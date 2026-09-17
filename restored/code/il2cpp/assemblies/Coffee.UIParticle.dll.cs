// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27940
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 27941
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 27942
{
	// Methods

	// RVA: 0x40DA2A8 Offset: 0x40D62A8 VA: 0x40DA2A8
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x40DA3A0 Offset: 0x40D63A0 VA: 0x40DA3A0
	public void .ctor() { }
}

// Namespace: 
private class ModifiedMaterial.MatEntry // TypeDefIndex: 27943
{
	// Fields
	public Material baseMat; // 0x10
	public int count; // 0x18
	public Material customMat; // 0x20
	public int id; // 0x28
	public int props; // 0x2C
	public Texture texture; // 0x30

	// Methods

	// RVA: 0x40DA734 Offset: 0x40D6734 VA: 0x40DA734
	public void .ctor() { }
}

// Namespace: Coffee.UIParticleExtensions
internal class ModifiedMaterial // TypeDefIndex: 27944
{
	// Fields
	private static readonly List<ModifiedMaterial.MatEntry> s_Entries; // 0x0

	// Methods

	// RVA: 0x40DA3A8 Offset: 0x40D63A8 VA: 0x40DA3A8
	public static Material Add(Material baseMat, Texture texture, int id, int props) { }

	// RVA: 0x40DA73C Offset: 0x40D673C VA: 0x40DA73C
	public static void Remove(Material customMat) { }

	// RVA: 0x40DA9A4 Offset: 0x40D69A4 VA: 0x40DA9A4
	public void .ctor() { }

	// RVA: 0x40DA9AC Offset: 0x40D69AC VA: 0x40DA9AC
	private static void .cctor() { }
}

// Namespace: Coffee.UIParticleExtensions
[Extension]
public static class Color32Extensions // TypeDefIndex: 27945
{
	// Fields
	private static byte[] s_LinearToGammaLut; // 0x0

	// Methods

	[Extension]
	// RVA: 0x40DAA44 Offset: 0x40D6A44 VA: 0x40DAA44
	public static byte LinearToGamma(byte self) { }
}

// Namespace: Coffee.UIParticleExtensions
[Extension]
public static class Vector3Extensions // TypeDefIndex: 27946
{
	// Methods

	[Extension]
	// RVA: 0x40DAB64 Offset: 0x40D6B64 VA: 0x40DAB64
	public static Vector3 Inverse(Vector3 self) { }

	[Extension]
	// RVA: 0x40DAC48 Offset: 0x40D6C48 VA: 0x40DAC48
	public static Vector3 GetScaled(Vector3 self, Vector3 other1) { }

	[Extension]
	// RVA: 0x40DAC58 Offset: 0x40D6C58 VA: 0x40DAC58
	public static Vector3 GetScaled(Vector3 self, Vector3 other1, Vector3 other2) { }

	[Extension]
	// RVA: 0x40DAC7C Offset: 0x40D6C7C VA: 0x40DAC7C
	public static Vector3 GetScaled(Vector3 self, Vector3 other1, Vector3 other2, Vector3 other3) { }

	[Extension]
	// RVA: 0x40DACB4 Offset: 0x40D6CB4 VA: 0x40DACB4
	public static bool IsVisible(Vector3 self) { }
}

// Namespace: Coffee.UIParticleExtensions
[Extension]
internal static class SpriteExtensions // TypeDefIndex: 27947
{
	// Methods

	[Extension]
	// RVA: 0x40DACCC Offset: 0x40D6CCC VA: 0x40DACCC
	internal static Texture2D GetActualTexture(Sprite self) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ParticleSystemExtensions.<>c // TypeDefIndex: 27948
{
	// Fields
	public static readonly ParticleSystemExtensions.<>c <>9; // 0x0
	public static Predicate<ParticleSystem> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x40DB824 Offset: 0x40D7824 VA: 0x40DB824
	private static void .cctor() { }

	// RVA: 0x40DB88C Offset: 0x40D788C VA: 0x40DB88C
	public void .ctor() { }

	// RVA: 0x40DB894 Offset: 0x40D7894 VA: 0x40DB894
	internal bool <Exec>b__10_0(ParticleSystem p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ParticleSystemExtensions.<>c__DisplayClass7_0 // TypeDefIndex: 27949
{
	// Fields
	public bool sortByMaterial; // 0x10
	public Transform transform; // 0x18
	public List<ParticleSystem> self; // 0x20

	// Methods

	// RVA: 0x40DB3E8 Offset: 0x40D73E8 VA: 0x40DB3E8
	public void .ctor() { }

	// RVA: 0x40DB8F8 Offset: 0x40D78F8 VA: 0x40DB8F8
	internal int <SortForRendering>b__0(ParticleSystem a, ParticleSystem b) { }
}

// Namespace: Coffee.UIParticleExtensions
[Extension]
public static class ParticleSystemExtensions // TypeDefIndex: 27950
{
	// Fields
	private static ParticleSystem.Particle[] s_TmpParticles; // 0x0

	// Methods

	// RVA: 0x40DAD4C Offset: 0x40D6D4C VA: 0x40DAD4C
	public static ParticleSystem.Particle[] GetParticleArray(int size) { }

	[Extension]
	// RVA: 0x40DAE78 Offset: 0x40D6E78 VA: 0x40DAE78
	public static void ValidateShape(ParticleSystem self) { }

	[Extension]
	// RVA: 0x40DB0C4 Offset: 0x40D70C4 VA: 0x40DB0C4
	public static bool CanBakeMesh(ParticleSystemRenderer self) { }

	[Extension]
	// RVA: 0x40DB174 Offset: 0x40D7174 VA: 0x40DB174
	public static ParticleSystemSimulationSpace GetActualSimulationSpace(ParticleSystem self) { }

	[Extension]
	// RVA: 0x40DB21C Offset: 0x40D721C VA: 0x40DB21C
	public static bool IsLocalSpace(ParticleSystem self) { }

	[Extension]
	// RVA: 0x40DB27C Offset: 0x40D727C VA: 0x40DB27C
	public static bool IsWorldSpace(ParticleSystem self) { }

	[Extension]
	// RVA: 0x40DB2DC Offset: 0x40D72DC VA: 0x40DB2DC
	public static void SortForRendering(List<ParticleSystem> self, Transform transform, bool sortByMaterial) { }

	// RVA: 0x40DB3F0 Offset: 0x40D73F0 VA: 0x40DB3F0
	private static int GetIndex(IList<ParticleSystem> list, Object ps) { }

	[Extension]
	// RVA: 0x40DB558 Offset: 0x40D7558 VA: 0x40DB558
	public static Texture2D GetTextureForSprite(ParticleSystem self) { }

	[Extension]
	// RVA: 0x40DB688 Offset: 0x40D7688 VA: 0x40DB688
	public static void Exec(List<ParticleSystem> self, Action<ParticleSystem> action) { }

	// RVA: 0x40DB7B0 Offset: 0x40D77B0 VA: 0x40DB7B0
	private static void .cctor() { }
}

// Namespace: Coffee.UIParticleExtensions
internal static class Misc // TypeDefIndex: 27951
{
	// Methods

	// RVA: 0x40DBD70 Offset: 0x40D7D70 VA: 0x40DBD70
	public static void Destroy(Object obj) { }

	// RVA: 0x40DA920 Offset: 0x40D6920 VA: 0x40DA920
	public static void DestroyImmediate(Object obj) { }
}

// Namespace: 
public enum AnimatableProperty.ShaderPropertyType // TypeDefIndex: 27952
{
	// Fields
	public int value__; // 0x0
	public const AnimatableProperty.ShaderPropertyType Color = 0;
	public const AnimatableProperty.ShaderPropertyType Vector = 1;
	public const AnimatableProperty.ShaderPropertyType Float = 2;
	public const AnimatableProperty.ShaderPropertyType Range = 3;
	public const AnimatableProperty.ShaderPropertyType Texture = 4;
}

// Namespace: Coffee.UIExtensions
[Serializable]
public class AnimatableProperty : ISerializationCallbackReceiver // TypeDefIndex: 27953
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private AnimatableProperty.ShaderPropertyType m_Type; // 0x18
	[CompilerGenerated]
	private int <id>k__BackingField; // 0x1C

	// Properties
	public int id { get; set; }
	public AnimatableProperty.ShaderPropertyType type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40DBDF4 Offset: 0x40D7DF4 VA: 0x40DBDF4
	public int get_id() { }

	[CompilerGenerated]
	// RVA: 0x40DBDFC Offset: 0x40D7DFC VA: 0x40DBDFC
	private void set_id(int value) { }

	// RVA: 0x40DBE04 Offset: 0x40D7E04 VA: 0x40DBE04
	public AnimatableProperty.ShaderPropertyType get_type() { }

	// RVA: 0x40DBE0C Offset: 0x40D7E0C VA: 0x40DBE0C Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x40DBE10 Offset: 0x40D7E10 VA: 0x40DBE10 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x40DBE30 Offset: 0x40D7E30 VA: 0x40DBE30
	public void UpdateMaterialProperties(Material material, MaterialPropertyBlock mpb) { }

	// RVA: 0x40DC090 Offset: 0x40D8090 VA: 0x40DC090
	public void .ctor() { }
}

// Namespace: 
public enum UIParticle.AutoScalingMode // TypeDefIndex: 27954
{
	// Fields
	public int value__; // 0x0
	public const UIParticle.AutoScalingMode None = 0;
	public const UIParticle.AutoScalingMode UIParticle = 1;
	public const UIParticle.AutoScalingMode Transform = 2;
}

// Namespace: 
public enum UIParticle.MeshSharing // TypeDefIndex: 27955
{
	// Fields
	public int value__; // 0x0
	public const UIParticle.MeshSharing None = 0;
	public const UIParticle.MeshSharing Auto = 1;
	public const UIParticle.MeshSharing Primary = 2;
	public const UIParticle.MeshSharing PrimarySimulator = 3;
	public const UIParticle.MeshSharing Replica = 4;
}

// Namespace: 
public enum UIParticle.PositionMode // TypeDefIndex: 27956
{
	// Fields
	public int value__; // 0x0
	public const UIParticle.PositionMode Relative = 0;
	public const UIParticle.PositionMode Absolute = 1;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UIParticle.<>c // TypeDefIndex: 27957
{
	// Fields
	public static readonly UIParticle.<>c <>9; // 0x0
	public static Action<UIParticleRenderer> <>9__85_0; // 0x8
	public static Action<ParticleSystem> <>9__90_0; // 0x10
	public static Action<ParticleSystem> <>9__91_0; // 0x18
	public static Action<ParticleSystem> <>9__93_0; // 0x20
	public static Action<ParticleSystem> <>9__94_0; // 0x28
	public static Action<ParticleSystem> <>9__95_0; // 0x30
	public static Action<ParticleSystem> <>9__96_0; // 0x38

	// Methods

	// RVA: 0x40E0250 Offset: 0x40DC250 VA: 0x40E0250
	private static void .cctor() { }

	// RVA: 0x40E02B8 Offset: 0x40DC2B8 VA: 0x40E02B8
	public void .ctor() { }

	// RVA: 0x40E02C0 Offset: 0x40DC2C0 VA: 0x40E02C0
	internal void <OnDisable>b__85_0(UIParticleRenderer r) { }

	// RVA: 0x40E02D8 Offset: 0x40DC2D8 VA: 0x40E02D8
	internal void <Play>b__90_0(ParticleSystem p) { }

	// RVA: 0x40E02FC Offset: 0x40DC2FC VA: 0x40E02FC
	internal void <Pause>b__91_0(ParticleSystem p) { }

	// RVA: 0x40E0314 Offset: 0x40DC314 VA: 0x40E0314
	internal void <Stop>b__93_0(ParticleSystem p) { }

	// RVA: 0x40E032C Offset: 0x40DC32C VA: 0x40E032C
	internal void <StartEmission>b__94_0(ParticleSystem p) { }

	// RVA: 0x40E0360 Offset: 0x40DC360 VA: 0x40E0360
	internal void <StopEmission>b__95_0(ParticleSystem p) { }

	// RVA: 0x40E0394 Offset: 0x40DC394 VA: 0x40E0394
	internal void <Clear>b__96_0(ParticleSystem p) { }
}

// Namespace: Coffee.UIExtensions
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasRenderer))]
public class UIParticle : MaskableGraphic, ISerializationCallbackReceiver // TypeDefIndex: 27958
{
	// Fields
	[HideInInspector]
	[SerializeField]
	[Obsolete]
	internal bool m_IsTrail; // 0xD8
	[Obsolete]
	[HideInInspector]
	[FormerlySerializedAs("m_IgnoreParent")]
	[SerializeField]
	private bool m_IgnoreCanvasScaler; // 0xD9
	[Obsolete]
	[HideInInspector]
	[SerializeField]
	internal bool m_AbsoluteMode; // 0xDA
	[SerializeField]
	[Tooltip("Scale the rendering particles. When the `3D` toggle is enabled, 3D scale (x, y, z) is supported.")]
	private Vector3 m_Scale3D; // 0xDC
	[Tooltip("If you want to update material properties (e.g. _MainTex_ST, _Color) in AnimationClip, use this to mark as animatable.")]
	[SerializeField]
	internal AnimatableProperty[] m_AnimatableProperties; // 0xE8
	[Tooltip("Particles")]
	[SerializeField]
	private List<ParticleSystem> m_Particles; // 0xF0
	[Tooltip("Particle simulation results are shared within the same group. A large number of the same effects can be displayed with a small load.
None: Disable mesh sharing.
Auto: Automatically select Primary/Replica.
Primary: Provides particle simulation results to the same group.
Primary Simulator: Primary, but do not render the particle (simulation only).
Replica: Render simulation results provided by the primary.")]
	[SerializeField]
	private UIParticle.MeshSharing m_MeshSharing; // 0xF8
	[Tooltip("Mesh sharing group ID.
If non-zero is specified, particle simulation results are shared within the group.")]
	[SerializeField]
	private int m_GroupId; // 0xFC
	[SerializeField]
	private int m_GroupMaxId; // 0x100
	[SerializeField]
	[Tooltip("Emission position mode.
Relative: The particles will be emitted from the scaled position.
Absolute: The particles will be emitted from the world position.")]
	private UIParticle.PositionMode m_PositionMode; // 0x104
	[Obsolete]
	[SerializeField]
	internal bool m_AutoScaling; // 0x108
	[SerializeField]
	[Tooltip("How to automatically adjust when the Canvas scale is changed by the screen size or reference resolution.
None: Do nothing.
Transform: Transform.lossyScale (=world scale) will be set to (1, 1, 1).
UIParticle: UIParticle.scale will be adjusted.")]
	private UIParticle.AutoScalingMode m_AutoScalingMode; // 0x10C
	[SerializeField]
	[Tooltip("Use a custom view.
Use this if the particles are not displayed correctly due to min/max particle size.")]
	private bool m_UseCustomView; // 0x110
	[SerializeField]
	[Tooltip("Custom view size.
Change the bake view size.")]
	private float m_CustomViewSize; // 0x114
	private readonly List<UIParticleRenderer> _renderers; // 0x118
	private Camera _bakeCamera; // 0x120
	private Canvas _canvas; // 0x128
	private int _groupId; // 0x130
	private bool _isScaleStored; // 0x134
	private Vector3 _storedScale; // 0x138
	private DrivenRectTransformTracker _tracker; // 0x144
	[CompilerGenerated]
	private bool <isPaused>k__BackingField; // 0x145
	[CompilerGenerated]
	private Vector3 <parentScale>k__BackingField; // 0x148
	[CompilerGenerated]
	private Vector3 <canvasScale>k__BackingField; // 0x154

	// Properties
	public override bool raycastTarget { get; set; }
	public UIParticle.MeshSharing meshSharing { get; set; }
	public int groupId { get; set; }
	public int groupMaxId { get; set; }
	public UIParticle.PositionMode positionMode { get; set; }
	[Obsolete("The absoluteMode is now obsolete. Please use the autoScalingMode instead.", False)]
	public bool absoluteMode { get; set; }
	[Obsolete("The autoScaling is now obsolete. Please use the autoScalingMode instead.", False)]
	public bool autoScaling { get; set; }
	public UIParticle.AutoScalingMode autoScalingMode { get; set; }
	public bool useCustomView { get; set; }
	public float customViewSize { get; set; }
	internal bool useMeshSharing { get; }
	internal bool isPrimary { get; }
	internal bool canSimulate { get; }
	internal bool canRender { get; }
	public float scale { get; set; }
	public Vector3 scale3D { get; set; }
	public Vector3 scale3DForCalc { get; }
	public List<ParticleSystem> particles { get; }
	public bool isPaused { get; set; }
	public Vector3 parentScale { get; set; }
	public Vector3 canvasScale { get; set; }

	// Methods

	// RVA: 0x40DC0F0 Offset: 0x40D80F0 VA: 0x40DC0F0 Slot: 24
	public override bool get_raycastTarget() { }

	// RVA: 0x40DC0F8 Offset: 0x40D80F8 VA: 0x40DC0F8 Slot: 25
	public override void set_raycastTarget(bool value) { }

	// RVA: 0x40DC0FC Offset: 0x40D80FC VA: 0x40DC0FC
	public UIParticle.MeshSharing get_meshSharing() { }

	// RVA: 0x40DC104 Offset: 0x40D8104 VA: 0x40DC104
	public void set_meshSharing(UIParticle.MeshSharing value) { }

	// RVA: 0x40DC10C Offset: 0x40D810C VA: 0x40DC10C
	public int get_groupId() { }

	// RVA: 0x40DC114 Offset: 0x40D8114 VA: 0x40DC114
	public void set_groupId(int value) { }

	// RVA: 0x40DC188 Offset: 0x40D8188 VA: 0x40DC188
	public int get_groupMaxId() { }

	// RVA: 0x40DC190 Offset: 0x40D8190 VA: 0x40DC190
	public void set_groupMaxId(int value) { }

	// RVA: 0x40DC1D0 Offset: 0x40D81D0 VA: 0x40DC1D0
	public UIParticle.PositionMode get_positionMode() { }

	// RVA: 0x40DC1D8 Offset: 0x40D81D8 VA: 0x40DC1D8
	public void set_positionMode(UIParticle.PositionMode value) { }

	// RVA: 0x40DC1E0 Offset: 0x40D81E0 VA: 0x40DC1E0
	public bool get_absoluteMode() { }

	// RVA: 0x40DC1F0 Offset: 0x40D81F0 VA: 0x40DC1F0
	public void set_absoluteMode(bool value) { }

	// RVA: 0x40DC20C Offset: 0x40D820C VA: 0x40DC20C
	public bool get_autoScaling() { }

	// RVA: 0x40DC21C Offset: 0x40D821C VA: 0x40DC21C
	public void set_autoScaling(bool value) { }

	// RVA: 0x40DC294 Offset: 0x40D8294 VA: 0x40DC294
	public UIParticle.AutoScalingMode get_autoScalingMode() { }

	// RVA: 0x40DC238 Offset: 0x40D8238 VA: 0x40DC238
	public void set_autoScalingMode(UIParticle.AutoScalingMode value) { }

	// RVA: 0x40DC29C Offset: 0x40D829C VA: 0x40DC29C
	public bool get_useCustomView() { }

	// RVA: 0x40DC2A4 Offset: 0x40D82A4 VA: 0x40DC2A4
	public void set_useCustomView(bool value) { }

	// RVA: 0x40DC2B0 Offset: 0x40D82B0 VA: 0x40DC2B0
	public float get_customViewSize() { }

	// RVA: 0x40DC2B8 Offset: 0x40D82B8 VA: 0x40DC2B8
	public void set_customViewSize(float value) { }

	// RVA: 0x40DC2CC Offset: 0x40D82CC VA: 0x40DC2CC
	internal bool get_useMeshSharing() { }

	// RVA: 0x40DC2DC Offset: 0x40D82DC VA: 0x40DC2DC
	internal bool get_isPrimary() { }

	// RVA: 0x40DC2F0 Offset: 0x40D82F0 VA: 0x40DC2F0
	internal bool get_canSimulate() { }

	// RVA: 0x40DC300 Offset: 0x40D8300 VA: 0x40DC300
	internal bool get_canRender() { }

	// RVA: 0x40DC324 Offset: 0x40D8324 VA: 0x40DC324
	public float get_scale() { }

	// RVA: 0x40DC32C Offset: 0x40D832C VA: 0x40DC32C
	public void set_scale(float value) { }

	// RVA: 0x40DC338 Offset: 0x40D8338 VA: 0x40DC338
	public Vector3 get_scale3D() { }

	// RVA: 0x40DC344 Offset: 0x40D8344 VA: 0x40DC344
	public void set_scale3D(Vector3 value) { }

	// RVA: 0x40DC350 Offset: 0x40D8350 VA: 0x40DC350
	public Vector3 get_scale3DForCalc() { }

	// RVA: 0x40DC3D0 Offset: 0x40D83D0 VA: 0x40DC3D0
	public List<ParticleSystem> get_particles() { }

	[CompilerGenerated]
	// RVA: 0x40DC3D8 Offset: 0x40D83D8 VA: 0x40DC3D8
	public bool get_isPaused() { }

	[CompilerGenerated]
	// RVA: 0x40DC3E0 Offset: 0x40D83E0 VA: 0x40DC3E0
	private void set_isPaused(bool value) { }

	[CompilerGenerated]
	// RVA: 0x40DC3EC Offset: 0x40D83EC VA: 0x40DC3EC
	public Vector3 get_parentScale() { }

	[CompilerGenerated]
	// RVA: 0x40DC3FC Offset: 0x40D83FC VA: 0x40DC3FC
	private void set_parentScale(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x40DC40C Offset: 0x40D840C VA: 0x40DC40C
	public Vector3 get_canvasScale() { }

	[CompilerGenerated]
	// RVA: 0x40DC41C Offset: 0x40D841C VA: 0x40DC41C
	private void set_canvasScale(Vector3 value) { }

	// RVA: 0x40DC42C Offset: 0x40D842C VA: 0x40DC42C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x40DC960 Offset: 0x40D8960 VA: 0x40DC960 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x40DCBF8 Offset: 0x40D8BF8 VA: 0x40DCBF8 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x40DCBFC Offset: 0x40D8BFC VA: 0x40DCBFC Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x40DCC00 Offset: 0x40D8C00 VA: 0x40DCC00 Slot: 65
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x40DCC04 Offset: 0x40D8C04 VA: 0x40DCC04 Slot: 66
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x40DCC3C Offset: 0x40D8C3C VA: 0x40DCC3C
	public void Play() { }

	// RVA: 0x40DCD54 Offset: 0x40D8D54 VA: 0x40DCD54
	public void Pause() { }

	// RVA: 0x40DCE70 Offset: 0x40D8E70 VA: 0x40DCE70
	public void Resume() { }

	// RVA: 0x40DCE78 Offset: 0x40D8E78 VA: 0x40DCE78
	public void Stop() { }

	// RVA: 0x40DCF94 Offset: 0x40D8F94 VA: 0x40DCF94
	public void StartEmission() { }

	// RVA: 0x40DD09C Offset: 0x40D909C VA: 0x40DD09C
	public void StopEmission() { }

	// RVA: 0x40DD1A4 Offset: 0x40D91A4 VA: 0x40DD1A4
	public void Clear() { }

	// RVA: 0x40DD2C0 Offset: 0x40D92C0 VA: 0x40DD2C0
	public void GetMaterials(List<Material> result) { }

	// RVA: 0x40DD45C Offset: 0x40D945C VA: 0x40DD45C
	public void SetParticleSystemInstance(GameObject instance) { }

	// RVA: 0x40DD464 Offset: 0x40D9464 VA: 0x40DD464
	public void SetParticleSystemInstance(GameObject instance, bool destroyOldParticles) { }

	// RVA: 0x40DD8A8 Offset: 0x40D98A8 VA: 0x40DD8A8
	public void SetParticleSystemPrefab(GameObject prefab) { }

	// RVA: 0x40DC940 Offset: 0x40D8940 VA: 0x40DC940
	public void RefreshParticles() { }

	// RVA: 0x40DD67C Offset: 0x40D967C VA: 0x40DD67C
	private void RefreshParticles(GameObject root) { }

	// RVA: 0x40DC658 Offset: 0x40D8658 VA: 0x40DC658
	public void RefreshParticles(List<ParticleSystem> particleSystems) { }

	// RVA: 0x40DE068 Offset: 0x40DA068 VA: 0x40DE068
	internal void UpdateTransformScale() { }

	// RVA: 0x40DE298 Offset: 0x40DA298 VA: 0x40DE298
	internal void UpdateRenderers() { }

	// RVA: 0x40DC158 Offset: 0x40D8158 VA: 0x40DC158
	internal void ResetGroupId() { }

	// RVA: 0x40DFD7C Offset: 0x40DBD7C VA: 0x40DFD7C Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x40DFD80 Offset: 0x40DBD80 VA: 0x40DFD80 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x40DFD84 Offset: 0x40DBD84 VA: 0x40DFD84
	private void UpdateRendererMaterial() { }

	// RVA: 0x40DDB18 Offset: 0x40D9B18 VA: 0x40DDB18
	internal UIParticleRenderer GetRenderer(int index) { }

	// RVA: 0x40DE3FC Offset: 0x40DA3FC VA: 0x40DE3FC
	private Camera GetBakeCamera() { }

	// RVA: 0x40E0128 Offset: 0x40DC128 VA: 0x40E0128
	public void .ctor() { }
}

// Namespace: 
public enum UIParticleAttractor.Movement // TypeDefIndex: 27959
{
	// Fields
	public int value__; // 0x0
	public const UIParticleAttractor.Movement Linear = 0;
	public const UIParticleAttractor.Movement Smooth = 1;
	public const UIParticleAttractor.Movement Sphere = 2;
}

// Namespace: 
public enum UIParticleAttractor.UpdateMode // TypeDefIndex: 27960
{
	// Fields
	public int value__; // 0x0
	public const UIParticleAttractor.UpdateMode Normal = 0;
	public const UIParticleAttractor.UpdateMode UnscaledTime = 1;
}

// Namespace: Coffee.UIExtensions
[ExecuteAlways]
public class UIParticleAttractor : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 27961
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private ParticleSystem m_ParticleSystem; // 0x20
	[SerializeField]
	private List<ParticleSystem> m_ParticleSystems; // 0x28
	[SerializeField]
	[Range(0.1, 10)]
	private float m_DestinationRadius; // 0x30
	[SerializeField]
	[Range(0, 0.95)]
	private float m_DelayRate; // 0x34
	[SerializeField]
	[Range(0.001, 100)]
	private float m_MaxSpeed; // 0x38
	[SerializeField]
	private UIParticleAttractor.Movement m_Movement; // 0x3C
	[SerializeField]
	private UIParticleAttractor.UpdateMode m_UpdateMode; // 0x40
	[SerializeField]
	private UnityEvent m_OnAttracted; // 0x48
	private List<UIParticle> _uiParticles; // 0x50

	// Properties
	public float destinationRadius { get; set; }
	public float delay { get; set; }
	public float maxSpeed { get; set; }
	public UIParticleAttractor.Movement movement { get; set; }
	public UIParticleAttractor.UpdateMode updateMode { get; set; }
	public UnityEvent onAttracted { get; set; }
	public IReadOnlyList<ParticleSystem> particleSystems { get; }

	// Methods

	// RVA: 0x40E03AC Offset: 0x40DC3AC VA: 0x40E03AC
	public float get_destinationRadius() { }

	// RVA: 0x40E03B4 Offset: 0x40DC3B4 VA: 0x40E03B4
	public void set_destinationRadius(float value) { }

	// RVA: 0x40E03D4 Offset: 0x40DC3D4 VA: 0x40E03D4
	public float get_delay() { }

	// RVA: 0x40E03DC Offset: 0x40DC3DC VA: 0x40E03DC
	public void set_delay(float value) { }

	// RVA: 0x40E03E4 Offset: 0x40DC3E4 VA: 0x40E03E4
	public float get_maxSpeed() { }

	// RVA: 0x40E03EC Offset: 0x40DC3EC VA: 0x40E03EC
	public void set_maxSpeed(float value) { }

	// RVA: 0x40E03F4 Offset: 0x40DC3F4 VA: 0x40E03F4
	public UIParticleAttractor.Movement get_movement() { }

	// RVA: 0x40E03FC Offset: 0x40DC3FC VA: 0x40E03FC
	public void set_movement(UIParticleAttractor.Movement value) { }

	// RVA: 0x40E0404 Offset: 0x40DC404 VA: 0x40E0404
	public UIParticleAttractor.UpdateMode get_updateMode() { }

	// RVA: 0x40E040C Offset: 0x40DC40C VA: 0x40E040C
	public void set_updateMode(UIParticleAttractor.UpdateMode value) { }

	// RVA: 0x40E0414 Offset: 0x40DC414 VA: 0x40E0414
	public UnityEvent get_onAttracted() { }

	// RVA: 0x40E041C Offset: 0x40DC41C VA: 0x40E041C
	public void set_onAttracted(UnityEvent value) { }

	// RVA: 0x40E0424 Offset: 0x40DC424 VA: 0x40E0424
	public IReadOnlyList<ParticleSystem> get_particleSystems() { }

	// RVA: 0x40E042C Offset: 0x40DC42C VA: 0x40E042C
	public void AddParticleSystem(ParticleSystem ps) { }

	// RVA: 0x40E05A8 Offset: 0x40DC5A8 VA: 0x40E05A8
	public void RemoveParticleSystem(ParticleSystem ps) { }

	// RVA: 0x40E0670 Offset: 0x40DC670 VA: 0x40E0670
	private void Awake() { }

	// RVA: 0x40E07EC Offset: 0x40DC7EC VA: 0x40E07EC
	private void OnEnable() { }

	// RVA: 0x40E0954 Offset: 0x40DC954 VA: 0x40E0954
	private void OnDisable() { }

	// RVA: 0x40E0A68 Offset: 0x40DCA68 VA: 0x40E0A68
	private void OnDestroy() { }

	// RVA: 0x40E0A90 Offset: 0x40DCA90 VA: 0x40E0A90
	internal void Attract() { }

	// RVA: 0x40E1204 Offset: 0x40DD204 VA: 0x40E1204
	private Vector3 GetDestinationPosition(UIParticle uiParticle, ParticleSystem particleSystem) { }

	// RVA: 0x40E145C Offset: 0x40DD45C VA: 0x40E145C
	private Vector3 GetAttractedPosition(Vector3 current, Vector3 target, float duration, float time) { }

	// RVA: 0x40E0F44 Offset: 0x40DCF44 VA: 0x40E0F44
	private void CollectUIParticlesIfNeeded() { }

	// RVA: 0x40E1650 Offset: 0x40DD650 VA: 0x40E1650 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x40E1654 Offset: 0x40DD654 VA: 0x40E1654 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x40E0674 Offset: 0x40DC674 VA: 0x40E0674
	private void UpgradeIfNeeded() { }

	// RVA: 0x40E1658 Offset: 0x40DD658 VA: 0x40E1658
	public void .ctor() { }
}

// Namespace: Coffee.UIExtensions
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("")]
internal class UIParticleRenderer : MaskableGraphic // TypeDefIndex: 27962
{
	// Fields
	private static readonly List<Component> s_Components; // 0x0
	private static readonly CombineInstance[] s_CombineInstances; // 0x8
	private static readonly List<Material> s_Materials; // 0x10
	private static MaterialPropertyBlock s_Mpb; // 0x18
	private static readonly List<UIParticleRenderer> s_Renderers; // 0x20
	private static readonly List<Color32> s_Colors; // 0x28
	private static readonly Vector3[] s_Corners; // 0x30
	private Material _currentMaterialForRendering; // 0xD8
	private bool _delay; // 0xE0
	private int _index; // 0xE4
	private bool _isPrevStored; // 0xE8
	private bool _isTrail; // 0xE9
	private Bounds _lastBounds; // 0xEC
	private Material _modifiedMaterial; // 0x108
	private UIParticle _parent; // 0x110
	private ParticleSystem _particleSystem; // 0x118
	private float _prevCanvasScale; // 0x120
	private Vector3 _prevPsPos; // 0x124
	private Vector3 _prevScale; // 0x130
	private Vector2Int _prevScreenSize; // 0x13C
	private bool _preWarm; // 0x144
	private ParticleSystemRenderer _renderer; // 0x148

	// Properties
	public override Texture mainTexture { get; }
	public override bool raycastTarget { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x40E1740 Offset: 0x40DD740 VA: 0x40E1740 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x40E17B0 Offset: 0x40DD7B0 VA: 0x40E17B0 Slot: 24
	public override bool get_raycastTarget() { }

	// RVA: 0x40E17B8 Offset: 0x40DD7B8 VA: 0x40E17B8
	private Rect get_rootCanvasRect() { }

	// RVA: 0x40DD97C Offset: 0x40D997C VA: 0x40DD97C
	public void Reset(int index = -1) { }

	// RVA: 0x40E1C1C Offset: 0x40DDC1C VA: 0x40E1C1C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x40E1D84 Offset: 0x40DDD84 VA: 0x40E1D84 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x40DFE70 Offset: 0x40DBE70 VA: 0x40DFE70
	public static UIParticleRenderer AddRenderer(UIParticle parent, int index) { }

	// RVA: 0x40E1E14 Offset: 0x40DDE14 VA: 0x40E1E14 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x40DDCD8 Offset: 0x40D9CD8 VA: 0x40DDCD8
	public void Set(UIParticle parent, ParticleSystem ps, bool isTrail) { }

	// RVA: 0x40DE8A8 Offset: 0x40DA8A8 VA: 0x40DE8A8
	public void UpdateMesh(Camera bakeCamera) { }

	// RVA: 0x40E2E24 Offset: 0x40DEE24 VA: 0x40E2E24 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x40E2E28 Offset: 0x40DEE28 VA: 0x40E2E28 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x40E1FD0 Offset: 0x40DDFD0 VA: 0x40E1FD0
	private Vector3 GetWorldScale() { }

	// RVA: 0x40E2828 Offset: 0x40DE828 VA: 0x40E2828
	private Matrix4x4 GetWorldMatrix(Vector3 psPos, Vector3 scale) { }

	// RVA: 0x40E2110 Offset: 0x40DE110 VA: 0x40E2110
	private void ResolveResolutionChange(Vector3 psPos, Vector3 scale) { }

	// RVA: 0x40E250C Offset: 0x40DE50C VA: 0x40E250C
	private void Simulate(Vector3 scale, bool paused) { }

	// RVA: 0x40E2C2C Offset: 0x40DEC2C VA: 0x40E2C2C
	private void UpdateMaterialProperties() { }

	// RVA: 0x40E303C Offset: 0x40DF03C VA: 0x40E303C
	public void .ctor() { }

	// RVA: 0x40E3044 Offset: 0x40DF044 VA: 0x40E3044
	private static void .cctor() { }
}

// Namespace: Coffee.UIExtensions
internal static class UIParticleUpdater // TypeDefIndex: 27963
{
	// Fields
	private static readonly List<UIParticle> s_ActiveParticles; // 0x0
	private static readonly List<UIParticleAttractor> s_ActiveAttractors; // 0x8
	private static readonly HashSet<int> s_UpdatedGroupIds; // 0x10
	private static int s_FrameCount; // 0x18

	// Properties
	public static int uiParticleCount { get; }

	// Methods

	// RVA: 0x40E3258 Offset: 0x40DF258 VA: 0x40E3258
	public static int get_uiParticleCount() { }

	// RVA: 0x40DC544 Offset: 0x40D8544 VA: 0x40DC544
	public static void Register(UIParticle particle) { }

	// RVA: 0x40DCB38 Offset: 0x40D8B38 VA: 0x40DCB38
	public static void Unregister(UIParticle particle) { }

	// RVA: 0x40E0840 Offset: 0x40DC840 VA: 0x40E0840
	public static void Register(UIParticleAttractor attractor) { }

	// RVA: 0x40E09A8 Offset: 0x40DC9A8 VA: 0x40E09A8
	public static void Unregister(UIParticleAttractor attractor) { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x40E32C8 Offset: 0x40DF2C8 VA: 0x40E32C8
	private static void InitializeOnLoad() { }

	// RVA: 0x40E3364 Offset: 0x40DF364 VA: 0x40E3364
	private static void Refresh() { }

	// RVA: 0x40E2A8C Offset: 0x40DEA8C VA: 0x40E2A8C
	public static void GetGroupedRenderers(int groupId, int index, List<UIParticleRenderer> results) { }

	// RVA: 0x40E372C Offset: 0x40DF72C VA: 0x40E372C
	internal static UIParticle GetPrimary(int groupId) { }

	// RVA: 0x40E3878 Offset: 0x40DF878 VA: 0x40E3878
	private static void .cctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=544 // TypeDefIndex: 27964
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=557 // TypeDefIndex: 27965
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 27966
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=544 7068DBC73045E9057F105CD4167A7774FAA7BE9C357446E3C9F2F113253CAE27 /*Metadata offset 0xF50F40*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=557 996B16FF2A2BAB3B9E70492F684669BB63056AA9C40CFAE802B8E4129C90AE4E /*Metadata offset 0xF51168*/; // 0x220
}

