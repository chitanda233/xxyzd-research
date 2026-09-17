// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 22932
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 22933
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 22934
{
	// Methods

	// RVA: 0x881F7AC Offset: 0x881B7AC VA: 0x881F7AC
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x881F8A4 Offset: 0x881B8A4 VA: 0x881F8A4
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public class AnimationTriggers // TypeDefIndex: 22935
{
	// Fields
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[SerializeField]
	[FormerlySerializedAs("normalTrigger")]
	private string m_NormalTrigger; // 0x10
	[FormerlySerializedAs("highlightedTrigger")]
	[SerializeField]
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	private string m_PressedTrigger; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_HighlightedTrigger")]
	private string m_SelectedTrigger; // 0x28
	[SerializeField]
	[FormerlySerializedAs("disabledTrigger")]
	private string m_DisabledTrigger; // 0x30

	// Properties
	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }

	// Methods

	// RVA: 0x881F8AC Offset: 0x881B8AC VA: 0x881F8AC
	public string get_normalTrigger() { }

	// RVA: 0x881F8B4 Offset: 0x881B8B4 VA: 0x881F8B4
	public void set_normalTrigger(string value) { }

	// RVA: 0x881F8BC Offset: 0x881B8BC VA: 0x881F8BC
	public string get_highlightedTrigger() { }

	// RVA: 0x881F8C4 Offset: 0x881B8C4 VA: 0x881F8C4
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x881F8CC Offset: 0x881B8CC VA: 0x881F8CC
	public string get_pressedTrigger() { }

	// RVA: 0x881F8D4 Offset: 0x881B8D4 VA: 0x881F8D4
	public void set_pressedTrigger(string value) { }

	// RVA: 0x881F8DC Offset: 0x881B8DC VA: 0x881F8DC
	public string get_selectedTrigger() { }

	// RVA: 0x881F8E4 Offset: 0x881B8E4 VA: 0x881F8E4
	public void set_selectedTrigger(string value) { }

	// RVA: 0x881F8EC Offset: 0x881B8EC VA: 0x881F8EC
	public string get_disabledTrigger() { }

	// RVA: 0x881F8F4 Offset: 0x881B8F4 VA: 0x881F8F4
	public void set_disabledTrigger(string value) { }

	// RVA: 0x881F8FC Offset: 0x881B8FC VA: 0x881F8FC
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Button.ButtonClickedEvent : UnityEvent // TypeDefIndex: 22936
{
	// Methods

	// RVA: 0x881FA8C Offset: 0x881BA8C VA: 0x881FA8C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Button.<OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22937
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Button <>4__this; // 0x20
	private float <fadeTime>5__2; // 0x28
	private float <elapsedTime>5__3; // 0x2C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x881FC4C Offset: 0x881BC4C VA: 0x881FC4C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x881FC74 Offset: 0x881BC74 VA: 0x881FC74 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x881FC78 Offset: 0x881BC78 VA: 0x881FC78 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x881FD78 Offset: 0x881BD78 VA: 0x881FD78 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x881FD80 Offset: 0x881BD80 VA: 0x881FD80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x881FDB8 Offset: 0x881BDB8 VA: 0x881FDB8 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Button", 30)]
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 22938
{
	// Fields
	[FormerlySerializedAs("onClick")]
	[SerializeField]
	private Button.ButtonClickedEvent m_OnClick; // 0x100

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x881F9F4 Offset: 0x881B9F4 VA: 0x881F9F4
	protected void .ctor() { }

	// RVA: 0x881FA94 Offset: 0x881BA94 VA: 0x881FA94
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x881FA9C Offset: 0x881BA9C VA: 0x881FA9C
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x881FAAC Offset: 0x881BAAC VA: 0x881FAAC
	private void Press() { }

	// RVA: 0x881FB44 Offset: 0x881BB44 VA: 0x881FB44 Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x881FB68 Offset: 0x881BB68 VA: 0x881FB68 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachine(typeof(Button.<OnFinishSubmit>d__9))]
	// RVA: 0x881FBE0 Offset: 0x881BBE0 VA: 0x881FBE0
	private IEnumerator OnFinishSubmit() { }
}

// Namespace: UnityEngine.UI
public enum CanvasUpdate // TypeDefIndex: 22939
{
	// Fields
	public int value__; // 0x0
	public const CanvasUpdate Prelayout = 0;
	public const CanvasUpdate Layout = 1;
	public const CanvasUpdate PostLayout = 2;
	public const CanvasUpdate PreRender = 3;
	public const CanvasUpdate LatePreRender = 4;
	public const CanvasUpdate MaxUpdateValue = 5;
}

// Namespace: UnityEngine.UI
public interface ICanvasElement // TypeDefIndex: 22940
{
	// Properties
	public abstract Transform transform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rebuild(CanvasUpdate executing);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Transform get_transform();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LayoutComplete();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GraphicUpdateComplete();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsDestroyed();
}

// Namespace: UnityEngine.UI
public class CanvasUpdateRegistry // TypeDefIndex: 22941
{
	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private string[] m_CanvasUpdateProfilerStrings; // 0x18
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

	// Properties
	public static CanvasUpdateRegistry instance { get; }

	// Methods

	// RVA: 0x881FDC0 Offset: 0x881BDC0 VA: 0x881FDC0
	protected void .ctor() { }

	// RVA: 0x8820000 Offset: 0x881C000 VA: 0x8820000
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x88200B0 Offset: 0x881C0B0 VA: 0x88200B0
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x8820180 Offset: 0x881C180 VA: 0x8820180
	private void CleanInvalidItems() { }

	// RVA: 0x8820464 Offset: 0x881C464 VA: 0x8820464
	private void PerformUpdate() { }

	// RVA: 0x8820C34 Offset: 0x881CC34 VA: 0x8820C34
	private static int ParentCount(Transform child) { }

	// RVA: 0x8820CF0 Offset: 0x881CCF0 VA: 0x8820CF0
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x8820E40 Offset: 0x881CE40 VA: 0x8820E40
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x8820F38 Offset: 0x881CF38 VA: 0x8820F38
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x8820EA0 Offset: 0x881CEA0 VA: 0x8820EA0
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x8820F98 Offset: 0x881CF98 VA: 0x8820F98
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x88210C8 Offset: 0x881D0C8 VA: 0x88210C8
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x8820FF8 Offset: 0x881CFF8 VA: 0x8820FF8
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x8821128 Offset: 0x881D128 VA: 0x8821128
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x8821460 Offset: 0x881D460 VA: 0x8821460
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x8821198 Offset: 0x881D198 VA: 0x8821198
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x88212FC Offset: 0x881D2FC VA: 0x88212FC
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x88214D0 Offset: 0x881D4D0 VA: 0x88214D0
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x8821634 Offset: 0x881D634 VA: 0x8821634
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x8821798 Offset: 0x881D798 VA: 0x8821798
	public static bool IsRebuildingLayout() { }

	// RVA: 0x88217F4 Offset: 0x881D7F4 VA: 0x88217F4
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x8821850 Offset: 0x881D850 VA: 0x8821850
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 22942
{
	// Fields
	[FormerlySerializedAs("normalColor")]
	[SerializeField]
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAs("highlightedColor")]
	[SerializeField]
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAs("pressedColor")]
	[SerializeField]
	private Color m_PressedColor; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_HighlightedColor")]
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAs("disabledColor")]
	[SerializeField]
	private Color m_DisabledColor; // 0x40
	[SerializeField]
	[Range(1, 5)]
	private float m_ColorMultiplier; // 0x50
	[SerializeField]
	[FormerlySerializedAs("fadeDuration")]
	private float m_FadeDuration; // 0x54
	public static ColorBlock defaultColorBlock; // 0x0

	// Properties
	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }

	// Methods

	// RVA: 0x88218E8 Offset: 0x881D8E8 VA: 0x88218E8
	public Color get_normalColor() { }

	// RVA: 0x88218F4 Offset: 0x881D8F4 VA: 0x88218F4
	public void set_normalColor(Color value) { }

	// RVA: 0x8821900 Offset: 0x881D900 VA: 0x8821900
	public Color get_highlightedColor() { }

	// RVA: 0x882190C Offset: 0x881D90C VA: 0x882190C
	public void set_highlightedColor(Color value) { }

	// RVA: 0x8821918 Offset: 0x881D918 VA: 0x8821918
	public Color get_pressedColor() { }

	// RVA: 0x8821924 Offset: 0x881D924 VA: 0x8821924
	public void set_pressedColor(Color value) { }

	// RVA: 0x8821930 Offset: 0x881D930 VA: 0x8821930
	public Color get_selectedColor() { }

	// RVA: 0x882193C Offset: 0x881D93C VA: 0x882193C
	public void set_selectedColor(Color value) { }

	// RVA: 0x8821948 Offset: 0x881D948 VA: 0x8821948
	public Color get_disabledColor() { }

	// RVA: 0x8821954 Offset: 0x881D954 VA: 0x8821954
	public void set_disabledColor(Color value) { }

	// RVA: 0x8821960 Offset: 0x881D960 VA: 0x8821960
	public float get_colorMultiplier() { }

	// RVA: 0x8821968 Offset: 0x881D968 VA: 0x8821968
	public void set_colorMultiplier(float value) { }

	// RVA: 0x8821970 Offset: 0x881D970 VA: 0x8821970
	public float get_fadeDuration() { }

	// RVA: 0x8821978 Offset: 0x881D978 VA: 0x8821978
	public void set_fadeDuration(float value) { }

	// RVA: 0x8821980 Offset: 0x881D980 VA: 0x8821980
	private static void .cctor() { }

	// RVA: 0x88219F8 Offset: 0x881D9F8 VA: 0x88219F8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8821AB8 Offset: 0x881DAB8 VA: 0x8821AB8 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x8821CB0 Offset: 0x881DCB0 VA: 0x8821CB0
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x8821D44 Offset: 0x881DD44 VA: 0x8821D44
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x8821DDC Offset: 0x881DDDC VA: 0x8821DDC Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UI
public class ClipperRegistry // TypeDefIndex: 22943
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x8821E48 Offset: 0x881DE48 VA: 0x8821E48
	protected void .ctor() { }

	// RVA: 0x8820AA4 Offset: 0x881CAA4 VA: 0x8820AA4
	public static ClipperRegistry get_instance() { }

	// RVA: 0x8820B28 Offset: 0x881CB28 VA: 0x8820B28
	public void Cull() { }

	// RVA: 0x8821ED0 Offset: 0x881DED0 VA: 0x8821ED0
	public static void Register(IClipper c) { }

	// RVA: 0x8821F40 Offset: 0x881DF40 VA: 0x8821F40
	public static void Unregister(IClipper c) { }

	// RVA: 0x8821F9C Offset: 0x881DF9C VA: 0x8821F9C
	public static void Disable(IClipper c) { }
}

// Namespace: UnityEngine.UI
public static class Clipping // TypeDefIndex: 22944
{
	// Methods

	// RVA: 0x8821FF8 Offset: 0x881DFF8 VA: 0x8821FF8
	public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect) { }
}

// Namespace: UnityEngine.UI
public interface IClipper // TypeDefIndex: 22945
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PerformClipping();
}

// Namespace: UnityEngine.UI
public interface IClippable // TypeDefIndex: 22946
{
	// Properties
	public abstract GameObject gameObject { get; }
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject get_gameObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RecalculateClipping();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract RectTransform get_rectTransform();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Cull(Rect clipRect, bool validRect);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetClipRect(Rect value, bool validRect);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetClipSoftness(Vector2 clipSoftness);
}

// Namespace: UnityEngine.UI
internal class RectangularVertexClipper // TypeDefIndex: 22947
{
	// Fields
	private readonly Vector3[] m_WorldCorners; // 0x10
	private readonly Vector3[] m_CanvasCorners; // 0x18

	// Methods

	// RVA: 0x88221D0 Offset: 0x881E1D0 VA: 0x88221D0
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

	// RVA: 0x8822328 Offset: 0x881E328 VA: 0x8822328
	public void .ctor() { }
}

// Namespace: 
public interface DefaultControls.IFactoryControls // TypeDefIndex: 22948
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject CreateGameObject(string name, Type[] components);
}

// Namespace: 
private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 22949
{
	// Fields
	public static DefaultControls.IFactoryControls Default; // 0x0

	// Methods

	// RVA: 0x8826F64 Offset: 0x8822F64 VA: 0x8826F64 Slot: 4
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x8826FD0 Offset: 0x8822FD0 VA: 0x8826FD0
	public void .ctor() { }

	// RVA: 0x8826FD8 Offset: 0x8822FD8 VA: 0x8826FD8
	private static void .cctor() { }
}

// Namespace: 
public struct DefaultControls.Resources // TypeDefIndex: 22950
{
	// Fields
	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30
}

// Namespace: UnityEngine.UI
public static class DefaultControls // TypeDefIndex: 22951
{
	// Fields
	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Properties
	public static DefaultControls.IFactoryControls factory { get; }

	// Methods

	// RVA: 0x88223A8 Offset: 0x881E3A8 VA: 0x88223A8
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x8822400 Offset: 0x881E400 VA: 0x8822400
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x8822560 Offset: 0x881E560 VA: 0x8822560
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x8822788 Offset: 0x881E788 VA: 0x8822788
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x8822864 Offset: 0x881E864 VA: 0x8822864
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x8822688 Offset: 0x881E688 VA: 0x8822688
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x88228C4 Offset: 0x881E8C4 VA: 0x88228C4
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x88229A8 Offset: 0x881E9A8 VA: 0x88229A8
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x8822FB4 Offset: 0x881EFB4 VA: 0x8822FB4
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x88233CC Offset: 0x881F3CC VA: 0x88233CC
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x8823578 Offset: 0x881F578 VA: 0x8823578
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x88236C0 Offset: 0x881F6C0 VA: 0x88236C0
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x8823808 Offset: 0x881F808 VA: 0x8823808
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x8823F0C Offset: 0x881FF0C VA: 0x8823F0C
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x88243C0 Offset: 0x88203C0 VA: 0x88243C0
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x8824970 Offset: 0x8820970 VA: 0x8824970
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x8824FC4 Offset: 0x8820FC4 VA: 0x8824FC4
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x8826558 Offset: 0x8822558 VA: 0x8826558
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x8826E80 Offset: 0x8822E80 VA: 0x8826E80
	private static void .cctor() { }
}

// Namespace: 
protected internal class Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 22952
{
	// Fields
	[SerializeField]
	private Text m_Text; // 0x20
	[SerializeField]
	private Image m_Image; // 0x28
	[SerializeField]
	private RectTransform m_RectTransform; // 0x30
	[SerializeField]
	private Toggle m_Toggle; // 0x38

	// Properties
	public Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x8829EA4 Offset: 0x8825EA4 VA: 0x8829EA4
	public Text get_text() { }

	// RVA: 0x8829EAC Offset: 0x8825EAC VA: 0x8829EAC
	public void set_text(Text value) { }

	// RVA: 0x8829EB4 Offset: 0x8825EB4 VA: 0x8829EB4
	public Image get_image() { }

	// RVA: 0x8829EBC Offset: 0x8825EBC VA: 0x8829EBC
	public void set_image(Image value) { }

	// RVA: 0x8829EC4 Offset: 0x8825EC4 VA: 0x8829EC4
	public RectTransform get_rectTransform() { }

	// RVA: 0x8829ECC Offset: 0x8825ECC VA: 0x8829ECC
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x8829ED4 Offset: 0x8825ED4 VA: 0x8829ED4
	public Toggle get_toggle() { }

	// RVA: 0x8829EDC Offset: 0x8825EDC VA: 0x8829EDC
	public void set_toggle(Toggle value) { }

	// RVA: 0x8829EE4 Offset: 0x8825EE4 VA: 0x8829EE4 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x8829F60 Offset: 0x8825F60 VA: 0x8829F60 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x882A00C Offset: 0x882600C VA: 0x882A00C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Dropdown.OptionData // TypeDefIndex: 22953
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Sprite m_Image; // 0x18

	// Properties
	public string text { get; set; }
	public Sprite image { get; set; }

	// Methods

	// RVA: 0x882A014 Offset: 0x8826014 VA: 0x882A014
	public string get_text() { }

	// RVA: 0x882A01C Offset: 0x882601C VA: 0x882A01C
	public void set_text(string value) { }

	// RVA: 0x882A024 Offset: 0x8826024 VA: 0x882A024
	public Sprite get_image() { }

	// RVA: 0x882A02C Offset: 0x882602C VA: 0x882A02C
	public void set_image(Sprite value) { }

	// RVA: 0x8826374 Offset: 0x8822374 VA: 0x8826374
	public void .ctor() { }

	// RVA: 0x88279E0 Offset: 0x88239E0 VA: 0x88279E0
	public void .ctor(string text) { }

	// RVA: 0x8827B78 Offset: 0x8823B78 VA: 0x8827B78
	public void .ctor(Sprite image) { }

	// RVA: 0x882A034 Offset: 0x8826034 VA: 0x882A034
	public void .ctor(string text, Sprite image) { }
}

// Namespace: 
[Serializable]
public class Dropdown.OptionDataList // TypeDefIndex: 22954
{
	// Fields
	[SerializeField]
	private List<Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x882A078 Offset: 0x8826078 VA: 0x882A078
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x882A080 Offset: 0x8826080 VA: 0x882A080
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x882736C Offset: 0x882336C VA: 0x882736C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 22955
{
	// Methods

	// RVA: 0x88273F4 Offset: 0x88233F4 VA: 0x88273F4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Dropdown.<>c__DisplayClass63_0 // TypeDefIndex: 22956
{
	// Fields
	public Dropdown.DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x8829038 Offset: 0x8825038 VA: 0x8829038
	public void .ctor() { }

	// RVA: 0x882A088 Offset: 0x8826088 VA: 0x882A088
	internal void <Show>b__0(bool x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Dropdown.<DelayedDestroyDropdownList>d__75 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22957
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public Dropdown <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x8829CCC Offset: 0x8825CCC VA: 0x8829CCC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x882A0AC Offset: 0x88260AC VA: 0x882A0AC Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x882A0B0 Offset: 0x88260B0 VA: 0x882A0B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x882A164 Offset: 0x8826164 VA: 0x882A164 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x882A16C Offset: 0x882616C VA: 0x882A16C Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x882A1A4 Offset: 0x88261A4 VA: 0x882A1A4 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Legacy/Dropdown", 102)]
[RequireComponent(typeof(RectTransform))]
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 22958
{
	// Fields
	[SerializeField]
	private RectTransform m_Template; // 0x100
	[SerializeField]
	private Text m_CaptionText; // 0x108
	[SerializeField]
	private Image m_CaptionImage; // 0x110
	[SerializeField]
	[Space]
	private Text m_ItemText; // 0x118
	[SerializeField]
	private Image m_ItemImage; // 0x120
	[Space]
	[SerializeField]
	private int m_Value; // 0x128
	[Space]
	[SerializeField]
	private Dropdown.OptionDataList m_Options; // 0x130
	[Space]
	[SerializeField]
	private Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField]
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private const int kHighSortingLayer = 30000;
	private static Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }

	// Methods

	// RVA: 0x8827040 Offset: 0x8823040 VA: 0x8827040
	public RectTransform get_template() { }

	// RVA: 0x88262F8 Offset: 0x88222F8 VA: 0x88262F8
	public void set_template(RectTransform value) { }

	// RVA: 0x8827048 Offset: 0x8823048 VA: 0x8827048
	public Text get_captionText() { }

	// RVA: 0x8826318 Offset: 0x8822318 VA: 0x8826318
	public void set_captionText(Text value) { }

	// RVA: 0x8827050 Offset: 0x8823050 VA: 0x8827050
	public Image get_captionImage() { }

	// RVA: 0x8827058 Offset: 0x8823058 VA: 0x8827058
	public void set_captionImage(Image value) { }

	// RVA: 0x8827078 Offset: 0x8823078 VA: 0x8827078
	public Text get_itemText() { }

	// RVA: 0x8826338 Offset: 0x8822338 VA: 0x8826338
	public void set_itemText(Text value) { }

	// RVA: 0x8827080 Offset: 0x8823080 VA: 0x8827080
	public Image get_itemImage() { }

	// RVA: 0x8827088 Offset: 0x8823088 VA: 0x8827088
	public void set_itemImage(Image value) { }

	// RVA: 0x8826358 Offset: 0x8822358 VA: 0x8826358
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x88270A8 Offset: 0x88230A8 VA: 0x88270A8
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x88270D0 Offset: 0x88230D0 VA: 0x88270D0
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x88270D8 Offset: 0x88230D8 VA: 0x88270D8
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0x88270E8 Offset: 0x88230E8 VA: 0x88270E8
	public float get_alphaFadeSpeed() { }

	// RVA: 0x88270F0 Offset: 0x88230F0 VA: 0x88270F0
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x88270F8 Offset: 0x88230F8 VA: 0x88270F8
	public int get_value() { }

	// RVA: 0x8827100 Offset: 0x8823100 VA: 0x8827100
	public void set_value(int value) { }

	// RVA: 0x882723C Offset: 0x882323C VA: 0x882723C
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x8827108 Offset: 0x8823108 VA: 0x8827108
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x8827244 Offset: 0x8823244 VA: 0x8827244
	protected void .ctor() { }

	// RVA: 0x882743C Offset: 0x882343C VA: 0x882743C Slot: 4
	protected override void Awake() { }

	// RVA: 0x8827538 Offset: 0x8823538 VA: 0x8827538 Slot: 6
	protected override void Start() { }

	// RVA: 0x88275EC Offset: 0x88235EC VA: 0x88275EC Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x882637C Offset: 0x882237C VA: 0x882637C
	public void RefreshShownValue() { }

	// RVA: 0x8827810 Offset: 0x8823810 VA: 0x8827810
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x8827878 Offset: 0x8823878 VA: 0x8827878
	public void AddOptions(List<string> options) { }

	// RVA: 0x8827A10 Offset: 0x8823A10 VA: 0x8827A10
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x8827BA8 Offset: 0x8823BA8 VA: 0x8827BA8
	public void ClearOptions() { }

	// RVA: 0x8827C20 Offset: 0x8823C20 VA: 0x8827C20
	private void SetupTemplate(Canvas rootCanvas) { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457447C Offset: 0x457047C VA: 0x457447C
	|-Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x88282E4 Offset: 0x88242E4 VA: 0x88282E4 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x8828F24 Offset: 0x8824F24 VA: 0x8828F24 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x8828F28 Offset: 0x8824F28 VA: 0x8828F28 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x88282E8 Offset: 0x88242E8 VA: 0x88282E8
	public void Show() { }

	// RVA: 0x882944C Offset: 0x882544C VA: 0x882944C Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x8829990 Offset: 0x8825990 VA: 0x8829990 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x88299E8 Offset: 0x88259E8 VA: 0x88299E8 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x8829A54 Offset: 0x8825A54 VA: 0x8829A54 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x8829AAC Offset: 0x8825AAC VA: 0x8829AAC Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x8829B18 Offset: 0x8825B18 VA: 0x8829B18 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x8829040 Offset: 0x8825040 VA: 0x8829040
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x8829B1C Offset: 0x8825B1C VA: 0x8829B1C
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x882932C Offset: 0x882532C VA: 0x882932C
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x8829B9C Offset: 0x8825B9C VA: 0x8829B9C
	private void SetAlpha(float alpha) { }

	// RVA: 0x8828F2C Offset: 0x8824F2C VA: 0x8828F2C
	public void Hide() { }

	[IteratorStateMachine(typeof(Dropdown.<DelayedDestroyDropdownList>d__75))]
	// RVA: 0x8829C50 Offset: 0x8825C50 VA: 0x8829C50
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x8827690 Offset: 0x8823690 VA: 0x8827690
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x8829CF4 Offset: 0x8825CF4 VA: 0x8829CF4
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x8829E28 Offset: 0x8825E28 VA: 0x8829E28
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 22959
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("font")]
	private Font m_Font; // 0x10
	[SerializeField]
	[FormerlySerializedAs("fontSize")]
	private int m_FontSize; // 0x18
	[FormerlySerializedAs("fontStyle")]
	[SerializeField]
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField]
	private bool m_BestFit; // 0x20
	[SerializeField]
	private int m_MinSize; // 0x24
	[SerializeField]
	private int m_MaxSize; // 0x28
	[SerializeField]
	[FormerlySerializedAs("alignment")]
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField]
	private bool m_AlignByGeometry; // 0x30
	[FormerlySerializedAs("richText")]
	[SerializeField]
	private bool m_RichText; // 0x31
	[SerializeField]
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField]
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField]
	private float m_LineSpacing; // 0x3C

	// Properties
	public static FontData defaultFontData { get; }
	public Font font { get; set; }
	public int fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public bool bestFit { get; set; }
	public int minSize { get; set; }
	public int maxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public bool richText { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }

	// Methods

	// RVA: 0x882A1AC Offset: 0x88261AC VA: 0x882A1AC
	public static FontData get_defaultFontData() { }

	// RVA: 0x882A244 Offset: 0x8826244 VA: 0x882A244
	public Font get_font() { }

	// RVA: 0x882A24C Offset: 0x882624C VA: 0x882A24C
	public void set_font(Font value) { }

	// RVA: 0x882A254 Offset: 0x8826254 VA: 0x882A254
	public int get_fontSize() { }

	// RVA: 0x882A25C Offset: 0x882625C VA: 0x882A25C
	public void set_fontSize(int value) { }

	// RVA: 0x882A264 Offset: 0x8826264 VA: 0x882A264
	public FontStyle get_fontStyle() { }

	// RVA: 0x882A26C Offset: 0x882626C VA: 0x882A26C
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x882A274 Offset: 0x8826274 VA: 0x882A274
	public bool get_bestFit() { }

	// RVA: 0x882A27C Offset: 0x882627C VA: 0x882A27C
	public void set_bestFit(bool value) { }

	// RVA: 0x882A288 Offset: 0x8826288 VA: 0x882A288
	public int get_minSize() { }

	// RVA: 0x882A290 Offset: 0x8826290 VA: 0x882A290
	public void set_minSize(int value) { }

	// RVA: 0x882A298 Offset: 0x8826298 VA: 0x882A298
	public int get_maxSize() { }

	// RVA: 0x882A2A0 Offset: 0x88262A0 VA: 0x882A2A0
	public void set_maxSize(int value) { }

	// RVA: 0x882A2A8 Offset: 0x88262A8 VA: 0x882A2A8
	public TextAnchor get_alignment() { }

	// RVA: 0x882A2B0 Offset: 0x88262B0 VA: 0x882A2B0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x882A2B8 Offset: 0x88262B8 VA: 0x882A2B8
	public bool get_alignByGeometry() { }

	// RVA: 0x882A2C0 Offset: 0x88262C0 VA: 0x882A2C0
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x882A2CC Offset: 0x88262CC VA: 0x882A2CC
	public bool get_richText() { }

	// RVA: 0x882A2D4 Offset: 0x88262D4 VA: 0x882A2D4
	public void set_richText(bool value) { }

	// RVA: 0x882A2E0 Offset: 0x88262E0 VA: 0x882A2E0
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x882A2E8 Offset: 0x88262E8 VA: 0x882A2E8
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x882A2F0 Offset: 0x88262F0 VA: 0x882A2F0
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x882A2F8 Offset: 0x88262F8 VA: 0x882A2F8
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x882A300 Offset: 0x8826300 VA: 0x882A300
	public float get_lineSpacing() { }

	// RVA: 0x882A308 Offset: 0x8826308 VA: 0x882A308
	public void set_lineSpacing(float value) { }

	// RVA: 0x882A310 Offset: 0x8826310 VA: 0x882A310 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x882A314 Offset: 0x8826314 VA: 0x882A314 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x882A23C Offset: 0x882623C VA: 0x882A23C
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public static class FontUpdateTracker // TypeDefIndex: 22960
{
	// Fields
	private static Dictionary<Font, HashSet<Text>> m_Tracked; // 0x0

	// Methods

	// RVA: 0x882A358 Offset: 0x8826358 VA: 0x882A358
	public static void TrackText(Text t) { }

	// RVA: 0x882A5A0 Offset: 0x88265A0 VA: 0x882A5A0
	private static void RebuildForFont(Font f) { }

	// RVA: 0x882A744 Offset: 0x8826744 VA: 0x882A744
	public static void UntrackText(Text t) { }

	// RVA: 0x882A94C Offset: 0x882694C VA: 0x882A94C
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[ExecuteAlways]
public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 22961
{
	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[FormerlySerializedAs("m_Mat")]
	[SerializeField]
	protected Material m_Material; // 0x20
	[SerializeField]
	private Color m_Color; // 0x28
	protected bool m_SkipLayoutUpdate; // 0x38
	protected bool m_SkipMaterialUpdate; // 0x39
	[SerializeField]
	private bool m_RaycastTarget; // 0x3A
	private bool m_RaycastTargetCache; // 0x3B
	[SerializeField]
	private Vector4 m_RaycastPadding; // 0x3C
	private RectTransform m_RectTransform; // 0x50
	private CanvasRenderer m_CanvasRenderer; // 0x58
	private Canvas m_Canvas; // 0x60
	private bool m_VertsDirty; // 0x68
	private bool m_MaterialDirty; // 0x69
	protected UnityAction m_OnDirtyLayoutCallback; // 0x70
	protected UnityAction m_OnDirtyVertsCallback; // 0x78
	protected UnityAction m_OnDirtyMaterialCallback; // 0x80
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x88
	protected Vector2[] m_CachedUvs; // 0x90
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; // 0x98
	[CompilerGenerated]
	private bool <useLegacyMeshGeneration>k__BackingField; // 0xA0

	// Properties
	public static Material defaultGraphicMaterial { get; }
	public virtual Color color { get; set; }
	public virtual bool raycastTarget { get; set; }
	public Vector4 raycastPadding { get; set; }
	protected bool useLegacyMeshGeneration { get; set; }
	public int depth { get; }
	public RectTransform rectTransform { get; }
	public Canvas canvas { get; }
	public CanvasRenderer canvasRenderer { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Material material { get; set; }
	public virtual Material materialForRendering { get; }
	public virtual Texture mainTexture { get; }
	protected static Mesh workerMesh { get; }

	// Methods

	// RVA: 0x882A9E4 Offset: 0x88269E4 VA: 0x882A9E4
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x882AAD0 Offset: 0x8826AD0 VA: 0x882AAD0 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x882AADC Offset: 0x8826ADC VA: 0x882AADC Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x882AB14 Offset: 0x8826B14 VA: 0x882AB14 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x882AB1C Offset: 0x8826B1C VA: 0x882AB1C Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x882AFD4 Offset: 0x8826FD4 VA: 0x882AFD4
	public Vector4 get_raycastPadding() { }

	// RVA: 0x882AFE0 Offset: 0x8826FE0 VA: 0x882AFE0
	public void set_raycastPadding(Vector4 value) { }

	[CompilerGenerated]
	// RVA: 0x882AFEC Offset: 0x8826FEC VA: 0x882AFEC
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGenerated]
	// RVA: 0x882AFF4 Offset: 0x8826FF4 VA: 0x882AFF4
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x882B000 Offset: 0x8827000 VA: 0x882B000
	protected void .ctor() { }

	// RVA: 0x882B0CC Offset: 0x88270CC VA: 0x882B0CC Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x882B214 Offset: 0x8827214 VA: 0x882B214 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x882B320 Offset: 0x8827320 VA: 0x882B320 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x882B3B4 Offset: 0x88273B4 VA: 0x882B3B4 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x882B13C Offset: 0x882713C VA: 0x882B13C
	public void SetRaycastDirty() { }

	// RVA: 0x882B448 Offset: 0x8827448 VA: 0x882B448 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x882B4F4 Offset: 0x88274F4 VA: 0x882B4F4 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x882B740 Offset: 0x8827740 VA: 0x882B740 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x882BB84 Offset: 0x8827B84 VA: 0x882BB84
	public int get_depth() { }

	// RVA: 0x882B2B4 Offset: 0x88272B4 VA: 0x882B2B4 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x882ABF8 Offset: 0x8826BF8 VA: 0x882ABF8
	public Canvas get_canvas() { }

	// RVA: 0x882B800 Offset: 0x8827800 VA: 0x882B800
	private void CacheCanvas() { }

	// RVA: 0x882BBA0 Offset: 0x8827BA0 VA: 0x882BBA0
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x882BC54 Offset: 0x8827C54 VA: 0x882BC54 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x882BCA0 Offset: 0x8827CA0 VA: 0x882BCA0 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x882BD28 Offset: 0x8827D28 VA: 0x882BD28 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x882BDD0 Offset: 0x8827DD0 VA: 0x882BDD0 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x882BF94 Offset: 0x8827F94 VA: 0x882BF94 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x882BFEC Offset: 0x8827FEC VA: 0x882BFEC Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x882C124 Offset: 0x8828124 VA: 0x882C124 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x882C3EC Offset: 0x88283EC VA: 0x882C3EC Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x882C500 Offset: 0x8828500 VA: 0x882C500 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x882C644 Offset: 0x8828644 VA: 0x882C644 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x882C6D0 Offset: 0x88286D0 VA: 0x882C6D0 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x882C7B4 Offset: 0x88287B4 VA: 0x882C7B4 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x882C7B8 Offset: 0x88287B8 VA: 0x882C7B8 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x882C7BC Offset: 0x88287BC VA: 0x882C7BC Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x882C874 Offset: 0x8828874 VA: 0x882C874 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x882CBEC Offset: 0x8828BEC VA: 0x882CBEC
	private void DoMeshGeneration() { }

	// RVA: 0x882C884 Offset: 0x8828884 VA: 0x882C884
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x882CF88 Offset: 0x8828F88 VA: 0x882CF88
	protected static Mesh get_workerMesh() { }

	[Obsolete("Use OnPopulateMesh instead.", True)]
	[EditorBrowsable(1)]
	// RVA: 0x882D0B8 Offset: 0x88290B8 VA: 0x882D0B8 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
	// RVA: 0x882D0BC Offset: 0x88290BC VA: 0x882D0BC Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x882D154 Offset: 0x8829154 VA: 0x882D154 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x882D3DC Offset: 0x88293DC VA: 0x882D3DC Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x882D3EC Offset: 0x88293EC VA: 0x882D3EC Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x882D3F0 Offset: 0x88293F0 VA: 0x882D3F0 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x882D87C Offset: 0x882987C VA: 0x882D87C
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x882D2B0 Offset: 0x88292B0 VA: 0x882D2B0
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x882D9BC Offset: 0x88299BC VA: 0x882D9BC Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x882D9D8 Offset: 0x88299D8 VA: 0x882D9D8 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x882DC64 Offset: 0x8829C64 VA: 0x882DC64
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x882DC78 Offset: 0x8829C78 VA: 0x882DC78 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x882DD14 Offset: 0x8829D14 VA: 0x882DD14
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x882DDA4 Offset: 0x8829DA4 VA: 0x882DDA4
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x882DE34 Offset: 0x8829E34 VA: 0x882DE34
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x882DEC4 Offset: 0x8829EC4 VA: 0x882DEC4
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x882DF54 Offset: 0x8829F54 VA: 0x882DF54
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x882DFE4 Offset: 0x8829FE4 VA: 0x882DFE4
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x882E074 Offset: 0x882A074 VA: 0x882E074
	private static void .cctor() { }

	// RVA: 0x882E118 Offset: 0x882A118 VA: 0x882E118 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum GraphicRaycaster.BlockingObjects // TypeDefIndex: 22962
{
	// Fields
	public int value__; // 0x0
	public const GraphicRaycaster.BlockingObjects None = 0;
	public const GraphicRaycaster.BlockingObjects TwoD = 1;
	public const GraphicRaycaster.BlockingObjects ThreeD = 2;
	public const GraphicRaycaster.BlockingObjects All = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GraphicRaycaster.<>c // TypeDefIndex: 22963
{
	// Fields
	public static readonly GraphicRaycaster.<>c <>9; // 0x0
	public static Comparison<Graphic> <>9__27_0; // 0x8

	// Methods

	// RVA: 0x882F720 Offset: 0x882B720 VA: 0x882F720
	private static void .cctor() { }

	// RVA: 0x882F788 Offset: 0x882B788 VA: 0x882F788
	public void .ctor() { }

	// RVA: 0x882F790 Offset: 0x882B790 VA: 0x882F790
	internal int <Raycast>b__27_0(Graphic g1, Graphic g2) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Event/Graphic Raycaster")]
[RequireComponent(typeof(Canvas))]
public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 22964
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	[SerializeField]
	[FormerlySerializedAs("ignoreReversedGraphics")]
	private bool m_IgnoreReversedGraphics; // 0x28
	[FormerlySerializedAs("blockingObjects")]
	[SerializeField]
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; // 0x2C
	[SerializeField]
	protected LayerMask m_BlockingMask; // 0x30
	private Canvas m_Canvas; // 0x38
	private List<Graphic> m_RaycastResults; // 0x40
	private static readonly List<Graphic> s_SortedGraphics; // 0x0

	// Properties
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	public LayerMask blockingMask { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x882E120 Offset: 0x882A120 VA: 0x882E120 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x882E210 Offset: 0x882A210 VA: 0x882E210 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x882E264 Offset: 0x882A264 VA: 0x882E264
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x882E26C Offset: 0x882A26C VA: 0x882E26C
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x882E278 Offset: 0x882A278 VA: 0x882E278
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x882E280 Offset: 0x882A280 VA: 0x882E280
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x882E288 Offset: 0x882A288 VA: 0x882E288
	public LayerMask get_blockingMask() { }

	// RVA: 0x882E290 Offset: 0x882A290 VA: 0x882E290
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x882E298 Offset: 0x882A298 VA: 0x882E298
	protected void .ctor() { }

	// RVA: 0x882E168 Offset: 0x882A168 VA: 0x882E168
	private Canvas get_canvas() { }

	// RVA: 0x882E338 Offset: 0x882A338 VA: 0x882E338 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x882F5C0 Offset: 0x882B5C0 VA: 0x882F5C0 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x882F040 Offset: 0x882B040 VA: 0x882F040
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x882F688 Offset: 0x882B688 VA: 0x882F688
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
public class GraphicRegistry // TypeDefIndex: 22965
{
	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x882F7D8 Offset: 0x882B7D8 VA: 0x882F7D8
	protected void .ctor() { }

	// RVA: 0x882F998 Offset: 0x882B998 VA: 0x882F998
	public static GraphicRegistry get_instance() { }

	// RVA: 0x882B998 Offset: 0x8827998 VA: 0x882B998
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x882ADE8 Offset: 0x8826DE8 VA: 0x882ADE8
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x882B59C Offset: 0x882759C VA: 0x882B59C
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x882AC6C Offset: 0x8826C6C VA: 0x882AC6C
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x882C26C Offset: 0x882826C VA: 0x882C26C
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x882FA48 Offset: 0x882BA48 VA: 0x882FA48
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x882FBC8 Offset: 0x882BBC8 VA: 0x882FBC8
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x882EF84 Offset: 0x882AF84 VA: 0x882EF84
	public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x882FC84 Offset: 0x882BC84 VA: 0x882FC84
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Not supported anymore")]
internal interface IGraphicEnabledDisabled // TypeDefIndex: 22966
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSiblingGraphicEnabledDisabled();
}

// Namespace: 
public enum Image.Type // TypeDefIndex: 22967
{
	// Fields
	public int value__; // 0x0
	public const Image.Type Simple = 0;
	public const Image.Type Sliced = 1;
	public const Image.Type Tiled = 2;
	public const Image.Type Filled = 3;
}

// Namespace: 
public enum Image.FillMethod // TypeDefIndex: 22968
{
	// Fields
	public int value__; // 0x0
	public const Image.FillMethod Horizontal = 0;
	public const Image.FillMethod Vertical = 1;
	public const Image.FillMethod Radial90 = 2;
	public const Image.FillMethod Radial180 = 3;
	public const Image.FillMethod Radial360 = 4;
}

// Namespace: 
public enum Image.OriginHorizontal // TypeDefIndex: 22969
{
	// Fields
	public int value__; // 0x0
	public const Image.OriginHorizontal Left = 0;
	public const Image.OriginHorizontal Right = 1;
}

// Namespace: 
public enum Image.OriginVertical // TypeDefIndex: 22970
{
	// Fields
	public int value__; // 0x0
	public const Image.OriginVertical Bottom = 0;
	public const Image.OriginVertical Top = 1;
}

// Namespace: 
public enum Image.Origin90 // TypeDefIndex: 22971
{
	// Fields
	public int value__; // 0x0
	public const Image.Origin90 BottomLeft = 0;
	public const Image.Origin90 TopLeft = 1;
	public const Image.Origin90 TopRight = 2;
	public const Image.Origin90 BottomRight = 3;
}

// Namespace: 
public enum Image.Origin180 // TypeDefIndex: 22972
{
	// Fields
	public int value__; // 0x0
	public const Image.Origin180 Bottom = 0;
	public const Image.Origin180 Left = 1;
	public const Image.Origin180 Top = 2;
	public const Image.Origin180 Right = 3;
}

// Namespace: 
public enum Image.Origin360 // TypeDefIndex: 22973
{
	// Fields
	public int value__; // 0x0
	public const Image.Origin360 Bottom = 0;
	public const Image.Origin360 Right = 1;
	public const Image.Origin360 Top = 2;
	public const Image.Origin360 Left = 3;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Image", 11)]
[RequireComponent(typeof(CanvasRenderer))]
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 22974
{
	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	[SerializeField]
	[FormerlySerializedAs("m_Frame")]
	private Sprite m_Sprite; // 0xD8
	private Sprite m_OverrideSprite; // 0xE0
	[SerializeField]
	private Image.Type m_Type; // 0xE8
	[SerializeField]
	private bool m_PreserveAspect; // 0xEC
	[SerializeField]
	private bool m_FillCenter; // 0xED
	[SerializeField]
	private Image.FillMethod m_FillMethod; // 0xF0
	[SerializeField]
	[Range(0, 1)]
	private float m_FillAmount; // 0xF4
	[SerializeField]
	private bool m_FillClockwise; // 0xF8
	[SerializeField]
	private int m_FillOrigin; // 0xFC
	private float m_AlphaHitTestMinimumThreshold; // 0x100
	private bool m_Tracked; // 0x104
	[SerializeField]
	private bool m_UseSpriteMesh; // 0x105
	[SerializeField]
	private float m_PixelsPerUnitMultiplier; // 0x108
	private float m_CachedReferencePixelsPerUnit; // 0x10C
	private static readonly Vector2[] s_VertScratch; // 0x8
	private static readonly Vector2[] s_UVScratch; // 0x10
	private static readonly Vector3[] s_Xy; // 0x18
	private static readonly Vector3[] s_Uv; // 0x20
	private static List<Image> m_TrackedTexturelessImages; // 0x28
	private static bool s_Initialized; // 0x30

	// Properties
	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	private Sprite activeSprite { get; }
	public Image.Type type { get; set; }
	public bool preserveAspect { get; set; }
	public bool fillCenter { get; set; }
	public Image.FillMethod fillMethod { get; set; }
	public float fillAmount { get; set; }
	public bool fillClockwise { get; set; }
	public int fillOrigin { get; set; }
	[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
	public float eventAlphaThreshold { get; set; }
	public float alphaHitTestMinimumThreshold { get; set; }
	public bool useSpriteMesh { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnitMultiplier { get; set; }
	public float pixelsPerUnit { get; }
	protected float multipliedPixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x882FD14 Offset: 0x882BD14 VA: 0x882FD14
	public Sprite get_sprite() { }

	// RVA: 0x8822C70 Offset: 0x881EC70 VA: 0x8822C70
	public void set_sprite(Sprite value) { }

	// RVA: 0x882FE98 Offset: 0x882BE98 VA: 0x882FE98
	public void DisableSpriteOptimizations() { }

	// RVA: 0x882FEA0 Offset: 0x882BEA0 VA: 0x882FEA0
	public Sprite get_overrideSprite() { }

	// RVA: 0x882FF1C Offset: 0x882BF1C VA: 0x882FF1C
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x882FEA4 Offset: 0x882BEA4 VA: 0x882FEA4
	private Sprite get_activeSprite() { }

	// RVA: 0x882FFA4 Offset: 0x882BFA4 VA: 0x882FFA4
	public Image.Type get_type() { }

	// RVA: 0x8822F34 Offset: 0x881EF34 VA: 0x8822F34
	public void set_type(Image.Type value) { }

	// RVA: 0x882FFAC Offset: 0x882BFAC VA: 0x882FFAC
	public bool get_preserveAspect() { }

	// RVA: 0x882FFB4 Offset: 0x882BFB4 VA: 0x882FFB4
	public void set_preserveAspect(bool value) { }

	// RVA: 0x8830034 Offset: 0x882C034 VA: 0x8830034
	public bool get_fillCenter() { }

	// RVA: 0x883003C Offset: 0x882C03C VA: 0x883003C
	public void set_fillCenter(bool value) { }

	// RVA: 0x88300BC Offset: 0x882C0BC VA: 0x88300BC
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x88300C4 Offset: 0x882C0C4 VA: 0x88300C4
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x883013C Offset: 0x882C13C VA: 0x883013C
	public float get_fillAmount() { }

	// RVA: 0x8830144 Offset: 0x882C144 VA: 0x8830144
	public void set_fillAmount(float value) { }

	// RVA: 0x88301D4 Offset: 0x882C1D4 VA: 0x88301D4
	public bool get_fillClockwise() { }

	// RVA: 0x88301DC Offset: 0x882C1DC VA: 0x88301DC
	public void set_fillClockwise(bool value) { }

	// RVA: 0x883025C Offset: 0x882C25C VA: 0x883025C
	public int get_fillOrigin() { }

	// RVA: 0x8830264 Offset: 0x882C264 VA: 0x8830264
	public void set_fillOrigin(int value) { }

	// RVA: 0x88302E4 Offset: 0x882C2E4 VA: 0x88302E4
	public float get_eventAlphaThreshold() { }

	// RVA: 0x88302F4 Offset: 0x882C2F4 VA: 0x88302F4
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x8830440 Offset: 0x882C440 VA: 0x8830440
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x8830300 Offset: 0x882C300 VA: 0x8830300
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x8830448 Offset: 0x882C448 VA: 0x8830448
	public bool get_useSpriteMesh() { }

	// RVA: 0x8830450 Offset: 0x882C450 VA: 0x8830450
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x88304D0 Offset: 0x882C4D0 VA: 0x88304D0
	protected void .ctor() { }

	// RVA: 0x8830510 Offset: 0x882C510 VA: 0x8830510
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x88305FC Offset: 0x882C5FC VA: 0x88305FC Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x8830774 Offset: 0x882C774 VA: 0x8830774
	public bool get_hasBorder() { }

	// RVA: 0x883082C Offset: 0x882C82C VA: 0x883082C
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x8830834 Offset: 0x882C834 VA: 0x8830834
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x8830854 Offset: 0x882C854 VA: 0x8830854
	public float get_pixelsPerUnit() { }

	// RVA: 0x8830948 Offset: 0x882C948 VA: 0x8830948
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x8830964 Offset: 0x882C964 VA: 0x8830964 Slot: 32
	public override Material get_material() { }

	// RVA: 0x8830A90 Offset: 0x882CA90 VA: 0x8830A90 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x8830A94 Offset: 0x882CA94 VA: 0x8830A94 Slot: 77
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x8830A98 Offset: 0x882CA98 VA: 0x8830A98 Slot: 78
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x8830AE8 Offset: 0x882CAE8 VA: 0x8830AE8
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x8830B7C Offset: 0x882CB7C VA: 0x8830B7C
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x8830F2C Offset: 0x882CF2C VA: 0x8830F2C Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x883106C Offset: 0x882D06C VA: 0x883106C Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x882FDAC Offset: 0x882BDAC VA: 0x882FDAC
	private void TrackSprite() { }

	// RVA: 0x88334B4 Offset: 0x882F4B4 VA: 0x88334B4 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x88334D0 Offset: 0x882F4D0 VA: 0x88334D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x88335C4 Offset: 0x882F5C4 VA: 0x88335C4 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x88336B8 Offset: 0x882F6B8 VA: 0x88336B8 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x88311B0 Offset: 0x882D1B0 VA: 0x88311B0
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x8831474 Offset: 0x882D474 VA: 0x8831474
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x8831754 Offset: 0x882D754 VA: 0x8831754
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x8831D14 Offset: 0x882DD14 VA: 0x8831D14
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x88339D4 Offset: 0x882F9D4 VA: 0x88339D4
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x8833880 Offset: 0x882F880 VA: 0x8833880
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x88337C0 Offset: 0x882F7C0 VA: 0x88337C0
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x8832A6C Offset: 0x882EA6C VA: 0x8832A6C
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x8833AB8 Offset: 0x882FAB8 VA: 0x8833AB8
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x8833BD8 Offset: 0x882FBD8 VA: 0x8833BD8
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x8834004 Offset: 0x8830004 VA: 0x8834004 Slot: 79
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x8834008 Offset: 0x8830008 VA: 0x8834008 Slot: 80
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x883400C Offset: 0x883000C VA: 0x883400C Slot: 81
	public virtual float get_minWidth() { }

	// RVA: 0x8834014 Offset: 0x8830014 VA: 0x8834014 Slot: 82
	public virtual float get_preferredWidth() { }

	// RVA: 0x88340DC Offset: 0x88300DC VA: 0x88340DC Slot: 83
	public virtual float get_flexibleWidth() { }

	// RVA: 0x88340E4 Offset: 0x88300E4 VA: 0x88340E4 Slot: 84
	public virtual float get_minHeight() { }

	// RVA: 0x88340EC Offset: 0x88300EC VA: 0x88340EC Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x88341B4 Offset: 0x88301B4 VA: 0x88341B4 Slot: 86
	public virtual float get_flexibleHeight() { }

	// RVA: 0x88341BC Offset: 0x88301BC VA: 0x88341BC Slot: 87
	public virtual int get_layoutPriority() { }

	// RVA: 0x88341C4 Offset: 0x88301C4 VA: 0x88341C4 Slot: 88
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x8834550 Offset: 0x8830550 VA: 0x8834550
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x88347A8 Offset: 0x88307A8 VA: 0x88347A8
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x8833354 Offset: 0x882F354 VA: 0x8833354
	private static void TrackImage(Image g) { }

	// RVA: 0x8833544 Offset: 0x882F544 VA: 0x8833544
	private static void UnTrackImage(Image g) { }

	// RVA: 0x8834950 Offset: 0x8830950 VA: 0x8834950 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x8834988 Offset: 0x8830988 VA: 0x8834988
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x882FD1C Offset: 0x882BD1C VA: 0x882FD1C
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	[CompilerGenerated]
	// RVA: 0x8834AF4 Offset: 0x8830AF4 VA: 0x8834AF4
	private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Not supported anymore.", True)]
[EditorBrowsable(1)]
public interface IMask // TypeDefIndex: 22975
{
	// Properties
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract RectTransform get_rectTransform();
}

// Namespace: UnityEngine.UI
public interface IMaskable // TypeDefIndex: 22976
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RecalculateMasking();
}

// Namespace: 
public enum InputField.ContentType // TypeDefIndex: 22977
{
	// Fields
	public int value__; // 0x0
	public const InputField.ContentType Standard = 0;
	public const InputField.ContentType Autocorrected = 1;
	public const InputField.ContentType IntegerNumber = 2;
	public const InputField.ContentType DecimalNumber = 3;
	public const InputField.ContentType Alphanumeric = 4;
	public const InputField.ContentType Name = 5;
	public const InputField.ContentType EmailAddress = 6;
	public const InputField.ContentType Password = 7;
	public const InputField.ContentType Pin = 8;
	public const InputField.ContentType Custom = 9;
}

// Namespace: 
public enum InputField.InputType // TypeDefIndex: 22978
{
	// Fields
	public int value__; // 0x0
	public const InputField.InputType Standard = 0;
	public const InputField.InputType AutoCorrect = 1;
	public const InputField.InputType Password = 2;
}

// Namespace: 
public enum InputField.CharacterValidation // TypeDefIndex: 22979
{
	// Fields
	public int value__; // 0x0
	public const InputField.CharacterValidation None = 0;
	public const InputField.CharacterValidation Integer = 1;
	public const InputField.CharacterValidation Decimal = 2;
	public const InputField.CharacterValidation Alphanumeric = 3;
	public const InputField.CharacterValidation Name = 4;
	public const InputField.CharacterValidation EmailAddress = 5;
}

// Namespace: 
public enum InputField.LineType // TypeDefIndex: 22980
{
	// Fields
	public int value__; // 0x0
	public const InputField.LineType SingleLine = 0;
	public const InputField.LineType MultiLineSubmit = 1;
	public const InputField.LineType MultiLineNewline = 2;
}

// Namespace: 
public sealed class InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 22981
{
	// Methods

	// RVA: 0x89824EC Offset: 0x897E4EC VA: 0x89824EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x898B41C Offset: 0x898741C VA: 0x898B41C Slot: 13
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x898B430 Offset: 0x8987430 VA: 0x898B430 Slot: 14
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x898B4F0 Offset: 0x89874F0 VA: 0x898B4F0 Slot: 15
	public virtual char EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Serializable]
public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 22982
{
	// Methods

	// RVA: 0x8981DA4 Offset: 0x897DDA4 VA: 0x8981DA4
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InputField.EndEditEvent : UnityEvent<string> // TypeDefIndex: 22983
{
	// Methods

	// RVA: 0x8981DEC Offset: 0x897DDEC VA: 0x8981DEC
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 22984
{
	// Methods

	// RVA: 0x8981E34 Offset: 0x897DE34 VA: 0x8981E34
	public void .ctor() { }
}

// Namespace: 
protected enum InputField.EditState // TypeDefIndex: 22985
{
	// Fields
	public int value__; // 0x0
	public const InputField.EditState Continue = 0;
	public const InputField.EditState Finish = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class InputField.<CaretBlink>d__172 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22986
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x8984104 Offset: 0x8980104 VA: 0x8984104
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x898B518 Offset: 0x8987518 VA: 0x898B518 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x898B51C Offset: 0x898751C VA: 0x898B51C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x898B640 Offset: 0x8987640 VA: 0x898B640 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x898B648 Offset: 0x8987648 VA: 0x898B648 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x898B680 Offset: 0x8987680 VA: 0x898B680 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InputField.<MouseDragOutsideRect>d__196 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22987
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PointerEventData eventData; // 0x20
	public InputField <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x8986B9C Offset: 0x8982B9C VA: 0x8986B9C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x898B688 Offset: 0x8987688 VA: 0x898B688 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x898B68C Offset: 0x898768C VA: 0x898B68C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x898B914 Offset: 0x8987914 VA: 0x898B914 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x898B91C Offset: 0x898791C VA: 0x898B91C Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x898B954 Offset: 0x8987954 VA: 0x898B954 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Legacy/Input Field", 103)]
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 22988
{
	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0x100
	private static readonly char[] kSeparators; // 0x0
	private static bool s_IsQuestDeviceEvaluated; // 0x8
	private static bool s_IsQuestDevice; // 0x9
	[FormerlySerializedAs("text")]
	[SerializeField]
	protected Text m_TextComponent; // 0x108
	[SerializeField]
	protected Graphic m_Placeholder; // 0x110
	[SerializeField]
	private InputField.ContentType m_ContentType; // 0x118
	[SerializeField]
	[FormerlySerializedAs("inputType")]
	private InputField.InputType m_InputType; // 0x11C
	[SerializeField]
	[FormerlySerializedAs("asteriskChar")]
	private char m_AsteriskChar; // 0x120
	[SerializeField]
	[FormerlySerializedAs("keyboardType")]
	private TouchScreenKeyboardType m_KeyboardType; // 0x124
	[SerializeField]
	private InputField.LineType m_LineType; // 0x128
	[SerializeField]
	[FormerlySerializedAs("hideMobileInput")]
	private bool m_HideMobileInput; // 0x12C
	[FormerlySerializedAs("validation")]
	[SerializeField]
	private InputField.CharacterValidation m_CharacterValidation; // 0x130
	[FormerlySerializedAs("characterLimit")]
	[SerializeField]
	private int m_CharacterLimit; // 0x134
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_OnSubmit")]
	[FormerlySerializedAs("m_EndEdit")]
	[FormerlySerializedAs("m_OnEndEdit")]
	[SerializeField]
	private InputField.SubmitEvent m_OnSubmit; // 0x138
	[SerializeField]
	private InputField.EndEditEvent m_OnDidEndEdit; // 0x140
	[FormerlySerializedAs("onValueChange")]
	[FormerlySerializedAs("m_OnValueChange")]
	[SerializeField]
	private InputField.OnChangeEvent m_OnValueChanged; // 0x148
	[FormerlySerializedAs("onValidateInput")]
	[SerializeField]
	private InputField.OnValidateInput m_OnValidateInput; // 0x150
	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	private Color m_CaretColor; // 0x158
	[SerializeField]
	private bool m_CustomCaretColor; // 0x168
	[SerializeField]
	private Color m_SelectionColor; // 0x16C
	[SerializeField]
	[Multiline]
	[FormerlySerializedAs("mValue")]
	protected string m_Text; // 0x180
	[SerializeField]
	[Range(0, 4)]
	private float m_CaretBlinkRate; // 0x188
	[SerializeField]
	[Range(1, 5)]
	private int m_CaretWidth; // 0x18C
	[SerializeField]
	private bool m_ReadOnly; // 0x190
	[SerializeField]
	private bool m_ShouldActivateOnSelect; // 0x191
	protected int m_CaretPosition; // 0x194
	protected int m_CaretSelectPosition; // 0x198
	private RectTransform caretRectTrans; // 0x1A0
	protected UIVertex[] m_CursorVerts; // 0x1A8
	private TextGenerator m_InputTextCache; // 0x1B0
	private CanvasRenderer m_CachedInputRenderer; // 0x1B8
	private bool m_PreventFontCallback; // 0x1C0
	protected Mesh m_Mesh; // 0x1C8
	private bool m_AllowInput; // 0x1D0
	private bool m_ShouldActivateNextUpdate; // 0x1D1
	private bool m_UpdateDrag; // 0x1D2
	private bool m_DragPositionOutOfBounds; // 0x1D3
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x1D4
	private Coroutine m_BlinkCoroutine; // 0x1D8
	private float m_BlinkStartTime; // 0x1E0
	protected int m_DrawStart; // 0x1E4
	protected int m_DrawEnd; // 0x1E8
	private Coroutine m_DragCoroutine; // 0x1F0
	private string m_OriginalText; // 0x1F8
	private bool m_WasCanceled; // 0x200
	private bool m_HasDoneFocusTransition; // 0x201
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x208
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x210
	private bool m_IsCompositionActive; // 0x211
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private const string kOculusQuestDeviceModel = "Oculus Quest";
	private Event m_ProcessingEvent; // 0x218
	private const int k_MaxTextLength = 16382;

	// Properties
	private BaseInput input { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	protected TextGenerator cachedInputTextGenerator { get; }
	public bool shouldHideMobileInput { get; set; }
	public virtual bool shouldActivateOnSelect { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public InputField.EndEditEvent onEndEdit { get; set; }
	public InputField.SubmitEvent onSubmit { get; set; }
	[Obsolete("onValueChange has been renamed to onValueChanged")]
	public InputField.OnChangeEvent onValueChange { get; set; }
	public InputField.OnChangeEvent onValueChanged { get; set; }
	public InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public InputField.ContentType contentType { get; set; }
	public InputField.LineType lineType { get; set; }
	public InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public InputField.CharacterValidation characterValidation { get; set; }
	public bool readOnly { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x8981A20 Offset: 0x897DA20 VA: 0x8981A20
	private BaseInput get_input() { }

	// RVA: 0x8981B30 Offset: 0x897DB30 VA: 0x8981B30
	private string get_compositionString() { }

	// RVA: 0x8981BC4 Offset: 0x897DBC4 VA: 0x8981BC4
	protected void .ctor() { }

	// RVA: 0x8981F10 Offset: 0x897DF10 VA: 0x8981F10
	protected Mesh get_mesh() { }

	// RVA: 0x8981FB8 Offset: 0x897DFB8 VA: 0x8981FB8
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x898202C Offset: 0x897E02C VA: 0x898202C
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x8982084 Offset: 0x897E084 VA: 0x8982084
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x898210C Offset: 0x897E10C VA: 0x898210C Slot: 59
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x8982118 Offset: 0x897E118 VA: 0x8982118 Slot: 60
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x8982188 Offset: 0x897E188 VA: 0x8982188
	public string get_text() { }

	// RVA: 0x8982190 Offset: 0x897E190 VA: 0x8982190
	public void set_text(string value) { }

	// RVA: 0x89824E4 Offset: 0x897E4E4 VA: 0x89824E4
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x8982198 Offset: 0x897E198 VA: 0x8982198
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x8982A18 Offset: 0x897EA18 VA: 0x8982A18
	public bool get_isFocused() { }

	// RVA: 0x8982A20 Offset: 0x897EA20 VA: 0x8982A20
	public float get_caretBlinkRate() { }

	// RVA: 0x8982A28 Offset: 0x897EA28 VA: 0x8982A28
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x8982B14 Offset: 0x897EB14 VA: 0x8982B14
	public int get_caretWidth() { }

	// RVA: 0x8982B1C Offset: 0x897EB1C VA: 0x8982B1C
	public void set_caretWidth(int value) { }

	// RVA: 0x8982BE8 Offset: 0x897EBE8 VA: 0x8982BE8
	public Text get_textComponent() { }

	// RVA: 0x8982BF0 Offset: 0x897EBF0 VA: 0x8982BF0
	public void set_textComponent(Text value) { }

	// RVA: 0x8982E70 Offset: 0x897EE70 VA: 0x8982E70
	public Graphic get_placeholder() { }

	// RVA: 0x8982E78 Offset: 0x897EE78 VA: 0x8982E78
	public void set_placeholder(Graphic value) { }

	// RVA: 0x8982ED0 Offset: 0x897EED0 VA: 0x8982ED0
	public Color get_caretColor() { }

	// RVA: 0x8982F14 Offset: 0x897EF14 VA: 0x8982F14
	public void set_caretColor(Color value) { }

	// RVA: 0x8982F40 Offset: 0x897EF40 VA: 0x8982F40
	public bool get_customCaretColor() { }

	// RVA: 0x8982F48 Offset: 0x897EF48 VA: 0x8982F48
	public void set_customCaretColor(bool value) { }

	// RVA: 0x8982F64 Offset: 0x897EF64 VA: 0x8982F64
	public Color get_selectionColor() { }

	// RVA: 0x8982F78 Offset: 0x897EF78 VA: 0x8982F78
	public void set_selectionColor(Color value) { }

	// RVA: 0x8982FA4 Offset: 0x897EFA4 VA: 0x8982FA4
	public InputField.EndEditEvent get_onEndEdit() { }

	// RVA: 0x8982FAC Offset: 0x897EFAC VA: 0x8982FAC
	public void set_onEndEdit(InputField.EndEditEvent value) { }

	// RVA: 0x8983004 Offset: 0x897F004 VA: 0x8983004
	public InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x898300C Offset: 0x897F00C VA: 0x898300C
	public void set_onSubmit(InputField.SubmitEvent value) { }

	// RVA: 0x8983064 Offset: 0x897F064 VA: 0x8983064
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x898306C Offset: 0x897F06C VA: 0x898306C
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x89830C8 Offset: 0x897F0C8 VA: 0x89830C8
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x8983070 Offset: 0x897F070 VA: 0x8983070
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x89830D0 Offset: 0x897F0D0 VA: 0x89830D0
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x89830D8 Offset: 0x897F0D8 VA: 0x89830D8
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x8983130 Offset: 0x897F130 VA: 0x8983130
	public int get_characterLimit() { }

	// RVA: 0x8983138 Offset: 0x897F138 VA: 0x8983138
	public void set_characterLimit(int value) { }

	// RVA: 0x89831F8 Offset: 0x897F1F8 VA: 0x89831F8
	public InputField.ContentType get_contentType() { }

	// RVA: 0x8983200 Offset: 0x897F200 VA: 0x8983200
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0x8983330 Offset: 0x897F330 VA: 0x8983330
	public InputField.LineType get_lineType() { }

	// RVA: 0x8983338 Offset: 0x897F338 VA: 0x8983338
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0x898345C Offset: 0x897F45C VA: 0x898345C
	public InputField.InputType get_inputType() { }

	// RVA: 0x8983464 Offset: 0x897F464 VA: 0x8983464
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x8983500 Offset: 0x897F500 VA: 0x8983500
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x8983508 Offset: 0x897F508 VA: 0x8983508
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x8983510 Offset: 0x897F510 VA: 0x8983510
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x8983594 Offset: 0x897F594 VA: 0x8983594
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x898359C Offset: 0x897F59C VA: 0x898359C
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x8983620 Offset: 0x897F620 VA: 0x8983620
	public bool get_readOnly() { }

	// RVA: 0x8983628 Offset: 0x897F628 VA: 0x8983628
	public void set_readOnly(bool value) { }

	// RVA: 0x8983634 Offset: 0x897F634 VA: 0x8983634
	public bool get_multiLine() { }

	// RVA: 0x8983648 Offset: 0x897F648 VA: 0x8983648
	public char get_asteriskChar() { }

	// RVA: 0x8983650 Offset: 0x897F650 VA: 0x8983650
	public void set_asteriskChar(char value) { }

	// RVA: 0x89836C4 Offset: 0x897F6C4 VA: 0x89836C4
	public bool get_wasCanceled() { }

	// RVA: 0x89836CC Offset: 0x897F6CC VA: 0x89836CC
	protected void ClampPos(ref int pos) { }

	// RVA: 0x8983704 Offset: 0x897F704 VA: 0x8983704
	protected int get_caretPositionInternal() { }

	// RVA: 0x8983728 Offset: 0x897F728 VA: 0x8983728
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x8983760 Offset: 0x897F760 VA: 0x8983760
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x8983784 Offset: 0x897F784 VA: 0x8983784
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x89837BC Offset: 0x897F7BC VA: 0x89837BC
	private bool get_hasSelection() { }

	// RVA: 0x89837EC Offset: 0x897F7EC VA: 0x89837EC
	public int get_caretPosition() { }

	// RVA: 0x8983810 Offset: 0x897F810 VA: 0x8983810
	public void set_caretPosition(int value) { }

	// RVA: 0x89838F0 Offset: 0x897F8F0 VA: 0x89838F0
	public int get_selectionAnchorPosition() { }

	// RVA: 0x8983838 Offset: 0x897F838 VA: 0x8983838
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x8983914 Offset: 0x897F914 VA: 0x8983914
	public int get_selectionFocusPosition() { }

	// RVA: 0x8983894 Offset: 0x897F894 VA: 0x8983894
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x8983938 Offset: 0x897F938 VA: 0x8983938 Slot: 4
	protected override void Awake() { }

	// RVA: 0x89839F8 Offset: 0x897F9F8 VA: 0x89839F8 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x8983C64 Offset: 0x897FC64 VA: 0x8983C64 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x8984034 Offset: 0x8980034 VA: 0x8984034 Slot: 8
	protected override void OnDestroy() { }

	[IteratorStateMachine(typeof(InputField.<CaretBlink>d__172))]
	// RVA: 0x8984098 Offset: 0x8980098 VA: 0x8984098
	private IEnumerator CaretBlink() { }

	// RVA: 0x898412C Offset: 0x898012C VA: 0x898412C
	private void SetCaretVisible() { }

	// RVA: 0x8982AA4 Offset: 0x897EAA4 VA: 0x8982AA4
	private void SetCaretActive() { }

	// RVA: 0x8984164 Offset: 0x8980164 VA: 0x8984164
	private void UpdateCaretMaterial() { }

	// RVA: 0x8984274 Offset: 0x8980274 VA: 0x8984274
	protected void OnFocus() { }

	// RVA: 0x89842A4 Offset: 0x89802A4 VA: 0x89842A4
	protected void SelectAll() { }

	// RVA: 0x89842D4 Offset: 0x89802D4 VA: 0x89842D4
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x8984334 Offset: 0x8980334 VA: 0x8984334
	public void MoveTextStart(bool shift) { }

	// RVA: 0x89843B0 Offset: 0x89803B0 VA: 0x89843B0
	private static string get_clipboard() { }

	// RVA: 0x8984400 Offset: 0x8980400 VA: 0x8984400
	private static void set_clipboard(string value) { }

	// RVA: 0x8984458 Offset: 0x8980458 VA: 0x8984458
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x8984510 Offset: 0x8980510 VA: 0x8984510
	private bool InPlaceEditing() { }

	// RVA: 0x8984540 Offset: 0x8980540 VA: 0x8984540
	private bool InPlaceEditingChanged() { }

	// RVA: 0x89845C0 Offset: 0x89805C0 VA: 0x89845C0
	private RangeInt GetInternalSelection() { }

	// RVA: 0x8984674 Offset: 0x8980674 VA: 0x8984674
	private void UpdateKeyboardCaret() { }

	// RVA: 0x898473C Offset: 0x898073C VA: 0x898473C
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x8984820 Offset: 0x8980820 VA: 0x8984820 Slot: 61
	protected virtual void LateUpdate() { }

	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	// RVA: 0x8985E78 Offset: 0x8981E78 VA: 0x8985E78
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x8986210 Offset: 0x8982210 VA: 0x8986210
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x8986420 Offset: 0x8982420 VA: 0x8986420
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x8986818 Offset: 0x8982818 VA: 0x8986818
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x89868F0 Offset: 0x89828F0 VA: 0x89868F0 Slot: 62
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x8986910 Offset: 0x8982910 VA: 0x8986910 Slot: 63
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(InputField.<MouseDragOutsideRect>d__196))]
	// RVA: 0x8986B14 Offset: 0x8982B14 VA: 0x8986B14
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x8986BC4 Offset: 0x8982BC4 VA: 0x8986BC4 Slot: 64
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x8986BE0 Offset: 0x8982BE0 VA: 0x8986BE0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x8986DD0 Offset: 0x8982DD0 VA: 0x8986DD0
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x89878D0 Offset: 0x89838D0 VA: 0x89878D0
	private bool IsValidChar(char c) { }

	// RVA: 0x8987940 Offset: 0x8983940 VA: 0x8987940
	public void ProcessEvent(Event e) { }

	// RVA: 0x8987944 Offset: 0x8983944 VA: 0x8987944 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x898739C Offset: 0x898339C VA: 0x898739C
	private string GetSelectedString() { }

	// RVA: 0x8987AE4 Offset: 0x8983AE4 VA: 0x8987AE4
	private int FindtNextWordBegin() { }

	// RVA: 0x898778C Offset: 0x898378C VA: 0x898778C
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x8987BA0 Offset: 0x8983BA0 VA: 0x8987BA0
	private int FindtPrevWordBegin() { }

	// RVA: 0x8987660 Offset: 0x8983660 VA: 0x8987660
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x8987C40 Offset: 0x8983C40 VA: 0x8987C40
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x8987D50 Offset: 0x8983D50 VA: 0x8987D50
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x89880A8 Offset: 0x89840A8 VA: 0x89880A8
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x89878C4 Offset: 0x89838C4 VA: 0x89878C4
	private void MoveDown(bool shift) { }

	// RVA: 0x898835C Offset: 0x898435C VA: 0x898835C
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x89878B8 Offset: 0x89838B8 VA: 0x89878B8
	private void MoveUp(bool shift) { }

	// RVA: 0x8988480 Offset: 0x8984480 VA: 0x8988480
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x8987444 Offset: 0x8983444 VA: 0x8987444
	private void Delete() { }

	// RVA: 0x89872E8 Offset: 0x89832E8 VA: 0x89872E8
	private void ForwardSpace() { }

	// RVA: 0x89871D4 Offset: 0x89831D4 VA: 0x89871D4
	private void Backspace() { }

	// RVA: 0x89885D8 Offset: 0x89845D8 VA: 0x89885D8
	private void Insert(char c) { }

	// RVA: 0x8987618 Offset: 0x8983618 VA: 0x8987618
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x8985E60 Offset: 0x8981E60 VA: 0x8985E60
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x89825A0 Offset: 0x897E5A0 VA: 0x89825A0
	private void SendOnValueChanged() { }

	// RVA: 0x8988708 Offset: 0x8984708 VA: 0x8988708
	protected void SendOnEndEdit() { }

	// RVA: 0x89856C4 Offset: 0x89816C4 VA: 0x89856C4
	protected void SendOnSubmit() { }

	// RVA: 0x8988788 Offset: 0x8984788 VA: 0x8988788 Slot: 66
	protected virtual void Append(string input) { }

	// RVA: 0x8988844 Offset: 0x8984844 VA: 0x8988844 Slot: 67
	protected virtual void Append(char input) { }

	// RVA: 0x8982620 Offset: 0x897E620 VA: 0x8982620
	protected void UpdateLabel() { }

	// RVA: 0x89895F0 Offset: 0x89855F0 VA: 0x89895F0
	private bool IsSelectionVisible() { }

	// RVA: 0x898965C Offset: 0x898565C VA: 0x898965C
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x89866B4 Offset: 0x89826B4 VA: 0x89866B4
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x8988AB4 Offset: 0x8984AB4 VA: 0x8988AB4
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x89897AC Offset: 0x89857AC VA: 0x89897AC
	public void ForceLabelUpdate() { }

	// RVA: 0x8982B90 Offset: 0x897EB90 VA: 0x8982B90
	private void MarkGeometryAsDirty() { }

	// RVA: 0x89897B0 Offset: 0x89857B0 VA: 0x89897B0 Slot: 68
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x8989C20 Offset: 0x8985C20 VA: 0x8989C20 Slot: 69
	public virtual void LayoutComplete() { }

	// RVA: 0x8989C24 Offset: 0x8985C24 VA: 0x8989C24 Slot: 70
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x89897C0 Offset: 0x89857C0 VA: 0x89897C0
	private void UpdateGeometry() { }

	// RVA: 0x89851C4 Offset: 0x89811C4 VA: 0x89851C4
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x8989C28 Offset: 0x8985C28 VA: 0x8989C28
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x8989EB0 Offset: 0x8985EB0 VA: 0x8989EB0
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x898AD30 Offset: 0x8986D30 VA: 0x898AD30
	private void CreateCursorVerts() { }

	// RVA: 0x898A5C8 Offset: 0x89865C8 VA: 0x898A5C8
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x8985744 Offset: 0x8981744 VA: 0x8985744
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x898AE90 Offset: 0x8986E90 VA: 0x898AE90
	public void ActivateInputField() { }

	// RVA: 0x8984E68 Offset: 0x8980E68 VA: 0x8984E68
	private void ActivateInputFieldInternal() { }

	// RVA: 0x898AFB0 Offset: 0x8986FB0 VA: 0x898AFB0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x898AFEC Offset: 0x8986FEC VA: 0x898AFEC Slot: 71
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x8983EA8 Offset: 0x897FEA8 VA: 0x8983EA8
	public void DeactivateInputField() { }

	// RVA: 0x898B010 Offset: 0x8987010 VA: 0x898B010 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x898B03C Offset: 0x898703C VA: 0x898B03C Slot: 72
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x8983274 Offset: 0x897F274 VA: 0x8983274
	private void EnforceContentType() { }

	// RVA: 0x8981E7C Offset: 0x897DE7C VA: 0x8981E7C
	private void EnforceTextHOverflow() { }

	// RVA: 0x89833F8 Offset: 0x897F3F8 VA: 0x89833F8
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x89834E8 Offset: 0x897F4E8 VA: 0x89834E8
	private void SetToCustom() { }

	// RVA: 0x898B084 Offset: 0x8987084 VA: 0x898B084 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x898B0B0 Offset: 0x89870B0 VA: 0x898B0B0 Slot: 73
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x898B0B4 Offset: 0x89870B4 VA: 0x898B0B4 Slot: 74
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x898B0B8 Offset: 0x89870B8 VA: 0x898B0B8 Slot: 75
	public virtual float get_minWidth() { }

	// RVA: 0x898B0C0 Offset: 0x89870C0 VA: 0x898B0C0 Slot: 76
	public virtual float get_preferredWidth() { }

	// RVA: 0x898B20C Offset: 0x898720C VA: 0x898B20C Slot: 77
	public virtual float get_flexibleWidth() { }

	// RVA: 0x898B214 Offset: 0x8987214 VA: 0x898B214 Slot: 78
	public virtual float get_minHeight() { }

	// RVA: 0x898B21C Offset: 0x898721C VA: 0x898B21C Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0x898B354 Offset: 0x8987354 VA: 0x898B354 Slot: 80
	public virtual float get_flexibleHeight() { }

	// RVA: 0x898B35C Offset: 0x898735C VA: 0x898B35C Slot: 81
	public virtual int get_layoutPriority() { }

	// RVA: 0x898B364 Offset: 0x8987364 VA: 0x898B364
	private static void .cctor() { }

	// RVA: 0x898B414 Offset: 0x8987414 VA: 0x898B414 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum AspectRatioFitter.AspectMode // TypeDefIndex: 22989
{
	// Fields
	public int value__; // 0x0
	public const AspectRatioFitter.AspectMode None = 0;
	public const AspectRatioFitter.AspectMode WidthControlsHeight = 1;
	public const AspectRatioFitter.AspectMode HeightControlsWidth = 2;
	public const AspectRatioFitter.AspectMode FitInParent = 3;
	public const AspectRatioFitter.AspectMode EnvelopeParent = 4;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 22990
{
	// Fields
	[SerializeField]
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x20
	[SerializeField]
	private float m_AspectRatio; // 0x24
	private RectTransform m_Rect; // 0x28
	private bool m_DelayedSetDirty; // 0x30
	private bool m_DoesParentExist; // 0x31
	private DrivenRectTransformTracker m_Tracker; // 0x32

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x898B95C Offset: 0x898795C VA: 0x898B95C
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x898B964 Offset: 0x8987964 VA: 0x898B964
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x898B9DC Offset: 0x89879DC VA: 0x898B9DC
	public float get_aspectRatio() { }

	// RVA: 0x898B9E4 Offset: 0x89879E4 VA: 0x898B9E4
	public void set_aspectRatio(float value) { }

	// RVA: 0x898BA58 Offset: 0x8987A58 VA: 0x898BA58
	private RectTransform get_rectTransform() { }

	// RVA: 0x898BB00 Offset: 0x8987B00 VA: 0x898BB00
	protected void .ctor() { }

	// RVA: 0x898BB10 Offset: 0x8987B10 VA: 0x898BB10 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x898BBA8 Offset: 0x8987BA8 VA: 0x898BBA8 Slot: 6
	protected override void Start() { }

	// RVA: 0x898BCEC Offset: 0x8987CEC VA: 0x898BCEC Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x898C168 Offset: 0x8988168 VA: 0x898C168 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x898C200 Offset: 0x8988200 VA: 0x898C200 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x898C214 Offset: 0x8988214 VA: 0x898C214 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x898C218 Offset: 0x8988218 VA: 0x898C218
	private void UpdateRect() { }

	// RVA: 0x898C5FC Offset: 0x89885FC VA: 0x898C5FC
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x898C504 Offset: 0x8988504 VA: 0x898C504
	private Vector2 GetParentSize() { }

	// RVA: 0x898C6F0 Offset: 0x89886F0 VA: 0x898C6F0 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x898C6F4 Offset: 0x89886F4 VA: 0x898C6F4 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x898B9D8 Offset: 0x89879D8 VA: 0x898B9D8
	protected void SetDirty() { }

	// RVA: 0x898BBF8 Offset: 0x8987BF8 VA: 0x898BBF8
	public bool IsComponentValidOnObject() { }

	// RVA: 0x898BCC4 Offset: 0x8987CC4 VA: 0x898BCC4
	public bool IsAspectModeValid() { }

	// RVA: 0x898C6F8 Offset: 0x89886F8 VA: 0x898C6F8
	private bool DoesParentExists() { }
}

// Namespace: 
public enum CanvasScaler.ScaleMode // TypeDefIndex: 22991
{
	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScaleMode ConstantPixelSize = 0;
	public const CanvasScaler.ScaleMode ScaleWithScreenSize = 1;
	public const CanvasScaler.ScaleMode ConstantPhysicalSize = 2;
}

// Namespace: 
public enum CanvasScaler.ScreenMatchMode // TypeDefIndex: 22992
{
	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScreenMatchMode MatchWidthOrHeight = 0;
	public const CanvasScaler.ScreenMatchMode Expand = 1;
	public const CanvasScaler.ScreenMatchMode Shrink = 2;
}

// Namespace: 
public enum CanvasScaler.Unit // TypeDefIndex: 22993
{
	// Fields
	public int value__; // 0x0
	public const CanvasScaler.Unit Centimeters = 0;
	public const CanvasScaler.Unit Millimeters = 1;
	public const CanvasScaler.Unit Inches = 2;
	public const CanvasScaler.Unit Points = 3;
	public const CanvasScaler.Unit Picas = 4;
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[AddComponentMenu("Layout/Canvas Scaler", 101)]
[ExecuteAlways]
[RequireComponent(typeof(Canvas))]
public class CanvasScaler : UIBehaviour // TypeDefIndex: 22994
{
	// Fields
	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	[SerializeField]
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x20
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	[SerializeField]
	protected float m_ReferencePixelsPerUnit; // 0x24
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	[SerializeField]
	protected float m_ScaleFactor; // 0x28
	[SerializeField]
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	protected Vector2 m_ReferenceResolution; // 0x2C
	[SerializeField]
	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x34
	[Range(0, 1)]
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	[SerializeField]
	protected float m_MatchWidthOrHeight; // 0x38
	private const float kLogBase = 2;
	[SerializeField]
	[Tooltip("The physical unit to specify positions and sizes in.")]
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x3C
	[SerializeField]
	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	protected float m_FallbackScreenDPI; // 0x40
	[SerializeField]
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	protected float m_DefaultSpriteDPI; // 0x44
	[SerializeField]
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	protected float m_DynamicPixelsPerUnit; // 0x48
	private Canvas m_Canvas; // 0x50
	private float m_PrevScaleFactor; // 0x58
	private float m_PrevReferencePixelsPerUnit; // 0x5C
	[SerializeField]
	protected bool m_PresetInfoIsWorld; // 0x60

	// Properties
	public CanvasScaler.ScaleMode uiScaleMode { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public float scaleFactor { get; set; }
	public Vector2 referenceResolution { get; set; }
	public CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
	public float matchWidthOrHeight { get; set; }
	public CanvasScaler.Unit physicalUnit { get; set; }
	public float fallbackScreenDPI { get; set; }
	public float defaultSpriteDPI { get; set; }
	public float dynamicPixelsPerUnit { get; set; }

	// Methods

	// RVA: 0x898C700 Offset: 0x8988700 VA: 0x898C700
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0x898C708 Offset: 0x8988708 VA: 0x898C708
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x898C710 Offset: 0x8988710 VA: 0x898C710
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x898C718 Offset: 0x8988718 VA: 0x898C718
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x898C720 Offset: 0x8988720 VA: 0x898C720
	public float get_scaleFactor() { }

	// RVA: 0x898C728 Offset: 0x8988728 VA: 0x898C728
	public void set_scaleFactor(float value) { }

	// RVA: 0x898C73C Offset: 0x898873C VA: 0x898C73C
	public Vector2 get_referenceResolution() { }

	// RVA: 0x898C744 Offset: 0x8988744 VA: 0x898C744
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x898C7A8 Offset: 0x89887A8 VA: 0x898C7A8
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x898C7B0 Offset: 0x89887B0 VA: 0x898C7B0
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x898C7B8 Offset: 0x89887B8 VA: 0x898C7B8
	public float get_matchWidthOrHeight() { }

	// RVA: 0x898C7C0 Offset: 0x89887C0 VA: 0x898C7C0
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x898C7C8 Offset: 0x89887C8 VA: 0x898C7C8
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0x898C7D0 Offset: 0x89887D0 VA: 0x898C7D0
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x898C7D8 Offset: 0x89887D8 VA: 0x898C7D8
	public float get_fallbackScreenDPI() { }

	// RVA: 0x898C7E0 Offset: 0x89887E0 VA: 0x898C7E0
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x898C7E8 Offset: 0x89887E8 VA: 0x898C7E8
	public float get_defaultSpriteDPI() { }

	// RVA: 0x898C7F0 Offset: 0x89887F0 VA: 0x898C7F0
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x898C800 Offset: 0x8988800 VA: 0x898C800
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x898C808 Offset: 0x8988808 VA: 0x898C808
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x898C810 Offset: 0x8988810 VA: 0x898C810
	protected void .ctor() { }

	// RVA: 0x898C858 Offset: 0x8988858 VA: 0x898C858 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x898C928 Offset: 0x8988928 VA: 0x898C928
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x898C938 Offset: 0x8988938 VA: 0x898C938 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x898CA60 Offset: 0x8988A60 VA: 0x898CA60 Slot: 17
	protected virtual void Handle() { }

	// RVA: 0x898CB5C Offset: 0x8988B5C VA: 0x898CB5C Slot: 18
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x898CB7C Offset: 0x8988B7C VA: 0x898CB7C Slot: 19
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x898CB9C Offset: 0x8988B9C VA: 0x898CB9C Slot: 20
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x898CDD0 Offset: 0x8988DD0 VA: 0x898CDD0 Slot: 21
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x898C9E0 Offset: 0x89889E0 VA: 0x898C9E0
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x898CA20 Offset: 0x8988A20 VA: 0x898CA20
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }
}

// Namespace: 
public enum ContentSizeFitter.FitMode // TypeDefIndex: 22995
{
	// Fields
	public int value__; // 0x0
	public const ContentSizeFitter.FitMode Unconstrained = 0;
	public const ContentSizeFitter.FitMode MinSize = 1;
	public const ContentSizeFitter.FitMode PreferredSize = 2;
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
[AddComponentMenu("Layout/Content Size Fitter", 141)]
public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 22996
{
	// Fields
	[SerializeField]
	protected ContentSizeFitter.FitMode m_HorizontalFit; // 0x20
	[SerializeField]
	protected ContentSizeFitter.FitMode m_VerticalFit; // 0x24
	private RectTransform m_Rect; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x30

	// Properties
	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x898CE38 Offset: 0x8988E38 VA: 0x898CE38
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x898CE40 Offset: 0x8988E40 VA: 0x898CE40
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x898CF38 Offset: 0x8988F38 VA: 0x898CF38
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x898CF40 Offset: 0x8988F40 VA: 0x898CF40
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x898CFB4 Offset: 0x8988FB4 VA: 0x898CFB4
	private RectTransform get_rectTransform() { }

	// RVA: 0x898D05C Offset: 0x898905C VA: 0x898D05C
	protected void .ctor() { }

	// RVA: 0x898D064 Offset: 0x8989064 VA: 0x898D064 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x898D080 Offset: 0x8989080 VA: 0x898D080 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x898D0FC Offset: 0x89890FC VA: 0x898D0FC Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x898D100 Offset: 0x8989100 VA: 0x898D100
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x898D1FC Offset: 0x89891FC VA: 0x898D1FC Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x898D220 Offset: 0x8989220 VA: 0x898D220 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x898CEB4 Offset: 0x8988EB4 VA: 0x898CEB4
	protected void SetDirty() { }
}

// Namespace: 
public enum GridLayoutGroup.Corner // TypeDefIndex: 22997
{
	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Corner UpperLeft = 0;
	public const GridLayoutGroup.Corner UpperRight = 1;
	public const GridLayoutGroup.Corner LowerLeft = 2;
	public const GridLayoutGroup.Corner LowerRight = 3;
}

// Namespace: 
public enum GridLayoutGroup.Axis // TypeDefIndex: 22998
{
	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Axis Horizontal = 0;
	public const GridLayoutGroup.Axis Vertical = 1;
}

// Namespace: 
public enum GridLayoutGroup.Constraint // TypeDefIndex: 22999
{
	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Constraint Flexible = 0;
	public const GridLayoutGroup.Constraint FixedColumnCount = 1;
	public const GridLayoutGroup.Constraint FixedRowCount = 2;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Grid Layout Group", 152)]
public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 23000
{
	// Fields
	[SerializeField]
	protected GridLayoutGroup.Corner m_StartCorner; // 0x60
	[SerializeField]
	protected GridLayoutGroup.Axis m_StartAxis; // 0x64
	[SerializeField]
	protected Vector2 m_CellSize; // 0x68
	[SerializeField]
	protected Vector2 m_Spacing; // 0x70
	[SerializeField]
	protected GridLayoutGroup.Constraint m_Constraint; // 0x78
	[SerializeField]
	protected int m_ConstraintCount; // 0x7C

	// Properties
	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }

	// Methods

	// RVA: 0x898D228 Offset: 0x8989228 VA: 0x898D228
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x898D230 Offset: 0x8989230 VA: 0x898D230
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x898D28C Offset: 0x898928C VA: 0x898D28C
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x898D294 Offset: 0x8989294 VA: 0x898D294
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x898D2F0 Offset: 0x89892F0 VA: 0x898D2F0
	public Vector2 get_cellSize() { }

	// RVA: 0x898D2F8 Offset: 0x89892F8 VA: 0x898D2F8
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x898D35C Offset: 0x898935C VA: 0x898D35C
	public Vector2 get_spacing() { }

	// RVA: 0x898D364 Offset: 0x8989364 VA: 0x898D364
	public void set_spacing(Vector2 value) { }

	// RVA: 0x898D3C8 Offset: 0x89893C8 VA: 0x898D3C8
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x898D3D0 Offset: 0x89893D0 VA: 0x898D3D0
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0x898D42C Offset: 0x898942C VA: 0x898D42C
	public int get_constraintCount() { }

	// RVA: 0x898D434 Offset: 0x8989434 VA: 0x898D434
	public void set_constraintCount(int value) { }

	// RVA: 0x898D494 Offset: 0x8989494 VA: 0x898D494
	protected void .ctor() { }

	// RVA: 0x898D658 Offset: 0x8989658 VA: 0x898D658 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x898DC68 Offset: 0x8989C68 VA: 0x898DC68 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x898DF18 Offset: 0x8989F18 VA: 0x898DF18 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x898E6AC Offset: 0x898A6AC VA: 0x898E6AC Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x898DF20 Offset: 0x8989F20 VA: 0x898DF20
	private void SetCellsAlongAxis(int axis) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 23001
{
	// Methods

	// RVA: 0x898E8AC Offset: 0x898A8AC VA: 0x898E8AC
	protected void .ctor() { }

	// RVA: 0x898E8C4 Offset: 0x898A8C4 VA: 0x898E8C4 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x898EB84 Offset: 0x898AB84 VA: 0x898EB84 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x898EB90 Offset: 0x898AB90 VA: 0x898EB90 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x898F1EC Offset: 0x898B1EC VA: 0x898F1EC Slot: 38
	public override void SetLayoutVertical() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 23002
{
	// Fields
	[SerializeField]
	protected float m_Spacing; // 0x60
	[SerializeField]
	protected bool m_ChildForceExpandWidth; // 0x64
	[SerializeField]
	protected bool m_ChildForceExpandHeight; // 0x65
	[SerializeField]
	protected bool m_ChildControlWidth; // 0x66
	[SerializeField]
	protected bool m_ChildControlHeight; // 0x67
	[SerializeField]
	protected bool m_ChildScaleWidth; // 0x68
	[SerializeField]
	protected bool m_ChildScaleHeight; // 0x69
	[SerializeField]
	protected bool m_ReverseArrangement; // 0x6A

	// Properties
	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }
	public bool reverseArrangement { get; set; }

	// Methods

	// RVA: 0x898F1F8 Offset: 0x898B1F8 VA: 0x898F1F8
	public float get_spacing() { }

	// RVA: 0x898F200 Offset: 0x898B200 VA: 0x898F200
	public void set_spacing(float value) { }

	// RVA: 0x898F25C Offset: 0x898B25C VA: 0x898F25C
	public bool get_childForceExpandWidth() { }

	// RVA: 0x898F264 Offset: 0x898B264 VA: 0x898F264
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x898F2C0 Offset: 0x898B2C0 VA: 0x898F2C0
	public bool get_childForceExpandHeight() { }

	// RVA: 0x898F2C8 Offset: 0x898B2C8 VA: 0x898F2C8
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x898F324 Offset: 0x898B324 VA: 0x898F324
	public bool get_childControlWidth() { }

	// RVA: 0x898F32C Offset: 0x898B32C VA: 0x898F32C
	public void set_childControlWidth(bool value) { }

	// RVA: 0x898F388 Offset: 0x898B388 VA: 0x898F388
	public bool get_childControlHeight() { }

	// RVA: 0x898F390 Offset: 0x898B390 VA: 0x898F390
	public void set_childControlHeight(bool value) { }

	// RVA: 0x898F3EC Offset: 0x898B3EC VA: 0x898F3EC
	public bool get_childScaleWidth() { }

	// RVA: 0x898F3F4 Offset: 0x898B3F4 VA: 0x898F3F4
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x898F450 Offset: 0x898B450 VA: 0x898F450
	public bool get_childScaleHeight() { }

	// RVA: 0x898F458 Offset: 0x898B458 VA: 0x898F458
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x898F4B4 Offset: 0x898B4B4 VA: 0x898F4B4
	public bool get_reverseArrangement() { }

	// RVA: 0x898F4BC Offset: 0x898B4BC VA: 0x898F4BC
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x898E8E4 Offset: 0x898A8E4 VA: 0x898E8E4
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x898EB9C Offset: 0x898AB9C VA: 0x898EB9C
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x898F518 Offset: 0x898B518 VA: 0x898F518
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x898E8B8 Offset: 0x898A8B8 VA: 0x898E8B8
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
public interface ILayoutElement // TypeDefIndex: 23003
{
	// Properties
	public abstract float minWidth { get; }
	public abstract float preferredWidth { get; }
	public abstract float flexibleWidth { get; }
	public abstract float minHeight { get; }
	public abstract float preferredHeight { get; }
	public abstract float flexibleHeight { get; }
	public abstract int layoutPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CalculateLayoutInputHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CalculateLayoutInputVertical();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_minWidth();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_preferredWidth();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_flexibleWidth();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_minHeight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_preferredHeight();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_flexibleHeight();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_layoutPriority();
}

// Namespace: UnityEngine.UI
public interface ILayoutController // TypeDefIndex: 23004
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetLayoutVertical();
}

// Namespace: UnityEngine.UI
public interface ILayoutGroup : ILayoutController // TypeDefIndex: 23005
{}

// Namespace: UnityEngine.UI
public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 23006
{}

// Namespace: UnityEngine.UI
public interface ILayoutIgnorer // TypeDefIndex: 23007
{
	// Properties
	public abstract bool ignoreLayout { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_ignoreLayout();
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Layout Element", 140)]
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 23008
{
	// Fields
	[SerializeField]
	private bool m_IgnoreLayout; // 0x20
	[SerializeField]
	private float m_MinWidth; // 0x24
	[SerializeField]
	private float m_MinHeight; // 0x28
	[SerializeField]
	private float m_PreferredWidth; // 0x2C
	[SerializeField]
	private float m_PreferredHeight; // 0x30
	[SerializeField]
	private float m_FlexibleWidth; // 0x34
	[SerializeField]
	private float m_FlexibleHeight; // 0x38
	[SerializeField]
	private int m_LayoutPriority; // 0x3C

	// Properties
	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }

	// Methods

	// RVA: 0x898FC74 Offset: 0x898BC74 VA: 0x898FC74 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x898FC7C Offset: 0x898BC7C VA: 0x898FC7C Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x898FDA8 Offset: 0x898BDA8 VA: 0x898FDA8 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x898FDAC Offset: 0x898BDAC VA: 0x898FDAC Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x898FDB0 Offset: 0x898BDB0 VA: 0x898FDB0 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x898FDB8 Offset: 0x898BDB8 VA: 0x898FDB8 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x898FE2C Offset: 0x898BE2C VA: 0x898FE2C Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x898FE34 Offset: 0x898BE34 VA: 0x898FE34 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x898FEA8 Offset: 0x898BEA8 VA: 0x898FEA8 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x898FEB0 Offset: 0x898BEB0 VA: 0x898FEB0 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x898FF24 Offset: 0x898BF24 VA: 0x898FF24 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x898FF2C Offset: 0x898BF2C VA: 0x898FF2C Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x898FFA0 Offset: 0x898BFA0 VA: 0x898FFA0 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x898FFA8 Offset: 0x898BFA8 VA: 0x898FFA8 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x899001C Offset: 0x898C01C VA: 0x899001C Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x8990024 Offset: 0x898C024 VA: 0x8990024 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x8990098 Offset: 0x898C098 VA: 0x8990098 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x89900A0 Offset: 0x898C0A0 VA: 0x89900A0 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x8990114 Offset: 0x898C114 VA: 0x8990114
	protected void .ctor() { }

	// RVA: 0x8990134 Offset: 0x898C134 VA: 0x8990134 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x8990150 Offset: 0x898C150 VA: 0x8990150 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x8990154 Offset: 0x898C154 VA: 0x8990154 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x8990170 Offset: 0x898C170 VA: 0x8990170 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x8990174 Offset: 0x898C174 VA: 0x8990174 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x898FCF0 Offset: 0x898BCF0 VA: 0x898FCF0
	protected void SetDirty() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LayoutGroup.<DelayedSetDirty>d__56 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23009
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RectTransform rectTransform; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x8990670 Offset: 0x898C670 VA: 0x8990670
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x8990698 Offset: 0x898C698 VA: 0x8990698 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x899069C Offset: 0x898C69C VA: 0x899069C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8990738 Offset: 0x898C738 VA: 0x8990738 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x8990740 Offset: 0x898C740 VA: 0x8990740 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x8990778 Offset: 0x898C778 VA: 0x8990778 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 23010
{
	// Fields
	[SerializeField]
	protected RectOffset m_Padding; // 0x20
	[SerializeField]
	protected TextAnchor m_ChildAlignment; // 0x28
	private RectTransform m_Rect; // 0x30
	protected DrivenRectTransformTracker m_Tracker; // 0x38
	private Vector2 m_TotalMinSize; // 0x3C
	private Vector2 m_TotalPreferredSize; // 0x44
	private Vector2 m_TotalFlexibleSize; // 0x4C
	private List<RectTransform> m_RectChildren; // 0x58

	// Properties
	public RectOffset padding { get; set; }
	public TextAnchor childAlignment { get; set; }
	protected RectTransform rectTransform { get; }
	protected List<RectTransform> rectChildren { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }
	private bool isRootLayoutGroup { get; }

	// Methods

	// RVA: 0x8990178 Offset: 0x898C178 VA: 0x8990178
	public RectOffset get_padding() { }

	// RVA: 0x8990180 Offset: 0x898C180 VA: 0x8990180
	public void set_padding(RectOffset value) { }

	// RVA: 0x89901DC Offset: 0x898C1DC VA: 0x89901DC
	public TextAnchor get_childAlignment() { }

	// RVA: 0x89901E4 Offset: 0x898C1E4 VA: 0x89901E4
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x898DE70 Offset: 0x8989E70 VA: 0x898DE70
	protected RectTransform get_rectTransform() { }

	// RVA: 0x8990240 Offset: 0x898C240 VA: 0x8990240
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x898D824 Offset: 0x8989824 VA: 0x898D824 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x8990248 Offset: 0x898C248 VA: 0x8990248 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x8990250 Offset: 0x898C250 VA: 0x8990250 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x8990258 Offset: 0x898C258 VA: 0x8990258 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x8990260 Offset: 0x898C260 VA: 0x8990260 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x8990268 Offset: 0x898C268 VA: 0x8990268 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x8990270 Offset: 0x898C270 VA: 0x8990270 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x8990278 Offset: 0x898C278 VA: 0x8990278 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x898D4FC Offset: 0x89894FC VA: 0x898D4FC
	protected void .ctor() { }

	// RVA: 0x8990280 Offset: 0x898C280 VA: 0x8990280 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x8990370 Offset: 0x898C370 VA: 0x8990370 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x89903EC Offset: 0x898C3EC VA: 0x89903EC Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x898FBF8 Offset: 0x898BBF8 VA: 0x898FBF8
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x898FB18 Offset: 0x898BB18 VA: 0x898FB18
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x898FB88 Offset: 0x898BB88 VA: 0x898FB88
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x898E6B4 Offset: 0x898A6B4 VA: 0x898E6B4
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x898F62C Offset: 0x898B62C VA: 0x898F62C
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x898DBE8 Offset: 0x8989BE8 VA: 0x898DBE8
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x89903F0 Offset: 0x898C3F0 VA: 0x89903F0
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x898F8EC Offset: 0x898B8EC VA: 0x898F8EC
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x898E7FC Offset: 0x898A7FC VA: 0x898E7FC
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x898F678 Offset: 0x898B678 VA: 0x898F678
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x8990498 Offset: 0x898C498 VA: 0x8990498
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x89905D0 Offset: 0x898C5D0 VA: 0x89905D0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x8990600 Offset: 0x898C600 VA: 0x8990600 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4655B44 Offset: 0x4651B44 VA: 0x4655B44
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0x4655BF8 Offset: 0x4651BF8 VA: 0x4655BF8
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0x4655C70 Offset: 0x4651C70 VA: 0x4655C70
	|-LayoutGroup.SetProperty<Int32Enum>
	|
	|-RVA: 0x4655D1C Offset: 0x4651D1C VA: 0x4655D1C
	|-LayoutGroup.SetProperty<object>
	|
	|-RVA: 0x4655D88 Offset: 0x4651D88 VA: 0x4655D88
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0x4655E00 Offset: 0x4651E00 VA: 0x4655E00
	|-LayoutGroup.SetProperty<Vector2>
	|
	|-RVA: 0x4655EE0 Offset: 0x4651EE0 VA: 0x4655EE0
	|-LayoutGroup.SetProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x899029C Offset: 0x898C29C VA: 0x899029C
	protected void SetDirty() { }

	[IteratorStateMachine(typeof(LayoutGroup.<DelayedSetDirty>d__56))]
	// RVA: 0x8990604 Offset: 0x898C604 VA: 0x8990604
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LayoutRebuilder.<>c // TypeDefIndex: 23011
{
	// Fields
	public static readonly LayoutRebuilder.<>c <>9; // 0x0
	public static Predicate<Component> <>9__10_0; // 0x8
	public static UnityAction<Component> <>9__12_0; // 0x10
	public static UnityAction<Component> <>9__12_1; // 0x18
	public static UnityAction<Component> <>9__12_2; // 0x20
	public static UnityAction<Component> <>9__12_3; // 0x28

	// Methods

	// RVA: 0x8991A40 Offset: 0x898DA40 VA: 0x8991A40
	private static void .cctor() { }

	// RVA: 0x8991AA8 Offset: 0x898DAA8 VA: 0x8991AA8
	public void .ctor() { }

	// RVA: 0x8991AB0 Offset: 0x898DAB0 VA: 0x8991AB0
	internal LayoutRebuilder <.cctor>b__5_0() { }

	// RVA: 0x8991B04 Offset: 0x898DB04 VA: 0x8991B04
	internal void <.cctor>b__5_1(LayoutRebuilder x) { }

	// RVA: 0x8991B30 Offset: 0x898DB30 VA: 0x8991B30
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x8991BBC Offset: 0x898DBBC VA: 0x8991BBC
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x8991C78 Offset: 0x898DC78 VA: 0x8991C78
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x8991D34 Offset: 0x898DD34 VA: 0x8991D34
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x8991DF4 Offset: 0x898DDF4 VA: 0x8991DF4
	internal void <Rebuild>b__12_3(Component e) { }
}

// Namespace: UnityEngine.UI
public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 23012
{
	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x8990780 Offset: 0x898C780 VA: 0x8990780
	private void Initialize(RectTransform controller) { }

	// RVA: 0x89907C0 Offset: 0x898C7C0 VA: 0x89907C0
	private void Clear() { }

	// RVA: 0x89907E4 Offset: 0x898C7E4 VA: 0x89907E4
	private static void .cctor() { }

	// RVA: 0x89909D0 Offset: 0x898C9D0 VA: 0x89909D0
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x8990A24 Offset: 0x898CA24 VA: 0x8990A24 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x8990A2C Offset: 0x898CA2C VA: 0x8990A2C Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x8990A8C Offset: 0x898CA8C VA: 0x8990A8C
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x8990B8C Offset: 0x898CB8C VA: 0x8990B8C
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x8990C54 Offset: 0x898CC54 VA: 0x8990C54 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x89911F0 Offset: 0x898D1F0 VA: 0x89911F0
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x8990F20 Offset: 0x898CF20 VA: 0x8990F20
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x898BD68 Offset: 0x8987D68 VA: 0x898BD68
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x89915B8 Offset: 0x898D5B8 VA: 0x89915B8
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x89917AC Offset: 0x898D7AC VA: 0x89917AC
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x89918F0 Offset: 0x898D8F0 VA: 0x89918F0 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x8991970 Offset: 0x898D970 VA: 0x8991970 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x8991974 Offset: 0x898D974 VA: 0x8991974 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x899197C Offset: 0x898D97C VA: 0x899197C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x89919CC Offset: 0x898D9CC VA: 0x89919CC Slot: 3
	public override string ToString() { }

	// RVA: 0x8991A38 Offset: 0x898DA38 VA: 0x8991A38
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LayoutUtility.<>c // TypeDefIndex: 23013
{
	// Fields
	public static readonly LayoutUtility.<>c <>9; // 0x0
	public static Func<ILayoutElement, float> <>9__3_0; // 0x8
	public static Func<ILayoutElement, float> <>9__4_0; // 0x10
	public static Func<ILayoutElement, float> <>9__4_1; // 0x18
	public static Func<ILayoutElement, float> <>9__5_0; // 0x20
	public static Func<ILayoutElement, float> <>9__6_0; // 0x28
	public static Func<ILayoutElement, float> <>9__7_0; // 0x30
	public static Func<ILayoutElement, float> <>9__7_1; // 0x38
	public static Func<ILayoutElement, float> <>9__8_0; // 0x40

	// Methods

	// RVA: 0x8992910 Offset: 0x898E910 VA: 0x8992910
	private static void .cctor() { }

	// RVA: 0x8992978 Offset: 0x898E978 VA: 0x8992978
	public void .ctor() { }

	// RVA: 0x8992980 Offset: 0x898E980 VA: 0x8992980
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x8992A20 Offset: 0x898EA20 VA: 0x8992A20
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x8992AC0 Offset: 0x898EAC0 VA: 0x8992AC0
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x8992B60 Offset: 0x898EB60 VA: 0x8992B60
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x8992C00 Offset: 0x898EC00 VA: 0x8992C00
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x8992CA0 Offset: 0x898ECA0 VA: 0x8992CA0
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x8992D40 Offset: 0x898ED40 VA: 0x8992D40
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x8992DE0 Offset: 0x898EDE0 VA: 0x8992DE0
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }
}

// Namespace: UnityEngine.UI
public static class LayoutUtility // TypeDefIndex: 23014
{
	// Methods

	// RVA: 0x898D1E4 Offset: 0x89891E4 VA: 0x898D1E4
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x898D1F0 Offset: 0x89891F0 VA: 0x898D1F0
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x898FC68 Offset: 0x898BC68 VA: 0x898FC68
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x8991FA4 Offset: 0x898DFA4 VA: 0x8991FA4
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x899223C Offset: 0x898E23C VA: 0x899223C
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x89924D4 Offset: 0x898E4D4 VA: 0x89924D4
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x8991EB4 Offset: 0x898DEB4 VA: 0x8991EB4
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x8992094 Offset: 0x898E094 VA: 0x8992094
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x89923E4 Offset: 0x898E3E4 VA: 0x89923E4
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x89925C4 Offset: 0x898E5C4 VA: 0x89925C4
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x89925DC Offset: 0x898E5DC VA: 0x89925DC
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Vertical Layout Group", 151)]
public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 23015
{
	// Methods

	// RVA: 0x8992E80 Offset: 0x898EE80 VA: 0x8992E80
	protected void .ctor() { }

	// RVA: 0x8992E8C Offset: 0x898EE8C VA: 0x8992E8C Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x8992EAC Offset: 0x898EEAC VA: 0x8992EAC Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x8992EB8 Offset: 0x898EEB8 VA: 0x8992EB8 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x8992EC4 Offset: 0x898EEC4 VA: 0x8992EC4 Slot: 38
	public override void SetLayoutVertical() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[AddComponentMenu("UI/Mask", 13)]
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 23016
{
	// Fields
	private RectTransform m_RectTransform; // 0x20
	[SerializeField]
	private bool m_ShowMaskGraphic; // 0x28
	private Graphic m_Graphic; // 0x30
	private Material m_MaskMaterial; // 0x38
	private Material m_UnmaskMaterial; // 0x40

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x8992ED0 Offset: 0x898EED0 VA: 0x8992ED0
	public RectTransform get_rectTransform() { }

	// RVA: 0x8992F40 Offset: 0x898EF40 VA: 0x8992F40
	public bool get_showMaskGraphic() { }

	// RVA: 0x8992F48 Offset: 0x898EF48 VA: 0x8992F48
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x8992FF8 Offset: 0x898EFF8 VA: 0x8992FF8
	public Graphic get_graphic() { }

	// RVA: 0x8993068 Offset: 0x898F068 VA: 0x8993068
	protected void .ctor() { }

	// RVA: 0x8993078 Offset: 0x898F078 VA: 0x8993078 Slot: 19
	public virtual bool MaskEnabled() { }

	[Obsolete("Not used anymore.")]
	// RVA: 0x8993108 Offset: 0x898F108 VA: 0x8993108 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x899310C Offset: 0x898F10C VA: 0x899310C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x89934DC Offset: 0x898F4DC VA: 0x89934DC Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x89936C0 Offset: 0x898F6C0 VA: 0x89936C0 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x899376C Offset: 0x898F76C VA: 0x899376C Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }
}

// Namespace: 
[Serializable]
public class MaskableGraphic.CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 23017
{
	// Methods

	// RVA: 0x8994C6C Offset: 0x8990C6C VA: 0x8994C6C
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 23018
{
	// Fields
	protected bool m_ShouldRecalculateStencil; // 0xA1
	protected Material m_MaskMaterial; // 0xA8
	private RectMask2D m_ParentMask; // 0xB0
	[SerializeField]
	private bool m_Maskable; // 0xB8
	private bool m_IsMaskingGraphic; // 0xB9
	[EditorBrowsable(1)]
	[Obsolete("Not used anymore.", True)]
	protected bool m_IncludeForMasking; // 0xBA
	[SerializeField]
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xC0
	[Obsolete("Not used anymore", True)]
	[EditorBrowsable(1)]
	protected bool m_ShouldRecalculate; // 0xC8
	protected int m_StencilValue; // 0xCC
	private readonly Vector3[] m_Corners; // 0xD0

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	public bool isMaskingGraphic { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x8993E60 Offset: 0x898FE60 VA: 0x8993E60
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x8993E68 Offset: 0x898FE68 VA: 0x8993E68
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x8993E70 Offset: 0x898FE70 VA: 0x8993E70
	public bool get_maskable() { }

	// RVA: 0x8993E78 Offset: 0x898FE78 VA: 0x8993E78
	public void set_maskable(bool value) { }

	// RVA: 0x8993EA8 Offset: 0x898FEA8 VA: 0x8993EA8
	public bool get_isMaskingGraphic() { }

	// RVA: 0x899326C Offset: 0x898F26C VA: 0x899326C
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x8993EB0 Offset: 0x898FEB0 VA: 0x8993EB0 Slot: 58
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x8993FC0 Offset: 0x898FFC0 VA: 0x8993FC0 Slot: 59
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x8994248 Offset: 0x8990248 VA: 0x8994248
	private void UpdateCull(bool cull) { }

	// RVA: 0x899432C Offset: 0x899032C VA: 0x899432C Slot: 60
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x8994398 Offset: 0x8990398 VA: 0x8994398 Slot: 61
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x89943D0 Offset: 0x89903D0 VA: 0x89943D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x8994580 Offset: 0x8990580 VA: 0x8994580 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x8994648 Offset: 0x8990648 VA: 0x8994648 Slot: 12
	protected override void OnTransformParentChanged() { }

	[Obsolete("Not used anymore.", True)]
	[EditorBrowsable(1)]
	// RVA: 0x8994698 Offset: 0x8990698 VA: 0x8994698 Slot: 62
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x899469C Offset: 0x899069C VA: 0x899469C Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x8994090 Offset: 0x8990090 VA: 0x8994090
	private Rect get_rootCanvasRect() { }

	// RVA: 0x8994420 Offset: 0x8990420 VA: 0x8994420
	private void UpdateClipParent() { }

	// RVA: 0x8994B00 Offset: 0x8990B00 VA: 0x8994B00 Slot: 63
	public virtual void RecalculateClipping() { }

	// RVA: 0x8994B04 Offset: 0x8990B04 VA: 0x8994B04 Slot: 64
	public virtual void RecalculateMasking() { }

	// RVA: 0x8994B98 Offset: 0x8990B98 VA: 0x8994B98
	protected void .ctor() { }

	// RVA: 0x8994CB4 Offset: 0x8990CB4 VA: 0x8994CB4 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }
}

// Namespace: UnityEngine.UI
public class MaskUtilities // TypeDefIndex: 23019
{
	// Methods

	// RVA: 0x8994CBC Offset: 0x8990CBC VA: 0x8994CBC
	public static void Notify2DMaskStateChanged(Component mask) { }

	// RVA: 0x8993284 Offset: 0x898F284 VA: 0x8993284
	public static void NotifyStencilStateChanged(Component mask) { }

	// RVA: 0x8993A38 Offset: 0x898FA38 VA: 0x8993A38
	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x8993BD8 Offset: 0x898FBD8 VA: 0x8993BD8
	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	// RVA: 0x8994F18 Offset: 0x8990F18 VA: 0x8994F18
	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	// RVA: 0x89946EC Offset: 0x89906EC VA: 0x89946EC
	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	// RVA: 0x8995070 Offset: 0x8991070 VA: 0x8995070
	public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks) { }

	// RVA: 0x89953D4 Offset: 0x89913D4 VA: 0x89953D4
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public interface IMaterialModifier // TypeDefIndex: 23020
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material GetModifiedMaterial(Material baseMaterial);
}

// Namespace: UnityEngine.UI
internal static class Misc // TypeDefIndex: 23021
{
	// Methods

	// RVA: 0x89953DC Offset: 0x89913DC VA: 0x89953DC
	public static void Destroy(Object obj) { }

	// RVA: 0x8995500 Offset: 0x8991500 VA: 0x8995500
	public static void DestroyImmediate(Object obj) { }
}

// Namespace: UnityEngine.UI
internal static class MultipleDisplayUtilities // TypeDefIndex: 23022
{
	// Methods

	// RVA: 0x89955CC Offset: 0x89915CC VA: 0x89955CC
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position) { }

	// RVA: 0x8995994 Offset: 0x8991994 VA: 0x8995994
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	// RVA: 0x8995638 Offset: 0x8991638 VA: 0x8995638
	public static Vector3 RelativeMouseAtScaled(Vector2 position, int displayIndex) { }
}

// Namespace: 
[Flags]
public enum Navigation.Mode // TypeDefIndex: 23023
{
	// Fields
	public int value__; // 0x0
	public const Navigation.Mode None = 0;
	public const Navigation.Mode Horizontal = 1;
	public const Navigation.Mode Vertical = 2;
	public const Navigation.Mode Automatic = 3;
	public const Navigation.Mode Explicit = 4;
}

// Namespace: UnityEngine.UI
[Serializable]
public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 23024
{
	// Fields
	[SerializeField]
	private Navigation.Mode m_Mode; // 0x0
	[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
	[SerializeField]
	private bool m_WrapAround; // 0x4
	[SerializeField]
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField]
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField]
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField]
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public bool wrapAround { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0x8995A5C Offset: 0x8991A5C VA: 0x8995A5C
	public Navigation.Mode get_mode() { }

	// RVA: 0x8995A64 Offset: 0x8991A64 VA: 0x8995A64
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0x8995A6C Offset: 0x8991A6C VA: 0x8995A6C
	public bool get_wrapAround() { }

	// RVA: 0x8995A74 Offset: 0x8991A74 VA: 0x8995A74
	public void set_wrapAround(bool value) { }

	// RVA: 0x8995A80 Offset: 0x8991A80 VA: 0x8995A80
	public Selectable get_selectOnUp() { }

	// RVA: 0x8995A88 Offset: 0x8991A88 VA: 0x8995A88
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x8995A90 Offset: 0x8991A90 VA: 0x8995A90
	public Selectable get_selectOnDown() { }

	// RVA: 0x8995A98 Offset: 0x8991A98 VA: 0x8995A98
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x8995AA0 Offset: 0x8991AA0 VA: 0x8995AA0
	public Selectable get_selectOnLeft() { }

	// RVA: 0x8995AA8 Offset: 0x8991AA8 VA: 0x8995AA8
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x8995AB0 Offset: 0x8991AB0 VA: 0x8995AB0
	public Selectable get_selectOnRight() { }

	// RVA: 0x8995AB8 Offset: 0x8991AB8 VA: 0x8995AB8
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x8995AC0 Offset: 0x8991AC0 VA: 0x8995AC0
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x8995AE0 Offset: 0x8991AE0 VA: 0x8995AE0 Slot: 4
	public bool Equals(Navigation other) { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Raw Image", 12)]
public class RawImage : MaskableGraphic // TypeDefIndex: 23025
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_Tex")]
	private Texture m_Texture; // 0xD8
	[SerializeField]
	private Rect m_UVRect; // 0xE0

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x8995BF8 Offset: 0x8991BF8 VA: 0x8995BF8
	protected void .ctor() { }

	// RVA: 0x8995C20 Offset: 0x8991C20 VA: 0x8995C20 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x8995D78 Offset: 0x8991D78 VA: 0x8995D78
	public Texture get_texture() { }

	// RVA: 0x8995D80 Offset: 0x8991D80 VA: 0x8995D80
	public void set_texture(Texture value) { }

	// RVA: 0x8995E3C Offset: 0x8991E3C VA: 0x8995E3C
	public Rect get_uvRect() { }

	// RVA: 0x8995E48 Offset: 0x8991E48 VA: 0x8995E48
	public void set_uvRect(Rect value) { }

	// RVA: 0x8995E94 Offset: 0x8991E94 VA: 0x8995E94 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x8996148 Offset: 0x8992148 VA: 0x8996148 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x89967CC Offset: 0x89927CC VA: 0x89967CC Slot: 13
	protected override void OnDidApplyAnimationProperties() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[AddComponentMenu("UI/Rect Mask 2D", 14)]
[ExecuteAlways]
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 23026
{
	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x20
	private RectTransform m_RectTransform; // 0x28
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x30
	private HashSet<IClippable> m_ClipTargets; // 0x38
	private bool m_ShouldRecalculateClipRects; // 0x40
	private List<RectMask2D> m_Clippers; // 0x48
	private Rect m_LastClipRectCanvasSpace; // 0x50
	private bool m_ForceClip; // 0x60
	[SerializeField]
	private Vector4 m_Padding; // 0x64
	[SerializeField]
	private Vector2Int m_Softness; // 0x74
	private Canvas m_Canvas; // 0x80
	private Vector3[] m_Corners; // 0x88

	// Properties
	public Vector4 padding { get; set; }
	public Vector2Int softness { get; set; }
	internal Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x8996808 Offset: 0x8992808 VA: 0x8996808
	public Vector4 get_padding() { }

	// RVA: 0x8996814 Offset: 0x8992814 VA: 0x8996814
	public void set_padding(Vector4 value) { }

	// RVA: 0x8996824 Offset: 0x8992824 VA: 0x8996824
	public Vector2Int get_softness() { }

	// RVA: 0x899682C Offset: 0x899282C VA: 0x899682C
	public void set_softness(Vector2Int value) { }

	// RVA: 0x8996844 Offset: 0x8992844 VA: 0x8996844
	internal Canvas get_Canvas() { }

	// RVA: 0x89969C4 Offset: 0x89929C4 VA: 0x89969C4
	public Rect get_canvasRect() { }

	// RVA: 0x8996A08 Offset: 0x8992A08 VA: 0x8996A08
	public RectTransform get_rectTransform() { }

	// RVA: 0x8996A78 Offset: 0x8992A78 VA: 0x8996A78
	protected void .ctor() { }

	// RVA: 0x8996C18 Offset: 0x8992C18 VA: 0x8996C18 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x8996C4C Offset: 0x8992C4C VA: 0x8996C4C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x8996D1C Offset: 0x8992D1C VA: 0x8996D1C Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x8996D3C Offset: 0x8992D3C VA: 0x8996D3C Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x8996E18 Offset: 0x8992E18 VA: 0x8996E18
	private Rect get_rootCanvasRect() { }

	// RVA: 0x8996F14 Offset: 0x8992F14 VA: 0x8996F14 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x8997730 Offset: 0x8993730 VA: 0x8997730 Slot: 21
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x8997A28 Offset: 0x8993A28 VA: 0x8997A28
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x8997B3C Offset: 0x8993B3C VA: 0x8997B3C
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x8997CDC Offset: 0x8993CDC VA: 0x8997CDC Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x8997D0C Offset: 0x8993D0C VA: 0x8997D0C Slot: 15
	protected override void OnCanvasHierarchyChanged() { }
}

// Namespace: 
public enum Scrollbar.Direction // TypeDefIndex: 23027
{
	// Fields
	public int value__; // 0x0
	public const Scrollbar.Direction LeftToRight = 0;
	public const Scrollbar.Direction RightToLeft = 1;
	public const Scrollbar.Direction BottomToTop = 2;
	public const Scrollbar.Direction TopToBottom = 3;
}

// Namespace: 
[Serializable]
public class Scrollbar.ScrollEvent : UnityEvent<float> // TypeDefIndex: 23028
{
	// Methods

	// RVA: 0x89981B0 Offset: 0x89941B0 VA: 0x89981B0
	public void .ctor() { }
}

// Namespace: 
private enum Scrollbar.Axis // TypeDefIndex: 23029
{
	// Fields
	public int value__; // 0x0
	public const Scrollbar.Axis Horizontal = 0;
	public const Scrollbar.Axis Vertical = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class Scrollbar.<ClickRepeat>d__58 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23030
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Scrollbar <>4__this; // 0x20
	public Vector2 screenPosition; // 0x28
	public Camera camera; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x89992B8 Offset: 0x89952B8 VA: 0x89992B8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x8999B8C Offset: 0x8995B8C VA: 0x8999B8C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8999B90 Offset: 0x8995B90 VA: 0x8999B90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8999DF4 Offset: 0x8995DF4 VA: 0x8999DF4 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x8999DFC Offset: 0x8995DFC VA: 0x8999DFC Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x8999E34 Offset: 0x8995E34 VA: 0x8999E34 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
[AddComponentMenu("UI/Scrollbar", 36)]
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 23031
{
	// Fields
	[SerializeField]
	private RectTransform m_HandleRect; // 0x100
	[SerializeField]
	private Scrollbar.Direction m_Direction; // 0x108
	[Range(0, 1)]
	[SerializeField]
	private float m_Value; // 0x10C
	[Range(0, 1)]
	[SerializeField]
	private float m_Size; // 0x110
	[Range(0, 11)]
	[SerializeField]
	private int m_NumberOfSteps; // 0x114
	[Space(6)]
	[SerializeField]
	private Scrollbar.ScrollEvent m_OnValueChanged; // 0x118
	private RectTransform m_ContainerRect; // 0x120
	private Vector2 m_Offset; // 0x128
	private DrivenRectTransformTracker m_Tracker; // 0x130
	private Coroutine m_PointerDownRepeat; // 0x138
	private bool isPointerDownAndNotDragging; // 0x140
	private bool m_DelayedUpdateVisuals; // 0x141

	// Properties
	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x8997D3C Offset: 0x8993D3C VA: 0x8997D3C
	public RectTransform get_handleRect() { }

	// RVA: 0x8997D44 Offset: 0x8993D44 VA: 0x8997D44
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x8998068 Offset: 0x8994068 VA: 0x8998068
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x8998070 Offset: 0x8994070 VA: 0x8998070
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x89980E4 Offset: 0x89940E4 VA: 0x89980E4
	protected void .ctor() { }

	// RVA: 0x8998338 Offset: 0x8994338 VA: 0x8998338
	public float get_value() { }

	// RVA: 0x89983F0 Offset: 0x89943F0 VA: 0x89983F0
	public void set_value(float value) { }

	// RVA: 0x89984BC Offset: 0x89944BC VA: 0x89984BC Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x89984C4 Offset: 0x89944C4 VA: 0x89984C4
	public float get_size() { }

	// RVA: 0x89984CC Offset: 0x89944CC VA: 0x89984CC
	public void set_size(float value) { }

	// RVA: 0x8998550 Offset: 0x8994550 VA: 0x8998550
	public int get_numberOfSteps() { }

	// RVA: 0x8998558 Offset: 0x8994558 VA: 0x8998558
	public void set_numberOfSteps(int value) { }

	// RVA: 0x89985DC Offset: 0x89945DC VA: 0x89985DC
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0x89985E4 Offset: 0x89945E4 VA: 0x89985E4
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x89985F4 Offset: 0x89945F4 VA: 0x89985F4
	private float get_stepSize() { }

	// RVA: 0x8998620 Offset: 0x8994620 VA: 0x8998620 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x8998624 Offset: 0x8994624 VA: 0x8998624 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x8998628 Offset: 0x8994628 VA: 0x8998628 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x899862C Offset: 0x899462C VA: 0x899862C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x899892C Offset: 0x899492C VA: 0x899892C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x8998A84 Offset: 0x8994A84 VA: 0x8998A84 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x8997DC0 Offset: 0x8993DC0 VA: 0x8997DC0
	private void UpdateCachedReferences() { }

	// RVA: 0x89983F8 Offset: 0x89943F8 VA: 0x89983F8
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x8998A98 Offset: 0x8994A98 VA: 0x8998A98 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x8998AD0 Offset: 0x8994AD0 VA: 0x8998AD0
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x8998AE0 Offset: 0x8994AE0 VA: 0x8998AE0
	private bool get_reverseValue() { }

	// RVA: 0x8997EB0 Offset: 0x8993EB0 VA: 0x8997EB0
	private void UpdateVisuals() { }

	// RVA: 0x8998AF4 Offset: 0x8994AF4 VA: 0x8998AF4
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x8998D04 Offset: 0x8994D04 VA: 0x8998D04
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x8998D6C Offset: 0x8994D6C VA: 0x8998D6C
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x8998DD0 Offset: 0x8994DD0 VA: 0x8998DD0 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x8998F84 Offset: 0x8994F84 VA: 0x8998F84 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x8999014 Offset: 0x8995014 VA: 0x8999014 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x8999278 Offset: 0x8995278 VA: 0x8999278
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(Scrollbar.<ClickRepeat>d__58))]
	// RVA: 0x89991DC Offset: 0x89951DC VA: 0x89991DC
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x89992E0 Offset: 0x89952E0 VA: 0x89992E0 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x8999320 Offset: 0x8995320 VA: 0x8999320 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x89995F4 Offset: 0x89955F4 VA: 0x89995F4 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x89996F0 Offset: 0x89956F0 VA: 0x89996F0 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x89997EC Offset: 0x89957EC VA: 0x89997EC Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x89998E8 Offset: 0x89958E8 VA: 0x89998E8 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x89999E4 Offset: 0x89959E4 VA: 0x89999E4 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x89999FC Offset: 0x89959FC VA: 0x89999FC
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x8999B84 Offset: 0x8995B84 VA: 0x8999B84 Slot: 43
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum ScrollRect.MovementType // TypeDefIndex: 23032
{
	// Fields
	public int value__; // 0x0
	public const ScrollRect.MovementType Unrestricted = 0;
	public const ScrollRect.MovementType Elastic = 1;
	public const ScrollRect.MovementType Clamped = 2;
}

// Namespace: 
public enum ScrollRect.ScrollbarVisibility // TypeDefIndex: 23033
{
	// Fields
	public int value__; // 0x0
	public const ScrollRect.ScrollbarVisibility Permanent = 0;
	public const ScrollRect.ScrollbarVisibility AutoHide = 1;
	public const ScrollRect.ScrollbarVisibility AutoHideAndExpandViewport = 2;
}

// Namespace: 
[Serializable]
public class ScrollRect.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 23034
{
	// Methods

	// RVA: 0x899A6A4 Offset: 0x89966A4 VA: 0x899A6A4
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[ExecuteAlways]
[SelectionBase]
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Scroll Rect", 37)]
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 23035
{
	// Fields
	[SerializeField]
	private RectTransform m_Content; // 0x20
	[SerializeField]
	private bool m_Horizontal; // 0x28
	[SerializeField]
	private bool m_Vertical; // 0x29
	[SerializeField]
	private ScrollRect.MovementType m_MovementType; // 0x2C
	[SerializeField]
	private float m_Elasticity; // 0x30
	[SerializeField]
	private bool m_Inertia; // 0x34
	[SerializeField]
	private float m_DecelerationRate; // 0x38
	[SerializeField]
	private float m_ScrollSensitivity; // 0x3C
	[SerializeField]
	private RectTransform m_Viewport; // 0x40
	[SerializeField]
	private Scrollbar m_HorizontalScrollbar; // 0x48
	[SerializeField]
	private Scrollbar m_VerticalScrollbar; // 0x50
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x58
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x5C
	[SerializeField]
	private float m_HorizontalScrollbarSpacing; // 0x60
	[SerializeField]
	private float m_VerticalScrollbarSpacing; // 0x64
	[SerializeField]
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x68
	private Vector2 m_PointerStartLocalCursor; // 0x70
	protected Vector2 m_ContentStartPosition; // 0x78
	private RectTransform m_ViewRect; // 0x80
	protected Bounds m_ContentBounds; // 0x88
	private Bounds m_ViewBounds; // 0xA0
	private Vector2 m_Velocity; // 0xB8
	private bool m_Dragging; // 0xC0
	private bool m_Scrolling; // 0xC1
	private Vector2 m_PrevPosition; // 0xC4
	private Bounds m_PrevContentBounds; // 0xCC
	private Bounds m_PrevViewBounds; // 0xE4
	private bool m_HasRebuiltLayout; // 0xFC
	private bool m_HSliderExpand; // 0xFD
	private bool m_VSliderExpand; // 0xFE
	private float m_HSliderHeight; // 0x100
	private float m_VSliderWidth; // 0x104
	private RectTransform m_Rect; // 0x108
	private RectTransform m_HorizontalScrollbarRect; // 0x110
	private RectTransform m_VerticalScrollbarRect; // 0x118
	private DrivenRectTransformTracker m_Tracker; // 0x120
	private readonly Vector3[] m_Corners; // 0x128

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x8999E3C Offset: 0x8995E3C VA: 0x8999E3C
	public RectTransform get_content() { }

	// RVA: 0x8999E44 Offset: 0x8995E44 VA: 0x8999E44
	public void set_content(RectTransform value) { }

	// RVA: 0x8999E4C Offset: 0x8995E4C VA: 0x8999E4C
	public bool get_horizontal() { }

	// RVA: 0x8999E54 Offset: 0x8995E54 VA: 0x8999E54
	public void set_horizontal(bool value) { }

	// RVA: 0x8999E60 Offset: 0x8995E60 VA: 0x8999E60
	public bool get_vertical() { }

	// RVA: 0x8999E68 Offset: 0x8995E68 VA: 0x8999E68
	public void set_vertical(bool value) { }

	// RVA: 0x8999E74 Offset: 0x8995E74 VA: 0x8999E74
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x8999E7C Offset: 0x8995E7C VA: 0x8999E7C
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x8999E84 Offset: 0x8995E84 VA: 0x8999E84
	public float get_elasticity() { }

	// RVA: 0x8999E8C Offset: 0x8995E8C VA: 0x8999E8C
	public void set_elasticity(float value) { }

	// RVA: 0x8999E94 Offset: 0x8995E94 VA: 0x8999E94
	public bool get_inertia() { }

	// RVA: 0x8999E9C Offset: 0x8995E9C VA: 0x8999E9C
	public void set_inertia(bool value) { }

	// RVA: 0x8999EA8 Offset: 0x8995EA8 VA: 0x8999EA8
	public float get_decelerationRate() { }

	// RVA: 0x8999EB0 Offset: 0x8995EB0 VA: 0x8999EB0
	public void set_decelerationRate(float value) { }

	// RVA: 0x8999EB8 Offset: 0x8995EB8 VA: 0x8999EB8
	public float get_scrollSensitivity() { }

	// RVA: 0x8999EC0 Offset: 0x8995EC0 VA: 0x8999EC0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x8999EC8 Offset: 0x8995EC8 VA: 0x8999EC8
	public RectTransform get_viewport() { }

	// RVA: 0x8999ED0 Offset: 0x8995ED0 VA: 0x8999ED0
	public void set_viewport(RectTransform value) { }

	// RVA: 0x8999FB4 Offset: 0x8995FB4 VA: 0x8999FB4
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x8999FBC Offset: 0x8995FBC VA: 0x8999FBC
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x899A154 Offset: 0x8996154 VA: 0x899A154
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x899A15C Offset: 0x899615C VA: 0x899A15C
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x899A2F4 Offset: 0x89962F4 VA: 0x899A2F4
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x899A2FC Offset: 0x89962FC VA: 0x899A2FC
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x899A304 Offset: 0x8996304 VA: 0x899A304
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x899A30C Offset: 0x899630C VA: 0x899A30C
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x899A314 Offset: 0x8996314 VA: 0x899A314
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x899A31C Offset: 0x899631C VA: 0x899A31C
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x899A3AC Offset: 0x89963AC VA: 0x899A3AC
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x899A3B4 Offset: 0x89963B4 VA: 0x899A3B4
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x899A3BC Offset: 0x89963BC VA: 0x899A3BC
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x899A3C4 Offset: 0x89963C4 VA: 0x899A3C4
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x899A3CC Offset: 0x89963CC VA: 0x899A3CC
	protected RectTransform get_viewRect() { }

	// RVA: 0x899A4DC Offset: 0x89964DC VA: 0x899A4DC
	public Vector2 get_velocity() { }

	// RVA: 0x899A4E4 Offset: 0x89964E4 VA: 0x899A4E4
	public void set_velocity(Vector2 value) { }

	// RVA: 0x899A4EC Offset: 0x89964EC VA: 0x899A4EC
	private RectTransform get_rectTransform() { }

	// RVA: 0x899A58C Offset: 0x899658C VA: 0x899A58C
	protected void .ctor() { }

	// RVA: 0x899A6EC Offset: 0x89966EC VA: 0x899A6EC Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x899B09C Offset: 0x899709C VA: 0x899B09C Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x899B0A0 Offset: 0x89970A0 VA: 0x899B0A0 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x899A774 Offset: 0x8996774 VA: 0x899A774
	private void UpdateCachedData() { }

	// RVA: 0x899B0A4 Offset: 0x89970A4 VA: 0x899B0A4 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x899B260 Offset: 0x8997260 VA: 0x899B260 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x899B490 Offset: 0x8997490 VA: 0x899B490 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x899B510 Offset: 0x8997510 VA: 0x899B510
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x899B584 Offset: 0x8997584 VA: 0x899B584 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x899B5D4 Offset: 0x89975D4 VA: 0x899B5D4 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x899B770 Offset: 0x8997770 VA: 0x899B770 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x899B7D0 Offset: 0x89977D0 VA: 0x899B7D0 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x899B8FC Offset: 0x89978FC VA: 0x899B8FC Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x899B91C Offset: 0x899791C VA: 0x899B91C Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x899BB50 Offset: 0x8997B50 VA: 0x899BB50 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x899BC04 Offset: 0x8997C04 VA: 0x899BC04 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x899AFC4 Offset: 0x8996FC4 VA: 0x899AFC4
	protected void UpdatePrevData() { }

	// RVA: 0x899AE44 Offset: 0x8996E44 VA: 0x899AE44
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x899C1DC Offset: 0x89981DC VA: 0x899C1DC
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x899C44C Offset: 0x899844C VA: 0x899C44C
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x899C24C Offset: 0x899824C VA: 0x899C24C
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x899C494 Offset: 0x8998494 VA: 0x899C494
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x899C34C Offset: 0x899834C VA: 0x899C34C
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x899C4A8 Offset: 0x89984A8 VA: 0x899C4A8
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x899C4BC Offset: 0x89984BC VA: 0x899C4BC
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x899C4D0 Offset: 0x89984D0 VA: 0x899C4D0
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x899C4E4 Offset: 0x89984E4 VA: 0x899C4E4 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x899BB18 Offset: 0x8997B18 VA: 0x899BB18
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x899C77C Offset: 0x899877C VA: 0x899C77C Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x899C780 Offset: 0x8998780 VA: 0x899C780
	private bool get_hScrollingNeeded() { }

	// RVA: 0x899C808 Offset: 0x8998808 VA: 0x899C808
	private bool get_vScrollingNeeded() { }

	// RVA: 0x899C890 Offset: 0x8998890 VA: 0x899C890 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x899C894 Offset: 0x8998894 VA: 0x899C894 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x899C898 Offset: 0x8998898 VA: 0x899C898 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0x899C8A0 Offset: 0x89988A0 VA: 0x899C8A0 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0x899C8A8 Offset: 0x89988A8 VA: 0x899C8A8 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0x899C8B0 Offset: 0x89988B0 VA: 0x899C8B0 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0x899C8B8 Offset: 0x89988B8 VA: 0x899C8B8 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0x899C8C0 Offset: 0x89988C0 VA: 0x899C8C0 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x899C8C8 Offset: 0x89988C8 VA: 0x899C8C8 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x899C8D0 Offset: 0x89988D0 VA: 0x899C8D0 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x899CEA8 Offset: 0x8998EA8 VA: 0x899CEA8 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x899C20C Offset: 0x899820C VA: 0x899C20C
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x899D1B4 Offset: 0x89991B4 VA: 0x899D1B4
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x899CF60 Offset: 0x8998F60 VA: 0x899CF60
	private void UpdateScrollbarLayout() { }

	// RVA: 0x899AAEC Offset: 0x8996AEC VA: 0x899AAEC
	protected void UpdateBounds() { }

	// RVA: 0x899D2B8 Offset: 0x89992B8 VA: 0x899D2B8
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x899CDB4 Offset: 0x8998DB4 VA: 0x899CDB4
	private Bounds GetBounds() { }

	// RVA: 0x899D334 Offset: 0x8999334 VA: 0x899D334
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x899B740 Offset: 0x8997740 VA: 0x899B740
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x899D4C4 Offset: 0x89994C4 VA: 0x899D4C4
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x899A324 Offset: 0x8996324 VA: 0x899A324
	protected void SetDirty() { }

	// RVA: 0x8999EEC Offset: 0x8995EEC VA: 0x8999EEC
	protected void SetDirtyCaching() { }

	// RVA: 0x899D608 Offset: 0x8999608 VA: 0x899D608 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum Selectable.Transition // TypeDefIndex: 23036
{
	// Fields
	public int value__; // 0x0
	public const Selectable.Transition None = 0;
	public const Selectable.Transition ColorTint = 1;
	public const Selectable.Transition SpriteSwap = 2;
	public const Selectable.Transition Animation = 3;
}

// Namespace: 
protected enum Selectable.SelectionState // TypeDefIndex: 23037
{
	// Fields
	public int value__; // 0x0
	public const Selectable.SelectionState Normal = 0;
	public const Selectable.SelectionState Highlighted = 1;
	public const Selectable.SelectionState Pressed = 2;
	public const Selectable.SelectionState Selected = 3;
	public const Selectable.SelectionState Disabled = 4;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Selectable", 35)]
[SelectionBase]
[ExecuteAlways]
[DisallowMultipleComponent]
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 23038
{
	// Fields
	protected static Selectable[] s_Selectables; // 0x0
	protected static int s_SelectableCount; // 0x8
	private bool m_EnableCalled; // 0x20
	[FormerlySerializedAs("navigation")]
	[SerializeField]
	private Navigation m_Navigation; // 0x28
	[SerializeField]
	[FormerlySerializedAs("transition")]
	private Selectable.Transition m_Transition; // 0x50
	[SerializeField]
	[FormerlySerializedAs("colors")]
	private ColorBlock m_Colors; // 0x54
	[SerializeField]
	[FormerlySerializedAs("spriteState")]
	private SpriteState m_SpriteState; // 0xB0
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	private AnimationTriggers m_AnimationTriggers; // 0xD0
	[Tooltip("Can the Selectable be interacted with?")]
	[SerializeField]
	private bool m_Interactable; // 0xD8
	[FormerlySerializedAs("highlightGraphic")]
	[FormerlySerializedAs("m_HighlightGraphic")]
	[SerializeField]
	private Graphic m_TargetGraphic; // 0xE0
	private bool m_GroupsAllowInteraction; // 0xE8
	protected int m_CurrentIndex; // 0xEC
	[CompilerGenerated]
	private bool <isPointerInside>k__BackingField; // 0xF0
	[CompilerGenerated]
	private bool <isPointerDown>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <hasSelection>k__BackingField; // 0xF2
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xF8

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	public static List<Selectable> allSelectables { get; }
	public Navigation navigation { get; set; }
	public Selectable.Transition transition { get; set; }
	public ColorBlock colors { get; set; }
	public SpriteState spriteState { get; set; }
	public AnimationTriggers animationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool interactable { get; set; }
	private bool isPointerInside { get; set; }
	private bool isPointerDown { get; set; }
	private bool hasSelection { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	protected Selectable.SelectionState currentSelectionState { get; }

	// Methods

	// RVA: 0x899D610 Offset: 0x8999610 VA: 0x899D610
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x899D6AC Offset: 0x89996AC VA: 0x899D6AC
	public static int get_allSelectableCount() { }

	// RVA: 0x899D704 Offset: 0x8999704 VA: 0x899D704
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x899D7A0 Offset: 0x89997A0 VA: 0x899D7A0
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x899D85C Offset: 0x899985C VA: 0x899D85C
	public Navigation get_navigation() { }

	// RVA: 0x899D874 Offset: 0x8999874 VA: 0x899D874
	public void set_navigation(Navigation value) { }

	// RVA: 0x899D960 Offset: 0x8999960 VA: 0x899D960
	public Selectable.Transition get_transition() { }

	// RVA: 0x899D968 Offset: 0x8999968 VA: 0x899D968
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x899D9DC Offset: 0x89999DC VA: 0x899D9DC
	public ColorBlock get_colors() { }

	// RVA: 0x899D9EC Offset: 0x89999EC VA: 0x899D9EC
	public void set_colors(ColorBlock value) { }

	// RVA: 0x899DA84 Offset: 0x8999A84 VA: 0x899DA84
	public SpriteState get_spriteState() { }

	// RVA: 0x899DA90 Offset: 0x8999A90 VA: 0x899DA90
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x899DB0C Offset: 0x8999B0C VA: 0x899DB0C
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x899DB14 Offset: 0x8999B14 VA: 0x899DB14
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x899DB88 Offset: 0x8999B88 VA: 0x899DB88
	public Graphic get_targetGraphic() { }

	// RVA: 0x899DB90 Offset: 0x8999B90 VA: 0x899DB90
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x899DC04 Offset: 0x8999C04 VA: 0x899DC04
	public bool get_interactable() { }

	// RVA: 0x899DC0C Offset: 0x8999C0C VA: 0x899DC0C
	public void set_interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x899DD7C Offset: 0x8999D7C VA: 0x899DD7C
	private bool get_isPointerInside() { }

	[CompilerGenerated]
	// RVA: 0x899DD84 Offset: 0x8999D84 VA: 0x899DD84
	private void set_isPointerInside(bool value) { }

	[CompilerGenerated]
	// RVA: 0x899DD90 Offset: 0x8999D90 VA: 0x899DD90
	private bool get_isPointerDown() { }

	[CompilerGenerated]
	// RVA: 0x899DD98 Offset: 0x8999D98 VA: 0x899DD98
	private void set_isPointerDown(bool value) { }

	[CompilerGenerated]
	// RVA: 0x899DDA4 Offset: 0x8999DA4 VA: 0x899DDA4
	private bool get_hasSelection() { }

	[CompilerGenerated]
	// RVA: 0x899DDAC Offset: 0x8999DAC VA: 0x899DDAC
	private void set_hasSelection(bool value) { }

	// RVA: 0x89981F8 Offset: 0x89941F8 VA: 0x89981F8
	protected void .ctor() { }

	// RVA: 0x899DDB8 Offset: 0x8999DB8 VA: 0x899DDB8
	public Image get_image() { }

	// RVA: 0x899DE34 Offset: 0x8999E34 VA: 0x899DE34
	public void set_image(Image value) { }

	// RVA: 0x899DE3C Offset: 0x8999E3C VA: 0x899DE3C
	public Animator get_animator() { }

	// RVA: 0x899DE84 Offset: 0x8999E84 VA: 0x899DE84 Slot: 4
	protected override void Awake() { }

	// RVA: 0x899DF34 Offset: 0x8999F34 VA: 0x899DF34 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x899DF68 Offset: 0x8999F68 VA: 0x899DF68
	private bool ParentGroupAllowsInteraction() { }

	// RVA: 0x899E0E0 Offset: 0x899A0E0 VA: 0x899E0E0 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x899E100 Offset: 0x899A100 VA: 0x899E100 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x899865C Offset: 0x899465C VA: 0x899865C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x899E154 Offset: 0x899A154 VA: 0x899E154 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x899D8FC Offset: 0x89998FC VA: 0x899D8FC
	private void OnSetProperty() { }

	// RVA: 0x899894C Offset: 0x899494C VA: 0x899894C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x899E17C Offset: 0x899A17C VA: 0x899E17C
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x899E104 Offset: 0x899A104 VA: 0x899E104
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x899E224 Offset: 0x899A224 VA: 0x899E224 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x899E5D4 Offset: 0x899A5D4 VA: 0x899E5D4 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x899E848 Offset: 0x899A848 VA: 0x899E848
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x899ECFC Offset: 0x899ACFC VA: 0x899ECFC
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x899EE7C Offset: 0x899AE7C VA: 0x899EE7C
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x8999618 Offset: 0x8995618 VA: 0x8999618 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x8999714 Offset: 0x8995714 VA: 0x8999714 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x8999810 Offset: 0x8995810 VA: 0x8999810 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x899990C Offset: 0x899590C VA: 0x899990C Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x8999568 Offset: 0x8995568 VA: 0x8999568 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x899E294 Offset: 0x899A294 VA: 0x899E294
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x899E3A4 Offset: 0x899A3A4 VA: 0x899E3A4
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x899E44C Offset: 0x899A44C VA: 0x899E44C
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x899EF34 Offset: 0x899AF34 VA: 0x899EF34
	protected bool IsHighlighted() { }

	// RVA: 0x899E1D8 Offset: 0x899A1D8 VA: 0x899E1D8
	protected bool IsPressed() { }

	// RVA: 0x899EF90 Offset: 0x899AF90 VA: 0x899EF90
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x89990AC Offset: 0x89950AC VA: 0x89990AC Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x89992F8 Offset: 0x89952F8 VA: 0x89992F8 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x899F028 Offset: 0x899B028 VA: 0x899F028 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x899F034 Offset: 0x899B034 VA: 0x899F034 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x899F03C Offset: 0x899B03C VA: 0x899F03C Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x899F048 Offset: 0x899B048 VA: 0x899F048 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x899F050 Offset: 0x899B050 VA: 0x899F050 Slot: 38
	public virtual void Select() { }

	// RVA: 0x899F154 Offset: 0x899B154 VA: 0x899F154
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
internal static class SetPropertyUtility // TypeDefIndex: 23039
{
	// Methods

	// RVA: 0x899F1D8 Offset: 0x899B1D8 VA: 0x899F1D8
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	// RVA: -1 Offset: -1
	public static bool SetStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F2FE4 Offset: 0x46EEFE4 VA: 0x46F2FE4
	|-SetPropertyUtility.SetStruct<bool>
	|
	|-RVA: 0x46F3050 Offset: 0x46EF050 VA: 0x46F3050
	|-SetPropertyUtility.SetStruct<char>
	|
	|-RVA: 0x46F30B8 Offset: 0x46EF0B8 VA: 0x46F30B8
	|-SetPropertyUtility.SetStruct<ColorBlock>
	|
	|-RVA: 0x46F3194 Offset: 0x46EF194 VA: 0x46F3194
	|-SetPropertyUtility.SetStruct<int>
	|
	|-RVA: 0x46F31FC Offset: 0x46EF1FC VA: 0x46F31FC
	|-SetPropertyUtility.SetStruct<Int32Enum>
	|
	|-RVA: 0x46F3264 Offset: 0x46EF264 VA: 0x46F3264
	|-SetPropertyUtility.SetStruct<Navigation>
	|
	|-RVA: 0x46F3334 Offset: 0x46EF334 VA: 0x46F3334
	|-SetPropertyUtility.SetStruct<float>
	|
	|-RVA: 0x46F33A4 Offset: 0x46EF3A4 VA: 0x46F33A4
	|-SetPropertyUtility.SetStruct<SpriteState>
	|
	|-RVA: 0x46F344C Offset: 0x46EF44C VA: 0x46F344C
	|-SetPropertyUtility.SetStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetClass<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F2F88 Offset: 0x46EEF88 VA: 0x46F2F88
	|-SetPropertyUtility.SetClass<object>
	*/
}

// Namespace: 
public enum Slider.Direction // TypeDefIndex: 23040
{
	// Fields
	public int value__; // 0x0
	public const Slider.Direction LeftToRight = 0;
	public const Slider.Direction RightToLeft = 1;
	public const Slider.Direction BottomToTop = 2;
	public const Slider.Direction TopToBottom = 3;
}

// Namespace: 
[Serializable]
public class Slider.SliderEvent : UnityEvent<float> // TypeDefIndex: 23041
{
	// Methods

	// RVA: 0x899FE78 Offset: 0x899BE78 VA: 0x899FE78
	public void .ctor() { }
}

// Namespace: 
private enum Slider.Axis // TypeDefIndex: 23042
{
	// Fields
	public int value__; // 0x0
	public const Slider.Axis Horizontal = 0;
	public const Slider.Axis Vertical = 1;
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Slider", 34)]
[ExecuteAlways]
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 23043
{
	// Fields
	[SerializeField]
	private RectTransform m_FillRect; // 0x100
	[SerializeField]
	private RectTransform m_HandleRect; // 0x108
	[SerializeField]
	[Space]
	private Slider.Direction m_Direction; // 0x110
	[SerializeField]
	private float m_MinValue; // 0x114
	[SerializeField]
	private float m_MaxValue; // 0x118
	[SerializeField]
	private bool m_WholeNumbers; // 0x11C
	[SerializeField]
	protected float m_Value; // 0x120
	[SerializeField]
	[Space]
	private Slider.SliderEvent m_OnValueChanged; // 0x128
	private Image m_FillImage; // 0x130
	private Transform m_FillTransform; // 0x138
	private RectTransform m_FillContainerRect; // 0x140
	private Transform m_HandleTransform; // 0x148
	private RectTransform m_HandleContainerRect; // 0x150
	private Vector2 m_Offset; // 0x158
	private DrivenRectTransformTracker m_Tracker; // 0x160
	private bool m_DelayedUpdateVisuals; // 0x161

	// Properties
	public RectTransform fillRect { get; set; }
	public RectTransform handleRect { get; set; }
	public Slider.Direction direction { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public virtual float value { get; set; }
	public float normalizedValue { get; set; }
	public Slider.SliderEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Slider.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x899F220 Offset: 0x899B220 VA: 0x899F220
	public RectTransform get_fillRect() { }

	// RVA: 0x899F228 Offset: 0x899B228 VA: 0x899F228
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x899F8C0 Offset: 0x899B8C0 VA: 0x899F8C0
	public RectTransform get_handleRect() { }

	// RVA: 0x899F8C8 Offset: 0x899B8C8 VA: 0x899F8C8
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x899F944 Offset: 0x899B944 VA: 0x899F944
	public Slider.Direction get_direction() { }

	// RVA: 0x899F94C Offset: 0x899B94C VA: 0x899F94C
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x899F9C0 Offset: 0x899B9C0 VA: 0x899F9C0
	public float get_minValue() { }

	// RVA: 0x899F9C8 Offset: 0x899B9C8 VA: 0x899F9C8
	public void set_minValue(float value) { }

	// RVA: 0x899FA58 Offset: 0x899BA58 VA: 0x899FA58
	public float get_maxValue() { }

	// RVA: 0x899FA60 Offset: 0x899BA60 VA: 0x899FA60
	public void set_maxValue(float value) { }

	// RVA: 0x899FAF0 Offset: 0x899BAF0 VA: 0x899FAF0
	public bool get_wholeNumbers() { }

	// RVA: 0x899FAF8 Offset: 0x899BAF8 VA: 0x899FAF8
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x899FB88 Offset: 0x899BB88 VA: 0x899FB88 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x899FC28 Offset: 0x899BC28 VA: 0x899FC28 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x899FC3C Offset: 0x899BC3C VA: 0x899FC3C Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x899FC50 Offset: 0x899BC50 VA: 0x899FC50
	public float get_normalizedValue() { }

	// RVA: 0x899FD34 Offset: 0x899BD34 VA: 0x899FD34
	public void set_normalizedValue(float value) { }

	// RVA: 0x899FD6C Offset: 0x899BD6C VA: 0x899FD6C
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x899FD74 Offset: 0x899BD74 VA: 0x899FD74
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x899FD84 Offset: 0x899BD84 VA: 0x899FD84
	private float get_stepSize() { }

	// RVA: 0x899FDB0 Offset: 0x899BDB0 VA: 0x899FDB0
	protected void .ctor() { }

	// RVA: 0x899FEC0 Offset: 0x899BEC0 VA: 0x899FEC0 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x899FEC4 Offset: 0x899BEC4 VA: 0x899FEC4 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x899FEC8 Offset: 0x899BEC8 VA: 0x899FEC8 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x899FECC Offset: 0x899BECC VA: 0x899FECC Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x899FF08 Offset: 0x899BF08 VA: 0x899FF08 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x899FF28 Offset: 0x899BF28 VA: 0x899FF28 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x899FF68 Offset: 0x899BF68 VA: 0x899FF68 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x899F2A4 Offset: 0x899B2A4 VA: 0x899F2A4
	private void UpdateCachedReferences() { }

	// RVA: 0x89A0150 Offset: 0x899C150 VA: 0x89A0150
	private float ClampValue(float input) { }

	// RVA: 0x89A0228 Offset: 0x899C228 VA: 0x89A0228 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x89A02EC Offset: 0x899C2EC VA: 0x89A02EC Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x89A0218 Offset: 0x899C218 VA: 0x89A0218
	private Slider.Axis get_axis() { }

	// RVA: 0x89A0204 Offset: 0x899C204 VA: 0x89A0204
	private bool get_reverseValue() { }

	// RVA: 0x899F5DC Offset: 0x899B5DC VA: 0x899F5DC
	private void UpdateVisuals() { }

	// RVA: 0x89A0324 Offset: 0x899C324 VA: 0x89A0324
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x89A051C Offset: 0x899C51C VA: 0x89A051C
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x89A0580 Offset: 0x899C580 VA: 0x89A0580 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x89A0738 Offset: 0x899C738 VA: 0x89A0738 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x89A0788 Offset: 0x899C788 VA: 0x89A0788 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x89A09D4 Offset: 0x899C9D4 VA: 0x89A09D4 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x89A09F8 Offset: 0x899C9F8 VA: 0x89A09F8 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x89A0A1C Offset: 0x899CA1C VA: 0x89A0A1C Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x89A0A40 Offset: 0x899CA40 VA: 0x89A0A40 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x89A0A64 Offset: 0x899CA64 VA: 0x89A0A64 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x89A0A7C Offset: 0x899CA7C VA: 0x89A0A7C
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x89A0C04 Offset: 0x899CC04 VA: 0x89A0C04 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 23044
{
	// Fields
	[SerializeField]
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField]
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAs("m_HighlightedSprite")]
	[SerializeField]
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField]
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0x89A0C0C Offset: 0x899CC0C VA: 0x89A0C0C
	public Sprite get_highlightedSprite() { }

	// RVA: 0x89A0C14 Offset: 0x899CC14 VA: 0x89A0C14
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x89A0C1C Offset: 0x899CC1C VA: 0x89A0C1C
	public Sprite get_pressedSprite() { }

	// RVA: 0x89A0C24 Offset: 0x899CC24 VA: 0x89A0C24
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x89A0C2C Offset: 0x899CC2C VA: 0x89A0C2C
	public Sprite get_selectedSprite() { }

	// RVA: 0x89A0C34 Offset: 0x899CC34 VA: 0x89A0C34
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x89A0C3C Offset: 0x899CC3C VA: 0x89A0C3C
	public Sprite get_disabledSprite() { }

	// RVA: 0x89A0C44 Offset: 0x899CC44 VA: 0x89A0C44
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x89A0C4C Offset: 0x899CC4C VA: 0x89A0C4C Slot: 4
	public bool Equals(SpriteState other) { }
}

// Namespace: 
private class StencilMaterial.MatEntry // TypeDefIndex: 23045
{
	// Fields
	public Material baseMat; // 0x10
	public Material customMat; // 0x18
	public int count; // 0x20
	public int stencilId; // 0x24
	public StencilOp operation; // 0x28
	public CompareFunction compareFunction; // 0x2C
	public int readMask; // 0x30
	public int writeMask; // 0x34
	public bool useAlphaClip; // 0x38
	public ColorWriteMask colorMask; // 0x3C

	// Methods

	// RVA: 0x89A1888 Offset: 0x899D888 VA: 0x89A1888
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public static class StencilMaterial // TypeDefIndex: 23046
{
	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	[EditorBrowsable(1)]
	[Obsolete("Use Material.Add instead.", True)]
	// RVA: 0x89A0D54 Offset: 0x899CD54 VA: 0x89A0D54
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x89A0D5C Offset: 0x899CD5C VA: 0x89A0D5C
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x89A17E0 Offset: 0x899D7E0 VA: 0x89A17E0
	private static void LogWarningWhenNotInBatchmode(string warning, Object context) { }

	// RVA: 0x89A0DE8 Offset: 0x899CDE8 VA: 0x89A0DE8
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x89A1898 Offset: 0x899D898 VA: 0x89A1898
	public static void Remove(Material customMat) { }

	// RVA: 0x89A1A64 Offset: 0x899DA64 VA: 0x89A1A64
	public static void ClearAll() { }

	// RVA: 0x89A1B90 Offset: 0x899DB90 VA: 0x89A1B90
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Legacy/Text", 100)]
[RequireComponent(typeof(CanvasRenderer))]
public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 23047
{
	// Fields
	[SerializeField]
	private FontData m_FontData; // 0xD8
	[SerializeField]
	[TextArea(3, 10)]
	protected string m_Text; // 0xE0
	private TextGenerator m_TextCache; // 0xE8
	private TextGenerator m_TextCacheForLayout; // 0xF0
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0xF8
	private readonly UIVertex[] m_TempVerts; // 0x100

	// Properties
	public TextGenerator cachedTextGenerator { get; }
	public TextGenerator cachedTextGeneratorForLayout { get; }
	public override Texture mainTexture { get; }
	public Font font { get; set; }
	public virtual string text { get; set; }
	public bool supportRichText { get; set; }
	public bool resizeTextForBestFit { get; set; }
	public int resizeTextMinSize { get; set; }
	public int resizeTextMaxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public int fontSize { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }
	public FontStyle fontStyle { get; set; }
	public float pixelsPerUnit { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x89A1C28 Offset: 0x899DC28 VA: 0x89A1C28
	protected void .ctor() { }

	// RVA: 0x89A1CE0 Offset: 0x899DCE0 VA: 0x89A1CE0
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x89A1D78 Offset: 0x899DD78 VA: 0x89A1D78
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x89A1DE8 Offset: 0x899DDE8 VA: 0x89A1DE8 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x89A1FAC Offset: 0x899DFAC VA: 0x89A1FAC
	public void FontTextureChanged() { }

	// RVA: 0x89A1F90 Offset: 0x899DF90 VA: 0x89A1F90
	public Font get_font() { }

	// RVA: 0x89A20B8 Offset: 0x899E0B8 VA: 0x89A20B8
	public void set_font(Font value) { }

	// RVA: 0x89A21D4 Offset: 0x899E1D4 VA: 0x89A21D4 Slot: 74
	public virtual string get_text() { }

	// RVA: 0x89A21DC Offset: 0x899E1DC VA: 0x89A21DC Slot: 75
	public virtual void set_text(string value) { }

	// RVA: 0x89A22BC Offset: 0x899E2BC VA: 0x89A22BC
	public bool get_supportRichText() { }

	// RVA: 0x89A22D8 Offset: 0x899E2D8 VA: 0x89A22D8
	public void set_supportRichText(bool value) { }

	// RVA: 0x89A2338 Offset: 0x899E338 VA: 0x89A2338
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x89A2354 Offset: 0x899E354 VA: 0x89A2354
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x89A23B4 Offset: 0x899E3B4 VA: 0x89A23B4
	public int get_resizeTextMinSize() { }

	// RVA: 0x89A23D0 Offset: 0x899E3D0 VA: 0x89A23D0
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x89A2424 Offset: 0x899E424 VA: 0x89A2424
	public int get_resizeTextMaxSize() { }

	// RVA: 0x89A2440 Offset: 0x899E440 VA: 0x89A2440
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x89A2494 Offset: 0x899E494 VA: 0x89A2494
	public TextAnchor get_alignment() { }

	// RVA: 0x89A24B0 Offset: 0x899E4B0 VA: 0x89A24B0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x89A2504 Offset: 0x899E504 VA: 0x89A2504
	public bool get_alignByGeometry() { }

	// RVA: 0x89A2520 Offset: 0x899E520 VA: 0x89A2520
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x89A2568 Offset: 0x899E568 VA: 0x89A2568
	public int get_fontSize() { }

	// RVA: 0x89A2584 Offset: 0x899E584 VA: 0x89A2584
	public void set_fontSize(int value) { }

	// RVA: 0x89A25D8 Offset: 0x899E5D8 VA: 0x89A25D8
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x89A25F4 Offset: 0x899E5F4 VA: 0x89A25F4
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x89A2648 Offset: 0x899E648 VA: 0x89A2648
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x89A2664 Offset: 0x899E664 VA: 0x89A2664
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x89A26B8 Offset: 0x899E6B8 VA: 0x89A26B8
	public float get_lineSpacing() { }

	// RVA: 0x89A26D4 Offset: 0x899E6D4 VA: 0x89A26D4
	public void set_lineSpacing(float value) { }

	// RVA: 0x89A2728 Offset: 0x899E728 VA: 0x89A2728
	public FontStyle get_fontStyle() { }

	// RVA: 0x89A2744 Offset: 0x899E744 VA: 0x89A2744
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x89A2798 Offset: 0x899E798 VA: 0x89A2798
	public float get_pixelsPerUnit() { }

	// RVA: 0x89A28E0 Offset: 0x899E8E0 VA: 0x89A28E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x89A295C Offset: 0x899E95C VA: 0x89A295C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x89A29C0 Offset: 0x899E9C0 VA: 0x89A29C0 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x89A2A48 Offset: 0x899EA48 VA: 0x89A2A48
	internal void AssignDefaultFont() { }

	// RVA: 0x89A2AB8 Offset: 0x899EAB8 VA: 0x89A2AB8
	internal void AssignDefaultFontIfNecessary() { }

	// RVA: 0x89A2B74 Offset: 0x899EB74 VA: 0x89A2B74
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x89A2D08 Offset: 0x899ED08 VA: 0x89A2D08
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x89A2D74 Offset: 0x899ED74 VA: 0x89A2D74 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x89A3460 Offset: 0x899F460 VA: 0x89A3460 Slot: 76
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x89A3464 Offset: 0x899F464 VA: 0x89A3464 Slot: 77
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x89A3468 Offset: 0x899F468 VA: 0x89A3468 Slot: 78
	public virtual float get_minWidth() { }

	// RVA: 0x89A3470 Offset: 0x899F470 VA: 0x89A3470 Slot: 79
	public virtual float get_preferredWidth() { }

	// RVA: 0x89A354C Offset: 0x899F54C VA: 0x89A354C Slot: 80
	public virtual float get_flexibleWidth() { }

	// RVA: 0x89A3554 Offset: 0x899F554 VA: 0x89A3554 Slot: 81
	public virtual float get_minHeight() { }

	// RVA: 0x89A355C Offset: 0x899F55C VA: 0x89A355C Slot: 82
	public virtual float get_preferredHeight() { }

	// RVA: 0x89A3614 Offset: 0x899F614 VA: 0x89A3614 Slot: 83
	public virtual float get_flexibleHeight() { }

	// RVA: 0x89A361C Offset: 0x899F61C VA: 0x89A361C Slot: 84
	public virtual int get_layoutPriority() { }
}

// Namespace: 
public enum Toggle.ToggleTransition // TypeDefIndex: 23048
{
	// Fields
	public int value__; // 0x0
	public const Toggle.ToggleTransition None = 0;
	public const Toggle.ToggleTransition Fade = 1;
}

// Namespace: 
[Serializable]
public class Toggle.ToggleEvent : UnityEvent<bool> // TypeDefIndex: 23049
{
	// Methods

	// RVA: 0x89A3900 Offset: 0x899F900 VA: 0x89A3900
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Toggle", 30)]
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 23050
{
	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0x100
	public Graphic graphic; // 0x108
	[SerializeField]
	private ToggleGroup m_Group; // 0x110
	public Toggle.ToggleEvent onValueChanged; // 0x118
	[Tooltip("Is the toggle currently on or off?")]
	[SerializeField]
	private bool m_IsOn; // 0x120

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0x89A3624 Offset: 0x899F624 VA: 0x89A3624
	public ToggleGroup get_group() { }

	// RVA: 0x89A362C Offset: 0x899F62C VA: 0x89A362C
	public void set_group(ToggleGroup value) { }

	// RVA: 0x89A3868 Offset: 0x899F868 VA: 0x89A3868
	protected void .ctor() { }

	// RVA: 0x89A3948 Offset: 0x899F948 VA: 0x89A3948 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x89A394C Offset: 0x899F94C VA: 0x89A394C Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x89A3950 Offset: 0x899F950 VA: 0x89A3950 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x89A3954 Offset: 0x899F954 VA: 0x89A3954 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x89A3DC4 Offset: 0x899FDC4 VA: 0x89A3DC4 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x89A3DF0 Offset: 0x899FDF0 VA: 0x89A3DF0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x89A3E10 Offset: 0x899FE10 VA: 0x89A3E10 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x89A364C Offset: 0x899F64C VA: 0x89A364C
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x89A4328 Offset: 0x89A0328 VA: 0x89A4328
	public bool get_isOn() { }

	// RVA: 0x89A4330 Offset: 0x89A0330 VA: 0x89A4330
	public void set_isOn(bool value) { }

	// RVA: 0x89A433C Offset: 0x89A033C VA: 0x89A433C
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x89A3F34 Offset: 0x899FF34 VA: 0x89A3F34
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x89A37A4 Offset: 0x899F7A4 VA: 0x89A37A4
	private void PlayEffect(bool instant) { }

	// RVA: 0x89A4488 Offset: 0x89A0488 VA: 0x89A4488 Slot: 6
	protected override void Start() { }

	// RVA: 0x89A4490 Offset: 0x89A0490 VA: 0x89A4490
	private void InternalToggle() { }

	// RVA: 0x89A44E4 Offset: 0x89A04E4 VA: 0x89A44E4 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x89A4508 Offset: 0x89A0508 VA: 0x89A4508 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x89A450C Offset: 0x89A050C VA: 0x89A450C Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ToggleGroup.<>c // TypeDefIndex: 23051
{
	// Fields
	public static readonly ToggleGroup.<>c <>9; // 0x0
	public static Predicate<Toggle> <>9__13_0; // 0x8
	public static Func<Toggle, bool> <>9__14_0; // 0x10

	// Methods

	// RVA: 0x89A49B4 Offset: 0x89A09B4 VA: 0x89A49B4
	private static void .cctor() { }

	// RVA: 0x89A4A1C Offset: 0x89A0A1C VA: 0x89A4A1C
	public void .ctor() { }

	// RVA: 0x89A4A24 Offset: 0x89A0A24 VA: 0x89A4A24
	internal bool <AnyTogglesOn>b__13_0(Toggle x) { }

	// RVA: 0x89A4A3C Offset: 0x89A0A3C VA: 0x89A4A3C
	internal bool <ActiveToggles>b__14_0(Toggle x) { }
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[AddComponentMenu("UI/Toggle Group", 31)]
public class ToggleGroup : UIBehaviour // TypeDefIndex: 23052
{
	// Fields
	[SerializeField]
	private bool m_AllowSwitchOff; // 0x20
	protected List<Toggle> m_Toggles; // 0x28

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x89A4514 Offset: 0x89A0514 VA: 0x89A4514
	public bool get_allowSwitchOff() { }

	// RVA: 0x89A451C Offset: 0x89A051C VA: 0x89A451C
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x89A4528 Offset: 0x89A0528 VA: 0x89A4528
	protected void .ctor() { }

	// RVA: 0x89A45B0 Offset: 0x89A05B0 VA: 0x89A45B0 Slot: 6
	protected override void Start() { }

	// RVA: 0x89A45CC Offset: 0x89A05CC VA: 0x89A45CC Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x89A45E8 Offset: 0x89A05E8 VA: 0x89A45E8
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x89A421C Offset: 0x89A021C VA: 0x89A421C
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x89A40A8 Offset: 0x89A00A8 VA: 0x89A40A8
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x89A4138 Offset: 0x89A0138 VA: 0x89A4138
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x89A39D4 Offset: 0x899F9D4 VA: 0x89A39D4
	public void EnsureValidState() { }

	// RVA: 0x89A4348 Offset: 0x89A0348 VA: 0x89A4348
	public bool AnyTogglesOn() { }

	// RVA: 0x89A4738 Offset: 0x89A0738 VA: 0x89A4738
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x89A4834 Offset: 0x89A0834 VA: 0x89A4834
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x89A48BC Offset: 0x89A08BC VA: 0x89A48BC
	public void SetAllTogglesOff(bool sendCallback = True) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.Raycast3DCallback : MulticastDelegate // TypeDefIndex: 23053
{
	// Methods

	// RVA: 0x89A587C Offset: 0x89A187C VA: 0x89A587C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89A591C Offset: 0x89A191C VA: 0x89A591C Slot: 13
	public virtual bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	// RVA: 0x89A595C Offset: 0x89A195C VA: 0x89A595C Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x89A5A80 Offset: 0x89A1A80 VA: 0x89A5A80 Slot: 15
	public virtual bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.RaycastAllCallback : MulticastDelegate // TypeDefIndex: 23054
{
	// Methods

	// RVA: 0x89A5AAC Offset: 0x89A1AAC VA: 0x89A5AAC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89A5B4C Offset: 0x89A1B4C VA: 0x89A5B4C Slot: 13
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x89A5B88 Offset: 0x89A1B88 VA: 0x89A5B88 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x89A5C78 Offset: 0x89A1C78 VA: 0x89A5C78 Slot: 15
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRaycastNonAllocCallback : MulticastDelegate // TypeDefIndex: 23055
{
	// Methods

	// RVA: 0x89A5C84 Offset: 0x89A1C84 VA: 0x89A5C84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89A5D24 Offset: 0x89A1D24 VA: 0x89A5D24 Slot: 13
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x89A5D60 Offset: 0x89A1D60 VA: 0x89A5D60 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x89A5E54 Offset: 0x89A1E54 VA: 0x89A5E54 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.Raycast2DCallback : MulticastDelegate // TypeDefIndex: 23056
{
	// Methods

	// RVA: 0x89A5E7C Offset: 0x89A1E7C VA: 0x89A5E7C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89A5F1C Offset: 0x89A1F1C VA: 0x89A5F1C Slot: 13
	public virtual RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	// RVA: 0x89A5F30 Offset: 0x89A1F30 VA: 0x89A5F30 Slot: 14
	public virtual IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x89A6034 Offset: 0x89A2034 VA: 0x89A6034 Slot: 15
	public virtual RaycastHit2D EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRayIntersectionAllCallback : MulticastDelegate // TypeDefIndex: 23057
{
	// Methods

	// RVA: 0x89A606C Offset: 0x89A206C VA: 0x89A606C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89A610C Offset: 0x89A210C VA: 0x89A610C Slot: 13
	public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x89A6148 Offset: 0x89A2148 VA: 0x89A6148 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x89A6238 Offset: 0x89A2238 VA: 0x89A6238 Slot: 15
	public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback : MulticastDelegate // TypeDefIndex: 23058
{
	// Methods

	// RVA: 0x89A6244 Offset: 0x89A2244 VA: 0x89A6244
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89A62E4 Offset: 0x89A22E4 VA: 0x89A62E4 Slot: 13
	public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	// RVA: 0x89A6320 Offset: 0x89A2320 VA: 0x89A6320 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x89A6414 Offset: 0x89A2414 VA: 0x89A6414 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.UI
internal class ReflectionMethodsCache // TypeDefIndex: 23059
{
	// Fields
	public ReflectionMethodsCache.Raycast3DCallback raycast3D; // 0x10
	public ReflectionMethodsCache.RaycastAllCallback raycast3DAll; // 0x18
	public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x20
	public ReflectionMethodsCache.Raycast2DCallback raycast2D; // 0x28
	public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll; // 0x30
	public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x38
	private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x0

	// Properties
	public static ReflectionMethodsCache Singleton { get; }

	// Methods

	// RVA: 0x89A4A54 Offset: 0x89A0A54 VA: 0x89A4A54
	public void .ctor() { }

	// RVA: 0x89A57F8 Offset: 0x89A17F8 VA: 0x89A57F8
	public static ReflectionMethodsCache get_Singleton() { }
}

// Namespace: UnityEngine.UI
public class VertexHelper : IDisposable // TypeDefIndex: 23060
{
	// Fields
	private List<Vector3> m_Positions; // 0x10
	private List<Color32> m_Colors; // 0x18
	private List<Vector4> m_Uv0S; // 0x20
	private List<Vector4> m_Uv1S; // 0x28
	private List<Vector4> m_Uv2S; // 0x30
	private List<Vector4> m_Uv3S; // 0x38
	private List<Vector3> m_Normals; // 0x40
	private List<Vector4> m_Tangents; // 0x48
	private List<int> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	// Properties
	public int currentVertCount { get; }
	public int currentIndexCount { get; }

	// Methods

	// RVA: 0x89A643C Offset: 0x89A243C VA: 0x89A643C
	public void .ctor() { }

	// RVA: 0x89A6444 Offset: 0x89A2444 VA: 0x89A6444
	public void .ctor(Mesh m) { }

	// RVA: 0x89A6680 Offset: 0x89A2680 VA: 0x89A6680
	private void InitializeListIfRequired() { }

	// RVA: 0x89A6874 Offset: 0x89A2874 VA: 0x89A6874 Slot: 4
	public void Dispose() { }

	// RVA: 0x8996410 Offset: 0x8992410 VA: 0x8996410
	public void Clear() { }

	// RVA: 0x89A6ADC Offset: 0x89A2ADC VA: 0x89A6ADC
	public int get_currentVertCount() { }

	// RVA: 0x89A6B28 Offset: 0x89A2B28 VA: 0x89A6B28
	public int get_currentIndexCount() { }

	// RVA: 0x89A6B74 Offset: 0x89A2B74 VA: 0x89A6B74
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x89A6CD4 Offset: 0x89A2CD4 VA: 0x89A6CD4
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x89A6E30 Offset: 0x89A2E30 VA: 0x89A6E30
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x89A6F90 Offset: 0x89A2F90 VA: 0x89A6F90
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x89A742C Offset: 0x89A342C VA: 0x89A742C
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x899652C Offset: 0x899252C VA: 0x899652C
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x89A7524 Offset: 0x89A3524 VA: 0x89A7524
	public void AddVert(UIVertex v) { }

	// RVA: 0x899665C Offset: 0x899265C VA: 0x899665C
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x89A3350 Offset: 0x899F350 VA: 0x89A3350
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x89A75B8 Offset: 0x89A35B8 VA: 0x89A75B8
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x89A7664 Offset: 0x89A3664 VA: 0x89A7664
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x89A76B4 Offset: 0x89A36B4 VA: 0x89A76B4
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x89A7704 Offset: 0x89A3704 VA: 0x89A7704
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Use BaseMeshEffect instead", True)]
public abstract class BaseVertexEffect // TypeDefIndex: 23061
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", True)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ModifyVertices(List<UIVertex> vertices);

	// RVA: 0x89A779C Offset: 0x89A379C VA: 0x89A779C
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 23062
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x89A77A4 Offset: 0x89A37A4 VA: 0x89A77A4
	protected Graphic get_graphic() { }

	// RVA: 0x89A784C Offset: 0x89A384C VA: 0x89A784C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x89A78F4 Offset: 0x89A38F4 VA: 0x89A78F4 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x89A7990 Offset: 0x89A3990 VA: 0x89A7990 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x89A7A2C Offset: 0x89A3A2C VA: 0x89A7A2C Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x89A7BDC Offset: 0x89A3BDC VA: 0x89A7BDC
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Use IMeshModifier instead", True)]
[EditorBrowsable(1)]
public interface IVertexModifier // TypeDefIndex: 23063
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", True)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyVertices(List<UIVertex> verts);
}

// Namespace: UnityEngine.UI
public interface IMeshModifier // TypeDefIndex: 23064
{
	// Methods

	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", False)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyMesh(Mesh mesh);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ModifyMesh(VertexHelper verts);
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Outline", 81)]
public class Outline : Shadow // TypeDefIndex: 23065
{
	// Methods

	// RVA: 0x89A7BE4 Offset: 0x89A3BE4 VA: 0x89A7BE4
	protected void .ctor() { }

	// RVA: 0x89A7BEC Offset: 0x89A3BEC VA: 0x89A7BEC Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Position As UV1", 82)]
public class PositionAsUV1 : BaseMeshEffect // TypeDefIndex: 23066
{
	// Methods

	// RVA: 0x89A7E2C Offset: 0x89A3E2C VA: 0x89A7E2C
	protected void .ctor() { }

	// RVA: 0x89A7E34 Offset: 0x89A3E34 VA: 0x89A7E34 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Shadow", 80)]
public class Shadow : BaseMeshEffect // TypeDefIndex: 23067
{
	// Fields
	[SerializeField]
	private Color m_EffectColor; // 0x28
	[SerializeField]
	private Vector2 m_EffectDistance; // 0x38
	[SerializeField]
	private bool m_UseGraphicAlpha; // 0x40
	private const float kMaxEffectDistance = 600;

	// Properties
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }

	// Methods

	// RVA: 0x89A7EF0 Offset: 0x89A3EF0 VA: 0x89A7EF0
	protected void .ctor() { }

	// RVA: 0x89A7F18 Offset: 0x89A3F18 VA: 0x89A7F18
	public Color get_effectColor() { }

	// RVA: 0x89A7F24 Offset: 0x89A3F24 VA: 0x89A7F24
	public void set_effectColor(Color value) { }

	// RVA: 0x89A7FF8 Offset: 0x89A3FF8 VA: 0x89A7FF8
	public Vector2 get_effectDistance() { }

	// RVA: 0x89A8000 Offset: 0x89A4000 VA: 0x89A8000
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x89A8104 Offset: 0x89A4104 VA: 0x89A8104
	public bool get_useGraphicAlpha() { }

	// RVA: 0x89A810C Offset: 0x89A410C VA: 0x89A810C
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x89A81C4 Offset: 0x89A41C4 VA: 0x89A81C4
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x89A84BC Offset: 0x89A44BC VA: 0x89A84BC
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x89A84C4 Offset: 0x89A44C4 VA: 0x89A84C4 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI.Collections
[DefaultMember("Item")]
internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 23068
{
	// Fields
	private readonly List<T> m_List; // 0x0
	private Dictionary<T, int> m_Dictionary; // 0x0
	private int m_EnabledObjectCount; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998FCC Offset: 0x4994FCC VA: 0x4998FCC
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x49999AC Offset: 0x49959AC VA: 0x49999AC
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T item, bool isActive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998FE0 Offset: 0x4994FE0 VA: 0x4998FE0
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x4999A74 Offset: 0x4995A74 VA: 0x4999A74
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool AddUnique(T item, bool isActive = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49990D0 Offset: 0x49950D0 VA: 0x49990D0
	|-IndexedSet<object>.AddUnique
	|
	|-RVA: 0x4999C64 Offset: 0x4995C64 VA: 0x4999C64
	|-IndexedSet<__Il2CppFullySharedGenericType>.AddUnique
	*/

	// RVA: -1 Offset: -1
	public bool EnableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4999170 Offset: 0x4995170 VA: 0x4999170
	|-IndexedSet<object>.EnableItem
	|
	|-RVA: 0x4999E14 Offset: 0x4995E14 VA: 0x4999E14
	|-IndexedSet<__Il2CppFullySharedGenericType>.EnableItem
	*/

	// RVA: -1 Offset: -1
	public bool DisableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49991F4 Offset: 0x49951F4 VA: 0x49991F4
	|-IndexedSet<object>.DisableItem
	|
	|-RVA: 0x4999F40 Offset: 0x4995F40 VA: 0x4999F40
	|-IndexedSet<__Il2CppFullySharedGenericType>.DisableItem
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4999280 Offset: 0x4995280 VA: 0x4999280
	|-IndexedSet<object>.Remove
	|
	|-RVA: 0x499A074 Offset: 0x4996074 VA: 0x499A074
	|-IndexedSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49992F0 Offset: 0x49952F0 VA: 0x49992F0
	|-IndexedSet<object>.GetEnumerator
	|
	|-RVA: 0x499A184 Offset: 0x4996184 VA: 0x499A184
	|-IndexedSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4999324 Offset: 0x4995324 VA: 0x4999324
	|-IndexedSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x499A1B8 Offset: 0x49961B8 VA: 0x499A1B8
	|-IndexedSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4999338 Offset: 0x4995338 VA: 0x4999338
	|-IndexedSet<object>.Clear
	|
	|-RVA: 0x499A1CC Offset: 0x49961CC VA: 0x499A1CC
	|-IndexedSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49993A0 Offset: 0x49953A0 VA: 0x49993A0
	|-IndexedSet<object>.Contains
	|
	|-RVA: 0x499A228 Offset: 0x4996228 VA: 0x499A228
	|-IndexedSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49993C4 Offset: 0x49953C4 VA: 0x49993C4
	|-IndexedSet<object>.CopyTo
	|
	|-RVA: 0x499A2FC Offset: 0x49962FC VA: 0x499A2FC
	|-IndexedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49993E8 Offset: 0x49953E8 VA: 0x49993E8
	|-IndexedSet<object>.get_Count
	|
	|-RVA: 0x499A324 Offset: 0x4996324 VA: 0x499A324
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49993F0 Offset: 0x49953F0 VA: 0x49993F0
	|-IndexedSet<object>.get_Capacity
	|
	|-RVA: 0x499A32C Offset: 0x499632C VA: 0x499A32C
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499940C Offset: 0x499540C VA: 0x499940C
	|-IndexedSet<object>.get_IsReadOnly
	|
	|-RVA: 0x499A354 Offset: 0x4996354 VA: 0x499A354
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4999414 Offset: 0x4995414 VA: 0x4999414
	|-IndexedSet<object>.IndexOf
	|
	|-RVA: 0x499A35C Offset: 0x499635C VA: 0x499A35C
	|-IndexedSet<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4999454 Offset: 0x4995454 VA: 0x4999454
	|-IndexedSet<object>.Insert
	|
	|-RVA: 0x499A440 Offset: 0x4996440 VA: 0x499A440
	|-IndexedSet<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499949C Offset: 0x499549C VA: 0x499949C
	|-IndexedSet<object>.RemoveAt
	|
	|-RVA: 0x499A488 Offset: 0x4996488 VA: 0x499A488
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private void Swap(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49995A4 Offset: 0x49955A4 VA: 0x49995A4
	|-IndexedSet<object>.Swap
	|
	|-RVA: 0x499A6CC Offset: 0x49966CC VA: 0x499A6CC
	|-IndexedSet<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49996B8 Offset: 0x49956B8 VA: 0x49996B8
	|-IndexedSet<object>.get_Item
	|
	|-RVA: 0x499AA00 Offset: 0x4996A00 VA: 0x499AA00
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499971C Offset: 0x499571C VA: 0x499971C
	|-IndexedSet<object>.set_Item
	|
	|-RVA: 0x499AAEC Offset: 0x4996AEC VA: 0x499AAEC
	|-IndexedSet<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49997C0 Offset: 0x49957C0 VA: 0x49997C0
	|-IndexedSet<object>.RemoveAll
	|
	|-RVA: 0x499AD3C Offset: 0x4996D3C VA: 0x499AD3C
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> sortLayoutFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4999868 Offset: 0x4995868 VA: 0x4999868
	|-IndexedSet<object>.Sort
	|
	|-RVA: 0x499AF20 Offset: 0x4996F20 VA: 0x499AF20
	|-IndexedSet<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49998FC Offset: 0x49958FC VA: 0x49998FC
	|-IndexedSet<object>..ctor
	|
	|-RVA: 0x499B0C4 Offset: 0x49970C4 VA: 0x499B0C4
	|-IndexedSet<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UI.CoroutineTween
internal interface ITweenValue // TypeDefIndex: 23069
{
	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();
}

// Namespace: 
public enum ColorTween.ColorTweenMode // TypeDefIndex: 23070
{
	// Fields
	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;
}

// Namespace: 
public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 23071
{
	// Methods

	// RVA: 0x89A87C8 Offset: 0x89A47C8 VA: 0x89A87C8
	public void .ctor() { }
}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct ColorTween : ITweenValue // TypeDefIndex: 23072
{
	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x89A85E4 Offset: 0x89A45E4 VA: 0x89A85E4
	public Color get_startColor() { }

	// RVA: 0x89A85F0 Offset: 0x89A45F0 VA: 0x89A85F0
	public void set_startColor(Color value) { }

	// RVA: 0x89A85FC Offset: 0x89A45FC VA: 0x89A85FC
	public Color get_targetColor() { }

	// RVA: 0x89A8608 Offset: 0x89A4608 VA: 0x89A8608
	public void set_targetColor(Color value) { }

	// RVA: 0x89A8614 Offset: 0x89A4614 VA: 0x89A8614
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x89A861C Offset: 0x89A461C VA: 0x89A861C
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x89A8624 Offset: 0x89A4624 VA: 0x89A8624 Slot: 6
	public float get_duration() { }

	// RVA: 0x89A862C Offset: 0x89A462C VA: 0x89A862C
	public void set_duration(float value) { }

	// RVA: 0x89A8634 Offset: 0x89A4634 VA: 0x89A8634 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x89A863C Offset: 0x89A463C VA: 0x89A863C
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x89A8648 Offset: 0x89A4648 VA: 0x89A8648 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x89A8734 Offset: 0x89A4734 VA: 0x89A8734
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x89A8810 Offset: 0x89A4810 VA: 0x89A8810
	public bool GetIgnoreTimescale() { }

	// RVA: 0x89A8818 Offset: 0x89A4818 VA: 0x89A8818
	public float GetDuration() { }

	// RVA: 0x89A8724 Offset: 0x89A4724 VA: 0x89A8724 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 23073
{
	// Methods

	// RVA: 0x89A8994 Offset: 0x89A4994 VA: 0x89A8994
	public void .ctor() { }
}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct FloatTween : ITweenValue // TypeDefIndex: 23074
{
	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x89A8820 Offset: 0x89A4820 VA: 0x89A8820
	public float get_startValue() { }

	// RVA: 0x89A8828 Offset: 0x89A4828 VA: 0x89A8828
	public void set_startValue(float value) { }

	// RVA: 0x89A8830 Offset: 0x89A4830 VA: 0x89A8830
	public float get_targetValue() { }

	// RVA: 0x89A8838 Offset: 0x89A4838 VA: 0x89A8838
	public void set_targetValue(float value) { }

	// RVA: 0x89A8840 Offset: 0x89A4840 VA: 0x89A8840 Slot: 6
	public float get_duration() { }

	// RVA: 0x89A8848 Offset: 0x89A4848 VA: 0x89A8848
	public void set_duration(float value) { }

	// RVA: 0x89A8850 Offset: 0x89A4850 VA: 0x89A8850 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x89A8858 Offset: 0x89A4858 VA: 0x89A8858
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x89A8864 Offset: 0x89A4864 VA: 0x89A8864 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x89A8900 Offset: 0x89A4900 VA: 0x89A8900
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x89A89DC Offset: 0x89A49DC VA: 0x89A89DC
	public bool GetIgnoreTimescale() { }

	// RVA: 0x89A89E4 Offset: 0x89A49E4 VA: 0x89A89E4
	public float GetDuration() { }

	// RVA: 0x89A88F0 Offset: 0x89A48F0 VA: 0x89A88F0 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TweenRunner.<Start>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23075
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public T tweenInfo; // 0x0
	private float <elapsedTime>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E49708 Offset: 0x5E45708 VA: 0x5E49708
	|-TweenRunner.<Start>d__2<ColorTween>..ctor
	|
	|-RVA: 0x5E499F8 Offset: 0x5E459F8 VA: 0x5E499F8
	|-TweenRunner.<Start>d__2<FloatTween>..ctor
	|
	|-RVA: 0x5E4A248 Offset: 0x5E46248 VA: 0x5E4A248
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E49730 Offset: 0x5E45730 VA: 0x5E49730
	|-TweenRunner.<Start>d__2<ColorTween>.System.IDisposable.Dispose
	|
	|-RVA: 0x5E49A20 Offset: 0x5E45A20 VA: 0x5E49A20
	|-TweenRunner.<Start>d__2<FloatTween>.System.IDisposable.Dispose
	|
	|-RVA: 0x5E4A288 Offset: 0x5E46288 VA: 0x5E4A288
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E49734 Offset: 0x5E45734 VA: 0x5E49734
	|-TweenRunner.<Start>d__2<ColorTween>.MoveNext
	|
	|-RVA: 0x5E49A24 Offset: 0x5E45A24 VA: 0x5E49A24
	|-TweenRunner.<Start>d__2<FloatTween>.MoveNext
	|
	|-RVA: 0x5E4A28C Offset: 0x5E4628C VA: 0x5E4A28C
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4983C Offset: 0x5E4583C VA: 0x5E4983C
	|-TweenRunner.<Start>d__2<ColorTween>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0x5E49B2C Offset: 0x5E45B2C VA: 0x5E49B2C
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0x5E4A89C Offset: 0x5E4689C VA: 0x5E4A89C
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E49844 Offset: 0x5E45844 VA: 0x5E49844
	|-TweenRunner.<Start>d__2<ColorTween>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5E49B34 Offset: 0x5E45B34 VA: 0x5E49B34
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5E4A8C4 Offset: 0x5E468C4 VA: 0x5E4A8C4
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E49878 Offset: 0x5E45878 VA: 0x5E49878
	|-TweenRunner.<Start>d__2<ColorTween>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5E49B68 Offset: 0x5E45B68 VA: 0x5E49B68
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5E4A8F8 Offset: 0x5E468F8 VA: 0x5E4A8F8
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: UnityEngine.UI.CoroutineTween
internal class TweenRunner<T> // TypeDefIndex: 23076
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	[IteratorStateMachine(typeof(TweenRunner.<Start>d__2<T>))]
	// RVA: -1 Offset: -1
	private static IEnumerator Start(T tweenInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5666EAC Offset: 0x5662EAC VA: 0x5666EAC
	|-TweenRunner<ColorTween>.Start
	|
	|-RVA: 0x5667148 Offset: 0x5663148 VA: 0x5667148
	|-TweenRunner<FloatTween>.Start
	|
	|-RVA: 0x56673C8 Offset: 0x56633C8 VA: 0x56673C8
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Start
	*/

	// RVA: -1 Offset: -1
	public void Init(MonoBehaviour coroutineContainer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5666F78 Offset: 0x5662F78 VA: 0x5666F78
	|-TweenRunner<ColorTween>.Init
	|
	|-RVA: 0x5667204 Offset: 0x5663204 VA: 0x5667204
	|-TweenRunner<FloatTween>.Init
	|
	|-RVA: 0x5667548 Offset: 0x5663548 VA: 0x5667548
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Init
	*/

	// RVA: -1 Offset: -1
	public void StartTween(T info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5666F80 Offset: 0x5662F80 VA: 0x5666F80
	|-TweenRunner<ColorTween>.StartTween
	|
	|-RVA: 0x566720C Offset: 0x566320C VA: 0x566720C
	|-TweenRunner<FloatTween>.StartTween
	|
	|-RVA: 0x5667550 Offset: 0x5663550 VA: 0x5667550
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StartTween
	*/

	// RVA: -1 Offset: -1
	public void StopTween() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5667100 Offset: 0x5663100 VA: 0x5667100
	|-TweenRunner<ColorTween>.StopTween
	|
	|-RVA: 0x5667380 Offset: 0x5663380 VA: 0x5667380
	|-TweenRunner<FloatTween>.StopTween
	|
	|-RVA: 0x5667794 Offset: 0x5663794 VA: 0x5667794
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StopTween
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5667140 Offset: 0x5663140 VA: 0x5667140
	|-TweenRunner<ColorTween>..ctor
	|
	|-RVA: 0x56673C0 Offset: 0x56633C0 VA: 0x56673C0
	|-TweenRunner<FloatTween>..ctor
	|
	|-RVA: 0x56677D4 Offset: 0x56637D4 VA: 0x56677D4
	|-TweenRunner<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: 
private enum PanelEventHandler.PointerEventType // TypeDefIndex: 23077
{
	// Fields
	public int value__; // 0x0
	public const PanelEventHandler.PointerEventType Default = 0;
	public const PanelEventHandler.PointerEventType Down = 1;
	public const PanelEventHandler.PointerEventType Up = 2;
}

// Namespace: 
private class PanelEventHandler.PointerEvent : IPointerEvent // TypeDefIndex: 23078
{
	// Fields
	[CompilerGenerated]
	private int <pointerId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <pointerType>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <isPrimary>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <button>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <pressedButtons>k__BackingField; // 0x28
	[CompilerGenerated]
	private Vector3 <position>k__BackingField; // 0x2C
	[CompilerGenerated]
	private Vector3 <localPosition>k__BackingField; // 0x38
	[CompilerGenerated]
	private Vector3 <deltaPosition>k__BackingField; // 0x44
	[CompilerGenerated]
	private float <deltaTime>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <clickCount>k__BackingField; // 0x54
	[CompilerGenerated]
	private float <pressure>k__BackingField; // 0x58
	[CompilerGenerated]
	private float <tangentialPressure>k__BackingField; // 0x5C
	[CompilerGenerated]
	private float <altitudeAngle>k__BackingField; // 0x60
	[CompilerGenerated]
	private float <azimuthAngle>k__BackingField; // 0x64
	[CompilerGenerated]
	private float <twist>k__BackingField; // 0x68
	[CompilerGenerated]
	private Vector2 <tilt>k__BackingField; // 0x6C
	[CompilerGenerated]
	private PenStatus <penStatus>k__BackingField; // 0x74
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; // 0x78
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; // 0x80
	[CompilerGenerated]
	private EventModifiers <modifiers>k__BackingField; // 0x88

	// Properties
	public int pointerId { get; set; }
	public string pointerType { get; set; }
	public bool isPrimary { get; set; }
	public int button { get; set; }
	public int pressedButtons { get; set; }
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 deltaPosition { get; set; }
	public float deltaTime { get; set; }
	public int clickCount { get; set; }
	public float pressure { get; set; }
	public float tangentialPressure { get; set; }
	public float altitudeAngle { get; set; }
	public float azimuthAngle { get; set; }
	public float twist { get; set; }
	public Vector2 tilt { get; set; }
	public PenStatus penStatus { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public EventModifiers modifiers { get; set; }
	public bool shiftKey { get; }
	public bool ctrlKey { get; }
	public bool commandKey { get; }
	public bool altKey { get; }
	public bool actionKey { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89AB3D0 Offset: 0x89A73D0 VA: 0x89AB3D0 Slot: 4
	public int get_pointerId() { }

	[CompilerGenerated]
	// RVA: 0x89AB3D8 Offset: 0x89A73D8 VA: 0x89AB3D8
	private void set_pointerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x89AB3E0 Offset: 0x89A73E0 VA: 0x89AB3E0 Slot: 5
	public string get_pointerType() { }

	[CompilerGenerated]
	// RVA: 0x89AB3E8 Offset: 0x89A73E8 VA: 0x89AB3E8
	private void set_pointerType(string value) { }

	[CompilerGenerated]
	// RVA: 0x89AB3F0 Offset: 0x89A73F0 VA: 0x89AB3F0 Slot: 6
	public bool get_isPrimary() { }

	[CompilerGenerated]
	// RVA: 0x89AB3F8 Offset: 0x89A73F8 VA: 0x89AB3F8
	private void set_isPrimary(bool value) { }

	[CompilerGenerated]
	// RVA: 0x89AB404 Offset: 0x89A7404 VA: 0x89AB404 Slot: 7
	public int get_button() { }

	[CompilerGenerated]
	// RVA: 0x89AB40C Offset: 0x89A740C VA: 0x89AB40C
	private void set_button(int value) { }

	[CompilerGenerated]
	// RVA: 0x89AB414 Offset: 0x89A7414 VA: 0x89AB414 Slot: 8
	public int get_pressedButtons() { }

	[CompilerGenerated]
	// RVA: 0x89AB41C Offset: 0x89A741C VA: 0x89AB41C
	private void set_pressedButtons(int value) { }

	[CompilerGenerated]
	// RVA: 0x89AB424 Offset: 0x89A7424 VA: 0x89AB424 Slot: 9
	public Vector3 get_position() { }

	[CompilerGenerated]
	// RVA: 0x89AB430 Offset: 0x89A7430 VA: 0x89AB430
	private void set_position(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x89AB43C Offset: 0x89A743C VA: 0x89AB43C Slot: 10
	public Vector3 get_localPosition() { }

	[CompilerGenerated]
	// RVA: 0x89AB448 Offset: 0x89A7448 VA: 0x89AB448
	private void set_localPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x89AB454 Offset: 0x89A7454 VA: 0x89AB454 Slot: 11
	public Vector3 get_deltaPosition() { }

	[CompilerGenerated]
	// RVA: 0x89AB460 Offset: 0x89A7460 VA: 0x89AB460
	private void set_deltaPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x89AB46C Offset: 0x89A746C VA: 0x89AB46C Slot: 12
	public float get_deltaTime() { }

	[CompilerGenerated]
	// RVA: 0x89AB474 Offset: 0x89A7474 VA: 0x89AB474
	private void set_deltaTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AB47C Offset: 0x89A747C VA: 0x89AB47C Slot: 13
	public int get_clickCount() { }

	[CompilerGenerated]
	// RVA: 0x89AB484 Offset: 0x89A7484 VA: 0x89AB484
	private void set_clickCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x89AB48C Offset: 0x89A748C VA: 0x89AB48C Slot: 14
	public float get_pressure() { }

	[CompilerGenerated]
	// RVA: 0x89AB494 Offset: 0x89A7494 VA: 0x89AB494
	private void set_pressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AB49C Offset: 0x89A749C VA: 0x89AB49C Slot: 15
	public float get_tangentialPressure() { }

	[CompilerGenerated]
	// RVA: 0x89AB4A4 Offset: 0x89A74A4 VA: 0x89AB4A4
	private void set_tangentialPressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AB4AC Offset: 0x89A74AC VA: 0x89AB4AC Slot: 16
	public float get_altitudeAngle() { }

	[CompilerGenerated]
	// RVA: 0x89AB4B4 Offset: 0x89A74B4 VA: 0x89AB4B4
	private void set_altitudeAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AB4BC Offset: 0x89A74BC VA: 0x89AB4BC Slot: 17
	public float get_azimuthAngle() { }

	[CompilerGenerated]
	// RVA: 0x89AB4C4 Offset: 0x89A74C4 VA: 0x89AB4C4
	private void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AB4CC Offset: 0x89A74CC VA: 0x89AB4CC Slot: 18
	public float get_twist() { }

	[CompilerGenerated]
	// RVA: 0x89AB4D4 Offset: 0x89A74D4 VA: 0x89AB4D4
	private void set_twist(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AB4DC Offset: 0x89A74DC VA: 0x89AB4DC Slot: 19
	public Vector2 get_tilt() { }

	[CompilerGenerated]
	// RVA: 0x89AB4E4 Offset: 0x89A74E4 VA: 0x89AB4E4
	private void set_tilt(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AB4EC Offset: 0x89A74EC VA: 0x89AB4EC Slot: 20
	public PenStatus get_penStatus() { }

	[CompilerGenerated]
	// RVA: 0x89AB4F4 Offset: 0x89A74F4 VA: 0x89AB4F4
	private void set_penStatus(PenStatus value) { }

	[CompilerGenerated]
	// RVA: 0x89AB4FC Offset: 0x89A74FC VA: 0x89AB4FC Slot: 21
	public Vector2 get_radius() { }

	[CompilerGenerated]
	// RVA: 0x89AB504 Offset: 0x89A7504 VA: 0x89AB504
	private void set_radius(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AB50C Offset: 0x89A750C VA: 0x89AB50C Slot: 22
	public Vector2 get_radiusVariance() { }

	[CompilerGenerated]
	// RVA: 0x89AB514 Offset: 0x89A7514 VA: 0x89AB514
	private void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AB51C Offset: 0x89A751C VA: 0x89AB51C Slot: 23
	public EventModifiers get_modifiers() { }

	[CompilerGenerated]
	// RVA: 0x89AB524 Offset: 0x89A7524 VA: 0x89AB524
	private void set_modifiers(EventModifiers value) { }

	// RVA: 0x89AB52C Offset: 0x89A752C VA: 0x89AB52C Slot: 24
	public bool get_shiftKey() { }

	// RVA: 0x89AB538 Offset: 0x89A7538 VA: 0x89AB538 Slot: 25
	public bool get_ctrlKey() { }

	// RVA: 0x89AB544 Offset: 0x89A7544 VA: 0x89AB544 Slot: 26
	public bool get_commandKey() { }

	// RVA: 0x89AB550 Offset: 0x89A7550 VA: 0x89AB550 Slot: 27
	public bool get_altKey() { }

	// RVA: 0x89AB55C Offset: 0x89A755C VA: 0x89AB55C Slot: 28
	public bool get_actionKey() { }

	// RVA: 0x89AAE2C Offset: 0x89A6E2C VA: 0x89AAE2C
	public void Read(PanelEventHandler self, PointerEventData eventData, PanelEventHandler.PointerEventType eventType) { }

	// RVA: 0x89AB2FC Offset: 0x89A72FC VA: 0x89AB2FC
	public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) { }

	// RVA: 0x89AB3C0 Offset: 0x89A73C0 VA: 0x89AB3C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x89AB5F0 Offset: 0x89A75F0 VA: 0x89AB5F0
	internal static bool <Read>g__InRange|90_0(int i, int start, int count) { }
}

// Namespace: UnityEngine.UIElements
[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent, IPointerClickHandler // TypeDefIndex: 23079
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x20
	private readonly PanelEventHandler.PointerEvent m_PointerEvent; // 0x28
	private float m_LastClickTime; // 0x30
	private bool m_Selecting; // 0x34
	private Event m_Event; // 0x38
	private static EventModifiers s_Modifiers; // 0x0

	// Properties
	public IPanel panel { get; set; }
	private GameObject selectableGameObject { get; }
	private EventSystem eventSystem { get; }
	private bool isCurrentFocusedPanel { get; }
	private Focusable currentFocusedElement { get; }

	// Methods

	// RVA: 0x89A89EC Offset: 0x89A49EC VA: 0x89A89EC Slot: 30
	public IPanel get_panel() { }

	// RVA: 0x89A89F4 Offset: 0x89A49F4 VA: 0x89A89F4 Slot: 28
	public void set_panel(IPanel value) { }

	// RVA: 0x89A8E10 Offset: 0x89A4E10 VA: 0x89A8E10
	private GameObject get_selectableGameObject() { }

	// RVA: 0x89A8E28 Offset: 0x89A4E28 VA: 0x89A8E28
	private EventSystem get_eventSystem() { }

	// RVA: 0x89A8EFC Offset: 0x89A4EFC VA: 0x89A8EFC
	private bool get_isCurrentFocusedPanel() { }

	// RVA: 0x89A8FC4 Offset: 0x89A4FC4 VA: 0x89A8FC4
	private Focusable get_currentFocusedElement() { }

	// RVA: 0x89A8FFC Offset: 0x89A4FFC VA: 0x89A8FFC Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x89A9004 Offset: 0x89A5004 VA: 0x89A9004 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x89A8C5C Offset: 0x89A4C5C VA: 0x89A8C5C
	private void RegisterCallbacks() { }

	// RVA: 0x89A8AA8 Offset: 0x89A4AA8 VA: 0x89A8AA8
	private void UnregisterCallbacks() { }

	// RVA: 0x89A900C Offset: 0x89A500C VA: 0x89A900C
	private void OnPanelDestroyed() { }

	// RVA: 0x89A9014 Offset: 0x89A5014 VA: 0x89A9014
	private void OnElementFocus(FocusEvent e) { }

	// RVA: 0x89A90FC Offset: 0x89A50FC VA: 0x89A90FC
	private void OnElementBlur(BlurEvent e) { }

	// RVA: 0x89A9100 Offset: 0x89A5100 VA: 0x89A9100 Slot: 24
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x89A9178 Offset: 0x89A5178 VA: 0x89A9178 Slot: 25
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x89A918C Offset: 0x89A518C VA: 0x89A918C Slot: 17
	public void OnPointerMove(PointerEventData eventData) { }

	// RVA: 0x89A94DC Offset: 0x89A54DC VA: 0x89A94DC Slot: 18
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x89A96F8 Offset: 0x89A56F8 VA: 0x89A96F8 Slot: 19
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x89A9984 Offset: 0x89A5984 VA: 0x89A9984 Slot: 26
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x89A9CAC Offset: 0x89A5CAC VA: 0x89A9CAC Slot: 27
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x89A9D00 Offset: 0x89A5D00 VA: 0x89A9D00 Slot: 29
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x89A9D1C Offset: 0x89A5D1C VA: 0x89A9D1C Slot: 20
	public void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x89AA074 Offset: 0x89A6074 VA: 0x89AA074 Slot: 21
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x89AA284 Offset: 0x89A6284 VA: 0x89AA284 Slot: 22
	public void OnMove(AxisEventData eventData) { }

	// RVA: 0x89AA4B8 Offset: 0x89A64B8 VA: 0x89AA4B8 Slot: 23
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x89A9478 Offset: 0x89A5478 VA: 0x89A9478
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	// RVA: 0x89AA6AC Offset: 0x89A66AC VA: 0x89AA6AC
	private void SendEvent(EventBase e, Event sourceEvent) { }

	// RVA: 0x89AA6CC Offset: 0x89A66CC VA: 0x89AA6CC
	internal void Update() { }

	// RVA: 0x89AA728 Offset: 0x89A6728 VA: 0x89AA728
	private void LateUpdate() { }

	// RVA: 0x89A9F2C Offset: 0x89A5F2C VA: 0x89A9F2C
	private void ProcessImguiEvents(Focusable target) { }

	// RVA: 0x89AA730 Offset: 0x89A6730 VA: 0x89AA730
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	// RVA: 0x89AA7B0 Offset: 0x89A67B0 VA: 0x89AA7B0
	private void ProcessTabEvent(Event e, Focusable target) { }

	// RVA: 0x89AAC38 Offset: 0x89A6C38 VA: 0x89AAC38
	private void SendTabEvent(Event e, NavigationMoveEvent.Direction direction, Focusable target) { }

	// RVA: 0x89AA818 Offset: 0x89A6818 VA: 0x89AA818
	private void SendKeyUpEvent(Event e, Focusable target) { }

	// RVA: 0x89AAA28 Offset: 0x89A6A28 VA: 0x89AAA28
	private void SendKeyDownEvent(Event e, Focusable target) { }

	// RVA: 0x89A9338 Offset: 0x89A5338 VA: 0x89A9338
	private bool ReadPointerData(PanelEventHandler.PointerEvent pe, PointerEventData eventData, PanelEventHandler.PointerEventType eventType = 0) { }

	// RVA: 0x89AB314 Offset: 0x89A7314 VA: 0x89AB314
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent // TypeDefIndex: 23080
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x28

	// Properties
	public IPanel panel { get; set; }
	private GameObject selectableGameObject { get; }
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x89AB60C Offset: 0x89A760C VA: 0x89AB60C Slot: 23
	public IPanel get_panel() { }

	// RVA: 0x89AB614 Offset: 0x89A7614 VA: 0x89AB614 Slot: 22
	public void set_panel(IPanel value) { }

	// RVA: 0x89AB758 Offset: 0x89A7758 VA: 0x89AB758
	private void RegisterCallbacks() { }

	// RVA: 0x89AB6C8 Offset: 0x89A76C8 VA: 0x89AB6C8
	private void UnregisterCallbacks() { }

	// RVA: 0x89AB7E8 Offset: 0x89A77E8 VA: 0x89AB7E8
	private void OnPanelDestroyed() { }

	// RVA: 0x89AB7F0 Offset: 0x89A77F0 VA: 0x89AB7F0
	private GameObject get_selectableGameObject() { }

	// RVA: 0x89AB808 Offset: 0x89A7808 VA: 0x89AB808 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x89AB884 Offset: 0x89A7884 VA: 0x89AB884 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x89AB8F8 Offset: 0x89A78F8 VA: 0x89AB8F8 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x89ABDB8 Offset: 0x89A7DB8 VA: 0x89ABDB8 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x89ABDC0 Offset: 0x89A7DC0 VA: 0x89ABDC0
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public class AxisEventData : BaseEventData // TypeDefIndex: 23081
{
	// Fields
	[CompilerGenerated]
	private Vector2 <moveVector>k__BackingField; // 0x20
	[CompilerGenerated]
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Properties
	public Vector2 moveVector { get; set; }
	public MoveDirection moveDir { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89ABDD0 Offset: 0x89A7DD0 VA: 0x89ABDD0
	public Vector2 get_moveVector() { }

	[CompilerGenerated]
	// RVA: 0x89ABDD8 Offset: 0x89A7DD8 VA: 0x89ABDD8
	public void set_moveVector(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89ABDE0 Offset: 0x89A7DE0 VA: 0x89ABDE0
	public MoveDirection get_moveDir() { }

	[CompilerGenerated]
	// RVA: 0x89ABDE8 Offset: 0x89A7DE8 VA: 0x89ABDE8
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x89ABDF0 Offset: 0x89A7DF0 VA: 0x89ABDF0
	public void .ctor(EventSystem eventSystem) { }
}

// Namespace: UnityEngine.EventSystems
public abstract class AbstractEventData // TypeDefIndex: 23082
{
	// Fields
	protected bool m_Used; // 0x10

	// Properties
	public virtual bool used { get; }

	// Methods

	// RVA: 0x89ABE94 Offset: 0x89A7E94 VA: 0x89ABE94 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x89ABE9C Offset: 0x89A7E9C VA: 0x89ABE9C Slot: 5
	public virtual void Use() { }

	// RVA: 0x89ABEA8 Offset: 0x89A7EA8 VA: 0x89ABEA8 Slot: 6
	public virtual bool get_used() { }

	// RVA: 0x89ABEB0 Offset: 0x89A7EB0 VA: 0x89ABEB0
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public class BaseEventData : AbstractEventData // TypeDefIndex: 23083
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Properties
	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }

	// Methods

	// RVA: 0x89ABE64 Offset: 0x89A7E64 VA: 0x89ABE64
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x89ABEB8 Offset: 0x89A7EB8 VA: 0x89ABEB8
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x89ABED4 Offset: 0x89A7ED4 VA: 0x89ABED4
	public GameObject get_selectedObject() { }

	// RVA: 0x89ABEF0 Offset: 0x89A7EF0 VA: 0x89ABEF0
	public void set_selectedObject(GameObject value) { }
}

// Namespace: 
public enum PointerEventData.InputButton // TypeDefIndex: 23084
{
	// Fields
	public int value__; // 0x0
	public const PointerEventData.InputButton Left = 0;
	public const PointerEventData.InputButton Right = 1;
	public const PointerEventData.InputButton Middle = 2;
}

// Namespace: 
public enum PointerEventData.FramePressState // TypeDefIndex: 23085
{
	// Fields
	public int value__; // 0x0
	public const PointerEventData.FramePressState Pressed = 0;
	public const PointerEventData.FramePressState Released = 1;
	public const PointerEventData.FramePressState PressedAndReleased = 2;
	public const PointerEventData.FramePressState NotChanged = 3;
}

// Namespace: UnityEngine.EventSystems
public class PointerEventData : BaseEventData // TypeDefIndex: 23086
{
	// Fields
	[CompilerGenerated]
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGenerated]
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGenerated]
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGenerated]
	private GameObject <pointerClick>k__BackingField; // 0x48
	[CompilerGenerated]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x50
	[CompilerGenerated]
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0xA0
	public List<GameObject> hovered; // 0xF0
	[CompilerGenerated]
	private bool <eligibleForClick>k__BackingField; // 0xF8
	[CompilerGenerated]
	private int <displayIndex>k__BackingField; // 0xFC
	[CompilerGenerated]
	private int <pointerId>k__BackingField; // 0x100
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; // 0x104
	[CompilerGenerated]
	private Vector2 <delta>k__BackingField; // 0x10C
	[CompilerGenerated]
	private Vector2 <pressPosition>k__BackingField; // 0x114
	[CompilerGenerated]
	private Vector3 <worldPosition>k__BackingField; // 0x11C
	[CompilerGenerated]
	private Vector3 <worldNormal>k__BackingField; // 0x128
	[CompilerGenerated]
	private float <clickTime>k__BackingField; // 0x134
	[CompilerGenerated]
	private int <clickCount>k__BackingField; // 0x138
	[CompilerGenerated]
	private Vector2 <scrollDelta>k__BackingField; // 0x13C
	[CompilerGenerated]
	private bool <useDragThreshold>k__BackingField; // 0x144
	[CompilerGenerated]
	private bool <dragging>k__BackingField; // 0x145
	[CompilerGenerated]
	private PointerEventData.InputButton <button>k__BackingField; // 0x148
	[CompilerGenerated]
	private float <pressure>k__BackingField; // 0x14C
	[CompilerGenerated]
	private float <tangentialPressure>k__BackingField; // 0x150
	[CompilerGenerated]
	private float <altitudeAngle>k__BackingField; // 0x154
	[CompilerGenerated]
	private float <azimuthAngle>k__BackingField; // 0x158
	[CompilerGenerated]
	private float <twist>k__BackingField; // 0x15C
	[CompilerGenerated]
	private Vector2 <tilt>k__BackingField; // 0x160
	[CompilerGenerated]
	private PenStatus <penStatus>k__BackingField; // 0x168
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; // 0x16C
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; // 0x174
	[CompilerGenerated]
	private bool <fullyExited>k__BackingField; // 0x17C
	[CompilerGenerated]
	private bool <reentered>k__BackingField; // 0x17D

	// Properties
	public GameObject pointerEnter { get; set; }
	public GameObject lastPress { get; set; }
	public GameObject rawPointerPress { get; set; }
	public GameObject pointerDrag { get; set; }
	public GameObject pointerClick { get; set; }
	public RaycastResult pointerCurrentRaycast { get; set; }
	public RaycastResult pointerPressRaycast { get; set; }
	public bool eligibleForClick { get; set; }
	public int displayIndex { get; set; }
	public int pointerId { get; set; }
	public Vector2 position { get; set; }
	public Vector2 delta { get; set; }
	public Vector2 pressPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	public Vector3 worldPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	public Vector3 worldNormal { get; set; }
	public float clickTime { get; set; }
	public int clickCount { get; set; }
	public Vector2 scrollDelta { get; set; }
	public bool useDragThreshold { get; set; }
	public bool dragging { get; set; }
	public PointerEventData.InputButton button { get; set; }
	public float pressure { get; set; }
	public float tangentialPressure { get; set; }
	public float altitudeAngle { get; set; }
	public float azimuthAngle { get; set; }
	public float twist { get; set; }
	public Vector2 tilt { get; set; }
	public PenStatus penStatus { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public bool fullyExited { get; set; }
	public bool reentered { get; set; }
	public Camera enterEventCamera { get; }
	public Camera pressEventCamera { get; }
	public GameObject pointerPress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x89AC144 Offset: 0x89A8144 VA: 0x89AC144
	public GameObject get_pointerEnter() { }

	[CompilerGenerated]
	// RVA: 0x89AC14C Offset: 0x89A814C VA: 0x89AC14C
	public void set_pointerEnter(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x89AC154 Offset: 0x89A8154 VA: 0x89AC154
	public GameObject get_lastPress() { }

	[CompilerGenerated]
	// RVA: 0x89AC15C Offset: 0x89A815C VA: 0x89AC15C
	private void set_lastPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x89AC164 Offset: 0x89A8164 VA: 0x89AC164
	public GameObject get_rawPointerPress() { }

	[CompilerGenerated]
	// RVA: 0x89AC16C Offset: 0x89A816C VA: 0x89AC16C
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x89AC174 Offset: 0x89A8174 VA: 0x89AC174
	public GameObject get_pointerDrag() { }

	[CompilerGenerated]
	// RVA: 0x89AC17C Offset: 0x89A817C VA: 0x89AC17C
	public void set_pointerDrag(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x89AC184 Offset: 0x89A8184 VA: 0x89AC184
	public GameObject get_pointerClick() { }

	[CompilerGenerated]
	// RVA: 0x89AC18C Offset: 0x89A818C VA: 0x89AC18C
	public void set_pointerClick(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x89AC194 Offset: 0x89A8194 VA: 0x89AC194
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGenerated]
	// RVA: 0x89AC1A4 Offset: 0x89A81A4 VA: 0x89AC1A4
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x89AC1C8 Offset: 0x89A81C8 VA: 0x89AC1C8
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGenerated]
	// RVA: 0x89AC1D8 Offset: 0x89A81D8 VA: 0x89AC1D8
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x89AC1FC Offset: 0x89A81FC VA: 0x89AC1FC
	public bool get_eligibleForClick() { }

	[CompilerGenerated]
	// RVA: 0x89AC204 Offset: 0x89A8204 VA: 0x89AC204
	public void set_eligibleForClick(bool value) { }

	[CompilerGenerated]
	// RVA: 0x89AC210 Offset: 0x89A8210 VA: 0x89AC210
	public int get_displayIndex() { }

	[CompilerGenerated]
	// RVA: 0x89AC218 Offset: 0x89A8218 VA: 0x89AC218
	public void set_displayIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x89AC220 Offset: 0x89A8220 VA: 0x89AC220
	public int get_pointerId() { }

	[CompilerGenerated]
	// RVA: 0x89AC228 Offset: 0x89A8228 VA: 0x89AC228
	public void set_pointerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x89AC230 Offset: 0x89A8230 VA: 0x89AC230
	public Vector2 get_position() { }

	[CompilerGenerated]
	// RVA: 0x89AC23C Offset: 0x89A823C VA: 0x89AC23C
	public void set_position(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AC248 Offset: 0x89A8248 VA: 0x89AC248
	public Vector2 get_delta() { }

	[CompilerGenerated]
	// RVA: 0x89AC254 Offset: 0x89A8254 VA: 0x89AC254
	public void set_delta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AC260 Offset: 0x89A8260 VA: 0x89AC260
	public Vector2 get_pressPosition() { }

	[CompilerGenerated]
	// RVA: 0x89AC26C Offset: 0x89A826C VA: 0x89AC26C
	public void set_pressPosition(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AC278 Offset: 0x89A8278 VA: 0x89AC278
	public Vector3 get_worldPosition() { }

	[CompilerGenerated]
	// RVA: 0x89AC288 Offset: 0x89A8288 VA: 0x89AC288
	public void set_worldPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x89AC298 Offset: 0x89A8298 VA: 0x89AC298
	public Vector3 get_worldNormal() { }

	[CompilerGenerated]
	// RVA: 0x89AC2A8 Offset: 0x89A82A8 VA: 0x89AC2A8
	public void set_worldNormal(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x89AC2B8 Offset: 0x89A82B8 VA: 0x89AC2B8
	public float get_clickTime() { }

	[CompilerGenerated]
	// RVA: 0x89AC2C0 Offset: 0x89A82C0 VA: 0x89AC2C0
	public void set_clickTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AC2C8 Offset: 0x89A82C8 VA: 0x89AC2C8
	public int get_clickCount() { }

	[CompilerGenerated]
	// RVA: 0x89AC2D0 Offset: 0x89A82D0 VA: 0x89AC2D0
	public void set_clickCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x89AC2D8 Offset: 0x89A82D8 VA: 0x89AC2D8
	public Vector2 get_scrollDelta() { }

	[CompilerGenerated]
	// RVA: 0x89AC2E4 Offset: 0x89A82E4 VA: 0x89AC2E4
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AC2F0 Offset: 0x89A82F0 VA: 0x89AC2F0
	public bool get_useDragThreshold() { }

	[CompilerGenerated]
	// RVA: 0x89AC2F8 Offset: 0x89A82F8 VA: 0x89AC2F8
	public void set_useDragThreshold(bool value) { }

	[CompilerGenerated]
	// RVA: 0x89AC304 Offset: 0x89A8304 VA: 0x89AC304
	public bool get_dragging() { }

	[CompilerGenerated]
	// RVA: 0x89AC30C Offset: 0x89A830C VA: 0x89AC30C
	public void set_dragging(bool value) { }

	[CompilerGenerated]
	// RVA: 0x89AC318 Offset: 0x89A8318 VA: 0x89AC318
	public PointerEventData.InputButton get_button() { }

	[CompilerGenerated]
	// RVA: 0x89AC320 Offset: 0x89A8320 VA: 0x89AC320
	public void set_button(PointerEventData.InputButton value) { }

	[CompilerGenerated]
	// RVA: 0x89AC328 Offset: 0x89A8328 VA: 0x89AC328
	public float get_pressure() { }

	[CompilerGenerated]
	// RVA: 0x89AC330 Offset: 0x89A8330 VA: 0x89AC330
	public void set_pressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AC338 Offset: 0x89A8338 VA: 0x89AC338
	public float get_tangentialPressure() { }

	[CompilerGenerated]
	// RVA: 0x89AC340 Offset: 0x89A8340 VA: 0x89AC340
	public void set_tangentialPressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AC348 Offset: 0x89A8348 VA: 0x89AC348
	public float get_altitudeAngle() { }

	[CompilerGenerated]
	// RVA: 0x89AC350 Offset: 0x89A8350 VA: 0x89AC350
	public void set_altitudeAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AC358 Offset: 0x89A8358 VA: 0x89AC358
	public float get_azimuthAngle() { }

	[CompilerGenerated]
	// RVA: 0x89AC360 Offset: 0x89A8360 VA: 0x89AC360
	public void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AC368 Offset: 0x89A8368 VA: 0x89AC368
	public float get_twist() { }

	[CompilerGenerated]
	// RVA: 0x89AC370 Offset: 0x89A8370 VA: 0x89AC370
	public void set_twist(float value) { }

	[CompilerGenerated]
	// RVA: 0x89AC378 Offset: 0x89A8378 VA: 0x89AC378
	public Vector2 get_tilt() { }

	[CompilerGenerated]
	// RVA: 0x89AC384 Offset: 0x89A8384 VA: 0x89AC384
	public void set_tilt(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AC390 Offset: 0x89A8390 VA: 0x89AC390
	public PenStatus get_penStatus() { }

	[CompilerGenerated]
	// RVA: 0x89AC398 Offset: 0x89A8398 VA: 0x89AC398
	public void set_penStatus(PenStatus value) { }

	[CompilerGenerated]
	// RVA: 0x89AC3A0 Offset: 0x89A83A0 VA: 0x89AC3A0
	public Vector2 get_radius() { }

	[CompilerGenerated]
	// RVA: 0x89AC3AC Offset: 0x89A83AC VA: 0x89AC3AC
	public void set_radius(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AC3B8 Offset: 0x89A83B8 VA: 0x89AC3B8
	public Vector2 get_radiusVariance() { }

	[CompilerGenerated]
	// RVA: 0x89AC3C4 Offset: 0x89A83C4 VA: 0x89AC3C4
	public void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x89AC3D0 Offset: 0x89A83D0 VA: 0x89AC3D0
	public bool get_fullyExited() { }

	[CompilerGenerated]
	// RVA: 0x89AC3D8 Offset: 0x89A83D8 VA: 0x89AC3D8
	public void set_fullyExited(bool value) { }

	[CompilerGenerated]
	// RVA: 0x89AC3E4 Offset: 0x89A83E4 VA: 0x89AC3E4
	public bool get_reentered() { }

	[CompilerGenerated]
	// RVA: 0x89AC3EC Offset: 0x89A83EC VA: 0x89AC3EC
	public void set_reentered(bool value) { }

	// RVA: 0x89AC3F8 Offset: 0x89A83F8 VA: 0x89AC3F8
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x89AC540 Offset: 0x89A8540 VA: 0x89AC540
	public bool IsPointerMoving() { }

	// RVA: 0x89AC560 Offset: 0x89A8560 VA: 0x89AC560
	public bool IsScrolling() { }

	// RVA: 0x89AC580 Offset: 0x89A8580 VA: 0x89AC580
	public Camera get_enterEventCamera() { }

	// RVA: 0x89AC610 Offset: 0x89A8610 VA: 0x89AC610
	public Camera get_pressEventCamera() { }

	// RVA: 0x89AC6A0 Offset: 0x89A86A0 VA: 0x89AC6A0
	public GameObject get_pointerPress() { }

	// RVA: 0x89AC6A8 Offset: 0x89A86A8 VA: 0x89AC6A8
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x89AC74C Offset: 0x89A874C VA: 0x89AC74C Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
[Flags]
public enum EventHandle // TypeDefIndex: 23087
{
	// Fields
	public int value__; // 0x0
	public const EventHandle Unused = 0;
	public const EventHandle Used = 1;
}

// Namespace: UnityEngine.EventSystems
public interface IEventSystemHandler // TypeDefIndex: 23088
{}

// Namespace: UnityEngine.EventSystems
public interface IPointerMoveHandler : IEventSystemHandler // TypeDefIndex: 23089
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerMove(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 23090
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerEnter(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 23091
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerExit(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 23092
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerDown(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 23093
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerUp(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 23094
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerClick(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 23095
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeginDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 23096
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitializePotentialDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 23097
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 23098
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEndDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 23099
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrop(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 23100
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnScroll(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 23101
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnUpdateSelected(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 23102
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSelect(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 23103
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeselect(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 23104
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnMove(AxisEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 23105
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSubmit(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 23106
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCancel(BaseEventData eventData);
}

// Namespace: 
private struct EventSystem.UIToolkitOverrideConfig // TypeDefIndex: 23107
{
	// Fields
	public EventSystem activeEventSystem; // 0x0
	public bool sendEvents; // 0x8
	public bool createPanelGameObjectsOnStart; // 0x9
}

// Namespace: 
[CompilerGenerated]
private sealed class EventSystem.<>c__DisplayClass56_0 // TypeDefIndex: 23108
{
	// Fields
	public GameObject go; // 0x10

	// Methods

	// RVA: 0x89AE980 Offset: 0x89AA980 VA: 0x89AE980
	public void .ctor() { }

	// RVA: 0x89AF310 Offset: 0x89AB310 VA: 0x89AF310
	internal void <CreateUIToolkitPanelGameObject>b__0() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Event System")]
[DisallowMultipleComponent]
public class EventSystem : UIBehaviour // TypeDefIndex: 23109
{
	// Fields
	private List<BaseInputModule> m_SystemInputModules; // 0x20
	private BaseInputModule m_CurrentInputModule; // 0x28
	private static List<EventSystem> m_EventSystems; // 0x0
	[SerializeField]
	[FormerlySerializedAs("m_Selected")]
	private GameObject m_FirstSelected; // 0x30
	[SerializeField]
	private bool m_sendNavigationEvents; // 0x38
	[SerializeField]
	private int m_DragThreshold; // 0x3C
	private GameObject m_CurrentSelected; // 0x40
	private bool m_HasFocus; // 0x48
	private bool m_SelectionGuard; // 0x49
	private BaseEventData m_DummyData; // 0x50
	private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x8
	private static EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride; // 0x10
	private bool m_Started; // 0x58
	private bool m_IsTrackingUIToolkitPanels; // 0x59

	// Properties
	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[Obsolete("lastSelectedGameObject is no longer supported")]
	public GameObject lastSelectedGameObject { get; }
	public bool isFocused { get; }
	public bool alreadySelecting { get; }
	private BaseEventData baseEventDataCache { get; }
	private bool isUIToolkitActiveEventSystem { get; }
	private bool sendUIToolkitEvents { get; }
	private bool createUIToolkitPanelGameObjectsOnStart { get; }

	// Methods

	// RVA: 0x89AD428 Offset: 0x89A9428 VA: 0x89AD428
	public static EventSystem get_current() { }

	// RVA: 0x89AD4EC Offset: 0x89A94EC VA: 0x89AD4EC
	public static void set_current(EventSystem value) { }

	// RVA: 0x89AD680 Offset: 0x89A9680 VA: 0x89AD680
	public bool get_sendNavigationEvents() { }

	// RVA: 0x89AD688 Offset: 0x89A9688 VA: 0x89AD688
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x89AD694 Offset: 0x89A9694 VA: 0x89AD694
	public int get_pixelDragThreshold() { }

	// RVA: 0x89AD69C Offset: 0x89A969C VA: 0x89AD69C
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x89AD6A4 Offset: 0x89A96A4 VA: 0x89AD6A4
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x89AD6AC Offset: 0x89A96AC VA: 0x89AD6AC
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x89AD6B4 Offset: 0x89A96B4 VA: 0x89AD6B4
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x89AD6BC Offset: 0x89A96BC VA: 0x89AD6BC
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x89AD6C4 Offset: 0x89A96C4 VA: 0x89AD6C4
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x89AD6CC Offset: 0x89A96CC VA: 0x89AD6CC
	public bool get_isFocused() { }

	// RVA: 0x89AD6D4 Offset: 0x89A96D4 VA: 0x89AD6D4
	protected void .ctor() { }

	// RVA: 0x89AD770 Offset: 0x89A9770 VA: 0x89AD770
	public void UpdateModules() { }

	// RVA: 0x89AD8B0 Offset: 0x89A98B0 VA: 0x89AD8B0
	public bool get_alreadySelecting() { }

	// RVA: 0x89ABF0C Offset: 0x89A7F0C VA: 0x89ABF0C
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x89AD8B8 Offset: 0x89A98B8 VA: 0x89AD8B8
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x89A90D0 Offset: 0x89A50D0 VA: 0x89A90D0
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x89AD93C Offset: 0x89A993C VA: 0x89AD93C
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x89ADDC0 Offset: 0x89A9DC0 VA: 0x89ADDC0
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x89ADFB0 Offset: 0x89A9FB0 VA: 0x89ADFB0
	public bool IsPointerOverGameObject() { }

	// RVA: 0x89ADFB8 Offset: 0x89A9FB8 VA: 0x89ADFB8
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x89AE05C Offset: 0x89AA05C VA: 0x89AE05C
	private bool get_isUIToolkitActiveEventSystem() { }

	// RVA: 0x89AE14C Offset: 0x89AA14C VA: 0x89AE14C
	private bool get_sendUIToolkitEvents() { }

	// RVA: 0x89AE1C0 Offset: 0x89AA1C0 VA: 0x89AE1C0
	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	// RVA: 0x89AE234 Offset: 0x89AA234 VA: 0x89AE234
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = True, bool createPanelGameObjectsOnStart = True) { }

	// RVA: 0x89AE3DC Offset: 0x89AA3DC VA: 0x89AE3DC
	private void StartTrackingUIToolkitPanels() { }

	// RVA: 0x89AE8D4 Offset: 0x89AA8D4 VA: 0x89AE8D4
	private void StopTrackingUIToolkitPanels() { }

	// RVA: 0x89AE614 Offset: 0x89AA614 VA: 0x89AE614
	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	// RVA: 0x89AE988 Offset: 0x89AA988 VA: 0x89AE988 Slot: 6
	protected override void Start() { }

	// RVA: 0x89AE998 Offset: 0x89AA998 VA: 0x89AE998 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x89AEAC8 Offset: 0x89AAAC8 VA: 0x89AEAC8 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x89AEBF0 Offset: 0x89AABF0 VA: 0x89AEBF0
	private void TickModules() { }

	// RVA: 0x89AECF0 Offset: 0x89AACF0 VA: 0x89AECF0 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x89AED04 Offset: 0x89AAD04 VA: 0x89AED04 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x89AEF6C Offset: 0x89AAF6C VA: 0x89AEF6C
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x89AF07C Offset: 0x89AB07C VA: 0x89AF07C Slot: 3
	public override string ToString() { }

	// RVA: 0x89AF1D4 Offset: 0x89AB1D4 VA: 0x89AF1D4
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class EventTrigger.TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 23110
{
	// Methods

	// RVA: 0x89AF5BC Offset: 0x89AB5BC VA: 0x89AF5BC
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class EventTrigger.Entry // TypeDefIndex: 23111
{
	// Fields
	public EventTriggerType eventID; // 0x10
	public EventTrigger.TriggerEvent callback; // 0x18

	// Methods

	// RVA: 0x89AF604 Offset: 0x89AB604 VA: 0x89AF604
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Event Trigger")]
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 23112
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("delegates")]
	private List<EventTrigger.Entry> m_Delegates; // 0x20

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }

	// Methods

	// RVA: 0x89AF36C Offset: 0x89AB36C VA: 0x89AF36C
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x89AF3F4 Offset: 0x89AB3F4 VA: 0x89AF3F4
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x89AF3FC Offset: 0x89AB3FC VA: 0x89AF3FC
	protected void .ctor() { }

	// RVA: 0x89AF370 Offset: 0x89AB370 VA: 0x89AF370
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x89AF404 Offset: 0x89AB404 VA: 0x89AF404
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x89AF40C Offset: 0x89AB40C VA: 0x89AF40C
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x89AF4F0 Offset: 0x89AB4F0 VA: 0x89AF4F0 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x89AF4FC Offset: 0x89AB4FC VA: 0x89AF4FC Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x89AF508 Offset: 0x89AB508 VA: 0x89AF508 Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x89AF514 Offset: 0x89AB514 VA: 0x89AF514 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x89AF520 Offset: 0x89AB520 VA: 0x89AF520 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x89AF52C Offset: 0x89AB52C VA: 0x89AF52C Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x89AF538 Offset: 0x89AB538 VA: 0x89AF538 Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x89AF544 Offset: 0x89AB544 VA: 0x89AF544 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x89AF550 Offset: 0x89AB550 VA: 0x89AF550 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x89AF55C Offset: 0x89AB55C VA: 0x89AF55C Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x89AF568 Offset: 0x89AB568 VA: 0x89AF568 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x89AF574 Offset: 0x89AB574 VA: 0x89AF574 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x89AF580 Offset: 0x89AB580 VA: 0x89AF580 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x89AF58C Offset: 0x89AB58C VA: 0x89AF58C Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x89AF598 Offset: 0x89AB598 VA: 0x89AF598 Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x89AF5A4 Offset: 0x89AB5A4 VA: 0x89AF5A4 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x89AF5B0 Offset: 0x89AB5B0 VA: 0x89AF5B0 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }
}

// Namespace: UnityEngine.EventSystems
public enum EventTriggerType // TypeDefIndex: 23113
{
	// Fields
	public int value__; // 0x0
	public const EventTriggerType PointerEnter = 0;
	public const EventTriggerType PointerExit = 1;
	public const EventTriggerType PointerDown = 2;
	public const EventTriggerType PointerUp = 3;
	public const EventTriggerType PointerClick = 4;
	public const EventTriggerType Drag = 5;
	public const EventTriggerType Drop = 6;
	public const EventTriggerType Scroll = 7;
	public const EventTriggerType UpdateSelected = 8;
	public const EventTriggerType Select = 9;
	public const EventTriggerType Deselect = 10;
	public const EventTriggerType Move = 11;
	public const EventTriggerType InitializePotentialDrag = 12;
	public const EventTriggerType BeginDrag = 13;
	public const EventTriggerType EndDrag = 14;
	public const EventTriggerType Submit = 15;
	public const EventTriggerType Cancel = 16;
}

// Namespace: 
public sealed class ExecuteEvents.EventFunction<T1> : MulticastDelegate // TypeDefIndex: 23114
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6319950 Offset: 0x6315950 VA: 0x6319950
	|-ExecuteEvents.EventFunction<object>..ctor
	|
	|-RVA: 0x6319AA4 Offset: 0x6315AA4 VA: 0x6319AA4
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6319A5C Offset: 0x6315A5C VA: 0x6319A5C
	|-ExecuteEvents.EventFunction<object>.Invoke
	|
	|-RVA: 0x6319BB0 Offset: 0x6315BB0 VA: 0x6319BB0
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6319A70 Offset: 0x6315A70 VA: 0x6319A70
	|-ExecuteEvents.EventFunction<object>.BeginInvoke
	|
	|-RVA: 0x6319BC4 Offset: 0x6315BC4 VA: 0x6319BC4
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6319A98 Offset: 0x6315A98 VA: 0x6319A98
	|-ExecuteEvents.EventFunction<object>.EndInvoke
	|
	|-RVA: 0x6319C4C Offset: 0x6315C4C VA: 0x6319C4C
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: UnityEngine.EventSystems
public static class ExecuteEvents // TypeDefIndex: 23115
{
	// Fields
	private static readonly ExecuteEvents.EventFunction<IPointerMoveHandler> s_PointerMoveHandler; // 0x0
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x8
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x10
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x18
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x20
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x28
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x30
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x38
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; // 0x40
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; // 0x48
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; // 0x50
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; // 0x58
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x60
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; // 0x68
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; // 0x70
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; // 0x78
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; // 0x80
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; // 0x88
	private static readonly List<Transform> s_InternalTransformList; // 0x90

	// Properties
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> pointerMoveHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler { get; }
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
	public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDragHandler> dragHandler { get; }
	public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDropHandler> dropHandler { get; }
	public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler { get; }
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
	public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler { get; }
	public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler { get; }
	public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler { get; }
	public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler { get; }
	public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F036C Offset: 0x45EC36C VA: 0x45F036C
	|-ExecuteEvents.ValidateEventData<object>
	*/

	// RVA: 0x89AF674 Offset: 0x89AB674 VA: 0x89AF674
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AF768 Offset: 0x89AB768 VA: 0x89AF768
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AF85C Offset: 0x89AB85C VA: 0x89AF85C
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AF950 Offset: 0x89AB950 VA: 0x89AF950
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AFA44 Offset: 0x89ABA44 VA: 0x89AFA44
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AFB38 Offset: 0x89ABB38 VA: 0x89AFB38
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AFC2C Offset: 0x89ABC2C VA: 0x89AFC2C
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AFD20 Offset: 0x89ABD20 VA: 0x89AFD20
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AFE14 Offset: 0x89ABE14 VA: 0x89AFE14
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AFF08 Offset: 0x89ABF08 VA: 0x89AFF08
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x89AFFFC Offset: 0x89ABFFC VA: 0x89AFFFC
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x89B00F0 Offset: 0x89AC0F0 VA: 0x89B00F0
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x89B01E4 Offset: 0x89AC1E4 VA: 0x89B01E4
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x89B0288 Offset: 0x89AC288 VA: 0x89B0288
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x89B032C Offset: 0x89AC32C VA: 0x89B032C
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x89B03D0 Offset: 0x89AC3D0 VA: 0x89B03D0
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x89B04C4 Offset: 0x89AC4C4 VA: 0x89B04C4
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x89B0568 Offset: 0x89AC568 VA: 0x89B0568
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x89B060C Offset: 0x89AC60C VA: 0x89B060C
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x89B0664 Offset: 0x89AC664 VA: 0x89B0664
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x89B06BC Offset: 0x89AC6BC VA: 0x89B06BC
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x89B0714 Offset: 0x89AC714 VA: 0x89B0714
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x89B076C Offset: 0x89AC76C VA: 0x89B076C
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x89B07C4 Offset: 0x89AC7C4 VA: 0x89B07C4
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x89B081C Offset: 0x89AC81C VA: 0x89B081C
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x89B0874 Offset: 0x89AC874 VA: 0x89B0874
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x89B08CC Offset: 0x89AC8CC VA: 0x89B08CC
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x89B0924 Offset: 0x89AC924 VA: 0x89B0924
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x89B097C Offset: 0x89AC97C VA: 0x89B097C
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x89B09D4 Offset: 0x89AC9D4 VA: 0x89B09D4
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x89B0A2C Offset: 0x89ACA2C VA: 0x89B0A2C
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x89B0A84 Offset: 0x89ACA84 VA: 0x89B0A84
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x89B0ADC Offset: 0x89ACADC VA: 0x89B0ADC
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x89B0B34 Offset: 0x89ACB34 VA: 0x89B0B34
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x89B0B8C Offset: 0x89ACB8C VA: 0x89B0B8C
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x89B0BE4 Offset: 0x89ACBE4 VA: 0x89B0BE4
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x89B0C3C Offset: 0x89ACC3C VA: 0x89B0C3C
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EEE40 Offset: 0x45EAE40 VA: 0x45EEE40
	|-ExecuteEvents.Execute<object>
	|
	|-RVA: 0x45EF20C Offset: 0x45EB20C VA: 0x45EF20C
	|-ExecuteEvents.Execute<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EF670 Offset: 0x45EB670 VA: 0x45EF670
	|-ExecuteEvents.ExecuteHierarchy<object>
	|
	|-RVA: 0x45EF7CC Offset: 0x45EB7CC VA: 0x45EF7CC
	|-ExecuteEvents.ExecuteHierarchy<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45F016C Offset: 0x45EC16C VA: 0x45F016C
	|-ExecuteEvents.ShouldSendToComponent<object>
	|
	|-RVA: 0x45F026C Offset: 0x45EC26C VA: 0x45F026C
	|-ExecuteEvents.ShouldSendToComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EFB90 Offset: 0x45EBB90 VA: 0x45EFB90
	|-ExecuteEvents.GetEventList<object>
	|
	|-RVA: 0x45EFE7C Offset: 0x45EBE7C VA: 0x45EFE7C
	|-ExecuteEvents.GetEventList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EEC54 Offset: 0x45EAC54 VA: 0x45EEC54
	|-ExecuteEvents.CanHandleEvent<object>
	|
	|-RVA: 0x45EED48 Offset: 0x45EAD48 VA: 0x45EED48
	|-ExecuteEvents.CanHandleEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EF92C Offset: 0x45EB92C VA: 0x45EF92C
	|-ExecuteEvents.GetEventHandler<object>
	|
	|-RVA: 0x45EFA5C Offset: 0x45EBA5C VA: 0x45EFA5C
	|-ExecuteEvents.GetEventHandler<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x89B0DD0 Offset: 0x89ACDD0 VA: 0x89B0DD0
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
public class BaseInput : UIBehaviour // TypeDefIndex: 23116
{
	// Properties
	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }

	// Methods

	// RVA: 0x89B14B4 Offset: 0x89AD4B4 VA: 0x89B14B4 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x89B14BC Offset: 0x89AD4BC VA: 0x89B14BC Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x89B14C4 Offset: 0x89AD4C4 VA: 0x89B14C4 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x89B14D0 Offset: 0x89AD4D0 VA: 0x89B14D0 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x89B14D8 Offset: 0x89AD4D8 VA: 0x89B14D8 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x89B14E0 Offset: 0x89AD4E0 VA: 0x89B14E0 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x89B14E8 Offset: 0x89AD4E8 VA: 0x89B14E8 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x89B14F4 Offset: 0x89AD4F4 VA: 0x89B14F4 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x89B1500 Offset: 0x89AD500 VA: 0x89B1500 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x89B150C Offset: 0x89AD50C VA: 0x89B150C Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x89B1514 Offset: 0x89AD514 VA: 0x89B1514 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x89B151C Offset: 0x89AD51C VA: 0x89B151C Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x89B1524 Offset: 0x89AD524 VA: 0x89B1524 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x89B152C Offset: 0x89AD52C VA: 0x89B152C Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x89B1564 Offset: 0x89AD564 VA: 0x89B1564 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x89B1570 Offset: 0x89AD570 VA: 0x89B1570 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x89B157C Offset: 0x89AD57C VA: 0x89B157C
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[RequireComponent(typeof(EventSystem))]
public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 23117
{
	// Fields
	protected List<RaycastResult> m_RaycastResultCache; // 0x20
	[SerializeField]
	private bool m_SendPointerHoverToParent; // 0x28
	private AxisEventData m_AxisEventData; // 0x30
	private EventSystem m_EventSystem; // 0x38
	private BaseEventData m_BaseEventData; // 0x40
	protected BaseInput m_InputOverride; // 0x48
	private BaseInput m_DefaultInput; // 0x50

	// Properties
	internal bool sendPointerHoverToParent { get; set; }
	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }

	// Methods

	// RVA: 0x89B1584 Offset: 0x89AD584 VA: 0x89B1584
	internal bool get_sendPointerHoverToParent() { }

	// RVA: 0x89B158C Offset: 0x89AD58C VA: 0x89B158C
	internal void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x89B1598 Offset: 0x89AD598 VA: 0x89B1598
	public BaseInput get_input() { }

	// RVA: 0x89B17C8 Offset: 0x89AD7C8 VA: 0x89B17C8
	public BaseInput get_inputOverride() { }

	// RVA: 0x89B17D0 Offset: 0x89AD7D0 VA: 0x89B17D0
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x89B17D8 Offset: 0x89AD7D8 VA: 0x89B17D8
	protected EventSystem get_eventSystem() { }

	// RVA: 0x89B17E0 Offset: 0x89AD7E0 VA: 0x89B17E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x89B1848 Offset: 0x89AD848 VA: 0x89B1848 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process();

	// RVA: 0x89B1860 Offset: 0x89AD860 VA: 0x89B1860
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x89B1974 Offset: 0x89AD974 VA: 0x89B1974
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x89B19C8 Offset: 0x89AD9C8 VA: 0x89B19C8
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x89B1A18 Offset: 0x89ADA18 VA: 0x89B1A18
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x89B1B8C Offset: 0x89ADB8C VA: 0x89B1B8C
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x89B2648 Offset: 0x89AE648 VA: 0x89B2648 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x89B2760 Offset: 0x89AE760 VA: 0x89B2760 Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x89B2808 Offset: 0x89AE808 VA: 0x89B2808 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x89B2810 Offset: 0x89AE810 VA: 0x89B2810 Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x89B2850 Offset: 0x89AE850 VA: 0x89B2850 Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x89B2854 Offset: 0x89AE854 VA: 0x89B2854 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x89B2858 Offset: 0x89AE858 VA: 0x89B2858 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x89B285C Offset: 0x89AE85C VA: 0x89B285C Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x89B2864 Offset: 0x89AE864 VA: 0x89B2864 Slot: 26
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x89B28E0 Offset: 0x89AE8E0 VA: 0x89B28E0
	protected void .ctor() { }
}

// Namespace: 
protected class PointerInputModule.ButtonState // TypeDefIndex: 23118
{
	// Fields
	private PointerEventData.InputButton m_Button; // 0x10
	private PointerInputModule.MouseButtonEventData m_EventData; // 0x18

	// Properties
	public PointerInputModule.MouseButtonEventData eventData { get; set; }
	public PointerEventData.InputButton button { get; set; }

	// Methods

	// RVA: 0x89B3D38 Offset: 0x89AFD38 VA: 0x89B3D38
	public PointerInputModule.MouseButtonEventData get_eventData() { }

	// RVA: 0x89B3D40 Offset: 0x89AFD40 VA: 0x89B3D40
	public void set_eventData(PointerInputModule.MouseButtonEventData value) { }

	// RVA: 0x89B3D48 Offset: 0x89AFD48 VA: 0x89B3D48
	public PointerEventData.InputButton get_button() { }

	// RVA: 0x89B3D50 Offset: 0x89AFD50 VA: 0x89B3D50
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x89B3D58 Offset: 0x89AFD58 VA: 0x89B3D58
	public void .ctor() { }
}

// Namespace: 
protected class PointerInputModule.MouseState // TypeDefIndex: 23119
{
	// Fields
	private List<PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x89B3D60 Offset: 0x89AFD60 VA: 0x89B3D60
	public bool AnyPressesThisFrame() { }

	// RVA: 0x89B3E2C Offset: 0x89AFE2C VA: 0x89B3E2C
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x89B3F00 Offset: 0x89AFF00 VA: 0x89B3F00
	public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button) { }

	// RVA: 0x89B32AC Offset: 0x89AF2AC VA: 0x89B32AC
	public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x89B3CB0 Offset: 0x89AFCB0 VA: 0x89B3CB0
	public void .ctor() { }
}

// Namespace: 
public class PointerInputModule.MouseButtonEventData // TypeDefIndex: 23120
{
	// Fields
	public PointerEventData.FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x89B3E1C Offset: 0x89AFE1C VA: 0x89B3E1C
	public bool PressedThisFrame() { }

	// RVA: 0x89B3EEC Offset: 0x89AFEEC VA: 0x89B3EEC
	public bool ReleasedThisFrame() { }

	// RVA: 0x89B40A8 Offset: 0x89B00A8 VA: 0x89B40A8
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 23121
{
	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x58
	private readonly PointerInputModule.MouseState m_MouseState; // 0x60

	// Methods

	// RVA: 0x89B2970 Offset: 0x89AE970 VA: 0x89B2970
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x89B2A68 Offset: 0x89AEA68 VA: 0x89B2A68
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x89B2AC4 Offset: 0x89AEAC4 VA: 0x89B2AC4
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x89B2E54 Offset: 0x89AEE54 VA: 0x89B2E54
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x89B2EF4 Offset: 0x89AEEF4 VA: 0x89B2EF4
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x89B2F70 Offset: 0x89AEF70 VA: 0x89B2F70 Slot: 27
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x89B2F84 Offset: 0x89AEF84 VA: 0x89B2F84 Slot: 28
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x89B32E8 Offset: 0x89AF2E8 VA: 0x89B32E8
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x89B3308 Offset: 0x89AF308 VA: 0x89B3308
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x89B3338 Offset: 0x89AF338 VA: 0x89B3338 Slot: 29
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x89B337C Offset: 0x89AF37C VA: 0x89B337C Slot: 30
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x89B3648 Offset: 0x89AF648 VA: 0x89B3648 Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x89B36E4 Offset: 0x89AF6E4 VA: 0x89B36E4
	protected void ClearSelection() { }

	// RVA: 0x89B38A4 Offset: 0x89AF8A4 VA: 0x89B38A4 Slot: 3
	public override string ToString() { }

	// RVA: 0x89B3B0C Offset: 0x89AFB0C VA: 0x89B3B0C
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x89B3BF8 Offset: 0x89AFBF8 VA: 0x89B3BF8
	protected void .ctor() { }
}

// Namespace: 
[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
public enum StandaloneInputModule.InputMode // TypeDefIndex: 23122
{
	// Fields
	public int value__; // 0x0
	public const StandaloneInputModule.InputMode Mouse = 0;
	public const StandaloneInputModule.InputMode Buttons = 1;
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Standalone Input Module")]
public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 23123
{
	// Fields
	private float m_PrevActionTime; // 0x68
	private Vector2 m_LastMoveVector; // 0x6C
	private int m_ConsecutiveMoveCount; // 0x74
	private Vector2 m_LastMousePosition; // 0x78
	private Vector2 m_MousePosition; // 0x80
	private GameObject m_CurrentFocusedGameObject; // 0x88
	private PointerEventData m_InputPointerEvent; // 0x90
	private const float doubleClickTime = 0.3;
	[SerializeField]
	private string m_HorizontalAxis; // 0x98
	[SerializeField]
	private string m_VerticalAxis; // 0xA0
	[SerializeField]
	private string m_SubmitButton; // 0xA8
	[SerializeField]
	private string m_CancelButton; // 0xB0
	[SerializeField]
	private float m_InputActionsPerSecond; // 0xB8
	[SerializeField]
	private float m_RepeatDelay; // 0xBC
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[SerializeField]
	[HideInInspector]
	private bool m_ForceModuleActive; // 0xC0

	// Properties
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	public StandaloneInputModule.InputMode inputMode { get; }
	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnMobileDevice { get; set; }
	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x89B40B0 Offset: 0x89B00B0 VA: 0x89B40B0
	protected void .ctor() { }

	// RVA: 0x89B418C Offset: 0x89B018C VA: 0x89B418C
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x89B4194 Offset: 0x89B0194 VA: 0x89B4194
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x89B419C Offset: 0x89B019C VA: 0x89B419C
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x89B41A8 Offset: 0x89B01A8 VA: 0x89B41A8
	public bool get_forceModuleActive() { }

	// RVA: 0x89B41B0 Offset: 0x89B01B0 VA: 0x89B41B0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x89B41BC Offset: 0x89B01BC VA: 0x89B41BC
	public float get_inputActionsPerSecond() { }

	// RVA: 0x89B41C4 Offset: 0x89B01C4 VA: 0x89B41C4
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x89B41CC Offset: 0x89B01CC VA: 0x89B41CC
	public float get_repeatDelay() { }

	// RVA: 0x89B41D4 Offset: 0x89B01D4 VA: 0x89B41D4
	public void set_repeatDelay(float value) { }

	// RVA: 0x89B41DC Offset: 0x89B01DC VA: 0x89B41DC
	public string get_horizontalAxis() { }

	// RVA: 0x89B41E4 Offset: 0x89B01E4 VA: 0x89B41E4
	public void set_horizontalAxis(string value) { }

	// RVA: 0x89B41EC Offset: 0x89B01EC VA: 0x89B41EC
	public string get_verticalAxis() { }

	// RVA: 0x89B41F4 Offset: 0x89B01F4 VA: 0x89B41F4
	public void set_verticalAxis(string value) { }

	// RVA: 0x89B41FC Offset: 0x89B01FC VA: 0x89B41FC
	public string get_submitButton() { }

	// RVA: 0x89B4204 Offset: 0x89B0204 VA: 0x89B4204
	public void set_submitButton(string value) { }

	// RVA: 0x89B420C Offset: 0x89B020C VA: 0x89B420C
	public string get_cancelButton() { }

	// RVA: 0x89B4214 Offset: 0x89B0214 VA: 0x89B4214
	public void set_cancelButton(string value) { }

	// RVA: 0x89B421C Offset: 0x89B021C VA: 0x89B421C
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x89B4224 Offset: 0x89B0224 VA: 0x89B4224 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x89B4308 Offset: 0x89B0308 VA: 0x89B4308
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x89B46AC Offset: 0x89B06AC VA: 0x89B46AC Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x89B48E4 Offset: 0x89B08E4 VA: 0x89B48E4 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x89B49E4 Offset: 0x89B09E4 VA: 0x89B49E4 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x89B49E8 Offset: 0x89B09E8 VA: 0x89B49E8 Slot: 17
	public override void Process() { }

	// RVA: 0x89B4BD4 Offset: 0x89B0BD4 VA: 0x89B4BD4
	private bool ProcessTouchEvents() { }

	// RVA: 0x89B51B4 Offset: 0x89B11B4 VA: 0x89B51B4
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x89B4FA0 Offset: 0x89B0FA0 VA: 0x89B4FA0
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x89B58DC Offset: 0x89B18DC VA: 0x89B58DC
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x89B4D40 Offset: 0x89B0D40 VA: 0x89B4D40
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x89B4D38 Offset: 0x89B0D38 VA: 0x89B4D38
	protected void ProcessMouseEvent() { }

	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	// RVA: 0x89B5C98 Offset: 0x89B1C98 VA: 0x89B5C98 Slot: 31
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x89B59E8 Offset: 0x89B19E8 VA: 0x89B59E8
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x89B4A8C Offset: 0x89B0A8C VA: 0x89B4A8C
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x89B5CA0 Offset: 0x89B1CA0 VA: 0x89B5CA0
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x89B605C Offset: 0x89B205C VA: 0x89B605C
	protected GameObject GetCurrentFocusedGameObject() { }
}

// Namespace: UnityEngine.EventSystems
[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
[AddComponentMenu("Event/Touch Input Module")]
public class TouchInputModule : PointerInputModule // TypeDefIndex: 23124
{
	// Fields
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private PointerEventData m_InputPointerEvent; // 0x78
	[FormerlySerializedAs("m_AllowActivationOnStandalone")]
	[SerializeField]
	private bool m_ForceModuleActive; // 0x80

	// Properties
	[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }

	// Methods

	// RVA: 0x89B6064 Offset: 0x89B2064 VA: 0x89B6064
	protected void .ctor() { }

	// RVA: 0x89B6068 Offset: 0x89B2068 VA: 0x89B6068
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x89B6070 Offset: 0x89B2070 VA: 0x89B6070
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x89B607C Offset: 0x89B207C VA: 0x89B607C
	public bool get_forceModuleActive() { }

	// RVA: 0x89B6084 Offset: 0x89B2084 VA: 0x89B6084
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x89B6090 Offset: 0x89B2090 VA: 0x89B6090 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x89B61F8 Offset: 0x89B21F8 VA: 0x89B61F8 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x89B6230 Offset: 0x89B2230 VA: 0x89B6230 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x89B62D4 Offset: 0x89B22D4 VA: 0x89B62D4
	private bool UseFakeInput() { }

	// RVA: 0x89B6304 Offset: 0x89B2304 VA: 0x89B6304 Slot: 17
	public override void Process() { }

	// RVA: 0x89B632C Offset: 0x89B232C VA: 0x89B632C
	private void FakeTouches() { }

	// RVA: 0x89B6454 Offset: 0x89B2454 VA: 0x89B6454
	private void ProcessTouchEvents() { }

	// RVA: 0x89B659C Offset: 0x89B259C VA: 0x89B659C
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x89B6CBC Offset: 0x89B2CBC VA: 0x89B6CBC Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x89B6CC0 Offset: 0x89B2CC0 VA: 0x89B6CC0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
public enum MoveDirection // TypeDefIndex: 23125
{
	// Fields
	public int value__; // 0x0
	public const MoveDirection Left = 0;
	public const MoveDirection Up = 1;
	public const MoveDirection Right = 2;
	public const MoveDirection Down = 3;
	public const MoveDirection None = 4;
}

// Namespace: UnityEngine.EventSystems
public static class RaycasterManager // TypeDefIndex: 23126
{
	// Fields
	private static readonly List<BaseRaycaster> s_Raycasters; // 0x0

	// Methods

	// RVA: 0x89B6F08 Offset: 0x89B2F08 VA: 0x89B6F08
	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	// RVA: 0x89B702C Offset: 0x89B302C VA: 0x89B702C
	public static List<BaseRaycaster> GetRaycasters() { }

	// RVA: 0x89B7084 Offset: 0x89B3084 VA: 0x89B7084
	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

	// RVA: 0x89B7154 Offset: 0x89B3154 VA: 0x89B7154
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 23127
{
	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x20

	// Properties
	public abstract Camera eventCamera { get; }
	[Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera();

	// RVA: 0x89B71EC Offset: 0x89B31EC VA: 0x89B71EC Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x89B71F4 Offset: 0x89B31F4 VA: 0x89B71F4 Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x89B71FC Offset: 0x89B31FC VA: 0x89B71FC Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x89ADCF4 Offset: 0x89A9CF4 VA: 0x89ADCF4
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x89B7204 Offset: 0x89B3204 VA: 0x89B7204 Slot: 3
	public override string ToString() { }

	// RVA: 0x89B7450 Offset: 0x89B3450 VA: 0x89B7450 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x89B74A4 Offset: 0x89B34A4 VA: 0x89B74A4 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x89B74F8 Offset: 0x89B34F8 VA: 0x89B74F8 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x89B7508 Offset: 0x89B3508 VA: 0x89B7508 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x89ABDC8 Offset: 0x89A7DC8 VA: 0x89ABDC8
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Physics 2D Raycaster")]
[RequireComponent(typeof(Camera))]
public class Physics2DRaycaster : PhysicsRaycaster // TypeDefIndex: 23128
{
	// Fields
	private RaycastHit2D[] m_Hits; // 0x48

	// Methods

	// RVA: 0x89B7518 Offset: 0x89B3518 VA: 0x89B7518
	protected void .ctor() { }

	// RVA: 0x89B7568 Offset: 0x89B3568 VA: 0x89B7568 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

// Namespace: 
private class PhysicsRaycaster.RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 23129
{
	// Fields
	public static PhysicsRaycaster.RaycastHitComparer instance; // 0x0

	// Methods

	// RVA: 0x89B867C Offset: 0x89B467C VA: 0x89B867C Slot: 4
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x89B86BC Offset: 0x89B46BC VA: 0x89B86BC
	public void .ctor() { }

	// RVA: 0x89B86C4 Offset: 0x89B46C4 VA: 0x89B86C4
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Physics Raycaster")]
[RequireComponent(typeof(Camera))]
public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 23130
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x28
	[SerializeField]
	protected LayerMask m_EventMask; // 0x30
	[SerializeField]
	protected int m_MaxRayIntersections; // 0x34
	protected int m_LastMaxRayIntersections; // 0x38
	private RaycastHit[] m_Hits; // 0x40

	// Properties
	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }

	// Methods

	// RVA: 0x89B7540 Offset: 0x89B3540 VA: 0x89B7540
	protected void .ctor() { }

	// RVA: 0x89B8074 Offset: 0x89B4074 VA: 0x89B8074 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x89B8158 Offset: 0x89B4158 VA: 0x89B8158 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x89B7FB0 Offset: 0x89B3FB0 VA: 0x89B7FB0
	public int get_finalEventMask() { }

	// RVA: 0x89B821C Offset: 0x89B421C VA: 0x89B821C
	public LayerMask get_eventMask() { }

	// RVA: 0x89B8224 Offset: 0x89B4224 VA: 0x89B8224
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x89B822C Offset: 0x89B422C VA: 0x89B822C
	public int get_maxRayIntersections() { }

	// RVA: 0x89B8234 Offset: 0x89B4234 VA: 0x89B8234
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x89B7CB4 Offset: 0x89B3CB4 VA: 0x89B7CB4
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	// RVA: 0x89B823C Offset: 0x89B423C VA: 0x89B823C Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

// Namespace: UnityEngine.EventSystems
public struct RaycastResult // TypeDefIndex: 23131
{
	// Fields
	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingGroupID; // 0x1C
	public int sortingGroupOrder; // 0x20
	public int sortingLayer; // 0x24
	public int sortingOrder; // 0x28
	public Vector3 worldPosition; // 0x2C
	public Vector3 worldNormal; // 0x38
	public Vector2 screenPosition; // 0x44
	public int displayIndex; // 0x4C

	// Properties
	public GameObject gameObject { get; set; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x89B872C Offset: 0x89B472C VA: 0x89B872C
	public GameObject get_gameObject() { }

	// RVA: 0x89B8734 Offset: 0x89B4734 VA: 0x89B8734
	public void set_gameObject(GameObject value) { }

	// RVA: 0x89B873C Offset: 0x89B473C VA: 0x89B873C
	public bool get_isValid() { }

	// RVA: 0x89B87D4 Offset: 0x89B47D4 VA: 0x89B87D4
	public void Clear() { }

	// RVA: 0x89ACE84 Offset: 0x89A8E84 VA: 0x89ACE84 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 23132
{
	// Methods

	// RVA: 0x89B8898 Offset: 0x89B4898 VA: 0x89B8898 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x89A9000 Offset: 0x89A5000 VA: 0x89A9000 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x89AE994 Offset: 0x89AA994 VA: 0x89AE994 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x89A9008 Offset: 0x89A5008 VA: 0x89A9008 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0x89B889C Offset: 0x89B489C VA: 0x89B889C Slot: 8
	protected virtual void OnDestroy() { }

	// RVA: 0x89B88A0 Offset: 0x89B48A0 VA: 0x89B88A0 Slot: 9
	public virtual bool IsActive() { }

	// RVA: 0x89B88A8 Offset: 0x89B48A8 VA: 0x89B88A8 Slot: 10
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x89B88AC Offset: 0x89B48AC VA: 0x89B88AC Slot: 11
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x89B7514 Offset: 0x89B3514 VA: 0x89B7514 Slot: 12
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x89B88B0 Offset: 0x89B48B0 VA: 0x89B88B0 Slot: 13
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x89B88B4 Offset: 0x89B48B4 VA: 0x89B88B4 Slot: 14
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x89B7504 Offset: 0x89B3504 VA: 0x89B7504 Slot: 15
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x89B88B8 Offset: 0x89B48B8 VA: 0x89B88B8 Slot: 16
	public bool IsDestroyed() { }

	// RVA: 0x89AB3C8 Offset: 0x89A73C8 VA: 0x89AB3C8
	protected void .ctor() { }
}

// Namespace: UnityEditor.Rendering.BuiltIn.ShaderGraph
internal static class MaterialAccess // TypeDefIndex: 23133
{
	// Methods

	// RVA: 0x89B8914 Offset: 0x89B4914 VA: 0x89B8914
	internal static int ReadMaterialRawRenderQueue(Material mat) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 23134
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5588 // TypeDefIndex: 23135
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7295 // TypeDefIndex: 23136
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 23137
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB /*Metadata offset 0xF1EDF0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5588 DA5B5A7108F89F2E49C96817FA8E4BFE7B5B5AC47EC2BD1C7222303523A2E087 /*Metadata offset 0xF1EE00*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7295 EB28482BCE14BB6624DE710F32BFEB5D64857CB241CBC6C56292DABC8712CE0A /*Metadata offset 0xF203D8*/; // 0x15E0
}

