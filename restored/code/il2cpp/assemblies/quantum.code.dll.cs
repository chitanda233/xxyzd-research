// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27287
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 27288
{
	// Methods

	// RVA: 0x7D91D90 Offset: 0x7D8DD90 VA: 0x7D91D90
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 27289
{
	// Methods

	// RVA: 0x7D91D98 Offset: 0x7D8DD98 VA: 0x7D91D98
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 27290
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(1)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 27291
{
	// Methods

	// RVA: 0x7D91DA0 Offset: 0x7D8DDA0 VA: 0x7D91DA0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x7D91E98 Offset: 0x7D8DE98 VA: 0x7D91E98
	public void .ctor() { }
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct BitSet1024.<bits>e__FixedBuffer // TypeDefIndex: 27292
{
	// Fields
	public ulong FixedElementField; // 0x0
}

// Namespace: Quantum
public struct BitSet1024 // TypeDefIndex: 27293
{
	// Fields
	public const int SIZE = 128;
	public const int ALIGNMENT = 8;
	[FixedBuffer(typeof(ulong), 16)]
	private BitSet1024.<bits>e__FixedBuffer bits; // 0x0
	public const int BitsSize = 1024;

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x7D91EA0 Offset: 0x7D8DEA0 VA: 0x7D91EA0
	public int get_Length() { }

	// RVA: 0x7D91EA8 Offset: 0x7D8DEA8 VA: 0x7D91EA8
	public static void Print(void* ptr, FramePrinter printer) { }

	[Obsolete("Use instance Set method instead")]
	// RVA: 0x7D91F44 Offset: 0x7D8DF44 VA: 0x7D91F44
	public static void Set(BitSet1024* set, int bit) { }

	[Obsolete("Use instance Clear method instead")]
	// RVA: 0x7D91F7C Offset: 0x7D8DF7C VA: 0x7D91F7C
	public static void Clear(BitSet1024* set, int bit) { }

	[Obsolete("Use instance ClearAll method instead")]
	// RVA: 0x7D91FB4 Offset: 0x7D8DFB4 VA: 0x7D91FB4
	public static void ClearAll(BitSet1024* set) { }

	[Obsolete("Use instance IsSet method instead")]
	// RVA: 0x7D9201C Offset: 0x7D8E01C VA: 0x7D9201C
	public static bool IsSet(BitSet1024* set, int bit) { }

	// RVA: 0x7D9204C Offset: 0x7D8E04C VA: 0x7D9204C
	public static BitSet1024 FromArray(ulong[] values) { }

	// RVA: 0x7D92100 Offset: 0x7D8E100 VA: 0x7D92100
	public void Set(int bit) { }

	// RVA: 0x7D92128 Offset: 0x7D8E128 VA: 0x7D92128
	public void Clear(int bit) { }

	// RVA: 0x7D92150 Offset: 0x7D8E150 VA: 0x7D92150
	public void ClearAll() { }

	// RVA: 0x7D921B4 Offset: 0x7D8E1B4 VA: 0x7D921B4
	public bool IsSet(int bit) { }

	// RVA: 0x7D921D4 Offset: 0x7D8E1D4 VA: 0x7D921D4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D9222C Offset: 0x7D8E22C VA: 0x7D9222C
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct BitSet128.<bits>e__FixedBuffer // TypeDefIndex: 27294
{
	// Fields
	public ulong FixedElementField; // 0x0
}

// Namespace: Quantum
public struct BitSet128 // TypeDefIndex: 27295
{
	// Fields
	public const int SIZE = 16;
	public const int ALIGNMENT = 8;
	[FixedBuffer(typeof(ulong), 2)]
	private BitSet128.<bits>e__FixedBuffer bits; // 0x0
	public const int BitsSize = 128;

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x7D922E4 Offset: 0x7D8E2E4 VA: 0x7D922E4
	public int get_Length() { }

	// RVA: 0x7D922EC Offset: 0x7D8E2EC VA: 0x7D922EC
	public static void Print(void* ptr, FramePrinter printer) { }

	[Obsolete("Use instance Set method instead")]
	// RVA: 0x7D92388 Offset: 0x7D8E388 VA: 0x7D92388
	public static void Set(BitSet128* set, int bit) { }

	[Obsolete("Use instance Clear method instead")]
	// RVA: 0x7D923C0 Offset: 0x7D8E3C0 VA: 0x7D923C0
	public static void Clear(BitSet128* set, int bit) { }

	[Obsolete("Use instance ClearAll method instead")]
	// RVA: 0x7D923F8 Offset: 0x7D8E3F8 VA: 0x7D923F8
	public static void ClearAll(BitSet128* set) { }

	[Obsolete("Use instance IsSet method instead")]
	// RVA: 0x7D92460 Offset: 0x7D8E460 VA: 0x7D92460
	public static bool IsSet(BitSet128* set, int bit) { }

	// RVA: 0x7D92490 Offset: 0x7D8E490 VA: 0x7D92490
	public static BitSet128 FromArray(ulong[] values) { }

	// RVA: 0x7D9252C Offset: 0x7D8E52C VA: 0x7D9252C
	public void Set(int bit) { }

	// RVA: 0x7D92554 Offset: 0x7D8E554 VA: 0x7D92554
	public void Clear(int bit) { }

	// RVA: 0x7D9257C Offset: 0x7D8E57C VA: 0x7D9257C
	public void ClearAll() { }

	// RVA: 0x7D925E0 Offset: 0x7D8E5E0 VA: 0x7D925E0
	public bool IsSet(int bit) { }

	// RVA: 0x7D92600 Offset: 0x7D8E600 VA: 0x7D92600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D92658 Offset: 0x7D8E658 VA: 0x7D92658
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct BitSet2048.<bits>e__FixedBuffer // TypeDefIndex: 27296
{
	// Fields
	public ulong FixedElementField; // 0x0
}

// Namespace: Quantum
public struct BitSet2048 // TypeDefIndex: 27297
{
	// Fields
	public const int SIZE = 256;
	public const int ALIGNMENT = 8;
	[FixedBuffer(typeof(ulong), 32)]
	private BitSet2048.<bits>e__FixedBuffer bits; // 0x0
	public const int BitsSize = 2048;

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x7D92710 Offset: 0x7D8E710 VA: 0x7D92710
	public int get_Length() { }

	// RVA: 0x7D92718 Offset: 0x7D8E718 VA: 0x7D92718
	public static void Print(void* ptr, FramePrinter printer) { }

	[Obsolete("Use instance Set method instead")]
	// RVA: 0x7D927B4 Offset: 0x7D8E7B4 VA: 0x7D927B4
	public static void Set(BitSet2048* set, int bit) { }

	[Obsolete("Use instance Clear method instead")]
	// RVA: 0x7D927EC Offset: 0x7D8E7EC VA: 0x7D927EC
	public static void Clear(BitSet2048* set, int bit) { }

	[Obsolete("Use instance ClearAll method instead")]
	// RVA: 0x7D92824 Offset: 0x7D8E824 VA: 0x7D92824
	public static void ClearAll(BitSet2048* set) { }

	[Obsolete("Use instance IsSet method instead")]
	// RVA: 0x7D9288C Offset: 0x7D8E88C VA: 0x7D9288C
	public static bool IsSet(BitSet2048* set, int bit) { }

	// RVA: 0x7D928BC Offset: 0x7D8E8BC VA: 0x7D928BC
	public static BitSet2048 FromArray(ulong[] values) { }

	// RVA: 0x7D92974 Offset: 0x7D8E974 VA: 0x7D92974
	public void Set(int bit) { }

	// RVA: 0x7D9299C Offset: 0x7D8E99C VA: 0x7D9299C
	public void Clear(int bit) { }

	// RVA: 0x7D929C4 Offset: 0x7D8E9C4 VA: 0x7D929C4
	public void ClearAll() { }

	// RVA: 0x7D92A28 Offset: 0x7D8EA28 VA: 0x7D92A28
	public bool IsSet(int bit) { }

	// RVA: 0x7D92A48 Offset: 0x7D8EA48 VA: 0x7D92A48 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D92AA0 Offset: 0x7D8EAA0 VA: 0x7D92AA0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct BitSet256.<bits>e__FixedBuffer // TypeDefIndex: 27298
{
	// Fields
	public ulong FixedElementField; // 0x0
}

// Namespace: Quantum
public struct BitSet256 // TypeDefIndex: 27299
{
	// Fields
	public const int SIZE = 32;
	public const int ALIGNMENT = 8;
	[FixedBuffer(typeof(ulong), 4)]
	private BitSet256.<bits>e__FixedBuffer bits; // 0x0
	public const int BitsSize = 256;

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x7D92B58 Offset: 0x7D8EB58 VA: 0x7D92B58
	public int get_Length() { }

	// RVA: 0x7D92B60 Offset: 0x7D8EB60 VA: 0x7D92B60
	public static void Print(void* ptr, FramePrinter printer) { }

	[Obsolete("Use instance Set method instead")]
	// RVA: 0x7D92BFC Offset: 0x7D8EBFC VA: 0x7D92BFC
	public static void Set(BitSet256* set, int bit) { }

	[Obsolete("Use instance Clear method instead")]
	// RVA: 0x7D92C34 Offset: 0x7D8EC34 VA: 0x7D92C34
	public static void Clear(BitSet256* set, int bit) { }

	[Obsolete("Use instance ClearAll method instead")]
	// RVA: 0x7D92C6C Offset: 0x7D8EC6C VA: 0x7D92C6C
	public static void ClearAll(BitSet256* set) { }

	[Obsolete("Use instance IsSet method instead")]
	// RVA: 0x7D92CD4 Offset: 0x7D8ECD4 VA: 0x7D92CD4
	public static bool IsSet(BitSet256* set, int bit) { }

	// RVA: 0x7D92D04 Offset: 0x7D8ED04 VA: 0x7D92D04
	public static BitSet256 FromArray(ulong[] values) { }

	// RVA: 0x7D92DA4 Offset: 0x7D8EDA4 VA: 0x7D92DA4
	public void Set(int bit) { }

	// RVA: 0x7D92DCC Offset: 0x7D8EDCC VA: 0x7D92DCC
	public void Clear(int bit) { }

	// RVA: 0x7D92DF4 Offset: 0x7D8EDF4 VA: 0x7D92DF4
	public void ClearAll() { }

	// RVA: 0x7D92E58 Offset: 0x7D8EE58 VA: 0x7D92E58
	public bool IsSet(int bit) { }

	// RVA: 0x7D92E78 Offset: 0x7D8EE78 VA: 0x7D92E78 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D92ED0 Offset: 0x7D8EED0 VA: 0x7D92ED0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct BitSet4096.<bits>e__FixedBuffer // TypeDefIndex: 27300
{
	// Fields
	public ulong FixedElementField; // 0x0
}

// Namespace: Quantum
public struct BitSet4096 // TypeDefIndex: 27301
{
	// Fields
	public const int SIZE = 512;
	public const int ALIGNMENT = 8;
	[FixedBuffer(typeof(ulong), 64)]
	private BitSet4096.<bits>e__FixedBuffer bits; // 0x0
	public const int BitsSize = 4096;

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x7D92F88 Offset: 0x7D8EF88 VA: 0x7D92F88
	public int get_Length() { }

	// RVA: 0x7D92F90 Offset: 0x7D8EF90 VA: 0x7D92F90
	public static void Print(void* ptr, FramePrinter printer) { }

	[Obsolete("Use instance Set method instead")]
	// RVA: 0x7D9302C Offset: 0x7D8F02C VA: 0x7D9302C
	public static void Set(BitSet4096* set, int bit) { }

	[Obsolete("Use instance Clear method instead")]
	// RVA: 0x7D93064 Offset: 0x7D8F064 VA: 0x7D93064
	public static void Clear(BitSet4096* set, int bit) { }

	[Obsolete("Use instance ClearAll method instead")]
	// RVA: 0x7D9309C Offset: 0x7D8F09C VA: 0x7D9309C
	public static void ClearAll(BitSet4096* set) { }

	[Obsolete("Use instance IsSet method instead")]
	// RVA: 0x7D93104 Offset: 0x7D8F104 VA: 0x7D93104
	public static bool IsSet(BitSet4096* set, int bit) { }

	// RVA: 0x7D93134 Offset: 0x7D8F134 VA: 0x7D93134
	public static BitSet4096 FromArray(ulong[] values) { }

	// RVA: 0x7D931EC Offset: 0x7D8F1EC VA: 0x7D931EC
	public void Set(int bit) { }

	// RVA: 0x7D93214 Offset: 0x7D8F214 VA: 0x7D93214
	public void Clear(int bit) { }

	// RVA: 0x7D9323C Offset: 0x7D8F23C VA: 0x7D9323C
	public void ClearAll() { }

	// RVA: 0x7D932A0 Offset: 0x7D8F2A0 VA: 0x7D932A0
	public bool IsSet(int bit) { }

	// RVA: 0x7D932C0 Offset: 0x7D8F2C0 VA: 0x7D932C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D93318 Offset: 0x7D8F318 VA: 0x7D93318
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct BitSet512.<bits>e__FixedBuffer // TypeDefIndex: 27302
{
	// Fields
	public ulong FixedElementField; // 0x0
}

// Namespace: Quantum
public struct BitSet512 // TypeDefIndex: 27303
{
	// Fields
	public const int SIZE = 64;
	public const int ALIGNMENT = 8;
	[FixedBuffer(typeof(ulong), 8)]
	private BitSet512.<bits>e__FixedBuffer bits; // 0x0
	public const int BitsSize = 512;

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x7D933D0 Offset: 0x7D8F3D0 VA: 0x7D933D0
	public int get_Length() { }

	// RVA: 0x7D933D8 Offset: 0x7D8F3D8 VA: 0x7D933D8
	public static void Print(void* ptr, FramePrinter printer) { }

	[Obsolete("Use instance Set method instead")]
	// RVA: 0x7D93474 Offset: 0x7D8F474 VA: 0x7D93474
	public static void Set(BitSet512* set, int bit) { }

	[Obsolete("Use instance Clear method instead")]
	// RVA: 0x7D934AC Offset: 0x7D8F4AC VA: 0x7D934AC
	public static void Clear(BitSet512* set, int bit) { }

	[Obsolete("Use instance ClearAll method instead")]
	// RVA: 0x7D934E4 Offset: 0x7D8F4E4 VA: 0x7D934E4
	public static void ClearAll(BitSet512* set) { }

	[Obsolete("Use instance IsSet method instead")]
	// RVA: 0x7D9354C Offset: 0x7D8F54C VA: 0x7D9354C
	public static bool IsSet(BitSet512* set, int bit) { }

	// RVA: 0x7D9357C Offset: 0x7D8F57C VA: 0x7D9357C
	public static BitSet512 FromArray(ulong[] values) { }

	// RVA: 0x7D93628 Offset: 0x7D8F628 VA: 0x7D93628
	public void Set(int bit) { }

	// RVA: 0x7D93650 Offset: 0x7D8F650 VA: 0x7D93650
	public void Clear(int bit) { }

	// RVA: 0x7D93678 Offset: 0x7D8F678 VA: 0x7D93678
	public void ClearAll() { }

	// RVA: 0x7D936DC Offset: 0x7D8F6DC VA: 0x7D936DC
	public bool IsSet(int bit) { }

	// RVA: 0x7D936FC Offset: 0x7D8F6FC VA: 0x7D936FC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D93754 Offset: 0x7D8F754 VA: 0x7D93754
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct BitSet6.<bits>e__FixedBuffer // TypeDefIndex: 27304
{
	// Fields
	public ulong FixedElementField; // 0x0
}

// Namespace: Quantum
public struct BitSet6 // TypeDefIndex: 27305
{
	// Fields
	public const int SIZE = 8;
	public const int ALIGNMENT = 8;
	[FixedBuffer(typeof(ulong), 1)]
	private BitSet6.<bits>e__FixedBuffer bits; // 0x0
	public const int BitsSize = 6;

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x7D9380C Offset: 0x7D8F80C VA: 0x7D9380C
	public int get_Length() { }

	// RVA: 0x7D93814 Offset: 0x7D8F814 VA: 0x7D93814
	public static void Print(void* ptr, FramePrinter printer) { }

	[Obsolete("Use instance Set method instead")]
	// RVA: 0x7D938B0 Offset: 0x7D8F8B0 VA: 0x7D938B0
	public static void Set(BitSet6* set, int bit) { }

	[Obsolete("Use instance Clear method instead")]
	// RVA: 0x7D938E8 Offset: 0x7D8F8E8 VA: 0x7D938E8
	public static void Clear(BitSet6* set, int bit) { }

	[Obsolete("Use instance ClearAll method instead")]
	// RVA: 0x7D93920 Offset: 0x7D8F920 VA: 0x7D93920
	public static void ClearAll(BitSet6* set) { }

	[Obsolete("Use instance IsSet method instead")]
	// RVA: 0x7D93988 Offset: 0x7D8F988 VA: 0x7D93988
	public static bool IsSet(BitSet6* set, int bit) { }

	// RVA: 0x7D939B8 Offset: 0x7D8F9B8 VA: 0x7D939B8
	public static BitSet6 FromArray(ulong[] values) { }

	// RVA: 0x7D939F4 Offset: 0x7D8F9F4 VA: 0x7D939F4
	public void Set(int bit) { }

	// RVA: 0x7D93A1C Offset: 0x7D8FA1C VA: 0x7D93A1C
	public void Clear(int bit) { }

	// RVA: 0x7D93A44 Offset: 0x7D8FA44 VA: 0x7D93A44
	public void ClearAll() { }

	// RVA: 0x7D93AA8 Offset: 0x7D8FAA8 VA: 0x7D93AA8
	public bool IsSet(int bit) { }

	// RVA: 0x7D93AC8 Offset: 0x7D8FAC8 VA: 0x7D93AC8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D93B20 Offset: 0x7D8FB20 VA: 0x7D93B20
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}

// Namespace: Quantum
public class ComponentPrototypeVisitor : ComponentPrototypeVisitorBase // TypeDefIndex: 27306
{
	// Methods

	// RVA: 0x7D93BD8 Offset: 0x7D8FBD8 VA: 0x7D93BD8
	public void .ctor() { }
}

// Namespace: 
public struct Frame.FrameSignals // TypeDefIndex: 27307
{
	// Fields
	private Frame _f; // 0x0

	// Methods

	// RVA: 0x7D964F4 Offset: 0x7D924F4 VA: 0x7D964F4
	public void .ctor(Frame f) { }

	// RVA: 0x7D93E44 Offset: 0x7D8FE44 VA: 0x7D93E44
	public void OnMapChanged(AssetRefMap previousMap) { }

	// RVA: 0x7D96360 Offset: 0x7D92360 VA: 0x7D96360
	public void OnEntityPrototypeMaterialized(EntityRef entity, EntityPrototypeRef prototypeRef) { }

	// RVA: 0x7D964FC Offset: 0x7D924FC VA: 0x7D964FC
	public void OnPlayerConnected(PlayerRef player) { }

	// RVA: 0x7D9667C Offset: 0x7D9267C VA: 0x7D9667C
	public void OnPlayerDisconnected(PlayerRef player) { }

	// RVA: 0x7D967FC Offset: 0x7D927FC VA: 0x7D967FC
	public void OnNavMeshWaypointReached(EntityRef entity, FPVector3 waypoint, Navigation.WaypointFlag waypointFlags, ref bool resetAgent) { }

	// RVA: 0x7D969F0 Offset: 0x7D929F0 VA: 0x7D969F0
	public void OnNavMeshSearchFailed(EntityRef entity, ref bool resetAgent) { }

	// RVA: 0x7D96B74 Offset: 0x7D92B74 VA: 0x7D96B74
	public void OnNavMeshMoveAgent(EntityRef entity, FPVector2 desiredDirection) { }

	// RVA: 0x7D96D08 Offset: 0x7D92D08 VA: 0x7D96D08
	public void OnCollision2D(CollisionInfo2D info) { }

	// RVA: 0x7D96ECC Offset: 0x7D92ECC VA: 0x7D96ECC
	public void OnCollisionEnter2D(CollisionInfo2D info) { }

	// RVA: 0x7D97090 Offset: 0x7D93090 VA: 0x7D97090
	public void OnCollisionExit2D(ExitInfo2D info) { }

	// RVA: 0x7D97224 Offset: 0x7D93224 VA: 0x7D97224
	public void OnTrigger2D(TriggerInfo2D info) { }

	// RVA: 0x7D973D0 Offset: 0x7D933D0 VA: 0x7D973D0
	public void OnTriggerEnter2D(TriggerInfo2D info) { }

	// RVA: 0x7D9757C Offset: 0x7D9357C VA: 0x7D9757C
	public void OnTriggerExit2D(ExitInfo2D info) { }

	// RVA: 0x7D97710 Offset: 0x7D93710 VA: 0x7D97710
	public void OnCollision3D(CollisionInfo3D info) { }

	// RVA: 0x7D978CC Offset: 0x7D938CC VA: 0x7D978CC
	public void OnCollisionEnter3D(CollisionInfo3D info) { }

	// RVA: 0x7D97A88 Offset: 0x7D93A88 VA: 0x7D97A88
	public void OnCollisionExit3D(ExitInfo3D info) { }

	// RVA: 0x7D97C1C Offset: 0x7D93C1C VA: 0x7D97C1C
	public void OnTrigger3D(TriggerInfo3D info) { }

	// RVA: 0x7D97DC8 Offset: 0x7D93DC8 VA: 0x7D97DC8
	public void OnTriggerEnter3D(TriggerInfo3D info) { }

	// RVA: 0x7D97F74 Offset: 0x7D93F74 VA: 0x7D97F74
	public void OnTriggerExit3D(ExitInfo3D info) { }
}

// Namespace: 
public struct Frame.FrameEvents // TypeDefIndex: 27308
{
	// Fields
	public const int EVENT_TYPE_COUNT = 0;
	private Frame _f; // 0x0

	// Methods

	// RVA: 0x7D98108 Offset: 0x7D94108 VA: 0x7D98108
	public static int GetParentEventID(int eventID) { }

	// RVA: 0x7D98110 Offset: 0x7D94110 VA: 0x7D98110
	public static Type GetEventType(int eventID) { }

	// RVA: 0x7D9815C Offset: 0x7D9415C VA: 0x7D9815C
	public void .ctor(Frame f) { }
}

// Namespace: 
public struct Frame.FrameAssets // TypeDefIndex: 27309
{
	// Fields
	private Frame _f; // 0x0

	// Methods

	// RVA: 0x7D98164 Offset: 0x7D94164 VA: 0x7D98164
	public void .ctor(Frame f) { }

	// RVA: 0x7D9816C Offset: 0x7D9416C VA: 0x7D9816C
	public EntityView View(string view, DatabaseType dbType = 1) { }

	// RVA: 0x7D981F4 Offset: 0x7D941F4 VA: 0x7D981F4
	public EntityPrototype Prototype(string prototype, DatabaseType dbType = 1) { }

	// RVA: 0x7D9827C Offset: 0x7D9427C VA: 0x7D9827C
	public EntityView View(AssetRefEntityView view) { }

	// RVA: 0x7D982F4 Offset: 0x7D942F4 VA: 0x7D982F4
	public EntityPrototype Prototype(AssetRefEntityPrototype prototype) { }

	// RVA: 0x7D9836C Offset: 0x7D9436C VA: 0x7D9836C
	public Map Map(AssetRefMap assetRef) { }

	// RVA: 0x7D983E4 Offset: 0x7D943E4 VA: 0x7D983E4
	public PhysicsMaterial PhysicsMaterial(AssetRefPhysicsMaterial assetRef) { }

	// RVA: 0x7D9845C Offset: 0x7D9445C VA: 0x7D9845C
	public PolygonCollider PolygonCollider(AssetRefPolygonCollider assetRef) { }

	// RVA: 0x7D984D4 Offset: 0x7D944D4 VA: 0x7D984D4
	public CharacterController3DConfig CharacterController3DConfig(AssetRefCharacterController3DConfig assetRef) { }

	// RVA: 0x7D9854C Offset: 0x7D9454C VA: 0x7D9854C
	public CharacterController2DConfig CharacterController2DConfig(AssetRefCharacterController2DConfig assetRef) { }

	// RVA: 0x7D985C4 Offset: 0x7D945C4 VA: 0x7D985C4
	public NavMesh NavMesh(AssetRefNavMesh assetRef) { }

	// RVA: 0x7D9863C Offset: 0x7D9463C VA: 0x7D9863C
	public NavMeshAgentConfig NavMeshAgentConfig(AssetRefNavMeshAgentConfig assetRef) { }

	// RVA: 0x7D986B4 Offset: 0x7D946B4 VA: 0x7D986B4
	public SimulationConfig SimulationConfig(AssetRefSimulationConfig assetRef) { }

	// RVA: 0x7D9872C Offset: 0x7D9472C VA: 0x7D9872C
	public TerrainCollider TerrainCollider(AssetRefTerrainCollider assetRef) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Frame.<>c // TypeDefIndex: 27310
{
	// Fields
	public static readonly Frame.<>c <>9; // 0x0
	public static Func<AssetObject, AssetGuid> <>9__103_0; // 0x8
	public static Action <>9__105_0; // 0x10

	// Methods

	// RVA: 0x7D987A4 Offset: 0x7D947A4 VA: 0x7D987A4
	private static void .cctor() { }

	// RVA: 0x7D9880C Offset: 0x7D9480C VA: 0x7D9880C
	public void .ctor() { }

	// RVA: 0x7D98814 Offset: 0x7D94814 VA: 0x7D98814
	internal AssetGuid <DumpFrame>b__103_0(AssetObject x) { }

	// RVA: 0x7D9882C Offset: 0x7D9482C VA: 0x7D9882C
	internal void <InitStaticGen>b__105_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Frame.<>c__100<T> // TypeDefIndex: 27311
{
	// Fields
	public static readonly Frame.<>c__100<T> <>9; // 0x0
	public static Func<SystemBase, bool> <>9__100_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48567B8 Offset: 0x48527B8 VA: 0x48567B8
	|-Frame.<>c__100<CharacterController2D>..cctor
	|
	|-RVA: 0x48568C0 Offset: 0x48528C0 VA: 0x48568C0
	|-Frame.<>c__100<CharacterController3D>..cctor
	|
	|-RVA: 0x48569C8 Offset: 0x48529C8 VA: 0x48569C8
	|-Frame.<>c__100<MapEntityLink>..cctor
	|
	|-RVA: 0x4856AD0 Offset: 0x4852AD0 VA: 0x4856AD0
	|-Frame.<>c__100<NavMeshAvoidanceAgent>..cctor
	|
	|-RVA: 0x4856BD8 Offset: 0x4852BD8 VA: 0x4856BD8
	|-Frame.<>c__100<NavMeshAvoidanceObstacle>..cctor
	|
	|-RVA: 0x4856CE0 Offset: 0x4852CE0 VA: 0x4856CE0
	|-Frame.<>c__100<NavMeshPathfinder>..cctor
	|
	|-RVA: 0x4856DE8 Offset: 0x4852DE8 VA: 0x4856DE8
	|-Frame.<>c__100<NavMeshSteeringAgent>..cctor
	|
	|-RVA: 0x4856EF0 Offset: 0x4852EF0 VA: 0x4856EF0
	|-Frame.<>c__100<PhysicsBody2D>..cctor
	|
	|-RVA: 0x4856FF8 Offset: 0x4852FF8 VA: 0x4856FF8
	|-Frame.<>c__100<PhysicsBody3D>..cctor
	|
	|-RVA: 0x4857100 Offset: 0x4853100 VA: 0x4857100
	|-Frame.<>c__100<PhysicsCollider2D>..cctor
	|
	|-RVA: 0x4857208 Offset: 0x4853208 VA: 0x4857208
	|-Frame.<>c__100<PhysicsCollider3D>..cctor
	|
	|-RVA: 0x4857310 Offset: 0x4853310 VA: 0x4857310
	|-Frame.<>c__100<Transform2D>..cctor
	|
	|-RVA: 0x4857418 Offset: 0x4853418 VA: 0x4857418
	|-Frame.<>c__100<Transform2DVertical>..cctor
	|
	|-RVA: 0x4857520 Offset: 0x4853520 VA: 0x4857520
	|-Frame.<>c__100<Transform3D>..cctor
	|
	|-RVA: 0x4857628 Offset: 0x4853628 VA: 0x4857628
	|-Frame.<>c__100<View>..cctor
	|
	|-RVA: 0x4857730 Offset: 0x4853730 VA: 0x4857730
	|-Frame.<>c__100<__Il2CppFullySharedGenericStructType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4856874 Offset: 0x4852874 VA: 0x4856874
	|-Frame.<>c__100<CharacterController2D>..ctor
	|
	|-RVA: 0x485697C Offset: 0x485297C VA: 0x485697C
	|-Frame.<>c__100<CharacterController3D>..ctor
	|
	|-RVA: 0x4856A84 Offset: 0x4852A84 VA: 0x4856A84
	|-Frame.<>c__100<MapEntityLink>..ctor
	|
	|-RVA: 0x4856B8C Offset: 0x4852B8C VA: 0x4856B8C
	|-Frame.<>c__100<NavMeshAvoidanceAgent>..ctor
	|
	|-RVA: 0x4856C94 Offset: 0x4852C94 VA: 0x4856C94
	|-Frame.<>c__100<NavMeshAvoidanceObstacle>..ctor
	|
	|-RVA: 0x4856D9C Offset: 0x4852D9C VA: 0x4856D9C
	|-Frame.<>c__100<NavMeshPathfinder>..ctor
	|
	|-RVA: 0x4856EA4 Offset: 0x4852EA4 VA: 0x4856EA4
	|-Frame.<>c__100<NavMeshSteeringAgent>..ctor
	|
	|-RVA: 0x4856FAC Offset: 0x4852FAC VA: 0x4856FAC
	|-Frame.<>c__100<PhysicsBody2D>..ctor
	|
	|-RVA: 0x48570B4 Offset: 0x48530B4 VA: 0x48570B4
	|-Frame.<>c__100<PhysicsBody3D>..ctor
	|
	|-RVA: 0x48571BC Offset: 0x48531BC VA: 0x48571BC
	|-Frame.<>c__100<PhysicsCollider2D>..ctor
	|
	|-RVA: 0x48572C4 Offset: 0x48532C4 VA: 0x48572C4
	|-Frame.<>c__100<PhysicsCollider3D>..ctor
	|
	|-RVA: 0x48573CC Offset: 0x48533CC VA: 0x48573CC
	|-Frame.<>c__100<Transform2D>..ctor
	|
	|-RVA: 0x48574D4 Offset: 0x48534D4 VA: 0x48574D4
	|-Frame.<>c__100<Transform2DVertical>..ctor
	|
	|-RVA: 0x48575DC Offset: 0x48535DC VA: 0x48575DC
	|-Frame.<>c__100<Transform3D>..ctor
	|
	|-RVA: 0x48576E4 Offset: 0x48536E4 VA: 0x48576E4
	|-Frame.<>c__100<View>..ctor
	|
	|-RVA: 0x4857824 Offset: 0x4853824 VA: 0x4857824
	|-Frame.<>c__100<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <BuildSignalsArrayOnComponentAdded>b__100_0(SystemBase x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485687C Offset: 0x485287C VA: 0x485687C
	|-Frame.<>c__100<CharacterController2D>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x4856984 Offset: 0x4852984 VA: 0x4856984
	|-Frame.<>c__100<CharacterController3D>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x4856A8C Offset: 0x4852A8C VA: 0x4856A8C
	|-Frame.<>c__100<MapEntityLink>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x4856B94 Offset: 0x4852B94 VA: 0x4856B94
	|-Frame.<>c__100<NavMeshAvoidanceAgent>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x4856C9C Offset: 0x4852C9C VA: 0x4856C9C
	|-Frame.<>c__100<NavMeshAvoidanceObstacle>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x4856DA4 Offset: 0x4852DA4 VA: 0x4856DA4
	|-Frame.<>c__100<NavMeshPathfinder>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x4856EAC Offset: 0x4852EAC VA: 0x4856EAC
	|-Frame.<>c__100<NavMeshSteeringAgent>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x4856FB4 Offset: 0x4852FB4 VA: 0x4856FB4
	|-Frame.<>c__100<PhysicsBody2D>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x48570BC Offset: 0x48530BC VA: 0x48570BC
	|-Frame.<>c__100<PhysicsBody3D>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x48571C4 Offset: 0x48531C4 VA: 0x48571C4
	|-Frame.<>c__100<PhysicsCollider2D>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x48572CC Offset: 0x48532CC VA: 0x48572CC
	|-Frame.<>c__100<PhysicsCollider3D>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x48573D4 Offset: 0x48533D4 VA: 0x48573D4
	|-Frame.<>c__100<Transform2D>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x48574DC Offset: 0x48534DC VA: 0x48574DC
	|-Frame.<>c__100<Transform2DVertical>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x48575E4 Offset: 0x48535E4 VA: 0x48575E4
	|-Frame.<>c__100<Transform3D>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x48576EC Offset: 0x48536EC VA: 0x48576EC
	|-Frame.<>c__100<View>.<BuildSignalsArrayOnComponentAdded>b__100_0
	|
	|-RVA: 0x485782C Offset: 0x485382C VA: 0x485782C
	|-Frame.<>c__100<__Il2CppFullySharedGenericStructType>.<BuildSignalsArrayOnComponentAdded>b__100_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Frame.<>c__101<T> // TypeDefIndex: 27312
{
	// Fields
	public static readonly Frame.<>c__101<T> <>9; // 0x0
	public static Func<SystemBase, bool> <>9__101_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4857870 Offset: 0x4853870 VA: 0x4857870
	|-Frame.<>c__101<CharacterController2D>..cctor
	|
	|-RVA: 0x4857978 Offset: 0x4853978 VA: 0x4857978
	|-Frame.<>c__101<CharacterController3D>..cctor
	|
	|-RVA: 0x4857A80 Offset: 0x4853A80 VA: 0x4857A80
	|-Frame.<>c__101<MapEntityLink>..cctor
	|
	|-RVA: 0x4857B88 Offset: 0x4853B88 VA: 0x4857B88
	|-Frame.<>c__101<NavMeshAvoidanceAgent>..cctor
	|
	|-RVA: 0x4857C90 Offset: 0x4853C90 VA: 0x4857C90
	|-Frame.<>c__101<NavMeshAvoidanceObstacle>..cctor
	|
	|-RVA: 0x4857D98 Offset: 0x4853D98 VA: 0x4857D98
	|-Frame.<>c__101<NavMeshPathfinder>..cctor
	|
	|-RVA: 0x4857EA0 Offset: 0x4853EA0 VA: 0x4857EA0
	|-Frame.<>c__101<NavMeshSteeringAgent>..cctor
	|
	|-RVA: 0x4857FA8 Offset: 0x4853FA8 VA: 0x4857FA8
	|-Frame.<>c__101<PhysicsBody2D>..cctor
	|
	|-RVA: 0x48580B0 Offset: 0x48540B0 VA: 0x48580B0
	|-Frame.<>c__101<PhysicsBody3D>..cctor
	|
	|-RVA: 0x48581B8 Offset: 0x48541B8 VA: 0x48581B8
	|-Frame.<>c__101<PhysicsCollider2D>..cctor
	|
	|-RVA: 0x48582C0 Offset: 0x48542C0 VA: 0x48582C0
	|-Frame.<>c__101<PhysicsCollider3D>..cctor
	|
	|-RVA: 0x48583C8 Offset: 0x48543C8 VA: 0x48583C8
	|-Frame.<>c__101<Transform2D>..cctor
	|
	|-RVA: 0x48584D0 Offset: 0x48544D0 VA: 0x48584D0
	|-Frame.<>c__101<Transform2DVertical>..cctor
	|
	|-RVA: 0x48585D8 Offset: 0x48545D8 VA: 0x48585D8
	|-Frame.<>c__101<Transform3D>..cctor
	|
	|-RVA: 0x48586E0 Offset: 0x48546E0 VA: 0x48586E0
	|-Frame.<>c__101<View>..cctor
	|
	|-RVA: 0x48587E8 Offset: 0x48547E8 VA: 0x48587E8
	|-Frame.<>c__101<__Il2CppFullySharedGenericStructType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485792C Offset: 0x485392C VA: 0x485792C
	|-Frame.<>c__101<CharacterController2D>..ctor
	|
	|-RVA: 0x4857A34 Offset: 0x4853A34 VA: 0x4857A34
	|-Frame.<>c__101<CharacterController3D>..ctor
	|
	|-RVA: 0x4857B3C Offset: 0x4853B3C VA: 0x4857B3C
	|-Frame.<>c__101<MapEntityLink>..ctor
	|
	|-RVA: 0x4857C44 Offset: 0x4853C44 VA: 0x4857C44
	|-Frame.<>c__101<NavMeshAvoidanceAgent>..ctor
	|
	|-RVA: 0x4857D4C Offset: 0x4853D4C VA: 0x4857D4C
	|-Frame.<>c__101<NavMeshAvoidanceObstacle>..ctor
	|
	|-RVA: 0x4857E54 Offset: 0x4853E54 VA: 0x4857E54
	|-Frame.<>c__101<NavMeshPathfinder>..ctor
	|
	|-RVA: 0x4857F5C Offset: 0x4853F5C VA: 0x4857F5C
	|-Frame.<>c__101<NavMeshSteeringAgent>..ctor
	|
	|-RVA: 0x4858064 Offset: 0x4854064 VA: 0x4858064
	|-Frame.<>c__101<PhysicsBody2D>..ctor
	|
	|-RVA: 0x485816C Offset: 0x485416C VA: 0x485816C
	|-Frame.<>c__101<PhysicsBody3D>..ctor
	|
	|-RVA: 0x4858274 Offset: 0x4854274 VA: 0x4858274
	|-Frame.<>c__101<PhysicsCollider2D>..ctor
	|
	|-RVA: 0x485837C Offset: 0x485437C VA: 0x485837C
	|-Frame.<>c__101<PhysicsCollider3D>..ctor
	|
	|-RVA: 0x4858484 Offset: 0x4854484 VA: 0x4858484
	|-Frame.<>c__101<Transform2D>..ctor
	|
	|-RVA: 0x485858C Offset: 0x485458C VA: 0x485858C
	|-Frame.<>c__101<Transform2DVertical>..ctor
	|
	|-RVA: 0x4858694 Offset: 0x4854694 VA: 0x4858694
	|-Frame.<>c__101<Transform3D>..ctor
	|
	|-RVA: 0x485879C Offset: 0x485479C VA: 0x485879C
	|-Frame.<>c__101<View>..ctor
	|
	|-RVA: 0x48588DC Offset: 0x48548DC VA: 0x48588DC
	|-Frame.<>c__101<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <BuildSignalsArrayOnComponentRemoved>b__101_0(SystemBase x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4857934 Offset: 0x4853934 VA: 0x4857934
	|-Frame.<>c__101<CharacterController2D>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x4857A3C Offset: 0x4853A3C VA: 0x4857A3C
	|-Frame.<>c__101<CharacterController3D>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x4857B44 Offset: 0x4853B44 VA: 0x4857B44
	|-Frame.<>c__101<MapEntityLink>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x4857C4C Offset: 0x4853C4C VA: 0x4857C4C
	|-Frame.<>c__101<NavMeshAvoidanceAgent>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x4857D54 Offset: 0x4853D54 VA: 0x4857D54
	|-Frame.<>c__101<NavMeshAvoidanceObstacle>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x4857E5C Offset: 0x4853E5C VA: 0x4857E5C
	|-Frame.<>c__101<NavMeshPathfinder>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x4857F64 Offset: 0x4853F64 VA: 0x4857F64
	|-Frame.<>c__101<NavMeshSteeringAgent>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x485806C Offset: 0x485406C VA: 0x485806C
	|-Frame.<>c__101<PhysicsBody2D>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x4858174 Offset: 0x4854174 VA: 0x4858174
	|-Frame.<>c__101<PhysicsBody3D>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x485827C Offset: 0x485427C VA: 0x485827C
	|-Frame.<>c__101<PhysicsCollider2D>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x4858384 Offset: 0x4854384 VA: 0x4858384
	|-Frame.<>c__101<PhysicsCollider3D>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x485848C Offset: 0x485448C VA: 0x485848C
	|-Frame.<>c__101<Transform2D>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x4858594 Offset: 0x4854594 VA: 0x4858594
	|-Frame.<>c__101<Transform2DVertical>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x485869C Offset: 0x485469C VA: 0x485869C
	|-Frame.<>c__101<Transform3D>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x48587A4 Offset: 0x48547A4 VA: 0x48587A4
	|-Frame.<>c__101<View>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	|
	|-RVA: 0x48588E4 Offset: 0x48548E4 VA: 0x48588E4
	|-Frame.<>c__101<__Il2CppFullySharedGenericStructType>.<BuildSignalsArrayOnComponentRemoved>b__101_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Frame.<>c__99<T> // TypeDefIndex: 27313
{
	// Fields
	public static readonly Frame.<>c__99<T> <>9; // 0x0
	public static Func<SystemBase, bool> <>9__99_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485C00C Offset: 0x485800C VA: 0x485C00C
	|-Frame.<>c__99<object>..cctor
	|
	|-RVA: 0x485C114 Offset: 0x4858114 VA: 0x485C114
	|-Frame.<>c__99<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485C0C8 Offset: 0x48580C8 VA: 0x485C0C8
	|-Frame.<>c__99<object>..ctor
	|
	|-RVA: 0x485C208 Offset: 0x4858208 VA: 0x485C208
	|-Frame.<>c__99<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <BuildSignalsArray>b__99_0(SystemBase x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485C0D0 Offset: 0x48580D0 VA: 0x485C0D0
	|-Frame.<>c__99<object>.<BuildSignalsArray>b__99_0
	|
	|-RVA: 0x485C210 Offset: 0x4858210 VA: 0x485C210
	|-Frame.<>c__99<__Il2CppFullySharedGenericType>.<BuildSignalsArray>b__99_0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Frame.<>c__DisplayClass100_0<T> // TypeDefIndex: 27314
{
	// Fields
	public Frame <>4__this; // 0x0
	public ISignalOnComponentAdded<T>[] array; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485E4F4 Offset: 0x485A4F4 VA: 0x485E4F4
	|-Frame.<>c__DisplayClass100_0<CharacterController2D>..ctor
	|
	|-RVA: 0x485E6A0 Offset: 0x485A6A0 VA: 0x485E6A0
	|-Frame.<>c__DisplayClass100_0<CharacterController3D>..ctor
	|
	|-RVA: 0x485E84C Offset: 0x485A84C VA: 0x485E84C
	|-Frame.<>c__DisplayClass100_0<MapEntityLink>..ctor
	|
	|-RVA: 0x485E9F8 Offset: 0x485A9F8 VA: 0x485E9F8
	|-Frame.<>c__DisplayClass100_0<NavMeshAvoidanceAgent>..ctor
	|
	|-RVA: 0x485EBA4 Offset: 0x485ABA4 VA: 0x485EBA4
	|-Frame.<>c__DisplayClass100_0<NavMeshAvoidanceObstacle>..ctor
	|
	|-RVA: 0x485ED50 Offset: 0x485AD50 VA: 0x485ED50
	|-Frame.<>c__DisplayClass100_0<NavMeshPathfinder>..ctor
	|
	|-RVA: 0x485EEFC Offset: 0x485AEFC VA: 0x485EEFC
	|-Frame.<>c__DisplayClass100_0<NavMeshSteeringAgent>..ctor
	|
	|-RVA: 0x485FAA8 Offset: 0x485BAA8 VA: 0x485FAA8
	|-Frame.<>c__DisplayClass100_0<PhysicsBody2D>..ctor
	|
	|-RVA: 0x485FC54 Offset: 0x485BC54 VA: 0x485FC54
	|-Frame.<>c__DisplayClass100_0<PhysicsBody3D>..ctor
	|
	|-RVA: 0x485FE00 Offset: 0x485BE00 VA: 0x485FE00
	|-Frame.<>c__DisplayClass100_0<PhysicsCollider2D>..ctor
	|
	|-RVA: 0x485FFAC Offset: 0x485BFAC VA: 0x485FFAC
	|-Frame.<>c__DisplayClass100_0<PhysicsCollider3D>..ctor
	|
	|-RVA: 0x4860158 Offset: 0x485C158 VA: 0x4860158
	|-Frame.<>c__DisplayClass100_0<Transform2D>..ctor
	|
	|-RVA: 0x4860304 Offset: 0x485C304 VA: 0x4860304
	|-Frame.<>c__DisplayClass100_0<Transform2DVertical>..ctor
	|
	|-RVA: 0x48604B0 Offset: 0x485C4B0 VA: 0x48604B0
	|-Frame.<>c__DisplayClass100_0<Transform3D>..ctor
	|
	|-RVA: 0x486065C Offset: 0x485C65C VA: 0x486065C
	|-Frame.<>c__DisplayClass100_0<View>..ctor
	|
	|-RVA: 0x4860808 Offset: 0x485C808 VA: 0x4860808
	|-Frame.<>c__DisplayClass100_0<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <BuildSignalsArrayOnComponentAdded>b__1(EntityRef entity, void* componentData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485E4FC Offset: 0x485A4FC VA: 0x485E4FC
	|-Frame.<>c__DisplayClass100_0<CharacterController2D>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485E6A8 Offset: 0x485A6A8 VA: 0x485E6A8
	|-Frame.<>c__DisplayClass100_0<CharacterController3D>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485E854 Offset: 0x485A854 VA: 0x485E854
	|-Frame.<>c__DisplayClass100_0<MapEntityLink>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485EA00 Offset: 0x485AA00 VA: 0x485EA00
	|-Frame.<>c__DisplayClass100_0<NavMeshAvoidanceAgent>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485EBAC Offset: 0x485ABAC VA: 0x485EBAC
	|-Frame.<>c__DisplayClass100_0<NavMeshAvoidanceObstacle>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485ED58 Offset: 0x485AD58 VA: 0x485ED58
	|-Frame.<>c__DisplayClass100_0<NavMeshPathfinder>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485EF04 Offset: 0x485AF04 VA: 0x485EF04
	|-Frame.<>c__DisplayClass100_0<NavMeshSteeringAgent>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485FAB0 Offset: 0x485BAB0 VA: 0x485FAB0
	|-Frame.<>c__DisplayClass100_0<PhysicsBody2D>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485FC5C Offset: 0x485BC5C VA: 0x485FC5C
	|-Frame.<>c__DisplayClass100_0<PhysicsBody3D>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485FE08 Offset: 0x485BE08 VA: 0x485FE08
	|-Frame.<>c__DisplayClass100_0<PhysicsCollider2D>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x485FFB4 Offset: 0x485BFB4 VA: 0x485FFB4
	|-Frame.<>c__DisplayClass100_0<PhysicsCollider3D>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x4860160 Offset: 0x485C160 VA: 0x4860160
	|-Frame.<>c__DisplayClass100_0<Transform2D>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x486030C Offset: 0x485C30C VA: 0x486030C
	|-Frame.<>c__DisplayClass100_0<Transform2DVertical>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x48604B8 Offset: 0x485C4B8 VA: 0x48604B8
	|-Frame.<>c__DisplayClass100_0<Transform3D>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x4860664 Offset: 0x485C664 VA: 0x4860664
	|-Frame.<>c__DisplayClass100_0<View>.<BuildSignalsArrayOnComponentAdded>b__1
	|
	|-RVA: 0x4860810 Offset: 0x485C810 VA: 0x4860810
	|-Frame.<>c__DisplayClass100_0<__Il2CppFullySharedGenericStructType>.<BuildSignalsArrayOnComponentAdded>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Frame.<>c__DisplayClass101_0<T> // TypeDefIndex: 27315
{
	// Fields
	public Frame <>4__this; // 0x0
	public ISignalOnComponentRemoved<T>[] array; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4861480 Offset: 0x485D480 VA: 0x4861480
	|-Frame.<>c__DisplayClass101_0<CharacterController2D>..ctor
	|
	|-RVA: 0x486162C Offset: 0x485D62C VA: 0x486162C
	|-Frame.<>c__DisplayClass101_0<CharacterController3D>..ctor
	|
	|-RVA: 0x48617D8 Offset: 0x485D7D8 VA: 0x48617D8
	|-Frame.<>c__DisplayClass101_0<MapEntityLink>..ctor
	|
	|-RVA: 0x4861984 Offset: 0x485D984 VA: 0x4861984
	|-Frame.<>c__DisplayClass101_0<NavMeshAvoidanceAgent>..ctor
	|
	|-RVA: 0x4861B30 Offset: 0x485DB30 VA: 0x4861B30
	|-Frame.<>c__DisplayClass101_0<NavMeshAvoidanceObstacle>..ctor
	|
	|-RVA: 0x4861CDC Offset: 0x485DCDC VA: 0x4861CDC
	|-Frame.<>c__DisplayClass101_0<NavMeshPathfinder>..ctor
	|
	|-RVA: 0x4861E88 Offset: 0x485DE88 VA: 0x4861E88
	|-Frame.<>c__DisplayClass101_0<NavMeshSteeringAgent>..ctor
	|
	|-RVA: 0x4862034 Offset: 0x485E034 VA: 0x4862034
	|-Frame.<>c__DisplayClass101_0<PhysicsBody2D>..ctor
	|
	|-RVA: 0x48621E0 Offset: 0x485E1E0 VA: 0x48621E0
	|-Frame.<>c__DisplayClass101_0<PhysicsBody3D>..ctor
	|
	|-RVA: 0x486238C Offset: 0x485E38C VA: 0x486238C
	|-Frame.<>c__DisplayClass101_0<PhysicsCollider2D>..ctor
	|
	|-RVA: 0x4862538 Offset: 0x485E538 VA: 0x4862538
	|-Frame.<>c__DisplayClass101_0<PhysicsCollider3D>..ctor
	|
	|-RVA: 0x48626E4 Offset: 0x485E6E4 VA: 0x48626E4
	|-Frame.<>c__DisplayClass101_0<Transform2D>..ctor
	|
	|-RVA: 0x4862890 Offset: 0x485E890 VA: 0x4862890
	|-Frame.<>c__DisplayClass101_0<Transform2DVertical>..ctor
	|
	|-RVA: 0x4862A3C Offset: 0x485EA3C VA: 0x4862A3C
	|-Frame.<>c__DisplayClass101_0<Transform3D>..ctor
	|
	|-RVA: 0x4862BE8 Offset: 0x485EBE8 VA: 0x4862BE8
	|-Frame.<>c__DisplayClass101_0<View>..ctor
	|
	|-RVA: 0x4862D94 Offset: 0x485ED94 VA: 0x4862D94
	|-Frame.<>c__DisplayClass101_0<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <BuildSignalsArrayOnComponentRemoved>b__1(EntityRef entity, void* componentData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4861488 Offset: 0x485D488 VA: 0x4861488
	|-Frame.<>c__DisplayClass101_0<CharacterController2D>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4861634 Offset: 0x485D634 VA: 0x4861634
	|-Frame.<>c__DisplayClass101_0<CharacterController3D>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x48617E0 Offset: 0x485D7E0 VA: 0x48617E0
	|-Frame.<>c__DisplayClass101_0<MapEntityLink>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x486198C Offset: 0x485D98C VA: 0x486198C
	|-Frame.<>c__DisplayClass101_0<NavMeshAvoidanceAgent>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4861B38 Offset: 0x485DB38 VA: 0x4861B38
	|-Frame.<>c__DisplayClass101_0<NavMeshAvoidanceObstacle>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4861CE4 Offset: 0x485DCE4 VA: 0x4861CE4
	|-Frame.<>c__DisplayClass101_0<NavMeshPathfinder>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4861E90 Offset: 0x485DE90 VA: 0x4861E90
	|-Frame.<>c__DisplayClass101_0<NavMeshSteeringAgent>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x486203C Offset: 0x485E03C VA: 0x486203C
	|-Frame.<>c__DisplayClass101_0<PhysicsBody2D>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x48621E8 Offset: 0x485E1E8 VA: 0x48621E8
	|-Frame.<>c__DisplayClass101_0<PhysicsBody3D>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4862394 Offset: 0x485E394 VA: 0x4862394
	|-Frame.<>c__DisplayClass101_0<PhysicsCollider2D>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4862540 Offset: 0x485E540 VA: 0x4862540
	|-Frame.<>c__DisplayClass101_0<PhysicsCollider3D>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x48626EC Offset: 0x485E6EC VA: 0x48626EC
	|-Frame.<>c__DisplayClass101_0<Transform2D>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4862898 Offset: 0x485E898 VA: 0x4862898
	|-Frame.<>c__DisplayClass101_0<Transform2DVertical>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4862A44 Offset: 0x485EA44 VA: 0x4862A44
	|-Frame.<>c__DisplayClass101_0<Transform3D>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4862BF0 Offset: 0x485EBF0 VA: 0x4862BF0
	|-Frame.<>c__DisplayClass101_0<View>.<BuildSignalsArrayOnComponentRemoved>b__1
	|
	|-RVA: 0x4862D9C Offset: 0x485ED9C VA: 0x4862D9C
	|-Frame.<>c__DisplayClass101_0<__Il2CppFullySharedGenericStructType>.<BuildSignalsArrayOnComponentRemoved>b__1
	*/
}

// Namespace: Quantum
public class Frame : FrameBase // TypeDefIndex: 27316
{
	// Fields
	public const int DumpFlag_NoSimulationConfig = 2;
	public const int DumpFlag_NoRuntimeConfig = 8;
	public const int DumpFlag_NoDeterministicSessionConfig = 16;
	public const int DumpFlag_NoRuntimePlayers = 32;
	public const int DumpFlag_NoDynamicDB = 64;
	public const int DumpFlag_ReadableDynamicDB = 128;
	public const int DumpFlag_PrintRawValues = 256;
	public const int DumpFlag_ComponentChecksums = 512;
	public const int DumpFlag_AssetDBCheckums = 1024;
	public const int DumpFlag_NoIsVerified = 2048;
	[Obsolete("Use DumpFlag_ComponentChecksums")]
	public const int DumpFlag_PrintComponentChecksums = 512;
	[Obsolete("Use DumpFlag_ReadableDynamicDB")]
	public const int DumpFlag_PrintReadableDynamicDB = 128;
	[DebuggerBrowsable(0)]
	private _globals_* _globals; // 0xC0
	private SystemBase[] _systemsAll; // 0xC8
	private SystemBase[] _systemsRoots; // 0xD0
	private Dictionary<Type, int> _systemIndexByType; // 0xD8
	private ISignalOnCollision2D[] _ISignalOnCollision2DSystems; // 0xE0
	private ISignalOnCollisionEnter2D[] _ISignalOnCollisionEnter2DSystems; // 0xE8
	private ISignalOnCollisionExit2D[] _ISignalOnCollisionExit2DSystems; // 0xF0
	private ISignalOnTrigger2D[] _ISignalOnTrigger2DSystems; // 0xF8
	private ISignalOnTriggerEnter2D[] _ISignalOnTriggerEnter2DSystems; // 0x100
	private ISignalOnTriggerExit2D[] _ISignalOnTriggerExit2DSystems; // 0x108
	private ISignalOnCollision3D[] _ISignalOnCollision3DSystems; // 0x110
	private ISignalOnCollisionEnter3D[] _ISignalOnCollisionEnter3DSystems; // 0x118
	private ISignalOnCollisionExit3D[] _ISignalOnCollisionExit3DSystems; // 0x120
	private ISignalOnTrigger3D[] _ISignalOnTrigger3DSystems; // 0x128
	private ISignalOnTriggerEnter3D[] _ISignalOnTriggerEnter3DSystems; // 0x130
	private ISignalOnTriggerExit3D[] _ISignalOnTriggerExit3DSystems; // 0x138
	private ISignalOnNavMeshWaypointReached[] _ISignalOnNavMeshWaypointReachedSystems; // 0x140
	private ISignalOnNavMeshSearchFailed[] _ISignalOnNavMeshSearchFailedSystems; // 0x148
	private ISignalOnNavMeshMoveAgent[] _ISignalOnNavMeshMoveAgentSystems; // 0x150
	private ISignalOnMapChanged[] _ISignalOnMapChangedSystems; // 0x158
	private ISignalOnEntityPrototypeMaterialized[] _ISignalOnEntityPrototypeMaterializedSystems; // 0x160
	private ISignalOnPlayerConnected[] _ISignalOnPlayerConnectedSystems; // 0x168
	private ISignalOnPlayerDisconnected[] _ISignalOnPlayerDisconnectedSystems; // 0x170
	public Frame.FrameSignals Signals; // 0x178
	public Frame.FrameEvents Events; // 0x180
	public Frame.FrameAssets Assets; // 0x188
	[CompilerGenerated]
	private RuntimeConfig <RuntimeConfig>k__BackingField; // 0x190
	[CompilerGenerated]
	private SimulationConfig <SimulationConfig>k__BackingField; // 0x198
	[CompilerGenerated]
	private DeterministicSessionConfig <SessionConfig>k__BackingField; // 0x1A0

	// Properties
	[DebuggerBrowsable(0)]
	public _globals_* Global { get; }
	[DebuggerBrowsable(0)]
	public RNGSession* RNG { get; }
	public override NavMeshRegionMask* NavMeshRegionMask { get; }
	public override FrameMetaData* FrameMetaData { get; }
	protected override PhysicsEngineState* _physicsState2D { get; }
	protected override PhysicsEngineState* _physicsState3D { get; }
	public override CommitCommandsModes CommitCommandsMode { get; }
	public FrameContext Context { get; }
	public RuntimeConfig RuntimeConfig { get; set; }
	public SimulationConfig SimulationConfig { get; set; }
	public DeterministicSessionConfig SessionConfig { get; set; }
	public SystemBase[] SystemsAll { get; }
	public override int UpdateRate { get; }
	public sealed override PhysicsSceneSettings* PhysicsSceneSettings { get; }
	public override FP DeltaTime { get; set; }
	public sealed override Map Map { get; set; }

	// Methods

	// RVA: 0x7D93BE0 Offset: 0x7D8FBE0 VA: 0x7D93BE0
	public _globals_* get_Global() { }

	// RVA: 0x7D93BE8 Offset: 0x7D8FBE8 VA: 0x7D93BE8
	public RNGSession* get_RNG() { }

	// RVA: 0x7D93C04 Offset: 0x7D8FC04 VA: 0x7D93C04 Slot: 11
	public override NavMeshRegionMask* get_NavMeshRegionMask() { }

	// RVA: 0x7D93C20 Offset: 0x7D8FC20 VA: 0x7D93C20 Slot: 12
	public override FrameMetaData* get_FrameMetaData() { }

	// RVA: 0x7D93C3C Offset: 0x7D8FC3C VA: 0x7D93C3C Slot: 13
	protected override PhysicsEngineState* get__physicsState2D() { }

	// RVA: 0x7D93C58 Offset: 0x7D8FC58 VA: 0x7D93C58 Slot: 14
	protected override PhysicsEngineState* get__physicsState3D() { }

	// RVA: 0x7D93C74 Offset: 0x7D8FC74 VA: 0x7D93C74 Slot: 7
	public override CommitCommandsModes get_CommitCommandsMode() { }

	// RVA: 0x7D93C98 Offset: 0x7D8FC98 VA: 0x7D93C98
	public FrameContext get_Context() { }

	[CompilerGenerated]
	// RVA: 0x7D93CA0 Offset: 0x7D8FCA0 VA: 0x7D93CA0
	public RuntimeConfig get_RuntimeConfig() { }

	[CompilerGenerated]
	// RVA: 0x7D93CA8 Offset: 0x7D8FCA8 VA: 0x7D93CA8
	internal void set_RuntimeConfig(RuntimeConfig value) { }

	[CompilerGenerated]
	// RVA: 0x7D93CB8 Offset: 0x7D8FCB8 VA: 0x7D93CB8
	public SimulationConfig get_SimulationConfig() { }

	[CompilerGenerated]
	// RVA: 0x7D93CC0 Offset: 0x7D8FCC0 VA: 0x7D93CC0
	internal void set_SimulationConfig(SimulationConfig value) { }

	[CompilerGenerated]
	// RVA: 0x7D93CD0 Offset: 0x7D8FCD0 VA: 0x7D93CD0
	public DeterministicSessionConfig get_SessionConfig() { }

	[CompilerGenerated]
	// RVA: 0x7D93CD8 Offset: 0x7D8FCD8 VA: 0x7D93CD8
	internal void set_SessionConfig(DeterministicSessionConfig value) { }

	// RVA: 0x7D93CE8 Offset: 0x7D8FCE8 VA: 0x7D93CE8
	public SystemBase[] get_SystemsAll() { }

	// RVA: 0x7D93CF0 Offset: 0x7D8FCF0 VA: 0x7D93CF0 Slot: 15
	public override int get_UpdateRate() { }

	// RVA: 0x7D93D0C Offset: 0x7D8FD0C VA: 0x7D93D0C Slot: 8
	public sealed override PhysicsSceneSettings* get_PhysicsSceneSettings() { }

	// RVA: 0x7D93D28 Offset: 0x7D8FD28 VA: 0x7D93D28 Slot: 16
	public override FP get_DeltaTime() { }

	// RVA: 0x7D93D44 Offset: 0x7D8FD44 VA: 0x7D93D44 Slot: 17
	public override void set_DeltaTime(FP value) { }

	// RVA: 0x7D93D60 Offset: 0x7D8FD60 VA: 0x7D93D60 Slot: 9
	public sealed override Map get_Map() { }

	// RVA: 0x7D93DD8 Offset: 0x7D8FDD8 VA: 0x7D93DD8 Slot: 10
	public sealed override void set_Map(Map value) { }

	// RVA: 0x7D93FC0 Offset: 0x7D8FFC0 VA: 0x7D93FC0
	public void .ctor(FrameContext context, SystemBase[] systemsAll, SystemBase[] systemsRoots, DeterministicSessionConfig sessionConfig, RuntimeConfig runtimeConfig, SimulationConfig simulationConfig, FP deltaTime) { }

	// RVA: 0x7D94D48 Offset: 0x7D90D48 VA: 0x7D94D48 Slot: 6
	protected sealed override void Copy(DeterministicFrame frame) { }

	// RVA: 0x7D94E88 Offset: 0x7D90E88 VA: 0x7D94E88 Slot: 4
	public sealed override void Free() { }

	[Obsolete("Use SystemIsEnabledSelf instead.")]
	// RVA: -1 Offset: -1
	public bool SystemIsEnabled<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4606408 Offset: 0x4602408 VA: 0x4606408
	|-Frame.SystemIsEnabled<object>
	*/

	[Obsolete("Use SystemIsEnabledSelf instead.")]
	// RVA: 0x7D94ED4 Offset: 0x7D90ED4 VA: 0x7D94ED4
	public bool SystemIsEnabled(Type t) { }

	// RVA: -1 Offset: -1
	public bool SystemIsEnabledSelf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4606488 Offset: 0x4602488 VA: 0x4606488
	|-Frame.SystemIsEnabledSelf<object>
	*/

	// RVA: 0x7D94ED8 Offset: 0x7D90ED8 VA: 0x7D94ED8
	public bool SystemIsEnabledSelf(Type t) { }

	// RVA: 0x7D95044 Offset: 0x7D91044 VA: 0x7D95044
	public bool SystemIsEnabledSelf(SystemBase s) { }

	// RVA: -1 Offset: -1
	public bool SystemIsEnabledInHierarchy<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4606440 Offset: 0x4602440 VA: 0x4606440
	|-Frame.SystemIsEnabledInHierarchy<object>
	*/

	// RVA: 0x7D95090 Offset: 0x7D91090 VA: 0x7D95090
	public bool SystemIsEnabledInHierarchy(Type t) { }

	// RVA: 0x7D950AC Offset: 0x7D910AC VA: 0x7D950AC
	public bool SystemIsEnabledInHierarchy(SystemBase system) { }

	// RVA: -1 Offset: -1
	public void SystemEnable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4606390 Offset: 0x4602390 VA: 0x4606390
	|-Frame.SystemEnable<object>
	*/

	// RVA: 0x7D95114 Offset: 0x7D91114 VA: 0x7D95114
	public void SystemEnable(Type t) { }

	// RVA: -1 Offset: -1
	public void SystemDisable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46062E8 Offset: 0x46022E8 VA: 0x46062E8
	|-Frame.SystemDisable<object>
	*/

	// RVA: -1 Offset: -1
	public void SystemDisable<T>(T system) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4606360 Offset: 0x4602360 VA: 0x4606360
	|-Frame.SystemDisable<object>
	*/

	// RVA: 0x7D95224 Offset: 0x7D91224 VA: 0x7D95224
	public void SystemDisable(Type t) { }

	// RVA: -1 Offset: -1
	private QTuple<SystemBase, int> FindSystem<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46061F8 Offset: 0x46021F8 VA: 0x46061F8
	|-Frame.FindSystem<object>
	|
	|-RVA: 0x4606270 Offset: 0x4602270 VA: 0x4606270
	|-Frame.FindSystem<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D94F1C Offset: 0x7D90F1C VA: 0x7D94F1C
	private QTuple<SystemBase, int> FindSystem(Type t) { }

	// RVA: -1 Offset: -1
	private T[] BuildSignalsArray<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4601300 Offset: 0x45FD300 VA: 0x4601300
	|-Frame.BuildSignalsArray<object>
	|
	|-RVA: 0x4601468 Offset: 0x45FD468 VA: 0x4601468
	|-Frame.BuildSignalsArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void BuildSignalsArrayOnComponentAdded<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46015D8 Offset: 0x45FD5D8 VA: 0x46015D8
	|-Frame.BuildSignalsArrayOnComponentAdded<CharacterController2D>
	|
	|-RVA: 0x4601838 Offset: 0x45FD838 VA: 0x4601838
	|-Frame.BuildSignalsArrayOnComponentAdded<CharacterController3D>
	|
	|-RVA: 0x4601A98 Offset: 0x45FDA98 VA: 0x4601A98
	|-Frame.BuildSignalsArrayOnComponentAdded<MapEntityLink>
	|
	|-RVA: 0x4601CF8 Offset: 0x45FDCF8 VA: 0x4601CF8
	|-Frame.BuildSignalsArrayOnComponentAdded<NavMeshAvoidanceAgent>
	|
	|-RVA: 0x4601F58 Offset: 0x45FDF58 VA: 0x4601F58
	|-Frame.BuildSignalsArrayOnComponentAdded<NavMeshAvoidanceObstacle>
	|
	|-RVA: 0x46021B8 Offset: 0x45FE1B8 VA: 0x46021B8
	|-Frame.BuildSignalsArrayOnComponentAdded<NavMeshPathfinder>
	|
	|-RVA: 0x4602418 Offset: 0x45FE418 VA: 0x4602418
	|-Frame.BuildSignalsArrayOnComponentAdded<NavMeshSteeringAgent>
	|
	|-RVA: 0x4602678 Offset: 0x45FE678 VA: 0x4602678
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsBody2D>
	|
	|-RVA: 0x46028D8 Offset: 0x45FE8D8 VA: 0x46028D8
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsBody3D>
	|
	|-RVA: 0x4602B38 Offset: 0x45FEB38 VA: 0x4602B38
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsCollider2D>
	|
	|-RVA: 0x4602D98 Offset: 0x45FED98 VA: 0x4602D98
	|-Frame.BuildSignalsArrayOnComponentAdded<PhysicsCollider3D>
	|
	|-RVA: 0x4602FF8 Offset: 0x45FEFF8 VA: 0x4602FF8
	|-Frame.BuildSignalsArrayOnComponentAdded<Transform2D>
	|
	|-RVA: 0x4603258 Offset: 0x45FF258 VA: 0x4603258
	|-Frame.BuildSignalsArrayOnComponentAdded<Transform2DVertical>
	|
	|-RVA: 0x46034B8 Offset: 0x45FF4B8 VA: 0x46034B8
	|-Frame.BuildSignalsArrayOnComponentAdded<Transform3D>
	|
	|-RVA: 0x4603718 Offset: 0x45FF718 VA: 0x4603718
	|-Frame.BuildSignalsArrayOnComponentAdded<View>
	|
	|-RVA: 0x4603978 Offset: 0x45FF978 VA: 0x4603978
	|-Frame.BuildSignalsArrayOnComponentAdded<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void BuildSignalsArrayOnComponentRemoved<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4603BE8 Offset: 0x45FFBE8 VA: 0x4603BE8
	|-Frame.BuildSignalsArrayOnComponentRemoved<CharacterController2D>
	|
	|-RVA: 0x4603E48 Offset: 0x45FFE48 VA: 0x4603E48
	|-Frame.BuildSignalsArrayOnComponentRemoved<CharacterController3D>
	|
	|-RVA: 0x46040A8 Offset: 0x46000A8 VA: 0x46040A8
	|-Frame.BuildSignalsArrayOnComponentRemoved<MapEntityLink>
	|
	|-RVA: 0x4604308 Offset: 0x4600308 VA: 0x4604308
	|-Frame.BuildSignalsArrayOnComponentRemoved<NavMeshAvoidanceAgent>
	|
	|-RVA: 0x4604568 Offset: 0x4600568 VA: 0x4604568
	|-Frame.BuildSignalsArrayOnComponentRemoved<NavMeshAvoidanceObstacle>
	|
	|-RVA: 0x46047C8 Offset: 0x46007C8 VA: 0x46047C8
	|-Frame.BuildSignalsArrayOnComponentRemoved<NavMeshPathfinder>
	|
	|-RVA: 0x4604A28 Offset: 0x4600A28 VA: 0x4604A28
	|-Frame.BuildSignalsArrayOnComponentRemoved<NavMeshSteeringAgent>
	|
	|-RVA: 0x4604C88 Offset: 0x4600C88 VA: 0x4604C88
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsBody2D>
	|
	|-RVA: 0x4604EE8 Offset: 0x4600EE8 VA: 0x4604EE8
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsBody3D>
	|
	|-RVA: 0x4605148 Offset: 0x4601148 VA: 0x4605148
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsCollider2D>
	|
	|-RVA: 0x46053A8 Offset: 0x46013A8 VA: 0x46053A8
	|-Frame.BuildSignalsArrayOnComponentRemoved<PhysicsCollider3D>
	|
	|-RVA: 0x4605608 Offset: 0x4601608 VA: 0x4605608
	|-Frame.BuildSignalsArrayOnComponentRemoved<Transform2D>
	|
	|-RVA: 0x4605868 Offset: 0x4601868 VA: 0x4605868
	|-Frame.BuildSignalsArrayOnComponentRemoved<Transform2DVertical>
	|
	|-RVA: 0x4605AC8 Offset: 0x4601AC8 VA: 0x4605AC8
	|-Frame.BuildSignalsArrayOnComponentRemoved<Transform3D>
	|
	|-RVA: 0x4605D28 Offset: 0x4601D28 VA: 0x4605D28
	|-Frame.BuildSignalsArrayOnComponentRemoved<View>
	|
	|-RVA: 0x4605F88 Offset: 0x4601F88 VA: 0x4605F88
	|-Frame.BuildSignalsArrayOnComponentRemoved<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7D95334 Offset: 0x7D91334 VA: 0x7D95334
	private void AddEvent(EventBase evnt) { }

	// RVA: 0x7D95364 Offset: 0x7D91364 VA: 0x7D95364 Slot: 5
	public sealed override string DumpFrame(int dumpFlags = 0) { }

	// RVA: 0x7D94858 Offset: 0x7D90858 VA: 0x7D94858
	public static void InitStatic() { }

	// RVA: 0x7D96284 Offset: 0x7D92284 VA: 0x7D96284
	private static void InitStaticGen() { }

	// RVA: 0x7D9485C Offset: 0x7D9085C VA: 0x7D9485C
	private void InitGen() { }

	// RVA: 0x7D94EA4 Offset: 0x7D90EA4 VA: 0x7D94EA4
	private void FreeGen() { }

	// RVA: 0x7D94824 Offset: 0x7D90824 VA: 0x7D94824
	private void AllocGen() { }

	// RVA: 0x7D94E18 Offset: 0x7D90E18 VA: 0x7D94E18
	private void CopyFromGen(Frame frame) { }

	[CompilerGenerated]
	// RVA: 0x7D96358 Offset: 0x7D92358 VA: 0x7D96358
	private void <.ctor>b__81_0(EntityRef entity, EntityPrototypeRef prototype) { }
}

// Namespace: Quantum
public class TypeRegistry // TypeDefIndex: 27317
{
	// Fields
	private readonly Dictionary<Type, int> _types; // 0x10

	// Properties
	public ReadOnlyDictionary<Type, int> Types { get; }

	// Methods

	// RVA: 0x7D98830 Offset: 0x7D94830 VA: 0x7D98830
	public ReadOnlyDictionary<Type, int> get_Types() { }

	// RVA: 0x7D988AC Offset: 0x7D948AC VA: 0x7D988AC
	public void .ctor() { }

	// RVA: 0x7D99E7C Offset: 0x7D95E7C VA: 0x7D99E7C
	private void Register(Type type, int size) { }

	// RVA: 0x7D98944 Offset: 0x7D94944 VA: 0x7D98944
	private void AddBuiltIns() { }

	// RVA: 0x7D99008 Offset: 0x7D95008 VA: 0x7D99008
	private void AddGenerated() { }
}

// Namespace: Quantum
public struct _globals_ // TypeDefIndex: 27318
{
	// Fields
	public const int SIZE = 568;
	public const int ALIGNMENT = 8;
	public FP DeltaTime; // 0x28
	public FrameMetaData FrameMetaData; // 0x68
	public AssetRefMap Map; // 0x18
	public NavMeshRegionMask NavMeshRegions; // 0x30
	public PhysicsSceneSettings PhysicsSettings; // 0x110
	public PhysicsEngineState PhysicsState2D; // 0x38
	public PhysicsEngineState PhysicsState3D; // 0x48
	public BitSet6 PlayerLastConnectionState; // 0x20
	public RNGSession RngSession; // 0x58
	public BitSet1024 Systems; // 0x90

	// Methods

	// RVA: 0x7D99F20 Offset: 0x7D95F20 VA: 0x7D99F20 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Quantum
public interface ISignalOnCollision2D : ISignal // TypeDefIndex: 27319
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollision2D(Frame f, CollisionInfo2D info);
}

// Namespace: Quantum
public interface ISignalOnCollisionEnter2D : ISignal // TypeDefIndex: 27320
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollisionEnter2D(Frame f, CollisionInfo2D info);
}

// Namespace: Quantum
public interface ISignalOnCollisionExit2D : ISignal // TypeDefIndex: 27321
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollisionExit2D(Frame f, ExitInfo2D info);
}

// Namespace: Quantum
public interface ISignalOnTrigger2D : ISignal // TypeDefIndex: 27322
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnTrigger2D(Frame f, TriggerInfo2D info);
}

// Namespace: Quantum
public interface ISignalOnTriggerEnter2D : ISignal // TypeDefIndex: 27323
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnTriggerEnter2D(Frame f, TriggerInfo2D info);
}

// Namespace: Quantum
public interface ISignalOnTriggerExit2D : ISignal // TypeDefIndex: 27324
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnTriggerExit2D(Frame f, ExitInfo2D info);
}

// Namespace: Quantum
public interface ISignalOnCollision3D : ISignal // TypeDefIndex: 27325
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollision3D(Frame f, CollisionInfo3D info);
}

// Namespace: Quantum
public interface ISignalOnCollisionEnter3D : ISignal // TypeDefIndex: 27326
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollisionEnter3D(Frame f, CollisionInfo3D info);
}

// Namespace: Quantum
public interface ISignalOnCollisionExit3D : ISignal // TypeDefIndex: 27327
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollisionExit3D(Frame f, ExitInfo3D info);
}

// Namespace: Quantum
public interface ISignalOnTrigger3D : ISignal // TypeDefIndex: 27328
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnTrigger3D(Frame f, TriggerInfo3D info);
}

// Namespace: Quantum
public interface ISignalOnTriggerEnter3D : ISignal // TypeDefIndex: 27329
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnTriggerEnter3D(Frame f, TriggerInfo3D info);
}

// Namespace: Quantum
public interface ISignalOnTriggerExit3D : ISignal // TypeDefIndex: 27330
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnTriggerExit3D(Frame f, ExitInfo3D info);
}

// Namespace: Quantum
public interface ISignalOnComponentAdded<T> : ISignal // TypeDefIndex: 27331
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnAdded(Frame f, EntityRef entity, T* component);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISignalOnComponentAdded<__Il2CppFullySharedGenericStructType>.OnAdded
	*/
}

// Namespace: Quantum
public interface ISignalOnComponentRemoved<T> : ISignal // TypeDefIndex: 27332
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnRemoved(Frame f, EntityRef entity, T* component);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISignalOnComponentRemoved<__Il2CppFullySharedGenericStructType>.OnRemoved
	*/
}

// Namespace: Quantum
public interface ISignalOnMapChanged : ISignal // TypeDefIndex: 27333
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnMapChanged(Frame f, AssetRefMap previousMap);
}

// Namespace: Quantum
public interface ISignalOnEntityPrototypeMaterialized : ISignal // TypeDefIndex: 27334
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEntityPrototypeMaterialized(Frame f, EntityRef entity, EntityPrototypeRef prototypeRef);
}

// Namespace: Quantum
public interface ISignalOnPlayerConnected : ISignal // TypeDefIndex: 27335
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPlayerConnected(Frame f, PlayerRef player);
}

// Namespace: Quantum
public interface ISignalOnPlayerDisconnected : ISignal // TypeDefIndex: 27336
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPlayerDisconnected(Frame f, PlayerRef player);
}

// Namespace: Quantum
public interface ISignalOnNavMeshWaypointReached : ISignal // TypeDefIndex: 27337
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNavMeshWaypointReached(Frame f, EntityRef entity, FPVector3 waypoint, Navigation.WaypointFlag waypointFlags, ref bool resetAgent);
}

// Namespace: Quantum
public interface ISignalOnNavMeshSearchFailed : ISignal // TypeDefIndex: 27338
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNavMeshSearchFailed(Frame f, EntityRef entity, ref bool resetAgent);
}

// Namespace: Quantum
public interface ISignalOnNavMeshMoveAgent : ISignal // TypeDefIndex: 27339
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNavMeshMoveAgent(Frame f, EntityRef entity, FPVector2 desiredDirection);
}

// Namespace: Quantum
[Serializable]
public class RuntimeConfig // TypeDefIndex: 27340
{
	// Fields
	public int Seed; // 0x10
	public AssetRefMap Map; // 0x18
	public AssetRefSimulationConfig SimulationConfig; // 0x20

	// Methods

	// RVA: 0x7D9A13C Offset: 0x7D9613C VA: 0x7D9A13C
	public void Serialize(BitStream stream) { }

	// RVA: 0x7D9A18C Offset: 0x7D9618C VA: 0x7D9A18C
	public string Dump() { }

	// RVA: 0x7D9A348 Offset: 0x7D96348 VA: 0x7D9A348
	public static byte[] ToByteArray(RuntimeConfig config) { }

	// RVA: 0x7D9A3F8 Offset: 0x7D963F8 VA: 0x7D9A3F8
	public static RuntimeConfig FromByteArray(byte[] data) { }

	// RVA: 0x7D9A4A4 Offset: 0x7D964A4 VA: 0x7D9A4A4
	public void .ctor() { }
}

// Namespace: 
public enum SimulationConfig.AutoLoadSceneFromMapMode // TypeDefIndex: 27341
{
	// Fields
	public int value__; // 0x0
	public const SimulationConfig.AutoLoadSceneFromMapMode Disabled = 0;
	public const SimulationConfig.AutoLoadSceneFromMapMode Legacy = 1;
	public const SimulationConfig.AutoLoadSceneFromMapMode UnloadPreviousSceneThenLoad = 2;
	public const SimulationConfig.AutoLoadSceneFromMapMode LoadThenUnloadPreviousScene = 3;
}

// Namespace: Quantum
[AssetObjectConfig(GenerateLinkingScripts = True, GenerateAssetCreateMenu = False, GenerateAssetResetMethod = False, GenerateAsMainScript = False)]
[Serializable]
public class SimulationConfig : AssetObject // TypeDefIndex: 27342
{
	// Fields
	public const long DEFAULT_ID = 5;
	[Space(8)]
	public Navigation.Config Navigation; // 0x20
	[Space(8)]
	public PhysicsCommon.Config Physics; // 0x28
	[Space(8)]
	public FrameBase.EntitiesConfig Entities; // 0x30
	[Tooltip("Configure how the client tracks the time to progress the Quantum simulation from the QuantumRunner class.")]
	public SimulationUpdateTime DeltaTimeType; // 0x38
	[Header("Frame Heap Settings")]
	[Tooltip("If and to which extent allocations in the Frame Heap should be tracked when in Debug mode.
Recommended modes for development is `DetectLeaks`.
While actively debugging a memory leak,`TraceAllocations` mode can be enabled (warning: tracing is very slow).")]
	public HeapTrackingMode HeapTrackingMode; // 0x3C
	[Tooltip("Define the max heap size for one page of memory the frame class uses for custom allocations like QList<> for example.

2^15 = 32.768 bytes
TotalHeapSizeInBytes = (1 << HeapPageShift) * HeapPageCount

Default is 15.")]
	public int HeapPageShift; // 0x40
	[Tooltip("Define the max heap page count for memory the frame class uses for custom allocations like QList<> for example.

TotalHeapSizeInBytes = (1 << HeapPageShift) * HeapPageCount

Default is 256.")]
	public int HeapPageCount; // 0x44
	[Tooltip("Sets extra heaps to allocate for a session in case you need to create 'auxiliary' frames than actually required for the simulation itself.
Default is 0.")]
	public int HeapExtraCount; // 0x48

	// Methods

	// RVA: 0x7D9A4AC Offset: 0x7D964AC VA: 0x7D9A4AC
	public void .ctor() { }
}

// Namespace: Quantum
[Serializable]
public struct AssetRefSimulationConfig : IEquatable<AssetRefSimulationConfig> // TypeDefIndex: 27343
{
	// Fields
	public const int SIZE = 8;
	public AssetGuid Id; // 0x0

	// Methods

	// RVA: 0x7D9A4C0 Offset: 0x7D964C0 VA: 0x7D9A4C0
	public static AssetRefSimulationConfig op_Implicit(Map value) { }

	// RVA: 0x7D9A4D0 Offset: 0x7D964D0 VA: 0x7D9A4D0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x7D9A33C Offset: 0x7D9633C VA: 0x7D9A33C Slot: 3
	public override string ToString() { }

	// RVA: 0x7D9A4E4 Offset: 0x7D964E4 VA: 0x7D9A4E4 Slot: 4
	public bool Equals(AssetRefSimulationConfig other) { }

	// RVA: 0x7D9A4EC Offset: 0x7D964EC VA: 0x7D9A4EC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x7D9A568 Offset: 0x7D96568 VA: 0x7D9A568 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D9A570 Offset: 0x7D96570 VA: 0x7D9A570
	public static bool op_Equality(AssetRefSimulationConfig a, AssetRefSimulationConfig b) { }

	// RVA: 0x7D9A578 Offset: 0x7D96578 VA: 0x7D9A578
	public static bool op_Inequality(AssetRefSimulationConfig a, AssetRefSimulationConfig b) { }
}

// Namespace: Quantum
[Extension]
public static class AssetRefSimulationConfigExt // TypeDefIndex: 27344
{
	// Methods

	[Extension]
	// RVA: 0x7D9A580 Offset: 0x7D96580 VA: 0x7D9A580
	public static SimulationConfig FindAsset(FrameBase f, AssetRefSimulationConfig assetRef) { }
}

// Namespace: Quantum
[Flags]
public enum SimulationConfigChecksumErrorDumpOptions // TypeDefIndex: 27345
{
	// Fields
	public int value__; // 0x0
	public const SimulationConfigChecksumErrorDumpOptions SendAssetDBChecksums = 1;
	public const SimulationConfigChecksumErrorDumpOptions ReadableDynamicDB = 2;
	public const SimulationConfigChecksumErrorDumpOptions RawFPValues = 4;
	public const SimulationConfigChecksumErrorDumpOptions ComponentChecksums = 8;
}

// Namespace: Quantum
public enum SimulationUpdateTime // TypeDefIndex: 27346
{
	// Fields
	public int value__; // 0x0
	public const SimulationUpdateTime Default = 0;
	public const SimulationUpdateTime EngineDeltaTime = 1;
	public const SimulationUpdateTime EngineUnscaledDeltaTime = 2;
}

// Namespace: Quantum
public class EventDispatcher : DispatcherBase, IEventDispatcher // TypeDefIndex: 27347
{
	// Methods

	// RVA: 0x7D9A5F4 Offset: 0x7D965F4 VA: 0x7D9A5F4
	private static Dictionary<Type, int> GetEventTypes() { }

	// RVA: 0x7D9A6DC Offset: 0x7D966DC VA: 0x7D9A6DC
	public void .ctor() { }

	// RVA: 0x7D9A6FC Offset: 0x7D966FC VA: 0x7D9A6FC Slot: 5
	public bool Publish(EventBase e) { }
}

// Namespace: Quantum
public class QuantumGameFlags // TypeDefIndex: 27348
{
	// Fields
	public const int Server = 1;
	public const int DisableSharedChecksumSerializer = 2;
	public const int DisableInterpolatableStates = 4;
	public const int CustomFlagsStart = 65536;

	// Methods

	// RVA: 0x7D9A828 Offset: 0x7D96828 VA: 0x7D9A828
	public void .ctor() { }
}

// Namespace: 
public struct QuantumGame.StartParameters // TypeDefIndex: 27349
{
	// Fields
	public IResourceManager ResourceManager; // 0x0
	public IAssetSerializer AssetSerializer; // 0x8
	public int HeapExtraCount; // 0x10
	public DynamicAssetDB InitialDynamicAssets; // 0x18
	public IQuantumBridge QuantumBridge; // 0x20
}

// Namespace: 
public class QuantumGame.FramesContainer // TypeDefIndex: 27350
{
	// Fields
	public Frame Verified; // 0x10

	// Methods

	// RVA: 0x7D9AB64 Offset: 0x7D96B64 VA: 0x7D9AB64
	public void .ctor() { }
}

// Namespace: 
public class QuantumGame.ConfigurationsContainer // TypeDefIndex: 27351
{
	// Fields
	public RuntimeConfig Runtime; // 0x10
	public SimulationConfig Simulation; // 0x18

	// Methods

	// RVA: 0x7D9AB6C Offset: 0x7D96B6C VA: 0x7D9AB6C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class QuantumGame.<>c // TypeDefIndex: 27352
{
	// Fields
	public static readonly QuantumGame.<>c <>9; // 0x0
	public static Func<SystemBase, bool> <>9__41_0; // 0x8
	public static Func<SystemBase, IEnumerable<SystemBase>> <>9__41_1; // 0x10
	public static Func<SystemBase, bool> <>9__41_2; // 0x18
	public static Func<SystemBase, bool> <>9__41_3; // 0x20
	public static Func<SystemBase, bool> <>9__41_4; // 0x28
	public static Func<SystemBase, bool> <>9__41_5; // 0x30
	public static Func<SystemBase, bool> <>9__41_6; // 0x38

	// Methods

	// RVA: 0x7D9C7B8 Offset: 0x7D987B8 VA: 0x7D9C7B8
	private static void .cctor() { }

	// RVA: 0x7D9C820 Offset: 0x7D98820 VA: 0x7D9C820
	public void .ctor() { }

	// RVA: 0x7D9C828 Offset: 0x7D98828 VA: 0x7D9C828
	internal bool <CreateFrameContext>b__41_0(SystemBase x) { }

	// RVA: 0x7D9C834 Offset: 0x7D98834 VA: 0x7D9C834
	internal IEnumerable<SystemBase> <CreateFrameContext>b__41_1(SystemBase x) { }

	// RVA: 0x7D9C8C4 Offset: 0x7D988C4 VA: 0x7D9C8C4
	internal bool <CreateFrameContext>b__41_2(SystemBase x) { }

	// RVA: 0x7D9C93C Offset: 0x7D9893C VA: 0x7D9C93C
	internal bool <CreateFrameContext>b__41_3(SystemBase x) { }

	// RVA: 0x7D9C9B4 Offset: 0x7D989B4 VA: 0x7D9C9B4
	internal bool <CreateFrameContext>b__41_4(SystemBase x) { }

	// RVA: 0x7D9CA2C Offset: 0x7D98A2C VA: 0x7D9CA2C
	internal bool <CreateFrameContext>b__41_5(SystemBase x) { }

	// RVA: 0x7D9CAA4 Offset: 0x7D98AA4 VA: 0x7D9CAA4
	internal bool <CreateFrameContext>b__41_6(SystemBase x) { }
}

// Namespace: Quantum
public class QuantumGame : IDeterministicGame // TypeDefIndex: 27353
{
	// Fields
	[CompilerGenerated]
	private Action<ProfilerContextData> ProfilerSampleGenerated; // 0x10
	[CompilerGenerated]
	private readonly QuantumGame.FramesContainer <Frames>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly QuantumGame.ConfigurationsContainer <Configurations>k__BackingField; // 0x20
	[CompilerGenerated]
	private DeterministicSession <Session>k__BackingField; // 0x28
	[CompilerGenerated]
	private IQuantumBridge <QuantumBridge>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly IAssetSerializer <AssetSerializer>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly int <HeapExtraCount>k__BackingField; // 0x40
	private byte[] _inputStreamReadZeroArray; // 0x48
	private IResourceManager _resourceManager; // 0x50
	private FrameSerializer _inputSerializerRead; // 0x58
	private FrameSerializer _inputSerializerWrite; // 0x60
	private SystemBase[] _systemsRoot; // 0x68
	private SystemBase[] _systemsAll; // 0x70
	private FrameContext _context; // 0x78
	private TypeRegistry _typeRegistry; // 0x80
	private bool _polledInputInThisSimulation; // 0x88
	private DynamicAssetDB _initialDynamicAssets; // 0x90
	private int _flags; // 0x98

	// Properties
	public QuantumGame.FramesContainer Frames { get; }
	public QuantumGame.ConfigurationsContainer Configurations { get; }
	public DeterministicSession Session { get; set; }
	public IQuantumBridge QuantumBridge { get; set; }
	public IAssetSerializer AssetSerializer { get; }
	public int HeapExtraCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D9A830 Offset: 0x7D96830 VA: 0x7D9A830
	public void add_ProfilerSampleGenerated(Action<ProfilerContextData> value) { }

	[CompilerGenerated]
	// RVA: 0x7D9A8E0 Offset: 0x7D968E0 VA: 0x7D9A8E0
	public void remove_ProfilerSampleGenerated(Action<ProfilerContextData> value) { }

	[CompilerGenerated]
	// RVA: 0x7D9A990 Offset: 0x7D96990 VA: 0x7D9A990
	public QuantumGame.FramesContainer get_Frames() { }

	[CompilerGenerated]
	// RVA: 0x7D9A998 Offset: 0x7D96998 VA: 0x7D9A998
	public QuantumGame.ConfigurationsContainer get_Configurations() { }

	[CompilerGenerated]
	// RVA: 0x7D9A9A0 Offset: 0x7D969A0 VA: 0x7D9A9A0 Slot: 4
	public DeterministicSession get_Session() { }

	[CompilerGenerated]
	// RVA: 0x7D9A9A8 Offset: 0x7D969A8 VA: 0x7D9A9A8
	private void set_Session(DeterministicSession value) { }

	[CompilerGenerated]
	// RVA: 0x7D9A9B0 Offset: 0x7D969B0 VA: 0x7D9A9B0
	public IQuantumBridge get_QuantumBridge() { }

	[CompilerGenerated]
	// RVA: 0x7D9A9B8 Offset: 0x7D969B8 VA: 0x7D9A9B8
	private void set_QuantumBridge(IQuantumBridge value) { }

	[CompilerGenerated]
	// RVA: 0x7D9A9C0 Offset: 0x7D969C0 VA: 0x7D9A9C0
	public IAssetSerializer get_AssetSerializer() { }

	[CompilerGenerated]
	// RVA: 0x7D9A9C8 Offset: 0x7D969C8 VA: 0x7D9A9C8
	public int get_HeapExtraCount() { }

	// RVA: 0x7D9A9D0 Offset: 0x7D969D0 VA: 0x7D9A9D0
	public void .ctor(in QuantumGame.StartParameters startParams) { }

	// RVA: 0x7D9AB74 Offset: 0x7D96B74 VA: 0x7D9AB74 Slot: 7
	public void OnDestroy() { }

	// RVA: 0x7D9AB78 Offset: 0x7D96B78 VA: 0x7D9AB78
	public Frame CreateFrame() { }

	// RVA: 0x7D9AC64 Offset: 0x7D96C64 VA: 0x7D9AC64 Slot: 6
	private DeterministicFrame Photon.Deterministic.IDeterministicGame.CreateFrame(IDisposable context) { }

	// RVA: 0x7D9AD78 Offset: 0x7D96D78 VA: 0x7D9AD78 Slot: 5
	public IDisposable CreateFrameContext() { }

	// RVA: 0x7D9B9B0 Offset: 0x7D979B0 VA: 0x7D9B9B0
	public void SetPredictionArea(FPVector3 position, FP radius) { }

	// RVA: 0x7D9BA1C Offset: 0x7D97A1C VA: 0x7D9BA1C
	public void SetPredictionArea(FPVector2 position, FP radius) { }

	// RVA: 0x7D9BAB8 Offset: 0x7D97AB8 VA: 0x7D9BAB8
	public void OnGameEnded() { }

	// RVA: 0x7D9BABC Offset: 0x7D97ABC VA: 0x7D9BABC Slot: 9
	public void OnGameStart(DeterministicFrame f) { }

	// RVA: 0x7D9BF80 Offset: 0x7D97F80 VA: 0x7D9BF80 Slot: 10
	public void OnSimulate(DeterministicFrame state) { }

	// RVA: 0x7D9C4F8 Offset: 0x7D984F8 VA: 0x7D9C4F8 Slot: 11
	public void OnSimulateFinished(DeterministicFrame state) { }

	// RVA: 0x7D9C4FC Offset: 0x7D984FC VA: 0x7D9C4FC Slot: 12
	public void OnUpdateDone() { }

	// RVA: 0x7D9C5C4 Offset: 0x7D985C4 VA: 0x7D9C5C4 Slot: 8
	public void AssignSession(DeterministicSession session) { }

	// RVA: 0x7D9C778 Offset: 0x7D98778 VA: 0x7D9C778 Slot: 13
	public void OnSimulationEnd() { }

	// RVA: 0x7D9C794 Offset: 0x7D98794 VA: 0x7D9C794 Slot: 14
	public void OnSimulationBegin() { }

	// RVA: 0x7D9BB9C Offset: 0x7D97B9C VA: 0x7D9BB9C
	private void InitSystems(DeterministicFrame df) { }

	// RVA: 0x7D9C440 Offset: 0x7D98440 VA: 0x7D9C440
	private void LogSimulationException(Exception exn) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DotNetTaskRunner.<>c__DisplayClass5_0 // TypeDefIndex: 27354
{
	// Fields
	public Action callback; // 0x10
	public DotNetTaskRunner <>4__this; // 0x18
	public int index; // 0x20

	// Methods

	// RVA: 0x7D9CD4C Offset: 0x7D98D4C VA: 0x7D9CD4C
	public void .ctor() { }

	// RVA: 0x7D9CDB8 Offset: 0x7D98DB8 VA: 0x7D9CDB8
	internal void <Wrap>b__0(object _) { }
}

// Namespace: Quantum
public class DotNetTaskRunner : IDeterministicPlatformTaskRunner // TypeDefIndex: 27355
{
	// Fields
	private int _length; // 0x10
	private bool[] _done; // 0x18

	// Methods

	// RVA: 0x7D9CB1C Offset: 0x7D98B1C VA: 0x7D9CB1C Slot: 4
	public void Schedule(Action[] delegates) { }

	// RVA: 0x7D9CC9C Offset: 0x7D98C9C VA: 0x7D9CC9C Slot: 5
	public void WaitForComplete() { }

	// RVA: 0x7D9CCD4 Offset: 0x7D98CD4 VA: 0x7D9CCD4 Slot: 6
	public bool PollForComplete() { }

	// RVA: 0x7D9CBBC Offset: 0x7D98BBC VA: 0x7D9CBBC
	private WaitCallback Wrap(int index, Action callback) { }

	// RVA: 0x7D9CD54 Offset: 0x7D98D54 VA: 0x7D9CD54
	public void .ctor() { }
}

// Namespace: Quantum
public class InactiveTaskRunner : IDeterministicPlatformTaskRunner // TypeDefIndex: 27356
{
	// Methods

	// RVA: 0x7D9CF54 Offset: 0x7D98F54 VA: 0x7D9CF54 Slot: 4
	public void Schedule(Action[] delegates) { }

	// RVA: 0x7D9CF58 Offset: 0x7D98F58 VA: 0x7D9CF58 Slot: 5
	public void WaitForComplete() { }

	// RVA: 0x7D9CF5C Offset: 0x7D98F5C VA: 0x7D9CF5C Slot: 6
	public bool PollForComplete() { }

	// RVA: 0x7D9CF64 Offset: 0x7D98F64 VA: 0x7D9CF64
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class JsonAssetSerializerBase.EntityPrototypeSurrogate // TypeDefIndex: 27357
{
	// Fields
	public FlatEntityPrototypeContainer Container; // 0x10
	public AssetObjectIdentifier Identifier; // 0x18

	// Methods

	// RVA: 0x7D9ED44 Offset: 0x7D9AD44 VA: 0x7D9ED44
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class JsonAssetSerializerBase.MapSurrogate // TypeDefIndex: 27358
{
	// Fields
	public Map Map; // 0x10
	public FlatEntityPrototypeContainer[] MapEntities; // 0x18

	// Methods

	// RVA: 0x7D9ED4C Offset: 0x7D9AD4C VA: 0x7D9ED4C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class JsonAssetSerializerBase.UserAssetSurrogate // TypeDefIndex: 27359
{
	// Fields
	public string Json; // 0x10
	public string Type; // 0x18

	// Methods

	// RVA: 0x7D9DA2C Offset: 0x7D99A2C VA: 0x7D9DA2C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class JsonAssetSerializerBase.BinaryDataSurrogate // TypeDefIndex: 27360
{
	// Fields
	public AssetObjectIdentifier Identifier; // 0x10
	public bool IsCompressed; // 0x20
	public string Base64Data; // 0x28

	// Methods

	// RVA: 0x7D9F1D4 Offset: 0x7D9B1D4 VA: 0x7D9F1D4
	public void .ctor() { }
}

// Namespace: 
private class JsonAssetSerializerBase.AssetVisitor : IAssetObjectVisitor // TypeDefIndex: 27361
{
	// Fields
	public JsonAssetSerializerBase.FlatDatabaseFile Storage; // 0x10
	public JsonAssetSerializerBase Serializer; // 0x18

	// Methods

	// RVA: 0x7D9F26C Offset: 0x7D9B26C VA: 0x7D9F26C Slot: 4
	private void Quantum.IAssetObjectVisitor.Visit(BinaryData asset) { }

	// RVA: 0x7D9F32C Offset: 0x7D9B32C VA: 0x7D9F32C Slot: 5
	private void Quantum.IAssetObjectVisitor.Visit(CharacterController2DConfig asset) { }

	// RVA: 0x7D9F3E0 Offset: 0x7D9B3E0 VA: 0x7D9F3E0 Slot: 6
	private void Quantum.IAssetObjectVisitor.Visit(CharacterController3DConfig asset) { }

	// RVA: 0x7D9F494 Offset: 0x7D9B494 VA: 0x7D9F494 Slot: 7
	private void Quantum.IAssetObjectVisitor.Visit(EntityPrototype asset) { }

	// RVA: 0x7D9F54C Offset: 0x7D9B54C VA: 0x7D9F54C Slot: 8
	private void Quantum.IAssetObjectVisitor.Visit(EntityView asset) { }

	// RVA: 0x7D9F600 Offset: 0x7D9B600 VA: 0x7D9F600 Slot: 9
	private void Quantum.IAssetObjectVisitor.Visit(Map asset) { }

	// RVA: 0x7D9F6B8 Offset: 0x7D9B6B8 VA: 0x7D9F6B8 Slot: 10
	private void Quantum.IAssetObjectVisitor.Visit(NavMesh asset) { }

	// RVA: 0x7D9F76C Offset: 0x7D9B76C VA: 0x7D9F76C Slot: 11
	private void Quantum.IAssetObjectVisitor.Visit(NavMeshAgentConfig asset) { }

	// RVA: 0x7D9F820 Offset: 0x7D9B820 VA: 0x7D9F820 Slot: 12
	private void Quantum.IAssetObjectVisitor.Visit(PhysicsMaterial asset) { }

	// RVA: 0x7D9F8D4 Offset: 0x7D9B8D4 VA: 0x7D9F8D4 Slot: 13
	private void Quantum.IAssetObjectVisitor.Visit(PolygonCollider asset) { }

	// RVA: 0x7D9F988 Offset: 0x7D9B988 VA: 0x7D9F988 Slot: 14
	private void Quantum.IAssetObjectVisitor.Visit(TerrainCollider asset) { }

	// RVA: 0x7D9DA24 Offset: 0x7D99A24 VA: 0x7D9DA24
	public void .ctor() { }
}

// Namespace: 
[Serializable]
private sealed class JsonAssetSerializerBase.FlatDatabaseFile // TypeDefIndex: 27362
{
	// Fields
	public List<CharacterController2DConfig> CharacterController2DConfig; // 0x10
	public List<CharacterController3DConfig> CharacterController3DConfig; // 0x18
	public List<JsonAssetSerializerBase.EntityPrototypeSurrogate> EntityPrototype; // 0x20
	public List<EntityView> EntityView; // 0x28
	public List<JsonAssetSerializerBase.MapSurrogate> Map; // 0x30
	public List<NavMesh> NavMesh; // 0x38
	public List<NavMeshAgentConfig> NavMeshAgentConfig; // 0x40
	public List<PhysicsMaterial> PhysicsMaterial; // 0x48
	public List<PolygonCollider> PolygonCollider; // 0x50
	public List<TerrainCollider> TerrainCollider; // 0x58
	public List<JsonAssetSerializerBase.UserAssetSurrogate> UserAssets; // 0x60
	public List<JsonAssetSerializerBase.BinaryDataSurrogate> BinaryData; // 0x68

	// Methods

	// RVA: 0x7D9D640 Offset: 0x7D99640 VA: 0x7D9D640
	public void .ctor() { }
}

// Namespace: Quantum
public abstract class JsonAssetSerializerBase : IAssetSerializer // TypeDefIndex: 27363
{
	// Fields
	private List<ComponentPrototype> _prototypeBuffer; // 0x10
	[CompilerGenerated]
	private bool <IsPrettyPrintEnabled>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <CompressBinaryDataOnSerializationThreshold>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <DecompressBinaryDataOnDeserialization>k__BackingField; // 0x20

	// Properties
	public bool IsPrettyPrintEnabled { get; set; }
	public int CompressBinaryDataOnSerializationThreshold { get; set; }
	public bool DecompressBinaryDataOnDeserialization { get; set; }
	public Encoding Encoding { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D9CF6C Offset: 0x7D98F6C VA: 0x7D9CF6C
	public bool get_IsPrettyPrintEnabled() { }

	[CompilerGenerated]
	// RVA: 0x7D9CF74 Offset: 0x7D98F74 VA: 0x7D9CF74
	public void set_IsPrettyPrintEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7D9CF80 Offset: 0x7D98F80 VA: 0x7D9CF80
	public int get_CompressBinaryDataOnSerializationThreshold() { }

	[CompilerGenerated]
	// RVA: 0x7D9CF88 Offset: 0x7D98F88 VA: 0x7D9CF88
	public void set_CompressBinaryDataOnSerializationThreshold(int value) { }

	[CompilerGenerated]
	// RVA: 0x7D9CF90 Offset: 0x7D98F90 VA: 0x7D9CF90
	public bool get_DecompressBinaryDataOnDeserialization() { }

	[CompilerGenerated]
	// RVA: 0x7D9CF98 Offset: 0x7D98F98 VA: 0x7D9CF98
	public void set_DecompressBinaryDataOnDeserialization(bool value) { }

	// RVA: 0x7D9CFA4 Offset: 0x7D98FA4 VA: 0x7D9CFA4
	public Encoding get_Encoding() { }

	// RVA: 0x7D9CFAC Offset: 0x7D98FAC VA: 0x7D9CFAC Slot: 4
	public byte[] SerializeAssets(IEnumerable<AssetObject> assets) { }

	// RVA: 0x7D9DA34 Offset: 0x7D99A34 VA: 0x7D9DA34 Slot: 5
	public string PrintAsset(AssetObject asset) { }

	// RVA: 0x7D9DE74 Offset: 0x7D99E74 VA: 0x7D9DE74
	public IEnumerable<AssetObject> DeserializeAssets(byte[] data) { }

	// RVA: 0x7D9DE7C Offset: 0x7D99E7C VA: 0x7D9DE7C Slot: 6
	public IEnumerable<AssetObject> DeserializeAssets(byte[] data, int index, int count) { }

	// RVA: -1 Offset: -1
	protected void Collect<AssetType>(List<AssetType> source, List<AssetObject> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4646DD4 Offset: 0x4642DD4 VA: 0x4646DD4
	|-JsonAssetSerializerBase.Collect<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract object FromJson(string json, Type type);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract string ToJson(object obj);

	// RVA: 0x7D9DB08 Offset: 0x7D99B08 VA: 0x7D9DB08
	private static JsonAssetSerializerBase.EntityPrototypeSurrogate CreateSurrogate(EntityPrototype asset) { }

	// RVA: 0x7D9DC68 Offset: 0x7D99C68 VA: 0x7D9DC68
	private static JsonAssetSerializerBase.MapSurrogate CreateSurrogate(Map asset) { }

	// RVA: 0x7D9E7C4 Offset: 0x7D9A7C4 VA: 0x7D9E7C4
	private EntityPrototype CreateFromSurrogate(JsonAssetSerializerBase.EntityPrototypeSurrogate surrogate) { }

	// RVA: 0x7D9E9BC Offset: 0x7D9A9BC VA: 0x7D9E9BC
	private Map CreateFromSurrogate(JsonAssetSerializerBase.MapSurrogate surrogate) { }

	// RVA: 0x7D9F070 Offset: 0x7D9B070 VA: 0x7D9F070
	private JsonAssetSerializerBase.BinaryDataSurrogate CreateSurrogate(BinaryData asset) { }

	// RVA: 0x7D9EC4C Offset: 0x7D9AC4C VA: 0x7D9EC4C
	private BinaryData CreateFromSurrogate(JsonAssetSerializerBase.BinaryDataSurrogate surrogate) { }

	// RVA: 0x7D9F1DC Offset: 0x7D9B1DC VA: 0x7D9F1DC
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SystemBase.<get_Hierarchy>d__12 : IEnumerable<SystemBase>, IEnumerable, IEnumerator<SystemBase>, IEnumerator, IDisposable // TypeDefIndex: 27364
{
	// Fields
	private int <>1__state; // 0x10
	private SystemBase <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public SystemBase <>4__this; // 0x28
	private IEnumerator<SystemBase> <>7__wrap1; // 0x30
	private IEnumerator<SystemBase> <>7__wrap2; // 0x38

	// Properties
	private SystemBase System.Collections.Generic.IEnumerator<Quantum.SystemBase>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7D9FA90 Offset: 0x7D9BA90 VA: 0x7D9FA90
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7D9FB90 Offset: 0x7D9BB90 VA: 0x7D9FB90 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D9FC40 Offset: 0x7D9BC40 VA: 0x7D9FC40 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7DA0184 Offset: 0x7D9C184 VA: 0x7DA0184
	private void <>m__Finally1() { }

	// RVA: 0x7DA00D4 Offset: 0x7D9C0D4 VA: 0x7DA00D4
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7DA0234 Offset: 0x7D9C234 VA: 0x7DA0234 Slot: 6
	private SystemBase System.Collections.Generic.IEnumerator<Quantum.SystemBase>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7DA023C Offset: 0x7D9C23C VA: 0x7DA023C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7DA0274 Offset: 0x7D9C274 VA: 0x7DA0274 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7DA027C Offset: 0x7D9C27C VA: 0x7DA027C Slot: 4
	private IEnumerator<SystemBase> System.Collections.Generic.IEnumerable<Quantum.SystemBase>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7DA0320 Offset: 0x7D9C320 VA: 0x7DA0320 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Quantum
public abstract class SystemBase // TypeDefIndex: 27365
{
	// Fields
	private Nullable<int> _runtimeIndex; // 0x10
	private string _scheduleSample; // 0x18
	private SystemBase _parentSystem; // 0x20

	// Properties
	public int RuntimeIndex { get; set; }
	public SystemBase ParentSystem { get; set; }
	public virtual IEnumerable<SystemBase> ChildSystems { get; }
	public IEnumerable<SystemBase> Hierarchy { get; }
	public virtual bool StartEnabled { get; }

	// Methods

	// RVA: 0x7D94D00 Offset: 0x7D90D00 VA: 0x7D94D00 Slot: 4
	public int get_RuntimeIndex() { }

	// RVA: 0x7D9B8A4 Offset: 0x7D978A4 VA: 0x7D9B8A4
	public void set_RuntimeIndex(int value) { }

	// RVA: 0x7D9FA3C Offset: 0x7D9BA3C VA: 0x7D9FA3C
	public SystemBase get_ParentSystem() { }

	// RVA: 0x7D9FA44 Offset: 0x7D9BA44 VA: 0x7D9FA44
	internal void set_ParentSystem(SystemBase value) { }

	// RVA: 0x7D9FA4C Offset: 0x7D9BA4C VA: 0x7D9FA4C Slot: 5
	public virtual IEnumerable<SystemBase> get_ChildSystems() { }

	[IteratorStateMachine(typeof(SystemBase.<get_Hierarchy>d__12))]
	// RVA: 0x7D9C848 Offset: 0x7D98848 VA: 0x7D9C848
	public IEnumerable<SystemBase> get_Hierarchy() { }

	// RVA: 0x7D9FAC4 Offset: 0x7D9BAC4 VA: 0x7D9FAC4 Slot: 6
	public virtual bool get_StartEnabled() { }

	// RVA: 0x7D9FACC Offset: 0x7D9BACC VA: 0x7D9FACC
	public void .ctor() { }

	// RVA: 0x7D9FB54 Offset: 0x7D9BB54 VA: 0x7D9FB54
	public void .ctor(string scheduleSample) { }

	// RVA: 0x7D9FB84 Offset: 0x7D9BB84 VA: 0x7D9FB84 Slot: 7
	public virtual void OnInit(Frame f) { }

	// RVA: 0x7D9FB88 Offset: 0x7D9BB88 VA: 0x7D9FB88 Slot: 8
	public virtual void OnEnabled(Frame f) { }

	// RVA: 0x7D9FB8C Offset: 0x7D9BB8C VA: 0x7D9FB8C Slot: 9
	public virtual void OnDisabled(Frame f) { }

	// RVA: 0x7D9C434 Offset: 0x7D98434 VA: 0x7D9C434
	public TaskHandle OnSchedule(Frame f, TaskHandle taskHandle) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract TaskHandle Schedule(Frame f, TaskHandle taskHandle);
}

// Namespace: Quantum
public class SystemGroup : SystemBase // TypeDefIndex: 27366
{
	// Fields
	private SystemBase[] _children; // 0x28

	// Properties
	public sealed override IEnumerable<SystemBase> ChildSystems { get; }

	// Methods

	// RVA: 0x7DA0324 Offset: 0x7D9C324 VA: 0x7DA0324 Slot: 5
	public sealed override IEnumerable<SystemBase> get_ChildSystems() { }

	// RVA: 0x7DA032C Offset: 0x7D9C32C VA: 0x7DA032C
	public void .ctor(string name, SystemBase[] children) { }

	// RVA: 0x7DA040C Offset: 0x7D9C40C VA: 0x7DA040C Slot: 10
	protected sealed override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA0580 Offset: 0x7D9C580 VA: 0x7DA0580 Slot: 8
	public override void OnEnabled(Frame f) { }

	// RVA: 0x7DA061C Offset: 0x7D9C61C VA: 0x7DA061C Slot: 9
	public override void OnDisabled(Frame f) { }
}

// Namespace: Quantum
public abstract class SystemMainThread : SystemBase // TypeDefIndex: 27367
{
	// Fields
	private TaskDelegateHandle _updateHandle; // 0x28
	private string _update; // 0x30

	// Methods

	// RVA: 0x7DA06B8 Offset: 0x7D9C6B8 VA: 0x7DA06B8
	public void .ctor(string name) { }

	// RVA: 0x7DA0728 Offset: 0x7D9C728 VA: 0x7DA0728
	public void .ctor() { }

	// RVA: 0x7DA07AC Offset: 0x7D9C7AC VA: 0x7DA07AC
	protected TaskHandle ScheduleUpdate(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA08A8 Offset: 0x7D9C8A8 VA: 0x7DA08A8 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA08AC Offset: 0x7D9C8AC VA: 0x7DA08AC
	private void TaskCallback(FrameThreadSafe frame, int start, int count, void* arg) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Update(Frame f);
}

// Namespace: Quantum
public abstract class SystemMainThreadFilter<T> : SystemMainThread // TypeDefIndex: 27368
{
	// Properties
	public virtual bool UseCulling { get; }
	public virtual ComponentSet Without { get; }
	public virtual ComponentSet Any { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool get_UseCulling() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535BCC Offset: 0x5531BCC VA: 0x5535BCC
	|-SystemMainThreadFilter<__Il2CppFullySharedGenericStructType>.get_UseCulling
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual ComponentSet get_Without() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535BD4 Offset: 0x5531BD4 VA: 0x5535BD4
	|-SystemMainThreadFilter<__Il2CppFullySharedGenericStructType>.get_Without
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual ComponentSet get_Any() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535BE0 Offset: 0x5531BE0 VA: 0x5535BE0
	|-SystemMainThreadFilter<__Il2CppFullySharedGenericStructType>.get_Any
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public sealed override void Update(Frame f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535BEC Offset: 0x5531BEC VA: 0x5535BEC
	|-SystemMainThreadFilter<__Il2CppFullySharedGenericStructType>.Update
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void Update(Frame f, ref T filter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SystemMainThreadFilter<__Il2CppFullySharedGenericStructType>.Update
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535DB4 Offset: 0x5531DB4 VA: 0x5535DB4
	|-SystemMainThreadFilter<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: Quantum
public class SystemMainThreadGroup : SystemMainThread // TypeDefIndex: 27369
{
	// Fields
	private SystemMainThread[] _children; // 0x38

	// Properties
	public sealed override IEnumerable<SystemBase> ChildSystems { get; }

	// Methods

	// RVA: 0x7DA0984 Offset: 0x7D9C984 VA: 0x7DA0984
	public void .ctor(string name, SystemMainThread[] children) { }

	// RVA: 0x7DA0A50 Offset: 0x7D9CA50 VA: 0x7DA0A50 Slot: 5
	public sealed override IEnumerable<SystemBase> get_ChildSystems() { }

	// RVA: 0x7DA0A58 Offset: 0x7D9CA58 VA: 0x7DA0A58 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA0BCC Offset: 0x7D9CBCC VA: 0x7DA0BCC Slot: 8
	public override void OnEnabled(Frame f) { }

	// RVA: 0x7DA0C68 Offset: 0x7D9CC68 VA: 0x7DA0C68 Slot: 9
	public override void OnDisabled(Frame f) { }

	// RVA: 0x7DA0D04 Offset: 0x7D9CD04 VA: 0x7DA0D04 Slot: 11
	public sealed override void Update(Frame f) { }
}

// Namespace: Quantum
public class SystemSignalsOnly : SystemBase // TypeDefIndex: 27370
{
	// Methods

	// RVA: 0x7DA0D08 Offset: 0x7D9CD08 VA: 0x7DA0D08 Slot: 10
	protected sealed override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA0D14 Offset: 0x7D9CD14 VA: 0x7DA0D14
	public void .ctor() { }
}

// Namespace: Quantum
public static class SystemSetup // TypeDefIndex: 27371
{
	// Methods

	// RVA: 0x7D9B608 Offset: 0x7D97608 VA: 0x7D9B608
	public static SystemBase[] CreateSystems(IQuantumBridge quantumBridge, RuntimeConfig gameConfig, SimulationConfig simulationConfig) { }
}

// Namespace: Quantum.Core
public class CullingSystem2D : SystemBase // TypeDefIndex: 27372
{
	// Methods

	// RVA: 0x7DA0D80 Offset: 0x7D9CD80 VA: 0x7DA0D80 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA0D18 Offset: 0x7D9CD18 VA: 0x7DA0D18
	public void .ctor() { }
}

// Namespace: Quantum.Core
public class CullingSystem3D : SystemBase // TypeDefIndex: 27373
{
	// Methods

	// RVA: 0x7DA0DA8 Offset: 0x7D9CDA8 VA: 0x7DA0DA8 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA0DD0 Offset: 0x7D9CDD0 VA: 0x7DA0DD0
	public void .ctor() { }
}

// Namespace: Quantum.Core
public sealed class EntityPrototypeSystem : SystemSignalsOnly, ISignalOnMapChanged, ISignal // TypeDefIndex: 27374
{
	// Methods

	// RVA: 0x7DA0DD4 Offset: 0x7D9CDD4 VA: 0x7DA0DD4 Slot: 7
	public override void OnInit(Frame f) { }

	// RVA: 0x7DA0DDC Offset: 0x7D9CDDC VA: 0x7DA0DDC Slot: 11
	public void OnMapChanged(Frame f, AssetRefMap previousMap) { }

	// RVA: 0x7DA0D24 Offset: 0x7D9CD24 VA: 0x7DA0D24
	public void .ctor() { }
}

// Namespace: Quantum.Core
public class NavigationSystem : SystemBase, INavigationCallbacks // TypeDefIndex: 27375
{
	// Fields
	private Frame _f; // 0x28

	// Methods

	// RVA: 0x7DA0FA0 Offset: 0x7D9CFA0 VA: 0x7DA0FA0 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA1024 Offset: 0x7D9D024 VA: 0x7DA1024 Slot: 11
	public void OnWaypointReached(EntityRef entity, FPVector3 waypoint, Navigation.WaypointFlag waypointFlags, ref bool resetAgent) { }

	// RVA: 0x7DA1080 Offset: 0x7D9D080 VA: 0x7DA1080 Slot: 12
	public void OnSearchFailed(EntityRef entity, ref bool resetAgent) { }

	// RVA: 0x7DA109C Offset: 0x7D9D09C VA: 0x7DA109C Slot: 13
	public void OnMoveAgent(EntityRef entity, FPVector2 desiredDirection) { }

	// RVA: 0x7DA0D20 Offset: 0x7D9CD20 VA: 0x7DA0D20
	public void .ctor() { }
}

// Namespace: Quantum.Core
public class PhysicsSystem2D : SystemBase, ICollisionCallbacks2D // TypeDefIndex: 27376
{
	// Methods

	// RVA: 0x7DA10B8 Offset: 0x7D9D0B8 VA: 0x7DA10B8 Slot: 7
	public override void OnInit(Frame f) { }

	// RVA: 0x7DA1124 Offset: 0x7D9D124 VA: 0x7DA1124 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA11B4 Offset: 0x7D9D1B4 VA: 0x7DA11B4 Slot: 11
	public void OnCollision2D(FrameBase f, CollisionInfo2D info) { }

	// RVA: 0x7DA1260 Offset: 0x7D9D260 VA: 0x7DA1260 Slot: 12
	public void OnCollisionEnter2D(FrameBase f, CollisionInfo2D info) { }

	// RVA: 0x7DA130C Offset: 0x7D9D30C VA: 0x7DA130C Slot: 13
	public void OnCollisionExit2D(FrameBase f, ExitInfo2D info) { }

	// RVA: 0x7DA13A8 Offset: 0x7D9D3A8 VA: 0x7DA13A8 Slot: 14
	public void OnTrigger2D(FrameBase f, TriggerInfo2D info) { }

	// RVA: 0x7DA144C Offset: 0x7D9D44C VA: 0x7DA144C Slot: 15
	public void OnTriggerEnter2D(FrameBase f, TriggerInfo2D info) { }

	// RVA: 0x7DA14F0 Offset: 0x7D9D4F0 VA: 0x7DA14F0 Slot: 16
	public void OnTriggerExit2D(FrameBase f, ExitInfo2D info) { }

	// RVA: 0x7DA0D1C Offset: 0x7D9CD1C VA: 0x7DA0D1C
	public void .ctor() { }
}

// Namespace: Quantum.Core
public class PhysicsSystem3D : SystemBase, ICollisionCallbacks3D // TypeDefIndex: 27377
{
	// Methods

	// RVA: 0x7DA158C Offset: 0x7D9D58C VA: 0x7DA158C Slot: 7
	public override void OnInit(Frame f) { }

	// RVA: 0x7DA15F8 Offset: 0x7D9D5F8 VA: 0x7DA15F8 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }

	// RVA: 0x7DA16A4 Offset: 0x7D9D6A4 VA: 0x7DA16A4 Slot: 11
	public void OnCollision3D(FrameBase f, CollisionInfo3D info) { }

	// RVA: 0x7DA174C Offset: 0x7D9D74C VA: 0x7DA174C Slot: 12
	public void OnCollisionEnter3D(FrameBase f, CollisionInfo3D info) { }

	// RVA: 0x7DA17F4 Offset: 0x7D9D7F4 VA: 0x7DA17F4 Slot: 13
	public void OnCollisionExit3D(FrameBase f, ExitInfo3D info) { }

	// RVA: 0x7DA1890 Offset: 0x7D9D890 VA: 0x7DA1890 Slot: 14
	public void OnTrigger3D(FrameBase f, TriggerInfo3D info) { }

	// RVA: 0x7DA1934 Offset: 0x7D9D934 VA: 0x7DA1934 Slot: 15
	public void OnTriggerEnter3D(FrameBase f, TriggerInfo3D info) { }

	// RVA: 0x7DA19D8 Offset: 0x7D9D9D8 VA: 0x7DA19D8 Slot: 16
	public void OnTriggerExit3D(FrameBase f, ExitInfo3D info) { }

	// RVA: 0x7DA1A74 Offset: 0x7D9DA74 VA: 0x7DA1A74
	public void .ctor() { }
}

// Namespace: Quantum.Task
public abstract class SystemArrayComponent<T> : SystemBase // TypeDefIndex: 27378
{
	// Fields
	private TaskDelegateHandle _arrayTaskDelegateHandle; // 0x0
	private const int MAX_SLICES_COUNT = 32;

	// Properties
	public virtual int SlicesCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public virtual int get_SlicesCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535388 Offset: 0x5531388 VA: 0x5535388
	|-SystemArrayComponent<__Il2CppFullySharedGenericStructType>.get_SlicesCount
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public sealed override void OnInit(Frame f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535390 Offset: 0x5531390 VA: 0x5535390
	|-SystemArrayComponent<__Il2CppFullySharedGenericStructType>.OnInit
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnInitUser(Frame f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535490 Offset: 0x5531490 VA: 0x5535490
	|-SystemArrayComponent<__Il2CppFullySharedGenericStructType>.OnInitUser
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535494 Offset: 0x5531494 VA: 0x5535494
	|-SystemArrayComponent<__Il2CppFullySharedGenericStructType>.Schedule
	*/

	// RVA: -1 Offset: -1
	private void TaskArrayComponent(FrameThreadSafe f, int start, int count, void* arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55355A0 Offset: 0x55315A0 VA: 0x55355A0
	|-SystemArrayComponent<__Il2CppFullySharedGenericStructType>.TaskArrayComponent
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Update(FrameThreadSafe f, EntityRef entity, T* component);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SystemArrayComponent<__Il2CppFullySharedGenericStructType>.Update
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55356C8 Offset: 0x55316C8 VA: 0x55356C8
	|-SystemArrayComponent<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: Quantum.Task
public abstract class SystemArrayFilter<T> : SystemBase // TypeDefIndex: 27379
{
	// Fields
	private TaskDelegateHandle _arrayTaskDelegateHandle; // 0x0
	private ComponentFilterStructMeta _filterMeta; // 0x0
	private const int MAX_SLICES_COUNT = 32;

	// Properties
	public virtual int SlicesCount { get; }
	public virtual bool UseCulling { get; }
	public virtual ComponentSet Without { get; }
	public virtual ComponentSet Any { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public virtual int get_SlicesCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55356D0 Offset: 0x55316D0 VA: 0x55356D0
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>.get_SlicesCount
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool get_UseCulling() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55356D8 Offset: 0x55316D8 VA: 0x55356D8
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>.get_UseCulling
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual ComponentSet get_Without() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55356E0 Offset: 0x55316E0 VA: 0x55356E0
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>.get_Without
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual ComponentSet get_Any() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55356EC Offset: 0x55316EC VA: 0x55356EC
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>.get_Any
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public sealed override void OnInit(Frame f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55356F8 Offset: 0x55316F8 VA: 0x55356F8
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>.OnInit
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void OnInitUser(Frame f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535864 Offset: 0x5531864 VA: 0x5535864
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>.OnInitUser
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535868 Offset: 0x5531868 VA: 0x5535868
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>.Schedule
	*/

	// RVA: -1 Offset: -1
	private void TaskArrayFilter(FrameThreadSafe f, int start, int count, void* userData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55359B0 Offset: 0x55319B0 VA: 0x55359B0
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>.TaskArrayFilter
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Update(FrameThreadSafe f, ref T filter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>.Update
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535BC4 Offset: 0x5531BC4 VA: 0x5535BC4
	|-SystemArrayFilter<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: Quantum.Task
public abstract class SystemThreadedComponent<T> : SystemBase // TypeDefIndex: 27380
{
	// Fields
	private TaskDelegateHandle _threadedTaskDelegateHandle; // 0x0
	private int _sliceIndexer; // 0x0
	private int _sliceSize; // 0x0
	public const int DEFAULT_SLICE_SIZE = 16;

	// Properties
	public virtual int SliceSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public virtual int get_SliceSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535DBC Offset: 0x5531DBC VA: 0x5535DBC
	|-SystemThreadedComponent<__Il2CppFullySharedGenericStructType>.get_SliceSize
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public sealed override void OnInit(Frame f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535DC4 Offset: 0x5531DC4 VA: 0x5535DC4
	|-SystemThreadedComponent<__Il2CppFullySharedGenericStructType>.OnInit
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnInitUser(Frame f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535EC4 Offset: 0x5531EC4 VA: 0x5535EC4
	|-SystemThreadedComponent<__Il2CppFullySharedGenericStructType>.OnInitUser
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535EC8 Offset: 0x5531EC8 VA: 0x5535EC8
	|-SystemThreadedComponent<__Il2CppFullySharedGenericStructType>.Schedule
	*/

	// RVA: -1 Offset: -1
	private void TaskThreadedComponent(FrameThreadSafe f, int start, int count, void* userData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5535F9C Offset: 0x5531F9C VA: 0x5535F9C
	|-SystemThreadedComponent<__Il2CppFullySharedGenericStructType>.TaskThreadedComponent
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Update(FrameThreadSafe f, EntityRef entity, T* component);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SystemThreadedComponent<__Il2CppFullySharedGenericStructType>.Update
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55360D8 Offset: 0x55320D8 VA: 0x55360D8
	|-SystemThreadedComponent<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: Quantum.Task
public abstract class SystemThreadedFilter<T> : SystemBase // TypeDefIndex: 27381
{
	// Fields
	private TaskDelegateHandle _threadedTaskDelegateHandle; // 0x0
	private int _sliceIndexer; // 0x0
	private int _sliceSize; // 0x0
	public const int DEFAULT_SLICE_SIZE = 16;

	// Properties
	public virtual int SliceSize { get; }
	public virtual bool UseCulling { get; }
	public virtual ComponentSet Without { get; }
	public virtual ComponentSet Any { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public virtual int get_SliceSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55360E0 Offset: 0x55320E0 VA: 0x55360E0
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>.get_SliceSize
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool get_UseCulling() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55360E8 Offset: 0x55320E8 VA: 0x55360E8
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>.get_UseCulling
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual ComponentSet get_Without() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55360F0 Offset: 0x55320F0 VA: 0x55360F0
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>.get_Without
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual ComponentSet get_Any() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55360FC Offset: 0x55320FC VA: 0x55360FC
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>.get_Any
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public sealed override void OnInit(Frame f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536108 Offset: 0x5532108 VA: 0x5536108
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>.OnInit
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void OnInitUser(Frame f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x553620C Offset: 0x553220C VA: 0x553620C
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>.OnInitUser
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override TaskHandle Schedule(Frame f, TaskHandle taskHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5536210 Offset: 0x5532210 VA: 0x5536210
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>.Schedule
	*/

	// RVA: -1 Offset: -1
	private void TaskThreadedFilter(FrameThreadSafe f, int start, int count, void* userData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55362E4 Offset: 0x55322E4 VA: 0x55362E4
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>.TaskThreadedFilter
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Update(FrameThreadSafe f, ref T filter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>.Update
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55364E8 Offset: 0x55324E8 VA: 0x55364E8
	|-SystemThreadedFilter<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: 
public class FlatEntityPrototypeContainer.StoreVisitor : ComponentPrototypeVisitor // TypeDefIndex: 27382
{
	// Fields
	public FlatEntityPrototypeContainer Storage; // 0x10

	// Methods

	// RVA: 0x7DA1D98 Offset: 0x7D9DD98 VA: 0x7DA1D98 Slot: 4
	public override void Visit(CharacterController2D_Prototype prototype) { }

	// RVA: 0x7DA1DF4 Offset: 0x7D9DDF4 VA: 0x7DA1DF4 Slot: 5
	public override void Visit(CharacterController3D_Prototype prototype) { }

	// RVA: 0x7DA1E50 Offset: 0x7D9DE50 VA: 0x7DA1E50 Slot: 6
	public override void Visit(NavMeshAvoidanceAgent_Prototype prototype) { }

	// RVA: 0x7DA1EAC Offset: 0x7D9DEAC VA: 0x7DA1EAC Slot: 7
	public override void Visit(NavMeshAvoidanceObstacle_Prototype prototype) { }

	// RVA: 0x7DA1F08 Offset: 0x7D9DF08 VA: 0x7DA1F08 Slot: 8
	public override void Visit(NavMeshPathfinder_Prototype prototype) { }

	// RVA: 0x7DA1F64 Offset: 0x7D9DF64 VA: 0x7DA1F64 Slot: 9
	public override void Visit(NavMeshSteeringAgent_Prototype prototype) { }

	// RVA: 0x7DA1FC0 Offset: 0x7D9DFC0 VA: 0x7DA1FC0 Slot: 10
	public override void Visit(PhysicsBody2D_Prototype prototype) { }

	// RVA: 0x7DA201C Offset: 0x7D9E01C VA: 0x7DA201C Slot: 11
	public override void Visit(PhysicsBody3D_Prototype prototype) { }

	// RVA: 0x7DA2078 Offset: 0x7D9E078 VA: 0x7DA2078 Slot: 12
	public override void Visit(PhysicsCollider2D_Prototype prototype) { }

	// RVA: 0x7DA20D4 Offset: 0x7D9E0D4 VA: 0x7DA20D4 Slot: 15
	public override void Visit(PhysicsCollider3D_Prototype prototype) { }

	// RVA: 0x7DA2130 Offset: 0x7D9E130 VA: 0x7DA2130 Slot: 16
	public override void Visit(PhysicsCallbacks2D_Prototype prototype) { }

	// RVA: 0x7DA218C Offset: 0x7D9E18C VA: 0x7DA218C Slot: 17
	public override void Visit(PhysicsCallbacks3D_Prototype prototype) { }

	// RVA: 0x7DA21E8 Offset: 0x7D9E1E8 VA: 0x7DA21E8 Slot: 18
	public override void Visit(Transform2D_Prototype prototype) { }

	// RVA: 0x7DA2244 Offset: 0x7D9E244 VA: 0x7DA2244 Slot: 19
	public override void Visit(Transform2DVertical_Prototype prototype) { }

	// RVA: 0x7DA22A0 Offset: 0x7D9E2A0 VA: 0x7DA22A0 Slot: 20
	public override void Visit(Transform3D_Prototype prototype) { }

	// RVA: 0x7DA22FC Offset: 0x7D9E2FC VA: 0x7DA22FC Slot: 21
	public override void Visit(View_Prototype prototype) { }

	// RVA: 0x7DA2358 Offset: 0x7D9E358 VA: 0x7DA2358 Slot: 13
	public override void Visit(PhysicsJoints2D_Prototype prototype) { }

	// RVA: 0x7DA23B4 Offset: 0x7D9E3B4 VA: 0x7DA23B4 Slot: 14
	public override void Visit(PhysicsJoints3D_Prototype prototype) { }

	// RVA: 0x7D9ED34 Offset: 0x7D9AD34 VA: 0x7D9ED34
	public void .ctor() { }
}

// Namespace: Quantum.Prototypes
[Serializable]
public class FlatEntityPrototypeContainer // TypeDefIndex: 27383
{
	// Fields
	[ArrayLength(0, 1)]
	public List<CharacterController2D_Prototype> CharacterController2D; // 0x10
	[ArrayLength(0, 1)]
	public List<CharacterController3D_Prototype> CharacterController3D; // 0x18
	[ArrayLength(0, 1)]
	public List<NavMeshAvoidanceAgent_Prototype> NavMeshAvoidanceAgent; // 0x20
	[ArrayLength(0, 1)]
	public List<NavMeshAvoidanceObstacle_Prototype> NavMeshAvoidanceObstacle; // 0x28
	[ArrayLength(0, 1)]
	public List<NavMeshPathfinder_Prototype> NavMeshPathfinder; // 0x30
	[ArrayLength(0, 1)]
	public List<NavMeshSteeringAgent_Prototype> NavMeshSteeringAgent; // 0x38
	[ArrayLength(0, 1)]
	public List<PhysicsBody2D_Prototype> PhysicsBody2D; // 0x40
	[ArrayLength(0, 1)]
	public List<PhysicsBody3D_Prototype> PhysicsBody3D; // 0x48
	[ArrayLength(0, 1)]
	public List<PhysicsCollider2D_Prototype> PhysicsCollider2D; // 0x50
	[ArrayLength(0, 1)]
	public List<PhysicsCollider3D_Prototype> PhysicsCollider3D; // 0x58
	[ArrayLength(0, 1)]
	public List<PhysicsCallbacks2D_Prototype> PhysicsCallbacks2D; // 0x60
	[ArrayLength(0, 1)]
	public List<PhysicsCallbacks3D_Prototype> PhysicsCallbacks3D; // 0x68
	[ArrayLength(0, 1)]
	public List<Transform2D_Prototype> Transform2D; // 0x70
	[ArrayLength(0, 1)]
	public List<Transform2DVertical_Prototype> Transform2DVertical; // 0x78
	[ArrayLength(0, 1)]
	public List<Transform3D_Prototype> Transform3D; // 0x80
	[ArrayLength(0, 1)]
	public List<View_Prototype> View; // 0x88
	[ArrayLength(0, 1)]
	public List<PhysicsJoints2D_Prototype> PhysicsJoints2D; // 0x90
	[ArrayLength(0, 1)]
	public List<PhysicsJoints3D_Prototype> PhysicsJoints3D; // 0x98

	// Methods

	// RVA: 0x7D9ED54 Offset: 0x7D9AD54 VA: 0x7D9ED54
	public void Collect(List<ComponentPrototype> target) { }

	// RVA: 0x7DA1A78 Offset: 0x7D9DA78 VA: 0x7DA1A78
	public void Store(IList<ComponentPrototype> prototypes) { }

	// RVA: -1 Offset: -1
	private void Collect<TPrototype>(List<TPrototype> source, List<ComponentPrototype> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46007F0 Offset: 0x45FC7F0 VA: 0x46007F0
	|-FlatEntityPrototypeContainer.Collect<object>
	*/

	// RVA: -1 Offset: -1
	private void Store<T>(T value, ref List<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46008E4 Offset: 0x45FC8E4 VA: 0x46008E4
	|-FlatEntityPrototypeContainer.Store<object>
	|
	|-RVA: 0x46009D0 Offset: 0x45FC9D0 VA: 0x46009D0
	|-FlatEntityPrototypeContainer.Store<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D9ED3C Offset: 0x7D9AD3C VA: 0x7D9ED3C
	public void .ctor() { }
}

// Namespace: Quantum.Platformer
public interface IQuantumBridge : IQuantumUserLogic, IQuantumUserPhysics, IQuantumUserPhysics3D, IQuantumUserPhysics2D // TypeDefIndex: 27384
{}

// Namespace: Quantum.Platformer
public interface IQuantumUserLogic // TypeDefIndex: 27385
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update(Frame f);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnInit(Frame f);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnEnabled(Frame f);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnDisabled(Frame f);
}

// Namespace: Quantum.Platformer
public class UserLogicSystem : SystemMainThread // TypeDefIndex: 27386
{
	// Fields
	private IQuantumUserLogic _quantumUserLogic; // 0x38

	// Methods

	// RVA: 0x7DA0D54 Offset: 0x7D9CD54 VA: 0x7DA0D54
	public void .ctor(IQuantumUserLogic quantumUserLogic) { }

	// RVA: 0x7DA2410 Offset: 0x7D9E410 VA: 0x7DA2410 Slot: 11
	public override void Update(Frame f) { }

	// RVA: 0x7DA24B8 Offset: 0x7D9E4B8 VA: 0x7DA24B8 Slot: 7
	public override void OnInit(Frame f) { }

	// RVA: 0x7DA2564 Offset: 0x7D9E564 VA: 0x7DA2564 Slot: 8
	public override void OnEnabled(Frame f) { }

	// RVA: 0x7DA2610 Offset: 0x7D9E610 VA: 0x7DA2610 Slot: 9
	public override void OnDisabled(Frame f) { }
}

// Namespace: Quantum.Platformer
public interface IQuantumUserNavigation // TypeDefIndex: 27387
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNavMeshWaypointReached(Frame f, EntityRef entity, FPVector3 waypoint, Navigation.WaypointFlag waypointFlags, ref bool resetAgent);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnNavMeshSearchFailed(Frame f, EntityRef entity, ref bool resetAgent);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnNavMeshMoveAgent(Frame f, EntityRef entity, FPVector2 desiredDirection);
}

// Namespace: Quantum.Platformer
public class UserNavigationSystem : SystemSignalsOnly, ISignalOnNavMeshWaypointReached, ISignal, ISignalOnNavMeshSearchFailed, ISignalOnNavMeshMoveAgent // TypeDefIndex: 27388
{
	// Fields
	private IQuantumUserNavigation _quantumUserNavigation; // 0x28

	// Methods

	// RVA: 0x7DA26BC Offset: 0x7D9E6BC VA: 0x7DA26BC
	public void .ctor(IQuantumUserNavigation quantumUserNavigation) { }

	// RVA: 0x7DA26E8 Offset: 0x7D9E6E8 VA: 0x7DA26E8 Slot: 11
	public void OnNavMeshWaypointReached(Frame f, EntityRef entity, FPVector3 waypoint, Navigation.WaypointFlag waypointFlags, ref bool resetAgent) { }

	// RVA: 0x7DA2828 Offset: 0x7D9E828 VA: 0x7DA2828 Slot: 13
	public void OnNavMeshSearchFailed(Frame f, EntityRef entity, ref bool resetAgent) { }

	// RVA: 0x7DA28EC Offset: 0x7D9E8EC VA: 0x7DA28EC Slot: 14
	public void OnNavMeshMoveAgent(Frame f, EntityRef entity, FPVector2 desiredDirection) { }
}

// Namespace: Quantum.Platformer
public interface IQuantumUserPhysics3D // TypeDefIndex: 27389
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollision3D(Frame f, CollisionInfo3D info);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCollisionEnter3D(Frame f, CollisionInfo3D info);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCollisionExit3D(Frame f, ExitInfo3D info);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnTrigger3D(Frame f, TriggerInfo3D info);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnTriggerEnter3D(Frame f, TriggerInfo3D info);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnTriggerExit3D(Frame f, ExitInfo3D info);
}

// Namespace: Quantum.Platformer
public interface IQuantumUserPhysics2D // TypeDefIndex: 27390
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCollision2D(Frame f, CollisionInfo2D info);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCollisionEnter2D(Frame f, CollisionInfo2D info);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCollisionExit2D(Frame f, ExitInfo2D info);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnTrigger2D(Frame f, TriggerInfo2D info);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnTriggerEnter2D(Frame f, TriggerInfo2D info);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnTriggerExit2D(Frame f, ExitInfo2D info);
}

// Namespace: Quantum.Platformer
public interface IQuantumUserPhysics : IQuantumUserPhysics3D, IQuantumUserPhysics2D // TypeDefIndex: 27391
{}

// Namespace: Quantum.Platformer
public class UserPhysicsSystem : SystemSignalsOnly, ISignalOnCollision3D, ISignal, ISignalOnCollisionEnter3D, ISignalOnCollisionExit3D, ISignalOnTrigger3D, ISignalOnTriggerEnter3D, ISignalOnTriggerExit3D, ISignalOnCollision2D, ISignalOnCollisionEnter2D, ISignalOnCollisionExit2D, ISignalOnTrigger2D, ISignalOnTriggerEnter2D, ISignalOnTriggerExit2D // TypeDefIndex: 27392
{
	// Fields
	private IQuantumUserPhysics _quantumUserPhysics; // 0x28

	// Methods

	// RVA: 0x7DA0D28 Offset: 0x7D9CD28 VA: 0x7DA0D28
	public void .ctor(IQuantumUserPhysics quantumUserPhysics3D) { }

	// RVA: 0x7DA29C0 Offset: 0x7D9E9C0 VA: 0x7DA29C0 Slot: 17
	public void OnTriggerExit3D(Frame f, ExitInfo3D info) { }

	// RVA: 0x7DA2AA4 Offset: 0x7D9EAA4 VA: 0x7DA2AA4 Slot: 16
	public void OnTriggerEnter3D(Frame f, TriggerInfo3D info) { }

	// RVA: 0x7DA2BA0 Offset: 0x7D9EBA0 VA: 0x7DA2BA0 Slot: 15
	public void OnTrigger3D(Frame f, TriggerInfo3D info) { }

	// RVA: 0x7DA2C9C Offset: 0x7D9EC9C VA: 0x7DA2C9C Slot: 14
	public void OnCollisionExit3D(Frame f, ExitInfo3D info) { }

	// RVA: 0x7DA2D80 Offset: 0x7D9ED80 VA: 0x7DA2D80 Slot: 13
	public void OnCollisionEnter3D(Frame f, CollisionInfo3D info) { }

	// RVA: 0x7DA2E84 Offset: 0x7D9EE84 VA: 0x7DA2E84 Slot: 11
	public void OnCollision3D(Frame f, CollisionInfo3D info) { }

	// RVA: 0x7DA2F84 Offset: 0x7D9EF84 VA: 0x7DA2F84 Slot: 18
	public void OnCollision2D(Frame f, CollisionInfo2D info) { }

	// RVA: 0x7DA3094 Offset: 0x7D9F094 VA: 0x7DA3094 Slot: 19
	public void OnCollisionEnter2D(Frame f, CollisionInfo2D info) { }

	// RVA: 0x7DA31A8 Offset: 0x7D9F1A8 VA: 0x7DA31A8 Slot: 20
	public void OnCollisionExit2D(Frame f, ExitInfo2D info) { }

	// RVA: 0x7DA328C Offset: 0x7D9F28C VA: 0x7DA328C Slot: 21
	public void OnTrigger2D(Frame f, TriggerInfo2D info) { }

	// RVA: 0x7DA3388 Offset: 0x7D9F388 VA: 0x7DA3388 Slot: 22
	public void OnTriggerEnter2D(Frame f, TriggerInfo2D info) { }

	// RVA: 0x7DA3484 Offset: 0x7D9F484 VA: 0x7DA3484 Slot: 23
	public void OnTriggerExit2D(Frame f, ExitInfo2D info) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2846 // TypeDefIndex: 27393
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3127 // TypeDefIndex: 27394
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 27395
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2846 1AB3B0D9518E68C950010BB0FDB8B2D8D27E124E2374930725891E779F710758 /*Metadata offset 0xF4D368*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3127 B14584E18C66E3FDBCA422D06A7D77769D5AE03C0C2A957FE35FF8E289695560 /*Metadata offset 0xF4DE88*/; // 0xB1E
}

