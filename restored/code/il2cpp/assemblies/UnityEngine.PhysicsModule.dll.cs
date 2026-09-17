// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27530
{}

// Namespace: UnityEngine
public enum RigidbodyConstraints // TypeDefIndex: 27531
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyConstraints None = 0;
	public const RigidbodyConstraints FreezePositionX = 2;
	public const RigidbodyConstraints FreezePositionY = 4;
	public const RigidbodyConstraints FreezePositionZ = 8;
	public const RigidbodyConstraints FreezeRotationX = 16;
	public const RigidbodyConstraints FreezeRotationY = 32;
	public const RigidbodyConstraints FreezeRotationZ = 64;
	public const RigidbodyConstraints FreezePosition = 14;
	public const RigidbodyConstraints FreezeRotation = 112;
	public const RigidbodyConstraints FreezeAll = 126;
}

// Namespace: UnityEngine
public enum ForceMode // TypeDefIndex: 27532
{
	// Fields
	public int value__; // 0x0
	public const ForceMode Force = 0;
	public const ForceMode Acceleration = 5;
	public const ForceMode Impulse = 1;
	public const ForceMode VelocityChange = 2;
}

// Namespace: UnityEngine
[Flags]
public enum MeshColliderCookingOptions // TypeDefIndex: 27533
{
	// Fields
	public int value__; // 0x0
	public const MeshColliderCookingOptions None = 0;
	[Obsolete("No longer used because the problem this was trying to solve is gone since Unity 2018.3", True)]
	public const MeshColliderCookingOptions InflateConvexMesh = 1;
	public const MeshColliderCookingOptions CookForFasterSimulation = 2;
	public const MeshColliderCookingOptions EnableMeshCleaning = 4;
	public const MeshColliderCookingOptions WeldColocatedVertices = 8;
	public const MeshColliderCookingOptions UseFastMidphase = 16;
}

// Namespace: UnityEngine
public enum RigidbodyInterpolation // TypeDefIndex: 27534
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyInterpolation None = 0;
	public const RigidbodyInterpolation Interpolate = 1;
	public const RigidbodyInterpolation Extrapolate = 2;
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class ControllerColliderHit // TypeDefIndex: 27535
{
	// Fields
	internal CharacterController m_Controller; // 0x10
	internal Collider m_Collider; // 0x18
	internal Vector3 m_Point; // 0x20
	internal Vector3 m_Normal; // 0x2C
	internal Vector3 m_MoveDirection; // 0x38
	internal float m_MoveLength; // 0x44
	internal int m_Push; // 0x48
}

// Namespace: UnityEngine
public class Collision // TypeDefIndex: 27536
{
	// Fields
	private ContactPairHeader m_Header; // 0x10
	private ContactPair m_Pair; // 0x38
	private bool m_Flipped; // 0x60
	private ContactPoint[] m_LegacyContacts; // 0x68

	// Properties
	public Component body { get; }
	public Collider collider { get; }
	public GameObject gameObject { get; }
	internal bool Flipped { set; }
	public ContactPoint[] contacts { get; }

	// Methods

	// RVA: 0x87CD56C Offset: 0x87C956C VA: 0x87CD56C
	public Component get_body() { }

	// RVA: 0x87CD670 Offset: 0x87C9670 VA: 0x87CD670
	public Collider get_collider() { }

	// RVA: 0x87CD79C Offset: 0x87C979C VA: 0x87CD79C
	public GameObject get_gameObject() { }

	// RVA: 0x87CD830 Offset: 0x87C9830 VA: 0x87CD830
	internal void set_Flipped(bool value) { }

	// RVA: 0x87CD83C Offset: 0x87C983C VA: 0x87CD83C
	public ContactPoint[] get_contacts() { }

	// RVA: 0x87CD944 Offset: 0x87C9944 VA: 0x87CD944
	public void .ctor() { }

	// RVA: 0x87CD99C Offset: 0x87C999C VA: 0x87CD99C
	internal void .ctor(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x87CDA94 Offset: 0x87C9A94 VA: 0x87CDA94
	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }
}

// Namespace: UnityEngine
public enum QueryTriggerInteraction // TypeDefIndex: 27537
{
	// Fields
	public int value__; // 0x0
	public const QueryTriggerInteraction UseGlobal = 0;
	public const QueryTriggerInteraction Ignore = 1;
	public const QueryTriggerInteraction Collide = 2;
}

// Namespace: UnityEngine
public enum CollisionDetectionMode // TypeDefIndex: 27538
{
	// Fields
	public int value__; // 0x0
	public const CollisionDetectionMode Discrete = 0;
	public const CollisionDetectionMode Continuous = 1;
	public const CollisionDetectionMode ContinuousDynamic = 2;
	public const CollisionDetectionMode ContinuousSpeculative = 3;
}

// Namespace: UnityEngine
[NativeClass("Unity::ArticulationBody")]
[NativeHeader("Modules/Physics/ArticulationBody.h")]
public class ArticulationBody : Behaviour // TypeDefIndex: 27539
{
	// Methods

	// RVA: 0x87CDAD8 Offset: 0x87C9AD8 VA: 0x87CDAD8
	public void .ctor() { }
}

// Namespace: 
public sealed class Physics.ContactEventDelegate : MulticastDelegate // TypeDefIndex: 27540
{
	// Methods

	// RVA: 0x87D8E98 Offset: 0x87D4E98 VA: 0x87D8E98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x87D8F38 Offset: 0x87D4F38 VA: 0x87D8F38 Slot: 13
	public virtual void Invoke(PhysicsScene scene, NativeArray.ReadOnly<ContactPairHeader> headerArray) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/PhysicsManager.h")]
[StaticAccessor("GetPhysicsManager()", 0)]
public class Physics // TypeDefIndex: 27541
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD; // 0x8
	internal const float k_MaxFloatMinusEpsilon = 3.4028233E+38;
	public const int IgnoreRaycastLayer = 4;
	public const int DefaultRaycastLayers = -5;
	public const int AllLayers = -1;
	[EditorBrowsable(1)]
	[Obsolete("Please use Physics.IgnoreRaycastLayer instead. (UnityUpgradable) -> IgnoreRaycastLayer", True)]
	public const int kIgnoreRaycastLayer = 4;
	[Obsolete("Please use Physics.DefaultRaycastLayers instead. (UnityUpgradable) -> DefaultRaycastLayers", True)]
	[EditorBrowsable(1)]
	public const int kDefaultRaycastLayers = -5;
	[EditorBrowsable(1)]
	[Obsolete("Please use Physics.AllLayers instead. (UnityUpgradable) -> AllLayers", True)]
	public const int kAllLayers = -1;
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Physics.ContactEventDelegate ContactEvent; // 0x10
	private static readonly Collision s_ReusableCollision; // 0x18

	// Properties
	public static Vector3 gravity { get; set; }
	public static float defaultContactOffset { get; set; }
	public static float sleepThreshold { get; set; }
	public static bool queriesHitTriggers { get; set; }
	public static bool queriesHitBackfaces { get; set; }
	public static float bounceThreshold { get; set; }
	public static float defaultMaxDepenetrationVelocity { get; set; }
	public static int defaultSolverIterations { get; set; }
	public static int defaultSolverVelocityIterations { get; set; }
	public static SimulationMode simulationMode { get; set; }
	public static float defaultMaxAngularSpeed { get; set; }
	public static bool improvedPatchFriction { get; set; }
	public static bool invokeCollisionCallbacks { get; set; }
	[NativeProperty("DefaultPhysicsSceneHandle", True, 0, True)]
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool autoSyncTransforms { get; set; }
	public static bool reuseCollisionCallbacks { get; set; }
	[StaticAccessor("GetPhysicsManager()")]
	public static float interCollisionDistance { get; set; }
	[StaticAccessor("GetPhysicsManager()")]
	public static float interCollisionStiffness { get; set; }
	[StaticAccessor("GetPhysicsManager()")]
	public static bool interCollisionSettingsToggle { get; set; }
	public static Vector3 clothGravity { get; set; }
	[Obsolete("Use Physics.defaultContactOffset or Collider.contactOffset instead.", True)]
	[EditorBrowsable(1)]
	public static float minPenetrationForPenalty { get; set; }
	[Obsolete("Please use bounceThreshold instead. (UnityUpgradable) -> bounceThreshold")]
	public static float bounceTreshold { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", True)]
	public static float sleepVelocity { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", True)]
	public static float sleepAngularVelocity { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Use Rigidbody.maxAngularVelocity instead.", True)]
	public static float maxAngularVelocity { get; set; }
	[Obsolete("Please use Physics.defaultSolverIterations instead. (UnityUpgradable) -> defaultSolverIterations")]
	public static int solverIterationCount { get; set; }
	[Obsolete("Please use Physics.defaultSolverVelocityIterations instead. (UnityUpgradable) -> defaultSolverVelocityIterations")]
	public static int solverVelocityIterationCount { get; set; }
	[Obsolete("penetrationPenaltyForce has no effect.", True)]
	[EditorBrowsable(1)]
	public static float penetrationPenaltyForce { get; set; }
	[Obsolete("Physics.autoSimulation has been replaced by Physics.simulationMode", False)]
	[EditorBrowsable(1)]
	public static bool autoSimulation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x87CDAE0 Offset: 0x87C9AE0 VA: 0x87CDAE0
	public static void add_ContactModifyEvent(Action<PhysicsScene, NativeArray<ModifiableContactPair>> value) { }

	[CompilerGenerated]
	// RVA: 0x87CDBD0 Offset: 0x87C9BD0 VA: 0x87CDBD0
	public static void remove_ContactModifyEvent(Action<PhysicsScene, NativeArray<ModifiableContactPair>> value) { }

	[CompilerGenerated]
	// RVA: 0x87CDCC0 Offset: 0x87C9CC0 VA: 0x87CDCC0
	public static void add_ContactModifyEventCCD(Action<PhysicsScene, NativeArray<ModifiableContactPair>> value) { }

	[CompilerGenerated]
	// RVA: 0x87CDDB4 Offset: 0x87C9DB4 VA: 0x87CDDB4
	public static void remove_ContactModifyEventCCD(Action<PhysicsScene, NativeArray<ModifiableContactPair>> value) { }

	[RequiredByNativeCode]
	// RVA: 0x87CDEA8 Offset: 0x87C9EA8 VA: 0x87CDEA8
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[ThreadSafe]
	// RVA: 0x87CDF8C Offset: 0x87C9F8C VA: 0x87CDF8C
	public static Vector3 get_gravity() { }

	// RVA: 0x87CE054 Offset: 0x87CA054 VA: 0x87CE054
	public static void set_gravity(Vector3 value) { }

	// RVA: 0x87CE114 Offset: 0x87CA114 VA: 0x87CE114
	public static float get_defaultContactOffset() { }

	// RVA: 0x87CE13C Offset: 0x87CA13C VA: 0x87CE13C
	public static void set_defaultContactOffset(float value) { }

	// RVA: 0x87CE174 Offset: 0x87CA174 VA: 0x87CE174
	public static float get_sleepThreshold() { }

	// RVA: 0x87CE19C Offset: 0x87CA19C VA: 0x87CE19C
	public static void set_sleepThreshold(float value) { }

	// RVA: 0x87CE1D4 Offset: 0x87CA1D4 VA: 0x87CE1D4
	public static bool get_queriesHitTriggers() { }

	// RVA: 0x87CE1FC Offset: 0x87CA1FC VA: 0x87CE1FC
	public static void set_queriesHitTriggers(bool value) { }

	// RVA: 0x87CE238 Offset: 0x87CA238 VA: 0x87CE238
	public static bool get_queriesHitBackfaces() { }

	// RVA: 0x87CE260 Offset: 0x87CA260 VA: 0x87CE260
	public static void set_queriesHitBackfaces(bool value) { }

	// RVA: 0x87CE29C Offset: 0x87CA29C VA: 0x87CE29C
	public static float get_bounceThreshold() { }

	// RVA: 0x87CE2C4 Offset: 0x87CA2C4 VA: 0x87CE2C4
	public static void set_bounceThreshold(float value) { }

	// RVA: 0x87CE2FC Offset: 0x87CA2FC VA: 0x87CE2FC
	public static float get_defaultMaxDepenetrationVelocity() { }

	// RVA: 0x87CE324 Offset: 0x87CA324 VA: 0x87CE324
	public static void set_defaultMaxDepenetrationVelocity(float value) { }

	// RVA: 0x87CE35C Offset: 0x87CA35C VA: 0x87CE35C
	public static int get_defaultSolverIterations() { }

	// RVA: 0x87CE384 Offset: 0x87CA384 VA: 0x87CE384
	public static void set_defaultSolverIterations(int value) { }

	// RVA: 0x87CE3C0 Offset: 0x87CA3C0 VA: 0x87CE3C0
	public static int get_defaultSolverVelocityIterations() { }

	// RVA: 0x87CE3E8 Offset: 0x87CA3E8 VA: 0x87CE3E8
	public static void set_defaultSolverVelocityIterations(int value) { }

	// RVA: 0x87CE424 Offset: 0x87CA424 VA: 0x87CE424
	public static SimulationMode get_simulationMode() { }

	// RVA: 0x87CE44C Offset: 0x87CA44C VA: 0x87CE44C
	public static void set_simulationMode(SimulationMode value) { }

	// RVA: 0x87CE488 Offset: 0x87CA488 VA: 0x87CE488
	public static float get_defaultMaxAngularSpeed() { }

	// RVA: 0x87CE4B0 Offset: 0x87CA4B0 VA: 0x87CE4B0
	public static void set_defaultMaxAngularSpeed(float value) { }

	// RVA: 0x87CE4E8 Offset: 0x87CA4E8 VA: 0x87CE4E8
	public static bool get_improvedPatchFriction() { }

	// RVA: 0x87CE510 Offset: 0x87CA510 VA: 0x87CE510
	public static void set_improvedPatchFriction(bool value) { }

	// RVA: 0x87CE54C Offset: 0x87CA54C VA: 0x87CE54C
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x87CE574 Offset: 0x87CA574 VA: 0x87CE574
	public static void set_invokeCollisionCallbacks(bool value) { }

	// RVA: 0x87CE5B0 Offset: 0x87CA5B0 VA: 0x87CE5B0
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x87CE668 Offset: 0x87CA668 VA: 0x87CE668
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	[ExcludeFromDocs]
	// RVA: 0x87CE6BC Offset: 0x87CA6BC VA: 0x87CE6BC
	public static void IgnoreCollision(Collider collider1, Collider collider2) { }

	[NativeName("IgnoreCollision")]
	// RVA: 0x87CE744 Offset: 0x87CA744 VA: 0x87CE744
	public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore) { }

	[ExcludeFromDocs]
	// RVA: 0x87CE798 Offset: 0x87CA798 VA: 0x87CE798
	public static void IgnoreLayerCollision(int layer1, int layer2) { }

	// RVA: 0x87CE820 Offset: 0x87CA820 VA: 0x87CE820
	public static bool GetIgnoreLayerCollision(int layer1, int layer2) { }

	// RVA: 0x87CE864 Offset: 0x87CA864 VA: 0x87CE864
	public static bool GetIgnoreCollision(Collider collider1, Collider collider2) { }

	// RVA: 0x87CE8A8 Offset: 0x87CA8A8 VA: 0x87CE8A8
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87CEB50 Offset: 0x87CAB50 VA: 0x87CEB50
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87CEC14 Offset: 0x87CAC14 VA: 0x87CEC14
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87CECDC Offset: 0x87CACDC VA: 0x87CECDC
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x87CED94 Offset: 0x87CAD94 VA: 0x87CED94
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x87CF058 Offset: 0x87CB058 VA: 0x87CF058
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF134 Offset: 0x87CB134 VA: 0x87CF134
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF1FC Offset: 0x87CB1FC VA: 0x87CF1FC
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x87CF2C4 Offset: 0x87CB2C4 VA: 0x87CF2C4
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF35C Offset: 0x87CB35C VA: 0x87CF35C
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF3F8 Offset: 0x87CB3F8 VA: 0x87CF3F8
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF480 Offset: 0x87CB480 VA: 0x87CF480
	public static bool Raycast(Ray ray) { }

	// RVA: 0x87CF508 Offset: 0x87CB508 VA: 0x87CF508
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF5B8 Offset: 0x87CB5B8 VA: 0x87CF5B8
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF670 Offset: 0x87CB670 VA: 0x87CF670
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF710 Offset: 0x87CB710 VA: 0x87CF710
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x87CF7A0 Offset: 0x87CB7A0 VA: 0x87CF7A0
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF8BC Offset: 0x87CB8BC VA: 0x87CF8BC
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87CF95C Offset: 0x87CB95C VA: 0x87CF95C
	public static bool Linecast(Vector3 start, Vector3 end) { }

	// RVA: 0x87CF9F8 Offset: 0x87CB9F8 VA: 0x87CF9F8
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87CFB24 Offset: 0x87CBB24 VA: 0x87CFB24
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87CFBD4 Offset: 0x87CBBD4 VA: 0x87CFBD4
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo) { }

	// RVA: 0x87CFC78 Offset: 0x87CBC78 VA: 0x87CFC78
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87CFD8C Offset: 0x87CBD8C VA: 0x87CFD8C
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87CFEA4 Offset: 0x87CBEA4 VA: 0x87CFEA4
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87CFFB8 Offset: 0x87CBFB8 VA: 0x87CFFB8
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction) { }

	// RVA: 0x87D00BC Offset: 0x87CC0BC VA: 0x87D00BC
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D01A0 Offset: 0x87CC1A0 VA: 0x87D01A0
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D02C8 Offset: 0x87CC2C8 VA: 0x87D02C8
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D03E4 Offset: 0x87CC3E4 VA: 0x87D03E4
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x87D04F0 Offset: 0x87CC4F0 VA: 0x87D04F0
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D05CC Offset: 0x87CC5CC VA: 0x87D05CC
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D0694 Offset: 0x87CC694 VA: 0x87D0694
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D0750 Offset: 0x87CC750 VA: 0x87D0750
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x87D080C Offset: 0x87CC80C VA: 0x87D080C
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D08E8 Offset: 0x87CC8E8 VA: 0x87D08E8
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D0998 Offset: 0x87CC998 VA: 0x87D0998
	public static bool SphereCast(Ray ray, float radius, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D0A3C Offset: 0x87CCA3C VA: 0x87D0A3C
	public static bool SphereCast(Ray ray, float radius) { }

	// RVA: 0x87D0AE0 Offset: 0x87CCAE0 VA: 0x87D0AE0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D0BAC Offset: 0x87CCBAC VA: 0x87D0BAC
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D0C64 Offset: 0x87CCC64 VA: 0x87D0C64
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D0D18 Offset: 0x87CCD18 VA: 0x87D0D18
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo) { }

	// RVA: 0x87D0DCC Offset: 0x87CCDCC VA: 0x87D0DCC
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D0EE8 Offset: 0x87CCEE8 VA: 0x87D0EE8
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D100C Offset: 0x87CD00C VA: 0x87D100C
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D112C Offset: 0x87CD12C VA: 0x87D112C
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation) { }

	[ExcludeFromDocs]
	// RVA: 0x87D1230 Offset: 0x87CD230 VA: 0x87D1230
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction) { }

	// RVA: 0x87D132C Offset: 0x87CD32C VA: 0x87D132C
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D1408 Offset: 0x87CD408 VA: 0x87D1408
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D153C Offset: 0x87CD53C VA: 0x87D153C
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D1664 Offset: 0x87CD664 VA: 0x87D1664
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation) { }

	[ExcludeFromDocs]
	// RVA: 0x87D1770 Offset: 0x87CD770 VA: 0x87D1770
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("RaycastAll")]
	// RVA: 0x87D1874 Offset: 0x87CD874 VA: 0x87D1874
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D1988 Offset: 0x87CD988 VA: 0x87D1988
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D1BAC Offset: 0x87CDBAC VA: 0x87D1BAC
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D1C5C Offset: 0x87CDC5C VA: 0x87D1C5C
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D1D08 Offset: 0x87CDD08 VA: 0x87D1D08
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x87D1DAC Offset: 0x87CDDAC VA: 0x87D1DAC
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x87D1E60 Offset: 0x87CDE60 VA: 0x87D1E60
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D1F10 Offset: 0x87CDF10 VA: 0x87D1F10
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D1FB4 Offset: 0x87CDFB4 VA: 0x87D1FB4
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x87D2050 Offset: 0x87CE050 VA: 0x87D2050
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x87D2350 Offset: 0x87CE350 VA: 0x87D2350
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D23E8 Offset: 0x87CE3E8 VA: 0x87D23E8
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D2484 Offset: 0x87CE484 VA: 0x87D2484
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x87D2510 Offset: 0x87CE510 VA: 0x87D2510
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D25E4 Offset: 0x87CE5E4 VA: 0x87D25E4
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D26BC Offset: 0x87CE6BC VA: 0x87D26BC
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D2780 Offset: 0x87CE780 VA: 0x87D2780
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeName("CapsuleCastAll")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x87D2844 Offset: 0x87CE844 VA: 0x87D2844
	private static RaycastHit[] Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D29AC Offset: 0x87CE9AC VA: 0x87D29AC
	public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D2B30 Offset: 0x87CEB30 VA: 0x87D2B30
	public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D2C48 Offset: 0x87CEC48 VA: 0x87D2C48
	public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D2D5C Offset: 0x87CED5C VA: 0x87D2D5C
	public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("SphereCastAll")]
	// RVA: 0x87D2E5C Offset: 0x87CEE5C VA: 0x87D2E5C
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D2FA8 Offset: 0x87CEFA8 VA: 0x87D2FA8
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D3110 Offset: 0x87CF110 VA: 0x87D3110
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D31C8 Offset: 0x87CF1C8 VA: 0x87D31C8
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D327C Offset: 0x87CF27C VA: 0x87D327C
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction) { }

	// RVA: 0x87D3330 Offset: 0x87CF330 VA: 0x87D3330
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D33EC Offset: 0x87CF3EC VA: 0x87D33EC
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D3498 Offset: 0x87CF498 VA: 0x87D3498
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D3538 Offset: 0x87CF538 VA: 0x87D3538
	public static RaycastHit[] SphereCastAll(Ray ray, float radius) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("OverlapCapsule")]
	// RVA: 0x87D35D8 Offset: 0x87CF5D8 VA: 0x87D35D8
	private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D3714 Offset: 0x87CF714 VA: 0x87D3714
	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D37D8 Offset: 0x87CF7D8 VA: 0x87D37D8
	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D3888 Offset: 0x87CF888 VA: 0x87D3888
	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("OverlapSphere")]
	// RVA: 0x87D3934 Offset: 0x87CF934 VA: 0x87D3934
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D3A54 Offset: 0x87CFA54 VA: 0x87D3A54
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D3AF0 Offset: 0x87CFAF0 VA: 0x87D3AF0
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D3B78 Offset: 0x87CFB78 VA: 0x87D3B78
	public static Collider[] OverlapSphere(Vector3 position, float radius) { }

	[NativeName("Simulate")]
	// RVA: 0x87D3BFC Offset: 0x87CFBFC VA: 0x87D3BFC
	internal static void Simulate_Internal(PhysicsScene physicsScene, float step) { }

	// RVA: 0x87D3CD8 Offset: 0x87CFCD8 VA: 0x87D3CD8
	public static void Simulate(float step) { }

	[NativeName("InterpolateBodies")]
	// RVA: 0x87D3DC8 Offset: 0x87CFDC8 VA: 0x87D3DC8
	internal static void InterpolateBodies_Internal(PhysicsScene physicsScene) { }

	[NativeName("ResetInterpolatedTransformPosition")]
	// RVA: 0x87D3E7C Offset: 0x87CFE7C VA: 0x87D3E7C
	internal static void ResetInterpolationPoses_Internal(PhysicsScene physicsScene) { }

	// RVA: 0x87D3F30 Offset: 0x87CFF30 VA: 0x87D3F30
	public static void SyncTransforms() { }

	// RVA: 0x87D3F58 Offset: 0x87CFF58 VA: 0x87D3F58
	public static bool get_autoSyncTransforms() { }

	// RVA: 0x87D3F80 Offset: 0x87CFF80 VA: 0x87D3F80
	public static void set_autoSyncTransforms(bool value) { }

	// RVA: 0x87D3FBC Offset: 0x87CFFBC VA: 0x87D3FBC
	public static bool get_reuseCollisionCallbacks() { }

	// RVA: 0x87D3FE4 Offset: 0x87CFFE4 VA: 0x87D3FE4
	public static void set_reuseCollisionCallbacks(bool value) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("ComputePenetration")]
	// RVA: 0x87D4020 Offset: 0x87D0020 VA: 0x87D4020
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x87D4190 Offset: 0x87D0190 VA: 0x87D4190
	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("ClosestPoint")]
	// RVA: 0x87D42B8 Offset: 0x87D02B8 VA: 0x87D42B8
	private static Vector3 Query_ClosestPoint(Collider collider, Vector3 position, Quaternion rotation, Vector3 point) { }

	// RVA: 0x87D43E4 Offset: 0x87D03E4 VA: 0x87D43E4
	public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation) { }

	[NativeName("GetClothInterCollisionDistance")]
	// RVA: 0x87D44AC Offset: 0x87D04AC VA: 0x87D44AC
	public static float get_interCollisionDistance() { }

	[NativeName("SetClothInterCollisionDistance")]
	// RVA: 0x87D44D4 Offset: 0x87D04D4 VA: 0x87D44D4
	public static void set_interCollisionDistance(float value) { }

	[NativeName("GetClothInterCollisionStiffness")]
	// RVA: 0x87D450C Offset: 0x87D050C VA: 0x87D450C
	public static float get_interCollisionStiffness() { }

	[NativeName("SetClothInterCollisionStiffness")]
	// RVA: 0x87D4534 Offset: 0x87D0534 VA: 0x87D4534
	public static void set_interCollisionStiffness(float value) { }

	[NativeName("GetClothInterCollisionSettingsToggle")]
	// RVA: 0x87D456C Offset: 0x87D056C VA: 0x87D456C
	public static bool get_interCollisionSettingsToggle() { }

	[NativeName("SetClothInterCollisionSettingsToggle")]
	// RVA: 0x87D4594 Offset: 0x87D0594 VA: 0x87D4594
	public static void set_interCollisionSettingsToggle(bool value) { }

	[ThreadSafe]
	// RVA: 0x87D45D0 Offset: 0x87D05D0 VA: 0x87D45D0
	public static Vector3 get_clothGravity() { }

	// RVA: 0x87D4698 Offset: 0x87D0698 VA: 0x87D4698
	public static void set_clothGravity(Vector3 value) { }

	// RVA: 0x87D4758 Offset: 0x87D0758 VA: 0x87D4758
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D4804 Offset: 0x87D0804 VA: 0x87D4804
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D489C Offset: 0x87D089C VA: 0x87D489C
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("SphereTest")]
	// RVA: 0x87D4928 Offset: 0x87D0928 VA: 0x87D4928
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D4A4C Offset: 0x87D0A4C VA: 0x87D4A4C
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D4AE8 Offset: 0x87D0AE8 VA: 0x87D4AE8
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D4B70 Offset: 0x87D0B70 VA: 0x87D4B70
	public static bool CheckSphere(Vector3 position, float radius) { }

	// RVA: 0x87D4BF4 Offset: 0x87D0BF4 VA: 0x87D4BF4
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D4E14 Offset: 0x87D0E14 VA: 0x87D4E14
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D4F3C Offset: 0x87D0F3C VA: 0x87D4F3C
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D5058 Offset: 0x87D1058 VA: 0x87D5058
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0x87D5160 Offset: 0x87D1160 VA: 0x87D5160
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D5364 Offset: 0x87D1364 VA: 0x87D5364
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D542C Offset: 0x87D142C VA: 0x87D542C
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D54E8 Offset: 0x87D14E8 VA: 0x87D54E8
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0x87D55A4 Offset: 0x87D15A4 VA: 0x87D55A4
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D5670 Offset: 0x87D1670 VA: 0x87D5670
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D5724 Offset: 0x87D1724 VA: 0x87D5724
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D57D4 Offset: 0x87D17D4 VA: 0x87D57D4
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results) { }

	[NativeName("CapsuleTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x87D5884 Offset: 0x87D1884 VA: 0x87D5884
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D59C4 Offset: 0x87D19C4 VA: 0x87D59C4
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D5A88 Offset: 0x87D1A88 VA: 0x87D5A88
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D5B38 Offset: 0x87D1B38 VA: 0x87D5B38
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius) { }

	[NativeName("BoxTest")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x87D5BE4 Offset: 0x87D1BE4 VA: 0x87D5BE4
	private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D5D18 Offset: 0x87D1D18 VA: 0x87D5D18
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D5DDC Offset: 0x87D1DDC VA: 0x87D5DDC
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D5EDC Offset: 0x87D1EDC VA: 0x87D5EDC
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation) { }

	[ExcludeFromDocs]
	// RVA: 0x87D5FD0 Offset: 0x87D1FD0 VA: 0x87D5FD0
	public static bool CheckBox(Vector3 center, Vector3 halfExtents) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("OverlapBox")]
	// RVA: 0x87D60BC Offset: 0x87D20BC VA: 0x87D60BC
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D61EC Offset: 0x87D21EC VA: 0x87D61EC
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D62B0 Offset: 0x87D22B0 VA: 0x87D62B0
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D63B0 Offset: 0x87D23B0 VA: 0x87D63B0
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation) { }

	[ExcludeFromDocs]
	// RVA: 0x87D64A4 Offset: 0x87D24A4 VA: 0x87D64A4
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents) { }

	// RVA: 0x87D658C Offset: 0x87D258C VA: 0x87D658C
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D667C Offset: 0x87D267C VA: 0x87D667C
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D6784 Offset: 0x87D2784 VA: 0x87D6784
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation) { }

	[ExcludeFromDocs]
	// RVA: 0x87D6888 Offset: 0x87D2888 VA: 0x87D6888
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results) { }

	// RVA: 0x87D6978 Offset: 0x87D2978 VA: 0x87D6978
	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D6B88 Offset: 0x87D2B88 VA: 0x87D6B88
	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation) { }

	[ExcludeFromDocs]
	// RVA: 0x87D6C90 Offset: 0x87D2C90 VA: 0x87D6C90
	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D6DB8 Offset: 0x87D2DB8 VA: 0x87D6DB8
	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D6EEC Offset: 0x87D2EEC VA: 0x87D6EEC
	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results) { }

	[NativeName("BoxCastAll")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x87D6FEC Offset: 0x87D2FEC VA: 0x87D6FEC
	private static RaycastHit[] Internal_BoxCastAll(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D7160 Offset: 0x87D3160 VA: 0x87D7160
	public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D7310 Offset: 0x87D3310 VA: 0x87D7310
	public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D7434 Offset: 0x87D3434 VA: 0x87D7434
	public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87D7554 Offset: 0x87D3554 VA: 0x87D7554
	public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation) { }

	[ExcludeFromDocs]
	// RVA: 0x87D7654 Offset: 0x87D3654 VA: 0x87D7654
	public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction) { }

	// RVA: 0x87D774C Offset: 0x87D374C VA: 0x87D774C
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87D7820 Offset: 0x87D3820 VA: 0x87D7820
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87D78E0 Offset: 0x87D38E0 VA: 0x87D78E0
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results) { }

	[StaticAccessor("GetPhysicsManager()")]
	[NativeName("RebuildBroadphaseRegions")]
	// RVA: 0x87D7994 Offset: 0x87D3994 VA: 0x87D7994
	private static void Internal_RebuildBroadphaseRegions(Bounds bounds, int subdivisions) { }

	// RVA: 0x87D7A5C Offset: 0x87D3A5C VA: 0x87D7A5C
	public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions) { }

	[StaticAccessor("GetPhysicsManager()")]
	[ThreadSafe]
	// RVA: 0x87D7B7C Offset: 0x87D3B7C VA: 0x87D7B7C
	public static void BakeMesh(int meshID, bool convex, MeshColliderCookingOptions cookingOptions) { }

	// RVA: 0x87D7BD0 Offset: 0x87D3BD0 VA: 0x87D7BD0
	public static void BakeMesh(int meshID, bool convex) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7C58 Offset: 0x87D3C58 VA: 0x87D7C58
	internal static Collider ResolveShapeToCollider(IntPtr shapePtr) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7C94 Offset: 0x87D3C94 VA: 0x87D7C94
	internal static Component ResolveActorToComponent(IntPtr actorPtr) { }

	[ThreadSafe]
	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7CD0 Offset: 0x87D3CD0 VA: 0x87D7CD0
	internal static int ResolveShapeToInstanceID(IntPtr shapePtr) { }

	[StaticAccessor("PhysicsManager", 2)]
	[ThreadSafe]
	// RVA: 0x87D7D0C Offset: 0x87D3D0C VA: 0x87D7D0C
	internal static int ResolveActorToInstanceID(IntPtr actorPtr) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7D48 Offset: 0x87D3D48 VA: 0x87D7D48
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7D84 Offset: 0x87D3D84 VA: 0x87D7D84
	internal static Component GetBodyByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", 2)]
	[ThreadSafe]
	// RVA: 0x87D7DC0 Offset: 0x87D3DC0 VA: 0x87D7DC0
	internal static uint TranslateTriangleIndex(IntPtr shapePtr, uint rawIndex) { }

	[ThreadSafe]
	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7E04 Offset: 0x87D3E04 VA: 0x87D7E04
	internal static uint TranslateTriangleIndexFromID(int instanceID, uint faceIndex) { }

	[ThreadSafe]
	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7E48 Offset: 0x87D3E48 VA: 0x87D7E48
	internal static bool IsShapeTrigger(IntPtr shapePtr) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7E84 Offset: 0x87D3E84 VA: 0x87D7E84
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7EC8 Offset: 0x87D3EC8 VA: 0x87D7EC8
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7F0C Offset: 0x87D3F0C VA: 0x87D7F0C
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[ThreadSafe]
	[StaticAccessor("PhysicsManager", 2)]
	// RVA: 0x87D7F50 Offset: 0x87D3F50 VA: 0x87D7F50
	internal static Vector3 GetActorLinearVelocity(IntPtr actorPtr) { }

	[StaticAccessor("PhysicsManager", 2)]
	[ThreadSafe]
	// RVA: 0x87D8028 Offset: 0x87D4028 VA: 0x87D8028
	internal static Vector3 GetActorAngularVelocity(IntPtr actorPtr) { }

	// RVA: 0x87D8100 Offset: 0x87D4100 VA: 0x87D8100
	public static float get_minPenetrationForPenalty() { }

	// RVA: 0x87D8108 Offset: 0x87D4108 VA: 0x87D8108
	public static void set_minPenetrationForPenalty(float value) { }

	// RVA: 0x87D810C Offset: 0x87D410C VA: 0x87D810C
	public static float get_bounceTreshold() { }

	// RVA: 0x87D8174 Offset: 0x87D4174 VA: 0x87D8174
	public static void set_bounceTreshold(float value) { }

	// RVA: 0x87D81EC Offset: 0x87D41EC VA: 0x87D81EC
	public static float get_sleepVelocity() { }

	// RVA: 0x87D81F4 Offset: 0x87D41F4 VA: 0x87D81F4
	public static void set_sleepVelocity(float value) { }

	// RVA: 0x87D81F8 Offset: 0x87D41F8 VA: 0x87D81F8
	public static float get_sleepAngularVelocity() { }

	// RVA: 0x87D8200 Offset: 0x87D4200 VA: 0x87D8200
	public static void set_sleepAngularVelocity(float value) { }

	// RVA: 0x87D8204 Offset: 0x87D4204 VA: 0x87D8204
	public static float get_maxAngularVelocity() { }

	// RVA: 0x87D820C Offset: 0x87D420C VA: 0x87D820C
	public static void set_maxAngularVelocity(float value) { }

	// RVA: 0x87D8210 Offset: 0x87D4210 VA: 0x87D8210
	public static int get_solverIterationCount() { }

	// RVA: 0x87D8278 Offset: 0x87D4278 VA: 0x87D8278
	public static void set_solverIterationCount(int value) { }

	// RVA: 0x87D82EC Offset: 0x87D42EC VA: 0x87D82EC
	public static int get_solverVelocityIterationCount() { }

	// RVA: 0x87D8354 Offset: 0x87D4354 VA: 0x87D8354
	public static void set_solverVelocityIterationCount(int value) { }

	// RVA: 0x87D83C8 Offset: 0x87D43C8 VA: 0x87D83C8
	public static float get_penetrationPenaltyForce() { }

	// RVA: 0x87D83D0 Offset: 0x87D43D0 VA: 0x87D83D0
	public static void set_penetrationPenaltyForce(float value) { }

	// RVA: 0x87D83D4 Offset: 0x87D43D4 VA: 0x87D83D4
	public static bool get_autoSimulation() { }

	// RVA: 0x87D844C Offset: 0x87D444C VA: 0x87D844C
	public static void set_autoSimulation(bool value) { }

	[CompilerGenerated]
	// RVA: 0x87D84C8 Offset: 0x87D44C8 VA: 0x87D84C8
	public static void add_ContactEvent(Physics.ContactEventDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x87D85A4 Offset: 0x87D45A4 VA: 0x87D85A4
	public static void remove_ContactEvent(Physics.ContactEventDelegate value) { }

	[RequiredByNativeCode]
	// RVA: 0x87D8680 Offset: 0x87D4680 VA: 0x87D8680
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x87D88D8 Offset: 0x87D48D8 VA: 0x87D88D8
	private static void ReportContacts(NativeArray.ReadOnly<ContactPairHeader> array) { }

	// RVA: 0x87D8CD8 Offset: 0x87D4CD8 VA: 0x87D8CD8
	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x87D8E20 Offset: 0x87D4E20 VA: 0x87D8E20
	public void .ctor() { }

	// RVA: 0x87D8E28 Offset: 0x87D4E28 VA: 0x87D8E28
	private static void .cctor() { }

	// RVA: 0x87CE018 Offset: 0x87CA018 VA: 0x87CE018
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x87CE0D8 Offset: 0x87CA0D8 VA: 0x87CE0D8
	private static void set_gravity_Injected(ref Vector3 value) { }

	// RVA: 0x87CE62C Offset: 0x87CA62C VA: 0x87CE62C
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x87D191C Offset: 0x87CD91C VA: 0x87D191C
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D2920 Offset: 0x87CE920 VA: 0x87D2920
	private static RaycastHit[] Query_CapsuleCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D2F24 Offset: 0x87CEF24 VA: 0x87D2F24
	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D3698 Offset: 0x87CF698 VA: 0x87D3698
	private static Collider[] OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D39E8 Offset: 0x87CF9E8 VA: 0x87D39E8
	private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D3C8C Offset: 0x87CFC8C VA: 0x87D3C8C
	private static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step) { }

	// RVA: 0x87D3E40 Offset: 0x87CFE40 VA: 0x87D3E40
	private static void InterpolateBodies_Internal_Injected(ref PhysicsScene physicsScene) { }

	// RVA: 0x87D3EF4 Offset: 0x87CFEF4 VA: 0x87D3EF4
	private static void ResetInterpolationPoses_Internal_Injected(ref PhysicsScene physicsScene) { }

	// RVA: 0x87D4104 Offset: 0x87D0104 VA: 0x87D4104
	private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x87D4378 Offset: 0x87D0378 VA: 0x87D4378
	private static void Query_ClosestPoint_Injected(Collider collider, ref Vector3 position, ref Quaternion rotation, ref Vector3 point, out Vector3 ret) { }

	// RVA: 0x87D465C Offset: 0x87D065C VA: 0x87D465C
	private static void get_clothGravity_Injected(out Vector3 ret) { }

	// RVA: 0x87D471C Offset: 0x87D071C VA: 0x87D471C
	private static void set_clothGravity_Injected(ref Vector3 value) { }

	// RVA: 0x87D49E0 Offset: 0x87D09E0 VA: 0x87D49E0
	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D5948 Offset: 0x87D1948 VA: 0x87D5948
	private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D5CA4 Offset: 0x87D1CA4 VA: 0x87D5CA4
	private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D6178 Offset: 0x87D2178 VA: 0x87D6178
	private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D70CC Offset: 0x87D30CC VA: 0x87D70CC
	private static RaycastHit[] Internal_BoxCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D7A18 Offset: 0x87D3A18 VA: 0x87D7A18
	private static void Internal_RebuildBroadphaseRegions_Injected(ref Bounds bounds, int subdivisions) { }

	// RVA: 0x87D7FE4 Offset: 0x87D3FE4 VA: 0x87D7FE4
	private static void GetActorLinearVelocity_Injected(IntPtr actorPtr, out Vector3 ret) { }

	// RVA: 0x87D80BC Offset: 0x87D40BC VA: 0x87D80BC
	private static void GetActorAngularVelocity_Injected(IntPtr actorPtr, out Vector3 ret) { }
}

// Namespace: UnityEngine
public struct ModifiableContactPair // TypeDefIndex: 27542
{
	// Fields
	private IntPtr actor; // 0x0
	private IntPtr otherActor; // 0x8
	private IntPtr shape; // 0x10
	private IntPtr otherShape; // 0x18
	public Quaternion rotation; // 0x20
	public Vector3 position; // 0x30
	public Quaternion otherRotation; // 0x3C
	public Vector3 otherPosition; // 0x4C
	private int numContacts; // 0x58
	private IntPtr contacts; // 0x60
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/PhysicMaterial.h")]
public class PhysicMaterial : Object // TypeDefIndex: 27543
{
	// Methods

	// RVA: 0x87D8F50 Offset: 0x87D4F50 VA: 0x87D8F50
	public void .ctor() { }

	// RVA: 0x87D8FEC Offset: 0x87D4FEC VA: 0x87D8FEC
	private static void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Interfaces/IRaycast.h")]
[NativeHeader("PhysicsScriptingClasses.h")]
[NativeHeader("Modules/Physics/RaycastHit.h")]
[UsedByNativeCode]
public struct RaycastHit // TypeDefIndex: 27544
{
	// Fields
	[NativeName("point")]
	internal Vector3 m_Point; // 0x0
	[NativeName("normal")]
	internal Vector3 m_Normal; // 0xC
	[NativeName("faceID")]
	internal uint m_FaceID; // 0x18
	[NativeName("distance")]
	internal float m_Distance; // 0x1C
	[NativeName("uv")]
	internal Vector2 m_UV; // 0x20
	[NativeName("collider")]
	internal int m_Collider; // 0x28

	// Properties
	public Collider collider { get; }
	public int colliderInstanceID { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; set; }
	public Vector3 barycentricCoordinate { get; set; }
	public float distance { get; set; }
	public int triangleIndex { get; }
	public Vector2 textureCoord { get; }
	public Vector2 textureCoord2 { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }
	public ArticulationBody articulationBody { get; }
	public Vector2 lightmapCoord { get; }
	[EditorBrowsable(1)]
	[Obsolete("Use textureCoord2 instead. (UnityUpgradable) -> textureCoord2")]
	public Vector2 textureCoord1 { get; }

	// Methods

	// RVA: 0x87D9030 Offset: 0x87D5030 VA: 0x87D9030
	public Collider get_collider() { }

	// RVA: 0x87D90DC Offset: 0x87D50DC VA: 0x87D90DC
	public int get_colliderInstanceID() { }

	// RVA: 0x87D90E4 Offset: 0x87D50E4 VA: 0x87D90E4
	public Vector3 get_point() { }

	// RVA: 0x87D90F0 Offset: 0x87D50F0 VA: 0x87D90F0
	public void set_point(Vector3 value) { }

	// RVA: 0x87D90FC Offset: 0x87D50FC VA: 0x87D90FC
	public Vector3 get_normal() { }

	// RVA: 0x87D9108 Offset: 0x87D5108 VA: 0x87D9108
	public void set_normal(Vector3 value) { }

	// RVA: 0x87D9114 Offset: 0x87D5114 VA: 0x87D9114
	public Vector3 get_barycentricCoordinate() { }

	// RVA: 0x87D9128 Offset: 0x87D5128 VA: 0x87D9128
	public void set_barycentricCoordinate(Vector3 value) { }

	// RVA: 0x87D9130 Offset: 0x87D5130 VA: 0x87D9130
	public float get_distance() { }

	// RVA: 0x87D9138 Offset: 0x87D5138 VA: 0x87D9138
	public void set_distance(float value) { }

	// RVA: 0x87D9140 Offset: 0x87D5140 VA: 0x87D9140
	public int get_triangleIndex() { }

	[NativeMethod("CalculateRaycastTexCoord", True, True)]
	// RVA: 0x87D9148 Offset: 0x87D5148 VA: 0x87D9148
	private static Vector2 CalculateRaycastTexCoord(int colliderInstanceID, Vector2 uv, Vector3 pos, uint face, int textcoord) { }

	// RVA: 0x87D923C Offset: 0x87D523C VA: 0x87D923C
	public Vector2 get_textureCoord() { }

	// RVA: 0x87D925C Offset: 0x87D525C VA: 0x87D925C
	public Vector2 get_textureCoord2() { }

	// RVA: 0x87D927C Offset: 0x87D527C VA: 0x87D927C
	public Transform get_transform() { }

	// RVA: 0x87D9358 Offset: 0x87D5358 VA: 0x87D9358
	public Rigidbody get_rigidbody() { }

	// RVA: 0x87D9450 Offset: 0x87D5450 VA: 0x87D9450
	public ArticulationBody get_articulationBody() { }

	// RVA: 0x87D9548 Offset: 0x87D5548 VA: 0x87D9548
	public Vector2 get_lightmapCoord() { }

	// RVA: 0x87D9644 Offset: 0x87D5644 VA: 0x87D9644
	public Vector2 get_textureCoord1() { }

	// RVA: 0x87D91C8 Offset: 0x87D51C8 VA: 0x87D91C8
	private static void CalculateRaycastTexCoord_Injected(int colliderInstanceID, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component // TypeDefIndex: 27545
{
	// Properties
	public Vector3 velocity { get; set; }
	public Vector3 angularVelocity { get; set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public float mass { get; set; }
	public bool useGravity { get; set; }
	public float maxDepenetrationVelocity { get; set; }
	public bool isKinematic { get; set; }
	public bool freezeRotation { get; set; }
	public RigidbodyConstraints constraints { get; set; }
	public CollisionDetectionMode collisionDetectionMode { get; set; }
	public bool automaticCenterOfMass { get; set; }
	public Vector3 centerOfMass { get; set; }
	public Vector3 worldCenterOfMass { get; }
	public bool automaticInertiaTensor { get; set; }
	public Quaternion inertiaTensorRotation { get; set; }
	public Vector3 inertiaTensor { get; set; }
	public bool detectCollisions { get; set; }
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public RigidbodyInterpolation interpolation { get; set; }
	public int solverIterations { get; set; }
	public float sleepThreshold { get; set; }
	public float maxAngularVelocity { get; set; }
	public float maxLinearVelocity { get; set; }
	public int solverVelocityIterations { get; set; }
	public LayerMask excludeLayers { get; set; }
	public LayerMask includeLayers { get; set; }
	[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", True)]
	[EditorBrowsable(1)]
	public float sleepVelocity { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold to specify energy.", True)]
	public float sleepAngularVelocity { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Cone friction is no longer supported.", True)]
	public bool useConeFriction { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Please use Rigidbody.solverIterations instead. (UnityUpgradable) -> solverIterations")]
	public int solverIterationCount { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Please use Rigidbody.solverVelocityIterations instead. (UnityUpgradable) -> solverVelocityIterations")]
	public int solverVelocityIterationCount { get; set; }

	// Methods

	// RVA: 0x87D9648 Offset: 0x87D5648 VA: 0x87D9648
	public Vector3 get_velocity() { }

	// RVA: 0x87D96E8 Offset: 0x87D56E8 VA: 0x87D96E8
	public void set_velocity(Vector3 value) { }

	// RVA: 0x87D9780 Offset: 0x87D5780 VA: 0x87D9780
	public Vector3 get_angularVelocity() { }

	// RVA: 0x87D9820 Offset: 0x87D5820 VA: 0x87D9820
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x87D98B8 Offset: 0x87D58B8 VA: 0x87D98B8
	public float get_drag() { }

	// RVA: 0x87D98F4 Offset: 0x87D58F4 VA: 0x87D98F4
	public void set_drag(float value) { }

	// RVA: 0x87D9940 Offset: 0x87D5940 VA: 0x87D9940
	public float get_angularDrag() { }

	// RVA: 0x87D997C Offset: 0x87D597C VA: 0x87D997C
	public void set_angularDrag(float value) { }

	// RVA: 0x87D99C8 Offset: 0x87D59C8 VA: 0x87D99C8
	public float get_mass() { }

	// RVA: 0x87D9A04 Offset: 0x87D5A04 VA: 0x87D9A04
	public void set_mass(float value) { }

	// RVA: 0x87D9A50 Offset: 0x87D5A50 VA: 0x87D9A50
	public void SetDensity(float density) { }

	// RVA: 0x87D9A9C Offset: 0x87D5A9C VA: 0x87D9A9C
	public bool get_useGravity() { }

	// RVA: 0x87D9AD8 Offset: 0x87D5AD8 VA: 0x87D9AD8
	public void set_useGravity(bool value) { }

	// RVA: 0x87D9B1C Offset: 0x87D5B1C VA: 0x87D9B1C
	public float get_maxDepenetrationVelocity() { }

	// RVA: 0x87D9B58 Offset: 0x87D5B58 VA: 0x87D9B58
	public void set_maxDepenetrationVelocity(float value) { }

	// RVA: 0x87D9BA4 Offset: 0x87D5BA4 VA: 0x87D9BA4
	public bool get_isKinematic() { }

	// RVA: 0x87D9BE0 Offset: 0x87D5BE0 VA: 0x87D9BE0
	public void set_isKinematic(bool value) { }

	// RVA: 0x87D9C24 Offset: 0x87D5C24 VA: 0x87D9C24
	public bool get_freezeRotation() { }

	// RVA: 0x87D9C60 Offset: 0x87D5C60 VA: 0x87D9C60
	public void set_freezeRotation(bool value) { }

	// RVA: 0x87D9CA4 Offset: 0x87D5CA4 VA: 0x87D9CA4
	public RigidbodyConstraints get_constraints() { }

	// RVA: 0x87D9CE0 Offset: 0x87D5CE0 VA: 0x87D9CE0
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x87D9D24 Offset: 0x87D5D24 VA: 0x87D9D24
	public CollisionDetectionMode get_collisionDetectionMode() { }

	// RVA: 0x87D9D60 Offset: 0x87D5D60 VA: 0x87D9D60
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x87D9DA4 Offset: 0x87D5DA4 VA: 0x87D9DA4
	public bool get_automaticCenterOfMass() { }

	// RVA: 0x87D9DE0 Offset: 0x87D5DE0 VA: 0x87D9DE0
	public void set_automaticCenterOfMass(bool value) { }

	// RVA: 0x87D9E24 Offset: 0x87D5E24 VA: 0x87D9E24
	public Vector3 get_centerOfMass() { }

	// RVA: 0x87D9EC4 Offset: 0x87D5EC4 VA: 0x87D9EC4
	public void set_centerOfMass(Vector3 value) { }

	// RVA: 0x87D9F5C Offset: 0x87D5F5C VA: 0x87D9F5C
	public Vector3 get_worldCenterOfMass() { }

	// RVA: 0x87D9FFC Offset: 0x87D5FFC VA: 0x87D9FFC
	public bool get_automaticInertiaTensor() { }

	// RVA: 0x87DA038 Offset: 0x87D6038 VA: 0x87DA038
	public void set_automaticInertiaTensor(bool value) { }

	// RVA: 0x87DA07C Offset: 0x87D607C VA: 0x87DA07C
	public Quaternion get_inertiaTensorRotation() { }

	// RVA: 0x87DA118 Offset: 0x87D6118 VA: 0x87DA118
	public void set_inertiaTensorRotation(Quaternion value) { }

	// RVA: 0x87DA1B0 Offset: 0x87D61B0 VA: 0x87DA1B0
	public Vector3 get_inertiaTensor() { }

	// RVA: 0x87DA250 Offset: 0x87D6250 VA: 0x87DA250
	public void set_inertiaTensor(Vector3 value) { }

	// RVA: 0x87DA2E8 Offset: 0x87D62E8 VA: 0x87DA2E8
	public bool get_detectCollisions() { }

	// RVA: 0x87DA324 Offset: 0x87D6324 VA: 0x87DA324
	public void set_detectCollisions(bool value) { }

	// RVA: 0x87DA368 Offset: 0x87D6368 VA: 0x87DA368
	public Vector3 get_position() { }

	// RVA: 0x87DA408 Offset: 0x87D6408 VA: 0x87DA408
	public void set_position(Vector3 value) { }

	// RVA: 0x87DA4A0 Offset: 0x87D64A0 VA: 0x87DA4A0
	public Quaternion get_rotation() { }

	// RVA: 0x87DA53C Offset: 0x87D653C VA: 0x87DA53C
	public void set_rotation(Quaternion value) { }

	// RVA: 0x87DA5D4 Offset: 0x87D65D4 VA: 0x87DA5D4
	public RigidbodyInterpolation get_interpolation() { }

	// RVA: 0x87DA610 Offset: 0x87D6610 VA: 0x87DA610
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x87DA654 Offset: 0x87D6654 VA: 0x87DA654
	public int get_solverIterations() { }

	// RVA: 0x87DA690 Offset: 0x87D6690 VA: 0x87DA690
	public void set_solverIterations(int value) { }

	// RVA: 0x87DA6D4 Offset: 0x87D66D4 VA: 0x87DA6D4
	public float get_sleepThreshold() { }

	// RVA: 0x87DA710 Offset: 0x87D6710 VA: 0x87DA710
	public void set_sleepThreshold(float value) { }

	// RVA: 0x87DA75C Offset: 0x87D675C VA: 0x87DA75C
	public float get_maxAngularVelocity() { }

	// RVA: 0x87DA798 Offset: 0x87D6798 VA: 0x87DA798
	public void set_maxAngularVelocity(float value) { }

	// RVA: 0x87DA7E4 Offset: 0x87D67E4 VA: 0x87DA7E4
	public float get_maxLinearVelocity() { }

	// RVA: 0x87DA820 Offset: 0x87D6820 VA: 0x87DA820
	public void set_maxLinearVelocity(float value) { }

	// RVA: 0x87DA86C Offset: 0x87D686C VA: 0x87DA86C
	public void MovePosition(Vector3 position) { }

	// RVA: 0x87DA904 Offset: 0x87D6904 VA: 0x87DA904
	public void MoveRotation(Quaternion rot) { }

	// RVA: 0x87DA99C Offset: 0x87D699C VA: 0x87DA99C
	public void Move(Vector3 position, Quaternion rotation) { }

	// RVA: 0x87DAA50 Offset: 0x87D6A50 VA: 0x87DAA50
	public void Sleep() { }

	// RVA: 0x87DAA8C Offset: 0x87D6A8C VA: 0x87DAA8C
	public bool IsSleeping() { }

	// RVA: 0x87DAAC8 Offset: 0x87D6AC8 VA: 0x87DAAC8
	public void WakeUp() { }

	// RVA: 0x87DAB04 Offset: 0x87D6B04 VA: 0x87DAB04
	public void ResetCenterOfMass() { }

	// RVA: 0x87DAB40 Offset: 0x87D6B40 VA: 0x87DAB40
	public void ResetInertiaTensor() { }

	// RVA: 0x87DAB7C Offset: 0x87D6B7C VA: 0x87DAB7C
	public Vector3 GetRelativePointVelocity(Vector3 relativePoint) { }

	// RVA: 0x87DAC38 Offset: 0x87D6C38 VA: 0x87DAC38
	public Vector3 GetPointVelocity(Vector3 worldPoint) { }

	// RVA: 0x87DACF4 Offset: 0x87D6CF4 VA: 0x87DACF4
	public int get_solverVelocityIterations() { }

	// RVA: 0x87DAD30 Offset: 0x87D6D30 VA: 0x87DAD30
	public void set_solverVelocityIterations(int value) { }

	// RVA: 0x87DAD74 Offset: 0x87D6D74 VA: 0x87DAD74
	public LayerMask get_excludeLayers() { }

	// RVA: 0x87DAE04 Offset: 0x87D6E04 VA: 0x87DAE04
	public void set_excludeLayers(LayerMask value) { }

	// RVA: 0x87DAE90 Offset: 0x87D6E90 VA: 0x87DAE90
	public LayerMask get_includeLayers() { }

	// RVA: 0x87DAF20 Offset: 0x87D6F20 VA: 0x87DAF20
	public void set_includeLayers(LayerMask value) { }

	// RVA: 0x87DAFAC Offset: 0x87D6FAC VA: 0x87DAFAC
	public Vector3 GetAccumulatedForce(float step) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB06C Offset: 0x87D706C VA: 0x87DB06C
	public Vector3 GetAccumulatedForce() { }

	// RVA: 0x87DB088 Offset: 0x87D7088 VA: 0x87DB088
	public Vector3 GetAccumulatedTorque(float step) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB148 Offset: 0x87D7148 VA: 0x87DB148
	public Vector3 GetAccumulatedTorque() { }

	// RVA: 0x87DB164 Offset: 0x87D7164 VA: 0x87DB164
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB214 Offset: 0x87D7214 VA: 0x87DB214
	public void AddForce(Vector3 force) { }

	// RVA: 0x87DB21C Offset: 0x87D721C VA: 0x87DB21C
	public void AddForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB220 Offset: 0x87D7220 VA: 0x87DB220
	public void AddForce(float x, float y, float z) { }

	// RVA: 0x87DB228 Offset: 0x87D7228 VA: 0x87DB228
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB2D8 Offset: 0x87D72D8 VA: 0x87DB2D8
	public void AddRelativeForce(Vector3 force) { }

	// RVA: 0x87DB2E0 Offset: 0x87D72E0 VA: 0x87DB2E0
	public void AddRelativeForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB2E4 Offset: 0x87D72E4 VA: 0x87DB2E4
	public void AddRelativeForce(float x, float y, float z) { }

	// RVA: 0x87DB2EC Offset: 0x87D72EC VA: 0x87DB2EC
	public void AddTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB39C Offset: 0x87D739C VA: 0x87DB39C
	public void AddTorque(Vector3 torque) { }

	// RVA: 0x87DB3A4 Offset: 0x87D73A4 VA: 0x87DB3A4
	public void AddTorque(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB3A8 Offset: 0x87D73A8 VA: 0x87DB3A8
	public void AddTorque(float x, float y, float z) { }

	// RVA: 0x87DB3B0 Offset: 0x87D73B0 VA: 0x87DB3B0
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB460 Offset: 0x87D7460 VA: 0x87DB460
	public void AddRelativeTorque(Vector3 torque) { }

	// RVA: 0x87DB468 Offset: 0x87D7468 VA: 0x87DB468
	public void AddRelativeTorque(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB46C Offset: 0x87D746C VA: 0x87DB46C
	public void AddRelativeTorque(float x, float y, float z) { }

	// RVA: 0x87DB474 Offset: 0x87D7474 VA: 0x87DB474
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB538 Offset: 0x87D7538 VA: 0x87DB538
	public void AddForceAtPosition(Vector3 force, Vector3 position) { }

	// RVA: 0x87DB540 Offset: 0x87D7540 VA: 0x87DB540
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB640 Offset: 0x87D7640 VA: 0x87DB640
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB648 Offset: 0x87D7648 VA: 0x87DB648
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) { }

	[NativeName("ClosestPointOnBounds")]
	// RVA: 0x87DB654 Offset: 0x87D7654 VA: 0x87DB654
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x87DB71C Offset: 0x87D771C VA: 0x87DB71C
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x87DB7C0 Offset: 0x87D77C0 VA: 0x87DB7C0
	private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit) { }

	// RVA: 0x87DB8DC Offset: 0x87D78DC VA: 0x87DB8DC
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB9E4 Offset: 0x87D79E4 VA: 0x87DB9E4
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87DB9EC Offset: 0x87D79EC VA: 0x87DB9EC
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo) { }

	[NativeName("SweepTestAll")]
	// RVA: 0x87DB9FC Offset: 0x87D79FC VA: 0x87DB9FC
	private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DBACC Offset: 0x87D7ACC VA: 0x87DBACC
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	// RVA: 0x87DBBC4 Offset: 0x87D7BC4 VA: 0x87DBBC4
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	// RVA: 0x87DBBCC Offset: 0x87D7BCC VA: 0x87DBBCC
	public RaycastHit[] SweepTestAll(Vector3 direction) { }

	// RVA: 0x87DBBDC Offset: 0x87D7BDC VA: 0x87DBBDC
	public float get_sleepVelocity() { }

	// RVA: 0x87DBBE4 Offset: 0x87D7BE4 VA: 0x87DBBE4
	public void set_sleepVelocity(float value) { }

	// RVA: 0x87DBBE8 Offset: 0x87D7BE8 VA: 0x87DBBE8
	public float get_sleepAngularVelocity() { }

	// RVA: 0x87DBBF0 Offset: 0x87D7BF0 VA: 0x87DBBF0
	public void set_sleepAngularVelocity(float value) { }

	[EditorBrowsable(1)]
	[Obsolete("Use Rigidbody.maxAngularVelocity instead.")]
	// RVA: 0x87DBBF4 Offset: 0x87D7BF4 VA: 0x87DBBF4
	public void SetMaxAngularVelocity(float a) { }

	// RVA: 0x87DBC40 Offset: 0x87D7C40 VA: 0x87DBC40
	public bool get_useConeFriction() { }

	// RVA: 0x87DBC48 Offset: 0x87D7C48 VA: 0x87DBC48
	public void set_useConeFriction(bool value) { }

	// RVA: 0x87DBC4C Offset: 0x87D7C4C VA: 0x87DBC4C
	public int get_solverIterationCount() { }

	// RVA: 0x87DBC88 Offset: 0x87D7C88 VA: 0x87DBC88
	public void set_solverIterationCount(int value) { }

	// RVA: 0x87DBCCC Offset: 0x87D7CCC VA: 0x87DBCCC
	public int get_solverVelocityIterationCount() { }

	// RVA: 0x87DBD08 Offset: 0x87D7D08 VA: 0x87DBD08
	public void set_solverVelocityIterationCount(int value) { }

	// RVA: 0x87DBD4C Offset: 0x87D7D4C VA: 0x87DBD4C
	public void .ctor() { }

	// RVA: 0x87D96A4 Offset: 0x87D56A4 VA: 0x87D96A4
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x87D973C Offset: 0x87D573C VA: 0x87D973C
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x87D97DC Offset: 0x87D57DC VA: 0x87D97DC
	private void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x87D9874 Offset: 0x87D5874 VA: 0x87D9874
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x87D9E80 Offset: 0x87D5E80 VA: 0x87D9E80
	private void get_centerOfMass_Injected(out Vector3 ret) { }

	// RVA: 0x87D9F18 Offset: 0x87D5F18 VA: 0x87D9F18
	private void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0x87D9FB8 Offset: 0x87D5FB8 VA: 0x87D9FB8
	private void get_worldCenterOfMass_Injected(out Vector3 ret) { }

	// RVA: 0x87DA0D4 Offset: 0x87D60D4 VA: 0x87DA0D4
	private void get_inertiaTensorRotation_Injected(out Quaternion ret) { }

	// RVA: 0x87DA16C Offset: 0x87D616C VA: 0x87DA16C
	private void set_inertiaTensorRotation_Injected(ref Quaternion value) { }

	// RVA: 0x87DA20C Offset: 0x87D620C VA: 0x87DA20C
	private void get_inertiaTensor_Injected(out Vector3 ret) { }

	// RVA: 0x87DA2A4 Offset: 0x87D62A4 VA: 0x87DA2A4
	private void set_inertiaTensor_Injected(ref Vector3 value) { }

	// RVA: 0x87DA3C4 Offset: 0x87D63C4 VA: 0x87DA3C4
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x87DA45C Offset: 0x87D645C VA: 0x87DA45C
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x87DA4F8 Offset: 0x87D64F8 VA: 0x87DA4F8
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x87DA590 Offset: 0x87D6590 VA: 0x87DA590
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x87DA8C0 Offset: 0x87D68C0 VA: 0x87DA8C0
	private void MovePosition_Injected(ref Vector3 position) { }

	// RVA: 0x87DA958 Offset: 0x87D6958 VA: 0x87DA958
	private void MoveRotation_Injected(ref Quaternion rot) { }

	// RVA: 0x87DA9FC Offset: 0x87D69FC VA: 0x87DA9FC
	private void Move_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x87DABE4 Offset: 0x87D6BE4 VA: 0x87DABE4
	private void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret) { }

	// RVA: 0x87DACA0 Offset: 0x87D6CA0 VA: 0x87DACA0
	private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) { }

	// RVA: 0x87DADC0 Offset: 0x87D6DC0 VA: 0x87DADC0
	private void get_excludeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87DAE4C Offset: 0x87D6E4C VA: 0x87DAE4C
	private void set_excludeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87DAEDC Offset: 0x87D6EDC VA: 0x87DAEDC
	private void get_includeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87DAF68 Offset: 0x87D6F68 VA: 0x87DAF68
	private void set_includeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87DB018 Offset: 0x87D7018 VA: 0x87DB018
	private void GetAccumulatedForce_Injected(float step, out Vector3 ret) { }

	// RVA: 0x87DB0F4 Offset: 0x87D70F4 VA: 0x87DB0F4
	private void GetAccumulatedTorque_Injected(float step, out Vector3 ret) { }

	// RVA: 0x87DB1C0 Offset: 0x87D71C0 VA: 0x87DB1C0
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x87DB284 Offset: 0x87D7284 VA: 0x87DB284
	private void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x87DB348 Offset: 0x87D7348 VA: 0x87DB348
	private void AddTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x87DB40C Offset: 0x87D740C VA: 0x87DB40C
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x87DB4DC Offset: 0x87D74DC VA: 0x87DB4DC
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

	// RVA: 0x87DB5C4 Offset: 0x87D75C4 VA: 0x87DB5C4
	private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	// RVA: 0x87DB6C0 Offset: 0x87D76C0 VA: 0x87DB6C0
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x87DB860 Offset: 0x87D7860 VA: 0x87DB860
	private void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x87DBA68 Offset: 0x87D7A68 VA: 0x87DBA68
	private RaycastHit[] Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/Physics/Collider.h")]
[RequireComponent(typeof(Transform))]
public class Collider : Component // TypeDefIndex: 27546
{
	// Properties
	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public ArticulationBody attachedArticulationBody { get; }
	public bool isTrigger { get; set; }
	public float contactOffset { get; set; }
	public Bounds bounds { get; }
	public bool hasModifiableContacts { get; set; }
	public bool providesContacts { get; set; }
	public int layerOverridePriority { get; set; }
	public LayerMask excludeLayers { get; set; }
	public LayerMask includeLayers { get; set; }
	[NativeMethod("Material")]
	public PhysicMaterial sharedMaterial { get; set; }
	public PhysicMaterial material { get; set; }

	// Methods

	// RVA: 0x87DBD54 Offset: 0x87D7D54 VA: 0x87DBD54
	public bool get_enabled() { }

	// RVA: 0x87DBD90 Offset: 0x87D7D90 VA: 0x87DBD90
	public void set_enabled(bool value) { }

	[NativeMethod("GetRigidbody")]
	// RVA: 0x87D9414 Offset: 0x87D5414 VA: 0x87D9414
	public Rigidbody get_attachedRigidbody() { }

	[NativeMethod("GetArticulationBody")]
	// RVA: 0x87D950C Offset: 0x87D550C VA: 0x87D950C
	public ArticulationBody get_attachedArticulationBody() { }

	// RVA: 0x87DBDD4 Offset: 0x87D7DD4 VA: 0x87DBDD4
	public bool get_isTrigger() { }

	// RVA: 0x87DBE10 Offset: 0x87D7E10 VA: 0x87DBE10
	public void set_isTrigger(bool value) { }

	// RVA: 0x87DBE54 Offset: 0x87D7E54 VA: 0x87DBE54
	public float get_contactOffset() { }

	// RVA: 0x87DBE90 Offset: 0x87D7E90 VA: 0x87DBE90
	public void set_contactOffset(float value) { }

	// RVA: 0x87DBEDC Offset: 0x87D7EDC VA: 0x87DBEDC
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x87DBF98 Offset: 0x87D7F98 VA: 0x87DBF98
	public Bounds get_bounds() { }

	// RVA: 0x87DC044 Offset: 0x87D8044 VA: 0x87DC044
	public bool get_hasModifiableContacts() { }

	// RVA: 0x87DC080 Offset: 0x87D8080 VA: 0x87DC080
	public void set_hasModifiableContacts(bool value) { }

	// RVA: 0x87DC0C4 Offset: 0x87D80C4 VA: 0x87DC0C4
	public bool get_providesContacts() { }

	// RVA: 0x87DC100 Offset: 0x87D8100 VA: 0x87DC100
	public void set_providesContacts(bool value) { }

	// RVA: 0x87DC144 Offset: 0x87D8144 VA: 0x87DC144
	public int get_layerOverridePriority() { }

	// RVA: 0x87DC180 Offset: 0x87D8180 VA: 0x87DC180
	public void set_layerOverridePriority(int value) { }

	// RVA: 0x87DC1C4 Offset: 0x87D81C4 VA: 0x87DC1C4
	public LayerMask get_excludeLayers() { }

	// RVA: 0x87DC254 Offset: 0x87D8254 VA: 0x87DC254
	public void set_excludeLayers(LayerMask value) { }

	// RVA: 0x87DC2E0 Offset: 0x87D82E0 VA: 0x87DC2E0
	public LayerMask get_includeLayers() { }

	// RVA: 0x87DC370 Offset: 0x87D8370 VA: 0x87DC370
	public void set_includeLayers(LayerMask value) { }

	// RVA: 0x87DC3FC Offset: 0x87D83FC VA: 0x87DC3FC
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x87DC438 Offset: 0x87D8438 VA: 0x87DC438
	public void set_sharedMaterial(PhysicMaterial value) { }

	[NativeMethod("GetClonedMaterial")]
	// RVA: 0x87DC47C Offset: 0x87D847C VA: 0x87DC47C
	public PhysicMaterial get_material() { }

	[NativeMethod("SetMaterial")]
	// RVA: 0x87DC4B8 Offset: 0x87D84B8 VA: 0x87DC4B8
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x87DC4FC Offset: 0x87D84FC VA: 0x87DC4FC
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x87DC5FC Offset: 0x87D85FC VA: 0x87DC5FC
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeName("ClosestPointOnBounds")]
	// RVA: 0x87DC6A8 Offset: 0x87D86A8 VA: 0x87DC6A8
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x87DC770 Offset: 0x87D8770 VA: 0x87DC770
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x87DC814 Offset: 0x87D8814 VA: 0x87DC814
	public void .ctor() { }

	// RVA: 0x87DBF44 Offset: 0x87D7F44 VA: 0x87DBF44
	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x87DC000 Offset: 0x87D8000 VA: 0x87DC000
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x87DC210 Offset: 0x87D8210 VA: 0x87DC210
	private void get_excludeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87DC29C Offset: 0x87D829C VA: 0x87DC29C
	private void set_excludeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87DC32C Offset: 0x87D832C VA: 0x87DC32C
	private void get_includeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87DC3B8 Offset: 0x87D83B8 VA: 0x87DC3B8
	private void set_includeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87DC590 Offset: 0x87D8590 VA: 0x87DC590
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x87DC714 Offset: 0x87D8714 VA: 0x87DC714
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/CharacterController.h")]
public class CharacterController : Collider // TypeDefIndex: 27547
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/Physics/MeshCollider.h")]
[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
public class MeshCollider : Collider // TypeDefIndex: 27548
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public bool convex { get; set; }
	public MeshColliderCookingOptions cookingOptions { get; set; }
	[Obsolete("Configuring smooth sphere collisions is no longer needed.", True)]
	[EditorBrowsable(1)]
	public bool smoothSphereCollisions { get; set; }
	[Obsolete("MeshCollider.skinWidth is no longer used.")]
	public float skinWidth { get; set; }
	[Obsolete("MeshCollider.inflateMesh is no longer supported. The new cooking algorithm doesn't need inflation to be used.")]
	public bool inflateMesh { get; set; }

	// Methods

	// RVA: 0x87DC81C Offset: 0x87D881C VA: 0x87DC81C
	public Mesh get_sharedMesh() { }

	// RVA: 0x87DC858 Offset: 0x87D8858 VA: 0x87DC858
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x87DC89C Offset: 0x87D889C VA: 0x87DC89C
	public bool get_convex() { }

	// RVA: 0x87DC8D8 Offset: 0x87D88D8 VA: 0x87DC8D8
	public void set_convex(bool value) { }

	// RVA: 0x87DC91C Offset: 0x87D891C VA: 0x87DC91C
	public MeshColliderCookingOptions get_cookingOptions() { }

	// RVA: 0x87DC958 Offset: 0x87D8958 VA: 0x87DC958
	public void set_cookingOptions(MeshColliderCookingOptions value) { }

	// RVA: 0x87DC99C Offset: 0x87D899C VA: 0x87DC99C
	public bool get_smoothSphereCollisions() { }

	// RVA: 0x87DC9A4 Offset: 0x87D89A4 VA: 0x87DC9A4
	public void set_smoothSphereCollisions(bool value) { }

	// RVA: 0x87DC9A8 Offset: 0x87D89A8 VA: 0x87DC9A8
	public float get_skinWidth() { }

	// RVA: 0x87DC9B0 Offset: 0x87D89B0 VA: 0x87DC9B0
	public void set_skinWidth(float value) { }

	// RVA: 0x87DC9B4 Offset: 0x87D89B4 VA: 0x87DC9B4
	public bool get_inflateMesh() { }

	// RVA: 0x87DC9BC Offset: 0x87D89BC VA: 0x87DC9BC
	public void set_inflateMesh(bool value) { }

	// RVA: 0x87DC9C0 Offset: 0x87D89C0 VA: 0x87DC9C0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/CapsuleCollider.h")]
[RequiredByNativeCode]
public class CapsuleCollider : Collider // TypeDefIndex: 27549
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/Physics/BoxCollider.h")]
public class BoxCollider : Collider // TypeDefIndex: 27550
{
	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	[Obsolete("Use BoxCollider.size instead. (UnityUpgradable) -> size")]
	public Vector3 extents { get; set; }

	// Methods

	// RVA: 0x87DC9C8 Offset: 0x87D89C8 VA: 0x87DC9C8
	public Vector3 get_center() { }

	// RVA: 0x87DCA68 Offset: 0x87D8A68 VA: 0x87DCA68
	public void set_center(Vector3 value) { }

	// RVA: 0x87DCB00 Offset: 0x87D8B00 VA: 0x87DCB00
	public Vector3 get_size() { }

	// RVA: 0x87DCBA0 Offset: 0x87D8BA0 VA: 0x87DCBA0
	public void set_size(Vector3 value) { }

	// RVA: 0x87DCC38 Offset: 0x87D8C38 VA: 0x87DCC38
	public Vector3 get_extents() { }

	// RVA: 0x87DCC58 Offset: 0x87D8C58 VA: 0x87DCC58
	public void set_extents(Vector3 value) { }

	// RVA: 0x87DCC68 Offset: 0x87D8C68 VA: 0x87DCC68
	public void .ctor() { }

	// RVA: 0x87DCA24 Offset: 0x87D8A24 VA: 0x87DCA24
	private void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x87DCABC Offset: 0x87D8ABC VA: 0x87DCABC
	private void set_center_Injected(ref Vector3 value) { }

	// RVA: 0x87DCB5C Offset: 0x87D8B5C VA: 0x87DCB5C
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x87DCBF4 Offset: 0x87D8BF4 VA: 0x87DCBF4
	private void set_size_Injected(ref Vector3 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/SphereCollider.h")]
[RequiredByNativeCode]
public class SphereCollider : Collider // TypeDefIndex: 27551
{
	// Properties
	public Vector3 center { get; set; }
	public float radius { get; set; }

	// Methods

	// RVA: 0x87DCC70 Offset: 0x87D8C70 VA: 0x87DCC70
	public Vector3 get_center() { }

	// RVA: 0x87DCD10 Offset: 0x87D8D10 VA: 0x87DCD10
	public void set_center(Vector3 value) { }

	// RVA: 0x87DCDA8 Offset: 0x87D8DA8 VA: 0x87DCDA8
	public float get_radius() { }

	// RVA: 0x87DCDE4 Offset: 0x87D8DE4 VA: 0x87DCDE4
	public void set_radius(float value) { }

	// RVA: 0x87DCE30 Offset: 0x87D8E30 VA: 0x87DCE30
	public void .ctor() { }

	// RVA: 0x87DCCCC Offset: 0x87D8CCC VA: 0x87DCCCC
	private void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x87DCD64 Offset: 0x87D8D64 VA: 0x87DCD64
	private void set_center_Injected(ref Vector3 value) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Physics/MessageParameters.h")]
public struct ContactPoint // TypeDefIndex: 27552
{
	// Fields
	internal Vector3 m_Point; // 0x0
	internal Vector3 m_Normal; // 0xC
	internal Vector3 m_Impulse; // 0x18
	internal int m_ThisColliderInstanceID; // 0x24
	internal int m_OtherColliderInstanceID; // 0x28
	internal float m_Separation; // 0x2C

	// Properties
	public Vector3 point { get; }
	public Vector3 normal { get; }

	// Methods

	// RVA: 0x87DCE38 Offset: 0x87D8E38 VA: 0x87DCE38
	public Vector3 get_point() { }

	// RVA: 0x87DCE44 Offset: 0x87D8E44 VA: 0x87DCE44
	public Vector3 get_normal() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 27553
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x87DCE50 Offset: 0x87D8E50 VA: 0x87DCE50 Slot: 3
	public override string ToString() { }

	// RVA: 0x87DCF40 Offset: 0x87D8F40 VA: 0x87DCF40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x87DCF48 Offset: 0x87D8F48 VA: 0x87DCF48 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x87DCFC0 Offset: 0x87D8FC0 VA: 0x87DCFC0 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x87CE980 Offset: 0x87CA980 VA: 0x87CE980
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("RaycastTest")]
	// RVA: 0x87DCFD0 Offset: 0x87D8FD0 VA: 0x87DCFD0
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87CEE6C Offset: 0x87CAE6C VA: 0x87CEE6C
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("Raycast")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	// RVA: 0x87DD0B8 Offset: 0x87D90B8 VA: 0x87DD0B8
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D20FC Offset: 0x87CE0FC VA: 0x87D20FC
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("RaycastNonAlloc")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x87DD1B0 Offset: 0x87D91B0 VA: 0x87DD1B0
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("CapsuleCast")]
	// RVA: 0x87DD2A4 Offset: 0x87D92A4 VA: 0x87DD2A4
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DD3F0 Offset: 0x87D93F0 VA: 0x87DD3F0
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87CFD6C Offset: 0x87CBD6C VA: 0x87CFD6C
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("CapsuleCastNonAlloc")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x87DD53C Offset: 0x87D953C VA: 0x87DD53C
	private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D4CE0 Offset: 0x87D0CE0 VA: 0x87D4CE0
	public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeName("OverlapCapsuleNonAlloc")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	// RVA: 0x87DD684 Offset: 0x87D9684 VA: 0x87DD684
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D7818 Offset: 0x87D3818 VA: 0x87D7818
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask = -1, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("SphereCast")]
	// RVA: 0x87DD798 Offset: 0x87D9798 VA: 0x87DD798
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DD8C0 Offset: 0x87D98C0 VA: 0x87DD8C0
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D05C4 Offset: 0x87CC5C4 VA: 0x87D05C4
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("SphereCastNonAlloc")]
	// RVA: 0x87DD9EC Offset: 0x87D99EC VA: 0x87DD9EC
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D5244 Offset: 0x87D1244 VA: 0x87D5244
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("OverlapSphereNonAlloc")]
	// RVA: 0x87DDB10 Offset: 0x87D9B10 VA: 0x87DDB10
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D47FC Offset: 0x87D07FC VA: 0x87D47FC
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", 0)]
	[NativeName("BoxCast")]
	// RVA: 0x87DDC10 Offset: 0x87D9C10 VA: 0x87DDC10
	private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DDD60 Offset: 0x87D9D60 VA: 0x87DDD60
	private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D0EB8 Offset: 0x87CCEB8 VA: 0x87D0EB8
	public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("OverlapBoxNonAlloc")]
	// RVA: 0x87DDEA4 Offset: 0x87D9EA4 VA: 0x87DDEA4
	private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D6660 Offset: 0x87D2660 VA: 0x87D6660
	public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()")]
	[NativeName("BoxCastNonAlloc")]
	// RVA: 0x87DDFB4 Offset: 0x87D9FB4 VA: 0x87DDFB4
	private static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87D6A5C Offset: 0x87D2A5C VA: 0x87D6A5C
	public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	// RVA: 0x87DD04C Offset: 0x87D904C VA: 0x87DD04C
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DD134 Offset: 0x87D9134 VA: 0x87DD134
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DD228 Offset: 0x87D9228 VA: 0x87DD228
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DD354 Offset: 0x87D9354 VA: 0x87DD354
	private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DD5E8 Offset: 0x87D95E8 VA: 0x87DD5E8
	private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DD714 Offset: 0x87D9714 VA: 0x87DD714
	private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DD834 Offset: 0x87D9834 VA: 0x87DD834
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DDA84 Offset: 0x87D9A84 VA: 0x87DDA84
	private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DDB94 Offset: 0x87D9B94 VA: 0x87DDB94
	private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DDCC4 Offset: 0x87D9CC4 VA: 0x87DDCC4
	private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DDF30 Offset: 0x87D9F30 VA: 0x87DDF30
	private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x87DE064 Offset: 0x87DA064 VA: 0x87DE064
	private static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, RaycastHit[] raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }
}

// Namespace: UnityEngine
public enum SimulationMode // TypeDefIndex: 27554
{
	// Fields
	public int value__; // 0x0
	public const SimulationMode FixedUpdate = 0;
	public const SimulationMode Update = 1;
	public const SimulationMode Script = 2;
}

// Namespace: UnityEngine
[IsReadOnly]
public struct ContactPairHeader // TypeDefIndex: 27555
{
	// Fields
	internal readonly int m_BodyID; // 0x0
	internal readonly int m_OtherBodyID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPairs; // 0x10
	internal readonly CollisionPairHeaderFlags m_Flags; // 0x14
	internal readonly Vector3 m_RelativeVelocity; // 0x18

	// Properties
	public Component Body { get; }
	public Component OtherBody { get; }
	internal bool HasRemovedBody { get; }

	// Methods

	// RVA: 0x87CD5F8 Offset: 0x87C95F8 VA: 0x87CD5F8
	public Component get_Body() { }

	// RVA: 0x87CD580 Offset: 0x87C9580 VA: 0x87CD580
	public Component get_OtherBody() { }

	// RVA: 0x87D8CA8 Offset: 0x87D4CA8 VA: 0x87D8CA8
	internal bool get_HasRemovedBody() { }

	// RVA: 0x87D8CB8 Offset: 0x87D4CB8 VA: 0x87D8CB8
	public ref ContactPair GetContactPair(int index) { }

	// RVA: 0x87DE100 Offset: 0x87DA100 VA: 0x87DE100
	internal ContactPair* GetContactPair_Internal(int index) { }
}

// Namespace: UnityEngine
[IsReadOnly]
[UsedByNativeCode]
public struct ContactPair // TypeDefIndex: 27556
{
	// Fields
	internal readonly int m_ColliderID; // 0x0
	internal readonly int m_OtherColliderID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPoints; // 0x10
	internal readonly CollisionPairFlags m_Flags; // 0x14
	internal readonly CollisionPairEventFlags m_Events; // 0x16
	internal readonly Vector3 m_ImpulseSum; // 0x18

	// Properties
	public Collider Collider { get; }
	public Collider OtherCollider { get; }
	public bool IsCollisionEnter { get; }
	public bool IsCollisionExit { get; }
	public bool IsCollisionStay { get; }
	internal bool HasRemovedCollider { get; }

	// Methods

	// RVA: 0x87CD710 Offset: 0x87C9710 VA: 0x87CD710
	public Collider get_Collider() { }

	// RVA: 0x87CD684 Offset: 0x87C9684 VA: 0x87CD684
	public Collider get_OtherCollider() { }

	// RVA: 0x87D8CCC Offset: 0x87D4CCC VA: 0x87D8CCC
	public bool get_IsCollisionEnter() { }

	// RVA: 0x87D8E14 Offset: 0x87D4E14 VA: 0x87D8E14
	public bool get_IsCollisionExit() { }

	// RVA: 0x87D8E08 Offset: 0x87D4E08 VA: 0x87D8E08
	public bool get_IsCollisionStay() { }

	// RVA: 0x87D8CBC Offset: 0x87D4CBC VA: 0x87D8CBC
	internal bool get_HasRemovedCollider() { }

	// RVA: 0x87CD8F0 Offset: 0x87C98F0 VA: 0x87CD8F0
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x87DE180 Offset: 0x87DA180 VA: 0x87DE180
	private static int ExtractContactsArray_Injected(ref ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped) { }
}

// Namespace: UnityEngine
internal enum CollisionPairHeaderFlags // TypeDefIndex: 27557
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairHeaderFlags RemovedActor = 1;
	public const CollisionPairHeaderFlags RemovedOtherActor = 2;
}

// Namespace: UnityEngine
internal enum CollisionPairFlags // TypeDefIndex: 27558
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairFlags RemovedShape = 1;
	public const CollisionPairFlags RemovedOtherShape = 2;
	public const CollisionPairFlags ActorPairHasFirstTouch = 4;
	public const CollisionPairFlags ActorPairLostTouch = 8;
	public const CollisionPairFlags InternalHasImpulses = 16;
	public const CollisionPairFlags InternalContactsAreFlipped = 32;
}

// Namespace: UnityEngine
internal enum CollisionPairEventFlags // TypeDefIndex: 27559
{
	// Fields
	public ushort value__; // 0x0
	public const CollisionPairEventFlags SolveContacts = 1;
	public const CollisionPairEventFlags ModifyContacts = 2;
	public const CollisionPairEventFlags NotifyTouchFound = 4;
	public const CollisionPairEventFlags NotifyTouchPersists = 8;
	public const CollisionPairEventFlags NotifyTouchLost = 16;
	public const CollisionPairEventFlags NotifyTouchCCD = 32;
	public const CollisionPairEventFlags NotifyThresholdForceFound = 64;
	public const CollisionPairEventFlags NotifyThresholdForcePersists = 128;
	public const CollisionPairEventFlags NotifyThresholdForceLost = 256;
	public const CollisionPairEventFlags NotifyContactPoint = 512;
	public const CollisionPairEventFlags DetectDiscreteContact = 1024;
	public const CollisionPairEventFlags DetectCCDContact = 2048;
	public const CollisionPairEventFlags PreSolverVelocity = 4096;
	public const CollisionPairEventFlags PostSolverVelocity = 8192;
	public const CollisionPairEventFlags ContactEventPose = 16384;
	public const CollisionPairEventFlags NextFree = 32768;
	public const CollisionPairEventFlags ContactDefault = 1025;
	public const CollisionPairEventFlags TriggerDefault = 1044;
}

