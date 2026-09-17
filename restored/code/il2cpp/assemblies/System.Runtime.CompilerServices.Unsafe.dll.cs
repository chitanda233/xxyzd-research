// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28970
{}

// Namespace: System.Runtime.CompilerServices
public static class Unsafe // TypeDefIndex: 28971
{
	// Methods

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static T ReadUnaligned<T>(ref byte source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4751E60 Offset: 0x474DE60 VA: 0x4751E60
	|-Unsafe.ReadUnaligned<double>
	|
	|-RVA: 0x4751E68 Offset: 0x474DE68 VA: 0x4751E68
	|-Unsafe.ReadUnaligned<float>
	|
	|-RVA: 0x4751E70 Offset: 0x474DE70 VA: 0x4751E70
	|-Unsafe.ReadUnaligned<ulong>
	|
	|-RVA: 0x4751E78 Offset: 0x474DE78 VA: 0x4751E78
	|-Unsafe.ReadUnaligned<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void WriteUnaligned<T>(ref byte destination, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4751F24 Offset: 0x474DF24 VA: 0x4751F24
	|-Unsafe.WriteUnaligned<float>
	|
	|-RVA: 0x4751F2C Offset: 0x474DF2C VA: 0x4751F2C
	|-Unsafe.WriteUnaligned<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4751E58 Offset: 0x474DE58 VA: 0x4751E58
	|-Unsafe.As<char, byte>
	|
	|-RVA: 0x4751E5C Offset: 0x474DE5C VA: 0x4751E5C
	|-Unsafe.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4751DF0 Offset: 0x474DDF0 VA: 0x4751DF0
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x4751DF8 Offset: 0x474DDF8 VA: 0x4751DF8
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4751E40 Offset: 0x474DE40 VA: 0x4751E40
	|-Unsafe.AddByteOffset<byte>
	|
	|-RVA: 0x4751E48 Offset: 0x474DE48 VA: 0x4751E48
	|-Unsafe.AddByteOffset<char>
	|
	|-RVA: 0x4751E50 Offset: 0x474DE50 VA: 0x4751E50
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Runtime.Versioning
[Usage(108, AllowMultiple = False, Inherited = False)]
internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 28972
{
	// Methods

	// RVA: 0x8193244 Offset: 0x818F244 VA: 0x8193244
	public void .ctor() { }
}

