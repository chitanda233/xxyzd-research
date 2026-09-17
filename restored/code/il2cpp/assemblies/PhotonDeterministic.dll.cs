// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 23990
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 23991
{
	// Methods

	// RVA: 0x7D399A0 Offset: 0x7D359A0 VA: 0x7D399A0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 23992
{
	// Methods

	// RVA: 0x7D399A8 Offset: 0x7D359A8 VA: 0x7D399A8
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 23993
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 23994
{
	// Methods

	// RVA: 0x7D399B0 Offset: 0x7D359B0 VA: 0x7D399B0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x7D39AA8 Offset: 0x7D35AA8 VA: 0x7D39AA8
	public void .ctor() { }
}

// Namespace: Photon.Deterministic
public static class Assert // TypeDefIndex: 23995
{
	// Methods

	[DoesNotReturn]
	// RVA: 0x7D39AB0 Offset: 0x7D35AB0 VA: 0x7D39AB0
	public static void Fail() { }

	[DoesNotReturn]
	// RVA: 0x7D39B3C Offset: 0x7D35B3C VA: 0x7D39B3C
	public static void Fail(string msg) { }

	[DoesNotReturn]
	// RVA: 0x7D39BE4 Offset: 0x7D35BE4 VA: 0x7D39BE4
	public static void Fail(string format, object[] args) { }

	// RVA: 0x7D39C2C Offset: 0x7D35C2C VA: 0x7D39C2C
	public static void Always(object condition) { }

	// RVA: 0x7D39C68 Offset: 0x7D35C68 VA: 0x7D39C68
	public static void Always(void* condition) { }

	// RVA: 0x7D39CA4 Offset: 0x7D35CA4 VA: 0x7D39CA4
	public static void Always(bool condition) { }

	// RVA: 0x7D39CE0 Offset: 0x7D35CE0 VA: 0x7D39CE0
	public static void Always(bool condition, string message) { }

	// RVA: -1 Offset: -1
	public static void Always<T0>(bool condition, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FCB94 Offset: 0x44F8B94 VA: 0x44FCB94
	|-Assert.Always<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Always<T0, T1>(bool condition, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FCD9C Offset: 0x44F8D9C VA: 0x44FCD9C
	|-Assert.Always<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Always<T0, T1, T2>(bool condition, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FD06C Offset: 0x44F906C VA: 0x44FD06C
	|-Assert.Always<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Always<T0, T1, T2, T3>(bool condition, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FD40C Offset: 0x44F940C VA: 0x44FD40C
	|-Assert.Always<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Always<T0>(bool condition, string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FCC98 Offset: 0x44F8C98 VA: 0x44FCC98
	|-Assert.Always<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Always<T0, T1>(bool condition, string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FCF04 Offset: 0x44F8F04 VA: 0x44FCF04
	|-Assert.Always<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Always<T0, T1, T2>(bool condition, string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FD240 Offset: 0x44F9240 VA: 0x44FD240
	|-Assert.Always<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D39D28 Offset: 0x7D35D28 VA: 0x7D39D28
	public static void Always(bool condition, string format, object[] args) { }

	[Conditional("DEBUG")]
	// RVA: 0x7D39D80 Offset: 0x7D35D80 VA: 0x7D39D80
	public static void Check(object condition) { }

	[Conditional("DEBUG")]
	// RVA: 0x7D39DBC Offset: 0x7D35DBC VA: 0x7D39DBC
	public static void Check(void* condition) { }

	[Conditional("DEBUG")]
	// RVA: 0x7D39DF8 Offset: 0x7D35DF8 VA: 0x7D39DF8
	public static void Check(bool condition) { }

	[Conditional("DEBUG")]
	// RVA: 0x7D39E34 Offset: 0x7D35E34 VA: 0x7D39E34
	public static void Check(bool condition, string error) { }

	[Conditional("DEBUG")]
	// RVA: -1 Offset: -1
	public static void Check<T0>(bool condition, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FD6E4 Offset: 0x44F96E4 VA: 0x44FD6E4
	|-Assert.Check<__Il2CppFullySharedGenericType>
	*/

	[Conditional("DEBUG")]
	// RVA: -1 Offset: -1
	public static void Check<T0, T1>(bool condition, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FD8EC Offset: 0x44F98EC VA: 0x44FD8EC
	|-Assert.Check<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Conditional("DEBUG")]
	// RVA: -1 Offset: -1
	public static void Check<T0, T1, T2>(bool condition, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FDBBC Offset: 0x44F9BBC VA: 0x44FDBBC
	|-Assert.Check<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Conditional("DEBUG")]
	// RVA: -1 Offset: -1
	public static void Check<T0, T1, T2, T3>(bool condition, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FDF5C Offset: 0x44F9F5C VA: 0x44FDF5C
	|-Assert.Check<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Conditional("DEBUG")]
	// RVA: -1 Offset: -1
	public static void Check<T0>(bool condition, string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FD7E8 Offset: 0x44F97E8 VA: 0x44FD7E8
	|-Assert.Check<__Il2CppFullySharedGenericType>
	*/

	[Conditional("DEBUG")]
	// RVA: -1 Offset: -1
	public static void Check<T0, T1>(bool condition, string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FDA54 Offset: 0x44F9A54 VA: 0x44FDA54
	|-Assert.Check<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Conditional("DEBUG")]
	// RVA: -1 Offset: -1
	public static void Check<T0, T1, T2>(bool condition, string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FDD90 Offset: 0x44F9D90 VA: 0x44FDD90
	|-Assert.Check<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Conditional("DEBUG")]
	// RVA: 0x7D39E7C Offset: 0x7D35E7C VA: 0x7D39E7C
	public static void Check(bool condition, string format, object[] args) { }
}

// Namespace: Photon.Deterministic
public class AssertException : Exception // TypeDefIndex: 23996
{
	// Methods

	// RVA: 0x7D39AE4 Offset: 0x7D35AE4 VA: 0x7D39AE4
	public void .ctor() { }

	// RVA: 0x7D39B7C Offset: 0x7D35B7C VA: 0x7D39B7C
	public void .ctor(string msg) { }
}

// Namespace: 
public sealed class BitStream.ArrayElementSerializer<T> : MulticastDelegate // TypeDefIndex: 23997
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x613E5D4 Offset: 0x613A5D4 VA: 0x613E5D4
	|-BitStream.ArrayElementSerializer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x613E684 Offset: 0x613A684 VA: 0x613E684
	|-BitStream.ArrayElementSerializer<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref T element, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x613E698 Offset: 0x613A698 VA: 0x613E698
	|-BitStream.ArrayElementSerializer<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref T element, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x613E71C Offset: 0x613A71C VA: 0x613E71C
	|-BitStream.ArrayElementSerializer<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Photon.Deterministic
public class BitStream : IBitStream // TypeDefIndex: 23998
{
	// Fields
	private int _ptr; // 0x10
	private int _maxPtr; // 0x14
	private int _offsetBytes; // 0x18
	private int _capacityBytes; // 0x1C
	private byte[] _data; // 0x20
	private bool _write; // 0x28

	// Properties
	public int Position { get; set; }
	public int BytesRequired { get; }
	public bool IsEvenBytes { get; }
	public int Capacity { get; }
	public int Offset { get; }
	public bool Done { get; }
	public bool Overflowing { get; }
	public bool Writing { get; set; }
	public bool Reading { get; set; }
	public byte[] Data { get; }

	// Methods

	// RVA: 0x7D39ED4 Offset: 0x7D35ED4 VA: 0x7D39ED4
	public int get_Position() { }

	// RVA: 0x7D39EE4 Offset: 0x7D35EE4 VA: 0x7D39EE4
	public void set_Position(int value) { }

	// RVA: 0x7D39F64 Offset: 0x7D35F64 VA: 0x7D39F64 Slot: 4
	public int get_BytesRequired() { }

	// RVA: 0x7D39FC4 Offset: 0x7D35FC4 VA: 0x7D39FC4
	public bool get_IsEvenBytes() { }

	// RVA: 0x7D39FD4 Offset: 0x7D35FD4 VA: 0x7D39FD4
	public int get_Capacity() { }

	// RVA: 0x7D39FDC Offset: 0x7D35FDC VA: 0x7D39FDC
	public int get_Offset() { }

	// RVA: 0x7D39FE4 Offset: 0x7D35FE4 VA: 0x7D39FE4
	public bool get_Done() { }

	// RVA: 0x7D39FF4 Offset: 0x7D35FF4 VA: 0x7D39FF4
	public bool get_Overflowing() { }

	// RVA: 0x7D3A004 Offset: 0x7D36004 VA: 0x7D3A004 Slot: 6
	public bool get_Writing() { }

	// RVA: 0x7D3A00C Offset: 0x7D3600C VA: 0x7D3A00C Slot: 7
	public void set_Writing(bool value) { }

	// RVA: 0x7D3A018 Offset: 0x7D36018 VA: 0x7D3A018 Slot: 8
	public bool get_Reading() { }

	// RVA: 0x7D3A028 Offset: 0x7D36028 VA: 0x7D3A028 Slot: 9
	public void set_Reading(bool value) { }

	// RVA: 0x7D3A038 Offset: 0x7D36038 VA: 0x7D3A038 Slot: 5
	public byte[] get_Data() { }

	// RVA: 0x7D3A040 Offset: 0x7D36040 VA: 0x7D3A040
	public void .ctor() { }

	// RVA: 0x7D3A0E0 Offset: 0x7D360E0 VA: 0x7D3A0E0
	public void .ctor(int size) { }

	// RVA: 0x7D3A094 Offset: 0x7D36094 VA: 0x7D3A094
	public void .ctor(byte[] arr) { }

	// RVA: 0x7D3A198 Offset: 0x7D36198 VA: 0x7D3A198
	public void .ctor(byte[] arr, int size) { }

	// RVA: 0x7D3A140 Offset: 0x7D36140 VA: 0x7D3A140
	public void .ctor(byte[] arr, int size, int offset) { }

	// RVA: 0x7D3A1DC Offset: 0x7D361DC VA: 0x7D3A1DC
	public void SetBuffer(byte[] arr) { }

	// RVA: 0x7D3A258 Offset: 0x7D36258 VA: 0x7D3A258
	public void SetBuffer(byte[] arr, int size) { }

	// RVA: 0x7D3A218 Offset: 0x7D36218 VA: 0x7D3A218
	public void SetBuffer(byte[] arr, int size, int offset) { }

	// RVA: 0x7D3A28C Offset: 0x7D3628C VA: 0x7D3A28C
	public int RoundToByte() { }

	// RVA: 0x7D3A354 Offset: 0x7D36354 VA: 0x7D3A354
	public bool CanWrite() { }

	// RVA: 0x7D3A37C Offset: 0x7D3637C VA: 0x7D3A37C
	public bool CanRead() { }

	// RVA: 0x7D3A368 Offset: 0x7D36368 VA: 0x7D3A368
	public bool CanWrite(int bits) { }

	// RVA: 0x7D3A390 Offset: 0x7D36390 VA: 0x7D3A390
	public bool CanRead(int bits) { }

	// RVA: 0x7D3A3A4 Offset: 0x7D363A4 VA: 0x7D3A3A4 Slot: 72
	public void CopyFromArray(byte[] array) { }

	// RVA: 0x7D3A414 Offset: 0x7D36414 VA: 0x7D3A414 Slot: 74
	public void Reset() { }

	// RVA: 0x7D3A41C Offset: 0x7D3641C VA: 0x7D3A41C
	public void Reset(int byteSize) { }

	// RVA: 0x7D3A46C Offset: 0x7D3646C VA: 0x7D3A46C
	public void ResetFast(int byteSize) { }

	// RVA: 0x7D3A4AC Offset: 0x7D364AC VA: 0x7D3A4AC Slot: 73
	public byte[] ToArray() { }

	// RVA: 0x7D3A530 Offset: 0x7D36530 VA: 0x7D3A530 Slot: 54
	public bool WriteBool(bool value) { }

	// RVA: 0x7D3A5B8 Offset: 0x7D365B8 VA: 0x7D3A5B8 Slot: 55
	public bool WriteBoolean(bool value) { }

	// RVA: 0x7D3A604 Offset: 0x7D36604 VA: 0x7D3A604 Slot: 52
	public bool ReadBool() { }

	// RVA: 0x7D3A700 Offset: 0x7D36700 VA: 0x7D3A700 Slot: 53
	public bool ReadBoolean() { }

	// RVA: 0x7D3A318 Offset: 0x7D36318 VA: 0x7D3A318
	public void WriteByte(byte value, int bits) { }

	// RVA: 0x7D3A720 Offset: 0x7D36720 VA: 0x7D3A720
	public byte ReadByte(int bits) { }

	// RVA: 0x7D3A724 Offset: 0x7D36724 VA: 0x7D3A724 Slot: 71
	public void WriteByte(byte value) { }

	// RVA: 0x7D3A758 Offset: 0x7D36758 VA: 0x7D3A758 Slot: 70
	public byte ReadByte() { }

	// RVA: 0x7D3A760 Offset: 0x7D36760 VA: 0x7D3A760
	public sbyte ReadSByte() { }

	// RVA: 0x7D3A768 Offset: 0x7D36768 VA: 0x7D3A768
	public void WriteSByte(sbyte value) { }

	// RVA: 0x7D3A79C Offset: 0x7D3679C VA: 0x7D3A79C
	public void WriteUShort(ushort value, int bits) { }

	// RVA: 0x7D3A820 Offset: 0x7D36820 VA: 0x7D3A820
	public ushort ReadUShort(int bits) { }

	// RVA: 0x7D3A874 Offset: 0x7D36874 VA: 0x7D3A874
	public void WriteUShort(ushort value) { }

	// RVA: 0x7D3A87C Offset: 0x7D3687C VA: 0x7D3A87C
	public ushort ReadUShort() { }

	// RVA: 0x7D3A8B4 Offset: 0x7D368B4 VA: 0x7D3A8B4
	public void WriteShort(short value, int bits) { }

	// RVA: 0x7D3A8B8 Offset: 0x7D368B8 VA: 0x7D3A8B8
	public short ReadShort(int bits) { }

	// RVA: 0x7D3A8BC Offset: 0x7D368BC VA: 0x7D3A8BC
	public void WriteShort(short value) { }

	// RVA: 0x7D3A8C4 Offset: 0x7D368C4 VA: 0x7D3A8C4
	public short ReadShort() { }

	// RVA: 0x7D3A8FC Offset: 0x7D368FC VA: 0x7D3A8FC
	public void WriteChar(char value) { }

	// RVA: 0x7D3A904 Offset: 0x7D36904 VA: 0x7D3A904
	public char ReadChar() { }

	// RVA: 0x7D3A93C Offset: 0x7D3693C VA: 0x7D3A93C
	public void WriteUInt(uint value, int bits) { }

	// RVA: 0x7D3AAA4 Offset: 0x7D36AA4 VA: 0x7D3AAA4
	public uint ReadUInt(int bits) { }

	// RVA: 0x7D3ABF0 Offset: 0x7D36BF0 VA: 0x7D3ABF0 Slot: 58
	public void WriteUInt(uint value) { }

	// RVA: 0x7D3ABF8 Offset: 0x7D36BF8 VA: 0x7D3ABF8 Slot: 59
	public uint ReadUInt() { }

	// RVA: 0x7D3AC00 Offset: 0x7D36C00 VA: 0x7D3AC00
	public void WriteInt_Shifted(int value, int bits, int shift) { }

	// RVA: 0x7D3AC0C Offset: 0x7D36C0C VA: 0x7D3AC0C
	public int ReadInt_Shifted(int bits, int shift) { }

	// RVA: 0x7D3AC08 Offset: 0x7D36C08 VA: 0x7D3AC08
	public void WriteInt(int value, int bits) { }

	// RVA: 0x7D3AC14 Offset: 0x7D36C14 VA: 0x7D3AC14
	public int ReadInt(int bits) { }

	// RVA: 0x7D3AC18 Offset: 0x7D36C18 VA: 0x7D3AC18 Slot: 57
	public void WriteInt(int value) { }

	// RVA: 0x7D3AC20 Offset: 0x7D36C20 VA: 0x7D3AC20 Slot: 56
	public int ReadInt() { }

	// RVA: 0x7D3AC28 Offset: 0x7D36C28 VA: 0x7D3AC28
	public void WriteULong(ulong value, int bits) { }

	// RVA: 0x7D3AC74 Offset: 0x7D36C74 VA: 0x7D3AC74
	public ulong ReadULong(int bits) { }

	// RVA: 0x7D3ACCC Offset: 0x7D36CCC VA: 0x7D3ACCC Slot: 69
	public void WriteULong(ulong value) { }

	// RVA: 0x7D3ACFC Offset: 0x7D36CFC VA: 0x7D3ACFC Slot: 68
	public ulong ReadULong() { }

	// RVA: 0x7D3AD38 Offset: 0x7D36D38 VA: 0x7D3AD38
	public void WriteLong(long value, int bits) { }

	// RVA: 0x7D3AD3C Offset: 0x7D36D3C VA: 0x7D3AD3C
	public long ReadLong(int bits) { }

	// RVA: 0x7D3AD40 Offset: 0x7D36D40 VA: 0x7D3AD40 Slot: 67
	public void WriteLong(long value) { }

	// RVA: 0x7D3AD70 Offset: 0x7D36D70 VA: 0x7D3AD70 Slot: 66
	public long ReadLong() { }

	// RVA: 0x7D3ADAC Offset: 0x7D36DAC VA: 0x7D3ADAC
	public void WriteFloat(float value) { }

	// RVA: 0x7D3AE54 Offset: 0x7D36E54 VA: 0x7D3AE54
	public float ReadFloat() { }

	// RVA: 0x7D3AEB4 Offset: 0x7D36EB4 VA: 0x7D3AEB4
	public void WriteDouble(double value) { }

	// RVA: 0x7D3AFEC Offset: 0x7D36FEC VA: 0x7D3AFEC
	public double ReadDouble() { }

	// RVA: 0x7D3B0A4 Offset: 0x7D370A4 VA: 0x7D3B0A4
	public void WriteByteArray(byte[] from) { }

	// RVA: 0x7D3B21C Offset: 0x7D3721C VA: 0x7D3B21C
	public void WriteByteArray(byte[] from, int count) { }

	// RVA: 0x7D3B0C0 Offset: 0x7D370C0 VA: 0x7D3B0C0
	public void WriteByteArray(byte[] from, int offset, int count) { }

	// RVA: 0x7D3B228 Offset: 0x7D37228 VA: 0x7D3B228
	public byte[] ReadByteArray(int size) { }

	// RVA: 0x7D3B294 Offset: 0x7D37294 VA: 0x7D3B294
	public void ReadByteArray(byte[] to) { }

	// RVA: 0x7D3B3B4 Offset: 0x7D373B4 VA: 0x7D3B3B4
	public void ReadByteArray(byte[] to, int count) { }

	// RVA: 0x7D3B2B0 Offset: 0x7D372B0 VA: 0x7D3B2B0
	public void ReadByteArray(byte[] to, int offset, int count) { }

	// RVA: 0x7D3B3C0 Offset: 0x7D373C0 VA: 0x7D3B3C0
	public void WriteByteArrayLengthPrefixed(byte[] array) { }

	// RVA: 0x7D3B3E4 Offset: 0x7D373E4 VA: 0x7D3B3E4
	public void WriteByteArrayLengthPrefixed(byte[] array, int maxLength) { }

	// RVA: 0x7D3B5A8 Offset: 0x7D375A8 VA: 0x7D3B5A8
	public byte[] ReadByteArrayLengthPrefixed() { }

	// RVA: 0x7D3B660 Offset: 0x7D37660 VA: 0x7D3B660
	public void WriteString(string value, Encoding encoding) { }

	// RVA: 0x7D3B6DC Offset: 0x7D376DC VA: 0x7D3B6DC
	public void WriteString(string value) { }

	// RVA: 0x7D3B70C Offset: 0x7D3770C VA: 0x7D3B70C
	public string ReadString(Encoding encoding) { }

	// RVA: 0x7D3B800 Offset: 0x7D37800 VA: 0x7D3B800
	public string ReadString() { }

	// RVA: 0x7D3B820 Offset: 0x7D37820 VA: 0x7D3B820
	public void WriteStringGZip(string value, Encoding encoding) { }

	// RVA: 0x7D3BCF4 Offset: 0x7D37CF4 VA: 0x7D3BCF4
	public string ReadStringGZip(Encoding encoding) { }

	// RVA: 0x7D3C244 Offset: 0x7D38244 VA: 0x7D3C244
	public void WriteGuid(Guid guid) { }

	// RVA: 0x7D3C278 Offset: 0x7D38278 VA: 0x7D3C278
	public Guid ReadGuid() { }

	// RVA: 0x7D3A57C Offset: 0x7D3657C VA: 0x7D3A57C
	private void InternalWriteByte(byte value, int bits) { }

	// RVA: 0x7D3C3D4 Offset: 0x7D383D4 VA: 0x7D3C3D4 Slot: 61
	public void WriteFP(FP fp) { }

	// RVA: 0x7D3C404 Offset: 0x7D38404 VA: 0x7D3C404 Slot: 60
	public FP ReadFP() { }

	// RVA: 0x7D3C440 Offset: 0x7D38440 VA: 0x7D3C440
	public void WriteNullableFP(FP fp) { }

	// RVA: 0x7D3C470 Offset: 0x7D38470 VA: 0x7D3C470 Slot: 63
	public void WriteFPVector2(FPVector2 v) { }

	// RVA: 0x7D3C4C4 Offset: 0x7D384C4 VA: 0x7D3C4C4 Slot: 62
	public FPVector2 ReadFPVector2() { }

	// RVA: 0x7D3C568 Offset: 0x7D38568 VA: 0x7D3C568 Slot: 65
	public void WriteFPVector3(FPVector3 v) { }

	// RVA: 0x7D3C5DC Offset: 0x7D385DC VA: 0x7D3C5DC Slot: 64
	public FPVector3 ReadFPVector3() { }

	// RVA: 0x7D3C680 Offset: 0x7D38680 VA: 0x7D3C680
	public void WriteFPQuaternion(FPQuaternion v) { }

	// RVA: 0x7D3C714 Offset: 0x7D38714 VA: 0x7D3C714
	public FPQuaternion ReadFPQuaternion() { }

	// RVA: 0x7D3C7E8 Offset: 0x7D387E8 VA: 0x7D3C7E8
	public void WriteFPMatrix2x2(FPMatrix2x2 v) { }

	// RVA: 0x7D3C87C Offset: 0x7D3887C VA: 0x7D3C87C
	public FPMatrix2x2 ReadFPMatrix2x2() { }

	// RVA: 0x7D3C93C Offset: 0x7D3893C VA: 0x7D3C93C
	public void WriteFPMatrix3x3(FPMatrix3x3 v) { }

	// RVA: 0x7D3CA70 Offset: 0x7D38A70 VA: 0x7D3CA70
	public FPMatrix3x3 ReadFPMatrix3x3() { }

	// RVA: 0x7D3CC00 Offset: 0x7D38C00 VA: 0x7D3CC00
	public void WriteFPMatrix4x4(FPMatrix4x4 v) { }

	// RVA: 0x7D3CE14 Offset: 0x7D38E14 VA: 0x7D3CE14
	public FPMatrix4x4 ReadFPMatrix4x4() { }

	// RVA: 0x7D3D0EC Offset: 0x7D390EC VA: 0x7D3D0EC
	public void WriteFPBounds2(FPBounds2 v) { }

	// RVA: 0x7D3D11C Offset: 0x7D3911C VA: 0x7D3D11C
	public FPBounds2 ReadFPBounds2() { }

	// RVA: 0x7D3D15C Offset: 0x7D3915C VA: 0x7D3D15C
	public void WriteFPBounds3(FPBounds3 v) { }

	// RVA: 0x7D3D1E4 Offset: 0x7D391E4 VA: 0x7D3D1E4
	public FPBounds3 ReadFPBounds3() { }

	// RVA: 0x7D3C2F4 Offset: 0x7D382F4 VA: 0x7D3C2F4
	public static void WriteByteAt(byte[] data, int ptr, int bits, byte value) { }

	// RVA: 0x7D3A624 Offset: 0x7D36624 VA: 0x7D3A624
	private byte InternalReadByte(int bits) { }

	// RVA: 0x7D3D26C Offset: 0x7D3926C VA: 0x7D3D26C Slot: 51
	public bool Condition(bool condition) { }

	// RVA: 0x7D3D2A8 Offset: 0x7D392A8 VA: 0x7D3D2A8 Slot: 10
	public void Serialize(ref string value) { }

	// RVA: 0x7D3D310 Offset: 0x7D39310 VA: 0x7D3D310 Slot: 11
	public void Serialize(ref bool value) { }

	// RVA: 0x7D3D354 Offset: 0x7D39354 VA: 0x7D3D354 Slot: 12
	public void Serialize(ref float value) { }

	// RVA: 0x7D3D380 Offset: 0x7D39380 VA: 0x7D3D380 Slot: 13
	public void Serialize(ref double value) { }

	// RVA: 0x7D3D3AC Offset: 0x7D393AC VA: 0x7D3D3AC Slot: 14
	public void Serialize(ref long value) { }

	// RVA: 0x7D3D420 Offset: 0x7D39420 VA: 0x7D3D420 Slot: 15
	public void Serialize(ref ulong value) { }

	// RVA: 0x7D3D494 Offset: 0x7D39494 VA: 0x7D3D494 Slot: 16
	public void Serialize(ref FP value) { }

	// RVA: 0x7D3D508 Offset: 0x7D39508 VA: 0x7D3D508 Slot: 17
	public void Serialize(ref FPVector2 value) { }

	// RVA: 0x7D3D534 Offset: 0x7D39534 VA: 0x7D3D534 Slot: 18
	public void Serialize(ref FPVector3 value) { }

	// RVA: 0x7D3D5B8 Offset: 0x7D395B8 VA: 0x7D3D5B8 Slot: 19
	public void Serialize(ref FPQuaternion value) { }

	// RVA: 0x7D3D628 Offset: 0x7D39628 VA: 0x7D3D628 Slot: 20
	public void Serialize(ref byte value) { }

	// RVA: 0x7D3D680 Offset: 0x7D39680 VA: 0x7D3D680 Slot: 21
	public void Serialize(ref uint value) { }

	// RVA: 0x7D3D688 Offset: 0x7D39688 VA: 0x7D3D688 Slot: 22
	public void Serialize(ref uint value, int bits) { }

	// RVA: 0x7D3D6B8 Offset: 0x7D396B8 VA: 0x7D3D6B8 Slot: 23
	public void Serialize(ref ulong value, int bits) { }

	// RVA: 0x7D3D6E8 Offset: 0x7D396E8 VA: 0x7D3D6E8 Slot: 24
	public void Serialize(ref int value) { }

	// RVA: 0x7D3D6F0 Offset: 0x7D396F0 VA: 0x7D3D6F0 Slot: 25
	public void Serialize(ref int value, int bits) { }

	// RVA: 0x7D3D720 Offset: 0x7D39720 VA: 0x7D3D720 Slot: 26
	public void Serialize(ref int[] value) { }

	// RVA: 0x7D3D8AC Offset: 0x7D398AC VA: 0x7D3D8AC Slot: 27
	public void Serialize(ref byte[] value) { }

	// RVA: 0x7D3D980 Offset: 0x7D39980 VA: 0x7D3D980 Slot: 28
	public void Serialize(ref byte[] array, ref int length) { }

	// RVA: 0x7D3DAB4 Offset: 0x7D39AB4 VA: 0x7D3DAB4 Slot: 29
	public void Serialize(ref byte[] value, int fixedSize) { }

	// RVA: 0x7D3DBA8 Offset: 0x7D39BA8 VA: 0x7D3DBA8 Slot: 30
	public void Serialize(ref byte[] array, ref int length, int fixedSize) { }

	// RVA: -1 Offset: -1 Slot: 31
	public void SerializeArrayLength<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4548D74 Offset: 0x4544D74 VA: 0x4548D74
	|-BitStream.SerializeArrayLength<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public void SerializeArray<T>(ref T[] array, BitStream.ArrayElementSerializer<T> serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4548C64 Offset: 0x4544C64 VA: 0x4548C64
	|-BitStream.SerializeArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7D3DD10 Offset: 0x7D39D10 VA: 0x7D3DD10 Slot: 33
	public void Serialize(byte* v) { }

	// RVA: 0x7D3DD68 Offset: 0x7D39D68 VA: 0x7D3DD68 Slot: 34
	public void Serialize(sbyte* v) { }

	// RVA: 0x7D3DDC0 Offset: 0x7D39DC0 VA: 0x7D3DDC0 Slot: 35
	public void Serialize(short* v) { }

	// RVA: 0x7D3DE20 Offset: 0x7D39E20 VA: 0x7D3DE20 Slot: 36
	public void Serialize(ushort* v) { }

	// RVA: 0x7D3DE80 Offset: 0x7D39E80 VA: 0x7D3DE80 Slot: 37
	public void Serialize(int* v) { }

	// RVA: 0x7D3DEB4 Offset: 0x7D39EB4 VA: 0x7D3DEB4 Slot: 38
	public void Serialize(uint* v) { }

	// RVA: 0x7D3DEE8 Offset: 0x7D39EE8 VA: 0x7D3DEE8 Slot: 39
	public void Serialize(long* v) { }

	// RVA: 0x7D3DF5C Offset: 0x7D39F5C VA: 0x7D3DF5C Slot: 40
	public void Serialize(ulong* v) { }

	// RVA: 0x7D3DFD0 Offset: 0x7D39FD0 VA: 0x7D3DFD0 Slot: 42
	public void Serialize(uint* v, int bits) { }

	// RVA: 0x7D3E000 Offset: 0x7D3A000 VA: 0x7D3E000 Slot: 41
	public void Serialize(int* v, int bits) { }

	// RVA: 0x7D3E030 Offset: 0x7D3A030 VA: 0x7D3E030 Slot: 43
	public void SerializeBuffer(byte* buffer, int length) { }

	// RVA: 0x7D3E0AC Offset: 0x7D3A0AC VA: 0x7D3E0AC Slot: 44
	public void SerializeBuffer(sbyte* buffer, int length) { }

	// RVA: 0x7D3E128 Offset: 0x7D3A128 VA: 0x7D3E128 Slot: 45
	public void SerializeBuffer(short* buffer, int length) { }

	// RVA: 0x7D3E1B0 Offset: 0x7D3A1B0 VA: 0x7D3E1B0 Slot: 46
	public void SerializeBuffer(ushort* buffer, int length) { }

	// RVA: 0x7D3E238 Offset: 0x7D3A238 VA: 0x7D3E238 Slot: 47
	public void SerializeBuffer(int* buffer, int length) { }

	// RVA: 0x7D3E2A4 Offset: 0x7D3A2A4 VA: 0x7D3E2A4 Slot: 48
	public void SerializeBuffer(uint* buffer, int length) { }

	// RVA: 0x7D3E310 Offset: 0x7D3A310 VA: 0x7D3E310 Slot: 49
	public void SerializeBuffer(long* buffer, int length) { }

	// RVA: 0x7D3E3B0 Offset: 0x7D3A3B0 VA: 0x7D3E3B0 Slot: 50
	public void SerializeBuffer(ulong* buffer, int length) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ByteUtils.<>c // TypeDefIndex: 23999
{
	// Fields
	public static readonly ByteUtils.<>c <>9; // 0x0
	public static Func<byte[], int> <>9__1_0; // 0x8
	public static Func<byte[], int> <>9__8_0; // 0x10

	// Methods

	// RVA: 0x7D3F7C8 Offset: 0x7D3B7C8 VA: 0x7D3F7C8
	private static void .cctor() { }

	// RVA: 0x7D3F830 Offset: 0x7D3B830 VA: 0x7D3F830
	public void .ctor() { }

	// RVA: 0x7D3F838 Offset: 0x7D3B838 VA: 0x7D3F838
	internal int <MergeByteBlocks>b__1_0(byte[] x) { }

	// RVA: 0x7D3F850 Offset: 0x7D3B850 VA: 0x7D3F850
	internal int <PackByteBlocks>b__8_0(byte[] x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ByteUtils.<ReadByteBlocks>d__9 : IEnumerable<byte[]>, IEnumerable, IEnumerator<byte[]>, IEnumerator, IDisposable // TypeDefIndex: 24000
{
	// Fields
	private int <>1__state; // 0x10
	private byte[] <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private byte[] data; // 0x28
	public byte[] <>3__data; // 0x30
	private int <dataOffset2>5__2; // 0x38

	// Properties
	private byte[] System.Collections.Generic.IEnumerator<System.Byte[]>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7D3EAB8 Offset: 0x7D3AAB8 VA: 0x7D3EAB8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7D3F868 Offset: 0x7D3B868 VA: 0x7D3F868 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D3F86C Offset: 0x7D3B86C VA: 0x7D3F86C Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7D3F968 Offset: 0x7D3B968 VA: 0x7D3F968 Slot: 6
	private byte[] System.Collections.Generic.IEnumerator<System.Byte[]>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D3F970 Offset: 0x7D3B970 VA: 0x7D3F970 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7D3F9A8 Offset: 0x7D3B9A8 VA: 0x7D3F9A8 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7D3F9B0 Offset: 0x7D3B9B0 VA: 0x7D3F9B0 Slot: 4
	private IEnumerator<byte[]> System.Collections.Generic.IEnumerable<System.Byte[]>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7D3FA54 Offset: 0x7D3BA54 VA: 0x7D3FA54 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Photon.Deterministic
public class ByteUtils // TypeDefIndex: 24001
{
	// Methods

	// RVA: 0x7D3E450 Offset: 0x7D3A450 VA: 0x7D3E450
	public static byte[] ToByteArray(byte* ptr, int length) { }

	// RVA: 0x7D3E4EC Offset: 0x7D3A4EC VA: 0x7D3E4EC
	public static byte[] MergeByteBlocks(byte[][] blocks) { }

	// RVA: 0x7D3E698 Offset: 0x7D3A698 VA: 0x7D3E698
	public static int AddValueBlock(int value, byte[] buffer, int offset) { }

	// RVA: 0x7D3E704 Offset: 0x7D3A704 VA: 0x7D3E704
	public static int AddValueBlock(long value, byte[] buffer, int offset) { }

	// RVA: 0x7D3E770 Offset: 0x7D3A770 VA: 0x7D3E770
	public static int AddValueBlock(ulong value, byte[] buffer, int offset) { }

	// RVA: 0x7D3E7B0 Offset: 0x7D3A7B0 VA: 0x7D3E7B0
	public static int AddByteBlock(byte[] block, byte[] buffer, int offset) { }

	// RVA: 0x7D3E824 Offset: 0x7D3A824 VA: 0x7D3E824
	public static int BeginByteBlockHeader(byte[] buffer, int offset, out int blockStart) { }

	// RVA: 0x7D3E830 Offset: 0x7D3A830 VA: 0x7D3E830
	public static int EndByteBlockHeader(byte[] buffer, int blockStart, int bytesWritten) { }

	// RVA: 0x7D3E858 Offset: 0x7D3A858 VA: 0x7D3E858
	public static byte[] PackByteBlocks(byte[][] blocks) { }

	[IteratorStateMachine(typeof(ByteUtils.<ReadByteBlocks>d__9))]
	// RVA: 0x7D3EA3C Offset: 0x7D3AA3C VA: 0x7D3EA3C
	public static IEnumerable<byte[]> ReadByteBlocks(byte[] data) { }

	// RVA: 0x7D3EAEC Offset: 0x7D3AAEC VA: 0x7D3EAEC
	public static string PrintBits(Array array, int offset, int length) { }

	// RVA: 0x7D3EC2C Offset: 0x7D3AC2C VA: 0x7D3EC2C
	private static void CopyTo(Stream source, Stream destination) { }

	// RVA: 0x7D3ED04 Offset: 0x7D3AD04 VA: 0x7D3ED04
	public static string Base64EncodeString(string data, Encoding encoding) { }

	// RVA: 0x7D3ED8C Offset: 0x7D3AD8C VA: 0x7D3ED8C
	public static string Base64DecodeString(string data, Encoding encoding) { }

	// RVA: 0x7D3ED34 Offset: 0x7D3AD34 VA: 0x7D3ED34
	public static string Base64Encode(byte[] data) { }

	// RVA: 0x7D3EDBC Offset: 0x7D3ADBC VA: 0x7D3EDBC
	public static byte[] Base64Decode(string data) { }

	// RVA: 0x7D3EE14 Offset: 0x7D3AE14 VA: 0x7D3EE14
	public static byte[] GZipCompressBytes(byte[] data) { }

	// RVA: 0x7D3EFE0 Offset: 0x7D3AFE0 VA: 0x7D3EFE0
	public static void GZipCompressBytes(byte[] data, int offset, int size, Stream output) { }

	// RVA: 0x7D3F188 Offset: 0x7D3B188 VA: 0x7D3F188
	public static void GZipCompressBytes(Stream input, Stream output) { }

	// RVA: 0x7D3F2F8 Offset: 0x7D3B2F8 VA: 0x7D3F2F8
	public static GZipStream CreateGZipCompressStream(Stream output) { }

	// RVA: 0x7D3F35C Offset: 0x7D3B35C VA: 0x7D3F35C
	public static byte[] GZipDecompressBytes(byte[] data) { }

	// RVA: 0x7D3B88C Offset: 0x7D3788C VA: 0x7D3B88C
	public static byte[] GZipCompressString(string data, Encoding encoding) { }

	// RVA: 0x7D3BDC8 Offset: 0x7D37DC8 VA: 0x7D3BDC8
	public static string GZipDecompressString(byte[] data, Encoding encoding) { }

	// RVA: 0x7D3E748 Offset: 0x7D3A748 VA: 0x7D3E748
	public static int WriteBytes(long value, byte[] array, int offset) { }

	// RVA: 0x7D3F798 Offset: 0x7D3B798 VA: 0x7D3F798
	public static int WriteBytes(ulong value, byte[] array, int offset) { }

	// RVA: 0x7D3E6DC Offset: 0x7D3A6DC VA: 0x7D3E6DC
	public static int WriteBytes(int value, byte[] array, int offset) { }

	// RVA: 0x7D3F7C0 Offset: 0x7D3B7C0 VA: 0x7D3F7C0
	public void .ctor() { }
}

// Namespace: Photon.Deterministic
public static class CRC64 // TypeDefIndex: 24002
{
	// Fields
	private static readonly ulong[] crc64_tab; // 0x0

	// Methods

	// RVA: 0x7D3FA58 Offset: 0x7D3BA58 VA: 0x7D3FA58
	public static ulong Calculate(ulong crc, void* data, int dataLength) { }

	// RVA: 0x7D3FB10 Offset: 0x7D3BB10 VA: 0x7D3FB10
	private static void .cctor() { }
}

// Namespace: Photon.Deterministic
public abstract class DeterministicFrame // TypeDefIndex: 24003
{
	// Fields
	public const int DumpFlag_NoHeap = 1;
	internal bool Verified; // 0x10
	public int Number; // 0x14

	// Properties
	public bool IsVerified { get; }
	public bool IsPredicted { get; }

	// Methods

	// RVA: 0x7D3FBB0 Offset: 0x7D3BBB0 VA: 0x7D3FBB0
	public bool get_IsVerified() { }

	// RVA: 0x7D3FBB8 Offset: 0x7D3BBB8 VA: 0x7D3FBB8
	public bool get_IsPredicted() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Free();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string DumpFrame(int dumpFlags = 0);

	// RVA: 0x7D3FBC8 Offset: 0x7D3BBC8 VA: 0x7D3FBC8
	public void CopyFrom(DeterministicFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void Copy(DeterministicFrame frame);

	// RVA: 0x7D3FC00 Offset: 0x7D3BC00 VA: 0x7D3FC00
	protected void .ctor() { }
}

// Namespace: Photon.Deterministic
public enum DeterministicFrameSerializeMode // TypeDefIndex: 24004
{
	// Fields
	public int value__; // 0x0
	public const DeterministicFrameSerializeMode Serialize = 0;
	public const DeterministicFrameSerializeMode Blit = 1;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DeterministicLog.<>c // TypeDefIndex: 24005
{
	// Fields
	public static readonly DeterministicLog.<>c <>9; // 0x0
	public static Action<string> <>9__0_0; // 0x8
	public static Action<string> <>9__0_1; // 0x10
	public static Action<string> <>9__0_2; // 0x18
	public static Action<Exception> <>9__0_3; // 0x20

	// Methods

	// RVA: 0x7D3FEA0 Offset: 0x7D3BEA0 VA: 0x7D3FEA0
	private static void .cctor() { }

	// RVA: 0x7D3FF08 Offset: 0x7D3BF08 VA: 0x7D3FF08
	public void .ctor() { }

	// RVA: 0x7D3FF10 Offset: 0x7D3BF10 VA: 0x7D3FF10
	internal void <InitForConsole>b__0_0(string info) { }

	// RVA: 0x7D3FF80 Offset: 0x7D3BF80 VA: 0x7D3FF80
	internal void <InitForConsole>b__0_1(string warn) { }

	// RVA: 0x7D3FFF0 Offset: 0x7D3BFF0 VA: 0x7D3FFF0
	internal void <InitForConsole>b__0_2(string error) { }

	// RVA: 0x7D40060 Offset: 0x7D3C060 VA: 0x7D40060
	internal void <InitForConsole>b__0_3(Exception exn) { }
}

// Namespace: Photon.Deterministic
public static class DeterministicLog // TypeDefIndex: 24006
{
	// Methods

	// RVA: 0x7D3FC08 Offset: 0x7D3BC08 VA: 0x7D3FC08
	public static void InitForConsole() { }

	// RVA: 0x7D3FE90 Offset: 0x7D3BE90 VA: 0x7D3FE90
	public static void Init(Action<string> info, Action<string> warn, Action<string> error, Action<Exception> exn) { }

	// RVA: 0x7D3FE98 Offset: 0x7D3BE98 VA: 0x7D3FE98
	public static void Reset() { }
}

// Namespace: 
public enum DeterministicPlatformInfo.Architectures // TypeDefIndex: 24007
{
	// Fields
	public int value__; // 0x0
	public const DeterministicPlatformInfo.Architectures ARMv7 = 0;
	public const DeterministicPlatformInfo.Architectures ARM64 = 1;
	public const DeterministicPlatformInfo.Architectures x86 = 2;
}

// Namespace: 
public enum DeterministicPlatformInfo.Runtimes // TypeDefIndex: 24008
{
	// Fields
	public int value__; // 0x0
	public const DeterministicPlatformInfo.Runtimes NetFramework = 0;
	public const DeterministicPlatformInfo.Runtimes NetCore = 1;
	public const DeterministicPlatformInfo.Runtimes Mono = 2;
	public const DeterministicPlatformInfo.Runtimes IL2CPP = 3;
}

// Namespace: 
public enum DeterministicPlatformInfo.RuntimeHosts // TypeDefIndex: 24009
{
	// Fields
	public int value__; // 0x0
	public const DeterministicPlatformInfo.RuntimeHosts Unity = 0;
	public const DeterministicPlatformInfo.RuntimeHosts UnityEditor = 1;
	public const DeterministicPlatformInfo.RuntimeHosts PhotonServer = 2;
	public const DeterministicPlatformInfo.RuntimeHosts NetApplication = 3;
}

// Namespace: 
public enum DeterministicPlatformInfo.Platforms // TypeDefIndex: 24010
{
	// Fields
	public int value__; // 0x0
	public const DeterministicPlatformInfo.Platforms Windows = 0;
	public const DeterministicPlatformInfo.Platforms OSX = 1;
	public const DeterministicPlatformInfo.Platforms Linux = 2;
	public const DeterministicPlatformInfo.Platforms IOS = 3;
	public const DeterministicPlatformInfo.Platforms Android = 4;
	public const DeterministicPlatformInfo.Platforms XboxOne = 5;
	public const DeterministicPlatformInfo.Platforms PlayStation4 = 6;
	public const DeterministicPlatformInfo.Platforms Switch = 7;
	public const DeterministicPlatformInfo.Platforms TVOS = 8;
}

// Namespace: Photon.Deterministic
public class DeterministicPlatformInfo // TypeDefIndex: 24011
{
	// Fields
	public DeterministicPlatformInfo.Architectures Architecture; // 0x10
	public DeterministicPlatformInfo.Platforms Platform; // 0x14
	public DeterministicPlatformInfo.RuntimeHosts RuntimeHost; // 0x18
	public DeterministicPlatformInfo.Runtimes Runtime; // 0x1C
	public Native.Allocator Allocator; // 0x20
	public int CoreCount; // 0x28
	public IDeterministicPlatformTaskRunner TaskRunner; // 0x30

	// Methods

	// RVA: 0x7D400FC Offset: 0x7D3C0FC VA: 0x7D400FC Slot: 3
	public override string ToString() { }

	// RVA: 0x7D403AC Offset: 0x7D3C3AC VA: 0x7D403AC
	public void .ctor() { }
}

// Namespace: Photon.Deterministic
public class DeterministicSession // TypeDefIndex: 24012
{
	// Fields
	private byte[] _runtimeConfig; // 0x10
	private byte[] _runtimeConfigLocal; // 0x18
	private DeterministicSessionConfig _sessionConfig; // 0x20
	private DeterministicSessionConfig _sessionConfigLocal; // 0x28
	private HashSet<int> _localPlayersSet; // 0x30
	private IDisposable _frameContext; // 0x38
	private DeterministicSimulator _simulator; // 0x40
	private DeterministicStats _stats; // 0x48
	private IDeterministicGame _game; // 0x50
	[CompilerGenerated]
	private int <MaxVerifiedTicksPerUpdate>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly DeterministicPlatformInfo <PlatformInfo>k__BackingField; // 0x60
	[CompilerGenerated]
	private IDisposable <Runner>k__BackingField; // 0x68

	// Properties
	public int MaxVerifiedTicksPerUpdate { get; set; }
	public byte[] RuntimeConfig { get; }
	public DeterministicStats Stats { get; }
	public IDeterministicGame Game { get; }
	public DeterministicFrame FrameVerified { get; }
	public DeterministicSessionConfig SessionConfig { get; }
	public FP DeltaTime { get; }
	public DeterministicPlatformInfo PlatformInfo { get; }
	public IDisposable Runner { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D403B4 Offset: 0x7D3C3B4 VA: 0x7D403B4
	public int get_MaxVerifiedTicksPerUpdate() { }

	[CompilerGenerated]
	// RVA: 0x7D403BC Offset: 0x7D3C3BC VA: 0x7D403BC
	public void set_MaxVerifiedTicksPerUpdate(int value) { }

	// RVA: 0x7D403C4 Offset: 0x7D3C3C4 VA: 0x7D403C4
	public byte[] get_RuntimeConfig() { }

	// RVA: 0x7D403CC Offset: 0x7D3C3CC VA: 0x7D403CC
	public DeterministicStats get_Stats() { }

	// RVA: 0x7D403D4 Offset: 0x7D3C3D4 VA: 0x7D403D4
	public IDeterministicGame get_Game() { }

	// RVA: 0x7D403DC Offset: 0x7D3C3DC VA: 0x7D403DC
	public DeterministicFrame get_FrameVerified() { }

	// RVA: 0x7D403F8 Offset: 0x7D3C3F8 VA: 0x7D403F8
	public DeterministicSessionConfig get_SessionConfig() { }

	// RVA: 0x7D40400 Offset: 0x7D3C400 VA: 0x7D40400
	public FP get_DeltaTime() { }

	[CompilerGenerated]
	// RVA: 0x7D40434 Offset: 0x7D3C434 VA: 0x7D40434
	public DeterministicPlatformInfo get_PlatformInfo() { }

	[CompilerGenerated]
	// RVA: 0x7D4043C Offset: 0x7D3C43C VA: 0x7D4043C
	public IDisposable get_Runner() { }

	[CompilerGenerated]
	// RVA: 0x7D40444 Offset: 0x7D3C444 VA: 0x7D40444
	public void set_Runner(IDisposable value) { }

	// RVA: 0x7D4044C Offset: 0x7D3C44C VA: 0x7D4044C
	public void SimulationStart() { }

	// RVA: 0x7D406DC Offset: 0x7D3C6DC VA: 0x7D406DC
	public void .ctor(DeterministicSessionArgs args) { }

	// RVA: 0x7D408B8 Offset: 0x7D3C8B8 VA: 0x7D408B8
	public void GetLocalConfigs(out DeterministicSessionConfig sessionConfig, out byte[] runtimeConfig) { }

	// RVA: 0x7D408F4 Offset: 0x7D3C8F4 VA: 0x7D408F4
	public void Destroy() { }

	// RVA: 0x7D40CF0 Offset: 0x7D3CCF0 VA: 0x7D40CF0
	public void Update() { }

	// RVA: 0x7D40D08 Offset: 0x7D3CD08 VA: 0x7D40D08
	private void UpdateSimulation() { }

	// RVA: 0x7D40D20 Offset: 0x7D3CD20 VA: 0x7D40D20
	private void UpdateSimulationInner() { }

	// RVA: 0x7D40E38 Offset: 0x7D3CE38 VA: 0x7D40E38
	private void CallOnUpdateDone() { }
}

// Namespace: Photon.Deterministic
public struct DeterministicSessionArgs // TypeDefIndex: 24013
{
	// Fields
	public DeterministicSessionConfig SessionConfig; // 0x0
	public IDeterministicGame Game; // 0x8
	public DeterministicPlatformInfo PlatformInfo; // 0x10
	public byte[] RuntimeConfig; // 0x18
}

// Namespace: Photon.Deterministic
[Serializable]
public class DeterministicSessionConfig // TypeDefIndex: 24014
{
	// Fields
	public int updateFPS; // 0x10

	// Methods

	// RVA: 0x7D40F6C Offset: 0x7D3CF6C VA: 0x7D40F6C
	public static byte[] ToByteArray(DeterministicSessionConfig instance) { }

	// RVA: 0x7D41078 Offset: 0x7D3D078 VA: 0x7D41078
	public static DeterministicSessionConfig FromByteArray(byte[] data) { }

	// RVA: 0x7D40FE4 Offset: 0x7D3CFE4 VA: 0x7D40FE4
	public static void Serialize(BitStream stream, ref DeterministicSessionConfig config) { }

	// RVA: 0x7D410F4 Offset: 0x7D3D0F4 VA: 0x7D410F4
	public void .ctor() { }
}

// Namespace: Photon.Deterministic
internal class DeterministicSimulator // TypeDefIndex: 24015
{
	// Fields
	private DeterministicSession _session; // 0x10
	private DeterministicFrame _stateVerified; // 0x18

	// Properties
	public DeterministicFrame FrameVerified { get; }

	// Methods

	// RVA: 0x7D41104 Offset: 0x7D3D104 VA: 0x7D41104
	public DeterministicFrame get_FrameVerified() { }

	// RVA: 0x7D4110C Offset: 0x7D3D10C VA: 0x7D4110C
	public void GetLocalConfigs(out DeterministicSessionConfig sessionConfig, out byte[] runtimeConfig) { }

	// RVA: 0x7D40888 Offset: 0x7D3C888 VA: 0x7D40888
	public void .ctor(DeterministicSession session) { }

	// RVA: 0x7D41150 Offset: 0x7D3D150 VA: 0x7D41150
	public DeterministicFrame CreateStateFrame(IDisposable context, int number) { }

	// RVA: 0x7D40F64 Offset: 0x7D3CF64 VA: 0x7D40F64
	public void Simulate() { }

	// RVA: 0x7D406D8 Offset: 0x7D3C6D8 VA: 0x7D406D8
	public void OnGameStart() { }

	// RVA: 0x7D406B4 Offset: 0x7D3C6B4 VA: 0x7D406B4
	public void Initialize(IDisposable context) { }

	// RVA: 0x7D4122C Offset: 0x7D3D22C VA: 0x7D4122C
	public void Reset(DeterministicFrame frame, bool resetInputFrame) { }

	// RVA: 0x7D41288 Offset: 0x7D3D288 VA: 0x7D41288
	private void Simulate(DeterministicFrame state) { }

	// RVA: 0x7D41224 Offset: 0x7D3D224 VA: 0x7D41224
	private void SimulateVerified() { }

	// RVA: 0x7D4123C Offset: 0x7D3D23C VA: 0x7D4123C
	private void ResetStateFrame(DeterministicFrame target, DeterministicFrame source) { }

	// RVA: 0x7D40CD8 Offset: 0x7D3CCD8 VA: 0x7D40CD8
	public void Destroy() { }
}

// Namespace: Photon.Deterministic
internal static class DeterministicSimulatorUtils // TypeDefIndex: 24016
{
	// Methods

	// RVA: 0x7D41614 Offset: 0x7D3D614 VA: 0x7D41614
	public static int CalculateFramesThatWillBeSimulated(double acc, double delta) { }

	// RVA: 0x7D412CC Offset: 0x7D3D2CC VA: 0x7D412CC
	public static void CallSimulate(DeterministicFrame f, IDeterministicGame game) { }

	// RVA: 0x7D41470 Offset: 0x7D3D470 VA: 0x7D41470
	public static void CallSimulateFinished(DeterministicFrame f, IDeterministicGame game) { }

	// RVA: 0x7D41634 Offset: 0x7D3D634 VA: 0x7D41634
	private static bool IsAllZero(byte[] array) { }

	// RVA: 0x7D41688 Offset: 0x7D3D688 VA: 0x7D41688
	public static bool InputIsIdentical(byte[] a, byte[] b) { }
}

// Namespace: Photon.Deterministic
public class DeterministicStats // TypeDefIndex: 24017
{
	// Fields
	[CompilerGenerated]
	private int <Ping>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Frame>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <Offset>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <Predicted>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <ResimulatedFrames>k__BackingField; // 0x20
	[CompilerGenerated]
	private double <UpdateTime>k__BackingField; // 0x28

	// Properties
	public int Ping { get; set; }
	public int Frame { get; set; }
	public int Offset { get; set; }
	public int Predicted { get; set; }
	public int ResimulatedFrames { get; set; }
	public double UpdateTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D41720 Offset: 0x7D3D720 VA: 0x7D41720
	public int get_Ping() { }

	[CompilerGenerated]
	// RVA: 0x7D41728 Offset: 0x7D3D728 VA: 0x7D41728
	internal void set_Ping(int value) { }

	[CompilerGenerated]
	// RVA: 0x7D41730 Offset: 0x7D3D730 VA: 0x7D41730
	public int get_Frame() { }

	[CompilerGenerated]
	// RVA: 0x7D41738 Offset: 0x7D3D738 VA: 0x7D41738
	internal void set_Frame(int value) { }

	[CompilerGenerated]
	// RVA: 0x7D41740 Offset: 0x7D3D740 VA: 0x7D41740
	public int get_Offset() { }

	[CompilerGenerated]
	// RVA: 0x7D41748 Offset: 0x7D3D748 VA: 0x7D41748
	internal void set_Offset(int value) { }

	[CompilerGenerated]
	// RVA: 0x7D41750 Offset: 0x7D3D750 VA: 0x7D41750
	public int get_Predicted() { }

	[CompilerGenerated]
	// RVA: 0x7D41758 Offset: 0x7D3D758 VA: 0x7D41758
	internal void set_Predicted(int value) { }

	[CompilerGenerated]
	// RVA: 0x7D41760 Offset: 0x7D3D760 VA: 0x7D41760
	public int get_ResimulatedFrames() { }

	[CompilerGenerated]
	// RVA: 0x7D41768 Offset: 0x7D3D768 VA: 0x7D41768
	internal void set_ResimulatedFrames(int value) { }

	[CompilerGenerated]
	// RVA: 0x7D41770 Offset: 0x7D3D770 VA: 0x7D41770
	public double get_UpdateTime() { }

	[CompilerGenerated]
	// RVA: 0x7D41778 Offset: 0x7D3D778 VA: 0x7D41778
	internal void set_UpdateTime(double value) { }

	// RVA: 0x7D406AC Offset: 0x7D3C6AC VA: 0x7D406AC
	public void .ctor() { }
}

// Namespace: 
public static class FP.Raw // TypeDefIndex: 24018
{
	// Fields
	public const long SmallestNonZero = 1;
	public const long MinValue = -9223372036854775808;
	public const long MaxValue = 9223372036854775807;
	public const long UseableMin = -2147483648;
	public const long UseableMax = 2147483647;
	public const long Pi = 205887;
	public const long PiInv = 20860;
	public const long PiTimes2 = 411774;
	public const long PiOver2 = 102943;
	public const long PiOver2Inv = 41721;
	public const long PiOver4 = 51471;
	public const long Pi3Over4 = 154415;
	public const long Deg2Rad = 1143;
	public const long Rad2Deg = 3754936;
	public const long _0 = 0;
	public const long _1 = 65536;
	public const long _2 = 131072;
	public const long _3 = 196608;
	public const long _4 = 262144;
	public const long _5 = 327680;
	public const long _6 = 393216;
	public const long _7 = 458752;
	public const long _8 = 524288;
	public const long _9 = 589824;
	public const long _10 = 655360;
	public const long _99 = 6488064;
	public const long _100 = 6553600;
	public const long _200 = 13107200;
	public const long _1000 = 65536000;
	public const long _10000 = 655360000;
	public const long _0_01 = 655;
	public const long _0_02 = 1310;
	public const long _0_10 = 6553;
	public const long _0_20 = 13107;
	public const long _0_25 = 16384;
	public const long _0_50 = 32768;
	public const long _0_75 = 49152;
	public const long _0_03 = 1965;
	public const long _0_04 = 2620;
	public const long _0_05 = 3275;
	public const long _0_33 = 21845;
	public const long _0_99 = 64881;
	public const long Minus_1 = -65536;
	public const long Rad_180 = 205887;
	public const long Rad_90 = 102943;
	public const long Rad_45 = 51471;
	public const long Rad_22_50 = 25735;
	public const long _1_01 = 66191;
	public const long _1_02 = 66846;
	public const long _1_03 = 67502;
	public const long _1_04 = 68157;
	public const long _1_05 = 68812;
	public const long _1_10 = 72089;
	public const long _1_20 = 78643;
	public const long _1_25 = 81920;
	public const long _1_50 = 98304;
	public const long _1_75 = 114688;
	public const long _1_33 = 87381;
	public const long _1_99 = 130417;
	public const long EN1 = 6553;
	public const long EN2 = 655;
	public const long EN3 = 65;
	public const long EN4 = 6;
	public const long EN5 = 0;
	public const long Epsilon = 65;
	public const long E = 178145;
	public const long Log2_E = 94548;
	public const long Log2_10 = 217705;
}

// Namespace: 
public class FP.Comparer : IComparer<FP> // TypeDefIndex: 24019
{
	// Fields
	public static readonly FP.Comparer Instance; // 0x0

	// Methods

	// RVA: 0x7D42634 Offset: 0x7D3E634 VA: 0x7D42634
	private void .ctor() { }

	// RVA: 0x7D4263C Offset: 0x7D3E63C VA: 0x7D4263C Slot: 4
	private int System.Collections.Generic.IComparer<Photon.Deterministic.FP>.Compare(FP x, FP y) { }

	// RVA: 0x7D4265C Offset: 0x7D3E65C VA: 0x7D4265C
	private static void .cctor() { }
}

// Namespace: 
public class FP.EqualityComparer : IEqualityComparer<FP> // TypeDefIndex: 24020
{
	// Fields
	public static readonly FP.EqualityComparer Instance; // 0x0

	// Methods

	// RVA: 0x7D426C4 Offset: 0x7D3E6C4 VA: 0x7D426C4
	private void .ctor() { }

	// RVA: 0x7D426CC Offset: 0x7D3E6CC VA: 0x7D426CC Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<Photon.Deterministic.FP>.Equals(FP x, FP y) { }

	// RVA: 0x7D426D8 Offset: 0x7D3E6D8 VA: 0x7D426D8 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<Photon.Deterministic.FP>.GetHashCode(FP num) { }

	// RVA: 0x7D426F4 Offset: 0x7D3E6F4 VA: 0x7D426F4
	private static void .cctor() { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct FP : IEquatable<FP>, IComparable<FP> // TypeDefIndex: 24021
{
	// Fields
	public const int SIZE = 8;
	private const int FRACTIONS_COUNT = 5;
	public const long RAW_ONE = 65536;
	public const long RAW_ZERO = 0;
	public const int Precision = 16;
	public const int Bits = 64;
	public const long MulRound = 0;
	public const int MulShift = 16;
	public const int MulShiftTrunc = 16;
	internal const bool UsesRoundedConstants = False;
	public long RawValue; // 0x0

	// Properties
	public static FP SmallestNonZero { get; }
	public static FP MinValue { get; }
	public static FP MaxValue { get; }
	public static FP UseableMin { get; }
	public static FP UseableMax { get; }
	public static FP Pi { get; }
	public static FP PiInv { get; }
	public static FP PiTimes2 { get; }
	public static FP PiOver2 { get; }
	public static FP PiOver2Inv { get; }
	public static FP PiOver4 { get; }
	public static FP Pi3Over4 { get; }
	public static FP Deg2Rad { get; }
	public static FP Rad2Deg { get; }
	public static FP _0 { get; }
	public static FP _1 { get; }
	public static FP _2 { get; }
	public static FP _3 { get; }
	public static FP _4 { get; }
	public static FP _5 { get; }
	public static FP _6 { get; }
	public static FP _7 { get; }
	public static FP _8 { get; }
	public static FP _9 { get; }
	public static FP _10 { get; }
	public static FP _20 { get; }
	public static FP _30 { get; }
	public static FP _40 { get; }
	public static FP _99 { get; }
	public static FP _100 { get; }
	public static FP _18 { get; }
	public static FP _180 { get; }
	public static FP _200 { get; }
	public static FP _60 { get; }
	public static FP _360 { get; }
	public static FP _1000 { get; }
	public static FP _10000 { get; }
	public static FP _0_001 { get; }
	public static FP _0_01 { get; }
	public static FP _0_02 { get; }
	public static FP _0_06 { get; }
	public static FP _0_13 { get; }
	public static FP _0_15 { get; }
	public static FP _0_16 { get; }
	public static FP _0_22 { get; }
	public static FP _0_39 { get; }
	public static FP _0_10 { get; }
	public static FP _0_20 { get; }
	public static FP _0_25 { get; }
	public static FP _0_40 { get; }
	public static FP _0_50 { get; }
	public static FP _0_75 { get; }
	public static FP _0_80 { get; }
	public static FP _0_03 { get; }
	public static FP _0_04 { get; }
	public static FP _0_05 { get; }
	public static FP _0_30 { get; }
	public static FP _0_33 { get; }
	public static FP _0_90 { get; }
	public static FP _0_99 { get; }
	public static FP Minus_1 { get; }
	public static FP Rad_180 { get; }
	public static FP Rad_90 { get; }
	public static FP Rad_45 { get; }
	public static FP Rad_22_50 { get; }
	public static FP _1_01 { get; }
	public static FP _1_02 { get; }
	public static FP _1_03 { get; }
	public static FP _1_04 { get; }
	public static FP _1_05 { get; }
	public static FP _1_10 { get; }
	public static FP _1_20 { get; }
	public static FP _1_25 { get; }
	public static FP _1_50 { get; }
	public static FP _1_75 { get; }
	public static FP _1_30 { get; }
	public static FP _1_33 { get; }
	public static FP _1_99 { get; }
	public static FP EN1 { get; }
	public static FP EN2 { get; }
	public static FP EN3 { get; }
	public static FP EN4 { get; }
	public static FP EN5 { get; }
	public static FP Epsilon { get; }
	public static FP E { get; }
	public static FP Log2_E { get; }
	public static FP Log2_10 { get; }
	public long AsLong { get; }
	public int AsInt { get; }
	public short AsShort { get; }
	public float AsFloat { get; }
	public double AsDouble { get; }

	// Methods

	// RVA: 0x7D41780 Offset: 0x7D3D780 VA: 0x7D41780
	public static FP get_SmallestNonZero() { }

	// RVA: 0x7D41788 Offset: 0x7D3D788 VA: 0x7D41788
	public static FP get_MinValue() { }

	// RVA: 0x7D41790 Offset: 0x7D3D790 VA: 0x7D41790
	public static FP get_MaxValue() { }

	// RVA: 0x7D41798 Offset: 0x7D3D798 VA: 0x7D41798
	public static FP get_UseableMin() { }

	// RVA: 0x7D417A0 Offset: 0x7D3D7A0 VA: 0x7D417A0
	public static FP get_UseableMax() { }

	// RVA: 0x7D417A8 Offset: 0x7D3D7A8 VA: 0x7D417A8
	public static FP get_Pi() { }

	// RVA: 0x7D417B4 Offset: 0x7D3D7B4 VA: 0x7D417B4
	public static FP get_PiInv() { }

	// RVA: 0x7D417BC Offset: 0x7D3D7BC VA: 0x7D417BC
	public static FP get_PiTimes2() { }

	// RVA: 0x7D417C8 Offset: 0x7D3D7C8 VA: 0x7D417C8
	public static FP get_PiOver2() { }

	// RVA: 0x7D417D4 Offset: 0x7D3D7D4 VA: 0x7D417D4
	public static FP get_PiOver2Inv() { }

	// RVA: 0x7D417DC Offset: 0x7D3D7DC VA: 0x7D417DC
	public static FP get_PiOver4() { }

	// RVA: 0x7D417E4 Offset: 0x7D3D7E4 VA: 0x7D417E4
	public static FP get_Pi3Over4() { }

	// RVA: 0x7D417F0 Offset: 0x7D3D7F0 VA: 0x7D417F0
	public static FP get_Deg2Rad() { }

	// RVA: 0x7D417F8 Offset: 0x7D3D7F8 VA: 0x7D417F8
	public static FP get_Rad2Deg() { }

	// RVA: 0x7D41804 Offset: 0x7D3D804 VA: 0x7D41804
	public static FP get__0() { }

	// RVA: 0x7D4180C Offset: 0x7D3D80C VA: 0x7D4180C
	public static FP get__1() { }

	// RVA: 0x7D41814 Offset: 0x7D3D814 VA: 0x7D41814
	public static FP get__2() { }

	// RVA: 0x7D4181C Offset: 0x7D3D81C VA: 0x7D4181C
	public static FP get__3() { }

	// RVA: 0x7D41824 Offset: 0x7D3D824 VA: 0x7D41824
	public static FP get__4() { }

	// RVA: 0x7D4182C Offset: 0x7D3D82C VA: 0x7D4182C
	public static FP get__5() { }

	// RVA: 0x7D41834 Offset: 0x7D3D834 VA: 0x7D41834
	public static FP get__6() { }

	// RVA: 0x7D4183C Offset: 0x7D3D83C VA: 0x7D4183C
	public static FP get__7() { }

	// RVA: 0x7D41844 Offset: 0x7D3D844 VA: 0x7D41844
	public static FP get__8() { }

	// RVA: 0x7D4184C Offset: 0x7D3D84C VA: 0x7D4184C
	public static FP get__9() { }

	// RVA: 0x7D41854 Offset: 0x7D3D854 VA: 0x7D41854
	public static FP get__10() { }

	// RVA: 0x7D4185C Offset: 0x7D3D85C VA: 0x7D4185C
	public static FP get__20() { }

	// RVA: 0x7D41864 Offset: 0x7D3D864 VA: 0x7D41864
	public static FP get__30() { }

	// RVA: 0x7D4186C Offset: 0x7D3D86C VA: 0x7D4186C
	public static FP get__40() { }

	// RVA: 0x7D41874 Offset: 0x7D3D874 VA: 0x7D41874
	public static FP get__99() { }

	// RVA: 0x7D4187C Offset: 0x7D3D87C VA: 0x7D4187C
	public static FP get__100() { }

	// RVA: 0x7D41884 Offset: 0x7D3D884 VA: 0x7D41884
	public static FP get__18() { }

	// RVA: 0x7D4188C Offset: 0x7D3D88C VA: 0x7D4188C
	public static FP get__180() { }

	// RVA: 0x7D41894 Offset: 0x7D3D894 VA: 0x7D41894
	public static FP get__200() { }

	// RVA: 0x7D4189C Offset: 0x7D3D89C VA: 0x7D4189C
	public static FP get__60() { }

	// RVA: 0x7D418A4 Offset: 0x7D3D8A4 VA: 0x7D418A4
	public static FP get__360() { }

	// RVA: 0x7D418AC Offset: 0x7D3D8AC VA: 0x7D418AC
	public static FP get__1000() { }

	// RVA: 0x7D418B4 Offset: 0x7D3D8B4 VA: 0x7D418B4
	public static FP get__10000() { }

	// RVA: 0x7D418BC Offset: 0x7D3D8BC VA: 0x7D418BC
	public static FP get__0_001() { }

	// RVA: 0x7D418C4 Offset: 0x7D3D8C4 VA: 0x7D418C4
	public static FP get__0_01() { }

	// RVA: 0x7D418CC Offset: 0x7D3D8CC VA: 0x7D418CC
	public static FP get__0_02() { }

	// RVA: 0x7D418D4 Offset: 0x7D3D8D4 VA: 0x7D418D4
	public static FP get__0_06() { }

	// RVA: 0x7D418DC Offset: 0x7D3D8DC VA: 0x7D418DC
	public static FP get__0_13() { }

	// RVA: 0x7D418E4 Offset: 0x7D3D8E4 VA: 0x7D418E4
	public static FP get__0_15() { }

	// RVA: 0x7D418EC Offset: 0x7D3D8EC VA: 0x7D418EC
	public static FP get__0_16() { }

	// RVA: 0x7D418F4 Offset: 0x7D3D8F4 VA: 0x7D418F4
	public static FP get__0_22() { }

	// RVA: 0x7D418FC Offset: 0x7D3D8FC VA: 0x7D418FC
	public static FP get__0_39() { }

	// RVA: 0x7D41904 Offset: 0x7D3D904 VA: 0x7D41904
	public static FP get__0_10() { }

	// RVA: 0x7D4190C Offset: 0x7D3D90C VA: 0x7D4190C
	public static FP get__0_20() { }

	// RVA: 0x7D41914 Offset: 0x7D3D914 VA: 0x7D41914
	public static FP get__0_25() { }

	// RVA: 0x7D4191C Offset: 0x7D3D91C VA: 0x7D4191C
	public static FP get__0_40() { }

	// RVA: 0x7D41924 Offset: 0x7D3D924 VA: 0x7D41924
	public static FP get__0_50() { }

	// RVA: 0x7D4192C Offset: 0x7D3D92C VA: 0x7D4192C
	public static FP get__0_75() { }

	// RVA: 0x7D41934 Offset: 0x7D3D934 VA: 0x7D41934
	public static FP get__0_80() { }

	// RVA: 0x7D4193C Offset: 0x7D3D93C VA: 0x7D4193C
	public static FP get__0_03() { }

	// RVA: 0x7D41944 Offset: 0x7D3D944 VA: 0x7D41944
	public static FP get__0_04() { }

	// RVA: 0x7D4194C Offset: 0x7D3D94C VA: 0x7D4194C
	public static FP get__0_05() { }

	// RVA: 0x7D41954 Offset: 0x7D3D954 VA: 0x7D41954
	public static FP get__0_30() { }

	// RVA: 0x7D4195C Offset: 0x7D3D95C VA: 0x7D4195C
	public static FP get__0_33() { }

	// RVA: 0x7D41964 Offset: 0x7D3D964 VA: 0x7D41964
	public static FP get__0_90() { }

	// RVA: 0x7D4196C Offset: 0x7D3D96C VA: 0x7D4196C
	public static FP get__0_99() { }

	// RVA: 0x7D41974 Offset: 0x7D3D974 VA: 0x7D41974
	public static FP get_Minus_1() { }

	// RVA: 0x7D4197C Offset: 0x7D3D97C VA: 0x7D4197C
	public static FP get_Rad_180() { }

	// RVA: 0x7D41988 Offset: 0x7D3D988 VA: 0x7D41988
	public static FP get_Rad_90() { }

	// RVA: 0x7D41994 Offset: 0x7D3D994 VA: 0x7D41994
	public static FP get_Rad_45() { }

	// RVA: 0x7D4199C Offset: 0x7D3D99C VA: 0x7D4199C
	public static FP get_Rad_22_50() { }

	// RVA: 0x7D419A4 Offset: 0x7D3D9A4 VA: 0x7D419A4
	public static FP get__1_01() { }

	// RVA: 0x7D419B0 Offset: 0x7D3D9B0 VA: 0x7D419B0
	public static FP get__1_02() { }

	// RVA: 0x7D419BC Offset: 0x7D3D9BC VA: 0x7D419BC
	public static FP get__1_03() { }

	// RVA: 0x7D419C8 Offset: 0x7D3D9C8 VA: 0x7D419C8
	public static FP get__1_04() { }

	// RVA: 0x7D419D4 Offset: 0x7D3D9D4 VA: 0x7D419D4
	public static FP get__1_05() { }

	// RVA: 0x7D419E0 Offset: 0x7D3D9E0 VA: 0x7D419E0
	public static FP get__1_10() { }

	// RVA: 0x7D419EC Offset: 0x7D3D9EC VA: 0x7D419EC
	public static FP get__1_20() { }

	// RVA: 0x7D419F8 Offset: 0x7D3D9F8 VA: 0x7D419F8
	public static FP get__1_25() { }

	// RVA: 0x7D41A04 Offset: 0x7D3DA04 VA: 0x7D41A04
	public static FP get__1_50() { }

	// RVA: 0x7D41A0C Offset: 0x7D3DA0C VA: 0x7D41A0C
	public static FP get__1_75() { }

	// RVA: 0x7D41A14 Offset: 0x7D3DA14 VA: 0x7D41A14
	public static FP get__1_30() { }

	// RVA: 0x7D41A20 Offset: 0x7D3DA20 VA: 0x7D41A20
	public static FP get__1_33() { }

	// RVA: 0x7D41A2C Offset: 0x7D3DA2C VA: 0x7D41A2C
	public static FP get__1_99() { }

	// RVA: 0x7D41A38 Offset: 0x7D3DA38 VA: 0x7D41A38
	public static FP get_EN1() { }

	// RVA: 0x7D41A40 Offset: 0x7D3DA40 VA: 0x7D41A40
	public static FP get_EN2() { }

	// RVA: 0x7D41A48 Offset: 0x7D3DA48 VA: 0x7D41A48
	public static FP get_EN3() { }

	// RVA: 0x7D41A50 Offset: 0x7D3DA50 VA: 0x7D41A50
	public static FP get_EN4() { }

	// RVA: 0x7D41A58 Offset: 0x7D3DA58 VA: 0x7D41A58
	public static FP get_EN5() { }

	// RVA: 0x7D41A60 Offset: 0x7D3DA60 VA: 0x7D41A60
	public static FP get_Epsilon() { }

	// RVA: 0x7D41A68 Offset: 0x7D3DA68 VA: 0x7D41A68
	public static FP get_E() { }

	// RVA: 0x7D41A74 Offset: 0x7D3DA74 VA: 0x7D41A74
	public static FP get_Log2_E() { }

	// RVA: 0x7D41A80 Offset: 0x7D3DA80 VA: 0x7D41A80
	public static FP get_Log2_10() { }

	// RVA: 0x7D41A8C Offset: 0x7D3DA8C VA: 0x7D41A8C
	public long get_AsLong() { }

	// RVA: 0x7D41A98 Offset: 0x7D3DA98 VA: 0x7D41A98
	public int get_AsInt() { }

	// RVA: 0x7D41AA4 Offset: 0x7D3DAA4 VA: 0x7D41AA4
	public short get_AsShort() { }

	// RVA: 0x7D41AAC Offset: 0x7D3DAAC VA: 0x7D41AAC
	public float get_AsFloat() { }

	// RVA: 0x7D41AC4 Offset: 0x7D3DAC4 VA: 0x7D41AC4
	public double get_AsDouble() { }

	// RVA: 0x7D41ADC Offset: 0x7D3DADC VA: 0x7D41ADC
	public static FP op_UnaryNegation(FP a) { }

	// RVA: 0x7D41AE4 Offset: 0x7D3DAE4 VA: 0x7D41AE4
	public static FP op_UnaryPlus(FP a) { }

	// RVA: 0x7D41AE8 Offset: 0x7D3DAE8 VA: 0x7D41AE8
	public static FP op_Addition(FP a, FP b) { }

	// RVA: 0x7D41AF0 Offset: 0x7D3DAF0 VA: 0x7D41AF0
	public static FP op_Addition(FP a, int b) { }

	// RVA: 0x7D41AFC Offset: 0x7D3DAFC VA: 0x7D41AFC
	public static FP op_Addition(int a, FP b) { }

	// RVA: 0x7D41B08 Offset: 0x7D3DB08 VA: 0x7D41B08
	public static FP op_Subtraction(FP a, FP b) { }

	// RVA: 0x7D41B10 Offset: 0x7D3DB10 VA: 0x7D41B10
	public static FP op_Subtraction(FP a, int b) { }

	// RVA: 0x7D41B1C Offset: 0x7D3DB1C VA: 0x7D41B1C
	public static FP op_Subtraction(int a, FP b) { }

	// RVA: 0x7D41B28 Offset: 0x7D3DB28 VA: 0x7D41B28
	public static FP op_Multiply(FP a, FP b) { }

	// RVA: 0x7D41B34 Offset: 0x7D3DB34 VA: 0x7D41B34
	public static FP op_Multiply(FP a, int b) { }

	// RVA: 0x7D41B40 Offset: 0x7D3DB40 VA: 0x7D41B40
	public static FP op_Multiply(int a, FP b) { }

	// RVA: 0x7D41B4C Offset: 0x7D3DB4C VA: 0x7D41B4C
	public static FP op_Division(FP a, FP b) { }

	// RVA: 0x7D41B60 Offset: 0x7D3DB60 VA: 0x7D41B60
	public static FP op_Division(FP a, int b) { }

	// RVA: 0x7D41B74 Offset: 0x7D3DB74 VA: 0x7D41B74
	public static FP op_Division(int a, FP b) { }

	// RVA: 0x7D41B88 Offset: 0x7D3DB88 VA: 0x7D41B88
	public static FP op_Division(FP a, FPHighPrecisionDivisor b) { }

	// RVA: 0x7D41B94 Offset: 0x7D3DB94 VA: 0x7D41B94
	public static FP op_Modulus(FP a, FP b) { }

	// RVA: 0x7D41BA0 Offset: 0x7D3DBA0 VA: 0x7D41BA0
	public static FP op_Modulus(FP a, int b) { }

	// RVA: 0x7D41BB0 Offset: 0x7D3DBB0 VA: 0x7D41BB0
	public static FP op_Modulus(int a, FP b) { }

	// RVA: 0x7D41BC0 Offset: 0x7D3DBC0 VA: 0x7D41BC0
	public static FP op_Modulus(FP a, FPHighPrecisionDivisor b) { }

	// RVA: 0x7D41BDC Offset: 0x7D3DBDC VA: 0x7D41BDC
	public static bool op_LessThan(FP a, FP b) { }

	// RVA: 0x7D41BE8 Offset: 0x7D3DBE8 VA: 0x7D41BE8
	public static bool op_LessThan(FP a, int b) { }

	// RVA: 0x7D41BF8 Offset: 0x7D3DBF8 VA: 0x7D41BF8
	public static bool op_LessThan(int a, FP b) { }

	// RVA: 0x7D41C08 Offset: 0x7D3DC08 VA: 0x7D41C08
	public static bool op_LessThanOrEqual(FP a, FP b) { }

	// RVA: 0x7D41C14 Offset: 0x7D3DC14 VA: 0x7D41C14
	public static bool op_LessThanOrEqual(FP a, int b) { }

	// RVA: 0x7D41C24 Offset: 0x7D3DC24 VA: 0x7D41C24
	public static bool op_LessThanOrEqual(int a, FP b) { }

	// RVA: 0x7D41C34 Offset: 0x7D3DC34 VA: 0x7D41C34
	public static bool op_GreaterThan(FP a, FP b) { }

	// RVA: 0x7D41C40 Offset: 0x7D3DC40 VA: 0x7D41C40
	public static bool op_GreaterThan(FP a, int b) { }

	// RVA: 0x7D41C50 Offset: 0x7D3DC50 VA: 0x7D41C50
	public static bool op_GreaterThan(int a, FP b) { }

	// RVA: 0x7D41C60 Offset: 0x7D3DC60 VA: 0x7D41C60
	public static bool op_GreaterThanOrEqual(FP a, FP b) { }

	// RVA: 0x7D41C6C Offset: 0x7D3DC6C VA: 0x7D41C6C
	public static bool op_GreaterThanOrEqual(FP a, int b) { }

	// RVA: 0x7D41C7C Offset: 0x7D3DC7C VA: 0x7D41C7C
	public static bool op_GreaterThanOrEqual(int a, FP b) { }

	// RVA: 0x7D41C8C Offset: 0x7D3DC8C VA: 0x7D41C8C
	public static bool op_Equality(FP a, FP b) { }

	// RVA: 0x7D41C98 Offset: 0x7D3DC98 VA: 0x7D41C98
	public static bool op_Equality(FP a, int b) { }

	// RVA: 0x7D41CA8 Offset: 0x7D3DCA8 VA: 0x7D41CA8
	public static bool op_Equality(int a, FP b) { }

	// RVA: 0x7D41CB8 Offset: 0x7D3DCB8 VA: 0x7D41CB8
	public static bool op_Inequality(FP a, FP b) { }

	// RVA: 0x7D41CC4 Offset: 0x7D3DCC4 VA: 0x7D41CC4
	public static bool op_Inequality(FP a, int b) { }

	// RVA: 0x7D41CD4 Offset: 0x7D3DCD4 VA: 0x7D41CD4
	public static FP op_LeftShift(FP a, int b) { }

	// RVA: 0x7D41CDC Offset: 0x7D3DCDC VA: 0x7D41CDC
	public static FP op_RightShift(FP a, int b) { }

	// RVA: 0x7D41CE4 Offset: 0x7D3DCE4 VA: 0x7D41CE4
	public static bool op_Inequality(int a, FP b) { }

	// RVA: 0x7D41CF4 Offset: 0x7D3DCF4 VA: 0x7D41CF4
	public static FP op_Implicit(int value) { }

	// RVA: 0x7D41CFC Offset: 0x7D3DCFC VA: 0x7D41CFC
	public static FP op_Implicit(uint value) { }

	// RVA: 0x7D41D08 Offset: 0x7D3DD08 VA: 0x7D41D08
	public static FP op_Implicit(short value) { }

	// RVA: 0x7D41D10 Offset: 0x7D3DD10 VA: 0x7D41D10
	public static FP op_Implicit(ushort value) { }

	// RVA: 0x7D41D1C Offset: 0x7D3DD1C VA: 0x7D41D1C
	public static FP op_Implicit(sbyte value) { }

	// RVA: 0x7D41D24 Offset: 0x7D3DD24 VA: 0x7D41D24
	public static FP op_Implicit(byte value) { }

	// RVA: 0x7D41D30 Offset: 0x7D3DD30 VA: 0x7D41D30
	public static int op_Explicit(FP value) { }

	// RVA: 0x7D41D38 Offset: 0x7D3DD38 VA: 0x7D41D38
	public static long op_Explicit(FP value) { }

	// RVA: 0x7D41D40 Offset: 0x7D3DD40 VA: 0x7D41D40
	public static float op_Explicit(FP value) { }

	// RVA: 0x7D41D54 Offset: 0x7D3DD54 VA: 0x7D41D54
	public static double op_Explicit(FP value) { }

	[Obsolete("Don't cast from float to FP", True)]
	// RVA: 0x7D41D68 Offset: 0x7D3DD68 VA: 0x7D41D68
	public static FP op_Implicit(float value) { }

	[Obsolete("Don't cast from double to FP", True)]
	// RVA: 0x7D41DA0 Offset: 0x7D3DDA0 VA: 0x7D41DA0
	public static FP op_Implicit(double value) { }

	// RVA: 0x7D41DD8 Offset: 0x7D3DDD8 VA: 0x7D41DD8
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D41EFC Offset: 0x7D3DEFC VA: 0x7D41EFC
	internal void .ctor(long v) { }

	// RVA: 0x7D41F04 Offset: 0x7D3DF04 VA: 0x7D41F04 Slot: 5
	public int CompareTo(FP other) { }

	// RVA: 0x7D41F0C Offset: 0x7D3DF0C VA: 0x7D41F0C Slot: 4
	public bool Equals(FP other) { }

	// RVA: 0x7D41F1C Offset: 0x7D3DF1C VA: 0x7D41F1C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x7D41F94 Offset: 0x7D3DF94 VA: 0x7D41F94 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D41F9C Offset: 0x7D3DF9C VA: 0x7D41F9C Slot: 3
	public override string ToString() { }

	// RVA: 0x7D42024 Offset: 0x7D3E024 VA: 0x7D42024
	public string ToString(string format) { }

	// RVA: 0x7D420B4 Offset: 0x7D3E0B4 VA: 0x7D420B4
	public string ToStringInternal() { }

	// RVA: 0x7D42210 Offset: 0x7D3E210 VA: 0x7D42210
	public static FP FromFloat_UNSAFE(float value) { }

	// RVA: 0x7D42290 Offset: 0x7D3E290 VA: 0x7D42290
	public static FP FromRaw(long value) { }

	// RVA: 0x7D42294 Offset: 0x7D3E294 VA: 0x7D42294
	public static FP FromString_UNSAFE(string value) { }

	// RVA: 0x7D42300 Offset: 0x7D3E300 VA: 0x7D42300
	public static FP FromString(string value) { }

	// RVA: 0x7D425D4 Offset: 0x7D3E5D4 VA: 0x7D425D4
	private static long ParseInteger(string format) { }

	// RVA: 0x7D424F4 Offset: 0x7D3E4F4 VA: 0x7D424F4
	private static long ParseFractions(string format) { }

	// RVA: 0x7D425EC Offset: 0x7D3E5EC VA: 0x7D425EC
	internal static long RawMultiply(FP x, FP y) { }

	// RVA: 0x7D425F8 Offset: 0x7D3E5F8 VA: 0x7D425F8
	internal static long RawMultiply(FP x, FP y, FP z) { }

	// RVA: 0x7D4260C Offset: 0x7D3E60C VA: 0x7D4260C
	internal static long RawMultiply(FP x, FP y, FP z, FP a) { }

	// RVA: 0x7D42628 Offset: 0x7D3E628 VA: 0x7D42628
	public static FP MulTruncate(FP x, FP y) { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct FPBounds2 // TypeDefIndex: 24022
{
	// Fields
	public const int SIZE = 32;
	public FPVector2 Center; // 0x0
	public FPVector2 Extents; // 0x10

	// Properties
	public FPVector2 Max { get; set; }
	public FPVector2 Min { get; set; }

	// Methods

	// RVA: 0x7D4275C Offset: 0x7D3E75C VA: 0x7D4275C
	public FPVector2 get_Max() { }

	// RVA: 0x7D42770 Offset: 0x7D3E770 VA: 0x7D42770
	public void set_Max(FPVector2 value) { }

	// RVA: 0x7D427AC Offset: 0x7D3E7AC VA: 0x7D427AC
	public FPVector2 get_Min() { }

	// RVA: 0x7D427EC Offset: 0x7D3E7EC VA: 0x7D427EC
	public void set_Min(FPVector2 value) { }

	// RVA: 0x7D42828 Offset: 0x7D3E828 VA: 0x7D42828
	public void .ctor(FPVector2 center, FPVector2 extents) { }

	// RVA: 0x7D42834 Offset: 0x7D3E834 VA: 0x7D42834
	public void Expand(FP amount) { }

	// RVA: 0x7D428A8 Offset: 0x7D3E8A8 VA: 0x7D428A8
	public void Expand(FPVector2 amount) { }

	// RVA: 0x7D427C0 Offset: 0x7D3E7C0 VA: 0x7D427C0
	public void SetMinMax(FPVector2 min, FPVector2 max) { }

	// RVA: 0x7D428C4 Offset: 0x7D3E8C4 VA: 0x7D428C4
	public void Encapsulate(FPVector2 point) { }

	// RVA: 0x7D4295C Offset: 0x7D3E95C VA: 0x7D4295C
	public void Encapsulate(FPBounds2 bounds) { }

	// RVA: 0x7D429A0 Offset: 0x7D3E9A0 VA: 0x7D429A0
	public bool Intersects(FPBounds2 bounds) { }

	// RVA: 0x7D42A14 Offset: 0x7D3EA14 VA: 0x7D42A14
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D42A4C Offset: 0x7D3EA4C VA: 0x7D42A4C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct FPBounds3 // TypeDefIndex: 24023
{
	// Fields
	public const int SIZE = 48;
	public FPVector3 Center; // 0x0
	public FPVector3 Extents; // 0x18

	// Properties
	public FPVector3 Max { get; set; }
	public FPVector3 Min { get; set; }

	// Methods

	// RVA: 0x7D42A90 Offset: 0x7D3EA90 VA: 0x7D42A90
	public FPVector3 get_Max() { }

	// RVA: 0x7D42AB4 Offset: 0x7D3EAB4 VA: 0x7D42AB4
	public void set_Max(FPVector3 value) { }

	// RVA: 0x7D42B08 Offset: 0x7D3EB08 VA: 0x7D42B08
	public FPVector3 get_Min() { }

	// RVA: 0x7D42B78 Offset: 0x7D3EB78 VA: 0x7D42B78
	public void set_Min(FPVector3 value) { }

	// RVA: 0x7D42BCC Offset: 0x7D3EBCC VA: 0x7D42BCC
	public void .ctor(FPVector3 center, FPVector3 extents) { }

	// RVA: 0x7D42BF0 Offset: 0x7D3EBF0 VA: 0x7D42BF0
	public void Expand(FP amount) { }

	// RVA: 0x7D42C7C Offset: 0x7D3EC7C VA: 0x7D42C7C
	public void Expand(FPVector3 amount) { }

	// RVA: 0x7D42B2C Offset: 0x7D3EB2C VA: 0x7D42B2C
	public void SetMinMax(FPVector3 min, FPVector3 max) { }

	// RVA: 0x7D42CA8 Offset: 0x7D3ECA8 VA: 0x7D42CA8
	public void Encapsulate(FPVector3 point) { }

	// RVA: 0x7D42DC8 Offset: 0x7D3EDC8 VA: 0x7D42DC8
	public void Encapsulate(FPBounds3 bounds) { }

	// RVA: 0x7D42E60 Offset: 0x7D3EE60 VA: 0x7D42E60
	public bool Intersects(FPBounds3 bounds) { }

	// RVA: 0x7D42EFC Offset: 0x7D3EEFC VA: 0x7D42EFC
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D42F34 Offset: 0x7D3EF34 VA: 0x7D42F34 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private struct FPCollision.Box // TypeDefIndex: 24024
{
	// Fields
	public FPVector2 UL; // 0x0
	public FPVector2 UR; // 0x10
	public FPVector2 LL; // 0x20
	public FPVector2 LR; // 0x30

	// Methods

	// RVA: 0x7D45C28 Offset: 0x7D41C28 VA: 0x7D45C28
	public void .ctor(FPVector2 center, FPVector2 extents, FP rotation) { }
}

// Namespace: Photon.Deterministic
public struct FPCollision // TypeDefIndex: 24025
{
	// Fields
	private const int ClosestDistanceMaxShiftLeft = 4;
	private const int ClosestDistanceMaxShiftRight = 8;
	private const int ClosestDistanceShiftPerIterationLeft = 1;
	private const int ClosestDistanceShiftPerIterationRight = 2;
	private const long ClosestDistanceMinThresholdRaw = 8;
	private const long ClosestDistanceMaxThresholdRaw = 2147483647;

	// Methods

	// RVA: 0x7D42F78 Offset: 0x7D3EF78 VA: 0x7D42F78
	public static FPVector2 TriangleCenter(FPVector2 v0, FPVector2 v1, FPVector2 v2) { }

	// RVA: 0x7D42FB0 Offset: 0x7D3EFB0 VA: 0x7D42FB0
	private static bool ClosestPointOnLine(FPVector2 line_p0, FPVector2 line_p1, FPVector2 c_center, FP c_radius, out FPVector2 point) { }

	// RVA: 0x7D43140 Offset: 0x7D3F140 VA: 0x7D43140
	public static bool IsPointOnLine(FPVector2 p1, FPVector2 p2, FPVector2 point) { }

	// RVA: 0x7D4319C Offset: 0x7D3F19C VA: 0x7D4319C
	internal static bool IsPointOnLineSegment(FPVector2 p1, FPVector2 p2, FPVector2 point) { }

	// RVA: 0x7D431F8 Offset: 0x7D3F1F8 VA: 0x7D431F8
	public static FPVector3 ClosestPointOnSegment(FPVector3 point, FPVector3 p1, FPVector3 p2) { }

	// RVA: 0x7D4334C Offset: 0x7D3F34C VA: 0x7D4334C
	public static FPVector2 ClosestPointOnSegment(FPVector2 point, FPVector2 p1, FPVector2 p2) { }

	// RVA: 0x7D43438 Offset: 0x7D3F438 VA: 0x7D43438
	public static FPVector2 ClosestPointOnTriangle(FPVector2 pt, FPVector2 t0, FPVector2 t1, FPVector2 t2) { }

	// RVA: 0x7D43614 Offset: 0x7D3F614 VA: 0x7D43614
	public static FPVector2 ClosestPointOnCicle(FPVector2 center, FP radius, FPVector2 pt) { }

	[Obsolete("Use TriangleContainsPointExclusive or -Inclusive")]
	// RVA: 0x7D43654 Offset: 0x7D3F654 VA: 0x7D43654
	public static bool TriangleContainsPoint(FPVector3 pt, FPVector3 t0, FPVector3 t1, FPVector3 t2) { }

	[Obsolete("Use TriangleContainsPointExclusive or -Inclusive")]
	// RVA: 0x7D43798 Offset: 0x7D3F798 VA: 0x7D43798
	public static bool TriangleContainsPoint(FPVector2 pt, FPVector2 t0, FPVector2 t1, FPVector2 t2) { }

	// RVA: 0x7D4379C Offset: 0x7D3F79C VA: 0x7D4379C
	public static bool TriangleContainsPointExclusive(FPVector2 pt, FPVector2 v0, FPVector2 v1, FPVector2 v2) { }

	// RVA: 0x7D436E0 Offset: 0x7D3F6E0 VA: 0x7D436E0
	public static bool TriangleContainsPointExclusive(FPVector3 pt, FPVector3 v0, FPVector3 v1, FPVector3 v2) { }

	// RVA: 0x7D43578 Offset: 0x7D3F578 VA: 0x7D43578
	public static bool TriangleContainsPointInclusive(FPVector2 pt, FPVector2 v0, FPVector2 v1, FPVector2 v2) { }

	// RVA: 0x7D43834 Offset: 0x7D3F834 VA: 0x7D43834
	public static bool TriangleContainsPointInclusive(FPVector3 pt, FPVector3 v0, FPVector3 v1, FPVector3 v2) { }

	// RVA: 0x7D438F0 Offset: 0x7D3F8F0 VA: 0x7D438F0
	public static bool CircleContainsPoint(FPVector2 center, FP radius, FPVector2 point) { }

	// RVA: 0x7D4391C Offset: 0x7D3F91C VA: 0x7D4391C
	public static bool CircleIntersectsCircle(FPVector2 a_origin, FP a_radius, FPVector2 b_origin, FP b_radius) { }

	// RVA: 0x7D43948 Offset: 0x7D3F948 VA: 0x7D43948
	public static bool CircleIntersectsAABB(FPVector2 center, FP radius, FPVector2 min, FPVector2 max) { }

	// RVA: 0x7D43990 Offset: 0x7D3F990 VA: 0x7D43990
	public static bool CircleIntersectsTriangle(FPVector2 center, FP radius, FPVector2 v1, FPVector2 v2, FPVector2 v3) { }

	// RVA: 0x7D43B40 Offset: 0x7D3FB40 VA: 0x7D43B40
	public static bool LineIntersectsAABB_SAT(FPVector2 p1, FPVector2 p2, FPVector2 aabbCenter, FPVector2 aabbExtents) { }

	// RVA: 0x7D43B5C Offset: 0x7D3FB5C VA: 0x7D43B5C
	public static bool LineIntersectsAABB_SAT(FPVector2 p1, FPVector2 p2, FPVector2 aabbExtents) { }

	// RVA: 0x7D43BB4 Offset: 0x7D3FBB4 VA: 0x7D43BB4
	public static bool LineIntersectsAABB2(FPVector2 p1, FPVector2 p2, FPVector2 normal, FPVector2 aabbCenter, FPVector2 aabbExtents, out FPVector2 i1, out FPVector2 i2, out FP penetration) { }

	// RVA: 0x7D43C30 Offset: 0x7D3FC30 VA: 0x7D43C30
	public static bool LineIntersectsAABB2(FPVector2 p1, FPVector2 p2, FPVector2 normal, FPVector2 aabbExtents, out FPVector2 i1, out FPVector2 i2, out FP penetration) { }

	// RVA: 0x7D43DD4 Offset: 0x7D3FDD4 VA: 0x7D43DD4
	public static int LineIntersectsAABB(FPVector2 p1, FPVector2 p2, FPVector2 aabbCenter, FPVector2 aabbExtents, out FPVector2 i1, out FPVector2 i2, out FP penetration) { }

	// RVA: 0x7D43E50 Offset: 0x7D3FE50 VA: 0x7D43E50
	public static int LineIntersectsAABB(FPVector2 p1, FPVector2 p2, FPVector2 aabbExtents, out FPVector2 i1, out FPVector2 i2, out FP penetration) { }

	// RVA: 0x7D44248 Offset: 0x7D40248 VA: 0x7D44248
	public static bool LineIntersectsLine(FPVector2 p1, FPVector2 p2, FPVector2 q1, FPVector2 q2) { }

	// RVA: 0x7D44304 Offset: 0x7D40304 VA: 0x7D44304
	public static bool LineIntersectsLine(FPVector2 p1, FPVector2 p2, FPVector2 q1, FPVector2 q2, out FPVector2 point, out FP distance) { }

	// RVA: 0x7D44330 Offset: 0x7D40330 VA: 0x7D44330
	public static bool LineIntersectsLine(FPVector2 p1, FPVector2 p2, FPVector2 q1, FPVector2 q2, out FPVector2 point, out FP distance, out FP normalizedDist) { }

	// RVA: 0x7D44490 Offset: 0x7D40490 VA: 0x7D44490
	public static bool LineIntersectsLine(FPVector2 p1, FPVector2 p2, FPVector2 q1, FPVector2 q2, out FPVector2 point) { }

	// RVA: 0x7D44590 Offset: 0x7D40590 VA: 0x7D44590
	public static void LineIntersectsLineAlwaysHit(FPVector2 p1, FPVector2 p2, FPVector2 q1, FPVector2 q2, out FPVector2 point) { }

	// RVA: 0x7D441BC Offset: 0x7D401BC VA: 0x7D441BC
	public static bool InsideAABB(FPVector2 point, FPVector2 extents, out FP penetration) { }

	// RVA: 0x7D44638 Offset: 0x7D40638 VA: 0x7D44638
	public static bool LineIntersectsCircleManifold(FPVector2 p1, FPVector2 p2, FPVector2 position, FP radius, out FPVector2 point) { }

	// RVA: 0x7D447A0 Offset: 0x7D407A0 VA: 0x7D447A0
	public static bool LineIntersectsCircle(FPVector2 p1, FPVector2 p2, FPVector2 position, FP radius, bool ignoreIfStartPointInside = False) { }

	// RVA: 0x7D44974 Offset: 0x7D40974 VA: 0x7D44974
	public static bool LineIntersectsCircle(FPVector2 p1, FPVector2 p2, FPVector2 position, FP radius, out FPVector2 point, bool ignoreIfStartPointInside = False) { }

	// RVA: 0x7D447F8 Offset: 0x7D407F8 VA: 0x7D447F8
	public static bool LineIntersectsCircle(FPVector2 p1, FPVector2 p2, FPVector2 position, FP radius, out FPVector2 point, out FP normalizedDist, bool ignoreIfStartPointInside = False) { }

	// RVA: 0x7D449A4 Offset: 0x7D409A4 VA: 0x7D449A4
	public static bool CircleIntersectsPolygon(FPVector2 circleCenter, FP circleRadius, FPVector2 polygonPosition, FP polygonRotationSinInverse, FP polygonRotationCosInverse, FPVector2[] polygonVertices, FPVector2[] polygonNormals) { }

	// RVA: 0x7D44BAC Offset: 0x7D40BAC VA: 0x7D44BAC
	public static bool CircleIntersectsPolygon(FPVector2 circleCenter, FP circleRadius, FPVector2 polygonPosition, FP polygonRotation, FPVector2[] polygonVertices, FPVector2[] polygonNormals) { }

	// RVA: 0x7D44CC8 Offset: 0x7D40CC8 VA: 0x7D44CC8
	public static bool BoxIntersectsBox(FPVector2 aCenter, FPVector2 aExtents, FP aRotation, FPVector2 bCenter, FPVector2 bExtents, FP bRotation) { }

	// RVA: 0x7D44F00 Offset: 0x7D40F00 VA: 0x7D44F00
	private static bool Project(FPVector2 axis, FPCollision.Box a, FPCollision.Box b) { }

	// RVA: 0x7D451C8 Offset: 0x7D411C8 VA: 0x7D451C8
	private static FPVector2 Project(FPVector2 axis, FPVector2 point) { }

	// RVA: 0x7D45254 Offset: 0x7D41254 VA: 0x7D45254
	public static FP ClosestDistanceToTriangle(FPVector3 p, FPVector3 a, FPVector3 b, FPVector3 c, out FPVector3 closestPoint, out FPVector3 barycentricCoordinates) { }
}

// Namespace: 
public class FPHighPrecisionDivisor.Raw // TypeDefIndex: 24026
{
	// Fields
	public const long Pi = 13493037704;
	public const long PiInv = 1367130551;
	public const long PiTimes2 = 26986075409;
	public const long PiOver2 = 6746518852;
	public const long PiOver2Inv = 2734261102;
	public const long PiOver4 = 3373259426;
	public const long Pi3Over4 = 10119778278;
	public const long Deg2Rad = 74961320;
	public const long Rad2Deg = 246083499207;
	public const long Rad_180 = 13493037704;
	public const long Rad_90 = 6746518852;
	public const long Rad_45 = 3373259426;
	public const long Rad_22_50 = 1686629713;
	public const long _0_01 = 42949672;
	public const long _0_02 = 85899345;
	public const long _0_03 = 128849018;
	public const long _0_04 = 171798691;
	public const long _0_05 = 214748364;
	public const long _0_10 = 429496729;
	public const long _0_20 = 858993459;
	public const long _0_33 = 1431655765;
	public const long _0_99 = 4252017623;
	public const long _1_01 = 4337916968;
	public const long _1_02 = 4380866641;
	public const long _1_03 = 4423816314;
	public const long _1_04 = 4466765987;
	public const long _1_05 = 4509715660;
	public const long _1_10 = 4724464025;
	public const long _1_20 = 5153960755;
	public const long _1_33 = 5726623061;
	public const long _1_99 = 8546984919;
	public const long EN1 = 429496729;
	public const long EN2 = 42949672;
	public const long EN3 = 4294967;
	public const long EN4 = 429496;
	public const long EN5 = 42949;
	public const long E = 11674931554;
	public const long Log2_E = 6196328018;
	public const long Log2_10 = 14267572527;

	// Methods

	// RVA: 0x7D45F44 Offset: 0x7D41F44 VA: 0x7D45F44
	public void .ctor() { }
}

// Namespace: Photon.Deterministic
public struct FPHighPrecisionDivisor // TypeDefIndex: 24027
{
	// Fields
	public const int ExtraPrecision = 16;
	public const int TotalPrecision = 32;
	internal long RawValue; // 0x0

	// Properties
	public static FPHighPrecisionDivisor Pi { get; }
	public static FPHighPrecisionDivisor PiInv { get; }
	public static FPHighPrecisionDivisor PiTimes2 { get; }
	public static FPHighPrecisionDivisor PiOver2 { get; }
	public static FPHighPrecisionDivisor PiOver2Inv { get; }
	public static FPHighPrecisionDivisor PiOver4 { get; }
	public static FPHighPrecisionDivisor Pi3Over4 { get; }
	public static FPHighPrecisionDivisor Deg2Rad { get; }
	public static FPHighPrecisionDivisor Rad2Deg { get; }
	public static FPHighPrecisionDivisor Rad_180 { get; }
	public static FPHighPrecisionDivisor Rad_90 { get; }
	public static FPHighPrecisionDivisor Rad_45 { get; }
	public static FPHighPrecisionDivisor Rad_22_50 { get; }
	public static FPHighPrecisionDivisor _0_01 { get; }
	public static FPHighPrecisionDivisor _0_02 { get; }
	public static FPHighPrecisionDivisor _0_03 { get; }
	public static FPHighPrecisionDivisor _0_04 { get; }
	public static FPHighPrecisionDivisor _0_05 { get; }
	public static FPHighPrecisionDivisor _0_10 { get; }
	public static FPHighPrecisionDivisor _0_20 { get; }
	public static FPHighPrecisionDivisor _0_33 { get; }
	public static FPHighPrecisionDivisor _0_99 { get; }
	public static FPHighPrecisionDivisor _1_01 { get; }
	public static FPHighPrecisionDivisor _1_02 { get; }
	public static FPHighPrecisionDivisor _1_03 { get; }
	public static FPHighPrecisionDivisor _1_04 { get; }
	public static FPHighPrecisionDivisor _1_05 { get; }
	public static FPHighPrecisionDivisor _1_10 { get; }
	public static FPHighPrecisionDivisor _1_20 { get; }
	public static FPHighPrecisionDivisor _1_33 { get; }
	public static FPHighPrecisionDivisor _1_99 { get; }
	public static FPHighPrecisionDivisor EN1 { get; }
	public static FPHighPrecisionDivisor EN2 { get; }
	public static FPHighPrecisionDivisor EN3 { get; }
	public static FPHighPrecisionDivisor EN4 { get; }
	public static FPHighPrecisionDivisor EN5 { get; }
	public static FPHighPrecisionDivisor E { get; }
	public static FPHighPrecisionDivisor Log2_E { get; }
	public static FPHighPrecisionDivisor Log2_10 { get; }
	public FP AsFP { get; }

	// Methods

	// RVA: 0x7D45CE8 Offset: 0x7D41CE8 VA: 0x7D45CE8
	public static FPHighPrecisionDivisor get_Pi() { }

	// RVA: 0x7D45CF8 Offset: 0x7D41CF8 VA: 0x7D45CF8
	public static FPHighPrecisionDivisor get_PiInv() { }

	// RVA: 0x7D45D04 Offset: 0x7D41D04 VA: 0x7D45D04
	public static FPHighPrecisionDivisor get_PiTimes2() { }

	// RVA: 0x7D45D14 Offset: 0x7D41D14 VA: 0x7D45D14
	public static FPHighPrecisionDivisor get_PiOver2() { }

	// RVA: 0x7D45D24 Offset: 0x7D41D24 VA: 0x7D45D24
	public static FPHighPrecisionDivisor get_PiOver2Inv() { }

	// RVA: 0x7D45D30 Offset: 0x7D41D30 VA: 0x7D45D30
	public static FPHighPrecisionDivisor get_PiOver4() { }

	// RVA: 0x7D45D3C Offset: 0x7D41D3C VA: 0x7D45D3C
	public static FPHighPrecisionDivisor get_Pi3Over4() { }

	// RVA: 0x7D45D4C Offset: 0x7D41D4C VA: 0x7D45D4C
	public static FPHighPrecisionDivisor get_Deg2Rad() { }

	// RVA: 0x7D45D58 Offset: 0x7D41D58 VA: 0x7D45D58
	public static FPHighPrecisionDivisor get_Rad2Deg() { }

	// RVA: 0x7D45D68 Offset: 0x7D41D68 VA: 0x7D45D68
	public static FPHighPrecisionDivisor get_Rad_180() { }

	// RVA: 0x7D45D78 Offset: 0x7D41D78 VA: 0x7D45D78
	public static FPHighPrecisionDivisor get_Rad_90() { }

	// RVA: 0x7D45D88 Offset: 0x7D41D88 VA: 0x7D45D88
	public static FPHighPrecisionDivisor get_Rad_45() { }

	// RVA: 0x7D45D94 Offset: 0x7D41D94 VA: 0x7D45D94
	public static FPHighPrecisionDivisor get_Rad_22_50() { }

	// RVA: 0x7D45DA0 Offset: 0x7D41DA0 VA: 0x7D45DA0
	public static FPHighPrecisionDivisor get__0_01() { }

	// RVA: 0x7D45DAC Offset: 0x7D41DAC VA: 0x7D45DAC
	public static FPHighPrecisionDivisor get__0_02() { }

	// RVA: 0x7D45DB8 Offset: 0x7D41DB8 VA: 0x7D45DB8
	public static FPHighPrecisionDivisor get__0_03() { }

	// RVA: 0x7D45DC4 Offset: 0x7D41DC4 VA: 0x7D45DC4
	public static FPHighPrecisionDivisor get__0_04() { }

	// RVA: 0x7D45DD0 Offset: 0x7D41DD0 VA: 0x7D45DD0
	public static FPHighPrecisionDivisor get__0_05() { }

	// RVA: 0x7D45DDC Offset: 0x7D41DDC VA: 0x7D45DDC
	public static FPHighPrecisionDivisor get__0_10() { }

	// RVA: 0x7D45DE8 Offset: 0x7D41DE8 VA: 0x7D45DE8
	public static FPHighPrecisionDivisor get__0_20() { }

	// RVA: 0x7D45DF0 Offset: 0x7D41DF0 VA: 0x7D45DF0
	public static FPHighPrecisionDivisor get__0_33() { }

	// RVA: 0x7D45DF8 Offset: 0x7D41DF8 VA: 0x7D45DF8
	public static FPHighPrecisionDivisor get__0_99() { }

	// RVA: 0x7D45E04 Offset: 0x7D41E04 VA: 0x7D45E04
	public static FPHighPrecisionDivisor get__1_01() { }

	// RVA: 0x7D45E14 Offset: 0x7D41E14 VA: 0x7D45E14
	public static FPHighPrecisionDivisor get__1_02() { }

	// RVA: 0x7D45E24 Offset: 0x7D41E24 VA: 0x7D45E24
	public static FPHighPrecisionDivisor get__1_03() { }

	// RVA: 0x7D45E34 Offset: 0x7D41E34 VA: 0x7D45E34
	public static FPHighPrecisionDivisor get__1_04() { }

	// RVA: 0x7D45E44 Offset: 0x7D41E44 VA: 0x7D45E44
	public static FPHighPrecisionDivisor get__1_05() { }

	// RVA: 0x7D45E54 Offset: 0x7D41E54 VA: 0x7D45E54
	public static FPHighPrecisionDivisor get__1_10() { }

	// RVA: 0x7D45E64 Offset: 0x7D41E64 VA: 0x7D45E64
	public static FPHighPrecisionDivisor get__1_20() { }

	// RVA: 0x7D45E74 Offset: 0x7D41E74 VA: 0x7D45E74
	public static FPHighPrecisionDivisor get__1_33() { }

	// RVA: 0x7D45E84 Offset: 0x7D41E84 VA: 0x7D45E84
	public static FPHighPrecisionDivisor get__1_99() { }

	// RVA: 0x7D45E94 Offset: 0x7D41E94 VA: 0x7D45E94
	public static FPHighPrecisionDivisor get_EN1() { }

	// RVA: 0x7D45EA0 Offset: 0x7D41EA0 VA: 0x7D45EA0
	public static FPHighPrecisionDivisor get_EN2() { }

	// RVA: 0x7D45EAC Offset: 0x7D41EAC VA: 0x7D45EAC
	public static FPHighPrecisionDivisor get_EN3() { }

	// RVA: 0x7D45EB8 Offset: 0x7D41EB8 VA: 0x7D45EB8
	public static FPHighPrecisionDivisor get_EN4() { }

	// RVA: 0x7D45EC4 Offset: 0x7D41EC4 VA: 0x7D45EC4
	public static FPHighPrecisionDivisor get_EN5() { }

	// RVA: 0x7D45ECC Offset: 0x7D41ECC VA: 0x7D45ECC
	public static FPHighPrecisionDivisor get_E() { }

	// RVA: 0x7D45EDC Offset: 0x7D41EDC VA: 0x7D45EDC
	public static FPHighPrecisionDivisor get_Log2_E() { }

	// RVA: 0x7D45EEC Offset: 0x7D41EEC VA: 0x7D45EEC
	public static FPHighPrecisionDivisor get_Log2_10() { }

	// RVA: 0x7D45EFC Offset: 0x7D41EFC VA: 0x7D45EFC
	public FP get_AsFP() { }

	// RVA: 0x7D45F08 Offset: 0x7D41F08 VA: 0x7D45F08
	internal static long RawMod(long standardPrecisionRaw, long highPrecisionRaw) { }

	// RVA: 0x7D45F24 Offset: 0x7D41F24 VA: 0x7D45F24
	internal static long RawModPositive(long standardPrecisionRaw, long highPrecisionRaw) { }

	// RVA: 0x7D45F38 Offset: 0x7D41F38 VA: 0x7D45F38
	internal static long RawDiv(long standardPrecisionRaw, long highPrecisionRaw) { }
}

// Namespace: Photon.Deterministic
public static class FPLut // TypeDefIndex: 24028
{
	// Fields
	public const int PRECISION = 16;
	public const long PI = 205887;
	public const long PITIMES2 = 411774;
	public const long PIOVER2 = 102944;
	public const long ONE = 65536;
	internal const int SQRT_RESOLUTION_SPACE = 3;
	internal const int SQRT_LUT_SIZE_BASE_2 = 16;
	internal const int SQRT_VALUE_STEP = 3;
	internal const int SQRT_LUT_SIZE_BASE_10 = 65536;
	internal const int SqrtAdditionalPrecisionBits = 6;
	internal const int Log2LutSizeExponent = 6;
	internal const int Log2AdditionalPrecisionBits = 15;
	internal const int Log2APShiftForHPDivision = 6;
	internal const int ExpNegativeLutPrecision = 42;
	internal const int ExpNegativeLutCount = 30;
	internal const int ExpNonNegativeLutCount = 33;
	internal const int ExpOverflowingThreshold = 20;
	public static int[] sqrt_aprox_lut; // 0x0
	public static long[] asin_lut; // 0x8
	public static long[] acos_lut; // 0x10
	public static long[] atan_lut; // 0x18
	public static long[] sin_cos_lut; // 0x20
	public static long[] tan_lut; // 0x28
	public static uint[] log2_approx_lut; // 0x30
	public static long[] exp_integral_lut; // 0x38

	// Properties
	public static bool IsLoaded { get; }

	// Methods

	// RVA: 0x7D45F4C Offset: 0x7D41F4C VA: 0x7D45F4C
	public static bool get_IsLoaded() { }

	// RVA: 0x7D45FFC Offset: 0x7D41FFC VA: 0x7D45FFC
	public static void Init(string directoryPath) { }

	// RVA: 0x7D46298 Offset: 0x7D42298 VA: 0x7D46298
	public static void Init(LutProvider lutProvider) { }

	// RVA: 0x7D461A0 Offset: 0x7D421A0 VA: 0x7D461A0
	private static void InitSmallLut() { }

	// RVA: 0x7D4643C Offset: 0x7D4243C VA: 0x7D4643C
	public static void GenerateTables(string directoryPath) { }

	// RVA: -1 Offset: -1
	private static void Load<T>(LutProvider lutProvider, string path, ref T[] lut) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FC7B4 Offset: 0x45F87B4 VA: 0x45FC7B4
	|-FPLut.Load<int>
	|
	|-RVA: 0x45FC968 Offset: 0x45F8968 VA: 0x45FC968
	|-FPLut.Load<long>
	|
	|-RVA: 0x45FCB1C Offset: 0x45F8B1C VA: 0x45FCB1C
	|-FPLut.Load<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void Load<T>(string directoryPath, string filePath, ref T[] lut) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FC868 Offset: 0x45F8868 VA: 0x45FC868
	|-FPLut.Load<int>
	|
	|-RVA: 0x45FCA1C Offset: 0x45F8A1C VA: 0x45FCA1C
	|-FPLut.Load<long>
	|
	|-RVA: 0x45FCBD0 Offset: 0x45F8BD0 VA: 0x45FCBD0
	|-FPLut.Load<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: 
internal struct FPMath.ExponentMantisaPair // TypeDefIndex: 24029
{
	// Fields
	public int Exponent; // 0x0
	public int Mantissa; // 0x4
}

// Namespace: Photon.Deterministic
public struct FPMath // TypeDefIndex: 24030
{
	// Methods

	// RVA: 0x7D46444 Offset: 0x7D42444 VA: 0x7D46444
	public static FP Sin(FP rad) { }

	// RVA: 0x7D464F8 Offset: 0x7D424F8 VA: 0x7D464F8
	public static FP SinHighPrecision(FP rad) { }

	// RVA: 0x7D465BC Offset: 0x7D425BC VA: 0x7D465BC
	public static FP Cos(FP rad) { }

	// RVA: 0x7D46668 Offset: 0x7D42668 VA: 0x7D46668
	public static FP CosHighPrecision(FP rad) { }

	// RVA: 0x7D46724 Offset: 0x7D42724 VA: 0x7D46724
	public static void SinCos(FP rad, out FP sin, out FP cos) { }

	// RVA: 0x7D467F4 Offset: 0x7D427F4 VA: 0x7D467F4
	public static void SinCosRaw(FP rad, out long sinRaw, out long cosRaw) { }

	// RVA: 0x7D468C4 Offset: 0x7D428C4 VA: 0x7D468C4
	public static void SinCosHighPrecision(FP rad, out FP sin, out FP cos) { }

	// RVA: 0x7D469A4 Offset: 0x7D429A4 VA: 0x7D469A4
	public static FP Tan(FP rad) { }

	// RVA: 0x7D46A64 Offset: 0x7D42A64 VA: 0x7D46A64
	public static FP Asin(FP value) { }

	// RVA: 0x7D46AF0 Offset: 0x7D42AF0 VA: 0x7D46AF0
	public static FP Acos(FP value) { }

	// RVA: 0x7D46B7C Offset: 0x7D42B7C VA: 0x7D46B7C
	public static FP Atan(FP value) { }

	// RVA: 0x7D46C98 Offset: 0x7D42C98 VA: 0x7D46C98
	public static FP Atan2(FP y, FP x) { }

	// RVA: 0x7D46D10 Offset: 0x7D42D10 VA: 0x7D46D10
	public static FP Sign(FP value) { }

	// RVA: 0x7D46D20 Offset: 0x7D42D20 VA: 0x7D46D20
	public static FP SignZero(FP value) { }

	// RVA: 0x7D46D3C Offset: 0x7D42D3C VA: 0x7D46D3C
	public static int SignInt(FP value) { }

	// RVA: 0x7D46D4C Offset: 0x7D42D4C VA: 0x7D46D4C
	public static int SignZeroInt(FP value) { }

	// RVA: 0x7D46D64 Offset: 0x7D42D64 VA: 0x7D46D64
	public static int NextPowerOfTwo(int value) { }

	// RVA: 0x7D46DD8 Offset: 0x7D42DD8 VA: 0x7D46DD8
	public static FP Abs(FP value) { }

	// RVA: 0x7D46DE4 Offset: 0x7D42DE4 VA: 0x7D46DE4
	public static FP Round(FP value) { }

	// RVA: 0x7D46E1C Offset: 0x7D42E1C VA: 0x7D46E1C
	public static void RoundToPointOne(FP value, out int iPart, out int frPart) { }

	// RVA: 0x7D46EAC Offset: 0x7D42EAC VA: 0x7D46EAC
	public static void RoundToPointTwo(FP value, out int iPart, out int frPart) { }

	// RVA: 0x7D46E9C Offset: 0x7D42E9C VA: 0x7D46E9C
	public static int RoundToInt(FP value) { }

	// RVA: 0x7D46F40 Offset: 0x7D42F40 VA: 0x7D46F40
	public static long RoundToLong(FP value) { }

	// RVA: 0x7D46E14 Offset: 0x7D42E14 VA: 0x7D46E14
	public static FP Floor(FP value) { }

	// RVA: 0x7D46F4C Offset: 0x7D42F4C VA: 0x7D46F4C
	public static long FloorRaw(long value) { }

	// RVA: 0x7D46E94 Offset: 0x7D42E94 VA: 0x7D46E94
	public static int FloorToInt(FP value) { }

	// RVA: 0x7D46F54 Offset: 0x7D42F54 VA: 0x7D46F54
	public static FP Ceiling(FP value) { }

	// RVA: 0x7D46E84 Offset: 0x7D42E84 VA: 0x7D46E84
	public static int CeilToInt(FP value) { }

	// RVA: 0x7D46F68 Offset: 0x7D42F68 VA: 0x7D46F68
	public static FP Max(FP val1, FP val2) { }

	// RVA: 0x7D46F74 Offset: 0x7D42F74 VA: 0x7D46F74
	public static int Max(int val1, int val2) { }

	// RVA: 0x7D46F80 Offset: 0x7D42F80 VA: 0x7D46F80
	public static int Min(int val1, int val2) { }

	// RVA: 0x7D46F8C Offset: 0x7D42F8C VA: 0x7D46F8C
	public static FP Min(FP val1, FP val2) { }

	// RVA: 0x7D46F98 Offset: 0x7D42F98 VA: 0x7D46F98
	public static FP Min(FP[] numbers) { }

	// RVA: 0x7D46FE8 Offset: 0x7D42FE8 VA: 0x7D46FE8
	public static FP Min(FP a, FP b, FP c) { }

	// RVA: 0x7D46FFC Offset: 0x7D42FFC VA: 0x7D46FFC
	public static FP Max(FP a, FP b, FP c) { }

	// RVA: 0x7D47010 Offset: 0x7D43010 VA: 0x7D47010
	public static FP Max(FP[] numbers) { }

	// RVA: 0x7D47060 Offset: 0x7D43060 VA: 0x7D47060
	public static void MinMax(FP a, FP b, out FP min, out FP max) { }

	// RVA: 0x7D47078 Offset: 0x7D43078 VA: 0x7D47078
	public static FP Clamp(FP value, FP min, FP max) { }

	// RVA: 0x7D47094 Offset: 0x7D43094 VA: 0x7D47094
	public static FP Clamp01(FP value) { }

	// RVA: 0x7D470B0 Offset: 0x7D430B0 VA: 0x7D470B0
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x7D470CC Offset: 0x7D430CC VA: 0x7D470CC
	public static long Clamp(long value, long min, long max) { }

	// RVA: 0x7D470E8 Offset: 0x7D430E8 VA: 0x7D470E8
	public static FP ClampUseable(FP value) { }

	// RVA: 0x7D4710C Offset: 0x7D4310C VA: 0x7D4710C
	public static FP Fraction(FP value) { }

	// RVA: 0x7D47114 Offset: 0x7D43114 VA: 0x7D47114
	public static FP Repeat(FP t, FP length) { }

	// RVA: 0x7D4712C Offset: 0x7D4312C VA: 0x7D4712C
	internal static long RepeatRaw(long t, long length) { }

	// RVA: 0x7D47144 Offset: 0x7D43144 VA: 0x7D47144
	public static FP LerpRadians(FP start, FP end, FP t) { }

	// RVA: 0x7D471B4 Offset: 0x7D431B4 VA: 0x7D471B4
	public static FP Lerp(FP start, FP end, FP t) { }

	// RVA: 0x7D471D4 Offset: 0x7D431D4 VA: 0x7D471D4
	public static FP LerpUnclamped(FP start, FP end, FP t) { }

	// RVA: 0x7D471E4 Offset: 0x7D431E4 VA: 0x7D471E4
	public static FP InverseLerp(FP start, FP end, FP value) { }

	// RVA: 0x7D47214 Offset: 0x7D43214 VA: 0x7D47214
	public static FP InverseLerpUnclamped(FP start, FP end, FP value) { }

	// RVA: 0x7D47234 Offset: 0x7D43234 VA: 0x7D47234
	public static FP SmoothStep(FP start, FP end, FP t) { }

	// RVA: 0x7D472C8 Offset: 0x7D432C8 VA: 0x7D472C8
	public static FP Sqrt(FP value) { }

	// RVA: 0x7D472CC Offset: 0x7D432CC VA: 0x7D472CC
	public static long SqrtRaw(long x) { }

	// RVA: 0x7D47474 Offset: 0x7D43474 VA: 0x7D47474
	internal static FPMath.ExponentMantisaPair GetSqrtExponentMantissa(ulong x) { }

	// RVA: 0x7D475AC Offset: 0x7D435AC VA: 0x7D475AC
	public static FP Barycentric(FP value1, FP value2, FP value3, FP t1, FP t2) { }

	// RVA: 0x7D475C8 Offset: 0x7D435C8 VA: 0x7D475C8
	public static FP CatmullRom(FP value1, FP value2, FP value3, FP value4, FP t) { }

	// RVA: 0x7D47258 Offset: 0x7D43258 VA: 0x7D47258
	public static FP Hermite(FP value1, FP tangent1, FP value2, FP tangent2, FP t) { }

	// RVA: 0x7D47634 Offset: 0x7D43634 VA: 0x7D47634
	public static long ModuloClamped(long a, long n) { }

	// RVA: 0x7D476D4 Offset: 0x7D436D4 VA: 0x7D476D4
	public static FP ModuloClamped(FP a, FP n) { }

	// RVA: 0x7D47774 Offset: 0x7D43774 VA: 0x7D47774
	public static FP AngleBetweenDegrees(FP source, FP target) { }

	// RVA: 0x7D477D4 Offset: 0x7D437D4 VA: 0x7D477D4
	public static long AngleBetweenDegreesRaw(long source, long target) { }

	// RVA: 0x7D47834 Offset: 0x7D43834 VA: 0x7D47834
	public static FP AngleBetweenRadians(FP source, FP target) { }

	// RVA: 0x7D478A4 Offset: 0x7D438A4 VA: 0x7D478A4
	public static long AngleBetweenRadiansRaw(long source, long target) { }

	// RVA: 0x7D47914 Offset: 0x7D43914 VA: 0x7D47914
	public static int Log2FloorToInt(FP value) { }

	// RVA: 0x7D479FC Offset: 0x7D439FC VA: 0x7D479FC
	public static int Log2CeilingToInt(FP value) { }

	// RVA: 0x7D47A24 Offset: 0x7D43A24 VA: 0x7D47A24
	public static FP Log2(FP value) { }

	// RVA: 0x7D47B1C Offset: 0x7D43B1C VA: 0x7D47B1C
	public static FP Ln(FP value) { }

	// RVA: 0x7D47B54 Offset: 0x7D43B54 VA: 0x7D47B54
	public static FP Log10(FP value) { }

	// RVA: 0x7D47B90 Offset: 0x7D43B90 VA: 0x7D47B90
	public static FP Log(FP value, FP logBase) { }

	// RVA: 0x7D47918 Offset: 0x7D43918 VA: 0x7D47918
	private static int Log2FloorToIntRaw(long x) { }

	// RVA: 0x7D47A38 Offset: 0x7D43A38 VA: 0x7D47A38
	private static long Log2RawAdditionalPrecision(long x) { }

	// RVA: 0x7D47BC0 Offset: 0x7D43BC0 VA: 0x7D47BC0
	public static FP Exp(FP x) { }
}

// Namespace: Photon.Deterministic
[DefaultMember("Item")]
[Serializable]
public struct FPMatrix2x2 // TypeDefIndex: 24031
{
	// Fields
	public const int SIZE = 32;
	public FP M00; // 0x0
	public FP M10; // 0x8
	public FP M01; // 0x10
	public FP M11; // 0x18

	// Properties
	public FPVector2 LossyScale { get; }
	public FPMatrix2x2 Inverted { get; }
	public FP Determinant { get; }
	public static FPMatrix2x2 Zero { get; }
	public static FPMatrix2x2 Identity { get; }
	public bool IsIdentity { get; }
	public FP Item { get; set; }

	// Methods

	// RVA: 0x7D47CE0 Offset: 0x7D43CE0 VA: 0x7D47CE0
	public FPVector2 get_LossyScale() { }

	// RVA: 0x7D47DA8 Offset: 0x7D43DA8 VA: 0x7D47DA8
	public FPMatrix2x2 get_Inverted() { }

	// RVA: 0x7D47D8C Offset: 0x7D43D8C VA: 0x7D47D8C
	public FP get_Determinant() { }

	// RVA: 0x7D47E04 Offset: 0x7D43E04 VA: 0x7D47E04
	public static FPMatrix2x2 get_Zero() { }

	// RVA: 0x7D47E10 Offset: 0x7D43E10 VA: 0x7D47E10
	public static FPMatrix2x2 get_Identity() { }

	// RVA: 0x7D47E20 Offset: 0x7D43E20 VA: 0x7D47E20
	public bool get_IsIdentity() { }

	// RVA: 0x7D47E54 Offset: 0x7D43E54 VA: 0x7D47E54
	public FP get_Item(int index) { }

	// RVA: 0x7D47ED0 Offset: 0x7D43ED0 VA: 0x7D47ED0
	public void set_Item(int index, FP value) { }

	// RVA: 0x7D47F4C Offset: 0x7D43F4C VA: 0x7D47F4C
	public static FPMatrix2x2 op_Addition(FPMatrix2x2 a, FPMatrix2x2 b) { }

	// RVA: 0x7D47F90 Offset: 0x7D43F90 VA: 0x7D47F90
	public static FPMatrix2x2 op_Subtraction(FPMatrix2x2 a, FPMatrix2x2 b) { }

	// RVA: 0x7D47FD4 Offset: 0x7D43FD4 VA: 0x7D47FD4
	public static FPMatrix2x2 op_Multiply(FPMatrix2x2 a, FPMatrix2x2 b) { }

	// RVA: 0x7D48030 Offset: 0x7D44030 VA: 0x7D48030
	public static FPVector2 op_Multiply(FPMatrix2x2 m, FPVector2 vector) { }

	// RVA: 0x7D4805C Offset: 0x7D4405C VA: 0x7D4805C
	public static FPMatrix2x2 op_Multiply(FP a, FPMatrix2x2 m) { }

	// RVA: 0x7D48098 Offset: 0x7D44098 VA: 0x7D48098
	public static FPMatrix2x2 FromRows(FP m00, FP m01, FP m10, FP m11) { }

	// RVA: 0x7D480A4 Offset: 0x7D440A4 VA: 0x7D480A4
	public static FPMatrix2x2 FromColumns(FP m00, FP m10, FP m01, FP m11) { }

	// RVA: 0x7D480B0 Offset: 0x7D440B0 VA: 0x7D480B0
	public static FPMatrix2x2 Rotate(FP rotation) { }

	// RVA: 0x7D48178 Offset: 0x7D44178 VA: 0x7D48178
	public static FPMatrix2x2 Scale(FPVector2 scale) { }

	// RVA: 0x7D48184 Offset: 0x7D44184 VA: 0x7D48184
	public FPVector2 MultiplyVector(FPVector2 v) { }

	// RVA: 0x7D481B0 Offset: 0x7D441B0 VA: 0x7D481B0
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D48208 Offset: 0x7D44208 VA: 0x7D48208 Slot: 3
	public override string ToString() { }

	// RVA: 0x7D4845C Offset: 0x7D4445C VA: 0x7D4845C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Photon.Deterministic
[DefaultMember("Item")]
[Serializable]
public struct FPMatrix3x3 // TypeDefIndex: 24032
{
	// Fields
	public const int SIZE = 72;
	public FP M00; // 0x0
	public FP M10; // 0x8
	public FP M20; // 0x10
	public FP M01; // 0x18
	public FP M11; // 0x20
	public FP M21; // 0x28
	public FP M02; // 0x30
	public FP M12; // 0x38
	public FP M22; // 0x40

	// Properties
	public static FPMatrix3x3 Zero { get; }
	public static FPMatrix3x3 Identity { get; }
	public FP Item { get; set; }
	public FP Item { get; set; }
	public FPMatrix3x3 Transposed { get; }
	public bool IsIdentity { get; }
	public FPVector3 LossyScale { get; }
	public FPMatrix3x3 Inverted { get; }
	public FP Determinant { get; }
	public FPQuaternion Rotation { get; }

	// Methods

	// RVA: 0x7D484E4 Offset: 0x7D444E4 VA: 0x7D484E4
	public static FPMatrix3x3 get_Zero() { }

	// RVA: 0x7D484F8 Offset: 0x7D444F8 VA: 0x7D484F8
	public static FPMatrix3x3 get_Identity() { }

	// RVA: 0x7D48514 Offset: 0x7D44514 VA: 0x7D48514
	public FP get_Item(int row, int column) { }

	// RVA: 0x7D485C4 Offset: 0x7D445C4 VA: 0x7D485C4
	public void set_Item(int row, int column, FP value) { }

	// RVA: 0x7D48520 Offset: 0x7D44520 VA: 0x7D48520
	public FP get_Item(int index) { }

	// RVA: 0x7D485D4 Offset: 0x7D445D4 VA: 0x7D485D4
	public void set_Item(int index, FP value) { }

	// RVA: 0x7D48678 Offset: 0x7D44678 VA: 0x7D48678
	public FPMatrix3x3 get_Transposed() { }

	// RVA: 0x7D486A4 Offset: 0x7D446A4 VA: 0x7D486A4
	public bool get_IsIdentity() { }

	// RVA: 0x7D48700 Offset: 0x7D44700 VA: 0x7D48700
	public FPVector3 get_LossyScale() { }

	// RVA: 0x7D48828 Offset: 0x7D44828 VA: 0x7D48828
	public FPMatrix3x3 get_Inverted() { }

	// RVA: 0x7D487C8 Offset: 0x7D447C8 VA: 0x7D487C8
	public FP get_Determinant() { }

	// RVA: 0x7D48964 Offset: 0x7D44964 VA: 0x7D48964
	public FPQuaternion get_Rotation() { }

	// RVA: 0x7D48B00 Offset: 0x7D44B00 VA: 0x7D48B00
	public static FPMatrix3x3 FromRows(FP m00, FP m01, FP m02, FP m10, FP m11, FP m12, FP m20, FP m21, FP m22) { }

	// RVA: 0x7D48B1C Offset: 0x7D44B1C VA: 0x7D48B1C
	public static FPMatrix3x3 FromColumns(FP m00, FP m10, FP m20, FP m01, FP m11, FP m21, FP m02, FP m12, FP m22) { }

	// RVA: 0x7D48B38 Offset: 0x7D44B38 VA: 0x7D48B38
	public static FPMatrix3x3 Scale(FPVector3 scale) { }

	// RVA: 0x7D48B58 Offset: 0x7D44B58 VA: 0x7D48B58
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D48C00 Offset: 0x7D44C00 VA: 0x7D48C00 Slot: 3
	public override string ToString() { }

	// RVA: 0x7D49020 Offset: 0x7D45020 VA: 0x7D49020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D49144 Offset: 0x7D45144 VA: 0x7D49144
	public static FPMatrix3x3 op_Addition(FPMatrix3x3 a, FPMatrix3x3 b) { }

	// RVA: 0x7D491D8 Offset: 0x7D451D8 VA: 0x7D491D8
	public static FPMatrix3x3 op_Subtraction(FPMatrix3x3 a, FPMatrix3x3 b) { }

	// RVA: 0x7D4926C Offset: 0x7D4526C VA: 0x7D4926C
	public static FPMatrix3x3 op_Multiply(FPMatrix3x3 a, FPMatrix3x3 b) { }

	// RVA: 0x7D493B4 Offset: 0x7D453B4 VA: 0x7D493B4
	public static FPVector3 op_Multiply(FPMatrix3x3 m, FPVector3 vector) { }

	// RVA: 0x7D49424 Offset: 0x7D45424 VA: 0x7D49424
	public static FPMatrix3x3 op_Multiply(FP a, FPMatrix3x3 m) { }

	// RVA: 0x7D494A0 Offset: 0x7D454A0 VA: 0x7D494A0
	public static FPMatrix3x3 Rotate(FPQuaternion q) { }

	// RVA: 0x7D4953C Offset: 0x7D4553C VA: 0x7D4953C
	public static FPMatrix3x3 RotateScale(FPQuaternion q, FPVector3 s) { }

	// RVA: 0x7D4960C Offset: 0x7D4560C VA: 0x7D4960C
	public static FPMatrix3x3 InverseRotateScale(FPQuaternion q, FPVector3 s) { }
}

// Namespace: Photon.Deterministic
[DefaultMember("Item")]
[Serializable]
public struct FPMatrix4x4 // TypeDefIndex: 24033
{
	// Fields
	public const int SIZE = 128;
	public FP M00; // 0x0
	public FP M10; // 0x8
	public FP M20; // 0x10
	public FP M30; // 0x18
	public FP M01; // 0x20
	public FP M11; // 0x28
	public FP M21; // 0x30
	public FP M31; // 0x38
	public FP M02; // 0x40
	public FP M12; // 0x48
	public FP M22; // 0x50
	public FP M32; // 0x58
	public FP M03; // 0x60
	public FP M13; // 0x68
	public FP M23; // 0x70
	public FP M33; // 0x78

	// Properties
	public static FPMatrix4x4 Zero { get; }
	public static FPMatrix4x4 Identity { get; }
	public FP Item { get; set; }
	public FP Item { get; set; }
	public FPMatrix4x4 Transposed { get; }
	public bool IsIdentity { get; }
	public FPVector3 LossyScale { get; }
	public FPMatrix4x4 Inverted { get; }
	public FP Determinant { get; }
	public FP Determinant3x3 { get; }
	public FPQuaternion Rotation { get; }

	// Methods

	// RVA: 0x7D49708 Offset: 0x7D45708 VA: 0x7D49708
	public static FPMatrix4x4 get_Zero() { }

	// RVA: 0x7D49720 Offset: 0x7D45720 VA: 0x7D49720
	public static FPMatrix4x4 get_Identity() { }

	// RVA: 0x7D49750 Offset: 0x7D45750 VA: 0x7D49750
	public FP get_Item(int row, int column) { }

	// RVA: 0x7D49834 Offset: 0x7D45834 VA: 0x7D49834
	public void set_Item(int row, int column, FP value) { }

	// RVA: 0x7D49758 Offset: 0x7D45758 VA: 0x7D49758
	public FP get_Item(int index) { }

	// RVA: 0x7D49840 Offset: 0x7D45840 VA: 0x7D49840
	public void set_Item(int index, FP value) { }

	// RVA: 0x7D4991C Offset: 0x7D4591C VA: 0x7D4991C
	public FPMatrix4x4 get_Transposed() { }

	// RVA: 0x7D49960 Offset: 0x7D45960 VA: 0x7D49960
	public bool get_IsIdentity() { }

	// RVA: 0x7D499EC Offset: 0x7D459EC VA: 0x7D499EC
	public FPVector3 get_LossyScale() { }

	// RVA: 0x7D49B38 Offset: 0x7D45B38 VA: 0x7D49B38
	public FPMatrix4x4 get_Inverted() { }

	// RVA: 0x7D49F84 Offset: 0x7D45F84 VA: 0x7D49F84
	public FP get_Determinant() { }

	// RVA: 0x7D49AB8 Offset: 0x7D45AB8 VA: 0x7D49AB8
	public FP get_Determinant3x3() { }

	// RVA: 0x7D4A0B8 Offset: 0x7D460B8 VA: 0x7D4A0B8
	public FPQuaternion get_Rotation() { }

	// RVA: 0x7D4A248 Offset: 0x7D46248 VA: 0x7D4A248
	public static FPMatrix4x4 FromRows(FP m00, FP m01, FP m02, FP m03, FP m10, FP m11, FP m12, FP m13, FP m20, FP m21, FP m22, FP m23, FP m30, FP m31, FP m32, FP m33) { }

	// RVA: 0x7D4A27C Offset: 0x7D4627C VA: 0x7D4A27C
	public static FPMatrix4x4 FromColumns(FP m00, FP m10, FP m20, FP m30, FP m01, FP m11, FP m21, FP m31, FP m02, FP m12, FP m22, FP m32, FP m03, FP m13, FP m23, FP m33) { }

	// RVA: 0x7D4A2A8 Offset: 0x7D462A8 VA: 0x7D4A2A8
	public static FPMatrix4x4 InverseLookAt(FPVector3 from, FPVector3 to, FPVector3 up) { }

	// RVA: 0x7D4A418 Offset: 0x7D46418 VA: 0x7D4A418
	public static FPMatrix4x4 LookAt(FPVector3 from, FPVector3 to, FPVector3 up) { }

	// RVA: 0x7D4A628 Offset: 0x7D46628 VA: 0x7D4A628
	public static FPMatrix4x4 Scale(FPVector3 scale) { }

	// RVA: 0x7D4A660 Offset: 0x7D46660 VA: 0x7D4A660
	public static FPMatrix4x4 Translate(FPVector3 translation) { }

	// RVA: 0x7D4A698 Offset: 0x7D46698 VA: 0x7D4A698
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D4A7B0 Offset: 0x7D467B0 VA: 0x7D4A7B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x7D4AE54 Offset: 0x7D46E54 VA: 0x7D4AE54 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D4B060 Offset: 0x7D47060 VA: 0x7D4B060
	public static FPMatrix4x4 op_Multiply(FPMatrix4x4 a, FPMatrix4x4 b) { }

	// RVA: 0x7D4B400 Offset: 0x7D47400 VA: 0x7D4B400
	public FPVector3 MultiplyPoint(FPVector3 point) { }

	// RVA: 0x7D4B4BC Offset: 0x7D474BC VA: 0x7D4B4BC
	public FPVector3 MultiplyPoint3x4(FPVector3 point) { }

	// RVA: 0x7D4B544 Offset: 0x7D47544 VA: 0x7D4B544
	public FPVector3 MultiplyVector(FPVector3 vector) { }

	// RVA: 0x7D4B5B8 Offset: 0x7D475B8 VA: 0x7D4B5B8
	public static FPMatrix4x4 TRS(FPVector3 pos, FPQuaternion q, FPVector3 s) { }

	// RVA: 0x7D4B760 Offset: 0x7D47760 VA: 0x7D4B760
	public static FPMatrix4x4 InverseTRS(FPVector3 pos, FPQuaternion q, FPVector3 s) { }

	// RVA: 0x7D4B6B0 Offset: 0x7D476B0 VA: 0x7D4B6B0
	public static FPMatrix4x4 Rotate(FPQuaternion q) { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct FPQuaternion // TypeDefIndex: 24034
{
	// Fields
	private const long RAW_180 = 11796480;
	private const long RAW_360 = 23592960;
	public const int SIZE = 32;
	public FP X; // 0x0
	public FP Y; // 0x8
	public FP Z; // 0x10
	public FP W; // 0x18

	// Properties
	public static FPQuaternion Identity { get; }
	public FPQuaternion Normalized { get; }
	public FPQuaternion Inverted { get; }
	public FPQuaternion Conjugated { get; }
	private long MagnitudeSqrRaw { get; }
	public FP MagnitudeSqr { get; }
	public FP Magnitude { get; }
	public FPVector3 AsEuler { get; }

	// Methods

	// RVA: 0x7D4B8BC Offset: 0x7D478BC VA: 0x7D4B8BC
	public static FPQuaternion get_Identity() { }

	// RVA: 0x7D4B8CC Offset: 0x7D478CC VA: 0x7D4B8CC
	public FPQuaternion get_Normalized() { }

	// RVA: 0x7D4B9C4 Offset: 0x7D479C4 VA: 0x7D4B9C4
	public FPQuaternion get_Inverted() { }

	// RVA: 0x7D496EC Offset: 0x7D456EC VA: 0x7D496EC
	public FPQuaternion get_Conjugated() { }

	// RVA: 0x7D4BAD8 Offset: 0x7D47AD8 VA: 0x7D4BAD8
	private long get_MagnitudeSqrRaw() { }

	// RVA: 0x7D4BB04 Offset: 0x7D47B04 VA: 0x7D4BB04
	public FP get_MagnitudeSqr() { }

	// RVA: 0x7D4BB30 Offset: 0x7D47B30 VA: 0x7D4BB30
	public FP get_Magnitude() { }

	// RVA: 0x7D4BB5C Offset: 0x7D47B5C VA: 0x7D4BB5C
	public FPVector3 get_AsEuler() { }

	// RVA: 0x7D4BCE4 Offset: 0x7D47CE4 VA: 0x7D4BCE4
	public static FPQuaternion Product(FPQuaternion left, FPQuaternion right) { }

	// RVA: 0x7D4BAB4 Offset: 0x7D47AB4 VA: 0x7D4BAB4
	public static FPQuaternion Conjugate(FPQuaternion value) { }

	// RVA: 0x7D4BD84 Offset: 0x7D47D84 VA: 0x7D4BD84
	public static bool IsIdentity(FPQuaternion value) { }

	// RVA: 0x7D4BDB4 Offset: 0x7D47DB4 VA: 0x7D4BDB4
	public static bool IsZero(FPQuaternion value) { }

	// RVA: 0x7D4BDE4 Offset: 0x7D47DE4 VA: 0x7D4BDE4
	public static FP Dot(FPQuaternion a, FPQuaternion b) { }

	// RVA: 0x7D4BE18 Offset: 0x7D47E18 VA: 0x7D4BE18
	public static FPQuaternion FromToRotation(FPVector3 fromVector, FPVector3 toVector) { }

	// RVA: 0x7D4C030 Offset: 0x7D48030 VA: 0x7D4C030
	public static FPQuaternion FromToRotationSkipNormalize(FPVector3 fromVector, FPVector3 toVector) { }

	// RVA: 0x7D4C140 Offset: 0x7D48140 VA: 0x7D4C140
	public static FPQuaternion Lerp(FPQuaternion a, FPQuaternion b, FP t) { }

	// RVA: 0x7D4C1BC Offset: 0x7D481BC VA: 0x7D4C1BC
	public static FPQuaternion LerpUnclamped(FPQuaternion a, FPQuaternion b, FP t) { }

	// RVA: 0x7D4C304 Offset: 0x7D48304 VA: 0x7D4C304
	public static FPQuaternion CreateFromYawPitchRoll(FP yaw, FP pitch, FP roll) { }

	// RVA: 0x7D4C4AC Offset: 0x7D484AC VA: 0x7D4C4AC
	public static FP Angle(FPQuaternion a, FPQuaternion b) { }

	// RVA: 0x7D4C564 Offset: 0x7D48564 VA: 0x7D4C564
	public static FPQuaternion LookRotation(FPVector3 forward, bool orthoNormalize = False) { }

	// RVA: 0x7D4C5F0 Offset: 0x7D485F0 VA: 0x7D4C5F0
	public static FPQuaternion LookRotation(FPVector3 forward, FPVector3 up, bool orthoNormalize = False) { }

	// RVA: 0x7D4C960 Offset: 0x7D48960 VA: 0x7D4C960
	public static FPQuaternion SimpleLookAt(FPVector3 direction) { }

	// RVA: 0x7D4CB20 Offset: 0x7D48B20 VA: 0x7D4CB20
	public static FPQuaternion SimpleLookAt(FPVector3 direction, FPVector3 up) { }

	// RVA: 0x7D4CA08 Offset: 0x7D48A08 VA: 0x7D4CA08
	public static FPQuaternion SimpleLookAt(FPVector3 direction, FPVector3 forward, FPVector3 up) { }

	// RVA: 0x7D4CD1C Offset: 0x7D48D1C VA: 0x7D4CD1C
	public static FPQuaternion Slerp(FPQuaternion from, FPQuaternion to, FP t) { }

	// RVA: 0x7D4CD98 Offset: 0x7D48D98 VA: 0x7D4CD98
	public static FPQuaternion SlerpUnclamped(FPQuaternion from, FPQuaternion to, FP t) { }

	// RVA: 0x7D4D074 Offset: 0x7D49074 VA: 0x7D4D074
	public static FPQuaternion RotateTowards(FPQuaternion from, FPQuaternion to, FP maxDegreesDelta) { }

	// RVA: 0x7D4D314 Offset: 0x7D49314 VA: 0x7D4D314
	public static FPQuaternion Euler(FP x, FP y, FP z) { }

	// RVA: 0x7D4D384 Offset: 0x7D49384 VA: 0x7D4D384
	public static FPQuaternion Euler(FPVector3 eulerAngles) { }

	// RVA: 0x7D4CBC0 Offset: 0x7D48BC0 VA: 0x7D4CBC0
	public static FPQuaternion AngleAxis(FP angle, FPVector3 axis) { }

	// RVA: 0x7D4D408 Offset: 0x7D49408 VA: 0x7D4D408
	public static FPQuaternion RadianAxis(FP radians, FPVector3 axis) { }

	// RVA: 0x7D4BA24 Offset: 0x7D47A24 VA: 0x7D4BA24
	public static FPQuaternion Inverse(FPQuaternion value) { }

	// RVA: 0x7D4B92C Offset: 0x7D4792C VA: 0x7D4B92C
	public static FPQuaternion Normalize(FPQuaternion value) { }

	// RVA: 0x7D4BF98 Offset: 0x7D47F98 VA: 0x7D4BF98
	internal static FPQuaternion NormalizeSmall(FPQuaternion value) { }

	// RVA: 0x7D4BBC0 Offset: 0x7D47BC0 VA: 0x7D4BBC0
	internal static FPVector3 ToEulerZXY(FPQuaternion value) { }

	// RVA: 0x7D4D55C Offset: 0x7D4955C VA: 0x7D4D55C
	public static FPQuaternion op_Multiply(FPQuaternion left, FPQuaternion right) { }

	// RVA: 0x7D4D5AC Offset: 0x7D495AC VA: 0x7D4D5AC
	public static FPQuaternion op_Multiply(FPQuaternion left, FP right) { }

	// RVA: 0x7D4D5E8 Offset: 0x7D495E8 VA: 0x7D4D5E8
	public static FPQuaternion op_Multiply(FP left, FPQuaternion right) { }

	// RVA: 0x7D4D61C Offset: 0x7D4961C VA: 0x7D4D61C
	public static FPQuaternion op_Addition(FPQuaternion left, FPQuaternion right) { }

	// RVA: 0x7D4D660 Offset: 0x7D49660 VA: 0x7D4D660
	public static FPQuaternion op_Subtraction(FPQuaternion left, FPQuaternion right) { }

	// RVA: 0x7D4D6A4 Offset: 0x7D496A4 VA: 0x7D4D6A4
	public static FPVector3 op_Multiply(FPQuaternion quat, FPVector3 point) { }

	// RVA: 0x7D4D794 Offset: 0x7D49794 VA: 0x7D4D794
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D48AF4 Offset: 0x7D44AF4 VA: 0x7D48AF4
	public void .ctor(FP x, FP y, FP z, FP w) { }

	// RVA: 0x7D4D7EC Offset: 0x7D497EC VA: 0x7D4D7EC Slot: 3
	public override string ToString() { }

	// RVA: 0x7D4DA40 Offset: 0x7D49A40 VA: 0x7D4DA40 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
public class FPVector2.EqualityComparer : IEqualityComparer<FPVector2> // TypeDefIndex: 24035
{
	// Fields
	public static readonly FPVector2.EqualityComparer Instance; // 0x0

	// Methods

	// RVA: 0x7D4F9C8 Offset: 0x7D4B9C8 VA: 0x7D4F9C8
	private void .ctor() { }

	// RVA: 0x7D4F9D0 Offset: 0x7D4B9D0 VA: 0x7D4F9D0 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<Photon.Deterministic.FPVector2>.Equals(FPVector2 x, FPVector2 y) { }

	// RVA: 0x7D4F9E8 Offset: 0x7D4B9E8 VA: 0x7D4F9E8 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<Photon.Deterministic.FPVector2>.GetHashCode(FPVector2 obj) { }

	// RVA: 0x7D4FA60 Offset: 0x7D4BA60 VA: 0x7D4FA60
	private static void .cctor() { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct FPVector2 : IEquatable<FPVector2> // TypeDefIndex: 24036
{
	// Fields
	public const int SIZE = 16;
	public FP X; // 0x0
	public FP Y; // 0x8

	// Properties
	public FPVector3 XXX { get; }
	public FPVector3 XXY { get; }
	public FPVector3 XYX { get; }
	public FPVector3 XYY { get; }
	public FPVector2 XX { get; }
	public FPVector2 XY { get; }
	public FPVector3 YYY { get; }
	public FPVector3 YYX { get; }
	public FPVector3 YXY { get; }
	public FPVector3 YXX { get; }
	public FPVector2 YY { get; }
	public FPVector2 YX { get; }
	public static FPVector2 Zero { get; }
	public static FPVector2 One { get; }
	public static FPVector2 Right { get; }
	public static FPVector2 Left { get; }
	public static FPVector2 Up { get; }
	public static FPVector2 Down { get; }
	public static FPVector2 MinValue { get; }
	public static FPVector2 MaxValue { get; }
	public static FPVector2 UseableMin { get; }
	public static FPVector2 UseableMax { get; }
	public FP Magnitude { get; }
	public FP SqrMagnitude { get; }
	public FPVector2 Normalized { get; }
	public FPVector3 XOY { get; }
	public FPVector3 XYO { get; }
	public FPVector3 OXY { get; }

	// Methods

	// RVA: 0x7D4DC08 Offset: 0x7D49C08 VA: 0x7D4DC08
	public FPVector3 get_XXX() { }

	// RVA: 0x7D4DC18 Offset: 0x7D49C18 VA: 0x7D4DC18
	public FPVector3 get_XXY() { }

	// RVA: 0x7D4DC28 Offset: 0x7D49C28 VA: 0x7D4DC28
	public FPVector3 get_XYX() { }

	// RVA: 0x7D4DC38 Offset: 0x7D49C38 VA: 0x7D4DC38
	public FPVector3 get_XYY() { }

	// RVA: 0x7D4DC48 Offset: 0x7D49C48 VA: 0x7D4DC48
	public FPVector2 get_XX() { }

	// RVA: 0x7D4DC54 Offset: 0x7D49C54 VA: 0x7D4DC54
	public FPVector2 get_XY() { }

	// RVA: 0x7D4DC60 Offset: 0x7D49C60 VA: 0x7D4DC60
	public FPVector3 get_YYY() { }

	// RVA: 0x7D4DC70 Offset: 0x7D49C70 VA: 0x7D4DC70
	public FPVector3 get_YYX() { }

	// RVA: 0x7D4DC84 Offset: 0x7D49C84 VA: 0x7D4DC84
	public FPVector3 get_YXY() { }

	// RVA: 0x7D4DC9C Offset: 0x7D49C9C VA: 0x7D4DC9C
	public FPVector3 get_YXX() { }

	// RVA: 0x7D4DCAC Offset: 0x7D49CAC VA: 0x7D4DCAC
	public FPVector2 get_YY() { }

	// RVA: 0x7D4DCB8 Offset: 0x7D49CB8 VA: 0x7D4DCB8
	public FPVector2 get_YX() { }

	// RVA: 0x7D4DCC4 Offset: 0x7D49CC4 VA: 0x7D4DCC4
	public static FPVector2 get_Zero() { }

	// RVA: 0x7D4DCD0 Offset: 0x7D49CD0 VA: 0x7D4DCD0
	public static FPVector2 get_One() { }

	// RVA: 0x7D4DCDC Offset: 0x7D49CDC VA: 0x7D4DCDC
	public static FPVector2 get_Right() { }

	// RVA: 0x7D4DCE8 Offset: 0x7D49CE8 VA: 0x7D4DCE8
	public static FPVector2 get_Left() { }

	// RVA: 0x7D4DCF4 Offset: 0x7D49CF4 VA: 0x7D4DCF4
	public static FPVector2 get_Up() { }

	// RVA: 0x7D4DD00 Offset: 0x7D49D00 VA: 0x7D4DD00
	public static FPVector2 get_Down() { }

	// RVA: 0x7D4DD0C Offset: 0x7D49D0C VA: 0x7D4DD0C
	public static FPVector2 get_MinValue() { }

	// RVA: 0x7D4DD18 Offset: 0x7D49D18 VA: 0x7D4DD18
	public static FPVector2 get_MaxValue() { }

	// RVA: 0x7D4DD24 Offset: 0x7D49D24 VA: 0x7D4DD24
	public static FPVector2 get_UseableMin() { }

	// RVA: 0x7D4DD30 Offset: 0x7D49D30 VA: 0x7D4DD30
	public static FPVector2 get_UseableMax() { }

	// RVA: 0x7D4DD3C Offset: 0x7D49D3C VA: 0x7D4DD3C
	public FP get_Magnitude() { }

	// RVA: 0x7D4DD58 Offset: 0x7D49D58 VA: 0x7D4DD58
	public FP get_SqrMagnitude() { }

	// RVA: 0x7D4DD70 Offset: 0x7D49D70 VA: 0x7D4DD70
	public FPVector2 get_Normalized() { }

	// RVA: 0x7D4DDD4 Offset: 0x7D49DD4 VA: 0x7D4DDD4
	public FPVector3 get_XOY() { }

	// RVA: 0x7D4DDF0 Offset: 0x7D49DF0 VA: 0x7D4DDF0
	public FPVector3 get_XYO() { }

	// RVA: 0x7D4DE00 Offset: 0x7D49E00 VA: 0x7D4DE00
	public FPVector3 get_OXY() { }

	// RVA: 0x7D4DD7C Offset: 0x7D49D7C VA: 0x7D4DD7C
	public static FPVector2 Normalize(FPVector2 value) { }

	// RVA: 0x7D4DE10 Offset: 0x7D49E10 VA: 0x7D4DE10
	public static FPVector2 Normalize(FPVector2 value, out FP magnitude) { }

	// RVA: 0x7D4DE7C Offset: 0x7D49E7C VA: 0x7D4DE7C
	public static FP Distance(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4DE9C Offset: 0x7D49E9C VA: 0x7D4DE9C
	public static FP DistanceSquared(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4DEB8 Offset: 0x7D49EB8 VA: 0x7D4DEB8
	public static FP Dot(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4DECC Offset: 0x7D49ECC VA: 0x7D4DECC
	public static FPVector2 ClampMagnitude(FPVector2 vector, FP maxLength) { }

	// RVA: 0x7D4DF50 Offset: 0x7D49F50 VA: 0x7D4DF50
	public static void Rotate(FPVector2[] vectors, FP radians) { }

	// RVA: 0x7D4DFCC Offset: 0x7D49FCC VA: 0x7D4DFCC
	public static FPVector2 Rotate(FPVector2 vector, FP radians) { }

	// RVA: 0x7D4E0B4 Offset: 0x7D4A0B4 VA: 0x7D4E0B4
	public static void Rotate(FPVector2[] vectors, FP sin, FP cos) { }

	// RVA: 0x7D4E128 Offset: 0x7D4A128 VA: 0x7D4E128
	public static FPVector2 Rotate(FPVector2 vector, FP sin, FP cos) { }

	// RVA: 0x7D4E14C Offset: 0x7D4A14C VA: 0x7D4E14C
	public static FP Cross(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4E160 Offset: 0x7D4A160 VA: 0x7D4E160
	internal static long CrossRaw(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4E174 Offset: 0x7D4A174 VA: 0x7D4E174
	public static FPVector2 Reflect(FPVector2 vector, FPVector2 normal) { }

	// RVA: 0x7D4E198 Offset: 0x7D4A198 VA: 0x7D4E198
	public static FPVector2 Clamp(FPVector2 value, FPVector2 min, FPVector2 max) { }

	// RVA: 0x7D4E1F8 Offset: 0x7D4A1F8 VA: 0x7D4E1F8
	public static FPVector2 Lerp(FPVector2 start, FPVector2 end, FP t) { }

	// RVA: 0x7D4E224 Offset: 0x7D4A224 VA: 0x7D4E224
	public static FPVector2 LerpUnclamped(FPVector2 start, FPVector2 end, FP t) { }

	// RVA: 0x7D4E240 Offset: 0x7D4A240 VA: 0x7D4E240
	public static FPVector2 Max(FPVector2 value1, FPVector2 value2) { }

	// RVA: 0x7D4E284 Offset: 0x7D4A284 VA: 0x7D4E284
	public static FPVector2 Max(FPVector2[] vectors) { }

	// RVA: 0x7D4E370 Offset: 0x7D4A370 VA: 0x7D4E370
	public static FPVector2 Min(FPVector2 value1, FPVector2 value2) { }

	// RVA: 0x7D4E3B4 Offset: 0x7D4A3B4 VA: 0x7D4E3B4
	public static FPVector2 Min(FPVector2[] vectors) { }

	// RVA: 0x7D4E4A0 Offset: 0x7D4A4A0 VA: 0x7D4E4A0
	public static FPVector2 Scale(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4E4B4 Offset: 0x7D4A4B4 VA: 0x7D4E4B4
	public static FP Angle(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4E618 Offset: 0x7D4A618 VA: 0x7D4E618
	public static FPVector2 CalculateRight(FPVector2 vector) { }

	// RVA: 0x7D4E628 Offset: 0x7D4A628 VA: 0x7D4E628
	public static FPVector2 CalculateLeft(FPVector2 vector) { }

	// RVA: 0x7D4E638 Offset: 0x7D4A638 VA: 0x7D4E638
	public bool IsRightOf(FPVector2 vector) { }

	// RVA: 0x7D4E658 Offset: 0x7D4A658 VA: 0x7D4E658
	public bool IsLeftOf(FPVector2 vector) { }

	// RVA: 0x7D4E678 Offset: 0x7D4A678 VA: 0x7D4E678
	public static FP Determinant(FPVector2 v1, FPVector2 v2) { }

	// RVA: 0x7D4E68C Offset: 0x7D4A68C VA: 0x7D4E68C
	public static FP Radians(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4E6EC Offset: 0x7D4A6EC VA: 0x7D4E6EC
	public static FP RadiansSkipNormalize(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4E71C Offset: 0x7D4A71C VA: 0x7D4E71C
	public static FP RadiansSigned(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4E770 Offset: 0x7D4A770 VA: 0x7D4E770
	public static FP RadiansSignedSkipNormalize(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4E7C4 Offset: 0x7D4A7C4 VA: 0x7D4E7C4
	public static FPVector2 SmoothStep(FPVector2 start, FPVector2 end, FP t) { }

	// RVA: 0x7D4E81C Offset: 0x7D4A81C VA: 0x7D4E81C
	public static FPVector2 Hermite(FPVector2 value1, FPVector2 tangent1, FPVector2 value2, FPVector2 tangent2, FP t) { }

	// RVA: 0x7D4E894 Offset: 0x7D4A894 VA: 0x7D4E894
	public static FPVector2 Barycentric(FPVector2 value1, FPVector2 value2, FPVector2 value3, FP t1, FP t2) { }

	// RVA: 0x7D4E90C Offset: 0x7D4A90C VA: 0x7D4E90C
	public static FPVector2 CatmullRom(FPVector2 value1, FPVector2 value2, FPVector2 value3, FPVector2 value4, FP t) { }

	// RVA: 0x7D4E984 Offset: 0x7D4A984 VA: 0x7D4E984
	public static bool IsPolygonConvex(FPVector2[] vertices) { }

	// RVA: 0x7D4EA5C Offset: 0x7D4AA5C VA: 0x7D4EA5C
	private static FP CrossProductLength(FPVector2 A, FPVector2 B, FPVector2 C) { }

	// RVA: 0x7D4EA80 Offset: 0x7D4AA80 VA: 0x7D4EA80
	public static bool IsClockWise(FPVector2[] vertices) { }

	// RVA: 0x7D4EADC Offset: 0x7D4AADC VA: 0x7D4EADC
	public static bool IsCounterClockWise(FPVector2[] vertices) { }

	// RVA: 0x7D4EAF4 Offset: 0x7D4AAF4 VA: 0x7D4EAF4
	public static void MakeCounterClockWise(FPVector2[] vertices) { }

	// RVA: 0x7D4EB60 Offset: 0x7D4AB60 VA: 0x7D4EB60
	public static void MakeClockWise(FPVector2[] vertices) { }

	// RVA: 0x7D4EB18 Offset: 0x7D4AB18 VA: 0x7D4EB18
	public static void FlipWindingOrder(FPVector2[] vertices) { }

	// RVA: 0x7D4EB84 Offset: 0x7D4AB84 VA: 0x7D4EB84
	public static FPVector2[] CalculatePolygonNormals(FPVector2[] vertices) { }

	// RVA: 0x7D4EEA4 Offset: 0x7D4AEA4 VA: 0x7D4EEA4
	public static bool PolygonNormalsAreValid(FPVector2[] vertices) { }

	// RVA: 0x7D4EF38 Offset: 0x7D4AF38 VA: 0x7D4EF38
	public static FPVector2[] RecenterPolygon(FPVector2[] vertices) { }

	// RVA: 0x7D4F164 Offset: 0x7D4B164 VA: 0x7D4F164
	public static FP CalculatePolygonArea(FPVector2[] vertices) { }

	// RVA: 0x7D4F028 Offset: 0x7D4B028 VA: 0x7D4F028
	public static FPVector2 CalculatePolygonCentroid(FPVector2[] vertices) { }

	// RVA: 0x7D4F200 Offset: 0x7D4B200 VA: 0x7D4F200
	public static FP CalculatePolygonInertiaFactor(FPVector2[] vertices) { }

	// RVA: 0x7D4F2E4 Offset: 0x7D4B2E4 VA: 0x7D4F2E4
	public static FPVector2 CalculatePolygonLocalSupport(FPVector2[] vertices, ref FPVector2 localDir) { }

	// RVA: 0x7D4F450 Offset: 0x7D4B450 VA: 0x7D4F450
	public static FPVector2 CalculatePolygonLocalSupport(FPVector2* vertices, int verticesCount, ref FPVector2 localDir) { }

	// RVA: 0x7D4F5C4 Offset: 0x7D4B5C4 VA: 0x7D4F5C4
	public static FP CalculatePolygonRadius(FPVector2[] vertices) { }

	// RVA: 0x7D4F658 Offset: 0x7D4B658 VA: 0x7D4F658
	public static FPVector2 MoveTowards(FPVector2 from, FPVector2 to, FP maxDelta) { }

	// RVA: 0x7D4F6E4 Offset: 0x7D4B6E4 VA: 0x7D4F6E4
	public static bool op_Equality(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4F6FC Offset: 0x7D4B6FC VA: 0x7D4F6FC
	public static bool op_Inequality(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4F714 Offset: 0x7D4B714 VA: 0x7D4F714
	public static FPVector2 op_UnaryNegation(FPVector2 v) { }

	// RVA: 0x7D4F720 Offset: 0x7D4B720 VA: 0x7D4F720
	public static FPVector2 op_Addition(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4F72C Offset: 0x7D4B72C VA: 0x7D4F72C
	public static FPVector2 op_Subtraction(FPVector2 a, FPVector2 b) { }

	// RVA: 0x7D4F738 Offset: 0x7D4B738 VA: 0x7D4F738
	public static FPVector2 op_Multiply(FPVector2 v, FP s) { }

	// RVA: 0x7D4F74C Offset: 0x7D4B74C VA: 0x7D4F74C
	public static FPVector2 op_Multiply(FP s, FPVector2 v) { }

	// RVA: 0x7D4F760 Offset: 0x7D4B760 VA: 0x7D4F760
	public static FPVector2 op_Multiply(FPVector2 v, int s) { }

	// RVA: 0x7D4F770 Offset: 0x7D4B770 VA: 0x7D4F770
	public static FPVector2 op_Multiply(int s, FPVector2 v) { }

	// RVA: 0x7D4F780 Offset: 0x7D4B780 VA: 0x7D4F780
	public static FPVector2 op_Division(FPVector2 v, FP s) { }

	// RVA: 0x7D4F794 Offset: 0x7D4B794 VA: 0x7D4F794
	public static FPVector2 op_Division(FPVector2 v, int s) { }

	// RVA: 0x7D4F7A4 Offset: 0x7D4B7A4 VA: 0x7D4F7A4
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D4F7DC Offset: 0x7D4B7DC VA: 0x7D4F7DC
	public void .ctor(int x, int y) { }

	// RVA: 0x7D4E1F0 Offset: 0x7D4A1F0 VA: 0x7D4E1F0
	public void .ctor(FP x, FP y) { }

	// RVA: 0x7D4F7EC Offset: 0x7D4B7EC VA: 0x7D4F7EC
	public void .ctor(FP value) { }

	// RVA: 0x7D4F7F4 Offset: 0x7D4B7F4 VA: 0x7D4F7F4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x7D4F878 Offset: 0x7D4B878 VA: 0x7D4F878 Slot: 4
	public bool Equals(FPVector2 other) { }

	// RVA: 0x7D4F894 Offset: 0x7D4B894 VA: 0x7D4F894 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D4F8D8 Offset: 0x7D4B8D8 VA: 0x7D4F8D8 Slot: 3
	public override string ToString() { }
}

// Namespace: 
public class FPVector3.EqualityComparer : IEqualityComparer<FPVector3> // TypeDefIndex: 24037
{
	// Fields
	public static readonly FPVector3.EqualityComparer Instance; // 0x0

	// Methods

	// RVA: 0x7D5133C Offset: 0x7D4D33C VA: 0x7D5133C
	private void .ctor() { }

	// RVA: 0x7D51344 Offset: 0x7D4D344 VA: 0x7D51344 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<Photon.Deterministic.FPVector3>.Equals(FPVector3 x, FPVector3 y) { }

	// RVA: 0x7D5137C Offset: 0x7D4D37C VA: 0x7D5137C Slot: 5
	private int System.Collections.Generic.IEqualityComparer<Photon.Deterministic.FPVector3>.GetHashCode(FPVector3 obj) { }

	// RVA: 0x7D51384 Offset: 0x7D4D384 VA: 0x7D51384
	private static void .cctor() { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct FPVector3 : IEquatable<FPVector3> // TypeDefIndex: 24038
{
	// Fields
	public const int SIZE = 24;
	public FP X; // 0x0
	public FP Y; // 0x8
	public FP Z; // 0x10

	// Properties
	public FPVector3 XXX { get; }
	public FPVector3 XXY { get; }
	public FPVector3 XXZ { get; }
	public FPVector3 XYX { get; }
	public FPVector3 XYY { get; }
	public FPVector3 XYZ { get; }
	public FPVector3 XZX { get; }
	public FPVector3 XZY { get; }
	public FPVector3 XZZ { get; }
	public FPVector2 XX { get; }
	public FPVector2 XY { get; }
	public FPVector2 XZ { get; }
	public FPVector3 YYY { get; }
	public FPVector3 YYZ { get; }
	public FPVector3 YYX { get; }
	public FPVector3 YZY { get; }
	public FPVector3 YZZ { get; }
	public FPVector3 YZX { get; }
	public FPVector3 YXY { get; }
	public FPVector3 YXZ { get; }
	public FPVector3 YXX { get; }
	public FPVector2 YY { get; }
	public FPVector2 YZ { get; }
	public FPVector2 YX { get; }
	public FPVector3 ZZZ { get; }
	public FPVector3 ZZX { get; }
	public FPVector3 ZZY { get; }
	public FPVector3 ZXZ { get; }
	public FPVector3 ZXX { get; }
	public FPVector3 ZXY { get; }
	public FPVector3 ZYZ { get; }
	public FPVector3 ZYX { get; }
	public FPVector3 ZYY { get; }
	public FPVector2 ZZ { get; }
	public FPVector2 ZX { get; }
	public FPVector2 ZY { get; }
	public static FPVector3 Zero { get; }
	public static FPVector3 Left { get; }
	public static FPVector3 Right { get; }
	public static FPVector3 Up { get; }
	public static FPVector3 Up_05 { get; }
	public static FPVector3 Up_08 { get; }
	public static FPVector3 Down { get; }
	public static FPVector3 Back { get; }
	public static FPVector3 Forward { get; }
	public static FPVector3 One { get; }
	public static FPVector3 MinValue { get; }
	public static FPVector3 MaxValue { get; }
	public static FPVector3 UseableMin { get; }
	public static FPVector3 UseableMax { get; }
	public FP SqrMagnitude { get; }
	public FP Magnitude { get; }
	public FPVector3 Normalized { get; }

	// Methods

	// RVA: 0x7D4FAC8 Offset: 0x7D4BAC8 VA: 0x7D4FAC8
	public FPVector3 get_XXX() { }

	// RVA: 0x7D4FAD8 Offset: 0x7D4BAD8 VA: 0x7D4FAD8
	public FPVector3 get_XXY() { }

	// RVA: 0x7D4FAE8 Offset: 0x7D4BAE8 VA: 0x7D4FAE8
	public FPVector3 get_XXZ() { }

	// RVA: 0x7D4FAFC Offset: 0x7D4BAFC VA: 0x7D4FAFC
	public FPVector3 get_XYX() { }

	// RVA: 0x7D4FB0C Offset: 0x7D4BB0C VA: 0x7D4FB0C
	public FPVector3 get_XYY() { }

	// RVA: 0x7D4FB1C Offset: 0x7D4BB1C VA: 0x7D4FB1C
	public FPVector3 get_XYZ() { }

	// RVA: 0x7D4FB30 Offset: 0x7D4BB30 VA: 0x7D4FB30
	public FPVector3 get_XZX() { }

	// RVA: 0x7D4FB44 Offset: 0x7D4BB44 VA: 0x7D4FB44
	public FPVector3 get_XZY() { }

	// RVA: 0x7D4FB5C Offset: 0x7D4BB5C VA: 0x7D4FB5C
	public FPVector3 get_XZZ() { }

	// RVA: 0x7D4FB70 Offset: 0x7D4BB70 VA: 0x7D4FB70
	public FPVector2 get_XX() { }

	// RVA: 0x7D4FB7C Offset: 0x7D4BB7C VA: 0x7D4FB7C
	public FPVector2 get_XY() { }

	// RVA: 0x7D4FB88 Offset: 0x7D4BB88 VA: 0x7D4FB88
	public FPVector2 get_XZ() { }

	// RVA: 0x7D4FB98 Offset: 0x7D4BB98 VA: 0x7D4FB98
	public FPVector3 get_YYY() { }

	// RVA: 0x7D4FBA8 Offset: 0x7D4BBA8 VA: 0x7D4FBA8
	public FPVector3 get_YYZ() { }

	// RVA: 0x7D4FBB8 Offset: 0x7D4BBB8 VA: 0x7D4FBB8
	public FPVector3 get_YYX() { }

	// RVA: 0x7D4FBCC Offset: 0x7D4BBCC VA: 0x7D4FBCC
	public FPVector3 get_YZY() { }

	// RVA: 0x7D4FBDC Offset: 0x7D4BBDC VA: 0x7D4FBDC
	public FPVector3 get_YZZ() { }

	// RVA: 0x7D4FBEC Offset: 0x7D4BBEC VA: 0x7D4FBEC
	public FPVector3 get_YZX() { }

	// RVA: 0x7D4FC00 Offset: 0x7D4BC00 VA: 0x7D4FC00
	public FPVector3 get_YXY() { }

	// RVA: 0x7D4FC18 Offset: 0x7D4BC18 VA: 0x7D4FC18
	public FPVector3 get_YXZ() { }

	// RVA: 0x7D4FC30 Offset: 0x7D4BC30 VA: 0x7D4FC30
	public FPVector3 get_YXX() { }

	// RVA: 0x7D4FC40 Offset: 0x7D4BC40 VA: 0x7D4FC40
	public FPVector2 get_YY() { }

	// RVA: 0x7D4FC4C Offset: 0x7D4BC4C VA: 0x7D4FC4C
	public FPVector2 get_YZ() { }

	// RVA: 0x7D4FC58 Offset: 0x7D4BC58 VA: 0x7D4FC58
	public FPVector2 get_YX() { }

	// RVA: 0x7D4FC64 Offset: 0x7D4BC64 VA: 0x7D4FC64
	public FPVector3 get_ZZZ() { }

	// RVA: 0x7D4FC74 Offset: 0x7D4BC74 VA: 0x7D4FC74
	public FPVector3 get_ZZX() { }

	// RVA: 0x7D4FC88 Offset: 0x7D4BC88 VA: 0x7D4FC88
	public FPVector3 get_ZZY() { }

	// RVA: 0x7D4FC9C Offset: 0x7D4BC9C VA: 0x7D4FC9C
	public FPVector3 get_ZXZ() { }

	// RVA: 0x7D4FCB0 Offset: 0x7D4BCB0 VA: 0x7D4FCB0
	public FPVector3 get_ZXX() { }

	// RVA: 0x7D4FCC4 Offset: 0x7D4BCC4 VA: 0x7D4FCC4
	public FPVector3 get_ZXY() { }

	// RVA: 0x7D4FCD8 Offset: 0x7D4BCD8 VA: 0x7D4FCD8
	public FPVector3 get_ZYZ() { }

	// RVA: 0x7D4FCF0 Offset: 0x7D4BCF0 VA: 0x7D4FCF0
	public FPVector3 get_ZYX() { }

	// RVA: 0x7D4FD08 Offset: 0x7D4BD08 VA: 0x7D4FD08
	public FPVector3 get_ZYY() { }

	// RVA: 0x7D4FD18 Offset: 0x7D4BD18 VA: 0x7D4FD18
	public FPVector2 get_ZZ() { }

	// RVA: 0x7D4FD24 Offset: 0x7D4BD24 VA: 0x7D4FD24
	public FPVector2 get_ZX() { }

	// RVA: 0x7D4FD34 Offset: 0x7D4BD34 VA: 0x7D4FD34
	public FPVector2 get_ZY() { }

	// RVA: 0x7D4FD40 Offset: 0x7D4BD40 VA: 0x7D4FD40
	public static FPVector3 get_Zero() { }

	// RVA: 0x7D4FD4C Offset: 0x7D4BD4C VA: 0x7D4FD4C
	public static FPVector3 get_Left() { }

	// RVA: 0x7D4FD5C Offset: 0x7D4BD5C VA: 0x7D4FD5C
	public static FPVector3 get_Right() { }

	// RVA: 0x7D4FD6C Offset: 0x7D4BD6C VA: 0x7D4FD6C
	public static FPVector3 get_Up() { }

	// RVA: 0x7D4FD80 Offset: 0x7D4BD80 VA: 0x7D4FD80
	public static FPVector3 get_Up_05() { }

	// RVA: 0x7D4FD94 Offset: 0x7D4BD94 VA: 0x7D4FD94
	public static FPVector3 get_Up_08() { }

	// RVA: 0x7D4FDA8 Offset: 0x7D4BDA8 VA: 0x7D4FDA8
	public static FPVector3 get_Down() { }

	// RVA: 0x7D4FDBC Offset: 0x7D4BDBC VA: 0x7D4FDBC
	public static FPVector3 get_Back() { }

	// RVA: 0x7D4FDCC Offset: 0x7D4BDCC VA: 0x7D4FDCC
	public static FPVector3 get_Forward() { }

	// RVA: 0x7D4FDDC Offset: 0x7D4BDDC VA: 0x7D4FDDC
	public static FPVector3 get_One() { }

	// RVA: 0x7D4FDF0 Offset: 0x7D4BDF0 VA: 0x7D4FDF0
	public static FPVector3 get_MinValue() { }

	// RVA: 0x7D4FE04 Offset: 0x7D4BE04 VA: 0x7D4FE04
	public static FPVector3 get_MaxValue() { }

	// RVA: 0x7D4FE18 Offset: 0x7D4BE18 VA: 0x7D4FE18
	public static FPVector3 get_UseableMin() { }

	// RVA: 0x7D4FE2C Offset: 0x7D4BE2C VA: 0x7D4FE2C
	public static FPVector3 get_UseableMax() { }

	// RVA: 0x7D4FE40 Offset: 0x7D4BE40 VA: 0x7D4FE40
	public FP get_SqrMagnitude() { }

	// RVA: 0x7D4FE64 Offset: 0x7D4BE64 VA: 0x7D4FE64
	public FP get_Magnitude() { }

	// RVA: 0x7D4FE8C Offset: 0x7D4BE8C VA: 0x7D4FE8C
	public FPVector3 get_Normalized() { }

	// RVA: 0x7D4FEF8 Offset: 0x7D4BEF8 VA: 0x7D4FEF8
	public static FPVector3 Normalize(FPVector3 value) { }

	// RVA: 0x7D4FF84 Offset: 0x7D4BF84 VA: 0x7D4FF84
	public static FPVector3 Normalize(FPVector3 value, out FP magnitude) { }

	// RVA: 0x7D50028 Offset: 0x7D4C028 VA: 0x7D50028
	public static FPVector3 Abs(FPVector3 value) { }

	// RVA: 0x7D50060 Offset: 0x7D4C060 VA: 0x7D50060
	public static FPVector3 Lerp(FPVector3 start, FPVector3 end, FP t) { }

	// RVA: 0x7D500C4 Offset: 0x7D4C0C4 VA: 0x7D500C4
	public static FPVector3 LerpUnclamped(FPVector3 start, FPVector3 end, FP t) { }

	// RVA: 0x7D50118 Offset: 0x7D4C118 VA: 0x7D50118
	public static FPVector3 Slerp(FPVector3 from, FPVector3 to, FP t) { }

	// RVA: 0x7D501A8 Offset: 0x7D4C1A8 VA: 0x7D501A8
	public static FPVector3 SlerpUnclamped(FPVector3 from, FPVector3 to, FP t) { }

	// RVA: 0x7D50564 Offset: 0x7D4C564 VA: 0x7D50564
	public static FPVector3 Scale(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D505AC Offset: 0x7D4C5AC VA: 0x7D505AC
	public static FPVector3 ClampMagnitude(FPVector3 vector, FP maxLength) { }

	// RVA: 0x7D5068C Offset: 0x7D4C68C VA: 0x7D5068C
	public static FPVector3 Min(FPVector3 value1, FPVector3 value2) { }

	// RVA: 0x7D506D4 Offset: 0x7D4C6D4 VA: 0x7D506D4
	public static FPVector3 Max(FPVector3 value1, FPVector3 value2) { }

	// RVA: 0x7D5071C Offset: 0x7D4C71C VA: 0x7D5071C
	public static FP Distance(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D5077C Offset: 0x7D4C77C VA: 0x7D5077C
	public static FP DistanceSquared(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D507CC Offset: 0x7D4C7CC VA: 0x7D507CC
	public static FPVector3 Cross(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D50818 Offset: 0x7D4C818 VA: 0x7D50818
	public static FP Dot(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D5084C Offset: 0x7D4C84C VA: 0x7D5084C
	public static FP SignedAngle(FPVector3 a, FPVector3 b, FPVector3 axis) { }

	// RVA: 0x7D50934 Offset: 0x7D4C934 VA: 0x7D50934
	public static FP Angle(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D50AEC Offset: 0x7D4CAEC VA: 0x7D50AEC
	public static FPVector3 MoveTowards(FPVector3 from, FPVector3 to, FP maxDelta) { }

	// RVA: 0x7D50BBC Offset: 0x7D4CBBC VA: 0x7D50BBC
	public static FPVector3 Project(FPVector3 vector, FPVector3 normal) { }

	// RVA: 0x7D50C40 Offset: 0x7D4CC40 VA: 0x7D50C40
	public static FPVector3 ProjectOnPlane(FPVector3 vector, FPVector3 planeNormal) { }

	// RVA: 0x7D50CD8 Offset: 0x7D4CCD8 VA: 0x7D50CD8
	public static FPVector3 Reflect(FPVector3 vector, FPVector3 normal) { }

	// RVA: 0x7D50D28 Offset: 0x7D4CD28 VA: 0x7D50D28
	internal static bool Barycentric(FPVector3 p, FPVector3 p0, FPVector3 p1, FPVector3 p2, out FP u, out FP v, out FP w) { }

	// RVA: 0x7D50E64 Offset: 0x7D4CE64 VA: 0x7D50E64
	public static bool op_Equality(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D50EA0 Offset: 0x7D4CEA0 VA: 0x7D50EA0
	public static bool op_Inequality(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D50EDC Offset: 0x7D4CEDC VA: 0x7D50EDC
	public static FPVector3 op_UnaryNegation(FPVector3 v) { }

	// RVA: 0x7D50F04 Offset: 0x7D4CF04 VA: 0x7D50F04
	public static FPVector3 op_Multiply(FPVector3 v, FP s) { }

	// RVA: 0x7D50F3C Offset: 0x7D4CF3C VA: 0x7D50F3C
	public static FPVector3 op_Multiply(FP s, FPVector3 v) { }

	// RVA: 0x7D50F74 Offset: 0x7D4CF74 VA: 0x7D50F74
	public static FPVector3 op_Division(FPVector3 v, FP s) { }

	// RVA: 0x7D50FAC Offset: 0x7D4CFAC VA: 0x7D50FAC
	public static FPVector3 op_Division(FPVector3 v, int s) { }

	// RVA: 0x7D50FDC Offset: 0x7D4CFDC VA: 0x7D50FDC
	public static FPVector3 op_Subtraction(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D51018 Offset: 0x7D4D018 VA: 0x7D51018
	public static FPVector3 op_Addition(FPVector3 a, FPVector3 b) { }

	// RVA: 0x7D51054 Offset: 0x7D4D054 VA: 0x7D51054
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D5109C Offset: 0x7D4D09C VA: 0x7D5109C
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x7D510B4 Offset: 0x7D4D0B4 VA: 0x7D510B4
	public void .ctor(int x, int y) { }

	// RVA: 0x7D4DDE4 Offset: 0x7D49DE4 VA: 0x7D4DDE4
	public void .ctor(FP x, FP y, FP z) { }

	// RVA: 0x7D510C8 Offset: 0x7D4D0C8 VA: 0x7D510C8
	public void .ctor(FP x, FP y) { }

	// RVA: 0x7D510D4 Offset: 0x7D4D0D4 VA: 0x7D510D4 Slot: 3
	public override string ToString() { }

	// RVA: 0x7D511F8 Offset: 0x7D4D1F8 VA: 0x7D511F8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x7D5129C Offset: 0x7D4D29C VA: 0x7D5129C Slot: 4
	public bool Equals(FPVector3 other) { }

	// RVA: 0x7D512D8 Offset: 0x7D4D2D8 VA: 0x7D512D8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Photon.Deterministic
public interface IBitStream // TypeDefIndex: 24039
{
	// Properties
	public abstract int BytesRequired { get; }
	public abstract byte[] Data { get; }
	public abstract bool Writing { get; set; }
	public abstract bool Reading { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_BytesRequired();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte[] get_Data();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_Writing();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Writing(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_Reading();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_Reading(bool value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Serialize(ref string value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Serialize(ref bool value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Serialize(ref float value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Serialize(ref double value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Serialize(ref long value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Serialize(ref ulong value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Serialize(ref FP value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Serialize(ref FPVector2 value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Serialize(ref FPVector3 value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void Serialize(ref FPQuaternion value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Serialize(ref byte value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Serialize(ref uint value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Serialize(ref uint value, int bits);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void Serialize(ref ulong value, int bits);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Serialize(ref int value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Serialize(ref int value, int bits);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void Serialize(ref int[] value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void Serialize(ref byte[] value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void Serialize(ref byte[] array, ref int length);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void Serialize(ref byte[] value, int fixedSize);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void Serialize(ref byte[] array, ref int length, int fixedSize);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SerializeArrayLength<T>(ref T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IBitStream.SerializeArrayLength<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SerializeArray<T>(ref T[] array, BitStream.ArrayElementSerializer<T> serializer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IBitStream.SerializeArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Serialize(byte* v);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void Serialize(sbyte* v);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void Serialize(short* v);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void Serialize(ushort* v);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void Serialize(int* v);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void Serialize(uint* v);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void Serialize(long* v);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void Serialize(ulong* v);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void Serialize(int* v, int bits);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void Serialize(uint* v, int bits);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void SerializeBuffer(byte* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract void SerializeBuffer(sbyte* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void SerializeBuffer(short* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract void SerializeBuffer(ushort* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void SerializeBuffer(int* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void SerializeBuffer(uint* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract void SerializeBuffer(long* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract void SerializeBuffer(ulong* buffer, int length);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract bool Condition(bool condition);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract bool ReadBool();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract bool ReadBoolean();

	// RVA: -1 Offset: -1 Slot: 50
	public abstract bool WriteBool(bool b);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract bool WriteBoolean(bool b);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract int ReadInt();

	// RVA: -1 Offset: -1 Slot: 53
	public abstract void WriteInt(int v);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract void WriteUInt(uint v);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract uint ReadUInt();

	// RVA: -1 Offset: -1 Slot: 56
	public abstract FP ReadFP();

	// RVA: -1 Offset: -1 Slot: 57
	public abstract void WriteFP(FP fp);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract FPVector2 ReadFPVector2();

	// RVA: -1 Offset: -1 Slot: 59
	public abstract void WriteFPVector2(FPVector2 fpVector2);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract FPVector3 ReadFPVector3();

	// RVA: -1 Offset: -1 Slot: 61
	public abstract void WriteFPVector3(FPVector3 fpVector3);

	// RVA: -1 Offset: -1 Slot: 62
	public abstract long ReadLong();

	// RVA: -1 Offset: -1 Slot: 63
	public abstract void WriteLong(long v);

	// RVA: -1 Offset: -1 Slot: 64
	public abstract ulong ReadULong();

	// RVA: -1 Offset: -1 Slot: 65
	public abstract void WriteULong(ulong v);

	// RVA: -1 Offset: -1 Slot: 66
	public abstract byte ReadByte();

	// RVA: -1 Offset: -1 Slot: 67
	public abstract void WriteByte(byte p0);

	// RVA: -1 Offset: -1 Slot: 68
	public abstract void CopyFromArray(byte[] data);

	// RVA: -1 Offset: -1 Slot: 69
	public abstract byte[] ToArray();

	// RVA: -1 Offset: -1 Slot: 70
	public abstract void Reset();
}

// Namespace: Photon.Deterministic
public interface IDeterministicFrameSerializer // TypeDefIndex: 24040
{
	// Properties
	public abstract bool Writing { get; }
	public abstract bool Reading { get; }
	public abstract IBitStream Stream { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Writing();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Reading();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IBitStream get_Stream();
}

// Namespace: Photon.Deterministic
public interface IDeterministicGame // TypeDefIndex: 24041
{
	// Properties
	public abstract DeterministicSession Session { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DeterministicSession get_Session();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDisposable CreateFrameContext();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DeterministicFrame CreateFrame(IDisposable context);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnDestroy();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AssignSession(DeterministicSession session);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnGameStart(DeterministicFrame state);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnSimulate(DeterministicFrame state);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnSimulateFinished(DeterministicFrame state);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnUpdateDone();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnSimulationEnd();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnSimulationBegin();
}

// Namespace: Photon.Deterministic
public interface IDeterministicPlatformTaskRunner // TypeDefIndex: 24042
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Schedule(Action[] delegates);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void WaitForComplete();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool PollForComplete();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Log.<>c // TypeDefIndex: 24043
{
	// Fields
	public static readonly Log.<>c <>9; // 0x0
	public static Action<string> <>9__6_0; // 0x8
	public static Action<string> <>9__6_1; // 0x10
	public static Action<string> <>9__6_2; // 0x18
	public static Action<Exception> <>9__6_3; // 0x20
	public static Action<Exception> <>9__7_0; // 0x28

	// Methods

	// RVA: 0x7D52D0C Offset: 0x7D4ED0C VA: 0x7D52D0C
	private static void .cctor() { }

	// RVA: 0x7D52D74 Offset: 0x7D4ED74 VA: 0x7D52D74
	public void .ctor() { }

	// RVA: 0x7D52D7C Offset: 0x7D4ED7C VA: 0x7D52D7C
	internal void <InitForConsole>b__6_0(string info) { }

	// RVA: 0x7D52DEC Offset: 0x7D4EDEC VA: 0x7D52DEC
	internal void <InitForConsole>b__6_1(string warn) { }

	// RVA: 0x7D52E5C Offset: 0x7D4EE5C VA: 0x7D52E5C
	internal void <InitForConsole>b__6_2(string error) { }

	// RVA: 0x7D52ECC Offset: 0x7D4EECC VA: 0x7D52ECC
	internal void <InitForConsole>b__6_3(Exception exn) { }

	// RVA: 0x7D52F68 Offset: 0x7D4EF68 VA: 0x7D52F68
	internal void <InitFile>b__7_0(Exception x) { }
}

// Namespace: Photon.Deterministic
internal static class Log // TypeDefIndex: 24044
{
	// Fields
	private static StreamWriter writer; // 0x0
	private static object sync; // 0x8
	private static Action<string> infoCallback; // 0x10
	private static Action<string> warnCallback; // 0x18
	private static Action<string> errorCallback; // 0x20
	private static Action<Exception> exnCallback; // 0x28

	// Methods

	// RVA: 0x7D513EC Offset: 0x7D4D3EC VA: 0x7D513EC
	public static void InitForConsole() { }

	// RVA: 0x7D51754 Offset: 0x7D4D754 VA: 0x7D51754
	public static void InitFile(string path) { }

	// RVA: 0x7D51670 Offset: 0x7D4D670 VA: 0x7D51670
	public static void Init(Action<string> info, Action<string> warn, Action<string> error, Action<Exception> exn) { }

	// RVA: 0x7D51960 Offset: 0x7D4D960 VA: 0x7D51960
	public static void Reset() { }

	[Conditional("TRACE")]
	// RVA: 0x7D51AAC Offset: 0x7D4DAAC VA: 0x7D51AAC
	public static void Trace(object value) { }

	[Conditional("TRACE")]
	// RVA: 0x7D51BFC Offset: 0x7D4DBFC VA: 0x7D51BFC
	public static void Trace(string fmt, object[] args) { }

	// RVA: 0x7D51AB0 Offset: 0x7D4DAB0 VA: 0x7D51AB0
	public static void Info(object value) { }

	// RVA: 0x7D51C00 Offset: 0x7D4DC00 VA: 0x7D51C00
	public static void Info(string fmt, object[] args) { }

	// RVA: 0x7D51D2C Offset: 0x7D4DD2C VA: 0x7D51D2C
	public static void Info(string fmt, string arg0) { }

	// RVA: 0x7D51E58 Offset: 0x7D4DE58 VA: 0x7D51E58
	public static void Info(string fmt, string arg0, string arg1) { }

	// RVA: 0x7D51F94 Offset: 0x7D4DF94 VA: 0x7D51F94
	public static void Info(string fmt, string arg0, string arg1, string arg2) { }

	// RVA: 0x7D4ED78 Offset: 0x7D4AD78 VA: 0x7D4ED78
	public static void Warn(string fmt, object[] args) { }

	// RVA: 0x7D520D8 Offset: 0x7D4E0D8 VA: 0x7D520D8
	public static void Warn(string fmt, string arg0) { }

	// RVA: 0x7D52204 Offset: 0x7D4E204 VA: 0x7D52204
	public static void Warn(string fmt, string arg0, string arg1) { }

	// RVA: 0x7D52340 Offset: 0x7D4E340 VA: 0x7D52340
	public static void Warn(string fmt, string arg0, string arg1, string arg2) { }

	// RVA: 0x7D52484 Offset: 0x7D4E484 VA: 0x7D52484
	public static void Warn(object value) { }

	// RVA: 0x7D525D0 Offset: 0x7D4E5D0 VA: 0x7D525D0
	public static void Error(string fmt, object[] args) { }

	// RVA: 0x7D526FC Offset: 0x7D4E6FC VA: 0x7D526FC
	public static void Error(string fmt, string arg0) { }

	// RVA: 0x7D52828 Offset: 0x7D4E828 VA: 0x7D52828
	public static void Error(string fmt, string arg0, string arg1) { }

	// RVA: 0x7D52964 Offset: 0x7D4E964 VA: 0x7D52964
	public static void Error(string fmt, string arg0, string arg1, string arg2) { }

	// RVA: 0x7D52AA8 Offset: 0x7D4EAA8 VA: 0x7D52AA8
	public static void Error(object value) { }

	// RVA: 0x7D52BF4 Offset: 0x7D4EBF4 VA: 0x7D52BF4
	public static void Exception(Exception exn) { }
}

// Namespace: Photon.Deterministic
internal class LutGenerator // TypeDefIndex: 24045
{
	// Fields
	private const long ATAN_DENSITY1_COVER = 6;
	public const long ATAN_SIZE_DENSITY1 = 393216;
	public const int ATAN_DENSITY2_COVER = 250;
	public const long ATAN_DENSITY2_COVER_RAW = 16384000;
	public const long ATAN_SIZE_DENSITY2 = 3904;
	public const int ATAN_DENSITY3_COVER = 10000;
	public const int ATAN_DENSITY3_COVER_RAW = 655360000;
	public const long ATAN_SIZE_DENSITY3 = 609;
	public const string TABLE_NAME_SIN_COS = "FPSinCos";
	public const string TABLE_NAME_TAN = "FPTan";
	public const string TABLE_NAME_ASIN = "FPAsin";
	public const string TABLE_NAME_ACOS = "FPAcos";
	public const string TABLE_NAME_ATAN = "FPAtan";
	public const string TABLE_NAME_SQRT = "FPSqrt";

	// Methods

	// RVA: 0x7D52FE4 Offset: 0x7D4EFE4 VA: 0x7D52FE4
	private static void Generate(Func<double, double> op, string file, long min, long max) { }

	// RVA: 0x7D53320 Offset: 0x7D4F320 VA: 0x7D53320
	private static void GenerateSqrt(string file) { }

	// RVA: 0x7D536A4 Offset: 0x7D4F6A4 VA: 0x7D536A4
	public static void GenerateSinCosPacked(string file) { }

	// RVA: 0x7D53A5C Offset: 0x7D4FA5C VA: 0x7D53A5C
	public static void GenerateAtan(string file) { }

	// RVA: 0x7D53F54 Offset: 0x7D4FF54 VA: 0x7D53F54
	public static void Generate(string directoryPath) { }

	// RVA: 0x7D5418C Offset: 0x7D5018C VA: 0x7D5418C
	public void .ctor() { }
}

// Namespace: Photon.Deterministic
public sealed class LutProvider : MulticastDelegate // TypeDefIndex: 24046
{
	// Methods

	// RVA: 0x7D54194 Offset: 0x7D50194 VA: 0x7D54194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7D54244 Offset: 0x7D50244 VA: 0x7D54244 Slot: 13
	public virtual byte[] Invoke(string path) { }

	// RVA: 0x7D54258 Offset: 0x7D50258 VA: 0x7D54258 Slot: 14
	public virtual IAsyncResult BeginInvoke(string path, AsyncCallback callback, object object) { }

	// RVA: 0x7D54278 Offset: 0x7D50278 VA: 0x7D54278 Slot: 15
	public virtual byte[] EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public struct Native.ObjectHandle // TypeDefIndex: 24047
{
	// Fields
	public readonly IntPtr Address; // 0x0
	public readonly ulong Identifier; // 0x8

	// Methods

	// RVA: 0x7D543CC Offset: 0x7D503CC VA: 0x7D543CC
	public void .ctor(IntPtr address) { }

	// RVA: 0x7D543D4 Offset: 0x7D503D4 VA: 0x7D543D4
	public void .ctor(ulong identifier) { }
}

// Namespace: 
public abstract class Native.Allocator // TypeDefIndex: 24048
{
	// Fields
	private readonly HashSet<IntPtr> _allocated; // 0x10

	// Methods

	// RVA: 0x7D543DC Offset: 0x7D503DC VA: 0x7D543DC
	protected void TrackAlloc(void* ptr) { }

	// RVA: 0x7D544EC Offset: 0x7D504EC VA: 0x7D544EC
	protected void TrackFree(void* ptr) { }

	// RVA: 0x7D5468C Offset: 0x7D5068C VA: 0x7D5468C
	public void Dispose() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Free(void* ptr);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void* Alloc(int count);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void* Alloc(int count, int alignment);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void Clear(void* dest, int count);

	// RVA: 0x7D54A14 Offset: 0x7D50A14 VA: 0x7D54A14
	public void* AllocAndClear(int count) { }

	// RVA: 0x7D54A5C Offset: 0x7D50A5C VA: 0x7D54A5C
	public void* AllocAndClear(int count, int alignment) { }

	// RVA: -1 Offset: -1
	public T* AllocAndClear<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x479BCE8 Offset: 0x4797CE8 VA: 0x479BCE8
	|-Native.Allocator.AllocAndClear<UnsafeHashMap>
	|
	|-RVA: 0x479BD30 Offset: 0x4797D30 VA: 0x479BD30
	|-Native.Allocator.AllocAndClear<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x479BD9C Offset: 0x4797D9C VA: 0x479BD9C
	|-Native.Allocator.AllocAndClear<FrameBase.Culling.CullingData>
	*/

	// RVA: -1 Offset: -1
	public T* Alloc<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x479BCA4 Offset: 0x4797CA4 VA: 0x479BCA4
	|-Native.Allocator.Alloc<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7D54AA4 Offset: 0x7D50AA4 VA: 0x7D54AA4
	public void* Expand(void* buffer, int currentSize, int newSize) { }

	// RVA: -1 Offset: -1
	public T* ExpandArray<T>(T* buffer, int currentSize, int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x479BDE4 Offset: 0x4797DE4 VA: 0x479BDE4
	|-Native.Allocator.ExpandArray<Bucket>
	|
	|-RVA: 0x479BEB0 Offset: 0x4797EB0 VA: 0x479BEB0
	|-Native.Allocator.ExpandArray<Bucket3D>
	|
	|-RVA: 0x479BF7C Offset: 0x4797F7C VA: 0x479BF7C
	|-Native.Allocator.ExpandArray<CollisionManifold2D>
	|
	|-RVA: 0x479C048 Offset: 0x4798048 VA: 0x479C048
	|-Native.Allocator.ExpandArray<CollisionManifold3D>
	|
	|-RVA: 0x479C114 Offset: 0x4798114 VA: 0x479C114
	|-Native.Allocator.ExpandArray<Entry2D>
	|
	|-RVA: 0x479C1E0 Offset: 0x47981E0 VA: 0x479C1E0
	|-Native.Allocator.ExpandArray<Entry3D>
	|
	|-RVA: 0x479C2AC Offset: 0x47982AC VA: 0x479C2AC
	|-Native.Allocator.ExpandArray<HitCollection>
	|
	|-RVA: 0x479C37C Offset: 0x479837C VA: 0x479C37C
	|-Native.Allocator.ExpandArray<HitCollection3D>
	|
	|-RVA: 0x479C44C Offset: 0x479844C VA: 0x479C44C
	|-Native.Allocator.ExpandArray<int>
	|
	|-RVA: 0x479C514 Offset: 0x4798514 VA: 0x479C514
	|-Native.Allocator.ExpandArray<Island2D>
	|
	|-RVA: 0x479C5DC Offset: 0x47985DC VA: 0x479C5DC
	|-Native.Allocator.ExpandArray<Island3D>
	|
	|-RVA: 0x479C6A4 Offset: 0x47986A4 VA: 0x479C6A4
	|-Native.Allocator.ExpandArray<Query2D>
	|
	|-RVA: 0x479C774 Offset: 0x4798774 VA: 0x479C774
	|-Native.Allocator.ExpandArray<Query3D>
	|
	|-RVA: 0x479C840 Offset: 0x4798840 VA: 0x479C840
	|-Native.Allocator.ExpandArray<QueryManifold>
	|
	|-RVA: 0x479C908 Offset: 0x4798908 VA: 0x479C908
	|-Native.Allocator.ExpandArray<QueryManifold3D>
	|
	|-RVA: 0x479C9D8 Offset: 0x47989D8 VA: 0x479C9D8
	|-Native.Allocator.ExpandArray<TriangleReference>
	|
	|-RVA: 0x479CAA0 Offset: 0x4798AA0 VA: 0x479CAA0
	|-Native.Allocator.ExpandArray<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x479CB74 Offset: 0x4798B74 VA: 0x479CB74
	|-Native.Allocator.ExpandArray<Navigation.Entry>
	|
	|-RVA: 0x479CC40 Offset: 0x4798C40 VA: 0x479CC40
	|-Native.Allocator.ExpandArray<Navigation.EntryPair>
	|
	|-RVA: 0x479CD0C Offset: 0x4798D0C VA: 0x479CD0C
	|-Native.Allocator.ExpandArray<Radix.EndPoint>
	|
	|-RVA: 0x479CDD4 Offset: 0x4798DD4 VA: 0x479CDD4
	|-Native.Allocator.ExpandArray<TriangleMesh.Tri>
	*/

	// RVA: 0x7D54B84 Offset: 0x7D50B84 VA: 0x7D54B84
	protected void .ctor() { }
}

// Namespace: 
public abstract class Native.Utility // TypeDefIndex: 24049
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Native.ObjectHandle HandleAcquire(object obj);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void HandleRelease(Native.ObjectHandle handle);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object GetObjectForHandle(Native.ObjectHandle handle);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Copy(void* dest, void* src, int count);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Clear(void* dest, int count);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Move(void* dest, void* src, int count);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(void* ptr1, void* ptr2, int count);

	// RVA: 0x7D54C0C Offset: 0x7D50C0C VA: 0x7D54C0C
	public void CopyArrayWithStride(void* source, int sourceIndex, void* destination, int destinationIndex, int count, int stride) { }

	// RVA: -1 Offset: -1
	public void CopyArray<T>(T* source, int sourceIndex, T* destination, int destinationIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x479CEA0 Offset: 0x4798EA0 VA: 0x479CEA0
	|-Native.Utility.CopyArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7D54C30 Offset: 0x7D50C30 VA: 0x7D54C30
	public static void ClearFast(void* dest, int count) { }

	// RVA: 0x7D54CA0 Offset: 0x7D50CA0 VA: 0x7D54CA0
	public static void CopyFast(void* dest, void* src, int count) { }

	// RVA: 0x7D54D18 Offset: 0x7D50D18 VA: 0x7D54D18
	protected void .ctor() { }
}

// Namespace: 
public class Native.LIBCAllocator : Native.PInvokeAllocator // TypeDefIndex: 24050
{
	// Methods

	// RVA: 0x7D54D20 Offset: 0x7D50D20 VA: 0x7D54D20
	private static extern IntPtr memset(IntPtr dest, int c, UIntPtr byteCount) { }

	// RVA: 0x7D54DB4 Offset: 0x7D50DB4 VA: 0x7D54DB4 Slot: 7
	protected sealed override void Clear(void* dest, int count) { }

	// RVA: 0x7D54E08 Offset: 0x7D50E08 VA: 0x7D54E08
	public void .ctor() { }
}

// Namespace: 
public class Native.LIBCUtility : Native.PInvokeUtility // TypeDefIndex: 24051
{
	// Methods

	// RVA: 0x7D54E90 Offset: 0x7D50E90 VA: 0x7D54E90
	private static extern IntPtr memcpy(IntPtr dest, IntPtr src, UIntPtr count) { }

	// RVA: 0x7D54F24 Offset: 0x7D50F24 VA: 0x7D54F24
	private static extern IntPtr memmove(IntPtr dest, IntPtr src, UIntPtr count) { }

	// RVA: 0x7D54FB8 Offset: 0x7D50FB8 VA: 0x7D54FB8
	private static extern IntPtr memset(IntPtr dest, int c, UIntPtr byteCount) { }

	// RVA: 0x7D5504C Offset: 0x7D5104C VA: 0x7D5504C
	private static extern int memcmp(IntPtr ptr1, IntPtr ptr2, UIntPtr byteCount) { }

	// RVA: 0x7D550E0 Offset: 0x7D510E0 VA: 0x7D550E0 Slot: 8
	public sealed override void Clear(void* dest, int count) { }

	// RVA: 0x7D55134 Offset: 0x7D51134 VA: 0x7D55134 Slot: 7
	public sealed override void Copy(void* dest, void* src, int count) { }

	// RVA: 0x7D5519C Offset: 0x7D5119C VA: 0x7D5519C Slot: 9
	public sealed override void Move(void* dest, void* src, int count) { }

	// RVA: 0x7D55204 Offset: 0x7D51204 VA: 0x7D55204 Slot: 10
	public sealed override int Compare(void* ptr1, void* ptr2, int count) { }

	// RVA: 0x7D5526C Offset: 0x7D5126C VA: 0x7D5526C
	public void .ctor() { }
}

// Namespace: 
public sealed class Native.MSVCRTAllocator : Native.PInvokeAllocator // TypeDefIndex: 24052
{
	// Methods

	// RVA: 0x7D5527C Offset: 0x7D5127C VA: 0x7D5527C
	private static extern IntPtr memset(IntPtr dest, int c, UIntPtr byteCount) { }

	// RVA: 0x7D55310 Offset: 0x7D51310 VA: 0x7D55310 Slot: 7
	protected sealed override void Clear(void* dest, int count) { }

	// RVA: 0x7D55364 Offset: 0x7D51364 VA: 0x7D55364
	public void .ctor() { }
}

// Namespace: 
public sealed class Native.MSVCRTUtility : Native.PInvokeUtility // TypeDefIndex: 24053
{
	// Methods

	// RVA: 0x7D55368 Offset: 0x7D51368 VA: 0x7D55368
	private static extern IntPtr memcpy(IntPtr dest, IntPtr src, UIntPtr count) { }

	// RVA: 0x7D553FC Offset: 0x7D513FC VA: 0x7D553FC
	private static extern IntPtr memmove(IntPtr dest, IntPtr src, UIntPtr count) { }

	// RVA: 0x7D55490 Offset: 0x7D51490 VA: 0x7D55490
	private static extern IntPtr memset(IntPtr dest, int c, UIntPtr byteCount) { }

	// RVA: 0x7D55524 Offset: 0x7D51524 VA: 0x7D55524
	private static extern int memcmp(IntPtr ptr1, IntPtr ptr2, UIntPtr count) { }

	// RVA: 0x7D555B8 Offset: 0x7D515B8 VA: 0x7D555B8 Slot: 8
	public sealed override void Clear(void* dest, int count) { }

	// RVA: 0x7D5560C Offset: 0x7D5160C VA: 0x7D5560C Slot: 7
	public sealed override void Copy(void* dest, void* src, int count) { }

	// RVA: 0x7D55674 Offset: 0x7D51674 VA: 0x7D55674 Slot: 9
	public sealed override void Move(void* dest, void* src, int count) { }

	// RVA: 0x7D556DC Offset: 0x7D516DC VA: 0x7D556DC Slot: 10
	public sealed override int Compare(void* ptr1, void* ptr2, int count) { }

	// RVA: 0x7D55744 Offset: 0x7D51744 VA: 0x7D55744
	public void .ctor() { }
}

// Namespace: 
public abstract class Native.PInvokeUtility : Native.Utility // TypeDefIndex: 24054
{
	// Methods

	// RVA: 0x7D5574C Offset: 0x7D5174C VA: 0x7D5574C
	private static void VerifyHandle(Native.ObjectHandle handle) { }

	// RVA: 0x7D557D8 Offset: 0x7D517D8 VA: 0x7D557D8 Slot: 4
	public override Native.ObjectHandle HandleAcquire(object obj) { }

	// RVA: 0x7D55808 Offset: 0x7D51808 VA: 0x7D55808 Slot: 5
	public override void HandleRelease(Native.ObjectHandle handle) { }

	// RVA: 0x7D55848 Offset: 0x7D51848 VA: 0x7D55848 Slot: 6
	public override object GetObjectForHandle(Native.ObjectHandle handle) { }

	// RVA: 0x7D55274 Offset: 0x7D51274 VA: 0x7D55274
	protected void .ctor() { }
}

// Namespace: 
public abstract class Native.PInvokeAllocator : Native.Allocator // TypeDefIndex: 24055
{
	// Fields
	private Dictionary<IntPtr, IntPtr> _alignmentMapping; // 0x18

	// Methods

	// RVA: 0x7D55888 Offset: 0x7D51888 VA: 0x7D55888 Slot: 5
	public sealed override void* Alloc(int count) { }

	// RVA: 0x7D55924 Offset: 0x7D51924 VA: 0x7D55924 Slot: 6
	public sealed override void* Alloc(int count, int alignment) { }

	// RVA: 0x7D55ABC Offset: 0x7D51ABC VA: 0x7D55ABC Slot: 4
	public sealed override void Free(void* ptr) { }

	// RVA: 0x7D54E0C Offset: 0x7D50E0C VA: 0x7D54E0C
	protected void .ctor() { }
}

// Namespace: Photon.Deterministic
public static class Native // TypeDefIndex: 24056
{
	// Fields
	public static Native.Utility Utils; // 0x0

	// Methods

	// RVA: 0x7D54284 Offset: 0x7D50284 VA: 0x7D54284
	public static int RoundUpToAlignment(int size, int alignment) { }

	// RVA: 0x7D54388 Offset: 0x7D50388 VA: 0x7D54388
	public static int GetAlignmentForArrayElement(int elementSize) { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct NullableFP // TypeDefIndex: 24057
{
	// Fields
	public const int SIZE = 16;
	public long _hasValue; // 0x0
	public FP _value; // 0x8

	// Properties
	public bool HasValue { get; }
	public FP Value { get; }

	// Methods

	// RVA: 0x7D55C7C Offset: 0x7D51C7C VA: 0x7D55C7C
	public bool get_HasValue() { }

	// RVA: 0x7D55C8C Offset: 0x7D51C8C VA: 0x7D55C8C
	public FP get_Value() { }

	// RVA: 0x7D55CD8 Offset: 0x7D51CD8 VA: 0x7D55CD8
	public FP ValueOrDefault(FP v) { }

	// RVA: 0x7D55CF0 Offset: 0x7D51CF0 VA: 0x7D55CF0
	public static NullableFP op_Implicit(FP v) { }

	// RVA: 0x7D55CFC Offset: 0x7D51CFC VA: 0x7D55CFC
	public static void Serialize(NullableFP* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D560AC Offset: 0x7D520AC VA: 0x7D560AC Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct NullableFPVector2 // TypeDefIndex: 24058
{
	// Fields
	public const int SIZE = 24;
	public long _hasValue; // 0x0
	public FPVector2 _value; // 0x8

	// Properties
	public bool HasValue { get; }
	public FPVector2 Value { get; }

	// Methods

	// RVA: 0x7D560C8 Offset: 0x7D520C8 VA: 0x7D560C8
	public bool get_HasValue() { }

	// RVA: 0x7D560D8 Offset: 0x7D520D8 VA: 0x7D560D8
	public FPVector2 get_Value() { }

	// RVA: 0x7D56128 Offset: 0x7D52128 VA: 0x7D56128
	public FPVector2 ValueOrDefault(FPVector2 v) { }

	// RVA: 0x7D56144 Offset: 0x7D52144 VA: 0x7D56144
	public static NullableFPVector2 op_Implicit(FPVector2 v) { }

	// RVA: 0x7D56154 Offset: 0x7D52154 VA: 0x7D56154
	public static void Serialize(NullableFPVector2* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D56508 Offset: 0x7D52508 VA: 0x7D56508 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct NullableFPVector3 // TypeDefIndex: 24059
{
	// Fields
	public const int SIZE = 32;
	public long _hasValue; // 0x0
	public FPVector3 _value; // 0x8

	// Properties
	public bool HasValue { get; }
	public FPVector3 Value { get; }

	// Methods

	// RVA: 0x7D56560 Offset: 0x7D52560 VA: 0x7D56560
	public bool get_HasValue() { }

	// RVA: 0x7D56570 Offset: 0x7D52570 VA: 0x7D56570
	public FPVector3 get_Value() { }

	// RVA: 0x7D565C8 Offset: 0x7D525C8 VA: 0x7D565C8
	public FPVector3 ValueOrDefault(FPVector3 v) { }

	// RVA: 0x7D56638 Offset: 0x7D52638 VA: 0x7D56638
	public static NullableFPVector3 op_Implicit(FPVector3 v) { }

	// RVA: 0x7D56654 Offset: 0x7D52654 VA: 0x7D56654
	public static void Serialize(NullableFPVector3* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D56A70 Offset: 0x7D52A70 VA: 0x7D56A70 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Photon.Deterministic
[Serializable]
public struct NullableNonNegativeFP // TypeDefIndex: 24060
{
	// Fields
	public const int SIZE = 8;
	public ulong _value; // 0x0
	private const ulong HasValueBit = 9223372036854775808;
	private const ulong ValueMask = 9223372036854775807;

	// Properties
	public bool HasValue { get; }
	public FP Value { get; }

	// Methods

	// RVA: 0x7D56A88 Offset: 0x7D52A88 VA: 0x7D56A88
	public bool get_HasValue() { }

	// RVA: 0x7D56A94 Offset: 0x7D52A94 VA: 0x7D56A94
	public FP get_Value() { }

	// RVA: 0x7D56AE0 Offset: 0x7D52AE0 VA: 0x7D56AE0
	public FP ValueOrDefault() { }

	// RVA: 0x7D56AEC Offset: 0x7D52AEC VA: 0x7D56AEC
	public static NullableNonNegativeFP op_Implicit(FP v) { }

	// RVA: 0x7D56B70 Offset: 0x7D52B70 VA: 0x7D56B70
	public static void Serialize(NullableNonNegativeFP* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D56C94 Offset: 0x7D52C94 VA: 0x7D56C94 Slot: 3
	public override string ToString() { }

	// RVA: 0x7D56CF8 Offset: 0x7D52CF8 VA: 0x7D56CF8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PersistentMap.<Iterator>d__44<K, V> : IEnumerable<KeyValuePair<K, V>>, IEnumerable, IEnumerator<KeyValuePair<K, V>>, IEnumerator, IDisposable // TypeDefIndex: 24061
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<K, V> <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public PersistentMap<K, V> <>4__this; // 0x0
	private Stack<PersistentMap<K, V>> <stack>5__2; // 0x0
	private PersistentMap<K, V> <map>5__3; // 0x0

	// Properties
	private KeyValuePair<K, V> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<K,V>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D34AFC Offset: 0x5D30AFC VA: 0x5D34AFC
	|-PersistentMap.<Iterator>d__44<AssetGuid, object>..ctor
	|
	|-RVA: 0x5D34F28 Offset: 0x5D30F28 VA: 0x5D34F28
	|-PersistentMap.<Iterator>d__44<object, object>..ctor
	|
	|-RVA: 0x5D35354 Offset: 0x5D31354 VA: 0x5D35354
	|-PersistentMap.<Iterator>d__44<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D34B30 Offset: 0x5D30B30 VA: 0x5D34B30
	|-PersistentMap.<Iterator>d__44<AssetGuid, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5D34F5C Offset: 0x5D30F5C VA: 0x5D34F5C
	|-PersistentMap.<Iterator>d__44<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5D353BC Offset: 0x5D313BC VA: 0x5D353BC
	|-PersistentMap.<Iterator>d__44<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D34B34 Offset: 0x5D30B34 VA: 0x5D34B34
	|-PersistentMap.<Iterator>d__44<AssetGuid, object>.MoveNext
	|
	|-RVA: 0x5D34F60 Offset: 0x5D30F60 VA: 0x5D34F60
	|-PersistentMap.<Iterator>d__44<object, object>.MoveNext
	|
	|-RVA: 0x5D353C0 Offset: 0x5D313C0 VA: 0x5D353C0
	|-PersistentMap.<Iterator>d__44<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private KeyValuePair<K, V> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<K,V>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D34E14 Offset: 0x5D30E14 VA: 0x5D34E14
	|-PersistentMap.<Iterator>d__44<AssetGuid, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<K,V>>.get_Current
	|
	|-RVA: 0x5D35240 Offset: 0x5D31240 VA: 0x5D35240
	|-PersistentMap.<Iterator>d__44<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<K,V>>.get_Current
	|
	|-RVA: 0x5D35B08 Offset: 0x5D31B08 VA: 0x5D35B08
	|-PersistentMap.<Iterator>d__44<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<K,V>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D34E20 Offset: 0x5D30E20 VA: 0x5D34E20
	|-PersistentMap.<Iterator>d__44<AssetGuid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5D3524C Offset: 0x5D3124C VA: 0x5D3524C
	|-PersistentMap.<Iterator>d__44<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5D35BA8 Offset: 0x5D31BA8 VA: 0x5D35BA8
	|-PersistentMap.<Iterator>d__44<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D34E54 Offset: 0x5D30E54 VA: 0x5D34E54
	|-PersistentMap.<Iterator>d__44<AssetGuid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5D35280 Offset: 0x5D31280 VA: 0x5D35280
	|-PersistentMap.<Iterator>d__44<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5D35BDC Offset: 0x5D31BDC VA: 0x5D35BDC
	|-PersistentMap.<Iterator>d__44<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<K, V>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D34E84 Offset: 0x5D30E84 VA: 0x5D34E84
	|-PersistentMap.<Iterator>d__44<AssetGuid, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator
	|
	|-RVA: 0x5D352B0 Offset: 0x5D312B0 VA: 0x5D352B0
	|-PersistentMap.<Iterator>d__44<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator
	|
	|-RVA: 0x5D35C80 Offset: 0x5D31C80 VA: 0x5D35C80
	|-PersistentMap.<Iterator>d__44<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K,V>>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D34F18 Offset: 0x5D30F18 VA: 0x5D34F18
	|-PersistentMap.<Iterator>d__44<AssetGuid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5D35344 Offset: 0x5D31344 VA: 0x5D35344
	|-PersistentMap.<Iterator>d__44<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5D35D90 Offset: 0x5D31D90 VA: 0x5D35D90
	|-PersistentMap.<Iterator>d__44<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class PersistentMap.<get_Values>d__30<K, V> : IEnumerable<V>, IEnumerable, IEnumerator<V>, IEnumerator, IDisposable // TypeDefIndex: 24062
{
	// Fields
	private int <>1__state; // 0x0
	private V <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public PersistentMap<K, V> <>4__this; // 0x0
	private Stack<PersistentMap<K, V>> <ancestors>5__2; // 0x0
	private PersistentMap<K, V> <node>5__3; // 0x0

	// Properties
	private V System.Collections.Generic.IEnumerator<V>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F31E90 Offset: 0x5F2DE90 VA: 0x5F31E90
	|-PersistentMap.<get_Values>d__30<AssetGuid, object>..ctor
	|
	|-RVA: 0x5F321C0 Offset: 0x5F2E1C0 VA: 0x5F321C0
	|-PersistentMap.<get_Values>d__30<object, object>..ctor
	|
	|-RVA: 0x5F324F0 Offset: 0x5F2E4F0 VA: 0x5F324F0
	|-PersistentMap.<get_Values>d__30<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F31EC4 Offset: 0x5F2DEC4 VA: 0x5F31EC4
	|-PersistentMap.<get_Values>d__30<AssetGuid, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5F321F4 Offset: 0x5F2E1F4 VA: 0x5F321F4
	|-PersistentMap.<get_Values>d__30<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5F32558 Offset: 0x5F2E558 VA: 0x5F32558
	|-PersistentMap.<get_Values>d__30<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F31EC8 Offset: 0x5F2DEC8 VA: 0x5F31EC8
	|-PersistentMap.<get_Values>d__30<AssetGuid, object>.MoveNext
	|
	|-RVA: 0x5F321F8 Offset: 0x5F2E1F8 VA: 0x5F321F8
	|-PersistentMap.<get_Values>d__30<object, object>.MoveNext
	|
	|-RVA: 0x5F3255C Offset: 0x5F2E55C VA: 0x5F3255C
	|-PersistentMap.<get_Values>d__30<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private V System.Collections.Generic.IEnumerator<V>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F320D8 Offset: 0x5F2E0D8 VA: 0x5F320D8
	|-PersistentMap.<get_Values>d__30<AssetGuid, object>.System.Collections.Generic.IEnumerator<V>.get_Current
	|
	|-RVA: 0x5F32408 Offset: 0x5F2E408 VA: 0x5F32408
	|-PersistentMap.<get_Values>d__30<object, object>.System.Collections.Generic.IEnumerator<V>.get_Current
	|
	|-RVA: 0x5F32A34 Offset: 0x5F2EA34 VA: 0x5F32A34
	|-PersistentMap.<get_Values>d__30<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<V>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F320E0 Offset: 0x5F2E0E0 VA: 0x5F320E0
	|-PersistentMap.<get_Values>d__30<AssetGuid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5F32410 Offset: 0x5F2E410 VA: 0x5F32410
	|-PersistentMap.<get_Values>d__30<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5F32AD4 Offset: 0x5F2EAD4 VA: 0x5F32AD4
	|-PersistentMap.<get_Values>d__30<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F32114 Offset: 0x5F2E114 VA: 0x5F32114
	|-PersistentMap.<get_Values>d__30<AssetGuid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5F32444 Offset: 0x5F2E444 VA: 0x5F32444
	|-PersistentMap.<get_Values>d__30<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5F32B08 Offset: 0x5F2EB08 VA: 0x5F32B08
	|-PersistentMap.<get_Values>d__30<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<V> System.Collections.Generic.IEnumerable<V>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F3211C Offset: 0x5F2E11C VA: 0x5F3211C
	|-PersistentMap.<get_Values>d__30<AssetGuid, object>.System.Collections.Generic.IEnumerable<V>.GetEnumerator
	|
	|-RVA: 0x5F3244C Offset: 0x5F2E44C VA: 0x5F3244C
	|-PersistentMap.<get_Values>d__30<object, object>.System.Collections.Generic.IEnumerable<V>.GetEnumerator
	|
	|-RVA: 0x5F32BAC Offset: 0x5F2EBAC VA: 0x5F32BAC
	|-PersistentMap.<get_Values>d__30<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<V>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F321B0 Offset: 0x5F2E1B0 VA: 0x5F321B0
	|-PersistentMap.<get_Values>d__30<AssetGuid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5F324E0 Offset: 0x5F2E4E0 VA: 0x5F324E0
	|-PersistentMap.<get_Values>d__30<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5F32CBC Offset: 0x5F2ECBC VA: 0x5F32CBC
	|-PersistentMap.<get_Values>d__30<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class PersistentMap.<get_ValuesUnordered>d__28<K, V> : IEnumerable<V>, IEnumerable, IEnumerator<V>, IEnumerator, IDisposable // TypeDefIndex: 24063
{
	// Fields
	private int <>1__state; // 0x0
	private V <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public PersistentMap<K, V> <>4__this; // 0x0
	private Stack<PersistentMap<K, V>> <stack>5__2; // 0x0
	private PersistentMap<K, V> <map>5__3; // 0x0

	// Properties
	private V System.Collections.Generic.IEnumerator<V>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F33B14 Offset: 0x5F2FB14 VA: 0x5F33B14
	|-PersistentMap.<get_ValuesUnordered>d__28<AssetGuid, object>..ctor
	|
	|-RVA: 0x5F33DE4 Offset: 0x5F2FDE4 VA: 0x5F33DE4
	|-PersistentMap.<get_ValuesUnordered>d__28<object, object>..ctor
	|
	|-RVA: 0x5F340B4 Offset: 0x5F300B4 VA: 0x5F340B4
	|-PersistentMap.<get_ValuesUnordered>d__28<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F33B48 Offset: 0x5F2FB48 VA: 0x5F33B48
	|-PersistentMap.<get_ValuesUnordered>d__28<AssetGuid, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5F33E18 Offset: 0x5F2FE18 VA: 0x5F33E18
	|-PersistentMap.<get_ValuesUnordered>d__28<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5F3411C Offset: 0x5F3011C VA: 0x5F3411C
	|-PersistentMap.<get_ValuesUnordered>d__28<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F33B4C Offset: 0x5F2FB4C VA: 0x5F33B4C
	|-PersistentMap.<get_ValuesUnordered>d__28<AssetGuid, object>.MoveNext
	|
	|-RVA: 0x5F33E1C Offset: 0x5F2FE1C VA: 0x5F33E1C
	|-PersistentMap.<get_ValuesUnordered>d__28<object, object>.MoveNext
	|
	|-RVA: 0x5F34120 Offset: 0x5F30120 VA: 0x5F34120
	|-PersistentMap.<get_ValuesUnordered>d__28<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private V System.Collections.Generic.IEnumerator<V>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F33CFC Offset: 0x5F2FCFC VA: 0x5F33CFC
	|-PersistentMap.<get_ValuesUnordered>d__28<AssetGuid, object>.System.Collections.Generic.IEnumerator<V>.get_Current
	|
	|-RVA: 0x5F33FCC Offset: 0x5F2FFCC VA: 0x5F33FCC
	|-PersistentMap.<get_ValuesUnordered>d__28<object, object>.System.Collections.Generic.IEnumerator<V>.get_Current
	|
	|-RVA: 0x5F34560 Offset: 0x5F30560 VA: 0x5F34560
	|-PersistentMap.<get_ValuesUnordered>d__28<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<V>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F33D04 Offset: 0x5F2FD04 VA: 0x5F33D04
	|-PersistentMap.<get_ValuesUnordered>d__28<AssetGuid, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5F33FD4 Offset: 0x5F2FFD4 VA: 0x5F33FD4
	|-PersistentMap.<get_ValuesUnordered>d__28<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5F34600 Offset: 0x5F30600 VA: 0x5F34600
	|-PersistentMap.<get_ValuesUnordered>d__28<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F33D38 Offset: 0x5F2FD38 VA: 0x5F33D38
	|-PersistentMap.<get_ValuesUnordered>d__28<AssetGuid, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5F34008 Offset: 0x5F30008 VA: 0x5F34008
	|-PersistentMap.<get_ValuesUnordered>d__28<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5F34634 Offset: 0x5F30634 VA: 0x5F34634
	|-PersistentMap.<get_ValuesUnordered>d__28<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<V> System.Collections.Generic.IEnumerable<V>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F33D40 Offset: 0x5F2FD40 VA: 0x5F33D40
	|-PersistentMap.<get_ValuesUnordered>d__28<AssetGuid, object>.System.Collections.Generic.IEnumerable<V>.GetEnumerator
	|
	|-RVA: 0x5F34010 Offset: 0x5F30010 VA: 0x5F34010
	|-PersistentMap.<get_ValuesUnordered>d__28<object, object>.System.Collections.Generic.IEnumerable<V>.GetEnumerator
	|
	|-RVA: 0x5F346D8 Offset: 0x5F306D8 VA: 0x5F346D8
	|-PersistentMap.<get_ValuesUnordered>d__28<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<V>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F33DD4 Offset: 0x5F2FDD4 VA: 0x5F33DD4
	|-PersistentMap.<get_ValuesUnordered>d__28<AssetGuid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5F340A4 Offset: 0x5F300A4 VA: 0x5F340A4
	|-PersistentMap.<get_ValuesUnordered>d__28<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5F347E8 Offset: 0x5F307E8 VA: 0x5F347E8
	|-PersistentMap.<get_ValuesUnordered>d__28<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Photon.Deterministic
[DefaultMember("Item")]
public sealed class PersistentMap<K, V> : IEquatable<PersistentMap<K, V>> // TypeDefIndex: 24064
{
	// Fields
	private static readonly PersistentMap<K, V> _empty; // 0x0
	private readonly K _key; // 0x0
	private readonly V _value; // 0x0
	private readonly int _count; // 0x0
	private readonly int _height; // 0x0
	private readonly PersistentMap<K, V> _left; // 0x0
	private readonly PersistentMap<K, V> _right; // 0x0

	// Properties
	private K Key { get; }
	private V Value { get; }
	private PersistentMap<K, V> Left { get; }
	private PersistentMap<K, V> Right { get; }
	private bool IsEmpty { get; }
	private bool HasLeft { get; }
	private bool HasRight { get; }
	private int Balance { get; }
	public int Count { get; }
	public V Item { get; }
	[Obsolete("Use Values instead")]
	public IEnumerable<V> ValuesUnordered { get; }
	public IEnumerable<V> Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	private K get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A328 Offset: 0x5256328 VA: 0x525A328
	|-PersistentMap<AssetGuid, object>.get_Key
	|
	|-RVA: 0x525D098 Offset: 0x5259098 VA: 0x525D098
	|-PersistentMap<object, object>.get_Key
	|
	|-RVA: 0x5260120 Offset: 0x525C120 VA: 0x5260120
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1
	private V get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A388 Offset: 0x5256388 VA: 0x525A388
	|-PersistentMap<AssetGuid, object>.get_Value
	|
	|-RVA: 0x525D0F8 Offset: 0x52590F8 VA: 0x525D0F8
	|-PersistentMap<object, object>.get_Value
	|
	|-RVA: 0x526022C Offset: 0x525C22C VA: 0x526022C
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1
	private PersistentMap<K, V> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A3E8 Offset: 0x52563E8 VA: 0x525A3E8
	|-PersistentMap<AssetGuid, object>.get_Left
	|
	|-RVA: 0x525D158 Offset: 0x5259158 VA: 0x525D158
	|-PersistentMap<object, object>.get_Left
	|
	|-RVA: 0x526033C Offset: 0x525C33C VA: 0x526033C
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Left
	*/

	// RVA: -1 Offset: -1
	private PersistentMap<K, V> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A448 Offset: 0x5256448 VA: 0x525A448
	|-PersistentMap<AssetGuid, object>.get_Right
	|
	|-RVA: 0x525D1B8 Offset: 0x52591B8 VA: 0x525D1B8
	|-PersistentMap<object, object>.get_Right
	|
	|-RVA: 0x52603D4 Offset: 0x525C3D4 VA: 0x52603D4
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Right
	*/

	// RVA: -1 Offset: -1
	private bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A4A8 Offset: 0x52564A8 VA: 0x525A4A8
	|-PersistentMap<AssetGuid, object>.get_IsEmpty
	|
	|-RVA: 0x525D218 Offset: 0x5259218 VA: 0x525D218
	|-PersistentMap<object, object>.get_IsEmpty
	|
	|-RVA: 0x526046C Offset: 0x525C46C VA: 0x526046C
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	private bool get_HasLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A4B8 Offset: 0x52564B8 VA: 0x525A4B8
	|-PersistentMap<AssetGuid, object>.get_HasLeft
	|
	|-RVA: 0x525D228 Offset: 0x5259228 VA: 0x525D228
	|-PersistentMap<object, object>.get_HasLeft
	|
	|-RVA: 0x526049C Offset: 0x525C49C VA: 0x526049C
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_HasLeft
	*/

	// RVA: -1 Offset: -1
	private bool get_HasRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A4FC Offset: 0x52564FC VA: 0x525A4FC
	|-PersistentMap<AssetGuid, object>.get_HasRight
	|
	|-RVA: 0x525D26C Offset: 0x525926C VA: 0x525D26C
	|-PersistentMap<object, object>.get_HasRight
	|
	|-RVA: 0x5260520 Offset: 0x525C520 VA: 0x5260520
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_HasRight
	*/

	// RVA: -1 Offset: -1
	private int get_Balance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A540 Offset: 0x5256540 VA: 0x525A540
	|-PersistentMap<AssetGuid, object>.get_Balance
	|
	|-RVA: 0x525D2B0 Offset: 0x52592B0 VA: 0x525D2B0
	|-PersistentMap<object, object>.get_Balance
	|
	|-RVA: 0x52605A4 Offset: 0x525C5A4 VA: 0x52605A4
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Balance
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A5A8 Offset: 0x52565A8 VA: 0x525A5A8
	|-PersistentMap<AssetGuid, object>.get_Count
	|
	|-RVA: 0x525D318 Offset: 0x5259318 VA: 0x525D318
	|-PersistentMap<object, object>.get_Count
	|
	|-RVA: 0x5260654 Offset: 0x525C654 VA: 0x5260654
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public V get_Item(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A5B0 Offset: 0x52565B0 VA: 0x525A5B0
	|-PersistentMap<AssetGuid, object>.get_Item
	|
	|-RVA: 0x525D320 Offset: 0x5259320 VA: 0x525D320
	|-PersistentMap<object, object>.get_Item
	|
	|-RVA: 0x526067C Offset: 0x525C67C VA: 0x526067C
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	[IteratorStateMachine(typeof(PersistentMap.<get_ValuesUnordered>d__28<K, V>))]
	// RVA: -1 Offset: -1
	public IEnumerable<V> get_ValuesUnordered() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A5C0 Offset: 0x52565C0 VA: 0x525A5C0
	|-PersistentMap<AssetGuid, object>.get_ValuesUnordered
	|
	|-RVA: 0x525D330 Offset: 0x5259330 VA: 0x525D330
	|-PersistentMap<object, object>.get_ValuesUnordered
	|
	|-RVA: 0x5260778 Offset: 0x525C778 VA: 0x5260778
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ValuesUnordered
	*/

	[IteratorStateMachine(typeof(PersistentMap.<get_Values>d__30<K, V>))]
	// RVA: -1 Offset: -1
	public IEnumerable<V> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A638 Offset: 0x5256638 VA: 0x525A638
	|-PersistentMap<AssetGuid, object>.get_Values
	|
	|-RVA: 0x525D3A8 Offset: 0x52593A8 VA: 0x525D3A8
	|-PersistentMap<object, object>.get_Values
	|
	|-RVA: 0x5260804 Offset: 0x525C804 VA: 0x5260804
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A6B0 Offset: 0x52566B0 VA: 0x525A6B0
	|-PersistentMap<AssetGuid, object>..ctor
	|
	|-RVA: 0x525D420 Offset: 0x5259420 VA: 0x525D420
	|-PersistentMap<object, object>..ctor
	|
	|-RVA: 0x5260890 Offset: 0x525C890 VA: 0x5260890
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(K key, V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A6E8 Offset: 0x52566E8 VA: 0x525A6E8
	|-PersistentMap<AssetGuid, object>..ctor
	|
	|-RVA: 0x525D458 Offset: 0x5259458 VA: 0x525D458
	|-PersistentMap<object, object>..ctor
	|
	|-RVA: 0x526099C Offset: 0x525C99C VA: 0x526099C
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(K key, V value, PersistentMap<K, V> left, PersistentMap<K, V> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A7BC Offset: 0x52567BC VA: 0x525A7BC
	|-PersistentMap<AssetGuid, object>..ctor
	|
	|-RVA: 0x525D52C Offset: 0x525952C VA: 0x525D52C
	|-PersistentMap<object, object>..ctor
	|
	|-RVA: 0x5260B40 Offset: 0x525CB40 VA: 0x5260B40
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public PersistentMap<K, V> Add(K key, V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525A8AC Offset: 0x52568AC VA: 0x525A8AC
	|-PersistentMap<AssetGuid, object>.Add
	|
	|-RVA: 0x525D628 Offset: 0x5259628 VA: 0x525D628
	|-PersistentMap<object, object>.Add
	|
	|-RVA: 0x5260DEC Offset: 0x525CDEC VA: 0x5260DEC
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public PersistentMap<K, V> Set(K key, V value, out V oldValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525AB9C Offset: 0x5256B9C VA: 0x525AB9C
	|-PersistentMap<AssetGuid, object>.Set
	|
	|-RVA: 0x525D9D0 Offset: 0x52599D0 VA: 0x525D9D0
	|-PersistentMap<object, object>.Set
	|
	|-RVA: 0x5261470 Offset: 0x525D470 VA: 0x5261470
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	public PersistentMap<K, V> AddOrSet(K key, V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525AEA0 Offset: 0x5256EA0 VA: 0x525AEA0
	|-PersistentMap<AssetGuid, object>.AddOrSet
	|
	|-RVA: 0x525DD48 Offset: 0x5259D48 VA: 0x525DD48
	|-PersistentMap<object, object>.AddOrSet
	|
	|-RVA: 0x5261B50 Offset: 0x525DB50 VA: 0x5261B50
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddOrSet
	*/

	// RVA: -1 Offset: -1
	public PersistentMap<K, V> TryRemove(K key, out V removed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525B1C8 Offset: 0x52571C8 VA: 0x525B1C8
	|-PersistentMap<AssetGuid, object>.TryRemove
	|
	|-RVA: 0x525E118 Offset: 0x525A118 VA: 0x525E118
	|-PersistentMap<object, object>.TryRemove
	|
	|-RVA: 0x52622D8 Offset: 0x525E2D8 VA: 0x52622D8
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemove
	*/

	// RVA: -1 Offset: -1
	public V Find(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525B728 Offset: 0x5257728 VA: 0x525B728
	|-PersistentMap<AssetGuid, object>.Find
	|
	|-RVA: 0x525E6DC Offset: 0x525A6DC VA: 0x525E6DC
	|-PersistentMap<object, object>.Find
	|
	|-RVA: 0x5262C70 Offset: 0x525EC70 VA: 0x5262C70
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	public bool HasKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525B794 Offset: 0x5257794 VA: 0x525B794
	|-PersistentMap<AssetGuid, object>.HasKey
	|
	|-RVA: 0x525E748 Offset: 0x525A748 VA: 0x525E748
	|-PersistentMap<object, object>.HasKey
	|
	|-RVA: 0x5262DE8 Offset: 0x525EDE8 VA: 0x5262DE8
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.HasKey
	*/

	// RVA: -1 Offset: -1
	public bool TryFind(K key, out V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525B7BC Offset: 0x52577BC VA: 0x525B7BC
	|-PersistentMap<AssetGuid, object>.TryFind
	|
	|-RVA: 0x525E770 Offset: 0x525A770 VA: 0x525E770
	|-PersistentMap<object, object>.TryFind
	|
	|-RVA: 0x5262EF8 Offset: 0x525EEF8 VA: 0x5262EF8
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryFind
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525B828 Offset: 0x5257828 VA: 0x525B828
	|-PersistentMap<AssetGuid, object>.Equals
	|
	|-RVA: 0x525E7DC Offset: 0x525A7DC VA: 0x525E7DC
	|-PersistentMap<object, object>.Equals
	|
	|-RVA: 0x526308C Offset: 0x525F08C VA: 0x526308C
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(PersistentMap<K, V> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525B8D0 Offset: 0x52578D0 VA: 0x525B8D0
	|-PersistentMap<AssetGuid, object>.Equals
	|
	|-RVA: 0x525E884 Offset: 0x525A884 VA: 0x525E884
	|-PersistentMap<object, object>.Equals
	|
	|-RVA: 0x5263150 Offset: 0x525F150 VA: 0x5263150
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public QTuple<K, V>[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525BC78 Offset: 0x5257C78 VA: 0x525BC78
	|-PersistentMap<AssetGuid, object>.ToArray
	|
	|-RVA: 0x525EC90 Offset: 0x525AC90 VA: 0x525EC90
	|-PersistentMap<object, object>.ToArray
	|
	|-RVA: 0x526389C Offset: 0x525F89C VA: 0x526389C
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToArray
	*/

	[IteratorStateMachine(typeof(PersistentMap.<Iterator>d__44<K, V>))]
	// RVA: -1 Offset: -1
	public IEnumerable<KeyValuePair<K, V>> Iterator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525BFEC Offset: 0x5257FEC VA: 0x525BFEC
	|-PersistentMap<AssetGuid, object>.Iterator
	|
	|-RVA: 0x525F004 Offset: 0x525B004 VA: 0x525F004
	|-PersistentMap<object, object>.Iterator
	|
	|-RVA: 0x5263E08 Offset: 0x525FE08 VA: 0x5263E08
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Iterator
	*/

	// RVA: -1 Offset: -1
	private PersistentMap<K, V> Search(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525C064 Offset: 0x5258064 VA: 0x525C064
	|-PersistentMap<AssetGuid, object>.Search
	|
	|-RVA: 0x525F07C Offset: 0x525B07C VA: 0x525F07C
	|-PersistentMap<object, object>.Search
	|
	|-RVA: 0x5263E94 Offset: 0x525FE94 VA: 0x5263E94
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Search
	*/

	// RVA: -1 Offset: -1
	private static PersistentMap<K, V> RotateLeft(PersistentMap<K, V> map) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525C110 Offset: 0x5258110 VA: 0x525C110
	|-PersistentMap<AssetGuid, object>.RotateLeft
	|
	|-RVA: 0x525F198 Offset: 0x525B198 VA: 0x525F198
	|-PersistentMap<object, object>.RotateLeft
	|
	|-RVA: 0x52640B4 Offset: 0x52600B4 VA: 0x52640B4
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RotateLeft
	*/

	// RVA: -1 Offset: -1
	private static PersistentMap<K, V> RotateRight(PersistentMap<K, V> map) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525C3EC Offset: 0x52583EC VA: 0x525C3EC
	|-PersistentMap<AssetGuid, object>.RotateRight
	|
	|-RVA: 0x525F474 Offset: 0x525B474 VA: 0x525F474
	|-PersistentMap<object, object>.RotateRight
	|
	|-RVA: 0x526481C Offset: 0x526081C VA: 0x526481C
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RotateRight
	*/

	// RVA: -1 Offset: -1
	private static PersistentMap<K, V> Rebalance(PersistentMap<K, V> map) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525C6C8 Offset: 0x52586C8 VA: 0x525C6C8
	|-PersistentMap<AssetGuid, object>.Rebalance
	|
	|-RVA: 0x525F750 Offset: 0x525B750 VA: 0x525F750
	|-PersistentMap<object, object>.Rebalance
	|
	|-RVA: 0x5264F74 Offset: 0x5260F74 VA: 0x5264F74
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Rebalance
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525CBAC Offset: 0x5258BAC VA: 0x525CBAC
	|-PersistentMap<AssetGuid, object>.GetHashCode
	|
	|-RVA: 0x525FC34 Offset: 0x525BC34 VA: 0x525FC34
	|-PersistentMap<object, object>.GetHashCode
	|
	|-RVA: 0x52659E0 Offset: 0x52619E0 VA: 0x52659E0
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(PersistentMap<K, V> a, PersistentMap<K, V> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525CF00 Offset: 0x5258F00 VA: 0x525CF00
	|-PersistentMap<AssetGuid, object>.op_Equality
	|
	|-RVA: 0x525FF88 Offset: 0x525BF88 VA: 0x525FF88
	|-PersistentMap<object, object>.op_Equality
	|
	|-RVA: 0x5265DFC Offset: 0x5261DFC VA: 0x5265DFC
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(PersistentMap<K, V> a, PersistentMap<K, V> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525CF70 Offset: 0x5258F70 VA: 0x525CF70
	|-PersistentMap<AssetGuid, object>.op_Inequality
	|
	|-RVA: 0x525FFF8 Offset: 0x525BFF8 VA: 0x525FFF8
	|-PersistentMap<object, object>.op_Inequality
	|
	|-RVA: 0x5265EBC Offset: 0x5261EBC VA: 0x5265EBC
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.op_Inequality
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x525CFE0 Offset: 0x5258FE0 VA: 0x525CFE0
	|-PersistentMap<AssetGuid, object>..cctor
	|
	|-RVA: 0x5260068 Offset: 0x525C068 VA: 0x5260068
	|-PersistentMap<object, object>..cctor
	|
	|-RVA: 0x5265F68 Offset: 0x5261F68 VA: 0x5265F68
	|-PersistentMap<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Photon.Deterministic
[Serializable]
public struct Plane // TypeDefIndex: 24065
{
	// Fields
	public FP equation0; // 0x0
	public FP equation1; // 0x8
	public FP equation2; // 0x10
	public FP equation3; // 0x18
	public FPVector3 origin; // 0x20
	public FPVector3 normal; // 0x38

	// Methods

	// RVA: 0x7D56D28 Offset: 0x7D52D28 VA: 0x7D56D28
	public void .ctor(FPVector3 origin, FPVector3 normal) { }

	// RVA: 0x7D56D94 Offset: 0x7D52D94 VA: 0x7D56D94
	public void .ctor(FPVector3 p1, FPVector3 p2, FPVector3 p3) { }

	// RVA: 0x7D56EA0 Offset: 0x7D52EA0 VA: 0x7D56EA0
	public bool IsFrontFacingTo(FPVector3 direction) { }

	// RVA: 0x7D56ED4 Offset: 0x7D52ED4 VA: 0x7D56ED4
	public FP SignedDistanceTo(FPVector3 point) { }
}

// Namespace: Photon.Deterministic
public struct QTuple // TypeDefIndex: 24066
{
	// Methods

	// RVA: -1 Offset: -1
	public static QTuple<T0, T1> Create<T0, T1>(T0 item0, T1 item1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B6340 Offset: 0x46B2340 VA: 0x46B6340
	|-QTuple.Create<AssetGuid, object>
	|
	|-RVA: 0x46B6398 Offset: 0x46B2398 VA: 0x46B6398
	|-QTuple.Create<AssetRef, object>
	|
	|-RVA: 0x46B63F0 Offset: 0x46B23F0 VA: 0x46B63F0
	|-QTuple.Create<object, int>
	|
	|-RVA: 0x46B6448 Offset: 0x46B2448 VA: 0x46B6448
	|-QTuple.Create<object, object>
	|
	|-RVA: 0x46B64A0 Offset: 0x46B24A0 VA: 0x46B64A0
	|-QTuple.Create<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static QTuple<T0, T1, T2> Create<T0, T1, T2>(T0 item0, T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B6650 Offset: 0x46B2650 VA: 0x46B6650
	|-QTuple.Create<int, int, int>
	|
	|-RVA: 0x46B66C0 Offset: 0x46B26C0 VA: 0x46B66C0
	|-QTuple.Create<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static QTuple<T0, T1, T2, T3> Create<T0, T1, T2, T3>(T0 item0, T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46B68FC Offset: 0x46B28FC VA: 0x46B68FC
	|-QTuple.Create<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Photon.Deterministic
public struct QTuple<T0, T1> // TypeDefIndex: 24067
{
	// Fields
	public readonly T0 Item0; // 0x0
	public readonly T1 Item1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T0 item0, T1 item1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52A90E8 Offset: 0x52A50E8 VA: 0x52A90E8
	|-QTuple<AssetGuid, object>..ctor
	|
	|-RVA: 0x52A9110 Offset: 0x52A5110 VA: 0x52A9110
	|-QTuple<AssetRef, object>..ctor
	|
	|-RVA: 0x52A9138 Offset: 0x52A5138 VA: 0x52A9138
	|-QTuple<object, int>..ctor
	|
	|-RVA: 0x52A9198 Offset: 0x52A5198 VA: 0x52A9198
	|-QTuple<object, object>..ctor
	|
	|-RVA: 0x52A9204 Offset: 0x52A5204 VA: 0x52A9204
	|-QTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Deconstruct(out T0 item0, out T1 item1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52A90F8 Offset: 0x52A50F8 VA: 0x52A90F8
	|-QTuple<AssetGuid, object>.Deconstruct
	|
	|-RVA: 0x52A9120 Offset: 0x52A5120 VA: 0x52A9120
	|-QTuple<AssetRef, object>.Deconstruct
	|
	|-RVA: 0x52A9160 Offset: 0x52A5160 VA: 0x52A9160
	|-QTuple<object, int>.Deconstruct
	|
	|-RVA: 0x52A91C8 Offset: 0x52A51C8 VA: 0x52A91C8
	|-QTuple<object, object>.Deconstruct
	|
	|-RVA: 0x52A93E8 Offset: 0x52A53E8 VA: 0x52A93E8
	|-QTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Deconstruct
	*/
}

// Namespace: Photon.Deterministic
public struct QTuple<T0, T1, T2> // TypeDefIndex: 24068
{
	// Fields
	public readonly T0 Item0; // 0x0
	public readonly T1 Item1; // 0x0
	public readonly T2 Item2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T0 item0, T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52A95D0 Offset: 0x52A55D0 VA: 0x52A95D0
	|-QTuple<int, int, int>..ctor
	|
	|-RVA: 0x52A95F8 Offset: 0x52A55F8 VA: 0x52A95F8
	|-QTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Deconstruct(out T0 item0, out T1 item1, out T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52A95DC Offset: 0x52A55DC VA: 0x52A95DC
	|-QTuple<int, int, int>.Deconstruct
	|
	|-RVA: 0x52A98A8 Offset: 0x52A58A8 VA: 0x52A98A8
	|-QTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Deconstruct
	*/
}

// Namespace: Photon.Deterministic
public struct QTuple<T0, T1, T2, T3> // TypeDefIndex: 24069
{
	// Fields
	public readonly T0 Item0; // 0x0
	public readonly T1 Item1; // 0x0
	public readonly T2 Item2; // 0x0
	public readonly T3 Item3; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T0 item0, T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52A9B64 Offset: 0x52A5B64 VA: 0x52A9B64
	|-QTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Deconstruct(out T0 item0, out T1 item1, out T2 item2, out T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52A9EDC Offset: 0x52A5EDC VA: 0x52A9EDC
	|-QTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Deconstruct
	*/
}

// Namespace: 
public struct RingBuffer.Iterator<T> // TypeDefIndex: 24070
{
	// Fields
	private int _count; // 0x0
	private int _index; // 0x0
	private readonly int _version; // 0x0
	private readonly RingBuffer<T> _buffer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(RingBuffer<T> buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6F1D8 Offset: 0x4A6B1D8 VA: 0x4A6F1D8
	|-RingBuffer.Iterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Next(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6F22C Offset: 0x4A6B22C VA: 0x4A6F22C
	|-RingBuffer.Iterator<__Il2CppFullySharedGenericType>.Next
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class RingBuffer.<GetEnumerator>d__23<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 24071
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public RingBuffer<T> <>4__this; // 0x0
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
	|-RVA: 0x5D2AC64 Offset: 0x5D26C64 VA: 0x5D2AC64
	|-RingBuffer.<GetEnumerator>d__23<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2ACA4 Offset: 0x5D26CA4 VA: 0x5D2ACA4
	|-RingBuffer.<GetEnumerator>d__23<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2ACA8 Offset: 0x5D26CA8 VA: 0x5D2ACA8
	|-RingBuffer.<GetEnumerator>d__23<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2AEBC Offset: 0x5D26EBC VA: 0x5D2AEBC
	|-RingBuffer.<GetEnumerator>d__23<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2AF5C Offset: 0x5D26F5C VA: 0x5D2AF5C
	|-RingBuffer.<GetEnumerator>d__23<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2AF90 Offset: 0x5D26F90 VA: 0x5D2AF90
	|-RingBuffer.<GetEnumerator>d__23<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Photon.Deterministic
[DefaultMember("Item")]
internal class RingBuffer<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 24072
{
	// Fields
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _count; // 0x0
	private int _version; // 0x0
	private readonly T[] _array; // 0x0
	private readonly bool _overwrite; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; }
	public bool IsFull { get; }
	public bool IsEmpty { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE028 Offset: 0x54CA028 VA: 0x54CE028
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE030 Offset: 0x54CA030 VA: 0x54CE030
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE04C Offset: 0x54CA04C VA: 0x54CE04C
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_IsFull
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE074 Offset: 0x54CA074 VA: 0x54CE074
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE084 Offset: 0x54CA084 VA: 0x54CE084
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE18C Offset: 0x54CA18C VA: 0x54CE18C
	|-RingBuffer<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public RingBuffer.Iterator<T> GetIterator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE304 Offset: 0x54CA304 VA: 0x54CE304
	|-RingBuffer<__Il2CppFullySharedGenericType>.GetIterator
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int size, bool overwrite) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE324 Offset: 0x54CA324 VA: 0x54CE324
	|-RingBuffer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE390 Offset: 0x54CA390 VA: 0x54CE390
	|-RingBuffer<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE580 Offset: 0x54CA580 VA: 0x54CE580
	|-RingBuffer<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE838 Offset: 0x54CA838 VA: 0x54CE838
	|-RingBuffer<__Il2CppFullySharedGenericType>.Clear
	*/

	[IteratorStateMachine(typeof(RingBuffer.<GetEnumerator>d__23<T>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE870 Offset: 0x54CA870 VA: 0x54CE870
	|-RingBuffer<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54CE8FC Offset: 0x54CA8FC VA: 0x54CE8FC
	|-RingBuffer<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Photon.Deterministic
public struct RNGSession // TypeDefIndex: 24073
{
	// Fields
	public const int SIZE = 16;
	public const uint MAX = 4294967295;
	private ulong state; // 0x0
	private ulong inc; // 0x8

	// Properties
	public RNGSession Peek { get; }

	// Methods

	// RVA: 0x7D56F08 Offset: 0x7D52F08 VA: 0x7D56F08
	public RNGSession get_Peek() { }

	// RVA: 0x7D56F14 Offset: 0x7D52F14 VA: 0x7D56F14
	public FP Next() { }

	// RVA: 0x7D56F94 Offset: 0x7D52F94 VA: 0x7D56F94
	public FP NextInclusive() { }

	// RVA: 0x7D57040 Offset: 0x7D53040 VA: 0x7D57040
	public FP Next(FP minInclusive, FP maxExclusive) { }

	// RVA: 0x7D57098 Offset: 0x7D53098 VA: 0x7D57098
	public FP NextInclusive(FP minInclusive, FP maxInclusive) { }

	// RVA: 0x7D5715C Offset: 0x7D5315C VA: 0x7D5715C
	public int Next(int minInclusive, int maxExclusive) { }

	// RVA: 0x7D57188 Offset: 0x7D53188 VA: 0x7D57188
	public int NextInclusive(int minInclusive, int maxInclusive) { }

	// RVA: 0x7D56FE8 Offset: 0x7D52FE8 VA: 0x7D56FE8
	private uint NextUnbiased(uint max) { }

	// RVA: 0x7D571F4 Offset: 0x7D531F4 VA: 0x7D571F4
	public void .ctor(int seed) { }

	// RVA: 0x7D57120 Offset: 0x7D53120 VA: 0x7D57120
	internal uint NextUInt32() { }

	// RVA: 0x7D56F54 Offset: 0x7D52F54 VA: 0x7D56F54
	internal FP NextFP() { }

	// RVA: 0x7D572C4 Offset: 0x7D532C4 VA: 0x7D572C4 Slot: 3
	public override string ToString() { }

	// RVA: 0x7D574A8 Offset: 0x7D534A8 VA: 0x7D574A8
	public static void Serialize(void* ptr, IDeterministicFrameSerializer serializer) { }

	// RVA: 0x7D57698 Offset: 0x7D53698 VA: 0x7D57698 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7D5726C Offset: 0x7D5326C VA: 0x7D5726C
	private static ulong NextSplitMix64(ref ulong x) { }
}

// Namespace: Photon.Deterministic
internal struct UdpByteConverter // TypeDefIndex: 24074
{
	// Fields
	public short Signed16; // 0x0
	public ushort Unsigned16; // 0x0
	public char Char; // 0x0
	public int Signed32; // 0x0
	public uint Unsigned32; // 0x0
	public long Signed64; // 0x0
	public ulong Unsigned64; // 0x0
	public float Float32; // 0x0
	public double Float64; // 0x0
	public byte Byte0; // 0x0
	public byte Byte1; // 0x1
	public byte Byte2; // 0x2
	public byte Byte3; // 0x3
	public byte Byte4; // 0x4
	public byte Byte5; // 0x5
	public byte Byte6; // 0x6
	public byte Byte7; // 0x7

	// Methods

	// RVA: 0x7D576DC Offset: 0x7D536DC VA: 0x7D576DC
	public static UdpByteConverter op_Implicit(short val) { }

	// RVA: 0x7D576E4 Offset: 0x7D536E4 VA: 0x7D576E4
	public static UdpByteConverter op_Implicit(ushort val) { }

	// RVA: 0x7D576EC Offset: 0x7D536EC VA: 0x7D576EC
	public static UdpByteConverter op_Implicit(char val) { }

	// RVA: 0x7D576F4 Offset: 0x7D536F4 VA: 0x7D576F4
	public static UdpByteConverter op_Implicit(uint val) { }

	// RVA: 0x7D576FC Offset: 0x7D536FC VA: 0x7D576FC
	public static UdpByteConverter op_Implicit(int val) { }

	// RVA: 0x7D57704 Offset: 0x7D53704 VA: 0x7D57704
	public static UdpByteConverter op_Implicit(ulong val) { }

	// RVA: 0x7D57708 Offset: 0x7D53708 VA: 0x7D57708
	public static UdpByteConverter op_Implicit(long val) { }

	// RVA: 0x7D5770C Offset: 0x7D5370C VA: 0x7D5770C
	public static UdpByteConverter op_Implicit(float val) { }

	// RVA: 0x7D57714 Offset: 0x7D53714 VA: 0x7D57714
	public static UdpByteConverter op_Implicit(double val) { }
}

// Namespace: Photon.Deterministic
internal static class UdpMath // TypeDefIndex: 24075
{
	// Fields
	private static readonly string[] _byteHexValue; // 0x0

	// Methods

	// RVA: 0x7D5771C Offset: 0x7D5371C VA: 0x7D5771C
	public static int BitsRequiredForNumber(uint n) { }

	// RVA: 0x7D57740 Offset: 0x7D53740 VA: 0x7D57740
	public static int BitsRequiredForNumber(int n) { }

	// RVA: 0x7D57764 Offset: 0x7D53764 VA: 0x7D57764
	public static bool IsPowerOfTwo(uint x) { }

	// RVA: 0x7D57784 Offset: 0x7D53784 VA: 0x7D57784
	public static bool IsMultipleOf8(uint value) { }

	// RVA: 0x7D5779C Offset: 0x7D5379C VA: 0x7D5779C
	public static bool IsMultipleOf8(int value) { }

	// RVA: 0x7D577B4 Offset: 0x7D537B4 VA: 0x7D577B4
	public static uint NextPow2(uint v) { }

	// RVA: 0x7D577D4 Offset: 0x7D537D4 VA: 0x7D577D4
	public static int HighBit(uint v) { }

	// RVA: 0x7D577EC Offset: 0x7D537EC VA: 0x7D577EC
	public static int BytesRequired(int bits) { }

	// RVA: 0x7D577F8 Offset: 0x7D537F8 VA: 0x7D577F8
	public static int SeqDistance(uint from, uint to, int shift) { }

	// RVA: 0x7D57808 Offset: 0x7D53808 VA: 0x7D57808
	public static int SeqDistance(ushort from, ushort to, int shift) { }

	// RVA: 0x7D57820 Offset: 0x7D53820 VA: 0x7D57820
	public static uint SeqNext(uint seq, uint mask) { }

	// RVA: 0x7D5782C Offset: 0x7D5382C VA: 0x7D5782C
	public static ushort SeqNext(ushort seq, ushort mask) { }

	// RVA: 0x7D57838 Offset: 0x7D53838 VA: 0x7D57838
	public static ushort SeqPrev(ushort seq, ushort mask) { }

	// RVA: 0x7D57844 Offset: 0x7D53844 VA: 0x7D57844
	internal static bool IsSet(uint mask, uint flag) { }

	// RVA: 0x7D57850 Offset: 0x7D53850 VA: 0x7D57850
	internal static ushort Clamp(ushort value, ushort min, ushort max) { }

	// RVA: 0x7D57870 Offset: 0x7D53870 VA: 0x7D57870
	internal static float Clamp(float value, float min, float max) { }

	// RVA: 0x7D57890 Offset: 0x7D53890 VA: 0x7D57890
	internal static int Clamp(int value, int min, int max) { }

	// RVA: 0x7D578AC Offset: 0x7D538AC VA: 0x7D578AC
	internal static uint Clamp(uint value, uint min, uint max) { }

	// RVA: 0x7D578C8 Offset: 0x7D538C8 VA: 0x7D578C8
	internal static byte Clamp(byte value, byte min, byte max) { }

	// RVA: 0x7D578E8 Offset: 0x7D538E8 VA: 0x7D578E8
	public static string ByteToHex(byte value) { }

	// RVA: 0x7D57964 Offset: 0x7D53964 VA: 0x7D57964
	public static string PrintBytesHex(byte* buffer, int length) { }

	// RVA: 0x7D57A78 Offset: 0x7D53A78 VA: 0x7D57A78
	private static void .cctor() { }
}

// Namespace: Photon.Deterministic
[Extension]
internal static class Utils // TypeDefIndex: 24076
{
	// Methods

	[Extension]
	// RVA: 0x7D5AB68 Offset: 0x7D56B68 VA: 0x7D5AB68
	public static string ToStringArray(Array array) { }
}

// Namespace: Photon.Analyzer
[Usage(256)]
[Conditional("false")]
public class StaticFieldAttribute : Attribute // TypeDefIndex: 24077
{
	// Fields
	[CompilerGenerated]
	private readonly StaticFieldResetMode <Reset>k__BackingField; // 0x10

	// Properties
	public StaticFieldResetMode Reset { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7D5AD0C Offset: 0x7D56D0C VA: 0x7D5AD0C
	public StaticFieldResetMode get_Reset() { }

	// RVA: 0x7D5AD14 Offset: 0x7D56D14 VA: 0x7D5AD14
	public void .ctor(StaticFieldResetMode resetMode) { }

	// RVA: 0x7D5AD3C Offset: 0x7D56D3C VA: 0x7D5AD3C
	public void .ctor() { }
}

// Namespace: Photon.Analyzer
[Usage(64)]
[Conditional("false")]
public class StaticFieldResetMethodAttribute : Attribute // TypeDefIndex: 24078
{
	// Methods

	// RVA: 0x7D5AD5C Offset: 0x7D56D5C VA: 0x7D5AD5C
	public void .ctor() { }
}

// Namespace: Photon.Analyzer
public enum StaticFieldResetMode // TypeDefIndex: 24079
{
	// Fields
	public int value__; // 0x0
	public const StaticFieldResetMode None = 0;
	public const StaticFieldResetMode Manual = 1;
	public const StaticFieldResetMode ResetMethod = 2;
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=264 // TypeDefIndex: 24080
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=504 // TypeDefIndex: 24081
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 // TypeDefIndex: 24082
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2751 // TypeDefIndex: 24083
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3919 // TypeDefIndex: 24084
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 24085
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2751 6A27E903903EA890BC7D4504C366F7C9058C8F086B8AAF990D26D006E2236C36 /*Metadata offset 0xF32590*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3919 93B8A4B83323F92CD027421B1B73B3F5621DC17FBF3CA457B1089F57C5882039 /*Metadata offset 0xF33050*/; // 0xABF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=504 B7F5F5F1F8B299DE7D2A07D3A91643CEAADDD96A7D24525B177284D3BA1C40F8 /*Metadata offset 0xF33FA0*/; // 0x1A0E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=264 D7C20AA110EDDCB69ED4FC0E77C6320FCA4C1A9AF2A6BB178F4272B38134FB75 /*Metadata offset 0xF341A0*/; // 0x1C06
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 E0D21FC6200880C2170D9145ECDF89F5F5DC60FFD0921F72E4DCFFE26B9E2A8B /*Metadata offset 0xF342B0*/; // 0x1D0E
}

