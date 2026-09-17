// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 19721
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 19722
{
	// Methods

	// RVA: 0x858F76C Offset: 0x858B76C VA: 0x858F76C
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 19723
{
	// Methods

	// RVA: 0x858F774 Offset: 0x858B774 VA: 0x858F774
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 19724
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 19725
{
	// Methods

	// RVA: 0x858F77C Offset: 0x858B77C VA: 0x858F77C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x858F874 Offset: 0x858B874 VA: 0x858F874
	public void .ctor() { }
}

// Namespace: 
public enum LightAnchor.UpDirection // TypeDefIndex: 19726
{
	// Fields
	public int value__; // 0x0
	public const LightAnchor.UpDirection World = 0;
	public const LightAnchor.UpDirection Local = 1;
}

// Namespace: 
private struct LightAnchor.Axes // TypeDefIndex: 19727
{
	// Fields
	public Vector3 up; // 0x0
	public Vector3 right; // 0xC
	public Vector3 forward; // 0x18
}

// Namespace: UnityEngine
[AddComponentMenu("Rendering/Light Anchor")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class LightAnchor : MonoBehaviour // TypeDefIndex: 19728
{
	// Fields
	private const float k_ArcRadius = 5;
	private const float k_AxisLength = 10;
	internal const float k_MaxDistance = 10000;
	[SerializeField]
	[Min(0)]
	private float m_Distance; // 0x20
	[SerializeField]
	private LightAnchor.UpDirection m_FrameSpace; // 0x24
	[SerializeField]
	private Transform m_AnchorPositionOverride; // 0x28
	[SerializeField]
	private Vector3 m_AnchorPositionOffset; // 0x30
	[SerializeField]
	private float m_Yaw; // 0x3C
	[SerializeField]
	private float m_Pitch; // 0x40
	[SerializeField]
	private float m_Roll; // 0x44

	// Properties
	public float yaw { get; set; }
	public float pitch { get; set; }
	public float roll { get; set; }
	public float distance { get; set; }
	public LightAnchor.UpDirection frameSpace { get; set; }
	public Vector3 anchorPosition { get; }
	public Transform anchorPositionOverride { get; set; }
	public Vector3 anchorPositionOffset { get; set; }

	// Methods

	// RVA: 0x858F87C Offset: 0x858B87C VA: 0x858F87C
	public float get_yaw() { }

	// RVA: 0x858F884 Offset: 0x858B884 VA: 0x858F884
	public void set_yaw(float value) { }

	// RVA: 0x858F8F0 Offset: 0x858B8F0 VA: 0x858F8F0
	public float get_pitch() { }

	// RVA: 0x858F8F8 Offset: 0x858B8F8 VA: 0x858F8F8
	public void set_pitch(float value) { }

	// RVA: 0x858F930 Offset: 0x858B930 VA: 0x858F930
	public float get_roll() { }

	// RVA: 0x858F938 Offset: 0x858B938 VA: 0x858F938
	public void set_roll(float value) { }

	// RVA: 0x858F970 Offset: 0x858B970 VA: 0x858F970
	public float get_distance() { }

	// RVA: 0x858F978 Offset: 0x858B978 VA: 0x858F978
	public void set_distance(float value) { }

	// RVA: 0x858F998 Offset: 0x858B998 VA: 0x858F998
	public LightAnchor.UpDirection get_frameSpace() { }

	// RVA: 0x858F9A0 Offset: 0x858B9A0 VA: 0x858F9A0
	public void set_frameSpace(LightAnchor.UpDirection value) { }

	// RVA: 0x858F9A8 Offset: 0x858B9A8 VA: 0x858F9A8
	public Vector3 get_anchorPosition() { }

	// RVA: 0x858FAB4 Offset: 0x858BAB4 VA: 0x858FAB4
	public Transform get_anchorPositionOverride() { }

	// RVA: 0x858FABC Offset: 0x858BABC VA: 0x858FABC
	public void set_anchorPositionOverride(Transform value) { }

	// RVA: 0x858FAC4 Offset: 0x858BAC4 VA: 0x858FAC4
	public Vector3 get_anchorPositionOffset() { }

	// RVA: 0x858FAD0 Offset: 0x858BAD0 VA: 0x858FAD0
	public void set_anchorPositionOffset(Vector3 value) { }

	// RVA: 0x858F8BC Offset: 0x858B8BC VA: 0x858F8BC
	public static float NormalizeAngleDegree(float angle) { }

	// RVA: 0x858FADC Offset: 0x858BADC VA: 0x858FADC
	public void SynchronizeOnTransform(Camera camera) { }

	// RVA: 0x85907E8 Offset: 0x858C7E8 VA: 0x85907E8
	public void UpdateTransform(Camera camera, Vector3 anchor) { }

	// RVA: 0x858FFB4 Offset: 0x858BFB4 VA: 0x858FFB4
	private LightAnchor.Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor) { }

	// RVA: 0x8590B2C Offset: 0x858CB2C VA: 0x8590B2C
	private void Update() { }

	// RVA: 0x8590C2C Offset: 0x858CC2C VA: 0x8590C2C
	private void OnDrawGizmosSelected() { }

	// RVA: 0x8590850 Offset: 0x858C850 VA: 0x8590850
	private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor) { }

	// RVA: 0x8590CFC Offset: 0x858CCFC VA: 0x8590CFC
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
public static class XRBuiltinShaderConstants // TypeDefIndex: 19729
{
	// Fields
	public static readonly int unity_StereoCameraProjection; // 0x0
	public static readonly int unity_StereoCameraInvProjection; // 0x4
	public static readonly int unity_StereoMatrixV; // 0x8
	public static readonly int unity_StereoMatrixInvV; // 0xC
	public static readonly int unity_StereoMatrixP; // 0x10
	public static readonly int unity_StereoMatrixInvP; // 0x14
	public static readonly int unity_StereoMatrixVP; // 0x18
	public static readonly int unity_StereoMatrixInvVP; // 0x1C
	public static readonly int unity_StereoWorldSpaceCameraPos; // 0x20
	private static Matrix4x4[] s_cameraProjMatrix; // 0x28
	private static Matrix4x4[] s_invCameraProjMatrix; // 0x30
	private static Matrix4x4[] s_viewMatrix; // 0x38
	private static Matrix4x4[] s_invViewMatrix; // 0x40
	private static Matrix4x4[] s_projMatrix; // 0x48
	private static Matrix4x4[] s_invProjMatrix; // 0x50
	private static Matrix4x4[] s_viewProjMatrix; // 0x58
	private static Matrix4x4[] s_invViewProjMatrix; // 0x60
	private static Vector4[] s_worldSpaceCameraPos; // 0x68

	// Methods

	// RVA: 0x8590D04 Offset: 0x858CD04 VA: 0x8590D04
	public static void UpdateBuiltinShaderConstants(Matrix4x4 viewMatrix, Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex) { }

	// RVA: 0x8591294 Offset: 0x858D294 VA: 0x8591294
	public static void SetBuiltinShaderConstants(CommandBuffer cmd) { }

	// RVA: 0x85913E4 Offset: 0x858D3E4 VA: 0x85913E4
	public static void Update(XRPass xrPass, CommandBuffer cmd, bool renderIntoTexture) { }

	// RVA: 0x8591C78 Offset: 0x858DC78 VA: 0x8591C78
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
public class XRLayout // TypeDefIndex: 19730
{
	// Fields
	private readonly List<ValueTuple<Camera, XRPass>> m_ActivePasses; // 0x10

	// Methods

	// RVA: 0x8591FC8 Offset: 0x858DFC8 VA: 0x8591FC8
	public void AddCamera(Camera camera, bool enableXR) { }

	// RVA: 0x859290C Offset: 0x858E90C VA: 0x859290C
	public void ReconfigurePass(XRPass xrPass, Camera camera) { }

	// RVA: 0x8592C30 Offset: 0x858EC30 VA: 0x8592C30
	public List<ValueTuple<Camera, XRPass>> GetActivePasses() { }

	// RVA: 0x859280C Offset: 0x858E80C VA: 0x859280C
	internal void AddPass(Camera camera, XRPass xrPass) { }

	// RVA: 0x8592C38 Offset: 0x858EC38 VA: 0x8592C38
	internal void Clear() { }

	// RVA: 0x8592D64 Offset: 0x858ED64 VA: 0x8592D64
	internal void LogDebugInfo() { }

	// RVA: 0x85932E0 Offset: 0x858F2E0 VA: 0x85932E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
internal static class XRMirrorView // TypeDefIndex: 19731
{
	// Fields
	private static readonly MaterialPropertyBlock s_MirrorViewMaterialProperty; // 0x0
	private static readonly ProfilingSampler k_MirrorViewProfilingSampler; // 0x8
	private static readonly int k_SourceTex; // 0x10
	private static readonly int k_SourceTexArraySlice; // 0x14
	private static readonly int k_ScaleBias; // 0x18
	private static readonly int k_ScaleBiasRt; // 0x1C
	private static readonly int k_SRGBRead; // 0x20
	private static readonly int k_SRGBWrite; // 0x24
	private static readonly int k_MaxNits; // 0x28
	private static readonly int k_SourceMaxNits; // 0x2C
	private static readonly int k_SourceHDREncoding; // 0x30
	private static readonly int k_ColorTransform; // 0x34

	// Methods

	// RVA: 0x8593368 Offset: 0x858F368 VA: 0x8593368
	internal static void RenderMirrorView(CommandBuffer cmd, Camera camera, Material mat, XRDisplaySubsystem display) { }

	// RVA: 0x8594028 Offset: 0x8590028 VA: 0x8594028
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
internal class XROcclusionMesh // TypeDefIndex: 19732
{
	// Fields
	private XRPass m_Pass; // 0x10
	private Mesh m_CombinedMesh; // 0x18
	private Material m_Material; // 0x20
	private int m_CombinedMeshHashCode; // 0x28
	private static readonly ProfilingSampler k_OcclusionMeshProfilingSampler; // 0x0

	// Properties
	internal bool hasValidOcclusionMesh { get; }

	// Methods

	// RVA: 0x85942D4 Offset: 0x85902D4 VA: 0x85942D4
	internal void .ctor(XRPass xrPass) { }

	// RVA: 0x8594304 Offset: 0x8590304 VA: 0x8594304
	internal void SetMaterial(Material mat) { }

	// RVA: 0x859430C Offset: 0x859030C VA: 0x859430C
	internal bool get_hasValidOcclusionMesh() { }

	// RVA: 0x85944C4 Offset: 0x85904C4 VA: 0x85944C4
	internal void RenderOcclusionMesh(CommandBuffer cmd, float occlusionMeshScale, bool yFlip = False) { }

	// RVA: 0x8594B74 Offset: 0x8590B74 VA: 0x8594B74
	internal void UpdateCombinedMesh() { }

	// RVA: 0x85943D0 Offset: 0x85903D0 VA: 0x85943D0
	private bool IsOcclusionMeshSupported() { }

	// RVA: 0x8594C48 Offset: 0x8590C48 VA: 0x8594C48
	private bool TryGetOcclusionMeshCombinedHashCode(out int hashCode) { }

	// RVA: 0x8594D3C Offset: 0x8590D3C VA: 0x8594D3C
	private void CreateOcclusionMeshCombined() { }

	// RVA: 0x8595090 Offset: 0x8591090 VA: 0x8595090
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
public struct XRPassCreateInfo // TypeDefIndex: 19733
{
	// Fields
	internal RenderTargetIdentifier renderTarget; // 0x0
	internal RenderTextureDescriptor renderTargetDesc; // 0x28
	internal ScriptableCullingParameters cullingParameters; // 0x60
	internal Material occlusionMeshMaterial; // 0x690
	internal float occlusionMeshScale; // 0x698
	internal IntPtr foveatedRenderingInfo; // 0x6A0
	internal int multipassId; // 0x6A8
	internal int cullingPassId; // 0x6AC
	internal bool copyDepth; // 0x6B0
	internal XRDisplaySubsystem.XRRenderPass xrSdkRenderPass; // 0x6B8
}

// Namespace: UnityEngine.Experimental.Rendering
public class XRPass // TypeDefIndex: 19734
{
	// Fields
	private readonly List<XRView> m_Views; // 0x10
	private readonly XROcclusionMesh m_OcclusionMesh; // 0x18
	[CompilerGenerated]
	private bool <copyDepth>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <multipassId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <cullingPassId>k__BackingField; // 0x28
	[CompilerGenerated]
	private RenderTargetIdentifier <renderTarget>k__BackingField; // 0x30
	[CompilerGenerated]
	private RenderTextureDescriptor <renderTargetDesc>k__BackingField; // 0x58
	[CompilerGenerated]
	private ScriptableCullingParameters <cullingParams>k__BackingField; // 0x90
	[CompilerGenerated]
	private IntPtr <foveatedRenderingInfo>k__BackingField; // 0x6C0
	[CompilerGenerated]
	private float <occlusionMeshScale>k__BackingField; // 0x6C8

	// Properties
	public bool enabled { get; }
	public bool supportsFoveatedRendering { get; }
	public bool copyDepth { get; set; }
	public int multipassId { get; set; }
	public int cullingPassId { get; set; }
	public RenderTargetIdentifier renderTarget { get; set; }
	public RenderTextureDescriptor renderTargetDesc { get; set; }
	public ScriptableCullingParameters cullingParams { get; set; }
	public int viewCount { get; }
	public bool singlePassEnabled { get; }
	public IntPtr foveatedRenderingInfo { get; set; }
	public bool isHDRDisplayOutputActive { get; }
	public ColorGamut hdrDisplayOutputColorGamut { get; }
	public HDROutputUtils.HDRDisplayInformation hdrDisplayOutputInformation { get; }
	public float occlusionMeshScale { get; set; }
	public bool hasValidOcclusionMesh { get; }

	// Methods

	// RVA: 0x859512C Offset: 0x859112C VA: 0x859512C
	public void .ctor() { }

	// RVA: 0x8595200 Offset: 0x8591200 VA: 0x8595200
	public static XRPass CreateDefault(XRPassCreateInfo createInfo) { }

	// RVA: 0x8595470 Offset: 0x8591470 VA: 0x8595470 Slot: 4
	public virtual void Release() { }

	// RVA: 0x8591B18 Offset: 0x858DB18 VA: 0x8591B18
	public bool get_enabled() { }

	// RVA: 0x85954DC Offset: 0x85914DC VA: 0x85954DC
	public bool get_supportsFoveatedRendering() { }

	[CompilerGenerated]
	// RVA: 0x859559C Offset: 0x859159C VA: 0x859559C
	public bool get_copyDepth() { }

	[CompilerGenerated]
	// RVA: 0x85955A4 Offset: 0x85915A4 VA: 0x85955A4
	private void set_copyDepth(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85955B0 Offset: 0x85915B0 VA: 0x85955B0
	public int get_multipassId() { }

	[CompilerGenerated]
	// RVA: 0x85955B8 Offset: 0x85915B8 VA: 0x85955B8
	private void set_multipassId(int value) { }

	[CompilerGenerated]
	// RVA: 0x85955C0 Offset: 0x85915C0 VA: 0x85955C0
	public int get_cullingPassId() { }

	[CompilerGenerated]
	// RVA: 0x85955C8 Offset: 0x85915C8 VA: 0x85955C8
	private void set_cullingPassId(int value) { }

	[CompilerGenerated]
	// RVA: 0x85955D0 Offset: 0x85915D0 VA: 0x85955D0
	public RenderTargetIdentifier get_renderTarget() { }

	[CompilerGenerated]
	// RVA: 0x85955E4 Offset: 0x85915E4 VA: 0x85955E4
	private void set_renderTarget(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	// RVA: 0x85955F8 Offset: 0x85915F8 VA: 0x85955F8
	public RenderTextureDescriptor get_renderTargetDesc() { }

	[CompilerGenerated]
	// RVA: 0x8595618 Offset: 0x8591618 VA: 0x8595618
	private void set_renderTargetDesc(RenderTextureDescriptor value) { }

	[CompilerGenerated]
	// RVA: 0x8595638 Offset: 0x8591638 VA: 0x8595638
	public ScriptableCullingParameters get_cullingParams() { }

	[CompilerGenerated]
	// RVA: 0x8595648 Offset: 0x8591648 VA: 0x8595648
	private void set_cullingParams(ScriptableCullingParameters value) { }

	// RVA: 0x8593298 Offset: 0x858F298 VA: 0x8593298
	public int get_viewCount() { }

	// RVA: 0x8591C60 Offset: 0x858DC60 VA: 0x8591C60
	public bool get_singlePassEnabled() { }

	[CompilerGenerated]
	// RVA: 0x8595660 Offset: 0x8591660 VA: 0x8595660
	public IntPtr get_foveatedRenderingInfo() { }

	[CompilerGenerated]
	// RVA: 0x8595668 Offset: 0x8591668 VA: 0x8595668
	private void set_foveatedRenderingInfo(IntPtr value) { }

	// RVA: 0x8595670 Offset: 0x8591670 VA: 0x8595670
	public bool get_isHDRDisplayOutputActive() { }

	// RVA: 0x859571C Offset: 0x859171C VA: 0x859571C
	public ColorGamut get_hdrDisplayOutputColorGamut() { }

	// RVA: 0x85957C8 Offset: 0x85917C8 VA: 0x85957C8
	public HDROutputUtils.HDRDisplayInformation get_hdrDisplayOutputInformation() { }

	[CompilerGenerated]
	// RVA: 0x85959EC Offset: 0x85919EC VA: 0x85959EC
	public float get_occlusionMeshScale() { }

	[CompilerGenerated]
	// RVA: 0x85959F4 Offset: 0x85919F4 VA: 0x85959F4
	private void set_occlusionMeshScale(float value) { }

	// RVA: 0x8591BC8 Offset: 0x858DBC8 VA: 0x8591BC8
	public Matrix4x4 GetProjMatrix(int viewIndex = 0) { }

	// RVA: 0x8591B30 Offset: 0x858DB30 VA: 0x8591B30
	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	// RVA: 0x85931BC Offset: 0x858F1BC VA: 0x85931BC
	public Rect GetViewport(int viewIndex = 0) { }

	// RVA: 0x8594458 Offset: 0x8590458 VA: 0x8594458
	public Mesh GetOcclusionMesh(int viewIndex = 0) { }

	// RVA: 0x859322C Offset: 0x858F22C VA: 0x859322C
	public int GetTextureArraySlice(int viewIndex = 0) { }

	// RVA: 0x8594980 Offset: 0x8590980 VA: 0x8594980
	public void StartSinglePass(CommandBuffer cmd) { }

	// RVA: 0x85948B4 Offset: 0x85908B4 VA: 0x85948B4
	public void StopSinglePass(CommandBuffer cmd) { }

	// RVA: 0x85959FC Offset: 0x85919FC VA: 0x85959FC
	public bool get_hasValidOcclusionMesh() { }

	// RVA: 0x8595A14 Offset: 0x8591A14 VA: 0x8595A14
	public void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = False) { }

	// RVA: 0x8595A44 Offset: 0x8591A44 VA: 0x8595A44
	public Vector4 ApplyXRViewCenterOffset(Vector2 center) { }

	// RVA: 0x8595B88 Offset: 0x8591B88 VA: 0x8595B88
	internal void AssignView(int viewId, XRView xrView) { }

	// RVA: 0x8595C88 Offset: 0x8591C88 VA: 0x8595C88
	internal void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams) { }

	// RVA: 0x8592C18 Offset: 0x858EC18 VA: 0x8592C18
	internal void UpdateCombinedOcclusionMesh() { }

	// RVA: 0x85952D8 Offset: 0x85912D8 VA: 0x85952D8
	public void InitBase(XRPassCreateInfo createInfo) { }

	// RVA: 0x8595D18 Offset: 0x8591D18 VA: 0x8595D18
	internal void AddView(XRView xrView) { }
}

// Namespace: UnityEngine.Experimental.Rendering
public static class XRSystem // TypeDefIndex: 19735
{
	// Fields
	private static XRLayout s_Layout; // 0x0
	private static Func<XRPassCreateInfo, XRPass> s_PassAllocator; // 0x8
	private static List<XRDisplaySubsystem> s_DisplayList; // 0x10
	private static XRDisplaySubsystem s_Display; // 0x18
	private static MSAASamples s_MSAASamples; // 0x20
	private static Material s_OcclusionMeshMaterial; // 0x28
	private static Material s_MirrorViewMaterial; // 0x30
	private static Action<XRLayout, Camera> s_LayoutOverride; // 0x38
	public static readonly XRPass emptyPass; // 0x40
	[CompilerGenerated]
	private static bool <singlePassAllowed>k__BackingField; // 0x48
	[CompilerGenerated]
	private static FoveatedRenderingCaps <foveatedRenderingCaps>k__BackingField; // 0x4C
	[CompilerGenerated]
	private static bool <dumpDebugInfo>k__BackingField; // 0x50

	// Properties
	public static bool displayActive { get; }
	public static bool isHDRDisplayOutputActive { get; }
	public static bool singlePassAllowed { get; set; }
	public static FoveatedRenderingCaps foveatedRenderingCaps { get; set; }
	public static bool dumpDebugInfo { get; set; }

	// Methods

	// RVA: 0x8595F2C Offset: 0x8591F2C VA: 0x8595F2C
	public static XRDisplaySubsystem GetActiveDisplay() { }

	// RVA: 0x8592174 Offset: 0x858E174 VA: 0x8592174
	public static bool get_displayActive() { }

	// RVA: 0x8595F84 Offset: 0x8591F84 VA: 0x8595F84
	public static bool get_isHDRDisplayOutputActive() { }

	[CompilerGenerated]
	// RVA: 0x8596034 Offset: 0x8592034 VA: 0x8596034
	public static bool get_singlePassAllowed() { }

	[CompilerGenerated]
	// RVA: 0x859608C Offset: 0x859208C VA: 0x859608C
	public static void set_singlePassAllowed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85960EC Offset: 0x85920EC VA: 0x85960EC
	public static FoveatedRenderingCaps get_foveatedRenderingCaps() { }

	[CompilerGenerated]
	// RVA: 0x8596144 Offset: 0x8592144 VA: 0x8596144
	public static void set_foveatedRenderingCaps(FoveatedRenderingCaps value) { }

	[CompilerGenerated]
	// RVA: 0x85961A0 Offset: 0x85921A0 VA: 0x85961A0
	public static bool get_dumpDebugInfo() { }

	[CompilerGenerated]
	// RVA: 0x85961F8 Offset: 0x85921F8 VA: 0x85961F8
	public static void set_dumpDebugInfo(bool value) { }

	// RVA: 0x8596258 Offset: 0x8592258 VA: 0x8596258
	public static void Initialize(Func<XRPassCreateInfo, XRPass> passAllocator, Shader occlusionMeshPS, Shader mirrorViewPS) { }

	// RVA: 0x85968E4 Offset: 0x85928E4 VA: 0x85968E4
	public static void SetDisplayMSAASamples(MSAASamples msaaSamples) { }

	// RVA: 0x8596AF4 Offset: 0x8592AF4 VA: 0x8596AF4
	public static MSAASamples GetDisplayMSAASamples() { }

	// RVA: 0x8596B4C Offset: 0x8592B4C VA: 0x8596B4C
	public static void SetRenderScale(float renderScale) { }

	// RVA: 0x8596D24 Offset: 0x8592D24 VA: 0x8596D24
	public static XRLayout NewLayout() { }

	// RVA: 0x8596E1C Offset: 0x8592E1C VA: 0x8596E1C
	public static void EndLayout() { }

	// RVA: 0x8596EEC Offset: 0x8592EEC VA: 0x8596EEC
	public static void RenderMirrorView(CommandBuffer cmd, Camera camera) { }

	// RVA: 0x8596F8C Offset: 0x8592F8C VA: 0x8596F8C
	public static void Dispose() { }

	// RVA: 0x8592208 Offset: 0x858E208 VA: 0x8592208
	internal static void SetDisplayZRange(float zNear, float zFar) { }

	// RVA: 0x859712C Offset: 0x859312C VA: 0x859712C
	private static void SetLayoutOverride(Action<XRLayout, Camera> action) { }

	[RuntimeInitializeOnLoadMethod(3)]
	// RVA: 0x859718C Offset: 0x859318C VA: 0x859718C
	private static void XRSystemInit() { }

	// RVA: 0x85965FC Offset: 0x85925FC VA: 0x85965FC
	private static void RefreshDeviceInfo() { }

	// RVA: 0x85922CC Offset: 0x858E2CC VA: 0x85922CC
	internal static void CreateDefaultLayout(Camera camera) { }

	// RVA: 0x8592998 Offset: 0x858E998 VA: 0x8592998
	internal static void ReconfigurePass(XRPass xrPass, Camera camera) { }

	// RVA: 0x859722C Offset: 0x859322C VA: 0x859722C
	private static bool CanUseSinglePass(Camera camera, XRDisplaySubsystem.XRRenderPass renderPass) { }

	// RVA: 0x8597604 Offset: 0x8593604 VA: 0x8597604
	private static XRView BuildView(XRDisplaySubsystem.XRRenderPass renderPass, XRDisplaySubsystem.XRRenderParameter renderParameter) { }

	// RVA: 0x85973B0 Offset: 0x85933B0 VA: 0x85973B0
	private static XRPassCreateInfo BuildPass(XRDisplaySubsystem.XRRenderPass xrRenderPass, ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x85977A4 Offset: 0x85937A4 VA: 0x85977A4
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
[IsReadOnly]
internal struct XRView // TypeDefIndex: 19736
{
	// Fields
	internal readonly Matrix4x4 projMatrix; // 0x0
	internal readonly Matrix4x4 viewMatrix; // 0x40
	internal readonly Rect viewport; // 0x80
	internal readonly Mesh occlusionMesh; // 0x90
	internal readonly int textureArraySlice; // 0x98
	internal readonly Vector2 eyeCenterUV; // 0x9C

	// Methods

	// RVA: 0x8597724 Offset: 0x8593724 VA: 0x8597724
	internal void .ctor(Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Rect viewport, Mesh occlusionMesh, int textureArraySlice) { }

	// RVA: 0x85978F8 Offset: 0x85938F8 VA: 0x85978F8
	private static Vector2 ComputeEyeCenterUV(Matrix4x4 proj) { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[Flags]
public enum DepthAccess // TypeDefIndex: 19737
{
	// Fields
	public int value__; // 0x0
	public const DepthAccess Read = 1;
	public const DepthAccess Write = 2;
	public const DepthAccess ReadWrite = 3;
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public class RenderGraphContext // TypeDefIndex: 19738
{
	// Fields
	public ScriptableRenderContext renderContext; // 0x10
	public CommandBuffer cmd; // 0x18
	public RenderGraphObjectPool renderGraphPool; // 0x20
	public RenderGraphDefaultResources defaultResources; // 0x28

	// Methods

	// RVA: 0x8597998 Offset: 0x8593998 VA: 0x8597998
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public struct RenderGraphParameters // TypeDefIndex: 19739
{
	// Fields
	public string executionName; // 0x0
	public int currentFrameIndex; // 0x8
	public bool rendererListCulling; // 0xC
	public ScriptableRenderContext scriptableRenderContext; // 0x10
	public CommandBuffer commandBuffer; // 0x18
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public struct RenderGraphExecution : IDisposable // TypeDefIndex: 19740
{
	// Fields
	private RenderGraph renderGraph; // 0x0

	// Methods

	// RVA: 0x85979A0 Offset: 0x85939A0 VA: 0x85979A0
	internal void .ctor(RenderGraph renderGraph) { }

	// RVA: 0x85979A8 Offset: 0x85939A8 VA: 0x85979A8 Slot: 4
	public void Dispose() { }
}

// Namespace: 
private static class RenderGraphDebugParams.Strings // TypeDefIndex: 19741
{
	// Fields
	public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation; // 0x0
	public static readonly DebugUI.Widget.NameAndTooltip DisablePassCulling; // 0x10
	public static readonly DebugUI.Widget.NameAndTooltip ImmediateMode; // 0x20
	public static readonly DebugUI.Widget.NameAndTooltip EnableLogging; // 0x30
	public static readonly DebugUI.Widget.NameAndTooltip LogFrameInformation; // 0x40
	public static readonly DebugUI.Widget.NameAndTooltip LogResources; // 0x50

	// Methods

	// RVA: 0x8598510 Offset: 0x8594510 VA: 0x8598510
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal class RenderGraphDebugParams // TypeDefIndex: 19742
{
	// Fields
	private DebugUI.Widget[] m_DebugItems; // 0x10
	private DebugUI.Panel m_DebugPanel; // 0x18
	public bool clearRenderTargetsAtCreation; // 0x20
	public bool clearRenderTargetsAtRelease; // 0x21
	public bool disablePassCulling; // 0x22
	public bool immediateMode; // 0x23
	public bool enableLogging; // 0x24
	public bool logFrameInformation; // 0x25
	public bool logResources; // 0x26

	// Methods

	// RVA: 0x8597BCC Offset: 0x8593BCC VA: 0x8597BCC
	public void RegisterDebug(string name, DebugUI.Panel debugPanel) { }

	// RVA: 0x8598338 Offset: 0x8594338 VA: 0x8598338
	public void UnRegisterDebug(string name) { }

	// RVA: 0x85983B8 Offset: 0x85943B8 VA: 0x85983B8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x85983C0 Offset: 0x85943C0 VA: 0x85983C0
	private bool <RegisterDebug>b__10_0() { }

	[CompilerGenerated]
	// RVA: 0x85983C8 Offset: 0x85943C8 VA: 0x85983C8
	private void <RegisterDebug>b__10_1(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85983D4 Offset: 0x85943D4 VA: 0x85983D4
	private bool <RegisterDebug>b__10_2() { }

	[CompilerGenerated]
	// RVA: 0x85983DC Offset: 0x85943DC VA: 0x85983DC
	private void <RegisterDebug>b__10_3(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85983E8 Offset: 0x85943E8 VA: 0x85983E8
	private bool <RegisterDebug>b__10_4() { }

	[CompilerGenerated]
	// RVA: 0x85983F0 Offset: 0x85943F0 VA: 0x85983F0
	private void <RegisterDebug>b__10_5(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85983FC Offset: 0x85943FC VA: 0x85983FC
	private bool <RegisterDebug>b__10_6() { }

	[CompilerGenerated]
	// RVA: 0x8598404 Offset: 0x8594404 VA: 0x8598404
	private void <RegisterDebug>b__10_7(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8598410 Offset: 0x8594410 VA: 0x8598410
	private void <RegisterDebug>b__10_8() { }

	[CompilerGenerated]
	// RVA: 0x8598490 Offset: 0x8594490 VA: 0x8598490
	private void <RegisterDebug>b__10_9() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public sealed class RenderFunc<PassData> : MulticastDelegate // TypeDefIndex: 19743
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A6D7C Offset: 0x54A2D7C VA: 0x54A6D7C
	|-RenderFunc<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(PassData data, RenderGraphContext renderGraphContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A6E88 Offset: 0x54A2E88 VA: 0x54A6E88
	|-RenderFunc<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(PassData data, RenderGraphContext renderGraphContext, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A6E9C Offset: 0x54A2E9C VA: 0x54A6E9C
	|-RenderFunc<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A6EC4 Offset: 0x54A2EC4 VA: 0x54A6EC4
	|-RenderFunc<object>.EndInvoke
	*/
}

// Namespace: 
[DebuggerDisplay("PassDebug: {name}")]
public struct RenderGraphDebugData.PassDebugData // TypeDefIndex: 19744
{
	// Fields
	public string name; // 0x0
	public List<int>[] resourceReadLists; // 0x8
	public List<int>[] resourceWriteLists; // 0x10
	public bool culled; // 0x18
	public bool async; // 0x19
	public int syncToPassIndex; // 0x1C
	public int syncFromPassIndex; // 0x20
	public bool generateDebugData; // 0x24
}

// Namespace: 
[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
public struct RenderGraphDebugData.ResourceDebugData // TypeDefIndex: 19745
{
	// Fields
	public string name; // 0x0
	public bool imported; // 0x8
	public int creationPassIndex; // 0xC
	public int releasePassIndex; // 0x10
	public List<int> consumerList; // 0x18
	public List<int> producerList; // 0x20
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal class RenderGraphDebugData // TypeDefIndex: 19746
{
	// Fields
	public List<RenderGraphDebugData.PassDebugData> passList; // 0x10
	public List<RenderGraphDebugData.ResourceDebugData>[] resourceLists; // 0x18

	// Methods

	// RVA: 0x85987EC Offset: 0x85947EC VA: 0x85987EC
	public void Clear() { }

	// RVA: 0x8598994 Offset: 0x8594994 VA: 0x8598994
	public void .ctor() { }
}

// Namespace: 
internal struct RenderGraph.CompiledResourceInfo // TypeDefIndex: 19747
{
	// Fields
	public List<int> producers; // 0x0
	public List<int> consumers; // 0x8
	public int refCount; // 0x10
	public bool imported; // 0x14

	// Methods

	// RVA: 0x859C89C Offset: 0x859889C VA: 0x859C89C
	public void Reset() { }
}

// Namespace: 
[DebuggerDisplay("RenderPass: {pass.name} (Index:{pass.index} Async:{enableAsyncCompute})")]
internal struct RenderGraph.CompiledPassInfo // TypeDefIndex: 19748
{
	// Fields
	public RenderGraphPass pass; // 0x0
	public List<int>[] resourceCreateList; // 0x8
	public List<int>[] resourceReleaseList; // 0x10
	public int refCount; // 0x18
	public bool culled; // 0x1C
	public bool culledByRendererList; // 0x1D
	public bool hasSideEffect; // 0x1E
	public int syncToPassIndex; // 0x20
	public int syncFromPassIndex; // 0x24
	public bool needGraphicsFence; // 0x28
	public GraphicsFence fence; // 0x30
	public bool enableAsyncCompute; // 0x40

	// Properties
	public bool allowPassCulling { get; }

	// Methods

	// RVA: 0x859DC6C Offset: 0x8599C6C VA: 0x859DC6C
	public bool get_allowPassCulling() { }

	// RVA: 0x859CB18 Offset: 0x8598B18 VA: 0x859CB18
	public void Reset(RenderGraphPass pass) { }
}

// Namespace: 
private class RenderGraph.ProfilingScopePassData // TypeDefIndex: 19749
{
	// Fields
	public ProfilingSampler sampler; // 0x10

	// Methods

	// RVA: 0x85A3DE4 Offset: 0x859FDE4 VA: 0x85A3DE4
	public void .ctor() { }
}

// Namespace: 
internal sealed class RenderGraph.OnGraphRegisteredDelegate : MulticastDelegate // TypeDefIndex: 19750
{
	// Methods

	// RVA: 0x85A3DEC Offset: 0x859FDEC VA: 0x85A3DEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x85A3EF4 Offset: 0x859FEF4 VA: 0x85A3EF4 Slot: 13
	public virtual void Invoke(RenderGraph graph) { }

	// RVA: 0x85A3F08 Offset: 0x859FF08 VA: 0x85A3F08 Slot: 14
	public virtual IAsyncResult BeginInvoke(RenderGraph graph, AsyncCallback callback, object object) { }

	// RVA: 0x85A3F28 Offset: 0x859FF28 VA: 0x85A3F28 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal sealed class RenderGraph.OnExecutionRegisteredDelegate : MulticastDelegate // TypeDefIndex: 19751
{
	// Methods

	// RVA: 0x85A3F34 Offset: 0x859FF34 VA: 0x85A3F34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x85A4040 Offset: 0x85A0040 VA: 0x85A4040 Slot: 13
	public virtual void Invoke(RenderGraph graph, string executionName) { }

	// RVA: 0x85A4054 Offset: 0x85A0054 VA: 0x85A4054 Slot: 14
	public virtual IAsyncResult BeginInvoke(RenderGraph graph, string executionName, AsyncCallback callback, object object) { }

	// RVA: 0x85A407C Offset: 0x85A007C VA: 0x85A407C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RenderGraph.<>c // TypeDefIndex: 19752
{
	// Fields
	public static readonly RenderGraph.<>c <>9; // 0x0
	public static RenderFunc<RenderGraph.ProfilingScopePassData> <>9__62_0; // 0x8
	public static RenderFunc<RenderGraph.ProfilingScopePassData> <>9__63_0; // 0x10

	// Methods

	// RVA: 0x85A4088 Offset: 0x85A0088 VA: 0x85A4088
	private static void .cctor() { }

	// RVA: 0x85A40F0 Offset: 0x85A00F0 VA: 0x85A40F0
	public void .ctor() { }

	// RVA: 0x85A40F8 Offset: 0x85A00F8 VA: 0x85A40F8
	internal void <BeginProfilingSampler>b__62_0(RenderGraph.ProfilingScopePassData data, RenderGraphContext ctx) { }

	// RVA: 0x85A4120 Offset: 0x85A0120 VA: 0x85A4120
	internal void <EndProfilingSampler>b__63_0(RenderGraph.ProfilingScopePassData data, RenderGraphContext ctx) { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public class RenderGraph // TypeDefIndex: 19753
{
	// Fields
	public static readonly int kMaxMRTCount; // 0x0
	private RenderGraphResourceRegistry m_Resources; // 0x10
	private RenderGraphObjectPool m_RenderGraphPool; // 0x18
	private List<RenderGraphPass> m_RenderPasses; // 0x20
	private List<RendererListHandle> m_RendererLists; // 0x28
	private RenderGraphDebugParams m_DebugParameters; // 0x30
	private RenderGraphLogger m_FrameInformationLogger; // 0x38
	private RenderGraphDefaultResources m_DefaultResources; // 0x40
	private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers; // 0x48
	private bool m_ExecutionExceptionWasRaised; // 0x50
	private RenderGraphContext m_RenderGraphContext; // 0x58
	private CommandBuffer m_PreviousCommandBuffer; // 0x60
	private int m_CurrentImmediatePassIndex; // 0x68
	private List<int>[] m_ImmediateModeResourceList; // 0x70
	private DynamicArray<RenderGraph.CompiledResourceInfo>[] m_CompiledResourcesInfos; // 0x78
	private DynamicArray<RenderGraph.CompiledPassInfo> m_CompiledPassInfos; // 0x80
	private Stack<int> m_CullingStack; // 0x88
	private int m_ExecutionCount; // 0x90
	private int m_CurrentFrameIndex; // 0x94
	private bool m_HasRenderGraphBegun; // 0x98
	private string m_CurrentExecutionName; // 0xA0
	private bool m_RendererListCulling; // 0xA8
	private Dictionary<string, RenderGraphDebugData> m_DebugData; // 0xB0
	private static List<RenderGraph> s_RegisteredGraphs; // 0x8
	[CompilerGenerated]
	private string <name>k__BackingField; // 0xB8
	[CompilerGenerated]
	private static bool <requireDebugData>k__BackingField; // 0x10
	[CompilerGenerated]
	private static RenderGraph.OnGraphRegisteredDelegate onGraphRegistered; // 0x18
	[CompilerGenerated]
	private static RenderGraph.OnGraphRegisteredDelegate onGraphUnregistered; // 0x20
	[CompilerGenerated]
	private static RenderGraph.OnExecutionRegisteredDelegate onExecutionRegistered; // 0x28
	[CompilerGenerated]
	private static RenderGraph.OnExecutionRegisteredDelegate onExecutionUnregistered; // 0x30

	// Properties
	public string name { get; set; }
	internal static bool requireDebugData { get; set; }
	public RenderGraphDefaultResources defaultResources { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8598A4C Offset: 0x8594A4C VA: 0x8598A4C
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x8598A54 Offset: 0x8594A54 VA: 0x8598A54
	private void set_name(string value) { }

	[CompilerGenerated]
	// RVA: 0x8598A5C Offset: 0x8594A5C VA: 0x8598A5C
	internal static bool get_requireDebugData() { }

	[CompilerGenerated]
	// RVA: 0x8598AB4 Offset: 0x8594AB4 VA: 0x8598AB4
	internal static void set_requireDebugData(bool value) { }

	// RVA: 0x8598B14 Offset: 0x8594B14 VA: 0x8598B14
	public RenderGraphDefaultResources get_defaultResources() { }

	// RVA: 0x8598B1C Offset: 0x8594B1C VA: 0x8598B1C
	public void .ctor(string name = "RenderGraph") { }

	// RVA: 0x8599720 Offset: 0x8595720 VA: 0x8599720
	public void Cleanup() { }

	// RVA: 0x85999BC Offset: 0x85959BC VA: 0x85999BC
	public void RegisterDebug(DebugUI.Panel panel) { }

	// RVA: 0x85999E0 Offset: 0x85959E0 VA: 0x85999E0
	public void UnRegisterDebug() { }

	// RVA: 0x85999F8 Offset: 0x85959F8 VA: 0x85999F8
	public static List<RenderGraph> GetRegisteredRenderGraphs() { }

	// RVA: 0x8599A50 Offset: 0x8595A50 VA: 0x8599A50
	internal RenderGraphDebugData GetDebugData(string executionName) { }

	// RVA: 0x8599AC8 Offset: 0x8595AC8 VA: 0x8599AC8
	public void EndFrame() { }

	// RVA: 0x8599E0C Offset: 0x8595E0C VA: 0x8599E0C
	public TextureHandle ImportTexture(RTHandle rt) { }

	// RVA: 0x8599EEC Offset: 0x8595EEC VA: 0x8599EEC
	public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	// RVA: 0x859A0A0 Offset: 0x85960A0 VA: 0x859A0A0
	public TextureHandle CreateTexture(in TextureDesc desc) { }

	// RVA: 0x859A1AC Offset: 0x85961AC VA: 0x859A1AC
	public TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease = False) { }

	// RVA: 0x859A3EC Offset: 0x85963EC VA: 0x859A3EC
	public void RefreshSharedTextureDesc(TextureHandle handle, in TextureDesc desc) { }

	// RVA: 0x859A53C Offset: 0x859653C VA: 0x859A53C
	public void ReleaseSharedTexture(TextureHandle texture) { }

	// RVA: 0x859A6DC Offset: 0x85966DC VA: 0x859A6DC
	public TextureHandle CreateTexture(TextureHandle texture) { }

	// RVA: 0x859A840 Offset: 0x8596840 VA: 0x859A840
	public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture) { }

	// RVA: 0x859A91C Offset: 0x859691C VA: 0x859A91C
	public TextureDesc GetTextureDesc(TextureHandle texture) { }

	// RVA: 0x859A960 Offset: 0x8596960 VA: 0x859A960
	public RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	// RVA: 0x859AA44 Offset: 0x8596A44 VA: 0x859AA44
	public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) { }

	// RVA: 0x859AB28 Offset: 0x8596B28 VA: 0x859AB28
	public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc) { }

	// RVA: 0x859AC2C Offset: 0x8596C2C VA: 0x859AC2C
	public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferHandle computeBuffer) { }

	// RVA: 0x859AD84 Offset: 0x8596D84 VA: 0x859AD84
	public ComputeBufferDesc GetComputeBufferDesc(in ComputeBufferHandle computeBuffer) { }

	// RVA: -1 Offset: -1
	public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BD79C Offset: 0x46B979C VA: 0x46BD79C
	|-RenderGraph.AddRenderPass<object>
	*/

	// RVA: -1 Offset: -1
	public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BD71C Offset: 0x46B971C VA: 0x46BD71C
	|-RenderGraph.AddRenderPass<object>
	*/

	// RVA: 0x859ADC0 Offset: 0x8596DC0 VA: 0x859ADC0
	public RenderGraphExecution RecordAndExecute(in RenderGraphParameters parameters) { }

	// RVA: 0x85979C0 Offset: 0x85939C0 VA: 0x85979C0
	internal void Execute() { }

	// RVA: 0x859B8A0 Offset: 0x85978A0 VA: 0x859B8A0
	public void BeginProfilingSampler(ProfilingSampler sampler) { }

	// RVA: 0x859BAF4 Offset: 0x8597AF4 VA: 0x859BAF4
	public void EndProfilingSampler(ProfilingSampler sampler) { }

	// RVA: 0x859BD08 Offset: 0x8597D08 VA: 0x859BD08
	internal DynamicArray<RenderGraph.CompiledPassInfo> GetCompiledPassInfos() { }

	// RVA: 0x859BD10 Offset: 0x8597D10 VA: 0x859BD10
	internal void ClearCompiledGraph() { }

	// RVA: 0x859C058 Offset: 0x8598058 VA: 0x859C058
	private void InvalidateContext() { }

	// RVA: 0x859C0A4 Offset: 0x85980A4 VA: 0x859C0A4
	internal void OnPassAdded(RenderGraphPass pass) { }

	[CompilerGenerated]
	// RVA: 0x859C108 Offset: 0x8598108 VA: 0x859C108
	internal static void add_onGraphRegistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x859C1E4 Offset: 0x85981E4 VA: 0x859C1E4
	internal static void remove_onGraphRegistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x859C2C0 Offset: 0x85982C0 VA: 0x859C2C0
	internal static void add_onGraphUnregistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x859C39C Offset: 0x859839C VA: 0x859C39C
	internal static void remove_onGraphUnregistered(RenderGraph.OnGraphRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x859C478 Offset: 0x8598478 VA: 0x859C478
	internal static void add_onExecutionRegistered(RenderGraph.OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x859C554 Offset: 0x8598554 VA: 0x859C554
	internal static void remove_onExecutionRegistered(RenderGraph.OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x859C630 Offset: 0x8598630 VA: 0x859C630
	internal static void add_onExecutionUnregistered(RenderGraph.OnExecutionRegisteredDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x859C70C Offset: 0x859870C VA: 0x859C70C
	internal static void remove_onExecutionUnregistered(RenderGraph.OnExecutionRegisteredDelegate value) { }

	// RVA: 0x859C7E8 Offset: 0x85987E8 VA: 0x859C7E8
	private void InitResourceInfosData(DynamicArray<RenderGraph.CompiledResourceInfo> resourceInfos, int count) { }

	// RVA: 0x859C99C Offset: 0x859899C VA: 0x859C99C
	private void InitializeCompilationData() { }

	// RVA: 0x859CD5C Offset: 0x8598D5C VA: 0x859CD5C
	private void CountReferences() { }

	// RVA: 0x859D624 Offset: 0x8599624 VA: 0x859D624
	private void CullUnusedPasses() { }

	// RVA: 0x859E07C Offset: 0x859A07C VA: 0x859E07C
	private void UpdatePassSynchronization(ref RenderGraph.CompiledPassInfo currentPassInfo, ref RenderGraph.CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex) { }

	// RVA: 0x859E0A4 Offset: 0x859A0A4 VA: 0x859E0A4
	private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in RenderGraph.CompiledResourceInfo resource) { }

	// RVA: 0x859E374 Offset: 0x859A374 VA: 0x859E374
	private int GetFirstValidConsumerIndex(int passIndex, in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x859E514 Offset: 0x859A514 VA: 0x859E514
	private int FindTextureProducer(int consumerPass, in RenderGraph.CompiledResourceInfo info, out int index) { }

	// RVA: 0x859E1D4 Offset: 0x859A1D4 VA: 0x859E1D4
	private int GetLatestProducerIndex(int passIndex, in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x859E628 Offset: 0x859A628 VA: 0x859E628
	private int GetLatestValidReadIndex(in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x859E70C Offset: 0x859A70C VA: 0x859E70C
	private int GetFirstValidWriteIndex(in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x859E800 Offset: 0x859A800 VA: 0x859E800
	private int GetLatestValidWriteIndex(in RenderGraph.CompiledResourceInfo info) { }

	// RVA: 0x859E8E4 Offset: 0x859A8E4 VA: 0x859E8E4
	private void CreateRendererLists() { }

	// RVA: 0x859ECD4 Offset: 0x859ACD4 VA: 0x859ECD4
	internal bool GetImportedFallback(TextureDesc desc, out TextureHandle fallback) { }

	// RVA: 0x859EEF0 Offset: 0x859AEF0 VA: 0x859EEF0
	private void AllocateCulledPassResources(ref RenderGraph.CompiledPassInfo passInfo, int passIndex) { }

	// RVA: 0x859F49C Offset: 0x859B49C VA: 0x859F49C
	private void UpdateResourceAllocationAndSynchronization() { }

	// RVA: 0x859FE70 Offset: 0x859BE70 VA: 0x859FE70
	private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists) { }

	// RVA: 0x85A0164 Offset: 0x859C164 VA: 0x85A0164
	private void TryCullPassAtIndex(int passIndex) { }

	// RVA: 0x85A026C Offset: 0x859C26C VA: 0x85A026C
	private void CullRendererLists() { }

	// RVA: 0x859B624 Offset: 0x8597624 VA: 0x859B624
	internal void CompileRenderGraph() { }

	// RVA: 0x85A0474 Offset: 0x859C474 VA: 0x85A0474
	private ref RenderGraph.CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass) { }

	// RVA: 0x859C0E4 Offset: 0x85980E4 VA: 0x859C0E4
	private void ExecutePassImmediately(RenderGraphPass pass) { }

	// RVA: 0x85A0F1C Offset: 0x859CF1C VA: 0x85A0F1C
	private void ExecuteCompiledPass(ref RenderGraph.CompiledPassInfo passInfo, int passIndex) { }

	// RVA: 0x859B748 Offset: 0x8597748 VA: 0x859B748
	private void ExecuteRenderGraph() { }

	// RVA: 0x85A1BA0 Offset: 0x859DBA0 VA: 0x85A1BA0
	private void PreRenderPassSetRenderTargets(in RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	// RVA: 0x85A1610 Offset: 0x859D610 VA: 0x85A1610
	private void PreRenderPassExecute(in RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	// RVA: 0x85A193C Offset: 0x859D93C VA: 0x85A193C
	private void PostRenderPassExecute(ref RenderGraph.CompiledPassInfo passInfo, RenderGraphContext rgContext) { }

	// RVA: 0x859BDF8 Offset: 0x8597DF8 VA: 0x859BDF8
	private void ClearRenderPasses() { }

	// RVA: 0x85A25DC Offset: 0x859E5DC VA: 0x85A25DC
	private void ReleaseImmediateModeResources() { }

	// RVA: 0x859B3E0 Offset: 0x85973E0 VA: 0x859B3E0
	private void LogFrameInformation() { }

	// RVA: 0x85A0358 Offset: 0x859C358 VA: 0x85A0358
	private void LogRendererListsCreation() { }

	// RVA: 0x85A1298 Offset: 0x859D298 VA: 0x85A1298
	private void LogRenderPassBegin(in RenderGraph.CompiledPassInfo passInfo) { }

	// RVA: 0x859DC88 Offset: 0x8599C88 VA: 0x859DC88
	private void LogCulledPasses() { }

	// RVA: 0x85A2770 Offset: 0x859E770 VA: 0x85A2770
	private ProfilingSampler GetDefaultProfilingSampler(string name) { }

	// RVA: 0x85A285C Offset: 0x859E85C VA: 0x85A285C
	private void UpdateImportedResourceLifeTime(ref RenderGraphDebugData.ResourceDebugData data, List<int> passList) { }

	// RVA: 0x85A2A30 Offset: 0x859EA30 VA: 0x85A2A30
	private void GenerateDebugData() { }

	// RVA: 0x85A3A24 Offset: 0x859FA24 VA: 0x85A3A24
	private void CleanupDebugData() { }

	// RVA: 0x85A3D34 Offset: 0x859FD34 VA: 0x85A3D34
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public struct RenderGraphProfilingScope : IDisposable // TypeDefIndex: 19754
{
	// Fields
	private bool m_Disposed; // 0x0
	private ProfilingSampler m_Sampler; // 0x8
	private RenderGraph m_RenderGraph; // 0x10

	// Methods

	// RVA: 0x85A4148 Offset: 0x85A0148 VA: 0x85A4148
	public void .ctor(RenderGraph renderGraph, ProfilingSampler sampler) { }

	// RVA: 0x85A4194 Offset: 0x85A0194 VA: 0x85A4194 Slot: 4
	public void Dispose() { }

	// RVA: 0x85A419C Offset: 0x85A019C VA: 0x85A419C
	private void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public struct RenderGraphBuilder : IDisposable // TypeDefIndex: 19755
{
	// Fields
	private RenderGraphPass m_RenderPass; // 0x0
	private RenderGraphResourceRegistry m_Resources; // 0x8
	private RenderGraph m_RenderGraph; // 0x10
	private bool m_Disposed; // 0x18

	// Methods

	// RVA: 0x85A41D4 Offset: 0x85A01D4 VA: 0x85A41D4
	public TextureHandle UseColorBuffer(in TextureHandle input, int index) { }

	// RVA: 0x85A43AC Offset: 0x85A03AC VA: 0x85A43AC
	public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags) { }

	// RVA: 0x85A4554 Offset: 0x85A0554 VA: 0x85A4554
	public TextureHandle ReadTexture(in TextureHandle input) { }

	// RVA: 0x85A44D0 Offset: 0x85A04D0 VA: 0x85A44D0
	public TextureHandle WriteTexture(in TextureHandle input) { }

	// RVA: 0x85A4828 Offset: 0x85A0828 VA: 0x85A4828
	public TextureHandle ReadWriteTexture(in TextureHandle input) { }

	// RVA: 0x85A4878 Offset: 0x85A0878 VA: 0x85A4878
	public TextureHandle CreateTransientTexture(in TextureDesc desc) { }

	// RVA: 0x85A49C0 Offset: 0x85A09C0 VA: 0x85A49C0
	public TextureHandle CreateTransientTexture(in TextureHandle texture) { }

	// RVA: 0x85A4A44 Offset: 0x85A0A44 VA: 0x85A4A44
	public RendererListHandle UseRendererList(in RendererListHandle input) { }

	// RVA: 0x85A4B10 Offset: 0x85A0B10 VA: 0x85A4B10
	public ComputeBufferHandle ReadComputeBuffer(in ComputeBufferHandle input) { }

	// RVA: 0x85A4B34 Offset: 0x85A0B34 VA: 0x85A4B34
	public ComputeBufferHandle WriteComputeBuffer(in ComputeBufferHandle input) { }

	// RVA: 0x85A4B74 Offset: 0x85A0B74 VA: 0x85A4B74
	public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferDesc desc) { }

	// RVA: 0x85A4BC4 Offset: 0x85A0BC4 VA: 0x85A4BC4
	public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferHandle computebuffer) { }

	// RVA: -1 Offset: -1
	public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BD908 Offset: 0x46B9908 VA: 0x46BD908
	|-RenderGraphBuilder.SetRenderFunc<object>
	*/

	// RVA: 0x85A4C34 Offset: 0x85A0C34 VA: 0x85A4C34
	public void EnableAsyncCompute(bool value) { }

	// RVA: 0x859BAB4 Offset: 0x8597AB4 VA: 0x859BAB4
	public void AllowPassCulling(bool value) { }

	// RVA: 0x85A4C6C Offset: 0x85A0C6C VA: 0x85A4C6C Slot: 4
	public void Dispose() { }

	// RVA: 0x85A4CA8 Offset: 0x85A0CA8 VA: 0x85A4CA8
	public void AllowRendererListCulling(bool value) { }

	// RVA: 0x85A4CD4 Offset: 0x85A0CD4 VA: 0x85A4CD4
	public RendererListHandle DependsOn(in RendererListHandle input) { }

	// RVA: 0x85A4CFC Offset: 0x85A0CFC VA: 0x85A4CFC
	internal void .ctor(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph) { }

	// RVA: 0x85A4C74 Offset: 0x85A0C74 VA: 0x85A4C74
	private void Dispose(bool disposing) { }

	// RVA: 0x85A421C Offset: 0x85A021C VA: 0x85A421C
	private void CheckResource(in ResourceHandle res, bool dontCheckTransientReadWrite = False) { }

	// RVA: 0x859BAD4 Offset: 0x8597AD4 VA: 0x859BAD4
	internal void GenerateDebugData(bool value) { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public class RenderGraphDefaultResources // TypeDefIndex: 19756
{
	// Fields
	private bool m_IsValid; // 0x10
	private RTHandle m_BlackTexture2D; // 0x18
	private RTHandle m_WhiteTexture2D; // 0x20
	private RTHandle m_ShadowTexture2D; // 0x28
	[CompilerGenerated]
	private TextureHandle <blackTexture>k__BackingField; // 0x30
	[CompilerGenerated]
	private TextureHandle <whiteTexture>k__BackingField; // 0x38
	[CompilerGenerated]
	private TextureHandle <clearTextureXR>k__BackingField; // 0x40
	[CompilerGenerated]
	private TextureHandle <magentaTextureXR>k__BackingField; // 0x48
	[CompilerGenerated]
	private TextureHandle <blackTextureXR>k__BackingField; // 0x50
	[CompilerGenerated]
	private TextureHandle <blackTextureArrayXR>k__BackingField; // 0x58
	[CompilerGenerated]
	private TextureHandle <blackUIntTextureXR>k__BackingField; // 0x60
	[CompilerGenerated]
	private TextureHandle <blackTexture3DXR>k__BackingField; // 0x68
	[CompilerGenerated]
	private TextureHandle <whiteTextureXR>k__BackingField; // 0x70
	[CompilerGenerated]
	private TextureHandle <defaultShadowTexture>k__BackingField; // 0x78

	// Properties
	public TextureHandle blackTexture { get; set; }
	public TextureHandle whiteTexture { get; set; }
	public TextureHandle clearTextureXR { get; set; }
	public TextureHandle magentaTextureXR { get; set; }
	public TextureHandle blackTextureXR { get; set; }
	public TextureHandle blackTextureArrayXR { get; set; }
	public TextureHandle blackUIntTextureXR { get; set; }
	public TextureHandle blackTexture3DXR { get; set; }
	public TextureHandle whiteTextureXR { get; set; }
	public TextureHandle defaultShadowTexture { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85A4D54 Offset: 0x85A0D54 VA: 0x85A4D54
	public TextureHandle get_blackTexture() { }

	[CompilerGenerated]
	// RVA: 0x85A4D5C Offset: 0x85A0D5C VA: 0x85A4D5C
	private void set_blackTexture(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A4D64 Offset: 0x85A0D64 VA: 0x85A4D64
	public TextureHandle get_whiteTexture() { }

	[CompilerGenerated]
	// RVA: 0x85A4D6C Offset: 0x85A0D6C VA: 0x85A4D6C
	private void set_whiteTexture(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A4D74 Offset: 0x85A0D74 VA: 0x85A4D74
	public TextureHandle get_clearTextureXR() { }

	[CompilerGenerated]
	// RVA: 0x85A4D7C Offset: 0x85A0D7C VA: 0x85A4D7C
	private void set_clearTextureXR(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A4D84 Offset: 0x85A0D84 VA: 0x85A4D84
	public TextureHandle get_magentaTextureXR() { }

	[CompilerGenerated]
	// RVA: 0x85A4D8C Offset: 0x85A0D8C VA: 0x85A4D8C
	private void set_magentaTextureXR(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A4D94 Offset: 0x85A0D94 VA: 0x85A4D94
	public TextureHandle get_blackTextureXR() { }

	[CompilerGenerated]
	// RVA: 0x85A4D9C Offset: 0x85A0D9C VA: 0x85A4D9C
	private void set_blackTextureXR(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A4DA4 Offset: 0x85A0DA4 VA: 0x85A4DA4
	public TextureHandle get_blackTextureArrayXR() { }

	[CompilerGenerated]
	// RVA: 0x85A4DAC Offset: 0x85A0DAC VA: 0x85A4DAC
	private void set_blackTextureArrayXR(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A4DB4 Offset: 0x85A0DB4 VA: 0x85A4DB4
	public TextureHandle get_blackUIntTextureXR() { }

	[CompilerGenerated]
	// RVA: 0x85A4DBC Offset: 0x85A0DBC VA: 0x85A4DBC
	private void set_blackUIntTextureXR(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A4DC4 Offset: 0x85A0DC4 VA: 0x85A4DC4
	public TextureHandle get_blackTexture3DXR() { }

	[CompilerGenerated]
	// RVA: 0x85A4DCC Offset: 0x85A0DCC VA: 0x85A4DCC
	private void set_blackTexture3DXR(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A4DD4 Offset: 0x85A0DD4 VA: 0x85A4DD4
	public TextureHandle get_whiteTextureXR() { }

	[CompilerGenerated]
	// RVA: 0x85A4DDC Offset: 0x85A0DDC VA: 0x85A4DDC
	private void set_whiteTextureXR(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A4DE4 Offset: 0x85A0DE4 VA: 0x85A4DE4
	public TextureHandle get_defaultShadowTexture() { }

	[CompilerGenerated]
	// RVA: 0x85A4DEC Offset: 0x85A0DEC VA: 0x85A4DEC
	private void set_defaultShadowTexture(TextureHandle value) { }

	// RVA: 0x8599278 Offset: 0x8595278 VA: 0x8599278
	internal void .ctor() { }

	// RVA: 0x8599894 Offset: 0x8595894 VA: 0x8599894
	internal void Cleanup() { }

	// RVA: 0x859B200 Offset: 0x8597200 VA: 0x859B200
	internal void InitializeForRendering(RenderGraph renderGraph) { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal struct RenderGraphLogIndent : IDisposable // TypeDefIndex: 19757
{
	// Fields
	private int m_Indentation; // 0x0
	private RenderGraphLogger m_Logger; // 0x8
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x85A15D0 Offset: 0x859D5D0 VA: 0x85A15D0
	public void .ctor(RenderGraphLogger logger, int indentation = 1) { }

	// RVA: 0x85A4E64 Offset: 0x85A0E64 VA: 0x85A4E64 Slot: 4
	public void Dispose() { }

	// RVA: 0x85A4E94 Offset: 0x85A0E94 VA: 0x85A4E94
	private void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal class RenderGraphLogger // TypeDefIndex: 19758
{
	// Fields
	private Dictionary<string, StringBuilder> m_LogMap; // 0x10
	private StringBuilder m_CurrentBuilder; // 0x18
	private int m_CurrentIndentation; // 0x20

	// Methods

	// RVA: 0x859B110 Offset: 0x8597110 VA: 0x859B110
	public void Initialize(string logName) { }

	// RVA: 0x85A4DF4 Offset: 0x85A0DF4 VA: 0x85A4DF4
	public void IncrementIndentation(int value) { }

	// RVA: 0x85A4EC8 Offset: 0x85A0EC8 VA: 0x85A4EC8
	public void DecrementIndentation(int value) { }

	// RVA: 0x859DBF4 Offset: 0x8599BF4 VA: 0x859DBF4
	public void LogLine(string format, object[] args) { }

	// RVA: 0x85A4F44 Offset: 0x85A0F44 VA: 0x85A4F44
	public string GetLog(string logName) { }

	// RVA: 0x8599BF4 Offset: 0x8595BF4 VA: 0x8599BF4
	public string GetAllLogs() { }

	// RVA: 0x85991F0 Offset: 0x85951F0 VA: 0x85991F0
	public void .ctor() { }
}

// Namespace: 
private abstract class RenderGraphObjectPool.SharedObjectPoolBase // TypeDefIndex: 19759
{
	// Fields
	protected static List<RenderGraphObjectPool.SharedObjectPoolBase> s_AllocatedPools; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Clear();

	// RVA: 0x85A5100 Offset: 0x85A1100 VA: 0x85A5100
	public static void ClearAll() { }

	// RVA: 0x85A5278 Offset: 0x85A1278 VA: 0x85A5278
	protected void .ctor() { }

	// RVA: 0x85A5280 Offset: 0x85A1280 VA: 0x85A5280
	private static void .cctor() { }
}

// Namespace: 
private class RenderGraphObjectPool.SharedObjectPool<T> : RenderGraphObjectPool.SharedObjectPoolBase // TypeDefIndex: 19760
{
	// Fields
	private Stack<T> m_Pool; // 0x0
	private static readonly Lazy<RenderGraphObjectPool.SharedObjectPool<T>> s_Instance; // 0x0

	// Properties
	public static RenderGraphObjectPool.SharedObjectPool<T> sharedPool { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E9A8C Offset: 0x54E5A8C VA: 0x54E9A8C
	|-RenderGraphObjectPool.SharedObjectPool<object>.Get
	|
	|-RVA: 0x54E9EBC Offset: 0x54E5EBC VA: 0x54E9EBC
	|-RenderGraphObjectPool.SharedObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E9AC4 Offset: 0x54E5AC4 VA: 0x54E9AC4
	|-RenderGraphObjectPool.SharedObjectPool<object>.Release
	|
	|-RVA: 0x54E9FAC Offset: 0x54E5FAC VA: 0x54E9FAC
	|-RenderGraphObjectPool.SharedObjectPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static RenderGraphObjectPool.SharedObjectPool<T> AllocatePool() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E9AE8 Offset: 0x54E5AE8 VA: 0x54E9AE8
	|-RenderGraphObjectPool.SharedObjectPool<object>.AllocatePool
	|
	|-RVA: 0x54EA074 Offset: 0x54E6074 VA: 0x54EA074
	|-RenderGraphObjectPool.SharedObjectPool<__Il2CppFullySharedGenericType>.AllocatePool
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected override void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E9C14 Offset: 0x54E5C14 VA: 0x54E9C14
	|-RenderGraphObjectPool.SharedObjectPool<object>.Clear
	|
	|-RVA: 0x54EA1D0 Offset: 0x54E61D0 VA: 0x54EA1D0
	|-RenderGraphObjectPool.SharedObjectPool<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public static RenderGraphObjectPool.SharedObjectPool<T> get_sharedPool() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E9C38 Offset: 0x54E5C38 VA: 0x54E9C38
	|-RenderGraphObjectPool.SharedObjectPool<object>.get_sharedPool
	|
	|-RVA: 0x54EA1F8 Offset: 0x54E61F8 VA: 0x54EA1F8
	|-RenderGraphObjectPool.SharedObjectPool<__Il2CppFullySharedGenericType>.get_sharedPool
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E9CD0 Offset: 0x54E5CD0 VA: 0x54E9CD0
	|-RenderGraphObjectPool.SharedObjectPool<object>..ctor
	|
	|-RVA: 0x54EA2E0 Offset: 0x54E62E0 VA: 0x54EA2E0
	|-RenderGraphObjectPool.SharedObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E9D6C Offset: 0x54E5D6C VA: 0x54E9D6C
	|-RenderGraphObjectPool.SharedObjectPool<object>..cctor
	|
	|-RVA: 0x54EA380 Offset: 0x54E6380 VA: 0x54EA380
	|-RenderGraphObjectPool.SharedObjectPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public sealed class RenderGraphObjectPool // TypeDefIndex: 19761
{
	// Fields
	private Dictionary<ValueTuple<Type, int>, Stack<object>> m_ArrayPool; // 0x10
	private List<ValueTuple<object, ValueTuple<Type, int>>> m_AllocatedArrays; // 0x18
	private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; // 0x20

	// Methods

	// RVA: 0x85990C0 Offset: 0x85950C0 VA: 0x85990C0
	internal void .ctor() { }

	// RVA: -1 Offset: -1
	public T[] GetTempArray<T>(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BDB28 Offset: 0x46B9B28 VA: 0x46BDB28
	|-RenderGraphObjectPool.GetTempArray<RenderTargetIdentifier>
	|
	|-RVA: 0x46BDE90 Offset: 0x46B9E90 VA: 0x46BDE90
	|-RenderGraphObjectPool.GetTempArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x85A4FE4 Offset: 0x85A0FE4 VA: 0x85A4FE4
	public MaterialPropertyBlock GetTempMaterialPropertyBlock() { }

	// RVA: 0x85A2108 Offset: 0x859E108 VA: 0x85A2108
	internal void ReleaseAllTempAlloc() { }

	// RVA: -1 Offset: -1
	internal T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BD9DC Offset: 0x46B99DC VA: 0x46BD9DC
	|-RenderGraphObjectPool.Get<object>
	|
	|-RVA: 0x46BDA38 Offset: 0x46B9A38 VA: 0x46BDA38
	|-RenderGraphObjectPool.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void Release<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BE1F8 Offset: 0x46BA1F8 VA: 0x46BE1F8
	|-RenderGraphObjectPool.Release<object>
	|
	|-RVA: 0x46BE264 Offset: 0x46BA264 VA: 0x46BE264
	|-RenderGraphObjectPool.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x85998D4 Offset: 0x85958D4 VA: 0x85998D4
	internal void Cleanup() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal abstract class RenderGraphPass // TypeDefIndex: 19762
{
	// Fields
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <index>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProfilingSampler <customSampler>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <enableAsyncCompute>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <allowPassCulling>k__BackingField; // 0x29
	[CompilerGenerated]
	private TextureHandle <depthBuffer>k__BackingField; // 0x2C
	[CompilerGenerated]
	private TextureHandle[] <colorBuffers>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <colorBufferMaxIndex>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <refCount>k__BackingField; // 0x44
	[CompilerGenerated]
	private bool <generateDebugData>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <allowRendererListCulling>k__BackingField; // 0x49
	public List<ResourceHandle>[] resourceReadLists; // 0x50
	public List<ResourceHandle>[] resourceWriteLists; // 0x58
	public List<ResourceHandle>[] transientResourceList; // 0x60
	public List<RendererListHandle> usedRendererListList; // 0x68

	// Properties
	public string name { get; set; }
	public int index { get; set; }
	public ProfilingSampler customSampler { get; set; }
	public bool enableAsyncCompute { get; set; }
	public bool allowPassCulling { get; set; }
	public TextureHandle depthBuffer { get; set; }
	public TextureHandle[] colorBuffers { get; set; }
	public int colorBufferMaxIndex { get; set; }
	public int refCount { get; set; }
	public bool generateDebugData { get; set; }
	public bool allowRendererListCulling { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public RenderFunc<PassData> GetExecuteDelegate<PassData>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BE378 Offset: 0x46BA378 VA: 0x46BE378
	|-RenderGraphPass.GetExecuteDelegate<object>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Execute(RenderGraphContext renderGraphContext);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Release(RenderGraphObjectPool pool);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool HasRenderFunc();

	[CompilerGenerated]
	// RVA: 0x85A5318 Offset: 0x85A1318 VA: 0x85A5318
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x85A5320 Offset: 0x85A1320 VA: 0x85A5320
	protected void set_name(string value) { }

	[CompilerGenerated]
	// RVA: 0x85A5328 Offset: 0x85A1328 VA: 0x85A5328
	public int get_index() { }

	[CompilerGenerated]
	// RVA: 0x85A5330 Offset: 0x85A1330 VA: 0x85A5330
	protected void set_index(int value) { }

	[CompilerGenerated]
	// RVA: 0x85A5338 Offset: 0x85A1338 VA: 0x85A5338
	public ProfilingSampler get_customSampler() { }

	[CompilerGenerated]
	// RVA: 0x85A5340 Offset: 0x85A1340 VA: 0x85A5340
	protected void set_customSampler(ProfilingSampler value) { }

	[CompilerGenerated]
	// RVA: 0x85A5348 Offset: 0x85A1348 VA: 0x85A5348
	public bool get_enableAsyncCompute() { }

	[CompilerGenerated]
	// RVA: 0x85A5350 Offset: 0x85A1350 VA: 0x85A5350
	protected void set_enableAsyncCompute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85A535C Offset: 0x85A135C VA: 0x85A535C
	public bool get_allowPassCulling() { }

	[CompilerGenerated]
	// RVA: 0x85A5364 Offset: 0x85A1364 VA: 0x85A5364
	protected void set_allowPassCulling(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85A5370 Offset: 0x85A1370 VA: 0x85A5370
	public TextureHandle get_depthBuffer() { }

	[CompilerGenerated]
	// RVA: 0x85A5378 Offset: 0x85A1378 VA: 0x85A5378
	protected void set_depthBuffer(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x85A5380 Offset: 0x85A1380 VA: 0x85A5380
	public TextureHandle[] get_colorBuffers() { }

	[CompilerGenerated]
	// RVA: 0x85A5388 Offset: 0x85A1388 VA: 0x85A5388
	protected void set_colorBuffers(TextureHandle[] value) { }

	[CompilerGenerated]
	// RVA: 0x85A5390 Offset: 0x85A1390 VA: 0x85A5390
	public int get_colorBufferMaxIndex() { }

	[CompilerGenerated]
	// RVA: 0x85A5398 Offset: 0x85A1398 VA: 0x85A5398
	protected void set_colorBufferMaxIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x85A53A0 Offset: 0x85A13A0 VA: 0x85A53A0
	public int get_refCount() { }

	[CompilerGenerated]
	// RVA: 0x85A53A8 Offset: 0x85A13A8 VA: 0x85A53A8
	protected void set_refCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x85A53B0 Offset: 0x85A13B0 VA: 0x85A53B0
	public bool get_generateDebugData() { }

	[CompilerGenerated]
	// RVA: 0x85A53B8 Offset: 0x85A13B8 VA: 0x85A53B8
	protected void set_generateDebugData(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85A53C4 Offset: 0x85A13C4 VA: 0x85A53C4
	public bool get_allowRendererListCulling() { }

	[CompilerGenerated]
	// RVA: 0x85A53CC Offset: 0x85A13CC VA: 0x85A53CC
	protected void set_allowRendererListCulling(bool value) { }

	// RVA: 0x85A53D8 Offset: 0x85A13D8 VA: 0x85A53D8
	public void .ctor() { }

	// RVA: 0x85A5690 Offset: 0x85A1690 VA: 0x85A5690
	public void Clear() { }

	// RVA: 0x85A4730 Offset: 0x85A0730 VA: 0x85A4730
	public void AddResourceWrite(in ResourceHandle res) { }

	// RVA: 0x85A4638 Offset: 0x85A0638 VA: 0x85A4638
	public void AddResourceRead(in ResourceHandle res) { }

	// RVA: 0x85A48C8 Offset: 0x85A08C8 VA: 0x85A48C8
	public void AddTransientResource(in ResourceHandle res) { }

	// RVA: 0x85A4A6C Offset: 0x85A0A6C VA: 0x85A4A6C
	public void UseRendererList(RendererListHandle rendererList) { }

	// RVA: 0x85A4C54 Offset: 0x85A0C54 VA: 0x85A4C54
	public void EnableAsyncCompute(bool value) { }

	// RVA: 0x85A4C60 Offset: 0x85A0C60 VA: 0x85A4C60
	public void AllowPassCulling(bool value) { }

	// RVA: 0x85A4CC8 Offset: 0x85A0CC8 VA: 0x85A4CC8
	public void AllowRendererListCulling(bool value) { }

	// RVA: 0x85A4D48 Offset: 0x85A0D48 VA: 0x85A4D48
	public void GenerateDebugData(bool value) { }

	// RVA: 0x85A42F8 Offset: 0x85A02F8 VA: 0x85A42F8
	public void SetColorBuffer(TextureHandle resource, int index) { }

	// RVA: 0x85A4510 Offset: 0x85A0510 VA: 0x85A4510
	public void SetDepthBuffer(TextureHandle resource, DepthAccess flags) { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal sealed class RenderGraphPass<PassData> : RenderGraphPass // TypeDefIndex: 19763
{
	// Fields
	internal PassData data; // 0x0
	internal RenderFunc<PassData> renderFunc; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void Execute(RenderGraphContext renderGraphContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A6ED0 Offset: 0x54A2ED0 VA: 0x54A6ED0
	|-RenderGraphPass<object>.Execute
	*/

	// RVA: -1 Offset: -1
	public void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A6F20 Offset: 0x54A2F20 VA: 0x54A6F20
	|-RenderGraphPass<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Release(RenderGraphObjectPool pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A6F90 Offset: 0x54A2F90 VA: 0x54A6F90
	|-RenderGraphPass<object>.Release
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool HasRenderFunc() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A700C Offset: 0x54A300C VA: 0x54A700C
	|-RenderGraphPass<object>.HasRenderFunc
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A701C Offset: 0x54A301C VA: 0x54A701C
	|-RenderGraphPass<object>..ctor
	*/
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal enum RenderGraphProfileId // TypeDefIndex: 19764
{
	// Fields
	public int value__; // 0x0
	public const RenderGraphProfileId CompileRenderGraph = 0;
	public const RenderGraphProfileId ExecuteRenderGraph = 1;
	public const RenderGraphProfileId RenderGraphClear = 2;
	public const RenderGraphProfileId RenderGraphClearDebug = 3;
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplay("ComputeBuffer ({handle.index})")]
public struct ComputeBufferHandle // TypeDefIndex: 19765
{
	// Fields
	private static ComputeBufferHandle s_NullHandle; // 0x0
	internal ResourceHandle handle; // 0x0

	// Properties
	public static ComputeBufferHandle nullHandle { get; }

	// Methods

	// RVA: 0x85A5950 Offset: 0x85A1950 VA: 0x85A5950
	public static ComputeBufferHandle get_nullHandle() { }

	// RVA: 0x85A59A8 Offset: 0x85A19A8 VA: 0x85A59A8
	internal void .ctor(int handle, bool shared = False) { }

	// RVA: 0x85A5A7C Offset: 0x85A1A7C VA: 0x85A5A7C
	public static ComputeBuffer op_Implicit(ComputeBufferHandle buffer) { }

	// RVA: 0x85A5B24 Offset: 0x85A1B24 VA: 0x85A5B24
	public bool IsValid() { }

	// RVA: 0x85A5CF0 Offset: 0x85A1CF0 VA: 0x85A5CF0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public struct ComputeBufferDesc // TypeDefIndex: 19766
{
	// Fields
	public int count; // 0x0
	public int stride; // 0x4
	public ComputeBufferType type; // 0x8
	public string name; // 0x10

	// Methods

	// RVA: 0x85A5CF4 Offset: 0x85A1CF4 VA: 0x85A5CF4
	public void .ctor(int count, int stride) { }

	// RVA: 0x85A5D08 Offset: 0x85A1D08 VA: 0x85A5D08
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x85A5D1C Offset: 0x85A1D1C VA: 0x85A5D1C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
internal class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer> // TypeDefIndex: 19767
{
	// Methods

	// RVA: 0x85A5D5C Offset: 0x85A1D5C VA: 0x85A5D5C Slot: 5
	public override string GetName() { }

	// RVA: 0x85A5DB0 Offset: 0x85A1DB0 VA: 0x85A5DB0 Slot: 9
	public override void CreatePooledGraphicsResource() { }

	// RVA: 0x85A5F4C Offset: 0x85A1F4C VA: 0x85A5F4C Slot: 11
	public override void ReleasePooledGraphicsResource(int frameIndex) { }

	// RVA: 0x85A60AC Offset: 0x85A20AC VA: 0x85A60AC Slot: 10
	public override void CreateGraphicsResource(string name = "") { }

	// RVA: 0x85A6228 Offset: 0x85A2228 VA: 0x85A6228 Slot: 12
	public override void ReleaseGraphicsResource() { }

	// RVA: 0x85A6280 Offset: 0x85A2280 VA: 0x85A6280 Slot: 13
	public override void LogCreation(RenderGraphLogger logger) { }

	// RVA: 0x85A6354 Offset: 0x85A2354 VA: 0x85A6354 Slot: 14
	public override void LogRelease(RenderGraphLogger logger) { }

	// RVA: 0x85A6428 Offset: 0x85A2428 VA: 0x85A6428
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer> // TypeDefIndex: 19768
{
	// Methods

	// RVA: 0x85A6470 Offset: 0x85A2470 VA: 0x85A6470 Slot: 8
	protected override void ReleaseInternalResource(ComputeBuffer res) { }

	// RVA: 0x85A6488 Offset: 0x85A2488 VA: 0x85A6488 Slot: 9
	protected override string GetResourceName(ComputeBuffer res) { }

	// RVA: 0x85A64C8 Offset: 0x85A24C8 VA: 0x85A64C8 Slot: 10
	protected override long GetResourceSize(ComputeBuffer res) { }

	// RVA: 0x85A650C Offset: 0x85A250C VA: 0x85A650C Slot: 11
	protected override string GetResourceTypeName() { }

	// RVA: 0x85A654C Offset: 0x85A254C VA: 0x85A654C Slot: 12
	protected override int GetSortIndex(ComputeBuffer res) { }

	// RVA: 0x85A6570 Offset: 0x85A2570 VA: 0x85A6570 Slot: 4
	public override void PurgeUnusedResources(int currentFrameIndex) { }

	// RVA: 0x85A6AC0 Offset: 0x85A2AC0 VA: 0x85A6AC0
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal abstract class IRenderGraphResourcePool // TypeDefIndex: 19769
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void PurgeUnusedResources(int currentFrameIndex);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Cleanup();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void CheckFrameAllocation(bool onException, int frameIndex);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LogResources(RenderGraphLogger logger);

	// RVA: 0x85A6B08 Offset: 0x85A2B08 VA: 0x85A6B08
	protected void .ctor() { }
}

// Namespace: 
private struct RenderGraphResourcePool.ResourceLogInfo<Type> // TypeDefIndex: 19770
{
	// Fields
	public string name; // 0x0
	public long size; // 0x0
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RenderGraphResourcePool.<>c<Type> // TypeDefIndex: 19771
{
	// Fields
	public static readonly RenderGraphResourcePool.<>c<Type> <>9; // 0x0
	public static Comparison<RenderGraphResourcePool.ResourceLogInfo<Type>> <>9__17_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4824298 Offset: 0x4820298 VA: 0x4824298
	|-RenderGraphResourcePool.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4824354 Offset: 0x4820354 VA: 0x4824354
	|-RenderGraphResourcePool.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int <LogResources>b__17_0(RenderGraphResourcePool.ResourceLogInfo<Type> a, RenderGraphResourcePool.ResourceLogInfo<Type> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482435C Offset: 0x482035C VA: 0x482435C
	|-RenderGraphResourcePool.<>c<object>.<LogResources>b__17_0
	*/
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal abstract class RenderGraphResourcePool<Type> : IRenderGraphResourcePool // TypeDefIndex: 19772
{
	// Fields
	[TupleElementNames(new[] { "resource", "frameIndex" })]
	protected Dictionary<int, SortedList<int, ValueTuple<Type, int>>> m_ResourcePool; // 0x0
	protected List<int> m_RemoveList; // 0x0
	private List<ValueTuple<int, Type>> m_FrameAllocatedResources; // 0x0
	protected static int s_CurrentFrameIndex; // 0x0
	private const int kStaleResourceLifetime = 10;

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void ReleaseInternalResource(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.ReleaseInternalResource
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract string GetResourceName(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetResourceName
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract long GetResourceSize(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetResourceSize
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract string GetResourceTypeName();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetResourceTypeName
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract int GetSortIndex(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetSortIndex
	*/

	// RVA: -1 Offset: -1
	public void ReleaseResource(int hash, Type resource, int currentFrameIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A7024 Offset: 0x54A3024 VA: 0x54A7024
	|-RenderGraphResourcePool<object>.ReleaseResource
	*/

	// RVA: -1 Offset: -1
	public bool TryGetResource(int hashCode, out Type resource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A7138 Offset: 0x54A3138 VA: 0x54A7138
	|-RenderGraphResourcePool<object>.TryGetResource
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Cleanup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A7278 Offset: 0x54A3278 VA: 0x54A7278
	|-RenderGraphResourcePool<object>.Cleanup
	*/

	// RVA: -1 Offset: -1
	public void RegisterFrameAllocation(int hash, Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A760C Offset: 0x54A360C VA: 0x54A760C
	|-RenderGraphResourcePool<object>.RegisterFrameAllocation
	*/

	// RVA: -1 Offset: -1
	public void UnregisterFrameAllocation(int hash, Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A76C0 Offset: 0x54A36C0 VA: 0x54A76C0
	|-RenderGraphResourcePool<object>.UnregisterFrameAllocation
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void CheckFrameAllocation(bool onException, int frameIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A7724 Offset: 0x54A3724 VA: 0x54A7724
	|-RenderGraphResourcePool<object>.CheckFrameAllocation
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void LogResources(RenderGraphLogger logger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A79B4 Offset: 0x54A39B4 VA: 0x54A79B4
	|-RenderGraphResourcePool<object>.LogResources
	*/

	// RVA: -1 Offset: -1
	protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A82DC Offset: 0x54A42DC VA: 0x54A82DC
	|-RenderGraphResourcePool<object>.ShouldReleaseResource
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A82EC Offset: 0x54A42EC VA: 0x54A82EC
	|-RenderGraphResourcePool<object>..ctor
	*/
}

// Namespace: 
private sealed class RenderGraphResourceRegistry.ResourceCreateCallback : MulticastDelegate // TypeDefIndex: 19773
{
	// Methods

	// RVA: 0x85A6E8C Offset: 0x85A2E8C VA: 0x85A6E8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x85A7F2C Offset: 0x85A3F2C VA: 0x85A7F2C Slot: 13
	public virtual bool Invoke(RenderGraphContext rgContext, IRenderGraphResource res) { }

	// RVA: 0x85A7F40 Offset: 0x85A3F40 VA: 0x85A7F40 Slot: 14
	public virtual IAsyncResult BeginInvoke(RenderGraphContext rgContext, IRenderGraphResource res, AsyncCallback callback, object object) { }

	// RVA: 0x85A7F68 Offset: 0x85A3F68 VA: 0x85A7F68 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class RenderGraphResourceRegistry.ResourceCallback : MulticastDelegate // TypeDefIndex: 19774
{
	// Methods

	// RVA: 0x85A6F98 Offset: 0x85A2F98 VA: 0x85A6F98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x85A7F90 Offset: 0x85A3F90 VA: 0x85A7F90 Slot: 13
	public virtual void Invoke(RenderGraphContext rgContext, IRenderGraphResource res) { }

	// RVA: 0x85A7FA4 Offset: 0x85A3FA4 VA: 0x85A7FA4 Slot: 14
	public virtual IAsyncResult BeginInvoke(RenderGraphContext rgContext, IRenderGraphResource res, AsyncCallback callback, object object) { }

	// RVA: 0x85A7FCC Offset: 0x85A3FCC VA: 0x85A7FCC Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RenderGraphResourceRegistry.RenderGraphResourcesData // TypeDefIndex: 19775
{
	// Fields
	public DynamicArray<IRenderGraphResource> resourceArray; // 0x10
	public int sharedResourcesCount; // 0x18
	public IRenderGraphResourcePool pool; // 0x20
	public RenderGraphResourceRegistry.ResourceCreateCallback createResourceCallback; // 0x28
	public RenderGraphResourceRegistry.ResourceCallback releaseResourceCallback; // 0x30

	// Methods

	// RVA: 0x85A7DEC Offset: 0x85A3DEC VA: 0x85A7DEC
	public void Clear(bool onException, int frameIndex) { }

	// RVA: 0x85A7E90 Offset: 0x85A3E90 VA: 0x85A7E90
	public void Cleanup() { }

	// RVA: 0x85A7E70 Offset: 0x85A3E70 VA: 0x85A7E70
	public void PurgeUnusedGraphicsResources(int frameIndex) { }

	// RVA: -1 Offset: -1
	public int AddNewRenderGraphResource<ResType>(out ResType outRes, bool pooledResource = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47A3F68 Offset: 0x479FF68 VA: 0x47A3F68
	|-RenderGraphResourceRegistry.RenderGraphResourcesData.AddNewRenderGraphResource<object>
	*/

	// RVA: 0x85A6E04 Offset: 0x85A2E04 VA: 0x85A6E04
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal class RenderGraphResourceRegistry // TypeDefIndex: 19776
{
	// Fields
	private const int kSharedResourceLifetime = 30;
	private static RenderGraphResourceRegistry m_CurrentRegistry; // 0x0
	private RenderGraphResourceRegistry.RenderGraphResourcesData[] m_RenderGraphResources; // 0x10
	private DynamicArray<RendererListResource> m_RendererListResources; // 0x18
	private RenderGraphDebugParams m_RenderGraphDebug; // 0x20
	private RenderGraphLogger m_ResourceLogger; // 0x28
	private RenderGraphLogger m_FrameInformationLogger; // 0x30
	private int m_CurrentFrameIndex; // 0x38
	private int m_ExecutionCount; // 0x3C
	private RTHandle m_CurrentBackbuffer; // 0x40
	private const int kInitialRendererListCount = 256;
	private List<RendererList> m_ActiveRendererLists; // 0x48

	// Properties
	internal static RenderGraphResourceRegistry current { get; set; }

	// Methods

	// RVA: 0x85A6B10 Offset: 0x85A2B10 VA: 0x85A6B10
	internal static RenderGraphResourceRegistry get_current() { }

	// RVA: 0x85A6B58 Offset: 0x85A2B58 VA: 0x85A6B58
	internal static void set_current(RenderGraphResourceRegistry value) { }

	// RVA: 0x859F378 Offset: 0x859B378 VA: 0x859F378
	internal RTHandle GetTexture(in TextureHandle handle) { }

	// RVA: 0x85A4434 Offset: 0x85A0434 VA: 0x85A4434
	internal bool TextureNeedsFallback(in TextureHandle handle) { }

	// RVA: 0x85A0094 Offset: 0x859C094 VA: 0x85A0094
	internal RendererList GetRendererList(in RendererListHandle handle) { }

	// RVA: 0x85A5B78 Offset: 0x85A1B78 VA: 0x85A5B78
	internal ComputeBuffer GetComputeBuffer(in ComputeBufferHandle handle) { }

	// RVA: 0x85A6CB8 Offset: 0x85A2CB8 VA: 0x85A6CB8
	private void .ctor() { }

	// RVA: 0x85993A4 Offset: 0x85953A4 VA: 0x85993A4
	internal void .ctor(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger) { }

	// RVA: 0x859B064 Offset: 0x8597064 VA: 0x859B064
	internal void BeginRenderGraph(int executionCount) { }

	// RVA: 0x859B5C4 Offset: 0x85975C4 VA: 0x859B5C4
	internal void BeginExecute(int currentFrameIndex) { }

	// RVA: 0x85A72C0 Offset: 0x85A32C0 VA: 0x85A72C0
	internal void EndExecute() { }

	// RVA: 0x85A730C Offset: 0x85A330C VA: 0x85A730C
	private void CheckHandleValidity(in ResourceHandle res) { }

	// RVA: 0x85A737C Offset: 0x85A337C VA: 0x85A737C
	private void CheckHandleValidity(RenderGraphResourceType type, int index) { }

	// RVA: 0x85A4220 Offset: 0x85A0220 VA: 0x85A4220
	internal void IncrementWriteCount(in ResourceHandle res) { }

	// RVA: 0x85A7490 Offset: 0x85A3490 VA: 0x85A7490
	internal string GetRenderGraphResourceName(in ResourceHandle res) { }

	// RVA: 0x85A3BE0 Offset: 0x859FBE0 VA: 0x85A3BE0
	internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index) { }

	// RVA: 0x859D550 Offset: 0x8599550 VA: 0x859D550
	internal bool IsRenderGraphResourceImported(in ResourceHandle res) { }

	// RVA: 0x859FD7C Offset: 0x859BD7C VA: 0x859FD7C
	internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index) { }

	// RVA: 0x85A0DB4 Offset: 0x859CDB4 VA: 0x85A0DB4
	internal bool IsGraphicsResourceCreated(in ResourceHandle res) { }

	// RVA: 0x85A0E8C Offset: 0x859CE8C VA: 0x85A0E8C
	internal bool IsRendererListCreated(in RendererListHandle res) { }

	// RVA: 0x85A3C8C Offset: 0x859FC8C VA: 0x85A3C8C
	internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index) { }

	// RVA: 0x85A7568 Offset: 0x85A3568 VA: 0x85A7568
	internal int GetRenderGraphResourceTransientIndex(in ResourceHandle res) { }

	// RVA: 0x8599E24 Offset: 0x8595E24 VA: 0x8599E24
	internal TextureHandle ImportTexture(RTHandle rt) { }

	// RVA: 0x859A218 Offset: 0x8596218 VA: 0x859A218
	internal TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease) { }

	// RVA: 0x859A404 Offset: 0x8596404 VA: 0x859A404
	internal void RefreshSharedTextureDesc(TextureHandle texture, in TextureDesc desc) { }

	// RVA: 0x859A5A4 Offset: 0x85965A4 VA: 0x859A5A4
	internal void ReleaseSharedTexture(TextureHandle texture) { }

	// RVA: 0x8599F34 Offset: 0x8595F34 VA: 0x8599F34
	internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	// RVA: 0x859A0BC Offset: 0x85960BC VA: 0x859A0BC
	internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1) { }

	// RVA: 0x85A7674 Offset: 0x85A3674 VA: 0x85A7674
	internal int GetResourceCount(RenderGraphResourceType type) { }

	// RVA: 0x859CB08 Offset: 0x8598B08 VA: 0x859CB08
	internal int GetTextureResourceCount() { }

	// RVA: 0x859F27C Offset: 0x859B27C VA: 0x859F27C
	internal TextureResource GetTextureResource(in ResourceHandle handle) { }

	// RVA: 0x859A734 Offset: 0x8596734 VA: 0x859A734
	internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle) { }

	// RVA: 0x859A978 Offset: 0x8596978 VA: 0x859A978
	internal RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	// RVA: 0x859AA5C Offset: 0x8596A5C VA: 0x859AA5C
	internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer) { }

	// RVA: 0x859AB44 Offset: 0x8596B44 VA: 0x859AB44
	internal ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc, int transientPassIndex = -1) { }

	// RVA: 0x859AC70 Offset: 0x8596C70 VA: 0x859AC70
	internal ComputeBufferDesc GetComputeBufferResourceDesc(in ResourceHandle handle) { }

	// RVA: 0x859CB10 Offset: 0x8598B10 VA: 0x859CB10
	internal int GetComputeBufferResourceCount() { }

	// RVA: 0x85A6BB8 Offset: 0x85A2BB8 VA: 0x85A6BB8
	private ComputeBufferResource GetComputeBufferResource(in ResourceHandle handle) { }

	// RVA: 0x859FDD4 Offset: 0x859BDD4 VA: 0x859FDD4
	internal void UpdateSharedResourceLastFrameIndex(int type, int index) { }

	// RVA: 0x85A7164 Offset: 0x85A3164 VA: 0x85A7164
	private void ManageSharedRenderGraphResources() { }

	// RVA: 0x85A1F88 Offset: 0x859DF88 VA: 0x85A1F88
	internal bool CreatePooledResource(RenderGraphContext rgContext, int type, int index) { }

	// RVA: 0x85A7728 Offset: 0x85A3728 VA: 0x85A7728
	internal bool CreatePooledResource(RenderGraphContext rgContext, ResourceHandle handle) { }

	// RVA: 0x85A77AC Offset: 0x85A37AC VA: 0x85A77AC
	private bool CreateTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res) { }

	// RVA: 0x85A24B0 Offset: 0x859E4B0 VA: 0x85A24B0
	internal void ReleasePooledResource(RenderGraphContext rgContext, int type, int index) { }

	// RVA: 0x85A79FC Offset: 0x85A39FC VA: 0x85A79FC
	internal void ReleasePooledResource(RenderGraphContext rgContext, ResourceHandle handle) { }

	// RVA: 0x85A7A80 Offset: 0x85A3A80 VA: 0x85A7A80
	private void ReleaseTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res) { }

	// RVA: 0x85A7670 Offset: 0x85A3670 VA: 0x85A7670
	private void ValidateTextureDesc(in TextureDesc desc) { }

	// RVA: 0x85A76E4 Offset: 0x85A36E4 VA: 0x85A76E4
	private void ValidateRendererListDesc(in RendererListDesc desc) { }

	// RVA: 0x85A7724 Offset: 0x85A3724 VA: 0x85A7724
	private void ValidateComputeBufferDesc(in ComputeBufferDesc desc) { }

	// RVA: 0x859E9C4 Offset: 0x859A9C4 VA: 0x859E9C4
	internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = False) { }

	// RVA: 0x859BF84 Offset: 0x8597F84 VA: 0x859BF84
	internal void Clear(bool onException) { }

	// RVA: 0x8599B84 Offset: 0x8595B84 VA: 0x8599B84
	internal void PurgeUnusedGraphicsResources() { }

	// RVA: 0x85997F4 Offset: 0x85957F4 VA: 0x85997F4
	internal void Cleanup() { }

	// RVA: 0x8599D9C Offset: 0x8595D9C VA: 0x8599D9C
	internal void FlushLogs() { }

	// RVA: 0x85A7C44 Offset: 0x85A3C44 VA: 0x85A7C44
	private void LogResources() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplay("RendererList ({handle})")]
public struct RendererListHandle // TypeDefIndex: 19777
{
	// Fields
	private bool m_IsValid; // 0x0
	[CompilerGenerated]
	private int <handle>k__BackingField; // 0x4

	// Properties
	internal int handle { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x85A7FD8 Offset: 0x85A3FD8 VA: 0x85A7FD8
	internal int get_handle() { }

	[CompilerGenerated]
	// RVA: 0x85A7FE0 Offset: 0x85A3FE0 VA: 0x85A7FE0
	private void set_handle(int value) { }

	// RVA: 0x85A7714 Offset: 0x85A3714 VA: 0x85A7714
	internal void .ctor(int handle) { }

	// RVA: 0x85A6BB0 Offset: 0x85A2BB0 VA: 0x85A6BB0
	public static int op_Implicit(RendererListHandle handle) { }

	// RVA: 0x85A7FE8 Offset: 0x85A3FE8 VA: 0x85A7FE8
	public static RendererList op_Implicit(RendererListHandle rendererList) { }

	// RVA: 0x85A80C0 Offset: 0x85A40C0 VA: 0x85A80C0
	public bool IsValid() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal struct RendererListResource // TypeDefIndex: 19778
{
	// Fields
	public RendererListDesc desc; // 0x0
	public RendererList rendererList; // 0xD0

	// Methods

	// RVA: 0x85A76E8 Offset: 0x85A36E8 VA: 0x85A76E8
	internal void .ctor(in RendererListDesc desc) { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal enum RenderGraphResourceType // TypeDefIndex: 19779
{
	// Fields
	public int value__; // 0x0
	public const RenderGraphResourceType Texture = 0;
	public const RenderGraphResourceType ComputeBuffer = 1;
	public const RenderGraphResourceType Count = 2;
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal struct ResourceHandle // TypeDefIndex: 19780
{
	// Fields
	private const uint kValidityMask = 4294901760;
	private const uint kIndexMask = 65535;
	private uint m_Value; // 0x0
	private static uint s_CurrentValidBit; // 0x0
	private static uint s_SharedResourceValidBit; // 0x4
	[CompilerGenerated]
	private RenderGraphResourceType <type>k__BackingField; // 0x4

	// Properties
	public int index { get; }
	public RenderGraphResourceType type { get; set; }
	public int iType { get; }

	// Methods

	// RVA: 0x85A7374 Offset: 0x85A3374 VA: 0x85A7374
	public int get_index() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85A80C8 Offset: 0x85A40C8 VA: 0x85A80C8
	public RenderGraphResourceType get_type() { }

	[CompilerGenerated]
	// RVA: 0x85A80D0 Offset: 0x85A40D0 VA: 0x85A80D0
	private void set_type(RenderGraphResourceType value) { }

	// RVA: 0x85A58FC Offset: 0x85A18FC VA: 0x85A58FC
	public int get_iType() { }

	// RVA: 0x85A59DC Offset: 0x85A19DC VA: 0x85A59DC
	internal void .ctor(int value, RenderGraphResourceType type, bool shared) { }

	// RVA: 0x859D4FC Offset: 0x85994FC VA: 0x859D4FC
	public static int op_Implicit(ResourceHandle handle) { }

	// RVA: 0x85A5C50 Offset: 0x85A1C50 VA: 0x85A5C50
	public bool IsValid() { }

	// RVA: 0x85A70A4 Offset: 0x85A30A4 VA: 0x85A70A4
	public static void NewFrame(int executionIndex) { }

	// RVA: 0x85A80D8 Offset: 0x85A40D8 VA: 0x85A80D8
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal class IRenderGraphResource // TypeDefIndex: 19781
{
	// Fields
	public bool imported; // 0x10
	public bool shared; // 0x11
	public bool sharedExplicitRelease; // 0x12
	public bool requestFallBack; // 0x13
	public uint writeCount; // 0x14
	public int cachedHash; // 0x18
	public int transientPassIndex; // 0x1C
	public int sharedResourceLastFrameUsed; // 0x20
	protected IRenderGraphResourcePool m_Pool; // 0x28

	// Methods

	// RVA: 0x85A8128 Offset: 0x85A4128 VA: 0x85A8128 Slot: 4
	public virtual void Reset(IRenderGraphResourcePool pool) { }

	// RVA: 0x85A8140 Offset: 0x85A4140 VA: 0x85A8140 Slot: 5
	public virtual string GetName() { }

	// RVA: 0x85A8180 Offset: 0x85A4180 VA: 0x85A8180 Slot: 6
	public virtual bool IsCreated() { }

	// RVA: 0x85A8188 Offset: 0x85A4188 VA: 0x85A8188 Slot: 7
	public virtual void IncrementWriteCount() { }

	// RVA: 0x85A8198 Offset: 0x85A4198 VA: 0x85A8198 Slot: 8
	public virtual bool NeedsFallBack() { }

	// RVA: 0x85A81B8 Offset: 0x85A41B8 VA: 0x85A81B8 Slot: 9
	public virtual void CreatePooledGraphicsResource() { }

	// RVA: 0x85A81BC Offset: 0x85A41BC VA: 0x85A81BC Slot: 10
	public virtual void CreateGraphicsResource(string name = "") { }

	// RVA: 0x85A81C0 Offset: 0x85A41C0 VA: 0x85A81C0 Slot: 11
	public virtual void ReleasePooledGraphicsResource(int frameIndex) { }

	// RVA: 0x85A81C4 Offset: 0x85A41C4 VA: 0x85A81C4 Slot: 12
	public virtual void ReleaseGraphicsResource() { }

	// RVA: 0x85A81C8 Offset: 0x85A41C8 VA: 0x85A81C8 Slot: 13
	public virtual void LogCreation(RenderGraphLogger logger) { }

	// RVA: 0x85A81CC Offset: 0x85A41CC VA: 0x85A81CC Slot: 14
	public virtual void LogRelease(RenderGraphLogger logger) { }

	// RVA: 0x85A81D0 Offset: 0x85A41D0 VA: 0x85A81D0 Slot: 15
	public virtual int GetSortIndex() { }

	// RVA: 0x85A81D8 Offset: 0x85A41D8 VA: 0x85A81D8
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
internal abstract class RenderGraphResource<DescType, ResType> : IRenderGraphResource // TypeDefIndex: 19782
{
	// Fields
	public DescType desc; // 0x0
	public ResType graphicsResource; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A83FC Offset: 0x54A43FC VA: 0x54A83FC
	|-RenderGraphResource<ComputeBufferDesc, object>..ctor
	|
	|-RVA: 0x54A8440 Offset: 0x54A4440 VA: 0x54A8440
	|-RenderGraphResource<TextureDesc, object>..ctor
	|
	|-RVA: 0x54A8484 Offset: 0x54A4484 VA: 0x54A8484
	|-RenderGraphResource<__Il2CppFullySharedGenericStructType, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Reset(IRenderGraphResourcePool pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A8404 Offset: 0x54A4404 VA: 0x54A8404
	|-RenderGraphResource<ComputeBufferDesc, object>.Reset
	|
	|-RVA: 0x54A8448 Offset: 0x54A4448 VA: 0x54A8448
	|-RenderGraphResource<TextureDesc, object>.Reset
	|
	|-RVA: 0x54A848C Offset: 0x54A448C VA: 0x54A848C
	|-RenderGraphResource<__Il2CppFullySharedGenericStructType, object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A8428 Offset: 0x54A4428 VA: 0x54A8428
	|-RenderGraphResource<ComputeBufferDesc, object>.IsCreated
	|
	|-RVA: 0x54A846C Offset: 0x54A446C VA: 0x54A846C
	|-RenderGraphResource<TextureDesc, object>.IsCreated
	|
	|-RVA: 0x54A84D8 Offset: 0x54A44D8 VA: 0x54A84D8
	|-RenderGraphResource<__Il2CppFullySharedGenericStructType, object>.IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void ReleaseGraphicsResource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A8438 Offset: 0x54A4438 VA: 0x54A8438
	|-RenderGraphResource<ComputeBufferDesc, object>.ReleaseGraphicsResource
	|
	|-RVA: 0x54A847C Offset: 0x54A447C VA: 0x54A847C
	|-RenderGraphResource<TextureDesc, object>.ReleaseGraphicsResource
	|
	|-RVA: 0x54A8508 Offset: 0x54A4508 VA: 0x54A8508
	|-RenderGraphResource<__Il2CppFullySharedGenericStructType, object>.ReleaseGraphicsResource
	*/
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplay("Texture ({handle.index})")]
public struct TextureHandle // TypeDefIndex: 19783
{
	// Fields
	private static TextureHandle s_NullHandle; // 0x0
	internal ResourceHandle handle; // 0x0

	// Properties
	public static TextureHandle nullHandle { get; }

	// Methods

	// RVA: 0x85A81E0 Offset: 0x85A41E0 VA: 0x85A81E0
	public static TextureHandle get_nullHandle() { }

	// RVA: 0x85A763C Offset: 0x85A363C VA: 0x85A763C
	internal void .ctor(int handle, bool shared = False) { }

	// RVA: 0x85A8238 Offset: 0x85A4238 VA: 0x85A8238
	public static RenderTargetIdentifier op_Implicit(TextureHandle texture) { }

	// RVA: 0x85A8310 Offset: 0x85A4310 VA: 0x85A8310
	public static Texture op_Implicit(TextureHandle texture) { }

	// RVA: 0x85A83BC Offset: 0x85A43BC VA: 0x85A83BC
	public static RenderTexture op_Implicit(TextureHandle texture) { }

	// RVA: 0x85A8468 Offset: 0x85A4468 VA: 0x85A8468
	public static RTHandle op_Implicit(TextureHandle texture) { }

	// RVA: 0x859A8C8 Offset: 0x85968C8 VA: 0x859A8C8
	public bool IsValid() { }

	// RVA: 0x85A8510 Offset: 0x85A4510 VA: 0x85A8510
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public enum TextureSizeMode // TypeDefIndex: 19784
{
	// Fields
	public int value__; // 0x0
	public const TextureSizeMode Explicit = 0;
	public const TextureSizeMode Scale = 1;
	public const TextureSizeMode Functor = 2;
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public struct FastMemoryDesc // TypeDefIndex: 19785
{
	// Fields
	public bool inFastMemory; // 0x0
	public FastMemoryFlags flags; // 0x4
	public float residencyFraction; // 0x8
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public struct TextureDesc // TypeDefIndex: 19786
{
	// Fields
	public TextureSizeMode sizeMode; // 0x0
	public int width; // 0x4
	public int height; // 0x8
	public int slices; // 0xC
	public Vector2 scale; // 0x10
	public ScaleFunc func; // 0x18
	public DepthBits depthBufferBits; // 0x20
	public GraphicsFormat colorFormat; // 0x24
	public FilterMode filterMode; // 0x28
	public TextureWrapMode wrapMode; // 0x2C
	public TextureDimension dimension; // 0x30
	public bool enableRandomWrite; // 0x34
	public bool useMipMap; // 0x35
	public bool autoGenerateMips; // 0x36
	public bool isShadowMap; // 0x37
	public int anisoLevel; // 0x38
	public float mipMapBias; // 0x3C
	public MSAASamples msaaSamples; // 0x40
	public bool bindTextureMS; // 0x44
	public bool useDynamicScale; // 0x45
	public RenderTextureMemoryless memoryless; // 0x48
	public VRTextureUsage vrUsage; // 0x4C
	public string name; // 0x50
	public FastMemoryDesc fastMemoryDesc; // 0x58
	public bool fallBackToBlackTexture; // 0x64
	public bool disableFallBackToImportedTexture; // 0x65
	public bool clearBuffer; // 0x66
	public Color clearColor; // 0x68

	// Methods

	// RVA: 0x85A86DC Offset: 0x85A46DC VA: 0x85A86DC
	private void InitDefaultValues(bool dynamicResolution, bool xrReady) { }

	// RVA: 0x85A87A4 Offset: 0x85A47A4 VA: 0x85A87A4
	public void .ctor(int width, int height, bool dynamicResolution = False, bool xrReady = False) { }

	// RVA: 0x85A87DC Offset: 0x85A47DC VA: 0x85A87DC
	public void .ctor(Vector2 scale, bool dynamicResolution = False, bool xrReady = False) { }

	// RVA: 0x85A8824 Offset: 0x85A4824 VA: 0x85A8824
	public void .ctor(ScaleFunc func, bool dynamicResolution = False, bool xrReady = False) { }

	// RVA: 0x85A8898 Offset: 0x85A4898 VA: 0x85A8898
	public void .ctor(TextureDesc input) { }

	// RVA: 0x85A88B8 Offset: 0x85A48B8 VA: 0x85A88B8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplay("TextureResource ({desc.name})")]
internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle> // TypeDefIndex: 19787
{
	// Fields
	private static int m_TextureCreationIndex; // 0x0

	// Methods

	// RVA: 0x85A8ABC Offset: 0x85A4ABC VA: 0x85A8ABC Slot: 5
	public override string GetName() { }

	// RVA: 0x85A8B28 Offset: 0x85A4B28 VA: 0x85A8B28 Slot: 9
	public override void CreatePooledGraphicsResource() { }

	// RVA: 0x85A8CA0 Offset: 0x85A4CA0 VA: 0x85A8CA0 Slot: 11
	public override void ReleasePooledGraphicsResource(int frameIndex) { }

	// RVA: 0x85A8E00 Offset: 0x85A4E00 VA: 0x85A8E00 Slot: 10
	public override void CreateGraphicsResource(string name = "") { }

	// RVA: 0x85A91E4 Offset: 0x85A51E4 VA: 0x85A91E4 Slot: 12
	public override void ReleaseGraphicsResource() { }

	// RVA: 0x85A923C Offset: 0x85A523C VA: 0x85A923C Slot: 13
	public override void LogCreation(RenderGraphLogger logger) { }

	// RVA: 0x85A9354 Offset: 0x85A5354 VA: 0x85A9354 Slot: 14
	public override void LogRelease(RenderGraphLogger logger) { }

	// RVA: 0x85A942C Offset: 0x85A542C VA: 0x85A942C
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal class TexturePool : RenderGraphResourcePool<RTHandle> // TypeDefIndex: 19788
{
	// Methods

	// RVA: 0x85A9474 Offset: 0x85A5474 VA: 0x85A9474 Slot: 8
	protected override void ReleaseInternalResource(RTHandle res) { }

	// RVA: 0x85A948C Offset: 0x85A548C VA: 0x85A948C Slot: 9
	protected override string GetResourceName(RTHandle res) { }

	// RVA: 0x85A94AC Offset: 0x85A54AC VA: 0x85A94AC Slot: 10
	protected override long GetResourceSize(RTHandle res) { }

	// RVA: 0x85A94C8 Offset: 0x85A54C8 VA: 0x85A94C8 Slot: 11
	protected override string GetResourceTypeName() { }

	// RVA: 0x85A9508 Offset: 0x85A5508 VA: 0x85A9508 Slot: 12
	protected override int GetSortIndex(RTHandle res) { }

	// RVA: 0x85A9520 Offset: 0x85A5520 VA: 0x85A9520 Slot: 4
	public override void PurgeUnusedResources(int currentFrameIndex) { }

	// RVA: 0x85A9A70 Offset: 0x85A5A70 VA: 0x85A9A70
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public class CameraSwitcher : MonoBehaviour // TypeDefIndex: 19789
{
	// Fields
	public Camera[] m_Cameras; // 0x20
	private int m_CurrentCameraIndex; // 0x28
	private Camera m_OriginalCamera; // 0x30
	private Vector3 m_OriginalCameraPosition; // 0x38
	private Quaternion m_OriginalCameraRotation; // 0x44
	private Camera m_CurrentCamera; // 0x58
	private GUIContent[] m_CameraNames; // 0x60
	private int[] m_CameraIndices; // 0x68
	private DebugUI.EnumField m_DebugEntry; // 0x70
	private int m_DebugEntryEnumIndex; // 0x78

	// Methods

	// RVA: 0x85A9AB8 Offset: 0x85A5AB8 VA: 0x85A9AB8
	private void OnEnable() { }

	// RVA: 0x85AA378 Offset: 0x85A6378 VA: 0x85AA378
	private void OnDisable() { }

	// RVA: 0x85AA080 Offset: 0x85A6080 VA: 0x85AA080
	private int GetCameraCount() { }

	// RVA: 0x85AA408 Offset: 0x85A6408 VA: 0x85AA408
	private Camera GetNextCamera() { }

	// RVA: 0x85AA450 Offset: 0x85A6450 VA: 0x85AA450
	private void SetCameraIndex(int index) { }

	// RVA: 0x85AA67C Offset: 0x85A667C VA: 0x85AA67C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x85AA68C Offset: 0x85A668C VA: 0x85AA68C
	private int <OnEnable>b__10_0() { }

	[CompilerGenerated]
	// RVA: 0x85AA694 Offset: 0x85A6694 VA: 0x85AA694
	private void <OnEnable>b__10_1(int value) { }

	[CompilerGenerated]
	// RVA: 0x85AA698 Offset: 0x85A6698 VA: 0x85AA698
	private int <OnEnable>b__10_2() { }

	[CompilerGenerated]
	// RVA: 0x85AA6A0 Offset: 0x85A66A0 VA: 0x85AA6A0
	private void <OnEnable>b__10_3(int value) { }
}

// Namespace: UnityEngine.Rendering
public class FreeCamera : MonoBehaviour // TypeDefIndex: 19790
{
	// Fields
	private const float k_MouseSensitivityMultiplier = 0.01;
	public float m_LookSpeedController; // 0x20
	public float m_LookSpeedMouse; // 0x24
	public float m_MoveSpeed; // 0x28
	public float m_MoveSpeedIncrement; // 0x2C
	public float m_Turbo; // 0x30
	private static string kMouseX; // 0x0
	private static string kMouseY; // 0x8
	private static string kRightStickX; // 0x10
	private static string kRightStickY; // 0x18
	private static string kVertical; // 0x20
	private static string kHorizontal; // 0x28
	private static string kYAxis; // 0x30
	private static string kSpeedAxis; // 0x38
	private float inputRotateAxisX; // 0x34
	private float inputRotateAxisY; // 0x38
	private float inputChangeSpeed; // 0x3C
	private float inputVertical; // 0x40
	private float inputHorizontal; // 0x44
	private float inputYAxis; // 0x48
	private bool leftShiftBoost; // 0x4C
	private bool leftShift; // 0x4D
	private bool fire1; // 0x4E

	// Methods

	// RVA: 0x85AA6A8 Offset: 0x85A66A8 VA: 0x85AA6A8
	private void OnEnable() { }

	// RVA: 0x85AA6AC Offset: 0x85A66AC VA: 0x85AA6AC
	private void RegisterInputs() { }

	// RVA: 0x85AA6B0 Offset: 0x85A66B0 VA: 0x85AA6B0
	private void UpdateInputs() { }

	// RVA: 0x85AA87C Offset: 0x85A687C VA: 0x85AA87C
	private void Update() { }

	// RVA: 0x85AACC4 Offset: 0x85A6CC4 VA: 0x85AACC4
	public void .ctor() { }

	// RVA: 0x85AACE0 Offset: 0x85A6CE0 VA: 0x85AACE0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CommandBufferPool.<>c // TypeDefIndex: 19791
{
	// Fields
	public static readonly CommandBufferPool.<>c <>9; // 0x0

	// Methods

	// RVA: 0x85AB164 Offset: 0x85A7164 VA: 0x85AB164
	private static void .cctor() { }

	// RVA: 0x85AB1CC Offset: 0x85A71CC VA: 0x85AB1CC
	public void .ctor() { }

	// RVA: 0x85AB1D4 Offset: 0x85A71D4 VA: 0x85AB1D4
	internal void <.cctor>b__4_0(CommandBuffer x) { }
}

// Namespace: UnityEngine.Rendering
public static class CommandBufferPool // TypeDefIndex: 19792
{
	// Fields
	private static ObjectPool<CommandBuffer> s_BufferPool; // 0x0

	// Methods

	// RVA: 0x85AAE84 Offset: 0x85A6E84 VA: 0x85AAE84
	public static CommandBuffer Get() { }

	// RVA: 0x85AAF2C Offset: 0x85A6F2C VA: 0x85AAF2C
	public static CommandBuffer Get(string name) { }

	// RVA: 0x85AAFC4 Offset: 0x85A6FC4 VA: 0x85AAFC4
	public static void Release(CommandBuffer buffer) { }

	// RVA: 0x85AB044 Offset: 0x85A7044 VA: 0x85AB044
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum ClearFlag // TypeDefIndex: 19793
{
	// Fields
	public int value__; // 0x0
	public const ClearFlag None = 0;
	public const ClearFlag Color = 1;
	public const ClearFlag Depth = 2;
	public const ClearFlag Stencil = 4;
	public const ClearFlag DepthStencil = 6;
	public const ClearFlag ColorStencil = 5;
	public const ClearFlag All = 7;
}

// Namespace: UnityEngine.Rendering
public static class ComponentSingleton<TType> // TypeDefIndex: 19794
{
	// Fields
	private static TType s_Instance; // 0x0

	// Properties
	public static TType instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static TType get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA967C Offset: 0x5CA567C VA: 0x5CA967C
	|-ComponentSingleton<object>.get_instance
	*/

	// RVA: -1 Offset: -1
	public static void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA98CC Offset: 0x5CA58CC VA: 0x5CA98CC
	|-ComponentSingleton<object>.Release
	*/
}

// Namespace: UnityEngine.Rendering
public class ConstantBuffer // TypeDefIndex: 19795
{
	// Fields
	private static List<ConstantBufferBase> m_RegisteredConstantBuffers; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static void PushGlobal<CBType>(CommandBuffer cmd, in CBType data, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455EF00 Offset: 0x455AF00 VA: 0x455EF00
	|-ConstantBuffer.PushGlobal<ShaderVariablesProbeVolumes>
	|
	|-RVA: 0x455EF7C Offset: 0x455AF7C VA: 0x455EF7C
	|-ConstantBuffer.PushGlobal<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void PushGlobal<CBType>(in CBType data, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455EE84 Offset: 0x455AE84 VA: 0x455EE84
	|-ConstantBuffer.PushGlobal<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Push<CBType>(CommandBuffer cmd, in CBType data, ComputeShader cs, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455ED58 Offset: 0x455AD58 VA: 0x455ED58
	|-ConstantBuffer.Push<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Push<CBType>(in CBType data, ComputeShader cs, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455EC50 Offset: 0x455AC50 VA: 0x455EC50
	|-ConstantBuffer.Push<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Push<CBType>(CommandBuffer cmd, in CBType data, Material mat, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455EDF0 Offset: 0x455ADF0 VA: 0x455EDF0
	|-ConstantBuffer.Push<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Push<CBType>(in CBType data, Material mat, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455ECD4 Offset: 0x455ACD4 VA: 0x455ECD4
	|-ConstantBuffer.Push<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void UpdateData<CBType>(CommandBuffer cmd, in CBType data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455F4EC Offset: 0x455B4EC VA: 0x455F4EC
	|-ConstantBuffer.UpdateData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void UpdateData<CBType>(in CBType data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455F368 Offset: 0x455B368 VA: 0x455F368
	|-ConstantBuffer.UpdateData<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x455F3BC Offset: 0x455B3BC VA: 0x455F3BC
	|-ConstantBuffer.UpdateData<Hammersley.Hammersley2dSeq16>
	|
	|-RVA: 0x455F408 Offset: 0x455B408 VA: 0x455F408
	|-ConstantBuffer.UpdateData<Hammersley.Hammersley2dSeq256>
	|
	|-RVA: 0x455F454 Offset: 0x455B454 VA: 0x455F454
	|-ConstantBuffer.UpdateData<Hammersley.Hammersley2dSeq32>
	|
	|-RVA: 0x455F4A0 Offset: 0x455B4A0 VA: 0x455F4A0
	|-ConstantBuffer.UpdateData<Hammersley.Hammersley2dSeq64>
	*/

	// RVA: -1 Offset: -1
	public static void SetGlobal<CBType>(CommandBuffer cmd, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455F30C Offset: 0x455B30C VA: 0x455F30C
	|-ConstantBuffer.SetGlobal<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void SetGlobal<CBType>(int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455F2B8 Offset: 0x455B2B8 VA: 0x455F2B8
	|-ConstantBuffer.SetGlobal<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Set<CBType>(CommandBuffer cmd, ComputeShader cs, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455F0BC Offset: 0x455B0BC VA: 0x455F0BC
	|-ConstantBuffer.Set<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x455F128 Offset: 0x455B128 VA: 0x455F128
	|-ConstantBuffer.Set<Hammersley.Hammersley2dSeq16>
	|
	|-RVA: 0x455F18C Offset: 0x455B18C VA: 0x455F18C
	|-ConstantBuffer.Set<Hammersley.Hammersley2dSeq256>
	|
	|-RVA: 0x455F1F0 Offset: 0x455B1F0 VA: 0x455F1F0
	|-ConstantBuffer.Set<Hammersley.Hammersley2dSeq32>
	|
	|-RVA: 0x455F254 Offset: 0x455B254 VA: 0x455F254
	|-ConstantBuffer.Set<Hammersley.Hammersley2dSeq64>
	*/

	// RVA: -1 Offset: -1
	public static void Set<CBType>(ComputeShader cs, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455F004 Offset: 0x455B004 VA: 0x455F004
	|-ConstantBuffer.Set<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Set<CBType>(Material mat, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x455F060 Offset: 0x455B060 VA: 0x455F060
	|-ConstantBuffer.Set<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x85AB1EC Offset: 0x85A71EC VA: 0x85AB1EC
	public static void ReleaseAll() { }

	// RVA: 0x85AB3B4 Offset: 0x85A73B4 VA: 0x85AB3B4
	internal static void Register(ConstantBufferBase cb) { }

	// RVA: 0x85AB488 Offset: 0x85A7488 VA: 0x85AB488
	public void .ctor() { }

	// RVA: 0x85AB490 Offset: 0x85A7490 VA: 0x85AB490
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public abstract class ConstantBufferBase // TypeDefIndex: 19796
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release();

	// RVA: 0x85AB528 Offset: 0x85A7528 VA: 0x85AB528
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public class ConstantBuffer<CBType> : ConstantBufferBase // TypeDefIndex: 19797
{
	// Fields
	private HashSet<int> m_GlobalBindings; // 0x0
	private CBType[] m_Data; // 0x0
	private ComputeBuffer m_GPUConstantBuffer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D29C Offset: 0x5D0929C VA: 0x5D0D29C
	|-ConstantBuffer<ShaderVariablesProbeVolumes>..ctor
	|
	|-RVA: 0x5D0D8C8 Offset: 0x5D098C8 VA: 0x5D0D8C8
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x5D0E06C Offset: 0x5D0A06C VA: 0x5D0E06C
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>..ctor
	|
	|-RVA: 0x5D0E6E8 Offset: 0x5D0A6E8 VA: 0x5D0E6E8
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>..ctor
	|
	|-RVA: 0x5D0ED84 Offset: 0x5D0AD84 VA: 0x5D0ED84
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>..ctor
	|
	|-RVA: 0x5D0F400 Offset: 0x5D0B400 VA: 0x5D0F400
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>..ctor
	*/

	// RVA: -1 Offset: -1
	public void UpdateData(CommandBuffer cmd, in CBType data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D39C Offset: 0x5D0939C VA: 0x5D0D39C
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.UpdateData
	|
	|-RVA: 0x5D0D9E4 Offset: 0x5D099E4 VA: 0x5D0D9E4
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.UpdateData
	|
	|-RVA: 0x5D0E16C Offset: 0x5D0A16C VA: 0x5D0E16C
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.UpdateData
	|
	|-RVA: 0x5D0E7E8 Offset: 0x5D0A7E8 VA: 0x5D0E7E8
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.UpdateData
	|
	|-RVA: 0x5D0EE84 Offset: 0x5D0AE84 VA: 0x5D0EE84
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.UpdateData
	|
	|-RVA: 0x5D0F500 Offset: 0x5D0B500 VA: 0x5D0F500
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.UpdateData
	*/

	// RVA: -1 Offset: -1
	public void UpdateData(in CBType data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D424 Offset: 0x5D09424 VA: 0x5D0D424
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.UpdateData
	|
	|-RVA: 0x5D0DAF0 Offset: 0x5D09AF0 VA: 0x5D0DAF0
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.UpdateData
	|
	|-RVA: 0x5D0E218 Offset: 0x5D0A218 VA: 0x5D0E218
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.UpdateData
	|
	|-RVA: 0x5D0E8A4 Offset: 0x5D0A8A4 VA: 0x5D0E8A4
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.UpdateData
	|
	|-RVA: 0x5D0EF30 Offset: 0x5D0AF30 VA: 0x5D0EF30
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.UpdateData
	|
	|-RVA: 0x5D0F5AC Offset: 0x5D0B5AC VA: 0x5D0F5AC
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.UpdateData
	*/

	// RVA: -1 Offset: -1
	public void SetGlobal(CommandBuffer cmd, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D498 Offset: 0x5D09498 VA: 0x5D0D498
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.SetGlobal
	|
	|-RVA: 0x5D0DBEC Offset: 0x5D09BEC VA: 0x5D0DBEC
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.SetGlobal
	|
	|-RVA: 0x5D0E2B8 Offset: 0x5D0A2B8 VA: 0x5D0E2B8
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.SetGlobal
	|
	|-RVA: 0x5D0E954 Offset: 0x5D0A954 VA: 0x5D0E954
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.SetGlobal
	|
	|-RVA: 0x5D0EFD0 Offset: 0x5D0AFD0 VA: 0x5D0EFD0
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.SetGlobal
	|
	|-RVA: 0x5D0F64C Offset: 0x5D0B64C VA: 0x5D0F64C
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.SetGlobal
	*/

	// RVA: -1 Offset: -1
	public void SetGlobal(int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D530 Offset: 0x5D09530 VA: 0x5D0D530
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.SetGlobal
	|
	|-RVA: 0x5D0DC84 Offset: 0x5D09C84 VA: 0x5D0DC84
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.SetGlobal
	|
	|-RVA: 0x5D0E350 Offset: 0x5D0A350 VA: 0x5D0E350
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.SetGlobal
	|
	|-RVA: 0x5D0E9EC Offset: 0x5D0A9EC VA: 0x5D0E9EC
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.SetGlobal
	|
	|-RVA: 0x5D0F068 Offset: 0x5D0B068 VA: 0x5D0F068
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.SetGlobal
	|
	|-RVA: 0x5D0F6E4 Offset: 0x5D0B6E4 VA: 0x5D0F6E4
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.SetGlobal
	*/

	// RVA: -1 Offset: -1
	public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D5B4 Offset: 0x5D095B4 VA: 0x5D0D5B4
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.Set
	|
	|-RVA: 0x5D0DD08 Offset: 0x5D09D08 VA: 0x5D0DD08
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.Set
	|
	|-RVA: 0x5D0E3D4 Offset: 0x5D0A3D4 VA: 0x5D0E3D4
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.Set
	|
	|-RVA: 0x5D0EA70 Offset: 0x5D0AA70 VA: 0x5D0EA70
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.Set
	|
	|-RVA: 0x5D0F0EC Offset: 0x5D0B0EC VA: 0x5D0F0EC
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.Set
	|
	|-RVA: 0x5D0F768 Offset: 0x5D0B768 VA: 0x5D0F768
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.Set
	*/

	// RVA: -1 Offset: -1
	public void Set(ComputeShader cs, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D614 Offset: 0x5D09614 VA: 0x5D0D614
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.Set
	|
	|-RVA: 0x5D0DD68 Offset: 0x5D09D68 VA: 0x5D0DD68
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.Set
	|
	|-RVA: 0x5D0E434 Offset: 0x5D0A434 VA: 0x5D0E434
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.Set
	|
	|-RVA: 0x5D0EAD0 Offset: 0x5D0AAD0 VA: 0x5D0EAD0
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.Set
	|
	|-RVA: 0x5D0F14C Offset: 0x5D0B14C VA: 0x5D0F14C
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.Set
	|
	|-RVA: 0x5D0F7C8 Offset: 0x5D0B7C8 VA: 0x5D0F7C8
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.Set
	*/

	// RVA: -1 Offset: -1
	public void Set(Material mat, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D664 Offset: 0x5D09664 VA: 0x5D0D664
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.Set
	|
	|-RVA: 0x5D0DDB8 Offset: 0x5D09DB8 VA: 0x5D0DDB8
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.Set
	|
	|-RVA: 0x5D0E484 Offset: 0x5D0A484 VA: 0x5D0E484
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.Set
	|
	|-RVA: 0x5D0EB20 Offset: 0x5D0AB20 VA: 0x5D0EB20
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.Set
	|
	|-RVA: 0x5D0F19C Offset: 0x5D0B19C VA: 0x5D0F19C
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.Set
	|
	|-RVA: 0x5D0F818 Offset: 0x5D0B818 VA: 0x5D0F818
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.Set
	*/

	// RVA: -1 Offset: -1
	public void PushGlobal(CommandBuffer cmd, in CBType data, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D6B4 Offset: 0x5D096B4 VA: 0x5D0D6B4
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.PushGlobal
	|
	|-RVA: 0x5D0DE08 Offset: 0x5D09E08 VA: 0x5D0DE08
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.PushGlobal
	|
	|-RVA: 0x5D0E4D4 Offset: 0x5D0A4D4 VA: 0x5D0E4D4
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.PushGlobal
	|
	|-RVA: 0x5D0EB70 Offset: 0x5D0AB70 VA: 0x5D0EB70
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.PushGlobal
	|
	|-RVA: 0x5D0F1EC Offset: 0x5D0B1EC VA: 0x5D0F1EC
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.PushGlobal
	|
	|-RVA: 0x5D0F868 Offset: 0x5D0B868 VA: 0x5D0F868
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.PushGlobal
	*/

	// RVA: -1 Offset: -1
	public void PushGlobal(in CBType data, int shaderId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D6E4 Offset: 0x5D096E4 VA: 0x5D0D6E4
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.PushGlobal
	|
	|-RVA: 0x5D0DE64 Offset: 0x5D09E64 VA: 0x5D0DE64
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.PushGlobal
	|
	|-RVA: 0x5D0E504 Offset: 0x5D0A504 VA: 0x5D0E504
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.PushGlobal
	|
	|-RVA: 0x5D0EBA0 Offset: 0x5D0ABA0 VA: 0x5D0EBA0
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.PushGlobal
	|
	|-RVA: 0x5D0F21C Offset: 0x5D0B21C VA: 0x5D0F21C
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.PushGlobal
	|
	|-RVA: 0x5D0F898 Offset: 0x5D0B898 VA: 0x5D0F898
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.PushGlobal
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D70C Offset: 0x5D0970C VA: 0x5D0D70C
	|-ConstantBuffer<ShaderVariablesProbeVolumes>.Release
	|
	|-RVA: 0x5D0DEB0 Offset: 0x5D09EB0 VA: 0x5D0DEB0
	|-ConstantBuffer<__Il2CppFullySharedGenericStructType>.Release
	|
	|-RVA: 0x5D0E52C Offset: 0x5D0A52C VA: 0x5D0E52C
	|-ConstantBuffer<Hammersley.Hammersley2dSeq16>.Release
	|
	|-RVA: 0x5D0EBC8 Offset: 0x5D0ABC8 VA: 0x5D0EBC8
	|-ConstantBuffer<Hammersley.Hammersley2dSeq256>.Release
	|
	|-RVA: 0x5D0F244 Offset: 0x5D0B244 VA: 0x5D0F244
	|-ConstantBuffer<Hammersley.Hammersley2dSeq32>.Release
	|
	|-RVA: 0x5D0F8C0 Offset: 0x5D0B8C0 VA: 0x5D0F8C0
	|-ConstantBuffer<Hammersley.Hammersley2dSeq64>.Release
	*/
}

// Namespace: UnityEngine.Rendering
internal class ConstantBufferSingleton<CBType> : ConstantBuffer<CBType> // TypeDefIndex: 19798
{
	// Fields
	private static ConstantBufferSingleton<CBType> s_Instance; // 0x0

	// Properties
	internal static ConstantBufferSingleton<CBType> instance { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal static ConstantBufferSingleton<CBType> get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0BF50 Offset: 0x5D07F50 VA: 0x5D0BF50
	|-ConstantBufferSingleton<ShaderVariablesProbeVolumes>.get_instance
	|
	|-RVA: 0x5D0C1E8 Offset: 0x5D081E8 VA: 0x5D0C1E8
	|-ConstantBufferSingleton<__Il2CppFullySharedGenericStructType>.get_instance
	|
	|-RVA: 0x5D0C86C Offset: 0x5D0886C VA: 0x5D0C86C
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq16>.get_instance
	|
	|-RVA: 0x5D0CAF8 Offset: 0x5D08AF8 VA: 0x5D0CAF8
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq256>.get_instance
	|
	|-RVA: 0x5D0CD84 Offset: 0x5D08D84 VA: 0x5D0CD84
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq32>.get_instance
	|
	|-RVA: 0x5D0D010 Offset: 0x5D09010 VA: 0x5D0D010
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq64>.get_instance
	*/

	// RVA: -1 Offset: -1
	internal static void set_instance(ConstantBufferSingleton<CBType> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0C0F4 Offset: 0x5D080F4 VA: 0x5D0C0F4
	|-ConstantBufferSingleton<ShaderVariablesProbeVolumes>.set_instance
	|
	|-RVA: 0x5D0C3B0 Offset: 0x5D083B0 VA: 0x5D0C3B0
	|-ConstantBufferSingleton<__Il2CppFullySharedGenericStructType>.set_instance
	|
	|-RVA: 0x5D0CA10 Offset: 0x5D08A10 VA: 0x5D0CA10
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq16>.set_instance
	|
	|-RVA: 0x5D0CC9C Offset: 0x5D08C9C VA: 0x5D0CC9C
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq256>.set_instance
	|
	|-RVA: 0x5D0CF28 Offset: 0x5D08F28 VA: 0x5D0CF28
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq32>.set_instance
	|
	|-RVA: 0x5D0D1B4 Offset: 0x5D091B4 VA: 0x5D0D1B4
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq64>.set_instance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0C170 Offset: 0x5D08170 VA: 0x5D0C170
	|-ConstantBufferSingleton<ShaderVariablesProbeVolumes>.Release
	|
	|-RVA: 0x5D0C42C Offset: 0x5D0842C VA: 0x5D0C42C
	|-ConstantBufferSingleton<__Il2CppFullySharedGenericStructType>.Release
	|
	|-RVA: 0x5D0CA8C Offset: 0x5D08A8C VA: 0x5D0CA8C
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq16>.Release
	|
	|-RVA: 0x5D0CD18 Offset: 0x5D08D18 VA: 0x5D0CD18
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq256>.Release
	|
	|-RVA: 0x5D0CFA4 Offset: 0x5D08FA4 VA: 0x5D0CFA4
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq32>.Release
	|
	|-RVA: 0x5D0D230 Offset: 0x5D09230 VA: 0x5D0D230
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq64>.Release
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0C1D8 Offset: 0x5D081D8 VA: 0x5D0C1D8
	|-ConstantBufferSingleton<ShaderVariablesProbeVolumes>..ctor
	|
	|-RVA: 0x5D0C498 Offset: 0x5D08498 VA: 0x5D0C498
	|-ConstantBufferSingleton<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x5D0CAE8 Offset: 0x5D08AE8 VA: 0x5D0CAE8
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq16>..ctor
	|
	|-RVA: 0x5D0CD74 Offset: 0x5D08D74 VA: 0x5D0CD74
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq256>..ctor
	|
	|-RVA: 0x5D0D000 Offset: 0x5D09000 VA: 0x5D0D000
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq32>..ctor
	|
	|-RVA: 0x5D0D28C Offset: 0x5D0928C VA: 0x5D0D28C
	|-ConstantBufferSingleton<Hammersley.Hammersley2dSeq64>..ctor
	*/
}

// Namespace: UnityEngine.Rendering
[Usage(260, AllowMultiple = False)]
public class DisplayInfoAttribute : Attribute // TypeDefIndex: 19799
{
	// Fields
	public string name; // 0x10
	public int order; // 0x18

	// Methods

	// RVA: 0x85AB530 Offset: 0x85A7530 VA: 0x85AB530
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[Usage(256)]
public class AdditionalPropertyAttribute : Attribute // TypeDefIndex: 19800
{
	// Methods

	// RVA: 0x85AB538 Offset: 0x85A7538 VA: 0x85AB538
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
internal enum CoreProfileId // TypeDefIndex: 19801
{
	// Fields
	public int value__; // 0x0
	public const CoreProfileId BlitTextureInPotAtlas = 0;
	public const CoreProfileId APVCellStreamingUpdate = 1;
	public const CoreProfileId APVScenarioBlendingUpdate = 2;
}

// Namespace: 
public struct CoreUnsafeUtils.FixedBufferStringQueue // TypeDefIndex: 19802
{
	// Fields
	private byte* m_ReadCursor; // 0x0
	private byte* m_WriteCursor; // 0x8
	private readonly byte* m_BufferEnd; // 0x10
	private readonly byte* m_BufferStart; // 0x18
	private readonly int m_BufferLength; // 0x20
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x24

	// Properties
	public int Count { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85AC1DC Offset: 0x85A81DC VA: 0x85AC1DC
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x85AC1E4 Offset: 0x85A81E4 VA: 0x85AC1E4
	private void set_Count(int value) { }

	// RVA: 0x85AC1EC Offset: 0x85A81EC VA: 0x85AC1EC
	public void .ctor(byte* ptr, int length) { }

	// RVA: 0x85AC22C Offset: 0x85A822C VA: 0x85AC22C
	public bool TryPush(string v) { }

	// RVA: 0x85AC2DC Offset: 0x85A82DC VA: 0x85AC2DC
	public bool TryPop(out string v) { }

	// RVA: 0x85AC210 Offset: 0x85A8210 VA: 0x85AC210
	public void Clear() { }
}

// Namespace: 
public interface CoreUnsafeUtils.IKeyGetter<TValue, TKey> // TypeDefIndex: 19803
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TKey Get(ref TValue v);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CoreUnsafeUtils.IKeyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/
}

// Namespace: 
internal struct CoreUnsafeUtils.DefaultKeyGetter<T> : CoreUnsafeUtils.IKeyGetter<T, T> // TypeDefIndex: 19804
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T Get(ref T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D20060 Offset: 0x5D1C060 VA: 0x5D20060
	|-CoreUnsafeUtils.DefaultKeyGetter<Hash128>.Get
	|
	|-RVA: 0x5D20068 Offset: 0x5D1C068 VA: 0x5D20068
	|-CoreUnsafeUtils.DefaultKeyGetter<int>.Get
	|
	|-RVA: 0x5D20070 Offset: 0x5D1C070 VA: 0x5D20070
	|-CoreUnsafeUtils.DefaultKeyGetter<__Il2CppFullySharedGenericType>.Get
	*/
}

// Namespace: 
internal struct CoreUnsafeUtils.UintKeyGetter : CoreUnsafeUtils.IKeyGetter<uint, uint> // TypeDefIndex: 19805
{
	// Methods

	// RVA: 0x85AC35C Offset: 0x85A835C VA: 0x85AC35C Slot: 4
	public uint Get(ref uint v) { }
}

// Namespace: UnityEngine.Rendering
[Extension]
public static class CoreUnsafeUtils // TypeDefIndex: 19806
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(List<T> list, void* dest, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45624CC Offset: 0x455E4CC VA: 0x45624CC
	|-CoreUnsafeUtils.CopyTo<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(T[] list, void* dest, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4562458 Offset: 0x455E458 VA: 0x4562458
	|-CoreUnsafeUtils.CopyTo<int>
	|
	|-RVA: 0x45625F4 Offset: 0x455E5F4 VA: 0x45625F4
	|-CoreUnsafeUtils.CopyTo<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x85AB540 Offset: 0x85A7540 VA: 0x85AB540
	private static void CalculateRadixParams(int radixBits, out int bitStates) { }

	// RVA: 0x85AB5B4 Offset: 0x85A75B4 VA: 0x85AB5B4
	private static int CalculateRadixSupportSize(int bitStates, int arrayLength) { }

	// RVA: 0x85AB5C0 Offset: 0x85A75C0 VA: 0x85AB5C0
	private static void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, out uint* bucketIndices, out uint* bucketSizes, out uint* bucketPrefix, out uint* arrayOutput) { }

	// RVA: 0x85AB5E0 Offset: 0x85A75E0 VA: 0x85AB5E0
	private static void MergeSort(uint* array, uint* support, int length) { }

	// RVA: 0x85AB714 Offset: 0x85A7714 VA: 0x85AB714
	public static void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray) { }

	// RVA: 0x85AB82C Offset: 0x85A782C VA: 0x85AB82C
	public static void MergeSort(NativeArray<uint> arr, int sortSize, ref NativeArray<uint> supportArray) { }

	// RVA: 0x85AB950 Offset: 0x85A7950 VA: 0x85AB950
	private static void InsertionSort(uint* arr, int length) { }

	// RVA: 0x85AB9BC Offset: 0x85A79BC VA: 0x85AB9BC
	public static void InsertionSort(uint[] arr, int sortSize) { }

	// RVA: 0x85ABA4C Offset: 0x85A7A4C VA: 0x85ABA4C
	public static void InsertionSort(NativeArray<uint> arr, int sortSize) { }

	// RVA: 0x85ABB0C Offset: 0x85A7B0C VA: 0x85ABB0C
	private static void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length) { }

	// RVA: 0x85ABC84 Offset: 0x85A7C84 VA: 0x85ABC84
	public static void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits = 8) { }

	// RVA: 0x85ABDBC Offset: 0x85A7DBC VA: 0x85ABDBC
	public static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, int radixBits = 8) { }

	// RVA: 0x85ABEFC Offset: 0x85A7EFC VA: 0x85ABEFC
	public static void QuickSort(uint[] arr, int left, int right) { }

	// RVA: -1 Offset: -1
	public static void QuickSort<T>(int count, void* data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4563158 Offset: 0x455F158 VA: 0x4563158
	|-CoreUnsafeUtils.QuickSort<int>
	|
	|-RVA: 0x456319C Offset: 0x455F19C VA: 0x456319C
	|-CoreUnsafeUtils.QuickSort<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void QuickSort<TValue, TKey, TGetter>(int count, void* data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45631E4 Offset: 0x455F1E4 VA: 0x45631E4
	|-CoreUnsafeUtils.QuickSort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456322C Offset: 0x455F22C VA: 0x456322C
	|-CoreUnsafeUtils.QuickSort<int, int, CoreUnsafeUtils.DefaultKeyGetter<int>>
	|
	|-RVA: 0x45632C4 Offset: 0x455F2C4 VA: 0x45632C4
	|-CoreUnsafeUtils.QuickSort<uint, uint, CoreUnsafeUtils.UintKeyGetter>
	|
	|-RVA: 0x456335C Offset: 0x455F35C VA: 0x456335C
	|-CoreUnsafeUtils.QuickSort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(void* data, int count, T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4562730 Offset: 0x455E730 VA: 0x4562730
	|-CoreUnsafeUtils.IndexOf<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45612DC Offset: 0x455D2DC VA: 0x45612DC
	|-CoreUnsafeUtils.CompareHashes<Hash128, CoreUnsafeUtils.DefaultKeyGetter<Hash128>, Hash128, CoreUnsafeUtils.DefaultKeyGetter<Hash128>>
	|
	|-RVA: 0x4561D64 Offset: 0x455DD64 VA: 0x4561D64
	|-CoreUnsafeUtils.CompareHashes<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x85ABF70 Offset: 0x85A7F70 VA: 0x85ABF70
	public static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) { }

	// RVA: -1 Offset: -1
	public static void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456102C Offset: 0x455D02C VA: 0x456102C
	|-CoreUnsafeUtils.CombineHashes<Hash128, CoreUnsafeUtils.DefaultKeyGetter<Hash128>>
	|
	|-RVA: 0x45610CC Offset: 0x455D0CC VA: 0x45610CC
	|-CoreUnsafeUtils.CombineHashes<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x85AC014 Offset: 0x85A8014 VA: 0x85AC014
	public static void CombineHashes(int count, Hash128* hashes, Hash128* outHash) { }

	// RVA: -1 Offset: -1
	private static int Partition<TValue, TKey, TGetter>(void* data, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45628D8 Offset: 0x455E8D8 VA: 0x45628D8
	|-CoreUnsafeUtils.Partition<int, int, CoreUnsafeUtils.DefaultKeyGetter<int>>
	|
	|-RVA: 0x4562A04 Offset: 0x455EA04 VA: 0x4562A04
	|-CoreUnsafeUtils.Partition<uint, uint, CoreUnsafeUtils.UintKeyGetter>
	|
	|-RVA: 0x4562B30 Offset: 0x455EB30 VA: 0x4562B30
	|-CoreUnsafeUtils.Partition<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x85AC074 Offset: 0x85A8074 VA: 0x85AC074
	public static bool HaveDuplicates(int[] arr) { }
}

// Namespace: 
public struct DynamicArray.Iterator<T> // TypeDefIndex: 19807
{
	// Fields
	private readonly DynamicArray<T> owner; // 0x0
	private int index; // 0x0

	// Properties
	public T Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DynamicArray<T> setOwner) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6EBDC Offset: 0x4A6ABDC VA: 0x4A6EBDC
	|-DynamicArray.Iterator<object>..ctor
	|
	|-RVA: 0x4A6EC98 Offset: 0x4A6AC98 VA: 0x4A6EC98
	|-DynamicArray.Iterator<RendererListResource>..ctor
	|
	|-RVA: 0x4A6F08C Offset: 0x4A6B08C VA: 0x4A6F08C
	|-DynamicArray.Iterator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x4A6F410 Offset: 0x4A6B410 VA: 0x4A6F410
	|-DynamicArray.Iterator<RenderGraph.CompiledPassInfo>..ctor
	|
	|-RVA: 0x4A6F4CC Offset: 0x4A6B4CC VA: 0x4A6F4CC
	|-DynamicArray.Iterator<RenderGraph.CompiledResourceInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6EBFC Offset: 0x4A6ABFC VA: 0x4A6EBFC
	|-DynamicArray.Iterator<object>.get_Current
	|
	|-RVA: 0x4A6ECB8 Offset: 0x4A6ACB8 VA: 0x4A6ECB8
	|-DynamicArray.Iterator<RendererListResource>.get_Current
	|
	|-RVA: 0x4A6F0AC Offset: 0x4A6B0AC VA: 0x4A6F0AC
	|-DynamicArray.Iterator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x4A6F430 Offset: 0x4A6B430 VA: 0x4A6F430
	|-DynamicArray.Iterator<RenderGraph.CompiledPassInfo>.get_Current
	|
	|-RVA: 0x4A6F4EC Offset: 0x4A6B4EC VA: 0x4A6F4EC
	|-DynamicArray.Iterator<RenderGraph.CompiledResourceInfo>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6EC44 Offset: 0x4A6AC44 VA: 0x4A6EC44
	|-DynamicArray.Iterator<object>.MoveNext
	|
	|-RVA: 0x4A6ED00 Offset: 0x4A6AD00 VA: 0x4A6ED00
	|-DynamicArray.Iterator<RendererListResource>.MoveNext
	|
	|-RVA: 0x4A6F13C Offset: 0x4A6B13C VA: 0x4A6F13C
	|-DynamicArray.Iterator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x4A6F478 Offset: 0x4A6B478 VA: 0x4A6F478
	|-DynamicArray.Iterator<RenderGraph.CompiledPassInfo>.MoveNext
	|
	|-RVA: 0x4A6F534 Offset: 0x4A6B534 VA: 0x4A6F534
	|-DynamicArray.Iterator<RenderGraph.CompiledResourceInfo>.MoveNext
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6EC8C Offset: 0x4A6AC8C VA: 0x4A6EC8C
	|-DynamicArray.Iterator<object>.Reset
	|
	|-RVA: 0x4A6ED48 Offset: 0x4A6AD48 VA: 0x4A6ED48
	|-DynamicArray.Iterator<RendererListResource>.Reset
	|
	|-RVA: 0x4A6F1CC Offset: 0x4A6B1CC VA: 0x4A6F1CC
	|-DynamicArray.Iterator<__Il2CppFullySharedGenericType>.Reset
	|
	|-RVA: 0x4A6F4C0 Offset: 0x4A6B4C0 VA: 0x4A6F4C0
	|-DynamicArray.Iterator<RenderGraph.CompiledPassInfo>.Reset
	|
	|-RVA: 0x4A6F57C Offset: 0x4A6B57C VA: 0x4A6F57C
	|-DynamicArray.Iterator<RenderGraph.CompiledResourceInfo>.Reset
	*/
}

// Namespace: 
public struct DynamicArray.RangeEnumerable.RangeIterator<T> // TypeDefIndex: 19808
{
	// Fields
	private readonly DynamicArray<T> owner; // 0x0
	private int index; // 0x0
	private int first; // 0x0
	private int last; // 0x0

	// Properties
	public T Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DynamicArray<T> setOwner, int first, int numItems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52FCE14 Offset: 0x52F8E14 VA: 0x52FCE14
	|-DynamicArray.RangeEnumerable.RangeIterator<object>..ctor
	|
	|-RVA: 0x52FCEC4 Offset: 0x52F8EC4 VA: 0x52FCEC4
	|-DynamicArray.RangeEnumerable.RangeIterator<RendererListResource>..ctor
	|
	|-RVA: 0x52FCF74 Offset: 0x52F8F74 VA: 0x52FCF74
	|-DynamicArray.RangeEnumerable.RangeIterator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x52FD06C Offset: 0x52F906C VA: 0x52FD06C
	|-DynamicArray.RangeEnumerable.RangeIterator<RenderGraph.CompiledPassInfo>..ctor
	|
	|-RVA: 0x52FD11C Offset: 0x52F911C VA: 0x52FD11C
	|-DynamicArray.RangeEnumerable.RangeIterator<RenderGraph.CompiledResourceInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52FCE4C Offset: 0x52F8E4C VA: 0x52FCE4C
	|-DynamicArray.RangeEnumerable.RangeIterator<object>.get_Current
	|
	|-RVA: 0x52FCEFC Offset: 0x52F8EFC VA: 0x52FCEFC
	|-DynamicArray.RangeEnumerable.RangeIterator<RendererListResource>.get_Current
	|
	|-RVA: 0x52FCFAC Offset: 0x52F8FAC VA: 0x52FCFAC
	|-DynamicArray.RangeEnumerable.RangeIterator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x52FD0A4 Offset: 0x52F90A4 VA: 0x52FD0A4
	|-DynamicArray.RangeEnumerable.RangeIterator<RenderGraph.CompiledPassInfo>.get_Current
	|
	|-RVA: 0x52FD154 Offset: 0x52F9154 VA: 0x52FD154
	|-DynamicArray.RangeEnumerable.RangeIterator<RenderGraph.CompiledResourceInfo>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52FCE94 Offset: 0x52F8E94 VA: 0x52FCE94
	|-DynamicArray.RangeEnumerable.RangeIterator<object>.MoveNext
	|
	|-RVA: 0x52FCF44 Offset: 0x52F8F44 VA: 0x52FCF44
	|-DynamicArray.RangeEnumerable.RangeIterator<RendererListResource>.MoveNext
	|
	|-RVA: 0x52FD03C Offset: 0x52F903C VA: 0x52FD03C
	|-DynamicArray.RangeEnumerable.RangeIterator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x52FD0EC Offset: 0x52F90EC VA: 0x52FD0EC
	|-DynamicArray.RangeEnumerable.RangeIterator<RenderGraph.CompiledPassInfo>.MoveNext
	|
	|-RVA: 0x52FD19C Offset: 0x52F919C VA: 0x52FD19C
	|-DynamicArray.RangeEnumerable.RangeIterator<RenderGraph.CompiledResourceInfo>.MoveNext
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52FCEB4 Offset: 0x52F8EB4 VA: 0x52FCEB4
	|-DynamicArray.RangeEnumerable.RangeIterator<object>.Reset
	|
	|-RVA: 0x52FCF64 Offset: 0x52F8F64 VA: 0x52FCF64
	|-DynamicArray.RangeEnumerable.RangeIterator<RendererListResource>.Reset
	|
	|-RVA: 0x52FD05C Offset: 0x52F905C VA: 0x52FD05C
	|-DynamicArray.RangeEnumerable.RangeIterator<__Il2CppFullySharedGenericType>.Reset
	|
	|-RVA: 0x52FD10C Offset: 0x52F910C VA: 0x52FD10C
	|-DynamicArray.RangeEnumerable.RangeIterator<RenderGraph.CompiledPassInfo>.Reset
	|
	|-RVA: 0x52FD1BC Offset: 0x52F91BC VA: 0x52FD1BC
	|-DynamicArray.RangeEnumerable.RangeIterator<RenderGraph.CompiledResourceInfo>.Reset
	*/
}

// Namespace: 
public struct DynamicArray.RangeEnumerable<T> // TypeDefIndex: 19809
{
	// Fields
	public DynamicArray.RangeEnumerable.RangeIterator<T> iterator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public DynamicArray.RangeEnumerable.RangeIterator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52FCDB0 Offset: 0x52F8DB0 VA: 0x52FCDB0
	|-DynamicArray.RangeEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x52FCDC4 Offset: 0x52F8DC4 VA: 0x52FCDC4
	|-DynamicArray.RangeEnumerable<RendererListResource>.GetEnumerator
	|
	|-RVA: 0x52FCDD8 Offset: 0x52F8DD8 VA: 0x52FCDD8
	|-DynamicArray.RangeEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x52FCDEC Offset: 0x52F8DEC VA: 0x52FCDEC
	|-DynamicArray.RangeEnumerable<RenderGraph.CompiledPassInfo>.GetEnumerator
	|
	|-RVA: 0x52FCE00 Offset: 0x52F8E00 VA: 0x52FCE00
	|-DynamicArray.RangeEnumerable<RenderGraph.CompiledResourceInfo>.GetEnumerator
	*/
}

// Namespace: UnityEngine.Rendering
[DefaultMember("Item")]
[DebuggerDisplay("Size = {size} Capacity = {capacity}")]
public class DynamicArray<T> // TypeDefIndex: 19810
{
	// Fields
	private T[] m_Array; // 0x0
	[CompilerGenerated]
	private int <size>k__BackingField; // 0x0

	// Properties
	public int size { get; set; }
	public int capacity { get; }
	public T Item { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_size() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029178 Offset: 0x6025178 VA: 0x6029178
	|-DynamicArray<object>.get_size
	|
	|-RVA: 0x602991C Offset: 0x602591C VA: 0x602991C
	|-DynamicArray<RendererListResource>.get_size
	|
	|-RVA: 0x602A398 Offset: 0x6026398 VA: 0x602A398
	|-DynamicArray<__Il2CppFullySharedGenericType>.get_size
	|
	|-RVA: 0x602B4EC Offset: 0x60274EC VA: 0x602B4EC
	|-DynamicArray<RenderGraph.CompiledPassInfo>.get_size
	|
	|-RVA: 0x602BF58 Offset: 0x6027F58 VA: 0x602BF58
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.get_size
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_size(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029180 Offset: 0x6025180 VA: 0x6029180
	|-DynamicArray<object>.set_size
	|
	|-RVA: 0x6029924 Offset: 0x6025924 VA: 0x6029924
	|-DynamicArray<RendererListResource>.set_size
	|
	|-RVA: 0x602A3A0 Offset: 0x60263A0 VA: 0x602A3A0
	|-DynamicArray<__Il2CppFullySharedGenericType>.set_size
	|
	|-RVA: 0x602B4F4 Offset: 0x60274F4 VA: 0x602B4F4
	|-DynamicArray<RenderGraph.CompiledPassInfo>.set_size
	|
	|-RVA: 0x602BF60 Offset: 0x6027F60 VA: 0x602BF60
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.set_size
	*/

	// RVA: -1 Offset: -1
	public int get_capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029188 Offset: 0x6025188 VA: 0x6029188
	|-DynamicArray<object>.get_capacity
	|
	|-RVA: 0x602992C Offset: 0x602592C VA: 0x602992C
	|-DynamicArray<RendererListResource>.get_capacity
	|
	|-RVA: 0x602A3A8 Offset: 0x60263A8 VA: 0x602A3A8
	|-DynamicArray<__Il2CppFullySharedGenericType>.get_capacity
	|
	|-RVA: 0x602B4FC Offset: 0x60274FC VA: 0x602B4FC
	|-DynamicArray<RenderGraph.CompiledPassInfo>.get_capacity
	|
	|-RVA: 0x602BF68 Offset: 0x6027F68 VA: 0x602BF68
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.get_capacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60291A4 Offset: 0x60251A4 VA: 0x60291A4
	|-DynamicArray<object>..ctor
	|
	|-RVA: 0x6029948 Offset: 0x6025948 VA: 0x6029948
	|-DynamicArray<RendererListResource>..ctor
	|
	|-RVA: 0x602A3C4 Offset: 0x60263C4 VA: 0x602A3C4
	|-DynamicArray<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x602B518 Offset: 0x6027518 VA: 0x602B518
	|-DynamicArray<RenderGraph.CompiledPassInfo>..ctor
	|
	|-RVA: 0x602BF84 Offset: 0x6027F84 VA: 0x602BF84
	|-DynamicArray<RenderGraph.CompiledResourceInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60291FC Offset: 0x60251FC VA: 0x60291FC
	|-DynamicArray<object>..ctor
	|
	|-RVA: 0x60299A0 Offset: 0x60259A0 VA: 0x60299A0
	|-DynamicArray<RendererListResource>..ctor
	|
	|-RVA: 0x602A430 Offset: 0x6026430 VA: 0x602A430
	|-DynamicArray<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x602B570 Offset: 0x6027570 VA: 0x602B570
	|-DynamicArray<RenderGraph.CompiledPassInfo>..ctor
	|
	|-RVA: 0x602BFDC Offset: 0x6027FDC VA: 0x602BFDC
	|-DynamicArray<RenderGraph.CompiledResourceInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029258 Offset: 0x6025258 VA: 0x6029258
	|-DynamicArray<object>.Clear
	|
	|-RVA: 0x60299FC Offset: 0x60259FC VA: 0x60299FC
	|-DynamicArray<RendererListResource>.Clear
	|
	|-RVA: 0x602A4A0 Offset: 0x60264A0 VA: 0x602A4A0
	|-DynamicArray<__Il2CppFullySharedGenericType>.Clear
	|
	|-RVA: 0x602B5CC Offset: 0x60275CC VA: 0x602B5CC
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Clear
	|
	|-RVA: 0x602C038 Offset: 0x6028038 VA: 0x602C038
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029260 Offset: 0x6025260 VA: 0x6029260
	|-DynamicArray<object>.Contains
	|
	|-RVA: 0x6029A04 Offset: 0x6025A04 VA: 0x6029A04
	|-DynamicArray<RendererListResource>.Contains
	|
	|-RVA: 0x602A4B8 Offset: 0x60264B8 VA: 0x602A4B8
	|-DynamicArray<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x602B5D4 Offset: 0x60275D4 VA: 0x602B5D4
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Contains
	|
	|-RVA: 0x602C040 Offset: 0x6028040 VA: 0x602C040
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Contains
	*/

	// RVA: -1 Offset: -1
	public int Add(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029294 Offset: 0x6025294 VA: 0x6029294
	|-DynamicArray<object>.Add
	|
	|-RVA: 0x6029A78 Offset: 0x6025A78 VA: 0x6029A78
	|-DynamicArray<RendererListResource>.Add
	|
	|-RVA: 0x602A580 Offset: 0x6026580 VA: 0x602A580
	|-DynamicArray<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0x602B648 Offset: 0x6027648 VA: 0x602B648
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Add
	|
	|-RVA: 0x602C098 Offset: 0x6028098 VA: 0x602C098
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(DynamicArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029364 Offset: 0x6025364 VA: 0x6029364
	|-DynamicArray<object>.AddRange
	|
	|-RVA: 0x6029BA8 Offset: 0x6025BA8 VA: 0x6029BA8
	|-DynamicArray<RendererListResource>.AddRange
	|
	|-RVA: 0x602A780 Offset: 0x6026780 VA: 0x602A780
	|-DynamicArray<__Il2CppFullySharedGenericType>.AddRange
	|
	|-RVA: 0x602B774 Offset: 0x6027774 VA: 0x602B774
	|-DynamicArray<RenderGraph.CompiledPassInfo>.AddRange
	|
	|-RVA: 0x602C1C0 Offset: 0x60281C0 VA: 0x602C1C0
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.AddRange
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029410 Offset: 0x6025410 VA: 0x6029410
	|-DynamicArray<object>.Remove
	|
	|-RVA: 0x6029C98 Offset: 0x6025C98 VA: 0x6029C98
	|-DynamicArray<RendererListResource>.Remove
	|
	|-RVA: 0x602A9A0 Offset: 0x60269A0 VA: 0x602A9A0
	|-DynamicArray<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x602B868 Offset: 0x6027868 VA: 0x602B868
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Remove
	|
	|-RVA: 0x602C2B4 Offset: 0x60282B4 VA: 0x602C2B4
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029478 Offset: 0x6025478 VA: 0x6029478
	|-DynamicArray<object>.RemoveAt
	|
	|-RVA: 0x6029D38 Offset: 0x6025D38 VA: 0x6029D38
	|-DynamicArray<RendererListResource>.RemoveAt
	|
	|-RVA: 0x602AA98 Offset: 0x6026A98 VA: 0x602AA98
	|-DynamicArray<__Il2CppFullySharedGenericType>.RemoveAt
	|
	|-RVA: 0x602B900 Offset: 0x6027900 VA: 0x602B900
	|-DynamicArray<RenderGraph.CompiledPassInfo>.RemoveAt
	|
	|-RVA: 0x602C340 Offset: 0x6028340 VA: 0x602C340
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029504 Offset: 0x6025504 VA: 0x6029504
	|-DynamicArray<object>.RemoveRange
	|
	|-RVA: 0x6029DC4 Offset: 0x6025DC4 VA: 0x6029DC4
	|-DynamicArray<RendererListResource>.RemoveRange
	|
	|-RVA: 0x602ABB0 Offset: 0x6026BB0 VA: 0x602ABB0
	|-DynamicArray<__Il2CppFullySharedGenericType>.RemoveRange
	|
	|-RVA: 0x602B98C Offset: 0x602798C VA: 0x602B98C
	|-DynamicArray<RenderGraph.CompiledPassInfo>.RemoveRange
	|
	|-RVA: 0x602C3CC Offset: 0x60283CC VA: 0x602C3CC
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.RemoveRange
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029594 Offset: 0x6025594 VA: 0x6029594
	|-DynamicArray<object>.FindIndex
	|
	|-RVA: 0x6029E54 Offset: 0x6025E54 VA: 0x6029E54
	|-DynamicArray<RendererListResource>.FindIndex
	|
	|-RVA: 0x602ACEC Offset: 0x6026CEC VA: 0x602ACEC
	|-DynamicArray<__Il2CppFullySharedGenericType>.FindIndex
	|
	|-RVA: 0x602BA1C Offset: 0x6027A1C VA: 0x602BA1C
	|-DynamicArray<RenderGraph.CompiledPassInfo>.FindIndex
	|
	|-RVA: 0x602C45C Offset: 0x602845C VA: 0x602C45C
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029614 Offset: 0x6025614 VA: 0x6029614
	|-DynamicArray<object>.IndexOf
	|
	|-RVA: 0x6029F1C Offset: 0x6025F1C VA: 0x6029F1C
	|-DynamicArray<RendererListResource>.IndexOf
	|
	|-RVA: 0x602AE40 Offset: 0x6026E40 VA: 0x602AE40
	|-DynamicArray<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x602BAE4 Offset: 0x6027AE4 VA: 0x602BAE4
	|-DynamicArray<RenderGraph.CompiledPassInfo>.IndexOf
	|
	|-RVA: 0x602C51C Offset: 0x602851C VA: 0x602C51C
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60296BC Offset: 0x60256BC VA: 0x60296BC
	|-DynamicArray<object>.IndexOf
	|
	|-RVA: 0x602A060 Offset: 0x6026060 VA: 0x602A060
	|-DynamicArray<RendererListResource>.IndexOf
	|
	|-RVA: 0x602B044 Offset: 0x6027044 VA: 0x602B044
	|-DynamicArray<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x602BC28 Offset: 0x6027C28 VA: 0x602BC28
	|-DynamicArray<RenderGraph.CompiledPassInfo>.IndexOf
	|
	|-RVA: 0x602C664 Offset: 0x6028664 VA: 0x602C664
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602974C Offset: 0x602574C VA: 0x602974C
	|-DynamicArray<object>.IndexOf
	|
	|-RVA: 0x602A178 Offset: 0x6026178 VA: 0x602A178
	|-DynamicArray<RendererListResource>.IndexOf
	|
	|-RVA: 0x602B220 Offset: 0x6027220 VA: 0x602B220
	|-DynamicArray<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x602BD38 Offset: 0x6027D38 VA: 0x602BD38
	|-DynamicArray<RenderGraph.CompiledPassInfo>.IndexOf
	|
	|-RVA: 0x602C778 Offset: 0x6028778 VA: 0x602C778
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void Resize(int newSize, bool keepContent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029760 Offset: 0x6025760 VA: 0x6029760
	|-DynamicArray<object>.Resize
	|
	|-RVA: 0x602A1D8 Offset: 0x60261D8 VA: 0x602A1D8
	|-DynamicArray<RendererListResource>.Resize
	|
	|-RVA: 0x602B2EC Offset: 0x60272EC VA: 0x602B2EC
	|-DynamicArray<__Il2CppFullySharedGenericType>.Resize
	|
	|-RVA: 0x602BD98 Offset: 0x6027D98 VA: 0x602BD98
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Resize
	|
	|-RVA: 0x602C7BC Offset: 0x60287BC VA: 0x602C7BC
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Resize
	*/

	// RVA: -1 Offset: -1
	public void Reserve(int newCapacity, bool keepContent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029794 Offset: 0x6025794 VA: 0x6029794
	|-DynamicArray<object>.Reserve
	|
	|-RVA: 0x602A20C Offset: 0x602620C VA: 0x602A20C
	|-DynamicArray<RendererListResource>.Reserve
	|
	|-RVA: 0x602B354 Offset: 0x6027354 VA: 0x602B354
	|-DynamicArray<__Il2CppFullySharedGenericType>.Reserve
	|
	|-RVA: 0x602BDCC Offset: 0x6027DCC VA: 0x602BDCC
	|-DynamicArray<RenderGraph.CompiledPassInfo>.Reserve
	|
	|-RVA: 0x602C7F0 Offset: 0x60287F0 VA: 0x602C7F0
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.Reserve
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029824 Offset: 0x6025824 VA: 0x6029824
	|-DynamicArray<object>.get_Item
	|
	|-RVA: 0x602A29C Offset: 0x602629C VA: 0x602A29C
	|-DynamicArray<RendererListResource>.get_Item
	|
	|-RVA: 0x602B3E4 Offset: 0x60273E4 VA: 0x602B3E4
	|-DynamicArray<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x602BE5C Offset: 0x6027E5C VA: 0x602BE5C
	|-DynamicArray<RenderGraph.CompiledPassInfo>.get_Item
	|
	|-RVA: 0x602C880 Offset: 0x6028880 VA: 0x602C880
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.get_Item
	*/

	// RVA: -1 Offset: -1
	public static T[] op_Implicit(DynamicArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029854 Offset: 0x6025854 VA: 0x6029854
	|-DynamicArray<object>.op_Implicit
	|
	|-RVA: 0x602A2D0 Offset: 0x60262D0 VA: 0x602A2D0
	|-DynamicArray<RendererListResource>.op_Implicit
	|
	|-RVA: 0x602B424 Offset: 0x6027424 VA: 0x602B424
	|-DynamicArray<__Il2CppFullySharedGenericType>.op_Implicit
	|
	|-RVA: 0x602BE90 Offset: 0x6027E90 VA: 0x602BE90
	|-DynamicArray<RenderGraph.CompiledPassInfo>.op_Implicit
	|
	|-RVA: 0x602C8B4 Offset: 0x60288B4 VA: 0x602C8B4
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public DynamicArray.Iterator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602986C Offset: 0x602586C VA: 0x602986C
	|-DynamicArray<object>.GetEnumerator
	|
	|-RVA: 0x602A2E8 Offset: 0x60262E8 VA: 0x602A2E8
	|-DynamicArray<RendererListResource>.GetEnumerator
	|
	|-RVA: 0x602B43C Offset: 0x602743C VA: 0x602B43C
	|-DynamicArray<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x602BEA8 Offset: 0x6027EA8 VA: 0x602BEA8
	|-DynamicArray<RenderGraph.CompiledPassInfo>.GetEnumerator
	|
	|-RVA: 0x602C8CC Offset: 0x60288CC VA: 0x602C8CC
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public DynamicArray.RangeEnumerable<T> SubRange(int first, int numItems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60298A0 Offset: 0x60258A0 VA: 0x60298A0
	|-DynamicArray<object>.SubRange
	|
	|-RVA: 0x602A31C Offset: 0x602631C VA: 0x602A31C
	|-DynamicArray<RendererListResource>.SubRange
	|
	|-RVA: 0x602B470 Offset: 0x6027470 VA: 0x602B470
	|-DynamicArray<__Il2CppFullySharedGenericType>.SubRange
	|
	|-RVA: 0x602BEDC Offset: 0x6027EDC VA: 0x602BEDC
	|-DynamicArray<RenderGraph.CompiledPassInfo>.SubRange
	|
	|-RVA: 0x602C900 Offset: 0x6028900 VA: 0x602C900
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.SubRange
	*/

	// RVA: -1 Offset: -1
	internal void BumpVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6029918 Offset: 0x6025918 VA: 0x6029918
	|-DynamicArray<object>.BumpVersion
	|
	|-RVA: 0x602A394 Offset: 0x6026394 VA: 0x602A394
	|-DynamicArray<RendererListResource>.BumpVersion
	|
	|-RVA: 0x602B4E8 Offset: 0x60274E8 VA: 0x602B4E8
	|-DynamicArray<__Il2CppFullySharedGenericType>.BumpVersion
	|
	|-RVA: 0x602BF54 Offset: 0x6027F54 VA: 0x602BF54
	|-DynamicArray<RenderGraph.CompiledPassInfo>.BumpVersion
	|
	|-RVA: 0x602C978 Offset: 0x6028978 VA: 0x602C978
	|-DynamicArray<RenderGraph.CompiledResourceInfo>.BumpVersion
	*/
}

// Namespace: UnityEngine.Rendering
[Extension]
public static class DynamicArrayExtensions // TypeDefIndex: 19811
{
	// Methods

	// RVA: -1 Offset: -1
	private static int Partition<T>(T[] data, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457580C Offset: 0x457180C VA: 0x457580C
	|-DynamicArrayExtensions.Partition<object>
	|
	|-RVA: 0x45759F4 Offset: 0x45719F4 VA: 0x45759F4
	|-DynamicArrayExtensions.Partition<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void QuickSort<T>(T[] data, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4575F3C Offset: 0x4571F3C VA: 0x4575F3C
	|-DynamicArrayExtensions.QuickSort<object>
	|
	|-RVA: 0x4575FD4 Offset: 0x4571FD4 VA: 0x4575FD4
	|-DynamicArrayExtensions.QuickSort<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void QuickSort<T>(DynamicArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4575E54 Offset: 0x4571E54 VA: 0x4575E54
	|-DynamicArrayExtensions.QuickSort<object>
	|
	|-RVA: 0x4575EB0 Offset: 0x4571EB0 VA: 0x4575EB0
	|-DynamicArrayExtensions.QuickSort<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.Rendering
public sealed class PerformDynamicRes : MulticastDelegate // TypeDefIndex: 19812
{
	// Methods

	// RVA: 0x85AC364 Offset: 0x85A8364 VA: 0x85AC364
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x85AC400 Offset: 0x85A8400 VA: 0x85AC400 Slot: 13
	public virtual float Invoke() { }

	// RVA: 0x85AC414 Offset: 0x85A8414 VA: 0x85AC414 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x85AC434 Offset: 0x85A8434 VA: 0x85AC434 Slot: 15
	public virtual float EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.Rendering
public enum DynamicResScalePolicyType // TypeDefIndex: 19813
{
	// Fields
	public int value__; // 0x0
	public const DynamicResScalePolicyType ReturnsPercentage = 0;
	public const DynamicResScalePolicyType ReturnsMinMaxLerpFactor = 1;
}

// Namespace: UnityEngine.Rendering
public enum DynamicResScalerSlot // TypeDefIndex: 19814
{
	// Fields
	public int value__; // 0x0
	public const DynamicResScalerSlot User = 0;
	public const DynamicResScalerSlot System = 1;
	public const DynamicResScalerSlot Count = 2;
}

// Namespace: 
private struct DynamicResolutionHandler.ScalerContainer // TypeDefIndex: 19815
{
	// Fields
	public DynamicResScalePolicyType type; // 0x0
	public PerformDynamicRes method; // 0x8
}

// Namespace: 
public enum DynamicResolutionHandler.UpsamplerScheduleType // TypeDefIndex: 19816
{
	// Fields
	public int value__; // 0x0
	public const DynamicResolutionHandler.UpsamplerScheduleType BeforePost = 0;
	public const DynamicResolutionHandler.UpsamplerScheduleType AfterDepthOfField = 1;
	public const DynamicResolutionHandler.UpsamplerScheduleType AfterPost = 2;
}

// Namespace: UnityEngine.Rendering
public class DynamicResolutionHandler // TypeDefIndex: 19817
{
	// Fields
	private bool m_Enabled; // 0x10
	private bool m_UseMipBias; // 0x11
	private float m_MinScreenFraction; // 0x14
	private float m_MaxScreenFraction; // 0x18
	private float m_CurrentFraction; // 0x1C
	private bool m_ForcingRes; // 0x20
	private bool m_CurrentCameraRequest; // 0x21
	private float m_PrevFraction; // 0x24
	private bool m_ForceSoftwareFallback; // 0x28
	private bool m_RunUpscalerFilterOnFullResolution; // 0x29
	private float m_PrevHWScaleWidth; // 0x2C
	private float m_PrevHWScaleHeight; // 0x30
	private Vector2Int m_LastScaledSize; // 0x34
	private static DynamicResScalerSlot s_ActiveScalerSlot; // 0x0
	private static DynamicResolutionHandler.ScalerContainer[] s_ScalerContainers; // 0x8
	private Vector2Int cachedOriginalSize; // 0x3C
	[CompilerGenerated]
	private DynamicResUpscaleFilter <filter>k__BackingField; // 0x44
	private static Dictionary<int, DynamicResUpscaleFilter> s_CameraUpscaleFilters; // 0x10
	[CompilerGenerated]
	private Vector2Int <finalViewport>k__BackingField; // 0x48
	private DynamicResolutionType type; // 0x50
	private GlobalDynamicResolutionSettings m_CachedSettings; // 0x54
	private const int CameraDictionaryMaxcCapacity = 32;
	private WeakReference m_OwnerCameraWeakRef; // 0x90
	private static Dictionary<int, DynamicResolutionHandler> s_CameraInstances; // 0x18
	private static DynamicResolutionHandler s_DefaultInstance; // 0x20
	private static int s_ActiveCameraId; // 0x28
	private static DynamicResolutionHandler s_ActiveInstance; // 0x30
	private static bool s_ActiveInstanceDirty; // 0x38
	private static float s_GlobalHwFraction; // 0x3C
	private static bool s_GlobalHwUpresActive; // 0x40
	private DynamicResolutionHandler.UpsamplerScheduleType m_UpsamplerSchedule; // 0x98

	// Properties
	public DynamicResUpscaleFilter filter { get; set; }
	public Vector2Int finalViewport { get; set; }
	public bool runUpscalerFilterOnFullResolution { get; set; }
	public DynamicResolutionHandler.UpsamplerScheduleType upsamplerSchedule { get; set; }
	public static DynamicResolutionHandler instance { get; }

	// Methods

	// RVA: 0x85AC45C Offset: 0x85A845C VA: 0x85AC45C
	private void Reset() { }

	[CompilerGenerated]
	// RVA: 0x85AC498 Offset: 0x85A8498 VA: 0x85AC498
	public DynamicResUpscaleFilter get_filter() { }

	[CompilerGenerated]
	// RVA: 0x85AC4A0 Offset: 0x85A84A0 VA: 0x85AC4A0
	private void set_filter(DynamicResUpscaleFilter value) { }

	[CompilerGenerated]
	// RVA: 0x85AC4A8 Offset: 0x85A84A8 VA: 0x85AC4A8
	public Vector2Int get_finalViewport() { }

	[CompilerGenerated]
	// RVA: 0x85AC4B0 Offset: 0x85A84B0 VA: 0x85AC4B0
	public void set_finalViewport(Vector2Int value) { }

	// RVA: 0x85AC4B8 Offset: 0x85A84B8 VA: 0x85AC4B8
	public void set_runUpscalerFilterOnFullResolution(bool value) { }

	// RVA: 0x85AC4C4 Offset: 0x85A84C4 VA: 0x85AC4C4
	public bool get_runUpscalerFilterOnFullResolution() { }

	// RVA: 0x85AC4E4 Offset: 0x85A84E4 VA: 0x85AC4E4
	private bool FlushScalableBufferManagerState() { }

	// RVA: 0x85AC650 Offset: 0x85A8650 VA: 0x85AC650
	private static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera) { }

	// RVA: 0x85ACB38 Offset: 0x85A8B38 VA: 0x85ACB38
	public void set_upsamplerSchedule(DynamicResolutionHandler.UpsamplerScheduleType value) { }

	// RVA: 0x85ACB40 Offset: 0x85A8B40 VA: 0x85ACB40
	public DynamicResolutionHandler.UpsamplerScheduleType get_upsamplerSchedule() { }

	// RVA: 0x85ACB48 Offset: 0x85A8B48 VA: 0x85ACB48
	public static DynamicResolutionHandler get_instance() { }

	// RVA: 0x85ACA84 Offset: 0x85A8A84 VA: 0x85ACA84
	private void .ctor() { }

	// RVA: 0x85ACBFC Offset: 0x85A8BFC VA: 0x85ACBFC
	private static float DefaultDynamicResMethod() { }

	// RVA: 0x85ACC04 Offset: 0x85A8C04 VA: 0x85ACC04
	private void ProcessSettings(GlobalDynamicResolutionSettings settings) { }

	// RVA: 0x85ACDC0 Offset: 0x85A8DC0 VA: 0x85ACDC0
	public Vector2 GetResolvedScale() { }

	// RVA: 0x85ACE34 Offset: 0x85A8E34 VA: 0x85ACE34
	public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = False) { }

	// RVA: 0x85ACEC4 Offset: 0x85A8EC4 VA: 0x85ACEC4
	public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	// RVA: 0x85ACF78 Offset: 0x85A8F78 VA: 0x85ACF78
	public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	// RVA: 0x85AD030 Offset: 0x85A9030 VA: 0x85AD030
	public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot) { }

	// RVA: 0x85AD08C Offset: 0x85A908C VA: 0x85AD08C
	public static void ClearSelectedCamera() { }

	// RVA: 0x85AD100 Offset: 0x85A9100 VA: 0x85AD100
	public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter) { }

	// RVA: 0x85AD224 Offset: 0x85A9224 VA: 0x85AD224
	public void SetCurrentCameraRequest(bool cameraRequest) { }

	// RVA: 0x85AD230 Offset: 0x85A9230 VA: 0x85AD230
	public static void UpdateAndUseCamera(Camera camera, Nullable<GlobalDynamicResolutionSettings> settings, Action OnResolutionChange) { }

	// RVA: 0x85AD43C Offset: 0x85A943C VA: 0x85AD43C
	public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange) { }

	// RVA: 0x85AD6C0 Offset: 0x85A96C0 VA: 0x85AD6C0
	public bool SoftwareDynamicResIsEnabled() { }

	// RVA: 0x85AC620 Offset: 0x85A8620 VA: 0x85AC620
	public bool HardwareDynamicResIsEnabled() { }

	// RVA: 0x85AD71C Offset: 0x85A971C VA: 0x85AD71C
	public bool RequestsHardwareDynamicResolution() { }

	// RVA: 0x85AD73C Offset: 0x85A973C VA: 0x85AD73C
	public bool DynamicResolutionEnabled() { }

	// RVA: 0x85AD784 Offset: 0x85A9784 VA: 0x85AD784
	public void ForceSoftwareFallback() { }

	// RVA: 0x85AD790 Offset: 0x85A9790 VA: 0x85AD790
	public Vector2Int GetScaledSize(Vector2Int size) { }

	// RVA: 0x85AD7E0 Offset: 0x85A97E0 VA: 0x85AD7E0
	public Vector2Int ApplyScalesOnSize(Vector2Int size) { }

	// RVA: 0x85AD808 Offset: 0x85A9808 VA: 0x85AD808
	internal Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales) { }

	// RVA: 0x85AD990 Offset: 0x85A9990 VA: 0x85AD990
	public float GetCurrentScale() { }

	// RVA: 0x85AD9AC Offset: 0x85A99AC VA: 0x85AD9AC
	public Vector2Int GetLastScaledSize() { }

	// RVA: 0x85AD9B4 Offset: 0x85A99B4 VA: 0x85AD9B4
	public float GetLowResMultiplier(float targetLowRes) { }

	// RVA: 0x85AD9BC Offset: 0x85A99BC VA: 0x85AD9BC
	public float GetLowResMultiplier(float targetLowRes, float minimumThreshold) { }

	// RVA: 0x85ADA68 Offset: 0x85A9A68 VA: 0x85ADA68
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public enum DynamicResolutionType // TypeDefIndex: 19818
{
	// Fields
	public byte value__; // 0x0
	public const DynamicResolutionType Software = 0;
	public const DynamicResolutionType Hardware = 1;
}

// Namespace: UnityEngine.Rendering
public enum DynamicResUpscaleFilter // TypeDefIndex: 19819
{
	// Fields
	public byte value__; // 0x0
	[Obsolete("Bilinear upscale filter is considered obsolete and is not supported anymore, please use CatmullRom for a very cheap, but blurry filter.", False)]
	public const DynamicResUpscaleFilter Bilinear = 0;
	public const DynamicResUpscaleFilter CatmullRom = 1;
	[Obsolete("Lanczos upscale filter is considered obsolete and is not supported anymore, please use Contrast Adaptive Sharpening for very sharp filter or FidelityFX Super Resolution 1.0.", False)]
	public const DynamicResUpscaleFilter Lanczos = 2;
	public const DynamicResUpscaleFilter ContrastAdaptiveSharpen = 3;
	[InspectorName("FidelityFX Super Resolution 1.0")]
	public const DynamicResUpscaleFilter EdgeAdaptiveScalingUpres = 4;
	[InspectorName("TAA Upscale")]
	public const DynamicResUpscaleFilter TAAU = 5;
}

// Namespace: UnityEngine.Rendering
[Serializable]
public struct GlobalDynamicResolutionSettings // TypeDefIndex: 19820
{
	// Fields
	public bool enabled; // 0x0
	public bool useMipBias; // 0x1
	public bool enableDLSS; // 0x2
	public uint DLSSPerfQualitySetting; // 0x4
	public DynamicResolutionHandler.UpsamplerScheduleType DLSSInjectionPoint; // 0x8
	public bool DLSSUseOptimalSettings; // 0xC
	[Range(0, 1)]
	public float DLSSSharpness; // 0x10
	public bool fsrOverrideSharpness; // 0x14
	[Range(0, 1)]
	public float fsrSharpness; // 0x18
	public float maxPercentage; // 0x1C
	public float minPercentage; // 0x20
	public DynamicResolutionType dynResType; // 0x24
	public DynamicResUpscaleFilter upsampleFilter; // 0x25
	public bool forceResolution; // 0x26
	public float forcedPercentage; // 0x28
	public float lowResTransparencyMinimumThreshold; // 0x2C
	public float rayTracingHalfResThreshold; // 0x30
	public float lowResSSGIMinimumThreshold; // 0x34
	public float lowResVolumetricCloudsMinimumThreshold; // 0x38

	// Methods

	// RVA: 0x85ACBA0 Offset: 0x85A8BA0 VA: 0x85ACBA0
	public static GlobalDynamicResolutionSettings NewDefault() { }
}

// Namespace: UnityEngine.Rendering
public interface IAdditionalData // TypeDefIndex: 19821
{}

// Namespace: UnityEngine.Rendering
public interface IVirtualTexturingEnabledRenderPipeline // TypeDefIndex: 19822
{
	// Properties
	public abstract bool virtualTexturingEnabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_virtualTexturingEnabled();
}

// Namespace: UnityEngine.Rendering
[DefaultMember("Item")]
public struct ListBuffer<T> // TypeDefIndex: 19823
{
	// Fields
	private T* m_BufferPtr; // 0x0
	private int m_Capacity; // 0x0
	private int* m_CountPtr; // 0x0

	// Properties
	internal T* BufferPtr { get; }
	public int Count { get; }
	public int Capacity { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal T* get_BufferPtr() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B640D0 Offset: 0x4B600D0 VA: 0x4B640D0
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.get_BufferPtr
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B640D8 Offset: 0x4B600D8 VA: 0x4B640D8
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B640E4 Offset: 0x4B600E4 VA: 0x4B640E4
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T* bufferPtr, int* countPtr, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B640EC Offset: 0x4B600EC VA: 0x4B640EC
	|-ListBuffer<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(in int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B640FC Offset: 0x4B600FC VA: 0x4B640FC
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public ref T GetUnchecked(in int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6427C Offset: 0x4B6027C VA: 0x4B6427C
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.GetUnchecked
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B642CC Offset: 0x4B602CC VA: 0x4B642CC
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T* dstBuffer, int startDstIndex, int copyCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B644B0 Offset: 0x4B604B0 VA: 0x4B644B0
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(ListBuffer<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B64584 Offset: 0x4B60584 VA: 0x4B64584
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.TryCopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyFrom(T* srcPtr, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B64854 Offset: 0x4B60854 VA: 0x4B64854
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.TryCopyFrom
	*/
}

// Namespace: UnityEngine.Rendering
[Extension]
public static class ListBufferExtensions // TypeDefIndex: 19824
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void QuickSort<T>(ListBuffer<T> self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4668A20 Offset: 0x4664A20 VA: 0x4668A20
	|-ListBufferExtensions.QuickSort<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: 
public struct ObjectPool.PooledObject<T> : IDisposable // TypeDefIndex: 19825
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly ObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T value, ObjectPool<T> pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526B0DC Offset: 0x52670DC VA: 0x526B0DC
	|-ObjectPool.PooledObject<object>..ctor
	|
	|-RVA: 0x526B154 Offset: 0x5267154 VA: 0x526B154
	|-ObjectPool.PooledObject<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526B10C Offset: 0x526710C VA: 0x526B10C
	|-ObjectPool.PooledObject<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x526B2A4 Offset: 0x52672A4 VA: 0x526B2A4
	|-ObjectPool.PooledObject<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/
}

// Namespace: UnityEngine.Rendering
public class ObjectPool<T> // TypeDefIndex: 19826
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	private readonly bool m_CollectionCheck; // 0x0
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
	|-RVA: 0x51FF16C Offset: 0x51FB16C VA: 0x51FF16C
	|-ObjectPool<object>.get_countAll
	|
	|-RVA: 0x51FF3C0 Offset: 0x51FB3C0 VA: 0x51FF3C0
	|-ObjectPool<__Il2CppFullySharedGenericType>.get_countAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FF174 Offset: 0x51FB174 VA: 0x51FF174
	|-ObjectPool<object>.set_countAll
	|
	|-RVA: 0x51FF3C8 Offset: 0x51FB3C8 VA: 0x51FF3C8
	|-ObjectPool<__Il2CppFullySharedGenericType>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FF17C Offset: 0x51FB17C VA: 0x51FF17C
	|-ObjectPool<object>.get_countActive
	|
	|-RVA: 0x51FF3D0 Offset: 0x51FB3D0 VA: 0x51FF3D0
	|-ObjectPool<__Il2CppFullySharedGenericType>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FF1A0 Offset: 0x51FB1A0 VA: 0x51FF1A0
	|-ObjectPool<object>.get_countInactive
	|
	|-RVA: 0x51FF420 Offset: 0x51FB420 VA: 0x51FF420
	|-ObjectPool<__Il2CppFullySharedGenericType>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FF1BC Offset: 0x51FB1BC VA: 0x51FF1BC
	|-ObjectPool<object>..ctor
	|
	|-RVA: 0x51FF448 Offset: 0x51FB448 VA: 0x51FF448
	|-ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FF274 Offset: 0x51FB274 VA: 0x51FF274
	|-ObjectPool<object>.Get
	|
	|-RVA: 0x51FF504 Offset: 0x51FB504 VA: 0x51FF504
	|-ObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public ObjectPool.PooledObject<T> Get(out T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FF2F0 Offset: 0x51FB2F0 VA: 0x51FF2F0
	|-ObjectPool<object>.Get
	|
	|-RVA: 0x51FF6E0 Offset: 0x51FB6E0 VA: 0x51FF6E0
	|-ObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FF368 Offset: 0x51FB368 VA: 0x51FF368
	|-ObjectPool<object>.Release
	|
	|-RVA: 0x51FF8CC Offset: 0x51FB8CC VA: 0x51FF8CC
	|-ObjectPool<__Il2CppFullySharedGenericType>.Release
	*/
}

// Namespace: UnityEngine.Rendering
public static class GenericPool<T> // TypeDefIndex: 19827
{
	// Fields
	private static readonly ObjectPool<T> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490B0E0 Offset: 0x49070E0 VA: 0x490B0E0
	|-GenericPool<object>.Get
	|
	|-RVA: 0x490B398 Offset: 0x4907398 VA: 0x490B398
	|-GenericPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<T> Get(out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490B178 Offset: 0x4907178 VA: 0x490B178
	|-GenericPool<object>.Get
	|
	|-RVA: 0x490B51C Offset: 0x490751C VA: 0x490B51C
	|-GenericPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(T toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490B220 Offset: 0x4907220 VA: 0x490B220
	|-GenericPool<object>.Release
	|
	|-RVA: 0x490B6AC Offset: 0x49076AC VA: 0x490B6AC
	|-GenericPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490B2C8 Offset: 0x49072C8 VA: 0x490B2C8
	|-GenericPool<object>..cctor
	|
	|-RVA: 0x490B898 Offset: 0x4907898 VA: 0x490B898
	|-GenericPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: UnityEngine.Rendering
public static class UnsafeGenericPool<T> // TypeDefIndex: 19828
{
	// Fields
	private static readonly ObjectPool<T> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE85C Offset: 0x56BA85C VA: 0x56BE85C
	|-UnsafeGenericPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<T> Get(out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE9E0 Offset: 0x56BA9E0 VA: 0x56BE9E0
	|-UnsafeGenericPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(T toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BEB70 Offset: 0x56BAB70 VA: 0x56BEB70
	|-UnsafeGenericPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BED5C Offset: 0x56BAD5C VA: 0x56BED5C
	|-UnsafeGenericPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ListPool.<>c<T> // TypeDefIndex: 19829
{
	// Fields
	public static readonly ListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4821CA4 Offset: 0x481DCA4 VA: 0x4821CA4
	|-ListPool.<>c<int>..cctor
	|
	|-RVA: 0x4823D30 Offset: 0x481FD30 VA: 0x4823D30
	|-ListPool.<>c<object>..cctor
	|
	|-RVA: 0x482862C Offset: 0x482462C VA: 0x482862C
	|-ListPool.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4821D60 Offset: 0x481DD60 VA: 0x4821D60
	|-ListPool.<>c<int>..ctor
	|
	|-RVA: 0x4823DEC Offset: 0x481FDEC VA: 0x4823DEC
	|-ListPool.<>c<object>..ctor
	|
	|-RVA: 0x4828720 Offset: 0x4824720 VA: 0x4828720
	|-ListPool.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__4_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4821D68 Offset: 0x481DD68 VA: 0x4821D68
	|-ListPool.<>c<int>.<.cctor>b__4_0
	|
	|-RVA: 0x4823DF4 Offset: 0x481FDF4 VA: 0x4823DF4
	|-ListPool.<>c<object>.<.cctor>b__4_0
	|
	|-RVA: 0x4828728 Offset: 0x4824728 VA: 0x4828728
	|-ListPool.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__4_0
	*/
}

// Namespace: UnityEngine.Rendering
public static class ListPool<T> // TypeDefIndex: 19830
{
	// Fields
	private static readonly ObjectPool<List<T>> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6ABA8 Offset: 0x4B66BA8 VA: 0x4B6ABA8
	|-ListPool<int>.Get
	|
	|-RVA: 0x4B6AF54 Offset: 0x4B66F54 VA: 0x4B6AF54
	|-ListPool<object>.Get
	|
	|-RVA: 0x4B6B300 Offset: 0x4B67300 VA: 0x4B6B300
	|-ListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<List<T>> Get(out List<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6AC40 Offset: 0x4B66C40 VA: 0x4B6AC40
	|-ListPool<int>.Get
	|
	|-RVA: 0x4B6AFEC Offset: 0x4B66FEC VA: 0x4B6AFEC
	|-ListPool<object>.Get
	|
	|-RVA: 0x4B6B3E8 Offset: 0x4B673E8 VA: 0x4B6B3E8
	|-ListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6ACE8 Offset: 0x4B66CE8 VA: 0x4B6ACE8
	|-ListPool<int>.Release
	|
	|-RVA: 0x4B6B094 Offset: 0x4B67094 VA: 0x4B6B094
	|-ListPool<object>.Release
	|
	|-RVA: 0x4B6B4E8 Offset: 0x4B674E8 VA: 0x4B6B4E8
	|-ListPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6AD90 Offset: 0x4B66D90 VA: 0x4B6AD90
	|-ListPool<int>..cctor
	|
	|-RVA: 0x4B6B13C Offset: 0x4B6713C VA: 0x4B6B13C
	|-ListPool<object>..cctor
	|
	|-RVA: 0x4B6B5E4 Offset: 0x4B675E4 VA: 0x4B6B5E4
	|-ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HashSetPool.<>c<T> // TypeDefIndex: 19831
{
	// Fields
	public static readonly HashSetPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482821C Offset: 0x482421C VA: 0x482821C
	|-HashSetPool.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4828310 Offset: 0x4824310 VA: 0x4828310
	|-HashSetPool.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__4_0(HashSet<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4828318 Offset: 0x4824318 VA: 0x4828318
	|-HashSetPool.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__4_0
	*/
}

// Namespace: UnityEngine.Rendering
public static class HashSetPool<T> // TypeDefIndex: 19832
{
	// Fields
	private static readonly ObjectPool<HashSet<T>> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static HashSet<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4914AA4 Offset: 0x4910AA4 VA: 0x4914AA4
	|-HashSetPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<HashSet<T>> Get(out HashSet<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4914B8C Offset: 0x4910B8C VA: 0x4914B8C
	|-HashSetPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(HashSet<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4914C8C Offset: 0x4910C8C VA: 0x4914C8C
	|-HashSetPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4914D88 Offset: 0x4910D88 VA: 0x4914D88
	|-HashSetPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DictionaryPool.<>c<TKey, TValue> // TypeDefIndex: 19833
{
	// Fields
	public static readonly DictionaryPool.<>c<TKey, TValue> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4834558 Offset: 0x4830558 VA: 0x4834558
	|-DictionaryPool.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x483464C Offset: 0x483064C VA: 0x483464C
	|-DictionaryPool.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__4_0(Dictionary<TKey, TValue> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4834654 Offset: 0x4830654 VA: 0x4834654
	|-DictionaryPool.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<.cctor>b__4_0
	*/
}

// Namespace: UnityEngine.Rendering
public static class DictionaryPool<TKey, TValue> // TypeDefIndex: 19834
{
	// Fields
	private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TValue> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D59BD0 Offset: 0x5D55BD0 VA: 0x5D59BD0
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<Dictionary<TKey, TValue>> Get(out Dictionary<TKey, TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D59CB8 Offset: 0x5D55CB8 VA: 0x5D59CB8
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(Dictionary<TKey, TValue> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D59DB8 Offset: 0x5D55DB8 VA: 0x5D59DB8
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D59EB4 Offset: 0x5D55EB4 VA: 0x5D59EB4
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: UnityEngine.Rendering
public sealed class ListChangedEventArgs<T> : EventArgs // TypeDefIndex: 19835
{
	// Fields
	public readonly int index; // 0x0
	public readonly T item; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B64D54 Offset: 0x4B60D54 VA: 0x4B64D54
	|-ListChangedEventArgs<object>..ctor
	|
	|-RVA: 0x4B64DD0 Offset: 0x4B60DD0 VA: 0x4B64DD0
	|-ListChangedEventArgs<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.Rendering
public sealed class ListChangedEventHandler<T> : MulticastDelegate // TypeDefIndex: 19836
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B64F08 Offset: 0x4B60F08 VA: 0x4B64F08
	|-ListChangedEventHandler<object>..ctor
	|
	|-RVA: 0x4B6505C Offset: 0x4B6105C VA: 0x4B6505C
	|-ListChangedEventHandler<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ObservableList<T> sender, ListChangedEventArgs<T> e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B65014 Offset: 0x4B61014 VA: 0x4B65014
	|-ListChangedEventHandler<object>.Invoke
	|
	|-RVA: 0x4B65168 Offset: 0x4B61168 VA: 0x4B65168
	|-ListChangedEventHandler<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ObservableList<T> sender, ListChangedEventArgs<T> e, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B65028 Offset: 0x4B61028 VA: 0x4B65028
	|-ListChangedEventHandler<object>.BeginInvoke
	|
	|-RVA: 0x4B6517C Offset: 0x4B6117C VA: 0x4B6517C
	|-ListChangedEventHandler<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B65050 Offset: 0x4B61050 VA: 0x4B65050
	|-ListChangedEventHandler<object>.EndInvoke
	|
	|-RVA: 0x4B651A4 Offset: 0x4B611A4 VA: 0x4B651A4
	|-ListChangedEventHandler<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: UnityEngine.Rendering
[DefaultMember("Item")]
public class ObservableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 19837
{
	// Fields
	private IList<T> m_List; // 0x0
	[CompilerGenerated]
	private ListChangedEventHandler<T> ItemAdded; // 0x0
	[CompilerGenerated]
	private ListChangedEventHandler<T> ItemRemoved; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_ItemAdded(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206880 Offset: 0x5202880 VA: 0x5206880
	|-ObservableList<object>.add_ItemAdded
	|
	|-RVA: 0x5207820 Offset: 0x5203820 VA: 0x5207820
	|-ObservableList<__Il2CppFullySharedGenericType>.add_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_ItemAdded(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520692C Offset: 0x520292C VA: 0x520692C
	|-ObservableList<object>.remove_ItemAdded
	|
	|-RVA: 0x52078CC Offset: 0x52038CC VA: 0x52078CC
	|-ObservableList<__Il2CppFullySharedGenericType>.remove_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_ItemRemoved(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52069D8 Offset: 0x52029D8 VA: 0x52069D8
	|-ObservableList<object>.add_ItemRemoved
	|
	|-RVA: 0x5207978 Offset: 0x5203978 VA: 0x5207978
	|-ObservableList<__Il2CppFullySharedGenericType>.add_ItemRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_ItemRemoved(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206A84 Offset: 0x5202A84 VA: 0x5206A84
	|-ObservableList<object>.remove_ItemRemoved
	|
	|-RVA: 0x5207A24 Offset: 0x5203A24 VA: 0x5207A24
	|-ObservableList<__Il2CppFullySharedGenericType>.remove_ItemRemoved
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206B30 Offset: 0x5202B30 VA: 0x5206B30
	|-ObservableList<object>.get_Item
	|
	|-RVA: 0x5207AD0 Offset: 0x5203AD0 VA: 0x5207AD0
	|-ObservableList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206BC8 Offset: 0x5202BC8 VA: 0x5206BC8
	|-ObservableList<object>.set_Item
	|
	|-RVA: 0x5207BEC Offset: 0x5203BEC VA: 0x5207BEC
	|-ObservableList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206D48 Offset: 0x5202D48 VA: 0x5206D48
	|-ObservableList<object>.get_Count
	|
	|-RVA: 0x5207EAC Offset: 0x5203EAC VA: 0x5207EAC
	|-ObservableList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206DD0 Offset: 0x5202DD0 VA: 0x5206DD0
	|-ObservableList<object>.get_IsReadOnly
	|
	|-RVA: 0x5207F34 Offset: 0x5203F34 VA: 0x5207F34
	|-ObservableList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206DD8 Offset: 0x5202DD8 VA: 0x5206DD8
	|-ObservableList<object>..ctor
	|
	|-RVA: 0x5207F3C Offset: 0x5203F3C VA: 0x5207F3C
	|-ObservableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206DEC Offset: 0x5202DEC VA: 0x5206DEC
	|-ObservableList<object>..ctor
	|
	|-RVA: 0x5207F54 Offset: 0x5203F54 VA: 0x5207F54
	|-ObservableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206E54 Offset: 0x5202E54 VA: 0x5206E54
	|-ObservableList<object>..ctor
	|
	|-RVA: 0x5207FC0 Offset: 0x5203FC0 VA: 0x5207FC0
	|-ObservableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void OnEvent(ListChangedEventHandler<T> e, int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206EBC Offset: 0x5202EBC VA: 0x5206EBC
	|-ObservableList<object>.OnEvent
	|
	|-RVA: 0x520802C Offset: 0x520402C VA: 0x520802C
	|-ObservableList<__Il2CppFullySharedGenericType>.OnEvent
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206F40 Offset: 0x5202F40 VA: 0x5206F40
	|-ObservableList<object>.Contains
	|
	|-RVA: 0x5208158 Offset: 0x5204158 VA: 0x5208158
	|-ObservableList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5206FDC Offset: 0x5202FDC VA: 0x5206FDC
	|-ObservableList<object>.IndexOf
	|
	|-RVA: 0x52082A0 Offset: 0x52042A0 VA: 0x52082A0
	|-ObservableList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5207078 Offset: 0x5203078 VA: 0x5207078
	|-ObservableList<object>.Add
	|
	|-RVA: 0x52083E0 Offset: 0x52043E0 VA: 0x52083E0
	|-ObservableList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52071CC Offset: 0x52031CC VA: 0x52071CC
	|-ObservableList<object>.Add
	|
	|-RVA: 0x5208684 Offset: 0x5204684 VA: 0x5208684
	|-ObservableList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5207248 Offset: 0x5203248 VA: 0x5207248
	|-ObservableList<object>.Insert
	|
	|-RVA: 0x52087EC Offset: 0x52047EC VA: 0x52087EC
	|-ObservableList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520731C Offset: 0x520331C VA: 0x520731C
	|-ObservableList<object>.Remove
	|
	|-RVA: 0x52089C0 Offset: 0x52049C0 VA: 0x52089C0
	|-ObservableList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public int Remove(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5207480 Offset: 0x5203480 VA: 0x5207480
	|-ObservableList<object>.Remove
	|
	|-RVA: 0x5208C70 Offset: 0x5204C70 VA: 0x5208C70
	|-ObservableList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5207518 Offset: 0x5203518 VA: 0x5207518
	|-ObservableList<object>.RemoveAt
	|
	|-RVA: 0x5208DF0 Offset: 0x5204DF0 VA: 0x5208DF0
	|-ObservableList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5207668 Offset: 0x5203668 VA: 0x5207668
	|-ObservableList<object>.Clear
	|
	|-RVA: 0x5209020 Offset: 0x5205020 VA: 0x5209020
	|-ObservableList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52076E4 Offset: 0x52036E4 VA: 0x52076E4
	|-ObservableList<object>.CopyTo
	|
	|-RVA: 0x52090AC Offset: 0x52050AC VA: 0x52090AC
	|-ObservableList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5207788 Offset: 0x5203788 VA: 0x5207788
	|-ObservableList<object>.GetEnumerator
	|
	|-RVA: 0x5209150 Offset: 0x5205150 VA: 0x5209150
	|-ObservableList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5207810 Offset: 0x5203810 VA: 0x5207810
	|-ObservableList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x52091D8 Offset: 0x52051D8 VA: 0x52091D8
	|-ObservableList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: UnityEngine.Rendering
[Extension]
public static class RemoveRangeExtensions // TypeDefIndex: 19838
{
	// Methods

	[MustUseReturnValue]
	[Extension]
	[CollectionAccess(2)]
	// RVA: -1 Offset: -1
	public static bool TryRemoveElementsInRange<TValue>(IList<TValue> list, int index, int count, out Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BD39C Offset: 0x46B939C VA: 0x46BD39C
	|-RemoveRangeExtensions.TryRemoveElementsInRange<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.Rendering
[Serializable]
public class SerializableEnum // TypeDefIndex: 19839
{
	// Fields
	[SerializeField]
	private string m_EnumValueAsString; // 0x10
	[SerializeField]
	private string m_EnumTypeAsString; // 0x18

	// Properties
	public Enum value { get; set; }

	// Methods

	// RVA: 0x85ADCD8 Offset: 0x85A9CD8 VA: 0x85ADCD8
	public Enum get_value() { }

	// RVA: 0x85ADE18 Offset: 0x85A9E18 VA: 0x85ADE18
	public void set_value(Enum value) { }

	// RVA: 0x85ADE50 Offset: 0x85A9E50 VA: 0x85ADE50
	public void .ctor(Type enumType) { }
}

// Namespace: UnityEngine.Rendering
[Serializable]
public class SerializedDictionary<K, V> : SerializedDictionary<K, V, K, V> // TypeDefIndex: 19840
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 48
	public override K SerializeKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2788 Offset: 0x54DE788 VA: 0x54E2788
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeKey
	*/

	// RVA: -1 Offset: -1 Slot: 49
	public override V SerializeValue(V val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2828 Offset: 0x54DE828 VA: 0x54E2828
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeValue
	*/

	// RVA: -1 Offset: -1 Slot: 50
	public override K DeserializeKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E28C8 Offset: 0x54DE8C8 VA: 0x54E28C8
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeKey
	*/

	// RVA: -1 Offset: -1 Slot: 51
	public override V DeserializeValue(V val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2968 Offset: 0x54DE968 VA: 0x54E2968
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeValue
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2A08 Offset: 0x54DEA08 VA: 0x54E2A08
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.Rendering
[Serializable]
public abstract class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver // TypeDefIndex: 19841
{
	// Fields
	[SerializeField]
	private List<SK> m_Keys; // 0x0
	[SerializeField]
	private List<SV> m_Values; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 48
	public abstract SK SerializeKey(K key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeKey
	*/

	// RVA: -1 Offset: -1 Slot: 49
	public abstract SV SerializeValue(V value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeValue
	*/

	// RVA: -1 Offset: -1 Slot: 50
	public abstract K DeserializeKey(SK serializedKey);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeKey
	*/

	// RVA: -1 Offset: -1 Slot: 51
	public abstract V DeserializeValue(SV serializedValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeValue
	*/

	// RVA: -1 Offset: -1 Slot: 46
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2A1C Offset: 0x54DEA1C VA: 0x54E2A1C
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 47
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2EC4 Offset: 0x54DEEC4 VA: 0x54E2EC4
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E3150 Offset: 0x54DF150 VA: 0x54E3150
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.Rendering
[Extension]
public static class SwapCollectionExtensions // TypeDefIndex: 19842
{
	// Methods

	[MustUseReturnValue]
	[CollectionAccess(2)]
	[Extension]
	// RVA: -1 Offset: -1
	public static bool TrySwap<TValue>(IList<TValue> list, int from, int to, out Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470E000 Offset: 0x470A000 VA: 0x470E000
	|-SwapCollectionExtensions.TrySwap<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
public enum XRGraphics.StereoRenderingMode // TypeDefIndex: 19843
{
	// Fields
	public int value__; // 0x0
	public const XRGraphics.StereoRenderingMode MultiPass = 0;
	public const XRGraphics.StereoRenderingMode SinglePass = 1;
	public const XRGraphics.StereoRenderingMode SinglePassInstanced = 2;
	public const XRGraphics.StereoRenderingMode SinglePassMultiView = 3;
}

// Namespace: UnityEngine.Rendering
[Serializable]
public class XRGraphics // TypeDefIndex: 19844
{
	// Properties
	public static float eyeTextureResolutionScale { get; set; }
	public static float renderViewportScale { get; }
	public static bool enabled { get; }
	public static bool isDeviceActive { get; }
	public static string loadedDeviceName { get; }
	public static string[] supportedDevices { get; }
	public static XRGraphics.StereoRenderingMode stereoRenderingMode { get; }
	public static RenderTextureDescriptor eyeTextureDesc { get; }
	public static int eyeTextureWidth { get; }
	public static int eyeTextureHeight { get; }

	// Methods

	// RVA: 0x85ADF04 Offset: 0x85A9F04 VA: 0x85ADF04
	public static float get_eyeTextureResolutionScale() { }

	// RVA: 0x85ADF34 Offset: 0x85A9F34 VA: 0x85ADF34
	public static void set_eyeTextureResolutionScale(float value) { }

	// RVA: 0x85ADF3C Offset: 0x85A9F3C VA: 0x85ADF3C
	public static float get_renderViewportScale() { }

	// RVA: 0x85ADF2C Offset: 0x85A9F2C VA: 0x85ADF2C
	public static bool get_enabled() { }

	// RVA: 0x85ADF64 Offset: 0x85A9F64 VA: 0x85ADF64
	public static bool get_isDeviceActive() { }

	// RVA: 0x85ADF8C Offset: 0x85A9F8C VA: 0x85ADF8C
	public static string get_loadedDeviceName() { }

	// RVA: 0x85ADFDC Offset: 0x85A9FDC VA: 0x85ADFDC
	public static string[] get_supportedDevices() { }

	// RVA: 0x85AE030 Offset: 0x85AA030 VA: 0x85AE030
	public static XRGraphics.StereoRenderingMode get_stereoRenderingMode() { }

	// RVA: 0x85AE058 Offset: 0x85AA058 VA: 0x85AE058
	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	// RVA: 0x85AE0D0 Offset: 0x85AA0D0 VA: 0x85AE0D0
	public static int get_eyeTextureWidth() { }

	// RVA: 0x85AE0F8 Offset: 0x85AA0F8 VA: 0x85AE0F8
	public static int get_eyeTextureHeight() { }

	// RVA: 0x85AE120 Offset: 0x85AA120 VA: 0x85AE120
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DebugDisplaySettings.<>c<T> // TypeDefIndex: 19845
{
	// Fields
	public static readonly DebugDisplaySettings.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4827AAC Offset: 0x4823AAC VA: 0x4827AAC
	|-DebugDisplaySettings.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4827BA0 Offset: 0x4823BA0 VA: 0x4827BA0
	|-DebugDisplaySettings.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <.cctor>b__15_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4827BA8 Offset: 0x4823BA8 VA: 0x4827BA8
	|-DebugDisplaySettings.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__15_0
	*/
}

// Namespace: UnityEngine.Rendering
public abstract class DebugDisplaySettings<T> : IDebugDisplaySettings, IDebugDisplaySettingsQuery // TypeDefIndex: 19846
{
	// Fields
	protected readonly HashSet<IDebugDisplaySettingsData> m_Settings; // 0x0
	private static readonly Lazy<T> s_Instance; // 0x0

	// Properties
	public static T Instance { get; }
	public virtual bool AreAnySettingsActive { get; }
	public virtual bool IsPostProcessingAllowed { get; }
	public virtual bool IsLightingActive { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1EAE4 Offset: 0x5D1AAE4 VA: 0x5D1EAE4
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.get_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual bool get_AreAnySettingsActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1EC68 Offset: 0x5D1AC68 VA: 0x5D1EC68
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.get_AreAnySettingsActive
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual bool get_IsPostProcessingAllowed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1EE34 Offset: 0x5D1AE34 VA: 0x5D1EE34
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.get_IsPostProcessingAllowed
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool get_IsLightingActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1EFF4 Offset: 0x5D1AFF4 VA: 0x5D1EFF4
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.get_IsLightingActive
	*/

	// RVA: -1 Offset: -1
	protected TData Add<TData>(TData newData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42232B4 Offset: 0x421F2B4 VA: 0x42232B4
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void ForEach(Action<IDebugDisplaySettingsData> onExecute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1F1B4 Offset: 0x5D1B1B4 VA: 0x5D1F1B4
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.ForEach
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1F30C Offset: 0x5D1B30C VA: 0x5D1F30C
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual bool TryGetScreenClearColor(ref Color color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1F35C Offset: 0x5D1B35C VA: 0x5D1F35C
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.TryGetScreenClearColor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1F53C Offset: 0x5D1B53C VA: 0x5D1F53C
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1F5C4 Offset: 0x5D1B5C4 VA: 0x5D1F5C4
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: UnityEngine.Rendering
public abstract class DebugDisplaySettingsPanel : IDebugDisplaySettingsPanelDisposable, IDebugDisplaySettingsPanel, IDisposable // TypeDefIndex: 19847
{
	// Fields
	private readonly List<DebugUI.Widget> m_Widgets; // 0x10
	private readonly DisplayInfoAttribute m_DisplayInfo; // 0x18

	// Properties
	public virtual string PanelName { get; }
	public virtual int Order { get; }
	public DebugUI.Widget[] Widgets { get; }
	public virtual DebugUI.Flags Flags { get; }

	// Methods

	// RVA: 0x85AE128 Offset: 0x85AA128 VA: 0x85AE128 Slot: 8
	public virtual string get_PanelName() { }

	// RVA: 0x85AE184 Offset: 0x85AA184 VA: 0x85AE184 Slot: 9
	public virtual int get_Order() { }

	// RVA: 0x85AE19C Offset: 0x85AA19C VA: 0x85AE19C Slot: 5
	public DebugUI.Widget[] get_Widgets() { }

	// RVA: 0x85AE1EC Offset: 0x85AA1EC VA: 0x85AE1EC Slot: 10
	public virtual DebugUI.Flags get_Flags() { }

	// RVA: 0x85AE1F4 Offset: 0x85AA1F4 VA: 0x85AE1F4
	protected void AddWidget(DebugUI.Widget widget) { }

	// RVA: 0x85AE2EC Offset: 0x85AA2EC VA: 0x85AE2EC
	protected void Clear() { }

	// RVA: 0x85AE35C Offset: 0x85AA35C VA: 0x85AE35C Slot: 7
	public void Dispose() { }

	// RVA: 0x85AE360 Offset: 0x85AA360 VA: 0x85AE360
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public abstract class DebugDisplaySettingsPanel<T> : DebugDisplaySettingsPanel // TypeDefIndex: 19848
{
	// Fields
	internal T m_Data; // 0x0

	// Properties
	public T data { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E888 Offset: 0x5D1A888 VA: 0x5D1E888
	|-DebugDisplaySettingsPanel<object>.get_data
	|
	|-RVA: 0x5D1E8C8 Offset: 0x5D1A8C8 VA: 0x5D1E8C8
	|-DebugDisplaySettingsPanel<__Il2CppFullySharedGenericType>.get_data
	*/

	// RVA: -1 Offset: -1
	internal void set_data(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E890 Offset: 0x5D1A890 VA: 0x5D1E890
	|-DebugDisplaySettingsPanel<object>.set_data
	|
	|-RVA: 0x5D1E960 Offset: 0x5D1A960 VA: 0x5D1E960
	|-DebugDisplaySettingsPanel<__Il2CppFullySharedGenericType>.set_data
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E898 Offset: 0x5D1A898 VA: 0x5D1E898
	|-DebugDisplaySettingsPanel<object>..ctor
	|
	|-RVA: 0x5D1EA14 Offset: 0x5D1AA14 VA: 0x5D1EA14
	|-DebugDisplaySettingsPanel<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugDisplaySettingsUI.<>c__DisplayClass3_0 // TypeDefIndex: 19849
{
	// Fields
	public DebugManager debugManager; // 0x10
	public List<IDebugDisplaySettingsPanelDisposable> panels; // 0x18

	// Methods

	// RVA: 0x85AEC7C Offset: 0x85AAC7C VA: 0x85AEC7C
	public void .ctor() { }

	// RVA: 0x85AEE60 Offset: 0x85AAE60 VA: 0x85AEE60
	internal void <RegisterDebug>b__0(IDebugDisplaySettingsData data) { }
}

// Namespace: UnityEngine.Rendering
public class DebugDisplaySettingsUI : IDebugData // TypeDefIndex: 19850
{
	// Fields
	private IEnumerable<IDebugDisplaySettingsPanelDisposable> m_DisposablePanels; // 0x10
	private IDebugDisplaySettings m_Settings; // 0x18

	// Methods

	// RVA: 0x85AE4C0 Offset: 0x85AA4C0 VA: 0x85AE4C0
	private void Reset() { }

	// RVA: 0x85AEA88 Offset: 0x85AAA88 VA: 0x85AEA88
	public void RegisterDebug(IDebugDisplaySettings settings) { }

	// RVA: 0x85AE5AC Offset: 0x85AA5AC VA: 0x85AE5AC
	public void UnregisterDebug() { }

	// RVA: 0x85AEDDC Offset: 0x85AADDC VA: 0x85AEDDC Slot: 4
	public Action GetReset() { }

	// RVA: 0x85AEE58 Offset: 0x85AAE58 VA: 0x85AEE58
	public void .ctor() { }
}

// Namespace: 
private static class DebugDisplaySettingsVolume.Styles // TypeDefIndex: 19851
{
	// Fields
	public static readonly GUIContent none; // 0x0
	public static readonly GUIContent editorCamera; // 0x8

	// Methods

	// RVA: 0x85AF358 Offset: 0x85AB358 VA: 0x85AF358
	private static void .cctor() { }
}

// Namespace: 
private static class DebugDisplaySettingsVolume.Strings // TypeDefIndex: 19852
{
	// Fields
	public static readonly string none; // 0x0
	public static readonly string camera; // 0x8
	public static readonly string parameter; // 0x10
	public static readonly string component; // 0x18
	public static readonly string debugViewNotSupported; // 0x20
	public static readonly string parameterNotOverrided; // 0x28
	public static readonly string volumeInfo; // 0x30
	public static readonly string gameObject; // 0x38
	public static readonly string resultValue; // 0x40
	public static readonly string resultValueTooltip; // 0x48
	public static readonly string globalDefaultValue; // 0x50
	public static readonly string globalDefaultValueTooltip; // 0x58
	public static readonly string qualityLevelValue; // 0x60
	public static readonly string qualityLevelValueTooltip; // 0x68
	public static readonly string global; // 0x70
	public static readonly string local; // 0x78
	public static readonly string volumeProfile; // 0x80

	// Methods

	// RVA: 0x85AF434 Offset: 0x85AB434 VA: 0x85AF434
	private static void .cctor() { }
}

// Namespace: 
private struct DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain // TypeDefIndex: 19853
{
	// Fields
	public DebugUI.Widget.NameAndTooltip nameAndTooltip; // 0x0
	public VolumeProfile volumeProfile; // 0x10
	public VolumeComponent volumeComponent; // 0x18
	public Volume volume; // 0x20
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DebugDisplaySettingsVolume.WidgetFactory.<>c // TypeDefIndex: 19854
{
	// Fields
	public static readonly DebugDisplaySettingsVolume.WidgetFactory.<>c <>9; // 0x0
	public static Func<object> <>9__9_2; // 0x8

	// Methods

	// RVA: 0x85B1CC0 Offset: 0x85ADCC0 VA: 0x85B1CC0
	private static void .cctor() { }

	// RVA: 0x85B1D28 Offset: 0x85ADD28 VA: 0x85B1D28
	public void .ctor() { }

	// RVA: 0x85B1D30 Offset: 0x85ADD30 VA: 0x85B1D30
	internal object <GenerateTableColumns>b__9_2() { }

	// RVA: 0x85B1D78 Offset: 0x85ADD78 VA: 0x85B1D78
	internal object <.cctor>b__11_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass0_0 // TypeDefIndex: 19855
{
	// Fields
	public DebugDisplaySettingsVolume.SettingsPanel panel; // 0x10

	// Methods

	// RVA: 0x85AFE38 Offset: 0x85ABE38 VA: 0x85AFE38
	public void .ctor() { }

	// RVA: 0x85B1DC0 Offset: 0x85ADDC0 VA: 0x85B1DC0
	internal int <CreateComponentSelector>b__0() { }

	// RVA: 0x85B1E7C Offset: 0x85ADE7C VA: 0x85B1E7C
	internal void <CreateComponentSelector>b__1(int value) { }

	// RVA: 0x85B1F44 Offset: 0x85ADF44 VA: 0x85B1F44
	internal int <CreateComponentSelector>b__2() { }

	// RVA: 0x85B1F94 Offset: 0x85ADF94 VA: 0x85B1F94
	internal void <CreateComponentSelector>b__3(int value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass1_0 // TypeDefIndex: 19856
{
	// Fields
	public DebugDisplaySettingsVolume.SettingsPanel panel; // 0x10

	// Methods

	// RVA: 0x85B0054 Offset: 0x85AC054 VA: 0x85B0054
	public void .ctor() { }

	// RVA: 0x85B1FE8 Offset: 0x85ADFE8 VA: 0x85B1FE8
	internal Object <CreateCameraSelector>b__0() { }

	// RVA: 0x85B20A8 Offset: 0x85AE0A8 VA: 0x85B20A8
	internal void <CreateCameraSelector>b__1(Object value) { }

	// RVA: 0x85B2258 Offset: 0x85AE258 VA: 0x85B2258
	internal IEnumerable<Object> <CreateCameraSelector>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass7_0 // TypeDefIndex: 19857
{
	// Fields
	public float timer; // 0x10
	public float refreshRate; // 0x14
	public DebugDisplaySettingsVolume data; // 0x18
	public DebugUI.Table table; // 0x20
	public Volume[] volumes; // 0x28

	// Methods

	// RVA: 0x85B0BC8 Offset: 0x85ACBC8 VA: 0x85B0BC8
	public void .ctor() { }

	// RVA: 0x85B2318 Offset: 0x85AE318 VA: 0x85B2318
	internal bool <CreateVolumeTable>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass9_0 // TypeDefIndex: 19858
{
	// Fields
	public DebugDisplaySettingsVolume data; // 0x10

	// Methods

	// RVA: 0x85B1A78 Offset: 0x85ADA78 VA: 0x85B1A78
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass9_1 // TypeDefIndex: 19859
{
	// Fields
	public DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain chain; // 0x10
	public DebugDisplaySettingsVolume.WidgetFactory.<>c__DisplayClass9_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x85B1A80 Offset: 0x85ADA80 VA: 0x85B1A80
	public void .ctor() { }

	// RVA: 0x85B2580 Offset: 0x85AE580 VA: 0x85B2580
	internal object <GenerateTableColumns>b__0() { }

	// RVA: 0x85B26F8 Offset: 0x85AE6F8 VA: 0x85B26F8
	internal Object <GenerateTableColumns>b__1() { }

	// RVA: 0x85B2700 Offset: 0x85AE700 VA: 0x85B2700
	internal Object <GenerateTableColumns>b__3() { }
}

// Namespace: 
internal static class DebugDisplaySettingsVolume.WidgetFactory // TypeDefIndex: 19860
{
	// Fields
	private static DebugUI.Value s_EmptyDebugUIValue; // 0x0

	// Methods

	// RVA: 0x85AF740 Offset: 0x85AB740 VA: 0x85AF740
	public static DebugUI.EnumField CreateComponentSelector(DebugDisplaySettingsVolume.SettingsPanel panel, Action<DebugUI.Field<int>, int> refresh) { }

	// RVA: 0x85AFE40 Offset: 0x85ABE40 VA: 0x85AFE40
	public static DebugUI.ObjectPopupField CreateCameraSelector(DebugDisplaySettingsVolume.SettingsPanel panel, Action<DebugUI.Field<Object>, Object> refresh) { }

	// RVA: 0x85B00A4 Offset: 0x85AC0A4 VA: 0x85B00A4
	private static DebugUI.Widget CreateVolumeParameterWidget(string name, bool isResultParameter, VolumeParameter param, Func<bool> isHiddenCallback) { }

	// RVA: 0x85B0158 Offset: 0x85AC158 VA: 0x85B0158
	private static VolumeComponent GetSelectedVolumeComponent(VolumeProfile profile, Type selectedType) { }

	// RVA: 0x85B0354 Offset: 0x85AC354 VA: 0x85B0354
	private static List<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> GetResolutionChain(DebugDisplaySettingsVolume data) { }

	// RVA: 0x85B095C Offset: 0x85AC95C VA: 0x85B095C
	public static DebugUI.Table CreateVolumeTable(DebugDisplaySettingsVolume data) { }

	// RVA: 0x85B16D0 Offset: 0x85AD6D0 VA: 0x85B16D0
	private static void SetTableColumnVisibility(DebugDisplaySettingsVolume data, DebugUI.Table table) { }

	// RVA: 0x85B0EC8 Offset: 0x85ACEC8 VA: 0x85B0EC8
	private static void GenerateTableColumns(DebugUI.Table table, DebugDisplaySettingsVolume data, List<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain) { }

	// RVA: 0x85B0C24 Offset: 0x85ACC24 VA: 0x85B0C24
	private static void GenerateTableRows(DebugUI.Table table, List<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain> resolutionChain) { }

	// RVA: 0x85B1BB4 Offset: 0x85ADBB4 VA: 0x85B1BB4
	private static void .cctor() { }
}

// Namespace: 
[DisplayInfo(name = "Volume", order = 2147483647)]
internal class DebugDisplaySettingsVolume.SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsVolume> // TypeDefIndex: 19861
{
	// Fields
	private DebugUI.Table m_VolumeTable; // 0x28

	// Methods

	// RVA: 0x85AF21C Offset: 0x85AB21C VA: 0x85AF21C
	public void .ctor(DebugDisplaySettingsVolume data) { }

	// RVA: 0x85B2708 Offset: 0x85AE708 VA: 0x85B2708
	private void Refresh() { }

	[CompilerGenerated]
	// RVA: 0x85B29B4 Offset: 0x85AE9B4 VA: 0x85B29B4
	private void <.ctor>b__0_0(DebugUI.Field<int> _, int __) { }

	[CompilerGenerated]
	// RVA: 0x85B29B8 Offset: 0x85AE9B8 VA: 0x85B29B8
	private void <.ctor>b__0_1(DebugUI.Field<Object> _, Object __) { }
}

// Namespace: UnityEngine.Rendering
public class DebugDisplaySettingsVolume : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery // TypeDefIndex: 19862
{
	// Fields
	[CompilerGenerated]
	private readonly IVolumeDebugSettings2 <volumeDebugSettings>k__BackingField; // 0x10
	internal int volumeComponentEnumIndex; // 0x18

	// Properties
	public IVolumeDebugSettings2 volumeDebugSettings { get; }
	public bool AreAnySettingsActive { get; }
	public bool IsPostProcessingAllowed { get; }
	public bool IsLightingActive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85AF16C Offset: 0x85AB16C VA: 0x85AF16C
	public IVolumeDebugSettings2 get_volumeDebugSettings() { }

	// RVA: 0x85AF174 Offset: 0x85AB174 VA: 0x85AF174
	public void .ctor(IVolumeDebugSettings2 volumeDebugSettings) { }

	// RVA: 0x85AF1A4 Offset: 0x85AB1A4 VA: 0x85AF1A4 Slot: 5
	public bool get_AreAnySettingsActive() { }

	// RVA: 0x85AF1AC Offset: 0x85AB1AC VA: 0x85AF1AC Slot: 6
	public bool get_IsPostProcessingAllowed() { }

	// RVA: 0x85AF1B4 Offset: 0x85AB1B4 VA: 0x85AF1B4 Slot: 7
	public bool get_IsLightingActive() { }

	// RVA: 0x85AF1BC Offset: 0x85AB1BC VA: 0x85AF1BC Slot: 8
	public bool TryGetScreenClearColor(ref Color color) { }

	// RVA: 0x85AF1C4 Offset: 0x85AB1C4 VA: 0x85AF1C4 Slot: 4
	public IDebugDisplaySettingsPanelDisposable CreatePanel() { }
}

// Namespace: UnityEngine.Rendering
public class DebugFrameTiming // TypeDefIndex: 19863
{
	// Fields
	private const string k_FpsFormatString = "{0:F1}";
	private const string k_MsFormatString = "{0:F2}ms";
	private const float k_RefreshRate = 0.2;
	internal FrameTimeSampleHistory m_FrameHistory; // 0x10
	internal BottleneckHistory m_BottleneckHistory; // 0x18
	[CompilerGenerated]
	private int <bottleneckHistorySize>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <sampleHistorySize>k__BackingField; // 0x24
	private FrameTiming[] m_Timing; // 0x28
	private FrameTimeSample m_Sample; // 0x30

	// Properties
	public int bottleneckHistorySize { get; set; }
	public int sampleHistorySize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85B29BC Offset: 0x85AE9BC VA: 0x85B29BC
	public int get_bottleneckHistorySize() { }

	[CompilerGenerated]
	// RVA: 0x85B29C4 Offset: 0x85AE9C4 VA: 0x85B29C4
	public void set_bottleneckHistorySize(int value) { }

	[CompilerGenerated]
	// RVA: 0x85B29CC Offset: 0x85AE9CC VA: 0x85B29CC
	public int get_sampleHistorySize() { }

	[CompilerGenerated]
	// RVA: 0x85B29D4 Offset: 0x85AE9D4 VA: 0x85B29D4
	public void set_sampleHistorySize(int value) { }

	// RVA: 0x85B29DC Offset: 0x85AE9DC VA: 0x85B29DC
	public void .ctor() { }

	// RVA: 0x85B2AD4 Offset: 0x85AEAD4 VA: 0x85B2AD4
	public void UpdateFrameTiming() { }

	// RVA: 0x85B2CD4 Offset: 0x85AECD4 VA: 0x85B2CD4
	public void RegisterDebugUI(List<DebugUI.Widget> list) { }

	// RVA: 0x85B413C Offset: 0x85B013C VA: 0x85B413C
	internal void Reset() { }

	[CompilerGenerated]
	// RVA: 0x85B416C Offset: 0x85B016C VA: 0x85B416C
	private object <RegisterDebugUI>b__17_0() { }

	[CompilerGenerated]
	// RVA: 0x85B41CC Offset: 0x85B01CC VA: 0x85B41CC
	private object <RegisterDebugUI>b__17_1() { }

	[CompilerGenerated]
	// RVA: 0x85B422C Offset: 0x85B022C VA: 0x85B422C
	private object <RegisterDebugUI>b__17_2() { }

	[CompilerGenerated]
	// RVA: 0x85B428C Offset: 0x85B028C VA: 0x85B428C
	private object <RegisterDebugUI>b__17_3() { }

	[CompilerGenerated]
	// RVA: 0x85B42EC Offset: 0x85B02EC VA: 0x85B42EC
	private object <RegisterDebugUI>b__17_4() { }

	[CompilerGenerated]
	// RVA: 0x85B434C Offset: 0x85B034C VA: 0x85B434C
	private object <RegisterDebugUI>b__17_5() { }

	[CompilerGenerated]
	// RVA: 0x85B43AC Offset: 0x85B03AC VA: 0x85B43AC
	private object <RegisterDebugUI>b__17_6() { }

	[CompilerGenerated]
	// RVA: 0x85B440C Offset: 0x85B040C VA: 0x85B440C
	private object <RegisterDebugUI>b__17_7() { }

	[CompilerGenerated]
	// RVA: 0x85B446C Offset: 0x85B046C VA: 0x85B446C
	private object <RegisterDebugUI>b__17_8() { }

	[CompilerGenerated]
	// RVA: 0x85B44CC Offset: 0x85B04CC VA: 0x85B44CC
	private object <RegisterDebugUI>b__17_9() { }

	[CompilerGenerated]
	// RVA: 0x85B452C Offset: 0x85B052C VA: 0x85B452C
	private object <RegisterDebugUI>b__17_10() { }

	[CompilerGenerated]
	// RVA: 0x85B458C Offset: 0x85B058C VA: 0x85B458C
	private object <RegisterDebugUI>b__17_11() { }

	[CompilerGenerated]
	// RVA: 0x85B45EC Offset: 0x85B05EC VA: 0x85B45EC
	private object <RegisterDebugUI>b__17_12() { }

	[CompilerGenerated]
	// RVA: 0x85B464C Offset: 0x85B064C VA: 0x85B464C
	private object <RegisterDebugUI>b__17_13() { }

	[CompilerGenerated]
	// RVA: 0x85B46AC Offset: 0x85B06AC VA: 0x85B46AC
	private object <RegisterDebugUI>b__17_14() { }

	[CompilerGenerated]
	// RVA: 0x85B470C Offset: 0x85B070C VA: 0x85B470C
	private object <RegisterDebugUI>b__17_15() { }

	[CompilerGenerated]
	// RVA: 0x85B476C Offset: 0x85B076C VA: 0x85B476C
	private object <RegisterDebugUI>b__17_16() { }

	[CompilerGenerated]
	// RVA: 0x85B47CC Offset: 0x85B07CC VA: 0x85B47CC
	private object <RegisterDebugUI>b__17_17() { }

	[CompilerGenerated]
	// RVA: 0x85B482C Offset: 0x85B082C VA: 0x85B482C
	private object <RegisterDebugUI>b__17_18() { }

	[CompilerGenerated]
	// RVA: 0x85B488C Offset: 0x85B088C VA: 0x85B488C
	private object <RegisterDebugUI>b__17_19() { }

	[CompilerGenerated]
	// RVA: 0x85B48EC Offset: 0x85B08EC VA: 0x85B48EC
	private object <RegisterDebugUI>b__17_20() { }

	[CompilerGenerated]
	// RVA: 0x85B494C Offset: 0x85B094C VA: 0x85B494C
	private object <RegisterDebugUI>b__17_21() { }
}

// Namespace: UnityEngine.Rendering
internal enum DebugAction // TypeDefIndex: 19864
{
	// Fields
	public int value__; // 0x0
	public const DebugAction EnableDebugMenu = 0;
	public const DebugAction PreviousDebugPanel = 1;
	public const DebugAction NextDebugPanel = 2;
	public const DebugAction Action = 3;
	public const DebugAction MakePersistent = 4;
	public const DebugAction MoveVertical = 5;
	public const DebugAction MoveHorizontal = 6;
	public const DebugAction Multiplier = 7;
	public const DebugAction ResetAll = 8;
	public const DebugAction DebugActionCount = 9;
}

// Namespace: UnityEngine.Rendering
internal enum DebugActionRepeatMode // TypeDefIndex: 19865
{
	// Fields
	public int value__; // 0x0
	public const DebugActionRepeatMode Never = 0;
	public const DebugActionRepeatMode Delay = 1;
}

// Namespace: 
public enum DebugManager.UIMode // TypeDefIndex: 19866
{
	// Fields
	public int value__; // 0x0
	public const DebugManager.UIMode EditorMode = 0;
	public const DebugManager.UIMode RuntimeMode = 1;
}

// Namespace: 
private class DebugManager.UIState // TypeDefIndex: 19867
{
	// Fields
	public DebugManager.UIMode mode; // 0x10
	[SerializeField]
	private bool m_Open; // 0x14

	// Properties
	public bool open { get; set; }

	// Methods

	// RVA: 0x85B8E28 Offset: 0x85B4E28 VA: 0x85B8E28
	public bool get_open() { }

	// RVA: 0x85B880C Offset: 0x85B480C VA: 0x85B880C
	public void set_open(bool value) { }

	// RVA: 0x85B6688 Offset: 0x85B2688 VA: 0x85B6688
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DebugManager.<>c // TypeDefIndex: 19868
{
	// Fields
	public static readonly DebugManager.<>c <>9; // 0x0
	public static Action<bool> <>9__48_0; // 0x8
	public static Action <>9__48_1; // 0x10
	public static Func<DebugUI.Widget, int> <>9__59_0; // 0x18

	// Methods

	// RVA: 0x85B8E30 Offset: 0x85B4E30 VA: 0x85B8E30
	private static void .cctor() { }

	// RVA: 0x85B8E98 Offset: 0x85B4E98 VA: 0x85B8E98
	public void .ctor() { }

	// RVA: 0x85B8EA0 Offset: 0x85B4EA0 VA: 0x85B8EA0
	internal void <.ctor>b__48_0(bool <p0>) { }

	// RVA: 0x85B8EA4 Offset: 0x85B4EA4 VA: 0x85B8EA4
	internal void <.ctor>b__48_1() { }

	// RVA: 0x85B8EA8 Offset: 0x85B4EA8 VA: 0x85B8EA8
	internal int <TogglePersistent>b__59_0(DebugUI.Widget w) { }

	// RVA: 0x85B8F24 Offset: 0x85B4F24 VA: 0x85B8F24
	internal DebugManager <.cctor>b__94_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugManager.<>c__DisplayClass66_0 // TypeDefIndex: 19869
{
	// Fields
	public string displayName; // 0x10

	// Methods

	// RVA: 0x85B7788 Offset: 0x85B3788 VA: 0x85B7788
	public void .ctor() { }

	// RVA: 0x85B8F74 Offset: 0x85B4F74 VA: 0x85B8F74
	internal bool <FindPanelIndex>b__0(DebugUI.Panel p) { }
}

// Namespace: UnityEngine.Rendering
public sealed class DebugManager // TypeDefIndex: 19870
{
	// Fields
	private const string kEnableDebugBtn1 = "Enable Debug Button 1";
	private const string kEnableDebugBtn2 = "Enable Debug Button 2";
	private const string kDebugPreviousBtn = "Debug Previous";
	private const string kDebugNextBtn = "Debug Next";
	private const string kValidateBtn = "Debug Validate";
	private const string kPersistentBtn = "Debug Persistent";
	private const string kDPadVertical = "Debug Vertical";
	private const string kDPadHorizontal = "Debug Horizontal";
	private const string kMultiplierBtn = "Debug Multiplier";
	private const string kResetBtn = "Debug Reset";
	private const string kEnableDebug = "Enable Debug";
	private DebugActionDesc[] m_DebugActions; // 0x10
	private DebugActionState[] m_DebugActionStates; // 0x18
	private static readonly Lazy<DebugManager> s_Instance; // 0x0
	private ReadOnlyCollection<DebugUI.Panel> m_ReadOnlyPanels; // 0x20
	private readonly List<DebugUI.Panel> m_Panels; // 0x28
	[CompilerGenerated]
	private Action<bool> onDisplayRuntimeUIChanged; // 0x30
	[CompilerGenerated]
	private Action onSetDirty; // 0x38
	[CompilerGenerated]
	private Action resetData; // 0x40
	public bool refreshEditorRequested; // 0x48
	private Nullable<int> m_RequestedPanelIndex; // 0x4C
	private GameObject m_Root; // 0x58
	private DebugUIHandlerCanvas m_RootUICanvas; // 0x60
	private GameObject m_PersistentRoot; // 0x68
	private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas; // 0x70
	[CompilerGenerated]
	private static Action<DebugManager.UIMode, bool> windowStateChanged; // 0x8
	private DebugManager.UIState editorUIState; // 0x78
	private bool m_EnableRuntimeUI; // 0x80
	private DebugManager.UIState runtimeUIState; // 0x88

	// Properties
	public static DebugManager instance { get; }
	public ReadOnlyCollection<DebugUI.Panel> panels { get; }
	public bool isAnyDebugUIActive { get; }
	public bool displayEditorUI { get; set; }
	public bool enableRuntimeUI { get; set; }
	public bool displayRuntimeUI { get; set; }
	public bool displayPersistentRuntimeUI { get; set; }

	// Methods

	// RVA: 0x85B49AC Offset: 0x85B09AC VA: 0x85B49AC
	private void RegisterActions() { }

	// RVA: 0x85B5460 Offset: 0x85B1460 VA: 0x85B5460
	internal void EnableInputActions() { }

	// RVA: 0x85B536C Offset: 0x85B136C VA: 0x85B536C
	private void AddAction(DebugAction action, DebugActionDesc desc) { }

	// RVA: 0x85B54BC Offset: 0x85B14BC VA: 0x85B54BC
	private void SampleAction(int actionIndex) { }

	// RVA: 0x85B5A1C Offset: 0x85B1A1C VA: 0x85B5A1C
	private void UpdateAction(int actionIndex) { }

	// RVA: 0x85B5C98 Offset: 0x85B1C98 VA: 0x85B5C98
	internal void UpdateActions() { }

	// RVA: 0x85B5CF0 Offset: 0x85B1CF0 VA: 0x85B5CF0
	internal float GetAction(DebugAction action) { }

	// RVA: 0x85B5D28 Offset: 0x85B1D28 VA: 0x85B5D28
	internal bool GetActionToggleDebugMenuWithTouch() { }

	// RVA: 0x85B5E78 Offset: 0x85B1E78 VA: 0x85B5E78
	internal bool GetActionReleaseScrollTarget() { }

	// RVA: 0x85B5F04 Offset: 0x85B1F04 VA: 0x85B5F04
	private void RegisterInputs() { }

	// RVA: 0x85AA10C Offset: 0x85A610C VA: 0x85AA10C
	public static DebugManager get_instance() { }

	// RVA: 0x85B5F08 Offset: 0x85B1F08 VA: 0x85B5F08
	private void UpdateReadOnlyCollection() { }

	// RVA: 0x85B5F8C Offset: 0x85B1F8C VA: 0x85B5F8C
	public ReadOnlyCollection<DebugUI.Panel> get_panels() { }

	[CompilerGenerated]
	// RVA: 0x85B5FB0 Offset: 0x85B1FB0 VA: 0x85B5FB0
	public void add_onDisplayRuntimeUIChanged(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x85B6060 Offset: 0x85B2060 VA: 0x85B6060
	public void remove_onDisplayRuntimeUIChanged(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x85B6110 Offset: 0x85B2110 VA: 0x85B6110
	public void add_onSetDirty(Action value) { }

	[CompilerGenerated]
	// RVA: 0x85B61AC Offset: 0x85B21AC VA: 0x85B61AC
	public void remove_onSetDirty(Action value) { }

	[CompilerGenerated]
	// RVA: 0x85B6248 Offset: 0x85B2248 VA: 0x85B6248
	private void add_resetData(Action value) { }

	[CompilerGenerated]
	// RVA: 0x85B62E4 Offset: 0x85B22E4 VA: 0x85B62E4
	private void remove_resetData(Action value) { }

	// RVA: 0x85B6380 Offset: 0x85B2380 VA: 0x85B6380
	public bool get_isAnyDebugUIActive() { }

	// RVA: 0x85B6430 Offset: 0x85B2430 VA: 0x85B6430
	private void .ctor() { }

	// RVA: 0x85AEC70 Offset: 0x85AAC70 VA: 0x85AEC70
	public void RefreshEditor() { }

	// RVA: 0x85B6690 Offset: 0x85B2690 VA: 0x85B6690
	public void Reset() { }

	// RVA: 0x85B2554 Offset: 0x85AE554 VA: 0x85B2554
	public void ReDrawOnScreenDebug() { }

	// RVA: 0x85AEC84 Offset: 0x85AAC84 VA: 0x85AEC84
	public void RegisterData(IDebugData data) { }

	// RVA: 0x85AED30 Offset: 0x85AAD30 VA: 0x85AED30
	public void UnregisterData(IDebugData data) { }

	// RVA: 0x85B66BC Offset: 0x85B26BC VA: 0x85B66BC
	public int GetState() { }

	// RVA: 0x85B6824 Offset: 0x85B2824 VA: 0x85B6824
	internal void RegisterRootCanvas(DebugUIHandlerCanvas root) { }

	// RVA: 0x85B6870 Offset: 0x85B2870 VA: 0x85B6870
	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	// RVA: 0x85B6890 Offset: 0x85B2890 VA: 0x85B6890
	internal void SetScrollTarget(DebugUIHandlerWidget widget) { }

	// RVA: 0x85B6928 Offset: 0x85B2928 VA: 0x85B6928
	private void EnsurePersistentCanvas() { }

	// RVA: 0x85B6B54 Offset: 0x85B2B54 VA: 0x85B6B54
	internal void TogglePersistent(DebugUI.Widget widget, Nullable<int> forceTupleIndex) { }

	// RVA: 0x85B70C4 Offset: 0x85B30C4 VA: 0x85B70C4
	private void OnPanelDirty(DebugUI.Panel panel) { }

	// RVA: 0x85B70E8 Offset: 0x85B30E8 VA: 0x85B70E8
	public int PanelIndex(string displayName) { }

	// RVA: 0x85B71C0 Offset: 0x85B31C0 VA: 0x85B71C0
	public string PanelDiplayName(int panelIndex) { }

	// RVA: 0x85B7268 Offset: 0x85B3268 VA: 0x85B7268
	public void RequestEditorWindowPanelIndex(int index) { }

	// RVA: 0x85B72D0 Offset: 0x85B32D0 VA: 0x85B72D0
	internal Nullable<int> GetRequestedEditorWindowPanelIndex() { }

	// RVA: 0x85AA184 Offset: 0x85A6184 VA: 0x85AA184
	public DebugUI.Panel GetPanel(string displayName, bool createIfNull = False, int groupIndex = 0, bool overrideIfExist = False) { }

	// RVA: 0x85B76A4 Offset: 0x85B36A4 VA: 0x85B76A4
	public int FindPanelIndex(string displayName) { }

	// RVA: 0x85B7790 Offset: 0x85B3790 VA: 0x85B7790
	public void RemovePanel(string displayName) { }

	// RVA: 0x85B7390 Offset: 0x85B3390 VA: 0x85B7390
	public void RemovePanel(DebugUI.Panel panel) { }

	// RVA: 0x85B7948 Offset: 0x85B3948 VA: 0x85B7948
	public DebugUI.Widget[] GetItems(DebugUI.Flags flags) { }

	// RVA: 0x85B7BEC Offset: 0x85B3BEC VA: 0x85B7BEC
	internal DebugUI.Widget[] GetItemsFromContainer(DebugUI.Flags flags, DebugUI.IContainer container) { }

	// RVA: 0x85B8138 Offset: 0x85B4138 VA: 0x85B8138
	public DebugUI.Widget GetItem(string queryPath) { }

	// RVA: 0x85B8290 Offset: 0x85B4290 VA: 0x85B8290
	private DebugUI.Widget GetItem(string queryPath, DebugUI.IContainer container) { }

	[CompilerGenerated]
	// RVA: 0x85B85EC Offset: 0x85B45EC VA: 0x85B85EC
	public static void add_windowStateChanged(Action<DebugManager.UIMode, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x85B86E0 Offset: 0x85B46E0 VA: 0x85B86E0
	public static void remove_windowStateChanged(Action<DebugManager.UIMode, bool> value) { }

	// RVA: 0x85B87D4 Offset: 0x85B47D4 VA: 0x85B87D4
	public bool get_displayEditorUI() { }

	// RVA: 0x85B87F0 Offset: 0x85B47F0 VA: 0x85B87F0
	public void set_displayEditorUI(bool value) { }

	// RVA: 0x85B88A0 Offset: 0x85B48A0 VA: 0x85B88A0
	public bool get_enableRuntimeUI() { }

	// RVA: 0x85B88A8 Offset: 0x85B48A8 VA: 0x85B88A8
	public void set_enableRuntimeUI(bool value) { }

	// RVA: 0x85AAC3C Offset: 0x85A6C3C VA: 0x85AAC3C
	public bool get_displayRuntimeUI() { }

	// RVA: 0x85B88D8 Offset: 0x85B48D8 VA: 0x85B88D8
	public void set_displayRuntimeUI(bool value) { }

	// RVA: 0x85B63A8 Offset: 0x85B23A8 VA: 0x85B63A8
	public bool get_displayPersistentRuntimeUI() { }

	// RVA: 0x85B8C58 Offset: 0x85B4C58 VA: 0x85B8C58
	public void set_displayPersistentRuntimeUI(bool value) { }

	[Obsolete("Use DebugManager.instance.displayEditorUI.open property instead. #from(23.1)")]
	// RVA: 0x85B8CF4 Offset: 0x85B4CF4 VA: 0x85B8CF4
	public void ToggleEditorUI(bool open) { }

	// RVA: 0x85B8D10 Offset: 0x85B4D10 VA: 0x85B8D10
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
internal class DebugActionDesc // TypeDefIndex: 19871
{
	// Fields
	public string axisTrigger; // 0x10
	public List<string[]> buttonTriggerList; // 0x18
	public List<KeyCode[]> keyTriggerList; // 0x20
	public DebugActionRepeatMode repeatMode; // 0x28
	public float repeatDelay; // 0x2C

	// Methods

	// RVA: 0x85B526C Offset: 0x85B126C VA: 0x85B526C
	public void .ctor() { }
}

// Namespace: 
private enum DebugActionState.DebugActionKeyType // TypeDefIndex: 19872
{
	// Fields
	public int value__; // 0x0
	public const DebugActionState.DebugActionKeyType Button = 0;
	public const DebugActionState.DebugActionKeyType Axis = 1;
	public const DebugActionState.DebugActionKeyType Key = 2;
}

// Namespace: UnityEngine.Rendering
internal class DebugActionState // TypeDefIndex: 19873
{
	// Fields
	private DebugActionState.DebugActionKeyType m_Type; // 0x10
	private string[] m_PressedButtons; // 0x18
	private string m_PressedAxis; // 0x20
	private KeyCode[] m_PressedKeys; // 0x28
	private bool[] m_TriggerPressedUp; // 0x30
	private float m_Timer; // 0x38
	[CompilerGenerated]
	private bool <runningAction>k__BackingField; // 0x3C
	[CompilerGenerated]
	private float <actionState>k__BackingField; // 0x40

	// Properties
	internal bool runningAction { get; set; }
	internal float actionState { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85B8F98 Offset: 0x85B4F98 VA: 0x85B8F98
	internal bool get_runningAction() { }

	[CompilerGenerated]
	// RVA: 0x85B8FA0 Offset: 0x85B4FA0 VA: 0x85B8FA0
	private void set_runningAction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85B8FAC Offset: 0x85B4FAC VA: 0x85B8FAC
	internal float get_actionState() { }

	[CompilerGenerated]
	// RVA: 0x85B8FB4 Offset: 0x85B4FB4 VA: 0x85B8FB4
	private void set_actionState(float value) { }

	// RVA: 0x85B8FBC Offset: 0x85B4FBC VA: 0x85B8FBC
	private void Trigger(int triggerCount, float state) { }

	// RVA: 0x85B58C0 Offset: 0x85B18C0 VA: 0x85B58C0
	public void TriggerWithButton(string[] buttons, float state) { }

	// RVA: 0x85B5950 Offset: 0x85B1950 VA: 0x85B5950
	public void TriggerWithAxis(string axis, float state) { }

	// RVA: 0x85B5988 Offset: 0x85B1988 VA: 0x85B5988
	public void TriggerWithKey(KeyCode[] keys, float state) { }

	// RVA: 0x85B9084 Offset: 0x85B5084 VA: 0x85B9084
	private void Reset() { }

	// RVA: 0x85B5A80 Offset: 0x85B1A80 VA: 0x85B5A80
	public void Update(DebugActionDesc desc) { }

	// RVA: 0x85B5464 Offset: 0x85B1464 VA: 0x85B5464
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public interface IDebugData // TypeDefIndex: 19874
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Action GetReset();
}

// Namespace: UnityEngine.Rendering
public class DebugShapes // TypeDefIndex: 19875
{
	// Fields
	private static DebugShapes s_Instance; // 0x0
	private Mesh m_sphereMesh; // 0x10
	private Mesh m_boxMesh; // 0x18
	private Mesh m_coneMesh; // 0x20
	private Mesh m_pyramidMesh; // 0x28

	// Properties
	public static DebugShapes instance { get; }

	// Methods

	// RVA: 0x85B9098 Offset: 0x85B5098 VA: 0x85B9098
	public static DebugShapes get_instance() { }

	// RVA: 0x85B9128 Offset: 0x85B5128 VA: 0x85B9128
	private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv) { }

	// RVA: 0x85B9810 Offset: 0x85B5810 VA: 0x85B9810
	private void BuildBox(ref Mesh outputMesh, float length, float width, float height) { }

	// RVA: 0x85B9F64 Offset: 0x85B5F64 VA: 0x85B9F64
	private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides) { }

	// RVA: 0x85BA88C Offset: 0x85B688C VA: 0x85BA88C
	private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth) { }

	// RVA: 0x85BAB7C Offset: 0x85B6B7C VA: 0x85BAB7C
	private void BuildShapes() { }

	// RVA: 0x85BACB0 Offset: 0x85B6CB0 VA: 0x85BACB0
	private void RebuildResources() { }

	// RVA: 0x85BADA0 Offset: 0x85B6DA0 VA: 0x85BADA0
	public Mesh RequestSphereMesh() { }

	// RVA: 0x85BADB8 Offset: 0x85B6DB8 VA: 0x85BADB8
	public Mesh RequestBoxMesh() { }

	// RVA: 0x85BADD0 Offset: 0x85B6DD0 VA: 0x85BADD0
	public Mesh RequestConeMesh() { }

	// RVA: 0x85BADE8 Offset: 0x85B6DE8 VA: 0x85BADE8
	public Mesh RequestPyramidMesh() { }

	// RVA: 0x85B9120 Offset: 0x85B5120 VA: 0x85B9120
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Container : DebugUI.Widget, DebugUI.IContainer // TypeDefIndex: 19876
{
	// Fields
	private const string k_IDToken = "#";
	[CompilerGenerated]
	private ObservableList<DebugUI.Widget> <children>k__BackingField; // 0x48

	// Properties
	internal bool hideDisplayName { get; }
	public ObservableList<DebugUI.Widget> children { get; set; }
	public override DebugUI.Panel panel { get; set; }

	// Methods

	// RVA: 0x85BAE08 Offset: 0x85B6E08 VA: 0x85BAE08
	internal bool get_hideDisplayName() { }

	[CompilerGenerated]
	// RVA: 0x85BAE7C Offset: 0x85B6E7C VA: 0x85BAE7C Slot: 12
	public ObservableList<DebugUI.Widget> get_children() { }

	[CompilerGenerated]
	// RVA: 0x85BAE84 Offset: 0x85B6E84 VA: 0x85BAE84
	private void set_children(ObservableList<DebugUI.Widget> value) { }

	// RVA: 0x85BAE8C Offset: 0x85B6E8C VA: 0x85BAE8C Slot: 4
	public override DebugUI.Panel get_panel() { }

	// RVA: 0x85BAE94 Offset: 0x85B6E94 VA: 0x85BAE94 Slot: 5
	internal override void set_panel(DebugUI.Panel value) { }

	// RVA: 0x85BAF6C Offset: 0x85B6F6C VA: 0x85BAF6C
	public void .ctor() { }

	// RVA: 0x85BB200 Offset: 0x85B7200 VA: 0x85BB200
	public void .ctor(string id) { }

	// RVA: 0x85BB008 Offset: 0x85B7008 VA: 0x85BB008
	public void .ctor(string displayName, ObservableList<DebugUI.Widget> children) { }

	// RVA: 0x85BB2BC Offset: 0x85B72BC VA: 0x85BB2BC Slot: 11
	internal override void GenerateQueryPath() { }

	// RVA: 0x85BB478 Offset: 0x85B7478 VA: 0x85BB478 Slot: 16
	protected virtual void OnItemAdded(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x85BB5A8 Offset: 0x85B75A8 VA: 0x85BB5A8 Slot: 17
	protected virtual void OnItemRemoved(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x85BB610 Offset: 0x85B7610 VA: 0x85BB610 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
public struct DebugUI.Foldout.ContextMenuItem // TypeDefIndex: 19877
{
	// Fields
	public string displayName; // 0x0
	public Action action; // 0x8
}

// Namespace: 
public class DebugUI.Foldout : DebugUI.Container, DebugUI.IValueField // TypeDefIndex: 19878
{
	// Fields
	public bool opened; // 0x50
	public bool isHeader; // 0x51
	public List<DebugUI.Foldout.ContextMenuItem> contextMenuItems; // 0x58
	[CompilerGenerated]
	private string[] <columnLabels>k__BackingField; // 0x60
	[CompilerGenerated]
	private string[] <columnTooltips>k__BackingField; // 0x68

	// Properties
	public bool isReadOnly { get; }
	public string[] columnLabels { get; set; }
	public string[] columnTooltips { get; set; }

	// Methods

	// RVA: 0x85BB778 Offset: 0x85B7778 VA: 0x85BB778
	public bool get_isReadOnly() { }

	[CompilerGenerated]
	// RVA: 0x85BB780 Offset: 0x85B7780 VA: 0x85BB780
	public string[] get_columnLabels() { }

	[CompilerGenerated]
	// RVA: 0x85BB788 Offset: 0x85B7788 VA: 0x85BB788
	public void set_columnLabels(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x85BB790 Offset: 0x85B7790 VA: 0x85BB790
	public string[] get_columnTooltips() { }

	[CompilerGenerated]
	// RVA: 0x85BB798 Offset: 0x85B7798 VA: 0x85BB798
	public void set_columnTooltips(string[] value) { }

	// RVA: 0x85B411C Offset: 0x85B011C VA: 0x85B411C
	public void .ctor() { }

	// RVA: 0x85BB7A0 Offset: 0x85B77A0 VA: 0x85BB7A0
	public void .ctor(string displayName, ObservableList<DebugUI.Widget> children, string[] columnLabels, string[] columnTooltips) { }

	// RVA: 0x85BB7E0 Offset: 0x85B77E0 VA: 0x85BB7E0
	public bool GetValue() { }

	// RVA: 0x85BB7E8 Offset: 0x85B77E8 VA: 0x85BB7E8 Slot: 18
	private object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }

	// RVA: 0x85BB844 Offset: 0x85B7844 VA: 0x85BB844 Slot: 19
	public void SetValue(object value) { }

	// RVA: 0x85BB8BC Offset: 0x85B78BC VA: 0x85BB8BC Slot: 20
	public object ValidateValue(object value) { }

	// RVA: 0x85BB8C4 Offset: 0x85B78C4 VA: 0x85BB8C4
	public void SetValue(bool value) { }
}

// Namespace: 
public class DebugUI.HBox : DebugUI.Container // TypeDefIndex: 19879
{
	// Methods

	// RVA: 0x85BB8D0 Offset: 0x85B78D0 VA: 0x85BB8D0
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.VBox : DebugUI.Container // TypeDefIndex: 19880
{
	// Methods

	// RVA: 0x85BB924 Offset: 0x85B7924 VA: 0x85BB924
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Table.Row : DebugUI.Foldout // TypeDefIndex: 19881
{
	// Methods

	// RVA: 0x85B1B60 Offset: 0x85ADB60 VA: 0x85B1B60
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Table : DebugUI.Container // TypeDefIndex: 19882
{
	// Fields
	public bool isReadOnly; // 0x50
	private bool[] m_Header; // 0x58

	// Properties
	public bool[] VisibleColumns { get; }

	// Methods

	// RVA: 0x85B0BD0 Offset: 0x85ACBD0 VA: 0x85B0BD0
	public void .ctor() { }

	// RVA: 0x85B1A2C Offset: 0x85ADA2C VA: 0x85B1A2C
	public void SetColumnVisibility(int index, bool visible) { }

	// RVA: 0x85BBBB8 Offset: 0x85B7BB8 VA: 0x85BBBB8
	public bool GetColumnVisibility(int index) { }

	// RVA: 0x85BB978 Offset: 0x85B7978 VA: 0x85BB978
	public bool[] get_VisibleColumns() { }

	// RVA: 0x85BBC04 Offset: 0x85B7C04 VA: 0x85BBC04 Slot: 16
	protected override void OnItemAdded(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x85BBC24 Offset: 0x85B7C24 VA: 0x85BBC24 Slot: 17
	protected override void OnItemRemoved(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }
}

// Namespace: 
[Flags]
public enum DebugUI.Flags // TypeDefIndex: 19883
{
	// Fields
	public int value__; // 0x0
	public const DebugUI.Flags None = 0;
	public const DebugUI.Flags EditorOnly = 2;
	public const DebugUI.Flags RuntimeOnly = 4;
	public const DebugUI.Flags EditorForceUpdate = 8;
	public const DebugUI.Flags FrequentlyUsed = 16;
}

// Namespace: 
public struct DebugUI.Widget.NameAndTooltip // TypeDefIndex: 19884
{
	// Fields
	public string name; // 0x0
	public string tooltip; // 0x8
}

// Namespace: 
public abstract class DebugUI.Widget // TypeDefIndex: 19885
{
	// Fields
	protected DebugUI.Panel m_Panel; // 0x10
	protected DebugUI.IContainer m_Parent; // 0x18
	[CompilerGenerated]
	private DebugUI.Flags <flags>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <displayName>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <tooltip>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <queryPath>k__BackingField; // 0x38
	public Func<bool> isHiddenCallback; // 0x40

	// Properties
	public virtual DebugUI.Panel panel { get; set; }
	public virtual DebugUI.IContainer parent { get; set; }
	public DebugUI.Flags flags { get; set; }
	public string displayName { get; set; }
	public string tooltip { get; set; }
	public string queryPath { get; set; }
	public bool isEditorOnly { get; }
	public bool isRuntimeOnly { get; }
	public bool isInactiveInEditor { get; }
	public bool isHidden { get; }
	public DebugUI.Widget.NameAndTooltip nameAndTooltip { set; }

	// Methods

	// RVA: 0x85BBC44 Offset: 0x85B7C44 VA: 0x85BBC44 Slot: 4
	public virtual DebugUI.Panel get_panel() { }

	// RVA: 0x85BBC4C Offset: 0x85B7C4C VA: 0x85BBC4C Slot: 5
	internal virtual void set_panel(DebugUI.Panel value) { }

	// RVA: 0x85BBC54 Offset: 0x85B7C54 VA: 0x85BBC54 Slot: 6
	public virtual DebugUI.IContainer get_parent() { }

	// RVA: 0x85BBC5C Offset: 0x85B7C5C VA: 0x85BBC5C Slot: 7
	internal virtual void set_parent(DebugUI.IContainer value) { }

	[CompilerGenerated]
	// RVA: 0x85BBC64 Offset: 0x85B7C64 VA: 0x85BBC64
	public DebugUI.Flags get_flags() { }

	[CompilerGenerated]
	// RVA: 0x85BBC6C Offset: 0x85B7C6C VA: 0x85BBC6C
	public void set_flags(DebugUI.Flags value) { }

	[CompilerGenerated]
	// RVA: 0x85BBC74 Offset: 0x85B7C74 VA: 0x85BBC74 Slot: 8
	public string get_displayName() { }

	[CompilerGenerated]
	// RVA: 0x85BBC7C Offset: 0x85B7C7C VA: 0x85BBC7C Slot: 9
	public void set_displayName(string value) { }

	[CompilerGenerated]
	// RVA: 0x85BBC84 Offset: 0x85B7C84 VA: 0x85BBC84
	public string get_tooltip() { }

	[CompilerGenerated]
	// RVA: 0x85BBC8C Offset: 0x85B7C8C VA: 0x85BBC8C
	public void set_tooltip(string value) { }

	[CompilerGenerated]
	// RVA: 0x85BBC94 Offset: 0x85B7C94 VA: 0x85BBC94 Slot: 10
	public string get_queryPath() { }

	[CompilerGenerated]
	// RVA: 0x85BBC9C Offset: 0x85B7C9C VA: 0x85BBC9C
	private void set_queryPath(string value) { }

	// RVA: 0x85BBCA4 Offset: 0x85B7CA4 VA: 0x85BBCA4
	public bool get_isEditorOnly() { }

	// RVA: 0x85BBCB0 Offset: 0x85B7CB0 VA: 0x85BBCB0
	public bool get_isRuntimeOnly() { }

	// RVA: 0x85BBCBC Offset: 0x85B7CBC VA: 0x85BBCBC
	public bool get_isInactiveInEditor() { }

	// RVA: 0x85BB758 Offset: 0x85B7758 VA: 0x85BB758
	public bool get_isHidden() { }

	// RVA: 0x85BB374 Offset: 0x85B7374 VA: 0x85BB374 Slot: 11
	internal virtual void GenerateQueryPath() { }

	// RVA: 0x85BBD2C Offset: 0x85B7D2C VA: 0x85BBD2C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x85B1A88 Offset: 0x85ADA88 VA: 0x85B1A88
	public void set_nameAndTooltip(DebugUI.Widget.NameAndTooltip value) { }

	// RVA: 0x85BB2B4 Offset: 0x85B72B4 VA: 0x85BB2B4
	protected void .ctor() { }
}

// Namespace: 
public interface DebugUI.IContainer // TypeDefIndex: 19886
{
	// Properties
	public abstract ObservableList<DebugUI.Widget> children { get; }
	public abstract string displayName { get; set; }
	public abstract string queryPath { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ObservableList<DebugUI.Widget> get_children();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_displayName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_displayName(string value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_queryPath();
}

// Namespace: 
public interface DebugUI.IValueField // TypeDefIndex: 19887
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetValue();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetValue(object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object ValidateValue(object value);
}

// Namespace: 
public class DebugUI.Button : DebugUI.Widget // TypeDefIndex: 19888
{
	// Fields
	[CompilerGenerated]
	private Action <action>k__BackingField; // 0x48

	// Properties
	public Action action { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85BBDD4 Offset: 0x85B7DD4 VA: 0x85BBDD4
	public Action get_action() { }

	[CompilerGenerated]
	// RVA: 0x85BBDDC Offset: 0x85B7DDC VA: 0x85BBDDC
	public void set_action(Action value) { }

	// RVA: 0x85BBDE4 Offset: 0x85B7DE4 VA: 0x85BBDE4
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Value : DebugUI.Widget // TypeDefIndex: 19889
{
	// Fields
	[CompilerGenerated]
	private Func<object> <getter>k__BackingField; // 0x48
	public float refreshRate; // 0x50
	public string formatString; // 0x58

	// Properties
	public Func<object> getter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85BBDEC Offset: 0x85B7DEC VA: 0x85BBDEC
	public Func<object> get_getter() { }

	[CompilerGenerated]
	// RVA: 0x85BBDF4 Offset: 0x85B7DF4 VA: 0x85BBDF4
	public void set_getter(Func<object> value) { }

	// RVA: 0x85B00F4 Offset: 0x85AC0F4 VA: 0x85B00F4
	public void .ctor() { }

	// RVA: 0x85BBDFC Offset: 0x85B7DFC VA: 0x85BBDFC Slot: 12
	public virtual object GetValue() { }

	// RVA: 0x85BBE20 Offset: 0x85B7E20 VA: 0x85BBE20 Slot: 13
	public virtual string FormatString(object value) { }
}

// Namespace: 
public class DebugUI.ProgressBarValue : DebugUI.Value // TypeDefIndex: 19890
{
	// Fields
	public float min; // 0x60
	public float max; // 0x64

	// Methods

	// RVA: 0x85BBE8C Offset: 0x85B7E8C VA: 0x85BBE8C Slot: 13
	public override string FormatString(object value) { }

	// RVA: 0x85B4130 Offset: 0x85B0130 VA: 0x85B4130
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x85BBF70 Offset: 0x85B7F70 VA: 0x85BBF70
	internal static float <FormatString>g__Remap01|2_0(float v, float x0, float y0) { }
}

// Namespace: 
public class DebugUI.ValueTuple : DebugUI.Widget // TypeDefIndex: 19891
{
	// Fields
	public DebugUI.Value[] values; // 0x48
	public int pinnedElementIndex; // 0x50

	// Properties
	public int numElements { get; }
	public float refreshRate { get; }

	// Methods

	// RVA: 0x85BBF80 Offset: 0x85B7F80 VA: 0x85BBF80
	public int get_numElements() { }

	// RVA: 0x85BBF9C Offset: 0x85B7F9C VA: 0x85BBF9C
	public float get_refreshRate() { }

	// RVA: 0x85B4120 Offset: 0x85B0120 VA: 0x85B4120
	public void .ctor() { }
}

// Namespace: 
public abstract class DebugUI.Field<T> : DebugUI.Widget, DebugUI.IValueField // TypeDefIndex: 19892
{
	// Fields
	[CompilerGenerated]
	private Func<T> <getter>k__BackingField; // 0x0
	[CompilerGenerated]
	private Action<T> <setter>k__BackingField; // 0x0
	public Action<DebugUI.Field<T>, T> onValueChanged; // 0x0

	// Properties
	public Func<T> getter { get; set; }
	public Action<T> setter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<T> get_getter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F0E4 Offset: 0x634B0E4 VA: 0x634F0E4
	|-DebugUI.Field<bool>.get_getter
	|
	|-RVA: 0x634F3BC Offset: 0x634B3BC VA: 0x634F3BC
	|-DebugUI.Field<Color>.get_getter
	|
	|-RVA: 0x634F6F4 Offset: 0x634B6F4 VA: 0x634F6F4
	|-DebugUI.Field<int>.get_getter
	|
	|-RVA: 0x634F968 Offset: 0x634B968 VA: 0x634F968
	|-DebugUI.Field<object>.get_getter
	|
	|-RVA: 0x634FB70 Offset: 0x634BB70 VA: 0x634FB70
	|-DebugUI.Field<float>.get_getter
	|
	|-RVA: 0x634FDE0 Offset: 0x634BDE0 VA: 0x634FDE0
	|-DebugUI.Field<uint>.get_getter
	|
	|-RVA: 0x6350054 Offset: 0x634C054 VA: 0x6350054
	|-DebugUI.Field<Vector2>.get_getter
	|
	|-RVA: 0x6350330 Offset: 0x634C330 VA: 0x6350330
	|-DebugUI.Field<Vector3>.get_getter
	|
	|-RVA: 0x6350640 Offset: 0x634C640 VA: 0x6350640
	|-DebugUI.Field<Vector4>.get_getter
	|
	|-RVA: 0x6350968 Offset: 0x634C968 VA: 0x6350968
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.get_getter
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_getter(Func<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F0EC Offset: 0x634B0EC VA: 0x634F0EC
	|-DebugUI.Field<bool>.set_getter
	|
	|-RVA: 0x634F3C4 Offset: 0x634B3C4 VA: 0x634F3C4
	|-DebugUI.Field<Color>.set_getter
	|
	|-RVA: 0x634F6FC Offset: 0x634B6FC VA: 0x634F6FC
	|-DebugUI.Field<int>.set_getter
	|
	|-RVA: 0x634F970 Offset: 0x634B970 VA: 0x634F970
	|-DebugUI.Field<object>.set_getter
	|
	|-RVA: 0x634FB78 Offset: 0x634BB78 VA: 0x634FB78
	|-DebugUI.Field<float>.set_getter
	|
	|-RVA: 0x634FDE8 Offset: 0x634BDE8 VA: 0x634FDE8
	|-DebugUI.Field<uint>.set_getter
	|
	|-RVA: 0x635005C Offset: 0x634C05C VA: 0x635005C
	|-DebugUI.Field<Vector2>.set_getter
	|
	|-RVA: 0x6350338 Offset: 0x634C338 VA: 0x6350338
	|-DebugUI.Field<Vector3>.set_getter
	|
	|-RVA: 0x6350648 Offset: 0x634C648 VA: 0x6350648
	|-DebugUI.Field<Vector4>.set_getter
	|
	|-RVA: 0x6350970 Offset: 0x634C970 VA: 0x6350970
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.set_getter
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Action<T> get_setter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F0F4 Offset: 0x634B0F4 VA: 0x634F0F4
	|-DebugUI.Field<bool>.get_setter
	|
	|-RVA: 0x634F3CC Offset: 0x634B3CC VA: 0x634F3CC
	|-DebugUI.Field<Color>.get_setter
	|
	|-RVA: 0x634F704 Offset: 0x634B704 VA: 0x634F704
	|-DebugUI.Field<int>.get_setter
	|
	|-RVA: 0x634F978 Offset: 0x634B978 VA: 0x634F978
	|-DebugUI.Field<object>.get_setter
	|
	|-RVA: 0x634FB80 Offset: 0x634BB80 VA: 0x634FB80
	|-DebugUI.Field<float>.get_setter
	|
	|-RVA: 0x634FDF0 Offset: 0x634BDF0 VA: 0x634FDF0
	|-DebugUI.Field<uint>.get_setter
	|
	|-RVA: 0x6350064 Offset: 0x634C064 VA: 0x6350064
	|-DebugUI.Field<Vector2>.get_setter
	|
	|-RVA: 0x6350340 Offset: 0x634C340 VA: 0x6350340
	|-DebugUI.Field<Vector3>.get_setter
	|
	|-RVA: 0x6350650 Offset: 0x634C650 VA: 0x6350650
	|-DebugUI.Field<Vector4>.get_setter
	|
	|-RVA: 0x6350978 Offset: 0x634C978 VA: 0x6350978
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.get_setter
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_setter(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F0FC Offset: 0x634B0FC VA: 0x634F0FC
	|-DebugUI.Field<bool>.set_setter
	|
	|-RVA: 0x634F3D4 Offset: 0x634B3D4 VA: 0x634F3D4
	|-DebugUI.Field<Color>.set_setter
	|
	|-RVA: 0x634F70C Offset: 0x634B70C VA: 0x634F70C
	|-DebugUI.Field<int>.set_setter
	|
	|-RVA: 0x634F980 Offset: 0x634B980 VA: 0x634F980
	|-DebugUI.Field<object>.set_setter
	|
	|-RVA: 0x634FB88 Offset: 0x634BB88 VA: 0x634FB88
	|-DebugUI.Field<float>.set_setter
	|
	|-RVA: 0x634FDF8 Offset: 0x634BDF8 VA: 0x634FDF8
	|-DebugUI.Field<uint>.set_setter
	|
	|-RVA: 0x635006C Offset: 0x634C06C VA: 0x635006C
	|-DebugUI.Field<Vector2>.set_setter
	|
	|-RVA: 0x6350348 Offset: 0x634C348 VA: 0x6350348
	|-DebugUI.Field<Vector3>.set_setter
	|
	|-RVA: 0x6350658 Offset: 0x634C658 VA: 0x6350658
	|-DebugUI.Field<Vector4>.set_setter
	|
	|-RVA: 0x6350980 Offset: 0x634C980 VA: 0x6350980
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.set_setter
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F104 Offset: 0x634B104 VA: 0x634F104
	|-DebugUI.Field<bool>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x634F3DC Offset: 0x634B3DC VA: 0x634F3DC
	|-DebugUI.Field<Color>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x634F714 Offset: 0x634B714 VA: 0x634F714
	|-DebugUI.Field<int>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x634F988 Offset: 0x634B988 VA: 0x634F988
	|-DebugUI.Field<object>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x634FB90 Offset: 0x634BB90 VA: 0x634FB90
	|-DebugUI.Field<float>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x634FE00 Offset: 0x634BE00 VA: 0x634FE00
	|-DebugUI.Field<uint>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x6350074 Offset: 0x634C074 VA: 0x6350074
	|-DebugUI.Field<Vector2>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x6350350 Offset: 0x634C350 VA: 0x6350350
	|-DebugUI.Field<Vector3>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x6350660 Offset: 0x634C660 VA: 0x6350660
	|-DebugUI.Field<Vector4>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	|
	|-RVA: 0x6350988 Offset: 0x634C988 VA: 0x6350988
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.UnityEngine.Rendering.DebugUI.IValueField.ValidateValue
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual T ValidateValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F1A8 Offset: 0x634B1A8 VA: 0x634F1A8
	|-DebugUI.Field<bool>.ValidateValue
	|
	|-RVA: 0x634F484 Offset: 0x634B484 VA: 0x634F484
	|-DebugUI.Field<Color>.ValidateValue
	|
	|-RVA: 0x634F7B4 Offset: 0x634B7B4 VA: 0x634F7B4
	|-DebugUI.Field<int>.ValidateValue
	|
	|-RVA: 0x634F9FC Offset: 0x634B9FC VA: 0x634F9FC
	|-DebugUI.Field<object>.ValidateValue
	|
	|-RVA: 0x634FC30 Offset: 0x634BC30 VA: 0x634FC30
	|-DebugUI.Field<float>.ValidateValue
	|
	|-RVA: 0x634FEA0 Offset: 0x634BEA0 VA: 0x634FEA0
	|-DebugUI.Field<uint>.ValidateValue
	|
	|-RVA: 0x6350114 Offset: 0x634C114 VA: 0x6350114
	|-DebugUI.Field<Vector2>.ValidateValue
	|
	|-RVA: 0x63503F8 Offset: 0x634C3F8 VA: 0x63503F8
	|-DebugUI.Field<Vector3>.ValidateValue
	|
	|-RVA: 0x6350708 Offset: 0x634C708 VA: 0x6350708
	|-DebugUI.Field<Vector4>.ValidateValue
	|
	|-RVA: 0x6350A80 Offset: 0x634CA80 VA: 0x6350A80
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.ValidateValue
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F1B0 Offset: 0x634B1B0 VA: 0x634F1B0
	|-DebugUI.Field<bool>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x634F488 Offset: 0x634B488 VA: 0x634F488
	|-DebugUI.Field<Color>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x634F7BC Offset: 0x634B7BC VA: 0x634F7BC
	|-DebugUI.Field<int>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x634FA04 Offset: 0x634BA04 VA: 0x634FA04
	|-DebugUI.Field<object>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x634FC34 Offset: 0x634BC34 VA: 0x634FC34
	|-DebugUI.Field<float>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x634FEA8 Offset: 0x634BEA8 VA: 0x634FEA8
	|-DebugUI.Field<uint>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x6350118 Offset: 0x634C118 VA: 0x6350118
	|-DebugUI.Field<Vector2>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x63503FC Offset: 0x634C3FC VA: 0x63503FC
	|-DebugUI.Field<Vector3>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x635070C Offset: 0x634C70C VA: 0x635070C
	|-DebugUI.Field<Vector4>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	|
	|-RVA: 0x6350B20 Offset: 0x634CB20 VA: 0x6350B20
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.UnityEngine.Rendering.DebugUI.IValueField.GetValue
	*/

	// RVA: -1 Offset: -1
	public T GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F200 Offset: 0x634B200 VA: 0x634F200
	|-DebugUI.Field<bool>.GetValue
	|
	|-RVA: 0x634F4D8 Offset: 0x634B4D8 VA: 0x634F4D8
	|-DebugUI.Field<Color>.GetValue
	|
	|-RVA: 0x634F808 Offset: 0x634B808 VA: 0x634F808
	|-DebugUI.Field<int>.GetValue
	|
	|-RVA: 0x634FA28 Offset: 0x634BA28 VA: 0x634FA28
	|-DebugUI.Field<object>.GetValue
	|
	|-RVA: 0x634FC80 Offset: 0x634BC80 VA: 0x634FC80
	|-DebugUI.Field<float>.GetValue
	|
	|-RVA: 0x634FEF4 Offset: 0x634BEF4 VA: 0x634FEF4
	|-DebugUI.Field<uint>.GetValue
	|
	|-RVA: 0x6350164 Offset: 0x634C164 VA: 0x6350164
	|-DebugUI.Field<Vector2>.GetValue
	|
	|-RVA: 0x635044C Offset: 0x634C44C VA: 0x635044C
	|-DebugUI.Field<Vector3>.GetValue
	|
	|-RVA: 0x635075C Offset: 0x634C75C VA: 0x635075C
	|-DebugUI.Field<Vector4>.GetValue
	|
	|-RVA: 0x6350BC4 Offset: 0x634CBC4 VA: 0x6350BC4
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void SetValue(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F224 Offset: 0x634B224 VA: 0x634F224
	|-DebugUI.Field<bool>.SetValue
	|
	|-RVA: 0x634F4FC Offset: 0x634B4FC VA: 0x634F4FC
	|-DebugUI.Field<Color>.SetValue
	|
	|-RVA: 0x634F82C Offset: 0x634B82C VA: 0x634F82C
	|-DebugUI.Field<int>.SetValue
	|
	|-RVA: 0x634FA4C Offset: 0x634BA4C VA: 0x634FA4C
	|-DebugUI.Field<object>.SetValue
	|
	|-RVA: 0x634FCA4 Offset: 0x634BCA4 VA: 0x634FCA4
	|-DebugUI.Field<float>.SetValue
	|
	|-RVA: 0x634FF18 Offset: 0x634BF18 VA: 0x634FF18
	|-DebugUI.Field<uint>.SetValue
	|
	|-RVA: 0x6350188 Offset: 0x634C188 VA: 0x6350188
	|-DebugUI.Field<Vector2>.SetValue
	|
	|-RVA: 0x6350470 Offset: 0x634C470 VA: 0x6350470
	|-DebugUI.Field<Vector3>.SetValue
	|
	|-RVA: 0x6350780 Offset: 0x634C780 VA: 0x6350780
	|-DebugUI.Field<Vector4>.SetValue
	|
	|-RVA: 0x6350C8C Offset: 0x634CC8C VA: 0x6350C8C
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual void SetValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F29C Offset: 0x634B29C VA: 0x634F29C
	|-DebugUI.Field<bool>.SetValue
	|
	|-RVA: 0x634F578 Offset: 0x634B578 VA: 0x634F578
	|-DebugUI.Field<Color>.SetValue
	|
	|-RVA: 0x634F8A4 Offset: 0x634B8A4 VA: 0x634F8A4
	|-DebugUI.Field<int>.SetValue
	|
	|-RVA: 0x634FAC0 Offset: 0x634BAC0 VA: 0x634FAC0
	|-DebugUI.Field<object>.SetValue
	|
	|-RVA: 0x634FD1C Offset: 0x634BD1C VA: 0x634FD1C
	|-DebugUI.Field<float>.SetValue
	|
	|-RVA: 0x634FF90 Offset: 0x634BF90 VA: 0x634FF90
	|-DebugUI.Field<uint>.SetValue
	|
	|-RVA: 0x6350200 Offset: 0x634C200 VA: 0x6350200
	|-DebugUI.Field<Vector2>.SetValue
	|
	|-RVA: 0x63504EC Offset: 0x634C4EC VA: 0x63504EC
	|-DebugUI.Field<Vector3>.SetValue
	|
	|-RVA: 0x63507FC Offset: 0x634C7FC VA: 0x63507FC
	|-DebugUI.Field<Vector4>.SetValue
	|
	|-RVA: 0x6350D64 Offset: 0x634CD64 VA: 0x6350D64
	|-DebugUI.Field<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x634F3B4 Offset: 0x634B3B4 VA: 0x634F3B4
	|-DebugUI.Field<bool>..ctor
	|
	|-RVA: 0x634F6EC Offset: 0x634B6EC VA: 0x634F6EC
	|-DebugUI.Field<Color>..ctor
	|
	|-RVA: 0x634F960 Offset: 0x634B960 VA: 0x634F960
	|-DebugUI.Field<int>..ctor
	|
	|-RVA: 0x634FB68 Offset: 0x634BB68 VA: 0x634FB68
	|-DebugUI.Field<object>..ctor
	|
	|-RVA: 0x634FDD8 Offset: 0x634BDD8 VA: 0x634FDD8
	|-DebugUI.Field<float>..ctor
	|
	|-RVA: 0x635004C Offset: 0x634C04C VA: 0x635004C
	|-DebugUI.Field<uint>..ctor
	|
	|-RVA: 0x6350328 Offset: 0x634C328 VA: 0x6350328
	|-DebugUI.Field<Vector2>..ctor
	|
	|-RVA: 0x6350638 Offset: 0x634C638 VA: 0x6350638
	|-DebugUI.Field<Vector3>..ctor
	|
	|-RVA: 0x6350960 Offset: 0x634C960 VA: 0x6350960
	|-DebugUI.Field<Vector4>..ctor
	|
	|-RVA: 0x6351068 Offset: 0x634D068 VA: 0x6351068
	|-DebugUI.Field<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class DebugUI.BoolField : DebugUI.Field<bool> // TypeDefIndex: 19893
{
	// Methods

	// RVA: 0x85BBFFC Offset: 0x85B7FFC VA: 0x85BBFFC
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.HistoryBoolField : DebugUI.BoolField // TypeDefIndex: 19894
{
	// Fields
	[CompilerGenerated]
	private Func<bool>[] <historyGetter>k__BackingField; // 0x60

	// Properties
	public Func<bool>[] historyGetter { get; set; }
	public int historyDepth { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85BC044 Offset: 0x85B8044 VA: 0x85BC044
	public Func<bool>[] get_historyGetter() { }

	[CompilerGenerated]
	// RVA: 0x85BC04C Offset: 0x85B804C VA: 0x85BC04C
	public void set_historyGetter(Func<bool>[] value) { }

	// RVA: 0x85BC054 Offset: 0x85B8054 VA: 0x85BC054
	public int get_historyDepth() { }

	// RVA: 0x85BC06C Offset: 0x85B806C VA: 0x85BC06C
	public bool GetHistoryValue(int historyIndex) { }

	// RVA: 0x85BC0AC Offset: 0x85B80AC VA: 0x85BC0AC
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.IntField : DebugUI.Field<int> // TypeDefIndex: 19895
{
	// Fields
	public Func<int> min; // 0x60
	public Func<int> max; // 0x68
	public int incStep; // 0x70
	public int intStepMult; // 0x74

	// Methods

	// RVA: 0x85BC0B0 Offset: 0x85B80B0 VA: 0x85BC0B0 Slot: 15
	public override int ValidateValue(int value) { }

	// RVA: 0x85BC110 Offset: 0x85B8110 VA: 0x85BC110
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.UIntField : DebugUI.Field<uint> // TypeDefIndex: 19896
{
	// Fields
	public Func<uint> min; // 0x60
	public Func<uint> max; // 0x68
	public uint incStep; // 0x70
	public uint intStepMult; // 0x74

	// Methods

	// RVA: 0x85BC164 Offset: 0x85B8164 VA: 0x85BC164 Slot: 15
	public override uint ValidateValue(uint value) { }

	// RVA: 0x85BC1C4 Offset: 0x85B81C4 VA: 0x85BC1C4
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.FloatField : DebugUI.Field<float> // TypeDefIndex: 19897
{
	// Fields
	public Func<float> min; // 0x60
	public Func<float> max; // 0x68
	public float incStep; // 0x70
	public float incStepMult; // 0x74
	public int decimals; // 0x78

	// Methods

	// RVA: 0x85BC218 Offset: 0x85B8218 VA: 0x85BC218 Slot: 15
	public override float ValidateValue(float value) { }

	// RVA: 0x85BC278 Offset: 0x85B8278 VA: 0x85BC278
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DebugUI.EnumField.<>c<T> // TypeDefIndex: 19898
{
	// Fields
	public static readonly DebugUI.EnumField.<>c<T> <>9; // 0x0
	public static Func<FieldInfo, bool> <>9__6_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4821D88 Offset: 0x481DD88 VA: 0x4821D88
	|-DebugUI.EnumField.<>c<int>..cctor
	|
	|-RVA: 0x4824A58 Offset: 0x4820A58 VA: 0x4824A58
	|-DebugUI.EnumField.<>c<object>..cctor
	|
	|-RVA: 0x4829324 Offset: 0x4825324 VA: 0x4829324
	|-DebugUI.EnumField.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4821E44 Offset: 0x481DE44 VA: 0x4821E44
	|-DebugUI.EnumField.<>c<int>..ctor
	|
	|-RVA: 0x4824B14 Offset: 0x4820B14 VA: 0x4824B14
	|-DebugUI.EnumField.<>c<object>..ctor
	|
	|-RVA: 0x4829418 Offset: 0x4825418 VA: 0x4829418
	|-DebugUI.EnumField.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <AutoFillFromType>b__6_0(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4821E4C Offset: 0x481DE4C VA: 0x4821E4C
	|-DebugUI.EnumField.<>c<int>.<AutoFillFromType>b__6_0
	|
	|-RVA: 0x4824B1C Offset: 0x4820B1C VA: 0x4824B1C
	|-DebugUI.EnumField.<>c<object>.<AutoFillFromType>b__6_0
	|
	|-RVA: 0x4829420 Offset: 0x4825420 VA: 0x4829420
	|-DebugUI.EnumField.<>c<__Il2CppFullySharedGenericType>.<AutoFillFromType>b__6_0
	*/
}

// Namespace: 
public abstract class DebugUI.EnumField<T> : DebugUI.Field<T> // TypeDefIndex: 19899
{
	// Fields
	public GUIContent[] enumNames; // 0x0
	private int[] m_EnumValues; // 0x0
	private static Regex s_NicifyRegEx; // 0x0

	// Properties
	public int[] enumValues { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int[] get_enumValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B895C Offset: 0x60B495C VA: 0x60B895C
	|-DebugUI.EnumField<int>.get_enumValues
	|
	|-RVA: 0x60B95DC Offset: 0x60B55DC VA: 0x60B95DC
	|-DebugUI.EnumField<object>.get_enumValues
	|
	|-RVA: 0x60BA25C Offset: 0x60B625C VA: 0x60BA25C
	|-DebugUI.EnumField<__Il2CppFullySharedGenericType>.get_enumValues
	*/

	// RVA: -1 Offset: -1
	public void set_enumValues(int[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B8964 Offset: 0x60B4964 VA: 0x60B8964
	|-DebugUI.EnumField<int>.set_enumValues
	|
	|-RVA: 0x60B95E4 Offset: 0x60B55E4 VA: 0x60B95E4
	|-DebugUI.EnumField<object>.set_enumValues
	|
	|-RVA: 0x60BA264 Offset: 0x60B6264 VA: 0x60BA264
	|-DebugUI.EnumField<__Il2CppFullySharedGenericType>.set_enumValues
	*/

	// RVA: -1 Offset: -1
	protected void AutoFillFromType(Type enumType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B8AF4 Offset: 0x60B4AF4 VA: 0x60B8AF4
	|-DebugUI.EnumField<int>.AutoFillFromType
	|
	|-RVA: 0x60B9774 Offset: 0x60B5774 VA: 0x60B9774
	|-DebugUI.EnumField<object>.AutoFillFromType
	|
	|-RVA: 0x60BA3F4 Offset: 0x60B63F4 VA: 0x60BA3F4
	|-DebugUI.EnumField<__Il2CppFullySharedGenericType>.AutoFillFromType
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B94FC Offset: 0x60B54FC VA: 0x60B94FC
	|-DebugUI.EnumField<int>..ctor
	|
	|-RVA: 0x60BA17C Offset: 0x60B617C VA: 0x60BA17C
	|-DebugUI.EnumField<object>..ctor
	|
	|-RVA: 0x60BAE08 Offset: 0x60B6E08 VA: 0x60BAE08
	|-DebugUI.EnumField<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B950C Offset: 0x60B550C VA: 0x60B950C
	|-DebugUI.EnumField<int>..cctor
	|
	|-RVA: 0x60BA18C Offset: 0x60B618C VA: 0x60BA18C
	|-DebugUI.EnumField<object>..cctor
	|
	|-RVA: 0x60BAE1C Offset: 0x60B6E1C VA: 0x60BAE1C
	|-DebugUI.EnumField<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DebugUI.EnumField.<>c // TypeDefIndex: 19900
{
	// Fields
	public static readonly DebugUI.EnumField.<>c <>9; // 0x0
	public static Func<GUIContent, string> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x85BC798 Offset: 0x85B8798 VA: 0x85BC798
	private static void .cctor() { }

	// RVA: 0x85BC800 Offset: 0x85B8800 VA: 0x85BC800
	public void .ctor() { }

	// RVA: 0x85BC808 Offset: 0x85B8808 VA: 0x85BC808
	internal string <InitQuickSeparators>b__17_0(GUIContent x) { }
}

// Namespace: 
public class DebugUI.EnumField : DebugUI.EnumField<int> // TypeDefIndex: 19901
{
	// Fields
	internal int[] quickSeparators; // 0x70
	private int[] m_Indexes; // 0x78
	[CompilerGenerated]
	private Func<int> <getIndex>k__BackingField; // 0x80
	[CompilerGenerated]
	private Action<int> <setIndex>k__BackingField; // 0x88

	// Properties
	internal int[] indexes { get; }
	public Func<int> getIndex { get; set; }
	public Action<int> setIndex { get; set; }
	public int currentIndex { get; set; }
	public Type autoEnum { set; }

	// Methods

	// RVA: 0x85BC2D4 Offset: 0x85B82D4 VA: 0x85BC2D4
	internal int[] get_indexes() { }

	[CompilerGenerated]
	// RVA: 0x85BC360 Offset: 0x85B8360 VA: 0x85BC360
	public Func<int> get_getIndex() { }

	[CompilerGenerated]
	// RVA: 0x85BC368 Offset: 0x85B8368 VA: 0x85BC368
	public void set_getIndex(Func<int> value) { }

	[CompilerGenerated]
	// RVA: 0x85BC370 Offset: 0x85B8370 VA: 0x85BC370
	public Action<int> get_setIndex() { }

	[CompilerGenerated]
	// RVA: 0x85BC378 Offset: 0x85B8378 VA: 0x85BC378
	public void set_setIndex(Action<int> value) { }

	// RVA: 0x85BC380 Offset: 0x85B8380 VA: 0x85BC380
	public int get_currentIndex() { }

	// RVA: 0x85BC3A4 Offset: 0x85B83A4 VA: 0x85BC3A4
	public void set_currentIndex(int value) { }

	// RVA: 0x85BC3C8 Offset: 0x85B83C8 VA: 0x85BC3C8
	public void set_autoEnum(Type value) { }

	// RVA: 0x85BC428 Offset: 0x85B8428 VA: 0x85BC428
	internal void InitQuickSeparators() { }

	// RVA: 0x85BC64C Offset: 0x85B864C VA: 0x85BC64C Slot: 16
	public override void SetValue(int value) { }

	// RVA: 0x85AA0A0 Offset: 0x85A60A0 VA: 0x85AA0A0
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.ObjectPopupField : DebugUI.Field<Object> // TypeDefIndex: 19902
{
	// Fields
	[CompilerGenerated]
	private Func<IEnumerable<Object>> <getObjects>k__BackingField; // 0x60

	// Properties
	public Func<IEnumerable<Object>> getObjects { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85BC894 Offset: 0x85B8894 VA: 0x85BC894
	public Func<IEnumerable<Object>> get_getObjects() { }

	[CompilerGenerated]
	// RVA: 0x85BC89C Offset: 0x85B889C VA: 0x85BC89C
	public void set_getObjects(Func<IEnumerable<Object>> value) { }

	// RVA: 0x85B005C Offset: 0x85AC05C VA: 0x85B005C
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.HistoryEnumField : DebugUI.EnumField // TypeDefIndex: 19903
{
	// Fields
	[CompilerGenerated]
	private Func<int>[] <historyIndexGetter>k__BackingField; // 0x90

	// Properties
	public Func<int>[] historyIndexGetter { get; set; }
	public int historyDepth { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85BC8A4 Offset: 0x85B88A4 VA: 0x85BC8A4
	public Func<int>[] get_historyIndexGetter() { }

	[CompilerGenerated]
	// RVA: 0x85BC8AC Offset: 0x85B88AC VA: 0x85BC8AC
	public void set_historyIndexGetter(Func<int>[] value) { }

	// RVA: 0x85BC8B4 Offset: 0x85B88B4 VA: 0x85BC8B4
	public int get_historyDepth() { }

	// RVA: 0x85BC8CC Offset: 0x85B88CC VA: 0x85BC8CC
	public int GetHistoryValue(int historyIndex) { }

	// RVA: 0x85BC90C Offset: 0x85B890C VA: 0x85BC90C
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.BitField : DebugUI.EnumField<Enum> // TypeDefIndex: 19904
{
	// Fields
	private Type m_EnumType; // 0x70

	// Properties
	public Type enumType { get; set; }

	// Methods

	// RVA: 0x85BC910 Offset: 0x85B8910 VA: 0x85BC910
	public Type get_enumType() { }

	// RVA: 0x85BC918 Offset: 0x85B8918 VA: 0x85BC918
	public void set_enumType(Type value) { }

	// RVA: 0x85BC980 Offset: 0x85B8980 VA: 0x85BC980
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.ColorField : DebugUI.Field<Color> // TypeDefIndex: 19905
{
	// Fields
	public bool hdr; // 0x60
	public bool showAlpha; // 0x61
	public bool showPicker; // 0x62
	public float incStep; // 0x64
	public float incStepMult; // 0x68
	public int decimals; // 0x6C

	// Methods

	// RVA: 0x85BC9EC Offset: 0x85B89EC VA: 0x85BC9EC Slot: 15
	public override Color ValidateValue(Color value) { }

	// RVA: 0x85BCA3C Offset: 0x85B8A3C VA: 0x85BCA3C
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Vector2Field : DebugUI.Field<Vector2> // TypeDefIndex: 19906
{
	// Fields
	public float incStep; // 0x60
	public float incStepMult; // 0x64
	public int decimals; // 0x68

	// Methods

	// RVA: 0x85BCAA0 Offset: 0x85B8AA0 VA: 0x85BCAA0
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Vector3Field : DebugUI.Field<Vector3> // TypeDefIndex: 19907
{
	// Fields
	public float incStep; // 0x60
	public float incStepMult; // 0x64
	public int decimals; // 0x68

	// Methods

	// RVA: 0x85BCAFC Offset: 0x85B8AFC VA: 0x85BCAFC
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.Vector4Field : DebugUI.Field<Vector4> // TypeDefIndex: 19908
{
	// Fields
	public float incStep; // 0x60
	public float incStepMult; // 0x64
	public int decimals; // 0x68

	// Methods

	// RVA: 0x85BCB58 Offset: 0x85B8B58 VA: 0x85BCB58
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.ObjectField : DebugUI.Field<Object> // TypeDefIndex: 19909
{
	// Fields
	public Type type; // 0x60

	// Methods

	// RVA: 0x85B1AB8 Offset: 0x85ADAB8 VA: 0x85B1AB8
	public void .ctor() { }
}

// Namespace: 
public class DebugUI.ObjectListField : DebugUI.Field<Object[]> // TypeDefIndex: 19910
{
	// Fields
	public Type type; // 0x60

	// Methods

	// RVA: 0x85BCBB4 Offset: 0x85B8BB4 VA: 0x85BCBB4
	public void .ctor() { }
}

// Namespace: 
public enum DebugUI.MessageBox.Style // TypeDefIndex: 19911
{
	// Fields
	public int value__; // 0x0
	public const DebugUI.MessageBox.Style Info = 0;
	public const DebugUI.MessageBox.Style Warning = 1;
	public const DebugUI.MessageBox.Style Error = 2;
}

// Namespace: 
public class DebugUI.MessageBox : DebugUI.Widget // TypeDefIndex: 19912
{
	// Fields
	public DebugUI.MessageBox.Style style; // 0x48

	// Methods

	// RVA: 0x85BCC5C Offset: 0x85B8C5C VA: 0x85BCC5C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DebugUI.Panel.<>c // TypeDefIndex: 19913
{
	// Fields
	public static readonly DebugUI.Panel.<>c <>9; // 0x0
	public static Action<DebugUI.Panel> <>9__29_0; // 0x8

	// Methods

	// RVA: 0x85BCF00 Offset: 0x85B8F00 VA: 0x85BCF00
	private static void .cctor() { }

	// RVA: 0x85BCF68 Offset: 0x85B8F68 VA: 0x85BCF68
	public void .ctor() { }

	// RVA: 0x85BCF70 Offset: 0x85B8F70 VA: 0x85BCF70
	internal void <.ctor>b__29_0(DebugUI.Panel <p0>) { }
}

// Namespace: 
public class DebugUI.Panel : DebugUI.IContainer, IComparable<DebugUI.Panel> // TypeDefIndex: 19914
{
	// Fields
	[CompilerGenerated]
	private DebugUI.Flags <flags>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <displayName>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <groupIndex>k__BackingField; // 0x20
	[CompilerGenerated]
	private ObservableList<DebugUI.Widget> <children>k__BackingField; // 0x28
	[CompilerGenerated]
	private Action<DebugUI.Panel> onSetDirty; // 0x30

	// Properties
	public DebugUI.Flags flags { get; set; }
	public string displayName { get; set; }
	public int groupIndex { get; set; }
	public string queryPath { get; }
	public bool isEditorOnly { get; }
	public bool isRuntimeOnly { get; }
	public bool isInactiveInEditor { get; }
	public bool editorForceUpdate { get; }
	public ObservableList<DebugUI.Widget> children { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85BCC64 Offset: 0x85B8C64 VA: 0x85BCC64
	public DebugUI.Flags get_flags() { }

	[CompilerGenerated]
	// RVA: 0x85BCC6C Offset: 0x85B8C6C VA: 0x85BCC6C
	public void set_flags(DebugUI.Flags value) { }

	[CompilerGenerated]
	// RVA: 0x85BCC74 Offset: 0x85B8C74 VA: 0x85BCC74 Slot: 5
	public string get_displayName() { }

	[CompilerGenerated]
	// RVA: 0x85BCC7C Offset: 0x85B8C7C VA: 0x85BCC7C Slot: 6
	public void set_displayName(string value) { }

	[CompilerGenerated]
	// RVA: 0x85BCC84 Offset: 0x85B8C84 VA: 0x85BCC84
	public int get_groupIndex() { }

	[CompilerGenerated]
	// RVA: 0x85BCC8C Offset: 0x85B8C8C VA: 0x85BCC8C
	public void set_groupIndex(int value) { }

	// RVA: 0x85BCC94 Offset: 0x85B8C94 VA: 0x85BCC94 Slot: 7
	public string get_queryPath() { }

	// RVA: 0x85BCC9C Offset: 0x85B8C9C VA: 0x85BCC9C
	public bool get_isEditorOnly() { }

	// RVA: 0x85BCCA8 Offset: 0x85B8CA8 VA: 0x85BCCA8
	public bool get_isRuntimeOnly() { }

	// RVA: 0x85BCCB4 Offset: 0x85B8CB4 VA: 0x85BCCB4
	public bool get_isInactiveInEditor() { }

	// RVA: 0x85BCD24 Offset: 0x85B8D24 VA: 0x85BCD24
	public bool get_editorForceUpdate() { }

	[CompilerGenerated]
	// RVA: 0x85BCD30 Offset: 0x85B8D30 VA: 0x85BCD30 Slot: 4
	public ObservableList<DebugUI.Widget> get_children() { }

	[CompilerGenerated]
	// RVA: 0x85BCD38 Offset: 0x85B8D38 VA: 0x85BCD38
	private void set_children(ObservableList<DebugUI.Widget> value) { }

	[CompilerGenerated]
	// RVA: 0x85B75F4 Offset: 0x85B35F4 VA: 0x85B75F4
	public void add_onSetDirty(Action<DebugUI.Panel> value) { }

	[CompilerGenerated]
	// RVA: 0x85B72E0 Offset: 0x85B32E0 VA: 0x85B72E0
	public void remove_onSetDirty(Action<DebugUI.Panel> value) { }

	// RVA: 0x85B7400 Offset: 0x85B3400 VA: 0x85B7400
	public void .ctor() { }

	// RVA: 0x85BCD40 Offset: 0x85B8D40 VA: 0x85BCD40 Slot: 9
	protected virtual void OnItemAdded(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x85BCD98 Offset: 0x85B8D98 VA: 0x85BCD98 Slot: 10
	protected virtual void OnItemRemoved(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e) { }

	// RVA: 0x85BB4E0 Offset: 0x85B74E0 VA: 0x85BB4E0
	public void SetDirty() { }

	// RVA: 0x85BCDF0 Offset: 0x85B8DF0 VA: 0x85BCDF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x85BCED0 Offset: 0x85B8ED0 VA: 0x85BCED0 Slot: 8
	private int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(DebugUI.Panel other) { }
}

// Namespace: UnityEngine.Rendering
public class DebugUI // TypeDefIndex: 19915
{
	// Methods

	// RVA: 0x85BAE00 Offset: 0x85B6E00 VA: 0x85BAE00
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugUpdater.<DoAfterInputModuleUpdated>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 19916
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action action; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x85BD5D0 Offset: 0x85B95D0 VA: 0x85BD5D0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x85BD904 Offset: 0x85B9904 VA: 0x85BD904 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x85BD908 Offset: 0x85B9908 VA: 0x85BD908 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x85BDA04 Offset: 0x85B9A04 VA: 0x85BDA04 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x85BDA0C Offset: 0x85B9A0C VA: 0x85BDA0C Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x85BDA44 Offset: 0x85B9A44 VA: 0x85BDA44 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugUpdater.<RefreshRuntimeUINextFrame>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 19917
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x85BD8D4 Offset: 0x85B98D4 VA: 0x85BD8D4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x85BDA4C Offset: 0x85B9A4C VA: 0x85BDA4C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x85BDA50 Offset: 0x85B9A50 VA: 0x85BDA50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x85BDAF0 Offset: 0x85B9AF0 VA: 0x85BDAF0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x85BDAF8 Offset: 0x85B9AF8 VA: 0x85BDAF8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x85BDB30 Offset: 0x85B9B30 VA: 0x85BDB30 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.Rendering
internal class DebugUpdater : MonoBehaviour // TypeDefIndex: 19918
{
	// Fields
	private static DebugUpdater s_Instance; // 0x0
	private ScreenOrientation m_Orientation; // 0x20
	private bool m_RuntimeUiWasVisibleLastFrame; // 0x24

	// Methods

	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x85BCF74 Offset: 0x85B8F74 VA: 0x85BCF74
	private static void RuntimeInit() { }

	// RVA: 0x85B88CC Offset: 0x85B48CC VA: 0x85B88CC
	internal static void SetEnabled(bool enabled) { }

	// RVA: 0x85BCF78 Offset: 0x85B8F78 VA: 0x85BCF78
	private static void EnableRuntime() { }

	// RVA: 0x85BD0EC Offset: 0x85B90EC VA: 0x85BD0EC
	private static void DisableRuntime() { }

	// RVA: 0x85B8B94 Offset: 0x85B4B94 VA: 0x85B8B94
	internal static void HandleInternalEventSystemComponents(bool uiEnabled) { }

	// RVA: 0x85BD228 Offset: 0x85B9228 VA: 0x85BD228
	private void EnsureExactlyOneEventSystem() { }

	[IteratorStateMachine(typeof(DebugUpdater.<DoAfterInputModuleUpdated>d__9))]
	// RVA: 0x85BD564 Offset: 0x85B9564 VA: 0x85BD564
	private IEnumerator DoAfterInputModuleUpdated(Action action) { }

	// RVA: 0x85BD5F8 Offset: 0x85B95F8 VA: 0x85BD5F8
	private void CheckInputModuleExists() { }

	// RVA: 0x85BD4E0 Offset: 0x85B94E0 VA: 0x85BD4E0
	private void CreateDebugEventSystem() { }

	// RVA: 0x85BD400 Offset: 0x85B9400 VA: 0x85BD400
	private void DestroyDebugEventSystem() { }

	// RVA: 0x85BD724 Offset: 0x85B9724 VA: 0x85BD724
	private void Update() { }

	[IteratorStateMachine(typeof(DebugUpdater.<RefreshRuntimeUINextFrame>d__14))]
	// RVA: 0x85BD87C Offset: 0x85B987C VA: 0x85BD87C
	private static IEnumerator RefreshRuntimeUINextFrame() { }

	// RVA: 0x85BD8FC Offset: 0x85B98FC VA: 0x85BD8FC
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
internal enum PerformanceBottleneck // TypeDefIndex: 19919
{
	// Fields
	public int value__; // 0x0
	public const PerformanceBottleneck Indeterminate = 0;
	public const PerformanceBottleneck PresentLimited = 1;
	public const PerformanceBottleneck CPU = 2;
	public const PerformanceBottleneck GPU = 3;
	public const PerformanceBottleneck Balanced = 4;
}

// Namespace: UnityEngine.Rendering
internal struct BottleneckHistogram // TypeDefIndex: 19920
{
	// Fields
	internal float PresentLimited; // 0x0
	internal float CPU; // 0x4
	internal float GPU; // 0x8
	internal float Balanced; // 0xC
}

// Namespace: UnityEngine.Rendering
internal class BottleneckHistory // TypeDefIndex: 19921
{
	// Fields
	private List<PerformanceBottleneck> m_Bottlenecks; // 0x10
	internal BottleneckHistogram Histogram; // 0x18

	// Methods

	// RVA: 0x85BDB38 Offset: 0x85B9B38 VA: 0x85BDB38
	public void .ctor(int initialCapacity) { }

	// RVA: 0x85BDBF4 Offset: 0x85B9BF4 VA: 0x85BDBF4
	internal void DiscardOldSamples(int historySize) { }

	// RVA: 0x85BDC94 Offset: 0x85B9C94 VA: 0x85BDC94
	internal void AddBottleneckFromAveragedSample(FrameTimeSample frameHistorySampleAverage) { }

	// RVA: 0x85BDE08 Offset: 0x85B9E08 VA: 0x85BDE08
	internal void ComputeHistogram() { }

	// RVA: 0x85BDD60 Offset: 0x85B9D60 VA: 0x85BDD60
	private static PerformanceBottleneck DetermineBottleneck(FrameTimeSample s) { }

	// RVA: 0x85BDF18 Offset: 0x85B9F18 VA: 0x85BDF18
	internal void Clear() { }
}

// Namespace: UnityEngine.Rendering
internal struct FrameTimeSample // TypeDefIndex: 19922
{
	// Fields
	internal float FramesPerSecond; // 0x0
	internal float FullFrameTime; // 0x4
	internal float MainThreadCPUFrameTime; // 0x8
	internal float MainThreadCPUPresentWaitTime; // 0xC
	internal float RenderThreadCPUFrameTime; // 0x10
	internal float GPUFrameTime; // 0x14

	// Methods

	// RVA: 0x85BDF6C Offset: 0x85B9F6C VA: 0x85BDF6C
	internal void .ctor(float initValue) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FrameTimeSampleHistory.<>c // TypeDefIndex: 19923
{
	// Fields
	public static readonly FrameTimeSampleHistory.<>c <>9; // 0x0

	// Methods

	// RVA: 0x85BE7CC Offset: 0x85BA7CC VA: 0x85BE7CC
	private static void .cctor() { }

	// RVA: 0x85BE834 Offset: 0x85BA834 VA: 0x85BE834
	public void .ctor() { }

	// RVA: 0x85BE83C Offset: 0x85BA83C VA: 0x85BE83C
	internal float <.cctor>b__15_0(float value, float other) { }

	// RVA: 0x85BE844 Offset: 0x85BA844 VA: 0x85BE844
	internal float <.cctor>b__15_1(float value, float other) { }

	// RVA: 0x85BE858 Offset: 0x85BA858 VA: 0x85BE858
	internal float <.cctor>b__15_2(float value, float other) { }

	// RVA: 0x85BE864 Offset: 0x85BA864 VA: 0x85BE864
	internal float <.cctor>b__15_3(float value, float other) { }

	// RVA: 0x85BE878 Offset: 0x85BA878 VA: 0x85BE878
	internal float <.cctor>b__15_4(float value, float other) { }

	// RVA: 0x85BE888 Offset: 0x85BA888 VA: 0x85BE888
	internal float <.cctor>b__15_5(float value, float other) { }
}

// Namespace: UnityEngine.Rendering
internal class FrameTimeSampleHistory // TypeDefIndex: 19924
{
	// Fields
	private List<FrameTimeSample> m_Samples; // 0x10
	internal FrameTimeSample SampleAverage; // 0x18
	internal FrameTimeSample SampleMin; // 0x30
	internal FrameTimeSample SampleMax; // 0x48
	private static Func<float, float, float> s_SampleValueAdd; // 0x0
	private static Func<float, float, float> s_SampleValueMin; // 0x8
	private static Func<float, float, float> s_SampleValueMax; // 0x10
	private static Func<float, float, float> s_SampleValueCountValid; // 0x18
	private static Func<float, float, float> s_SampleValueEnsureValid; // 0x20
	private static Func<float, float, float> s_SampleValueDivide; // 0x28

	// Methods

	// RVA: 0x85BDF7C Offset: 0x85B9F7C VA: 0x85BDF7C
	public void .ctor(int initialCapacity) { }

	// RVA: 0x85BE038 Offset: 0x85BA038 VA: 0x85BE038
	internal void Add(FrameTimeSample sample) { }

	// RVA: 0x85BE120 Offset: 0x85BA120 VA: 0x85BE120
	internal void ComputeAggregateValues() { }

	// RVA: 0x85BE464 Offset: 0x85BA464 VA: 0x85BE464
	internal void DiscardOldSamples(int sampleHistorySize) { }

	// RVA: 0x85BE504 Offset: 0x85BA504 VA: 0x85BE504
	internal void Clear() { }

	// RVA: 0x85BE554 Offset: 0x85BA554 VA: 0x85BE554
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x85BE394 Offset: 0x85BA394 VA: 0x85BE394
	internal static void <ComputeAggregateValues>g__ForEachSampleMember|12_0(ref FrameTimeSample aggregate, FrameTimeSample sample, Func<float, float, float> func) { }
}

// Namespace: UnityEngine.Rendering
public interface IDebugDisplaySettings : IDebugDisplaySettingsQuery // TypeDefIndex: 19925
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ForEach(Action<IDebugDisplaySettingsData> onExecute);
}

// Namespace: UnityEngine.Rendering
public interface IDebugDisplaySettingsData : IDebugDisplaySettingsQuery // TypeDefIndex: 19926
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDebugDisplaySettingsPanelDisposable CreatePanel();
}

// Namespace: UnityEngine.Rendering
public interface IDebugDisplaySettingsPanel // TypeDefIndex: 19927
{
	// Properties
	public abstract string PanelName { get; }
	public abstract DebugUI.Widget[] Widgets { get; }
	public abstract DebugUI.Flags Flags { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_PanelName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DebugUI.Widget[] get_Widgets();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DebugUI.Flags get_Flags();
}

// Namespace: UnityEngine.Rendering
public interface IDebugDisplaySettingsPanelDisposable : IDebugDisplaySettingsPanel, IDisposable // TypeDefIndex: 19928
{}

// Namespace: UnityEngine.Rendering
public interface IDebugDisplaySettingsQuery // TypeDefIndex: 19929
{
	// Properties
	public abstract bool AreAnySettingsActive { get; }
	public abstract bool IsPostProcessingAllowed { get; }
	public abstract bool IsLightingActive { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_AreAnySettingsActive();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsPostProcessingAllowed();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsLightingActive();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TryGetScreenClearColor(ref Color color);
}

// Namespace: UnityEngine.Rendering
[Obsolete("This variant is obsolete and kept only for not breaking user code. Use IVolumeDebugSettings2 for all new usage.", False)]
public interface IVolumeDebugSettings // TypeDefIndex: 19930
{
	// Properties
	public abstract int selectedComponent { get; set; }
	public abstract Camera selectedCamera { get; }
	public abstract IEnumerable<Camera> cameras { get; }
	public abstract int selectedCameraIndex { get; set; }
	public abstract VolumeStack selectedCameraVolumeStack { get; }
	public abstract LayerMask selectedCameraLayerMask { get; }
	public abstract Vector3 selectedCameraPosition { get; }
	public abstract Type selectedComponentType { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_selectedComponent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_selectedComponent(int value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Camera get_selectedCamera();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<Camera> get_cameras();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_selectedCameraIndex();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_selectedCameraIndex(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract VolumeStack get_selectedCameraVolumeStack();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract LayerMask get_selectedCameraLayerMask();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Vector3 get_selectedCameraPosition();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_selectedComponentType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_selectedComponentType(Type value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Volume[] GetVolumes();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool VolumeHasInfluence(Volume volume);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool RefreshVolumes(Volume[] newVolumes);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float GetVolumeWeight(Volume volume);
}

// Namespace: UnityEngine.Rendering
public interface IVolumeDebugSettings2 : IVolumeDebugSettings // TypeDefIndex: 19931
{
	// Properties
	public abstract Type targetRenderPipeline { get; }
	public abstract List<ValueTuple<string, Type>> volumeComponentsPathAndType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_targetRenderPipeline();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract List<ValueTuple<string, Type>> get_volumeComponentsPathAndType();
}

// Namespace: UnityEngine.Rendering
public class MousePositionDebug // TypeDefIndex: 19932
{
	// Fields
	private static MousePositionDebug s_Instance; // 0x0

	// Properties
	public static MousePositionDebug instance { get; }

	// Methods

	// RVA: 0x85BE89C Offset: 0x85BA89C VA: 0x85BE89C
	public static MousePositionDebug get_instance() { }

	// RVA: 0x85BE92C Offset: 0x85BA92C VA: 0x85BE92C
	public void Build() { }

	// RVA: 0x85BE930 Offset: 0x85BA930 VA: 0x85BE930
	public void Cleanup() { }

	// RVA: 0x85BE934 Offset: 0x85BA934 VA: 0x85BE934
	public Vector2 GetMousePosition(float ScreenHeight, bool sceneView) { }

	// RVA: 0x85BE93C Offset: 0x85BA93C VA: 0x85BE93C
	private Vector2 GetInputMousePosition() { }

	// RVA: 0x85BE944 Offset: 0x85BA944 VA: 0x85BE944
	public Vector2 GetMouseClickPosition(float ScreenHeight) { }

	// RVA: 0x85BE924 Offset: 0x85BA924 VA: 0x85BE924
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
internal class TProfilingSampler<TEnum> : ProfilingSampler // TypeDefIndex: 19933
{
	// Fields
	internal static Dictionary<TEnum, TProfilingSampler<TEnum>> samples; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x553C88C Offset: 0x553888C VA: 0x553C88C
	|-TProfilingSampler<Int32Enum>..cctor
	|
	|-RVA: 0x553CB9C Offset: 0x5538B9C VA: 0x553CB9C
	|-TProfilingSampler<__Il2CppFullySharedGenericStructType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x553CB94 Offset: 0x5538B94 VA: 0x553CB94
	|-TProfilingSampler<Int32Enum>..ctor
	|
	|-RVA: 0x553CF6C Offset: 0x5538F6C VA: 0x553CF6C
	|-TProfilingSampler<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: UnityEngine.Rendering
[IgnoredByDeepProfiler]
public class ProfilingSampler // TypeDefIndex: 19934
{
	// Fields
	[CompilerGenerated]
	private CustomSampler <sampler>k__BackingField; // 0x10
	[CompilerGenerated]
	private CustomSampler <inlineSampler>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x20
	private Recorder m_Recorder; // 0x28
	private Recorder m_InlineRecorder; // 0x30

	// Properties
	internal CustomSampler sampler { get; set; }
	internal CustomSampler inlineSampler { get; set; }
	public string name { get; set; }
	public bool enableRecording { set; }
	public float gpuElapsedTime { get; }
	public int gpuSampleCount { get; }
	public float cpuElapsedTime { get; }
	public int cpuSampleCount { get; }
	public float inlineCpuElapsedTime { get; }
	public int inlineCpuSampleCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ProfilingSampler Get<TEnum>(TEnum marker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46A5AB8 Offset: 0x46A1AB8 VA: 0x46A5AB8
	|-ProfilingSampler.Get<Int32Enum>
	|
	|-RVA: 0x46A5B44 Offset: 0x46A1B44 VA: 0x46A5B44
	|-ProfilingSampler.Get<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x85BE984 Offset: 0x85BA984 VA: 0x85BE984
	public void .ctor(string name) { }

	// RVA: 0x85BEAD0 Offset: 0x85BAAD0 VA: 0x85BEAD0
	public void Begin(CommandBuffer cmd) { }

	// RVA: 0x85BEB34 Offset: 0x85BAB34 VA: 0x85BEB34
	public void End(CommandBuffer cmd) { }

	// RVA: 0x85BEB98 Offset: 0x85BAB98 VA: 0x85BEB98
	internal bool IsValid() { }

	[CompilerGenerated]
	// RVA: 0x85BEBB8 Offset: 0x85BABB8 VA: 0x85BEBB8
	internal CustomSampler get_sampler() { }

	[CompilerGenerated]
	// RVA: 0x85BEBC0 Offset: 0x85BABC0 VA: 0x85BEBC0
	private void set_sampler(CustomSampler value) { }

	[CompilerGenerated]
	// RVA: 0x85BEBC8 Offset: 0x85BABC8 VA: 0x85BEBC8
	internal CustomSampler get_inlineSampler() { }

	[CompilerGenerated]
	// RVA: 0x85BEBD0 Offset: 0x85BABD0 VA: 0x85BEBD0
	private void set_inlineSampler(CustomSampler value) { }

	[CompilerGenerated]
	// RVA: 0x85BEBD8 Offset: 0x85BABD8 VA: 0x85BEBD8
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x85BEBE0 Offset: 0x85BABE0 VA: 0x85BEBE0
	private void set_name(string value) { }

	// RVA: 0x85BEBE8 Offset: 0x85BABE8 VA: 0x85BEBE8
	public void set_enableRecording(bool value) { }

	// RVA: 0x85BEC2C Offset: 0x85BAC2C VA: 0x85BEC2C
	public float get_gpuElapsedTime() { }

	// RVA: 0x85BEC78 Offset: 0x85BAC78 VA: 0x85BEC78
	public int get_gpuSampleCount() { }

	// RVA: 0x85BECB8 Offset: 0x85BACB8 VA: 0x85BECB8
	public float get_cpuElapsedTime() { }

	// RVA: 0x85BED04 Offset: 0x85BAD04 VA: 0x85BED04
	public int get_cpuSampleCount() { }

	// RVA: 0x85BED44 Offset: 0x85BAD44 VA: 0x85BED44
	public float get_inlineCpuElapsedTime() { }

	// RVA: 0x85BED90 Offset: 0x85BAD90 VA: 0x85BED90
	public int get_inlineCpuSampleCount() { }

	// RVA: 0x85BEDD0 Offset: 0x85BADD0 VA: 0x85BEDD0
	private void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public struct ProfilingScope : IDisposable // TypeDefIndex: 19935
{
	// Methods

	// RVA: 0x85BEDD8 Offset: 0x85BADD8 VA: 0x85BEDD8
	public void .ctor(CommandBuffer cmd, ProfilingSampler sampler) { }

	// RVA: 0x85BEDDC Offset: 0x85BADDC VA: 0x85BEDDC Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine.Rendering
[Obsolete("Please use ProfilingScope")]
[IgnoredByDeepProfiler]
public struct ProfilingSample : IDisposable // TypeDefIndex: 19936
{
	// Fields
	private readonly CommandBuffer m_Cmd; // 0x0
	private readonly string m_Name; // 0x8
	private bool m_Disposed; // 0x10
	private CustomSampler m_Sampler; // 0x18

	// Methods

	// RVA: 0x85BEDE0 Offset: 0x85BADE0 VA: 0x85BEDE0
	public void .ctor(CommandBuffer cmd, string name, CustomSampler sampler) { }

	// RVA: 0x85BEE90 Offset: 0x85BAE90 VA: 0x85BEE90
	public void .ctor(CommandBuffer cmd, string format, object arg) { }

	// RVA: 0x85BEECC Offset: 0x85BAECC VA: 0x85BEECC
	public void .ctor(CommandBuffer cmd, string format, object[] args) { }

	// RVA: 0x85BEF08 Offset: 0x85BAF08 VA: 0x85BEF08 Slot: 4
	public void Dispose() { }

	// RVA: 0x85BEF10 Offset: 0x85BAF10 VA: 0x85BEF10
	private void Dispose(bool disposing) { }
}

// Namespace: 
private static class ShaderDebugPrintManager.Profiling // TypeDefIndex: 19937
{
	// Fields
	public static readonly ProfilingSampler BufferReadComplete; // 0x0

	// Methods

	// RVA: 0x85C06FC Offset: 0x85BC6FC VA: 0x85C06FC
	private static void .cctor() { }
}

// Namespace: 
private enum ShaderDebugPrintManager.DebugValueType // TypeDefIndex: 19938
{
	// Fields
	public int value__; // 0x0
	public const ShaderDebugPrintManager.DebugValueType TypeUint = 1;
	public const ShaderDebugPrintManager.DebugValueType TypeInt = 2;
	public const ShaderDebugPrintManager.DebugValueType TypeFloat = 3;
	public const ShaderDebugPrintManager.DebugValueType TypeUint2 = 4;
	public const ShaderDebugPrintManager.DebugValueType TypeInt2 = 5;
	public const ShaderDebugPrintManager.DebugValueType TypeFloat2 = 6;
	public const ShaderDebugPrintManager.DebugValueType TypeUint3 = 7;
	public const ShaderDebugPrintManager.DebugValueType TypeInt3 = 8;
	public const ShaderDebugPrintManager.DebugValueType TypeFloat3 = 9;
	public const ShaderDebugPrintManager.DebugValueType TypeUint4 = 10;
	public const ShaderDebugPrintManager.DebugValueType TypeInt4 = 11;
	public const ShaderDebugPrintManager.DebugValueType TypeFloat4 = 12;
	public const ShaderDebugPrintManager.DebugValueType TypeBool = 13;
}

// Namespace: UnityEngine.Rendering
public sealed class ShaderDebugPrintManager // TypeDefIndex: 19939
{
	// Fields
	private static readonly ShaderDebugPrintManager s_Instance; // 0x0
	private const int k_DebugUAVSlot = 7;
	private const int k_FramesInFlight = 4;
	private const int k_MaxBufferElements = 16384;
	private List<GraphicsBuffer> m_OutputBuffers; // 0x10
	private List<AsyncGPUReadbackRequest> m_ReadbackRequests; // 0x18
	private Action<AsyncGPUReadbackRequest> m_BufferReadCompleteAction; // 0x20
	private int m_FrameCounter; // 0x28
	private bool m_FrameCleared; // 0x2C
	private string m_OutputLine; // 0x30
	private Action<string> m_OutputAction; // 0x38
	private static readonly int m_ShaderPropertyIDInputMouse; // 0x8
	private static readonly int m_ShaderPropertyIDInputFrame; // 0xC
	private const uint k_TypeHasTag = 128;

	// Properties
	public static ShaderDebugPrintManager instance { get; }
	public string outputLine { get; }
	public Action<string> outputAction { set; }

	// Methods

	// RVA: 0x85BEF9C Offset: 0x85BAF9C VA: 0x85BEF9C
	private int DebugValueTypeToElemSize(ShaderDebugPrintManager.DebugValueType type) { }

	// RVA: 0x85BEFC0 Offset: 0x85BAFC0 VA: 0x85BEFC0
	private void .ctor() { }

	// RVA: 0x85BF2AC Offset: 0x85BB2AC VA: 0x85BF2AC
	public static ShaderDebugPrintManager get_instance() { }

	// RVA: 0x85BF304 Offset: 0x85BB304 VA: 0x85BF304
	public void SetShaderDebugPrintInputConstants(CommandBuffer cmd, ShaderDebugPrintInput input) { }

	// RVA: 0x85BF3CC Offset: 0x85BB3CC VA: 0x85BF3CC
	public void SetShaderDebugPrintBindings(CommandBuffer cmd) { }

	// RVA: 0x85BF4D0 Offset: 0x85BB4D0 VA: 0x85BF4D0
	private void ClearShaderDebugPrintBuffer() { }

	// RVA: 0x85BF5BC Offset: 0x85BB5BC VA: 0x85BF5BC
	private void BufferReadComplete(AsyncGPUReadbackRequest request) { }

	// RVA: 0x85C050C Offset: 0x85BC50C VA: 0x85C050C
	public void EndFrame() { }

	// RVA: 0x85C05CC Offset: 0x85BC5CC VA: 0x85C05CC
	public string get_outputLine() { }

	// RVA: 0x85C05D4 Offset: 0x85BC5D4 VA: 0x85C05D4
	public void set_outputAction(Action<string> value) { }

	// RVA: 0x85C05DC Offset: 0x85BC5DC VA: 0x85C05DC
	public void DefaultOutput(string line) { }

	// RVA: 0x85C0634 Offset: 0x85BC634 VA: 0x85C0634
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public struct ShaderDebugPrintInput // TypeDefIndex: 19940
{
	// Fields
	[CompilerGenerated]
	private Vector2 <pos>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <leftDown>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <rightDown>k__BackingField; // 0x9
	[CompilerGenerated]
	private bool <middleDown>k__BackingField; // 0xA

	// Properties
	public Vector2 pos { get; set; }
	public bool leftDown { get; set; }
	public bool rightDown { get; set; }
	public bool middleDown { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85C0794 Offset: 0x85BC794 VA: 0x85C0794
	public Vector2 get_pos() { }

	[CompilerGenerated]
	// RVA: 0x85C079C Offset: 0x85BC79C VA: 0x85C079C
	public void set_pos(Vector2 value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x85C07A4 Offset: 0x85BC7A4 VA: 0x85C07A4
	public bool get_leftDown() { }

	[CompilerGenerated]
	// RVA: 0x85C07AC Offset: 0x85BC7AC VA: 0x85C07AC
	public void set_leftDown(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85C07B8 Offset: 0x85BC7B8 VA: 0x85C07B8
	public bool get_rightDown() { }

	[CompilerGenerated]
	// RVA: 0x85C07C0 Offset: 0x85BC7C0 VA: 0x85C07C0
	public void set_rightDown(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85C07CC Offset: 0x85BC7CC VA: 0x85C07CC
	public bool get_middleDown() { }

	[CompilerGenerated]
	// RVA: 0x85C07D4 Offset: 0x85BC7D4 VA: 0x85C07D4
	public void set_middleDown(bool value) { }

	// RVA: 0x85C07E0 Offset: 0x85BC7E0 VA: 0x85C07E0
	public string String() { }
}

// Namespace: UnityEngine.Rendering
public static class ShaderDebugPrintInputProducer // TypeDefIndex: 19941
{
	// Methods

	// RVA: 0x85C0A1C Offset: 0x85BCA1C VA: 0x85C0A1C
	public static ShaderDebugPrintInput Get() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VolumeDebugSettings.<>c<T> // TypeDefIndex: 19942
{
	// Fields
	public static readonly VolumeDebugSettings.<>c<T> <>9; // 0x0
	public static Func<Volume, bool> <>9__35_0; // 0x0
	public static Func<FieldInfo, bool> <>9__37_0; // 0x0
	public static Func<Type, bool> <>9__44_0; // 0x0
	public static Func<Type, bool> <>9__44_1; // 0x0
	public static Func<Type, string> <>9__44_2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48246DC Offset: 0x48206DC VA: 0x48246DC
	|-VolumeDebugSettings.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4824798 Offset: 0x4820798 VA: 0x4824798
	|-VolumeDebugSettings.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <GetVolumes>b__35_0(Volume v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48247A0 Offset: 0x48207A0 VA: 0x48247A0
	|-VolumeDebugSettings.<>c<object>.<GetVolumes>b__35_0
	*/

	// RVA: -1 Offset: -1
	internal bool <GetStates>b__37_0(FieldInfo t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4824808 Offset: 0x4820808 VA: 0x4824808
	|-VolumeDebugSettings.<>c<object>.<GetStates>b__37_0
	*/

	// RVA: -1 Offset: -1
	internal bool <get_componentTypes>b__44_0(Type t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48248B8 Offset: 0x48208B8 VA: 0x48248B8
	|-VolumeDebugSettings.<>c<object>.<get_componentTypes>b__44_0
	*/

	// RVA: -1 Offset: -1
	internal bool <get_componentTypes>b__44_1(Type t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4824960 Offset: 0x4820960 VA: 0x4824960
	|-VolumeDebugSettings.<>c<object>.<get_componentTypes>b__44_1
	*/

	// RVA: -1 Offset: -1
	internal string <get_componentTypes>b__44_2(Type t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4824A08 Offset: 0x4820A08 VA: 0x4824A08
	|-VolumeDebugSettings.<>c<object>.<get_componentTypes>b__44_2
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class VolumeDebugSettings.<>c__DisplayClass23_0<T> // TypeDefIndex: 19943
{
	// Fields
	public Type value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486AA48 Offset: 0x4866A48 VA: 0x486AA48
	|-VolumeDebugSettings.<>c__DisplayClass23_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <set_selectedComponentType>b__0(ValueTuple<string, Type> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486AA50 Offset: 0x4866A50 VA: 0x486AA50
	|-VolumeDebugSettings.<>c__DisplayClass23_0<object>.<set_selectedComponentType>b__0
	*/
}

// Namespace: UnityEngine.Rendering
public abstract class VolumeDebugSettings<T> : IVolumeDebugSettings2, IVolumeDebugSettings // TypeDefIndex: 19944
{
	// Fields
	[CompilerGenerated]
	private int <selectedComponent>k__BackingField; // 0x0
	private Camera m_SelectedCamera; // 0x0
	protected int m_SelectedCameraIndex; // 0x0
	private Camera[] m_CamerasArray; // 0x0
	private List<Camera> m_Cameras; // 0x0
	private static List<ValueTuple<string, Type>> s_ComponentPathAndType; // 0x0
	private float[] weights; // 0x0
	private Volume[] volumes; // 0x0
	private VolumeParameter[,] savedStates; // 0x0
	private static List<Type> s_ComponentTypes; // 0x0
	[CompilerGenerated]
	private static List<T> <additionalCameraDatas>k__BackingField; // 0x0

	// Properties
	public int selectedComponent { get; set; }
	public Camera selectedCamera { get; }
	public int selectedCameraIndex { get; set; }
	public IEnumerable<Camera> cameras { get; }
	public abstract VolumeStack selectedCameraVolumeStack { get; }
	public abstract LayerMask selectedCameraLayerMask { get; }
	public abstract Vector3 selectedCameraPosition { get; }
	public Type selectedComponentType { get; set; }
	public List<ValueTuple<string, Type>> volumeComponentsPathAndType { get; }
	public abstract Type targetRenderPipeline { get; }
	[Obsolete("Please use volumeComponentsPathAndType instead, and get the second element of the tuple", False)]
	public static List<Type> componentTypes { get; }
	[Obsolete("Cameras are auto registered/unregistered, use property cameras", False)]
	protected static List<T> additionalCameraDatas { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public int get_selectedComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA0AC Offset: 0x58B60AC VA: 0x58BA0AC
	|-VolumeDebugSettings<object>.get_selectedComponent
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public void set_selectedComponent(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA0B4 Offset: 0x58B60B4 VA: 0x58BA0B4
	|-VolumeDebugSettings<object>.set_selectedComponent
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public Camera get_selectedCamera() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA0BC Offset: 0x58B60BC VA: 0x58BA0BC
	|-VolumeDebugSettings<object>.get_selectedCamera
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_selectedCameraIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA0C4 Offset: 0x58B60C4 VA: 0x58BA0C4
	|-VolumeDebugSettings<object>.get_selectedCameraIndex
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void set_selectedCameraIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA0CC Offset: 0x58B60CC VA: 0x58BA0CC
	|-VolumeDebugSettings<object>.set_selectedCameraIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public IEnumerable<Camera> get_cameras() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA1C4 Offset: 0x58B61C4 VA: 0x58BA1C4
	|-VolumeDebugSettings<object>.get_cameras
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public abstract VolumeStack get_selectedCameraVolumeStack();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VolumeDebugSettings<object>.get_selectedCameraVolumeStack
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public abstract LayerMask get_selectedCameraLayerMask();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VolumeDebugSettings<object>.get_selectedCameraLayerMask
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public abstract Vector3 get_selectedCameraPosition();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VolumeDebugSettings<object>.get_selectedCameraPosition
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public Type get_selectedComponentType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA44C Offset: 0x58B644C VA: 0x58BA44C
	|-VolumeDebugSettings<object>.get_selectedComponentType
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public void set_selectedComponentType(Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA4C0 Offset: 0x58B64C0 VA: 0x58BA4C0
	|-VolumeDebugSettings<object>.set_selectedComponentType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public List<ValueTuple<string, Type>> get_volumeComponentsPathAndType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA5D0 Offset: 0x58B65D0 VA: 0x58BA5D0
	|-VolumeDebugSettings<object>.get_volumeComponentsPathAndType
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Type get_targetRenderPipeline();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VolumeDebugSettings<object>.get_targetRenderPipeline
	*/

	// RVA: -1 Offset: -1
	internal VolumeParameter GetParameter(VolumeComponent component, FieldInfo field) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA710 Offset: 0x58B6710 VA: 0x58BA710
	|-VolumeDebugSettings<object>.GetParameter
	*/

	// RVA: -1 Offset: -1
	internal VolumeParameter GetParameter(FieldInfo field) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA7A8 Offset: 0x58B67A8 VA: 0x58BA7A8
	|-VolumeDebugSettings<object>.GetParameter
	*/

	// RVA: -1 Offset: -1
	internal VolumeParameter GetParameter(Volume volume, FieldInfo field) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA828 Offset: 0x58B6828 VA: 0x58BA828
	|-VolumeDebugSettings<object>.GetParameter
	*/

	// RVA: -1 Offset: -1
	private float ComputeWeight(Volume volume, Vector3 triggerPos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BA918 Offset: 0x58B6918 VA: 0x58BA918
	|-VolumeDebugSettings<object>.ComputeWeight
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public Volume[] GetVolumes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BABC0 Offset: 0x58B6BC0 VA: 0x58BABC0
	|-VolumeDebugSettings<object>.GetVolumes
	*/

	// RVA: -1 Offset: -1
	private VolumeParameter[,] GetStates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BADD0 Offset: 0x58B6DD0 VA: 0x58BADD0
	|-VolumeDebugSettings<object>.GetStates
	*/

	// RVA: -1 Offset: -1
	private bool ChangedStates(VolumeParameter[,] newStates) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BB148 Offset: 0x58B7148 VA: 0x58BB148
	|-VolumeDebugSettings<object>.ChangedStates
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool RefreshVolumes(Volume[] newVolumes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BB290 Offset: 0x58B7290 VA: 0x58BB290
	|-VolumeDebugSettings<object>.RefreshVolumes
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public float GetVolumeWeight(Volume volume) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BB4D4 Offset: 0x58B74D4 VA: 0x58BB4D4
	|-VolumeDebugSettings<object>.GetVolumeWeight
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool VolumeHasInfluence(Volume volume) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BB51C Offset: 0x58B751C VA: 0x58BB51C
	|-VolumeDebugSettings<object>.VolumeHasInfluence
	*/

	// RVA: -1 Offset: -1
	public static List<Type> get_componentTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BB570 Offset: 0x58B7570 VA: 0x58BB570
	|-VolumeDebugSettings<object>.get_componentTypes
	*/

	[Obsolete("Please use componentPathAndType instead, and get the first element of the tuple", False)]
	// RVA: -1 Offset: -1
	public static string ComponentDisplayName(Type component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BBBFC Offset: 0x58B7BFC VA: 0x58BBBFC
	|-VolumeDebugSettings<object>.ComponentDisplayName
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected static List<T> get_additionalCameraDatas() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BBD74 Offset: 0x58B7D74 VA: 0x58BBD74
	|-VolumeDebugSettings<object>.get_additionalCameraDatas
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private static void set_additionalCameraDatas(List<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BBDE0 Offset: 0x58B7DE0 VA: 0x58BBDE0
	|-VolumeDebugSettings<object>.set_additionalCameraDatas
	*/

	[Obsolete("Cameras are auto registered/unregistered", False)]
	// RVA: -1 Offset: -1
	public static void RegisterCamera(T additionalCamera) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BBE90 Offset: 0x58B7E90 VA: 0x58BBE90
	|-VolumeDebugSettings<object>.RegisterCamera
	*/

	[Obsolete("Cameras are auto registered/unregistered", False)]
	// RVA: -1 Offset: -1
	public static void UnRegisterCamera(T additionalCamera) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC0AC Offset: 0x58B80AC VA: 0x58BC0AC
	|-VolumeDebugSettings<object>.UnRegisterCamera
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC278 Offset: 0x58B8278 VA: 0x58BC278
	|-VolumeDebugSettings<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC308 Offset: 0x58B8308 VA: 0x58BC308
	|-VolumeDebugSettings<object>..cctor
	*/
}

// Namespace: UnityEngine.Rendering
[Conditional("UNITY_EDITOR")]
[Usage(20, AllowMultiple = False)]
public class CoreRPHelpURLAttribute : HelpURLAttribute // TypeDefIndex: 19945
{
	// Methods

	// RVA: 0x85C0A9C Offset: 0x85BCA9C VA: 0x85C0A9C
	public void .ctor(string pageName, string packageName = "com.unity.render-pipelines.core") { }

	// RVA: 0x85C0C98 Offset: 0x85BCC98 VA: 0x85C0C98
	public void .ctor(string pageName, string pageHash, string packageName = "com.unity.render-pipelines.core") { }
}

// Namespace: UnityEngine.Rendering
public class DocumentationInfo // TypeDefIndex: 19946
{
	// Fields
	private const string fallbackVersion = "13.1";
	private const string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html{3}";

	// Properties
	public static string version { get; }

	// Methods

	// RVA: 0x85C0CBC Offset: 0x85BCCBC VA: 0x85C0CBC
	public static string get_version() { }

	// RVA: 0x85C0CFC Offset: 0x85BCCFC VA: 0x85C0CFC
	public static string GetPageLink(string packageName, string pageName) { }

	// RVA: 0x85C0B08 Offset: 0x85BCB08 VA: 0x85C0B08
	public static string GetPageLink(string packageName, string pageName, string pageHash) { }

	// RVA: 0x85C0EA4 Offset: 0x85BCEA4 VA: 0x85C0EA4
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public static class DocumentationUtils // TypeDefIndex: 19947
{
	// Methods

	// RVA: -1 Offset: -1
	public static string GetHelpURL<TEnum>(TEnum mask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45740D8 Offset: 0x45700D8 VA: 0x45740D8
	|-DocumentationUtils.GetHelpURL<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x85C0EAC Offset: 0x85BCEAC VA: 0x85C0EAC
	public static bool TryGetHelpURL(Type type, out string url) { }
}

// Namespace: 
[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
[Serializable]
public struct ProbeBrickIndex.Brick : IEquatable<ProbeBrickIndex.Brick> // TypeDefIndex: 19948
{
	// Fields
	public Vector3Int position; // 0x0
	public int subdivisionLevel; // 0xC

	// Methods

	// RVA: 0x85C3950 Offset: 0x85BF950 VA: 0x85C3950
	internal void .ctor(Vector3Int position, int subdivisionLevel) { }

	// RVA: 0x85C395C Offset: 0x85BF95C VA: 0x85C395C Slot: 4
	public bool Equals(ProbeBrickIndex.Brick other) { }
}

// Namespace: 
[DebuggerDisplay("Brick [{brick.position}, {brick.subdivisionLevel}], {flattenedIdx}")]
private struct ProbeBrickIndex.ReservedBrick // TypeDefIndex: 19949
{
	// Fields
	public ProbeBrickIndex.Brick brick; // 0x0
	public int flattenedIdx; // 0x10
}

// Namespace: 
private class ProbeBrickIndex.VoxelMeta // TypeDefIndex: 19950
{
	// Fields
	public ProbeReferenceVolume.Cell cell; // 0x10
	public List<ushort> brickIndices; // 0x18

	// Methods

	// RVA: 0x85C39A8 Offset: 0x85BF9A8 VA: 0x85C39A8
	public void Clear() { }

	// RVA: 0x85C3A08 Offset: 0x85BFA08 VA: 0x85C3A08
	public void .ctor() { }
}

// Namespace: 
private class ProbeBrickIndex.BrickMeta // TypeDefIndex: 19951
{
	// Fields
	public HashSet<Vector3Int> voxels; // 0x10
	public List<ProbeBrickIndex.ReservedBrick> bricks; // 0x18

	// Methods

	// RVA: 0x85C3A90 Offset: 0x85BFA90 VA: 0x85C3A90
	public void Clear() { }

	// RVA: 0x85C3B04 Offset: 0x85BFB04 VA: 0x85C3B04
	public void .ctor() { }
}

// Namespace: 
public struct ProbeBrickIndex.CellIndexUpdateInfo // TypeDefIndex: 19952
{
	// Fields
	public int firstChunkIndex; // 0x0
	public int numberOfChunks; // 0x4
	public int minSubdivInCell; // 0x8
	public Vector3Int minValidBrickIndexForCellAtMaxRes; // 0xC
	public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne; // 0x18
	public Vector3Int cellPositionInBricksAtMaxRes; // 0x24
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProbeBrickIndex.<>c // TypeDefIndex: 19953
{
	// Fields
	public static readonly ProbeBrickIndex.<>c <>9; // 0x0
	public static UnityAction<ProbeBrickIndex.BrickMeta> <>9__28_0; // 0x8
	public static UnityAction<List<ProbeBrickIndex.VoxelMeta>> <>9__28_1; // 0x10
	public static UnityAction<ProbeBrickIndex.VoxelMeta> <>9__28_2; // 0x18
	public static Predicate<ProbeBrickIndex.VoxelMeta> <>9__39_0; // 0x20
	public static Predicate<ProbeBrickIndex.VoxelMeta> <>9__40_0; // 0x28

	// Methods

	// RVA: 0x85C3BE0 Offset: 0x85BFBE0 VA: 0x85C3BE0
	private static void .cctor() { }

	// RVA: 0x85C3C48 Offset: 0x85BFC48 VA: 0x85C3C48
	public void .ctor() { }

	// RVA: 0x85C3C50 Offset: 0x85BFC50 VA: 0x85C3C50
	internal void <.ctor>b__28_0(ProbeBrickIndex.BrickMeta x) { }

	// RVA: 0x85C3C64 Offset: 0x85BFC64 VA: 0x85C3C64
	internal void <.ctor>b__28_1(List<ProbeBrickIndex.VoxelMeta> x) { }

	// RVA: 0x85C3CD0 Offset: 0x85BFCD0 VA: 0x85C3CD0
	internal void <.ctor>b__28_2(ProbeBrickIndex.VoxelMeta x) { }

	// RVA: 0x85C3CE4 Offset: 0x85BFCE4 VA: 0x85C3CE4
	internal bool <AddBricks>b__39_0(ProbeBrickIndex.VoxelMeta lhs) { }

	// RVA: 0x85C3D44 Offset: 0x85BFD44 VA: 0x85C3D44
	internal bool <RemoveBricks>b__40_0(ProbeBrickIndex.VoxelMeta lhs) { }
}

// Namespace: UnityEngine.Rendering
internal class ProbeBrickIndex // TypeDefIndex: 19954
{
	// Fields
	internal const int kMaxSubdivisionLevels = 7;
	internal const int kIndexChunkSize = 243;
	private BitArray m_IndexChunks; // 0x10
	private int m_IndexInChunks; // 0x18
	private int m_NextFreeChunk; // 0x1C
	private int m_AvailableChunkCount; // 0x20
	private ComputeBuffer m_PhysicalIndexBuffer; // 0x28
	private int[] m_PhysicalIndexBufferData; // 0x30
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; // 0x38
	private Vector3Int m_CenterRS; // 0x3C
	private Dictionary<Vector3Int, List<ProbeBrickIndex.VoxelMeta>> m_VoxelToBricks; // 0x48
	private Dictionary<ProbeReferenceVolume.Cell, ProbeBrickIndex.BrickMeta> m_BricksToVoxels; // 0x50
	private ObjectPool<ProbeBrickIndex.BrickMeta> m_BrickMetaPool; // 0x58
	private ObjectPool<List<ProbeBrickIndex.VoxelMeta>> m_VoxelMetaListPool; // 0x60
	private ObjectPool<ProbeBrickIndex.VoxelMeta> m_VoxelMetaPool; // 0x68
	private bool m_NeedUpdateIndexComputeBuffer; // 0x70
	private int m_UpdateMinIndex; // 0x74
	private int m_UpdateMaxIndex; // 0x78
	private static ProbeReferenceVolume.Cell g_Cell; // 0x0

	// Properties
	internal int estimatedVMemCost { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85C0F30 Offset: 0x85BCF30 VA: 0x85C0F30
	internal int get_estimatedVMemCost() { }

	[CompilerGenerated]
	// RVA: 0x85C0F38 Offset: 0x85BCF38 VA: 0x85C0F38
	private void set_estimatedVMemCost(int value) { }

	// RVA: 0x85C0F40 Offset: 0x85BCF40 VA: 0x85C0F40
	private int GetVoxelSubdivLevel() { }

	// RVA: 0x85C0FE4 Offset: 0x85BCFE4 VA: 0x85C0FE4
	private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	// RVA: 0x85C1020 Offset: 0x85BD020 VA: 0x85C1020
	internal void .ctor(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	// RVA: 0x85C1A68 Offset: 0x85BDA68 VA: 0x85C1A68
	public int GetRemainingChunkCount() { }

	// RVA: 0x85C1A70 Offset: 0x85BDA70 VA: 0x85C1A70
	internal void UploadIndexData() { }

	// RVA: 0x85C1584 Offset: 0x85BD584 VA: 0x85C1584
	internal void Clear() { }

	// RVA: 0x85C1AB8 Offset: 0x85BDAB8 VA: 0x85C1AB8
	private void MapBrickToVoxels(ProbeBrickIndex.Brick brick, HashSet<Vector3Int> voxels) { }

	// RVA: 0x85C1DEC Offset: 0x85BDDEC VA: 0x85C1DEC
	private void ClearVoxel(Vector3Int pos, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x85C23A8 Offset: 0x85BE3A8 VA: 0x85C23A8
	internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr) { }

	// RVA: 0x85C23E0 Offset: 0x85BE3E0 VA: 0x85C23E0
	internal void Cleanup() { }

	// RVA: 0x85C244C Offset: 0x85BE44C VA: 0x85C244C
	private int MergeIndex(int index, int size) { }

	// RVA: 0x85C2458 Offset: 0x85BE458 VA: 0x85C2458
	internal bool AssignIndexChunksToCell(int bricksCount, ref ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog) { }

	// RVA: 0x85C2638 Offset: 0x85BE638 VA: 0x85C2638
	public void AddBricks(ProbeReferenceVolume.Cell cell, NativeArray<ProbeBrickIndex.Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x85C30B0 Offset: 0x85BF0B0 VA: 0x85C30B0
	public void RemoveBricks(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x85C2E88 Offset: 0x85BEE88 VA: 0x85C2E88
	private void UpdateIndexForVoxel(Vector3Int voxel, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x85C2040 Offset: 0x85BE040 VA: 0x85C2040
	private void UpdatePhysicalIndex(Vector3Int brickMin, Vector3Int brickMax, int value, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x85C1E94 Offset: 0x85BDE94 VA: 0x85C1E94
	private void ClipToIndexSpace(Vector3Int pos, int subdiv, out Vector3Int outMinpos, out Vector3Int outMaxpos, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }

	// RVA: 0x85C3630 Offset: 0x85BF630 VA: 0x85C3630
	private void UpdateIndexForVoxel(Vector3Int voxel, List<ProbeBrickIndex.ReservedBrick> bricks, List<ushort> indices, ProbeBrickIndex.CellIndexUpdateInfo cellInfo) { }
}

// Namespace: 
[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
public struct ProbeBrickPool.BrickChunkAlloc // TypeDefIndex: 19955
{
	// Fields
	public int x; // 0x0
	public int y; // 0x4
	public int z; // 0x8

	// Methods

	// RVA: 0x85C2E74 Offset: 0x85BEE74 VA: 0x85C2E74
	internal int flattenIndex(int sx, int sy) { }
}

// Namespace: 
public struct ProbeBrickPool.DataLocation // TypeDefIndex: 19956
{
	// Fields
	internal Texture TexL0_L1rx; // 0x0
	internal Texture TexL1_G_ry; // 0x8
	internal Texture TexL1_B_rz; // 0x10
	internal Texture TexL2_0; // 0x18
	internal Texture TexL2_1; // 0x20
	internal Texture TexL2_2; // 0x28
	internal Texture TexL2_3; // 0x30
	internal Texture3D TexValidity; // 0x38
	internal int width; // 0x40
	internal int height; // 0x44
	internal int depth; // 0x48

	// Methods

	// RVA: 0x85C44B4 Offset: 0x85C04B4 VA: 0x85C44B4
	internal void Cleanup() { }
}

// Namespace: UnityEngine.Rendering
internal class ProbeBrickPool // TypeDefIndex: 19957
{
	// Fields
	private const int kProbePoolChunkSizeInBricks = 128;
	internal const int kBrickCellCount = 3;
	internal const int kBrickProbeCountPerDim = 4;
	internal const int kBrickProbeCountTotal = 64;
	internal const int kChunkProbeCountPerDim = 512;
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; // 0x10
	private const int kMaxPoolWidth = 2048;
	internal ProbeBrickPool.DataLocation m_Pool; // 0x18
	private ProbeBrickPool.BrickChunkAlloc m_NextFreeChunk; // 0x68
	private Stack<ProbeBrickPool.BrickChunkAlloc> m_FreeList; // 0x78
	private int m_AvailableChunkCount; // 0x80
	private ProbeVolumeSHBands m_SHBands; // 0x84
	private bool m_ContainsValidity; // 0x88

	// Properties
	internal int estimatedVMemCost { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85C3DA4 Offset: 0x85BFDA4 VA: 0x85C3DA4
	internal int get_estimatedVMemCost() { }

	[CompilerGenerated]
	// RVA: 0x85C3DAC Offset: 0x85BFDAC VA: 0x85C3DAC
	private void set_estimatedVMemCost(int value) { }

	// RVA: 0x85C3DB4 Offset: 0x85BFDB4 VA: 0x85C3DB4
	internal void .ctor(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = True) { }

	// RVA: 0x85C43BC Offset: 0x85C03BC VA: 0x85C43BC
	public int GetRemainingChunkCount() { }

	// RVA: 0x85C43C4 Offset: 0x85C03C4 VA: 0x85C43C4
	internal void EnsureTextureValidity() { }

	// RVA: 0x85C4618 Offset: 0x85C0618 VA: 0x85C4618
	internal static int GetChunkSizeInBrickCount() { }

	// RVA: 0x85C4620 Offset: 0x85C0620 VA: 0x85C4620
	internal static int GetChunkSizeInProbeCount() { }

	// RVA: 0x85C4628 Offset: 0x85C0628 VA: 0x85C4628
	internal int GetPoolWidth() { }

	// RVA: 0x85C4630 Offset: 0x85C0630 VA: 0x85C4630
	internal int GetPoolHeight() { }

	// RVA: 0x85C4638 Offset: 0x85C0638 VA: 0x85C4638
	internal Vector3Int GetPoolDimensions() { }

	// RVA: 0x85C4644 Offset: 0x85C0644 VA: 0x85C4644
	internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr) { }

	// RVA: 0x85C4A30 Offset: 0x85C0A30 VA: 0x85C4A30
	internal void Clear() { }

	// RVA: 0x85C4A8C Offset: 0x85C0A8C VA: 0x85C4A8C
	internal static int GetChunkCount(int brickCount, int chunkSizeInBricks) { }

	// RVA: 0x85C4A9C Offset: 0x85C0A9C VA: 0x85C4A9C
	internal bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations, bool ignoreErrorLog) { }

	// RVA: 0x85C4CEC Offset: 0x85C0CEC VA: 0x85C4CEC
	internal void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations) { }

	// RVA: 0x85C4E74 Offset: 0x85C0E74 VA: 0x85C4E74
	internal void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands) { }

	// RVA: 0x85C5210 Offset: 0x85C1210 VA: 0x85C5210
	internal void UpdateValidity(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex) { }

	// RVA: 0x85C53A4 Offset: 0x85C13A4 VA: 0x85C53A4
	internal static Vector3Int ProbeCountToDataLocSize(int numProbes) { }

	// RVA: 0x85C5420 Offset: 0x85C1420 VA: 0x85C5420
	public static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes) { }

	// RVA: 0x85C3F3C Offset: 0x85BFF3C VA: 0x85C3F3C
	public static ProbeBrickPool.DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, out int allocatedBytes) { }

	// RVA: 0x85C3F28 Offset: 0x85BFF28 VA: 0x85C3F28
	private void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth) { }

	// RVA: 0x85C5618 Offset: 0x85C1618 VA: 0x85C5618
	internal void Cleanup() { }
}

// Namespace: UnityEngine.Rendering
internal class ProbeBrickBlendingPool // TypeDefIndex: 19958
{
	// Fields
	private static ComputeShader stateBlendShader; // 0x0
	private static int scenarioBlendingKernel; // 0x8
	private static readonly int _PoolDim_LerpFactor; // 0xC
	private static readonly int _ChunkList; // 0x10
	private static readonly int _State0_L0_L1Rx; // 0x14
	private static readonly int _State0_L1G_L1Ry; // 0x18
	private static readonly int _State0_L1B_L1Rz; // 0x1C
	private static readonly int _State0_L2_0; // 0x20
	private static readonly int _State0_L2_1; // 0x24
	private static readonly int _State0_L2_2; // 0x28
	private static readonly int _State0_L2_3; // 0x2C
	private static readonly int _State1_L0_L1Rx; // 0x30
	private static readonly int _State1_L1G_L1Ry; // 0x34
	private static readonly int _State1_L1B_L1Rz; // 0x38
	private static readonly int _State1_L2_0; // 0x3C
	private static readonly int _State1_L2_1; // 0x40
	private static readonly int _State1_L2_2; // 0x44
	private static readonly int _State1_L2_3; // 0x48
	private static readonly int _Out_L0_L1Rx; // 0x4C
	private static readonly int _Out_L1G_L1Ry; // 0x50
	private static readonly int _Out_L1B_L1Rz; // 0x54
	private static readonly int _Out_L2_0; // 0x58
	private static readonly int _Out_L2_1; // 0x5C
	private static readonly int _Out_L2_2; // 0x60
	private static readonly int _Out_L2_3; // 0x64
	private Vector4[] m_ChunkList; // 0x10
	private int m_MappedChunks; // 0x18
	private ProbeBrickPool m_State0; // 0x20
	private ProbeBrickPool m_State1; // 0x28
	private ProbeVolumeTextureMemoryBudget m_MemoryBudget; // 0x30
	private ProbeVolumeSHBands m_ShBands; // 0x34

	// Properties
	internal static bool isSupported { get; }
	internal bool isAllocated { get; }
	internal int estimatedVMemCost { get; }

	// Methods

	// RVA: 0x85C5620 Offset: 0x85C1620 VA: 0x85C5620
	internal static bool get_isSupported() { }

	// RVA: 0x85C56AC Offset: 0x85C16AC VA: 0x85C56AC
	internal static void Initialize(in ProbeVolumeSystemParameters parameters) { }

	// RVA: 0x85C57C8 Offset: 0x85C17C8 VA: 0x85C57C8
	internal bool get_isAllocated() { }

	// RVA: 0x85C57D8 Offset: 0x85C17D8 VA: 0x85C57D8
	internal int get_estimatedVMemCost() { }

	// RVA: 0x85C580C Offset: 0x85C180C VA: 0x85C580C
	internal int GetPoolWidth() { }

	// RVA: 0x85C5828 Offset: 0x85C1828 VA: 0x85C5828
	internal int GetPoolHeight() { }

	// RVA: 0x85C5844 Offset: 0x85C1844 VA: 0x85C5844
	internal int GetPoolDepth() { }

	// RVA: 0x85C5860 Offset: 0x85C1860 VA: 0x85C5860
	internal void .ctor(ProbeVolumeBlendingTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands) { }

	// RVA: 0x85C588C Offset: 0x85C188C VA: 0x85C588C
	internal void AllocateResourcesIfNeeded() { }

	// RVA: 0x85C59C4 Offset: 0x85C19C4 VA: 0x85C59C4
	internal void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands, int state) { }

	// RVA: 0x85C5A4C Offset: 0x85C1A4C VA: 0x85C5A4C
	private static int DivRoundUp(int x, int y) { }

	// RVA: 0x85C5A5C Offset: 0x85C1A5C VA: 0x85C5A5C
	internal void PerformBlending(CommandBuffer cmd, float factor, ProbeBrickPool dstPool) { }

	// RVA: 0x85C6334 Offset: 0x85C2334 VA: 0x85C6334
	internal void BlendChunks(ProbeReferenceVolume.BlendingCellInfo blendingCell, ProbeBrickPool dstPool) { }

	// RVA: 0x85C644C Offset: 0x85C244C VA: 0x85C644C
	internal void Clear() { }

	// RVA: 0x85C645C Offset: 0x85C245C VA: 0x85C645C
	internal bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations) { }

	// RVA: 0x85C64B4 Offset: 0x85C24B4 VA: 0x85C64B4
	internal void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations) { }

	// RVA: 0x85C6518 Offset: 0x85C2518 VA: 0x85C6518
	internal void EnsureTextureValidity() { }

	// RVA: 0x85C6548 Offset: 0x85C2548 VA: 0x85C6548
	internal void Cleanup() { }

	// RVA: 0x85C6580 Offset: 0x85C2580 VA: 0x85C6580
	private static void .cctor() { }
}

// Namespace: 
internal struct ProbeCellIndices.IndexMetaData // TypeDefIndex: 19959
{
	// Fields
	private static uint[] s_PackedValues; // 0x0
	internal Vector3Int minLocalIdx; // 0x0
	internal Vector3Int maxLocalIdx; // 0xC
	internal int firstChunkIndex; // 0x18
	internal int minSubdiv; // 0x1C

	// Methods

	// RVA: 0x85C6D38 Offset: 0x85C2D38 VA: 0x85C6D38
	internal void Pack(out uint[] vals) { }

	// RVA: 0x85C6F84 Offset: 0x85C2F84 VA: 0x85C6F84
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
internal class ProbeCellIndices // TypeDefIndex: 19960
{
	// Fields
	private const int kUintPerEntry = 3;
	[CompilerGenerated]
	private int <estimatedVMemCost>k__BackingField; // 0x10
	private ComputeBuffer m_IndexOfIndicesBuffer; // 0x18
	private uint[] m_IndexOfIndicesData; // 0x20
	private Vector3Int m_CellCount; // 0x28
	private Vector3Int m_CellMin; // 0x34
	private int m_CellSizeInMinBricks; // 0x40
	private bool m_NeedUpdateComputeBuffer; // 0x44

	// Properties
	internal int estimatedVMemCost { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85C69E0 Offset: 0x85C29E0 VA: 0x85C69E0
	internal int get_estimatedVMemCost() { }

	[CompilerGenerated]
	// RVA: 0x85C69E8 Offset: 0x85C29E8 VA: 0x85C69E8
	private void set_estimatedVMemCost(int value) { }

	// RVA: 0x85C69F0 Offset: 0x85C29F0 VA: 0x85C69F0
	internal Vector3Int GetCellIndexDimension() { }

	// RVA: 0x85C6A00 Offset: 0x85C2A00 VA: 0x85C6A00
	internal Vector3Int GetCellMinPosition() { }

	// RVA: 0x85C6A10 Offset: 0x85C2A10 VA: 0x85C6A10
	private int GetFlatIndex(Vector3Int normalizedPos) { }

	// RVA: 0x85C6A24 Offset: 0x85C2A24 VA: 0x85C6A24
	internal void .ctor(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks) { }

	// RVA: 0x85C6B84 Offset: 0x85C2B84 VA: 0x85C6B84
	internal int GetFlatIdxForCell(Vector3Int cellPosition) { }

	// RVA: 0x85C6BB0 Offset: 0x85C2BB0 VA: 0x85C6BB0
	internal void UpdateCell(int cellFlatIdx, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo) { }

	// RVA: 0x85C6E54 Offset: 0x85C2E54 VA: 0x85C6E54
	internal void MarkCellAsUnloaded(int cellFlatIdx) { }

	// RVA: 0x85C6EB4 Offset: 0x85C2EB4 VA: 0x85C6EB4
	internal void PushComputeData() { }

	// RVA: 0x85C6EE0 Offset: 0x85C2EE0 VA: 0x85C6EE0
	internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr) { }

	// RVA: 0x85C6F18 Offset: 0x85C2F18 VA: 0x85C6F18
	internal void Cleanup() { }
}

// Namespace: UnityEngine.Rendering
public struct ProbeVolumeSystemParameters // TypeDefIndex: 19961
{
	// Fields
	public ProbeVolumeTextureMemoryBudget memoryBudget; // 0x0
	public ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget; // 0x4
	public Mesh probeDebugMesh; // 0x8
	public Shader probeDebugShader; // 0x10
	public Mesh offsetDebugMesh; // 0x18
	public Shader offsetDebugShader; // 0x20
	public ComputeShader scenarioBlendingShader; // 0x28
	public ProbeVolumeSceneData sceneData; // 0x30
	public ProbeVolumeSHBands shBands; // 0x38
	public bool supportsRuntimeDebug; // 0x3C
	public bool supportStreaming; // 0x3D
}

// Namespace: UnityEngine.Rendering
public struct ProbeVolumeShadingParameters // TypeDefIndex: 19962
{
	// Fields
	public float normalBias; // 0x0
	public float viewBias; // 0x4
	public bool scaleBiasByMinDistanceBetweenProbes; // 0x8
	public float samplingNoise; // 0xC
	public float weight; // 0x10
	public APVLeakReductionMode leakReductionMode; // 0x14
	public float occlusionWeightContribution; // 0x18
	public float minValidNormalWeight; // 0x1C
	public int frameIndexForNoise; // 0x20
	public float reflNormalizationLowerClamp; // 0x24
	public float reflNormalizationUpperClamp; // 0x28
}

// Namespace: UnityEngine.Rendering
[Serializable]
public enum ProbeVolumeTextureMemoryBudget // TypeDefIndex: 19963
{
	// Fields
	public int value__; // 0x0
	public const ProbeVolumeTextureMemoryBudget MemoryBudgetLow = 512;
	public const ProbeVolumeTextureMemoryBudget MemoryBudgetMedium = 1024;
	public const ProbeVolumeTextureMemoryBudget MemoryBudgetHigh = 2048;
}

// Namespace: UnityEngine.Rendering
[Serializable]
public enum ProbeVolumeBlendingTextureMemoryBudget // TypeDefIndex: 19964
{
	// Fields
	public int value__; // 0x0
	public const ProbeVolumeBlendingTextureMemoryBudget None = 0;
	public const ProbeVolumeBlendingTextureMemoryBudget MemoryBudgetLow = 128;
	public const ProbeVolumeBlendingTextureMemoryBudget MemoryBudgetMedium = 256;
	public const ProbeVolumeBlendingTextureMemoryBudget MemoryBudgetHigh = 512;
}

// Namespace: UnityEngine.Rendering
[Serializable]
public enum ProbeVolumeSHBands // TypeDefIndex: 19965
{
	// Fields
	public int value__; // 0x0
	public const ProbeVolumeSHBands SphericalHarmonicsL1 = 1;
	public const ProbeVolumeSHBands SphericalHarmonicsL2 = 2;
}

// Namespace: 
public struct ProbeReferenceVolume.Cell.PerScenarioData // TypeDefIndex: 19966
{
	// Fields
	[CompilerGenerated]
	private NativeArray<ushort> <shL0L1RxData>k__BackingField; // 0x0
	[CompilerGenerated]
	private NativeArray<byte> <shL1GL1RyData>k__BackingField; // 0x10
	[CompilerGenerated]
	private NativeArray<byte> <shL1BL1RzData>k__BackingField; // 0x20
	[CompilerGenerated]
	private NativeArray<byte> <shL2Data_0>k__BackingField; // 0x30
	[CompilerGenerated]
	private NativeArray<byte> <shL2Data_1>k__BackingField; // 0x40
	[CompilerGenerated]
	private NativeArray<byte> <shL2Data_2>k__BackingField; // 0x50
	[CompilerGenerated]
	private NativeArray<byte> <shL2Data_3>k__BackingField; // 0x60

	// Properties
	public NativeArray<ushort> shL0L1RxData { get; set; }
	public NativeArray<byte> shL1GL1RyData { get; set; }
	public NativeArray<byte> shL1BL1RzData { get; set; }
	public NativeArray<byte> shL2Data_0 { get; set; }
	public NativeArray<byte> shL2Data_1 { get; set; }
	public NativeArray<byte> shL2Data_2 { get; set; }
	public NativeArray<byte> shL2Data_3 { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x85D174C Offset: 0x85CD74C VA: 0x85D174C
	public NativeArray<ushort> get_shL0L1RxData() { }

	[CompilerGenerated]
	// RVA: 0x85D1758 Offset: 0x85CD758 VA: 0x85D1758
	internal void set_shL0L1RxData(NativeArray<ushort> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x85D1760 Offset: 0x85CD760 VA: 0x85D1760
	public NativeArray<byte> get_shL1GL1RyData() { }

	[CompilerGenerated]
	// RVA: 0x85D176C Offset: 0x85CD76C VA: 0x85D176C
	internal void set_shL1GL1RyData(NativeArray<byte> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85D1774 Offset: 0x85CD774 VA: 0x85D1774
	public NativeArray<byte> get_shL1BL1RzData() { }

	[CompilerGenerated]
	// RVA: 0x85D1780 Offset: 0x85CD780 VA: 0x85D1780
	internal void set_shL1BL1RzData(NativeArray<byte> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x85D1788 Offset: 0x85CD788 VA: 0x85D1788
	public NativeArray<byte> get_shL2Data_0() { }

	[CompilerGenerated]
	// RVA: 0x85D1794 Offset: 0x85CD794 VA: 0x85D1794
	internal void set_shL2Data_0(NativeArray<byte> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85D179C Offset: 0x85CD79C VA: 0x85D179C
	public NativeArray<byte> get_shL2Data_1() { }

	[CompilerGenerated]
	// RVA: 0x85D17A8 Offset: 0x85CD7A8 VA: 0x85D17A8
	internal void set_shL2Data_1(NativeArray<byte> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x85D17B0 Offset: 0x85CD7B0 VA: 0x85D17B0
	public NativeArray<byte> get_shL2Data_2() { }

	[CompilerGenerated]
	// RVA: 0x85D17BC Offset: 0x85CD7BC VA: 0x85D17BC
	internal void set_shL2Data_2(NativeArray<byte> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x85D17C4 Offset: 0x85CD7C4 VA: 0x85D17C4
	public NativeArray<byte> get_shL2Data_3() { }

	[CompilerGenerated]
	// RVA: 0x85D17D0 Offset: 0x85CD7D0 VA: 0x85D17D0
	internal void set_shL2Data_3(NativeArray<byte> value) { }
}

// Namespace: 
[DebuggerDisplay("Index = {index} position = {position}")]
[Serializable]
internal class ProbeReferenceVolume.Cell // TypeDefIndex: 19967
{
	// Fields
	public Vector3Int position; // 0x10
	public int index; // 0x1C
	public int probeCount; // 0x20
	public int minSubdiv; // 0x24
	public int maxSubdiv; // 0x28
	public int indexChunkCount; // 0x2C
	public int shChunkCount; // 0x30
	public bool hasTwoScenarios; // 0x34
	public ProbeVolumeSHBands shBands; // 0x38
	[CompilerGenerated]
	private NativeArray<ProbeBrickIndex.Brick> <bricks>k__BackingField; // 0x40
	[CompilerGenerated]
	private NativeArray<byte> <validityNeighMaskData>k__BackingField; // 0x50
	[CompilerGenerated]
	private NativeArray<Vector3> <probePositions>k__BackingField; // 0x60
	[CompilerGenerated]
	private NativeArray<float> <touchupVolumeInteraction>k__BackingField; // 0x70
	[CompilerGenerated]
	private NativeArray<Vector3> <offsetVectors>k__BackingField; // 0x80
	[CompilerGenerated]
	private NativeArray<float> <validity>k__BackingField; // 0x90
	public ProbeReferenceVolume.Cell.PerScenarioData scenario0; // 0xA0
	public ProbeReferenceVolume.Cell.PerScenarioData scenario1; // 0x110

	// Properties
	public NativeArray<ProbeBrickIndex.Brick> bricks { get; set; }
	public NativeArray<byte> validityNeighMaskData { get; set; }
	public NativeArray<Vector3> probePositions { get; set; }
	public NativeArray<float> touchupVolumeInteraction { get; set; }
	public NativeArray<Vector3> offsetVectors { get; set; }
	public NativeArray<float> validity { get; set; }
	public ProbeReferenceVolume.Cell.PerScenarioData bakingScenario { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85D16BC Offset: 0x85CD6BC VA: 0x85D16BC
	public NativeArray<ProbeBrickIndex.Brick> get_bricks() { }

	[CompilerGenerated]
	// RVA: 0x85D16C8 Offset: 0x85CD6C8 VA: 0x85D16C8
	internal void set_bricks(NativeArray<ProbeBrickIndex.Brick> value) { }

	[CompilerGenerated]
	// RVA: 0x85D16D0 Offset: 0x85CD6D0 VA: 0x85D16D0
	public NativeArray<byte> get_validityNeighMaskData() { }

	[CompilerGenerated]
	// RVA: 0x85D16DC Offset: 0x85CD6DC VA: 0x85D16DC
	internal void set_validityNeighMaskData(NativeArray<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x85D16E4 Offset: 0x85CD6E4 VA: 0x85D16E4
	public NativeArray<Vector3> get_probePositions() { }

	[CompilerGenerated]
	// RVA: 0x85D16F0 Offset: 0x85CD6F0 VA: 0x85D16F0
	internal void set_probePositions(NativeArray<Vector3> value) { }

	[CompilerGenerated]
	// RVA: 0x85D16F8 Offset: 0x85CD6F8 VA: 0x85D16F8
	public NativeArray<float> get_touchupVolumeInteraction() { }

	[CompilerGenerated]
	// RVA: 0x85D1704 Offset: 0x85CD704 VA: 0x85D1704
	internal void set_touchupVolumeInteraction(NativeArray<float> value) { }

	[CompilerGenerated]
	// RVA: 0x85D170C Offset: 0x85CD70C VA: 0x85D170C
	public NativeArray<Vector3> get_offsetVectors() { }

	[CompilerGenerated]
	// RVA: 0x85D1718 Offset: 0x85CD718 VA: 0x85D1718
	internal void set_offsetVectors(NativeArray<Vector3> value) { }

	[CompilerGenerated]
	// RVA: 0x85D1720 Offset: 0x85CD720 VA: 0x85D1720
	public NativeArray<float> get_validity() { }

	[CompilerGenerated]
	// RVA: 0x85D172C Offset: 0x85CD72C VA: 0x85D172C
	internal void set_validity(NativeArray<float> value) { }

	// RVA: 0x85D1734 Offset: 0x85CD734 VA: 0x85D1734
	public ProbeReferenceVolume.Cell.PerScenarioData get_bakingScenario() { }

	// RVA: 0x85D1744 Offset: 0x85CD744 VA: 0x85D1744
	public void .ctor() { }
}

// Namespace: 
[DebuggerDisplay("Index = {cell.index} Loaded = {loaded}")]
internal class ProbeReferenceVolume.CellInfo : IComparable<ProbeReferenceVolume.CellInfo> // TypeDefIndex: 19968
{
	// Fields
	public ProbeReferenceVolume.Cell cell; // 0x10
	public ProbeReferenceVolume.BlendingCellInfo blendingCell; // 0x18
	public List<ProbeBrickPool.BrickChunkAlloc> chunkList; // 0x20
	public int flatIdxInCellIndices; // 0x28
	public bool loaded; // 0x2C
	public ProbeBrickIndex.CellIndexUpdateInfo updateInfo; // 0x30
	public bool indexUpdated; // 0x60
	public ProbeBrickIndex.CellIndexUpdateInfo tempUpdateInfo; // 0x64
	public int sourceAssetInstanceID; // 0x94
	public float streamingScore; // 0x98
	public int referenceCount; // 0x9C
	public ProbeReferenceVolume.CellInstancedDebugProbes debugProbes; // 0xA0

	// Methods

	// RVA: 0x85D17D8 Offset: 0x85CD7D8 VA: 0x85D17D8 Slot: 4
	public int CompareTo(ProbeReferenceVolume.CellInfo other) { }

	// RVA: 0x85D1814 Offset: 0x85CD814 VA: 0x85D1814
	public void Clear() { }

	// RVA: 0x85D18B4 Offset: 0x85CD8B4 VA: 0x85D18B4
	public void .ctor() { }
}

// Namespace: 
[DebuggerDisplay("Index = {cellInfo.cell.index} Factor = {blendingFactor} Score = {streamingScore}")]
internal class ProbeReferenceVolume.BlendingCellInfo : IComparable<ProbeReferenceVolume.BlendingCellInfo> // TypeDefIndex: 19969
{
	// Fields
	public ProbeReferenceVolume.CellInfo cellInfo; // 0x10
	public List<ProbeBrickPool.BrickChunkAlloc> chunkList; // 0x18
	public float streamingScore; // 0x20
	public float blendingFactor; // 0x24
	public bool blending; // 0x28

	// Methods

	// RVA: 0x85D1944 Offset: 0x85CD944 VA: 0x85D1944 Slot: 4
	public int CompareTo(ProbeReferenceVolume.BlendingCellInfo other) { }

	// RVA: 0x85D1980 Offset: 0x85CD980 VA: 0x85D1980
	public void Clear() { }

	// RVA: 0x85D19EC Offset: 0x85CD9EC VA: 0x85D19EC
	public void MarkUpToDate() { }

	// RVA: 0x85D19F8 Offset: 0x85CD9F8 VA: 0x85D19F8
	public bool IsUpToDate() { }

	// RVA: 0x85D1A10 Offset: 0x85CDA10 VA: 0x85D1A10
	public void ForceReupload() { }

	// RVA: 0x85D1A1C Offset: 0x85CDA1C VA: 0x85D1A1C
	public bool ShouldReupload() { }

	// RVA: 0x85D1A30 Offset: 0x85CDA30 VA: 0x85D1A30
	public void Prioritize() { }

	// RVA: 0x85D1A3C Offset: 0x85CDA3C VA: 0x85D1A3C
	public bool ShouldPrioritize() { }

	// RVA: 0x85D1A50 Offset: 0x85CDA50 VA: 0x85D1A50
	public void .ctor() { }
}

// Namespace: 
internal struct ProbeReferenceVolume.Volume : IEquatable<ProbeReferenceVolume.Volume> // TypeDefIndex: 19970
{
	// Fields
	internal Vector3 corner; // 0x0
	internal Vector3 X; // 0xC
	internal Vector3 Y; // 0x18
	internal Vector3 Z; // 0x24
	internal float maxSubdivisionMultiplier; // 0x30
	internal float minSubdivisionMultiplier; // 0x34

	// Methods

	// RVA: 0x85D1AD8 Offset: 0x85CDAD8 VA: 0x85D1AD8
	public void .ctor(Matrix4x4 trs, float maxSubdivision, float minSubdivision) { }

	// RVA: 0x85D1BBC Offset: 0x85CDBBC VA: 0x85D1BBC
	public void .ctor(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1, float minSubdivision = 0) { }

	// RVA: 0x85D1BF8 Offset: 0x85CDBF8 VA: 0x85D1BF8
	public void .ctor(ProbeReferenceVolume.Volume copy) { }

	// RVA: 0x85D1C9C Offset: 0x85CDC9C VA: 0x85D1C9C
	public void .ctor(Bounds bounds) { }

	// RVA: 0x85D1CFC Offset: 0x85CDCFC VA: 0x85D1CFC
	public Bounds CalculateAABB() { }

	// RVA: 0x85D1E00 Offset: 0x85CDE00 VA: 0x85D1E00
	public void CalculateCenterAndSize(out Vector3 center, out Vector3 size) { }

	// RVA: 0x85D1FC8 Offset: 0x85CDFC8 VA: 0x85D1FC8
	public void Transform(Matrix4x4 trs) { }

	// RVA: 0x85D2078 Offset: 0x85CE078 VA: 0x85D2078 Slot: 3
	public override string ToString() { }

	// RVA: 0x85D22D4 Offset: 0x85CE2D4 VA: 0x85D22D4 Slot: 4
	public bool Equals(ProbeReferenceVolume.Volume other) { }
}

// Namespace: 
internal struct ProbeReferenceVolume.RefVolTransform // TypeDefIndex: 19971
{
	// Fields
	public Vector3 posWS; // 0x0
	public Quaternion rot; // 0xC
	public float scale; // 0x1C
}

// Namespace: 
public struct ProbeReferenceVolume.RuntimeResources // TypeDefIndex: 19972
{
	// Fields
	public ComputeBuffer index; // 0x0
	public ComputeBuffer cellIndices; // 0x8
	public RenderTexture L0_L1rx; // 0x10
	public RenderTexture L1_G_ry; // 0x18
	public RenderTexture L1_B_rz; // 0x20
	public RenderTexture L2_0; // 0x28
	public RenderTexture L2_1; // 0x30
	public RenderTexture L2_2; // 0x38
	public RenderTexture L2_3; // 0x40
	public Texture3D Validity; // 0x48
}

// Namespace: 
public struct ProbeReferenceVolume.ExtraDataActionInput // TypeDefIndex: 19973
{}

// Namespace: 
private struct ProbeReferenceVolume.InitInfo // TypeDefIndex: 19974
{
	// Fields
	public Vector3Int pendingMinCellPosition; // 0x0
	public Vector3Int pendingMaxCellPosition; // 0xC
}

// Namespace: 
internal class ProbeReferenceVolume.CellInstancedDebugProbes // TypeDefIndex: 19975
{
	// Fields
	public List<Matrix4x4[]> probeBuffers; // 0x10
	public List<Matrix4x4[]> offsetBuffers; // 0x18
	public List<MaterialPropertyBlock> props; // 0x20

	// Methods

	// RVA: 0x85D23D8 Offset: 0x85CE3D8 VA: 0x85D23D8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProbeReferenceVolume.<>c // TypeDefIndex: 19976
{
	// Fields
	public static readonly ProbeReferenceVolume.<>c <>9; // 0x0
	public static UnityAction<ProbeReferenceVolume.CellInfo> <>9__120_0; // 0x8
	public static UnityAction<ProbeReferenceVolume.BlendingCellInfo> <>9__120_1; // 0x10
	public static Func<float> <>9__171_7; // 0x18
	public static Func<float> <>9__171_16; // 0x20
	public static Func<float> <>9__171_17; // 0x28
	public static Func<int> <>9__171_22; // 0x30
	public static Func<int> <>9__171_23; // 0x38
	public static Func<int> <>9__171_26; // 0x40
	public static Func<int> <>9__171_27; // 0x48
	public static Func<float> <>9__171_32; // 0x50
	public static Func<float> <>9__171_33; // 0x58
	public static Func<float> <>9__171_36; // 0x60
	public static Func<int> <>9__171_39; // 0x68
	public static Action<int> <>9__171_40; // 0x70
	public static Func<int> <>9__171_41; // 0x78
	public static Func<int> <>9__171_43; // 0x80
	public static Action<int> <>9__171_44; // 0x88
	public static Func<int> <>9__171_45; // 0x90
	public static Func<float> <>9__171_46; // 0x98
	public static Action<float> <>9__171_47; // 0xA0
	public static Func<float> <>9__171_48; // 0xA8
	public static Func<float> <>9__171_49; // 0xB0
	public static Func<float> <>9__171_54; // 0xB8
	public static Action<float> <>9__171_55; // 0xC0
	public static Func<float> <>9__171_56; // 0xC8
	public static Func<float> <>9__171_57; // 0xD0

	// Methods

	// RVA: 0x85D23E0 Offset: 0x85CE3E0 VA: 0x85D23E0
	private static void .cctor() { }

	// RVA: 0x85D2448 Offset: 0x85CE448 VA: 0x85D2448
	public void .ctor() { }

	// RVA: 0x85D2450 Offset: 0x85CE450 VA: 0x85D2450
	internal void <.ctor>b__120_0(ProbeReferenceVolume.CellInfo x) { }

	// RVA: 0x85D2464 Offset: 0x85CE464 VA: 0x85D2464
	internal void <.ctor>b__120_1(ProbeReferenceVolume.BlendingCellInfo x) { }

	// RVA: 0x85D2478 Offset: 0x85CE478 VA: 0x85D2478
	internal float <RegisterDebug>b__171_7() { }

	// RVA: 0x85D2480 Offset: 0x85CE480 VA: 0x85D2480
	internal float <RegisterDebug>b__171_16() { }

	// RVA: 0x85D248C Offset: 0x85CE48C VA: 0x85D248C
	internal float <RegisterDebug>b__171_17() { }

	// RVA: 0x85D2494 Offset: 0x85CE494 VA: 0x85D2494
	internal int <RegisterDebug>b__171_22() { }

	// RVA: 0x85D249C Offset: 0x85CE49C VA: 0x85D249C
	internal int <RegisterDebug>b__171_23() { }

	// RVA: 0x85D2534 Offset: 0x85CE534 VA: 0x85D2534
	internal int <RegisterDebug>b__171_26() { }

	// RVA: 0x85D253C Offset: 0x85CE53C VA: 0x85D253C
	internal int <RegisterDebug>b__171_27() { }

	// RVA: 0x85D25D4 Offset: 0x85CE5D4 VA: 0x85D25D4
	internal float <RegisterDebug>b__171_32() { }

	// RVA: 0x85D25E0 Offset: 0x85CE5E0 VA: 0x85D25E0
	internal float <RegisterDebug>b__171_33() { }

	// RVA: 0x85D25EC Offset: 0x85CE5EC VA: 0x85D25EC
	internal float <RegisterDebug>b__171_36() { }

	// RVA: 0x85D25F4 Offset: 0x85CE5F4 VA: 0x85D25F4
	internal int <RegisterDebug>b__171_39() { }

	// RVA: 0x85D2688 Offset: 0x85CE688 VA: 0x85D2688
	internal void <RegisterDebug>b__171_40(int value) { }

	// RVA: 0x85D2724 Offset: 0x85CE724 VA: 0x85D2724
	internal int <RegisterDebug>b__171_41() { }

	// RVA: 0x85D272C Offset: 0x85CE72C VA: 0x85D272C
	internal int <RegisterDebug>b__171_43() { }

	// RVA: 0x85D27C0 Offset: 0x85CE7C0 VA: 0x85D27C0
	internal void <RegisterDebug>b__171_44(int value) { }

	// RVA: 0x85D285C Offset: 0x85CE85C VA: 0x85D285C
	internal int <RegisterDebug>b__171_45() { }

	// RVA: 0x85D2864 Offset: 0x85CE864 VA: 0x85D2864
	internal float <RegisterDebug>b__171_46() { }

	// RVA: 0x85D28F8 Offset: 0x85CE8F8 VA: 0x85D28F8
	internal void <RegisterDebug>b__171_47(float value) { }

	// RVA: 0x85D299C Offset: 0x85CE99C VA: 0x85D299C
	internal float <RegisterDebug>b__171_48() { }

	// RVA: 0x85D29A4 Offset: 0x85CE9A4 VA: 0x85D29A4
	internal float <RegisterDebug>b__171_49() { }

	// RVA: 0x85D29AC Offset: 0x85CE9AC VA: 0x85D29AC
	internal float <RegisterDebug>b__171_54() { }

	// RVA: 0x85D2A40 Offset: 0x85CEA40 VA: 0x85D2A40
	internal void <RegisterDebug>b__171_55(float value) { }

	// RVA: 0x85D2AE4 Offset: 0x85CEAE4 VA: 0x85D2AE4
	internal float <RegisterDebug>b__171_56() { }

	// RVA: 0x85D2AEC Offset: 0x85CEAEC VA: 0x85D2AEC
	internal float <RegisterDebug>b__171_57() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ProbeReferenceVolume.<>c__DisplayClass171_0 // TypeDefIndex: 19977
{
	// Fields
	public ProbeReferenceVolume <>4__this; // 0x10
	public ProbeVolumeSystemParameters parameters; // 0x18

	// Methods

	// RVA: 0x85D2AF4 Offset: 0x85CEAF4 VA: 0x85D2AF4
	public void .ctor() { }

	// RVA: -1 Offset: -1
	internal void <RegisterDebug>g__RefreshDebug|0<T>(DebugUI.Field<T> field, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47A1A44 Offset: 0x479DA44 VA: 0x47A1A44
	|-ProbeReferenceVolume.<>c__DisplayClass171_0.<RegisterDebug>g__RefreshDebug|0<bool>
	|
	|-RVA: 0x47A1AB0 Offset: 0x479DAB0 VA: 0x47A1AB0
	|-ProbeReferenceVolume.<>c__DisplayClass171_0.<RegisterDebug>g__RefreshDebug|0<int>
	|
	|-RVA: 0x47A1B1C Offset: 0x479DB1C VA: 0x47A1B1C
	|-ProbeReferenceVolume.<>c__DisplayClass171_0.<RegisterDebug>g__RefreshDebug|0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x85D2AFC Offset: 0x85CEAFC VA: 0x85D2AFC
	internal bool <RegisterDebug>b__1() { }

	// RVA: 0x85D2B20 Offset: 0x85CEB20 VA: 0x85D2B20
	internal void <RegisterDebug>b__2(bool value) { }

	// RVA: 0x85D2B48 Offset: 0x85CEB48 VA: 0x85D2B48
	internal bool <RegisterDebug>b__3() { }

	// RVA: 0x85D2B6C Offset: 0x85CEB6C VA: 0x85D2B6C
	internal void <RegisterDebug>b__4(bool value) { }

	// RVA: 0x85D2B94 Offset: 0x85CEB94 VA: 0x85D2B94
	internal float <RegisterDebug>b__5() { }

	// RVA: 0x85D2BB8 Offset: 0x85CEBB8 VA: 0x85D2BB8
	internal void <RegisterDebug>b__6(float value) { }

	// RVA: 0x85D2BDC Offset: 0x85CEBDC VA: 0x85D2BDC
	internal bool <RegisterDebug>b__8() { }

	// RVA: 0x85D2C00 Offset: 0x85CEC00 VA: 0x85D2C00
	internal void <RegisterDebug>b__9(bool value) { }

	// RVA: 0x85D2C28 Offset: 0x85CEC28 VA: 0x85D2C28
	internal int <RegisterDebug>b__10() { }

	// RVA: 0x85D2C4C Offset: 0x85CEC4C VA: 0x85D2C4C
	internal void <RegisterDebug>b__11(int value) { }

	// RVA: 0x85D2C70 Offset: 0x85CEC70 VA: 0x85D2C70
	internal int <RegisterDebug>b__12() { }

	// RVA: 0x85D2C94 Offset: 0x85CEC94 VA: 0x85D2C94
	internal void <RegisterDebug>b__13(int value) { }

	// RVA: 0x85D2CB8 Offset: 0x85CECB8 VA: 0x85D2CB8
	internal float <RegisterDebug>b__14() { }

	// RVA: 0x85D2CDC Offset: 0x85CECDC VA: 0x85D2CDC
	internal void <RegisterDebug>b__15(float value) { }

	// RVA: 0x85D2D00 Offset: 0x85CED00 VA: 0x85D2D00
	internal float <RegisterDebug>b__18() { }

	// RVA: 0x85D2D24 Offset: 0x85CED24 VA: 0x85D2D24
	internal void <RegisterDebug>b__19(float value) { }

	// RVA: 0x85D2D48 Offset: 0x85CED48 VA: 0x85D2D48
	internal int <RegisterDebug>b__20() { }

	// RVA: 0x85D2D6C Offset: 0x85CED6C VA: 0x85D2D6C
	internal void <RegisterDebug>b__21(int v) { }

	// RVA: 0x85D2E30 Offset: 0x85CEE30 VA: 0x85D2E30
	internal int <RegisterDebug>b__24() { }

	// RVA: 0x85D2E54 Offset: 0x85CEE54 VA: 0x85D2E54
	internal void <RegisterDebug>b__25(int v) { }

	// RVA: 0x85D2E7C Offset: 0x85CEE7C VA: 0x85D2E7C
	internal bool <RegisterDebug>b__28() { }

	// RVA: 0x85D2EA0 Offset: 0x85CEEA0 VA: 0x85D2EA0
	internal void <RegisterDebug>b__29(bool value) { }

	// RVA: 0x85D2F98 Offset: 0x85CEF98 VA: 0x85D2F98
	internal float <RegisterDebug>b__30() { }

	// RVA: 0x85D2FBC Offset: 0x85CEFBC VA: 0x85D2FBC
	internal void <RegisterDebug>b__31(float value) { }

	// RVA: 0x85D2FE0 Offset: 0x85CEFE0 VA: 0x85D2FE0
	internal float <RegisterDebug>b__34() { }

	// RVA: 0x85D3004 Offset: 0x85CF004 VA: 0x85D3004
	internal void <RegisterDebug>b__35(float value) { }

	// RVA: 0x85D3028 Offset: 0x85CF028 VA: 0x85D3028
	internal bool <RegisterDebug>b__37() { }

	// RVA: 0x85D304C Offset: 0x85CF04C VA: 0x85D304C
	internal void <RegisterDebug>b__38(bool value) { }

	// RVA: 0x85D3074 Offset: 0x85CF074 VA: 0x85D3074
	internal void <RegisterDebug>g__RefreshScenarioNames|42(string guid) { }

	// RVA: 0x85D37BC Offset: 0x85CF7BC VA: 0x85D37BC
	internal int <RegisterDebug>b__50() { }

	// RVA: 0x85D39E4 Offset: 0x85CF9E4 VA: 0x85D39E4
	internal void <RegisterDebug>b__51(int value) { }

	// RVA: 0x85D3E8C Offset: 0x85CFE8C VA: 0x85D3E8C
	internal int <RegisterDebug>b__52() { }

	// RVA: 0x85D3EB0 Offset: 0x85CFEB0 VA: 0x85D3EB0
	internal void <RegisterDebug>b__53(int value) { }
}

// Namespace: UnityEngine.Rendering
public class ProbeReferenceVolume // TypeDefIndex: 19978
{
	// Fields
	private bool m_IsInitialized; // 0x10
	private bool m_SupportStreaming; // 0x11
	private ProbeReferenceVolume.RefVolTransform m_Transform; // 0x14
	private int m_MaxSubdivision; // 0x34
	private ProbeBrickPool m_Pool; // 0x38
	private ProbeBrickIndex m_Index; // 0x40
	private ProbeCellIndices m_CellIndices; // 0x48
	private ProbeBrickBlendingPool m_BlendingPool; // 0x50
	private List<ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks; // 0x58
	private float[] m_PositionOffsets; // 0x60
	private Bounds m_CurrGlobalBounds; // 0x68
	internal Dictionary<int, ProbeReferenceVolume.CellInfo> cells; // 0x80
	private ObjectPool<ProbeReferenceVolume.CellInfo> m_CellInfoPool; // 0x88
	private ObjectPool<ProbeReferenceVolume.BlendingCellInfo> m_BlendingCellInfoPool; // 0x90
	private ProbeBrickPool.DataLocation m_TemporaryDataLocation; // 0x98
	private int m_TemporaryDataLocationMemCost; // 0xE8
	private int m_CurrentProbeVolumeChunkSizeInBricks; // 0xEC
	internal ProbeVolumeSceneData sceneData; // 0xF0
	private Vector3Int minLoadedCellPos; // 0xF8
	private Vector3Int maxLoadedCellPos; // 0x104
	public Action<ProbeReferenceVolume.ExtraDataActionInput> retrieveExtraDataAction; // 0x110
	public Action checksDuringBakeAction; // 0x118
	private bool m_BricksLoaded; // 0x120
	private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeLoaded; // 0x128
	private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeUnloaded; // 0x130
	private Dictionary<string, ProbeVolumeAsset> m_ActiveAssets; // 0x138
	private bool m_NeedLoadAsset; // 0x140
	private bool m_ProbeReferenceVolumeInit; // 0x141
	private bool m_EnabledBySRP; // 0x142
	private ProbeReferenceVolume.InitInfo m_PendingInitInfo; // 0x144
	private bool m_NeedsIndexRebuild; // 0x15C
	private bool m_HasChangedIndex; // 0x15D
	private int m_CBShaderID; // 0x160
	private int m_NumberOfCellsLoadedPerFrame; // 0x164
	private int m_NumberOfCellsBlendedPerFrame; // 0x168
	private float m_TurnoverRate; // 0x16C
	private ProbeVolumeTextureMemoryBudget m_MemoryBudget; // 0x170
	private ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget; // 0x174
	private ProbeVolumeSHBands m_SHBands; // 0x178
	private float m_ProbeVolumesWeight; // 0x17C
	internal bool clearAssetsOnVolumeClear; // 0x180
	internal static string defaultLightingScenario; // 0x0
	private static ProbeReferenceVolume _instance; // 0x8
	[CompilerGenerated]
	private List<ProbeVolumePerSceneData> <perSceneDataList>k__BackingField; // 0x188
	private const int kProbesPerBatch = 511;
	public static readonly string k_DebugPanelName; // 0x10
	[CompilerGenerated]
	private readonly ProbeVolumeDebug <probeVolumeDebug>k__BackingField; // 0x190
	[CompilerGenerated]
	private readonly Color[] <subdivisionDebugColors>k__BackingField; // 0x198
	private DebugUI.Widget[] m_DebugItems; // 0x1A0
	private Mesh m_DebugMesh; // 0x1A8
	private Material m_DebugMaterial; // 0x1B0
	private Mesh m_DebugOffsetMesh; // 0x1B8
	private Material m_DebugOffsetMaterial; // 0x1C0
	private Plane[] m_DebugFrustumPlanes; // 0x1C8
	private GUIContent[] m_DebugScenarioNames; // 0x1D0
	private int[] m_DebugScenarioValues; // 0x1D8
	private string m_DebugActiveSceneGUID; // 0x1E0
	private string m_DebugActiveScenario; // 0x1E8
	private DebugUI.EnumField m_DebugScenarioField; // 0x1F0
	internal ProbeVolumeBakingProcessSettings bakingProcessSettings; // 0x1F8
	internal Dictionary<Bounds, ProbeBrickIndex.Brick[]> realtimeSubdivisionInfo; // 0x228
	private bool m_MaxSubdivVisualizedIsMaxAvailable; // 0x230
	private DynamicArray<ProbeReferenceVolume.CellInfo> m_LoadedCells; // 0x238
	private DynamicArray<ProbeReferenceVolume.CellInfo> m_ToBeLoadedCells; // 0x240
	private DynamicArray<ProbeReferenceVolume.CellInfo> m_TempCellToLoadList; // 0x248
	private DynamicArray<ProbeReferenceVolume.CellInfo> m_TempCellToUnloadList; // 0x250
	private DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_LoadedBlendingCells; // 0x258
	private DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_ToBeLoadedBlendingCells; // 0x260
	private DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_TempBlendingCellToLoadList; // 0x268
	private DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_TempBlendingCellToUnloadList; // 0x270
	private Vector3 m_FrozenCameraPosition; // 0x278
	private bool m_HasRemainingCellsToBlend; // 0x284

	// Properties
	internal Bounds globalBounds { get; set; }
	public bool isInitialized { get; }
	internal bool enabledBySRP { get; }
	internal bool hasUnloadedCells { get; }
	internal bool enableScenarioBlending { get; }
	internal int numberOfCellsLoadedPerFrame { get; }
	public int numberOfCellsBlendedPerFrame { get; set; }
	public float turnoverRate { get; set; }
	public ProbeVolumeSHBands shBands { get; }
	public string lightingScenario { get; set; }
	public float scenarioBlendingFactor { get; set; }
	public ProbeVolumeTextureMemoryBudget memoryBudget { get; }
	public float probeVolumesWeight { get; set; }
	internal List<ProbeVolumePerSceneData> perSceneDataList { get; set; }
	public static ProbeReferenceVolume instance { get; }
	internal ProbeVolumeDebug probeVolumeDebug { get; }
	public Color[] subdivisionDebugColors { get; }

	// Methods

	// RVA: 0x85C6FF8 Offset: 0x85C2FF8 VA: 0x85C6FF8
	internal Bounds get_globalBounds() { }

	// RVA: 0x85C700C Offset: 0x85C300C VA: 0x85C700C
	internal void set_globalBounds(Bounds value) { }

	// RVA: 0x85C7020 Offset: 0x85C3020 VA: 0x85C7020
	public bool get_isInitialized() { }

	// RVA: 0x85C7028 Offset: 0x85C3028 VA: 0x85C7028
	internal bool get_enabledBySRP() { }

	// RVA: 0x85C7030 Offset: 0x85C3030 VA: 0x85C7030
	internal bool get_hasUnloadedCells() { }

	// RVA: 0x85C7080 Offset: 0x85C3080 VA: 0x85C7080
	internal bool get_enableScenarioBlending() { }

	// RVA: 0x85C70E8 Offset: 0x85C30E8 VA: 0x85C70E8
	internal int get_numberOfCellsLoadedPerFrame() { }

	// RVA: 0x85C70F0 Offset: 0x85C30F0 VA: 0x85C70F0
	public int get_numberOfCellsBlendedPerFrame() { }

	// RVA: 0x85C70F8 Offset: 0x85C30F8 VA: 0x85C70F8
	public void set_numberOfCellsBlendedPerFrame(int value) { }

	// RVA: 0x85C7108 Offset: 0x85C3108 VA: 0x85C7108
	public float get_turnoverRate() { }

	// RVA: 0x85C7110 Offset: 0x85C3110 VA: 0x85C7110
	public void set_turnoverRate(float value) { }

	// RVA: 0x85C712C Offset: 0x85C312C VA: 0x85C712C
	public ProbeVolumeSHBands get_shBands() { }

	// RVA: 0x85C7134 Offset: 0x85C3134 VA: 0x85C7134
	public string get_lightingScenario() { }

	// RVA: 0x85C7150 Offset: 0x85C3150 VA: 0x85C7150
	public void set_lightingScenario(string value) { }

	// RVA: 0x85C716C Offset: 0x85C316C VA: 0x85C716C
	public float get_scenarioBlendingFactor() { }

	// RVA: 0x85C7188 Offset: 0x85C3188 VA: 0x85C7188
	public void set_scenarioBlendingFactor(float value) { }

	// RVA: 0x85C71A8 Offset: 0x85C31A8 VA: 0x85C71A8
	public void BlendLightingScenario(string otherScenario, float blendingFactor) { }

	// RVA: 0x85C71C4 Offset: 0x85C31C4 VA: 0x85C71C4
	public ProbeVolumeTextureMemoryBudget get_memoryBudget() { }

	// RVA: 0x85C71CC Offset: 0x85C31CC VA: 0x85C71CC
	public float get_probeVolumesWeight() { }

	// RVA: 0x85C71D4 Offset: 0x85C31D4 VA: 0x85C71D4
	public void set_probeVolumesWeight(float value) { }

	[CompilerGenerated]
	// RVA: 0x85C71F0 Offset: 0x85C31F0 VA: 0x85C71F0
	internal List<ProbeVolumePerSceneData> get_perSceneDataList() { }

	[CompilerGenerated]
	// RVA: 0x85C71F8 Offset: 0x85C31F8 VA: 0x85C71F8
	private void set_perSceneDataList(List<ProbeVolumePerSceneData> value) { }

	// RVA: 0x85C7208 Offset: 0x85C3208 VA: 0x85C7208
	internal void RegisterPerSceneData(ProbeVolumePerSceneData data) { }

	// RVA: 0x85C72EC Offset: 0x85C32EC VA: 0x85C72EC
	internal void UnregisterPerSceneData(ProbeVolumePerSceneData data) { }

	// RVA: 0x85C7344 Offset: 0x85C3344 VA: 0x85C7344
	public static ProbeReferenceVolume get_instance() { }

	// RVA: 0x85C739C Offset: 0x85C339C VA: 0x85C739C
	public void Initialize(in ProbeVolumeSystemParameters parameters) { }

	// RVA: 0x85C7A3C Offset: 0x85C3A3C VA: 0x85C7A3C
	public void SetEnableStateFromSRP(bool srpEnablesPV) { }

	// RVA: 0x85C7A48 Offset: 0x85C3A48 VA: 0x85C7A48
	internal void ForceSHBand(ProbeVolumeSHBands shBands) { }

	// RVA: 0x85C7AF4 Offset: 0x85C3AF4 VA: 0x85C7AF4
	public void Cleanup() { }

	// RVA: 0x85C7C04 Offset: 0x85C3C04 VA: 0x85C7C04
	public int GetVideoMemoryCost() { }

	// RVA: 0x85C7C88 Offset: 0x85C3C88 VA: 0x85C7C88
	private void RemoveCell(ProbeReferenceVolume.Cell cell) { }

	// RVA: 0x85C7DF4 Offset: 0x85C3DF4 VA: 0x85C7DF4
	internal void UnloadCell(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x85C7EE0 Offset: 0x85C3EE0 VA: 0x85C7EE0
	internal void UnloadBlendingCell(ProbeReferenceVolume.BlendingCellInfo blendingCell) { }

	// RVA: 0x85C8084 Offset: 0x85C4084 VA: 0x85C8084
	internal void UnloadAllCells() { }

	// RVA: 0x85C8160 Offset: 0x85C4160 VA: 0x85C8160
	internal void UnloadAllBlendingCells() { }

	// RVA: 0x85C823C Offset: 0x85C423C VA: 0x85C823C
	private void AddCell(ProbeReferenceVolume.Cell cell, int assetInstanceID) { }

	// RVA: 0x85C83F0 Offset: 0x85C43F0 VA: 0x85C83F0
	internal bool LoadCell(ProbeReferenceVolume.CellInfo cellInfo, bool ignoreErrorLog = False) { }

	// RVA: 0x85C8988 Offset: 0x85C4988 VA: 0x85C8988
	internal void LoadAllCells() { }

	// RVA: 0x85C8AC4 Offset: 0x85C4AC4 VA: 0x85C8AC4
	private void RecomputeMinMaxLoadedCellPos() { }

	// RVA: 0x85C8CE4 Offset: 0x85C4CE4 VA: 0x85C8CE4
	private bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<string, ProbeVolumeAsset> collection) { }

	// RVA: 0x85C8EF0 Offset: 0x85C4EF0 VA: 0x85C8EF0
	internal void AddPendingAssetLoading(ProbeVolumeAsset asset) { }

	// RVA: 0x85C966C Offset: 0x85C566C VA: 0x85C966C
	internal void AddPendingAssetRemoval(ProbeVolumeAsset asset) { }

	// RVA: 0x85C9754 Offset: 0x85C5754 VA: 0x85C9754
	internal void RemovePendingAsset(ProbeVolumeAsset asset) { }

	// RVA: 0x85C99D8 Offset: 0x85C59D8 VA: 0x85C99D8
	private void PerformPendingIndexChangeAndInit() { }

	// RVA: 0x85C9A18 Offset: 0x85C5A18 VA: 0x85C9A18
	internal void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv) { }

	// RVA: 0x85C9B50 Offset: 0x85C5B50 VA: 0x85C9B50
	private void LoadAsset(ProbeVolumeAsset asset) { }

	// RVA: 0x85C9D60 Offset: 0x85C5D60 VA: 0x85C9D60
	private void PerformPendingLoading() { }

	// RVA: 0x85CA0D0 Offset: 0x85C60D0 VA: 0x85CA0D0
	private void PerformPendingDeletion() { }

	// RVA: 0x85CA274 Offset: 0x85C6274 VA: 0x85CA274
	internal int GetNumberOfBricksAtSubdiv(Vector3Int position, int minSubdiv, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes) { }

	// RVA: 0x85C84FC Offset: 0x85C44FC VA: 0x85C84FC
	private bool GetCellIndexUpdate(ProbeReferenceVolume.Cell cell, out ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog) { }

	// RVA: 0x85CA8A4 Offset: 0x85C68A4 VA: 0x85CA8A4
	public void PerformPendingOperations() { }

	// RVA: 0x85C781C Offset: 0x85C381C VA: 0x85C781C
	private void InitProbeReferenceVolume(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget, ProbeVolumeSHBands shBands) { }

	// RVA: 0x85C9CCC Offset: 0x85C5CCC VA: 0x85C9CCC
	private void AllocateTemporaryDataLocation() { }

	// RVA: 0x85CA8C4 Offset: 0x85C68C4 VA: 0x85CA8C4
	private void .ctor() { }

	// RVA: 0x85CB068 Offset: 0x85C7068 VA: 0x85CB068
	public ProbeReferenceVolume.RuntimeResources GetRuntimeResources() { }

	// RVA: 0x85C9ACC Offset: 0x85C5ACC VA: 0x85C9ACC
	internal void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize) { }

	// RVA: 0x85C9AE0 Offset: 0x85C5AE0 VA: 0x85C9AE0
	internal void SetMaxSubdivision(int maxSubdivision) { }

	// RVA: 0x85C1DBC Offset: 0x85BDDBC VA: 0x85C1DBC
	internal static int CellSize(int subdivisionLevel) { }

	// RVA: 0x85CB0FC Offset: 0x85C70FC VA: 0x85CB0FC
	internal float BrickSize(int subdivisionLevel) { }

	// RVA: 0x85CA89C Offset: 0x85C689C VA: 0x85CA89C
	internal float MinBrickSize() { }

	// RVA: 0x85CA890 Offset: 0x85C6890 VA: 0x85CA890
	internal float MaxBrickSize() { }

	// RVA: 0x85CB194 Offset: 0x85C7194 VA: 0x85CB194
	internal ProbeReferenceVolume.RefVolTransform GetTransform() { }

	// RVA: 0x85CB1A4 Offset: 0x85C71A4 VA: 0x85CB1A4
	internal int GetMaxSubdivision() { }

	// RVA: 0x85CB1AC Offset: 0x85C71AC VA: 0x85CB1AC
	internal int GetMaxSubdivision(float multiplier) { }

	// RVA: 0x85CB22C Offset: 0x85C722C VA: 0x85CB22C
	internal float GetDistanceBetweenProbes(int subdivisionLevel) { }

	// RVA: 0x85CB244 Offset: 0x85C7244 VA: 0x85CB244
	internal float MinDistanceBetweenProbes() { }

	// RVA: 0x85CB260 Offset: 0x85C7260 VA: 0x85CB260
	public bool DataHasBeenLoaded() { }

	// RVA: 0x85CB268 Offset: 0x85C7268 VA: 0x85CB268
	internal void Clear() { }

	// RVA: 0x85CB33C Offset: 0x85C733C VA: 0x85CB33C
	private List<ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, ProbeBrickPool.DataLocation dataLoc) { }

	// RVA: 0x85CB4C0 Offset: 0x85C74C0 VA: 0x85CB4C0
	private void UpdatePool(List<ProbeBrickPool.BrickChunkAlloc> chunkList, ProbeReferenceVolume.Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex, int poolIndex) { }

	// RVA: 0x85CBA4C Offset: 0x85C7A4C VA: 0x85CBA4C
	private void UpdatePoolValidity(List<ProbeBrickPool.BrickChunkAlloc> chunkList, ProbeReferenceVolume.Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex) { }

	// RVA: 0x85CBB90 Offset: 0x85C7B90 VA: 0x85CBB90
	private bool AddBlendingBricks(ProbeReferenceVolume.BlendingCellInfo blendingCell) { }

	// RVA: 0x85C866C Offset: 0x85C466C VA: 0x85C866C
	private bool AddBricks(ProbeReferenceVolume.CellInfo cellInfo, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog) { }

	// RVA: 0x85CBEF4 Offset: 0x85C7EF4 VA: 0x85CBEF4
	private void UpdateCellIndex(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x85C7F54 Offset: 0x85C3F54 VA: 0x85C7F54
	private void ReleaseBricks(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x85CBFD8 Offset: 0x85C7FD8 VA: 0x85CBFD8
	public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters) { }

	// RVA: 0x85C7A8C Offset: 0x85C3A8C VA: 0x85C7A8C
	private void CleanupLoadedData() { }

	[CompilerGenerated]
	// RVA: 0x85CC1F8 Offset: 0x85C81F8 VA: 0x85CC1F8
	internal ProbeVolumeDebug get_probeVolumeDebug() { }

	[CompilerGenerated]
	// RVA: 0x85CC200 Offset: 0x85C8200 VA: 0x85CC200
	public Color[] get_subdivisionDebugColors() { }

	// RVA: 0x85CC208 Offset: 0x85C8208 VA: 0x85CC208
	public void RenderDebug(Camera camera) { }

	// RVA: 0x85C7634 Offset: 0x85C3634 VA: 0x85C7634
	private void InitializeDebug(in ProbeVolumeSystemParameters parameters) { }

	// RVA: 0x85C7B90 Offset: 0x85C3B90 VA: 0x85C7B90
	private void CleanupDebug() { }

	// RVA: -1 Offset: -1
	private void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46A5134 Offset: 0x46A1134 VA: 0x46A5134
	|-ProbeReferenceVolume.DebugCellIndexChanged<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x85CCC34 Offset: 0x85C8C34 VA: 0x85CCC34
	private void RegisterDebug(ProbeVolumeSystemParameters parameters) { }

	// RVA: 0x85CF2C0 Offset: 0x85CB2C0 VA: 0x85CF2C0
	private void UnregisterDebug(bool destroyPanel) { }

	// RVA: 0x85CF3BC Offset: 0x85CB3BC VA: 0x85CF3BC
	private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes) { }

	// RVA: 0x85CC268 Offset: 0x85C8268 VA: 0x85CC268
	private void DrawProbeDebug(Camera camera) { }

	// RVA: 0x85D03E4 Offset: 0x85CC3E4 VA: 0x85D03E4
	internal void ResetDebugViewToMaxSubdiv() { }

	// RVA: 0x85C8034 Offset: 0x85C4034 VA: 0x85C8034
	private void ClearDebugData() { }

	// RVA: 0x85CF608 Offset: 0x85CB608 VA: 0x85CF608
	private ProbeReferenceVolume.CellInstancedDebugProbes CreateInstancedProbes(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x85D0494 Offset: 0x85CC494 VA: 0x85D0494
	private void OnClearLightingdata() { }

	// RVA: 0x85D0498 Offset: 0x85CC498 VA: 0x85D0498
	internal void ScenarioBlendingChanged(bool scenarioChanged) { }

	// RVA: 0x85D0540 Offset: 0x85CC540 VA: 0x85D0540
	public void SetNumberOfCellsLoadedPerFrame(int numberOfCells) { }

	// RVA: 0x85D0550 Offset: 0x85CC550 VA: 0x85D0550
	private void ComputeCellCameraDistance(Vector3 cameraPosition, DynamicArray<ProbeReferenceVolume.CellInfo> cells) { }

	// RVA: 0x85D0688 Offset: 0x85CC688 VA: 0x85D0688
	private void ComputeStreamingScoreForBlending(DynamicArray<ProbeReferenceVolume.BlendingCellInfo> cells, float worstScore) { }

	// RVA: 0x85D0780 Offset: 0x85CC780 VA: 0x85D0780
	private bool TryLoadCell(ProbeReferenceVolume.CellInfo cellInfo, ref int shBudget, ref int indexBudget, DynamicArray<ProbeReferenceVolume.CellInfo> loadedCells) { }

	// RVA: 0x85D0880 Offset: 0x85CC880 VA: 0x85D0880
	private void UnloadBlendingCell(ProbeReferenceVolume.BlendingCellInfo blendingCell, DynamicArray<ProbeReferenceVolume.BlendingCellInfo> unloadedCells) { }

	// RVA: 0x85D08F8 Offset: 0x85CC8F8 VA: 0x85D08F8
	private bool TryLoadBlendingCell(ProbeReferenceVolume.BlendingCellInfo blendingCell, DynamicArray<ProbeReferenceVolume.BlendingCellInfo> loadedCells) { }

	// RVA: 0x85D097C Offset: 0x85CC97C VA: 0x85D097C
	public void UpdateCellStreaming(CommandBuffer cmd, Camera camera) { }

	// RVA: 0x85D14F8 Offset: 0x85CD4F8 VA: 0x85D14F8
	private int FindWorstBlendingCellToBeLoaded() { }

	// RVA: 0x85D0FB4 Offset: 0x85CCFB4 VA: 0x85D0FB4
	private void UpdateBlendingCellStreaming(CommandBuffer cmd) { }

	// RVA: 0x85D15FC Offset: 0x85CD5FC VA: 0x85D15FC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\Lighting\ProbeVolume\ProbeReferenceVolume.Debug.cs")]
public enum DebugProbeShadingMode // TypeDefIndex: 19979
{
	// Fields
	public int value__; // 0x0
	public const DebugProbeShadingMode SH = 0;
	public const DebugProbeShadingMode SHL0 = 1;
	public const DebugProbeShadingMode SHL0L1 = 2;
	public const DebugProbeShadingMode Validity = 3;
	public const DebugProbeShadingMode ValidityOverDilationThreshold = 4;
	public const DebugProbeShadingMode InvalidatedByTouchupVolumes = 5;
	public const DebugProbeShadingMode Size = 6;
}

// Namespace: UnityEngine.Rendering
internal class ProbeVolumeDebug : IDebugData // TypeDefIndex: 19980
{
	// Fields
	public bool drawProbes; // 0x10
	public bool drawBricks; // 0x11
	public bool drawCells; // 0x12
	public bool realtimeSubdivision; // 0x13
	public int subdivisionCellUpdatePerFrame; // 0x14
	public float subdivisionDelayInSeconds; // 0x18
	public DebugProbeShadingMode probeShading; // 0x1C
	public float probeSize; // 0x20
	public float subdivisionViewCullingDistance; // 0x24
	public float probeCullingDistance; // 0x28
	public int maxSubdivToVisualize; // 0x2C
	public int minSubdivToVisualize; // 0x30
	public float exposureCompensation; // 0x34
	public bool drawVirtualOffsetPush; // 0x38
	public float offsetSize; // 0x3C
	public bool freezeStreaming; // 0x40
	public int otherStateIndex; // 0x44

	// Methods

	// RVA: 0x85D3ED4 Offset: 0x85CFED4 VA: 0x85D3ED4
	public void .ctor() { }

	// RVA: 0x85D3F50 Offset: 0x85CFF50 VA: 0x85D3F50
	private void Init() { }

	// RVA: 0x85D3F98 Offset: 0x85CFF98 VA: 0x85D3F98 Slot: 4
	public Action GetReset() { }

	[CompilerGenerated]
	// RVA: 0x85D4014 Offset: 0x85D0014 VA: 0x85D4014
	private void <GetReset>b__19_0() { }
}

// Namespace: 
internal enum ProbeReferenceVolumeProfile.Version // TypeDefIndex: 19981
{
	// Fields
	public int value__; // 0x0
	public const ProbeReferenceVolumeProfile.Version Initial = 0;
}

// Namespace: UnityEngine.Rendering
public sealed class ProbeReferenceVolumeProfile : ScriptableObject // TypeDefIndex: 19982
{
	// Fields
	[SerializeField]
	private ProbeReferenceVolumeProfile.Version version; // 0x18
	[SerializeField]
	internal bool freezePlacement; // 0x1C
	[Range(2, 5)]
	public int simplificationLevels; // 0x20
	[Min(0.1)]
	public float minDistanceBetweenProbes; // 0x24
	public LayerMask renderersLayerMask; // 0x28
	[Min(0)]
	public float minRendererVolumeSize; // 0x2C

	// Properties
	public int cellSizeInBricks { get; }
	public int maxSubdivision { get; }
	public float minBrickSize { get; }
	public float cellSizeInMeters { get; }

	// Methods

	// RVA: 0x85D405C Offset: 0x85D005C VA: 0x85D405C
	public int get_cellSizeInBricks() { }

	// RVA: 0x85D4090 Offset: 0x85D0090 VA: 0x85D4090
	public int get_maxSubdivision() { }

	// RVA: 0x85D409C Offset: 0x85D009C VA: 0x85D409C
	public float get_minBrickSize() { }

	// RVA: 0x85D40B8 Offset: 0x85D00B8 VA: 0x85D40B8
	public float get_cellSizeInMeters() { }

	// RVA: 0x85D411C Offset: 0x85D011C VA: 0x85D411C
	private void OnEnable() { }

	// RVA: 0x85D4180 Offset: 0x85D0180 VA: 0x85D4180
	public bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile) { }

	// RVA: 0x85D428C Offset: 0x85D028C VA: 0x85D428C
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[AddComponentMenu("Rendering/Probe Volume Touchup")]
[ExecuteAlways]
public class ProbeTouchupVolume : MonoBehaviour // TypeDefIndex: 19983
{
	// Fields
	[Range(0.0001, 2)]
	public float intensityScale; // 0x20
	public bool invalidateProbes; // 0x24
	public bool overrideDilationThreshold; // 0x25
	[Range(0, 0.99)]
	public float overriddenDilationThreshold; // 0x28
	public Vector3 size; // 0x2C

	// Methods

	// RVA: 0x85D4328 Offset: 0x85D0328 VA: 0x85D4328
	public void .ctor() { }
}

// Namespace: 
public enum ProbeVolume.Mode // TypeDefIndex: 19984
{
	// Fields
	public int value__; // 0x0
	public const ProbeVolume.Mode Global = 0;
	public const ProbeVolume.Mode Scene = 1;
	public const ProbeVolume.Mode Local = 2;
}

// Namespace: 
private enum ProbeVolume.Version // TypeDefIndex: 19985
{
	// Fields
	public int value__; // 0x0
	public const ProbeVolume.Version Initial = 0;
	public const ProbeVolume.Version LocalMode = 1;
	public const ProbeVolume.Version Count = 2;
}

// Namespace: UnityEngine.Rendering
[AddComponentMenu("Rendering/Probe Volume")]
[ExecuteAlways]
public class ProbeVolume : MonoBehaviour // TypeDefIndex: 19986
{
	// Fields
	[Tooltip("When set to Global this Probe Volume considers all renderers with Contribute Global Illumination enabled. Local only considers renderers in the scene.
This list updates every time the Scene is saved or the lighting is baked.")]
	public ProbeVolume.Mode mode; // 0x20
	public Vector3 size; // 0x24
	[Min(0)]
	[HideInInspector]
	public bool overrideRendererFilters; // 0x30
	[HideInInspector]
	[Min(0)]
	public float minRendererVolumeSize; // 0x34
	public LayerMask objectLayerMask; // 0x38
	[HideInInspector]
	public int lowestSubdivLevelOverride; // 0x3C
	[HideInInspector]
	public int highestSubdivLevelOverride; // 0x40
	[HideInInspector]
	public bool overridesSubdivLevels; // 0x44
	[SerializeField]
	internal bool mightNeedRebaking; // 0x45
	[SerializeField]
	internal Matrix4x4 cachedTransform; // 0x48
	[SerializeField]
	internal int cachedHashCode; // 0x88
	[HideInInspector]
	[Tooltip("Whether spaces with no renderers need to be filled with bricks at lowest subdivision level.")]
	public bool fillEmptySpaces; // 0x8C
	[SerializeField]
	private ProbeVolume.Version version; // 0x90
	[SerializeField]
	[Obsolete("Use mode instead")]
	public bool globalVolume; // 0x94

	// Methods

	// RVA: 0x85D4344 Offset: 0x85D0344 VA: 0x85D4344
	private void Awake() { }

	// RVA: 0x85D436C Offset: 0x85D036C VA: 0x85D436C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
internal enum ProbeVolumeAsset.AssetVersion // TypeDefIndex: 19987
{
	// Fields
	public int value__; // 0x0
	public const ProbeVolumeAsset.AssetVersion First = 0;
	public const ProbeVolumeAsset.AssetVersion AddProbeVolumesAtlasEncodingModes = 1;
	public const ProbeVolumeAsset.AssetVersion PV2 = 2;
	public const ProbeVolumeAsset.AssetVersion ChunkBasedIndex = 3;
	public const ProbeVolumeAsset.AssetVersion BinaryRuntimeDebugSplit = 4;
	public const ProbeVolumeAsset.AssetVersion BinaryTextureData = 5;
	public const ProbeVolumeAsset.AssetVersion Max = 6;
	public const ProbeVolumeAsset.AssetVersion Current = 5;
}

// Namespace: 
[Serializable]
internal struct ProbeVolumeAsset.CellCounts // TypeDefIndex: 19988
{
	// Fields
	public int bricksCount; // 0x0
	public int probesCount; // 0x4
	public int offsetsCount; // 0x8
	public int chunksCount; // 0xC

	// Methods

	// RVA: 0x85D4944 Offset: 0x85D0944 VA: 0x85D4944
	public void Add(ProbeVolumeAsset.CellCounts o) { }
}

// Namespace: UnityEngine.Rendering
[PreferBinarySerialization]
internal class ProbeVolumeAsset : ScriptableObject // TypeDefIndex: 19989
{
	// Fields
	[SerializeField]
	protected internal int m_Version; // 0x18
	[SerializeField]
	internal ProbeReferenceVolume.Cell[] cells; // 0x20
	[SerializeField]
	internal ProbeVolumeAsset.CellCounts[] cellCounts; // 0x28
	[SerializeField]
	internal ProbeVolumeAsset.CellCounts totalCellCounts; // 0x30
	[SerializeField]
	internal Vector3Int maxCellPosition; // 0x40
	[SerializeField]
	internal Vector3Int minCellPosition; // 0x4C
	[SerializeField]
	internal Bounds globalBounds; // 0x58
	[SerializeField]
	internal ProbeVolumeSHBands bands; // 0x70
	[SerializeField]
	internal int chunkSizeInBricks; // 0x74
	[SerializeField]
	private string m_AssetFullPath; // 0x78
	[SerializeField]
	internal int cellSizeInBricks; // 0x80
	[SerializeField]
	internal int simplificationLevels; // 0x84
	[SerializeField]
	internal float minDistanceBetweenProbes; // 0x88

	// Properties
	public int Version { get; }
	internal int maxSubdivision { get; }
	internal float minBrickSize { get; }

	// Methods

	// RVA: 0x85D43C8 Offset: 0x85D03C8 VA: 0x85D43C8
	public int get_Version() { }

	// RVA: 0x85D43D0 Offset: 0x85D03D0 VA: 0x85D43D0
	internal int get_maxSubdivision() { }

	// RVA: 0x85D43DC Offset: 0x85D03DC VA: 0x85D43DC
	internal float get_minBrickSize() { }

	// RVA: 0x85D43F8 Offset: 0x85D03F8 VA: 0x85D43F8
	internal bool CompatibleWith(ProbeVolumeAsset otherAsset) { }

	// RVA: 0x85D4470 Offset: 0x85D0470 VA: 0x85D4470
	internal bool IsInvalid() { }

	// RVA: 0x85D44AC Offset: 0x85D04AC VA: 0x85D44AC
	public string GetSerializedFullPath() { }

	// RVA: 0x85D44B4 Offset: 0x85D04B4 VA: 0x85D44B4
	private static int AlignUp16(int count) { }

	// RVA: -1 Offset: -1
	private NativeArray<T> GetSubArray<T>(NativeArray<byte> input, int count, ref int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46A513C Offset: 0x46A113C VA: 0x46A513C
	|-ProbeVolumeAsset.GetSubArray<byte>
	|
	|-RVA: 0x46A5208 Offset: 0x46A1208 VA: 0x46A5208
	|-ProbeVolumeAsset.GetSubArray<float>
	|
	|-RVA: 0x46A52D8 Offset: 0x46A12D8 VA: 0x46A52D8
	|-ProbeVolumeAsset.GetSubArray<ushort>
	|
	|-RVA: 0x46A53A8 Offset: 0x46A13A8 VA: 0x46A53A8
	|-ProbeVolumeAsset.GetSubArray<Vector3>
	|
	|-RVA: 0x46A547C Offset: 0x46A147C VA: 0x46A547C
	|-ProbeVolumeAsset.GetSubArray<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x46A5560 Offset: 0x46A1560 VA: 0x46A5560
	|-ProbeVolumeAsset.GetSubArray<ProbeBrickIndex.Brick>
	*/

	// RVA: 0x85D44DC Offset: 0x85D04DC VA: 0x85D44DC
	internal bool ResolveSharedCellData(TextAsset cellSharedDataAsset, TextAsset cellSupportDataAsset) { }

	// RVA: 0x85D496C Offset: 0x85D096C VA: 0x85D496C
	internal bool ResolvePerScenarioCellData(TextAsset cellDataAsset, TextAsset cellOptionalDataAsset, int stateIndex) { }

	// RVA: 0x85D4E64 Offset: 0x85D0E64 VA: 0x85D4E64
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[Serializable]
internal struct ProbeDilationSettings // TypeDefIndex: 19990
{
	// Fields
	public bool enableDilation; // 0x0
	public float dilationDistance; // 0x4
	public float dilationValidityThreshold; // 0x8
	public int dilationIterations; // 0xC
	public bool squaredDistWeighting; // 0x10

	// Methods

	// RVA: 0x85D4EC4 Offset: 0x85D0EC4 VA: 0x85D4EC4
	internal void SetDefaults() { }

	// RVA: 0x85D4EE4 Offset: 0x85D0EE4 VA: 0x85D4EE4
	internal void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to) { }
}

// Namespace: UnityEngine.Rendering
[Serializable]
internal struct VirtualOffsetSettings // TypeDefIndex: 19991
{
	// Fields
	public bool useVirtualOffset; // 0x0
	[Range(0, 1)]
	public float outOfGeoOffset; // 0x4
	[Range(0, 2)]
	public float searchMultiplier; // 0x8
	[Range(-0.05, 0)]
	public float rayOriginBias; // 0xC
	[Range(4, 24)]
	public int maxHitsPerRay; // 0x10
	public LayerMask collisionMask; // 0x14

	// Methods

	// RVA: 0x85D4EE8 Offset: 0x85D0EE8 VA: 0x85D4EE8
	internal void SetDefaults() { }

	// RVA: 0x85D4F2C Offset: 0x85D0F2C VA: 0x85D4F2C
	internal void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to) { }
}

// Namespace: 
internal enum ProbeVolumeBakingProcessSettings.SettingsVersion // TypeDefIndex: 19992
{
	// Fields
	public int value__; // 0x0
	public const ProbeVolumeBakingProcessSettings.SettingsVersion Initial = 0;
	public const ProbeVolumeBakingProcessSettings.SettingsVersion ThreadedVirtualOffset = 1;
	public const ProbeVolumeBakingProcessSettings.SettingsVersion Max = 2;
	public const ProbeVolumeBakingProcessSettings.SettingsVersion Current = 1;
}

// Namespace: UnityEngine.Rendering
[Serializable]
internal struct ProbeVolumeBakingProcessSettings // TypeDefIndex: 19993
{
	// Fields
	[SerializeField]
	private ProbeVolumeBakingProcessSettings.SettingsVersion m_Version; // 0x0
	public ProbeDilationSettings dilationSettings; // 0x4
	public VirtualOffsetSettings virtualOffsetSettings; // 0x18

	// Properties
	internal static ProbeVolumeBakingProcessSettings Default { get; }

	// Methods

	// RVA: 0x85D4F6C Offset: 0x85D0F6C VA: 0x85D4F6C
	internal static ProbeVolumeBakingProcessSettings get_Default() { }

	// RVA: 0x85D5040 Offset: 0x85D1040 VA: 0x85D5040
	internal void .ctor(ProbeDilationSettings dilationSettings, VirtualOffsetSettings virtualOffsetSettings) { }

	// RVA: 0x85D4FE0 Offset: 0x85D0FE0 VA: 0x85D4FE0
	internal void SetDefaults() { }

	// RVA: 0x85D506C Offset: 0x85D106C VA: 0x85D506C
	internal void Upgrade() { }
}

// Namespace: UnityEngine.Rendering
internal struct GIContributors // TypeDefIndex: 19994
{}

// Namespace: 
[Serializable]
internal struct ProbeVolumePerSceneData.PerScenarioData // TypeDefIndex: 19995
{
	// Fields
	public int sceneHash; // 0x0
	public TextAsset cellDataAsset; // 0x8
	public TextAsset cellOptionalDataAsset; // 0x10
}

// Namespace: 
[Serializable]
private struct ProbeVolumePerSceneData.SerializablePerScenarioDataItem // TypeDefIndex: 19996
{
	// Fields
	public string scenario; // 0x0
	public ProbeVolumePerSceneData.PerScenarioData data; // 0x8
}

// Namespace: UnityEngine.Rendering
[AddComponentMenu("")]
[ExecuteAlways]
public class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 19997
{
	// Fields
	[SerializeField]
	internal ProbeVolumeAsset asset; // 0x20
	[SerializeField]
	internal TextAsset cellSharedDataAsset; // 0x28
	[SerializeField]
	internal TextAsset cellSupportDataAsset; // 0x30
	[SerializeField]
	private List<ProbeVolumePerSceneData.SerializablePerScenarioDataItem> serializedScenarios; // 0x38
	internal Dictionary<string, ProbeVolumePerSceneData.PerScenarioData> scenarios; // 0x40
	private bool assetLoaded; // 0x48
	private string activeScenario; // 0x50
	private string otherScenario; // 0x58

	// Methods

	// RVA: 0x85D50B8 Offset: 0x85D10B8 VA: 0x85D50B8 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x85D5288 Offset: 0x85D1288 VA: 0x85D5288 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x85D553C Offset: 0x85D153C VA: 0x85D553C
	internal void Clear() { }

	// RVA: 0x85D5674 Offset: 0x85D1674 VA: 0x85D5674
	internal void RemoveScenario(string scenario) { }

	// RVA: 0x85D56CC Offset: 0x85D16CC VA: 0x85D56CC
	internal void RenameScenario(string scenario, string newName) { }

	// RVA: 0x85D57C0 Offset: 0x85D17C0 VA: 0x85D57C0
	internal bool ResolveCells() { }

	// RVA: 0x85D57E8 Offset: 0x85D17E8 VA: 0x85D57E8
	internal bool ResolveSharedCellData() { }

	// RVA: 0x85D5870 Offset: 0x85D1870 VA: 0x85D5870
	private bool ResolvePerScenarioCellData() { }

	// RVA: 0x85D59BC Offset: 0x85D19BC VA: 0x85D59BC
	internal void QueueAssetLoading() { }

	// RVA: 0x85D5594 Offset: 0x85D1594 VA: 0x85D5594
	internal void QueueAssetRemoval() { }

	// RVA: 0x85D5AE4 Offset: 0x85D1AE4 VA: 0x85D5AE4
	private void OnEnable() { }

	// RVA: 0x85D5CEC Offset: 0x85D1CEC VA: 0x85D5CEC
	private void OnDisable() { }

	// RVA: 0x85D5BD8 Offset: 0x85D1BD8 VA: 0x85D5BD8
	internal void Initialize() { }

	// RVA: 0x85D5DB0 Offset: 0x85D1DB0 VA: 0x85D5DB0
	internal void UpdateActiveScenario(string activeScenario, string otherScenario) { }

	// RVA: 0x85D5E88 Offset: 0x85D1E88 VA: 0x85D5E88
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private struct ProbeVolumeSceneData.SerializableBoundItem // TypeDefIndex: 19998
{
	// Fields
	[SerializeField]
	public string sceneGUID; // 0x0
	[SerializeField]
	public Bounds bounds; // 0x8
}

// Namespace: 
[Serializable]
private struct ProbeVolumeSceneData.SerializableHasPVItem // TypeDefIndex: 19999
{
	// Fields
	[SerializeField]
	public string sceneGUID; // 0x0
	[SerializeField]
	public bool hasProbeVolumes; // 0x8
}

// Namespace: 
[Serializable]
private struct ProbeVolumeSceneData.SerializablePVProfile // TypeDefIndex: 20000
{
	// Fields
	[SerializeField]
	public string sceneGUID; // 0x0
	[SerializeField]
	public ProbeReferenceVolumeProfile profile; // 0x8
}

// Namespace: 
[Serializable]
private struct ProbeVolumeSceneData.SerializablePVBakeSettings // TypeDefIndex: 20001
{
	// Fields
	public string sceneGUID; // 0x0
	public ProbeVolumeBakingProcessSettings settings; // 0x8
}

// Namespace: 
[Serializable]
internal class ProbeVolumeSceneData.BakingSet // TypeDefIndex: 20002
{
	// Fields
	public string name; // 0x10
	public List<string> sceneGUIDs; // 0x18
	public ProbeVolumeBakingProcessSettings settings; // 0x20
	public ProbeReferenceVolumeProfile profile; // 0x50
	public List<string> lightingScenarios; // 0x58

	// Methods

	// RVA: 0x85D8480 Offset: 0x85D4480 VA: 0x85D8480
	internal string CreateScenario(string name) { }

	// RVA: 0x85D85F4 Offset: 0x85D45F4 VA: 0x85D85F4
	internal bool RemoveScenario(string name) { }

	// RVA: 0x85D830C Offset: 0x85D430C VA: 0x85D830C
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[Serializable]
public class ProbeVolumeSceneData : ISerializationCallbackReceiver // TypeDefIndex: 20003
{
	// Fields
	private static PropertyInfo s_SceneGUID; // 0x0
	[SerializeField]
	private List<ProbeVolumeSceneData.SerializableBoundItem> serializedBounds; // 0x10
	[SerializeField]
	private List<ProbeVolumeSceneData.SerializableHasPVItem> serializedHasVolumes; // 0x18
	[SerializeField]
	private List<ProbeVolumeSceneData.SerializablePVProfile> serializedProfiles; // 0x20
	[SerializeField]
	private List<ProbeVolumeSceneData.SerializablePVBakeSettings> serializedBakeSettings; // 0x28
	[SerializeField]
	private List<ProbeVolumeSceneData.BakingSet> serializedBakingSets; // 0x30
	internal Object parentAsset; // 0x38
	internal string parentSceneDataPropertyName; // 0x40
	public Dictionary<string, Bounds> sceneBounds; // 0x48
	internal Dictionary<string, bool> hasProbeVolumes; // 0x50
	internal Dictionary<string, ProbeReferenceVolumeProfile> sceneProfiles; // 0x58
	internal Dictionary<string, ProbeVolumeBakingProcessSettings> sceneBakingSettings; // 0x60
	internal List<ProbeVolumeSceneData.BakingSet> bakingSets; // 0x68
	[SerializeField]
	private string m_LightingScenario; // 0x70
	private string m_OtherScenario; // 0x78
	private float m_ScenarioBlendingFactor; // 0x80

	// Properties
	internal string lightingScenario { get; }
	internal string otherScenario { get; }
	internal float scenarioBlendingFactor { get; }

	// Methods

	// RVA: 0x85D3918 Offset: 0x85CF918 VA: 0x85D3918
	internal static string GetSceneGUID(Scene scene) { }

	// RVA: 0x85D5F64 Offset: 0x85D1F64 VA: 0x85D5F64
	internal string get_lightingScenario() { }

	// RVA: 0x85D5F6C Offset: 0x85D1F6C VA: 0x85D5F6C
	internal string get_otherScenario() { }

	// RVA: 0x85D5F74 Offset: 0x85D1F74 VA: 0x85D5F74
	internal float get_scenarioBlendingFactor() { }

	// RVA: 0x85D5F7C Offset: 0x85D1F7C VA: 0x85D5F7C
	internal void SetActiveScenario(string scenario) { }

	// RVA: 0x85D3A74 Offset: 0x85CFA74 VA: 0x85D3A74
	internal void BlendLightingScenario(string otherScenario, float blendingFactor) { }

	// RVA: 0x85D6250 Offset: 0x85D2250 VA: 0x85D6250
	public void .ctor(Object parentAsset, string parentSceneDataPropertyName) { }

	// RVA: 0x85D6794 Offset: 0x85D2794 VA: 0x85D6794
	public void SetParentObject(Object parent, string parentSceneDataPropertyName) { }

	// RVA: 0x85D67CC Offset: 0x85D27CC VA: 0x85D67CC Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x85D65BC Offset: 0x85D25BC VA: 0x85D65BC
	private void UpdateBakingSets() { }

	// RVA: 0x85D765C Offset: 0x85D365C VA: 0x85D765C Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x85D8230 Offset: 0x85D4230 VA: 0x85D8230
	internal ProbeVolumeSceneData.BakingSet CreateNewBakingSet(string name) { }

	// RVA: 0x85D714C Offset: 0x85D314C VA: 0x85D714C
	private void InitializeBakingSet(ProbeVolumeSceneData.BakingSet set, string name) { }

	// RVA: 0x85D7234 Offset: 0x85D3234 VA: 0x85D7234
	private void InitializeScenarios(ProbeVolumeSceneData.BakingSet set) { }

	// RVA: 0x85D7354 Offset: 0x85D3354 VA: 0x85D7354
	internal void SyncBakingSetSettings() { }

	// RVA: 0x85D83B8 Offset: 0x85D43B8 VA: 0x85D83B8
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public enum APVConstantBufferRegister // TypeDefIndex: 20004
{
	// Fields
	public int value__; // 0x0
	public const APVConstantBufferRegister GlobalRegister = 5;
}

// Namespace: UnityEngine.Rendering
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\Lighting\ProbeVolume\ShaderVariablesProbeVolumes.cs")]
public enum APVLeakReductionMode // TypeDefIndex: 20005
{
	// Fields
	public int value__; // 0x0
	public const APVLeakReductionMode None = 0;
	public const APVLeakReductionMode ValidityAndNormalBased = 1;
}

// Namespace: UnityEngine.Rendering
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\Lighting\ProbeVolume\ShaderVariablesProbeVolumes.cs", needAccessors = False, generateCBuffer = True, constantRegister = 5)]
internal struct ShaderVariablesProbeVolumes // TypeDefIndex: 20006
{
	// Fields
	public Vector4 _PoolDim_CellInMeters; // 0x0
	public Vector4 _MinCellPos_Noise; // 0x10
	public Vector4 _IndicesDim_IndexChunkSize; // 0x20
	public Vector4 _Biases_CellInMinBrick_MinBrickSize; // 0x30
	public Vector4 _LeakReductionParams; // 0x40
	public Vector4 _Weight_MinLoadedCell; // 0x50
	public Vector4 _MaxLoadedCell_FrameIndex; // 0x60
	public Vector4 _NormalizationClamp_Padding12; // 0x70
}

// Namespace: UnityEngine.Rendering
[Serializable]
public struct SphericalHarmonicsL1 // TypeDefIndex: 20007
{
	// Fields
	public Vector4 shAr; // 0x0
	public Vector4 shAg; // 0x10
	public Vector4 shAb; // 0x20
	public static readonly SphericalHarmonicsL1 zero; // 0x0

	// Methods

	// RVA: 0x85D864C Offset: 0x85D464C VA: 0x85D864C
	public static SphericalHarmonicsL1 op_Addition(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	// RVA: 0x85D8674 Offset: 0x85D4674 VA: 0x85D8674
	public static SphericalHarmonicsL1 op_Subtraction(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	// RVA: 0x85D869C Offset: 0x85D469C VA: 0x85D869C
	public static SphericalHarmonicsL1 op_Multiply(SphericalHarmonicsL1 lhs, float rhs) { }

	// RVA: 0x85D86BC Offset: 0x85D46BC VA: 0x85D86BC
	public static SphericalHarmonicsL1 op_Division(SphericalHarmonicsL1 lhs, float rhs) { }

	// RVA: 0x85D86E0 Offset: 0x85D46E0 VA: 0x85D86E0
	public static bool op_Equality(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	// RVA: 0x85D8790 Offset: 0x85D4790 VA: 0x85D8790
	public static bool op_Inequality(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	// RVA: 0x85D8844 Offset: 0x85D4844 VA: 0x85D8844 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x85D8924 Offset: 0x85D4924 VA: 0x85D8924 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x85D8A38 Offset: 0x85D4A38 VA: 0x85D8A38
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public class SphericalHarmonicsL2Utils // TypeDefIndex: 20008
{
	// Methods

	// RVA: 0x85D8ACC Offset: 0x85D4ACC VA: 0x85D8ACC
	public static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B) { }

	// RVA: 0x85D8BE0 Offset: 0x85D4BE0 VA: 0x85D8BE0
	public static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4) { }

	// RVA: 0x85D8D9C Offset: 0x85D4D9C VA: 0x85D8D9C
	public static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0) { }

	// RVA: 0x85D8DF8 Offset: 0x85D4DF8 VA: 0x85D8DF8
	public static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R) { }

	// RVA: 0x85D8E54 Offset: 0x85D4E54 VA: 0x85D8E54
	public static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G) { }

	// RVA: 0x85D8EB0 Offset: 0x85D4EB0 VA: 0x85D8EB0
	public static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B) { }

	// RVA: 0x85D8F0C Offset: 0x85D4F0C VA: 0x85D8F0C
	public static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B) { }

	// RVA: 0x85D8F70 Offset: 0x85D4F70 VA: 0x85D8F70
	public static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient) { }

	// RVA: 0x85D8FD8 Offset: 0x85D4FD8 VA: 0x85D8FD8
	public static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index) { }

	// RVA: 0x85D9048 Offset: 0x85D5048 VA: 0x85D9048
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\PostProcessing\HDROutputDefines.cs")]
public enum HDRRangeReduction // TypeDefIndex: 20009
{
	// Fields
	public int value__; // 0x0
	public const HDRRangeReduction None = 0;
	public const HDRRangeReduction Reinhard = 1;
	public const HDRRangeReduction BT2390 = 2;
	public const HDRRangeReduction ACES1000Nits = 3;
	public const HDRRangeReduction ACES2000Nits = 4;
	public const HDRRangeReduction ACES4000Nits = 5;
}

// Namespace: UnityEngine.Rendering
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\PostProcessing\HDROutputDefines.cs")]
public enum HDRColorspace // TypeDefIndex: 20010
{
	// Fields
	public int value__; // 0x0
	public const HDRColorspace Rec709 = 0;
	public const HDRColorspace Rec2020 = 1;
	public const HDRColorspace P3D65 = 2;
}

// Namespace: UnityEngine.Rendering
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\PostProcessing\HDROutputDefines.cs")]
public enum HDREncoding // TypeDefIndex: 20011
{
	// Fields
	public int value__; // 0x0
	public const HDREncoding Linear = 3;
	public const HDREncoding PQ = 2;
	public const HDREncoding Gamma22 = 4;
	public const HDREncoding sRGB = 0;
}

// Namespace: 
internal class LensFlareCommonSRP.LensFlareCompInfo // TypeDefIndex: 20012
{
	// Fields
	internal int index; // 0x10
	internal LensFlareComponentSRP comp; // 0x18

	// Methods

	// RVA: 0x85D9B00 Offset: 0x85D5B00 VA: 0x85D9B00
	internal void .ctor(int idx, LensFlareComponentSRP cmp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LensFlareCommonSRP.<>c__DisplayClass21_0 // TypeDefIndex: 20013
{
	// Fields
	public LensFlareComponentSRP newData; // 0x10

	// Methods

	// RVA: 0x85D9AF8 Offset: 0x85D5AF8 VA: 0x85D9AF8
	public void .ctor() { }

	// RVA: 0x85DE994 Offset: 0x85DA994 VA: 0x85DE994
	internal bool <AddData>b__0(LensFlareCommonSRP.LensFlareCompInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LensFlareCommonSRP.<>c__DisplayClass22_0 // TypeDefIndex: 20014
{
	// Fields
	public LensFlareComponentSRP data; // 0x10

	// Methods

	// RVA: 0x85D9D64 Offset: 0x85D5D64 VA: 0x85D9D64
	public void .ctor() { }

	// RVA: 0x85DEA04 Offset: 0x85DAA04 VA: 0x85DEA04
	internal bool <RemoveData>b__0(LensFlareCommonSRP.LensFlareCompInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private struct LensFlareCommonSRP.<>c__DisplayClass40_0 // TypeDefIndex: 20015
{
	// Fields
	public Vector2 screenPos; // 0x0
}

// Namespace: 
[CompilerGenerated]
private struct LensFlareCommonSRP.<>c__DisplayClass40_1 // TypeDefIndex: 20016
{
	// Fields
	public LensFlareDataElementSRP element; // 0x0
}

// Namespace: 
[CompilerGenerated]
private struct LensFlareCommonSRP.<>c__DisplayClass40_2 // TypeDefIndex: 20017
{
	// Fields
	public float position; // 0x0
	public float globalCos0; // 0x4
	public float globalSin0; // 0x8
	public float combinedScale; // 0xC
	public float usedAspectRatio; // 0x10
}

// Namespace: UnityEngine.Rendering
public sealed class LensFlareCommonSRP // TypeDefIndex: 20018
{
	// Fields
	private static LensFlareCommonSRP m_Instance; // 0x0
	private static readonly object m_Padlock; // 0x8
	private static List<LensFlareCommonSRP.LensFlareCompInfo> m_Data; // 0x10
	private static List<int> m_AvailableIndicies; // 0x18
	public static int maxLensFlareWithOcclusion; // 0x20
	public static int maxLensFlareWithOcclusionTemporalSample; // 0x24
	public static int mergeNeeded; // 0x28
	public static RTHandle occlusionRT; // 0x30
	private static int frameIdx; // 0x38
	private static readonly bool s_SupportsLensFlareTexFormat; // 0x3C

	// Properties
	public static LensFlareCommonSRP Instance { get; }
	private List<LensFlareCommonSRP.LensFlareCompInfo> Data { get; }

	// Methods

	// RVA: 0x85D9050 Offset: 0x85D5050 VA: 0x85D9050
	private void .ctor() { }

	// RVA: 0x85D9058 Offset: 0x85D5058 VA: 0x85D9058
	public static bool IsOcclusionRTCompatible() { }

	// RVA: 0x85D90E8 Offset: 0x85D50E8 VA: 0x85D90E8
	public static void Initialize() { }

	// RVA: 0x85D9418 Offset: 0x85D5418 VA: 0x85D9418
	public static void Dispose() { }

	// RVA: 0x85D9564 Offset: 0x85D5564 VA: 0x85D9564
	public static LensFlareCommonSRP get_Instance() { }

	// RVA: 0x85D96F0 Offset: 0x85D56F0 VA: 0x85D96F0
	private List<LensFlareCommonSRP.LensFlareCompInfo> get_Data() { }

	// RVA: 0x85D9748 Offset: 0x85D5748 VA: 0x85D9748
	public bool IsEmpty() { }

	// RVA: 0x85D97CC Offset: 0x85D57CC VA: 0x85D97CC
	private int GetNextAvailableIndex() { }

	// RVA: 0x85D98E0 Offset: 0x85D58E0 VA: 0x85D98E0
	public void AddData(LensFlareComponentSRP newData) { }

	// RVA: 0x85D9B38 Offset: 0x85D5B38 VA: 0x85D9B38
	public void RemoveData(LensFlareComponentSRP data) { }

	// RVA: 0x85D9D6C Offset: 0x85D5D6C VA: 0x85D9D6C
	public static float ShapeAttenuationPointLight() { }

	// RVA: 0x85D9D74 Offset: 0x85D5D74 VA: 0x85D9D74
	public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x85D9D94 Offset: 0x85D5D94 VA: 0x85D9D94
	public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01) { }

	// RVA: 0x85D9E40 Offset: 0x85D5E40 VA: 0x85D9E40
	public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x85D9E68 Offset: 0x85D5E68 VA: 0x85D9E68
	public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x85D9F08 Offset: 0x85D5F08 VA: 0x85D9F08
	public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam) { }

	// RVA: 0x85DA420 Offset: 0x85D6420 VA: 0x85DA420
	public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x85DA4B8 Offset: 0x85D64B8 VA: 0x85DA4B8
	public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x85DA550 Offset: 0x85D6550 VA: 0x85DA550
	private static bool IsLensFlareSRPHidden(Camera cam, LensFlareComponentSRP comp, LensFlareDataSRP data) { }

	// RVA: 0x85DA674 Offset: 0x85D6674 VA: 0x85DA674
	public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate) { }

	// RVA: 0x85DA88C Offset: 0x85D688C VA: 0x85DA88C
	private static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0) { }

	// RVA: 0x85DA8C4 Offset: 0x85D68C4 VA: 0x85DA8C4
	private static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS) { }

	// RVA: 0x85DAA08 Offset: 0x85D6A08 VA: 0x85DAA08
	private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS) { }

	// RVA: 0x85DAA80 Offset: 0x85D6A80 VA: 0x85DAA80
	private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS) { }

	// RVA: 0x85DAB60 Offset: 0x85D6B60 VA: 0x85DAB60
	public static bool IsCloudLayerOpacityNeeded(Camera cam) { }

	// RVA: 0x85DAE00 Offset: 0x85D6E00 VA: 0x85DAE00
	private static void SetOcclusionPermutation(CommandBuffer cmd, bool useBackgroundCloudOcclusion, bool volumetricCloudOcclusion, bool hasCloudLayer, int _FlareCloudOpacity, int _FlareSunOcclusionTex, Texture cloudOpacityTexture, Texture sunOcclusionTexture) { }

	// RVA: 0x85DAF8C Offset: 0x85D6F8C VA: 0x85DAF8C
	public static void ComputeOcclusion(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4) { }

	// RVA: 0x85DC07C Offset: 0x85D807C VA: 0x85DC07C
	public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView) { }

	// RVA: 0x85DBE28 Offset: 0x85D7E28 VA: 0x85DBE28
	private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance) { }

	// RVA: 0x85DE66C Offset: 0x85DA66C VA: 0x85DE66C
	private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView) { }

	// RVA: 0x85DE6AC Offset: 0x85DA6AC VA: 0x85DE6AC
	private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d) { }

	// RVA: 0x85DE770 Offset: 0x85DA770 VA: 0x85DE770
	private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d) { }

	// RVA: 0x85DE7A4 Offset: 0x85DA7A4 VA: 0x85DE7A4
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x85DE93C Offset: 0x85DA93C VA: 0x85DE93C
	internal static float <ShapeAttenuationAreaTubeLight>g__Fpo|28_0(float d, float l) { }

	[CompilerGenerated]
	// RVA: 0x85DE97C Offset: 0x85DA97C VA: 0x85DE97C
	internal static float <ShapeAttenuationAreaTubeLight>g__Fwt|28_1(float d, float l) { }

	[CompilerGenerated]
	// RVA: 0x85DA138 Offset: 0x85D6138 VA: 0x85DA138
	internal static float <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|28_2(Vector3 p1, Vector3 p2) { }

	[CompilerGenerated]
	// RVA: 0x85DE4B4 Offset: 0x85DA4B4 VA: 0x85DE4B4
	internal static Vector2 <DoLensFlareDataDrivenCommon>g__ComputeLocalSize|40_0(Vector2 rayOff, Vector2 rayOff0, Vector2 curSize, AnimationCurve distortionCurve, ref LensFlareCommonSRP.<>c__DisplayClass40_0 , ref LensFlareCommonSRP.<>c__DisplayClass40_1 , ref LensFlareCommonSRP.<>c__DisplayClass40_2 ) { }

	[CompilerGenerated]
	// RVA: 0x85DE664 Offset: 0x85DA664 VA: 0x85DE664
	internal static float <DoLensFlareDataDrivenCommon>g__RandomRange|40_1(float min, float max) { }
}

// Namespace: UnityEngine.Rendering
[AddComponentMenu("Rendering/Lens Flare (SRP)")]
[ExecuteAlways]
public sealed class LensFlareComponentSRP : MonoBehaviour // TypeDefIndex: 20019
{
	// Fields
	[SerializeField]
	private LensFlareDataSRP m_LensFlareData; // 0x20
	[Min(0)]
	public float intensity; // 0x28
	[Min(1E-05)]
	public float maxAttenuationDistance; // 0x2C
	[Min(1E-05)]
	public float maxAttenuationScale; // 0x30
	public AnimationCurve distanceAttenuationCurve; // 0x38
	public AnimationCurve scaleByDistanceCurve; // 0x40
	public bool attenuationByLightShape; // 0x48
	public AnimationCurve radialScreenAttenuationCurve; // 0x50
	public bool useOcclusion; // 0x58
	[Min(0)]
	public float occlusionRadius; // 0x5C
	public bool useBackgroundCloudOcclusion; // 0x60
	[Range(1, 64)]
	public uint sampleCount; // 0x64
	public float occlusionOffset; // 0x68
	[Min(0)]
	public float scale; // 0x6C
	public bool allowOffScreen; // 0x70
	public bool volumetricCloudOcclusion; // 0x71
	private static float sCelestialAngularRadius; // 0x0
	public TextureCurve occlusionRemapCurve; // 0x78

	// Properties
	public LensFlareDataSRP lensFlareData { get; set; }

	// Methods

	// RVA: 0x85DEA74 Offset: 0x85DAA74 VA: 0x85DEA74
	public LensFlareDataSRP get_lensFlareData() { }

	// RVA: 0x85DEA7C Offset: 0x85DAA7C VA: 0x85DEA7C
	public void set_lensFlareData(LensFlareDataSRP value) { }

	// RVA: 0x85DBF88 Offset: 0x85D7F88 VA: 0x85DBF88
	public float celestialProjectedOcclusionRadius(Camera mainCam) { }

	// RVA: 0x85DEB6C Offset: 0x85DAB6C VA: 0x85DEB6C
	private void OnEnable() { }

	// RVA: 0x85DEC18 Offset: 0x85DAC18 VA: 0x85DEC18
	private void OnDisable() { }

	// RVA: 0x85DEA98 Offset: 0x85DAA98 VA: 0x85DEA98
	private void OnValidate() { }

	// RVA: 0x85DEC78 Offset: 0x85DAC78 VA: 0x85DEC78
	public void .ctor() { }

	// RVA: 0x85DF020 Offset: 0x85DB020 VA: 0x85DF020
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[Serializable]
public enum SRPLensFlareBlendMode // TypeDefIndex: 20020
{
	// Fields
	public int value__; // 0x0
	public const SRPLensFlareBlendMode Additive = 0;
	public const SRPLensFlareBlendMode Screen = 1;
	public const SRPLensFlareBlendMode Premultiply = 2;
	public const SRPLensFlareBlendMode Lerp = 3;
}

// Namespace: UnityEngine.Rendering
[Serializable]
public enum SRPLensFlareDistribution // TypeDefIndex: 20021
{
	// Fields
	public int value__; // 0x0
	public const SRPLensFlareDistribution Uniform = 0;
	public const SRPLensFlareDistribution Curve = 1;
	public const SRPLensFlareDistribution Random = 2;
}

// Namespace: UnityEngine.Rendering
[Serializable]
public enum SRPLensFlareType // TypeDefIndex: 20022
{
	// Fields
	public int value__; // 0x0
	public const SRPLensFlareType Image = 0;
	public const SRPLensFlareType Circle = 1;
	public const SRPLensFlareType Polygon = 2;
}

// Namespace: UnityEngine.Rendering
[Serializable]
public sealed class LensFlareDataElementSRP // TypeDefIndex: 20023
{
	// Fields
	public bool visible; // 0x10
	public float position; // 0x14
	public Vector2 positionOffset; // 0x18
	public float angularOffset; // 0x20
	public Vector2 translationScale; // 0x24
	[SerializeField]
	[Min(0)]
	[FormerlySerializedAs("localIntensity")]
	private float m_LocalIntensity; // 0x2C
	public Texture lensFlareTexture; // 0x30
	public float uniformScale; // 0x38
	public Vector2 sizeXY; // 0x3C
	public bool allowMultipleElement; // 0x44
	[Min(1)]
	[FormerlySerializedAs("count")]
	[SerializeField]
	private int m_Count; // 0x48
	public bool preserveAspectRatio; // 0x4C
	public float rotation; // 0x50
	public Color tint; // 0x54
	public SRPLensFlareBlendMode blendMode; // 0x64
	public bool autoRotate; // 0x68
	public SRPLensFlareType flareType; // 0x6C
	public bool modulateByLightColor; // 0x70
	[SerializeField]
	private bool isFoldOpened; // 0x71
	public SRPLensFlareDistribution distribution; // 0x74
	public float lengthSpread; // 0x78
	public AnimationCurve positionCurve; // 0x80
	public AnimationCurve scaleCurve; // 0x88
	public int seed; // 0x90
	public Gradient colorGradient; // 0x98
	[FormerlySerializedAs("intensityVariation")]
	[SerializeField]
	[Range(0, 1)]
	private float m_IntensityVariation; // 0xA0
	public Vector2 positionVariation; // 0xA4
	public float scaleVariation; // 0xAC
	public float rotationVariation; // 0xB0
	public bool enableRadialDistortion; // 0xB4
	public Vector2 targetSizeDistortion; // 0xB8
	public AnimationCurve distortionCurve; // 0xC0
	public bool distortionRelativeToCenter; // 0xC8
	[FormerlySerializedAs("fallOff")]
	[SerializeField]
	[Range(0, 1)]
	private float m_FallOff; // 0xCC
	[SerializeField]
	[Range(0, 1)]
	[FormerlySerializedAs("edgeOffset")]
	private float m_EdgeOffset; // 0xD0
	[FormerlySerializedAs("sideCount")]
	[Min(3)]
	[SerializeField]
	private int m_SideCount; // 0xD4
	[Range(0, 1)]
	[SerializeField]
	[FormerlySerializedAs("sdfRoundness")]
	private float m_SdfRoundness; // 0xD8
	public bool inverseSDF; // 0xDC
	public float uniformAngle; // 0xE0
	public AnimationCurve uniformAngleCurve; // 0xE8

	// Properties
	public float localIntensity { get; set; }
	public int count { get; set; }
	public float intensityVariation { get; set; }
	public float fallOff { get; set; }
	public float edgeOffset { get; set; }
	public int sideCount { get; set; }
	public float sdfRoundness { get; set; }

	// Methods

	// RVA: 0x85DF070 Offset: 0x85DB070 VA: 0x85DF070
	public void .ctor() { }

	// RVA: 0x85DF7B4 Offset: 0x85DB7B4 VA: 0x85DF7B4
	public float get_localIntensity() { }

	// RVA: 0x85DF71C Offset: 0x85DB71C VA: 0x85DF71C
	public void set_localIntensity(float value) { }

	// RVA: 0x85DF7BC Offset: 0x85DB7BC VA: 0x85DF7BC
	public int get_count() { }

	// RVA: 0x85DF72C Offset: 0x85DB72C VA: 0x85DF72C
	public void set_count(int value) { }

	// RVA: 0x85DF7C4 Offset: 0x85DB7C4 VA: 0x85DF7C4
	public float get_intensityVariation() { }

	// RVA: 0x85DF73C Offset: 0x85DB73C VA: 0x85DF73C
	public void set_intensityVariation(float value) { }

	// RVA: 0x85DF7CC Offset: 0x85DB7CC VA: 0x85DF7CC
	public float get_fallOff() { }

	// RVA: 0x85DF74C Offset: 0x85DB74C VA: 0x85DF74C
	public void set_fallOff(float value) { }

	// RVA: 0x85DF7D4 Offset: 0x85DB7D4 VA: 0x85DF7D4
	public float get_edgeOffset() { }

	// RVA: 0x85DF768 Offset: 0x85DB768 VA: 0x85DF768
	public void set_edgeOffset(float value) { }

	// RVA: 0x85DF7DC Offset: 0x85DB7DC VA: 0x85DF7DC
	public int get_sideCount() { }

	// RVA: 0x85DF7A0 Offset: 0x85DB7A0 VA: 0x85DF7A0
	public void set_sideCount(int value) { }

	// RVA: 0x85DF7E4 Offset: 0x85DB7E4 VA: 0x85DF7E4
	public float get_sdfRoundness() { }

	// RVA: 0x85DF784 Offset: 0x85DB784 VA: 0x85DF784
	public void set_sdfRoundness(float value) { }
}

// Namespace: UnityEngine.Rendering
[Serializable]
public sealed class LensFlareDataSRP : ScriptableObject // TypeDefIndex: 20024
{
	// Fields
	public LensFlareDataElementSRP[] elements; // 0x18

	// Methods

	// RVA: 0x85DF7EC Offset: 0x85DB7EC VA: 0x85DF7EC
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public interface ICloudBackground // TypeDefIndex: 20025
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsCloudBackgroundUsable();
}

// Namespace: UnityEngine.Rendering
public enum ShaderVariantLogLevel // TypeDefIndex: 20026
{
	// Fields
	public int value__; // 0x0
	[Tooltip("No shader variants are logged")]
	public const ShaderVariantLogLevel Disabled = 0;
	[Tooltip("Only shaders that are compatible with SRPs (e.g., URP, HDRP) are logged")]
	public const ShaderVariantLogLevel OnlySRPShaders = 1;
	[Tooltip("All shader variants are logged")]
	public const ShaderVariantLogLevel AllShaders = 2;
}

// Namespace: UnityEngine.Rendering
public interface IShaderVariantSettings // TypeDefIndex: 20027
{
	// Properties
	public abstract ShaderVariantLogLevel shaderVariantLogLevel { get; set; }
	public abstract bool exportShaderVariants { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ShaderVariantLogLevel get_shaderVariantLogLevel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_shaderVariantLogLevel(ShaderVariantLogLevel value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_exportShaderVariants();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_exportShaderVariants(bool value);
}

// Namespace: UnityEngine.Rendering
public interface IVolumetricCloud // TypeDefIndex: 20028
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsVolumetricCloudUsable();
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineResources : ScriptableObject // TypeDefIndex: 20029
{
	// Properties
	protected virtual string packagePath { get; }
	internal string packagePath_Internal { get; }

	// Methods

	// RVA: 0x85DF810 Offset: 0x85DB810 VA: 0x85DF810 Slot: 4
	protected virtual string get_packagePath() { }

	// RVA: 0x85DF818 Offset: 0x85DB818 VA: 0x85DF818
	internal string get_packagePath_Internal() { }

	// RVA: 0x85DF824 Offset: 0x85DB824 VA: 0x85DF824
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public enum PackingRules // TypeDefIndex: 20030
{
	// Fields
	public int value__; // 0x0
	public const PackingRules Exact = 0;
	public const PackingRules Aggressive = 1;
}

// Namespace: UnityEngine.Rendering
public enum FieldPacking // TypeDefIndex: 20031
{
	// Fields
	public int value__; // 0x0
	public const FieldPacking NoPacking = 0;
	public const FieldPacking R11G11B10 = 1;
	public const FieldPacking PackedFloat = 2;
	public const FieldPacking PackedUint = 3;
}

// Namespace: UnityEngine.Rendering
public enum FieldPrecision // TypeDefIndex: 20032
{
	// Fields
	public int value__; // 0x0
	public const FieldPrecision Half = 0;
	public const FieldPrecision Real = 1;
	public const FieldPrecision Default = 2;
}

// Namespace: UnityEngine.Rendering
[Usage(28)]
public class GenerateHLSL : Attribute // TypeDefIndex: 20033
{
	// Fields
	public PackingRules packingRules; // 0x10
	public bool containsPackedFields; // 0x14
	public bool needAccessors; // 0x15
	public bool needSetters; // 0x16
	public bool needParamDebug; // 0x17
	public int paramDefinesStart; // 0x18
	public bool omitStructDeclaration; // 0x1C
	public bool generateCBuffer; // 0x1D
	public int constantRegister; // 0x20
	public string sourcePath; // 0x28

	// Methods

	// RVA: 0x85DF82C Offset: 0x85DB82C VA: 0x85DF82C
	public void .ctor(PackingRules rules = 0, bool needAccessors = True, bool needSetters = False, bool needParamDebug = False, int paramDefinesStart = 1, bool omitStructDeclaration = False, bool containsPackedFields = False, bool generateCBuffer = False, int constantRegister = -1, string sourcePath) { }
}

// Namespace: UnityEngine.Rendering
[Usage(256)]
public class SurfaceDataAttributes : Attribute // TypeDefIndex: 20034
{
	// Fields
	public string[] displayNames; // 0x10
	public bool isDirection; // 0x18
	public bool sRGBDisplay; // 0x19
	public FieldPrecision precision; // 0x1C
	public bool checkIsNormalized; // 0x20
	public string preprocessor; // 0x28

	// Methods

	// RVA: 0x85DF8CC Offset: 0x85DB8CC VA: 0x85DF8CC
	public void .ctor(string displayName = "", bool isDirection = False, bool sRGBDisplay = False, FieldPrecision precision = 2, bool checkIsNormalized = False, string preprocessor = "") { }

	// RVA: 0x85DF9B4 Offset: 0x85DB9B4 VA: 0x85DF9B4
	public void .ctor(string[] displayNames, bool isDirection = False, bool sRGBDisplay = False, FieldPrecision precision = 2, bool checkIsNormalized = False, string preprocessor = "") { }
}

// Namespace: UnityEngine.Rendering
[Usage(256)]
public class HLSLArray : Attribute // TypeDefIndex: 20035
{
	// Fields
	public int arraySize; // 0x10
	public Type elementType; // 0x18

	// Methods

	// RVA: 0x85DFA28 Offset: 0x85DBA28 VA: 0x85DFA28
	public void .ctor(int arraySize, Type elementType) { }
}

// Namespace: UnityEngine.Rendering
[Usage(256, AllowMultiple = True)]
public class PackingAttribute : Attribute // TypeDefIndex: 20036
{
	// Fields
	public string[] displayNames; // 0x10
	public float[] range; // 0x18
	public FieldPacking packingScheme; // 0x20
	public int offsetInSource; // 0x24
	public int sizeInBits; // 0x28
	public bool isDirection; // 0x2C
	public bool sRGBDisplay; // 0x2D
	public bool checkIsNormalized; // 0x2E
	public string preprocessor; // 0x30

	// Methods

	// RVA: 0x85DFA60 Offset: 0x85DBA60 VA: 0x85DFA60
	public void .ctor(string[] displayNames, FieldPacking packingScheme = 0, int bitSize = 32, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = False, bool sRGBDisplay = False, bool checkIsNormalized = False, string preprocessor = "") { }

	// RVA: 0x85DFB7C Offset: 0x85DBB7C VA: 0x85DFB7C
	public void .ctor(string displayName = "", FieldPacking packingScheme = 0, int bitSize = 0, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = False, bool sRGBDisplay = False, bool checkIsNormalized = False, string preprocessor = "") { }
}

// Namespace: UnityEngine.Rendering
public struct ShaderGenUInt4 // TypeDefIndex: 20037
{}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Hammersley.Hammersley2dSeq16.<hammersley2dSeq16>e__FixedBuffer // TypeDefIndex: 20038
{
	// Fields
	public float FixedElementField; // 0x0
}

// Namespace: 
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\ShaderLibrary\Sampling\Hammersley.cs", needAccessors = False, generateCBuffer = True)]
private struct Hammersley.Hammersley2dSeq16 // TypeDefIndex: 20039
{
	// Fields
	[FixedBuffer(typeof(float), 64)]
	[HLSLArray(16, typeof(Vector4))]
	public Hammersley.Hammersley2dSeq16.<hammersley2dSeq16>e__FixedBuffer hammersley2dSeq16; // 0x0
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct Hammersley.Hammersley2dSeq32.<hammersley2dSeq32>e__FixedBuffer // TypeDefIndex: 20040
{
	// Fields
	public float FixedElementField; // 0x0
}

// Namespace: 
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\ShaderLibrary\Sampling\Hammersley.cs", needAccessors = False, generateCBuffer = True)]
private struct Hammersley.Hammersley2dSeq32 // TypeDefIndex: 20041
{
	// Fields
	[HLSLArray(32, typeof(Vector4))]
	[FixedBuffer(typeof(float), 128)]
	public Hammersley.Hammersley2dSeq32.<hammersley2dSeq32>e__FixedBuffer hammersley2dSeq32; // 0x0
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Hammersley.Hammersley2dSeq64.<hammersley2dSeq64>e__FixedBuffer // TypeDefIndex: 20042
{
	// Fields
	public float FixedElementField; // 0x0
}

// Namespace: 
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\ShaderLibrary\Sampling\Hammersley.cs", needAccessors = False, generateCBuffer = True)]
private struct Hammersley.Hammersley2dSeq64 // TypeDefIndex: 20043
{
	// Fields
	[HLSLArray(64, typeof(Vector4))]
	[FixedBuffer(typeof(float), 256)]
	public Hammersley.Hammersley2dSeq64.<hammersley2dSeq64>e__FixedBuffer hammersley2dSeq64; // 0x0
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct Hammersley.Hammersley2dSeq256.<hammersley2dSeq256>e__FixedBuffer // TypeDefIndex: 20044
{
	// Fields
	public float FixedElementField; // 0x0
}

// Namespace: 
[GenerateHLSL(0, True, False, False, 1, False, False, False, -1, ".\Library\PackageCache\com.unity.render-pipelines.core@14.0.12\Runtime\ShaderLibrary\Sampling\Hammersley.cs", needAccessors = False, generateCBuffer = True)]
private struct Hammersley.Hammersley2dSeq256 // TypeDefIndex: 20045
{
	// Fields
	[HLSLArray(256, typeof(Vector4))]
	[FixedBuffer(typeof(float), 1024)]
	public Hammersley.Hammersley2dSeq256.<hammersley2dSeq256>e__FixedBuffer hammersley2dSeq256; // 0x0
}

// Namespace: UnityEngine.Rendering
internal static class Hammersley // TypeDefIndex: 20046
{
	// Fields
	private static float[] k_Hammersley2dSeq16; // 0x0
	private static float[] k_Hammersley2dSeq32; // 0x8
	private static float[] k_Hammersley2dSeq64; // 0x10
	private static float[] k_Hammersley2dSeq256; // 0x18
	private static readonly int s_hammersley2DSeq16Id; // 0x20
	private static readonly int s_hammersley2DSeq32Id; // 0x24
	private static readonly int s_hammersley2DSeq64Id; // 0x28
	private static readonly int s_hammersley2DSeq256Id; // 0x2C

	// Methods

	// RVA: 0x85DFCD4 Offset: 0x85DBCD4 VA: 0x85DFCD4
	public static void Initialize() { }

	// RVA: 0x85E0024 Offset: 0x85DC024 VA: 0x85E0024
	public static void BindConstants(CommandBuffer cmd, ComputeShader cs) { }

	// RVA: 0x85E0178 Offset: 0x85DC178 VA: 0x85E0178
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public class BufferedRTHandleSystem : IDisposable // TypeDefIndex: 20047
{
	// Fields
	private Dictionary<int, RTHandle[]> m_RTHandles; // 0x10
	private RTHandleSystem m_RTHandleSystem; // 0x18
	private bool m_DisposedValue; // 0x20

	// Properties
	public int maxWidth { get; }
	public int maxHeight { get; }
	public RTHandleProperties rtHandleProperties { get; }

	// Methods

	// RVA: 0x85E03B0 Offset: 0x85DC3B0 VA: 0x85E03B0
	public int get_maxWidth() { }

	// RVA: 0x85E03CC Offset: 0x85DC3CC VA: 0x85E03CC
	public int get_maxHeight() { }

	// RVA: 0x85E03E8 Offset: 0x85DC3E8 VA: 0x85E03E8
	public RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x85E0410 Offset: 0x85DC410 VA: 0x85E0410
	public RTHandle GetFrameRT(int bufferId, int frameIndex) { }

	// RVA: 0x85E04C8 Offset: 0x85DC4C8 VA: 0x85E04C8
	public void AllocBuffer(int bufferId, Func<RTHandleSystem, int, RTHandle> allocator, int bufferCount) { }

	// RVA: 0x85E0778 Offset: 0x85DC778 VA: 0x85E0778
	public void ReleaseBuffer(int bufferId) { }

	// RVA: 0x85E0878 Offset: 0x85DC878 VA: 0x85E0878
	public void SwapAndSetReferenceSize(int width, int height) { }

	// RVA: 0x85E0BB8 Offset: 0x85DCBB8 VA: 0x85E0BB8
	public void ResetReferenceSize(int width, int height) { }

	// RVA: 0x85E0BE4 Offset: 0x85DCBE4 VA: 0x85E0BE4
	public int GetNumFramesAllocated(int bufferId) { }

	// RVA: 0x85E0C7C Offset: 0x85DCC7C VA: 0x85E0C7C
	public Vector2 CalculateRatioAgainstMaxSize(int width, int height) { }

	// RVA: 0x85E08B4 Offset: 0x85DC8B4 VA: 0x85E08B4
	private void Swap() { }

	// RVA: 0x85E0EB4 Offset: 0x85DCEB4 VA: 0x85E0EB4
	private void Dispose(bool disposing) { }

	// RVA: 0x85E10FC Offset: 0x85DD0FC VA: 0x85E10FC Slot: 4
	public void Dispose() { }

	// RVA: 0x85E0F10 Offset: 0x85DCF10 VA: 0x85E0F10
	public void ReleaseAll() { }

	// RVA: 0x85E1104 Offset: 0x85DD104 VA: 0x85E1104
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public enum DepthBits // TypeDefIndex: 20048
{
	// Fields
	public int value__; // 0x0
	public const DepthBits None = 0;
	public const DepthBits Depth8 = 8;
	public const DepthBits Depth16 = 16;
	public const DepthBits Depth24 = 24;
	public const DepthBits Depth32 = 32;
}

// Namespace: UnityEngine.Rendering
public enum MSAASamples // TypeDefIndex: 20049
{
	// Fields
	public int value__; // 0x0
	public const MSAASamples None = 1;
	public const MSAASamples MSAA2x = 2;
	public const MSAASamples MSAA4x = 4;
	public const MSAASamples MSAA8x = 8;
}

// Namespace: 
private enum PowerOfTwoTextureAtlas.BlitType // TypeDefIndex: 20050
{
	// Fields
	public int value__; // 0x0
	public const PowerOfTwoTextureAtlas.BlitType Padding = 0;
	public const PowerOfTwoTextureAtlas.BlitType PaddingMultiply = 1;
	public const PowerOfTwoTextureAtlas.BlitType OctahedralPadding = 2;
	public const PowerOfTwoTextureAtlas.BlitType OctahedralPaddingMultiply = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PowerOfTwoTextureAtlas.<>c // TypeDefIndex: 20051
{
	// Fields
	public static readonly PowerOfTwoTextureAtlas.<>c <>9; // 0x0
	[TupleElementNames(new[] { "instanceId", "size" })]
	public static Comparison<ValueTuple<int, Vector2Int>> <>9__23_0; // 0x8

	// Methods

	// RVA: 0x85E2828 Offset: 0x85DE828 VA: 0x85E2828
	private static void .cctor() { }

	// RVA: 0x85E2890 Offset: 0x85DE890 VA: 0x85E2890
	public void .ctor() { }

	// RVA: 0x85E2898 Offset: 0x85DE898 VA: 0x85E2898
	internal int <RelayoutEntries>b__23_0(ValueTuple<int, Vector2Int> c1, ValueTuple<int, Vector2Int> c2) { }
}

// Namespace: UnityEngine.Rendering
public class PowerOfTwoTextureAtlas : Texture2DAtlas // TypeDefIndex: 20052
{
	// Fields
	private readonly int m_MipPadding; // 0x48
	private const float k_MipmapFactorApprox = 1.33;
	private Dictionary<int, Vector2Int> m_RequestedTextures; // 0x50

	// Properties
	public int mipPadding { get; }

	// Methods

	// RVA: 0x85E1278 Offset: 0x85DD278 VA: 0x85E1278
	public void .ctor(int size, int mipPadding, GraphicsFormat format, FilterMode filterMode = 0, string name = "", bool useMipMap = True) { }

	// RVA: 0x85E1380 Offset: 0x85DD380 VA: 0x85E1380
	public int get_mipPadding() { }

	// RVA: 0x85E1388 Offset: 0x85DD388 VA: 0x85E1388
	private int GetTexturePadding() { }

	// RVA: 0x85E13B8 Offset: 0x85DD3B8 VA: 0x85E13B8
	public Vector4 GetPayloadScaleOffset(Texture texture, in Vector4 scaleOffset) { }

	// RVA: 0x85E14F8 Offset: 0x85DD4F8 VA: 0x85E14F8
	public static Vector4 GetPayloadScaleOffset(in Vector2 textureSize, in Vector2 paddingSize, in Vector4 scaleOffset) { }

	// RVA: 0x85E1530 Offset: 0x85DD530 VA: 0x85E1530
	private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, PowerOfTwoTextureAtlas.BlitType blitType) { }

	// RVA: 0x85E1918 Offset: 0x85DD918 VA: 0x85E1918 Slot: 4
	public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x85E1A24 Offset: 0x85DDA24 VA: 0x85E1A24
	public void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x85E1B30 Offset: 0x85DDB30 VA: 0x85E1B30 Slot: 5
	public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x85E1C3C Offset: 0x85DDC3C VA: 0x85E1C3C
	public void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x85E1D48 Offset: 0x85DDD48 VA: 0x85E1D48
	private void TextureSizeToPowerOfTwo(Texture texture, ref int width, ref int height) { }

	// RVA: 0x85E148C Offset: 0x85DD48C VA: 0x85E148C
	private Vector2 GetPowerOfTwoTextureSize(Texture texture) { }

	// RVA: 0x85E1D84 Offset: 0x85DDD84 VA: 0x85E1D84 Slot: 7
	public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1) { }

	// RVA: 0x85E1F94 Offset: 0x85DDF94 VA: 0x85E1F94
	public void ResetRequestedTexture() { }

	// RVA: 0x85E1FE4 Offset: 0x85DDFE4 VA: 0x85E1FE4
	public bool ReserveSpace(Texture texture) { }

	// RVA: 0x85E2058 Offset: 0x85DE058 VA: 0x85E2058
	public bool ReserveSpace(Texture texture, int width, int height) { }

	// RVA: 0x85E21BC Offset: 0x85DE1BC VA: 0x85E21BC
	public bool ReserveSpace(Texture textureA, Texture textureB, int width, int height) { }

	// RVA: 0x85E2090 Offset: 0x85DE090 VA: 0x85E2090
	private bool ReserveSpace(int id, int width, int height) { }

	// RVA: 0x85E21F4 Offset: 0x85DE1F4 VA: 0x85E21F4
	public bool RelayoutEntries() { }

	// RVA: 0x85E2684 Offset: 0x85DE684 VA: 0x85E2684
	public static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format) { }

	// RVA: 0x85E274C Offset: 0x85DE74C VA: 0x85E274C
	public static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format) { }
}

// Namespace: UnityEngine.Rendering
public struct RTHandleStaticHelpers // TypeDefIndex: 20053
{
	// Fields
	public static RTHandle s_RTHandleWrapper; // 0x0

	// Methods

	// RVA: 0x85E28DC Offset: 0x85DE8DC VA: 0x85E28DC
	public static void SetRTHandleStaticWrapper(RenderTargetIdentifier rtId) { }

	// RVA: 0x85E2AC4 Offset: 0x85DEAC4 VA: 0x85E2AC4
	public static void SetRTHandleUserManagedWrapper(ref RTHandle rtWrapper, RenderTargetIdentifier rtId) { }
}

// Namespace: UnityEngine.Rendering
public class RTHandle // TypeDefIndex: 20054
{
	// Fields
	internal RTHandleSystem m_Owner; // 0x10
	internal RenderTexture m_RT; // 0x18
	internal Texture m_ExternalTexture; // 0x20
	internal RenderTargetIdentifier m_NameID; // 0x28
	internal bool m_EnableMSAA; // 0x50
	internal bool m_EnableRandomWrite; // 0x51
	internal bool m_EnableHWDynamicScale; // 0x52
	internal string m_Name; // 0x58
	internal bool m_UseCustomHandleScales; // 0x60
	internal RTHandleProperties m_CustomHandleProperties; // 0x64
	[CompilerGenerated]
	private Vector2 <scaleFactor>k__BackingField; // 0x94
	internal ScaleFunc scaleFunc; // 0xA0
	[CompilerGenerated]
	private bool <useScaling>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Vector2Int <referenceSize>k__BackingField; // 0xAC

	// Properties
	public Vector2 scaleFactor { get; set; }
	public bool useScaling { get; set; }
	public Vector2Int referenceSize { get; set; }
	public RTHandleProperties rtHandleProperties { get; }
	public RenderTexture rt { get; }
	public RenderTargetIdentifier nameID { get; }
	public string name { get; }
	public bool isMSAAEnabled { get; }

	// Methods

	// RVA: 0x85E2C80 Offset: 0x85DEC80 VA: 0x85E2C80
	public void SetCustomHandleProperties(in RTHandleProperties properties) { }

	// RVA: 0x85E2CA0 Offset: 0x85DECA0 VA: 0x85E2CA0
	public void ClearCustomHandleProperties() { }

	[CompilerGenerated]
	// RVA: 0x85E2CA8 Offset: 0x85DECA8 VA: 0x85E2CA8
	public Vector2 get_scaleFactor() { }

	[CompilerGenerated]
	// RVA: 0x85E2CB0 Offset: 0x85DECB0 VA: 0x85E2CB0
	internal void set_scaleFactor(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x85E2CB8 Offset: 0x85DECB8 VA: 0x85E2CB8
	public bool get_useScaling() { }

	[CompilerGenerated]
	// RVA: 0x85E2CC0 Offset: 0x85DECC0 VA: 0x85E2CC0
	internal void set_useScaling(bool value) { }

	[CompilerGenerated]
	// RVA: 0x85E2CCC Offset: 0x85DECCC VA: 0x85E2CCC
	public Vector2Int get_referenceSize() { }

	[CompilerGenerated]
	// RVA: 0x85E2CD4 Offset: 0x85DECD4 VA: 0x85E2CD4
	internal void set_referenceSize(Vector2Int value) { }

	// RVA: 0x85E2CDC Offset: 0x85DECDC VA: 0x85E2CDC
	public RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x85E2D1C Offset: 0x85DED1C VA: 0x85E2D1C
	public RenderTexture get_rt() { }

	// RVA: 0x85E2D24 Offset: 0x85DED24 VA: 0x85E2D24
	public RenderTargetIdentifier get_nameID() { }

	// RVA: 0x85E2D3C Offset: 0x85DED3C VA: 0x85E2D3C
	public string get_name() { }

	// RVA: 0x85E2D44 Offset: 0x85DED44 VA: 0x85E2D44
	public bool get_isMSAAEnabled() { }

	// RVA: 0x85E2D4C Offset: 0x85DED4C VA: 0x85E2D4C
	internal void .ctor(RTHandleSystem owner) { }

	// RVA: 0x85DC050 Offset: 0x85D8050 VA: 0x85DC050
	public static RenderTargetIdentifier op_Implicit(RTHandle handle) { }

	// RVA: 0x85E2D7C Offset: 0x85DED7C VA: 0x85E2D7C
	public static Texture op_Implicit(RTHandle handle) { }

	// RVA: 0x85E2DFC Offset: 0x85DEDFC VA: 0x85E2DFC
	public static RenderTexture op_Implicit(RTHandle handle) { }

	// RVA: 0x85E2E08 Offset: 0x85DEE08 VA: 0x85E2E08
	internal void SetRenderTexture(RenderTexture rt) { }

	// RVA: 0x85E2E74 Offset: 0x85DEE74 VA: 0x85E2E74
	internal void SetTexture(Texture tex) { }

	// RVA: 0x85E2A78 Offset: 0x85DEA78 VA: 0x85E2A78
	internal void SetTexture(RenderTargetIdentifier tex) { }

	// RVA: 0x85E2EE4 Offset: 0x85DEEE4 VA: 0x85E2EE4
	public int GetInstanceID() { }

	// RVA: 0x85E2FA0 Offset: 0x85DEFA0 VA: 0x85E2FA0
	public void Release() { }

	// RVA: 0x85E30D0 Offset: 0x85DF0D0 VA: 0x85E30D0
	public Vector2Int GetScaledSize(Vector2Int refSize) { }

	// RVA: 0x85E32C4 Offset: 0x85DF2C4 VA: 0x85E32C4
	public Vector2Int GetScaledSize() { }

	// RVA: 0x85E34B8 Offset: 0x85DF4B8 VA: 0x85E34B8
	public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1, bool copyContents = False) { }

	// RVA: 0x85E353C Offset: 0x85DF53C VA: 0x85E353C
	public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1) { }

	// RVA: 0x85E3544 Offset: 0x85DF544 VA: 0x85E3544
	public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = True) { }
}

// Namespace: UnityEngine.Rendering
public static class RTHandles // TypeDefIndex: 20055
{
	// Fields
	private static RTHandleSystem s_DefaultInstance; // 0x0

	// Properties
	public static int maxWidth { get; }
	public static int maxHeight { get; }
	public static RTHandleProperties rtHandleProperties { get; }

	// Methods

	// RVA: 0x85E35A0 Offset: 0x85DF5A0 VA: 0x85E35A0
	public static int get_maxWidth() { }

	// RVA: 0x85E3604 Offset: 0x85DF604 VA: 0x85E3604
	public static int get_maxHeight() { }

	// RVA: 0x85E3668 Offset: 0x85DF668 VA: 0x85E3668
	public static RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x85D92C4 Offset: 0x85D52C4 VA: 0x85D92C4
	public static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x85E3798 Offset: 0x85DF798 VA: 0x85E3798
	public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = 0, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x85E3E74 Offset: 0x85DFE74 VA: 0x85E3E74
	public static RTHandle Alloc(in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x85E40F4 Offset: 0x85E00F4 VA: 0x85E40F4
	public static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x85E4514 Offset: 0x85E0514 VA: 0x85E4514
	public static RTHandle Alloc(Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x85E4788 Offset: 0x85E0788 VA: 0x85E4788
	public static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x85E4A20 Offset: 0x85E0A20 VA: 0x85E4A20
	public static RTHandle Alloc(ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x85E4C8C Offset: 0x85E0C8C VA: 0x85E4C8C
	public static RTHandle Alloc(Texture tex) { }

	// RVA: 0x85E4DA4 Offset: 0x85E0DA4 VA: 0x85E4DA4
	public static RTHandle Alloc(RenderTexture tex) { }

	// RVA: 0x85E29E4 Offset: 0x85DE9E4 VA: 0x85E29E4
	public static RTHandle Alloc(RenderTargetIdentifier tex) { }

	// RVA: 0x85E4F30 Offset: 0x85E0F30 VA: 0x85E4F30
	public static RTHandle Alloc(RenderTargetIdentifier tex, string name) { }

	// RVA: 0x85E50B4 Offset: 0x85E10B4 VA: 0x85E50B4
	private static RTHandle Alloc(RTHandle tex) { }

	// RVA: 0x85E5124 Offset: 0x85E1124 VA: 0x85E5124
	public static void Initialize(int width, int height) { }

	[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead.")]
	// RVA: 0x85E5448 Offset: 0x85E1448 VA: 0x85E5448
	public static void Initialize(int width, int height, bool useLegacyDynamicResControl = False) { }

	// RVA: 0x85D94EC Offset: 0x85D54EC VA: 0x85D94EC
	public static void Release(RTHandle rth) { }

	// RVA: 0x85E5504 Offset: 0x85E1504 VA: 0x85E5504
	public static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested) { }

	// RVA: 0x85E56E0 Offset: 0x85E16E0 VA: 0x85E56E0
	public static void SetReferenceSize(int width, int height) { }

	// RVA: 0x85E575C Offset: 0x85E175C VA: 0x85E575C
	public static void ResetReferenceSize(int width, int height) { }

	// RVA: 0x85E57DC Offset: 0x85E17DC VA: 0x85E57DC
	public static Vector2 CalculateRatioAgainstMaxSize(int width, int height) { }

	// RVA: 0x85E5860 Offset: 0x85E1860 VA: 0x85E5860
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public sealed class ScaleFunc : MulticastDelegate // TypeDefIndex: 20056
{
	// Methods

	// RVA: 0x85E58D8 Offset: 0x85E18D8 VA: 0x85E58D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x85E5978 Offset: 0x85E1978 VA: 0x85E5978 Slot: 13
	public virtual Vector2Int Invoke(Vector2Int size) { }

	// RVA: 0x85E598C Offset: 0x85E198C VA: 0x85E598C Slot: 14
	public virtual IAsyncResult BeginInvoke(Vector2Int size, AsyncCallback callback, object object) { }

	// RVA: 0x85E5A10 Offset: 0x85E1A10 VA: 0x85E5A10 Slot: 15
	public virtual Vector2Int EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.Rendering
public struct RTHandleProperties // TypeDefIndex: 20057
{
	// Fields
	public Vector2Int previousViewportSize; // 0x0
	public Vector2Int previousRenderTargetSize; // 0x8
	public Vector2Int currentViewportSize; // 0x10
	public Vector2Int currentRenderTargetSize; // 0x18
	public Vector4 rtHandleScale; // 0x20
}

// Namespace: 
internal enum RTHandleSystem.ResizeMode // TypeDefIndex: 20058
{
	// Fields
	public int value__; // 0x0
	public const RTHandleSystem.ResizeMode Auto = 0;
	public const RTHandleSystem.ResizeMode OnDemand = 1;
}

// Namespace: UnityEngine.Rendering
public class RTHandleSystem : IDisposable // TypeDefIndex: 20059
{
	// Fields
	private bool m_HardwareDynamicResRequested; // 0x10
	private HashSet<RTHandle> m_AutoSizedRTs; // 0x18
	private RTHandle[] m_AutoSizedRTsArray; // 0x20
	private HashSet<RTHandle> m_ResizeOnDemandRTs; // 0x28
	private RTHandleProperties m_RTHandleProperties; // 0x30
	private int m_MaxWidths; // 0x60
	private int m_MaxHeights; // 0x64

	// Properties
	public RTHandleProperties rtHandleProperties { get; }

	// Methods

	// RVA: 0x85E5A38 Offset: 0x85E1A38 VA: 0x85E5A38
	public RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x85E11C0 Offset: 0x85DD1C0 VA: 0x85E11C0
	public void .ctor() { }

	// RVA: 0x85E10F4 Offset: 0x85DD0F4 VA: 0x85E10F4 Slot: 4
	public void Dispose() { }

	// RVA: 0x85E519C Offset: 0x85E119C VA: 0x85E519C
	public void Initialize(int width, int height) { }

	[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead.")]
	// RVA: 0x85E54D8 Offset: 0x85E14D8 VA: 0x85E54D8
	public void Initialize(int width, int height, bool useLegacyDynamicResControl = False) { }

	// RVA: 0x85E0868 Offset: 0x85DC868 VA: 0x85E0868
	public void Release(RTHandle rth) { }

	// RVA: 0x85E3078 Offset: 0x85DF078 VA: 0x85E3078
	internal void Remove(RTHandle rth) { }

	// RVA: 0x85E0BD8 Offset: 0x85DCBD8 VA: 0x85E0BD8
	public void ResetReferenceSize(int width, int height) { }

	// RVA: 0x85E0BB0 Offset: 0x85DCBB0 VA: 0x85E0BB0
	public void SetReferenceSize(int width, int height) { }

	// RVA: 0x85E5C1C Offset: 0x85E1C1C VA: 0x85E5C1C
	public void SetReferenceSize(int width, int height, bool reset) { }

	// RVA: 0x85E0CA8 Offset: 0x85DCCA8 VA: 0x85E0CA8
	internal Vector2 CalculateRatioAgainstMaxSize(in Vector2Int viewportSize) { }

	// RVA: 0x85E556C Offset: 0x85E156C VA: 0x85E556C
	public void SetHardwareDynamicResolutionState(bool enableHWDynamicRes) { }

	// RVA: 0x85E0664 Offset: 0x85DC664 VA: 0x85E0664
	internal void SwitchResizeMode(RTHandle rth, RTHandleSystem.ResizeMode mode) { }

	// RVA: 0x85E6090 Offset: 0x85E2090 VA: 0x85E6090
	private void DemandResize(RTHandle rth) { }

	// RVA: 0x85E62E4 Offset: 0x85E22E4 VA: 0x85E62E4
	public int GetMaxWidth() { }

	// RVA: 0x85E62EC Offset: 0x85E22EC VA: 0x85E62EC
	public int GetMaxHeight() { }

	// RVA: 0x85E5A4C Offset: 0x85E1A4C VA: 0x85E5A4C
	private void Dispose(bool disposing) { }

	// RVA: 0x85E5DA8 Offset: 0x85E1DA8 VA: 0x85E5DA8
	private void Resize(int width, int height, bool sizeChanged) { }

	// RVA: 0x85E36DC Offset: 0x85DF6DC VA: 0x85E36DC
	public RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x85E38F4 Offset: 0x85DF8F4 VA: 0x85E38F4
	public RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = 0, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x85E4244 Offset: 0x85E0244 VA: 0x85E4244
	public RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x85E48CC Offset: 0x85E08CC VA: 0x85E48CC
	public RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x85E62F4 Offset: 0x85E22F4 VA: 0x85E62F4
	private RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, RenderTextureMemoryless memoryless, VRTextureUsage vrUsage, string name) { }

	// RVA: 0x85E4E0C Offset: 0x85E0E0C VA: 0x85E4E0C
	public RTHandle Alloc(RenderTexture texture) { }

	// RVA: 0x85E4CF4 Offset: 0x85E0CF4 VA: 0x85E4CF4
	public RTHandle Alloc(Texture texture) { }

	// RVA: 0x85E4EBC Offset: 0x85E0EBC VA: 0x85E4EBC
	public RTHandle Alloc(RenderTargetIdentifier texture) { }

	// RVA: 0x85E4FD4 Offset: 0x85E0FD4 VA: 0x85E4FD4
	public RTHandle Alloc(RenderTargetIdentifier texture, string name) { }

	// RVA: 0x85E6814 Offset: 0x85E2814 VA: 0x85E6814
	private static RTHandle Alloc(RTHandle tex) { }

	// RVA: 0x85E6884 Offset: 0x85E2884 VA: 0x85E6884
	internal string DumpRTInfo() { }
}

// Namespace: 
private class AtlasAllocator.AtlasNode // TypeDefIndex: 20060
{
	// Fields
	public AtlasAllocator.AtlasNode m_RightChild; // 0x10
	public AtlasAllocator.AtlasNode m_BottomChild; // 0x18
	public Vector4 m_Rect; // 0x20

	// Methods

	// RVA: 0x85E6E80 Offset: 0x85E2E80 VA: 0x85E6E80
	public AtlasAllocator.AtlasNode Allocate(ref ObjectPool<AtlasAllocator.AtlasNode> pool, int width, int height, bool powerOfTwoPadding) { }

	// RVA: 0x85E70CC Offset: 0x85E30CC VA: 0x85E70CC
	public void Release(ref ObjectPool<AtlasAllocator.AtlasNode> pool) { }

	// RVA: 0x85E6DF0 Offset: 0x85E2DF0 VA: 0x85E6DF0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AtlasAllocator.<>c // TypeDefIndex: 20061
{
	// Fields
	public static readonly AtlasAllocator.<>c <>9; // 0x0
	public static UnityAction<AtlasAllocator.AtlasNode> <>9__6_0; // 0x8
	public static UnityAction<AtlasAllocator.AtlasNode> <>9__6_1; // 0x10

	// Methods

	// RVA: 0x85E71C0 Offset: 0x85E31C0 VA: 0x85E71C0
	private static void .cctor() { }

	// RVA: 0x85E7228 Offset: 0x85E3228 VA: 0x85E7228
	public void .ctor() { }

	// RVA: 0x85E7230 Offset: 0x85E3230 VA: 0x85E7230
	internal void <.ctor>b__6_0(AtlasAllocator.AtlasNode _) { }

	// RVA: 0x85E7234 Offset: 0x85E3234 VA: 0x85E7234
	internal void <.ctor>b__6_1(AtlasAllocator.AtlasNode _) { }
}

// Namespace: UnityEngine.Rendering
internal class AtlasAllocator // TypeDefIndex: 20062
{
	// Fields
	private AtlasAllocator.AtlasNode m_Root; // 0x10
	private int m_Width; // 0x18
	private int m_Height; // 0x1C
	private bool powerOfTwoPadding; // 0x20
	private ObjectPool<AtlasAllocator.AtlasNode> m_NodePool; // 0x28

	// Methods

	// RVA: 0x85E6BB8 Offset: 0x85E2BB8 VA: 0x85E6BB8
	public void .ctor(int width, int height, bool potPadding) { }

	// RVA: 0x85E6DFC Offset: 0x85E2DFC VA: 0x85E6DFC
	public bool Allocate(ref Vector4 result, int width, int height) { }

	// RVA: 0x85E7090 Offset: 0x85E3090 VA: 0x85E7090
	public void Reset() { }
}

// Namespace: 
private enum Texture2DAtlas.BlitType // TypeDefIndex: 20063
{
	// Fields
	public int value__; // 0x0
	public const Texture2DAtlas.BlitType Default = 0;
	public const Texture2DAtlas.BlitType CubeTo2DOctahedral = 1;
	public const Texture2DAtlas.BlitType SingleChannel = 2;
	public const Texture2DAtlas.BlitType CubeTo2DOctahedralSingleChannel = 3;
}

// Namespace: UnityEngine.Rendering
public class Texture2DAtlas // TypeDefIndex: 20064
{
	// Fields
	internal const int kGPUTexInvalid = 0;
	internal const int kGPUTexValidMip0 = 1;
	internal const int kGPUTexValidMipAll = 2;
	internal RTHandle m_AtlasTexture; // 0x10
	internal int m_Width; // 0x18
	internal int m_Height; // 0x1C
	internal GraphicsFormat m_Format; // 0x20
	internal bool m_UseMipMaps; // 0x24
	private bool m_IsAtlasTextureOwner; // 0x25
	private AtlasAllocator m_AtlasAllocator; // 0x28
	[TupleElementNames(new[] { "scaleOffset", "size" })]
	private Dictionary<int, ValueTuple<Vector4, Vector2Int>> m_AllocationCache; // 0x30
	private Dictionary<int, int> m_IsGPUTextureUpToDate; // 0x38
	private Dictionary<int, int> m_TextureHashes; // 0x40
	private static readonly Vector4 fullScaleOffset; // 0x0
	private static readonly int s_MaxMipLevelPadding; // 0x10

	// Properties
	public static int maxMipLevelPadding { get; }
	public RTHandle AtlasTexture { get; }

	// Methods

	// RVA: 0x85E7238 Offset: 0x85E3238 VA: 0x85E7238
	public static int get_maxMipLevelPadding() { }

	// RVA: 0x85E7290 Offset: 0x85E3290 VA: 0x85E7290
	public RTHandle get_AtlasTexture() { }

	// RVA: 0x85E7298 Offset: 0x85E3298 VA: 0x85E7298
	public void .ctor(int width, int height, GraphicsFormat format, FilterMode filterMode = 0, bool powerOfTwoPadding = False, string name = "", bool useMipMap = True) { }

	// RVA: 0x85E7620 Offset: 0x85E3620 VA: 0x85E7620
	public void Release() { }

	// RVA: 0x85E7698 Offset: 0x85E3698 VA: 0x85E7698
	public void ResetAllocator() { }

	// RVA: 0x85E7718 Offset: 0x85E3718 VA: 0x85E7718
	public void ClearTarget(CommandBuffer cmd) { }

	// RVA: 0x85E754C Offset: 0x85E354C VA: 0x85E754C
	internal int GetTextureMipmapCount(int width, int height) { }

	// RVA: 0x85E7A94 Offset: 0x85E3A94 VA: 0x85E7A94
	internal bool Is2D(Texture texture) { }

	// RVA: 0x85E7B60 Offset: 0x85E3B60 VA: 0x85E7B60
	internal bool IsSingleChannelBlit(Texture source, Texture destination) { }

	// RVA: 0x85E7DA4 Offset: 0x85E3DA4 VA: 0x85E7DA4
	private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, Texture2DAtlas.BlitType blitType) { }

	// RVA: 0x85E86B0 Offset: 0x85E46B0 VA: 0x85E86B0
	internal void MarkGPUTextureValid(int instanceId, bool mipAreValid = False) { }

	// RVA: 0x85E8720 Offset: 0x85E4720 VA: 0x85E8720
	internal void MarkGPUTextureInvalid(int instanceId) { }

	// RVA: 0x85E877C Offset: 0x85E477C VA: 0x85E877C Slot: 4
	public virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x85E8AA4 Offset: 0x85E4AA4 VA: 0x85E8AA4 Slot: 5
	public virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x85E8AB4 Offset: 0x85E4AB4 VA: 0x85E8AB4 Slot: 6
	public virtual void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = True, int overrideInstanceID = -1) { }

	// RVA: 0x85E8C34 Offset: 0x85E4C34 VA: 0x85E8C34 Slot: 7
	public virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1) { }

	// RVA: 0x85E8E04 Offset: 0x85E4E04 VA: 0x85E8E04
	public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset) { }

	// RVA: 0x85E8E60 Offset: 0x85E4E60 VA: 0x85E8E60 Slot: 8
	public virtual bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset) { }

	// RVA: 0x85E8FE8 Offset: 0x85E4FE8 VA: 0x85E8FE8
	internal int GetTextureHash(Texture textureA, Texture textureB) { }

	// RVA: 0x85E8918 Offset: 0x85E4918 VA: 0x85E8918
	public int GetTextureID(Texture texture) { }

	// RVA: 0x85E9060 Offset: 0x85E5060 VA: 0x85E9060
	public int GetTextureID(Texture textureA, Texture textureB) { }

	// RVA: 0x85E90A8 Offset: 0x85E50A8 VA: 0x85E90A8
	public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB) { }

	// RVA: 0x85E9164 Offset: 0x85E5164 VA: 0x85E9164
	public bool IsCached(out Vector4 scaleOffset, Texture texture) { }

	// RVA: 0x85E90DC Offset: 0x85E50DC VA: 0x85E90DC
	public bool IsCached(out Vector4 scaleOffset, int id) { }

	// RVA: 0x85E91A0 Offset: 0x85E51A0 VA: 0x85E91A0
	internal Vector2Int GetCachedTextureSize(int id) { }

	// RVA: 0x85E9214 Offset: 0x85E5214 VA: 0x85E9214 Slot: 9
	public virtual bool NeedsUpdate(Texture texture, bool needMips = False) { }

	// RVA: 0x85E9488 Offset: 0x85E5488 VA: 0x85E9488 Slot: 10
	public virtual bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = False) { }

	// RVA: 0x85E9894 Offset: 0x85E5894 VA: 0x85E9894 Slot: 11
	public virtual bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture) { }

	// RVA: 0x85E9934 Offset: 0x85E5934 VA: 0x85E9934 Slot: 12
	public virtual bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = True, bool blitMips = True) { }

	// RVA: 0x85E9AB0 Offset: 0x85E5AB0 VA: 0x85E9AB0 Slot: 13
	public virtual bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = True, bool blitMips = True) { }

	// RVA: 0x85E9B60 Offset: 0x85E5B60 VA: 0x85E9B60
	internal bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height) { }

	// RVA: 0x85E9CD0 Offset: 0x85E5CD0 VA: 0x85E9CD0
	private static void .cctor() { }
}

// Namespace: 
private class AtlasAllocatorDynamic.AtlasNodePool // TypeDefIndex: 20065
{
	// Fields
	internal AtlasAllocatorDynamic.AtlasNode[] m_Nodes; // 0x10
	private short m_Next; // 0x18
	private short m_FreelistHead; // 0x1A

	// Methods

	// RVA: 0x85E9E6C Offset: 0x85E5E6C VA: 0x85E9E6C
	public void .ctor(short capacity) { }

	// RVA: 0x85EACAC Offset: 0x85E6CAC VA: 0x85EACAC
	public void Dispose() { }

	// RVA: 0x85EA758 Offset: 0x85E6758 VA: 0x85EA758
	public void Clear() { }

	// RVA: 0x85E9EE8 Offset: 0x85E5EE8 VA: 0x85E9EE8
	public short AtlasNodeCreate(short parent) { }

	// RVA: 0x85EAD20 Offset: 0x85E6D20 VA: 0x85EAD20
	public void AtlasNodeFree(short index) { }
}

// Namespace: 
private enum AtlasAllocatorDynamic.AtlasNode.AtlasNodeFlags // TypeDefIndex: 20066
{
	// Fields
	public uint value__; // 0x0
	public const AtlasAllocatorDynamic.AtlasNode.AtlasNodeFlags IsOccupied = 1;
}

// Namespace: 
private struct AtlasAllocatorDynamic.AtlasNode // TypeDefIndex: 20067
{
	// Fields
	public short m_Self; // 0x0
	public short m_Parent; // 0x2
	public short m_LeftChild; // 0x4
	public short m_RightChild; // 0x6
	public short m_FreelistNext; // 0x8
	public ushort m_Flags; // 0xA
	public Vector4 m_Rect; // 0x10

	// Methods

	// RVA: 0x85EACC0 Offset: 0x85E6CC0 VA: 0x85EACC0
	public void .ctor(short self, short parent) { }

	// RVA: 0x85EACA0 Offset: 0x85E6CA0 VA: 0x85EACA0
	public bool IsOccupied() { }

	// RVA: 0x85EAD5C Offset: 0x85E6D5C VA: 0x85EAD5C
	public void SetIsOccupied() { }

	// RVA: 0x85EAD6C Offset: 0x85E6D6C VA: 0x85EAD6C
	public void ClearIsOccupied() { }

	// RVA: 0x85EAD7C Offset: 0x85E6D7C VA: 0x85EAD7C
	public bool IsLeafNode() { }

	// RVA: 0x85EA158 Offset: 0x85E6158 VA: 0x85EA158
	public short Allocate(AtlasAllocatorDynamic.AtlasNodePool pool, int width, int height) { }

	// RVA: 0x85EAD8C Offset: 0x85E6D8C VA: 0x85EAD8C
	public void ReleaseChildren(AtlasAllocatorDynamic.AtlasNodePool pool) { }

	// RVA: 0x85EA5F4 Offset: 0x85E65F4 VA: 0x85EA5F4
	public void ReleaseAndMerge(AtlasAllocatorDynamic.AtlasNodePool pool) { }

	// RVA: 0x85EAE34 Offset: 0x85E6E34 VA: 0x85EAE34
	public bool IsMergeNeeded(AtlasAllocatorDynamic.AtlasNodePool pool) { }
}

// Namespace: UnityEngine.Rendering
internal class AtlasAllocatorDynamic // TypeDefIndex: 20068
{
	// Fields
	private int m_Width; // 0x10
	private int m_Height; // 0x14
	private AtlasAllocatorDynamic.AtlasNodePool m_Pool; // 0x18
	private short m_Root; // 0x20
	private Dictionary<int, short> m_NodeFromID; // 0x28

	// Methods

	// RVA: 0x85E9D30 Offset: 0x85E5D30 VA: 0x85E9D30
	public void .ctor(int width, int height, int capacityAllocations) { }

	// RVA: 0x85EA028 Offset: 0x85E6028 VA: 0x85EA028
	public bool Allocate(out Vector4 result, int key, int width, int height) { }

	// RVA: 0x85EA528 Offset: 0x85E6528 VA: 0x85EA528
	public void Release(int key) { }

	// RVA: 0x85EA6B4 Offset: 0x85E66B4 VA: 0x85EA6B4
	public void Release() { }

	// RVA: 0x85EA764 Offset: 0x85E6764 VA: 0x85EA764
	public string DebugStringFromRoot(int depthMax = -1) { }

	// RVA: 0x85EA7D4 Offset: 0x85E67D4 VA: 0x85EA7D4
	private void DebugStringFromNode(ref string res, short n, int depthCurrent = 0, int depthMax = -1) { }
}

// Namespace: UnityEngine.Rendering
internal class Texture2DAtlasDynamic // TypeDefIndex: 20069
{
	// Fields
	private RTHandle m_AtlasTexture; // 0x10
	private bool isAtlasTextureOwner; // 0x18
	private int m_Width; // 0x1C
	private int m_Height; // 0x20
	private GraphicsFormat m_Format; // 0x24
	private AtlasAllocatorDynamic m_AtlasAllocator; // 0x28
	private Dictionary<int, Vector4> m_AllocationCache; // 0x30

	// Properties
	public RTHandle AtlasTexture { get; }

	// Methods

	// RVA: 0x85EAEB4 Offset: 0x85E6EB4 VA: 0x85EAEB4
	public RTHandle get_AtlasTexture() { }

	// RVA: 0x85EAEBC Offset: 0x85E6EBC VA: 0x85EAEBC
	public void .ctor(int width, int height, int capacity, GraphicsFormat format) { }

	// RVA: 0x85EB068 Offset: 0x85E7068 VA: 0x85EB068
	public void .ctor(int width, int height, int capacity, RTHandle atlasTexture) { }

	// RVA: 0x85EB188 Offset: 0x85E7188 VA: 0x85EB188
	public void Release() { }

	// RVA: 0x85EB200 Offset: 0x85E7200 VA: 0x85EB200
	public void ResetAllocator() { }

	// RVA: 0x85EB25C Offset: 0x85E725C VA: 0x85EB25C
	public bool AddTexture(CommandBuffer cmd, out Vector4 scaleOffset, Texture texture) { }

	// RVA: 0x85EB4B4 Offset: 0x85E74B4 VA: 0x85EB4B4
	public bool IsCached(out Vector4 scaleOffset, int key) { }

	// RVA: 0x85EB51C Offset: 0x85E751C VA: 0x85EB51C
	public bool EnsureTextureSlot(out bool isUploadNeeded, out Vector4 scaleOffset, int key, int width, int height) { }

	// RVA: 0x85EB62C Offset: 0x85E762C VA: 0x85EB62C
	public void ReleaseTextureSlot(int key) { }
}

// Namespace: UnityEngine.Rendering
public static class TextureXR // TypeDefIndex: 20070
{
	// Fields
	private static int m_MaxViews; // 0x0
	private static Texture m_BlackUIntTexture2DArray; // 0x8
	private static Texture m_BlackUIntTexture; // 0x10
	private static RTHandle m_BlackUIntTexture2DArrayRTH; // 0x18
	private static RTHandle m_BlackUIntTextureRTH; // 0x20
	private static Texture2DArray m_ClearTexture2DArray; // 0x28
	private static Texture2D m_ClearTexture; // 0x30
	private static RTHandle m_ClearTexture2DArrayRTH; // 0x38
	private static RTHandle m_ClearTextureRTH; // 0x40
	private static Texture2DArray m_MagentaTexture2DArray; // 0x48
	private static Texture2D m_MagentaTexture; // 0x50
	private static RTHandle m_MagentaTexture2DArrayRTH; // 0x58
	private static RTHandle m_MagentaTextureRTH; // 0x60
	private static Texture2D m_BlackTexture; // 0x68
	private static Texture3D m_BlackTexture3D; // 0x70
	private static Texture2DArray m_BlackTexture2DArray; // 0x78
	private static RTHandle m_BlackTexture2DArrayRTH; // 0x80
	private static RTHandle m_BlackTextureRTH; // 0x88
	private static RTHandle m_BlackTexture3DRTH; // 0x90
	private static Texture2DArray m_WhiteTexture2DArray; // 0x98
	private static RTHandle m_WhiteTexture2DArrayRTH; // 0xA0
	private static RTHandle m_WhiteTextureRTH; // 0xA8

	// Properties
	public static int maxViews { set; }
	public static int slices { get; }
	public static bool useTexArray { get; }
	public static TextureDimension dimension { get; }

	// Methods

	// RVA: 0x85EB694 Offset: 0x85E7694 VA: 0x85EB694
	public static void set_maxViews(int value) { }

	// RVA: 0x85EB6F0 Offset: 0x85E76F0 VA: 0x85EB6F0
	public static int get_slices() { }

	// RVA: 0x85EB748 Offset: 0x85E7748 VA: 0x85EB748
	public static bool get_useTexArray() { }

	// RVA: 0x85EB7B0 Offset: 0x85E77B0 VA: 0x85EB7B0
	public static TextureDimension get_dimension() { }

	// RVA: 0x85EB810 Offset: 0x85E7810 VA: 0x85EB810
	public static RTHandle GetBlackUIntTexture() { }

	// RVA: 0x85EB894 Offset: 0x85E7894 VA: 0x85EB894
	public static RTHandle GetClearTexture() { }

	// RVA: 0x85EB918 Offset: 0x85E7918 VA: 0x85EB918
	public static RTHandle GetMagentaTexture() { }

	// RVA: 0x85EB99C Offset: 0x85E799C VA: 0x85EB99C
	public static RTHandle GetBlackTexture() { }

	// RVA: 0x85EBA20 Offset: 0x85E7A20 VA: 0x85EBA20
	public static RTHandle GetBlackTextureArray() { }

	// RVA: 0x85EBA78 Offset: 0x85E7A78 VA: 0x85EBA78
	public static RTHandle GetBlackTexture3D() { }

	// RVA: 0x85EBAD0 Offset: 0x85E7AD0 VA: 0x85EBAD0
	public static RTHandle GetWhiteTexture() { }

	// RVA: 0x85EBB54 Offset: 0x85E7B54 VA: 0x85EBB54
	public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	// RVA: 0x85EC694 Offset: 0x85E8694 VA: 0x85EC694
	private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name) { }

	// RVA: 0x85EC284 Offset: 0x85E8284 VA: 0x85EC284
	private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	// RVA: 0x85EC4D8 Offset: 0x85E84D8 VA: 0x85EC4D8
	private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	// RVA: 0x85EC874 Offset: 0x85E8874 VA: 0x85EC874
	private static Texture3D CreateBlackTexture3D(string name) { }

	// RVA: 0x85EC934 Offset: 0x85E8934 VA: 0x85EC934
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[Extension]
public static class ArrayExtensions // TypeDefIndex: 20071
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void ResizeArray<T>(ref NativeArray<T> array, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F8A20 Offset: 0x44F4A20 VA: 0x44F8A20
	|-ArrayExtensions.ResizeArray<uint>
	|
	|-RVA: 0x44F8AB0 Offset: 0x44F4AB0 VA: 0x44F8AB0
	|-ArrayExtensions.ResizeArray<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: 0x85EC980 Offset: 0x85E8980 VA: 0x85EC980
	public static void ResizeArray(ref TransformAccessArray array, int capacity) { }

	// RVA: -1 Offset: -1
	public static void ResizeArray<T>(ref T[] array, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F8930 Offset: 0x44F4930 VA: 0x44F8930
	|-ArrayExtensions.ResizeArray<int>
	|
	|-RVA: 0x44F89A8 Offset: 0x44F49A8 VA: 0x44F89A8
	|-ArrayExtensions.ResizeArray<object>
	|
	|-RVA: 0x44F8B90 Offset: 0x44F4B90 VA: 0x44F8B90
	|-ArrayExtensions.ResizeArray<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.Rendering
[Serializable]
public struct SHCoefficients : IEquatable<SHCoefficients> // TypeDefIndex: 20072
{
	// Fields
	public Vector4 SHAr; // 0x0
	public Vector4 SHAg; // 0x10
	public Vector4 SHAb; // 0x20
	public Vector4 SHBr; // 0x30
	public Vector4 SHBg; // 0x40
	public Vector4 SHBb; // 0x50
	public Vector4 SHC; // 0x60
	public Vector4 ProbesOcclusion; // 0x70

	// Methods

	// RVA: 0x85ECA20 Offset: 0x85E8A20 VA: 0x85ECA20
	public void .ctor(SphericalHarmonicsL2 sh) { }

	// RVA: 0x85ECD1C Offset: 0x85E8D1C VA: 0x85ECD1C
	public void .ctor(SphericalHarmonicsL2 sh, Vector4 probesOcclusion) { }

	// RVA: 0x85ECB78 Offset: 0x85E8B78 VA: 0x85ECB78
	private static Vector4 GetSHA(SphericalHarmonicsL2 sh, int i) { }

	// RVA: 0x85ECC20 Offset: 0x85E8C20 VA: 0x85ECC20
	private static Vector4 GetSHB(SphericalHarmonicsL2 sh, int i) { }

	// RVA: 0x85ECCB4 Offset: 0x85E8CB4 VA: 0x85ECCB4
	private static Vector4 GetSHC(SphericalHarmonicsL2 sh) { }

	// RVA: 0x85ECD74 Offset: 0x85E8D74 VA: 0x85ECD74 Slot: 4
	public bool Equals(SHCoefficients other) { }

	// RVA: 0x85ECF80 Offset: 0x85E8F80 VA: 0x85ECF80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x85ED010 Offset: 0x85E9010 VA: 0x85ED010 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x85ED184 Offset: 0x85E9184 VA: 0x85ED184
	public static bool op_Equality(SHCoefficients left, SHCoefficients right) { }

	// RVA: 0x85ED1B8 Offset: 0x85E91B8 VA: 0x85ED1B8
	public static bool op_Inequality(SHCoefficients left, SHCoefficients right) { }
}

// Namespace: UnityEngine.Rendering
[Obsolete("BatchRendererGroupGlobals and associated cbuffer are now set automatically by Unity. Setting it manually is no longer necessary or supported.")]
[Serializable]
public struct BatchRendererGroupGlobals : IEquatable<BatchRendererGroupGlobals> // TypeDefIndex: 20073
{
	// Fields
	public const string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues";
	public static readonly int kGlobalsPropertyId; // 0x0
	public Vector4 ProbesOcclusion; // 0x0
	public Vector4 SpecCube0_HDR; // 0x10
	public Vector4 SpecCube1_HDR; // 0x20
	public SHCoefficients SHCoefficients; // 0x30

	// Properties
	public static BatchRendererGroupGlobals Default { get; }

	// Methods

	// RVA: 0x85ED1F0 Offset: 0x85E91F0 VA: 0x85ED1F0
	public static BatchRendererGroupGlobals get_Default() { }

	// RVA: 0x85ED314 Offset: 0x85E9314 VA: 0x85ED314 Slot: 4
	public bool Equals(BatchRendererGroupGlobals other) { }

	// RVA: 0x85ED42C Offset: 0x85E942C VA: 0x85ED42C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x85ED4E4 Offset: 0x85E94E4 VA: 0x85ED4E4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x85ED5F8 Offset: 0x85E95F8 VA: 0x85ED5F8
	public static bool op_Equality(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right) { }

	// RVA: 0x85ED68C Offset: 0x85E968C VA: 0x85ED68C
	public static bool op_Inequality(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right) { }

	// RVA: 0x85ED724 Offset: 0x85E9724 VA: 0x85ED724
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[DefaultMember("Item")]
public interface IBitArray // TypeDefIndex: 20074
{
	// Properties
	public abstract uint capacity { get; }
	public abstract bool allFalse { get; }
	public abstract bool allTrue { get; }
	public abstract bool Item { get; set; }
	public abstract string humanizedData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract uint get_capacity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_allFalse();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_allTrue();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_Item(uint index);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_Item(uint index, bool value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_humanizedData();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IBitArray BitAnd(IBitArray other);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IBitArray BitOr(IBitArray other);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IBitArray BitNot();
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Serializable]
public struct BitArray8 : IBitArray // TypeDefIndex: 20075
{
	// Fields
	[SerializeField]
	private byte data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x85ED78C Offset: 0x85E978C VA: 0x85ED78C Slot: 4
	public uint get_capacity() { }

	// RVA: 0x85ED794 Offset: 0x85E9794 VA: 0x85ED794 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x85ED7A4 Offset: 0x85E97A4 VA: 0x85ED7A4 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x85ED7B4 Offset: 0x85E97B4 VA: 0x85ED7B4 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x85ED8AC Offset: 0x85E98AC VA: 0x85ED8AC Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x85ED8CC Offset: 0x85E98CC VA: 0x85ED8CC Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x85ED914 Offset: 0x85E9914 VA: 0x85ED914
	public void .ctor(byte initValue) { }

	// RVA: 0x85ED91C Offset: 0x85E991C VA: 0x85ED91C
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x85ED9CC Offset: 0x85E99CC VA: 0x85ED9CC
	public static BitArray8 op_OnesComplement(BitArray8 a) { }

	// RVA: 0x85ED9D8 Offset: 0x85E99D8 VA: 0x85ED9D8
	public static BitArray8 op_BitwiseOr(BitArray8 a, BitArray8 b) { }

	// RVA: 0x85ED9E4 Offset: 0x85E99E4 VA: 0x85ED9E4
	public static BitArray8 op_BitwiseAnd(BitArray8 a, BitArray8 b) { }

	// RVA: 0x85ED9F0 Offset: 0x85E99F0 VA: 0x85ED9F0 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x85EDA88 Offset: 0x85E9A88 VA: 0x85EDA88 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x85EDB20 Offset: 0x85E9B20 VA: 0x85EDB20 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x85EDB80 Offset: 0x85E9B80 VA: 0x85EDB80
	public static bool op_Equality(BitArray8 a, BitArray8 b) { }

	// RVA: 0x85EDB90 Offset: 0x85E9B90 VA: 0x85EDB90
	public static bool op_Inequality(BitArray8 a, BitArray8 b) { }

	// RVA: 0x85EDBA0 Offset: 0x85E9BA0 VA: 0x85EDBA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x85EDC18 Offset: 0x85E9C18 VA: 0x85EDC18 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Serializable]
public struct BitArray16 : IBitArray // TypeDefIndex: 20076
{
	// Fields
	[SerializeField]
	private ushort data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x85EDC38 Offset: 0x85E9C38 VA: 0x85EDC38 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x85EDC40 Offset: 0x85E9C40 VA: 0x85EDC40 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x85EDC50 Offset: 0x85E9C50 VA: 0x85EDC50 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x85EDC60 Offset: 0x85E9C60 VA: 0x85EDC60 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x85EDDD0 Offset: 0x85E9DD0 VA: 0x85EDDD0 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x85EDDF0 Offset: 0x85E9DF0 VA: 0x85EDDF0 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x85EDE38 Offset: 0x85E9E38 VA: 0x85EDE38
	public void .ctor(ushort initValue) { }

	// RVA: 0x85EDE40 Offset: 0x85E9E40 VA: 0x85EDE40
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x85EDEF0 Offset: 0x85E9EF0 VA: 0x85EDEF0
	public static BitArray16 op_OnesComplement(BitArray16 a) { }

	// RVA: 0x85EDEFC Offset: 0x85E9EFC VA: 0x85EDEFC
	public static BitArray16 op_BitwiseOr(BitArray16 a, BitArray16 b) { }

	// RVA: 0x85EDF08 Offset: 0x85E9F08 VA: 0x85EDF08
	public static BitArray16 op_BitwiseAnd(BitArray16 a, BitArray16 b) { }

	// RVA: 0x85EDF14 Offset: 0x85E9F14 VA: 0x85EDF14 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x85EDFAC Offset: 0x85E9FAC VA: 0x85EDFAC Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x85EE044 Offset: 0x85EA044 VA: 0x85EE044 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x85EE0A4 Offset: 0x85EA0A4 VA: 0x85EE0A4
	public static bool op_Equality(BitArray16 a, BitArray16 b) { }

	// RVA: 0x85EE0B4 Offset: 0x85EA0B4 VA: 0x85EE0B4
	public static bool op_Inequality(BitArray16 a, BitArray16 b) { }

	// RVA: 0x85EE0C4 Offset: 0x85EA0C4 VA: 0x85EE0C4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x85EE13C Offset: 0x85EA13C VA: 0x85EE13C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Serializable]
public struct BitArray32 : IBitArray // TypeDefIndex: 20077
{
	// Fields
	[SerializeField]
	private uint data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	private string humanizedVersion { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x85EE15C Offset: 0x85EA15C VA: 0x85EE15C Slot: 4
	public uint get_capacity() { }

	// RVA: 0x85EE164 Offset: 0x85EA164 VA: 0x85EE164 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x85EE174 Offset: 0x85EA174 VA: 0x85EE174 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x85EE184 Offset: 0x85EA184 VA: 0x85EE184
	private string get_humanizedVersion() { }

	// RVA: 0x85EE1E4 Offset: 0x85EA1E4 VA: 0x85EE1E4 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x85EE354 Offset: 0x85EA354 VA: 0x85EE354 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x85EE370 Offset: 0x85EA370 VA: 0x85EE370 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x85EE3B8 Offset: 0x85EA3B8 VA: 0x85EE3B8
	public void .ctor(uint initValue) { }

	// RVA: 0x85EE3C0 Offset: 0x85EA3C0 VA: 0x85EE3C0
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x85EE470 Offset: 0x85EA470 VA: 0x85EE470 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x85EE510 Offset: 0x85EA510 VA: 0x85EE510 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x85EE5B0 Offset: 0x85EA5B0 VA: 0x85EE5B0 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x85EE610 Offset: 0x85EA610 VA: 0x85EE610
	public static BitArray32 op_OnesComplement(BitArray32 a) { }

	// RVA: 0x85EE5A8 Offset: 0x85EA5A8 VA: 0x85EE5A8
	public static BitArray32 op_BitwiseOr(BitArray32 a, BitArray32 b) { }

	// RVA: 0x85EE508 Offset: 0x85EA508 VA: 0x85EE508
	public static BitArray32 op_BitwiseAnd(BitArray32 a, BitArray32 b) { }

	// RVA: 0x85EE618 Offset: 0x85EA618 VA: 0x85EE618
	public static bool op_Equality(BitArray32 a, BitArray32 b) { }

	// RVA: 0x85EE624 Offset: 0x85EA624 VA: 0x85EE624
	public static bool op_Inequality(BitArray32 a, BitArray32 b) { }

	// RVA: 0x85EE630 Offset: 0x85EA630 VA: 0x85EE630 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x85EE6A8 Offset: 0x85EA6A8 VA: 0x85EE6A8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Serializable]
public struct BitArray64 : IBitArray // TypeDefIndex: 20078
{
	// Fields
	[SerializeField]
	private ulong data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x85EE6C8 Offset: 0x85EA6C8 VA: 0x85EE6C8 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x85EE6D0 Offset: 0x85EA6D0 VA: 0x85EE6D0 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x85EE6E0 Offset: 0x85EA6E0 VA: 0x85EE6E0 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x85EE6F0 Offset: 0x85EA6F0 VA: 0x85EE6F0 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x85EE860 Offset: 0x85EA860 VA: 0x85EE860 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x85EE87C Offset: 0x85EA87C VA: 0x85EE87C Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x85EE8C4 Offset: 0x85EA8C4 VA: 0x85EE8C4
	public void .ctor(ulong initValue) { }

	// RVA: 0x85EE8CC Offset: 0x85EA8CC VA: 0x85EE8CC
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x85EE97C Offset: 0x85EA97C VA: 0x85EE97C
	public static BitArray64 op_OnesComplement(BitArray64 a) { }

	// RVA: 0x85EE984 Offset: 0x85EA984 VA: 0x85EE984
	public static BitArray64 op_BitwiseOr(BitArray64 a, BitArray64 b) { }

	// RVA: 0x85EE98C Offset: 0x85EA98C VA: 0x85EE98C
	public static BitArray64 op_BitwiseAnd(BitArray64 a, BitArray64 b) { }

	// RVA: 0x85EE994 Offset: 0x85EA994 VA: 0x85EE994 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x85EEA2C Offset: 0x85EAA2C VA: 0x85EEA2C Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x85EEAC4 Offset: 0x85EAAC4 VA: 0x85EEAC4 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x85EEB24 Offset: 0x85EAB24 VA: 0x85EEB24
	public static bool op_Equality(BitArray64 a, BitArray64 b) { }

	// RVA: 0x85EEB30 Offset: 0x85EAB30 VA: 0x85EEB30
	public static bool op_Inequality(BitArray64 a, BitArray64 b) { }

	// RVA: 0x85EEB3C Offset: 0x85EAB3C VA: 0x85EEB3C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x85EEBB4 Offset: 0x85EABB4 VA: 0x85EEBB4 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Serializable]
public struct BitArray128 : IBitArray // TypeDefIndex: 20079
{
	// Fields
	[SerializeField]
	private ulong data1; // 0x0
	[SerializeField]
	private ulong data2; // 0x8

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x85EEBD4 Offset: 0x85EABD4 VA: 0x85EEBD4 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x85EEBDC Offset: 0x85EABDC VA: 0x85EEBDC Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x85EEBFC Offset: 0x85EABFC VA: 0x85EEBFC Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x85EEC20 Offset: 0x85EAC20 VA: 0x85EEC20 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x85EEE1C Offset: 0x85EAE1C VA: 0x85EEE1C Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x85EEE50 Offset: 0x85EAE50 VA: 0x85EEE50 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x85EEEC0 Offset: 0x85EAEC0 VA: 0x85EEEC0
	public void .ctor(ulong initValue1, ulong initValue2) { }

	// RVA: 0x85EEEC8 Offset: 0x85EAEC8 VA: 0x85EEEC8
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x85EEFA0 Offset: 0x85EAFA0 VA: 0x85EEFA0
	public static BitArray128 op_OnesComplement(BitArray128 a) { }

	// RVA: 0x85EEFAC Offset: 0x85EAFAC VA: 0x85EEFAC
	public static BitArray128 op_BitwiseOr(BitArray128 a, BitArray128 b) { }

	// RVA: 0x85EEFB8 Offset: 0x85EAFB8 VA: 0x85EEFB8
	public static BitArray128 op_BitwiseAnd(BitArray128 a, BitArray128 b) { }

	// RVA: 0x85EEFC4 Offset: 0x85EAFC4 VA: 0x85EEFC4 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x85EF068 Offset: 0x85EB068 VA: 0x85EF068 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x85EF10C Offset: 0x85EB10C VA: 0x85EF10C Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x85EF16C Offset: 0x85EB16C VA: 0x85EF16C
	public static bool op_Equality(BitArray128 a, BitArray128 b) { }

	// RVA: 0x85EF184 Offset: 0x85EB184 VA: 0x85EF184
	public static bool op_Inequality(BitArray128 a, BitArray128 b) { }

	// RVA: 0x85EF19C Offset: 0x85EB19C VA: 0x85EF19C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x85EF258 Offset: 0x85EB258 VA: 0x85EF258 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DefaultMember("Item")]
[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[Serializable]
public struct BitArray256 : IBitArray // TypeDefIndex: 20080
{
	// Fields
	[SerializeField]
	private ulong data1; // 0x0
	[SerializeField]
	private ulong data2; // 0x8
	[SerializeField]
	private ulong data3; // 0x10
	[SerializeField]
	private ulong data4; // 0x18

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x85EF2A0 Offset: 0x85EB2A0 VA: 0x85EF2A0 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x85EF2A8 Offset: 0x85EB2A8 VA: 0x85EF2A8 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x85EF2D8 Offset: 0x85EB2D8 VA: 0x85EF2D8 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x85EF314 Offset: 0x85EB314 VA: 0x85EF314 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x85EF614 Offset: 0x85EB614 VA: 0x85EF614 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x85EF698 Offset: 0x85EB698 VA: 0x85EF698 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x85EF764 Offset: 0x85EB764 VA: 0x85EF764
	public void .ctor(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4) { }

	// RVA: 0x85EF770 Offset: 0x85EB770 VA: 0x85EF770
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x85EF884 Offset: 0x85EB884 VA: 0x85EF884
	public static BitArray256 op_OnesComplement(BitArray256 a) { }

	// RVA: 0x85EF898 Offset: 0x85EB898 VA: 0x85EF898
	public static BitArray256 op_BitwiseOr(BitArray256 a, BitArray256 b) { }

	// RVA: 0x85EF8B0 Offset: 0x85EB8B0 VA: 0x85EF8B0
	public static BitArray256 op_BitwiseAnd(BitArray256 a, BitArray256 b) { }

	// RVA: 0x85EF8C8 Offset: 0x85EB8C8 VA: 0x85EF8C8 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x85EF988 Offset: 0x85EB988 VA: 0x85EF988 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x85EFA48 Offset: 0x85EBA48 VA: 0x85EFA48 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x85EFAAC Offset: 0x85EBAAC VA: 0x85EFAAC
	public static bool op_Equality(BitArray256 a, BitArray256 b) { }

	// RVA: 0x85EFAF8 Offset: 0x85EBAF8 VA: 0x85EFAF8
	public static bool op_Inequality(BitArray256 a, BitArray256 b) { }

	// RVA: 0x85EFB44 Offset: 0x85EBB44 VA: 0x85EFB44 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x85EFC7C Offset: 0x85EBC7C VA: 0x85EFC7C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
public static class BitArrayUtilities // TypeDefIndex: 20081
{
	// Methods

	// RVA: 0x85ED8BC Offset: 0x85E98BC VA: 0x85ED8BC
	public static bool Get8(uint index, byte data) { }

	// RVA: 0x85EDDE0 Offset: 0x85E9DE0 VA: 0x85EDDE0
	public static bool Get16(uint index, ushort data) { }

	// RVA: 0x85EE364 Offset: 0x85EA364 VA: 0x85EE364
	public static bool Get32(uint index, uint data) { }

	// RVA: 0x85EE870 Offset: 0x85EA870 VA: 0x85EE870
	public static bool Get64(uint index, ulong data) { }

	// RVA: 0x85EEE3C Offset: 0x85EAE3C VA: 0x85EEE3C
	public static bool Get128(uint index, ulong data1, ulong data2) { }

	// RVA: 0x85EF65C Offset: 0x85EB65C VA: 0x85EF65C
	public static bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4) { }

	// RVA: 0x85ED8F0 Offset: 0x85E98F0 VA: 0x85ED8F0
	public static void Set8(uint index, ref byte data, bool value) { }

	// RVA: 0x85EDE14 Offset: 0x85E9E14 VA: 0x85EDE14
	public static void Set16(uint index, ref ushort data, bool value) { }

	// RVA: 0x85EE394 Offset: 0x85EA394 VA: 0x85EE394
	public static void Set32(uint index, ref uint data, bool value) { }

	// RVA: 0x85EE8A0 Offset: 0x85EA8A0 VA: 0x85EE8A0
	public static void Set64(uint index, ref ulong data, bool value) { }

	// RVA: 0x85EEE80 Offset: 0x85EAE80 VA: 0x85EEE80
	public static void Set128(uint index, ref ulong data1, ref ulong data2, bool value) { }

	// RVA: 0x85EF6BC Offset: 0x85EB6BC VA: 0x85EF6BC
	public static void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value) { }
}

// Namespace: 
private static class Blitter.BlitShaderIDs // TypeDefIndex: 20082
{
	// Fields
	public static readonly int _BlitTexture; // 0x0
	public static readonly int _BlitCubeTexture; // 0x4
	public static readonly int _BlitScaleBias; // 0x8
	public static readonly int _BlitScaleBiasRt; // 0xC
	public static readonly int _BlitMipLevel; // 0x10
	public static readonly int _BlitTextureSize; // 0x14
	public static readonly int _BlitPaddingSize; // 0x18
	public static readonly int _BlitDecodeInstructions; // 0x1C
	public static readonly int _InputDepth; // 0x20

	// Methods

	// RVA: 0x85F2DAC Offset: 0x85EEDAC VA: 0x85F2DAC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public static class Blitter // TypeDefIndex: 20083
{
	// Fields
	private static Material s_Blit; // 0x0
	private static Material s_BlitTexArray; // 0x8
	private static Material s_BlitTexArraySingleSlice; // 0x10
	private static Material s_BlitColorAndDepth; // 0x18
	private static MaterialPropertyBlock s_PropertyBlock; // 0x20
	private static Mesh s_TriangleMesh; // 0x28
	private static Mesh s_QuadMesh; // 0x30
	private static LocalKeyword s_DecodeHdrKeyword; // 0x38

	// Methods

	// RVA: 0x85EFCF8 Offset: 0x85EBCF8 VA: 0x85EFCF8
	public static void Initialize(Shader blitPS, Shader blitColorAndDepthPS) { }

	// RVA: 0x85F0638 Offset: 0x85EC638 VA: 0x85F0638
	public static void Cleanup() { }

	// RVA: 0x85F0814 Offset: 0x85EC814 VA: 0x85F0814
	public static Material GetBlitMaterial(TextureDimension dimension, bool singleSlice = False) { }

	// RVA: 0x85F0894 Offset: 0x85EC894 VA: 0x85F0894
	private static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass) { }

	// RVA: 0x85F0A44 Offset: 0x85ECA44 VA: 0x85F0A44
	internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass) { }

	// RVA: 0x85F0BF4 Offset: 0x85ECBF4 VA: 0x85F0BF4
	public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	// RVA: 0x85F0E80 Offset: 0x85ECE80 VA: 0x85F0E80
	public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	// RVA: 0x85F0FB0 Offset: 0x85ECFB0 VA: 0x85F0FB0
	public static void BlitColorAndDepth(CommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth) { }

	// RVA: 0x85F0D48 Offset: 0x85ECD48 VA: 0x85F0D48
	public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass) { }

	// RVA: 0x85F1194 Offset: 0x85ED194 VA: 0x85F1194
	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass) { }

	// RVA: 0x85F12F0 Offset: 0x85ED2F0 VA: 0x85F12F0
	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass) { }

	// RVA: 0x85F1488 Offset: 0x85ED488 VA: 0x85F1488
	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass) { }

	// RVA: 0x85F1638 Offset: 0x85ED638 VA: 0x85F1638
	public static void BlitTexture(CommandBuffer cmd, Vector4 scaleBias, Material material, int pass) { }

	// RVA: 0x85F1728 Offset: 0x85ED728 VA: 0x85F1728
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0, bool bilinear = False) { }

	// RVA: 0x85F1928 Offset: 0x85ED928 VA: 0x85F1928
	public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0, bool bilinear = False) { }

	// RVA: 0x85F1A84 Offset: 0x85EDA84 VA: 0x85F1A84
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass) { }

	// RVA: 0x85F1BD8 Offset: 0x85EDBD8 VA: 0x85F1BD8
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass) { }

	// RVA: 0x85F1E6C Offset: 0x85EDE6C VA: 0x85F1E6C
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0, bool bilinear = False) { }

	// RVA: 0x85F1F64 Offset: 0x85EDF64 VA: 0x85F1F64
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0, bool bilinear = False) { }

	// RVA: 0x85E78B8 Offset: 0x85E38B8 VA: 0x85E78B8
	public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear) { }

	// RVA: 0x85F2100 Offset: 0x85EE100 VA: 0x85F2100
	public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	// RVA: 0x85F237C Offset: 0x85EE37C VA: 0x85F237C
	public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	// RVA: 0x85F25F8 Offset: 0x85EE5F8 VA: 0x85F25F8
	public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	// RVA: 0x85F2810 Offset: 0x85EE810 VA: 0x85F2810
	public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	// RVA: 0x85E8018 Offset: 0x85E4018 VA: 0x85E8018
	public static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) { }

	// RVA: 0x85F2A28 Offset: 0x85EEA28 VA: 0x85F2A28
	public static void BlitCubeToOctahedral2DQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, Nullable<Vector4> decodeInstructions) { }

	// RVA: 0x85E8440 Offset: 0x85E4440 VA: 0x85E8440
	public static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) { }

	// RVA: 0x85E81B0 Offset: 0x85E41B0 VA: 0x85E81B0
	public static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex) { }

	// RVA: 0x85F2D38 Offset: 0x85EED38 VA: 0x85F2D38
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x85F0358 Offset: 0x85EC358 VA: 0x85F0358
	internal static Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|9_0(float z) { }

	[CompilerGenerated]
	// RVA: 0x85F040C Offset: 0x85EC40C VA: 0x85F040C
	internal static Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|9_1() { }

	[CompilerGenerated]
	// RVA: 0x85F04D4 Offset: 0x85EC4D4 VA: 0x85F04D4
	internal static Vector3[] <Initialize>g__GetQuadVertexPosition|9_2(float z) { }

	[CompilerGenerated]
	// RVA: 0x85F057C Offset: 0x85EC57C VA: 0x85F057C
	internal static Vector2[] <Initialize>g__GetQuadTexCoord|9_3() { }
}

// Namespace: UnityEngine.Rendering
public static class CameraCaptureBridge // TypeDefIndex: 20084
{
	// Fields
	private static Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>> actionDict; // 0x0
	private static bool _enabled; // 0x8

	// Properties
	public static bool enabled { get; set; }

	// Methods

	// RVA: 0x85F2F94 Offset: 0x85EEF94 VA: 0x85F2F94
	public static bool get_enabled() { }

	// RVA: 0x85F2FEC Offset: 0x85EEFEC VA: 0x85F2FEC
	public static void set_enabled(bool value) { }

	// RVA: 0x85F304C Offset: 0x85EF04C VA: 0x85F304C
	public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera) { }

	// RVA: 0x85F3158 Offset: 0x85EF158 VA: 0x85F3158
	public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }

	// RVA: 0x85F32A4 Offset: 0x85EF2A4 VA: 0x85F32A4
	public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }

	// RVA: 0x85F33A0 Offset: 0x85EF3A0 VA: 0x85F33A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
internal static class ColorSpaceUtils // TypeDefIndex: 20085
{
	// Fields
	public static readonly Matrix4x4 Rec709ToRec2020Mat; // 0x0
	public static readonly Matrix4x4 Rec709ToP3D65Mat; // 0x40
	public static readonly Matrix4x4 Rec2020ToRec709Mat; // 0x80
	public static readonly Matrix4x4 Rec2020ToP3D65Mat; // 0xC0
	public static readonly Matrix4x4 P3D65ToRec2020Mat; // 0x100

	// Methods

	// RVA: 0x85F3438 Offset: 0x85EF438 VA: 0x85F3438
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public static class ColorUtils // TypeDefIndex: 20086
{
	// Fields
	public static float s_LightMeterCalibrationConstant; // 0x0
	public static float s_LensAttenuation; // 0x4

	// Properties
	public static float lensImperfectionExposureScale { get; }

	// Methods

	// RVA: 0x85F3714 Offset: 0x85EF714 VA: 0x85F3714
	public static float get_lensImperfectionExposureScale() { }

	// RVA: 0x85F3784 Offset: 0x85EF784 VA: 0x85F3784
	public static float StandardIlluminantY(float x) { }

	// RVA: 0x85F37B0 Offset: 0x85EF7B0 VA: 0x85F37B0
	public static Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x85F3840 Offset: 0x85EF840 VA: 0x85F3840
	public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint) { }

	// RVA: 0x85F39A4 Offset: 0x85EF9A4 VA: 0x85F39A4
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights(in Vector4 inShadows, in Vector4 inMidtones, in Vector4 inHighlights) { }

	// RVA: 0x85F3BAC Offset: 0x85EFBAC VA: 0x85F3BAC
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain(in Vector4 inLift, in Vector4 inGamma, in Vector4 inGain) { }

	// RVA: 0x85F3E58 Offset: 0x85EFE58 VA: 0x85F3E58
	public static ValueTuple<Vector4, Vector4> PrepareSplitToning(in Vector4 inShadows, in Vector4 inHighlights, float balance) { }

	// RVA: 0x85F3E20 Offset: 0x85EFE20 VA: 0x85F3E20
	public static float Luminance(in Color color) { }

	// RVA: 0x85F3EE4 Offset: 0x85EFEE4 VA: 0x85F3EE4
	public static float ComputeEV100(float aperture, float shutterSpeed, float ISO) { }

	// RVA: 0x85F3F70 Offset: 0x85EFF70 VA: 0x85F3F70
	public static float ConvertEV100ToExposure(float EV100) { }

	// RVA: 0x85F3FE4 Offset: 0x85EFFE4 VA: 0x85F3FE4
	public static float ConvertExposureToEV100(float exposure) { }

	// RVA: 0x85F409C Offset: 0x85F009C VA: 0x85F409C
	public static float ComputeEV100FromAvgLuminance(float avgLuminance) { }

	// RVA: 0x85F415C Offset: 0x85F015C VA: 0x85F415C
	public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100) { }

	// RVA: 0x85F4198 Offset: 0x85F0198 VA: 0x85F4198
	public static uint ToHex(Color c) { }

	// RVA: 0x85F4200 Offset: 0x85F0200 VA: 0x85F4200
	public static Color ToRGBA(uint hex) { }

	// RVA: 0x85F423C Offset: 0x85F023C VA: 0x85F423C
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public static class CoreMatrixUtils // TypeDefIndex: 20087
{
	// Methods

	// RVA: 0x85F428C Offset: 0x85F028C VA: 0x85F428C
	public static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation) { }

	// RVA: 0x85F42E8 Offset: 0x85F02E8 VA: 0x85F42E8
	public static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation) { }

	// RVA: 0x85F4370 Offset: 0x85F0370 VA: 0x85F4370
	public static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs) { }

	// RVA: 0x85F4424 Offset: 0x85F0424 VA: 0x85F4424
	private static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs) { }

	// RVA: 0x85F44C8 Offset: 0x85F04C8 VA: 0x85F44C8
	private static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs) { }

	// RVA: 0x85F45B8 Offset: 0x85F05B8 VA: 0x85F45B8
	public static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered) { }

	// RVA: 0x85F46A0 Offset: 0x85F06A0 VA: 0x85F46A0
	public static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered) { }
}

// Namespace: 
public static class CoreUtils.Sections // TypeDefIndex: 20088
{
	// Fields
	public const int section1 = 10000;
	public const int section2 = 20000;
	public const int section3 = 30000;
	public const int section4 = 40000;
	public const int section5 = 50000;
	public const int section6 = 60000;
	public const int section7 = 70000;
	public const int section8 = 80000;
}

// Namespace: 
public static class CoreUtils.Priorities // TypeDefIndex: 20089
{
	// Fields
	public const int assetsCreateShaderMenuPriority = 83;
	public const int assetsCreateRenderingMenuPriority = 308;
	public const int editMenuPriority = 320;
	public const int gameObjectMenuPriority = 10;
	public const int srpLensFlareMenuPriority = 303;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CoreUtils.<>c // TypeDefIndex: 20090
{
	// Fields
	public static readonly CoreUtils.<>c <>9; // 0x0
	public static Func<Assembly, IEnumerable<Type>> <>9__87_0; // 0x8

	// Methods

	// RVA: 0x85F8A74 Offset: 0x85F4A74 VA: 0x85F8A74
	private static void .cctor() { }

	// RVA: 0x85F8ADC Offset: 0x85F4ADC VA: 0x85F8ADC
	public void .ctor() { }

	// RVA: 0x85F8AE4 Offset: 0x85F4AE4 VA: 0x85F8AE4
	internal IEnumerable<Type> <GetAllAssemblyTypes>b__87_0(Assembly t) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CoreUtils.<>c__88<T> // TypeDefIndex: 20091
{
	// Fields
	public static readonly CoreUtils.<>c__88<T> <>9; // 0x0
	public static Func<Type, bool> <>9__88_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485BD2C Offset: 0x4857D2C VA: 0x485BD2C
	|-CoreUtils.<>c__88<object>..cctor
	|
	|-RVA: 0x485BE80 Offset: 0x4857E80 VA: 0x485BE80
	|-CoreUtils.<>c__88<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485BDE8 Offset: 0x4857DE8 VA: 0x485BDE8
	|-CoreUtils.<>c__88<object>..ctor
	|
	|-RVA: 0x485BF74 Offset: 0x4857F74 VA: 0x485BF74
	|-CoreUtils.<>c__88<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <GetAllTypesDerivedFrom>b__88_0(Type t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485BDF0 Offset: 0x4857DF0 VA: 0x485BDF0
	|-CoreUtils.<>c__88<object>.<GetAllTypesDerivedFrom>b__88_0
	|
	|-RVA: 0x485BF7C Offset: 0x4857F7C VA: 0x485BF7C
	|-CoreUtils.<>c__88<__Il2CppFullySharedGenericType>.<GetAllTypesDerivedFrom>b__88_0
	*/
}

// Namespace: UnityEngine.Rendering
public static class CoreUtils // TypeDefIndex: 20092
{
	// Fields
	public static readonly Vector3[] lookAtList; // 0x0
	public static readonly Vector3[] upVectorList; // 0x8
	private const string obsoletePriorityMessage = "Use CoreUtils.Priorities instead";
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int editMenuPriority1 = 320;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int editMenuPriority2 = 331;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int editMenuPriority3 = 342;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int editMenuPriority4 = 353;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int assetCreateMenuPriority1 = 230;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int assetCreateMenuPriority2 = 241;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int assetCreateMenuPriority3 = 300;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int gameObjectMenuPriority = 10;
	private static Cubemap m_BlackCubeTexture; // 0x10
	private static Cubemap m_MagentaCubeTexture; // 0x18
	private static CubemapArray m_MagentaCubeTextureArray; // 0x20
	private static Cubemap m_WhiteCubeTexture; // 0x28
	private static RenderTexture m_EmptyUAV; // 0x30
	private static Texture3D m_BlackVolumeTexture; // 0x38
	private static IEnumerable<Type> m_AssemblyTypes; // 0x40

	// Properties
	public static Cubemap blackCubeTexture { get; }
	public static Cubemap magentaCubeTexture { get; }
	public static CubemapArray magentaCubeTextureArray { get; }
	public static Cubemap whiteCubeTexture { get; }
	public static RenderTexture emptyUAV { get; }
	public static Texture3D blackVolumeTexture { get; }

	// Methods

	// RVA: 0x85F4768 Offset: 0x85F0768 VA: 0x85F4768
	public static Cubemap get_blackCubeTexture() { }

	// RVA: 0x85F48D8 Offset: 0x85F08D8 VA: 0x85F48D8
	public static Cubemap get_magentaCubeTexture() { }

	// RVA: 0x85F4A48 Offset: 0x85F0A48 VA: 0x85F4A48
	public static CubemapArray get_magentaCubeTextureArray() { }

	// RVA: 0x85F4C1C Offset: 0x85F0C1C VA: 0x85F4C1C
	public static Cubemap get_whiteCubeTexture() { }

	// RVA: 0x85F4D8C Offset: 0x85F0D8C VA: 0x85F4D8C
	public static RenderTexture get_emptyUAV() { }

	// RVA: 0x85F4ECC Offset: 0x85F0ECC VA: 0x85F4ECC
	public static Texture3D get_blackVolumeTexture() { }

	// RVA: 0x85F5058 Offset: 0x85F1058 VA: 0x85F5058
	public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x85F507C Offset: 0x85F107C VA: 0x85F507C
	private static int FixupDepthSlice(int depthSlice, RTHandle buffer) { }

	// RVA: 0x85F50C0 Offset: 0x85F10C0 VA: 0x85F50C0
	private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace) { }

	// RVA: 0x85F50D4 Offset: 0x85F10D4 VA: 0x85F50D4
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F51E4 Offset: 0x85F11E4 VA: 0x85F51E4
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F52B4 Offset: 0x85F12B4 VA: 0x85F52B4
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F54E8 Offset: 0x85F14E8 VA: 0x85F54E8
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F53A8 Offset: 0x85F13A8 VA: 0x85F53A8
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F55E8 Offset: 0x85F15E8 VA: 0x85F55E8
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer) { }

	// RVA: 0x85F5784 Offset: 0x85F1784 VA: 0x85F5784
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = 0) { }

	// RVA: 0x85F5694 Offset: 0x85F1694 VA: 0x85F5694
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x85F583C Offset: 0x85F183C VA: 0x85F583C
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x85F5930 Offset: 0x85F1930 VA: 0x85F5930
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F5A30 Offset: 0x85F1A30 VA: 0x85F5A30
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F5B54 Offset: 0x85F1B54 VA: 0x85F5B54
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag) { }

	// RVA: 0x85F5C14 Offset: 0x85F1C14 VA: 0x85F5C14
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x85F5D50 Offset: 0x85F1D50 VA: 0x85F5D50
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F5EC0 Offset: 0x85F1EC0 VA: 0x85F5EC0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F603C Offset: 0x85F203C VA: 0x85F603C
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x85F6148 Offset: 0x85F2148 VA: 0x85F6148
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag) { }

	// RVA: 0x85F6250 Offset: 0x85F2250 VA: 0x85F6250
	private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x85F636C Offset: 0x85F236C VA: 0x85F636C
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F1884 Offset: 0x85ED884 VA: 0x85F1884
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F6488 Offset: 0x85F2488 VA: 0x85F6488
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F6804 Offset: 0x85F2804 VA: 0x85F6804
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F65F0 Offset: 0x85F25F0 VA: 0x85F65F0
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F1D54 Offset: 0x85EDD54 VA: 0x85F1D54
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F6970 Offset: 0x85F2970 VA: 0x85F6970
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x85F6BA8 Offset: 0x85F2BA8 VA: 0x85F6BA8
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer) { }

	// RVA: 0x85F6C68 Offset: 0x85F2C68 VA: 0x85F6C68
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = 0) { }

	// RVA: 0x85F6D2C Offset: 0x85F2D2C VA: 0x85F6D2C
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x85F62F4 Offset: 0x85F22F4 VA: 0x85F62F4
	public static void SetViewport(CommandBuffer cmd, RTHandle target) { }

	// RVA: 0x85F6E28 Offset: 0x85F2E28 VA: 0x85F6E28
	public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = 1) { }

	// RVA: 0x85F7170 Offset: 0x85F3170 VA: 0x85F7170
	public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = 1) { }

	// RVA: 0x85F7268 Offset: 0x85F3268 VA: 0x85F7268
	public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = 1, bool dynamicRes = False) { }

	// RVA: 0x85F6F20 Offset: 0x85F2F20 VA: 0x85F6F20
	private static string GetRenderTargetAutoName(int width, int height, int depth, string format, TextureDimension dim, string name, bool mips, bool enableMSAA, MSAASamples msaaSamples, bool dynamicRes) { }

	// RVA: 0x85F736C Offset: 0x85F336C VA: 0x85F736C
	public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = 0, string name = "", bool mips = False, int depth = 0) { }

	// RVA: 0x85F7870 Offset: 0x85F3870 VA: 0x85F7870
	public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = 0, string name = "", bool mips = False, int depth = 0) { }

	// RVA: 0x85F7454 Offset: 0x85F3454 VA: 0x85F7454
	private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = 0, string name = "", bool mips = False, int depth = 0) { }

	// RVA: 0x85F7958 Offset: 0x85F3958 VA: 0x85F7958
	public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, Color clearColor, bool clearMips = False) { }

	// RVA: 0x85F7B0C Offset: 0x85F3B0C VA: 0x85F7B0C
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x85F7BC0 Offset: 0x85F3BC0 VA: 0x85F7BC0
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x85F7C9C Offset: 0x85F3C9C VA: 0x85F7C9C
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x85F7DA4 Offset: 0x85F3DA4 VA: 0x85F7DA4
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x85F7E88 Offset: 0x85F3E88 VA: 0x85F7E88
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x85F7F50 Offset: 0x85F3F50 VA: 0x85F7F50
	public static Color ConvertSRGBToActiveColorSpace(Color color) { }

	// RVA: 0x85F7FCC Offset: 0x85F3FCC VA: 0x85F7FCC
	public static Color ConvertLinearToActiveColorSpace(Color color) { }

	// RVA: 0x85F8048 Offset: 0x85F4048 VA: 0x85F8048
	public static Material CreateEngineMaterial(string shaderPath) { }

	// RVA: 0x85F0260 Offset: 0x85EC260 VA: 0x85F0260
	public static Material CreateEngineMaterial(Shader shader) { }

	// RVA: -1 Offset: -1
	public static bool HasFlag<T>(T mask, T flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45638D4 Offset: 0x455F8D4 VA: 0x45638D4
	|-CoreUtils.HasFlag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4563A68 Offset: 0x455FA68 VA: 0x4563A68
	|-CoreUtils.Swap<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x85F8184 Offset: 0x85F4184 VA: 0x85F8184
	public static void SetKeyword(CommandBuffer cmd, string keyword, bool state) { }

	// RVA: 0x85F81A4 Offset: 0x85F41A4 VA: 0x85F81A4
	public static void SetKeyword(Material material, string keyword, bool state) { }

	// RVA: 0x85F81C4 Offset: 0x85F41C4 VA: 0x85F81C4
	public static void SetKeyword(ComputeShader cs, string keyword, bool state) { }

	// RVA: 0x85F078C Offset: 0x85EC78C VA: 0x85F078C
	public static void Destroy(Object obj) { }

	// RVA: 0x85F81E4 Offset: 0x85F41E4 VA: 0x85F81E4
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	// RVA: -1 Offset: -1
	public static IEnumerable<Type> GetAllTypesDerivedFrom<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4563414 Offset: 0x455F414 VA: 0x4563414
	|-CoreUtils.GetAllTypesDerivedFrom<object>
	|
	|-RVA: 0x4563598 Offset: 0x455F598 VA: 0x4563598
	|-CoreUtils.GetAllTypesDerivedFrom<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x85F837C Offset: 0x85F437C VA: 0x85F837C
	public static void SafeRelease(GraphicsBuffer buffer) { }

	// RVA: 0x85F838C Offset: 0x85F438C VA: 0x85F838C
	public static void SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x85F839C Offset: 0x85F439C VA: 0x85F839C
	public static Mesh CreateCubeMesh(Vector3 min, Vector3 max) { }

	// RVA: 0x85F8740 Offset: 0x85F4740 VA: 0x85F8740
	public static bool ArePostProcessesEnabled(Camera camera) { }

	// RVA: 0x85F8748 Offset: 0x85F4748 VA: 0x85F8748
	public static bool AreAnimatedMaterialsEnabled(Camera camera) { }

	// RVA: 0x85F8750 Offset: 0x85F4750 VA: 0x85F8750
	public static bool IsSceneLightingDisabled(Camera camera) { }

	// RVA: 0x85F8758 Offset: 0x85F4758 VA: 0x85F8758
	public static bool IsLightOverlapDebugEnabled(Camera camera) { }

	// RVA: 0x85F8760 Offset: 0x85F4760 VA: 0x85F8760
	public static bool IsSceneViewFogEnabled(Camera camera) { }

	// RVA: 0x85F8768 Offset: 0x85F4768 VA: 0x85F8768
	public static bool IsSceneFilteringEnabled() { }

	// RVA: 0x85F8770 Offset: 0x85F4770 VA: 0x85F8770
	public static bool IsSceneViewPrefabStageContextHidden() { }

	// RVA: 0x85F8778 Offset: 0x85F4778 VA: 0x85F8778
	public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList) { }

	// RVA: 0x85E8930 Offset: 0x85E4930 VA: 0x85E8930
	public static int GetTextureHash(Texture texture) { }

	// RVA: 0x85F886C Offset: 0x85F486C VA: 0x85F886C
	public static int PreviousPowerOfTwo(int size) { }

	// RVA: -1 Offset: -1
	public static T GetLastEnumValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456371C Offset: 0x455F71C VA: 0x456371C
	|-CoreUtils.GetLastEnumValue<Int32Enum>
	|
	|-RVA: 0x45637B0 Offset: 0x455F7B0 VA: 0x45637B0
	|-CoreUtils.GetLastEnumValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x85F8898 Offset: 0x85F4898 VA: 0x85F8898
	internal static string GetCorePath() { }

	// RVA: 0x85F88D8 Offset: 0x85F48D8 VA: 0x85F88D8
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public static class DelegateUtility // TypeDefIndex: 20093
{
	// Methods

	// RVA: 0x85F8BC8 Offset: 0x85F4BC8 VA: 0x85F8BC8
	public static Delegate Cast(Delegate source, Type type) { }
}

// Namespace: 
private static class FSRUtils.ShaderConstants // TypeDefIndex: 20094
{
	// Fields
	public static readonly int _FsrEasuConstants0; // 0x0
	public static readonly int _FsrEasuConstants1; // 0x4
	public static readonly int _FsrEasuConstants2; // 0x8
	public static readonly int _FsrEasuConstants3; // 0xC
	public static readonly int _FsrRcasConstants; // 0x10

	// Methods

	// RVA: 0x85F8FC8 Offset: 0x85F4FC8 VA: 0x85F8FC8
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public static class FSRUtils // TypeDefIndex: 20095
{
	// Fields
	internal const float kMaxSharpnessStops = 2.5;
	public const float kDefaultSharpnessStops = 0.2;
	public const float kDefaultSharpnessLinear = 0.92;

	// Methods

	// RVA: 0x85F8D68 Offset: 0x85F4D68 VA: 0x85F8D68
	public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels) { }

	// RVA: 0x85F8EEC Offset: 0x85F4EEC VA: 0x85F8EEC
	public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2) { }

	// RVA: 0x85F8F98 Offset: 0x85F4F98 VA: 0x85F8F98
	public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92) { }

	// RVA: 0x85F8FAC Offset: 0x85F4FAC VA: 0x85F8FAC
	public static bool IsSupported() { }
}

// Namespace: 
public class HableCurve.Segment // TypeDefIndex: 20096
{
	// Fields
	public float offsetX; // 0x10
	public float offsetY; // 0x14
	public float scaleX; // 0x18
	public float scaleY; // 0x1C
	public float lnA; // 0x20
	public float B; // 0x24

	// Methods

	// RVA: 0x85F9370 Offset: 0x85F5370 VA: 0x85F9370
	public float Eval(float x) { }

	// RVA: 0x85F9288 Offset: 0x85F5288 VA: 0x85F9288
	public void .ctor() { }
}

// Namespace: 
private struct HableCurve.DirectParams // TypeDefIndex: 20097
{
	// Fields
	internal float x0; // 0x0
	internal float y0; // 0x4
	internal float x1; // 0x8
	internal float y1; // 0xC
	internal float W; // 0x10
	internal float overshootX; // 0x14
	internal float overshootY; // 0x18
	internal float gamma; // 0x1C
}

// Namespace: 
public class HableCurve.Uniforms // TypeDefIndex: 20098
{
	// Fields
	private HableCurve parent; // 0x10

	// Properties
	public Vector4 curve { get; }
	public Vector4 toeSegmentA { get; }
	public Vector4 toeSegmentB { get; }
	public Vector4 midSegmentA { get; }
	public Vector4 midSegmentB { get; }
	public Vector4 shoSegmentA { get; }
	public Vector4 shoSegmentB { get; }

	// Methods

	// RVA: 0x85F9290 Offset: 0x85F5290 VA: 0x85F9290
	internal void .ctor(HableCurve parent) { }

	// RVA: 0x85F984C Offset: 0x85F584C VA: 0x85F984C
	public Vector4 get_curve() { }

	// RVA: 0x85F9870 Offset: 0x85F5870 VA: 0x85F9870
	public Vector4 get_toeSegmentA() { }

	// RVA: 0x85F98AC Offset: 0x85F58AC VA: 0x85F98AC
	public Vector4 get_toeSegmentB() { }

	// RVA: 0x85F98EC Offset: 0x85F58EC VA: 0x85F98EC
	public Vector4 get_midSegmentA() { }

	// RVA: 0x85F992C Offset: 0x85F592C VA: 0x85F992C
	public Vector4 get_midSegmentB() { }

	// RVA: 0x85F9970 Offset: 0x85F5970 VA: 0x85F9970
	public Vector4 get_shoSegmentA() { }

	// RVA: 0x85F99B0 Offset: 0x85F59B0 VA: 0x85F99B0
	public Vector4 get_shoSegmentB() { }
}

// Namespace: UnityEngine.Rendering
public class HableCurve // TypeDefIndex: 20099
{
	// Fields
	[CompilerGenerated]
	private float <whitePoint>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <inverseWhitePoint>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <x0>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <x1>k__BackingField; // 0x1C
	public readonly HableCurve.Segment[] segments; // 0x20
	public readonly HableCurve.Uniforms uniforms; // 0x28

	// Properties
	public float whitePoint { get; set; }
	public float inverseWhitePoint { get; set; }
	public float x0 { get; set; }
	public float x1 { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85F90F0 Offset: 0x85F50F0 VA: 0x85F90F0
	public float get_whitePoint() { }

	[CompilerGenerated]
	// RVA: 0x85F90F8 Offset: 0x85F50F8 VA: 0x85F90F8
	private void set_whitePoint(float value) { }

	[CompilerGenerated]
	// RVA: 0x85F9100 Offset: 0x85F5100 VA: 0x85F9100
	public float get_inverseWhitePoint() { }

	[CompilerGenerated]
	// RVA: 0x85F9108 Offset: 0x85F5108 VA: 0x85F9108
	private void set_inverseWhitePoint(float value) { }

	[CompilerGenerated]
	// RVA: 0x85F9110 Offset: 0x85F5110 VA: 0x85F9110
	public float get_x0() { }

	[CompilerGenerated]
	// RVA: 0x85F9118 Offset: 0x85F5118 VA: 0x85F9118
	private void set_x0(float value) { }

	[CompilerGenerated]
	// RVA: 0x85F9120 Offset: 0x85F5120 VA: 0x85F9120
	public float get_x1() { }

	[CompilerGenerated]
	// RVA: 0x85F9128 Offset: 0x85F5128 VA: 0x85F9128
	private void set_x1(float value) { }

	// RVA: 0x85F9130 Offset: 0x85F5130 VA: 0x85F9130
	public void .ctor() { }

	// RVA: 0x85F92C0 Offset: 0x85F52C0 VA: 0x85F92C0
	public float Eval(float x) { }

	// RVA: 0x85F93CC Offset: 0x85F53CC VA: 0x85F93CC
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	// RVA: 0x85F94E4 Offset: 0x85F54E4 VA: 0x85F94E4
	private void InitSegments(HableCurve.DirectParams srcParams) { }

	// RVA: 0x85F97FC Offset: 0x85F57FC VA: 0x85F97FC
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

	// RVA: 0x85F9798 Offset: 0x85F5798 VA: 0x85F9798
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	// RVA: 0x85F97C4 Offset: 0x85F57C4 VA: 0x85F97C4
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }
}

// Namespace: UnityEngine.Rendering
public static class HaltonSequence // TypeDefIndex: 20100
{
	// Methods

	// RVA: 0x85F99F4 Offset: 0x85F59F4 VA: 0x85F99F4
	public static float Get(int index, int radix) { }
}

// Namespace: UnityEngine.Rendering
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct HashFNV1A32 // TypeDefIndex: 20101
{
	// Fields
	private const uint k_Prime = 16777619;
	private const uint k_OffsetBasis = 2166136261;
	private uint m_Hash; // 0x0

	// Properties
	public int value { get; }

	// Methods

	// RVA: 0x85F9A38 Offset: 0x85F5A38 VA: 0x85F9A38
	public static HashFNV1A32 Create() { }

	// RVA: 0x85F9A44 Offset: 0x85F5A44 VA: 0x85F9A44
	public void Append(in int input) { }

	// RVA: 0x85F9A64 Offset: 0x85F5A64 VA: 0x85F9A64
	public void Append(in uint input) { }

	// RVA: 0x85F9A84 Offset: 0x85F5A84 VA: 0x85F9A84
	public void Append(in bool input) { }

	// RVA: 0x85F9AAC Offset: 0x85F5AAC VA: 0x85F9AAC
	public void Append(in float input) { }

	// RVA: 0x85F9AF0 Offset: 0x85F5AF0 VA: 0x85F9AF0
	public void Append(in double input) { }

	// RVA: 0x85F9B28 Offset: 0x85F5B28 VA: 0x85F9B28
	public void Append(in Vector2 input) { }

	// RVA: 0x85F9B8C Offset: 0x85F5B8C VA: 0x85F9B8C
	public void Append(in Vector3 input) { }

	// RVA: 0x85F9C18 Offset: 0x85F5C18 VA: 0x85F9C18
	public void Append(in Vector4 input) { }

	// RVA: -1 Offset: -1
	public void Append<T>(T input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4638FE0 Offset: 0x4634FE0 VA: 0x4638FE0
	|-HashFNV1A32.Append<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x85F9CB4 Offset: 0x85F5CB4 VA: 0x85F9CB4
	public void Append(Delegate del) { }

	// RVA: 0x85F9D30 Offset: 0x85F5D30 VA: 0x85F9D30
	internal static int GetFuncHashCode(Delegate del) { }

	// RVA: 0x85F9D84 Offset: 0x85F5D84 VA: 0x85F9D84
	public int get_value() { }

	// RVA: 0x85F9D8C Offset: 0x85F5D8C VA: 0x85F9D8C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[Flags]
public enum HDROutputUtils.Operation // TypeDefIndex: 20102
{
	// Fields
	public int value__; // 0x0
	public const HDROutputUtils.Operation None = 0;
	public const HDROutputUtils.Operation ColorConversion = 1;
	public const HDROutputUtils.Operation ColorEncoding = 2;
}

// Namespace: 
public struct HDROutputUtils.HDRDisplayInformation // TypeDefIndex: 20103
{
	// Fields
	public int maxFullFrameToneMapLuminance; // 0x0
	public int maxToneMapLuminance; // 0x4
	public int minToneMapLuminance; // 0x8
	public float paperWhiteNits; // 0xC

	// Methods

	// RVA: 0x85FA994 Offset: 0x85F6994 VA: 0x85FA994
	public void .ctor(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits) { }
}

// Namespace: 
public static class HDROutputUtils.ShaderKeywords // TypeDefIndex: 20104
{
	// Fields
	public const string HDR_COLORSPACE_CONVERSION = "HDR_COLORSPACE_CONVERSION";
	public const string HDR_ENCODING = "HDR_ENCODING";
	public const string HDR_COLORSPACE_CONVERSION_AND_ENCODING = "HDR_COLORSPACE_CONVERSION_AND_ENCODING";
	public const string HDR_INPUT = "HDR_INPUT";
	internal static readonly ShaderKeyword HDRColorSpaceConversion; // 0x0
	internal static readonly ShaderKeyword HDREncoding; // 0x10
	internal static readonly ShaderKeyword HDRColorSpaceConversionAndEncoding; // 0x20
	internal static readonly ShaderKeyword HDRInput; // 0x30

	// Methods

	// RVA: 0x85FA9A4 Offset: 0x85F69A4 VA: 0x85FA9A4
	private static void .cctor() { }
}

// Namespace: 
private static class HDROutputUtils.ShaderPropertyId // TypeDefIndex: 20105
{
	// Fields
	public static readonly int hdrColorSpace; // 0x0
	public static readonly int hdrEncoding; // 0x4

	// Methods

	// RVA: 0x85FAB18 Offset: 0x85F6B18 VA: 0x85FAB18
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public static class HDROutputUtils // TypeDefIndex: 20106
{
	// Methods

	// RVA: 0x85F9D94 Offset: 0x85F5D94 VA: 0x85F9D94
	public static bool GetColorSpaceForGamut(ColorGamut gamut, out int colorspace) { }

	// RVA: 0x85F9FA8 Offset: 0x85F5FA8 VA: 0x85F9FA8
	public static bool GetColorEncodingForGamut(ColorGamut gamut, out int encoding) { }

	// RVA: 0x85FA12C Offset: 0x85F612C VA: 0x85FA12C
	public static void ConfigureHDROutput(Material material, ColorGamut gamut, HDROutputUtils.Operation operations) { }

	// RVA: 0x85FA390 Offset: 0x85F6390 VA: 0x85FA390
	public static void ConfigureHDROutput(MaterialPropertyBlock properties, ColorGamut gamut) { }

	// RVA: 0x85FA450 Offset: 0x85F6450 VA: 0x85FA450
	public static void ConfigureHDROutput(Material material, HDROutputUtils.Operation operations) { }

	// RVA: 0x85FA624 Offset: 0x85F6624 VA: 0x85FA624
	public static void ConfigureHDROutput(ComputeShader computeShader, ColorGamut gamut, HDROutputUtils.Operation operations) { }

	// RVA: 0x85FA888 Offset: 0x85F6888 VA: 0x85FA888
	public static bool IsShaderVariantValid(ShaderKeywordSet shaderKeywordSet, bool isHDREnabled) { }
}

// Namespace: UnityEngine.Rendering
[MovedFrom("Utilities")]
[Flags]
public enum MaterialQuality // TypeDefIndex: 20107
{
	// Fields
	public int value__; // 0x0
	public const MaterialQuality Low = 1;
	public const MaterialQuality Medium = 2;
	public const MaterialQuality High = 4;
}

// Namespace: UnityEngine.Rendering
[MovedFrom("Utilities")]
[Extension]
public static class MaterialQualityUtilities // TypeDefIndex: 20108
{
	// Fields
	public static string[] KeywordNames; // 0x0
	public static string[] EnumNames; // 0x8
	public static ShaderKeyword[] Keywords; // 0x10

	// Methods

	[Extension]
	// RVA: 0x85FABB4 Offset: 0x85F6BB4 VA: 0x85FABB4
	public static MaterialQuality GetHighestQuality(MaterialQuality levels) { }

	[Extension]
	// RVA: 0x85FAC40 Offset: 0x85F6C40 VA: 0x85FAC40
	public static MaterialQuality GetClosestQuality(MaterialQuality availableLevels, MaterialQuality requestedLevel) { }

	[Extension]
	// RVA: 0x85FAE00 Offset: 0x85F6E00 VA: 0x85FAE00
	public static void SetGlobalShaderKeywords(MaterialQuality level) { }

	[Extension]
	// RVA: 0x85FAED8 Offset: 0x85F6ED8 VA: 0x85FAED8
	public static void SetGlobalShaderKeywords(MaterialQuality level, CommandBuffer cmd) { }

	[Extension]
	// RVA: 0x85FAD68 Offset: 0x85F6D68 VA: 0x85FAD68
	public static int ToFirstIndex(MaterialQuality level) { }

	// RVA: 0x85FADF4 Offset: 0x85F6DF4 VA: 0x85FADF4
	public static MaterialQuality FromIndex(int index) { }

	// RVA: 0x85FAFBC Offset: 0x85F6FBC VA: 0x85FAFBC
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct MeshGizmo.<>c__DisplayClass10_0 // TypeDefIndex: 20109
{
	// Fields
	public MeshGizmo <>4__this; // 0x0
	public Color color; // 0x8
}

// Namespace: UnityEngine.Rendering
internal class MeshGizmo : IDisposable // TypeDefIndex: 20110
{
	// Fields
	public static readonly int vertexCountPerCube; // 0x0
	public Mesh mesh; // 0x10
	private List<Vector3> vertices; // 0x18
	private List<int> indices; // 0x20
	private List<Color> colors; // 0x28
	private Material wireMaterial; // 0x30
	private Material dottedWireMaterial; // 0x38
	private Material solidMaterial; // 0x40

	// Methods

	// RVA: 0x85FB2A4 Offset: 0x85F72A4 VA: 0x85FB2A4
	public void .ctor(int capacity = 0) { }

	// RVA: 0x85FB44C Offset: 0x85F744C VA: 0x85FB44C
	public void Clear() { }

	// RVA: 0x85FB4DC Offset: 0x85F74DC VA: 0x85FB4DC
	public void AddWireCube(Vector3 center, Vector3 size, Color color) { }

	// RVA: 0x85FBA24 Offset: 0x85F7A24 VA: 0x85FBA24
	private void DrawMesh(Matrix4x4 trs, Material mat, MeshTopology topology, CompareFunction depthTest, string gizmoName) { }

	// RVA: 0x85FBBCC Offset: 0x85F7BCC VA: 0x85FBBCC
	public void RenderWireframe(Matrix4x4 trs, CompareFunction depthTest = 4, string gizmoName) { }

	// RVA: 0x85FBC0C Offset: 0x85F7C0C VA: 0x85FBC0C Slot: 4
	public void Dispose() { }

	// RVA: 0x85FBC68 Offset: 0x85F7C68 VA: 0x85FBC68
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x85FB730 Offset: 0x85F7730 VA: 0x85FB730
	private void <AddWireCube>g__AddEdge|10_0(Vector3 p1, Vector3 p2, ref MeshGizmo.<>c__DisplayClass10_0 ) { }
}

// Namespace: 
public enum ReloadAttribute.Package // TypeDefIndex: 20111
{
	// Fields
	public int value__; // 0x0
	public const ReloadAttribute.Package Builtin = 0;
	public const ReloadAttribute.Package Root = 1;
	public const ReloadAttribute.Package BuiltinExtra = 2;
}

// Namespace: UnityEngine.Rendering
[Usage(256)]
public sealed class ReloadAttribute : Attribute // TypeDefIndex: 20112
{
	// Methods

	// RVA: 0x85FBCB4 Offset: 0x85F7CB4 VA: 0x85FBCB4
	public void .ctor(string[] paths, ReloadAttribute.Package package = 1) { }

	// RVA: 0x85FBCBC Offset: 0x85F7CBC VA: 0x85FBCBC
	public void .ctor(string path, ReloadAttribute.Package package = 1) { }

	// RVA: 0x85FBD3C Offset: 0x85F7D3C VA: 0x85FBD3C
	public void .ctor(string pathFormat, int rangeMin, int rangeMax, ReloadAttribute.Package package = 1) { }
}

// Namespace: UnityEngine.Rendering
[Usage(4)]
public sealed class ReloadGroupAttribute : Attribute // TypeDefIndex: 20113
{
	// Methods

	// RVA: 0x85FBD44 Offset: 0x85F7D44 VA: 0x85FBD44
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public class SceneRenderPipeline : MonoBehaviour // TypeDefIndex: 20114
{
	// Methods

	// RVA: 0x85FBD4C Offset: 0x85F7D4C VA: 0x85FBD4C
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[DefaultMember("Item")]
[Serializable]
public class TextureCurve : IDisposable // TypeDefIndex: 20115
{
	// Fields
	private const int k_Precision = 128;
	private const float k_Step = 0.0078125;
	[SerializeField]
	[CompilerGenerated]
	private int <length>k__BackingField; // 0x10
	[SerializeField]
	private bool m_Loop; // 0x14
	[SerializeField]
	private float m_ZeroValue; // 0x18
	[SerializeField]
	private float m_Range; // 0x1C
	[SerializeField]
	private AnimationCurve m_Curve; // 0x20
	private AnimationCurve m_LoopingCurve; // 0x28
	private Texture2D m_Texture; // 0x30
	private bool m_IsCurveDirty; // 0x38
	private bool m_IsTextureDirty; // 0x39

	// Properties
	public int length { get; set; }
	public Keyframe Item { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85FBD54 Offset: 0x85F7D54 VA: 0x85FBD54
	public int get_length() { }

	[CompilerGenerated]
	// RVA: 0x85FBD5C Offset: 0x85F7D5C VA: 0x85FBD5C
	private void set_length(int value) { }

	// RVA: 0x85FBD64 Offset: 0x85F7D64 VA: 0x85FBD64
	public Keyframe get_Item(int index) { }

	// RVA: 0x85FBDA4 Offset: 0x85F7DA4 VA: 0x85FBDA4
	public void .ctor(AnimationCurve baseCurve, float zeroValue, bool loop, in Vector2 bounds) { }

	// RVA: 0x85FBDF8 Offset: 0x85F7DF8 VA: 0x85FBDF8
	public void .ctor(Keyframe[] keys, float zeroValue, bool loop, in Vector2 bounds) { }

	// RVA: 0x85FBF0C Offset: 0x85F7F0C VA: 0x85FBF0C Slot: 1
	protected override void Finalize() { }

	[Obsolete("Please use Release() instead.")]
	// RVA: 0x85FBF14 Offset: 0x85F7F14 VA: 0x85FBF14 Slot: 4
	public void Dispose() { }

	// RVA: 0x85FBF18 Offset: 0x85F7F18 VA: 0x85FBF18
	public void Release() { }

	// RVA: 0x85FBF84 Offset: 0x85F7F84 VA: 0x85FBF84
	public void SetDirty() { }

	// RVA: 0x85FBF90 Offset: 0x85F7F90 VA: 0x85FBF90
	private static GraphicsFormat GetTextureFormat() { }

	// RVA: 0x85FBFDC Offset: 0x85F7FDC VA: 0x85FBFDC
	public Texture2D GetTexture() { }

	// RVA: 0x85FC1E4 Offset: 0x85F81E4 VA: 0x85FC1E4
	public float Evaluate(float time) { }

	// RVA: 0x85FC41C Offset: 0x85F841C VA: 0x85FC41C
	public int AddKey(float time, float value) { }

	// RVA: 0x85FC454 Offset: 0x85F8454 VA: 0x85FC454
	public int MoveKey(int index, in Keyframe key) { }

	// RVA: 0x85FC4AC Offset: 0x85F84AC VA: 0x85FC4AC
	public void RemoveKey(int index) { }

	// RVA: 0x85FC4D8 Offset: 0x85F84D8 VA: 0x85FC4D8
	public void SmoothTangents(int index, float weight) { }
}

// Namespace: UnityEngine.Rendering
[Serializable]
public class TextureCurveParameter : VolumeParameter<TextureCurve> // TypeDefIndex: 20116
{
	// Methods

	// RVA: 0x85FC504 Offset: 0x85F8504 VA: 0x85FC504
	public void .ctor(TextureCurve value, bool overrideState = False) { }

	// RVA: 0x85FC564 Offset: 0x85F8564 VA: 0x85FC564 Slot: 11
	public override void Release() { }
}

// Namespace: UnityEngine.Rendering
public static class TileLayoutUtils // TypeDefIndex: 20117
{
	// Methods

	// RVA: 0x85FC57C Offset: 0x85F857C VA: 0x85FC57C
	public static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight) { }

	// RVA: 0x85FC624 Offset: 0x85F8624 VA: 0x85FC624
	public static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other) { }

	// RVA: 0x85FC684 Offset: 0x85F8684 VA: 0x85FC684
	public static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other) { }
}

// Namespace: UnityEngine.Rendering
public static class XRUtils // TypeDefIndex: 20118
{
	// Methods

	// RVA: 0x85FC6E4 Offset: 0x85F86E4 VA: 0x85FC6E4
	public static void DrawOcclusionMesh(CommandBuffer cmd, Camera camera, bool stereoEnabled = True) { }
}

// Namespace: UnityEngine.Rendering
public interface IVolume // TypeDefIndex: 20119
{
	// Properties
	public abstract bool isGlobal { get; set; }
	public abstract List<Collider> colliders { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isGlobal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_isGlobal(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<Collider> get_colliders();
}

// Namespace: UnityEngine.Rendering
public class KeyframeUtility // TypeDefIndex: 20120
{
	// Methods

	// RVA: 0x85FC76C Offset: 0x85F876C VA: 0x85FC76C
	public static void ResetAnimationCurve(AnimationCurve curve) { }

	// RVA: 0x85FC780 Offset: 0x85F8780 VA: 0x85FC780
	private static Keyframe LerpSingleKeyframe(Keyframe lhs, Keyframe rhs, float t) { }

	// RVA: 0x85FC93C Offset: 0x85F893C VA: 0x85FC93C
	private static Keyframe GetKeyframeAndClampEdge(NativeArray<Keyframe> keys, int index) { }

	// RVA: 0x85FCA50 Offset: 0x85F8A50 VA: 0x85FCA50
	private static Keyframe FetchKeyFromIndexClampEdge(NativeArray<Keyframe> keys, int index, float segmentStartTime, float segmentEndTime) { }

	// RVA: 0x85FCBDC Offset: 0x85F8BDC VA: 0x85FCBDC
	private static void EvalCurveSegmentAndDeriv(out float dstValue, out float dstDeriv, Keyframe lhsKey, Keyframe rhsKey, float desiredTime) { }

	// RVA: 0x85FCD68 Offset: 0x85F8D68 VA: 0x85FCD68
	private static Keyframe EvalKeyAtTime(NativeArray<Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime) { }

	// RVA: 0x85FCE54 Offset: 0x85F8E54 VA: 0x85FCE54
	public static void InterpAnimationCurve(ref AnimationCurve lhsAndResultCurve, AnimationCurve rhsCurve, float t) { }

	// RVA: 0x85FD500 Offset: 0x85F9500 VA: 0x85FD500
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[ExecuteAlways]
[AddComponentMenu("Miscellaneous/Volume")]
public class Volume : MonoBehaviour, IVolume // TypeDefIndex: 20121
{
	// Fields
	[FormerlySerializedAs("isGlobal")]
	[SerializeField]
	private bool m_IsGlobal; // 0x20
	[Tooltip("A value which determines which Volume is being used when Volumes have an equal amount of influence on the Scene. Volumes with a higher priority will override lower ones.")]
	[Delayed]
	public float priority; // 0x24
	[Tooltip("Sets the outer distance to start blending from. A value of 0 means no blending and Unity applies the Volume overrides immediately upon entry.")]
	public float blendDistance; // 0x28
	[Tooltip("Sets the total weight of this Volume in the Scene. 0 means no effect and 1 means full effect.")]
	[Range(0, 1)]
	public float weight; // 0x2C
	public VolumeProfile sharedProfile; // 0x30
	internal List<Collider> m_Colliders; // 0x38
	private int m_PreviousLayer; // 0x40
	private float m_PreviousPriority; // 0x44
	private VolumeProfile m_InternalProfile; // 0x48

	// Properties
	[Tooltip("When enabled, the Volume is applied to the entire Scene.")]
	public bool isGlobal { get; set; }
	public VolumeProfile profile { get; set; }
	public List<Collider> colliders { get; }
	internal VolumeProfile profileRef { get; }

	// Methods

	// RVA: 0x85FD508 Offset: 0x85F9508 VA: 0x85FD508 Slot: 4
	public bool get_isGlobal() { }

	// RVA: 0x85FD510 Offset: 0x85F9510 VA: 0x85FD510 Slot: 5
	public void set_isGlobal(bool value) { }

	// RVA: 0x85FD51C Offset: 0x85F951C VA: 0x85FD51C
	public VolumeProfile get_profile() { }

	// RVA: 0x85FD804 Offset: 0x85F9804 VA: 0x85FD804
	public void set_profile(VolumeProfile value) { }

	// RVA: 0x85FD80C Offset: 0x85F980C VA: 0x85FD80C Slot: 6
	public List<Collider> get_colliders() { }

	// RVA: 0x85FD814 Offset: 0x85F9814 VA: 0x85FD814
	internal VolumeProfile get_profileRef() { }

	// RVA: 0x85FD88C Offset: 0x85F988C VA: 0x85FD88C
	public bool HasInstantiatedProfile() { }

	// RVA: 0x85FD8EC Offset: 0x85F98EC VA: 0x85FD8EC
	private void OnEnable() { }

	// RVA: 0x85FDCDC Offset: 0x85F9CDC VA: 0x85FDCDC
	private void OnDisable() { }

	// RVA: 0x85FDF1C Offset: 0x85F9F1C VA: 0x85FDF1C
	private void Update() { }

	// RVA: 0x85FDFC0 Offset: 0x85F9FC0 VA: 0x85FDFC0
	internal void UpdateLayer() { }

	// RVA: 0x85FE21C Offset: 0x85FA21C VA: 0x85FE21C
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[Usage(4, AllowMultiple = False)]
public class VolumeComponentMenu : Attribute // TypeDefIndex: 20122
{
	// Fields
	public readonly string menu; // 0x10

	// Methods

	// RVA: 0x85FE2B4 Offset: 0x85FA2B4 VA: 0x85FE2B4
	public void .ctor(string menu) { }
}

// Namespace: UnityEngine.Rendering
public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu // TypeDefIndex: 20123
{
	// Fields
	[CompilerGenerated]
	private readonly Type[] <pipelineTypes>k__BackingField; // 0x18

	// Properties
	public Type[] pipelineTypes { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85FE2E4 Offset: 0x85FA2E4 VA: 0x85FE2E4
	public Type[] get_pipelineTypes() { }

	// RVA: 0x85FE2EC Offset: 0x85FA2EC VA: 0x85FE2EC
	public void .ctor(string menu, Type[] pipelineTypes) { }
}

// Namespace: UnityEngine.Rendering
[Usage(4)]
[Obsolete("VolumeComponentDeprecated has been deprecated (UnityUpgradable) -> [UnityEngine] UnityEngine.HideInInspector", False)]
public sealed class VolumeComponentDeprecated : Attribute // TypeDefIndex: 20124
{
	// Methods

	// RVA: 0x85FE4D4 Offset: 0x85FA4D4 VA: 0x85FE4D4
	public void .ctor() { }
}

// Namespace: 
public sealed class VolumeComponent.Indent : PropertyAttribute // TypeDefIndex: 20125
{
	// Fields
	public readonly int relativeAmount; // 0x10

	// Methods

	// RVA: 0x85FF82C Offset: 0x85FB82C VA: 0x85FF82C
	public void .ctor(int relativeAmount = 1) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VolumeComponent.<>c // TypeDefIndex: 20126
{
	// Fields
	public static readonly VolumeComponent.<>c <>9; // 0x0
	public static Func<FieldInfo, int> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x85FF854 Offset: 0x85FB854 VA: 0x85FF854
	private static void .cctor() { }

	// RVA: 0x85FF8BC Offset: 0x85FB8BC VA: 0x85FF8BC
	public void .ctor() { }

	// RVA: 0x85FF8C4 Offset: 0x85FB8C4 VA: 0x85FF8C4
	internal int <FindParameters>b__10_0(FieldInfo t) { }
}

// Namespace: UnityEngine.Rendering
[Serializable]
public class VolumeComponent : ScriptableObject // TypeDefIndex: 20127
{
	// Fields
	public bool active; // 0x18
	[CompilerGenerated]
	private string <displayName>k__BackingField; // 0x20
	internal readonly List<VolumeParameter> parameterList; // 0x28
	private ReadOnlyCollection<VolumeParameter> m_ParameterReadOnlyCollection; // 0x30

	// Properties
	public string displayName { get; set; }
	public ReadOnlyCollection<VolumeParameter> parameters { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x85FE4DC Offset: 0x85FA4DC VA: 0x85FE4DC
	public string get_displayName() { }

	[CompilerGenerated]
	// RVA: 0x85FE4E4 Offset: 0x85FA4E4 VA: 0x85FE4E4
	protected void set_displayName(string value) { }

	// RVA: 0x85FE4EC Offset: 0x85FA4EC VA: 0x85FE4EC
	public ReadOnlyCollection<VolumeParameter> get_parameters() { }

	// RVA: 0x85FE560 Offset: 0x85FA560 VA: 0x85FE560
	internal static void FindParameters(object o, List<VolumeParameter> parameters, Func<FieldInfo, bool> filter) { }

	// RVA: 0x85FEB98 Offset: 0x85FAB98 VA: 0x85FEB98 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x85FEDE0 Offset: 0x85FADE0 VA: 0x85FEDE0 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x85FEF28 Offset: 0x85FAF28 VA: 0x85FEF28 Slot: 6
	public virtual void Override(VolumeComponent state, float interpFactor) { }

	// RVA: 0x85FF04C Offset: 0x85FB04C VA: 0x85FF04C
	public void SetAllOverridesTo(bool state) { }

	// RVA: 0x85FF05C Offset: 0x85FB05C VA: 0x85FF05C
	internal void SetOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state) { }

	// RVA: 0x85FF57C Offset: 0x85FB57C VA: 0x85FF57C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x85FF628 Offset: 0x85FB628 VA: 0x85FF628
	public bool AnyPropertiesIsOverridden() { }

	// RVA: 0x85FF6CC Offset: 0x85FB6CC VA: 0x85FF6CC Slot: 7
	protected virtual void OnDestroy() { }

	// RVA: 0x85FF6D0 Offset: 0x85FB6D0 VA: 0x85FF6D0
	public void Release() { }

	// RVA: 0x85FF778 Offset: 0x85FB778 VA: 0x85FF778
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VolumeManager.<>c // TypeDefIndex: 20128
{
	// Fields
	public static readonly VolumeManager.<>c <>9; // 0x0
	public static Func<ValueTuple<string, Type>, string> <>9__12_0; // 0x8
	public static Func<Type, bool> <>9__29_0; // 0x10
	public static Predicate<Volume> <>9__42_0; // 0x18

	// Methods

	// RVA: 0x8601B2C Offset: 0x85FDB2C VA: 0x8601B2C
	private static void .cctor() { }

	// RVA: 0x8601B94 Offset: 0x85FDB94 VA: 0x8601B94
	public void .ctor() { }

	// RVA: 0x8601B9C Offset: 0x85FDB9C VA: 0x8601B9C
	internal string <FilterVolumeComponentTypes>b__12_0(ValueTuple<string, Type> i) { }

	// RVA: 0x8601BA4 Offset: 0x85FDBA4 VA: 0x8601BA4
	internal bool <ReloadBaseTypes>b__29_0(Type t) { }

	// RVA: 0x8601BCC Offset: 0x85FDBCC VA: 0x8601BCC
	internal bool <GetVolumes>b__42_0(Volume v) { }

	// RVA: 0x8601C28 Offset: 0x85FDC28 VA: 0x8601C28
	internal VolumeManager <.cctor>b__46_0() { }
}

// Namespace: UnityEngine.Rendering
public sealed class VolumeManager // TypeDefIndex: 20129
{
	// Fields
	private static readonly Lazy<VolumeManager> s_Instance; // 0x0
	[CompilerGenerated]
	private VolumeStack <stack>k__BackingField; // 0x10
	private static readonly Dictionary<Type, List<ValueTuple<string, Type>>> s_SupportedVolumeComponentsForRenderPipeline; // 0x8
	[CompilerGenerated]
	private Type[] <baseComponentTypeArray>k__BackingField; // 0x18
	private const int k_MaxLayerCount = 32;
	private readonly Dictionary<int, List<Volume>> m_SortedVolumes; // 0x20
	private readonly List<Volume> m_Volumes; // 0x28
	private readonly Dictionary<int, bool> m_SortNeeded; // 0x30
	private readonly List<VolumeComponent> m_ComponentsDefaultState; // 0x38
	private readonly List<Collider> m_TempColliders; // 0x40
	private VolumeStack m_DefaultStack; // 0x48

	// Properties
	public static VolumeManager instance { get; }
	public VolumeStack stack { get; set; }
	[Obsolete("Please use baseComponentTypeArray instead.")]
	public IEnumerable<Type> baseComponentTypes { get; set; }
	public Type[] baseComponentTypeArray { get; set; }

	// Methods

	// RVA: 0x85FD990 Offset: 0x85F9990 VA: 0x85FD990
	public static VolumeManager get_instance() { }

	[CompilerGenerated]
	// RVA: 0x85FF8EC Offset: 0x85FB8EC VA: 0x85FF8EC
	public VolumeStack get_stack() { }

	[CompilerGenerated]
	// RVA: 0x85FF8F4 Offset: 0x85FB8F4 VA: 0x85FF8F4
	public void set_stack(VolumeStack value) { }

	// RVA: 0x85FF8FC Offset: 0x85FB8FC VA: 0x85FF8FC
	public IEnumerable<Type> get_baseComponentTypes() { }

	// RVA: 0x85FF904 Offset: 0x85FB904 VA: 0x85FF904
	private void set_baseComponentTypes(IEnumerable<Type> value) { }

	// RVA: 0x85FF968 Offset: 0x85FB968 VA: 0x85FF968
	internal static List<ValueTuple<string, Type>> GetSupportedVolumeComponents(Type currentPipelineType) { }

	// RVA: 0x85FFA60 Offset: 0x85FBA60 VA: 0x85FFA60
	private static List<ValueTuple<string, Type>> FilterVolumeComponentTypes(Type[] types, Type currentPipelineType) { }

	[CompilerGenerated]
	// RVA: 0x85FFE60 Offset: 0x85FBE60 VA: 0x85FFE60
	public Type[] get_baseComponentTypeArray() { }

	[CompilerGenerated]
	// RVA: 0x85FFE68 Offset: 0x85FBE68 VA: 0x85FFE68
	private void set_baseComponentTypeArray(Type[] value) { }

	// RVA: 0x85FFE70 Offset: 0x85FBE70 VA: 0x85FFE70
	internal VolumeComponent GetDefaultVolumeComponent(Type volumeComponentType) { }

	// RVA: 0x8600010 Offset: 0x85FC010 VA: 0x8600010
	private void .ctor() { }

	// RVA: 0x8600540 Offset: 0x85FC540 VA: 0x8600540
	public VolumeStack CreateStack() { }

	// RVA: 0x8600ADC Offset: 0x85FCADC VA: 0x8600ADC
	public void ResetMainStack() { }

	// RVA: 0x8600AE8 Offset: 0x85FCAE8 VA: 0x8600AE8
	public void DestroyStack(VolumeStack stack) { }

	// RVA: 0x8600218 Offset: 0x85FC218 VA: 0x8600218
	private void ReloadBaseTypes() { }

	// RVA: 0x85FDA08 Offset: 0x85F9A08 VA: 0x85FDA08
	public void Register(Volume volume, int layer) { }

	// RVA: 0x85FDD60 Offset: 0x85F9D60 VA: 0x85FDD60
	public void Unregister(Volume volume, int layer) { }

	// RVA: -1 Offset: -1
	public bool IsComponentActiveInMask<T>(LayerMask layerMask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4781700 Offset: 0x477D700 VA: 0x4781700
	|-VolumeManager.IsComponentActiveInMask<object>
	*/

	// RVA: 0x85FE068 Offset: 0x85FA068 VA: 0x85FE068
	internal void SetLayerDirty(int layer) { }

	// RVA: 0x85FE1EC Offset: 0x85FA1EC VA: 0x85FE1EC
	internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer) { }

	// RVA: 0x8600B00 Offset: 0x85FCB00 VA: 0x8600B00
	private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor) { }

	// RVA: 0x8600C54 Offset: 0x85FCC54 VA: 0x8600C54
	internal void ReplaceData(VolumeStack stack) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x8600CF4 Offset: 0x85FCCF4 VA: 0x8600CF4
	public void CheckBaseTypes() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x8600DB0 Offset: 0x85FCDB0 VA: 0x8600DB0
	public void CheckStack(VolumeStack stack) { }

	// RVA: 0x8600FAC Offset: 0x85FCFAC VA: 0x8600FAC
	private bool CheckUpdateRequired(VolumeStack stack) { }

	// RVA: 0x8601020 Offset: 0x85FD020 VA: 0x8601020
	public void Update(Transform trigger, LayerMask layerMask) { }

	// RVA: 0x8601034 Offset: 0x85FD034 VA: 0x8601034
	public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask) { }

	// RVA: 0x8601744 Offset: 0x85FD744 VA: 0x8601744
	public Volume[] GetVolumes(LayerMask layerMask) { }

	// RVA: 0x860143C Offset: 0x85FD43C VA: 0x860143C
	private List<Volume> GrabVolumes(LayerMask mask) { }

	// RVA: 0x8601880 Offset: 0x85FD880 VA: 0x8601880
	private static void SortByPriority(List<Volume> volumes) { }

	// RVA: 0x86019B4 Offset: 0x85FD9B4 VA: 0x86019B4
	private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera) { }

	// RVA: 0x86019BC Offset: 0x85FD9BC VA: 0x86019BC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[Obsolete("VolumeIsolationScope is deprecated, it does not have any effect anymore.")]
public struct VolumeIsolationScope : IDisposable // TypeDefIndex: 20130
{
	// Methods

	// RVA: 0x8601C78 Offset: 0x85FDC78 VA: 0x8601C78
	public void .ctor(bool unused) { }

	// RVA: 0x8601C7C Offset: 0x85FDC7C VA: 0x8601C7C Slot: 4
	private void System.IDisposable.Dispose() { }
}

// Namespace: UnityEngine.Rendering
public abstract class VolumeParameter : ICloneable // TypeDefIndex: 20131
{
	// Fields
	public const string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";
	[SerializeField]
	protected bool m_OverrideState; // 0x10

	// Properties
	public virtual bool overrideState { get; set; }

	// Methods

	// RVA: 0x8601C80 Offset: 0x85FDC80 VA: 0x8601C80 Slot: 5
	public virtual bool get_overrideState() { }

	// RVA: 0x8601C88 Offset: 0x85FDC88 VA: 0x8601C88 Slot: 6
	public virtual void set_overrideState(bool value) { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t);

	// RVA: -1 Offset: -1
	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4781AB8 Offset: 0x477DAB8 VA: 0x4781AB8
	|-VolumeParameter.GetValue<bool>
	|
	|-RVA: 0x4781B88 Offset: 0x477DB88 VA: 0x4781B88
	|-VolumeParameter.GetValue<Color>
	|
	|-RVA: 0x4781C58 Offset: 0x477DC58 VA: 0x4781C58
	|-VolumeParameter.GetValue<int>
	|
	|-RVA: 0x4781D28 Offset: 0x477DD28 VA: 0x4781D28
	|-VolumeParameter.GetValue<LayerMask>
	|
	|-RVA: 0x4781E00 Offset: 0x477DE00 VA: 0x4781E00
	|-VolumeParameter.GetValue<object>
	|
	|-RVA: 0x4781ED0 Offset: 0x477DED0 VA: 0x4781ED0
	|-VolumeParameter.GetValue<float>
	|
	|-RVA: 0x4781FA0 Offset: 0x477DFA0 VA: 0x4781FA0
	|-VolumeParameter.GetValue<Vector2>
	|
	|-RVA: 0x4782070 Offset: 0x477E070 VA: 0x4782070
	|-VolumeParameter.GetValue<Vector3>
	|
	|-RVA: 0x4782140 Offset: 0x477E140 VA: 0x4782140
	|-VolumeParameter.GetValue<Vector4>
	|
	|-RVA: 0x4782210 Offset: 0x477E210 VA: 0x4782210
	|-VolumeParameter.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetValue(VolumeParameter parameter);

	// RVA: 0x8601C94 Offset: 0x85FDC94 VA: 0x8601C94 Slot: 9
	protected internal virtual void OnEnable() { }

	// RVA: 0x8601C98 Offset: 0x85FDC98 VA: 0x8601C98 Slot: 10
	protected internal virtual void OnDisable() { }

	// RVA: 0x85FF448 Offset: 0x85FB448 VA: 0x85FF448
	public static bool IsObjectParameter(Type type) { }

	// RVA: 0x8601C9C Offset: 0x85FDC9C VA: 0x8601C9C Slot: 11
	public virtual void Release() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract object Clone();

	// RVA: 0x8601CA0 Offset: 0x85FDCA0 VA: 0x8601CA0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class VolumeParameter<T> : VolumeParameter, IEquatable<VolumeParameter<T>> // TypeDefIndex: 20132
{
	// Fields
	[SerializeField]
	protected T m_Value; // 0x0

	// Properties
	public virtual T value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	public virtual T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC3D0 Offset: 0x58B83D0 VA: 0x58BC3D0
	|-VolumeParameter<bool>.get_value
	|
	|-RVA: 0x58BCCAC Offset: 0x58B8CAC VA: 0x58BCCAC
	|-VolumeParameter<Color>.get_value
	|
	|-RVA: 0x58BD6F8 Offset: 0x58B96F8 VA: 0x58BD6F8
	|-VolumeParameter<int>.get_value
	|
	|-RVA: 0x58BDF58 Offset: 0x58B9F58 VA: 0x58BDF58
	|-VolumeParameter<LayerMask>.get_value
	|
	|-RVA: 0x58BE808 Offset: 0x58BA808 VA: 0x58BE808
	|-VolumeParameter<object>.get_value
	|
	|-RVA: 0x58BF01C Offset: 0x58BB01C VA: 0x58BF01C
	|-VolumeParameter<float>.get_value
	|
	|-RVA: 0x58BF888 Offset: 0x58BB888 VA: 0x58BF888
	|-VolumeParameter<Vector2>.get_value
	|
	|-RVA: 0x58C019C Offset: 0x58BC19C VA: 0x58C019C
	|-VolumeParameter<Vector3>.get_value
	|
	|-RVA: 0x58C0B78 Offset: 0x58BCB78 VA: 0x58C0B78
	|-VolumeParameter<Vector4>.get_value
	|
	|-RVA: 0x58C15BC Offset: 0x58BD5BC VA: 0x58C15BC
	|-VolumeParameter<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void set_value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC3D8 Offset: 0x58B83D8 VA: 0x58BC3D8
	|-VolumeParameter<bool>.set_value
	|
	|-RVA: 0x58BCCB8 Offset: 0x58B8CB8 VA: 0x58BCCB8
	|-VolumeParameter<Color>.set_value
	|
	|-RVA: 0x58BD700 Offset: 0x58B9700 VA: 0x58BD700
	|-VolumeParameter<int>.set_value
	|
	|-RVA: 0x58BDF60 Offset: 0x58B9F60 VA: 0x58BDF60
	|-VolumeParameter<LayerMask>.set_value
	|
	|-RVA: 0x58BE810 Offset: 0x58BA810 VA: 0x58BE810
	|-VolumeParameter<object>.set_value
	|
	|-RVA: 0x58BF024 Offset: 0x58BB024 VA: 0x58BF024
	|-VolumeParameter<float>.set_value
	|
	|-RVA: 0x58BF890 Offset: 0x58BB890 VA: 0x58BF890
	|-VolumeParameter<Vector2>.set_value
	|
	|-RVA: 0x58C01A8 Offset: 0x58BC1A8 VA: 0x58C01A8
	|-VolumeParameter<Vector3>.set_value
	|
	|-RVA: 0x58C0B84 Offset: 0x58BCB84 VA: 0x58C0B84
	|-VolumeParameter<Vector4>.set_value
	|
	|-RVA: 0x58C1654 Offset: 0x58BD654 VA: 0x58C1654
	|-VolumeParameter<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC3E4 Offset: 0x58B83E4 VA: 0x58BC3E4
	|-VolumeParameter<bool>..ctor
	|
	|-RVA: 0x58BCCC4 Offset: 0x58B8CC4 VA: 0x58BCCC4
	|-VolumeParameter<Color>..ctor
	|
	|-RVA: 0x58BD708 Offset: 0x58B9708 VA: 0x58BD708
	|-VolumeParameter<int>..ctor
	|
	|-RVA: 0x58BDF68 Offset: 0x58B9F68 VA: 0x58BDF68
	|-VolumeParameter<LayerMask>..ctor
	|
	|-RVA: 0x58BE818 Offset: 0x58BA818 VA: 0x58BE818
	|-VolumeParameter<object>..ctor
	|
	|-RVA: 0x58BF02C Offset: 0x58BB02C VA: 0x58BF02C
	|-VolumeParameter<float>..ctor
	|
	|-RVA: 0x58BF898 Offset: 0x58BB898 VA: 0x58BF898
	|-VolumeParameter<Vector2>..ctor
	|
	|-RVA: 0x58C01B4 Offset: 0x58BC1B4 VA: 0x58C01B4
	|-VolumeParameter<Vector3>..ctor
	|
	|-RVA: 0x58C0B90 Offset: 0x58BCB90 VA: 0x58C0B90
	|-VolumeParameter<Vector4>..ctor
	|
	|-RVA: 0x58C1708 Offset: 0x58BD708 VA: 0x58C1708
	|-VolumeParameter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(T value, bool overrideState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC410 Offset: 0x58B8410 VA: 0x58BC410
	|-VolumeParameter<bool>..ctor
	|
	|-RVA: 0x58BCCF4 Offset: 0x58B8CF4 VA: 0x58BCCF4
	|-VolumeParameter<Color>..ctor
	|
	|-RVA: 0x58BD734 Offset: 0x58B9734 VA: 0x58BD734
	|-VolumeParameter<int>..ctor
	|
	|-RVA: 0x58BDF94 Offset: 0x58B9F94 VA: 0x58BDF94
	|-VolumeParameter<LayerMask>..ctor
	|
	|-RVA: 0x58BE850 Offset: 0x58BA850 VA: 0x58BE850
	|-VolumeParameter<object>..ctor
	|
	|-RVA: 0x58BF058 Offset: 0x58BB058 VA: 0x58BF058
	|-VolumeParameter<float>..ctor
	|
	|-RVA: 0x58BF8C4 Offset: 0x58BB8C4 VA: 0x58BF8C4
	|-VolumeParameter<Vector2>..ctor
	|
	|-RVA: 0x58C01E4 Offset: 0x58BC1E4 VA: 0x58C01E4
	|-VolumeParameter<Vector3>..ctor
	|
	|-RVA: 0x58C0BC0 Offset: 0x58BCBC0 VA: 0x58C0BC0
	|-VolumeParameter<Vector4>..ctor
	|
	|-RVA: 0x58C17F4 Offset: 0x58BD7F4 VA: 0x58C17F4
	|-VolumeParameter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override void Interp(VolumeParameter from, VolumeParameter to, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC44C Offset: 0x58B844C VA: 0x58BC44C
	|-VolumeParameter<bool>.Interp
	|
	|-RVA: 0x58BCD50 Offset: 0x58B8D50 VA: 0x58BCD50
	|-VolumeParameter<Color>.Interp
	|
	|-RVA: 0x58BD770 Offset: 0x58B9770 VA: 0x58BD770
	|-VolumeParameter<int>.Interp
	|
	|-RVA: 0x58BDFD0 Offset: 0x58B9FD0 VA: 0x58BDFD0
	|-VolumeParameter<LayerMask>.Interp
	|
	|-RVA: 0x58BE898 Offset: 0x58BA898 VA: 0x58BE898
	|-VolumeParameter<object>.Interp
	|
	|-RVA: 0x58BF09C Offset: 0x58BB09C VA: 0x58BF09C
	|-VolumeParameter<float>.Interp
	|
	|-RVA: 0x58BF90C Offset: 0x58BB90C VA: 0x58BF90C
	|-VolumeParameter<Vector2>.Interp
	|
	|-RVA: 0x58C023C Offset: 0x58BC23C VA: 0x58C023C
	|-VolumeParameter<Vector3>.Interp
	|
	|-RVA: 0x58C0C1C Offset: 0x58BCC1C VA: 0x58C0C1C
	|-VolumeParameter<Vector4>.Interp
	|
	|-RVA: 0x58C18EC Offset: 0x58BD8EC VA: 0x58C18EC
	|-VolumeParameter<__Il2CppFullySharedGenericType>.Interp
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual void Interp(T from, T to, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC5DC Offset: 0x58B85DC VA: 0x58BC5DC
	|-VolumeParameter<bool>.Interp
	|
	|-RVA: 0x58BCF18 Offset: 0x58B8F18 VA: 0x58BCF18
	|-VolumeParameter<Color>.Interp
	|
	|-RVA: 0x58BD900 Offset: 0x58B9900 VA: 0x58BD900
	|-VolumeParameter<int>.Interp
	|
	|-RVA: 0x58BE164 Offset: 0x58BA164 VA: 0x58BE164
	|-VolumeParameter<LayerMask>.Interp
	|
	|-RVA: 0x58BEA28 Offset: 0x58BAA28 VA: 0x58BEA28
	|-VolumeParameter<object>.Interp
	|
	|-RVA: 0x58BF224 Offset: 0x58BB224 VA: 0x58BF224
	|-VolumeParameter<float>.Interp
	|
	|-RVA: 0x58BFAA8 Offset: 0x58BBAA8 VA: 0x58BFAA8
	|-VolumeParameter<Vector2>.Interp
	|
	|-RVA: 0x58C03E4 Offset: 0x58BC3E4 VA: 0x58C03E4
	|-VolumeParameter<Vector3>.Interp
	|
	|-RVA: 0x58C0DE4 Offset: 0x58BCDE4 VA: 0x58C0DE4
	|-VolumeParameter<Vector4>.Interp
	|
	|-RVA: 0x58C1B10 Offset: 0x58BDB10 VA: 0x58C1B10
	|-VolumeParameter<__Il2CppFullySharedGenericType>.Interp
	*/

	// RVA: -1 Offset: -1
	public void Override(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC600 Offset: 0x58B8600 VA: 0x58BC600
	|-VolumeParameter<bool>.Override
	|
	|-RVA: 0x58BCF4C Offset: 0x58B8F4C VA: 0x58BCF4C
	|-VolumeParameter<Color>.Override
	|
	|-RVA: 0x58BD920 Offset: 0x58B9920 VA: 0x58BD920
	|-VolumeParameter<int>.Override
	|
	|-RVA: 0x58BE184 Offset: 0x58BA184 VA: 0x58BE184
	|-VolumeParameter<LayerMask>.Override
	|
	|-RVA: 0x58BEA48 Offset: 0x58BAA48 VA: 0x58BEA48
	|-VolumeParameter<object>.Override
	|
	|-RVA: 0x58BF244 Offset: 0x58BB244 VA: 0x58BF244
	|-VolumeParameter<float>.Override
	|
	|-RVA: 0x58BFACC Offset: 0x58BBACC VA: 0x58BFACC
	|-VolumeParameter<Vector2>.Override
	|
	|-RVA: 0x58C0410 Offset: 0x58BC410 VA: 0x58C0410
	|-VolumeParameter<Vector3>.Override
	|
	|-RVA: 0x58C0E18 Offset: 0x58BCE18 VA: 0x58C0E18
	|-VolumeParameter<Vector4>.Override
	|
	|-RVA: 0x58C1C2C Offset: 0x58BDC2C VA: 0x58C1C2C
	|-VolumeParameter<__Il2CppFullySharedGenericType>.Override
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void SetValue(VolumeParameter parameter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC638 Offset: 0x58B8638 VA: 0x58BC638
	|-VolumeParameter<bool>.SetValue
	|
	|-RVA: 0x58BCF9C Offset: 0x58B8F9C VA: 0x58BCF9C
	|-VolumeParameter<Color>.SetValue
	|
	|-RVA: 0x58BD958 Offset: 0x58B9958 VA: 0x58BD958
	|-VolumeParameter<int>.SetValue
	|
	|-RVA: 0x58BE1BC Offset: 0x58BA1BC VA: 0x58BE1BC
	|-VolumeParameter<LayerMask>.SetValue
	|
	|-RVA: 0x58BEA88 Offset: 0x58BAA88 VA: 0x58BEA88
	|-VolumeParameter<object>.SetValue
	|
	|-RVA: 0x58BF27C Offset: 0x58BB27C VA: 0x58BF27C
	|-VolumeParameter<float>.SetValue
	|
	|-RVA: 0x58BFB08 Offset: 0x58BBB08 VA: 0x58BFB08
	|-VolumeParameter<Vector2>.SetValue
	|
	|-RVA: 0x58C045C Offset: 0x58BC45C VA: 0x58C045C
	|-VolumeParameter<Vector3>.SetValue
	|
	|-RVA: 0x58C0E68 Offset: 0x58BCE68 VA: 0x58C0E68
	|-VolumeParameter<Vector4>.SetValue
	|
	|-RVA: 0x58C1D0C Offset: 0x58BDD0C VA: 0x58C1D0C
	|-VolumeParameter<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC700 Offset: 0x58B8700 VA: 0x58BC700
	|-VolumeParameter<bool>.GetHashCode
	|
	|-RVA: 0x58BD064 Offset: 0x58B9064 VA: 0x58BD064
	|-VolumeParameter<Color>.GetHashCode
	|
	|-RVA: 0x58BDA20 Offset: 0x58B9A20 VA: 0x58BDA20
	|-VolumeParameter<int>.GetHashCode
	|
	|-RVA: 0x58BE284 Offset: 0x58BA284 VA: 0x58BE284
	|-VolumeParameter<LayerMask>.GetHashCode
	|
	|-RVA: 0x58BEB54 Offset: 0x58BAB54 VA: 0x58BEB54
	|-VolumeParameter<object>.GetHashCode
	|
	|-RVA: 0x58BF344 Offset: 0x58BB344 VA: 0x58BF344
	|-VolumeParameter<float>.GetHashCode
	|
	|-RVA: 0x58BFBD0 Offset: 0x58BBBD0 VA: 0x58BFBD0
	|-VolumeParameter<Vector2>.GetHashCode
	|
	|-RVA: 0x58C052C Offset: 0x58BC52C VA: 0x58C052C
	|-VolumeParameter<Vector3>.GetHashCode
	|
	|-RVA: 0x58C0F30 Offset: 0x58BCF30 VA: 0x58C0F30
	|-VolumeParameter<Vector4>.GetHashCode
	|
	|-RVA: 0x58C1E1C Offset: 0x58BDE1C VA: 0x58C1E1C
	|-VolumeParameter<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC840 Offset: 0x58B8840 VA: 0x58BC840
	|-VolumeParameter<bool>.ToString
	|
	|-RVA: 0x58BD1D4 Offset: 0x58B91D4 VA: 0x58BD1D4
	|-VolumeParameter<Color>.ToString
	|
	|-RVA: 0x58BDB40 Offset: 0x58B9B40 VA: 0x58BDB40
	|-VolumeParameter<int>.ToString
	|
	|-RVA: 0x58BE3C8 Offset: 0x58BA3C8 VA: 0x58BE3C8
	|-VolumeParameter<LayerMask>.ToString
	|
	|-RVA: 0x58BEC64 Offset: 0x58BAC64 VA: 0x58BEC64
	|-VolumeParameter<object>.ToString
	|
	|-RVA: 0x58BF460 Offset: 0x58BB460 VA: 0x58BF460
	|-VolumeParameter<float>.ToString
	|
	|-RVA: 0x58BFD04 Offset: 0x58BBD04 VA: 0x58BFD04
	|-VolumeParameter<Vector2>.ToString
	|
	|-RVA: 0x58C0690 Offset: 0x58BC690 VA: 0x58C0690
	|-VolumeParameter<Vector3>.ToString
	|
	|-RVA: 0x58C10A8 Offset: 0x58BD0A8 VA: 0x58C10A8
	|-VolumeParameter<Vector4>.ToString
	|
	|-RVA: 0x58C2094 Offset: 0x58BE094 VA: 0x58C2094
	|-VolumeParameter<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(VolumeParameter<T> lhs, T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BC91C Offset: 0x58B891C VA: 0x58BC91C
	|-VolumeParameter<bool>.op_Equality
	|
	|-RVA: 0x58BD2B0 Offset: 0x58B92B0 VA: 0x58BD2B0
	|-VolumeParameter<Color>.op_Equality
	|
	|-RVA: 0x58BDC18 Offset: 0x58B9C18 VA: 0x58BDC18
	|-VolumeParameter<int>.op_Equality
	|
	|-RVA: 0x58BE4A0 Offset: 0x58BA4A0 VA: 0x58BE4A0
	|-VolumeParameter<LayerMask>.op_Equality
	|
	|-RVA: 0x58BED18 Offset: 0x58BAD18 VA: 0x58BED18
	|-VolumeParameter<object>.op_Equality
	|
	|-RVA: 0x58BF538 Offset: 0x58BB538 VA: 0x58BF538
	|-VolumeParameter<float>.op_Equality
	|
	|-RVA: 0x58BFDDC Offset: 0x58BBDDC VA: 0x58BFDDC
	|-VolumeParameter<Vector2>.op_Equality
	|
	|-RVA: 0x58C076C Offset: 0x58BC76C VA: 0x58C076C
	|-VolumeParameter<Vector3>.op_Equality
	|
	|-RVA: 0x58C1184 Offset: 0x58BD184 VA: 0x58C1184
	|-VolumeParameter<Vector4>.op_Equality
	|
	|-RVA: 0x58C21C4 Offset: 0x58BE1C4 VA: 0x58C21C4
	|-VolumeParameter<__Il2CppFullySharedGenericType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(VolumeParameter<T> lhs, T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BCA10 Offset: 0x58B8A10 VA: 0x58BCA10
	|-VolumeParameter<bool>.op_Inequality
	|
	|-RVA: 0x58BD414 Offset: 0x58B9414 VA: 0x58BD414
	|-VolumeParameter<Color>.op_Inequality
	|
	|-RVA: 0x58BDCC0 Offset: 0x58B9CC0 VA: 0x58BDCC0
	|-VolumeParameter<int>.op_Inequality
	|
	|-RVA: 0x58BE570 Offset: 0x58BA570 VA: 0x58BE570
	|-VolumeParameter<LayerMask>.op_Inequality
	|
	|-RVA: 0x58BED84 Offset: 0x58BAD84 VA: 0x58BED84
	|-VolumeParameter<object>.op_Inequality
	|
	|-RVA: 0x58BF5E8 Offset: 0x58BB5E8 VA: 0x58BF5E8
	|-VolumeParameter<float>.op_Inequality
	|
	|-RVA: 0x58BFEF0 Offset: 0x58BBEF0 VA: 0x58BFEF0
	|-VolumeParameter<Vector2>.op_Inequality
	|
	|-RVA: 0x58C08A0 Offset: 0x58BC8A0 VA: 0x58C08A0
	|-VolumeParameter<Vector3>.op_Inequality
	|
	|-RVA: 0x58C12D8 Offset: 0x58BD2D8 VA: 0x58C12D8
	|-VolumeParameter<Vector4>.op_Inequality
	|
	|-RVA: 0x58C2448 Offset: 0x58BE448 VA: 0x58C2448
	|-VolumeParameter<__Il2CppFullySharedGenericType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Equals(VolumeParameter<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BCA60 Offset: 0x58B8A60 VA: 0x58BCA60
	|-VolumeParameter<bool>.Equals
	|
	|-RVA: 0x58BD484 Offset: 0x58B9484 VA: 0x58BD484
	|-VolumeParameter<Color>.Equals
	|
	|-RVA: 0x58BDD10 Offset: 0x58B9D10 VA: 0x58BDD10
	|-VolumeParameter<int>.Equals
	|
	|-RVA: 0x58BE5C0 Offset: 0x58BA5C0 VA: 0x58BE5C0
	|-VolumeParameter<LayerMask>.Equals
	|
	|-RVA: 0x58BEDC8 Offset: 0x58BADC8 VA: 0x58BEDC8
	|-VolumeParameter<object>.Equals
	|
	|-RVA: 0x58BF638 Offset: 0x58BB638 VA: 0x58BF638
	|-VolumeParameter<float>.Equals
	|
	|-RVA: 0x58BFF48 Offset: 0x58BBF48 VA: 0x58BFF48
	|-VolumeParameter<Vector2>.Equals
	|
	|-RVA: 0x58C0908 Offset: 0x58BC908 VA: 0x58C0908
	|-VolumeParameter<Vector3>.Equals
	|
	|-RVA: 0x58C1348 Offset: 0x58BD348 VA: 0x58C1348
	|-VolumeParameter<Vector4>.Equals
	|
	|-RVA: 0x58C25E4 Offset: 0x58BE5E4 VA: 0x58C25E4
	|-VolumeParameter<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BCAC8 Offset: 0x58B8AC8 VA: 0x58BCAC8
	|-VolumeParameter<bool>.Equals
	|
	|-RVA: 0x58BD4F4 Offset: 0x58B94F4 VA: 0x58BD4F4
	|-VolumeParameter<Color>.Equals
	|
	|-RVA: 0x58BDD78 Offset: 0x58B9D78 VA: 0x58BDD78
	|-VolumeParameter<int>.Equals
	|
	|-RVA: 0x58BE628 Offset: 0x58BA628 VA: 0x58BE628
	|-VolumeParameter<LayerMask>.Equals
	|
	|-RVA: 0x58BEE30 Offset: 0x58BAE30 VA: 0x58BEE30
	|-VolumeParameter<object>.Equals
	|
	|-RVA: 0x58BF6A0 Offset: 0x58BB6A0 VA: 0x58BF6A0
	|-VolumeParameter<float>.Equals
	|
	|-RVA: 0x58BFFB0 Offset: 0x58BBFB0 VA: 0x58BFFB0
	|-VolumeParameter<Vector2>.Equals
	|
	|-RVA: 0x58C0978 Offset: 0x58BC978 VA: 0x58C0978
	|-VolumeParameter<Vector3>.Equals
	|
	|-RVA: 0x58C13B8 Offset: 0x58BD3B8 VA: 0x58C13B8
	|-VolumeParameter<Vector4>.Equals
	|
	|-RVA: 0x58C2744 Offset: 0x58BE744 VA: 0x58C2744
	|-VolumeParameter<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override object Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BCBF4 Offset: 0x58B8BF4 VA: 0x58BCBF4
	|-VolumeParameter<bool>.Clone
	|
	|-RVA: 0x58BD620 Offset: 0x58B9620 VA: 0x58BD620
	|-VolumeParameter<Color>.Clone
	|
	|-RVA: 0x58BDEA4 Offset: 0x58B9EA4 VA: 0x58BDEA4
	|-VolumeParameter<int>.Clone
	|
	|-RVA: 0x58BE754 Offset: 0x58BA754 VA: 0x58BE754
	|-VolumeParameter<LayerMask>.Clone
	|
	|-RVA: 0x58BEF5C Offset: 0x58BAF5C VA: 0x58BEF5C
	|-VolumeParameter<object>.Clone
	|
	|-RVA: 0x58BF7CC Offset: 0x58BB7CC VA: 0x58BF7CC
	|-VolumeParameter<float>.Clone
	|
	|-RVA: 0x58C00DC Offset: 0x58BC0DC VA: 0x58C00DC
	|-VolumeParameter<Vector2>.Clone
	|
	|-RVA: 0x58C0AA4 Offset: 0x58BCAA4 VA: 0x58C0AA4
	|-VolumeParameter<Vector3>.Clone
	|
	|-RVA: 0x58C14E4 Offset: 0x58BD4E4 VA: 0x58C14E4
	|-VolumeParameter<Vector4>.Clone
	|
	|-RVA: 0x58C288C Offset: 0x58BE88C VA: 0x58C288C
	|-VolumeParameter<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1
	public static T op_Explicit(VolumeParameter<T> prop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58BCC94 Offset: 0x58B8C94 VA: 0x58BCC94
	|-VolumeParameter<bool>.op_Explicit
	|
	|-RVA: 0x58BD6DC Offset: 0x58B96DC VA: 0x58BD6DC
	|-VolumeParameter<Color>.op_Explicit
	|
	|-RVA: 0x58BDF40 Offset: 0x58B9F40 VA: 0x58BDF40
	|-VolumeParameter<int>.op_Explicit
	|
	|-RVA: 0x58BE7F0 Offset: 0x58BA7F0 VA: 0x58BE7F0
	|-VolumeParameter<LayerMask>.op_Explicit
	|
	|-RVA: 0x58BF004 Offset: 0x58BB004 VA: 0x58BF004
	|-VolumeParameter<object>.op_Explicit
	|
	|-RVA: 0x58BF870 Offset: 0x58BB870 VA: 0x58BF870
	|-VolumeParameter<float>.op_Explicit
	|
	|-RVA: 0x58C0184 Offset: 0x58BC184 VA: 0x58C0184
	|-VolumeParameter<Vector2>.op_Explicit
	|
	|-RVA: 0x58C0B5C Offset: 0x58BCB5C VA: 0x58C0B5C
	|-VolumeParameter<Vector3>.op_Explicit
	|
	|-RVA: 0x58C15A0 Offset: 0x58BD5A0 VA: 0x58C15A0
	|-VolumeParameter<Vector4>.op_Explicit
	|
	|-RVA: 0x58C29B0 Offset: 0x58BE9B0 VA: 0x58C29B0
	|-VolumeParameter<__Il2CppFullySharedGenericType>.op_Explicit
	*/
}

// Namespace: 
public enum BoolParameter.DisplayType // TypeDefIndex: 20133
{
	// Fields
	public int value__; // 0x0
	public const BoolParameter.DisplayType Checkbox = 0;
	public const BoolParameter.DisplayType EnumPopup = 1;
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class BoolParameter : VolumeParameter<bool> // TypeDefIndex: 20134
{
	// Fields
	public BoolParameter.DisplayType displayType; // 0x14

	// Methods

	// RVA: 0x8601CA8 Offset: 0x85FDCA8 VA: 0x8601CA8
	public void .ctor(bool value, bool overrideState = False) { }

	// RVA: 0x8601D08 Offset: 0x85FDD08 VA: 0x8601D08
	public void .ctor(bool value, BoolParameter.DisplayType displayType, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class LayerMaskParameter : VolumeParameter<LayerMask> // TypeDefIndex: 20135
{
	// Methods

	// RVA: 0x8601D7C Offset: 0x85FDD7C VA: 0x8601D7C
	public void .ctor(LayerMask value, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class IntParameter : VolumeParameter<int> // TypeDefIndex: 20136
{
	// Methods

	// RVA: 0x8601DDC Offset: 0x85FDDDC VA: 0x8601DDC
	public void .ctor(int value, bool overrideState = False) { }

	// RVA: 0x8601E3C Offset: 0x85FDE3C VA: 0x8601E3C Slot: 16
	public sealed override void Interp(int from, int to, float t) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpIntParameter : VolumeParameter<int> // TypeDefIndex: 20137
{
	// Methods

	// RVA: 0x8601E70 Offset: 0x85FDE70 VA: 0x8601E70
	public void .ctor(int value, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class MinIntParameter : IntParameter // TypeDefIndex: 20138
{
	// Fields
	public int min; // 0x18

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x8601ED0 Offset: 0x85FDED0 VA: 0x8601ED0 Slot: 14
	public override int get_value() { }

	// RVA: 0x8601ED8 Offset: 0x85FDED8 VA: 0x8601ED8 Slot: 15
	public override void set_value(int value) { }

	// RVA: 0x8601EEC Offset: 0x85FDEEC VA: 0x8601EEC
	public void .ctor(int value, int min, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpMinIntParameter : VolumeParameter<int> // TypeDefIndex: 20139
{
	// Fields
	public int min; // 0x18

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x8601F14 Offset: 0x85FDF14 VA: 0x8601F14 Slot: 14
	public override int get_value() { }

	// RVA: 0x8601F1C Offset: 0x85FDF1C VA: 0x8601F1C Slot: 15
	public override void set_value(int value) { }

	// RVA: 0x8601F30 Offset: 0x85FDF30 VA: 0x8601F30
	public void .ctor(int value, int min, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class MaxIntParameter : IntParameter // TypeDefIndex: 20140
{
	// Fields
	public int max; // 0x18

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x8601FA4 Offset: 0x85FDFA4 VA: 0x8601FA4 Slot: 14
	public override int get_value() { }

	// RVA: 0x8601FAC Offset: 0x85FDFAC VA: 0x8601FAC Slot: 15
	public override void set_value(int value) { }

	// RVA: 0x8601FC0 Offset: 0x85FDFC0 VA: 0x8601FC0
	public void .ctor(int value, int max, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpMaxIntParameter : VolumeParameter<int> // TypeDefIndex: 20141
{
	// Fields
	public int max; // 0x18

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x8601FE8 Offset: 0x85FDFE8 VA: 0x8601FE8 Slot: 14
	public override int get_value() { }

	// RVA: 0x8601FF0 Offset: 0x85FDFF0 VA: 0x8601FF0 Slot: 15
	public override void set_value(int value) { }

	// RVA: 0x8602004 Offset: 0x85FE004 VA: 0x8602004
	public void .ctor(int value, int max, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class ClampedIntParameter : IntParameter // TypeDefIndex: 20142
{
	// Fields
	public int min; // 0x18
	public int max; // 0x1C

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x8602078 Offset: 0x85FE078 VA: 0x8602078 Slot: 14
	public override int get_value() { }

	// RVA: 0x8602080 Offset: 0x85FE080 VA: 0x8602080 Slot: 15
	public override void set_value(int value) { }

	// RVA: 0x860209C Offset: 0x85FE09C VA: 0x860209C
	public void .ctor(int value, int min, int max, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpClampedIntParameter : VolumeParameter<int> // TypeDefIndex: 20143
{
	// Fields
	public int min; // 0x18
	public int max; // 0x1C

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x86020C8 Offset: 0x85FE0C8 VA: 0x86020C8 Slot: 14
	public override int get_value() { }

	// RVA: 0x86020D0 Offset: 0x85FE0D0 VA: 0x86020D0 Slot: 15
	public override void set_value(int value) { }

	// RVA: 0x86020EC Offset: 0x85FE0EC VA: 0x86020EC
	public void .ctor(int value, int min, int max, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class FloatParameter : VolumeParameter<float> // TypeDefIndex: 20144
{
	// Methods

	// RVA: 0x8602164 Offset: 0x85FE164 VA: 0x8602164
	public void .ctor(float value, bool overrideState = False) { }

	// RVA: 0x86021CC Offset: 0x85FE1CC VA: 0x86021CC Slot: 16
	public sealed override void Interp(float from, float to, float t) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpFloatParameter : VolumeParameter<float> // TypeDefIndex: 20145
{
	// Methods

	// RVA: 0x86021E0 Offset: 0x85FE1E0 VA: 0x86021E0
	public void .ctor(float value, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class MinFloatParameter : FloatParameter // TypeDefIndex: 20146
{
	// Fields
	public float min; // 0x18

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x8602248 Offset: 0x85FE248 VA: 0x8602248 Slot: 14
	public override float get_value() { }

	// RVA: 0x8602250 Offset: 0x85FE250 VA: 0x8602250 Slot: 15
	public override void set_value(float value) { }

	// RVA: 0x8602264 Offset: 0x85FE264 VA: 0x8602264
	public void .ctor(float value, float min, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpMinFloatParameter : VolumeParameter<float> // TypeDefIndex: 20147
{
	// Fields
	public float min; // 0x18

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x860228C Offset: 0x85FE28C VA: 0x860228C Slot: 14
	public override float get_value() { }

	// RVA: 0x8602294 Offset: 0x85FE294 VA: 0x8602294 Slot: 15
	public override void set_value(float value) { }

	// RVA: 0x86022A8 Offset: 0x85FE2A8 VA: 0x86022A8
	public void .ctor(float value, float min, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class MaxFloatParameter : FloatParameter // TypeDefIndex: 20148
{
	// Fields
	public float max; // 0x18

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x860231C Offset: 0x85FE31C VA: 0x860231C Slot: 14
	public override float get_value() { }

	// RVA: 0x8602324 Offset: 0x85FE324 VA: 0x8602324 Slot: 15
	public override void set_value(float value) { }

	// RVA: 0x8602338 Offset: 0x85FE338 VA: 0x8602338
	public void .ctor(float value, float max, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpMaxFloatParameter : VolumeParameter<float> // TypeDefIndex: 20149
{
	// Fields
	public float max; // 0x18

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x8602360 Offset: 0x85FE360 VA: 0x8602360 Slot: 14
	public override float get_value() { }

	// RVA: 0x8602368 Offset: 0x85FE368 VA: 0x8602368 Slot: 15
	public override void set_value(float value) { }

	// RVA: 0x860237C Offset: 0x85FE37C VA: 0x860237C
	public void .ctor(float value, float max, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class ClampedFloatParameter : FloatParameter // TypeDefIndex: 20150
{
	// Fields
	public float min; // 0x18
	public float max; // 0x1C

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x86023F0 Offset: 0x85FE3F0 VA: 0x86023F0 Slot: 14
	public override float get_value() { }

	// RVA: 0x86023F8 Offset: 0x85FE3F8 VA: 0x86023F8 Slot: 15
	public override void set_value(float value) { }

	// RVA: 0x8602414 Offset: 0x85FE414 VA: 0x8602414
	public void .ctor(float value, float min, float max, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpClampedFloatParameter : VolumeParameter<float> // TypeDefIndex: 20151
{
	// Fields
	public float min; // 0x18
	public float max; // 0x1C

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x8602440 Offset: 0x85FE440 VA: 0x8602440 Slot: 14
	public override float get_value() { }

	// RVA: 0x8602448 Offset: 0x85FE448 VA: 0x8602448 Slot: 15
	public override void set_value(float value) { }

	// RVA: 0x8602464 Offset: 0x85FE464 VA: 0x8602464
	public void .ctor(float value, float min, float max, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class FloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 20152
{
	// Fields
	public float min; // 0x1C
	public float max; // 0x20

	// Properties
	public override Vector2 value { get; set; }

	// Methods

	// RVA: 0x86024E4 Offset: 0x85FE4E4 VA: 0x86024E4 Slot: 14
	public override Vector2 get_value() { }

	// RVA: 0x86024EC Offset: 0x85FE4EC VA: 0x86024EC Slot: 15
	public override void set_value(Vector2 value) { }

	// RVA: 0x8602508 Offset: 0x85FE508 VA: 0x8602508
	public void .ctor(Vector2 value, float min, float max, bool overrideState = False) { }

	// RVA: 0x8602590 Offset: 0x85FE590 VA: 0x8602590 Slot: 16
	public override void Interp(Vector2 from, Vector2 to, float t) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpFloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 20153
{
	// Fields
	public float min; // 0x1C
	public float max; // 0x20

	// Properties
	public override Vector2 value { get; set; }

	// Methods

	// RVA: 0x86025B0 Offset: 0x85FE5B0 VA: 0x86025B0 Slot: 14
	public override Vector2 get_value() { }

	// RVA: 0x86025B8 Offset: 0x85FE5B8 VA: 0x86025B8 Slot: 15
	public override void set_value(Vector2 value) { }

	// RVA: 0x86025D4 Offset: 0x85FE5D4 VA: 0x86025D4
	public void .ctor(Vector2 value, float min, float max, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class ColorParameter : VolumeParameter<Color> // TypeDefIndex: 20154
{
	// Fields
	public bool hdr; // 0x24
	public bool showAlpha; // 0x25
	public bool showEyeDropper; // 0x26

	// Methods

	// RVA: 0x860265C Offset: 0x85FE65C VA: 0x860265C
	public void .ctor(Color value, bool overrideState = False) { }

	// RVA: 0x86026EC Offset: 0x85FE6EC VA: 0x86026EC
	public void .ctor(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = False) { }

	// RVA: 0x86027C0 Offset: 0x85FE7C0 VA: 0x86027C0 Slot: 16
	public override void Interp(Color from, Color to, float t) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpColorParameter : VolumeParameter<Color> // TypeDefIndex: 20155
{
	// Fields
	public bool hdr; // 0x24
	public bool showAlpha; // 0x25
	public bool showEyeDropper; // 0x26

	// Methods

	// RVA: 0x86027F0 Offset: 0x85FE7F0 VA: 0x86027F0
	public void .ctor(Color value, bool overrideState = False) { }

	// RVA: 0x8602880 Offset: 0x85FE880 VA: 0x8602880
	public void .ctor(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class Vector2Parameter : VolumeParameter<Vector2> // TypeDefIndex: 20156
{
	// Methods

	// RVA: 0x8602954 Offset: 0x85FE954 VA: 0x8602954
	public void .ctor(Vector2 value, bool overrideState = False) { }

	// RVA: 0x86029C4 Offset: 0x85FE9C4 VA: 0x86029C4 Slot: 16
	public override void Interp(Vector2 from, Vector2 to, float t) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpVector2Parameter : VolumeParameter<Vector2> // TypeDefIndex: 20157
{
	// Methods

	// RVA: 0x86029E4 Offset: 0x85FE9E4 VA: 0x86029E4
	public void .ctor(Vector2 value, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class Vector3Parameter : VolumeParameter<Vector3> // TypeDefIndex: 20158
{
	// Methods

	// RVA: 0x8602A54 Offset: 0x85FEA54 VA: 0x8602A54
	public void .ctor(Vector3 value, bool overrideState = False) { }

	// RVA: 0x8602AD4 Offset: 0x85FEAD4 VA: 0x8602AD4 Slot: 16
	public override void Interp(Vector3 from, Vector3 to, float t) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpVector3Parameter : VolumeParameter<Vector3> // TypeDefIndex: 20159
{
	// Methods

	// RVA: 0x8602B04 Offset: 0x85FEB04 VA: 0x8602B04
	public void .ctor(Vector3 value, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class Vector4Parameter : VolumeParameter<Vector4> // TypeDefIndex: 20160
{
	// Methods

	// RVA: 0x8602B84 Offset: 0x85FEB84 VA: 0x8602B84
	public void .ctor(Vector4 value, bool overrideState = False) { }

	// RVA: 0x8602C0C Offset: 0x85FEC0C VA: 0x8602C0C Slot: 16
	public override void Interp(Vector4 from, Vector4 to, float t) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpVector4Parameter : VolumeParameter<Vector4> // TypeDefIndex: 20161
{
	// Methods

	// RVA: 0x8602C3C Offset: 0x85FEC3C VA: 0x8602C3C
	public void .ctor(Vector4 value, bool overrideState = False) { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class TextureParameter : VolumeParameter<Texture> // TypeDefIndex: 20162
{
	// Fields
	public TextureDimension dimension; // 0x20

	// Methods

	// RVA: 0x8602CC4 Offset: 0x85FECC4 VA: 0x8602CC4
	public void .ctor(Texture value, bool overrideState = False) { }

	// RVA: 0x8602CD0 Offset: 0x85FECD0 VA: 0x8602CD0
	public void .ctor(Texture value, TextureDimension dimension, bool overrideState = False) { }

	// RVA: 0x8602D44 Offset: 0x85FED44 VA: 0x8602D44 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpTextureParameter : VolumeParameter<Texture> // TypeDefIndex: 20163
{
	// Methods

	// RVA: 0x8602E48 Offset: 0x85FEE48 VA: 0x8602E48
	public void .ctor(Texture value, bool overrideState = False) { }

	// RVA: 0x8602EA8 Offset: 0x85FEEA8 VA: 0x8602EA8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class Texture2DParameter : VolumeParameter<Texture> // TypeDefIndex: 20164
{
	// Methods

	// RVA: 0x8602FAC Offset: 0x85FEFAC VA: 0x8602FAC
	public void .ctor(Texture value, bool overrideState = False) { }

	// RVA: 0x860300C Offset: 0x85FF00C VA: 0x860300C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class Texture3DParameter : VolumeParameter<Texture> // TypeDefIndex: 20165
{
	// Methods

	// RVA: 0x8603110 Offset: 0x85FF110 VA: 0x8603110
	public void .ctor(Texture value, bool overrideState = False) { }

	// RVA: 0x8603170 Offset: 0x85FF170 VA: 0x8603170 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class RenderTextureParameter : VolumeParameter<RenderTexture> // TypeDefIndex: 20166
{
	// Methods

	// RVA: 0x8603274 Offset: 0x85FF274 VA: 0x8603274
	public void .ctor(RenderTexture value, bool overrideState = False) { }

	// RVA: 0x86032D4 Offset: 0x85FF2D4 VA: 0x86032D4 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpRenderTextureParameter : VolumeParameter<RenderTexture> // TypeDefIndex: 20167
{
	// Methods

	// RVA: 0x86033D8 Offset: 0x85FF3D8 VA: 0x86033D8
	public void .ctor(RenderTexture value, bool overrideState = False) { }

	// RVA: 0x8603438 Offset: 0x85FF438 VA: 0x8603438 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class CubemapParameter : VolumeParameter<Texture> // TypeDefIndex: 20168
{
	// Methods

	// RVA: 0x860353C Offset: 0x85FF53C VA: 0x860353C
	public void .ctor(Texture value, bool overrideState = False) { }

	// RVA: 0x860359C Offset: 0x85FF59C VA: 0x860359C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class NoInterpCubemapParameter : VolumeParameter<Cubemap> // TypeDefIndex: 20169
{
	// Methods

	// RVA: 0x86036A0 Offset: 0x85FF6A0 VA: 0x86036A0
	public void .ctor(Cubemap value, bool overrideState = False) { }

	// RVA: 0x8603700 Offset: 0x85FF700 VA: 0x8603700 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ObjectParameter.<>c<T> // TypeDefIndex: 20170
{
	// Fields
	public static readonly ObjectParameter.<>c<T> <>9; // 0x0
	public static Func<FieldInfo, bool> <>9__9_0; // 0x0
	public static Func<FieldInfo, int> <>9__9_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4828898 Offset: 0x4824898 VA: 0x4828898
	|-ObjectParameter.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482898C Offset: 0x482498C VA: 0x482898C
	|-ObjectParameter.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <set_value>b__9_0(FieldInfo t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4828994 Offset: 0x4824994 VA: 0x4828994
	|-ObjectParameter.<>c<__Il2CppFullySharedGenericType>.<set_value>b__9_0
	*/

	// RVA: -1 Offset: -1
	internal int <set_value>b__9_1(FieldInfo t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4828A44 Offset: 0x4824A44 VA: 0x4828A44
	|-ObjectParameter.<>c<__Il2CppFullySharedGenericType>.<set_value>b__9_1
	*/
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class ObjectParameter<T> : VolumeParameter<T> // TypeDefIndex: 20171
{
	// Fields
	[CompilerGenerated]
	private ReadOnlyCollection<VolumeParameter> <parameters>k__BackingField; // 0x0

	// Properties
	internal ReadOnlyCollection<VolumeParameter> parameters { get; set; }
	public sealed override bool overrideState { get; set; }
	public sealed override T value { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal ReadOnlyCollection<VolumeParameter> get_parameters() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FC0B0 Offset: 0x51F80B0 VA: 0x51FC0B0
	|-ObjectParameter<__Il2CppFullySharedGenericType>.get_parameters
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_parameters(ReadOnlyCollection<VolumeParameter> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FC0D4 Offset: 0x51F80D4 VA: 0x51FC0D4
	|-ObjectParameter<__Il2CppFullySharedGenericType>.set_parameters
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public sealed override bool get_overrideState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FC0F0 Offset: 0x51F80F0 VA: 0x51FC0F0
	|-ObjectParameter<__Il2CppFullySharedGenericType>.get_overrideState
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public sealed override void set_overrideState(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FC0F8 Offset: 0x51F80F8 VA: 0x51FC0F8
	|-ObjectParameter<__Il2CppFullySharedGenericType>.set_overrideState
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public sealed override T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FC104 Offset: 0x51F8104 VA: 0x51FC104
	|-ObjectParameter<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public sealed override void set_value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FC19C Offset: 0x51F819C VA: 0x51FC19C
	|-ObjectParameter<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FC6CC Offset: 0x51F86CC VA: 0x51FC6CC
	|-ObjectParameter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override void Interp(VolumeParameter from, VolumeParameter to, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FC7C0 Offset: 0x51F87C0 VA: 0x51FC7C0
	|-ObjectParameter<__Il2CppFullySharedGenericType>.Interp
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private VolumeParameter <set_value>b__9_2(FieldInfo t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FCB6C Offset: 0x51F8B6C VA: 0x51FCB6C
	|-ObjectParameter<__Il2CppFullySharedGenericType>.<set_value>b__9_2
	*/
}

// Namespace: UnityEngine.Rendering
[Serializable]
public class AnimationCurveParameter : VolumeParameter<AnimationCurve> // TypeDefIndex: 20172
{
	// Methods

	// RVA: 0x8603804 Offset: 0x85FF804 VA: 0x8603804
	public void .ctor(AnimationCurve value, bool overrideState = False) { }

	// RVA: 0x8603864 Offset: 0x85FF864 VA: 0x8603864 Slot: 16
	public override void Interp(AnimationCurve lhsCurve, AnimationCurve rhsCurve, float t) { }

	// RVA: 0x86038A4 Offset: 0x85FF8A4 VA: 0x86038A4 Slot: 8
	public override void SetValue(VolumeParameter parameter) { }

	// RVA: 0x8603934 Offset: 0x85FF934 VA: 0x8603934 Slot: 12
	public override object Clone() { }

	// RVA: 0x8603A14 Offset: 0x85FFA14 VA: 0x8603A14 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Serializable]
public class MaterialParameter : VolumeParameter<Material> // TypeDefIndex: 20173
{
	// Methods

	// RVA: 0x8603AC8 Offset: 0x85FFAC8 VA: 0x8603AC8
	public void .ctor(Material value, bool overrideState = False) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VolumeProfile.<>c // TypeDefIndex: 20174
{
	// Fields
	public static readonly VolumeProfile.<>c <>9; // 0x0
	public static Predicate<VolumeComponent> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x86045EC Offset: 0x86005EC VA: 0x86045EC
	private static void .cctor() { }

	// RVA: 0x8604654 Offset: 0x8600654 VA: 0x8604654
	public void .ctor() { }

	// RVA: 0x860465C Offset: 0x860065C VA: 0x860465C
	internal bool <OnEnable>b__2_0(VolumeComponent x) { }
}

// Namespace: UnityEngine.Rendering
public sealed class VolumeProfile : ScriptableObject // TypeDefIndex: 20175
{
	// Fields
	public List<VolumeComponent> components; // 0x18
	public bool isDirty; // 0x20

	// Methods

	// RVA: 0x8603B28 Offset: 0x85FFB28 VA: 0x8603B28
	private void OnEnable() { }

	// RVA: 0x8603C2C Offset: 0x85FFC2C VA: 0x8603C2C
	internal void OnDisable() { }

	// RVA: 0x8603D10 Offset: 0x85FFD10 VA: 0x8603D10
	public void Reset() { }

	// RVA: -1 Offset: -1
	public T Add<T>(bool overrides = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x478235C Offset: 0x477E35C VA: 0x478235C
	|-VolumeProfile.Add<object>
	*/

	// RVA: 0x8603D1C Offset: 0x85FFD1C VA: 0x8603D1C
	public VolumeComponent Add(Type type, bool overrides = False) { }

	// RVA: -1 Offset: -1
	public void Remove<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47824A4 Offset: 0x477E4A4 VA: 0x47824A4
	|-VolumeProfile.Remove<object>
	*/

	// RVA: 0x8604058 Offset: 0x8600058 VA: 0x8604058
	public void Remove(Type type) { }

	// RVA: -1 Offset: -1
	public bool Has<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x478242C Offset: 0x477E42C VA: 0x478242C
	|-VolumeProfile.Has<object>
	*/

	// RVA: 0x8603EA4 Offset: 0x85FFEA4 VA: 0x8603EA4
	public bool Has(Type type) { }

	// RVA: 0x8604170 Offset: 0x8600170 VA: 0x8604170
	public bool HasSubclassOf(Type type) { }

	// RVA: -1 Offset: -1
	public bool TryGet<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x478251C Offset: 0x477E51C VA: 0x478251C
	|-VolumeProfile.TryGet<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGet<T>(Type type, out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47825A8 Offset: 0x477E5A8 VA: 0x47825A8
	|-VolumeProfile.TryGet<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetSubclassOf<T>(Type type, out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4782A7C Offset: 0x477EA7C VA: 0x4782A7C
	|-VolumeProfile.TryGetSubclassOf<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetAllSubclassOf<T>(Type type, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4782820 Offset: 0x477E820 VA: 0x4782820
	|-VolumeProfile.TryGetAllSubclassOf<object>
	*/

	// RVA: 0x8604300 Offset: 0x8600300 VA: 0x8604300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x86043AC Offset: 0x86003AC VA: 0x86043AC
	internal int GetComponentListHashCode() { }

	// RVA: 0x8604464 Offset: 0x8600464 VA: 0x8604464
	internal void Sanitize() { }

	// RVA: 0x860455C Offset: 0x860055C VA: 0x860455C
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public sealed class VolumeStack : IDisposable // TypeDefIndex: 20176
{
	// Fields
	internal readonly Dictionary<Type, VolumeComponent> components; // 0x10
	[TupleElementNames(new[] { "parameter", "defaultValue" })]
	internal ValueTuple<VolumeParameter, VolumeParameter>[] defaultParameters; // 0x18
	internal bool requiresReset; // 0x20

	// Methods

	// RVA: 0x86005A8 Offset: 0x85FC5A8 VA: 0x86005A8
	internal void .ctor() { }

	// RVA: 0x86046B8 Offset: 0x86006B8 VA: 0x86046B8
	internal void Clear() { }

	// RVA: 0x8600638 Offset: 0x85FC638 VA: 0x8600638
	internal void Reload(List<VolumeComponent> componentDefaultStates) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4782CCC Offset: 0x477ECCC VA: 0x4782CCC
	|-VolumeStack.GetComponent<object>
	*/

	// RVA: 0x8600BE4 Offset: 0x85FCBE4 VA: 0x8600BE4
	public VolumeComponent GetComponent(Type type) { }

	// RVA: 0x8600AFC Offset: 0x85FCAFC VA: 0x8600AFC Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine.Rendering
public static class XRGraphicsAutomatedTests // TypeDefIndex: 20177
{
	// Fields
	[CompilerGenerated]
	private static readonly bool <enabled>k__BackingField; // 0x0
	public static bool running; // 0x1

	// Properties
	private static bool activatedFromCommandLine { get; }
	public static bool enabled { get; }

	// Methods

	// RVA: 0x86048E0 Offset: 0x86008E0 VA: 0x86048E0
	private static bool get_activatedFromCommandLine() { }

	[CompilerGenerated]
	// RVA: 0x86048E8 Offset: 0x86008E8 VA: 0x86048E8
	public static bool get_enabled() { }

	// RVA: 0x8604940 Offset: 0x8600940 VA: 0x8604940
	internal static void OverrideLayout(XRLayout layout, Camera camera) { }

	// RVA: 0x8604E00 Offset: 0x8600E00 VA: 0x8604E00
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering.LookDev
public interface IDataProvider // TypeDefIndex: 20178
{
	// Properties
	public abstract IEnumerable<string> supportedDebugModes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FirstInitScene(StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UpdateSky(Camera camera, Sky sky, StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<string> get_supportedDebugModes();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UpdateDebugMode(int debugIndex);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void GetShadowMask(ref RenderTexture output, StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBeginRendering(StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnEndRendering(StageRuntimeInterface stage);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Cleanup(StageRuntimeInterface SRI);
}

// Namespace: UnityEngine.Rendering.LookDev
public struct Sky // TypeDefIndex: 20179
{
	// Fields
	public Cubemap cubemap; // 0x0
	public float longitudeOffset; // 0x8
	public float exposure; // 0xC
}

// Namespace: UnityEngine.Rendering.LookDev
public class StageRuntimeInterface // TypeDefIndex: 20180
{
	// Fields
	private Func<bool, GameObject> m_AddGameObject; // 0x10
	private Func<Camera> m_GetCamera; // 0x18
	private Func<Light> m_GetSunLight; // 0x20
	public object SRPData; // 0x28

	// Properties
	public Camera camera { get; }
	public Light sunLight { get; }

	// Methods

	// RVA: 0x8604E48 Offset: 0x8600E48 VA: 0x8604E48
	public void .ctor(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight) { }

	// RVA: 0x8604EA8 Offset: 0x8600EA8 VA: 0x8604EA8
	public GameObject AddGameObject(bool persistent = False) { }

	// RVA: 0x8604ECC Offset: 0x8600ECC VA: 0x8604ECC
	public Camera get_camera() { }

	// RVA: 0x8604EEC Offset: 0x8600EEC VA: 0x8604EEC
	public Light get_sunLight() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerBitField : DebugUIHandlerWidget // TypeDefIndex: 20181
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public List<DebugUIHandlerIndirectToggle> toggles; // 0x70
	private DebugUI.BitField m_Field; // 0x78
	private DebugUIHandlerContainer m_Container; // 0x80

	// Methods

	// RVA: 0x8604F0C Offset: 0x8600F0C VA: 0x8604F0C Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x8605354 Offset: 0x8601354 VA: 0x8605354
	private bool GetValue(int index) { }

	// RVA: 0x86053FC Offset: 0x86013FC VA: 0x86053FC
	private void SetValue(int index, bool value) { }

	// RVA: 0x8605758 Offset: 0x8601758 VA: 0x8605758 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x86059D8 Offset: 0x86019D8 VA: 0x86059D8 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x8605A08 Offset: 0x8601A08 VA: 0x8605A08 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x8605A28 Offset: 0x8601A28 VA: 0x8605A28 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x8605A48 Offset: 0x8601A48 VA: 0x8605A48 Slot: 8
	public override void OnAction() { }

	// RVA: 0x8605A70 Offset: 0x8601A70 VA: 0x8605A70 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x8605BCC Offset: 0x8601BCC VA: 0x8605BCC
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerButton : DebugUIHandlerWidget // TypeDefIndex: 20182
{
	// Fields
	public Text nameLabel; // 0x60
	private DebugUI.Button m_Field; // 0x68

	// Methods

	// RVA: 0x8605BD4 Offset: 0x8601BD4 VA: 0x8605BD4 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x8605C70 Offset: 0x8601C70 VA: 0x8605C70 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x8605CA8 Offset: 0x8601CA8 VA: 0x8605CA8 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x8605CD8 Offset: 0x8601CD8 VA: 0x8605CD8 Slot: 8
	public override void OnAction() { }

	// RVA: 0x8605D0C Offset: 0x8601D0C VA: 0x8605D0C
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
[Serializable]
public class DebugUIPrefabBundle // TypeDefIndex: 20183
{
	// Fields
	public string type; // 0x10
	public RectTransform prefab; // 0x18

	// Methods

	// RVA: 0x8605D14 Offset: 0x8601D14 VA: 0x8605D14
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DebugUIHandlerCanvas.<>c // TypeDefIndex: 20184
{
	// Fields
	public static readonly DebugUIHandlerCanvas.<>c <>9; // 0x0
	public static Func<DebugUI.Widget, bool> <>9__12_0; // 0x8
	public static Action<DebugUIHandlerPanel> <>9__15_0; // 0x10

	// Methods

	// RVA: 0x8607FC0 Offset: 0x8603FC0 VA: 0x8607FC0
	private static void .cctor() { }

	// RVA: 0x8608028 Offset: 0x8604028 VA: 0x8608028
	public void .ctor() { }

	// RVA: 0x8608030 Offset: 0x8604030 VA: 0x8608030
	internal bool <Rebuild>b__12_0(DebugUI.Widget x) { }

	// RVA: 0x8608074 Offset: 0x8604074 VA: 0x8608074
	internal void <ActivatePanel>b__15_0(DebugUIHandlerPanel p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugUIHandlerCanvas.<>c__DisplayClass14_0 // TypeDefIndex: 20185
{
	// Fields
	public string queryPath; // 0x10

	// Methods

	// RVA: 0x86078D4 Offset: 0x86038D4 VA: 0x86078D4
	public void .ctor() { }

	// RVA: 0x86080A0 Offset: 0x86040A0 VA: 0x86080A0
	internal bool <GetWidgetFromPath>b__0(DebugUIHandlerWidget w) { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerCanvas : MonoBehaviour // TypeDefIndex: 20186
{
	// Fields
	private int m_DebugTreeState; // 0x20
	private Dictionary<Type, Transform> m_PrefabsMap; // 0x28
	public Transform panelPrefab; // 0x30
	public List<DebugUIPrefabBundle> prefabs; // 0x38
	private List<DebugUIHandlerPanel> m_UIPanels; // 0x40
	private int m_SelectedPanel; // 0x48
	private DebugUIHandlerWidget m_SelectedWidget; // 0x50
	private string m_CurrentQueryPath; // 0x58

	// Methods

	// RVA: 0x8605D1C Offset: 0x8601D1C VA: 0x8605D1C
	private void OnEnable() { }

	// RVA: 0x8605E94 Offset: 0x8601E94 VA: 0x8605E94
	private void Update() { }

	// RVA: 0x8606654 Offset: 0x8602654 VA: 0x8606654
	internal void RequestHierarchyReset() { }

	// RVA: 0x8605FBC Offset: 0x8601FBC VA: 0x8605FBC
	private void ResetAllHierarchy() { }

	// RVA: 0x8606660 Offset: 0x8602660 VA: 0x8606660
	private void Rebuild() { }

	// RVA: 0x86070C4 Offset: 0x86030C4 VA: 0x86070C4
	private void Traverse(DebugUI.IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler, ref DebugUIHandlerWidget selectedHandler) { }

	// RVA: 0x8607780 Offset: 0x8603780 VA: 0x8607780
	private DebugUIHandlerWidget GetWidgetFromPath(string queryPath) { }

	// RVA: 0x860757C Offset: 0x860357C VA: 0x860757C
	private void ActivatePanel(int index, DebugUIHandlerWidget selectedWidget) { }

	// RVA: 0x8607930 Offset: 0x8603930 VA: 0x8607930
	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	// RVA: 0x8607C8C Offset: 0x8603C8C VA: 0x8607C8C
	internal void SelectPreviousItem() { }

	// RVA: 0x8607D50 Offset: 0x8603D50 VA: 0x8607D50
	internal void SelectNextPanel() { }

	// RVA: 0x8607DC4 Offset: 0x8603DC4 VA: 0x8607DC4
	internal void SelectPreviousPanel() { }

	// RVA: 0x8607BC8 Offset: 0x8603BC8 VA: 0x8607BC8
	internal void SelectNextItem() { }

	// RVA: 0x8607E44 Offset: 0x8603E44 VA: 0x8607E44
	private void ChangeSelectionValue(float multiplier) { }

	// RVA: 0x8607F30 Offset: 0x8603F30 VA: 0x8607F30
	private void ActivateSelection() { }

	// RVA: 0x86062C8 Offset: 0x86022C8 VA: 0x86062C8
	private void HandleInput() { }

	// RVA: 0x8607ADC Offset: 0x8603ADC VA: 0x8607ADC
	internal void SetScrollTarget(DebugUIHandlerWidget widget) { }

	// RVA: 0x8607FB8 Offset: 0x8603FB8 VA: 0x8607FB8
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerColor : DebugUIHandlerWidget // TypeDefIndex: 20187
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public Image colorImage; // 0x70
	public DebugUIHandlerIndirectFloatField fieldR; // 0x78
	public DebugUIHandlerIndirectFloatField fieldG; // 0x80
	public DebugUIHandlerIndirectFloatField fieldB; // 0x88
	public DebugUIHandlerIndirectFloatField fieldA; // 0x90
	private DebugUI.ColorField m_Field; // 0x98
	private DebugUIHandlerContainer m_Container; // 0xA0

	// Methods

	// RVA: 0x86080CC Offset: 0x86040CC VA: 0x86080CC Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x86086E8 Offset: 0x86046E8 VA: 0x86086E8
	private void SetValue(float x, bool r = False, bool g = False, bool b = False, bool a = False) { }

	// RVA: 0x8608504 Offset: 0x8604504 VA: 0x8608504
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x86087A8 Offset: 0x86047A8 VA: 0x86087A8 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860888C Offset: 0x860488C VA: 0x860888C Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x86088BC Offset: 0x86048BC VA: 0x86088BC Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x86088DC Offset: 0x86048DC VA: 0x86088DC Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x86088FC Offset: 0x86048FC VA: 0x86088FC Slot: 8
	public override void OnAction() { }

	// RVA: 0x8608634 Offset: 0x8604634 VA: 0x8608634
	internal void UpdateColor() { }

	// RVA: 0x8608924 Offset: 0x8604924 VA: 0x8608924 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x86089F0 Offset: 0x86049F0 VA: 0x86089F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x86089F8 Offset: 0x86049F8 VA: 0x86089F8
	private float <SetWidget>b__9_0() { }

	[CompilerGenerated]
	// RVA: 0x8608A48 Offset: 0x8604A48 VA: 0x8608A48
	private void <SetWidget>b__9_1(float x) { }

	[CompilerGenerated]
	// RVA: 0x8608A5C Offset: 0x8604A5C VA: 0x8608A5C
	private float <SetWidget>b__9_2() { }

	[CompilerGenerated]
	// RVA: 0x8608AB4 Offset: 0x8604AB4 VA: 0x8608AB4
	private void <SetWidget>b__9_3(float x) { }

	[CompilerGenerated]
	// RVA: 0x8608AC8 Offset: 0x8604AC8 VA: 0x8608AC8
	private float <SetWidget>b__9_4() { }

	[CompilerGenerated]
	// RVA: 0x8608B20 Offset: 0x8604B20 VA: 0x8608B20
	private void <SetWidget>b__9_5(float x) { }

	[CompilerGenerated]
	// RVA: 0x8608B34 Offset: 0x8604B34 VA: 0x8608B34
	private float <SetWidget>b__9_6() { }

	[CompilerGenerated]
	// RVA: 0x8608B8C Offset: 0x8604B8C VA: 0x8608B8C
	private void <SetWidget>b__9_7(float x) { }

	[CompilerGenerated]
	// RVA: 0x8608BA0 Offset: 0x8604BA0 VA: 0x8608BA0
	private float <SetupSettings>b__11_0() { }

	[CompilerGenerated]
	// RVA: 0x8608BBC Offset: 0x8604BBC VA: 0x8608BBC
	private float <SetupSettings>b__11_1() { }

	[CompilerGenerated]
	// RVA: 0x8608BD8 Offset: 0x8604BD8 VA: 0x8608BD8
	private float <SetupSettings>b__11_2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugUIHandlerContainer.<>c__DisplayClass3_0 // TypeDefIndex: 20188
{
	// Fields
	public DebugUIHandlerWidget widget; // 0x10

	// Methods

	// RVA: 0x8609024 Offset: 0x8605024 VA: 0x8609024
	public void .ctor() { }

	// RVA: 0x8609034 Offset: 0x8605034 VA: 0x8609034
	internal bool <IsDirectChild>b__0(DebugUIHandlerWidget x) { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerContainer : MonoBehaviour // TypeDefIndex: 20189
{
	// Fields
	[SerializeField]
	public RectTransform contentHolder; // 0x20

	// Methods

	// RVA: 0x8605B3C Offset: 0x8601B3C VA: 0x8605B3C
	internal DebugUIHandlerWidget GetFirstItem() { }

	// RVA: 0x8605948 Offset: 0x8601948 VA: 0x8605948
	internal DebugUIHandlerWidget GetLastItem() { }

	// RVA: 0x860583C Offset: 0x860183C VA: 0x860583C
	internal bool IsDirectChild(DebugUIHandlerWidget widget) { }

	// RVA: 0x8608BF8 Offset: 0x8604BF8 VA: 0x8608BF8
	private List<DebugUIHandlerWidget> GetActiveChildren() { }

	// RVA: 0x860902C Offset: 0x860502C VA: 0x860902C
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerEnumField : DebugUIHandlerField<DebugUI.EnumField> // TypeDefIndex: 20190
{
	// Methods

	// RVA: 0x86090A0 Offset: 0x86050A0 VA: 0x86090A0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x8609214 Offset: 0x8605214 VA: 0x8609214 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x86093B8 Offset: 0x86053B8 VA: 0x86093B8 Slot: 13
	public override void UpdateValueLabel() { }

	// RVA: 0x8609450 Offset: 0x8605450 VA: 0x8609450
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugUIHandlerEnumHistory.<RefreshAfterSanitization>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 20191
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DebugUIHandlerEnumHistory <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x86099CC Offset: 0x86059CC VA: 0x86099CC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x86099F8 Offset: 0x86059F8 VA: 0x86099F8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x86099FC Offset: 0x86059FC VA: 0x86099FC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x8609AEC Offset: 0x8605AEC VA: 0x8609AEC Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x8609AF4 Offset: 0x8605AF4 VA: 0x8609AF4 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x8609B2C Offset: 0x8605B2C VA: 0x8609B2C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField // TypeDefIndex: 20192
{
	// Fields
	private Text[] historyValues; // 0x88
	private const float k_XOffset = 230;

	// Methods

	// RVA: 0x8609498 Offset: 0x8605498 VA: 0x8609498 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x8609744 Offset: 0x8605744 VA: 0x8609744 Slot: 13
	public override void UpdateValueLabel() { }

	[IteratorStateMachine(typeof(DebugUIHandlerEnumHistory.<RefreshAfterSanitization>d__4))]
	// RVA: 0x8609960 Offset: 0x8605960 VA: 0x8609960
	private IEnumerator RefreshAfterSanitization() { }

	// RVA: 0x86099F4 Offset: 0x86059F4 VA: 0x86099F4
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public abstract class DebugUIHandlerField<T> : DebugUIHandlerWidget // TypeDefIndex: 20193
{
	// Fields
	public Text nextButtonText; // 0x0
	public Text previousButtonText; // 0x0
	public Text nameLabel; // 0x0
	public Text valueLabel; // 0x0
	protected internal T m_Field; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1F7DC Offset: 0x5D1B7DC VA: 0x5D1F7DC
	|-DebugUIHandlerField<object>.SetWidget
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1F864 Offset: 0x5D1B864 VA: 0x5D1F864
	|-DebugUIHandlerField<object>.OnSelection
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void OnDeselection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1F97C Offset: 0x5D1B97C VA: 0x5D1F97C
	|-DebugUIHandlerField<object>.OnDeselection
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnAction() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1FA8C Offset: 0x5D1BA8C VA: 0x5D1FA8C
	|-DebugUIHandlerField<object>.OnAction
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateValueLabel();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-DebugUIHandlerField<object>.UpdateValueLabel
	*/

	// RVA: -1 Offset: -1
	protected void SetLabelText(string text) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1FAAC Offset: 0x5D1BAAC VA: 0x5D1FAAC
	|-DebugUIHandlerField<object>.SetLabelText
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1FB40 Offset: 0x5D1BB40 VA: 0x5D1FB40
	|-DebugUIHandlerField<object>..ctor
	*/
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerFloatField : DebugUIHandlerWidget // TypeDefIndex: 20194
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	private DebugUI.FloatField m_Field; // 0x70

	// Methods

	// RVA: 0x8609B34 Offset: 0x8605B34 VA: 0x8609B34 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x8609CA0 Offset: 0x8605CA0 VA: 0x8609CA0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x8609CF8 Offset: 0x8605CF8 VA: 0x8609CF8 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x8609D48 Offset: 0x8605D48 VA: 0x8609D48 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x8609DF0 Offset: 0x8605DF0 VA: 0x8609DF0 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x8609D54 Offset: 0x8605D54 VA: 0x8609D54
	private void ChangeValue(bool fast, float multiplier) { }

	// RVA: 0x8609BDC Offset: 0x8605BDC VA: 0x8609BDC
	private void UpdateValueLabel() { }

	// RVA: 0x8609DFC Offset: 0x8605DFC VA: 0x8609DFC
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerFoldout : DebugUIHandlerWidget // TypeDefIndex: 20195
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	private DebugUI.Foldout m_Field; // 0x70
	private DebugUIHandlerContainer m_Container; // 0x78
	private const float k_FoldoutXOffset = 215;
	private const float k_XOffset = 230;

	// Methods

	// RVA: 0x8609E04 Offset: 0x8605E04 VA: 0x8609E04 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860A19C Offset: 0x860619C VA: 0x860A19C Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860A280 Offset: 0x8606280 VA: 0x860A280 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860A2B0 Offset: 0x86062B0 VA: 0x860A2B0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x860A2D0 Offset: 0x86062D0 VA: 0x860A2D0 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x860A2EC Offset: 0x86062EC VA: 0x860A2EC Slot: 8
	public override void OnAction() { }

	// RVA: 0x860A174 Offset: 0x8606174 VA: 0x860A174
	private void UpdateValue() { }

	// RVA: 0x860A310 Offset: 0x8606310 VA: 0x860A310 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x860A3DC Offset: 0x86063DC VA: 0x860A3DC
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerGroup : DebugUIHandlerWidget // TypeDefIndex: 20196
{
	// Fields
	public Text nameLabel; // 0x60
	public Transform header; // 0x68
	private DebugUI.Container m_Field; // 0x70
	private DebugUIHandlerContainer m_Container; // 0x78

	// Methods

	// RVA: 0x860A3E4 Offset: 0x86063E4 VA: 0x860A3E4 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860A4F4 Offset: 0x86064F4 VA: 0x860A4F4 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860A5AC Offset: 0x86065AC VA: 0x860A5AC Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x860A668 Offset: 0x8606668 VA: 0x860A668
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerHBox : DebugUIHandlerWidget // TypeDefIndex: 20197
{
	// Fields
	private DebugUIHandlerContainer m_Container; // 0x60

	// Methods

	// RVA: 0x860A670 Offset: 0x8606670 VA: 0x860A670 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860A6E4 Offset: 0x86066E4 VA: 0x860A6E4 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860A79C Offset: 0x860679C VA: 0x860A79C Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x860A858 Offset: 0x8606858 VA: 0x860A858
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget // TypeDefIndex: 20198
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	public Func<float> getter; // 0x70
	public Action<float> setter; // 0x78
	public Func<float> incStepGetter; // 0x80
	public Func<float> incStepMultGetter; // 0x88
	public Func<float> decimalsGetter; // 0x90

	// Methods

	// RVA: 0x86087A4 Offset: 0x86047A4 VA: 0x86087A4
	public void Init() { }

	// RVA: 0x860A970 Offset: 0x8606970 VA: 0x860A970 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860A9C8 Offset: 0x86069C8 VA: 0x860A9C8 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860AA18 Offset: 0x8606A18 VA: 0x860AA18 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x860AAD8 Offset: 0x8606AD8 VA: 0x860AAD8 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x860AA24 Offset: 0x8606A24 VA: 0x860AA24
	private void ChangeValue(bool fast, float multiplier) { }

	// RVA: 0x860A860 Offset: 0x8606860 VA: 0x860A860
	private void UpdateValueLabel() { }

	// RVA: 0x860AAE4 Offset: 0x8606AE4 VA: 0x860AAE4
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget // TypeDefIndex: 20199
{
	// Fields
	public Text nameLabel; // 0x60
	public Toggle valueToggle; // 0x68
	public Image checkmarkImage; // 0x70
	public Func<int, bool> getter; // 0x78
	public Action<int, bool> setter; // 0x80
	internal int index; // 0x88

	// Methods

	// RVA: 0x86052A8 Offset: 0x86012A8 VA: 0x86052A8
	public void Init() { }

	// RVA: 0x860AAEC Offset: 0x8606AEC VA: 0x860AAEC
	private void OnToggleValueChanged(bool value) { }

	// RVA: 0x860AB1C Offset: 0x8606B1C VA: 0x860AB1C Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860AB74 Offset: 0x8606B74 VA: 0x860AB74 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860ABC4 Offset: 0x8606BC4 VA: 0x860ABC4 Slot: 8
	public override void OnAction() { }

	// RVA: 0x86056B0 Offset: 0x86016B0 VA: 0x86056B0
	internal void UpdateValueLabel() { }

	// RVA: 0x860AC20 Offset: 0x8606C20 VA: 0x860AC20
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerIntField : DebugUIHandlerWidget // TypeDefIndex: 20200
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	private DebugUI.IntField m_Field; // 0x70

	// Methods

	// RVA: 0x860AC28 Offset: 0x8606C28 VA: 0x860AC28 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860ADB0 Offset: 0x8606DB0 VA: 0x860ADB0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860AE08 Offset: 0x8606E08 VA: 0x860AE08 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860AE58 Offset: 0x8606E58 VA: 0x860AE58 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x860AF04 Offset: 0x8606F04 VA: 0x860AF04 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x860AE64 Offset: 0x8606E64 VA: 0x860AE64
	private void ChangeValue(bool fast, int multiplier) { }

	// RVA: 0x860ACD0 Offset: 0x8606CD0 VA: 0x860ACD0
	private void UpdateValueLabel() { }

	// RVA: 0x860AF10 Offset: 0x8606F10 VA: 0x860AF10
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerMessageBox : DebugUIHandlerWidget // TypeDefIndex: 20201
{
	// Fields
	public Text nameLabel; // 0x60
	private DebugUI.MessageBox m_Field; // 0x68
	private static Color32 k_WarningBackgroundColor; // 0x0
	private static Color32 k_WarningTextColor; // 0x4
	private static Color32 k_ErrorBackgroundColor; // 0x8
	private static Color32 k_ErrorTextColor; // 0xC

	// Methods

	// RVA: 0x860AF18 Offset: 0x8606F18 VA: 0x860AF18 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860B0B4 Offset: 0x86070B4 VA: 0x860B0B4 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860B0BC Offset: 0x86070BC VA: 0x860B0BC
	public void .ctor() { }

	// RVA: 0x860B0C4 Offset: 0x86070C4 VA: 0x860B0C4
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerObject : DebugUIHandlerWidget // TypeDefIndex: 20202
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68

	// Methods

	// RVA: 0x860B14C Offset: 0x860714C VA: 0x860B14C Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860B224 Offset: 0x8607224 VA: 0x860B224 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860B27C Offset: 0x860727C VA: 0x860B27C Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860B2CC Offset: 0x86072CC VA: 0x860B2CC
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerObjectList : DebugUIHandlerField<DebugUI.ObjectListField> // TypeDefIndex: 20203
{
	// Fields
	private int m_Index; // 0x88

	// Methods

	// RVA: 0x860B2D4 Offset: 0x86072D4 VA: 0x860B2D4 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860B334 Offset: 0x8607334 VA: 0x860B334 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x860B350 Offset: 0x8607350 VA: 0x860B350 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x860B36C Offset: 0x860736C VA: 0x860B36C Slot: 13
	public override void UpdateValueLabel() { }

	// RVA: 0x860B4DC Offset: 0x86074DC VA: 0x860B4DC
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerObjectPopupField : DebugUIHandlerField<DebugUI.ObjectPopupField> // TypeDefIndex: 20204
{
	// Fields
	private int m_Index; // 0x88

	// Methods

	// RVA: 0x860B524 Offset: 0x8607524 VA: 0x860B524 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860B584 Offset: 0x8607584 VA: 0x860B584
	private void ChangeSelectedObject() { }

	// RVA: 0x860B684 Offset: 0x8607684 VA: 0x860B684 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x860B694 Offset: 0x8607694 VA: 0x860B694 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x860B6A4 Offset: 0x86076A4 VA: 0x860B6A4 Slot: 13
	public override void UpdateValueLabel() { }

	// RVA: 0x860B784 Offset: 0x8607784 VA: 0x860B784
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerPanel : MonoBehaviour // TypeDefIndex: 20205
{
	// Fields
	public Text nameLabel; // 0x20
	public ScrollRect scrollRect; // 0x28
	public RectTransform viewport; // 0x30
	public DebugUIHandlerCanvas Canvas; // 0x38
	private RectTransform m_ScrollTransform; // 0x40
	private RectTransform m_ContentTransform; // 0x48
	private RectTransform m_MaskTransform; // 0x50
	private DebugUIHandlerWidget m_ScrollTarget; // 0x58
	protected internal DebugUI.Panel m_Panel; // 0x60

	// Methods

	// RVA: 0x860B7CC Offset: 0x86077CC VA: 0x860B7CC
	private void OnEnable() { }

	// RVA: 0x860707C Offset: 0x860307C VA: 0x860707C
	internal void SetPanel(DebugUI.Panel panel) { }

	// RVA: 0x860B8A0 Offset: 0x86078A0 VA: 0x860B8A0
	internal DebugUI.Panel GetPanel() { }

	// RVA: 0x860B8A8 Offset: 0x86078A8 VA: 0x860B8A8
	public void SelectNextItem() { }

	// RVA: 0x860B8C0 Offset: 0x86078C0 VA: 0x860B8C0
	public void SelectPreviousItem() { }

	// RVA: 0x860B8D8 Offset: 0x86078D8 VA: 0x860B8D8
	public void OnScrollbarClicked() { }

	// RVA: 0x860B93C Offset: 0x860793C VA: 0x860B93C
	internal void SetScrollTarget(DebugUIHandlerWidget target) { }

	// RVA: 0x86064DC Offset: 0x86024DC VA: 0x86064DC
	internal void UpdateScroll() { }

	// RVA: 0x860B944 Offset: 0x8607944 VA: 0x860B944
	private float GetYPosInScroll(RectTransform target) { }

	// RVA: 0x86078DC Offset: 0x86038DC VA: 0x86078DC
	internal DebugUIHandlerWidget GetFirstItem() { }

	// RVA: 0x860BA30 Offset: 0x8607A30 VA: 0x860BA30
	public void ResetDebugManager() { }

	// RVA: 0x860BA90 Offset: 0x8607A90 VA: 0x860BA90
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugUIHandlerPersistentCanvas.<>c__DisplayClass3_0 // TypeDefIndex: 20206
{
	// Fields
	public DebugUI.Value widget; // 0x10

	// Methods

	// RVA: 0x860BD8C Offset: 0x8607D8C VA: 0x860BD8C
	public void .ctor() { }

	// RVA: 0x860C414 Offset: 0x8608414 VA: 0x860C414
	internal bool <Toggle>b__0(DebugUIHandlerValue x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugUIHandlerPersistentCanvas.<>c__DisplayClass5_0 // TypeDefIndex: 20207
{
	// Fields
	public DebugUI.ValueTuple widget; // 0x10

	// Methods

	// RVA: 0x860C12C Offset: 0x860812C VA: 0x860C12C
	public void .ctor() { }

	// RVA: 0x860C438 Offset: 0x8608438 VA: 0x860C438
	internal bool <Toggle>b__0(DebugUI.ValueTuple x) { }
}

// Namespace: UnityEngine.Rendering.UI
internal class DebugUIHandlerPersistentCanvas : MonoBehaviour // TypeDefIndex: 20208
{
	// Fields
	public RectTransform panel; // 0x20
	public RectTransform valuePrefab; // 0x28
	private List<DebugUIHandlerValue> m_Items; // 0x30
	private List<DebugUI.ValueTuple> m_ValueTupleWidgets; // 0x38

	// Methods

	// RVA: 0x860BA98 Offset: 0x8607A98 VA: 0x860BA98
	internal void Toggle(DebugUI.Value widget, string displayName) { }

	// RVA: 0x860BD94 Offset: 0x8607D94 VA: 0x860BD94
	internal void Toggle(DebugUI.ValueTuple widget, Nullable<int> forceTupleIndex) { }

	// RVA: 0x860C134 Offset: 0x8608134 VA: 0x860C134
	internal bool IsEmpty() { }

	// RVA: 0x860C184 Offset: 0x8608184 VA: 0x860C184
	internal void Clear() { }

	// RVA: 0x860C338 Offset: 0x8608338 VA: 0x860C338
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerProgressBar : DebugUIHandlerWidget // TypeDefIndex: 20209
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	public RectTransform progressBarRect; // 0x70
	private DebugUI.ProgressBarValue m_Value; // 0x78
	private float m_Timer; // 0x80

	// Methods

	// RVA: 0x860C448 Offset: 0x8608448 VA: 0x860C448 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x860C450 Offset: 0x8608450 VA: 0x860C450 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860C604 Offset: 0x8608604 VA: 0x860C604 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860C63C Offset: 0x860863C VA: 0x860C63C Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860C66C Offset: 0x860866C VA: 0x860C66C
	private void Update() { }

	// RVA: 0x860C4F8 Offset: 0x86084F8 VA: 0x860C4F8
	private void UpdateValue() { }

	// RVA: 0x860C6D0 Offset: 0x86086D0 VA: 0x860C6D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerRow : DebugUIHandlerFoldout // TypeDefIndex: 20210
{
	// Fields
	private float m_Timer; // 0x80

	// Methods

	// RVA: 0x860C6D8 Offset: 0x86086D8 VA: 0x860C6D8 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x860C6E0 Offset: 0x86086E0 VA: 0x860C6E0
	private GameObject GetChild(int index) { }

	// RVA: 0x860C810 Offset: 0x8608810 VA: 0x860C810
	private bool TryGetChild(int index, out GameObject child) { }

	// RVA: 0x860C89C Offset: 0x860889C VA: 0x860C89C
	private bool IsActive(DebugUI.Table table, int index, GameObject child) { }

	// RVA: 0x860C9D0 Offset: 0x86089D0 VA: 0x860C9D0
	protected void Update() { }

	// RVA: 0x860CDC0 Offset: 0x8608DC0 VA: 0x860CDC0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerToggle : DebugUIHandlerWidget // TypeDefIndex: 20211
{
	// Fields
	public Text nameLabel; // 0x60
	public Toggle valueToggle; // 0x68
	public Image checkmarkImage; // 0x70
	protected internal DebugUI.BoolField m_Field; // 0x78

	// Methods

	// RVA: 0x860CDC8 Offset: 0x8608DC8 VA: 0x860CDC8 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860CEF4 Offset: 0x8608EF4 VA: 0x860CEF4
	private void OnToggleValueChanged(bool value) { }

	// RVA: 0x860CF1C Offset: 0x8608F1C VA: 0x860CF1C Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860CF74 Offset: 0x8608F74 VA: 0x860CF74 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860CFC4 Offset: 0x8608FC4 VA: 0x860CFC4 Slot: 8
	public override void OnAction() { }

	// RVA: 0x860D04C Offset: 0x860904C VA: 0x860D04C Slot: 13
	protected internal virtual void UpdateValueLabel() { }

	// RVA: 0x860D0FC Offset: 0x86090FC VA: 0x860D0FC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugUIHandlerToggleHistory.<RefreshAfterSanitization>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 20212
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DebugUIHandlerToggleHistory <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x860D6A8 Offset: 0x86096A8 VA: 0x860D6A8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x860D6D8 Offset: 0x86096D8 VA: 0x860D6D8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x860D6DC Offset: 0x86096DC VA: 0x860D6DC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x860D798 Offset: 0x8609798 VA: 0x860D798 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x860D7A0 Offset: 0x86097A0 VA: 0x860D7A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x860D7D8 Offset: 0x86097D8 VA: 0x860D7D8 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle // TypeDefIndex: 20213
{
	// Fields
	private Toggle[] historyToggles; // 0x80
	private const float k_XOffset = 230;

	// Methods

	// RVA: 0x860D104 Offset: 0x8609104 VA: 0x860D104 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860D4AC Offset: 0x86094AC VA: 0x860D4AC Slot: 13
	protected internal override void UpdateValueLabel() { }

	[IteratorStateMachine(typeof(DebugUIHandlerToggleHistory.<RefreshAfterSanitization>d__4))]
	// RVA: 0x860D63C Offset: 0x860963C VA: 0x860D63C
	private IEnumerator RefreshAfterSanitization() { }

	// RVA: 0x860D6D0 Offset: 0x86096D0 VA: 0x860D6D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerUIntField : DebugUIHandlerWidget // TypeDefIndex: 20214
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	private DebugUI.UIntField m_Field; // 0x70

	// Methods

	// RVA: 0x860D7E0 Offset: 0x86097E0 VA: 0x860D7E0 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860D968 Offset: 0x8609968 VA: 0x860D968 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860D9C0 Offset: 0x86099C0 VA: 0x860D9C0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860DA10 Offset: 0x8609A10 VA: 0x860DA10 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x860DAD4 Offset: 0x8609AD4 VA: 0x860DAD4 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x860DA1C Offset: 0x8609A1C VA: 0x860DA1C
	private void ChangeValue(bool fast, int multiplier) { }

	// RVA: 0x860D888 Offset: 0x8609888 VA: 0x860D888
	private void UpdateValueLabel() { }

	// RVA: 0x860DAE0 Offset: 0x8609AE0 VA: 0x860DAE0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerValue : DebugUIHandlerWidget // TypeDefIndex: 20215
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	private DebugUI.Value m_Field; // 0x70
	protected internal float m_Timer; // 0x78
	private static readonly Color k_ZeroColor; // 0x0

	// Methods

	// RVA: 0x860DAE8 Offset: 0x8609AE8 VA: 0x860DAE8 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x860DAF0 Offset: 0x8609AF0 VA: 0x860DAF0 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860DB8C Offset: 0x8609B8C VA: 0x860DB8C Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860DBE4 Offset: 0x8609BE4 VA: 0x860DBE4 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860DC34 Offset: 0x8609C34 VA: 0x860DC34
	private void Update() { }

	// RVA: 0x860DDB4 Offset: 0x8609DB4 VA: 0x860DDB4
	public void .ctor() { }

	// RVA: 0x860DDBC Offset: 0x8609DBC VA: 0x860DDBC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerValueTuple : DebugUIHandlerWidget // TypeDefIndex: 20216
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	protected internal DebugUI.ValueTuple m_Field; // 0x70
	protected internal Text[] valueElements; // 0x78
	private const float k_XOffset = 230;
	private float m_Timer; // 0x80
	private static readonly Color k_ZeroColor; // 0x0

	// Methods

	// RVA: 0x860DE0C Offset: 0x8609E0C VA: 0x860DE0C Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x860DE14 Offset: 0x8609E14 VA: 0x860DE14 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860DE4C Offset: 0x8609E4C VA: 0x860DE4C Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860DE7C Offset: 0x8609E7C VA: 0x860DE7C Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860E218 Offset: 0x860A218 VA: 0x860E218 Slot: 13
	internal virtual void UpdateValueLabels() { }

	// RVA: 0x860E468 Offset: 0x860A468 VA: 0x860E468
	private void Update() { }

	// RVA: 0x860E4E4 Offset: 0x860A4E4 VA: 0x860E4E4
	public void .ctor() { }

	// RVA: 0x860E4EC Offset: 0x860A4EC VA: 0x860E4EC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerVBox : DebugUIHandlerWidget // TypeDefIndex: 20217
{
	// Fields
	private DebugUIHandlerContainer m_Container; // 0x60

	// Methods

	// RVA: 0x860E53C Offset: 0x860A53C VA: 0x860E53C Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860E5B0 Offset: 0x860A5B0 VA: 0x860E5B0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860E668 Offset: 0x860A668 VA: 0x860E668 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x860E724 Offset: 0x860A724 VA: 0x860E724
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerVector2 : DebugUIHandlerWidget // TypeDefIndex: 20218
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public DebugUIHandlerIndirectFloatField fieldX; // 0x70
	public DebugUIHandlerIndirectFloatField fieldY; // 0x78
	private DebugUI.Vector2Field m_Field; // 0x80
	private DebugUIHandlerContainer m_Container; // 0x88

	// Methods

	// RVA: 0x860E72C Offset: 0x860A72C VA: 0x860E72C Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860EAC0 Offset: 0x860AAC0 VA: 0x860EAC0
	private void SetValue(float v, bool x = False, bool y = False) { }

	// RVA: 0x860E990 Offset: 0x860A990 VA: 0x860E990
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x860EB54 Offset: 0x860AB54 VA: 0x860EB54 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860EC38 Offset: 0x860AC38 VA: 0x860EC38 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860EC68 Offset: 0x860AC68 VA: 0x860EC68 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x860EC88 Offset: 0x860AC88 VA: 0x860EC88 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x860ECA8 Offset: 0x860ACA8 VA: 0x860ECA8 Slot: 8
	public override void OnAction() { }

	// RVA: 0x860ECD0 Offset: 0x860ACD0 VA: 0x860ECD0 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x860ED9C Offset: 0x860AD9C VA: 0x860ED9C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x860EDA4 Offset: 0x860ADA4 VA: 0x860EDA4
	private float <SetWidget>b__6_0() { }

	[CompilerGenerated]
	// RVA: 0x860EDF4 Offset: 0x860ADF4 VA: 0x860EDF4
	private void <SetWidget>b__6_1(float x) { }

	[CompilerGenerated]
	// RVA: 0x860EE00 Offset: 0x860AE00 VA: 0x860EE00
	private float <SetWidget>b__6_2() { }

	[CompilerGenerated]
	// RVA: 0x860EE58 Offset: 0x860AE58 VA: 0x860EE58
	private void <SetWidget>b__6_3(float x) { }

	[CompilerGenerated]
	// RVA: 0x860EE64 Offset: 0x860AE64 VA: 0x860EE64
	private float <SetupSettings>b__8_0() { }

	[CompilerGenerated]
	// RVA: 0x860EE80 Offset: 0x860AE80 VA: 0x860EE80
	private float <SetupSettings>b__8_1() { }

	[CompilerGenerated]
	// RVA: 0x860EE9C Offset: 0x860AE9C VA: 0x860EE9C
	private float <SetupSettings>b__8_2() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerVector3 : DebugUIHandlerWidget // TypeDefIndex: 20219
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public DebugUIHandlerIndirectFloatField fieldX; // 0x70
	public DebugUIHandlerIndirectFloatField fieldY; // 0x78
	public DebugUIHandlerIndirectFloatField fieldZ; // 0x80
	private DebugUI.Vector3Field m_Field; // 0x88
	private DebugUIHandlerContainer m_Container; // 0x90

	// Methods

	// RVA: 0x860EEBC Offset: 0x860AEBC VA: 0x860EEBC Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860F314 Offset: 0x860B314 VA: 0x860F314
	private void SetValue(float v, bool x = False, bool y = False, bool z = False) { }

	// RVA: 0x860F1E4 Offset: 0x860B1E4 VA: 0x860F1E4
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x860F3B4 Offset: 0x860B3B4 VA: 0x860F3B4 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860F498 Offset: 0x860B498 VA: 0x860F498 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860F4C8 Offset: 0x860B4C8 VA: 0x860F4C8 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x860F4E8 Offset: 0x860B4E8 VA: 0x860F4E8 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x860F508 Offset: 0x860B508 VA: 0x860F508 Slot: 8
	public override void OnAction() { }

	// RVA: 0x860F530 Offset: 0x860B530 VA: 0x860F530 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x860F5FC Offset: 0x860B5FC VA: 0x860F5FC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x860F604 Offset: 0x860B604 VA: 0x860F604
	private float <SetWidget>b__7_0() { }

	[CompilerGenerated]
	// RVA: 0x860F654 Offset: 0x860B654 VA: 0x860F654
	private void <SetWidget>b__7_1(float v) { }

	[CompilerGenerated]
	// RVA: 0x860F664 Offset: 0x860B664 VA: 0x860F664
	private float <SetWidget>b__7_2() { }

	[CompilerGenerated]
	// RVA: 0x860F6BC Offset: 0x860B6BC VA: 0x860F6BC
	private void <SetWidget>b__7_3(float v) { }

	[CompilerGenerated]
	// RVA: 0x860F6CC Offset: 0x860B6CC VA: 0x860F6CC
	private float <SetWidget>b__7_4() { }

	[CompilerGenerated]
	// RVA: 0x860F724 Offset: 0x860B724 VA: 0x860F724
	private void <SetWidget>b__7_5(float v) { }

	[CompilerGenerated]
	// RVA: 0x860F734 Offset: 0x860B734 VA: 0x860F734
	private float <SetupSettings>b__9_0() { }

	[CompilerGenerated]
	// RVA: 0x860F750 Offset: 0x860B750 VA: 0x860F750
	private float <SetupSettings>b__9_1() { }

	[CompilerGenerated]
	// RVA: 0x860F76C Offset: 0x860B76C VA: 0x860F76C
	private float <SetupSettings>b__9_2() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerVector4 : DebugUIHandlerWidget // TypeDefIndex: 20220
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public DebugUIHandlerIndirectFloatField fieldX; // 0x70
	public DebugUIHandlerIndirectFloatField fieldY; // 0x78
	public DebugUIHandlerIndirectFloatField fieldZ; // 0x80
	public DebugUIHandlerIndirectFloatField fieldW; // 0x88
	private DebugUI.Vector4Field m_Field; // 0x90
	private DebugUIHandlerContainer m_Container; // 0x98

	// Methods

	// RVA: 0x860F78C Offset: 0x860B78C VA: 0x860F78C Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x860FCAC Offset: 0x860BCAC VA: 0x860FCAC
	private void SetValue(float v, bool x = False, bool y = False, bool z = False, bool w = False) { }

	// RVA: 0x860FB78 Offset: 0x860BB78 VA: 0x860FB78
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x860FD60 Offset: 0x860BD60 VA: 0x860FD60 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x860FE4C Offset: 0x860BE4C VA: 0x860FE4C Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x860FE7C Offset: 0x860BE7C VA: 0x860FE7C Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x860FE9C Offset: 0x860BE9C VA: 0x860FE9C Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x860FEBC Offset: 0x860BEBC VA: 0x860FEBC Slot: 8
	public override void OnAction() { }

	// RVA: 0x860FEE4 Offset: 0x860BEE4 VA: 0x860FEE4 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x86100B4 Offset: 0x860C0B4 VA: 0x86100B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x86100EC Offset: 0x860C0EC VA: 0x86100EC
	private float <SetWidget>b__8_0() { }

	[CompilerGenerated]
	// RVA: 0x861013C Offset: 0x860C13C VA: 0x861013C
	private void <SetWidget>b__8_1(float x) { }

	[CompilerGenerated]
	// RVA: 0x8610150 Offset: 0x860C150 VA: 0x8610150
	private float <SetWidget>b__8_2() { }

	[CompilerGenerated]
	// RVA: 0x86101A8 Offset: 0x860C1A8 VA: 0x86101A8
	private void <SetWidget>b__8_3(float x) { }

	[CompilerGenerated]
	// RVA: 0x86101BC Offset: 0x860C1BC VA: 0x86101BC
	private float <SetWidget>b__8_4() { }

	[CompilerGenerated]
	// RVA: 0x8610214 Offset: 0x860C214 VA: 0x8610214
	private void <SetWidget>b__8_5(float x) { }

	[CompilerGenerated]
	// RVA: 0x8610228 Offset: 0x860C228 VA: 0x8610228
	private float <SetWidget>b__8_6() { }

	[CompilerGenerated]
	// RVA: 0x8610280 Offset: 0x860C280 VA: 0x8610280
	private void <SetWidget>b__8_7(float x) { }

	[CompilerGenerated]
	// RVA: 0x8610294 Offset: 0x860C294 VA: 0x8610294
	private float <SetupSettings>b__10_0() { }

	[CompilerGenerated]
	// RVA: 0x86102B0 Offset: 0x860C2B0 VA: 0x86102B0
	private float <SetupSettings>b__10_1() { }

	[CompilerGenerated]
	// RVA: 0x86102CC Offset: 0x860C2CC VA: 0x86102CC
	private float <SetupSettings>b__10_2() { }
}

// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerWidget : MonoBehaviour // TypeDefIndex: 20221
{
	// Fields
	[HideInInspector]
	public Color colorDefault; // 0x20
	[HideInInspector]
	public Color colorSelected; // 0x30
	[CompilerGenerated]
	private DebugUIHandlerWidget <parentUIHandler>k__BackingField; // 0x40
	[CompilerGenerated]
	private DebugUIHandlerWidget <previousUIHandler>k__BackingField; // 0x48
	[CompilerGenerated]
	private DebugUIHandlerWidget <nextUIHandler>k__BackingField; // 0x50
	protected DebugUI.Widget m_Widget; // 0x58

	// Properties
	public DebugUIHandlerWidget parentUIHandler { get; set; }
	public DebugUIHandlerWidget previousUIHandler { get; set; }
	public DebugUIHandlerWidget nextUIHandler { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x86102EC Offset: 0x860C2EC VA: 0x86102EC
	public DebugUIHandlerWidget get_parentUIHandler() { }

	[CompilerGenerated]
	// RVA: 0x86102F4 Offset: 0x860C2F4 VA: 0x86102F4
	public void set_parentUIHandler(DebugUIHandlerWidget value) { }

	[CompilerGenerated]
	// RVA: 0x86102FC Offset: 0x860C2FC VA: 0x86102FC
	public DebugUIHandlerWidget get_previousUIHandler() { }

	[CompilerGenerated]
	// RVA: 0x8610304 Offset: 0x860C304 VA: 0x8610304
	public void set_previousUIHandler(DebugUIHandlerWidget value) { }

	[CompilerGenerated]
	// RVA: 0x861030C Offset: 0x860C30C VA: 0x861030C
	public DebugUIHandlerWidget get_nextUIHandler() { }

	[CompilerGenerated]
	// RVA: 0x8610314 Offset: 0x860C314 VA: 0x8610314
	public void set_nextUIHandler(DebugUIHandlerWidget value) { }

	// RVA: 0x861031C Offset: 0x860C31C VA: 0x861031C Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x8610320 Offset: 0x860C320 VA: 0x8610320 Slot: 5
	internal virtual void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x8610328 Offset: 0x860C328 VA: 0x8610328
	internal DebugUI.Widget GetWidget() { }

	// RVA: -1 Offset: -1
	protected T CastWidget<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456C9E4 Offset: 0x45689E4 VA: 0x456C9E4
	|-DebugUIHandlerWidget.CastWidget<object>
	*/

	// RVA: 0x8610330 Offset: 0x860C330 VA: 0x8610330 Slot: 6
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x8610338 Offset: 0x860C338 VA: 0x8610338 Slot: 7
	public virtual void OnDeselection() { }

	// RVA: 0x861033C Offset: 0x860C33C VA: 0x861033C Slot: 8
	public virtual void OnAction() { }

	// RVA: 0x8610340 Offset: 0x860C340 VA: 0x8610340 Slot: 9
	public virtual void OnIncrement(bool fast) { }

	// RVA: 0x8610344 Offset: 0x860C344 VA: 0x8610344 Slot: 10
	public virtual void OnDecrement(bool fast) { }

	// RVA: 0x8610348 Offset: 0x860C348 VA: 0x8610348 Slot: 11
	public virtual DebugUIHandlerWidget Previous() { }

	// RVA: 0x860FFB0 Offset: 0x860BFB0 VA: 0x860FFB0 Slot: 12
	public virtual DebugUIHandlerWidget Next() { }

	// RVA: 0x86100D0 Offset: 0x860C0D0 VA: 0x86100D0
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering.UI
[ExecuteAlways]
public class UIFoldout : Toggle // TypeDefIndex: 20222
{
	// Fields
	public GameObject content; // 0x128
	public GameObject arrowOpened; // 0x130
	public GameObject arrowClosed; // 0x138

	// Methods

	// RVA: 0x86103F4 Offset: 0x860C3F4 VA: 0x86103F4 Slot: 6
	protected override void Start() { }

	// RVA: 0x86104C0 Offset: 0x860C4C0 VA: 0x86104C0
	private void OnValidate() { }

	// RVA: 0x86104B4 Offset: 0x860C4B4 VA: 0x86104B4
	public void SetState(bool state) { }

	// RVA: 0x86104CC Offset: 0x860C4CC VA: 0x86104CC
	public void SetState(bool state, bool rebuildLayout) { }

	// RVA: 0x86106BC Offset: 0x860C6BC VA: 0x86106BC
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 // TypeDefIndex: 20223
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 // TypeDefIndex: 20224
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 20225
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=512 // TypeDefIndex: 20226
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 20227
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 // TypeDefIndex: 20228
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18843 // TypeDefIndex: 20229
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20258 // TypeDefIndex: 20230
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 20231
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 45AC882BD91FEBD5A58E67471A0EF32BFC485447A8A18D61DBA335FDA5A2C097 /*Metadata offset 0xEFDDE0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=512 4A1D5C231BB4DDB64A57CFF5FC45592F845DB22D8DE0DCCA7BB59D822908C39A /*Metadata offset 0xEFDEE8*/; // 0x100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18843 7DE9E34DC6DC53F9052337C321856C2B209C506DFB969F9FA2126D5F5F76BCD8 /*Metadata offset 0xEFE0F0*/; // 0x300
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 90C2D148CDB931199C77ADD692B92324CDFC328EDD1D0AB7FA24830C177A4FF4 /*Metadata offset 0xF02A90*/; // 0x4C9B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 BDFF4BF48DBC7214A392CF884F7F2A6073CCDB77CA3EB11BEBB93DA8ED8B2158 /*Metadata offset 0xF02E98*/; // 0x509B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 C606E03B5FE8EAD2ECA6BCB45AE684039D928B4EE7C4A03C63D0DF9F94F81DAF /*Metadata offset 0xF02F30*/; // 0x512B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20258 CD4AC44D3D07CBFB8F72693232F0A04A4D44369E9180E37EF6E673C579594EA7 /*Metadata offset 0xF03F38*/; // 0x612B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE /*Metadata offset 0xF08E60*/; // 0xB04D
}

