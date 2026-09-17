// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 23138
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 23139
{
	// Methods

	// RVA: 0x7D5AD64 Offset: 0x7D56D64 VA: 0x7D5AD64
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 23140
{
	// Methods

	// RVA: 0x7D5AD6C Offset: 0x7D56D6C VA: 0x7D5AD6C
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentCharacterController2D : EntityComponentBase<CharacterController2D_Prototype> // TypeDefIndex: 23141
{
	// Methods

	// RVA: 0x7D5AD74 Offset: 0x7D56D74 VA: 0x7D5AD74
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentCharacterController3D : EntityComponentBase<CharacterController3D_Prototype> // TypeDefIndex: 23142
{
	// Methods

	// RVA: 0x7D5ADBC Offset: 0x7D56DBC VA: 0x7D5ADBC
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentNavMeshAvoidanceAgent : EntityComponentBase<NavMeshAvoidanceAgent_Prototype> // TypeDefIndex: 23143
{
	// Methods

	// RVA: 0x7D5AE04 Offset: 0x7D56E04 VA: 0x7D5AE04
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentNavMeshAvoidanceObstacle : EntityComponentBase<NavMeshAvoidanceObstacle_Prototype> // TypeDefIndex: 23144
{
	// Methods

	// RVA: 0x7D5AE4C Offset: 0x7D56E4C VA: 0x7D5AE4C
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentNavMeshPathfinder : EntityComponentBase<NavMeshPathfinder_Prototype> // TypeDefIndex: 23145
{
	// Fields
	[DrawIf("Prototype.InitialTargetNavMesh.Id.Value", 0, 0, 2)]
	[LocalReference]
	public MapNavMeshDefinition InitialTargetNavMeshReference; // 0x28

	// Methods

	// RVA: 0x7D5AE94 Offset: 0x7D56E94 VA: 0x7D5AE94 Slot: 5
	public override void Refresh() { }

	// RVA: 0x7D5AF30 Offset: 0x7D56F30 VA: 0x7D5AF30
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentNavMeshSteeringAgent : EntityComponentBase<NavMeshSteeringAgent_Prototype> // TypeDefIndex: 23146
{
	// Methods

	// RVA: 0x7D5AF78 Offset: 0x7D56F78 VA: 0x7D5AF78
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
[RequireComponent(typeof(EntityComponentPhysicsCollider2D))]
public class EntityComponentPhysicsBody2D : EntityComponentBase<PhysicsBody2D_Prototype> // TypeDefIndex: 23147
{
	// Methods

	// RVA: 0x7D5AFC0 Offset: 0x7D56FC0 VA: 0x7D5AFC0
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(EntityComponentPhysicsCollider3D))]
[DisallowMultipleComponent]
public class EntityComponentPhysicsBody3D : EntityComponentBase<PhysicsBody3D_Prototype> // TypeDefIndex: 23148
{
	// Methods

	// RVA: 0x7D5B008 Offset: 0x7D57008 VA: 0x7D5B008
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
[RequireComponent(typeof(EntityComponentPhysicsCollider2D))]
public class EntityComponentPhysicsCallbacks2D : EntityComponentBase<PhysicsCallbacks2D_Prototype> // TypeDefIndex: 23149
{
	// Methods

	// RVA: 0x7D5B050 Offset: 0x7D57050 VA: 0x7D5B050
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(EntityComponentPhysicsCollider3D))]
[DisallowMultipleComponent]
public class EntityComponentPhysicsCallbacks3D : EntityComponentBase<PhysicsCallbacks3D_Prototype> // TypeDefIndex: 23150
{
	// Methods

	// RVA: 0x7D5B098 Offset: 0x7D57098 VA: 0x7D5B098
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentPhysicsCollider2D : EntityComponentBase<PhysicsCollider2D_Prototype> // TypeDefIndex: 23151
{
	// Fields
	[MultiTypeReference(new[] { typeof(BoxCollider2D), typeof(CircleCollider2D), typeof(BoxCollider), typeof(SphereCollider) })]
	public Component SourceCollider; // 0x28

	// Methods

	// RVA: 0x7D5B0E0 Offset: 0x7D570E0 VA: 0x7D5B0E0
	private void OnValidate() { }

	// RVA: 0x7D5B774 Offset: 0x7D57774 VA: 0x7D5B774 Slot: 5
	public override void Refresh() { }

	// RVA: 0x7D5B7F4 Offset: 0x7D577F4 VA: 0x7D5B7F4
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentPhysicsCollider3D : EntityComponentBase<PhysicsCollider3D_Prototype> // TypeDefIndex: 23152
{
	// Fields
	[MultiTypeReference(new[] { typeof(BoxCollider), typeof(SphereCollider) })]
	public Collider SourceCollider3D; // 0x28

	// Methods

	// RVA: 0x7D5B83C Offset: 0x7D5783C VA: 0x7D5B83C
	private void OnValidate() { }

	// RVA: 0x7D5BC28 Offset: 0x7D57C28 VA: 0x7D5BC28 Slot: 5
	public override void Refresh() { }

	// RVA: 0x7D5BCB4 Offset: 0x7D57CB4 VA: 0x7D5BCB4
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(EntityPrototype))]
[DisallowMultipleComponent]
public class EntityComponentPhysicsJoints2D : EntityComponentBase<PhysicsJoints2D_Prototype, PhysicsJoints2D_Prototype> // TypeDefIndex: 23153
{
	// Methods

	// RVA: 0x7D5BCFC Offset: 0x7D57CFC VA: 0x7D5BCFC
	private void OnValidate() { }

	// RVA: 0x7D5BF08 Offset: 0x7D57F08 VA: 0x7D5BF08 Slot: 5
	public override void Refresh() { }

	// RVA: 0x7D5BD00 Offset: 0x7D57D00 VA: 0x7D5BD00
	private void AutoConfigureDistance() { }

	// RVA: 0x7D5BF0C Offset: 0x7D57F0C VA: 0x7D5BF0C
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
[RequireComponent(typeof(EntityPrototype))]
public class EntityComponentPhysicsJoints3D : EntityComponentBase<PhysicsJoints3D_Prototype, PhysicsJoints3D_Prototype> // TypeDefIndex: 23154
{
	// Methods

	// RVA: 0x7D5BF54 Offset: 0x7D57F54 VA: 0x7D5BF54
	private void OnValidate() { }

	// RVA: 0x7D5BF60 Offset: 0x7D57F60 VA: 0x7D5BF60 Slot: 5
	public override void Refresh() { }

	// RVA: 0x7D5BF64 Offset: 0x7D57F64 VA: 0x7D5BF64
	private void AutoConfigureDistance() { }

	// RVA: 0x7D5C214 Offset: 0x7D58214 VA: 0x7D5C214
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentTransform2D : EntityComponentBase<Transform2D_Prototype> // TypeDefIndex: 23155
{
	// Fields
	public bool AutoSetPosition; // 0x28
	public bool AutoSetRotation; // 0x29

	// Methods

	// RVA: 0x7D5C25C Offset: 0x7D5825C VA: 0x7D5C25C
	private void OnValidate() { }

	// RVA: 0x7D5C268 Offset: 0x7D58268 VA: 0x7D5C268 Slot: 5
	public override void Refresh() { }

	// RVA: 0x7D5C2EC Offset: 0x7D582EC VA: 0x7D5C2EC
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentTransform2DVertical : EntityComponentBase<Transform2DVertical_Prototype> // TypeDefIndex: 23156
{
	// Fields
	[Tooltip("If not set lossyScale.y of the transform will be used")]
	public bool AutoSetHeight; // 0x28
	public bool AutoSetPosition; // 0x29

	// Methods

	// RVA: 0x7D5C33C Offset: 0x7D5833C VA: 0x7D5C33C
	private void OnValidate() { }

	// RVA: 0x7D5C348 Offset: 0x7D58348 VA: 0x7D5C348 Slot: 5
	public override void Refresh() { }

	// RVA: 0x7D5C3D4 Offset: 0x7D583D4 VA: 0x7D5C3D4
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentTransform3D : EntityComponentBase<Transform3D_Prototype> // TypeDefIndex: 23157
{
	// Fields
	public bool AutoSetPosition; // 0x28
	public bool AutoSetRotation; // 0x29

	// Methods

	// RVA: 0x7D5C424 Offset: 0x7D58424 VA: 0x7D5C424
	private void OnValidate() { }

	// RVA: 0x7D5C430 Offset: 0x7D58430 VA: 0x7D5C430 Slot: 5
	public override void Refresh() { }

	// RVA: 0x7D5C540 Offset: 0x7D58540 VA: 0x7D5C540
	public void .ctor() { }
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentView : EntityComponentBase<View_Prototype> // TypeDefIndex: 23158
{
	// Methods

	// RVA: 0x7D5C590 Offset: 0x7D58590 VA: 0x7D5C590
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Configurations/SimulationConfig", fileName = "SimulationConfig", order = -999)]
public class SimulationConfigAsset : AssetBase // TypeDefIndex: 23159
{
	// Fields
	public SimulationConfig Settings; // 0x18

	// Properties
	public override AssetObject AssetObject { get; }
	public static SimulationConfigAsset Instance { get; }

	// Methods

	// RVA: 0x7D5C5D8 Offset: 0x7D585D8 VA: 0x7D5C5D8 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D5C5E0 Offset: 0x7D585E0 VA: 0x7D5C5E0
	public static SimulationConfigAsset get_Instance() { }

	// RVA: 0x7D5C654 Offset: 0x7D58654 VA: 0x7D5C654 Slot: 6
	public override void Loaded() { }

	// RVA: 0x7D5C684 Offset: 0x7D58684 VA: 0x7D5C684 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D5C870 Offset: 0x7D58870 VA: 0x7D5C870
	public void .ctor() { }
}

// Namespace: 
[Extension]
public static class SimulationConfigAssetExts // TypeDefIndex: 23160
{
	// Methods

	[Extension]
	// RVA: 0x7D5C880 Offset: 0x7D58880 VA: 0x7D5C880
	public static SimulationConfigAsset GetUnityAsset(SimulationConfig data) { }
}

// Namespace: 
public class QuantumAOT // TypeDefIndex: 23161
{
	// Fields
	public List<FPVector2> FPVector2; // 0x10
	public List<AssetRefNavMesh> AssetRefNavMesh; // 0x18
	public List<FrameBase.EntitiesConfig.ComponentBufferConfig> ComponentBufferConfig; // 0x20
	public List<MapStaticCollider2D> MapStaticCollider2D; // 0x28
	public List<MapStaticCollider3D> MapStaticCollider3D; // 0x30
	public List<byte> Byte; // 0x38
	public List<int> Int32; // 0x40

	// Methods

	[Preserve]
	// RVA: 0x7D5C900 Offset: 0x7D58900 VA: 0x7D5C900
	private static void PreserveReflectedMethods() { }

	// RVA: 0x7D5C908 Offset: 0x7D58908 VA: 0x7D5C908
	public void .ctor() { }
}

// Namespace: 
public abstract class AssetBase : ScriptableObject // TypeDefIndex: 23162
{
	// Fields
	public const string DefaultAssetObjectPropertyPath = "Settings";
	public const char NestedPathSeparator = '\x7c';

	// Properties
	public abstract AssetObject AssetObject { get; }
	public bool IsTransient { get; }
	public virtual string AssetObjectPropertyPath { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract AssetObject get_AssetObject();

	// RVA: 0x7D5C910 Offset: 0x7D58910 VA: 0x7D5C910
	public bool get_IsTransient() { }

	// RVA: 0x7D5C964 Offset: 0x7D58964 VA: 0x7D5C964 Slot: 5
	public virtual string get_AssetObjectPropertyPath() { }

	// RVA: 0x7D5C9A4 Offset: 0x7D589A4 VA: 0x7D5C9A4 Slot: 6
	public virtual void Loaded() { }

	// RVA: 0x7D5C9B0 Offset: 0x7D589B0 VA: 0x7D5C9B0 Slot: 7
	public virtual void PrepareAsset() { }

	// RVA: 0x7D5C9B4 Offset: 0x7D589B4 VA: 0x7D5C9B4 Slot: 8
	public virtual void Disposed() { }

	// RVA: 0x7D5C800 Offset: 0x7D58800 VA: 0x7D5C800 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x7D5C9B8 Offset: 0x7D589B8 VA: 0x7D5C9B8 Slot: 10
	public virtual void Awake() { }

	// RVA: 0x7D5C9BC Offset: 0x7D589BC VA: 0x7D5C9BC
	private string GetNameForNesting() { }

	// RVA: 0x7D5CA50 Offset: 0x7D58A50 VA: 0x7D5CA50
	public static bool GetMainAssetPath(string path, out string mainAssetPath) { }

	// RVA: 0x7D5C878 Offset: 0x7D58878 VA: 0x7D5C878
	protected void .ctor() { }
}

// Namespace: 
public interface IQuantumPrefabBakedAsset // TypeDefIndex: 23163
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Import(QuantumPrefabAsset prefab, IQuantumPrefabNestedAsset asset);
}

// Namespace: 
public interface IQuantumPrefabNestedAsset // TypeDefIndex: 23164
{
	// Properties
	public abstract Component Parent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Component get_Parent();
}

// Namespace: 
public interface IQuantumPrefabNestedAsset<THostingComponent> : IQuantumPrefabNestedAsset // TypeDefIndex: 23165
{}

// Namespace: 
private sealed class UnityDB.Context : IDisposable // TypeDefIndex: 23166
{
	// Fields
	public QuantumUnityNativeAllocator Allocator; // 0x10
	public List<AssetResource> AssetResources; // 0x18
	public AssetResourceContainer ResourceContainer; // 0x20
	public UnityResourceLoader ResourceLoader; // 0x28
	public ResourceManagerDynamic ResourceManager; // 0x30

	// Methods

	// RVA: 0x7D5D688 Offset: 0x7D59688 VA: 0x7D5D688
	public void .ctor() { }

	// RVA: 0x7D5D954 Offset: 0x7D59954 VA: 0x7D5D954
	public ResourceManagerDynamic CreateResourceManager() { }

	// RVA: 0x7D5D280 Offset: 0x7D59280 VA: 0x7D5D280 Slot: 4
	public void Dispose() { }
}

// Namespace: 
public static class UnityDB // TypeDefIndex: 23167
{
	// Fields
	private static UnityDB.Context _context; // 0x0

	// Properties
	public static IEnumerable<AssetResource> AssetResources { get; }
	[Obsolete("Use DefaultResourceManager instead")]
	public static ResourceManagerDynamic ResourceManager { get; }
	public static ResourceManagerDynamic DefaultResourceManager { get; }

	// Methods

	// RVA: 0x7D5CAC4 Offset: 0x7D58AC4 VA: 0x7D5CAC4
	private static void .cctor() { }

	// RVA: 0x7D5CAC8 Offset: 0x7D58AC8 VA: 0x7D5CAC8
	public static IEnumerable<AssetResource> get_AssetResources() { }

	// RVA: 0x7D5CBEC Offset: 0x7D58BEC VA: 0x7D5CBEC
	public static ResourceManagerDynamic get_ResourceManager() { }

	// RVA: 0x7D5CC38 Offset: 0x7D58C38 VA: 0x7D5CC38
	public static ResourceManagerDynamic get_DefaultResourceManager() { }

	// RVA: 0x7D5CC94 Offset: 0x7D58C94 VA: 0x7D5CC94
	public static List<QTuple<AssetRef, string>> CollectAddressableAssets() { }

	// RVA: 0x7D5CD30 Offset: 0x7D58D30 VA: 0x7D5CD30
	public static void CollectAddressableAssets(List<QTuple<AssetRef, string>> entries) { }

	// RVA: 0x7D5D108 Offset: 0x7D59108 VA: 0x7D5D108
	public static void Dispose() { }

	// RVA: -1 Offset: -1
	public static T FindAsset<T>(AssetObject asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47507E4 Offset: 0x474C7E4 VA: 0x47507E4
	|-UnityDB.FindAsset<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindAsset<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4750874 Offset: 0x474C874 VA: 0x4750874
	|-UnityDB.FindAsset<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindAsset<T>(AssetGuid guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4750714 Offset: 0x474C714 VA: 0x4750714
	|-UnityDB.FindAsset<object>
	*/

	// RVA: 0x7D5D434 Offset: 0x7D59434 VA: 0x7D5D434
	public static AssetBase FindAsset(string path) { }

	// RVA: 0x7D5D4F0 Offset: 0x7D594F0 VA: 0x7D5D4F0
	public static AssetBase FindAsset(AssetGuid guid) { }

	// RVA: 0x7D5D5AC Offset: 0x7D595AC VA: 0x7D5D5AC
	public static AssetGuid GetAssetGuid(string path) { }

	// RVA: 0x7D5D610 Offset: 0x7D59610 VA: 0x7D5D610
	public static void Update() { }

	// RVA: 0x7D5CB24 Offset: 0x7D58B24 VA: 0x7D5CB24
	private static UnityDB.Context GetOrCreateContext() { }

	// RVA: 0x7D5D7C8 Offset: 0x7D597C8 VA: 0x7D5D7C8
	private static AssetResourceContainer LoadContainer() { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Binary Data", order = -491)]
public class BinaryDataAsset : AssetBase, ISerializationCallbackReceiver // TypeDefIndex: 23168
{
	// Fields
	public BinaryData Settings; // 0x18
	public TextAsset SourceTextAsset; // 0x20

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x7D5D9C8 Offset: 0x7D599C8 VA: 0x7D5D9C8 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D5D9D0 Offset: 0x7D599D0 VA: 0x7D5D9D0 Slot: 7
	public override void PrepareAsset() { }

	// RVA: 0x7D5DA70 Offset: 0x7D59A70 VA: 0x7D5DA70 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D5DAE4 Offset: 0x7D59AE4 VA: 0x7D5DAE4
	public void SetData(byte[] data, bool compressed) { }

	// RVA: 0x7D5DB50 Offset: 0x7D59B50 VA: 0x7D5DB50
	public void Store(Stream stream) { }

	// RVA: 0x7D5DBA8 Offset: 0x7D59BA8 VA: 0x7D5DBA8 Slot: 11
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x7D5DC98 Offset: 0x7D59C98 VA: 0x7D5DC98 Slot: 12
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x7D5DC9C Offset: 0x7D59C9C VA: 0x7D5DC9C
	public void .ctor() { }
}

// Namespace: 
[Extension]
public static class RawAssetAssetExt // TypeDefIndex: 23169
{
	// Methods

	[Extension]
	// RVA: 0x7D5DCA4 Offset: 0x7D59CA4 VA: 0x7D5DCA4
	public static BinaryDataAsset GetUnityAsset(BinaryData data) { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Physics/Character Controller 2D", order = -508)]
public class CharacterController2DConfigAsset : AssetBase // TypeDefIndex: 23170
{
	// Fields
	public CharacterController2DConfig Settings; // 0x18

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x7D5DD24 Offset: 0x7D59D24 VA: 0x7D5DD24 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D5DD2C Offset: 0x7D59D2C VA: 0x7D5DD2C Slot: 9
	public override void Reset() { }

	// RVA: 0x7D5DDA0 Offset: 0x7D59DA0 VA: 0x7D5DDA0 Slot: 6
	public override void Loaded() { }

	// RVA: 0x7D5DDC8 Offset: 0x7D59DC8 VA: 0x7D5DDC8
	public void .ctor() { }
}

// Namespace: 
[Extension]
public static class CharacterController3DConfigAssetExt // TypeDefIndex: 23171
{
	// Methods

	[Extension]
	// RVA: 0x7D5DDD0 Offset: 0x7D59DD0 VA: 0x7D5DDD0
	public static CharacterController2DConfigAsset GetUnityAsset(CharacterController2DConfig data) { }

	[Extension]
	// RVA: 0x7D5DE50 Offset: 0x7D59E50 VA: 0x7D5DE50
	public static CharacterController3DConfigAsset GetUnityAsset(CharacterController3DConfig data) { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Physics/Character Controller 3D", order = -508)]
public class CharacterController3DConfigAsset : AssetBase // TypeDefIndex: 23172
{
	// Fields
	public CharacterController3DConfig Settings; // 0x18

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x7D5DED0 Offset: 0x7D59ED0 VA: 0x7D5DED0 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D5DED8 Offset: 0x7D59ED8 VA: 0x7D5DED8 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D5DF4C Offset: 0x7D59F4C VA: 0x7D5DF4C Slot: 6
	public override void Loaded() { }

	// RVA: 0x7D5DF74 Offset: 0x7D59F74 VA: 0x7D5DF74
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(EntityPrototype))]
public abstract class EntityComponentBase : MonoBehaviour // TypeDefIndex: 23173
{
	// Fields
	private const string ExpectedTypeNamePrefix = "EntityComponent";

	// Properties
	public abstract Type PrototypeType { get; }
	public Type ComponentType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_PrototypeType();

	// RVA: 0x7D5DF7C Offset: 0x7D59F7C VA: 0x7D5DF7C
	public Type get_ComponentType() { }

	// RVA: 0x7D5DF98 Offset: 0x7D59F98 VA: 0x7D5DF98 Slot: 5
	public virtual void Refresh() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ComponentPrototype CreatePrototype(EntityPrototypeConverter converter);

	// RVA: 0x7D5DF9C Offset: 0x7D59F9C VA: 0x7D5DF9C
	public static Type UnityComponentTypeToQuantumPrototypeType(Type type) { }

	// RVA: 0x7D5E21C Offset: 0x7D5A21C VA: 0x7D5E21C
	public static Type UnityComponentTypeToQuantumComponentType(Type type) { }

	// RVA: 0x7D5E230 Offset: 0x7D5A230 VA: 0x7D5E230
	protected void .ctor() { }
}

// Namespace: 
public abstract class EntityComponentBase<TPrototype> : EntityComponentBase // TypeDefIndex: 23174
{
	// Fields
	[FormerlySerializedAs("prototype")]
	public TPrototype Prototype; // 0x0

	// Properties
	public override Type PrototypeType { get; }
	[Obsolete("Use Prototype field")]
	public TPrototype prototype { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override Type get_PrototypeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B3A50 Offset: 0x60AFA50 VA: 0x60B3A50
	|-EntityComponentBase<object>.get_PrototypeType
	*/

	// RVA: -1 Offset: -1
	public TPrototype get_prototype() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B3AB4 Offset: 0x60AFAB4 VA: 0x60B3AB4
	|-EntityComponentBase<object>.get_prototype
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override ComponentPrototype CreatePrototype(EntityPrototypeConverter converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B3ABC Offset: 0x60AFABC VA: 0x60B3ABC
	|-EntityComponentBase<object>.CreatePrototype
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B3AC4 Offset: 0x60AFAC4 VA: 0x60B3AC4
	|-EntityComponentBase<object>..ctor
	*/
}

// Namespace: 
public abstract class EntityComponentBase<TPrototype, TAdapter> : EntityComponentBase // TypeDefIndex: 23175
{
	// Fields
	[FormerlySerializedAs("prototype")]
	public TAdapter Prototype; // 0x0

	// Properties
	public override Type PrototypeType { get; }
	[Obsolete("Use Prototype field")]
	public TAdapter prototype { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override Type get_PrototypeType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B3B00 Offset: 0x60AFB00 VA: 0x60B3B00
	|-EntityComponentBase<object, object>.get_PrototypeType
	*/

	// RVA: -1 Offset: -1
	public TAdapter get_prototype() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B3B64 Offset: 0x60AFB64 VA: 0x60B3B64
	|-EntityComponentBase<object, object>.get_prototype
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override ComponentPrototype CreatePrototype(EntityPrototypeConverter converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B3B6C Offset: 0x60AFB6C VA: 0x60B3B6C
	|-EntityComponentBase<object, object>.CreatePrototype
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B3B8C Offset: 0x60AFB8C VA: 0x60B3B8C
	|-EntityComponentBase<object, object>..ctor
	*/
}

// Namespace: 
private class EntityPrototypeAsset.Visitor : ComponentPrototypeVisitor // TypeDefIndex: 23176
{
	// Methods

	// RVA: 0x7D5F4B4 Offset: 0x7D5B4B4 VA: 0x7D5F4B4 Slot: 22
	protected override void VisitFallback(ComponentPrototype prototype) { }

	// RVA: 0x7D5F4AC Offset: 0x7D5B4AC VA: 0x7D5F4AC
	public void .ctor() { }
}

// Namespace: 
public class EntityPrototypeAsset : AssetBase, IQuantumPrefabNestedAsset<EntityPrototype>, IQuantumPrefabNestedAsset // TypeDefIndex: 23177
{
	// Fields
	protected static readonly List<ComponentPrototype> prototypeBuffer; // 0x0
	private static readonly List<EntityComponentBase> behaviourBuffer; // 0x8
	private static readonly EntityPrototypeAsset.Visitor cache; // 0x10
	public EntityPrototype Settings; // 0x18
	public EntityPrototype Parent; // 0x20

	// Properties
	public override AssetObject AssetObject { get; }
	private Component IQuantumPrefabNestedAsset.Parent { get; }

	// Methods

	// RVA: 0x7D5E238 Offset: 0x7D5A238 VA: 0x7D5E238 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D5E240 Offset: 0x7D5A240 VA: 0x7D5E240 Slot: 11
	private Component IQuantumPrefabNestedAsset.get_Parent() { }

	// RVA: 0x7D5E248 Offset: 0x7D5A248 VA: 0x7D5E248 Slot: 6
	public override void Loaded() { }

	// RVA: 0x7D5E254 Offset: 0x7D5A254 VA: 0x7D5E254 Slot: 7
	public override void PrepareAsset() { }

	// RVA: 0x7D5F2A8 Offset: 0x7D5B2A8 VA: 0x7D5F2A8 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D5F378 Offset: 0x7D5B378 VA: 0x7D5F378
	public void .ctor() { }

	// RVA: 0x7D5F380 Offset: 0x7D5B380 VA: 0x7D5F380
	private static void .cctor() { }
}

// Namespace: 
[Extension]
public static class EntityPrototypeAssetExts // TypeDefIndex: 23178
{
	// Methods

	[Extension]
	// RVA: 0x7D5F588 Offset: 0x7D5B588 VA: 0x7D5F588
	public static EntityPrototypeAsset GetUnityAsset(EntityPrototype data) { }
}

// Namespace: 
internal class EntityPrototypeBakedAsset : EntityPrototypeAsset, IQuantumPrefabBakedAsset // TypeDefIndex: 23179
{
	// Fields
	public FlatEntityPrototypeContainer Container; // 0x28

	// Methods

	// RVA: 0x7D5F608 Offset: 0x7D5B608 VA: 0x7D5F608 Slot: 6
	public override void Loaded() { }

	// RVA: 0x7D5F614 Offset: 0x7D5B614 VA: 0x7D5F614 Slot: 7
	public override void PrepareAsset() { }

	// RVA: 0x7D5F808 Offset: 0x7D5B808 VA: 0x7D5F808 Slot: 12
	private void IQuantumPrefabBakedAsset.Import(QuantumPrefabAsset prefab, IQuantumPrefabNestedAsset asset) { }

	// RVA: 0x7D5F928 Offset: 0x7D5B928 VA: 0x7D5F928
	public void .ctor() { }
}

// Namespace: 
public class EntityViewAsset : AssetBase, IQuantumPrefabNestedAsset<EntityView>, IQuantumPrefabNestedAsset // TypeDefIndex: 23180
{
	// Fields
	public EntityView Settings; // 0x18
	public EntityView Parent; // 0x20

	// Properties
	[Obsolete("Use View instead")]
	public EntityView Prefab { get; }
	public EntityView View { get; }
	public override AssetObject AssetObject { get; }
	private Component IQuantumPrefabNestedAsset.Parent { get; }
	public virtual EntityViewAssetStatus ViewStatus { get; }

	// Methods

	// RVA: 0x7D5F980 Offset: 0x7D5B980 VA: 0x7D5F980
	public EntityView get_Prefab() { }

	// RVA: 0x7D5F988 Offset: 0x7D5B988 VA: 0x7D5F988
	public EntityView get_View() { }

	// RVA: 0x7D5F990 Offset: 0x7D5B990 VA: 0x7D5F990 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D5F998 Offset: 0x7D5B998 VA: 0x7D5F998 Slot: 11
	private Component IQuantumPrefabNestedAsset.get_Parent() { }

	// RVA: 0x7D5F9A0 Offset: 0x7D5B9A0 VA: 0x7D5F9A0 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D5FA14 Offset: 0x7D5BA14 VA: 0x7D5FA14 Slot: 12
	public virtual EntityViewAssetStatus get_ViewStatus() { }

	// RVA: 0x7D5FA1C Offset: 0x7D5BA1C VA: 0x7D5FA1C Slot: 13
	public virtual void LoadViewPrefab(bool async = False) { }

	// RVA: 0x7D5FA84 Offset: 0x7D5BA84 VA: 0x7D5FA84
	public void .ctor() { }
}

// Namespace: 
public enum EntityViewAssetStatus // TypeDefIndex: 23181
{
	// Fields
	public int value__; // 0x0
	public const EntityViewAssetStatus NotLoaded = 0;
	public const EntityViewAssetStatus Loading = 1;
	public const EntityViewAssetStatus Loaded = 2;
	public const EntityViewAssetStatus Error = 3;
}

// Namespace: 
internal class EntityViewBakedAsset : EntityViewAsset, IQuantumPrefabBakedAsset, QuantumPrefabAsset.IListener // TypeDefIndex: 23182
{
	// Fields
	public QuantumPrefabAsset PrefabAsset; // 0x28
	private EntityViewAssetStatus _status; // 0x30

	// Properties
	public override EntityViewAssetStatus ViewStatus { get; }

	// Methods

	// RVA: 0x7D5FA8C Offset: 0x7D5BA8C VA: 0x7D5FA8C Slot: 12
	public override EntityViewAssetStatus get_ViewStatus() { }

	// RVA: 0x7D5FA94 Offset: 0x7D5BA94 VA: 0x7D5FA94 Slot: 13
	public override void LoadViewPrefab(bool async) { }

	// RVA: 0x7D5FC2C Offset: 0x7D5BC2C VA: 0x7D5FC2C Slot: 6
	public override void Loaded() { }

	// RVA: 0x7D5FC38 Offset: 0x7D5BC38 VA: 0x7D5FC38 Slot: 7
	public override void PrepareAsset() { }

	// RVA: 0x7D5FC3C Offset: 0x7D5BC3C VA: 0x7D5FC3C Slot: 15
	private void QuantumPrefabAsset.IListener.Error(QuantumPrefabAsset source, Exception error) { }

	// RVA: 0x7D5FCD4 Offset: 0x7D5BCD4 VA: 0x7D5FCD4 Slot: 16
	private void QuantumPrefabAsset.IListener.Loaded(QuantumPrefabAsset source, GameObject prefab) { }

	// RVA: 0x7D5FD40 Offset: 0x7D5BD40 VA: 0x7D5FD40 Slot: 14
	private void IQuantumPrefabBakedAsset.Import(QuantumPrefabAsset prefab, IQuantumPrefabNestedAsset asset) { }

	// RVA: 0x7D5FDE8 Offset: 0x7D5BDE8 VA: 0x7D5FDE8
	public void .ctor() { }
}

// Namespace: 
public interface IQuantumPrefabNestedAssetHost // TypeDefIndex: 23183
{
	// Properties
	public abstract Type NestedAssetType { get; }
	public abstract Type SplitAssetType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_NestedAssetType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_SplitAssetType();
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Map", order = -588)]
public class MapAsset : AssetBase // TypeDefIndex: 23184
{
	// Fields
	public Map Settings; // 0x18
	public List<FlatEntityPrototypeContainer> Prototypes; // 0x20

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x7D5FDF0 Offset: 0x7D5BDF0 VA: 0x7D5FDF0 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D5FDF8 Offset: 0x7D5BDF8 VA: 0x7D5FDF8 Slot: 7
	public override void PrepareAsset() { }

	// RVA: 0x7D600D0 Offset: 0x7D5C0D0 VA: 0x7D600D0 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D6019C Offset: 0x7D5C19C VA: 0x7D6019C
	public void .ctor() { }
}

// Namespace: 
[Extension]
public static class MapAssetExts // TypeDefIndex: 23185
{
	// Methods

	[Extension]
	// RVA: 0x7D601A4 Offset: 0x7D5C1A4 VA: 0x7D601A4
	public static MapAsset GetUnityAsset(Map data) { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Navigation/NavMesh Agent Config", order = -549)]
public class NavMeshAgentConfigAsset : AssetBase // TypeDefIndex: 23186
{
	// Fields
	public NavMeshAgentConfig Settings; // 0x18

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x7D60224 Offset: 0x7D5C224 VA: 0x7D60224 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D6022C Offset: 0x7D5C22C VA: 0x7D6022C Slot: 9
	public override void Reset() { }

	// RVA: 0x7D602A0 Offset: 0x7D5C2A0 VA: 0x7D602A0
	public void .ctor() { }
}

// Namespace: 
[Extension]
public static class NavMeshAgentConfigAssetExts // TypeDefIndex: 23187
{
	// Methods

	[Extension]
	// RVA: 0x7D602A8 Offset: 0x7D5C2A8 VA: 0x7D602A8
	public static NavMeshAgentConfigAsset GetUnityAsset(NavMeshAgentConfig data) { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Navigation/NavMesh Asset", order = -549)]
public class NavMeshAsset : AssetBase // TypeDefIndex: 23188
{
	// Fields
	public NavMesh Settings; // 0x18

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x7D60328 Offset: 0x7D5C328 VA: 0x7D60328 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D60330 Offset: 0x7D5C330 VA: 0x7D60330 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D603A4 Offset: 0x7D5C3A4 VA: 0x7D603A4
	public void .ctor() { }
}

// Namespace: 
[Extension]
public static class NavMeshAssetExts // TypeDefIndex: 23189
{
	// Methods

	[Extension]
	// RVA: 0x7D603AC Offset: 0x7D5C3AC VA: 0x7D603AC
	public static NavMeshAsset GetUnityAsset(NavMesh data) { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Physics/Physics Material", order = -495)]
public class PhysicsMaterialAsset : AssetBase // TypeDefIndex: 23190
{
	// Fields
	public PhysicsMaterial Settings; // 0x18

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x7D6042C Offset: 0x7D5C42C VA: 0x7D6042C Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D60434 Offset: 0x7D5C434 VA: 0x7D60434 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D604A8 Offset: 0x7D5C4A8 VA: 0x7D604A8
	public void .ctor() { }
}

// Namespace: 
[Extension]
public static class PhysicsMaterialAssetExt // TypeDefIndex: 23191
{
	// Methods

	[Extension]
	// RVA: 0x7D604B0 Offset: 0x7D5C4B0 VA: 0x7D604B0
	public static PhysicsMaterialAsset GetUnityAsset(PhysicsMaterial data) { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Physics/Polygon Collider", order = -495)]
public class PolygonColliderAsset : AssetBase // TypeDefIndex: 23192
{
	// Fields
	public PolygonCollider Settings; // 0x18

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x7D60530 Offset: 0x7D5C530 VA: 0x7D60530 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D60538 Offset: 0x7D5C538 VA: 0x7D60538 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D605AC Offset: 0x7D5C5AC VA: 0x7D605AC
	public void .ctor() { }
}

// Namespace: 
[Extension]
public static class PolygonColliderAssetExt // TypeDefIndex: 23193
{
	// Methods

	[Extension]
	// RVA: 0x7D605B4 Offset: 0x7D5C5B4 VA: 0x7D605B4
	public static PolygonColliderAsset GetUnityAsset(PolygonCollider data) { }
}

// Namespace: 
public interface QuantumPrefabAsset.IListener // TypeDefIndex: 23194
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Error(QuantumPrefabAsset source, Exception error);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Loaded(QuantumPrefabAsset source, GameObject prefab);
}

// Namespace: 
protected struct QuantumPrefabAsset.LoadContext // TypeDefIndex: 23195
{
	// Fields
	public QuantumPrefabAsset.IListener Listener; // 0x0
	public QuantumPrefabAsset PrefabAsset; // 0x8
	public bool PreferAsync; // 0x10

	// Methods

	// RVA: 0x7D60B70 Offset: 0x7D5CB70 VA: 0x7D60B70
	public void Error(Exception error) { }

	// RVA: 0x7D60B94 Offset: 0x7D5CB94 VA: 0x7D60B94
	public void Loaded(GameObject prefab) { }
}

// Namespace: 
public abstract class QuantumPrefabAsset : ScriptableObject // TypeDefIndex: 23196
{
	// Fields
	public string PrefabGuid; // 0x18
	private GameObject _loadedInstance; // 0x20

	// Methods

	// RVA: 0x7D5FAC0 Offset: 0x7D5BAC0 VA: 0x7D5FAC0
	public void Load(QuantumPrefabAsset.IListener listener, bool async = False) { }

	// RVA: 0x7D60634 Offset: 0x7D5C634 VA: 0x7D60634
	public void UnloadInstance() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Load(in QuantumPrefabAsset.LoadContext context);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void Unload();

	// RVA: -1 Offset: -1
	private T EnsureComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B6BE0 Offset: 0x46B2BE0 VA: 0x46B6BE0
	|-QuantumPrefabAsset.EnsureComponent<object>
	*/

	// RVA: 0x7D60740 Offset: 0x7D5C740 VA: 0x7D60740
	private void LoadFinished(in QuantumPrefabAsset.LoadContext context, GameObject prefab) { }

	// RVA: 0x7D609F8 Offset: 0x7D5C9F8 VA: 0x7D609F8
	private void LoadFinished(in QuantumPrefabAsset.LoadContext context, Exception error) { }

	// RVA: 0x7D60B68 Offset: 0x7D5CB68 VA: 0x7D60B68
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumPrefabAsset_Addressable.<>c__DisplayClass1_0 // TypeDefIndex: 23197
{
	// Fields
	public QuantumPrefabAsset.LoadContext c; // 0x10

	// Methods

	// RVA: 0x7D60D8C Offset: 0x7D5CD8C VA: 0x7D60D8C
	public void .ctor() { }

	// RVA: 0x7D60DC0 Offset: 0x7D5CDC0 VA: 0x7D60DC0
	internal void <Load>b__0(AsyncOperationHandle<GameObject> _op) { }
}

// Namespace: 
public class QuantumPrefabAsset_Addressable : QuantumPrefabAsset // TypeDefIndex: 23198
{
	// Fields
	public AssetReferenceGameObject Address; // 0x28

	// Methods

	// RVA: 0x7D60BB8 Offset: 0x7D5CBB8 VA: 0x7D60BB8 Slot: 4
	protected override void Load(in QuantumPrefabAsset.LoadContext context) { }

	// RVA: 0x7D60D94 Offset: 0x7D5CD94 VA: 0x7D60D94 Slot: 5
	protected override void Unload() { }

	// RVA: 0x7D60DB8 Offset: 0x7D5CDB8 VA: 0x7D60DB8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumPrefabAsset_AssetBundle.<>c__DisplayClass4_0 // TypeDefIndex: 23199
{
	// Fields
	public QuantumPrefabAsset.LoadContext cc; // 0x10
	public QuantumPrefabAsset_AssetBundle <>4__this; // 0x28

	// Methods

	// RVA: 0x7D61188 Offset: 0x7D5D188 VA: 0x7D61188
	public void .ctor() { }

	// RVA: 0x7D612E0 Offset: 0x7D5D2E0 VA: 0x7D612E0
	internal void <Load>b__1(AsyncOperation op) { }
}

// Namespace: 
public class QuantumPrefabAsset_AssetBundle : QuantumPrefabAsset // TypeDefIndex: 23200
{
	// Fields
	public string AssetBundle; // 0x28
	public string AssetName; // 0x30
	private object _state; // 0x38
	private AssetBundle _bundle; // 0x40

	// Methods

	// RVA: 0x7D60E24 Offset: 0x7D5CE24 VA: 0x7D60E24 Slot: 4
	protected override void Load(in QuantumPrefabAsset.LoadContext context) { }

	// RVA: 0x7D61190 Offset: 0x7D5D190 VA: 0x7D61190 Slot: 5
	protected override void Unload() { }

	// RVA: 0x7D61254 Offset: 0x7D5D254 VA: 0x7D61254
	private void UnloadPrefab(GameObject prefab) { }

	// RVA: 0x7D612AC Offset: 0x7D5D2AC VA: 0x7D612AC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7D612B4 Offset: 0x7D5D2B4 VA: 0x7D612B4
	private bool <Load>b__4_0(AssetBundle ab) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumPrefabAsset_Resource.<>c__DisplayClass2_0 // TypeDefIndex: 23201
{
	// Fields
	public QuantumPrefabAsset_Resource <>4__this; // 0x10
	public QuantumPrefabAsset.LoadContext cc; // 0x18

	// Methods

	// RVA: 0x7D615F8 Offset: 0x7D5D5F8 VA: 0x7D615F8
	public void .ctor() { }

	// RVA: 0x7D616C8 Offset: 0x7D5D6C8 VA: 0x7D616C8
	internal void <Load>b__0(AsyncOperation op) { }
}

// Namespace: 
public class QuantumPrefabAsset_Resource : QuantumPrefabAsset // TypeDefIndex: 23202
{
	// Fields
	public string ResourcePath; // 0x28
	private object _state; // 0x30

	// Methods

	// RVA: 0x7D61424 Offset: 0x7D5D424 VA: 0x7D61424 Slot: 4
	protected override void Load(in QuantumPrefabAsset.LoadContext context) { }

	// RVA: 0x7D61600 Offset: 0x7D5D600 VA: 0x7D61600 Slot: 5
	protected override void Unload() { }

	// RVA: 0x7D616B4 Offset: 0x7D5D6B4 VA: 0x7D616B4
	private void UnloadPrefab(GameObject asset) { }

	// RVA: 0x7D616C0 Offset: 0x7D5D6C0 VA: 0x7D616C0
	public void .ctor() { }
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Physics/Terrain Collider 3D", order = -491)]
public class TerrainColliderAsset : AssetBase // TypeDefIndex: 23203
{
	// Fields
	public TerrainCollider Settings; // 0x18

	// Properties
	public override AssetObject AssetObject { get; }

	// Methods

	// RVA: 0x7D61810 Offset: 0x7D5D810 VA: 0x7D61810 Slot: 4
	public override AssetObject get_AssetObject() { }

	// RVA: 0x7D61818 Offset: 0x7D5D818 VA: 0x7D61818 Slot: 9
	public override void Reset() { }

	// RVA: 0x7D6188C Offset: 0x7D5D88C VA: 0x7D6188C
	public void .ctor() { }
}

// Namespace: 
[Extension]
public static class TerrainColliderAssetExt // TypeDefIndex: 23204
{
	// Methods

	[Extension]
	// RVA: 0x7D61894 Offset: 0x7D5D894 VA: 0x7D61894
	public static TerrainColliderAsset GetUnityAsset(TerrainCollider data) { }
}

// Namespace: 
public enum SimulationConfigAssetHelper.PhysicsType // TypeDefIndex: 23205
{
	// Fields
	public int value__; // 0x0
	public const SimulationConfigAssetHelper.PhysicsType Physics3D = 0;
	public const SimulationConfigAssetHelper.PhysicsType Physics2D = 1;
}

// Namespace: 
[Extension]
public static class SimulationConfigAssetHelper // TypeDefIndex: 23206
{
	// Methods

	[Extension]
	// RVA: 0x7D5C804 Offset: 0x7D58804 VA: 0x7D5C804
	public static void ImportLayersFromUnity(SimulationConfigAsset data, SimulationConfigAssetHelper.PhysicsType physicsType = 0) { }

	// RVA: 0x7D61914 Offset: 0x7D5D914 VA: 0x7D61914
	public static string[] GetUnityLayerNameArray() { }

	// RVA: 0x7D61A48 Offset: 0x7D5DA48 VA: 0x7D61A48
	public static int[] GetUnityLayerMatrix(SimulationConfigAssetHelper.PhysicsType physicsType) { }
}

// Namespace: 
public interface IQuantumUnityDispatcher // TypeDefIndex: 23207
{}

// Namespace: 
[Extension]
public static class IQuantumUnityDispatcherExtensions // TypeDefIndex: 23208
{
	// Fields
	public const uint CustomFlag_IsUnityObject = 256;
	public const uint CustomFlag_OnlyIfActiveAndEnabled = 512;

	// Methods

	[Extension]
	// RVA: 0x7D61BAC Offset: 0x7D5DBAC VA: 0x7D61BAC
	internal static DispatcherBase.ListenerStatus GetUnityListenerStatus(IQuantumUnityDispatcher _, object listener, uint flags) { }

	[Extension]
	// RVA: -1 Offset: -1
	internal static DispatcherSubscription Subscribe<TDispatcher, T>(TDispatcher dispatcher, Object listener, DispatchableHandler<T> handler, bool once = False, bool onlyIfActiveAndEnabled = False, DispatchableFilter filter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4645928 Offset: 0x4641928 VA: 0x4645928
	|-IQuantumUnityDispatcherExtensions.Subscribe<object, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
public class QuantumEvent : QuantumUnityStaticDispatcherAdapter<QuantumUnityEventDispatcher, EventBase> // TypeDefIndex: 23209
{
	// Methods

	// RVA: 0x7D61CF0 Offset: 0x7D5DCF0 VA: 0x7D61CF0
	private void .ctor() { }
}

// Namespace: 
public class QuantumUnityEventDispatcher : EventDispatcher, IQuantumUnityDispatcher // TypeDefIndex: 23210
{
	// Methods

	// RVA: 0x7D61D54 Offset: 0x7D5DD54 VA: 0x7D61D54 Slot: 4
	protected override DispatcherBase.ListenerStatus GetListenerStatus(object listener, uint flags) { }

	// RVA: 0x7D61D58 Offset: 0x7D5DD58 VA: 0x7D61D58
	public void .ctor() { }
}

// Namespace: 
protected sealed class QuantumUnityStaticDispatcherAdapter.Worker : MonoBehaviour // TypeDefIndex: 23211
{
	// Fields
	public DispatcherBase Dispatcher; // 0x20

	// Methods

	// RVA: 0x7D61D68 Offset: 0x7D5DD68 VA: 0x7D61D68
	private void LateUpdate() { }

	// RVA: 0x7D61DEC Offset: 0x7D5DDEC VA: 0x7D61DEC
	public void .ctor() { }
}

// Namespace: 
public abstract class QuantumUnityStaticDispatcherAdapter // TypeDefIndex: 23212
{
	// Methods

	// RVA: 0x7D61D60 Offset: 0x7D5DD60 VA: 0x7D61D60
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass16_0<TDispatcher, TDispatchableBase> // TypeDefIndex: 23213
{
	// Fields
	public DispatchableFilter first; // 0x0
	public DispatchableFilter second; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486764C Offset: 0x486364C VA: 0x486764C
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass16_0<object, object>..ctor
	|
	|-RVA: 0x48676B8 Offset: 0x48636B8 VA: 0x48676B8
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass16_0<object, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ComposeFilters>b__0(IDeterministicGame x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867654 Offset: 0x4863654 VA: 0x4867654
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass16_0<object, object>.<ComposeFilters>b__0
	|
	|-RVA: 0x48676C0 Offset: 0x48636C0 VA: 0x48676C0
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass16_0<object, __Il2CppFullySharedGenericType>.<ComposeFilters>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass6_0<TDispatcher, TDispatchableBase, TDispatchable> // TypeDefIndex: 23214
{
	// Fields
	public EntityView view; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E134 Offset: 0x545A134 VA: 0x545E134
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass6_0<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <Subscribe>b__0(IDeterministicGame _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545E13C Offset: 0x545A13C VA: 0x545E13C
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass6_0<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<Subscribe>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass7_0<TDispatcher, TDispatchableBase, TDispatchable> // TypeDefIndex: 23215
{
	// Fields
	public string runnerId; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5460698 Offset: 0x545C698 VA: 0x5460698
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass7_0<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <Subscribe>b__0(IDeterministicGame game) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54606A0 Offset: 0x545C6A0 VA: 0x54606A0
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass7_0<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<Subscribe>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass8_0<TDispatcher, TDispatchableBase, TDispatchable> // TypeDefIndex: 23216
{
	// Fields
	public int runnerInstanceId; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469880 Offset: 0x5465880 VA: 0x5469880
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass8_0<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <Subscribe>b__0(IDeterministicGame game) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469888 Offset: 0x5465888 VA: 0x5469888
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass8_0<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<Subscribe>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass9_0<TDispatcher, TDispatchableBase, TDispatchable> // TypeDefIndex: 23217
{
	// Fields
	public QuantumGame game; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B498 Offset: 0x5467498 VA: 0x546B498
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass9_0<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <Subscribe>b__0(IDeterministicGame g) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B4A0 Offset: 0x54674A0 VA: 0x546B4A0
	|-QuantumUnityStaticDispatcherAdapter.<>c__DisplayClass9_0<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<Subscribe>b__0
	*/
}

// Namespace: 
public abstract class QuantumUnityStaticDispatcherAdapter<TDispatcher, TDispatchableBase> : QuantumUnityStaticDispatcherAdapter // TypeDefIndex: 23218
{
	// Fields
	protected static QuantumUnityStaticDispatcherAdapter.Worker _worker; // 0x0
	[CompilerGenerated]
	private static readonly TDispatcher <Dispatcher>k__BackingField; // 0x0

	// Properties
	public static TDispatcher Dispatcher { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static TDispatcher get_Dispatcher() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AA258 Offset: 0x52A6258 VA: 0x52AA258
	|-QuantumUnityStaticDispatcherAdapter<object, object>.get_Dispatcher
	|
	|-RVA: 0x52AAEB4 Offset: 0x52A6EB4 VA: 0x52AAEB4
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.get_Dispatcher
	*/

	// RVA: -1 Offset: -1
	public static void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AA2C4 Offset: 0x52A62C4 VA: 0x52AA2C4
	|-QuantumUnityStaticDispatcherAdapter<object, object>.Clear
	|
	|-RVA: 0x52AAF20 Offset: 0x52A6F20 VA: 0x52AAF20
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public static void RemoveDeadListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AA4F8 Offset: 0x52A64F8 VA: 0x52AA4F8
	|-QuantumUnityStaticDispatcherAdapter<object, object>.RemoveDeadListeners
	|
	|-RVA: 0x52AB134 Offset: 0x52A7134 VA: 0x52AB134
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.RemoveDeadListeners
	*/

	// RVA: -1 Offset: -1
	public static DispatcherSubscription Subscribe<TDispatchable>(Object listener, DispatchableHandler<TDispatchable> handler, DispatchableFilter filter, bool once = False, bool onlyIfActiveAndEnabled = False, bool onlyIfEntityViewBound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4347530 Offset: 0x4343530 VA: 0x4347530
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.Subscribe<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static DispatcherSubscription Subscribe<TDispatchable>(Object listener, DispatchableHandler<TDispatchable> handler, string runnerId, bool once = False, bool onlyIfActiveAndEnabled = False, bool onlyIfEntityViewBound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4347BA0 Offset: 0x4343BA0 VA: 0x4347BA0
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.Subscribe<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static DispatcherSubscription Subscribe<TDispatchable>(Object listener, DispatchableHandler<TDispatchable> handler, QuantumRunner runner, bool once = False, bool onlyIfActiveAndEnabled = False, bool onlyIfEntityViewBound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4347A70 Offset: 0x4343A70 VA: 0x4347A70
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.Subscribe<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static DispatcherSubscription Subscribe<TDispatchable>(Object listener, DispatchableHandler<TDispatchable> handler, QuantumGame game, bool once = False, bool onlyIfActiveAndEnabled = False, bool onlyIfEntityViewBound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4347944 Offset: 0x4343944 VA: 0x4347944
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.Subscribe<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IDisposable SubscribeManual<TDispatchable>(object listener, DispatchableHandler<TDispatchable> handler, DispatchableFilter filter, bool once = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4347DAC Offset: 0x4343DAC VA: 0x4347DAC
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.SubscribeManual<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IDisposable SubscribeManual<TDispatchable>(DispatchableHandler<TDispatchable> handler, DispatchableFilter filter, bool once = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4347CCC Offset: 0x4343CCC VA: 0x4347CCC
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.SubscribeManual<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool Unsubscribe(DispatcherSubscription subscription) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AA5B8 Offset: 0x52A65B8 VA: 0x52AA5B8
	|-QuantumUnityStaticDispatcherAdapter<object, object>.Unsubscribe
	|
	|-RVA: 0x52AB1D4 Offset: 0x52A71D4 VA: 0x52AB1D4
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.Unsubscribe
	*/

	// RVA: -1 Offset: -1
	public static bool UnsubscribeListener(object listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AA690 Offset: 0x52A6690 VA: 0x52AA690
	|-QuantumUnityStaticDispatcherAdapter<object, object>.UnsubscribeListener
	|
	|-RVA: 0x52AB28C Offset: 0x52A728C VA: 0x52AB28C
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.UnsubscribeListener
	*/

	// RVA: -1 Offset: -1
	public static bool UnsubscribeListener<TDispatchable>(object listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4347E9C Offset: 0x4343E9C VA: 0x4347E9C
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.UnsubscribeListener<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void EnsureWorkerExistsAndIsActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AA768 Offset: 0x52A6768 VA: 0x52AA768
	|-QuantumUnityStaticDispatcherAdapter<object, object>.EnsureWorkerExistsAndIsActive
	|
	|-RVA: 0x52AB344 Offset: 0x52A7344 VA: 0x52AB344
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.EnsureWorkerExistsAndIsActive
	*/

	// RVA: -1 Offset: -1
	private static DispatchableFilter ComposeFilters(DispatchableFilter first, DispatchableFilter second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AACA4 Offset: 0x52A6CA4 VA: 0x52AACA4
	|-QuantumUnityStaticDispatcherAdapter<object, object>.ComposeFilters
	|
	|-RVA: 0x52AB85C Offset: 0x52A785C VA: 0x52AB85C
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>.ComposeFilters
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AAE10 Offset: 0x52A6E10 VA: 0x52AAE10
	|-QuantumUnityStaticDispatcherAdapter<object, object>..ctor
	|
	|-RVA: 0x52AB9F8 Offset: 0x52A79F8 VA: 0x52AB9F8
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AAE18 Offset: 0x52A6E18 VA: 0x52AAE18
	|-QuantumUnityStaticDispatcherAdapter<object, object>..cctor
	|
	|-RVA: 0x52ABA00 Offset: 0x52A7A00 VA: 0x52ABA00
	|-QuantumUnityStaticDispatcherAdapter<object, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
public abstract class ComponentPrototypeRefWrapperBase // TypeDefIndex: 23219
{
	// Fields
	public AssetRefEntityPrototype AssetPrototype; // 0x10

	// Properties
	public abstract string ComponentTypeName { get; }
	public abstract EntityComponentBase ScenePrototype { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_ComponentTypeName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract EntityComponentBase get_ScenePrototype();

	// RVA: 0x7D61DF4 Offset: 0x7D5DDF4 VA: 0x7D61DF4
	protected void .ctor() { }
}

// Namespace: 
public abstract class ComponentPrototypeRefWrapperBase<T, U> : ComponentPrototypeRefWrapperBase // TypeDefIndex: 23220
{
	// Fields
	[LocalReference]
	[SerializeField]
	private T _scenePrototype; // 0x0

	// Properties
	public override string ComponentTypeName { get; }
	public override EntityComponentBase ScenePrototype { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override string get_ComponentTypeName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA85D0 Offset: 0x5CA45D0 VA: 0x5CA85D0
	|-ComponentPrototypeRefWrapperBase<object, __Il2CppFullySharedGenericStructType>.get_ComponentTypeName
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override EntityComponentBase get_ScenePrototype() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA864C Offset: 0x5CA464C VA: 0x5CA864C
	|-ComponentPrototypeRefWrapperBase<object, __Il2CppFullySharedGenericStructType>.get_ScenePrototype
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA8654 Offset: 0x5CA4654 VA: 0x5CA8654
	|-ComponentPrototypeRefWrapperBase<object, __Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: 
[Serializable]
public class ComponentPrototypeRefWrapper : ComponentPrototypeRefWrapperBase // TypeDefIndex: 23221
{
	// Fields
	[SerializeField]
	[LocalReference]
	private EntityComponentBase _scenePrototype; // 0x18
	[SerializeField]
	private string _componentTypeName; // 0x20

	// Properties
	public override string ComponentTypeName { get; }
	public override EntityComponentBase ScenePrototype { get; }

	// Methods

	// RVA: 0x7D61DFC Offset: 0x7D5DDFC VA: 0x7D61DFC Slot: 4
	public override string get_ComponentTypeName() { }

	// RVA: 0x7D61E04 Offset: 0x7D5DE04 VA: 0x7D61E04 Slot: 5
	public override EntityComponentBase get_ScenePrototype() { }

	// RVA: 0x7D61E0C Offset: 0x7D5DE0C VA: 0x7D61E0C
	public void .ctor() { }
}

// Namespace: 
public enum EntityPrototypeTransformMode // TypeDefIndex: 23222
{
	// Fields
	public int value__; // 0x0
	public const EntityPrototypeTransformMode Transform2D = 0;
	public const EntityPrototypeTransformMode Transform3D = 1;
	public const EntityPrototypeTransformMode None = 2;
}

// Namespace: 
[Serializable]
public struct EntityPrototype.Transform2DVerticalInfo // TypeDefIndex: 23223
{
	// Fields
	[HideInInspector]
	public bool IsEnabled; // 0x0
	public FP Height; // 0x8
	public FP PositionOffset; // 0x10
}

// Namespace: 
[Serializable]
public struct EntityPrototype.PhysicsColliderGeneric // TypeDefIndex: 23224
{
	// Fields
	public bool IsTrigger; // 0x0
	public AssetRefPhysicsMaterial Material; // 0x8
	public Component SourceCollider; // 0x10
	[HideInInspector]
	public bool IsEnabled; // 0x18
	public Shape2DConfig Shape2D; // 0x20
	public Shape3DConfig Shape3D; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	[Layer]
	public int Layer; // 0x30
	public CallbackFlags_Wrapper CallbackFlags; // 0x34
}

// Namespace: 
[Serializable]
public struct EntityPrototype.PhysicsBodyGeneric // TypeDefIndex: 23225
{
	// Fields
	[HideInInspector]
	public bool IsEnabled; // 0x0
	[HideInInspector]
	public int Version2D; // 0x4
	[HideInInspector]
	public int Version3D; // 0x8
	[DisplayName("Config")]
	[EnumFlags]
	public PhysicsBody2D.ConfigFlags Config2D; // 0xC
	[DisplayName("Config")]
	[EnumFlags]
	public PhysicsBody3D.ConfigFlags Config3D; // 0xD
	[EnumFlags]
	public RotationFreezeFlags RotationFreeze; // 0xE
	public FP Mass; // 0x10
	public FP Drag; // 0x18
	public FP AngularDrag; // 0x20
	[DisplayName("Center Of Mass")]
	public FPVector2 CenterOfMass2D; // 0x28
	[DisplayName("Center Of Mass")]
	public FPVector3 CenterOfMass3D; // 0x38
	public NullableFP GravityScale; // 0x50

	// Properties
	[Obsolete("Use Version2D or Version3D instead.")]
	public int Version { get; set; }

	// Methods

	// RVA: 0x7D62488 Offset: 0x7D5E488 VA: 0x7D62488
	public int get_Version() { }

	// RVA: 0x7D62490 Offset: 0x7D5E490 VA: 0x7D62490
	public void set_Version(int value) { }

	// RVA: 0x7D61EEC Offset: 0x7D5DEEC VA: 0x7D61EEC
	public void EnsureVersionUpdated() { }
}

// Namespace: 
[Serializable]
public struct EntityPrototype.NavMeshPathfinderInfo // TypeDefIndex: 23226
{
	// Fields
	[HideInInspector]
	public bool IsEnabled; // 0x0
	public AssetRefNavMeshAgentConfig NavMeshAgentConfig; // 0x8
	[Optional("InitialTarget.IsEnabled")]
	public EntityPrototype.InitialNavMeshTargetInfo InitialTarget; // 0x10
}

// Namespace: 
[Serializable]
public struct EntityPrototype.InitialNavMeshTargetInfo // TypeDefIndex: 23227
{
	// Fields
	[HideInInspector]
	public bool IsEnabled; // 0x0
	public Transform Target; // 0x8
	[DrawIf("Target", 0, 0, 2)]
	public FPVector3 Position; // 0x10
	public EntityPrototype.NavMeshSpec NavMesh; // 0x28
}

// Namespace: 
[Serializable]
public struct EntityPrototype.NavMeshSpec // TypeDefIndex: 23228
{
	// Fields
	public MapNavMeshDefinition Reference; // 0x0
	public AssetRefNavMesh Asset; // 0x8
	public string Name; // 0x10
}

// Namespace: 
[Serializable]
public struct EntityPrototype.NavMeshSteeringAgentInfo // TypeDefIndex: 23229
{
	// Fields
	[HideInInspector]
	public bool IsEnabled; // 0x0
	[Optional("MaxSpeed.IsEnabled")]
	public EntityPrototype.OverrideFP MaxSpeed; // 0x8
	[Optional("Acceleration.IsEnabled")]
	public EntityPrototype.OverrideFP Acceleration; // 0x18
}

// Namespace: 
[Serializable]
public struct EntityPrototype.OverrideFP // TypeDefIndex: 23230
{
	// Fields
	[HideInInspector]
	public bool IsEnabled; // 0x0
	public FP Value; // 0x8
}

// Namespace: 
[Serializable]
public struct EntityPrototype.NavMeshAvoidanceAgentInfo // TypeDefIndex: 23231
{
	// Fields
	[HideInInspector]
	public bool IsEnabled; // 0x0
}

// Namespace: 
private class EntityPrototype.CheckComponentDuplicatesVisitor : ComponentPrototypeVisitor // TypeDefIndex: 23232
{
	// Fields
	public EntityPrototype Source; // 0x10
	public Dictionary<Type, List<Component>> TypeToSources; // 0x18

	// Methods

	// RVA: 0x7D62498 Offset: 0x7D5E498 VA: 0x7D62498 Slot: 22
	protected override void VisitFallback(ComponentPrototype prototype) { }

	// RVA: 0x7D623C4 Offset: 0x7D5E3C4 VA: 0x7D623C4
	public void .ctor() { }
}

// Namespace: 
public class EntityPrototype : MonoBehaviour, IQuantumPrefabNestedAssetHost // TypeDefIndex: 23233
{
	// Fields
	public EntityPrototypeTransformMode TransformMode; // 0x20
	[Optional("Transform2DVertical.IsEnabled")]
	[DrawIf("TransformMode", 0, 0, 3)]
	public EntityPrototype.Transform2DVerticalInfo Transform2DVertical; // 0x28
	[Optional("PhysicsCollider.IsEnabled")]
	[DrawIf("TransformMode", 2, 1, 3)]
	public EntityPrototype.PhysicsColliderGeneric PhysicsCollider; // 0x40
	[Optional("PhysicsBody.IsEnabled")]
	[DrawIf("PhysicsCollider.IsTrigger", 0, 0, 2)]
	[DrawIf("PhysicsCollider.IsEnabled", 1, 0, 2)]
	[DrawIf("TransformMode", 2, 1, 3)]
	[Tooltip("To enable make sure PhysicsCollider is enabled and not a trigger")]
	public EntityPrototype.PhysicsBodyGeneric PhysicsBody; // 0x78
	[Optional("NavMeshPathfinder.IsEnabled")]
	[DrawIf("TransformMode", 2, 1, 3)]
	public EntityPrototype.NavMeshPathfinderInfo NavMeshPathfinder; // 0xD8
	[DrawIf("TransformMode", 2, 1, 3)]
	[DrawIf("NavMeshPathfinder.IsEnabled", 1, 0, 2)]
	[Optional("NavMeshSteeringAgent.IsEnabled")]
	public EntityPrototype.NavMeshSteeringAgentInfo NavMeshSteeringAgent; // 0x128
	[Optional("NavMeshAvoidanceAgent.IsEnabled")]
	[DrawIf("NavMeshPathfinder.IsEnabled", 1, 0, 2)]
	[DrawIf("NavMeshSteeringAgent.IsEnabled", 1, 0, 2)]
	[DrawIf("TransformMode", 2, 1, 3)]
	public EntityPrototype.NavMeshAvoidanceAgentInfo NavMeshAvoidanceAgent; // 0x150
	public AssetRefEntityView View; // 0x158

	// Properties
	private Type IQuantumPrefabNestedAssetHost.NestedAssetType { get; }
	private Type IQuantumPrefabNestedAssetHost.SplitAssetType { get; }

	// Methods

	// RVA: 0x7D61E14 Offset: 0x7D5DE14 VA: 0x7D61E14 Slot: 4
	private Type IQuantumPrefabNestedAssetHost.get_NestedAssetType() { }

	// RVA: 0x7D61E80 Offset: 0x7D5DE80 VA: 0x7D61E80 Slot: 5
	private Type IQuantumPrefabNestedAssetHost.get_SplitAssetType() { }

	// RVA: 0x7D5E994 Offset: 0x7D5A994 VA: 0x7D5E994
	public void PreSerialize() { }

	// RVA: 0x7D5EB74 Offset: 0x7D5AB74 VA: 0x7D5EB74
	public void SerializeImplicitComponents(ComponentPrototypeVisitor visitor, out EntityView selfView) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x7D61F80 Offset: 0x7D5DF80 VA: 0x7D61F80
	public void CheckComponentDuplicates(Action<string> duplicateCallback) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x7D61F84 Offset: 0x7D5DF84 VA: 0x7D61F84
	public void CheckComponentDuplicates(Action<Type, List<Component>> duplicateCallback) { }

	// RVA: 0x7D623CC Offset: 0x7D5E3CC VA: 0x7D623CC
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct EntityPrototypeRefWrapper // TypeDefIndex: 23234
{
	// Fields
	[LocalReference]
	public EntityPrototype ScenePrototype; // 0x0
	public AssetRefEntityPrototype AssetPrototype; // 0x8
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EntityPrototypeUtils.<>c // TypeDefIndex: 23235
{
	// Fields
	public static readonly EntityPrototypeUtils.<>c <>9; // 0x0
	public static Func<Type, string> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x7D63210 Offset: 0x7D5F210 VA: 0x7D63210
	private static void .cctor() { }

	// RVA: 0x7D63278 Offset: 0x7D5F278 VA: 0x7D63278
	public void .ctor() { }

	// RVA: 0x7D63280 Offset: 0x7D5F280 VA: 0x7D63280
	internal string <CreateTypeNotSupportedMessage>b__5_0(Type x) { }
}

// Namespace: 
[Extension]
public static class EntityPrototypeUtils // TypeDefIndex: 23236
{
	// Methods

	// RVA: 0x7D5B160 Offset: 0x7D57160 VA: 0x7D5B160
	public static bool TrySetShapeConfigFromSourceCollider2D(Shape2DConfig config, Transform reference, Component collider) { }

	// RVA: 0x7D5B8C8 Offset: 0x7D578C8 VA: 0x7D5B8C8
	public static bool TrySetShapeConfigFromSourceCollider3D(Shape3DConfig config, Transform reference, Component collider) { }

	[Obsolete("Use TrySetShapeConfigFromSourceCollider2D instead.")]
	// RVA: 0x7D628E8 Offset: 0x7D5E8E8 VA: 0x7D628E8
	public static Shape2DConfig ColliderToShape2D(Transform reference, Component collider, out bool isTrigger) { }

	[Obsolete("Use TrySetShapeConfigFromSourceCollider3D instead.")]
	// RVA: 0x7D62E1C Offset: 0x7D5EE1C VA: 0x7D62E1C
	public static Shape3DConfig ColliderToShape3D(Transform reference, Component collider, out bool isTrigger) { }

	[Extension]
	// RVA: 0x7D5B594 Offset: 0x7D57594 VA: 0x7D5B594
	public static bool IsColliderTrigger(Component component) { }

	// RVA: 0x7D62744 Offset: 0x7D5E744 VA: 0x7D62744
	private static string CreateTypeNotSupportedMessage(Type colliderType, Type[] supportedTypes) { }

	// RVA: 0x7D625C4 Offset: 0x7D5E5C4 VA: 0x7D625C4
	private static void ThrowIfDifferentWorldPosition(Transform reference, Bounds bounds) { }

	// RVA: 0x7D62670 Offset: 0x7D5E670 VA: 0x7D62670
	private static void ThrowIfDifferentWorldRotation(Transform reference, Component collider) { }
}

// Namespace: 
[Serializable]
public class EntityView.EntityUnityEvent : UnityEvent<QuantumGame> // TypeDefIndex: 23237
{
	// Methods

	// RVA: 0x7D639DC Offset: 0x7D5F9DC VA: 0x7D639DC
	public void .ctor() { }
}

// Namespace: 
public struct EntityView.UpdatePostionParameter // TypeDefIndex: 23238
{
	// Fields
	public Vector3 NewPosition; // 0x0
	public Quaternion NewRotation; // 0xC
	public Vector3 UninterpolatedPosition; // 0x1C
	public Quaternion UninterpolatedRotation; // 0x28
	public Vector3 ErrorVisualVector; // 0x38
	public Quaternion ErrorVisualQuaternion; // 0x44
	public bool PositionTeleport; // 0x54
	public bool RotationTeleport; // 0x55
}

// Namespace: 
[DisallowMultipleComponent]
public class EntityView : MonoBehaviour, IQuantumPrefabNestedAssetHost // TypeDefIndex: 23239
{
	// Fields
	public AssetGuid AssetGuid; // 0x20
	public EntityRef EntityRef; // 0x28
	[FormerlySerializedAs("CreateBehaviour")]
	public EntityViewBindBehaviour BindBehaviour; // 0x30
	[Tooltip("If enabled the EntityViewUpdater will not destroy (or disable, in case of map entities) this instance, and you are responsible for removing it from the game world yourself.

You will still receive the OnEntityDestroyed callback.")]
	[FormerlySerializedAs("ManualDestroy")]
	[FormerlySerializedAs("ManualDiposal")]
	public bool ManualDisposal; // 0x34
	[Tooltip("If enabled automatically sets the name of the spawned EntityView gameobject to be EntityRef.ToString()")]
	public bool GameObjectNameIsEntityRef; // 0x35
	[Header("Prediction Error Correction")]
	[Tooltip("A factor with dimension of 1/s (Hz) that works as a lower limit for how much of the accumulated prediction error is corrected every frame. This factor affects both the position and the rotation correction. Suggested values are greater than zero and smaller than ErrorCorrectionRateMax.

E.g.: ErrorCorrectionRateMin = 3, rendering delta time = (1/60)s: at least 5% (3 * 1/60) of the accumulated error will be corrected on this rendered frame. 

This threshold might not be respected if the resultant correction magnitude is below the ErrorPositionMinCorrection or above the ErrorPositionTeleportDistance, for the position error, or above the ErrorRotationTeleportDistance, for the rotation error.")]
	public float ErrorCorrectionRateMin; // 0x38
	[Tooltip("A factor with dimension of 1/s (Hz) that works as a upper limit for how much of the accumulated prediction error is corrected every frame. This factor affects both the position and the rotation correction. Suggested values are greater than ErrorCorrectionRateMin and smaller than half of a target rendering rate.

E.g.: ErrorCorrectionRateMax = 15, rendering delta time = (1/60)s: at maximum 25% (15 * 1/60) of the accumulated error will be corrected on this rendered frame. 

This threshold might not be respected if the resultant correction magnitude is below the ErrorPositionMinCorrection or above the ErrorPositionTeleportDistance, for the position error, or above the ErrorRotationTeleportDistance, for the rotation error.")]
	public float ErrorCorrectionRateMax; // 0x3C
	[Tooltip("The reference for the magnitude of the accumulated position error, in meters, at which the position error will be corrected at the ErrorCorrectionRateMin. Suggested values are greater than ErrorPositionMinCorrection and smaller than ErrorPositionBlendEnd.

In other words, if the magnitude of the accumulated error is equal to or smaller than this threshold, it will be corrected at the ErrorCorrectionRateMin. If, instead, the magnitude is between this threshold and ErrorPositionBlendEnd,the error is corrected at a rate between ErrorCorrectionRateMin and ErrorCorrectionRateMax, proportionally. If it is equal to or greater than ErrorPositionBlendEnd, it will be corrected at the ErrorCorrectionRateMax.

Note: as the factor is expressed in distance units (meters), it might need to be scaled proportionally to the overall scale of objects in the scene and speeds at which they move, which are factors that affect the expected magnitude of prediction errors.")]
	public float ErrorPositionBlendStart; // 0x40
	[Tooltip("The reference for the magnitude of the accumulated position error, in meters, at which the position error will be corrected at the ErrorCorrectionRateMax. Suggested values are greater than ErrorPositionBlendStart and smaller than ErrorPositionTeleportDistance.

In other words, if the magnitude of the accumulated error is equal to or greater than this threshold, it will be corrected at the ErrorCorrectionRateMax. If, instead, the magnitude is between ErrorPositionBlendStart and this threshold, the error is corrected at a rate between ErrorCorrectionRateMin and ErrorCorrectionRateMax, proportionally. If it is equal to or smaller than ErrorPositionBlendStart, it will be corrected at the ErrorCorrectionRateMin.

Note: as the factor is expressed in distance units (meters), it might need to be scaled proportionally to the overall scale of objects in the scene and speeds at which they move, which are factors that affect the expected magnitude of prediction errors.")]
	public float ErrorPositionBlendEnd; // 0x44
	[Tooltip("The reference for the magnitude of the accumulated rotation error, in radians, at which the rotation error will be corrected at the ErrorCorrectionRateMin. Suggested values are smaller than ErrorRotationBlendEnd.

In other words, if the magnitude of the accumulated error is equal to or smaller than this threshold, it will be corrected at the ErrorCorrectionRateMin. If, instead, the magnitude is between this threshold and ErrorRotationBlendEnd, the error is corrected at a rate between ErrorCorrectionRateMin and ErrorCorrectionRateMax, proportionally. If it is equal to or greater than ErrorRotationBlendEnd, it will be corrected at the ErrorCorrectionRateMax.")]
	public float ErrorRotationBlendStart; // 0x48
	[Tooltip("The reference for the magnitude of the accumulated rotation error, in radians, at which the rotation error will be corrected at the ErrorCorrectionRateMax. Suggested values are greater than ErrorRotationBlendStart and smaller than ErrorRotationTeleportDistance.

In other words, if the magnitude of the accumulated error is equal to or greater than this threshold, it will be corrected at the ErrorCorrectionRateMax. If, instead, the magnitude is between ErrorRotationBlendStart and this threshold, the error is corrected at a rate between ErrorCorrectionRateMin and ErrorCorrectionRateMax, proportionally. If it is equal to or smaller than ErrorRotationBlendStart, it will be corrected at the ErrorCorrectionRateMin.")]
	public float ErrorRotationBlendEnd; // 0x4C
	[Tooltip("The value, in meters, that represents the minimum magnitude of the accumulated position error that will be corrected in a single frame, until it is fully corrected.

This setting has priority over the resultant correction rate, i.e. the restriction will be respected even if it makes the effective correction rate be different than the one computed according to the min/max rates and start/end blend values. Suggested values are greater than zero and smaller than ErrorPositionBlendStart.

Note: as the factor is expressed in distance units (meters), it might need to be scaled proportionally to the overall scale of objects in the scene and speeds at which they move, which are factors that affect the expected magnitude of prediction errors.")]
	public float ErrorPositionMinCorrection; // 0x50
	[Tooltip("The value, in meters, that represents the magnitude of the accumulated position error above which the error will be instantaneously corrected, effectively teleporting the rendered object to its correct position. Suggested values are greater than ErrorPositionBlendEnd.

This setting has priority over the resultant correction rate, i.e. the restriction will be respected even if it makes the effective correction rate be different than the one computed according to the min/max rates and start/end blend values.

Note: as the factor is expressed in distance units (meters), it might need to be scaled proportionally to the overall scale of objects in the scene and speeds at which they move, which are factors that affect the expected magnitude of prediction errors.")]
	public float ErrorPositionTeleportDistance; // 0x54
	[Tooltip("The value, in radians, that represents the magnitude of the accumulated rotation error above which the error will be instantaneously corrected, effectively teleporting the rendered object to its correct orientation. Suggested values are greater than ErrorRotationBlendEnd.

This setting has priority over the resultant correction rate, i.e. the restriction will be respected even if it makes the effective correction rate be different than the one computed according to the min/max rates and start/end blend values.")]
	public float ErrorRotationTeleportDistance; // 0x58
	[Header("Events")]
	public EntityView.EntityUnityEvent OnEntityInstantiated; // 0x60
	public EntityView.EntityUnityEvent OnEntityDestroyed; // 0x68
	private FP _lastPredictedVerticalPosition2D; // 0x70
	private FPVector2 _lastPredictedPosition2D; // 0x78
	private FPVector3 _lastPredictedPosition3D; // 0x88
	private FP _lastPredictedRotation2D; // 0xA0
	private FPQuaternion _lastPredictedRotation3D; // 0xA8
	private Vector3 _errorVisualVector; // 0xC8
	private Quaternion _errorVisualQuaternion; // 0xD4

	// Properties
	[Obsolete("Use ManualDisposal")]
	public bool ManualDiposal { get; }
	private Type IQuantumPrefabNestedAssetHost.NestedAssetType { get; }
	private Type IQuantumPrefabNestedAssetHost.SplitAssetType { get; }

	// Methods

	// RVA: 0x7D632A8 Offset: 0x7D5F2A8 VA: 0x7D632A8
	public bool get_ManualDiposal() { }

	// RVA: 0x7D632B0 Offset: 0x7D5F2B0 VA: 0x7D632B0 Slot: 4
	private Type IQuantumPrefabNestedAssetHost.get_NestedAssetType() { }

	// RVA: 0x7D6331C Offset: 0x7D5F31C VA: 0x7D6331C Slot: 5
	private Type IQuantumPrefabNestedAssetHost.get_SplitAssetType() { }

	// RVA: 0x7D63388 Offset: 0x7D5F388 VA: 0x7D63388
	public void OnInstantiated() { }

	// RVA: 0x7D633F4 Offset: 0x7D5F3F4 VA: 0x7D633F4
	private void UpdateRenderPosition(ref EntityView.UpdatePostionParameter param) { }

	// RVA: 0x7D638C8 Offset: 0x7D5F8C8 VA: 0x7D638C8 Slot: 6
	protected virtual void ApplyTransform(ref EntityView.UpdatePostionParameter param) { }

	// RVA: 0x7D63754 Offset: 0x7D5F754 VA: 0x7D63754
	private void UpdateMinPositionCorrection(float positionCorrectionMultiplier, Vector3 positionCorrectionAmount) { }

	// RVA: 0x7D639AC Offset: 0x7D5F9AC VA: 0x7D639AC
	public void .ctor() { }
}

// Namespace: 
public enum EntityViewBindBehaviour // TypeDefIndex: 23240
{
	// Fields
	public int value__; // 0x0
	public const EntityViewBindBehaviour NonVerified = 0;
	public const EntityViewBindBehaviour Verified = 1;
}

// Namespace: 
[Flags]
public enum MapData.DrawMode // TypeDefIndex: 23241
{
	// Fields
	public int value__; // 0x0
	public const MapData.DrawMode PhysicsArea = 4;
	public const MapData.DrawMode PhysicsBuckets = 8;
	public const MapData.DrawMode NavMeshArea = 16;
	public const MapData.DrawMode NavMeshGrid = 32;
	public const MapData.DrawMode All = 60;
}

// Namespace: 
[ExecuteInEditMode]
public class MapData : MonoBehaviour // TypeDefIndex: 23242
{
	// Fields
	public MapAsset Asset; // 0x20
	[EnumFlags]
	public MapData.DrawMode DrawGridMode; // 0x28
	[HideInInspector]
	[EnumFlags]
	public QuantumMapDataBakeFlags BakeAllMode; // 0x2C
	public List<MonoBehaviour> StaticCollider2DReferences; // 0x30
	public List<MonoBehaviour> StaticCollider3DReferences; // 0x38
	public List<EntityView> MapEntityReferences; // 0x40

	// Methods

	// RVA: 0x7D63A24 Offset: 0x7D5FA24 VA: 0x7D63A24
	private void Update() { }

	// RVA: 0x7D63AE8 Offset: 0x7D5FAE8 VA: 0x7D63AE8
	private void OnDrawGizmos() { }

	// RVA: 0x7D63AF0 Offset: 0x7D5FAF0 VA: 0x7D63AF0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x7D63AEC Offset: 0x7D5FAEC VA: 0x7D63AEC
	private void DrawGizmos(bool selected) { }

	// RVA: 0x7D63AF4 Offset: 0x7D5FAF4 VA: 0x7D63AF4
	public void .ctor() { }
}

// Namespace: 
public enum MapDataBaker.BuildTrigger // TypeDefIndex: 23243
{
	// Fields
	public int value__; // 0x0
	public const MapDataBaker.BuildTrigger SceneSave = 0;
	public const MapDataBaker.BuildTrigger PlaymodeChange = 1;
	public const MapDataBaker.BuildTrigger Build = 2;
	public const MapDataBaker.BuildTrigger Manual = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MapDataBaker.<>c // TypeDefIndex: 23244
{
	// Fields
	public static readonly MapDataBaker.<>c <>9; // 0x0
	public static Func<Vector3, FPVector2> <>9__7_2; // 0x8
	public static Func<KeyValuePair<int, TriangleCCW[]>, int> <>9__7_0; // 0x10
	public static Func<Type, int> <>9__9_0; // 0x18
	public static Comparison<MapNavMeshUnity> <>9__14_0; // 0x20
	public static Comparison<MapNavMeshDefinition> <>9__14_1; // 0x28

	// Methods

	// RVA: 0x7D69E94 Offset: 0x7D65E94 VA: 0x7D69E94
	private static void .cctor() { }

	// RVA: 0x7D69EFC Offset: 0x7D65EFC VA: 0x7D69EFC
	public void .ctor() { }

	// RVA: 0x7D69F04 Offset: 0x7D65F04 VA: 0x7D69F04
	internal FPVector2 <BakeColliders>b__7_2(Vector3 x) { }

	// RVA: 0x7D69F0C Offset: 0x7D65F0C VA: 0x7D69F0C
	internal int <BakeColliders>b__7_0(KeyValuePair<int, TriangleCCW[]> x) { }

	// RVA: 0x7D69F50 Offset: 0x7D65F50 VA: 0x7D69F50
	internal int <FindCallbackInstances>b__9_0(Type t) { }

	// RVA: 0x7D69FA4 Offset: 0x7D65FA4 VA: 0x7D69FA4
	internal int <BakeNavMeshesLoop>b__14_0(MapNavMeshUnity a, MapNavMeshUnity b) { }

	// RVA: 0x7D69FF4 Offset: 0x7D65FF4 VA: 0x7D69FF4
	internal int <BakeNavMeshesLoop>b__14_1(MapNavMeshDefinition a, MapNavMeshDefinition b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapDataBaker.<>c__DisplayClass15_0<T> // TypeDefIndex: 23245
{
	// Fields
	public List<int> list0; // 0x0
	public List<int> list1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486737C Offset: 0x486337C VA: 0x486737C
	|-MapDataBaker.<>c__DisplayClass15_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int <SortBySiblingIndex>b__0(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867384 Offset: 0x4863384 VA: 0x4867384
	|-MapDataBaker.<>c__DisplayClass15_0<object>.<SortBySiblingIndex>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class MapDataBaker.<>c__DisplayClass7_0 // TypeDefIndex: 23246
{
	// Fields
	public Vector3 s; // 0x10

	// Methods

	// RVA: 0x7D68FC4 Offset: 0x7D64FC4 VA: 0x7D68FC4
	public void .ctor() { }

	// RVA: 0x7D6A044 Offset: 0x7D66044 VA: 0x7D6A044
	internal Vector3 <BakeColliders>b__1(FPVector2 x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapDataBaker.<BakeNavMeshesLoop>d__14 : IEnumerable<NavMesh>, IEnumerable, IEnumerator<NavMesh>, IEnumerator, IDisposable // TypeDefIndex: 23247
{
	// Fields
	private int <>1__state; // 0x10
	private NavMesh <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private MapData data; // 0x28
	public MapData <>3__data; // 0x30
	private List<MapNavMesh.BakeData> <allBakeData>5__2; // 0x38
	private int <i>5__3; // 0x40

	// Properties
	private NavMesh System.Collections.Generic.IEnumerator<Quantum.NavMesh>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7D69A0C Offset: 0x7D65A0C VA: 0x7D69A0C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7D6A078 Offset: 0x7D66078 VA: 0x7D6A078 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D6A07C Offset: 0x7D6607C VA: 0x7D6A07C Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D6D6B4 Offset: 0x7D696B4 VA: 0x7D6D6B4 Slot: 6
	private NavMesh System.Collections.Generic.IEnumerator<Quantum.NavMesh>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D6D6BC Offset: 0x7D696BC VA: 0x7D6D6BC Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7D6D6F4 Offset: 0x7D696F4 VA: 0x7D6D6F4 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D6D6FC Offset: 0x7D696FC VA: 0x7D6D6FC Slot: 4
	private IEnumerator<NavMesh> System.Collections.Generic.IEnumerable<Quantum.NavMesh>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7D6D7A0 Offset: 0x7D697A0 VA: 0x7D6D7A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
public static class MapDataBaker // TypeDefIndex: 23248
{
	// Fields
	public static int NavMeshSerializationBufferSize; // 0x0

	// Methods

	// RVA: 0x7D63C00 Offset: 0x7D5FC00 VA: 0x7D63C00
	public static void BakeMapData(MapData data, bool inEditor, bool bakeColliders = True, bool bakePrototypes = True, QuantumMapDataBakeFlags bakeFlags = 0, MapDataBaker.BuildTrigger buildTrigger = 3) { }

	// RVA: 0x7D685AC Offset: 0x7D645AC VA: 0x7D685AC
	public static void BakeMeshes(MapData data, bool inEditor) { }

	// RVA: 0x7D685B0 Offset: 0x7D645B0 VA: 0x7D685B0
	public static IEnumerable<NavMesh> BakeNavMeshes(MapData data, bool inEditor) { }

	// RVA: 0x7D68EFC Offset: 0x7D64EFC VA: 0x7D68EFC
	private static void RemoveLegacyResourcesBinaryFile(ref string name) { }

	// RVA: 0x7D68F00 Offset: 0x7D64F00 VA: 0x7D68F00
	private static StaticColliderData GetStaticData(GameObject gameObject, QuantumStaticColliderSettings settings, int colliderId) { }

	// RVA: 0x7D64A30 Offset: 0x7D60A30 VA: 0x7D64A30
	public static void BakeColliders(MapData data, bool inEditor) { }

	// RVA: 0x7D6805C Offset: 0x7D6405C VA: 0x7D6805C
	public static void BakePrototypes(MapData data) { }

	// RVA: 0x7D69314 Offset: 0x7D65314 VA: 0x7D69314
	private static IEnumerable<Type> FindCallbackInstances() { }

	// RVA: 0x7D63DD8 Offset: 0x7D5FDD8 VA: 0x7D63DD8
	private static void InvokeCallbacks(string callbackName, MapData data, MapDataBaker.BuildTrigger buildTrigger, QuantumMapDataBakeFlags bakeFlags) { }

	// RVA: 0x7D6431C Offset: 0x7D6031C VA: 0x7D6431C
	private static void InvokeCallbacks(string callbackName, MapData data) { }

	// RVA: 0x7D694D0 Offset: 0x7D654D0 VA: 0x7D694D0
	private static void InvokeCallbacks(string callbackName, MapData data, List<MapNavMesh.BakeData> bakeData) { }

	// RVA: 0x7D689C0 Offset: 0x7D649C0 VA: 0x7D689C0
	private static void InvokeCallbacks(string callbackName, MapData data, List<NavMesh> navmeshes) { }

	[IteratorStateMachine(typeof(MapDataBaker.<BakeNavMeshesLoop>d__14))]
	// RVA: 0x7D68944 Offset: 0x7D64944 VA: 0x7D68944
	private static IEnumerable<NavMesh> BakeNavMeshesLoop(MapData data) { }

	// RVA: -1 Offset: -1
	private static void SortBySiblingIndex<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466D4BC Offset: 0x46694BC VA: 0x466D4BC
	|-MapDataBaker.SortBySiblingIndex<object>
	*/

	// RVA: 0x7D69A40 Offset: 0x7D65A40 VA: 0x7D69A40
	private static List<int> GetSiblingIndexPath(Transform t, List<int> buffer) { }

	// RVA: 0x7D69B80 Offset: 0x7D65B80 VA: 0x7D69B80
	private static int CompareLists(List<int> left, List<int> right) { }

	// RVA: 0x7D68FCC Offset: 0x7D64FCC VA: 0x7D68FCC
	private static bool BakeStaticEdge2D(Transform t, FPVector2 positionOffset, FP rotationOffset, FPVector2 vertexA, FPVector2 vertexB, FP height, QuantumStaticColliderSettings settings, int colliderId, out MapStaticCollider2D bakedCollider) { }

	// RVA: -1 Offset: -1
	public static List<T> FindLocalObjects<T>(Scene scene) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466D378 Offset: 0x4669378 VA: 0x466D378
	|-MapDataBaker.FindLocalObjects<object>
	*/

	// RVA: 0x7D69CA8 Offset: 0x7D65CA8 VA: 0x7D69CA8
	public static List<Component> FindLocalObjects(Scene scene, Type type) { }

	// RVA: 0x7D69E48 Offset: 0x7D65E48 VA: 0x7D69E48
	private static void .cctor() { }
}

// Namespace: 
public abstract class MapDataBakerCallback // TypeDefIndex: 23249
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBeforeBake(MapData data);

	// RVA: 0x7D6D7A4 Offset: 0x7D697A4 VA: 0x7D6D7A4 Slot: 5
	public virtual void OnBeforeBake(MapData data, MapDataBaker.BuildTrigger buildTrigger, QuantumMapDataBakeFlags bakeFlags) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnBake(MapData data);

	// RVA: 0x7D6D7A8 Offset: 0x7D697A8 VA: 0x7D6D7A8 Slot: 7
	public virtual void OnBeforeBakeNavMesh(MapData data) { }

	// RVA: 0x7D6D7AC Offset: 0x7D697AC VA: 0x7D6D7AC Slot: 8
	public virtual void OnCollectNavMeshBakeData(MapData data, List<MapNavMesh.BakeData> navMeshBakeData) { }

	// RVA: 0x7D6D7B0 Offset: 0x7D697B0 VA: 0x7D6D7B0 Slot: 9
	public virtual void OnCollectNavMeshes(MapData data, List<NavMesh> navmeshes) { }

	// RVA: 0x7D6D7B4 Offset: 0x7D697B4 VA: 0x7D6D7B4 Slot: 10
	public virtual void OnBakeNavMesh(MapData data) { }

	// RVA: 0x7D6D7B8 Offset: 0x7D697B8 VA: 0x7D6D7B8
	protected void .ctor() { }
}

// Namespace: 
public class MapDataBakerCallbackAttribute : Attribute // TypeDefIndex: 23250
{
	// Fields
	[CompilerGenerated]
	private int <InvokeOrder>k__BackingField; // 0x10

	// Properties
	public int InvokeOrder { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D6D7C0 Offset: 0x7D697C0 VA: 0x7D6D7C0
	public int get_InvokeOrder() { }

	[CompilerGenerated]
	// RVA: 0x7D6D7C8 Offset: 0x7D697C8 VA: 0x7D6D7C8
	private void set_InvokeOrder(int value) { }

	// RVA: 0x7D6D7D0 Offset: 0x7D697D0 VA: 0x7D6D7D0
	public void .ctor(int invokeOrder) { }
}

// Namespace: 
[Serializable]
public enum MapNavMesh.FindClosestTriangleCalculation // TypeDefIndex: 23251
{
	// Fields
	public int value__; // 0x0
	public const MapNavMesh.FindClosestTriangleCalculation BruteForce = 0;
	public const MapNavMesh.FindClosestTriangleCalculation SpiralOut = 1;
}

// Namespace: 
[Serializable]
public class MapNavMesh.BakeData // TypeDefIndex: 23252
{
	// Fields
	public string Name; // 0x10
	public Vector3 Position; // 0x18
	public FP AgentRadius; // 0x28
	public List<string> Regions; // 0x30
	public MapNavMeshVertex[] Vertices; // 0x38
	public MapNavMeshTriangle[] Triangles; // 0x40
	public MapNavMeshLink[] Links; // 0x48
	public MapNavMesh.FindClosestTriangleCalculation ClosestTriangleCalculation; // 0x50
	public int ClosestTriangleCalculationDepth; // 0x54
	public bool EnableQuantum_XY; // 0x58
	public bool LinkErrorCorrection; // 0x59

	// Methods

	// RVA: 0x7D6D7F8 Offset: 0x7D697F8 VA: 0x7D6D7F8
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class MapNavMesh.ImportSettings // TypeDefIndex: 23253
{
	// Fields
	[Tooltip("The Unity NavMesh is a collection of non - connected triangles, this option is very important and combines shared vertices.")]
	public bool WeldIdenticalVertices; // 0x10
	[Tooltip("Don't make the epsilon too small, vertices to fuse are missed, also don't make the value too big as it will deform your navmesh.")]
	public float WeldVertexEpsilon; // 0x14
	[Tooltip("Post processes imported Unity navmesh with a Delaunay triangulation to reduce long triangles.")]
	public bool DelaunayTriangulation; // 0x18
	[Tooltip("In 3D the triangulation can deform the navmesh on slopes, check this option to restrict the triangulation to triangles that lie in the same plane.")]
	public bool DelaunayTriangulationRestrictToPlanes; // 0x19
	[Tooltip("Sometimes vertices are lying on other triangle edges, this will lead to unwanted borders being detected, this option splits those vertices.")]
	public bool FixTrianglesOnEdges; // 0x1A
	[Tooltip("Larger scaled navmeshes may require to increase this value (e.g. 0.001) when false-positive borders are detected.")]
	public float FixTrianglesOnEdgesEpsilon; // 0x1C
	[Tooltip("Automatically correct navmesh link position to the closest triangle (default is off).")]
	public bool LinkErrorCorrection; // 0x20
	[Tooltip("SpiralOut will be considerably faster but fallback triangles can be null.")]
	public MapNavMesh.FindClosestTriangleCalculation ClosestTriangleCalculation; // 0x24
	[Tooltip("Number of cells to search triangles in neighbors.")]
	public int ClosestTriangleCalculationDepth; // 0x28
	[Tooltip("Activate this and the navmesh baking will flip Y and Z to support navmeshes generated in the XY plane.")]
	public bool EnableQuantum_XY; // 0x2C
	[Tooltip("The agent radius that the navmesh is build for. The value is retrieved from Unity settings when baking in Editor.")]
	public FP MinAgentRadius; // 0x30
	[Tooltip("Toggle the Quantum region import.")]
	public bool ImportRegions; // 0x38
	[Tooltip("The artificial margin is necessary because the Unity NavMesh does not fit the source size very well. The value is added to the navmesh area and checked against all Quantum Region scripts to select the correct region id.")]
	public float RegionDetectionMargin; // 0x3C
	public List<int> RegionAreaIds; // 0x40

	// Methods

	// RVA: 0x7D6FA9C Offset: 0x7D6BA9C VA: 0x7D6FA9C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MapNavMesh.ImportUtils.<>c // TypeDefIndex: 23254
{
	// Fields
	public static readonly MapNavMesh.ImportUtils.<>c <>9; // 0x0
	public static Func<int, string> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x7D70194 Offset: 0x7D6C194 VA: 0x7D70194
	private static void .cctor() { }

	// RVA: 0x7D701FC Offset: 0x7D6C1FC VA: 0x7D701FC
	public void .ctor() { }

	// RVA: 0x7D70204 Offset: 0x7D6C204 VA: 0x7D70204
	internal string <ImportRegions>b__2_0(int sdfdsf) { }
}

// Namespace: 
public static class MapNavMesh.ImportUtils // TypeDefIndex: 23255
{
	// Methods

	// RVA: 0x7D6D808 Offset: 0x7D69808 VA: 0x7D6D808
	public static void WeldIdenticalVertices(ref MapNavMeshVertex[] vertices, ref MapNavMeshTriangle[] triangles, float cleanupEpsilon, Action<float> reporter) { }

	// RVA: 0x7D6DA40 Offset: 0x7D69A40 VA: 0x7D6DA40
	public static void RemoveUnusedVertices(ref MapNavMeshVertex[] vertices, ref MapNavMeshTriangle[] triangles, Action<float> reporter) { }

	// RVA: 0x7D6E1EC Offset: 0x7D6A1EC VA: 0x7D6E1EC
	public static void ImportRegions(Scene scene, ref MapNavMeshVertex[] vertices, ref MapNavMeshTriangle[] triangles, int t, ref List<string> regionMap, float regionDetectionMargin) { }

	// RVA: 0x7D6DD40 Offset: 0x7D69D40 VA: 0x7D6DD40
	public static void FixTrianglesOnEdges(ref MapNavMeshVertex[] vertices, ref MapNavMeshTriangle[] triangles, int t, int v0, float epsilon) { }

	// RVA: 0x7D6FAE4 Offset: 0x7D6BAE4 VA: 0x7D6FAE4
	public static int FindTriangleOnEdge(ref MapNavMeshVertex[] vertices, ref MapNavMeshTriangle[] triangles, int tri, int v0, int v1, float epsilon, out int triangleVertexIndex) { }

	// RVA: 0x7D70020 Offset: 0x7D6C020 VA: 0x7D70020
	public static bool IsPointBetween(Vector3 p, Vector3 v0, Vector3 v1, float epsilon) { }

	// RVA: 0x7D6FDDC Offset: 0x7D6BDDC VA: 0x7D6FDDC
	public static void SplitTriangle(ref MapNavMeshTriangle[] triangles, int t, int v0, int vNew) { }
}

// Namespace: 
private struct MapNavMesh.GizmoNavmeshData // TypeDefIndex: 23256
{
	// Fields
	public Mesh GizmoMesh; // 0x0
	public NavMeshRegionMask CurrentRegionMask; // 0x8
}

// Namespace: 
public class MapNavMesh.DelaunayTriangulation.HalfEdge // TypeDefIndex: 23257
{
	// Fields
	public MapNavMesh.DelaunayTriangulation.HalfEdgeVertex v; // 0x10
	public MapNavMesh.DelaunayTriangulation.HalfEdge nextEdge; // 0x18
	public MapNavMesh.DelaunayTriangulation.HalfEdge oppositeEdge; // 0x20
	public MapNavMesh.DelaunayTriangulation.HalfEdge prevEdge; // 0x28
	public MapNavMesh.DelaunayTriangulation.Triangle t; // 0x30

	// Methods

	// RVA: 0x7D70CCC Offset: 0x7D6CCCC VA: 0x7D70CCC
	public void .ctor(MapNavMesh.DelaunayTriangulation.HalfEdgeVertex v) { }
}

// Namespace: 
public class MapNavMesh.DelaunayTriangulation.HalfEdgeVertex // TypeDefIndex: 23258
{
	// Fields
	public Vector3 position; // 0x10
	public int index; // 0x1C
	public MapNavMesh.DelaunayTriangulation.HalfEdge edge; // 0x20

	// Methods

	// RVA: 0x7D6DE40 Offset: 0x7D69E40 VA: 0x7D6DE40
	public void .ctor(Vector3 position, int index) { }
}

// Namespace: 
public class MapNavMesh.DelaunayTriangulation.Triangle // TypeDefIndex: 23259
{
	// Fields
	public MapNavMesh.DelaunayTriangulation.HalfEdgeVertex v1; // 0x10
	public MapNavMesh.DelaunayTriangulation.HalfEdgeVertex v2; // 0x18
	public MapNavMesh.DelaunayTriangulation.HalfEdgeVertex v3; // 0x20
	public int t; // 0x28
	public MapNavMesh.DelaunayTriangulation.HalfEdge edge; // 0x30

	// Methods

	// RVA: 0x7D70D34 Offset: 0x7D6CD34 VA: 0x7D70D34
	public void ChangeOrientation() { }

	// RVA: 0x7D6DE38 Offset: 0x7D69E38 VA: 0x7D6DE38
	public void .ctor() { }
}

// Namespace: 
public static class MapNavMesh.DelaunayTriangulation // TypeDefIndex: 23260
{
	// Methods

	// RVA: 0x7D6DE8C Offset: 0x7D69E8C VA: 0x7D6DE8C
	public static List<MapNavMesh.DelaunayTriangulation.Triangle> TriangulateByFlippingEdges(List<MapNavMesh.DelaunayTriangulation.Triangle> triangles, bool retrictToPlanes, Action reporter) { }

	// RVA: 0x7D70220 Offset: 0x7D6C220 VA: 0x7D70220
	private static List<MapNavMesh.DelaunayTriangulation.HalfEdge> TransformFromTriangleToHalfEdge(List<MapNavMesh.DelaunayTriangulation.Triangle> triangles) { }

	// RVA: 0x7D70BB8 Offset: 0x7D6CBB8 VA: 0x7D70BB8
	private static void OrientTrianglesClockwise(List<MapNavMesh.DelaunayTriangulation.Triangle> triangles) { }

	// RVA: 0x7D70CFC Offset: 0x7D6CCFC VA: 0x7D70CFC
	private static bool IsTriangleOrientedClockwise(Vector2 p1, Vector2 p2, Vector2 p3) { }

	// RVA: 0x7D7070C Offset: 0x7D6C70C VA: 0x7D7070C
	private static float IsPointInsideOutsideOrOnCircle(Vector2 aVec, Vector2 bVec, Vector2 cVec, Vector2 dVec) { }

	// RVA: 0x7D70790 Offset: 0x7D6C790 VA: 0x7D70790
	private static bool IsQuadrilateralConvex(Vector2 a, Vector2 b, Vector2 c, Vector2 d) { }

	// RVA: 0x7D708C0 Offset: 0x7D6C8C0 VA: 0x7D708C0
	private static void FlipEdge(MapNavMesh.DelaunayTriangulation.HalfEdge one) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MapNavMesh.<>c // TypeDefIndex: 23261
{
	// Fields
	public static readonly MapNavMesh.<>c <>9; // 0x0
	public static Comparison<string> <>9__5_3; // 0x8
	public static Func<NavMeshVertex, Vector3> <>9__11_0; // 0x10
	public static Func<NavMeshTriangle, IEnumerable<int>> <>9__11_1; // 0x18

	// Methods

	// RVA: 0x7D70D68 Offset: 0x7D6CD68 VA: 0x7D70D68
	private static void .cctor() { }

	// RVA: 0x7D70DD0 Offset: 0x7D6CDD0 VA: 0x7D70DD0
	public void .ctor() { }

	// RVA: 0x7D70DD8 Offset: 0x7D6CDD8 VA: 0x7D70DD8
	internal int <ImportFromUnity>b__5_3(string a, string b) { }

	// RVA: 0x7D70DE8 Offset: 0x7D6CDE8 VA: 0x7D70DE8
	internal Vector3 <CreateGizmoMesh>b__11_0(NavMeshVertex x) { }

	// RVA: 0x7D70E38 Offset: 0x7D6CE38 VA: 0x7D70E38
	internal IEnumerable<int> <CreateGizmoMesh>b__11_1(NavMeshTriangle x) { }

	// RVA: 0x7D70EE8 Offset: 0x7D6CEE8 VA: 0x7D70EE8
	internal Type <.cctor>b__20_0() { }

	// RVA: 0x7D70F2C Offset: 0x7D6CF2C VA: 0x7D70F2C
	internal Type <.cctor>b__20_1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapNavMesh.<>c__DisplayClass11_0 // TypeDefIndex: 23262
{
	// Fields
	public NavMeshRegionMask regionMask; // 0x10

	// Methods

	// RVA: 0x7D6F88C Offset: 0x7D6B88C VA: 0x7D6F88C
	public void .ctor() { }

	// RVA: 0x7D70F70 Offset: 0x7D6CF70 VA: 0x7D70F70
	internal IEnumerable<int> <CreateGizmoMesh>b__2(NavMeshTriangle x) { }

	// RVA: 0x7D71044 Offset: 0x7D6D044 VA: 0x7D71044
	internal IEnumerable<int> <CreateGizmoMesh>b__3(NavMeshTriangle x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapNavMesh.<>c__DisplayClass5_0 // TypeDefIndex: 23263
{
	// Fields
	public ProgressBar progressBar; // 0x10

	// Methods

	// RVA: 0x7D6D800 Offset: 0x7D69800 VA: 0x7D6D800
	public void .ctor() { }

	// RVA: 0x7D71118 Offset: 0x7D6D118 VA: 0x7D71118
	internal void <ImportFromUnity>b__0(float p) { }

	// RVA: 0x7D71134 Offset: 0x7D6D134 VA: 0x7D71134
	internal void <ImportFromUnity>b__1(float p) { }

	// RVA: 0x7D71150 Offset: 0x7D6D150 VA: 0x7D71150
	internal void <ImportFromUnity>b__2(float p) { }

	// RVA: 0x7D7116C Offset: 0x7D6D16C VA: 0x7D7116C
	internal void <ImportFromUnity>b__4() { }
}

// Namespace: 
public static class MapNavMesh // TypeDefIndex: 23264
{
	// Fields
	public static float DefaultMinAgentRadius; // 0x0
	private static Dictionary<string, MapNavMesh.GizmoNavmeshData> _navmeshGizmoMap; // 0x8
	private static Lazy<Type> _navMeshSurfaceType; // 0x10
	private static Lazy<Type> _navMeshAssetManagerType; // 0x18

	// Properties
	public static Type NavMeshSurfaceType { get; }
	public static Type NavMeshAssetManagerType { get; }

	// Methods

	// RVA: 0x7D6B46C Offset: 0x7D6746C VA: 0x7D6B46C
	public static MapNavMesh.BakeData ImportFromUnity(Scene scene, MapNavMesh.ImportSettings settings, string name) { }

	// RVA: 0x7D6D254 Offset: 0x7D69254 VA: 0x7D6D254
	public static FP FindSmallestAgentRadius(GameObject[] navmeshSurfaces) { }

	// RVA: 0x7D6B350 Offset: 0x7D67350 VA: 0x7D6B350
	public static void InvalidateGizmos() { }

	// RVA: 0x7D6F0A0 Offset: 0x7D6B0A0 VA: 0x7D6F0A0
	public static void CreateAndDrawGizmoMesh(NavMesh navmesh, NavMeshRegionMask regionMask) { }

	// RVA: 0x7D6F108 Offset: 0x7D6B108 VA: 0x7D6F108
	public static Mesh CreateGizmoMesh(NavMesh navmesh, NavMeshRegionMask regionMask) { }

	// RVA: 0x7D6F660 Offset: 0x7D6B660 VA: 0x7D6F660
	public static void DrawGizmoMesh(Mesh mesh) { }

	// RVA: 0x7D6B3F4 Offset: 0x7D673F4 VA: 0x7D6B3F4
	public static Type get_NavMeshSurfaceType() { }

	// RVA: 0x7D6F894 Offset: 0x7D6B894 VA: 0x7D6F894
	public static Type get_NavMeshAssetManagerType() { }

	// RVA: 0x7D6F90C Offset: 0x7D6B90C VA: 0x7D6F90C
	private static void .cctor() { }
}

// Namespace: 
public class MapNavMeshDebugDrawer : MonoBehaviour // TypeDefIndex: 23265
{
	// Fields
	public AssetRefBinaryData BinaryAsset; // 0x20
	public bool DrawBorders; // 0x28
	public bool DrawLinks; // 0x29
	public bool DrawBorderNormals; // 0x2A
	public bool DrawVertexNormals; // 0x2B
	public bool DrawTriangleNeighbors; // 0x2C
	public bool DrawVertexIds; // 0x2D
	public bool DrawTrianglesIds; // 0x2E

	// Methods

	// RVA: 0x7D711A4 Offset: 0x7D6D1A4 VA: 0x7D711A4
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct MapNavMeshTriangle // TypeDefIndex: 23266
{
	// Fields
	public string Id; // 0x0
	public string[] VertexIds; // 0x8
	public int[] VertexIds2; // 0x10
	public int Area; // 0x18
	public string RegionId; // 0x20
	public FP Cost; // 0x28
}

// Namespace: 
[Serializable]
public struct MapNavMeshVertex // TypeDefIndex: 23267
{
	// Fields
	public string Id; // 0x0
	public Vector3 Position; // 0x8
	public List<int> Neighbors; // 0x18
	public List<int> Triangles; // 0x20
}

// Namespace: 
[Serializable]
public struct MapNavMeshLink // TypeDefIndex: 23268
{
	// Fields
	public Vector3 Start; // 0x0
	public Vector3 End; // 0xC
	public bool Bidirectional; // 0x18
	public float CostOverride; // 0x1C
	public string RegionId; // 0x20
	public string Name; // 0x28
}

// Namespace: 
[Obsolete("Use MapNavMesh.BakeData")]
public class MapNavMeshBakeData : MapNavMesh.BakeData // TypeDefIndex: 23269
{
	// Methods

	// RVA: 0x7D711B4 Offset: 0x7D6D1B4 VA: 0x7D711B4
	public void .ctor() { }
}

// Namespace: 
[Obsolete("Use MapNavMesh.FindClosestTriangleCalculation")]
[Serializable]
public enum MapNavMeshDefinition.FindClosestTriangleCalculation // TypeDefIndex: 23270
{
	// Fields
	public int value__; // 0x0
	public const MapNavMeshDefinition.FindClosestTriangleCalculation BruteForce = 0;
	public const MapNavMeshDefinition.FindClosestTriangleCalculation SpiralOut = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class MapNavMeshDefinition.<>c__DisplayClass23_0 // TypeDefIndex: 23271
{
	// Fields
	public string id; // 0x10

	// Methods

	// RVA: 0x7D714B4 Offset: 0x7D6D4B4 VA: 0x7D714B4
	public void .ctor() { }

	// RVA: 0x7D71798 Offset: 0x7D6D798 VA: 0x7D71798
	internal bool <GetVertexIndex>b__0(MapNavMeshVertex x) { }
}

// Namespace: 
public class MapNavMeshDefinition : MonoBehaviour // TypeDefIndex: 23272
{
	// Fields
	public GameObject[] NavMeshSurfaces; // 0x20
	public FP AgentRadius; // 0x28
	public bool WeldIdenticalVertices; // 0x30
	public float WeldVertexEpsilon; // 0x34
	public bool DelaunayTriangulation; // 0x38
	public bool DelaunayTriangulationRestrictToPlanes; // 0x39
	public bool FixTrianglesOnEdges; // 0x3A
	public float FixTrianglesOnEdgesEpsilon; // 0x3C
	public bool ImportRegions; // 0x40
	public float RegionDetectionMargin; // 0x44
	public List<int> RegionAreaIds; // 0x48
	public MapNavMesh.FindClosestTriangleCalculation ClosestTriangleCalculation; // 0x50
	public int ClosestTriangleCalculationDepth; // 0x54
	public bool LinkErrorCorrection; // 0x58
	public bool EnableQuantum_XY; // 0x59
	[QuantumInspector]
	[ReadOnly]
	public MapNavMeshVertex[] Vertices; // 0x60
	[QuantumInspector]
	[ReadOnly]
	public MapNavMeshTriangle[] Triangles; // 0x68
	[ReadOnly]
	[QuantumInspector]
	public List<string> Regions; // 0x70
	[QuantumInspector]
	[ReadOnly]
	public MapNavMeshLink[] Links; // 0x78

	// Methods

	// RVA: 0x7D6D5B4 Offset: 0x7D695B4 VA: 0x7D6D5B4
	public static MapNavMesh.BakeData CreateBakeData(MapNavMeshDefinition definition) { }

	// RVA: 0x7D711BC Offset: 0x7D6D1BC VA: 0x7D711BC
	public static MapNavMesh.ImportSettings CreateImportSettings(MapNavMeshDefinition definition) { }

	// RVA: 0x7D712F8 Offset: 0x7D6D2F8 VA: 0x7D712F8
	public MapNavMeshVertex GetVertex(string id) { }

	// RVA: 0x7D713CC Offset: 0x7D6D3CC VA: 0x7D713CC
	public int GetVertexIndex(string id) { }

	// RVA: 0x7D714BC Offset: 0x7D6D4BC VA: 0x7D714BC
	public bool Contains(FPVector2 point) { }

	// RVA: 0x7D714E0 Offset: 0x7D6D4E0 VA: 0x7D714E0
	public bool Contains(Vector3 point) { }

	// RVA: 0x7D71738 Offset: 0x7D6D738 VA: 0x7D71738
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7D71774 Offset: 0x7D6D774 VA: 0x7D71774
	private Vector3 <Contains>b__25_0(string x) { }
}

// Namespace: 
public enum MapNavMeshRegion.RegionCastType // TypeDefIndex: 23273
{
	// Fields
	public int value__; // 0x0
	public const MapNavMeshRegion.RegionCastType CastRegion = 0;
	public const MapNavMeshRegion.RegionCastType NoRegion = 1;
}

// Namespace: 
public class MapNavMeshRegion : MonoBehaviour // TypeDefIndex: 23274
{
	// Fields
	[Tooltip("All regions with the same id are toggle-able as one region. Check Map.Regions to see the results.")]
	public string Id; // 0x20
	[Tooltip("Set to CastRegion when the region should be casted onto the navmesh. For Links for example chose NoRegion.")]
	public MapNavMeshRegion.RegionCastType CastRegion; // 0x28
	[Tooltip("Cost modifier that is applied to the heuristics of the path finding. Automatically gets the Unity area cost when adding the scripts. Toggle Overwrite to set to a custom value.")]
	public FP Cost; // 0x30
	public bool OverwriteCost; // 0x38

	// Methods

	// RVA: 0x7D717AC Offset: 0x7D6D7AC VA: 0x7D717AC
	public void .ctor() { }
}

// Namespace: 
public class MapNavMeshUnity : MonoBehaviour // TypeDefIndex: 23275
{
	// Fields
	public GameObject[] NavMeshSurfaces; // 0x20
	public MapNavMesh.ImportSettings Settings; // 0x28

	// Methods

	// RVA: 0x7D717BC Offset: 0x7D6D7BC VA: 0x7D717BC
	public void .ctor() { }
}

// Namespace: 
public class QuantumStaticBoxCollider2D : MonoBehaviour // TypeDefIndex: 23276
{
	// Fields
	public Component SourceCollider; // 0x20
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 Size; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 PositionOffset; // 0x38
	public FP RotationOffset; // 0x48
	public FP Height; // 0x50
	public QuantumStaticColliderSettings Settings; // 0x58

	// Methods

	// RVA: 0x7D717C4 Offset: 0x7D6D7C4 VA: 0x7D717C4
	public void UpdateFromSourceCollider() { }

	// RVA: 0x7D71950 Offset: 0x7D6D950 VA: 0x7D71950 Slot: 4
	public virtual void BeforeBake() { }

	// RVA: 0x7D71954 Offset: 0x7D6D954 VA: 0x7D71954
	private void OnDrawGizmos() { }

	// RVA: 0x7D71C7C Offset: 0x7D6DC7C VA: 0x7D71C7C
	private void OnDrawGizmosSelected() { }

	// RVA: 0x7D719C0 Offset: 0x7D6D9C0 VA: 0x7D719C0
	private void DrawGizmo(bool selected) { }

	// RVA: 0x7D71CE8 Offset: 0x7D6DCE8 VA: 0x7D71CE8
	public void .ctor() { }
}

// Namespace: 
public class QuantumStaticBoxCollider3D : MonoBehaviour // TypeDefIndex: 23277
{
	// Fields
	public BoxCollider SourceCollider; // 0x20
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector3 Size; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector3 PositionOffset; // 0x40
	public FPVector3 RotationOffset; // 0x58
	public QuantumStaticColliderSettings Settings; // 0x70

	// Methods

	// RVA: 0x7D71D54 Offset: 0x7D6DD54 VA: 0x7D71D54
	public void UpdateFromSourceCollider() { }

	// RVA: 0x7D71E78 Offset: 0x7D6DE78 VA: 0x7D71E78 Slot: 4
	public virtual void BeforeBake() { }

	// RVA: 0x7D71E7C Offset: 0x7D6DE7C VA: 0x7D71E7C
	private void OnDrawGizmos() { }

	// RVA: 0x7D72128 Offset: 0x7D6E128 VA: 0x7D72128
	private void OnDrawGizmosSelected() { }

	// RVA: 0x7D71EE8 Offset: 0x7D6DEE8 VA: 0x7D71EE8
	private void DrawGizmo(bool selected) { }

	// RVA: 0x7D72194 Offset: 0x7D6E194 VA: 0x7D72194
	public void .ctor() { }
}

// Namespace: 
public class QuantumStaticCircleCollider2D : MonoBehaviour // TypeDefIndex: 23278
{
	// Fields
	public Component SourceCollider; // 0x20
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FP Radius; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 PositionOffset; // 0x30
	public FP Height; // 0x40
	public QuantumStaticColliderSettings Settings; // 0x48

	// Methods

	// RVA: 0x7D72200 Offset: 0x7D6E200 VA: 0x7D72200
	public void UpdateFromSourceCollider() { }

	// RVA: 0x7D7238C Offset: 0x7D6E38C VA: 0x7D7238C Slot: 4
	public virtual void BeforeBake() { }

	// RVA: 0x7D72390 Offset: 0x7D6E390 VA: 0x7D72390
	private void OnDrawGizmos() { }

	// RVA: 0x7D72574 Offset: 0x7D6E574 VA: 0x7D72574
	private void OnDrawGizmosSelected() { }

	// RVA: 0x7D723FC Offset: 0x7D6E3FC VA: 0x7D723FC
	private void DrawGizmo(bool selected) { }

	// RVA: 0x7D725E0 Offset: 0x7D6E5E0 VA: 0x7D725E0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class QuantumStaticColliderSettings // TypeDefIndex: 23279
{
	// Fields
	public PhysicsCommon.StaticColliderMutableMode MutableMode; // 0x10
	public AssetRefPhysicsMaterial PhysicsMaterial; // 0x18
	public AssetRef Asset; // 0x20
	public bool Trigger; // 0x28

	// Methods

	// RVA: 0x7D727C4 Offset: 0x7D6E7C4 VA: 0x7D727C4
	public void .ctor() { }
}

// Namespace: 
public class QuantumStaticEdgeCollider2D : MonoBehaviour // TypeDefIndex: 23280
{
	// Fields
	public EdgeCollider2D SourceCollider; // 0x20
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 VertexA; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 VertexB; // 0x38
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 PositionOffset; // 0x48
	public FP RotationOffset; // 0x58
	public FP Height; // 0x60
	public QuantumStaticColliderSettings Settings; // 0x68

	// Methods

	// RVA: 0x7D727CC Offset: 0x7D6E7CC VA: 0x7D727CC
	public void UpdateFromSourceCollider() { }

	// RVA: 0x7D7294C Offset: 0x7D6E94C VA: 0x7D7294C Slot: 4
	public virtual void BeforeBake() { }

	// RVA: 0x7D72950 Offset: 0x7D6E950 VA: 0x7D72950
	private void OnDrawGizmos() { }

	// RVA: 0x7D72AD0 Offset: 0x7D6EAD0 VA: 0x7D72AD0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x7D729BC Offset: 0x7D6E9BC VA: 0x7D729BC
	private void DrawGizmos(bool selected) { }

	// RVA: 0x7D72CE4 Offset: 0x7D6ECE4 VA: 0x7D72CE4
	public static void GetEdgeGizmosSettings(Transform t, FPVector2 posOffset, FP rotOffset, FPVector2 localStart, FPVector2 localEnd, FP localHeight, out Vector3 start, out Vector3 end, out float height) { }

	// RVA: 0x7D72F6C Offset: 0x7D6EF6C VA: 0x7D72F6C
	public void .ctor() { }
}

// Namespace: 
public class QuantumStaticMeshCollider3D : MonoBehaviour // TypeDefIndex: 23281
{
	// Fields
	public Mesh Mesh; // 0x20
	public QuantumStaticColliderSettings Settings; // 0x28
	[Header("Experimental")]
	public bool SmoothSphereMeshCollisions; // 0x30
	public TriangleCCW[] Triangles; // 0x38
	[HideInInspector]
	[Obsolete("Use 'Settings.MutableMode' instead.")]
	public MapStaticCollider3D.MutableModes Mode; // 0x40

	// Methods

	// RVA: 0x7D7304C Offset: 0x7D6F04C VA: 0x7D7304C
	private void Reset() { }

	// RVA: 0x7D73168 Offset: 0x7D6F168 VA: 0x7D73168
	public bool Bake(int index) { }

	// RVA: 0x7D738A0 Offset: 0x7D6F8A0 VA: 0x7D738A0
	public void .ctor() { }
}

// Namespace: 
public class QuantumStaticPolygonCollider2D : MonoBehaviour // TypeDefIndex: 23282
{
	// Fields
	public PolygonCollider2D SourceCollider; // 0x20
	public bool BakeAsStaticEdges2D; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2[] Vertices; // 0x30
	[Tooltip("Additional translation applied to transform position when baking")]
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector2 PositionOffset; // 0x38
	[Tooltip("Additional rotation (in degrees) applied to transform rotation when baking")]
	public FP RotationOffset; // 0x48
	public FP Height; // 0x50
	public QuantumStaticColliderSettings Settings; // 0x58

	// Properties
	protected virtual bool UpdateVerticesFromSourceOnBake { get; }

	// Methods

	// RVA: 0x7D7390C Offset: 0x7D6F90C VA: 0x7D7390C Slot: 4
	protected virtual bool get_UpdateVerticesFromSourceOnBake() { }

	// RVA: 0x7D73914 Offset: 0x7D6F914 VA: 0x7D73914
	public void UpdateFromSourceCollider(bool updateVertices = True) { }

	// RVA: 0x7D73AA0 Offset: 0x7D6FAA0 VA: 0x7D73AA0 Slot: 5
	public virtual void BeforeBake() { }

	// RVA: 0x7D73AC4 Offset: 0x7D6FAC4 VA: 0x7D73AC4
	private void OnDrawGizmos() { }

	// RVA: 0x7D73EAC Offset: 0x7D6FEAC VA: 0x7D73EAC
	private void OnDrawGizmosSelected() { }

	// RVA: 0x7D73B34 Offset: 0x7D6FB34 VA: 0x7D73B34
	private void DrawGizmo(bool selected) { }

	// RVA: 0x7D73F1C Offset: 0x7D6FF1C VA: 0x7D73F1C
	public void .ctor() { }
}

// Namespace: 
public class QuantumStaticSphereCollider3D : MonoBehaviour // TypeDefIndex: 23283
{
	// Fields
	public SphereCollider SourceCollider; // 0x20
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FP Radius; // 0x28
	[DrawIf("SourceCollider", 0, 0, 2)]
	public FPVector3 PositionOffset; // 0x30
	public QuantumStaticColliderSettings Settings; // 0x48

	// Methods

	// RVA: 0x7D74054 Offset: 0x7D70054 VA: 0x7D74054
	public void UpdateFromSourceCollider() { }

	// RVA: 0x7D74168 Offset: 0x7D70168 VA: 0x7D74168 Slot: 4
	public virtual void BeforeBake() { }

	// RVA: 0x7D7416C Offset: 0x7D7016C VA: 0x7D7416C
	private void OnDrawGizmos() { }

	// RVA: 0x7D74310 Offset: 0x7D70310 VA: 0x7D74310
	private void OnDrawGizmosSelected() { }

	// RVA: 0x7D741D8 Offset: 0x7D701D8 VA: 0x7D741D8
	private void DrawGizmo(bool selected) { }

	// RVA: 0x7D743A8 Offset: 0x7D703A8 VA: 0x7D743A8
	public void .ctor() { }
}

// Namespace: 
[ExecuteInEditMode]
public class QuantumStaticTerrainCollider3D : MonoBehaviour // TypeDefIndex: 23284
{
	// Fields
	public TerrainColliderAsset Asset; // 0x20
	public PhysicsCommon.StaticColliderMutableMode MutableMode; // 0x28
	[HideInInspector]
	public bool SmoothSphereMeshCollisions; // 0x2C
	[Obsolete("Use 'MutableMode' instead.")]
	[HideInInspector]
	public MapStaticCollider3D.MutableModes Mode; // 0x30

	// Methods

	// RVA: 0x7D74414 Offset: 0x7D70414 VA: 0x7D74414
	public void Bake() { }

	// RVA: 0x7D74758 Offset: 0x7D70758 VA: 0x7D74758
	public void .ctor() { }
}

// Namespace: 
public abstract class QuantumCallbacks : MonoBehaviour // TypeDefIndex: 23285
{
	// Fields
	public static readonly List<QuantumCallbacks> Instances; // 0x0

	// Methods

	// RVA: 0x7D74760 Offset: 0x7D70760 VA: 0x7D74760 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x7D74834 Offset: 0x7D70834 VA: 0x7D74834 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x7D748B4 Offset: 0x7D708B4 VA: 0x7D748B4 Slot: 6
	public virtual void OnGameStart(QuantumGame game) { }

	// RVA: 0x7D748B8 Offset: 0x7D708B8 VA: 0x7D748B8 Slot: 7
	public virtual void OnGameResync(QuantumGame game) { }

	// RVA: 0x7D748BC Offset: 0x7D708BC VA: 0x7D748BC Slot: 8
	public virtual void OnGameDestroyed(QuantumGame game) { }

	// RVA: 0x7D748C0 Offset: 0x7D708C0 VA: 0x7D748C0 Slot: 9
	public virtual void OnUpdateView(QuantumGame game) { }

	// RVA: 0x7D748C4 Offset: 0x7D708C4 VA: 0x7D748C4 Slot: 10
	public virtual void OnSimulateFinished(QuantumGame game, Frame frame) { }

	// RVA: 0x7D748C8 Offset: 0x7D708C8 VA: 0x7D748C8 Slot: 11
	public virtual void OnUnitySceneLoadBegin(QuantumGame game) { }

	// RVA: 0x7D748CC Offset: 0x7D708CC VA: 0x7D748CC Slot: 12
	public virtual void OnUnitySceneLoadDone(QuantumGame game) { }

	// RVA: 0x7D748D0 Offset: 0x7D708D0 VA: 0x7D748D0 Slot: 13
	public virtual void OnUnitySceneUnloadBegin(QuantumGame game) { }

	// RVA: 0x7D748D4 Offset: 0x7D708D4 VA: 0x7D748D4 Slot: 14
	public virtual void OnUnitySceneUnloadDone(QuantumGame game) { }

	// RVA: 0x7D748D8 Offset: 0x7D708D8 VA: 0x7D748D8
	protected void .ctor() { }

	// RVA: 0x7D748E0 Offset: 0x7D708E0 VA: 0x7D748E0
	private static void .cctor() { }
}

// Namespace: 
[Flags]
[Serializable]
public enum QuantumEditorSettings.GizmosMode // TypeDefIndex: 23286
{
	// Fields
	public int value__; // 0x0
	public const QuantumEditorSettings.GizmosMode None = 0;
	public const QuantumEditorSettings.GizmosMode OnDraw = 1;
	public const QuantumEditorSettings.GizmosMode OnSelected = 2;
	public const QuantumEditorSettings.GizmosMode OnApplicationPlaying = 4;
}

// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Configurations/QuantumEditorSettings", fileName = "QuantumEditorSettings", order = -999)]
public class QuantumEditorSettings : ScriptableObject // TypeDefIndex: 23287
{
	// Fields
	private static QuantumEditorSettings _instance; // 0x0
	[Tooltip("Path to asset resource db file.")]
	public string AssetResourcesPath; // 0x18
	[Tooltip("These folders are scanned when creating the AssetResource collection. The first on is the default path for exported assets like map and navmesh.")]
	public string[] AssetSearchPaths; // 0x20
	[Tooltip("Quantum scripts occasionally search for types in the Unity assemblies (e.g. MapDataBakerCallback). When using assembly definitions add them here.")]
	public string[] SearchAssemblies; // 0x28
	[Tooltip("See SearchAssemblies")]
	public string[] SearchEditorAssemblies; // 0x30
	[Header("Map")]
	public Color PhysicsGridColor; // 0x38
	public Color NavMeshGridColor; // 0x48
	[Header("Gizmos")]
	public FP GizmoIconScale; // 0x58
	public float GizmoSelectedBrightness; // 0x60
	[Header("Collider Gizmos")]
	[EnumFlags]
	public QuantumEditorSettings.GizmosMode DrawColliderGizmos; // 0x64
	public QuantumGizmoStyle ColliderGizmosStyle; // 0x68
	public QuantumGizmoStyle StaticColliderGizmoStyle; // 0x69
	public bool DrawStaticMeshTriangles; // 0x6A
	public bool DrawStaticMeshNormals; // 0x6B
	public bool DrawSceneMeshCells; // 0x6C
	public bool DrawSceneMeshTriangles; // 0x6D
	public Color StaticColliderColor; // 0x70
	public Color DynamicColliderColor; // 0x80
	public Color KinematicColliderColor; // 0x90
	public Color CharacterControllerColor; // 0xA0
	public Color AsleepColliderColor; // 0xB0
	public Color DisabledColliderColor; // 0xC0
	[Header("Joint Gizmos")]
	[EnumFlags]
	public QuantumEditorSettings.GizmosMode DrawJointGizmos; // 0xD0
	public QuantumGizmoStyle JointGizmosStyle; // 0xD4
	public Color JointGizmosPrimaryColor; // 0xD8
	public Color JointGizmosSecondaryColor; // 0xE8
	public Color JointGizmosWarningColor; // 0xF8
	[Header("Prediction Culling Gizmos")]
	public bool DrawPredictionArea; // 0x108
	public Color PredictionAreaColor; // 0x10C
	[Header("Pathfinder Gizmos")]
	public bool DrawPathfinderRawPath; // 0x11C
	public bool DrawPathfinderRawTrianglePath; // 0x11D
	public bool DrawPathfinderFunnel; // 0x11E
	[Header("NavMesh Agent Gizmos")]
	public bool DrawNavMeshAgents; // 0x11F
	public Color NavMeshAgentColor; // 0x120
	public Color NavMeshAvoidanceColor; // 0x130
	[Header("NavMesh Gizmos")]
	public bool DrawNavMesh; // 0x140
	public bool DrawNavMeshBorders; // 0x141
	public bool DrawNavMeshTriangleIds; // 0x142
	public bool DrawNavMeshRegionIds; // 0x143
	public bool DrawNavMeshVertexNormals; // 0x144
	public bool DrawNavMeshLinks; // 0x145
	public Color NavMeshDefaultColor; // 0x148
	public Color NavMeshRegionColor; // 0x158
	[Header("NavMesh Editor")]
	public bool DrawNavMeshDefinitionAlways; // 0x168
	public bool DrawNavMeshDefinitionMesh; // 0x169
	public bool DrawNavMeshDefinitionOptimized; // 0x16A
	[Header("Editor Features")]
	[Tooltip("Toggle the Quantum asset inspector. Completely disable it by defining DISABLE_QUANTUM_ASSET_EDITOR.")]
	public bool UseQuantumAssetInspector; // 0x16B
	[Tooltip("The post processor enables duplicating Quantum assets and prefabs and make sure a new guid and correct path are set. This can make especially batched processes slow and can be toggled off here.")]
	public bool UseAssetBasePostprocessor; // 0x16C
	[Tooltip("If enabled a scene loading dropdown is displayed next to the play button.")]
	public bool UseQuantumToolbarUtilities; // 0x16D
	[Tooltip("Toolbar Zone. Requires a domain reload after change.")]
	public QuantumToolbarZone QuantumToolbarZone; // 0x170
	[Tooltip("If enabled a local PhotonPrivateAppVersion scriptable object is created to support the demo menu scene.")]
	public bool UsePhotonAppVersionsPostprocessor; // 0x174
	[Tooltip("If enabled entity components are displayed inside of EntityPrototype inspector")]
	[FormerlySerializedAs("UseInlineEntityComponents")]
	public QuantumEntityComponentInspectorMode EntityComponentInspectorMode; // 0x178
	[Range(2, 7)]
	[Tooltip("How many decimal places to round to when displaying FPs.")]
	public int FPDisplayPrecision; // 0x17C
	[FormerlySerializedAs("MaxInspectableArraySize")]
	[Tooltip("How many elements an array can have to be expandable in the Inspector. Set to a negative value to always allow arrays expansion.")]
	public int MaxArraySizeForInspector; // 0x180
	[EnumFlags]
	[Tooltip("Automatically trigger bake on saving a scene.")]
	public QuantumMapDataBakeFlags AutoBuildOnSceneSave; // 0x184
	[EnumFlags]
	[Tooltip("If set MapData will be automatically baked on entering play mode, on saving a scene and on building a player.")]
	public QuantumMapDataBakeFlags AutoBuildOnPlaymodeChanged; // 0x188
	[Tooltip("If set MapData will be automatically baked on entering play mode, on saving a scene and on building a player.")]
	[EnumFlags]
	public QuantumMapDataBakeFlags AutoBuildOnBuild; // 0x18C
	[Tooltip("Overwrite to use a different path from the Unity project to the quantum code solution.")]
	[Header("Quantum Solution Integration (changes require Unity restart)")]
	private string databasePathInResources; // 0x190
	private string assetResourcesPathInResources; // 0x198

	// Properties
	public static QuantumEditorSettings Instance { get; }
	public static QuantumEditorSettings InstanceFailSilently { get; }
	[Obsolete("Use DefaultAssetSearchPath instead")]
	public string DatabasePath { get; }
	public string DefaultAssetSearchPath { get; }
	[Obsolete("Use DatabasePathInResources")]
	public string ResourceDatabasePath { get; }
	public string DatabasePathInResources { get; }
	public string AssetResourcesPathInResources { get; }

	// Methods

	// RVA: 0x7D72B3C Offset: 0x7D6EB3C VA: 0x7D72B3C
	public static QuantumEditorSettings get_Instance() { }

	// RVA: 0x7D74978 Offset: 0x7D70978 VA: 0x7D74978
	public static QuantumEditorSettings get_InstanceFailSilently() { }

	// RVA: 0x7D74A54 Offset: 0x7D70A54 VA: 0x7D74A54
	public string get_DatabasePath() { }

	// RVA: 0x7D74A58 Offset: 0x7D70A58 VA: 0x7D74A58
	public string get_DefaultAssetSearchPath() { }

	// RVA: 0x7D74A80 Offset: 0x7D70A80 VA: 0x7D74A80
	public string get_ResourceDatabasePath() { }

	// RVA: 0x7D74A84 Offset: 0x7D70A84 VA: 0x7D74A84
	public string get_DatabasePathInResources() { }

	// RVA: 0x7D74B60 Offset: 0x7D70B60 VA: 0x7D74B60
	public string get_AssetResourcesPathInResources() { }

	// RVA: 0x7D74B68 Offset: 0x7D70B68 VA: 0x7D74B68
	public Color GetNavMeshColor(NavMeshRegionMask regionMask) { }

	// RVA: 0x7D74BC8 Offset: 0x7D70BC8 VA: 0x7D74BC8
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public enum QuantumToolbarAnchor // TypeDefIndex: 23288
{
	// Fields
	public int value__; // 0x0
	public const QuantumToolbarAnchor Legacy = 0;
	public const QuantumToolbarAnchor Center = 1;
	public const QuantumToolbarAnchor Left = 2;
	public const QuantumToolbarAnchor Right = 3;
}

// Namespace: 
[Serializable]
public enum QuantumToolbarZone // TypeDefIndex: 23289
{
	// Fields
	public int value__; // 0x0
	public const QuantumToolbarZone ToolbarZoneRightAlign = 0;
	public const QuantumToolbarZone ToolbarZoneLeftAlign = 1;
}

// Namespace: 
[Flags]
[Serializable]
public enum QuantumMapDataBakeFlags // TypeDefIndex: 23290
{
	// Fields
	public int value__; // 0x0
	public const QuantumMapDataBakeFlags None = 0;
	[Obsolete("Use BakeMapData instead")]
	public const QuantumMapDataBakeFlags Obsolete_BakeMapData = 1;
	public const QuantumMapDataBakeFlags BakeMapData = 96;
	public const QuantumMapDataBakeFlags BakeMapPrototypes = 32;
	public const QuantumMapDataBakeFlags BakeMapColliders = 64;
	public const QuantumMapDataBakeFlags BakeUnityNavMesh = 8;
	public const QuantumMapDataBakeFlags ImportUnityNavMesh = 4;
	public const QuantumMapDataBakeFlags BakeNavMesh = 2;
	public const QuantumMapDataBakeFlags ClearUnityNavMesh = 256;
	public const QuantumMapDataBakeFlags GenerateAssetDB = 16;
	public const QuantumMapDataBakeFlags SaveUnityAssets = 128;
}

// Namespace: 
public enum QuantumEntityComponentInspectorMode // TypeDefIndex: 23291
{
	// Fields
	public int value__; // 0x0
	public const QuantumEntityComponentInspectorMode ShowMonoBehaviours = 0;
	public const QuantumEntityComponentInspectorMode InlineInEntityPrototypeAndShowMonoBehavioursStubs = 1;
	public const QuantumEntityComponentInspectorMode InlineInEntityPrototypeAndHideMonoBehaviours = 2;
}

// Namespace: 
private class QuantumFrameDiffer.QuantumFrameDifferGUIRuntime : QuantumFrameDifferGUI // TypeDefIndex: 23292
{
	// Properties
	public override int TextLineHeight { get; }
	public override Rect Position { get; }

	// Methods

	// RVA: 0x7D74FF0 Offset: 0x7D70FF0 VA: 0x7D74FF0
	public void .ctor(QuantumFrameDifferGUI.FrameDifferState state) { }

	// RVA: 0x7D75430 Offset: 0x7D71430 VA: 0x7D75430 Slot: 5
	public override int get_TextLineHeight() { }

	// RVA: 0x7D75438 Offset: 0x7D71438 VA: 0x7D75438 Slot: 15
	public override Rect get_Position() { }

	// RVA: 0x7D75468 Offset: 0x7D71468 VA: 0x7D75468 Slot: 18
	public override void DrawHeader() { }
}

// Namespace: 
public class QuantumFrameDiffer : MonoBehaviour // TypeDefIndex: 23293
{
	// Fields
	public QuantumFrameDifferGUI.FrameDifferState State; // 0x20
	private QuantumFrameDifferGUI _gui; // 0x28

	// Methods

	// RVA: 0x7D74F40 Offset: 0x7D70F40 VA: 0x7D74F40
	private void OnGUI() { }

	// RVA: 0x7D750D0 Offset: 0x7D710D0 VA: 0x7D750D0
	public static QuantumFrameDiffer Show() { }

	// RVA: 0x7D75278 Offset: 0x7D71278 VA: 0x7D75278
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private class QuantumFrameDifferGUI.StateEntry // TypeDefIndex: 23294
{
	// Fields
	public string RunnerId; // 0x10
	public int ActorId; // 0x18
	public int FrameNumber; // 0x1C
	public string CompressedFrameDump; // 0x20
	public string ActorName; // 0x28
	public string FrameDump; // 0x30

	// Methods

	// RVA: 0x7D78FD0 Offset: 0x7D74FD0 VA: 0x7D78FD0
	public void .ctor() { }
}

// Namespace: 
internal class QuantumFrameDifferGUI.FrameData // TypeDefIndex: 23295
{
	// Fields
	public string String; // 0x10
	public int Diffs; // 0x18
	public List<string> Lines; // 0x20
	public bool Initialized; // 0x28
	public string Title; // 0x30

	// Methods

	// RVA: 0x7D78FD8 Offset: 0x7D74FD8 VA: 0x7D78FD8
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class QuantumFrameDifferGUI.FrameDifferState : ISerializationCallbackReceiver // TypeDefIndex: 23296
{
	// Fields
	[SerializeField]
	private List<QuantumFrameDifferGUI.StateEntry> Entries; // 0x10
	private Dictionary<string, Dictionary<int, Dictionary<int, QuantumFrameDifferGUI.FrameData>>> _byRunner; // 0x18

	// Properties
	public IEnumerable<string> RunnerIds { get; }

	// Methods

	// RVA: 0x7D77BB8 Offset: 0x7D73BB8 VA: 0x7D77BB8
	public void Clear() { }

	// RVA: 0x7D79060 Offset: 0x7D75060 VA: 0x7D79060
	public void AddEntry(string runnerId, int actorId, int frameNumber, string frameDump, string actorName) { }

	// RVA: 0x7D793E0 Offset: 0x7D753E0 VA: 0x7D793E0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x7D795B4 Offset: 0x7D755B4 VA: 0x7D795B4 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x7D791A0 Offset: 0x7D751A0 VA: 0x7D791A0
	private void OnEntryAdded(QuantumFrameDifferGUI.StateEntry entry) { }

	// RVA: 0x7D76454 Offset: 0x7D72454 VA: 0x7D76454
	public IEnumerable<string> get_RunnerIds() { }

	// RVA: 0x7D78EDC Offset: 0x7D74EDC VA: 0x7D78EDC
	internal Dictionary<int, QuantumFrameDifferGUI.FrameData> GetFirstFrameDiff(string runnerId, out int frameNumber) { }

	// RVA: 0x7D752E0 Offset: 0x7D712E0 VA: 0x7D752E0
	public void .ctor() { }
}

// Namespace: 
public struct QuantumFrameDifferGUI.LongestCommonSequence.DiffChunk // TypeDefIndex: 23297
{
	// Fields
	public int StartA; // 0x0
	public int StartB; // 0x4
	public int AddedA; // 0x8
	public int AddedB; // 0xC

	// Methods

	// RVA: 0x7D798A4 Offset: 0x7D758A4 VA: 0x7D798A4 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private class QuantumFrameDifferGUI.LongestCommonSequence // TypeDefIndex: 23298
{
	// Fields
	private ushort[,] m_c; // 0x10
	private const int MaxSlice = 5000;

	// Methods

	// RVA: 0x7D79740 Offset: 0x7D75740 VA: 0x7D79740
	public void .ctor() { }

	// RVA: -1 Offset: -1
	public void Diff<T>(T[] x, T[] y, IEqualityComparer<T> comparer, List<QuantumFrameDifferGUI.LongestCommonSequence.DiffChunk> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47A1B88 Offset: 0x479DB88 VA: 0x47A1B88
	|-QuantumFrameDifferGUI.LongestCommonSequence.Diff<object>
	|
	|-RVA: 0x47A204C Offset: 0x479E04C VA: 0x47A204C
	|-QuantumFrameDifferGUI.LongestCommonSequence.Diff<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D79748 Offset: 0x7D75748 VA: 0x7D79748
	private void AllocateMatrix(int x, int y) { }

	// RVA: -1 Offset: -1
	private static void FillMatrix<T>(ushort[,] c, ArraySegment<T> x, ArraySegment<T> y, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47A30EC Offset: 0x479F0EC VA: 0x47A30EC
	|-QuantumFrameDifferGUI.LongestCommonSequence.FillMatrix<object>
	|
	|-RVA: 0x47A3470 Offset: 0x479F470 VA: 0x47A3470
	|-QuantumFrameDifferGUI.LongestCommonSequence.FillMatrix<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void FillDiff<T>(ushort[,] c, ArraySegment<T> x, ArraySegment<T> y, IEqualityComparer<T> comparer, List<QuantumFrameDifferGUI.LongestCommonSequence.DiffChunk> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47A2670 Offset: 0x479E670 VA: 0x47A2670
	|-QuantumFrameDifferGUI.LongestCommonSequence.FillDiff<object>
	|
	|-RVA: 0x47A2ACC Offset: 0x479EACC VA: 0x47A2ACC
	|-QuantumFrameDifferGUI.LongestCommonSequence.FillDiff<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class QuantumFrameDifferGUI.<>c // TypeDefIndex: 23299
{
	// Fields
	public static readonly QuantumFrameDifferGUI.<>c <>9; // 0x0
	public static Func<int, int> <>9__48_0; // 0x8
	public static Func<KeyValuePair<int, QuantumFrameDifferGUI.FrameData>, int> <>9__48_1; // 0x10
	public static Func<int, int> <>9__55_0; // 0x18
	public static Func<KeyValuePair<int, QuantumFrameDifferGUI.FrameData>, int> <>9__55_2; // 0x20
	public static Func<KeyValuePair<int, QuantumFrameDifferGUI.FrameData>, QuantumFrameDifferGUI.FrameData> <>9__55_3; // 0x28
	public static Func<QuantumFrameDifferGUI.LongestCommonSequence> <>9__55_4; // 0x30
	public static Action<QuantumFrameDifferGUI.LongestCommonSequence> <>9__55_6; // 0x38

	// Methods

	// RVA: 0x7D79A80 Offset: 0x7D75A80 VA: 0x7D79A80
	private static void .cctor() { }

	// RVA: 0x7D79AE8 Offset: 0x7D75AE8 VA: 0x7D79AE8
	public void .ctor() { }

	// RVA: 0x7D79AF0 Offset: 0x7D75AF0 VA: 0x7D79AF0
	internal int <DrawDiff>b__48_0(int x) { }

	// RVA: 0x7D79AF8 Offset: 0x7D75AF8 VA: 0x7D79AF8
	internal int <DrawDiff>b__48_1(KeyValuePair<int, QuantumFrameDifferGUI.FrameData> x) { }

	// RVA: 0x7D79B34 Offset: 0x7D75B34 VA: 0x7D79B34
	internal int <Diff>b__55_0(int x) { }

	// RVA: 0x7D79B3C Offset: 0x7D75B3C VA: 0x7D79B3C
	internal int <Diff>b__55_2(KeyValuePair<int, QuantumFrameDifferGUI.FrameData> x) { }

	// RVA: 0x7D79B78 Offset: 0x7D75B78 VA: 0x7D79B78
	internal QuantumFrameDifferGUI.FrameData <Diff>b__55_3(KeyValuePair<int, QuantumFrameDifferGUI.FrameData> x) { }

	// RVA: 0x7D79BB4 Offset: 0x7D75BB4 VA: 0x7D79BB4
	internal QuantumFrameDifferGUI.LongestCommonSequence <Diff>b__55_4() { }

	// RVA: 0x7D79C08 Offset: 0x7D75C08 VA: 0x7D79C08
	internal void <Diff>b__55_6(QuantumFrameDifferGUI.LongestCommonSequence lcs) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumFrameDifferGUI.<>c__DisplayClass55_0 // TypeDefIndex: 23300
{
	// Fields
	public QuantumFrameDifferGUI <>4__this; // 0x10
	public QuantumFrameDifferGUI.FrameData[] otherFrames; // 0x18
	public string[] splits; // 0x20
	public string[] baseLines; // 0x28
	public List<ValueTuple<string, string>>[] diffs; // 0x30

	// Methods

	// RVA: 0x7D78FC8 Offset: 0x7D74FC8 VA: 0x7D78FC8
	public void .ctor() { }

	// RVA: 0x7D79C0C Offset: 0x7D75C0C VA: 0x7D79C0C
	internal bool <Diff>b__1(KeyValuePair<int, QuantumFrameDifferGUI.FrameData> x) { }

	// RVA: 0x7D79C60 Offset: 0x7D75C60 VA: 0x7D79C60
	internal QuantumFrameDifferGUI.LongestCommonSequence <Diff>b__5(int frameIndex, ParallelLoopState state, QuantumFrameDifferGUI.LongestCommonSequence lcs) { }
}

// Namespace: 
public abstract class QuantumFrameDifferGUI // TypeDefIndex: 23301
{
	// Fields
	public int ReferenceActorId; // 0x10
	private string _search; // 0x18
	private string _gameId; // 0x20
	private int _scrollOffset; // 0x28
	protected bool _hidden; // 0x2C
	private const float HeaderHeight = 28;
	[CompilerGenerated]
	private QuantumFrameDifferGUI.FrameDifferState <State>k__BackingField; // 0x30

	// Properties
	public QuantumFrameDifferGUI.FrameDifferState State { get; set; }
	public virtual bool IsEditor { get; }
	public virtual int TextLineHeight { get; }
	public virtual GUIStyle DiffBackground { get; }
	public virtual GUIStyle DiffHeader { get; }
	public virtual GUIStyle DiffHeaderError { get; }
	public virtual GUIStyle DiffLineOverlay { get; }
	public virtual GUIStyle MiniButton { get; }
	public virtual GUIStyle TextLabel { get; }
	public virtual GUIStyle BoldLabel { get; }
	public virtual GUIStyle MiniButtonLeft { get; }
	public virtual GUIStyle MiniButtonRight { get; }
	public abstract Rect Position { get; }
	public virtual float ScrollWidth { get; }
	private StringComparer Comparer { get; }

	// Methods

	// RVA: 0x7D753BC Offset: 0x7D713BC VA: 0x7D753BC
	protected void .ctor(QuantumFrameDifferGUI.FrameDifferState state) { }

	[CompilerGenerated]
	// RVA: 0x7D75584 Offset: 0x7D71584 VA: 0x7D75584
	public QuantumFrameDifferGUI.FrameDifferState get_State() { }

	[CompilerGenerated]
	// RVA: 0x7D7558C Offset: 0x7D7158C VA: 0x7D7558C
	public void set_State(QuantumFrameDifferGUI.FrameDifferState value) { }

	// RVA: 0x7D75594 Offset: 0x7D71594 VA: 0x7D75594 Slot: 4
	public virtual bool get_IsEditor() { }

	// RVA: 0x7D7559C Offset: 0x7D7159C VA: 0x7D7559C Slot: 5
	public virtual int get_TextLineHeight() { }

	// RVA: 0x7D755A4 Offset: 0x7D715A4 VA: 0x7D755A4 Slot: 6
	public virtual GUIStyle get_DiffBackground() { }

	// RVA: 0x7D75604 Offset: 0x7D71604 VA: 0x7D75604 Slot: 7
	public virtual GUIStyle get_DiffHeader() { }

	// RVA: 0x7D75664 Offset: 0x7D71664 VA: 0x7D75664 Slot: 8
	public virtual GUIStyle get_DiffHeaderError() { }

	// RVA: 0x7D756C4 Offset: 0x7D716C4 VA: 0x7D756C4 Slot: 9
	public virtual GUIStyle get_DiffLineOverlay() { }

	// RVA: 0x7D75724 Offset: 0x7D71724 VA: 0x7D75724 Slot: 10
	public virtual GUIStyle get_MiniButton() { }

	// RVA: 0x7D75784 Offset: 0x7D71784 VA: 0x7D75784 Slot: 11
	public virtual GUIStyle get_TextLabel() { }

	// RVA: 0x7D757E4 Offset: 0x7D717E4 VA: 0x7D757E4 Slot: 12
	public virtual GUIStyle get_BoldLabel() { }

	// RVA: 0x7D75844 Offset: 0x7D71844 VA: 0x7D75844 Slot: 13
	public virtual GUIStyle get_MiniButtonLeft() { }

	// RVA: 0x7D758A4 Offset: 0x7D718A4 VA: 0x7D758A4 Slot: 14
	public virtual GUIStyle get_MiniButtonRight() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Rect get_Position();

	// RVA: 0x7D75904 Offset: 0x7D71904 VA: 0x7D75904 Slot: 16
	public virtual float get_ScrollWidth() { }

	// RVA: 0x7D7590C Offset: 0x7D7190C VA: 0x7D7590C
	private StringComparer get_Comparer() { }

	// RVA: 0x7D75994 Offset: 0x7D71994 VA: 0x7D75994 Slot: 17
	public virtual void Repaint() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void DrawHeader();

	// RVA: 0x7D75270 Offset: 0x7D71270 VA: 0x7D75270
	public void Show() { }

	// RVA: 0x7D74FF4 Offset: 0x7D70FF4 VA: 0x7D74FF4
	public void OnGUI() { }

	// RVA: 0x7D764A4 Offset: 0x7D724A4 VA: 0x7D764A4
	private void DrawNoDumps() { }

	// RVA: 0x7D75998 Offset: 0x7D71998 VA: 0x7D75998
	private void DrawSelection() { }

	// RVA: 0x7D7662C Offset: 0x7D7262C VA: 0x7D7662C
	private void DrawDiff() { }

	// RVA: 0x7D77F60 Offset: 0x7D73F60 VA: 0x7D77F60
	private Rect CalculateLineRect(int line, Rect mainRect) { }

	// RVA: 0x7D77C40 Offset: 0x7D73C40 VA: 0x7D77C40
	private Rect CalculateTopBarRect() { }

	// RVA: 0x7D77EF0 Offset: 0x7D73EF0 VA: 0x7D77EF0
	private Rect CalculateMainRect(int frameDataCount) { }

	// RVA: 0x7D78DDC Offset: 0x7D74DDC VA: 0x7D78DDC
	private void SearchDiff(QuantumFrameDifferGUI.FrameData frameData, QuantumFrameDifferGUI.FrameData baseFrame, int startIndex, int searchDirection) { }

	// RVA: 0x7D77E04 Offset: 0x7D73E04 VA: 0x7D77E04
	private void Search(QuantumFrameDifferGUI.FrameData frameData, int startIndex, int searchDirection) { }

	// RVA: 0x7D77C68 Offset: 0x7D73C68 VA: 0x7D77C68
	private Dictionary<int, QuantumFrameDifferGUI.FrameData> GetSelectedFrameData() { }

	// RVA: 0x7D77FE4 Offset: 0x7D73FE4 VA: 0x7D77FE4
	private void Diff(Dictionary<int, QuantumFrameDifferGUI.FrameData> frames) { }
}

// Namespace: 
public static class QuantumGameGizmos // TypeDefIndex: 23302
{
	// Methods

	// RVA: 0x7D7A3C8 Offset: 0x7D763C8 VA: 0x7D7A3C8
	private static Color Desaturate(Color c, float t) { }

	// RVA: 0x7D72C5C Offset: 0x7D6EC5C VA: 0x7D72C5C
	public static bool ShouldDraw(QuantumEditorSettings.GizmosMode mode, bool selected, bool hasStateDrawer = True) { }

	// RVA: 0x7D7A440 Offset: 0x7D76440 VA: 0x7D7A440
	public static void OnDrawGizmos(Frame frame, QuantumEditorSettings editorSettings) { }

	// RVA: 0x7D7A444 Offset: 0x7D76444 VA: 0x7D7A444
	public static void DrawCharacterController2DGizmo(Vector3 position, CharacterController2DConfig config, bool selected, QuantumGizmoStyle style) { }

	// RVA: 0x7D7A55C Offset: 0x7D7655C VA: 0x7D7A55C
	public static void DrawCharacterController3DGizmo(Vector3 position, CharacterController3DConfig config, bool selected, QuantumGizmoStyle style) { }

	// RVA: 0x7D7A668 Offset: 0x7D76668 VA: 0x7D7A668
	public static void DrawCollider3DGizmo(Frame frame, EntityRef handle, PhysicsCollider3D* collider, QuantumGizmoStyle style) { }

	// RVA: 0x7D7AE8C Offset: 0x7D76E8C VA: 0x7D7AE8C
	public static void DrawCollider2DGizmo(Frame frame, EntityRef handle, PhysicsCollider2D* collider, QuantumGizmoStyle style) { }

	// RVA: 0x7D7ABAC Offset: 0x7D76BAC VA: 0x7D7ABAC
	public static void DrawShape3DGizmo(Shape3D s, Vector3 position, Quaternion rotation, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x7D7B414 Offset: 0x7D77414 VA: 0x7D7B414
	public static void DrawShape2DGizmo(Shape2D s, Vector3 pos, Quaternion rot, Color color, float height, Frame currentFrame, QuantumGizmoStyle style) { }

	// RVA: 0x7D7B1CC Offset: 0x7D771CC VA: 0x7D7B1CC
	private static void DrawCompoundShape2D(Frame f, Shape2D* compoundShape, Transform2D* transform, Transform2DVertical* transformVertical, Color color, float height, QuantumGizmoStyle style) { }

	// RVA: 0x7D7A8FC Offset: 0x7D768FC VA: 0x7D7A8FC
	private static void DrawCompoundShape3D(Frame f, Shape3D* compoundShape, Transform3D* transform, Color color, QuantumGizmoStyle style) { }
}

// Namespace: 
public class QuantumMapLoader : MonoBehaviour // TypeDefIndex: 23303
{
	// Fields
	private static QuantumMapLoader _instance; // 0x0
	private static bool _isApplicationQuitting; // 0x8

	// Properties
	public static QuantumMapLoader Instance { get; }

	// Methods

	// RVA: 0x7D7B920 Offset: 0x7D77920 VA: 0x7D7B920
	public static QuantumMapLoader get_Instance() { }

	// RVA: 0x7D7BAB8 Offset: 0x7D77AB8 VA: 0x7D7BAB8
	public void Awake() { }

	// RVA: 0x7D7BB10 Offset: 0x7D77B10 VA: 0x7D7BB10
	public void OnApplicationQuit() { }

	// RVA: 0x7D7BB5C Offset: 0x7D77B5C VA: 0x7D7BB5C
	public static void ResetStatics() { }

	// RVA: 0x7D7BBC0 Offset: 0x7D77BC0 VA: 0x7D7BBC0
	public void .ctor() { }
}

// Namespace: 
public static class QuantumProfilingClientConstants // TypeDefIndex: 23304
{
	// Fields
	public const string DISCOVER_TOKEN = "QuantumProfiling/Discover";
	public const string DISCOVER_RESPONSE_TOKEN = "QuantumProfiling/DiscoverResponse";
	public const string CONNECT_TOKEN = "QuantumProfiling/Connect";
	public const byte ClientInfoMessage = 0;
	public const byte FrameMessage = 1;
}

// Namespace: 
[Serializable]
public class QuantumProfilingClientInfo.CustomProperty // TypeDefIndex: 23305
{
	// Fields
	public string Name; // 0x10
	public string Value; // 0x18

	// Methods

	// RVA: 0x7D7C728 Offset: 0x7D78728 VA: 0x7D7C728
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumProfilingClientInfo.<>c__DisplayClass6_0 // TypeDefIndex: 23306
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x7D7C720 Offset: 0x7D78720 VA: 0x7D7C720
	public void .ctor() { }

	// RVA: 0x7D7C730 Offset: 0x7D78730 VA: 0x7D7C730
	internal bool <GetProperty>b__0(QuantumProfilingClientInfo.CustomProperty x) { }
}

// Namespace: 
[Serializable]
public class QuantumProfilingClientInfo // TypeDefIndex: 23307
{
	// Fields
	public string ProfilerId; // 0x10
	public DeterministicSessionConfig Config; // 0x18
	public List<QuantumProfilingClientInfo.CustomProperty> Properties; // 0x20

	// Methods

	// RVA: 0x7D7BBC8 Offset: 0x7D77BC8 VA: 0x7D7BBC8
	public void .ctor() { }

	// RVA: 0x7D7BC50 Offset: 0x7D77C50 VA: 0x7D7BC50
	public void .ctor(string clientId, DeterministicSessionConfig config, DeterministicPlatformInfo platformInfo) { }

	// RVA: 0x7D7C5F4 Offset: 0x7D785F4 VA: 0x7D7C5F4
	public string GetProperty(string name, string defaultValue = "Unknown") { }

	// RVA: -1 Offset: -1
	private static QuantumProfilingClientInfo.CustomProperty CreateProperty<T>(string name, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B6CB8 Offset: 0x46B2CB8 VA: 0x46B6CB8
	|-QuantumProfilingClientInfo.CreateProperty<int>
	|
	|-RVA: 0x46B6D08 Offset: 0x46B2D08 VA: 0x46B6D08
	|-QuantumProfilingClientInfo.CreateProperty<Int32Enum>
	|
	|-RVA: 0x46B6D7C Offset: 0x46B2D7C VA: 0x46B6D7C
	|-QuantumProfilingClientInfo.CreateProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D7C568 Offset: 0x7D78568 VA: 0x7D7C568
	private static QuantumProfilingClientInfo.CustomProperty CreateProperty(string name, string value) { }
}

// Namespace: 
public struct QuantumRunner.StartParameters // TypeDefIndex: 23308
{
	// Fields
	public RuntimeConfig RuntimeConfig; // 0x0
	public DeterministicSessionConfig DeterministicConfig; // 0x8
	public string RunnerId; // 0x10
	public int PlayerCount; // 0x18
	public int LocalPlayerCount; // 0x1C
	public IResourceManager ResourceManagerOverride; // 0x20
	public int HeapExtraCount; // 0x28
	public DynamicAssetDB InitialDynamicAssets; // 0x30
	[Obsolete("IsRejoin is not used anymore")]
	public bool IsRejoin; // 0x38
	public float StartGameTimeoutInSeconds; // 0x3C
}

// Namespace: 
public sealed class QuantumRunner : MonoBehaviour, IDisposable // TypeDefIndex: 23309
{
	// Fields
	private static List<QuantumRunner> _activeRunners; // 0x0
	[HideInInspector]
	public bool OverrideUpdateSession; // 0x20
	[CompilerGenerated]
	private QuantumGame <Game>k__BackingField; // 0x28
	[CompilerGenerated]
	private DeterministicSession <Session>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x38
	[CompilerGenerated]
	private SimulationUpdateTime <DeltaTimeType>k__BackingField; // 0x40
	public bool HideGizmos; // 0x44
	public QuantumEditorSettings GizmoSettings; // 0x48
	private bool _shutdownRequested; // 0x50
	private float _startGameTimeout; // 0x54

	// Properties
	public static QuantumRunner Default { get; }
	public static IEnumerable<QuantumRunner> ActiveRunners { get; }
	public QuantumGame Game { get; set; }
	public DeterministicSession Session { get; set; }
	public string Id { get; set; }
	public SimulationUpdateTime DeltaTimeType { get; set; }
	public Nullable<float> DeltaTime { get; }

	// Methods

	// RVA: 0x7D7C754 Offset: 0x7D78754 VA: 0x7D7C754
	public static QuantumRunner get_Default() { }

	// RVA: 0x7D7C814 Offset: 0x7D78814 VA: 0x7D7C814
	public static IEnumerable<QuantumRunner> get_ActiveRunners() { }

	[CompilerGenerated]
	// RVA: 0x7D7C86C Offset: 0x7D7886C VA: 0x7D7C86C
	public QuantumGame get_Game() { }

	[CompilerGenerated]
	// RVA: 0x7D7C874 Offset: 0x7D78874 VA: 0x7D7C874
	private void set_Game(QuantumGame value) { }

	[CompilerGenerated]
	// RVA: 0x7D7C87C Offset: 0x7D7887C VA: 0x7D7C87C
	public DeterministicSession get_Session() { }

	[CompilerGenerated]
	// RVA: 0x7D7C884 Offset: 0x7D78884 VA: 0x7D7C884
	private void set_Session(DeterministicSession value) { }

	[CompilerGenerated]
	// RVA: 0x7D7C88C Offset: 0x7D7888C VA: 0x7D7C88C
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x7D7C894 Offset: 0x7D78894 VA: 0x7D7C894
	private void set_Id(string value) { }

	[CompilerGenerated]
	// RVA: 0x7D7C89C Offset: 0x7D7889C VA: 0x7D7C89C
	public SimulationUpdateTime get_DeltaTimeType() { }

	[CompilerGenerated]
	// RVA: 0x7D7C8A4 Offset: 0x7D788A4 VA: 0x7D7C8A4
	public void set_DeltaTimeType(SimulationUpdateTime value) { }

	// RVA: 0x7D7C8AC Offset: 0x7D788AC VA: 0x7D7C8AC
	public Nullable<float> get_DeltaTime() { }

	// RVA: 0x7D7C930 Offset: 0x7D78930 VA: 0x7D7C930
	private void Update() { }

	// RVA: 0x7D7CA28 Offset: 0x7D78A28 VA: 0x7D7CA28
	private void OnDisable() { }

	// RVA: 0x7D7CADC Offset: 0x7D78ADC VA: 0x7D7CADC
	private void OnDrawGizmos() { }

	// RVA: 0x7D7C9BC Offset: 0x7D789BC VA: 0x7D7C9BC
	public void Shutdown() { }

	// RVA: 0x7D7CAE0 Offset: 0x7D78AE0 VA: 0x7D7CAE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x7D7CAE4 Offset: 0x7D78AE4 VA: 0x7D7CAE4
	public static void Init(bool force = False) { }

	// RVA: 0x7D7CF7C Offset: 0x7D78F7C VA: 0x7D7CF7C
	public static QuantumRunner StartGame(string clientId, QuantumRunner.StartParameters param) { }

	// RVA: 0x7D7D650 Offset: 0x7D79650 VA: 0x7D7D650
	public static DeterministicPlatformInfo CreatePlatformInfo() { }

	// RVA: 0x7D7D81C Offset: 0x7D7981C VA: 0x7D7D81C
	public static bool ShutdownAll(bool immediate = False) { }

	// RVA: 0x7D7DA38 Offset: 0x7D79A38 VA: 0x7D7DA38
	public static QuantumRunner FindRunner(string id) { }

	// RVA: 0x7D7DBBC Offset: 0x7D79BBC VA: 0x7D7DBBC
	public static QuantumRunner FindRunner(IDeterministicGame game) { }

	[Obsolete("Use FindRunner")]
	// RVA: 0x7D7DD3C Offset: 0x7D79D3C VA: 0x7D7DD3C
	internal static QuantumRunner FindRunnerForGame(IDeterministicGame game) { }

	// RVA: 0x7D7D4A0 Offset: 0x7D794A0 VA: 0x7D7D4A0
	private static QuantumRunner CreateInstance(string name) { }

	// RVA: 0x7D7DD90 Offset: 0x7D79D90 VA: 0x7D7DD90
	public void .ctor() { }

	// RVA: 0x7D7DD98 Offset: 0x7D79D98 VA: 0x7D7DD98
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class QuantumRunnerLocalDebug.DynamicAssetDBSettings.InitialDynamicAssetsRequestedUnityEvent : UnityEvent<DynamicAssetDB> // TypeDefIndex: 23310
{
	// Methods

	// RVA: 0x7D7E538 Offset: 0x7D7A538 VA: 0x7D7E538
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct QuantumRunnerLocalDebug.DynamicAssetDBSettings // TypeDefIndex: 23311
{
	// Fields
	public QuantumRunnerLocalDebug.DynamicAssetDBSettings.InitialDynamicAssetsRequestedUnityEvent OnInitialDynamicAssetsRequested; // 0x0
}

// Namespace: 
[CompilerGenerated]
private sealed class QuantumRunnerLocalDebug.<SaveAndReload>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 23312
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7D7E4B0 Offset: 0x7D7A4B0 VA: 0x7D7E4B0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7D7E580 Offset: 0x7D7A580 VA: 0x7D7E580 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D7E584 Offset: 0x7D7A584 VA: 0x7D7E584 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D7E6B0 Offset: 0x7D7A6B0 VA: 0x7D7E6B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D7E6B8 Offset: 0x7D7A6B8 VA: 0x7D7E6B8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7D7E6F0 Offset: 0x7D7A6F0 VA: 0x7D7E6F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private struct QuantumRunnerLocalDebug.<Start>d__6 : IAsyncStateMachine // TypeDefIndex: 23313
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public QuantumRunnerLocalDebug <>4__this; // 0x28
	private List.Enumerator<QTuple<AssetRef, string>> <>7__wrap1; // 0x30
	private TaskAwaiter<AssetBase> <>u__1; // 0x50

	// Methods

	// RVA: 0x7D7E6F8 Offset: 0x7D7A6F8 VA: 0x7D7E6F8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D7EBA4 Offset: 0x7D7ABA4 VA: 0x7D7EBA4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
public class QuantumRunnerLocalDebug : QuantumCallbacks // TypeDefIndex: 23314
{
	// Fields
	public float SimulationSpeedMultiplier; // 0x20
	public bool DisplaySaveAndReloadButton; // 0x24
	public RuntimeConfig Config; // 0x28
	public bool PreloadAddressables; // 0x30
	public QuantumRunnerLocalDebug.DynamicAssetDBSettings DynamicAssetDB; // 0x38
	private bool _isReload; // 0x40

	// Methods

	[AsyncStateMachine(typeof(QuantumRunnerLocalDebug.<Start>d__6))]
	// RVA: 0x7D7DE30 Offset: 0x7D79E30 VA: 0x7D7DE30
	public void Start() { }

	// RVA: 0x7D7DEE8 Offset: 0x7D79EE8 VA: 0x7D7DEE8
	public void StartWithFrame(int frameNumber = 0, byte[] frameData) { }

	// RVA: 0x7D7E154 Offset: 0x7D7A154 VA: 0x7D7E154 Slot: 6
	public override void OnGameStart(QuantumGame game) { }

	// RVA: 0x7D7E158 Offset: 0x7D7A158 VA: 0x7D7E158
	public void OnGUI() { }

	// RVA: 0x7D7E328 Offset: 0x7D7A328 VA: 0x7D7E328
	public void Update() { }

	[IteratorStateMachine(typeof(QuantumRunnerLocalDebug.<SaveAndReload>d__11))]
	// RVA: 0x7D7E2D0 Offset: 0x7D7A2D0 VA: 0x7D7E2D0
	private IEnumerator SaveAndReload() { }

	// RVA: 0x7D7E4D8 Offset: 0x7D7A4D8 VA: 0x7D7E4D8
	public void .ctor() { }
}

// Namespace: 
private struct QuantumTaskRunnerJobs.ActionJob : IJob // TypeDefIndex: 23315
{
	// Fields
	public int Index; // 0x0

	// Methods

	// RVA: 0x7D7EF24 Offset: 0x7D7AF24 VA: 0x7D7EF24 Slot: 4
	public void Execute() { }
}

// Namespace: 
public class QuantumTaskRunnerJobs : MonoBehaviour, IDisposable, IDeterministicPlatformTaskRunner // TypeDefIndex: 23316
{
	// Fields
	private static Action[] _delegates; // 0x0
	private NativeArray<JobHandle> _handles; // 0x20
	private QuantumTaskRunnerJobs.ActionJob[] _jobs; // 0x30

	// Methods

	// RVA: 0x7D7D714 Offset: 0x7D79714 VA: 0x7D7D714
	public static QuantumTaskRunnerJobs GetInstance() { }

	// RVA: 0x7D7EBB0 Offset: 0x7D7ABB0 VA: 0x7D7EBB0 Slot: 8
	public virtual void Schedule(Action[] delegates) { }

	// RVA: 0x7D7ED98 Offset: 0x7D7AD98 VA: 0x7D7ED98 Slot: 7
	public bool PollForComplete() { }

	// RVA: 0x7D7EE64 Offset: 0x7D7AE64 VA: 0x7D7EE64 Slot: 6
	public void WaitForComplete() { }

	// RVA: 0x7D7EE74 Offset: 0x7D7AE74 VA: 0x7D7EE74
	private void OnDestroy() { }

	// RVA: 0x7D7EE78 Offset: 0x7D7AE78 VA: 0x7D7EE78 Slot: 4
	public void Dispose() { }

	// RVA: 0x7D7EF1C Offset: 0x7D7AF1C VA: 0x7D7EF1C
	public void .ctor() { }
}

// Namespace: 
public class QuantumUnityMemoryLayoutVerifierPlatform : MemoryLayoutVerifier.IPlatform // TypeDefIndex: 23317
{
	// Properties
	public bool CanResolveEnumSize { get; }

	// Methods

	// RVA: 0x7D7EFA4 Offset: 0x7D7AFA4 VA: 0x7D7EFA4 Slot: 5
	public int FieldOffset(FieldInfo field) { }

	// RVA: 0x7D7EFB0 Offset: 0x7D7AFB0 VA: 0x7D7EFB0 Slot: 6
	public int SizeOf(Type type) { }

	// RVA: 0x7D7EFBC Offset: 0x7D7AFBC VA: 0x7D7EFBC Slot: 4
	public bool get_CanResolveEnumSize() { }

	// RVA: 0x7D7CF6C Offset: 0x7D78F6C VA: 0x7D7CF6C
	public void .ctor() { }
}

// Namespace: 
public sealed class QuantumUnityNativeAllocator : Native.Allocator // TypeDefIndex: 23318
{
	// Methods

	// RVA: 0x7D7EFC4 Offset: 0x7D7AFC4 VA: 0x7D7EFC4 Slot: 5
	public sealed override void* Alloc(int count) { }

	// RVA: 0x7D7F008 Offset: 0x7D7B008 VA: 0x7D7F008 Slot: 6
	public sealed override void* Alloc(int count, int alignment) { }

	// RVA: 0x7D7F050 Offset: 0x7D7B050 VA: 0x7D7F050 Slot: 4
	public sealed override void Free(void* ptr) { }

	// RVA: 0x7D7F074 Offset: 0x7D7B074 VA: 0x7D7F074 Slot: 7
	protected sealed override void Clear(void* dest, int count) { }

	// RVA: 0x7D7D70C Offset: 0x7D7970C VA: 0x7D7D70C
	public void .ctor() { }
}

// Namespace: 
private static class QuantumUnityNativeUtility.ObjectPinner // TypeDefIndex: 23319
{
	// Fields
	private static object _pinLock; // 0x0
	public static object _pinnedObject; // 0x8
	public static ulong _pinnedHandle; // 0x10

	// Methods

	// RVA: 0x7D7F8A0 Offset: 0x7D7B8A0 VA: 0x7D7F8A0
	private static void VerifyHandle(Native.ObjectHandle handle) { }

	// RVA: 0x7D7F0DC Offset: 0x7D7B0DC VA: 0x7D7F0DC
	public static Native.ObjectHandle HandleAcquire(object obj) { }

	// RVA: 0x7D7F310 Offset: 0x7D7B310 VA: 0x7D7F310
	public static void HandleRelease(Native.ObjectHandle handle) { }

	// RVA: 0x7D7F5B0 Offset: 0x7D7B5B0 VA: 0x7D7F5B0
	public static object GetObjectForHandle(Native.ObjectHandle handle) { }

	// RVA: 0x7D7F928 Offset: 0x7D7B928 VA: 0x7D7F928
	private static void .cctor() { }
}

// Namespace: 
public class QuantumUnityNativeUtility : Native.Utility // TypeDefIndex: 23320
{
	// Methods

	// RVA: 0x7D7F088 Offset: 0x7D7B088 VA: 0x7D7F088 Slot: 4
	public override Native.ObjectHandle HandleAcquire(object obj) { }

	// RVA: 0x7D7F2AC Offset: 0x7D7B2AC VA: 0x7D7F2AC Slot: 5
	public override void HandleRelease(Native.ObjectHandle handle) { }

	// RVA: 0x7D7F54C Offset: 0x7D7B54C VA: 0x7D7F54C Slot: 6
	public override object GetObjectForHandle(Native.ObjectHandle handle) { }

	// RVA: 0x7D7F7D8 Offset: 0x7D7B7D8 VA: 0x7D7F7D8 Slot: 8
	public override void Clear(void* dest, int count) { }

	// RVA: 0x7D7F7EC Offset: 0x7D7B7EC VA: 0x7D7F7EC Slot: 7
	public override void Copy(void* dest, void* src, int count) { }

	// RVA: 0x7D7F804 Offset: 0x7D7B804 VA: 0x7D7F804 Slot: 9
	public override void Move(void* dest, void* src, int count) { }

	// RVA: 0x7D7F81C Offset: 0x7D7B81C VA: 0x7D7F81C Slot: 10
	public override int Compare(void* ptr1, void* ptr2, int count) { }

	// RVA: 0x7D7F834 Offset: 0x7D7B834 VA: 0x7D7F834
	public static void ResetStatics() { }

	// RVA: 0x7D7CF74 Offset: 0x7D78F74 VA: 0x7D7CF74
	public void .ctor() { }
}

// Namespace: 
public class QuantumRunnerLocalSavegame : MonoBehaviour // TypeDefIndex: 23321
{
	// Fields
	public TextAsset SavegameFile; // 0x20
	public TextAsset DatabaseFile; // 0x28
	public string DatabasePath; // 0x30
	private IResourceManager _resourceManager; // 0x38

	// Methods

	// RVA: 0x7D7F9A4 Offset: 0x7D7B9A4 VA: 0x7D7F9A4
	public void Start() { }

	// RVA: 0x7D7FBD8 Offset: 0x7D7BBD8 VA: 0x7D7FBD8
	private void OnDestroy() { }

	// RVA: 0x7D7FC84 Offset: 0x7D7BC84 VA: 0x7D7FC84
	public void .ctor() { }
}

// Namespace: 
public class QuantumMemoryStats : MonoBehaviour // TypeDefIndex: 23322
{
	// Fields
	public Text TotalMemory; // 0x20
	public Text TotalPages; // 0x28
	public Text TotalUsage; // 0x30
	public Text PagesFree; // 0x38
	public Text PagesFull; // 0x40
	public Text PagesUsed; // 0x48
	public Text BytesAllocated; // 0x50
	public Text BytesReserved; // 0x58
	public Text BytesCommited; // 0x60
	public Text EntityCount; // 0x68
	public Text EntityMemory; // 0x70
	private static string[] suf; // 0x0

	// Methods

	// RVA: 0x7D7FC8C Offset: 0x7D7BC8C VA: 0x7D7FC8C
	private void Update() { }

	// RVA: 0x7D7FD34 Offset: 0x7D7BD34 VA: 0x7D7FD34
	private void UpdateStats(Frame f) { }

	// RVA: 0x7D7FF30 Offset: 0x7D7BF30 VA: 0x7D7FF30
	private void UpdateStatsValue(Text text, int value, bool isBytes = True) { }

	// RVA: 0x7D7FFD0 Offset: 0x7D7BFD0 VA: 0x7D7FFD0
	private static string BytesToString(long byteCount) { }

	// RVA: 0x7D801C8 Offset: 0x7D7C1C8 VA: 0x7D801C8
	public void .ctor() { }

	// RVA: 0x7D801D0 Offset: 0x7D7C1D0 VA: 0x7D801D0
	private static void .cctor() { }
}

// Namespace: 
public class QuantumStats : MonoBehaviour // TypeDefIndex: 23323
{
	// Fields
	public Text FrameVerified; // 0x20
	public Text FramePredicted; // 0x28
	public Text Predicted; // 0x30
	public Text Resimulated; // 0x38
	public Text SimulateTime; // 0x40
	public Text SimulationState; // 0x48
	public Text NetworkPing; // 0x50
	public Text NetworkIn; // 0x58
	public Text NetworkOut; // 0x60
	public Text InputOffset; // 0x68
	public Text ToggleButtonText; // 0x70
	public GameObject[] Toggles; // 0x78
	public bool StartEnabled; // 0x80
	private Stopwatch _networkTimer; // 0x88

	// Methods

	// RVA: 0x7D803B8 Offset: 0x7D7C3B8 VA: 0x7D803B8
	private void Start() { }

	// RVA: 0x7D80560 Offset: 0x7D7C560 VA: 0x7D80560
	private void Update() { }

	// RVA: 0x7D80494 Offset: 0x7D7C494 VA: 0x7D80494
	private void SetState(bool state) { }

	// RVA: 0x7D80868 Offset: 0x7D7C868 VA: 0x7D80868
	public void Toggle() { }

	// RVA: 0x7D808AC Offset: 0x7D7C8AC VA: 0x7D808AC
	public static void Show() { }

	// RVA: 0x7D809B8 Offset: 0x7D7C9B8 VA: 0x7D809B8
	public static void Hide() { }

	// RVA: 0x7D808C8 Offset: 0x7D7C8C8 VA: 0x7D808C8
	public static QuantumStats GetObject() { }

	// RVA: 0x7D809D4 Offset: 0x7D7C9D4 VA: 0x7D809D4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FPMathUtils.<>c // TypeDefIndex: 23324
{
	// Fields
	public static readonly FPMathUtils.<>c <>9; // 0x0
	public static LutProvider <>9__0_0; // 0x8

	// Methods

	// RVA: 0x7D80FC4 Offset: 0x7D7CFC4 VA: 0x7D80FC4
	private static void .cctor() { }

	// RVA: 0x7D8102C Offset: 0x7D7D02C VA: 0x7D8102C
	public void .ctor() { }

	// RVA: 0x7D81034 Offset: 0x7D7D034 VA: 0x7D81034
	internal byte[] <LoadLookupTables>b__0_0(string file) { }
}

// Namespace: 
[Extension]
public static class FPMathUtils // TypeDefIndex: 23325
{
	// Methods

	// RVA: 0x7D73740 Offset: 0x7D6F740 VA: 0x7D73740
	public static void LoadLookupTables(bool force = False) { }

	[Extension]
	// RVA: 0x7D74160 Offset: 0x7D70160 VA: 0x7D74160
	public static FP ToFP(float v) { }

	[Extension]
	// RVA: 0x7D72F38 Offset: 0x7D6EF38 VA: 0x7D72F38
	public static FP FlipRotation(FP r) { }

	[Extension]
	// RVA: 0x7D72F40 Offset: 0x7D6EF40 VA: 0x7D72F40
	public static Quaternion ToUnityQuaternionDegrees(FP r) { }

	[Extension]
	// RVA: 0x7D7B3D8 Offset: 0x7D773D8 VA: 0x7D7B3D8
	public static Quaternion ToUnityQuaternion(FP r) { }

	[Extension]
	// RVA: 0x7D7AABC Offset: 0x7D76ABC VA: 0x7D7AABC
	public static Quaternion ToUnityQuaternion(FPQuaternion r) { }

	[Extension]
	// RVA: 0x7D809E4 Offset: 0x7D7C9E4 VA: 0x7D809E4
	public static FPQuaternion ToFPQuaternion(Quaternion r) { }

	[Extension]
	// RVA: 0x7D80A60 Offset: 0x7D7CA60 VA: 0x7D80A60
	public static FP ToFPRotation2DDegrees(Quaternion r) { }

	[Extension]
	// RVA: 0x7D80AA0 Offset: 0x7D7CAA0 VA: 0x7D80AA0
	public static FP ToFPRotation2D(Quaternion r) { }

	[Extension]
	// RVA: 0x7D728D0 Offset: 0x7D6E8D0 VA: 0x7D728D0
	public static FPVector2 ToFPVector2(Vector2 v) { }

	[Extension]
	// RVA: 0x7D80AE8 Offset: 0x7D7CAE8 VA: 0x7D80AE8
	public static Vector2 ToUnityVector2(FPVector2 v) { }

	[Extension]
	// RVA: 0x7D80B04 Offset: 0x7D7CB04 VA: 0x7D80B04
	public static FPVector2 ToFPVector2(Vector3 v) { }

	[Extension]
	// RVA: 0x7D80B80 Offset: 0x7D7CB80 VA: 0x7D80B80
	public static FP ToFPVerticalPosition(Vector3 v) { }

	[Extension]
	// RVA: 0x7D73834 Offset: 0x7D6F834 VA: 0x7D73834
	public static FPVector3 ToFPVector3(Vector3 v) { }

	[Extension]
	// RVA: 0x7D72F18 Offset: 0x7D6EF18 VA: 0x7D72F18
	public static Vector3 ToUnityVector3(FPVector2 v) { }

	[Extension]
	// RVA: 0x7D7437C Offset: 0x7D7037C VA: 0x7D7437C
	public static Vector3 ToUnityVector3(FPVector3 v) { }

	[Extension]
	// RVA: 0x7D80B8C Offset: 0x7D7CB8C VA: 0x7D80B8C
	public static Vector3 ToUnityVector3(FPVector3 v, bool quantumXYSwizzle) { }

	[Extension]
	// RVA: 0x7D80BB8 Offset: 0x7D7CBB8 VA: 0x7D80BB8
	public static Vector2 ToUnityVector2(FPVector3 v) { }

	[Extension]
	// RVA: 0x7D80BD8 Offset: 0x7D7CBD8 VA: 0x7D80BD8
	public static Vector3 RoundToInt(Vector3 v) { }

	[Extension]
	// RVA: 0x7D80E1C Offset: 0x7D7CE1C VA: 0x7D80E1C
	public static Vector2 RoundToInt(Vector2 v) { }

	[Extension]
	// RVA: 0x7D80FBC Offset: 0x7D7CFBC VA: 0x7D80FBC
	public static Color32 ToColor32(ColorRGBA clr) { }

	[Extension]
	// RVA: 0x7D74F04 Offset: 0x7D70F04 VA: 0x7D74F04
	public static Color ToColor(ColorRGBA clr) { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 23326
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 23327
{
	// Methods

	// RVA: 0x7D810B4 Offset: 0x7D7D0B4 VA: 0x7D810B4
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x7D811AC Offset: 0x7D7D1AC VA: 0x7D811AC
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AssetResourceContainer.AssetResourceInfo_Addressables : AssetResourceInfo // TypeDefIndex: 23328
{
	// Fields
	public string Address; // 0x20

	// Methods

	// RVA: 0x7D82258 Offset: 0x7D7E258 VA: 0x7D82258
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AssetResourceContainer.AssetResourceInfoGroup_Addressables : AssetResourceInfoGroup<AssetResourceContainer.AssetResourceInfo_Addressables> // TypeDefIndex: 23329
{
	// Properties
	public override int SortOrder { get; }

	// Methods

	// RVA: 0x7D82268 Offset: 0x7D7E268 VA: 0x7D82268 Slot: 5
	public override int get_SortOrder() { }

	// RVA: 0x7D82270 Offset: 0x7D7E270 VA: 0x7D82270 Slot: 6
	public override UnityResourceLoader.ILoader CreateLoader() { }

	// RVA: 0x7D8235C Offset: 0x7D7E35C VA: 0x7D8235C
	public void .ctor() { }
}

// Namespace: 
private class AssetResourceContainer.Loader_Addressables : UnityResourceLoader.LoaderBase<AssetResourceContainer.AssetResourceInfo_Addressables, AsyncOperationHandle<AssetBase>> // TypeDefIndex: 23330
{
	// Fields
	private Dictionary<AssetGuid, AsyncOperationHandle<AssetBase>> _handles; // 0x18

	// Methods

	// RVA: 0x7D823A4 Offset: 0x7D7E3A4 VA: 0x7D823A4 Slot: 10
	protected override AssetBase GetAssetFromAsyncState(AssetResourceContainer.AssetResourceInfo_Addressables resourceInfo, AsyncOperationHandle<AssetBase> asyncState) { }

	// RVA: 0x7D82478 Offset: 0x7D7E478 VA: 0x7D82478 Slot: 11
	protected override bool IsDone(AsyncOperationHandle<AssetBase> asyncState) { }

	// RVA: 0x7D824C0 Offset: 0x7D7E4C0 VA: 0x7D824C0 Slot: 12
	protected override AsyncOperationHandle<AssetBase> LoadAsync(AssetResourceContainer.AssetResourceInfo_Addressables info) { }

	// RVA: 0x7D825C4 Offset: 0x7D7E5C4 VA: 0x7D825C4 Slot: 13
	protected override AssetBase LoadSync(AssetResourceContainer.AssetResourceInfo_Addressables info) { }

	// RVA: 0x7D829AC Offset: 0x7D7E9AC VA: 0x7D829AC Slot: 14
	protected override void Unload(AssetResourceContainer.AssetResourceInfo_Addressables info, AssetBase asset) { }

	// RVA: 0x7D822C0 Offset: 0x7D7E2C0 VA: 0x7D822C0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AssetResourceContainer.AssetResourceInfo_AssetBundle : AssetResourceInfo // TypeDefIndex: 23331
{
	// Fields
	public string AssetBundle; // 0x20
	public string AssetName; // 0x28

	// Methods

	// RVA: 0x7D82B08 Offset: 0x7D7EB08 VA: 0x7D82B08
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AssetResourceContainer.AssetResourceInfoGroup_AssetBundle : AssetResourceInfoGroup<AssetResourceContainer.AssetResourceInfo_AssetBundle> // TypeDefIndex: 23332
{
	// Properties
	public override int SortOrder { get; }

	// Methods

	// RVA: 0x7D82B10 Offset: 0x7D7EB10 VA: 0x7D82B10 Slot: 5
	public override int get_SortOrder() { }

	// RVA: 0x7D82B18 Offset: 0x7D7EB18 VA: 0x7D82B18 Slot: 6
	public override UnityResourceLoader.ILoader CreateLoader() { }

	// RVA: 0x7D82BB0 Offset: 0x7D7EBB0 VA: 0x7D82BB0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AssetResourceContainer.Loader_AssetBundles.<>c__DisplayClass5_0 // TypeDefIndex: 23333
{
	// Fields
	public AssetResourceContainer.AssetResourceInfo_AssetBundle resource; // 0x10

	// Methods

	// RVA: 0x7D83078 Offset: 0x7D7F078 VA: 0x7D83078
	public void .ctor() { }

	// RVA: 0x7D83080 Offset: 0x7D7F080 VA: 0x7D83080
	internal bool <GetAssetBundleOrThrow>b__0(AssetBundle ab) { }
}

// Namespace: 
private class AssetResourceContainer.Loader_AssetBundles : UnityResourceLoader.LoaderBase<AssetResourceContainer.AssetResourceInfo_AssetBundle, AssetBundleRequest> // TypeDefIndex: 23334
{
	// Methods

	// RVA: 0x7D82BF8 Offset: 0x7D7EBF8 VA: 0x7D82BF8 Slot: 10
	protected override AssetBase GetAssetFromAsyncState(AssetResourceContainer.AssetResourceInfo_AssetBundle resourceInfo, AssetBundleRequest asyncState) { }

	// RVA: 0x7D82CE8 Offset: 0x7D7ECE8 VA: 0x7D82CE8 Slot: 11
	protected override bool IsDone(AssetBundleRequest asyncState) { }

	// RVA: 0x7D82D00 Offset: 0x7D7ED00 VA: 0x7D82D00 Slot: 12
	protected override AssetBundleRequest LoadAsync(AssetResourceContainer.AssetResourceInfo_AssetBundle info) { }

	// RVA: 0x7D82FBC Offset: 0x7D7EFBC VA: 0x7D82FBC Slot: 13
	protected override AssetBase LoadSync(AssetResourceContainer.AssetResourceInfo_AssetBundle info) { }

	// RVA: 0x7D83074 Offset: 0x7D7F074 VA: 0x7D83074 Slot: 14
	protected override void Unload(AssetResourceContainer.AssetResourceInfo_AssetBundle info, AssetBase asset) { }

	// RVA: 0x7D82D98 Offset: 0x7D7ED98 VA: 0x7D82D98
	private AssetBundle GetAssetBundleOrThrow(AssetResourceContainer.AssetResourceInfo_AssetBundle resource) { }

	// RVA: 0x7D82B68 Offset: 0x7D7EB68 VA: 0x7D82B68
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AssetResourceContainer.AssetResourceInfo_Resources : AssetResourceInfo // TypeDefIndex: 23335
{
	// Fields
	public string ResourcePath; // 0x20

	// Methods

	// RVA: 0x7D830B4 Offset: 0x7D7F0B4 VA: 0x7D830B4
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AssetResourceContainer.AssetResourceInfoGroup_Resources : AssetResourceInfoGroup<AssetResourceContainer.AssetResourceInfo_Resources> // TypeDefIndex: 23336
{
	// Properties
	public override int SortOrder { get; }

	// Methods

	// RVA: 0x7D830BC Offset: 0x7D7F0BC VA: 0x7D830BC Slot: 5
	public override int get_SortOrder() { }

	// RVA: 0x7D830C4 Offset: 0x7D7F0C4 VA: 0x7D830C4 Slot: 6
	public override UnityResourceLoader.ILoader CreateLoader() { }

	// RVA: 0x7D8315C Offset: 0x7D7F15C VA: 0x7D8315C
	public void .ctor() { }
}

// Namespace: 
private class AssetResourceContainer.Loader_Resources : UnityResourceLoader.LoaderBase<AssetResourceContainer.AssetResourceInfo_Resources, ResourceRequest> // TypeDefIndex: 23337
{
	// Methods

	// RVA: 0x7D831A4 Offset: 0x7D7F1A4 VA: 0x7D831A4 Slot: 10
	protected override AssetBase GetAssetFromAsyncState(AssetResourceContainer.AssetResourceInfo_Resources info, ResourceRequest asyncState) { }

	// RVA: 0x7D83288 Offset: 0x7D7F288 VA: 0x7D83288 Slot: 11
	protected override bool IsDone(ResourceRequest asyncState) { }

	// RVA: 0x7D832A0 Offset: 0x7D7F2A0 VA: 0x7D832A0 Slot: 12
	protected override ResourceRequest LoadAsync(AssetResourceContainer.AssetResourceInfo_Resources info) { }

	// RVA: 0x7D832F0 Offset: 0x7D7F2F0 VA: 0x7D832F0 Slot: 13
	protected override AssetBase LoadSync(AssetResourceContainer.AssetResourceInfo_Resources info) { }

	// RVA: 0x7D83398 Offset: 0x7D7F398 VA: 0x7D83398 Slot: 14
	protected override void Unload(AssetResourceContainer.AssetResourceInfo_Resources info, AssetBase asset) { }

	// RVA: 0x7D83114 Offset: 0x7D7F114 VA: 0x7D83114
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AssetResourceContainer.<>c // TypeDefIndex: 23338
{
	// Fields
	public static readonly AssetResourceContainer.<>c <>9; // 0x0
	public static Func<AssetResourceInfoGroup, int> <>9__2_0; // 0x8
	public static Func<AssetResourceInfoGroup, UnityResourceLoader.ILoader> <>9__3_0; // 0x10
	public static Func<FieldInfo, bool> <>9__8_0; // 0x18
	public static Func<AssetResourceInfoGroup, int> <>9__8_2; // 0x20

	// Methods

	// RVA: 0x7D8341C Offset: 0x7D7F41C VA: 0x7D8341C
	private static void .cctor() { }

	// RVA: 0x7D83484 Offset: 0x7D7F484 VA: 0x7D83484
	public void .ctor() { }

	// RVA: 0x7D8348C Offset: 0x7D7F48C VA: 0x7D8348C
	internal int <get_AssetCount>b__2_0(AssetResourceInfoGroup x) { }

	// RVA: 0x7D83540 Offset: 0x7D7F540 VA: 0x7D83540
	internal UnityResourceLoader.ILoader <CreateLoader>b__3_0(AssetResourceInfoGroup x) { }

	// RVA: 0x7D83564 Offset: 0x7D7F564 VA: 0x7D83564
	internal bool <InitGroups>b__8_0(FieldInfo x) { }

	// RVA: 0x7D83614 Offset: 0x7D7F614 VA: 0x7D83614
	internal int <InitGroups>b__8_2(AssetResourceInfoGroup x) { }
}

// Namespace: Quantum
public class AssetResourceContainer : ScriptableObject // TypeDefIndex: 23339
{
	// Fields
	private List<AssetResourceInfoGroup> _groups; // 0x18
	public AssetResourceContainer.AssetResourceInfoGroup_Addressables AddressablesGroup; // 0x20
	public AssetResourceContainer.AssetResourceInfoGroup_AssetBundle AssetBundlesGroup; // 0x28
	public AssetResourceContainer.AssetResourceInfoGroup_Resources ResourcesGroup; // 0x30

	// Properties
	public int AssetCount { get; }
	public IReadOnlyList<AssetResourceInfoGroup> Groups { get; }

	// Methods

	// RVA: 0x7D811B4 Offset: 0x7D7D1B4 VA: 0x7D811B4
	public int get_AssetCount() { }

	// RVA: 0x7D812E4 Offset: 0x7D7D2E4 VA: 0x7D812E4
	public UnityResourceLoader CreateLoader() { }

	// RVA: 0x7D81544 Offset: 0x7D7D544 VA: 0x7D81544
	public List<AssetResource> CreateResourceWrappers() { }

	// RVA: 0x7D812C0 Offset: 0x7D7D2C0 VA: 0x7D812C0
	public IReadOnlyList<AssetResourceInfoGroup> get_Groups() { }

	// RVA: 0x7D81D48 Offset: 0x7D7DD48 VA: 0x7D81D48
	public AssetResourceInfo FindResourceInfo(AssetGuid guid) { }

	// RVA: 0x7D81AB8 Offset: 0x7D7DAB8 VA: 0x7D81AB8
	private void InitGroups() { }

	// RVA: 0x7D8213C Offset: 0x7D7E13C VA: 0x7D8213C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7D82144 Offset: 0x7D7E144 VA: 0x7D82144
	private AssetResourceInfoGroup <InitGroups>b__8_1(FieldInfo x) { }
}

// Namespace: Quantum
[Serializable]
public class AssetResourceInfo // TypeDefIndex: 23340
{
	// Fields
	public string Path; // 0x10
	public AssetRef AssetRef; // 0x18

	// Properties
	public AssetGuid Guid { get; set; }
	public bool IsNestedAsset { get; }

	// Methods

	// RVA: 0x7D825BC Offset: 0x7D7E5BC VA: 0x7D825BC
	public AssetGuid get_Guid() { }

	// RVA: 0x7D83638 Offset: 0x7D7F638 VA: 0x7D83638
	public void set_Guid(AssetGuid value) { }

	// RVA: 0x7D82CC8 Offset: 0x7D7ECC8 VA: 0x7D82CC8
	public bool get_IsNestedAsset() { }

	// RVA: 0x7D82260 Offset: 0x7D7E260 VA: 0x7D82260
	public void .ctor() { }
}

// Namespace: Quantum
public abstract class AssetResourceInfoGroup // TypeDefIndex: 23341
{
	// Properties
	public abstract IReadOnlyList<AssetResourceInfo> Resources { get; }
	public abstract int SortOrder { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IReadOnlyList<AssetResourceInfo> get_Resources();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_SortOrder();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract UnityResourceLoader.ILoader CreateLoader();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Add(AssetResourceInfo info);

	// RVA: 0x7D82054 Offset: 0x7D7E054 VA: 0x7D82054
	public AssetResourceInfo FindResourceInfo(AssetGuid guid) { }

	// RVA: 0x7D83640 Offset: 0x7D7F640 VA: 0x7D83640
	private static int BinarySearch(IReadOnlyList<AssetResourceInfo> list, AssetGuid guid) { }

	// RVA: 0x7D837C0 Offset: 0x7D7F7C0 VA: 0x7D837C0
	protected void .ctor() { }
}

// Namespace: Quantum
public abstract class AssetResourceInfoGroup<T> : AssetResourceInfoGroup // TypeDefIndex: 23342
{
	// Fields
	[SerializeField]
	private List<T> _resources; // 0x0

	// Properties
	public override IReadOnlyList<AssetResourceInfo> Resources { get; }
	public IReadOnlyList<T> ResourcesT { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override IReadOnlyList<AssetResourceInfo> get_Resources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54914A0 Offset: 0x548D4A0 VA: 0x54914A0
	|-AssetResourceInfoGroup<object>.get_Resources
	*/

	// RVA: -1 Offset: -1
	public IReadOnlyList<T> get_ResourcesT() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54914A8 Offset: 0x548D4A8 VA: 0x54914A8
	|-AssetResourceInfoGroup<object>.get_ResourcesT
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54914B0 Offset: 0x548D4B0 VA: 0x54914B0
	|-AssetResourceInfoGroup<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void Add(AssetResourceInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54914F0 Offset: 0x548D4F0 VA: 0x54914F0
	|-AssetResourceInfoGroup<object>.Add
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54915C8 Offset: 0x548D5C8 VA: 0x54915C8
	|-AssetResourceInfoGroup<object>..ctor
	*/
}

// Namespace: 
private sealed class UnityResourceLoader.UnityAssetResource : AssetResource // TypeDefIndex: 23343
{
	// Fields
	public AssetBase AssetWrapper; // 0x30
	public AssetResourceInfo ResourceInfo; // 0x38
	public bool IsBeingLoadedAsync; // 0x40
	public int LoaderIndex; // 0x44

	// Methods

	// RVA: 0x7D837C8 Offset: 0x7D7F7C8 VA: 0x7D837C8
	public void .ctor(AssetResourceInfo resourceInfo, int groupIndex) { }
}

// Namespace: 
public interface UnityResourceLoader.ILoader : IDisposable // TypeDefIndex: 23344
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LoadAsync(AssetResourceInfo resourceInfo);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AssetBase LoadSync(AssetResourceInfo resourceInfo);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Unload(AssetResourceInfo resourceInfo, AssetBase asset);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UpdateLoadAsync(Action<AssetResourceInfo, AssetBase> asyncLoadedCallback);
}

// Namespace: 
public abstract class UnityResourceLoader.LoaderBase<T, AsyncState> : UnityResourceLoader.ILoader, IDisposable // TypeDefIndex: 23345
{
	// Fields
	private List<ValueTuple<T, AsyncState>> _asyncRequests; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public virtual void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5004594 Offset: 0x5000594 VA: 0x5004594
	|-UnityResourceLoader.LoaderBase<object, AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x5004B54 Offset: 0x5000B54 VA: 0x5004B54
	|-UnityResourceLoader.LoaderBase<object, object>.Dispose
	|
	|-RVA: 0x5005088 Offset: 0x5001088 VA: 0x5005088
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void Quantum.UnityResourceLoader.ILoader.LoadAsync(AssetResourceInfo resourceInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5004598 Offset: 0x5000598 VA: 0x5004598
	|-UnityResourceLoader.LoaderBase<object, AsyncOperationHandle<object>>.Quantum.UnityResourceLoader.ILoader.LoadAsync
	|
	|-RVA: 0x5004B58 Offset: 0x5000B58 VA: 0x5004B58
	|-UnityResourceLoader.LoaderBase<object, object>.Quantum.UnityResourceLoader.ILoader.LoadAsync
	|
	|-RVA: 0x500508C Offset: 0x500108C VA: 0x500508C
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.Quantum.UnityResourceLoader.ILoader.LoadAsync
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private AssetBase Quantum.UnityResourceLoader.ILoader.LoadSync(AssetResourceInfo resourceInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5004738 Offset: 0x5000738 VA: 0x5004738
	|-UnityResourceLoader.LoaderBase<object, AsyncOperationHandle<object>>.Quantum.UnityResourceLoader.ILoader.LoadSync
	|
	|-RVA: 0x5004CBC Offset: 0x5000CBC VA: 0x5004CBC
	|-UnityResourceLoader.LoaderBase<object, object>.Quantum.UnityResourceLoader.ILoader.LoadSync
	|
	|-RVA: 0x50052C0 Offset: 0x50012C0 VA: 0x50052C0
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.Quantum.UnityResourceLoader.ILoader.LoadSync
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void Quantum.UnityResourceLoader.ILoader.Unload(AssetResourceInfo resourceInfo, AssetBase asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50047AC Offset: 0x50007AC VA: 0x50047AC
	|-UnityResourceLoader.LoaderBase<object, AsyncOperationHandle<object>>.Quantum.UnityResourceLoader.ILoader.Unload
	|
	|-RVA: 0x5004D30 Offset: 0x5000D30 VA: 0x5004D30
	|-UnityResourceLoader.LoaderBase<object, object>.Quantum.UnityResourceLoader.ILoader.Unload
	|
	|-RVA: 0x5005334 Offset: 0x5001334 VA: 0x5005334
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.Quantum.UnityResourceLoader.ILoader.Unload
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void Quantum.UnityResourceLoader.ILoader.UpdateLoadAsync(Action<AssetResourceInfo, AssetBase> asyncLoadedCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5004830 Offset: 0x5000830 VA: 0x5004830
	|-UnityResourceLoader.LoaderBase<object, AsyncOperationHandle<object>>.Quantum.UnityResourceLoader.ILoader.UpdateLoadAsync
	|
	|-RVA: 0x5004DB4 Offset: 0x5000DB4 VA: 0x5004DB4
	|-UnityResourceLoader.LoaderBase<object, object>.Quantum.UnityResourceLoader.ILoader.UpdateLoadAsync
	|
	|-RVA: 0x50053B8 Offset: 0x50013B8 VA: 0x50053B8
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.Quantum.UnityResourceLoader.ILoader.UpdateLoadAsync
	*/

	// RVA: -1 Offset: -1
	protected static AssetBase FindAsset(Object[] assets, AssetGuid subAssetGuid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x500495C Offset: 0x500095C VA: 0x500495C
	|-UnityResourceLoader.LoaderBase<object, AsyncOperationHandle<object>>.FindAsset
	|
	|-RVA: 0x5004E90 Offset: 0x5000E90 VA: 0x5004E90
	|-UnityResourceLoader.LoaderBase<object, object>.FindAsset
	|
	|-RVA: 0x500566C Offset: 0x500166C VA: 0x500566C
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.FindAsset
	*/

	// RVA: -1 Offset: -1
	protected static AssetBase FindAsset(AssetBase[] assets, AssetGuid subAssetGuid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5004A4C Offset: 0x5000A4C VA: 0x5004A4C
	|-UnityResourceLoader.LoaderBase<object, AsyncOperationHandle<object>>.FindAsset
	|
	|-RVA: 0x5004F80 Offset: 0x5000F80 VA: 0x5004F80
	|-UnityResourceLoader.LoaderBase<object, object>.FindAsset
	|
	|-RVA: 0x500575C Offset: 0x500175C VA: 0x500575C
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.FindAsset
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract AssetBase GetAssetFromAsyncState(T resourceInfo, AsyncState asyncState);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.GetAssetFromAsyncState
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract bool IsDone(AsyncState asyncState);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.IsDone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract AsyncState LoadAsync(T info);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.LoadAsync
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract AssetBase LoadSync(T info);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.LoadSync
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual void Unload(T info, AssetBase asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5004AE0 Offset: 0x5000AE0 VA: 0x5004AE0
	|-UnityResourceLoader.LoaderBase<object, AsyncOperationHandle<object>>.Unload
	|
	|-RVA: 0x5005014 Offset: 0x5001014 VA: 0x5005014
	|-UnityResourceLoader.LoaderBase<object, object>.Unload
	|
	|-RVA: 0x50057F0 Offset: 0x50017F0 VA: 0x50057F0
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>.Unload
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5004AE4 Offset: 0x5000AE4 VA: 0x5004AE4
	|-UnityResourceLoader.LoaderBase<object, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x5005018 Offset: 0x5001018 VA: 0x5005018
	|-UnityResourceLoader.LoaderBase<object, object>..ctor
	|
	|-RVA: 0x50057F4 Offset: 0x50017F4 VA: 0x50057F4
	|-UnityResourceLoader.LoaderBase<object, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Quantum
public sealed class UnityResourceLoader : IResourceLoader, IDisposable // TypeDefIndex: 23346
{
	// Fields
	private readonly UnityResourceLoader.ILoader[] _loaders; // 0x10
	private Dictionary<AssetGuid, UnityResourceLoader.UnityAssetResource> _inProgress; // 0x18
	private Action<AssetResourceInfo, AssetBase> _loadedAsync; // 0x20
	[CompilerGenerated]
	private ResourceLoaded LoadCompleted; // 0x28
	[CompilerGenerated]
	private ResourceLoadFailed LoadFailed; // 0x30

	// Methods

	// RVA: 0x7D81A50 Offset: 0x7D7DA50 VA: 0x7D81A50
	public static AssetResource CreateAssetResource(AssetResourceInfo resouceInfo, int loaderIndex) { }

	// RVA: 0x7D83824 Offset: 0x7D7F824 VA: 0x7D83824
	public static AssetBase GetWrapperFromResource(AssetResource resource) { }

	// RVA: 0x7D8144C Offset: 0x7D7D44C VA: 0x7D8144C
	public void .ctor(UnityResourceLoader.ILoader[] loaders) { }

	[CompilerGenerated]
	// RVA: 0x7D83888 Offset: 0x7D7F888 VA: 0x7D83888 Slot: 4
	public void add_LoadCompleted(ResourceLoaded value) { }

	[CompilerGenerated]
	// RVA: 0x7D83924 Offset: 0x7D7F924 VA: 0x7D83924 Slot: 5
	public void remove_LoadCompleted(ResourceLoaded value) { }

	[CompilerGenerated]
	// RVA: 0x7D839C0 Offset: 0x7D7F9C0 VA: 0x7D839C0 Slot: 6
	public void add_LoadFailed(ResourceLoadFailed value) { }

	[CompilerGenerated]
	// RVA: 0x7D83A5C Offset: 0x7D7FA5C VA: 0x7D83A5C Slot: 7
	public void remove_LoadFailed(ResourceLoadFailed value) { }

	// RVA: 0x7D83AF8 Offset: 0x7D7FAF8 VA: 0x7D83AF8 Slot: 11
	public void Dispose() { }

	// RVA: 0x7D83BDC Offset: 0x7D7FBDC VA: 0x7D83BDC Slot: 10
	private void Quantum.IResourceLoader.DisposeResource(AssetResource resource) { }

	// RVA: 0x7D83D18 Offset: 0x7D7FD18 VA: 0x7D83D18 Slot: 9
	private void Quantum.IResourceLoader.LoadResource(AssetResource resource) { }

	// RVA: 0x7D84120 Offset: 0x7D80120 VA: 0x7D84120 Slot: 8
	private void Quantum.IResourceLoader.LoadResourceAsync(AssetResource resource) { }

	// RVA: 0x7D84300 Offset: 0x7D80300 VA: 0x7D84300
	public void Update() { }

	// RVA: 0x7D840F4 Offset: 0x7D800F4 VA: 0x7D840F4
	private void FinishLoading(UnityResourceLoader.UnityAssetResource resource, Exception error) { }

	// RVA: 0x7D83F0C Offset: 0x7D7FF0C VA: 0x7D83F0C
	private void FinishLoading(UnityResourceLoader.UnityAssetResource resource, AssetBase asset) { }

	// RVA: 0x7D83CE0 Offset: 0x7D7FCE0 VA: 0x7D83CE0
	private UnityResourceLoader.ILoader GetLoaderForResource(UnityResourceLoader.UnityAssetResource resource) { }

	[CompilerGenerated]
	// RVA: 0x7D843F8 Offset: 0x7D803F8 VA: 0x7D843F8
	private void <.ctor>b__6_0(AssetResourceInfo resourceInfo, AssetBase asset) { }
}

// Namespace: Quantum
public abstract class PrototypeAdapter // TypeDefIndex: 23347
{
	// Properties
	public abstract Type PrototypedType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_PrototypedType();

	// RVA: 0x7D844C8 Offset: 0x7D804C8 VA: 0x7D844C8
	protected void .ctor() { }
}

// Namespace: Quantum
public abstract class PrototypeAdapter<PrototypeType> : PrototypeAdapter // TypeDefIndex: 23348
{
	// Properties
	public sealed override Type PrototypedType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public sealed override Type get_PrototypedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E428 Offset: 0x529A428 VA: 0x529E428
	|-PrototypeAdapter<object>.get_PrototypedType
	|
	|-RVA: 0x529E494 Offset: 0x529A494 VA: 0x529E494
	|-PrototypeAdapter<__Il2CppFullySharedGenericType>.get_PrototypedType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract PrototypeType Convert(EntityPrototypeConverter converter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PrototypeAdapter<__Il2CppFullySharedGenericType>.Convert
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E48C Offset: 0x529A48C VA: 0x529E48C
	|-PrototypeAdapter<object>..ctor
	|
	|-RVA: 0x529E4F8 Offset: 0x529A4F8 VA: 0x529E4F8
	|-PrototypeAdapter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Quantum
[Usage(256)]
[Obsolete("Use Quantum.Inspector.EnumFlagsAttribute instead")]
public class EnumFlagsAttribute : PropertyAttribute // TypeDefIndex: 23349
{
	// Fields
	[CompilerGenerated]
	private string <tooltip>k__BackingField; // 0x10

	// Properties
	public string tooltip { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D844D0 Offset: 0x7D804D0 VA: 0x7D844D0
	public string get_tooltip() { }

	[CompilerGenerated]
	// RVA: 0x7D844D8 Offset: 0x7D804D8 VA: 0x7D844D8
	public void set_tooltip(string value) { }

	// RVA: 0x7D844E0 Offset: 0x7D804E0 VA: 0x7D844E0
	public void .ctor() { }
}

// Namespace: Quantum
[Usage(256)]
public class InspectorButtonAttribute : PropertyAttribute // TypeDefIndex: 23350
{
	// Fields
	public string Method; // 0x10
	public string Label; // 0x18
	public bool IsToggleable; // 0x20

	// Methods

	// RVA: 0x7D84538 Offset: 0x7D80538 VA: 0x7D84538
	public void .ctor(string method) { }

	// RVA: 0x7D84578 Offset: 0x7D80578 VA: 0x7D84578
	public void .ctor(string method, string label) { }

	// RVA: 0x7D845BC Offset: 0x7D805BC VA: 0x7D845BC
	public void .ctor(string method, bool isToggleable) { }

	// RVA: 0x7D845F8 Offset: 0x7D805F8 VA: 0x7D845F8
	public void .ctor(string method, string label, bool isToggleable) { }
}

// Namespace: Quantum
[Usage(256)]
public class LocalReferenceAttribute : PropertyAttribute // TypeDefIndex: 23351
{
	// Methods

	// RVA: 0x7D84650 Offset: 0x7D80650 VA: 0x7D84650
	public void .ctor() { }
}

// Namespace: Quantum
[Usage(256)]
public class MultiTypeReferenceAttribute : PropertyAttribute // TypeDefIndex: 23352
{
	// Fields
	public readonly Type[] Types; // 0x10

	// Methods

	// RVA: 0x7D84658 Offset: 0x7D80658 VA: 0x7D84658
	public void .ctor(Type[] types) { }
}

// Namespace: Quantum
[Usage(256)]
public class QuantumInspectorAttribute : PropertyAttribute // TypeDefIndex: 23353
{
	// Methods

	// RVA: 0x7D84688 Offset: 0x7D80688 VA: 0x7D84688
	public void .ctor() { }
}

// Namespace: Quantum
public abstract class QuantumPropertyAttributeProxyAttribute : PropertyAttribute // TypeDefIndex: 23354
{
	// Fields
	[CompilerGenerated]
	private readonly PropertyAttribute <Attribute>k__BackingField; // 0x10

	// Properties
	public PropertyAttribute Attribute { get; }

	// Methods

	// RVA: 0x7D84690 Offset: 0x7D80690 VA: 0x7D84690
	public void .ctor(PropertyAttribute attribute) { }

	[CompilerGenerated]
	// RVA: 0x7D846C0 Offset: 0x7D806C0 VA: 0x7D846C0
	public PropertyAttribute get_Attribute() { }
}

// Namespace: Quantum
public class EntityPrototypeConverter // TypeDefIndex: 23355
{
	// Fields
	public readonly EntityPrototype[] OrderedMapPrototypes; // 0x10
	public readonly EntityPrototype AssetPrototype; // 0x18
	public readonly MapData Map; // 0x20

	// Methods

	// RVA: 0x7D846C8 Offset: 0x7D806C8 VA: 0x7D846C8
	public void .ctor(MapData map, EntityPrototype[] orderedMapPrototypes) { }

	// RVA: 0x7D8470C Offset: 0x7D8070C VA: 0x7D8470C
	public void .ctor(EntityPrototype prototypeAsset) { }

	// RVA: 0x7D8473C Offset: 0x7D8073C VA: 0x7D8473C
	public void Convert(EntityPrototype prototype, out MapEntityId result) { }

	// RVA: 0x7D84828 Offset: 0x7D80828 VA: 0x7D84828
	public void Convert(EntityPrototypeRefWrapper prototype, out EntityPrototypeRef result) { }

	// RVA: 0x7D84964 Offset: 0x7D80964 VA: 0x7D84964
	public void Convert(ComponentPrototypeRefWrapperBase prototype, out ComponentPrototypeRef_Prototype result) { }
}

// Namespace: 
public struct MapNavMeshBaker.TriangleCenterGrid.Pair // TypeDefIndex: 23356
{
	// Fields
	public int Triangle; // 0x0
	public FP Heuristic; // 0x8
}

// Namespace: 
private struct MapNavMeshBaker.TriangleCenterGrid // TypeDefIndex: 23357
{
	// Fields
	public List<MapNavMeshBaker.TriangleCenterGrid.Pair> Regions; // 0x0
}

// Namespace: 
public struct MapNavMeshBaker.Vector3Double // TypeDefIndex: 23358
{
	// Fields
	public double X; // 0x0
	public double Y; // 0x8
	public double Z; // 0x10

	// Methods

	// RVA: 0x7D8A864 Offset: 0x7D86864 VA: 0x7D8A864
	public void .ctor(double x, double y, double z) { }

	// RVA: 0x7D8A870 Offset: 0x7D86870 VA: 0x7D8A870
	public void .ctor(FPVector3 v) { }

	// RVA: 0x7D8A8AC Offset: 0x7D868AC VA: 0x7D8A8AC
	public void .ctor(Vector3 v) { }

	// RVA: 0x7D8A8C4 Offset: 0x7D868C4 VA: 0x7D8A8C4
	public static MapNavMeshBaker.Vector3Double op_Subtraction(MapNavMeshBaker.Vector3Double a, MapNavMeshBaker.Vector3Double b) { }

	// RVA: 0x7D8A8D4 Offset: 0x7D868D4 VA: 0x7D8A8D4
	public static MapNavMeshBaker.Vector3Double op_Addition(MapNavMeshBaker.Vector3Double a, MapNavMeshBaker.Vector3Double b) { }

	// RVA: 0x7D8A8E4 Offset: 0x7D868E4 VA: 0x7D8A8E4
	public static MapNavMeshBaker.Vector3Double op_Multiply(MapNavMeshBaker.Vector3Double a, double b) { }

	// RVA: 0x7D8A8F4 Offset: 0x7D868F4 VA: 0x7D8A8F4
	public static MapNavMeshBaker.Vector3Double op_Multiply(double b, MapNavMeshBaker.Vector3Double a) { }

	// RVA: 0x7D8A908 Offset: 0x7D86908 VA: 0x7D8A908
	public FPVector3 AsFPVector() { }

	// RVA: 0x7D8A980 Offset: 0x7D86980 VA: 0x7D8A980
	public double SqrMagnitude() { }

	// RVA: 0x7D8A9A0 Offset: 0x7D869A0 VA: 0x7D8A9A0
	public void Normalize() { }

	// RVA: 0x7D8AA8C Offset: 0x7D86A8C VA: 0x7D8AA8C Slot: 3
	public override string ToString() { }

	// RVA: 0x7D8AB50 Offset: 0x7D86B50 VA: 0x7D8AB50
	public static double Dot(MapNavMeshBaker.Vector3Double a, MapNavMeshBaker.Vector3Double b) { }

	// RVA: 0x7D8AB68 Offset: 0x7D86B68 VA: 0x7D8AB68
	public static MapNavMeshBaker.Vector3Double Cross(MapNavMeshBaker.Vector3Double a, MapNavMeshBaker.Vector3Double b) { }

	// RVA: 0x7D8AB90 Offset: 0x7D86B90 VA: 0x7D8AB90
	public static double ClosestDistanceToTriangle(MapNavMeshBaker.Vector3Double p, MapNavMeshBaker.Vector3Double v0, MapNavMeshBaker.Vector3Double v1, MapNavMeshBaker.Vector3Double v2, ref MapNavMeshBaker.Vector3Double closestPoint) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MapNavMeshBaker.<>c // TypeDefIndex: 23359
{
	// Fields
	public static readonly MapNavMeshBaker.<>c <>9; // 0x0
	public static Comparison<MapNavMeshBaker.TriangleCenterGrid.Pair> <>9__15_0; // 0x8

	// Methods

	// RVA: 0x7D8AE14 Offset: 0x7D86E14 VA: 0x7D8AE14
	private static void .cctor() { }

	// RVA: 0x7D8AE7C Offset: 0x7D86E7C VA: 0x7D8AE7C
	public void .ctor() { }

	// RVA: 0x7D8AE84 Offset: 0x7D86E84 VA: 0x7D8AE84
	internal int <GenerateTriangleCenterGrid>b__15_0(MapNavMeshBaker.TriangleCenterGrid.Pair a, MapNavMeshBaker.TriangleCenterGrid.Pair b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapNavMeshBaker.<>c__DisplayClass18_0 // TypeDefIndex: 23360
{
	// Fields
	public MapNavMeshLink link; // 0x10

	// Methods

	// RVA: 0x7D8AEB0 Offset: 0x7D86EB0 VA: 0x7D8AEB0
	public void .ctor() { }

	// RVA: 0x7D8AEB8 Offset: 0x7D86EB8 VA: 0x7D8AEB8
	internal bool <GenerateNavMeshLinks>b__0(string r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapNavMeshBaker.<>c__DisplayClass4_0 // TypeDefIndex: 23361
{
	// Fields
	public List<string> regions; // 0x10
	public ProgressBar progressBar; // 0x18

	// Methods

	// RVA: 0x7D8AECC Offset: 0x7D86ECC VA: 0x7D8AECC
	public void .ctor() { }

	// RVA: 0x7D8AED4 Offset: 0x7D86ED4 VA: 0x7D8AED4
	internal void <BakeNavMesh>b__0(float p) { }

	// RVA: 0x7D8AF28 Offset: 0x7D86F28 VA: 0x7D8AF28
	internal void <BakeNavMesh>b__1(float p) { }

	// RVA: 0x7D8AF5C Offset: 0x7D86F5C VA: 0x7D8AF5C
	internal void <BakeNavMesh>b__2(float p) { }

	// RVA: 0x7D8AF90 Offset: 0x7D86F90 VA: 0x7D8AF90
	internal void <BakeNavMesh>b__3(float p) { }

	// RVA: 0x7D8AFC4 Offset: 0x7D86FC4 VA: 0x7D8AFC4
	internal void <BakeNavMesh>b__4(float p) { }

	// RVA: 0x7D8AFF8 Offset: 0x7D86FF8 VA: 0x7D8AFF8
	internal void <BakeNavMesh>b__5(float p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapNavMeshBaker.<>c__DisplayClass4_1 // TypeDefIndex: 23362
{
	// Fields
	public int i; // 0x10
	public MapNavMeshBaker.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x7D8B02C Offset: 0x7D8702C VA: 0x7D8B02C
	public void .ctor() { }

	// RVA: 0x7D8B034 Offset: 0x7D87034 VA: 0x7D8B034
	internal bool <BakeNavMesh>b__6(string r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapNavMeshBaker.<>c__DisplayClass4_2 // TypeDefIndex: 23363
{
	// Fields
	public MapNavMeshTriangle t; // 0x10

	// Methods

	// RVA: 0x7D8B0A4 Offset: 0x7D870A4 VA: 0x7D8B0A4
	public void .ctor() { }

	// RVA: 0x7D8B0AC Offset: 0x7D870AC VA: 0x7D8B0AC
	internal bool <BakeNavMesh>b__7(MapNavMeshVertex x) { }

	// RVA: 0x7D8B0DC Offset: 0x7D870DC VA: 0x7D8B0DC
	internal bool <BakeNavMesh>b__8(MapNavMeshVertex x) { }

	// RVA: 0x7D8B110 Offset: 0x7D87110 VA: 0x7D8B110
	internal bool <BakeNavMesh>b__9(MapNavMeshVertex x) { }

	// RVA: 0x7D8B144 Offset: 0x7D87144 VA: 0x7D8B144
	internal bool <BakeNavMesh>b__10(string r) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MapNavMeshBaker.<>c__DisplayClass7_0 // TypeDefIndex: 23364
{
	// Fields
	public NavMeshBorder border; // 0x10

	// Methods

	// RVA: 0x7D8B158 Offset: 0x7D87158 VA: 0x7D8B158
	public void .ctor() { }

	// RVA: 0x7D8B160 Offset: 0x7D87160 VA: 0x7D8B160
	internal bool <ProcessBorder>b__0(NavMeshBorder b) { }
}

// Namespace: Quantum
public static class MapNavMeshBaker // TypeDefIndex: 23365
{
	// Fields
	private static FP TriangleCheckEpsilon; // 0x0
	private static readonly int MaxCandidates; // 0x8
	private static List<MapNavMeshBaker.TriangleCenterGrid.Pair> Candidates; // 0x10

	// Methods

	// RVA: 0x7D84B28 Offset: 0x7D80B28 VA: 0x7D84B28
	public static NavMesh BakeNavMesh(MapData data, MapNavMesh.BakeData navmeshBakeData) { }

	// RVA: 0x7D84B98 Offset: 0x7D80B98 VA: 0x7D84B98
	public static NavMesh BakeNavMesh(Map map, MapNavMesh.BakeData navmeshBakeData) { }

	// RVA: 0x7D863CC Offset: 0x7D823CC VA: 0x7D863CC
	private static NavMeshTriangleNode[] GenerateTriangleGrid(NavMesh navmesh, Action<float> reporter) { }

	// RVA: 0x7D86E00 Offset: 0x7D82E00 VA: 0x7D86E00
	private static List<NavMeshBorder> GenerateBorders(NavMesh navmesh, Action<float> reporter) { }

	// RVA: 0x7D88F98 Offset: 0x7D84F98 VA: 0x7D88F98
	private static void ProcessBorder(NavMesh navmesh, int t, int v0, int v1, List<NavMeshBorder> borders) { }

	// RVA: 0x7D895E0 Offset: 0x7D855E0 VA: 0x7D895E0
	private static bool IsBorderEdge(NavMeshTriangle[] triangles, int tri, int v0, int v1, out NavMeshRegionMask otherRegion, NavMeshVertex[] vertices) { }

	// RVA: 0x7D898D4 Offset: 0x7D858D4 VA: 0x7D898D4
	private static int FindBorderTriangle(NavMeshTriangle[] triangles, int tri, int v0, int v1) { }

	// RVA: 0x7D89720 Offset: 0x7D85720 VA: 0x7D89720
	private static bool TriangleContains(NavMeshTriangle[] ts, NavMeshVertex[] vs, FPVector3 point, NavMeshRegionMask regions) { }

	// RVA: 0x7D86F6C Offset: 0x7D82F6C VA: 0x7D86F6C
	private static NavMeshBorderNode[] GenerateBorderGrid(NavMesh navmesh, Action<float> reporter) { }

	// RVA: 0x7D8997C Offset: 0x7D8597C VA: 0x7D8997C
	private static FP CalculateCellTriangleHeuristic(FPVector3 cellCenter, FP cellSize, NavMesh navmesh, int triangle) { }

	// RVA: 0x7D89C8C Offset: 0x7D85C8C VA: 0x7D89C8C
	private static void CalculateCellTriangleHeuristic(NavMesh navmesh, int triangleIndex, FPVector3 cellCenter, int regionIndex) { }

	// RVA: 0x7D8A04C Offset: 0x7D8604C VA: 0x7D8A04C
	private static bool FindClosestTriangle(NavMesh navmesh, int cellIndex, FPVector3 cellCenter, int regionIndex, MapNavMesh.FindClosestTriangleCalculation triangleCalc, int triangleCalcDepth, ref MapNavMeshBaker.TriangleCenterGrid.Pair heuristic) { }

	// RVA: 0x7D877E0 Offset: 0x7D837E0 VA: 0x7D877E0
	private static NavMeshTriangleCenterGridNode[] GenerateTriangleCenterGrid(NavMesh navmesh, MapNavMesh.FindClosestTriangleCalculation triangleCalc, int triangleCalcDepth, List<string> regionsList, Action<float> reporter) { }

	// RVA: 0x7D874A4 Offset: 0x7D834A4 VA: 0x7D874A4
	private static void GenerateTriangleNeighbors(NavMesh navmesh, Action<float> reporter) { }

	// RVA: 0x7D88D4C Offset: 0x7D84D4C VA: 0x7D88D4C
	public static bool LocateGridCells(ref int xMin, ref int xMax, ref int yMin, ref int yMax, FPVector2 worldOffset, int gridNodeSize, int gridSizeX, int gridSizeY, FPVector2[] positions) { }

	// RVA: 0x7D87FA0 Offset: 0x7D83FA0 VA: 0x7D87FA0
	private static void GenerateNavMeshLinks(NavMesh navmesh, MapNavMeshLink[] links, string[] regions, bool errorCorrection, bool enableQuantumXY, Action<float> reporter) { }

	// RVA: 0x7D8A7B0 Offset: 0x7D867B0 VA: 0x7D8A7B0
	private static void .cctor() { }
}

// Namespace: Quantum
public class QuantumUnityJsonSerializer : JsonAssetSerializerBase // TypeDefIndex: 23366
{
	// Methods

	// RVA: 0x7D8B290 Offset: 0x7D87290 VA: 0x7D8B290 Slot: 7
	protected override object FromJson(string json, Type type) { }

	// RVA: 0x7D8B2A0 Offset: 0x7D872A0 VA: 0x7D8B2A0 Slot: 8
	protected override string ToJson(object obj) { }

	// RVA: 0x7D8B2B4 Offset: 0x7D872B4 VA: 0x7D8B2B4
	public void .ctor() { }
}

// Namespace: Quantum
public static class DebugDraw // TypeDefIndex: 23367
{
	// Fields
	private static Queue<Draw.DebugRay> _rays; // 0x0
	private static Queue<Draw.DebugLine> _lines; // 0x8
	private static Queue<Draw.DebugCircle> _circles; // 0x10
	private static Queue<Draw.DebugSphere> _spheres; // 0x18
	private static Queue<Draw.DebugRectangle> _rectangles; // 0x20
	private static Queue<Draw.DebugBox> _boxes; // 0x28
	private static Dictionary<ColorRGBA, Material> _materials; // 0x30
	private static Draw.DebugRay[] _raysArray; // 0x38
	private static Draw.DebugLine[] _linesArray; // 0x40
	private static Draw.DebugCircle[] _circlesArray; // 0x48
	private static Draw.DebugSphere[] _spheresArray; // 0x50
	private static Draw.DebugRectangle[] _rectanglesArray; // 0x58
	private static Draw.DebugBox[] _boxesArray; // 0x60
	private static int _raysCount; // 0x68
	private static int _linesCount; // 0x6C
	private static int _circlesCount; // 0x70
	private static int _spheresCount; // 0x74
	private static int _rectanglesCount; // 0x78
	private static int _boxesCount; // 0x7C
	private static Mesh _solidSphere; // 0x80

	// Methods

	// RVA: 0x7D8B2BC Offset: 0x7D872BC VA: 0x7D8B2BC
	public static void Ray(Draw.DebugRay ray) { }

	// RVA: 0x7D8B450 Offset: 0x7D87450 VA: 0x7D8B450
	public static void Line(Draw.DebugLine line) { }

	// RVA: 0x7D8B5E4 Offset: 0x7D875E4 VA: 0x7D8B5E4
	public static void Circle(Draw.DebugCircle circle) { }

	// RVA: 0x7D8B768 Offset: 0x7D87768 VA: 0x7D8B768
	public static void Sphere(Draw.DebugSphere sphere) { }

	// RVA: 0x7D8B8EC Offset: 0x7D878EC VA: 0x7D8B8EC
	public static void Rectangle(Draw.DebugRectangle rectangle) { }

	// RVA: 0x7D8BA80 Offset: 0x7D87A80 VA: 0x7D8BA80
	public static void Box(Draw.DebugBox box) { }

	// RVA: 0x7D8BC0C Offset: 0x7D87C0C VA: 0x7D8BC0C
	public static Material GetMaterial(ColorRGBA color) { }

	// RVA: 0x7D8BEB0 Offset: 0x7D87EB0 VA: 0x7D8BEB0
	public static void Clear() { }

	// RVA: 0x7D8C020 Offset: 0x7D88020 VA: 0x7D8C020
	public static void TakeAll() { }

	// RVA: 0x7D8C1A0 Offset: 0x7D881A0 VA: 0x7D8C1A0
	public static void DrawAll() { }

	// RVA: 0x7D8C51C Offset: 0x7D8851C VA: 0x7D8C51C
	private static void DrawRay(Draw.DebugRay ray) { }

	// RVA: 0x7D8C670 Offset: 0x7D88670 VA: 0x7D8C670
	private static void DrawLine(Draw.DebugLine line) { }

	// RVA: 0x7D8D634 Offset: 0x7D89634 VA: 0x7D8D634
	private static Mesh GetSphere() { }

	// RVA: 0x7D8C9E8 Offset: 0x7D889E8 VA: 0x7D8C9E8
	private static void DrawSphere(Draw.DebugSphere sphere) { }

	// RVA: 0x7D8C7C4 Offset: 0x7D887C4 VA: 0x7D8C7C4
	private static void DrawCircle(Draw.DebugCircle circle) { }

	// RVA: 0x7D8CC14 Offset: 0x7D88C14 VA: 0x7D8CC14
	private static void DrawRectangle(Draw.DebugRectangle rectangle) { }

	// RVA: 0x7D8D050 Offset: 0x7D89050 VA: 0x7D8D050
	private static void DrawBox(Draw.DebugBox box) { }

	// RVA: -1 Offset: -1
	private static int TakeAllFromQueueAndClearLocked<T>(Queue<T> queue, ref T[] result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456BA04 Offset: 0x4567A04 VA: 0x456BA04
	|-DebugDraw.TakeAllFromQueueAndClearLocked<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x456BCE8 Offset: 0x4567CE8 VA: 0x456BCE8
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugBox>
	|
	|-RVA: 0x456BF00 Offset: 0x4567F00 VA: 0x456BF00
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugCircle>
	|
	|-RVA: 0x456C118 Offset: 0x4568118 VA: 0x456C118
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugLine>
	|
	|-RVA: 0x456C354 Offset: 0x4568354 VA: 0x456C354
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugRay>
	|
	|-RVA: 0x456C590 Offset: 0x4568590 VA: 0x456C590
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugRectangle>
	|
	|-RVA: 0x456C7CC Offset: 0x45687CC VA: 0x456C7CC
	|-DebugDraw.TakeAllFromQueueAndClearLocked<Draw.DebugSphere>
	*/

	// RVA: 0x7D8D9F8 Offset: 0x7D899F8 VA: 0x7D8D9F8
	private static void .cctor() { }
}

// Namespace: Quantum
public static class DebugMesh // TypeDefIndex: 23368
{
	// Fields
	private static Mesh _circleMesh; // 0x0
	private static Mesh _quadMesh; // 0x8
	private static Mesh _cylinderMesh; // 0x10
	private static Mesh _cubeMesh; // 0x18
	private static Material _debugMaterial; // 0x20

	// Properties
	public static Mesh CircleMesh { get; }
	public static Mesh QuadMesh { get; }
	public static Mesh CubeMesh { get; }
	public static Mesh CylinderMesh { get; }
	public static Material DebugMaterial { get; }

	// Methods

	// RVA: 0x7D8D778 Offset: 0x7D89778 VA: 0x7D8D778
	public static Mesh get_CircleMesh() { }

	// RVA: 0x7D8D850 Offset: 0x7D89850 VA: 0x7D8D850
	public static Mesh get_QuadMesh() { }

	// RVA: 0x7D8D924 Offset: 0x7D89924 VA: 0x7D8D924
	public static Mesh get_CubeMesh() { }

	// RVA: 0x7D8DE0C Offset: 0x7D89E0C VA: 0x7D8DE0C
	public static Mesh get_CylinderMesh() { }

	// RVA: 0x7D8BDDC Offset: 0x7D87DDC VA: 0x7D8BDDC
	public static Material get_DebugMaterial() { }
}

// Namespace: Quantum
public static class EditorDefines // TypeDefIndex: 23369
{
	// Fields
	public const int AssetMenuPriority = -1000;
	public const int AssetMenuPriorityConfigurations = -999;
	public const int AssetMenuPriorityDemo = -998;
	public const int AssetMenuPriorityStart = -900;
}

// Namespace: Quantum
[Serializable]
public struct FloatMinMax // TypeDefIndex: 23370
{
	// Fields
	public float Min; // 0x0
	public float Max; // 0x4

	// Methods

	// RVA: 0x7D8DEE0 Offset: 0x7D89EE0 VA: 0x7D8DEE0
	public void .ctor(float min, float max) { }
}

// Namespace: Quantum
[Usage(256, Inherited = True, AllowMultiple = False)]
public class MinMaxSliderAttribute : PropertyAttribute // TypeDefIndex: 23371
{
	// Fields
	public readonly float Min; // 0x10
	public readonly float Max; // 0x14

	// Methods

	// RVA: 0x7D8DEE8 Offset: 0x7D89EE8 VA: 0x7D8DEE8
	public void .ctor() { }

	// RVA: 0x7D8DF0C Offset: 0x7D89F0C VA: 0x7D8DF0C
	public void .ctor(float min, float max) { }
}

// Namespace: Quantum
[Extension]
public static class GameObjectUtils // TypeDefIndex: 23372
{
	// Methods

	[Extension]
	// RVA: 0x7D8DF38 Offset: 0x7D89F38 VA: 0x7D8DF38
	public static void Show(GameObject[] gameObjects) { }

	[Extension]
	// RVA: 0x7D8DF9C Offset: 0x7D89F9C VA: 0x7D8DF9C
	public static void Hide(GameObject[] gameObjects) { }

	[Extension]
	// RVA: 0x7D8E000 Offset: 0x7D8A000 VA: 0x7D8E000
	public static void Show(GameObject gameObject) { }

	[Extension]
	// RVA: 0x7D8E090 Offset: 0x7D8A090 VA: 0x7D8E090
	public static void Hide(GameObject gameObject) { }

	[Extension]
	// RVA: 0x7D8E120 Offset: 0x7D8A120 VA: 0x7D8E120
	public static bool Toggle(GameObject gameObject) { }

	[Extension]
	// RVA: 0x7D8E1B0 Offset: 0x7D8A1B0 VA: 0x7D8E1B0
	public static bool Toggle(GameObject gameObject, bool state) { }

	[Extension]
	// RVA: 0x7D8E258 Offset: 0x7D8A258 VA: 0x7D8E258
	public static bool Toggle(Component component, bool state) { }

	[Extension]
	// RVA: 0x7D8E2F0 Offset: 0x7D8A2F0 VA: 0x7D8E2F0
	public static void Show(Component component) { }

	[Extension]
	// RVA: 0x7D8E370 Offset: 0x7D8A370 VA: 0x7D8E370
	public static void Show(Image component, Sprite sprite) { }

	[Extension]
	// RVA: 0x7D8E41C Offset: 0x7D8A41C VA: 0x7D8E41C
	public static void Hide(Component component) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void Show<T>(T[] gameObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4630DE8 Offset: 0x462CDE8 VA: 0x4630DE8
	|-GameObjectUtils.Show<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Hide<T>(T[] gameObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4630D4C Offset: 0x462CD4C VA: 0x4630D4C
	|-GameObjectUtils.Hide<object>
	*/
}

// Namespace: 
public enum GizmoUtils.GizmosJointParams.GizmosJointType // TypeDefIndex: 23373
{
	// Fields
	public int value__; // 0x0
	public const GizmoUtils.GizmosJointParams.GizmosJointType None = 0;
	public const GizmoUtils.GizmosJointParams.GizmosJointType DistanceJoint2D = 1;
	public const GizmoUtils.GizmosJointParams.GizmosJointType DistanceJoint3D = 2;
	public const GizmoUtils.GizmosJointParams.GizmosJointType SpringJoint2D = 3;
	public const GizmoUtils.GizmosJointParams.GizmosJointType SpringJoint3D = 4;
	public const GizmoUtils.GizmosJointParams.GizmosJointType HingeJoint2D = 5;
	public const GizmoUtils.GizmosJointParams.GizmosJointType HingeJoint3D = 6;
}

// Namespace: 
private struct GizmoUtils.GizmosJointParams // TypeDefIndex: 23374
{
	// Fields
	public GizmoUtils.GizmosJointParams.GizmosJointType Type; // 0x0
	public bool Selected; // 0x4
	public Vector3 AnchorPos; // 0x8
	public Vector3 ConnectedPos; // 0x14
	public Quaternion JointRot; // 0x20
	public Quaternion ConnectedRot; // 0x30
	public Quaternion RelRotRef; // 0x40
	public float MinDistance; // 0x50
	public float MaxDistance; // 0x54
	public Vector3 Axis; // 0x58
	public bool UseAngleLimits; // 0x64
	public float LowerAngle; // 0x68
	public float UpperAngle; // 0x6C
}

// Namespace: Quantum
[Extension]
public static class GizmoUtils // TypeDefIndex: 23375
{
	// Fields
	public const float DefaultArrowHeadLength = 0.25;
	public const float DefaultArrowHeadAngle = 25;

	// Methods

	[Extension]
	// RVA: 0x7D8E49C Offset: 0x7D8A49C VA: 0x7D8E49C
	public static Color Alpha(Color color, float a) { }

	[Extension]
	// RVA: 0x7D8E4A4 Offset: 0x7D8A4A4 VA: 0x7D8E4A4
	public static Color Brightness(Color color, float brightness) { }

	// RVA: 0x7D8E4FC Offset: 0x7D8A4FC VA: 0x7D8E4FC
	public static void DrawGizmosBox(Transform transform, Vector3 size, Color color, Vector3 offset, bool selected = False, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E500 Offset: 0x7D8A500 VA: 0x7D8E500
	public static void DrawGizmosBox(Vector3 center, Vector3 size, Color color, bool selected = False, Nullable<Quaternion> rotation, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E504 Offset: 0x7D8A504 VA: 0x7D8E504
	public static void DrawGizmosBox(Matrix4x4 matrix, Vector3 size, Color color, bool selected = False, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E508 Offset: 0x7D8A508 VA: 0x7D8E508
	public static void DrawGizmosCircle(Vector3 position, float radius, Color color, float height = 0, bool selected = False, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E50C Offset: 0x7D8A50C VA: 0x7D8E50C
	public static void DrawGizmosSphere(Vector3 position, float radius, Color color, bool selected = False, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E510 Offset: 0x7D8A510 VA: 0x7D8E510
	public static void DrawGizmosTriangle(Vector3 A, Vector3 B, Vector3 C, bool selected, Color color) { }

	// RVA: 0x7D8E514 Offset: 0x7D8A514 VA: 0x7D8E514
	public static void DrawGizmoGrid(FPVector2 bottomLeft, int width, int height, int nodeSize, Color color) { }

	// RVA: 0x7D8E518 Offset: 0x7D8A518 VA: 0x7D8E518
	public static void DrawGizmoGrid(Vector3 bottomLeft, int width, int height, int nodeSize, Color color) { }

	// RVA: 0x7D8E51C Offset: 0x7D8A51C VA: 0x7D8E51C
	public static void DrawGizmoGrid(Vector3 bottomLeft, int width, int height, float nodeWidth, float nodeHeight, Color color) { }

	// RVA: 0x7D8E520 Offset: 0x7D8A520 VA: 0x7D8E520
	public static void DrawGizmoPolygon2D(Vector3 position, Quaternion rotation, FPVector2[] vertices, float height, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E524 Offset: 0x7D8A524 VA: 0x7D8E524
	public static void DrawGizmoPolygon2D(Vector3 position, Quaternion rotation, FPVector2[] vertices, float height, bool drawNormals, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E528 Offset: 0x7D8A528 VA: 0x7D8E528
	public static void DrawGizmoPolygon2D(Transform transform, FPVector2[] vertices, float height, bool drawNormals, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E52C Offset: 0x7D8A52C VA: 0x7D8E52C
	public static void DrawGizmoPolygon2D(Matrix4x4 matrix, FPVector2[] vertices, float height, bool drawNormals, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E530 Offset: 0x7D8A530 VA: 0x7D8E530
	private static void DrawGizmoPolygon2DInternal(Vector3[] vertices, float height, bool drawNormals, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E534 Offset: 0x7D8A534 VA: 0x7D8E534
	public static void DrawGizmoDiamond(Vector3 center, Vector2 size) { }

	// RVA: 0x7D8E538 Offset: 0x7D8A538 VA: 0x7D8E538
	public static void DrawGizmoVector3D(Vector3 start, Vector3 end, float arrowHeadLength = 0.25, float arrowHeadAngle = 25) { }

	// RVA: 0x7D8E53C Offset: 0x7D8A53C VA: 0x7D8E53C
	public static void DrawGizmoVector(Vector3 start, Vector3 end, float arrowHeadLength = 0.25, float arrowHeadAngle = 25) { }

	// RVA: 0x7D8E540 Offset: 0x7D8A540 VA: 0x7D8E540
	public static void DrawGizmoArc(Vector3 position, Vector3 normal, Vector3 from, float angle, float radius, Color color, float alphaRatio = 1, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E544 Offset: 0x7D8A544 VA: 0x7D8E544
	public static void DrawGizmoDisc(Vector3 position, Vector3 normal, float radius, Color color, float alphaRatio = 1, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E548 Offset: 0x7D8A548 VA: 0x7D8E548
	public static void DrawGizmosEdge(Vector3 start, Vector3 end, float height, bool selected, Color color, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E54C Offset: 0x7D8A54C VA: 0x7D8E54C
	public static void DrawGizmosJoint2D(Joint2D_Prototype prototype, Transform jointTransform, Transform connectedTransform, bool selected, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E550 Offset: 0x7D8A550 VA: 0x7D8E550
	public static void DrawGizmosJoint2D(Joint* joint, Transform2D* jointTransform, Transform2D* connectedTransform, bool selected, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E554 Offset: 0x7D8A554 VA: 0x7D8E554
	public static void DrawGizmosJoint3D(Joint3D_Prototype prototype, Transform jointTransform, Transform connectedTransform, bool selected, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E558 Offset: 0x7D8A558 VA: 0x7D8E558
	public static void DrawGizmosJoint3D(Joint3D* joint, Transform3D* jointTransform, Transform3D* connectedTransform, bool selected, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E55C Offset: 0x7D8A55C VA: 0x7D8E55C
	private static void DrawGizmosJointInternal(ref GizmoUtils.GizmosJointParams p, QuantumEditorSettings editorSettings, QuantumGizmoStyle style) { }

	// RVA: 0x7D8E560 Offset: 0x7D8A560 VA: 0x7D8E560
	private static float ComputeRelativeAngleHingeJoint(Vector3 hingeAxis, Quaternion rotJoint, Quaternion rotConnectedAnchor, Quaternion relRotRef) { }
}

// Namespace: Quantum
[Serializable]
public struct QuantumGizmoStyle // TypeDefIndex: 23376
{
	// Fields
	public bool DisableFill; // 0x0

	// Properties
	public static QuantumGizmoStyle FillDisabled { get; }
	public bool IsFillEnabled { get; }
	public bool IsWireframeEnabled { get; }

	// Methods

	// RVA: 0x7D8E7C0 Offset: 0x7D8A7C0 VA: 0x7D8E7C0
	public static QuantumGizmoStyle get_FillDisabled() { }

	// RVA: 0x7D8E7C8 Offset: 0x7D8A7C8 VA: 0x7D8E7C8
	public bool get_IsFillEnabled() { }

	// RVA: 0x7D8E7D8 Offset: 0x7D8A7D8 VA: 0x7D8E7D8
	public bool get_IsWireframeEnabled() { }
}

// Namespace: Quantum
public interface IQuantumEditorGUI // TypeDefIndex: 23377
{}

// Namespace: Quantum
public class ProgressBar : IDisposable // TypeDefIndex: 23378
{
	// Fields
	private float _progress; // 0x10
	private string _info; // 0x18
	private string _title; // 0x20
	private bool _isCancelable; // 0x28
	private Stopwatch _sw; // 0x30

	// Properties
	public string Info { set; }
	public float Progress { get; set; }

	// Methods

	// RVA: 0x7D8E7E0 Offset: 0x7D8A7E0 VA: 0x7D8E7E0
	public void .ctor(string title, bool isCancelable = False, bool logStopwatch = False) { }

	// RVA: 0x7D8E890 Offset: 0x7D8A890 VA: 0x7D8E890
	public void set_Info(string value) { }

	// RVA: 0x7D8AF08 Offset: 0x7D86F08 VA: 0x7D8AF08
	public void set_Progress(float value) { }

	// RVA: 0x7D8EA5C Offset: 0x7D8AA5C VA: 0x7D8EA5C
	public float get_Progress() { }

	// RVA: 0x7D8EA64 Offset: 0x7D8AA64 VA: 0x7D8EA64 Slot: 4
	public void Dispose() { }

	// RVA: 0x7D8EA58 Offset: 0x7D8AA58 VA: 0x7D8EA58
	private void Display() { }

	// RVA: 0x7D8E8C4 Offset: 0x7D8A8C4 VA: 0x7D8E8C4
	private void DisplayStopwatch() { }
}

// Namespace: Quantum
[Extension]
public static class EditorRectUtils // TypeDefIndex: 23379
{
	// Methods

	[Extension]
	// RVA: 0x7D8EA68 Offset: 0x7D8AA68 VA: 0x7D8EA68
	public static Rect SetWidth(Rect r, float w) { }

	[Extension]
	// RVA: 0x7D8EA70 Offset: 0x7D8AA70 VA: 0x7D8EA70
	public static Rect SetWidthHeight(Rect r, Vector2 v) { }

	[Extension]
	// RVA: 0x7D8EA7C Offset: 0x7D8AA7C VA: 0x7D8EA7C
	public static Rect SetWidthHeight(Rect r, float w, float h) { }

	[Extension]
	// RVA: 0x7D8EA88 Offset: 0x7D8AA88 VA: 0x7D8EA88
	public static Rect AddWidth(Rect r, float w) { }

	[Extension]
	// RVA: 0x7D8EA90 Offset: 0x7D8AA90 VA: 0x7D8EA90
	public static Rect AddHeight(Rect r, float h) { }

	[Extension]
	// RVA: 0x7D8EA98 Offset: 0x7D8AA98 VA: 0x7D8EA98
	public static Rect SetHeight(Rect r, float h) { }

	[Extension]
	// RVA: 0x7D8EAA0 Offset: 0x7D8AAA0 VA: 0x7D8EAA0
	public static Rect AddXY(Rect r, Vector2 xy) { }

	[Extension]
	// RVA: 0x7D8EAAC Offset: 0x7D8AAAC VA: 0x7D8EAAC
	public static Rect AddXY(Rect r, float x, float y) { }

	[Extension]
	// RVA: 0x7D8EAB8 Offset: 0x7D8AAB8 VA: 0x7D8EAB8
	public static Rect AddX(Rect r, float x) { }

	[Extension]
	// RVA: 0x7D8EAC0 Offset: 0x7D8AAC0 VA: 0x7D8EAC0
	public static Rect AddY(Rect r, float y) { }

	[Extension]
	// RVA: 0x7D8EAC8 Offset: 0x7D8AAC8 VA: 0x7D8EAC8
	public static Rect SetY(Rect r, float y) { }

	[Extension]
	// RVA: 0x7D8EAD0 Offset: 0x7D8AAD0 VA: 0x7D8EAD0
	public static Rect SetX(Rect r, float x) { }

	[Extension]
	// RVA: 0x7D8EAD8 Offset: 0x7D8AAD8 VA: 0x7D8EAD8
	public static Rect SetXMin(Rect r, float x) { }

	[Extension]
	// RVA: 0x7D8EAE8 Offset: 0x7D8AAE8 VA: 0x7D8EAE8
	public static Rect SetXMax(Rect r, float x) { }

	[Extension]
	// RVA: 0x7D8EAF0 Offset: 0x7D8AAF0 VA: 0x7D8EAF0
	public static Rect SetYMin(Rect r, float y) { }

	[Extension]
	// RVA: 0x7D8EB00 Offset: 0x7D8AB00 VA: 0x7D8EB00
	public static Rect SetYMax(Rect r, float y) { }

	[Extension]
	// RVA: 0x7D8EB08 Offset: 0x7D8AB08 VA: 0x7D8EB08
	public static Rect AddXMin(Rect r, float x) { }

	[Extension]
	// RVA: 0x7D8EB1C Offset: 0x7D8AB1C VA: 0x7D8EB1C
	public static Rect AddXMax(Rect r, float x) { }

	[Extension]
	// RVA: 0x7D8EB2C Offset: 0x7D8AB2C VA: 0x7D8EB2C
	public static Rect AddYMin(Rect r, float y) { }

	[Extension]
	// RVA: 0x7D8EB40 Offset: 0x7D8AB40 VA: 0x7D8EB40
	public static Rect AddYMax(Rect r, float y) { }

	[Extension]
	// RVA: 0x7D8EB50 Offset: 0x7D8AB50 VA: 0x7D8EB50
	public static Rect Adjust(Rect r, float x, float y, float w, float h) { }

	[Extension]
	// RVA: 0x7D8EB64 Offset: 0x7D8AB64 VA: 0x7D8EB64
	public static Rect ToRect(Vector2 v, float w, float h) { }

	[Extension]
	// RVA: 0x7D8EB68 Offset: 0x7D8AB68 VA: 0x7D8EB68
	public static Rect ZeroXY(Rect r) { }

	[Extension]
	// RVA: 0x7D8EB74 Offset: 0x7D8AB74 VA: 0x7D8EB74
	public static Vector2 ToVector2(Rect r) { }
}

// Namespace: 
public struct ReflectionUtils.InstanceAccessor<TValue> // TypeDefIndex: 23380
{
	// Fields
	public Func<object, TValue> GetValue; // 0x0
	public Action<object, TValue> SetValue; // 0x0
}

// Namespace: 
public struct ReflectionUtils.StaticAccessor<TValue> // TypeDefIndex: 23381
{
	// Fields
	public Func<TValue> GetValue; // 0x0
	public Action<TValue> SetValue; // 0x0
}

// Namespace: 
public class ReflectionUtils.DelegateSwizzle // TypeDefIndex: 23382
{
	// Fields
	private int[] _args; // 0x10

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x7D914D4 Offset: 0x7D8D4D4 VA: 0x7D914D4
	public int get_Count() { }

	// RVA: 0x7D914F0 Offset: 0x7D8D4F0 VA: 0x7D914F0
	public void .ctor(int[] args) { }

	// RVA: -1 Offset: -1
	public T[] Swizzle<T>(T[] inputTypes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47A3CF8 Offset: 0x479FCF8 VA: 0x47A3CF8
	|-ReflectionUtils.DelegateSwizzle.Swizzle<object>
	|
	|-RVA: 0x47A3DD4 Offset: 0x479FDD4 VA: 0x47A3DD4
	|-ReflectionUtils.DelegateSwizzle.Swizzle<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReflectionUtils.<>c // TypeDefIndex: 23383
{
	// Fields
	public static readonly ReflectionUtils.<>c <>9; // 0x0
	public static Func<Type, string> <>9__25_0; // 0x8
	public static Func<ParameterInfo, Type> <>9__30_0; // 0x10
	public static Func<Type, string> <>9__30_1; // 0x18
	public static Func<ConstructorInfo, string> <>9__30_2; // 0x20
	public static Func<ParameterInfo, Type> <>9__31_0; // 0x28
	public static Func<Type, string> <>9__31_1; // 0x30
	public static Func<MethodInfo, string> <>9__31_2; // 0x38

	// Methods

	// RVA: 0x7D91520 Offset: 0x7D8D520 VA: 0x7D91520
	private static void .cctor() { }

	// RVA: 0x7D91588 Offset: 0x7D8D588 VA: 0x7D91588
	public void .ctor() { }

	// RVA: 0x7D91590 Offset: 0x7D8D590 VA: 0x7D91590
	internal string <CreateConstructorExceptionMessage>b__25_0(Type x) { }

	// RVA: 0x7D915B8 Offset: 0x7D8D5B8 VA: 0x7D915B8
	internal Type <GetConstructorOrThrow>b__30_0(ParameterInfo x) { }

	// RVA: 0x7D915E0 Offset: 0x7D8D5E0 VA: 0x7D915E0
	internal string <GetConstructorOrThrow>b__30_1(Type x) { }

	// RVA: 0x7D91608 Offset: 0x7D8D608 VA: 0x7D91608
	internal string <GetConstructorOrThrow>b__30_2(ConstructorInfo x) { }

	// RVA: 0x7D9162C Offset: 0x7D8D62C VA: 0x7D9162C
	internal Type <GetMethodOrThrow>b__31_0(ParameterInfo x) { }

	// RVA: 0x7D91654 Offset: 0x7D8D654 VA: 0x7D91654
	internal string <GetMethodOrThrow>b__31_1(Type x) { }

	// RVA: 0x7D9167C Offset: 0x7D8D67C VA: 0x7D9167C
	internal string <GetMethodOrThrow>b__31_2(MethodInfo x) { }
}

// Namespace: Quantum
[Extension]
public static class ReflectionUtils // TypeDefIndex: 23384
{
	// Fields
	public const BindingFlags DefaultBindingFlags = 60;

	// Methods

	[Extension]
	// RVA: 0x7D8EB80 Offset: 0x7D8AB80 VA: 0x7D8EB80
	public static Type GetUnityLeafType(Type type) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T CreateMethodDelegate<T>(Type type, string methodName, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BB6AC Offset: 0x46B76AC VA: 0x46BB6AC
	|-ReflectionUtils.CreateMethodDelegate<object>
	*/

	[Extension]
	// RVA: 0x7D8EC98 Offset: 0x7D8AC98 VA: 0x7D8EC98
	public static Delegate CreateMethodDelegate(Type type, string methodName, BindingFlags flags, Type delegateType) { }

	// RVA: -1 Offset: -1
	public static T CreateMethodDelegate<T>(Assembly assembly, string typeName, string methodName, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BB804 Offset: 0x46B7804 VA: 0x46BB804
	|-ReflectionUtils.CreateMethodDelegate<object>
	*/

	// RVA: 0x7D8ECE0 Offset: 0x7D8ACE0 VA: 0x7D8ECE0
	public static Delegate CreateMethodDelegate(Assembly assembly, string typeName, string methodName, BindingFlags flags, Type delegateType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T CreateMethodDelegate<T>(Type type, string methodName, BindingFlags flags, Type delegateType, ReflectionUtils.DelegateSwizzle[] fallbackSwizzles) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BB94C Offset: 0x46B794C VA: 0x46BB94C
	|-ReflectionUtils.CreateMethodDelegate<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T CreateConstructorDelegate<T>(Type type, BindingFlags flags, Type delegateType, ReflectionUtils.DelegateSwizzle[] fallbackSwizzles) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BAE38 Offset: 0x46B6E38 VA: 0x46BAE38
	|-ReflectionUtils.CreateConstructorDelegate<object>
	*/

	[Extension]
	// RVA: 0x7D8F028 Offset: 0x7D8B028 VA: 0x7D8F028
	public static FieldInfo GetFieldOrThrow(Type type, string fieldName, BindingFlags flags = 60) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static FieldInfo GetFieldOrThrow<T>(Type type, string fieldName, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BD27C Offset: 0x46B927C VA: 0x46BD27C
	|-ReflectionUtils.GetFieldOrThrow<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7D8F2D8 Offset: 0x7D8B2D8 VA: 0x7D8F2D8
	public static FieldInfo GetFieldOrThrow(Type type, string fieldName, Type fieldType, BindingFlags flags = 60) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static PropertyInfo GetPropertyOrThrow<T>(Type type, string propertyName, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BD30C Offset: 0x46B930C VA: 0x46BD30C
	|-ReflectionUtils.GetPropertyOrThrow<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7D8F574 Offset: 0x7D8B574 VA: 0x7D8F574
	public static PropertyInfo GetPropertyOrThrow(Type type, string propertyName, Type propertyType, BindingFlags flags = 60) { }

	[Extension]
	// RVA: 0x7D8F808 Offset: 0x7D8B808 VA: 0x7D8F808
	public static ConstructorInfo GetConstructorInfoOrThrow(Type type, Type[] types, BindingFlags flags = 60) { }

	[Extension]
	// RVA: 0x7D8FC0C Offset: 0x7D8BC0C VA: 0x7D8FC0C
	public static Type GetNestedTypeOrThrow(Type type, string name, BindingFlags flags) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static ReflectionUtils.InstanceAccessor<FieldType> CreateFieldAccessor<FieldType>(Type type, string fieldName, Type expectedFieldType, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BB5FC Offset: 0x46B75FC VA: 0x46BB5FC
	|-ReflectionUtils.CreateFieldAccessor<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7D8FD50 Offset: 0x7D8BD50 VA: 0x7D8FD50
	public static ReflectionUtils.StaticAccessor<object> CreateStaticFieldAccessor(Type type, string fieldName, Type expectedFieldType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static ReflectionUtils.StaticAccessor<FieldType> CreateStaticFieldAccessor<FieldType>(Type type, string fieldName, Type expectedFieldType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BCFC4 Offset: 0x46B8FC4 VA: 0x46BCFC4
	|-ReflectionUtils.CreateStaticFieldAccessor<object>
	|
	|-RVA: 0x46BD070 Offset: 0x46B9070 VA: 0x46BD070
	|-ReflectionUtils.CreateStaticFieldAccessor<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static ReflectionUtils.InstanceAccessor<PropertyType> CreatePropertyAccessor<PropertyType>(Type type, string fieldName, Type expectedPropertyType, BindingFlags flags = 60) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BC424 Offset: 0x46B8424 VA: 0x46BC424
	|-ReflectionUtils.CreatePropertyAccessor<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7D8FDB0 Offset: 0x7D8BDB0 VA: 0x7D8FDB0
	public static ReflectionUtils.StaticAccessor<object> CreateStaticPropertyAccessor(Type type, string fieldName, Type expectedFieldType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static ReflectionUtils.StaticAccessor<FieldType> CreateStaticPropertyAccessor<FieldType>(Type type, string fieldName, Type expectedFieldType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BD120 Offset: 0x46B9120 VA: 0x46BD120
	|-ReflectionUtils.CreateStaticPropertyAccessor<object>
	|
	|-RVA: 0x46BD1CC Offset: 0x46B91CC VA: 0x46BD1CC
	|-ReflectionUtils.CreateStaticPropertyAccessor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static string CreateMethodExceptionMessage<T>(Assembly assembly, string typeName, string methodName, BindingFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BC2F4 Offset: 0x46B82F4 VA: 0x46BC2F4
	|-ReflectionUtils.CreateMethodExceptionMessage<object>
	|
	|-RVA: 0x46BC38C Offset: 0x46B838C VA: 0x46BC38C
	|-ReflectionUtils.CreateMethodExceptionMessage<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D8EE30 Offset: 0x7D8AE30 VA: 0x7D8EE30
	private static string CreateMethodExceptionMessage(Assembly assembly, string typeName, string methodName, BindingFlags flags, Type delegateType) { }

	// RVA: 0x7D8F120 Offset: 0x7D8B120 VA: 0x7D8F120
	private static string CreateFieldExceptionMessage(Assembly assembly, string typeName, string fieldName, BindingFlags flags) { }

	// RVA: 0x7D8FE10 Offset: 0x7D8BE10 VA: 0x7D8FE10
	private static string CreateConstructorExceptionMessage(Assembly assembly, string typeName, BindingFlags flags) { }

	// RVA: 0x7D8F94C Offset: 0x7D8B94C VA: 0x7D8F94C
	private static string CreateConstructorExceptionMessage(Assembly assembly, string typeName, Type[] types, BindingFlags flags) { }

	[Extension]
	// RVA: -1 Offset: -1
	private static T CreateMethodDelegateInternal<T>(Type type, string name, BindingFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BC21C Offset: 0x46B821C VA: 0x46BC21C
	|-ReflectionUtils.CreateMethodDelegateInternal<object>
	*/

	[Extension]
	// RVA: 0x7D8ECBC Offset: 0x7D8ACBC VA: 0x7D8ECBC
	private static Delegate CreateMethodDelegateInternal(Type type, string name, BindingFlags flags, Type delegateType) { }

	// RVA: 0x7D8FEC8 Offset: 0x7D8BEC8 VA: 0x7D8FEC8
	private static MethodInfo GetMethodOrThrow(Type type, string name, BindingFlags flags, Type delegateType) { }

	// RVA: 0x7D90748 Offset: 0x7D8C748 VA: 0x7D90748
	private static MethodInfo FindMethod(Type type, string name, BindingFlags flags, Type returnType, Type[] parameters) { }

	// RVA: 0x7D90834 Offset: 0x7D8C834 VA: 0x7D90834
	private static ConstructorInfo GetConstructorOrThrow(Type type, BindingFlags flags, Type delegateType, ReflectionUtils.DelegateSwizzle[] swizzles, out ReflectionUtils.DelegateSwizzle firstMatchingSwizzle) { }

	// RVA: 0x7D8FF90 Offset: 0x7D8BF90 VA: 0x7D8FF90
	private static MethodInfo GetMethodOrThrow(Type type, string name, BindingFlags flags, Type delegateType, ReflectionUtils.DelegateSwizzle[] swizzles, out ReflectionUtils.DelegateSwizzle firstMatchingSwizzle) { }

	[Extension]
	// RVA: 0x7D90ED8 Offset: 0x7D8CED8 VA: 0x7D90ED8
	public static bool IsArrayOrList(Type listType) { }

	[Extension]
	// RVA: 0x7D90FB8 Offset: 0x7D8CFB8 VA: 0x7D90FB8
	public static Type GetArrayOrListElementType(Type listType) { }

	// RVA: 0x7D910DC Offset: 0x7D8D0DC VA: 0x7D910DC
	public static Type MakeFuncType(Type[] types) { }

	// RVA: 0x7D91110 Offset: 0x7D8D110 VA: 0x7D91110
	private static Type GetFuncType(int argumentCount) { }

	// RVA: 0x7D912A0 Offset: 0x7D8D2A0 VA: 0x7D912A0
	public static Type MakeActionType(Type[] types) { }

	// RVA: 0x7D91344 Offset: 0x7D8D344 VA: 0x7D91344
	private static Type GetActionType(int argumentCount) { }

	// RVA: -1 Offset: -1
	private static ReflectionUtils.StaticAccessor<T> CreateStaticAccessorInternal<T>(MemberInfo fieldOrProperty) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BC4D4 Offset: 0x46B84D4 VA: 0x46BC4D4
	|-ReflectionUtils.CreateStaticAccessorInternal<object>
	|
	|-RVA: 0x46BCA34 Offset: 0x46B8A34 VA: 0x46BCA34
	|-ReflectionUtils.CreateStaticAccessorInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static ReflectionUtils.InstanceAccessor<T> CreateAccessorInternal<T>(MemberInfo fieldOrProperty) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BA7E4 Offset: 0x46B67E4 VA: 0x46BA7E4
	|-ReflectionUtils.CreateAccessorInternal<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class PhysicsJoints3D_Prototype.<>c__DisplayClass1_0 // TypeDefIndex: 23385
{
	// Fields
	public EntityPrototypeConverter converter; // 0x10

	// Methods

	// RVA: 0x7D917CC Offset: 0x7D8D7CC VA: 0x7D917CC
	public void .ctor() { }

	// RVA: 0x7D9188C Offset: 0x7D8D88C VA: 0x7D9188C
	internal Joint3D_Prototype <Convert>b__0(Joint3D_Prototype x) { }
}

// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(PhysicsJoints3D))]
[Serializable]
public class PhysicsJoints3D_Prototype : PrototypeAdapter<PhysicsJoints3D_Prototype> // TypeDefIndex: 23386
{
	// Fields
	[DynamicCollection]
	public Joint3D_Prototype[] JointConfigs; // 0x10

	// Methods

	// RVA: 0x7D916A0 Offset: 0x7D8D6A0 VA: 0x7D916A0 Slot: 5
	public sealed override PhysicsJoints3D_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x7D917D4 Offset: 0x7D8D7D4 VA: 0x7D917D4
	public void .ctor() { }
}

// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Joint3D))]
[Serializable]
public class Joint3D_Prototype : PrototypeAdapter<Joint3D_Prototype> // TypeDefIndex: 23387
{
	// Fields
	[Tooltip("If the joint should be materialized with Enabled set to false, not being considered by the Physics Engine.")]
	[DrawIf("JointType", 0, 1, 3)]
	public bool StartDisabled; // 0x10
	[Tooltip("The type of the joint, implying which constraints are applied.")]
	[DisplayName("Type")]
	public JointType3D JointType; // 0x12
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("A numerical tag that can be used to identify a joint or a group of joints.")]
	public int UserTag; // 0x14
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("A Map Entity that the joint might be connected to.
The entity must have at least a transform component.")]
	[LocalReference]
	public EntityPrototype ConnectedEntity; // 0x18
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("The anchor point to which the joint connects to.
If a Connected Entity is provided, this represents an offset in its local space. Otherwise, the connected anchor is a position in world space.")]
	public FPVector3 ConnectedAnchor; // 0x20
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("The anchor offset, in the local space of this joint entity's transform.
This is the point considered for the joint constraints and where the forces will be applied in the joint entity's body.")]
	public FPVector3 Anchor; // 0x38
	[Tooltip("Axis around which the joint rotates, defined in the local space of the entity.
The vector is normalized before set. If zeroed, FPVector3.Right is used instead.")]
	[DrawIf("JointType", 3, 0, 3)]
	public FPVector3 Axis; // 0x50
	[Tooltip("The frequency in Hertz (Hz) at which the spring joint will attempt to oscillate.
Typical values are below half the frequency of the simulation.")]
	[DrawIf("JointType", 2, 0, 3)]
	public FP Frequency; // 0x68
	[Range(0, 2)]
	[DrawIf("JointType", 2, 0, 3)]
	[Tooltip("A dimensionless value representing the damper capacity of suppressing the spring oscillation, typically between 0 and 1.")]
	public FP DampingRatio; // 0x70
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("Automatically configure the target Distance to be the current distance between the anchor points in the scene.")]
	[DrawIf("JointType", 3, 1, 3)]
	public bool AutoConfigureDistance; // 0x78
	[DrawIf("JointType", 2, 0, 3)]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The distance between the anchor points that the joint will attempt to maintain.")]
	public FP Distance; // 0x80
	[DrawIf("JointType", 1, 0, 3)]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The minimum distance between the anchor points that the joint will attempt to maintain.")]
	public FP MinDistance; // 0x88
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The maximum distance between the anchor points that the joint will attempt to maintain.")]
	[DrawIf("JointType", 1, 0, 3)]
	public FP MaxDistance; // 0x90
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("If the relative angle between the joint transform and its connected anchor should be limited by the hinge joint.
Set this checkbox to configure the lower and upper limiting angles.")]
	public bool UseAngleLimits; // 0x98
	[Tooltip("The lower limiting angle of the allowed arc of rotation around the connected anchor, in degrees.")]
	[DrawIf("UseAngleLimits", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	public FP LowerAngle; // 0xA0
	[Tooltip("The upper limiting  angle of the allowed arc of rotation around the connected anchor, in degrees.")]
	[DrawIf("JointType", 3, 0, 3)]
	[DrawIf("UseAngleLimits", 1, 0, 3)]
	public FP UpperAngle; // 0xA8
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("If the hinge joint uses a motor.
Set this checkbox to configure the motor speed and max torque.")]
	public bool UseMotor; // 0xB0
	[DrawIf("UseMotor", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The speed at which the hinge motor will attempt to rotate, in angles per second.")]
	public FP MotorSpeed; // 0xB8
	[Tooltip("The maximum torque produced by the hinge motor in order to achieve the target motor speed.
Leave this checkbox unchecked and the motor toque should not be limited.")]
	[DrawIf("JointType", 3, 0, 3)]
	[DrawIf("UseMotor", 1, 0, 3)]
	public NullableFP MaxMotorTorque; // 0xC0

	// Methods

	// RVA: 0x7D918B4 Offset: 0x7D8D8B4 VA: 0x7D918B4 Slot: 5
	public sealed override Joint3D_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x7D919E0 Offset: 0x7D8D9E0 VA: 0x7D919E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PhysicsJoints2D_Prototype.<>c__DisplayClass1_0 // TypeDefIndex: 23388
{
	// Fields
	public EntityPrototypeConverter converter; // 0x10

	// Methods

	// RVA: 0x7D91B54 Offset: 0x7D8DB54 VA: 0x7D91B54
	public void .ctor() { }

	// RVA: 0x7D91C14 Offset: 0x7D8DC14 VA: 0x7D91C14
	internal Joint2D_Prototype <Convert>b__0(Joint2D_Prototype x) { }
}

// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(PhysicsJoints2D))]
[Serializable]
public class PhysicsJoints2D_Prototype : PrototypeAdapter<PhysicsJoints2D_Prototype> // TypeDefIndex: 23389
{
	// Fields
	[DynamicCollection]
	public Joint2D_Prototype[] JointConfigs; // 0x10

	// Methods

	// RVA: 0x7D91A28 Offset: 0x7D8DA28 VA: 0x7D91A28 Slot: 5
	public sealed override PhysicsJoints2D_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x7D91B5C Offset: 0x7D8DB5C VA: 0x7D91B5C
	public void .ctor() { }
}

// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(Joint))]
[Serializable]
public class Joint2D_Prototype : PrototypeAdapter<Joint2D_Prototype> // TypeDefIndex: 23390
{
	// Fields
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("If the joint should be materialized with Enabled set to false, not being considered by the Physics Engine.")]
	public bool StartDisabled; // 0x10
	[DisplayName("Type")]
	[Tooltip("The type of the joint, implying which constraints are applied.")]
	public JointType JointType; // 0x12
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("A numerical tag that can be used to identify a joint or a group of joints.")]
	public int UserTag; // 0x14
	[DrawIf("JointType", 0, 1, 3)]
	[LocalReference]
	[Tooltip("A Map Entity that the joint might be connected to.
The entity must have at least a Transform2D component.")]
	public EntityPrototype ConnectedEntity; // 0x18
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("The anchor point to which the joint connects to.
If a Connected Entity is provided, this represents an offset in its local space. Otherwise, the connected anchor is a position in world space.")]
	public FPVector2 ConnectedAnchor; // 0x20
	[DrawIf("JointType", 0, 1, 3)]
	[Tooltip("The anchor offset, in the local space of this joint entity's transform.
This is the point considered for the joint constraints and where the forces will be applied in the joint entity's body.")]
	public FPVector2 Anchor; // 0x30
	[DrawIf("JointType", 2, 0, 3)]
	[Tooltip("The frequency in Hertz (Hz) at which the spring joint will attempt to oscillate.
Typical values are below half the frequency of the simulation.")]
	public FP Frequency; // 0x40
	[Tooltip("A dimensionless value representing the damper capacity of suppressing the spring oscillation, typically between 0 and 1.")]
	[Range(0, 2)]
	[DrawIf("JointType", 2, 0, 3)]
	public FP DampingRatio; // 0x48
	[DrawIf("JointType", 0, 1, 3)]
	[DrawIf("JointType", 3, 1, 3)]
	[Tooltip("Automatically configure the target Distance to be the current distance between the anchor points in the scene.")]
	public bool AutoConfigureDistance; // 0x50
	[DrawIf("JointType", 2, 0, 3)]
	[Tooltip("The distance between the anchor points that the joint will attempt to maintain.")]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	public FP Distance; // 0x58
	[DrawIf("JointType", 1, 0, 3)]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	[Tooltip("The minimum distance between the anchor points that the joint will attempt to maintain.")]
	public FP MinDistance; // 0x60
	[DrawIf("JointType", 1, 0, 3)]
	[Tooltip("The maximum distance between the anchor points that the joint will attempt to maintain.")]
	[DrawIf("AutoConfigureDistance", 0, 0, 2)]
	public FP MaxDistance; // 0x68
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("If the relative angle between the joint transform and its connected anchor should be limited by the hinge joint.
Set this checkbox to configure the lower and upper limiting angles.")]
	public bool UseAngleLimits; // 0x70
	[Degrees]
	[DrawIf("UseAngleLimits", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The lower limiting angle of the allowed arc of rotation around the connected anchor, in degrees.")]
	public FP LowerAngle; // 0x78
	[Degrees]
	[DrawIf("UseAngleLimits", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The upper limiting  angle of the allowed arc of rotation around the connected anchor, in degrees.")]
	public FP UpperAngle; // 0x80
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("If the hinge joint uses a motor.
Set this checkbox to configure the motor speed and max torque.")]
	public bool UseMotor; // 0x88
	[Tooltip("The speed at which the hinge motor will attempt to rotate, in angles per second.")]
	[DrawIf("JointType", 3, 0, 3)]
	[Degrees]
	[DrawIf("UseMotor", 1, 0, 3)]
	public FP MotorSpeed; // 0x90
	[DrawIf("UseMotor", 1, 0, 3)]
	[DrawIf("JointType", 3, 0, 3)]
	[Tooltip("The maximum torque produced by the hinge motor in order to achieve the target motor speed.
Leave this checkbox unchecked and the motor toque should not be limited.")]
	public NullableFP MaxMotorTorque; // 0x98

	// Methods

	// RVA: 0x7D91C3C Offset: 0x7D8DC3C VA: 0x7D91C3C Slot: 5
	public sealed override Joint2D_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x7D91D48 Offset: 0x7D8DD48 VA: 0x7D91D48
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7421 // TypeDefIndex: 23391
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8624 // TypeDefIndex: 23392
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 23393
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8624 508E113B005BEDE9C36A4E80DDCE5625AE16920676447A6CAFD28C178FE9CBF8 /*Metadata offset 0xF22178*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7421 CD575A5F5584C1B9AA4C009006F4089ED18A7F3420D25A4E63FF562CE90D6460 /*Metadata offset 0xF24330*/; // 0x21B0
}

