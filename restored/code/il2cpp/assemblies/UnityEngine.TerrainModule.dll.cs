// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28651
{}

// Namespace: UnityEngine
[StaticAccessor("GetITerrainManager()", 1)]
[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Terrain/Public/Terrain.h")]
public sealed class Terrain : Behaviour // TypeDefIndex: 28652
{
	// Properties
	public TerrainData terrainData { get; }
	public bool allowAutoConnect { get; }
	public int groupingID { get; }
	[NativeProperty("ActiveTerrainsScriptingArray")]
	public static Terrain[] activeTerrains { get; }

	// Methods

	// RVA: 0x87E5AD0 Offset: 0x87E1AD0 VA: 0x87E5AD0
	public TerrainData get_terrainData() { }

	// RVA: 0x87E5B0C Offset: 0x87E1B0C VA: 0x87E5B0C
	public bool get_allowAutoConnect() { }

	// RVA: 0x87E5B48 Offset: 0x87E1B48 VA: 0x87E5B48
	public int get_groupingID() { }

	// RVA: 0x87E5B84 Offset: 0x87E1B84 VA: 0x87E5B84
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x87E5BF0 Offset: 0x87E1BF0 VA: 0x87E5BF0
	public static Terrain[] get_activeTerrains() { }

	// RVA: 0x87E5C18 Offset: 0x87E1C18 VA: 0x87E5C18
	public void .ctor() { }
}

// Namespace: 
public sealed class TerrainCallbacks.HeightmapChangedCallback : MulticastDelegate // TypeDefIndex: 28653
{
	// Methods

	// RVA: 0x87E5E84 Offset: 0x87E1E84 VA: 0x87E5E84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x87E5F38 Offset: 0x87E1F38 VA: 0x87E5F38 Slot: 13
	public virtual void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }
}

// Namespace: 
public sealed class TerrainCallbacks.TextureChangedCallback : MulticastDelegate // TypeDefIndex: 28654
{
	// Methods

	// RVA: 0x87E5F50 Offset: 0x87E1F50 VA: 0x87E5F50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x87E6004 Offset: 0x87E2004 VA: 0x87E6004 Slot: 13
	public virtual void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }
}

// Namespace: UnityEngine
[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainCallbacks // TypeDefIndex: 28655
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x87E5C20 Offset: 0x87E1C20 VA: 0x87E5C20
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCode]
	// RVA: 0x87E5D68 Offset: 0x87E1D68 VA: 0x87E5D68
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }
}

// Namespace: 
private enum TerrainData.BoundaryValueType // TypeDefIndex: 28656
{
	// Fields
	public int value__; // 0x0
	public const TerrainData.BoundaryValueType MaxHeightmapRes = 0;
	public const TerrainData.BoundaryValueType MinDetailResPerPatch = 1;
	public const TerrainData.BoundaryValueType MaxDetailResPerPatch = 2;
	public const TerrainData.BoundaryValueType MaxDetailPatchCount = 3;
	public const TerrainData.BoundaryValueType MaxCoveragePerRes = 4;
	public const TerrainData.BoundaryValueType MinAlphamapRes = 5;
	public const TerrainData.BoundaryValueType MaxAlphamapRes = 6;
	public const TerrainData.BoundaryValueType MinBaseMapRes = 7;
	public const TerrainData.BoundaryValueType MaxBaseMapRes = 8;
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
public sealed class TerrainData : Object // TypeDefIndex: 28657
{
	// Fields
	internal static readonly int k_MaximumResolution; // 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly int k_MaximumDetailPatchCount; // 0xC
	internal static readonly int k_MinimumAlphamapResolution; // 0x10
	internal static readonly int k_MaximumAlphamapResolution; // 0x14
	internal static readonly int k_MinimumBaseMapResolution; // 0x18
	internal static readonly int k_MaximumBaseMapResolution; // 0x1C

	// Properties
	public int heightmapResolution { get; }
	private int internalHeightmapResolution { get; }
	public Vector3 heightmapScale { get; }
	public int holesResolution { get; }
	public Vector3 size { get; }
	internal Terrain[] users { get; }

	// Methods

	[ThreadSafe]
	[StaticAccessor("TerrainDataScriptingInterface", 2)]
	// RVA: 0x87E601C Offset: 0x87E201C VA: 0x87E601C
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x87E6058 Offset: 0x87E2058 VA: 0x87E6058
	public void .ctor() { }

	[FreeFunction("TerrainDataScriptingInterface::Create")]
	// RVA: 0x87E60FC Offset: 0x87E20FC VA: 0x87E60FC
	private static void Internal_Create(TerrainData terrainData) { }

	// RVA: 0x87E6138 Offset: 0x87E2138 VA: 0x87E6138
	public int get_heightmapResolution() { }

	[NativeName("GetHeightmap().GetResolution")]
	// RVA: 0x87E6174 Offset: 0x87E2174 VA: 0x87E6174
	private int get_internalHeightmapResolution() { }

	[NativeName("GetHeightmap().GetScale")]
	// RVA: 0x87E61B0 Offset: 0x87E21B0 VA: 0x87E61B0
	public Vector3 get_heightmapScale() { }

	// RVA: 0x87E6250 Offset: 0x87E2250 VA: 0x87E6250
	public int get_holesResolution() { }

	[NativeName("GetHeightmap().GetSize")]
	// RVA: 0x87E6294 Offset: 0x87E2294 VA: 0x87E6294
	public Vector3 get_size() { }

	[NativeName("GetHeightmap().GetHeight")]
	// RVA: 0x87E6334 Offset: 0x87E2334 VA: 0x87E6334
	public float GetHeight(int x, int y) { }

	// RVA: 0x87E6388 Offset: 0x87E2388 VA: 0x87E6388
	public bool IsHole(int x, int y) { }

	[FreeFunction("TerrainDataScriptingInterface::IsHole", HasExplicitThis = True)]
	// RVA: 0x87E6490 Offset: 0x87E2490 VA: 0x87E6490
	private bool Internal_IsHole(int x, int y) { }

	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	[RequiredByNativeCode]
	// RVA: 0x87E64E4 Offset: 0x87E24E4 VA: 0x87E64E4
	internal float GetAlphamapResolutionInternal() { }

	// RVA: 0x87E5D2C Offset: 0x87E1D2C VA: 0x87E5D2C
	internal Terrain[] get_users() { }

	// RVA: 0x87E6520 Offset: 0x87E2520 VA: 0x87E6520
	private static void .cctor() { }

	// RVA: 0x87E620C Offset: 0x87E220C VA: 0x87E620C
	private void get_heightmapScale_Injected(out Vector3 ret) { }

	// RVA: 0x87E62F0 Offset: 0x87E22F0 VA: 0x87E62F0
	private void get_size_Injected(out Vector3 ret) { }
}

// Namespace: UnityEngine.TerrainUtils
internal enum TerrainMapStatusCode // TypeDefIndex: 28658
{
	// Fields
	public int value__; // 0x0
	public const TerrainMapStatusCode OK = 0;
	public const TerrainMapStatusCode Overlapping = 1;
	public const TerrainMapStatusCode SizeMismatch = 4;
	public const TerrainMapStatusCode EdgeAlignmentMismatch = 8;
}

// Namespace: UnityEngine.TerrainUtils
[IsReadOnly]
public struct TerrainTileCoord // TypeDefIndex: 28659
{
	// Fields
	public readonly int tileX; // 0x0
	public readonly int tileZ; // 0x4

	// Methods

	// RVA: 0x87E66E0 Offset: 0x87E26E0 VA: 0x87E66E0
	public void .ctor(int tileX, int tileZ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TerrainMap.<>c__DisplayClass3_0 // TypeDefIndex: 28660
{
	// Fields
	public int groupID; // 0x10

	// Methods

	// RVA: 0x87E6A0C Offset: 0x87E2A0C VA: 0x87E6A0C
	public void .ctor() { }

	// RVA: 0x87E79AC Offset: 0x87E39AC VA: 0x87E79AC
	internal bool <CreateFromPlacement>b__0(Terrain x) { }
}

// Namespace: UnityEngine.TerrainUtils
public class TerrainMap // TypeDefIndex: 28661
{
	// Fields
	private Vector3 m_patchSize; // 0x10
	private TerrainMapStatusCode m_errorCode; // 0x1C
	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; // 0x20

	// Properties
	public Dictionary<TerrainTileCoord, Terrain> terrainTiles { get; }

	// Methods

	// RVA: 0x87E66E8 Offset: 0x87E26E8 VA: 0x87E66E8
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x87E6760 Offset: 0x87E2760 VA: 0x87E6760
	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x87E6A14 Offset: 0x87E2A14 VA: 0x87E6A14
	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x87E7100 Offset: 0x87E3100 VA: 0x87E7100
	public Dictionary<TerrainTileCoord, Terrain> get_terrainTiles() { }

	// RVA: 0x87E6DFC Offset: 0x87E2DFC VA: 0x87E6DFC
	public void .ctor() { }

	// RVA: 0x87E7108 Offset: 0x87E3108 VA: 0x87E7108
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x87E6E88 Offset: 0x87E2E88 VA: 0x87E6E88
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x87E7230 Offset: 0x87E3230 VA: 0x87E7230
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x87E6F9C Offset: 0x87E2F9C VA: 0x87E6F9C
	private TerrainMapStatusCode Validate() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TerrainUtility.<>c__DisplayClass2_0 // TypeDefIndex: 28662
{
	// Fields
	public bool onlyAutoConnectedTerrains; // 0x10

	// Methods

	// RVA: 0x87E7E78 Offset: 0x87E3E78 VA: 0x87E7E78
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TerrainUtility.<>c__DisplayClass2_1 // TypeDefIndex: 28663
{
	// Fields
	public Terrain t; // 0x10
	public TerrainUtility.<>c__DisplayClass2_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x87E7E80 Offset: 0x87E3E80 VA: 0x87E7E80
	public void .ctor() { }

	// RVA: 0x87E8210 Offset: 0x87E4210 VA: 0x87E8210
	internal bool <CollectTerrains>b__0(Terrain x) { }
}

// Namespace: UnityEngine.TerrainUtils
[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainUtility // TypeDefIndex: 28664
{
	// Methods

	// RVA: 0x87E7A04 Offset: 0x87E3A04 VA: 0x87E7A04
	internal static bool ValidTerrainsExist() { }

	// RVA: 0x87E7A6C Offset: 0x87E3A6C VA: 0x87E7A6C
	internal static void ClearConnectivity() { }

	// RVA: 0x87E7B64 Offset: 0x87E3B64 VA: 0x87E7B64
	internal static Dictionary<int, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = True) { }

	[RequiredByNativeCode]
	// RVA: 0x87E7E88 Offset: 0x87E3E88 VA: 0x87E7E88
	public static void AutoConnect() { }
}

