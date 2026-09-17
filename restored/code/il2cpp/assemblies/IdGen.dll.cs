// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28757
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 28758
{
	// Methods

	// RVA: 0x797AB8C Offset: 0x7976B8C VA: 0x797AB8C
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 28759
{
	// Methods

	// RVA: 0x797AB94 Offset: 0x7976B94 VA: 0x797AB94
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 28760
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x797AB9C Offset: 0x7976B9C VA: 0x797AB9C
	public void .ctor(byte ) { }

	// RVA: 0x797AC24 Offset: 0x7976C24 VA: 0x797AC24
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 28761
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x797AC54 Offset: 0x7976C54 VA: 0x797AC54
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
[Usage(2, AllowMultiple = False, Inherited = False)]
internal sealed class RefSafetyRulesAttribute : Attribute // TypeDefIndex: 28762
{
	// Fields
	public readonly int Version; // 0x10

	// Methods

	// RVA: 0x797AC7C Offset: 0x7976C7C VA: 0x797AC7C
	public void .ctor(int ) { }
}

// Namespace: IdGen
public class DefaultTimeSource : StopwatchTimeSource // TypeDefIndex: 28763
{
	// Methods

	// RVA: 0x797ACA4 Offset: 0x7976CA4 VA: 0x797ACA4
	public void .ctor(DateTimeOffset epoch) { }

	// RVA: 0x797AD20 Offset: 0x7976D20 VA: 0x797AD20
	public void .ctor(DateTimeOffset epoch, TimeSpan tickDuration) { }

	// RVA: 0x797AE84 Offset: 0x7976E84 VA: 0x797AE84 Slot: 7
	public override long GetTicks() { }
}

// Namespace: IdGen
public struct Id : IEquatable<Id> // TypeDefIndex: 28764
{
	// Fields
	[CompilerGenerated]
	private int <SequenceNumber>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <GeneratorId>k__BackingField; // 0x4
	[CompilerGenerated]
	private DateTimeOffset <DateTimeOffset>k__BackingField; // 0x8

	// Properties
	public int SequenceNumber { get; set; }
	public int GeneratorId { get; set; }
	public DateTimeOffset DateTimeOffset { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x797AF70 Offset: 0x7976F70 VA: 0x797AF70
	public int get_SequenceNumber() { }

	[CompilerGenerated]
	// RVA: 0x797AF78 Offset: 0x7976F78 VA: 0x797AF78
	private void set_SequenceNumber(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x797AF80 Offset: 0x7976F80 VA: 0x797AF80
	public int get_GeneratorId() { }

	[CompilerGenerated]
	// RVA: 0x797AF88 Offset: 0x7976F88 VA: 0x797AF88
	private void set_GeneratorId(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x797AF90 Offset: 0x7976F90 VA: 0x797AF90
	public DateTimeOffset get_DateTimeOffset() { }

	[CompilerGenerated]
	// RVA: 0x797AF9C Offset: 0x7976F9C VA: 0x797AF9C
	private void set_DateTimeOffset(DateTimeOffset value) { }

	// RVA: 0x797AFA4 Offset: 0x7976FA4 VA: 0x797AFA4
	internal void .ctor(int sequenceNumber, int generatorId, DateTimeOffset dateTimeOffset) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x797AFB0 Offset: 0x7976FB0 VA: 0x797AFB0 Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x797B08C Offset: 0x797708C VA: 0x797B08C
	private bool PrintMembers(StringBuilder builder) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x797B1D8 Offset: 0x79771D8 VA: 0x797B1D8 Slot: 2
	public override int GetHashCode() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x797B2A4 Offset: 0x79772A4 VA: 0x797B2A4 Slot: 0
	public override bool Equals(object obj) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x797B334 Offset: 0x7977334 VA: 0x797B334 Slot: 4
	public bool Equals(Id other) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class IdGenerator.<IdStream>d__22 : IEnumerable<long>, IEnumerable, IEnumerator<long>, IEnumerator, IDisposable // TypeDefIndex: 28765
{
	// Fields
	private int <>1__state; // 0x10
	private long <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(0)]
	public IdGenerator <>4__this; // 0x28

	// Properties
	private long System.Collections.Generic.IEnumerator<System.Int64>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x797BFAC Offset: 0x7977FAC VA: 0x797BFAC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x797C148 Offset: 0x7978148 VA: 0x797C148 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x797C14C Offset: 0x797814C VA: 0x797C14C Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x797C19C Offset: 0x797819C VA: 0x797C19C Slot: 6
	private long System.Collections.Generic.IEnumerator<System.Int64>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x797C1A4 Offset: 0x79781A4 VA: 0x797C1A4 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x797C1DC Offset: 0x79781DC VA: 0x797C1DC Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x797C238 Offset: 0x7978238 VA: 0x797C238 Slot: 4
	private IEnumerator<long> System.Collections.Generic.IEnumerable<System.Int64>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x797C2DC Offset: 0x79782DC VA: 0x797C2DC Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: IdGen
[Nullable(0)]
[NullableContext(1)]
public class IdGenerator : IIdGenerator<long>, IEnumerable<long>, IEnumerable // TypeDefIndex: 28766
{
	// Fields
	private readonly long _generatorid; // 0x10
	private int _sequence; // 0x18
	private long _lastgen; // 0x20
	private readonly long MASK_SEQUENCE; // 0x28
	private readonly long MASK_TIME; // 0x30
	private readonly long MASK_GENERATOR; // 0x38
	private readonly int SHIFT_TIME; // 0x40
	private readonly int SHIFT_GENERATOR; // 0x44
	private readonly object _genlock; // 0x48
	[CompilerGenerated]
	private readonly IdGeneratorOptions <Options>k__BackingField; // 0x50

	// Properties
	public IdGeneratorOptions Options { get; }
	public int Id { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x797B410 Offset: 0x7977410 VA: 0x797B410
	public IdGeneratorOptions get_Options() { }

	// RVA: 0x797B418 Offset: 0x7977418 VA: 0x797B418
	public int get_Id() { }

	// RVA: 0x797B420 Offset: 0x7977420 VA: 0x797B420
	public void .ctor(int generatorId) { }

	// RVA: 0x797B5B8 Offset: 0x79775B8 VA: 0x797B5B8
	public void .ctor(int generatorId, IdGeneratorOptions options) { }

	// RVA: 0x797B7EC Offset: 0x79777EC VA: 0x797B7EC Slot: 6
	public long CreateId() { }

	// RVA: 0x797BC3C Offset: 0x7977C3C VA: 0x797BC3C
	public bool TryCreateId(out long id) { }

	[NullableContext(2)]
	// RVA: 0x797B82C Offset: 0x797782C VA: 0x797B82C
	private long CreateIdImpl(out Exception exception) { }

	// RVA: 0x797BC80 Offset: 0x7977C80 VA: 0x797BC80
	public Id FromId(long id) { }

	// RVA: 0x797BE74 Offset: 0x7977E74 VA: 0x797BE74
	private long GetTicks() { }

	// RVA: 0x797BF20 Offset: 0x7977F20 VA: 0x797BF20
	private static long GetMask(byte bits) { }

	[IteratorStateMachine(typeof(IdGenerator.<IdStream>d__22))]
	// RVA: 0x797BF30 Offset: 0x7977F30 VA: 0x797BF30
	private IEnumerable<long> IdStream() { }

	// RVA: 0x797BFE0 Offset: 0x7977FE0 VA: 0x797BFE0 Slot: 4
	public IEnumerator<long> GetEnumerator() { }

	// RVA: 0x797C088 Offset: 0x7978088 VA: 0x797C088 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CompilerGenerated]
	// RVA: 0x797C08C Offset: 0x797808C VA: 0x797C08C
	private bool <CreateIdImpl>b__18_0() { }
}

// Namespace: IdGen
[NullableContext(1)]
[Nullable(0)]
public class IdGeneratorOptions // TypeDefIndex: 28767
{
	// Fields
	public static readonly DateTime DefaultEpoch; // 0x0
	private static readonly IdStructure _defaultidstructure; // 0x8
	private static readonly ITimeSource _defaulttimesource; // 0x10
	private static readonly SequenceOverflowStrategy _defaultsequenceoverflowstrategy; // 0x18
	public static readonly IdGeneratorOptions Default; // 0x20
	[CompilerGenerated]
	private readonly IdStructure <IdStructure>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ITimeSource <TimeSource>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly SequenceOverflowStrategy <SequenceOverflowStrategy>k__BackingField; // 0x20

	// Properties
	public IdStructure IdStructure { get; set; }
	public ITimeSource TimeSource { get; set; }
	public SequenceOverflowStrategy SequenceOverflowStrategy { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x797C2E0 Offset: 0x79782E0 VA: 0x797C2E0
	public IdStructure get_IdStructure() { }

	[CompilerGenerated]
	// RVA: 0x797C2E8 Offset: 0x79782E8 VA: 0x797C2E8
	public void set_IdStructure(IdStructure value) { }

	[CompilerGenerated]
	// RVA: 0x797C2F0 Offset: 0x79782F0 VA: 0x797C2F0
	public ITimeSource get_TimeSource() { }

	[CompilerGenerated]
	// RVA: 0x797C2F8 Offset: 0x79782F8 VA: 0x797C2F8
	public void set_TimeSource(ITimeSource value) { }

	[CompilerGenerated]
	// RVA: 0x797C300 Offset: 0x7978300 VA: 0x797C300
	public SequenceOverflowStrategy get_SequenceOverflowStrategy() { }

	[CompilerGenerated]
	// RVA: 0x797C308 Offset: 0x7978308 VA: 0x797C308
	public void set_SequenceOverflowStrategy(SequenceOverflowStrategy value) { }

	[NullableContext(2)]
	// RVA: 0x797B494 Offset: 0x7977494 VA: 0x797B494
	public void .ctor(IdStructure idStructure, ITimeSource timeSource, SequenceOverflowStrategy sequenceOverflowStrategy = 0) { }

	// RVA: 0x797C310 Offset: 0x7978310 VA: 0x797C310
	private static void .cctor() { }
}

// Namespace: IdGen
[Nullable(0)]
[NullableContext(1)]
public class IdStructure // TypeDefIndex: 28768
{
	// Fields
	[CompilerGenerated]
	private byte <TimestampBits>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <GeneratorIdBits>k__BackingField; // 0x11
	[CompilerGenerated]
	private byte <SequenceBits>k__BackingField; // 0x12

	// Properties
	public byte TimestampBits { get; set; }
	public byte GeneratorIdBits { get; set; }
	public byte SequenceBits { get; set; }
	public static IdStructure Default { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x797C514 Offset: 0x7978514 VA: 0x797C514
	public byte get_TimestampBits() { }

	[CompilerGenerated]
	// RVA: 0x797C51C Offset: 0x797851C VA: 0x797C51C
	private void set_TimestampBits(byte value) { }

	[CompilerGenerated]
	// RVA: 0x797C524 Offset: 0x7978524 VA: 0x797C524
	public byte get_GeneratorIdBits() { }

	[CompilerGenerated]
	// RVA: 0x797C52C Offset: 0x797852C VA: 0x797C52C
	private void set_GeneratorIdBits(byte value) { }

	[CompilerGenerated]
	// RVA: 0x797C534 Offset: 0x7978534 VA: 0x797C534
	public byte get_SequenceBits() { }

	[CompilerGenerated]
	// RVA: 0x797C53C Offset: 0x797853C VA: 0x797C53C
	private void set_SequenceBits(byte value) { }

	// RVA: 0x797C4B0 Offset: 0x79784B0 VA: 0x797C4B0
	public static IdStructure get_Default() { }

	// RVA: 0x797C544 Offset: 0x7978544 VA: 0x797C544
	public void .ctor(byte timestampBits, byte generatorIdBits, byte sequenceBits) { }
}

// Namespace: IdGen
public interface IIdGenerator<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 28769
{}

// Namespace: IdGen
[Nullable(0)]
[NullableContext(1)]
public class InvalidSystemClockException : Exception // TypeDefIndex: 28770
{
	// Methods

	// RVA: 0x797BC70 Offset: 0x7977C70 VA: 0x797BC70
	public void .ctor(string message) { }

	// RVA: 0x797C66C Offset: 0x797866C VA: 0x797C66C
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: IdGen
public interface ITimeSource // TypeDefIndex: 28771
{
	// Properties
	public abstract DateTimeOffset Epoch { get; }
	public abstract TimeSpan TickDuration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DateTimeOffset get_Epoch();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TimeSpan get_TickDuration();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract long GetTicks();
}

// Namespace: IdGen
[Nullable(0)]
[NullableContext(1)]
public class SequenceOverflowException : Exception // TypeDefIndex: 28772
{
	// Methods

	// RVA: 0x797BC78 Offset: 0x7977C78 VA: 0x797BC78
	public void .ctor(string message) { }

	// RVA: 0x797C6DC Offset: 0x79786DC VA: 0x797C6DC
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: IdGen
public enum SequenceOverflowStrategy // TypeDefIndex: 28773
{
	// Fields
	public int value__; // 0x0
	public const SequenceOverflowStrategy Throw = 0;
	public const SequenceOverflowStrategy SpinWait = 1;
}

// Namespace: IdGen
public abstract class StopwatchTimeSource : ITimeSource // TypeDefIndex: 28774
{
	// Fields
	[Nullable(1)]
	private static readonly Stopwatch _sw; // 0x0
	private static readonly DateTimeOffset _initialized; // 0x8
	[CompilerGenerated]
	private DateTimeOffset <Epoch>k__BackingField; // 0x10
	[CompilerGenerated]
	private TimeSpan <Offset>k__BackingField; // 0x20
	[CompilerGenerated]
	private TimeSpan <TickDuration>k__BackingField; // 0x28

	// Properties
	public DateTimeOffset Epoch { get; set; }
	protected static TimeSpan Elapsed { get; }
	protected TimeSpan Offset { get; set; }
	public TimeSpan TickDuration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x797C74C Offset: 0x797874C VA: 0x797C74C Slot: 4
	public DateTimeOffset get_Epoch() { }

	[CompilerGenerated]
	// RVA: 0x797C758 Offset: 0x7978758 VA: 0x797C758
	private void set_Epoch(DateTimeOffset value) { }

	// RVA: 0x797AF0C Offset: 0x7976F0C VA: 0x797AF0C
	protected static TimeSpan get_Elapsed() { }

	[CompilerGenerated]
	// RVA: 0x797C760 Offset: 0x7978760 VA: 0x797C760
	protected TimeSpan get_Offset() { }

	[CompilerGenerated]
	// RVA: 0x797C768 Offset: 0x7978768 VA: 0x797C768
	private void set_Offset(TimeSpan value) { }

	// RVA: 0x797AD9C Offset: 0x7976D9C VA: 0x797AD9C
	public void .ctor(DateTimeOffset epoch, TimeSpan tickDuration) { }

	[CompilerGenerated]
	// RVA: 0x797C770 Offset: 0x7978770 VA: 0x797C770 Slot: 5
	public TimeSpan get_TickDuration() { }

	[CompilerGenerated]
	// RVA: 0x797C778 Offset: 0x7978778 VA: 0x797C778
	private void set_TickDuration(TimeSpan value) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long GetTicks();

	// RVA: 0x797C780 Offset: 0x7978780 VA: 0x797C780
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
[DebuggerNonUserCode]
internal static class IsExternalInit // TypeDefIndex: 28775
{}

