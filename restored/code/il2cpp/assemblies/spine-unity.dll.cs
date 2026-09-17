// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 24086
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 24087
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 24088
{
	// Methods

	// RVA: 0x7F51E1C Offset: 0x7F4DE1C VA: 0x7F51E1C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x7F51F14 Offset: 0x7F4DF14 VA: 0x7F51F14
	public void .ctor() { }
}

// Namespace: Spine
public struct BoneMatrix // TypeDefIndex: 24089
{
	// Fields
	public float a; // 0x0
	public float b; // 0x4
	public float c; // 0x8
	public float d; // 0xC
	public float x; // 0x10
	public float y; // 0x14

	// Methods

	// RVA: 0x7F51F1C Offset: 0x7F4DF1C VA: 0x7F51F1C
	public static BoneMatrix CalculateSetupWorld(BoneData boneData) { }

	// RVA: 0x7F51FA8 Offset: 0x7F4DFA8 VA: 0x7F51FA8
	private static BoneMatrix GetInheritedInternal(BoneData boneData, BoneMatrix parentMatrix) { }

	// RVA: 0x7F525D4 Offset: 0x7F4E5D4 VA: 0x7F525D4
	public void .ctor(BoneData boneData) { }

	// RVA: 0x7F526BC Offset: 0x7F4E6BC VA: 0x7F526BC
	public void .ctor(Bone bone) { }

	// RVA: 0x7F527A4 Offset: 0x7F4E7A4 VA: 0x7F527A4
	public BoneMatrix TransformMatrix(BoneMatrix local) { }
}

// Namespace: Spine
[Extension]
public static class SpineSkeletonExtensions // TypeDefIndex: 24090
{
	// Methods

	[Extension]
	// RVA: 0x7F527FC Offset: 0x7F4E7FC VA: 0x7F527FC
	public static bool IsWeighted(VertexAttachment va) { }

	[Extension]
	// RVA: 0x7F5282C Offset: 0x7F4E82C VA: 0x7F5282C
	public static bool InheritsRotation(TransformMode mode) { }

	[Extension]
	// RVA: 0x7F52838 Offset: 0x7F4E838 VA: 0x7F52838
	public static bool InheritsScale(TransformMode mode) { }
}

// Namespace: Spine.Unity
[CreateAssetMenu(menuName = "Spine/Animation Reference Asset", order = 100)]
public class AnimationReferenceAsset : ScriptableObject, IHasSkeletonDataAsset, ISpineComponent // TypeDefIndex: 24091
{
	// Fields
	private const bool QuietSkeletonData = True;
	[SerializeField]
	protected SkeletonDataAsset skeletonDataAsset; // 0x18
	[SerializeField]
	[SpineAnimation("", "", True, False)]
	protected string animationName; // 0x20
	private Animation animation; // 0x28

	// Properties
	public SkeletonDataAsset SkeletonDataAsset { get; }
	public Animation Animation { get; }

	// Methods

	// RVA: 0x7F52844 Offset: 0x7F4E844 VA: 0x7F52844 Slot: 4
	public SkeletonDataAsset get_SkeletonDataAsset() { }

	// RVA: 0x7F5284C Offset: 0x7F4E84C VA: 0x7F5284C
	public Animation get_Animation() { }

	// RVA: 0x7F52A24 Offset: 0x7F4EA24 VA: 0x7F52A24
	public void Clear() { }

	// RVA: 0x7F52870 Offset: 0x7F4E870 VA: 0x7F52870
	public void Initialize() { }

	// RVA: 0x7F53028 Offset: 0x7F4F028 VA: 0x7F53028
	public static Animation op_Implicit(AnimationReferenceAsset asset) { }

	// RVA: 0x7F53054 Offset: 0x7F4F054 VA: 0x7F53054
	public void .ctor() { }
}

// Namespace: 
public enum AtlasAssetBase.LoadingMode // TypeDefIndex: 24092
{
	// Fields
	public int value__; // 0x0
	public const AtlasAssetBase.LoadingMode Normal = 0;
	public const AtlasAssetBase.LoadingMode OnDemand = 1;
}

// Namespace: Spine.Unity
public abstract class AtlasAssetBase : ScriptableObject // TypeDefIndex: 24093
{
	// Fields
	[SerializeField]
	protected AtlasAssetBase.LoadingMode textureLoadingMode; // 0x18
	[SerializeField]
	protected OnDemandTextureLoader onDemandTextureLoader; // 0x20

	// Properties
	public abstract Material PrimaryMaterial { get; }
	public abstract IEnumerable<Material> Materials { get; }
	public abstract int MaterialCount { get; }
	public abstract bool IsLoaded { get; }
	public virtual AtlasAssetBase.LoadingMode TextureLoadingMode { get; set; }
	public OnDemandTextureLoader OnDemandTextureLoader { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Material get_PrimaryMaterial();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IEnumerable<Material> get_Materials();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_MaterialCount();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsLoaded();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Atlas GetAtlas(bool onlyMetaData = False);

	// RVA: 0x7F5305C Offset: 0x7F4F05C VA: 0x7F5305C Slot: 10
	public virtual AtlasAssetBase.LoadingMode get_TextureLoadingMode() { }

	// RVA: 0x7F53064 Offset: 0x7F4F064 VA: 0x7F53064 Slot: 11
	public virtual void set_TextureLoadingMode(AtlasAssetBase.LoadingMode value) { }

	// RVA: 0x7F5306C Offset: 0x7F4F06C VA: 0x7F5306C
	public OnDemandTextureLoader get_OnDemandTextureLoader() { }

	// RVA: 0x7F53074 Offset: 0x7F4F074 VA: 0x7F53074
	public void set_OnDemandTextureLoader(OnDemandTextureLoader value) { }

	// RVA: 0x7F5307C Offset: 0x7F4F07C VA: 0x7F5307C Slot: 12
	public virtual void BeginCustomTextureLoading() { }

	// RVA: 0x7F53100 Offset: 0x7F4F100 VA: 0x7F53100 Slot: 13
	public virtual void EndCustomTextureLoading() { }

	// RVA: 0x7F53184 Offset: 0x7F4F184 VA: 0x7F53184 Slot: 14
	public virtual void RequireTexturesLoaded(Material material, ref Material overrideMaterial) { }

	// RVA: 0x7F53224 Offset: 0x7F4F224 VA: 0x7F53224
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
public class BlendModeMaterials.ReplacementMaterial // TypeDefIndex: 24094
{
	// Fields
	public string pageName; // 0x10
	public Material material; // 0x18

	// Methods

	// RVA: 0x7F54004 Offset: 0x7F50004 VA: 0x7F54004
	public void .ctor() { }
}

// Namespace: Spine.Unity
[Serializable]
public class BlendModeMaterials // TypeDefIndex: 24095
{
	// Fields
	[SerializeField]
	[HideInInspector]
	protected bool requiresBlendModeMaterials; // 0x10
	public bool applyAdditiveMaterial; // 0x11
	public List<BlendModeMaterials.ReplacementMaterial> additiveMaterials; // 0x18
	public List<BlendModeMaterials.ReplacementMaterial> multiplyMaterials; // 0x20
	public List<BlendModeMaterials.ReplacementMaterial> screenMaterials; // 0x28

	// Properties
	public bool RequiresBlendModeMaterials { get; set; }

	// Methods

	// RVA: 0x7F5322C Offset: 0x7F4F22C VA: 0x7F5322C
	public bool get_RequiresBlendModeMaterials() { }

	// RVA: 0x7F53234 Offset: 0x7F4F234 VA: 0x7F53234
	public void set_RequiresBlendModeMaterials(bool value) { }

	// RVA: 0x7F53240 Offset: 0x7F4F240 VA: 0x7F53240
	public BlendMode BlendModeForMaterial(Material material) { }

	// RVA: 0x7F535A8 Offset: 0x7F4F5A8 VA: 0x7F535A8
	public void ApplyMaterials(SkeletonData skeletonData) { }

	// RVA: 0x7F53D50 Offset: 0x7F4FD50 VA: 0x7F53D50
	protected AtlasRegion CloneAtlasRegionWithMaterial(AtlasRegion originalRegion, List<BlendModeMaterials.ReplacementMaterial> replacementMaterials) { }

	// RVA: 0x7F53F34 Offset: 0x7F4FF34 VA: 0x7F53F34
	public void .ctor() { }
}

// Namespace: Spine.Unity
[CreateAssetMenu(menuName = "Spine/EventData Reference Asset", order = 100)]
public class EventDataReferenceAsset : ScriptableObject // TypeDefIndex: 24096
{
	// Fields
	private const bool QuietSkeletonData = True;
	[SerializeField]
	protected SkeletonDataAsset skeletonDataAsset; // 0x18
	[SpineEvent("", "skeletonDataAsset", True, False, False)]
	[SerializeField]
	protected string eventName; // 0x20
	private EventData eventData; // 0x28

	// Properties
	public EventData EventData { get; }

	// Methods

	// RVA: 0x7F5400C Offset: 0x7F5000C VA: 0x7F5400C
	public EventData get_EventData() { }

	// RVA: 0x7F54030 Offset: 0x7F50030 VA: 0x7F54030
	public void Initialize() { }

	// RVA: 0x7F541DC Offset: 0x7F501DC VA: 0x7F541DC
	public static EventData op_Implicit(EventDataReferenceAsset asset) { }

	// RVA: 0x7F54208 Offset: 0x7F50208 VA: 0x7F54208
	public void .ctor() { }
}

// Namespace: 
public sealed class OnDemandTextureLoader.TextureLoadDelegate : MulticastDelegate // TypeDefIndex: 24097
{
	// Methods

	// RVA: 0x7F544F0 Offset: 0x7F504F0 VA: 0x7F544F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F545FC Offset: 0x7F505FC VA: 0x7F545FC Slot: 13
	public virtual void Invoke(OnDemandTextureLoader loader, Material material, int textureIndex) { }

	// RVA: 0x7F54610 Offset: 0x7F50610 VA: 0x7F54610 Slot: 14
	public virtual IAsyncResult BeginInvoke(OnDemandTextureLoader loader, Material material, int textureIndex, AsyncCallback callback, object object) { }

	// RVA: 0x7F546A8 Offset: 0x7F506A8 VA: 0x7F546A8 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Spine.Unity
public abstract class OnDemandTextureLoader : ScriptableObject // TypeDefIndex: 24098
{
	// Fields
	public AtlasAssetBase atlasAsset; // 0x18
	[CompilerGenerated]
	private OnDemandTextureLoader.TextureLoadDelegate onTextureLoaded; // 0x20
	[CompilerGenerated]
	private OnDemandTextureLoader.TextureLoadDelegate onTextureUnloaded; // 0x28

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetPlaceholderTextureName(string originalTextureName);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool AssignPlaceholderTextures(out IEnumerable<Material> modifiedMaterials);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool HasPlaceholderTexturesAssigned(out List<Material> placeholderMaterials);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool AssignTargetTextures(out IEnumerable<Material> modifiedMaterials);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void BeginCustomTextureLoading();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void EndCustomTextureLoading();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool HasPlaceholderAssigned(Material material);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void RequestLoadMaterialTextures(Material material, ref Material overrideMaterial);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Clear(bool clearAtlasAsset = False);

	[CompilerGenerated]
	// RVA: 0x7F54210 Offset: 0x7F50210 VA: 0x7F54210
	protected void add_onTextureLoaded(OnDemandTextureLoader.TextureLoadDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F542AC Offset: 0x7F502AC VA: 0x7F542AC
	protected void remove_onTextureLoaded(OnDemandTextureLoader.TextureLoadDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F54348 Offset: 0x7F50348 VA: 0x7F54348
	protected void add_onTextureUnloaded(OnDemandTextureLoader.TextureLoadDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F543E4 Offset: 0x7F503E4 VA: 0x7F543E4
	protected void remove_onTextureUnloaded(OnDemandTextureLoader.TextureLoadDelegate value) { }

	// RVA: 0x7F54480 Offset: 0x7F50480 VA: 0x7F54480
	public void add_TextureLoaded(OnDemandTextureLoader.TextureLoadDelegate value) { }

	// RVA: 0x7F54484 Offset: 0x7F50484 VA: 0x7F54484
	public void remove_TextureLoaded(OnDemandTextureLoader.TextureLoadDelegate value) { }

	// RVA: 0x7F54488 Offset: 0x7F50488 VA: 0x7F54488
	public void add_TextureUnloaded(OnDemandTextureLoader.TextureLoadDelegate value) { }

	// RVA: 0x7F5448C Offset: 0x7F5048C VA: 0x7F5448C
	public void remove_TextureUnloaded(OnDemandTextureLoader.TextureLoadDelegate value) { }

	// RVA: 0x7F54490 Offset: 0x7F50490 VA: 0x7F54490
	protected void OnTextureLoaded(Material material, int textureIndex) { }

	// RVA: 0x7F544BC Offset: 0x7F504BC VA: 0x7F544BC
	protected void OnTextureUnloaded(Material material, int textureIndex) { }

	// RVA: 0x7F544E8 Offset: 0x7F504E8 VA: 0x7F544E8
	protected void .ctor() { }
}

// Namespace: Spine.Unity
public class RegionlessAttachmentLoader : AttachmentLoader // TypeDefIndex: 24099
{
	// Fields
	private static AtlasRegion emptyRegion; // 0x0

	// Properties
	private static AtlasRegion EmptyRegion { get; }

	// Methods

	// RVA: 0x7F546B4 Offset: 0x7F506B4 VA: 0x7F546B4
	private static AtlasRegion get_EmptyRegion() { }

	// RVA: 0x7F54870 Offset: 0x7F50870 VA: 0x7F54870 Slot: 4
	public RegionAttachment NewRegionAttachment(Skin skin, string name, string path, Sequence sequence) { }

	// RVA: 0x7F548E8 Offset: 0x7F508E8 VA: 0x7F548E8 Slot: 5
	public MeshAttachment NewMeshAttachment(Skin skin, string name, string path, Sequence sequence) { }

	// RVA: 0x7F54960 Offset: 0x7F50960 VA: 0x7F54960 Slot: 6
	public BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name) { }

	// RVA: 0x7F549BC Offset: 0x7F509BC VA: 0x7F549BC Slot: 7
	public PathAttachment NewPathAttachment(Skin skin, string name) { }

	// RVA: 0x7F54A18 Offset: 0x7F50A18 VA: 0x7F54A18 Slot: 8
	public PointAttachment NewPointAttachment(Skin skin, string name) { }

	// RVA: 0x7F54A74 Offset: 0x7F50A74 VA: 0x7F54A74 Slot: 9
	public ClippingAttachment NewClippingAttachment(Skin skin, string name) { }

	// RVA: 0x7F54AD0 Offset: 0x7F50AD0 VA: 0x7F54AD0
	public void .ctor() { }
}

// Namespace: Spine.Unity
[CreateAssetMenu(fileName = "New SkeletonDataAsset", menuName = "Spine/SkeletonData Asset")]
public class SkeletonDataAsset : ScriptableObject // TypeDefIndex: 24100
{
	// Fields
	public AtlasAssetBase[] atlasAssets; // 0x18
	public float scale; // 0x20
	public TextAsset skeletonJSON; // 0x28
	public bool isUpgradingBlendModeMaterials; // 0x30
	public BlendModeMaterials blendModeMaterials; // 0x38
	[Tooltip("Use SkeletonDataModifierAssets to apply changes to the SkeletonData after being loaded, such as apply blend mode Materials to Attachments under slots with special blend modes.")]
	public List<SkeletonDataModifierAsset> skeletonDataModifiers; // 0x40
	[SpineAnimation("", "", False, False)]
	public string[] fromAnimation; // 0x48
	[SpineAnimation("", "", False, False)]
	public string[] toAnimation; // 0x50
	public float[] duration; // 0x58
	public float defaultMix; // 0x60
	public RuntimeAnimatorController controller; // 0x68
	private SkeletonData skeletonData; // 0x70
	private AnimationStateData stateData; // 0x78

	// Properties
	public bool IsLoaded { get; }

	// Methods

	// RVA: 0x7F54AD8 Offset: 0x7F50AD8 VA: 0x7F54AD8
	public bool get_IsLoaded() { }

	// RVA: 0x7F54AE8 Offset: 0x7F50AE8 VA: 0x7F54AE8
	private void Reset() { }

	// RVA: 0x7F54B38 Offset: 0x7F50B38 VA: 0x7F54B38
	public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAssetBase atlasAsset, bool initialize, float scale = 0.01) { }

	// RVA: 0x7F54BFC Offset: 0x7F50BFC VA: 0x7F54BFC
	public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAssetBase[] atlasAssets, bool initialize, float scale = 0.01) { }

	// RVA: 0x7F54B10 Offset: 0x7F50B10 VA: 0x7F54B10
	public void Clear() { }

	// RVA: 0x7F54CC4 Offset: 0x7F50CC4 VA: 0x7F54CC4
	public AnimationStateData GetAnimationStateData() { }

	// RVA: 0x7F52A30 Offset: 0x7F4EA30 VA: 0x7F52A30
	public SkeletonData GetSkeletonData(bool quiet) { }

	// RVA: 0x7F5514C Offset: 0x7F5114C VA: 0x7F5514C
	internal void InitializeWithData(SkeletonData sd) { }

	// RVA: 0x7F551E0 Offset: 0x7F511E0 VA: 0x7F551E0
	public void FillStateData(bool quiet = False) { }

	// RVA: 0x7F54CEC Offset: 0x7F50CEC VA: 0x7F54CEC
	internal Atlas[] GetAtlasArray() { }

	// RVA: 0x7F54E90 Offset: 0x7F50E90 VA: 0x7F54E90
	internal static SkeletonData ReadSkeletonData(byte[] bytes, AttachmentLoader attachmentLoader, float scale) { }

	// RVA: 0x7F5508C Offset: 0x7F5108C VA: 0x7F5508C
	internal static SkeletonData ReadSkeletonData(string text, AttachmentLoader attachmentLoader, float scale) { }

	// RVA: 0x7F552B4 Offset: 0x7F512B4 VA: 0x7F552B4
	public void .ctor() { }
}

// Namespace: 
public enum SkeletonDataCompatibility.SourceType // TypeDefIndex: 24101
{
	// Fields
	public int value__; // 0x0
	public const SkeletonDataCompatibility.SourceType Json = 0;
	public const SkeletonDataCompatibility.SourceType Binary = 1;
}

// Namespace: 
[Serializable]
public class SkeletonDataCompatibility.VersionInfo // TypeDefIndex: 24102
{
	// Fields
	public string rawVersion; // 0x10
	public int[] version; // 0x18
	public SkeletonDataCompatibility.SourceType sourceType; // 0x20

	// Methods

	// RVA: 0x7F55438 Offset: 0x7F51438 VA: 0x7F55438
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class SkeletonDataCompatibility.CompatibilityProblemInfo // TypeDefIndex: 24103
{
	// Fields
	public SkeletonDataCompatibility.VersionInfo actualVersion; // 0x10
	public int[][] compatibleVersions; // 0x18
	public string explicitProblemDescription; // 0x20

	// Methods

	// RVA: 0x7F55440 Offset: 0x7F51440 VA: 0x7F55440
	public string DescriptionString() { }

	// RVA: 0x7F55750 Offset: 0x7F51750 VA: 0x7F55750
	public void .ctor() { }
}

// Namespace: Spine.Unity
public static class SkeletonDataCompatibility // TypeDefIndex: 24104
{}

// Namespace: Spine.Unity
public abstract class SkeletonDataModifierAsset : ScriptableObject // TypeDefIndex: 24105
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Apply(SkeletonData skeletonData);

	// RVA: 0x7F55758 Offset: 0x7F51758 VA: 0x7F55758
	protected void .ctor() { }
}

// Namespace: Spine.Unity
[CreateAssetMenu(fileName = "New Spine Atlas Asset", menuName = "Spine/Spine Atlas Asset")]
public class SpineAtlasAsset : AtlasAssetBase // TypeDefIndex: 24106
{
	// Fields
	public TextAsset atlasFile; // 0x28
	public Material[] materials; // 0x30
	public TextureLoader customTextureLoader; // 0x38
	protected Atlas atlas; // 0x40

	// Properties
	public override bool IsLoaded { get; }
	public override IEnumerable<Material> Materials { get; }
	public override int MaterialCount { get; }
	public override Material PrimaryMaterial { get; }

	// Methods

	// RVA: 0x7F55760 Offset: 0x7F51760 VA: 0x7F55760 Slot: 7
	public override bool get_IsLoaded() { }

	// RVA: 0x7F55770 Offset: 0x7F51770 VA: 0x7F55770 Slot: 5
	public override IEnumerable<Material> get_Materials() { }

	// RVA: 0x7F55778 Offset: 0x7F51778 VA: 0x7F55778 Slot: 6
	public override int get_MaterialCount() { }

	// RVA: 0x7F55790 Offset: 0x7F51790 VA: 0x7F55790 Slot: 4
	public override Material get_PrimaryMaterial() { }

	// RVA: 0x7F557B8 Offset: 0x7F517B8 VA: 0x7F557B8
	public static SpineAtlasAsset CreateRuntimeInstance(TextAsset atlasText, Material[] materials, bool initialize, Func<SpineAtlasAsset, TextureLoader> newCustomTextureLoader) { }

	// RVA: 0x7F558A4 Offset: 0x7F518A4 VA: 0x7F558A4
	public static SpineAtlasAsset CreateRuntimeInstance(TextAsset atlasText, Texture2D[] textures, Material materialPropertySource, bool initialize, Func<SpineAtlasAsset, TextureLoader> newCustomTextureLoader) { }

	// RVA: 0x7F55CBC Offset: 0x7F51CBC VA: 0x7F55CBC
	public static SpineAtlasAsset CreateRuntimeInstance(TextAsset atlasText, Texture2D[] textures, Shader shader, bool initialize, Func<SpineAtlasAsset, TextureLoader> newCustomTextureLoader) { }

	// RVA: 0x7F55898 Offset: 0x7F51898 VA: 0x7F55898
	private void Reset() { }

	// RVA: 0x7F55DA4 Offset: 0x7F51DA4 VA: 0x7F55DA4 Slot: 8
	public override void Clear() { }

	// RVA: 0x7F55DB0 Offset: 0x7F51DB0 VA: 0x7F55DB0 Slot: 9
	public override Atlas GetAtlas(bool onlyMetaData = False) { }

	// RVA: 0x7F56248 Offset: 0x7F52248 VA: 0x7F56248
	public Mesh GenerateMesh(string name, Mesh mesh, out Material material, float scale = 0.01) { }

	// RVA: 0x7F56658 Offset: 0x7F52658 VA: 0x7F56658
	public void .ctor() { }
}

// Namespace: Spine.Unity
public class NoOpTextureLoader : TextureLoader // TypeDefIndex: 24107
{
	// Methods

	// RVA: 0x7F56660 Offset: 0x7F52660 VA: 0x7F56660 Slot: 4
	public void Load(AtlasPage page, string path) { }

	// RVA: 0x7F56664 Offset: 0x7F52664 VA: 0x7F56664 Slot: 5
	public void Unload(object texture) { }

	// RVA: 0x7F56240 Offset: 0x7F52240 VA: 0x7F56240
	public void .ctor() { }
}

// Namespace: Spine.Unity
public class MaterialsTextureLoader : TextureLoader // TypeDefIndex: 24108
{
	// Fields
	private SpineAtlasAsset atlasAsset; // 0x10

	// Methods

	// RVA: 0x7F56210 Offset: 0x7F52210 VA: 0x7F56210
	public void .ctor(SpineAtlasAsset atlasAsset) { }

	// RVA: 0x7F56668 Offset: 0x7F52668 VA: 0x7F56668 Slot: 4
	public void Load(AtlasPage page, string path) { }

	// RVA: 0x7F569AC Offset: 0x7F529AC VA: 0x7F569AC Slot: 5
	public void Unload(object texture) { }
}

// Namespace: 
[Serializable]
protected class SpineSpriteAtlasAsset.SavedRegionInfo // TypeDefIndex: 24109
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float width; // 0x18
	public float height; // 0x1C
	public SpritePackingRotation packingRotation; // 0x20

	// Methods

	// RVA: 0x7F5773C Offset: 0x7F5373C VA: 0x7F5773C
	public void .ctor() { }
}

// Namespace: Spine.Unity
[CreateAssetMenu(fileName = "New Spine SpriteAtlas Asset", menuName = "Spine/Spine SpriteAtlas Asset")]
public class SpineSpriteAtlasAsset : AtlasAssetBase // TypeDefIndex: 24110
{
	// Fields
	public SpriteAtlas spriteAtlasFile; // 0x28
	public Material[] materials; // 0x30
	protected Atlas atlas; // 0x38
	public bool updateRegionsInPlayMode; // 0x40
	[SerializeField]
	protected SpineSpriteAtlasAsset.SavedRegionInfo[] savedRegions; // 0x48

	// Properties
	public override bool IsLoaded { get; }
	public override IEnumerable<Material> Materials { get; }
	public override int MaterialCount { get; }
	public override Material PrimaryMaterial { get; }

	// Methods

	// RVA: 0x7F569B0 Offset: 0x7F529B0 VA: 0x7F569B0 Slot: 7
	public override bool get_IsLoaded() { }

	// RVA: 0x7F569C0 Offset: 0x7F529C0 VA: 0x7F569C0 Slot: 5
	public override IEnumerable<Material> get_Materials() { }

	// RVA: 0x7F569C8 Offset: 0x7F529C8 VA: 0x7F569C8 Slot: 6
	public override int get_MaterialCount() { }

	// RVA: 0x7F569E0 Offset: 0x7F529E0 VA: 0x7F569E0 Slot: 4
	public override Material get_PrimaryMaterial() { }

	// RVA: 0x7F56A08 Offset: 0x7F52A08 VA: 0x7F56A08
	public static SpineSpriteAtlasAsset CreateRuntimeInstance(SpriteAtlas spriteAtlasFile, Material[] materials, bool initialize) { }

	// RVA: 0x7F56AB4 Offset: 0x7F52AB4 VA: 0x7F56AB4
	private void Reset() { }

	// RVA: 0x7F56AC0 Offset: 0x7F52AC0 VA: 0x7F56AC0 Slot: 8
	public override void Clear() { }

	// RVA: 0x7F56ACC Offset: 0x7F52ACC VA: 0x7F56ACC Slot: 9
	public override Atlas GetAtlas(bool onlyMetaData = False) { }

	// RVA: 0x7F57284 Offset: 0x7F53284 VA: 0x7F57284
	protected void AssignRegionsFromSavedRegions(Sprite[] sprites, Atlas usedAtlas) { }

	// RVA: 0x7F56E08 Offset: 0x7F52E08 VA: 0x7F56E08
	private Atlas LoadAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x7F57680 Offset: 0x7F53680 VA: 0x7F57680
	public static Texture2D AccessPackedTexture(Sprite[] sprites) { }

	// RVA: 0x7F576AC Offset: 0x7F536AC VA: 0x7F576AC
	public static Sprite[] AccessPackedSprites(SpriteAtlas spriteAtlas) { }

	// RVA: 0x7F57734 Offset: 0x7F53734 VA: 0x7F57734
	public void .ctor() { }
}

// Namespace: 
public enum BoneFollower.AxisOrientation // TypeDefIndex: 24111
{
	// Fields
	public int value__; // 0x0
	public const BoneFollower.AxisOrientation XAxis = 1;
	public const BoneFollower.AxisOrientation YAxis = 2;
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#BoneFollower")]
[AddComponentMenu("Spine/BoneFollower")]
[ExecuteAlways]
public class BoneFollower : MonoBehaviour // TypeDefIndex: 24112
{
	// Fields
	public SkeletonRenderer skeletonRenderer; // 0x20
	[SpineBone("", "skeletonRenderer", True, False)]
	public string boneName; // 0x28
	public bool followXYPosition; // 0x30
	public bool followZPosition; // 0x31
	public bool followBoneRotation; // 0x32
	[Tooltip("Follows the skeleton's flip state by controlling this Transform's local scale.")]
	public bool followSkeletonFlip; // 0x33
	[FormerlySerializedAs("followScale")]
	[Tooltip("Follows the target bone's local scale.")]
	public bool followLocalScale; // 0x34
	[Tooltip("Includes the parent bone's lossy world scale. BoneFollower cannot inherit rotated/skewed scale because of UnityEngine.Transform property limitations.")]
	public bool followParentWorldScale; // 0x35
	[Tooltip("Applies when 'Follow Skeleton Flip' is disabled but 'Follow Bone Rotation' is enabled. When flipping the skeleton by scaling its Transform, this follower's rotation is adjusted instead of its scale to follow the bone orientation. When one of the axes is flipped,  only one axis can be followed, either the X or the Y axis, which is selected here.")]
	public BoneFollower.AxisOrientation maintainedAxisOrientation; // 0x38
	[FormerlySerializedAs("resetOnAwake")]
	public bool initializeOnAwake; // 0x3C
	public bool valid; // 0x3D
	public Bone bone; // 0x40
	private Transform skeletonTransform; // 0x48
	private bool skeletonTransformIsParent; // 0x50

	// Properties
	public SkeletonRenderer SkeletonRenderer { get; set; }

	// Methods

	// RVA: 0x7F57744 Offset: 0x7F53744 VA: 0x7F57744
	public SkeletonRenderer get_SkeletonRenderer() { }

	// RVA: 0x7F5774C Offset: 0x7F5374C VA: 0x7F5774C
	public void set_SkeletonRenderer(SkeletonRenderer value) { }

	// RVA: 0x7F57938 Offset: 0x7F53938 VA: 0x7F57938
	public bool SetBone(string name) { }

	// RVA: 0x7F57A20 Offset: 0x7F53A20 VA: 0x7F57A20
	public void Awake() { }

	// RVA: 0x7F57A30 Offset: 0x7F53A30 VA: 0x7F57A30
	public void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer) { }

	// RVA: 0x7F57768 Offset: 0x7F53768 VA: 0x7F57768
	public void Initialize() { }

	// RVA: 0x7F57A34 Offset: 0x7F53A34 VA: 0x7F57A34
	private void OnDestroy() { }

	// RVA: 0x7F57B04 Offset: 0x7F53B04 VA: 0x7F57B04
	public void LateUpdate() { }

	// RVA: 0x7F58060 Offset: 0x7F54060 VA: 0x7F58060
	public void .ctor() { }
}

// Namespace: Spine.Unity
[AddComponentMenu("Spine/UI/BoneFollowerGraphic")]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[HelpURL("http://esotericsoftware.com/spine-unity#BoneFollowerGraphic")]
public class BoneFollowerGraphic : MonoBehaviour // TypeDefIndex: 24113
{
	// Fields
	public SkeletonGraphic skeletonGraphic; // 0x20
	public bool initializeOnAwake; // 0x28
	[SpineBone("", "skeletonGraphic", True, False)]
	public string boneName; // 0x30
	public bool followBoneRotation; // 0x38
	[Tooltip("Follows the skeleton's flip state by controlling this Transform's local scale.")]
	public bool followSkeletonFlip; // 0x39
	[Tooltip("Follows the target bone's local scale.")]
	public bool followLocalScale; // 0x3A
	[Tooltip("Includes the parent bone's lossy world scale. BoneFollower cannot inherit rotated/skewed scale because of UnityEngine.Transform property limitations.")]
	public bool followParentWorldScale; // 0x3B
	public bool followXYPosition; // 0x3C
	public bool followZPosition; // 0x3D
	[Tooltip("Applies when 'Follow Skeleton Flip' is disabled but 'Follow Bone Rotation' is enabled. When flipping the skeleton by scaling its Transform, this follower's rotation is adjusted instead of its scale to follow the bone orientation. When one of the axes is flipped,  only one axis can be followed, either the X or the Y axis, which is selected here.")]
	public BoneFollower.AxisOrientation maintainedAxisOrientation; // 0x40
	public Bone bone; // 0x48
	private Transform skeletonTransform; // 0x50
	private bool skeletonTransformIsParent; // 0x58
	public bool valid; // 0x59

	// Properties
	public SkeletonGraphic SkeletonGraphic { get; set; }

	// Methods

	// RVA: 0x7F5807C Offset: 0x7F5407C VA: 0x7F5807C
	public SkeletonGraphic get_SkeletonGraphic() { }

	// RVA: 0x7F58084 Offset: 0x7F54084 VA: 0x7F58084
	public void set_SkeletonGraphic(SkeletonGraphic value) { }

	// RVA: 0x7F581E8 Offset: 0x7F541E8 VA: 0x7F581E8
	public bool SetBone(string name) { }

	// RVA: 0x7F58308 Offset: 0x7F54308 VA: 0x7F58308
	public void Awake() { }

	// RVA: 0x7F580A0 Offset: 0x7F540A0 VA: 0x7F580A0
	public void Initialize() { }

	// RVA: 0x7F58328 Offset: 0x7F54328 VA: 0x7F58328
	public void LateUpdate() { }

	// RVA: 0x7F5894C Offset: 0x7F5494C VA: 0x7F5894C
	public void .ctor() { }
}

// Namespace: Spine.Unity
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#BoundingBoxFollower")]
public class BoundingBoxFollower : MonoBehaviour // TypeDefIndex: 24114
{
	// Fields
	internal static bool DebugMessages; // 0x0
	public SkeletonRenderer skeletonRenderer; // 0x20
	[SpineSlot("", "skeletonRenderer", True, True, False)]
	public string slotName; // 0x28
	public bool isTrigger; // 0x30
	public bool usedByEffector; // 0x31
	public bool usedByComposite; // 0x32
	public bool clearStateOnDisable; // 0x33
	private Slot slot; // 0x38
	private BoundingBoxAttachment currentAttachment; // 0x40
	private string currentAttachmentName; // 0x48
	private PolygonCollider2D currentCollider; // 0x50
	public readonly Dictionary<BoundingBoxAttachment, PolygonCollider2D> colliderTable; // 0x58
	public readonly Dictionary<BoundingBoxAttachment, string> nameTable; // 0x60

	// Properties
	public Slot Slot { get; }
	public BoundingBoxAttachment CurrentAttachment { get; }
	public string CurrentAttachmentName { get; }
	public PolygonCollider2D CurrentCollider { get; }
	public bool IsTrigger { get; }

	// Methods

	// RVA: 0x7F5896C Offset: 0x7F5496C VA: 0x7F5896C
	public Slot get_Slot() { }

	// RVA: 0x7F58974 Offset: 0x7F54974 VA: 0x7F58974
	public BoundingBoxAttachment get_CurrentAttachment() { }

	// RVA: 0x7F5897C Offset: 0x7F5497C VA: 0x7F5897C
	public string get_CurrentAttachmentName() { }

	// RVA: 0x7F58984 Offset: 0x7F54984 VA: 0x7F58984
	public PolygonCollider2D get_CurrentCollider() { }

	// RVA: 0x7F5898C Offset: 0x7F5498C VA: 0x7F5898C
	public bool get_IsTrigger() { }

	// RVA: 0x7F58994 Offset: 0x7F54994 VA: 0x7F58994
	private void Start() { }

	// RVA: 0x7F58EC0 Offset: 0x7F54EC0 VA: 0x7F58EC0
	private void OnEnable() { }

	// RVA: 0x7F58FCC Offset: 0x7F54FCC VA: 0x7F58FCC
	private void HandleRebuild(SkeletonRenderer sr) { }

	// RVA: 0x7F5899C Offset: 0x7F5499C VA: 0x7F5899C
	public void Initialize(bool overwrite = False) { }

	// RVA: 0x7F58FD4 Offset: 0x7F54FD4 VA: 0x7F58FD4
	private void AddCollidersForSkin(Skin skin, int slotIndex, PolygonCollider2D[] previousColliders, ref int collidersCount) { }

	// RVA: 0x7F5955C Offset: 0x7F5555C VA: 0x7F5955C
	private void OnDisable() { }

	// RVA: 0x7F5963C Offset: 0x7F5563C VA: 0x7F5963C
	public void ClearState() { }

	// RVA: 0x7F5946C Offset: 0x7F5546C VA: 0x7F5946C
	private void DisposeExcessCollidersAfter(int requiredCount) { }

	// RVA: 0x7F597DC Offset: 0x7F557DC VA: 0x7F597DC
	private void LateUpdate() { }

	// RVA: 0x7F597FC Offset: 0x7F557FC VA: 0x7F597FC
	private void MatchAttachment(Attachment attachment) { }

	// RVA: 0x7F59B58 Offset: 0x7F55B58 VA: 0x7F59B58
	public void .ctor() { }

	// RVA: 0x7F59C3C Offset: 0x7F55C3C VA: 0x7F59C3C
	private static void .cctor() { }
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#BoundingBoxFollowerGraphic")]
[ExecuteAlways]
public class BoundingBoxFollowerGraphic : MonoBehaviour // TypeDefIndex: 24115
{
	// Fields
	internal static bool DebugMessages; // 0x0
	public SkeletonGraphic skeletonGraphic; // 0x20
	[SpineSlot("", "skeletonGraphic", True, True, False)]
	public string slotName; // 0x28
	public bool isTrigger; // 0x30
	public bool usedByEffector; // 0x31
	public bool usedByComposite; // 0x32
	public bool clearStateOnDisable; // 0x33
	private Slot slot; // 0x38
	private BoundingBoxAttachment currentAttachment; // 0x40
	private string currentAttachmentName; // 0x48
	private PolygonCollider2D currentCollider; // 0x50
	public readonly Dictionary<BoundingBoxAttachment, PolygonCollider2D> colliderTable; // 0x58
	public readonly Dictionary<BoundingBoxAttachment, string> nameTable; // 0x60

	// Properties
	public Slot Slot { get; }
	public BoundingBoxAttachment CurrentAttachment { get; }
	public string CurrentAttachmentName { get; }
	public PolygonCollider2D CurrentCollider { get; }
	public bool IsTrigger { get; }

	// Methods

	// RVA: 0x7F59C88 Offset: 0x7F55C88 VA: 0x7F59C88
	public Slot get_Slot() { }

	// RVA: 0x7F59C90 Offset: 0x7F55C90 VA: 0x7F59C90
	public BoundingBoxAttachment get_CurrentAttachment() { }

	// RVA: 0x7F59C98 Offset: 0x7F55C98 VA: 0x7F59C98
	public string get_CurrentAttachmentName() { }

	// RVA: 0x7F59CA0 Offset: 0x7F55CA0 VA: 0x7F59CA0
	public PolygonCollider2D get_CurrentCollider() { }

	// RVA: 0x7F59CA8 Offset: 0x7F55CA8 VA: 0x7F59CA8
	public bool get_IsTrigger() { }

	// RVA: 0x7F59CB0 Offset: 0x7F55CB0 VA: 0x7F59CB0
	private void Start() { }

	// RVA: 0x7F5A2B8 Offset: 0x7F562B8 VA: 0x7F5A2B8
	private void OnEnable() { }

	// RVA: 0x7F5A4FC Offset: 0x7F564FC VA: 0x7F5A4FC
	private void HandleRebuild(SkeletonGraphic sr) { }

	// RVA: 0x7F59CB8 Offset: 0x7F55CB8 VA: 0x7F59CB8
	public void Initialize(bool overwrite = False) { }

	// RVA: 0x7F5A8F8 Offset: 0x7F568F8 VA: 0x7F5A8F8
	private void AddCollidersForSkin(Skin skin, int slotIndex, PolygonCollider2D[] previousColliders, float scale, ref int collidersCount) { }

	// RVA: 0x7F5AE8C Offset: 0x7F56E8C VA: 0x7F5AE8C
	private void OnDisable() { }

	// RVA: 0x7F5AF68 Offset: 0x7F56F68 VA: 0x7F5AF68
	public void ClearState() { }

	// RVA: 0x7F5AD9C Offset: 0x7F56D9C VA: 0x7F5AD9C
	private void DisposeExcessCollidersAfter(int requiredCount) { }

	// RVA: 0x7F5B108 Offset: 0x7F57108 VA: 0x7F5B108
	private void LateUpdate() { }

	// RVA: 0x7F5B128 Offset: 0x7F57128 VA: 0x7F5B128
	private void MatchAttachment(Attachment attachment) { }

	// RVA: 0x7F5B484 Offset: 0x7F57484 VA: 0x7F5B484
	public void .ctor() { }

	// RVA: 0x7F5B568 Offset: 0x7F57568 VA: 0x7F5B568
	private static void .cctor() { }
}

// Namespace: Spine.Unity
[ExecuteAlways]
[AddComponentMenu("Spine/Point Follower")]
[HelpURL("http://esotericsoftware.com/spine-unity#PointFollower")]
public class PointFollower : MonoBehaviour, IHasSkeletonRenderer, ISpineComponent, IHasSkeletonComponent // TypeDefIndex: 24116
{
	// Fields
	public SkeletonRenderer skeletonRenderer; // 0x20
	[SpineSlot("", "skeletonRenderer", False, True, False)]
	public string slotName; // 0x28
	[SpineAttachment(True, False, False, "slotName", "skeletonRenderer", "", True, True)]
	public string pointAttachmentName; // 0x30
	public bool followRotation; // 0x38
	public bool followSkeletonFlip; // 0x39
	public bool followSkeletonZPosition; // 0x3A
	private Transform skeletonTransform; // 0x40
	private bool skeletonTransformIsParent; // 0x48
	private PointAttachment point; // 0x50
	private Bone bone; // 0x58
	private bool valid; // 0x60

	// Properties
	public SkeletonRenderer SkeletonRenderer { get; }
	public ISkeletonComponent SkeletonComponent { get; }
	public bool IsValid { get; }

	// Methods

	// RVA: 0x7F5B5B4 Offset: 0x7F575B4 VA: 0x7F5B5B4 Slot: 4
	public SkeletonRenderer get_SkeletonRenderer() { }

	// RVA: 0x7F5B5BC Offset: 0x7F575BC VA: 0x7F5B5BC Slot: 5
	public ISkeletonComponent get_SkeletonComponent() { }

	// RVA: 0x7F5B5C4 Offset: 0x7F575C4 VA: 0x7F5B5C4
	public bool get_IsValid() { }

	// RVA: 0x7F5B5CC Offset: 0x7F575CC VA: 0x7F5B5CC
	public void Initialize() { }

	// RVA: 0x7F5B89C Offset: 0x7F5789C VA: 0x7F5B89C
	private void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer) { }

	// RVA: 0x7F5B660 Offset: 0x7F57660 VA: 0x7F5B660
	private void UpdateReferences() { }

	// RVA: 0x7F5B8A0 Offset: 0x7F578A0 VA: 0x7F5B8A0
	private void OnDestroy() { }

	// RVA: 0x7F5B970 Offset: 0x7F57970 VA: 0x7F5B970
	public void LateUpdate() { }

	// RVA: 0x7F5BC88 Offset: 0x7F57C88 VA: 0x7F5BC88
	public void .ctor() { }
}

// Namespace: Spine.Unity
[RequireComponent(typeof(CanvasRenderer))]
public class SkeletonSubmeshGraphic : MaskableGraphic // TypeDefIndex: 24117
{
	// Methods

	// RVA: 0x7F5BC98 Offset: 0x7F57C98 VA: 0x7F5BC98 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x7F5BC9C Offset: 0x7F57C9C VA: 0x7F5BC9C Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x7F5BCA0 Offset: 0x7F57CA0 VA: 0x7F5BCA0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x7F5BCB8 Offset: 0x7F57CB8 VA: 0x7F5BCB8 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x7F5BCEC Offset: 0x7F57CEC VA: 0x7F5BCEC Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x7F5BD20 Offset: 0x7F57D20 VA: 0x7F5BD20
	public void .ctor() { }
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonMecanimRootMotion")]
public class SkeletonMecanimRootMotion : SkeletonRootMotionBase // TypeDefIndex: 24118
{
	// Fields
	private const int DefaultMecanimLayerFlags = -1;
	public int mecanimLayerFlags; // 0xF8
	protected Vector2 movementDelta; // 0xFC
	protected float rotationDelta; // 0x104
	private SkeletonMecanim skeletonMecanim; // 0x108

	// Properties
	public SkeletonMecanim SkeletonMecanim { get; }

	// Methods

	// RVA: 0x7F5BD28 Offset: 0x7F57D28 VA: 0x7F5BD28
	public SkeletonMecanim get_SkeletonMecanim() { }

	// RVA: 0x7F5BDD0 Offset: 0x7F57DD0 VA: 0x7F5BDD0 Slot: 12
	public override Vector2 GetRemainingRootMotion(int layerIndex) { }

	// RVA: 0x7F5C46C Offset: 0x7F5846C VA: 0x7F5C46C Slot: 13
	public override SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int layerIndex) { }

	// RVA: 0x7F5C760 Offset: 0x7F58760 VA: 0x7F5C760 Slot: 4
	protected override void Reset() { }

	// RVA: 0x7F5C780 Offset: 0x7F58780 VA: 0x7F5C780 Slot: 5
	protected override void Start() { }

	// RVA: 0x7F5CAD8 Offset: 0x7F58AD8 VA: 0x7F5CAD8
	private void OnClipApplied(Animation animation, int layerIndex, float weight, float time, float lastTime, bool playsBackward) { }

	// RVA: 0x7F5D02C Offset: 0x7F5902C VA: 0x7F5D02C Slot: 10
	protected override Vector2 CalculateAnimationsMovementDelta() { }

	// RVA: 0x7F5D090 Offset: 0x7F59090 VA: 0x7F5D090 Slot: 11
	protected override float CalculateAnimationsRotationDelta() { }

	// RVA: 0x7F5D09C Offset: 0x7F5909C VA: 0x7F5D09C
	public void .ctor() { }
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRootMotion")]
public class SkeletonRootMotion : SkeletonRootMotionBase // TypeDefIndex: 24119
{
	// Fields
	private const int DefaultAnimationTrackFlags = -1;
	public int animationTrackFlags; // 0xF8
	private AnimationState animationState; // 0x100
	private Canvas canvas; // 0x108

	// Properties
	protected override float AdditionalScale { get; }

	// Methods

	// RVA: 0x7F5D2F8 Offset: 0x7F592F8 VA: 0x7F5D2F8 Slot: 12
	public override Vector2 GetRemainingRootMotion(int trackIndex) { }

	// RVA: 0x7F5D380 Offset: 0x7F59380 VA: 0x7F5D380 Slot: 13
	public override SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int trackIndex) { }

	// RVA: 0x7F5D3FC Offset: 0x7F593FC VA: 0x7F5D3FC Slot: 9
	protected override float get_AdditionalScale() { }

	// RVA: 0x7F5D480 Offset: 0x7F59480 VA: 0x7F5D480 Slot: 4
	protected override void Reset() { }

	// RVA: 0x7F5D49C Offset: 0x7F5949C VA: 0x7F5D49C Slot: 5
	protected override void Start() { }

	// RVA: 0x7F5D620 Offset: 0x7F59620 VA: 0x7F5D620 Slot: 10
	protected override Vector2 CalculateAnimationsMovementDelta() { }

	// RVA: 0x7F5D7FC Offset: 0x7F597FC VA: 0x7F5D7FC Slot: 11
	protected override float CalculateAnimationsRotationDelta() { }

	// RVA: 0x7F5D7C4 Offset: 0x7F597C4 VA: 0x7F5D7C4
	private void ApplyMixAlphaToDelta(ref Vector2 currentDelta, TrackEntry next, TrackEntry track) { }

	// RVA: 0x7F5D908 Offset: 0x7F59908 VA: 0x7F5D908
	private void ApplyMixAlphaToDelta(ref float currentDelta, TrackEntry next, TrackEntry track) { }

	// RVA: 0x7F5D940 Offset: 0x7F59940 VA: 0x7F5D940
	private void GetMixAlpha(ref float cumulatedMixAlpha, TrackEntry next, TrackEntry track) { }

	// RVA: 0x7F5D9DC Offset: 0x7F599DC VA: 0x7F5D9DC
	public void .ctor() { }
}

// Namespace: 
public sealed class SkeletonRootMotionBase.RootMotionDelegate : MulticastDelegate // TypeDefIndex: 24120
{
	// Methods

	// RVA: 0x7F6041C Offset: 0x7F5C41C VA: 0x7F6041C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F60528 Offset: 0x7F5C528 VA: 0x7F60528 Slot: 13
	public virtual void Invoke(SkeletonRootMotionBase component, Vector2 translation, float rotation) { }

	// RVA: 0x7F6053C Offset: 0x7F5C53C VA: 0x7F6053C Slot: 14
	public virtual IAsyncResult BeginInvoke(SkeletonRootMotionBase component, Vector2 translation, float rotation, AsyncCallback callback, object object) { }

	// RVA: 0x7F605FC Offset: 0x7F5C5FC VA: 0x7F605FC Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public struct SkeletonRootMotionBase.RootMotionInfo // TypeDefIndex: 24121
{
	// Fields
	public Vector2 start; // 0x0
	public Vector2 current; // 0x8
	public Vector2 mid; // 0x10
	public Vector2 end; // 0x18
	public bool timeIsPastMid; // 0x20
}

// Namespace: 
[CompilerGenerated]
private sealed class SkeletonRootMotionBase.<>c__DisplayClass78_0 // TypeDefIndex: 24122
{
	// Fields
	public int constraintIndex; // 0x10

	// Methods

	// RVA: 0x7F5F76C Offset: 0x7F5B76C VA: 0x7F5F76C
	public void .ctor() { }

	// RVA: 0x7F60608 Offset: 0x7F5C608 VA: 0x7F60608
	internal bool <GetConstraintLastPosIndex>b__0(int addedIndex) { }
}

// Namespace: Spine.Unity
[DefaultExecutionOrder(1)]
public abstract class SkeletonRootMotionBase : MonoBehaviour // TypeDefIndex: 24123
{
	// Fields
	[SpineBone("", "", True, False)]
	[SerializeField]
	protected string rootMotionBoneName; // 0x20
	public bool transformPositionX; // 0x28
	public bool transformPositionY; // 0x29
	public bool transformRotation; // 0x2A
	public float rootMotionScaleX; // 0x2C
	public float rootMotionScaleY; // 0x30
	public float rootMotionScaleRotation; // 0x34
	public float rootMotionTranslateXPerY; // 0x38
	public float rootMotionTranslateYPerX; // 0x3C
	[Header("Optional")]
	public Rigidbody2D rigidBody2D; // 0x40
	public bool applyRigidbody2DGravity; // 0x48
	public Rigidbody rigidBody; // 0x50
	[CompilerGenerated]
	private SkeletonRootMotionBase.RootMotionDelegate ProcessRootMotionOverride; // 0x58
	[CompilerGenerated]
	private SkeletonRootMotionBase.RootMotionDelegate PhysicsUpdateRootMotionOverride; // 0x60
	public bool disableOnOverride; // 0x68
	protected ISkeletonComponent skeletonComponent; // 0x70
	protected Bone rootMotionBone; // 0x78
	protected int rootMotionBoneIndex; // 0x80
	protected List<int> transformConstraintIndices; // 0x88
	protected List<Vector2> transformConstraintLastPos; // 0x90
	protected List<float> transformConstraintLastRotation; // 0x98
	protected List<Bone> topLevelBones; // 0xA0
	protected Vector2 initialOffset; // 0xA8
	protected bool accumulatedUntilFixedUpdate; // 0xB0
	protected Vector2 tempSkeletonDisplacement; // 0xB4
	protected Vector3 rigidbodyDisplacement; // 0xBC
	protected Vector3 previousRigidbodyRootMotion; // 0xC8
	protected Vector2 additionalRigidbody2DMovement; // 0xD4
	protected Quaternion rigidbodyLocalRotation; // 0xDC
	protected float rigidbody2DRotation; // 0xEC
	protected float initialOffsetRotation; // 0xF0
	protected float tempSkeletonRotation; // 0xF4

	// Properties
	public Bone RootMotionBone { get; }
	public bool UsesRigidbody { get; }
	public Vector2 PreviousRigidbodyRootMotion2D { get; }
	public Vector3 PreviousRigidbodyRootMotion3D { get; }
	public Vector2 AdditionalRigidbody2DMovement { get; set; }
	protected bool SkeletonAnimationUsesFixedUpdate { get; }
	protected virtual float AdditionalScale { get; }
	public ISkeletonComponent TargetSkeletonComponent { get; }
	public ISkeletonAnimation TargetSkeletonAnimationComponent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F5D9E8 Offset: 0x7F599E8 VA: 0x7F5D9E8
	public void add_ProcessRootMotionOverride(SkeletonRootMotionBase.RootMotionDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F5DA84 Offset: 0x7F59A84 VA: 0x7F5DA84
	public void remove_ProcessRootMotionOverride(SkeletonRootMotionBase.RootMotionDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F5DB20 Offset: 0x7F59B20 VA: 0x7F5DB20
	public void add_PhysicsUpdateRootMotionOverride(SkeletonRootMotionBase.RootMotionDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F5DBBC Offset: 0x7F59BBC VA: 0x7F5DBBC
	public void remove_PhysicsUpdateRootMotionOverride(SkeletonRootMotionBase.RootMotionDelegate value) { }

	// RVA: 0x7F5DC58 Offset: 0x7F59C58 VA: 0x7F5DC58
	public Bone get_RootMotionBone() { }

	// RVA: 0x7F5DC60 Offset: 0x7F59C60 VA: 0x7F5DC60
	public bool get_UsesRigidbody() { }

	// RVA: 0x7F5DCF8 Offset: 0x7F59CF8 VA: 0x7F5DCF8
	public Vector2 get_PreviousRigidbodyRootMotion2D() { }

	// RVA: 0x7F5DD00 Offset: 0x7F59D00 VA: 0x7F5DD00
	public Vector3 get_PreviousRigidbodyRootMotion3D() { }

	// RVA: 0x7F5DD0C Offset: 0x7F59D0C VA: 0x7F5DD0C
	public Vector2 get_AdditionalRigidbody2DMovement() { }

	// RVA: 0x7F5DD14 Offset: 0x7F59D14 VA: 0x7F5DD14
	public void set_AdditionalRigidbody2DMovement(Vector2 value) { }

	// RVA: 0x7F5DD1C Offset: 0x7F59D1C VA: 0x7F5DD1C
	protected bool get_SkeletonAnimationUsesFixedUpdate() { }

	// RVA: 0x7F5C77C Offset: 0x7F5877C VA: 0x7F5C77C Slot: 4
	protected virtual void Reset() { }

	// RVA: 0x7F5C8E4 Offset: 0x7F588E4 VA: 0x7F5C8E4 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x7F5E3A0 Offset: 0x7F5A3A0 VA: 0x7F5E3A0 Slot: 6
	protected virtual void FixedUpdate() { }

	// RVA: 0x7F5E3E0 Offset: 0x7F5A3E0 VA: 0x7F5E3E0 Slot: 7
	protected virtual void PhysicsUpdate(bool skeletonAnimationUsesFixedUpdate) { }

	// RVA: 0x7F5EAA8 Offset: 0x7F5AAA8 VA: 0x7F5EAA8 Slot: 8
	protected virtual void OnDisable() { }

	// RVA: 0x7F5DDD4 Offset: 0x7F59DD4 VA: 0x7F5DDD4
	protected void FindRigidbodyComponent() { }

	// RVA: 0x7F5EAAC Offset: 0x7F5AAAC VA: 0x7F5EAAC Slot: 9
	protected virtual float get_AdditionalScale() { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract Vector2 CalculateAnimationsMovementDelta();

	// RVA: 0x7F5EAB4 Offset: 0x7F5AAB4 VA: 0x7F5EAB4 Slot: 11
	protected virtual float CalculateAnimationsRotationDelta() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Vector2 GetRemainingRootMotion(int trackIndex = 0);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int trackIndex = 0);

	// RVA: 0x7F5EABC Offset: 0x7F5AABC VA: 0x7F5EABC
	public ISkeletonComponent get_TargetSkeletonComponent() { }

	// RVA: 0x7F5EB28 Offset: 0x7F5AB28 VA: 0x7F5EB28
	public ISkeletonAnimation get_TargetSkeletonAnimationComponent() { }

	// RVA: 0x7F5E21C Offset: 0x7F5A21C VA: 0x7F5E21C
	public void SetRootMotionBone(string name) { }

	// RVA: 0x7F5EDF8 Offset: 0x7F5ADF8 VA: 0x7F5EDF8
	public void AdjustRootMotionToDistance(Vector2 distanceToTarget, int trackIndex = 0, bool adjustX = True, bool adjustY = True, float minX = 0, float maxX = 3.4028235E+38, float minY = 0, float maxY = 3.4028235E+38, bool allowXTranslation = False, bool allowYTranslation = False) { }

	// RVA: 0x7F5F000 Offset: 0x7F5B000 VA: 0x7F5F000
	public Vector2 GetAnimationRootMotion(Animation animation) { }

	// RVA: 0x7F5BE8C Offset: 0x7F57E8C VA: 0x7F5BE8C
	public Vector2 GetAnimationRootMotion(float startTime, float endTime, Animation animation) { }

	// RVA: 0x7F5F308 Offset: 0x7F5B308 VA: 0x7F5F308
	public float GetAnimationRootMotionRotation(Animation animation) { }

	// RVA: 0x7F5CBE0 Offset: 0x7F58BE0 VA: 0x7F5CBE0
	public float GetAnimationRootMotionRotation(float startTime, float endTime, Animation animation) { }

	// RVA: 0x7F5F01C Offset: 0x7F5B01C VA: 0x7F5F01C
	private void ApplyConstraintToPos(Animation animation, TransformConstraint constraint, int constraintIndex, float time, bool useLastConstraintPos, ref Vector2 pos) { }

	// RVA: 0x7F5F324 Offset: 0x7F5B324 VA: 0x7F5F324
	private void ApplyConstraintToRotation(Animation animation, TransformConstraint constraint, int constraintIndex, float time, bool useLastConstraintRotation, ref float rotation) { }

	// RVA: 0x7F5F138 Offset: 0x7F5B138 VA: 0x7F5F138
	private void UpdateLastConstraintPos(TransformConstraint[] transformConstraintsItems) { }

	// RVA: 0x7F5F424 Offset: 0x7F5B424 VA: 0x7F5F424
	private void UpdateLastConstraintRotation(TransformConstraint[] transformConstraintsItems) { }

	// RVA: 0x7F5C528 Offset: 0x7F58528 VA: 0x7F5C528
	public SkeletonRootMotionBase.RootMotionInfo GetAnimationRootMotionInfo(Animation animation, float currentTime) { }

	// RVA: 0x7F5F5F4 Offset: 0x7F5B5F4 VA: 0x7F5F5F4
	private int GetConstraintLastPosIndex(int constraintIndex) { }

	// RVA: 0x7F5EB74 Offset: 0x7F5AB74 VA: 0x7F5EB74
	private void FindTransformConstraintsAffectingBone() { }

	// RVA: 0x7F5F774 Offset: 0x7F5B774 VA: 0x7F5F774
	private Vector2 GetTimelineMovementDelta(float startTime, float endTime, TranslateXTimeline xTimeline, TranslateYTimeline yTimeline, Animation animation) { }

	// RVA: 0x7F5DF80 Offset: 0x7F59F80 VA: 0x7F5DF80
	private void GatherTopLevelBones() { }

	// RVA: 0x7F5F8C0 Offset: 0x7F5B8C0 VA: 0x7F5F8C0
	private void HandleUpdateLocal(ISkeletonAnimation animatedSkeletonComponent) { }

	// RVA: 0x7F5FA30 Offset: 0x7F5BA30 VA: 0x7F5FA30
	private void ApplyRootMotion(Vector2 skeletonTranslationDelta, float skeletonRotationDelta, Vector2 parentBoneScale, bool skeletonAnimationUsesFixedUpdate) { }

	// RVA: 0x7F601FC Offset: 0x7F5C1FC VA: 0x7F601FC
	private void ApplyTransformConstraints() { }

	// RVA: 0x7F5EFE8 Offset: 0x7F5AFE8 VA: 0x7F5EFE8
	private Vector2 GetScaleAffectingRootMotion() { }

	// RVA: 0x7F5E808 Offset: 0x7F5A808 VA: 0x7F5E808
	private Vector2 GetScaleAffectingRootMotion(out Vector2 parentBoneScale) { }

	// RVA: 0x7F5F9A4 Offset: 0x7F5B9A4 VA: 0x7F5F9A4
	private Vector2 GetSkeletonSpaceMovementDelta(Vector2 boneLocalDelta, out Vector2 parentBoneScale, out Vector2 totalScale) { }

	// RVA: 0x7F5FA1C Offset: 0x7F5BA1C VA: 0x7F5FA1C
	private float GetSkeletonSpaceRotationDelta(float boneLocalDelta, Vector2 totalScaleAffectingRootMotion) { }

	// RVA: 0x7F5FDB0 Offset: 0x7F5BDB0 VA: 0x7F5FDB0
	private void SetEffectiveBoneOffsetsTo(Vector2 displacementSkeletonSpace, float rotationSkeletonSpace, Vector2 parentBoneScale) { }

	// RVA: 0x7F5E99C Offset: 0x7F5A99C VA: 0x7F5E99C
	private void ClearEffectiveBoneOffsets(Vector2 parentBoneScale) { }

	// RVA: 0x7F5EA08 Offset: 0x7F5AA08 VA: 0x7F5EA08
	private void ClearRigidbodyTempMovement() { }

	// RVA: 0x7F5D0A8 Offset: 0x7F590A8 VA: 0x7F5D0A8
	protected void .ctor() { }
}

// Namespace: Spine.Unity
[AddComponentMenu("Spine/SkeletonAnimation")]
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonAnimation-Component")]
public class SkeletonAnimation : SkeletonRenderer, ISkeletonAnimation, ISpineComponent, IAnimationStateComponent // TypeDefIndex: 24124
{
	// Fields
	public AnimationState state; // 0xE8
	private bool wasUpdatedAfterInit; // 0xF0
	[CompilerGenerated]
	private ISkeletonAnimationDelegate _OnAnimationRebuild; // 0xF8
	[CompilerGenerated]
	private UpdateBonesDelegate _BeforeApply; // 0x100
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateLocal; // 0x108
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateWorld; // 0x110
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateComplete; // 0x118
	[SerializeField]
	protected UpdateTiming updateTiming; // 0x120
	[SerializeField]
	protected bool unscaledTime; // 0x124
	[SpineAnimation("", "", True, False)]
	[SerializeField]
	private string _animationName; // 0x128
	public bool loop; // 0x130
	public float timeScale; // 0x134

	// Properties
	public AnimationState AnimationState { get; }
	public UpdateTiming UpdateTiming { get; set; }
	public bool UnscaledTime { get; set; }
	public string AnimationName { get; set; }

	// Methods

	// RVA: 0x7F60618 Offset: 0x7F5C618 VA: 0x7F60618 Slot: 24
	public AnimationState get_AnimationState() { }

	[CompilerGenerated]
	// RVA: 0x7F60640 Offset: 0x7F5C640 VA: 0x7F60640
	protected void add__OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F606DC Offset: 0x7F5C6DC VA: 0x7F606DC
	protected void remove__OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F60778 Offset: 0x7F5C778 VA: 0x7F60778
	protected void add__BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F60818 Offset: 0x7F5C818 VA: 0x7F60818
	protected void remove__BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F608B8 Offset: 0x7F5C8B8 VA: 0x7F608B8
	protected void add__UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F60958 Offset: 0x7F5C958 VA: 0x7F60958
	protected void remove__UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F609F8 Offset: 0x7F5C9F8 VA: 0x7F609F8
	protected void add__UpdateWorld(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F60A98 Offset: 0x7F5CA98 VA: 0x7F60A98
	protected void remove__UpdateWorld(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F60B38 Offset: 0x7F5CB38 VA: 0x7F60B38
	protected void add__UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F60BD8 Offset: 0x7F5CBD8 VA: 0x7F60BD8
	protected void remove__UpdateComplete(UpdateBonesDelegate value) { }

	// RVA: 0x7F60C78 Offset: 0x7F5CC78 VA: 0x7F60C78 Slot: 13
	public void add_OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	// RVA: 0x7F60C7C Offset: 0x7F5CC7C VA: 0x7F60C7C Slot: 14
	public void remove_OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	// RVA: 0x7F60C80 Offset: 0x7F5CC80 VA: 0x7F60C80
	public void add_BeforeApply(UpdateBonesDelegate value) { }

	// RVA: 0x7F60C84 Offset: 0x7F5CC84 VA: 0x7F60C84
	public void remove_BeforeApply(UpdateBonesDelegate value) { }

	// RVA: 0x7F60C88 Offset: 0x7F5CC88 VA: 0x7F60C88 Slot: 15
	public void add_UpdateLocal(UpdateBonesDelegate value) { }

	// RVA: 0x7F60C8C Offset: 0x7F5CC8C VA: 0x7F60C8C Slot: 16
	public void remove_UpdateLocal(UpdateBonesDelegate value) { }

	// RVA: 0x7F60C90 Offset: 0x7F5CC90 VA: 0x7F60C90 Slot: 17
	public void add_UpdateWorld(UpdateBonesDelegate value) { }

	// RVA: 0x7F60C94 Offset: 0x7F5CC94 VA: 0x7F60C94 Slot: 18
	public void remove_UpdateWorld(UpdateBonesDelegate value) { }

	// RVA: 0x7F60C98 Offset: 0x7F5CC98 VA: 0x7F60C98 Slot: 19
	public void add_UpdateComplete(UpdateBonesDelegate value) { }

	// RVA: 0x7F60C9C Offset: 0x7F5CC9C VA: 0x7F60C9C Slot: 20
	public void remove_UpdateComplete(UpdateBonesDelegate value) { }

	// RVA: 0x7F60CA0 Offset: 0x7F5CCA0 VA: 0x7F60CA0 Slot: 22
	public UpdateTiming get_UpdateTiming() { }

	// RVA: 0x7F60CA8 Offset: 0x7F5CCA8 VA: 0x7F60CA8 Slot: 23
	public void set_UpdateTiming(UpdateTiming value) { }

	// RVA: 0x7F60CB0 Offset: 0x7F5CCB0 VA: 0x7F60CB0 Slot: 25
	public bool get_UnscaledTime() { }

	// RVA: 0x7F60CB8 Offset: 0x7F5CCB8 VA: 0x7F60CB8 Slot: 26
	public void set_UnscaledTime(bool value) { }

	// RVA: 0x7F60CC4 Offset: 0x7F5CCC4 VA: 0x7F60CC4
	public string get_AnimationName() { }

	// RVA: 0x7F60D0C Offset: 0x7F5CD0C VA: 0x7F60D0C
	public void set_AnimationName(string value) { }

	// RVA: 0x7F60E00 Offset: 0x7F5CE00 VA: 0x7F60E00
	public static SkeletonAnimation AddToGameObject(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, bool quiet = False) { }

	// RVA: 0x7F60E84 Offset: 0x7F5CE84 VA: 0x7F60E84
	public static SkeletonAnimation NewSkeletonAnimationGameObject(SkeletonDataAsset skeletonDataAsset, bool quiet = False) { }

	// RVA: 0x7F60F00 Offset: 0x7F5CF00 VA: 0x7F60F00 Slot: 8
	public override void ClearState() { }

	// RVA: 0x7F60F2C Offset: 0x7F5CF2C VA: 0x7F60F2C Slot: 9
	public override void Initialize(bool overwrite, bool quiet = False) { }

	// RVA: 0x7F61070 Offset: 0x7F5D070 VA: 0x7F61070 Slot: 27
	protected virtual void Update() { }

	// RVA: 0x7F61128 Offset: 0x7F5D128 VA: 0x7F61128 Slot: 28
	protected virtual void FixedUpdate() { }

	// RVA: 0x7F610B4 Offset: 0x7F5D0B4 VA: 0x7F610B4
	public void Update(float deltaTime) { }

	// RVA: 0x7F6116C Offset: 0x7F5D16C VA: 0x7F6116C
	protected void UpdateAnimationStatus(float deltaTime) { }

	// RVA: 0x7F61194 Offset: 0x7F5D194 VA: 0x7F61194
	protected void ApplyAnimation() { }

	// RVA: 0x7F611F8 Offset: 0x7F5D1F8 VA: 0x7F611F8
	public void AfterAnimationApplied() { }

	// RVA: 0x7F61284 Offset: 0x7F5D284 VA: 0x7F61284 Slot: 10
	public override void LateUpdate() { }

	// RVA: 0x7F612B0 Offset: 0x7F5D2B0 VA: 0x7F612B0 Slot: 12
	public override void OnBecameVisible() { }

	// RVA: 0x7F6130C Offset: 0x7F5D30C VA: 0x7F6130C
	public void .ctor() { }
}

// Namespace: 
public enum SkeletonGraphic.LayoutMode // TypeDefIndex: 24125
{
	// Fields
	public int value__; // 0x0
	public const SkeletonGraphic.LayoutMode None = 0;
	public const SkeletonGraphic.LayoutMode WidthControlsHeight = 1;
	public const SkeletonGraphic.LayoutMode HeightControlsWidth = 2;
	public const SkeletonGraphic.LayoutMode FitInParent = 3;
	public const SkeletonGraphic.LayoutMode EnvelopeParent = 4;
}

// Namespace: 
public sealed class SkeletonGraphic.MeshAssignmentDelegateSingle : MulticastDelegate // TypeDefIndex: 24126
{
	// Methods

	// RVA: 0x7F66808 Offset: 0x7F62808 VA: 0x7F66808
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F668BC Offset: 0x7F628BC VA: 0x7F668BC Slot: 13
	public virtual void Invoke(Mesh mesh, Material graphicMaterial, Texture texture) { }

	// RVA: 0x7F668D0 Offset: 0x7F628D0 VA: 0x7F668D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Mesh mesh, Material graphicMaterial, Texture texture, AsyncCallback callback, object object) { }

	// RVA: 0x7F668FC Offset: 0x7F628FC VA: 0x7F668FC Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class SkeletonGraphic.MeshAssignmentDelegateMultiple : MulticastDelegate // TypeDefIndex: 24127
{
	// Methods

	// RVA: 0x7F66908 Offset: 0x7F62908 VA: 0x7F66908
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F669A8 Offset: 0x7F629A8 VA: 0x7F669A8 Slot: 13
	public virtual void Invoke(int meshCount, Mesh[] meshes, Material[] graphicMaterials, Texture[] textures) { }

	// RVA: 0x7F669BC Offset: 0x7F629BC VA: 0x7F669BC Slot: 14
	public virtual IAsyncResult BeginInvoke(int meshCount, Mesh[] meshes, Material[] graphicMaterials, Texture[] textures, AsyncCallback callback, object object) { }

	// RVA: 0x7F66A68 Offset: 0x7F62A68 VA: 0x7F66A68 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class SkeletonGraphic.SkeletonRendererDelegate : MulticastDelegate // TypeDefIndex: 24128
{
	// Methods

	// RVA: 0x7F66A74 Offset: 0x7F62A74 VA: 0x7F66A74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F66B7C Offset: 0x7F62B7C VA: 0x7F66B7C Slot: 13
	public virtual void Invoke(SkeletonGraphic skeletonGraphic) { }

	// RVA: 0x7F66B90 Offset: 0x7F62B90 VA: 0x7F66B90 Slot: 14
	public virtual IAsyncResult BeginInvoke(SkeletonGraphic skeletonGraphic, AsyncCallback callback, object object) { }

	// RVA: 0x7F66BB0 Offset: 0x7F62BB0 VA: 0x7F66BB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class SkeletonGraphic.InstructionDelegate : MulticastDelegate // TypeDefIndex: 24129
{
	// Methods

	// RVA: 0x7F66BBC Offset: 0x7F62BBC VA: 0x7F66BBC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F66CC4 Offset: 0x7F62CC4 VA: 0x7F66CC4 Slot: 13
	public virtual void Invoke(SkeletonRendererInstruction instruction) { }

	// RVA: 0x7F66CD8 Offset: 0x7F62CD8 VA: 0x7F66CD8 Slot: 14
	public virtual IAsyncResult BeginInvoke(SkeletonRendererInstruction instruction, AsyncCallback callback, object object) { }

	// RVA: 0x7F66CF8 Offset: 0x7F62CF8 VA: 0x7F66CF8 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Spine.Unity
[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer), typeof(RectTransform))]
[DisallowMultipleComponent]
[AddComponentMenu("Spine/SkeletonGraphic (Unity UI Canvas)")]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonGraphic-Component")]
public class SkeletonGraphic : MaskableGraphic, ISkeletonComponent, ISpineComponent, IAnimationStateComponent, ISkeletonAnimation, IHasSkeletonDataAsset // TypeDefIndex: 24130
{
	// Fields
	public SkeletonDataAsset skeletonDataAsset; // 0xD8
	public Material additiveMaterial; // 0xE0
	public Material multiplyMaterial; // 0xE8
	public Material screenMaterial; // 0xF0
	[SpineSkin("", "skeletonDataAsset", True, False, True)]
	public string initialSkinName; // 0xF8
	public bool initialFlipX; // 0x100
	public bool initialFlipY; // 0x101
	[SpineAnimation("", "skeletonDataAsset", True, False)]
	public string startingAnimation; // 0x108
	public bool startingLoop; // 0x110
	public float timeScale; // 0x114
	public bool freeze; // 0x118
	protected float meshScale; // 0x11C
	public SkeletonGraphic.LayoutMode layoutScaleMode; // 0x120
	[SerializeField]
	protected Vector2 referenceSize; // 0x124
	[SerializeField]
	protected float referenceScale; // 0x12C
	protected const bool EditReferenceRect = False;
	protected UpdateMode updateMode; // 0x130
	public UpdateMode updateWhenInvisible; // 0x134
	public bool allowMultipleCanvasRenderers; // 0x138
	public List<CanvasRenderer> canvasRenderers; // 0x140
	protected List<SkeletonSubmeshGraphic> submeshGraphics; // 0x148
	protected int usedRenderersCount; // 0x150
	public const string SeparatorPartGameObjectName = "Part";
	[SerializeField]
	[SpineSlot("", "", False, True, False)]
	protected string[] separatorSlotNames; // 0x158
	public readonly List<Slot> separatorSlots; // 0x160
	public bool enableSeparatorSlots; // 0x168
	[SerializeField]
	protected List<Transform> separatorParts; // 0x170
	public bool updateSeparatorPartLocation; // 0x178
	public bool updateSeparatorPartScale; // 0x179
	private bool wasUpdatedAfterInit; // 0x17A
	private bool requiresInstructionUpate; // 0x17B
	private Texture baseTexture; // 0x180
	public bool disableMeshAssignmentOnOverride; // 0x188
	[CompilerGenerated]
	private SkeletonGraphic.MeshAssignmentDelegateSingle assignMeshOverrideSingle; // 0x190
	[CompilerGenerated]
	private SkeletonGraphic.MeshAssignmentDelegateMultiple assignMeshOverrideMultiple; // 0x198
	private readonly Dictionary<Texture, Texture> customTextureOverride; // 0x1A0
	private readonly Dictionary<Texture, Material> customMaterialOverride; // 0x1A8
	private Texture overrideTexture; // 0x1B0
	protected Skeleton skeleton; // 0x1B8
	[CompilerGenerated]
	private SkeletonGraphic.SkeletonRendererDelegate OnRebuild; // 0x1C0
	[CompilerGenerated]
	private SkeletonGraphic.InstructionDelegate OnInstructionsPrepared; // 0x1C8
	[CompilerGenerated]
	private SkeletonGraphic.SkeletonRendererDelegate OnMeshAndMaterialsUpdated; // 0x1D0
	protected AnimationState state; // 0x1D8
	[SerializeField]
	protected MeshGenerator meshGenerator; // 0x1E0
	private DoubleBuffered<MeshRendererBuffers.SmartMesh> meshBuffers; // 0x1E8
	private SkeletonRendererInstruction currentInstructions; // 0x1F0
	private readonly ExposedList<Mesh> meshes; // 0x1F8
	private readonly ExposedList<Material> usedMaterials; // 0x200
	private readonly ExposedList<Texture> usedTextures; // 0x208
	[CompilerGenerated]
	private ISkeletonAnimationDelegate OnAnimationRebuild; // 0x210
	[CompilerGenerated]
	private UpdateBonesDelegate BeforeApply; // 0x218
	[CompilerGenerated]
	private UpdateBonesDelegate UpdateLocal; // 0x220
	[CompilerGenerated]
	private UpdateBonesDelegate UpdateWorld; // 0x228
	[CompilerGenerated]
	private UpdateBonesDelegate UpdateComplete; // 0x230
	[SerializeField]
	protected UpdateTiming updateTiming; // 0x238
	[SerializeField]
	protected bool unscaledTime; // 0x23C
	[CompilerGenerated]
	private MeshGeneratorDelegate OnPostProcessVertices; // 0x240

	// Properties
	public SkeletonDataAsset SkeletonDataAsset { get; }
	public float MeshScale { get; }
	public UpdateMode UpdateMode { get; set; }
	public List<Transform> SeparatorParts { get; }
	public Dictionary<Texture, Texture> CustomTextureOverride { get; }
	public Dictionary<Texture, Material> CustomMaterialOverride { get; }
	public Texture OverrideTexture { get; set; }
	public override Texture mainTexture { get; }
	public Skeleton Skeleton { get; set; }
	public SkeletonData SkeletonData { get; }
	public bool IsValid { get; }
	public AnimationState AnimationState { get; }
	public MeshGenerator MeshGenerator { get; }
	public ExposedList<Mesh> MeshesMultipleCanvasRenderers { get; }
	public ExposedList<Material> MaterialsMultipleCanvasRenderers { get; }
	public ExposedList<Texture> TexturesMultipleCanvasRenderers { get; }
	public UpdateTiming UpdateTiming { get; set; }
	public bool UnscaledTime { get; set; }

	// Methods

	// RVA: 0x7F61378 Offset: 0x7F5D378 VA: 0x7F61378 Slot: 81
	public SkeletonDataAsset get_SkeletonDataAsset() { }

	// RVA: 0x7F61380 Offset: 0x7F5D380 VA: 0x7F61380
	public float get_MeshScale() { }

	// RVA: 0x7F61388 Offset: 0x7F5D388 VA: 0x7F61388
	public UpdateMode get_UpdateMode() { }

	// RVA: 0x7F61390 Offset: 0x7F5D390 VA: 0x7F61390
	public void set_UpdateMode(UpdateMode value) { }

	// RVA: 0x7F61398 Offset: 0x7F5D398 VA: 0x7F61398
	public List<Transform> get_SeparatorParts() { }

	// RVA: 0x7F613A0 Offset: 0x7F5D3A0 VA: 0x7F613A0
	public static SkeletonGraphic NewSkeletonGraphicGameObject(SkeletonDataAsset skeletonDataAsset, Transform parent, Material material) { }

	// RVA: 0x7F614A0 Offset: 0x7F5D4A0 VA: 0x7F614A0
	public static SkeletonGraphic AddSkeletonGraphicComponent(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, Material material) { }

	[CompilerGenerated]
	// RVA: 0x7F615DC Offset: 0x7F5D5DC VA: 0x7F615DC
	private void add_assignMeshOverrideSingle(SkeletonGraphic.MeshAssignmentDelegateSingle value) { }

	[CompilerGenerated]
	// RVA: 0x7F6167C Offset: 0x7F5D67C VA: 0x7F6167C
	private void remove_assignMeshOverrideSingle(SkeletonGraphic.MeshAssignmentDelegateSingle value) { }

	[CompilerGenerated]
	// RVA: 0x7F6171C Offset: 0x7F5D71C VA: 0x7F6171C
	private void add_assignMeshOverrideMultiple(SkeletonGraphic.MeshAssignmentDelegateMultiple value) { }

	[CompilerGenerated]
	// RVA: 0x7F617BC Offset: 0x7F5D7BC VA: 0x7F617BC
	private void remove_assignMeshOverrideMultiple(SkeletonGraphic.MeshAssignmentDelegateMultiple value) { }

	// RVA: 0x7F6185C Offset: 0x7F5D85C VA: 0x7F6185C
	public void add_AssignMeshOverrideSingleRenderer(SkeletonGraphic.MeshAssignmentDelegateSingle value) { }

	// RVA: 0x7F61890 Offset: 0x7F5D890 VA: 0x7F61890
	public void remove_AssignMeshOverrideSingleRenderer(SkeletonGraphic.MeshAssignmentDelegateSingle value) { }

	// RVA: 0x7F618C4 Offset: 0x7F5D8C4 VA: 0x7F618C4
	public void add_AssignMeshOverrideMultipleRenderers(SkeletonGraphic.MeshAssignmentDelegateMultiple value) { }

	// RVA: 0x7F618F8 Offset: 0x7F5D8F8 VA: 0x7F618F8
	public void remove_AssignMeshOverrideMultipleRenderers(SkeletonGraphic.MeshAssignmentDelegateMultiple value) { }

	// RVA: 0x7F6192C Offset: 0x7F5D92C VA: 0x7F6192C
	public Dictionary<Texture, Texture> get_CustomTextureOverride() { }

	// RVA: 0x7F61934 Offset: 0x7F5D934 VA: 0x7F61934
	public Dictionary<Texture, Material> get_CustomMaterialOverride() { }

	// RVA: 0x7F6193C Offset: 0x7F5D93C VA: 0x7F6193C
	public Texture get_OverrideTexture() { }

	// RVA: 0x7F61944 Offset: 0x7F5D944 VA: 0x7F61944
	public void set_OverrideTexture(Texture value) { }

	// RVA: 0x7F619A0 Offset: 0x7F5D9A0 VA: 0x7F619A0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x7F61A18 Offset: 0x7F5DA18 VA: 0x7F61A18 Slot: 4
	protected override void Awake() { }

	// RVA: 0x7F61E10 Offset: 0x7F5DE10 VA: 0x7F61E10 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x7F61F48 Offset: 0x7F5DF48 VA: 0x7F61F48 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x7F62228 Offset: 0x7F5E228 VA: 0x7F62228 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x7F62380 Offset: 0x7F5E380 VA: 0x7F62380 Slot: 82
	public virtual void Update() { }

	// RVA: 0x7F623D8 Offset: 0x7F5E3D8 VA: 0x7F623D8 Slot: 83
	protected virtual void FixedUpdate() { }

	// RVA: 0x7F62430 Offset: 0x7F5E430 VA: 0x7F62430 Slot: 84
	public virtual void Update(float deltaTime) { }

	// RVA: 0x7F61B14 Offset: 0x7F5DB14 VA: 0x7F61B14
	protected void SyncSubmeshGraphicsWithCanvasRenderers() { }

	// RVA: 0x7F6249C Offset: 0x7F5E49C VA: 0x7F6249C
	protected void UpdateAnimationStatus(float deltaTime) { }

	// RVA: 0x7F624C4 Offset: 0x7F5E4C4 VA: 0x7F624C4
	protected void ApplyAnimation() { }

	// RVA: 0x7F62528 Offset: 0x7F5E528 VA: 0x7F62528
	public void AfterAnimationApplied() { }

	// RVA: 0x7F625B4 Offset: 0x7F5E5B4 VA: 0x7F625B4
	public void LateUpdate() { }

	// RVA: 0x7F62624 Offset: 0x7F5E624 VA: 0x7F62624
	protected void OnCullStateChanged(bool culled) { }

	// RVA: 0x7F62648 Offset: 0x7F5E648 VA: 0x7F62648
	public void OnBecameVisible() { }

	// RVA: 0x7F6263C Offset: 0x7F5E63C VA: 0x7F6263C
	public void OnBecameInvisible() { }

	// RVA: 0x7F62654 Offset: 0x7F5E654 VA: 0x7F62654
	public void ReapplySeparatorSlotNames() { }

	// RVA: 0x7F582E4 Offset: 0x7F542E4 VA: 0x7F582E4 Slot: 78
	public Skeleton get_Skeleton() { }

	// RVA: 0x7F629F4 Offset: 0x7F5E9F4 VA: 0x7F629F4
	public void set_Skeleton(Skeleton value) { }

	// RVA: 0x7F62A0C Offset: 0x7F5EA0C VA: 0x7F62A0C
	public SkeletonData get_SkeletonData() { }

	// RVA: 0x7F58318 Offset: 0x7F54318 VA: 0x7F58318
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x7F5A45C Offset: 0x7F5645C VA: 0x7F5A45C
	public void add_OnRebuild(SkeletonGraphic.SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F5A3BC Offset: 0x7F563BC VA: 0x7F5A3BC
	public void remove_OnRebuild(SkeletonGraphic.SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F62A38 Offset: 0x7F5EA38 VA: 0x7F62A38
	public void add_OnInstructionsPrepared(SkeletonGraphic.InstructionDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F62AD8 Offset: 0x7F5EAD8 VA: 0x7F62AD8
	public void remove_OnInstructionsPrepared(SkeletonGraphic.InstructionDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F62B78 Offset: 0x7F5EB78 VA: 0x7F62B78
	public void add_OnMeshAndMaterialsUpdated(SkeletonGraphic.SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F62C18 Offset: 0x7F5EC18 VA: 0x7F62C18
	public void remove_OnMeshAndMaterialsUpdated(SkeletonGraphic.SkeletonRendererDelegate value) { }

	// RVA: 0x7F62CB8 Offset: 0x7F5ECB8 VA: 0x7F62CB8 Slot: 67
	public AnimationState get_AnimationState() { }

	// RVA: 0x7F62CD4 Offset: 0x7F5ECD4 VA: 0x7F62CD4
	public MeshGenerator get_MeshGenerator() { }

	// RVA: 0x7F62CDC Offset: 0x7F5ECDC VA: 0x7F62CDC
	public ExposedList<Mesh> get_MeshesMultipleCanvasRenderers() { }

	// RVA: 0x7F62CE4 Offset: 0x7F5ECE4 VA: 0x7F62CE4
	public ExposedList<Material> get_MaterialsMultipleCanvasRenderers() { }

	// RVA: 0x7F62CEC Offset: 0x7F5ECEC VA: 0x7F62CEC
	public ExposedList<Texture> get_TexturesMultipleCanvasRenderers() { }

	// RVA: 0x7F62CF4 Offset: 0x7F5ECF4 VA: 0x7F62CF4
	public Mesh GetLastMesh() { }

	// RVA: 0x7F62D50 Offset: 0x7F5ED50 VA: 0x7F62D50
	public bool MatchRectTransformWithBounds() { }

	// RVA: 0x7F62DC8 Offset: 0x7F5EDC8 VA: 0x7F62DC8
	protected bool MatchRectTransformSingleRenderer() { }

	// RVA: 0x7F62EE4 Offset: 0x7F5EEE4 VA: 0x7F62EE4
	protected bool MatchRectTransformMultipleRenderers() { }

	// RVA: 0x7F63208 Offset: 0x7F5F208 VA: 0x7F63208
	private void SetRectTransformBounds(Bounds combinedBounds) { }

	// RVA: 0x7F6357C Offset: 0x7F5F57C VA: 0x7F6357C
	public static void SetRectTransformSize(Graphic target, Vector2 size) { }

	// RVA: 0x7F635B0 Offset: 0x7F5F5B0 VA: 0x7F635B0
	public static void SetRectTransformSize(RectTransform targetRectTransform, Vector2 size) { }

	[CompilerGenerated]
	// RVA: 0x7F63730 Offset: 0x7F5F730 VA: 0x7F63730 Slot: 70
	public void add_OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F637D0 Offset: 0x7F5F7D0 VA: 0x7F637D0 Slot: 71
	public void remove_OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F63870 Offset: 0x7F5F870 VA: 0x7F63870
	public void add_BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F63910 Offset: 0x7F5F910 VA: 0x7F63910
	public void remove_BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F639B0 Offset: 0x7F5F9B0 VA: 0x7F639B0 Slot: 72
	public void add_UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F63A50 Offset: 0x7F5FA50 VA: 0x7F63A50 Slot: 73
	public void remove_UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F63AF0 Offset: 0x7F5FAF0 VA: 0x7F63AF0 Slot: 74
	public void add_UpdateWorld(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F63B90 Offset: 0x7F5FB90 VA: 0x7F63B90 Slot: 75
	public void remove_UpdateWorld(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F63C30 Offset: 0x7F5FC30 VA: 0x7F63C30 Slot: 76
	public void add_UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F63CD0 Offset: 0x7F5FCD0 VA: 0x7F63CD0 Slot: 77
	public void remove_UpdateComplete(UpdateBonesDelegate value) { }

	// RVA: 0x7F63D70 Offset: 0x7F5FD70 VA: 0x7F63D70 Slot: 79
	public UpdateTiming get_UpdateTiming() { }

	// RVA: 0x7F63D78 Offset: 0x7F5FD78 VA: 0x7F63D78 Slot: 80
	public void set_UpdateTiming(UpdateTiming value) { }

	// RVA: 0x7F63D80 Offset: 0x7F5FD80 VA: 0x7F63D80 Slot: 68
	public bool get_UnscaledTime() { }

	// RVA: 0x7F63D88 Offset: 0x7F5FD88 VA: 0x7F63D88 Slot: 69
	public void set_UnscaledTime(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7F63D94 Offset: 0x7F5FD94 VA: 0x7F63D94
	public void add_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F63E34 Offset: 0x7F5FE34 VA: 0x7F63E34
	public void remove_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	// RVA: 0x7F61E2C Offset: 0x7F5DE2C VA: 0x7F61E2C
	public void Clear() { }

	// RVA: 0x7F640FC Offset: 0x7F600FC VA: 0x7F640FC
	public void TrimRenderers() { }

	// RVA: 0x7F5A504 Offset: 0x7F56504 VA: 0x7F5A504
	public void Initialize(bool overwrite) { }

	// RVA: 0x7F61FE0 Offset: 0x7F5DFE0 VA: 0x7F61FE0
	public void PrepareInstructionsAndRenderers(bool isInRebuild = False) { }

	// RVA: 0x7F62DAC Offset: 0x7F5EDAC VA: 0x7F62DAC
	public void UpdateMesh() { }

	// RVA: 0x7F62188 Offset: 0x7F5E188 VA: 0x7F62188
	public void UpdateMeshToInstructions() { }

	// RVA: 0x7F662E8 Offset: 0x7F622E8 VA: 0x7F662E8
	public bool HasMultipleSubmeshInstructions() { }

	// RVA: 0x7F64430 Offset: 0x7F60430 VA: 0x7F64430
	protected void InitMeshBuffers() { }

	// RVA: 0x7F64064 Offset: 0x7F60064 VA: 0x7F64064
	protected void DisposeMeshBuffers() { }

	// RVA: 0x7F6553C Offset: 0x7F6153C VA: 0x7F6553C
	protected void UpdateMeshSingleCanvasRenderer(SkeletonRendererInstruction currentInstructions) { }

	// RVA: 0x7F6595C Offset: 0x7F6195C VA: 0x7F6595C
	protected void UpdateMaterialsMultipleCanvasRenderers(SkeletonRendererInstruction currentInstructions) { }

	// RVA: 0x7F65DB8 Offset: 0x7F61DB8 VA: 0x7F65DB8
	protected void UpdateMeshMultipleCanvasRenderers(SkeletonRendererInstruction currentInstructions) { }

	// RVA: 0x7F645CC Offset: 0x7F605CC VA: 0x7F645CC
	protected void EnsureCanvasRendererCount(int targetCount) { }

	// RVA: 0x7F64EF8 Offset: 0x7F60EF8 VA: 0x7F64EF8
	protected void PrepareRendererGameObjects(SkeletonRendererInstruction currentInstructions, bool isInRebuild = False) { }

	// RVA: 0x7F64500 Offset: 0x7F60500 VA: 0x7F64500
	protected void DisableUnusedCanvasRenderers(int usedCount, bool isInRebuild = False) { }

	// RVA: 0x7F64974 Offset: 0x7F60974 VA: 0x7F64974
	protected void EnsureMeshesCount(int targetCount) { }

	// RVA: 0x7F64A24 Offset: 0x7F60A24 VA: 0x7F64A24
	protected void EnsureUsedTexturesAndMaterialsCount(int targetCount) { }

	// RVA: 0x7F63ED4 Offset: 0x7F5FED4 VA: 0x7F63ED4
	protected void DestroyMeshes() { }

	// RVA: 0x7F64B18 Offset: 0x7F60B18 VA: 0x7F64B18
	protected void EnsureSeparatorPartCount() { }

	// RVA: 0x7F627E8 Offset: 0x7F5E7E8 VA: 0x7F627E8
	protected void UpdateSeparatorPartParents() { }

	// RVA: 0x7F66358 Offset: 0x7F62358 VA: 0x7F66358
	protected float GetLayoutScale(SkeletonGraphic.LayoutMode mode) { }

	// RVA: 0x7F663D0 Offset: 0x7F623D0 VA: 0x7F663D0
	private Vector2 GetCurrentRectSize() { }

	// RVA: 0x7F663FC Offset: 0x7F623FC VA: 0x7F663FC
	public void .ctor() { }
}

// Namespace: 
public sealed class SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate : MulticastDelegate // TypeDefIndex: 24131
{
	// Methods

	// RVA: 0x7F6A490 Offset: 0x7F66490 VA: 0x7F6A490
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F6A59C Offset: 0x7F6659C VA: 0x7F6A59C Slot: 13
	public virtual void Invoke(Animation clip, int layerIndex, float weight, float time, float lastTime, bool playsBackward) { }

	// RVA: 0x7F6A5B4 Offset: 0x7F665B4 VA: 0x7F6A5B4 Slot: 14
	public virtual IAsyncResult BeginInvoke(Animation clip, int layerIndex, float weight, float time, float lastTime, bool playsBackward, AsyncCallback callback, object object) { }

	// RVA: 0x7F6A6E0 Offset: 0x7F666E0 VA: 0x7F6A6E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public enum SkeletonMecanim.MecanimTranslator.MixMode // TypeDefIndex: 24132
{
	// Fields
	public int value__; // 0x0
	public const SkeletonMecanim.MecanimTranslator.MixMode AlwaysMix = 0;
	public const SkeletonMecanim.MecanimTranslator.MixMode MixNext = 1;
	public const SkeletonMecanim.MecanimTranslator.MixMode Hard = 2;
}

// Namespace: 
protected class SkeletonMecanim.MecanimTranslator.ClipInfos // TypeDefIndex: 24133
{
	// Fields
	public bool isInterruptionActive; // 0x10
	public bool isLastFrameOfInterruption; // 0x11
	public int clipInfoCount; // 0x14
	public int nextClipInfoCount; // 0x18
	public int interruptingClipInfoCount; // 0x1C
	public readonly List<AnimatorClipInfo> clipInfos; // 0x20
	public readonly List<AnimatorClipInfo> nextClipInfos; // 0x28
	public readonly List<AnimatorClipInfo> interruptingClipInfos; // 0x30
	public AnimatorStateInfo stateInfo; // 0x38
	public AnimatorStateInfo nextStateInfo; // 0x5C
	public AnimatorStateInfo interruptingStateInfo; // 0x80
	public float interruptingClipTimeAddition; // 0xA4

	// Methods

	// RVA: 0x7F6A3C0 Offset: 0x7F663C0 VA: 0x7F6A3C0
	public void .ctor() { }
}

// Namespace: 
private class SkeletonMecanim.MecanimTranslator.AnimationClipEqualityComparer : IEqualityComparer<AnimationClip> // TypeDefIndex: 24134
{
	// Fields
	internal static readonly IEqualityComparer<AnimationClip> Instance; // 0x0

	// Methods

	// RVA: 0x7F6A6EC Offset: 0x7F666EC VA: 0x7F6A6EC Slot: 4
	public bool Equals(AnimationClip x, AnimationClip y) { }

	// RVA: 0x7F6A734 Offset: 0x7F66734 VA: 0x7F6A734 Slot: 5
	public int GetHashCode(AnimationClip o) { }

	// RVA: 0x7F6A74C Offset: 0x7F6674C VA: 0x7F6A74C
	public void .ctor() { }

	// RVA: 0x7F6A754 Offset: 0x7F66754 VA: 0x7F6A754
	private static void .cctor() { }
}

// Namespace: 
private class SkeletonMecanim.MecanimTranslator.IntEqualityComparer : IEqualityComparer<int> // TypeDefIndex: 24135
{
	// Fields
	internal static readonly IEqualityComparer<int> Instance; // 0x0

	// Methods

	// RVA: 0x7F6A7BC Offset: 0x7F667BC VA: 0x7F6A7BC Slot: 4
	public bool Equals(int x, int y) { }

	// RVA: 0x7F6A7C8 Offset: 0x7F667C8 VA: 0x7F6A7C8 Slot: 5
	public int GetHashCode(int o) { }

	// RVA: 0x7F6A7D0 Offset: 0x7F667D0 VA: 0x7F6A7D0
	public void .ctor() { }

	// RVA: 0x7F6A7D8 Offset: 0x7F667D8 VA: 0x7F6A7D8
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class SkeletonMecanim.MecanimTranslator // TypeDefIndex: 24136
{
	// Fields
	private const float WeightEpsilon = 0.0001;
	public bool autoReset; // 0x10
	public bool useCustomMixMode; // 0x11
	public SkeletonMecanim.MecanimTranslator.MixMode[] layerMixModes; // 0x18
	public MixBlend[] layerBlendModes; // 0x20
	[CompilerGenerated]
	private SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate _OnClipApplied; // 0x28
	private readonly Dictionary<int, Animation> animationTable; // 0x30
	private readonly Dictionary<AnimationClip, int> clipNameHashCodeTable; // 0x38
	private readonly List<Animation> previousAnimations; // 0x40
	protected SkeletonMecanim.MecanimTranslator.ClipInfos[] layerClipInfos; // 0x48
	private Animator animator; // 0x50

	// Properties
	public Animator Animator { get; }
	public int MecanimLayerCount { get; }
	public string[] MecanimLayerNames { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F69090 Offset: 0x7F65090 VA: 0x7F69090
	protected void add__OnClipApplied(SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F6912C Offset: 0x7F6512C VA: 0x7F6912C
	protected void remove__OnClipApplied(SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value) { }

	// RVA: 0x7F691C8 Offset: 0x7F651C8 VA: 0x7F691C8
	public void add_OnClipApplied(SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value) { }

	// RVA: 0x7F691CC Offset: 0x7F651CC VA: 0x7F691CC
	public void remove_OnClipApplied(SkeletonMecanim.MecanimTranslator.OnClipAppliedDelegate value) { }

	// RVA: 0x7F691D0 Offset: 0x7F651D0 VA: 0x7F691D0
	public Animator get_Animator() { }

	// RVA: 0x7F691D8 Offset: 0x7F651D8 VA: 0x7F691D8
	public int get_MecanimLayerCount() { }

	// RVA: 0x7F6925C Offset: 0x7F6525C VA: 0x7F6925C
	public string[] get_MecanimLayerNames() { }

	// RVA: 0x7F67A78 Offset: 0x7F63A78 VA: 0x7F67A78
	public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset) { }

	// RVA: 0x7F694E8 Offset: 0x7F654E8 VA: 0x7F694E8
	private bool ApplyAnimation(Skeleton skeleton, AnimatorClipInfo info, AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, MixBlend layerBlendMode, bool useClipWeight1 = False) { }

	// RVA: 0x7F69938 Offset: 0x7F65938 VA: 0x7F69938
	private bool ApplyInterruptionAnimation(Skeleton skeleton, bool interpolateWeightTo1, AnimatorClipInfo info, AnimatorStateInfo stateInfo, int layerIndex, float layerWeight, MixBlend layerBlendMode, float interruptingClipTimeAddition, bool useClipWeight1 = False) { }

	// RVA: 0x7F6984C Offset: 0x7F6584C VA: 0x7F6984C
	private void OnClipAppliedCallback(Animation clip, AnimatorStateInfo stateInfo, int layerIndex, float time, bool isLooping, float weight) { }

	// RVA: 0x7F67E14 Offset: 0x7F63E14 VA: 0x7F67E14
	public void Apply(Skeleton skeleton) { }

	// RVA: 0x7F6A168 Offset: 0x7F66168 VA: 0x7F6A168
	public KeyValuePair<Animation, float> GetActiveAnimationAndTime(int layer) { }

	// RVA: 0x7F697E0 Offset: 0x7F657E0 VA: 0x7F697E0
	private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed) { }

	// RVA: 0x7F6A370 Offset: 0x7F66370 VA: 0x7F6A370
	private static float ToSpineAnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed) { }

	// RVA: 0x7F69B6C Offset: 0x7F65B6C VA: 0x7F69B6C
	private void InitClipInfosForLayers() { }

	// RVA: 0x7F69398 Offset: 0x7F65398 VA: 0x7F69398
	private void ClearClipInfosForLayers() { }

	// RVA: 0x7F6A10C Offset: 0x7F6610C VA: 0x7F6A10C
	private SkeletonMecanim.MecanimTranslator.MixMode GetMixMode(int layer, MixBlend layerBlendMode) { }

	// RVA: 0x7F69CC0 Offset: 0x7F65CC0 VA: 0x7F69CC0
	private void GetStateUpdatesFromAnimator(int layer) { }

	// RVA: 0x7F69FC8 Offset: 0x7F65FC8 VA: 0x7F69FC8
	private void GetAnimatorClipInfos(int layer, out bool isInterruptionActive, out int clipInfoCount, out int nextClipInfoCount, out int interruptingClipInfoCount, out IList<AnimatorClipInfo> clipInfo, out IList<AnimatorClipInfo> nextClipInfo, out IList<AnimatorClipInfo> interruptingClipInfo, out bool shallInterpolateWeightTo1) { }

	// RVA: 0x7F6A080 Offset: 0x7F66080 VA: 0x7F6A080
	private void GetAnimatorStateInfos(int layer, out bool isInterruptionActive, out AnimatorStateInfo stateInfo, out AnimatorStateInfo nextStateInfo, out AnimatorStateInfo interruptingStateInfo, out float interruptingClipTimeAddition) { }

	// RVA: 0x7F696EC Offset: 0x7F656EC VA: 0x7F696EC
	private Animation GetAnimation(AnimationClip clip) { }

	// RVA: 0x7F67840 Offset: 0x7F63840 VA: 0x7F67840
	public void .ctor() { }
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonMecanim-Component")]
[RequireComponent(typeof(Animator))]
public class SkeletonMecanim : SkeletonRenderer, ISkeletonAnimation, ISpineComponent // TypeDefIndex: 24137
{
	// Fields
	[SerializeField]
	protected SkeletonMecanim.MecanimTranslator translator; // 0xE8
	private bool wasUpdatedAfterInit; // 0xF0
	[CompilerGenerated]
	private ISkeletonAnimationDelegate _OnAnimationRebuild; // 0xF8
	[CompilerGenerated]
	private UpdateBonesDelegate _BeforeApply; // 0x100
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateLocal; // 0x108
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateWorld; // 0x110
	[CompilerGenerated]
	private UpdateBonesDelegate _UpdateComplete; // 0x118
	[SerializeField]
	protected UpdateTiming updateTiming; // 0x120

	// Properties
	public SkeletonMecanim.MecanimTranslator Translator { get; }
	public UpdateTiming UpdateTiming { get; set; }

	// Methods

	// RVA: 0x7F66D04 Offset: 0x7F62D04 VA: 0x7F66D04
	public SkeletonMecanim.MecanimTranslator get_Translator() { }

	[CompilerGenerated]
	// RVA: 0x7F66D0C Offset: 0x7F62D0C VA: 0x7F66D0C
	protected void add__OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F66DA8 Offset: 0x7F62DA8 VA: 0x7F66DA8
	protected void remove__OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F66E44 Offset: 0x7F62E44 VA: 0x7F66E44
	protected void add__BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F66EE4 Offset: 0x7F62EE4 VA: 0x7F66EE4
	protected void remove__BeforeApply(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F66F84 Offset: 0x7F62F84 VA: 0x7F66F84
	protected void add__UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F67024 Offset: 0x7F63024 VA: 0x7F67024
	protected void remove__UpdateLocal(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F670C4 Offset: 0x7F630C4 VA: 0x7F670C4
	protected void add__UpdateWorld(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F67164 Offset: 0x7F63164 VA: 0x7F67164
	protected void remove__UpdateWorld(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F67204 Offset: 0x7F63204 VA: 0x7F67204
	protected void add__UpdateComplete(UpdateBonesDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F672A4 Offset: 0x7F632A4 VA: 0x7F672A4
	protected void remove__UpdateComplete(UpdateBonesDelegate value) { }

	// RVA: 0x7F67344 Offset: 0x7F63344 VA: 0x7F67344 Slot: 13
	public void add_OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	// RVA: 0x7F67348 Offset: 0x7F63348 VA: 0x7F67348 Slot: 14
	public void remove_OnAnimationRebuild(ISkeletonAnimationDelegate value) { }

	// RVA: 0x7F6734C Offset: 0x7F6334C VA: 0x7F6734C
	public void add_BeforeApply(UpdateBonesDelegate value) { }

	// RVA: 0x7F67350 Offset: 0x7F63350 VA: 0x7F67350
	public void remove_BeforeApply(UpdateBonesDelegate value) { }

	// RVA: 0x7F67354 Offset: 0x7F63354 VA: 0x7F67354 Slot: 15
	public void add_UpdateLocal(UpdateBonesDelegate value) { }

	// RVA: 0x7F67358 Offset: 0x7F63358 VA: 0x7F67358 Slot: 16
	public void remove_UpdateLocal(UpdateBonesDelegate value) { }

	// RVA: 0x7F6735C Offset: 0x7F6335C VA: 0x7F6735C Slot: 17
	public void add_UpdateWorld(UpdateBonesDelegate value) { }

	// RVA: 0x7F67360 Offset: 0x7F63360 VA: 0x7F67360 Slot: 18
	public void remove_UpdateWorld(UpdateBonesDelegate value) { }

	// RVA: 0x7F67364 Offset: 0x7F63364 VA: 0x7F67364 Slot: 19
	public void add_UpdateComplete(UpdateBonesDelegate value) { }

	// RVA: 0x7F67368 Offset: 0x7F63368 VA: 0x7F67368 Slot: 20
	public void remove_UpdateComplete(UpdateBonesDelegate value) { }

	// RVA: 0x7F6736C Offset: 0x7F6336C VA: 0x7F6736C Slot: 22
	public UpdateTiming get_UpdateTiming() { }

	// RVA: 0x7F67374 Offset: 0x7F63374 VA: 0x7F67374 Slot: 23
	public void set_UpdateTiming(UpdateTiming value) { }

	// RVA: 0x7F6737C Offset: 0x7F6337C VA: 0x7F6737C Slot: 9
	public override void Initialize(bool overwrite, bool quiet = False) { }

	// RVA: 0x7F67CE0 Offset: 0x7F63CE0 VA: 0x7F67CE0 Slot: 24
	public virtual void Update() { }

	// RVA: 0x7F67D2C Offset: 0x7F63D2C VA: 0x7F67D2C Slot: 25
	public virtual void FixedUpdate() { }

	// RVA: 0x7F67D10 Offset: 0x7F63D10 VA: 0x7F67D10
	protected void UpdateAnimation() { }

	// RVA: 0x7F67D5C Offset: 0x7F63D5C VA: 0x7F67D5C
	protected void ApplyAnimation() { }

	// RVA: 0x7F68CFC Offset: 0x7F64CFC VA: 0x7F68CFC Slot: 10
	public override void LateUpdate() { }

	// RVA: 0x7F68D74 Offset: 0x7F64D74 VA: 0x7F68D74 Slot: 12
	public override void OnBecameVisible() { }

	// RVA: 0x7F68DD8 Offset: 0x7F64DD8 VA: 0x7F68DD8
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class SkeletonRenderer.SpriteMaskInteractionMaterials // TypeDefIndex: 24138
{
	// Fields
	public Material[] materialsMaskDisabled; // 0x10
	public Material[] materialsInsideMask; // 0x18
	public Material[] materialsOutsideMask; // 0x20

	// Properties
	public bool AnyMaterialCreated { get; }

	// Methods

	// RVA: 0x7F6EBA8 Offset: 0x7F6ABA8 VA: 0x7F6EBA8
	public bool get_AnyMaterialCreated() { }

	// RVA: 0x7F6EBF4 Offset: 0x7F6ABF4 VA: 0x7F6EBF4
	public void .ctor() { }
}

// Namespace: 
public sealed class SkeletonRenderer.InstructionDelegate : MulticastDelegate // TypeDefIndex: 24139
{
	// Methods

	// RVA: 0x7F70114 Offset: 0x7F6C114 VA: 0x7F70114
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F7021C Offset: 0x7F6C21C VA: 0x7F7021C Slot: 13
	public virtual void Invoke(SkeletonRendererInstruction instruction) { }

	// RVA: 0x7F70230 Offset: 0x7F6C230 VA: 0x7F70230 Slot: 14
	public virtual IAsyncResult BeginInvoke(SkeletonRendererInstruction instruction, AsyncCallback callback, object object) { }

	// RVA: 0x7F70250 Offset: 0x7F6C250 VA: 0x7F70250 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class SkeletonRenderer.SkeletonRendererDelegate : MulticastDelegate // TypeDefIndex: 24140
{
	// Methods

	// RVA: 0x7F7025C Offset: 0x7F6C25C VA: 0x7F7025C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F70364 Offset: 0x7F6C364 VA: 0x7F70364 Slot: 13
	public virtual void Invoke(SkeletonRenderer skeletonRenderer) { }

	// RVA: 0x7F70378 Offset: 0x7F6C378 VA: 0x7F70378 Slot: 14
	public virtual IAsyncResult BeginInvoke(SkeletonRenderer skeletonRenderer, AsyncCallback callback, object object) { }

	// RVA: 0x7F70398 Offset: 0x7F6C398 VA: 0x7F70398 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SkeletonRenderer.<>c__DisplayClass76_0 // TypeDefIndex: 24141
{
	// Fields
	public string startsWith; // 0x10

	// Methods

	// RVA: 0x7F6F554 Offset: 0x7F6B554 VA: 0x7F6F554
	public void .ctor() { }

	// RVA: 0x7F703A4 Offset: 0x7F6C3A4 VA: 0x7F703A4
	internal bool <FindAndApplySeparatorSlots>b__0(string slotName) { }
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRenderer-Component")]
[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteAlways]
public class SkeletonRenderer : MonoBehaviour, ISkeletonComponent, ISpineComponent, IHasSkeletonDataAsset // TypeDefIndex: 24142
{
	// Fields
	public SkeletonDataAsset skeletonDataAsset; // 0x20
	[SpineSkin("", "", True, False, True)]
	public string initialSkinName; // 0x28
	public bool initialFlipX; // 0x30
	public bool initialFlipY; // 0x31
	protected UpdateMode updateMode; // 0x34
	public UpdateMode updateWhenInvisible; // 0x38
	[SerializeField]
	[SpineSlot("", "", False, True, False)]
	[FormerlySerializedAs("submeshSeparators")]
	protected string[] separatorSlotNames; // 0x40
	public readonly List<Slot> separatorSlots; // 0x48
	[Range(-0.1, 0)]
	public float zSpacing; // 0x50
	public bool useClipping; // 0x54
	public bool immutableTriangles; // 0x55
	public bool pmaVertexColors; // 0x56
	public bool clearStateOnDisable; // 0x57
	public bool tintBlack; // 0x58
	public bool singleSubmesh; // 0x59
	public bool fixDrawOrder; // 0x5A
	[FormerlySerializedAs("calculateNormals")]
	public bool addNormals; // 0x5B
	public bool calculateTangents; // 0x5C
	public SpriteMaskInteraction maskInteraction; // 0x60
	public SkeletonRenderer.SpriteMaskInteractionMaterials maskMaterials; // 0x68
	public static readonly int STENCIL_COMP_PARAM_ID; // 0x0
	public const CompareFunction STENCIL_COMP_MASKINTERACTION_NONE = 8;
	public const CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_INSIDE = 4;
	public const CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_OUTSIDE = 5;
	public bool disableRenderingOnOverride; // 0x70
	[CompilerGenerated]
	private SkeletonRenderer.InstructionDelegate generateMeshOverride; // 0x78
	[CompilerGenerated]
	private MeshGeneratorDelegate OnPostProcessVertices; // 0x80
	private readonly Dictionary<Material, Material> customMaterialOverride; // 0x88
	private readonly Dictionary<Slot, Material> customSlotMaterials; // 0x90
	private readonly SkeletonRendererInstruction currentInstructions; // 0x98
	private readonly MeshGenerator meshGenerator; // 0xA0
	private readonly MeshRendererBuffers rendererBuffers; // 0xA8
	private MeshRenderer meshRenderer; // 0xB0
	private MeshFilter meshFilter; // 0xB8
	public bool valid; // 0xC0
	public Skeleton skeleton; // 0xC8
	[CompilerGenerated]
	private SkeletonRenderer.SkeletonRendererDelegate OnRebuild; // 0xD0
	[CompilerGenerated]
	private SkeletonRenderer.SkeletonRendererDelegate OnMeshAndMaterialsUpdated; // 0xD8
	private MaterialPropertyBlock reusedPropertyBlock; // 0xE0
	public static readonly int SUBMESH_DUMMY_PARAM_ID; // 0x4

	// Properties
	public UpdateMode UpdateMode { get; set; }
	public Dictionary<Material, Material> CustomMaterialOverride { get; }
	public Dictionary<Slot, Material> CustomSlotMaterials { get; }
	public Skeleton Skeleton { get; }
	public SkeletonDataAsset SkeletonDataAsset { get; }

	// Methods

	// RVA: 0x7F6A840 Offset: 0x7F66840 VA: 0x7F6A840
	public UpdateMode get_UpdateMode() { }

	// RVA: 0x7F6A848 Offset: 0x7F66848 VA: 0x7F6A848
	public void set_UpdateMode(UpdateMode value) { }

	[CompilerGenerated]
	// RVA: 0x7F6A850 Offset: 0x7F66850 VA: 0x7F6A850
	private void add_generateMeshOverride(SkeletonRenderer.InstructionDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F6A8EC Offset: 0x7F668EC VA: 0x7F6A8EC
	private void remove_generateMeshOverride(SkeletonRenderer.InstructionDelegate value) { }

	// RVA: 0x7F6A988 Offset: 0x7F66988 VA: 0x7F6A988
	public void add_GenerateMeshOverride(SkeletonRenderer.InstructionDelegate value) { }

	// RVA: 0x7F6AA44 Offset: 0x7F66A44 VA: 0x7F6AA44
	public void remove_GenerateMeshOverride(SkeletonRenderer.InstructionDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F6AB00 Offset: 0x7F66B00 VA: 0x7F6AB00
	public void add_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F6AB9C Offset: 0x7F66B9C VA: 0x7F6AB9C
	public void remove_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	// RVA: 0x7F6AC38 Offset: 0x7F66C38 VA: 0x7F6AC38
	public Dictionary<Material, Material> get_CustomMaterialOverride() { }

	// RVA: 0x7F6AC40 Offset: 0x7F66C40 VA: 0x7F6AC40
	public Dictionary<Slot, Material> get_CustomSlotMaterials() { }

	// RVA: 0x7F6AC48 Offset: 0x7F66C48 VA: 0x7F6AC48 Slot: 5
	public Skeleton get_Skeleton() { }

	[CompilerGenerated]
	// RVA: 0x7F6AC70 Offset: 0x7F66C70 VA: 0x7F6AC70
	public void add_OnRebuild(SkeletonRenderer.SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F6AD0C Offset: 0x7F66D0C VA: 0x7F6AD0C
	public void remove_OnRebuild(SkeletonRenderer.SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F6ADA8 Offset: 0x7F66DA8 VA: 0x7F6ADA8
	public void add_OnMeshAndMaterialsUpdated(SkeletonRenderer.SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F6AE44 Offset: 0x7F66E44 VA: 0x7F6AE44
	public void remove_OnMeshAndMaterialsUpdated(SkeletonRenderer.SkeletonRendererDelegate value) { }

	// RVA: 0x7F6AEE0 Offset: 0x7F66EE0 VA: 0x7F6AEE0 Slot: 6
	public SkeletonDataAsset get_SkeletonDataAsset() { }

	// RVA: -1 Offset: -1
	public static T NewSpineGameObject<T>(SkeletonDataAsset skeletonDataAsset, bool quiet = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F3660 Offset: 0x46EF660 VA: 0x46F3660
	|-SkeletonRenderer.NewSpineGameObject<object>
	*/

	// RVA: -1 Offset: -1
	public static T AddSpineComponent<T>(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, bool quiet = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F3594 Offset: 0x46EF594 VA: 0x46F3594
	|-SkeletonRenderer.AddSpineComponent<object>
	*/

	// RVA: 0x7F6AEE8 Offset: 0x7F66EE8 VA: 0x7F6AEE8
	public void SetMeshSettings(MeshGenerator.Settings settings) { }

	// RVA: 0x7F6AF38 Offset: 0x7F66F38 VA: 0x7F6AF38 Slot: 7
	public virtual void Awake() { }

	// RVA: 0x7F6AF64 Offset: 0x7F66F64 VA: 0x7F6AF64
	private void OnDisable() { }

	// RVA: 0x7F6AF84 Offset: 0x7F66F84 VA: 0x7F6AF84
	private void OnDestroy() { }

	// RVA: 0x7F6AFAC Offset: 0x7F66FAC VA: 0x7F6AFAC Slot: 8
	public virtual void ClearState() { }

	// RVA: 0x7F6B084 Offset: 0x7F67084 VA: 0x7F6B084
	public void EnsureMeshGeneratorCapacity(int minimumVertexCount) { }

	// RVA: 0x7F67474 Offset: 0x7F63474 VA: 0x7F67474 Slot: 9
	public virtual void Initialize(bool overwrite, bool quiet = False) { }

	// RVA: 0x7F68D50 Offset: 0x7F64D50 VA: 0x7F68D50 Slot: 10
	public virtual void LateUpdate() { }

	// RVA: 0x7F6B40C Offset: 0x7F6740C VA: 0x7F6B40C Slot: 11
	public virtual void LateUpdateMesh() { }

	// RVA: 0x7F6F420 Offset: 0x7F6B420 VA: 0x7F6F420 Slot: 12
	public virtual void OnBecameVisible() { }

	// RVA: 0x7F6F444 Offset: 0x7F6B444 VA: 0x7F6F444
	public void OnBecameInvisible() { }

	// RVA: 0x7F6F450 Offset: 0x7F6B450 VA: 0x7F6F450
	public void FindAndApplySeparatorSlots(string startsWith, bool clearExistingSeparators = True, bool updateStringArray = False) { }

	// RVA: 0x7F6F55C Offset: 0x7F6B55C VA: 0x7F6F55C
	public void FindAndApplySeparatorSlots(Func<string, bool> slotNamePredicate, bool clearExistingSeparators = True, bool updateStringArray = False) { }

	// RVA: 0x7F6FA64 Offset: 0x7F6BA64 VA: 0x7F6FA64
	public void ReapplySeparatorSlotNames() { }

	// RVA: 0x7F6EE38 Offset: 0x7F6AE38 VA: 0x7F6EE38
	private void AssignSpriteMaskMaterials() { }

	// RVA: 0x7F6FBAC Offset: 0x7F6BBAC VA: 0x7F6FBAC
	private bool InitSpriteMaskMaterialsInsideMask() { }

	// RVA: 0x7F6FBD4 Offset: 0x7F6BBD4 VA: 0x7F6FBD4
	private bool InitSpriteMaskMaterialsOutsideMask() { }

	// RVA: 0x7F6FBFC Offset: 0x7F6BBFC VA: 0x7F6FBFC
	private bool InitSpriteMaskMaterialsForMaskType(CompareFunction maskFunction, ref Material[] materialsToFill) { }

	// RVA: 0x7F6F040 Offset: 0x7F6B040 VA: 0x7F6F040
	private void HandleOnDemandLoading() { }

	// RVA: 0x7F6F228 Offset: 0x7F6B228 VA: 0x7F6F228
	private void SetMaterialSettingsToFixDrawOrder() { }

	// RVA: 0x7F68E38 Offset: 0x7F64E38 VA: 0x7F68E38
	public void .ctor() { }

	// RVA: 0x7F70078 Offset: 0x7F6C078 VA: 0x7F70078
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public struct SkeletonGraphicCustomMaterials.AtlasMaterialOverride : IEquatable<SkeletonGraphicCustomMaterials.AtlasMaterialOverride> // TypeDefIndex: 24143
{
	// Fields
	public bool overrideEnabled; // 0x0
	public Texture originalTexture; // 0x8
	public Material replacementMaterial; // 0x10

	// Methods

	// RVA: 0x7F70CD4 Offset: 0x7F6CCD4 VA: 0x7F70CD4 Slot: 4
	public bool Equals(SkeletonGraphicCustomMaterials.AtlasMaterialOverride other) { }
}

// Namespace: 
[Serializable]
public struct SkeletonGraphicCustomMaterials.AtlasTextureOverride : IEquatable<SkeletonGraphicCustomMaterials.AtlasTextureOverride> // TypeDefIndex: 24144
{
	// Fields
	public bool overrideEnabled; // 0x0
	public Texture originalTexture; // 0x8
	public Texture replacementTexture; // 0x10

	// Methods

	// RVA: 0x7F70D98 Offset: 0x7F6CD98 VA: 0x7F70D98 Slot: 4
	public bool Equals(SkeletonGraphicCustomMaterials.AtlasTextureOverride other) { }
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonGraphicCustomMaterials")]
[ExecuteAlways]
public class SkeletonGraphicCustomMaterials : MonoBehaviour // TypeDefIndex: 24145
{
	// Fields
	public SkeletonGraphic skeletonGraphic; // 0x20
	[SerializeField]
	protected List<SkeletonGraphicCustomMaterials.AtlasMaterialOverride> customMaterialOverrides; // 0x28
	[SerializeField]
	protected List<SkeletonGraphicCustomMaterials.AtlasTextureOverride> customTextureOverrides; // 0x30

	// Methods

	// RVA: 0x7F703C8 Offset: 0x7F6C3C8 VA: 0x7F703C8
	private void SetCustomMaterialOverrides() { }

	// RVA: 0x7F70524 Offset: 0x7F6C524 VA: 0x7F70524
	private void RemoveCustomMaterialOverrides() { }

	// RVA: 0x7F706E0 Offset: 0x7F6C6E0 VA: 0x7F706E0
	private void SetCustomTextureOverrides() { }

	// RVA: 0x7F7083C Offset: 0x7F6C83C VA: 0x7F7083C
	private void RemoveCustomTextureOverrides() { }

	// RVA: 0x7F709F8 Offset: 0x7F6C9F8 VA: 0x7F709F8
	private void OnEnable() { }

	// RVA: 0x7F70B38 Offset: 0x7F6CB38 VA: 0x7F70B38
	private void OnDisable() { }

	// RVA: 0x7F70BF8 Offset: 0x7F6CBF8 VA: 0x7F70BF8
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct SkeletonRendererCustomMaterials.SlotMaterialOverride : IEquatable<SkeletonRendererCustomMaterials.SlotMaterialOverride> // TypeDefIndex: 24146
{
	// Fields
	public bool overrideDisabled; // 0x0
	[SpineSlot("", "", False, True, False)]
	public string slotName; // 0x8
	public Material material; // 0x10

	// Methods

	// RVA: 0x7F717E8 Offset: 0x7F6D7E8 VA: 0x7F717E8 Slot: 4
	public bool Equals(SkeletonRendererCustomMaterials.SlotMaterialOverride other) { }
}

// Namespace: 
[Serializable]
public struct SkeletonRendererCustomMaterials.AtlasMaterialOverride : IEquatable<SkeletonRendererCustomMaterials.AtlasMaterialOverride> // TypeDefIndex: 24147
{
	// Fields
	public bool overrideDisabled; // 0x0
	public Material originalMaterial; // 0x8
	public Material replacementMaterial; // 0x10

	// Methods

	// RVA: 0x7F71888 Offset: 0x7F6D888 VA: 0x7F71888 Slot: 4
	public bool Equals(SkeletonRendererCustomMaterials.AtlasMaterialOverride other) { }
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRendererCustomMaterials")]
[ExecuteAlways]
public class SkeletonRendererCustomMaterials : MonoBehaviour // TypeDefIndex: 24148
{
	// Fields
	public SkeletonRenderer skeletonRenderer; // 0x20
	[SerializeField]
	protected List<SkeletonRendererCustomMaterials.SlotMaterialOverride> customSlotMaterials; // 0x28
	[SerializeField]
	protected List<SkeletonRendererCustomMaterials.AtlasMaterialOverride> customMaterialOverrides; // 0x30

	// Methods

	// RVA: 0x7F70E5C Offset: 0x7F6CE5C VA: 0x7F70E5C
	private void SetCustomSlotMaterials() { }

	// RVA: 0x7F70FFC Offset: 0x7F6CFFC VA: 0x7F70FFC
	private void RemoveCustomSlotMaterials() { }

	// RVA: 0x7F711EC Offset: 0x7F6D1EC VA: 0x7F711EC
	private void SetCustomMaterialOverrides() { }

	// RVA: 0x7F71348 Offset: 0x7F6D348 VA: 0x7F71348
	private void RemoveCustomMaterialOverrides() { }

	// RVA: 0x7F71504 Offset: 0x7F6D504 VA: 0x7F71504
	private void OnEnable() { }

	// RVA: 0x7F7164C Offset: 0x7F6D64C VA: 0x7F7164C
	private void OnDisable() { }

	// RVA: 0x7F7170C Offset: 0x7F6D70C VA: 0x7F7170C
	public void .ctor() { }
}

// Namespace: 
public sealed class SkeletonPartsRenderer.SkeletonPartsRendererDelegate : MulticastDelegate // TypeDefIndex: 24149
{
	// Methods

	// RVA: 0x7F72134 Offset: 0x7F6E134 VA: 0x7F72134
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F7223C Offset: 0x7F6E23C VA: 0x7F7223C Slot: 13
	public virtual void Invoke(SkeletonPartsRenderer skeletonPartsRenderer) { }

	// RVA: 0x7F72250 Offset: 0x7F6E250 VA: 0x7F72250 Slot: 14
	public virtual IAsyncResult BeginInvoke(SkeletonPartsRenderer skeletonPartsRenderer, AsyncCallback callback, object object) { }

	// RVA: 0x7F72270 Offset: 0x7F6E270 VA: 0x7F72270 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRenderSeparator")]
[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class SkeletonPartsRenderer : MonoBehaviour // TypeDefIndex: 24150
{
	// Fields
	private MeshGenerator meshGenerator; // 0x20
	private MeshRenderer meshRenderer; // 0x28
	private MeshFilter meshFilter; // 0x30
	[CompilerGenerated]
	private SkeletonPartsRenderer.SkeletonPartsRendererDelegate OnMeshAndMaterialsUpdated; // 0x38
	private MeshRendererBuffers buffers; // 0x40
	private SkeletonRendererInstruction currentInstructions; // 0x48

	// Properties
	public MeshGenerator MeshGenerator { get; }
	public MeshRenderer MeshRenderer { get; }
	public MeshFilter MeshFilter { get; }

	// Methods

	// RVA: 0x7F7194C Offset: 0x7F6D94C VA: 0x7F7194C
	public MeshGenerator get_MeshGenerator() { }

	// RVA: 0x7F71AA0 Offset: 0x7F6DAA0 VA: 0x7F71AA0
	public MeshRenderer get_MeshRenderer() { }

	// RVA: 0x7F71AB8 Offset: 0x7F6DAB8 VA: 0x7F71AB8
	public MeshFilter get_MeshFilter() { }

	[CompilerGenerated]
	// RVA: 0x7F71AD0 Offset: 0x7F6DAD0 VA: 0x7F71AD0
	public void add_OnMeshAndMaterialsUpdated(SkeletonPartsRenderer.SkeletonPartsRendererDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F71B6C Offset: 0x7F6DB6C VA: 0x7F71B6C
	public void remove_OnMeshAndMaterialsUpdated(SkeletonPartsRenderer.SkeletonPartsRendererDelegate value) { }

	// RVA: 0x7F71964 Offset: 0x7F6D964 VA: 0x7F71964
	private void LazyIntialize() { }

	// RVA: 0x7F71C08 Offset: 0x7F6DC08 VA: 0x7F71C08
	public void ClearMesh() { }

	// RVA: 0x7F71C30 Offset: 0x7F6DC30 VA: 0x7F71C30
	public void RenderParts(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh) { }

	// RVA: 0x7F71EA4 Offset: 0x7F6DEA4 VA: 0x7F71EA4
	public void SetPropertyBlock(MaterialPropertyBlock block) { }

	// RVA: 0x7F71ED8 Offset: 0x7F6DED8 VA: 0x7F71ED8
	public static SkeletonPartsRenderer NewPartsRendererGameObject(Transform parent, string name, int sortingOrder = 0) { }

	// RVA: 0x7F720C8 Offset: 0x7F6E0C8 VA: 0x7F720C8
	public void .ctor() { }
}

// Namespace: Spine.Unity
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRenderSeparator")]
public class SkeletonRenderSeparator : MonoBehaviour // TypeDefIndex: 24151
{
	// Fields
	public const int DefaultSortingOrderIncrement = 5;
	[SerializeField]
	protected SkeletonRenderer skeletonRenderer; // 0x20
	private MeshRenderer mainMeshRenderer; // 0x28
	public bool copyPropertyBlock; // 0x30
	[Tooltip("Copies MeshRenderer flags into each parts renderer")]
	public bool copyMeshRendererFlags; // 0x31
	public List<SkeletonPartsRenderer> partsRenderers; // 0x38
	[CompilerGenerated]
	private SkeletonRenderer.SkeletonRendererDelegate OnMeshAndMaterialsUpdated; // 0x40
	private MaterialPropertyBlock copiedBlock; // 0x48

	// Properties
	public SkeletonRenderer SkeletonRenderer { get; set; }

	// Methods

	// RVA: 0x7F7227C Offset: 0x7F6E27C VA: 0x7F7227C
	public SkeletonRenderer get_SkeletonRenderer() { }

	// RVA: 0x7F72284 Offset: 0x7F6E284 VA: 0x7F72284
	public void set_SkeletonRenderer(SkeletonRenderer value) { }

	[CompilerGenerated]
	// RVA: 0x7F723B0 Offset: 0x7F6E3B0 VA: 0x7F723B0
	public void add_OnMeshAndMaterialsUpdated(SkeletonRenderer.SkeletonRendererDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F7244C Offset: 0x7F6E44C VA: 0x7F7244C
	public void remove_OnMeshAndMaterialsUpdated(SkeletonRenderer.SkeletonRendererDelegate value) { }

	// RVA: 0x7F724E8 Offset: 0x7F6E4E8 VA: 0x7F724E8
	public static SkeletonRenderSeparator AddToSkeletonRenderer(SkeletonRenderer skeletonRenderer, int sortingLayerID = 0, int extraPartsRenderers = 0, int sortingOrderIncrement = 5, int baseSortingOrder = 0, bool addMinimumPartsRenderers = True) { }

	// RVA: 0x7F72AA8 Offset: 0x7F6EAA8 VA: 0x7F72AA8
	public SkeletonPartsRenderer AddPartsRenderer(int sortingOrderIncrement = 5, string name) { }

	// RVA: 0x7F72758 Offset: 0x7F6E758 VA: 0x7F72758
	public void OnEnable() { }

	// RVA: 0x7F72C70 Offset: 0x7F6EC70 VA: 0x7F72C70
	public void OnDisable() { }

	// RVA: 0x7F72EE8 Offset: 0x7F6EEE8 VA: 0x7F72EE8
	private void HandleRender(SkeletonRendererInstruction instruction) { }

	// RVA: 0x7F72D54 Offset: 0x7F6ED54 VA: 0x7F72D54
	protected void ClearPartsRendererMeshes() { }

	// RVA: 0x7F73210 Offset: 0x7F6F210 VA: 0x7F73210
	public void .ctor() { }
}

// Namespace: Spine.Unity
public class ActivateBasedOnFlipDirection : MonoBehaviour // TypeDefIndex: 24152
{
	// Fields
	public SkeletonRenderer skeletonRenderer; // 0x20
	public SkeletonGraphic skeletonGraphic; // 0x28
	public GameObject activeOnNormalX; // 0x30
	public GameObject activeOnFlippedX; // 0x38
	private HingeJoint2D[] jointsNormalX; // 0x40
	private HingeJoint2D[] jointsFlippedX; // 0x48
	private ISkeletonComponent skeletonComponent; // 0x50
	private bool wasFlippedXBefore; // 0x58

	// Methods

	// RVA: 0x7F732A0 Offset: 0x7F6F2A0 VA: 0x7F732A0
	private void Start() { }

	// RVA: 0x7F73380 Offset: 0x7F6F380 VA: 0x7F73380
	private void FixedUpdate() { }

	// RVA: 0x7F73458 Offset: 0x7F6F458 VA: 0x7F73458
	private void HandleFlip(bool isFlippedX) { }

	// RVA: 0x7F73510 Offset: 0x7F6F510 VA: 0x7F73510
	private void ResetJointPositions(HingeJoint2D[] joints) { }

	// RVA: 0x7F735CC Offset: 0x7F6F5CC VA: 0x7F735CC
	private void CompensateMovementAfterFlipX(Transform toActivate, Transform toDeactivate) { }

	// RVA: 0x7F73694 Offset: 0x7F6F694 VA: 0x7F73694
	public void .ctor() { }
}

// Namespace: Spine.Unity
[RequireComponent(typeof(Rigidbody))]
public class FollowLocationRigidbody : MonoBehaviour // TypeDefIndex: 24153
{
	// Fields
	public Transform reference; // 0x20
	private Rigidbody ownRigidbody; // 0x28

	// Methods

	// RVA: 0x7F7369C Offset: 0x7F6F69C VA: 0x7F7369C
	private void Awake() { }

	// RVA: 0x7F736F4 Offset: 0x7F6F6F4 VA: 0x7F736F4
	private void FixedUpdate() { }

	// RVA: 0x7F73754 Offset: 0x7F6F754 VA: 0x7F73754
	public void .ctor() { }
}

// Namespace: Spine.Unity
[RequireComponent(typeof(Rigidbody2D))]
public class FollowLocationRigidbody2D : MonoBehaviour // TypeDefIndex: 24154
{
	// Fields
	public Transform reference; // 0x20
	public bool followFlippedX; // 0x28
	private Rigidbody2D ownRigidbody; // 0x30

	// Methods

	// RVA: 0x7F7375C Offset: 0x7F6F75C VA: 0x7F7375C
	private void Awake() { }

	// RVA: 0x7F737B4 Offset: 0x7F6F7B4 VA: 0x7F737B4
	private void FixedUpdate() { }

	// RVA: 0x7F73868 Offset: 0x7F6F868 VA: 0x7F73868
	public void .ctor() { }
}

// Namespace: Spine.Unity
public class FollowSkeletonUtilityRootRotation : MonoBehaviour // TypeDefIndex: 24155
{
	// Fields
	private const float FLIP_ANGLE_THRESHOLD = 100;
	public Transform reference; // 0x20
	private Vector3 prevLocalEulerAngles; // 0x28

	// Methods

	// RVA: 0x7F73870 Offset: 0x7F6F870 VA: 0x7F73870
	private void Start() { }

	// RVA: 0x7F738A0 Offset: 0x7F6F8A0 VA: 0x7F738A0
	private void FixedUpdate() { }

	// RVA: 0x7F73988 Offset: 0x7F6F988 VA: 0x7F73988
	private void CompensatePositionToYRotation() { }

	// RVA: 0x7F73A50 Offset: 0x7F6FA50 VA: 0x7F73A50
	private void CompensatePositionToXRotation() { }

	// RVA: 0x7F73B18 Offset: 0x7F6FB18 VA: 0x7F73B18
	public void .ctor() { }
}

// Namespace: 
public sealed class SkeletonUtility.SkeletonUtilityDelegate : MulticastDelegate // TypeDefIndex: 24156
{
	// Methods

	// RVA: 0x7F770B0 Offset: 0x7F730B0 VA: 0x7F770B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F7714C Offset: 0x7F7314C VA: 0x7F7714C Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x7F77160 Offset: 0x7F73160 VA: 0x7F77160 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x7F77180 Offset: 0x7F73180 VA: 0x7F77180 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Spine.Unity
[ExecuteAlways]
[RequireComponent(typeof(ISkeletonAnimation))]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonUtility")]
public sealed class SkeletonUtility : MonoBehaviour // TypeDefIndex: 24157
{
	// Fields
	[CompilerGenerated]
	private SkeletonUtility.SkeletonUtilityDelegate OnReset; // 0x20
	public Transform boneRoot; // 0x28
	public bool flipBy180DegreeRotation; // 0x30
	[HideInInspector]
	public SkeletonRenderer skeletonRenderer; // 0x38
	[HideInInspector]
	public SkeletonGraphic skeletonGraphic; // 0x40
	private Canvas canvas; // 0x48
	public ISkeletonAnimation skeletonAnimation; // 0x50
	private ISkeletonComponent skeletonComponent; // 0x58
	public List<SkeletonUtilityBone> boneComponents; // 0x60
	public List<SkeletonUtilityConstraint> constraintComponents; // 0x68
	private float positionScale; // 0x70
	private bool hasOverrideBones; // 0x74
	private bool hasConstraints; // 0x75
	private bool needToReprocessBones; // 0x76

	// Properties
	public ISkeletonComponent SkeletonComponent { get; }
	public Skeleton Skeleton { get; }
	public bool IsValid { get; }
	public float PositionScale { get; }

	// Methods

	// RVA: 0x7F73B20 Offset: 0x7F6FB20 VA: 0x7F73B20
	public static PolygonCollider2D AddBoundingBoxGameObject(Skeleton skeleton, string skinName, string slotName, string attachmentName, Transform parent, bool isTrigger = True) { }

	// RVA: 0x7F73E5C Offset: 0x7F6FE5C VA: 0x7F73E5C
	public static PolygonCollider2D AddBoundingBoxGameObject(string name, BoundingBoxAttachment box, Slot slot, Transform parent, bool isTrigger = True) { }

	// RVA: 0x7F74018 Offset: 0x7F70018 VA: 0x7F74018
	public static PolygonCollider2D AddBoundingBoxAsComponent(BoundingBoxAttachment box, Slot slot, GameObject gameObject, bool isTrigger = True) { }

	// RVA: 0x7F740B8 Offset: 0x7F700B8 VA: 0x7F740B8
	public static void SetColliderPointsLocal(PolygonCollider2D collider, Slot slot, BoundingBoxAttachment box, float scale = 1) { }

	// RVA: 0x7F741F0 Offset: 0x7F701F0 VA: 0x7F741F0
	public static Bounds GetBoundingBoxBounds(BoundingBoxAttachment boundingBox, float depth = 0) { }

	// RVA: 0x7F742E4 Offset: 0x7F702E4 VA: 0x7F742E4
	public static Rigidbody2D AddBoneRigidbody2D(GameObject gameObject, bool isKinematic = True, float gravityScale = 0) { }

	[CompilerGenerated]
	// RVA: 0x7F743D0 Offset: 0x7F703D0 VA: 0x7F743D0
	public void add_OnReset(SkeletonUtility.SkeletonUtilityDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F7446C Offset: 0x7F7046C VA: 0x7F7446C
	public void remove_OnReset(SkeletonUtility.SkeletonUtilityDelegate value) { }

	// RVA: 0x7F74508 Offset: 0x7F70508 VA: 0x7F74508
	private void Update() { }

	// RVA: 0x7F746DC Offset: 0x7F706DC VA: 0x7F746DC
	public ISkeletonComponent get_SkeletonComponent() { }

	// RVA: 0x7F747C0 Offset: 0x7F707C0 VA: 0x7F747C0
	public Skeleton get_Skeleton() { }

	// RVA: 0x7F7487C Offset: 0x7F7087C VA: 0x7F7487C
	public bool get_IsValid() { }

	// RVA: 0x7F74944 Offset: 0x7F70944 VA: 0x7F74944
	public float get_PositionScale() { }

	// RVA: 0x7F7494C Offset: 0x7F7094C VA: 0x7F7494C
	public void ResubscribeEvents() { }

	// RVA: 0x7F74CA8 Offset: 0x7F70CA8 VA: 0x7F74CA8
	private void OnEnable() { }

	// RVA: 0x7F759C4 Offset: 0x7F719C4 VA: 0x7F759C4
	private void Start() { }

	// RVA: 0x7F74964 Offset: 0x7F70964 VA: 0x7F74964
	private void OnDisable() { }

	// RVA: 0x7F759C8 Offset: 0x7F719C8 VA: 0x7F759C8
	private void HandleRendererReset(SkeletonRenderer r) { }

	// RVA: 0x7F759F4 Offset: 0x7F719F4 VA: 0x7F759F4
	private void HandleRendererReset(SkeletonGraphic g) { }

	// RVA: 0x7F75A20 Offset: 0x7F71A20 VA: 0x7F75A20
	public void RegisterBone(SkeletonUtilityBone bone) { }

	// RVA: 0x7F75B00 Offset: 0x7F71B00 VA: 0x7F75B00
	public void UnregisterBone(SkeletonUtilityBone bone) { }

	// RVA: 0x7F75B58 Offset: 0x7F71B58 VA: 0x7F75B58
	public void RegisterConstraint(SkeletonUtilityConstraint constraint) { }

	// RVA: 0x7F75C38 Offset: 0x7F71C38 VA: 0x7F75C38
	public void UnregisterConstraint(SkeletonUtilityConstraint constraint) { }

	// RVA: 0x7F75348 Offset: 0x7F71348 VA: 0x7F75348
	public void CollectBones() { }

	// RVA: 0x7F7648C Offset: 0x7F7248C VA: 0x7F7648C
	private void UpdateLocal(ISkeletonAnimation anim) { }

	// RVA: 0x7F76628 Offset: 0x7F72628 VA: 0x7F76628
	private void UpdateWorld(ISkeletonAnimation anim) { }

	// RVA: 0x7F766D4 Offset: 0x7F726D4 VA: 0x7F766D4
	private void UpdateComplete(ISkeletonAnimation anim) { }

	// RVA: 0x7F76548 Offset: 0x7F72548 VA: 0x7F76548
	private void UpdateAllBones(SkeletonUtilityBone.UpdatePhase phase) { }

	// RVA: 0x7F766DC Offset: 0x7F726DC VA: 0x7F766DC
	public Transform GetBoneRoot() { }

	// RVA: 0x7F76908 Offset: 0x7F72908 VA: 0x7F76908
	public GameObject SpawnRoot(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca) { }

	// RVA: 0x7F76C5C Offset: 0x7F72C5C VA: 0x7F76C5C
	public GameObject SpawnHierarchy(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca) { }

	// RVA: 0x7F76D68 Offset: 0x7F72D68 VA: 0x7F76D68
	public GameObject SpawnBoneRecursively(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca) { }

	// RVA: 0x7F76A14 Offset: 0x7F72A14 VA: 0x7F76A14
	public GameObject SpawnBone(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca) { }

	// RVA: 0x7F76FCC Offset: 0x7F72FCC VA: 0x7F76FCC
	public void .ctor() { }
}

// Namespace: 
public enum SkeletonUtilityBone.Mode // TypeDefIndex: 24158
{
	// Fields
	public int value__; // 0x0
	public const SkeletonUtilityBone.Mode Follow = 0;
	public const SkeletonUtilityBone.Mode Override = 1;
}

// Namespace: 
public enum SkeletonUtilityBone.UpdatePhase // TypeDefIndex: 24159
{
	// Fields
	public int value__; // 0x0
	public const SkeletonUtilityBone.UpdatePhase Local = 0;
	public const SkeletonUtilityBone.UpdatePhase World = 1;
	public const SkeletonUtilityBone.UpdatePhase Complete = 2;
}

// Namespace: Spine.Unity
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonUtilityBone")]
[AddComponentMenu("Spine/SkeletonUtilityBone")]
[ExecuteAlways]
public class SkeletonUtilityBone : MonoBehaviour // TypeDefIndex: 24160
{
	// Fields
	public string boneName; // 0x20
	public Transform parentReference; // 0x28
	public SkeletonUtilityBone.Mode mode; // 0x30
	public bool position; // 0x34
	public bool rotation; // 0x35
	public bool scale; // 0x36
	public bool zPosition; // 0x37
	[Range(0, 1)]
	public float overrideAlpha; // 0x38
	public SkeletonUtility hierarchy; // 0x40
	public Bone bone; // 0x48
	public bool transformLerpComplete; // 0x50
	public bool valid; // 0x51
	private Transform cachedTransform; // 0x58
	private Transform skeletonTransform; // 0x60
	private bool incompatibleTransformMode; // 0x68

	// Properties
	public bool IncompatibleTransformMode { get; }

	// Methods

	// RVA: 0x7F7718C Offset: 0x7F7318C VA: 0x7F7718C
	public bool get_IncompatibleTransformMode() { }

	// RVA: 0x7F76E54 Offset: 0x7F72E54 VA: 0x7F76E54
	public void Reset() { }

	// RVA: 0x7F77194 Offset: 0x7F73194 VA: 0x7F77194
	private void OnEnable() { }

	// RVA: 0x7F772E0 Offset: 0x7F732E0 VA: 0x7F772E0
	private void HandleOnReset() { }

	// RVA: 0x7F772E4 Offset: 0x7F732E4 VA: 0x7F772E4
	private void OnDisable() { }

	// RVA: 0x7F75C90 Offset: 0x7F71C90 VA: 0x7F75C90
	public void DoUpdate(SkeletonUtilityBone.UpdatePhase phase) { }

	// RVA: 0x7F773BC Offset: 0x7F733BC VA: 0x7F773BC
	public static bool BoneTransformModeIncompatible(Bone bone) { }

	// RVA: 0x7F773EC Offset: 0x7F733EC VA: 0x7F773EC
	public void AddBoundingBox(string skinName, string slotName, string attachmentName) { }

	// RVA: 0x7F7746C Offset: 0x7F7346C VA: 0x7F7746C
	public void .ctor() { }
}

// Namespace: Spine.Unity
[RequireComponent(typeof(SkeletonUtilityBone))]
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonUtilityConstraint")]
public abstract class SkeletonUtilityConstraint : MonoBehaviour // TypeDefIndex: 24161
{
	// Fields
	protected SkeletonUtilityBone bone; // 0x20
	protected SkeletonUtility hierarchy; // 0x28

	// Methods

	// RVA: 0x7F77484 Offset: 0x7F73484 VA: 0x7F77484 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x7F77530 Offset: 0x7F73530 VA: 0x7F77530 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void DoUpdate();

	// RVA: 0x7F7754C Offset: 0x7F7354C VA: 0x7F7754C
	protected void .ctor() { }
}

// Namespace: Spine.Unity
public enum UpdateMode // TypeDefIndex: 24162
{
	// Fields
	public int value__; // 0x0
	public const UpdateMode Nothing = 0;
	public const UpdateMode OnlyAnimationStatus = 1;
	public const UpdateMode OnlyEventTimelines = 4;
	public const UpdateMode EverythingExceptMesh = 2;
	public const UpdateMode FullUpdate = 3;
}

// Namespace: Spine.Unity
public enum UpdateTiming // TypeDefIndex: 24163
{
	// Fields
	public int value__; // 0x0
	public const UpdateTiming ManualUpdate = 0;
	public const UpdateTiming InUpdate = 1;
	public const UpdateTiming InFixedUpdate = 2;
}

// Namespace: Spine.Unity
public sealed class ISkeletonAnimationDelegate : MulticastDelegate // TypeDefIndex: 24164
{
	// Methods

	// RVA: 0x7F77554 Offset: 0x7F73554 VA: 0x7F77554
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F7765C Offset: 0x7F7365C VA: 0x7F7765C Slot: 13
	public virtual void Invoke(ISkeletonAnimation animated) { }

	// RVA: 0x7F77670 Offset: 0x7F73670 VA: 0x7F77670 Slot: 14
	public virtual IAsyncResult BeginInvoke(ISkeletonAnimation animated, AsyncCallback callback, object object) { }

	// RVA: 0x7F77690 Offset: 0x7F73690 VA: 0x7F77690 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Spine.Unity
public sealed class UpdateBonesDelegate : MulticastDelegate // TypeDefIndex: 24165
{
	// Methods

	// RVA: 0x7F75240 Offset: 0x7F71240 VA: 0x7F75240
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F7769C Offset: 0x7F7369C VA: 0x7F7769C Slot: 13
	public virtual void Invoke(ISkeletonAnimation animated) { }

	// RVA: 0x7F776B0 Offset: 0x7F736B0 VA: 0x7F776B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ISkeletonAnimation animated, AsyncCallback callback, object object) { }

	// RVA: 0x7F776D0 Offset: 0x7F736D0 VA: 0x7F776D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Spine.Unity
public interface ISpineComponent // TypeDefIndex: 24166
{}

// Namespace: Spine.Unity
[Extension]
public static class ISpineComponentExtensions // TypeDefIndex: 24167
{
	// Methods

	[Extension]
	// RVA: 0x7F776DC Offset: 0x7F736DC VA: 0x7F776DC
	public static bool IsNullOrDestroyed(ISpineComponent component) { }
}

// Namespace: Spine.Unity
public interface ISkeletonAnimation : ISpineComponent // TypeDefIndex: 24168
{
	// Properties
	public abstract Skeleton Skeleton { get; }
	public abstract UpdateTiming UpdateTiming { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_OnAnimationRebuild(ISkeletonAnimationDelegate value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_OnAnimationRebuild(ISkeletonAnimationDelegate value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_UpdateLocal(UpdateBonesDelegate value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_UpdateLocal(UpdateBonesDelegate value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_UpdateWorld(UpdateBonesDelegate value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_UpdateWorld(UpdateBonesDelegate value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void add_UpdateComplete(UpdateBonesDelegate value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void remove_UpdateComplete(UpdateBonesDelegate value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Skeleton get_Skeleton();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract UpdateTiming get_UpdateTiming();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_UpdateTiming(UpdateTiming value);
}

// Namespace: Spine.Unity
public interface IHasSkeletonDataAsset : ISpineComponent // TypeDefIndex: 24169
{
	// Properties
	public abstract SkeletonDataAsset SkeletonDataAsset { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SkeletonDataAsset get_SkeletonDataAsset();
}

// Namespace: Spine.Unity
public interface ISkeletonComponent : ISpineComponent // TypeDefIndex: 24170
{
	// Properties
	public abstract SkeletonDataAsset SkeletonDataAsset { get; }
	public abstract Skeleton Skeleton { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SkeletonDataAsset get_SkeletonDataAsset();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Skeleton get_Skeleton();
}

// Namespace: Spine.Unity
public interface IAnimationStateComponent : ISpineComponent // TypeDefIndex: 24171
{
	// Properties
	public abstract AnimationState AnimationState { get; }
	public abstract bool UnscaledTime { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AnimationState get_AnimationState();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_UnscaledTime();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_UnscaledTime(bool value);
}

// Namespace: Spine.Unity
public interface IHasSkeletonRenderer : ISpineComponent // TypeDefIndex: 24172
{
	// Properties
	public abstract SkeletonRenderer SkeletonRenderer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SkeletonRenderer get_SkeletonRenderer();
}

// Namespace: Spine.Unity
public interface IHasSkeletonComponent : ISpineComponent // TypeDefIndex: 24173
{
	// Properties
	public abstract ISkeletonComponent SkeletonComponent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISkeletonComponent get_SkeletonComponent();
}

// Namespace: Spine.Unity
public class DoubleBuffered<T> // TypeDefIndex: 24174
{
	// Fields
	private readonly T a; // 0x0
	private readonly T b; // 0x0
	private bool usingA; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public T GetCurrent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601BF60 Offset: 0x6017F60 VA: 0x601BF60
	|-DoubleBuffered<object>.GetCurrent
	|
	|-RVA: 0x601C008 Offset: 0x6018008 VA: 0x601C008
	|-DoubleBuffered<__Il2CppFullySharedGenericType>.GetCurrent
	*/

	// RVA: -1 Offset: -1
	public T GetNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601BF7C Offset: 0x6017F7C VA: 0x601BF7C
	|-DoubleBuffered<object>.GetNext
	|
	|-RVA: 0x601C0DC Offset: 0x60180DC VA: 0x601C0DC
	|-DoubleBuffered<__Il2CppFullySharedGenericType>.GetNext
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601BFA0 Offset: 0x6017FA0 VA: 0x601BFA0
	|-DoubleBuffered<object>..ctor
	|
	|-RVA: 0x601C1F4 Offset: 0x60181F4 VA: 0x601C1F4
	|-DoubleBuffered<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Spine.Unity
public sealed class MeshGeneratorDelegate : MulticastDelegate // TypeDefIndex: 24175
{
	// Methods

	// RVA: 0x7F77784 Offset: 0x7F73784 VA: 0x7F77784
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F77824 Offset: 0x7F73824 VA: 0x7F77824 Slot: 13
	public virtual void Invoke(MeshGeneratorBuffers buffers) { }

	// RVA: 0x7F77860 Offset: 0x7F73860 VA: 0x7F77860 Slot: 14
	public virtual IAsyncResult BeginInvoke(MeshGeneratorBuffers buffers, AsyncCallback callback, object object) { }

	// RVA: 0x7F778EC Offset: 0x7F738EC VA: 0x7F778EC Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Spine.Unity
public struct MeshGeneratorBuffers // TypeDefIndex: 24176
{
	// Fields
	public int vertexCount; // 0x0
	public Vector3[] vertexBuffer; // 0x8
	public Vector2[] uvBuffer; // 0x10
	public Color32[] colorBuffer; // 0x18
	public MeshGenerator meshGenerator; // 0x20
}

// Namespace: 
[Serializable]
public struct MeshGenerator.Settings // TypeDefIndex: 24177
{
	// Fields
	public bool useClipping; // 0x0
	[Space]
	[Range(-0.1, 0)]
	public float zSpacing; // 0x4
	[Header("Vertex Data")]
	[Space]
	public bool pmaVertexColors; // 0x8
	public bool tintBlack; // 0x9
	[Tooltip("Enable when using Additive blend mode at SkeletonGraphic under a CanvasGroup. When enabled, Additive alpha value is stored at uv2.g instead of color.a to capture CanvasGroup modifying color.a.")]
	public bool canvasGroupTintBlack; // 0xA
	public bool calculateTangents; // 0xB
	public bool addNormals; // 0xC
	public bool immutableTriangles; // 0xD

	// Properties
	public static MeshGenerator.Settings Default { get; }

	// Methods

	// RVA: 0x7F7933C Offset: 0x7F7533C VA: 0x7F7933C
	public static MeshGenerator.Settings get_Default() { }
}

// Namespace: Spine.Unity
[Serializable]
public class MeshGenerator // TypeDefIndex: 24178
{
	// Fields
	public MeshGenerator.Settings settings; // 0x10
	private const float BoundsMinDefault = ∞;
	private const float BoundsMaxDefault = -∞;
	protected readonly ExposedList<Vector3> vertexBuffer; // 0x20
	protected readonly ExposedList<Vector2> uvBuffer; // 0x28
	protected readonly ExposedList<Color32> colorBuffer; // 0x30
	protected readonly ExposedList<ExposedList<int>> submeshes; // 0x38
	private Vector2 meshBoundsMin; // 0x40
	private Vector2 meshBoundsMax; // 0x48
	private float meshBoundsThickness; // 0x50
	private int submeshIndex; // 0x54
	private SkeletonClipping clipper; // 0x58
	private float[] tempVerts; // 0x60
	private int[] regionTriangles; // 0x68
	private Vector3[] normals; // 0x70
	private Vector4[] tangents; // 0x78
	private Vector2[] tempTanBuffer; // 0x80
	private ExposedList<Vector2> uv2; // 0x88
	private ExposedList<Vector2> uv3; // 0x90
	private static List<Vector3> AttachmentVerts; // 0x0
	private static List<Vector2> AttachmentUVs; // 0x8
	private static List<Color32> AttachmentColors32; // 0x10
	private static List<int> AttachmentIndices; // 0x18

	// Properties
	public int VertexCount { get; }
	public MeshGeneratorBuffers Buffers { get; }

	// Methods

	// RVA: 0x7F71E88 Offset: 0x7F6DE88 VA: 0x7F71E88
	public int get_VertexCount() { }

	// RVA: 0x7F778F8 Offset: 0x7F738F8 VA: 0x7F778F8
	public int SubmeshIndexCount(int submeshIndex) { }

	// RVA: 0x7F6E704 Offset: 0x7F6A704 VA: 0x7F6E704
	public MeshGeneratorBuffers get_Buffers() { }

	// RVA: 0x7F6FD8C Offset: 0x7F6BD8C VA: 0x7F6FD8C
	public void .ctor() { }

	// RVA: 0x7F6BA4C Offset: 0x7F67A4C VA: 0x7F6BA4C
	public static void GenerateSingleSubmeshInstruction(SkeletonRendererInstruction instructionOutput, Skeleton skeleton, Material material) { }

	// RVA: 0x7F77938 Offset: 0x7F73938 VA: 0x7F77938
	public static bool RequiresMultipleSubmeshesByDrawOrder(Skeleton skeleton) { }

	// RVA: 0x7F6DDE0 Offset: 0x7F69DE0 VA: 0x7F6DDE0
	public static void GenerateSkeletonRendererInstruction(SkeletonRendererInstruction instructionOutput, Skeleton skeleton, Dictionary<Slot, Material> customSlotMaterials, List<Slot> separatorSlots, bool generateMeshOverride, bool immutableTriangles = False) { }

	// RVA: 0x7F6BF74 Offset: 0x7F67F74 VA: 0x7F6BF74
	public static void TryReplaceMaterials(ExposedList<SubmeshInstruction> workingSubmeshInstructions, Dictionary<Material, Material> customMaterialOverride) { }

	// RVA: 0x7F6B334 Offset: 0x7F67334 VA: 0x7F6B334
	public void Begin() { }

	// RVA: 0x7F6C04C Offset: 0x7F6804C VA: 0x7F6C04C
	public void AddSubmesh(SubmeshInstruction instruction, bool updateTriangles = True) { }

	// RVA: 0x7F6E668 Offset: 0x7F6A668 VA: 0x7F6E668
	public void BuildMesh(SkeletonRendererInstruction instruction, bool updateTriangles) { }

	// RVA: 0x7F6CCA8 Offset: 0x7F68CA8 VA: 0x7F6CCA8
	public void BuildMeshWithArrays(SkeletonRendererInstruction instruction, bool updateTriangles) { }

	// RVA: 0x7F77E10 Offset: 0x7F73E10 VA: 0x7F77E10
	public void ScaleVertexData(float scale) { }

	// RVA: 0x7F77E94 Offset: 0x7F73E94 VA: 0x7F77E94
	public Bounds GetMeshBounds() { }

	// RVA: 0x7F77C4C Offset: 0x7F73C4C VA: 0x7F77C4C
	private void AddAttachmentTintBlack(float r2, float g2, float b2, float a, int vertexCount) { }

	// RVA: 0x7F6E7B0 Offset: 0x7F6A7B0 VA: 0x7F6E7B0
	public void FillVertexData(Mesh mesh) { }

	// RVA: 0x7F6EC90 Offset: 0x7F6AC90 VA: 0x7F6EC90
	public void FillLateVertexData(Mesh mesh) { }

	// RVA: 0x7F6EB04 Offset: 0x7F6AB04 VA: 0x7F6EB04
	public void FillTriangles(Mesh mesh) { }

	// RVA: 0x7F6B0A8 Offset: 0x7F670A8 VA: 0x7F6B0A8
	public void EnsureVertexCapacity(int minimumVertexCount, bool inlcudeTintBlack = False, bool includeTangents = False, bool includeNormals = False) { }

	// RVA: 0x7F78270 Offset: 0x7F74270 VA: 0x7F78270
	public void TrimExcess() { }

	// RVA: 0x7F77EF8 Offset: 0x7F73EF8 VA: 0x7F77EF8
	internal static void SolveTangents2DEnsureSize(ref Vector4[] tangentBuffer, ref Vector2[] tempTanBuffer, int vertexCount, int vertexBufferLength) { }

	// RVA: 0x7F77FD0 Offset: 0x7F73FD0 VA: 0x7F77FD0
	internal static void SolveTangents2DTriangles(Vector2[] tempTanBuffer, int[] triangles, int triangleCount, Vector3[] vertices, Vector2[] uvs, int vertexCount) { }

	// RVA: 0x7F781A4 Offset: 0x7F741A4 VA: 0x7F781A4
	internal static void SolveTangents2DBuffer(Vector4[] tangents, Vector2[] tempTanBuffer, int vertexCount) { }

	// RVA: 0x7F783A0 Offset: 0x7F743A0 VA: 0x7F783A0
	public static void FillMeshLocal(Mesh mesh, RegionAttachment regionAttachment) { }

	// RVA: 0x7F78A9C Offset: 0x7F74A9C VA: 0x7F78A9C
	public static void FillMeshLocal(Mesh mesh, MeshAttachment meshAttachment, SkeletonData skeletonData) { }

	// RVA: 0x7F7919C Offset: 0x7F7519C VA: 0x7F7919C
	private static void .cctor() { }
}

// Namespace: 
public class MeshRendererBuffers.SmartMesh : IDisposable // TypeDefIndex: 24179
{
	// Fields
	public Mesh mesh; // 0x10
	public SkeletonRendererInstruction instructionUsed; // 0x18

	// Methods

	// RVA: 0x7F79438 Offset: 0x7F75438 VA: 0x7F79438
	public void Clear() { }

	// RVA: 0x7F79838 Offset: 0x7F75838 VA: 0x7F79838 Slot: 4
	public void Dispose() { }

	// RVA: 0x7F79A0C Offset: 0x7F75A0C VA: 0x7F79A0C
	public void .ctor() { }
}

// Namespace: Spine.Unity
public class MeshRendererBuffers : IDisposable // TypeDefIndex: 24180
{
	// Fields
	private DoubleBuffered<MeshRendererBuffers.SmartMesh> doubleBufferedMesh; // 0x10
	internal readonly ExposedList<Material> submeshMaterials; // 0x18
	internal Material[] sharedMaterials; // 0x20

	// Methods

	// RVA: 0x7F79348 Offset: 0x7F75348 VA: 0x7F79348
	public void Initialize() { }

	// RVA: 0x7F79464 Offset: 0x7F75464 VA: 0x7F79464
	public Material[] GetUpdatedSharedMaterialsArray() { }

	// RVA: 0x7F79504 Offset: 0x7F75504 VA: 0x7F79504
	public bool MaterialsChangedInLastUpdate() { }

	// RVA: 0x7F795A8 Offset: 0x7F755A8 VA: 0x7F795A8
	public void UpdateSharedMaterials(ExposedList<SubmeshInstruction> instructions) { }

	// RVA: 0x7F796D8 Offset: 0x7F756D8 VA: 0x7F796D8
	public MeshRendererBuffers.SmartMesh GetNextMesh() { }

	// RVA: 0x7F79728 Offset: 0x7F75728 VA: 0x7F79728
	public void Clear() { }

	// RVA: 0x7F797AC Offset: 0x7F757AC VA: 0x7F797AC Slot: 4
	public void Dispose() { }

	// RVA: 0x7F798CC Offset: 0x7F758CC VA: 0x7F798CC
	public void .ctor() { }
}

// Namespace: Spine.Unity
public class SkeletonRendererInstruction // TypeDefIndex: 24181
{
	// Fields
	public readonly ExposedList<SubmeshInstruction> submeshInstructions; // 0x10
	public bool immutableTriangles; // 0x18
	public bool hasActiveClipping; // 0x19
	public int rawVertexCount; // 0x1C
	public readonly ExposedList<Attachment> attachments; // 0x20

	// Methods

	// RVA: 0x7F79984 Offset: 0x7F75984 VA: 0x7F79984
	public void Clear() { }

	// RVA: 0x7F79C08 Offset: 0x7F75C08 VA: 0x7F79C08
	public void Dispose() { }

	// RVA: 0x7F79C5C Offset: 0x7F75C5C VA: 0x7F79C5C
	public void SetWithSubset(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh) { }

	// RVA: 0x7F79FB4 Offset: 0x7F75FB4 VA: 0x7F79FB4
	public void Set(SkeletonRendererInstruction other) { }

	// RVA: 0x7F7A160 Offset: 0x7F76160 VA: 0x7F7A160
	public static bool GeometryNotEqual(SkeletonRendererInstruction a, SkeletonRendererInstruction b) { }

	// RVA: 0x7F79B24 Offset: 0x7F75B24 VA: 0x7F79B24
	public void .ctor() { }
}

// Namespace: Spine.Unity
public static class SpineMesh // TypeDefIndex: 24182
{
	// Fields
	internal const HideFlags MeshHideflags = 20;

	// Methods

	// RVA: 0x7F79A88 Offset: 0x7F75A88 VA: 0x7F79A88
	public static Mesh NewSkeletonMesh() { }
}

// Namespace: Spine.Unity
public struct SubmeshInstruction // TypeDefIndex: 24183
{
	// Fields
	public Skeleton skeleton; // 0x0
	public int startSlot; // 0x8
	public int endSlot; // 0xC
	public Material material; // 0x10
	public bool forceSeparate; // 0x18
	public int preActiveClippingSlotSource; // 0x1C
	public int rawTriangleCount; // 0x20
	public int rawVertexCount; // 0x24
	public int rawFirstVertexIndex; // 0x28
	public bool hasClipping; // 0x2C
	public bool hasPMAAdditiveSlot; // 0x2D

	// Properties
	public int SlotCount { get; }

	// Methods

	// RVA: 0x7F7A304 Offset: 0x7F76304 VA: 0x7F7A304
	public int get_SlotCount() { }

	// RVA: 0x7F7A310 Offset: 0x7F76310 VA: 0x7F7A310 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private class BlendModeMaterialsAsset.AtlasMaterialCache : IDisposable // TypeDefIndex: 24184
{
	// Fields
	private readonly Dictionary<KeyValuePair<AtlasPage, Material>, AtlasPage> cache; // 0x10

	// Methods

	// RVA: 0x7F7AD64 Offset: 0x7F76D64 VA: 0x7F7AD64
	public AtlasRegion CloneAtlasRegionWithMaterial(AtlasRegion originalRegion, Material materialTemplate) { }

	// RVA: 0x7F7ADD4 Offset: 0x7F76DD4 VA: 0x7F7ADD4
	private AtlasPage GetAtlasPageWithMaterial(AtlasPage originalPage, Material materialTemplate) { }

	// RVA: 0x7F7B00C Offset: 0x7F7700C VA: 0x7F7B00C Slot: 4
	public void Dispose() { }

	// RVA: 0x7F7ACDC Offset: 0x7F76CDC VA: 0x7F7ACDC
	public void .ctor() { }
}

// Namespace: Spine.Unity
[CreateAssetMenu(menuName = "Spine/SkeletonData Modifiers/Blend Mode Materials", order = 200)]
public class BlendModeMaterialsAsset : SkeletonDataModifierAsset // TypeDefIndex: 24185
{
	// Fields
	public Material multiplyMaterialTemplate; // 0x18
	public Material screenMaterialTemplate; // 0x20
	public Material additiveMaterialTemplate; // 0x28
	public bool applyAdditiveMaterial; // 0x30

	// Methods

	// RVA: 0x7F7A554 Offset: 0x7F76554 VA: 0x7F7A554 Slot: 4
	public override void Apply(SkeletonData skeletonData) { }

	// RVA: 0x7F7A56C Offset: 0x7F7656C VA: 0x7F7A56C
	public static void ApplyMaterials(SkeletonData skeletonData, Material multiplyTemplate, Material screenTemplate, Material additiveTemplate, bool includeAdditiveSlots) { }

	// RVA: 0x7F7ADC4 Offset: 0x7F76DC4 VA: 0x7F7ADC4
	public void .ctor() { }
}

// Namespace: Spine.Unity
[Usage(256, Inherited = True, AllowMultiple = False)]
public abstract class SpineAttributeBase : PropertyAttribute // TypeDefIndex: 24186
{
	// Fields
	public string dataField; // 0x10
	public string startsWith; // 0x18
	public bool includeNone; // 0x20
	public bool fallbackToTextField; // 0x21

	// Methods

	// RVA: 0x7F7B05C Offset: 0x7F7705C VA: 0x7F7B05C
	protected void .ctor() { }
}

// Namespace: Spine.Unity
public class SpineBone : SpineAttributeBase // TypeDefIndex: 24187
{
	// Methods

	// RVA: 0x7F7B0CC Offset: 0x7F770CC VA: 0x7F7B0CC
	public void .ctor(string startsWith = "", string dataField = "", bool includeNone = True, bool fallbackToTextField = False) { }

	// RVA: 0x7F7B128 Offset: 0x7F77128 VA: 0x7F7B128
	public static Bone GetBone(string boneName, SkeletonRenderer renderer) { }

	// RVA: 0x7F7B158 Offset: 0x7F77158 VA: 0x7F7B158
	public static BoneData GetBoneData(string boneName, SkeletonDataAsset skeletonDataAsset) { }
}

// Namespace: Spine.Unity
public class SpineSlot : SpineAttributeBase // TypeDefIndex: 24188
{
	// Fields
	public bool containsBoundingBoxes; // 0x22

	// Methods

	// RVA: 0x7F7B190 Offset: 0x7F77190 VA: 0x7F7B190
	public void .ctor(string startsWith = "", string dataField = "", bool containsBoundingBoxes = False, bool includeNone = True, bool fallbackToTextField = False) { }
}

// Namespace: Spine.Unity
public class SpineAnimation : SpineAttributeBase // TypeDefIndex: 24189
{
	// Methods

	// RVA: 0x7F7B1FC Offset: 0x7F771FC VA: 0x7F7B1FC
	public void .ctor(string startsWith = "", string dataField = "", bool includeNone = True, bool fallbackToTextField = False) { }
}

// Namespace: Spine.Unity
public class SpineEvent : SpineAttributeBase // TypeDefIndex: 24190
{
	// Fields
	public bool audioOnly; // 0x22

	// Methods

	// RVA: 0x7F7B258 Offset: 0x7F77258 VA: 0x7F7B258
	public void .ctor(string startsWith = "", string dataField = "", bool includeNone = True, bool fallbackToTextField = False, bool audioOnly = False) { }
}

// Namespace: Spine.Unity
public class SpineIkConstraint : SpineAttributeBase // TypeDefIndex: 24191
{
	// Methods

	// RVA: 0x7F7B2C4 Offset: 0x7F772C4 VA: 0x7F7B2C4
	public void .ctor(string startsWith = "", string dataField = "", bool includeNone = True, bool fallbackToTextField = False) { }
}

// Namespace: Spine.Unity
public class SpineTransformConstraint : SpineAttributeBase // TypeDefIndex: 24192
{
	// Methods

	// RVA: 0x7F7B320 Offset: 0x7F77320 VA: 0x7F7B320
	public void .ctor(string startsWith = "", string dataField = "", bool includeNone = True, bool fallbackToTextField = False) { }
}

// Namespace: Spine.Unity
public class SpinePathConstraint : SpineAttributeBase // TypeDefIndex: 24193
{
	// Methods

	// RVA: 0x7F7B37C Offset: 0x7F7737C VA: 0x7F7B37C
	public void .ctor(string startsWith = "", string dataField = "", bool includeNone = True, bool fallbackToTextField = False) { }
}

// Namespace: Spine.Unity
public class SpineSkin : SpineAttributeBase // TypeDefIndex: 24194
{
	// Fields
	public bool defaultAsEmptyString; // 0x22

	// Methods

	// RVA: 0x7F7B3D8 Offset: 0x7F773D8 VA: 0x7F7B3D8
	public void .ctor(string startsWith = "", string dataField = "", bool includeNone = True, bool fallbackToTextField = False, bool defaultAsEmptyString = False) { }
}

// Namespace: 
public struct SpineAttachment.Hierarchy // TypeDefIndex: 24195
{
	// Fields
	public string skin; // 0x0
	public string slot; // 0x8
	public string name; // 0x10

	// Methods

	// RVA: 0x7F7B570 Offset: 0x7F77570 VA: 0x7F7B570
	public void .ctor(string fullPath) { }
}

// Namespace: Spine.Unity
public class SpineAttachment : SpineAttributeBase // TypeDefIndex: 24196
{
	// Fields
	public bool returnAttachmentPath; // 0x22
	public bool currentSkinOnly; // 0x23
	public bool placeholdersOnly; // 0x24
	public string skinField; // 0x28
	public string slotField; // 0x30

	// Methods

	// RVA: 0x7F7B444 Offset: 0x7F77444 VA: 0x7F7B444
	public void .ctor(bool currentSkinOnly = True, bool returnAttachmentPath = False, bool placeholdersOnly = False, string slotField = "", string dataField = "", string skinField = "", bool includeNone = True, bool fallbackToTextField = False) { }

	// RVA: 0x7F7B55C Offset: 0x7F7755C VA: 0x7F7B55C
	public static SpineAttachment.Hierarchy GetHierarchy(string fullPath) { }

	// RVA: 0x7F7B764 Offset: 0x7F77764 VA: 0x7F7B764
	public static Attachment GetAttachment(string attachmentPath, SkeletonData skeletonData) { }

	// RVA: 0x7F7B800 Offset: 0x7F77800 VA: 0x7F7B800
	public static Attachment GetAttachment(string attachmentPath, SkeletonDataAsset skeletonDataAsset) { }
}

// Namespace: Spine.Unity
public class SpineAtlasRegion : PropertyAttribute // TypeDefIndex: 24197
{
	// Fields
	public string atlasAssetField; // 0x10

	// Methods

	// RVA: 0x7F7B834 Offset: 0x7F77834 VA: 0x7F7B834
	public void .ctor(string atlasAssetField = "") { }
}

// Namespace: Spine.Unity
public static class MathUtilities // TypeDefIndex: 24198
{
	// Methods

	// RVA: 0x7F7B864 Offset: 0x7F77864 VA: 0x7F7B864
	public static float InverseLerp(float a, float b, float value) { }

	// RVA: 0x7F7B874 Offset: 0x7F77874 VA: 0x7F7B874
	public static Vector2 InverseLerp(Vector2 a, Vector2 b, Vector2 value) { }

	// RVA: 0x7F7B890 Offset: 0x7F77890 VA: 0x7F7B890
	public static Vector3 InverseLerp(Vector3 a, Vector3 b, Vector3 value) { }

	// RVA: 0x7F7B8C0 Offset: 0x7F778C0 VA: 0x7F7B8C0
	public static Vector4 InverseLerp(Vector4 a, Vector4 b, Vector4 value) { }
}

// Namespace: Spine.Unity
public enum SettingsTriState // TypeDefIndex: 24199
{
	// Fields
	public int value__; // 0x0
	public const SettingsTriState Disable = 0;
	public const SettingsTriState Enable = 1;
	public const SettingsTriState UseGlobalSetting = 2;
}

// Namespace: Spine.Unity
[Extension]
public static class SkeletonExtensions // TypeDefIndex: 24200
{
	// Fields
	private const float ByteToFloat = 0.003921569;

	// Methods

	[Extension]
	// RVA: 0x7F7B8FC Offset: 0x7F778FC VA: 0x7F7B8FC
	public static Color GetColor(Skeleton s) { }

	[Extension]
	// RVA: 0x7F7B918 Offset: 0x7F77918 VA: 0x7F7B918
	public static Color GetColor(RegionAttachment a) { }

	[Extension]
	// RVA: 0x7F7B934 Offset: 0x7F77934 VA: 0x7F7B934
	public static Color GetColor(MeshAttachment a) { }

	[Extension]
	// RVA: 0x7F7B950 Offset: 0x7F77950 VA: 0x7F7B950
	public static Color GetColor(Slot s) { }

	[Extension]
	// RVA: 0x7F7B96C Offset: 0x7F7796C VA: 0x7F7B96C
	public static Color GetColorTintBlack(Slot s) { }

	[Extension]
	// RVA: 0x7F7B98C Offset: 0x7F7798C VA: 0x7F7B98C
	public static void SetColor(Skeleton skeleton, Color color) { }

	[Extension]
	// RVA: 0x7F7B9A8 Offset: 0x7F779A8 VA: 0x7F7B9A8
	public static void SetColor(Skeleton skeleton, Color32 color) { }

	[Extension]
	// RVA: 0x7F7B9F8 Offset: 0x7F779F8 VA: 0x7F7B9F8
	public static void SetColor(Slot slot, Color color) { }

	[Extension]
	// RVA: 0x7F7BA14 Offset: 0x7F77A14 VA: 0x7F7BA14
	public static void SetColor(Slot slot, Color32 color) { }

	[Extension]
	// RVA: 0x7F7BA64 Offset: 0x7F77A64 VA: 0x7F7BA64
	public static void SetColor(RegionAttachment attachment, Color color) { }

	[Extension]
	// RVA: 0x7F7BA80 Offset: 0x7F77A80 VA: 0x7F7BA80
	public static void SetColor(RegionAttachment attachment, Color32 color) { }

	[Extension]
	// RVA: 0x7F7BAD0 Offset: 0x7F77AD0 VA: 0x7F7BAD0
	public static void SetColor(MeshAttachment attachment, Color color) { }

	[Extension]
	// RVA: 0x7F7BAEC Offset: 0x7F77AEC VA: 0x7F7BAEC
	public static void SetColor(MeshAttachment attachment, Color32 color) { }

	[Extension]
	// RVA: 0x7F7BB3C Offset: 0x7F77B3C VA: 0x7F7BB3C
	public static void SetLocalScale(Skeleton skeleton, Vector2 scale) { }

	[Extension]
	// RVA: 0x7F7BB54 Offset: 0x7F77B54 VA: 0x7F7BB54
	public static Matrix4x4 GetMatrix4x4(Bone bone) { }

	[Extension]
	// RVA: 0x7F7BBA8 Offset: 0x7F77BA8 VA: 0x7F7BBA8
	public static void SetLocalPosition(Bone bone, Vector2 position) { }

	[Extension]
	// RVA: 0x7F7BBC0 Offset: 0x7F77BC0 VA: 0x7F7BBC0
	public static void SetLocalPosition(Bone bone, Vector3 position) { }

	[Extension]
	// RVA: 0x7F7BBD8 Offset: 0x7F77BD8 VA: 0x7F7BBD8
	public static Vector2 GetLocalPosition(Bone bone) { }

	[Extension]
	// RVA: 0x7F7BBF0 Offset: 0x7F77BF0 VA: 0x7F7BBF0
	public static Vector2 GetSkeletonSpacePosition(Bone bone) { }

	[Extension]
	// RVA: 0x7F7BC0C Offset: 0x7F77C0C VA: 0x7F7BC0C
	public static Vector2 GetSkeletonSpacePosition(Bone bone, Vector2 boneLocal) { }

	[Extension]
	// RVA: 0x7F7BC3C Offset: 0x7F77C3C VA: 0x7F7BC3C
	public static Vector3 GetWorldPosition(Bone bone, Transform spineGameObjectTransform) { }

	[Extension]
	// RVA: 0x7F7BC68 Offset: 0x7F77C68 VA: 0x7F7BC68
	public static Vector3 GetWorldPosition(Bone bone, Transform spineGameObjectTransform, float positionScale) { }

	[Extension]
	// RVA: 0x7F7BC9C Offset: 0x7F77C9C VA: 0x7F7BC9C
	public static Quaternion GetQuaternion(Bone bone) { }

	[Extension]
	// RVA: 0x7F7BCDC Offset: 0x7F77CDC VA: 0x7F7BCDC
	public static Quaternion GetLocalQuaternion(Bone bone) { }

	[Extension]
	// RVA: 0x7F7BD20 Offset: 0x7F77D20 VA: 0x7F7BD20
	public static Vector2 GetLocalScale(Skeleton skeleton) { }

	[Extension]
	// RVA: 0x7F7BD50 Offset: 0x7F77D50 VA: 0x7F7BD50
	public static void GetWorldToLocalMatrix(Bone bone, out float ia, out float ib, out float ic, out float id) { }

	[Extension]
	// RVA: 0x7F7BDA8 Offset: 0x7F77DA8 VA: 0x7F7BDA8
	public static Vector2 WorldToLocal(Bone bone, Vector2 worldPosition) { }

	[Extension]
	// RVA: 0x7F7BDD8 Offset: 0x7F77DD8 VA: 0x7F7BDD8
	public static Vector2 SetPositionSkeletonSpace(Bone bone, Vector2 skeletonSpacePosition) { }

	[Extension]
	// RVA: 0x7F7BE00 Offset: 0x7F77E00 VA: 0x7F7BE00
	public static Material GetMaterial(Attachment a) { }

	[Extension]
	// RVA: 0x7F7BF4C Offset: 0x7F77F4C VA: 0x7F7BF4C
	public static Vector2[] GetLocalVertices(VertexAttachment va, Slot slot, Vector2[] buffer) { }

	[Extension]
	// RVA: 0x7F7C200 Offset: 0x7F78200 VA: 0x7F7C200
	public static Vector2[] GetWorldVertices(VertexAttachment a, Slot slot, Vector2[] buffer) { }

	[Extension]
	// RVA: 0x7F7C3C8 Offset: 0x7F783C8 VA: 0x7F7C3C8
	public static Vector3 GetWorldPosition(PointAttachment attachment, Slot slot, Transform spineGameObjectTransform) { }

	[Extension]
	// RVA: 0x7F7C424 Offset: 0x7F78424 VA: 0x7F7C424
	public static Vector3 GetWorldPosition(PointAttachment attachment, Bone bone, Transform spineGameObjectTransform) { }
}

// Namespace: 
[Flags]
public enum WaitForSpineAnimation.AnimationEventTypes // TypeDefIndex: 24201
{
	// Fields
	public int value__; // 0x0
	public const WaitForSpineAnimation.AnimationEventTypes Start = 1;
	public const WaitForSpineAnimation.AnimationEventTypes Interrupt = 2;
	public const WaitForSpineAnimation.AnimationEventTypes End = 4;
	public const WaitForSpineAnimation.AnimationEventTypes Dispose = 8;
	public const WaitForSpineAnimation.AnimationEventTypes Complete = 16;
}

// Namespace: Spine.Unity
public class WaitForSpineAnimation : IEnumerator // TypeDefIndex: 24202
{
	// Fields
	private bool m_WasFired; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x7F7C478 Offset: 0x7F78478 VA: 0x7F7C478
	public void .ctor(TrackEntry trackEntry, WaitForSpineAnimation.AnimationEventTypes eventsToWaitFor) { }

	// RVA: 0x7F7C6B4 Offset: 0x7F786B4 VA: 0x7F7C6B4
	public WaitForSpineAnimation NowWaitFor(TrackEntry trackEntry, WaitForSpineAnimation.AnimationEventTypes eventsToWaitFor) { }

	// RVA: 0x7F7C6CC Offset: 0x7F786CC VA: 0x7F7C6CC Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x7F7C778 Offset: 0x7F78778 VA: 0x7F7C778 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7F7C780 Offset: 0x7F78780 VA: 0x7F7C780 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7F7C4AC Offset: 0x7F784AC VA: 0x7F7C4AC
	protected void SafeSubscribe(TrackEntry trackEntry, WaitForSpineAnimation.AnimationEventTypes eventsToWaitFor) { }

	// RVA: 0x7F7C788 Offset: 0x7F78788 VA: 0x7F7C788
	private void HandleComplete(TrackEntry trackEntry) { }
}

// Namespace: Spine.Unity
public class WaitForSpineAnimationComplete : WaitForSpineAnimation, IEnumerator // TypeDefIndex: 24203
{
	// Methods

	// RVA: 0x7F7C794 Offset: 0x7F78794 VA: 0x7F7C794
	public void .ctor(TrackEntry trackEntry, bool includeEndEvent = False) { }

	// RVA: 0x7F7C7D4 Offset: 0x7F787D4 VA: 0x7F7C7D4
	public WaitForSpineAnimationComplete NowWaitFor(TrackEntry trackEntry, bool includeEndEvent = False) { }
}

// Namespace: Spine.Unity
public class WaitForSpineAnimationEnd : WaitForSpineAnimation, IEnumerator // TypeDefIndex: 24204
{
	// Methods

	// RVA: 0x7F7C804 Offset: 0x7F78804 VA: 0x7F7C804
	public void .ctor(TrackEntry trackEntry) { }

	// RVA: 0x7F7C834 Offset: 0x7F78834 VA: 0x7F7C834
	public WaitForSpineAnimationEnd NowWaitFor(TrackEntry trackEntry) { }
}

// Namespace: Spine.Unity
public class WaitForSpineEvent : IEnumerator // TypeDefIndex: 24205
{
	// Fields
	private EventData m_TargetEvent; // 0x10
	private string m_EventName; // 0x18
	private AnimationState m_AnimationState; // 0x20
	private bool m_WasFired; // 0x28
	private bool m_unsubscribeAfterFiring; // 0x29

	// Properties
	public bool WillUnsubscribeAfterFiring { get; set; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x7F7C850 Offset: 0x7F78850 VA: 0x7F7C850
	private void Subscribe(AnimationState state, EventData eventDataReference, bool unsubscribe) { }

	// RVA: 0x7F7C994 Offset: 0x7F78994 VA: 0x7F7C994
	private void SubscribeByName(AnimationState state, string eventName, bool unsubscribe) { }

	// RVA: 0x7F7CAE4 Offset: 0x7F78AE4 VA: 0x7F7CAE4
	public void .ctor(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = True) { }

	// RVA: 0x7F7CB28 Offset: 0x7F78B28 VA: 0x7F7CB28
	public void .ctor(SkeletonAnimation skeletonAnimation, EventData eventDataReference, bool unsubscribeAfterFiring = True) { }

	// RVA: 0x7F7CB74 Offset: 0x7F78B74 VA: 0x7F7CB74
	public void .ctor(AnimationState state, string eventName, bool unsubscribeAfterFiring = True) { }

	// RVA: 0x7F7CBB8 Offset: 0x7F78BB8 VA: 0x7F7CBB8
	public void .ctor(SkeletonAnimation skeletonAnimation, string eventName, bool unsubscribeAfterFiring = True) { }

	// RVA: 0x7F7CC04 Offset: 0x7F78C04 VA: 0x7F7CC04
	private void HandleAnimationStateEventByName(TrackEntry trackEntry, Event e) { }

	// RVA: 0x7F7CCD4 Offset: 0x7F78CD4 VA: 0x7F7CCD4
	private void HandleAnimationStateEvent(TrackEntry trackEntry, Event e) { }

	// RVA: 0x7F7CD98 Offset: 0x7F78D98 VA: 0x7F7CD98
	public bool get_WillUnsubscribeAfterFiring() { }

	// RVA: 0x7F7CDA0 Offset: 0x7F78DA0 VA: 0x7F7CDA0
	public void set_WillUnsubscribeAfterFiring(bool value) { }

	// RVA: 0x7F7CDAC Offset: 0x7F78DAC VA: 0x7F7CDAC
	public WaitForSpineEvent NowWaitFor(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = True) { }

	// RVA: 0x7F7CF58 Offset: 0x7F78F58 VA: 0x7F7CF58
	public WaitForSpineEvent NowWaitFor(AnimationState state, string eventName, bool unsubscribeAfterFiring = True) { }

	// RVA: 0x7F7CE88 Offset: 0x7F78E88 VA: 0x7F7CE88
	private void Clear(AnimationState state) { }

	// RVA: 0x7F7D034 Offset: 0x7F79034 VA: 0x7F7D034 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x7F7D0E0 Offset: 0x7F790E0 VA: 0x7F7D0E0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7F7D0E8 Offset: 0x7F790E8 VA: 0x7F7D0E8 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Spine.Unity
public class WaitForSpineTrackEntryEnd : IEnumerator // TypeDefIndex: 24206
{
	// Fields
	private bool m_WasFired; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x7F7D0F0 Offset: 0x7F790F0 VA: 0x7F7D0F0
	public void .ctor(TrackEntry trackEntry) { }

	// RVA: 0x7F7D1F8 Offset: 0x7F791F8 VA: 0x7F7D1F8
	private void HandleEnd(TrackEntry trackEntry) { }

	// RVA: 0x7F7D11C Offset: 0x7F7911C VA: 0x7F7D11C
	private void SafeSubscribe(TrackEntry trackEntry) { }

	// RVA: 0x7F7D204 Offset: 0x7F79204 VA: 0x7F7D204
	public WaitForSpineTrackEntryEnd NowWaitFor(TrackEntry trackEntry) { }

	// RVA: 0x7F7D21C Offset: 0x7F7921C VA: 0x7F7D21C Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x7F7D2C8 Offset: 0x7F792C8 VA: 0x7F7D2C8 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7F7D2D0 Offset: 0x7F792D0 VA: 0x7F7D2D0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Spine.Unity.AnimationTools
[Extension]
public static class TimelineExtensions // TypeDefIndex: 24207
{
	// Methods

	[Extension]
	// RVA: 0x7F7D2D8 Offset: 0x7F792D8 VA: 0x7F7D2D8
	public static Vector2 Evaluate(TranslateTimeline timeline, float time, SkeletonData skeletonData) { }

	// RVA: 0x7F7D3B4 Offset: 0x7F793B4 VA: 0x7F7D3B4
	public static Vector2 Evaluate(TranslateXTimeline xTimeline, TranslateYTimeline yTimeline, float time, SkeletonData skeletonData) { }

	[Extension]
	// RVA: 0x7F7D4CC Offset: 0x7F794CC VA: 0x7F7D4CC
	public static float Evaluate(RotateTimeline timeline, float time, SkeletonData skeletonData) { }

	[Extension]
	// RVA: 0x7F7D560 Offset: 0x7F79560 VA: 0x7F7D560
	public static Vector2 EvaluateTranslateXYMix(TransformConstraintTimeline timeline, float time) { }

	[Extension]
	// RVA: 0x7F7D610 Offset: 0x7F79610 VA: 0x7F7D610
	public static float EvaluateRotateMix(TransformConstraintTimeline timeline, float time) { }

	[Extension]
	// RVA: 0x7F7D67C Offset: 0x7F7967C VA: 0x7F7D67C
	public static TranslateTimeline FindTranslateTimelineForBone(Animation a, int boneIndex) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T FindTimelineForBone<T>(Animation a, int boneIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471F3D0 Offset: 0x471B3D0 VA: 0x471F3D0
	|-TimelineExtensions.FindTimelineForBone<object>
	*/

	[Extension]
	// RVA: 0x7F7D8C0 Offset: 0x7F798C0 VA: 0x7F7D8C0
	public static TransformConstraintTimeline FindTransformConstraintTimeline(Animation a, int transformConstraintIndex) { }
}

// Namespace: 
private struct AtlasUtilities.IntAndAtlasRegionKey // TypeDefIndex: 24208
{
	// Fields
	private int i; // 0x0
	private AtlasRegion region; // 0x8

	// Methods

	// RVA: 0x7F81748 Offset: 0x7F7D748 VA: 0x7F81748
	public void .ctor(int i, AtlasRegion region) { }

	// RVA: 0x7F81ED0 Offset: 0x7F7DED0 VA: 0x7F81ED0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Spine.Unity.AttachmentTools
[Extension]
public static class AtlasUtilities // TypeDefIndex: 24209
{
	// Fields
	internal const TextureFormat SpineTextureFormat = 4;
	internal const float DefaultMipmapBias = -0.5;
	internal const bool UseMipMaps = False;
	internal const float DefaultScale = 0.01;
	private const int NonrenderingRegion = -1;
	private static readonly Dictionary<AtlasRegion, int> existingRegions; // 0x0
	private static readonly List<int> regionIndices; // 0x8
	private static readonly List<AtlasRegion> originalRegions; // 0x10
	private static readonly List<AtlasRegion> repackedRegions; // 0x18
	private static List<Texture2D>[] texturesToPackAtParam; // 0x20
	private static List<Attachment> inoutAttachments; // 0x28
	private static Dictionary<AtlasUtilities.IntAndAtlasRegionKey, Texture2D> CachedRegionTextures; // 0x30
	private static List<Texture2D> CachedRegionTexturesList; // 0x38

	// Methods

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x7F7DB04 Offset: 0x7F79B04 VA: 0x7F7DB04
	private static void Init() { }

	[Extension]
	// RVA: 0x7F7DD5C Offset: 0x7F79D5C VA: 0x7F7DD5C
	public static AtlasRegion ToAtlasRegion(Texture2D t, Material materialPropertySource, float scale = 0.01) { }

	[Extension]
	// RVA: 0x7F7DDE8 Offset: 0x7F79DE8 VA: 0x7F7DDE8
	public static AtlasRegion ToAtlasRegion(Texture2D t, Shader shader, float scale = 0.01, Material materialPropertySource) { }

	[Extension]
	// RVA: 0x7F7E148 Offset: 0x7F7A148 VA: 0x7F7E148
	public static AtlasRegion ToAtlasRegionPMAClone(Texture2D t, Material materialPropertySource, TextureFormat textureFormat = 4, bool mipmaps = False) { }

	[Extension]
	// RVA: 0x7F7E1DC Offset: 0x7F7A1DC VA: 0x7F7E1DC
	public static AtlasRegion ToAtlasRegionPMAClone(Texture2D t, Shader shader, TextureFormat textureFormat = 4, bool mipmaps = False, Material materialPropertySource) { }

	[Extension]
	// RVA: 0x7F7E030 Offset: 0x7F7A030 VA: 0x7F7E030
	public static AtlasPage ToSpineAtlasPage(Material m) { }

	[Extension]
	// RVA: 0x7F7E568 Offset: 0x7F7A568 VA: 0x7F7E568
	public static AtlasRegion ToAtlasRegion(Sprite s, AtlasPage page) { }

	[Extension]
	// RVA: 0x7F7E95C Offset: 0x7F7A95C VA: 0x7F7E95C
	public static AtlasRegion ToAtlasRegion(Sprite s, Material material) { }

	[Extension]
	// RVA: 0x7F7E9EC Offset: 0x7F7A9EC VA: 0x7F7E9EC
	public static AtlasRegion ToAtlasRegionPMAClone(Sprite s, Material materialPropertySource, TextureFormat textureFormat = 4, bool mipmaps = False) { }

	[Extension]
	// RVA: 0x7F7EA80 Offset: 0x7F7AA80 VA: 0x7F7EA80
	public static AtlasRegion ToAtlasRegionPMAClone(Sprite s, Shader shader, TextureFormat textureFormat = 4, bool mipmaps = False, Material materialPropertySource) { }

	[Extension]
	// RVA: 0x7F7E644 Offset: 0x7F7A644 VA: 0x7F7E644
	internal static AtlasRegion ToAtlasRegion(Sprite s, bool isolatedTexture = False) { }

	// RVA: 0x7F7F080 Offset: 0x7F7B080 VA: 0x7F7F080
	public static void GetRepackedAttachments(List<Attachment> sourceAttachments, List<Attachment> outputAttachments, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = 4, bool mipmaps = False, string newAssetName = "Repacked Attachments", bool clearCache = False, bool useOriginalNonrenderables = True, int[] additionalTexturePropertyIDsToCopy, Texture2D[] additionalOutputTextures, TextureFormat[] additionalTextureFormats, bool[] additionalTextureIsLinear) { }

	// RVA: 0x7F7F1F4 Offset: 0x7F7B1F4 VA: 0x7F7F1F4
	public static void GetRepackedAttachments(List<Attachment> sourceAttachments, List<Attachment> outputAttachments, Shader shader, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = 4, bool mipmaps = False, string newAssetName = "Repacked Attachments", Material materialPropertySource, bool clearCache = False, bool useOriginalNonrenderables = True, int[] additionalTexturePropertyIDsToCopy, Texture2D[] additionalOutputTextures, TextureFormat[] additionalTextureFormats, bool[] additionalTextureIsLinear) { }

	[Extension]
	// RVA: 0x7F80C50 Offset: 0x7F7CC50 VA: 0x7F80C50
	public static Skin GetRepackedSkin(Skin o, string newName, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = 4, bool mipmaps = False, bool useOriginalNonrenderables = True, bool clearCache = False, int[] additionalTexturePropertyIDsToCopy, Texture2D[] additionalOutputTextures, TextureFormat[] additionalTextureFormats, bool[] additionalTextureIsLinear) { }

	[Extension]
	// RVA: 0x7F80D40 Offset: 0x7F7CD40 VA: 0x7F80D40
	public static Skin GetRepackedSkin(Skin o, string newName, Shader shader, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = 4, bool mipmaps = False, Material materialPropertySource, bool clearCache = False, bool useOriginalNonrenderables = True, int[] additionalTexturePropertyIDsToCopy, Texture2D[] additionalOutputTextures, TextureFormat[] additionalTextureFormats, bool[] additionalTextureIsLinear) { }

	[Extension]
	// RVA: 0x7F81594 Offset: 0x7F7D594 VA: 0x7F81594
	public static Sprite ToSprite(AtlasRegion ar, float pixelsPerUnit = 100) { }

	// RVA: 0x7F7DB50 Offset: 0x7F79B50 VA: 0x7F7DB50
	public static void ClearCache() { }

	[Extension]
	// RVA: 0x7F80374 Offset: 0x7F7C374 VA: 0x7F80374
	public static Texture2D ToTexture(AtlasRegion ar, TextureFormat textureFormat = 4, bool mipmaps = False, int texturePropertyId = 0, bool linear = False, bool applyPMA = False) { }

	[Extension]
	// RVA: 0x7F7EC78 Offset: 0x7F7AC78 VA: 0x7F7EC78
	private static Texture2D ToTexture(Sprite s, TextureFormat textureFormat = 4, bool mipmaps = False, bool linear = False, bool applyPMA = False) { }

	[Extension]
	// RVA: 0x7F7E3E0 Offset: 0x7F7A3E0 VA: 0x7F7E3E0
	private static Texture2D GetClone(Texture2D t, TextureFormat textureFormat = 4, bool mipmaps = False, bool linear = False, bool applyPMA = False) { }

	// RVA: 0x7F818DC Offset: 0x7F7D8DC VA: 0x7F818DC
	private static void CopyTexture(Texture2D source, Rect sourceRect, Texture2D destination) { }

	// RVA: 0x7F81814 Offset: 0x7F7D814 VA: 0x7F81814
	private static void CopyTextureApplyPMA(Texture2D source, Rect sourceRect, Texture2D destination) { }

	// RVA: 0x7F81A4C Offset: 0x7F7DA4C VA: 0x7F81A4C
	private static bool IsRenderable(Attachment a) { }

	[Extension]
	// RVA: 0x7F7EFDC Offset: 0x7F7AFDC VA: 0x7F7EFDC
	private static Rect SpineUnityFlipRect(Rect rect, int textureHeight) { }

	[Extension]
	// RVA: 0x7F816CC Offset: 0x7F7D6CC VA: 0x7F816CC
	private static Rect GetUnityRect(AtlasRegion region) { }

	[Extension]
	// RVA: 0x7F81AE4 Offset: 0x7F7DAE4 VA: 0x7F81AE4
	private static Rect GetUnityRect(AtlasRegion region, int textureHeight) { }

	[Extension]
	// RVA: 0x7F81AA0 Offset: 0x7F7DAA0 VA: 0x7F81AA0
	private static Rect GetSpineAtlasRect(AtlasRegion region, bool includeRotate = True) { }

	// RVA: 0x7F81B58 Offset: 0x7F7DB58 VA: 0x7F81B58
	private static Rect UVRectToTextureRect(Rect uvRect, int texWidth, int texHeight) { }

	// RVA: 0x7F7EFEC Offset: 0x7F7AFEC VA: 0x7F7EFEC
	private static Rect TextureRectToUVRect(Rect textureRect, int texWidth, int texHeight) { }

	// RVA: 0x7F80730 Offset: 0x7F7C730 VA: 0x7F80730
	private static AtlasRegion UVRectToAtlasRegion(Rect uvRect, AtlasRegion referenceRegion, AtlasPage page) { }

	[Extension]
	// RVA: 0x7F81618 Offset: 0x7F7D618 VA: 0x7F81618
	private static Texture2D GetMainTexture(AtlasRegion region) { }

	[Extension]
	// RVA: 0x7F81B74 Offset: 0x7F7DB74 VA: 0x7F81B74
	private static Texture2D GetTexture(AtlasRegion region, string texturePropertyName) { }

	[Extension]
	// RVA: 0x7F81758 Offset: 0x7F7D758 VA: 0x7F81758
	private static Texture2D GetTexture(AtlasRegion region, int texturePropertyId) { }

	[Extension]
	// RVA: 0x7F80680 Offset: 0x7F7C680 VA: 0x7F80680
	private static void CopyTextureAttributesFrom(Texture2D destination, Texture2D source) { }

	// RVA: 0x7F7E138 Offset: 0x7F7A138 VA: 0x7F7E138
	private static float InverseLerp(float a, float b, float value) { }

	// RVA: 0x7F81C30 Offset: 0x7F7DC30 VA: 0x7F81C30
	private static void .cctor() { }
}

// Namespace: Spine.Unity.AttachmentTools
[Extension]
public static class AttachmentCloneExtensions // TypeDefIndex: 24210
{
	// Methods

	[Extension]
	// RVA: 0x7F81F14 Offset: 0x7F7DF14 VA: 0x7F81F14
	public static Attachment GetRemappedClone(Attachment o, Sprite sprite, Material sourceMaterial, bool premultiplyAlpha = True, bool cloneMeshAsLinked = True, bool useOriginalRegionSize = False, bool pivotShiftsMeshUVCoords = True, bool useOriginalRegionScale = False, TextureFormat pmaCloneTextureFormat = 4, bool pmaCloneMipmaps = False) { }

	[Extension]
	// RVA: 0x7F82128 Offset: 0x7F7E128 VA: 0x7F82128
	public static Attachment GetRemappedClone(Attachment o, AtlasRegion atlasRegion, bool cloneMeshAsLinked = True, bool useOriginalRegionSize = False, float scale = 0.01) { }
}

// Namespace: Spine.Unity.AttachmentTools
[Extension]
public static class AttachmentRegionExtensions // TypeDefIndex: 24211
{
	// Methods

	[Extension]
	// RVA: 0x7F82310 Offset: 0x7F7E310 VA: 0x7F82310
	public static RegionAttachment ToRegionAttachment(Sprite sprite, Material material, float rotation = 0) { }

	[Extension]
	// RVA: 0x7F8238C Offset: 0x7F7E38C VA: 0x7F8238C
	public static RegionAttachment ToRegionAttachment(Sprite sprite, AtlasPage page, float rotation = 0) { }

	[Extension]
	// RVA: 0x7F826C0 Offset: 0x7F7E6C0 VA: 0x7F826C0
	public static RegionAttachment ToRegionAttachmentPMAClone(Sprite sprite, Shader shader, TextureFormat textureFormat = 4, bool mipmaps = False, Material materialPropertySource, float rotation = 0) { }

	[Extension]
	// RVA: 0x7F82854 Offset: 0x7F7E854 VA: 0x7F82854
	public static RegionAttachment ToRegionAttachmentPMAClone(Sprite sprite, Material materialPropertySource, TextureFormat textureFormat = 4, bool mipmaps = False, float rotation = 0) { }

	[Extension]
	// RVA: 0x7F824E0 Offset: 0x7F7E4E0 VA: 0x7F824E0
	public static RegionAttachment ToRegionAttachment(AtlasRegion region, string attachmentName, float scale = 0.01, float rotation = 0) { }

	[Extension]
	// RVA: 0x7F828B8 Offset: 0x7F7E8B8 VA: 0x7F828B8
	public static void SetScale(RegionAttachment regionAttachment, Vector2 scale) { }

	[Extension]
	// RVA: 0x7F828D0 Offset: 0x7F7E8D0 VA: 0x7F828D0
	public static void SetScale(RegionAttachment regionAttachment, float x, float y) { }

	[Extension]
	// RVA: 0x7F828E8 Offset: 0x7F7E8E8 VA: 0x7F828E8
	public static void SetPositionOffset(RegionAttachment regionAttachment, Vector2 offset) { }

	[Extension]
	// RVA: 0x7F82900 Offset: 0x7F7E900 VA: 0x7F82900
	public static void SetPositionOffset(RegionAttachment regionAttachment, float x, float y) { }

	[Extension]
	// RVA: 0x7F82918 Offset: 0x7F7E918 VA: 0x7F82918
	public static void SetRotation(RegionAttachment regionAttachment, float rotation) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 // TypeDefIndex: 24212
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4005 // TypeDefIndex: 24213
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5094 // TypeDefIndex: 24214
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 24215
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 0C6A9A02BE5F7EB53FB20C6B5B3C610B857B50E630614FEC5F4BFCD7FC6F1567 /*Metadata offset 0xF34C20*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4005 51C5EDCA9F4C774BE3AEB002A5880EFB2D9D43EB4E2FB7353CC4484F9D02479C /*Metadata offset 0xF34C40*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 753D5E1ADA77B20B9959A1030B8E0BA5CF925F2881D3635C3F791E5A0AE0EEB1 /*Metadata offset 0xF35BE8*/; // 0xFBD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5094 F87BF1BD0D0FE8F89F2206DADA871FB1EAED914BBC3C2527A0BAAD1C289752EC /*Metadata offset 0xF35C08*/; // 0xFD5
}

