// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 29004
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 29005
{
	// Methods

	// RVA: 0x853DEF4 Offset: 0x8539EF4 VA: 0x853DEF4
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 29006
{
	// Methods

	// RVA: 0x853DEFC Offset: 0x8539EFC VA: 0x853DEFC
	public void .ctor() { }
}

// Namespace: Unity.Profiling
[IsReadOnly]
public struct ProfilerCounter<T> // TypeDefIndex: 29007
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294A64 Offset: 0x5290A64 VA: 0x5294A64
	|-ProfilerCounter<int>..ctor
	|
	|-RVA: 0x5294A68 Offset: 0x5290A68 VA: 0x5294A68
	|-ProfilerCounter<float>..ctor
	|
	|-RVA: 0x5294A6C Offset: 0x5290A6C VA: 0x5294A6C
	|-ProfilerCounter<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: Unity.Profiling
[IsReadOnly]
public struct ProfilerCounterValue<T> // TypeDefIndex: 29008
{
	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529497C Offset: 0x529097C VA: 0x529497C
	|-ProfilerCounterValue<int>..ctor
	|
	|-RVA: 0x529498C Offset: 0x529098C VA: 0x529498C
	|-ProfilerCounterValue<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294980 Offset: 0x5290980 VA: 0x5294980
	|-ProfilerCounterValue<int>.get_Value
	|
	|-RVA: 0x5294990 Offset: 0x5290990 VA: 0x5294990
	|-ProfilerCounterValue<__Il2CppFullySharedGenericStructType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294988 Offset: 0x5290988 VA: 0x5294988
	|-ProfilerCounterValue<int>.set_Value
	|
	|-RVA: 0x5294A60 Offset: 0x5290A60 VA: 0x5294A60
	|-ProfilerCounterValue<__Il2CppFullySharedGenericStructType>.set_Value
	*/
}

