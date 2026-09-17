// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 24216
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 24217
{
	// Methods

	// RVA: 0x416C3F8 Offset: 0x41683F8 VA: 0x416C3F8
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 24218
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x416C400 Offset: 0x4168400 VA: 0x416C400
	public void .ctor(byte ) { }

	// RVA: 0x416C488 Offset: 0x4168488 VA: 0x416C488
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Usage(5196, AllowMultiple = False, Inherited = False)]
[Embedded]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 24219
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x416C4B8 Offset: 0x41684B8 VA: 0x416C4B8
	public void .ctor(byte ) { }
}

// Namespace: 
public class XRandom // TypeDefIndex: 24220
{
	// Fields
	private long seed; // 0x10
	private const long multiplier = 25214903917;
	private const long addend = 11;
	private const long mask = 281474976710655;
	private const double DOUBLE_UNIT = 1.1102230246251565E-16;
	private const string BadBound = "bound must be positive";
	private static long _seedUniquifier; // 0x0
	private double nextNextGaussian; // 0x18
	private bool haveNextNextGaussian; // 0x20

	// Methods

	// RVA: 0x416C4E0 Offset: 0x41684E0 VA: 0x416C4E0
	public static long nanoTime() { }

	// RVA: 0x416C54C Offset: 0x416854C VA: 0x416C54C
	public void .ctor() { }

	// RVA: 0x416C5B0 Offset: 0x41685B0 VA: 0x416C5B0
	private static long seedUniquifier() { }

	// RVA: 0x416C640 Offset: 0x4168640 VA: 0x416C640
	public void .ctor(long seed) { }

	// RVA: 0x416C74C Offset: 0x416874C VA: 0x416C74C
	private static long initialScramble(long seed) { }

	// RVA: 0x416C764 Offset: 0x4168764 VA: 0x416C764
	public void setSeed(long seed) { }

	// RVA: 0x416C870 Offset: 0x4168870 VA: 0x416C870
	protected int next(int bits) { }

	// RVA: 0x416C928 Offset: 0x4168928 VA: 0x416C928
	public void nextBytes(byte[] bytes) { }

	// RVA: 0x416CA08 Offset: 0x4168A08 VA: 0x416CA08
	public int nextInt() { }

	// RVA: 0x416CA10 Offset: 0x4168A10 VA: 0x416CA10
	public int nextInt(int bound) { }

	// RVA: 0x416CAD8 Offset: 0x4168AD8 VA: 0x416CAD8
	public int nextInt(int min, int max) { }

	// RVA: 0x416CB6C Offset: 0x4168B6C VA: 0x416CB6C
	public long nextLong() { }

	// RVA: 0x416CBA4 Offset: 0x4168BA4 VA: 0x416CBA4
	public bool nextBoolean() { }

	// RVA: 0x416CBC0 Offset: 0x4168BC0 VA: 0x416CBC0
	public float nextFloat() { }

	// RVA: 0x416CBE4 Offset: 0x4168BE4 VA: 0x416CBE4
	public double nextDouble() { }

	// RVA: 0x416CC2C Offset: 0x4168C2C VA: 0x416CC2C
	public double nextGaussian() { }

	// RVA: 0x416C910 Offset: 0x4168910 VA: 0x416C910
	public static long move_fill_0(long value, int bits) { }

	// RVA: 0x416CDC4 Offset: 0x4168DC4 VA: 0x416CDC4
	private static void .cctor() { }
}

// Namespace: 
public class XXRandom // TypeDefIndex: 24221
{
	// Fields
	private const long multiplier = 25214903917;
	private const long addend = 11;
	private const long mask = 281474976710655;
	private const int bits = 32;
	private const int maskBit = 48;
	private long _randSeed; // 0x10

	// Properties
	public long Seed { get; }

	// Methods

	// RVA: 0x416CE1C Offset: 0x4168E1C VA: 0x416CE1C
	public long get_Seed() { }

	// RVA: 0x416CE24 Offset: 0x4168E24 VA: 0x416CE24
	public void .ctor(uint seed = 17) { }

	// RVA: 0x416CE58 Offset: 0x4168E58 VA: 0x416CE58
	public void .ctor(long seed) { }

	// RVA: 0x416CE88 Offset: 0x4168E88 VA: 0x416CE88
	private uint NextUInt32() { }

	// RVA: 0x416CEB4 Offset: 0x4168EB4 VA: 0x416CEB4
	private uint Next(uint max) { }

	// RVA: 0x416CEE8 Offset: 0x4168EE8 VA: 0x416CEE8
	private int Next(int max) { }

	// RVA: 0x416CF24 Offset: 0x4168F24 VA: 0x416CF24
	public uint Range(uint min, uint max) { }

	// RVA: 0x416CF60 Offset: 0x4168F60 VA: 0x416CF60
	internal int Range(int min, int max) { }

	// RVA: 0x416CFB0 Offset: 0x4168FB0 VA: 0x416CFB0
	internal void SetSeed(uint seed) { }

	// RVA: 0x416CFBC Offset: 0x4168FBC VA: 0x416CFBC
	private FP NextFp() { }

	// RVA: 0x416CFE8 Offset: 0x4168FE8 VA: 0x416CFE8
	public FP Next() { }

	// RVA: 0x416D024 Offset: 0x4169024 VA: 0x416D024
	public FP Next(FP minInclusive, FP maxExclusive) { }

	// RVA: 0x416D068 Offset: 0x4169068 VA: 0x416D068
	public int Next(int minInclusive, int maxExclusive) { }

	// RVA: 0x416D0B4 Offset: 0x41690B4 VA: 0x416D0B4
	public int NextInclusive(int minInclusive, int maxInclusive) { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 24222
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
[CompilerGenerated]
[EditorBrowsable(1)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 24223
{
	// Methods

	// RVA: 0x416D108 Offset: 0x4169108 VA: 0x416D108
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x416D200 Offset: 0x4169200 VA: 0x416D200
	public void .ctor() { }
}

// Namespace: Assets.FrameworkLockStep.Runtime
public class TempConfig // TypeDefIndex: 24224
{
	// Fields
	public const int TrackEntityId = 100001;

	// Methods

	// RVA: 0x416D208 Offset: 0x4169208 VA: 0x416D208
	public void .ctor() { }
}

// Namespace: 
private struct OrderedDictionary.Entry<TKey, TValue> // TypeDefIndex: 24225
{
	// Fields
	public int hashCode; // 0x0
	public int next; // 0x0
	public TKey key; // 0x0
	public TValue value; // 0x0
	public int nextOrder; // 0x0
	public int previousOrder; // 0x0
}

// Namespace: 
internal struct OrderedDictionary.EmptyHelper<TKey, TValue> // TypeDefIndex: 24226
{
	// Fields
	public static OrderedDictionary<TKey, TValue> m_empty; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6056434 Offset: 0x6052434 VA: 0x6056434
	|-OrderedDictionary.EmptyHelper<ValueTuple<EntityRef, object>, FP>..cctor
	|
	|-RVA: 0x60564F8 Offset: 0x60524F8 VA: 0x60564F8
	|-OrderedDictionary.EmptyHelper<EntityRef, int>..cctor
	|
	|-RVA: 0x60565BC Offset: 0x60525BC VA: 0x60565BC
	|-OrderedDictionary.EmptyHelper<EntityRef, object>..cctor
	|
	|-RVA: 0x6056680 Offset: 0x6052680 VA: 0x6056680
	|-OrderedDictionary.EmptyHelper<int, ValueTuple<object, object, object, object>>..cctor
	|
	|-RVA: 0x6056744 Offset: 0x6052744 VA: 0x6056744
	|-OrderedDictionary.EmptyHelper<int, BulletLink>..cctor
	|
	|-RVA: 0x6056808 Offset: 0x6052808 VA: 0x6056808
	|-OrderedDictionary.EmptyHelper<int, HeroSkillCount>..cctor
	|
	|-RVA: 0x60568CC Offset: 0x60528CC VA: 0x60568CC
	|-OrderedDictionary.EmptyHelper<int, int>..cctor
	|
	|-RVA: 0x6056990 Offset: 0x6052990 VA: 0x6056990
	|-OrderedDictionary.EmptyHelper<int, object>..cctor
	|
	|-RVA: 0x6056A54 Offset: 0x6052A54 VA: 0x6056A54
	|-OrderedDictionary.EmptyHelper<Int32Enum, int>..cctor
	|
	|-RVA: 0x6056B18 Offset: 0x6052B18 VA: 0x6056B18
	|-OrderedDictionary.EmptyHelper<long, object>..cctor
	|
	|-RVA: 0x6056BDC Offset: 0x6052BDC VA: 0x6056BDC
	|-OrderedDictionary.EmptyHelper<object, FP>..cctor
	|
	|-RVA: 0x6056CA0 Offset: 0x6052CA0 VA: 0x6056CA0
	|-OrderedDictionary.EmptyHelper<object, long>..cctor
	|
	|-RVA: 0x6056D64 Offset: 0x6052D64 VA: 0x6056D64
	|-OrderedDictionary.EmptyHelper<object, object>..cctor
	|
	|-RVA: 0x6056E28 Offset: 0x6052E28 VA: 0x6056E28
	|-OrderedDictionary.EmptyHelper<ulong, object>..cctor
	|
	|-RVA: 0x6056EEC Offset: 0x6052EEC VA: 0x6056EEC
	|-OrderedDictionary.EmptyHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[DefaultMember("Item")]
public struct OrderedDictionary.Reader<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 24227
{
	// Fields
	private OrderedDictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public static OrderedDictionary.Reader<TKey, TValue> Empty { get; }
	public TValue Item { get; }
	public int Count { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static OrderedDictionary.Reader<TKey, TValue> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F294 Offset: 0x544B294 VA: 0x544F294
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.get_Empty
	|
	|-RVA: 0x544F5F8 Offset: 0x544B5F8 VA: 0x544F5F8
	|-OrderedDictionary.Reader<EntityRef, int>.get_Empty
	|
	|-RVA: 0x544F944 Offset: 0x544B944 VA: 0x544F944
	|-OrderedDictionary.Reader<EntityRef, object>.get_Empty
	|
	|-RVA: 0x544FC90 Offset: 0x544BC90 VA: 0x544FC90
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.get_Empty
	|
	|-RVA: 0x544FFF0 Offset: 0x544BFF0 VA: 0x544FFF0
	|-OrderedDictionary.Reader<int, BulletLink>.get_Empty
	|
	|-RVA: 0x5450358 Offset: 0x544C358 VA: 0x5450358
	|-OrderedDictionary.Reader<int, HeroSkillCount>.get_Empty
	|
	|-RVA: 0x5450684 Offset: 0x544C684 VA: 0x5450684
	|-OrderedDictionary.Reader<int, int>.get_Empty
	|
	|-RVA: 0x54509B0 Offset: 0x544C9B0 VA: 0x54509B0
	|-OrderedDictionary.Reader<int, object>.get_Empty
	|
	|-RVA: 0x5450CFC Offset: 0x544CCFC VA: 0x5450CFC
	|-OrderedDictionary.Reader<Int32Enum, int>.get_Empty
	|
	|-RVA: 0x5451028 Offset: 0x544D028 VA: 0x5451028
	|-OrderedDictionary.Reader<long, object>.get_Empty
	|
	|-RVA: 0x5451374 Offset: 0x544D374 VA: 0x5451374
	|-OrderedDictionary.Reader<object, FP>.get_Empty
	|
	|-RVA: 0x54516C0 Offset: 0x544D6C0 VA: 0x54516C0
	|-OrderedDictionary.Reader<object, long>.get_Empty
	|
	|-RVA: 0x5451A0C Offset: 0x544DA0C VA: 0x5451A0C
	|-OrderedDictionary.Reader<object, object>.get_Empty
	|
	|-RVA: 0x5451D58 Offset: 0x544DD58 VA: 0x5451D58
	|-OrderedDictionary.Reader<ulong, object>.get_Empty
	|
	|-RVA: 0x54520A4 Offset: 0x544E0A4 VA: 0x54520A4
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F330 Offset: 0x544B330 VA: 0x544F330
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.get_Item
	|
	|-RVA: 0x544F694 Offset: 0x544B694 VA: 0x544F694
	|-OrderedDictionary.Reader<EntityRef, int>.get_Item
	|
	|-RVA: 0x544F9E0 Offset: 0x544B9E0 VA: 0x544F9E0
	|-OrderedDictionary.Reader<EntityRef, object>.get_Item
	|
	|-RVA: 0x544FD2C Offset: 0x544BD2C VA: 0x544FD2C
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.get_Item
	|
	|-RVA: 0x545008C Offset: 0x544C08C VA: 0x545008C
	|-OrderedDictionary.Reader<int, BulletLink>.get_Item
	|
	|-RVA: 0x54503F4 Offset: 0x544C3F4 VA: 0x54503F4
	|-OrderedDictionary.Reader<int, HeroSkillCount>.get_Item
	|
	|-RVA: 0x5450720 Offset: 0x544C720 VA: 0x5450720
	|-OrderedDictionary.Reader<int, int>.get_Item
	|
	|-RVA: 0x5450A4C Offset: 0x544CA4C VA: 0x5450A4C
	|-OrderedDictionary.Reader<int, object>.get_Item
	|
	|-RVA: 0x5450D98 Offset: 0x544CD98 VA: 0x5450D98
	|-OrderedDictionary.Reader<Int32Enum, int>.get_Item
	|
	|-RVA: 0x54510C4 Offset: 0x544D0C4 VA: 0x54510C4
	|-OrderedDictionary.Reader<long, object>.get_Item
	|
	|-RVA: 0x5451410 Offset: 0x544D410 VA: 0x5451410
	|-OrderedDictionary.Reader<object, FP>.get_Item
	|
	|-RVA: 0x545175C Offset: 0x544D75C VA: 0x545175C
	|-OrderedDictionary.Reader<object, long>.get_Item
	|
	|-RVA: 0x5451AA8 Offset: 0x544DAA8 VA: 0x5451AA8
	|-OrderedDictionary.Reader<object, object>.get_Item
	|
	|-RVA: 0x5451DF4 Offset: 0x544DDF4 VA: 0x5451DF4
	|-OrderedDictionary.Reader<ulong, object>.get_Item
	|
	|-RVA: 0x5452140 Offset: 0x544E140 VA: 0x5452140
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F37C Offset: 0x544B37C VA: 0x544F37C
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.get_Count
	|
	|-RVA: 0x544F6D8 Offset: 0x544B6D8 VA: 0x544F6D8
	|-OrderedDictionary.Reader<EntityRef, int>.get_Count
	|
	|-RVA: 0x544FA24 Offset: 0x544BA24 VA: 0x544FA24
	|-OrderedDictionary.Reader<EntityRef, object>.get_Count
	|
	|-RVA: 0x544FD8C Offset: 0x544BD8C VA: 0x544FD8C
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.get_Count
	|
	|-RVA: 0x54500F4 Offset: 0x544C0F4 VA: 0x54500F4
	|-OrderedDictionary.Reader<int, BulletLink>.get_Count
	|
	|-RVA: 0x5450438 Offset: 0x544C438 VA: 0x5450438
	|-OrderedDictionary.Reader<int, HeroSkillCount>.get_Count
	|
	|-RVA: 0x5450764 Offset: 0x544C764 VA: 0x5450764
	|-OrderedDictionary.Reader<int, int>.get_Count
	|
	|-RVA: 0x5450A90 Offset: 0x544CA90 VA: 0x5450A90
	|-OrderedDictionary.Reader<int, object>.get_Count
	|
	|-RVA: 0x5450DDC Offset: 0x544CDDC VA: 0x5450DDC
	|-OrderedDictionary.Reader<Int32Enum, int>.get_Count
	|
	|-RVA: 0x5451108 Offset: 0x544D108 VA: 0x5451108
	|-OrderedDictionary.Reader<long, object>.get_Count
	|
	|-RVA: 0x5451454 Offset: 0x544D454 VA: 0x5451454
	|-OrderedDictionary.Reader<object, FP>.get_Count
	|
	|-RVA: 0x54517A0 Offset: 0x544D7A0 VA: 0x54517A0
	|-OrderedDictionary.Reader<object, long>.get_Count
	|
	|-RVA: 0x5451AEC Offset: 0x544DAEC VA: 0x5451AEC
	|-OrderedDictionary.Reader<object, object>.get_Count
	|
	|-RVA: 0x5451E38 Offset: 0x544DE38 VA: 0x5451E38
	|-OrderedDictionary.Reader<ulong, object>.get_Count
	|
	|-RVA: 0x5452334 Offset: 0x544E334 VA: 0x5452334
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F3B0 Offset: 0x544B3B0 VA: 0x544F3B0
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x544F70C Offset: 0x544B70C VA: 0x544F70C
	|-OrderedDictionary.Reader<EntityRef, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x544FA58 Offset: 0x544BA58 VA: 0x544FA58
	|-OrderedDictionary.Reader<EntityRef, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x544FDC0 Offset: 0x544BDC0 VA: 0x544FDC0
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5450128 Offset: 0x544C128 VA: 0x5450128
	|-OrderedDictionary.Reader<int, BulletLink>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x545046C Offset: 0x544C46C VA: 0x545046C
	|-OrderedDictionary.Reader<int, HeroSkillCount>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5450798 Offset: 0x544C798 VA: 0x5450798
	|-OrderedDictionary.Reader<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5450AC4 Offset: 0x544CAC4 VA: 0x5450AC4
	|-OrderedDictionary.Reader<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5450E10 Offset: 0x544CE10 VA: 0x5450E10
	|-OrderedDictionary.Reader<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x545113C Offset: 0x544D13C VA: 0x545113C
	|-OrderedDictionary.Reader<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5451488 Offset: 0x544D488 VA: 0x5451488
	|-OrderedDictionary.Reader<object, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54517D4 Offset: 0x544D7D4 VA: 0x54517D4
	|-OrderedDictionary.Reader<object, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5451B20 Offset: 0x544DB20 VA: 0x5451B20
	|-OrderedDictionary.Reader<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5451E6C Offset: 0x544DE6C VA: 0x5451E6C
	|-OrderedDictionary.Reader<ulong, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54523B4 Offset: 0x544E3B4 VA: 0x54523B4
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F3CC Offset: 0x544B3CC VA: 0x544F3CC
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x544F728 Offset: 0x544B728 VA: 0x544F728
	|-OrderedDictionary.Reader<EntityRef, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x544FA74 Offset: 0x544BA74 VA: 0x544FA74
	|-OrderedDictionary.Reader<EntityRef, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x544FDDC Offset: 0x544BDDC VA: 0x544FDDC
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5450144 Offset: 0x544C144 VA: 0x5450144
	|-OrderedDictionary.Reader<int, BulletLink>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5450488 Offset: 0x544C488 VA: 0x5450488
	|-OrderedDictionary.Reader<int, HeroSkillCount>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54507B4 Offset: 0x544C7B4 VA: 0x54507B4
	|-OrderedDictionary.Reader<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5450AE0 Offset: 0x544CAE0 VA: 0x5450AE0
	|-OrderedDictionary.Reader<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5450E2C Offset: 0x544CE2C VA: 0x5450E2C
	|-OrderedDictionary.Reader<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5451158 Offset: 0x544D158 VA: 0x5451158
	|-OrderedDictionary.Reader<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54514A4 Offset: 0x544D4A4 VA: 0x54514A4
	|-OrderedDictionary.Reader<object, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54517F0 Offset: 0x544D7F0 VA: 0x54517F0
	|-OrderedDictionary.Reader<object, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5451B3C Offset: 0x544DB3C VA: 0x5451B3C
	|-OrderedDictionary.Reader<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5451E88 Offset: 0x544DE88 VA: 0x5451E88
	|-OrderedDictionary.Reader<ulong, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54523D0 Offset: 0x544E3D0 VA: 0x54523D0
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1
	public void .ctor(OrderedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F3E8 Offset: 0x544B3E8 VA: 0x544F3E8
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x544F744 Offset: 0x544B744 VA: 0x544F744
	|-OrderedDictionary.Reader<EntityRef, int>..ctor
	|
	|-RVA: 0x544FA90 Offset: 0x544BA90 VA: 0x544FA90
	|-OrderedDictionary.Reader<EntityRef, object>..ctor
	|
	|-RVA: 0x544FDF8 Offset: 0x544BDF8 VA: 0x544FDF8
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x5450160 Offset: 0x544C160 VA: 0x5450160
	|-OrderedDictionary.Reader<int, BulletLink>..ctor
	|
	|-RVA: 0x54504A4 Offset: 0x544C4A4 VA: 0x54504A4
	|-OrderedDictionary.Reader<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x54507D0 Offset: 0x544C7D0 VA: 0x54507D0
	|-OrderedDictionary.Reader<int, int>..ctor
	|
	|-RVA: 0x5450AFC Offset: 0x544CAFC VA: 0x5450AFC
	|-OrderedDictionary.Reader<int, object>..ctor
	|
	|-RVA: 0x5450E48 Offset: 0x544CE48 VA: 0x5450E48
	|-OrderedDictionary.Reader<Int32Enum, int>..ctor
	|
	|-RVA: 0x5451174 Offset: 0x544D174 VA: 0x5451174
	|-OrderedDictionary.Reader<long, object>..ctor
	|
	|-RVA: 0x54514C0 Offset: 0x544D4C0 VA: 0x54514C0
	|-OrderedDictionary.Reader<object, FP>..ctor
	|
	|-RVA: 0x545180C Offset: 0x544D80C VA: 0x545180C
	|-OrderedDictionary.Reader<object, long>..ctor
	|
	|-RVA: 0x5451B58 Offset: 0x544DB58 VA: 0x5451B58
	|-OrderedDictionary.Reader<object, object>..ctor
	|
	|-RVA: 0x5451EA4 Offset: 0x544DEA4 VA: 0x5451EA4
	|-OrderedDictionary.Reader<ulong, object>..ctor
	|
	|-RVA: 0x54523EC Offset: 0x544E3EC VA: 0x54523EC
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F3F0 Offset: 0x544B3F0 VA: 0x544F3F0
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.ContainsKey
	|
	|-RVA: 0x544F74C Offset: 0x544B74C VA: 0x544F74C
	|-OrderedDictionary.Reader<EntityRef, int>.ContainsKey
	|
	|-RVA: 0x544FA98 Offset: 0x544BA98 VA: 0x544FA98
	|-OrderedDictionary.Reader<EntityRef, object>.ContainsKey
	|
	|-RVA: 0x544FE00 Offset: 0x544BE00 VA: 0x544FE00
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.ContainsKey
	|
	|-RVA: 0x5450168 Offset: 0x544C168 VA: 0x5450168
	|-OrderedDictionary.Reader<int, BulletLink>.ContainsKey
	|
	|-RVA: 0x54504AC Offset: 0x544C4AC VA: 0x54504AC
	|-OrderedDictionary.Reader<int, HeroSkillCount>.ContainsKey
	|
	|-RVA: 0x54507D8 Offset: 0x544C7D8 VA: 0x54507D8
	|-OrderedDictionary.Reader<int, int>.ContainsKey
	|
	|-RVA: 0x5450B04 Offset: 0x544CB04 VA: 0x5450B04
	|-OrderedDictionary.Reader<int, object>.ContainsKey
	|
	|-RVA: 0x5450E50 Offset: 0x544CE50 VA: 0x5450E50
	|-OrderedDictionary.Reader<Int32Enum, int>.ContainsKey
	|
	|-RVA: 0x545117C Offset: 0x544D17C VA: 0x545117C
	|-OrderedDictionary.Reader<long, object>.ContainsKey
	|
	|-RVA: 0x54514C8 Offset: 0x544D4C8 VA: 0x54514C8
	|-OrderedDictionary.Reader<object, FP>.ContainsKey
	|
	|-RVA: 0x5451814 Offset: 0x544D814 VA: 0x5451814
	|-OrderedDictionary.Reader<object, long>.ContainsKey
	|
	|-RVA: 0x5451B60 Offset: 0x544DB60 VA: 0x5451B60
	|-OrderedDictionary.Reader<object, object>.ContainsKey
	|
	|-RVA: 0x5451EAC Offset: 0x544DEAC VA: 0x5451EAC
	|-OrderedDictionary.Reader<ulong, object>.ContainsKey
	|
	|-RVA: 0x54523F4 Offset: 0x544E3F4 VA: 0x54523F4
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F43C Offset: 0x544B43C VA: 0x544F43C
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.TryGetValue
	|
	|-RVA: 0x544F790 Offset: 0x544B790 VA: 0x544F790
	|-OrderedDictionary.Reader<EntityRef, int>.TryGetValue
	|
	|-RVA: 0x544FADC Offset: 0x544BADC VA: 0x544FADC
	|-OrderedDictionary.Reader<EntityRef, object>.TryGetValue
	|
	|-RVA: 0x544FE44 Offset: 0x544BE44 VA: 0x544FE44
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.TryGetValue
	|
	|-RVA: 0x54501AC Offset: 0x544C1AC VA: 0x54501AC
	|-OrderedDictionary.Reader<int, BulletLink>.TryGetValue
	|
	|-RVA: 0x54504F0 Offset: 0x544C4F0 VA: 0x54504F0
	|-OrderedDictionary.Reader<int, HeroSkillCount>.TryGetValue
	|
	|-RVA: 0x545081C Offset: 0x544C81C VA: 0x545081C
	|-OrderedDictionary.Reader<int, int>.TryGetValue
	|
	|-RVA: 0x5450B48 Offset: 0x544CB48 VA: 0x5450B48
	|-OrderedDictionary.Reader<int, object>.TryGetValue
	|
	|-RVA: 0x5450E94 Offset: 0x544CE94 VA: 0x5450E94
	|-OrderedDictionary.Reader<Int32Enum, int>.TryGetValue
	|
	|-RVA: 0x54511C0 Offset: 0x544D1C0 VA: 0x54511C0
	|-OrderedDictionary.Reader<long, object>.TryGetValue
	|
	|-RVA: 0x545150C Offset: 0x544D50C VA: 0x545150C
	|-OrderedDictionary.Reader<object, FP>.TryGetValue
	|
	|-RVA: 0x5451858 Offset: 0x544D858 VA: 0x5451858
	|-OrderedDictionary.Reader<object, long>.TryGetValue
	|
	|-RVA: 0x5451BA4 Offset: 0x544DBA4 VA: 0x5451BA4
	|-OrderedDictionary.Reader<object, object>.TryGetValue
	|
	|-RVA: 0x5451EF0 Offset: 0x544DEF0 VA: 0x5451EF0
	|-OrderedDictionary.Reader<ulong, object>.TryGetValue
	|
	|-RVA: 0x5452590 Offset: 0x544E590 VA: 0x5452590
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F498 Offset: 0x544B498 VA: 0x544F498
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.GetEnumerator
	|
	|-RVA: 0x544F7DC Offset: 0x544B7DC VA: 0x544F7DC
	|-OrderedDictionary.Reader<EntityRef, int>.GetEnumerator
	|
	|-RVA: 0x544FB28 Offset: 0x544BB28 VA: 0x544FB28
	|-OrderedDictionary.Reader<EntityRef, object>.GetEnumerator
	|
	|-RVA: 0x544FE90 Offset: 0x544BE90 VA: 0x544FE90
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.GetEnumerator
	|
	|-RVA: 0x54501F8 Offset: 0x544C1F8 VA: 0x54501F8
	|-OrderedDictionary.Reader<int, BulletLink>.GetEnumerator
	|
	|-RVA: 0x545053C Offset: 0x544C53C VA: 0x545053C
	|-OrderedDictionary.Reader<int, HeroSkillCount>.GetEnumerator
	|
	|-RVA: 0x5450868 Offset: 0x544C868 VA: 0x5450868
	|-OrderedDictionary.Reader<int, int>.GetEnumerator
	|
	|-RVA: 0x5450B94 Offset: 0x544CB94 VA: 0x5450B94
	|-OrderedDictionary.Reader<int, object>.GetEnumerator
	|
	|-RVA: 0x5450EE0 Offset: 0x544CEE0 VA: 0x5450EE0
	|-OrderedDictionary.Reader<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x545120C Offset: 0x544D20C VA: 0x545120C
	|-OrderedDictionary.Reader<long, object>.GetEnumerator
	|
	|-RVA: 0x5451558 Offset: 0x544D558 VA: 0x5451558
	|-OrderedDictionary.Reader<object, FP>.GetEnumerator
	|
	|-RVA: 0x54518A4 Offset: 0x544D8A4 VA: 0x54518A4
	|-OrderedDictionary.Reader<object, long>.GetEnumerator
	|
	|-RVA: 0x5451BF0 Offset: 0x544DBF0 VA: 0x5451BF0
	|-OrderedDictionary.Reader<object, object>.GetEnumerator
	|
	|-RVA: 0x5451F3C Offset: 0x544DF3C VA: 0x5451F3C
	|-OrderedDictionary.Reader<ulong, object>.GetEnumerator
	|
	|-RVA: 0x5452738 Offset: 0x544E738 VA: 0x5452738
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F4F8 Offset: 0x544B4F8 VA: 0x544F4F8
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x544F83C Offset: 0x544B83C VA: 0x544F83C
	|-OrderedDictionary.Reader<EntityRef, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x544FB88 Offset: 0x544BB88 VA: 0x544FB88
	|-OrderedDictionary.Reader<EntityRef, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x544FEF0 Offset: 0x544BEF0 VA: 0x544FEF0
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5450258 Offset: 0x544C258 VA: 0x5450258
	|-OrderedDictionary.Reader<int, BulletLink>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5450594 Offset: 0x544C594 VA: 0x5450594
	|-OrderedDictionary.Reader<int, HeroSkillCount>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54508C0 Offset: 0x544C8C0 VA: 0x54508C0
	|-OrderedDictionary.Reader<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5450BF4 Offset: 0x544CBF4 VA: 0x5450BF4
	|-OrderedDictionary.Reader<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5450F38 Offset: 0x544CF38 VA: 0x5450F38
	|-OrderedDictionary.Reader<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x545126C Offset: 0x544D26C VA: 0x545126C
	|-OrderedDictionary.Reader<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54515B8 Offset: 0x544D5B8 VA: 0x54515B8
	|-OrderedDictionary.Reader<object, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5451904 Offset: 0x544D904 VA: 0x5451904
	|-OrderedDictionary.Reader<object, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5451C50 Offset: 0x544DC50 VA: 0x5451C50
	|-OrderedDictionary.Reader<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5451F9C Offset: 0x544DF9C VA: 0x5451F9C
	|-OrderedDictionary.Reader<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5452854 Offset: 0x544E854 VA: 0x5452854
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F578 Offset: 0x544B578 VA: 0x544F578
	|-OrderedDictionary.Reader<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x544F8C0 Offset: 0x544B8C0 VA: 0x544F8C0
	|-OrderedDictionary.Reader<EntityRef, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x544FC0C Offset: 0x544BC0C VA: 0x544FC0C
	|-OrderedDictionary.Reader<EntityRef, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x544FF70 Offset: 0x544BF70 VA: 0x544FF70
	|-OrderedDictionary.Reader<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54502D8 Offset: 0x544C2D8 VA: 0x54502D8
	|-OrderedDictionary.Reader<int, BulletLink>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x545060C Offset: 0x544C60C VA: 0x545060C
	|-OrderedDictionary.Reader<int, HeroSkillCount>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5450938 Offset: 0x544C938 VA: 0x5450938
	|-OrderedDictionary.Reader<int, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5450C78 Offset: 0x544CC78 VA: 0x5450C78
	|-OrderedDictionary.Reader<int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5450FB0 Offset: 0x544CFB0 VA: 0x5450FB0
	|-OrderedDictionary.Reader<Int32Enum, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54512F0 Offset: 0x544D2F0 VA: 0x54512F0
	|-OrderedDictionary.Reader<long, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x545163C Offset: 0x544D63C VA: 0x545163C
	|-OrderedDictionary.Reader<object, FP>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5451988 Offset: 0x544D988 VA: 0x5451988
	|-OrderedDictionary.Reader<object, long>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5451CD4 Offset: 0x544DCD4 VA: 0x5451CD4
	|-OrderedDictionary.Reader<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5452020 Offset: 0x544E020 VA: 0x5452020
	|-OrderedDictionary.Reader<ulong, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5452978 Offset: 0x544E978 VA: 0x5452978
	|-OrderedDictionary.Reader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class OrderedDictionary.ReverseReader.<>c<TKey, TValue> // TypeDefIndex: 24228
{
	// Fields
	public static readonly OrderedDictionary.ReverseReader.<>c<TKey, TValue> <>9; // 0x0
	public static Func<KeyValuePair<TKey, TValue>, TKey> <>9__8_0; // 0x0
	public static Func<KeyValuePair<TKey, TValue>, TValue> <>9__10_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482B994 Offset: 0x4827994 VA: 0x482B994
	|-OrderedDictionary.ReverseReader.<>c<ValueTuple<EntityRef, object>, FP>..cctor
	|
	|-RVA: 0x482BA68 Offset: 0x4827A68 VA: 0x482BA68
	|-OrderedDictionary.ReverseReader.<>c<EntityRef, int>..cctor
	|
	|-RVA: 0x482BB3C Offset: 0x4827B3C VA: 0x482BB3C
	|-OrderedDictionary.ReverseReader.<>c<EntityRef, object>..cctor
	|
	|-RVA: 0x482BC10 Offset: 0x4827C10 VA: 0x482BC10
	|-OrderedDictionary.ReverseReader.<>c<int, ValueTuple<object, object, object, object>>..cctor
	|
	|-RVA: 0x482BFE4 Offset: 0x4827FE4 VA: 0x482BFE4
	|-OrderedDictionary.ReverseReader.<>c<int, BulletLink>..cctor
	|
	|-RVA: 0x482C0C8 Offset: 0x48280C8 VA: 0x482C0C8
	|-OrderedDictionary.ReverseReader.<>c<int, HeroSkillCount>..cctor
	|
	|-RVA: 0x482C5C4 Offset: 0x48285C4 VA: 0x482C5C4
	|-OrderedDictionary.ReverseReader.<>c<int, int>..cctor
	|
	|-RVA: 0x482CC3C Offset: 0x4828C3C VA: 0x482CC3C
	|-OrderedDictionary.ReverseReader.<>c<int, object>..cctor
	|
	|-RVA: 0x482D5CC Offset: 0x48295CC VA: 0x482D5CC
	|-OrderedDictionary.ReverseReader.<>c<Int32Enum, int>..cctor
	|
	|-RVA: 0x482E058 Offset: 0x482A058 VA: 0x482E058
	|-OrderedDictionary.ReverseReader.<>c<long, object>..cctor
	|
	|-RVA: 0x482EC98 Offset: 0x482AC98 VA: 0x482EC98
	|-OrderedDictionary.ReverseReader.<>c<object, FP>..cctor
	|
	|-RVA: 0x482F414 Offset: 0x482B414 VA: 0x482F414
	|-OrderedDictionary.ReverseReader.<>c<object, long>..cctor
	|
	|-RVA: 0x482FABC Offset: 0x482BABC VA: 0x482FABC
	|-OrderedDictionary.ReverseReader.<>c<object, object>..cctor
	|
	|-RVA: 0x48337C8 Offset: 0x482F7C8 VA: 0x48337C8
	|-OrderedDictionary.ReverseReader.<>c<ulong, object>..cctor
	|
	|-RVA: 0x48352BC Offset: 0x48312BC VA: 0x48352BC
	|-OrderedDictionary.ReverseReader.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482BA50 Offset: 0x4827A50 VA: 0x482BA50
	|-OrderedDictionary.ReverseReader.<>c<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x482BB24 Offset: 0x4827B24 VA: 0x482BB24
	|-OrderedDictionary.ReverseReader.<>c<EntityRef, int>..ctor
	|
	|-RVA: 0x482BBF8 Offset: 0x4827BF8 VA: 0x482BBF8
	|-OrderedDictionary.ReverseReader.<>c<EntityRef, object>..ctor
	|
	|-RVA: 0x482BCCC Offset: 0x4827CCC VA: 0x482BCCC
	|-OrderedDictionary.ReverseReader.<>c<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x482C0A0 Offset: 0x48280A0 VA: 0x482C0A0
	|-OrderedDictionary.ReverseReader.<>c<int, BulletLink>..ctor
	|
	|-RVA: 0x482C184 Offset: 0x4828184 VA: 0x482C184
	|-OrderedDictionary.ReverseReader.<>c<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x482C680 Offset: 0x4828680 VA: 0x482C680
	|-OrderedDictionary.ReverseReader.<>c<int, int>..ctor
	|
	|-RVA: 0x482CCF8 Offset: 0x4828CF8 VA: 0x482CCF8
	|-OrderedDictionary.ReverseReader.<>c<int, object>..ctor
	|
	|-RVA: 0x482D688 Offset: 0x4829688 VA: 0x482D688
	|-OrderedDictionary.ReverseReader.<>c<Int32Enum, int>..ctor
	|
	|-RVA: 0x482E114 Offset: 0x482A114 VA: 0x482E114
	|-OrderedDictionary.ReverseReader.<>c<long, object>..ctor
	|
	|-RVA: 0x482ED54 Offset: 0x482AD54 VA: 0x482ED54
	|-OrderedDictionary.ReverseReader.<>c<object, FP>..ctor
	|
	|-RVA: 0x482F4D0 Offset: 0x482B4D0 VA: 0x482F4D0
	|-OrderedDictionary.ReverseReader.<>c<object, long>..ctor
	|
	|-RVA: 0x482FB78 Offset: 0x482BB78 VA: 0x482FB78
	|-OrderedDictionary.ReverseReader.<>c<object, object>..ctor
	|
	|-RVA: 0x4833884 Offset: 0x482F884 VA: 0x4833884
	|-OrderedDictionary.ReverseReader.<>c<ulong, object>..ctor
	|
	|-RVA: 0x48353B0 Offset: 0x48313B0 VA: 0x48353B0
	|-OrderedDictionary.ReverseReader.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TKey <System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0(KeyValuePair<TKey, TValue> s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482BA58 Offset: 0x4827A58 VA: 0x482BA58
	|-OrderedDictionary.ReverseReader.<>c<ValueTuple<EntityRef, object>, FP>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482BB2C Offset: 0x4827B2C VA: 0x482BB2C
	|-OrderedDictionary.ReverseReader.<>c<EntityRef, int>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482BC00 Offset: 0x4827C00 VA: 0x482BC00
	|-OrderedDictionary.ReverseReader.<>c<EntityRef, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482BCD4 Offset: 0x4827CD4 VA: 0x482BCD4
	|-OrderedDictionary.ReverseReader.<>c<int, ValueTuple<object, object, object, object>>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482C0A8 Offset: 0x48280A8 VA: 0x482C0A8
	|-OrderedDictionary.ReverseReader.<>c<int, BulletLink>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482C18C Offset: 0x482818C VA: 0x482C18C
	|-OrderedDictionary.ReverseReader.<>c<int, HeroSkillCount>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482C688 Offset: 0x4828688 VA: 0x482C688
	|-OrderedDictionary.ReverseReader.<>c<int, int>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482CD00 Offset: 0x4828D00 VA: 0x482CD00
	|-OrderedDictionary.ReverseReader.<>c<int, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482D690 Offset: 0x4829690 VA: 0x482D690
	|-OrderedDictionary.ReverseReader.<>c<Int32Enum, int>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482E11C Offset: 0x482A11C VA: 0x482E11C
	|-OrderedDictionary.ReverseReader.<>c<long, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482ED5C Offset: 0x482AD5C VA: 0x482ED5C
	|-OrderedDictionary.ReverseReader.<>c<object, FP>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482F4D8 Offset: 0x482B4D8 VA: 0x482F4D8
	|-OrderedDictionary.ReverseReader.<>c<object, long>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x482FB80 Offset: 0x482BB80 VA: 0x482FB80
	|-OrderedDictionary.ReverseReader.<>c<object, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x483388C Offset: 0x482F88C VA: 0x483388C
	|-OrderedDictionary.ReverseReader.<>c<ulong, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	|
	|-RVA: 0x48353B8 Offset: 0x48313B8 VA: 0x48353B8
	|-OrderedDictionary.ReverseReader.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys>b__8_0
	*/

	// RVA: -1 Offset: -1
	internal TValue <System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0(KeyValuePair<TKey, TValue> s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482BA60 Offset: 0x4827A60 VA: 0x482BA60
	|-OrderedDictionary.ReverseReader.<>c<ValueTuple<EntityRef, object>, FP>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482BB34 Offset: 0x4827B34 VA: 0x482BB34
	|-OrderedDictionary.ReverseReader.<>c<EntityRef, int>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482BC08 Offset: 0x4827C08 VA: 0x482BC08
	|-OrderedDictionary.ReverseReader.<>c<EntityRef, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482BCDC Offset: 0x4827CDC VA: 0x482BCDC
	|-OrderedDictionary.ReverseReader.<>c<int, ValueTuple<object, object, object, object>>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482C0B0 Offset: 0x48280B0 VA: 0x482C0B0
	|-OrderedDictionary.ReverseReader.<>c<int, BulletLink>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482C194 Offset: 0x4828194 VA: 0x482C194
	|-OrderedDictionary.ReverseReader.<>c<int, HeroSkillCount>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482C690 Offset: 0x4828690 VA: 0x482C690
	|-OrderedDictionary.ReverseReader.<>c<int, int>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482CD08 Offset: 0x4828D08 VA: 0x482CD08
	|-OrderedDictionary.ReverseReader.<>c<int, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482D698 Offset: 0x4829698 VA: 0x482D698
	|-OrderedDictionary.ReverseReader.<>c<Int32Enum, int>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482E124 Offset: 0x482A124 VA: 0x482E124
	|-OrderedDictionary.ReverseReader.<>c<long, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482ED64 Offset: 0x482AD64 VA: 0x482ED64
	|-OrderedDictionary.ReverseReader.<>c<object, FP>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482F4E0 Offset: 0x482B4E0 VA: 0x482F4E0
	|-OrderedDictionary.ReverseReader.<>c<object, long>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x482FB88 Offset: 0x482BB88 VA: 0x482FB88
	|-OrderedDictionary.ReverseReader.<>c<object, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x4833894 Offset: 0x482F894 VA: 0x4833894
	|-OrderedDictionary.ReverseReader.<>c<ulong, object>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	|
	|-RVA: 0x4835458 Offset: 0x4831458 VA: 0x4835458
	|-OrderedDictionary.ReverseReader.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values>b__10_0
	*/
}

// Namespace: 
[DefaultMember("Item")]
public struct OrderedDictionary.ReverseReader<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 24229
{
	// Fields
	private OrderedDictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public static OrderedDictionary.ReverseReader<TKey, TValue> Empty { get; }
	public TValue Item { get; }
	public int Count { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static OrderedDictionary.ReverseReader<TKey, TValue> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C6A90 Offset: 0x54C2A90 VA: 0x54C6A90
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.get_Empty
	|
	|-RVA: 0x54C7200 Offset: 0x54C3200 VA: 0x54C7200
	|-OrderedDictionary.ReverseReader<EntityRef, int>.get_Empty
	|
	|-RVA: 0x54C7958 Offset: 0x54C3958 VA: 0x54C7958
	|-OrderedDictionary.ReverseReader<EntityRef, object>.get_Empty
	|
	|-RVA: 0x54C80B0 Offset: 0x54C40B0 VA: 0x54C80B0
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.get_Empty
	|
	|-RVA: 0x54C8824 Offset: 0x54C4824 VA: 0x54C8824
	|-OrderedDictionary.ReverseReader<int, BulletLink>.get_Empty
	|
	|-RVA: 0x54C8FB4 Offset: 0x54C4FB4 VA: 0x54C8FB4
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.get_Empty
	|
	|-RVA: 0x54C96F0 Offset: 0x54C56F0 VA: 0x54C96F0
	|-OrderedDictionary.ReverseReader<int, int>.get_Empty
	|
	|-RVA: 0x54C9E2C Offset: 0x54C5E2C VA: 0x54C9E2C
	|-OrderedDictionary.ReverseReader<int, object>.get_Empty
	|
	|-RVA: 0x54CA584 Offset: 0x54C6584 VA: 0x54CA584
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.get_Empty
	|
	|-RVA: 0x54CACC0 Offset: 0x54C6CC0 VA: 0x54CACC0
	|-OrderedDictionary.ReverseReader<long, object>.get_Empty
	|
	|-RVA: 0x54CB418 Offset: 0x54C7418 VA: 0x54CB418
	|-OrderedDictionary.ReverseReader<object, FP>.get_Empty
	|
	|-RVA: 0x54CBB70 Offset: 0x54C7B70 VA: 0x54CBB70
	|-OrderedDictionary.ReverseReader<object, long>.get_Empty
	|
	|-RVA: 0x54CC2C8 Offset: 0x54C82C8 VA: 0x54CC2C8
	|-OrderedDictionary.ReverseReader<object, object>.get_Empty
	|
	|-RVA: 0x54CCA20 Offset: 0x54C8A20 VA: 0x54CCA20
	|-OrderedDictionary.ReverseReader<ulong, object>.get_Empty
	|
	|-RVA: 0x54CD178 Offset: 0x54C9178 VA: 0x54CD178
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C6B2C Offset: 0x54C2B2C VA: 0x54C6B2C
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.get_Item
	|
	|-RVA: 0x54C729C Offset: 0x54C329C VA: 0x54C729C
	|-OrderedDictionary.ReverseReader<EntityRef, int>.get_Item
	|
	|-RVA: 0x54C79F4 Offset: 0x54C39F4 VA: 0x54C79F4
	|-OrderedDictionary.ReverseReader<EntityRef, object>.get_Item
	|
	|-RVA: 0x54C814C Offset: 0x54C414C VA: 0x54C814C
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.get_Item
	|
	|-RVA: 0x54C88C0 Offset: 0x54C48C0 VA: 0x54C88C0
	|-OrderedDictionary.ReverseReader<int, BulletLink>.get_Item
	|
	|-RVA: 0x54C9050 Offset: 0x54C5050 VA: 0x54C9050
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.get_Item
	|
	|-RVA: 0x54C978C Offset: 0x54C578C VA: 0x54C978C
	|-OrderedDictionary.ReverseReader<int, int>.get_Item
	|
	|-RVA: 0x54C9EC8 Offset: 0x54C5EC8 VA: 0x54C9EC8
	|-OrderedDictionary.ReverseReader<int, object>.get_Item
	|
	|-RVA: 0x54CA620 Offset: 0x54C6620 VA: 0x54CA620
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.get_Item
	|
	|-RVA: 0x54CAD5C Offset: 0x54C6D5C VA: 0x54CAD5C
	|-OrderedDictionary.ReverseReader<long, object>.get_Item
	|
	|-RVA: 0x54CB4B4 Offset: 0x54C74B4 VA: 0x54CB4B4
	|-OrderedDictionary.ReverseReader<object, FP>.get_Item
	|
	|-RVA: 0x54CBC0C Offset: 0x54C7C0C VA: 0x54CBC0C
	|-OrderedDictionary.ReverseReader<object, long>.get_Item
	|
	|-RVA: 0x54CC364 Offset: 0x54C8364 VA: 0x54CC364
	|-OrderedDictionary.ReverseReader<object, object>.get_Item
	|
	|-RVA: 0x54CCABC Offset: 0x54C8ABC VA: 0x54CCABC
	|-OrderedDictionary.ReverseReader<ulong, object>.get_Item
	|
	|-RVA: 0x54CD214 Offset: 0x54C9214 VA: 0x54CD214
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C6B78 Offset: 0x54C2B78 VA: 0x54C6B78
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.get_Count
	|
	|-RVA: 0x54C72E0 Offset: 0x54C32E0 VA: 0x54C72E0
	|-OrderedDictionary.ReverseReader<EntityRef, int>.get_Count
	|
	|-RVA: 0x54C7A38 Offset: 0x54C3A38 VA: 0x54C7A38
	|-OrderedDictionary.ReverseReader<EntityRef, object>.get_Count
	|
	|-RVA: 0x54C81AC Offset: 0x54C41AC VA: 0x54C81AC
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.get_Count
	|
	|-RVA: 0x54C8928 Offset: 0x54C4928 VA: 0x54C8928
	|-OrderedDictionary.ReverseReader<int, BulletLink>.get_Count
	|
	|-RVA: 0x54C9094 Offset: 0x54C5094 VA: 0x54C9094
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.get_Count
	|
	|-RVA: 0x54C97D0 Offset: 0x54C57D0 VA: 0x54C97D0
	|-OrderedDictionary.ReverseReader<int, int>.get_Count
	|
	|-RVA: 0x54C9F0C Offset: 0x54C5F0C VA: 0x54C9F0C
	|-OrderedDictionary.ReverseReader<int, object>.get_Count
	|
	|-RVA: 0x54CA664 Offset: 0x54C6664 VA: 0x54CA664
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.get_Count
	|
	|-RVA: 0x54CADA0 Offset: 0x54C6DA0 VA: 0x54CADA0
	|-OrderedDictionary.ReverseReader<long, object>.get_Count
	|
	|-RVA: 0x54CB4F8 Offset: 0x54C74F8 VA: 0x54CB4F8
	|-OrderedDictionary.ReverseReader<object, FP>.get_Count
	|
	|-RVA: 0x54CBC50 Offset: 0x54C7C50 VA: 0x54CBC50
	|-OrderedDictionary.ReverseReader<object, long>.get_Count
	|
	|-RVA: 0x54CC3A8 Offset: 0x54C83A8 VA: 0x54CC3A8
	|-OrderedDictionary.ReverseReader<object, object>.get_Count
	|
	|-RVA: 0x54CCB00 Offset: 0x54C8B00 VA: 0x54CCB00
	|-OrderedDictionary.ReverseReader<ulong, object>.get_Count
	|
	|-RVA: 0x54CD408 Offset: 0x54C9408 VA: 0x54CD408
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C6BAC Offset: 0x54C2BAC VA: 0x54C6BAC
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54C7314 Offset: 0x54C3314 VA: 0x54C7314
	|-OrderedDictionary.ReverseReader<EntityRef, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54C7A6C Offset: 0x54C3A6C VA: 0x54C7A6C
	|-OrderedDictionary.ReverseReader<EntityRef, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54C81E0 Offset: 0x54C41E0 VA: 0x54C81E0
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54C895C Offset: 0x54C495C VA: 0x54C895C
	|-OrderedDictionary.ReverseReader<int, BulletLink>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54C90C8 Offset: 0x54C50C8 VA: 0x54C90C8
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54C9804 Offset: 0x54C5804 VA: 0x54C9804
	|-OrderedDictionary.ReverseReader<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54C9F40 Offset: 0x54C5F40 VA: 0x54C9F40
	|-OrderedDictionary.ReverseReader<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54CA698 Offset: 0x54C6698 VA: 0x54CA698
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54CADD4 Offset: 0x54C6DD4 VA: 0x54CADD4
	|-OrderedDictionary.ReverseReader<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54CB52C Offset: 0x54C752C VA: 0x54CB52C
	|-OrderedDictionary.ReverseReader<object, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54CBC84 Offset: 0x54C7C84 VA: 0x54CBC84
	|-OrderedDictionary.ReverseReader<object, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54CC3DC Offset: 0x54C83DC VA: 0x54CC3DC
	|-OrderedDictionary.ReverseReader<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54CCB34 Offset: 0x54C8B34 VA: 0x54CCB34
	|-OrderedDictionary.ReverseReader<ulong, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x54CD488 Offset: 0x54C9488 VA: 0x54CD488
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C6DD8 Offset: 0x54C2DD8 VA: 0x54C6DD8
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54C7540 Offset: 0x54C3540 VA: 0x54C7540
	|-OrderedDictionary.ReverseReader<EntityRef, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54C7C98 Offset: 0x54C3C98 VA: 0x54C7C98
	|-OrderedDictionary.ReverseReader<EntityRef, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54C840C Offset: 0x54C440C VA: 0x54C840C
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54C8B88 Offset: 0x54C4B88 VA: 0x54C8B88
	|-OrderedDictionary.ReverseReader<int, BulletLink>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54C92F4 Offset: 0x54C52F4 VA: 0x54C92F4
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54C9A30 Offset: 0x54C5A30 VA: 0x54C9A30
	|-OrderedDictionary.ReverseReader<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54CA16C Offset: 0x54C616C VA: 0x54CA16C
	|-OrderedDictionary.ReverseReader<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54CA8C4 Offset: 0x54C68C4 VA: 0x54CA8C4
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54CB000 Offset: 0x54C7000 VA: 0x54CB000
	|-OrderedDictionary.ReverseReader<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54CB758 Offset: 0x54C7758 VA: 0x54CB758
	|-OrderedDictionary.ReverseReader<object, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54CBEB0 Offset: 0x54C7EB0 VA: 0x54CBEB0
	|-OrderedDictionary.ReverseReader<object, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54CC608 Offset: 0x54C8608 VA: 0x54CC608
	|-OrderedDictionary.ReverseReader<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54CCD60 Offset: 0x54C8D60 VA: 0x54CCD60
	|-OrderedDictionary.ReverseReader<ulong, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x54CD718 Offset: 0x54C9718 VA: 0x54CD718
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1
	public void .ctor(OrderedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C7004 Offset: 0x54C3004 VA: 0x54C7004
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x54C776C Offset: 0x54C376C VA: 0x54C776C
	|-OrderedDictionary.ReverseReader<EntityRef, int>..ctor
	|
	|-RVA: 0x54C7EC4 Offset: 0x54C3EC4 VA: 0x54C7EC4
	|-OrderedDictionary.ReverseReader<EntityRef, object>..ctor
	|
	|-RVA: 0x54C8638 Offset: 0x54C4638 VA: 0x54C8638
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x54C8DB4 Offset: 0x54C4DB4 VA: 0x54C8DB4
	|-OrderedDictionary.ReverseReader<int, BulletLink>..ctor
	|
	|-RVA: 0x54C9520 Offset: 0x54C5520 VA: 0x54C9520
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x54C9C5C Offset: 0x54C5C5C VA: 0x54C9C5C
	|-OrderedDictionary.ReverseReader<int, int>..ctor
	|
	|-RVA: 0x54CA398 Offset: 0x54C6398 VA: 0x54CA398
	|-OrderedDictionary.ReverseReader<int, object>..ctor
	|
	|-RVA: 0x54CAAF0 Offset: 0x54C6AF0 VA: 0x54CAAF0
	|-OrderedDictionary.ReverseReader<Int32Enum, int>..ctor
	|
	|-RVA: 0x54CB22C Offset: 0x54C722C VA: 0x54CB22C
	|-OrderedDictionary.ReverseReader<long, object>..ctor
	|
	|-RVA: 0x54CB984 Offset: 0x54C7984 VA: 0x54CB984
	|-OrderedDictionary.ReverseReader<object, FP>..ctor
	|
	|-RVA: 0x54CC0DC Offset: 0x54C80DC VA: 0x54CC0DC
	|-OrderedDictionary.ReverseReader<object, long>..ctor
	|
	|-RVA: 0x54CC834 Offset: 0x54C8834 VA: 0x54CC834
	|-OrderedDictionary.ReverseReader<object, object>..ctor
	|
	|-RVA: 0x54CCF8C Offset: 0x54C8F8C VA: 0x54CCF8C
	|-OrderedDictionary.ReverseReader<ulong, object>..ctor
	|
	|-RVA: 0x54CD9A8 Offset: 0x54C99A8 VA: 0x54CD9A8
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C700C Offset: 0x54C300C VA: 0x54C700C
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.ContainsKey
	|
	|-RVA: 0x54C7774 Offset: 0x54C3774 VA: 0x54C7774
	|-OrderedDictionary.ReverseReader<EntityRef, int>.ContainsKey
	|
	|-RVA: 0x54C7ECC Offset: 0x54C3ECC VA: 0x54C7ECC
	|-OrderedDictionary.ReverseReader<EntityRef, object>.ContainsKey
	|
	|-RVA: 0x54C8640 Offset: 0x54C4640 VA: 0x54C8640
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.ContainsKey
	|
	|-RVA: 0x54C8DBC Offset: 0x54C4DBC VA: 0x54C8DBC
	|-OrderedDictionary.ReverseReader<int, BulletLink>.ContainsKey
	|
	|-RVA: 0x54C9528 Offset: 0x54C5528 VA: 0x54C9528
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.ContainsKey
	|
	|-RVA: 0x54C9C64 Offset: 0x54C5C64 VA: 0x54C9C64
	|-OrderedDictionary.ReverseReader<int, int>.ContainsKey
	|
	|-RVA: 0x54CA3A0 Offset: 0x54C63A0 VA: 0x54CA3A0
	|-OrderedDictionary.ReverseReader<int, object>.ContainsKey
	|
	|-RVA: 0x54CAAF8 Offset: 0x54C6AF8 VA: 0x54CAAF8
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.ContainsKey
	|
	|-RVA: 0x54CB234 Offset: 0x54C7234 VA: 0x54CB234
	|-OrderedDictionary.ReverseReader<long, object>.ContainsKey
	|
	|-RVA: 0x54CB98C Offset: 0x54C798C VA: 0x54CB98C
	|-OrderedDictionary.ReverseReader<object, FP>.ContainsKey
	|
	|-RVA: 0x54CC0E4 Offset: 0x54C80E4 VA: 0x54CC0E4
	|-OrderedDictionary.ReverseReader<object, long>.ContainsKey
	|
	|-RVA: 0x54CC83C Offset: 0x54C883C VA: 0x54CC83C
	|-OrderedDictionary.ReverseReader<object, object>.ContainsKey
	|
	|-RVA: 0x54CCF94 Offset: 0x54C8F94 VA: 0x54CCF94
	|-OrderedDictionary.ReverseReader<ulong, object>.ContainsKey
	|
	|-RVA: 0x54CD9B0 Offset: 0x54C99B0 VA: 0x54CD9B0
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C7058 Offset: 0x54C3058 VA: 0x54C7058
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.TryGetValue
	|
	|-RVA: 0x54C77B8 Offset: 0x54C37B8 VA: 0x54C77B8
	|-OrderedDictionary.ReverseReader<EntityRef, int>.TryGetValue
	|
	|-RVA: 0x54C7F10 Offset: 0x54C3F10 VA: 0x54C7F10
	|-OrderedDictionary.ReverseReader<EntityRef, object>.TryGetValue
	|
	|-RVA: 0x54C8684 Offset: 0x54C4684 VA: 0x54C8684
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.TryGetValue
	|
	|-RVA: 0x54C8E00 Offset: 0x54C4E00 VA: 0x54C8E00
	|-OrderedDictionary.ReverseReader<int, BulletLink>.TryGetValue
	|
	|-RVA: 0x54C956C Offset: 0x54C556C VA: 0x54C956C
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.TryGetValue
	|
	|-RVA: 0x54C9CA8 Offset: 0x54C5CA8 VA: 0x54C9CA8
	|-OrderedDictionary.ReverseReader<int, int>.TryGetValue
	|
	|-RVA: 0x54CA3E4 Offset: 0x54C63E4 VA: 0x54CA3E4
	|-OrderedDictionary.ReverseReader<int, object>.TryGetValue
	|
	|-RVA: 0x54CAB3C Offset: 0x54C6B3C VA: 0x54CAB3C
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.TryGetValue
	|
	|-RVA: 0x54CB278 Offset: 0x54C7278 VA: 0x54CB278
	|-OrderedDictionary.ReverseReader<long, object>.TryGetValue
	|
	|-RVA: 0x54CB9D0 Offset: 0x54C79D0 VA: 0x54CB9D0
	|-OrderedDictionary.ReverseReader<object, FP>.TryGetValue
	|
	|-RVA: 0x54CC128 Offset: 0x54C8128 VA: 0x54CC128
	|-OrderedDictionary.ReverseReader<object, long>.TryGetValue
	|
	|-RVA: 0x54CC880 Offset: 0x54C8880 VA: 0x54CC880
	|-OrderedDictionary.ReverseReader<object, object>.TryGetValue
	|
	|-RVA: 0x54CCFD8 Offset: 0x54C8FD8 VA: 0x54CCFD8
	|-OrderedDictionary.ReverseReader<ulong, object>.TryGetValue
	|
	|-RVA: 0x54CDB4C Offset: 0x54C9B4C VA: 0x54CDB4C
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.ReverseEnumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C70B4 Offset: 0x54C30B4 VA: 0x54C70B4
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.GetEnumerator
	|
	|-RVA: 0x54C7804 Offset: 0x54C3804 VA: 0x54C7804
	|-OrderedDictionary.ReverseReader<EntityRef, int>.GetEnumerator
	|
	|-RVA: 0x54C7F5C Offset: 0x54C3F5C VA: 0x54C7F5C
	|-OrderedDictionary.ReverseReader<EntityRef, object>.GetEnumerator
	|
	|-RVA: 0x54C86D0 Offset: 0x54C46D0 VA: 0x54C86D0
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.GetEnumerator
	|
	|-RVA: 0x54C8E4C Offset: 0x54C4E4C VA: 0x54C8E4C
	|-OrderedDictionary.ReverseReader<int, BulletLink>.GetEnumerator
	|
	|-RVA: 0x54C95B8 Offset: 0x54C55B8 VA: 0x54C95B8
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.GetEnumerator
	|
	|-RVA: 0x54C9CF4 Offset: 0x54C5CF4 VA: 0x54C9CF4
	|-OrderedDictionary.ReverseReader<int, int>.GetEnumerator
	|
	|-RVA: 0x54CA430 Offset: 0x54C6430 VA: 0x54CA430
	|-OrderedDictionary.ReverseReader<int, object>.GetEnumerator
	|
	|-RVA: 0x54CAB88 Offset: 0x54C6B88 VA: 0x54CAB88
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x54CB2C4 Offset: 0x54C72C4 VA: 0x54CB2C4
	|-OrderedDictionary.ReverseReader<long, object>.GetEnumerator
	|
	|-RVA: 0x54CBA1C Offset: 0x54C7A1C VA: 0x54CBA1C
	|-OrderedDictionary.ReverseReader<object, FP>.GetEnumerator
	|
	|-RVA: 0x54CC174 Offset: 0x54C8174 VA: 0x54CC174
	|-OrderedDictionary.ReverseReader<object, long>.GetEnumerator
	|
	|-RVA: 0x54CC8CC Offset: 0x54C88CC VA: 0x54CC8CC
	|-OrderedDictionary.ReverseReader<object, object>.GetEnumerator
	|
	|-RVA: 0x54CD024 Offset: 0x54C9024 VA: 0x54CD024
	|-OrderedDictionary.ReverseReader<ulong, object>.GetEnumerator
	|
	|-RVA: 0x54CDCF4 Offset: 0x54C9CF4 VA: 0x54CDCF4
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C70F8 Offset: 0x54C30F8 VA: 0x54C70F8
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C7848 Offset: 0x54C3848 VA: 0x54C7848
	|-OrderedDictionary.ReverseReader<EntityRef, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C7FA0 Offset: 0x54C3FA0 VA: 0x54C7FA0
	|-OrderedDictionary.ReverseReader<EntityRef, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C8714 Offset: 0x54C4714 VA: 0x54C8714
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C8E94 Offset: 0x54C4E94 VA: 0x54C8E94
	|-OrderedDictionary.ReverseReader<int, BulletLink>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C95F8 Offset: 0x54C55F8 VA: 0x54C95F8
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C9D34 Offset: 0x54C5D34 VA: 0x54C9D34
	|-OrderedDictionary.ReverseReader<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54CA474 Offset: 0x54C6474 VA: 0x54CA474
	|-OrderedDictionary.ReverseReader<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54CABC8 Offset: 0x54C6BC8 VA: 0x54CABC8
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54CB308 Offset: 0x54C7308 VA: 0x54CB308
	|-OrderedDictionary.ReverseReader<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54CBA60 Offset: 0x54C7A60 VA: 0x54CBA60
	|-OrderedDictionary.ReverseReader<object, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54CC1B8 Offset: 0x54C81B8 VA: 0x54CC1B8
	|-OrderedDictionary.ReverseReader<object, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54CC910 Offset: 0x54C8910 VA: 0x54CC910
	|-OrderedDictionary.ReverseReader<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54CD068 Offset: 0x54C9068 VA: 0x54CD068
	|-OrderedDictionary.ReverseReader<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54CDDE0 Offset: 0x54C9DE0 VA: 0x54CDDE0
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C717C Offset: 0x54C317C VA: 0x54C717C
	|-OrderedDictionary.ReverseReader<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54C78D0 Offset: 0x54C38D0 VA: 0x54C78D0
	|-OrderedDictionary.ReverseReader<EntityRef, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54C8028 Offset: 0x54C4028 VA: 0x54C8028
	|-OrderedDictionary.ReverseReader<EntityRef, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54C879C Offset: 0x54C479C VA: 0x54C879C
	|-OrderedDictionary.ReverseReader<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54C8F24 Offset: 0x54C4F24 VA: 0x54C8F24
	|-OrderedDictionary.ReverseReader<int, BulletLink>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54C9674 Offset: 0x54C5674 VA: 0x54C9674
	|-OrderedDictionary.ReverseReader<int, HeroSkillCount>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54C9DB0 Offset: 0x54C5DB0 VA: 0x54C9DB0
	|-OrderedDictionary.ReverseReader<int, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54CA4FC Offset: 0x54C64FC VA: 0x54CA4FC
	|-OrderedDictionary.ReverseReader<int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54CAC44 Offset: 0x54C6C44 VA: 0x54CAC44
	|-OrderedDictionary.ReverseReader<Int32Enum, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54CB390 Offset: 0x54C7390 VA: 0x54CB390
	|-OrderedDictionary.ReverseReader<long, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54CBAE8 Offset: 0x54C7AE8 VA: 0x54CBAE8
	|-OrderedDictionary.ReverseReader<object, FP>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54CC240 Offset: 0x54C8240 VA: 0x54CC240
	|-OrderedDictionary.ReverseReader<object, long>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54CC998 Offset: 0x54C8998 VA: 0x54CC998
	|-OrderedDictionary.ReverseReader<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54CD0F0 Offset: 0x54C90F0 VA: 0x54CD0F0
	|-OrderedDictionary.ReverseReader<ulong, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x54CDF04 Offset: 0x54C9F04 VA: 0x54CDF04
	|-OrderedDictionary.ReverseReader<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/
}

// Namespace: 
[Serializable]
public struct OrderedDictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable, IDictionaryEnumerator // TypeDefIndex: 24230
{
	// Fields
	private OrderedDictionary<TKey, TValue> dictionary; // 0x0
	private int version; // 0x0
	private int index; // 0x0
	private KeyValuePair<TKey, TValue> current; // 0x0
	private int getEnumeratorRetType; // 0x0
	internal const int DictEntry = 1;
	internal const int KeyValuePair = 2;

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6115658 Offset: 0x6111658 VA: 0x6115658
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x61249A0 Offset: 0x61209A0 VA: 0x61249A0
	|-OrderedDictionary.Enumerator<EntityRef, int>..ctor
	|
	|-RVA: 0x613F8A0 Offset: 0x613B8A0 VA: 0x613F8A0
	|-OrderedDictionary.Enumerator<EntityRef, object>..ctor
	|
	|-RVA: 0x6147754 Offset: 0x6143754 VA: 0x6147754
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x6149504 Offset: 0x6145504 VA: 0x6149504
	|-OrderedDictionary.Enumerator<int, BulletLink>..ctor
	|
	|-RVA: 0x614D778 Offset: 0x6149778 VA: 0x614D778
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x614F040 Offset: 0x614B040 VA: 0x614F040
	|-OrderedDictionary.Enumerator<int, int>..ctor
	|
	|-RVA: 0x61535C0 Offset: 0x614F5C0 VA: 0x61535C0
	|-OrderedDictionary.Enumerator<int, object>..ctor
	|
	|-RVA: 0x615C97C Offset: 0x615897C VA: 0x615C97C
	|-OrderedDictionary.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x6163D78 Offset: 0x615FD78 VA: 0x6163D78
	|-OrderedDictionary.Enumerator<long, object>..ctor
	|
	|-RVA: 0x616F008 Offset: 0x616B008 VA: 0x616F008
	|-OrderedDictionary.Enumerator<object, FP>..ctor
	|
	|-RVA: 0x61711E0 Offset: 0x616D1E0 VA: 0x61711E0
	|-OrderedDictionary.Enumerator<object, long>..ctor
	|
	|-RVA: 0x6172788 Offset: 0x616E788 VA: 0x6172788
	|-OrderedDictionary.Enumerator<object, object>..ctor
	|
	|-RVA: 0x618C674 Offset: 0x6188674 VA: 0x618C674
	|-OrderedDictionary.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x618FA88 Offset: 0x618BA88 VA: 0x618FA88
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType, int startingIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x611569C Offset: 0x611169C VA: 0x611569C
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x61249E0 Offset: 0x61209E0 VA: 0x61249E0
	|-OrderedDictionary.Enumerator<EntityRef, int>..ctor
	|
	|-RVA: 0x613F8E0 Offset: 0x613B8E0 VA: 0x613F8E0
	|-OrderedDictionary.Enumerator<EntityRef, object>..ctor
	|
	|-RVA: 0x614779C Offset: 0x614379C VA: 0x614779C
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x614954C Offset: 0x614554C VA: 0x614954C
	|-OrderedDictionary.Enumerator<int, BulletLink>..ctor
	|
	|-RVA: 0x614D7B8 Offset: 0x61497B8 VA: 0x614D7B8
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x614F080 Offset: 0x614B080 VA: 0x614F080
	|-OrderedDictionary.Enumerator<int, int>..ctor
	|
	|-RVA: 0x6153600 Offset: 0x614F600 VA: 0x6153600
	|-OrderedDictionary.Enumerator<int, object>..ctor
	|
	|-RVA: 0x615C9BC Offset: 0x61589BC VA: 0x615C9BC
	|-OrderedDictionary.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x6163DB8 Offset: 0x615FDB8 VA: 0x6163DB8
	|-OrderedDictionary.Enumerator<long, object>..ctor
	|
	|-RVA: 0x616F048 Offset: 0x616B048 VA: 0x616F048
	|-OrderedDictionary.Enumerator<object, FP>..ctor
	|
	|-RVA: 0x6171220 Offset: 0x616D220 VA: 0x6171220
	|-OrderedDictionary.Enumerator<object, long>..ctor
	|
	|-RVA: 0x61727C8 Offset: 0x616E7C8 VA: 0x61727C8
	|-OrderedDictionary.Enumerator<object, object>..ctor
	|
	|-RVA: 0x618C6B4 Offset: 0x61886B4 VA: 0x618C6B4
	|-OrderedDictionary.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x618FBE0 Offset: 0x618BBE0 VA: 0x618FBE0
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61156EC Offset: 0x61116EC VA: 0x61156EC
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>.MoveNext
	|
	|-RVA: 0x6124A2C Offset: 0x6120A2C VA: 0x6124A2C
	|-OrderedDictionary.Enumerator<EntityRef, int>.MoveNext
	|
	|-RVA: 0x613F92C Offset: 0x613B92C VA: 0x613F92C
	|-OrderedDictionary.Enumerator<EntityRef, object>.MoveNext
	|
	|-RVA: 0x61477F0 Offset: 0x61437F0 VA: 0x61477F0
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>.MoveNext
	|
	|-RVA: 0x61495A0 Offset: 0x61455A0 VA: 0x61495A0
	|-OrderedDictionary.Enumerator<int, BulletLink>.MoveNext
	|
	|-RVA: 0x614D804 Offset: 0x6149804 VA: 0x614D804
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>.MoveNext
	|
	|-RVA: 0x614F0CC Offset: 0x614B0CC VA: 0x614F0CC
	|-OrderedDictionary.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x615364C Offset: 0x614F64C VA: 0x615364C
	|-OrderedDictionary.Enumerator<int, object>.MoveNext
	|
	|-RVA: 0x615CA08 Offset: 0x6158A08 VA: 0x615CA08
	|-OrderedDictionary.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x6163E04 Offset: 0x615FE04 VA: 0x6163E04
	|-OrderedDictionary.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x616F094 Offset: 0x616B094 VA: 0x616F094
	|-OrderedDictionary.Enumerator<object, FP>.MoveNext
	|
	|-RVA: 0x617126C Offset: 0x616D26C VA: 0x617126C
	|-OrderedDictionary.Enumerator<object, long>.MoveNext
	|
	|-RVA: 0x6172814 Offset: 0x616E814 VA: 0x6172814
	|-OrderedDictionary.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x618C700 Offset: 0x6188700 VA: 0x618C700
	|-OrderedDictionary.Enumerator<ulong, object>.MoveNext
	|
	|-RVA: 0x618FD38 Offset: 0x618BD38 VA: 0x618FD38
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6115840 Offset: 0x6111840 VA: 0x6115840
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>.get_Current
	|
	|-RVA: 0x6124B58 Offset: 0x6120B58 VA: 0x6124B58
	|-OrderedDictionary.Enumerator<EntityRef, int>.get_Current
	|
	|-RVA: 0x613FA60 Offset: 0x613BA60 VA: 0x613FA60
	|-OrderedDictionary.Enumerator<EntityRef, object>.get_Current
	|
	|-RVA: 0x614794C Offset: 0x614394C VA: 0x614794C
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>.get_Current
	|
	|-RVA: 0x61496FC Offset: 0x61456FC VA: 0x61496FC
	|-OrderedDictionary.Enumerator<int, BulletLink>.get_Current
	|
	|-RVA: 0x614D948 Offset: 0x6149948 VA: 0x614D948
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>.get_Current
	|
	|-RVA: 0x614F1F4 Offset: 0x614B1F4 VA: 0x614F1F4
	|-OrderedDictionary.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x6153784 Offset: 0x614F784 VA: 0x6153784
	|-OrderedDictionary.Enumerator<int, object>.get_Current
	|
	|-RVA: 0x615CB30 Offset: 0x6158B30 VA: 0x615CB30
	|-OrderedDictionary.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x6163F38 Offset: 0x615FF38 VA: 0x6163F38
	|-OrderedDictionary.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x616F1C8 Offset: 0x616B1C8 VA: 0x616F1C8
	|-OrderedDictionary.Enumerator<object, FP>.get_Current
	|
	|-RVA: 0x61713A0 Offset: 0x616D3A0 VA: 0x61713A0
	|-OrderedDictionary.Enumerator<object, long>.get_Current
	|
	|-RVA: 0x6172948 Offset: 0x616E948 VA: 0x6172948
	|-OrderedDictionary.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x618C834 Offset: 0x6188834 VA: 0x618C834
	|-OrderedDictionary.Enumerator<ulong, object>.get_Current
	|
	|-RVA: 0x61902F0 Offset: 0x618C2F0 VA: 0x61902F0
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6115854 Offset: 0x6111854 VA: 0x6115854
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>.Dispose
	|
	|-RVA: 0x6124B64 Offset: 0x6120B64 VA: 0x6124B64
	|-OrderedDictionary.Enumerator<EntityRef, int>.Dispose
	|
	|-RVA: 0x613FA6C Offset: 0x613BA6C VA: 0x613FA6C
	|-OrderedDictionary.Enumerator<EntityRef, object>.Dispose
	|
	|-RVA: 0x6147960 Offset: 0x6143960 VA: 0x6147960
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>.Dispose
	|
	|-RVA: 0x6149710 Offset: 0x6145710 VA: 0x6149710
	|-OrderedDictionary.Enumerator<int, BulletLink>.Dispose
	|
	|-RVA: 0x614D958 Offset: 0x6149958 VA: 0x614D958
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>.Dispose
	|
	|-RVA: 0x614F1FC Offset: 0x614B1FC VA: 0x614F1FC
	|-OrderedDictionary.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x6153790 Offset: 0x614F790 VA: 0x6153790
	|-OrderedDictionary.Enumerator<int, object>.Dispose
	|
	|-RVA: 0x615CB38 Offset: 0x6158B38 VA: 0x615CB38
	|-OrderedDictionary.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x6163F44 Offset: 0x615FF44 VA: 0x6163F44
	|-OrderedDictionary.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x616F1D4 Offset: 0x616B1D4 VA: 0x616F1D4
	|-OrderedDictionary.Enumerator<object, FP>.Dispose
	|
	|-RVA: 0x61713AC Offset: 0x616D3AC VA: 0x61713AC
	|-OrderedDictionary.Enumerator<object, long>.Dispose
	|
	|-RVA: 0x6172954 Offset: 0x616E954 VA: 0x6172954
	|-OrderedDictionary.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x618C840 Offset: 0x6188840 VA: 0x618C840
	|-OrderedDictionary.Enumerator<ulong, object>.Dispose
	|
	|-RVA: 0x61903E0 Offset: 0x618C3E0 VA: 0x61903E0
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6115858 Offset: 0x6111858 VA: 0x6115858
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6124B68 Offset: 0x6120B68 VA: 0x6124B68
	|-OrderedDictionary.Enumerator<EntityRef, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x613FA70 Offset: 0x613BA70 VA: 0x613FA70
	|-OrderedDictionary.Enumerator<EntityRef, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6147964 Offset: 0x6143964 VA: 0x6147964
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6149714 Offset: 0x6145714 VA: 0x6149714
	|-OrderedDictionary.Enumerator<int, BulletLink>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x614D95C Offset: 0x614995C VA: 0x614D95C
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x614F200 Offset: 0x614B200 VA: 0x614F200
	|-OrderedDictionary.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6153794 Offset: 0x614F794 VA: 0x6153794
	|-OrderedDictionary.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x615CB3C Offset: 0x6158B3C VA: 0x615CB3C
	|-OrderedDictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6163F48 Offset: 0x615FF48 VA: 0x6163F48
	|-OrderedDictionary.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x616F1D8 Offset: 0x616B1D8 VA: 0x616F1D8
	|-OrderedDictionary.Enumerator<object, FP>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x61713B0 Offset: 0x616D3B0 VA: 0x61713B0
	|-OrderedDictionary.Enumerator<object, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6172958 Offset: 0x616E958 VA: 0x6172958
	|-OrderedDictionary.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x618C844 Offset: 0x6188844 VA: 0x618C844
	|-OrderedDictionary.Enumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x61903E4 Offset: 0x618C3E4 VA: 0x61903E4
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61159FC Offset: 0x61119FC VA: 0x61159FC
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6124D04 Offset: 0x6120D04 VA: 0x6124D04
	|-OrderedDictionary.Enumerator<EntityRef, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x613FBD4 Offset: 0x613BBD4 VA: 0x613FBD4
	|-OrderedDictionary.Enumerator<EntityRef, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6147B0C Offset: 0x6143B0C VA: 0x6147B0C
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x61498C4 Offset: 0x61458C4 VA: 0x61498C4
	|-OrderedDictionary.Enumerator<int, BulletLink>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x614DB00 Offset: 0x6149B00 VA: 0x614DB00
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x614F39C Offset: 0x614B39C VA: 0x614F39C
	|-OrderedDictionary.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x61538F8 Offset: 0x614F8F8 VA: 0x61538F8
	|-OrderedDictionary.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x615CCD8 Offset: 0x6158CD8 VA: 0x615CCD8
	|-OrderedDictionary.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x61640AC Offset: 0x61600AC VA: 0x61640AC
	|-OrderedDictionary.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x616F33C Offset: 0x616B33C VA: 0x616F33C
	|-OrderedDictionary.Enumerator<object, FP>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6171514 Offset: 0x616D514 VA: 0x6171514
	|-OrderedDictionary.Enumerator<object, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6172A90 Offset: 0x616EA90 VA: 0x6172A90
	|-OrderedDictionary.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x618C9A8 Offset: 0x61889A8 VA: 0x618C9A8
	|-OrderedDictionary.Enumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6190840 Offset: 0x618C840 VA: 0x6190840
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6115A7C Offset: 0x6111A7C VA: 0x6115A7C
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x6124D80 Offset: 0x6120D80 VA: 0x6124D80
	|-OrderedDictionary.Enumerator<EntityRef, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x613FC50 Offset: 0x613BC50 VA: 0x613FC50
	|-OrderedDictionary.Enumerator<EntityRef, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x6147B90 Offset: 0x6143B90 VA: 0x6147B90
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x6149948 Offset: 0x6145948 VA: 0x6149948
	|-OrderedDictionary.Enumerator<int, BulletLink>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x614DB80 Offset: 0x6149B80 VA: 0x614DB80
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x614F418 Offset: 0x614B418 VA: 0x614F418
	|-OrderedDictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x6153974 Offset: 0x614F974 VA: 0x6153974
	|-OrderedDictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x615CD54 Offset: 0x6158D54 VA: 0x615CD54
	|-OrderedDictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x6164128 Offset: 0x6160128 VA: 0x6164128
	|-OrderedDictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x616F3B8 Offset: 0x616B3B8 VA: 0x616F3B8
	|-OrderedDictionary.Enumerator<object, FP>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x6171590 Offset: 0x616D590 VA: 0x6171590
	|-OrderedDictionary.Enumerator<object, long>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x6172B0C Offset: 0x616EB0C VA: 0x6172B0C
	|-OrderedDictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x618CA24 Offset: 0x6188A24 VA: 0x618CA24
	|-OrderedDictionary.Enumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x61909D0 Offset: 0x618C9D0 VA: 0x61909D0
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6115BAC Offset: 0x6111BAC VA: 0x6115BAC
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x6124EB0 Offset: 0x6120EB0 VA: 0x6124EB0
	|-OrderedDictionary.Enumerator<EntityRef, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x613FD48 Offset: 0x613BD48 VA: 0x613FD48
	|-OrderedDictionary.Enumerator<EntityRef, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x6147CC4 Offset: 0x6143CC4 VA: 0x6147CC4
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x6149A84 Offset: 0x6145A84 VA: 0x6149A84
	|-OrderedDictionary.Enumerator<int, BulletLink>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x614DCB0 Offset: 0x6149CB0 VA: 0x614DCB0
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x614F548 Offset: 0x614B548 VA: 0x614F548
	|-OrderedDictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x6153A6C Offset: 0x614FA6C VA: 0x6153A6C
	|-OrderedDictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x615CE84 Offset: 0x6158E84 VA: 0x615CE84
	|-OrderedDictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x6164220 Offset: 0x6160220 VA: 0x6164220
	|-OrderedDictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x616F4B0 Offset: 0x616B4B0 VA: 0x616F4B0
	|-OrderedDictionary.Enumerator<object, FP>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x6171688 Offset: 0x616D688 VA: 0x6171688
	|-OrderedDictionary.Enumerator<object, long>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x6172BD8 Offset: 0x616EBD8 VA: 0x6172BD8
	|-OrderedDictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x618CB1C Offset: 0x6188B1C VA: 0x618CB1C
	|-OrderedDictionary.Enumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x6190D48 Offset: 0x618CD48 VA: 0x6190D48
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6115C70 Offset: 0x6111C70 VA: 0x6115C70
	|-OrderedDictionary.Enumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x6124F6C Offset: 0x6120F6C VA: 0x6124F6C
	|-OrderedDictionary.Enumerator<EntityRef, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x613FE04 Offset: 0x613BE04 VA: 0x613FE04
	|-OrderedDictionary.Enumerator<EntityRef, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x6147D80 Offset: 0x6143D80 VA: 0x6147D80
	|-OrderedDictionary.Enumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x6149B40 Offset: 0x6145B40 VA: 0x6149B40
	|-OrderedDictionary.Enumerator<int, BulletLink>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x614DD6C Offset: 0x6149D6C VA: 0x614DD6C
	|-OrderedDictionary.Enumerator<int, HeroSkillCount>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x614F604 Offset: 0x614B604 VA: 0x614F604
	|-OrderedDictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x6153B28 Offset: 0x614FB28 VA: 0x6153B28
	|-OrderedDictionary.Enumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x615CF40 Offset: 0x6158F40 VA: 0x615CF40
	|-OrderedDictionary.Enumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x61642DC Offset: 0x61602DC VA: 0x61642DC
	|-OrderedDictionary.Enumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x616F540 Offset: 0x616B540 VA: 0x616F540
	|-OrderedDictionary.Enumerator<object, FP>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x6171718 Offset: 0x616D718 VA: 0x6171718
	|-OrderedDictionary.Enumerator<object, long>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x6172C68 Offset: 0x616EC68 VA: 0x6172C68
	|-OrderedDictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x618CBD8 Offset: 0x6188BD8 VA: 0x618CBD8
	|-OrderedDictionary.Enumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x6190F90 Offset: 0x618CF90 VA: 0x6190F90
	|-OrderedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Value
	*/
}

// Namespace: 
[Serializable]
public struct OrderedDictionary.ReverseEnumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable, IDictionaryEnumerator // TypeDefIndex: 24231
{
	// Fields
	private OrderedDictionary<TKey, TValue> dictionary; // 0x0
	private int version; // 0x0
	private int index; // 0x0
	private KeyValuePair<TKey, TValue> current; // 0x0
	private int getEnumeratorRetType; // 0x0
	internal const int DictEntry = 1;
	internal const int KeyValuePair = 2;

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BDE10 Offset: 0x54B9E10 VA: 0x54BDE10
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x54BE4EC Offset: 0x54BA4EC VA: 0x54BE4EC
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>..ctor
	|
	|-RVA: 0x54BEB7C Offset: 0x54BAB7C VA: 0x54BEB7C
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>..ctor
	|
	|-RVA: 0x54BF178 Offset: 0x54BB178 VA: 0x54BF178
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x54BF874 Offset: 0x54BB874 VA: 0x54BF874
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>..ctor
	|
	|-RVA: 0x54BFF88 Offset: 0x54BBF88 VA: 0x54BFF88
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x54C0640 Offset: 0x54BC640 VA: 0x54C0640
	|-OrderedDictionary.ReverseEnumerator<int, int>..ctor
	|
	|-RVA: 0x54C0CC8 Offset: 0x54BCCC8 VA: 0x54C0CC8
	|-OrderedDictionary.ReverseEnumerator<int, object>..ctor
	|
	|-RVA: 0x54C12C8 Offset: 0x54BD2C8 VA: 0x54C12C8
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x54C1950 Offset: 0x54BD950 VA: 0x54C1950
	|-OrderedDictionary.ReverseEnumerator<long, object>..ctor
	|
	|-RVA: 0x54C1F4C Offset: 0x54BDF4C VA: 0x54C1F4C
	|-OrderedDictionary.ReverseEnumerator<object, FP>..ctor
	|
	|-RVA: 0x54C2548 Offset: 0x54BE548 VA: 0x54C2548
	|-OrderedDictionary.ReverseEnumerator<object, long>..ctor
	|
	|-RVA: 0x54C2B44 Offset: 0x54BEB44 VA: 0x54C2B44
	|-OrderedDictionary.ReverseEnumerator<object, object>..ctor
	|
	|-RVA: 0x54C30BC Offset: 0x54BF0BC VA: 0x54C30BC
	|-OrderedDictionary.ReverseEnumerator<ulong, object>..ctor
	|
	|-RVA: 0x54C36B8 Offset: 0x54BF6B8 VA: 0x54C36B8
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType, int startingIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BDE5C Offset: 0x54B9E5C VA: 0x54BDE5C
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x54BE534 Offset: 0x54BA534 VA: 0x54BE534
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>..ctor
	|
	|-RVA: 0x54BEBC4 Offset: 0x54BABC4 VA: 0x54BEBC4
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>..ctor
	|
	|-RVA: 0x54BF1C8 Offset: 0x54BB1C8 VA: 0x54BF1C8
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x54BF8C4 Offset: 0x54BB8C4 VA: 0x54BF8C4
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>..ctor
	|
	|-RVA: 0x54BFFD0 Offset: 0x54BBFD0 VA: 0x54BFFD0
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x54C0688 Offset: 0x54BC688 VA: 0x54C0688
	|-OrderedDictionary.ReverseEnumerator<int, int>..ctor
	|
	|-RVA: 0x54C0D10 Offset: 0x54BCD10 VA: 0x54C0D10
	|-OrderedDictionary.ReverseEnumerator<int, object>..ctor
	|
	|-RVA: 0x54C1310 Offset: 0x54BD310 VA: 0x54C1310
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x54C1998 Offset: 0x54BD998 VA: 0x54C1998
	|-OrderedDictionary.ReverseEnumerator<long, object>..ctor
	|
	|-RVA: 0x54C1F94 Offset: 0x54BDF94 VA: 0x54C1F94
	|-OrderedDictionary.ReverseEnumerator<object, FP>..ctor
	|
	|-RVA: 0x54C2590 Offset: 0x54BE590 VA: 0x54C2590
	|-OrderedDictionary.ReverseEnumerator<object, long>..ctor
	|
	|-RVA: 0x54C2B8C Offset: 0x54BEB8C VA: 0x54C2B8C
	|-OrderedDictionary.ReverseEnumerator<object, object>..ctor
	|
	|-RVA: 0x54C3104 Offset: 0x54BF104 VA: 0x54C3104
	|-OrderedDictionary.ReverseEnumerator<ulong, object>..ctor
	|
	|-RVA: 0x54C3810 Offset: 0x54BF810 VA: 0x54C3810
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BDEAC Offset: 0x54B9EAC VA: 0x54BDEAC
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>.MoveNext
	|
	|-RVA: 0x54BE580 Offset: 0x54BA580 VA: 0x54BE580
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>.MoveNext
	|
	|-RVA: 0x54BEC10 Offset: 0x54BAC10 VA: 0x54BEC10
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>.MoveNext
	|
	|-RVA: 0x54BF21C Offset: 0x54BB21C VA: 0x54BF21C
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>.MoveNext
	|
	|-RVA: 0x54BF918 Offset: 0x54BB918 VA: 0x54BF918
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>.MoveNext
	|
	|-RVA: 0x54C001C Offset: 0x54BC01C VA: 0x54C001C
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>.MoveNext
	|
	|-RVA: 0x54C06D4 Offset: 0x54BC6D4 VA: 0x54C06D4
	|-OrderedDictionary.ReverseEnumerator<int, int>.MoveNext
	|
	|-RVA: 0x54C0D5C Offset: 0x54BCD5C VA: 0x54C0D5C
	|-OrderedDictionary.ReverseEnumerator<int, object>.MoveNext
	|
	|-RVA: 0x54C135C Offset: 0x54BD35C VA: 0x54C135C
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x54C19E4 Offset: 0x54BD9E4 VA: 0x54C19E4
	|-OrderedDictionary.ReverseEnumerator<long, object>.MoveNext
	|
	|-RVA: 0x54C1FE0 Offset: 0x54BDFE0 VA: 0x54C1FE0
	|-OrderedDictionary.ReverseEnumerator<object, FP>.MoveNext
	|
	|-RVA: 0x54C25DC Offset: 0x54BE5DC VA: 0x54C25DC
	|-OrderedDictionary.ReverseEnumerator<object, long>.MoveNext
	|
	|-RVA: 0x54C2BD8 Offset: 0x54BEBD8 VA: 0x54C2BD8
	|-OrderedDictionary.ReverseEnumerator<object, object>.MoveNext
	|
	|-RVA: 0x54C3150 Offset: 0x54BF150 VA: 0x54C3150
	|-OrderedDictionary.ReverseEnumerator<ulong, object>.MoveNext
	|
	|-RVA: 0x54C3968 Offset: 0x54BF968 VA: 0x54C3968
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BE000 Offset: 0x54BA000 VA: 0x54BE000
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>.get_Current
	|
	|-RVA: 0x54BE6AC Offset: 0x54BA6AC VA: 0x54BE6AC
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>.get_Current
	|
	|-RVA: 0x54BED44 Offset: 0x54BAD44 VA: 0x54BED44
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>.get_Current
	|
	|-RVA: 0x54BF378 Offset: 0x54BB378 VA: 0x54BF378
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>.get_Current
	|
	|-RVA: 0x54BFA74 Offset: 0x54BBA74 VA: 0x54BFA74
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>.get_Current
	|
	|-RVA: 0x54C0160 Offset: 0x54BC160 VA: 0x54C0160
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>.get_Current
	|
	|-RVA: 0x54C07FC Offset: 0x54BC7FC VA: 0x54C07FC
	|-OrderedDictionary.ReverseEnumerator<int, int>.get_Current
	|
	|-RVA: 0x54C0E94 Offset: 0x54BCE94 VA: 0x54C0E94
	|-OrderedDictionary.ReverseEnumerator<int, object>.get_Current
	|
	|-RVA: 0x54C1484 Offset: 0x54BD484 VA: 0x54C1484
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x54C1B18 Offset: 0x54BDB18 VA: 0x54C1B18
	|-OrderedDictionary.ReverseEnumerator<long, object>.get_Current
	|
	|-RVA: 0x54C2114 Offset: 0x54BE114 VA: 0x54C2114
	|-OrderedDictionary.ReverseEnumerator<object, FP>.get_Current
	|
	|-RVA: 0x54C2710 Offset: 0x54BE710 VA: 0x54C2710
	|-OrderedDictionary.ReverseEnumerator<object, long>.get_Current
	|
	|-RVA: 0x54C2D0C Offset: 0x54BED0C VA: 0x54C2D0C
	|-OrderedDictionary.ReverseEnumerator<object, object>.get_Current
	|
	|-RVA: 0x54C3284 Offset: 0x54BF284 VA: 0x54C3284
	|-OrderedDictionary.ReverseEnumerator<ulong, object>.get_Current
	|
	|-RVA: 0x54C3F20 Offset: 0x54BFF20 VA: 0x54C3F20
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BE014 Offset: 0x54BA014 VA: 0x54BE014
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>.Dispose
	|
	|-RVA: 0x54BE6B8 Offset: 0x54BA6B8 VA: 0x54BE6B8
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>.Dispose
	|
	|-RVA: 0x54BED50 Offset: 0x54BAD50 VA: 0x54BED50
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>.Dispose
	|
	|-RVA: 0x54BF38C Offset: 0x54BB38C VA: 0x54BF38C
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>.Dispose
	|
	|-RVA: 0x54BFA88 Offset: 0x54BBA88 VA: 0x54BFA88
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>.Dispose
	|
	|-RVA: 0x54C0170 Offset: 0x54BC170 VA: 0x54C0170
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>.Dispose
	|
	|-RVA: 0x54C0804 Offset: 0x54BC804 VA: 0x54C0804
	|-OrderedDictionary.ReverseEnumerator<int, int>.Dispose
	|
	|-RVA: 0x54C0EA0 Offset: 0x54BCEA0 VA: 0x54C0EA0
	|-OrderedDictionary.ReverseEnumerator<int, object>.Dispose
	|
	|-RVA: 0x54C148C Offset: 0x54BD48C VA: 0x54C148C
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x54C1B24 Offset: 0x54BDB24 VA: 0x54C1B24
	|-OrderedDictionary.ReverseEnumerator<long, object>.Dispose
	|
	|-RVA: 0x54C2120 Offset: 0x54BE120 VA: 0x54C2120
	|-OrderedDictionary.ReverseEnumerator<object, FP>.Dispose
	|
	|-RVA: 0x54C271C Offset: 0x54BE71C VA: 0x54C271C
	|-OrderedDictionary.ReverseEnumerator<object, long>.Dispose
	|
	|-RVA: 0x54C2D18 Offset: 0x54BED18 VA: 0x54C2D18
	|-OrderedDictionary.ReverseEnumerator<object, object>.Dispose
	|
	|-RVA: 0x54C3290 Offset: 0x54BF290 VA: 0x54C3290
	|-OrderedDictionary.ReverseEnumerator<ulong, object>.Dispose
	|
	|-RVA: 0x54C4010 Offset: 0x54C0010 VA: 0x54C4010
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BE018 Offset: 0x54BA018 VA: 0x54BE018
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54BE6BC Offset: 0x54BA6BC VA: 0x54BE6BC
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54BED54 Offset: 0x54BAD54 VA: 0x54BED54
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54BF390 Offset: 0x54BB390 VA: 0x54BF390
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54BFA8C Offset: 0x54BBA8C VA: 0x54BFA8C
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C0174 Offset: 0x54BC174 VA: 0x54C0174
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C0808 Offset: 0x54BC808 VA: 0x54C0808
	|-OrderedDictionary.ReverseEnumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C0EA4 Offset: 0x54BCEA4 VA: 0x54C0EA4
	|-OrderedDictionary.ReverseEnumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C1490 Offset: 0x54BD490 VA: 0x54C1490
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C1B28 Offset: 0x54BDB28 VA: 0x54C1B28
	|-OrderedDictionary.ReverseEnumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C2124 Offset: 0x54BE124 VA: 0x54C2124
	|-OrderedDictionary.ReverseEnumerator<object, FP>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C2720 Offset: 0x54BE720 VA: 0x54C2720
	|-OrderedDictionary.ReverseEnumerator<object, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C2D1C Offset: 0x54BED1C VA: 0x54C2D1C
	|-OrderedDictionary.ReverseEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C3294 Offset: 0x54BF294 VA: 0x54C3294
	|-OrderedDictionary.ReverseEnumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54C4014 Offset: 0x54C0014 VA: 0x54C4014
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BE1BC Offset: 0x54BA1BC VA: 0x54BE1BC
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54BE858 Offset: 0x54BA858 VA: 0x54BE858
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54BEEB8 Offset: 0x54BAEB8 VA: 0x54BEEB8
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54BF538 Offset: 0x54BB538 VA: 0x54BF538
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54BFC3C Offset: 0x54BBC3C VA: 0x54BFC3C
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C0318 Offset: 0x54BC318 VA: 0x54C0318
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C09A4 Offset: 0x54BC9A4 VA: 0x54C09A4
	|-OrderedDictionary.ReverseEnumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C1008 Offset: 0x54BD008 VA: 0x54C1008
	|-OrderedDictionary.ReverseEnumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C162C Offset: 0x54BD62C VA: 0x54C162C
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C1C8C Offset: 0x54BDC8C VA: 0x54C1C8C
	|-OrderedDictionary.ReverseEnumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C2288 Offset: 0x54BE288 VA: 0x54C2288
	|-OrderedDictionary.ReverseEnumerator<object, FP>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C2884 Offset: 0x54BE884 VA: 0x54C2884
	|-OrderedDictionary.ReverseEnumerator<object, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C2E54 Offset: 0x54BEE54 VA: 0x54C2E54
	|-OrderedDictionary.ReverseEnumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C33F8 Offset: 0x54BF3F8 VA: 0x54C33F8
	|-OrderedDictionary.ReverseEnumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54C4470 Offset: 0x54C0470 VA: 0x54C4470
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BE23C Offset: 0x54BA23C VA: 0x54BE23C
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54BE8D4 Offset: 0x54BA8D4 VA: 0x54BE8D4
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54BEF34 Offset: 0x54BAF34 VA: 0x54BEF34
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54BF5BC Offset: 0x54BB5BC VA: 0x54BF5BC
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54BFCC0 Offset: 0x54BBCC0 VA: 0x54BFCC0
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C0398 Offset: 0x54BC398 VA: 0x54C0398
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C0A20 Offset: 0x54BCA20 VA: 0x54C0A20
	|-OrderedDictionary.ReverseEnumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C1084 Offset: 0x54BD084 VA: 0x54C1084
	|-OrderedDictionary.ReverseEnumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C16A8 Offset: 0x54BD6A8 VA: 0x54C16A8
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C1D08 Offset: 0x54BDD08 VA: 0x54C1D08
	|-OrderedDictionary.ReverseEnumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C2304 Offset: 0x54BE304 VA: 0x54C2304
	|-OrderedDictionary.ReverseEnumerator<object, FP>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C2900 Offset: 0x54BE900 VA: 0x54C2900
	|-OrderedDictionary.ReverseEnumerator<object, long>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C2ED0 Offset: 0x54BEED0 VA: 0x54C2ED0
	|-OrderedDictionary.ReverseEnumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C3474 Offset: 0x54BF474 VA: 0x54C3474
	|-OrderedDictionary.ReverseEnumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x54C4600 Offset: 0x54C0600 VA: 0x54C4600
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BE36C Offset: 0x54BA36C VA: 0x54BE36C
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54BEA04 Offset: 0x54BAA04 VA: 0x54BEA04
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54BF02C Offset: 0x54BB02C VA: 0x54BF02C
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54BF6F0 Offset: 0x54BB6F0 VA: 0x54BF6F0
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54BFDFC Offset: 0x54BBDFC VA: 0x54BFDFC
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C04C8 Offset: 0x54BC4C8 VA: 0x54C04C8
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C0B50 Offset: 0x54BCB50 VA: 0x54C0B50
	|-OrderedDictionary.ReverseEnumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C117C Offset: 0x54BD17C VA: 0x54C117C
	|-OrderedDictionary.ReverseEnumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C17D8 Offset: 0x54BD7D8 VA: 0x54C17D8
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C1E00 Offset: 0x54BDE00 VA: 0x54C1E00
	|-OrderedDictionary.ReverseEnumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C23FC Offset: 0x54BE3FC VA: 0x54C23FC
	|-OrderedDictionary.ReverseEnumerator<object, FP>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C29F8 Offset: 0x54BE9F8 VA: 0x54C29F8
	|-OrderedDictionary.ReverseEnumerator<object, long>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C2F9C Offset: 0x54BEF9C VA: 0x54C2F9C
	|-OrderedDictionary.ReverseEnumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C356C Offset: 0x54BF56C VA: 0x54C356C
	|-OrderedDictionary.ReverseEnumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x54C4978 Offset: 0x54C0978 VA: 0x54C4978
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BE430 Offset: 0x54BA430 VA: 0x54BE430
	|-OrderedDictionary.ReverseEnumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54BEAC0 Offset: 0x54BAAC0 VA: 0x54BEAC0
	|-OrderedDictionary.ReverseEnumerator<EntityRef, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54BF0E8 Offset: 0x54BB0E8 VA: 0x54BF0E8
	|-OrderedDictionary.ReverseEnumerator<EntityRef, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54BF7AC Offset: 0x54BB7AC VA: 0x54BF7AC
	|-OrderedDictionary.ReverseEnumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54BFEB8 Offset: 0x54BBEB8 VA: 0x54BFEB8
	|-OrderedDictionary.ReverseEnumerator<int, BulletLink>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C0584 Offset: 0x54BC584 VA: 0x54C0584
	|-OrderedDictionary.ReverseEnumerator<int, HeroSkillCount>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C0C0C Offset: 0x54BCC0C VA: 0x54C0C0C
	|-OrderedDictionary.ReverseEnumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C1238 Offset: 0x54BD238 VA: 0x54C1238
	|-OrderedDictionary.ReverseEnumerator<int, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C1894 Offset: 0x54BD894 VA: 0x54C1894
	|-OrderedDictionary.ReverseEnumerator<Int32Enum, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C1EBC Offset: 0x54BDEBC VA: 0x54C1EBC
	|-OrderedDictionary.ReverseEnumerator<long, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C248C Offset: 0x54BE48C VA: 0x54C248C
	|-OrderedDictionary.ReverseEnumerator<object, FP>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C2A88 Offset: 0x54BEA88 VA: 0x54C2A88
	|-OrderedDictionary.ReverseEnumerator<object, long>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C302C Offset: 0x54BF02C VA: 0x54C302C
	|-OrderedDictionary.ReverseEnumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C3628 Offset: 0x54BF628 VA: 0x54C3628
	|-OrderedDictionary.ReverseEnumerator<ulong, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x54C4BC0 Offset: 0x54C0BC0 VA: 0x54C4BC0
	|-OrderedDictionary.ReverseEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Value
	*/
}

// Namespace: 
[Serializable]
public struct OrderedDictionary.KeyCollection.Enumerator<TKey, TValue> : IEnumerator<TKey>, IEnumerator, IDisposable // TypeDefIndex: 24232
{
	// Fields
	private OrderedDictionary<TKey, TValue> dictionary; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private TKey currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x611607C Offset: 0x611207C VA: 0x611607C
	|-OrderedDictionary.KeyCollection.Enumerator<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x6125370 Offset: 0x6121370 VA: 0x6125370
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, int>..ctor
	|
	|-RVA: 0x61401BC Offset: 0x613C1BC VA: 0x61401BC
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, object>..ctor
	|
	|-RVA: 0x6147E48 Offset: 0x6143E48 VA: 0x6147E48
	|-OrderedDictionary.KeyCollection.Enumerator<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x6149C10 Offset: 0x6145C10 VA: 0x6149C10
	|-OrderedDictionary.KeyCollection.Enumerator<int, BulletLink>..ctor
	|
	|-RVA: 0x614DE28 Offset: 0x6149E28 VA: 0x614DE28
	|-OrderedDictionary.KeyCollection.Enumerator<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x61502E0 Offset: 0x614C2E0 VA: 0x61502E0
	|-OrderedDictionary.KeyCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x6154718 Offset: 0x6150718 VA: 0x6154718
	|-OrderedDictionary.KeyCollection.Enumerator<int, object>..ctor
	|
	|-RVA: 0x615D334 Offset: 0x6159334 VA: 0x615D334
	|-OrderedDictionary.KeyCollection.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x6164694 Offset: 0x6160694 VA: 0x6164694
	|-OrderedDictionary.KeyCollection.Enumerator<long, object>..ctor
	|
	|-RVA: 0x616F924 Offset: 0x616B924 VA: 0x616F924
	|-OrderedDictionary.KeyCollection.Enumerator<object, FP>..ctor
	|
	|-RVA: 0x6171AFC Offset: 0x616DAFC VA: 0x6171AFC
	|-OrderedDictionary.KeyCollection.Enumerator<object, long>..ctor
	|
	|-RVA: 0x6173598 Offset: 0x616F598 VA: 0x6173598
	|-OrderedDictionary.KeyCollection.Enumerator<object, object>..ctor
	|
	|-RVA: 0x618CF90 Offset: 0x6188F90 VA: 0x618CF90
	|-OrderedDictionary.KeyCollection.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x61951B8 Offset: 0x61911B8 VA: 0x61951B8
	|-OrderedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61160B8 Offset: 0x61120B8 VA: 0x61160B8
	|-OrderedDictionary.KeyCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.Dispose
	|
	|-RVA: 0x61253AC Offset: 0x61213AC VA: 0x61253AC
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, int>.Dispose
	|
	|-RVA: 0x61401F8 Offset: 0x613C1F8 VA: 0x61401F8
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, object>.Dispose
	|
	|-RVA: 0x6147E84 Offset: 0x6143E84 VA: 0x6147E84
	|-OrderedDictionary.KeyCollection.Enumerator<int, ValueTuple<object, object, object, object>>.Dispose
	|
	|-RVA: 0x6149C4C Offset: 0x6145C4C VA: 0x6149C4C
	|-OrderedDictionary.KeyCollection.Enumerator<int, BulletLink>.Dispose
	|
	|-RVA: 0x614DE64 Offset: 0x6149E64 VA: 0x614DE64
	|-OrderedDictionary.KeyCollection.Enumerator<int, HeroSkillCount>.Dispose
	|
	|-RVA: 0x615031C Offset: 0x614C31C VA: 0x615031C
	|-OrderedDictionary.KeyCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x6154754 Offset: 0x6150754 VA: 0x6154754
	|-OrderedDictionary.KeyCollection.Enumerator<int, object>.Dispose
	|
	|-RVA: 0x615D370 Offset: 0x6159370 VA: 0x615D370
	|-OrderedDictionary.KeyCollection.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x61646D0 Offset: 0x61606D0 VA: 0x61646D0
	|-OrderedDictionary.KeyCollection.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x616F960 Offset: 0x616B960 VA: 0x616F960
	|-OrderedDictionary.KeyCollection.Enumerator<object, FP>.Dispose
	|
	|-RVA: 0x6171B38 Offset: 0x616DB38 VA: 0x6171B38
	|-OrderedDictionary.KeyCollection.Enumerator<object, long>.Dispose
	|
	|-RVA: 0x61735D4 Offset: 0x616F5D4 VA: 0x61735D4
	|-OrderedDictionary.KeyCollection.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x618CFCC Offset: 0x6188FCC VA: 0x618CFCC
	|-OrderedDictionary.KeyCollection.Enumerator<ulong, object>.Dispose
	|
	|-RVA: 0x61952D8 Offset: 0x61912D8 VA: 0x61952D8
	|-OrderedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61160BC Offset: 0x61120BC VA: 0x61160BC
	|-OrderedDictionary.KeyCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.MoveNext
	|
	|-RVA: 0x61253B0 Offset: 0x61213B0 VA: 0x61253B0
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, int>.MoveNext
	|
	|-RVA: 0x61401FC Offset: 0x613C1FC VA: 0x61401FC
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, object>.MoveNext
	|
	|-RVA: 0x6147E88 Offset: 0x6143E88 VA: 0x6147E88
	|-OrderedDictionary.KeyCollection.Enumerator<int, ValueTuple<object, object, object, object>>.MoveNext
	|
	|-RVA: 0x6149C50 Offset: 0x6145C50 VA: 0x6149C50
	|-OrderedDictionary.KeyCollection.Enumerator<int, BulletLink>.MoveNext
	|
	|-RVA: 0x614DE68 Offset: 0x6149E68 VA: 0x614DE68
	|-OrderedDictionary.KeyCollection.Enumerator<int, HeroSkillCount>.MoveNext
	|
	|-RVA: 0x6150320 Offset: 0x614C320 VA: 0x6150320
	|-OrderedDictionary.KeyCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x6154758 Offset: 0x6150758 VA: 0x6154758
	|-OrderedDictionary.KeyCollection.Enumerator<int, object>.MoveNext
	|
	|-RVA: 0x615D374 Offset: 0x6159374 VA: 0x615D374
	|-OrderedDictionary.KeyCollection.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x61646D4 Offset: 0x61606D4 VA: 0x61646D4
	|-OrderedDictionary.KeyCollection.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x616F964 Offset: 0x616B964 VA: 0x616F964
	|-OrderedDictionary.KeyCollection.Enumerator<object, FP>.MoveNext
	|
	|-RVA: 0x6171B3C Offset: 0x616DB3C VA: 0x6171B3C
	|-OrderedDictionary.KeyCollection.Enumerator<object, long>.MoveNext
	|
	|-RVA: 0x61735D8 Offset: 0x616F5D8 VA: 0x61735D8
	|-OrderedDictionary.KeyCollection.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x618CFD0 Offset: 0x6188FD0 VA: 0x618CFD0
	|-OrderedDictionary.KeyCollection.Enumerator<ulong, object>.MoveNext
	|
	|-RVA: 0x61952DC Offset: 0x61912DC VA: 0x61952DC
	|-OrderedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61161B8 Offset: 0x61121B8 VA: 0x61161B8
	|-OrderedDictionary.KeyCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.get_Current
	|
	|-RVA: 0x6125488 Offset: 0x6121488 VA: 0x6125488
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, int>.get_Current
	|
	|-RVA: 0x61402D4 Offset: 0x613C2D4 VA: 0x61402D4
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, object>.get_Current
	|
	|-RVA: 0x6147F4C Offset: 0x6143F4C VA: 0x6147F4C
	|-OrderedDictionary.KeyCollection.Enumerator<int, ValueTuple<object, object, object, object>>.get_Current
	|
	|-RVA: 0x6149D10 Offset: 0x6145D10 VA: 0x6149D10
	|-OrderedDictionary.KeyCollection.Enumerator<int, BulletLink>.get_Current
	|
	|-RVA: 0x614DF2C Offset: 0x6149F2C VA: 0x614DF2C
	|-OrderedDictionary.KeyCollection.Enumerator<int, HeroSkillCount>.get_Current
	|
	|-RVA: 0x61503E4 Offset: 0x614C3E4 VA: 0x61503E4
	|-OrderedDictionary.KeyCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x6154818 Offset: 0x6150818 VA: 0x6154818
	|-OrderedDictionary.KeyCollection.Enumerator<int, object>.get_Current
	|
	|-RVA: 0x615D438 Offset: 0x6159438 VA: 0x615D438
	|-OrderedDictionary.KeyCollection.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x6164794 Offset: 0x6160794 VA: 0x6164794
	|-OrderedDictionary.KeyCollection.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x616FA54 Offset: 0x616BA54 VA: 0x616FA54
	|-OrderedDictionary.KeyCollection.Enumerator<object, FP>.get_Current
	|
	|-RVA: 0x6171C2C Offset: 0x616DC2C VA: 0x6171C2C
	|-OrderedDictionary.KeyCollection.Enumerator<object, long>.get_Current
	|
	|-RVA: 0x61736C8 Offset: 0x616F6C8 VA: 0x61736C8
	|-OrderedDictionary.KeyCollection.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x618D090 Offset: 0x6189090 VA: 0x618D090
	|-OrderedDictionary.KeyCollection.Enumerator<ulong, object>.get_Current
	|
	|-RVA: 0x6195680 Offset: 0x6191680 VA: 0x6195680
	|-OrderedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61161C4 Offset: 0x61121C4 VA: 0x61161C4
	|-OrderedDictionary.KeyCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6125490 Offset: 0x6121490 VA: 0x6125490
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x61402DC Offset: 0x613C2DC VA: 0x61402DC
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6147F54 Offset: 0x6143F54 VA: 0x6147F54
	|-OrderedDictionary.KeyCollection.Enumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6149D18 Offset: 0x6145D18 VA: 0x6149D18
	|-OrderedDictionary.KeyCollection.Enumerator<int, BulletLink>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x614DF34 Offset: 0x6149F34 VA: 0x614DF34
	|-OrderedDictionary.KeyCollection.Enumerator<int, HeroSkillCount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x61503EC Offset: 0x614C3EC VA: 0x61503EC
	|-OrderedDictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6154820 Offset: 0x6150820 VA: 0x6154820
	|-OrderedDictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x615D440 Offset: 0x6159440 VA: 0x615D440
	|-OrderedDictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x616479C Offset: 0x616079C VA: 0x616479C
	|-OrderedDictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x616FA5C Offset: 0x616BA5C VA: 0x616FA5C
	|-OrderedDictionary.KeyCollection.Enumerator<object, FP>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6171C34 Offset: 0x616DC34 VA: 0x6171C34
	|-OrderedDictionary.KeyCollection.Enumerator<object, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x61736D0 Offset: 0x616F6D0 VA: 0x61736D0
	|-OrderedDictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x618D098 Offset: 0x6189098 VA: 0x618D098
	|-OrderedDictionary.KeyCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6195770 Offset: 0x6191770 VA: 0x6195770
	|-OrderedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x611626C Offset: 0x611226C VA: 0x611626C
	|-OrderedDictionary.KeyCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6125530 Offset: 0x6121530 VA: 0x6125530
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x614037C Offset: 0x613C37C VA: 0x614037C
	|-OrderedDictionary.KeyCollection.Enumerator<EntityRef, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6147FF4 Offset: 0x6143FF4 VA: 0x6147FF4
	|-OrderedDictionary.KeyCollection.Enumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6149DB8 Offset: 0x6145DB8 VA: 0x6149DB8
	|-OrderedDictionary.KeyCollection.Enumerator<int, BulletLink>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x614DFD4 Offset: 0x6149FD4 VA: 0x614DFD4
	|-OrderedDictionary.KeyCollection.Enumerator<int, HeroSkillCount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x615048C Offset: 0x614C48C VA: 0x615048C
	|-OrderedDictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x61548C0 Offset: 0x61508C0 VA: 0x61548C0
	|-OrderedDictionary.KeyCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x615D4E0 Offset: 0x61594E0 VA: 0x615D4E0
	|-OrderedDictionary.KeyCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x616483C Offset: 0x616083C VA: 0x616483C
	|-OrderedDictionary.KeyCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x616FAD8 Offset: 0x616BAD8 VA: 0x616FAD8
	|-OrderedDictionary.KeyCollection.Enumerator<object, FP>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6171CB0 Offset: 0x616DCB0 VA: 0x6171CB0
	|-OrderedDictionary.KeyCollection.Enumerator<object, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x617374C Offset: 0x616F74C VA: 0x617374C
	|-OrderedDictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x618D138 Offset: 0x6189138 VA: 0x618D138
	|-OrderedDictionary.KeyCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6195948 Offset: 0x6191948 VA: 0x6195948
	|-OrderedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[DebuggerTypeProxy(typeof(KeyCollectionDebugView<TKey, TValue>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public sealed class OrderedDictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 24233
{
	// Fields
	private OrderedDictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(OrderedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A79028 Offset: 0x4A75028 VA: 0x4A79028
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x4A84AC4 Offset: 0x4A80AC4 VA: 0x4A84AC4
	|-OrderedDictionary.KeyCollection<EntityRef, int>..ctor
	|
	|-RVA: 0x4A85FBC Offset: 0x4A81FBC VA: 0x4A85FBC
	|-OrderedDictionary.KeyCollection<EntityRef, object>..ctor
	|
	|-RVA: 0x4A8B198 Offset: 0x4A87198 VA: 0x4A8B198
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x4A8C690 Offset: 0x4A88690 VA: 0x4A8C690
	|-OrderedDictionary.KeyCollection<int, BulletLink>..ctor
	|
	|-RVA: 0x4A8F3E0 Offset: 0x4A8B3E0 VA: 0x4A8F3E0
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x4A908D8 Offset: 0x4A8C8D8 VA: 0x4A908D8
	|-OrderedDictionary.KeyCollection<int, int>..ctor
	|
	|-RVA: 0x4A93EBC Offset: 0x4A8FEBC VA: 0x4A93EBC
	|-OrderedDictionary.KeyCollection<int, object>..ctor
	|
	|-RVA: 0x4AC2FA4 Offset: 0x4ABEFA4 VA: 0x4AC2FA4
	|-OrderedDictionary.KeyCollection<Int32Enum, int>..ctor
	|
	|-RVA: 0x4AC818C Offset: 0x4AC418C VA: 0x4AC818C
	|-OrderedDictionary.KeyCollection<long, object>..ctor
	|
	|-RVA: 0x4AD035C Offset: 0x4ACC35C VA: 0x4AD035C
	|-OrderedDictionary.KeyCollection<object, FP>..ctor
	|
	|-RVA: 0x4AD23B0 Offset: 0x4ACE3B0 VA: 0x4AD23B0
	|-OrderedDictionary.KeyCollection<object, long>..ctor
	|
	|-RVA: 0x4AD3274 Offset: 0x4ACF274 VA: 0x4AD3274
	|-OrderedDictionary.KeyCollection<object, object>..ctor
	|
	|-RVA: 0x4AE63AC Offset: 0x4AE23AC VA: 0x4AE63AC
	|-OrderedDictionary.KeyCollection<ulong, object>..ctor
	|
	|-RVA: 0x4AE82B4 Offset: 0x4AE42B4 VA: 0x4AE82B4
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.KeyCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A7909C Offset: 0x4A7509C VA: 0x4A7909C
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.GetEnumerator
	|
	|-RVA: 0x4A84B38 Offset: 0x4A80B38 VA: 0x4A84B38
	|-OrderedDictionary.KeyCollection<EntityRef, int>.GetEnumerator
	|
	|-RVA: 0x4A86030 Offset: 0x4A82030 VA: 0x4A86030
	|-OrderedDictionary.KeyCollection<EntityRef, object>.GetEnumerator
	|
	|-RVA: 0x4A8B20C Offset: 0x4A8720C VA: 0x4A8B20C
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.GetEnumerator
	|
	|-RVA: 0x4A8C704 Offset: 0x4A88704 VA: 0x4A8C704
	|-OrderedDictionary.KeyCollection<int, BulletLink>.GetEnumerator
	|
	|-RVA: 0x4A8F454 Offset: 0x4A8B454 VA: 0x4A8F454
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.GetEnumerator
	|
	|-RVA: 0x4A9094C Offset: 0x4A8C94C VA: 0x4A9094C
	|-OrderedDictionary.KeyCollection<int, int>.GetEnumerator
	|
	|-RVA: 0x4A93F30 Offset: 0x4A8FF30 VA: 0x4A93F30
	|-OrderedDictionary.KeyCollection<int, object>.GetEnumerator
	|
	|-RVA: 0x4AC3018 Offset: 0x4ABF018 VA: 0x4AC3018
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x4AC8200 Offset: 0x4AC4200 VA: 0x4AC8200
	|-OrderedDictionary.KeyCollection<long, object>.GetEnumerator
	|
	|-RVA: 0x4AD03D0 Offset: 0x4ACC3D0 VA: 0x4AD03D0
	|-OrderedDictionary.KeyCollection<object, FP>.GetEnumerator
	|
	|-RVA: 0x4AD2424 Offset: 0x4ACE424 VA: 0x4AD2424
	|-OrderedDictionary.KeyCollection<object, long>.GetEnumerator
	|
	|-RVA: 0x4AD32E8 Offset: 0x4ACF2E8 VA: 0x4AD32E8
	|-OrderedDictionary.KeyCollection<object, object>.GetEnumerator
	|
	|-RVA: 0x4AE6420 Offset: 0x4AE2420 VA: 0x4AE6420
	|-OrderedDictionary.KeyCollection<ulong, object>.GetEnumerator
	|
	|-RVA: 0x4AE8328 Offset: 0x4AE4328 VA: 0x4AE8328
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A790C0 Offset: 0x4A750C0 VA: 0x4A790C0
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.CopyTo
	|
	|-RVA: 0x4A84B5C Offset: 0x4A80B5C VA: 0x4A84B5C
	|-OrderedDictionary.KeyCollection<EntityRef, int>.CopyTo
	|
	|-RVA: 0x4A86054 Offset: 0x4A82054 VA: 0x4A86054
	|-OrderedDictionary.KeyCollection<EntityRef, object>.CopyTo
	|
	|-RVA: 0x4A8B230 Offset: 0x4A87230 VA: 0x4A8B230
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.CopyTo
	|
	|-RVA: 0x4A8C728 Offset: 0x4A88728 VA: 0x4A8C728
	|-OrderedDictionary.KeyCollection<int, BulletLink>.CopyTo
	|
	|-RVA: 0x4A8F478 Offset: 0x4A8B478 VA: 0x4A8F478
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.CopyTo
	|
	|-RVA: 0x4A90970 Offset: 0x4A8C970 VA: 0x4A90970
	|-OrderedDictionary.KeyCollection<int, int>.CopyTo
	|
	|-RVA: 0x4A93F54 Offset: 0x4A8FF54 VA: 0x4A93F54
	|-OrderedDictionary.KeyCollection<int, object>.CopyTo
	|
	|-RVA: 0x4AC303C Offset: 0x4ABF03C VA: 0x4AC303C
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x4AC8224 Offset: 0x4AC4224 VA: 0x4AC8224
	|-OrderedDictionary.KeyCollection<long, object>.CopyTo
	|
	|-RVA: 0x4AD03F4 Offset: 0x4ACC3F4 VA: 0x4AD03F4
	|-OrderedDictionary.KeyCollection<object, FP>.CopyTo
	|
	|-RVA: 0x4AD2448 Offset: 0x4ACE448 VA: 0x4AD2448
	|-OrderedDictionary.KeyCollection<object, long>.CopyTo
	|
	|-RVA: 0x4AD330C Offset: 0x4ACF30C VA: 0x4AD330C
	|-OrderedDictionary.KeyCollection<object, object>.CopyTo
	|
	|-RVA: 0x4AE6444 Offset: 0x4AE2444 VA: 0x4AE6444
	|-OrderedDictionary.KeyCollection<ulong, object>.CopyTo
	|
	|-RVA: 0x4AE83D8 Offset: 0x4AE43D8 VA: 0x4AE83D8
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A79290 Offset: 0x4A75290 VA: 0x4A79290
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.get_Count
	|
	|-RVA: 0x4A84D0C Offset: 0x4A80D0C VA: 0x4A84D0C
	|-OrderedDictionary.KeyCollection<EntityRef, int>.get_Count
	|
	|-RVA: 0x4A86204 Offset: 0x4A82204 VA: 0x4A86204
	|-OrderedDictionary.KeyCollection<EntityRef, object>.get_Count
	|
	|-RVA: 0x4A8B3DC Offset: 0x4A873DC VA: 0x4A8B3DC
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.get_Count
	|
	|-RVA: 0x4A8C8D0 Offset: 0x4A888D0 VA: 0x4A8C8D0
	|-OrderedDictionary.KeyCollection<int, BulletLink>.get_Count
	|
	|-RVA: 0x4A8F624 Offset: 0x4A8B624 VA: 0x4A8F624
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.get_Count
	|
	|-RVA: 0x4A90B1C Offset: 0x4A8CB1C VA: 0x4A90B1C
	|-OrderedDictionary.KeyCollection<int, int>.get_Count
	|
	|-RVA: 0x4A940FC Offset: 0x4A900FC VA: 0x4A940FC
	|-OrderedDictionary.KeyCollection<int, object>.get_Count
	|
	|-RVA: 0x4AC31E8 Offset: 0x4ABF1E8 VA: 0x4AC31E8
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.get_Count
	|
	|-RVA: 0x4AC83D4 Offset: 0x4AC43D4 VA: 0x4AC83D4
	|-OrderedDictionary.KeyCollection<long, object>.get_Count
	|
	|-RVA: 0x4AD05B4 Offset: 0x4ACC5B4 VA: 0x4AD05B4
	|-OrderedDictionary.KeyCollection<object, FP>.get_Count
	|
	|-RVA: 0x4AD2608 Offset: 0x4ACE608 VA: 0x4AD2608
	|-OrderedDictionary.KeyCollection<object, long>.get_Count
	|
	|-RVA: 0x4AD34CC Offset: 0x4ACF4CC VA: 0x4AD34CC
	|-OrderedDictionary.KeyCollection<object, object>.get_Count
	|
	|-RVA: 0x4AE65F4 Offset: 0x4AE25F4 VA: 0x4AE65F4
	|-OrderedDictionary.KeyCollection<ulong, object>.get_Count
	|
	|-RVA: 0x4AE86A8 Offset: 0x4AE46A8 VA: 0x4AE86A8
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A792B4 Offset: 0x4A752B4 VA: 0x4A792B4
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4A84D30 Offset: 0x4A80D30 VA: 0x4A84D30
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4A86228 Offset: 0x4A82228 VA: 0x4A86228
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4A8B400 Offset: 0x4A87400 VA: 0x4A8B400
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4A8C8F4 Offset: 0x4A888F4 VA: 0x4A8C8F4
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4A8F648 Offset: 0x4A8B648 VA: 0x4A8F648
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4A90B40 Offset: 0x4A8CB40 VA: 0x4A90B40
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4A94120 Offset: 0x4A90120 VA: 0x4A94120
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4AC320C Offset: 0x4ABF20C VA: 0x4AC320C
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4AC83F8 Offset: 0x4AC43F8 VA: 0x4AC83F8
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4AD05D8 Offset: 0x4ACC5D8 VA: 0x4AD05D8
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4AD262C Offset: 0x4ACE62C VA: 0x4AD262C
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4AD34F0 Offset: 0x4ACF4F0 VA: 0x4AD34F0
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4AE6618 Offset: 0x4AE2618 VA: 0x4AE6618
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x4AE86D0 Offset: 0x4AE46D0 VA: 0x4AE86D0
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A792BC Offset: 0x4A752BC VA: 0x4A792BC
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4A84D38 Offset: 0x4A80D38 VA: 0x4A84D38
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4A86230 Offset: 0x4A82230 VA: 0x4A86230
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4A8B408 Offset: 0x4A87408 VA: 0x4A8B408
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4A8C8FC Offset: 0x4A888FC VA: 0x4A8C8FC
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4A8F650 Offset: 0x4A8B650 VA: 0x4A8F650
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4A90B48 Offset: 0x4A8CB48 VA: 0x4A90B48
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4A94128 Offset: 0x4A90128 VA: 0x4A94128
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4AC3214 Offset: 0x4ABF214 VA: 0x4AC3214
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4AC8400 Offset: 0x4AC4400 VA: 0x4AC8400
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4AD05E0 Offset: 0x4ACC5E0 VA: 0x4AD05E0
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4AD2634 Offset: 0x4ACE634 VA: 0x4AD2634
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4AD34F8 Offset: 0x4ACF4F8 VA: 0x4AD34F8
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4AE6620 Offset: 0x4AE2620 VA: 0x4AE6620
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x4AE86D8 Offset: 0x4AE46D8 VA: 0x4AE86D8
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A79304 Offset: 0x4A75304 VA: 0x4A79304
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4A84D80 Offset: 0x4A80D80 VA: 0x4A84D80
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4A86278 Offset: 0x4A82278 VA: 0x4A86278
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4A8B450 Offset: 0x4A87450 VA: 0x4A8B450
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4A8C944 Offset: 0x4A88944 VA: 0x4A8C944
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4A8F698 Offset: 0x4A8B698 VA: 0x4A8F698
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4A90B90 Offset: 0x4A8CB90 VA: 0x4A90B90
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4A94170 Offset: 0x4A90170 VA: 0x4A94170
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4AC325C Offset: 0x4ABF25C VA: 0x4AC325C
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4AC8448 Offset: 0x4AC4448 VA: 0x4AC8448
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4AD0628 Offset: 0x4ACC628 VA: 0x4AD0628
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4AD267C Offset: 0x4ACE67C VA: 0x4AD267C
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4AD3540 Offset: 0x4ACF540 VA: 0x4AD3540
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4AE6668 Offset: 0x4AE2668 VA: 0x4AE6668
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x4AE8720 Offset: 0x4AE4720 VA: 0x4AE8720
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A7934C Offset: 0x4A7534C VA: 0x4A7934C
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4A84DC8 Offset: 0x4A80DC8 VA: 0x4A84DC8
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4A862C0 Offset: 0x4A822C0 VA: 0x4A862C0
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4A8B498 Offset: 0x4A87498 VA: 0x4A8B498
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4A8C98C Offset: 0x4A8898C VA: 0x4A8C98C
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4A8F6E0 Offset: 0x4A8B6E0 VA: 0x4A8F6E0
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4A90BD8 Offset: 0x4A8CBD8 VA: 0x4A90BD8
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4A941B8 Offset: 0x4A901B8 VA: 0x4A941B8
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4AC32A4 Offset: 0x4ABF2A4 VA: 0x4AC32A4
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4AC8490 Offset: 0x4AC4490 VA: 0x4AC8490
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4AD0670 Offset: 0x4ACC670 VA: 0x4AD0670
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4AD26C4 Offset: 0x4ACE6C4 VA: 0x4AD26C4
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4AD3588 Offset: 0x4ACF588 VA: 0x4AD3588
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4AE66B0 Offset: 0x4AE26B0 VA: 0x4AE66B0
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x4AE8768 Offset: 0x4AE4768 VA: 0x4AE8768
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A79370 Offset: 0x4A75370 VA: 0x4A79370
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4A84DEC Offset: 0x4A80DEC VA: 0x4A84DEC
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4A862E4 Offset: 0x4A822E4 VA: 0x4A862E4
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4A8B4BC Offset: 0x4A874BC VA: 0x4A8B4BC
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4A8C9B0 Offset: 0x4A889B0 VA: 0x4A8C9B0
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4A8F704 Offset: 0x4A8B704 VA: 0x4A8F704
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4A90BFC Offset: 0x4A8CBFC VA: 0x4A90BFC
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4A941DC Offset: 0x4A901DC VA: 0x4A941DC
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4AC32C8 Offset: 0x4ABF2C8 VA: 0x4AC32C8
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4AC84B4 Offset: 0x4AC44B4 VA: 0x4AC84B4
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4AD0694 Offset: 0x4ACC694 VA: 0x4AD0694
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4AD26E8 Offset: 0x4ACE6E8 VA: 0x4AD26E8
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4AD35AC Offset: 0x4ACF5AC VA: 0x4AD35AC
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4AE66D4 Offset: 0x4AE26D4 VA: 0x4AE66D4
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x4AE8838 Offset: 0x4AE4838 VA: 0x4AE8838
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A793B8 Offset: 0x4A753B8 VA: 0x4A793B8
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4A84E34 Offset: 0x4A80E34 VA: 0x4A84E34
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4A8632C Offset: 0x4A8232C VA: 0x4A8632C
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4A8B504 Offset: 0x4A87504 VA: 0x4A8B504
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4A8C9F8 Offset: 0x4A889F8 VA: 0x4A8C9F8
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4A8F74C Offset: 0x4A8B74C VA: 0x4A8F74C
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4A90C44 Offset: 0x4A8CC44 VA: 0x4A90C44
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4A94224 Offset: 0x4A90224 VA: 0x4A94224
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4AC3310 Offset: 0x4ABF310 VA: 0x4AC3310
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4AC84FC Offset: 0x4AC44FC VA: 0x4AC84FC
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4AD06DC Offset: 0x4ACC6DC VA: 0x4AD06DC
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4AD2730 Offset: 0x4ACE730 VA: 0x4AD2730
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4AD35F4 Offset: 0x4ACF5F4 VA: 0x4AD35F4
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4AE671C Offset: 0x4AE271C VA: 0x4AE671C
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x4AE8880 Offset: 0x4AE4880 VA: 0x4AE8880
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A7940C Offset: 0x4A7540C VA: 0x4A7940C
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4A84E90 Offset: 0x4A80E90 VA: 0x4A84E90
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4A86388 Offset: 0x4A82388 VA: 0x4A86388
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4A8B560 Offset: 0x4A87560 VA: 0x4A8B560
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4A8CA54 Offset: 0x4A88A54 VA: 0x4A8CA54
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4A8F7A8 Offset: 0x4A8B7A8 VA: 0x4A8F7A8
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4A90CA0 Offset: 0x4A8CCA0 VA: 0x4A90CA0
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4A94280 Offset: 0x4A90280 VA: 0x4A94280
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4AC336C Offset: 0x4ABF36C VA: 0x4AC336C
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4AC8558 Offset: 0x4AC4558 VA: 0x4AC8558
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4AD0738 Offset: 0x4ACC738 VA: 0x4AD0738
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4AD278C Offset: 0x4ACE78C VA: 0x4AD278C
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4AD3650 Offset: 0x4ACF650 VA: 0x4AD3650
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4AE6778 Offset: 0x4AE2778 VA: 0x4AE6778
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4AE8930 Offset: 0x4AE4930 VA: 0x4AE8930
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A79460 Offset: 0x4A75460 VA: 0x4A79460
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4A84EEC Offset: 0x4A80EEC VA: 0x4A84EEC
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4A863E4 Offset: 0x4A823E4 VA: 0x4A863E4
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4A8B5BC Offset: 0x4A875BC VA: 0x4A8B5BC
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4A8CAB0 Offset: 0x4A88AB0 VA: 0x4A8CAB0
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4A8F804 Offset: 0x4A8B804 VA: 0x4A8F804
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4A90CFC Offset: 0x4A8CCFC VA: 0x4A90CFC
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4A942DC Offset: 0x4A902DC VA: 0x4A942DC
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4AC33C8 Offset: 0x4ABF3C8 VA: 0x4AC33C8
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4AC85B4 Offset: 0x4AC45B4 VA: 0x4AC85B4
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4AD0794 Offset: 0x4ACC794 VA: 0x4AD0794
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4AD27E8 Offset: 0x4ACE7E8 VA: 0x4AD27E8
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4AD36AC Offset: 0x4ACF6AC VA: 0x4AD36AC
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4AE67D4 Offset: 0x4AE27D4 VA: 0x4AE67D4
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x4AE89E0 Offset: 0x4AE49E0 VA: 0x4AE89E0
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A79858 Offset: 0x4A75858 VA: 0x4A79858
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4A852E0 Offset: 0x4A812E0 VA: 0x4A852E0
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4A867D8 Offset: 0x4A827D8 VA: 0x4A867D8
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4A8B9B4 Offset: 0x4A879B4 VA: 0x4A8B9B4
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4A8CEA4 Offset: 0x4A88EA4 VA: 0x4A8CEA4
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4A8FBFC Offset: 0x4A8BBFC VA: 0x4A8FBFC
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4A910F4 Offset: 0x4A8D0F4 VA: 0x4A910F4
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4A946D0 Offset: 0x4A906D0 VA: 0x4A946D0
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4AC37C0 Offset: 0x4ABF7C0 VA: 0x4AC37C0
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4AC89A8 Offset: 0x4AC49A8 VA: 0x4AC89A8
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4AD0B68 Offset: 0x4ACCB68 VA: 0x4AD0B68
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4AD2BBC Offset: 0x4ACEBBC VA: 0x4AD2BBC
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4AD3A80 Offset: 0x4ACFA80 VA: 0x4AD3A80
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4AE6BC8 Offset: 0x4AE2BC8 VA: 0x4AE6BC8
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x4AE8E80 Offset: 0x4AE4E80 VA: 0x4AE8E80
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A79860 Offset: 0x4A75860 VA: 0x4A79860
	|-OrderedDictionary.KeyCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4A852E8 Offset: 0x4A812E8 VA: 0x4A852E8
	|-OrderedDictionary.KeyCollection<EntityRef, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4A867E0 Offset: 0x4A827E0 VA: 0x4A867E0
	|-OrderedDictionary.KeyCollection<EntityRef, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4A8B9BC Offset: 0x4A879BC VA: 0x4A8B9BC
	|-OrderedDictionary.KeyCollection<int, ValueTuple<object, object, object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4A8CEAC Offset: 0x4A88EAC VA: 0x4A8CEAC
	|-OrderedDictionary.KeyCollection<int, BulletLink>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4A8FC04 Offset: 0x4A8BC04 VA: 0x4A8FC04
	|-OrderedDictionary.KeyCollection<int, HeroSkillCount>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4A910FC Offset: 0x4A8D0FC VA: 0x4A910FC
	|-OrderedDictionary.KeyCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4A946D8 Offset: 0x4A906D8 VA: 0x4A946D8
	|-OrderedDictionary.KeyCollection<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4AC37C8 Offset: 0x4ABF7C8 VA: 0x4AC37C8
	|-OrderedDictionary.KeyCollection<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4AC89B0 Offset: 0x4AC49B0 VA: 0x4AC89B0
	|-OrderedDictionary.KeyCollection<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4AD0B70 Offset: 0x4ACCB70 VA: 0x4AD0B70
	|-OrderedDictionary.KeyCollection<object, FP>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4AD2BC4 Offset: 0x4ACEBC4 VA: 0x4AD2BC4
	|-OrderedDictionary.KeyCollection<object, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4AD3A88 Offset: 0x4ACFA88 VA: 0x4AD3A88
	|-OrderedDictionary.KeyCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4AE6BD0 Offset: 0x4AE2BD0 VA: 0x4AE6BD0
	|-OrderedDictionary.KeyCollection<ulong, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x4AE8E88 Offset: 0x4AE4E88 VA: 0x4AE8E88
	|-OrderedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/
}

// Namespace: 
[Serializable]
public struct OrderedDictionary.ValueCollection.Enumerator<TKey, TValue> : IEnumerator<TValue>, IEnumerator, IDisposable // TypeDefIndex: 24234
{
	// Fields
	private OrderedDictionary<TKey, TValue> dictionary; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private TValue currentValue; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61162E8 Offset: 0x61122E8 VA: 0x61162E8
	|-OrderedDictionary.ValueCollection.Enumerator<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x61255AC Offset: 0x61215AC VA: 0x61255AC
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, int>..ctor
	|
	|-RVA: 0x61403F8 Offset: 0x613C3F8 VA: 0x61403F8
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, object>..ctor
	|
	|-RVA: 0x6148070 Offset: 0x6144070 VA: 0x6148070
	|-OrderedDictionary.ValueCollection.Enumerator<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x6149E34 Offset: 0x6145E34 VA: 0x6149E34
	|-OrderedDictionary.ValueCollection.Enumerator<int, BulletLink>..ctor
	|
	|-RVA: 0x614E050 Offset: 0x614A050 VA: 0x614E050
	|-OrderedDictionary.ValueCollection.Enumerator<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x6150508 Offset: 0x614C508 VA: 0x6150508
	|-OrderedDictionary.ValueCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x615493C Offset: 0x615093C VA: 0x615493C
	|-OrderedDictionary.ValueCollection.Enumerator<int, object>..ctor
	|
	|-RVA: 0x615D55C Offset: 0x615955C VA: 0x615D55C
	|-OrderedDictionary.ValueCollection.Enumerator<Int32Enum, int>..ctor
	|
	|-RVA: 0x61648B8 Offset: 0x61608B8 VA: 0x61648B8
	|-OrderedDictionary.ValueCollection.Enumerator<long, object>..ctor
	|
	|-RVA: 0x616FB54 Offset: 0x616BB54 VA: 0x616FB54
	|-OrderedDictionary.ValueCollection.Enumerator<object, FP>..ctor
	|
	|-RVA: 0x6171D2C Offset: 0x616DD2C VA: 0x6171D2C
	|-OrderedDictionary.ValueCollection.Enumerator<object, long>..ctor
	|
	|-RVA: 0x61737C8 Offset: 0x616F7C8 VA: 0x61737C8
	|-OrderedDictionary.ValueCollection.Enumerator<object, object>..ctor
	|
	|-RVA: 0x618D1B4 Offset: 0x61891B4 VA: 0x618D1B4
	|-OrderedDictionary.ValueCollection.Enumerator<ulong, object>..ctor
	|
	|-RVA: 0x6195AD8 Offset: 0x6191AD8 VA: 0x6195AD8
	|-OrderedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6116324 Offset: 0x6112324 VA: 0x6116324
	|-OrderedDictionary.ValueCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.Dispose
	|
	|-RVA: 0x61255E8 Offset: 0x61215E8 VA: 0x61255E8
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, int>.Dispose
	|
	|-RVA: 0x6140434 Offset: 0x613C434 VA: 0x6140434
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, object>.Dispose
	|
	|-RVA: 0x61480B0 Offset: 0x61440B0 VA: 0x61480B0
	|-OrderedDictionary.ValueCollection.Enumerator<int, ValueTuple<object, object, object, object>>.Dispose
	|
	|-RVA: 0x6149E78 Offset: 0x6145E78 VA: 0x6149E78
	|-OrderedDictionary.ValueCollection.Enumerator<int, BulletLink>.Dispose
	|
	|-RVA: 0x614E08C Offset: 0x614A08C VA: 0x614E08C
	|-OrderedDictionary.ValueCollection.Enumerator<int, HeroSkillCount>.Dispose
	|
	|-RVA: 0x6150544 Offset: 0x614C544 VA: 0x6150544
	|-OrderedDictionary.ValueCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x6154978 Offset: 0x6150978 VA: 0x6154978
	|-OrderedDictionary.ValueCollection.Enumerator<int, object>.Dispose
	|
	|-RVA: 0x615D598 Offset: 0x6159598 VA: 0x615D598
	|-OrderedDictionary.ValueCollection.Enumerator<Int32Enum, int>.Dispose
	|
	|-RVA: 0x61648F4 Offset: 0x61608F4 VA: 0x61648F4
	|-OrderedDictionary.ValueCollection.Enumerator<long, object>.Dispose
	|
	|-RVA: 0x616FB90 Offset: 0x616BB90 VA: 0x616FB90
	|-OrderedDictionary.ValueCollection.Enumerator<object, FP>.Dispose
	|
	|-RVA: 0x6171D68 Offset: 0x616DD68 VA: 0x6171D68
	|-OrderedDictionary.ValueCollection.Enumerator<object, long>.Dispose
	|
	|-RVA: 0x6173804 Offset: 0x616F804 VA: 0x6173804
	|-OrderedDictionary.ValueCollection.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x618D1F0 Offset: 0x61891F0 VA: 0x618D1F0
	|-OrderedDictionary.ValueCollection.Enumerator<ulong, object>.Dispose
	|
	|-RVA: 0x6195BF8 Offset: 0x6191BF8 VA: 0x6195BF8
	|-OrderedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6116328 Offset: 0x6112328 VA: 0x6116328
	|-OrderedDictionary.ValueCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.MoveNext
	|
	|-RVA: 0x61255EC Offset: 0x61215EC VA: 0x61255EC
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, int>.MoveNext
	|
	|-RVA: 0x6140438 Offset: 0x613C438 VA: 0x6140438
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, object>.MoveNext
	|
	|-RVA: 0x61480B4 Offset: 0x61440B4 VA: 0x61480B4
	|-OrderedDictionary.ValueCollection.Enumerator<int, ValueTuple<object, object, object, object>>.MoveNext
	|
	|-RVA: 0x6149E7C Offset: 0x6145E7C VA: 0x6149E7C
	|-OrderedDictionary.ValueCollection.Enumerator<int, BulletLink>.MoveNext
	|
	|-RVA: 0x614E090 Offset: 0x614A090 VA: 0x614E090
	|-OrderedDictionary.ValueCollection.Enumerator<int, HeroSkillCount>.MoveNext
	|
	|-RVA: 0x6150548 Offset: 0x614C548 VA: 0x6150548
	|-OrderedDictionary.ValueCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x615497C Offset: 0x615097C VA: 0x615497C
	|-OrderedDictionary.ValueCollection.Enumerator<int, object>.MoveNext
	|
	|-RVA: 0x615D59C Offset: 0x615959C VA: 0x615D59C
	|-OrderedDictionary.ValueCollection.Enumerator<Int32Enum, int>.MoveNext
	|
	|-RVA: 0x61648F8 Offset: 0x61608F8 VA: 0x61648F8
	|-OrderedDictionary.ValueCollection.Enumerator<long, object>.MoveNext
	|
	|-RVA: 0x616FB94 Offset: 0x616BB94 VA: 0x616FB94
	|-OrderedDictionary.ValueCollection.Enumerator<object, FP>.MoveNext
	|
	|-RVA: 0x6171D6C Offset: 0x616DD6C VA: 0x6171D6C
	|-OrderedDictionary.ValueCollection.Enumerator<object, long>.MoveNext
	|
	|-RVA: 0x6173808 Offset: 0x616F808 VA: 0x6173808
	|-OrderedDictionary.ValueCollection.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x618D1F4 Offset: 0x61891F4 VA: 0x618D1F4
	|-OrderedDictionary.ValueCollection.Enumerator<ulong, object>.MoveNext
	|
	|-RVA: 0x6195BFC Offset: 0x6191BFC VA: 0x6195BFC
	|-OrderedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6116408 Offset: 0x6112408 VA: 0x6116408
	|-OrderedDictionary.ValueCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.get_Current
	|
	|-RVA: 0x61256AC Offset: 0x61216AC VA: 0x61256AC
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, int>.get_Current
	|
	|-RVA: 0x6140528 Offset: 0x613C528 VA: 0x6140528
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, object>.get_Current
	|
	|-RVA: 0x61481B4 Offset: 0x61441B4 VA: 0x61481B4
	|-OrderedDictionary.ValueCollection.Enumerator<int, ValueTuple<object, object, object, object>>.get_Current
	|
	|-RVA: 0x6149F70 Offset: 0x6145F70 VA: 0x6149F70
	|-OrderedDictionary.ValueCollection.Enumerator<int, BulletLink>.get_Current
	|
	|-RVA: 0x614E170 Offset: 0x614A170 VA: 0x614E170
	|-OrderedDictionary.ValueCollection.Enumerator<int, HeroSkillCount>.get_Current
	|
	|-RVA: 0x615060C Offset: 0x614C60C VA: 0x615060C
	|-OrderedDictionary.ValueCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x6154A6C Offset: 0x6150A6C VA: 0x6154A6C
	|-OrderedDictionary.ValueCollection.Enumerator<int, object>.get_Current
	|
	|-RVA: 0x615D660 Offset: 0x6159660 VA: 0x615D660
	|-OrderedDictionary.ValueCollection.Enumerator<Int32Enum, int>.get_Current
	|
	|-RVA: 0x61649E8 Offset: 0x61609E8 VA: 0x61649E8
	|-OrderedDictionary.ValueCollection.Enumerator<long, object>.get_Current
	|
	|-RVA: 0x616FC6C Offset: 0x616BC6C VA: 0x616FC6C
	|-OrderedDictionary.ValueCollection.Enumerator<object, FP>.get_Current
	|
	|-RVA: 0x6171E2C Offset: 0x616DE2C VA: 0x6171E2C
	|-OrderedDictionary.ValueCollection.Enumerator<object, long>.get_Current
	|
	|-RVA: 0x61738F8 Offset: 0x616F8F8 VA: 0x61738F8
	|-OrderedDictionary.ValueCollection.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x618D2E4 Offset: 0x61892E4 VA: 0x618D2E4
	|-OrderedDictionary.ValueCollection.Enumerator<ulong, object>.get_Current
	|
	|-RVA: 0x6195FA0 Offset: 0x6191FA0 VA: 0x6195FA0
	|-OrderedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6116410 Offset: 0x6112410 VA: 0x6116410
	|-OrderedDictionary.ValueCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x61256B4 Offset: 0x61216B4 VA: 0x61256B4
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6140530 Offset: 0x613C530 VA: 0x6140530
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x61481C0 Offset: 0x61441C0 VA: 0x61481C0
	|-OrderedDictionary.ValueCollection.Enumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6149F84 Offset: 0x6145F84 VA: 0x6149F84
	|-OrderedDictionary.ValueCollection.Enumerator<int, BulletLink>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x614E178 Offset: 0x614A178 VA: 0x614E178
	|-OrderedDictionary.ValueCollection.Enumerator<int, HeroSkillCount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6150614 Offset: 0x614C614 VA: 0x6150614
	|-OrderedDictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6154A74 Offset: 0x6150A74 VA: 0x6154A74
	|-OrderedDictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x615D668 Offset: 0x6159668 VA: 0x615D668
	|-OrderedDictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x61649F0 Offset: 0x61609F0 VA: 0x61649F0
	|-OrderedDictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x616FC74 Offset: 0x616BC74 VA: 0x616FC74
	|-OrderedDictionary.ValueCollection.Enumerator<object, FP>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6171E34 Offset: 0x616DE34 VA: 0x6171E34
	|-OrderedDictionary.ValueCollection.Enumerator<object, long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6173900 Offset: 0x616F900 VA: 0x6173900
	|-OrderedDictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x618D2EC Offset: 0x61892EC VA: 0x618D2EC
	|-OrderedDictionary.ValueCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6196090 Offset: 0x6192090 VA: 0x6196090
	|-OrderedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61164B0 Offset: 0x61124B0 VA: 0x61164B0
	|-OrderedDictionary.ValueCollection.Enumerator<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6125754 Offset: 0x6121754 VA: 0x6125754
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x61405AC Offset: 0x613C5AC VA: 0x61405AC
	|-OrderedDictionary.ValueCollection.Enumerator<EntityRef, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6148268 Offset: 0x6144268 VA: 0x6148268
	|-OrderedDictionary.ValueCollection.Enumerator<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x614A034 Offset: 0x6146034 VA: 0x614A034
	|-OrderedDictionary.ValueCollection.Enumerator<int, BulletLink>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x614E218 Offset: 0x614A218 VA: 0x614E218
	|-OrderedDictionary.ValueCollection.Enumerator<int, HeroSkillCount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x61506B4 Offset: 0x614C6B4 VA: 0x61506B4
	|-OrderedDictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6154AF0 Offset: 0x6150AF0 VA: 0x6154AF0
	|-OrderedDictionary.ValueCollection.Enumerator<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x615D708 Offset: 0x6159708 VA: 0x615D708
	|-OrderedDictionary.ValueCollection.Enumerator<Int32Enum, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6164A6C Offset: 0x6160A6C VA: 0x6164A6C
	|-OrderedDictionary.ValueCollection.Enumerator<long, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x616FD14 Offset: 0x616BD14 VA: 0x616FD14
	|-OrderedDictionary.ValueCollection.Enumerator<object, FP>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6171ED4 Offset: 0x616DED4 VA: 0x6171ED4
	|-OrderedDictionary.ValueCollection.Enumerator<object, long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x617397C Offset: 0x616F97C VA: 0x617397C
	|-OrderedDictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x618D368 Offset: 0x6189368 VA: 0x618D368
	|-OrderedDictionary.ValueCollection.Enumerator<ulong, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6196268 Offset: 0x6192268 VA: 0x6196268
	|-OrderedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ValueCollectionDebugView<TKey, TValue>))]
[Serializable]
public sealed class OrderedDictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 24235
{
	// Fields
	private OrderedDictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(OrderedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D0FA0 Offset: 0x56CCFA0 VA: 0x56D0FA0
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x56DBF74 Offset: 0x56D7F74 VA: 0x56DBF74
	|-OrderedDictionary.ValueCollection<EntityRef, int>..ctor
	|
	|-RVA: 0x56DD458 Offset: 0x56D9458 VA: 0x56DD458
	|-OrderedDictionary.ValueCollection<EntityRef, object>..ctor
	|
	|-RVA: 0x56E27C4 Offset: 0x56DE7C4 VA: 0x56E27C4
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x56E3DAC Offset: 0x56DFDAC VA: 0x56E3DAC
	|-OrderedDictionary.ValueCollection<int, BulletLink>..ctor
	|
	|-RVA: 0x56E6D6C Offset: 0x56E2D6C VA: 0x56E6D6C
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x56E8270 Offset: 0x56E4270 VA: 0x56E8270
	|-OrderedDictionary.ValueCollection<int, int>..ctor
	|
	|-RVA: 0x56EB81C Offset: 0x56E781C VA: 0x56EB81C
	|-OrderedDictionary.ValueCollection<int, object>..ctor
	|
	|-RVA: 0x56F26E0 Offset: 0x56EE6E0 VA: 0x56F26E0
	|-OrderedDictionary.ValueCollection<Int32Enum, int>..ctor
	|
	|-RVA: 0x56F7A2C Offset: 0x56F3A2C VA: 0x56F7A2C
	|-OrderedDictionary.ValueCollection<long, object>..ctor
	|
	|-RVA: 0x5700328 Offset: 0x56FC328 VA: 0x5700328
	|-OrderedDictionary.ValueCollection<object, FP>..ctor
	|
	|-RVA: 0x57023B0 Offset: 0x56FE3B0 VA: 0x57023B0
	|-OrderedDictionary.ValueCollection<object, long>..ctor
	|
	|-RVA: 0x5703284 Offset: 0x56FF284 VA: 0x5703284
	|-OrderedDictionary.ValueCollection<object, object>..ctor
	|
	|-RVA: 0x5738E5C Offset: 0x5734E5C VA: 0x5738E5C
	|-OrderedDictionary.ValueCollection<ulong, object>..ctor
	|
	|-RVA: 0x573AD30 Offset: 0x5736D30 VA: 0x573AD30
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.ValueCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D1014 Offset: 0x56CD014 VA: 0x56D1014
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.GetEnumerator
	|
	|-RVA: 0x56DBFE8 Offset: 0x56D7FE8 VA: 0x56DBFE8
	|-OrderedDictionary.ValueCollection<EntityRef, int>.GetEnumerator
	|
	|-RVA: 0x56DD4CC Offset: 0x56D94CC VA: 0x56DD4CC
	|-OrderedDictionary.ValueCollection<EntityRef, object>.GetEnumerator
	|
	|-RVA: 0x56E2838 Offset: 0x56DE838 VA: 0x56E2838
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.GetEnumerator
	|
	|-RVA: 0x56E3E20 Offset: 0x56DFE20 VA: 0x56E3E20
	|-OrderedDictionary.ValueCollection<int, BulletLink>.GetEnumerator
	|
	|-RVA: 0x56E6DE0 Offset: 0x56E2DE0 VA: 0x56E6DE0
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.GetEnumerator
	|
	|-RVA: 0x56E82E4 Offset: 0x56E42E4 VA: 0x56E82E4
	|-OrderedDictionary.ValueCollection<int, int>.GetEnumerator
	|
	|-RVA: 0x56EB890 Offset: 0x56E7890 VA: 0x56EB890
	|-OrderedDictionary.ValueCollection<int, object>.GetEnumerator
	|
	|-RVA: 0x56F2754 Offset: 0x56EE754 VA: 0x56F2754
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x56F7AA0 Offset: 0x56F3AA0 VA: 0x56F7AA0
	|-OrderedDictionary.ValueCollection<long, object>.GetEnumerator
	|
	|-RVA: 0x570039C Offset: 0x56FC39C VA: 0x570039C
	|-OrderedDictionary.ValueCollection<object, FP>.GetEnumerator
	|
	|-RVA: 0x5702424 Offset: 0x56FE424 VA: 0x5702424
	|-OrderedDictionary.ValueCollection<object, long>.GetEnumerator
	|
	|-RVA: 0x57032F8 Offset: 0x56FF2F8 VA: 0x57032F8
	|-OrderedDictionary.ValueCollection<object, object>.GetEnumerator
	|
	|-RVA: 0x5738ED0 Offset: 0x5734ED0 VA: 0x5738ED0
	|-OrderedDictionary.ValueCollection<ulong, object>.GetEnumerator
	|
	|-RVA: 0x573ADA4 Offset: 0x5736DA4 VA: 0x573ADA4
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D1038 Offset: 0x56CD038 VA: 0x56D1038
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.CopyTo
	|
	|-RVA: 0x56DC00C Offset: 0x56D800C VA: 0x56DC00C
	|-OrderedDictionary.ValueCollection<EntityRef, int>.CopyTo
	|
	|-RVA: 0x56DD4F0 Offset: 0x56D94F0 VA: 0x56DD4F0
	|-OrderedDictionary.ValueCollection<EntityRef, object>.CopyTo
	|
	|-RVA: 0x56E2860 Offset: 0x56DE860 VA: 0x56E2860
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.CopyTo
	|
	|-RVA: 0x56E3E48 Offset: 0x56DFE48 VA: 0x56E3E48
	|-OrderedDictionary.ValueCollection<int, BulletLink>.CopyTo
	|
	|-RVA: 0x56E6E04 Offset: 0x56E2E04 VA: 0x56E6E04
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.CopyTo
	|
	|-RVA: 0x56E8308 Offset: 0x56E4308 VA: 0x56E8308
	|-OrderedDictionary.ValueCollection<int, int>.CopyTo
	|
	|-RVA: 0x56EB8B4 Offset: 0x56E78B4 VA: 0x56EB8B4
	|-OrderedDictionary.ValueCollection<int, object>.CopyTo
	|
	|-RVA: 0x56F2778 Offset: 0x56EE778 VA: 0x56F2778
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x56F7AC4 Offset: 0x56F3AC4 VA: 0x56F7AC4
	|-OrderedDictionary.ValueCollection<long, object>.CopyTo
	|
	|-RVA: 0x57003C0 Offset: 0x56FC3C0 VA: 0x57003C0
	|-OrderedDictionary.ValueCollection<object, FP>.CopyTo
	|
	|-RVA: 0x5702448 Offset: 0x56FE448 VA: 0x5702448
	|-OrderedDictionary.ValueCollection<object, long>.CopyTo
	|
	|-RVA: 0x570331C Offset: 0x56FF31C VA: 0x570331C
	|-OrderedDictionary.ValueCollection<object, object>.CopyTo
	|
	|-RVA: 0x5738EF4 Offset: 0x5734EF4 VA: 0x5738EF4
	|-OrderedDictionary.ValueCollection<ulong, object>.CopyTo
	|
	|-RVA: 0x573AE54 Offset: 0x5736E54 VA: 0x573AE54
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D11F0 Offset: 0x56CD1F0 VA: 0x56D11F0
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.get_Count
	|
	|-RVA: 0x56DC1B4 Offset: 0x56D81B4 VA: 0x56DC1B4
	|-OrderedDictionary.ValueCollection<EntityRef, int>.get_Count
	|
	|-RVA: 0x56DD6B0 Offset: 0x56D96B0 VA: 0x56DD6B0
	|-OrderedDictionary.ValueCollection<EntityRef, object>.get_Count
	|
	|-RVA: 0x56E2A38 Offset: 0x56DEA38 VA: 0x56E2A38
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.get_Count
	|
	|-RVA: 0x56E4028 Offset: 0x56E0028 VA: 0x56E4028
	|-OrderedDictionary.ValueCollection<int, BulletLink>.get_Count
	|
	|-RVA: 0x56E6FBC Offset: 0x56E2FBC VA: 0x56E6FBC
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.get_Count
	|
	|-RVA: 0x56E84B4 Offset: 0x56E44B4 VA: 0x56E84B4
	|-OrderedDictionary.ValueCollection<int, int>.get_Count
	|
	|-RVA: 0x56EBA74 Offset: 0x56E7A74 VA: 0x56EBA74
	|-OrderedDictionary.ValueCollection<int, object>.get_Count
	|
	|-RVA: 0x56F2924 Offset: 0x56EE924 VA: 0x56F2924
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.get_Count
	|
	|-RVA: 0x56F7C84 Offset: 0x56F3C84 VA: 0x56F7C84
	|-OrderedDictionary.ValueCollection<long, object>.get_Count
	|
	|-RVA: 0x5700570 Offset: 0x56FC570 VA: 0x5700570
	|-OrderedDictionary.ValueCollection<object, FP>.get_Count
	|
	|-RVA: 0x57025F8 Offset: 0x56FE5F8 VA: 0x57025F8
	|-OrderedDictionary.ValueCollection<object, long>.get_Count
	|
	|-RVA: 0x57034DC Offset: 0x56FF4DC VA: 0x57034DC
	|-OrderedDictionary.ValueCollection<object, object>.get_Count
	|
	|-RVA: 0x57390B4 Offset: 0x57350B4 VA: 0x57390B4
	|-OrderedDictionary.ValueCollection<ulong, object>.get_Count
	|
	|-RVA: 0x573B124 Offset: 0x5737124 VA: 0x573B124
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D1214 Offset: 0x56CD214 VA: 0x56D1214
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x56DC1D8 Offset: 0x56D81D8 VA: 0x56DC1D8
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x56DD6D4 Offset: 0x56D96D4 VA: 0x56DD6D4
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x56E2A5C Offset: 0x56DEA5C VA: 0x56E2A5C
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x56E404C Offset: 0x56E004C VA: 0x56E404C
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x56E6FE0 Offset: 0x56E2FE0 VA: 0x56E6FE0
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x56E84D8 Offset: 0x56E44D8 VA: 0x56E84D8
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x56EBA98 Offset: 0x56E7A98 VA: 0x56EBA98
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x56F2948 Offset: 0x56EE948 VA: 0x56F2948
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x56F7CA8 Offset: 0x56F3CA8 VA: 0x56F7CA8
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x5700594 Offset: 0x56FC594 VA: 0x5700594
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x570261C Offset: 0x56FE61C VA: 0x570261C
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x5703500 Offset: 0x56FF500 VA: 0x5703500
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x57390D8 Offset: 0x57350D8 VA: 0x57390D8
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x573B14C Offset: 0x573714C VA: 0x573B14C
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D121C Offset: 0x56CD21C VA: 0x56D121C
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x56DC1E0 Offset: 0x56D81E0 VA: 0x56DC1E0
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x56DD6DC Offset: 0x56D96DC VA: 0x56DD6DC
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x56E2A64 Offset: 0x56DEA64 VA: 0x56E2A64
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x56E4054 Offset: 0x56E0054 VA: 0x56E4054
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x56E6FE8 Offset: 0x56E2FE8 VA: 0x56E6FE8
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x56E84E0 Offset: 0x56E44E0 VA: 0x56E84E0
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x56EBAA0 Offset: 0x56E7AA0 VA: 0x56EBAA0
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x56F2950 Offset: 0x56EE950 VA: 0x56F2950
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x56F7CB0 Offset: 0x56F3CB0 VA: 0x56F7CB0
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x570059C Offset: 0x56FC59C VA: 0x570059C
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x5702624 Offset: 0x56FE624 VA: 0x5702624
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x5703508 Offset: 0x56FF508 VA: 0x5703508
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x57390E0 Offset: 0x57350E0 VA: 0x57390E0
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x573B154 Offset: 0x5737154 VA: 0x573B154
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D1264 Offset: 0x56CD264 VA: 0x56D1264
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x56DC228 Offset: 0x56D8228 VA: 0x56DC228
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x56DD724 Offset: 0x56D9724 VA: 0x56DD724
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x56E2AAC Offset: 0x56DEAAC VA: 0x56E2AAC
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x56E409C Offset: 0x56E009C VA: 0x56E409C
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x56E7030 Offset: 0x56E3030 VA: 0x56E7030
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x56E8528 Offset: 0x56E4528 VA: 0x56E8528
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x56EBAE8 Offset: 0x56E7AE8 VA: 0x56EBAE8
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x56F2998 Offset: 0x56EE998 VA: 0x56F2998
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x56F7CF8 Offset: 0x56F3CF8 VA: 0x56F7CF8
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x57005E4 Offset: 0x56FC5E4 VA: 0x57005E4
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x570266C Offset: 0x56FE66C VA: 0x570266C
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x5703550 Offset: 0x56FF550 VA: 0x5703550
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x5739128 Offset: 0x5735128 VA: 0x5739128
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x573B19C Offset: 0x573719C VA: 0x573B19C
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D12AC Offset: 0x56CD2AC VA: 0x56D12AC
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x56DC270 Offset: 0x56D8270 VA: 0x56DC270
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x56DD76C Offset: 0x56D976C VA: 0x56DD76C
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x56E2AF4 Offset: 0x56DEAF4 VA: 0x56E2AF4
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x56E40E4 Offset: 0x56E00E4 VA: 0x56E40E4
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x56E7078 Offset: 0x56E3078 VA: 0x56E7078
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x56E8570 Offset: 0x56E4570 VA: 0x56E8570
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x56EBB30 Offset: 0x56E7B30 VA: 0x56EBB30
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x56F29E0 Offset: 0x56EE9E0 VA: 0x56F29E0
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x56F7D40 Offset: 0x56F3D40 VA: 0x56F7D40
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x570062C Offset: 0x56FC62C VA: 0x570062C
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x57026B4 Offset: 0x56FE6B4 VA: 0x57026B4
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x5703598 Offset: 0x56FF598 VA: 0x5703598
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x5739170 Offset: 0x5735170 VA: 0x5739170
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x573B1E4 Offset: 0x57371E4 VA: 0x573B1E4
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D12F4 Offset: 0x56CD2F4 VA: 0x56D12F4
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x56DC2B8 Offset: 0x56D82B8 VA: 0x56DC2B8
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x56DD7B4 Offset: 0x56D97B4 VA: 0x56DD7B4
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x56E2B3C Offset: 0x56DEB3C VA: 0x56E2B3C
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x56E412C Offset: 0x56E012C VA: 0x56E412C
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x56E70C0 Offset: 0x56E30C0 VA: 0x56E70C0
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x56E85B8 Offset: 0x56E45B8 VA: 0x56E85B8
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x56EBB78 Offset: 0x56E7B78 VA: 0x56EBB78
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x56F2A28 Offset: 0x56EEA28 VA: 0x56F2A28
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x56F7D88 Offset: 0x56F3D88 VA: 0x56F7D88
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x5700674 Offset: 0x56FC674 VA: 0x5700674
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x57026FC Offset: 0x56FE6FC VA: 0x57026FC
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x57035E0 Offset: 0x56FF5E0 VA: 0x57035E0
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x57391B8 Offset: 0x57351B8 VA: 0x57391B8
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x573B22C Offset: 0x573722C VA: 0x573B22C
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D1318 Offset: 0x56CD318 VA: 0x56D1318
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x56DC2DC Offset: 0x56D82DC VA: 0x56DC2DC
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x56DD7D8 Offset: 0x56D97D8 VA: 0x56DD7D8
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x56E2B84 Offset: 0x56DEB84 VA: 0x56E2B84
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x56E4184 Offset: 0x56E0184 VA: 0x56E4184
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x56E70E4 Offset: 0x56E30E4 VA: 0x56E70E4
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x56E85DC Offset: 0x56E45DC VA: 0x56E85DC
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x56EBB9C Offset: 0x56E7B9C VA: 0x56EBB9C
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x56F2A4C Offset: 0x56EEA4C VA: 0x56F2A4C
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x56F7DAC Offset: 0x56F3DAC VA: 0x56F7DAC
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x5700698 Offset: 0x56FC698 VA: 0x5700698
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x5702720 Offset: 0x56FE720 VA: 0x5702720
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x5703604 Offset: 0x56FF604 VA: 0x5703604
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x57391DC Offset: 0x57351DC VA: 0x57391DC
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x573B2FC Offset: 0x57372FC VA: 0x573B2FC
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D1374 Offset: 0x56CD374 VA: 0x56D1374
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56DC338 Offset: 0x56D8338 VA: 0x56DC338
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56DD834 Offset: 0x56D9834 VA: 0x56DD834
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56E2BE4 Offset: 0x56DEBE4 VA: 0x56E2BE4
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56E41E4 Offset: 0x56E01E4 VA: 0x56E41E4
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56E7140 Offset: 0x56E3140 VA: 0x56E7140
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56E8638 Offset: 0x56E4638 VA: 0x56E8638
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56EBBF8 Offset: 0x56E7BF8 VA: 0x56EBBF8
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56F2AA8 Offset: 0x56EEAA8 VA: 0x56F2AA8
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56F7E08 Offset: 0x56F3E08 VA: 0x56F7E08
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x57006F4 Offset: 0x56FC6F4 VA: 0x57006F4
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x570277C Offset: 0x56FE77C VA: 0x570277C
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5703660 Offset: 0x56FF660 VA: 0x5703660
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5739238 Offset: 0x5735238 VA: 0x5739238
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x573B3AC Offset: 0x57373AC VA: 0x573B3AC
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D13D0 Offset: 0x56CD3D0 VA: 0x56D13D0
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56DC394 Offset: 0x56D8394 VA: 0x56DC394
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56DD890 Offset: 0x56D9890 VA: 0x56DD890
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56E2C44 Offset: 0x56DEC44 VA: 0x56E2C44
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56E4244 Offset: 0x56E0244 VA: 0x56E4244
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56E719C Offset: 0x56E319C VA: 0x56E719C
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56E8694 Offset: 0x56E4694 VA: 0x56E8694
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56EBC54 Offset: 0x56E7C54 VA: 0x56EBC54
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56F2B04 Offset: 0x56EEB04 VA: 0x56F2B04
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56F7E64 Offset: 0x56F3E64 VA: 0x56F7E64
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x5700750 Offset: 0x56FC750 VA: 0x5700750
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x57027D8 Offset: 0x56FE7D8 VA: 0x57027D8
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x57036BC Offset: 0x56FF6BC VA: 0x57036BC
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x5739294 Offset: 0x5735294 VA: 0x5739294
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x573B45C Offset: 0x573745C VA: 0x573B45C
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D17C8 Offset: 0x56CD7C8 VA: 0x56D17C8
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56DC788 Offset: 0x56D8788 VA: 0x56DC788
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56DDC64 Offset: 0x56D9C64 VA: 0x56DDC64
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56E303C Offset: 0x56DF03C VA: 0x56E303C
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56E464C Offset: 0x56E064C VA: 0x56E464C
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56E7594 Offset: 0x56E3594 VA: 0x56E7594
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56E8A8C Offset: 0x56E4A8C VA: 0x56E8A8C
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56EC028 Offset: 0x56E8028 VA: 0x56EC028
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56F2EFC Offset: 0x56EEEFC VA: 0x56F2EFC
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56F8238 Offset: 0x56F4238 VA: 0x56F8238
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x5700B44 Offset: 0x56FCB44 VA: 0x5700B44
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x5702BCC Offset: 0x56FEBCC VA: 0x5702BCC
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x5703A90 Offset: 0x56FFA90 VA: 0x5703A90
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x5739668 Offset: 0x5735668 VA: 0x5739668
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x573B8FC Offset: 0x57378FC VA: 0x573B8FC
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56D17D0 Offset: 0x56CD7D0 VA: 0x56D17D0
	|-OrderedDictionary.ValueCollection<ValueTuple<EntityRef, object>, FP>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56DC790 Offset: 0x56D8790 VA: 0x56DC790
	|-OrderedDictionary.ValueCollection<EntityRef, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56DDC6C Offset: 0x56D9C6C VA: 0x56DDC6C
	|-OrderedDictionary.ValueCollection<EntityRef, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56E3044 Offset: 0x56DF044 VA: 0x56E3044
	|-OrderedDictionary.ValueCollection<int, ValueTuple<object, object, object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56E4654 Offset: 0x56E0654 VA: 0x56E4654
	|-OrderedDictionary.ValueCollection<int, BulletLink>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56E759C Offset: 0x56E359C VA: 0x56E759C
	|-OrderedDictionary.ValueCollection<int, HeroSkillCount>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56E8A94 Offset: 0x56E4A94 VA: 0x56E8A94
	|-OrderedDictionary.ValueCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56EC030 Offset: 0x56E8030 VA: 0x56EC030
	|-OrderedDictionary.ValueCollection<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56F2F04 Offset: 0x56EEF04 VA: 0x56F2F04
	|-OrderedDictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56F8240 Offset: 0x56F4240 VA: 0x56F8240
	|-OrderedDictionary.ValueCollection<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x5700B4C Offset: 0x56FCB4C VA: 0x5700B4C
	|-OrderedDictionary.ValueCollection<object, FP>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x5702BD4 Offset: 0x56FEBD4 VA: 0x5702BD4
	|-OrderedDictionary.ValueCollection<object, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x5703A98 Offset: 0x56FFA98 VA: 0x5703A98
	|-OrderedDictionary.ValueCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x5739670 Offset: 0x5735670 VA: 0x5739670
	|-OrderedDictionary.ValueCollection<ulong, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x573B904 Offset: 0x5737904 VA: 0x573B904
	|-OrderedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/
}

// Namespace: Rock.Collections
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(DictionaryDebugView<K, V>))]
[ComVisible(False)]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class OrderedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback // TypeDefIndex: 24236
{
	// Fields
	private int[] buckets; // 0x0
	private OrderedDictionary.Entry<TKey, TValue>[] entries; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private int m_firstOrderIndex; // 0x0
	private int m_lastOrderIndex; // 0x0
	private int freeList; // 0x0
	private int freeCount; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0
	private OrderedDictionary.KeyCollection<TKey, TValue> keys; // 0x0
	private OrderedDictionary.ValueCollection<TKey, TValue> values; // 0x0
	private object _syncRoot; // 0x0
	private const string VersionName = "Version";
	private const string HashSizeName = "HashSize";
	private const string KeyValuePairsName = "KeyValuePairs";
	private const string ComparerName = "Comparer";
	private const int UnusedHash = -1;
	private const int LastIndex = -1;
	private const int InvalidIndex = -2;

	// Properties
	public OrderedDictionary.Reader<TKey, TValue> Items { get; }
	public OrderedDictionary.ReverseReader<TKey, TValue> Reversed { get; }
	public IEqualityComparer<TKey> Comparer { get; }
	public int Count { get; }
	public OrderedDictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public OrderedDictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	public TValue Item { get; set; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public OrderedDictionary.Reader<TKey, TValue> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52091EC Offset: 0x52051EC VA: 0x52091EC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.get_Items
	|
	|-RVA: 0x520D1F8 Offset: 0x52091F8 VA: 0x520D1F8
	|-OrderedDictionary<EntityRef, int>.get_Items
	|
	|-RVA: 0x5210F78 Offset: 0x520CF78 VA: 0x5210F78
	|-OrderedDictionary<EntityRef, object>.get_Items
	|
	|-RVA: 0x5214D68 Offset: 0x5210D68 VA: 0x5214D68
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.get_Items
	|
	|-RVA: 0x5218E8C Offset: 0x5214E8C VA: 0x5218E8C
	|-OrderedDictionary<int, BulletLink>.get_Items
	|
	|-RVA: 0x521D024 Offset: 0x5219024 VA: 0x521D024
	|-OrderedDictionary<int, HeroSkillCount>.get_Items
	|
	|-RVA: 0x5221158 Offset: 0x521D158 VA: 0x5221158
	|-OrderedDictionary<int, int>.get_Items
	|
	|-RVA: 0x5224F60 Offset: 0x5220F60 VA: 0x5224F60
	|-OrderedDictionary<int, object>.get_Items
	|
	|-RVA: 0x5228D34 Offset: 0x5224D34 VA: 0x5228D34
	|-OrderedDictionary<Int32Enum, int>.get_Items
	|
	|-RVA: 0x522CB4C Offset: 0x5228B4C VA: 0x522CB4C
	|-OrderedDictionary<long, object>.get_Items
	|
	|-RVA: 0x5230924 Offset: 0x522C924 VA: 0x5230924
	|-OrderedDictionary<object, FP>.get_Items
	|
	|-RVA: 0x52346C8 Offset: 0x52306C8 VA: 0x52346C8
	|-OrderedDictionary<object, long>.get_Items
	|
	|-RVA: 0x5238440 Offset: 0x5234440 VA: 0x5238440
	|-OrderedDictionary<object, object>.get_Items
	|
	|-RVA: 0x523C1E8 Offset: 0x52381E8 VA: 0x523C1E8
	|-OrderedDictionary<ulong, object>.get_Items
	|
	|-RVA: 0x523FFC0 Offset: 0x523BFC0 VA: 0x523FFC0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.ReverseReader<TKey, TValue> get_Reversed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520920C Offset: 0x520520C VA: 0x520920C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.get_Reversed
	|
	|-RVA: 0x520D218 Offset: 0x5209218 VA: 0x520D218
	|-OrderedDictionary<EntityRef, int>.get_Reversed
	|
	|-RVA: 0x5210F98 Offset: 0x520CF98 VA: 0x5210F98
	|-OrderedDictionary<EntityRef, object>.get_Reversed
	|
	|-RVA: 0x5214D88 Offset: 0x5210D88 VA: 0x5214D88
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.get_Reversed
	|
	|-RVA: 0x5218EAC Offset: 0x5214EAC VA: 0x5218EAC
	|-OrderedDictionary<int, BulletLink>.get_Reversed
	|
	|-RVA: 0x521D044 Offset: 0x5219044 VA: 0x521D044
	|-OrderedDictionary<int, HeroSkillCount>.get_Reversed
	|
	|-RVA: 0x5221178 Offset: 0x521D178 VA: 0x5221178
	|-OrderedDictionary<int, int>.get_Reversed
	|
	|-RVA: 0x5224F80 Offset: 0x5220F80 VA: 0x5224F80
	|-OrderedDictionary<int, object>.get_Reversed
	|
	|-RVA: 0x5228D54 Offset: 0x5224D54 VA: 0x5228D54
	|-OrderedDictionary<Int32Enum, int>.get_Reversed
	|
	|-RVA: 0x522CB6C Offset: 0x5228B6C VA: 0x522CB6C
	|-OrderedDictionary<long, object>.get_Reversed
	|
	|-RVA: 0x5230944 Offset: 0x522C944 VA: 0x5230944
	|-OrderedDictionary<object, FP>.get_Reversed
	|
	|-RVA: 0x52346E8 Offset: 0x52306E8 VA: 0x52346E8
	|-OrderedDictionary<object, long>.get_Reversed
	|
	|-RVA: 0x5238460 Offset: 0x5234460 VA: 0x5238460
	|-OrderedDictionary<object, object>.get_Reversed
	|
	|-RVA: 0x523C208 Offset: 0x5238208 VA: 0x523C208
	|-OrderedDictionary<ulong, object>.get_Reversed
	|
	|-RVA: 0x523FFE0 Offset: 0x523BFE0 VA: 0x523FFE0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Reversed
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520922C Offset: 0x520522C VA: 0x520922C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x520D238 Offset: 0x5209238 VA: 0x520D238
	|-OrderedDictionary<EntityRef, int>..ctor
	|
	|-RVA: 0x5210FB8 Offset: 0x520CFB8 VA: 0x5210FB8
	|-OrderedDictionary<EntityRef, object>..ctor
	|
	|-RVA: 0x5214DA8 Offset: 0x5210DA8 VA: 0x5214DA8
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x5218ECC Offset: 0x5214ECC VA: 0x5218ECC
	|-OrderedDictionary<int, BulletLink>..ctor
	|
	|-RVA: 0x521D064 Offset: 0x5219064 VA: 0x521D064
	|-OrderedDictionary<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x5221198 Offset: 0x521D198 VA: 0x5221198
	|-OrderedDictionary<int, int>..ctor
	|
	|-RVA: 0x5224FA0 Offset: 0x5220FA0 VA: 0x5224FA0
	|-OrderedDictionary<int, object>..ctor
	|
	|-RVA: 0x5228D74 Offset: 0x5224D74 VA: 0x5228D74
	|-OrderedDictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x522CB8C Offset: 0x5228B8C VA: 0x522CB8C
	|-OrderedDictionary<long, object>..ctor
	|
	|-RVA: 0x5230964 Offset: 0x522C964 VA: 0x5230964
	|-OrderedDictionary<object, FP>..ctor
	|
	|-RVA: 0x5234708 Offset: 0x5230708 VA: 0x5234708
	|-OrderedDictionary<object, long>..ctor
	|
	|-RVA: 0x5238480 Offset: 0x5234480 VA: 0x5238480
	|-OrderedDictionary<object, object>..ctor
	|
	|-RVA: 0x523C228 Offset: 0x5238228 VA: 0x523C228
	|-OrderedDictionary<ulong, object>..ctor
	|
	|-RVA: 0x5240000 Offset: 0x523C000 VA: 0x5240000
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209244 Offset: 0x5205244 VA: 0x5209244
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x520D250 Offset: 0x5209250 VA: 0x520D250
	|-OrderedDictionary<EntityRef, int>..ctor
	|
	|-RVA: 0x5210FD0 Offset: 0x520CFD0 VA: 0x5210FD0
	|-OrderedDictionary<EntityRef, object>..ctor
	|
	|-RVA: 0x5214DC0 Offset: 0x5210DC0 VA: 0x5214DC0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x5218EE4 Offset: 0x5214EE4 VA: 0x5218EE4
	|-OrderedDictionary<int, BulletLink>..ctor
	|
	|-RVA: 0x521D07C Offset: 0x521907C VA: 0x521D07C
	|-OrderedDictionary<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x52211B0 Offset: 0x521D1B0 VA: 0x52211B0
	|-OrderedDictionary<int, int>..ctor
	|
	|-RVA: 0x5224FB8 Offset: 0x5220FB8 VA: 0x5224FB8
	|-OrderedDictionary<int, object>..ctor
	|
	|-RVA: 0x5228D8C Offset: 0x5224D8C VA: 0x5228D8C
	|-OrderedDictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x522CBA4 Offset: 0x5228BA4 VA: 0x522CBA4
	|-OrderedDictionary<long, object>..ctor
	|
	|-RVA: 0x523097C Offset: 0x522C97C VA: 0x523097C
	|-OrderedDictionary<object, FP>..ctor
	|
	|-RVA: 0x5234720 Offset: 0x5230720 VA: 0x5234720
	|-OrderedDictionary<object, long>..ctor
	|
	|-RVA: 0x5238498 Offset: 0x5234498 VA: 0x5238498
	|-OrderedDictionary<object, object>..ctor
	|
	|-RVA: 0x523C240 Offset: 0x5238240 VA: 0x523C240
	|-OrderedDictionary<ulong, object>..ctor
	|
	|-RVA: 0x524001C Offset: 0x523C01C VA: 0x524001C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209258 Offset: 0x5205258 VA: 0x5209258
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x520D264 Offset: 0x5209264 VA: 0x520D264
	|-OrderedDictionary<EntityRef, int>..ctor
	|
	|-RVA: 0x5210FE4 Offset: 0x520CFE4 VA: 0x5210FE4
	|-OrderedDictionary<EntityRef, object>..ctor
	|
	|-RVA: 0x5214DD4 Offset: 0x5210DD4 VA: 0x5214DD4
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x5218EF8 Offset: 0x5214EF8 VA: 0x5218EF8
	|-OrderedDictionary<int, BulletLink>..ctor
	|
	|-RVA: 0x521D090 Offset: 0x5219090 VA: 0x521D090
	|-OrderedDictionary<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x52211C4 Offset: 0x521D1C4 VA: 0x52211C4
	|-OrderedDictionary<int, int>..ctor
	|
	|-RVA: 0x5224FCC Offset: 0x5220FCC VA: 0x5224FCC
	|-OrderedDictionary<int, object>..ctor
	|
	|-RVA: 0x5228DA0 Offset: 0x5224DA0 VA: 0x5228DA0
	|-OrderedDictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x522CBB8 Offset: 0x5228BB8 VA: 0x522CBB8
	|-OrderedDictionary<long, object>..ctor
	|
	|-RVA: 0x5230990 Offset: 0x522C990 VA: 0x5230990
	|-OrderedDictionary<object, FP>..ctor
	|
	|-RVA: 0x5234734 Offset: 0x5230734 VA: 0x5234734
	|-OrderedDictionary<object, long>..ctor
	|
	|-RVA: 0x52384AC Offset: 0x52344AC VA: 0x52384AC
	|-OrderedDictionary<object, object>..ctor
	|
	|-RVA: 0x523C254 Offset: 0x5238254 VA: 0x523C254
	|-OrderedDictionary<ulong, object>..ctor
	|
	|-RVA: 0x5240034 Offset: 0x523C034 VA: 0x5240034
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209274 Offset: 0x5205274 VA: 0x5209274
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x520D280 Offset: 0x5209280 VA: 0x520D280
	|-OrderedDictionary<EntityRef, int>..ctor
	|
	|-RVA: 0x5211000 Offset: 0x520D000 VA: 0x5211000
	|-OrderedDictionary<EntityRef, object>..ctor
	|
	|-RVA: 0x5214DF0 Offset: 0x5210DF0 VA: 0x5214DF0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x5218F14 Offset: 0x5214F14 VA: 0x5218F14
	|-OrderedDictionary<int, BulletLink>..ctor
	|
	|-RVA: 0x521D0AC Offset: 0x52190AC VA: 0x521D0AC
	|-OrderedDictionary<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x52211E0 Offset: 0x521D1E0 VA: 0x52211E0
	|-OrderedDictionary<int, int>..ctor
	|
	|-RVA: 0x5224FE8 Offset: 0x5220FE8 VA: 0x5224FE8
	|-OrderedDictionary<int, object>..ctor
	|
	|-RVA: 0x5228DBC Offset: 0x5224DBC VA: 0x5228DBC
	|-OrderedDictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x522CBD4 Offset: 0x5228BD4 VA: 0x522CBD4
	|-OrderedDictionary<long, object>..ctor
	|
	|-RVA: 0x52309AC Offset: 0x522C9AC VA: 0x52309AC
	|-OrderedDictionary<object, FP>..ctor
	|
	|-RVA: 0x5234750 Offset: 0x5230750 VA: 0x5234750
	|-OrderedDictionary<object, long>..ctor
	|
	|-RVA: 0x52384C8 Offset: 0x52344C8 VA: 0x52384C8
	|-OrderedDictionary<object, object>..ctor
	|
	|-RVA: 0x523C270 Offset: 0x5238270 VA: 0x523C270
	|-OrderedDictionary<ulong, object>..ctor
	|
	|-RVA: 0x5240054 Offset: 0x523C054 VA: 0x5240054
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209374 Offset: 0x5205374 VA: 0x5209374
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x520D380 Offset: 0x5209380 VA: 0x520D380
	|-OrderedDictionary<EntityRef, int>..ctor
	|
	|-RVA: 0x5211100 Offset: 0x520D100 VA: 0x5211100
	|-OrderedDictionary<EntityRef, object>..ctor
	|
	|-RVA: 0x5214EF0 Offset: 0x5210EF0 VA: 0x5214EF0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x5219014 Offset: 0x5215014 VA: 0x5219014
	|-OrderedDictionary<int, BulletLink>..ctor
	|
	|-RVA: 0x521D1AC Offset: 0x52191AC VA: 0x521D1AC
	|-OrderedDictionary<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x52212E0 Offset: 0x521D2E0 VA: 0x52212E0
	|-OrderedDictionary<int, int>..ctor
	|
	|-RVA: 0x52250E8 Offset: 0x52210E8 VA: 0x52250E8
	|-OrderedDictionary<int, object>..ctor
	|
	|-RVA: 0x5228EBC Offset: 0x5224EBC VA: 0x5228EBC
	|-OrderedDictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x522CCD4 Offset: 0x5228CD4 VA: 0x522CCD4
	|-OrderedDictionary<long, object>..ctor
	|
	|-RVA: 0x5230AAC Offset: 0x522CAAC VA: 0x5230AAC
	|-OrderedDictionary<object, FP>..ctor
	|
	|-RVA: 0x5234850 Offset: 0x5230850 VA: 0x5234850
	|-OrderedDictionary<object, long>..ctor
	|
	|-RVA: 0x52385C8 Offset: 0x52345C8 VA: 0x52385C8
	|-OrderedDictionary<object, object>..ctor
	|
	|-RVA: 0x523C370 Offset: 0x5238370 VA: 0x523C370
	|-OrderedDictionary<ulong, object>..ctor
	|
	|-RVA: 0x524015C Offset: 0x523C15C VA: 0x524015C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209388 Offset: 0x5205388 VA: 0x5209388
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x520D394 Offset: 0x5209394 VA: 0x520D394
	|-OrderedDictionary<EntityRef, int>..ctor
	|
	|-RVA: 0x5211114 Offset: 0x520D114 VA: 0x5211114
	|-OrderedDictionary<EntityRef, object>..ctor
	|
	|-RVA: 0x5214F04 Offset: 0x5210F04 VA: 0x5214F04
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x5219028 Offset: 0x5215028 VA: 0x5219028
	|-OrderedDictionary<int, BulletLink>..ctor
	|
	|-RVA: 0x521D1C0 Offset: 0x52191C0 VA: 0x521D1C0
	|-OrderedDictionary<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x52212F4 Offset: 0x521D2F4 VA: 0x52212F4
	|-OrderedDictionary<int, int>..ctor
	|
	|-RVA: 0x52250FC Offset: 0x52210FC VA: 0x52250FC
	|-OrderedDictionary<int, object>..ctor
	|
	|-RVA: 0x5228ED0 Offset: 0x5224ED0 VA: 0x5228ED0
	|-OrderedDictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x522CCE8 Offset: 0x5228CE8 VA: 0x522CCE8
	|-OrderedDictionary<long, object>..ctor
	|
	|-RVA: 0x5230AC0 Offset: 0x522CAC0 VA: 0x5230AC0
	|-OrderedDictionary<object, FP>..ctor
	|
	|-RVA: 0x5234864 Offset: 0x5230864 VA: 0x5234864
	|-OrderedDictionary<object, long>..ctor
	|
	|-RVA: 0x52385DC Offset: 0x52345DC VA: 0x52385DC
	|-OrderedDictionary<object, object>..ctor
	|
	|-RVA: 0x523C384 Offset: 0x5238384 VA: 0x523C384
	|-OrderedDictionary<ulong, object>..ctor
	|
	|-RVA: 0x5240174 Offset: 0x523C174 VA: 0x5240174
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52099AC Offset: 0x52059AC VA: 0x52099AC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>..ctor
	|
	|-RVA: 0x520D9BC Offset: 0x52099BC VA: 0x520D9BC
	|-OrderedDictionary<EntityRef, int>..ctor
	|
	|-RVA: 0x5211738 Offset: 0x520D738 VA: 0x5211738
	|-OrderedDictionary<EntityRef, object>..ctor
	|
	|-RVA: 0x52155B0 Offset: 0x52115B0 VA: 0x52155B0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x52196B8 Offset: 0x52156B8 VA: 0x52196B8
	|-OrderedDictionary<int, BulletLink>..ctor
	|
	|-RVA: 0x521D7F8 Offset: 0x52197F8 VA: 0x521D7F8
	|-OrderedDictionary<int, HeroSkillCount>..ctor
	|
	|-RVA: 0x5221900 Offset: 0x521D900 VA: 0x5221900
	|-OrderedDictionary<int, int>..ctor
	|
	|-RVA: 0x5225724 Offset: 0x5221724 VA: 0x5225724
	|-OrderedDictionary<int, object>..ctor
	|
	|-RVA: 0x52294DC Offset: 0x52254DC VA: 0x52294DC
	|-OrderedDictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x522D30C Offset: 0x522930C VA: 0x522D30C
	|-OrderedDictionary<long, object>..ctor
	|
	|-RVA: 0x52310E4 Offset: 0x522D0E4 VA: 0x52310E4
	|-OrderedDictionary<object, FP>..ctor
	|
	|-RVA: 0x5234E88 Offset: 0x5230E88 VA: 0x5234E88
	|-OrderedDictionary<object, long>..ctor
	|
	|-RVA: 0x5238C00 Offset: 0x5234C00 VA: 0x5238C00
	|-OrderedDictionary<object, object>..ctor
	|
	|-RVA: 0x523C9A8 Offset: 0x52389A8 VA: 0x523C9A8
	|-OrderedDictionary<ulong, object>..ctor
	|
	|-RVA: 0x5240A78 Offset: 0x523CA78 VA: 0x5240A78
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<TKey> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209A44 Offset: 0x5205A44 VA: 0x5209A44
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.get_Comparer
	|
	|-RVA: 0x520DA54 Offset: 0x5209A54 VA: 0x520DA54
	|-OrderedDictionary<EntityRef, int>.get_Comparer
	|
	|-RVA: 0x52117D0 Offset: 0x520D7D0 VA: 0x52117D0
	|-OrderedDictionary<EntityRef, object>.get_Comparer
	|
	|-RVA: 0x5215648 Offset: 0x5211648 VA: 0x5215648
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.get_Comparer
	|
	|-RVA: 0x5219750 Offset: 0x5215750 VA: 0x5219750
	|-OrderedDictionary<int, BulletLink>.get_Comparer
	|
	|-RVA: 0x521D890 Offset: 0x5219890 VA: 0x521D890
	|-OrderedDictionary<int, HeroSkillCount>.get_Comparer
	|
	|-RVA: 0x5221998 Offset: 0x521D998 VA: 0x5221998
	|-OrderedDictionary<int, int>.get_Comparer
	|
	|-RVA: 0x52257BC Offset: 0x52217BC VA: 0x52257BC
	|-OrderedDictionary<int, object>.get_Comparer
	|
	|-RVA: 0x5229574 Offset: 0x5225574 VA: 0x5229574
	|-OrderedDictionary<Int32Enum, int>.get_Comparer
	|
	|-RVA: 0x522D3A4 Offset: 0x52293A4 VA: 0x522D3A4
	|-OrderedDictionary<long, object>.get_Comparer
	|
	|-RVA: 0x523117C Offset: 0x522D17C VA: 0x523117C
	|-OrderedDictionary<object, FP>.get_Comparer
	|
	|-RVA: 0x5234F20 Offset: 0x5230F20 VA: 0x5234F20
	|-OrderedDictionary<object, long>.get_Comparer
	|
	|-RVA: 0x5238C98 Offset: 0x5234C98 VA: 0x5238C98
	|-OrderedDictionary<object, object>.get_Comparer
	|
	|-RVA: 0x523CA40 Offset: 0x5238A40 VA: 0x523CA40
	|-OrderedDictionary<ulong, object>.get_Comparer
	|
	|-RVA: 0x5240B10 Offset: 0x523CB10 VA: 0x5240B10
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209A4C Offset: 0x5205A4C VA: 0x5209A4C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.get_Count
	|
	|-RVA: 0x520DA5C Offset: 0x5209A5C VA: 0x520DA5C
	|-OrderedDictionary<EntityRef, int>.get_Count
	|
	|-RVA: 0x52117D8 Offset: 0x520D7D8 VA: 0x52117D8
	|-OrderedDictionary<EntityRef, object>.get_Count
	|
	|-RVA: 0x5215650 Offset: 0x5211650 VA: 0x5215650
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.get_Count
	|
	|-RVA: 0x5219758 Offset: 0x5215758 VA: 0x5219758
	|-OrderedDictionary<int, BulletLink>.get_Count
	|
	|-RVA: 0x521D898 Offset: 0x5219898 VA: 0x521D898
	|-OrderedDictionary<int, HeroSkillCount>.get_Count
	|
	|-RVA: 0x52219A0 Offset: 0x521D9A0 VA: 0x52219A0
	|-OrderedDictionary<int, int>.get_Count
	|
	|-RVA: 0x52257C4 Offset: 0x52217C4 VA: 0x52257C4
	|-OrderedDictionary<int, object>.get_Count
	|
	|-RVA: 0x522957C Offset: 0x522557C VA: 0x522957C
	|-OrderedDictionary<Int32Enum, int>.get_Count
	|
	|-RVA: 0x522D3AC Offset: 0x52293AC VA: 0x522D3AC
	|-OrderedDictionary<long, object>.get_Count
	|
	|-RVA: 0x5231184 Offset: 0x522D184 VA: 0x5231184
	|-OrderedDictionary<object, FP>.get_Count
	|
	|-RVA: 0x5234F28 Offset: 0x5230F28 VA: 0x5234F28
	|-OrderedDictionary<object, long>.get_Count
	|
	|-RVA: 0x5238CA0 Offset: 0x5234CA0 VA: 0x5238CA0
	|-OrderedDictionary<object, object>.get_Count
	|
	|-RVA: 0x523CA48 Offset: 0x5238A48 VA: 0x523CA48
	|-OrderedDictionary<ulong, object>.get_Count
	|
	|-RVA: 0x5240B18 Offset: 0x523CB18 VA: 0x5240B18
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209A5C Offset: 0x5205A5C VA: 0x5209A5C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.get_Keys
	|
	|-RVA: 0x520DA6C Offset: 0x5209A6C VA: 0x520DA6C
	|-OrderedDictionary<EntityRef, int>.get_Keys
	|
	|-RVA: 0x52117E8 Offset: 0x520D7E8 VA: 0x52117E8
	|-OrderedDictionary<EntityRef, object>.get_Keys
	|
	|-RVA: 0x5215660 Offset: 0x5211660 VA: 0x5215660
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.get_Keys
	|
	|-RVA: 0x5219768 Offset: 0x5215768 VA: 0x5219768
	|-OrderedDictionary<int, BulletLink>.get_Keys
	|
	|-RVA: 0x521D8A8 Offset: 0x52198A8 VA: 0x521D8A8
	|-OrderedDictionary<int, HeroSkillCount>.get_Keys
	|
	|-RVA: 0x52219B0 Offset: 0x521D9B0 VA: 0x52219B0
	|-OrderedDictionary<int, int>.get_Keys
	|
	|-RVA: 0x52257D4 Offset: 0x52217D4 VA: 0x52257D4
	|-OrderedDictionary<int, object>.get_Keys
	|
	|-RVA: 0x522958C Offset: 0x522558C VA: 0x522958C
	|-OrderedDictionary<Int32Enum, int>.get_Keys
	|
	|-RVA: 0x522D3BC Offset: 0x52293BC VA: 0x522D3BC
	|-OrderedDictionary<long, object>.get_Keys
	|
	|-RVA: 0x5231194 Offset: 0x522D194 VA: 0x5231194
	|-OrderedDictionary<object, FP>.get_Keys
	|
	|-RVA: 0x5234F38 Offset: 0x5230F38 VA: 0x5234F38
	|-OrderedDictionary<object, long>.get_Keys
	|
	|-RVA: 0x5238CB0 Offset: 0x5234CB0 VA: 0x5238CB0
	|-OrderedDictionary<object, object>.get_Keys
	|
	|-RVA: 0x523CA58 Offset: 0x5238A58 VA: 0x523CA58
	|-OrderedDictionary<ulong, object>.get_Keys
	|
	|-RVA: 0x5240B28 Offset: 0x523CB28 VA: 0x5240B28
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209ACC Offset: 0x5205ACC VA: 0x5209ACC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x520DADC Offset: 0x5209ADC VA: 0x520DADC
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5211858 Offset: 0x520D858 VA: 0x5211858
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x52156D0 Offset: 0x52116D0 VA: 0x52156D0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x52197D8 Offset: 0x52157D8 VA: 0x52197D8
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x521D918 Offset: 0x5219918 VA: 0x521D918
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5221A20 Offset: 0x521DA20 VA: 0x5221A20
	|-OrderedDictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5225844 Offset: 0x5221844 VA: 0x5225844
	|-OrderedDictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x52295FC Offset: 0x52255FC VA: 0x52295FC
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x522D42C Offset: 0x522942C VA: 0x522D42C
	|-OrderedDictionary<long, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5231204 Offset: 0x522D204 VA: 0x5231204
	|-OrderedDictionary<object, FP>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5234FA8 Offset: 0x5230FA8 VA: 0x5234FA8
	|-OrderedDictionary<object, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5238D20 Offset: 0x5234D20 VA: 0x5238D20
	|-OrderedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x523CAC8 Offset: 0x5238AC8 VA: 0x523CAC8
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5240B9C Offset: 0x523CB9C VA: 0x5240B9C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209B3C Offset: 0x5205B3C VA: 0x5209B3C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x520DB4C Offset: 0x5209B4C VA: 0x520DB4C
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x52118C8 Offset: 0x520D8C8 VA: 0x52118C8
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5215740 Offset: 0x5211740 VA: 0x5215740
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5219848 Offset: 0x5215848 VA: 0x5219848
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x521D988 Offset: 0x5219988 VA: 0x521D988
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5221A90 Offset: 0x521DA90 VA: 0x5221A90
	|-OrderedDictionary<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x52258B4 Offset: 0x52218B4 VA: 0x52258B4
	|-OrderedDictionary<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x522966C Offset: 0x522566C VA: 0x522966C
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x522D49C Offset: 0x522949C VA: 0x522D49C
	|-OrderedDictionary<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5231274 Offset: 0x522D274 VA: 0x5231274
	|-OrderedDictionary<object, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5235018 Offset: 0x5231018 VA: 0x5235018
	|-OrderedDictionary<object, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5238D90 Offset: 0x5234D90 VA: 0x5238D90
	|-OrderedDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x523CB38 Offset: 0x5238B38 VA: 0x523CB38
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x5240C10 Offset: 0x523CC10 VA: 0x5240C10
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209BAC Offset: 0x5205BAC VA: 0x5209BAC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.get_Values
	|
	|-RVA: 0x520DBBC Offset: 0x5209BBC VA: 0x520DBBC
	|-OrderedDictionary<EntityRef, int>.get_Values
	|
	|-RVA: 0x5211938 Offset: 0x520D938 VA: 0x5211938
	|-OrderedDictionary<EntityRef, object>.get_Values
	|
	|-RVA: 0x52157B0 Offset: 0x52117B0 VA: 0x52157B0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.get_Values
	|
	|-RVA: 0x52198B8 Offset: 0x52158B8 VA: 0x52198B8
	|-OrderedDictionary<int, BulletLink>.get_Values
	|
	|-RVA: 0x521D9F8 Offset: 0x52199F8 VA: 0x521D9F8
	|-OrderedDictionary<int, HeroSkillCount>.get_Values
	|
	|-RVA: 0x5221B00 Offset: 0x521DB00 VA: 0x5221B00
	|-OrderedDictionary<int, int>.get_Values
	|
	|-RVA: 0x5225924 Offset: 0x5221924 VA: 0x5225924
	|-OrderedDictionary<int, object>.get_Values
	|
	|-RVA: 0x52296DC Offset: 0x52256DC VA: 0x52296DC
	|-OrderedDictionary<Int32Enum, int>.get_Values
	|
	|-RVA: 0x522D50C Offset: 0x522950C VA: 0x522D50C
	|-OrderedDictionary<long, object>.get_Values
	|
	|-RVA: 0x52312E4 Offset: 0x522D2E4 VA: 0x52312E4
	|-OrderedDictionary<object, FP>.get_Values
	|
	|-RVA: 0x5235088 Offset: 0x5231088 VA: 0x5235088
	|-OrderedDictionary<object, long>.get_Values
	|
	|-RVA: 0x5238E00 Offset: 0x5234E00 VA: 0x5238E00
	|-OrderedDictionary<object, object>.get_Values
	|
	|-RVA: 0x523CBA8 Offset: 0x5238BA8 VA: 0x523CBA8
	|-OrderedDictionary<ulong, object>.get_Values
	|
	|-RVA: 0x5240C84 Offset: 0x523CC84 VA: 0x5240C84
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209C1C Offset: 0x5205C1C VA: 0x5209C1C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x520DC2C Offset: 0x5209C2C VA: 0x520DC2C
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x52119A8 Offset: 0x520D9A8 VA: 0x52119A8
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5215820 Offset: 0x5211820 VA: 0x5215820
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5219928 Offset: 0x5215928 VA: 0x5219928
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x521DA68 Offset: 0x5219A68 VA: 0x521DA68
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5221B70 Offset: 0x521DB70 VA: 0x5221B70
	|-OrderedDictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5225994 Offset: 0x5221994 VA: 0x5225994
	|-OrderedDictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x522974C Offset: 0x522574C VA: 0x522974C
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x522D57C Offset: 0x522957C VA: 0x522D57C
	|-OrderedDictionary<long, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5231354 Offset: 0x522D354 VA: 0x5231354
	|-OrderedDictionary<object, FP>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x52350F8 Offset: 0x52310F8 VA: 0x52350F8
	|-OrderedDictionary<object, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5238E70 Offset: 0x5234E70 VA: 0x5238E70
	|-OrderedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x523CC18 Offset: 0x5238C18 VA: 0x523CC18
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5240CF8 Offset: 0x523CCF8 VA: 0x5240CF8
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209C8C Offset: 0x5205C8C VA: 0x5209C8C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x520DC9C Offset: 0x5209C9C VA: 0x520DC9C
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5211A18 Offset: 0x520DA18 VA: 0x5211A18
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5215890 Offset: 0x5211890 VA: 0x5215890
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5219998 Offset: 0x5215998 VA: 0x5219998
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x521DAD8 Offset: 0x5219AD8 VA: 0x521DAD8
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5221BE0 Offset: 0x521DBE0 VA: 0x5221BE0
	|-OrderedDictionary<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5225A04 Offset: 0x5221A04 VA: 0x5225A04
	|-OrderedDictionary<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x52297BC Offset: 0x52257BC VA: 0x52297BC
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x522D5EC Offset: 0x52295EC VA: 0x522D5EC
	|-OrderedDictionary<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x52313C4 Offset: 0x522D3C4 VA: 0x52313C4
	|-OrderedDictionary<object, FP>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5235168 Offset: 0x5231168 VA: 0x5235168
	|-OrderedDictionary<object, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5238EE0 Offset: 0x5234EE0 VA: 0x5238EE0
	|-OrderedDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x523CC88 Offset: 0x5238C88 VA: 0x523CC88
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x5240D6C Offset: 0x523CD6C VA: 0x5240D6C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209CFC Offset: 0x5205CFC VA: 0x5209CFC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.get_Item
	|
	|-RVA: 0x520DD0C Offset: 0x5209D0C VA: 0x520DD0C
	|-OrderedDictionary<EntityRef, int>.get_Item
	|
	|-RVA: 0x5211A88 Offset: 0x520DA88 VA: 0x5211A88
	|-OrderedDictionary<EntityRef, object>.get_Item
	|
	|-RVA: 0x5215900 Offset: 0x5211900 VA: 0x5215900
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.get_Item
	|
	|-RVA: 0x5219A08 Offset: 0x5215A08 VA: 0x5219A08
	|-OrderedDictionary<int, BulletLink>.get_Item
	|
	|-RVA: 0x521DB48 Offset: 0x5219B48 VA: 0x521DB48
	|-OrderedDictionary<int, HeroSkillCount>.get_Item
	|
	|-RVA: 0x5221C50 Offset: 0x521DC50 VA: 0x5221C50
	|-OrderedDictionary<int, int>.get_Item
	|
	|-RVA: 0x5225A74 Offset: 0x5221A74 VA: 0x5225A74
	|-OrderedDictionary<int, object>.get_Item
	|
	|-RVA: 0x522982C Offset: 0x522582C VA: 0x522982C
	|-OrderedDictionary<Int32Enum, int>.get_Item
	|
	|-RVA: 0x522D65C Offset: 0x522965C VA: 0x522D65C
	|-OrderedDictionary<long, object>.get_Item
	|
	|-RVA: 0x5231434 Offset: 0x522D434 VA: 0x5231434
	|-OrderedDictionary<object, FP>.get_Item
	|
	|-RVA: 0x52351D8 Offset: 0x52311D8 VA: 0x52351D8
	|-OrderedDictionary<object, long>.get_Item
	|
	|-RVA: 0x5238F50 Offset: 0x5234F50 VA: 0x5238F50
	|-OrderedDictionary<object, object>.get_Item
	|
	|-RVA: 0x523CCF8 Offset: 0x5238CF8 VA: 0x523CCF8
	|-OrderedDictionary<ulong, object>.get_Item
	|
	|-RVA: 0x5240DE0 Offset: 0x523CDE0 VA: 0x5240DE0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209D7C Offset: 0x5205D7C VA: 0x5209D7C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.set_Item
	|
	|-RVA: 0x520DD8C Offset: 0x5209D8C VA: 0x520DD8C
	|-OrderedDictionary<EntityRef, int>.set_Item
	|
	|-RVA: 0x5211B08 Offset: 0x520DB08 VA: 0x5211B08
	|-OrderedDictionary<EntityRef, object>.set_Item
	|
	|-RVA: 0x5215988 Offset: 0x5211988 VA: 0x5215988
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.set_Item
	|
	|-RVA: 0x5219A9C Offset: 0x5215A9C VA: 0x5219A9C
	|-OrderedDictionary<int, BulletLink>.set_Item
	|
	|-RVA: 0x521DBC8 Offset: 0x5219BC8 VA: 0x521DBC8
	|-OrderedDictionary<int, HeroSkillCount>.set_Item
	|
	|-RVA: 0x5221CD0 Offset: 0x521DCD0 VA: 0x5221CD0
	|-OrderedDictionary<int, int>.set_Item
	|
	|-RVA: 0x5225AF4 Offset: 0x5221AF4 VA: 0x5225AF4
	|-OrderedDictionary<int, object>.set_Item
	|
	|-RVA: 0x52298AC Offset: 0x52258AC VA: 0x52298AC
	|-OrderedDictionary<Int32Enum, int>.set_Item
	|
	|-RVA: 0x522D6DC Offset: 0x52296DC VA: 0x522D6DC
	|-OrderedDictionary<long, object>.set_Item
	|
	|-RVA: 0x52314B4 Offset: 0x522D4B4 VA: 0x52314B4
	|-OrderedDictionary<object, FP>.set_Item
	|
	|-RVA: 0x5235258 Offset: 0x5231258 VA: 0x5235258
	|-OrderedDictionary<object, long>.set_Item
	|
	|-RVA: 0x5238FD0 Offset: 0x5234FD0 VA: 0x5238FD0
	|-OrderedDictionary<object, object>.set_Item
	|
	|-RVA: 0x523CD78 Offset: 0x5238D78 VA: 0x523CD78
	|-OrderedDictionary<ulong, object>.set_Item
	|
	|-RVA: 0x5240F6C Offset: 0x523CF6C VA: 0x5240F6C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209D90 Offset: 0x5205D90 VA: 0x5209D90
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.Add
	|
	|-RVA: 0x520DDA0 Offset: 0x5209DA0 VA: 0x520DDA0
	|-OrderedDictionary<EntityRef, int>.Add
	|
	|-RVA: 0x5211B1C Offset: 0x520DB1C VA: 0x5211B1C
	|-OrderedDictionary<EntityRef, object>.Add
	|
	|-RVA: 0x52159C0 Offset: 0x52119C0 VA: 0x52159C0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.Add
	|
	|-RVA: 0x5219AE8 Offset: 0x5215AE8 VA: 0x5219AE8
	|-OrderedDictionary<int, BulletLink>.Add
	|
	|-RVA: 0x521DBDC Offset: 0x5219BDC VA: 0x521DBDC
	|-OrderedDictionary<int, HeroSkillCount>.Add
	|
	|-RVA: 0x5221CE4 Offset: 0x521DCE4 VA: 0x5221CE4
	|-OrderedDictionary<int, int>.Add
	|
	|-RVA: 0x5225B08 Offset: 0x5221B08 VA: 0x5225B08
	|-OrderedDictionary<int, object>.Add
	|
	|-RVA: 0x52298C0 Offset: 0x52258C0 VA: 0x52298C0
	|-OrderedDictionary<Int32Enum, int>.Add
	|
	|-RVA: 0x522D6F0 Offset: 0x52296F0 VA: 0x522D6F0
	|-OrderedDictionary<long, object>.Add
	|
	|-RVA: 0x52314C8 Offset: 0x522D4C8 VA: 0x52314C8
	|-OrderedDictionary<object, FP>.Add
	|
	|-RVA: 0x523526C Offset: 0x523126C VA: 0x523526C
	|-OrderedDictionary<object, long>.Add
	|
	|-RVA: 0x5238FE4 Offset: 0x5234FE4 VA: 0x5238FE4
	|-OrderedDictionary<object, object>.Add
	|
	|-RVA: 0x523CD8C Offset: 0x5238D8C VA: 0x523CD8C
	|-OrderedDictionary<ulong, object>.Add
	|
	|-RVA: 0x524109C Offset: 0x523D09C VA: 0x524109C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209DA4 Offset: 0x5205DA4 VA: 0x5209DA4
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x520DDB4 Offset: 0x5209DB4 VA: 0x520DDB4
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x5211B30 Offset: 0x520DB30 VA: 0x5211B30
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x52159F8 Offset: 0x52119F8 VA: 0x52159F8
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x5219B34 Offset: 0x5215B34 VA: 0x5219B34
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x521DBF0 Offset: 0x5219BF0 VA: 0x521DBF0
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x5221CF8 Offset: 0x521DCF8 VA: 0x5221CF8
	|-OrderedDictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x5225B1C Offset: 0x5221B1C VA: 0x5225B1C
	|-OrderedDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x52298D4 Offset: 0x52258D4 VA: 0x52298D4
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x522D704 Offset: 0x5229704 VA: 0x522D704
	|-OrderedDictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x52314DC Offset: 0x522D4DC VA: 0x52314DC
	|-OrderedDictionary<object, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x5235280 Offset: 0x5231280 VA: 0x5235280
	|-OrderedDictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x5238FF8 Offset: 0x5234FF8 VA: 0x5238FF8
	|-OrderedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x523CDA0 Offset: 0x5238DA0 VA: 0x523CDA0
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x52411D0 Offset: 0x523D1D0 VA: 0x52411D0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209DD0 Offset: 0x5205DD0 VA: 0x5209DD0
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x520DDD4 Offset: 0x5209DD4 VA: 0x520DDD4
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x5211B50 Offset: 0x520DB50 VA: 0x5211B50
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x5215A44 Offset: 0x5211A44 VA: 0x5215A44
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x5219B94 Offset: 0x5215B94 VA: 0x5219B94
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x521DC20 Offset: 0x5219C20 VA: 0x521DC20
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x5221D1C Offset: 0x521DD1C VA: 0x5221D1C
	|-OrderedDictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x5225B3C Offset: 0x5221B3C VA: 0x5225B3C
	|-OrderedDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x52298F8 Offset: 0x52258F8 VA: 0x52298F8
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x522D724 Offset: 0x5229724 VA: 0x522D724
	|-OrderedDictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x52314FC Offset: 0x522D4FC VA: 0x52314FC
	|-OrderedDictionary<object, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x52352A0 Offset: 0x52312A0 VA: 0x52352A0
	|-OrderedDictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x5239018 Offset: 0x5235018 VA: 0x5239018
	|-OrderedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x523CDC0 Offset: 0x5238DC0 VA: 0x523CDC0
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x52412FC Offset: 0x523D2FC VA: 0x52412FC
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209E74 Offset: 0x5205E74 VA: 0x5209E74
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x520DE70 Offset: 0x5209E70 VA: 0x520DE70
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x5211BEC Offset: 0x520DBEC VA: 0x5211BEC
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x5215B14 Offset: 0x5211B14 VA: 0x5215B14
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x5219C88 Offset: 0x5215C88 VA: 0x5219C88
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x521DCC0 Offset: 0x5219CC0 VA: 0x521DCC0
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x5221DB8 Offset: 0x521DDB8 VA: 0x5221DB8
	|-OrderedDictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x5225BD8 Offset: 0x5221BD8 VA: 0x5225BD8
	|-OrderedDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x5229994 Offset: 0x5225994 VA: 0x5229994
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x522D7C0 Offset: 0x52297C0 VA: 0x522D7C0
	|-OrderedDictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x5231598 Offset: 0x522D598 VA: 0x5231598
	|-OrderedDictionary<object, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x523533C Offset: 0x523133C VA: 0x523533C
	|-OrderedDictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x52390B4 Offset: 0x52350B4 VA: 0x52390B4
	|-OrderedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x523CE5C Offset: 0x5238E5C VA: 0x523CE5C
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x52414F8 Offset: 0x523D4F8 VA: 0x52414F8
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209F30 Offset: 0x5205F30 VA: 0x5209F30
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.Clear
	|
	|-RVA: 0x520DF28 Offset: 0x5209F28 VA: 0x520DF28
	|-OrderedDictionary<EntityRef, int>.Clear
	|
	|-RVA: 0x5211CA4 Offset: 0x520DCA4 VA: 0x5211CA4
	|-OrderedDictionary<EntityRef, object>.Clear
	|
	|-RVA: 0x5215BFC Offset: 0x5211BFC VA: 0x5215BFC
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.Clear
	|
	|-RVA: 0x5219D94 Offset: 0x5215D94 VA: 0x5219D94
	|-OrderedDictionary<int, BulletLink>.Clear
	|
	|-RVA: 0x521DD84 Offset: 0x5219D84 VA: 0x521DD84
	|-OrderedDictionary<int, HeroSkillCount>.Clear
	|
	|-RVA: 0x5221E6C Offset: 0x521DE6C VA: 0x5221E6C
	|-OrderedDictionary<int, int>.Clear
	|
	|-RVA: 0x5225C90 Offset: 0x5221C90 VA: 0x5225C90
	|-OrderedDictionary<int, object>.Clear
	|
	|-RVA: 0x5229A48 Offset: 0x5225A48 VA: 0x5229A48
	|-OrderedDictionary<Int32Enum, int>.Clear
	|
	|-RVA: 0x522D878 Offset: 0x5229878 VA: 0x522D878
	|-OrderedDictionary<long, object>.Clear
	|
	|-RVA: 0x5231650 Offset: 0x522D650 VA: 0x5231650
	|-OrderedDictionary<object, FP>.Clear
	|
	|-RVA: 0x52353F4 Offset: 0x52313F4 VA: 0x52353F4
	|-OrderedDictionary<object, long>.Clear
	|
	|-RVA: 0x523916C Offset: 0x523516C VA: 0x523916C
	|-OrderedDictionary<object, object>.Clear
	|
	|-RVA: 0x523CF14 Offset: 0x5238F14 VA: 0x523CF14
	|-OrderedDictionary<ulong, object>.Clear
	|
	|-RVA: 0x5241760 Offset: 0x523D760 VA: 0x5241760
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209FC0 Offset: 0x5205FC0 VA: 0x5209FC0
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.ContainsKey
	|
	|-RVA: 0x520DFB8 Offset: 0x5209FB8 VA: 0x520DFB8
	|-OrderedDictionary<EntityRef, int>.ContainsKey
	|
	|-RVA: 0x5211D34 Offset: 0x520DD34 VA: 0x5211D34
	|-OrderedDictionary<EntityRef, object>.ContainsKey
	|
	|-RVA: 0x5215C8C Offset: 0x5211C8C VA: 0x5215C8C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.ContainsKey
	|
	|-RVA: 0x5219E24 Offset: 0x5215E24 VA: 0x5219E24
	|-OrderedDictionary<int, BulletLink>.ContainsKey
	|
	|-RVA: 0x521DE14 Offset: 0x5219E14 VA: 0x521DE14
	|-OrderedDictionary<int, HeroSkillCount>.ContainsKey
	|
	|-RVA: 0x5221EFC Offset: 0x521DEFC VA: 0x5221EFC
	|-OrderedDictionary<int, int>.ContainsKey
	|
	|-RVA: 0x5225D20 Offset: 0x5221D20 VA: 0x5225D20
	|-OrderedDictionary<int, object>.ContainsKey
	|
	|-RVA: 0x5229AD8 Offset: 0x5225AD8 VA: 0x5229AD8
	|-OrderedDictionary<Int32Enum, int>.ContainsKey
	|
	|-RVA: 0x522D908 Offset: 0x5229908 VA: 0x522D908
	|-OrderedDictionary<long, object>.ContainsKey
	|
	|-RVA: 0x52316E0 Offset: 0x522D6E0 VA: 0x52316E0
	|-OrderedDictionary<object, FP>.ContainsKey
	|
	|-RVA: 0x5235484 Offset: 0x5231484 VA: 0x5235484
	|-OrderedDictionary<object, long>.ContainsKey
	|
	|-RVA: 0x52391FC Offset: 0x52351FC VA: 0x52391FC
	|-OrderedDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x523CFA4 Offset: 0x5238FA4 VA: 0x523CFA4
	|-OrderedDictionary<ulong, object>.ContainsKey
	|
	|-RVA: 0x52417F0 Offset: 0x523D7F0 VA: 0x52417F0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5209FE4 Offset: 0x5205FE4 VA: 0x5209FE4
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.ContainsValue
	|
	|-RVA: 0x520DFDC Offset: 0x5209FDC VA: 0x520DFDC
	|-OrderedDictionary<EntityRef, int>.ContainsValue
	|
	|-RVA: 0x5211D58 Offset: 0x520DD58 VA: 0x5211D58
	|-OrderedDictionary<EntityRef, object>.ContainsValue
	|
	|-RVA: 0x5215CB0 Offset: 0x5211CB0 VA: 0x5215CB0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.ContainsValue
	|
	|-RVA: 0x5219E48 Offset: 0x5215E48 VA: 0x5219E48
	|-OrderedDictionary<int, BulletLink>.ContainsValue
	|
	|-RVA: 0x521DE38 Offset: 0x5219E38 VA: 0x521DE38
	|-OrderedDictionary<int, HeroSkillCount>.ContainsValue
	|
	|-RVA: 0x5221F20 Offset: 0x521DF20 VA: 0x5221F20
	|-OrderedDictionary<int, int>.ContainsValue
	|
	|-RVA: 0x5225D44 Offset: 0x5221D44 VA: 0x5225D44
	|-OrderedDictionary<int, object>.ContainsValue
	|
	|-RVA: 0x5229AFC Offset: 0x5225AFC VA: 0x5229AFC
	|-OrderedDictionary<Int32Enum, int>.ContainsValue
	|
	|-RVA: 0x522D92C Offset: 0x522992C VA: 0x522D92C
	|-OrderedDictionary<long, object>.ContainsValue
	|
	|-RVA: 0x5231704 Offset: 0x522D704 VA: 0x5231704
	|-OrderedDictionary<object, FP>.ContainsValue
	|
	|-RVA: 0x52354A8 Offset: 0x52314A8 VA: 0x52354A8
	|-OrderedDictionary<object, long>.ContainsValue
	|
	|-RVA: 0x5239220 Offset: 0x5235220 VA: 0x5239220
	|-OrderedDictionary<object, object>.ContainsValue
	|
	|-RVA: 0x523CFC8 Offset: 0x5238FC8 VA: 0x523CFC8
	|-OrderedDictionary<ulong, object>.ContainsValue
	|
	|-RVA: 0x52418BC Offset: 0x523D8BC VA: 0x52418BC
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1
	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A0A0 Offset: 0x52060A0 VA: 0x520A0A0
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.CopyTo
	|
	|-RVA: 0x520E098 Offset: 0x520A098 VA: 0x520E098
	|-OrderedDictionary<EntityRef, int>.CopyTo
	|
	|-RVA: 0x5211E60 Offset: 0x520DE60 VA: 0x5211E60
	|-OrderedDictionary<EntityRef, object>.CopyTo
	|
	|-RVA: 0x5215D94 Offset: 0x5211D94 VA: 0x5215D94
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.CopyTo
	|
	|-RVA: 0x5219F50 Offset: 0x5215F50 VA: 0x5219F50
	|-OrderedDictionary<int, BulletLink>.CopyTo
	|
	|-RVA: 0x521DEF4 Offset: 0x5219EF4 VA: 0x521DEF4
	|-OrderedDictionary<int, HeroSkillCount>.CopyTo
	|
	|-RVA: 0x5221FDC Offset: 0x521DFDC VA: 0x5221FDC
	|-OrderedDictionary<int, int>.CopyTo
	|
	|-RVA: 0x5225E4C Offset: 0x5221E4C VA: 0x5225E4C
	|-OrderedDictionary<int, object>.CopyTo
	|
	|-RVA: 0x5229BB8 Offset: 0x5225BB8 VA: 0x5229BB8
	|-OrderedDictionary<Int32Enum, int>.CopyTo
	|
	|-RVA: 0x522DA34 Offset: 0x5229A34 VA: 0x522DA34
	|-OrderedDictionary<long, object>.CopyTo
	|
	|-RVA: 0x52317C0 Offset: 0x522D7C0 VA: 0x52317C0
	|-OrderedDictionary<object, FP>.CopyTo
	|
	|-RVA: 0x5235564 Offset: 0x5231564 VA: 0x5235564
	|-OrderedDictionary<object, long>.CopyTo
	|
	|-RVA: 0x5239328 Offset: 0x5235328 VA: 0x5239328
	|-OrderedDictionary<object, object>.CopyTo
	|
	|-RVA: 0x523D0D0 Offset: 0x52390D0 VA: 0x523D0D0
	|-OrderedDictionary<ulong, object>.CopyTo
	|
	|-RVA: 0x5241BC4 Offset: 0x523DBC4 VA: 0x5241BC4
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A298 Offset: 0x5206298 VA: 0x520A298
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.GetEnumerator
	|
	|-RVA: 0x520E25C Offset: 0x520A25C VA: 0x520E25C
	|-OrderedDictionary<EntityRef, int>.GetEnumerator
	|
	|-RVA: 0x5212030 Offset: 0x520E030 VA: 0x5212030
	|-OrderedDictionary<EntityRef, object>.GetEnumerator
	|
	|-RVA: 0x5215F9C Offset: 0x5211F9C VA: 0x5215F9C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.GetEnumerator
	|
	|-RVA: 0x521A168 Offset: 0x5216168 VA: 0x521A168
	|-OrderedDictionary<int, BulletLink>.GetEnumerator
	|
	|-RVA: 0x521E0D0 Offset: 0x521A0D0 VA: 0x521E0D0
	|-OrderedDictionary<int, HeroSkillCount>.GetEnumerator
	|
	|-RVA: 0x52221A0 Offset: 0x521E1A0 VA: 0x52221A0
	|-OrderedDictionary<int, int>.GetEnumerator
	|
	|-RVA: 0x5226020 Offset: 0x5222020 VA: 0x5226020
	|-OrderedDictionary<int, object>.GetEnumerator
	|
	|-RVA: 0x5229D7C Offset: 0x5225D7C VA: 0x5229D7C
	|-OrderedDictionary<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x522DC04 Offset: 0x5229C04 VA: 0x522DC04
	|-OrderedDictionary<long, object>.GetEnumerator
	|
	|-RVA: 0x523198C Offset: 0x522D98C VA: 0x523198C
	|-OrderedDictionary<object, FP>.GetEnumerator
	|
	|-RVA: 0x5235730 Offset: 0x5231730 VA: 0x5235730
	|-OrderedDictionary<object, long>.GetEnumerator
	|
	|-RVA: 0x52394F4 Offset: 0x52354F4 VA: 0x52394F4
	|-OrderedDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x523D2A0 Offset: 0x52392A0 VA: 0x523D2A0
	|-OrderedDictionary<ulong, object>.GetEnumerator
	|
	|-RVA: 0x5241FC8 Offset: 0x523DFC8 VA: 0x5241FC8
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.Enumerator<TKey, TValue> GetEnumerator(TKey startingElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A2C0 Offset: 0x52062C0 VA: 0x520A2C0
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.GetEnumerator
	|
	|-RVA: 0x520E284 Offset: 0x520A284 VA: 0x520E284
	|-OrderedDictionary<EntityRef, int>.GetEnumerator
	|
	|-RVA: 0x5212058 Offset: 0x520E058 VA: 0x5212058
	|-OrderedDictionary<EntityRef, object>.GetEnumerator
	|
	|-RVA: 0x5215FC4 Offset: 0x5211FC4 VA: 0x5215FC4
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.GetEnumerator
	|
	|-RVA: 0x521A194 Offset: 0x5216194 VA: 0x521A194
	|-OrderedDictionary<int, BulletLink>.GetEnumerator
	|
	|-RVA: 0x521E0F4 Offset: 0x521A0F4 VA: 0x521E0F4
	|-OrderedDictionary<int, HeroSkillCount>.GetEnumerator
	|
	|-RVA: 0x52221C4 Offset: 0x521E1C4 VA: 0x52221C4
	|-OrderedDictionary<int, int>.GetEnumerator
	|
	|-RVA: 0x5226048 Offset: 0x5222048 VA: 0x5226048
	|-OrderedDictionary<int, object>.GetEnumerator
	|
	|-RVA: 0x5229DA0 Offset: 0x5225DA0 VA: 0x5229DA0
	|-OrderedDictionary<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x522DC2C Offset: 0x5229C2C VA: 0x522DC2C
	|-OrderedDictionary<long, object>.GetEnumerator
	|
	|-RVA: 0x52319B4 Offset: 0x522D9B4 VA: 0x52319B4
	|-OrderedDictionary<object, FP>.GetEnumerator
	|
	|-RVA: 0x5235758 Offset: 0x5231758 VA: 0x5235758
	|-OrderedDictionary<object, long>.GetEnumerator
	|
	|-RVA: 0x523951C Offset: 0x523551C VA: 0x523951C
	|-OrderedDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x523D2C8 Offset: 0x52392C8 VA: 0x523D2C8
	|-OrderedDictionary<ulong, object>.GetEnumerator
	|
	|-RVA: 0x524207C Offset: 0x523E07C VA: 0x524207C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.ReverseEnumerator<TKey, TValue> GetReverseEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A318 Offset: 0x5206318 VA: 0x520A318
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.GetReverseEnumerator
	|
	|-RVA: 0x520E2DC Offset: 0x520A2DC VA: 0x520E2DC
	|-OrderedDictionary<EntityRef, int>.GetReverseEnumerator
	|
	|-RVA: 0x52120B0 Offset: 0x520E0B0 VA: 0x52120B0
	|-OrderedDictionary<EntityRef, object>.GetReverseEnumerator
	|
	|-RVA: 0x521601C Offset: 0x521201C VA: 0x521601C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.GetReverseEnumerator
	|
	|-RVA: 0x521A1F0 Offset: 0x52161F0 VA: 0x521A1F0
	|-OrderedDictionary<int, BulletLink>.GetReverseEnumerator
	|
	|-RVA: 0x521E148 Offset: 0x521A148 VA: 0x521E148
	|-OrderedDictionary<int, HeroSkillCount>.GetReverseEnumerator
	|
	|-RVA: 0x5222218 Offset: 0x521E218 VA: 0x5222218
	|-OrderedDictionary<int, int>.GetReverseEnumerator
	|
	|-RVA: 0x52260A0 Offset: 0x52220A0 VA: 0x52260A0
	|-OrderedDictionary<int, object>.GetReverseEnumerator
	|
	|-RVA: 0x5229DF4 Offset: 0x5225DF4 VA: 0x5229DF4
	|-OrderedDictionary<Int32Enum, int>.GetReverseEnumerator
	|
	|-RVA: 0x522DC84 Offset: 0x5229C84 VA: 0x522DC84
	|-OrderedDictionary<long, object>.GetReverseEnumerator
	|
	|-RVA: 0x5231A0C Offset: 0x522DA0C VA: 0x5231A0C
	|-OrderedDictionary<object, FP>.GetReverseEnumerator
	|
	|-RVA: 0x52357B0 Offset: 0x52317B0 VA: 0x52357B0
	|-OrderedDictionary<object, long>.GetReverseEnumerator
	|
	|-RVA: 0x5239574 Offset: 0x5235574 VA: 0x5239574
	|-OrderedDictionary<object, object>.GetReverseEnumerator
	|
	|-RVA: 0x523D320 Offset: 0x5239320 VA: 0x523D320
	|-OrderedDictionary<ulong, object>.GetReverseEnumerator
	|
	|-RVA: 0x52421B4 Offset: 0x523E1B4 VA: 0x52421B4
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetReverseEnumerator
	*/

	// RVA: -1 Offset: -1
	public OrderedDictionary.ReverseEnumerator<TKey, TValue> GetReverseEnumerator(TKey startingElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A340 Offset: 0x5206340 VA: 0x520A340
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.GetReverseEnumerator
	|
	|-RVA: 0x520E304 Offset: 0x520A304 VA: 0x520E304
	|-OrderedDictionary<EntityRef, int>.GetReverseEnumerator
	|
	|-RVA: 0x52120D8 Offset: 0x520E0D8 VA: 0x52120D8
	|-OrderedDictionary<EntityRef, object>.GetReverseEnumerator
	|
	|-RVA: 0x5216044 Offset: 0x5212044 VA: 0x5216044
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.GetReverseEnumerator
	|
	|-RVA: 0x521A21C Offset: 0x521621C VA: 0x521A21C
	|-OrderedDictionary<int, BulletLink>.GetReverseEnumerator
	|
	|-RVA: 0x521E16C Offset: 0x521A16C VA: 0x521E16C
	|-OrderedDictionary<int, HeroSkillCount>.GetReverseEnumerator
	|
	|-RVA: 0x522223C Offset: 0x521E23C VA: 0x522223C
	|-OrderedDictionary<int, int>.GetReverseEnumerator
	|
	|-RVA: 0x52260C8 Offset: 0x52220C8 VA: 0x52260C8
	|-OrderedDictionary<int, object>.GetReverseEnumerator
	|
	|-RVA: 0x5229E18 Offset: 0x5225E18 VA: 0x5229E18
	|-OrderedDictionary<Int32Enum, int>.GetReverseEnumerator
	|
	|-RVA: 0x522DCAC Offset: 0x5229CAC VA: 0x522DCAC
	|-OrderedDictionary<long, object>.GetReverseEnumerator
	|
	|-RVA: 0x5231A34 Offset: 0x522DA34 VA: 0x5231A34
	|-OrderedDictionary<object, FP>.GetReverseEnumerator
	|
	|-RVA: 0x52357D8 Offset: 0x52317D8 VA: 0x52357D8
	|-OrderedDictionary<object, long>.GetReverseEnumerator
	|
	|-RVA: 0x523959C Offset: 0x523559C VA: 0x523959C
	|-OrderedDictionary<object, object>.GetReverseEnumerator
	|
	|-RVA: 0x523D348 Offset: 0x5239348 VA: 0x523D348
	|-OrderedDictionary<ulong, object>.GetReverseEnumerator
	|
	|-RVA: 0x5242268 Offset: 0x523E268 VA: 0x5242268
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetReverseEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A398 Offset: 0x5206398 VA: 0x520A398
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x520E35C Offset: 0x520A35C VA: 0x520E35C
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5212130 Offset: 0x520E130 VA: 0x5212130
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x521609C Offset: 0x521209C VA: 0x521609C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x521A278 Offset: 0x5216278 VA: 0x521A278
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x521E1C0 Offset: 0x521A1C0 VA: 0x521E1C0
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5222290 Offset: 0x521E290 VA: 0x5222290
	|-OrderedDictionary<int, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5226120 Offset: 0x5222120 VA: 0x5226120
	|-OrderedDictionary<int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5229E6C Offset: 0x5225E6C VA: 0x5229E6C
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x522DD04 Offset: 0x5229D04 VA: 0x522DD04
	|-OrderedDictionary<long, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5231A8C Offset: 0x522DA8C VA: 0x5231A8C
	|-OrderedDictionary<object, FP>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x5235830 Offset: 0x5231830 VA: 0x5235830
	|-OrderedDictionary<object, long>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x52395F4 Offset: 0x52355F4 VA: 0x52395F4
	|-OrderedDictionary<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x523D3A0 Offset: 0x52393A0 VA: 0x523D3A0
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x52423A0 Offset: 0x523E3A0 VA: 0x52423A0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 44
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A3FC Offset: 0x52063FC VA: 0x520A3FC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.GetObjectData
	|
	|-RVA: 0x520E3C0 Offset: 0x520A3C0 VA: 0x520E3C0
	|-OrderedDictionary<EntityRef, int>.GetObjectData
	|
	|-RVA: 0x5212194 Offset: 0x520E194 VA: 0x5212194
	|-OrderedDictionary<EntityRef, object>.GetObjectData
	|
	|-RVA: 0x5216100 Offset: 0x5212100 VA: 0x5216100
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.GetObjectData
	|
	|-RVA: 0x521A2E0 Offset: 0x52162E0 VA: 0x521A2E0
	|-OrderedDictionary<int, BulletLink>.GetObjectData
	|
	|-RVA: 0x521E218 Offset: 0x521A218 VA: 0x521E218
	|-OrderedDictionary<int, HeroSkillCount>.GetObjectData
	|
	|-RVA: 0x52222E8 Offset: 0x521E2E8 VA: 0x52222E8
	|-OrderedDictionary<int, int>.GetObjectData
	|
	|-RVA: 0x5226184 Offset: 0x5222184 VA: 0x5226184
	|-OrderedDictionary<int, object>.GetObjectData
	|
	|-RVA: 0x5229EC4 Offset: 0x5225EC4 VA: 0x5229EC4
	|-OrderedDictionary<Int32Enum, int>.GetObjectData
	|
	|-RVA: 0x522DD68 Offset: 0x5229D68 VA: 0x522DD68
	|-OrderedDictionary<long, object>.GetObjectData
	|
	|-RVA: 0x5231AF0 Offset: 0x522DAF0 VA: 0x5231AF0
	|-OrderedDictionary<object, FP>.GetObjectData
	|
	|-RVA: 0x5235894 Offset: 0x5231894 VA: 0x5235894
	|-OrderedDictionary<object, long>.GetObjectData
	|
	|-RVA: 0x5239658 Offset: 0x5235658 VA: 0x5239658
	|-OrderedDictionary<object, object>.GetObjectData
	|
	|-RVA: 0x523D404 Offset: 0x5239404 VA: 0x523D404
	|-OrderedDictionary<ulong, object>.GetObjectData
	|
	|-RVA: 0x5242454 Offset: 0x523E454 VA: 0x5242454
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1
	private int FindEntry(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A648 Offset: 0x5206648 VA: 0x520A648
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.FindEntry
	|
	|-RVA: 0x520E60C Offset: 0x520A60C VA: 0x520E60C
	|-OrderedDictionary<EntityRef, int>.FindEntry
	|
	|-RVA: 0x52123E0 Offset: 0x520E3E0 VA: 0x52123E0
	|-OrderedDictionary<EntityRef, object>.FindEntry
	|
	|-RVA: 0x521634C Offset: 0x521234C VA: 0x521634C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.FindEntry
	|
	|-RVA: 0x521A52C Offset: 0x521652C VA: 0x521A52C
	|-OrderedDictionary<int, BulletLink>.FindEntry
	|
	|-RVA: 0x521E464 Offset: 0x521A464 VA: 0x521E464
	|-OrderedDictionary<int, HeroSkillCount>.FindEntry
	|
	|-RVA: 0x5222534 Offset: 0x521E534 VA: 0x5222534
	|-OrderedDictionary<int, int>.FindEntry
	|
	|-RVA: 0x52263D0 Offset: 0x52223D0 VA: 0x52263D0
	|-OrderedDictionary<int, object>.FindEntry
	|
	|-RVA: 0x522A110 Offset: 0x5226110 VA: 0x522A110
	|-OrderedDictionary<Int32Enum, int>.FindEntry
	|
	|-RVA: 0x522DFB4 Offset: 0x5229FB4 VA: 0x522DFB4
	|-OrderedDictionary<long, object>.FindEntry
	|
	|-RVA: 0x5231D3C Offset: 0x522DD3C VA: 0x5231D3C
	|-OrderedDictionary<object, FP>.FindEntry
	|
	|-RVA: 0x5235AE0 Offset: 0x5231AE0 VA: 0x5235AE0
	|-OrderedDictionary<object, long>.FindEntry
	|
	|-RVA: 0x52398A4 Offset: 0x52358A4 VA: 0x52398A4
	|-OrderedDictionary<object, object>.FindEntry
	|
	|-RVA: 0x523D650 Offset: 0x5239650 VA: 0x523D650
	|-OrderedDictionary<ulong, object>.FindEntry
	|
	|-RVA: 0x52426C0 Offset: 0x523E6C0 VA: 0x52426C0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private void Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A840 Offset: 0x5206840 VA: 0x520A840
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.Initialize
	|
	|-RVA: 0x520E7E0 Offset: 0x520A7E0 VA: 0x520E7E0
	|-OrderedDictionary<EntityRef, int>.Initialize
	|
	|-RVA: 0x52125B4 Offset: 0x520E5B4 VA: 0x52125B4
	|-OrderedDictionary<EntityRef, object>.Initialize
	|
	|-RVA: 0x521652C Offset: 0x521252C VA: 0x521652C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.Initialize
	|
	|-RVA: 0x521A700 Offset: 0x5216700 VA: 0x521A700
	|-OrderedDictionary<int, BulletLink>.Initialize
	|
	|-RVA: 0x521E644 Offset: 0x521A644 VA: 0x521E644
	|-OrderedDictionary<int, HeroSkillCount>.Initialize
	|
	|-RVA: 0x5222714 Offset: 0x521E714 VA: 0x5222714
	|-OrderedDictionary<int, int>.Initialize
	|
	|-RVA: 0x52265A4 Offset: 0x52225A4 VA: 0x52265A4
	|-OrderedDictionary<int, object>.Initialize
	|
	|-RVA: 0x522A2F0 Offset: 0x52262F0 VA: 0x522A2F0
	|-OrderedDictionary<Int32Enum, int>.Initialize
	|
	|-RVA: 0x522E188 Offset: 0x522A188 VA: 0x522E188
	|-OrderedDictionary<long, object>.Initialize
	|
	|-RVA: 0x5231F10 Offset: 0x522DF10 VA: 0x5231F10
	|-OrderedDictionary<object, FP>.Initialize
	|
	|-RVA: 0x5235CB4 Offset: 0x5231CB4 VA: 0x5235CB4
	|-OrderedDictionary<object, long>.Initialize
	|
	|-RVA: 0x5239A78 Offset: 0x5235A78 VA: 0x5239A78
	|-OrderedDictionary<object, object>.Initialize
	|
	|-RVA: 0x523D824 Offset: 0x5239824 VA: 0x523D824
	|-OrderedDictionary<ulong, object>.Initialize
	|
	|-RVA: 0x5242A48 Offset: 0x523EA48 VA: 0x5242A48
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1
	private void Insert(TKey key, TValue value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520A970 Offset: 0x5206970 VA: 0x520A970
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.Insert
	|
	|-RVA: 0x520E910 Offset: 0x520A910 VA: 0x520E910
	|-OrderedDictionary<EntityRef, int>.Insert
	|
	|-RVA: 0x52126E4 Offset: 0x520E6E4 VA: 0x52126E4
	|-OrderedDictionary<EntityRef, object>.Insert
	|
	|-RVA: 0x521665C Offset: 0x521265C VA: 0x521665C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.Insert
	|
	|-RVA: 0x521A830 Offset: 0x5216830 VA: 0x521A830
	|-OrderedDictionary<int, BulletLink>.Insert
	|
	|-RVA: 0x521E774 Offset: 0x521A774 VA: 0x521E774
	|-OrderedDictionary<int, HeroSkillCount>.Insert
	|
	|-RVA: 0x5222844 Offset: 0x521E844 VA: 0x5222844
	|-OrderedDictionary<int, int>.Insert
	|
	|-RVA: 0x52266D4 Offset: 0x52226D4 VA: 0x52266D4
	|-OrderedDictionary<int, object>.Insert
	|
	|-RVA: 0x522A420 Offset: 0x5226420 VA: 0x522A420
	|-OrderedDictionary<Int32Enum, int>.Insert
	|
	|-RVA: 0x522E2B8 Offset: 0x522A2B8 VA: 0x522E2B8
	|-OrderedDictionary<long, object>.Insert
	|
	|-RVA: 0x5232040 Offset: 0x522E040 VA: 0x5232040
	|-OrderedDictionary<object, FP>.Insert
	|
	|-RVA: 0x5235DE4 Offset: 0x5231DE4 VA: 0x5235DE4
	|-OrderedDictionary<object, long>.Insert
	|
	|-RVA: 0x5239BA8 Offset: 0x5235BA8 VA: 0x5239BA8
	|-OrderedDictionary<object, object>.Insert
	|
	|-RVA: 0x523D954 Offset: 0x5239954 VA: 0x523D954
	|-OrderedDictionary<ulong, object>.Insert
	|
	|-RVA: 0x5242B78 Offset: 0x523EB78 VA: 0x5242B78
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 45
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520ADE0 Offset: 0x5206DE0 VA: 0x520ADE0
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.OnDeserialization
	|
	|-RVA: 0x520ED00 Offset: 0x520AD00 VA: 0x520ED00
	|-OrderedDictionary<EntityRef, int>.OnDeserialization
	|
	|-RVA: 0x5212B00 Offset: 0x520EB00 VA: 0x5212B00
	|-OrderedDictionary<EntityRef, object>.OnDeserialization
	|
	|-RVA: 0x5216AA0 Offset: 0x5212AA0 VA: 0x5216AA0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.OnDeserialization
	|
	|-RVA: 0x521AC5C Offset: 0x5216C5C VA: 0x521AC5C
	|-OrderedDictionary<int, BulletLink>.OnDeserialization
	|
	|-RVA: 0x521EB9C Offset: 0x521AB9C VA: 0x521EB9C
	|-OrderedDictionary<int, HeroSkillCount>.OnDeserialization
	|
	|-RVA: 0x5222C30 Offset: 0x521EC30 VA: 0x5222C30
	|-OrderedDictionary<int, int>.OnDeserialization
	|
	|-RVA: 0x5226AD4 Offset: 0x5222AD4 VA: 0x5226AD4
	|-OrderedDictionary<int, object>.OnDeserialization
	|
	|-RVA: 0x522A81C Offset: 0x522681C VA: 0x522A81C
	|-OrderedDictionary<Int32Enum, int>.OnDeserialization
	|
	|-RVA: 0x522E6BC Offset: 0x522A6BC VA: 0x522E6BC
	|-OrderedDictionary<long, object>.OnDeserialization
	|
	|-RVA: 0x523244C Offset: 0x522E44C VA: 0x523244C
	|-OrderedDictionary<object, FP>.OnDeserialization
	|
	|-RVA: 0x52361D0 Offset: 0x52321D0 VA: 0x52361D0
	|-OrderedDictionary<object, long>.OnDeserialization
	|
	|-RVA: 0x5239FC4 Offset: 0x5235FC4 VA: 0x5239FC4
	|-OrderedDictionary<object, object>.OnDeserialization
	|
	|-RVA: 0x523DD58 Offset: 0x5239D58 VA: 0x523DD58
	|-OrderedDictionary<ulong, object>.OnDeserialization
	|
	|-RVA: 0x524348C Offset: 0x523F48C VA: 0x524348C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520B238 Offset: 0x5207238 VA: 0x520B238
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.Resize
	|
	|-RVA: 0x520F158 Offset: 0x520B158 VA: 0x520F158
	|-OrderedDictionary<EntityRef, int>.Resize
	|
	|-RVA: 0x5212F58 Offset: 0x520EF58 VA: 0x5212F58
	|-OrderedDictionary<EntityRef, object>.Resize
	|
	|-RVA: 0x5216F08 Offset: 0x5212F08 VA: 0x5216F08
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.Resize
	|
	|-RVA: 0x521B0D8 Offset: 0x52170D8 VA: 0x521B0D8
	|-OrderedDictionary<int, BulletLink>.Resize
	|
	|-RVA: 0x521EFF4 Offset: 0x521AFF4 VA: 0x521EFF4
	|-OrderedDictionary<int, HeroSkillCount>.Resize
	|
	|-RVA: 0x5223088 Offset: 0x521F088 VA: 0x5223088
	|-OrderedDictionary<int, int>.Resize
	|
	|-RVA: 0x5226F2C Offset: 0x5222F2C VA: 0x5226F2C
	|-OrderedDictionary<int, object>.Resize
	|
	|-RVA: 0x522AC74 Offset: 0x5226C74 VA: 0x522AC74
	|-OrderedDictionary<Int32Enum, int>.Resize
	|
	|-RVA: 0x522EB14 Offset: 0x522AB14 VA: 0x522EB14
	|-OrderedDictionary<long, object>.Resize
	|
	|-RVA: 0x52328C4 Offset: 0x522E8C4 VA: 0x52328C4
	|-OrderedDictionary<object, FP>.Resize
	|
	|-RVA: 0x5236648 Offset: 0x5232648 VA: 0x5236648
	|-OrderedDictionary<object, long>.Resize
	|
	|-RVA: 0x523A43C Offset: 0x523643C VA: 0x523A43C
	|-OrderedDictionary<object, object>.Resize
	|
	|-RVA: 0x523E1B0 Offset: 0x523A1B0 VA: 0x523E1B0
	|-OrderedDictionary<ulong, object>.Resize
	|
	|-RVA: 0x5243A90 Offset: 0x523FA90 VA: 0x5243A90
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	private void Resize(int newSize, bool forceNewHashCodes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520B2BC Offset: 0x52072BC VA: 0x520B2BC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.Resize
	|
	|-RVA: 0x520F1DC Offset: 0x520B1DC VA: 0x520F1DC
	|-OrderedDictionary<EntityRef, int>.Resize
	|
	|-RVA: 0x5212FDC Offset: 0x520EFDC VA: 0x5212FDC
	|-OrderedDictionary<EntityRef, object>.Resize
	|
	|-RVA: 0x5216F8C Offset: 0x5212F8C VA: 0x5216F8C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.Resize
	|
	|-RVA: 0x521B15C Offset: 0x521715C VA: 0x521B15C
	|-OrderedDictionary<int, BulletLink>.Resize
	|
	|-RVA: 0x521F078 Offset: 0x521B078 VA: 0x521F078
	|-OrderedDictionary<int, HeroSkillCount>.Resize
	|
	|-RVA: 0x522310C Offset: 0x521F10C VA: 0x522310C
	|-OrderedDictionary<int, int>.Resize
	|
	|-RVA: 0x5226FB0 Offset: 0x5222FB0 VA: 0x5226FB0
	|-OrderedDictionary<int, object>.Resize
	|
	|-RVA: 0x522ACF8 Offset: 0x5226CF8 VA: 0x522ACF8
	|-OrderedDictionary<Int32Enum, int>.Resize
	|
	|-RVA: 0x522EB98 Offset: 0x522AB98 VA: 0x522EB98
	|-OrderedDictionary<long, object>.Resize
	|
	|-RVA: 0x5232948 Offset: 0x522E948 VA: 0x5232948
	|-OrderedDictionary<object, FP>.Resize
	|
	|-RVA: 0x52366CC Offset: 0x52326CC VA: 0x52366CC
	|-OrderedDictionary<object, long>.Resize
	|
	|-RVA: 0x523A4C0 Offset: 0x52364C0 VA: 0x523A4C0
	|-OrderedDictionary<object, object>.Resize
	|
	|-RVA: 0x523E234 Offset: 0x523A234 VA: 0x523E234
	|-OrderedDictionary<ulong, object>.Resize
	|
	|-RVA: 0x5243B18 Offset: 0x523FB18 VA: 0x5243B18
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520B548 Offset: 0x5207548 VA: 0x520B548
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.Remove
	|
	|-RVA: 0x520F444 Offset: 0x520B444 VA: 0x520F444
	|-OrderedDictionary<EntityRef, int>.Remove
	|
	|-RVA: 0x5213244 Offset: 0x520F244 VA: 0x5213244
	|-OrderedDictionary<EntityRef, object>.Remove
	|
	|-RVA: 0x52171FC Offset: 0x52131FC VA: 0x52171FC
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.Remove
	|
	|-RVA: 0x521B3C4 Offset: 0x52173C4 VA: 0x521B3C4
	|-OrderedDictionary<int, BulletLink>.Remove
	|
	|-RVA: 0x521F2E8 Offset: 0x521B2E8 VA: 0x521F2E8
	|-OrderedDictionary<int, HeroSkillCount>.Remove
	|
	|-RVA: 0x522337C Offset: 0x521F37C VA: 0x522337C
	|-OrderedDictionary<int, int>.Remove
	|
	|-RVA: 0x5227218 Offset: 0x5223218 VA: 0x5227218
	|-OrderedDictionary<int, object>.Remove
	|
	|-RVA: 0x522AF68 Offset: 0x5226F68 VA: 0x522AF68
	|-OrderedDictionary<Int32Enum, int>.Remove
	|
	|-RVA: 0x522EE00 Offset: 0x522AE00 VA: 0x522EE00
	|-OrderedDictionary<long, object>.Remove
	|
	|-RVA: 0x5232BB0 Offset: 0x522EBB0 VA: 0x5232BB0
	|-OrderedDictionary<object, FP>.Remove
	|
	|-RVA: 0x5236934 Offset: 0x5232934 VA: 0x5236934
	|-OrderedDictionary<object, long>.Remove
	|
	|-RVA: 0x523A728 Offset: 0x5236728 VA: 0x523A728
	|-OrderedDictionary<object, object>.Remove
	|
	|-RVA: 0x523E49C Offset: 0x523A49C VA: 0x523E49C
	|-OrderedDictionary<ulong, object>.Remove
	|
	|-RVA: 0x5243F30 Offset: 0x523FF30 VA: 0x5243F30
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520B93C Offset: 0x520793C VA: 0x520B93C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.Remove
	|
	|-RVA: 0x520F7C0 Offset: 0x520B7C0 VA: 0x520F7C0
	|-OrderedDictionary<EntityRef, int>.Remove
	|
	|-RVA: 0x52135E0 Offset: 0x520F5E0 VA: 0x52135E0
	|-OrderedDictionary<EntityRef, object>.Remove
	|
	|-RVA: 0x52175E0 Offset: 0x52135E0 VA: 0x52175E0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.Remove
	|
	|-RVA: 0x521B77C Offset: 0x521777C VA: 0x521B77C
	|-OrderedDictionary<int, BulletLink>.Remove
	|
	|-RVA: 0x521F6BC Offset: 0x521B6BC VA: 0x521F6BC
	|-OrderedDictionary<int, HeroSkillCount>.Remove
	|
	|-RVA: 0x5223734 Offset: 0x521F734 VA: 0x5223734
	|-OrderedDictionary<int, int>.Remove
	|
	|-RVA: 0x52275B0 Offset: 0x52235B0 VA: 0x52275B0
	|-OrderedDictionary<int, object>.Remove
	|
	|-RVA: 0x522B320 Offset: 0x5227320 VA: 0x522B320
	|-OrderedDictionary<Int32Enum, int>.Remove
	|
	|-RVA: 0x522F19C Offset: 0x522B19C VA: 0x522F19C
	|-OrderedDictionary<long, object>.Remove
	|
	|-RVA: 0x5232F44 Offset: 0x522EF44 VA: 0x5232F44
	|-OrderedDictionary<object, FP>.Remove
	|
	|-RVA: 0x5236CBC Offset: 0x5232CBC VA: 0x5236CBC
	|-OrderedDictionary<object, long>.Remove
	|
	|-RVA: 0x523AAC4 Offset: 0x5236AC4 VA: 0x523AAC4
	|-OrderedDictionary<object, object>.Remove
	|
	|-RVA: 0x523E838 Offset: 0x523A838 VA: 0x523E838
	|-OrderedDictionary<ulong, object>.Remove
	|
	|-RVA: 0x5244808 Offset: 0x5240808 VA: 0x5244808
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520BD00 Offset: 0x5207D00 VA: 0x520BD00
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.TryGetValue
	|
	|-RVA: 0x520FB2C Offset: 0x520BB2C VA: 0x520FB2C
	|-OrderedDictionary<EntityRef, int>.TryGetValue
	|
	|-RVA: 0x521394C Offset: 0x520F94C VA: 0x521394C
	|-OrderedDictionary<EntityRef, object>.TryGetValue
	|
	|-RVA: 0x521797C Offset: 0x521397C VA: 0x521797C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.TryGetValue
	|
	|-RVA: 0x521BAF0 Offset: 0x5217AF0 VA: 0x521BAF0
	|-OrderedDictionary<int, BulletLink>.TryGetValue
	|
	|-RVA: 0x521FA54 Offset: 0x521BA54 VA: 0x521FA54
	|-OrderedDictionary<int, HeroSkillCount>.TryGetValue
	|
	|-RVA: 0x5223ACC Offset: 0x521FACC VA: 0x5223ACC
	|-OrderedDictionary<int, int>.TryGetValue
	|
	|-RVA: 0x5227918 Offset: 0x5223918 VA: 0x5227918
	|-OrderedDictionary<int, object>.TryGetValue
	|
	|-RVA: 0x522B6B8 Offset: 0x52276B8 VA: 0x522B6B8
	|-OrderedDictionary<Int32Enum, int>.TryGetValue
	|
	|-RVA: 0x522F508 Offset: 0x522B508 VA: 0x522F508
	|-OrderedDictionary<long, object>.TryGetValue
	|
	|-RVA: 0x52332B0 Offset: 0x522F2B0 VA: 0x52332B0
	|-OrderedDictionary<object, FP>.TryGetValue
	|
	|-RVA: 0x5237028 Offset: 0x5233028 VA: 0x5237028
	|-OrderedDictionary<object, long>.TryGetValue
	|
	|-RVA: 0x523AE30 Offset: 0x5236E30 VA: 0x523AE30
	|-OrderedDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x523EBA4 Offset: 0x523ABA4 VA: 0x523EBA4
	|-OrderedDictionary<ulong, object>.TryGetValue
	|
	|-RVA: 0x524502C Offset: 0x524102C VA: 0x524502C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool MoveFirst(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520BD6C Offset: 0x5207D6C VA: 0x520BD6C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.MoveFirst
	|
	|-RVA: 0x520FB98 Offset: 0x520BB98 VA: 0x520FB98
	|-OrderedDictionary<EntityRef, int>.MoveFirst
	|
	|-RVA: 0x52139C4 Offset: 0x520F9C4 VA: 0x52139C4
	|-OrderedDictionary<EntityRef, object>.MoveFirst
	|
	|-RVA: 0x52179FC Offset: 0x52139FC VA: 0x52179FC
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.MoveFirst
	|
	|-RVA: 0x521BB78 Offset: 0x5217B78 VA: 0x521BB78
	|-OrderedDictionary<int, BulletLink>.MoveFirst
	|
	|-RVA: 0x521FAC0 Offset: 0x521BAC0 VA: 0x521FAC0
	|-OrderedDictionary<int, HeroSkillCount>.MoveFirst
	|
	|-RVA: 0x5223B38 Offset: 0x521FB38 VA: 0x5223B38
	|-OrderedDictionary<int, int>.MoveFirst
	|
	|-RVA: 0x5227990 Offset: 0x5223990 VA: 0x5227990
	|-OrderedDictionary<int, object>.MoveFirst
	|
	|-RVA: 0x522B724 Offset: 0x5227724 VA: 0x522B724
	|-OrderedDictionary<Int32Enum, int>.MoveFirst
	|
	|-RVA: 0x522F580 Offset: 0x522B580 VA: 0x522F580
	|-OrderedDictionary<long, object>.MoveFirst
	|
	|-RVA: 0x523331C Offset: 0x522F31C VA: 0x523331C
	|-OrderedDictionary<object, FP>.MoveFirst
	|
	|-RVA: 0x5237094 Offset: 0x5233094 VA: 0x5237094
	|-OrderedDictionary<object, long>.MoveFirst
	|
	|-RVA: 0x523AEA8 Offset: 0x5236EA8 VA: 0x523AEA8
	|-OrderedDictionary<object, object>.MoveFirst
	|
	|-RVA: 0x523EC1C Offset: 0x523AC1C VA: 0x523EC1C
	|-OrderedDictionary<ulong, object>.MoveFirst
	|
	|-RVA: 0x52451D0 Offset: 0x52411D0 VA: 0x52451D0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveFirst
	*/

	// RVA: -1 Offset: -1
	public bool MoveLast(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520BE4C Offset: 0x5207E4C VA: 0x520BE4C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.MoveLast
	|
	|-RVA: 0x520FC60 Offset: 0x520BC60 VA: 0x520FC60
	|-OrderedDictionary<EntityRef, int>.MoveLast
	|
	|-RVA: 0x5213A90 Offset: 0x520FA90 VA: 0x5213A90
	|-OrderedDictionary<EntityRef, object>.MoveLast
	|
	|-RVA: 0x5217ADC Offset: 0x5213ADC VA: 0x5217ADC
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.MoveLast
	|
	|-RVA: 0x521BC44 Offset: 0x5217C44 VA: 0x521BC44
	|-OrderedDictionary<int, BulletLink>.MoveLast
	|
	|-RVA: 0x521FBA0 Offset: 0x521BBA0 VA: 0x521FBA0
	|-OrderedDictionary<int, HeroSkillCount>.MoveLast
	|
	|-RVA: 0x5223C18 Offset: 0x521FC18 VA: 0x5223C18
	|-OrderedDictionary<int, int>.MoveLast
	|
	|-RVA: 0x5227A5C Offset: 0x5223A5C VA: 0x5227A5C
	|-OrderedDictionary<int, object>.MoveLast
	|
	|-RVA: 0x522B804 Offset: 0x5227804 VA: 0x522B804
	|-OrderedDictionary<Int32Enum, int>.MoveLast
	|
	|-RVA: 0x522F64C Offset: 0x522B64C VA: 0x522F64C
	|-OrderedDictionary<long, object>.MoveLast
	|
	|-RVA: 0x52333E8 Offset: 0x522F3E8 VA: 0x52333E8
	|-OrderedDictionary<object, FP>.MoveLast
	|
	|-RVA: 0x5237160 Offset: 0x5233160 VA: 0x5237160
	|-OrderedDictionary<object, long>.MoveLast
	|
	|-RVA: 0x523AF74 Offset: 0x5236F74 VA: 0x523AF74
	|-OrderedDictionary<object, object>.MoveLast
	|
	|-RVA: 0x523ECE8 Offset: 0x523ACE8 VA: 0x523ECE8
	|-OrderedDictionary<ulong, object>.MoveLast
	|
	|-RVA: 0x52454C8 Offset: 0x52414C8 VA: 0x52454C8
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveLast
	*/

	// RVA: -1 Offset: -1
	public bool MoveBefore(TKey keyToMove, TKey mark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520BF2C Offset: 0x5207F2C VA: 0x520BF2C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.MoveBefore
	|
	|-RVA: 0x520FD28 Offset: 0x520BD28 VA: 0x520FD28
	|-OrderedDictionary<EntityRef, int>.MoveBefore
	|
	|-RVA: 0x5213B5C Offset: 0x520FB5C VA: 0x5213B5C
	|-OrderedDictionary<EntityRef, object>.MoveBefore
	|
	|-RVA: 0x5217BBC Offset: 0x5213BBC VA: 0x5217BBC
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.MoveBefore
	|
	|-RVA: 0x521BD0C Offset: 0x5217D0C VA: 0x521BD0C
	|-OrderedDictionary<int, BulletLink>.MoveBefore
	|
	|-RVA: 0x521FC7C Offset: 0x521BC7C VA: 0x521FC7C
	|-OrderedDictionary<int, HeroSkillCount>.MoveBefore
	|
	|-RVA: 0x5223CF4 Offset: 0x521FCF4 VA: 0x5223CF4
	|-OrderedDictionary<int, int>.MoveBefore
	|
	|-RVA: 0x5227B28 Offset: 0x5223B28 VA: 0x5227B28
	|-OrderedDictionary<int, object>.MoveBefore
	|
	|-RVA: 0x522B8E0 Offset: 0x52278E0 VA: 0x522B8E0
	|-OrderedDictionary<Int32Enum, int>.MoveBefore
	|
	|-RVA: 0x522F718 Offset: 0x522B718 VA: 0x522F718
	|-OrderedDictionary<long, object>.MoveBefore
	|
	|-RVA: 0x52334B4 Offset: 0x522F4B4 VA: 0x52334B4
	|-OrderedDictionary<object, FP>.MoveBefore
	|
	|-RVA: 0x523722C Offset: 0x523322C VA: 0x523722C
	|-OrderedDictionary<object, long>.MoveBefore
	|
	|-RVA: 0x523B040 Offset: 0x5237040 VA: 0x523B040
	|-OrderedDictionary<object, object>.MoveBefore
	|
	|-RVA: 0x523EDB4 Offset: 0x523ADB4 VA: 0x523EDB4
	|-OrderedDictionary<ulong, object>.MoveBefore
	|
	|-RVA: 0x52457C0 Offset: 0x52417C0 VA: 0x52457C0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveBefore
	*/

	// RVA: -1 Offset: -1
	public bool MoveAfter(TKey keyToMove, TKey mark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C080 Offset: 0x5208080 VA: 0x520C080
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.MoveAfter
	|
	|-RVA: 0x520FE50 Offset: 0x520BE50 VA: 0x520FE50
	|-OrderedDictionary<EntityRef, int>.MoveAfter
	|
	|-RVA: 0x5213C94 Offset: 0x520FC94 VA: 0x5213C94
	|-OrderedDictionary<EntityRef, object>.MoveAfter
	|
	|-RVA: 0x5217D00 Offset: 0x5213D00 VA: 0x5217D00
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.MoveAfter
	|
	|-RVA: 0x521BE38 Offset: 0x5217E38 VA: 0x521BE38
	|-OrderedDictionary<int, BulletLink>.MoveAfter
	|
	|-RVA: 0x521FDB4 Offset: 0x521BDB4 VA: 0x521FDB4
	|-OrderedDictionary<int, HeroSkillCount>.MoveAfter
	|
	|-RVA: 0x5223E2C Offset: 0x521FE2C VA: 0x5223E2C
	|-OrderedDictionary<int, int>.MoveAfter
	|
	|-RVA: 0x5227C60 Offset: 0x5223C60 VA: 0x5227C60
	|-OrderedDictionary<int, object>.MoveAfter
	|
	|-RVA: 0x522BA18 Offset: 0x5227A18 VA: 0x522BA18
	|-OrderedDictionary<Int32Enum, int>.MoveAfter
	|
	|-RVA: 0x522F850 Offset: 0x522B850 VA: 0x522F850
	|-OrderedDictionary<long, object>.MoveAfter
	|
	|-RVA: 0x52335EC Offset: 0x522F5EC VA: 0x52335EC
	|-OrderedDictionary<object, FP>.MoveAfter
	|
	|-RVA: 0x5237364 Offset: 0x5233364 VA: 0x5237364
	|-OrderedDictionary<object, long>.MoveAfter
	|
	|-RVA: 0x523B178 Offset: 0x5237178 VA: 0x523B178
	|-OrderedDictionary<object, object>.MoveAfter
	|
	|-RVA: 0x523EEEC Offset: 0x523AEEC VA: 0x523EEEC
	|-OrderedDictionary<ulong, object>.MoveAfter
	|
	|-RVA: 0x5245BD8 Offset: 0x5241BD8 VA: 0x5245BD8
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveAfter
	*/

	// RVA: -1 Offset: -1
	internal TValue GetValueOrDefault(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C1D4 Offset: 0x52081D4 VA: 0x520C1D4
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.GetValueOrDefault
	|
	|-RVA: 0x520FF78 Offset: 0x520BF78 VA: 0x520FF78
	|-OrderedDictionary<EntityRef, int>.GetValueOrDefault
	|
	|-RVA: 0x5213DCC Offset: 0x520FDCC VA: 0x5213DCC
	|-OrderedDictionary<EntityRef, object>.GetValueOrDefault
	|
	|-RVA: 0x5217E44 Offset: 0x5213E44 VA: 0x5217E44
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.GetValueOrDefault
	|
	|-RVA: 0x521BF6C Offset: 0x5217F6C VA: 0x521BF6C
	|-OrderedDictionary<int, BulletLink>.GetValueOrDefault
	|
	|-RVA: 0x521FEF4 Offset: 0x521BEF4 VA: 0x521FEF4
	|-OrderedDictionary<int, HeroSkillCount>.GetValueOrDefault
	|
	|-RVA: 0x5223F6C Offset: 0x521FF6C VA: 0x5223F6C
	|-OrderedDictionary<int, int>.GetValueOrDefault
	|
	|-RVA: 0x5227D98 Offset: 0x5223D98 VA: 0x5227D98
	|-OrderedDictionary<int, object>.GetValueOrDefault
	|
	|-RVA: 0x522BB58 Offset: 0x5227B58 VA: 0x522BB58
	|-OrderedDictionary<Int32Enum, int>.GetValueOrDefault
	|
	|-RVA: 0x522F988 Offset: 0x522B988 VA: 0x522F988
	|-OrderedDictionary<long, object>.GetValueOrDefault
	|
	|-RVA: 0x5233724 Offset: 0x522F724 VA: 0x5233724
	|-OrderedDictionary<object, FP>.GetValueOrDefault
	|
	|-RVA: 0x523749C Offset: 0x523349C VA: 0x523749C
	|-OrderedDictionary<object, long>.GetValueOrDefault
	|
	|-RVA: 0x523B2B0 Offset: 0x52372B0 VA: 0x523B2B0
	|-OrderedDictionary<object, object>.GetValueOrDefault
	|
	|-RVA: 0x523F024 Offset: 0x523B024 VA: 0x523F024
	|-OrderedDictionary<ulong, object>.GetValueOrDefault
	|
	|-RVA: 0x5245FF0 Offset: 0x5241FF0 VA: 0x5245FF0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValueOrDefault
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C228 Offset: 0x5208228 VA: 0x520C228
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x520FFCC Offset: 0x520BFCC VA: 0x520FFCC
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x5213E20 Offset: 0x520FE20 VA: 0x5213E20
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x5217EAC Offset: 0x5213EAC VA: 0x5217EAC
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x521BFE4 Offset: 0x5217FE4 VA: 0x521BFE4
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x521FF48 Offset: 0x521BF48 VA: 0x521FF48
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x5223FC0 Offset: 0x521FFC0 VA: 0x5223FC0
	|-OrderedDictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x5227DEC Offset: 0x5223DEC VA: 0x5227DEC
	|-OrderedDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x522BBAC Offset: 0x5227BAC VA: 0x522BBAC
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x522F9DC Offset: 0x522B9DC VA: 0x522F9DC
	|-OrderedDictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x5233778 Offset: 0x522F778 VA: 0x5233778
	|-OrderedDictionary<object, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x52374F0 Offset: 0x52334F0 VA: 0x52374F0
	|-OrderedDictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x523B304 Offset: 0x5237304 VA: 0x523B304
	|-OrderedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x523F078 Offset: 0x523B078 VA: 0x523F078
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x52461A0 Offset: 0x52421A0 VA: 0x52461A0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C230 Offset: 0x5208230 VA: 0x520C230
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x520FFD4 Offset: 0x520BFD4 VA: 0x520FFD4
	|-OrderedDictionary<EntityRef, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x5213E28 Offset: 0x520FE28 VA: 0x5213E28
	|-OrderedDictionary<EntityRef, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x5217EB4 Offset: 0x5213EB4 VA: 0x5217EB4
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x521BFEC Offset: 0x5217FEC VA: 0x521BFEC
	|-OrderedDictionary<int, BulletLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x521FF50 Offset: 0x521BF50 VA: 0x521FF50
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x5223FC8 Offset: 0x521FFC8 VA: 0x5223FC8
	|-OrderedDictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x5227DF4 Offset: 0x5223DF4 VA: 0x5227DF4
	|-OrderedDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x522BBB4 Offset: 0x5227BB4 VA: 0x522BBB4
	|-OrderedDictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x522F9E4 Offset: 0x522B9E4 VA: 0x522F9E4
	|-OrderedDictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x5233780 Offset: 0x522F780 VA: 0x5233780
	|-OrderedDictionary<object, FP>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x52374F8 Offset: 0x52334F8 VA: 0x52374F8
	|-OrderedDictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x523B30C Offset: 0x523730C VA: 0x523B30C
	|-OrderedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x523F080 Offset: 0x523B080 VA: 0x523F080
	|-OrderedDictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x52461A8 Offset: 0x52421A8 VA: 0x52461A8
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C240 Offset: 0x5208240 VA: 0x520C240
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x520FFE4 Offset: 0x520BFE4 VA: 0x520FFE4
	|-OrderedDictionary<EntityRef, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x5213E38 Offset: 0x520FE38 VA: 0x5213E38
	|-OrderedDictionary<EntityRef, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x5217EC4 Offset: 0x5213EC4 VA: 0x5217EC4
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x521BFFC Offset: 0x5217FFC VA: 0x521BFFC
	|-OrderedDictionary<int, BulletLink>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x521FF60 Offset: 0x521BF60 VA: 0x521FF60
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x5223FD8 Offset: 0x521FFD8 VA: 0x5223FD8
	|-OrderedDictionary<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x5227E04 Offset: 0x5223E04 VA: 0x5227E04
	|-OrderedDictionary<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x522BBC4 Offset: 0x5227BC4 VA: 0x522BBC4
	|-OrderedDictionary<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x522F9F4 Offset: 0x522B9F4 VA: 0x522F9F4
	|-OrderedDictionary<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x5233790 Offset: 0x522F790 VA: 0x5233790
	|-OrderedDictionary<object, FP>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x5237508 Offset: 0x5233508 VA: 0x5237508
	|-OrderedDictionary<object, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x523B31C Offset: 0x523731C VA: 0x523B31C
	|-OrderedDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x523F090 Offset: 0x523B090 VA: 0x523F090
	|-OrderedDictionary<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x52461BC Offset: 0x52421BC VA: 0x52461BC
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C7C0 Offset: 0x52087C0 VA: 0x520C7C0
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5210558 Offset: 0x520C558 VA: 0x5210558
	|-OrderedDictionary<EntityRef, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5214368 Offset: 0x5210368 VA: 0x5214368
	|-OrderedDictionary<EntityRef, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5218444 Offset: 0x5214444 VA: 0x5218444
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x521C598 Offset: 0x5218598 VA: 0x521C598
	|-OrderedDictionary<int, BulletLink>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x52204E0 Offset: 0x521C4E0 VA: 0x52204E0
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5224558 Offset: 0x5220558 VA: 0x5224558
	|-OrderedDictionary<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5228334 Offset: 0x5224334 VA: 0x5228334
	|-OrderedDictionary<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x522C144 Offset: 0x5228144 VA: 0x522C144
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x522FF24 Offset: 0x522BF24 VA: 0x522FF24
	|-OrderedDictionary<long, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5233C9C Offset: 0x522FC9C VA: 0x5233C9C
	|-OrderedDictionary<object, FP>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5237A14 Offset: 0x5233A14 VA: 0x5237A14
	|-OrderedDictionary<object, long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x523B7E4 Offset: 0x52377E4 VA: 0x523B7E4
	|-OrderedDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x523F5C0 Offset: 0x523B5C0 VA: 0x523F5C0
	|-OrderedDictionary<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x52468C4 Offset: 0x52428C4 VA: 0x52468C4
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C824 Offset: 0x5208824 VA: 0x520C824
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x52105BC Offset: 0x520C5BC VA: 0x52105BC
	|-OrderedDictionary<EntityRef, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x52143CC Offset: 0x52103CC VA: 0x52143CC
	|-OrderedDictionary<EntityRef, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x52184A8 Offset: 0x52144A8 VA: 0x52184A8
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x521C600 Offset: 0x5218600 VA: 0x521C600
	|-OrderedDictionary<int, BulletLink>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x5220538 Offset: 0x521C538 VA: 0x5220538
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x52245B0 Offset: 0x52205B0 VA: 0x52245B0
	|-OrderedDictionary<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x5228398 Offset: 0x5224398 VA: 0x5228398
	|-OrderedDictionary<int, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x522C19C Offset: 0x522819C VA: 0x522C19C
	|-OrderedDictionary<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x522FF88 Offset: 0x522BF88 VA: 0x522FF88
	|-OrderedDictionary<long, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x5233D00 Offset: 0x522FD00 VA: 0x5233D00
	|-OrderedDictionary<object, FP>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x5237A78 Offset: 0x5233A78 VA: 0x5237A78
	|-OrderedDictionary<object, long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x523B848 Offset: 0x5237848 VA: 0x523B848
	|-OrderedDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x523F624 Offset: 0x523B624 VA: 0x523F624
	|-OrderedDictionary<ulong, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x5246978 Offset: 0x5242978 VA: 0x5246978
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C82C Offset: 0x520882C VA: 0x520C82C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x52105C4 Offset: 0x520C5C4 VA: 0x52105C4
	|-OrderedDictionary<EntityRef, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x52143D4 Offset: 0x52103D4 VA: 0x52143D4
	|-OrderedDictionary<EntityRef, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x52184B0 Offset: 0x52144B0 VA: 0x52184B0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x521C608 Offset: 0x5218608 VA: 0x521C608
	|-OrderedDictionary<int, BulletLink>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x5220540 Offset: 0x521C540 VA: 0x5220540
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x52245B8 Offset: 0x52205B8 VA: 0x52245B8
	|-OrderedDictionary<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x52283A0 Offset: 0x52243A0 VA: 0x52283A0
	|-OrderedDictionary<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x522C1A4 Offset: 0x52281A4 VA: 0x522C1A4
	|-OrderedDictionary<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x522FF90 Offset: 0x522BF90 VA: 0x522FF90
	|-OrderedDictionary<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x5233D08 Offset: 0x522FD08 VA: 0x5233D08
	|-OrderedDictionary<object, FP>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x5237A80 Offset: 0x5233A80 VA: 0x5237A80
	|-OrderedDictionary<object, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x523B850 Offset: 0x5237850 VA: 0x523B850
	|-OrderedDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x523F62C Offset: 0x523B62C VA: 0x523F62C
	|-OrderedDictionary<ulong, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x5246980 Offset: 0x5242980 VA: 0x5246980
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C89C Offset: 0x520889C VA: 0x520C89C
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x5210634 Offset: 0x520C634 VA: 0x5210634
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x5214444 Offset: 0x5210444 VA: 0x5214444
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x5218520 Offset: 0x5214520 VA: 0x5218520
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x521C678 Offset: 0x5218678 VA: 0x521C678
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x52205B0 Offset: 0x521C5B0 VA: 0x52205B0
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x5224628 Offset: 0x5220628 VA: 0x5224628
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x5228410 Offset: 0x5224410 VA: 0x5228410
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x522C214 Offset: 0x5228214 VA: 0x522C214
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x5230000 Offset: 0x522C000 VA: 0x5230000
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x5233D78 Offset: 0x522FD78 VA: 0x5233D78
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x5237AF0 Offset: 0x5233AF0 VA: 0x5237AF0
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x523B8C0 Offset: 0x52378C0 VA: 0x523B8C0
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x523F69C Offset: 0x523B69C VA: 0x523F69C
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x52469F0 Offset: 0x52429F0 VA: 0x52469F0
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C8A4 Offset: 0x52088A4 VA: 0x520C8A4
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x521063C Offset: 0x520C63C VA: 0x521063C
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x521444C Offset: 0x521044C VA: 0x521444C
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x5218528 Offset: 0x5214528 VA: 0x5218528
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x521C680 Offset: 0x5218680 VA: 0x521C680
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x52205B8 Offset: 0x521C5B8 VA: 0x52205B8
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x5224630 Offset: 0x5220630 VA: 0x5224630
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x5228418 Offset: 0x5224418 VA: 0x5228418
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x522C21C Offset: 0x522821C VA: 0x522C21C
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x5230008 Offset: 0x522C008 VA: 0x5230008
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x5233D80 Offset: 0x522FD80 VA: 0x5233D80
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x5237AF8 Offset: 0x5233AF8 VA: 0x5237AF8
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x523B8C8 Offset: 0x52378C8 VA: 0x523B8C8
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x523F6A4 Offset: 0x523B6A4 VA: 0x523F6A4
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x52469F8 Offset: 0x52429F8 VA: 0x52469F8
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C8AC Offset: 0x52088AC VA: 0x520C8AC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x5210644 Offset: 0x520C644 VA: 0x5210644
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x5214454 Offset: 0x5210454 VA: 0x5214454
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x5218530 Offset: 0x5214530 VA: 0x5218530
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x521C688 Offset: 0x5218688 VA: 0x521C688
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x52205C0 Offset: 0x521C5C0 VA: 0x52205C0
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x5224638 Offset: 0x5220638 VA: 0x5224638
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x5228420 Offset: 0x5224420 VA: 0x5228420
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x522C224 Offset: 0x5228224 VA: 0x522C224
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x5230010 Offset: 0x522C010 VA: 0x5230010
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x5233D88 Offset: 0x522FD88 VA: 0x5233D88
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x5237B00 Offset: 0x5233B00 VA: 0x5237B00
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x523B8D0 Offset: 0x52378D0 VA: 0x523B8D0
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x523F6AC Offset: 0x523B6AC VA: 0x523F6AC
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x5246A00 Offset: 0x5242A00 VA: 0x5246A00
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C8BC Offset: 0x52088BC VA: 0x520C8BC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x5210654 Offset: 0x520C654 VA: 0x5210654
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x5214464 Offset: 0x5210464 VA: 0x5214464
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x5218540 Offset: 0x5214540 VA: 0x5218540
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x521C698 Offset: 0x5218698 VA: 0x521C698
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x52205D0 Offset: 0x521C5D0 VA: 0x52205D0
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x5224648 Offset: 0x5220648 VA: 0x5224648
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x5228430 Offset: 0x5224430 VA: 0x5228430
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x522C234 Offset: 0x5228234 VA: 0x522C234
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x5230020 Offset: 0x522C020 VA: 0x5230020
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x5233D98 Offset: 0x522FD98 VA: 0x5233D98
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x5237B10 Offset: 0x5233B10 VA: 0x5237B10
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x523B8E0 Offset: 0x52378E0 VA: 0x523B8E0
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x523F6BC Offset: 0x523B6BC VA: 0x523F6BC
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x5246A14 Offset: 0x5242A14 VA: 0x5246A14
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C8CC Offset: 0x52088CC VA: 0x520C8CC
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x5210664 Offset: 0x520C664 VA: 0x5210664
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x5214474 Offset: 0x5210474 VA: 0x5214474
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x5218550 Offset: 0x5214550 VA: 0x5218550
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x521C6A8 Offset: 0x52186A8 VA: 0x521C6A8
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x52205E0 Offset: 0x521C5E0 VA: 0x52205E0
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x5224658 Offset: 0x5220658 VA: 0x5224658
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x5228440 Offset: 0x5224440 VA: 0x5228440
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x522C244 Offset: 0x5228244 VA: 0x522C244
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x5230030 Offset: 0x522C030 VA: 0x5230030
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x5233DA8 Offset: 0x522FDA8 VA: 0x5233DA8
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x5237B20 Offset: 0x5233B20 VA: 0x5237B20
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x523B8F0 Offset: 0x52378F0 VA: 0x523B8F0
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x523F6CC Offset: 0x523B6CC VA: 0x523F6CC
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x5246A28 Offset: 0x5242A28 VA: 0x5246A28
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520C9B4 Offset: 0x52089B4 VA: 0x520C9B4
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x521074C Offset: 0x520C74C VA: 0x521074C
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x521453C Offset: 0x521053C VA: 0x521453C
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x5218638 Offset: 0x5214638 VA: 0x5218638
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x521C7A4 Offset: 0x52187A4 VA: 0x521C7A4
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x52206C8 Offset: 0x521C6C8 VA: 0x52206C8
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x5224740 Offset: 0x5220740 VA: 0x5224740
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x5228508 Offset: 0x5224508 VA: 0x5228508
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x522C32C Offset: 0x522832C VA: 0x522C32C
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x52300F8 Offset: 0x522C0F8 VA: 0x52300F8
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x5233E90 Offset: 0x522FE90 VA: 0x5233E90
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x5237C08 Offset: 0x5233C08 VA: 0x5237C08
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x523B9C0 Offset: 0x52379C0 VA: 0x523B9C0
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x523F794 Offset: 0x523B794 VA: 0x523F794
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x5246BC4 Offset: 0x5242BC4 VA: 0x5246BC4
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520CCD0 Offset: 0x5208CD0 VA: 0x520CCD0
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.IsCompatibleKey
	|
	|-RVA: 0x5210A5C Offset: 0x520CA5C VA: 0x5210A5C
	|-OrderedDictionary<EntityRef, int>.IsCompatibleKey
	|
	|-RVA: 0x521484C Offset: 0x521084C VA: 0x521484C
	|-OrderedDictionary<EntityRef, object>.IsCompatibleKey
	|
	|-RVA: 0x521895C Offset: 0x521495C VA: 0x521895C
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.IsCompatibleKey
	|
	|-RVA: 0x521CADC Offset: 0x5218ADC VA: 0x521CADC
	|-OrderedDictionary<int, BulletLink>.IsCompatibleKey
	|
	|-RVA: 0x52209D8 Offset: 0x521C9D8 VA: 0x52209D8
	|-OrderedDictionary<int, HeroSkillCount>.IsCompatibleKey
	|
	|-RVA: 0x5224A50 Offset: 0x5220A50 VA: 0x5224A50
	|-OrderedDictionary<int, int>.IsCompatibleKey
	|
	|-RVA: 0x5228818 Offset: 0x5224818 VA: 0x5228818
	|-OrderedDictionary<int, object>.IsCompatibleKey
	|
	|-RVA: 0x522C63C Offset: 0x522863C VA: 0x522C63C
	|-OrderedDictionary<Int32Enum, int>.IsCompatibleKey
	|
	|-RVA: 0x5230408 Offset: 0x522C408 VA: 0x5230408
	|-OrderedDictionary<long, object>.IsCompatibleKey
	|
	|-RVA: 0x52341A0 Offset: 0x52301A0 VA: 0x52341A0
	|-OrderedDictionary<object, FP>.IsCompatibleKey
	|
	|-RVA: 0x5237F18 Offset: 0x5233F18 VA: 0x5237F18
	|-OrderedDictionary<object, long>.IsCompatibleKey
	|
	|-RVA: 0x523BCC8 Offset: 0x5237CC8 VA: 0x523BCC8
	|-OrderedDictionary<object, object>.IsCompatibleKey
	|
	|-RVA: 0x523FAA4 Offset: 0x523BAA4 VA: 0x523FAA4
	|-OrderedDictionary<ulong, object>.IsCompatibleKey
	|
	|-RVA: 0x5246F64 Offset: 0x5242F64 VA: 0x5246F64
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520CD24 Offset: 0x5208D24 VA: 0x520CD24
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x5210AB0 Offset: 0x520CAB0 VA: 0x5210AB0
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x52148A0 Offset: 0x52108A0 VA: 0x52148A0
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x52189B0 Offset: 0x52149B0 VA: 0x52189B0
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x521CB30 Offset: 0x5218B30 VA: 0x521CB30
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x5220A2C Offset: 0x521CA2C VA: 0x5220A2C
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x5224AA4 Offset: 0x5220AA4 VA: 0x5224AA4
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x522886C Offset: 0x522486C VA: 0x522886C
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x522C690 Offset: 0x5228690 VA: 0x522C690
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x523045C Offset: 0x522C45C VA: 0x523045C
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x52341F4 Offset: 0x52301F4 VA: 0x52341F4
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x5237F6C Offset: 0x5233F6C VA: 0x5237F6C
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x523BD1C Offset: 0x5237D1C VA: 0x523BD1C
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x523FAF8 Offset: 0x523BAF8 VA: 0x523FAF8
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x5246FB8 Offset: 0x5242FB8 VA: 0x5246FB8
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520D040 Offset: 0x5209040 VA: 0x520D040
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x5210DC0 Offset: 0x520CDC0 VA: 0x5210DC0
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x5214BB0 Offset: 0x5210BB0 VA: 0x5214BB0
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x5218CD4 Offset: 0x5214CD4 VA: 0x5218CD4
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x521CE68 Offset: 0x5218E68 VA: 0x521CE68
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x5220D3C Offset: 0x521CD3C VA: 0x5220D3C
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x5224DB4 Offset: 0x5220DB4 VA: 0x5224DB4
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x5228B7C Offset: 0x5224B7C VA: 0x5228B7C
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x522C9A0 Offset: 0x52289A0 VA: 0x522C9A0
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x523076C Offset: 0x522C76C VA: 0x523076C
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x5234504 Offset: 0x5230504 VA: 0x5234504
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x523827C Offset: 0x523427C VA: 0x523827C
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x523C024 Offset: 0x5238024 VA: 0x523C024
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x523FE08 Offset: 0x523BE08 VA: 0x523FE08
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x5247358 Offset: 0x5243358 VA: 0x5247358
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520D0F4 Offset: 0x52090F4 VA: 0x520D0F4
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x5210E74 Offset: 0x520CE74 VA: 0x5210E74
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x5214C64 Offset: 0x5210C64 VA: 0x5214C64
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x5218D88 Offset: 0x5214D88 VA: 0x5218D88
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x521CF1C Offset: 0x5218F1C VA: 0x521CF1C
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x5220DF0 Offset: 0x521CDF0 VA: 0x5220DF0
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x5224E68 Offset: 0x5220E68 VA: 0x5224E68
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x5228C30 Offset: 0x5224C30 VA: 0x5228C30
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x522CA54 Offset: 0x5228A54 VA: 0x522CA54
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x5230820 Offset: 0x522C820 VA: 0x5230820
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x52345BC Offset: 0x52305BC VA: 0x52345BC
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x5238334 Offset: 0x5234334 VA: 0x5238334
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x523C0DC Offset: 0x52380DC VA: 0x523C0DC
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x523FEBC Offset: 0x523BEBC VA: 0x523FEBC
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x5247468 Offset: 0x5243468 VA: 0x5247468
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x520D158 Offset: 0x5209158 VA: 0x520D158
	|-OrderedDictionary<ValueTuple<EntityRef, object>, FP>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x5210ED8 Offset: 0x520CED8 VA: 0x5210ED8
	|-OrderedDictionary<EntityRef, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x5214CC8 Offset: 0x5210CC8 VA: 0x5214CC8
	|-OrderedDictionary<EntityRef, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x5218DEC Offset: 0x5214DEC VA: 0x5218DEC
	|-OrderedDictionary<int, ValueTuple<object, object, object, object>>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x521CF84 Offset: 0x5218F84 VA: 0x521CF84
	|-OrderedDictionary<int, BulletLink>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x5220E48 Offset: 0x521CE48 VA: 0x5220E48
	|-OrderedDictionary<int, HeroSkillCount>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x5224EC0 Offset: 0x5220EC0 VA: 0x5224EC0
	|-OrderedDictionary<int, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x5228C94 Offset: 0x5224C94 VA: 0x5228C94
	|-OrderedDictionary<int, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x522CAAC Offset: 0x5228AAC VA: 0x522CAAC
	|-OrderedDictionary<Int32Enum, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x5230884 Offset: 0x522C884 VA: 0x5230884
	|-OrderedDictionary<long, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x5234620 Offset: 0x5230620 VA: 0x5234620
	|-OrderedDictionary<object, FP>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x5238398 Offset: 0x5234398 VA: 0x5238398
	|-OrderedDictionary<object, long>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x523C140 Offset: 0x5238140 VA: 0x523C140
	|-OrderedDictionary<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x523FF20 Offset: 0x523BF20 VA: 0x523FF20
	|-OrderedDictionary<ulong, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x524751C Offset: 0x524351C VA: 0x524751C
	|-OrderedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/
}

// Namespace: 
internal struct OrderedHashSet.Slot<T> // TypeDefIndex: 24237
{
	// Fields
	internal int hashCode; // 0x0
	internal T value; // 0x0
	internal int next; // 0x0
	internal int nextOrder; // 0x0
	internal int previousOrder; // 0x0
}

// Namespace: 
public struct OrderedHashSet.Reader<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 24238
{
	// Fields
	private OrderedHashSet<T> m_set; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544E168 Offset: 0x544A168 VA: 0x544E168
	|-OrderedHashSet.Reader<EntityRef>.get_Count
	|
	|-RVA: 0x544E388 Offset: 0x544A388 VA: 0x544E388
	|-OrderedHashSet.Reader<int>.get_Count
	|
	|-RVA: 0x544E5A8 Offset: 0x544A5A8 VA: 0x544E5A8
	|-OrderedHashSet.Reader<object>.get_Count
	|
	|-RVA: 0x544E7C8 Offset: 0x544A7C8 VA: 0x544E7C8
	|-OrderedHashSet.Reader<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor(OrderedHashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544E194 Offset: 0x544A194 VA: 0x544E194
	|-OrderedHashSet.Reader<EntityRef>..ctor
	|
	|-RVA: 0x544E3B4 Offset: 0x544A3B4 VA: 0x544E3B4
	|-OrderedHashSet.Reader<int>..ctor
	|
	|-RVA: 0x544E5D4 Offset: 0x544A5D4 VA: 0x544E5D4
	|-OrderedHashSet.Reader<object>..ctor
	|
	|-RVA: 0x544E848 Offset: 0x544A848 VA: 0x544E848
	|-OrderedHashSet.Reader<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544E19C Offset: 0x544A19C VA: 0x544E19C
	|-OrderedHashSet.Reader<EntityRef>.Contains
	|
	|-RVA: 0x544E3BC Offset: 0x544A3BC VA: 0x544E3BC
	|-OrderedHashSet.Reader<int>.Contains
	|
	|-RVA: 0x544E5DC Offset: 0x544A5DC VA: 0x544E5DC
	|-OrderedHashSet.Reader<object>.Contains
	|
	|-RVA: 0x544E850 Offset: 0x544A850 VA: 0x544E850
	|-OrderedHashSet.Reader<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.Range<T> StartWith(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544E1E0 Offset: 0x544A1E0 VA: 0x544E1E0
	|-OrderedHashSet.Reader<EntityRef>.StartWith
	|
	|-RVA: 0x544E400 Offset: 0x544A400 VA: 0x544E400
	|-OrderedHashSet.Reader<int>.StartWith
	|
	|-RVA: 0x544E620 Offset: 0x544A620 VA: 0x544E620
	|-OrderedHashSet.Reader<object>.StartWith
	|
	|-RVA: 0x544E9EC Offset: 0x544A9EC VA: 0x544E9EC
	|-OrderedHashSet.Reader<__Il2CppFullySharedGenericType>.StartWith
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544E234 Offset: 0x544A234 VA: 0x544E234
	|-OrderedHashSet.Reader<EntityRef>.GetEnumerator
	|
	|-RVA: 0x544E454 Offset: 0x544A454 VA: 0x544E454
	|-OrderedHashSet.Reader<int>.GetEnumerator
	|
	|-RVA: 0x544E674 Offset: 0x544A674 VA: 0x544E674
	|-OrderedHashSet.Reader<object>.GetEnumerator
	|
	|-RVA: 0x544EBBC Offset: 0x544ABBC VA: 0x544EBBC
	|-OrderedHashSet.Reader<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544E278 Offset: 0x544A278 VA: 0x544E278
	|-OrderedHashSet.Reader<EntityRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x544E498 Offset: 0x544A498 VA: 0x544E498
	|-OrderedHashSet.Reader<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x544E6B8 Offset: 0x544A6B8 VA: 0x544E6B8
	|-OrderedHashSet.Reader<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x544ECA4 Offset: 0x544ACA4 VA: 0x544ECA4
	|-OrderedHashSet.Reader<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544E300 Offset: 0x544A300 VA: 0x544E300
	|-OrderedHashSet.Reader<EntityRef>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x544E520 Offset: 0x544A520 VA: 0x544E520
	|-OrderedHashSet.Reader<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x544E740 Offset: 0x544A740 VA: 0x544E740
	|-OrderedHashSet.Reader<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x544EDC8 Offset: 0x544ADC8 VA: 0x544EDC8
	|-OrderedHashSet.Reader<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}

// Namespace: 
public struct OrderedHashSet.ReverseReader<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 24239
{
	// Fields
	private OrderedHashSet<T> m_set; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C5970 Offset: 0x54C1970 VA: 0x54C5970
	|-OrderedHashSet.ReverseReader<EntityRef>.get_Count
	|
	|-RVA: 0x54C5B88 Offset: 0x54C1B88 VA: 0x54C5B88
	|-OrderedHashSet.ReverseReader<int>.get_Count
	|
	|-RVA: 0x54C5DA0 Offset: 0x54C1DA0 VA: 0x54C5DA0
	|-OrderedHashSet.ReverseReader<object>.get_Count
	|
	|-RVA: 0x54C5FCC Offset: 0x54C1FCC VA: 0x54C5FCC
	|-OrderedHashSet.ReverseReader<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor(OrderedHashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C599C Offset: 0x54C199C VA: 0x54C599C
	|-OrderedHashSet.ReverseReader<EntityRef>..ctor
	|
	|-RVA: 0x54C5BB4 Offset: 0x54C1BB4 VA: 0x54C5BB4
	|-OrderedHashSet.ReverseReader<int>..ctor
	|
	|-RVA: 0x54C5DCC Offset: 0x54C1DCC VA: 0x54C5DCC
	|-OrderedHashSet.ReverseReader<object>..ctor
	|
	|-RVA: 0x54C604C Offset: 0x54C204C VA: 0x54C604C
	|-OrderedHashSet.ReverseReader<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C59A4 Offset: 0x54C19A4 VA: 0x54C59A4
	|-OrderedHashSet.ReverseReader<EntityRef>.Contains
	|
	|-RVA: 0x54C5BBC Offset: 0x54C1BBC VA: 0x54C5BBC
	|-OrderedHashSet.ReverseReader<int>.Contains
	|
	|-RVA: 0x54C5DD4 Offset: 0x54C1DD4 VA: 0x54C5DD4
	|-OrderedHashSet.ReverseReader<object>.Contains
	|
	|-RVA: 0x54C6054 Offset: 0x54C2054 VA: 0x54C6054
	|-OrderedHashSet.ReverseReader<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.ReverseRange<T> StartWith(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C59E8 Offset: 0x54C19E8 VA: 0x54C59E8
	|-OrderedHashSet.ReverseReader<EntityRef>.StartWith
	|
	|-RVA: 0x54C5C00 Offset: 0x54C1C00 VA: 0x54C5C00
	|-OrderedHashSet.ReverseReader<int>.StartWith
	|
	|-RVA: 0x54C5E18 Offset: 0x54C1E18 VA: 0x54C5E18
	|-OrderedHashSet.ReverseReader<object>.StartWith
	|
	|-RVA: 0x54C61F0 Offset: 0x54C21F0 VA: 0x54C61F0
	|-OrderedHashSet.ReverseReader<__Il2CppFullySharedGenericType>.StartWith
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.ReverseEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C5A34 Offset: 0x54C1A34 VA: 0x54C5A34
	|-OrderedHashSet.ReverseReader<EntityRef>.GetEnumerator
	|
	|-RVA: 0x54C5C4C Offset: 0x54C1C4C VA: 0x54C5C4C
	|-OrderedHashSet.ReverseReader<int>.GetEnumerator
	|
	|-RVA: 0x54C5E78 Offset: 0x54C1E78 VA: 0x54C5E78
	|-OrderedHashSet.ReverseReader<object>.GetEnumerator
	|
	|-RVA: 0x54C63C0 Offset: 0x54C23C0 VA: 0x54C63C0
	|-OrderedHashSet.ReverseReader<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C5A78 Offset: 0x54C1A78 VA: 0x54C5A78
	|-OrderedHashSet.ReverseReader<EntityRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C5C90 Offset: 0x54C1C90 VA: 0x54C5C90
	|-OrderedHashSet.ReverseReader<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C5EBC Offset: 0x54C1EBC VA: 0x54C5EBC
	|-OrderedHashSet.ReverseReader<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C64A8 Offset: 0x54C24A8 VA: 0x54C64A8
	|-OrderedHashSet.ReverseReader<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C5B00 Offset: 0x54C1B00 VA: 0x54C5B00
	|-OrderedHashSet.ReverseReader<EntityRef>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x54C5D18 Offset: 0x54C1D18 VA: 0x54C5D18
	|-OrderedHashSet.ReverseReader<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x54C5F44 Offset: 0x54C1F44 VA: 0x54C5F44
	|-OrderedHashSet.ReverseReader<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x54C65CC Offset: 0x54C25CC VA: 0x54C65CC
	|-OrderedHashSet.ReverseReader<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}

// Namespace: 
public struct OrderedHashSet.Range<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 24240
{
	// Fields
	private OrderedHashSet<T> m_set; // 0x0
	private T m_startingItem; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(OrderedHashSet<T> set, T startingItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52FC224 Offset: 0x52F8224 VA: 0x52FC224
	|-OrderedHashSet.Range<EntityRef>..ctor
	|
	|-RVA: 0x52FC3F0 Offset: 0x52F83F0 VA: 0x52FC3F0
	|-OrderedHashSet.Range<int>..ctor
	|
	|-RVA: 0x52FC5BC Offset: 0x52F85BC VA: 0x52FC5BC
	|-OrderedHashSet.Range<object>..ctor
	|
	|-RVA: 0x52FC790 Offset: 0x52F8790 VA: 0x52FC790
	|-OrderedHashSet.Range<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52FC24C Offset: 0x52F824C VA: 0x52FC24C
	|-OrderedHashSet.Range<EntityRef>.GetEnumerator
	|
	|-RVA: 0x52FC418 Offset: 0x52F8418 VA: 0x52FC418
	|-OrderedHashSet.Range<int>.GetEnumerator
	|
	|-RVA: 0x52FC5EC Offset: 0x52F85EC VA: 0x52FC5EC
	|-OrderedHashSet.Range<object>.GetEnumerator
	|
	|-RVA: 0x52FC8E8 Offset: 0x52F88E8 VA: 0x52FC8E8
	|-OrderedHashSet.Range<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52FC2E0 Offset: 0x52F82E0 VA: 0x52FC2E0
	|-OrderedHashSet.Range<EntityRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x52FC4AC Offset: 0x52F84AC VA: 0x52FC4AC
	|-OrderedHashSet.Range<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x52FC680 Offset: 0x52F8680 VA: 0x52FC680
	|-OrderedHashSet.Range<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x52FCB68 Offset: 0x52F8B68 VA: 0x52FCB68
	|-OrderedHashSet.Range<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52FC368 Offset: 0x52F8368 VA: 0x52FC368
	|-OrderedHashSet.Range<EntityRef>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x52FC534 Offset: 0x52F8534 VA: 0x52FC534
	|-OrderedHashSet.Range<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x52FC708 Offset: 0x52F8708 VA: 0x52FC708
	|-OrderedHashSet.Range<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x52FCC8C Offset: 0x52F8C8C VA: 0x52FCC8C
	|-OrderedHashSet.Range<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}

// Namespace: 
public struct OrderedHashSet.ReverseRange<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 24241
{
	// Fields
	private OrderedHashSet<T> m_set; // 0x0
	private T m_startingItem; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(OrderedHashSet<T> set, T startingItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C4E08 Offset: 0x54C0E08 VA: 0x54C4E08
	|-OrderedHashSet.ReverseRange<EntityRef>..ctor
	|
	|-RVA: 0x54C4FC8 Offset: 0x54C0FC8 VA: 0x54C4FC8
	|-OrderedHashSet.ReverseRange<int>..ctor
	|
	|-RVA: 0x54C5188 Offset: 0x54C1188 VA: 0x54C5188
	|-OrderedHashSet.ReverseRange<object>..ctor
	|
	|-RVA: 0x54C5350 Offset: 0x54C1350 VA: 0x54C5350
	|-OrderedHashSet.ReverseRange<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.ReverseEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C4E30 Offset: 0x54C0E30 VA: 0x54C4E30
	|-OrderedHashSet.ReverseRange<EntityRef>.GetEnumerator
	|
	|-RVA: 0x54C4FF0 Offset: 0x54C0FF0 VA: 0x54C4FF0
	|-OrderedHashSet.ReverseRange<int>.GetEnumerator
	|
	|-RVA: 0x54C51B8 Offset: 0x54C11B8 VA: 0x54C51B8
	|-OrderedHashSet.ReverseRange<object>.GetEnumerator
	|
	|-RVA: 0x54C54A8 Offset: 0x54C14A8 VA: 0x54C54A8
	|-OrderedHashSet.ReverseRange<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C4EB8 Offset: 0x54C0EB8 VA: 0x54C4EB8
	|-OrderedHashSet.ReverseRange<EntityRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C5078 Offset: 0x54C1078 VA: 0x54C5078
	|-OrderedHashSet.ReverseRange<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C5240 Offset: 0x54C1240 VA: 0x54C5240
	|-OrderedHashSet.ReverseRange<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x54C5728 Offset: 0x54C1728 VA: 0x54C5728
	|-OrderedHashSet.ReverseRange<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C4F40 Offset: 0x54C0F40 VA: 0x54C4F40
	|-OrderedHashSet.ReverseRange<EntityRef>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x54C5100 Offset: 0x54C1100 VA: 0x54C5100
	|-OrderedHashSet.ReverseRange<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x54C52C8 Offset: 0x54C12C8 VA: 0x54C52C8
	|-OrderedHashSet.ReverseRange<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x54C584C Offset: 0x54C184C VA: 0x54C584C
	|-OrderedHashSet.ReverseRange<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}

// Namespace: 
[Serializable]
public struct OrderedHashSet.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 24242
{
	// Fields
	private OrderedHashSet<T> m_set; // 0x0
	private int m_index; // 0x0
	private int m_version; // 0x0
	private T m_current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60DECA0 Offset: 0x60DACA0 VA: 0x60DECA0
	|-OrderedHashSet.Enumerator<EntityRef>.get_Current
	|
	|-RVA: 0x60E2620 Offset: 0x60DE620 VA: 0x60E2620
	|-OrderedHashSet.Enumerator<int>.get_Current
	|
	|-RVA: 0x60E97FC Offset: 0x60E57FC VA: 0x60E97FC
	|-OrderedHashSet.Enumerator<object>.get_Current
	|
	|-RVA: 0x60FDC50 Offset: 0x60F9C50 VA: 0x60FDC50
	|-OrderedHashSet.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedHashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60DECA8 Offset: 0x60DACA8 VA: 0x60DECA8
	|-OrderedHashSet.Enumerator<EntityRef>..ctor
	|
	|-RVA: 0x60E2628 Offset: 0x60DE628 VA: 0x60E2628
	|-OrderedHashSet.Enumerator<int>..ctor
	|
	|-RVA: 0x60E9804 Offset: 0x60E5804 VA: 0x60E9804
	|-OrderedHashSet.Enumerator<object>..ctor
	|
	|-RVA: 0x60FDD40 Offset: 0x60F9D40 VA: 0x60FDD40
	|-OrderedHashSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedHashSet<T> set, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60DECEC Offset: 0x60DACEC VA: 0x60DECEC
	|-OrderedHashSet.Enumerator<EntityRef>..ctor
	|
	|-RVA: 0x60E266C Offset: 0x60DE66C VA: 0x60E266C
	|-OrderedHashSet.Enumerator<int>..ctor
	|
	|-RVA: 0x60E9848 Offset: 0x60E5848 VA: 0x60E9848
	|-OrderedHashSet.Enumerator<object>..ctor
	|
	|-RVA: 0x60FDDD8 Offset: 0x60F9DD8 VA: 0x60FDDD8
	|-OrderedHashSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60DED2C Offset: 0x60DAD2C VA: 0x60DED2C
	|-OrderedHashSet.Enumerator<EntityRef>.MoveNext
	|
	|-RVA: 0x60E26A8 Offset: 0x60DE6A8 VA: 0x60E26A8
	|-OrderedHashSet.Enumerator<int>.MoveNext
	|
	|-RVA: 0x60E9888 Offset: 0x60E5888 VA: 0x60E9888
	|-OrderedHashSet.Enumerator<object>.MoveNext
	|
	|-RVA: 0x60FDEF8 Offset: 0x60F9EF8 VA: 0x60FDEF8
	|-OrderedHashSet.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60DEDFC Offset: 0x60DADFC VA: 0x60DEDFC
	|-OrderedHashSet.Enumerator<EntityRef>.System.IDisposable.Dispose
	|
	|-RVA: 0x60E2764 Offset: 0x60DE764 VA: 0x60E2764
	|-OrderedHashSet.Enumerator<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x60E9970 Offset: 0x60E5970 VA: 0x60E9970
	|-OrderedHashSet.Enumerator<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x60FE270 Offset: 0x60FA270 VA: 0x60FE270
	|-OrderedHashSet.Enumerator<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60DEE00 Offset: 0x60DAE00 VA: 0x60DEE00
	|-OrderedHashSet.Enumerator<EntityRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60E2768 Offset: 0x60DE768 VA: 0x60E2768
	|-OrderedHashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60E9974 Offset: 0x60E5974 VA: 0x60E9974
	|-OrderedHashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60FE274 Offset: 0x60FA274 VA: 0x60FE274
	|-OrderedHashSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60DEEBC Offset: 0x60DAEBC VA: 0x60DEEBC
	|-OrderedHashSet.Enumerator<EntityRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60E2824 Offset: 0x60DE824 VA: 0x60E2824
	|-OrderedHashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60E9A04 Offset: 0x60E5A04 VA: 0x60E9A04
	|-OrderedHashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60FE480 Offset: 0x60FA480 VA: 0x60FE480
	|-OrderedHashSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[Serializable]
public struct OrderedHashSet.ReverseEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 24243
{
	// Fields
	private OrderedHashSet<T> m_set; // 0x0
	private int m_index; // 0x0
	private int m_version; // 0x0
	private T m_current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BCAAC Offset: 0x54B8AAC VA: 0x54BCAAC
	|-OrderedHashSet.ReverseEnumerator<EntityRef>.get_Current
	|
	|-RVA: 0x54BCCFC Offset: 0x54B8CFC VA: 0x54BCCFC
	|-OrderedHashSet.ReverseEnumerator<int>.get_Current
	|
	|-RVA: 0x54BCF34 Offset: 0x54B8F34 VA: 0x54BCF34
	|-OrderedHashSet.ReverseEnumerator<object>.get_Current
	|
	|-RVA: 0x54BD170 Offset: 0x54B9170 VA: 0x54BD170
	|-OrderedHashSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedHashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BCAB4 Offset: 0x54B8AB4 VA: 0x54BCAB4
	|-OrderedHashSet.ReverseEnumerator<EntityRef>..ctor
	|
	|-RVA: 0x54BCD04 Offset: 0x54B8D04 VA: 0x54BCD04
	|-OrderedHashSet.ReverseEnumerator<int>..ctor
	|
	|-RVA: 0x54BCF3C Offset: 0x54B8F3C VA: 0x54BCF3C
	|-OrderedHashSet.ReverseEnumerator<object>..ctor
	|
	|-RVA: 0x54BD260 Offset: 0x54B9260 VA: 0x54BD260
	|-OrderedHashSet.ReverseEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(OrderedHashSet<T> set, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BCAF8 Offset: 0x54B8AF8 VA: 0x54BCAF8
	|-OrderedHashSet.ReverseEnumerator<EntityRef>..ctor
	|
	|-RVA: 0x54BCD48 Offset: 0x54B8D48 VA: 0x54BCD48
	|-OrderedHashSet.ReverseEnumerator<int>..ctor
	|
	|-RVA: 0x54BCF80 Offset: 0x54B8F80 VA: 0x54BCF80
	|-OrderedHashSet.ReverseEnumerator<object>..ctor
	|
	|-RVA: 0x54BD2F8 Offset: 0x54B92F8 VA: 0x54BD2F8
	|-OrderedHashSet.ReverseEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BCB38 Offset: 0x54B8B38 VA: 0x54BCB38
	|-OrderedHashSet.ReverseEnumerator<EntityRef>.MoveNext
	|
	|-RVA: 0x54BCD84 Offset: 0x54B8D84 VA: 0x54BCD84
	|-OrderedHashSet.ReverseEnumerator<int>.MoveNext
	|
	|-RVA: 0x54BCFC0 Offset: 0x54B8FC0 VA: 0x54BCFC0
	|-OrderedHashSet.ReverseEnumerator<object>.MoveNext
	|
	|-RVA: 0x54BD418 Offset: 0x54B9418 VA: 0x54BD418
	|-OrderedHashSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BCC08 Offset: 0x54B8C08 VA: 0x54BCC08
	|-OrderedHashSet.ReverseEnumerator<EntityRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54BCE40 Offset: 0x54B8E40 VA: 0x54BCE40
	|-OrderedHashSet.ReverseEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54BD0A8 Offset: 0x54B90A8 VA: 0x54BD0A8
	|-OrderedHashSet.ReverseEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x54BD790 Offset: 0x54B9790 VA: 0x54BD790
	|-OrderedHashSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BCCC4 Offset: 0x54B8CC4 VA: 0x54BCCC4
	|-OrderedHashSet.ReverseEnumerator<EntityRef>.System.IDisposable.Dispose
	|
	|-RVA: 0x54BCEFC Offset: 0x54B8EFC VA: 0x54BCEFC
	|-OrderedHashSet.ReverseEnumerator<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x54BD138 Offset: 0x54B9138 VA: 0x54BD138
	|-OrderedHashSet.ReverseEnumerator<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x54BD99C Offset: 0x54B999C VA: 0x54BD99C
	|-OrderedHashSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BCCC8 Offset: 0x54B8CC8 VA: 0x54BCCC8
	|-OrderedHashSet.ReverseEnumerator<EntityRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54BCF00 Offset: 0x54B8F00 VA: 0x54BCF00
	|-OrderedHashSet.ReverseEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54BD13C Offset: 0x54B913C VA: 0x54BD13C
	|-OrderedHashSet.ReverseEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x54BD9A0 Offset: 0x54B99A0 VA: 0x54BD9A0
	|-OrderedHashSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: Rock.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[Serializable]
public class OrderedHashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 24244
{
	// Fields
	private static bool IsValueType; // 0x0
	private static bool IsNullable; // 0x0
	private const int Lower31BitMask = 2147483647;
	private const int GrowthFactor = 2;
	private const int ShrinkThreshold = 3;
	private const string CapacityName = "Capacity";
	private const string ElementsName = "Elements";
	private const string ComparerName = "Comparer";
	private const string VersionName = "Version";
	private int[] m_buckets; // 0x0
	private OrderedHashSet.Slot<T>[] m_slots; // 0x0
	private int m_count; // 0x0
	private int m_lastIndex; // 0x0
	private int m_freeList; // 0x0
	private IEqualityComparer<T> m_comparer; // 0x0
	private int m_version; // 0x0
	private int m_firstOrderIndex; // 0x0
	private int m_lastOrderIndex; // 0x0
	private SerializationInfo m_siInfo; // 0x0

	// Properties
	public int Count { get; }
	public OrderedHashSet.Reader<T> Items { get; }
	public OrderedHashSet.ReverseReader<T> Reversed { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	public IEqualityComparer<T> Comparer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5249684 Offset: 0x5245684 VA: 0x5249684
	|-OrderedHashSet<EntityRef>.get_Count
	|
	|-RVA: 0x524BF48 Offset: 0x5247F48 VA: 0x524BF48
	|-OrderedHashSet<int>.get_Count
	|
	|-RVA: 0x524E714 Offset: 0x524A714 VA: 0x524E714
	|-OrderedHashSet<object>.get_Count
	|
	|-RVA: 0x5250E90 Offset: 0x524CE90 VA: 0x5250E90
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.Reader<T> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524968C Offset: 0x524568C VA: 0x524968C
	|-OrderedHashSet<EntityRef>.get_Items
	|
	|-RVA: 0x524BF50 Offset: 0x5247F50 VA: 0x524BF50
	|-OrderedHashSet<int>.get_Items
	|
	|-RVA: 0x524E71C Offset: 0x524A71C VA: 0x524E71C
	|-OrderedHashSet<object>.get_Items
	|
	|-RVA: 0x5250E98 Offset: 0x524CE98 VA: 0x5250E98
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.ReverseReader<T> get_Reversed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52496AC Offset: 0x52456AC VA: 0x52496AC
	|-OrderedHashSet<EntityRef>.get_Reversed
	|
	|-RVA: 0x524BF70 Offset: 0x5247F70 VA: 0x524BF70
	|-OrderedHashSet<int>.get_Reversed
	|
	|-RVA: 0x524E73C Offset: 0x524A73C VA: 0x524E73C
	|-OrderedHashSet<object>.get_Reversed
	|
	|-RVA: 0x5250EB8 Offset: 0x524CEB8 VA: 0x5250EB8
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.get_Reversed
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52496CC Offset: 0x52456CC VA: 0x52496CC
	|-OrderedHashSet<EntityRef>..ctor
	|
	|-RVA: 0x524BF90 Offset: 0x5247F90 VA: 0x524BF90
	|-OrderedHashSet<int>..ctor
	|
	|-RVA: 0x524E75C Offset: 0x524A75C VA: 0x524E75C
	|-OrderedHashSet<object>..ctor
	|
	|-RVA: 0x5250ED8 Offset: 0x524CED8 VA: 0x5250ED8
	|-OrderedHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5249720 Offset: 0x5245720 VA: 0x5249720
	|-OrderedHashSet<EntityRef>..ctor
	|
	|-RVA: 0x524BFE4 Offset: 0x5247FE4 VA: 0x524BFE4
	|-OrderedHashSet<int>..ctor
	|
	|-RVA: 0x524E7B0 Offset: 0x524A7B0 VA: 0x524E7B0
	|-OrderedHashSet<object>..ctor
	|
	|-RVA: 0x5250F24 Offset: 0x524CF24 VA: 0x5250F24
	|-OrderedHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524976C Offset: 0x524576C VA: 0x524976C
	|-OrderedHashSet<EntityRef>..ctor
	|
	|-RVA: 0x524C030 Offset: 0x5248030 VA: 0x524C030
	|-OrderedHashSet<int>..ctor
	|
	|-RVA: 0x524E7FC Offset: 0x524A7FC VA: 0x524E7FC
	|-OrderedHashSet<object>..ctor
	|
	|-RVA: 0x5250F78 Offset: 0x524CF78 VA: 0x5250F78
	|-OrderedHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5249788 Offset: 0x5245788 VA: 0x5249788
	|-OrderedHashSet<EntityRef>..ctor
	|
	|-RVA: 0x524C04C Offset: 0x524804C VA: 0x524C04C
	|-OrderedHashSet<int>..ctor
	|
	|-RVA: 0x524E818 Offset: 0x524A818 VA: 0x524E818
	|-OrderedHashSet<object>..ctor
	|
	|-RVA: 0x5250F98 Offset: 0x524CF98 VA: 0x5250F98
	|-OrderedHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524982C Offset: 0x524582C VA: 0x524982C
	|-OrderedHashSet<EntityRef>..ctor
	|
	|-RVA: 0x524C0F0 Offset: 0x52480F0 VA: 0x524C0F0
	|-OrderedHashSet<int>..ctor
	|
	|-RVA: 0x524E8BC Offset: 0x524A8BC VA: 0x524E8BC
	|-OrderedHashSet<object>..ctor
	|
	|-RVA: 0x5251044 Offset: 0x524D044 VA: 0x5251044
	|-OrderedHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5249878 Offset: 0x5245878 VA: 0x5249878
	|-OrderedHashSet<EntityRef>..ctor
	|
	|-RVA: 0x524C13C Offset: 0x524813C VA: 0x524C13C
	|-OrderedHashSet<int>..ctor
	|
	|-RVA: 0x524E908 Offset: 0x524A908 VA: 0x524E908
	|-OrderedHashSet<object>..ctor
	|
	|-RVA: 0x5251098 Offset: 0x524D098 VA: 0x5251098
	|-OrderedHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5249A90 Offset: 0x5245A90 VA: 0x5249A90
	|-OrderedHashSet<EntityRef>..ctor
	|
	|-RVA: 0x524C354 Offset: 0x5248354 VA: 0x524C354
	|-OrderedHashSet<int>..ctor
	|
	|-RVA: 0x524EB20 Offset: 0x524AB20 VA: 0x524EB20
	|-OrderedHashSet<object>..ctor
	|
	|-RVA: 0x52512B0 Offset: 0x524D2B0 VA: 0x52512B0
	|-OrderedHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5249AC0 Offset: 0x5245AC0 VA: 0x5249AC0
	|-OrderedHashSet<EntityRef>.GetObjectData
	|
	|-RVA: 0x524C384 Offset: 0x5248384 VA: 0x524C384
	|-OrderedHashSet<int>.GetObjectData
	|
	|-RVA: 0x524EB50 Offset: 0x524AB50 VA: 0x524EB50
	|-OrderedHashSet<object>.GetObjectData
	|
	|-RVA: 0x52512E0 Offset: 0x524D2E0 VA: 0x52512E0
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5249CDC Offset: 0x5245CDC VA: 0x5249CDC
	|-OrderedHashSet<EntityRef>.OnDeserialization
	|
	|-RVA: 0x524C5A0 Offset: 0x52485A0 VA: 0x524C5A0
	|-OrderedHashSet<int>.OnDeserialization
	|
	|-RVA: 0x524ED6C Offset: 0x524AD6C VA: 0x524ED6C
	|-OrderedHashSet<object>.OnDeserialization
	|
	|-RVA: 0x52514EC Offset: 0x524D4EC VA: 0x52514EC
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A06C Offset: 0x524606C VA: 0x524A06C
	|-OrderedHashSet<EntityRef>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x524C930 Offset: 0x5248930 VA: 0x524C930
	|-OrderedHashSet<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x524F0FC Offset: 0x524B0FC VA: 0x524F0FC
	|-OrderedHashSet<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x5251908 Offset: 0x524D908 VA: 0x5251908
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A074 Offset: 0x5246074 VA: 0x524A074
	|-OrderedHashSet<EntityRef>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x524C938 Offset: 0x5248938 VA: 0x524C938
	|-OrderedHashSet<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x524F104 Offset: 0x524B104 VA: 0x524F104
	|-OrderedHashSet<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x5251910 Offset: 0x524D910 VA: 0x5251910
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A084 Offset: 0x5246084 VA: 0x524A084
	|-OrderedHashSet<EntityRef>.Clear
	|
	|-RVA: 0x524C948 Offset: 0x5248948 VA: 0x524C948
	|-OrderedHashSet<int>.Clear
	|
	|-RVA: 0x524F114 Offset: 0x524B114 VA: 0x524F114
	|-OrderedHashSet<object>.Clear
	|
	|-RVA: 0x52519CC Offset: 0x524D9CC VA: 0x52519CC
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A0EC Offset: 0x52460EC VA: 0x524A0EC
	|-OrderedHashSet<EntityRef>.Contains
	|
	|-RVA: 0x524C9B0 Offset: 0x52489B0 VA: 0x524C9B0
	|-OrderedHashSet<int>.Contains
	|
	|-RVA: 0x524F17C Offset: 0x524B17C VA: 0x524F17C
	|-OrderedHashSet<object>.Contains
	|
	|-RVA: 0x5251A34 Offset: 0x524DA34 VA: 0x5251A34
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A254 Offset: 0x5246254 VA: 0x524A254
	|-OrderedHashSet<EntityRef>.CopyTo
	|
	|-RVA: 0x524CB24 Offset: 0x5248B24 VA: 0x524CB24
	|-OrderedHashSet<int>.CopyTo
	|
	|-RVA: 0x524F2E4 Offset: 0x524B2E4 VA: 0x524F2E4
	|-OrderedHashSet<object>.CopyTo
	|
	|-RVA: 0x5251D50 Offset: 0x524DD50 VA: 0x5251D50
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void UnionWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A268 Offset: 0x5246268 VA: 0x524A268
	|-OrderedHashSet<EntityRef>.UnionWith
	|
	|-RVA: 0x524CB38 Offset: 0x5248B38 VA: 0x524CB38
	|-OrderedHashSet<int>.UnionWith
	|
	|-RVA: 0x524F2F8 Offset: 0x524B2F8 VA: 0x524F2F8
	|-OrderedHashSet<object>.UnionWith
	|
	|-RVA: 0x5251D68 Offset: 0x524DD68 VA: 0x5251D68
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.UnionWith
	*/

	// RVA: -1 Offset: -1
	private int InternalIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A590 Offset: 0x5246590 VA: 0x524A590
	|-OrderedHashSet<EntityRef>.InternalIndexOf
	|
	|-RVA: 0x524CE60 Offset: 0x5248E60 VA: 0x524CE60
	|-OrderedHashSet<int>.InternalIndexOf
	|
	|-RVA: 0x524F620 Offset: 0x524B620 VA: 0x524F620
	|-OrderedHashSet<object>.InternalIndexOf
	|
	|-RVA: 0x525216C Offset: 0x524E16C VA: 0x525216C
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.InternalIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A6EC Offset: 0x52466EC VA: 0x524A6EC
	|-OrderedHashSet<EntityRef>.Remove
	|
	|-RVA: 0x524CFC8 Offset: 0x5248FC8 VA: 0x524CFC8
	|-OrderedHashSet<int>.Remove
	|
	|-RVA: 0x524F77C Offset: 0x524B77C VA: 0x524F77C
	|-OrderedHashSet<object>.Remove
	|
	|-RVA: 0x525246C Offset: 0x524E46C VA: 0x525246C
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A9CC Offset: 0x52469CC VA: 0x524A9CC
	|-OrderedHashSet<EntityRef>.GetEnumerator
	|
	|-RVA: 0x524D2D4 Offset: 0x52492D4 VA: 0x524D2D4
	|-OrderedHashSet<int>.GetEnumerator
	|
	|-RVA: 0x524FA5C Offset: 0x524BA5C VA: 0x524FA5C
	|-OrderedHashSet<object>.GetEnumerator
	|
	|-RVA: 0x5252BE0 Offset: 0x524EBE0 VA: 0x5252BE0
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524A9EC Offset: 0x52469EC VA: 0x524A9EC
	|-OrderedHashSet<EntityRef>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x524D2F4 Offset: 0x52492F4 VA: 0x524D2F4
	|-OrderedHashSet<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x524FA7C Offset: 0x524BA7C VA: 0x524FA7C
	|-OrderedHashSet<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x5252C90 Offset: 0x524EC90 VA: 0x5252C90
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524AA48 Offset: 0x5246A48 VA: 0x524AA48
	|-OrderedHashSet<EntityRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x524D350 Offset: 0x5249350 VA: 0x524D350
	|-OrderedHashSet<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x524FAD8 Offset: 0x524BAD8 VA: 0x524FAD8
	|-OrderedHashSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5252D40 Offset: 0x524ED40 VA: 0x5252D40
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524AAA4 Offset: 0x5246AA4 VA: 0x524AAA4
	|-OrderedHashSet<EntityRef>.CopyTo
	|
	|-RVA: 0x524D3AC Offset: 0x52493AC VA: 0x524D3AC
	|-OrderedHashSet<int>.CopyTo
	|
	|-RVA: 0x524FB34 Offset: 0x524BB34 VA: 0x524FB34
	|-OrderedHashSet<object>.CopyTo
	|
	|-RVA: 0x5252DF0 Offset: 0x524EDF0 VA: 0x5252DF0
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524AABC Offset: 0x5246ABC VA: 0x524AABC
	|-OrderedHashSet<EntityRef>.CopyTo
	|
	|-RVA: 0x524D3C4 Offset: 0x52493C4 VA: 0x524D3C4
	|-OrderedHashSet<int>.CopyTo
	|
	|-RVA: 0x524FB4C Offset: 0x524BB4C VA: 0x524FB4C
	|-OrderedHashSet<object>.CopyTo
	|
	|-RVA: 0x5252E0C Offset: 0x524EE0C VA: 0x5252E0C
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool MoveFirst(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524AC6C Offset: 0x5246C6C VA: 0x524AC6C
	|-OrderedHashSet<EntityRef>.MoveFirst
	|
	|-RVA: 0x524D560 Offset: 0x5249560 VA: 0x524D560
	|-OrderedHashSet<int>.MoveFirst
	|
	|-RVA: 0x524FD18 Offset: 0x524BD18 VA: 0x524FD18
	|-OrderedHashSet<object>.MoveFirst
	|
	|-RVA: 0x52530F4 Offset: 0x524F0F4 VA: 0x52530F4
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.MoveFirst
	*/

	// RVA: -1 Offset: -1
	public bool MoveLast(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524AD38 Offset: 0x5246D38 VA: 0x524AD38
	|-OrderedHashSet<EntityRef>.MoveLast
	|
	|-RVA: 0x524D63C Offset: 0x524963C VA: 0x524D63C
	|-OrderedHashSet<int>.MoveLast
	|
	|-RVA: 0x524FDE4 Offset: 0x524BDE4 VA: 0x524FDE4
	|-OrderedHashSet<object>.MoveLast
	|
	|-RVA: 0x52533EC Offset: 0x524F3EC VA: 0x52533EC
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.MoveLast
	*/

	// RVA: -1 Offset: -1
	public bool MoveBefore(T itemToMove, T mark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524AE04 Offset: 0x5246E04 VA: 0x524AE04
	|-OrderedHashSet<EntityRef>.MoveBefore
	|
	|-RVA: 0x524D71C Offset: 0x524971C VA: 0x524D71C
	|-OrderedHashSet<int>.MoveBefore
	|
	|-RVA: 0x524FEB0 Offset: 0x524BEB0 VA: 0x524FEB0
	|-OrderedHashSet<object>.MoveBefore
	|
	|-RVA: 0x52536E4 Offset: 0x524F6E4 VA: 0x52536E4
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.MoveBefore
	*/

	// RVA: -1 Offset: -1
	public bool MoveAfter(T itemToMove, T mark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524AF3C Offset: 0x5246F3C VA: 0x524AF3C
	|-OrderedHashSet<EntityRef>.MoveAfter
	|
	|-RVA: 0x524D85C Offset: 0x524985C VA: 0x524D85C
	|-OrderedHashSet<int>.MoveAfter
	|
	|-RVA: 0x524FFE8 Offset: 0x524BFE8 VA: 0x524FFE8
	|-OrderedHashSet<object>.MoveAfter
	|
	|-RVA: 0x5253AFC Offset: 0x524FAFC VA: 0x5253AFC
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.MoveAfter
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.Range<T> StartWith(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524B074 Offset: 0x5247074 VA: 0x524B074
	|-OrderedHashSet<EntityRef>.StartWith
	|
	|-RVA: 0x524D994 Offset: 0x5249994 VA: 0x524D994
	|-OrderedHashSet<int>.StartWith
	|
	|-RVA: 0x5250120 Offset: 0x524C120 VA: 0x5250120
	|-OrderedHashSet<object>.StartWith
	|
	|-RVA: 0x5253F14 Offset: 0x524FF14 VA: 0x5253F14
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.StartWith
	*/

	// RVA: -1 Offset: -1
	public OrderedHashSet.ReverseRange<T> StartWithReversed(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524B0B0 Offset: 0x52470B0 VA: 0x524B0B0
	|-OrderedHashSet<EntityRef>.StartWithReversed
	|
	|-RVA: 0x524D9D0 Offset: 0x52499D0 VA: 0x524D9D0
	|-OrderedHashSet<int>.StartWithReversed
	|
	|-RVA: 0x525015C Offset: 0x524C15C VA: 0x525015C
	|-OrderedHashSet<object>.StartWithReversed
	|
	|-RVA: 0x5254048 Offset: 0x5250048 VA: 0x5254048
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.StartWithReversed
	*/

	// RVA: -1 Offset: -1
	public int RemoveWhere(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524B0EC Offset: 0x52470EC VA: 0x524B0EC
	|-OrderedHashSet<EntityRef>.RemoveWhere
	|
	|-RVA: 0x524DA0C Offset: 0x5249A0C VA: 0x524DA0C
	|-OrderedHashSet<int>.RemoveWhere
	|
	|-RVA: 0x5250198 Offset: 0x524C198 VA: 0x5250198
	|-OrderedHashSet<object>.RemoveWhere
	|
	|-RVA: 0x525417C Offset: 0x525017C VA: 0x525417C
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.RemoveWhere
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524B1F8 Offset: 0x52471F8 VA: 0x524B1F8
	|-OrderedHashSet<EntityRef>.get_Comparer
	|
	|-RVA: 0x524DB18 Offset: 0x5249B18 VA: 0x524DB18
	|-OrderedHashSet<int>.get_Comparer
	|
	|-RVA: 0x52502A4 Offset: 0x524C2A4 VA: 0x52502A4
	|-OrderedHashSet<object>.get_Comparer
	|
	|-RVA: 0x52543F8 Offset: 0x52503F8 VA: 0x52543F8
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524B200 Offset: 0x5247200 VA: 0x524B200
	|-OrderedHashSet<EntityRef>.TrimExcess
	|
	|-RVA: 0x524DB20 Offset: 0x5249B20 VA: 0x524DB20
	|-OrderedHashSet<int>.TrimExcess
	|
	|-RVA: 0x52502AC Offset: 0x524C2AC VA: 0x52502AC
	|-OrderedHashSet<object>.TrimExcess
	|
	|-RVA: 0x5254400 Offset: 0x5250400 VA: 0x5254400
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private void Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524B4F8 Offset: 0x52474F8 VA: 0x524B4F8
	|-OrderedHashSet<EntityRef>.Initialize
	|
	|-RVA: 0x524DE30 Offset: 0x5249E30 VA: 0x524DE30
	|-OrderedHashSet<int>.Initialize
	|
	|-RVA: 0x52505C0 Offset: 0x524C5C0 VA: 0x52505C0
	|-OrderedHashSet<object>.Initialize
	|
	|-RVA: 0x5254A28 Offset: 0x5250A28 VA: 0x5254A28
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524B5C8 Offset: 0x52475C8 VA: 0x524B5C8
	|-OrderedHashSet<EntityRef>.IncreaseCapacity
	|
	|-RVA: 0x524DF00 Offset: 0x5249F00 VA: 0x524DF00
	|-OrderedHashSet<int>.IncreaseCapacity
	|
	|-RVA: 0x5250690 Offset: 0x524C690 VA: 0x5250690
	|-OrderedHashSet<object>.IncreaseCapacity
	|
	|-RVA: 0x5254AF8 Offset: 0x5250AF8 VA: 0x5254AF8
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.IncreaseCapacity
	*/

	// RVA: -1 Offset: -1
	public bool Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524B784 Offset: 0x5247784 VA: 0x524B784
	|-OrderedHashSet<EntityRef>.Add
	|
	|-RVA: 0x524E0BC Offset: 0x524A0BC VA: 0x524E0BC
	|-OrderedHashSet<int>.Add
	|
	|-RVA: 0x525084C Offset: 0x524C84C VA: 0x525084C
	|-OrderedHashSet<object>.Add
	|
	|-RVA: 0x5254D30 Offset: 0x5250D30 VA: 0x5254D30
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private int InternalGetHashCode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524BA50 Offset: 0x5247A50 VA: 0x524BA50
	|-OrderedHashSet<EntityRef>.InternalGetHashCode
	|
	|-RVA: 0x524E398 Offset: 0x524A398 VA: 0x524E398
	|-OrderedHashSet<int>.InternalGetHashCode
	|
	|-RVA: 0x5250B20 Offset: 0x524CB20 VA: 0x5250B20
	|-OrderedHashSet<object>.InternalGetHashCode
	|
	|-RVA: 0x5255350 Offset: 0x5251350 VA: 0x5255350
	|-OrderedHashSet<__Il2CppFullySharedGenericType>.InternalGetHashCode
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x524BBCC Offset: 0x5247BCC VA: 0x524BBCC
	|-OrderedHashSet<EntityRef>..cctor
	|
	|-RVA: 0x524E514 Offset: 0x524A514 VA: 0x524E514
	|-OrderedHashSet<int>..cctor
	|
	|-RVA: 0x5250C90 Offset: 0x524CC90 VA: 0x5250C90
	|-OrderedHashSet<object>..cctor
	|
	|-RVA: 0x5255628 Offset: 0x5251628 VA: 0x5255628
	|-OrderedHashSet<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Rock.Collections
internal struct Slot // TypeDefIndex: 24245
{
	// Fields
	public int Left; // 0x0
	public int Right; // 0x4
	public int Parent; // 0x8
	public bool IsRed; // 0xC
}

// Namespace: 
public struct SortedSet.Node<T> // TypeDefIndex: 24246
{
	// Fields
	private SortedSet<T> m_tree; // 0x0
	private int m_node; // 0x0
	private int m_version; // 0x0

	// Properties
	public bool IsNull { get; }
	public T Value { get; }
	public SortedSet.Node<T> Next { get; }
	public SortedSet.Node<T> Previous { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_IsNull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5128B18 Offset: 0x5124B18 VA: 0x5128B18
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_IsNull
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5128B28 Offset: 0x5124B28 VA: 0x5128B28
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5128C74 Offset: 0x5124C74 VA: 0x5128C74
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Next
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Previous() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5128D94 Offset: 0x5124D94 VA: 0x5128D94
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Previous
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> tree, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5128EB4 Offset: 0x5124EB4 VA: 0x5128EB4
	|-SortedSet.Node<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CheckVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5128EF0 Offset: 0x5124EF0 VA: 0x5128EF0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.CheckVersion
	*/
}

// Namespace: 
public struct SortedSet.Reader<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 24247
{
	// Fields
	private SortedSet<T> m_set; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544EEEC Offset: 0x544AEEC VA: 0x544EEEC
	|-SortedSet.Reader<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544EF6C Offset: 0x544AF6C VA: 0x544EF6C
	|-SortedSet.Reader<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544EF74 Offset: 0x544AF74 VA: 0x544EF74
	|-SortedSet.Reader<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F110 Offset: 0x544B110 VA: 0x544F110
	|-SortedSet.Reader<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F154 Offset: 0x544B154 VA: 0x544F154
	|-SortedSet.Reader<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x544F1F4 Offset: 0x544B1F4 VA: 0x544F1F4
	|-SortedSet.Reader<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}

// Namespace: 
public struct SortedSet.ReverseReader<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 24248
{
	// Fields
	private SortedSet<T> m_set; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C66F0 Offset: 0x54C26F0 VA: 0x54C66F0
	|-SortedSet.ReverseReader<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C6770 Offset: 0x54C2770 VA: 0x54C6770
	|-SortedSet.ReverseReader<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C6778 Offset: 0x54C2778 VA: 0x54C6778
	|-SortedSet.ReverseReader<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public SortedSet.ReverseEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C6914 Offset: 0x54C2914 VA: 0x54C6914
	|-SortedSet.ReverseReader<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C6950 Offset: 0x54C2950 VA: 0x54C6950
	|-SortedSet.ReverseReader<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54C69F0 Offset: 0x54C29F0 VA: 0x54C69F0
	|-SortedSet.ReverseReader<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}

// Namespace: 
public struct SortedSet.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 24249
{
	// Fields
	private SortedSet<T> m_tree; // 0x0
	private int m_version; // 0x0
	private int m_index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60FF62C Offset: 0x60FB62C VA: 0x60FF62C
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60FF714 Offset: 0x60FB714 VA: 0x60FF714
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60FF744 Offset: 0x60FB744 VA: 0x60FF744
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60FF888 Offset: 0x60FB888 VA: 0x60FF888
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60FF88C Offset: 0x60FB88C VA: 0x60FF88C
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60FF9F0 Offset: 0x60FB9F0 VA: 0x60FF9F0
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
public struct SortedSet.ReverseEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 24250
{
	// Fields
	private SortedSet<T> m_tree; // 0x0
	private int m_version; // 0x0
	private int m_index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BD9D4 Offset: 0x54B99D4 VA: 0x54BD9D4
	|-SortedSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BDABC Offset: 0x54B9ABC VA: 0x54BDABC
	|-SortedSet.ReverseEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BDAEC Offset: 0x54B9AEC VA: 0x54BDAEC
	|-SortedSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BDC30 Offset: 0x54B9C30 VA: 0x54BDC30
	|-SortedSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BDC34 Offset: 0x54B9C34 VA: 0x54BDC34
	|-SortedSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54BDD98 Offset: 0x54B9D98 VA: 0x54BDD98
	|-SortedSet.ReverseEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: Rock.Collections
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class SortedSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 24251
{
	// Fields
	private int m_root; // 0x0
	private IComparer<T> m_comparer; // 0x0
	private int m_count; // 0x0
	private int m_version; // 0x0
	private object m_syncRoot; // 0x0
	private SerializationInfo m_siInfo; // 0x0
	private Slot[] m_slots; // 0x0
	private T[] m_items; // 0x0
	private int m_freeList; // 0x0
	private int m_lastIndex; // 0x0
	private const int MinSize = 4;
	private const int GrowFactor = 2;
	private const string ComparerName = "Comparer";
	private const string CountName = "Count";
	private const string ItemsName = "Items";
	private const string VersionName = "Version";
	private const string TreeName = "Tree";
	private const string NodeValueName = "Item";
	private const string EnumStartName = "EnumStarted";
	private const string ReverseName = "Reverse";
	private const string EnumVersionName = "EnumVersion";
	private const string minName = "Min";
	private const string maxName = "Max";
	private const string lBoundActiveName = "lBoundActive";
	private const string uBoundActiveName = "uBoundActive";

	// Properties
	public int Count { get; }
	public IComparer<T> Comparer { get; }
	public SortedSet.Reader<T> Items { get; }
	public SortedSet.ReverseReader<T> Reversed { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public T Min { get; }
	public T Max { get; }
	public SortedSet.Node<T> FirstNode { get; }
	public SortedSet.Node<T> LastNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FAFD4 Offset: 0x54F6FD4 VA: 0x54FAFD4
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public IComparer<T> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FAFDC Offset: 0x54F6FDC VA: 0x54FAFDC
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Reader<T> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FAFE4 Offset: 0x54F6FE4 VA: 0x54FAFE4
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1
	public SortedSet.ReverseReader<T> get_Reversed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB004 Offset: 0x54F7004 VA: 0x54FB004
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Reversed
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB024 Offset: 0x54F7024 VA: 0x54FB024
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB03C Offset: 0x54F703C VA: 0x54FB03C
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB054 Offset: 0x54F7054 VA: 0x54FB054
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB074 Offset: 0x54F7074 VA: 0x54FB074
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB160 Offset: 0x54F7160 VA: 0x54FB160
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB1B4 Offset: 0x54F71B4 VA: 0x54FB1B4
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB5D8 Offset: 0x54F75D8 VA: 0x54FB5D8
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB608 Offset: 0x54F7608 VA: 0x54FB608
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB610 Offset: 0x54F7610 VA: 0x54FB610
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB618 Offset: 0x54F7618 VA: 0x54FB618
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB68C Offset: 0x54F768C VA: 0x54FB68C
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FB748 Offset: 0x54F7748 VA: 0x54FB748
	|-SortedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FBBE8 Offset: 0x54F7BE8 VA: 0x54FBBE8
	|-SortedSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FC22C Offset: 0x54F822C VA: 0x54FC22C
	|-SortedSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FC278 Offset: 0x54F8278 VA: 0x54FC278
	|-SortedSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FC344 Offset: 0x54F8344 VA: 0x54FC344
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FC398 Offset: 0x54F8398 VA: 0x54FC398
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FC3F8 Offset: 0x54F83F8 VA: 0x54FC3F8
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FC6C4 Offset: 0x54F86C4 VA: 0x54FC6C4
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FCAE4 Offset: 0x54F8AE4 VA: 0x54FCAE4
	|-SortedSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FCB18 Offset: 0x54F8B18 VA: 0x54FCB18
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FCB68 Offset: 0x54F8B68 VA: 0x54FCB68
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static int GetSibling(Slot[] m_slots, int node, int parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FCBB8 Offset: 0x54F8BB8 VA: 0x54FCBB8
	|-SortedSet<__Il2CppFullySharedGenericType>.GetSibling
	*/

	// RVA: -1 Offset: -1
	private static void InsertionBalance(Slot[] m_slots, ref int m_root, int current, ref int parent, int grandParent, int greatGrandParent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FCBF4 Offset: 0x54F8BF4 VA: 0x54FCBF4
	|-SortedSet<__Il2CppFullySharedGenericType>.InsertionBalance
	*/

	// RVA: -1 Offset: -1
	private static bool Is2Node(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FCDFC Offset: 0x54F8DFC VA: 0x54FCDFC
	|-SortedSet<__Il2CppFullySharedGenericType>.Is2Node
	*/

	// RVA: -1 Offset: -1
	private static bool Is4Node(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FCF9C Offset: 0x54F8F9C VA: 0x54FCF9C
	|-SortedSet<__Il2CppFullySharedGenericType>.Is4Node
	*/

	// RVA: -1 Offset: -1
	private static bool IsBlack(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FD0DC Offset: 0x54F90DC VA: 0x54FD0DC
	|-SortedSet<__Il2CppFullySharedGenericType>.IsBlack
	*/

	// RVA: -1 Offset: -1
	private static bool IsNullOrBlack(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FD120 Offset: 0x54F9120 VA: 0x54FD120
	|-SortedSet<__Il2CppFullySharedGenericType>.IsNullOrBlack
	*/

	// RVA: -1 Offset: -1
	private static bool IsRed(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FD164 Offset: 0x54F9164 VA: 0x54FD164
	|-SortedSet<__Il2CppFullySharedGenericType>.IsRed
	*/

	// RVA: -1 Offset: -1
	private static void Merge2Nodes(Slot[] m_slots, int parent, int child1, int child2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FD1A8 Offset: 0x54F91A8 VA: 0x54FD1A8
	|-SortedSet<__Il2CppFullySharedGenericType>.Merge2Nodes
	*/

	// RVA: -1 Offset: -1
	private int ObtainSlot(T item, bool isRed = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FD1F8 Offset: 0x54F91F8 VA: 0x54FD1F8
	|-SortedSet<__Il2CppFullySharedGenericType>.ObtainSlot
	*/

	// RVA: -1 Offset: -1
	private void ReturnSlot(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FD450 Offset: 0x54F9450 VA: 0x54FD450
	|-SortedSet<__Il2CppFullySharedGenericType>.ReturnSlot
	*/

	// RVA: -1 Offset: -1
	private static void ReplaceChildOfNodeOrRoot(Slot[] m_slots, ref int m_root, int parent, int child, int newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FD5B8 Offset: 0x54F95B8 VA: 0x54FD5B8
	|-SortedSet<__Il2CppFullySharedGenericType>.ReplaceChildOfNodeOrRoot
	*/

	// RVA: -1 Offset: -1
	private static void ReplaceNode(Slot[] m_slots, ref int m_root, int match, int parentOfMatch, int successor, int parentOfsuccessor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FD6D0 Offset: 0x54F96D0 VA: 0x54FD6D0
	|-SortedSet<__Il2CppFullySharedGenericType>.ReplaceNode
	*/

	// RVA: -1 Offset: -1
	internal int FindNode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FD95C Offset: 0x54F995C VA: 0x54FD95C
	|-SortedSet<__Il2CppFullySharedGenericType>.FindNode
	*/

	// RVA: -1 Offset: -1
	internal int InternalIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FDB70 Offset: 0x54F9B70 VA: 0x54FDB70
	|-SortedSet<__Il2CppFullySharedGenericType>.InternalIndexOf
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> FindNext(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FDDC0 Offset: 0x54F9DC0 VA: 0x54FDDC0
	|-SortedSet<__Il2CppFullySharedGenericType>.FindNext
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> FindPrevious(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FE060 Offset: 0x54FA060 VA: 0x54FE060
	|-SortedSet<__Il2CppFullySharedGenericType>.FindPrevious
	*/

	// RVA: -1 Offset: -1
	internal int FindRange(T from, T to) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FE300 Offset: 0x54FA300 VA: 0x54FE300
	|-SortedSet<__Il2CppFullySharedGenericType>.FindRange
	*/

	// RVA: -1 Offset: -1
	internal int FindRange(T from, T to, bool lowerBoundActive, bool upperBoundActive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FE428 Offset: 0x54FA428 VA: 0x54FE428
	|-SortedSet<__Il2CppFullySharedGenericType>.FindRange
	*/

	// RVA: -1 Offset: -1
	private static int RotateLeft(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FE784 Offset: 0x54FA784 VA: 0x54FE784
	|-SortedSet<__Il2CppFullySharedGenericType>.RotateLeft
	*/

	// RVA: -1 Offset: -1
	private static int RotateLeftRight(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FE870 Offset: 0x54FA870 VA: 0x54FE870
	|-SortedSet<__Il2CppFullySharedGenericType>.RotateLeftRight
	*/

	// RVA: -1 Offset: -1
	private static int RotateRight(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FEA78 Offset: 0x54FAA78 VA: 0x54FEA78
	|-SortedSet<__Il2CppFullySharedGenericType>.RotateRight
	*/

	// RVA: -1 Offset: -1
	private static int RotateRightLeft(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FEB64 Offset: 0x54FAB64 VA: 0x54FEB64
	|-SortedSet<__Il2CppFullySharedGenericType>.RotateRightLeft
	*/

	// RVA: -1 Offset: -1
	public static IEqualityComparer<SortedSet<T>> CreateSetComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FED6C Offset: 0x54FAD6C VA: 0x54FED6C
	|-SortedSet<__Il2CppFullySharedGenericType>.CreateSetComparer
	*/

	// RVA: -1 Offset: -1
	public static IEqualityComparer<SortedSet<T>> CreateSetComparer(IEqualityComparer<T> memberEqualityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FEE0C Offset: 0x54FAE0C VA: 0x54FEE0C
	|-SortedSet<__Il2CppFullySharedGenericType>.CreateSetComparer
	*/

	// RVA: -1 Offset: -1
	internal static bool SortedSetEquals(SortedSet<T> set1, SortedSet<T> set2, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FEEBC Offset: 0x54FAEBC VA: 0x54FEEBC
	|-SortedSet<__Il2CppFullySharedGenericType>.SortedSetEquals
	*/

	// RVA: -1 Offset: -1
	private static bool AreComparersEqual(SortedSet<T> set1, SortedSet<T> set2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FF618 Offset: 0x54FB618 VA: 0x54FF618
	|-SortedSet<__Il2CppFullySharedGenericType>.AreComparersEqual
	*/

	// RVA: -1 Offset: -1
	private static void Split4Node(Slot[] m_slots, int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FF714 Offset: 0x54FB714 VA: 0x54FF714
	|-SortedSet<__Il2CppFullySharedGenericType>.Split4Node
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FF778 Offset: 0x54FB778 VA: 0x54FF778
	|-SortedSet<__Il2CppFullySharedGenericType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	public bool SetEquals(SortedSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FF7EC Offset: 0x54FB7EC VA: 0x54FF7EC
	|-SortedSet<__Il2CppFullySharedGenericType>.SetEquals
	*/

	// RVA: -1 Offset: -1
	public T get_Min() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FFB40 Offset: 0x54FBB40 VA: 0x54FFB40
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Min
	*/

	// RVA: -1 Offset: -1
	public T get_Max() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FFC78 Offset: 0x54FBC78 VA: 0x54FFC78
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Max
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_FirstNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FFDB0 Offset: 0x54FBDB0 VA: 0x54FFDB0
	|-SortedSet<__Il2CppFullySharedGenericType>.get_FirstNode
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_LastNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FFE0C Offset: 0x54FBE0C VA: 0x54FFE0C
	|-SortedSet<__Il2CppFullySharedGenericType>.get_LastNode
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FFE68 Offset: 0x54FBE68 VA: 0x54FFE68
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1
	protected void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FFE7C Offset: 0x54FBE7C VA: 0x54FFE7C
	|-SortedSet<__Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55000A4 Offset: 0x54FC0A4 VA: 0x55000A4
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	protected void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55000B8 Offset: 0x54FC0B8 VA: 0x55000B8
	|-SortedSet<__Il2CppFullySharedGenericType>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private int GetFirst() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5500480 Offset: 0x54FC480 VA: 0x5500480
	|-SortedSet<__Il2CppFullySharedGenericType>.GetFirst
	*/

	// RVA: -1 Offset: -1
	private int GetLast() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55004D0 Offset: 0x54FC4D0 VA: 0x55004D0
	|-SortedSet<__Il2CppFullySharedGenericType>.GetLast
	*/

	// RVA: -1 Offset: -1
	private int GetNext(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5500520 Offset: 0x54FC520 VA: 0x5500520
	|-SortedSet<__Il2CppFullySharedGenericType>.GetNext
	*/

	// RVA: -1 Offset: -1
	private int GetPrevious(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55005B4 Offset: 0x54FC5B4 VA: 0x55005B4
	|-SortedSet<__Il2CppFullySharedGenericType>.GetPrevious
	*/

	// RVA: -1 Offset: -1
	private static void SetLeft(Slot[] m_slots, int slot, int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5500648 Offset: 0x54FC648 VA: 0x5500648
	|-SortedSet<__Il2CppFullySharedGenericType>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private static void SetRight(Slot[] m_slots, int slot, int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x550068C Offset: 0x54FC68C VA: 0x550068C
	|-SortedSet<__Il2CppFullySharedGenericType>.SetRight
	*/

	// RVA: -1 Offset: -1
	private static int log2(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55006D0 Offset: 0x54FC6D0 VA: 0x55006D0
	|-SortedSet<__Il2CppFullySharedGenericType>.log2
	*/
}

// Namespace: Rock.Collections
internal sealed class SortedSetEqualityComparer<T> : IEqualityComparer<SortedSet<T>> // TypeDefIndex: 24252
{
	// Fields
	private readonly IComparer<T> _comparer; // 0x0
	private readonly IEqualityComparer<T> _memberEqualityComparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FABA4 Offset: 0x54F6BA4 VA: 0x54FABA4
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> memberEqualityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FABC0 Offset: 0x54F6BC0 VA: 0x54FABC0
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(IComparer<T> comparer, IEqualityComparer<T> memberEqualityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FABE0 Offset: 0x54F6BE0 VA: 0x54FABE0
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(SortedSet<T> x, SortedSet<T> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FAC70 Offset: 0x54F6C70 VA: 0x54FAC70
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int GetHashCode(SortedSet<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FAC94 Offset: 0x54F6C94 VA: 0x54FAC94
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FAF1C Offset: 0x54F6F1C VA: 0x54FAF1C
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54FAF8C Offset: 0x54F6F8C VA: 0x54FAF8C
	|-SortedSetEqualityComparer<__Il2CppFullySharedGenericType>.GetHashCode
	*/
}

// Namespace: Rock.Collections.Internals
public sealed class CollectionDebugView<T> // TypeDefIndex: 24253
{
	// Fields
	private readonly ICollection<T> m_collection; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public T[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB9B50 Offset: 0x5BB5B50 VA: 0x5BB9B50
	|-CollectionDebugView<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BB9BC4 Offset: 0x5BB5BC4 VA: 0x5BB9BC4
	|-CollectionDebugView<__Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: Rock.Collections.Internals
public sealed class DictionaryDebugView<K, V> // TypeDefIndex: 24254
{
	// Fields
	private readonly IDictionary<K, V> m_dict; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public KeyValuePair<K, V>[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<K, V> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D46808 Offset: 0x5D42808 VA: 0x5D46808
	|-DictionaryDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<K, V>[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4687C Offset: 0x5D4287C VA: 0x5D4687C
	|-DictionaryDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: Rock.Collections.Internals
public static class HashHelpers // TypeDefIndex: 24255
{
	// Fields
	public const int MaxPrimeArrayLength = 2146435069;
	private static readonly int[] primes; // 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x8

	// Properties
	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }

	// Methods

	// RVA: 0x416D210 Offset: 0x4169210 VA: 0x416D210
	public static int GetPrime(int min) { }

	// RVA: 0x416D318 Offset: 0x4169318 VA: 0x416D318
	public static int ExpandPrime(int oldSize) { }

	// RVA: 0x416D39C Offset: 0x416939C VA: 0x416D39C
	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x416D40C Offset: 0x416940C VA: 0x416D40C
	internal static object GetEqualityComparerForSerialization(object comparer) { }

	// RVA: 0x416D410 Offset: 0x4169410 VA: 0x416D410
	private static void .cctor() { }
}

// Namespace: Rock.Collections.Internals
public sealed class KeyCollectionDebugView<TKey, TValue> // TypeDefIndex: 24256
{
	// Fields
	private readonly ICollection<TKey> m_collection; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public TKey[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<TKey> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AEEA88 Offset: 0x4AEAA88 VA: 0x4AEEA88
	|-KeyCollectionDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TKey[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AEEAFC Offset: 0x4AEAAFC VA: 0x4AEEAFC
	|-KeyCollectionDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: Rock.Collections.Internals
public sealed class ValueCollectionDebugView<TKey, TValue> // TypeDefIndex: 24257
{
	// Fields
	private readonly ICollection<TValue> m_collection; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public TValue[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<TValue> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5741300 Offset: 0x573D300 VA: 0x5741300
	|-ValueCollectionDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5741374 Offset: 0x573D374 VA: 0x5741374
	|-ValueCollectionDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: Rock.Collections.Custom
public class OrderedDictionaryEntityRefComparer : IEqualityComparer<EntityRef> // TypeDefIndex: 24258
{
	// Fields
	private static OrderedDictionaryEntityRefComparer _default; // 0x0

	// Properties
	public static OrderedDictionaryEntityRefComparer Default { get; }

	// Methods

	// RVA: 0x416D4B0 Offset: 0x41694B0 VA: 0x416D4B0
	public static OrderedDictionaryEntityRefComparer get_Default() { }

	// RVA: 0x416D534 Offset: 0x4169534 VA: 0x416D534 Slot: 4
	public bool Equals(EntityRef x, EntityRef y) { }

	// RVA: 0x416D544 Offset: 0x4169544 VA: 0x416D544 Slot: 5
	public int GetHashCode(EntityRef obj) { }

	// RVA: 0x416D52C Offset: 0x416952C VA: 0x416D52C
	public void .ctor() { }
}

// Namespace: Rock.Collections.Custom
public class OrderedDictionaryIntComparer : IEqualityComparer<int> // TypeDefIndex: 24259
{
	// Fields
	private static OrderedDictionaryIntComparer _default; // 0x0

	// Properties
	public static OrderedDictionaryIntComparer Default { get; }

	// Methods

	// RVA: 0x416D554 Offset: 0x4169554 VA: 0x416D554
	public static OrderedDictionaryIntComparer get_Default() { }

	// RVA: 0x416D5D8 Offset: 0x41695D8 VA: 0x416D5D8 Slot: 4
	public bool Equals(int x, int y) { }

	// RVA: 0x416D5E4 Offset: 0x41695E4 VA: 0x416D5E4 Slot: 5
	public int GetHashCode(int obj) { }

	// RVA: 0x416D5D0 Offset: 0x41695D0 VA: 0x416D5D0
	public void .ctor() { }
}

// Namespace: Rock.Collections.Custom
public class OrderedDictionaryLongComparer : IEqualityComparer<long> // TypeDefIndex: 24260
{
	// Fields
	private static OrderedDictionaryLongComparer _default; // 0x0

	// Properties
	public static OrderedDictionaryLongComparer Default { get; }

	// Methods

	// RVA: 0x416D600 Offset: 0x4169600 VA: 0x416D600
	public static OrderedDictionaryLongComparer get_Default() { }

	// RVA: 0x416D684 Offset: 0x4169684 VA: 0x416D684 Slot: 4
	public bool Equals(long x, long y) { }

	// RVA: 0x416D690 Offset: 0x4169690 VA: 0x416D690 Slot: 5
	public int GetHashCode(long obj) { }

	// RVA: 0x416D67C Offset: 0x416967C VA: 0x416D67C
	public void .ctor() { }
}

// Namespace: Rock.Collections.Custom
public class OrderedDictionaryUIntComparer : IEqualityComparer<uint> // TypeDefIndex: 24261
{
	// Fields
	private static OrderedDictionaryUIntComparer _default; // 0x0

	// Properties
	public static OrderedDictionaryUIntComparer Default { get; }

	// Methods

	// RVA: 0x416D6AC Offset: 0x41696AC VA: 0x416D6AC
	public static OrderedDictionaryUIntComparer get_Default() { }

	// RVA: 0x416D730 Offset: 0x4169730 VA: 0x416D730 Slot: 4
	public bool Equals(uint x, uint y) { }

	// RVA: 0x416D73C Offset: 0x416973C VA: 0x416D73C Slot: 5
	public int GetHashCode(uint obj) { }

	// RVA: 0x416D728 Offset: 0x4169728 VA: 0x416D728
	public void .ctor() { }
}

// Namespace: Rock.Collections.Custom
public class OrderedDictionaryULongComparer : IEqualityComparer<ulong> // TypeDefIndex: 24262
{
	// Fields
	private static OrderedDictionaryULongComparer _default; // 0x0

	// Properties
	public static OrderedDictionaryULongComparer Default { get; }

	// Methods

	// RVA: 0x416D758 Offset: 0x4169758 VA: 0x416D758
	public static OrderedDictionaryULongComparer get_Default() { }

	// RVA: 0x416D7DC Offset: 0x41697DC VA: 0x416D7DC Slot: 4
	public bool Equals(ulong x, ulong y) { }

	// RVA: 0x416D7E8 Offset: 0x41697E8 VA: 0x416D7E8 Slot: 5
	public int GetHashCode(ulong obj) { }

	// RVA: 0x416D7D4 Offset: 0x41697D4 VA: 0x416D7D4
	public void .ctor() { }
}

// Namespace: LitJson
public enum JsonType // TypeDefIndex: 24263
{
	// Fields
	public int value__; // 0x0
	public const JsonType None = 0;
	public const JsonType Object = 1;
	public const JsonType Array = 2;
	public const JsonType String = 3;
	public const JsonType Int = 4;
	public const JsonType Long = 5;
	public const JsonType Double = 6;
	public const JsonType FP = 7;
	public const JsonType Boolean = 8;
}

// Namespace: LitJson
public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary // TypeDefIndex: 24264
{
	// Properties
	public abstract bool IsArray { get; }
	public abstract bool IsBoolean { get; }
	public abstract bool IsDouble { get; }
	public abstract bool IsFp { get; }
	public abstract bool IsInt { get; }
	public abstract bool IsLong { get; }
	public abstract bool IsObject { get; }
	public abstract bool IsString { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsArray();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsBoolean();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsDouble();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsFp();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsInt();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsLong();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsObject();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsString();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool GetBoolean();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract double GetDouble();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract FP GetFp();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetInt();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract JsonType GetJsonType();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long GetLong();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract string GetString();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SetBoolean(bool val);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetDouble(double val);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetFp(FP val);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SetInt(int val);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SetJsonType(JsonType type);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void SetLong(long val);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void SetString(string val);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract string ToJson();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void ToJson(JsonWriter writer);
}

// Namespace: LitJson
[DefaultMember("Item")]
public class JsonDataLockStep : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonDataLockStep> // TypeDefIndex: 24265
{
	// Fields
	private IList<JsonDataLockStep> inst_array; // 0x10
	private bool inst_boolean; // 0x18
	private double inst_double; // 0x20
	private FP inst_fp; // 0x28
	private int inst_int; // 0x30
	private long inst_long; // 0x38
	private IDictionary<string, JsonDataLockStep> inst_object; // 0x40
	private string inst_string; // 0x48
	private string json; // 0x50
	private JsonType type; // 0x58
	private IList<KeyValuePair<string, JsonDataLockStep>> object_list; // 0x60

	// Properties
	public int Count { get; }
	public bool IsArray { get; }
	public bool IsBoolean { get; }
	public bool IsDouble { get; }
	public bool IsFp { get; }
	public bool IsInt { get; }
	public bool IsLong { get; }
	public bool IsObject { get; }
	public bool IsString { get; }
	public ICollection<string> Keys { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool LitJson.IJsonWrapper.IsArray { get; }
	private bool LitJson.IJsonWrapper.IsBoolean { get; }
	private bool LitJson.IJsonWrapper.IsDouble { get; }
	private bool LitJson.IJsonWrapper.IsFp { get; }
	private bool LitJson.IJsonWrapper.IsInt { get; }
	private bool LitJson.IJsonWrapper.IsLong { get; }
	private bool LitJson.IJsonWrapper.IsObject { get; }
	private bool LitJson.IJsonWrapper.IsString { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private object System.Collections.Specialized.IOrderedDictionary.Item { get; set; }
	private object System.Collections.IList.Item { get; set; }
	public JsonDataLockStep Item { get; set; }
	public JsonDataLockStep Item { get; set; }

	// Methods

	// RVA: 0x416D804 Offset: 0x4169804 VA: 0x416D804
	public int get_Count() { }

	// RVA: 0x416D984 Offset: 0x4169984 VA: 0x416D984
	public bool get_IsArray() { }

	// RVA: 0x416D994 Offset: 0x4169994 VA: 0x416D994
	public bool get_IsBoolean() { }

	// RVA: 0x416D9A4 Offset: 0x41699A4 VA: 0x416D9A4
	public bool get_IsDouble() { }

	// RVA: 0x416D9B4 Offset: 0x41699B4 VA: 0x416D9B4
	public bool get_IsFp() { }

	// RVA: 0x416D9C4 Offset: 0x41699C4 VA: 0x416D9C4
	public bool get_IsInt() { }

	// RVA: 0x416D9D4 Offset: 0x41699D4 VA: 0x416D9D4
	public bool get_IsLong() { }

	// RVA: 0x416D9E4 Offset: 0x41699E4 VA: 0x416D9E4
	public bool get_IsObject() { }

	// RVA: 0x416D9F4 Offset: 0x41699F4 VA: 0x416D9F4
	public bool get_IsString() { }

	// RVA: 0x416DA04 Offset: 0x4169A04 VA: 0x416DA04
	public ICollection<string> get_Keys() { }

	// RVA: 0x416DC24 Offset: 0x4169C24 VA: 0x416DC24
	public bool ContainsKey(string key) { }

	// RVA: 0x416DD50 Offset: 0x4169D50 VA: 0x416DD50 Slot: 40
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x416DD54 Offset: 0x4169D54 VA: 0x416DD54 Slot: 42
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x416DE00 Offset: 0x4169E00 VA: 0x416DE00 Slot: 41
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x416DEAC Offset: 0x4169EAC VA: 0x416DEAC Slot: 57
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x416DF58 Offset: 0x4169F58 VA: 0x416DF58 Slot: 56
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x416E004 Offset: 0x416A004 VA: 0x416E004 Slot: 51
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x416E3DC Offset: 0x416A3DC VA: 0x416E3DC Slot: 52
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x416E7B4 Offset: 0x416A7B4 VA: 0x416E7B4 Slot: 4
	private bool LitJson.IJsonWrapper.get_IsArray() { }

	// RVA: 0x416E7C4 Offset: 0x416A7C4 VA: 0x416E7C4 Slot: 5
	private bool LitJson.IJsonWrapper.get_IsBoolean() { }

	// RVA: 0x416E7D4 Offset: 0x416A7D4 VA: 0x416E7D4 Slot: 6
	private bool LitJson.IJsonWrapper.get_IsDouble() { }

	// RVA: 0x416E7E4 Offset: 0x416A7E4 VA: 0x416E7E4 Slot: 7
	private bool LitJson.IJsonWrapper.get_IsFp() { }

	// RVA: 0x416E7F4 Offset: 0x416A7F4 VA: 0x416E7F4 Slot: 8
	private bool LitJson.IJsonWrapper.get_IsInt() { }

	// RVA: 0x416E804 Offset: 0x416A804 VA: 0x416E804 Slot: 9
	private bool LitJson.IJsonWrapper.get_IsLong() { }

	// RVA: 0x416E814 Offset: 0x416A814 VA: 0x416E814 Slot: 10
	private bool LitJson.IJsonWrapper.get_IsObject() { }

	// RVA: 0x416E824 Offset: 0x416A824 VA: 0x416E824 Slot: 11
	private bool LitJson.IJsonWrapper.get_IsString() { }

	// RVA: 0x416E834 Offset: 0x416A834 VA: 0x416E834 Slot: 34
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x416EA04 Offset: 0x416AA04 VA: 0x416EA04 Slot: 33
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x416EAB0 Offset: 0x416AAB0 VA: 0x416EAB0 Slot: 49
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x416EB60 Offset: 0x416AB60 VA: 0x416EB60 Slot: 50
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x416F05C Offset: 0x416B05C VA: 0x416F05C Slot: 44
	private object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx) { }

	// RVA: 0x416F120 Offset: 0x416B120 VA: 0x416F120 Slot: 45
	private void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value) { }

	// RVA: 0x416F32C Offset: 0x416B32C VA: 0x416F32C Slot: 28
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x416F3DC Offset: 0x416B3DC VA: 0x416F3DC Slot: 29
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x416F6BC Offset: 0x416B6BC VA: 0x416F6BC
	public JsonDataLockStep get_Item(string prop_name) { }

	// RVA: 0x416ECC4 Offset: 0x416ACC4 VA: 0x416ECC4
	public void set_Item(string prop_name, JsonDataLockStep value) { }

	// RVA: 0x416F76C Offset: 0x416B76C VA: 0x416F76C
	public JsonDataLockStep get_Item(int index) { }

	// RVA: 0x416F414 Offset: 0x416B414 VA: 0x416F414
	public void set_Item(int index, JsonDataLockStep value) { }

	// RVA: 0x416F8BC Offset: 0x416B8BC VA: 0x416F8BC
	public void .ctor() { }

	// RVA: 0x416F8C4 Offset: 0x416B8C4 VA: 0x416F8C4
	public void .ctor(bool boolean) { }

	// RVA: 0x416F8F4 Offset: 0x416B8F4 VA: 0x416F8F4
	public void .ctor(double number) { }

	// RVA: 0x416F924 Offset: 0x416B924 VA: 0x416F924
	public void .ctor(FP number) { }

	// RVA: 0x416F954 Offset: 0x416B954 VA: 0x416F954
	public void .ctor(int number) { }

	// RVA: 0x416F984 Offset: 0x416B984 VA: 0x416F984
	public void .ctor(long number) { }

	// RVA: 0x416F9B4 Offset: 0x416B9B4 VA: 0x416F9B4
	public void .ctor(object obj) { }

	// RVA: 0x416FC48 Offset: 0x416BC48 VA: 0x416FC48
	public void .ctor(string str) { }

	// RVA: 0x416FC80 Offset: 0x416BC80 VA: 0x416FC80
	public static JsonDataLockStep op_Implicit(bool data) { }

	// RVA: 0x416FCE8 Offset: 0x416BCE8 VA: 0x416FCE8
	public static JsonDataLockStep op_Implicit(double data) { }

	// RVA: 0x416FD54 Offset: 0x416BD54 VA: 0x416FD54
	public static JsonDataLockStep op_Implicit(FP data) { }

	// RVA: 0x416FDB8 Offset: 0x416BDB8 VA: 0x416FDB8
	public static JsonDataLockStep op_Implicit(int data) { }

	// RVA: 0x416FE1C Offset: 0x416BE1C VA: 0x416FE1C
	public static JsonDataLockStep op_Implicit(long data) { }

	// RVA: 0x416FE80 Offset: 0x416BE80 VA: 0x416FE80
	public static JsonDataLockStep op_Implicit(string data) { }

	// RVA: 0x416FEF0 Offset: 0x416BEF0 VA: 0x416FEF0
	public static bool op_Explicit(JsonDataLockStep dataLockStep) { }

	// RVA: 0x416FF5C Offset: 0x416BF5C VA: 0x416FF5C
	public static double op_Explicit(JsonDataLockStep dataLockStep) { }

	// RVA: 0x416FFC8 Offset: 0x416BFC8 VA: 0x416FFC8
	public static FP op_Explicit(JsonDataLockStep dataLockStep) { }

	// RVA: 0x4170034 Offset: 0x416C034 VA: 0x4170034
	public static int op_Explicit(JsonDataLockStep dataLockStep) { }

	// RVA: 0x41700B0 Offset: 0x416C0B0 VA: 0x41700B0
	public static long op_Explicit(JsonDataLockStep dataLockStep) { }

	// RVA: 0x417012C Offset: 0x416C12C VA: 0x417012C
	public static string op_Explicit(JsonDataLockStep dataLockStep) { }

	// RVA: 0x4170198 Offset: 0x416C198 VA: 0x4170198 Slot: 39
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4170258 Offset: 0x416C258 VA: 0x4170258 Slot: 54
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x4170424 Offset: 0x416C424 VA: 0x4170424 Slot: 55
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x4170558 Offset: 0x416C558 VA: 0x4170558 Slot: 53
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x417060C Offset: 0x416C60C VA: 0x417060C Slot: 58
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x41706A4 Offset: 0x416C6A4 VA: 0x41706A4 Slot: 59
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x4170930 Offset: 0x416C930 VA: 0x4170930 Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x41709D8 Offset: 0x416C9D8 VA: 0x41709D8 Slot: 12
	private bool LitJson.IJsonWrapper.GetBoolean() { }

	// RVA: 0x4170A3C Offset: 0x416CA3C VA: 0x4170A3C Slot: 13
	private double LitJson.IJsonWrapper.GetDouble() { }

	// RVA: 0x4170AA0 Offset: 0x416CAA0 VA: 0x4170AA0 Slot: 14
	private FP LitJson.IJsonWrapper.GetFp() { }

	// RVA: 0x4170B04 Offset: 0x416CB04 VA: 0x4170B04 Slot: 15
	private int LitJson.IJsonWrapper.GetInt() { }

	// RVA: 0x4170B68 Offset: 0x416CB68 VA: 0x4170B68 Slot: 17
	private long LitJson.IJsonWrapper.GetLong() { }

	// RVA: 0x4170BCC Offset: 0x416CBCC VA: 0x4170BCC Slot: 18
	private string LitJson.IJsonWrapper.GetString() { }

	// RVA: 0x4170C30 Offset: 0x416CC30 VA: 0x4170C30 Slot: 19
	private void LitJson.IJsonWrapper.SetBoolean(bool val) { }

	// RVA: 0x4170C4C Offset: 0x416CC4C VA: 0x4170C4C Slot: 20
	private void LitJson.IJsonWrapper.SetDouble(double val) { }

	// RVA: 0x4170C64 Offset: 0x416CC64 VA: 0x4170C64 Slot: 21
	public void SetFp(FP val) { }

	// RVA: 0x4170C7C Offset: 0x416CC7C VA: 0x4170C7C Slot: 22
	private void LitJson.IJsonWrapper.SetInt(int val) { }

	// RVA: 0x4170C94 Offset: 0x416CC94 VA: 0x4170C94 Slot: 24
	private void LitJson.IJsonWrapper.SetLong(long val) { }

	// RVA: 0x4170CAC Offset: 0x416CCAC VA: 0x4170CAC Slot: 25
	private void LitJson.IJsonWrapper.SetString(string val) { }

	// RVA: 0x4170CD8 Offset: 0x416CCD8 VA: 0x4170CD8 Slot: 26
	private string LitJson.IJsonWrapper.ToJson() { }

	// RVA: 0x4170DAC Offset: 0x416CDAC VA: 0x4170DAC Slot: 27
	private void LitJson.IJsonWrapper.ToJson(JsonWriter writer) { }

	// RVA: 0x4170DE0 Offset: 0x416CDE0 VA: 0x4170DE0 Slot: 30
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x4170EB4 Offset: 0x416CEB4 VA: 0x4170EB4 Slot: 32
	private void System.Collections.IList.Clear() { }

	// RVA: 0x4170F70 Offset: 0x416CF70 VA: 0x4170F70 Slot: 31
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x4171024 Offset: 0x416D024 VA: 0x4171024 Slot: 35
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x41710D8 Offset: 0x416D0D8 VA: 0x41710D8 Slot: 36
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x41711AC Offset: 0x416D1AC VA: 0x41711AC Slot: 37
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x4171270 Offset: 0x416D270 VA: 0x4171270 Slot: 38
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x4171334 Offset: 0x416D334 VA: 0x4171334 Slot: 46
	private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator() { }

	// RVA: 0x4171454 Offset: 0x416D454 VA: 0x4171454 Slot: 47
	private void System.Collections.Specialized.IOrderedDictionary.Insert(int idx, object key, object value) { }

	// RVA: 0x41715A0 Offset: 0x416D5A0 VA: 0x41715A0 Slot: 48
	private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int idx) { }

	// RVA: 0x416D8B0 Offset: 0x41698B0 VA: 0x416D8B0
	private ICollection EnsureCollection() { }

	// RVA: 0x416DAB0 Offset: 0x4169AB0 VA: 0x416DAB0
	private IDictionary EnsureDictionary() { }

	// RVA: 0x416E8E0 Offset: 0x416A8E0 VA: 0x416E8E0
	private IList EnsureList() { }

	// RVA: 0x416EC38 Offset: 0x416AC38 VA: 0x416EC38
	private JsonDataLockStep ToJsonData(object obj) { }

	// RVA: 0x417174C Offset: 0x416D74C VA: 0x417174C
	private static void WriteJson(IJsonWrapper obj, JsonWriter writer) { }

	// RVA: 0x4170DE4 Offset: 0x416CDE4 VA: 0x4170DE4
	public int Add(object value) { }

	// RVA: 0x4172E70 Offset: 0x416EE70 VA: 0x4172E70
	public bool Remove(object obj) { }

	// RVA: 0x41731FC Offset: 0x416F1FC VA: 0x41731FC
	public void Clear() { }

	// RVA: 0x417330C Offset: 0x416F30C VA: 0x417330C Slot: 60
	public bool Equals(JsonDataLockStep x) { }

	// RVA: 0x41734D4 Offset: 0x416F4D4 VA: 0x41734D4 Slot: 16
	public JsonType GetJsonType() { }

	// RVA: 0x41734DC Offset: 0x416F4DC VA: 0x41734DC Slot: 23
	public void SetJsonType(JsonType type) { }

	// RVA: 0x4170CDC Offset: 0x416CCDC VA: 0x4170CDC
	public string ToJson() { }

	// RVA: 0x4170DB0 Offset: 0x416CDB0 VA: 0x4170DB0
	public void ToJson(JsonWriter writer) { }

	// RVA: 0x41736DC Offset: 0x416F6DC VA: 0x41736DC Slot: 3
	public override string ToString() { }
}

// Namespace: LitJson
internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 24266
{
	// Fields
	private IEnumerator<KeyValuePair<string, JsonDataLockStep>> list_enumerator; // 0x10

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x417380C Offset: 0x416F80C VA: 0x417380C Slot: 8
	public object get_Current() { }

	// RVA: 0x4173870 Offset: 0x416F870 VA: 0x4173870 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x4173958 Offset: 0x416F958 VA: 0x4173958 Slot: 4
	public object get_Key() { }

	// RVA: 0x4173A04 Offset: 0x416FA04 VA: 0x4173A04 Slot: 5
	public object get_Value() { }

	// RVA: 0x4171424 Offset: 0x416D424 VA: 0x4171424
	public void .ctor(IEnumerator<KeyValuePair<string, JsonDataLockStep>> enumerator) { }

	// RVA: 0x4173AB8 Offset: 0x416FAB8 VA: 0x4173AB8 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x4173B58 Offset: 0x416FB58 VA: 0x4173B58 Slot: 9
	public void Reset() { }
}

// Namespace: LitJson
public class JsonException : ApplicationException // TypeDefIndex: 24267
{
	// Methods

	// RVA: 0x4173BFC Offset: 0x416FBFC VA: 0x4173BFC
	public void .ctor() { }

	// RVA: 0x4173C04 Offset: 0x416FC04 VA: 0x4173C04
	internal void .ctor(ParserToken token) { }

	// RVA: 0x4173CA0 Offset: 0x416FCA0 VA: 0x4173CA0
	internal void .ctor(ParserToken token, Exception inner_exception) { }

	// RVA: 0x4173D44 Offset: 0x416FD44 VA: 0x4173D44
	internal void .ctor(int c) { }

	// RVA: 0x4173DE0 Offset: 0x416FDE0 VA: 0x4173DE0
	internal void .ctor(int c, Exception inner_exception) { }

	// RVA: 0x4173E84 Offset: 0x416FE84 VA: 0x4173E84
	public void .ctor(string message) { }

	// RVA: 0x4173E8C Offset: 0x416FE8C VA: 0x4173E8C
	public void .ctor(string message, Exception inner_exception) { }
}

// Namespace: LitJson
internal struct PropertyMetadata // TypeDefIndex: 24268
{
	// Fields
	public MemberInfo Info; // 0x0
	public bool IsField; // 0x8
	public Type Type; // 0x10
}

// Namespace: LitJson
internal struct ArrayMetadata // TypeDefIndex: 24269
{
	// Fields
	private Type element_type; // 0x0
	private bool is_array; // 0x8
	private bool is_list; // 0x9

	// Properties
	public Type ElementType { get; set; }
	public bool IsArray { get; set; }
	public bool IsList { get; set; }

	// Methods

	// RVA: 0x4173E94 Offset: 0x416FE94 VA: 0x4173E94
	public Type get_ElementType() { }

	// RVA: 0x4173F3C Offset: 0x416FF3C VA: 0x4173F3C
	public void set_ElementType(Type value) { }

	// RVA: 0x4173F44 Offset: 0x416FF44 VA: 0x4173F44
	public bool get_IsArray() { }

	// RVA: 0x4173F4C Offset: 0x416FF4C VA: 0x4173F4C
	public void set_IsArray(bool value) { }

	// RVA: 0x4173F58 Offset: 0x416FF58 VA: 0x4173F58
	public bool get_IsList() { }

	// RVA: 0x4173F60 Offset: 0x416FF60 VA: 0x4173F60
	public void set_IsList(bool value) { }
}

// Namespace: LitJson
internal struct ObjectMetadata // TypeDefIndex: 24270
{
	// Fields
	private Type element_type; // 0x0
	private bool is_dictionary; // 0x8
	private IDictionary<string, PropertyMetadata> properties; // 0x10

	// Properties
	public Type ElementType { get; set; }
	public bool IsDictionary { get; set; }
	public IDictionary<string, PropertyMetadata> Properties { get; set; }

	// Methods

	// RVA: 0x4173F6C Offset: 0x416FF6C VA: 0x4173F6C
	public Type get_ElementType() { }

	// RVA: 0x4174014 Offset: 0x4170014 VA: 0x4174014
	public void set_ElementType(Type value) { }

	// RVA: 0x417401C Offset: 0x417001C VA: 0x417401C
	public bool get_IsDictionary() { }

	// RVA: 0x4174024 Offset: 0x4170024 VA: 0x4174024
	public void set_IsDictionary(bool value) { }

	// RVA: 0x4174030 Offset: 0x4170030 VA: 0x4174030
	public IDictionary<string, PropertyMetadata> get_Properties() { }

	// RVA: 0x4174038 Offset: 0x4170038 VA: 0x4174038
	public void set_Properties(IDictionary<string, PropertyMetadata> value) { }
}

// Namespace: LitJson
internal sealed class ExporterFunc : MulticastDelegate // TypeDefIndex: 24271
{
	// Methods

	// RVA: 0x4174040 Offset: 0x4170040 VA: 0x4174040
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x417414C Offset: 0x417014C VA: 0x417414C Slot: 13
	public virtual void Invoke(object obj, JsonWriter writer) { }

	// RVA: 0x4174160 Offset: 0x4170160 VA: 0x4174160 Slot: 14
	public virtual IAsyncResult BeginInvoke(object obj, JsonWriter writer, AsyncCallback callback, object object) { }

	// RVA: 0x4174188 Offset: 0x4170188 VA: 0x4174188 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: LitJson
public sealed class ExporterFunc<T> : MulticastDelegate // TypeDefIndex: 24272
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631AD6C Offset: 0x6316D6C VA: 0x631AD6C
	|-ExporterFunc<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T obj, JsonWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631AE78 Offset: 0x6316E78 VA: 0x631AE78
	|-ExporterFunc<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T obj, JsonWriter writer, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631AE8C Offset: 0x6316E8C VA: 0x631AE8C
	|-ExporterFunc<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631AF14 Offset: 0x6316F14 VA: 0x631AF14
	|-ExporterFunc<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: LitJson
internal sealed class ImporterFunc : MulticastDelegate // TypeDefIndex: 24273
{
	// Methods

	// RVA: 0x4174194 Offset: 0x4170194 VA: 0x4174194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x417429C Offset: 0x417029C VA: 0x417429C Slot: 13
	public virtual object Invoke(object input) { }

	// RVA: 0x41742B0 Offset: 0x41702B0 VA: 0x41742B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object input, AsyncCallback callback, object object) { }

	// RVA: 0x41742D0 Offset: 0x41702D0 VA: 0x41742D0 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}

// Namespace: LitJson
public sealed class ImporterFunc<TJson, TValue> : MulticastDelegate // TypeDefIndex: 24274
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49980FC Offset: 0x49940FC VA: 0x49980FC
	|-ImporterFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(TJson input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998204 Offset: 0x4994204 VA: 0x4998204
	|-ImporterFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(TJson input, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998218 Offset: 0x4994218 VA: 0x4998218
	|-ImporterFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TValue EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998298 Offset: 0x4994298 VA: 0x4998298
	|-ImporterFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: LitJson
public sealed class WrapperFactory : MulticastDelegate // TypeDefIndex: 24275
{
	// Methods

	// RVA: 0x41742DC Offset: 0x41702DC VA: 0x41742DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4174378 Offset: 0x4170378 VA: 0x4174378 Slot: 13
	public virtual IJsonWrapper Invoke() { }

	// RVA: 0x417438C Offset: 0x417038C VA: 0x417438C Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x41743AC Offset: 0x41703AC VA: 0x41743AC Slot: 15
	public virtual IJsonWrapper EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JsonMapperLockStep.<>c // TypeDefIndex: 24276
{
	// Fields
	public static readonly JsonMapperLockStep.<>c <>9; // 0x0
	public static WrapperFactory <>9__24_0; // 0x8
	public static ExporterFunc <>9__25_0; // 0x10
	public static ExporterFunc <>9__25_1; // 0x18
	public static ExporterFunc <>9__25_2; // 0x20
	public static ExporterFunc <>9__25_3; // 0x28
	public static ExporterFunc <>9__25_4; // 0x30
	public static ExporterFunc <>9__25_5; // 0x38
	public static ExporterFunc <>9__25_6; // 0x40
	public static ExporterFunc <>9__25_7; // 0x48
	public static ExporterFunc <>9__25_8; // 0x50
	public static ExporterFunc <>9__25_9; // 0x58
	public static ImporterFunc <>9__26_0; // 0x60
	public static ImporterFunc <>9__26_1; // 0x68
	public static ImporterFunc <>9__26_2; // 0x70
	public static ImporterFunc <>9__26_3; // 0x78
	public static ImporterFunc <>9__26_4; // 0x80
	public static ImporterFunc <>9__26_5; // 0x88
	public static ImporterFunc <>9__26_6; // 0x90
	public static ImporterFunc <>9__26_7; // 0x98
	public static ImporterFunc <>9__26_8; // 0xA0
	public static ImporterFunc <>9__26_9; // 0xA8
	public static ImporterFunc <>9__26_10; // 0xB0
	public static ImporterFunc <>9__26_11; // 0xB8
	public static ImporterFunc <>9__26_12; // 0xC0
	public static ImporterFunc <>9__26_13; // 0xC8
	public static ImporterFunc <>9__26_14; // 0xD0
	public static WrapperFactory <>9__31_0; // 0xD8
	public static WrapperFactory <>9__32_0; // 0xE0
	public static WrapperFactory <>9__33_0; // 0xE8
	public static WrapperFactory <>9__34_0; // 0xF0

	// Methods

	// RVA: 0x417C808 Offset: 0x4178808 VA: 0x417C808
	private static void .cctor() { }

	// RVA: 0x417C870 Offset: 0x4178870 VA: 0x417C870
	public void .ctor() { }

	// RVA: 0x417C878 Offset: 0x4178878 VA: 0x417C878
	internal IJsonWrapper <ReadSkip>b__24_0() { }

	// RVA: 0x417C8D4 Offset: 0x41788D4 VA: 0x417C8D4
	internal void <RegisterBaseExporters>b__25_0(object obj, JsonWriter writer) { }

	// RVA: 0x417C988 Offset: 0x4178988 VA: 0x417C988
	internal void <RegisterBaseExporters>b__25_1(object obj, JsonWriter writer) { }

	// RVA: 0x417CA3C Offset: 0x4178A3C VA: 0x417CA3C
	internal void <RegisterBaseExporters>b__25_2(object obj, JsonWriter writer) { }

	// RVA: 0x417CB28 Offset: 0x4178B28 VA: 0x417CB28
	internal void <RegisterBaseExporters>b__25_3(object obj, JsonWriter writer) { }

	// RVA: 0x417CC80 Offset: 0x4178C80 VA: 0x417CC80
	internal void <RegisterBaseExporters>b__25_4(object obj, JsonWriter writer) { }

	// RVA: 0x417CD34 Offset: 0x4178D34 VA: 0x417CD34
	internal void <RegisterBaseExporters>b__25_5(object obj, JsonWriter writer) { }

	// RVA: 0x417CDE8 Offset: 0x4178DE8 VA: 0x417CDE8
	internal void <RegisterBaseExporters>b__25_6(object obj, JsonWriter writer) { }

	// RVA: 0x417CE9C Offset: 0x4178E9C VA: 0x417CE9C
	internal void <RegisterBaseExporters>b__25_7(object obj, JsonWriter writer) { }

	// RVA: 0x417CF50 Offset: 0x4178F50 VA: 0x417CF50
	internal void <RegisterBaseExporters>b__25_8(object obj, JsonWriter writer) { }

	// RVA: 0x417CFCC Offset: 0x4178FCC VA: 0x417CFCC
	internal void <RegisterBaseExporters>b__25_9(object obj, JsonWriter writer) { }

	// RVA: 0x417D0D8 Offset: 0x41790D8 VA: 0x417D0D8
	internal object <RegisterBaseImporters>b__26_0(object input) { }

	// RVA: 0x417D1A8 Offset: 0x41791A8 VA: 0x417D1A8
	internal object <RegisterBaseImporters>b__26_1(object input) { }

	// RVA: 0x417D278 Offset: 0x4179278 VA: 0x417D278
	internal object <RegisterBaseImporters>b__26_2(object input) { }

	// RVA: 0x417D348 Offset: 0x4179348 VA: 0x417D348
	internal object <RegisterBaseImporters>b__26_3(object input) { }

	// RVA: 0x417D418 Offset: 0x4179418 VA: 0x417D418
	internal object <RegisterBaseImporters>b__26_4(object input) { }

	// RVA: 0x417D4E8 Offset: 0x41794E8 VA: 0x417D4E8
	internal object <RegisterBaseImporters>b__26_5(object input) { }

	// RVA: 0x417D5B8 Offset: 0x41795B8 VA: 0x417D5B8
	internal object <RegisterBaseImporters>b__26_6(object input) { }

	// RVA: 0x417D688 Offset: 0x4179688 VA: 0x417D688
	internal object <RegisterBaseImporters>b__26_7(object input) { }

	// RVA: 0x417D754 Offset: 0x4179754 VA: 0x417D754
	internal object <RegisterBaseImporters>b__26_8(object input) { }

	// RVA: 0x417D820 Offset: 0x4179820 VA: 0x417D820
	internal object <RegisterBaseImporters>b__26_9(object input) { }

	// RVA: 0x417D918 Offset: 0x4179918 VA: 0x417D918
	internal object <RegisterBaseImporters>b__26_10(object input) { }

	// RVA: 0x417D9E4 Offset: 0x41799E4 VA: 0x417D9E4
	internal object <RegisterBaseImporters>b__26_11(object input) { }

	// RVA: 0x417DAB4 Offset: 0x4179AB4 VA: 0x417DAB4
	internal object <RegisterBaseImporters>b__26_12(object input) { }

	// RVA: 0x417DB78 Offset: 0x4179B78 VA: 0x417DB78
	internal object <RegisterBaseImporters>b__26_13(object input) { }

	// RVA: 0x417DC74 Offset: 0x4179C74 VA: 0x417DC74
	internal object <RegisterBaseImporters>b__26_14(object input) { }

	// RVA: 0x417DD5C Offset: 0x4179D5C VA: 0x417DD5C
	internal IJsonWrapper <ToObject>b__31_0() { }

	// RVA: 0x417DDB0 Offset: 0x4179DB0 VA: 0x417DDB0
	internal IJsonWrapper <ToObject>b__32_0() { }

	// RVA: 0x417DE04 Offset: 0x4179E04 VA: 0x417DE04
	internal IJsonWrapper <ToObject>b__33_0() { }

	// RVA: 0x417DE58 Offset: 0x4179E58 VA: 0x417DE58
	internal IJsonWrapper <ToObjectFp>b__34_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonMapperLockStep.<>c__DisplayClass44_0<T> // TypeDefIndex: 24277
{
	// Fields
	public ExporterFunc<T> exporter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54573B0 Offset: 0x54533B0 VA: 0x54573B0
	|-JsonMapperLockStep.<>c__DisplayClass44_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterExporter>b__0(object obj, JsonWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54573B8 Offset: 0x54533B8 VA: 0x54573B8
	|-JsonMapperLockStep.<>c__DisplayClass44_0<__Il2CppFullySharedGenericType>.<RegisterExporter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonMapperLockStep.<>c__DisplayClass45_0<TJson, TValue> // TypeDefIndex: 24278
{
	// Fields
	public ImporterFunc<TJson, TValue> importer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5457594 Offset: 0x5453594 VA: 0x5457594
	|-JsonMapperLockStep.<>c__DisplayClass45_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <RegisterImporter>b__0(object input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545759C Offset: 0x545359C VA: 0x545759C
	|-JsonMapperLockStep.<>c__DisplayClass45_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<RegisterImporter>b__0
	*/
}

// Namespace: LitJson
public class JsonMapperLockStep // TypeDefIndex: 24279
{
	// Fields
	private static readonly int max_nesting_depth; // 0x0
	private static readonly IFormatProvider datetime_format; // 0x8
	private static readonly IDictionary<Type, ExporterFunc> base_exporters_table; // 0x10
	private static readonly IDictionary<Type, ExporterFunc> custom_exporters_table; // 0x18
	private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table; // 0x20
	private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table; // 0x28
	private static readonly IDictionary<Type, ArrayMetadata> array_metadata; // 0x30
	private static readonly object array_metadata_lock; // 0x38
	private static readonly IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops; // 0x40
	private static readonly object conv_ops_lock; // 0x48
	private static readonly IDictionary<Type, ObjectMetadata> object_metadata; // 0x50
	private static readonly object object_metadata_lock; // 0x58
	private static readonly IDictionary<Type, IList<PropertyMetadata>> type_properties; // 0x60
	private static readonly object type_properties_lock; // 0x68
	private static readonly JsonWriter static_writer; // 0x70
	private static readonly object static_writer_lock; // 0x78

	// Methods

	// RVA: 0x41743B8 Offset: 0x41703B8 VA: 0x41743B8
	private static void .cctor() { }

	// RVA: 0x41764C8 Offset: 0x41724C8 VA: 0x41764C8
	private static void AddArrayMetadata(Type type) { }

	// RVA: 0x4176954 Offset: 0x4172954 VA: 0x4176954
	private static void AddObjectMetadata(Type type) { }

	// RVA: 0x41770E0 Offset: 0x41730E0 VA: 0x41770E0
	private static void AddTypeProperties(Type type) { }

	// RVA: 0x4177688 Offset: 0x4173688 VA: 0x4177688
	private static bool IsJsonIgnored(MemberInfo memberInfo) { }

	// RVA: 0x41777D0 Offset: 0x41737D0 VA: 0x41777D0
	private static MethodInfo GetConvOp(Type t1, Type t2) { }

	// RVA: 0x4178040 Offset: 0x4174040 VA: 0x4178040
	private static object ReadValue(Type inst_type, JsonReader reader) { }

	// RVA: 0x41795A4 Offset: 0x41755A4 VA: 0x41795A4
	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader) { }

	// RVA: 0x41794A4 Offset: 0x41754A4 VA: 0x41794A4
	private static void ReadSkip(JsonReader reader) { }

	// RVA: 0x4174870 Offset: 0x4170870 VA: 0x4174870
	private static void RegisterBaseExporters() { }

	// RVA: 0x41755B4 Offset: 0x41715B4 VA: 0x41755B4
	private static void RegisterBaseImporters() { }

	// RVA: 0x4179D2C Offset: 0x4175D2C VA: 0x4179D2C
	private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer) { }

	// RVA: 0x4179F6C Offset: 0x4175F6C VA: 0x4179F6C
	private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth) { }

	// RVA: 0x417BB78 Offset: 0x4177B78 VA: 0x417BB78
	public static string ToJson(object obj) { }

	// RVA: 0x417BDD8 Offset: 0x4177DD8 VA: 0x417BDD8
	public static void ToJson(object obj, JsonWriter writer) { }

	// RVA: 0x417BE44 Offset: 0x4177E44 VA: 0x417BE44
	public static JsonDataLockStep ToObject(JsonReader reader) { }

	// RVA: 0x417BF90 Offset: 0x4177F90 VA: 0x417BF90
	public static JsonDataLockStep ToObject(TextReader reader) { }

	// RVA: 0x417C110 Offset: 0x4178110 VA: 0x417C110
	public static JsonDataLockStep ToObject(string json) { }

	// RVA: 0x417C2E8 Offset: 0x41782E8 VA: 0x417C2E8
	public static JsonDataLockStep ToObjectFp(string json) { }

	// RVA: -1 Offset: -1
	public static T ToObject<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4652658 Offset: 0x464E658 VA: 0x4652658
	|-JsonMapperLockStep.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ToObject<T>(TextReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4652914 Offset: 0x464E914 VA: 0x4652914
	|-JsonMapperLockStep.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ToObject<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4652540 Offset: 0x464E540 VA: 0x4652540
	|-JsonMapperLockStep.ToObject<object>
	|
	|-RVA: 0x465279C Offset: 0x464E79C VA: 0x465279C
	|-JsonMapperLockStep.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ToObjectFp<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4652A8C Offset: 0x464EA8C VA: 0x4652A8C
	|-JsonMapperLockStep.ToObjectFp<object>
	|
	|-RVA: 0x4652BB4 Offset: 0x464EBB4 VA: 0x4652BB4
	|-JsonMapperLockStep.ToObjectFp<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x417C4D0 Offset: 0x41784D0 VA: 0x417C4D0
	public static object ToObject(string json, Type ConvertType) { }

	// RVA: 0x417C5CC Offset: 0x41785CC VA: 0x417C5CC
	public static object ToObjectFp(string json, Type ConvertType) { }

	// RVA: 0x4179CC8 Offset: 0x4175CC8 VA: 0x4179CC8
	public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader) { }

	// RVA: 0x417C25C Offset: 0x417825C VA: 0x417C25C
	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json) { }

	// RVA: 0x417C434 Offset: 0x4178434 VA: 0x417C434
	public static IJsonWrapper ToWrapperFp(WrapperFactory factory, string json) { }

	// RVA: -1 Offset: -1
	public static void RegisterExporter<T>(ExporterFunc<T> exporter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4652268 Offset: 0x464E268 VA: 0x4652268
	|-JsonMapperLockStep.RegisterExporter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46523F8 Offset: 0x464E3F8 VA: 0x46523F8
	|-JsonMapperLockStep.RegisterImporter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x417C668 Offset: 0x4178668 VA: 0x417C668
	public static void UnregisterExporters() { }

	// RVA: 0x417C734 Offset: 0x4178734 VA: 0x417C734
	public static void UnregisterImporters() { }

	// RVA: 0x417C800 Offset: 0x4178800 VA: 0x417C800
	public void .ctor() { }
}

// Namespace: LitJson
public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary // TypeDefIndex: 24280
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsFp>k__BackingField; // 0x10

	// Properties
	public bool IsArray { get; }
	public bool IsBoolean { get; }
	public bool IsDouble { get; }
	public bool IsFp { get; }
	public bool IsInt { get; }
	public bool IsLong { get; }
	public bool IsObject { get; }
	public bool IsString { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private object System.Collections.Specialized.IOrderedDictionary.Item { get; set; }

	// Methods

	// RVA: 0x417DEAC Offset: 0x4179EAC VA: 0x417DEAC Slot: 4
	public bool get_IsArray() { }

	// RVA: 0x417DEB4 Offset: 0x4179EB4 VA: 0x417DEB4 Slot: 5
	public bool get_IsBoolean() { }

	// RVA: 0x417DEBC Offset: 0x4179EBC VA: 0x417DEBC Slot: 6
	public bool get_IsDouble() { }

	[CompilerGenerated]
	// RVA: 0x417DEC4 Offset: 0x4179EC4 VA: 0x417DEC4 Slot: 7
	public bool get_IsFp() { }

	// RVA: 0x417DECC Offset: 0x4179ECC VA: 0x417DECC Slot: 8
	public bool get_IsInt() { }

	// RVA: 0x417DED4 Offset: 0x4179ED4 VA: 0x417DED4 Slot: 9
	public bool get_IsLong() { }

	// RVA: 0x417DEDC Offset: 0x4179EDC VA: 0x417DEDC Slot: 10
	public bool get_IsObject() { }

	// RVA: 0x417DEE4 Offset: 0x4179EE4 VA: 0x417DEE4 Slot: 11
	public bool get_IsString() { }

	// RVA: 0x417DEEC Offset: 0x4179EEC VA: 0x417DEEC Slot: 12
	public bool GetBoolean() { }

	// RVA: 0x417DEF4 Offset: 0x4179EF4 VA: 0x417DEF4 Slot: 13
	public double GetDouble() { }

	// RVA: 0x417DEFC Offset: 0x4179EFC VA: 0x417DEFC Slot: 15
	public int GetInt() { }

	// RVA: 0x417DF04 Offset: 0x4179F04 VA: 0x417DF04 Slot: 16
	public JsonType GetJsonType() { }

	// RVA: 0x417DF0C Offset: 0x4179F0C VA: 0x417DF0C Slot: 17
	public long GetLong() { }

	// RVA: 0x417DF14 Offset: 0x4179F14 VA: 0x417DF14 Slot: 18
	public string GetString() { }

	// RVA: 0x417DF54 Offset: 0x4179F54 VA: 0x417DF54 Slot: 14
	public FP GetFp() { }

	// RVA: 0x417DF5C Offset: 0x4179F5C VA: 0x417DF5C Slot: 19
	public void SetBoolean(bool val) { }

	// RVA: 0x417DF60 Offset: 0x4179F60 VA: 0x417DF60 Slot: 20
	public void SetDouble(double val) { }

	// RVA: 0x417DF64 Offset: 0x4179F64 VA: 0x417DF64 Slot: 21
	public void SetFp(FP val) { }

	// RVA: 0x417DF68 Offset: 0x4179F68 VA: 0x417DF68 Slot: 22
	public void SetInt(int val) { }

	// RVA: 0x417DF6C Offset: 0x4179F6C VA: 0x417DF6C Slot: 23
	public void SetJsonType(JsonType type) { }

	// RVA: 0x417DF70 Offset: 0x4179F70 VA: 0x417DF70 Slot: 24
	public void SetLong(long val) { }

	// RVA: 0x417DF74 Offset: 0x4179F74 VA: 0x417DF74 Slot: 25
	public void SetString(string val) { }

	// RVA: 0x417DF78 Offset: 0x4179F78 VA: 0x417DF78 Slot: 26
	public string ToJson() { }

	// RVA: 0x417DFB8 Offset: 0x4179FB8 VA: 0x417DFB8 Slot: 27
	public void ToJson(JsonWriter writer) { }

	// RVA: 0x417DFBC Offset: 0x4179FBC VA: 0x417DFBC Slot: 34
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x417DFC4 Offset: 0x4179FC4 VA: 0x417DFC4 Slot: 33
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x417DFCC Offset: 0x4179FCC VA: 0x417DFCC Slot: 28
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x417DFD4 Offset: 0x4179FD4 VA: 0x417DFD4 Slot: 29
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x417DFD8 Offset: 0x4179FD8 VA: 0x417DFD8 Slot: 30
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x417DFE0 Offset: 0x4179FE0 VA: 0x417DFE0 Slot: 32
	private void System.Collections.IList.Clear() { }

	// RVA: 0x417DFE4 Offset: 0x4179FE4 VA: 0x417DFE4 Slot: 31
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x417DFEC Offset: 0x4179FEC VA: 0x417DFEC Slot: 35
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x417DFF4 Offset: 0x4179FF4 VA: 0x417DFF4 Slot: 36
	private void System.Collections.IList.Insert(int i, object v) { }

	// RVA: 0x417DFF8 Offset: 0x4179FF8 VA: 0x417DFF8 Slot: 37
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x417DFFC Offset: 0x4179FFC VA: 0x417DFFC Slot: 38
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x417E000 Offset: 0x417A000 VA: 0x417E000 Slot: 40
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x417E008 Offset: 0x417A008 VA: 0x417E008 Slot: 42
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x417E010 Offset: 0x417A010 VA: 0x417E010 Slot: 41
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x417E018 Offset: 0x417A018 VA: 0x417E018 Slot: 39
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x417E01C Offset: 0x417A01C VA: 0x417E01C Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x417E024 Offset: 0x417A024 VA: 0x417E024 Slot: 57
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x417E02C Offset: 0x417A02C VA: 0x417E02C Slot: 56
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x417E034 Offset: 0x417A034 VA: 0x417E034 Slot: 51
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x417E03C Offset: 0x417A03C VA: 0x417E03C Slot: 52
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x417E044 Offset: 0x417A044 VA: 0x417E044 Slot: 49
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x417E04C Offset: 0x417A04C VA: 0x417E04C Slot: 50
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x417E050 Offset: 0x417A050 VA: 0x417E050 Slot: 54
	private void System.Collections.IDictionary.Add(object k, object v) { }

	// RVA: 0x417E054 Offset: 0x417A054 VA: 0x417E054 Slot: 55
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x417E058 Offset: 0x417A058 VA: 0x417E058 Slot: 53
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x417E060 Offset: 0x417A060 VA: 0x417E060 Slot: 59
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x417E064 Offset: 0x417A064 VA: 0x417E064 Slot: 58
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x417E06C Offset: 0x417A06C VA: 0x417E06C Slot: 44
	private object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx) { }

	// RVA: 0x417E074 Offset: 0x417A074 VA: 0x417E074 Slot: 45
	private void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value) { }

	// RVA: 0x417E078 Offset: 0x417A078 VA: 0x417E078 Slot: 46
	private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator() { }

	// RVA: 0x417E080 Offset: 0x417A080 VA: 0x417E080 Slot: 47
	private void System.Collections.Specialized.IOrderedDictionary.Insert(int i, object k, object v) { }

	// RVA: 0x417E084 Offset: 0x417A084 VA: 0x417E084 Slot: 48
	private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int i) { }

	// RVA: 0x417C8CC Offset: 0x41788CC VA: 0x417C8CC
	public void .ctor() { }
}

// Namespace: LitJson
public enum JsonToken // TypeDefIndex: 24281
{
	// Fields
	public int value__; // 0x0
	public const JsonToken None = 0;
	public const JsonToken ObjectStart = 1;
	public const JsonToken PropertyName = 2;
	public const JsonToken ObjectEnd = 3;
	public const JsonToken ArrayStart = 4;
	public const JsonToken ArrayEnd = 5;
	public const JsonToken Int = 6;
	public const JsonToken Long = 7;
	public const JsonToken Double = 8;
	public const JsonToken Fp = 9;
	public const JsonToken String = 10;
	public const JsonToken Boolean = 11;
	public const JsonToken Null = 12;
}

// Namespace: LitJson
public class JsonReader // TypeDefIndex: 24282
{
	// Fields
	private static readonly IDictionary<int, IDictionary<int, int[]>> parse_table; // 0x0
	private Stack<int> automaton_stack; // 0x10
	private int current_input; // 0x18
	private int current_symbol; // 0x1C
	private bool end_of_json; // 0x20
	private bool end_of_input; // 0x21
	private Lexer lexer; // 0x28
	private bool parser_in_string; // 0x30
	private bool parser_return; // 0x31
	private bool read_started; // 0x32
	private TextReader reader; // 0x38
	private bool reader_is_owned; // 0x40
	private bool skip_non_members; // 0x41
	private object token_value; // 0x48
	private JsonToken token; // 0x50
	public bool useFp; // 0x54

	// Properties
	public bool AllowComments { get; set; }
	public bool AllowSingleQuotedStrings { get; set; }
	public bool SkipNonMembers { get; set; }
	public bool EndOfInput { get; }
	public bool EndOfJson { get; }
	public JsonToken Token { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x417E088 Offset: 0x417A088 VA: 0x417E088
	public bool get_AllowComments() { }

	// RVA: 0x417E0A4 Offset: 0x417A0A4 VA: 0x417E0A4
	public void set_AllowComments(bool value) { }

	// RVA: 0x417E0C4 Offset: 0x417A0C4 VA: 0x417E0C4
	public bool get_AllowSingleQuotedStrings() { }

	// RVA: 0x417E0E0 Offset: 0x417A0E0 VA: 0x417E0E0
	public void set_AllowSingleQuotedStrings(bool value) { }

	// RVA: 0x417E100 Offset: 0x417A100 VA: 0x417E100
	public bool get_SkipNonMembers() { }

	// RVA: 0x417E108 Offset: 0x417A108 VA: 0x417E108
	public void set_SkipNonMembers(bool value) { }

	// RVA: 0x417E114 Offset: 0x417A114 VA: 0x417E114
	public bool get_EndOfInput() { }

	// RVA: 0x417E11C Offset: 0x417A11C VA: 0x417E11C
	public bool get_EndOfJson() { }

	// RVA: 0x417E124 Offset: 0x417A124 VA: 0x417E124
	public JsonToken get_Token() { }

	// RVA: 0x417E12C Offset: 0x417A12C VA: 0x417E12C
	public object get_Value() { }

	// RVA: 0x417E134 Offset: 0x417A134 VA: 0x417E134
	private static void .cctor() { }

	// RVA: 0x417C55C Offset: 0x417855C VA: 0x417C55C
	public void .ctor(string json_text) { }

	// RVA: 0x417C108 Offset: 0x4178108 VA: 0x417C108
	public void .ctor(TextReader reader) { }

	// RVA: 0x417E8F0 Offset: 0x417A8F0 VA: 0x417E8F0
	private void .ctor(TextReader reader, bool owned) { }

	// RVA: 0x417E18C Offset: 0x417A18C VA: 0x417E18C
	private static IDictionary<int, IDictionary<int, int[]>> PopulateParseTable() { }

	// RVA: 0x417EC6C Offset: 0x417AC6C VA: 0x417EC6C
	private static void TableAddCol(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken row, int col, int[] symbols) { }

	// RVA: 0x417EB7C Offset: 0x417AB7C VA: 0x417EB7C
	private static void TableAddRow(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken rule) { }

	// RVA: 0x417EDA0 Offset: 0x417ADA0 VA: 0x417EDA0
	private void ProcessNumber(string number) { }

	// RVA: 0x417F040 Offset: 0x417B040 VA: 0x417F040
	private void ProcessSymbol() { }

	// RVA: 0x417F200 Offset: 0x417B200 VA: 0x417F200
	private bool ReadToken() { }

	// RVA: 0x417F424 Offset: 0x417B424 VA: 0x417F424
	public void Close() { }

	// RVA: 0x417904C Offset: 0x417504C VA: 0x417904C
	public bool Read() { }
}

// Namespace: LitJson
internal enum Condition // TypeDefIndex: 24283
{
	// Fields
	public int value__; // 0x0
	public const Condition InArray = 0;
	public const Condition InObject = 1;
	public const Condition NotAProperty = 2;
	public const Condition Property = 3;
	public const Condition Value = 4;
}

// Namespace: LitJson
internal class WriterContext // TypeDefIndex: 24284
{
	// Fields
	public int Count; // 0x10
	public bool InArray; // 0x14
	public bool InObject; // 0x15
	public bool ExpectingValue; // 0x16
	public int Padding; // 0x18

	// Methods

	// RVA: 0x417F4F4 Offset: 0x417B4F4 VA: 0x417F4F4
	public void .ctor() { }
}

// Namespace: LitJson
public class JsonWriter // TypeDefIndex: 24285
{
	// Fields
	private static readonly NumberFormatInfo number_format; // 0x0
	private WriterContext context; // 0x10
	private Stack<WriterContext> ctx_stack; // 0x18
	private bool has_reached_end; // 0x20
	private char[] hex_seq; // 0x28
	private int indentation; // 0x30
	private int indent_value; // 0x34
	private StringBuilder inst_string_builder; // 0x38
	private bool pretty_print; // 0x40
	private bool validate; // 0x41
	private bool lower_case_properties; // 0x42
	private TextWriter writer; // 0x48

	// Properties
	public int IndentValue { get; set; }
	public bool PrettyPrint { get; set; }
	public TextWriter TextWriter { get; }
	public bool Validate { get; set; }
	public bool LowerCaseProperties { get; set; }

	// Methods

	// RVA: 0x417F4FC Offset: 0x417B4FC VA: 0x417F4FC
	public int get_IndentValue() { }

	// RVA: 0x417F504 Offset: 0x417B504 VA: 0x417F504
	public void set_IndentValue(int value) { }

	// RVA: 0x417F518 Offset: 0x417B518 VA: 0x417F518
	public bool get_PrettyPrint() { }

	// RVA: 0x417F520 Offset: 0x417B520 VA: 0x417F520
	public void set_PrettyPrint(bool value) { }

	// RVA: 0x417F52C Offset: 0x417B52C VA: 0x417F52C
	public TextWriter get_TextWriter() { }

	// RVA: 0x417F534 Offset: 0x417B534 VA: 0x417F534
	public bool get_Validate() { }

	// RVA: 0x417F53C Offset: 0x417B53C VA: 0x417F53C
	public void set_Validate(bool value) { }

	// RVA: 0x417F548 Offset: 0x417B548 VA: 0x417F548
	public bool get_LowerCaseProperties() { }

	// RVA: 0x417F550 Offset: 0x417B550 VA: 0x417F550
	public void set_LowerCaseProperties(bool value) { }

	// RVA: 0x417F55C Offset: 0x417B55C VA: 0x417F55C
	private static void .cctor() { }

	// RVA: 0x41747B0 Offset: 0x41707B0 VA: 0x41747B0
	public void .ctor() { }

	// RVA: 0x417F6F0 Offset: 0x417B6F0 VA: 0x417F6F0
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x4173658 Offset: 0x416F658 VA: 0x4173658
	public void .ctor(TextWriter writer) { }

	// RVA: 0x417F75C Offset: 0x417B75C VA: 0x417F75C
	private void DoValidation(Condition cond) { }

	// RVA: 0x417F5B8 Offset: 0x417B5B8 VA: 0x417F5B8
	private void Init() { }

	// RVA: 0x417F8E0 Offset: 0x417B8E0 VA: 0x417F8E0
	private static void IntToHex(int n, char[] hex) { }

	// RVA: 0x417F958 Offset: 0x417B958 VA: 0x417F958
	private void Indent() { }

	// RVA: 0x417F970 Offset: 0x417B970 VA: 0x417F970
	private void Put(string str) { }

	// RVA: 0x417F9FC Offset: 0x417B9FC VA: 0x417F9FC
	private void PutNewline() { }

	// RVA: 0x417FA04 Offset: 0x417BA04 VA: 0x417FA04
	private void PutNewline(bool add_comma) { }

	// RVA: 0x417FA98 Offset: 0x417BA98 VA: 0x417FA98
	private void PutString(string str) { }

	// RVA: 0x417FDA0 Offset: 0x417BDA0 VA: 0x417FDA0
	private void Unindent() { }

	// RVA: 0x417FDB8 Offset: 0x417BDB8 VA: 0x417FDB8 Slot: 3
	public override string ToString() { }

	// RVA: 0x417BCEC Offset: 0x4177CEC VA: 0x417BCEC
	public void Reset() { }

	// RVA: 0x4172474 Offset: 0x416E474 VA: 0x4172474
	public void Write(bool boolean) { }

	// RVA: 0x417CBA4 Offset: 0x4178BA4 VA: 0x417CBA4
	public void Write(Decimal number) { }

	// RVA: 0x417250C Offset: 0x416E50C VA: 0x417250C
	public void Write(double number) { }

	// RVA: 0x4172648 Offset: 0x416E648 VA: 0x4172648
	public void Write(FP number) { }

	// RVA: 0x417B9D0 Offset: 0x41779D0 VA: 0x417B9D0
	public void Write(float number) { }

	// RVA: 0x41727B4 Offset: 0x416E7B4 VA: 0x41727B4
	public void Write(int number) { }

	// RVA: 0x4172888 Offset: 0x416E888 VA: 0x4172888
	public void Write(long number) { }

	// RVA: 0x41723E8 Offset: 0x416E3E8 VA: 0x41723E8
	public void Write(string str) { }

	[CLSCompliant(False)]
	// RVA: 0x417BAA4 Offset: 0x4177AA4 VA: 0x417BAA4
	public void Write(ulong number) { }

	// RVA: 0x4172A50 Offset: 0x416EA50 VA: 0x4172A50
	public void WriteArrayEnd() { }

	// RVA: 0x417295C Offset: 0x416E95C VA: 0x417295C
	public void WriteArrayStart() { }

	// RVA: 0x4172D70 Offset: 0x416ED70 VA: 0x4172D70
	public void WriteObjectEnd() { }

	// RVA: 0x4172B50 Offset: 0x416EB50 VA: 0x4172B50
	public void WriteObjectStart() { }

	// RVA: 0x4172C44 Offset: 0x416EC44 VA: 0x4172C44
	public void WritePropertyName(string property_name) { }
}

// Namespace: LitJson
internal class FsmContext // TypeDefIndex: 24286
{
	// Fields
	public bool Return; // 0x10
	public int NextState; // 0x14
	public Lexer L; // 0x18
	public int StateStack; // 0x20

	// Methods

	// RVA: 0x417FE20 Offset: 0x417BE20 VA: 0x417FE20
	public void .ctor() { }
}

// Namespace: 
private sealed class Lexer.StateHandler : MulticastDelegate // TypeDefIndex: 24287
{
	// Methods

	// RVA: 0x4180864 Offset: 0x417C864 VA: 0x4180864
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4181CFC Offset: 0x417DCFC VA: 0x4181CFC Slot: 13
	public virtual bool Invoke(FsmContext ctx) { }

	// RVA: 0x4181D10 Offset: 0x417DD10 VA: 0x4181D10 Slot: 14
	public virtual IAsyncResult BeginInvoke(FsmContext ctx, AsyncCallback callback, object object) { }

	// RVA: 0x4181D30 Offset: 0x417DD30 VA: 0x4181D30 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: LitJson
internal class Lexer // TypeDefIndex: 24288
{
	// Fields
	private static readonly int[] fsm_return_table; // 0x0
	private static readonly Lexer.StateHandler[] fsm_handler_table; // 0x8
	private bool allow_comments; // 0x10
	private bool allow_single_quoted_strings; // 0x11
	private bool end_of_input; // 0x12
	private FsmContext fsm_context; // 0x18
	private int input_buffer; // 0x20
	private int input_char; // 0x24
	private TextReader reader; // 0x28
	private int state; // 0x30
	private StringBuilder string_buffer; // 0x38
	private string string_value; // 0x40
	private int token; // 0x48
	private int unichar; // 0x4C

	// Properties
	public bool AllowComments { get; set; }
	public bool AllowSingleQuotedStrings { get; set; }
	public bool EndOfInput { get; }
	public int Token { get; }
	public string StringValue { get; }

	// Methods

	// RVA: 0x417FE28 Offset: 0x417BE28 VA: 0x417FE28
	public bool get_AllowComments() { }

	// RVA: 0x417FE30 Offset: 0x417BE30 VA: 0x417FE30
	public void set_AllowComments(bool value) { }

	// RVA: 0x417FE3C Offset: 0x417BE3C VA: 0x417FE3C
	public bool get_AllowSingleQuotedStrings() { }

	// RVA: 0x417FE44 Offset: 0x417BE44 VA: 0x417FE44
	public void set_AllowSingleQuotedStrings(bool value) { }

	// RVA: 0x417FE50 Offset: 0x417BE50 VA: 0x417FE50
	public bool get_EndOfInput() { }

	// RVA: 0x417FE58 Offset: 0x417BE58 VA: 0x417FE58
	public int get_Token() { }

	// RVA: 0x417FE60 Offset: 0x417BE60 VA: 0x417FE60
	public string get_StringValue() { }

	// RVA: 0x417FE68 Offset: 0x417BE68 VA: 0x417FE68
	private static void .cctor() { }

	// RVA: 0x417EA84 Offset: 0x417AA84 VA: 0x417EA84
	public void .ctor(TextReader reader) { }

	// RVA: 0x41807E0 Offset: 0x417C7E0 VA: 0x41807E0
	private static int HexValue(int digit) { }

	// RVA: 0x417FEB0 Offset: 0x417BEB0 VA: 0x417FEB0
	private static void PopulateFsmTables(out Lexer.StateHandler[] fsm_handler_table, out int[] fsm_return_table) { }

	// RVA: 0x418096C Offset: 0x417C96C VA: 0x418096C
	private static char ProcessEscChar(int esc_char) { }

	// RVA: 0x4180A5C Offset: 0x417CA5C VA: 0x4180A5C
	private static bool State1(FsmContext ctx) { }

	// RVA: 0x4180C64 Offset: 0x417CC64 VA: 0x4180C64
	private static bool State2(FsmContext ctx) { }

	// RVA: 0x4180D0C Offset: 0x417CD0C VA: 0x4180D0C
	private static bool State3(FsmContext ctx) { }

	// RVA: 0x4180E48 Offset: 0x417CE48 VA: 0x4180E48
	private static bool State4(FsmContext ctx) { }

	// RVA: 0x4180F40 Offset: 0x417CF40 VA: 0x4180F40
	private static bool State5(FsmContext ctx) { }

	// RVA: 0x4180FBC Offset: 0x417CFBC VA: 0x4180FBC
	private static bool State6(FsmContext ctx) { }

	// RVA: 0x41810B8 Offset: 0x417D0B8 VA: 0x41810B8
	private static bool State7(FsmContext ctx) { }

	// RVA: 0x418114C Offset: 0x417D14C VA: 0x418114C
	private static bool State8(FsmContext ctx) { }

	// RVA: 0x4181208 Offset: 0x417D208 VA: 0x4181208
	private static bool State9(FsmContext ctx) { }

	// RVA: 0x4181270 Offset: 0x417D270 VA: 0x4181270
	private static bool State10(FsmContext ctx) { }

	// RVA: 0x41812D8 Offset: 0x417D2D8 VA: 0x41812D8
	private static bool State11(FsmContext ctx) { }

	// RVA: 0x4181344 Offset: 0x417D344 VA: 0x4181344
	private static bool State12(FsmContext ctx) { }

	// RVA: 0x41813AC Offset: 0x417D3AC VA: 0x41813AC
	private static bool State13(FsmContext ctx) { }

	// RVA: 0x4181414 Offset: 0x417D414 VA: 0x4181414
	private static bool State14(FsmContext ctx) { }

	// RVA: 0x418147C Offset: 0x417D47C VA: 0x418147C
	private static bool State15(FsmContext ctx) { }

	// RVA: 0x41814E8 Offset: 0x417D4E8 VA: 0x41814E8
	private static bool State16(FsmContext ctx) { }

	// RVA: 0x4181550 Offset: 0x417D550 VA: 0x4181550
	private static bool State17(FsmContext ctx) { }

	// RVA: 0x41815B8 Offset: 0x417D5B8 VA: 0x41815B8
	private static bool State18(FsmContext ctx) { }

	// RVA: 0x4181624 Offset: 0x417D624 VA: 0x4181624
	private static bool State19(FsmContext ctx) { }

	// RVA: 0x41816CC Offset: 0x417D6CC VA: 0x41816CC
	private static bool State20(FsmContext ctx) { }

	// RVA: 0x4181738 Offset: 0x417D738 VA: 0x4181738
	private static bool State21(FsmContext ctx) { }

	// RVA: 0x4181870 Offset: 0x417D870 VA: 0x4181870
	private static bool State22(FsmContext ctx) { }

	// RVA: 0x41819E4 Offset: 0x417D9E4 VA: 0x41819E4
	private static bool State23(FsmContext ctx) { }

	// RVA: 0x4181A8C Offset: 0x417DA8C VA: 0x4181A8C
	private static bool State24(FsmContext ctx) { }

	// RVA: 0x4181B00 Offset: 0x417DB00 VA: 0x4181B00
	private static bool State25(FsmContext ctx) { }

	// RVA: 0x4181B7C Offset: 0x417DB7C VA: 0x4181B7C
	private static bool State26(FsmContext ctx) { }

	// RVA: 0x4181BE4 Offset: 0x417DBE4 VA: 0x4181BE4
	private static bool State27(FsmContext ctx) { }

	// RVA: 0x4181C4C Offset: 0x417DC4C VA: 0x4181C4C
	private static bool State28(FsmContext ctx) { }

	// RVA: 0x4180C34 Offset: 0x417CC34 VA: 0x4180C34
	private bool GetChar() { }

	// RVA: 0x4181CC4 Offset: 0x417DCC4 VA: 0x4181CC4
	private int NextChar() { }

	// RVA: 0x417F254 Offset: 0x417B254 VA: 0x417F254
	public bool NextToken() { }

	// RVA: 0x4180E3C Offset: 0x417CE3C VA: 0x4180E3C
	private void UngetChar() { }
}

// Namespace: LitJson
internal enum ParserToken // TypeDefIndex: 24289
{
	// Fields
	public int value__; // 0x0
	public const ParserToken None = 65536;
	public const ParserToken Number = 65537;
	public const ParserToken True = 65538;
	public const ParserToken False = 65539;
	public const ParserToken Null = 65540;
	public const ParserToken CharSeq = 65541;
	public const ParserToken Char = 65542;
	public const ParserToken Text = 65543;
	public const ParserToken Object = 65544;
	public const ParserToken ObjectPrime = 65545;
	public const ParserToken Pair = 65546;
	public const ParserToken PairRest = 65547;
	public const ParserToken Array = 65548;
	public const ParserToken ArrayPrime = 65549;
	public const ParserToken Value = 65550;
	public const ParserToken ValueRest = 65551;
	public const ParserToken String = 65552;
	public const ParserToken End = 65553;
	public const ParserToken Epsilon = 65554;
}

// Namespace: 
[CompilerGenerated]
private sealed class CollectionHelpers.NongenericCollectionWrapper.<GetEnumerator>d__4<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 24290
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public CollectionHelpers.NongenericCollectionWrapper<T> <>4__this; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E5CC Offset: 0x5D2A5CC VA: 0x5D2E5CC
	|-CollectionHelpers.NongenericCollectionWrapper.<GetEnumerator>d__4<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E60C Offset: 0x5D2A60C VA: 0x5D2E60C
	|-CollectionHelpers.NongenericCollectionWrapper.<GetEnumerator>d__4<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E66C Offset: 0x5D2A66C VA: 0x5D2E66C
	|-CollectionHelpers.NongenericCollectionWrapper.<GetEnumerator>d__4<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2EAF8 Offset: 0x5D2AAF8 VA: 0x5D2EAF8
	|-CollectionHelpers.NongenericCollectionWrapper.<GetEnumerator>d__4<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2EBF4 Offset: 0x5D2ABF4 VA: 0x5D2EBF4
	|-CollectionHelpers.NongenericCollectionWrapper.<GetEnumerator>d__4<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2EC94 Offset: 0x5D2AC94 VA: 0x5D2EC94
	|-CollectionHelpers.NongenericCollectionWrapper.<GetEnumerator>d__4<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2ECC8 Offset: 0x5D2ACC8 VA: 0x5D2ECC8
	|-CollectionHelpers.NongenericCollectionWrapper.<GetEnumerator>d__4<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
private sealed class CollectionHelpers.NongenericCollectionWrapper<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 24291
{
	// Fields
	private readonly ICollection _collection; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512A5E4 Offset: 0x51265E4 VA: 0x512A5E4
	|-CollectionHelpers.NongenericCollectionWrapper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512A620 Offset: 0x5126620 VA: 0x512A620
	|-CollectionHelpers.NongenericCollectionWrapper<__Il2CppFullySharedGenericType>.get_Count
	*/

	[IteratorStateMachine(typeof(CollectionHelpers.NongenericCollectionWrapper.<GetEnumerator>d__4<T>))]
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512A6C4 Offset: 0x51266C4 VA: 0x512A6C4
	|-CollectionHelpers.NongenericCollectionWrapper<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512A750 Offset: 0x5126750 VA: 0x512A750
	|-CollectionHelpers.NongenericCollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
private sealed class CollectionHelpers.CollectionWrapper<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 24292
{
	// Fields
	private readonly ICollection<T> _collection; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBC788 Offset: 0x5BB8788 VA: 0x5BBC788
	|-CollectionHelpers.CollectionWrapper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBC7C4 Offset: 0x5BB87C4 VA: 0x5BBC7C4
	|-CollectionHelpers.CollectionWrapper<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBC84C Offset: 0x5BB884C VA: 0x5BBC84C
	|-CollectionHelpers.CollectionWrapper<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BBC8D4 Offset: 0x5BB88D4 VA: 0x5BBC8D4
	|-CollectionHelpers.CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Custom.Collections
internal static class CollectionHelpers // TypeDefIndex: 24293
{
	// Methods

	// RVA: -1 Offset: -1
	public static IReadOnlyCollection<T> ReifyCollection<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4550BB8 Offset: 0x454CBB8 VA: 0x4550BB8
	|-CollectionHelpers.ReifyCollection<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[DebuggerNonUserCode]
private sealed class DoubleEndQueue.DebugView<T> // TypeDefIndex: 24294
{
	// Fields
	private readonly DoubleEndQueue<T> _doubleEndQueue; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public T[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DoubleEndQueue<T> doubleEndQueue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1FB48 Offset: 0x5D1BB48 VA: 0x5D1FB48
	|-DoubleEndQueue.DebugView<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1FB78 Offset: 0x5D1BB78 VA: 0x5D1FB78
	|-DoubleEndQueue.DebugView<__Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DoubleEndQueue.<GetEnumerator>d__19<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 24295
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public DoubleEndQueue<T> <>4__this; // 0x0
	private int <count>5__2; // 0x0
	private int <i>5__3; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D29D10 Offset: 0x5D25D10 VA: 0x5D29D10
	|-DoubleEndQueue.<GetEnumerator>d__19<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D29D50 Offset: 0x5D25D50 VA: 0x5D29D50
	|-DoubleEndQueue.<GetEnumerator>d__19<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D29D54 Offset: 0x5D25D54 VA: 0x5D29D54
	|-DoubleEndQueue.<GetEnumerator>d__19<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D29FC0 Offset: 0x5D25FC0 VA: 0x5D29FC0
	|-DoubleEndQueue.<GetEnumerator>d__19<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A060 Offset: 0x5D26060 VA: 0x5D2A060
	|-DoubleEndQueue.<GetEnumerator>d__19<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A094 Offset: 0x5D26094 VA: 0x5D2A094
	|-DoubleEndQueue.<GetEnumerator>d__19<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Custom.Collections
[DebuggerTypeProxy(typeof(DoubleEndQueue.DebugView<T>))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
public sealed class DoubleEndQueue<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>, IList, ICollection // TypeDefIndex: 24296
{
	// Fields
	private const int DefaultCapacity = 8;
	private T[] _buffer; // 0x0
	private int _offset; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	public T Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool IsEmpty { get; }
	private bool IsFull { get; }
	private bool IsSplit { get; }
	public int Capacity { get; set; }
	public int Count { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C310 Offset: 0x6018310 VA: 0x601C310
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C3B8 Offset: 0x60183B8 VA: 0x601C3B8
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C518 Offset: 0x6018518 VA: 0x601C518
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C530 Offset: 0x6018530 VA: 0x601C530
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C538 Offset: 0x6018538 VA: 0x601C538
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C628 Offset: 0x6018628 VA: 0x601C628
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C73C Offset: 0x601873C VA: 0x601C73C
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C854 Offset: 0x6018854 VA: 0x601C854
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C8B8 Offset: 0x60188B8 VA: 0x601C8B8
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601CCB4 Offset: 0x6018CB4 VA: 0x601CCB4
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<T>.Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601CDB4 Offset: 0x6018DB4 VA: 0x601CDB4
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601D1A8 Offset: 0x60191A8 VA: 0x601D1A8
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void CopyToArray(Array array, int arrayIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601D23C Offset: 0x601923C VA: 0x601D23C
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.CopyToArray
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601D338 Offset: 0x6019338 VA: 0x601D338
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.Remove
	*/

	[IteratorStateMachine(typeof(DoubleEndQueue.<GetEnumerator>d__19<T>))]
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601D434 Offset: 0x6019434 VA: 0x601D434
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601D4C0 Offset: 0x60194C0 VA: 0x601D4C0
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	private static bool IsT(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601D4D4 Offset: 0x60194D4 VA: 0x601D4D4
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.IsT
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 22
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601D630 Offset: 0x6019630 VA: 0x601D630
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601D84C Offset: 0x601984C VA: 0x601D84C
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601D9CC Offset: 0x60199CC VA: 0x601D9CC
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601DAD4 Offset: 0x6019AD4 VA: 0x601DAD4
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601DCE0 Offset: 0x6019CE0 VA: 0x601DCE0
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601DCE8 Offset: 0x6019CE8 VA: 0x601DCE8
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601DCF0 Offset: 0x6019CF0 VA: 0x601DCF0
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601DDEC Offset: 0x6019DEC VA: 0x601DDEC
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601DE9C Offset: 0x6019E9C VA: 0x601DE9C
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E0A8 Offset: 0x601A0A8 VA: 0x601E0A8
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E280 Offset: 0x601A280 VA: 0x601E280
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E288 Offset: 0x601A288 VA: 0x601E288
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	private static void CheckNewIndexArgument(int sourceLength, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E28C Offset: 0x601A28C VA: 0x601E28C
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.CheckNewIndexArgument
	*/

	// RVA: -1 Offset: -1
	private static void CheckExistingIndexArgument(int sourceLength, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E354 Offset: 0x601A354 VA: 0x601E354
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.CheckExistingIndexArgument
	*/

	// RVA: -1 Offset: -1
	private static void CheckRangeArguments(int sourceLength, int offset, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E41C Offset: 0x601A41C VA: 0x601E41C
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.CheckRangeArguments
	*/

	// RVA: -1 Offset: -1
	private bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E644 Offset: 0x601A644 VA: 0x601E644
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	private bool get_IsFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E66C Offset: 0x601A66C VA: 0x601E66C
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.get_IsFull
	*/

	// RVA: -1 Offset: -1
	private bool get_IsSplit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E6C0 Offset: 0x601A6C0 VA: 0x601E6C0
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.get_IsSplit
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E71C Offset: 0x601A71C VA: 0x601E71C
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E738 Offset: 0x601A738 VA: 0x601E738
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.set_Capacity
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 32
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E840 Offset: 0x601A840 VA: 0x601E840
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E848 Offset: 0x601A848 VA: 0x601E848
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1
	private int DequeIndexToBufferIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E850 Offset: 0x601A850 VA: 0x601E850
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DequeIndexToBufferIndex
	*/

	// RVA: -1 Offset: -1
	private T DoGetItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E890 Offset: 0x601A890 VA: 0x601E890
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoGetItem
	*/

	// RVA: -1 Offset: -1
	private void DoSetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E964 Offset: 0x601A964 VA: 0x601E964
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoSetItem
	*/

	// RVA: -1 Offset: -1
	private void DoInsert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601EAA4 Offset: 0x601AAA4 VA: 0x601EAA4
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoInsert
	*/

	// RVA: -1 Offset: -1
	private void DoRemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601ECB4 Offset: 0x601ACB4 VA: 0x601ECB4
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoRemoveAt
	*/

	// RVA: -1 Offset: -1
	private int PostIncrement(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601EDA0 Offset: 0x601ADA0 VA: 0x601EDA0
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.PostIncrement
	*/

	// RVA: -1 Offset: -1
	private int PreDecrement(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601EDE8 Offset: 0x601ADE8 VA: 0x601EDE8
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.PreDecrement
	*/

	// RVA: -1 Offset: -1
	private void DoAddToBack(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601EE30 Offset: 0x601AE30 VA: 0x601EE30
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoAddToBack
	*/

	// RVA: -1 Offset: -1
	private void DoAddToFront(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601EFC4 Offset: 0x601AFC4 VA: 0x601EFC4
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoAddToFront
	*/

	// RVA: -1 Offset: -1
	private T DoRemoveFromBack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601F140 Offset: 0x601B140 VA: 0x601F140
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoRemoveFromBack
	*/

	// RVA: -1 Offset: -1
	private T DoRemoveFromFront() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601F274 Offset: 0x601B274 VA: 0x601F274
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoRemoveFromFront
	*/

	// RVA: -1 Offset: -1
	private void DoInsertRange(int index, IReadOnlyCollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601F388 Offset: 0x601B388 VA: 0x601F388
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoInsertRange
	*/

	// RVA: -1 Offset: -1
	private void DoRemoveRange(int index, int collectionCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601FB44 Offset: 0x601BB44 VA: 0x601FB44
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.DoRemoveRange
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacityForOneElement() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601FEFC Offset: 0x601BEFC VA: 0x601FEFC
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.EnsureCapacityForOneElement
	*/

	// RVA: -1 Offset: -1
	public void AddToBack(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601FF98 Offset: 0x601BF98 VA: 0x601FF98
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.AddToBack
	*/

	// RVA: -1 Offset: -1
	public void AddToFront(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6020084 Offset: 0x601C084 VA: 0x6020084
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.AddToFront
	*/

	// RVA: -1 Offset: -1
	public void InsertRange(int index, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6020170 Offset: 0x601C170 VA: 0x6020170
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.InsertRange
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int offset, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6020328 Offset: 0x601C328 VA: 0x6020328
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.RemoveRange
	*/

	// RVA: -1 Offset: -1
	public T RemoveFromBack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60203B4 Offset: 0x601C3B4 VA: 0x60203B4
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.RemoveFromBack
	*/

	// RVA: -1 Offset: -1
	public T RemoveFromFront() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60204B8 Offset: 0x601C4B8 VA: 0x60204B8
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.RemoveFromFront
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60205BC Offset: 0x601C5BC VA: 0x60205BC
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60205D8 Offset: 0x601C5D8 VA: 0x60205D8
	|-DoubleEndQueue<__Il2CppFullySharedGenericType>.ToArray
	*/
}

// Namespace: Custom.Collections
public sealed class KeyedPriorityQueueHeadChangedEventArgs<T> : EventArgs // TypeDefIndex: 24297
{
	// Fields
	private T newFirstElement; // 0x0
	private T oldFirstElement; // 0x0

	// Properties
	public T NewFirstElement { get; }
	public T OldFirstElement { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T oldFirstElement, T newFirstElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B05D8C Offset: 0x4B01D8C VA: 0x4B05D8C
	|-KeyedPriorityQueueHeadChangedEventArgs<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_NewFirstElement() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B05E14 Offset: 0x4B01E14 VA: 0x4B05E14
	|-KeyedPriorityQueueHeadChangedEventArgs<object>.get_NewFirstElement
	*/

	// RVA: -1 Offset: -1
	public T get_OldFirstElement() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B05E1C Offset: 0x4B01E1C VA: 0x4B05E1C
	|-KeyedPriorityQueueHeadChangedEventArgs<object>.get_OldFirstElement
	*/
}

// Namespace: 
[Serializable]
private struct KeyedPriorityQueue.HeapNode<K, V, P, KK, VV, PP> // TypeDefIndex: 24298
{
	// Fields
	public KK Key; // 0x0
	public VV Value; // 0x0
	public PP Priority; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(KK key, VV value, PP priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4984878 Offset: 0x4980878 VA: 0x4984878
	|-KeyedPriorityQueue.HeapNode<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Custom.Collections
[Serializable]
public class KeyedPriorityQueue<K, V, P> // TypeDefIndex: 24299
{
	// Fields
	private List<KeyedPriorityQueue.HeapNode<K, V, P, K, V, P>> heap; // 0x0
	private KeyedPriorityQueue.HeapNode<K, V, P, K, V, P> placeHolder; // 0x0
	private Comparer<P> priorityComparer; // 0x0
	private int size; // 0x0
	[CompilerGenerated]
	private EventHandler<KeyedPriorityQueueHeadChangedEventArgs<V>> FirstElementChanged; // 0x0

	// Properties
	public int Count { get; }
	public ReadOnlyCollection<K> Keys { get; }
	public ReadOnlyCollection<V> Values { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_FirstElementChanged(EventHandler<KeyedPriorityQueueHeadChangedEventArgs<V>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B05E24 Offset: 0x4B01E24 VA: 0x4B05E24
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.add_FirstElementChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_FirstElementChanged(EventHandler<KeyedPriorityQueueHeadChangedEventArgs<V>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B05F04 Offset: 0x4B01F04 VA: 0x4B05F04
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.remove_FirstElementChanged
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B05FE4 Offset: 0x4B01FE4 VA: 0x4B05FE4
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B061A8 Offset: 0x4B021A8 VA: 0x4B061A8
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public V Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B06214 Offset: 0x4B02214 VA: 0x4B06214
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	private V DequeueImpl() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B06394 Offset: 0x4B02394 VA: 0x4B06394
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.DequeueImpl
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(K key, V value, P priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B06638 Offset: 0x4B02638 VA: 0x4B06638
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public V FindByPriority(P priority, Predicate<V> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B06C58 Offset: 0x4B02C58 VA: 0x4B06C58
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.FindByPriority
	*/

	// RVA: -1 Offset: -1
	private void Heapify(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B06D7C Offset: 0x4B02D7C VA: 0x4B06D7C
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.Heapify
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual bool IsHigher(P p1, P p2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B07160 Offset: 0x4B03160 VA: 0x4B07160
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.IsHigher
	*/

	// RVA: -1 Offset: -1
	public V Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B072A4 Offset: 0x4B032A4 VA: 0x4B072A4
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	private void RaiseHeadChangedEvent(V oldHead, V newHead) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B073B0 Offset: 0x4B033B0 VA: 0x4B073B0
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.RaiseHeadChangedEvent
	*/

	// RVA: -1 Offset: -1
	public V Remove(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B07454 Offset: 0x4B03454 VA: 0x4B07454
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	private V Search(P priority, int i, Predicate<V> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B079B4 Offset: 0x4B039B4 VA: 0x4B079B4
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.Search
	*/

	// RVA: -1 Offset: -1
	private void Swap(int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B07D98 Offset: 0x4B03D98 VA: 0x4B07D98
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B07FB4 Offset: 0x4B03FB4 VA: 0x4B07FB4
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<K> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B07FDC Offset: 0x4B03FDC VA: 0x4B07FDC
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<V> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B081F8 Offset: 0x4B041F8 VA: 0x4B081F8
	|-KeyedPriorityQueue<__Il2CppFullySharedGenericType, object, __Il2CppFullySharedGenericType>.get_Values
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinkedArray.Node.<>c__DisplayClass22_0<T> // TypeDefIndex: 24300
{
	// Fields
	public T item; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486A4A4 Offset: 0x48664A4 VA: 0x486A4A4
	|-LinkedArray.Node.<>c__DisplayClass22_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <IndexOf>b__0(T m) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486A4AC Offset: 0x48664AC VA: 0x486A4AC
	|-LinkedArray.Node.<>c__DisplayClass22_0<__Il2CppFullySharedGenericType>.<IndexOf>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinkedArray.Node.<System-Collections-Generic-IEnumerable<T>-GetEnumerator>d__33<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 24301
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public LinkedArray.Node<T> <>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4A920 Offset: 0x5E46920 VA: 0x5E4A920
	|-LinkedArray.Node.<System-Collections-Generic-IEnumerable<T>-GetEnumerator>d__33<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4A960 Offset: 0x5E46960 VA: 0x5E4A960
	|-LinkedArray.Node.<System-Collections-Generic-IEnumerable<T>-GetEnumerator>d__33<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4A964 Offset: 0x5E46964 VA: 0x5E4A964
	|-LinkedArray.Node.<System-Collections-Generic-IEnumerable<T>-GetEnumerator>d__33<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4AB8C Offset: 0x5E46B8C VA: 0x5E4AB8C
	|-LinkedArray.Node.<System-Collections-Generic-IEnumerable<T>-GetEnumerator>d__33<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4AC2C Offset: 0x5E46C2C VA: 0x5E4AC2C
	|-LinkedArray.Node.<System-Collections-Generic-IEnumerable<T>-GetEnumerator>d__33<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4AC60 Offset: 0x5E46C60 VA: 0x5E4AC60
	|-LinkedArray.Node.<System-Collections-Generic-IEnumerable<T>-GetEnumerator>d__33<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[DefaultMember("Item")]
private class LinkedArray.Node<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 24302
{
	// Fields
	[CompilerGenerated]
	private LinkedArray.Node<T> <PrevNode>k__BackingField; // 0x0
	[CompilerGenerated]
	private LinkedArray.Node<T> <NextNode>k__BackingField; // 0x0
	private LinkedArray<T> outerInstance; // 0x0
	public int ElementCount; // 0x0
	private T[] table; // 0x0

	// Properties
	public virtual LinkedArray.Node<T> PrevNode { get; set; }
	public virtual LinkedArray.Node<T> NextNode { get; set; }
	protected virtual T[] Table { get; set; }
	public T Item { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public virtual LinkedArray.Node<T> get_PrevNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51262F0 Offset: 0x51222F0 VA: 0x51262F0
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.get_PrevNode
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public virtual void set_PrevNode(LinkedArray.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51262F8 Offset: 0x51222F8 VA: 0x51262F8
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.set_PrevNode
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public virtual LinkedArray.Node<T> get_NextNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5126300 Offset: 0x5122300 VA: 0x5126300
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.get_NextNode
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public virtual void set_NextNode(LinkedArray.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5126308 Offset: 0x5122308 VA: 0x5126308
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.set_NextNode
	*/

	// RVA: -1 Offset: -1
	public void .ctor(LinkedArray.Node<T> prev, LinkedArray.Node<T> next, LinkedArray<T> outerInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5126310 Offset: 0x5122310 VA: 0x5126310
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void InsertNextNode(LinkedArray.Node<T> prev, LinkedArray.Node<T> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5126378 Offset: 0x5122378 VA: 0x5126378
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.InsertNextNode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5126418 Offset: 0x5122418 VA: 0x5126418
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual void AddRange(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5126630 Offset: 0x5122630 VA: 0x5126630
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512677C Offset: 0x512277C VA: 0x512677C
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void InsertRange(int index, T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51269D8 Offset: 0x51229D8 VA: 0x51269D8
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.InsertRange
	*/

	// RVA: -1 Offset: -1
	private LinkedArray.InnerTable<T>[] SplitLargeTable(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5126EA0 Offset: 0x5122EA0 VA: 0x5126EA0
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.SplitLargeTable
	*/

	// RVA: -1 Offset: -1
	private void HalfSplitNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512720C Offset: 0x512320C VA: 0x512720C
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.HalfSplitNode
	*/

	// RVA: -1 Offset: -1
	private void SplitNode(int threshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51274C0 Offset: 0x51234C0 VA: 0x51274C0
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.SplitNode
	*/

	// RVA: -1 Offset: -1
	private void InsertTableItem(T[] array, int index, int length, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5127748 Offset: 0x5123748 VA: 0x5127748
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.InsertTableItem
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5127900 Offset: 0x5123900 VA: 0x5127900
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51279F8 Offset: 0x51239F8 VA: 0x51279F8
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5127B84 Offset: 0x5123B84 VA: 0x5127B84
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private void RemoveThisNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5127EA4 Offset: 0x5123EA4 VA: 0x5127EA4
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.RemoveThisNode
	*/

	// RVA: -1 Offset: -1
	private void ElementClear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5127F10 Offset: 0x5123F10 VA: 0x5127F10
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.ElementClear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual T[] get_Table() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5128024 Offset: 0x5124024 VA: 0x5128024
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.get_Table
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void set_Table(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51280B0 Offset: 0x51240B0 VA: 0x51280B0
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.set_Table
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51280B8 Offset: 0x51240B8 VA: 0x51280B8
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5128190 Offset: 0x5124190 VA: 0x5128190
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public T[] GetTableArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51282D4 Offset: 0x51242D4 VA: 0x51282D4
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.GetTableArray
	*/

	[IteratorStateMachine(typeof(LinkedArray.Node.<System-Collections-Generic-IEnumerable<T>-GetEnumerator>d__33<T>))]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5128348 Offset: 0x5124348 VA: 0x5128348
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51283D4 Offset: 0x51243D4 VA: 0x51283D4
	|-LinkedArray.Node<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
private class LinkedArray.TerminatedNode<T> : LinkedArray.Node<T> // TypeDefIndex: 24303
{
	// Properties
	protected override T[] Table { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(LinkedArray<T> outerInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55EA618 Offset: 0x55E6618 VA: 0x55EA618
	|-LinkedArray.TerminatedNode<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected override T[] get_Table() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55EA638 Offset: 0x55E6638 VA: 0x55EA638
	|-LinkedArray.TerminatedNode<__Il2CppFullySharedGenericType>.get_Table
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected override void set_Table(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55EA66C Offset: 0x55E666C VA: 0x55EA66C
	|-LinkedArray.TerminatedNode<__Il2CppFullySharedGenericType>.set_Table
	*/
}

// Namespace: 
private struct LinkedArray.IndexInfo<T> // TypeDefIndex: 24304
{
	// Fields
	[CompilerGenerated]
	private int <NodeIndex>k__BackingField; // 0x0
	[CompilerGenerated]
	private LinkedArray.Node<T> <Node>k__BackingField; // 0x0

	// Properties
	public int NodeIndex { get; set; }
	public LinkedArray.Node<T> Node { get; set; }
	public T Current { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: -1 Offset: -1
	public int get_NodeIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49985A4 Offset: 0x49945A4 VA: 0x49985A4
	|-LinkedArray.IndexInfo<__Il2CppFullySharedGenericType>.get_NodeIndex
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_NodeIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49985AC Offset: 0x49945AC VA: 0x49985AC
	|-LinkedArray.IndexInfo<__Il2CppFullySharedGenericType>.set_NodeIndex
	*/

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: -1 Offset: -1
	public LinkedArray.Node<T> get_Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49985B4 Offset: 0x49945B4 VA: 0x49985B4
	|-LinkedArray.IndexInfo<__Il2CppFullySharedGenericType>.get_Node
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Node(LinkedArray.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49985BC Offset: 0x49945BC VA: 0x49985BC
	|-LinkedArray.IndexInfo<__Il2CppFullySharedGenericType>.set_Node
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int nodeIndex, LinkedArray.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49985C4 Offset: 0x49945C4 VA: 0x49985C4
	|-LinkedArray.IndexInfo<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49986B4 Offset: 0x49946B4 VA: 0x49986B4
	|-LinkedArray.IndexInfo<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public void set_Current(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499889C Offset: 0x499489C VA: 0x499889C
	|-LinkedArray.IndexInfo<__Il2CppFullySharedGenericType>.set_Current
	*/
}

// Namespace: 
private class LinkedArray.InnerTable<T> // TypeDefIndex: 24305
{
	// Fields
	[CompilerGenerated]
	private T[] <Data>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <ElementCount>k__BackingField; // 0x0

	// Properties
	public T[] Data { get; set; }
	public int ElementCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T[] get_Data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499B35C Offset: 0x499735C VA: 0x499B35C
	|-LinkedArray.InnerTable<__Il2CppFullySharedGenericType>.get_Data
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Data(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499B364 Offset: 0x4997364 VA: 0x499B364
	|-LinkedArray.InnerTable<__Il2CppFullySharedGenericType>.set_Data
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_ElementCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499B36C Offset: 0x499736C VA: 0x499B36C
	|-LinkedArray.InnerTable<__Il2CppFullySharedGenericType>.get_ElementCount
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_ElementCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499B374 Offset: 0x4997374 VA: 0x499B374
	|-LinkedArray.InnerTable<__Il2CppFullySharedGenericType>.set_ElementCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] data, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499B37C Offset: 0x499737C VA: 0x499B37C
	|-LinkedArray.InnerTable<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinkedArray.<GetEnumerator>d__37<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 24306
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public LinkedArray<T> <>4__this; // 0x0
	private LinkedArray.Node<T> <current>5__2; // 0x0
	private IEnumerator<T> <>7__wrap2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2DCF0 Offset: 0x5D29CF0 VA: 0x5D2DCF0
	|-LinkedArray.<GetEnumerator>d__37<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2DD30 Offset: 0x5D29D30 VA: 0x5D2DD30
	|-LinkedArray.<GetEnumerator>d__37<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2DD90 Offset: 0x5D29D90 VA: 0x5D2DD90
	|-LinkedArray.<GetEnumerator>d__37<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E348 Offset: 0x5D2A348 VA: 0x5D2E348
	|-LinkedArray.<GetEnumerator>d__37<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E454 Offset: 0x5D2A454 VA: 0x5D2E454
	|-LinkedArray.<GetEnumerator>d__37<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E4F4 Offset: 0x5D2A4F4 VA: 0x5D2E4F4
	|-LinkedArray.<GetEnumerator>d__37<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2E528 Offset: 0x5D2A528 VA: 0x5D2E528
	|-LinkedArray.<GetEnumerator>d__37<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Custom.Collections
[DefaultMember("Item")]
public class LinkedArray<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IList<T> // TypeDefIndex: 24307
{
	// Fields
	[CompilerGenerated]
	private readonly LinkedArray.Node<T> <FirstNode>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly LinkedArray.Node<T> <LastNode>k__BackingField; // 0x0
	private LinkedArray.IndexInfo<T> cacheIndexInfo; // 0x0
	private int prevIndex; // 0x0
	private int count; // 0x0
	[CompilerGenerated]
	private int <TableCapacity>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <System.Collections.Generic.ICollection<T>.IsReadOnly>k__BackingField; // 0x0

	// Properties
	private LinkedArray.Node<T> FirstNode { get; }
	private LinkedArray.Node<T> LastNode { get; }
	public int TableCapacity { get; set; }
	public T Item { get; set; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private LinkedArray.Node<T> get_FirstNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B14D20 Offset: 0x4B10D20 VA: 0x4B14D20
	|-LinkedArray<__Il2CppFullySharedGenericType>.get_FirstNode
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private LinkedArray.Node<T> get_LastNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B14D28 Offset: 0x4B10D28 VA: 0x4B14D28
	|-LinkedArray<__Il2CppFullySharedGenericType>.get_LastNode
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_TableCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B14D30 Offset: 0x4B10D30 VA: 0x4B14D30
	|-LinkedArray<__Il2CppFullySharedGenericType>.get_TableCapacity
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_TableCapacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B14D38 Offset: 0x4B10D38 VA: 0x4B14D38
	|-LinkedArray<__Il2CppFullySharedGenericType>.set_TableCapacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B14D40 Offset: 0x4B10D40 VA: 0x4B14D40
	|-LinkedArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(List<T> original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B14EE8 Offset: 0x4B10EE8 VA: 0x4B14EE8
	|-LinkedArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B14F78 Offset: 0x4B10F78 VA: 0x4B14F78
	|-LinkedArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B14FF0 Offset: 0x4B10FF0 VA: 0x4B14FF0
	|-LinkedArray<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B150B0 Offset: 0x4B110B0 VA: 0x4B150B0
	|-LinkedArray<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void SortedAdd(T item, Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B15184 Offset: 0x4B11184 VA: 0x4B15184
	|-LinkedArray<__Il2CppFullySharedGenericType>.SortedAdd
	*/

	// RVA: -1 Offset: -1
	public List<T> FindAll(Predicate<T> matche) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B158BC Offset: 0x4B118BC VA: 0x4B158BC
	|-LinkedArray<__Il2CppFullySharedGenericType>.FindAll
	*/

	// RVA: -1 Offset: -1
	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B15CD0 Offset: 0x4B11CD0 VA: 0x4B15CD0
	|-LinkedArray<__Il2CppFullySharedGenericType>.ForEach
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16040 Offset: 0x4B12040 VA: 0x4B16040
	|-LinkedArray<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1616C Offset: 0x4B1216C VA: 0x4B1616C
	|-LinkedArray<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	private LinkedArray.IndexInfo<T> GetIndexInfo(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B162C0 Offset: 0x4B122C0 VA: 0x4B162C0
	|-LinkedArray<__Il2CppFullySharedGenericType>.GetIndexInfo
	*/

	// RVA: -1 Offset: -1
	public void AddRange(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B164B8 Offset: 0x4B124B8 VA: 0x4B164B8
	|-LinkedArray<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1655C Offset: 0x4B1255C VA: 0x4B1655C
	|-LinkedArray<__Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16564 Offset: 0x4B12564 VA: 0x4B16564
	|-LinkedArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1656C Offset: 0x4B1256C VA: 0x4B1656C
	|-LinkedArray<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool LastOut(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16690 Offset: 0x4B12690 VA: 0x4B16690
	|-LinkedArray<__Il2CppFullySharedGenericType>.LastOut
	*/

	// RVA: -1 Offset: -1
	public bool FirstOut(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16874 Offset: 0x4B12874 VA: 0x4B16874
	|-LinkedArray<__Il2CppFullySharedGenericType>.FirstOut
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16A6C Offset: 0x4B12A6C VA: 0x4B16A6C
	|-LinkedArray<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16B24 Offset: 0x4B12B24 VA: 0x4B16B24
	|-LinkedArray<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16BF0 Offset: 0x4B12BF0 VA: 0x4B16BF0
	|-LinkedArray<__Il2CppFullySharedGenericType>.CopyTo
	*/

	[IteratorStateMachine(typeof(LinkedArray.<GetEnumerator>d__37<T>))]
	// RVA: -1 Offset: -1
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16C44 Offset: 0x4B12C44 VA: 0x4B16C44
	|-LinkedArray<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private List<T> BuildTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16CD0 Offset: 0x4B12CD0 VA: 0x4B16CD0
	|-LinkedArray<__Il2CppFullySharedGenericType>.BuildTable
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B16DD8 Offset: 0x4B12DD8 VA: 0x4B16DD8
	|-LinkedArray<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1704C Offset: 0x4B1304C VA: 0x4B1704C
	|-LinkedArray<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void InsertRange(int index, T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B171F8 Offset: 0x4B131F8 VA: 0x4B171F8
	|-LinkedArray<__Il2CppFullySharedGenericType>.InsertRange
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1730C Offset: 0x4B1330C VA: 0x4B1730C
	|-LinkedArray<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17480 Offset: 0x4B13480 VA: 0x4B17480
	|-LinkedArray<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17580 Offset: 0x4B13580 VA: 0x4B17580
	|-LinkedArray<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17594 Offset: 0x4B13594 VA: 0x4B17594
	|-LinkedArray<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public List<T> ToList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B175D0 Offset: 0x4B135D0 VA: 0x4B175D0
	|-LinkedArray<__Il2CppFullySharedGenericType>.ToList
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B175E4 Offset: 0x4B135E4 VA: 0x4B175E4
	|-LinkedArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B176A0 Offset: 0x4B136A0 VA: 0x4B176A0
	|-LinkedArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<T>.Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B176B4 Offset: 0x4B136B4 VA: 0x4B176B4
	|-LinkedArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17780 Offset: 0x4B13780 VA: 0x4B17780
	|-LinkedArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17794 Offset: 0x4B13794 VA: 0x4B17794
	|-LinkedArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17860 Offset: 0x4B13860 VA: 0x4B17860
	|-LinkedArray<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}

// Namespace: Custom.Collections
[NullableContext(1)]
[Nullable(0)]
internal sealed class PriorityQueueDebugView<TElement, TPriority> // TypeDefIndex: 24308
{
	// Fields
	private readonly PriorityQueue<TElement, TPriority> _queue; // 0x0
	private readonly bool _sort; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	[Nullable(new[] { 1, 0, 1, 1 })]
	[TupleElementNames(new[] { "Element", "Priority" })]
	public ValueTuple<TElement, TPriority>[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public ValueTuple<TElement, TPriority>[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528DE88 Offset: 0x5289E88 VA: 0x528DE88
	|-PriorityQueueDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1
	public void .ctor(PriorityQueue<TElement, TPriority> queue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528DF94 Offset: 0x5289F94 VA: 0x528DF94
	|-PriorityQueueDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(PriorityQueue.UnorderedItemsCollection<TElement, TPriority> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528DFDC Offset: 0x5289FDC VA: 0x528DFDC
	|-PriorityQueueDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private int <get_Items>b__3_0(ValueTuple<TElement, TPriority> i1, ValueTuple<TElement, TPriority> i2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E060 Offset: 0x528A060 VA: 0x528E060
	|-PriorityQueueDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<get_Items>b__3_0
	*/
}

// Namespace: Custom.Collections
[Nullable(0)]
[NullableContext(1)]
internal static class SR // TypeDefIndex: 24309
{
	// Fields
	internal const string ArgumentOutOfRange_NeedNonNegNum = "Non-negative number required.";
	internal const string ArgumentOutOfRange_IndexMustBeLessOrEqual = "Index must be less or equal";
	internal const string InvalidOperation_EmptyQueue = "The queue is empty.";
	internal const string InvalidOperation_EnumFailedVersion = "Collection modified while iterating over it.";
	internal const string Arg_NonZeroLowerBound = "Non-zero lower bound required.";
	internal const string Arg_RankMultiDimNotSupported = "Multi-dimensional arrays not supported.";
	internal const string Argument_InvalidArrayType = "Invalid array type.";
	internal const string Argument_InvalidOffLen = "Invalid offset or length.";
}

// Namespace: Custom.Collections
internal static class ArgumentNullException // TypeDefIndex: 24310
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x4181D58 Offset: 0x417DD58 VA: 0x4181D58
	public static void ThrowIfNull(object o) { }
}

// Namespace: Custom.Collections
internal static class ArrayEx // TypeDefIndex: 24311
{
	// Fields
	internal const int MaxLength = 2147483647;
}

// Namespace: Custom.Collections
internal static class EnumerableHelpers // TypeDefIndex: 24312
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	internal static T[] ToArray<T>(IEnumerable<T> source, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45DEB2C Offset: 0x45DAB2C VA: 0x45DEB2C
	|-EnumerableHelpers.ToArray<ValueTuple<int, int>>
	|
	|-RVA: 0x45DF188 Offset: 0x45DB188 VA: 0x45DF188
	|-EnumerableHelpers.ToArray<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[Nullable(0)]
public struct PriorityQueue.UnorderedItemsCollection.Enumerator<TElement, TPriority> : IEnumerator<ValueTuple<TElement, TPriority>>, IEnumerator, IDisposable // TypeDefIndex: 24313
{
	// Fields
	private readonly PriorityQueue<TElement, TPriority> _queue; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	[TupleElementNames(new[] { "Element", "Priority" })]
	[Nullable(new[] { 0, 1, 1 })]
	[CompilerGenerated]
	private ValueTuple<TElement, TPriority> <Current>k__BackingField; // 0x0

	// Properties
	[Nullable(new[] { 0, 1, 1 })]
	[TupleElementNames(new[] { "Element", "Priority" })]
	public ValueTuple<TElement, TPriority> Current { get; set; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(PriorityQueue<TElement, TPriority> queue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6150730 Offset: 0x614C730 VA: 0x6150730
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x61963F8 Offset: 0x61923F8 VA: 0x61963F8
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6150780 Offset: 0x614C780 VA: 0x6150780
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x61965E4 Offset: 0x61925E4 VA: 0x61965E4
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6150784 Offset: 0x614C784 VA: 0x6150784
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x61965E8 Offset: 0x61925E8 VA: 0x61965E8
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private bool MoveNextRare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6150838 Offset: 0x614C838 VA: 0x6150838
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<int, int>.MoveNextRare
	|
	|-RVA: 0x61968D0 Offset: 0x61928D0 VA: 0x61968D0
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNextRare
	*/

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: -1 Offset: -1 Slot: 4
	public ValueTuple<TElement, TPriority> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61508D0 Offset: 0x614C8D0 VA: 0x61508D0
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x6196B2C Offset: 0x6192B2C VA: 0x6196B2C
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Current(ValueTuple<TElement, TPriority> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61508D8 Offset: 0x614C8D8 VA: 0x61508D8
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<int, int>.set_Current
	|
	|-RVA: 0x6196C1C Offset: 0x6192C1C VA: 0x6196C1C
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x61508E0 Offset: 0x614C8E0 VA: 0x61508E0
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x6196CFC Offset: 0x6192CFC VA: 0x6196CFC
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6150948 Offset: 0x614C948 VA: 0x6150948
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x6196E20 Offset: 0x6192E20 VA: 0x6196E20
	|-PriorityQueue.UnorderedItemsCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[DebuggerDisplay("Count = {Count}")]
[Nullable(0)]
[DebuggerTypeProxy(typeof(PriorityQueueDebugView<TElement, TPriority>))]
public sealed class PriorityQueue.UnorderedItemsCollection<TElement, TPriority> : IReadOnlyCollection<ValueTuple<TElement, TPriority>>, IEnumerable<ValueTuple<TElement, TPriority>>, IEnumerable, ICollection // TypeDefIndex: 24314
{
	// Fields
	internal readonly PriorityQueue<TElement, TPriority> _queue; // 0x0

	// Properties
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(PriorityQueue<TElement, TPriority> queue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE000 Offset: 0x56BA000 VA: 0x56BE000
	|-PriorityQueue.UnorderedItemsCollection<int, int>..ctor
	|
	|-RVA: 0x56BE3B4 Offset: 0x56BA3B4 VA: 0x56BE3B4
	|-PriorityQueue.UnorderedItemsCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public PriorityQueue.UnorderedItemsCollection.Enumerator<TElement, TPriority> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE030 Offset: 0x56BA030 VA: 0x56BE030
	|-PriorityQueue.UnorderedItemsCollection<int, int>.GetEnumerator
	|
	|-RVA: 0x56BE3E4 Offset: 0x56BA3E4 VA: 0x56BE3E4
	|-PriorityQueue.UnorderedItemsCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE054 Offset: 0x56BA054 VA: 0x56BE054
	|-PriorityQueue.UnorderedItemsCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x56BE494 Offset: 0x56BA494 VA: 0x56BE494
	|-PriorityQueue.UnorderedItemsCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE058 Offset: 0x56BA058 VA: 0x56BE058
	|-PriorityQueue.UnorderedItemsCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x56BE498 Offset: 0x56BA498 VA: 0x56BE498
	|-PriorityQueue.UnorderedItemsCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE060 Offset: 0x56BA060 VA: 0x56BE060
	|-PriorityQueue.UnorderedItemsCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x56BE4A0 Offset: 0x56BA4A0 VA: 0x56BE4A0
	|-PriorityQueue.UnorderedItemsCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE2B8 Offset: 0x56BA2B8 VA: 0x56BE2B8
	|-PriorityQueue.UnorderedItemsCollection<int, int>.get_Count
	|
	|-RVA: 0x56BE6F8 Offset: 0x56BA6F8 VA: 0x56BE6F8
	|-PriorityQueue.UnorderedItemsCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<ValueTuple<TElement, TPriority>> System.Collections.Generic.IEnumerable<(TElementElement,TPriorityPriority)>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE2D4 Offset: 0x56BA2D4 VA: 0x56BE2D4
	|-PriorityQueue.UnorderedItemsCollection<int, int>.System.Collections.Generic.IEnumerable<(TElementElement,TPriorityPriority)>.GetEnumerator
	|
	|-RVA: 0x56BE714 Offset: 0x56BA714 VA: 0x56BE714
	|-PriorityQueue.UnorderedItemsCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<(TElementElement,TPriorityPriority)>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BE344 Offset: 0x56BA344 VA: 0x56BE344
	|-PriorityQueue.UnorderedItemsCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x56BE7B8 Offset: 0x56BA7B8 VA: 0x56BE7B8
	|-PriorityQueue.UnorderedItemsCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Custom.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(PriorityQueueDebugView<TElement, TPriority>))]
[Nullable(0)]
[NullableContext(1)]
public class PriorityQueue<TElement, TPriority> // TypeDefIndex: 24315
{
	// Fields
	private const int Arity = 4;
	private const int Log2Arity = 2;
	[Nullable(new[] { 1, 0, 1, 1 })]
	[TupleElementNames(new[] { "Element", "Priority" })]
	private ValueTuple<TElement, TPriority>[] _nodes; // 0x0
	[Nullable(new[] { 2, 1 })]
	private readonly IComparer<TPriority> _comparer; // 0x0
	[Nullable(new[] { 2, 0, 0 })]
	private PriorityQueue.UnorderedItemsCollection<TElement, TPriority> _unorderedItems; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0

	// Properties
	public int Count { get; }
	public IComparer<TPriority> Comparer { get; }
	[Nullable(new[] { 1, 0, 0 })]
	public PriorityQueue.UnorderedItemsCollection<TElement, TPriority> UnorderedItems { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E264 Offset: 0x528A264 VA: 0x528E264
	|-PriorityQueue<int, int>.get_Count
	|
	|-RVA: 0x5290528 Offset: 0x528C528 VA: 0x5290528
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public IComparer<TPriority> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E26C Offset: 0x528A26C VA: 0x528E26C
	|-PriorityQueue<int, int>.get_Comparer
	|
	|-RVA: 0x5290530 Offset: 0x528C530 VA: 0x5290530
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1
	public PriorityQueue.UnorderedItemsCollection<TElement, TPriority> get_UnorderedItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E288 Offset: 0x528A288 VA: 0x528E288
	|-PriorityQueue<int, int>.get_UnorderedItems
	|
	|-RVA: 0x5290550 Offset: 0x528C550 VA: 0x5290550
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_UnorderedItems
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E300 Offset: 0x528A300 VA: 0x528E300
	|-PriorityQueue<int, int>..ctor
	|
	|-RVA: 0x52905CC Offset: 0x528C5CC VA: 0x52905CC
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E3A8 Offset: 0x528A3A8 VA: 0x528E3A8
	|-PriorityQueue<int, int>..ctor
	|
	|-RVA: 0x5290638 Offset: 0x528C638 VA: 0x5290638
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TPriority> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E3BC Offset: 0x528A3BC VA: 0x528E3BC
	|-PriorityQueue<int, int>..ctor
	|
	|-RVA: 0x5290650 Offset: 0x528C650 VA: 0x5290650
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialCapacity, IComparer<TPriority> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E470 Offset: 0x528A470 VA: 0x528E470
	|-PriorityQueue<int, int>..ctor
	|
	|-RVA: 0x52906C0 Offset: 0x528C6C0 VA: 0x52906C0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<ValueTuple<TElement, TPriority>> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E568 Offset: 0x528A568 VA: 0x528E568
	|-PriorityQueue<int, int>..ctor
	|
	|-RVA: 0x52907BC Offset: 0x528C7BC VA: 0x52907BC
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<ValueTuple<TElement, TPriority>> items, IComparer<TPriority> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E57C Offset: 0x528A57C VA: 0x528E57C
	|-PriorityQueue<int, int>..ctor
	|
	|-RVA: 0x52907D4 Offset: 0x528C7D4 VA: 0x52907D4
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(TElement element, TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E634 Offset: 0x528A634 VA: 0x528E634
	|-PriorityQueue<int, int>.Enqueue
	|
	|-RVA: 0x5290898 Offset: 0x528C898 VA: 0x5290898
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public TElement Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E730 Offset: 0x528A730 VA: 0x528E730
	|-PriorityQueue<int, int>.Peek
	|
	|-RVA: 0x5290B5C Offset: 0x528CB5C VA: 0x5290B5C
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public TElement Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E7A8 Offset: 0x528A7A8 VA: 0x528E7A8
	|-PriorityQueue<int, int>.Dequeue
	|
	|-RVA: 0x5290C5C Offset: 0x528CC5C VA: 0x5290C5C
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out TElement element, out TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E834 Offset: 0x528A834 VA: 0x528E834
	|-PriorityQueue<int, int>.TryDequeue
	|
	|-RVA: 0x5290D80 Offset: 0x528CD80 VA: 0x5290D80
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	public bool TryPeek(out TElement element, out TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E894 Offset: 0x528A894 VA: 0x528E894
	|-PriorityQueue<int, int>.TryPeek
	|
	|-RVA: 0x5291008 Offset: 0x528D008 VA: 0x5291008
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryPeek
	*/

	// RVA: -1 Offset: -1
	public TElement EnqueueDequeue(TElement element, TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528E8E4 Offset: 0x528A8E4 VA: 0x528E8E4
	|-PriorityQueue<int, int>.EnqueueDequeue
	|
	|-RVA: 0x5291280 Offset: 0x528D280 VA: 0x5291280
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EnqueueDequeue
	*/

	// RVA: -1 Offset: -1
	public void EnqueueRange(IEnumerable<ValueTuple<TElement, TPriority>> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528EA94 Offset: 0x528AA94 VA: 0x528EA94
	|-PriorityQueue<int, int>.EnqueueRange
	|
	|-RVA: 0x5291850 Offset: 0x528D850 VA: 0x5291850
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EnqueueRange
	*/

	// RVA: -1 Offset: -1
	public void EnqueueRange(IEnumerable<TElement> elements, TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528F298 Offset: 0x528B298 VA: 0x528F298
	|-PriorityQueue<int, int>.EnqueueRange
	|
	|-RVA: 0x5292450 Offset: 0x528E450 VA: 0x5292450
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EnqueueRange
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FA00 Offset: 0x528BA00 VA: 0x528FA00
	|-PriorityQueue<int, int>.Clear
	|
	|-RVA: 0x5292EAC Offset: 0x528EEAC VA: 0x5292EAC
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public int EnsureCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FA30 Offset: 0x528BA30 VA: 0x528FA30
	|-PriorityQueue<int, int>.EnsureCapacity
	|
	|-RVA: 0x5292EDC Offset: 0x528EEDC VA: 0x5292EDC
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FB0C Offset: 0x528BB0C VA: 0x528FB0C
	|-PriorityQueue<int, int>.TrimExcess
	|
	|-RVA: 0x5292FBC Offset: 0x528EFBC VA: 0x5292FBC
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private void Grow(int minCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FB80 Offset: 0x528BB80 VA: 0x528FB80
	|-PriorityQueue<int, int>.Grow
	|
	|-RVA: 0x5293034 Offset: 0x528F034 VA: 0x5293034
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Grow
	*/

	// RVA: -1 Offset: -1
	private void RemoveRootNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FC28 Offset: 0x528BC28 VA: 0x528FC28
	|-PriorityQueue<int, int>.RemoveRootNode
	|
	|-RVA: 0x52930E0 Offset: 0x528F0E0 VA: 0x52930E0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveRootNode
	*/

	// RVA: -1 Offset: -1
	private static int GetParentIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FCD4 Offset: 0x528BCD4 VA: 0x528FCD4
	|-PriorityQueue<int, int>.GetParentIndex
	|
	|-RVA: 0x5293270 Offset: 0x528F270 VA: 0x5293270
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParentIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetFirstChildIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FCE0 Offset: 0x528BCE0 VA: 0x528FCE0
	|-PriorityQueue<int, int>.GetFirstChildIndex
	|
	|-RVA: 0x529327C Offset: 0x528F27C VA: 0x529327C
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetFirstChildIndex
	*/

	// RVA: -1 Offset: -1
	private void Heapify() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FCF0 Offset: 0x528BCF0 VA: 0x528FCF0
	|-PriorityQueue<int, int>.Heapify
	|
	|-RVA: 0x529328C Offset: 0x528F28C VA: 0x529328C
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Heapify
	*/

	// RVA: -1 Offset: -1
	private void MoveUpDefaultComparer(ValueTuple<TElement, TPriority> node, int nodeIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FDC4 Offset: 0x528BDC4 VA: 0x528FDC4
	|-PriorityQueue<int, int>.MoveUpDefaultComparer
	|
	|-RVA: 0x5293424 Offset: 0x528F424 VA: 0x5293424
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveUpDefaultComparer
	*/

	// RVA: -1 Offset: -1
	private void MoveUpCustomComparer(ValueTuple<TElement, TPriority> node, int nodeIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FE9C Offset: 0x528BE9C VA: 0x528FE9C
	|-PriorityQueue<int, int>.MoveUpCustomComparer
	|
	|-RVA: 0x5293820 Offset: 0x528F820 VA: 0x5293820
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveUpCustomComparer
	*/

	// RVA: -1 Offset: -1
	private void MoveDownDefaultComparer(ValueTuple<TElement, TPriority> node, int nodeIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528FFD4 Offset: 0x528BFD4 VA: 0x528FFD4
	|-PriorityQueue<int, int>.MoveDownDefaultComparer
	|
	|-RVA: 0x5293C30 Offset: 0x528FC30 VA: 0x5293C30
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveDownDefaultComparer
	*/

	// RVA: -1 Offset: -1
	private void MoveDownCustomComparer(ValueTuple<TElement, TPriority> node, int nodeIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52901C0 Offset: 0x528C1C0 VA: 0x52901C0
	|-PriorityQueue<int, int>.MoveDownCustomComparer
	|
	|-RVA: 0x52941F0 Offset: 0x52901F0 VA: 0x52941F0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveDownCustomComparer
	*/

	// RVA: -1 Offset: -1
	private static IComparer<TPriority> InitializeComparer(IComparer<TPriority> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5290444 Offset: 0x528C444 VA: 0x5290444
	|-PriorityQueue<int, int>.InitializeComparer
	|
	|-RVA: 0x5294814 Offset: 0x5290814 VA: 0x5294814
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InitializeComparer
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class WeakValueDictionary.<GetEnumerator>d__29<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable // TypeDefIndex: 24316
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	public WeakValueDictionary<TKey, TValue> <>4__this; // 0x0
	private int <nullCount>5__2; // 0x0
	private Dictionary.Enumerator<TKey, WeakReference<TValue>> <>7__wrap2; // 0x0

	// Properties
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2BBD4 Offset: 0x5D27BD4 VA: 0x5D2BBD4
	|-WeakValueDictionary.<GetEnumerator>d__29<__Il2CppFullySharedGenericType, object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2BC14 Offset: 0x5D27C14 VA: 0x5D2BC14
	|-WeakValueDictionary.<GetEnumerator>d__29<__Il2CppFullySharedGenericType, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2BC74 Offset: 0x5D27C74 VA: 0x5D2BC74
	|-WeakValueDictionary.<GetEnumerator>d__29<__Il2CppFullySharedGenericType, object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2C214 Offset: 0x5D28214 VA: 0x5D2C214
	|-WeakValueDictionary.<GetEnumerator>d__29<__Il2CppFullySharedGenericType, object>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2C320 Offset: 0x5D28320 VA: 0x5D2C320
	|-WeakValueDictionary.<GetEnumerator>d__29<__Il2CppFullySharedGenericType, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2C3C0 Offset: 0x5D283C0 VA: 0x5D2C3C0
	|-WeakValueDictionary.<GetEnumerator>d__29<__Il2CppFullySharedGenericType, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2C3F4 Offset: 0x5D283F4 VA: 0x5D2C3F4
	|-WeakValueDictionary.<GetEnumerator>d__29<__Il2CppFullySharedGenericType, object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Custom.Collections
[DefaultMember("Item")]
public class WeakValueDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 24317
{
	// Fields
	private readonly Dictionary<TKey, WeakReference<TValue>> _dict; // 0x0
	private int _version; // 0x0
	private int _cleanVersion; // 0x0
	private int _cleanGeneration; // 0x0
	private const int MinRehashInterval = 500;

	// Properties
	public ICollection<TKey> Keys { get; }
	public ICollection<TValue> Values { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C6D44 Offset: 0x58C2D44 VA: 0x58C6D44
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C6DB8 Offset: 0x58C2DB8 VA: 0x58C6DB8
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C6DE0 Offset: 0x58C2DE0 VA: 0x58C6DE0
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C6E14 Offset: 0x58C2E14 VA: 0x58C6E14
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C6F40 Offset: 0x58C2F40 VA: 0x58C6F40
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7168 Offset: 0x58C3168 VA: 0x58C7168
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C72FC Offset: 0x58C32FC VA: 0x58C72FC
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C744C Offset: 0x58C344C VA: 0x58C744C
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7538 Offset: 0x58C3538 VA: 0x58C7538
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.set_Item
	*/

	// RVA: -1 Offset: -1
	private void AutoCleanup(int incVersion) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7644 Offset: 0x58C3644 VA: 0x58C7644
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.AutoCleanup
	*/

	// RVA: -1 Offset: -1
	private void Cleanup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C772C Offset: 0x58C372C VA: 0x58C772C
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.Cleanup
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7D48 Offset: 0x58C3D48 VA: 0x58C7D48
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7E44 Offset: 0x58C3E44 VA: 0x58C7E44
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7E7C Offset: 0x58C3E7C VA: 0x58C7E7C
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7EC4 Offset: 0x58C3EC4 VA: 0x58C7EC4
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7F0C Offset: 0x58C3F0C VA: 0x58C7F0C
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7F34 Offset: 0x58C3F34 VA: 0x58C7F34
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7F3C Offset: 0x58C3F3C VA: 0x58C7F3C
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7F84 Offset: 0x58C3F84 VA: 0x58C7F84
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	[IteratorStateMachine(typeof(WeakValueDictionary.<GetEnumerator>d__29<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C7F98 Offset: 0x58C3F98 VA: 0x58C7F98
	|-WeakValueDictionary<__Il2CppFullySharedGenericType, object>.GetEnumerator
	*/
}

// Namespace: Custom.Collections
public class WeakReference<T> : WeakReference // TypeDefIndex: 24318
{
	// Properties
	public T Target { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C6350 Offset: 0x58C2350 VA: 0x58C6350
	|-WeakReference<object>..ctor
	|
	|-RVA: 0x58C63F0 Offset: 0x58C23F0 VA: 0x58C63F0
	|-WeakReference<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T target, bool trackResurrection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C6358 Offset: 0x58C2358 VA: 0x58C6358
	|-WeakReference<object>..ctor
	|
	|-RVA: 0x58C649C Offset: 0x58C249C VA: 0x58C649C
	|-WeakReference<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C6364 Offset: 0x58C2364 VA: 0x58C6364
	|-WeakReference<object>..ctor
	|
	|-RVA: 0x58C6558 Offset: 0x58C2558 VA: 0x58C6558
	|-WeakReference<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Target() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C636C Offset: 0x58C236C VA: 0x58C636C
	|-WeakReference<object>.get_Target
	|
	|-RVA: 0x58C6560 Offset: 0x58C2560 VA: 0x58C6560
	|-WeakReference<__Il2CppFullySharedGenericType>.get_Target
	*/

	// RVA: -1 Offset: -1
	public void set_Target(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C63DC Offset: 0x58C23DC VA: 0x58C63DC
	|-WeakReference<object>.set_Target
	|
	|-RVA: 0x58C662C Offset: 0x58C262C VA: 0x58C662C
	|-WeakReference<__Il2CppFullySharedGenericType>.set_Target
	*/
}

// Namespace: FrameworkLockStep.Runtime
public interface IBinarySerialize // TypeDefIndex: 24319
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Serialize(BinaryWriter writer);
}

// Namespace: FrameworkLockStep.Runtime
public interface IBinaryDeSerialize // TypeDefIndex: 24320
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DeSerialize(BinaryReader reader);
}

// Namespace: FrameworkLockStep.Runtime
[Extension]
public static class BinarySerializeUtils // TypeDefIndex: 24321
{
	// Methods

	[Extension]
	// RVA: 0x4181D98 Offset: 0x417DD98 VA: 0x4181D98
	public static void WriteUTF8String(BinaryWriter writer, string value) { }

	[Extension]
	// RVA: 0x4181E18 Offset: 0x417DE18 VA: 0x4181E18
	public static string ReadUTF8String(BinaryReader reader) { }

	[Extension]
	// RVA: 0x4181E78 Offset: 0x417DE78 VA: 0x4181E78
	public static void Write(BinaryWriter writer, FP value) { }

	[Extension]
	// RVA: 0x4181E98 Offset: 0x417DE98 VA: 0x4181E98
	public static FP ReadFP(BinaryReader reader) { }

	[Extension]
	// RVA: 0x4181EB8 Offset: 0x417DEB8 VA: 0x4181EB8
	public static void Write(BinaryWriter writer, FPVector2 value) { }

	[Extension]
	// RVA: 0x4181F00 Offset: 0x417DF00 VA: 0x4181F00
	public static FPVector2 ReadFPVector2(BinaryReader reader) { }

	[Extension]
	// RVA: 0x4181F50 Offset: 0x417DF50 VA: 0x4181F50
	public static void Write(BinaryWriter writer, FPVector3 value) { }

	[Extension]
	// RVA: 0x4181FB4 Offset: 0x417DFB4 VA: 0x4181FB4
	public static FPVector3 ReadFPVector3(BinaryReader reader) { }
}

// Namespace: FrameworkLockStep.Runtime
[Extension]
public static class FPAnimationUtils // TypeDefIndex: 24322
{
	// Fields
	private const string FpCurveDir = "Assets/_Resources/Bake/AnimationCurve/";
	public const string FpCurveCatalogPath = "Assets/_Resources/Bake/AnimationCurve/catalog.json";
	private const string FpCurvePath = "Assets/_Resources/Bake/AnimationCurve/{0}.bytes";

	// Methods

	// RVA: 0x4182028 Offset: 0x417E028 VA: 0x4182028
	public static string GetFpAnimationPath(int id) { }

	[Extension]
	// RVA: 0x41820A8 Offset: 0x417E0A8 VA: 0x41820A8
	public static void Serialize(ref FPAnimationCurve curve, BinaryWriter writer) { }

	[Extension]
	// RVA: 0x4182300 Offset: 0x417E300 VA: 0x4182300
	public static void DeSerialize(ref FPAnimationCurve curve, BinaryReader reader) { }
}

// Namespace: FrameworkLockStep.Runtime
public class FpCurveCatalog // TypeDefIndex: 24323
{
	// Fields
	[CompilerGenerated]
	private string[] <PathList>k__BackingField; // 0x10

	// Properties
	public string[] PathList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41825F4 Offset: 0x417E5F4 VA: 0x41825F4
	public string[] get_PathList() { }

	[CompilerGenerated]
	// RVA: 0x41825FC Offset: 0x417E5FC VA: 0x41825FC
	public void set_PathList(string[] value) { }

	// RVA: 0x4182604 Offset: 0x417E604 VA: 0x4182604
	public void .ctor() { }
}

// Namespace: FrameworkLockStep.Runtime
[Extension]
public static class FPExtendsion // TypeDefIndex: 24324
{
	// Methods

	[Extension]
	// RVA: 0x418260C Offset: 0x417E60C VA: 0x418260C
	public static FP ToFp(int value, int d) { }

	[Extension]
	// RVA: 0x4182628 Offset: 0x417E628 VA: 0x4182628
	public static FP Mul(FP x, FP y) { }

	[Extension]
	// RVA: 0x418264C Offset: 0x417E64C VA: 0x418264C
	public static FP Div(FP x, FP y) { }

	// RVA: 0x4182758 Offset: 0x417E758 VA: 0x4182758
	private static int CountLeadingZeroes(ulong x) { }
}

// Namespace: FrameworkLockStep.Runtime
public interface ISimulatorPlatform // TypeDefIndex: 24325
{
	// Properties
	public abstract MemoryLayoutVerifier.IPlatform Platform { get; }
	public abstract Native.Utility PlatformUtility { get; }
	public abstract Action<Draw.DebugRay> DebugDrawRay { get; }
	public abstract Action<Draw.DebugLine> DebugDrawLine { get; }
	public abstract Action<Draw.DebugCircle> DebugDrawCircle { get; }
	public abstract Action<Draw.DebugSphere> DebugDrawSphere { get; }
	public abstract Action<Draw.DebugRectangle> DebugDrawRectangle { get; }
	public abstract Action<Draw.DebugBox> DebugDrawBox { get; }
	public abstract Action DebugDrawClear { get; }
	public abstract Action<string> LogInfo { get; }
	public abstract Action<string> LogWarn { get; }
	public abstract Action<string> LogError { get; }
	public abstract Action<Exception> LogException { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MemoryLayoutVerifier.IPlatform get_Platform();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Native.Utility get_PlatformUtility();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ProfilerBeginSample(string name);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ProfilerEndSample();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ProfilerBeginThreadProfiling(string threadGroupName, string threadName);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ProfilerEndThreadProfiling();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Action<Draw.DebugRay> get_DebugDrawRay();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Action<Draw.DebugLine> get_DebugDrawLine();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Action<Draw.DebugCircle> get_DebugDrawCircle();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Action<Draw.DebugSphere> get_DebugDrawSphere();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Action<Draw.DebugRectangle> get_DebugDrawRectangle();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Action<Draw.DebugBox> get_DebugDrawBox();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Action get_DebugDrawClear();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Action<string> get_LogInfo();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Action<string> get_LogWarn();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Action<string> get_LogError();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Action<Exception> get_LogException();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void LoadLookupTables();
}

// Namespace: 
public struct LockStepSimulator.StartParameters // TypeDefIndex: 24326
{
	// Fields
	public RuntimeConfig runtimeConfig; // 0x0
	public DeterministicSessionConfig deterministicConfig; // 0x8
	public string simulatorId; // 0x10
	public IResourceManager resourceManager; // 0x18
	public int heapExtraCount; // 0x20
	public DynamicAssetDB initialDynamicAssets; // 0x28
	public IQuantumBridge quantumBridge; // 0x30
	public IAssetSerializer assetSerializer; // 0x38
	public DeterministicPlatformInfo platformInfo; // 0x40
}

// Namespace: FrameworkLockStep.Runtime
public abstract class LockStepSimulator // TypeDefIndex: 24327
{
	// Fields
	[CompilerGenerated]
	private LockStepSimulator.StartParameters <Parameters>k__BackingField; // 0x10
	[CompilerGenerated]
	private QuantumGame <Game>k__BackingField; // 0x58
	[CompilerGenerated]
	private DeterministicSession <Session>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x68

	// Properties
	public LockStepSimulator.StartParameters Parameters { get; set; }
	public QuantumGame Game { get; set; }
	public DeterministicSession Session { get; set; }
	public string Id { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41827A0 Offset: 0x417E7A0 VA: 0x41827A0
	public LockStepSimulator.StartParameters get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x41827B0 Offset: 0x417E7B0 VA: 0x41827B0
	private void set_Parameters(LockStepSimulator.StartParameters value) { }

	[CompilerGenerated]
	// RVA: 0x41827D4 Offset: 0x417E7D4 VA: 0x41827D4
	public QuantumGame get_Game() { }

	[CompilerGenerated]
	// RVA: 0x41827DC Offset: 0x417E7DC VA: 0x41827DC
	private void set_Game(QuantumGame value) { }

	[CompilerGenerated]
	// RVA: 0x41827E4 Offset: 0x417E7E4 VA: 0x41827E4
	public DeterministicSession get_Session() { }

	[CompilerGenerated]
	// RVA: 0x41827EC Offset: 0x417E7EC VA: 0x41827EC
	private void set_Session(DeterministicSession value) { }

	[CompilerGenerated]
	// RVA: 0x41827F4 Offset: 0x417E7F4 VA: 0x41827F4
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x41827FC Offset: 0x417E7FC VA: 0x41827FC
	private void set_Id(string value) { }

	// RVA: 0x4182804 Offset: 0x417E804 VA: 0x4182804
	public void Start(LockStepSimulator.StartParameters parameters) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnStart();

	// RVA: 0x4182AC0 Offset: 0x417EAC0 VA: 0x4182AC0
	public void Destroy() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnDestroy();

	// RVA: 0x4182B38 Offset: 0x417EB38 VA: 0x4182B38
	public void Update() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnUpdate();

	// RVA: 0x4182B68 Offset: 0x417EB68 VA: 0x4182B68
	public static void InitPlatform(ISimulatorPlatform simulatorPlatform) { }

	// RVA: 0x418331C Offset: 0x417F31C VA: 0x418331C
	protected void .ctor() { }
}

// Namespace: FrameworkLockStep.Runtime
public static class StringBuilderCache // TypeDefIndex: 24328
{
	// Fields
	internal const int MaxBuilderSize = 360;
	private const int DefaultCapacity = 16;
	[ThreadStatic]
	private static StringBuilder _tCachedInstance; // 0x80000000

	// Methods

	// RVA: 0x4183324 Offset: 0x417F324 VA: 0x4183324
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x41833EC Offset: 0x417F3EC VA: 0x41833EC
	public static void Release(StringBuilder sb) { }

	// RVA: 0x418346C Offset: 0x417F46C VA: 0x418346C
	public static string GetStringAndRelease(StringBuilder sb) { }
}

// Namespace: Deterministic.Animation
public class AnimatorNormalState : AnimatorStateBase // TypeDefIndex: 24329
{
	// Properties
	public override DeterministicAnimationState CurPlayState { get; }
	public override DeterministicAnimatorState StateType { get; }

	// Methods

	// RVA: 0x41834A8 Offset: 0x417F4A8 VA: 0x41834A8
	public void .ctor(DeterministicAnimator context) { }

	// RVA: 0x4183548 Offset: 0x417F548 VA: 0x4183548 Slot: 4
	public override DeterministicAnimationState get_CurPlayState() { }

	// RVA: 0x4183550 Offset: 0x417F550 VA: 0x4183550 Slot: 5
	public override DeterministicAnimatorState get_StateType() { }

	// RVA: 0x4183558 Offset: 0x417F558 VA: 0x4183558 Slot: 6
	public override void OnEnter(object[] args) { }

	// RVA: 0x41836BC Offset: 0x417F6BC VA: 0x41836BC Slot: 7
	public override void OnUpdate(FP deltaTime) { }

	// RVA: 0x4183DDC Offset: 0x417FDDC VA: 0x4183DDC Slot: 8
	public override void OnExit() { }

	// RVA: 0x4183E2C Offset: 0x417FE2C VA: 0x4183E2C Slot: 9
	public override bool IsPlayAnimation(int aniStateStateHash) { }
}

// Namespace: Deterministic.Animation
public enum DeterministicAnimatorState // TypeDefIndex: 24330
{
	// Fields
	public int value__; // 0x0
	public const DeterministicAnimatorState Normal = 0;
	public const DeterministicAnimatorState Transition = 1;
}

// Namespace: Deterministic.Animation
public abstract class AnimatorStateBase // TypeDefIndex: 24331
{
	// Fields
	protected DeterministicAnimator _context; // 0x10
	protected DeterministicAnimationState _curState; // 0x18
	protected HashSet<string> _firedEvents; // 0x20
	protected FP _playTime; // 0x28

	// Properties
	public abstract DeterministicAnimationState CurPlayState { get; }
	public abstract DeterministicAnimatorState StateType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DeterministicAnimationState get_CurPlayState();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract DeterministicAnimatorState get_StateType();

	// RVA: 0x41834AC Offset: 0x417F4AC VA: 0x41834AC
	protected void .ctor(DeterministicAnimator context) { }

	// RVA: 0x4183928 Offset: 0x417F928 VA: 0x4183928
	protected void CheckEvents() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnEnter(object[] args);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnUpdate(FP deltaTime);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnExit();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool IsPlayAnimation(int aniStateStateHash);

	// RVA: 0x4183E50 Offset: 0x417FE50 VA: 0x4183E50
	private void printTmpLog(DeterministicAnimationEvent clipEvent) { }
}

// Namespace: Deterministic.Animation
public class AnimatorTransitionState : AnimatorStateBase // TypeDefIndex: 24332
{
	// Fields
	private FP _enterTime; // 0x30
	private DeterministicAnimationState _nextState; // 0x38
	private DeterministicAnimationTransition _transition; // 0x40

	// Properties
	public override DeterministicAnimationState CurPlayState { get; }
	public override DeterministicAnimatorState StateType { get; }

	// Methods

	// RVA: 0x4183E84 Offset: 0x417FE84 VA: 0x4183E84 Slot: 4
	public override DeterministicAnimationState get_CurPlayState() { }

	// RVA: 0x4183E8C Offset: 0x417FE8C VA: 0x4183E8C Slot: 5
	public override DeterministicAnimatorState get_StateType() { }

	// RVA: 0x4183E94 Offset: 0x417FE94 VA: 0x4183E94
	public void .ctor(DeterministicAnimator context) { }

	// RVA: 0x4183E98 Offset: 0x417FE98 VA: 0x4183E98 Slot: 6
	public override void OnEnter(object[] args) { }

	// RVA: 0x4184098 Offset: 0x4180098 VA: 0x4184098 Slot: 7
	public override void OnUpdate(FP deltaTime) { }

	// RVA: 0x418429C Offset: 0x418029C VA: 0x418429C Slot: 8
	public override void OnExit() { }

	// RVA: 0x41842F0 Offset: 0x41802F0 VA: 0x41842F0 Slot: 9
	public override bool IsPlayAnimation(int aniStateStateHash) { }
}

// Namespace: Deterministic.Animation
public static class AnimationEvent // TypeDefIndex: 24333
{
	// Fields
	public const string Start = "Start";
	public const string Hold = "Hold";
	public const string Fire = "Fire";
	public const string End = "End";
}

// Namespace: Deterministic.Animation
public class DeterministicAnimationEvent : IBinarySerialize, IBinaryDeSerialize // TypeDefIndex: 24334
{
	// Fields
	public FP normalizeTime; // 0x10
	public string eventName; // 0x18
	private FPVector3 _leftFirePos; // 0x20
	private FPVector3 _rightFirePos; // 0x38
	private List<FPVector3> _firePosList; // 0x50
	public FP scale; // 0x58

	// Properties
	public FPVector3 LeftFirePos { get; set; }
	public FPVector3 RightFirePos { get; set; }
	public List<FPVector3> FirePosList { get; set; }

	// Methods

	// RVA: 0x4184314 Offset: 0x4180314 VA: 0x4184314
	public void set_LeftFirePos(FPVector3 value) { }

	// RVA: 0x4184328 Offset: 0x4180328 VA: 0x4184328
	public FPVector3 get_LeftFirePos() { }

	// RVA: 0x4184358 Offset: 0x4180358 VA: 0x4184358
	public void set_RightFirePos(FPVector3 value) { }

	// RVA: 0x418436C Offset: 0x418036C VA: 0x418436C
	public FPVector3 get_RightFirePos() { }

	// RVA: 0x418439C Offset: 0x418039C VA: 0x418439C
	public void set_FirePosList(List<FPVector3> value) { }

	// RVA: 0x41843A4 Offset: 0x41803A4 VA: 0x41843A4
	public List<FPVector3> get_FirePosList() { }

	// RVA: 0x41843AC Offset: 0x41803AC VA: 0x41843AC Slot: 4
	public void Serialize(BinaryWriter writer) { }

	// RVA: 0x41845CC Offset: 0x41805CC VA: 0x41845CC Slot: 5
	public void DeSerialize(BinaryReader reader) { }

	// RVA: 0x41848DC Offset: 0x41808DC VA: 0x41848DC
	public void .ctor() { }
}

// Namespace: Deterministic.Animation
public class DeterministicAnimationClip : IBinarySerialize, IBinaryDeSerialize // TypeDefIndex: 24335
{
	// Fields
	public bool loop; // 0x10
	public FP length; // 0x18
	public DeterministicAnimationEvent[] events; // 0x20

	// Methods

	// RVA: 0x418496C Offset: 0x418096C VA: 0x418496C Slot: 4
	public void Serialize(BinaryWriter writer) { }

	// RVA: 0x4184A54 Offset: 0x4180A54 VA: 0x4184A54 Slot: 5
	public void DeSerialize(BinaryReader reader) { }

	// RVA: 0x4184BB8 Offset: 0x4180BB8 VA: 0x4184BB8
	public void .ctor() { }
}

// Namespace: Deterministic.Animation
public class DeterministicAnimationState : IBinarySerialize, IBinaryDeSerialize // TypeDefIndex: 24336
{
	// Fields
	public string stateName; // 0x10
	public int stateHash; // 0x18
	public FP speed; // 0x20
	public DeterministicAnimationClip clip; // 0x28
	public DeterministicAnimationTransition[] transitions; // 0x30
	public FP normalizeTime; // 0x38

	// Methods

	// RVA: 0x4184BC0 Offset: 0x4180BC0 VA: 0x4184BC0 Slot: 4
	public void Serialize(BinaryWriter writer) { }

	// RVA: 0x4184D98 Offset: 0x4180D98 VA: 0x4184D98 Slot: 5
	public void DeSerialize(BinaryReader reader) { }

	// RVA: 0x418502C Offset: 0x418102C VA: 0x418502C
	public void .ctor() { }
}

// Namespace: Deterministic.Animation
public class DeterministicAnimationTransition : IBinarySerialize, IBinaryDeSerialize // TypeDefIndex: 24337
{
	// Fields
	public bool hasExitTime; // 0x10
	public FP exitTime; // 0x18
	public FP duration; // 0x20
	public FP offset; // 0x28
	public int destStateHash; // 0x30

	// Methods

	// RVA: 0x4184D00 Offset: 0x4180D00 VA: 0x4184D00 Slot: 4
	public void Serialize(BinaryWriter writer) { }

	// RVA: 0x4184F90 Offset: 0x4180F90 VA: 0x4184F90 Slot: 5
	public void DeSerialize(BinaryReader reader) { }

	// RVA: 0x4184F88 Offset: 0x4180F88 VA: 0x4184F88
	public void .ctor() { }
}

// Namespace: Deterministic.Animation
[Extension]
public static class DeterministicAnimationUtils // TypeDefIndex: 24338
{
	// Fields
	public const string BakePath = "Assets/_Resources/Bake/Animation/";
	public static readonly Dictionary<string, int> PrefabPathHashDic; // 0x0

	// Methods

	[Extension]
	// RVA: 0x4183B6C Offset: 0x417FB6C VA: 0x4183B6C
	public static FP Length(DeterministicAnimationState aniState) { }

	[Extension]
	// RVA: 0x4183C74 Offset: 0x417FC74 VA: 0x4183C74
	public static bool ReachTransition(DeterministicAnimationState aniState, FP playTime, out DeterministicAnimationTransition transition) { }

	// RVA: 0x4185034 Offset: 0x4181034 VA: 0x4185034
	public static string GetDataPath(string prefabPath) { }

	// RVA: 0x4185170 Offset: 0x4181170 VA: 0x4185170
	public static int GetPathHashCode(string prefabPath) { }

	// RVA: 0x4185334 Offset: 0x4181334 VA: 0x4185334
	public static bool HasAnimator(string prefabPath) { }

	// RVA: 0x41853B4 Offset: 0x41813B4 VA: 0x41853B4
	public static void DeSerializePrefabPathHash(byte[] bytes) { }

	// RVA: 0x41857D4 Offset: 0x41817D4 VA: 0x41857D4
	private static void .cctor() { }
}

// Namespace: Deterministic.Animation
public class DeterministicAnimator : IBinarySerialize, IBinaryDeSerialize // TypeDefIndex: 24339
{
	// Fields
	private FP _speed; // 0x10
	private Dictionary<int, DeterministicAnimationState> _aniStateIntDic; // 0x18
	private Dictionary<string, DeterministicAnimationState> _aniStateStrDic; // 0x20
	private AnimatorStateBase _curState; // 0x28
	private Dictionary<DeterministicAnimatorState, AnimatorStateBase> _stateDic; // 0x30
	public Action<int, int, FP, FP> OnTransitionBegin; // 0x38
	public Action<int, int, FP> OnTransitionEnd; // 0x40
	public Action<int, FP> OnPlayState; // 0x48
	public Action<int> OnPlayOver; // 0x50
	[CompilerGenerated]
	private Action<DeterministicAnimationEvent> OnEvent; // 0x58
	[CompilerGenerated]
	private Action<DeterministicAnimationEvent> OnReceiveFirePosListEvent; // 0x60
	[CompilerGenerated]
	private int <EntityId>k__BackingField; // 0x68
	private DeterministicAnimationState[] _aniStates; // 0x70
	private int _defaultStateHash; // 0x78

	// Properties
	public FP Speed { get; }
	public int DefaultStateHash { get; }
	public int EntityId { get; set; }
	public string CurPlayingAniName { get; }
	public int CurPlayingAniHash { get; }

	// Methods

	// RVA: 0x418586C Offset: 0x418186C VA: 0x418586C
	public FP get_Speed() { }

	// RVA: 0x4185874 Offset: 0x4181874 VA: 0x4185874
	public int get_DefaultStateHash() { }

	[CompilerGenerated]
	// RVA: 0x418587C Offset: 0x418187C VA: 0x418587C
	public void add_OnEvent(Action<DeterministicAnimationEvent> value) { }

	[CompilerGenerated]
	// RVA: 0x418592C Offset: 0x418192C VA: 0x418592C
	public void remove_OnEvent(Action<DeterministicAnimationEvent> value) { }

	[CompilerGenerated]
	// RVA: 0x41859DC Offset: 0x41819DC VA: 0x41859DC
	public void add_OnReceiveFirePosListEvent(Action<DeterministicAnimationEvent> value) { }

	[CompilerGenerated]
	// RVA: 0x4185A8C Offset: 0x4181A8C VA: 0x4185A8C
	public void remove_OnReceiveFirePosListEvent(Action<DeterministicAnimationEvent> value) { }

	[CompilerGenerated]
	// RVA: 0x4185B3C Offset: 0x4181B3C VA: 0x4185B3C
	public int get_EntityId() { }

	[CompilerGenerated]
	// RVA: 0x4185B44 Offset: 0x4181B44 VA: 0x4185B44
	private void set_EntityId(int value) { }

	// RVA: 0x4183E68 Offset: 0x417FE68 VA: 0x4183E68
	public void DispatchEvent(DeterministicAnimationEvent evt) { }

	// RVA: 0x4185B4C Offset: 0x4181B4C VA: 0x4185B4C
	public void Init() { }

	// RVA: 0x4185F3C Offset: 0x4181F3C VA: 0x4185F3C
	public List<FPVector3> GetFirePosList() { }

	// RVA: 0x41860A4 Offset: 0x41820A4 VA: 0x41860A4
	public void DeInit() { }

	// RVA: 0x4186174 Offset: 0x4182174 VA: 0x4186174
	public void SetEntityId(int entityId) { }

	// RVA: 0x418617C Offset: 0x418217C VA: 0x418617C
	public DeterministicAnimationState GetAnimationState(string stateName) { }

	// RVA: 0x4183644 Offset: 0x417F644 VA: 0x4183644
	public DeterministicAnimationState GetAnimationState(int stateHash) { }

	// RVA: 0x4186204 Offset: 0x4182204 VA: 0x4186204
	public string get_CurPlayingAniName() { }

	// RVA: 0x4186230 Offset: 0x4182230 VA: 0x4186230
	public int get_CurPlayingAniHash() { }

	// RVA: 0x418625C Offset: 0x418225C VA: 0x418625C
	public bool IsPlayingAnimation(string stateName) { }

	// RVA: 0x4186294 Offset: 0x4182294 VA: 0x4186294
	public bool IsPlayingAnimation(int stateHash) { }

	// RVA: 0x41862C8 Offset: 0x41822C8 VA: 0x41862C8
	public void PlayAnimation(string stateName) { }

	// RVA: 0x41862D0 Offset: 0x41822D0 VA: 0x41862D0
	public void PlayAnimation(string stateName, FP speed) { }

	// RVA: 0x418630C Offset: 0x418230C VA: 0x418630C
	public void PlayAnimation(int stateHash) { }

	// RVA: 0x4185DCC Offset: 0x4181DCC VA: 0x4185DCC
	public void PlayAnimation(int stateHash, FP speed) { }

	// RVA: 0x4186314 Offset: 0x4182314 VA: 0x4186314
	public void OnUpdate(FP deltaTime) { }

	// RVA: 0x4183D20 Offset: 0x417FD20 VA: 0x4183D20
	public void ActiveState(DeterministicAnimatorState state, object[] args) { }

	// RVA: 0x418633C Offset: 0x418233C VA: 0x418633C
	public FP GetAnimLength(int stateHash) { }

	// RVA: 0x41863E4 Offset: 0x41823E4 VA: 0x41863E4
	public FP GetAnimLength(string stateName) { }

	// RVA: 0x418648C Offset: 0x418248C VA: 0x418648C
	public FP GetEventTime(int stateHash, string eventName) { }

	// RVA: 0x4186580 Offset: 0x4182580 VA: 0x4186580
	public FP GetEventTime(string stateName, string eventName) { }

	// RVA: 0x4186674 Offset: 0x4182674 VA: 0x4186674
	public void SetDefaultStateHash(int defaultStateHash) { }

	// RVA: 0x418667C Offset: 0x418267C VA: 0x418667C
	public void SetAnimationStates(DeterministicAnimationState[] aniStates) { }

	// RVA: 0x4186684 Offset: 0x4182684 VA: 0x4186684 Slot: 4
	public void Serialize(BinaryWriter writer) { }

	// RVA: 0x418672C Offset: 0x418272C VA: 0x418672C Slot: 5
	public void DeSerialize(BinaryReader reader) { }

	// RVA: 0x4186880 Offset: 0x4182880 VA: 0x4186880
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 24340
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 // TypeDefIndex: 24341
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 // TypeDefIndex: 24342
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3710 // TypeDefIndex: 24343
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4386 // TypeDefIndex: 24344
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 24345
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 007BF590BBEB04CCFE038AF62ED0DC0030769A13820A1C9E0B33958E6F2389C6 /*Metadata offset 0xF37330*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3710 4B07CBFF23FB96F4F15EBEDEBAF86DFAA8B672EA8DDE486D67A0E598837F4B9C /*Metadata offset 0xF374D8*/; // 0x1A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 59B7E757844D3BF9299877BD1C17451611BFBAB493374D6B18D973FDE534151A /*Metadata offset 0xF38358*/; // 0x101E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 5B979F69B96A61586A09DD4ED26F20534C629B08732AE32FA34B6F8A0049ACDD /*Metadata offset 0xF38368*/; // 0x102A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7FCA397EF25DB53B2C58A05F9BBFA4E8E0685FDBC8AAF39536123447056895C0 /*Metadata offset 0xF38378*/; // 0x1036
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B257E85A5D3CAB5E738D5A0FD1A7AE96624BFE92CB7915726CBBE1518C3225CF /*Metadata offset 0xF38388*/; // 0x1042
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B7A918F6F138CA8137025633559198B529D28CCEC5A51B005376CC69A5B83D85 /*Metadata offset 0xF38398*/; // 0x104E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4386 C68E5290C06BFB59C4D1E38DAACA5D8F7444A64B1069D809D571570B1E2F1C6A /*Metadata offset 0xF383A8*/; // 0x105A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 C84227140A8A7787B30DFF8BD5693C19AA5A430C4E89FFD0256D7F77B3FEAD82 /*Metadata offset 0xF394D0*/; // 0x217C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 FC03ECB1D62767A5B31230F548FA4D4C02F01E3DA8CA1FC66C7C332EA16BF206 /*Metadata offset 0xF39548*/; // 0x21EC
}

