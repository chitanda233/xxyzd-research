// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28745
{}

// Namespace: Unity.AI.Navigation
[ExecuteAlways]
[AddComponentMenu("Navigation/NavMeshModifier", 32)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshModifier.html")]
public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 28746
{
	// Fields
	[SerializeField]
	private bool m_OverrideArea; // 0x20
	[SerializeField]
	private int m_Area; // 0x24
	[SerializeField]
	private bool m_OverrideGenerateLinks; // 0x28
	[SerializeField]
	private bool m_GenerateLinks; // 0x29
	[SerializeField]
	private bool m_IgnoreFromBuild; // 0x2A
	[SerializeField]
	private bool m_ApplyToChildren; // 0x2B
	[SerializeField]
	private List<int> m_AffectedAgents; // 0x30
	private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x0

	// Properties
	public bool overrideArea { get; set; }
	public int area { get; set; }
	public bool overrideGenerateLinks { get; set; }
	public bool generateLinks { get; set; }
	public bool ignoreFromBuild { get; set; }
	public bool applyToChildren { get; set; }
	public static List<NavMeshModifier> activeModifiers { get; }

	// Methods

	// RVA: 0x852FA58 Offset: 0x852BA58 VA: 0x852FA58
	public bool get_overrideArea() { }

	// RVA: 0x852FA60 Offset: 0x852BA60 VA: 0x852FA60
	public void set_overrideArea(bool value) { }

	// RVA: 0x852FA6C Offset: 0x852BA6C VA: 0x852FA6C
	public int get_area() { }

	// RVA: 0x852FA74 Offset: 0x852BA74 VA: 0x852FA74
	public void set_area(int value) { }

	// RVA: 0x852FA7C Offset: 0x852BA7C VA: 0x852FA7C
	public bool get_overrideGenerateLinks() { }

	// RVA: 0x852FA84 Offset: 0x852BA84 VA: 0x852FA84
	public void set_overrideGenerateLinks(bool value) { }

	// RVA: 0x852FA90 Offset: 0x852BA90 VA: 0x852FA90
	public bool get_generateLinks() { }

	// RVA: 0x852FA98 Offset: 0x852BA98 VA: 0x852FA98
	public void set_generateLinks(bool value) { }

	// RVA: 0x852FAA4 Offset: 0x852BAA4 VA: 0x852FAA4
	public bool get_ignoreFromBuild() { }

	// RVA: 0x852FAAC Offset: 0x852BAAC VA: 0x852FAAC
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x852FAB8 Offset: 0x852BAB8 VA: 0x852FAB8
	public bool get_applyToChildren() { }

	// RVA: 0x852FAC0 Offset: 0x852BAC0 VA: 0x852FAC0
	public void set_applyToChildren(bool value) { }

	// RVA: 0x852FACC Offset: 0x852BACC VA: 0x852FACC
	public static List<NavMeshModifier> get_activeModifiers() { }

	// RVA: 0x852FB24 Offset: 0x852BB24 VA: 0x852FB24
	private void OnEnable() { }

	// RVA: 0x852FC48 Offset: 0x852BC48 VA: 0x852FC48
	private void OnDisable() { }

	// RVA: 0x852FCC8 Offset: 0x852BCC8 VA: 0x852FCC8
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x852FD80 Offset: 0x852BD80 VA: 0x852FD80
	public void .ctor() { }

	// RVA: 0x852FE4C Offset: 0x852BE4C VA: 0x852FE4C
	private static void .cctor() { }
}

// Namespace: Unity.AI.Navigation
[ExecuteAlways]
[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshModifierVolume.html")]
public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 28747
{
	// Fields
	[SerializeField]
	private Vector3 m_Size; // 0x20
	[SerializeField]
	private Vector3 m_Center; // 0x2C
	[SerializeField]
	private int m_Area; // 0x38
	[SerializeField]
	private List<int> m_AffectedAgents; // 0x40
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x0

	// Properties
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public int area { get; set; }
	public static List<NavMeshModifierVolume> activeModifiers { get; }

	// Methods

	// RVA: 0x852FEE4 Offset: 0x852BEE4 VA: 0x852FEE4
	public Vector3 get_size() { }

	// RVA: 0x852FEF0 Offset: 0x852BEF0 VA: 0x852FEF0
	public void set_size(Vector3 value) { }

	// RVA: 0x852FEFC Offset: 0x852BEFC VA: 0x852FEFC
	public Vector3 get_center() { }

	// RVA: 0x852FF08 Offset: 0x852BF08 VA: 0x852FF08
	public void set_center(Vector3 value) { }

	// RVA: 0x852FF14 Offset: 0x852BF14 VA: 0x852FF14
	public int get_area() { }

	// RVA: 0x852FF1C Offset: 0x852BF1C VA: 0x852FF1C
	public void set_area(int value) { }

	// RVA: 0x852FF24 Offset: 0x852BF24 VA: 0x852FF24
	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	// RVA: 0x852FF7C Offset: 0x852BF7C VA: 0x852FF7C
	private void OnEnable() { }

	// RVA: 0x85300A0 Offset: 0x852C0A0 VA: 0x85300A0
	private void OnDisable() { }

	// RVA: 0x8530120 Offset: 0x852C120 VA: 0x8530120
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x85301D8 Offset: 0x852C1D8 VA: 0x85301D8
	public void .ctor() { }

	// RVA: 0x85302B4 Offset: 0x852C2B4 VA: 0x85302B4
	private static void .cctor() { }
}

// Namespace: Unity.AI.Navigation
public enum CollectObjects // TypeDefIndex: 28748
{
	// Fields
	public int value__; // 0x0
	[InspectorName("All Game Objects")]
	public const CollectObjects All = 0;
	[InspectorName("Volume")]
	public const CollectObjects Volume = 1;
	[InspectorName("Current Object Hierarchy")]
	public const CollectObjects Children = 2;
	[InspectorName("NavMeshModifier Component Only")]
	public const CollectObjects MarkedWithModifier = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NavMeshSurface.<>c // TypeDefIndex: 28749
{
	// Fields
	public static readonly NavMeshSurface.<>c <>9; // 0x0
	public static Predicate<NavMeshModifierVolume> <>9__84_0; // 0x8
	public static Predicate<NavMeshModifier> <>9__85_0; // 0x10
	public static Predicate<NavMeshBuildSource> <>9__85_1; // 0x18
	public static Predicate<NavMeshBuildSource> <>9__85_2; // 0x20

	// Methods

	// RVA: 0x8532C70 Offset: 0x852EC70 VA: 0x8532C70
	private static void .cctor() { }

	// RVA: 0x8532CD8 Offset: 0x852ECD8 VA: 0x8532CD8
	public void .ctor() { }

	// RVA: 0x8532CE0 Offset: 0x852ECE0 VA: 0x8532CE0
	internal bool <AppendModifierVolumes>b__84_0(NavMeshModifierVolume x) { }

	// RVA: 0x8532D08 Offset: 0x852ED08 VA: 0x8532D08
	internal bool <CollectSources>b__85_0(NavMeshModifier x) { }

	// RVA: 0x8532D30 Offset: 0x852ED30 VA: 0x8532D30
	internal bool <CollectSources>b__85_1(NavMeshBuildSource x) { }

	// RVA: 0x8532E18 Offset: 0x852EE18 VA: 0x8532E18
	internal bool <CollectSources>b__85_2(NavMeshBuildSource x) { }
}

// Namespace: Unity.AI.Navigation
[AddComponentMenu("Navigation/NavMeshSurface", 30)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshSurface.html")]
[DefaultExecutionOrder(-102)]
[ExecuteAlways]
public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 28750
{
	// Fields
	[SerializeField]
	private int m_AgentTypeID; // 0x20
	[SerializeField]
	private CollectObjects m_CollectObjects; // 0x24
	[SerializeField]
	private Vector3 m_Size; // 0x28
	[SerializeField]
	private Vector3 m_Center; // 0x34
	[SerializeField]
	private LayerMask m_LayerMask; // 0x40
	[SerializeField]
	private NavMeshCollectGeometry m_UseGeometry; // 0x44
	[SerializeField]
	private int m_DefaultArea; // 0x48
	[SerializeField]
	private bool m_GenerateLinks; // 0x4C
	[SerializeField]
	private bool m_IgnoreNavMeshAgent; // 0x4D
	[SerializeField]
	private bool m_IgnoreNavMeshObstacle; // 0x4E
	[SerializeField]
	private bool m_OverrideTileSize; // 0x4F
	[SerializeField]
	private int m_TileSize; // 0x50
	[SerializeField]
	private bool m_OverrideVoxelSize; // 0x54
	[SerializeField]
	private float m_VoxelSize; // 0x58
	[SerializeField]
	private float m_MinRegionArea; // 0x5C
	[FormerlySerializedAs("m_BakedNavMeshData")]
	[SerializeField]
	private NavMeshData m_NavMeshData; // 0x60
	[SerializeField]
	private bool m_BuildHeightMesh; // 0x68
	private NavMeshDataInstance m_NavMeshDataInstance; // 0x6C
	private Vector3 m_LastPosition; // 0x70
	private Quaternion m_LastRotation; // 0x7C
	private static readonly List<NavMeshSurface> s_NavMeshSurfaces; // 0x0

	// Properties
	public int agentTypeID { get; set; }
	public CollectObjects collectObjects { get; set; }
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public LayerMask layerMask { get; set; }
	public NavMeshCollectGeometry useGeometry { get; set; }
	public int defaultArea { get; set; }
	public bool ignoreNavMeshAgent { get; set; }
	public bool ignoreNavMeshObstacle { get; set; }
	public bool overrideTileSize { get; set; }
	public int tileSize { get; set; }
	public bool overrideVoxelSize { get; set; }
	public float voxelSize { get; set; }
	public float minRegionArea { get; set; }
	public bool buildHeightMesh { get; set; }
	public NavMeshData navMeshData { get; set; }
	internal NavMeshDataInstance navMeshDataInstance { get; }
	public static List<NavMeshSurface> activeSurfaces { get; }

	// Methods

	// RVA: 0x853034C Offset: 0x852C34C VA: 0x853034C
	public int get_agentTypeID() { }

	// RVA: 0x8530354 Offset: 0x852C354 VA: 0x8530354
	public void set_agentTypeID(int value) { }

	// RVA: 0x853035C Offset: 0x852C35C VA: 0x853035C
	public CollectObjects get_collectObjects() { }

	// RVA: 0x8530364 Offset: 0x852C364 VA: 0x8530364
	public void set_collectObjects(CollectObjects value) { }

	// RVA: 0x853036C Offset: 0x852C36C VA: 0x853036C
	public Vector3 get_size() { }

	// RVA: 0x8530378 Offset: 0x852C378 VA: 0x8530378
	public void set_size(Vector3 value) { }

	// RVA: 0x8530384 Offset: 0x852C384 VA: 0x8530384
	public Vector3 get_center() { }

	// RVA: 0x8530390 Offset: 0x852C390 VA: 0x8530390
	public void set_center(Vector3 value) { }

	// RVA: 0x853039C Offset: 0x852C39C VA: 0x853039C
	public LayerMask get_layerMask() { }

	// RVA: 0x85303A4 Offset: 0x852C3A4 VA: 0x85303A4
	public void set_layerMask(LayerMask value) { }

	// RVA: 0x85303AC Offset: 0x852C3AC VA: 0x85303AC
	public NavMeshCollectGeometry get_useGeometry() { }

	// RVA: 0x85303B4 Offset: 0x852C3B4 VA: 0x85303B4
	public void set_useGeometry(NavMeshCollectGeometry value) { }

	// RVA: 0x85303BC Offset: 0x852C3BC VA: 0x85303BC
	public int get_defaultArea() { }

	// RVA: 0x85303C4 Offset: 0x852C3C4 VA: 0x85303C4
	public void set_defaultArea(int value) { }

	// RVA: 0x85303CC Offset: 0x852C3CC VA: 0x85303CC
	public bool get_ignoreNavMeshAgent() { }

	// RVA: 0x85303D4 Offset: 0x852C3D4 VA: 0x85303D4
	public void set_ignoreNavMeshAgent(bool value) { }

	// RVA: 0x85303E0 Offset: 0x852C3E0 VA: 0x85303E0
	public bool get_ignoreNavMeshObstacle() { }

	// RVA: 0x85303E8 Offset: 0x852C3E8 VA: 0x85303E8
	public void set_ignoreNavMeshObstacle(bool value) { }

	// RVA: 0x85303F4 Offset: 0x852C3F4 VA: 0x85303F4
	public bool get_overrideTileSize() { }

	// RVA: 0x85303FC Offset: 0x852C3FC VA: 0x85303FC
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x8530408 Offset: 0x852C408 VA: 0x8530408
	public int get_tileSize() { }

	// RVA: 0x8530410 Offset: 0x852C410 VA: 0x8530410
	public void set_tileSize(int value) { }

	// RVA: 0x8530418 Offset: 0x852C418 VA: 0x8530418
	public bool get_overrideVoxelSize() { }

	// RVA: 0x8530420 Offset: 0x852C420 VA: 0x8530420
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x853042C Offset: 0x852C42C VA: 0x853042C
	public float get_voxelSize() { }

	// RVA: 0x8530434 Offset: 0x852C434 VA: 0x8530434
	public void set_voxelSize(float value) { }

	// RVA: 0x853043C Offset: 0x852C43C VA: 0x853043C
	public float get_minRegionArea() { }

	// RVA: 0x8530444 Offset: 0x852C444 VA: 0x8530444
	public void set_minRegionArea(float value) { }

	// RVA: 0x853044C Offset: 0x852C44C VA: 0x853044C
	public bool get_buildHeightMesh() { }

	// RVA: 0x8530454 Offset: 0x852C454 VA: 0x8530454
	public void set_buildHeightMesh(bool value) { }

	// RVA: 0x8530460 Offset: 0x852C460 VA: 0x8530460
	public NavMeshData get_navMeshData() { }

	// RVA: 0x8530468 Offset: 0x852C468 VA: 0x8530468
	public void set_navMeshData(NavMeshData value) { }

	// RVA: 0x8530470 Offset: 0x852C470 VA: 0x8530470
	internal NavMeshDataInstance get_navMeshDataInstance() { }

	// RVA: 0x8530478 Offset: 0x852C478 VA: 0x8530478
	public static List<NavMeshSurface> get_activeSurfaces() { }

	// RVA: 0x85304D0 Offset: 0x852C4D0 VA: 0x85304D0
	private Bounds GetInflatedBounds() { }

	// RVA: 0x8530590 Offset: 0x852C590 VA: 0x8530590
	private void OnEnable() { }

	// RVA: 0x8530984 Offset: 0x852C984 VA: 0x8530984
	private void OnDisable() { }

	// RVA: 0x8530828 Offset: 0x852C828 VA: 0x8530828
	public void AddData() { }

	// RVA: 0x85309E8 Offset: 0x852C9E8 VA: 0x85309E8
	public void RemoveData() { }

	// RVA: 0x8530B88 Offset: 0x852CB88 VA: 0x8530B88
	public NavMeshBuildSettings GetBuildSettings() { }

	// RVA: 0x8530D14 Offset: 0x852CD14 VA: 0x8530D14
	public void BuildNavMesh() { }

	// RVA: 0x8532034 Offset: 0x852E034 VA: 0x8532034
	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

	// RVA: 0x85305EC Offset: 0x852C5EC VA: 0x85305EC
	private static void Register(NavMeshSurface surface) { }

	// RVA: 0x8530A08 Offset: 0x852CA08 VA: 0x8530A08
	private static void Unregister(NavMeshSurface surface) { }

	// RVA: 0x8532144 Offset: 0x852E144 VA: 0x8532144
	private static void UpdateActive() { }

	// RVA: 0x8532244 Offset: 0x852E244 VA: 0x8532244
	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) { }

	// RVA: 0x8530F44 Offset: 0x852CF44 VA: 0x8530F44
	private List<NavMeshBuildSource> CollectSources() { }

	// RVA: 0x853180C Offset: 0x852D80C VA: 0x853180C
	private static Vector3 Abs(Vector3 v) { }

	// RVA: 0x8532844 Offset: 0x852E844 VA: 0x8532844
	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	// RVA: 0x853181C Offset: 0x852D81C VA: 0x853181C
	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	// RVA: 0x8532A3C Offset: 0x852EA3C VA: 0x8532A3C
	private bool HasTransformChanged() { }

	// RVA: 0x8532210 Offset: 0x852E210 VA: 0x8532210
	private void UpdateDataIfTransformChanged() { }

	// RVA: 0x8532B00 Offset: 0x852EB00 VA: 0x8532B00
	public void .ctor() { }

	// RVA: 0x8532BD8 Offset: 0x852EBD8 VA: 0x8532BD8
	private static void .cctor() { }
}

