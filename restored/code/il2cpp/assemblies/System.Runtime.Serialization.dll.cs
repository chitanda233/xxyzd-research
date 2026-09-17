// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28953
{}

// Namespace: System.Runtime.Serialization
[Usage(28, Inherited = False, AllowMultiple = False)]
public sealed class DataContractAttribute : Attribute // TypeDefIndex: 28954
{
	// Fields
	private bool isReference; // 0x10

	// Properties
	public bool IsReference { get; }

	// Methods

	// RVA: 0x819324C Offset: 0x818F24C VA: 0x819324C
	public bool get_IsReference() { }
}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 28955
{
	// Fields
	private string name; // 0x10
	private int order; // 0x18
	private bool isRequired; // 0x1C
	private bool emitDefaultValue; // 0x1D

	// Properties
	public string Name { get; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; }

	// Methods

	// RVA: 0x8193254 Offset: 0x818F254 VA: 0x8193254
	public string get_Name() { }

	// RVA: 0x819325C Offset: 0x818F25C VA: 0x819325C
	public int get_Order() { }

	// RVA: 0x8193264 Offset: 0x818F264 VA: 0x8193264
	public bool get_IsRequired() { }

	// RVA: 0x819326C Offset: 0x818F26C VA: 0x819326C
	public bool get_EmitDefaultValue() { }
}

// Namespace: System.Runtime.Serialization
[Usage(256, Inherited = False, AllowMultiple = False)]
public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 28956
{
	// Fields
	private string value; // 0x10

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x8193274 Offset: 0x818F274 VA: 0x8193274
	public string get_Value() { }
}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class IgnoreDataMemberAttribute : Attribute // TypeDefIndex: 28957
{}

