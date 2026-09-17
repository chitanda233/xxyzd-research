// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 21699
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 21700
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 21701
{
	// Methods

	// RVA: 0x864A924 Offset: 0x8646924 VA: 0x864A924
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x864AA1C Offset: 0x8646A1C VA: 0x864AA1C
	public void .ctor() { }
}

// Namespace: TMPro
public class FastAction // TypeDefIndex: 21702
{
	// Fields
	private LinkedList<Action> delegates; // 0x10
	private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18

	// Methods

	// RVA: 0x864AA24 Offset: 0x8646A24 VA: 0x864AA24
	public void Add(Action rhs) { }

	// RVA: 0x864AAE4 Offset: 0x8646AE4 VA: 0x864AAE4
	public void Remove(Action rhs) { }

	// RVA: 0x864ABA4 Offset: 0x8646BA4 VA: 0x864ABA4
	public void Call() { }

	// RVA: 0x864AC3C Offset: 0x8646C3C VA: 0x864AC3C
	public void .ctor() { }
}

// Namespace: TMPro
public class FastAction<A> // TypeDefIndex: 21703
{
	// Fields
	private LinkedList<Action<A>> delegates; // 0x0
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633A59C Offset: 0x633659C VA: 0x633A59C
	|-FastAction<bool>.Add
	|
	|-RVA: 0x633A7C4 Offset: 0x63367C4 VA: 0x633A7C4
	|-FastAction<object>.Add
	|
	|-RVA: 0x633A9EC Offset: 0x63369EC VA: 0x633A9EC
	|-FastAction<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633A624 Offset: 0x6336624 VA: 0x633A624
	|-FastAction<bool>.Remove
	|
	|-RVA: 0x633A84C Offset: 0x633684C VA: 0x633A84C
	|-FastAction<object>.Remove
	|
	|-RVA: 0x633AAA8 Offset: 0x6336AA8 VA: 0x633AAA8
	|-FastAction<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633A6AC Offset: 0x63366AC VA: 0x633A6AC
	|-FastAction<bool>.Call
	|
	|-RVA: 0x633A8D4 Offset: 0x63368D4 VA: 0x633A8D4
	|-FastAction<object>.Call
	|
	|-RVA: 0x633AB5C Offset: 0x6336B5C VA: 0x633AB5C
	|-FastAction<__Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633A714 Offset: 0x6336714 VA: 0x633A714
	|-FastAction<bool>..ctor
	|
	|-RVA: 0x633A93C Offset: 0x633693C VA: 0x633A93C
	|-FastAction<object>..ctor
	|
	|-RVA: 0x633ACB4 Offset: 0x6336CB4 VA: 0x633ACB4
	|-FastAction<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: TMPro
public class FastAction<A, B> // TypeDefIndex: 21704
{
	// Fields
	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633AD6C Offset: 0x6336D6C VA: 0x633AD6C
	|-FastAction<bool, object>.Add
	|
	|-RVA: 0x633AFA4 Offset: 0x6336FA4 VA: 0x633AFA4
	|-FastAction<object, object>.Add
	|
	|-RVA: 0x633B1DC Offset: 0x63371DC VA: 0x633B1DC
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633ADF4 Offset: 0x6336DF4 VA: 0x633ADF4
	|-FastAction<bool, object>.Remove
	|
	|-RVA: 0x633B02C Offset: 0x633702C VA: 0x633B02C
	|-FastAction<object, object>.Remove
	|
	|-RVA: 0x633B298 Offset: 0x6337298 VA: 0x633B298
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633AE7C Offset: 0x6336E7C VA: 0x633AE7C
	|-FastAction<bool, object>.Call
	|
	|-RVA: 0x633B0B4 Offset: 0x63370B4 VA: 0x633B0B4
	|-FastAction<object, object>.Call
	|
	|-RVA: 0x633B34C Offset: 0x633734C VA: 0x633B34C
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633AEF4 Offset: 0x6336EF4 VA: 0x633AEF4
	|-FastAction<bool, object>..ctor
	|
	|-RVA: 0x633B12C Offset: 0x633712C VA: 0x633B12C
	|-FastAction<object, object>..ctor
	|
	|-RVA: 0x633B500 Offset: 0x6337500 VA: 0x633B500
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: TMPro
public class FastAction<A, B, C> // TypeDefIndex: 21705
{
	// Fields
	private LinkedList<Action<A, B, C>> delegates; // 0x0
	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633B5B8 Offset: 0x63375B8 VA: 0x633B5B8
	|-FastAction<object, object, object>.Add
	|
	|-RVA: 0x633B7F8 Offset: 0x63377F8 VA: 0x633B7F8
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633B640 Offset: 0x6337640 VA: 0x633B640
	|-FastAction<object, object, object>.Remove
	|
	|-RVA: 0x633B8B4 Offset: 0x63378B4 VA: 0x633B8B4
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b, C c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633B6C8 Offset: 0x63376C8 VA: 0x633B6C8
	|-FastAction<object, object, object>.Call
	|
	|-RVA: 0x633B968 Offset: 0x6337968 VA: 0x633B968
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633B748 Offset: 0x6337748 VA: 0x633B748
	|-FastAction<object, object, object>..ctor
	|
	|-RVA: 0x633BB80 Offset: 0x6337B80 VA: 0x633BB80
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: TMPro
public interface ITextPreprocessor // TypeDefIndex: 21706
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string PreprocessText(string text);
}

// Namespace: TMPro
public class MaterialReferenceManager // TypeDefIndex: 21707
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x864AD18 Offset: 0x8646D18 VA: 0x864AD18
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x864AF20 Offset: 0x8646F20 VA: 0x864AF20
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x864AF40 Offset: 0x8646F40 VA: 0x864AF40
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	// RVA: 0x864B004 Offset: 0x8647004 VA: 0x864B004
	public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x864B024 Offset: 0x8647024 VA: 0x864B024
	private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x864B0E8 Offset: 0x86470E8 VA: 0x864B0E8
	public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x864B118 Offset: 0x8647118 VA: 0x864B118
	private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x864B1EC Offset: 0x86471EC VA: 0x864B1EC
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x864B21C Offset: 0x864721C VA: 0x864B21C
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x864B284 Offset: 0x8647284 VA: 0x864B284
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x864B2B4 Offset: 0x86472B4 VA: 0x864B2B4
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x864B358 Offset: 0x8647358 VA: 0x864B358
	public bool Contains(TMP_FontAsset font) { }

	// RVA: 0x864B3B4 Offset: 0x86473B4 VA: 0x864B3B4
	public bool Contains(TMP_SpriteAsset sprite) { }

	// RVA: 0x864B410 Offset: 0x8647410 VA: 0x864B410
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x864B440 Offset: 0x8647440 VA: 0x864B440
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x864B4B8 Offset: 0x86474B8 VA: 0x864B4B8
	public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x864B4E8 Offset: 0x86474E8 VA: 0x864B4E8
	private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x864B560 Offset: 0x8647560 VA: 0x864B560
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x864B590 Offset: 0x8647590 VA: 0x864B590
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x864B608 Offset: 0x8647608 VA: 0x864B608
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x864B638 Offset: 0x8647638 VA: 0x864B638
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x864AD9C Offset: 0x8646D9C VA: 0x864AD9C
	public void .ctor() { }
}

// Namespace: TMPro
public struct TMP_MaterialReference // TypeDefIndex: 21708
{
	// Fields
	public Material material; // 0x0
	public int referenceCount; // 0x8
}

// Namespace: TMPro
public struct MaterialReference // TypeDefIndex: 21709
{
	// Fields
	public int index; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public TMP_SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isDefaultMaterial; // 0x20
	public bool isFallbackMaterial; // 0x21
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x864B6B0 Offset: 0x86476B0 VA: 0x864B6B0
	public void .ctor(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x864B76C Offset: 0x864776C VA: 0x864B76C
	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	// RVA: 0x864B868 Offset: 0x8647868 VA: 0x864B868
	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x864BA98 Offset: 0x8647A98 VA: 0x864BA98
	public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}

// Namespace: TMPro
public enum TextContainerAnchors // TypeDefIndex: 21710
{
	// Fields
	public int value__; // 0x0
	public const TextContainerAnchors TopLeft = 0;
	public const TextContainerAnchors Top = 1;
	public const TextContainerAnchors TopRight = 2;
	public const TextContainerAnchors Left = 3;
	public const TextContainerAnchors Middle = 4;
	public const TextContainerAnchors Right = 5;
	public const TextContainerAnchors BottomLeft = 6;
	public const TextContainerAnchors Bottom = 7;
	public const TextContainerAnchors BottomRight = 8;
	public const TextContainerAnchors Custom = 9;
}

// Namespace: TMPro
[RequireComponent(typeof(RectTransform))]
public class TextContainer : UIBehaviour // TypeDefIndex: 21711
{
	// Fields
	private bool m_hasChanged; // 0x20
	[SerializeField]
	private Vector2 m_pivot; // 0x24
	[SerializeField]
	private TextContainerAnchors m_anchorPosition; // 0x2C
	[SerializeField]
	private Rect m_rect; // 0x30
	private bool m_isDefaultWidth; // 0x40
	private bool m_isDefaultHeight; // 0x41
	private bool m_isAutoFitting; // 0x42
	private Vector3[] m_corners; // 0x48
	private Vector3[] m_worldCorners; // 0x50
	[SerializeField]
	private Vector4 m_margins; // 0x58
	private RectTransform m_rectTransform; // 0x68
	private static Vector2 k_defaultSize; // 0x0
	private TextMeshPro m_textMeshPro; // 0x70

	// Properties
	public bool hasChanged { get; set; }
	public Vector2 pivot { get; set; }
	public TextContainerAnchors anchorPosition { get; set; }
	public Rect rect { get; set; }
	public Vector2 size { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public bool isDefaultWidth { get; }
	public bool isDefaultHeight { get; }
	public bool isAutoFitting { get; set; }
	public Vector3[] corners { get; }
	public Vector3[] worldCorners { get; }
	public Vector4 margins { get; set; }
	public RectTransform rectTransform { get; }
	public TextMeshPro textMeshPro { get; }

	// Methods

	// RVA: 0x864BC90 Offset: 0x8647C90 VA: 0x864BC90
	public bool get_hasChanged() { }

	// RVA: 0x864BC98 Offset: 0x8647C98 VA: 0x864BC98
	public void set_hasChanged(bool value) { }

	// RVA: 0x864BCA4 Offset: 0x8647CA4 VA: 0x864BCA4
	public Vector2 get_pivot() { }

	// RVA: 0x864BCAC Offset: 0x8647CAC VA: 0x864BCAC
	public void set_pivot(Vector2 value) { }

	// RVA: 0x864BF0C Offset: 0x8647F0C VA: 0x864BF0C
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x864BF14 Offset: 0x8647F14 VA: 0x864BF14
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0x864BFC8 Offset: 0x8647FC8 VA: 0x864BFC8
	public Rect get_rect() { }

	// RVA: 0x864BFD4 Offset: 0x8647FD4 VA: 0x864BFD4
	public void set_rect(Rect value) { }

	// RVA: 0x864C01C Offset: 0x864801C VA: 0x864C01C
	public Vector2 get_size() { }

	// RVA: 0x864C024 Offset: 0x8648024 VA: 0x864C024
	public void set_size(Vector2 value) { }

	// RVA: 0x864C06C Offset: 0x864806C VA: 0x864C06C
	public float get_width() { }

	// RVA: 0x864C074 Offset: 0x8648074 VA: 0x864C074
	public void set_width(float value) { }

	// RVA: 0x864C088 Offset: 0x8648088 VA: 0x864C088
	public float get_height() { }

	// RVA: 0x864C090 Offset: 0x8648090 VA: 0x864C090
	public void set_height(float value) { }

	// RVA: 0x864C0A4 Offset: 0x86480A4 VA: 0x864C0A4
	public bool get_isDefaultWidth() { }

	// RVA: 0x864C0AC Offset: 0x86480AC VA: 0x864C0AC
	public bool get_isDefaultHeight() { }

	// RVA: 0x864C0B4 Offset: 0x86480B4 VA: 0x864C0B4
	public bool get_isAutoFitting() { }

	// RVA: 0x864C0BC Offset: 0x86480BC VA: 0x864C0BC
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x864C0C8 Offset: 0x86480C8 VA: 0x864C0C8
	public Vector3[] get_corners() { }

	// RVA: 0x864C0D0 Offset: 0x86480D0 VA: 0x864C0D0
	public Vector3[] get_worldCorners() { }

	// RVA: 0x864C0D8 Offset: 0x86480D8 VA: 0x864C0D8
	public Vector4 get_margins() { }

	// RVA: 0x864C0E4 Offset: 0x86480E4 VA: 0x864C0E4
	public void set_margins(Vector4 value) { }

	// RVA: 0x864C140 Offset: 0x8648140 VA: 0x864C140
	public RectTransform get_rectTransform() { }

	// RVA: 0x864C1E8 Offset: 0x86481E8 VA: 0x864C1E8
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x864C290 Offset: 0x8648290 VA: 0x864C290 Slot: 4
	protected override void Awake() { }

	// RVA: 0x864C358 Offset: 0x8648358 VA: 0x864C358 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x864C35C Offset: 0x864835C VA: 0x864C35C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x864BDFC Offset: 0x8647DFC VA: 0x864BDFC
	private void OnContainerChanged() { }

	// RVA: 0x864C4B4 Offset: 0x86484B4 VA: 0x864C4B4 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x864C064 Offset: 0x8648064 VA: 0x864C064
	private void SetRect(Vector2 size) { }

	// RVA: 0x864C360 Offset: 0x8648360 VA: 0x864C360
	private void UpdateCorners() { }

	// RVA: 0x864BF50 Offset: 0x8647F50 VA: 0x864BF50
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x864BD04 Offset: 0x8647D04 VA: 0x864BD04
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x864C618 Offset: 0x8648618 VA: 0x864C618
	public void .ctor() { }

	// RVA: 0x864C6A0 Offset: 0x86486A0 VA: 0x864C6A0
	private static void .cctor() { }
}

// Namespace: TMPro
[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
[ExecuteAlways]
[AddComponentMenu("Mesh/TextMeshPro - Text")]
[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 21712
{
	// Fields
	[SerializeField]
	internal int _SortingLayer; // 0x6C8
	[SerializeField]
	internal int _SortingLayerID; // 0x6CC
	[SerializeField]
	internal int _SortingOrder; // 0x6D0
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x6D8
	private bool m_currentAutoSizeMode; // 0x6E0
	[SerializeField]
	private bool m_hasFontAssetChanged; // 0x6E1
	private float m_previousLossyScaleY; // 0x6E4
	[SerializeField]
	private Renderer m_renderer; // 0x6E8
	private MeshFilter m_meshFilter; // 0x6F0
	private bool m_isFirstAllocation; // 0x6F8
	private int m_max_characters; // 0x6FC
	private int m_max_numberOfLines; // 0x700
	private TMP_SubMesh[] m_subTextObjects; // 0x708
	[SerializeField]
	private MaskingTypes m_maskType; // 0x710
	private Matrix4x4 m_EnvMapMatrix; // 0x714
	private Vector3[] m_RectTransformCorners; // 0x758
	private bool m_isRegisteredForEvents; // 0x760
	private static ProfilerMarker k_GenerateTextMarker; // 0x0
	private static ProfilerMarker k_SetArraySizesMarker; // 0x8
	private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
	private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
	private static ProfilerMarker k_CharacterLookupMarker; // 0x20
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
	private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
	private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
	private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
	private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
	private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
	private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
	private static ProfilerMarker k_SavePageInfoMarker; // 0x80
	private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x88
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x90
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0x98

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x864C6F0 Offset: 0x86486F0 VA: 0x864C6F0
	public int get_sortingLayerID() { }

	// RVA: 0x864C824 Offset: 0x8648824 VA: 0x864C824
	public void set_sortingLayerID(int value) { }

	// RVA: 0x864C9E4 Offset: 0x86489E4 VA: 0x864C9E4
	public int get_sortingOrder() { }

	// RVA: 0x864CA78 Offset: 0x8648A78 VA: 0x864CA78
	public void set_sortingOrder(int value) { }

	// RVA: 0x864CC38 Offset: 0x8648C38 VA: 0x864CC38 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x864CC40 Offset: 0x8648C40 VA: 0x864CC40 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x864CCE0 Offset: 0x8648CE0 VA: 0x864CCE0
	public TextContainer get_textContainer() { }

	// RVA: 0x864CCE8 Offset: 0x8648CE8 VA: 0x864CCE8
	public Transform get_transform() { }

	// RVA: 0x864C784 Offset: 0x8648784 VA: 0x864C784
	public Renderer get_renderer() { }

	// RVA: 0x864CD88 Offset: 0x8648D88 VA: 0x864CD88 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x864CE48 Offset: 0x8648E48 VA: 0x864CE48
	public MeshFilter get_meshFilter() { }

	// RVA: 0x864CF6C Offset: 0x8648F6C VA: 0x864CF6C
	public MaskingTypes get_maskType() { }

	// RVA: 0x864CF74 Offset: 0x8648F74 VA: 0x864CF74
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x864D0C4 Offset: 0x86490C4 VA: 0x864D0C4
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x864D1AC Offset: 0x86491AC VA: 0x864D1AC
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x864D2FC Offset: 0x86492FC VA: 0x864D2FC Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x864D3AC Offset: 0x86493AC VA: 0x864D3AC Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x864D47C Offset: 0x864947C VA: 0x864D47C Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x864D48C Offset: 0x864948C VA: 0x864D48C Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x864D4D0 Offset: 0x86494D0 VA: 0x864D4D0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x864D800 Offset: 0x8649800 VA: 0x864D800 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x864D934 Offset: 0x8649934 VA: 0x864D934 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x864DA34 Offset: 0x8649A34 VA: 0x864DA34 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x864DA48 Offset: 0x8649A48 VA: 0x864DA48 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x864DAB4 Offset: 0x8649AB4 VA: 0x864DAB4 Slot: 130
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGenerated]
	// RVA: 0x864DB74 Offset: 0x8649B74 VA: 0x864DB74 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x864DC28 Offset: 0x8649C28 VA: 0x864DC28 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x864DCDC Offset: 0x8649CDC VA: 0x864DCDC Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x864DCF4 Offset: 0x8649CF4 VA: 0x864DCF4 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x864DE94 Offset: 0x8649E94 VA: 0x864DE94 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x864E064 Offset: 0x864A064 VA: 0x864E064
	public void UpdateFontAsset() { }

	// RVA: 0x864E074 Offset: 0x864A074 VA: 0x864E074 Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x864E078 Offset: 0x864A078 VA: 0x864E078 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x864E07C Offset: 0x864A07C VA: 0x864E07C Slot: 4
	protected override void Awake() { }

	// RVA: 0x864E4B0 Offset: 0x864A4B0 VA: 0x864E4B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x864E5AC Offset: 0x864A5AC VA: 0x864E5AC Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x864E658 Offset: 0x864A658 VA: 0x864E658 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x864E724 Offset: 0x864A724 VA: 0x864E724 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x864ED7C Offset: 0x864AD7C VA: 0x864ED7C
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x864CF7C Offset: 0x8648F7C VA: 0x864CF7C
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x864D10C Offset: 0x864910C VA: 0x864D10C
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x864D20C Offset: 0x864920C VA: 0x864D20C
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x864EFF0 Offset: 0x864AFF0 VA: 0x864EFF0
	private void EnableMasking() { }

	// RVA: 0x864F168 Offset: 0x864B168 VA: 0x864F168
	private void DisableMasking() { }

	// RVA: 0x864F0E8 Offset: 0x864B0E8 VA: 0x864F0E8
	private void UpdateMask() { }

	// RVA: 0x864F328 Offset: 0x864B328 VA: 0x864F328 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x864F44C Offset: 0x864B44C VA: 0x864F44C Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x864F620 Offset: 0x864B620 VA: 0x864F620 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x864F664 Offset: 0x864B664 VA: 0x864F664 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x864F814 Offset: 0x864B814 VA: 0x864F814 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x864FBB8 Offset: 0x864BBB8 VA: 0x864FBB8 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x864FD0C Offset: 0x864BD0C VA: 0x864FD0C Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x864FE44 Offset: 0x864BE44 VA: 0x864FE44 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x864F25C Offset: 0x864B25C VA: 0x864F25C
	private void CreateMaterialInstance() { }

	// RVA: 0x864FF7C Offset: 0x864BF7C VA: 0x864FF7C Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x8650070 Offset: 0x864C070 VA: 0x8650070 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x865030C Offset: 0x864C30C VA: 0x865030C
	private void SetPerspectiveCorrection() { }

	// RVA: 0x8650390 Offset: 0x864C390 VA: 0x8650390 Slot: 114
	internal override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x86521C0 Offset: 0x864E1C0 VA: 0x86521C0 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x86522B0 Offset: 0x864E2B0 VA: 0x86522B0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x86522CC Offset: 0x864E2CC VA: 0x86522CC Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x86522FC Offset: 0x864E2FC VA: 0x86522FC Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x8652450 Offset: 0x864E450 VA: 0x8652450 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x864D5B8 Offset: 0x86495B8 VA: 0x864D5B8
	private void OnPreRenderObject() { }

	// RVA: 0x863BC1C Offset: 0x8637C1C VA: 0x863BC1C Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x8652798 Offset: 0x864E798 VA: 0x8652798 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x865283C Offset: 0x864E83C VA: 0x865283C
	private void SetMeshFilters(bool state) { }

	// RVA: 0x86529FC Offset: 0x864E9FC VA: 0x86529FC Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x8652668 Offset: 0x864E668 VA: 0x8652668
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x8652B0C Offset: 0x864EB0C VA: 0x8652B0C Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x864C8D8 Offset: 0x86488D8 VA: 0x864C8D8
	internal void UpdateSubMeshSortingLayerID(int id) { }

	// RVA: 0x864CB2C Offset: 0x8648B2C VA: 0x864CB2C
	internal void UpdateSubMeshSortingOrder(int order) { }

	// RVA: 0x8652BE8 Offset: 0x864EBE8 VA: 0x8652BE8 Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x86524EC Offset: 0x864E4EC VA: 0x86524EC
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x8652DD8 Offset: 0x864EDD8 VA: 0x8652DD8
	public void .ctor() { }

	// RVA: 0x8652EB0 Offset: 0x864EEB0 VA: 0x8652EB0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TextMeshProUGUI.<DelayedGraphicRebuild>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21713
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextMeshProUGUI <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x8653894 Offset: 0x864F894 VA: 0x8653894
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x865AAF8 Offset: 0x8656AF8 VA: 0x865AAF8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x865AAFC Offset: 0x8656AFC VA: 0x865AAFC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x865ABCC Offset: 0x8656BCC VA: 0x865ABCC Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x865ABD4 Offset: 0x8656BD4 VA: 0x865ABD4 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x865AC0C Offset: 0x8656C0C VA: 0x865AC0C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TextMeshProUGUI.<DelayedMaterialRebuild>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21714
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextMeshProUGUI <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x8653928 Offset: 0x864F928 VA: 0x8653928
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x865AC14 Offset: 0x8656C14 VA: 0x865AC14 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x865AC18 Offset: 0x8656C18 VA: 0x865AC18 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x865ACF0 Offset: 0x8656CF0 VA: 0x865ACF0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x865ACF8 Offset: 0x8656CF8 VA: 0x865ACF8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x865AD30 Offset: 0x8656D30 VA: 0x865AD30 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: TMPro
[ExecuteAlways]
[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 21715
{
	// Fields
	private bool m_isRebuildingLayout; // 0x6C8
	private Coroutine m_DelayedGraphicRebuild; // 0x6D0
	private Coroutine m_DelayedMaterialRebuild; // 0x6D8
	private Rect m_ClipRect; // 0x6E0
	private bool m_ValidRect; // 0x6F0
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x6F8
	[SerializeField]
	private bool m_hasFontAssetChanged; // 0x700
	protected TMP_SubMeshUI[] m_subTextObjects; // 0x708
	private float m_previousLossyScaleY; // 0x710
	private Vector3[] m_RectTransformCorners; // 0x718
	private CanvasRenderer m_canvasRenderer; // 0x720
	private Canvas m_canvas; // 0x728
	private float m_CanvasScaleFactor; // 0x730
	private bool m_isFirstAllocation; // 0x734
	private int m_max_characters; // 0x738
	[SerializeField]
	private Material m_baseMaterial; // 0x740
	private bool m_isScrollRegionSet; // 0x748
	[SerializeField]
	private Vector4 m_maskOffset; // 0x74C
	private Matrix4x4 m_EnvMapMatrix; // 0x75C
	private bool m_isRegisteredForEvents; // 0x79C
	private static ProfilerMarker k_GenerateTextMarker; // 0x0
	private static ProfilerMarker k_SetArraySizesMarker; // 0x8
	private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
	private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
	private static ProfilerMarker k_CharacterLookupMarker; // 0x20
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
	private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
	private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
	private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
	private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
	private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
	private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
	private static ProfilerMarker k_SavePageInfoMarker; // 0x80
	private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x88
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x90
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0x98

	// Properties
	public override Material materialForRendering { get; }
	public override bool autoSizeTextContainer { get; set; }
	public override Mesh mesh { get; }
	public CanvasRenderer canvasRenderer { get; }
	public Vector4 maskOffset { get; set; }

	// Methods

	// RVA: 0x865336C Offset: 0x864F36C VA: 0x865336C Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x86533CC Offset: 0x864F3CC VA: 0x86533CC Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x86533D4 Offset: 0x864F3D4 VA: 0x86533D4 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x8653474 Offset: 0x864F474 VA: 0x8653474 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x865347C Offset: 0x864F47C VA: 0x865347C
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x865351C Offset: 0x864F51C VA: 0x865351C Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x8653520 Offset: 0x864F520 VA: 0x8653520 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x8653524 Offset: 0x864F524 VA: 0x8653524 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x8653608 Offset: 0x864F608 VA: 0x8653608 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x86536F8 Offset: 0x864F6F8 VA: 0x86536F8 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x86537E4 Offset: 0x864F7E4 VA: 0x86537E4 Slot: 26
	public override void SetAllDirty() { }

	[IteratorStateMachine(typeof(TextMeshProUGUI.<DelayedGraphicRebuild>d__18))]
	// RVA: 0x8653828 Offset: 0x864F828 VA: 0x8653828
	private IEnumerator DelayedGraphicRebuild() { }

	[IteratorStateMachine(typeof(TextMeshProUGUI.<DelayedMaterialRebuild>d__19))]
	// RVA: 0x86538BC Offset: 0x864F8BC VA: 0x86538BC
	private IEnumerator DelayedMaterialRebuild() { }

	// RVA: 0x8653950 Offset: 0x864F950 VA: 0x8653950 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x8653CBC Offset: 0x864FCBC VA: 0x8653CBC
	private void UpdateSubObjectPivot() { }

	// RVA: 0x8653D90 Offset: 0x864FD90 VA: 0x8653D90 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x8653EA0 Offset: 0x864FEA0 VA: 0x8653EA0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x8653F8C Offset: 0x864FF8C VA: 0x8653F8C
	public Vector4 get_maskOffset() { }

	// RVA: 0x8653FA0 Offset: 0x864FFA0 VA: 0x8653FA0
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0x86542E4 Offset: 0x86502E4 VA: 0x86542E4 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x86542EC Offset: 0x86502EC VA: 0x86542EC Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x8654568 Offset: 0x8650568 VA: 0x8654568 Slot: 102
	internal override void UpdateCulling() { }

	// RVA: 0x8654784 Offset: 0x8650784 VA: 0x8654784 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x8654884 Offset: 0x8650884 VA: 0x8654884 Slot: 112
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x8654950 Offset: 0x8650950 VA: 0x8654950 Slot: 113
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x86549EC Offset: 0x86509EC VA: 0x86549EC Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x8654AA4 Offset: 0x8650AA4 VA: 0x8654AA4 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x8654B9C Offset: 0x8650B9C VA: 0x8654B9C Slot: 129
	public override void ClearMesh() { }

	[CompilerGenerated]
	// RVA: 0x8654C8C Offset: 0x8650C8C VA: 0x8654C8C Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x8654D40 Offset: 0x8650D40 VA: 0x8654D40 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x8654DF4 Offset: 0x8650DF4 VA: 0x8654DF4 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x8654E6C Offset: 0x8650E6C VA: 0x8654E6C Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x8655050 Offset: 0x8651050 VA: 0x8655050 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x8655264 Offset: 0x8651264 VA: 0x8655264
	public void UpdateFontAsset() { }

	// RVA: 0x8655274 Offset: 0x8651274 VA: 0x8655274 Slot: 4
	protected override void Awake() { }

	// RVA: 0x865567C Offset: 0x865167C VA: 0x865567C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x865591C Offset: 0x865191C VA: 0x865591C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x8655AC0 Offset: 0x8651AC0 VA: 0x8655AC0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x8655C2C Offset: 0x8651C2C VA: 0x8655C2C Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x86557B8 Offset: 0x86517B8 VA: 0x86557B8
	private Canvas GetCanvas() { }

	// RVA: 0x86561F4 Offset: 0x86521F4 VA: 0x86561F4
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x8656468 Offset: 0x8652468 VA: 0x8656468
	private void EnableMasking() { }

	// RVA: 0x865662C Offset: 0x865262C VA: 0x865662C
	private void DisableMasking() { }

	// RVA: 0x8653FCC Offset: 0x864FFCC VA: 0x8653FCC
	private void UpdateMask() { }

	// RVA: 0x8656630 Offset: 0x8652630 VA: 0x8656630 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x8656788 Offset: 0x8652788 VA: 0x8656788 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x8656964 Offset: 0x8652964 VA: 0x8656964 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x86569A8 Offset: 0x86529A8 VA: 0x86569A8 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x8656B58 Offset: 0x8652B58 VA: 0x8656B58 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x8656F30 Offset: 0x8652F30 VA: 0x8656F30 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x8657110 Offset: 0x8653110 VA: 0x8657110 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x8657254 Offset: 0x8653254 VA: 0x8657254 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x8657398 Offset: 0x8653398 VA: 0x8657398 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x86574C4 Offset: 0x86534C4 VA: 0x86574C4 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x865778C Offset: 0x865378C VA: 0x865778C
	private void SetPerspectiveCorrection() { }

	// RVA: 0x8657810 Offset: 0x8653810 VA: 0x8657810
	private void SetMeshArrays(int size) { }

	// RVA: 0x86578BC Offset: 0x86538BC VA: 0x86578BC Slot: 114
	internal override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x8659810 Offset: 0x8655810 VA: 0x8659810 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x8659900 Offset: 0x8655900 VA: 0x8659900 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x8659938 Offset: 0x8655938 VA: 0x8659938 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x8659A68 Offset: 0x8655A68 VA: 0x8659A68 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x8659AB8 Offset: 0x8655AB8 VA: 0x8659AB8 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x8659C88 Offset: 0x8655C88 VA: 0x8659C88 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x8653A38 Offset: 0x864FA38 VA: 0x8653A38
	private void OnPreRenderCanvas() { }

	// RVA: 0x864312C Offset: 0x863F12C VA: 0x864312C Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x8659F2C Offset: 0x8655F2C VA: 0x8659F2C Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x8659FD0 Offset: 0x8655FD0 VA: 0x8659FD0 Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x865A0E0 Offset: 0x86560E0 VA: 0x865A0E0 Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x865A1BC Offset: 0x86561BC VA: 0x865A1BC Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x865A3AC Offset: 0x86563AC VA: 0x865A3AC Slot: 117
	internal override Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x8659D24 Offset: 0x8655D24 VA: 0x8659D24
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x865A56C Offset: 0x865656C VA: 0x865A56C
	public void .ctor() { }

	// RVA: 0x865A63C Offset: 0x865663C VA: 0x865A63C
	private static void .cctor() { }
}

// Namespace: TMPro
public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 21716
{
	// Fields
	public int value__; // 0x0
	public const Compute_DistanceTransform_EventTypes Processing = 0;
	public const Compute_DistanceTransform_EventTypes Completed = 1;
}

// Namespace: TMPro
public static class TMPro_EventManager // TypeDefIndex: 21717
{
	// Fields
	public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x0
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x8
	public static readonly FastAction<bool, Object> FONT_PROPERTY_EVENT; // 0x10
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
	public static readonly FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
	public static readonly FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; // 0x58

	// Methods

	// RVA: 0x865AD38 Offset: 0x8656D38 VA: 0x865AD38
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x865ADC8 Offset: 0x8656DC8 VA: 0x865ADC8
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x865AE58 Offset: 0x8656E58 VA: 0x865AE58
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x865AEE8 Offset: 0x8656EE8 VA: 0x865AEE8
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x865AF78 Offset: 0x8656F78 VA: 0x865AF78
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x865B010 Offset: 0x8657010 VA: 0x865B010
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x865B090 Offset: 0x8657090 VA: 0x865B090
	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(Object obj) { }

	// RVA: 0x865B110 Offset: 0x8657110 VA: 0x865B110
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x865B190 Offset: 0x8657190 VA: 0x865B190
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x865B1F0 Offset: 0x86571F0 VA: 0x865B1F0
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x865B250 Offset: 0x8657250 VA: 0x865B250
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x865B2E0 Offset: 0x86572E0 VA: 0x865B2E0
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x865B370 Offset: 0x8657370 VA: 0x865B370
	private static void .cctor() { }
}

// Namespace: TMPro
public class Compute_DT_EventArgs // TypeDefIndex: 21718
{
	// Fields
	public Compute_DistanceTransform_EventTypes EventType; // 0x10
	public float ProgressPercentage; // 0x14
	public Color[] Colors; // 0x18

	// Methods

	// RVA: 0x865B6AC Offset: 0x86576AC VA: 0x865B6AC
	public void .ctor(Compute_DistanceTransform_EventTypes type, float progress) { }

	// RVA: 0x865B6E4 Offset: 0x86576E4 VA: 0x865B6E4
	public void .ctor(Compute_DistanceTransform_EventTypes type, Color[] colors) { }
}

// Namespace: TMPro
[Extension]
public static class TMPro_ExtensionMethods // TypeDefIndex: 21719
{
	// Methods

	[Extension]
	// RVA: 0x865B71C Offset: 0x865771C VA: 0x865B71C
	public static int[] ToIntArray(string text) { }

	[Extension]
	// RVA: 0x865B7D0 Offset: 0x86577D0 VA: 0x865B7D0
	public static string ArrayToString(char[] chars) { }

	[Extension]
	// RVA: 0x865B8B8 Offset: 0x86578B8 VA: 0x865B8B8
	public static string IntToString(int[] unicodes) { }

	[Extension]
	// RVA: 0x865B968 Offset: 0x8657968 VA: 0x865B968
	internal static string UintToString(List<uint> unicodes) { }

	[Extension]
	// RVA: 0x865BA40 Offset: 0x8657A40 VA: 0x865BA40
	public static string IntToString(int[] unicodes, int start, int length) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470FE10 Offset: 0x470BE10 VA: 0x470FE10
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[Extension]
	// RVA: 0x865BB50 Offset: 0x8657B50 VA: 0x865BB50
	public static bool Compare(Color32 a, Color32 b) { }

	[Extension]
	// RVA: 0x865BB60 Offset: 0x8657B60 VA: 0x865BB60
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[Extension]
	// RVA: 0x865BB70 Offset: 0x8657B70 VA: 0x865BB70
	public static bool Compare(Color a, Color b) { }

	[Extension]
	// RVA: 0x865BB98 Offset: 0x8657B98 VA: 0x865BB98
	public static bool CompareRGB(Color a, Color b) { }

	[Extension]
	// RVA: 0x865BBB8 Offset: 0x8657BB8 VA: 0x865BBB8
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[Extension]
	// RVA: 0x865BC70 Offset: 0x8657C70 VA: 0x865BC70
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[Extension]
	// RVA: 0x865BD28 Offset: 0x8657D28 VA: 0x865BD28
	public static Color32 Tint(Color32 c1, float tint) { }

	[Extension]
	// RVA: 0x865BE04 Offset: 0x8657E04 VA: 0x865BE04
	public static Color MinAlpha(Color c1, Color c2) { }

	[Extension]
	// RVA: 0x865BE10 Offset: 0x8657E10 VA: 0x865BE10
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[Extension]
	// RVA: 0x865BEA4 Offset: 0x8657EA4 VA: 0x865BEA4
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }
}

// Namespace: TMPro
public static class TMP_Math // TypeDefIndex: 21720
{
	// Fields
	public const float FLOAT_MAX = 32767;
	public const float FLOAT_MIN = -32767;
	public const int INT_MAX = 2147483647;
	public const int INT_MIN = -2147483647;
	public const float FLOAT_UNSET = -32767;
	public const int INT_UNSET = -32767;
	public static Vector2 MAX_16BIT; // 0x0
	public static Vector2 MIN_16BIT; // 0x8

	// Methods

	// RVA: 0x865BF64 Offset: 0x8657F64 VA: 0x865BF64
	public static bool Approximately(float a, float b) { }

	// RVA: 0x865BF94 Offset: 0x8657F94 VA: 0x865BF94
	public static int Mod(int a, int b) { }

	// RVA: 0x865BFA8 Offset: 0x8657FA8 VA: 0x865BFA8
	private static void .cctor() { }
}

// Namespace: TMPro
public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 21721
{
	// Fields
	public int value__; // 0x0
	public const TMP_VertexDataUpdateFlags None = 0;
	public const TMP_VertexDataUpdateFlags Vertices = 1;
	public const TMP_VertexDataUpdateFlags Uv0 = 2;
	public const TMP_VertexDataUpdateFlags Uv2 = 4;
	public const TMP_VertexDataUpdateFlags Uv4 = 8;
	public const TMP_VertexDataUpdateFlags Colors32 = 16;
	public const TMP_VertexDataUpdateFlags All = 255;
}

// Namespace: TMPro
[Serializable]
public struct VertexGradient // TypeDefIndex: 21722
{
	// Fields
	public Color topLeft; // 0x0
	public Color topRight; // 0x10
	public Color bottomLeft; // 0x20
	public Color bottomRight; // 0x30

	// Methods

	// RVA: 0x865C014 Offset: 0x8658014 VA: 0x865C014
	public void .ctor(Color color) { }

	// RVA: 0x865C038 Offset: 0x8658038 VA: 0x865C038
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }
}

// Namespace: TMPro
public struct TMP_PageInfo // TypeDefIndex: 21723
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10
}

// Namespace: TMPro
public struct TMP_LinkInfo // TypeDefIndex: 21724
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20

	// Methods

	// RVA: 0x865C054 Offset: 0x8658054 VA: 0x865C054
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x865C138 Offset: 0x8658138 VA: 0x865C138
	public string GetLinkText() { }

	// RVA: 0x865C240 Offset: 0x8658240 VA: 0x865C240
	public string GetLinkID() { }
}

// Namespace: TMPro
public struct TMP_WordInfo // TypeDefIndex: 21725
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int firstCharacterIndex; // 0x8
	public int lastCharacterIndex; // 0xC
	public int characterCount; // 0x10

	// Methods

	// RVA: 0x865C2E8 Offset: 0x86582E8 VA: 0x865C2E8
	public string GetWord() { }
}

// Namespace: TMPro
public struct TMP_SpriteInfo // TypeDefIndex: 21726
{
	// Fields
	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8
}

// Namespace: TMPro
public struct Extents // TypeDefIndex: 21727
{
	// Fields
	internal static Extents zero; // 0x0
	internal static Extents uninitialized; // 0x10
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x865C3F0 Offset: 0x86583F0 VA: 0x865C3F0
	public void .ctor(Vector2 min, Vector2 max) { }

	// RVA: 0x865C3FC Offset: 0x86583FC VA: 0x865C3FC Slot: 3
	public override string ToString() { }

	// RVA: 0x865C624 Offset: 0x8658624 VA: 0x865C624
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public struct Mesh_Extents // TypeDefIndex: 21728
{
	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x865C6B8 Offset: 0x86586B8 VA: 0x865C6B8
	public void .ctor(Vector2 min, Vector2 max) { }

	// RVA: 0x865C6C4 Offset: 0x86586C4 VA: 0x865C6C4 Slot: 3
	public override string ToString() { }
}

// Namespace: TMPro
public struct WordWrapState // TypeDefIndex: 21729
{
	// Fields
	public int previous_WordBreak; // 0x0
	public int total_CharacterCount; // 0x4
	public int visible_CharacterCount; // 0x8
	public int visible_SpriteCount; // 0xC
	public int visible_LinkCount; // 0x10
	public int firstCharacterIndex; // 0x14
	public int firstVisibleCharacterIndex; // 0x18
	public int lastCharacterIndex; // 0x1C
	public int lastVisibleCharIndex; // 0x20
	public int lineNumber; // 0x24
	public float maxCapHeight; // 0x28
	public float maxAscender; // 0x2C
	public float maxDescender; // 0x30
	public float startOfLineAscender; // 0x34
	public float maxLineAscender; // 0x38
	public float maxLineDescender; // 0x3C
	public float pageAscender; // 0x40
	public HorizontalAlignmentOptions horizontalAlignment; // 0x44
	public float marginLeft; // 0x48
	public float marginRight; // 0x4C
	public float xAdvance; // 0x50
	public float preferredWidth; // 0x54
	public float preferredHeight; // 0x58
	public float previousLineScale; // 0x5C
	public int wordCount; // 0x60
	public FontStyles fontStyle; // 0x64
	public int italicAngle; // 0x68
	public float fontScaleMultiplier; // 0x6C
	public float currentFontSize; // 0x70
	public float baselineOffset; // 0x74
	public float lineOffset; // 0x78
	public bool isDrivenLineSpacing; // 0x7C
	public float glyphHorizontalAdvanceAdjustment; // 0x80
	public float cSpace; // 0x84
	public float mSpace; // 0x88
	public TMP_TextInfo textInfo; // 0x90
	public TMP_LineInfo lineInfo; // 0x98
	public Color32 vertexColor; // 0xF4
	public Color32 underlineColor; // 0xF8
	public Color32 strikethroughColor; // 0xFC
	public Color32 highlightColor; // 0x100
	public TMP_FontStyleStack basicStyleStack; // 0x104
	public TMP_TextProcessingStack<int> italicAngleStack; // 0x110
	public TMP_TextProcessingStack<Color32> colorStack; // 0x130
	public TMP_TextProcessingStack<Color32> underlineColorStack; // 0x150
	public TMP_TextProcessingStack<Color32> strikethroughColorStack; // 0x170
	public TMP_TextProcessingStack<Color32> highlightColorStack; // 0x190
	public TMP_TextProcessingStack<HighlightState> highlightStateStack; // 0x1B0
	public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack; // 0x1E0
	public TMP_TextProcessingStack<float> sizeStack; // 0x208
	public TMP_TextProcessingStack<float> indentStack; // 0x228
	public TMP_TextProcessingStack<FontWeight> fontWeightStack; // 0x248
	public TMP_TextProcessingStack<int> styleStack; // 0x268
	public TMP_TextProcessingStack<float> baselineStack; // 0x288
	public TMP_TextProcessingStack<int> actionStack; // 0x2A8
	public TMP_TextProcessingStack<MaterialReference> materialReferenceStack; // 0x2C8
	public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack; // 0x320
	public int spriteAnimationID; // 0x340
	public TMP_FontAsset currentFontAsset; // 0x348
	public TMP_SpriteAsset currentSpriteAsset; // 0x350
	public Material currentMaterial; // 0x358
	public int currentMaterialIndex; // 0x360
	public Extents meshExtents; // 0x364
	public bool tagNoParsing; // 0x374
	public bool isNonBreakingSpace; // 0x375
}

// Namespace: TMPro
public struct TagAttribute // TypeDefIndex: 21730
{
	// Fields
	public int startIndex; // 0x0
	public int length; // 0x4
	public int hashCode; // 0x8
}

// Namespace: TMPro
public struct RichTextTagAttribute // TypeDefIndex: 21731
{
	// Fields
	public int nameHashCode; // 0x0
	public int valueHashCode; // 0x4
	public TagValueType valueType; // 0x8
	public int valueStartIndex; // 0xC
	public int valueLength; // 0x10
	public TagUnitType unitType; // 0x14
}

// Namespace: TMPro
[Serializable]
public abstract class TMP_Asset : ScriptableObject // TypeDefIndex: 21732
{
	// Fields
	private int m_InstanceID; // 0x18
	public int hashCode; // 0x1C
	public Material material; // 0x20
	public int materialHashCode; // 0x28

	// Properties
	public int instanceID { get; }

	// Methods

	// RVA: 0x865C8EC Offset: 0x86588EC VA: 0x865C8EC
	public int get_instanceID() { }

	// RVA: 0x865C914 Offset: 0x8658914 VA: 0x865C914
	protected void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Character : TMP_TextElement // TypeDefIndex: 21733
{
	// Methods

	// RVA: 0x865C91C Offset: 0x865891C VA: 0x865C91C
	public void .ctor() { }

	// RVA: 0x865C944 Offset: 0x8658944 VA: 0x865C944
	public void .ctor(uint unicode, Glyph glyph) { }

	// RVA: 0x865C9B4 Offset: 0x86589B4 VA: 0x865C9B4
	public void .ctor(uint unicode, TMP_FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x865CA30 Offset: 0x8658A30 VA: 0x865CA30
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
public struct TMP_Vertex // TypeDefIndex: 21734
{
	// Fields
	public Vector3 position; // 0x0
	public Vector2 uv; // 0xC
	public Vector2 uv2; // 0x14
	public Vector2 uv4; // 0x1C
	public Color32 color; // 0x24
	private static readonly TMP_Vertex k_Zero; // 0x0

	// Properties
	public static TMP_Vertex zero { get; }

	// Methods

	// RVA: 0x865CA8C Offset: 0x8658A8C VA: 0x865CA8C
	public static TMP_Vertex get_zero() { }

	// RVA: 0x865CAF4 Offset: 0x8658AF4 VA: 0x865CAF4
	private static void .cctor() { }
}

// Namespace: TMPro
public struct TMP_Offset // TypeDefIndex: 21735
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly TMP_Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; set; }
	public float right { get; set; }
	public float top { get; set; }
	public float bottom { get; set; }
	public float horizontal { get; set; }
	public float vertical { get; set; }
	public static TMP_Offset zero { get; }

	// Methods

	// RVA: 0x865CAF8 Offset: 0x8658AF8 VA: 0x865CAF8
	public float get_left() { }

	// RVA: 0x865CB00 Offset: 0x8658B00 VA: 0x865CB00
	public void set_left(float value) { }

	// RVA: 0x865CB08 Offset: 0x8658B08 VA: 0x865CB08
	public float get_right() { }

	// RVA: 0x865CB10 Offset: 0x8658B10 VA: 0x865CB10
	public void set_right(float value) { }

	// RVA: 0x865CB18 Offset: 0x8658B18 VA: 0x865CB18
	public float get_top() { }

	// RVA: 0x865CB20 Offset: 0x8658B20 VA: 0x865CB20
	public void set_top(float value) { }

	// RVA: 0x865CB28 Offset: 0x8658B28 VA: 0x865CB28
	public float get_bottom() { }

	// RVA: 0x865CB30 Offset: 0x8658B30 VA: 0x865CB30
	public void set_bottom(float value) { }

	// RVA: 0x865CB38 Offset: 0x8658B38 VA: 0x865CB38
	public float get_horizontal() { }

	// RVA: 0x865CB40 Offset: 0x8658B40 VA: 0x865CB40
	public void set_horizontal(float value) { }

	// RVA: 0x865CB48 Offset: 0x8658B48 VA: 0x865CB48
	public float get_vertical() { }

	// RVA: 0x865CB50 Offset: 0x8658B50 VA: 0x865CB50
	public void set_vertical(float value) { }

	// RVA: 0x865CB58 Offset: 0x8658B58 VA: 0x865CB58
	public static TMP_Offset get_zero() { }

	// RVA: 0x865CBB4 Offset: 0x8658BB4 VA: 0x865CBB4
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x865CBC0 Offset: 0x8658BC0 VA: 0x865CBC0
	public void .ctor(float horizontal, float vertical) { }

	// RVA: 0x865CBCC Offset: 0x8658BCC VA: 0x865CBCC
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x865CBF4 Offset: 0x8658BF4 VA: 0x865CBF4
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x865CCA4 Offset: 0x8658CA4 VA: 0x865CCA4
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	// RVA: 0x865CCB8 Offset: 0x8658CB8 VA: 0x865CCB8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x865CD1C Offset: 0x8658D1C VA: 0x865CD1C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x865CD94 Offset: 0x8658D94 VA: 0x865CD94
	public bool Equals(TMP_Offset other) { }

	// RVA: 0x865CE3C Offset: 0x8658E3C VA: 0x865CE3C
	private static void .cctor() { }
}

// Namespace: TMPro
public struct HighlightState // TypeDefIndex: 21736
{
	// Fields
	public Color32 color; // 0x0
	public TMP_Offset padding; // 0x4

	// Methods

	// RVA: 0x865CE84 Offset: 0x8658E84 VA: 0x865CE84
	public void .ctor(Color32 color, TMP_Offset padding) { }

	// RVA: 0x865CE94 Offset: 0x8658E94 VA: 0x865CE94
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x865CF60 Offset: 0x8658F60 VA: 0x865CF60
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x865CFA8 Offset: 0x8658FA8 VA: 0x865CFA8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x865D014 Offset: 0x8659014 VA: 0x865D014 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x865D094 Offset: 0x8659094 VA: 0x865D094
	public bool Equals(HighlightState other) { }
}

// Namespace: TMPro
[DebuggerDisplay("Unicode '{character}'  ({((uint)character).ToString("X")})")]
public struct TMP_CharacterInfo // TypeDefIndex: 21737
{
	// Fields
	public char character; // 0x0
	public int index; // 0x4
	public int stringLength; // 0x8
	public TMP_TextElementType elementType; // 0xC
	public TMP_TextElement textElement; // 0x10
	public TMP_FontAsset fontAsset; // 0x18
	public TMP_SpriteAsset spriteAsset; // 0x20
	public int spriteIndex; // 0x28
	public Material material; // 0x30
	public int materialReferenceIndex; // 0x38
	public bool isUsingAlternateTypeface; // 0x3C
	public float pointSize; // 0x40
	public int lineNumber; // 0x44
	public int pageNumber; // 0x48
	public int vertexIndex; // 0x4C
	public TMP_Vertex vertex_BL; // 0x50
	public TMP_Vertex vertex_TL; // 0x78
	public TMP_Vertex vertex_TR; // 0xA0
	public TMP_Vertex vertex_BR; // 0xC8
	public Vector3 topLeft; // 0xF0
	public Vector3 bottomLeft; // 0xFC
	public Vector3 topRight; // 0x108
	public Vector3 bottomRight; // 0x114
	public float origin; // 0x120
	public float xAdvance; // 0x124
	public float ascender; // 0x128
	public float baseLine; // 0x12C
	public float descender; // 0x130
	internal float adjustedAscender; // 0x134
	internal float adjustedDescender; // 0x138
	public float aspectRatio; // 0x13C
	public float scale; // 0x140
	public Color32 color; // 0x144
	public Color32 underlineColor; // 0x148
	public int underlineVertexIndex; // 0x14C
	public Color32 strikethroughColor; // 0x150
	public int strikethroughVertexIndex; // 0x154
	public Color32 highlightColor; // 0x158
	public HighlightState highlightState; // 0x15C
	public FontStyles style; // 0x170
	public bool isVisible; // 0x174
}

// Namespace: TMPro
public enum ColorMode // TypeDefIndex: 21738
{
	// Fields
	public int value__; // 0x0
	public const ColorMode Single = 0;
	public const ColorMode HorizontalGradient = 1;
	public const ColorMode VerticalGradient = 2;
	public const ColorMode FourCornersGradient = 3;
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 21739
{
	// Fields
	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x865D138 Offset: 0x8659138 VA: 0x865D138
	public void .ctor() { }

	// RVA: 0x865D1D4 Offset: 0x86591D4 VA: 0x865D1D4
	public void .ctor(Color color) { }

	// RVA: 0x865D240 Offset: 0x8659240 VA: 0x865D240
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x865D2E4 Offset: 0x86592E4 VA: 0x865D2E4
	private static void .cctor() { }
}

// Namespace: 
public enum TMP_Compatibility.AnchorPositions // TypeDefIndex: 21740
{
	// Fields
	public int value__; // 0x0
	public const TMP_Compatibility.AnchorPositions TopLeft = 0;
	public const TMP_Compatibility.AnchorPositions Top = 1;
	public const TMP_Compatibility.AnchorPositions TopRight = 2;
	public const TMP_Compatibility.AnchorPositions Left = 3;
	public const TMP_Compatibility.AnchorPositions Center = 4;
	public const TMP_Compatibility.AnchorPositions Right = 5;
	public const TMP_Compatibility.AnchorPositions BottomLeft = 6;
	public const TMP_Compatibility.AnchorPositions Bottom = 7;
	public const TMP_Compatibility.AnchorPositions BottomRight = 8;
	public const TMP_Compatibility.AnchorPositions BaseLine = 9;
	public const TMP_Compatibility.AnchorPositions None = 10;
}

// Namespace: TMPro
public static class TMP_Compatibility // TypeDefIndex: 21741
{
	// Methods

	// RVA: 0x865D330 Offset: 0x8659330 VA: 0x865D330
	public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue) { }
}

// Namespace: TMPro
internal interface ITweenValue // TypeDefIndex: 21742
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
public enum ColorTween.ColorTweenMode // TypeDefIndex: 21743
{
	// Fields
	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;
}

// Namespace: 
public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 21744
{
	// Methods

	// RVA: 0x865D538 Offset: 0x8659538 VA: 0x865D538
	public void .ctor() { }
}

// Namespace: TMPro
internal struct ColorTween : ITweenValue // TypeDefIndex: 21745
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

	// RVA: 0x865D354 Offset: 0x8659354 VA: 0x865D354
	public Color get_startColor() { }

	// RVA: 0x865D360 Offset: 0x8659360 VA: 0x865D360
	public void set_startColor(Color value) { }

	// RVA: 0x865D36C Offset: 0x865936C VA: 0x865D36C
	public Color get_targetColor() { }

	// RVA: 0x865D378 Offset: 0x8659378 VA: 0x865D378
	public void set_targetColor(Color value) { }

	// RVA: 0x865D384 Offset: 0x8659384 VA: 0x865D384
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x865D38C Offset: 0x865938C VA: 0x865D38C
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x865D394 Offset: 0x8659394 VA: 0x865D394 Slot: 6
	public float get_duration() { }

	// RVA: 0x865D39C Offset: 0x865939C VA: 0x865D39C
	public void set_duration(float value) { }

	// RVA: 0x865D3A4 Offset: 0x86593A4 VA: 0x865D3A4 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x865D3AC Offset: 0x86593AC VA: 0x865D3AC
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x865D3B8 Offset: 0x86593B8 VA: 0x865D3B8 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x865D4A4 Offset: 0x86594A4 VA: 0x865D4A4
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x865D580 Offset: 0x8659580 VA: 0x865D580
	public bool GetIgnoreTimescale() { }

	// RVA: 0x865D588 Offset: 0x8659588 VA: 0x865D588
	public float GetDuration() { }

	// RVA: 0x865D494 Offset: 0x8659494 VA: 0x865D494 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 21746
{
	// Methods

	// RVA: 0x865D704 Offset: 0x8659704 VA: 0x865D704
	public void .ctor() { }
}

// Namespace: TMPro
internal struct FloatTween : ITweenValue // TypeDefIndex: 21747
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

	// RVA: 0x865D590 Offset: 0x8659590 VA: 0x865D590
	public float get_startValue() { }

	// RVA: 0x865D598 Offset: 0x8659598 VA: 0x865D598
	public void set_startValue(float value) { }

	// RVA: 0x865D5A0 Offset: 0x86595A0 VA: 0x865D5A0
	public float get_targetValue() { }

	// RVA: 0x865D5A8 Offset: 0x86595A8 VA: 0x865D5A8
	public void set_targetValue(float value) { }

	// RVA: 0x865D5B0 Offset: 0x86595B0 VA: 0x865D5B0 Slot: 6
	public float get_duration() { }

	// RVA: 0x865D5B8 Offset: 0x86595B8 VA: 0x865D5B8
	public void set_duration(float value) { }

	// RVA: 0x865D5C0 Offset: 0x86595C0 VA: 0x865D5C0 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x865D5C8 Offset: 0x86595C8 VA: 0x865D5C8
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x865D5D4 Offset: 0x86595D4 VA: 0x865D5D4 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x865D670 Offset: 0x8659670 VA: 0x865D670
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x865D74C Offset: 0x865974C VA: 0x865D74C
	public bool GetIgnoreTimescale() { }

	// RVA: 0x865D754 Offset: 0x8659754 VA: 0x865D754
	public float GetDuration() { }

	// RVA: 0x865D660 Offset: 0x8659660 VA: 0x865D660 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TweenRunner.<Start>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21748
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
	|-RVA: 0x5E49880 Offset: 0x5E45880 VA: 0x5E49880
	|-TweenRunner.<Start>d__2<FloatTween>..ctor
	|
	|-RVA: 0x5E49B70 Offset: 0x5E45B70 VA: 0x5E49B70
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E498A8 Offset: 0x5E458A8 VA: 0x5E498A8
	|-TweenRunner.<Start>d__2<FloatTween>.System.IDisposable.Dispose
	|
	|-RVA: 0x5E49BB0 Offset: 0x5E45BB0 VA: 0x5E49BB0
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E498AC Offset: 0x5E458AC VA: 0x5E498AC
	|-TweenRunner.<Start>d__2<FloatTween>.MoveNext
	|
	|-RVA: 0x5E49BB4 Offset: 0x5E45BB4 VA: 0x5E49BB4
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E499B4 Offset: 0x5E459B4 VA: 0x5E499B4
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0x5E4A1C4 Offset: 0x5E461C4 VA: 0x5E4A1C4
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E499BC Offset: 0x5E459BC VA: 0x5E499BC
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5E4A1EC Offset: 0x5E461EC VA: 0x5E4A1EC
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E499F0 Offset: 0x5E459F0 VA: 0x5E499F0
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5E4A220 Offset: 0x5E46220 VA: 0x5E4A220
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: TMPro
internal class TweenRunner<T> // TypeDefIndex: 21749
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
	|-RVA: 0x5666818 Offset: 0x5662818 VA: 0x5666818
	|-TweenRunner<FloatTween>.Start
	|
	|-RVA: 0x5666A98 Offset: 0x5662A98 VA: 0x5666A98
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Start
	*/

	// RVA: -1 Offset: -1
	public void Init(MonoBehaviour coroutineContainer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56668D4 Offset: 0x56628D4 VA: 0x56668D4
	|-TweenRunner<FloatTween>.Init
	|
	|-RVA: 0x5666C18 Offset: 0x5662C18 VA: 0x5666C18
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Init
	*/

	// RVA: -1 Offset: -1
	public void StartTween(T info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56668DC Offset: 0x56628DC VA: 0x56668DC
	|-TweenRunner<FloatTween>.StartTween
	|
	|-RVA: 0x5666C20 Offset: 0x5662C20 VA: 0x5666C20
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StartTween
	*/

	// RVA: -1 Offset: -1
	public void StopTween() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5666A50 Offset: 0x5662A50 VA: 0x5666A50
	|-TweenRunner<FloatTween>.StopTween
	|
	|-RVA: 0x5666E64 Offset: 0x5662E64 VA: 0x5666E64
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StopTween
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5666A90 Offset: 0x5662A90 VA: 0x5666A90
	|-TweenRunner<FloatTween>..ctor
	|
	|-RVA: 0x5666EA4 Offset: 0x5662EA4 VA: 0x5666EA4
	|-TweenRunner<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: 
public struct TMP_DefaultControls.Resources // TypeDefIndex: 21750
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

// Namespace: TMPro
public static class TMP_DefaultControls // TypeDefIndex: 21751
{
	// Fields
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_TextElementSize; // 0x0
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Color s_DefaultSelectableColor; // 0x18
	private static Color s_TextColor; // 0x28

	// Methods

	// RVA: 0x865D75C Offset: 0x865975C VA: 0x865D75C
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0x865D804 Offset: 0x8659804 VA: 0x865D804
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0x865D9C4 Offset: 0x86599C4 VA: 0x865D9C4
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	// RVA: 0x865DA4C Offset: 0x8659A4C VA: 0x865DA4C
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x865D8C4 Offset: 0x86598C4 VA: 0x865D8C4
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x865DAAC Offset: 0x8659AAC VA: 0x865DAAC
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x865DB90 Offset: 0x8659B90 VA: 0x865DB90
	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x865DE5C Offset: 0x8659E5C VA: 0x865DE5C
	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x865E11C Offset: 0x865A11C VA: 0x865E11C
	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x865E1BC Offset: 0x865A1BC VA: 0x865E1BC
	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x865E9C0 Offset: 0x865A9C0 VA: 0x865E9C0
	public static GameObject CreateDropdown(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x865FAC8 Offset: 0x865BAC8 VA: 0x865FAC8
	private static void .cctor() { }
}

// Namespace: 
protected internal class TMP_Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 21752
{
	// Fields
	[SerializeField]
	private TMP_Text m_Text; // 0x20
	[SerializeField]
	private Image m_Image; // 0x28
	[SerializeField]
	private RectTransform m_RectTransform; // 0x30
	[SerializeField]
	private Toggle m_Toggle; // 0x38

	// Properties
	public TMP_Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x8662AAC Offset: 0x865EAAC VA: 0x8662AAC
	public TMP_Text get_text() { }

	// RVA: 0x8662AB4 Offset: 0x865EAB4 VA: 0x8662AB4
	public void set_text(TMP_Text value) { }

	// RVA: 0x8662ABC Offset: 0x865EABC VA: 0x8662ABC
	public Image get_image() { }

	// RVA: 0x8662AC4 Offset: 0x865EAC4 VA: 0x8662AC4
	public void set_image(Image value) { }

	// RVA: 0x8662ACC Offset: 0x865EACC VA: 0x8662ACC
	public RectTransform get_rectTransform() { }

	// RVA: 0x8662AD4 Offset: 0x865EAD4 VA: 0x8662AD4
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x8662ADC Offset: 0x865EADC VA: 0x8662ADC
	public Toggle get_toggle() { }

	// RVA: 0x8662AE4 Offset: 0x865EAE4 VA: 0x8662AE4
	public void set_toggle(Toggle value) { }

	// RVA: 0x8662AEC Offset: 0x865EAEC VA: 0x8662AEC Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x8662B68 Offset: 0x865EB68 VA: 0x8662B68 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x8662C14 Offset: 0x865EC14 VA: 0x8662C14
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_Dropdown.OptionData // TypeDefIndex: 21753
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

	// RVA: 0x8662C1C Offset: 0x865EC1C VA: 0x8662C1C
	public string get_text() { }

	// RVA: 0x8662C24 Offset: 0x865EC24 VA: 0x8662C24
	public void set_text(string value) { }

	// RVA: 0x8662C2C Offset: 0x865EC2C VA: 0x8662C2C
	public Sprite get_image() { }

	// RVA: 0x8662C34 Offset: 0x865EC34 VA: 0x8662C34
	public void set_image(Sprite value) { }

	// RVA: 0x865F888 Offset: 0x865B888 VA: 0x865F888
	public void .ctor() { }

	// RVA: 0x86605E0 Offset: 0x865C5E0 VA: 0x86605E0
	public void .ctor(string text) { }

	// RVA: 0x8660774 Offset: 0x865C774 VA: 0x8660774
	public void .ctor(Sprite image) { }

	// RVA: 0x8662C3C Offset: 0x865EC3C VA: 0x8662C3C
	public void .ctor(string text, Sprite image) { }
}

// Namespace: 
[Serializable]
public class TMP_Dropdown.OptionDataList // TypeDefIndex: 21754
{
	// Fields
	[SerializeField]
	private List<TMP_Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<TMP_Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x8662C80 Offset: 0x865EC80 VA: 0x8662C80
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x8662C88 Offset: 0x865EC88 VA: 0x8662C88
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x865FF40 Offset: 0x865BF40 VA: 0x865FF40
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 21755
{
	// Methods

	// RVA: 0x865FFC8 Offset: 0x865BFC8 VA: 0x865FFC8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_Dropdown.<>c__DisplayClass69_0 // TypeDefIndex: 21756
{
	// Fields
	public TMP_Dropdown.DropdownItem item; // 0x10
	public TMP_Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x8661CB0 Offset: 0x865DCB0 VA: 0x8661CB0
	public void .ctor() { }

	// RVA: 0x8662C90 Offset: 0x865EC90 VA: 0x8662C90
	internal void <Show>b__0(bool x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_Dropdown.<DelayedDestroyDropdownList>d__81 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21757
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public TMP_Dropdown <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x86628D4 Offset: 0x865E8D4 VA: 0x86628D4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x8662CB4 Offset: 0x865ECB4 VA: 0x8662CB4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8662CB8 Offset: 0x865ECB8 VA: 0x8662CB8 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8662D6C Offset: 0x865ED6C VA: 0x8662D6C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x8662D74 Offset: 0x865ED74 VA: 0x8662D74 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x8662DAC Offset: 0x865EDAC VA: 0x8662DAC Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: TMPro
[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 21758
{
	// Fields
	[SerializeField]
	private RectTransform m_Template; // 0x100
	[SerializeField]
	private TMP_Text m_CaptionText; // 0x108
	[SerializeField]
	private Image m_CaptionImage; // 0x110
	[SerializeField]
	private Graphic m_Placeholder; // 0x118
	[SerializeField]
	[Space]
	private TMP_Text m_ItemText; // 0x120
	[SerializeField]
	private Image m_ItemImage; // 0x128
	[SerializeField]
	[Space]
	private int m_Value; // 0x130
	[SerializeField]
	[Space]
	private TMP_Dropdown.OptionDataList m_Options; // 0x138
	[SerializeField]
	[Space]
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x140
	[SerializeField]
	private float m_AlphaFadeSpeed; // 0x148
	private GameObject m_Dropdown; // 0x150
	private GameObject m_Blocker; // 0x158
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x160
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x168
	private bool validTemplate; // 0x170
	private Coroutine m_Coroutine; // 0x178
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }

	// Methods

	// RVA: 0x865FB58 Offset: 0x865BB58 VA: 0x865FB58
	public RectTransform get_template() { }

	// RVA: 0x865F80C Offset: 0x865B80C VA: 0x865F80C
	public void set_template(RectTransform value) { }

	// RVA: 0x865FB60 Offset: 0x865BB60 VA: 0x865FB60
	public TMP_Text get_captionText() { }

	// RVA: 0x865F82C Offset: 0x865B82C VA: 0x865F82C
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x865FB68 Offset: 0x865BB68 VA: 0x865FB68
	public Image get_captionImage() { }

	// RVA: 0x865FB70 Offset: 0x865BB70 VA: 0x865FB70
	public void set_captionImage(Image value) { }

	// RVA: 0x865FB90 Offset: 0x865BB90 VA: 0x865FB90
	public Graphic get_placeholder() { }

	// RVA: 0x865FB98 Offset: 0x865BB98 VA: 0x865FB98
	public void set_placeholder(Graphic value) { }

	// RVA: 0x865FBB8 Offset: 0x865BBB8 VA: 0x865FBB8
	public TMP_Text get_itemText() { }

	// RVA: 0x865F84C Offset: 0x865B84C VA: 0x865F84C
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x865FBC0 Offset: 0x865BBC0 VA: 0x865FBC0
	public Image get_itemImage() { }

	// RVA: 0x865FBC8 Offset: 0x865BBC8 VA: 0x865FBC8
	public void set_itemImage(Image value) { }

	// RVA: 0x865F86C Offset: 0x865B86C VA: 0x865F86C
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x865FBE8 Offset: 0x865BBE8 VA: 0x865FBE8
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x865FC10 Offset: 0x865BC10 VA: 0x865FC10
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x865FC18 Offset: 0x865BC18 VA: 0x865FC18
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x865FC28 Offset: 0x865BC28 VA: 0x865FC28
	public float get_alphaFadeSpeed() { }

	// RVA: 0x865FC30 Offset: 0x865BC30 VA: 0x865FC30
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x865FC38 Offset: 0x865BC38 VA: 0x865FC38
	public int get_value() { }

	// RVA: 0x865FC40 Offset: 0x865BC40 VA: 0x865FC40
	public void set_value(int value) { }

	// RVA: 0x865FDB0 Offset: 0x865BDB0 VA: 0x865FDB0
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x865FC48 Offset: 0x865BC48 VA: 0x865FC48
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x865FDB8 Offset: 0x865BDB8 VA: 0x865FDB8
	public bool get_IsExpanded() { }

	// RVA: 0x865FE18 Offset: 0x865BE18 VA: 0x865FE18
	protected void .ctor() { }

	// RVA: 0x8660010 Offset: 0x865C010 VA: 0x8660010 Slot: 4
	protected override void Awake() { }

	// RVA: 0x866010C Offset: 0x865C10C VA: 0x866010C Slot: 6
	protected override void Start() { }

	// RVA: 0x86601C0 Offset: 0x865C1C0 VA: 0x86601C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x865F890 Offset: 0x865B890 VA: 0x865F890
	public void RefreshShownValue() { }

	// RVA: 0x8660414 Offset: 0x865C414 VA: 0x8660414
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x866047C Offset: 0x865C47C VA: 0x866047C
	public void AddOptions(List<string> options) { }

	// RVA: 0x8660610 Offset: 0x865C610 VA: 0x8660610
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x86607A4 Offset: 0x865C7A4 VA: 0x86607A4
	public void ClearOptions() { }

	// RVA: 0x8660854 Offset: 0x865C854 VA: 0x8660854
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470F5BC Offset: 0x470B5BC VA: 0x470F5BC
	|-TMP_Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x8660EF0 Offset: 0x865CEF0 VA: 0x8660EF0 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x8661B74 Offset: 0x865DB74 VA: 0x8661B74 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x8661B78 Offset: 0x865DB78 VA: 0x8661B78 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x8660EF4 Offset: 0x865CEF4 VA: 0x8660EF4
	public void Show() { }

	// RVA: 0x86620C4 Offset: 0x865E0C4 VA: 0x86620C4 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x8662598 Offset: 0x865E598 VA: 0x8662598 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x86625F0 Offset: 0x865E5F0 VA: 0x86625F0 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x866265C Offset: 0x865E65C VA: 0x866265C Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x86626B4 Offset: 0x865E6B4 VA: 0x86626B4 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x8662720 Offset: 0x865E720 VA: 0x8662720 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x8661CB8 Offset: 0x865DCB8 VA: 0x8661CB8
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x8662724 Offset: 0x865E724 VA: 0x8662724
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x8661FA8 Offset: 0x865DFA8 VA: 0x8661FA8
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x86627A4 Offset: 0x865E7A4 VA: 0x86627A4
	private void SetAlpha(float alpha) { }

	// RVA: 0x8661B7C Offset: 0x865DB7C VA: 0x8661B7C
	public void Hide() { }

	[IteratorStateMachine(typeof(TMP_Dropdown.<DelayedDestroyDropdownList>d__81))]
	// RVA: 0x8662858 Offset: 0x865E858 VA: 0x8662858
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x8660264 Offset: 0x865C264 VA: 0x8660264
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x86628FC Offset: 0x865E8FC VA: 0x86628FC
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x8662A30 Offset: 0x865EA30 VA: 0x8662A30
	private static void .cctor() { }
}

// Namespace: TMPro
public enum AtlasPopulationMode // TypeDefIndex: 21759
{
	// Fields
	public int value__; // 0x0
	public const AtlasPopulationMode Static = 0;
	public const AtlasPopulationMode Dynamic = 1;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TMP_FontAsset.<>c // TypeDefIndex: 21760
{
	// Fields
	public static readonly TMP_FontAsset.<>c <>9; // 0x0
	public static Func<TMP_Character, uint> <>9__124_0; // 0x8
	public static Func<Glyph, uint> <>9__125_0; // 0x10

	// Methods

	// RVA: 0x866B8F0 Offset: 0x86678F0 VA: 0x866B8F0
	private static void .cctor() { }

	// RVA: 0x866B958 Offset: 0x8667958 VA: 0x866B958
	public void .ctor() { }

	// RVA: 0x866B960 Offset: 0x8667960 VA: 0x866B960
	internal uint <SortCharacterTable>b__124_0(TMP_Character c) { }

	// RVA: 0x866B978 Offset: 0x8667978 VA: 0x866B978
	internal uint <SortGlyphTable>b__125_0(Glyph c) { }
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 21761
{
	// Fields
	[SerializeField]
	private string m_Version; // 0x30
	[SerializeField]
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField]
	private Font m_SourceFontFile; // 0x40
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x50
	[SerializeField]
	internal List<Glyph> m_GlyphTable; // 0xB0
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB8
	[SerializeField]
	internal List<TMP_Character> m_CharacterTable; // 0xC0
	internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC8
	internal Texture2D m_AtlasTexture; // 0xD0
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; // 0xD8
	[SerializeField]
	internal int m_AtlasTextureIndex; // 0xE0
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; // 0xE4
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0xE5
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; // 0xE8
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; // 0xF0
	[SerializeField]
	private FaceInfo_Legacy m_fontInfo; // 0xF8
	[SerializeField]
	public Texture2D atlas; // 0x100
	[SerializeField]
	internal int m_AtlasWidth; // 0x108
	[SerializeField]
	internal int m_AtlasHeight; // 0x10C
	[SerializeField]
	internal int m_AtlasPadding; // 0x110
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; // 0x114
	[SerializeField]
	internal List<TMP_Glyph> m_glyphInfoList; // 0x118
	[SerializeField]
	[FormerlySerializedAs("m_kerningInfo")]
	internal KerningTable m_KerningTable; // 0x120
	[SerializeField]
	internal TMP_FontFeatureTable m_FontFeatureTable; // 0x128
	[SerializeField]
	private List<TMP_FontAsset> fallbackFontAssets; // 0x130
	[SerializeField]
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x138
	[SerializeField]
	internal FontAssetCreationSettings m_CreationSettings; // 0x140
	[SerializeField]
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x198
	[SerializeField]
	private TMP_FontWeightPair[] fontWeights; // 0x1A0
	public float normalStyle; // 0x1A8
	public float normalSpacingOffset; // 0x1AC
	public float boldStyle; // 0x1B0
	public float boldSpacing; // 0x1B4
	public byte italicStyle; // 0x1B8
	public byte tabSize; // 0x1B9
	internal bool IsFontAssetLookupTablesDirty; // 0x1BA
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x10
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x28
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x30
	private static string s_DefaultMaterialSuffix; // 0x38
	internal HashSet<int> FallbackSearchQueryLookup; // 0x1C0
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x40
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x48
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x50
	private static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue; // 0x58
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x60
	private List<Glyph> m_GlyphsToRender; // 0x1C8
	private List<Glyph> m_GlyphsRendered; // 0x1D0
	private List<uint> m_GlyphIndexList; // 0x1D8
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1E0
	internal List<uint> m_GlyphsToAdd; // 0x1E8
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x1F0
	internal List<TMP_Character> m_CharactersToAdd; // 0x1F8
	internal HashSet<uint> m_CharactersToAddLookup; // 0x200
	internal List<uint> s_MissingCharacterList; // 0x208
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x210
	internal static uint[] k_GlyphIndexArray; // 0x68

	// Properties
	public string version { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<TMP_Character> characterTable { get; set; }
	public Dictionary<uint, TMP_Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	internal bool clearDynamicDataOnBuild { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
	public FaceInfo_Legacy fontInfo { get; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	public TMP_FontFeatureTable fontFeatureTable { get; set; }
	public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
	public FontAssetCreationSettings creationSettings { get; set; }
	public TMP_FontWeightPair[] fontWeightTable { get; set; }

	// Methods

	// RVA: 0x8662DB4 Offset: 0x865EDB4 VA: 0x8662DB4
	public string get_version() { }

	// RVA: 0x8662DBC Offset: 0x865EDBC VA: 0x8662DBC
	internal void set_version(string value) { }

	// RVA: 0x8662DC4 Offset: 0x865EDC4 VA: 0x8662DC4
	public Font get_sourceFontFile() { }

	// RVA: 0x8662DCC Offset: 0x865EDCC VA: 0x8662DCC
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x8662DD4 Offset: 0x865EDD4 VA: 0x8662DD4
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x8662DDC Offset: 0x865EDDC VA: 0x8662DDC
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x8662DE4 Offset: 0x865EDE4 VA: 0x8662DE4
	public FaceInfo get_faceInfo() { }

	// RVA: 0x8662DF4 Offset: 0x865EDF4 VA: 0x8662DF4
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x8662E18 Offset: 0x865EE18 VA: 0x8662E18
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x8662E20 Offset: 0x865EE20 VA: 0x8662E20
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x8662E28 Offset: 0x865EE28 VA: 0x8662E28
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x8663084 Offset: 0x865F084 VA: 0x8663084
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0x866308C Offset: 0x865F08C VA: 0x866308C
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0x8663094 Offset: 0x865F094 VA: 0x8663094
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0x86630B8 Offset: 0x865F0B8 VA: 0x86630B8
	public Texture2D get_atlasTexture() { }

	// RVA: 0x8663158 Offset: 0x865F158 VA: 0x8663158
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x8663160 Offset: 0x865F160 VA: 0x8663160
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x8663168 Offset: 0x865F168 VA: 0x8663168
	public int get_atlasTextureCount() { }

	// RVA: 0x8663174 Offset: 0x865F174 VA: 0x8663174
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x866317C Offset: 0x865F17C VA: 0x866317C
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x8663188 Offset: 0x865F188 VA: 0x8663188
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x8663190 Offset: 0x865F190 VA: 0x8663190
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x866319C Offset: 0x865F19C VA: 0x866319C
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x86631A4 Offset: 0x865F1A4 VA: 0x86631A4
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x86631AC Offset: 0x865F1AC VA: 0x86631AC
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x86631B4 Offset: 0x865F1B4 VA: 0x86631B4
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x86631BC Offset: 0x865F1BC VA: 0x86631BC
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0x86631C4 Offset: 0x865F1C4 VA: 0x86631C4
	public int get_atlasWidth() { }

	// RVA: 0x86631CC Offset: 0x865F1CC VA: 0x86631CC
	internal void set_atlasWidth(int value) { }

	// RVA: 0x86631D4 Offset: 0x865F1D4 VA: 0x86631D4
	public int get_atlasHeight() { }

	// RVA: 0x86631DC Offset: 0x865F1DC VA: 0x86631DC
	internal void set_atlasHeight(int value) { }

	// RVA: 0x86631E4 Offset: 0x865F1E4 VA: 0x86631E4
	public int get_atlasPadding() { }

	// RVA: 0x86631EC Offset: 0x865F1EC VA: 0x86631EC
	internal void set_atlasPadding(int value) { }

	// RVA: 0x86631F4 Offset: 0x865F1F4 VA: 0x86631F4
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x86631FC Offset: 0x865F1FC VA: 0x86631FC
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x8663204 Offset: 0x865F204 VA: 0x8663204
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x866320C Offset: 0x865F20C VA: 0x866320C
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x866321C Offset: 0x865F21C VA: 0x866321C
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x8663224 Offset: 0x865F224 VA: 0x8663224
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0x8663234 Offset: 0x865F234 VA: 0x8663234
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0x8663244 Offset: 0x865F244 VA: 0x8663244
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0x8663268 Offset: 0x865F268 VA: 0x8663268
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x8663270 Offset: 0x865F270 VA: 0x8663270
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0x8663280 Offset: 0x865F280 VA: 0x8663280
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x86632FC Offset: 0x865F2FC VA: 0x86632FC
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x8663854 Offset: 0x865F854 VA: 0x8663854
	private void Awake() { }

	// RVA: 0x8662E4C Offset: 0x865EE4C VA: 0x8662E4C
	public void ReadFontAssetDefinition() { }

	// RVA: 0x8664520 Offset: 0x8660520 VA: 0x8664520
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x866484C Offset: 0x866084C VA: 0x866484C
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x8664B0C Offset: 0x8660B0C VA: 0x8664B0C
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x8664D5C Offset: 0x8660D5C VA: 0x8664D5C
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x8664540 Offset: 0x8660540 VA: 0x8664540
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x86652AC Offset: 0x86612AC VA: 0x86652AC
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x86654C4 Offset: 0x86614C4 VA: 0x86654C4
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character) { }

	// RVA: 0x866557C Offset: 0x866157C VA: 0x866557C
	internal void SortCharacterTable() { }

	// RVA: 0x86656D0 Offset: 0x86616D0 VA: 0x86656D0
	internal void SortGlyphTable() { }

	// RVA: 0x8665824 Offset: 0x8661824 VA: 0x8665824
	internal void SortFontFeatureTable() { }

	// RVA: 0x8665A54 Offset: 0x8661A54 VA: 0x8665A54
	internal void SortAllTables() { }

	// RVA: 0x8665A7C Offset: 0x8661A7C VA: 0x8665A7C
	public bool HasCharacter(int character) { }

	// RVA: 0x8665ADC Offset: 0x8661ADC VA: 0x8665ADC
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x86668A0 Offset: 0x86628A0 VA: 0x86668A0
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x8666ABC Offset: 0x8662ABC VA: 0x8666ABC
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x8666C74 Offset: 0x8662C74 VA: 0x8666C74
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x8667278 Offset: 0x8663278 VA: 0x8667278
	public bool HasCharacters(string text) { }

	// RVA: 0x866733C Offset: 0x866333C VA: 0x866733C
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x8667448 Offset: 0x8663448 VA: 0x8667448
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0x866752C Offset: 0x866352C VA: 0x866752C
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x8667644 Offset: 0x8663644 VA: 0x8667644
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x8667788 Offset: 0x8663788 VA: 0x8667788
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x8667C1C Offset: 0x8663C1C VA: 0x8667C1C
	internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x8667D60 Offset: 0x8663D60 VA: 0x8667D60
	internal static void UpdateAtlasTexturesForFontAssetsInQueue() { }

	// RVA: 0x8667ECC Offset: 0x8663ECC VA: 0x8667ECC
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x8667EEC Offset: 0x8663EEC VA: 0x8667EEC
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x8669010 Offset: 0x8665010 VA: 0x8669010
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x8669030 Offset: 0x8665030 VA: 0x8669030
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x8665FB8 Offset: 0x8661FB8 VA: 0x8665FB8
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0x8669E90 Offset: 0x8665E90 VA: 0x8669E90
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	// RVA: 0x8667EC8 Offset: 0x8663EC8 VA: 0x8667EC8
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x8668B68 Offset: 0x8664B68 VA: 0x8668B68
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x8669C78 Offset: 0x8665C78 VA: 0x8669C78
	private void SetupNewAtlasTexture() { }

	// RVA: 0x866A480 Offset: 0x8666480 VA: 0x866A480
	internal void UpdateAtlasTexture() { }

	// RVA: 0x86678F4 Offset: 0x86638F4 VA: 0x86678F4
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x866A788 Offset: 0x8666788 VA: 0x866A788
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x866AA88 Offset: 0x8666A88 VA: 0x866AA88
	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x866AA8C Offset: 0x8666A8C VA: 0x866AA8C
	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470F660 Offset: 0x470B660 VA: 0x470F660
	|-TMP_FontAsset.CopyListDataToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x866AA90 Offset: 0x8666A90 VA: 0x866AA90
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x866B034 Offset: 0x8667034 VA: 0x866B034
	internal void ClearFontAssetDataInternal() { }

	// RVA: 0x866B050 Offset: 0x8667050 VA: 0x866B050
	internal void UpdateFontAssetData() { }

	// RVA: 0x866AAC0 Offset: 0x8666AC0 VA: 0x866AAC0
	internal void ClearFontAssetTables() { }

	// RVA: 0x866ACD0 Offset: 0x8666CD0 VA: 0x866ACD0
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x86638DC Offset: 0x865F8DC VA: 0x86638DC
	internal void UpgradeFontAsset() { }

	// RVA: 0x8664F2C Offset: 0x8660F2C VA: 0x8664F2C
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0x866B1D8 Offset: 0x86671D8 VA: 0x866B1D8
	public void .ctor() { }

	// RVA: 0x866B5FC Offset: 0x86675FC VA: 0x866B5FC
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public class FaceInfo_Legacy // TypeDefIndex: 21762
{
	// Fields
	public string Name; // 0x10
	public float PointSize; // 0x18
	public float Scale; // 0x1C
	public int CharacterCount; // 0x20
	public float LineHeight; // 0x24
	public float Baseline; // 0x28
	public float Ascender; // 0x2C
	public float CapHeight; // 0x30
	public float Descender; // 0x34
	public float CenterLine; // 0x38
	public float SuperscriptOffset; // 0x3C
	public float SubscriptOffset; // 0x40
	public float SubSize; // 0x44
	public float Underline; // 0x48
	public float UnderlineThickness; // 0x4C
	public float strikethrough; // 0x50
	public float strikethroughThickness; // 0x54
	public float TabWidth; // 0x58
	public float Padding; // 0x5C
	public float AtlasWidth; // 0x60
	public float AtlasHeight; // 0x64

	// Methods

	// RVA: 0x866B990 Offset: 0x8667990 VA: 0x866B990
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 21763
{
	// Methods

	// RVA: 0x866B998 Offset: 0x8667998 VA: 0x866B998
	public static TMP_Glyph Clone(TMP_Glyph source) { }

	// RVA: 0x866BA14 Offset: 0x8667A14 VA: 0x866BA14
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public struct FontAssetCreationSettings // TypeDefIndex: 21764
{
	// Fields
	public string sourceFontFileName; // 0x0
	public string sourceFontFileGUID; // 0x8
	public int pointSizeSamplingMode; // 0x10
	public int pointSize; // 0x14
	public int padding; // 0x18
	public int packingMode; // 0x1C
	public int atlasWidth; // 0x20
	public int atlasHeight; // 0x24
	public int characterSetSelectionMode; // 0x28
	public string characterSequence; // 0x30
	public string referencedFontAssetGUID; // 0x38
	public string referencedTextAssetGUID; // 0x40
	public int fontStyle; // 0x48
	public float fontStyleModifier; // 0x4C
	public int renderMode; // 0x50
	public bool includeFontFeatures; // 0x54

	// Methods

	// RVA: 0x866BA1C Offset: 0x8667A1C VA: 0x866BA1C
	internal void .ctor(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode) { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_FontWeightPair // TypeDefIndex: 21765
{
	// Fields
	public TMP_FontAsset regularTypeface; // 0x0
	public TMP_FontAsset italicTypeface; // 0x8
}

// Namespace: TMPro
public struct KerningPairKey // TypeDefIndex: 21766
{
	// Fields
	public uint ascii_Left; // 0x0
	public uint ascii_Right; // 0x4
	public uint key; // 0x8

	// Methods

	// RVA: 0x866BB38 Offset: 0x8667B38 VA: 0x866BB38
	public void .ctor(uint ascii_left, uint ascii_right) { }
}

// Namespace: TMPro
[Serializable]
public struct GlyphValueRecord_Legacy // TypeDefIndex: 21767
{
	// Fields
	public float xPlacement; // 0x0
	public float yPlacement; // 0x4
	public float xAdvance; // 0x8
	public float yAdvance; // 0xC

	// Methods

	// RVA: 0x866BB48 Offset: 0x8667B48 VA: 0x866BB48
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x866BBA8 Offset: 0x8667BA8 VA: 0x866BBA8
	public static GlyphValueRecord_Legacy op_Addition(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) { }
}

// Namespace: TMPro
[Serializable]
public class KerningPair // TypeDefIndex: 21768
{
	// Fields
	[FormerlySerializedAs("AscII_Left")]
	[SerializeField]
	private uint m_FirstGlyph; // 0x10
	[SerializeField]
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAs("AscII_Right")]
	[SerializeField]
	private uint m_SecondGlyph; // 0x24
	[SerializeField]
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAs("XadvanceOffset")]
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField]
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x866BBBC Offset: 0x8667BBC VA: 0x866BBBC
	public uint get_firstGlyph() { }

	// RVA: 0x866BBC4 Offset: 0x8667BC4 VA: 0x866BBC4
	public void set_firstGlyph(uint value) { }

	// RVA: 0x866BBCC Offset: 0x8667BCC VA: 0x866BBCC
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x866BBD8 Offset: 0x8667BD8 VA: 0x866BBD8
	public uint get_secondGlyph() { }

	// RVA: 0x866BBE0 Offset: 0x8667BE0 VA: 0x866BBE0
	public void set_secondGlyph(uint value) { }

	// RVA: 0x866BBE8 Offset: 0x8667BE8 VA: 0x866BBE8
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x866BBF4 Offset: 0x8667BF4 VA: 0x866BBF4
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x866BBFC Offset: 0x8667BFC VA: 0x866BBFC
	public void .ctor() { }

	// RVA: 0x866BC20 Offset: 0x8667C20 VA: 0x866BC20
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x866BC60 Offset: 0x8667C60 VA: 0x866BC60
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x866BCE0 Offset: 0x8667CE0 VA: 0x866BCE0
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x866BCEC Offset: 0x8667CEC VA: 0x866BCEC
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class KerningTable.<>c // TypeDefIndex: 21769
{
	// Fields
	public static readonly KerningTable.<>c <>9; // 0x0
	public static Func<KerningPair, uint> <>9__7_0; // 0x8
	public static Func<KerningPair, uint> <>9__7_1; // 0x10

	// Methods

	// RVA: 0x866C688 Offset: 0x8668688 VA: 0x866C688
	private static void .cctor() { }

	// RVA: 0x866C6F0 Offset: 0x86686F0 VA: 0x866C6F0
	public void .ctor() { }

	// RVA: 0x866C6F8 Offset: 0x86686F8 VA: 0x866C6F8
	internal uint <SortKerningPairs>b__7_0(KerningPair s) { }

	// RVA: 0x866C710 Offset: 0x8668710 VA: 0x866C710
	internal uint <SortKerningPairs>b__7_1(KerningPair s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KerningTable.<>c__DisplayClass3_0 // TypeDefIndex: 21770
{
	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x866C0F4 Offset: 0x86680F4 VA: 0x866C0F4
	public void .ctor() { }

	// RVA: 0x866C728 Offset: 0x8668728 VA: 0x866C728
	internal bool <AddKerningPair>b__0(KerningPair item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KerningTable.<>c__DisplayClass4_0 // TypeDefIndex: 21771
{
	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x866C2EC Offset: 0x86682EC VA: 0x866C2EC
	public void .ctor() { }

	// RVA: 0x866C764 Offset: 0x8668764 VA: 0x866C764
	internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KerningTable.<>c__DisplayClass5_0 // TypeDefIndex: 21772
{
	// Fields
	public int left; // 0x10
	public int right; // 0x14

	// Methods

	// RVA: 0x866C410 Offset: 0x8668410 VA: 0x866C410
	public void .ctor() { }

	// RVA: 0x866C7A0 Offset: 0x86687A0 VA: 0x866C7A0
	internal bool <RemoveKerningPair>b__0(KerningPair item) { }
}

// Namespace: TMPro
[Serializable]
public class KerningTable // TypeDefIndex: 21773
{
	// Fields
	public List<KerningPair> kerningPairs; // 0x10

	// Methods

	// RVA: 0x866B574 Offset: 0x8667574 VA: 0x866B574
	public void .ctor() { }

	// RVA: 0x866BD68 Offset: 0x8667D68 VA: 0x866BD68
	public void AddKerningPair() { }

	// RVA: 0x866BF44 Offset: 0x8667F44 VA: 0x866BF44
	public int AddKerningPair(uint first, uint second, float offset) { }

	// RVA: 0x866C0FC Offset: 0x86680FC VA: 0x866C0FC
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	// RVA: 0x866C2F4 Offset: 0x86682F4 VA: 0x866C2F4
	public void RemoveKerningPair(int left, int right) { }

	// RVA: 0x866C418 Offset: 0x8668418 VA: 0x866C418
	public void RemoveKerningPair(int index) { }

	// RVA: 0x866C470 Offset: 0x8668470 VA: 0x866C470
	public void SortKerningPairs() { }
}

// Namespace: TMPro
public static class TMP_FontUtilities // TypeDefIndex: 21774
{
	// Fields
	private static List<int> k_searchedFontAssets; // 0x0

	// Methods

	// RVA: 0x866C7DC Offset: 0x86687DC VA: 0x866C7DC
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x866CB64 Offset: 0x8668B64 VA: 0x866CB64
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	// RVA: 0x866C8CC Offset: 0x86688CC VA: 0x866C8CC
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x866CB68 Offset: 0x8668B68 VA: 0x866CB68
	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }
}

// Namespace: TMPro
public class TMP_FontAssetUtilities // TypeDefIndex: 21775
{
	// Fields
	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static HashSet<int> k_SearchedAssets; // 0x8
	private static bool k_IsFontEngineInitialized; // 0x10

	// Properties
	public static TMP_FontAssetUtilities instance { get; }

	// Methods

	// RVA: 0x866CC64 Offset: 0x8668C64 VA: 0x866CC64
	private static void .cctor() { }

	// RVA: 0x866CCD4 Offset: 0x8668CD4 VA: 0x866CCD4
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0x866CD2C Offset: 0x8668D2C VA: 0x866CD2C
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x866CE88 Offset: 0x8668E88 VA: 0x866CE88
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x866D24C Offset: 0x866924C VA: 0x866D24C
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x866D4B0 Offset: 0x86694B0 VA: 0x866D4B0
	public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x866D7C0 Offset: 0x86697C0 VA: 0x866D7C0
	private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x866CCCC Offset: 0x8668CCC VA: 0x866CCCC
	public void .ctor() { }
}

// Namespace: TMPro
[Flags]
public enum FontFeatureLookupFlags // TypeDefIndex: 21776
{
	// Fields
	public int value__; // 0x0
	public const FontFeatureLookupFlags None = 0;
	public const FontFeatureLookupFlags IgnoreLigatures = 4;
	public const FontFeatureLookupFlags IgnoreSpacingAdjustments = 256;
}

// Namespace: TMPro
[Serializable]
public struct TMP_GlyphValueRecord // TypeDefIndex: 21777
{
	// Fields
	[SerializeField]
	internal float m_XPlacement; // 0x0
	[SerializeField]
	internal float m_YPlacement; // 0x4
	[SerializeField]
	internal float m_XAdvance; // 0x8
	[SerializeField]
	internal float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0x866D99C Offset: 0x866999C VA: 0x866D99C
	public float get_xPlacement() { }

	// RVA: 0x866D9A4 Offset: 0x86699A4 VA: 0x866D9A4
	public void set_xPlacement(float value) { }

	// RVA: 0x866D9AC Offset: 0x86699AC VA: 0x866D9AC
	public float get_yPlacement() { }

	// RVA: 0x866D9B4 Offset: 0x86699B4 VA: 0x866D9B4
	public void set_yPlacement(float value) { }

	// RVA: 0x866D9BC Offset: 0x86699BC VA: 0x866D9BC
	public float get_xAdvance() { }

	// RVA: 0x866D9C4 Offset: 0x86699C4 VA: 0x866D9C4
	public void set_xAdvance(float value) { }

	// RVA: 0x866D9CC Offset: 0x86699CC VA: 0x866D9CC
	public float get_yAdvance() { }

	// RVA: 0x866D9D4 Offset: 0x86699D4 VA: 0x866D9D4
	public void set_yAdvance(float value) { }

	// RVA: 0x866B174 Offset: 0x8667174 VA: 0x866B174
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x866D9DC Offset: 0x86699DC VA: 0x866D9DC
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x866D9E8 Offset: 0x86699E8 VA: 0x866D9E8
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x866DA48 Offset: 0x8669A48 VA: 0x866DA48
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 21778
{
	// Fields
	[SerializeField]
	internal uint m_GlyphIndex; // 0x0
	[SerializeField]
	internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; set; }
	public TMP_GlyphValueRecord glyphValueRecord { get; set; }

	// Methods

	// RVA: 0x866DA5C Offset: 0x8669A5C VA: 0x866DA5C
	public uint get_glyphIndex() { }

	// RVA: 0x866DA64 Offset: 0x8669A64 VA: 0x866DA64
	public void set_glyphIndex(uint value) { }

	// RVA: 0x866DA6C Offset: 0x8669A6C VA: 0x866DA6C
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x866DA78 Offset: 0x8669A78 VA: 0x866DA78
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

	// RVA: 0x866B180 Offset: 0x8667180 VA: 0x866B180
	public void .ctor(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	// RVA: 0x866DA84 Offset: 0x8669A84 VA: 0x866DA84
	internal void .ctor(GlyphAdjustmentRecord adjustmentRecord) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 21779
{
	// Fields
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField]
	internal FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0x866DAD8 Offset: 0x8669AD8 VA: 0x866DAD8
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x866DAEC Offset: 0x8669AEC VA: 0x866DAEC
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x866DB00 Offset: 0x8669B00 VA: 0x866DB00
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x866DB14 Offset: 0x8669B14 VA: 0x866DB14
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x866DB28 Offset: 0x8669B28 VA: 0x866DB28
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x866DB30 Offset: 0x8669B30 VA: 0x866DB30
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0x866B190 Offset: 0x8667190 VA: 0x866B190
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0x866A6D4 Offset: 0x86666D4 VA: 0x866A6D4
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }
}

// Namespace: TMPro
public struct GlyphPairKey // TypeDefIndex: 21780
{
	// Fields
	public uint firstGlyphIndex; // 0x0
	public uint secondGlyphIndex; // 0x4
	public uint key; // 0x8

	// Methods

	// RVA: 0x866DB38 Offset: 0x8669B38 VA: 0x866DB38
	public void .ctor(uint firstGlyphIndex, uint secondGlyphIndex) { }

	// RVA: 0x8665284 Offset: 0x8661284 VA: 0x8665284
	internal void .ctor(TMP_GlyphPairAdjustmentRecord record) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TMP_FontFeatureTable.<>c // TypeDefIndex: 21781
{
	// Fields
	public static readonly TMP_FontFeatureTable.<>c <>9; // 0x0
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x8
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10

	// Methods

	// RVA: 0x866DB58 Offset: 0x8669B58 VA: 0x866DB58
	private static void .cctor() { }

	// RVA: 0x866DBC0 Offset: 0x8669BC0 VA: 0x866DBC0
	public void .ctor() { }

	// RVA: 0x866DBC8 Offset: 0x8669BC8 VA: 0x866DBC8
	internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s) { }

	// RVA: 0x866DBE0 Offset: 0x8669BE0 VA: 0x866DBE0
	internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_FontFeatureTable // TypeDefIndex: 21782
{
	// Fields
	[SerializeField]
	internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
	internal Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

	// Properties
	public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x866DB48 Offset: 0x8669B48 VA: 0x866DB48
	public List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x866DB50 Offset: 0x8669B50 VA: 0x866DB50
	public void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	// RVA: 0x866A5F8 Offset: 0x86665F8 VA: 0x866A5F8
	public void .ctor() { }

	// RVA: 0x866583C Offset: 0x866183C VA: 0x866583C
	public void SortGlyphPairAdjustmentRecords() { }
}

// Namespace: 
public enum TMP_InputField.ContentType // TypeDefIndex: 21783
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.ContentType Standard = 0;
	public const TMP_InputField.ContentType Autocorrected = 1;
	public const TMP_InputField.ContentType IntegerNumber = 2;
	public const TMP_InputField.ContentType DecimalNumber = 3;
	public const TMP_InputField.ContentType Alphanumeric = 4;
	public const TMP_InputField.ContentType Name = 5;
	public const TMP_InputField.ContentType EmailAddress = 6;
	public const TMP_InputField.ContentType Password = 7;
	public const TMP_InputField.ContentType Pin = 8;
	public const TMP_InputField.ContentType Custom = 9;
}

// Namespace: 
public enum TMP_InputField.InputType // TypeDefIndex: 21784
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.InputType Standard = 0;
	public const TMP_InputField.InputType AutoCorrect = 1;
	public const TMP_InputField.InputType Password = 2;
}

// Namespace: 
public enum TMP_InputField.CharacterValidation // TypeDefIndex: 21785
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.CharacterValidation None = 0;
	public const TMP_InputField.CharacterValidation Digit = 1;
	public const TMP_InputField.CharacterValidation Integer = 2;
	public const TMP_InputField.CharacterValidation Decimal = 3;
	public const TMP_InputField.CharacterValidation Alphanumeric = 4;
	public const TMP_InputField.CharacterValidation Name = 5;
	public const TMP_InputField.CharacterValidation Regex = 6;
	public const TMP_InputField.CharacterValidation EmailAddress = 7;
	public const TMP_InputField.CharacterValidation CustomValidator = 8;
}

// Namespace: 
public enum TMP_InputField.LineType // TypeDefIndex: 21786
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.LineType SingleLine = 0;
	public const TMP_InputField.LineType MultiLineSubmit = 1;
	public const TMP_InputField.LineType MultiLineNewline = 2;
}

// Namespace: 
public sealed class TMP_InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 21787
{
	// Methods

	// RVA: 0x868F558 Offset: 0x868B558 VA: 0x868F558
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x868F60C Offset: 0x868B60C VA: 0x868F60C Slot: 13
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x868F620 Offset: 0x868B620 VA: 0x868F620 Slot: 14
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x868F6E0 Offset: 0x868B6E0 VA: 0x868F6E0 Slot: 15
	public virtual char EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 21788
{
	// Methods

	// RVA: 0x868F708 Offset: 0x868B708 VA: 0x868F708
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 21789
{
	// Methods

	// RVA: 0x868F750 Offset: 0x868B750 VA: 0x868F750
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.SelectionEvent : UnityEvent<string> // TypeDefIndex: 21790
{
	// Methods

	// RVA: 0x868F798 Offset: 0x868B798 VA: 0x868F798
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 21791
{
	// Methods

	// RVA: 0x868F7E0 Offset: 0x868B7E0 VA: 0x868F7E0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 21792
{
	// Methods

	// RVA: 0x868F828 Offset: 0x868B828 VA: 0x868F828
	public void .ctor() { }
}

// Namespace: 
protected enum TMP_InputField.EditState // TypeDefIndex: 21793
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.EditState Continue = 0;
	public const TMP_InputField.EditState Finish = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_InputField.<CaretBlink>d__276 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21794
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x868F870 Offset: 0x868B870 VA: 0x868F870
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x868F898 Offset: 0x868B898 VA: 0x868F898 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x868F89C Offset: 0x868B89C VA: 0x868F89C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x868F9C0 Offset: 0x868B9C0 VA: 0x868F9C0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x868F9C8 Offset: 0x868B9C8 VA: 0x868F9C8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x868FA00 Offset: 0x868BA00 VA: 0x868FA00 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_InputField.<MouseDragOutsideRect>d__294 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21795
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x868FA08 Offset: 0x868BA08 VA: 0x868FA08
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x868FA30 Offset: 0x868BA30 VA: 0x868FA30 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x868FA34 Offset: 0x868BA34 VA: 0x868FA34 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x868FC7C Offset: 0x868BC7C VA: 0x868FC7C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x868FC84 Offset: 0x868BC84 VA: 0x868FC84 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x868FCBC Offset: 0x868BCBC VA: 0x868FCBC Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: TMPro
[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 21796
{
	// Fields
	protected TouchScreenKeyboard m_SoftKeyboard; // 0x100
	private static readonly char[] kSeparators; // 0x0
	protected RectTransform m_RectTransform; // 0x108
	[SerializeField]
	protected RectTransform m_TextViewport; // 0x110
	protected RectMask2D m_TextComponentRectMask; // 0x118
	protected RectMask2D m_TextViewportRectMask; // 0x120
	private Rect m_CachedViewportRect; // 0x128
	[SerializeField]
	protected TMP_Text m_TextComponent; // 0x138
	protected RectTransform m_TextComponentRectTransform; // 0x140
	[SerializeField]
	protected Graphic m_Placeholder; // 0x148
	[SerializeField]
	protected Scrollbar m_VerticalScrollbar; // 0x150
	[SerializeField]
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x158
	private bool m_IsDrivenByLayoutComponents; // 0x160
	[SerializeField]
	private LayoutGroup m_LayoutGroup; // 0x168
	private IScrollHandler m_IScrollHandlerParent; // 0x170
	private float m_ScrollPosition; // 0x178
	[SerializeField]
	protected float m_ScrollSensitivity; // 0x17C
	[SerializeField]
	private TMP_InputField.ContentType m_ContentType; // 0x180
	[SerializeField]
	private TMP_InputField.InputType m_InputType; // 0x184
	[SerializeField]
	private char m_AsteriskChar; // 0x188
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; // 0x18C
	[SerializeField]
	private TMP_InputField.LineType m_LineType; // 0x190
	[SerializeField]
	private bool m_HideMobileInput; // 0x194
	[SerializeField]
	private bool m_HideSoftKeyboard; // 0x195
	[SerializeField]
	private TMP_InputField.CharacterValidation m_CharacterValidation; // 0x198
	[SerializeField]
	private string m_RegexValue; // 0x1A0
	[SerializeField]
	private float m_GlobalPointSize; // 0x1A8
	[SerializeField]
	private int m_CharacterLimit; // 0x1AC
	[SerializeField]
	private TMP_InputField.SubmitEvent m_OnEndEdit; // 0x1B0
	[SerializeField]
	private TMP_InputField.SubmitEvent m_OnSubmit; // 0x1B8
	[SerializeField]
	private TMP_InputField.SelectionEvent m_OnSelect; // 0x1C0
	[SerializeField]
	private TMP_InputField.SelectionEvent m_OnDeselect; // 0x1C8
	[SerializeField]
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; // 0x1D0
	[SerializeField]
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; // 0x1D8
	[SerializeField]
	private TMP_InputField.OnChangeEvent m_OnValueChanged; // 0x1E0
	[SerializeField]
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x1E8
	[SerializeField]
	private TMP_InputField.OnValidateInput m_OnValidateInput; // 0x1F0
	[SerializeField]
	private Color m_CaretColor; // 0x1F8
	[SerializeField]
	private bool m_CustomCaretColor; // 0x208
	[SerializeField]
	private Color m_SelectionColor; // 0x20C
	[TextArea(5, 10)]
	[SerializeField]
	protected string m_Text; // 0x220
	[SerializeField]
	[Range(0, 4)]
	private float m_CaretBlinkRate; // 0x228
	[SerializeField]
	[Range(1, 5)]
	private int m_CaretWidth; // 0x22C
	[SerializeField]
	private bool m_ReadOnly; // 0x230
	[SerializeField]
	private bool m_RichText; // 0x231
	protected int m_StringPosition; // 0x234
	protected int m_StringSelectPosition; // 0x238
	protected int m_CaretPosition; // 0x23C
	protected int m_CaretSelectPosition; // 0x240
	private RectTransform caretRectTrans; // 0x248
	protected UIVertex[] m_CursorVerts; // 0x250
	private CanvasRenderer m_CachedInputRenderer; // 0x258
	private Vector2 m_LastPosition; // 0x260
	protected Mesh m_Mesh; // 0x268
	private bool m_AllowInput; // 0x270
	private bool m_ShouldActivateNextUpdate; // 0x271
	private bool m_UpdateDrag; // 0x272
	private bool m_DragPositionOutOfBounds; // 0x273
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x274
	private Coroutine m_BlinkCoroutine; // 0x278
	private float m_BlinkStartTime; // 0x280
	private Coroutine m_DragCoroutine; // 0x288
	private string m_OriginalText; // 0x290
	private bool m_WasCanceled; // 0x298
	private bool m_HasDoneFocusTransition; // 0x299
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x2A0
	private bool m_PreventCallback; // 0x2A8
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x2A9
	private bool m_IsTextComponentUpdateRequired; // 0x2AA
	private bool m_isLastKeyBackspace; // 0x2AB
	private float m_PointerDownClickStartTime; // 0x2AC
	private float m_KeyDownStartTime; // 0x2B0
	private float m_DoubleClickDelay; // 0x2B4
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private bool m_IsCompositionActive; // 0x2B8
	private bool m_ShouldUpdateIMEWindowPosition; // 0x2B9
	private int m_PreviousIMEInsertionLine; // 0x2BC
	[SerializeField]
	protected TMP_FontAsset m_GlobalFontAsset; // 0x2C0
	[SerializeField]
	protected bool m_OnFocusSelectAll; // 0x2C8
	protected bool m_isSelectAll; // 0x2C9
	[SerializeField]
	protected bool m_ResetOnDeActivation; // 0x2CA
	private bool m_SelectionStillActive; // 0x2CB
	private bool m_ReleaseSelection; // 0x2CC
	private GameObject m_PreviouslySelectedObject; // 0x2D0
	[SerializeField]
	private bool m_RestoreOriginalTextOnEscape; // 0x2D8
	[SerializeField]
	protected bool m_isRichTextEditingAllowed; // 0x2D9
	[SerializeField]
	protected int m_LineLimit; // 0x2DC
	[SerializeField]
	protected TMP_InputValidator m_InputValidator; // 0x2E0
	private bool m_isSelected; // 0x2E8
	private bool m_IsStringPositionDirty; // 0x2E9
	private bool m_IsCaretPositionDirty; // 0x2EA
	private bool m_forceRectTransformAdjustment; // 0x2EB
	private Event m_ProcessingEvent; // 0x2F0

	// Properties
	private BaseInput inputSystem { get; }
	private string compositionString { get; }
	private int compositionLength { get; }
	protected Mesh mesh { get; }
	public bool shouldHideMobileInput { get; set; }
	public bool shouldHideSoftKeyboard { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public RectTransform textViewport { get; set; }
	public TMP_Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public float scrollSensitivity { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public TMP_InputField.SubmitEvent onEndEdit { get; set; }
	public TMP_InputField.SubmitEvent onSubmit { get; set; }
	public TMP_InputField.SelectionEvent onSelect { get; set; }
	public TMP_InputField.SelectionEvent onDeselect { get; set; }
	public TMP_InputField.TextSelectionEvent onTextSelection { get; set; }
	public TMP_InputField.TextSelectionEvent onEndTextSelection { get; set; }
	public TMP_InputField.OnChangeEvent onValueChanged { get; set; }
	public TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; }
	public TMP_InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public float pointSize { get; set; }
	public TMP_FontAsset fontAsset { get; set; }
	public bool onFocusSelectAll { get; set; }
	public bool resetOnDeActivation { get; set; }
	public bool restoreOriginalTextOnEscape { get; set; }
	public bool isRichTextEditingAllowed { get; set; }
	public TMP_InputField.ContentType contentType { get; set; }
	public TMP_InputField.LineType lineType { get; set; }
	public int lineLimit { get; set; }
	public TMP_InputField.InputType inputType { get; set; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public TMP_InputField.CharacterValidation characterValidation { get; set; }
	public TMP_InputValidator inputValidator { get; set; }
	public bool readOnly { get; set; }
	public bool richText { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int stringPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	protected int stringSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	public int stringPosition { get; set; }
	public int selectionStringAnchorPosition { get; set; }
	public int selectionStringFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x866DBF8 Offset: 0x8669BF8 VA: 0x866DBF8
	private BaseInput get_inputSystem() { }

	// RVA: 0x866DD08 Offset: 0x8669D08 VA: 0x866DD08
	private string get_compositionString() { }

	// RVA: 0x866DD9C Offset: 0x8669D9C VA: 0x866DD9C
	private int get_compositionLength() { }

	// RVA: 0x866DDC8 Offset: 0x8669DC8 VA: 0x866DDC8
	protected void .ctor() { }

	// RVA: 0x866E160 Offset: 0x866A160 VA: 0x866E160
	protected Mesh get_mesh() { }

	// RVA: 0x866E208 Offset: 0x866A208 VA: 0x866E208
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x866E290 Offset: 0x866A290 VA: 0x866E290
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x866E34C Offset: 0x866A34C VA: 0x866E34C
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0x866E444 Offset: 0x866A444 VA: 0x866E444
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0x866E5C0 Offset: 0x866A5C0 VA: 0x866E5C0
	private bool isKeyboardUsingEvents() { }

	// RVA: 0x866E658 Offset: 0x866A658 VA: 0x866E658
	public string get_text() { }

	// RVA: 0x866E660 Offset: 0x866A660 VA: 0x866E660
	public void set_text(string value) { }

	// RVA: 0x866E7A8 Offset: 0x866A7A8 VA: 0x866E7A8
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x866E668 Offset: 0x866A668 VA: 0x866E668
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x866ECD8 Offset: 0x866ACD8 VA: 0x866ECD8
	public bool get_isFocused() { }

	// RVA: 0x866ECE0 Offset: 0x866ACE0 VA: 0x866ECE0
	public float get_caretBlinkRate() { }

	// RVA: 0x866ECE8 Offset: 0x866ACE8 VA: 0x866ECE8
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x866EDD4 Offset: 0x866ADD4 VA: 0x866EDD4
	public int get_caretWidth() { }

	// RVA: 0x866EDDC Offset: 0x866ADDC VA: 0x866EDDC
	public void set_caretWidth(int value) { }

	// RVA: 0x866EEA8 Offset: 0x866AEA8 VA: 0x866EEA8
	public RectTransform get_textViewport() { }

	// RVA: 0x865E81C Offset: 0x865A81C VA: 0x865E81C
	public void set_textViewport(RectTransform value) { }

	// RVA: 0x866EEB0 Offset: 0x866AEB0 VA: 0x866EEB0
	public TMP_Text get_textComponent() { }

	// RVA: 0x865E874 Offset: 0x865A874 VA: 0x865E874
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0x866EEB8 Offset: 0x866AEB8 VA: 0x866EEB8
	public Graphic get_placeholder() { }

	// RVA: 0x865E8E8 Offset: 0x865A8E8 VA: 0x865E8E8
	public void set_placeholder(Graphic value) { }

	// RVA: 0x866EEC0 Offset: 0x866AEC0 VA: 0x866EEC0
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x866EEC8 Offset: 0x866AEC8 VA: 0x866EEC8
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x866F07C Offset: 0x866B07C VA: 0x866F07C
	public float get_scrollSensitivity() { }

	// RVA: 0x866F084 Offset: 0x866B084 VA: 0x866F084
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x866F0F8 Offset: 0x866B0F8 VA: 0x866F0F8
	public Color get_caretColor() { }

	// RVA: 0x866F13C Offset: 0x866B13C VA: 0x866F13C
	public void set_caretColor(Color value) { }

	// RVA: 0x866F168 Offset: 0x866B168 VA: 0x866F168
	public bool get_customCaretColor() { }

	// RVA: 0x866F170 Offset: 0x866B170 VA: 0x866F170
	public void set_customCaretColor(bool value) { }

	// RVA: 0x866F18C Offset: 0x866B18C VA: 0x866F18C
	public Color get_selectionColor() { }

	// RVA: 0x866F1A0 Offset: 0x866B1A0 VA: 0x866F1A0
	public void set_selectionColor(Color value) { }

	// RVA: 0x866F1CC Offset: 0x866B1CC VA: 0x866F1CC
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x866F1D4 Offset: 0x866B1D4 VA: 0x866F1D4
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x866F22C Offset: 0x866B22C VA: 0x866F22C
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x866F234 Offset: 0x866B234 VA: 0x866F234
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x866F28C Offset: 0x866B28C VA: 0x866F28C
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0x866F294 Offset: 0x866B294 VA: 0x866F294
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x866F2EC Offset: 0x866B2EC VA: 0x866F2EC
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0x866F2F4 Offset: 0x866B2F4 VA: 0x866F2F4
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x866F34C Offset: 0x866B34C VA: 0x866F34C
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0x866F354 Offset: 0x866B354 VA: 0x866F354
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x866F3AC Offset: 0x866B3AC VA: 0x866F3AC
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0x866F3B4 Offset: 0x866B3B4 VA: 0x866F3B4
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x866F40C Offset: 0x866B40C VA: 0x866F40C
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x866F414 Offset: 0x866B414 VA: 0x866F414
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0x866F46C Offset: 0x866B46C VA: 0x866F46C
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x866F474 Offset: 0x866B474 VA: 0x866F474
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0x866F4CC Offset: 0x866B4CC VA: 0x866F4CC
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x866F4D4 Offset: 0x866B4D4 VA: 0x866F4D4
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0x866F52C Offset: 0x866B52C VA: 0x866F52C
	public int get_characterLimit() { }

	// RVA: 0x866F534 Offset: 0x866B534 VA: 0x866F534
	public void set_characterLimit(int value) { }

	// RVA: 0x866F5F4 Offset: 0x866B5F4 VA: 0x866F5F4
	public float get_pointSize() { }

	// RVA: 0x866F5FC Offset: 0x866B5FC VA: 0x866F5FC
	public void set_pointSize(float value) { }

	// RVA: 0x866F798 Offset: 0x866B798 VA: 0x866F798
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x865E940 Offset: 0x865A940 VA: 0x865E940
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x866F880 Offset: 0x866B880 VA: 0x866F880
	public bool get_onFocusSelectAll() { }

	// RVA: 0x866F888 Offset: 0x866B888 VA: 0x866F888
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0x866F894 Offset: 0x866B894 VA: 0x866F894
	public bool get_resetOnDeActivation() { }

	// RVA: 0x866F89C Offset: 0x866B89C VA: 0x866F89C
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0x866F8A8 Offset: 0x866B8A8 VA: 0x866F8A8
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0x866F8B0 Offset: 0x866B8B0 VA: 0x866F8B0
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0x866F8BC Offset: 0x866B8BC VA: 0x866F8BC
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0x866F8C4 Offset: 0x866B8C4 VA: 0x866F8C4
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0x866F8D0 Offset: 0x866B8D0 VA: 0x866F8D0
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0x866F8D8 Offset: 0x866B8D8 VA: 0x866F8D8
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x866FA08 Offset: 0x866BA08 VA: 0x866FA08
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0x866FA10 Offset: 0x866BA10 VA: 0x866FA10
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0x866FB34 Offset: 0x866BB34 VA: 0x866FB34
	public int get_lineLimit() { }

	// RVA: 0x866FB3C Offset: 0x866BB3C VA: 0x866FB3C
	public void set_lineLimit(int value) { }

	// RVA: 0x866FBA8 Offset: 0x866BBA8 VA: 0x866FBA8
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0x866FBB0 Offset: 0x866BBB0 VA: 0x866FBB0
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0x866FC4C Offset: 0x866BC4C VA: 0x866FC4C
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x866FC54 Offset: 0x866BC54 VA: 0x866FC54
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x866FCD8 Offset: 0x866BCD8 VA: 0x866FCD8
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x866FCE0 Offset: 0x866BCE0 VA: 0x866FCE0
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0x866FD64 Offset: 0x866BD64 VA: 0x866FD64
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0x866FD6C Offset: 0x866BD6C VA: 0x866FD6C
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0x866FE08 Offset: 0x866BE08 VA: 0x866FE08
	public bool get_readOnly() { }

	// RVA: 0x866FE10 Offset: 0x866BE10 VA: 0x866FE10
	public void set_readOnly(bool value) { }

	// RVA: 0x866FE1C Offset: 0x866BE1C VA: 0x866FE1C
	public bool get_richText() { }

	// RVA: 0x866FE24 Offset: 0x866BE24 VA: 0x866FE24
	public void set_richText(bool value) { }

	// RVA: 0x866FEB8 Offset: 0x866BEB8 VA: 0x866FEB8
	public bool get_multiLine() { }

	// RVA: 0x866FECC Offset: 0x866BECC VA: 0x866FECC
	public char get_asteriskChar() { }

	// RVA: 0x866FED4 Offset: 0x866BED4 VA: 0x866FED4
	public void set_asteriskChar(char value) { }

	// RVA: 0x866FF48 Offset: 0x866BF48 VA: 0x866FF48
	public bool get_wasCanceled() { }

	// RVA: 0x866FF50 Offset: 0x866BF50 VA: 0x866FF50
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0x866FF88 Offset: 0x866BF88 VA: 0x866FF88
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0x866FFCC Offset: 0x866BFCC VA: 0x866FFCC
	protected int get_caretPositionInternal() { }

	// RVA: 0x866FFE4 Offset: 0x866BFE4 VA: 0x866FFE4
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x866FFF4 Offset: 0x866BFF4 VA: 0x866FFF4
	protected int get_stringPositionInternal() { }

	// RVA: 0x867000C Offset: 0x866C00C VA: 0x867000C
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0x8670044 Offset: 0x866C044 VA: 0x8670044
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x867005C Offset: 0x866C05C VA: 0x867005C
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x867006C Offset: 0x866C06C VA: 0x867006C
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0x8670084 Offset: 0x866C084 VA: 0x8670084
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0x86700BC Offset: 0x866C0BC VA: 0x86700BC
	private bool get_hasSelection() { }

	// RVA: 0x86700F8 Offset: 0x866C0F8 VA: 0x86700F8
	public int get_caretPosition() { }

	// RVA: 0x8670110 Offset: 0x866C110 VA: 0x8670110
	public void set_caretPosition(int value) { }

	// RVA: 0x86701BC Offset: 0x866C1BC VA: 0x86701BC
	public int get_selectionAnchorPosition() { }

	// RVA: 0x8670144 Offset: 0x866C144 VA: 0x8670144
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x86701D4 Offset: 0x866C1D4 VA: 0x86701D4
	public int get_selectionFocusPosition() { }

	// RVA: 0x8670180 Offset: 0x866C180 VA: 0x8670180
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x86701EC Offset: 0x866C1EC VA: 0x86701EC
	public int get_stringPosition() { }

	// RVA: 0x8670204 Offset: 0x866C204 VA: 0x8670204
	public void set_stringPosition(int value) { }

	// RVA: 0x86702E8 Offset: 0x866C2E8 VA: 0x86702E8
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0x8670238 Offset: 0x866C238 VA: 0x8670238
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0x8670300 Offset: 0x866C300 VA: 0x8670300
	public int get_selectionStringFocusPosition() { }

	// RVA: 0x8670290 Offset: 0x866C290 VA: 0x8670290
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0x8670318 Offset: 0x866C318 VA: 0x8670318 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x8670FE8 Offset: 0x866CFE8 VA: 0x8670FE8 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x86714F0 Offset: 0x866D4F0 VA: 0x86714F0
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachine(typeof(TMP_InputField.<CaretBlink>d__276))]
	// RVA: 0x8671770 Offset: 0x866D770 VA: 0x8671770
	private IEnumerator CaretBlink() { }

	// RVA: 0x86717E4 Offset: 0x866D7E4 VA: 0x86717E4
	private void SetCaretVisible() { }

	// RVA: 0x866ED64 Offset: 0x866AD64 VA: 0x866ED64
	private void SetCaretActive() { }

	// RVA: 0x867181C Offset: 0x866D81C VA: 0x867181C
	protected void OnFocus() { }

	// RVA: 0x867182C Offset: 0x866D82C VA: 0x867182C
	protected void SelectAll() { }

	// RVA: 0x8671864 Offset: 0x866D864 VA: 0x8671864
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x86719FC Offset: 0x866D9FC VA: 0x86719FC
	public void MoveTextStart(bool shift) { }

	// RVA: 0x8671B38 Offset: 0x866DB38 VA: 0x8671B38
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0x8671CB8 Offset: 0x866DCB8 VA: 0x8671CB8
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0x8671E48 Offset: 0x866DE48 VA: 0x8671E48
	private static string get_clipboard() { }

	// RVA: 0x8671E98 Offset: 0x866DE98 VA: 0x8671E98
	private static void set_clipboard(string value) { }

	// RVA: 0x8671EF0 Offset: 0x866DEF0 VA: 0x8671EF0
	private bool InPlaceEditing() { }

	// RVA: 0x8671FF4 Offset: 0x866DFF4 VA: 0x8671FF4
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x867213C Offset: 0x866E13C VA: 0x867213C Slot: 60
	protected virtual void LateUpdate() { }

	// RVA: 0x8673478 Offset: 0x866F478 VA: 0x8673478
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x8673550 Offset: 0x866F550 VA: 0x8673550 Slot: 61
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x8673570 Offset: 0x866F570 VA: 0x8673570 Slot: 62
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(TMP_InputField.<MouseDragOutsideRect>d__294))]
	// RVA: 0x8673814 Offset: 0x866F814 VA: 0x8673814
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x86738A4 Offset: 0x866F8A4 VA: 0x86738A4 Slot: 63
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x86738C0 Offset: 0x866F8C0 VA: 0x86738C0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x8673FF8 Offset: 0x866FFF8 VA: 0x8673FF8
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x86754BC Offset: 0x86714BC VA: 0x86754BC Slot: 64
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0x86754DC Offset: 0x86714DC VA: 0x86754DC
	public void ProcessEvent(Event e) { }

	// RVA: 0x86754E0 Offset: 0x86714E0 VA: 0x86754E0 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x86756DC Offset: 0x86716DC VA: 0x86756DC Slot: 66
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x8675894 Offset: 0x8671894 VA: 0x8675894
	private float GetScrollPositionRelativeToViewport() { }

	// RVA: 0x8674A08 Offset: 0x8670A08 VA: 0x8674A08
	private string GetSelectedString() { }

	// RVA: 0x8675B0C Offset: 0x8671B0C VA: 0x8675B0C
	private int FindNextWordBegin() { }

	// RVA: 0x8675090 Offset: 0x8671090 VA: 0x8675090
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x8675BE0 Offset: 0x8671BE0 VA: 0x8675BE0
	private int FindPrevWordBegin() { }

	// RVA: 0x8674CE0 Offset: 0x8670CE0 VA: 0x8674CE0
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x8675C98 Offset: 0x8671C98 VA: 0x8675C98
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x8675DE8 Offset: 0x8671DE8 VA: 0x8675DE8
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x8675F34 Offset: 0x8671F34 VA: 0x8675F34
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x8676118 Offset: 0x8672118 VA: 0x8676118
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x8675498 Offset: 0x8671498 VA: 0x8675498
	private void MoveDown(bool shift) { }

	// RVA: 0x8676304 Offset: 0x8672304 VA: 0x8676304
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x867548C Offset: 0x867148C VA: 0x867548C
	private void MoveUp(bool shift) { }

	// RVA: 0x86764C8 Offset: 0x86724C8 VA: 0x86764C8
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x86754A4 Offset: 0x86714A4 VA: 0x86754A4
	private void MovePageUp(bool shift) { }

	// RVA: 0x8676678 Offset: 0x8672678 VA: 0x8676678
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x86754B0 Offset: 0x86714B0 VA: 0x86754B0
	private void MovePageDown(bool shift) { }

	// RVA: 0x8676924 Offset: 0x8672924 VA: 0x8676924
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0x8674AC8 Offset: 0x8670AC8 VA: 0x8674AC8
	private void Delete() { }

	// RVA: 0x86747C4 Offset: 0x86707C4 VA: 0x86747C4
	private void DeleteKey() { }

	// RVA: 0x867441C Offset: 0x867041C VA: 0x867441C
	private void Backspace() { }

	// RVA: 0x8676BE0 Offset: 0x8672BE0 VA: 0x8676BE0 Slot: 67
	protected virtual void Append(string input) { }

	// RVA: 0x8676C90 Offset: 0x8672C90 VA: 0x8676C90 Slot: 68
	protected virtual void Append(char input) { }

	// RVA: 0x8676ECC Offset: 0x8672ECC VA: 0x8676ECC
	private void Insert(char c) { }

	// RVA: 0x8674CA4 Offset: 0x8670CA4 VA: 0x8674CA4
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x8673460 Offset: 0x866F460 VA: 0x8673460
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x866EC7C Offset: 0x866AC7C VA: 0x866EC7C
	private void SendOnValueChanged() { }

	// RVA: 0x8676FEC Offset: 0x8672FEC VA: 0x8676FEC
	protected void SendOnEndEdit() { }

	// RVA: 0x8675680 Offset: 0x8671680 VA: 0x8675680
	protected void SendOnSubmit() { }

	// RVA: 0x8677048 Offset: 0x8673048 VA: 0x8677048
	protected void SendOnFocus() { }

	// RVA: 0x86770A4 Offset: 0x86730A4 VA: 0x86770A4
	protected void SendOnFocusLost() { }

	// RVA: 0x8677100 Offset: 0x8673100 VA: 0x8677100
	protected void SendOnTextSelection() { }

	// RVA: 0x86771A8 Offset: 0x86731A8 VA: 0x86771A8
	protected void SendOnEndTextSelection() { }

	// RVA: 0x8672BEC Offset: 0x866EBEC VA: 0x8672BEC
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x866E7B0 Offset: 0x866A7B0 VA: 0x866E7B0
	protected void UpdateLabel() { }

	// RVA: 0x8671698 Offset: 0x866D698 VA: 0x8671698
	private void UpdateScrollbar() { }

	// RVA: 0x867723C Offset: 0x867323C VA: 0x867723C
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0x8670FE4 Offset: 0x866CFE4 VA: 0x8670FE4
	private void UpdateMaskRegions() { }

	// RVA: 0x8675974 Offset: 0x8671974 VA: 0x8675974
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0x8671628 Offset: 0x866D628 VA: 0x8671628
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x8677278 Offset: 0x8673278 VA: 0x8677278
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x86772EC Offset: 0x86732EC VA: 0x86772EC
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x867199C Offset: 0x866D99C VA: 0x867199C
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0x867735C Offset: 0x867335C VA: 0x867735C
	public void ForceLabelUpdate() { }

	// RVA: 0x866EE50 Offset: 0x866AE50 VA: 0x866EE50
	private void MarkGeometryAsDirty() { }

	// RVA: 0x8677360 Offset: 0x8673360 VA: 0x8677360 Slot: 69
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x8677424 Offset: 0x8673424 VA: 0x8677424 Slot: 70
	public virtual void LayoutComplete() { }

	// RVA: 0x8677428 Offset: 0x8673428 VA: 0x8677428 Slot: 71
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x8677370 Offset: 0x8673370 VA: 0x8677370
	private void UpdateGeometry() { }

	// RVA: 0x8670AE4 Offset: 0x866CAE4 VA: 0x8670AE4
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x867742C Offset: 0x867342C VA: 0x867742C
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x8677794 Offset: 0x8673794 VA: 0x8677794
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x867834C Offset: 0x867434C VA: 0x867834C
	private void CreateCursorVerts() { }

	// RVA: 0x8677D78 Offset: 0x8673D78 VA: 0x8677D78
	private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x86784AC Offset: 0x86744AC VA: 0x86784AC
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0x8672C60 Offset: 0x866EC60 VA: 0x8672C60
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x867892C Offset: 0x867492C VA: 0x867892C
	public void ActivateInputField() { }

	// RVA: 0x86727BC Offset: 0x866E7BC VA: 0x86727BC
	private void ActivateInputFieldInternal() { }

	// RVA: 0x8678A40 Offset: 0x8674A40 VA: 0x8678A40 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x8678A64 Offset: 0x8674A64 VA: 0x8678A64 Slot: 72
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x8678A88 Offset: 0x8674A88 VA: 0x8678A88
	public void OnControlClick() { }

	// RVA: 0x8672BB0 Offset: 0x866EBB0 VA: 0x8672BB0
	public void ReleaseSelection() { }

	// RVA: 0x8671324 Offset: 0x866D324 VA: 0x8671324
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0x8678A8C Offset: 0x8674A8C VA: 0x8678A8C Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x8678AC4 Offset: 0x8674AC4 VA: 0x8678AC4 Slot: 73
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x866F94C Offset: 0x866B94C VA: 0x866F94C
	private void EnforceContentType() { }

	// RVA: 0x866E0CC Offset: 0x866A0CC VA: 0x866E0CC
	private void SetTextComponentWrapMode() { }

	// RVA: 0x866FE30 Offset: 0x866BE30 VA: 0x866FE30
	private void SetTextComponentRichTextMode() { }

	// RVA: 0x866FAD0 Offset: 0x866BAD0 VA: 0x866FAD0
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x866FC34 Offset: 0x866BC34 VA: 0x866FC34
	private void SetToCustom() { }

	// RVA: 0x866FDF0 Offset: 0x866BDF0 VA: 0x866FDF0
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0x8678B18 Offset: 0x8674B18 VA: 0x8678B18 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x8678B44 Offset: 0x8674B44 VA: 0x8678B44 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x8678B48 Offset: 0x8674B48 VA: 0x8678B48 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x8678B4C Offset: 0x8674B4C VA: 0x8678B4C Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0x8678B54 Offset: 0x8674B54 VA: 0x8678B54 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0x8678C84 Offset: 0x8674C84 VA: 0x8678C84 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x8678C8C Offset: 0x8674C8C VA: 0x8678C8C Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0x8678C94 Offset: 0x8674C94 VA: 0x8678C94 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0x8678DC4 Offset: 0x8674DC4 VA: 0x8678DC4 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x8678DCC Offset: 0x8674DCC VA: 0x8678DCC Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0x866F6B0 Offset: 0x866B6B0 VA: 0x866F6B0
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0x866F7A0 Offset: 0x866B7A0 VA: 0x866F7A0
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x8678DD4 Offset: 0x8674DD4 VA: 0x8678DD4
	private static void .cctor() { }

	// RVA: 0x8678E74 Offset: 0x8674E74 VA: 0x8678E74 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: TMPro
internal static class SetPropertyUtility // TypeDefIndex: 21797
{
	// Methods

	// RVA: 0x868FCC4 Offset: 0x868BCC4 VA: 0x868FCC4
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	// RVA: -1 Offset: -1
	public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F2720 Offset: 0x46EE720 VA: 0x46F2720
	|-SetPropertyUtility.SetEquatableStruct<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F28C0 Offset: 0x46EE8C0 VA: 0x46F28C0
	|-SetPropertyUtility.SetStruct<bool>
	|
	|-RVA: 0x46F2964 Offset: 0x46EE964 VA: 0x46F2964
	|-SetPropertyUtility.SetStruct<char>
	|
	|-RVA: 0x46F2A08 Offset: 0x46EEA08 VA: 0x46F2A08
	|-SetPropertyUtility.SetStruct<int>
	|
	|-RVA: 0x46F2A78 Offset: 0x46EEA78 VA: 0x46F2A78
	|-SetPropertyUtility.SetStruct<Int32Enum>
	|
	|-RVA: 0x46F2B14 Offset: 0x46EEB14 VA: 0x46F2B14
	|-SetPropertyUtility.SetStruct<float>
	|
	|-RVA: 0x46F2B8C Offset: 0x46EEB8C VA: 0x46F2B8C
	|-SetPropertyUtility.SetStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetClass<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F26C4 Offset: 0x46EE6C4 VA: 0x46F26C4
	|-SetPropertyUtility.SetClass<object>
	*/
}

// Namespace: TMPro
[Serializable]
public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 21798
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract char Validate(ref string text, ref int pos, char ch);

	// RVA: 0x868FD0C Offset: 0x868BD0C VA: 0x868FD0C
	protected void .ctor() { }
}

// Namespace: TMPro
public struct TMP_LineInfo // TypeDefIndex: 21799
{
	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int wordCount; // 0x10
	public int firstCharacterIndex; // 0x14
	public int firstVisibleCharacterIndex; // 0x18
	public int lastCharacterIndex; // 0x1C
	public int lastVisibleCharacterIndex; // 0x20
	public float length; // 0x24
	public float lineHeight; // 0x28
	public float ascender; // 0x2C
	public float baseline; // 0x30
	public float descender; // 0x34
	public float maxAdvance; // 0x38
	public float width; // 0x3C
	public float marginLeft; // 0x40
	public float marginRight; // 0x44
	public HorizontalAlignmentOptions alignment; // 0x48
	public Extents lineExtents; // 0x4C
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TMP_ListPool.<>c<T> // TypeDefIndex: 21800
{
	// Fields
	public static readonly TMP_ListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482436C Offset: 0x482036C VA: 0x482436C
	|-TMP_ListPool.<>c<object>..cctor
	|
	|-RVA: 0x4828ED0 Offset: 0x4824ED0 VA: 0x4828ED0
	|-TMP_ListPool.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4824428 Offset: 0x4820428 VA: 0x4824428
	|-TMP_ListPool.<>c<object>..ctor
	|
	|-RVA: 0x4828FC4 Offset: 0x4824FC4 VA: 0x4828FC4
	|-TMP_ListPool.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__3_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4824430 Offset: 0x4820430 VA: 0x4824430
	|-TMP_ListPool.<>c<object>.<.cctor>b__3_0
	|
	|-RVA: 0x4828FCC Offset: 0x4824FCC VA: 0x4828FCC
	|-TMP_ListPool.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__3_0
	*/
}

// Namespace: TMPro
internal static class TMP_ListPool<T> // TypeDefIndex: 21801
{
	// Fields
	private static readonly TMP_ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55364F0 Offset: 0x55324F0 VA: 0x55364F0
	|-TMP_ListPool<object>.Get
	|
	|-RVA: 0x55367F0 Offset: 0x55327F0 VA: 0x55367F0
	|-TMP_ListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536588 Offset: 0x5532588 VA: 0x5536588
	|-TMP_ListPool<object>.Release
	|
	|-RVA: 0x55368D8 Offset: 0x55328D8 VA: 0x55368D8
	|-TMP_ListPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536630 Offset: 0x5532630 VA: 0x5536630
	|-TMP_ListPool<object>..cctor
	|
	|-RVA: 0x55369D4 Offset: 0x55329D4 VA: 0x55369D4
	|-TMP_ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
private class TMP_MaterialManager.FallbackMaterial // TypeDefIndex: 21802
{
	// Fields
	public long fallbackID; // 0x10
	public Material sourceMaterial; // 0x18
	internal int sourceMaterialCRC; // 0x20
	public Material fallbackMaterial; // 0x28
	public int count; // 0x30

	// Methods

	// RVA: 0x8692B14 Offset: 0x868EB14 VA: 0x8692B14
	public void .ctor() { }
}

// Namespace: 
private class TMP_MaterialManager.MaskingMaterial // TypeDefIndex: 21803
{
	// Fields
	public Material baseMaterial; // 0x10
	public Material stencilMaterial; // 0x18
	public int count; // 0x20
	public int stencilID; // 0x24

	// Methods

	// RVA: 0x8691044 Offset: 0x868D044 VA: 0x8691044
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_MaterialManager.<>c__DisplayClass11_0 // TypeDefIndex: 21804
{
	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x8691730 Offset: 0x868D730 VA: 0x8691730
	public void .ctor() { }

	// RVA: 0x869347C Offset: 0x868F47C VA: 0x869347C
	internal bool <AddMaskingMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_MaterialManager.<>c__DisplayClass12_0 // TypeDefIndex: 21805
{
	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x86918A0 Offset: 0x868D8A0 VA: 0x86918A0
	public void .ctor() { }

	// RVA: 0x86934EC Offset: 0x868F4EC VA: 0x86934EC
	internal bool <RemoveStencilMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_MaterialManager.<>c__DisplayClass13_0 // TypeDefIndex: 21806
{
	// Fields
	public Material baseMaterial; // 0x10

	// Methods

	// RVA: 0x8691D8C Offset: 0x868DD8C VA: 0x8691D8C
	public void .ctor() { }

	// RVA: 0x869355C Offset: 0x868F55C VA: 0x869355C
	internal bool <ReleaseBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_MaterialManager.<>c__DisplayClass9_0 // TypeDefIndex: 21807
{
	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x86913A8 Offset: 0x868D3A8 VA: 0x86913A8
	public void .ctor() { }

	// RVA: 0x86935CC Offset: 0x868F5CC VA: 0x86935CC
	internal bool <GetBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: TMPro
public static class TMP_MaterialManager // TypeDefIndex: 21808
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x868FD14 Offset: 0x868BD14 VA: 0x868FD14
	private static void .cctor() { }

	// RVA: 0x868FF04 Offset: 0x868BF04 VA: 0x868FF04
	private static void OnPreRender() { }

	// RVA: 0x8690190 Offset: 0x868C190 VA: 0x8690190
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x869104C Offset: 0x868D04C VA: 0x869104C
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x869123C Offset: 0x868D23C VA: 0x869123C
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x86913B0 Offset: 0x868D3B0 VA: 0x86913B0
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x869146C Offset: 0x868D46C VA: 0x869146C
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x8691738 Offset: 0x868D738 VA: 0x8691738
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x86918A8 Offset: 0x868D8A8 VA: 0x86918A8
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x8691D94 Offset: 0x868DD94 VA: 0x8691D94
	public static void ClearMaterials() { }

	// RVA: 0x8691F50 Offset: 0x868DF50 VA: 0x8691F50
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x86923BC Offset: 0x868E3BC VA: 0x86923BC
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x869221C Offset: 0x868E21C VA: 0x869221C
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x86925B8 Offset: 0x868E5B8 VA: 0x86925B8
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x8692B1C Offset: 0x868EB1C VA: 0x8692B1C
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x8692F68 Offset: 0x868EF68 VA: 0x8692F68
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x86930AC Offset: 0x868F0AC VA: 0x86930AC
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x868FF7C Offset: 0x868BF7C VA: 0x868FF7C
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x8693284 Offset: 0x868F284 VA: 0x8693284
	public static void ReleaseFallbackMaterial(Material fallbackMaterial) { }

	// RVA: 0x86928A8 Offset: 0x868E8A8 VA: 0x86928A8
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}

// Namespace: TMPro
public enum VertexSortingOrder // TypeDefIndex: 21809
{
	// Fields
	public int value__; // 0x0
	public const VertexSortingOrder Normal = 0;
	public const VertexSortingOrder Reverse = 1;
}

// Namespace: TMPro
public struct TMP_MeshInfo // TypeDefIndex: 21810
{
	// Fields
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x4
	private static readonly Vector4 s_DefaultTangent; // 0x10
	private static readonly Bounds s_DefaultBounds; // 0x20
	public Mesh mesh; // 0x0
	public int vertexCount; // 0x8
	public Vector3[] vertices; // 0x10
	public Vector3[] normals; // 0x18
	public Vector4[] tangents; // 0x20
	public Vector2[] uvs0; // 0x28
	public Vector2[] uvs2; // 0x30
	public Color32[] colors32; // 0x38
	public int[] triangles; // 0x40
	public Material material; // 0x48

	// Methods

	// RVA: 0x869363C Offset: 0x868F63C VA: 0x869363C
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x8693BD8 Offset: 0x868FBD8 VA: 0x8693BD8
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x869440C Offset: 0x869040C VA: 0x869440C
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x8694880 Offset: 0x8690880 VA: 0x8694880
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x8695158 Offset: 0x8691158 VA: 0x8695158
	public void Clear() { }

	// RVA: 0x86951FC Offset: 0x86911FC VA: 0x86951FC
	public void Clear(bool uploadChanges) { }

	// RVA: 0x8695334 Offset: 0x8691334 VA: 0x8695334
	public void ClearUnusedVertices() { }

	// RVA: 0x8695370 Offset: 0x8691370 VA: 0x8695370
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x86953A4 Offset: 0x86913A4 VA: 0x86953A4
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x8695468 Offset: 0x8691468 VA: 0x8695468
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x8695AA8 Offset: 0x8691AA8 VA: 0x8695AA8
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x869551C Offset: 0x869151C VA: 0x869551C
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0x8695CA0 Offset: 0x8691CA0 VA: 0x8695CA0
	private static void .cctor() { }
}

// Namespace: TMPro
internal class TMP_ObjectPool<T> // TypeDefIndex: 21811
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGenerated]
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536BF0 Offset: 0x5532BF0 VA: 0x5536BF0
	|-TMP_ObjectPool<object>.get_countAll
	|
	|-RVA: 0x5536E40 Offset: 0x5532E40 VA: 0x5536E40
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536BF8 Offset: 0x5532BF8 VA: 0x5536BF8
	|-TMP_ObjectPool<object>.set_countAll
	|
	|-RVA: 0x5536E48 Offset: 0x5532E48 VA: 0x5536E48
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536C00 Offset: 0x5532C00 VA: 0x5536C00
	|-TMP_ObjectPool<object>.get_countActive
	|
	|-RVA: 0x5536E50 Offset: 0x5532E50 VA: 0x5536E50
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536C24 Offset: 0x5532C24 VA: 0x5536C24
	|-TMP_ObjectPool<object>.get_countInactive
	|
	|-RVA: 0x5536EA0 Offset: 0x5532EA0 VA: 0x5536EA0
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536C40 Offset: 0x5532C40 VA: 0x5536C40
	|-TMP_ObjectPool<object>..ctor
	|
	|-RVA: 0x5536EC8 Offset: 0x5532EC8 VA: 0x5536EC8
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536CE0 Offset: 0x5532CE0 VA: 0x5536CE0
	|-TMP_ObjectPool<object>.Get
	|
	|-RVA: 0x5536F6C Offset: 0x5532F6C VA: 0x5536F6C
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536D5C Offset: 0x5532D5C VA: 0x5536D5C
	|-TMP_ObjectPool<object>.Release
	|
	|-RVA: 0x5537148 Offset: 0x5533148 VA: 0x5537148
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.Release
	*/
}

// Namespace: TMPro
public class TMP_ResourceManager // TypeDefIndex: 21812
{
	// Fields
	private static readonly TMP_ResourceManager s_instance; // 0x0
	private static TMP_Settings s_TextSettings; // 0x8
	private static readonly List<TMP_FontAsset> s_FontAssetReferences; // 0x10
	private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup; // 0x18

	// Methods

	// RVA: 0x8695D20 Offset: 0x8691D20 VA: 0x8695D20
	private static void .cctor() { }

	// RVA: 0x8695E40 Offset: 0x8691E40 VA: 0x8695E40
	internal static TMP_Settings GetTextSettings() { }

	// RVA: 0x8695F50 Offset: 0x8691F50 VA: 0x8695F50
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x86960AC Offset: 0x86920AC VA: 0x86960AC
	public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x869614C Offset: 0x869214C VA: 0x869614C
	internal static void RebuildFontAssetCache(int instanceID) { }

	// RVA: 0x8695E38 Offset: 0x8691E38 VA: 0x8695E38
	public void .ctor() { }
}

// Namespace: TMPro
internal enum MarkupTag // TypeDefIndex: 21813
{
	// Fields
	public int value__; // 0x0
	public const MarkupTag BOLD = 66;
	public const MarkupTag SLASH_BOLD = 1613;
	public const MarkupTag ITALIC = 73;
	public const MarkupTag SLASH_ITALIC = 1606;
	public const MarkupTag UNDERLINE = 85;
	public const MarkupTag SLASH_UNDERLINE = 1626;
	public const MarkupTag STRIKETHROUGH = 83;
	public const MarkupTag SLASH_STRIKETHROUGH = 1628;
	public const MarkupTag MARK = 2699125;
	public const MarkupTag SLASH_MARK = 57644506;
	public const MarkupTag SUBSCRIPT = 92132;
	public const MarkupTag SLASH_SUBSCRIPT = 1770219;
	public const MarkupTag SUPERSCRIPT = 92150;
	public const MarkupTag SLASH_SUPERSCRIPT = 1770233;
	public const MarkupTag COLOR = 81999901;
	public const MarkupTag SLASH_COLOR = 1909026194;
	public const MarkupTag ALPHA = 75165780;
	public const MarkupTag A = 65;
	public const MarkupTag SLASH_A = 1614;
	public const MarkupTag SIZE = 3061285;
	public const MarkupTag SLASH_SIZE = 58429962;
	public const MarkupTag SPRITE = -991527447;
	public const MarkupTag NO_BREAK = 2856657;
	public const MarkupTag SLASH_NO_BREAK = 57477502;
	public const MarkupTag STYLE = 100252951;
	public const MarkupTag SLASH_STYLE = 1927738392;
	public const MarkupTag FONT = 2586451;
	public const MarkupTag SLASH_FONT = 57747708;
	public const MarkupTag SLASH_MATERIAL = -1100708252;
	public const MarkupTag LINK = 2656128;
	public const MarkupTag SLASH_LINK = 57686191;
	public const MarkupTag FONT_WEIGHT = -1889896162;
	public const MarkupTag SLASH_FONT_WEIGHT = -757976431;
	public const MarkupTag NO_PARSE = -408011596;
	public const MarkupTag SLASH_NO_PARSE = -294095813;
	public const MarkupTag POSITION = 85420;
	public const MarkupTag SLASH_POSITION = 1777699;
	public const MarkupTag VERTICAL_OFFSET = 1952379995;
	public const MarkupTag SLASH_VERTICAL_OFFSET = -11107948;
	public const MarkupTag SPACE = 100083556;
	public const MarkupTag SLASH_SPACE = 1927873067;
	public const MarkupTag PAGE = 2808691;
	public const MarkupTag SLASH_PAGE = 58683868;
	public const MarkupTag ALIGN = 75138797;
	public const MarkupTag SLASH_ALIGN = 1916026786;
	public const MarkupTag WIDTH = 105793766;
	public const MarkupTag SLASH_WIDTH = 1923459625;
	public const MarkupTag GRADIENT = -1999759898;
	public const MarkupTag SLASH_GRADIENT = -1854491959;
	public const MarkupTag CHARACTER_SPACE = -1584382009;
	public const MarkupTag SLASH_CHARACTER_SPACE = -1394426712;
	public const MarkupTag MONOSPACE = -1340221943;
	public const MarkupTag SLASH_MONOSPACE = -1638865562;
	public const MarkupTag CLASS = 82115566;
	public const MarkupTag INDENT = -1514123076;
	public const MarkupTag SLASH_INDENT = -1496889389;
	public const MarkupTag LINE_INDENT = -844305121;
	public const MarkupTag SLASH_LINE_INDENT = 93886352;
	public const MarkupTag MARGIN = -1355614050;
	public const MarkupTag SLASH_MARGIN = -1649644303;
	public const MarkupTag MARGIN_LEFT = -272933656;
	public const MarkupTag MARGIN_RIGHT = -447416589;
	public const MarkupTag LINE_HEIGHT = -799081892;
	public const MarkupTag SLASH_LINE_HEIGHT = 200452819;
	public const MarkupTag ACTION = -1827519330;
	public const MarkupTag SLASH_ACTION = -1187217679;
	public const MarkupTag SCALE = 100553336;
	public const MarkupTag SLASH_SCALE = 1928413879;
	public const MarkupTag ROTATE = -1000007783;
	public const MarkupTag SLASH_ROTATE = -764695562;
	public const MarkupTag LOWERCASE = -1506899689;
	public const MarkupTag SLASH_LOWERCASE = -1451284584;
	public const MarkupTag ALLCAPS = 218273952;
	public const MarkupTag SLASH_ALLCAPS = -797437649;
	public const MarkupTag UPPERCASE = -305409418;
	public const MarkupTag SLASH_UPPERCASE = -582368199;
	public const MarkupTag SMALLCAPS = -766062114;
	public const MarkupTag SLASH_SMALLCAPS = 199921873;
	public const MarkupTag LIGA = 2655971;
	public const MarkupTag SLASH_LIGA = 57686604;
	public const MarkupTag FRAC = 2598518;
	public const MarkupTag SLASH_FRAC = 57774681;
	public const MarkupTag NAME = 2875623;
	public const MarkupTag INDEX = 84268030;
	public const MarkupTag TINT = 2960519;
	public const MarkupTag ANIM = 2283339;
	public const MarkupTag MATERIAL = 825491659;
	public const MarkupTag HREF = 2535353;
	public const MarkupTag ANGLE = 75347905;
	public const MarkupTag RED = 91635;
	public const MarkupTag GREEN = 87065851;
	public const MarkupTag BLUE = 2457214;
	public const MarkupTag YELLOW = -882444668;
	public const MarkupTag ORANGE = -1108587920;
	public const MarkupTag BLACK = 81074727;
	public const MarkupTag WHITE = 105680263;
	public const MarkupTag PURPLE = -1250222130;
	public const MarkupTag BR = 2256;
	public const MarkupTag ZWSP = 3288238;
	public const MarkupTag NBSP = 2869039;
	public const MarkupTag SHY = 92674;
	public const MarkupTag LEFT = 2660507;
	public const MarkupTag RIGHT = 99937376;
	public const MarkupTag CENTER = -1591113269;
	public const MarkupTag JUSTIFIED = 817091359;
	public const MarkupTag FLUSH = 85552164;
	public const MarkupTag NONE = 2857034;
	public const MarkupTag PLUS = 43;
	public const MarkupTag MINUS = 45;
	public const MarkupTag PX = 2568;
	public const MarkupTag PLUS_PX = 49507;
	public const MarkupTag MINUS_PX = 47461;
	public const MarkupTag EM = 2216;
	public const MarkupTag PLUS_EM = 49091;
	public const MarkupTag MINUS_EM = 46789;
	public const MarkupTag PCT = 85031;
	public const MarkupTag PLUS_PCT = 1634348;
	public const MarkupTag MINUS_PCT = 1567082;
	public const MarkupTag PERCENTAGE = 37;
	public const MarkupTag PLUS_PERCENTAGE = 1454;
	public const MarkupTag MINUS_PERCENTAGE = 1512;
	public const MarkupTag TRUE = 2932022;
	public const MarkupTag FALSE = 85422813;
	public const MarkupTag INVALID = 1585415185;
	public const MarkupTag NORMAL = -1183493901;
	public const MarkupTag DEFAULT = -620974005;
}

// Namespace: TMPro
public enum TagValueType // TypeDefIndex: 21814
{
	// Fields
	public int value__; // 0x0
	public const TagValueType None = 0;
	public const TagValueType NumericalValue = 1;
	public const TagValueType StringValue = 2;
	public const TagValueType ColorValue = 4;
}

// Namespace: TMPro
public enum TagUnitType // TypeDefIndex: 21815
{
	// Fields
	public int value__; // 0x0
	public const TagUnitType Pixels = 0;
	public const TagUnitType FontUnits = 1;
	public const TagUnitType Percentage = 2;
}

// Namespace: TMPro
internal static class CodePoint // TypeDefIndex: 21816
{
	// Fields
	public const uint SPACE = 32;
	public const uint DOUBLE_QUOTE = 34;
	public const uint NUMBER_SIGN = 35;
	public const uint PERCENTAGE = 37;
	public const uint PLUS = 43;
	public const uint MINUS = 45;
	public const uint PERIOD = 46;
	public const uint HYPHEN_MINUS = 45;
	public const uint SOFT_HYPHEN = 173;
	public const uint HYPHEN = 8208;
	public const uint NON_BREAKING_HYPHEN = 8209;
	public const uint ZERO_WIDTH_SPACE = 8203;
	public const uint RIGHT_SINGLE_QUOTATION = 8217;
	public const uint APOSTROPHE = 39;
	public const uint WORD_JOINER = 8288;
	public const uint HIGH_SURROGATE_START = 55296;
	public const uint HIGH_SURROGATE_END = 56319;
	public const uint LOW_SURROGATE_START = 56320;
	public const uint LOW_SURROGATE_END = 57343;
	public const uint UNICODE_PLANE01_START = 65536;
}

// Namespace: TMPro
public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 21817
{
	// Fields
	public bool isSelected; // 0x20

	// Methods

	// RVA: 0x8696264 Offset: 0x8692264 VA: 0x8696264 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x86962CC Offset: 0x86922CC VA: 0x86962CC Slot: 5
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x8696344 Offset: 0x8692344 VA: 0x8696344 Slot: 6
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x86963B8 Offset: 0x86923B8 VA: 0x86963B8
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent(typeof(CanvasRenderer))]
public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 21818
{
	// Methods

	// RVA: 0x86963C0 Offset: 0x86923C0 VA: 0x86963C0 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x8696490 Offset: 0x8692490 VA: 0x8696490 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x8696494 Offset: 0x8692494 VA: 0x8696494
	public void .ctor() { }
}

// Namespace: 
public class TMP_Settings.LineBreakingTable // TypeDefIndex: 21819
{
	// Fields
	public Dictionary<int, char> leadingCharacters; // 0x10
	public Dictionary<int, char> followingCharacters; // 0x18

	// Methods

	// RVA: 0x8696E28 Offset: 0x8692E28 VA: 0x8696E28
	public void .ctor() { }
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_Settings : ScriptableObject // TypeDefIndex: 21820
{
	// Fields
	private static TMP_Settings s_Instance; // 0x0
	[SerializeField]
	private bool m_enableWordWrapping; // 0x18
	[SerializeField]
	private bool m_enableKerning; // 0x19
	[SerializeField]
	private bool m_enableExtraPadding; // 0x1A
	[SerializeField]
	private bool m_enableTintAllSprites; // 0x1B
	[SerializeField]
	private bool m_enableParseEscapeCharacters; // 0x1C
	[SerializeField]
	private bool m_EnableRaycastTarget; // 0x1D
	[SerializeField]
	private bool m_GetFontFeaturesAtRuntime; // 0x1E
	[SerializeField]
	private int m_missingGlyphCharacter; // 0x20
	[SerializeField]
	private bool m_warningsDisabled; // 0x24
	[SerializeField]
	private TMP_FontAsset m_defaultFontAsset; // 0x28
	[SerializeField]
	private string m_defaultFontAssetPath; // 0x30
	[SerializeField]
	private float m_defaultFontSize; // 0x38
	[SerializeField]
	private float m_defaultAutoSizeMinRatio; // 0x3C
	[SerializeField]
	private float m_defaultAutoSizeMaxRatio; // 0x40
	[SerializeField]
	private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
	[SerializeField]
	private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
	[SerializeField]
	private bool m_autoSizeTextContainer; // 0x54
	[SerializeField]
	private bool m_IsTextObjectScaleStatic; // 0x55
	[SerializeField]
	private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
	[SerializeField]
	private bool m_matchMaterialPreset; // 0x60
	[SerializeField]
	private TMP_SpriteAsset m_defaultSpriteAsset; // 0x68
	[SerializeField]
	private string m_defaultSpriteAssetPath; // 0x70
	[SerializeField]
	private bool m_enableEmojiSupport; // 0x78
	[SerializeField]
	private uint m_MissingCharacterSpriteUnicode; // 0x7C
	[SerializeField]
	private string m_defaultColorGradientPresetsPath; // 0x80
	[SerializeField]
	private TMP_StyleSheet m_defaultStyleSheet; // 0x88
	[SerializeField]
	private string m_StyleSheetsResourcePath; // 0x90
	[SerializeField]
	private TextAsset m_leadingCharacters; // 0x98
	[SerializeField]
	private TextAsset m_followingCharacters; // 0xA0
	[SerializeField]
	private TMP_Settings.LineBreakingTable m_linebreakingRules; // 0xA8
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0xB0

	// Properties
	public static string version { get; }
	public static bool enableWordWrapping { get; }
	public static bool enableKerning { get; }
	public static bool enableExtraPadding { get; }
	public static bool enableTintAllSprites { get; }
	public static bool enableParseEscapeCharacters { get; }
	public static bool enableRaycastTarget { get; }
	public static bool getFontFeaturesAtRuntime { get; }
	public static int missingGlyphCharacter { get; set; }
	public static bool warningsDisabled { get; }
	public static TMP_FontAsset defaultFontAsset { get; }
	public static string defaultFontAssetPath { get; }
	public static float defaultFontSize { get; }
	public static float defaultTextAutoSizingMinRatio { get; }
	public static float defaultTextAutoSizingMaxRatio { get; }
	public static Vector2 defaultTextMeshProTextContainerSize { get; }
	public static Vector2 defaultTextMeshProUITextContainerSize { get; }
	public static bool autoSizeTextContainer { get; }
	public static bool isTextObjectScaleStatic { get; set; }
	public static List<TMP_FontAsset> fallbackFontAssets { get; }
	public static bool matchMaterialPreset { get; }
	public static TMP_SpriteAsset defaultSpriteAsset { get; }
	public static string defaultSpriteAssetPath { get; }
	public static bool enableEmojiSupport { get; set; }
	public static uint missingCharacterSpriteUnicode { get; set; }
	public static string defaultColorGradientPresetsPath { get; }
	public static TMP_StyleSheet defaultStyleSheet { get; }
	public static string styleSheetsResourcePath { get; }
	public static TextAsset leadingCharacters { get; }
	public static TextAsset followingCharacters { get; }
	public static TMP_Settings.LineBreakingTable linebreakingRules { get; }
	public static bool useModernHangulLineBreakingRules { get; set; }
	public static TMP_Settings instance { get; }

	// Methods

	// RVA: 0x869649C Offset: 0x869249C VA: 0x869649C
	public static string get_version() { }

	// RVA: 0x86964DC Offset: 0x86924DC VA: 0x86964DC
	public static bool get_enableWordWrapping() { }

	// RVA: 0x86965D4 Offset: 0x86925D4 VA: 0x86965D4
	public static bool get_enableKerning() { }

	// RVA: 0x86965F0 Offset: 0x86925F0 VA: 0x86965F0
	public static bool get_enableExtraPadding() { }

	// RVA: 0x869660C Offset: 0x869260C VA: 0x869660C
	public static bool get_enableTintAllSprites() { }

	// RVA: 0x8696628 Offset: 0x8692628 VA: 0x8696628
	public static bool get_enableParseEscapeCharacters() { }

	// RVA: 0x8696644 Offset: 0x8692644 VA: 0x8696644
	public static bool get_enableRaycastTarget() { }

	// RVA: 0x8696660 Offset: 0x8692660 VA: 0x8696660
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0x869667C Offset: 0x869267C VA: 0x869667C
	public static int get_missingGlyphCharacter() { }

	// RVA: 0x8696698 Offset: 0x8692698 VA: 0x8696698
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0x86966B8 Offset: 0x86926B8 VA: 0x86966B8
	public static bool get_warningsDisabled() { }

	// RVA: 0x86966D4 Offset: 0x86926D4 VA: 0x86966D4
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0x86966F0 Offset: 0x86926F0 VA: 0x86966F0
	public static string get_defaultFontAssetPath() { }

	// RVA: 0x869670C Offset: 0x869270C VA: 0x869670C
	public static float get_defaultFontSize() { }

	// RVA: 0x8696728 Offset: 0x8692728 VA: 0x8696728
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0x8696744 Offset: 0x8692744 VA: 0x8696744
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0x8696760 Offset: 0x8692760 VA: 0x8696760
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0x869677C Offset: 0x869277C VA: 0x869677C
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0x8696798 Offset: 0x8692798 VA: 0x8696798
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0x86967B4 Offset: 0x86927B4 VA: 0x86967B4
	public static bool get_isTextObjectScaleStatic() { }

	// RVA: 0x86967D0 Offset: 0x86927D0 VA: 0x86967D0
	public static void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x86967F4 Offset: 0x86927F4 VA: 0x86967F4
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x8696810 Offset: 0x8692810 VA: 0x8696810
	public static bool get_matchMaterialPreset() { }

	// RVA: 0x869682C Offset: 0x869282C VA: 0x869682C
	public static TMP_SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x8696848 Offset: 0x8692848 VA: 0x8696848
	public static string get_defaultSpriteAssetPath() { }

	// RVA: 0x8696864 Offset: 0x8692864 VA: 0x8696864
	public static bool get_enableEmojiSupport() { }

	// RVA: 0x8696880 Offset: 0x8692880 VA: 0x8696880
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0x86968A4 Offset: 0x86928A4 VA: 0x86968A4
	public static uint get_missingCharacterSpriteUnicode() { }

	// RVA: 0x86968C0 Offset: 0x86928C0 VA: 0x86968C0
	public static void set_missingCharacterSpriteUnicode(uint value) { }

	// RVA: 0x86968E0 Offset: 0x86928E0 VA: 0x86968E0
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x86968FC Offset: 0x86928FC VA: 0x86968FC
	public static TMP_StyleSheet get_defaultStyleSheet() { }

	// RVA: 0x8696918 Offset: 0x8692918 VA: 0x8696918
	public static string get_styleSheetsResourcePath() { }

	// RVA: 0x8696934 Offset: 0x8692934 VA: 0x8696934
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0x8696950 Offset: 0x8692950 VA: 0x8696950
	public static TextAsset get_followingCharacters() { }

	// RVA: 0x869696C Offset: 0x869296C VA: 0x869696C
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0x8696AD8 Offset: 0x8692AD8 VA: 0x8696AD8
	public static bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x8696AF4 Offset: 0x8692AF4 VA: 0x8696AF4
	public static void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x86964F8 Offset: 0x86924F8 VA: 0x86964F8
	public static TMP_Settings get_instance() { }

	// RVA: 0x8696B18 Offset: 0x8692B18 VA: 0x8696B18
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0x8696C20 Offset: 0x8692C20 VA: 0x8696C20
	public static TMP_Settings GetSettings() { }

	// RVA: 0x8696C9C Offset: 0x8692C9C VA: 0x8696C9C
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0x8696D20 Offset: 0x8692D20 VA: 0x8696D20
	public static TMP_SpriteAsset GetSpriteAsset() { }

	// RVA: 0x8696DA4 Offset: 0x8692DA4 VA: 0x8696DA4
	public static TMP_StyleSheet GetStyleSheet() { }

	// RVA: 0x869699C Offset: 0x869299C VA: 0x869699C
	public static void LoadLinebreakingRules() { }

	// RVA: 0x8696E30 Offset: 0x8692E30 VA: 0x8696E30
	private static Dictionary<int, char> GetCharacters(TextAsset file) { }

	// RVA: 0x8696F54 Offset: 0x8692F54 VA: 0x8696F54
	public void .ctor() { }
}

// Namespace: TMPro
public static class ShaderUtilities // TypeDefIndex: 21821
{
	// Fields
	public static int ID_MainTex; // 0x0
	public static int ID_FaceTex; // 0x4
	public static int ID_FaceColor; // 0x8
	public static int ID_FaceDilate; // 0xC
	public static int ID_Shininess; // 0x10
	public static int ID_UnderlayColor; // 0x14
	public static int ID_UnderlayOffsetX; // 0x18
	public static int ID_UnderlayOffsetY; // 0x1C
	public static int ID_UnderlayDilate; // 0x20
	public static int ID_UnderlaySoftness; // 0x24
	public static int ID_UnderlayOffset; // 0x28
	public static int ID_UnderlayIsoPerimeter; // 0x2C
	public static int ID_WeightNormal; // 0x30
	public static int ID_WeightBold; // 0x34
	public static int ID_OutlineTex; // 0x38
	public static int ID_OutlineWidth; // 0x3C
	public static int ID_OutlineSoftness; // 0x40
	public static int ID_OutlineColor; // 0x44
	public static int ID_Outline2Color; // 0x48
	public static int ID_Outline2Width; // 0x4C
	public static int ID_Padding; // 0x50
	public static int ID_GradientScale; // 0x54
	public static int ID_ScaleX; // 0x58
	public static int ID_ScaleY; // 0x5C
	public static int ID_PerspectiveFilter; // 0x60
	public static int ID_Sharpness; // 0x64
	public static int ID_TextureWidth; // 0x68
	public static int ID_TextureHeight; // 0x6C
	public static int ID_BevelAmount; // 0x70
	public static int ID_GlowColor; // 0x74
	public static int ID_GlowOffset; // 0x78
	public static int ID_GlowPower; // 0x7C
	public static int ID_GlowOuter; // 0x80
	public static int ID_GlowInner; // 0x84
	public static int ID_LightAngle; // 0x88
	public static int ID_EnvMap; // 0x8C
	public static int ID_EnvMatrix; // 0x90
	public static int ID_EnvMatrixRotation; // 0x94
	public static int ID_MaskCoord; // 0x98
	public static int ID_ClipRect; // 0x9C
	public static int ID_MaskSoftnessX; // 0xA0
	public static int ID_MaskSoftnessY; // 0xA4
	public static int ID_VertexOffsetX; // 0xA8
	public static int ID_VertexOffsetY; // 0xAC
	public static int ID_UseClipRect; // 0xB0
	public static int ID_StencilID; // 0xB4
	public static int ID_StencilOp; // 0xB8
	public static int ID_StencilComp; // 0xBC
	public static int ID_StencilReadMask; // 0xC0
	public static int ID_StencilWriteMask; // 0xC4
	public static int ID_ShaderFlags; // 0xC8
	public static int ID_ScaleRatio_A; // 0xCC
	public static int ID_ScaleRatio_B; // 0xD0
	public static int ID_ScaleRatio_C; // 0xD4
	public static string Keyword_Bevel; // 0xD8
	public static string Keyword_Glow; // 0xE0
	public static string Keyword_Underlay; // 0xE8
	public static string Keyword_Ratios; // 0xF0
	public static string Keyword_MASK_SOFT; // 0xF8
	public static string Keyword_MASK_HARD; // 0x100
	public static string Keyword_MASK_TEX; // 0x108
	public static string Keyword_Outline; // 0x110
	public static string ShaderTag_ZTestMode; // 0x118
	public static string ShaderTag_CullMode; // 0x120
	private static float m_clamp; // 0x128
	public static bool isInitialized; // 0x12C
	private static Shader k_ShaderRef_MobileSDF; // 0x130
	private static Shader k_ShaderRef_MobileBitmap; // 0x138

	// Properties
	internal static Shader ShaderRef_MobileSDF { get; }
	internal static Shader ShaderRef_MobileBitmap { get; }

	// Methods

	// RVA: 0x8696F64 Offset: 0x8692F64 VA: 0x8696F64
	internal static Shader get_ShaderRef_MobileSDF() { }

	// RVA: 0x8697064 Offset: 0x8693064 VA: 0x8697064
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x8697164 Offset: 0x8693164 VA: 0x8697164
	private static void .cctor() { }

	// RVA: 0x869055C Offset: 0x868C55C VA: 0x869055C
	public static void GetShaderPropertyIDs() { }

	// RVA: 0x8697378 Offset: 0x8693378 VA: 0x8697378
	public static void UpdateShaderRatios(Material mat) { }

	// RVA: 0x86977D4 Offset: 0x86937D4 VA: 0x86977D4
	public static Vector4 GetFontExtent(Material material) { }

	// RVA: 0x8697818 Offset: 0x8693818 VA: 0x8697818
	public static bool IsMaskingEnabled(Material material) { }

	// RVA: 0x86979B4 Offset: 0x86939B4 VA: 0x86979B4
	public static float GetPadding(Material material, bool enableExtraPadding, bool isBold) { }

	// RVA: 0x869805C Offset: 0x869405C VA: 0x869805C
	public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Sprite : TMP_TextElement_Legacy // TypeDefIndex: 21822
{
	// Fields
	public string name; // 0x38
	public int hashCode; // 0x40
	public int unicode; // 0x44
	public Vector2 pivot; // 0x48
	public Sprite sprite; // 0x50

	// Methods

	// RVA: 0x869894C Offset: 0x869494C VA: 0x869894C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_SpriteAnimator.<DoSpriteAnimationInternal>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 21823
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_SpriteAnimator <>4__this; // 0x20
	public int start; // 0x28
	public int end; // 0x2C
	public TMP_SpriteAsset spriteAsset; // 0x30
	public int currentCharacter; // 0x38
	public int framerate; // 0x3C
	private int <currentFrame>5__2; // 0x40
	private TMP_CharacterInfo <charInfo>5__3; // 0x48
	private int <materialIndex>5__4; // 0x1C0
	private int <vertexIndex>5__5; // 0x1C4
	private TMP_MeshInfo <meshInfo>5__6; // 0x1C8
	private float <baseSpriteScale>5__7; // 0x218
	private float <elapsedTime>5__8; // 0x21C
	private float <targetTime>5__9; // 0x220

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x8698BB4 Offset: 0x8694BB4 VA: 0x8698BB4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x8698C68 Offset: 0x8694C68 VA: 0x8698C68 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8698C6C Offset: 0x8694C6C VA: 0x8698C6C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x86995D4 Offset: 0x86955D4 VA: 0x86995D4 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x86995DC Offset: 0x86955DC VA: 0x86995DC Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x8699614 Offset: 0x8695614 VA: 0x8699614 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: TMPro
[DisallowMultipleComponent]
public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 21824
{
	// Fields
	private Dictionary<int, bool> m_animations; // 0x20
	private TMP_Text m_TextComponent; // 0x28

	// Methods

	// RVA: 0x869895C Offset: 0x869495C VA: 0x869895C
	private void Awake() { }

	// RVA: 0x86989B4 Offset: 0x86949B4 VA: 0x86989B4
	private void OnEnable() { }

	// RVA: 0x86989B8 Offset: 0x86949B8 VA: 0x86989B8
	private void OnDisable() { }

	// RVA: 0x86989BC Offset: 0x86949BC VA: 0x86989BC
	public void StopAllAnimations() { }

	// RVA: 0x8698A18 Offset: 0x8694A18 VA: 0x8698A18
	public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[IteratorStateMachine(typeof(TMP_SpriteAnimator.<DoSpriteAnimationInternal>d__7))]
	// RVA: 0x8698B00 Offset: 0x8694B00 VA: 0x8698B00
	private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	// RVA: 0x8698BDC Offset: 0x8694BDC VA: 0x8698BDC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TMP_SpriteAsset.<>c // TypeDefIndex: 21825
{
	// Fields
	public static readonly TMP_SpriteAsset.<>c <>9; // 0x0
	public static Func<TMP_SpriteGlyph, uint> <>9__40_0; // 0x8
	public static Func<TMP_SpriteCharacter, uint> <>9__41_0; // 0x10

	// Methods

	// RVA: 0x869B2CC Offset: 0x86972CC VA: 0x869B2CC
	private static void .cctor() { }

	// RVA: 0x869B334 Offset: 0x8697334 VA: 0x869B334
	public void .ctor() { }

	// RVA: 0x869B33C Offset: 0x869733C VA: 0x869B33C
	internal uint <SortGlyphTable>b__40_0(TMP_SpriteGlyph item) { }

	// RVA: 0x869B354 Offset: 0x8697354 VA: 0x869B354
	internal uint <SortCharacterTable>b__41_0(TMP_SpriteCharacter c) { }
}

// Namespace: TMPro
[ExcludeFromPreset]
public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 21826
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x30
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x38
	[SerializeField]
	private string m_Version; // 0x40
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x48
	public Texture spriteSheet; // 0xA8
	[SerializeField]
	private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xB0
	internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
	[SerializeField]
	private List<TMP_SpriteGlyph> m_SpriteGlyphTable; // 0xC0
	internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
	public List<TMP_Sprite> spriteInfoList; // 0xD0
	[SerializeField]
	public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0xD8
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public string version { get; set; }
	public FaceInfo faceInfo { get; set; }
	public List<TMP_SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<TMP_SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x869961C Offset: 0x869561C VA: 0x869961C
	public string get_version() { }

	// RVA: 0x8699624 Offset: 0x8695624 VA: 0x8699624
	internal void set_version(string value) { }

	// RVA: 0x869962C Offset: 0x869562C VA: 0x869962C
	public FaceInfo get_faceInfo() { }

	// RVA: 0x869963C Offset: 0x869563C VA: 0x869963C
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x86995B0 Offset: 0x86955B0 VA: 0x86995B0
	public List<TMP_SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x8699BB8 Offset: 0x8695BB8 VA: 0x8699BB8
	internal void set_spriteCharacterTable(List<TMP_SpriteCharacter> value) { }

	// RVA: 0x8699BC0 Offset: 0x8695BC0 VA: 0x8699BC0
	public Dictionary<uint, TMP_SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x8699BE4 Offset: 0x8695BE4 VA: 0x8699BE4
	internal void set_spriteCharacterLookupTable(Dictionary<uint, TMP_SpriteCharacter> value) { }

	// RVA: 0x8699BEC Offset: 0x8695BEC VA: 0x8699BEC
	public List<TMP_SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x8699BF4 Offset: 0x8695BF4 VA: 0x8699BF4
	internal void set_spriteGlyphTable(List<TMP_SpriteGlyph> value) { }

	// RVA: 0x8699BFC Offset: 0x8695BFC VA: 0x8699BFC
	private void Awake() { }

	// RVA: 0x869A194 Offset: 0x8696194 VA: 0x869A194
	private Material GetDefaultSpriteMaterial() { }

	// RVA: 0x8699660 Offset: 0x8695660 VA: 0x8699660
	public void UpdateLookupTables() { }

	// RVA: 0x869A27C Offset: 0x869627C VA: 0x869A27C
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x869A304 Offset: 0x8696304 VA: 0x869A304
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x869A398 Offset: 0x8696398 VA: 0x869A398
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x869A478 Offset: 0x8696478 VA: 0x869A478
	public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x869A6AC Offset: 0x86966AC VA: 0x869A6AC
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x869A84C Offset: 0x869684C VA: 0x869A84C
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x869A8FC Offset: 0x86968FC VA: 0x869A8FC
	public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x869AC28 Offset: 0x8696C28 VA: 0x869AC28
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x869ADC8 Offset: 0x8696DC8 VA: 0x869ADC8
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x869AE78 Offset: 0x8696E78 VA: 0x869AE78
	public void SortGlyphTable() { }

	// RVA: 0x869AFC8 Offset: 0x8696FC8 VA: 0x869AFC8
	internal void SortCharacterTable() { }

	// RVA: 0x869B11C Offset: 0x869711C VA: 0x869B11C
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x8699C84 Offset: 0x8695C84 VA: 0x8699C84
	private void UpgradeSpriteAsset() { }

	// RVA: 0x869B1F0 Offset: 0x86971F0 VA: 0x869B1F0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 21827
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x30
	[SerializeField]
	private int m_HashCode; // 0x38

	// Properties
	public string name { get; set; }
	public int hashCode { get; }

	// Methods

	// RVA: 0x869B36C Offset: 0x869736C VA: 0x869B36C
	public string get_name() { }

	// RVA: 0x869B15C Offset: 0x869715C VA: 0x869B15C
	public void set_name(string value) { }

	// RVA: 0x869B3E0 Offset: 0x86973E0 VA: 0x869B3E0
	public int get_hashCode() { }

	// RVA: 0x869B13C Offset: 0x869713C VA: 0x869B13C
	public void .ctor() { }

	// RVA: 0x869B3F0 Offset: 0x86973F0 VA: 0x869B3F0
	public void .ctor(uint unicode, TMP_SpriteGlyph glyph) { }

	// RVA: 0x869B454 Offset: 0x8697454 VA: 0x869B454
	public void .ctor(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph) { }

	// RVA: 0x869B4D0 Offset: 0x86974D0 VA: 0x869B4D0
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_SpriteGlyph : Glyph // TypeDefIndex: 21828
{
	// Fields
	public Sprite sprite; // 0x48

	// Methods

	// RVA: 0x869B134 Offset: 0x8697134 VA: 0x869B134
	public void .ctor() { }

	// RVA: 0x869B52C Offset: 0x869752C VA: 0x869B52C
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	// RVA: 0x869B5E8 Offset: 0x86975E8 VA: 0x869B5E8
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Style // TypeDefIndex: 21829
{
	// Fields
	internal static TMP_Style k_NormalStyle; // 0x0
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private int m_HashCode; // 0x18
	[SerializeField]
	private string m_OpeningDefinition; // 0x20
	[SerializeField]
	private string m_ClosingDefinition; // 0x28
	[SerializeField]
	private int[] m_OpeningTagArray; // 0x30
	[SerializeField]
	private int[] m_ClosingTagArray; // 0x38
	[SerializeField]
	internal uint[] m_OpeningTagUnicodeArray; // 0x40
	[SerializeField]
	internal uint[] m_ClosingTagUnicodeArray; // 0x48

	// Properties
	public static TMP_Style NormalStyle { get; }
	public string name { get; set; }
	public int hashCode { get; set; }
	public string styleOpeningDefinition { get; }
	public string styleClosingDefinition { get; }
	public int[] styleOpeningTagArray { get; }
	public int[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x869B6B8 Offset: 0x86976B8 VA: 0x869B6B8
	public static TMP_Style get_NormalStyle() { }

	// RVA: 0x869B834 Offset: 0x8697834 VA: 0x869B834
	public string get_name() { }

	// RVA: 0x869B83C Offset: 0x869783C VA: 0x869B83C
	public void set_name(string value) { }

	// RVA: 0x869B888 Offset: 0x8697888 VA: 0x869B888
	public int get_hashCode() { }

	// RVA: 0x869B890 Offset: 0x8697890 VA: 0x869B890
	public void set_hashCode(int value) { }

	// RVA: 0x869B8A4 Offset: 0x86978A4 VA: 0x869B8A4
	public string get_styleOpeningDefinition() { }

	// RVA: 0x869B8AC Offset: 0x86978AC VA: 0x869B8AC
	public string get_styleClosingDefinition() { }

	// RVA: 0x869B8B4 Offset: 0x86978B4 VA: 0x869B8B4
	public int[] get_styleOpeningTagArray() { }

	// RVA: 0x869B8BC Offset: 0x86978BC VA: 0x869B8BC
	public int[] get_styleClosingTagArray() { }

	// RVA: 0x869B77C Offset: 0x869777C VA: 0x869B77C
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x869B980 Offset: 0x8697980 VA: 0x869B980
	public void RefreshStyle() { }
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 21830
{
	// Fields
	[SerializeField]
	private List<TMP_Style> m_StyleList; // 0x18
	private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20

	// Properties
	internal List<TMP_Style> styles { get; }

	// Methods

	// RVA: 0x869BBA8 Offset: 0x8697BA8 VA: 0x869BBA8
	internal List<TMP_Style> get_styles() { }

	// RVA: 0x869BBB0 Offset: 0x8697BB0 VA: 0x869BBB0
	private void Reset() { }

	// RVA: 0x869BEDC Offset: 0x8697EDC VA: 0x869BEDC
	public TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x869BF64 Offset: 0x8697F64 VA: 0x869BF64
	public TMP_Style GetStyle(string name) { }

	// RVA: 0x869C01C Offset: 0x869801C VA: 0x869C01C
	public void RefreshStyles() { }

	// RVA: 0x869BBB4 Offset: 0x8697BB4 VA: 0x869BBB4
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x869C020 Offset: 0x8698020 VA: 0x869C020
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent(typeof(MeshRenderer))]
[ExecuteAlways]
public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 21831
{
	// Fields
	[SerializeField]
	private TMP_FontAsset m_fontAsset; // 0x20
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; // 0x28
	[SerializeField]
	private Material m_material; // 0x30
	[SerializeField]
	private Material m_sharedMaterial; // 0x38
	private Material m_fallbackMaterial; // 0x40
	private Material m_fallbackSourceMaterial; // 0x48
	[SerializeField]
	private bool m_isDefaultMaterial; // 0x50
	[SerializeField]
	private float m_padding; // 0x54
	[SerializeField]
	private Renderer m_renderer; // 0x58
	private MeshFilter m_meshFilter; // 0x60
	private Mesh m_mesh; // 0x68
	[SerializeField]
	private TextMeshPro m_TextComponent; // 0x70
	private bool m_isRegisteredForEvents; // 0x78

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Renderer renderer { get; }
	public MeshFilter meshFilter { get; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x869C0AC Offset: 0x86980AC VA: 0x869C0AC
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x869C0B4 Offset: 0x86980B4 VA: 0x869C0B4
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x869C0BC Offset: 0x86980BC VA: 0x869C0BC
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x869C0C4 Offset: 0x86980C4 VA: 0x869C0C4
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x869C0CC Offset: 0x86980CC VA: 0x869C0CC
	public Material get_material() { }

	// RVA: 0x869C224 Offset: 0x8698224 VA: 0x869C224
	public void set_material(Material value) { }

	// RVA: 0x869C3EC Offset: 0x86983EC VA: 0x869C3EC
	public Material get_sharedMaterial() { }

	// RVA: 0x869C3F4 Offset: 0x86983F4 VA: 0x869C3F4
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x869C420 Offset: 0x8698420 VA: 0x869C420
	public Material get_fallbackMaterial() { }

	// RVA: 0x869C428 Offset: 0x8698428 VA: 0x869C428
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x869C570 Offset: 0x8698570 VA: 0x869C570
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x869C578 Offset: 0x8698578 VA: 0x869C578
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x869C580 Offset: 0x8698580 VA: 0x869C580
	public bool get_isDefaultMaterial() { }

	// RVA: 0x869C588 Offset: 0x8698588 VA: 0x869C588
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x869C594 Offset: 0x8698594 VA: 0x869C594
	public float get_padding() { }

	// RVA: 0x869C59C Offset: 0x869859C VA: 0x869C59C
	public void set_padding(float value) { }

	// RVA: 0x869C5A4 Offset: 0x86985A4 VA: 0x869C5A4
	public Renderer get_renderer() { }

	// RVA: 0x869C64C Offset: 0x869864C VA: 0x869C64C
	public MeshFilter get_meshFilter() { }

	// RVA: 0x869C770 Offset: 0x8698770 VA: 0x869C770
	public Mesh get_mesh() { }

	// RVA: 0x869C82C Offset: 0x869882C VA: 0x869C82C
	public void set_mesh(Mesh value) { }

	// RVA: 0x869C834 Offset: 0x8698834 VA: 0x869C834
	public TMP_Text get_textComponent() { }

	// RVA: 0x869C8DC Offset: 0x86988DC VA: 0x869C8DC
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0x869CCB8 Offset: 0x8698CB8 VA: 0x869CCB8
	private void OnEnable() { }

	// RVA: 0x869CDE4 Offset: 0x8698DE4 VA: 0x869CDE4
	private void OnDisable() { }

	// RVA: 0x869CEAC Offset: 0x8698EAC VA: 0x869CEAC
	private void OnDestroy() { }

	// RVA: 0x869D010 Offset: 0x8699010 VA: 0x869D010
	public void DestroySelf() { }

	// RVA: 0x869C0D4 Offset: 0x86980D4 VA: 0x869C0D4
	private Material GetMaterial(Material mat) { }

	// RVA: 0x869D080 Offset: 0x8699080 VA: 0x869D080
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x869D140 Offset: 0x8699140 VA: 0x869D140
	private Material GetSharedMaterial() { }

	// RVA: 0x869C3F8 Offset: 0x86983F8 VA: 0x869C3F8
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x869C2C4 Offset: 0x86982C4 VA: 0x869C2C4
	public float GetPaddingForMaterial() { }

	// RVA: 0x869D1F4 Offset: 0x86991F4 VA: 0x869D1F4
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x869C338 Offset: 0x8698338 VA: 0x869C338
	public void SetVerticesDirty() { }

	// RVA: 0x869C3E8 Offset: 0x86983E8 VA: 0x869C3E8
	public void SetMaterialDirty() { }

	// RVA: 0x869D268 Offset: 0x8699268 VA: 0x869D268
	protected void UpdateMaterial() { }

	// RVA: 0x869D3D8 Offset: 0x86993D8 VA: 0x869D3D8
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent(typeof(CanvasRenderer))]
[ExecuteAlways]
public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 21832
{
	// Fields
	[SerializeField]
	private TMP_FontAsset m_fontAsset; // 0xD8
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; // 0xE0
	[SerializeField]
	private Material m_material; // 0xE8
	[SerializeField]
	private Material m_sharedMaterial; // 0xF0
	private Material m_fallbackMaterial; // 0xF8
	private Material m_fallbackSourceMaterial; // 0x100
	[SerializeField]
	private bool m_isDefaultMaterial; // 0x108
	[SerializeField]
	private float m_padding; // 0x10C
	private Mesh m_mesh; // 0x110
	[SerializeField]
	private TextMeshProUGUI m_TextComponent; // 0x118
	private bool m_isRegisteredForEvents; // 0x120
	private bool m_materialDirty; // 0x121
	[SerializeField]
	private int m_materialReferenceIndex; // 0x124
	private Transform m_RootCanvasTransform; // 0x128

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public override Texture mainTexture { get; }
	public override Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public override Material materialForRendering { get; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x869D3E0 Offset: 0x86993E0 VA: 0x869D3E0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x869D3E8 Offset: 0x86993E8 VA: 0x869D3E8
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x869D3F0 Offset: 0x86993F0 VA: 0x869D3F0
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x869D3F8 Offset: 0x86993F8 VA: 0x869D3F8
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x869D400 Offset: 0x8699400 VA: 0x869D400 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x869D4BC Offset: 0x86994BC VA: 0x869D4BC Slot: 32
	public override Material get_material() { }

	// RVA: 0x869D5D0 Offset: 0x86995D0 VA: 0x869D5D0 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x869D74C Offset: 0x869974C VA: 0x869D74C
	public Material get_sharedMaterial() { }

	// RVA: 0x869D754 Offset: 0x8699754 VA: 0x869D754
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x869D7AC Offset: 0x86997AC VA: 0x869D7AC
	public Material get_fallbackMaterial() { }

	// RVA: 0x869D7B4 Offset: 0x86997B4 VA: 0x869D7B4
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x869D8FC Offset: 0x86998FC VA: 0x869D8FC
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x869D904 Offset: 0x8699904 VA: 0x869D904
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x869D914 Offset: 0x8699914 VA: 0x869D914 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x869D970 Offset: 0x8699970 VA: 0x869D970
	public bool get_isDefaultMaterial() { }

	// RVA: 0x869D978 Offset: 0x8699978 VA: 0x869D978
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x869D984 Offset: 0x8699984 VA: 0x869D984
	public float get_padding() { }

	// RVA: 0x869D98C Offset: 0x869998C VA: 0x869D98C
	public void set_padding(float value) { }

	// RVA: 0x869D994 Offset: 0x8699994 VA: 0x869D994
	public Mesh get_mesh() { }

	// RVA: 0x869DA54 Offset: 0x8699A54 VA: 0x869DA54
	public void set_mesh(Mesh value) { }

	// RVA: 0x869DA64 Offset: 0x8699A64 VA: 0x869DA64
	public TMP_Text get_textComponent() { }

	// RVA: 0x869DB04 Offset: 0x8699B04 VA: 0x869DB04
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0x869DEC0 Offset: 0x8699EC0 VA: 0x869DEC0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x869DF30 Offset: 0x8699F30 VA: 0x869DF30 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x869DFEC Offset: 0x8699FEC VA: 0x869DFEC Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x869E1A8 Offset: 0x869A1A8 VA: 0x869E1A8 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x869E1FC Offset: 0x869A1FC VA: 0x869E1FC Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x869D6D8 Offset: 0x86996D8 VA: 0x869D6D8
	public float GetPaddingForMaterial() { }

	// RVA: 0x869E30C Offset: 0x869A30C VA: 0x869E30C
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x869E380 Offset: 0x869A380 VA: 0x869E380
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x869E3F4 Offset: 0x869A3F4 VA: 0x869E3F4 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x869E3F8 Offset: 0x869A3F8 VA: 0x869E3F8 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x869E4AC Offset: 0x869A4AC VA: 0x869E4AC Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x869E4B0 Offset: 0x869A4B0 VA: 0x869E4B0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x869E4F4 Offset: 0x869A4F4 VA: 0x869E4F4
	public void SetPivotDirty() { }

	// RVA: 0x869E55C Offset: 0x869A55C VA: 0x869E55C
	private Transform GetRootCanvasTransform() { }

	// RVA: 0x869E608 Offset: 0x869A608 VA: 0x869E608 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x869E60C Offset: 0x869A60C VA: 0x869E60C Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x869E610 Offset: 0x869A610 VA: 0x869E610 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x869E648 Offset: 0x869A648 VA: 0x869E648
	public void RefreshMaterial() { }

	// RVA: 0x869E658 Offset: 0x869A658 VA: 0x869E658 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x869E7D8 Offset: 0x869A7D8 VA: 0x869E7D8 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x869E7E0 Offset: 0x869A7E0 VA: 0x869E7E0
	private Material GetMaterial() { }

	// RVA: 0x869D4C4 Offset: 0x86994C4 VA: 0x869D4C4
	private Material GetMaterial(Material mat) { }

	// RVA: 0x869E7E8 Offset: 0x869A7E8 VA: 0x869E7E8
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x869E8A8 Offset: 0x869A8A8 VA: 0x869E8A8
	private Material GetSharedMaterial() { }

	// RVA: 0x869D758 Offset: 0x8699758 VA: 0x869D758
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x869E8C8 Offset: 0x869A8C8 VA: 0x869E8C8
	public void .ctor() { }
}

// Namespace: TMPro
public interface ITextElement // TypeDefIndex: 21833
{
	// Properties
	public abstract Material sharedMaterial { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material get_sharedMaterial();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Rebuild(CanvasUpdate update);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int GetInstanceID();
}

// Namespace: TMPro
public enum TextAlignmentOptions // TypeDefIndex: 21834
{
	// Fields
	public int value__; // 0x0
	public const TextAlignmentOptions TopLeft = 257;
	public const TextAlignmentOptions Top = 258;
	public const TextAlignmentOptions TopRight = 260;
	public const TextAlignmentOptions TopJustified = 264;
	public const TextAlignmentOptions TopFlush = 272;
	public const TextAlignmentOptions TopGeoAligned = 288;
	public const TextAlignmentOptions Left = 513;
	public const TextAlignmentOptions Center = 514;
	public const TextAlignmentOptions Right = 516;
	public const TextAlignmentOptions Justified = 520;
	public const TextAlignmentOptions Flush = 528;
	public const TextAlignmentOptions CenterGeoAligned = 544;
	public const TextAlignmentOptions BottomLeft = 1025;
	public const TextAlignmentOptions Bottom = 1026;
	public const TextAlignmentOptions BottomRight = 1028;
	public const TextAlignmentOptions BottomJustified = 1032;
	public const TextAlignmentOptions BottomFlush = 1040;
	public const TextAlignmentOptions BottomGeoAligned = 1056;
	public const TextAlignmentOptions BaselineLeft = 2049;
	public const TextAlignmentOptions Baseline = 2050;
	public const TextAlignmentOptions BaselineRight = 2052;
	public const TextAlignmentOptions BaselineJustified = 2056;
	public const TextAlignmentOptions BaselineFlush = 2064;
	public const TextAlignmentOptions BaselineGeoAligned = 2080;
	public const TextAlignmentOptions MidlineLeft = 4097;
	public const TextAlignmentOptions Midline = 4098;
	public const TextAlignmentOptions MidlineRight = 4100;
	public const TextAlignmentOptions MidlineJustified = 4104;
	public const TextAlignmentOptions MidlineFlush = 4112;
	public const TextAlignmentOptions MidlineGeoAligned = 4128;
	public const TextAlignmentOptions CaplineLeft = 8193;
	public const TextAlignmentOptions Capline = 8194;
	public const TextAlignmentOptions CaplineRight = 8196;
	public const TextAlignmentOptions CaplineJustified = 8200;
	public const TextAlignmentOptions CaplineFlush = 8208;
	public const TextAlignmentOptions CaplineGeoAligned = 8224;
	public const TextAlignmentOptions Converted = 65535;
}

// Namespace: TMPro
public enum HorizontalAlignmentOptions // TypeDefIndex: 21835
{
	// Fields
	public int value__; // 0x0
	public const HorizontalAlignmentOptions Left = 1;
	public const HorizontalAlignmentOptions Center = 2;
	public const HorizontalAlignmentOptions Right = 4;
	public const HorizontalAlignmentOptions Justified = 8;
	public const HorizontalAlignmentOptions Flush = 16;
	public const HorizontalAlignmentOptions Geometry = 32;
}

// Namespace: TMPro
public enum VerticalAlignmentOptions // TypeDefIndex: 21836
{
	// Fields
	public int value__; // 0x0
	public const VerticalAlignmentOptions Top = 256;
	public const VerticalAlignmentOptions Middle = 512;
	public const VerticalAlignmentOptions Bottom = 1024;
	public const VerticalAlignmentOptions Baseline = 2048;
	public const VerticalAlignmentOptions Geometry = 4096;
	public const VerticalAlignmentOptions Capline = 8192;
}

// Namespace: TMPro
public enum TextRenderFlags // TypeDefIndex: 21837
{
	// Fields
	public int value__; // 0x0
	public const TextRenderFlags DontRender = 0;
	public const TextRenderFlags Render = 255;
}

// Namespace: TMPro
public enum TMP_TextElementType // TypeDefIndex: 21838
{
	// Fields
	public int value__; // 0x0
	public const TMP_TextElementType Character = 0;
	public const TMP_TextElementType Sprite = 1;
}

// Namespace: TMPro
public enum MaskingTypes // TypeDefIndex: 21839
{
	// Fields
	public int value__; // 0x0
	public const MaskingTypes MaskOff = 0;
	public const MaskingTypes MaskHard = 1;
	public const MaskingTypes MaskSoft = 2;
}

// Namespace: TMPro
public enum TextOverflowModes // TypeDefIndex: 21840
{
	// Fields
	public int value__; // 0x0
	public const TextOverflowModes Overflow = 0;
	public const TextOverflowModes Ellipsis = 1;
	public const TextOverflowModes Masking = 2;
	public const TextOverflowModes Truncate = 3;
	public const TextOverflowModes ScrollRect = 4;
	public const TextOverflowModes Page = 5;
	public const TextOverflowModes Linked = 6;
}

// Namespace: TMPro
public enum MaskingOffsetMode // TypeDefIndex: 21841
{
	// Fields
	public int value__; // 0x0
	public const MaskingOffsetMode Percentage = 0;
	public const MaskingOffsetMode Pixel = 1;
}

// Namespace: TMPro
public enum TextureMappingOptions // TypeDefIndex: 21842
{
	// Fields
	public int value__; // 0x0
	public const TextureMappingOptions Character = 0;
	public const TextureMappingOptions Line = 1;
	public const TextureMappingOptions Paragraph = 2;
	public const TextureMappingOptions MatchAspect = 3;
}

// Namespace: TMPro
[Flags]
public enum FontStyles // TypeDefIndex: 21843
{
	// Fields
	public int value__; // 0x0
	public const FontStyles Normal = 0;
	public const FontStyles Bold = 1;
	public const FontStyles Italic = 2;
	public const FontStyles Underline = 4;
	public const FontStyles LowerCase = 8;
	public const FontStyles UpperCase = 16;
	public const FontStyles SmallCaps = 32;
	public const FontStyles Strikethrough = 64;
	public const FontStyles Superscript = 128;
	public const FontStyles Subscript = 256;
	public const FontStyles Highlight = 512;
}

// Namespace: TMPro
public enum FontWeight // TypeDefIndex: 21844
{
	// Fields
	public int value__; // 0x0
	public const FontWeight Thin = 100;
	public const FontWeight ExtraLight = 200;
	public const FontWeight Light = 300;
	public const FontWeight Regular = 400;
	public const FontWeight Medium = 500;
	public const FontWeight SemiBold = 600;
	public const FontWeight Bold = 700;
	public const FontWeight Heavy = 800;
	public const FontWeight Black = 900;
}

// Namespace: 
protected struct TMP_Text.CharacterSubstitution // TypeDefIndex: 21845
{
	// Fields
	public int index; // 0x0
	public uint unicode; // 0x4

	// Methods

	// RVA: 0x869E8D0 Offset: 0x869A8D0 VA: 0x869E8D0
	public void .ctor(int index, uint unicode) { }
}

// Namespace: 
internal enum TMP_Text.TextInputSources // TypeDefIndex: 21846
{
	// Fields
	public int value__; // 0x0
	public const TMP_Text.TextInputSources TextInputBox = 0;
	public const TMP_Text.TextInputSources SetText = 1;
	public const TMP_Text.TextInputSources SetTextArray = 2;
	public const TMP_Text.TextInputSources TextString = 3;
}

// Namespace: 
[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
internal struct TMP_Text.UnicodeChar // TypeDefIndex: 21847
{
	// Fields
	public int unicode; // 0x0
	public int stringIndex; // 0x4
	public int length; // 0x8
}

// Namespace: 
protected struct TMP_Text.SpecialCharacter // TypeDefIndex: 21848
{
	// Fields
	public TMP_Character character; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public Material material; // 0x10
	public int materialIndex; // 0x18

	// Methods

	// RVA: 0x869E8D8 Offset: 0x869A8D8 VA: 0x869E8D8
	public void .ctor(TMP_Character character, int materialIndex) { }
}

// Namespace: 
[DefaultMember("Item")]
private struct TMP_Text.TextBackingContainer // TypeDefIndex: 21849
{
	// Fields
	private uint[] m_Array; // 0x0
	private int m_Count; // 0x8

	// Properties
	public int Capacity { get; }
	public int Count { get; set; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x869EA24 Offset: 0x869AA24 VA: 0x869EA24
	public int get_Capacity() { }

	// RVA: 0x869EA40 Offset: 0x869AA40 VA: 0x869EA40
	public int get_Count() { }

	// RVA: 0x869EA48 Offset: 0x869AA48 VA: 0x869EA48
	public void set_Count(int value) { }

	// RVA: 0x869EA50 Offset: 0x869AA50 VA: 0x869EA50
	public uint get_Item(int index) { }

	// RVA: 0x869EA80 Offset: 0x869AA80 VA: 0x869EA80
	public void set_Item(int index, uint value) { }

	// RVA: 0x869EB44 Offset: 0x869AB44 VA: 0x869EB44
	public void .ctor(int size) { }

	// RVA: 0x869EAE0 Offset: 0x869AAE0 VA: 0x869EAE0
	public void Resize(int size) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TMP_Text.<>c // TypeDefIndex: 21850
{
	// Fields
	public static readonly TMP_Text.<>c <>9; // 0x0
	public static Action<TMP_TextInfo> <>9__622_0; // 0x8

	// Methods

	// RVA: 0x869EBB0 Offset: 0x869ABB0 VA: 0x869EBB0
	private static void .cctor() { }

	// RVA: 0x869EC18 Offset: 0x869AC18 VA: 0x869EC18
	public void .ctor() { }

	// RVA: 0x869EC20 Offset: 0x869AC20 VA: 0x869EC20
	internal void <.ctor>b__622_0(TMP_TextInfo <p0>) { }
}

// Namespace: TMPro
public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 21851
{
	// Fields
	[TextArea(5, 10)]
	[SerializeField]
	protected string m_text; // 0xD8
	private bool m_IsTextBackingStringDirty; // 0xE0
	[SerializeField]
	protected ITextPreprocessor m_TextPreprocessor; // 0xE8
	[SerializeField]
	protected bool m_isRightToLeft; // 0xF0
	[SerializeField]
	protected TMP_FontAsset m_fontAsset; // 0xF8
	protected TMP_FontAsset m_currentFontAsset; // 0x100
	protected bool m_isSDFShader; // 0x108
	[SerializeField]
	protected Material m_sharedMaterial; // 0x110
	protected Material m_currentMaterial; // 0x118
	protected static MaterialReference[] m_materialReferences; // 0x0
	protected static Dictionary<int, int> m_materialReferenceIndexLookup; // 0x8
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x10
	protected int m_currentMaterialIndex; // 0x120
	[SerializeField]
	protected Material[] m_fontSharedMaterials; // 0x128
	[SerializeField]
	protected Material m_fontMaterial; // 0x130
	[SerializeField]
	protected Material[] m_fontMaterials; // 0x138
	protected bool m_isMaterialDirty; // 0x140
	[SerializeField]
	protected Color32 m_fontColor32; // 0x144
	[SerializeField]
	protected Color m_fontColor; // 0x148
	protected static Color32 s_colorWhite; // 0x68
	protected Color32 m_underlineColor; // 0x158
	protected Color32 m_strikethroughColor; // 0x15C
	[SerializeField]
	protected bool m_enableVertexGradient; // 0x160
	[SerializeField]
	protected ColorMode m_colorMode; // 0x164
	[SerializeField]
	protected VertexGradient m_fontColorGradient; // 0x168
	[SerializeField]
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1A8
	[SerializeField]
	protected TMP_SpriteAsset m_spriteAsset; // 0x1B0
	[SerializeField]
	protected bool m_tintAllSprites; // 0x1B8
	protected bool m_tintSprite; // 0x1B9
	protected Color32 m_spriteColor; // 0x1BC
	[SerializeField]
	protected TMP_StyleSheet m_StyleSheet; // 0x1C0
	internal TMP_Style m_TextStyle; // 0x1C8
	[SerializeField]
	protected int m_TextStyleHashCode; // 0x1D0
	[SerializeField]
	protected bool m_overrideHtmlColors; // 0x1D4
	[SerializeField]
	protected Color32 m_faceColor; // 0x1D8
	protected Color32 m_outlineColor; // 0x1DC
	protected float m_outlineWidth; // 0x1E0
	[SerializeField]
	protected float m_fontSize; // 0x1E4
	protected float m_currentFontSize; // 0x1E8
	[SerializeField]
	protected float m_fontSizeBase; // 0x1EC
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x1F0
	[SerializeField]
	protected FontWeight m_fontWeight; // 0x210
	protected FontWeight m_FontWeightInternal; // 0x214
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x218
	[SerializeField]
	protected bool m_enableAutoSizing; // 0x238
	protected float m_maxFontSize; // 0x23C
	protected float m_minFontSize; // 0x240
	protected int m_AutoSizeIterationCount; // 0x244
	protected int m_AutoSizeMaxIterationCount; // 0x248
	protected bool m_IsAutoSizePointSizeSet; // 0x24C
	[SerializeField]
	protected float m_fontSizeMin; // 0x250
	[SerializeField]
	protected float m_fontSizeMax; // 0x254
	[SerializeField]
	protected FontStyles m_fontStyle; // 0x258
	protected FontStyles m_FontStyleInternal; // 0x25C
	protected TMP_FontStyleStack m_fontStyleStack; // 0x260
	protected bool m_isUsingBold; // 0x26A
	[SerializeField]
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x26C
	[SerializeField]
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x270
	[SerializeField]
	[FormerlySerializedAs("m_lineJustification")]
	protected TextAlignmentOptions m_textAlignment; // 0x274
	protected HorizontalAlignmentOptions m_lineJustification; // 0x278
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x280
	protected Vector3[] m_textContainerLocalCorners; // 0x2A0
	[SerializeField]
	protected float m_characterSpacing; // 0x2A8
	protected float m_cSpacing; // 0x2AC
	protected float m_monoSpacing; // 0x2B0
	[SerializeField]
	protected float m_wordSpacing; // 0x2B4
	[SerializeField]
	protected float m_lineSpacing; // 0x2B8
	protected float m_lineSpacingDelta; // 0x2BC
	protected float m_lineHeight; // 0x2C0
	protected bool m_IsDrivenLineSpacing; // 0x2C4
	[SerializeField]
	protected float m_lineSpacingMax; // 0x2C8
	[SerializeField]
	protected float m_paragraphSpacing; // 0x2CC
	[SerializeField]
	protected float m_charWidthMaxAdj; // 0x2D0
	protected float m_charWidthAdjDelta; // 0x2D4
	[SerializeField]
	protected bool m_enableWordWrapping; // 0x2D8
	protected bool m_isCharacterWrappingEnabled; // 0x2D9
	protected bool m_isNonBreakingSpace; // 0x2DA
	protected bool m_isIgnoringAlignment; // 0x2DB
	[SerializeField]
	protected float m_wordWrappingRatios; // 0x2DC
	[SerializeField]
	protected TextOverflowModes m_overflowMode; // 0x2E0
	protected int m_firstOverflowCharacterIndex; // 0x2E4
	[SerializeField]
	protected TMP_Text m_linkedTextComponent; // 0x2E8
	[SerializeField]
	internal TMP_Text parentLinkedComponent; // 0x2F0
	protected bool m_isTextTruncated; // 0x2F8
	[SerializeField]
	protected bool m_enableKerning; // 0x2F9
	protected float m_GlyphHorizontalAdvanceAdjustment; // 0x2FC
	[SerializeField]
	protected bool m_enableExtraPadding; // 0x300
	[SerializeField]
	protected bool checkPaddingRequired; // 0x301
	[SerializeField]
	protected bool m_isRichText; // 0x302
	[SerializeField]
	protected bool m_parseCtrlCharacters; // 0x303
	protected bool m_isOverlay; // 0x304
	[SerializeField]
	protected bool m_isOrthographic; // 0x305
	[SerializeField]
	protected bool m_isCullingEnabled; // 0x306
	protected bool m_isMaskingEnabled; // 0x307
	protected bool isMaskUpdateRequired; // 0x308
	protected bool m_ignoreCulling; // 0x309
	[SerializeField]
	protected TextureMappingOptions m_horizontalMapping; // 0x30C
	[SerializeField]
	protected TextureMappingOptions m_verticalMapping; // 0x310
	[SerializeField]
	protected float m_uvLineOffset; // 0x314
	protected TextRenderFlags m_renderMode; // 0x318
	[SerializeField]
	protected VertexSortingOrder m_geometrySortingOrder; // 0x31C
	[SerializeField]
	protected bool m_IsTextObjectScaleStatic; // 0x320
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; // 0x321
	protected int m_firstVisibleCharacter; // 0x324
	protected int m_maxVisibleCharacters; // 0x328
	protected int m_maxVisibleWords; // 0x32C
	protected int m_maxVisibleLines; // 0x330
	[SerializeField]
	protected bool m_useMaxVisibleDescender; // 0x334
	[SerializeField]
	protected int m_pageToDisplay; // 0x338
	protected bool m_isNewPage; // 0x33C
	[SerializeField]
	protected Vector4 m_margin; // 0x340
	protected float m_marginLeft; // 0x350
	protected float m_marginRight; // 0x354
	protected float m_marginWidth; // 0x358
	protected float m_marginHeight; // 0x35C
	protected float m_width; // 0x360
	protected TMP_TextInfo m_textInfo; // 0x368
	protected bool m_havePropertiesChanged; // 0x370
	[SerializeField]
	protected bool m_isUsingLegacyAnimationComponent; // 0x371
	protected Transform m_transform; // 0x378
	protected RectTransform m_rectTransform; // 0x380
	protected Vector2 m_PreviousRectTransformSize; // 0x388
	protected Vector2 m_PreviousPivotPosition; // 0x390
	[CompilerGenerated]
	private bool <autoSizeTextContainer>k__BackingField; // 0x398
	protected bool m_autoSizeTextContainer; // 0x399
	protected Mesh m_mesh; // 0x3A0
	[SerializeField]
	protected bool m_isVolumetricText; // 0x3A8
	[CompilerGenerated]
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x70
	[CompilerGenerated]
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3B0
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x3B8
	protected float m_flexibleHeight; // 0x3C0
	protected float m_flexibleWidth; // 0x3C4
	protected float m_minWidth; // 0x3C8
	protected float m_minHeight; // 0x3CC
	protected float m_maxWidth; // 0x3D0
	protected float m_maxHeight; // 0x3D4
	protected LayoutElement m_LayoutElement; // 0x3D8
	protected float m_preferredWidth; // 0x3E0
	protected float m_renderedWidth; // 0x3E4
	protected bool m_isPreferredWidthDirty; // 0x3E8
	protected float m_preferredHeight; // 0x3EC
	protected float m_renderedHeight; // 0x3F0
	protected bool m_isPreferredHeightDirty; // 0x3F4
	protected bool m_isCalculatingPreferredValues; // 0x3F5
	protected int m_layoutPriority; // 0x3F8
	protected bool m_isLayoutDirty; // 0x3FC
	protected bool m_isAwake; // 0x3FD
	internal bool m_isWaitingOnResourceLoad; // 0x3FE
	internal TMP_Text.TextInputSources m_inputSource; // 0x400
	protected float m_fontScaleMultiplier; // 0x404
	private static char[] m_htmlTag; // 0x80
	private static RichTextTagAttribute[] m_xmlAttribute; // 0x88
	private static float[] m_attributeParameterValues; // 0x90
	protected float tag_LineIndent; // 0x408
	protected float tag_Indent; // 0x40C
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x410
	protected bool tag_NoParsing; // 0x430
	protected bool m_isParsingText; // 0x431
	protected Matrix4x4 m_FXMatrix; // 0x434
	protected bool m_isFXMatrixSet; // 0x474
	internal TMP_Text.UnicodeChar[] m_TextProcessingArray; // 0x478
	internal int m_InternalTextProcessingArraySize; // 0x480
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x488
	protected int m_totalCharacterCount; // 0x490
	protected static WordWrapState m_SavedWordWrapState; // 0x98
	protected static WordWrapState m_SavedLineState; // 0x410
	protected static WordWrapState m_SavedEllipsisState; // 0x788
	protected static WordWrapState m_SavedLastValidState; // 0xB00
	protected static WordWrapState m_SavedSoftLineBreakState; // 0xE78
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x11F0
	protected int m_characterCount; // 0x494
	protected int m_firstCharacterOfLine; // 0x498
	protected int m_firstVisibleCharacterOfLine; // 0x49C
	protected int m_lastCharacterOfLine; // 0x4A0
	protected int m_lastVisibleCharacterOfLine; // 0x4A4
	protected int m_lineNumber; // 0x4A8
	protected int m_lineVisibleCharacterCount; // 0x4AC
	protected int m_pageNumber; // 0x4B0
	protected float m_PageAscender; // 0x4B4
	protected float m_maxTextAscender; // 0x4B8
	protected float m_maxCapHeight; // 0x4BC
	protected float m_ElementAscender; // 0x4C0
	protected float m_ElementDescender; // 0x4C4
	protected float m_maxLineAscender; // 0x4C8
	protected float m_maxLineDescender; // 0x4CC
	protected float m_startOfLineAscender; // 0x4D0
	protected float m_startOfLineDescender; // 0x4D4
	protected float m_lineOffset; // 0x4D8
	protected Extents m_meshExtents; // 0x4DC
	protected Color32 m_htmlColor; // 0x4EC
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x4F0
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x510
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x530
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x550
	protected TMP_ColorGradient m_colorGradientPreset; // 0x580
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x588
	protected bool m_colorGradientPresetIsTinted; // 0x5B0
	protected float m_tabSpacing; // 0x5B4
	protected float m_spacing; // 0x5B8
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x5C0
	protected int m_TextStyleStackDepth; // 0x5C8
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x5D0
	protected int m_ItalicAngle; // 0x5F0
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x5F8
	protected float m_padding; // 0x618
	protected float m_baselineOffset; // 0x61C
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x620
	protected float m_xAdvance; // 0x640
	protected TMP_TextElementType m_textElementType; // 0x644
	protected TMP_TextElement m_cached_TextElement; // 0x648
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x650
	protected TMP_Text.SpecialCharacter m_Underline; // 0x670
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x690
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x698
	protected int m_spriteCount; // 0x6A0
	protected int m_spriteIndex; // 0x6A4
	protected int m_spriteAnimationID; // 0x6A8
	private static ProfilerMarker k_ParseTextMarker; // 0x1588
	private static ProfilerMarker k_InsertNewLineMarker; // 0x1590
	protected bool m_ignoreActiveState; // 0x6AC
	private TMP_Text.TextBackingContainer m_TextBackingArray; // 0x6B0
	private readonly Decimal[] k_Power; // 0x6C0
	protected static Vector2 k_LargePositiveVector2; // 0x1598
	protected static Vector2 k_LargeNegativeVector2; // 0x15A0
	protected static float k_LargePositiveFloat; // 0x15A8
	protected static float k_LargeNegativeFloat; // 0x15AC
	protected static int k_LargePositiveInt; // 0x15B0
	protected static int k_LargeNegativeInt; // 0x15B4

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x8678E7C Offset: 0x8674E7C VA: 0x8678E7C Slot: 65
	public virtual string get_text() { }

	// RVA: 0x8678F64 Offset: 0x8674F64 VA: 0x8678F64 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x8679008 Offset: 0x8675008 VA: 0x8679008
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x8679010 Offset: 0x8675010 VA: 0x8679010
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x8679018 Offset: 0x8675018 VA: 0x8679018
	public bool get_isRightToLeftText() { }

	// RVA: 0x8679020 Offset: 0x8675020 VA: 0x8679020
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x8679074 Offset: 0x8675074 VA: 0x8679074
	public TMP_FontAsset get_font() { }

	// RVA: 0x867907C Offset: 0x867507C VA: 0x867907C
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x8679154 Offset: 0x8675154 VA: 0x8679154 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x867915C Offset: 0x867515C VA: 0x867915C Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x8679224 Offset: 0x8675224 VA: 0x8679224 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x8679234 Offset: 0x8675234 VA: 0x8679234 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x8679280 Offset: 0x8675280 VA: 0x8679280
	public Material get_fontMaterial() { }

	// RVA: 0x8679294 Offset: 0x8675294 VA: 0x8679294
	public void set_fontMaterial(Material value) { }

	// RVA: 0x86793A0 Offset: 0x86753A0 VA: 0x86793A0 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x86793B4 Offset: 0x86753B4 VA: 0x86793B4 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x8679400 Offset: 0x8675400 VA: 0x8679400 Slot: 22
	public override Color get_color() { }

	// RVA: 0x8679414 Offset: 0x8675414 VA: 0x8679414 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x867948C Offset: 0x867548C VA: 0x867948C
	public float get_alpha() { }

	// RVA: 0x8679494 Offset: 0x8675494 VA: 0x8679494
	public void set_alpha(float value) { }

	// RVA: 0x86794C0 Offset: 0x86754C0 VA: 0x86794C0
	public bool get_enableVertexGradient() { }

	// RVA: 0x86794C8 Offset: 0x86754C8 VA: 0x86794C8
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x86794F8 Offset: 0x86754F8 VA: 0x86794F8
	public VertexGradient get_colorGradient() { }

	// RVA: 0x8679510 Offset: 0x8675510 VA: 0x8679510
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x867953C Offset: 0x867553C VA: 0x867953C
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x8679544 Offset: 0x8675544 VA: 0x8679544
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x8679578 Offset: 0x8675578 VA: 0x8679578
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x8679580 Offset: 0x8675580 VA: 0x8679580
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x86795C8 Offset: 0x86755C8 VA: 0x86795C8
	public bool get_tintAllSprites() { }

	// RVA: 0x86795D0 Offset: 0x86755D0 VA: 0x86795D0
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x8679600 Offset: 0x8675600 VA: 0x8679600
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x8679608 Offset: 0x8675608 VA: 0x8679608
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x8679650 Offset: 0x8675650 VA: 0x8679650
	public TMP_Style get_textStyle() { }

	// RVA: 0x86797A4 Offset: 0x86757A4 VA: 0x86797A4
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x8679800 Offset: 0x8675800 VA: 0x8679800
	public bool get_overrideColorTags() { }

	// RVA: 0x8679808 Offset: 0x8675808 VA: 0x8679808
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x8679838 Offset: 0x8675838 VA: 0x8679838
	public Color32 get_faceColor() { }

	// RVA: 0x8679900 Offset: 0x8675900 VA: 0x8679900
	public void set_faceColor(Color32 value) { }

	// RVA: 0x8679988 Offset: 0x8675988 VA: 0x8679988
	public Color32 get_outlineColor() { }

	// RVA: 0x8679A50 Offset: 0x8675A50 VA: 0x8679A50
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x8679AC4 Offset: 0x8675AC4 VA: 0x8679AC4
	public float get_outlineWidth() { }

	// RVA: 0x8679B80 Offset: 0x8675B80 VA: 0x8679B80
	public void set_outlineWidth(float value) { }

	// RVA: 0x8679BE0 Offset: 0x8675BE0 VA: 0x8679BE0
	public float get_fontSize() { }

	// RVA: 0x8679BE8 Offset: 0x8675BE8 VA: 0x8679BE8
	public void set_fontSize(float value) { }

	// RVA: 0x8679C48 Offset: 0x8675C48 VA: 0x8679C48
	public FontWeight get_fontWeight() { }

	// RVA: 0x8679C50 Offset: 0x8675C50 VA: 0x8679C50
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x8679CA0 Offset: 0x8675CA0 VA: 0x8679CA0
	public float get_pixelsPerUnit() { }

	// RVA: 0x8679E10 Offset: 0x8675E10 VA: 0x8679E10
	public bool get_enableAutoSizing() { }

	// RVA: 0x8679E18 Offset: 0x8675E18 VA: 0x8679E18
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x8679E64 Offset: 0x8675E64 VA: 0x8679E64
	public float get_fontSizeMin() { }

	// RVA: 0x8679E6C Offset: 0x8675E6C VA: 0x8679E6C
	public void set_fontSizeMin(float value) { }

	// RVA: 0x8679EB4 Offset: 0x8675EB4 VA: 0x8679EB4
	public float get_fontSizeMax() { }

	// RVA: 0x8679EBC Offset: 0x8675EBC VA: 0x8679EBC
	public void set_fontSizeMax(float value) { }

	// RVA: 0x8679F04 Offset: 0x8675F04 VA: 0x8679F04
	public FontStyles get_fontStyle() { }

	// RVA: 0x8679F0C Offset: 0x8675F0C VA: 0x8679F0C
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x8679F5C Offset: 0x8675F5C VA: 0x8679F5C
	public bool get_isUsingBold() { }

	// RVA: 0x8679F64 Offset: 0x8675F64 VA: 0x8679F64
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x8679F6C Offset: 0x8675F6C VA: 0x8679F6C
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x8679F98 Offset: 0x8675F98 VA: 0x8679F98
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x8679FA0 Offset: 0x8675FA0 VA: 0x8679FA0
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x8679FCC Offset: 0x8675FCC VA: 0x8679FCC
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x8679FDC Offset: 0x8675FDC VA: 0x8679FDC
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x867A020 Offset: 0x8676020 VA: 0x867A020
	public float get_characterSpacing() { }

	// RVA: 0x867A028 Offset: 0x8676028 VA: 0x867A028
	public void set_characterSpacing(float value) { }

	// RVA: 0x867A078 Offset: 0x8676078 VA: 0x867A078
	public float get_wordSpacing() { }

	// RVA: 0x867A080 Offset: 0x8676080 VA: 0x867A080
	public void set_wordSpacing(float value) { }

	// RVA: 0x867A0D0 Offset: 0x86760D0 VA: 0x867A0D0
	public float get_lineSpacing() { }

	// RVA: 0x867A0D8 Offset: 0x86760D8 VA: 0x867A0D8
	public void set_lineSpacing(float value) { }

	// RVA: 0x867A128 Offset: 0x8676128 VA: 0x867A128
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x867A130 Offset: 0x8676130 VA: 0x867A130
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x867A180 Offset: 0x8676180 VA: 0x867A180
	public float get_paragraphSpacing() { }

	// RVA: 0x867A188 Offset: 0x8676188 VA: 0x867A188
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x867A1D8 Offset: 0x86761D8 VA: 0x867A1D8
	public float get_characterWidthAdjustment() { }

	// RVA: 0x867A1E0 Offset: 0x86761E0 VA: 0x867A1E0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x867A230 Offset: 0x8676230 VA: 0x867A230
	public bool get_enableWordWrapping() { }

	// RVA: 0x867A238 Offset: 0x8676238 VA: 0x867A238
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x867A28C Offset: 0x867628C VA: 0x867A28C
	public float get_wordWrappingRatios() { }

	// RVA: 0x867A294 Offset: 0x8676294 VA: 0x867A294
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x867A2E4 Offset: 0x86762E4 VA: 0x867A2E4
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x867A2EC Offset: 0x86762EC VA: 0x867A2EC
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x867A33C Offset: 0x867633C VA: 0x867A33C
	public bool get_isTextOverflowing() { }

	// RVA: 0x867A34C Offset: 0x867634C VA: 0x867A34C
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x867A354 Offset: 0x8676354 VA: 0x867A354
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x867A35C Offset: 0x867635C VA: 0x867A35C
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x867A684 Offset: 0x8676684 VA: 0x867A684
	public bool get_isTextTruncated() { }

	// RVA: 0x867A68C Offset: 0x867668C VA: 0x867A68C
	public bool get_enableKerning() { }

	// RVA: 0x867A694 Offset: 0x8676694 VA: 0x867A694
	public void set_enableKerning(bool value) { }

	// RVA: 0x867A6E8 Offset: 0x86766E8 VA: 0x867A6E8
	public bool get_extraPadding() { }

	// RVA: 0x867A6F0 Offset: 0x86766F0 VA: 0x867A6F0
	public void set_extraPadding(bool value) { }

	// RVA: 0x867A744 Offset: 0x8676744 VA: 0x867A744
	public bool get_richText() { }

	// RVA: 0x867A74C Offset: 0x867674C VA: 0x867A74C
	public void set_richText(bool value) { }

	// RVA: 0x867A7A0 Offset: 0x86767A0 VA: 0x867A7A0
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x867A7A8 Offset: 0x86767A8 VA: 0x867A7A8
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x867A7FC Offset: 0x86767FC VA: 0x867A7FC
	public bool get_isOverlay() { }

	// RVA: 0x867A804 Offset: 0x8676804 VA: 0x867A804
	public void set_isOverlay(bool value) { }

	// RVA: 0x867A858 Offset: 0x8676858 VA: 0x867A858
	public bool get_isOrthographic() { }

	// RVA: 0x867A860 Offset: 0x8676860 VA: 0x867A860
	public void set_isOrthographic(bool value) { }

	// RVA: 0x867A890 Offset: 0x8676890 VA: 0x867A890
	public bool get_enableCulling() { }

	// RVA: 0x867A898 Offset: 0x8676898 VA: 0x867A898
	public void set_enableCulling(bool value) { }

	// RVA: 0x867A8D4 Offset: 0x86768D4 VA: 0x867A8D4
	public bool get_ignoreVisibility() { }

	// RVA: 0x867A8DC Offset: 0x86768DC VA: 0x867A8DC
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x867A8FC Offset: 0x86768FC VA: 0x867A8FC
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x867A904 Offset: 0x8676904 VA: 0x867A904
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x867A930 Offset: 0x8676930 VA: 0x867A930
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x867A938 Offset: 0x8676938 VA: 0x867A938
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x867A964 Offset: 0x8676964 VA: 0x867A964
	public float get_mappingUvLineOffset() { }

	// RVA: 0x867A96C Offset: 0x867696C VA: 0x867A96C
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x867A998 Offset: 0x8676998 VA: 0x867A998
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x867A9A0 Offset: 0x86769A0 VA: 0x867A9A0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x867A9BC Offset: 0x86769BC VA: 0x867A9BC
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x867A9C4 Offset: 0x86769C4 VA: 0x867A9C4
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x867A9E0 Offset: 0x86769E0 VA: 0x867A9E0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x867A9E8 Offset: 0x86769E8 VA: 0x867A9E8
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x867AA68 Offset: 0x8676A68 VA: 0x867AA68
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x867AA70 Offset: 0x8676A70 VA: 0x867AA70
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x867AA90 Offset: 0x8676A90 VA: 0x867AA90
	public int get_firstVisibleCharacter() { }

	// RVA: 0x867AA98 Offset: 0x8676A98 VA: 0x867AA98
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x867AAC4 Offset: 0x8676AC4 VA: 0x867AAC4
	public int get_maxVisibleCharacters() { }

	// RVA: 0x867AACC Offset: 0x8676ACC VA: 0x867AACC
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x867AAF8 Offset: 0x8676AF8 VA: 0x867AAF8
	public int get_maxVisibleWords() { }

	// RVA: 0x867AB00 Offset: 0x8676B00 VA: 0x867AB00
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x867AB2C Offset: 0x8676B2C VA: 0x867AB2C
	public int get_maxVisibleLines() { }

	// RVA: 0x867AB34 Offset: 0x8676B34 VA: 0x867AB34
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x867AB60 Offset: 0x8676B60 VA: 0x867AB60
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x867AB68 Offset: 0x8676B68 VA: 0x867AB68
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x867AB98 Offset: 0x8676B98 VA: 0x867AB98
	public int get_pageToDisplay() { }

	// RVA: 0x867ABA0 Offset: 0x8676BA0 VA: 0x867ABA0
	public void set_pageToDisplay(int value) { }

	// RVA: 0x867ABCC Offset: 0x8676BCC VA: 0x867ABCC Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x867ABE0 Offset: 0x8676BE0 VA: 0x867ABE0 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x867AC7C Offset: 0x8676C7C VA: 0x867AC7C
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x867AC84 Offset: 0x8676C84 VA: 0x867AC84
	public bool get_havePropertiesChanged() { }

	// RVA: 0x867AC8C Offset: 0x8676C8C VA: 0x867AC8C
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x867ACB4 Offset: 0x8676CB4 VA: 0x867ACB4
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x867ACBC Offset: 0x8676CBC VA: 0x867ACBC
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x867ACC8 Offset: 0x8676CC8 VA: 0x867ACC8
	public Transform get_transform() { }

	// RVA: 0x867AD68 Offset: 0x8676D68 VA: 0x867AD68
	public RectTransform get_rectTransform() { }

	[CompilerGenerated]
	// RVA: 0x867AE08 Offset: 0x8676E08 VA: 0x867AE08 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGenerated]
	// RVA: 0x867AE10 Offset: 0x8676E10 VA: 0x867AE10 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x867AE1C Offset: 0x8676E1C VA: 0x867AE1C Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x867AE24 Offset: 0x8676E24 VA: 0x867AE24
	public bool get_isVolumetricText() { }

	// RVA: 0x867AE2C Offset: 0x8676E2C VA: 0x867AE2C
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x867AE94 Offset: 0x8676E94 VA: 0x867AE94
	public Bounds get_bounds() { }

	// RVA: 0x867AF44 Offset: 0x8676F44 VA: 0x867AF44
	public Bounds get_textBounds() { }

	[CompilerGenerated]
	// RVA: 0x867B134 Offset: 0x8677134 VA: 0x867B134
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x867B228 Offset: 0x8677228 VA: 0x867B228
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x867B31C Offset: 0x867731C VA: 0x867B31C
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x867B410 Offset: 0x8677410 VA: 0x867B410
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x867B504 Offset: 0x8677504 VA: 0x867B504 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x867B5B8 Offset: 0x86775B8 VA: 0x867B5B8 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x867B66C Offset: 0x867766C VA: 0x867B66C
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x867B77C Offset: 0x867777C VA: 0x867B77C Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x867B784 Offset: 0x8677784 VA: 0x867B784 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x867B78C Offset: 0x867778C VA: 0x867B78C Slot: 82
	public float get_minWidth() { }

	// RVA: 0x867B794 Offset: 0x8677794 VA: 0x867B794 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x867B79C Offset: 0x867779C VA: 0x867B79C
	public float get_maxWidth() { }

	// RVA: 0x867B7A4 Offset: 0x86777A4 VA: 0x867B7A4
	public float get_maxHeight() { }

	// RVA: 0x867B7AC Offset: 0x86777AC VA: 0x867B7AC
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x867B84C Offset: 0x867784C VA: 0x867B84C Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x867B9A0 Offset: 0x86779A0 VA: 0x867B9A0 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x867BB30 Offset: 0x8677B30 VA: 0x867BB30 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x867BB78 Offset: 0x8677B78 VA: 0x867BB78 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x867BBC0 Offset: 0x8677BC0 VA: 0x867BBC0 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x867BBC8 Offset: 0x8677BC8 VA: 0x867BBC8 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x867BBCC Offset: 0x8677BCC VA: 0x867BBCC Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x867BBD0 Offset: 0x8677BD0 VA: 0x867BBD0 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x867BBD8 Offset: 0x8677BD8 VA: 0x867BBD8 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x867BBDC Offset: 0x8677BDC VA: 0x867BBDC Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x867BBE4 Offset: 0x8677BE4 VA: 0x867BBE4 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x867BBE8 Offset: 0x8677BE8 VA: 0x867BBE8 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x867BBF0 Offset: 0x8677BF0 VA: 0x867BBF0 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x867BCB0 Offset: 0x8677CB0 VA: 0x867BCB0
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x867BD6C Offset: 0x8677D6C VA: 0x867BD6C
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x867BD70 Offset: 0x8677D70 VA: 0x867BD70
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x867BD74 Offset: 0x8677D74 VA: 0x867BD74 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x867BD78 Offset: 0x8677D78 VA: 0x867BD78 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x867BD7C Offset: 0x8677D7C VA: 0x867BD7C Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x867BD80 Offset: 0x8677D80 VA: 0x867BD80 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x867BD84 Offset: 0x8677D84 VA: 0x867BD84 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x867BD88 Offset: 0x8677D88 VA: 0x867BD88 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x867BD8C Offset: 0x8677D8C VA: 0x867BD8C Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x867BEAC Offset: 0x8677EAC VA: 0x867BEAC Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x867BFAC Offset: 0x8677FAC VA: 0x867BFAC Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x867BFB4 Offset: 0x8677FB4 VA: 0x867BFB4 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x867BFB8 Offset: 0x8677FB8 VA: 0x867BFB8 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x867BFBC Offset: 0x8677FBC VA: 0x867BFBC Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x867BFC0 Offset: 0x8677FC0 VA: 0x867BFC0 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x867BFC4 Offset: 0x8677FC4 VA: 0x867BFC4 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x867BFC8 Offset: 0x8677FC8 VA: 0x867BFC8 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x867BFCC Offset: 0x8677FCC VA: 0x867BFCC Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x867C054 Offset: 0x8678054 VA: 0x867C054 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x867C0A8 Offset: 0x86780A8 VA: 0x867C0A8 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x867C0AC Offset: 0x86780AC VA: 0x867C0AC Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x867C0B0 Offset: 0x86780B0 VA: 0x867C0B0
	protected void ParseInputText() { }

	// RVA: 0x867C1C8 Offset: 0x86781C8 VA: 0x867C1C8
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x867CC50 Offset: 0x8678C50 VA: 0x867CC50
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x867CD48 Offset: 0x8678D48 VA: 0x867CD48
	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x867CE70 Offset: 0x8678E70 VA: 0x867CE70
	private void PopulateTextBackingArray(char[] sourceText, int start, int length) { }

	// RVA: 0x867C1E0 Offset: 0x86781E0 VA: 0x867C1E0
	private void PopulateTextProcessingArray() { }

	// RVA: 0x867E204 Offset: 0x867A204 VA: 0x867E204
	private void SetTextInternal(string sourceText) { }

	// RVA: 0x867E250 Offset: 0x867A250 VA: 0x867E250
	public void SetText(string sourceText, bool syncTextInputBox = True) { }

	// RVA: 0x867E2D8 Offset: 0x867A2D8 VA: 0x867E2D8
	public void SetText(string sourceText, float arg0) { }

	// RVA: 0x867E5B8 Offset: 0x867A5B8 VA: 0x867E5B8
	public void SetText(string sourceText, float arg0, float arg1) { }

	// RVA: 0x867E5D4 Offset: 0x867A5D4 VA: 0x867E5D4
	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	// RVA: 0x867E5EC Offset: 0x867A5EC VA: 0x867E5EC
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x867E600 Offset: 0x867A600 VA: 0x867E600
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x867E610 Offset: 0x867A610 VA: 0x867E610
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x867E61C Offset: 0x867A61C VA: 0x867E61C
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x867E2F8 Offset: 0x867A2F8 VA: 0x867E2F8
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x867E900 Offset: 0x867A900 VA: 0x867E900
	public void SetText(StringBuilder sourceText) { }

	// RVA: 0x867E944 Offset: 0x867A944 VA: 0x867E944
	private void SetText(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x867E9A0 Offset: 0x867A9A0 VA: 0x867E9A0
	public void SetText(char[] sourceText) { }

	// RVA: 0x867EA14 Offset: 0x867AA14 VA: 0x867EA14
	public void SetText(char[] sourceText, int start, int length) { }

	// RVA: 0x867EA18 Offset: 0x867AA18 VA: 0x867EA18
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x867E9B8 Offset: 0x867A9B8 VA: 0x867E9B8
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x86796B4 Offset: 0x86756B4 VA: 0x86796B4
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x867D638 Offset: 0x8679638 VA: 0x867D638
	private bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x867EE48 Offset: 0x867AE48 VA: 0x867EE48
	private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x867DA54 Offset: 0x8679A54 VA: 0x867DA54
	private void ReplaceClosingStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x867F264 Offset: 0x867B264 VA: 0x867F264
	private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x867CF84 Offset: 0x8678F84 VA: 0x867CF84
	private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x867DE40 Offset: 0x8679E40 VA: 0x867DE40
	private void InsertClosingStyleTag(ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x867ED2C Offset: 0x867AD2C VA: 0x867ED2C
	private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex) { }

	// RVA: 0x867D52C Offset: 0x867952C VA: 0x867D52C
	private int GetMarkupTagHashCode(TMP_Text.TextBackingContainer tagDefinition, int readIndex) { }

	// RVA: 0x867F650 Offset: 0x867B650 VA: 0x867F650
	private int GetStyleHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0x867EA30 Offset: 0x867AA30 VA: 0x867EA30
	private int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470F828 Offset: 0x470B828 VA: 0x470F828
	|-TMP_Text.ResizeInternalArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x470F884 Offset: 0x470B884 VA: 0x470F884
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470F8DC Offset: 0x470B8DC VA: 0x470F8DC
	|-TMP_Text.ResizeInternalArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x470F92C Offset: 0x470B92C VA: 0x470F92C
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x867E624 Offset: 0x867A624 VA: 0x867E624
	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x867F72C Offset: 0x867B72C VA: 0x867F72C
	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x8678E90 Offset: 0x8674E90 VA: 0x8678E90
	private string InternalTextBackingArrayToString() { }

	// RVA: 0x867F85C Offset: 0x867B85C VA: 0x867F85C Slot: 114
	internal virtual int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x867F864 Offset: 0x867B864 VA: 0x867F864
	public Vector2 GetPreferredValues() { }

	// RVA: 0x867F8B0 Offset: 0x867B8B0 VA: 0x867F8B0
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x867FA64 Offset: 0x867BA64 VA: 0x867FA64
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x867FB8C Offset: 0x867BB8C VA: 0x867FB8C
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x867B864 Offset: 0x8677864 VA: 0x867B864
	protected float GetPreferredWidth() { }

	// RVA: 0x867F95C Offset: 0x867B95C VA: 0x867F95C
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x867B9B8 Offset: 0x86779B8 VA: 0x867B9B8
	protected float GetPreferredHeight() { }

	// RVA: 0x867F9B8 Offset: 0x867B9B8 VA: 0x867F9B8
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x867FC50 Offset: 0x867BC50 VA: 0x867FC50
	public Vector2 GetRenderedValues() { }

	// RVA: 0x867FC78 Offset: 0x867BC78 VA: 0x867FC78
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x867BB54 Offset: 0x8677B54 VA: 0x867BB54
	private float GetRenderedWidth() { }

	// RVA: 0x867FEAC Offset: 0x867BEAC VA: 0x867FEAC
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x867BB9C Offset: 0x8677B9C VA: 0x867BB9C
	private float GetRenderedHeight() { }

	// RVA: 0x867FED4 Offset: 0x867BED4 VA: 0x867FED4
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x867FEFC Offset: 0x867BEFC VA: 0x867FEFC Slot: 115
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) { }

	// RVA: 0x8688400 Offset: 0x8684400 VA: 0x8688400 Slot: 116
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x868840C Offset: 0x868440C VA: 0x868840C Slot: 117
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x867AF88 Offset: 0x8676F88 VA: 0x867AF88
	protected Bounds GetTextBounds() { }

	// RVA: 0x867FCA4 Offset: 0x867BCA4 VA: 0x867FCA4
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x8688414 Offset: 0x8684414 VA: 0x8688414
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x86885CC Offset: 0x86845CC VA: 0x86885CC
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x868877C Offset: 0x868477C VA: 0x868877C Slot: 118
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x8688784 Offset: 0x8684784 VA: 0x8688784 Slot: 119
	public virtual void ComputeMarginSize() { }

	// RVA: 0x8688788 Offset: 0x8684788 VA: 0x8688788
	protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x86880A4 Offset: 0x86840A4 VA: 0x86880A4
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x8687D10 Offset: 0x8683D10 VA: 0x8687D10
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x8688C58 Offset: 0x8684C58 VA: 0x8688C58 Slot: 120
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x86897D0 Offset: 0x86857D0 VA: 0x86897D0 Slot: 121
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x8689F30 Offset: 0x8685F30 VA: 0x8689F30 Slot: 122
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0x868A650 Offset: 0x8686650 VA: 0x868A650 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0x868B180 Offset: 0x8687180 VA: 0x868B180 Slot: 124
	protected virtual void FillSpriteVertexBuffers(int i, int index_X4) { }

	// RVA: 0x868B8A0 Offset: 0x86878A0 VA: 0x868B8A0 Slot: 125
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x868C8E0 Offset: 0x86888E0 VA: 0x868C8E0 Slot: 126
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x868CE08 Offset: 0x8688E08 VA: 0x868CE08
	protected void LoadDefaultSettings() { }

	// RVA: 0x868D094 Offset: 0x8689094 VA: 0x868D094
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x868D0BC Offset: 0x86890BC VA: 0x868D0BC
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x868C724 Offset: 0x8688724 VA: 0x868C724
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x868D30C Offset: 0x868930C VA: 0x868D30C
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x868D380 Offset: 0x8689380 VA: 0x868D380
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x868D3FC Offset: 0x86893FC VA: 0x868D3FC
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x868D7E8 Offset: 0x86897E8 VA: 0x868D7E8 Slot: 127
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x868D7EC Offset: 0x86897EC VA: 0x868D7EC Slot: 128
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x868D7F0 Offset: 0x86897F0 VA: 0x868D7F0 Slot: 129
	public virtual void ClearMesh() { }

	// RVA: 0x868D7F4 Offset: 0x86897F4 VA: 0x868D7F4 Slot: 130
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x868D7F8 Offset: 0x86897F8 VA: 0x868D7F8 Slot: 131
	public virtual string GetParsedText() { }

	// RVA: 0x867A5A4 Offset: 0x86765A4 VA: 0x867A5A4
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x867A474 Offset: 0x8676474 VA: 0x867A474
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x868C880 Offset: 0x8688880 VA: 0x868C880
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x868D8F0 Offset: 0x86898F0 VA: 0x868D8F0
	protected float PackUV(float x, float y) { }

	// RVA: 0x868D950 Offset: 0x8689950 VA: 0x868D950 Slot: 132
	internal virtual void InternalUpdate() { }

	// RVA: 0x868D954 Offset: 0x8689954 VA: 0x868D954
	protected int HexToInt(char hex) { }

	// RVA: 0x868D980 Offset: 0x8689980 VA: 0x868D980
	protected int GetUTF16(string text, int i) { }

	// RVA: 0x867EB3C Offset: 0x867AB3C VA: 0x867EB3C
	protected int GetUTF16(int[] text, int i) { }

	// RVA: 0x868DA28 Offset: 0x8689A28 VA: 0x868DA28
	internal int GetUTF16(uint[] text, int i) { }

	// RVA: 0x868DAD0 Offset: 0x8689AD0 VA: 0x868DAD0
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0x867D34C Offset: 0x867934C VA: 0x867D34C
	private int GetUTF16(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x868DB78 Offset: 0x8689B78 VA: 0x868DB78
	protected int GetUTF32(string text, int i) { }

	// RVA: 0x867EBE4 Offset: 0x867ABE4 VA: 0x867EBE4
	protected int GetUTF32(int[] text, int i) { }

	// RVA: 0x868DCB0 Offset: 0x8689CB0 VA: 0x868DCB0
	internal int GetUTF32(uint[] text, int i) { }

	// RVA: 0x868DDF8 Offset: 0x8689DF8 VA: 0x868DDF8
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0x867D3F4 Offset: 0x86793F4 VA: 0x867D3F4
	private int GetUTF32(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x868DF30 Offset: 0x8689F30 VA: 0x868DF30
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x868E344 Offset: 0x868A344 VA: 0x868E344
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x868E590 Offset: 0x868A590 VA: 0x868E590
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x868E7BC Offset: 0x868A7BC VA: 0x868E7BC
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x868E63C Offset: 0x868A63C VA: 0x868E63C
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x8682108 Offset: 0x867E108 VA: 0x8682108
	internal bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x868E7D4 Offset: 0x868A7D4 VA: 0x868E7D4
	protected void .ctor() { }

	// RVA: 0x868F1D4 Offset: 0x868B1D4 VA: 0x868F1D4
	private static void .cctor() { }
}

// Namespace: TMPro
public enum TextElementType // TypeDefIndex: 21852
{
	// Fields
	public byte value__; // 0x0
	public const TextElementType Character = 1;
	public const TextElementType Sprite = 2;
}

// Namespace: TMPro
[Serializable]
public class TMP_TextElement // TypeDefIndex: 21853
{
	// Fields
	[SerializeField]
	protected TextElementType m_ElementType; // 0x10
	[SerializeField]
	internal uint m_Unicode; // 0x14
	internal TMP_Asset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField]
	internal uint m_GlyphIndex; // 0x28
	[SerializeField]
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TMP_Asset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x869EC24 Offset: 0x869AC24 VA: 0x869EC24
	public TextElementType get_elementType() { }

	// RVA: 0x869EC2C Offset: 0x869AC2C VA: 0x869EC2C
	public uint get_unicode() { }

	// RVA: 0x869EC34 Offset: 0x869AC34 VA: 0x869EC34
	public void set_unicode(uint value) { }

	// RVA: 0x869EC3C Offset: 0x869AC3C VA: 0x869EC3C
	public TMP_Asset get_textAsset() { }

	// RVA: 0x869EC44 Offset: 0x869AC44 VA: 0x869EC44
	public void set_textAsset(TMP_Asset value) { }

	// RVA: 0x869EC4C Offset: 0x869AC4C VA: 0x869EC4C
	public Glyph get_glyph() { }

	// RVA: 0x869EC54 Offset: 0x869AC54 VA: 0x869EC54
	public void set_glyph(Glyph value) { }

	// RVA: 0x869EC5C Offset: 0x869AC5C VA: 0x869EC5C
	public uint get_glyphIndex() { }

	// RVA: 0x869EC64 Offset: 0x869AC64 VA: 0x869EC64
	public void set_glyphIndex(uint value) { }

	// RVA: 0x869EC6C Offset: 0x869AC6C VA: 0x869EC6C
	public float get_scale() { }

	// RVA: 0x869EC74 Offset: 0x869AC74 VA: 0x869EC74
	public void set_scale(float value) { }

	// RVA: 0x869B3E8 Offset: 0x86973E8 VA: 0x869B3E8
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextElement_Legacy // TypeDefIndex: 21854
{
	// Fields
	public int id; // 0x10
	public float x; // 0x14
	public float y; // 0x18
	public float width; // 0x1C
	public float height; // 0x20
	public float xOffset; // 0x24
	public float yOffset; // 0x28
	public float xAdvance; // 0x2C
	public float scale; // 0x30

	// Methods

	// RVA: 0x8698954 Offset: 0x8694954 VA: 0x8698954
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextInfo // TypeDefIndex: 21855
{
	// Fields
	internal static Vector2 k_InfinityVectorPositive; // 0x0
	internal static Vector2 k_InfinityVectorNegative; // 0x8
	public TMP_Text textComponent; // 0x10
	public int characterCount; // 0x18
	public int spriteCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int linkCount; // 0x28
	public int lineCount; // 0x2C
	public int pageCount; // 0x30
	public int materialCount; // 0x34
	public TMP_CharacterInfo[] characterInfo; // 0x38
	public TMP_WordInfo[] wordInfo; // 0x40
	public TMP_LinkInfo[] linkInfo; // 0x48
	public TMP_LineInfo[] lineInfo; // 0x50
	public TMP_PageInfo[] pageInfo; // 0x58
	public TMP_MeshInfo[] meshInfo; // 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68

	// Methods

	// RVA: 0x869EC7C Offset: 0x869AC7C VA: 0x869EC7C
	public void .ctor() { }

	// RVA: 0x869EDE8 Offset: 0x869ADE8 VA: 0x869EDE8
	internal void .ctor(int characterCount) { }

	// RVA: 0x869EF58 Offset: 0x869AF58 VA: 0x869EF58
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x869F128 Offset: 0x869B128 VA: 0x869F128
	public void Clear() { }

	// RVA: 0x869F184 Offset: 0x869B184 VA: 0x869F184
	internal void ClearAllData() { }

	// RVA: 0x869F2F4 Offset: 0x869B2F4 VA: 0x869F2F4
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x869F3AC Offset: 0x869B3AC VA: 0x869F3AC
	public void ClearAllMeshInfo() { }

	// RVA: 0x869F45C Offset: 0x869B45C VA: 0x869F45C
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x869F518 Offset: 0x869B518 VA: 0x869F518
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x869F5C8 Offset: 0x869B5C8 VA: 0x869F5C8
	public void ClearLineInfo() { }

	// RVA: 0x869F758 Offset: 0x869B758 VA: 0x869F758
	internal void ClearPageInfo() { }

	// RVA: 0x869F800 Offset: 0x869B800 VA: 0x869F800
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470F978 Offset: 0x470B978 VA: 0x470F978
	|-TMP_TextInfo.Resize<object>
	|
	|-RVA: 0x470F9D4 Offset: 0x470B9D4 VA: 0x470F9D4
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x470FA30 Offset: 0x470BA30 VA: 0x470FA30
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	|
	|-RVA: 0x470FA8C Offset: 0x470BA8C VA: 0x470FA8C
	|-TMP_TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470FAEC Offset: 0x470BAEC VA: 0x470FAEC
	|-TMP_TextInfo.Resize<object>
	|
	|-RVA: 0x470FB8C Offset: 0x470BB8C VA: 0x470FB8C
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x470FC2C Offset: 0x470BC2C VA: 0x470FC2C
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x470FCCC Offset: 0x470BCCC VA: 0x470FCCC
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	|
	|-RVA: 0x470FD6C Offset: 0x470BD6C VA: 0x470FD6C
	|-TMP_TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x869FC1C Offset: 0x869BC1C VA: 0x869FC1C
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_TextParsingUtilities // TypeDefIndex: 21856
{
	// Fields
	private static readonly TMP_TextParsingUtilities s_Instance; // 0x0
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Properties
	public static TMP_TextParsingUtilities instance { get; }

	// Methods

	// RVA: 0x869FC88 Offset: 0x869BC88 VA: 0x869FC88
	private static void .cctor() { }

	// RVA: 0x869FCF8 Offset: 0x869BCF8 VA: 0x869FCF8
	public static TMP_TextParsingUtilities get_instance() { }

	// RVA: 0x869B8C4 Offset: 0x86978C4 VA: 0x869B8C4
	public static int GetHashCode(string s) { }

	// RVA: 0x869B374 Offset: 0x8697374 VA: 0x869B374
	public static int GetHashCodeCaseSensitive(string s) { }

	// RVA: 0x869FDC4 Offset: 0x869BDC4 VA: 0x869FDC4
	public static char ToLowerASCIIFast(char c) { }

	// RVA: 0x869FD50 Offset: 0x869BD50 VA: 0x869FD50
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x869FE38 Offset: 0x869BE38 VA: 0x869FE38
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x869FEAC Offset: 0x869BEAC VA: 0x869FEAC
	public static uint ToLowerASCIIFast(uint c) { }

	// RVA: 0x869FF20 Offset: 0x869BF20 VA: 0x869FF20
	public static bool IsHighSurrogate(uint c) { }

	// RVA: 0x869FF34 Offset: 0x869BF34 VA: 0x869FF34
	public static bool IsLowSurrogate(uint c) { }

	// RVA: 0x869FF48 Offset: 0x869BF48 VA: 0x869FF48
	internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x869FCF0 Offset: 0x869BCF0 VA: 0x869FCF0
	public void .ctor() { }
}

// Namespace: TMPro
public struct TMP_FontStyleStack // TypeDefIndex: 21857
{
	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x869FF5C Offset: 0x869BF5C VA: 0x869FF5C
	public void Clear() { }

	// RVA: 0x869FF68 Offset: 0x869BF68 VA: 0x869FF68
	public byte Add(FontStyles style) { }

	// RVA: 0x86A0064 Offset: 0x869C064 VA: 0x86A0064
	public byte Remove(FontStyles style) { }
}

// Namespace: TMPro
[DebuggerDisplay("Item count = {m_Count}")]
public struct TMP_TextProcessingStack<T> // TypeDefIndex: 21858
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55373B4 Offset: 0x55333B4 VA: 0x55373B4
	|-TMP_TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x5537940 Offset: 0x5533940 VA: 0x5537940
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x553808C Offset: 0x553408C VA: 0x553808C
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x5538618 Offset: 0x5534618 VA: 0x5538618
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x5538BA4 Offset: 0x5534BA4 VA: 0x5538BA4
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x553941C Offset: 0x553541C VA: 0x553941C
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x55399D4 Offset: 0x55359D4 VA: 0x55399D4
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x5539F64 Offset: 0x5535F64 VA: 0x5539F64
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x553A738 Offset: 0x5536738 VA: 0x553A738
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55373F4 Offset: 0x55333F4 VA: 0x55373F4
	|-TMP_TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x5537980 Offset: 0x5533980 VA: 0x5537980
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x55380CC Offset: 0x55340CC VA: 0x55380CC
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x5538658 Offset: 0x5534658 VA: 0x5538658
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x5538BF0 Offset: 0x5534BF0 VA: 0x5538BF0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x553945C Offset: 0x553545C VA: 0x553945C
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x5539A14 Offset: 0x5535A14 VA: 0x5539A14
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x5539FB4 Offset: 0x5535FB4 VA: 0x5539FB4
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x553A8A8 Offset: 0x55368A8 VA: 0x553A8A8
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5537464 Offset: 0x5533464 VA: 0x5537464
	|-TMP_TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x55379F0 Offset: 0x55339F0 VA: 0x55379F0
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x553813C Offset: 0x553413C VA: 0x553813C
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x55386C8 Offset: 0x55346C8 VA: 0x55386C8
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x5538C6C Offset: 0x5534C6C VA: 0x5538C6C
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x55394CC Offset: 0x55354CC VA: 0x55394CC
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x5539A84 Offset: 0x5535A84 VA: 0x5539A84
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x553A034 Offset: 0x5536034 VA: 0x553A034
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x553AA48 Offset: 0x5536A48 VA: 0x553AA48
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55374D4 Offset: 0x55334D4 VA: 0x55374D4
	|-TMP_TextProcessingStack<Color32>.get_Count
	|
	|-RVA: 0x5537A68 Offset: 0x5533A68 VA: 0x5537A68
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x55381AC Offset: 0x55341AC VA: 0x55381AC
	|-TMP_TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x5538738 Offset: 0x5534738 VA: 0x5538738
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x5538CEC Offset: 0x5534CEC VA: 0x5538CEC
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x5539540 Offset: 0x5535540 VA: 0x5539540
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x5539AF4 Offset: 0x5535AF4 VA: 0x5539AF4
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x553A0B8 Offset: 0x55360B8 VA: 0x553A0B8
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x553ABF4 Offset: 0x5536BF4 VA: 0x553ABF4
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55374DC Offset: 0x55334DC VA: 0x55374DC
	|-TMP_TextProcessingStack<Color32>.get_current
	|
	|-RVA: 0x5537A70 Offset: 0x5533A70 VA: 0x5537A70
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x55381B4 Offset: 0x55341B4 VA: 0x55381B4
	|-TMP_TextProcessingStack<int>.get_current
	|
	|-RVA: 0x5538740 Offset: 0x5534740 VA: 0x5538740
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x5538CF4 Offset: 0x5534CF4 VA: 0x5538CF4
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x5539548 Offset: 0x5535548 VA: 0x5539548
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x5539AFC Offset: 0x5535AFC VA: 0x5539AFC
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x553A0C0 Offset: 0x55360C0 VA: 0x553A0C0
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x553AC38 Offset: 0x5536C38 VA: 0x553AC38
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5537528 Offset: 0x5533528 VA: 0x5537528
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	|
	|-RVA: 0x5537AD0 Offset: 0x5533AD0 VA: 0x5537AD0
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x5538200 Offset: 0x5534200 VA: 0x5538200
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|
	|-RVA: 0x553878C Offset: 0x553478C VA: 0x553878C
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|
	|-RVA: 0x5538D5C Offset: 0x5534D5C VA: 0x5538D5C
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x5539594 Offset: 0x5535594 VA: 0x5539594
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x5539B48 Offset: 0x5535B48 VA: 0x5539B48
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x553A118 Offset: 0x5536118 VA: 0x553A118
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	|
	|-RVA: 0x553ADD8 Offset: 0x5536DD8 VA: 0x553ADD8
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5537530 Offset: 0x5533530 VA: 0x5537530
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	|
	|-RVA: 0x5537AD8 Offset: 0x5533AD8 VA: 0x5537AD8
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x5538208 Offset: 0x5534208 VA: 0x5538208
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|
	|-RVA: 0x5538794 Offset: 0x5534794 VA: 0x5538794
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|
	|-RVA: 0x5538D64 Offset: 0x5534D64 VA: 0x5538D64
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x553959C Offset: 0x553559C VA: 0x553959C
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x5539B50 Offset: 0x5535B50 VA: 0x5539B50
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x553A120 Offset: 0x5536120 VA: 0x553A120
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	|
	|-RVA: 0x553AE1C Offset: 0x5536E1C VA: 0x553AE1C
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5537538 Offset: 0x5533538 VA: 0x5537538
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x5537AE0 Offset: 0x5533AE0 VA: 0x5537AE0
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x5538210 Offset: 0x5534210 VA: 0x5538210
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x553879C Offset: 0x553479C VA: 0x553879C
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x5538D6C Offset: 0x5534D6C VA: 0x5538D6C
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x55395A4 Offset: 0x55355A4 VA: 0x55395A4
	|-TMP_TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x5539B58 Offset: 0x5535B58 VA: 0x5539B58
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x553A128 Offset: 0x5536128 VA: 0x553A128
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x553AE68 Offset: 0x5536E68 VA: 0x553AE68
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55375C4 Offset: 0x55335C4 VA: 0x55375C4
	|-TMP_TextProcessingStack<Color32>.Clear
	|
	|-RVA: 0x5537BA4 Offset: 0x5533BA4 VA: 0x5537BA4
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x553829C Offset: 0x553429C VA: 0x553829C
	|-TMP_TextProcessingStack<int>.Clear
	|
	|-RVA: 0x5538828 Offset: 0x5534828 VA: 0x5538828
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x5538E48 Offset: 0x5534E48 VA: 0x5538E48
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x5539630 Offset: 0x5535630 VA: 0x5539630
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x5539BEC Offset: 0x5535BEC VA: 0x5539BEC
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x553A1F8 Offset: 0x55361F8 VA: 0x553A1F8
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x553B034 Offset: 0x5537034 VA: 0x553B034
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55375D0 Offset: 0x55335D0 VA: 0x55375D0
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x5537BB0 Offset: 0x5533BB0 VA: 0x5537BB0
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x55382A8 Offset: 0x55342A8 VA: 0x55382A8
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x5538834 Offset: 0x5534834 VA: 0x5538834
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x5538E54 Offset: 0x5534E54 VA: 0x5538E54
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x553963C Offset: 0x553563C VA: 0x553963C
	|-TMP_TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x5539BF8 Offset: 0x5535BF8 VA: 0x5539BF8
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x553A204 Offset: 0x5536204 VA: 0x553A204
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x553B0AC Offset: 0x55370AC VA: 0x553B0AC
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5537660 Offset: 0x5533660 VA: 0x5537660
	|-TMP_TextProcessingStack<Color32>.Add
	|
	|-RVA: 0x5537C98 Offset: 0x5533C98 VA: 0x5537C98
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x5538338 Offset: 0x5534338 VA: 0x5538338
	|-TMP_TextProcessingStack<int>.Add
	|
	|-RVA: 0x55388C4 Offset: 0x55348C4 VA: 0x55388C4
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0x5538F6C Offset: 0x5534F6C VA: 0x5538F6C
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x55396D4 Offset: 0x55356D4 VA: 0x55396D4
	|-TMP_TextProcessingStack<object>.Add
	|
	|-RVA: 0x5539C88 Offset: 0x5535C88 VA: 0x5539C88
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x553A304 Offset: 0x5536304 VA: 0x553A304
	|-TMP_TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x553B368 Offset: 0x5537368 VA: 0x553B368
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55376A8 Offset: 0x55336A8 VA: 0x55376A8
	|-TMP_TextProcessingStack<Color32>.Remove
	|
	|-RVA: 0x5537D08 Offset: 0x5533D08 VA: 0x5537D08
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x5538380 Offset: 0x5534380 VA: 0x5538380
	|-TMP_TextProcessingStack<int>.Remove
	|
	|-RVA: 0x553890C Offset: 0x553490C VA: 0x553890C
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0x5538FFC Offset: 0x5534FFC VA: 0x5538FFC
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x5539724 Offset: 0x5535724 VA: 0x5539724
	|-TMP_TextProcessingStack<object>.Remove
	|
	|-RVA: 0x5539CCC Offset: 0x5535CCC VA: 0x5539CCC
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x553A390 Offset: 0x5536390 VA: 0x553A390
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x553B5F4 Offset: 0x55375F4 VA: 0x553B5F4
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x553770C Offset: 0x553370C VA: 0x553770C
	|-TMP_TextProcessingStack<Color32>.Push
	|
	|-RVA: 0x5537D80 Offset: 0x5533D80 VA: 0x5537D80
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x55383E4 Offset: 0x55343E4 VA: 0x55383E4
	|-TMP_TextProcessingStack<int>.Push
	|
	|-RVA: 0x5538970 Offset: 0x5534970 VA: 0x5538970
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x553907C Offset: 0x553507C VA: 0x553907C
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x5539788 Offset: 0x5535788 VA: 0x5539788
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x5539D30 Offset: 0x5535D30 VA: 0x5539D30
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x553A400 Offset: 0x5536400 VA: 0x553A400
	|-TMP_TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x553B828 Offset: 0x5537828 VA: 0x553B828
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55377D4 Offset: 0x55337D4 VA: 0x55377D4
	|-TMP_TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0x5537E80 Offset: 0x5533E80 VA: 0x5537E80
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x55384AC Offset: 0x55344AC VA: 0x55384AC
	|-TMP_TextProcessingStack<int>.Pop
	|
	|-RVA: 0x5538A38 Offset: 0x5534A38 VA: 0x5538A38
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x55391A4 Offset: 0x55351A4 VA: 0x55391A4
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x5539858 Offset: 0x5535858 VA: 0x5539858
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x5539DFC Offset: 0x5535DFC VA: 0x5539DFC
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x553A518 Offset: 0x5536518 VA: 0x553A518
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x553BDCC Offset: 0x5537DCC VA: 0x553BDCC
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5537860 Offset: 0x5533860 VA: 0x5537860
	|-TMP_TextProcessingStack<Color32>.Peek
	|
	|-RVA: 0x5537F74 Offset: 0x5533F74 VA: 0x5537F74
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x5538538 Offset: 0x5534538 VA: 0x5538538
	|-TMP_TextProcessingStack<int>.Peek
	|
	|-RVA: 0x5538AC4 Offset: 0x5534AC4 VA: 0x5538AC4
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0x55392EC Offset: 0x55352EC VA: 0x55392EC
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x55398F4 Offset: 0x55358F4 VA: 0x55398F4
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x5539E84 Offset: 0x5535E84 VA: 0x5539E84
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x553A638 Offset: 0x5536638 VA: 0x553A638
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x553C3AC Offset: 0x55383AC VA: 0x553C3AC
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55378A8 Offset: 0x55338A8 VA: 0x55378A8
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	|
	|-RVA: 0x5537FCC Offset: 0x5533FCC VA: 0x5537FCC
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x5538580 Offset: 0x5534580 VA: 0x5538580
	|-TMP_TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x5538B0C Offset: 0x5534B0C VA: 0x5538B0C
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x553934C Offset: 0x553534C VA: 0x553934C
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x553993C Offset: 0x553593C VA: 0x553993C
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x5539ECC Offset: 0x5535ECC VA: 0x5539ECC
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x553A688 Offset: 0x5536688 VA: 0x553A688
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x553C54C Offset: 0x553854C VA: 0x553C54C
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55378F4 Offset: 0x55338F4 VA: 0x55378F4
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	|
	|-RVA: 0x553802C Offset: 0x553402C VA: 0x553802C
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x55385CC Offset: 0x55345CC VA: 0x55385CC
	|-TMP_TextProcessingStack<int>.PreviousItem
	|
	|-RVA: 0x5538B58 Offset: 0x5534B58 VA: 0x5538B58
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x55393B4 Offset: 0x55353B4 VA: 0x55393B4
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x5539988 Offset: 0x5535988 VA: 0x5539988
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x5539F18 Offset: 0x5535F18 VA: 0x5539F18
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x553A6E0 Offset: 0x55366E0 VA: 0x553A6E0
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	|
	|-RVA: 0x553C6EC Offset: 0x55386EC VA: 0x553C6EC
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.PreviousItem
	*/
}

// Namespace: TMPro
public enum CaretPosition // TypeDefIndex: 21859
{
	// Fields
	public int value__; // 0x0
	public const CaretPosition None = 0;
	public const CaretPosition Left = 1;
	public const CaretPosition Right = 2;
}

// Namespace: TMPro
public struct CaretInfo // TypeDefIndex: 21860
{
	// Fields
	public int index; // 0x0
	public CaretPosition position; // 0x4

	// Methods

	// RVA: 0x86A01A8 Offset: 0x869C1A8 VA: 0x86A01A8
	public void .ctor(int index, CaretPosition position) { }
}

// Namespace: 
private struct TMP_TextUtilities.LineSegment // TypeDefIndex: 21861
{
	// Fields
	public Vector3 Point1; // 0x0
	public Vector3 Point2; // 0xC

	// Methods

	// RVA: 0x86A3040 Offset: 0x869F040 VA: 0x86A3040
	public void .ctor(Vector3 p1, Vector3 p2) { }
}

// Namespace: TMPro
public static class TMP_TextUtilities // TypeDefIndex: 21862
{
	// Fields
	private static Vector3[] m_rectWorldCorners; // 0x0
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Methods

	// RVA: 0x86A01B0 Offset: 0x869C1B0 VA: 0x86A01B0
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x86A0960 Offset: 0x869C960 VA: 0x86A0960
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x86A0B40 Offset: 0x869CB40 VA: 0x86A0B40
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x86A0CC0 Offset: 0x869CCC0 VA: 0x86A0CC0
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x86A11B4 Offset: 0x869D1B4 VA: 0x86A11B4
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x86A12D0 Offset: 0x869D2D0 VA: 0x86A12D0
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x86A0314 Offset: 0x869C314 VA: 0x86A0314
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x86A14D8 Offset: 0x869D4D8 VA: 0x86A14D8
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x86A18E8 Offset: 0x869D8E8 VA: 0x86A18E8
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x86A1EAC Offset: 0x869DEAC VA: 0x86A1EAC
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x86A2004 Offset: 0x869E004 VA: 0x86A2004
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x86A2344 Offset: 0x869E344 VA: 0x86A2344
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x86A102C Offset: 0x869D02C VA: 0x86A102C
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x86A063C Offset: 0x869C63C VA: 0x86A063C
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x86A2A58 Offset: 0x869EA58 VA: 0x86A2A58
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x86A10EC Offset: 0x869D0EC VA: 0x86A10EC
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x86A2BC8 Offset: 0x869EBC8 VA: 0x86A2BC8
	public static char ToLowerFast(char c) { }

	// RVA: 0x86A2C3C Offset: 0x869EC3C VA: 0x86A2C3C
	public static char ToUpperFast(char c) { }

	// RVA: 0x86A2CB0 Offset: 0x869ECB0 VA: 0x86A2CB0
	internal static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x86A2D24 Offset: 0x869ED24 VA: 0x86A2D24
	public static int GetHashCode(string s) { }

	// RVA: 0x869A40C Offset: 0x869640C VA: 0x869A40C
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x86A2DE0 Offset: 0x869EDE0 VA: 0x86A2DE0
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x86A2E9C Offset: 0x869EE9C VA: 0x86A2E9C
	public static int HexToInt(char hex) { }

	// RVA: 0x86A2EC8 Offset: 0x869EEC8 VA: 0x86A2EC8
	public static int StringHexToInt(string s) { }

	// RVA: 0x86A2FCC Offset: 0x869EFCC VA: 0x86A2FCC
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_UpdateManager // TypeDefIndex: 21863
{
	// Fields
	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly HashSet<int> m_LayoutQueueLookup; // 0x10
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x18
	private readonly HashSet<int> m_GraphicQueueLookup; // 0x20
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x28
	private readonly HashSet<int> m_InternalUpdateLookup; // 0x30
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x38
	private readonly HashSet<int> m_CullingUpdateLookup; // 0x40
	private readonly List<TMP_Text> m_CullingUpdateQueue; // 0x48
	private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; // 0x8
	private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; // 0x10
	private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; // 0x18
	private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; // 0x20
	private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; // 0x28

	// Properties
	private static TMP_UpdateManager instance { get; }

	// Methods

	// RVA: 0x86A3050 Offset: 0x869F050 VA: 0x86A3050
	private static TMP_UpdateManager get_instance() { }

	// RVA: 0x86A3100 Offset: 0x869F100 VA: 0x86A3100
	private void .ctor() { }

	// RVA: 0x86A330C Offset: 0x869F30C VA: 0x86A330C
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x86A336C Offset: 0x869F36C VA: 0x86A336C
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x86A3490 Offset: 0x869F490 VA: 0x86A3490
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x86A34F0 Offset: 0x869F4F0 VA: 0x86A34F0
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x86A3614 Offset: 0x869F614 VA: 0x86A3614
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x86A3674 Offset: 0x869F674 VA: 0x86A3674
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x86A3798 Offset: 0x869F798 VA: 0x86A3798
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x86A37F8 Offset: 0x869F7F8 VA: 0x86A37F8
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x86A391C Offset: 0x869F91C VA: 0x86A391C
	private void OnCameraPreCull() { }

	// RVA: 0x86A3920 Offset: 0x869F920 VA: 0x86A3920
	private void DoRebuilds() { }

	// RVA: 0x86A3B74 Offset: 0x869FB74 VA: 0x86A3B74
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x86A3C6C Offset: 0x869FC6C VA: 0x86A3C6C
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x86A3CEC Offset: 0x869FCEC VA: 0x86A3CEC
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x86A3D84 Offset: 0x869FD84 VA: 0x86A3D84
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x86A3BD4 Offset: 0x869FBD4 VA: 0x86A3BD4
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x86A3E1C Offset: 0x869FE1C VA: 0x86A3E1C
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_UpdateRegistry // TypeDefIndex: 21864
{
	// Fields
	private static TMP_UpdateRegistry s_Instance; // 0x0
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
	private HashSet<int> m_LayoutQueueLookup; // 0x18
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private HashSet<int> m_GraphicQueueLookup; // 0x28

	// Properties
	public static TMP_UpdateRegistry instance { get; }

	// Methods

	// RVA: 0x86A3F80 Offset: 0x869FF80 VA: 0x86A3F80
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x86A4004 Offset: 0x86A0004 VA: 0x86A4004
	protected void .ctor() { }

	// RVA: 0x86A4180 Offset: 0x86A0180 VA: 0x86A4180
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x86A41A0 Offset: 0x86A01A0 VA: 0x86A41A0
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x86A4304 Offset: 0x86A0304 VA: 0x86A4304
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x86A4324 Offset: 0x86A0324 VA: 0x86A4324
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x86A4488 Offset: 0x86A0488 VA: 0x86A4488
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x86A46E4 Offset: 0x86A06E4 VA: 0x86A46E4
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x86A474C Offset: 0x86A074C VA: 0x86A474C
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x86A477C Offset: 0x86A077C VA: 0x86A477C
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x86A4858 Offset: 0x86A0858 VA: 0x86A4858
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }
}

// Namespace: TMPro.SpriteAssetUtilities
public enum SpriteAssetImportFormats // TypeDefIndex: 21865
{
	// Fields
	public int value__; // 0x0
	public const SpriteAssetImportFormats None = 0;
	public const SpriteAssetImportFormats TexturePackerJsonArray = 1;
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.SpriteFrame // TypeDefIndex: 21866
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float w; // 0x8
	public float h; // 0xC

	// Methods

	// RVA: 0x86A493C Offset: 0x86A093C VA: 0x86A493C Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.SpriteSize // TypeDefIndex: 21867
{
	// Fields
	public float w; // 0x0
	public float h; // 0x4

	// Methods

	// RVA: 0x86A4B44 Offset: 0x86A0B44 VA: 0x86A4B44 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.Frame // TypeDefIndex: 21868
{
	// Fields
	public string filename; // 0x0
	public TexturePacker_JsonArray.SpriteFrame frame; // 0x8
	public bool rotated; // 0x18
	public bool trimmed; // 0x19
	public TexturePacker_JsonArray.SpriteFrame spriteSourceSize; // 0x1C
	public TexturePacker_JsonArray.SpriteSize sourceSize; // 0x2C
	public Vector2 pivot; // 0x34
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.Meta // TypeDefIndex: 21869
{
	// Fields
	public string app; // 0x0
	public string version; // 0x8
	public string image; // 0x10
	public string format; // 0x18
	public TexturePacker_JsonArray.SpriteSize size; // 0x20
	public float scale; // 0x28
	public string smartupdate; // 0x30
}

// Namespace: 
[Serializable]
public class TexturePacker_JsonArray.SpriteDataObject // TypeDefIndex: 21870
{
	// Fields
	public List<TexturePacker_JsonArray.Frame> frames; // 0x10
	public TexturePacker_JsonArray.Meta meta; // 0x18

	// Methods

	// RVA: 0x86A4BF0 Offset: 0x86A0BF0 VA: 0x86A4BF0
	public void .ctor() { }
}

// Namespace: TMPro.SpriteAssetUtilities
public class TexturePacker_JsonArray // TypeDefIndex: 21871
{
	// Methods

	// RVA: 0x86A4934 Offset: 0x86A0934 VA: 0x86A4934
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 21872
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3551 // TypeDefIndex: 21873
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5236 // TypeDefIndex: 21874
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 21875
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB /*Metadata offset 0xF14B28*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5236 28151F9F060FF60EEF78172E7E7E46DEA49A59E4122A3E5F52BB749EDC98756F /*Metadata offset 0xF14B38*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3551 8888F405A0F13565CE61E72C16289D7F52D50B6F9F074009144957058CC0160C /*Metadata offset 0xF15FB0*/; // 0x1480
}

