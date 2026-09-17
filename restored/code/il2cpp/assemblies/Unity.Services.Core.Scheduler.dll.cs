// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28881
{}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ActionScheduler : IActionScheduler, IServiceComponent // TypeDefIndex: 28882
{
	// Fields
	internal readonly PlayerLoopSystem SchedulerLoopSystem; // 0x10
	private readonly ITimeProvider m_TimeProvider; // 0x38
	private readonly object m_Lock; // 0x40
	private readonly MinimumBinaryHeap<ScheduledInvocation> m_ScheduledActions; // 0x48
	private readonly Dictionary<long, ScheduledInvocation> m_IdScheduledInvocationMap; // 0x50
	private readonly List<ScheduledInvocation> m_ExpiredActions; // 0x58
	private long m_NextId; // 0x60

	// Methods

	// RVA: 0x863AD10 Offset: 0x8636D10 VA: 0x863AD10
	public void .ctor() { }

	// RVA: 0x863AD74 Offset: 0x8636D74 VA: 0x863AD74
	public void .ctor(ITimeProvider timeProvider) { }

	// RVA: 0x863B01C Offset: 0x863701C VA: 0x863B01C
	internal void ExecuteExpiredActions() { }

	// RVA: 0x863B5E0 Offset: 0x86375E0 VA: 0x863B5E0
	internal static void UpdateCurrentPlayerLoopWith(List<PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop) { }

	// RVA: 0x863B66C Offset: 0x863766C VA: 0x863B66C
	public void JoinPlayerLoopSystem() { }
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal abstract class MinimumBinaryHeap // TypeDefIndex: 28883
{
	// Methods

	// RVA: 0x863B834 Offset: 0x8637834 VA: 0x863B834
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct MinimumBinaryHeap.<>c__DisplayClass21_0<T> // TypeDefIndex: 28884
{
	// Fields
	public int smallest; // 0x0
	public int currentIndex; // 0x0
	public MinimumBinaryHeap<T> <>4__this; // 0x0
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class MinimumBinaryHeap<T> : MinimumBinaryHeap // TypeDefIndex: 28885
{
	// Fields
	private readonly object m_Lock; // 0x0
	private readonly IComparer<T> m_Comparer; // 0x0
	private readonly int m_MinimumCapacity; // 0x0
	private T[] m_HeapArray; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public int Count { get; set; }
	public T Min { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FC7E4 Offset: 0x50F87E4 VA: 0x50FC7E4
	|-MinimumBinaryHeap<object>.get_Count
	|
	|-RVA: 0x50FD8A0 Offset: 0x50F98A0 VA: 0x50FD8A0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FC7EC Offset: 0x50F87EC VA: 0x50FC7EC
	|-MinimumBinaryHeap<object>.set_Count
	|
	|-RVA: 0x50FD8A8 Offset: 0x50F98A8 VA: 0x50FD8A8
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Min() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FC7F4 Offset: 0x50F87F4 VA: 0x50FC7F4
	|-MinimumBinaryHeap<object>.get_Min
	|
	|-RVA: 0x50FD8B0 Offset: 0x50F98B0 VA: 0x50FD8B0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.get_Min
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer, int minimumCapacity = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FC81C Offset: 0x50F881C VA: 0x50FC81C
	|-MinimumBinaryHeap<object>..ctor
	|
	|-RVA: 0x50FD958 Offset: 0x50F9958 VA: 0x50FD958
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<T> collection, IComparer<T> comparer, int minimumCapacity = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FC83C Offset: 0x50F883C VA: 0x50FC83C
	|-MinimumBinaryHeap<object>..ctor
	|
	|-RVA: 0x50FD97C Offset: 0x50F997C VA: 0x50FD97C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Insert(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FCDA8 Offset: 0x50F8DA8 VA: 0x50FCDA8
	|-MinimumBinaryHeap<object>.Insert
	|
	|-RVA: 0x50FE008 Offset: 0x50FA008 VA: 0x50FE008
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	private void IncreaseHeapCapacityWhenFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD02C Offset: 0x50F902C VA: 0x50FD02C
	|-MinimumBinaryHeap<object>.IncreaseHeapCapacityWhenFull
	|
	|-RVA: 0x50FE480 Offset: 0x50FA480 VA: 0x50FE480
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.IncreaseHeapCapacityWhenFull
	*/

	// RVA: -1 Offset: -1
	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD130 Offset: 0x50F9130 VA: 0x50FD130
	|-MinimumBinaryHeap<object>.Remove
	|
	|-RVA: 0x50FE5D0 Offset: 0x50FA5D0 VA: 0x50FE5D0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	private int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD2AC Offset: 0x50F92AC VA: 0x50FD2AC
	|-MinimumBinaryHeap<object>.IndexOf
	|
	|-RVA: 0x50FE82C Offset: 0x50FA82C VA: 0x50FE82C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public T ExtractMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD32C Offset: 0x50F932C VA: 0x50FD32C
	|-MinimumBinaryHeap<object>.ExtractMin
	|
	|-RVA: 0x50FEA0C Offset: 0x50FAA0C VA: 0x50FEA0C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.ExtractMin
	*/

	// RVA: -1 Offset: -1
	private void DecreaseHeapCapacityWhenSpare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD508 Offset: 0x50F9508 VA: 0x50FD508
	|-MinimumBinaryHeap<object>.DecreaseHeapCapacityWhenSpare
	|
	|-RVA: 0x50FEF70 Offset: 0x50FAF70 VA: 0x50FEF70
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.DecreaseHeapCapacityWhenSpare
	*/

	// RVA: -1 Offset: -1
	private void MinHeapify() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD610 Offset: 0x50F9610 VA: 0x50FD610
	|-MinimumBinaryHeap<object>.MinHeapify
	|
	|-RVA: 0x50FF0F0 Offset: 0x50FB0F0 VA: 0x50FF0F0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.MinHeapify
	*/

	// RVA: -1 Offset: -1
	private static void Swap(ref T lhs, ref T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD6DC Offset: 0x50F96DC VA: 0x50FD6DC
	|-MinimumBinaryHeap<object>.Swap
	|
	|-RVA: 0x50FF1B4 Offset: 0x50FB1B4 VA: 0x50FF1B4
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1
	private static int GetParentIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD710 Offset: 0x50F9710 VA: 0x50FD710
	|-MinimumBinaryHeap<object>.GetParentIndex
	|
	|-RVA: 0x50FF39C Offset: 0x50FB39C VA: 0x50FF39C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetParentIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetLeftChildIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD724 Offset: 0x50F9724 VA: 0x50FD724
	|-MinimumBinaryHeap<object>.GetLeftChildIndex
	|
	|-RVA: 0x50FF3B0 Offset: 0x50FB3B0 VA: 0x50FF3B0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetLeftChildIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetRightChildIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD734 Offset: 0x50F9734 VA: 0x50FD734
	|-MinimumBinaryHeap<object>.GetRightChildIndex
	|
	|-RVA: 0x50FF3C0 Offset: 0x50FB3C0 VA: 0x50FF3C0
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetRightChildIndex
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <MinHeapify>g__UpdateSmallestIndex|21_0(ref MinimumBinaryHeap.<>c__DisplayClass21_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD740 Offset: 0x50F9740 VA: 0x50FD740
	|-MinimumBinaryHeap<object>.<MinHeapify>g__UpdateSmallestIndex|21_0
	|
	|-RVA: 0x50FF3CC Offset: 0x50FB3CC VA: 0x50FF3CC
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.<MinHeapify>g__UpdateSmallestIndex|21_0
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(int candidate, ref MinimumBinaryHeap.<>c__DisplayClass21_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50FD7AC Offset: 0x50F97AC VA: 0x50FD7AC
	|-MinimumBinaryHeap<object>.<MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1
	|
	|-RVA: 0x50FF474 Offset: 0x50FB474 VA: 0x50FF474
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.<MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1
	*/
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ScheduledInvocation // TypeDefIndex: 28886
{
	// Fields
	public Action Action; // 0x10
	public DateTime InvocationTime; // 0x18
	public long ActionId; // 0x20
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ScheduledInvocationComparer : IComparer<ScheduledInvocation> // TypeDefIndex: 28887
{
	// Methods

	// RVA: 0x863B83C Offset: 0x863783C VA: 0x863B83C Slot: 4
	public int Compare(ScheduledInvocation x, ScheduledInvocation y) { }

	// RVA: 0x863B014 Offset: 0x8637014 VA: 0x863B014
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal interface ITimeProvider // TypeDefIndex: 28888
{
	// Properties
	public abstract DateTime Now { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DateTime get_Now();
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class UtcTimeProvider : ITimeProvider // TypeDefIndex: 28889
{
	// Properties
	public DateTime Now { get; }

	// Methods

	// RVA: 0x863B8F4 Offset: 0x86378F4 VA: 0x863B8F4 Slot: 4
	public DateTime get_Now() { }

	// RVA: 0x863AD6C Offset: 0x8636D6C VA: 0x863AD6C
	public void .ctor() { }
}

