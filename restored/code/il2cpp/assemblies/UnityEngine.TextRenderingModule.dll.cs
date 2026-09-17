// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28396
{}

// Namespace: UnityEngine
public enum FontStyle // TypeDefIndex: 28397
{
	// Fields
	public int value__; // 0x0
	public const FontStyle Normal = 0;
	public const FontStyle Bold = 1;
	public const FontStyle Italic = 2;
	public const FontStyle BoldAndItalic = 3;
}

// Namespace: UnityEngine
[Flags]
internal enum TextGenerationError // TypeDefIndex: 28398
{
	// Fields
	public int value__; // 0x0
	public const TextGenerationError None = 0;
	public const TextGenerationError CustomSizeOnNonDynamicFont = 1;
	public const TextGenerationError CustomStyleOnNonDynamicFont = 2;
	public const TextGenerationError NoFont = 4;
}

// Namespace: UnityEngine
public struct TextGenerationSettings // TypeDefIndex: 28399
{
	// Fields
	public Font font; // 0x0
	public Color color; // 0x8
	public int fontSize; // 0x18
	public float lineSpacing; // 0x1C
	public bool richText; // 0x20
	public float scaleFactor; // 0x24
	public FontStyle fontStyle; // 0x28
	public TextAnchor textAnchor; // 0x2C
	public bool alignByGeometry; // 0x30
	public bool resizeTextForBestFit; // 0x31
	public int resizeTextMinSize; // 0x34
	public int resizeTextMaxSize; // 0x38
	public bool updateBounds; // 0x3C
	public VerticalWrapMode verticalOverflow; // 0x40
	public HorizontalWrapMode horizontalOverflow; // 0x44
	public Vector2 generationExtents; // 0x48
	public Vector2 pivot; // 0x50
	public bool generateOutOfBounds; // 0x58

	// Methods

	// RVA: 0x881CBA8 Offset: 0x8818BA8 VA: 0x881CBA8
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x881CCE0 Offset: 0x8818CE0 VA: 0x881CCE0
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x881CDA8 Offset: 0x8818DA8 VA: 0x881CDA8
	public bool Equals(TextGenerationSettings other) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/TextRendering/TextGenerator.h")]
[UsedByNativeCode]
public sealed class TextGenerator : IDisposable // TypeDefIndex: 28400
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int vertexCount { get; }
	public int characterCount { get; }
	public int lineCount { get; }
	[NativeProperty("FontSizeFoundForBestFit", False, 0)]
	public int fontSizeUsedForBestFit { get; }

	// Methods

	// RVA: 0x881CFC8 Offset: 0x8818FC8 VA: 0x881CFC8
	public void .ctor() { }

	// RVA: 0x881CFD0 Offset: 0x8818FD0 VA: 0x881CFD0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x881D164 Offset: 0x8819164 VA: 0x881D164 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x881D274 Offset: 0x8819274 VA: 0x881D274 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x881D30C Offset: 0x881930C VA: 0x881D30C
	public int get_characterCountVisible() { }

	// RVA: 0x881D38C Offset: 0x881938C VA: 0x881D38C
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x881D690 Offset: 0x8819690 VA: 0x881D690
	public void Invalidate() { }

	// RVA: 0x881D698 Offset: 0x8819698 VA: 0x881D698
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x881D720 Offset: 0x8819720 VA: 0x881D720
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x881D7A8 Offset: 0x88197A8 VA: 0x881D7A8
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x881D830 Offset: 0x8819830 VA: 0x881D830
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x881D93C Offset: 0x881993C VA: 0x881D93C
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x881D99C Offset: 0x881999C VA: 0x881D99C
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x881D894 Offset: 0x8819894 VA: 0x881D894
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x881DB6C Offset: 0x8819B6C VA: 0x881DB6C
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x881DBFC Offset: 0x8819BFC VA: 0x881DBFC
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x881DEC4 Offset: 0x8819EC4 VA: 0x881DEC4
	public IList<UIVertex> get_verts() { }

	// RVA: 0x881DF20 Offset: 0x8819F20 VA: 0x881DF20
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x881DF7C Offset: 0x8819F7C VA: 0x881DF7C
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x881D8E4 Offset: 0x88198E4 VA: 0x881D8E4
	public Rect get_rectExtents() { }

	// RVA: 0x881E01C Offset: 0x881A01C VA: 0x881E01C
	public int get_vertexCount() { }

	// RVA: 0x881D350 Offset: 0x8819350 VA: 0x881D350
	public int get_characterCount() { }

	// RVA: 0x881E058 Offset: 0x881A058 VA: 0x881E058
	public int get_lineCount() { }

	// RVA: 0x881E094 Offset: 0x881A094 VA: 0x881E094
	public int get_fontSizeUsedForBestFit() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x881D13C Offset: 0x881913C VA: 0x881D13C
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x881D2D0 Offset: 0x88192D0 VA: 0x881D2D0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x881E0D0 Offset: 0x881A0D0 VA: 0x881E0D0
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x881DD1C Offset: 0x8819D1C VA: 0x881DD1C
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	// RVA: 0x881E34C Offset: 0x881A34C VA: 0x881E34C
	public UIVertex[] GetVerticesArray() { }

	// RVA: 0x881E388 Offset: 0x881A388 VA: 0x881E388
	public UICharInfo[] GetCharactersArray() { }

	// RVA: 0x881E3C4 Offset: 0x881A3C4 VA: 0x881E3C4
	public UILineInfo[] GetLinesArray() { }

	[NativeThrows]
	// RVA: 0x881D7EC Offset: 0x88197EC VA: 0x881D7EC
	private void GetVerticesInternal(object vertices) { }

	[NativeThrows]
	// RVA: 0x881D6DC Offset: 0x88196DC VA: 0x881D6DC
	private void GetCharactersInternal(object characters) { }

	[NativeThrows]
	// RVA: 0x881D764 Offset: 0x8819764 VA: 0x881D764
	private void GetLinesInternal(object lines) { }

	// RVA: 0x881DFD8 Offset: 0x8819FD8 VA: 0x881DFD8
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x881E21C Offset: 0x881A21C VA: 0x881E21C
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }
}

// Namespace: UnityEngine
public enum TextAlignment // TypeDefIndex: 28401
{
	// Fields
	public int value__; // 0x0
	public const TextAlignment Left = 0;
	public const TextAlignment Center = 1;
	public const TextAlignment Right = 2;
}

// Namespace: UnityEngine
public enum TextAnchor // TypeDefIndex: 28402
{
	// Fields
	public int value__; // 0x0
	public const TextAnchor UpperLeft = 0;
	public const TextAnchor UpperCenter = 1;
	public const TextAnchor UpperRight = 2;
	public const TextAnchor MiddleLeft = 3;
	public const TextAnchor MiddleCenter = 4;
	public const TextAnchor MiddleRight = 5;
	public const TextAnchor LowerLeft = 6;
	public const TextAnchor LowerCenter = 7;
	public const TextAnchor LowerRight = 8;
}

// Namespace: UnityEngine
public enum HorizontalWrapMode // TypeDefIndex: 28403
{
	// Fields
	public int value__; // 0x0
	public const HorizontalWrapMode Wrap = 0;
	public const HorizontalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
public enum VerticalWrapMode // TypeDefIndex: 28404
{
	// Fields
	public int value__; // 0x0
	public const VerticalWrapMode Truncate = 0;
	public const VerticalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
[NativeHeader("Modules/TextRendering/Public/TextMesh.h")]
[NativeClass("TextRenderingPrivate::TextMesh")]
[RequireComponent(typeof(Transform), typeof(MeshRenderer))]
public sealed class TextMesh : Component // TypeDefIndex: 28405
{
	// Properties
	public string text { set; }

	// Methods

	// RVA: 0x881E400 Offset: 0x881A400 VA: 0x881E400
	public void set_text(string value) { }

	// RVA: 0x881E444 Offset: 0x881A444 VA: 0x881E444
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct CharacterInfo // TypeDefIndex: 28406
{
	// Fields
	public int index; // 0x0
	[Obsolete("CharacterInfo.uv is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead.")]
	public Rect uv; // 0x4
	[Obsolete("CharacterInfo.vert is deprecated. Use minX, maxX, minY, maxY instead.")]
	public Rect vert; // 0x14
	[NativeName("advance")]
	[Obsolete("CharacterInfo.width is deprecated. Use advance instead.")]
	public float width; // 0x24
	public int size; // 0x28
	public FontStyle style; // 0x2C
	[Obsolete("CharacterInfo.flipped is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead, which will be correct regardless of orientation.")]
	public bool flipped; // 0x30

	// Properties
	public int advance { get; set; }
	public int glyphWidth { get; set; }
	public int glyphHeight { get; set; }
	public int bearing { get; set; }
	public int minY { get; set; }
	public int maxY { get; set; }
	public int minX { get; set; }
	public int maxX { get; set; }
	internal Vector2 uvBottomLeftUnFlipped { get; set; }
	internal Vector2 uvBottomRightUnFlipped { get; set; }
	internal Vector2 uvTopRightUnFlipped { get; set; }
	internal Vector2 uvTopLeftUnFlipped { get; set; }
	public Vector2 uvBottomLeft { get; set; }
	public Vector2 uvBottomRight { get; set; }
	public Vector2 uvTopRight { get; set; }
	public Vector2 uvTopLeft { get; set; }

	// Methods

	// RVA: 0x881E44C Offset: 0x881A44C VA: 0x881E44C
	public int get_advance() { }

	// RVA: 0x881E504 Offset: 0x881A504 VA: 0x881E504
	public void set_advance(int value) { }

	// RVA: 0x881E510 Offset: 0x881A510 VA: 0x881E510
	public int get_glyphWidth() { }

	// RVA: 0x881E530 Offset: 0x881A530 VA: 0x881E530
	public void set_glyphWidth(int value) { }

	// RVA: 0x881E53C Offset: 0x881A53C VA: 0x881E53C
	public int get_glyphHeight() { }

	// RVA: 0x881E560 Offset: 0x881A560 VA: 0x881E560
	public void set_glyphHeight(int value) { }

	// RVA: 0x881E584 Offset: 0x881A584 VA: 0x881E584
	public int get_bearing() { }

	// RVA: 0x881E5A4 Offset: 0x881A5A4 VA: 0x881E5A4
	public void set_bearing(int value) { }

	// RVA: 0x881E5B0 Offset: 0x881A5B0 VA: 0x881E5B0
	public int get_minY() { }

	// RVA: 0x881E5D8 Offset: 0x881A5D8 VA: 0x881E5D8
	public void set_minY(int value) { }

	// RVA: 0x881E5EC Offset: 0x881A5EC VA: 0x881E5EC
	public int get_maxY() { }

	// RVA: 0x881E60C Offset: 0x881A60C VA: 0x881E60C
	public void set_maxY(int value) { }

	// RVA: 0x881E62C Offset: 0x881A62C VA: 0x881E62C
	public int get_minX() { }

	// RVA: 0x881E64C Offset: 0x881A64C VA: 0x881E64C
	public void set_minX(int value) { }

	// RVA: 0x881E66C Offset: 0x881A66C VA: 0x881E66C
	public int get_maxX() { }

	// RVA: 0x881E694 Offset: 0x881A694 VA: 0x881E694
	public void set_maxX(int value) { }

	// RVA: 0x881E6A8 Offset: 0x881A6A8 VA: 0x881E6A8
	internal Vector2 get_uvBottomLeftUnFlipped() { }

	// RVA: 0x881E6B0 Offset: 0x881A6B0 VA: 0x881E6B0
	internal void set_uvBottomLeftUnFlipped(Vector2 value) { }

	// RVA: 0x881E6E4 Offset: 0x881A6E4 VA: 0x881E6E4
	internal Vector2 get_uvBottomRightUnFlipped() { }

	// RVA: 0x881E6F4 Offset: 0x881A6F4 VA: 0x881E6F4
	internal void set_uvBottomRightUnFlipped(Vector2 value) { }

	// RVA: 0x881E6D0 Offset: 0x881A6D0 VA: 0x881E6D0
	internal Vector2 get_uvTopRightUnFlipped() { }

	// RVA: 0x881E714 Offset: 0x881A714 VA: 0x881E714
	internal void set_uvTopRightUnFlipped(Vector2 value) { }

	// RVA: 0x881E728 Offset: 0x881A728 VA: 0x881E728
	internal Vector2 get_uvTopLeftUnFlipped() { }

	// RVA: 0x881E738 Offset: 0x881A738 VA: 0x881E738
	internal void set_uvTopLeftUnFlipped(Vector2 value) { }

	// RVA: 0x881E758 Offset: 0x881A758 VA: 0x881E758
	public Vector2 get_uvBottomLeft() { }

	// RVA: 0x881E760 Offset: 0x881A760 VA: 0x881E760
	public void set_uvBottomLeft(Vector2 value) { }

	// RVA: 0x881E780 Offset: 0x881A780 VA: 0x881E780
	public Vector2 get_uvBottomRight() { }

	// RVA: 0x881E7A8 Offset: 0x881A7A8 VA: 0x881E7A8
	public void set_uvBottomRight(Vector2 value) { }

	// RVA: 0x881E7F0 Offset: 0x881A7F0 VA: 0x881E7F0
	public Vector2 get_uvTopRight() { }

	// RVA: 0x881E804 Offset: 0x881A804 VA: 0x881E804
	public void set_uvTopRight(Vector2 value) { }

	// RVA: 0x881E818 Offset: 0x881A818 VA: 0x881E818
	public Vector2 get_uvTopLeft() { }

	// RVA: 0x881E840 Offset: 0x881A840 VA: 0x881E840
	public void set_uvTopLeft(Vector2 value) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UICharInfo // TypeDefIndex: 28407
{
	// Fields
	public Vector2 cursorPos; // 0x0
	public float charWidth; // 0x8
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UILineInfo // TypeDefIndex: 28408
{
	// Fields
	public int startCharIdx; // 0x0
	public int height; // 0x4
	public float topY; // 0x8
	public float leading; // 0xC
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UIVertex // TypeDefIndex: 28409
{
	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector4 uv0; // 0x2C
	public Vector4 uv1; // 0x3C
	public Vector4 uv2; // 0x4C
	public Vector4 uv3; // 0x5C
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Methods

	// RVA: 0x881E888 Offset: 0x881A888 VA: 0x881E888
	private static void .cctor() { }
}

// Namespace: 
public sealed class Font.FontTextureRebuildCallback : MulticastDelegate // TypeDefIndex: 28410
{
	// Methods

	// RVA: 0x881F6FC Offset: 0x881B6FC VA: 0x881F6FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x881F798 Offset: 0x881B798 VA: 0x881F798 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[StaticAccessor("TextRenderingPrivate", 2)]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeClass("TextRendering::Font")]
public sealed class Font : Object // TypeDefIndex: 28411
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Font> textureRebuilt; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; set; }
	public string[] fontNames { get; set; }
	public bool dynamic { get; }
	public int ascent { get; }
	public int fontSize { get; }
	public CharacterInfo[] characterInfo { get; set; }
	[NativeProperty("LineSpacing", False, 0)]
	public int lineHeight { get; }
	[Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
	public Font.FontTextureRebuildCallback textureRebuildCallback { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x881E9F4 Offset: 0x881A9F4 VA: 0x881E9F4
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGenerated]
	// RVA: 0x881EAC0 Offset: 0x881AAC0 VA: 0x881EAC0
	public static void remove_textureRebuilt(Action<Font> value) { }

	[CompilerGenerated]
	// RVA: 0x881EB8C Offset: 0x881AB8C VA: 0x881EB8C
	private void add_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	[CompilerGenerated]
	// RVA: 0x881EC28 Offset: 0x881AC28 VA: 0x881EC28
	private void remove_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	// RVA: 0x881ECC4 Offset: 0x881ACC4 VA: 0x881ECC4
	public Material get_material() { }

	// RVA: 0x881ED00 Offset: 0x881AD00 VA: 0x881ED00
	public void set_material(Material value) { }

	// RVA: 0x881ED44 Offset: 0x881AD44 VA: 0x881ED44
	public string[] get_fontNames() { }

	// RVA: 0x881ED80 Offset: 0x881AD80 VA: 0x881ED80
	public void set_fontNames(string[] value) { }

	// RVA: 0x881D654 Offset: 0x8819654 VA: 0x881D654
	public bool get_dynamic() { }

	// RVA: 0x881EDC4 Offset: 0x881ADC4 VA: 0x881EDC4
	public int get_ascent() { }

	// RVA: 0x881EE00 Offset: 0x881AE00 VA: 0x881EE00
	public int get_fontSize() { }

	[FreeFunction("TextRenderingPrivate::GetFontCharacterInfo", HasExplicitThis = True)]
	// RVA: 0x881EE3C Offset: 0x881AE3C VA: 0x881EE3C
	public CharacterInfo[] get_characterInfo() { }

	[FreeFunction("TextRenderingPrivate::SetFontCharacterInfo", HasExplicitThis = True)]
	// RVA: 0x881EE78 Offset: 0x881AE78 VA: 0x881EE78
	public void set_characterInfo(CharacterInfo[] value) { }

	// RVA: 0x881EEBC Offset: 0x881AEBC VA: 0x881EEBC
	public int get_lineHeight() { }

	// RVA: 0x881EEF8 Offset: 0x881AEF8 VA: 0x881EEF8
	public Font.FontTextureRebuildCallback get_textureRebuildCallback() { }

	// RVA: 0x881EF00 Offset: 0x881AF00 VA: 0x881EF00
	public void set_textureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	// RVA: 0x881EF08 Offset: 0x881AF08 VA: 0x881EF08
	public void .ctor() { }

	// RVA: 0x881EFD0 Offset: 0x881AFD0 VA: 0x881EFD0
	public void .ctor(string name) { }

	// RVA: 0x881F124 Offset: 0x881B124 VA: 0x881F124
	private void .ctor(string[] names, int size) { }

	// RVA: 0x881F210 Offset: 0x881B210 VA: 0x881F210
	public static Font CreateDynamicFontFromOSFont(string fontname, int size) { }

	// RVA: 0x881F2C0 Offset: 0x881B2C0 VA: 0x881F2C0
	public static Font CreateDynamicFontFromOSFont(string[] fontnames, int size) { }

	[RequiredByNativeCode]
	// RVA: 0x881F328 Offset: 0x881B328 VA: 0x881F328
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x881F3B4 Offset: 0x881B3B4 VA: 0x881F3B4
	public static int GetMaxVertsForString(string str) { }

	// RVA: 0x881F3D4 Offset: 0x881B3D4 VA: 0x881F3D4
	internal static Font GetDefault() { }

	// RVA: 0x881F3FC Offset: 0x881B3FC VA: 0x881F3FC
	public bool HasCharacter(char c) { }

	// RVA: 0x881F440 Offset: 0x881B440 VA: 0x881F440
	private bool HasCharacter(int c) { }

	// RVA: 0x881F484 Offset: 0x881B484 VA: 0x881F484
	public static string[] GetOSInstalledFontNames() { }

	// RVA: 0x881F4AC Offset: 0x881B4AC VA: 0x881F4AC
	public static string[] GetPathsToOSFonts() { }

	// RVA: 0x881EF8C Offset: 0x881AF8C VA: 0x881EF8C
	private static void Internal_CreateFont(Font self, string name) { }

	// RVA: 0x881F0E0 Offset: 0x881B0E0 VA: 0x881F0E0
	private static void Internal_CreateFontFromPath(Font self, string fontPath) { }

	// RVA: 0x881F1BC Offset: 0x881B1BC VA: 0x881F1BC
	private static void Internal_CreateDynamicFont(Font self, string[] _names, int size) { }

	[FreeFunction("TextRenderingPrivate::GetCharacterInfo", HasExplicitThis = True)]
	// RVA: 0x881F4D4 Offset: 0x881B4D4 VA: 0x881F4D4
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	[ExcludeFromDocs]
	// RVA: 0x881F540 Offset: 0x881B540 VA: 0x881F540
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { }

	[ExcludeFromDocs]
	// RVA: 0x881F5A0 Offset: 0x881B5A0 VA: 0x881F5A0
	public bool GetCharacterInfo(char ch, out CharacterInfo info) { }

	// RVA: 0x881F5FC Offset: 0x881B5FC VA: 0x881F5FC
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	[ExcludeFromDocs]
	// RVA: 0x881F658 Offset: 0x881B658 VA: 0x881F658
	public void RequestCharactersInTexture(string characters, int size) { }

	[ExcludeFromDocs]
	// RVA: 0x881F6B0 Offset: 0x881B6B0 VA: 0x881F6B0
	public void RequestCharactersInTexture(string characters) { }
}

