// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28635
{}

// Namespace: UnityEngine.AI
[StaticAccessor("NavMeshBuilderBindings", 2)]
[NativeHeader("Modules/AI/Builder/NavMeshBuilder.bindings.h")]
public static class NavMeshBuilder // TypeDefIndex: 28636
{
	// Methods

	// RVA: 0x86BC3F0 Offset: 0x86B83F0 VA: 0x86BC3F0
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results) { }

	// RVA: 0x86BC6A8 Offset: 0x86B86A8 VA: 0x86BC6A8
	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results) { }

	// RVA: 0x86BC608 Offset: 0x86B8608 VA: 0x86BC608
	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects) { }

	// RVA: 0x86BC8DC Offset: 0x86B88DC VA: 0x86BC8DC
	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	// RVA: 0x86BCBA0 Offset: 0x86B8BA0 VA: 0x86BCBA0
	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x86BCC58 Offset: 0x86B8C58 VA: 0x86BCC58
	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	// RVA: 0x86BCDA0 Offset: 0x86B8DA0 VA: 0x86BCDA0
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x86BC83C Offset: 0x86B883C VA: 0x86BC83C
	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects) { }

	// RVA: 0x86BCBFC Offset: 0x86B8BFC VA: 0x86BCBFC
	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

	// RVA: 0x86BCDFC Offset: 0x86B8DFC VA: 0x86BCDFC
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }
}

// Namespace: UnityEngine.AI
[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshAgent.html")]
public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 28637
{}

// Namespace: UnityEngine.AI
[NativeHeader("Modules/AI/Components/NavMeshObstacle.bindings.h")]
[MovedFrom("UnityEngine")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshObstacle.html")]
public sealed class NavMeshObstacle : Behaviour // TypeDefIndex: 28638
{}

// Namespace: UnityEngine.AI
[MovedFrom("UnityEngine")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/OffMeshLink.html")]
public sealed class OffMeshLink : Behaviour // TypeDefIndex: 28639
{
	// Properties
	public float costOverride { get; }
	public bool biDirectional { get; }
	public Transform startTransform { get; }
	public Transform endTransform { get; }

	// Methods

	// RVA: 0x86BCE58 Offset: 0x86B8E58 VA: 0x86BCE58
	public float get_costOverride() { }

	// RVA: 0x86BCE94 Offset: 0x86B8E94 VA: 0x86BCE94
	public bool get_biDirectional() { }

	// RVA: 0x86BCED0 Offset: 0x86B8ED0 VA: 0x86BCED0
	public Transform get_startTransform() { }

	// RVA: 0x86BCF0C Offset: 0x86B8F0C VA: 0x86BCF0C
	public Transform get_endTransform() { }
}

// Namespace: UnityEngine.AI
[MovedFrom("UnityEngine")]
[UsedByNativeCode]
public struct NavMeshTriangulation // TypeDefIndex: 28640
{
	// Fields
	public Vector3[] vertices; // 0x0
	public int[] indices; // 0x8
	public int[] areas; // 0x10
}

// Namespace: UnityEngine.AI
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
public sealed class NavMeshData : Object // TypeDefIndex: 28641
{
	// Properties
	public Vector3 position { set; }
	public Quaternion rotation { set; }

	// Methods

	// RVA: 0x86BCF48 Offset: 0x86B8F48 VA: 0x86BCF48
	public void .ctor() { }

	// RVA: 0x86BCA68 Offset: 0x86B8A68 VA: 0x86BCA68
	public void .ctor(int agentTypeID) { }

	[StaticAccessor("NavMeshDataBindings", 2)]
	// RVA: 0x86BCFCC Offset: 0x86B8FCC VA: 0x86BCFCC
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	// RVA: 0x86BCAF8 Offset: 0x86B8AF8 VA: 0x86BCAF8
	public void set_position(Vector3 value) { }

	// RVA: 0x86BCB4C Offset: 0x86B8B4C VA: 0x86BCB4C
	public void set_rotation(Quaternion value) { }

	// RVA: 0x86BD010 Offset: 0x86B9010 VA: 0x86BD010
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x86BD054 Offset: 0x86B9054 VA: 0x86BD054
	private void set_rotation_Injected(ref Quaternion value) { }
}

// Namespace: UnityEngine.AI
public struct NavMeshDataInstance // TypeDefIndex: 28642
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <id>k__BackingField; // 0x0

	// Properties
	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }

	// Methods

	// RVA: 0x86BD098 Offset: 0x86B9098 VA: 0x86BD098
	public bool get_valid() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x86BD124 Offset: 0x86B9124 VA: 0x86BD124
	internal int get_id() { }

	[CompilerGenerated]
	// RVA: 0x86BD12C Offset: 0x86B912C VA: 0x86BD12C
	internal void set_id(int value) { }

	// RVA: 0x86BD134 Offset: 0x86B9134 VA: 0x86BD134
	public void Remove() { }

	// RVA: 0x86BD1AC Offset: 0x86B91AC VA: 0x86BD1AC
	public void set_owner(Object value) { }
}

// Namespace: 
public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 28643
{
	// Methods

	// RVA: 0x86BD6AC Offset: 0x86B96AC VA: 0x86BD6AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x86BD748 Offset: 0x86B9748 VA: 0x86BD748 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine.AI
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMeshManager.h")]
[StaticAccessor("NavMeshBindings", 2)]
public static class NavMesh // TypeDefIndex: 28644
{
	// Fields
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x86BD304 Offset: 0x86B9304 VA: 0x86BD304
	private static void Internal_CallOnNavMeshPreUpdate() { }

	[NativeName("GetAreaCost")]
	[StaticAccessor("GetNavMeshProjectSettings()")]
	// RVA: 0x86BD368 Offset: 0x86B9368 VA: 0x86BD368
	public static float GetAreaCost(int areaIndex) { }

	// RVA: 0x86BD3A4 Offset: 0x86B93A4 VA: 0x86BD3A4
	public static NavMeshTriangulation CalculateTriangulation() { }

	// RVA: 0x86BD438 Offset: 0x86B9438 VA: 0x86BD438
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeName("IsValidSurfaceID")]
	[StaticAccessor("GetNavMeshManager()")]
	// RVA: 0x86BD0E8 Offset: 0x86B90E8 VA: 0x86BD0E8
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("SetSurfaceUserID")]
	// RVA: 0x86BD2C0 Offset: 0x86B92C0 VA: 0x86BD2C0
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("LoadData")]
	// RVA: 0x86BD548 Offset: 0x86B9548 VA: 0x86BD548
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("UnloadData")]
	// RVA: 0x86BD170 Offset: 0x86B9170 VA: 0x86BD170
	internal static void RemoveNavMeshDataInternal(int handle) { }

	// RVA: 0x86BD5FC Offset: 0x86B95FC VA: 0x86BD5FC
	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	// RVA: 0x86BD3FC Offset: 0x86B93FC VA: 0x86BD3FC
	private static void CalculateTriangulation_Injected(out NavMeshTriangulation ret) { }

	// RVA: 0x86BD5A8 Offset: 0x86B95A8 VA: 0x86BD5A8
	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x86BD668 Offset: 0x86B9668 VA: 0x86BD668
	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }
}

// Namespace: UnityEngine.AI
public enum NavMeshBuildSourceShape // TypeDefIndex: 28645
{
	// Fields
	public int value__; // 0x0
	public const NavMeshBuildSourceShape Mesh = 0;
	public const NavMeshBuildSourceShape Terrain = 1;
	public const NavMeshBuildSourceShape Box = 2;
	public const NavMeshBuildSourceShape Sphere = 3;
	public const NavMeshBuildSourceShape Capsule = 4;
	public const NavMeshBuildSourceShape ModifierBox = 5;
}

// Namespace: UnityEngine.AI
public enum NavMeshCollectGeometry // TypeDefIndex: 28646
{
	// Fields
	public int value__; // 0x0
	public const NavMeshCollectGeometry RenderMeshes = 0;
	public const NavMeshCollectGeometry PhysicsColliders = 1;
}

// Namespace: UnityEngine.AI
[UsedByNativeCode]
[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
public struct NavMeshBuildSource // TypeDefIndex: 28647
{
	// Fields
	private Matrix4x4 m_Transform; // 0x0
	private Vector3 m_Size; // 0x40
	private NavMeshBuildSourceShape m_Shape; // 0x4C
	private int m_Area; // 0x50
	private int m_InstanceID; // 0x54
	private int m_ComponentID; // 0x58
	private int m_GenerateLinks; // 0x5C

	// Properties
	public Matrix4x4 transform { get; set; }
	public Vector3 size { get; set; }
	public NavMeshBuildSourceShape shape { get; set; }
	public int area { set; }
	public Object sourceObject { get; }
	public Component component { get; }

	// Methods

	// RVA: 0x86BD75C Offset: 0x86B975C VA: 0x86BD75C
	public Matrix4x4 get_transform() { }

	// RVA: 0x86BD770 Offset: 0x86B9770 VA: 0x86BD770
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x86BD784 Offset: 0x86B9784 VA: 0x86BD784
	public Vector3 get_size() { }

	// RVA: 0x86BD790 Offset: 0x86B9790 VA: 0x86BD790
	public void set_size(Vector3 value) { }

	// RVA: 0x86BD79C Offset: 0x86B979C VA: 0x86BD79C
	public NavMeshBuildSourceShape get_shape() { }

	// RVA: 0x86BD7A4 Offset: 0x86B97A4 VA: 0x86BD7A4
	public void set_shape(NavMeshBuildSourceShape value) { }

	// RVA: 0x86BD7AC Offset: 0x86B97AC VA: 0x86BD7AC
	public void set_area(int value) { }

	// RVA: 0x86BD7B4 Offset: 0x86B97B4 VA: 0x86BD7B4
	public Object get_sourceObject() { }

	// RVA: 0x86BD82C Offset: 0x86B982C VA: 0x86BD82C
	public Component get_component() { }

	[StaticAccessor("NavMeshBuildSource", 2)]
	// RVA: 0x86BD868 Offset: 0x86B9868 VA: 0x86BD868
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessor("NavMeshBuildSource", 2)]
	// RVA: 0x86BD7F0 Offset: 0x86B97F0 VA: 0x86BD7F0
	private static Object InternalGetObject(int instanceID) { }
}

// Namespace: UnityEngine.AI
[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
public struct NavMeshBuildMarkup // TypeDefIndex: 28648
{
	// Fields
	private int m_OverrideArea; // 0x0
	private int m_Area; // 0x4
	private int m_InheritIgnoreFromBuild; // 0x8
	private int m_IgnoreFromBuild; // 0xC
	private int m_OverrideGenerateLinks; // 0x10
	private int m_GenerateLinks; // 0x14
	private int m_InstanceID; // 0x18
	private int m_IgnoreChildren; // 0x1C

	// Properties
	public bool overrideArea { set; }
	public int area { set; }
	public bool ignoreFromBuild { set; }
	public bool overrideGenerateLinks { set; }
	public bool generateLinks { set; }
	public bool applyToChildren { set; }
	public Transform root { set; }

	// Methods

	// RVA: 0x86BD8A4 Offset: 0x86B98A4 VA: 0x86BD8A4
	public void set_overrideArea(bool value) { }

	// RVA: 0x86BD8B0 Offset: 0x86B98B0 VA: 0x86BD8B0
	public void set_area(int value) { }

	// RVA: 0x86BD8B8 Offset: 0x86B98B8 VA: 0x86BD8B8
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x86BD8C4 Offset: 0x86B98C4 VA: 0x86BD8C4
	public void set_overrideGenerateLinks(bool value) { }

	// RVA: 0x86BD8D0 Offset: 0x86B98D0 VA: 0x86BD8D0
	public void set_generateLinks(bool value) { }

	// RVA: 0x86BD8DC Offset: 0x86B98DC VA: 0x86BD8DC
	public void set_applyToChildren(bool value) { }

	// RVA: 0x86BD8EC Offset: 0x86B98EC VA: 0x86BD8EC
	public void set_root(Transform value) { }
}

// Namespace: UnityEngine.AI
[NativeHeader("Modules/AI/Public/NavMeshBuildSettings.h")]
public struct NavMeshBuildSettings // TypeDefIndex: 28649
{
	// Fields
	private int m_AgentTypeID; // 0x0
	private float m_AgentRadius; // 0x4
	private float m_AgentHeight; // 0x8
	private float m_AgentSlope; // 0xC
	private float m_AgentClimb; // 0x10
	private float m_LedgeDropHeight; // 0x14
	private float m_MaxJumpAcrossDistance; // 0x18
	private float m_MinRegionArea; // 0x1C
	private int m_OverrideVoxelSize; // 0x20
	private float m_VoxelSize; // 0x24
	private int m_OverrideTileSize; // 0x28
	private int m_TileSize; // 0x2C
	private int m_BuildHeightMesh; // 0x30
	private uint m_MaxJobWorkers; // 0x34
	private int m_PreserveTilesOutsideBounds; // 0x38
	private NavMeshBuildDebugSettings m_Debug; // 0x3C

	// Properties
	public int agentTypeID { get; set; }
	public float agentRadius { get; }
	public float minRegionArea { set; }
	public bool overrideVoxelSize { set; }
	public float voxelSize { set; }
	public bool overrideTileSize { set; }
	public int tileSize { set; }
	public bool buildHeightMesh { set; }

	// Methods

	// RVA: 0x86BCA60 Offset: 0x86B8A60 VA: 0x86BCA60
	public int get_agentTypeID() { }

	// RVA: 0x86BD97C Offset: 0x86B997C VA: 0x86BD97C
	public void set_agentTypeID(int value) { }

	// RVA: 0x86BD984 Offset: 0x86B9984 VA: 0x86BD984
	public float get_agentRadius() { }

	// RVA: 0x86BD98C Offset: 0x86B998C VA: 0x86BD98C
	public void set_minRegionArea(float value) { }

	// RVA: 0x86BD994 Offset: 0x86B9994 VA: 0x86BD994
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x86BD9A0 Offset: 0x86B99A0 VA: 0x86BD9A0
	public void set_voxelSize(float value) { }

	// RVA: 0x86BD9A8 Offset: 0x86B99A8 VA: 0x86BD9A8
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x86BD9B4 Offset: 0x86B99B4 VA: 0x86BD9B4
	public void set_tileSize(int value) { }

	// RVA: 0x86BD9BC Offset: 0x86B99BC VA: 0x86BD9BC
	public void set_buildHeightMesh(bool value) { }
}

// Namespace: UnityEngine.AI
[NativeHeader("Modules/AI/Public/NavMeshBuildDebugSettings.h")]
public struct NavMeshBuildDebugSettings // TypeDefIndex: 28650
{
	// Fields
	private byte m_Flags; // 0x0
}

