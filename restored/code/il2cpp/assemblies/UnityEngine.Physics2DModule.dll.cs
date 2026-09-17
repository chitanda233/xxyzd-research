// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27735
{}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 27736
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x87C2E58 Offset: 0x87BEE58 VA: 0x87C2E58 Slot: 3
	public override string ToString() { }

	// RVA: 0x87C2F48 Offset: 0x87BEF48 VA: 0x87C2F48 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x87C2F50 Offset: 0x87BEF50 VA: 0x87C2F50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x87C2FC8 Offset: 0x87BEFC8 VA: 0x87C2FC8 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x87C2FD8 Offset: 0x87BEFD8 VA: 0x87C2FD8
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x87C3234 Offset: 0x87BF234 VA: 0x87C3234
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethod("Raycast_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x87C31A0 Offset: 0x87BF1A0 VA: 0x87C31A0
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x87C3304 Offset: 0x87BF304 VA: 0x87C3304
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethod("RaycastArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x87C3334 Offset: 0x87BF334 VA: 0x87C3334
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x87C3428 Offset: 0x87BF428 VA: 0x87C3428
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("RaycastList_Binding")]
	// RVA: 0x87C3458 Offset: 0x87BF458 VA: 0x87C3458
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x87C354C Offset: 0x87BF54C VA: 0x87C354C
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRayIntersectionArray_Binding")]
	// RVA: 0x87C3570 Offset: 0x87BF570 VA: 0x87C3570
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x87C366C Offset: 0x87BF66C VA: 0x87C366C
	public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("OverlapColliderArray_Binding")]
	// RVA: 0x87C36D0 Offset: 0x87BF6D0 VA: 0x87C36D0
	private static int OverlapColliderArray_Internal(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x87C3778 Offset: 0x87BF778 VA: 0x87C3778
	public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results) { }

	[NativeMethod("OverlapColliderList_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x87C37DC Offset: 0x87BF7DC VA: 0x87C37DC
	private static int OverlapColliderList_Internal(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x87C3288 Offset: 0x87BF288 VA: 0x87C3288
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x87C33AC Offset: 0x87BF3AC VA: 0x87C33AC
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x87C34D0 Offset: 0x87BF4D0 VA: 0x87C34D0
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x87C35F0 Offset: 0x87BF5F0 VA: 0x87C35F0
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x87C3724 Offset: 0x87BF724 VA: 0x87C3724
	private static int OverlapColliderArray_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x87C3830 Offset: 0x87BF830 VA: 0x87C3830
	private static int OverlapColliderList_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter, List<Collider2D> results) { }
}

// Namespace: UnityEngine
[NativeHeader("Physics2DScriptingClasses.h")]
[StaticAccessor("GetPhysicsManager2D()", 1)]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[NativeHeader("Physics2DScriptingClasses.h")]
public class Physics2D // TypeDefIndex: 27737
{
	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessor("GetPhysics2DSettings()")]
	public static Vector2 gravity { get; }
	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0x87C3884 Offset: 0x87BF884 VA: 0x87C3884
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x87C388C Offset: 0x87BF88C VA: 0x87C388C
	public static Vector2 get_gravity() { }

	// RVA: 0x87C3944 Offset: 0x87BF944 VA: 0x87C3944
	public static bool get_queriesHitTriggers() { }

	// RVA: 0x87C396C Offset: 0x87BF96C VA: 0x87C396C
	public static bool GetIgnoreLayerCollision(int layer1, int layer2) { }

	[StaticAccessor("GetPhysics2DSettings()")]
	[NativeMethod("GetIgnoreLayerCollision")]
	// RVA: 0x87C3A60 Offset: 0x87BFA60 VA: 0x87C3A60
	private static bool GetIgnoreLayerCollision_Internal(int layer1, int layer2) { }

	// RVA: 0x87C3AA4 Offset: 0x87BFAA4 VA: 0x87C3AA4
	public static int GetLayerCollisionMask(int layer) { }

	[StaticAccessor("GetPhysics2DSettings()")]
	[NativeMethod("GetLayerCollisionMask")]
	// RVA: 0x87C3B68 Offset: 0x87BFB68 VA: 0x87C3B68
	private static int GetLayerCollisionMask_Internal(int layer) { }

	// RVA: 0x87C3BA4 Offset: 0x87BFBA4 VA: 0x87C3BA4
	public static ColliderDistance2D Distance(Collider2D colliderA, Collider2D colliderB) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("Distance")]
	// RVA: 0x87C3D48 Offset: 0x87BFD48 VA: 0x87C3D48
	private static ColliderDistance2D Distance_Internal(Collider2D colliderA, Collider2D colliderB) { }

	// RVA: 0x87C3E44 Offset: 0x87BFE44 VA: 0x87C3E44
	public static Vector2 ClosestPoint(Vector2 position, Collider2D collider) { }

	// RVA: 0x87C3FC4 Offset: 0x87BFFC4 VA: 0x87C3FC4
	public static Vector2 ClosestPoint(Vector2 position, Rigidbody2D rigidbody) { }

	[NativeMethod("ClosestPoint")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x87C3F30 Offset: 0x87BFF30 VA: 0x87C3F30
	private static Vector2 ClosestPoint_Collider(Vector2 position, Collider2D collider) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("ClosestPoint")]
	// RVA: 0x87C40B0 Offset: 0x87C00B0 VA: 0x87C40B0
	private static Vector2 ClosestPoint_Rigidbody(Vector2 position, Rigidbody2D rigidbody) { }

	[ExcludeFromDocs]
	// RVA: 0x87C41EC Offset: 0x87C01EC VA: 0x87C41EC
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocs]
	// RVA: 0x87C42AC Offset: 0x87C02AC VA: 0x87C42AC
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x87C4374 Offset: 0x87C0374 VA: 0x87C4374
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87C4484 Offset: 0x87C0484 VA: 0x87C4484
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x87C4594 Offset: 0x87C0594 VA: 0x87C4594
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocs]
	// RVA: 0x87C46AC Offset: 0x87C06AC VA: 0x87C46AC
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x87C4768 Offset: 0x87C0768 VA: 0x87C4768
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x87C482C Offset: 0x87C082C VA: 0x87C482C
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocs]
	// RVA: 0x87C48F0 Offset: 0x87C08F0 VA: 0x87C48F0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocs]
	// RVA: 0x87C4A0C Offset: 0x87C0A0C VA: 0x87C4A0C
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCode]
	// RVA: 0x87C4A80 Offset: 0x87C0A80 VA: 0x87C4A80
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[NativeMethod("GetRayIntersectionAll_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x87C495C Offset: 0x87C095C VA: 0x87C495C
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87C4B6C Offset: 0x87C0B6C VA: 0x87C4B6C
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	// RVA: 0x87C4BE8 Offset: 0x87C0BE8 VA: 0x87C4BE8
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCode]
	// RVA: 0x87C4C6C Offset: 0x87C0C6C VA: 0x87C4C6C
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	// RVA: 0x87C4CF4 Offset: 0x87C0CF4 VA: 0x87C4CF4
	public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, ContactPoint2D[] contacts) { }

	// RVA: 0x87C4E18 Offset: 0x87C0E18 VA: 0x87C4E18
	public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] colliders) { }

	// RVA: 0x87C4F3C Offset: 0x87C0F3C VA: 0x87C4F3C
	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, ContactPoint2D[] contacts) { }

	// RVA: 0x87C5060 Offset: 0x87C1060 VA: 0x87C5060
	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Collider2D[] colliders) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetColliderContactsArray_Binding")]
	// RVA: 0x87C4D8C Offset: 0x87C0D8C VA: 0x87C4D8C
	private static int GetColliderContactsArray(Collider2D collider, ContactFilter2D contactFilter, ContactPoint2D[] results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRigidbodyContactsArray_Binding")]
	// RVA: 0x87C4FD4 Offset: 0x87C0FD4 VA: 0x87C4FD4
	private static int GetRigidbodyContactsArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, ContactPoint2D[] results) { }

	[NativeMethod("GetColliderContactsCollidersOnlyArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x87C4EB0 Offset: 0x87C0EB0 VA: 0x87C4EB0
	private static int GetColliderContactsCollidersOnlyArray(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results) { }

	[NativeMethod("GetRigidbodyContactsCollidersOnlyArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x87C50F8 Offset: 0x87C10F8 VA: 0x87C50F8
	private static int GetRigidbodyContactsCollidersOnlyArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x87C52D4 Offset: 0x87C12D4 VA: 0x87C52D4
	public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> contacts) { }

	// RVA: 0x87C53F8 Offset: 0x87C13F8 VA: 0x87C53F8
	public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> colliders) { }

	// RVA: 0x87C551C Offset: 0x87C151C VA: 0x87C551C
	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> contacts) { }

	// RVA: 0x87C5640 Offset: 0x87C1640 VA: 0x87C5640
	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> colliders) { }

	[NativeMethod("GetColliderContactsList_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x87C536C Offset: 0x87C136C VA: 0x87C536C
	private static int GetColliderContactsList(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> results) { }

	[NativeMethod("GetRigidbodyContactsList_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x87C55B4 Offset: 0x87C15B4 VA: 0x87C55B4
	private static int GetRigidbodyContactsList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetColliderContactsCollidersOnlyList_Binding")]
	// RVA: 0x87C5490 Offset: 0x87C1490 VA: 0x87C5490
	private static int GetColliderContactsCollidersOnlyList(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRigidbodyContactsCollidersOnlyList_Binding")]
	// RVA: 0x87C56D8 Offset: 0x87C16D8 VA: 0x87C56D8
	private static int GetRigidbodyContactsCollidersOnlyList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x87C58B4 Offset: 0x87C18B4 VA: 0x87C58B4
	private static void .cctor() { }

	// RVA: 0x87C3908 Offset: 0x87BF908 VA: 0x87C3908
	private static void get_gravity_Injected(out Vector2 ret) { }

	// RVA: 0x87C3DF0 Offset: 0x87BFDF0 VA: 0x87C3DF0
	private static void Distance_Internal_Injected(Collider2D colliderA, Collider2D colliderB, out ColliderDistance2D ret) { }

	// RVA: 0x87C4144 Offset: 0x87C0144 VA: 0x87C4144
	private static void ClosestPoint_Collider_Injected(ref Vector2 position, Collider2D collider, out Vector2 ret) { }

	// RVA: 0x87C4198 Offset: 0x87C0198 VA: 0x87C4198
	private static void ClosestPoint_Rigidbody_Injected(ref Vector2 position, Rigidbody2D rigidbody, out Vector2 ret) { }

	// RVA: 0x87C4B00 Offset: 0x87C0B00 VA: 0x87C4B00
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

	// RVA: 0x87C5184 Offset: 0x87C1184 VA: 0x87C5184
	private static int GetColliderContactsArray_Injected(Collider2D collider, ref ContactFilter2D contactFilter, ContactPoint2D[] results) { }

	// RVA: 0x87C51D8 Offset: 0x87C11D8 VA: 0x87C51D8
	private static int GetRigidbodyContactsArray_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, ContactPoint2D[] results) { }

	// RVA: 0x87C522C Offset: 0x87C122C VA: 0x87C522C
	private static int GetColliderContactsCollidersOnlyArray_Injected(Collider2D collider, ref ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x87C5280 Offset: 0x87C1280 VA: 0x87C5280
	private static int GetRigidbodyContactsCollidersOnlyArray_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x87C5764 Offset: 0x87C1764 VA: 0x87C5764
	private static int GetColliderContactsList_Injected(Collider2D collider, ref ContactFilter2D contactFilter, List<ContactPoint2D> results) { }

	// RVA: 0x87C57B8 Offset: 0x87C17B8 VA: 0x87C57B8
	private static int GetRigidbodyContactsList_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, List<ContactPoint2D> results) { }

	// RVA: 0x87C580C Offset: 0x87C180C VA: 0x87C580C
	private static int GetColliderContactsCollidersOnlyList_Injected(Collider2D collider, ref ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x87C5860 Offset: 0x87C1860 VA: 0x87C5860
	private static int GetRigidbodyContactsCollidersOnlyList_Injected(Rigidbody2D rigidbody, ref ContactFilter2D contactFilter, List<Collider2D> results) { }
}

// Namespace: UnityEngine
public enum CapsuleDirection2D // TypeDefIndex: 27738
{
	// Fields
	public int value__; // 0x0
	public const CapsuleDirection2D Vertical = 0;
	public const CapsuleDirection2D Horizontal = 1;
}

// Namespace: UnityEngine
[Flags]
public enum RigidbodyConstraints2D // TypeDefIndex: 27739
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyConstraints2D None = 0;
	public const RigidbodyConstraints2D FreezePositionX = 1;
	public const RigidbodyConstraints2D FreezePositionY = 2;
	public const RigidbodyConstraints2D FreezeRotation = 4;
	public const RigidbodyConstraints2D FreezePosition = 3;
	public const RigidbodyConstraints2D FreezeAll = 7;
}

// Namespace: UnityEngine
public enum RigidbodyInterpolation2D // TypeDefIndex: 27740
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyInterpolation2D None = 0;
	public const RigidbodyInterpolation2D Interpolate = 1;
	public const RigidbodyInterpolation2D Extrapolate = 2;
}

// Namespace: UnityEngine
public enum RigidbodySleepMode2D // TypeDefIndex: 27741
{
	// Fields
	public int value__; // 0x0
	public const RigidbodySleepMode2D NeverSleep = 0;
	public const RigidbodySleepMode2D StartAwake = 1;
	public const RigidbodySleepMode2D StartAsleep = 2;
}

// Namespace: UnityEngine
public enum CollisionDetectionMode2D // TypeDefIndex: 27742
{
	// Fields
	public int value__; // 0x0
	[Obsolete("Enum member CollisionDetectionMode2D.None has been deprecated. Use CollisionDetectionMode2D.Discrete instead (UnityUpgradable) -> Discrete", True)]
	[EditorBrowsable(1)]
	public const CollisionDetectionMode2D None = 0;
	public const CollisionDetectionMode2D Discrete = 0;
	public const CollisionDetectionMode2D Continuous = 1;
}

// Namespace: UnityEngine
public enum RigidbodyType2D // TypeDefIndex: 27743
{
	// Fields
	public int value__; // 0x0
	public const RigidbodyType2D Dynamic = 0;
	public const RigidbodyType2D Kinematic = 1;
	public const RigidbodyType2D Static = 2;
}

// Namespace: UnityEngine
public enum ForceMode2D // TypeDefIndex: 27744
{
	// Fields
	public int value__; // 0x0
	public const ForceMode2D Force = 0;
	public const ForceMode2D Impulse = 1;
}

// Namespace: UnityEngine
public enum ColliderErrorState2D // TypeDefIndex: 27745
{
	// Fields
	public int value__; // 0x0
	public const ColliderErrorState2D None = 0;
	public const ColliderErrorState2D NoShapes = 1;
	public const ColliderErrorState2D RemovedShapes = 2;
}

// Namespace: UnityEngine
public enum JointLimitState2D // TypeDefIndex: 27746
{
	// Fields
	public int value__; // 0x0
	public const JointLimitState2D Inactive = 0;
	public const JointLimitState2D LowerLimit = 1;
	public const JointLimitState2D UpperLimit = 2;
	public const JointLimitState2D EqualLimits = 3;
}

// Namespace: UnityEngine
public enum PhysicsShapeType2D // TypeDefIndex: 27747
{
	// Fields
	public int value__; // 0x0
	public const PhysicsShapeType2D Circle = 0;
	public const PhysicsShapeType2D Capsule = 1;
	public const PhysicsShapeType2D Polygon = 2;
	public const PhysicsShapeType2D Edges = 3;
}

// Namespace: UnityEngine
[NativeHeader(Header = "Modules/Physics2D/Public/PhysicsScripting2D.h")]
[UsedByNativeCode]
public struct PhysicsShape2D // TypeDefIndex: 27748
{
	// Fields
	private PhysicsShapeType2D m_ShapeType; // 0x0
	private float m_Radius; // 0x4
	private int m_VertexStartIndex; // 0x8
	private int m_VertexCount; // 0xC
	private int m_UseAdjacentStart; // 0x10
	private int m_UseAdjacentEnd; // 0x14
	private Vector2 m_AdjacentStart; // 0x18
	private Vector2 m_AdjacentEnd; // 0x20
}

// Namespace: 
[NativeHeader(Header = "Modules/Physics2D/Public/PhysicsScripting2D.h")]
internal struct PhysicsShapeGroup2D.GroupState // TypeDefIndex: 27749
{
	// Fields
	[NativeName("shapesList")]
	public List<PhysicsShape2D> m_Shapes; // 0x0
	[NativeName("verticesList")]
	public List<Vector2> m_Vertices; // 0x8
	[NativeName("localToWorld")]
	public Matrix4x4 m_LocalToWorld; // 0x10
}

// Namespace: UnityEngine
public class PhysicsShapeGroup2D // TypeDefIndex: 27750
{
	// Fields
	internal PhysicsShapeGroup2D.GroupState m_GroupState; // 0x10
}

// Namespace: UnityEngine
public struct ColliderDistance2D // TypeDefIndex: 27751
{
	// Fields
	private Vector2 m_PointA; // 0x0
	private Vector2 m_PointB; // 0x8
	private Vector2 m_Normal; // 0x10
	private float m_Distance; // 0x18
	private int m_IsValid; // 0x1C
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("ContactFilter", "struct ContactFilter;")]
[Serializable]
public struct ContactFilter2D // TypeDefIndex: 27752
{
	// Fields
	[NativeName("m_UseTriggers")]
	public bool useTriggers; // 0x0
	[NativeName("m_UseLayerMask")]
	public bool useLayerMask; // 0x1
	[NativeName("m_UseDepth")]
	public bool useDepth; // 0x2
	[NativeName("m_UseOutsideDepth")]
	public bool useOutsideDepth; // 0x3
	[NativeName("m_UseNormalAngle")]
	public bool useNormalAngle; // 0x4
	[NativeName("m_UseOutsideNormalAngle")]
	public bool useOutsideNormalAngle; // 0x5
	[NativeName("m_LayerMask")]
	public LayerMask layerMask; // 0x8
	[NativeName("m_MinDepth")]
	public float minDepth; // 0xC
	[NativeName("m_MaxDepth")]
	public float maxDepth; // 0x10
	[NativeName("m_MinNormalAngle")]
	public float minNormalAngle; // 0x14
	[NativeName("m_MaxNormalAngle")]
	public float maxNormalAngle; // 0x18

	// Methods

	// RVA: 0x87C594C Offset: 0x87C194C VA: 0x87C594C
	public ContactFilter2D NoFilter() { }

	// RVA: 0x87C59A0 Offset: 0x87C19A0 VA: 0x87C59A0
	private void CheckConsistency() { }

	// RVA: 0x87C5A18 Offset: 0x87C1A18 VA: 0x87C5A18
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x87C5A28 Offset: 0x87C1A28 VA: 0x87C5A28
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x87C30A0 Offset: 0x87BF0A0 VA: 0x87C30A0
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	// RVA: 0x87C59DC Offset: 0x87C19DC VA: 0x87C59DC
	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class Collision2D // TypeDefIndex: 27753
{
	// Fields
	internal int m_Collider; // 0x10
	internal int m_OtherCollider; // 0x14
	internal int m_Rigidbody; // 0x18
	internal int m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal int m_Enabled; // 0x28
	internal int m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38

	// Properties
	public Collider2D collider { get; }
	public Collider2D otherCollider { get; }
	public Rigidbody2D rigidbody { get; }
	public Rigidbody2D otherRigidbody { get; }
	public Transform transform { get; }
	public GameObject gameObject { get; }
	public Vector2 relativeVelocity { get; }
	public bool enabled { get; }
	public ContactPoint2D[] contacts { get; }
	public int contactCount { get; }

	// Methods

	// RVA: 0x87C5A70 Offset: 0x87C1A70 VA: 0x87C5A70
	private ContactPoint2D[] GetContacts_Internal() { }

	// RVA: 0x87C5A8C Offset: 0x87C1A8C VA: 0x87C5A8C
	public Collider2D get_collider() { }

	// RVA: 0x87C5B38 Offset: 0x87C1B38 VA: 0x87C5B38
	public Collider2D get_otherCollider() { }

	// RVA: 0x87C5BE4 Offset: 0x87C1BE4 VA: 0x87C5BE4
	public Rigidbody2D get_rigidbody() { }

	// RVA: 0x87C5C6C Offset: 0x87C1C6C VA: 0x87C5C6C
	public Rigidbody2D get_otherRigidbody() { }

	// RVA: 0x87C5CF4 Offset: 0x87C1CF4 VA: 0x87C5CF4
	public Transform get_transform() { }

	// RVA: 0x87C5D88 Offset: 0x87C1D88 VA: 0x87C5D88
	public GameObject get_gameObject() { }

	// RVA: 0x87C5E1C Offset: 0x87C1E1C VA: 0x87C5E1C
	public Vector2 get_relativeVelocity() { }

	// RVA: 0x87C5E24 Offset: 0x87C1E24 VA: 0x87C5E24
	public bool get_enabled() { }

	// RVA: 0x87C5E34 Offset: 0x87C1E34 VA: 0x87C5E34
	public ContactPoint2D[] get_contacts() { }

	// RVA: 0x87C5EB0 Offset: 0x87C1EB0 VA: 0x87C5EB0
	public int get_contactCount() { }

	// RVA: 0x87C5EB8 Offset: 0x87C1EB8 VA: 0x87C5EB8
	public ContactPoint2D GetContact(int index) { }

	// RVA: 0x87C5FCC Offset: 0x87C1FCC VA: 0x87C5FCC
	public int GetContacts(ContactPoint2D[] contacts) { }

	// RVA: 0x87C605C Offset: 0x87C205C VA: 0x87C605C
	public int GetContacts(List<ContactPoint2D> contacts) { }

	// RVA: 0x87C6228 Offset: 0x87C2228 VA: 0x87C6228
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[RequiredByNativeCode(Optional = False, GenerateProxy = True)]
[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
public struct ContactPoint2D // TypeDefIndex: 27754
{
	// Fields
	[NativeName("point")]
	private Vector2 m_Point; // 0x0
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x8
	[NativeName("relativeVelocity")]
	private Vector2 m_RelativeVelocity; // 0x10
	[NativeName("separation")]
	private float m_Separation; // 0x18
	[NativeName("normalImpulse")]
	private float m_NormalImpulse; // 0x1C
	[NativeName("tangentImpulse")]
	private float m_TangentImpulse; // 0x20
	[NativeName("collider")]
	private int m_Collider; // 0x24
	[NativeName("otherCollider")]
	private int m_OtherCollider; // 0x28
	[NativeName("rigidbody")]
	private int m_Rigidbody; // 0x2C
	[NativeName("otherRigidbody")]
	private int m_OtherRigidbody; // 0x30
	[NativeName("enabled")]
	private int m_Enabled; // 0x34

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }

	// Methods

	// RVA: 0x87C6230 Offset: 0x87C2230 VA: 0x87C6230
	public Vector2 get_point() { }

	// RVA: 0x87C6238 Offset: 0x87C2238 VA: 0x87C6238
	public Vector2 get_normal() { }
}

// Namespace: UnityEngine
public struct JointAngleLimits2D // TypeDefIndex: 27755
{
	// Fields
	private float m_LowerAngle; // 0x0
	private float m_UpperAngle; // 0x4
}

// Namespace: UnityEngine
public struct JointMotor2D // TypeDefIndex: 27756
{
	// Fields
	private float m_MotorSpeed; // 0x0
	private float m_MaximumMotorTorque; // 0x4
}

// Namespace: UnityEngine
[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
public struct RaycastHit2D // TypeDefIndex: 27757
{
	// Fields
	[NativeName("centroid")]
	private Vector2 m_Centroid; // 0x0
	[NativeName("point")]
	private Vector2 m_Point; // 0x8
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x10
	[NativeName("distance")]
	private float m_Distance; // 0x18
	[NativeName("fraction")]
	private float m_Fraction; // 0x1C
	[NativeName("collider")]
	private int m_Collider; // 0x20

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }
	public Rigidbody2D rigidbody { get; }
	public Transform transform { get; }

	// Methods

	// RVA: 0x87C6240 Offset: 0x87C2240 VA: 0x87C6240
	public Vector2 get_point() { }

	// RVA: 0x87C6248 Offset: 0x87C2248 VA: 0x87C6248
	public Vector2 get_normal() { }

	// RVA: 0x87C6250 Offset: 0x87C2250 VA: 0x87C6250
	public float get_distance() { }

	// RVA: 0x87C6258 Offset: 0x87C2258 VA: 0x87C6258
	public Collider2D get_collider() { }

	// RVA: 0x87C6304 Offset: 0x87C2304 VA: 0x87C6304
	public Rigidbody2D get_rigidbody() { }

	// RVA: 0x87C63FC Offset: 0x87C23FC VA: 0x87C63FC
	public Transform get_transform() { }

	// RVA: 0x87C64D8 Offset: 0x87C24D8 VA: 0x87C64D8
	public static bool op_Implicit(RaycastHit2D hit) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component // TypeDefIndex: 27758
{
	// Properties
	public Vector2 position { get; set; }
	public float rotation { get; set; }
	public Vector2 velocity { get; set; }
	public float angularVelocity { get; set; }
	public bool useAutoMass { get; set; }
	public float mass { get; set; }
	[NativeMethod("Material")]
	public PhysicsMaterial2D sharedMaterial { get; set; }
	public Vector2 centerOfMass { get; set; }
	public Vector2 worldCenterOfMass { get; }
	public float inertia { get; set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public float gravityScale { get; set; }
	public RigidbodyType2D bodyType { get; set; }
	public bool useFullKinematicContacts { get; set; }
	public bool isKinematic { get; set; }
	[NativeMethod("FreezeRotation")]
	[Obsolete("'fixedAngle' is no longer supported. Use constraints instead.", False)]
	public bool fixedAngle { get; set; }
	public bool freezeRotation { get; set; }
	public RigidbodyConstraints2D constraints { get; set; }
	public bool simulated { get; set; }
	public RigidbodyInterpolation2D interpolation { get; set; }
	public RigidbodySleepMode2D sleepMode { get; set; }
	public CollisionDetectionMode2D collisionDetectionMode { get; set; }
	public int attachedColliderCount { get; }
	public Vector2 totalForce { get; set; }
	public float totalTorque { get; set; }
	public LayerMask excludeLayers { get; set; }
	public LayerMask includeLayers { get; set; }

	// Methods

	// RVA: 0x87C6544 Offset: 0x87C2544 VA: 0x87C6544
	public Vector2 get_position() { }

	// RVA: 0x87C65D4 Offset: 0x87C25D4 VA: 0x87C65D4
	public void set_position(Vector2 value) { }

	// RVA: 0x87C6660 Offset: 0x87C2660 VA: 0x87C6660
	public float get_rotation() { }

	// RVA: 0x87C669C Offset: 0x87C269C VA: 0x87C669C
	public void set_rotation(float value) { }

	// RVA: 0x87C66E8 Offset: 0x87C26E8 VA: 0x87C66E8
	public void SetRotation(float angle) { }

	[NativeMethod("SetRotation")]
	// RVA: 0x87C6734 Offset: 0x87C2734 VA: 0x87C6734
	private void SetRotation_Angle(float angle) { }

	// RVA: 0x87C6780 Offset: 0x87C2780 VA: 0x87C6780
	public void SetRotation(Quaternion rotation) { }

	[NativeMethod("SetRotation")]
	// RVA: 0x87C6784 Offset: 0x87C2784 VA: 0x87C6784
	private void SetRotation_Quaternion(Quaternion rotation) { }

	// RVA: 0x87C681C Offset: 0x87C281C VA: 0x87C681C
	public void MovePosition(Vector2 position) { }

	// RVA: 0x87C68A8 Offset: 0x87C28A8 VA: 0x87C68A8
	public void MoveRotation(float angle) { }

	[NativeMethod("MoveRotation")]
	// RVA: 0x87C68F4 Offset: 0x87C28F4 VA: 0x87C68F4
	private void MoveRotation_Angle(float angle) { }

	// RVA: 0x87C6940 Offset: 0x87C2940 VA: 0x87C6940
	public void MoveRotation(Quaternion rotation) { }

	[NativeMethod("MoveRotation")]
	// RVA: 0x87C6944 Offset: 0x87C2944 VA: 0x87C6944
	private void MoveRotation_Quaternion(Quaternion rotation) { }

	// RVA: 0x87C69DC Offset: 0x87C29DC VA: 0x87C69DC
	public Vector2 get_velocity() { }

	// RVA: 0x87C6A6C Offset: 0x87C2A6C VA: 0x87C6A6C
	public void set_velocity(Vector2 value) { }

	// RVA: 0x87C6AF8 Offset: 0x87C2AF8 VA: 0x87C6AF8
	public float get_angularVelocity() { }

	// RVA: 0x87C6B34 Offset: 0x87C2B34 VA: 0x87C6B34
	public void set_angularVelocity(float value) { }

	// RVA: 0x87C6B80 Offset: 0x87C2B80 VA: 0x87C6B80
	public bool get_useAutoMass() { }

	// RVA: 0x87C6BBC Offset: 0x87C2BBC VA: 0x87C6BBC
	public void set_useAutoMass(bool value) { }

	// RVA: 0x87C6C00 Offset: 0x87C2C00 VA: 0x87C6C00
	public float get_mass() { }

	// RVA: 0x87C6C3C Offset: 0x87C2C3C VA: 0x87C6C3C
	public void set_mass(float value) { }

	// RVA: 0x87C6C88 Offset: 0x87C2C88 VA: 0x87C6C88
	public PhysicsMaterial2D get_sharedMaterial() { }

	// RVA: 0x87C6CC4 Offset: 0x87C2CC4 VA: 0x87C6CC4
	public void set_sharedMaterial(PhysicsMaterial2D value) { }

	// RVA: 0x87C6D08 Offset: 0x87C2D08 VA: 0x87C6D08
	public Vector2 get_centerOfMass() { }

	// RVA: 0x87C6D98 Offset: 0x87C2D98 VA: 0x87C6D98
	public void set_centerOfMass(Vector2 value) { }

	// RVA: 0x87C6E24 Offset: 0x87C2E24 VA: 0x87C6E24
	public Vector2 get_worldCenterOfMass() { }

	// RVA: 0x87C6EB4 Offset: 0x87C2EB4 VA: 0x87C6EB4
	public float get_inertia() { }

	// RVA: 0x87C6EF0 Offset: 0x87C2EF0 VA: 0x87C6EF0
	public void set_inertia(float value) { }

	// RVA: 0x87C6F3C Offset: 0x87C2F3C VA: 0x87C6F3C
	public float get_drag() { }

	// RVA: 0x87C6F78 Offset: 0x87C2F78 VA: 0x87C6F78
	public void set_drag(float value) { }

	// RVA: 0x87C6FC4 Offset: 0x87C2FC4 VA: 0x87C6FC4
	public float get_angularDrag() { }

	// RVA: 0x87C7000 Offset: 0x87C3000 VA: 0x87C7000
	public void set_angularDrag(float value) { }

	// RVA: 0x87C704C Offset: 0x87C304C VA: 0x87C704C
	public float get_gravityScale() { }

	// RVA: 0x87C7088 Offset: 0x87C3088 VA: 0x87C7088
	public void set_gravityScale(float value) { }

	// RVA: 0x87C70D4 Offset: 0x87C30D4 VA: 0x87C70D4
	public RigidbodyType2D get_bodyType() { }

	[NativeMethod("SetBodyType_Binding")]
	// RVA: 0x87C7110 Offset: 0x87C3110 VA: 0x87C7110
	public void set_bodyType(RigidbodyType2D value) { }

	// RVA: 0x87C7154 Offset: 0x87C3154 VA: 0x87C7154
	internal void SetDragBehaviour(bool dragged) { }

	// RVA: 0x87C7198 Offset: 0x87C3198 VA: 0x87C7198
	public bool get_useFullKinematicContacts() { }

	// RVA: 0x87C71D4 Offset: 0x87C31D4 VA: 0x87C71D4
	public void set_useFullKinematicContacts(bool value) { }

	// RVA: 0x87C7218 Offset: 0x87C3218 VA: 0x87C7218
	public bool get_isKinematic() { }

	// RVA: 0x87C7260 Offset: 0x87C3260 VA: 0x87C7260
	public void set_isKinematic(bool value) { }

	// RVA: 0x87C72AC Offset: 0x87C32AC VA: 0x87C72AC
	public bool get_fixedAngle() { }

	// RVA: 0x87C72E8 Offset: 0x87C32E8 VA: 0x87C72E8
	public void set_fixedAngle(bool value) { }

	// RVA: 0x87C732C Offset: 0x87C332C VA: 0x87C732C
	public bool get_freezeRotation() { }

	// RVA: 0x87C7368 Offset: 0x87C3368 VA: 0x87C7368
	public void set_freezeRotation(bool value) { }

	// RVA: 0x87C73AC Offset: 0x87C33AC VA: 0x87C73AC
	public RigidbodyConstraints2D get_constraints() { }

	// RVA: 0x87C73E8 Offset: 0x87C33E8 VA: 0x87C73E8
	public void set_constraints(RigidbodyConstraints2D value) { }

	// RVA: 0x87C742C Offset: 0x87C342C VA: 0x87C742C
	public bool IsSleeping() { }

	// RVA: 0x87C7468 Offset: 0x87C3468 VA: 0x87C7468
	public bool IsAwake() { }

	// RVA: 0x87C74A4 Offset: 0x87C34A4 VA: 0x87C74A4
	public void Sleep() { }

	[NativeMethod("Wake")]
	// RVA: 0x87C74E0 Offset: 0x87C34E0 VA: 0x87C74E0
	public void WakeUp() { }

	// RVA: 0x87C751C Offset: 0x87C351C VA: 0x87C751C
	public bool get_simulated() { }

	[NativeMethod("SetSimulated_Binding")]
	// RVA: 0x87C7558 Offset: 0x87C3558 VA: 0x87C7558
	public void set_simulated(bool value) { }

	// RVA: 0x87C759C Offset: 0x87C359C VA: 0x87C759C
	public RigidbodyInterpolation2D get_interpolation() { }

	// RVA: 0x87C75D8 Offset: 0x87C35D8 VA: 0x87C75D8
	public void set_interpolation(RigidbodyInterpolation2D value) { }

	// RVA: 0x87C761C Offset: 0x87C361C VA: 0x87C761C
	public RigidbodySleepMode2D get_sleepMode() { }

	// RVA: 0x87C7658 Offset: 0x87C3658 VA: 0x87C7658
	public void set_sleepMode(RigidbodySleepMode2D value) { }

	// RVA: 0x87C769C Offset: 0x87C369C VA: 0x87C769C
	public CollisionDetectionMode2D get_collisionDetectionMode() { }

	// RVA: 0x87C76D8 Offset: 0x87C36D8 VA: 0x87C76D8
	public void set_collisionDetectionMode(CollisionDetectionMode2D value) { }

	// RVA: 0x87C771C Offset: 0x87C371C VA: 0x87C771C
	public int get_attachedColliderCount() { }

	// RVA: 0x87C7758 Offset: 0x87C3758 VA: 0x87C7758
	public Vector2 get_totalForce() { }

	// RVA: 0x87C77E8 Offset: 0x87C37E8 VA: 0x87C77E8
	public void set_totalForce(Vector2 value) { }

	// RVA: 0x87C7874 Offset: 0x87C3874 VA: 0x87C7874
	public float get_totalTorque() { }

	// RVA: 0x87C78B0 Offset: 0x87C38B0 VA: 0x87C78B0
	public void set_totalTorque(float value) { }

	// RVA: 0x87C78FC Offset: 0x87C38FC VA: 0x87C78FC
	public LayerMask get_excludeLayers() { }

	// RVA: 0x87C798C Offset: 0x87C398C VA: 0x87C798C
	public void set_excludeLayers(LayerMask value) { }

	// RVA: 0x87C7A18 Offset: 0x87C3A18 VA: 0x87C7A18
	public LayerMask get_includeLayers() { }

	// RVA: 0x87C7AA8 Offset: 0x87C3AA8 VA: 0x87C7AA8
	public void set_includeLayers(LayerMask value) { }

	// RVA: 0x87C7B34 Offset: 0x87C3B34 VA: 0x87C7B34
	public bool IsTouching(Collider2D collider) { }

	// RVA: 0x87C7B78 Offset: 0x87C3B78 VA: 0x87C7B78
	public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter) { }

	[NativeMethod("IsTouching")]
	// RVA: 0x87C7BE0 Offset: 0x87C3BE0 VA: 0x87C7BE0
	private bool IsTouching_OtherColliderWithFilter_Internal(Collider2D collider, ContactFilter2D contactFilter) { }

	// RVA: 0x87C7C88 Offset: 0x87C3C88 VA: 0x87C7C88
	public bool IsTouching(ContactFilter2D contactFilter) { }

	[NativeMethod("IsTouching")]
	// RVA: 0x87C7CE8 Offset: 0x87C3CE8 VA: 0x87C7CE8
	private bool IsTouching_AnyColliderWithFilter_Internal(ContactFilter2D contactFilter) { }

	[ExcludeFromDocs]
	// RVA: 0x87C7D70 Offset: 0x87C3D70 VA: 0x87C7D70
	public bool IsTouchingLayers() { }

	// RVA: 0x87C7DB0 Offset: 0x87C3DB0 VA: 0x87C7DB0
	public bool IsTouchingLayers(int layerMask) { }

	// RVA: 0x87C7DF4 Offset: 0x87C3DF4 VA: 0x87C7DF4
	public bool OverlapPoint(Vector2 point) { }

	// RVA: 0x87C7E84 Offset: 0x87C3E84 VA: 0x87C7E84
	public ColliderDistance2D Distance(Collider2D collider) { }

	[NativeMethod("Distance")]
	// RVA: 0x87C8024 Offset: 0x87C4024 VA: 0x87C8024
	private ColliderDistance2D Distance_Internal(Collider2D collider) { }

	// RVA: 0x87C80E8 Offset: 0x87C40E8 VA: 0x87C80E8
	public Vector2 ClosestPoint(Vector2 position) { }

	[ExcludeFromDocs]
	// RVA: 0x87C8154 Offset: 0x87C4154 VA: 0x87C8154
	public void AddForce(Vector2 force) { }

	// RVA: 0x87C815C Offset: 0x87C415C VA: 0x87C815C
	public void AddForce(Vector2 force, ForceMode2D mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87C8208 Offset: 0x87C4208 VA: 0x87C8208
	public void AddRelativeForce(Vector2 relativeForce) { }

	// RVA: 0x87C8210 Offset: 0x87C4210 VA: 0x87C8210
	public void AddRelativeForce(Vector2 relativeForce, ForceMode2D mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87C82BC Offset: 0x87C42BC VA: 0x87C82BC
	public void AddForceAtPosition(Vector2 force, Vector2 position) { }

	// RVA: 0x87C82C4 Offset: 0x87C42C4 VA: 0x87C82C4
	public void AddForceAtPosition(Vector2 force, Vector2 position, ForceMode2D mode) { }

	[ExcludeFromDocs]
	// RVA: 0x87C8380 Offset: 0x87C4380 VA: 0x87C8380
	public void AddTorque(float torque) { }

	// RVA: 0x87C83D0 Offset: 0x87C43D0 VA: 0x87C83D0
	public void AddTorque(float torque, ForceMode2D mode) { }

	// RVA: 0x87C8424 Offset: 0x87C4424 VA: 0x87C8424
	public Vector2 GetPoint(Vector2 point) { }

	// RVA: 0x87C84D0 Offset: 0x87C44D0 VA: 0x87C84D0
	public Vector2 GetRelativePoint(Vector2 relativePoint) { }

	// RVA: 0x87C857C Offset: 0x87C457C VA: 0x87C857C
	public Vector2 GetVector(Vector2 vector) { }

	// RVA: 0x87C8628 Offset: 0x87C4628 VA: 0x87C8628
	public Vector2 GetRelativeVector(Vector2 relativeVector) { }

	// RVA: 0x87C86D4 Offset: 0x87C46D4 VA: 0x87C86D4
	public Vector2 GetPointVelocity(Vector2 point) { }

	// RVA: 0x87C8780 Offset: 0x87C4780 VA: 0x87C8780
	public Vector2 GetRelativePointVelocity(Vector2 relativePoint) { }

	// RVA: 0x87C882C Offset: 0x87C482C VA: 0x87C882C
	public int OverlapCollider(ContactFilter2D contactFilter, [Out] Collider2D[] results) { }

	[NativeMethod("OverlapColliderArray_Binding")]
	// RVA: 0x87C8890 Offset: 0x87C4890 VA: 0x87C8890
	private int OverlapColliderArray_Internal(ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x87C8938 Offset: 0x87C4938 VA: 0x87C8938
	public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results) { }

	[NativeMethod("OverlapColliderList_Binding")]
	// RVA: 0x87C899C Offset: 0x87C499C VA: 0x87C899C
	private int OverlapColliderList_Internal(ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x87C8A44 Offset: 0x87C4A44 VA: 0x87C8A44
	public int GetContacts(ContactPoint2D[] contacts) { }

	// RVA: 0x87C8AF0 Offset: 0x87C4AF0 VA: 0x87C8AF0
	public int GetContacts(List<ContactPoint2D> contacts) { }

	// RVA: 0x87C8B9C Offset: 0x87C4B9C VA: 0x87C8B9C
	public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts) { }

	// RVA: 0x87C8C34 Offset: 0x87C4C34 VA: 0x87C8C34
	public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts) { }

	// RVA: 0x87C8CCC Offset: 0x87C4CCC VA: 0x87C8CCC
	public int GetContacts(Collider2D[] colliders) { }

	// RVA: 0x87C8D78 Offset: 0x87C4D78 VA: 0x87C8D78
	public int GetContacts(List<Collider2D> colliders) { }

	// RVA: 0x87C8E24 Offset: 0x87C4E24 VA: 0x87C8E24
	public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders) { }

	// RVA: 0x87C8EBC Offset: 0x87C4EBC VA: 0x87C8EBC
	public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders) { }

	// RVA: 0x87C8F54 Offset: 0x87C4F54 VA: 0x87C8F54
	public int GetAttachedColliders([Out] Collider2D[] results) { }

	[NativeMethod("GetAttachedCollidersArray_Binding")]
	// RVA: 0x87C8F98 Offset: 0x87C4F98 VA: 0x87C8F98
	private int GetAttachedCollidersArray_Internal(Collider2D[] results) { }

	// RVA: 0x87C8FDC Offset: 0x87C4FDC VA: 0x87C8FDC
	public int GetAttachedColliders(List<Collider2D> results) { }

	[NativeMethod("GetAttachedCollidersList_Binding")]
	// RVA: 0x87C9020 Offset: 0x87C5020 VA: 0x87C9020
	private int GetAttachedCollidersList_Internal(List<Collider2D> results) { }

	[ExcludeFromDocs]
	// RVA: 0x87C9064 Offset: 0x87C5064 VA: 0x87C9064
	public int Cast(Vector2 direction, RaycastHit2D[] results) { }

	// RVA: 0x87C90D0 Offset: 0x87C50D0 VA: 0x87C90D0
	public int Cast(Vector2 direction, RaycastHit2D[] results, float distance) { }

	[NativeMethod("CastArray_Binding")]
	// RVA: 0x87C9070 Offset: 0x87C5070 VA: 0x87C9070
	private int CastArray_Internal(Vector2 direction, float distance, RaycastHit2D[] results) { }

	// RVA: 0x87C9138 Offset: 0x87C5138 VA: 0x87C9138
	public int Cast(Vector2 direction, List<RaycastHit2D> results, float distance = ∞) { }

	[NativeMethod("CastList_Binding")]
	// RVA: 0x87C913C Offset: 0x87C513C VA: 0x87C913C
	private int CastList_Internal(Vector2 direction, float distance, List<RaycastHit2D> results) { }

	[ExcludeFromDocs]
	// RVA: 0x87C9200 Offset: 0x87C5200 VA: 0x87C9200
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x87C92AC Offset: 0x87C52AC VA: 0x87C92AC
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	[NativeMethod("CastFilteredArray_Binding")]
	// RVA: 0x87C9234 Offset: 0x87C5234 VA: 0x87C9234
	private int CastFilteredArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x87C9344 Offset: 0x87C5344 VA: 0x87C9344
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance) { }

	[NativeMethod("CastFilteredList_Binding")]
	// RVA: 0x87C9370 Offset: 0x87C5370 VA: 0x87C9370
	private int CastFilteredList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x87C9454 Offset: 0x87C5454 VA: 0x87C9454
	public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup) { }

	[NativeMethod("GetShapes_Binding")]
	// RVA: 0x87C94A0 Offset: 0x87C54A0 VA: 0x87C94A0
	private int GetShapes_Internal(ref PhysicsShapeGroup2D.GroupState physicsShapeGroupState) { }

	// RVA: 0x87C94E4 Offset: 0x87C54E4 VA: 0x87C94E4
	public void .ctor() { }

	// RVA: 0x87C6590 Offset: 0x87C2590 VA: 0x87C6590
	private void get_position_Injected(out Vector2 ret) { }

	// RVA: 0x87C661C Offset: 0x87C261C VA: 0x87C661C
	private void set_position_Injected(ref Vector2 value) { }

	// RVA: 0x87C67D8 Offset: 0x87C27D8 VA: 0x87C67D8
	private void SetRotation_Quaternion_Injected(ref Quaternion rotation) { }

	// RVA: 0x87C6864 Offset: 0x87C2864 VA: 0x87C6864
	private void MovePosition_Injected(ref Vector2 position) { }

	// RVA: 0x87C6998 Offset: 0x87C2998 VA: 0x87C6998
	private void MoveRotation_Quaternion_Injected(ref Quaternion rotation) { }

	// RVA: 0x87C6A28 Offset: 0x87C2A28 VA: 0x87C6A28
	private void get_velocity_Injected(out Vector2 ret) { }

	// RVA: 0x87C6AB4 Offset: 0x87C2AB4 VA: 0x87C6AB4
	private void set_velocity_Injected(ref Vector2 value) { }

	// RVA: 0x87C6D54 Offset: 0x87C2D54 VA: 0x87C6D54
	private void get_centerOfMass_Injected(out Vector2 ret) { }

	// RVA: 0x87C6DE0 Offset: 0x87C2DE0 VA: 0x87C6DE0
	private void set_centerOfMass_Injected(ref Vector2 value) { }

	// RVA: 0x87C6E70 Offset: 0x87C2E70 VA: 0x87C6E70
	private void get_worldCenterOfMass_Injected(out Vector2 ret) { }

	// RVA: 0x87C77A4 Offset: 0x87C37A4 VA: 0x87C77A4
	private void get_totalForce_Injected(out Vector2 ret) { }

	// RVA: 0x87C7830 Offset: 0x87C3830 VA: 0x87C7830
	private void set_totalForce_Injected(ref Vector2 value) { }

	// RVA: 0x87C7948 Offset: 0x87C3948 VA: 0x87C7948
	private void get_excludeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87C79D4 Offset: 0x87C39D4 VA: 0x87C79D4
	private void set_excludeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87C7A64 Offset: 0x87C3A64 VA: 0x87C7A64
	private void get_includeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87C7AF0 Offset: 0x87C3AF0 VA: 0x87C7AF0
	private void set_includeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87C7C34 Offset: 0x87C3C34 VA: 0x87C7C34
	private bool IsTouching_OtherColliderWithFilter_Internal_Injected(Collider2D collider, ref ContactFilter2D contactFilter) { }

	// RVA: 0x87C7D2C Offset: 0x87C3D2C VA: 0x87C7D2C
	private bool IsTouching_AnyColliderWithFilter_Internal_Injected(ref ContactFilter2D contactFilter) { }

	// RVA: 0x87C7E40 Offset: 0x87C3E40 VA: 0x87C7E40
	private bool OverlapPoint_Injected(ref Vector2 point) { }

	// RVA: 0x87C8094 Offset: 0x87C4094 VA: 0x87C8094
	private void Distance_Internal_Injected(Collider2D collider, out ColliderDistance2D ret) { }

	// RVA: 0x87C81B4 Offset: 0x87C41B4 VA: 0x87C81B4
	private void AddForce_Injected(ref Vector2 force, ForceMode2D mode) { }

	// RVA: 0x87C8268 Offset: 0x87C4268 VA: 0x87C8268
	private void AddRelativeForce_Injected(ref Vector2 relativeForce, ForceMode2D mode) { }

	// RVA: 0x87C8324 Offset: 0x87C4324 VA: 0x87C8324
	private void AddForceAtPosition_Injected(ref Vector2 force, ref Vector2 position, ForceMode2D mode) { }

	// RVA: 0x87C847C Offset: 0x87C447C VA: 0x87C847C
	private void GetPoint_Injected(ref Vector2 point, out Vector2 ret) { }

	// RVA: 0x87C8528 Offset: 0x87C4528 VA: 0x87C8528
	private void GetRelativePoint_Injected(ref Vector2 relativePoint, out Vector2 ret) { }

	// RVA: 0x87C85D4 Offset: 0x87C45D4 VA: 0x87C85D4
	private void GetVector_Injected(ref Vector2 vector, out Vector2 ret) { }

	// RVA: 0x87C8680 Offset: 0x87C4680 VA: 0x87C8680
	private void GetRelativeVector_Injected(ref Vector2 relativeVector, out Vector2 ret) { }

	// RVA: 0x87C872C Offset: 0x87C472C VA: 0x87C872C
	private void GetPointVelocity_Injected(ref Vector2 point, out Vector2 ret) { }

	// RVA: 0x87C87D8 Offset: 0x87C47D8 VA: 0x87C87D8
	private void GetRelativePointVelocity_Injected(ref Vector2 relativePoint, out Vector2 ret) { }

	// RVA: 0x87C88E4 Offset: 0x87C48E4 VA: 0x87C88E4
	private int OverlapColliderArray_Internal_Injected(ref ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x87C89F0 Offset: 0x87C49F0 VA: 0x87C89F0
	private int OverlapColliderList_Internal_Injected(ref ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x87C90D4 Offset: 0x87C50D4 VA: 0x87C90D4
	private int CastArray_Internal_Injected(ref Vector2 direction, float distance, RaycastHit2D[] results) { }

	// RVA: 0x87C919C Offset: 0x87C519C VA: 0x87C919C
	private int CastList_Internal_Injected(ref Vector2 direction, float distance, List<RaycastHit2D> results) { }

	// RVA: 0x87C92D8 Offset: 0x87C52D8 VA: 0x87C92D8
	private int CastFilteredArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x87C93E8 Offset: 0x87C53E8 VA: 0x87C93E8
	private int CastFilteredList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequiredByNativeCode(Optional = True)]
[RequireComponent(typeof(Transform))]
public class Collider2D : Behaviour // TypeDefIndex: 27759
{
	// Properties
	public float density { get; set; }
	public bool isTrigger { get; set; }
	public bool usedByEffector { get; set; }
	public bool usedByComposite { get; set; }
	public CompositeCollider2D composite { get; }
	public Vector2 offset { get; set; }
	public Rigidbody2D attachedRigidbody { get; }
	public int shapeCount { get; }
	public Bounds bounds { get; }
	public ColliderErrorState2D errorState { get; }
	internal bool compositeCapable { get; }
	public PhysicsMaterial2D sharedMaterial { get; set; }
	public int layerOverridePriority { get; set; }
	public LayerMask excludeLayers { get; set; }
	public LayerMask includeLayers { get; set; }
	public LayerMask forceSendLayers { get; set; }
	public LayerMask forceReceiveLayers { get; set; }
	public LayerMask contactCaptureLayers { get; set; }
	public LayerMask callbackLayers { get; set; }
	public float friction { get; }
	public float bounciness { get; }

	// Methods

	// RVA: 0x87C94EC Offset: 0x87C54EC VA: 0x87C94EC
	public float get_density() { }

	// RVA: 0x87C9528 Offset: 0x87C5528 VA: 0x87C9528
	public void set_density(float value) { }

	// RVA: 0x87C9574 Offset: 0x87C5574 VA: 0x87C9574
	public bool get_isTrigger() { }

	// RVA: 0x87C95B0 Offset: 0x87C55B0 VA: 0x87C95B0
	public void set_isTrigger(bool value) { }

	// RVA: 0x87C95F4 Offset: 0x87C55F4 VA: 0x87C95F4
	public bool get_usedByEffector() { }

	// RVA: 0x87C9630 Offset: 0x87C5630 VA: 0x87C9630
	public void set_usedByEffector(bool value) { }

	// RVA: 0x87C9674 Offset: 0x87C5674 VA: 0x87C9674
	public bool get_usedByComposite() { }

	// RVA: 0x87C96B0 Offset: 0x87C56B0 VA: 0x87C96B0
	public void set_usedByComposite(bool value) { }

	// RVA: 0x87C96F4 Offset: 0x87C56F4 VA: 0x87C96F4
	public CompositeCollider2D get_composite() { }

	// RVA: 0x87C9730 Offset: 0x87C5730 VA: 0x87C9730
	public Vector2 get_offset() { }

	// RVA: 0x87C97C0 Offset: 0x87C57C0 VA: 0x87C97C0
	public void set_offset(Vector2 value) { }

	[NativeMethod("GetAttachedRigidbody_Binding")]
	// RVA: 0x87C63C0 Offset: 0x87C23C0 VA: 0x87C63C0
	public Rigidbody2D get_attachedRigidbody() { }

	// RVA: 0x87C984C Offset: 0x87C584C VA: 0x87C984C
	public int get_shapeCount() { }

	[NativeMethod("CreateMesh_Binding")]
	// RVA: 0x87C9888 Offset: 0x87C5888 VA: 0x87C9888
	public Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation) { }

	[NativeMethod("GetShapeHash_Binding")]
	// RVA: 0x87C98DC Offset: 0x87C58DC VA: 0x87C98DC
	public uint GetShapeHash() { }

	// RVA: 0x87C9918 Offset: 0x87C5918 VA: 0x87C9918
	public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup) { }

	// RVA: 0x87C99FC Offset: 0x87C59FC VA: 0x87C99FC
	public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, int shapeCount = 1) { }

	[NativeMethod("GetShapes_Binding")]
	// RVA: 0x87C99A0 Offset: 0x87C59A0 VA: 0x87C99A0
	private int GetShapes_Internal(ref PhysicsShapeGroup2D.GroupState physicsShapeGroupState, int shapeIndex, int shapeCount) { }

	// RVA: 0x87C9B68 Offset: 0x87C5B68 VA: 0x87C9B68
	public Bounds get_bounds() { }

	// RVA: 0x87C9C14 Offset: 0x87C5C14 VA: 0x87C9C14
	public ColliderErrorState2D get_errorState() { }

	[NativeMethod("GetCompositeCapable_Binding")]
	// RVA: 0x87C9C50 Offset: 0x87C5C50 VA: 0x87C9C50
	internal bool get_compositeCapable() { }

	[NativeMethod("GetMaterial")]
	// RVA: 0x87C9C8C Offset: 0x87C5C8C VA: 0x87C9C8C
	public PhysicsMaterial2D get_sharedMaterial() { }

	[NativeMethod("SetMaterial")]
	// RVA: 0x87C9CC8 Offset: 0x87C5CC8 VA: 0x87C9CC8
	public void set_sharedMaterial(PhysicsMaterial2D value) { }

	// RVA: 0x87C9D0C Offset: 0x87C5D0C VA: 0x87C9D0C
	public int get_layerOverridePriority() { }

	// RVA: 0x87C9D48 Offset: 0x87C5D48 VA: 0x87C9D48
	public void set_layerOverridePriority(int value) { }

	// RVA: 0x87C9D8C Offset: 0x87C5D8C VA: 0x87C9D8C
	public LayerMask get_excludeLayers() { }

	// RVA: 0x87C9E1C Offset: 0x87C5E1C VA: 0x87C9E1C
	public void set_excludeLayers(LayerMask value) { }

	// RVA: 0x87C9EA8 Offset: 0x87C5EA8 VA: 0x87C9EA8
	public LayerMask get_includeLayers() { }

	// RVA: 0x87C9F38 Offset: 0x87C5F38 VA: 0x87C9F38
	public void set_includeLayers(LayerMask value) { }

	// RVA: 0x87C9FC4 Offset: 0x87C5FC4 VA: 0x87C9FC4
	public LayerMask get_forceSendLayers() { }

	// RVA: 0x87CA054 Offset: 0x87C6054 VA: 0x87CA054
	public void set_forceSendLayers(LayerMask value) { }

	// RVA: 0x87CA0E0 Offset: 0x87C60E0 VA: 0x87CA0E0
	public LayerMask get_forceReceiveLayers() { }

	// RVA: 0x87CA170 Offset: 0x87C6170 VA: 0x87CA170
	public void set_forceReceiveLayers(LayerMask value) { }

	// RVA: 0x87CA1FC Offset: 0x87C61FC VA: 0x87CA1FC
	public LayerMask get_contactCaptureLayers() { }

	// RVA: 0x87CA28C Offset: 0x87C628C VA: 0x87CA28C
	public void set_contactCaptureLayers(LayerMask value) { }

	// RVA: 0x87CA318 Offset: 0x87C6318 VA: 0x87CA318
	public LayerMask get_callbackLayers() { }

	// RVA: 0x87CA3A8 Offset: 0x87C63A8 VA: 0x87CA3A8
	public void set_callbackLayers(LayerMask value) { }

	// RVA: 0x87CA434 Offset: 0x87C6434 VA: 0x87CA434
	public float get_friction() { }

	// RVA: 0x87CA470 Offset: 0x87C6470 VA: 0x87CA470
	public float get_bounciness() { }

	// RVA: 0x87CA4AC Offset: 0x87C64AC VA: 0x87CA4AC
	public bool IsTouching(Collider2D collider) { }

	// RVA: 0x87CA4F0 Offset: 0x87C64F0 VA: 0x87CA4F0
	public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter) { }

	[NativeMethod("IsTouching")]
	// RVA: 0x87CA558 Offset: 0x87C6558 VA: 0x87CA558
	private bool IsTouching_OtherColliderWithFilter(Collider2D collider, ContactFilter2D contactFilter) { }

	// RVA: 0x87CA600 Offset: 0x87C6600 VA: 0x87CA600
	public bool IsTouching(ContactFilter2D contactFilter) { }

	[NativeMethod("IsTouching")]
	// RVA: 0x87CA660 Offset: 0x87C6660 VA: 0x87CA660
	private bool IsTouching_AnyColliderWithFilter(ContactFilter2D contactFilter) { }

	[ExcludeFromDocs]
	// RVA: 0x87CA6E8 Offset: 0x87C66E8 VA: 0x87CA6E8
	public bool IsTouchingLayers() { }

	// RVA: 0x87CA728 Offset: 0x87C6728 VA: 0x87CA728
	public bool IsTouchingLayers(int layerMask) { }

	// RVA: 0x87CA76C Offset: 0x87C676C VA: 0x87CA76C
	public bool OverlapPoint(Vector2 point) { }

	// RVA: 0x87CA7FC Offset: 0x87C67FC VA: 0x87CA7FC
	public ColliderDistance2D Distance(Collider2D collider) { }

	// RVA: 0x87CA884 Offset: 0x87C6884 VA: 0x87CA884
	public int OverlapCollider(ContactFilter2D contactFilter, Collider2D[] results) { }

	// RVA: 0x87CA8E8 Offset: 0x87C68E8 VA: 0x87CA8E8
	public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results) { }

	// RVA: 0x87CA94C Offset: 0x87C694C VA: 0x87CA94C
	public int GetContacts(ContactPoint2D[] contacts) { }

	// RVA: 0x87CA9F8 Offset: 0x87C69F8 VA: 0x87CA9F8
	public int GetContacts(List<ContactPoint2D> contacts) { }

	// RVA: 0x87CAAA4 Offset: 0x87C6AA4 VA: 0x87CAAA4
	public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts) { }

	// RVA: 0x87CAB3C Offset: 0x87C6B3C VA: 0x87CAB3C
	public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts) { }

	// RVA: 0x87CABD4 Offset: 0x87C6BD4 VA: 0x87CABD4
	public int GetContacts(Collider2D[] colliders) { }

	// RVA: 0x87CAC80 Offset: 0x87C6C80 VA: 0x87CAC80
	public int GetContacts(List<Collider2D> colliders) { }

	// RVA: 0x87CAD2C Offset: 0x87C6D2C VA: 0x87CAD2C
	public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders) { }

	// RVA: 0x87CADC4 Offset: 0x87C6DC4 VA: 0x87CADC4
	public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders) { }

	[ExcludeFromDocs]
	// RVA: 0x87CAE5C Offset: 0x87C6E5C VA: 0x87CAE5C
	public int Cast(Vector2 direction, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	// RVA: 0x87CAFF4 Offset: 0x87C6FF4 VA: 0x87CAFF4
	public int Cast(Vector2 direction, RaycastHit2D[] results, float distance) { }

	// RVA: 0x87CB11C Offset: 0x87C711C VA: 0x87CB11C
	public int Cast(Vector2 direction, RaycastHit2D[] results, float distance, bool ignoreSiblingColliders) { }

	[ExcludeFromDocs]
	// RVA: 0x87CB248 Offset: 0x87C7248 VA: 0x87CB248
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	// RVA: 0x87CB284 Offset: 0x87C7284 VA: 0x87CB284
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x87CB2B8 Offset: 0x87C72B8 VA: 0x87CB2B8
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance, bool ignoreSiblingColliders) { }

	[NativeMethod("CastArray_Binding")]
	// RVA: 0x87CAF7C Offset: 0x87C6F7C VA: 0x87CAF7C
	private int CastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, RaycastHit2D[] results) { }

	// RVA: 0x87CB36C Offset: 0x87C736C VA: 0x87CB36C
	public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞, bool ignoreSiblingColliders = True) { }

	[NativeMethod("CastList_Binding")]
	// RVA: 0x87CB3A4 Offset: 0x87C73A4 VA: 0x87CB3A4
	private int CastList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, List<RaycastHit2D> results) { }

	[ExcludeFromDocs]
	// RVA: 0x87CB498 Offset: 0x87C7498 VA: 0x87CB498
	public int Raycast(Vector2 direction, RaycastHit2D[] results) { }

	[ExcludeFromDocs]
	// RVA: 0x87CB5A4 Offset: 0x87C75A4 VA: 0x87CB5A4
	public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance) { }

	[ExcludeFromDocs]
	// RVA: 0x87CB638 Offset: 0x87C7638 VA: 0x87CB638
	public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x87CB6CC Offset: 0x87C76CC VA: 0x87CB6CC
	public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth) { }

	// RVA: 0x87CB75C Offset: 0x87C775C VA: 0x87CB75C
	public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocs]
	// RVA: 0x87CB7E8 Offset: 0x87C77E8 VA: 0x87CB7E8
	public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x87CB81C Offset: 0x87C781C VA: 0x87CB81C
	public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	[NativeMethod("RaycastArray_Binding")]
	// RVA: 0x87CB52C Offset: 0x87C752C VA: 0x87CB52C
	private int RaycastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x87CB8B4 Offset: 0x87C78B4 VA: 0x87CB8B4
	public int Raycast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[NativeMethod("RaycastList_Binding")]
	// RVA: 0x87CB8E0 Offset: 0x87C78E0 VA: 0x87CB8E0
	private int RaycastList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x87CB9C4 Offset: 0x87C79C4 VA: 0x87CB9C4
	public Vector2 ClosestPoint(Vector2 position) { }

	// RVA: 0x87CBA30 Offset: 0x87C7A30 VA: 0x87CBA30
	public void .ctor() { }

	// RVA: 0x87C977C Offset: 0x87C577C VA: 0x87C977C
	private void get_offset_Injected(out Vector2 ret) { }

	// RVA: 0x87C9808 Offset: 0x87C5808 VA: 0x87C9808
	private void set_offset_Injected(ref Vector2 value) { }

	// RVA: 0x87C9BD0 Offset: 0x87C5BD0 VA: 0x87C9BD0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x87C9DD8 Offset: 0x87C5DD8 VA: 0x87C9DD8
	private void get_excludeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87C9E64 Offset: 0x87C5E64 VA: 0x87C9E64
	private void set_excludeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87C9EF4 Offset: 0x87C5EF4 VA: 0x87C9EF4
	private void get_includeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87C9F80 Offset: 0x87C5F80 VA: 0x87C9F80
	private void set_includeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87CA010 Offset: 0x87C6010 VA: 0x87CA010
	private void get_forceSendLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87CA09C Offset: 0x87C609C VA: 0x87CA09C
	private void set_forceSendLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87CA12C Offset: 0x87C612C VA: 0x87CA12C
	private void get_forceReceiveLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87CA1B8 Offset: 0x87C61B8 VA: 0x87CA1B8
	private void set_forceReceiveLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87CA248 Offset: 0x87C6248 VA: 0x87CA248
	private void get_contactCaptureLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87CA2D4 Offset: 0x87C62D4 VA: 0x87CA2D4
	private void set_contactCaptureLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87CA364 Offset: 0x87C6364 VA: 0x87CA364
	private void get_callbackLayers_Injected(out LayerMask ret) { }

	// RVA: 0x87CA3F0 Offset: 0x87C63F0 VA: 0x87CA3F0
	private void set_callbackLayers_Injected(ref LayerMask value) { }

	// RVA: 0x87CA5AC Offset: 0x87C65AC VA: 0x87CA5AC
	private bool IsTouching_OtherColliderWithFilter_Injected(Collider2D collider, ref ContactFilter2D contactFilter) { }

	// RVA: 0x87CA6A4 Offset: 0x87C66A4 VA: 0x87CA6A4
	private bool IsTouching_AnyColliderWithFilter_Injected(ref ContactFilter2D contactFilter) { }

	// RVA: 0x87CA7B8 Offset: 0x87C67B8 VA: 0x87CA7B8
	private bool OverlapPoint_Injected(ref Vector2 point) { }

	// RVA: 0x87CB2F0 Offset: 0x87C72F0 VA: 0x87CB2F0
	private int CastArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, RaycastHit2D[] results) { }

	// RVA: 0x87CB41C Offset: 0x87C741C VA: 0x87CB41C
	private int CastList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, List<RaycastHit2D> results) { }

	// RVA: 0x87CB848 Offset: 0x87C7848 VA: 0x87CB848
	private int RaycastArray_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x87CB958 Offset: 0x87C7958 VA: 0x87CB958
	private int RaycastList_Internal_Injected(ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/CircleCollider2D.h")]
public sealed class CircleCollider2D : Collider2D // TypeDefIndex: 27760
{
	// Properties
	public float radius { get; set; }
	[Obsolete("CircleCollider2D.center has been deprecated. Use CircleCollider2D.offset instead (UnityUpgradable) -> offset", True)]
	[EditorBrowsable(1)]
	public Vector2 center { get; set; }

	// Methods

	// RVA: 0x87CBA38 Offset: 0x87C7A38 VA: 0x87CBA38
	public float get_radius() { }

	// RVA: 0x87CBA74 Offset: 0x87C7A74 VA: 0x87CBA74
	public void set_radius(float value) { }

	// RVA: 0x87CBAC0 Offset: 0x87C7AC0 VA: 0x87CBAC0
	public Vector2 get_center() { }

	// RVA: 0x87CBB00 Offset: 0x87C7B00 VA: 0x87CBB00
	public void set_center(Vector2 value) { }

	// RVA: 0x87CBB04 Offset: 0x87C7B04 VA: 0x87CBB04
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/CapsuleCollider2D.h")]
public sealed class CapsuleCollider2D : Collider2D // TypeDefIndex: 27761
{
	// Properties
	public Vector2 size { get; set; }
	public CapsuleDirection2D direction { get; set; }

	// Methods

	// RVA: 0x87CBB0C Offset: 0x87C7B0C VA: 0x87CBB0C
	public Vector2 get_size() { }

	// RVA: 0x87CBB9C Offset: 0x87C7B9C VA: 0x87CBB9C
	public void set_size(Vector2 value) { }

	// RVA: 0x87CBC28 Offset: 0x87C7C28 VA: 0x87CBC28
	public CapsuleDirection2D get_direction() { }

	// RVA: 0x87CBC64 Offset: 0x87C7C64 VA: 0x87CBC64
	public void set_direction(CapsuleDirection2D value) { }

	// RVA: 0x87CBCA8 Offset: 0x87C7CA8 VA: 0x87CBCA8
	public void .ctor() { }

	// RVA: 0x87CBB58 Offset: 0x87C7B58 VA: 0x87CBB58
	private void get_size_Injected(out Vector2 ret) { }

	// RVA: 0x87CBBE4 Offset: 0x87C7BE4 VA: 0x87CBBE4
	private void set_size_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/EdgeCollider2D.h")]
public sealed class EdgeCollider2D : Collider2D // TypeDefIndex: 27762
{
	// Properties
	public float edgeRadius { get; set; }
	public int edgeCount { get; }
	public int pointCount { get; }
	public Vector2[] points { get; set; }
	public bool useAdjacentStartPoint { get; set; }
	public bool useAdjacentEndPoint { get; set; }
	public Vector2 adjacentStartPoint { get; set; }
	public Vector2 adjacentEndPoint { get; set; }

	// Methods

	// RVA: 0x87CBCB0 Offset: 0x87C7CB0 VA: 0x87CBCB0
	public void Reset() { }

	// RVA: 0x87CBCEC Offset: 0x87C7CEC VA: 0x87CBCEC
	public float get_edgeRadius() { }

	// RVA: 0x87CBD28 Offset: 0x87C7D28 VA: 0x87CBD28
	public void set_edgeRadius(float value) { }

	// RVA: 0x87CBD74 Offset: 0x87C7D74 VA: 0x87CBD74
	public int get_edgeCount() { }

	// RVA: 0x87CBDB0 Offset: 0x87C7DB0 VA: 0x87CBDB0
	public int get_pointCount() { }

	// RVA: 0x87CBDEC Offset: 0x87C7DEC VA: 0x87CBDEC
	public Vector2[] get_points() { }

	// RVA: 0x87CBE28 Offset: 0x87C7E28 VA: 0x87CBE28
	public void set_points(Vector2[] value) { }

	[NativeMethod("GetPoints_Binding")]
	// RVA: 0x87CBE6C Offset: 0x87C7E6C VA: 0x87CBE6C
	public int GetPoints(List<Vector2> points) { }

	[NativeMethod("SetPoints_Binding")]
	// RVA: 0x87CBEB0 Offset: 0x87C7EB0 VA: 0x87CBEB0
	public bool SetPoints(List<Vector2> points) { }

	// RVA: 0x87CBEF4 Offset: 0x87C7EF4 VA: 0x87CBEF4
	public bool get_useAdjacentStartPoint() { }

	// RVA: 0x87CBF30 Offset: 0x87C7F30 VA: 0x87CBF30
	public void set_useAdjacentStartPoint(bool value) { }

	// RVA: 0x87CBF74 Offset: 0x87C7F74 VA: 0x87CBF74
	public bool get_useAdjacentEndPoint() { }

	// RVA: 0x87CBFB0 Offset: 0x87C7FB0 VA: 0x87CBFB0
	public void set_useAdjacentEndPoint(bool value) { }

	// RVA: 0x87CBFF4 Offset: 0x87C7FF4 VA: 0x87CBFF4
	public Vector2 get_adjacentStartPoint() { }

	// RVA: 0x87CC084 Offset: 0x87C8084 VA: 0x87CC084
	public void set_adjacentStartPoint(Vector2 value) { }

	// RVA: 0x87CC110 Offset: 0x87C8110 VA: 0x87CC110
	public Vector2 get_adjacentEndPoint() { }

	// RVA: 0x87CC1A0 Offset: 0x87C81A0 VA: 0x87CC1A0
	public void set_adjacentEndPoint(Vector2 value) { }

	// RVA: 0x87CC22C Offset: 0x87C822C VA: 0x87CC22C
	public void .ctor() { }

	// RVA: 0x87CC040 Offset: 0x87C8040 VA: 0x87CC040
	private void get_adjacentStartPoint_Injected(out Vector2 ret) { }

	// RVA: 0x87CC0CC Offset: 0x87C80CC VA: 0x87CC0CC
	private void set_adjacentStartPoint_Injected(ref Vector2 value) { }

	// RVA: 0x87CC15C Offset: 0x87C815C VA: 0x87CC15C
	private void get_adjacentEndPoint_Injected(out Vector2 ret) { }

	// RVA: 0x87CC1E8 Offset: 0x87C81E8 VA: 0x87CC1E8
	private void set_adjacentEndPoint_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
public sealed class BoxCollider2D : Collider2D // TypeDefIndex: 27763
{
	// Properties
	public Vector2 size { get; set; }
	public float edgeRadius { get; set; }
	public bool autoTiling { get; set; }
	[Obsolete("BoxCollider2D.center has been deprecated. Use BoxCollider2D.offset instead (UnityUpgradable) -> offset", True)]
	[EditorBrowsable(1)]
	public Vector2 center { get; set; }

	// Methods

	// RVA: 0x87CC234 Offset: 0x87C8234 VA: 0x87CC234
	public Vector2 get_size() { }

	// RVA: 0x87CC2C4 Offset: 0x87C82C4 VA: 0x87CC2C4
	public void set_size(Vector2 value) { }

	// RVA: 0x87CC350 Offset: 0x87C8350 VA: 0x87CC350
	public float get_edgeRadius() { }

	// RVA: 0x87CC38C Offset: 0x87C838C VA: 0x87CC38C
	public void set_edgeRadius(float value) { }

	// RVA: 0x87CC3D8 Offset: 0x87C83D8 VA: 0x87CC3D8
	public bool get_autoTiling() { }

	// RVA: 0x87CC414 Offset: 0x87C8414 VA: 0x87CC414
	public void set_autoTiling(bool value) { }

	// RVA: 0x87CC458 Offset: 0x87C8458 VA: 0x87CC458
	public Vector2 get_center() { }

	// RVA: 0x87CC498 Offset: 0x87C8498 VA: 0x87CC498
	public void set_center(Vector2 value) { }

	// RVA: 0x87CC49C Offset: 0x87C849C VA: 0x87CC49C
	public void .ctor() { }

	// RVA: 0x87CC280 Offset: 0x87C8280 VA: 0x87CC280
	private void get_size_Injected(out Vector2 ret) { }

	// RVA: 0x87CC30C Offset: 0x87C830C VA: 0x87CC30C
	private void set_size_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
public sealed class PolygonCollider2D : Collider2D // TypeDefIndex: 27764
{
	// Properties
	public bool useDelaunayMesh { get; set; }
	public bool autoTiling { get; set; }
	public Vector2[] points { get; set; }
	public int pathCount { get; set; }

	// Methods

	// RVA: 0x87CC4A4 Offset: 0x87C84A4 VA: 0x87CC4A4
	public bool get_useDelaunayMesh() { }

	// RVA: 0x87CC4E0 Offset: 0x87C84E0 VA: 0x87CC4E0
	public void set_useDelaunayMesh(bool value) { }

	// RVA: 0x87CC524 Offset: 0x87C8524 VA: 0x87CC524
	public bool get_autoTiling() { }

	// RVA: 0x87CC560 Offset: 0x87C8560 VA: 0x87CC560
	public void set_autoTiling(bool value) { }

	[NativeMethod("GetPointCount")]
	// RVA: 0x87CC5A4 Offset: 0x87C85A4 VA: 0x87CC5A4
	public int GetTotalPointCount() { }

	[NativeMethod("GetPoints_Binding")]
	// RVA: 0x87CC5E0 Offset: 0x87C85E0 VA: 0x87CC5E0
	public Vector2[] get_points() { }

	[NativeMethod("SetPoints_Binding")]
	// RVA: 0x87CC61C Offset: 0x87C861C VA: 0x87CC61C
	public void set_points(Vector2[] value) { }

	// RVA: 0x87CC660 Offset: 0x87C8660 VA: 0x87CC660
	public int get_pathCount() { }

	// RVA: 0x87CC69C Offset: 0x87C869C VA: 0x87CC69C
	public void set_pathCount(int value) { }

	// RVA: 0x87CC6E0 Offset: 0x87C86E0 VA: 0x87CC6E0
	public Vector2[] GetPath(int index) { }

	[NativeMethod("GetPath_Binding")]
	// RVA: 0x87CC7F8 Offset: 0x87C87F8 VA: 0x87CC7F8
	private Vector2[] GetPath_Internal(int index) { }

	// RVA: 0x87CC83C Offset: 0x87C883C VA: 0x87CC83C
	public void SetPath(int index, Vector2[] points) { }

	[NativeMethod("SetPath_Binding")]
	// RVA: 0x87CC904 Offset: 0x87C8904 VA: 0x87CC904
	private void SetPath_Internal(int index, Vector2[] points) { }

	// RVA: 0x87CC958 Offset: 0x87C8958 VA: 0x87CC958
	public int GetPath(int index, List<Vector2> points) { }

	[NativeMethod("GetPathList_Binding")]
	// RVA: 0x87CCADC Offset: 0x87C8ADC VA: 0x87CCADC
	private int GetPathList_Internal(int index, List<Vector2> points) { }

	// RVA: 0x87CCB30 Offset: 0x87C8B30 VA: 0x87CCB30
	public void SetPath(int index, List<Vector2> points) { }

	[NativeMethod("SetPathList_Binding")]
	// RVA: 0x87CCBF8 Offset: 0x87C8BF8 VA: 0x87CCBF8
	private void SetPathList_Internal(int index, List<Vector2> points) { }

	[ExcludeFromDocs]
	// RVA: 0x87CCC4C Offset: 0x87C8C4C VA: 0x87CCC4C
	public void CreatePrimitive(int sides) { }

	[ExcludeFromDocs]
	// RVA: 0x87CCDF0 Offset: 0x87C8DF0 VA: 0x87CCDF0
	public void CreatePrimitive(int sides, Vector2 scale) { }

	// RVA: 0x87CCCE4 Offset: 0x87C8CE4 VA: 0x87CCCE4
	public void CreatePrimitive(int sides, Vector2 scale, Vector2 offset) { }

	[NativeMethod("CreatePrimitive")]
	// RVA: 0x87CCE60 Offset: 0x87C8E60 VA: 0x87CCE60
	private void CreatePrimitive_Internal(int sides, Vector2 scale, Vector2 offset, bool autoRefresh) { }

	// RVA: 0x87CCF3C Offset: 0x87C8F3C VA: 0x87CCF3C
	public void .ctor() { }

	// RVA: 0x87CCED0 Offset: 0x87C8ED0 VA: 0x87CCED0
	private void CreatePrimitive_Internal_Injected(int sides, ref Vector2 scale, ref Vector2 offset, bool autoRefresh) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/CompositeCollider2D.h")]
[RequireComponent(typeof(Rigidbody2D))]
public sealed class CompositeCollider2D : Collider2D // TypeDefIndex: 27765
{
	// Methods

	// RVA: 0x87CCF44 Offset: 0x87C8F44 VA: 0x87CCF44
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Joint2D.h")]
[RequireComponent(typeof(Transform), typeof(Rigidbody2D))]
public class Joint2D : Behaviour // TypeDefIndex: 27766
{
	// Properties
	public Rigidbody2D connectedBody { get; }

	// Methods

	// RVA: 0x87CCF4C Offset: 0x87C8F4C VA: 0x87CCF4C
	public Rigidbody2D get_connectedBody() { }

	// RVA: 0x87CCF88 Offset: 0x87C8F88 VA: 0x87CCF88
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/AnchoredJoint2D.h")]
public class AnchoredJoint2D : Joint2D // TypeDefIndex: 27767
{
	// Properties
	public Vector2 connectedAnchor { get; }

	// Methods

	// RVA: 0x87CCF90 Offset: 0x87C8F90 VA: 0x87CCF90
	public Vector2 get_connectedAnchor() { }

	// RVA: 0x87CD020 Offset: 0x87C9020 VA: 0x87CD020
	public void .ctor() { }

	// RVA: 0x87CCFDC Offset: 0x87C8FDC VA: 0x87CCFDC
	private void get_connectedAnchor_Injected(out Vector2 ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/HingeJoint2D.h")]
public sealed class HingeJoint2D : AnchoredJoint2D // TypeDefIndex: 27768
{
	// Properties
	public bool useMotor { get; set; }
	public bool useLimits { get; set; }
	public JointMotor2D motor { get; set; }
	public JointAngleLimits2D limits { get; set; }
	public JointLimitState2D limitState { get; }
	public float referenceAngle { get; }
	public float jointAngle { get; }
	public float jointSpeed { get; }

	// Methods

	// RVA: 0x87CD028 Offset: 0x87C9028 VA: 0x87CD028
	public bool get_useMotor() { }

	// RVA: 0x87CD064 Offset: 0x87C9064 VA: 0x87CD064
	public void set_useMotor(bool value) { }

	// RVA: 0x87CD0A8 Offset: 0x87C90A8 VA: 0x87CD0A8
	public bool get_useLimits() { }

	// RVA: 0x87CD0E4 Offset: 0x87C90E4 VA: 0x87CD0E4
	public void set_useLimits(bool value) { }

	// RVA: 0x87CD128 Offset: 0x87C9128 VA: 0x87CD128
	public JointMotor2D get_motor() { }

	// RVA: 0x87CD1B8 Offset: 0x87C91B8 VA: 0x87CD1B8
	public void set_motor(JointMotor2D value) { }

	// RVA: 0x87CD244 Offset: 0x87C9244 VA: 0x87CD244
	public JointAngleLimits2D get_limits() { }

	// RVA: 0x87CD2D4 Offset: 0x87C92D4 VA: 0x87CD2D4
	public void set_limits(JointAngleLimits2D value) { }

	// RVA: 0x87CD360 Offset: 0x87C9360 VA: 0x87CD360
	public JointLimitState2D get_limitState() { }

	// RVA: 0x87CD39C Offset: 0x87C939C VA: 0x87CD39C
	public float get_referenceAngle() { }

	// RVA: 0x87CD3D8 Offset: 0x87C93D8 VA: 0x87CD3D8
	public float get_jointAngle() { }

	// RVA: 0x87CD414 Offset: 0x87C9414 VA: 0x87CD414
	public float get_jointSpeed() { }

	// RVA: 0x87CD450 Offset: 0x87C9450 VA: 0x87CD450
	public float GetMotorTorque(float timeStep) { }

	// RVA: 0x87CD49C Offset: 0x87C949C VA: 0x87CD49C
	public void .ctor() { }

	// RVA: 0x87CD174 Offset: 0x87C9174 VA: 0x87CD174
	private void get_motor_Injected(out JointMotor2D ret) { }

	// RVA: 0x87CD200 Offset: 0x87C9200 VA: 0x87CD200
	private void set_motor_Injected(ref JointMotor2D value) { }

	// RVA: 0x87CD290 Offset: 0x87C9290 VA: 0x87CD290
	private void get_limits_Injected(out JointAngleLimits2D ret) { }

	// RVA: 0x87CD31C Offset: 0x87C931C VA: 0x87CD31C
	private void set_limits_Injected(ref JointAngleLimits2D value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PhysicsMaterial2D.h")]
public sealed class PhysicsMaterial2D : Object // TypeDefIndex: 27769
{
	// Methods

	// RVA: 0x87CD4A4 Offset: 0x87C94A4 VA: 0x87CD4A4
	public void .ctor() { }

	[NativeMethod("Create_Binding")]
	// RVA: 0x87CD528 Offset: 0x87C9528 VA: 0x87CD528
	private static void Create_Internal(PhysicsMaterial2D scriptMaterial, string name) { }
}

