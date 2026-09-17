// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28412
{}

// Namespace: UnityEngine
public interface ICanvasRaycastFilter // TypeDefIndex: 28413
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/CanvasGroup.h")]
[NativeClass("UI::CanvasGroup")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 28414
{
	// Properties
	[NativeProperty("Alpha", False, 0)]
	public float alpha { get; set; }
	[NativeProperty("Interactable", False, 0)]
	public bool interactable { get; set; }
	[NativeProperty("BlocksRaycasts", False, 0)]
	public bool blocksRaycasts { get; set; }
	[NativeProperty("IgnoreParentGroups", False, 0)]
	public bool ignoreParentGroups { get; set; }

	// Methods

	// RVA: 0x897D29C Offset: 0x897929C VA: 0x897D29C
	public float get_alpha() { }

	// RVA: 0x897D2D8 Offset: 0x89792D8 VA: 0x897D2D8
	public void set_alpha(float value) { }

	// RVA: 0x897D324 Offset: 0x8979324 VA: 0x897D324
	public bool get_interactable() { }

	// RVA: 0x897D360 Offset: 0x8979360 VA: 0x897D360
	public void set_interactable(bool value) { }

	// RVA: 0x897D3A4 Offset: 0x89793A4 VA: 0x897D3A4
	public bool get_blocksRaycasts() { }

	// RVA: 0x897D3E0 Offset: 0x89793E0 VA: 0x897D3E0
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x897D424 Offset: 0x8979424 VA: 0x897D424
	public bool get_ignoreParentGroups() { }

	// RVA: 0x897D460 Offset: 0x8979460 VA: 0x897D460
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x897D4A4 Offset: 0x89794A4 VA: 0x897D4A4 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x897D4E0 Offset: 0x89794E0 VA: 0x897D4E0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeClass("UI::CanvasRenderer")]
[NativeHeader("Modules/UI/CanvasRenderer.h")]
public sealed class CanvasRenderer : Component // TypeDefIndex: 28415
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { get; set; }
	public int materialCount { get; set; }
	public int popMaterialCount { get; set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	public bool cullTransparentMesh { get; set; }
	[NativeProperty("RectClipping", False, 0)]
	public bool hasRectClipping { get; }
	[NativeProperty("Depth", False, 0)]
	public int relativeDepth { get; }
	[NativeProperty("ShouldCull", False, 0)]
	public bool cull { get; set; }
	[Obsolete("isMask is no longer supported.See EnableClipping for vertex clipping configuration", False)]
	public bool isMask { get; set; }
	public Vector2 clippingSoftness { get; set; }

	// Methods

	// RVA: 0x897D4E8 Offset: 0x89794E8 VA: 0x897D4E8
	public bool get_hasPopInstruction() { }

	// RVA: 0x897D524 Offset: 0x8979524 VA: 0x897D524
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x897D568 Offset: 0x8979568 VA: 0x897D568
	public int get_materialCount() { }

	// RVA: 0x897D5A4 Offset: 0x89795A4 VA: 0x897D5A4
	public void set_materialCount(int value) { }

	// RVA: 0x897D5E8 Offset: 0x89795E8 VA: 0x897D5E8
	public int get_popMaterialCount() { }

	// RVA: 0x897D624 Offset: 0x8979624 VA: 0x897D624
	public void set_popMaterialCount(int value) { }

	// RVA: 0x897D668 Offset: 0x8979668 VA: 0x897D668
	public int get_absoluteDepth() { }

	// RVA: 0x897D6A4 Offset: 0x89796A4 VA: 0x897D6A4
	public bool get_hasMoved() { }

	// RVA: 0x897D6E0 Offset: 0x89796E0 VA: 0x897D6E0
	public bool get_cullTransparentMesh() { }

	// RVA: 0x897D71C Offset: 0x897971C VA: 0x897D71C
	public void set_cullTransparentMesh(bool value) { }

	// RVA: 0x897D760 Offset: 0x8979760 VA: 0x897D760
	public bool get_hasRectClipping() { }

	// RVA: 0x897D79C Offset: 0x897979C VA: 0x897D79C
	public int get_relativeDepth() { }

	// RVA: 0x897D7D8 Offset: 0x89797D8 VA: 0x897D7D8
	public bool get_cull() { }

	// RVA: 0x897D814 Offset: 0x8979814 VA: 0x897D814
	public void set_cull(bool value) { }

	[CompilerGenerated]
	// RVA: 0x897D858 Offset: 0x8979858 VA: 0x897D858
	public bool get_isMask() { }

	[CompilerGenerated]
	// RVA: 0x897D860 Offset: 0x8979860 VA: 0x897D860
	public void set_isMask(bool value) { }

	// RVA: 0x897D86C Offset: 0x897986C VA: 0x897D86C
	public void SetColor(Color color) { }

	// RVA: 0x897D904 Offset: 0x8979904 VA: 0x897D904
	public Color GetColor() { }

	// RVA: 0x897D9A0 Offset: 0x89799A0 VA: 0x897D9A0
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x897DA38 Offset: 0x8979A38 VA: 0x897DA38
	public Vector2 get_clippingSoftness() { }

	// RVA: 0x897DAC8 Offset: 0x8979AC8 VA: 0x897DAC8
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x897DB54 Offset: 0x8979B54 VA: 0x897DB54
	public void DisableRectClipping() { }

	// RVA: 0x897DB90 Offset: 0x8979B90 VA: 0x897DB90
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x897DBE4 Offset: 0x8979BE4 VA: 0x897DBE4
	public Material GetMaterial(int index) { }

	// RVA: 0x897DC28 Offset: 0x8979C28 VA: 0x897DC28
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x897DC7C Offset: 0x8979C7C VA: 0x897DC7C
	public Material GetPopMaterial(int index) { }

	// RVA: 0x897DCC0 Offset: 0x8979CC0 VA: 0x897DCC0
	public void SetTexture(Texture texture) { }

	// RVA: 0x897DD04 Offset: 0x8979D04 VA: 0x897DD04
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x897DD48 Offset: 0x8979D48 VA: 0x897DD48
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x897DD8C Offset: 0x8979D8C VA: 0x897DD8C
	public Mesh GetMesh() { }

	// RVA: 0x897DDC8 Offset: 0x8979DC8 VA: 0x897DDC8
	public void Clear() { }

	// RVA: 0x897DE04 Offset: 0x8979E04 VA: 0x897DE04
	public float GetAlpha() { }

	// RVA: 0x897DE18 Offset: 0x8979E18 VA: 0x897DE18
	public void SetAlpha(float alpha) { }

	// RVA: 0x897DE40 Offset: 0x8979E40 VA: 0x897DE40
	public float GetInheritedAlpha() { }

	// RVA: 0x897DE7C Offset: 0x8979E7C VA: 0x897DE7C
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x897DFA4 Offset: 0x8979FA4 VA: 0x897DFA4
	public Material GetMaterial() { }

	// RVA: 0x897DFE4 Offset: 0x8979FE4 VA: 0x897DFE4
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x897E0CC Offset: 0x897A0CC VA: 0x897E0CC
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x897E27C Offset: 0x897A27C VA: 0x897E27C
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x897E384 Offset: 0x897A384 VA: 0x897E384
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x897E4BC Offset: 0x897A4BC VA: 0x897E4BC
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents) { }

	// RVA: 0x897E5C0 Offset: 0x897A5C0 VA: 0x897E5C0
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", False)]
	// RVA: 0x897E65C Offset: 0x897A65C VA: 0x897E65C
	public void SetVertices(List<UIVertex> vertices) { }

	[Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", False)]
	// RVA: 0x897E6CC Offset: 0x897A6CC VA: 0x897E6CC
	public void SetVertices(UIVertex[] vertices, int size) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x897E238 Offset: 0x897A238 VA: 0x897E238
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x897E19C Offset: 0x897A19C VA: 0x897E19C
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x897E420 Offset: 0x897A420 VA: 0x897E420
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x897F060 Offset: 0x897B060 VA: 0x897F060
	public void .ctor() { }

	// RVA: 0x897D8C0 Offset: 0x89798C0 VA: 0x897D8C0
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x897D95C Offset: 0x897995C VA: 0x897D95C
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x897D9F4 Offset: 0x89799F4 VA: 0x897D9F4
	private void EnableRectClipping_Injected(ref Rect rect) { }

	// RVA: 0x897DA84 Offset: 0x8979A84 VA: 0x897DA84
	private void get_clippingSoftness_Injected(out Vector2 ret) { }

	// RVA: 0x897DB10 Offset: 0x8979B10 VA: 0x897DB10
	private void set_clippingSoftness_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Transform/RectTransform.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI", 2)]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Modules/UI/RectTransformUtil.h")]
public sealed class RectTransformUtility // TypeDefIndex: 28416
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x897F068 Offset: 0x897B068 VA: 0x897F068
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x897F168 Offset: 0x897B168 VA: 0x897F168
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x897F25C Offset: 0x897B25C VA: 0x897F25C
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x897F360 Offset: 0x897B360 VA: 0x897F360
	private void .ctor() { }

	// RVA: 0x897F368 Offset: 0x897B368 VA: 0x897F368
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint) { }

	// RVA: 0x897F3D8 Offset: 0x897B3D8 VA: 0x897F3D8
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x897F4AC Offset: 0x897B4AC VA: 0x897F4AC
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x897F558 Offset: 0x897B558 VA: 0x897F558
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x897FB34 Offset: 0x897BB34 VA: 0x897FB34
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x897F97C Offset: 0x897B97C VA: 0x897F97C
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x897FC30 Offset: 0x897BC30 VA: 0x897FC30
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x897FCE0 Offset: 0x897BCE0 VA: 0x897FCE0
	public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child) { }

	// RVA: 0x8980000 Offset: 0x897C000 VA: 0x8980000
	public static Bounds CalculateRelativeRectTransformBounds(Transform trans) { }

	// RVA: 0x8980088 Offset: 0x897C088 VA: 0x8980088
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x8980348 Offset: 0x897C348 VA: 0x8980348
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x89805A0 Offset: 0x897C5A0 VA: 0x89805A0
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x89805B0 Offset: 0x897C5B0 VA: 0x89805B0
	private static void .cctor() { }

	// RVA: 0x897F10C Offset: 0x897B10C VA: 0x897F10C
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x897F208 Offset: 0x897B208 VA: 0x897F208
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x897F304 Offset: 0x897B304 VA: 0x897F304
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) { }
}

// Namespace: UnityEngine
public enum RenderMode // TypeDefIndex: 28417
{
	// Fields
	public int value__; // 0x0
	public const RenderMode ScreenSpaceOverlay = 0;
	public const RenderMode ScreenSpaceCamera = 1;
	public const RenderMode WorldSpace = 2;
}

// Namespace: UnityEngine
public enum StandaloneRenderResize // TypeDefIndex: 28418
{
	// Fields
	public int value__; // 0x0
	public const StandaloneRenderResize Enabled = 0;
	public const StandaloneRenderResize Disabled = 1;
}

// Namespace: UnityEngine
[Flags]
public enum AdditionalCanvasShaderChannels // TypeDefIndex: 28419
{
	// Fields
	public int value__; // 0x0
	public const AdditionalCanvasShaderChannels None = 0;
	public const AdditionalCanvasShaderChannels TexCoord1 = 1;
	public const AdditionalCanvasShaderChannels TexCoord2 = 2;
	public const AdditionalCanvasShaderChannels TexCoord3 = 4;
	public const AdditionalCanvasShaderChannels Normal = 8;
	public const AdditionalCanvasShaderChannels Tangent = 16;
}

// Namespace: 
public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 28420
{
	// Methods

	// RVA: 0x89818B4 Offset: 0x897D8B4 VA: 0x89818B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x8981950 Offset: 0x897D950 VA: 0x8981950 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/Canvas.h")]
[RequireComponent(typeof(RectTransform))]
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeClass("UI::Canvas")]
public sealed class Canvas : Behaviour // TypeDefIndex: 28421
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases preWillRenderCanvases; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int> <externBeginRenderOverlays>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int, int> <externRenderOverlaysBefore>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int> <externEndRenderOverlays>k__BackingField; // 0x20

	// Properties
	public RenderMode renderMode { get; set; }
	public bool isRootCanvas { get; }
	public Rect pixelRect { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool overridePixelPerfect { get; set; }
	public bool vertexColorAlwaysGammaSpace { get; set; }
	public bool pixelPerfect { get; set; }
	public float planeDistance { get; set; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; set; }
	public int sortingLayerID { get; set; }
	public int cachedSortingLayerValue { get; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public string sortingLayerName { get; set; }
	public Canvas rootCanvas { get; }
	public Vector2 renderingDisplaySize { get; }
	public StandaloneRenderResize updateRectTransformForStandalone { get; set; }
	internal static Action<int> externBeginRenderOverlays { get; set; }
	internal static Action<int, int> externRenderOverlaysBefore { get; set; }
	internal static Action<int> externEndRenderOverlays { get; set; }
	[NativeProperty("Camera", False, 0)]
	public Camera worldCamera { get; set; }
	[NativeProperty("SortingBucketNormalizedSize", False, 0)]
	public float normalizedSortingGridSize { get; set; }
	[NativeProperty("SortingBucketNormalizedSize", False, 0)]
	[Obsolete("Setting normalizedSize via a int is not supported. Please use normalizedSortingGridSize", False)]
	public int sortingGridNormalizedSize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8980624 Offset: 0x897C624 VA: 0x8980624
	public static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x89806DC Offset: 0x897C6DC VA: 0x89806DC
	public static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x8980794 Offset: 0x897C794 VA: 0x8980794
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x8980850 Offset: 0x897C850 VA: 0x8980850
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x898090C Offset: 0x897C90C VA: 0x898090C
	public RenderMode get_renderMode() { }

	// RVA: 0x8980948 Offset: 0x897C948 VA: 0x8980948
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x898098C Offset: 0x897C98C VA: 0x898098C
	public bool get_isRootCanvas() { }

	// RVA: 0x89809C8 Offset: 0x897C9C8 VA: 0x89809C8
	public Rect get_pixelRect() { }

	// RVA: 0x8980A64 Offset: 0x897CA64 VA: 0x8980A64
	public float get_scaleFactor() { }

	// RVA: 0x8980AA0 Offset: 0x897CAA0 VA: 0x8980AA0
	public void set_scaleFactor(float value) { }

	// RVA: 0x8980AEC Offset: 0x897CAEC VA: 0x8980AEC
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x8980B28 Offset: 0x897CB28 VA: 0x8980B28
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x8980B74 Offset: 0x897CB74 VA: 0x8980B74
	public bool get_overridePixelPerfect() { }

	// RVA: 0x8980BB0 Offset: 0x897CBB0 VA: 0x8980BB0
	public void set_overridePixelPerfect(bool value) { }

	// RVA: 0x8980BF4 Offset: 0x897CBF4 VA: 0x8980BF4
	public bool get_vertexColorAlwaysGammaSpace() { }

	// RVA: 0x8980C30 Offset: 0x897CC30 VA: 0x8980C30
	public void set_vertexColorAlwaysGammaSpace(bool value) { }

	// RVA: 0x8980C74 Offset: 0x897CC74 VA: 0x8980C74
	public bool get_pixelPerfect() { }

	// RVA: 0x8980CB0 Offset: 0x897CCB0 VA: 0x8980CB0
	public void set_pixelPerfect(bool value) { }

	// RVA: 0x8980CF4 Offset: 0x897CCF4 VA: 0x8980CF4
	public float get_planeDistance() { }

	// RVA: 0x8980D30 Offset: 0x897CD30 VA: 0x8980D30
	public void set_planeDistance(float value) { }

	// RVA: 0x8980D7C Offset: 0x897CD7C VA: 0x8980D7C
	public int get_renderOrder() { }

	// RVA: 0x8980DB8 Offset: 0x897CDB8 VA: 0x8980DB8
	public bool get_overrideSorting() { }

	// RVA: 0x8980DF4 Offset: 0x897CDF4 VA: 0x8980DF4
	public void set_overrideSorting(bool value) { }

	// RVA: 0x8980E38 Offset: 0x897CE38 VA: 0x8980E38
	public int get_sortingOrder() { }

	// RVA: 0x8980E74 Offset: 0x897CE74 VA: 0x8980E74
	public void set_sortingOrder(int value) { }

	// RVA: 0x8980EB8 Offset: 0x897CEB8 VA: 0x8980EB8
	public int get_targetDisplay() { }

	// RVA: 0x8980EF4 Offset: 0x897CEF4 VA: 0x8980EF4
	public void set_targetDisplay(int value) { }

	// RVA: 0x8980F38 Offset: 0x897CF38 VA: 0x8980F38
	public int get_sortingLayerID() { }

	// RVA: 0x8980F74 Offset: 0x897CF74 VA: 0x8980F74
	public void set_sortingLayerID(int value) { }

	// RVA: 0x8980FB8 Offset: 0x897CFB8 VA: 0x8980FB8
	public int get_cachedSortingLayerValue() { }

	// RVA: 0x8980FF4 Offset: 0x897CFF4 VA: 0x8980FF4
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x8981030 Offset: 0x897D030 VA: 0x8981030
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x8981074 Offset: 0x897D074 VA: 0x8981074
	public string get_sortingLayerName() { }

	// RVA: 0x89810B0 Offset: 0x897D0B0 VA: 0x89810B0
	public void set_sortingLayerName(string value) { }

	// RVA: 0x89810F4 Offset: 0x897D0F4 VA: 0x89810F4
	public Canvas get_rootCanvas() { }

	// RVA: 0x8981130 Offset: 0x897D130 VA: 0x8981130
	public Vector2 get_renderingDisplaySize() { }

	// RVA: 0x89811C0 Offset: 0x897D1C0 VA: 0x89811C0
	public StandaloneRenderResize get_updateRectTransformForStandalone() { }

	// RVA: 0x89811FC Offset: 0x897D1FC VA: 0x89811FC
	public void set_updateRectTransformForStandalone(StandaloneRenderResize value) { }

	[CompilerGenerated]
	// RVA: 0x8981240 Offset: 0x897D240 VA: 0x8981240
	internal static Action<int> get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	// RVA: 0x8981288 Offset: 0x897D288 VA: 0x8981288
	internal static void set_externBeginRenderOverlays(Action<int> value) { }

	[CompilerGenerated]
	// RVA: 0x89812D8 Offset: 0x897D2D8 VA: 0x89812D8
	internal static Action<int, int> get_externRenderOverlaysBefore() { }

	[CompilerGenerated]
	// RVA: 0x8981320 Offset: 0x897D320 VA: 0x8981320
	internal static void set_externRenderOverlaysBefore(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x8981370 Offset: 0x897D370 VA: 0x8981370
	internal static Action<int> get_externEndRenderOverlays() { }

	[CompilerGenerated]
	// RVA: 0x89813B8 Offset: 0x897D3B8 VA: 0x89813B8
	internal static void set_externEndRenderOverlays(Action<int> value) { }

	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	// RVA: 0x8981408 Offset: 0x897D408 VA: 0x8981408
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x8981444 Offset: 0x897D444 VA: 0x8981444
	public Camera get_worldCamera() { }

	// RVA: 0x8981480 Offset: 0x897D480 VA: 0x8981480
	public void set_worldCamera(Camera value) { }

	// RVA: 0x89814C4 Offset: 0x897D4C4 VA: 0x89814C4
	public float get_normalizedSortingGridSize() { }

	// RVA: 0x8981500 Offset: 0x897D500 VA: 0x8981500
	public void set_normalizedSortingGridSize(float value) { }

	// RVA: 0x898154C Offset: 0x897D54C VA: 0x898154C
	public int get_sortingGridNormalizedSize() { }

	// RVA: 0x8981588 Offset: 0x897D588 VA: 0x8981588
	public void set_sortingGridNormalizedSize(int value) { }

	[Obsolete("Shared default material now used for text and general UI elements, call Canvas.GetDefaultCanvasMaterial()", False)]
	[FreeFunction("UI::GetDefaultUIMaterial")]
	// RVA: 0x89815CC Offset: 0x897D5CC VA: 0x89815CC
	public static Material GetDefaultCanvasTextMaterial() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	// RVA: 0x89815F4 Offset: 0x897D5F4 VA: 0x89815F4
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	// RVA: 0x898161C Offset: 0x897D61C VA: 0x898161C
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x8981644 Offset: 0x897D644 VA: 0x8981644
	internal void UpdateCanvasRectTransform(bool alignWithCamera) { }

	// RVA: 0x8981688 Offset: 0x897D688 VA: 0x8981688
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x8981698 Offset: 0x897D698 VA: 0x8981698
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x89816FC Offset: 0x897D6FC VA: 0x89816FC
	private static void SendWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x8981760 Offset: 0x897D760 VA: 0x8981760
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	// RVA: 0x89817CC Offset: 0x897D7CC VA: 0x89817CC
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	// RVA: 0x8981840 Offset: 0x897D840 VA: 0x8981840
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x89818AC Offset: 0x897D8AC VA: 0x89818AC
	public void .ctor() { }

	// RVA: 0x8980A20 Offset: 0x897CA20 VA: 0x8980A20
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x898117C Offset: 0x897D17C VA: 0x898117C
	private void get_renderingDisplaySize_Injected(out Vector2 ret) { }
}

// Namespace: 
public enum UISystemProfilerApi.SampleType // TypeDefIndex: 28422
{
	// Fields
	public int value__; // 0x0
	public const UISystemProfilerApi.SampleType Layout = 0;
	public const UISystemProfilerApi.SampleType Render = 1;
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/Canvas.h")]
[IgnoredByDeepProfiler]
[StaticAccessor("UI::SystemProfilerApi", 2)]
public static class UISystemProfilerApi // TypeDefIndex: 28423
{
	// Methods

	// RVA: 0x8981964 Offset: 0x897D964 VA: 0x8981964
	public static void BeginSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x89819A0 Offset: 0x897D9A0 VA: 0x89819A0
	public static void EndSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x89819DC Offset: 0x897D9DC VA: 0x89819DC
	public static void AddMarker(string name, Object obj) { }
}

