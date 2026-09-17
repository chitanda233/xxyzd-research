// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28834
{}

// Namespace: UnityEngine
[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
public static class JsonUtility // TypeDefIndex: 28835
{
	// Methods

	[FreeFunction("ToJsonInternal", True)]
	[ThreadSafe]
	// RVA: 0x87B5638 Offset: 0x87B1638 VA: 0x87B5638
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	[ThreadSafe]
	[FreeFunction("FromJsonInternal", True, ThrowsException = True)]
	// RVA: 0x87B567C Offset: 0x87B167C VA: 0x87B567C
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: 0x87B56D0 Offset: 0x87B16D0 VA: 0x87B56D0
	public static string ToJson(object obj) { }

	// RVA: 0x87B56D8 Offset: 0x87B16D8 VA: 0x87B56D8
	public static string ToJson(object obj, bool prettyPrint) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46548A4 Offset: 0x46508A4 VA: 0x46548A4
	|-JsonUtility.FromJson<DiagnosticEvent>
	|
	|-RVA: 0x4654984 Offset: 0x4650984 VA: 0x4654984
	|-JsonUtility.FromJson<object>
	|
	|-RVA: 0x4654A44 Offset: 0x4650A44 VA: 0x4654A44
	|-JsonUtility.FromJson<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x87B5848 Offset: 0x87B1848 VA: 0x87B5848
	public static object FromJson(string json, Type type) { }

	// RVA: 0x87B5A38 Offset: 0x87B1A38 VA: 0x87B5A38
	public static void FromJsonOverwrite(string json, object objectToOverwrite) { }
}

