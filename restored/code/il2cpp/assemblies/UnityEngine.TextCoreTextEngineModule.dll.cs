// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 23394
{}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class Character : TextElement // TypeDefIndex: 23395
{
	// Methods

	// RVA: 0x87EAD70 Offset: 0x87E6D70 VA: 0x87EAD70
	public void .ctor() { }

	// RVA: 0x87EADA8 Offset: 0x87E6DA8 VA: 0x87EADA8
	public void .ctor(uint unicode, FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x87EAE44 Offset: 0x87E6E44 VA: 0x87EAE44
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class ColorUtilities // TypeDefIndex: 23396
{
	// Methods

	// RVA: 0x87EAEA0 Offset: 0x87E6EA0 VA: 0x87EAEA0
	internal static bool CompareColors(Color32 a, Color32 b) { }

	// RVA: 0x87EAEB0 Offset: 0x87E6EB0 VA: 0x87EAEB0
	internal static Color32 MultiplyColors(Color32 c1, Color32 c2) { }
}

// Namespace: UnityEngine.TextCore.Text
public enum TextFontWeight // TypeDefIndex: 23397
{
	// Fields
	public int value__; // 0x0
	public const TextFontWeight Thin = 100;
	public const TextFontWeight ExtraLight = 200;
	public const TextFontWeight Light = 300;
	public const TextFontWeight Regular = 400;
	public const TextFontWeight Medium = 500;
	public const TextFontWeight SemiBold = 600;
	public const TextFontWeight Bold = 700;
	public const TextFontWeight Heavy = 800;
	public const TextFontWeight Black = 900;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public struct FontWeightPair // TypeDefIndex: 23398
{
	// Fields
	public FontAsset regularTypeface; // 0x0
	public FontAsset italicTypeface; // 0x8
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromDocs]
[Serializable]
public struct FontAssetCreationEditorSettings // TypeDefIndex: 23399
{
	// Fields
	public string sourceFontFileGUID; // 0x0
	public int faceIndex; // 0x8
	public int pointSizeSamplingMode; // 0xC
	public int pointSize; // 0x10
	public int padding; // 0x14
	public int paddingMode; // 0x18
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
}

// Namespace: UnityEngine.TextCore.Text
public enum AtlasPopulationMode // TypeDefIndex: 23400
{
	// Fields
	public int value__; // 0x0
	public const AtlasPopulationMode Static = 0;
	public const AtlasPopulationMode Dynamic = 1;
	public const AtlasPopulationMode DynamicOS = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FontAsset.<>c // TypeDefIndex: 23401
{
	// Fields
	public static readonly FontAsset.<>c <>9; // 0x0
	public static Func<Character, uint> <>9__151_0; // 0x8
	public static Func<Glyph, uint> <>9__152_0; // 0x10

	// Methods

	// RVA: 0x87F4A24 Offset: 0x87F0A24 VA: 0x87F4A24
	private static void .cctor() { }

	// RVA: 0x87F4A8C Offset: 0x87F0A8C VA: 0x87F4A8C
	public void .ctor() { }

	// RVA: 0x87F4A94 Offset: 0x87F0A94 VA: 0x87F4A94
	internal uint <SortCharacterTable>b__151_0(Character c) { }

	// RVA: 0x87F4AAC Offset: 0x87F0AAC VA: 0x87F4AAC
	internal uint <SortGlyphTable>b__152_0(Glyph c) { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[Serializable]
public class FontAsset : TextAsset // TypeDefIndex: 23402
{
	// Fields
	[SerializeField]
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x40
	[SerializeField]
	private Font m_SourceFontFile; // 0x98
	[SerializeField]
	private string m_SourceFontFilePath; // 0xA0
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; // 0xA8
	[SerializeField]
	internal bool InternalDynamicOS; // 0xAC
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0xB0
	private int m_FamilyNameHashCode; // 0x110
	private int m_StyleNameHashCode; // 0x114
	[SerializeField]
	internal List<Glyph> m_GlyphTable; // 0x118
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0x120
	[SerializeField]
	internal List<Character> m_CharacterTable; // 0x128
	internal Dictionary<uint, Character> m_CharacterLookupDictionary; // 0x130
	internal Texture2D m_AtlasTexture; // 0x138
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; // 0x140
	[SerializeField]
	internal int m_AtlasTextureIndex; // 0x148
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; // 0x14C
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x14D
	[SerializeField]
	internal int m_AtlasWidth; // 0x150
	[SerializeField]
	internal int m_AtlasHeight; // 0x154
	[SerializeField]
	internal int m_AtlasPadding; // 0x158
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; // 0x15C
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; // 0x160
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; // 0x168
	[SerializeField]
	internal FontFeatureTable m_FontFeatureTable; // 0x170
	[SerializeField]
	internal List<FontAsset> m_FallbackFontAssetTable; // 0x178
	[SerializeField]
	private FontWeightPair[] m_FontWeightTable; // 0x180
	[SerializeField]
	[FormerlySerializedAs("normalStyle")]
	internal float m_RegularStyleWeight; // 0x188
	[FormerlySerializedAs("normalSpacingOffset")]
	[SerializeField]
	internal float m_RegularStyleSpacing; // 0x18C
	[FormerlySerializedAs("boldStyle")]
	[SerializeField]
	internal float m_BoldStyleWeight; // 0x190
	[SerializeField]
	[FormerlySerializedAs("boldSpacing")]
	internal float m_BoldStyleSpacing; // 0x194
	[SerializeField]
	[FormerlySerializedAs("italicStyle")]
	internal byte m_ItalicStyleSlant; // 0x198
	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	internal byte m_TabMultiple; // 0x199
	internal bool IsFontAssetLookupTablesDirty; // 0x19A
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x10
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x28
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x30
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x38
	private static ProfilerMarker k_TryAddGlyphMarker; // 0x40
	private static string s_DefaultMaterialSuffix; // 0x48
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x50
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x58
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x60
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x68
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x70
	private List<Glyph> m_GlyphsToRender; // 0x1A0
	private List<Glyph> m_GlyphsRendered; // 0x1A8
	private List<uint> m_GlyphIndexList; // 0x1B0
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1B8
	internal List<uint> m_GlyphsToAdd; // 0x1C0
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x1C8
	internal List<Character> m_CharactersToAdd; // 0x1D0
	internal HashSet<uint> m_CharactersToAddLookup; // 0x1D8
	internal List<uint> s_MissingCharacterList; // 0x1E0
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x1E8
	internal static uint[] k_GlyphIndexArray; // 0x78

	// Properties
	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	internal int familyNameHashCode { get; set; }
	internal int styleNameHashCode { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<Character> characterTable { get; set; }
	public Dictionary<uint, Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	internal bool clearDynamicDataOnBuild { get; set; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	public FontFeatureTable fontFeatureTable { get; set; }
	public List<FontAsset> fallbackFontAssetTable { get; set; }
	public FontWeightPair[] fontWeightTable { get; set; }
	public float regularStyleWeight { get; set; }
	public float regularStyleSpacing { get; set; }
	public float boldStyleWeight { get; set; }
	public float boldStyleSpacing { get; set; }
	public byte italicStyleSlant { get; set; }
	public byte tabMultiple { get; set; }

	// Methods

	// RVA: 0x87EAF68 Offset: 0x87E6F68 VA: 0x87EAF68
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	// RVA: 0x87EAF84 Offset: 0x87E6F84 VA: 0x87EAF84
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	// RVA: 0x87EAFA8 Offset: 0x87E6FA8 VA: 0x87EAFA8
	public Font get_sourceFontFile() { }

	// RVA: 0x87EAFB0 Offset: 0x87E6FB0 VA: 0x87EAFB0
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x87EAFB8 Offset: 0x87E6FB8 VA: 0x87EAFB8
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x87EAFC0 Offset: 0x87E6FC0 VA: 0x87EAFC0
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x87EAFC8 Offset: 0x87E6FC8 VA: 0x87EAFC8
	public FaceInfo get_faceInfo() { }

	// RVA: 0x87EAFE4 Offset: 0x87E6FE4 VA: 0x87EAFE4
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x87EB008 Offset: 0x87E7008 VA: 0x87EB008
	internal int get_familyNameHashCode() { }

	// RVA: 0x87EB038 Offset: 0x87E7038 VA: 0x87EB038
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x87EB040 Offset: 0x87E7040 VA: 0x87EB040
	internal int get_styleNameHashCode() { }

	// RVA: 0x87EB070 Offset: 0x87E7070 VA: 0x87EB070
	internal void set_styleNameHashCode(int value) { }

	// RVA: 0x87EB078 Offset: 0x87E7078 VA: 0x87EB078
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x87EB080 Offset: 0x87E7080 VA: 0x87EB080
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x87EB090 Offset: 0x87E7090 VA: 0x87EB090
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x87EB454 Offset: 0x87E7454 VA: 0x87EB454
	public List<Character> get_characterTable() { }

	// RVA: 0x87EB45C Offset: 0x87E745C VA: 0x87EB45C
	internal void set_characterTable(List<Character> value) { }

	// RVA: 0x87EB46C Offset: 0x87E746C VA: 0x87EB46C
	public Dictionary<uint, Character> get_characterLookupTable() { }

	// RVA: 0x87EB490 Offset: 0x87E7490 VA: 0x87EB490
	public Texture2D get_atlasTexture() { }

	// RVA: 0x87EB528 Offset: 0x87E7528 VA: 0x87EB528
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x87EB530 Offset: 0x87E7530 VA: 0x87EB530
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x87EB540 Offset: 0x87E7540 VA: 0x87EB540
	public int get_atlasTextureCount() { }

	// RVA: 0x87EB54C Offset: 0x87E754C VA: 0x87EB54C
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x87EB554 Offset: 0x87E7554 VA: 0x87EB554
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x87EB560 Offset: 0x87E7560 VA: 0x87EB560
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x87EB568 Offset: 0x87E7568 VA: 0x87EB568
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x87EB574 Offset: 0x87E7574 VA: 0x87EB574
	public int get_atlasWidth() { }

	// RVA: 0x87EB57C Offset: 0x87E757C VA: 0x87EB57C
	internal void set_atlasWidth(int value) { }

	// RVA: 0x87EB584 Offset: 0x87E7584 VA: 0x87EB584
	public int get_atlasHeight() { }

	// RVA: 0x87EB58C Offset: 0x87E758C VA: 0x87EB58C
	internal void set_atlasHeight(int value) { }

	// RVA: 0x87EB594 Offset: 0x87E7594 VA: 0x87EB594
	public int get_atlasPadding() { }

	// RVA: 0x87EB59C Offset: 0x87E759C VA: 0x87EB59C
	internal void set_atlasPadding(int value) { }

	// RVA: 0x87EB5A4 Offset: 0x87E75A4 VA: 0x87EB5A4
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x87EB5AC Offset: 0x87E75AC VA: 0x87EB5AC
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x87EB5B4 Offset: 0x87E75B4 VA: 0x87EB5B4
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x87EB5BC Offset: 0x87E75BC VA: 0x87EB5BC
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x87EB5CC Offset: 0x87E75CC VA: 0x87EB5CC
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x87EB5D4 Offset: 0x87E75D4 VA: 0x87EB5D4
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x87EB5E4 Offset: 0x87E75E4 VA: 0x87EB5E4
	public FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x87EB5EC Offset: 0x87E75EC VA: 0x87EB5EC
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	// RVA: 0x87EB5FC Offset: 0x87E75FC VA: 0x87EB5FC
	public List<FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x87EB604 Offset: 0x87E7604 VA: 0x87EB604
	public void set_fallbackFontAssetTable(List<FontAsset> value) { }

	// RVA: 0x87EB614 Offset: 0x87E7614 VA: 0x87EB614
	public FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x87EB61C Offset: 0x87E761C VA: 0x87EB61C
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	// RVA: 0x87EB62C Offset: 0x87E762C VA: 0x87EB62C
	public float get_regularStyleWeight() { }

	// RVA: 0x87EB634 Offset: 0x87E7634 VA: 0x87EB634
	public void set_regularStyleWeight(float value) { }

	// RVA: 0x87EB63C Offset: 0x87E763C VA: 0x87EB63C
	public float get_regularStyleSpacing() { }

	// RVA: 0x87EB644 Offset: 0x87E7644 VA: 0x87EB644
	public void set_regularStyleSpacing(float value) { }

	// RVA: 0x87EB64C Offset: 0x87E764C VA: 0x87EB64C
	public float get_boldStyleWeight() { }

	// RVA: 0x87EB654 Offset: 0x87E7654 VA: 0x87EB654
	public void set_boldStyleWeight(float value) { }

	// RVA: 0x87EB65C Offset: 0x87E765C VA: 0x87EB65C
	public float get_boldStyleSpacing() { }

	// RVA: 0x87EB664 Offset: 0x87E7664 VA: 0x87EB664
	public void set_boldStyleSpacing(float value) { }

	// RVA: 0x87EB66C Offset: 0x87E766C VA: 0x87EB66C
	public byte get_italicStyleSlant() { }

	// RVA: 0x87EB674 Offset: 0x87E7674 VA: 0x87EB674
	public void set_italicStyleSlant(byte value) { }

	// RVA: 0x87EB67C Offset: 0x87E767C VA: 0x87EB67C
	public byte get_tabMultiple() { }

	// RVA: 0x87EB684 Offset: 0x87E7684 VA: 0x87EB684
	public void set_tabMultiple(byte value) { }

	// RVA: 0x87EB68C Offset: 0x87E768C VA: 0x87EB68C
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	// RVA: 0x87EBA40 Offset: 0x87E7A40 VA: 0x87EBA40
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x87EB8BC Offset: 0x87E78BC VA: 0x87EB8BC
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 2, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x87EBFC0 Offset: 0x87E7FC0 VA: 0x87EBFC0
	public static FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x87EC03C Offset: 0x87E803C VA: 0x87EC03C
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x87EC0FC Offset: 0x87E80FC VA: 0x87EC0FC
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x87EBAF4 Offset: 0x87E7AF4 VA: 0x87EBAF4
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x87EC32C Offset: 0x87E832C VA: 0x87EC32C
	private void Awake() { }

	// RVA: 0x87EC330 Offset: 0x87E8330 VA: 0x87EC330
	private void OnDestroy() { }

	// RVA: 0x87EB0B4 Offset: 0x87E70B4 VA: 0x87EB0B4
	public void ReadFontAssetDefinition() { }

	// RVA: 0x87EC458 Offset: 0x87E8458 VA: 0x87EC458
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x87EC668 Offset: 0x87E8668 VA: 0x87EC668
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x87EC928 Offset: 0x87E8928 VA: 0x87EC928
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x87ECAF0 Offset: 0x87E8AF0 VA: 0x87ECAF0
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x87ECE28 Offset: 0x87E8E28 VA: 0x87ECE28
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x87ED06C Offset: 0x87E906C VA: 0x87ED06C
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x87ED258 Offset: 0x87E9258 VA: 0x87ED258
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x87EC490 Offset: 0x87E8490 VA: 0x87EC490
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x87ED5D8 Offset: 0x87E95D8 VA: 0x87ED5D8
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x87ED7F0 Offset: 0x87E97F0 VA: 0x87ED7F0
	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	// RVA: 0x87ED44C Offset: 0x87E944C VA: 0x87ED44C
	private FontEngineError LoadFontFace() { }

	// RVA: 0x87ED858 Offset: 0x87E9858 VA: 0x87ED858
	internal void SortCharacterTable() { }

	// RVA: 0x87ED9B0 Offset: 0x87E99B0 VA: 0x87ED9B0
	internal void SortGlyphTable() { }

	// RVA: 0x87EDB08 Offset: 0x87E9B08 VA: 0x87EDB08
	internal void SortFontFeatureTable() { }

	// RVA: 0x87EE184 Offset: 0x87EA184 VA: 0x87EE184
	internal void SortAllTables() { }

	// RVA: 0x87EE1A4 Offset: 0x87EA1A4 VA: 0x87EE1A4
	public bool HasCharacter(int character) { }

	// RVA: 0x87EE204 Offset: 0x87EA204 VA: 0x87EE204
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x87EE214 Offset: 0x87EA214 VA: 0x87EE214
	public bool HasCharacter(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x87EEE4C Offset: 0x87EAE4C VA: 0x87EEE4C
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x87EF070 Offset: 0x87EB070 VA: 0x87EF070
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x87EF228 Offset: 0x87EB228 VA: 0x87EF228
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x87EF674 Offset: 0x87EB674 VA: 0x87EF674
	public bool HasCharacters(string text) { }

	// RVA: 0x87EF738 Offset: 0x87EB738 VA: 0x87EF738
	public static string GetCharacters(FontAsset fontAsset) { }

	// RVA: 0x87EF844 Offset: 0x87EB844 VA: 0x87EF844
	public static int[] GetCharactersArray(FontAsset fontAsset) { }

	// RVA: 0x87EF928 Offset: 0x87EB928 VA: 0x87EF928
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x87EFA04 Offset: 0x87EBA04 VA: 0x87EFA04
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	// RVA: 0x87EFB70 Offset: 0x87EBB70 VA: 0x87EFB70
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x87EFD34 Offset: 0x87EBD34 VA: 0x87EFD34
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x87EFE70 Offset: 0x87EBE70 VA: 0x87EFE70
	internal static void UpdateAtlasTexturesInQueue() { }

	// RVA: 0x87EFFE8 Offset: 0x87EBFE8 VA: 0x87EFFE8
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x87F0038 Offset: 0x87EC038 VA: 0x87F0038
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x87F0058 Offset: 0x87EC058 VA: 0x87F0058
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x87F116C Offset: 0x87ED16C VA: 0x87F116C
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x87F118C Offset: 0x87ED18C VA: 0x87F118C
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x87F1DC0 Offset: 0x87EDDC0 VA: 0x87F1DC0
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	// RVA: 0x87EE530 Offset: 0x87EA530 VA: 0x87EE530
	internal bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = False) { }

	// RVA: 0x87F29B0 Offset: 0x87EE9B0 VA: 0x87F29B0
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = False) { }

	// RVA: 0x87F2F4C Offset: 0x87EEF4C VA: 0x87F2F4C
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x87F0CC4 Offset: 0x87ECCC4 VA: 0x87F0CC4
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x87F2798 Offset: 0x87EE798 VA: 0x87F2798
	private void SetupNewAtlasTexture() { }

	// RVA: 0x87EFCDC Offset: 0x87EBCDC VA: 0x87EFCDC
	private void UpdateAllFontFeatures() { }

	// RVA: 0x87F2F50 Offset: 0x87EEF50 VA: 0x87F2F50
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x87F36C0 Offset: 0x87EF6C0 VA: 0x87F36C0
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x87F3B4C Offset: 0x87EFB4C VA: 0x87F3B4C
	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x87F3B50 Offset: 0x87EFB50 VA: 0x87F3B50
	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4600B1C Offset: 0x45FCB1C VA: 0x4600B1C
	|-FontAsset.CopyListDataToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87F3B54 Offset: 0x87EFB54 VA: 0x87F3B54
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x87F4114 Offset: 0x87F0114 VA: 0x87F4114
	internal void ClearFontAssetDataInternal(bool clearFontFeatures = False) { }

	// RVA: 0x87F4134 Offset: 0x87F0134 VA: 0x87F4134
	internal void UpdateFontAssetData() { }

	// RVA: 0x87F3C94 Offset: 0x87EFC94 VA: 0x87F3C94
	internal void ClearFontAssetTables(bool clearFontFeatures) { }

	// RVA: 0x87F3F1C Offset: 0x87EFF1C VA: 0x87F3F1C
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x87EC394 Offset: 0x87E8394 VA: 0x87EC394
	private void DestroyAtlasTextures() { }

	// RVA: 0x87F4370 Offset: 0x87F0370 VA: 0x87F4370
	public void .ctor() { }

	// RVA: 0x87F4698 Offset: 0x87F0698 VA: 0x87F4698
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class FontAssetUtilities // TypeDefIndex: 23403
{
	// Fields
	private static HashSet<int> k_SearchedAssets; // 0x0

	// Methods

	// RVA: 0x87F4AC4 Offset: 0x87F0AC4 VA: 0x87F4AC4
	internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x87F4BD4 Offset: 0x87F0BD4 VA: 0x87F4BD4
	private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x87F5024 Offset: 0x87F1024 VA: 0x87F5024
	public static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x87F51E4 Offset: 0x87F11E4 VA: 0x87F51E4
	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x87F54B4 Offset: 0x87F14B4 VA: 0x87F54B4
	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FontFeatureTable.<>c // TypeDefIndex: 23404
{
	// Fields
	public static readonly FontFeatureTable.<>c <>9; // 0x0
	public static Func<GlyphPairAdjustmentRecord, uint> <>9__25_0; // 0x8
	public static Func<GlyphPairAdjustmentRecord, uint> <>9__25_1; // 0x10
	public static Func<MarkToBaseAdjustmentRecord, uint> <>9__26_0; // 0x18
	public static Func<MarkToBaseAdjustmentRecord, uint> <>9__26_1; // 0x20
	public static Func<MarkToMarkAdjustmentRecord, uint> <>9__27_0; // 0x28
	public static Func<MarkToMarkAdjustmentRecord, uint> <>9__27_1; // 0x30

	// Methods

	// RVA: 0x87F5674 Offset: 0x87F1674 VA: 0x87F5674
	private static void .cctor() { }

	// RVA: 0x87F56DC Offset: 0x87F16DC VA: 0x87F56DC
	public void .ctor() { }

	// RVA: 0x87F56E4 Offset: 0x87F16E4 VA: 0x87F56E4
	internal uint <SortGlyphPairAdjustmentRecords>b__25_0(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x87F572C Offset: 0x87F172C VA: 0x87F572C
	internal uint <SortGlyphPairAdjustmentRecords>b__25_1(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x87F5774 Offset: 0x87F1774 VA: 0x87F5774
	internal uint <SortMarkToBaseAdjustmentRecords>b__26_0(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x87F5780 Offset: 0x87F1780 VA: 0x87F5780
	internal uint <SortMarkToBaseAdjustmentRecords>b__26_1(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x87F578C Offset: 0x87F178C VA: 0x87F578C
	internal uint <SortMarkToMarkAdjustmentRecords>b__27_0(MarkToMarkAdjustmentRecord s) { }

	// RVA: 0x87F5798 Offset: 0x87F1798 VA: 0x87F5798
	internal uint <SortMarkToMarkAdjustmentRecords>b__27_1(MarkToMarkAdjustmentRecord s) { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class FontFeatureTable // TypeDefIndex: 23405
{
	// Fields
	[SerializeField]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; // 0x10
	[SerializeField]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; // 0x18
	[SerializeField]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x20
	[SerializeField]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; // 0x28
	[SerializeField]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; // 0x30
	internal Dictionary<uint, List<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; // 0x38
	internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x40
	internal Dictionary<uint, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; // 0x48
	internal Dictionary<uint, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; // 0x50

	// Methods

	// RVA: 0x87F340C Offset: 0x87EF40C VA: 0x87F340C
	internal void .ctor() { }

	// RVA: 0x87EDB3C Offset: 0x87E9B3C VA: 0x87EDB3C
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x87EDD54 Offset: 0x87E9D54 VA: 0x87EDD54
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x87EDF6C Offset: 0x87E9F6C VA: 0x87EDF6C
	public void SortMarkToMarkAdjustmentRecords() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct Extents // TypeDefIndex: 23406
{
	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x87F57A4 Offset: 0x87F17A4 VA: 0x87F57A4 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct LineInfo // TypeDefIndex: 23407
{
	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int visibleSpaceCount; // 0x10
	public int wordCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharacterIndex; // 0x24
	public float length; // 0x28
	public float lineHeight; // 0x2C
	public float ascender; // 0x30
	public float baseline; // 0x34
	public float descender; // 0x38
	public float maxAdvance; // 0x3C
	public float width; // 0x40
	public float marginLeft; // 0x44
	public float marginRight; // 0x48
	public TextAlignment alignment; // 0x4C
	public Extents lineExtents; // 0x50
}

// Namespace: UnityEngine.TextCore.Text
internal struct LinkInfo // TypeDefIndex: 23408
{
	// Fields
	public int hashCode; // 0x0
	public int linkIdFirstCharacterIndex; // 0x4
	public int linkIdLength; // 0x8
	public int linkTextfirstCharacterIndex; // 0xC
	public int linkTextLength; // 0x10
	internal char[] linkId; // 0x18
	private string m_LinkIdString; // 0x20
	private string m_LinkTextString; // 0x28

	// Methods

	// RVA: 0x87F59CC Offset: 0x87F19CC VA: 0x87F59CC
	internal void SetLinkId(char[] text, int startIndex, int length) { }

	// RVA: 0x87F5AD4 Offset: 0x87F1AD4 VA: 0x87F5AD4
	public string GetLinkText(TextInfo textInfo) { }

	// RVA: 0x87F5BE0 Offset: 0x87F1BE0 VA: 0x87F5BE0
	public string GetLinkId() { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class MaterialManager // TypeDefIndex: 23409
{
	// Fields
	private static Dictionary<long, Material> s_FallbackMaterials; // 0x0

	// Methods

	// RVA: 0x87F5C38 Offset: 0x87F1C38 VA: 0x87F5C38
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x87F6288 Offset: 0x87F2288 VA: 0x87F6288
	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x87F6000 Offset: 0x87F2000 VA: 0x87F6000
	private static void CopyMaterialPresetProperties(Material source, Material destination) { }

	// RVA: 0x87F64A8 Offset: 0x87F24A8 VA: 0x87F64A8
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct MaterialReference // TypeDefIndex: 23410
{
	// Fields
	public int index; // 0x0
	public FontAsset fontAsset; // 0x8
	public SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isDefaultMaterial; // 0x20
	public bool isFallbackMaterial; // 0x21
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x87F6540 Offset: 0x87F2540 VA: 0x87F6540
	public void .ctor(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x87F65FC Offset: 0x87F25FC VA: 0x87F65FC
	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x87F682C Offset: 0x87F282C VA: 0x87F682C
	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}

// Namespace: UnityEngine.TextCore.Text
internal class MaterialReferenceManager // TypeDefIndex: 23411
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x87F6A24 Offset: 0x87F2A24 VA: 0x87F6A24
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x87F6C28 Offset: 0x87F2C28 VA: 0x87F6C28
	public static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x87F6C48 Offset: 0x87F2C48 VA: 0x87F6C48
	private void AddFontAssetInternal(FontAsset fontAsset) { }

	// RVA: 0x87F6DF8 Offset: 0x87F2DF8 VA: 0x87F6DF8
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x87F6E28 Offset: 0x87F2E28 VA: 0x87F6E28
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x87F6EFC Offset: 0x87F2EFC VA: 0x87F6EFC
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x87F6F2C Offset: 0x87F2F2C VA: 0x87F6F2C
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x87F6F94 Offset: 0x87F2F94 VA: 0x87F6F94
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x87F6FC4 Offset: 0x87F2FC4 VA: 0x87F6FC4
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x87F7068 Offset: 0x87F3068 VA: 0x87F7068
	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x87F7098 Offset: 0x87F3098 VA: 0x87F7098
	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x87F7110 Offset: 0x87F3110 VA: 0x87F7110
	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x87F7140 Offset: 0x87F3140 VA: 0x87F7140
	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x87F71B8 Offset: 0x87F31B8 VA: 0x87F71B8
	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x87F71E8 Offset: 0x87F31E8 VA: 0x87F71E8
	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x87F7260 Offset: 0x87F3260 VA: 0x87F7260
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x87F7290 Offset: 0x87F3290 VA: 0x87F7290
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x87F6AA4 Offset: 0x87F2AA4 VA: 0x87F6AA4
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal enum VertexSortingOrder // TypeDefIndex: 23412
{
	// Fields
	public int value__; // 0x0
	public const VertexSortingOrder Normal = 0;
	public const VertexSortingOrder Reverse = 1;
}

// Namespace: UnityEngine.TextCore.Text
internal struct MeshInfo // TypeDefIndex: 23413
{
	// Fields
	private static readonly Color32 k_DefaultColor; // 0x0
	private static readonly Vector3 k_DefaultNormal; // 0x4
	private static readonly Vector4 k_DefaultTangent; // 0x10
	public int vertexCount; // 0x0
	public Vector3[] vertices; // 0x8
	public Vector3[] normals; // 0x10
	public Vector4[] tangents; // 0x18
	public Vector4[] uvs0; // 0x20
	public Vector2[] uvs2; // 0x28
	public Color32[] colors32; // 0x30
	public int[] triangles; // 0x38
	public Material material; // 0x40
	internal GlyphRenderMode glyphRenderMode; // 0x48

	// Methods

	// RVA: 0x87F7308 Offset: 0x87F3308 VA: 0x87F7308
	public void .ctor(int size) { }

	// RVA: 0x87F77C4 Offset: 0x87F37C4 VA: 0x87F77C4
	internal void ResizeMeshInfo(int size) { }

	// RVA: 0x87F79BC Offset: 0x87F39BC VA: 0x87F79BC
	internal void Clear(bool uploadChanges) { }

	// RVA: 0x87F79E8 Offset: 0x87F39E8 VA: 0x87F79E8
	internal void ClearUnusedVertices() { }

	// RVA: 0x87F7A24 Offset: 0x87F3A24 VA: 0x87F7A24
	internal void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x87F7AD8 Offset: 0x87F3AD8 VA: 0x87F7AD8
	internal void SwapVertexData(int src, int dst) { }

	// RVA: 0x87F8064 Offset: 0x87F4064 VA: 0x87F8064
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SpriteAsset.<>c // TypeDefIndex: 23414
{
	// Fields
	public static readonly SpriteAsset.<>c <>9; // 0x0
	public static Func<SpriteGlyph, uint> <>9__37_0; // 0x8
	public static Func<SpriteCharacter, uint> <>9__38_0; // 0x10

	// Methods

	// RVA: 0x87F9544 Offset: 0x87F5544 VA: 0x87F9544
	private static void .cctor() { }

	// RVA: 0x87F95AC Offset: 0x87F55AC VA: 0x87F95AC
	public void .ctor() { }

	// RVA: 0x87F95B4 Offset: 0x87F55B4 VA: 0x87F95B4
	internal uint <SortGlyphTable>b__37_0(SpriteGlyph item) { }

	// RVA: 0x87F95CC Offset: 0x87F55CC VA: 0x87F95CC
	internal uint <SortCharacterTable>b__38_0(SpriteCharacter c) { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/2022.3/Documentation/Manual/UIE-sprite.html")]
public class SpriteAsset : TextAsset // TypeDefIndex: 23415
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x38
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x48
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	internal Texture m_SpriteAtlasTexture; // 0xA8
	[SerializeField]
	private List<SpriteCharacter> m_SpriteCharacterTable; // 0xB0
	internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
	[SerializeField]
	private List<SpriteGlyph> m_SpriteGlyphTable; // 0xC0
	internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
	[SerializeField]
	public List<SpriteAsset> fallbackSpriteAssets; // 0xD0
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xD8
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public FaceInfo faceInfo { get; set; }
	public Texture spriteSheet { get; set; }
	public List<SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x87F80D8 Offset: 0x87F40D8 VA: 0x87F80D8
	public FaceInfo get_faceInfo() { }

	// RVA: 0x87F80F4 Offset: 0x87F40F4 VA: 0x87F80F4
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x87F8118 Offset: 0x87F4118 VA: 0x87F8118
	public Texture get_spriteSheet() { }

	// RVA: 0x87F8120 Offset: 0x87F4120 VA: 0x87F8120
	internal void set_spriteSheet(Texture value) { }

	// RVA: 0x87F8128 Offset: 0x87F4128 VA: 0x87F8128
	public List<SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x87F865C Offset: 0x87F465C VA: 0x87F865C
	internal void set_spriteCharacterTable(List<SpriteCharacter> value) { }

	// RVA: 0x87F5490 Offset: 0x87F1490 VA: 0x87F5490
	public Dictionary<uint, SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x87F8664 Offset: 0x87F4664 VA: 0x87F8664
	internal void set_spriteCharacterLookupTable(Dictionary<uint, SpriteCharacter> value) { }

	// RVA: 0x87F866C Offset: 0x87F466C VA: 0x87F866C
	public List<SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x87F8674 Offset: 0x87F4674 VA: 0x87F8674
	internal void set_spriteGlyphTable(List<SpriteGlyph> value) { }

	// RVA: 0x87F867C Offset: 0x87F467C VA: 0x87F867C
	private void Awake() { }

	// RVA: 0x87F814C Offset: 0x87F414C VA: 0x87F814C
	public void UpdateLookupTables() { }

	// RVA: 0x87F8688 Offset: 0x87F4688 VA: 0x87F8688
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x87F8710 Offset: 0x87F4710 VA: 0x87F8710
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x87F87A4 Offset: 0x87F47A4 VA: 0x87F87A4
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x87F87E4 Offset: 0x87F47E4 VA: 0x87F87E4
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x87F89B8 Offset: 0x87F49B8 VA: 0x87F89B8
	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x87F8B58 Offset: 0x87F4B58 VA: 0x87F8B58
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x87F8C08 Offset: 0x87F4C08 VA: 0x87F8C08
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings) { }

	// RVA: 0x87F8F50 Offset: 0x87F4F50 VA: 0x87F8F50
	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x87F90F8 Offset: 0x87F50F8 VA: 0x87F90F8
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x87F91A8 Offset: 0x87F51A8 VA: 0x87F91A8
	public void SortGlyphTable() { }

	// RVA: 0x87F92F8 Offset: 0x87F52F8 VA: 0x87F92F8
	internal void SortCharacterTable() { }

	// RVA: 0x87F944C Offset: 0x87F544C VA: 0x87F944C
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x87F9464 Offset: 0x87F5464 VA: 0x87F9464
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteCharacter : TextElement // TypeDefIndex: 23416
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x30

	// Properties
	public string name { get; }

	// Methods

	// RVA: 0x87F8680 Offset: 0x87F4680 VA: 0x87F8680
	public string get_name() { }

	// RVA: 0x87F95E4 Offset: 0x87F55E4 VA: 0x87F95E4
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteGlyph : Glyph // TypeDefIndex: 23417
{
	// Fields
	public Sprite sprite; // 0x48

	// Methods

	// RVA: 0x87F9604 Offset: 0x87F5604 VA: 0x87F9604
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromObjectFactory]
[Serializable]
public abstract class TextAsset : ScriptableObject // TypeDefIndex: 23418
{
	// Fields
	[SerializeField]
	internal string m_Version; // 0x18
	internal int m_InstanceID; // 0x20
	internal int m_HashCode; // 0x24
	[FormerlySerializedAs("material")]
	[SerializeField]
	internal Material m_Material; // 0x28
	internal int m_MaterialHashCode; // 0x30

	// Properties
	public string version { get; set; }
	public int instanceID { get; }
	public int hashCode { get; set; }
	public Material material { get; set; }
	public int materialHashCode { get; set; }

	// Methods

	// RVA: 0x87F960C Offset: 0x87F560C VA: 0x87F960C
	public string get_version() { }

	// RVA: 0x87F9614 Offset: 0x87F5614 VA: 0x87F9614
	internal void set_version(string value) { }

	// RVA: 0x87EFB48 Offset: 0x87EBB48 VA: 0x87EFB48
	public int get_instanceID() { }

	// RVA: 0x87F6D30 Offset: 0x87F2D30 VA: 0x87F6D30
	public int get_hashCode() { }

	// RVA: 0x87F961C Offset: 0x87F561C VA: 0x87F961C
	public void set_hashCode(int value) { }

	// RVA: 0x87F9624 Offset: 0x87F5624 VA: 0x87F9624
	public Material get_material() { }

	// RVA: 0x87F962C Offset: 0x87F562C VA: 0x87F962C
	public void set_material(Material value) { }

	// RVA: 0x87F6D60 Offset: 0x87F2D60 VA: 0x87F6D60
	public int get_materialHashCode() { }

	// RVA: 0x87F9634 Offset: 0x87F5634 VA: 0x87F9634
	public void set_materialHashCode(int value) { }

	// RVA: 0x87F4690 Offset: 0x87F0690 VA: 0x87F4690
	protected void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
public enum ColorGradientMode // TypeDefIndex: 23419
{
	// Fields
	public int value__; // 0x0
	public const ColorGradientMode Single = 0;
	public const ColorGradientMode HorizontalGradient = 1;
	public const ColorGradientMode VerticalGradient = 2;
	public const ColorGradientMode FourCornersGradient = 3;
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[Serializable]
public class TextColorGradient : ScriptableObject // TypeDefIndex: 23420
{
	// Fields
	public ColorGradientMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorGradientMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x87F963C Offset: 0x87F563C VA: 0x87F963C
	public void .ctor() { }

	// RVA: 0x87F96D8 Offset: 0x87F56D8 VA: 0x87F96D8
	public void .ctor(Color color) { }

	// RVA: 0x87F9744 Offset: 0x87F5744 VA: 0x87F9744
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x87F97E8 Offset: 0x87F57E8 VA: 0x87F97E8
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
public enum TextElementType // TypeDefIndex: 23421
{
	// Fields
	public byte value__; // 0x0
	public const TextElementType Character = 1;
	public const TextElementType Sprite = 2;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public abstract class TextElement // TypeDefIndex: 23422
{
	// Fields
	[SerializeField]
	protected TextElementType m_ElementType; // 0x10
	[SerializeField]
	internal uint m_Unicode; // 0x14
	internal TextAsset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField]
	internal uint m_GlyphIndex; // 0x28
	[SerializeField]
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TextAsset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x87F9834 Offset: 0x87F5834 VA: 0x87F9834
	public TextElementType get_elementType() { }

	// RVA: 0x87ED444 Offset: 0x87E9444 VA: 0x87ED444
	public uint get_unicode() { }

	// RVA: 0x87EAE24 Offset: 0x87E6E24 VA: 0x87EAE24
	public void set_unicode(uint value) { }

	// RVA: 0x87F501C Offset: 0x87F101C VA: 0x87F501C
	public TextAsset get_textAsset() { }

	// RVA: 0x87EAE2C Offset: 0x87E6E2C VA: 0x87EAE2C
	public void set_textAsset(TextAsset value) { }

	// RVA: 0x87F983C Offset: 0x87F583C VA: 0x87F983C
	public Glyph get_glyph() { }

	// RVA: 0x87EAE34 Offset: 0x87E6E34 VA: 0x87EAE34
	public void set_glyph(Glyph value) { }

	// RVA: 0x87EC660 Offset: 0x87E8660 VA: 0x87EC660
	public uint get_glyphIndex() { }

	// RVA: 0x87EAE3C Offset: 0x87E6E3C VA: 0x87EAE3C
	public void set_glyphIndex(uint value) { }

	// RVA: 0x87F9844 Offset: 0x87F5844 VA: 0x87F9844
	public float get_scale() { }

	// RVA: 0x87EADA0 Offset: 0x87E6DA0 VA: 0x87EADA0
	public void set_scale(float value) { }

	// RVA: 0x87EAD98 Offset: 0x87E6D98 VA: 0x87EAD98
	protected void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct TextVertex // TypeDefIndex: 23423
{
	// Fields
	public Vector3 position; // 0x0
	public Vector4 uv; // 0xC
	public Vector2 uv2; // 0x1C
	public Color32 color; // 0x24
}

// Namespace: UnityEngine.TextCore.Text
internal struct TextElementInfo // TypeDefIndex: 23424
{
	// Fields
	public char character; // 0x0
	public int index; // 0x4
	public TextElementType elementType; // 0x8
	public int stringLength; // 0xC
	public TextElement textElement; // 0x10
	public Glyph alternativeGlyph; // 0x18
	public FontAsset fontAsset; // 0x20
	public SpriteAsset spriteAsset; // 0x28
	public int spriteIndex; // 0x30
	public Material material; // 0x38
	public int materialReferenceIndex; // 0x40
	public bool isUsingAlternateTypeface; // 0x44
	public float pointSize; // 0x48
	public int lineNumber; // 0x4C
	public int pageNumber; // 0x50
	public int vertexIndex; // 0x54
	public TextVertex vertexTopLeft; // 0x58
	public TextVertex vertexBottomLeft; // 0x80
	public TextVertex vertexTopRight; // 0xA8
	public TextVertex vertexBottomRight; // 0xD0
	public Vector3 topLeft; // 0xF8
	public Vector3 bottomLeft; // 0x104
	public Vector3 topRight; // 0x110
	public Vector3 bottomRight; // 0x11C
	public float origin; // 0x128
	public float ascender; // 0x12C
	public float baseLine; // 0x130
	public float descender; // 0x134
	internal float adjustedAscender; // 0x138
	internal float adjustedDescender; // 0x13C
	internal float adjustedHorizontalAdvance; // 0x140
	public float xAdvance; // 0x144
	public float aspectRatio; // 0x148
	public float scale; // 0x14C
	public Color32 color; // 0x150
	public Color32 underlineColor; // 0x154
	public int underlineVertexIndex; // 0x158
	public Color32 strikethroughColor; // 0x15C
	public int strikethroughVertexIndex; // 0x160
	public Color32 highlightColor; // 0x164
	public HighlightState highlightState; // 0x168
	public FontStyles style; // 0x17C
	public bool isVisible; // 0x180

	// Methods

	// RVA: 0x87F984C Offset: 0x87F584C VA: 0x87F984C Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore.Text
internal class TextGenerationSettings : IEquatable<TextGenerationSettings> // TypeDefIndex: 23425
{
	// Fields
	public string text; // 0x10
	public Rect screenRect; // 0x18
	public Vector4 margins; // 0x28
	public float scale; // 0x38
	public FontAsset fontAsset; // 0x40
	public Material material; // 0x48
	public SpriteAsset spriteAsset; // 0x50
	public TextStyleSheet styleSheet; // 0x58
	public FontStyles fontStyle; // 0x60
	public TextSettings textSettings; // 0x68
	public TextAlignment textAlignment; // 0x70
	public TextOverflowMode overflowMode; // 0x74
	public bool wordWrap; // 0x78
	public float wordWrappingRatio; // 0x7C
	public Color color; // 0x80
	public TextColorGradient fontColorGradient; // 0x90
	public TextColorGradient fontColorGradientPreset; // 0x98
	public bool tintSprites; // 0xA0
	public bool overrideRichTextColors; // 0xA1
	public bool shouldConvertToLinearSpace; // 0xA2
	public float fontSize; // 0xA4
	public bool autoSize; // 0xA8
	public float fontSizeMin; // 0xAC
	public float fontSizeMax; // 0xB0
	public bool enableKerning; // 0xB4
	public bool richText; // 0xB5
	public bool isRightToLeft; // 0xB6
	public float extraPadding; // 0xB8
	public bool parseControlCharacters; // 0xBC
	public bool isOrthographic; // 0xBD
	public bool tagNoParsing; // 0xBE
	public float characterSpacing; // 0xC0
	public float wordSpacing; // 0xC4
	public float lineSpacing; // 0xC8
	public float paragraphSpacing; // 0xCC
	public float lineSpacingMax; // 0xD0
	public TextWrappingMode textWrappingMode; // 0xD4
	public int maxVisibleCharacters; // 0xD8
	public int maxVisibleWords; // 0xDC
	public int maxVisibleLines; // 0xE0
	public int firstVisibleCharacter; // 0xE4
	public bool useMaxVisibleDescender; // 0xE8
	public TextFontWeight fontWeight; // 0xEC
	public int pageToDisplay; // 0xF0
	public TextureMapping horizontalMapping; // 0xF4
	public TextureMapping verticalMapping; // 0xF8
	public float uvLineOffset; // 0xFC
	public VertexSortingOrder geometrySortingOrder; // 0x100
	public bool inverseYAxis; // 0x104
	public float charWidthMaxAdj; // 0x108
	internal TextInputSource inputSource; // 0x10C

	// Methods

	// RVA: 0x87FB3F8 Offset: 0x87F73F8 VA: 0x87FB3F8 Slot: 4
	public bool Equals(TextGenerationSettings other) { }

	// RVA: 0x87FB8A0 Offset: 0x87F78A0 VA: 0x87FB8A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x87FB9AC Offset: 0x87F79AC VA: 0x87FB9AC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x87FBE7C Offset: 0x87F7E7C VA: 0x87FBE7C
	public static bool op_Equality(TextGenerationSettings left, TextGenerationSettings right) { }

	// RVA: 0x87FBE84 Offset: 0x87F7E84 VA: 0x87FBE84 Slot: 3
	public override string ToString() { }

	// RVA: 0x87FDEC0 Offset: 0x87F9EC0 VA: 0x87FDEC0
	public void .ctor() { }
}

// Namespace: 
public sealed class TextGenerator.MissingCharacterEventCallback : MulticastDelegate // TypeDefIndex: 23426
{
	// Methods

	// RVA: 0x88135EC Offset: 0x880F5EC VA: 0x88135EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x881368C Offset: 0x880F68C VA: 0x881368C Slot: 13
	public virtual void Invoke(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset) { }
}

// Namespace: 
protected struct TextGenerator.SpecialCharacter // TypeDefIndex: 23427
{
	// Fields
	public Character character; // 0x0
	public FontAsset fontAsset; // 0x8
	public Material material; // 0x10
	public int materialIndex; // 0x18

	// Methods

	// RVA: 0x88136A0 Offset: 0x880F6A0 VA: 0x88136A0
	public void .ctor(Character character, int materialIndex) { }
}

// Namespace: UnityEngine.TextCore.Text
internal class TextGenerator // TypeDefIndex: 23428
{
	// Fields
	private static TextGenerator s_TextGenerator; // 0x0
	private TextBackingContainer m_TextBackingArray; // 0x10
	internal TextProcessingElement[] m_TextProcessingArray; // 0x20
	internal int m_InternalTextProcessingArraySize; // 0x28
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; // 0x2C
	private char[] m_HtmlTag; // 0x30
	internal HighlightState m_HighlightState; // 0x38
	protected bool m_IsIgnoringAlignment; // 0x4C
	protected static bool m_IsTextTruncated; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static TextGenerator.MissingCharacterEventCallback OnMissingCharacter; // 0x10
	private Vector3[] m_RectTransformCorners; // 0x50
	private float m_MarginWidth; // 0x58
	private float m_MarginHeight; // 0x5C
	private float m_PreferredWidth; // 0x60
	private float m_PreferredHeight; // 0x64
	private FontAsset m_CurrentFontAsset; // 0x68
	private Material m_CurrentMaterial; // 0x70
	private int m_CurrentMaterialIndex; // 0x78
	private TextProcessingStack<MaterialReference> m_MaterialReferenceStack; // 0x80
	private float m_Padding; // 0xD8
	private SpriteAsset m_CurrentSpriteAsset; // 0xE0
	private int m_TotalCharacterCount; // 0xE8
	private float m_FontSize; // 0xEC
	private float m_FontScaleMultiplier; // 0xF0
	private float m_CurrentFontSize; // 0xF4
	private TextProcessingStack<float> m_SizeStack; // 0xF8
	protected TextProcessingStack<int>[] m_TextStyleStacks; // 0x118
	protected int m_TextStyleStackDepth; // 0x120
	private FontStyles m_FontStyleInternal; // 0x124
	private FontStyleStack m_FontStyleStack; // 0x128
	private TextFontWeight m_FontWeightInternal; // 0x134
	private TextProcessingStack<TextFontWeight> m_FontWeightStack; // 0x138
	private TextAlignment m_LineJustification; // 0x158
	private TextProcessingStack<TextAlignment> m_LineJustificationStack; // 0x160
	private float m_BaselineOffset; // 0x180
	private TextProcessingStack<float> m_BaselineOffsetStack; // 0x188
	private Color32 m_FontColor32; // 0x1A8
	private Color32 m_HtmlColor; // 0x1AC
	private Color32 m_UnderlineColor; // 0x1B0
	private Color32 m_StrikethroughColor; // 0x1B4
	private TextProcessingStack<Color32> m_ColorStack; // 0x1B8
	private TextProcessingStack<Color32> m_UnderlineColorStack; // 0x1D8
	private TextProcessingStack<Color32> m_StrikethroughColorStack; // 0x1F8
	private TextProcessingStack<Color32> m_HighlightColorStack; // 0x218
	private TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x238
	private TextProcessingStack<int> m_ItalicAngleStack; // 0x268
	private TextColorGradient m_ColorGradientPreset; // 0x288
	private TextProcessingStack<TextColorGradient> m_ColorGradientStack; // 0x290
	private bool m_ColorGradientPresetIsTinted; // 0x2B8
	private TextProcessingStack<int> m_ActionStack; // 0x2C0
	private float m_LineOffset; // 0x2E0
	private float m_LineHeight; // 0x2E4
	private bool m_IsDrivenLineSpacing; // 0x2E8
	private float m_CSpacing; // 0x2EC
	private float m_MonoSpacing; // 0x2F0
	private float m_XAdvance; // 0x2F4
	private float m_TagLineIndent; // 0x2F8
	private float m_TagIndent; // 0x2FC
	private TextProcessingStack<float> m_IndentStack; // 0x300
	private bool m_TagNoParsing; // 0x320
	private int m_CharacterCount; // 0x324
	private int m_FirstCharacterOfLine; // 0x328
	private int m_LastCharacterOfLine; // 0x32C
	private int m_FirstVisibleCharacterOfLine; // 0x330
	private int m_LastVisibleCharacterOfLine; // 0x334
	private float m_MaxLineAscender; // 0x338
	private float m_MaxLineDescender; // 0x33C
	private int m_LineNumber; // 0x340
	private int m_LineVisibleCharacterCount; // 0x344
	private int m_LineVisibleSpaceCount; // 0x348
	private int m_FirstOverflowCharacterIndex; // 0x34C
	private int m_PageNumber; // 0x350
	private float m_MarginLeft; // 0x354
	private float m_MarginRight; // 0x358
	private float m_Width; // 0x35C
	private Extents m_MeshExtents; // 0x360
	private float m_MaxCapHeight; // 0x370
	private float m_MaxAscender; // 0x374
	private float m_MaxDescender; // 0x378
	private bool m_IsNewPage; // 0x37C
	private bool m_IsNonBreakingSpace; // 0x37D
	private WordWrapState m_SavedWordWrapState; // 0x380
	private WordWrapState m_SavedLineState; // 0x718
	private WordWrapState m_SavedEllipsisState; // 0xAB0
	private WordWrapState m_SavedLastValidState; // 0xE48
	private WordWrapState m_SavedSoftLineBreakState; // 0x11E0
	private TextElementType m_TextElementType; // 0x1578
	private bool m_isTextLayoutPhase; // 0x1579
	private int m_SpriteIndex; // 0x157C
	private Color32 m_SpriteColor; // 0x1580
	private TextElement m_CachedTextElement; // 0x1588
	private Color32 m_HighlightColor; // 0x1590
	private float m_CharWidthAdjDelta; // 0x1594
	private float m_MaxFontSize; // 0x1598
	private float m_MinFontSize; // 0x159C
	private int m_AutoSizeIterationCount; // 0x15A0
	private int m_AutoSizeMaxIterationCount; // 0x15A4
	private bool m_IsAutoSizePointSizeSet; // 0x15A8
	private float m_StartOfLineAscender; // 0x15AC
	private float m_LineSpacingDelta; // 0x15B0
	private MaterialReference[] m_MaterialReferences; // 0x15B8
	private int m_SpriteCount; // 0x15C0
	private TextProcessingStack<int> m_StyleStack; // 0x15C8
	private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x15E8
	private int m_SpriteAnimationId; // 0x19A0
	private int m_ItalicAngle; // 0x19A4
	private Vector3 m_FXScale; // 0x19A8
	private Quaternion m_FXRotation; // 0x19B4
	private int m_LastBaseGlyphIndex; // 0x19C4
	private float m_PageAscender; // 0x19C8
	private RichTextTagAttribute[] m_XmlAttribute; // 0x19D0
	private float[] m_AttributeParameterValues; // 0x19D8
	private Dictionary<int, int> m_MaterialReferenceIndexLookup; // 0x19E0
	private bool m_IsCalculatingPreferredValues; // 0x19E8
	private SpriteAsset m_DefaultSpriteAsset; // 0x19F0
	private bool m_TintSprite; // 0x19F8
	protected TextGenerator.SpecialCharacter m_Ellipsis; // 0x1A00
	protected TextGenerator.SpecialCharacter m_Underline; // 0x1A20
	private TextElementInfo[] m_InternalTextElementInfo; // 0x1A40

	// Properties
	public static bool isTextTruncated { get; }

	// Methods

	// RVA: 0x88058C8 Offset: 0x88018C8 VA: 0x88058C8
	private static TextGenerator GetTextGenerator() { }

	// RVA: 0x88060E8 Offset: 0x88020E8 VA: 0x88060E8
	public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x8806350 Offset: 0x8802350 VA: 0x8806350
	public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x88065BC Offset: 0x88025BC VA: 0x88065BC
	public static bool get_isTextTruncated() { }

	// RVA: 0x880625C Offset: 0x880225C VA: 0x880625C
	private void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x87FDF3C Offset: 0x87F9F3C VA: 0x87FDF3C
	private void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x88089DC Offset: 0x88049DC VA: 0x88089DC
	private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo) { }

	// RVA: 0x8808D38 Offset: 0x8804D38 VA: 0x8808D38
	protected int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo) { }

	// RVA: 0x88090A4 Offset: 0x88050A4 VA: 0x88090A4
	protected bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x880D974 Offset: 0x8809974 VA: 0x880D974
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x880E4E0 Offset: 0x880A4E0 VA: 0x880E4E0
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x880ED08 Offset: 0x880AD08 VA: 0x880ED08
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x880F944 Offset: 0x880B944 VA: 0x880F944
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x880FEC0 Offset: 0x880BEC0 VA: 0x880FEC0
	private static void ClearMesh(bool updateMesh, TextInfo textInfo) { }

	// RVA: 0x880740C Offset: 0x880340C VA: 0x880740C
	internal int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x881008C Offset: 0x880C08C VA: 0x881008C
	internal TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x880662C Offset: 0x880262C VA: 0x880662C
	private void ComputeMarginSize(Rect rect, Vector4 margins) { }

	// RVA: 0x8806604 Offset: 0x8802604 VA: 0x8806604
	protected void GetSpecialCharacters(TextGenerationSettings generationSettings) { }

	// RVA: 0x880FEE0 Offset: 0x880BEE0 VA: 0x880FEE0
	protected void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x880F8B0 Offset: 0x880B8B0 VA: 0x880F8B0
	protected void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x8806480 Offset: 0x8802480 VA: 0x8806480
	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x881041C Offset: 0x880C41C VA: 0x881041C Slot: 4
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingMode textWrapMode, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x8806694 Offset: 0x8802694 VA: 0x8806694
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x8812FEC Offset: 0x880EFEC VA: 0x8812FEC
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x88066AC Offset: 0x88026AC VA: 0x88066AC
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings) { }

	// RVA: 0x88130E0 Offset: 0x880F0E0 VA: 0x88130E0
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x8810380 Offset: 0x880C380 VA: 0x8810380
	protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo) { }

	// RVA: 0x880D910 Offset: 0x8809910 VA: 0x880D910
	private void ClearMarkupTagAttributes() { }

	// RVA: 0x8805948 Offset: 0x8801948 VA: 0x8805948
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextAlignment // TypeDefIndex: 23429
{
	// Fields
	public int value__; // 0x0
	public const TextAlignment TopLeft = 257;
	public const TextAlignment TopCenter = 258;
	public const TextAlignment TopRight = 260;
	public const TextAlignment TopJustified = 264;
	public const TextAlignment TopFlush = 272;
	public const TextAlignment TopGeoAligned = 288;
	public const TextAlignment MiddleLeft = 513;
	public const TextAlignment MiddleCenter = 514;
	public const TextAlignment MiddleRight = 516;
	public const TextAlignment MiddleJustified = 520;
	public const TextAlignment MiddleFlush = 528;
	public const TextAlignment MiddleGeoAligned = 544;
	public const TextAlignment BottomLeft = 1025;
	public const TextAlignment BottomCenter = 1026;
	public const TextAlignment BottomRight = 1028;
	public const TextAlignment BottomJustified = 1032;
	public const TextAlignment BottomFlush = 1040;
	public const TextAlignment BottomGeoAligned = 1056;
	public const TextAlignment BaselineLeft = 2049;
	public const TextAlignment BaselineCenter = 2050;
	public const TextAlignment BaselineRight = 2052;
	public const TextAlignment BaselineJustified = 2056;
	public const TextAlignment BaselineFlush = 2064;
	public const TextAlignment BaselineGeoAligned = 2080;
	public const TextAlignment MidlineLeft = 4097;
	public const TextAlignment MidlineCenter = 4098;
	public const TextAlignment MidlineRight = 4100;
	public const TextAlignment MidlineJustified = 4104;
	public const TextAlignment MidlineFlush = 4112;
	public const TextAlignment MidlineGeoAligned = 4128;
	public const TextAlignment CaplineLeft = 8193;
	public const TextAlignment CaplineCenter = 8194;
	public const TextAlignment CaplineRight = 8196;
	public const TextAlignment CaplineJustified = 8200;
	public const TextAlignment CaplineFlush = 8208;
	public const TextAlignment CaplineGeoAligned = 8224;
}

// Namespace: UnityEngine.TextCore.Text
[Flags]
public enum FontStyles // TypeDefIndex: 23430
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

// Namespace: UnityEngine.TextCore.Text
internal enum TextOverflowMode // TypeDefIndex: 23431
{
	// Fields
	public int value__; // 0x0
	public const TextOverflowMode Overflow = 0;
	public const TextOverflowMode Ellipsis = 1;
	public const TextOverflowMode Masking = 2;
	public const TextOverflowMode Truncate = 3;
	public const TextOverflowMode ScrollRect = 4;
	public const TextOverflowMode Page = 5;
	public const TextOverflowMode Linked = 6;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextureMapping // TypeDefIndex: 23432
{
	// Fields
	public int value__; // 0x0
	public const TextureMapping Character = 0;
	public const TextureMapping Line = 1;
	public const TextureMapping Paragraph = 2;
	public const TextureMapping MatchAspect = 3;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextWrappingMode // TypeDefIndex: 23433
{
	// Fields
	public int value__; // 0x0
	public const TextWrappingMode NoWrap = 0;
	public const TextWrappingMode Normal = 1;
	public const TextWrappingMode PreserveWhitespace = 2;
	public const TextWrappingMode PreserveWhitespaceNoWrap = 3;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextInputSource // TypeDefIndex: 23434
{
	// Fields
	public int value__; // 0x0
	public const TextInputSource TextInputBox = 0;
	public const TextInputSource SetText = 1;
	public const TextInputSource SetTextArray = 2;
	public const TextInputSource TextString = 3;
}

// Namespace: UnityEngine.TextCore.Text
internal struct RichTextTagAttribute // TypeDefIndex: 23435
{
	// Fields
	public int nameHashCode; // 0x0
	public int valueHashCode; // 0x4
	public TagValueType valueType; // 0x8
	public int valueStartIndex; // 0xC
	public int valueLength; // 0x10
	public TagUnitType unitType; // 0x14
}

// Namespace: UnityEngine.TextCore.Text
[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
internal struct TextProcessingElement // TypeDefIndex: 23436
{
	// Fields
	public TextProcessingElementType elementType; // 0x0
	public uint unicode; // 0x4
	public int stringIndex; // 0x8
	public int length; // 0xC
}

// Namespace: UnityEngine.TextCore.Text
[DefaultMember("Item")]
internal struct TextBackingContainer // TypeDefIndex: 23437
{
	// Fields
	private uint[] m_Array; // 0x0
	private int m_Count; // 0x8

	// Properties
	public int Capacity { get; }
	public int Count { get; set; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x88137F4 Offset: 0x880F7F4 VA: 0x88137F4
	public int get_Capacity() { }

	// RVA: 0x8813810 Offset: 0x880F810 VA: 0x8813810
	public int get_Count() { }

	// RVA: 0x8813818 Offset: 0x880F818 VA: 0x8813818
	public void set_Count(int value) { }

	// RVA: 0x8813820 Offset: 0x880F820 VA: 0x8813820
	public uint get_Item(int index) { }

	// RVA: 0x8813850 Offset: 0x880F850 VA: 0x8813850
	public void set_Item(int index, uint value) { }

	// RVA: 0x8813914 Offset: 0x880F914 VA: 0x8813914
	public void .ctor(int size) { }

	// RVA: 0x88138B0 Offset: 0x880F8B0 VA: 0x88138B0
	public void Resize(int size) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct CharacterSubstitution // TypeDefIndex: 23438
{
	// Fields
	public int index; // 0x0
	public uint unicode; // 0x4

	// Methods

	// RVA: 0x8813980 Offset: 0x880F980 VA: 0x8813980
	public void .ctor(int index, uint unicode) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct Offset // TypeDefIndex: 23439
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; }
	public float right { get; }
	public float top { get; }
	public float bottom { get; }
	public static Offset zero { get; }

	// Methods

	// RVA: 0x8813988 Offset: 0x880F988 VA: 0x8813988
	public float get_left() { }

	// RVA: 0x8813990 Offset: 0x880F990 VA: 0x8813990
	public float get_right() { }

	// RVA: 0x8813998 Offset: 0x880F998 VA: 0x8813998
	public float get_top() { }

	// RVA: 0x88139A0 Offset: 0x880F9A0 VA: 0x88139A0
	public float get_bottom() { }

	// RVA: 0x88139A8 Offset: 0x880F9A8 VA: 0x88139A8
	public static Offset get_zero() { }

	// RVA: 0x8813A04 Offset: 0x880FA04 VA: 0x8813A04
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x8813A10 Offset: 0x880FA10 VA: 0x8813A10
	public static bool op_Equality(Offset lhs, Offset rhs) { }

	// RVA: 0x8813A40 Offset: 0x880FA40 VA: 0x8813A40
	public static Offset op_Multiply(Offset a, float b) { }

	// RVA: 0x8813A54 Offset: 0x880FA54 VA: 0x8813A54 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8813AB8 Offset: 0x880FAB8 VA: 0x8813AB8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8813B30 Offset: 0x880FB30 VA: 0x8813B30
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct HighlightState // TypeDefIndex: 23440
{
	// Fields
	public Color32 color; // 0x0
	public Offset padding; // 0x4

	// Methods

	// RVA: 0x8813B78 Offset: 0x880FB78 VA: 0x8813B78
	public void .ctor(Color32 color, Offset padding) { }

	// RVA: 0x8813B88 Offset: 0x880FB88 VA: 0x8813B88
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x8813C7C Offset: 0x880FC7C VA: 0x8813C7C
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x8813CC4 Offset: 0x880FCC4 VA: 0x8813CC4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8813D30 Offset: 0x880FD30 VA: 0x8813D30 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct WordWrapState // TypeDefIndex: 23441
{
	// Fields
	public int previousWordBreak; // 0x0
	public int totalCharacterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int visibleSpaceCount; // 0xC
	public int visibleSpriteCount; // 0x10
	public int visibleLinkCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharIndex; // 0x24
	public int lineNumber; // 0x28
	public float maxCapHeight; // 0x2C
	public float maxAscender; // 0x30
	public float maxDescender; // 0x34
	public float maxLineAscender; // 0x38
	public float maxLineDescender; // 0x3C
	public float startOfLineAscender; // 0x40
	public float xAdvance; // 0x44
	public float preferredWidth; // 0x48
	public float preferredHeight; // 0x4C
	public float previousLineScale; // 0x50
	public float pageAscender; // 0x54
	public int wordCount; // 0x58
	public FontStyles fontStyle; // 0x5C
	public float fontScale; // 0x60
	public float fontScaleMultiplier; // 0x64
	public int italicAngle; // 0x68
	public float currentFontSize; // 0x6C
	public float baselineOffset; // 0x70
	public float lineOffset; // 0x74
	public TextInfo textInfo; // 0x78
	public LineInfo lineInfo; // 0x80
	public Color32 vertexColor; // 0xE0
	public Color32 underlineColor; // 0xE4
	public Color32 strikethroughColor; // 0xE8
	public Color32 highlightColor; // 0xEC
	public HighlightState highlightState; // 0xF0
	public FontStyleStack basicStyleStack; // 0x104
	public TextProcessingStack<int> italicAngleStack; // 0x110
	public TextProcessingStack<Color32> colorStack; // 0x130
	public TextProcessingStack<Color32> underlineColorStack; // 0x150
	public TextProcessingStack<Color32> strikethroughColorStack; // 0x170
	public TextProcessingStack<Color32> highlightColorStack; // 0x190
	public TextProcessingStack<HighlightState> highlightStateStack; // 0x1B0
	public TextProcessingStack<TextColorGradient> colorGradientStack; // 0x1E0
	public TextProcessingStack<float> sizeStack; // 0x208
	public TextProcessingStack<float> indentStack; // 0x228
	public TextProcessingStack<TextFontWeight> fontWeightStack; // 0x248
	public TextProcessingStack<int> styleStack; // 0x268
	public TextProcessingStack<float> baselineStack; // 0x288
	public TextProcessingStack<int> actionStack; // 0x2A8
	public TextProcessingStack<MaterialReference> materialReferenceStack; // 0x2C8
	public TextProcessingStack<TextAlignment> lineJustificationStack; // 0x320
	public int lastBaseGlyphIndex; // 0x340
	public int spriteAnimationId; // 0x344
	public FontAsset currentFontAsset; // 0x348
	public SpriteAsset currentSpriteAsset; // 0x350
	public Material currentMaterial; // 0x358
	public int currentMaterialIndex; // 0x360
	public Extents meshExtents; // 0x364
	public bool tagNoParsing; // 0x374
	public bool isNonBreakingSpace; // 0x375
	public bool isDrivenLineSpacing; // 0x376
	public Vector3 fxScale; // 0x378
	public Quaternion fxRotation; // 0x384
}

// Namespace: UnityEngine.TextCore.Text
[Extension]
internal static class TextGeneratorUtilities // TypeDefIndex: 23442
{
	// Fields
	public static readonly Vector2 largePositiveVector2; // 0x0
	public static readonly Vector2 largeNegativeVector2; // 0x8

	// Methods

	// RVA: 0x8813DB0 Offset: 0x880FDB0 VA: 0x8813DB0
	public static bool Approximately(float a, float b) { }

	// RVA: 0x8813DE0 Offset: 0x880FDE0 VA: 0x8813DE0
	public static Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x8814414 Offset: 0x8810414 VA: 0x8814414
	public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x88143E8 Offset: 0x88103E8 VA: 0x88143E8
	public static uint HexToInt(char hex) { }

	// RVA: 0x88146A0 Offset: 0x88106A0 VA: 0x88146A0
	public static float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x8814720 Offset: 0x8810720 VA: 0x8814720
	public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x8814880 Offset: 0x8810880 VA: 0x8814880
	public static Vector2 PackUV(float x, float y, float scale) { }

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471B2C4 Offset: 0x47172C4 VA: 0x471B2C4
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0x471B31C Offset: 0x471731C VA: 0x471B31C
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471B378 Offset: 0x4717378 VA: 0x471B378
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0x471B3C4 Offset: 0x47173C4 VA: 0x471B3C4
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x88148E0 Offset: 0x88108E0 VA: 0x88148E0
	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x8814E7C Offset: 0x8810E7C VA: 0x8814E7C
	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x8814F7C Offset: 0x8810F7C VA: 0x8814F7C
	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x88152A4 Offset: 0x88112A4 VA: 0x88152A4
	private static bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x88154D4 Offset: 0x88114D4 VA: 0x88154D4
	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x8815600 Offset: 0x8811600 VA: 0x8815600
	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x88156D8 Offset: 0x88116D8 VA: 0x88156D8
	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x88149E8 Offset: 0x88109E8 VA: 0x88149E8
	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x88151C0 Offset: 0x88111C0 VA: 0x88151C0
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	// RVA: 0x88153FC Offset: 0x88113FC VA: 0x88153FC
	public static int GetStyleHashCode(ref uint[] text, int index, out int closeIndex) { }

	// RVA: 0x88150D4 Offset: 0x88110D4 VA: 0x88150D4
	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: 0x88157BC Offset: 0x88117BC VA: 0x88157BC
	public static uint GetUTF16(uint[] text, int i) { }

	// RVA: 0x8815C38 Offset: 0x8811C38 VA: 0x8815C38
	public static uint GetUTF16(TextBackingContainer text, int i) { }

	// RVA: 0x88158A4 Offset: 0x88118A4 VA: 0x88158A4
	public static uint GetUTF32(uint[] text, int i) { }

	// RVA: 0x8815CF4 Offset: 0x8811CF4 VA: 0x8815CF4
	public static uint GetUTF32(TextBackingContainer text, int i) { }

	// RVA: 0x8815E00 Offset: 0x8811E00 VA: 0x8815E00
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x8816838 Offset: 0x8812838 VA: 0x8816838
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x88170D8 Offset: 0x88130D8 VA: 0x88170D8
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	// RVA: 0x8817258 Offset: 0x8813258 VA: 0x8817258
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	// RVA: 0x8817410 Offset: 0x8813410 VA: 0x8817410
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	// RVA: 0x8817420 Offset: 0x8813420 VA: 0x8817420
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	// RVA: 0x8817444 Offset: 0x8813444 VA: 0x8817444
	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x8817458 Offset: 0x8813458 VA: 0x8817458
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x8815A24 Offset: 0x8811A24 VA: 0x8815A24
	public static int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex) { }

	// RVA: 0x8815BC4 Offset: 0x8811BC4 VA: 0x8815BC4
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x881755C Offset: 0x881355C VA: 0x881755C
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x88175D0 Offset: 0x88135D0 VA: 0x88175D0
	public static char ToUpperFast(char c) { }

	// RVA: 0x8817644 Offset: 0x8813644 VA: 0x8817644
	public static int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x8817728 Offset: 0x8813728 VA: 0x8817728
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	// RVA: 0x8817768 Offset: 0x8813768 VA: 0x8817768
	public static bool IsBaseGlyph(uint c) { }

	[Extension]
	// RVA: 0x8817890 Offset: 0x8813890 VA: 0x8817890
	public static Color MinAlpha(Color c1, Color c2) { }

	// RVA: 0x881679C Offset: 0x881279C VA: 0x881679C
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x881789C Offset: 0x881389C VA: 0x881789C
	private static byte GammaToLinear(byte value) { }

	// RVA: 0x881794C Offset: 0x881394C VA: 0x881794C
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	// RVA: 0x88179E8 Offset: 0x88139E8 VA: 0x88179E8
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	// RVA: 0x8817A84 Offset: 0x8813A84 VA: 0x8817A84
	internal static bool IsHangul(uint c) { }

	// RVA: 0x8817AF4 Offset: 0x8813AF4 VA: 0x8817AF4
	internal static bool IsCJK(uint c) { }

	// RVA: 0x8817CAC Offset: 0x8813CAC VA: 0x8817CAC
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal class TextHandle // TypeDefIndex: 23443
{
	// Fields
	private Vector2 m_PreferredSize; // 0x10
	private TextInfo m_TextInfo; // 0x18
	private static TextInfo m_LayoutTextInfo; // 0x0
	private int m_PreviousGenerationSettingsHash; // 0x20
	protected TextGenerationSettings textGenerationSettings; // 0x28
	protected static TextGenerationSettings s_LayoutSettings; // 0x8
	private bool isDirty; // 0x30

	// Properties
	internal TextInfo textInfo { get; }
	internal static TextInfo layoutTextInfo { get; }

	// Methods

	// RVA: 0x8817D10 Offset: 0x8813D10 VA: 0x8817D10
	public void .ctor() { }

	// RVA: 0x8817D7C Offset: 0x8813D7C VA: 0x8817D7C
	internal TextInfo get_textInfo() { }

	// RVA: 0x8817F68 Offset: 0x8813F68 VA: 0x8817F68
	internal static TextInfo get_layoutTextInfo() { }

	// RVA: 0x8818030 Offset: 0x8814030 VA: 0x8818030
	public bool IsDirty() { }

	// RVA: 0x8818080 Offset: 0x8814080 VA: 0x8818080
	public Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = True) { }

	// RVA: 0x88181D0 Offset: 0x88141D0 VA: 0x88181D0
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = False, bool inverseYAxis = True) { }

	// RVA: 0x881835C Offset: 0x881435C VA: 0x881835C
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = True) { }

	// RVA: 0x8818804 Offset: 0x8814804 VA: 0x8818804
	public int LineDownCharacterPosition(int originalPos) { }

	// RVA: 0x88189E0 Offset: 0x88149E0 VA: 0x88189E0
	public int LineUpCharacterPosition(int originalPos) { }

	// RVA: 0x8818474 Offset: 0x8814474 VA: 0x8818474
	public int FindNearestLine(Vector2 position) { }

	// RVA: 0x8818544 Offset: 0x8814544 VA: 0x8818544
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	// RVA: 0x8818D30 Offset: 0x8814D30 VA: 0x8818D30
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = True) { }

	// RVA: 0x8818BA8 Offset: 0x8814BA8 VA: 0x8818BA8
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x8818C68 Offset: 0x8814C68 VA: 0x8818C68
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x8818FF4 Offset: 0x8814FF4 VA: 0x8818FF4
	public int GetLineNumber(int index) { }

	// RVA: 0x8819084 Offset: 0x8815084 VA: 0x8819084
	public float GetLineHeight(int lineNumber) { }

	// RVA: 0x8819114 Offset: 0x8815114 VA: 0x8819114
	public float GetLineHeightFromCharacterIndex(int index) { }

	// RVA: 0x88191A8 Offset: 0x88151A8 VA: 0x88191A8
	public float GetCharacterHeightFromIndex(int index) { }

	// RVA: 0x8819240 Offset: 0x8815240 VA: 0x8819240
	public bool IsElided() { }

	// RVA: 0x8819280 Offset: 0x8815280 VA: 0x8819280
	public string Substring(int startIndex, int length) { }

	// RVA: 0x88193B8 Offset: 0x88153B8 VA: 0x88193B8
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x88194A0 Offset: 0x88154A0 VA: 0x88194A0
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x881956C Offset: 0x881556C VA: 0x881956C
	protected float ComputeTextWidth(TextGenerationSettings tgs) { }

	// RVA: 0x88195F8 Offset: 0x88155F8 VA: 0x88195F8
	protected float ComputeTextHeight(TextGenerationSettings tgs) { }

	// RVA: 0x8819584 Offset: 0x8815584 VA: 0x8819584
	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	// RVA: 0x8819610 Offset: 0x8815610 VA: 0x8819610
	protected TextInfo Update(TextGenerationSettings tgs) { }

	// RVA: 0x8819688 Offset: 0x8815688 VA: 0x8819688
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct PageInfo // TypeDefIndex: 23444
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10
}

// Namespace: UnityEngine.TextCore.Text
internal struct WordInfo // TypeDefIndex: 23445
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public int characterCount; // 0x8
}

// Namespace: UnityEngine.TextCore.Text
internal class TextInfo // TypeDefIndex: 23446
{
	// Fields
	private static Vector2 s_InfinityVectorPositive; // 0x0
	private static Vector2 s_InfinityVectorNegative; // 0x8
	public int characterCount; // 0x10
	public int spriteCount; // 0x14
	public int spaceCount; // 0x18
	public int wordCount; // 0x1C
	public int linkCount; // 0x20
	public int lineCount; // 0x24
	public int pageCount; // 0x28
	public int materialCount; // 0x2C
	public TextElementInfo[] textElementInfo; // 0x30
	public WordInfo[] wordInfo; // 0x38
	public LinkInfo[] linkInfo; // 0x40
	public LineInfo[] lineInfo; // 0x48
	public PageInfo[] pageInfo; // 0x50
	public MeshInfo[] meshInfo; // 0x58
	public bool isDirty; // 0x60
	public bool hasMultipleColors; // 0x61

	// Methods

	// RVA: 0x8817DE8 Offset: 0x8813DE8 VA: 0x8817DE8
	public void .ctor() { }

	// RVA: 0x88196FC Offset: 0x88156FC VA: 0x88196FC
	internal void Clear() { }

	// RVA: 0x881975C Offset: 0x881575C VA: 0x881975C
	internal void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x8819818 Offset: 0x8815818 VA: 0x8819818
	internal void ClearLineInfo() { }

	// RVA: 0x8819994 Offset: 0x8815994 VA: 0x8819994
	internal void ClearPageInfo() { }

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471B414 Offset: 0x4717414 VA: 0x471B414
	|-TextInfo.Resize<LinkInfo>
	|
	|-RVA: 0x471B470 Offset: 0x4717470 VA: 0x471B470
	|-TextInfo.Resize<WordInfo>
	|
	|-RVA: 0x471B4CC Offset: 0x47174CC VA: 0x471B4CC
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471B52C Offset: 0x471752C VA: 0x471B52C
	|-TextInfo.Resize<MeshInfo>
	|
	|-RVA: 0x471B5CC Offset: 0x47175CC VA: 0x471B5CC
	|-TextInfo.Resize<PageInfo>
	|
	|-RVA: 0x471B66C Offset: 0x471766C VA: 0x471B66C
	|-TextInfo.Resize<TextElementInfo>
	|
	|-RVA: 0x471B70C Offset: 0x471770C VA: 0x471B70C
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8819A3C Offset: 0x8815A3C VA: 0x8819A3C
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal enum MarkupTag // TypeDefIndex: 23447
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
	public const MarkupTag TABLE = 226476955;
	public const MarkupTag SLASH_TABLE = -979118220;
	public const MarkupTag TH = 5862489;
	public const MarkupTag SLASH_TH = 193346070;
	public const MarkupTag TR = 5862467;
	public const MarkupTag SLASH_TR = 193346060;
	public const MarkupTag TD = 5862485;
	public const MarkupTag SLASH_TD = 193346074;
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
	public const MarkupTag PADDING = -2144568463;
	public const MarkupTag FAMILYNAME = 704251153;
	public const MarkupTag STYLENAME = -1207081936;
	public const MarkupTag RED = 91635;
	public const MarkupTag GREEN = 87065851;
	public const MarkupTag BLUE = 2457214;
	public const MarkupTag YELLOW = -882444668;
	public const MarkupTag ORANGE = -1108587920;
	public const MarkupTag BLACK = 81074727;
	public const MarkupTag WHITE = 105680263;
	public const MarkupTag PURPLE = -1250222130;
	public const MarkupTag BR = 2256;
	public const MarkupTag CR = 2289;
	public const MarkupTag ZWSP = 3288238;
	public const MarkupTag ZWJ = 99623;
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
	public const MarkupTag NOTDEF = 612146780;
	public const MarkupTag NORMAL = -1183493901;
	public const MarkupTag DEFAULT = -620974005;
	public const MarkupTag REGULAR = 1291372090;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TagValueType // TypeDefIndex: 23448
{
	// Fields
	public int value__; // 0x0
	public const TagValueType None = 0;
	public const TagValueType NumericalValue = 1;
	public const TagValueType StringValue = 2;
	public const TagValueType ColorValue = 4;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TagUnitType // TypeDefIndex: 23449
{
	// Fields
	public int value__; // 0x0
	public const TagUnitType Pixels = 0;
	public const TagUnitType FontUnits = 1;
	public const TagUnitType Percentage = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextProcessingElementType // TypeDefIndex: 23450
{
	// Fields
	public int value__; // 0x0
	public const TextProcessingElementType Undefined = 0;
	public const TextProcessingElementType TextCharacterElement = 1;
	public const TextProcessingElementType TextMarkupElement = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal struct FontStyleStack // TypeDefIndex: 23451
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

	// RVA: 0x8819AA8 Offset: 0x8815AA8 VA: 0x8819AA8
	public void Clear() { }

	// RVA: 0x8819AB4 Offset: 0x8815AB4 VA: 0x8819AB4
	public byte Add(FontStyles style) { }

	// RVA: 0x8819BB0 Offset: 0x8815BB0 VA: 0x8819BB0
	public byte Remove(FontStyles style) { }
}

// Namespace: UnityEngine.TextCore.Text
[DebuggerDisplay("Item count = {m_Count}")]
internal struct TextProcessingStack<T> // TypeDefIndex: 23452
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0

	// Properties
	public int Count { get; }
	public T current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B364 Offset: 0x5617364 VA: 0x561B364
	|-TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x561B8A8 Offset: 0x56178A8 VA: 0x561B8A8
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x561BF88 Offset: 0x5617F88 VA: 0x561BF88
	|-TextProcessingStack<int>..ctor
	|
	|-RVA: 0x561C4DC Offset: 0x56184DC VA: 0x561C4DC
	|-TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x561CA30 Offset: 0x5618A30 VA: 0x561CA30
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x561D23C Offset: 0x561923C VA: 0x561D23C
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0x561D7BC Offset: 0x56197BC VA: 0x561D7BC
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x561DD14 Offset: 0x5619D14 VA: 0x561DD14
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x561E500 Offset: 0x561A500 VA: 0x561E500
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B3A4 Offset: 0x56173A4 VA: 0x561B3A4
	|-TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x561B8E8 Offset: 0x56178E8 VA: 0x561B8E8
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x561BFC8 Offset: 0x5617FC8 VA: 0x561BFC8
	|-TextProcessingStack<int>..ctor
	|
	|-RVA: 0x561C51C Offset: 0x561851C VA: 0x561C51C
	|-TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x561CA7C Offset: 0x5618A7C VA: 0x561CA7C
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x561D27C Offset: 0x561927C VA: 0x561D27C
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0x561D7FC Offset: 0x56197FC VA: 0x561D7FC
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x561DD64 Offset: 0x5619D64 VA: 0x561DD64
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x561E670 Offset: 0x561A670 VA: 0x561E670
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B414 Offset: 0x5617414 VA: 0x561B414
	|-TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x561B958 Offset: 0x5617958 VA: 0x561B958
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x561C038 Offset: 0x5618038 VA: 0x561C038
	|-TextProcessingStack<int>..ctor
	|
	|-RVA: 0x561C58C Offset: 0x561858C VA: 0x561C58C
	|-TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x561CAF8 Offset: 0x5618AF8 VA: 0x561CAF8
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x561D2EC Offset: 0x56192EC VA: 0x561D2EC
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0x561D86C Offset: 0x561986C VA: 0x561D86C
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x561DDE4 Offset: 0x5619DE4 VA: 0x561DDE4
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x561E810 Offset: 0x561A810 VA: 0x561E810
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B484 Offset: 0x5617484 VA: 0x561B484
	|-TextProcessingStack<Color32>.get_Count
	|
	|-RVA: 0x561B9D0 Offset: 0x56179D0 VA: 0x561B9D0
	|-TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x561C0A8 Offset: 0x56180A8 VA: 0x561C0A8
	|-TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x561C5FC Offset: 0x56185FC VA: 0x561C5FC
	|-TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x561CB78 Offset: 0x5618B78 VA: 0x561CB78
	|-TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x561D360 Offset: 0x5619360 VA: 0x561D360
	|-TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x561D8DC Offset: 0x56198DC VA: 0x561D8DC
	|-TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x561DE68 Offset: 0x5619E68 VA: 0x561DE68
	|-TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x561E9BC Offset: 0x561A9BC VA: 0x561E9BC
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B48C Offset: 0x561748C VA: 0x561B48C
	|-TextProcessingStack<Color32>.get_current
	|
	|-RVA: 0x561B9D8 Offset: 0x56179D8 VA: 0x561B9D8
	|-TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x561C0B0 Offset: 0x56180B0 VA: 0x561C0B0
	|-TextProcessingStack<int>.get_current
	|
	|-RVA: 0x561C604 Offset: 0x5618604 VA: 0x561C604
	|-TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x561CB80 Offset: 0x5618B80 VA: 0x561CB80
	|-TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x561D368 Offset: 0x5619368 VA: 0x561D368
	|-TextProcessingStack<object>.get_current
	|
	|-RVA: 0x561D8E4 Offset: 0x56198E4 VA: 0x561D8E4
	|-TextProcessingStack<float>.get_current
	|
	|-RVA: 0x561DE70 Offset: 0x5619E70 VA: 0x561DE70
	|-TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x561EA00 Offset: 0x561AA00 VA: 0x561EA00
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_current
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B4D8 Offset: 0x56174D8 VA: 0x561B4D8
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x561BA44 Offset: 0x5617A44 VA: 0x561BA44
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x561C104 Offset: 0x5618104 VA: 0x561C104
	|-TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x561C658 Offset: 0x5618658 VA: 0x561C658
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x561CBFC Offset: 0x5618BFC VA: 0x561CBFC
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x561D3BC Offset: 0x56193BC VA: 0x561D3BC
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x561D938 Offset: 0x5619938 VA: 0x561D938
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x561DEF4 Offset: 0x5619EF4 VA: 0x561DEF4
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x561EBE4 Offset: 0x561ABE4 VA: 0x561EBE4
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B564 Offset: 0x5617564 VA: 0x561B564
	|-TextProcessingStack<Color32>.Clear
	|
	|-RVA: 0x561BB08 Offset: 0x5617B08 VA: 0x561BB08
	|-TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x561C190 Offset: 0x5618190 VA: 0x561C190
	|-TextProcessingStack<int>.Clear
	|
	|-RVA: 0x561C6E4 Offset: 0x56186E4 VA: 0x561C6E4
	|-TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x561CCD8 Offset: 0x5618CD8 VA: 0x561CCD8
	|-TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x561D448 Offset: 0x5619448 VA: 0x561D448
	|-TextProcessingStack<object>.Clear
	|
	|-RVA: 0x561D9CC Offset: 0x56199CC VA: 0x561D9CC
	|-TextProcessingStack<float>.Clear
	|
	|-RVA: 0x561DFC4 Offset: 0x5619FC4 VA: 0x561DFC4
	|-TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x561EDB0 Offset: 0x561ADB0 VA: 0x561EDB0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B570 Offset: 0x5617570 VA: 0x561B570
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x561BB14 Offset: 0x5617B14 VA: 0x561BB14
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x561C19C Offset: 0x561819C VA: 0x561C19C
	|-TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x561C6F0 Offset: 0x56186F0 VA: 0x561C6F0
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x561CCE4 Offset: 0x5618CE4 VA: 0x561CCE4
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x561D454 Offset: 0x5619454 VA: 0x561D454
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x561D9D8 Offset: 0x56199D8 VA: 0x561D9D8
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x561DFD0 Offset: 0x5619FD0 VA: 0x561DFD0
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x561EE28 Offset: 0x561AE28 VA: 0x561EE28
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B604 Offset: 0x5617604 VA: 0x561B604
	|-TextProcessingStack<Color32>.Add
	|
	|-RVA: 0x561BBE4 Offset: 0x5617BE4 VA: 0x561BBE4
	|-TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x561C230 Offset: 0x5618230 VA: 0x561C230
	|-TextProcessingStack<int>.Add
	|
	|-RVA: 0x561C784 Offset: 0x5618784 VA: 0x561C784
	|-TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0x561CDDC Offset: 0x5618DDC VA: 0x561CDDC
	|-TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x561D4F0 Offset: 0x56194F0 VA: 0x561D4F0
	|-TextProcessingStack<object>.Add
	|
	|-RVA: 0x561DA6C Offset: 0x5619A6C VA: 0x561DA6C
	|-TextProcessingStack<float>.Add
	|
	|-RVA: 0x561E0B8 Offset: 0x561A0B8 VA: 0x561E0B8
	|-TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x561F110 Offset: 0x561B110 VA: 0x561F110
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B64C Offset: 0x561764C VA: 0x561B64C
	|-TextProcessingStack<Color32>.Remove
	|
	|-RVA: 0x561BC54 Offset: 0x5617C54 VA: 0x561BC54
	|-TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x561C278 Offset: 0x5618278 VA: 0x561C278
	|-TextProcessingStack<int>.Remove
	|
	|-RVA: 0x561C7CC Offset: 0x56187CC VA: 0x561C7CC
	|-TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0x561CE6C Offset: 0x5618E6C VA: 0x561CE6C
	|-TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x561D540 Offset: 0x5619540 VA: 0x561D540
	|-TextProcessingStack<object>.Remove
	|
	|-RVA: 0x561DAB0 Offset: 0x5619AB0 VA: 0x561DAB0
	|-TextProcessingStack<float>.Remove
	|
	|-RVA: 0x561E144 Offset: 0x561A144 VA: 0x561E144
	|-TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x561F39C Offset: 0x561B39C VA: 0x561F39C
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B6C0 Offset: 0x56176C0 VA: 0x561B6C0
	|-TextProcessingStack<Color32>.Push
	|
	|-RVA: 0x561BCE8 Offset: 0x5617CE8 VA: 0x561BCE8
	|-TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x561C2EC Offset: 0x56182EC VA: 0x561C2EC
	|-TextProcessingStack<int>.Push
	|
	|-RVA: 0x561C840 Offset: 0x5618840 VA: 0x561C840
	|-TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x561CF10 Offset: 0x5618F10 VA: 0x561CF10
	|-TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x561D5B4 Offset: 0x56195B4 VA: 0x561D5B4
	|-TextProcessingStack<object>.Push
	|
	|-RVA: 0x561DB24 Offset: 0x5619B24 VA: 0x561DB24
	|-TextProcessingStack<float>.Push
	|
	|-RVA: 0x561E1EC Offset: 0x561A1EC VA: 0x561E1EC
	|-TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x561F69C Offset: 0x561B69C VA: 0x561F69C
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B788 Offset: 0x5617788 VA: 0x561B788
	|-TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0x561BDE8 Offset: 0x5617DE8 VA: 0x561BDE8
	|-TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x561C3B4 Offset: 0x56183B4 VA: 0x561C3B4
	|-TextProcessingStack<int>.Pop
	|
	|-RVA: 0x561C908 Offset: 0x5618908 VA: 0x561C908
	|-TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x561D038 Offset: 0x5619038 VA: 0x561D038
	|-TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x561D684 Offset: 0x5619684 VA: 0x561D684
	|-TextProcessingStack<object>.Pop
	|
	|-RVA: 0x561DBF0 Offset: 0x5619BF0 VA: 0x561DBF0
	|-TextProcessingStack<float>.Pop
	|
	|-RVA: 0x561E304 Offset: 0x561A304 VA: 0x561E304
	|-TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x561FC40 Offset: 0x561BC40 VA: 0x561FC40
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B814 Offset: 0x5617814 VA: 0x561B814
	|-TextProcessingStack<Color32>.Peek
	|
	|-RVA: 0x561BEB4 Offset: 0x5617EB4 VA: 0x561BEB4
	|-TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x561C440 Offset: 0x5618440 VA: 0x561C440
	|-TextProcessingStack<int>.Peek
	|
	|-RVA: 0x561C994 Offset: 0x5618994 VA: 0x561C994
	|-TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0x561D14C Offset: 0x561914C VA: 0x561D14C
	|-TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x561D720 Offset: 0x5619720 VA: 0x561D720
	|-TextProcessingStack<object>.Peek
	|
	|-RVA: 0x561DC78 Offset: 0x5619C78 VA: 0x561DC78
	|-TextProcessingStack<float>.Peek
	|
	|-RVA: 0x561E404 Offset: 0x561A404 VA: 0x561E404
	|-TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x56201F4 Offset: 0x561C1F4 VA: 0x56201F4
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x561B85C Offset: 0x561785C VA: 0x561B85C
	|-TextProcessingStack<Color32>.CurrentItem
	|
	|-RVA: 0x561BF1C Offset: 0x5617F1C VA: 0x561BF1C
	|-TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x561C488 Offset: 0x5618488 VA: 0x561C488
	|-TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x561C9DC Offset: 0x56189DC VA: 0x561C9DC
	|-TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x561D1C0 Offset: 0x56191C0 VA: 0x561D1C0
	|-TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x561D768 Offset: 0x5619768 VA: 0x561D768
	|-TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x561DCC0 Offset: 0x5619CC0 VA: 0x561DCC0
	|-TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x561E47C Offset: 0x561A47C VA: 0x561E47C
	|-TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x56203D8 Offset: 0x561C3D8 VA: 0x56203D8
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.CurrentItem
	*/
}

// Namespace: 
private struct TextResourceManager.FontAssetRef // TypeDefIndex: 23453
{
	// Fields
	public int nameHashCode; // 0x0
	public int familyNameHashCode; // 0x4
	public int styleNameHashCode; // 0x8
	public long familyNameAndStyleHashCode; // 0x10
	public readonly FontAsset fontAsset; // 0x18

	// Methods

	// RVA: 0x881A228 Offset: 0x8816228 VA: 0x881A228
	public void .ctor(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset) { }
}

// Namespace: UnityEngine.TextCore.Text
internal class TextResourceManager // TypeDefIndex: 23454
{
	// Fields
	private static readonly Dictionary<int, TextResourceManager.FontAssetRef> s_FontAssetReferences; // 0x0
	private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup; // 0x8
	private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x10
	private static readonly List<int> s_FontAssetRemovalList; // 0x18
	private static readonly int k_RegularStyleHashCode; // 0x20

	// Methods

	// RVA: 0x8819CF4 Offset: 0x8815CF4 VA: 0x8819CF4
	internal static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x881A250 Offset: 0x8816250 VA: 0x881A250
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private struct TextSettings.FontReferenceMap // TypeDefIndex: 23455
{
	// Fields
	public Font font; // 0x0
	public FontAsset fontAsset; // 0x8

	// Methods

	// RVA: 0x881AE1C Offset: 0x8816E1C VA: 0x881AE1C
	public void .ctor(Font font, FontAsset fontAsset) { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[Serializable]
public class TextSettings : ScriptableObject // TypeDefIndex: 23456
{
	// Fields
	[SerializeField]
	protected string m_Version; // 0x18
	[SerializeField]
	[FormerlySerializedAs("m_defaultFontAsset")]
	protected FontAsset m_DefaultFontAsset; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	protected string m_DefaultFontAssetPath; // 0x28
	[SerializeField]
	[FormerlySerializedAs("m_fallbackFontAssets")]
	protected List<FontAsset> m_FallbackFontAssets; // 0x30
	[SerializeField]
	[FormerlySerializedAs("m_matchMaterialPreset")]
	protected bool m_MatchMaterialPreset; // 0x38
	[SerializeField]
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	protected int m_MissingCharacterUnicode; // 0x3C
	[SerializeField]
	protected bool m_ClearDynamicDataOnBuild; // 0x40
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	[SerializeField]
	protected SpriteAsset m_DefaultSpriteAsset; // 0x48
	[SerializeField]
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	protected string m_DefaultSpriteAssetPath; // 0x50
	[SerializeField]
	protected List<SpriteAsset> m_FallbackSpriteAssets; // 0x58
	[SerializeField]
	protected uint m_MissingSpriteCharacterUnicode; // 0x60
	[FormerlySerializedAs("m_defaultStyleSheet")]
	[SerializeField]
	protected TextStyleSheet m_DefaultStyleSheet; // 0x68
	[SerializeField]
	protected string m_StyleSheetsResourcePath; // 0x70
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	[SerializeField]
	protected string m_DefaultColorGradientPresetsPath; // 0x78
	[SerializeField]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x80
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0x88
	[SerializeField]
	[FormerlySerializedAs("m_warningsDisabled")]
	protected bool m_DisplayWarnings; // 0x89
	internal Dictionary<int, FontAsset> m_FontLookup; // 0x90
	private List<TextSettings.FontReferenceMap> m_FontReferences; // 0x98

	// Properties
	public string version { get; set; }
	public FontAsset defaultFontAsset { get; set; }
	public string defaultFontAssetPath { get; set; }
	public List<FontAsset> fallbackFontAssets { get; set; }
	public bool matchMaterialPreset { get; set; }
	public int missingCharacterUnicode { get; set; }
	public bool clearDynamicDataOnBuild { get; set; }
	public SpriteAsset defaultSpriteAsset { get; set; }
	public string defaultSpriteAssetPath { get; set; }
	public List<SpriteAsset> fallbackSpriteAssets { get; set; }
	public uint missingSpriteCharacterUnicode { get; set; }
	public TextStyleSheet defaultStyleSheet { get; set; }
	public string styleSheetsResourcePath { get; set; }
	public string defaultColorGradientPresetsPath { get; set; }
	public UnicodeLineBreakingRules lineBreakingRules { get; set; }
	public bool useModernHangulLineBreakingRules { get; set; }
	public bool displayWarnings { get; set; }

	// Methods

	// RVA: 0x881A490 Offset: 0x8816490 VA: 0x881A490
	public string get_version() { }

	// RVA: 0x881A498 Offset: 0x8816498 VA: 0x881A498
	internal void set_version(string value) { }

	// RVA: 0x881A4A0 Offset: 0x88164A0 VA: 0x881A4A0
	public FontAsset get_defaultFontAsset() { }

	// RVA: 0x881A4A8 Offset: 0x88164A8 VA: 0x881A4A8
	public void set_defaultFontAsset(FontAsset value) { }

	// RVA: 0x881A4B0 Offset: 0x88164B0 VA: 0x881A4B0
	public string get_defaultFontAssetPath() { }

	// RVA: 0x881A4B8 Offset: 0x88164B8 VA: 0x881A4B8
	public void set_defaultFontAssetPath(string value) { }

	// RVA: 0x881A4C0 Offset: 0x88164C0 VA: 0x881A4C0
	public List<FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x881A4C8 Offset: 0x88164C8 VA: 0x881A4C8
	public void set_fallbackFontAssets(List<FontAsset> value) { }

	// RVA: 0x881A4D0 Offset: 0x88164D0 VA: 0x881A4D0
	public bool get_matchMaterialPreset() { }

	// RVA: 0x881A4D8 Offset: 0x88164D8 VA: 0x881A4D8
	public void set_matchMaterialPreset(bool value) { }

	// RVA: 0x881A4E4 Offset: 0x88164E4 VA: 0x881A4E4
	public int get_missingCharacterUnicode() { }

	// RVA: 0x881A4EC Offset: 0x88164EC VA: 0x881A4EC
	public void set_missingCharacterUnicode(int value) { }

	// RVA: 0x881A4F4 Offset: 0x88164F4 VA: 0x881A4F4
	public bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x881A4FC Offset: 0x88164FC VA: 0x881A4FC
	public void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x881A508 Offset: 0x8816508 VA: 0x881A508
	public SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x881A510 Offset: 0x8816510 VA: 0x881A510
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	// RVA: 0x881A518 Offset: 0x8816518 VA: 0x881A518
	public string get_defaultSpriteAssetPath() { }

	// RVA: 0x881A520 Offset: 0x8816520 VA: 0x881A520
	public void set_defaultSpriteAssetPath(string value) { }

	// RVA: 0x881A528 Offset: 0x8816528 VA: 0x881A528
	public List<SpriteAsset> get_fallbackSpriteAssets() { }

	// RVA: 0x881A530 Offset: 0x8816530 VA: 0x881A530
	public void set_fallbackSpriteAssets(List<SpriteAsset> value) { }

	// RVA: 0x881A538 Offset: 0x8816538 VA: 0x881A538
	public uint get_missingSpriteCharacterUnicode() { }

	// RVA: 0x881A540 Offset: 0x8816540 VA: 0x881A540
	public void set_missingSpriteCharacterUnicode(uint value) { }

	// RVA: 0x881A548 Offset: 0x8816548 VA: 0x881A548
	public TextStyleSheet get_defaultStyleSheet() { }

	// RVA: 0x881A550 Offset: 0x8816550 VA: 0x881A550
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	// RVA: 0x881A558 Offset: 0x8816558 VA: 0x881A558
	public string get_styleSheetsResourcePath() { }

	// RVA: 0x881A560 Offset: 0x8816560 VA: 0x881A560
	public void set_styleSheetsResourcePath(string value) { }

	// RVA: 0x881A568 Offset: 0x8816568 VA: 0x881A568
	public string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x881A570 Offset: 0x8816570 VA: 0x881A570
	public void set_defaultColorGradientPresetsPath(string value) { }

	// RVA: 0x881A578 Offset: 0x8816578 VA: 0x881A578
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	// RVA: 0x881A824 Offset: 0x8816824 VA: 0x881A824
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	// RVA: 0x881A82C Offset: 0x881682C VA: 0x881A82C
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x881A834 Offset: 0x8816834 VA: 0x881A834
	public void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x881A840 Offset: 0x8816840 VA: 0x881A840
	public bool get_displayWarnings() { }

	// RVA: 0x881A848 Offset: 0x8816848 VA: 0x881A848
	public void set_displayWarnings(bool value) { }

	// RVA: 0x881A854 Offset: 0x8816854 VA: 0x881A854
	private void OnEnable() { }

	// RVA: 0x881A86C Offset: 0x881686C VA: 0x881A86C
	protected void InitializeFontReferenceLookup() { }

	// RVA: 0x881AAB0 Offset: 0x8816AB0 VA: 0x881AAB0
	protected FontAsset GetCachedFontAssetInternal(Font font) { }

	// RVA: 0x881AE4C Offset: 0x8816E4C VA: 0x881AE4C
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromDocs]
public static class TextShaderUtilities // TypeDefIndex: 23457
{
	// Fields
	public static int ID_MainTex; // 0x0
	public static int ID_FaceTex; // 0x4
	public static int ID_FaceColor; // 0x8
	public static int ID_FaceDilate; // 0xC
	public static int ID_Shininess; // 0x10
	public static int ID_OutlineOffset1; // 0x14
	public static int ID_OutlineOffset2; // 0x18
	public static int ID_OutlineOffset3; // 0x1C
	public static int ID_OutlineMode; // 0x20
	public static int ID_IsoPerimeter; // 0x24
	public static int ID_Softness; // 0x28
	public static int ID_UnderlayColor; // 0x2C
	public static int ID_UnderlayOffsetX; // 0x30
	public static int ID_UnderlayOffsetY; // 0x34
	public static int ID_UnderlayDilate; // 0x38
	public static int ID_UnderlaySoftness; // 0x3C
	public static int ID_UnderlayOffset; // 0x40
	public static int ID_UnderlayIsoPerimeter; // 0x44
	public static int ID_WeightNormal; // 0x48
	public static int ID_WeightBold; // 0x4C
	public static int ID_OutlineTex; // 0x50
	public static int ID_OutlineWidth; // 0x54
	public static int ID_OutlineSoftness; // 0x58
	public static int ID_OutlineColor; // 0x5C
	public static int ID_Outline2Color; // 0x60
	public static int ID_Outline2Width; // 0x64
	public static int ID_Padding; // 0x68
	public static int ID_GradientScale; // 0x6C
	public static int ID_ScaleX; // 0x70
	public static int ID_ScaleY; // 0x74
	public static int ID_PerspectiveFilter; // 0x78
	public static int ID_Sharpness; // 0x7C
	public static int ID_TextureWidth; // 0x80
	public static int ID_TextureHeight; // 0x84
	public static int ID_BevelAmount; // 0x88
	public static int ID_GlowColor; // 0x8C
	public static int ID_GlowOffset; // 0x90
	public static int ID_GlowPower; // 0x94
	public static int ID_GlowOuter; // 0x98
	public static int ID_GlowInner; // 0x9C
	public static int ID_LightAngle; // 0xA0
	public static int ID_EnvMap; // 0xA4
	public static int ID_EnvMatrix; // 0xA8
	public static int ID_EnvMatrixRotation; // 0xAC
	public static int ID_MaskCoord; // 0xB0
	public static int ID_ClipRect; // 0xB4
	public static int ID_MaskSoftnessX; // 0xB8
	public static int ID_MaskSoftnessY; // 0xBC
	public static int ID_VertexOffsetX; // 0xC0
	public static int ID_VertexOffsetY; // 0xC4
	public static int ID_UseClipRect; // 0xC8
	public static int ID_StencilID; // 0xCC
	public static int ID_StencilOp; // 0xD0
	public static int ID_StencilComp; // 0xD4
	public static int ID_StencilReadMask; // 0xD8
	public static int ID_StencilWriteMask; // 0xDC
	public static int ID_ShaderFlags; // 0xE0
	public static int ID_ScaleRatio_A; // 0xE4
	public static int ID_ScaleRatio_B; // 0xE8
	public static int ID_ScaleRatio_C; // 0xEC
	public static string Keyword_Bevel; // 0xF0
	public static string Keyword_Glow; // 0xF8
	public static string Keyword_Underlay; // 0x100
	public static string Keyword_Ratios; // 0x108
	public static string Keyword_MASK_SOFT; // 0x110
	public static string Keyword_MASK_HARD; // 0x118
	public static string Keyword_MASK_TEX; // 0x120
	public static string Keyword_Outline; // 0x128
	public static string ShaderTag_ZTestMode; // 0x130
	public static string ShaderTag_CullMode; // 0x138
	private static float m_clamp; // 0x140
	public static bool isInitialized; // 0x144
	private static Shader k_ShaderRef_MobileSDF; // 0x148
	private static Shader k_ShaderRef_MobileBitmap; // 0x150

	// Properties
	internal static Shader ShaderRef_MobileSDF { get; }
	internal static Shader ShaderRef_MobileBitmap { get; }

	// Methods

	// RVA: 0x881AF80 Offset: 0x8816F80 VA: 0x881AF80
	internal static Shader get_ShaderRef_MobileSDF() { }

	// RVA: 0x881B194 Offset: 0x8817194 VA: 0x881B194
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x881B3A8 Offset: 0x88173A8 VA: 0x881B3A8
	private static void .cctor() { }

	// RVA: 0x881B5C8 Offset: 0x88175C8 VA: 0x881B5C8
	internal static void GetShaderPropertyIDs() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class TextStyle // TypeDefIndex: 23458
{
	// Fields
	internal static TextStyle k_NormalStyle; // 0x0
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private int m_HashCode; // 0x18
	[SerializeField]
	private string m_OpeningDefinition; // 0x20
	[SerializeField]
	private string m_ClosingDefinition; // 0x28
	[SerializeField]
	private uint[] m_OpeningTagArray; // 0x30
	[SerializeField]
	private uint[] m_ClosingTagArray; // 0x38
	[SerializeField]
	internal uint[] m_OpeningTagUnicodeArray; // 0x40
	[SerializeField]
	internal uint[] m_ClosingTagUnicodeArray; // 0x48

	// Properties
	public int hashCode { get; }
	public uint[] styleOpeningTagArray { get; }
	public uint[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x88149D8 Offset: 0x88109D8 VA: 0x88149D8
	public int get_hashCode() { }

	// RVA: 0x88149E0 Offset: 0x88109E0 VA: 0x88149E0
	public uint[] get_styleOpeningTagArray() { }

	// RVA: 0x8814F74 Offset: 0x8810F74 VA: 0x8814F74
	public uint[] get_styleClosingTagArray() { }

	// RVA: 0x881C090 Offset: 0x8818090 VA: 0x881C090
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x881C104 Offset: 0x8818104 VA: 0x881C104
	public void RefreshStyle() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[Serializable]
public class TextStyleSheet : ScriptableObject // TypeDefIndex: 23459
{
	// Fields
	[SerializeField]
	private List<TextStyle> m_StyleList; // 0x18
	private Dictionary<int, TextStyle> m_StyleLookupDictionary; // 0x20

	// Properties
	internal List<TextStyle> styles { get; }

	// Methods

	// RVA: 0x881C2E8 Offset: 0x88182E8 VA: 0x881C2E8
	internal List<TextStyle> get_styles() { }

	// RVA: 0x881C2F0 Offset: 0x88182F0 VA: 0x881C2F0
	private void Reset() { }

	// RVA: 0x8815B3C Offset: 0x8811B3C VA: 0x8815B3C
	public TextStyle GetStyle(int hashCode) { }

	// RVA: 0x881C5EC Offset: 0x88185EC VA: 0x881C5EC
	public TextStyle GetStyle(string name) { }

	// RVA: 0x881C680 Offset: 0x8818680 VA: 0x881C680
	public void RefreshStyles() { }

	// RVA: 0x881C2F4 Offset: 0x88182F4 VA: 0x881C2F4
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x881C684 Offset: 0x8818684 VA: 0x881C684
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Extension]
internal static class TextUtilities // TypeDefIndex: 23460
{
	// Methods

	// RVA: 0x881C710 Offset: 0x8818710 VA: 0x881C710
	internal static char ToUpperFast(char c) { }

	// RVA: 0x881A420 Offset: 0x8816420 VA: 0x881A420
	public static int GetHashCodeCaseInSensitive(string s) { }

	[Extension]
	// RVA: 0x881C784 Offset: 0x8818784 VA: 0x881C784
	internal static string UintToString(List<uint> unicodes) { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class UnicodeLineBreakingRules // TypeDefIndex: 23461
{
	// Fields
	[SerializeField]
	private TextAsset m_UnicodeLineBreakingRules; // 0x10
	[SerializeField]
	private TextAsset m_LeadingCharacters; // 0x18
	[SerializeField]
	private TextAsset m_FollowingCharacters; // 0x20
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0x28
	private HashSet<uint> m_LeadingCharactersLookup; // 0x30
	private HashSet<uint> m_FollowingCharactersLookup; // 0x38

	// Properties
	public TextAsset leadingCharacters { get; }
	public TextAsset followingCharacters { get; }
	internal HashSet<uint> leadingCharactersLookup { get; }
	internal HashSet<uint> followingCharactersLookup { get; }
	public bool useModernHangulLineBreakingRules { get; }

	// Methods

	// RVA: 0x881C85C Offset: 0x881885C VA: 0x881C85C
	public TextAsset get_leadingCharacters() { }

	// RVA: 0x881C864 Offset: 0x8818864 VA: 0x881C864
	public TextAsset get_followingCharacters() { }

	// RVA: 0x881C86C Offset: 0x881886C VA: 0x881C86C
	internal HashSet<uint> get_leadingCharactersLookup() { }

	// RVA: 0x881CA90 Offset: 0x8818A90 VA: 0x881CA90
	internal HashSet<uint> get_followingCharactersLookup() { }

	// RVA: 0x881CAB8 Offset: 0x8818AB8 VA: 0x881CAB8
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x881A600 Offset: 0x8816600 VA: 0x881A600
	internal void LoadLineBreakingRules() { }

	// RVA: 0x881C894 Offset: 0x8818894 VA: 0x881C894
	internal void LoadLineBreakingRules(TextAsset leadingRules, TextAsset followingRules) { }

	// RVA: 0x881CAC0 Offset: 0x8818AC0 VA: 0x881CAC0
	private static HashSet<uint> GetCharacters(TextAsset file) { }

	// RVA: 0x881A5F8 Offset: 0x88165F8 VA: 0x881A5F8
	public void .ctor() { }
}

