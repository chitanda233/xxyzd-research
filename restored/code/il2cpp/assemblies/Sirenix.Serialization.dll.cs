// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 22284
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <>f__AnonymousType0<<Assembly>j__TPar, <Attribute>j__TPar> // TypeDefIndex: 22285
{
	// Fields
	[DebuggerBrowsable(0)]
	private readonly <Assembly>j__TPar <Assembly>i__Field; // 0x0
	[DebuggerBrowsable(0)]
	private readonly <Attribute>j__TPar <Attribute>i__Field; // 0x0

	// Properties
	public <Assembly>j__TPar Assembly { get; }
	public <Attribute>j__TPar Attribute { get; }

	// Methods

	// RVA: -1 Offset: -1
	public <Assembly>j__TPar get_Assembly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546C4B8 Offset: 0x54684B8 VA: 0x546C4B8
	|-<>f__AnonymousType0<object, object>.get_Assembly
	|
	|-RVA: 0x546DD50 Offset: 0x5469D50 VA: 0x546DD50
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Assembly
	*/

	// RVA: -1 Offset: -1
	public <Attribute>j__TPar get_Attribute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546C4C0 Offset: 0x54684C0 VA: 0x546C4C0
	|-<>f__AnonymousType0<object, object>.get_Attribute
	|
	|-RVA: 0x546DDE8 Offset: 0x5469DE8 VA: 0x546DDE8
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Attribute
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(<Assembly>j__TPar Assembly, <Attribute>j__TPar Attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546C4C8 Offset: 0x54684C8 VA: 0x546C4C8
	|-<>f__AnonymousType0<object, object>..ctor
	|
	|-RVA: 0x546DE88 Offset: 0x5469E88 VA: 0x546DE88
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546C50C Offset: 0x546850C VA: 0x546C50C
	|-<>f__AnonymousType0<object, object>.Equals
	|
	|-RVA: 0x546DFCC Offset: 0x5469FCC VA: 0x546DFCC
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546C5E0 Offset: 0x54685E0 VA: 0x546C5E0
	|-<>f__AnonymousType0<object, object>.GetHashCode
	|
	|-RVA: 0x546E258 Offset: 0x546A258 VA: 0x546E258
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546C66C Offset: 0x546866C VA: 0x546C66C
	|-<>f__AnonymousType0<object, object>.ToString
	|
	|-RVA: 0x546E40C Offset: 0x546A40C VA: 0x546E40C
	|-<>f__AnonymousType0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: Sirenix.OdinInspector
public abstract class SerializedBehaviour : Behaviour, ISerializationCallbackReceiver, ISupportsPrefabSerialization // TypeDefIndex: 22286
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private SerializationData serializationData; // 0x18

	// Properties
	private SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.SerializationData { get; set; }

	// Methods

	// RVA: 0x7E848DC Offset: 0x7E808DC VA: 0x7E848DC Slot: 6
	private SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData() { }

	// RVA: 0x7E848F8 Offset: 0x7E808F8 VA: 0x7E848F8 Slot: 7
	private void Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(SerializationData value) { }

	// RVA: 0x7E84920 Offset: 0x7E80920 VA: 0x7E84920 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x7E849D4 Offset: 0x7E809D4 VA: 0x7E849D4 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x7E84A8C Offset: 0x7E80A8C VA: 0x7E84A8C Slot: 8
	protected virtual void OnAfterDeserialize() { }

	// RVA: 0x7E84A90 Offset: 0x7E80A90 VA: 0x7E84A90 Slot: 9
	protected virtual void OnBeforeSerialize() { }

	// RVA: 0x7E84A94 Offset: 0x7E80A94 VA: 0x7E84A94
	protected void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
public abstract class SerializedComponent : Component, ISerializationCallbackReceiver, ISupportsPrefabSerialization // TypeDefIndex: 22287
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private SerializationData serializationData; // 0x18

	// Properties
	private SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.SerializationData { get; set; }

	// Methods

	// RVA: 0x7E84A9C Offset: 0x7E80A9C VA: 0x7E84A9C Slot: 6
	private SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData() { }

	// RVA: 0x7E84AB8 Offset: 0x7E80AB8 VA: 0x7E84AB8 Slot: 7
	private void Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(SerializationData value) { }

	// RVA: 0x7E84AE0 Offset: 0x7E80AE0 VA: 0x7E84AE0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x7E84B94 Offset: 0x7E80B94 VA: 0x7E84B94 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x7E84C4C Offset: 0x7E80C4C VA: 0x7E84C4C Slot: 8
	protected virtual void OnAfterDeserialize() { }

	// RVA: 0x7E84C50 Offset: 0x7E80C50 VA: 0x7E84C50 Slot: 9
	protected virtual void OnBeforeSerialize() { }

	// RVA: 0x7E84C54 Offset: 0x7E80C54 VA: 0x7E84C54
	protected void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
public abstract class SerializedMonoBehaviour : MonoBehaviour, ISerializationCallbackReceiver, ISupportsPrefabSerialization // TypeDefIndex: 22288
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private SerializationData serializationData; // 0x20

	// Properties
	private SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.SerializationData { get; set; }

	// Methods

	// RVA: 0x7E84C5C Offset: 0x7E80C5C VA: 0x7E84C5C Slot: 6
	private SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData() { }

	// RVA: 0x7E84C70 Offset: 0x7E80C70 VA: 0x7E84C70 Slot: 7
	private void Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(SerializationData value) { }

	// RVA: 0x7E84C90 Offset: 0x7E80C90 VA: 0x7E84C90 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x7E84D44 Offset: 0x7E80D44 VA: 0x7E84D44 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x7E84DFC Offset: 0x7E80DFC VA: 0x7E84DFC Slot: 8
	protected virtual void OnAfterDeserialize() { }

	// RVA: 0x7E84E00 Offset: 0x7E80E00 VA: 0x7E84E00 Slot: 9
	protected virtual void OnBeforeSerialize() { }

	// RVA: 0x7E84E04 Offset: 0x7E80E04 VA: 0x7E84E04
	protected void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
public abstract class SerializedScriptableObject : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 22289
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private SerializationData serializationData; // 0x18

	// Methods

	// RVA: 0x7E84E0C Offset: 0x7E80E0C VA: 0x7E84E0C Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x7E84EC0 Offset: 0x7E80EC0 VA: 0x7E84EC0 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x7E84F78 Offset: 0x7E80F78 VA: 0x7E84F78 Slot: 6
	protected virtual void OnAfterDeserialize() { }

	// RVA: 0x7E84F7C Offset: 0x7E80F7C VA: 0x7E84F7C Slot: 7
	protected virtual void OnBeforeSerialize() { }

	// RVA: 0x7E84F80 Offset: 0x7E80F80 VA: 0x7E84F80
	protected void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
public abstract class SerializedStateMachineBehaviour : StateMachineBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 22290
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private SerializationData serializationData; // 0x18

	// Methods

	// RVA: 0x7E84F88 Offset: 0x7E80F88 VA: 0x7E84F88 Slot: 19
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x7E85040 Offset: 0x7E81040 VA: 0x7E85040 Slot: 18
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x7E850FC Offset: 0x7E810FC VA: 0x7E850FC Slot: 20
	protected virtual void OnAfterDeserialize() { }

	// RVA: 0x7E85100 Offset: 0x7E81100 VA: 0x7E85100 Slot: 21
	protected virtual void OnBeforeSerialize() { }

	// RVA: 0x7E85104 Offset: 0x7E81104 VA: 0x7E85104
	protected void .ctor() { }
}

// Namespace: Sirenix.OdinInspector
public abstract class SerializedUnityObject : Object, ISerializationCallbackReceiver // TypeDefIndex: 22291
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private SerializationData serializationData; // 0x18

	// Methods

	// RVA: 0x7E8510C Offset: 0x7E8110C VA: 0x7E8510C Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x7E851C0 Offset: 0x7E811C0 VA: 0x7E851C0 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x7E85278 Offset: 0x7E81278 VA: 0x7E85278 Slot: 6
	protected virtual void OnAfterDeserialize() { }

	// RVA: 0x7E8527C Offset: 0x7E8127C VA: 0x7E8527C Slot: 7
	protected virtual void OnBeforeSerialize() { }

	// RVA: 0x7E85280 Offset: 0x7E81280 VA: 0x7E85280
	protected void .ctor() { }
}

// Namespace: Sirenix.Serialization
public abstract class BaseDataReader : BaseDataReaderWriter, IDataReader, IDisposable // TypeDefIndex: 22292
{
	// Fields
	private DeserializationContext context; // 0x20
	private Stream stream; // 0x28

	// Properties
	public int CurrentNodeId { get; }
	public int CurrentNodeDepth { get; }
	public string CurrentNodeName { get; }
	public virtual Stream Stream { get; set; }
	public DeserializationContext Context { get; set; }

	// Methods

	// RVA: 0x7E852D8 Offset: 0x7E812D8 VA: 0x7E852D8
	protected void .ctor(Stream stream, DeserializationContext context) { }

	// RVA: 0x7E85394 Offset: 0x7E81394 VA: 0x7E85394 Slot: 13
	public int get_CurrentNodeId() { }

	// RVA: 0x7E85450 Offset: 0x7E81450 VA: 0x7E85450 Slot: 14
	public int get_CurrentNodeDepth() { }

	// RVA: 0x7E85458 Offset: 0x7E81458 VA: 0x7E85458 Slot: 12
	public string get_CurrentNodeName() { }

	// RVA: 0x7E85478 Offset: 0x7E81478 VA: 0x7E85478 Slot: 47
	public virtual Stream get_Stream() { }

	// RVA: 0x7E85480 Offset: 0x7E81480 VA: 0x7E85480 Slot: 48
	public virtual void set_Stream(Stream value) { }

	// RVA: 0x7E8553C Offset: 0x7E8153C VA: 0x7E8553C Slot: 15
	public DeserializationContext get_Context() { }

	// RVA: 0x7E855AC Offset: 0x7E815AC VA: 0x7E855AC Slot: 16
	public void set_Context(DeserializationContext value) { }

	// RVA: -1 Offset: -1 Slot: 49
	public abstract bool EnterNode(out Type type);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract bool ExitNode();

	// RVA: -1 Offset: -1 Slot: 51
	public abstract bool EnterArray(out long length);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract bool ExitArray();

	// RVA: -1 Offset: -1 Slot: 53
	public abstract bool ReadPrimitiveArray<T>(out T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseDataReader.ReadPrimitiveArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1 Slot: 54
	public abstract EntryType PeekEntry(out string name);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract bool ReadInternalReference(out int id);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract bool ReadExternalReference(out int index);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract bool ReadExternalReference(out Guid guid);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract bool ReadExternalReference(out string id);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract bool ReadChar(out char value);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract bool ReadString(out string value);

	// RVA: -1 Offset: -1 Slot: 61
	public abstract bool ReadGuid(out Guid value);

	// RVA: -1 Offset: -1 Slot: 62
	public abstract bool ReadSByte(out sbyte value);

	// RVA: -1 Offset: -1 Slot: 63
	public abstract bool ReadInt16(out short value);

	// RVA: -1 Offset: -1 Slot: 64
	public abstract bool ReadInt32(out int value);

	// RVA: -1 Offset: -1 Slot: 65
	public abstract bool ReadInt64(out long value);

	// RVA: -1 Offset: -1 Slot: 66
	public abstract bool ReadByte(out byte value);

	// RVA: -1 Offset: -1 Slot: 67
	public abstract bool ReadUInt16(out ushort value);

	// RVA: -1 Offset: -1 Slot: 68
	public abstract bool ReadUInt32(out uint value);

	// RVA: -1 Offset: -1 Slot: 69
	public abstract bool ReadUInt64(out ulong value);

	// RVA: -1 Offset: -1 Slot: 70
	public abstract bool ReadDecimal(out Decimal value);

	// RVA: -1 Offset: -1 Slot: 71
	public abstract bool ReadSingle(out float value);

	// RVA: -1 Offset: -1 Slot: 72
	public abstract bool ReadDouble(out double value);

	// RVA: -1 Offset: -1 Slot: 73
	public abstract bool ReadBoolean(out bool value);

	// RVA: -1 Offset: -1 Slot: 74
	public abstract bool ReadNull();

	// RVA: 0x7E855B4 Offset: 0x7E815B4 VA: 0x7E855B4 Slot: 75
	public virtual void SkipEntry() { }

	// RVA: -1 Offset: -1 Slot: 76
	public abstract void Dispose();

	// RVA: 0x7E85B28 Offset: 0x7E81B28 VA: 0x7E85B28 Slot: 77
	public virtual void PrepareNewSerializationSession() { }

	// RVA: -1 Offset: -1 Slot: 78
	public abstract string GetDataDump();

	// RVA: -1 Offset: -1 Slot: 79
	protected abstract EntryType PeekEntry();

	// RVA: -1 Offset: -1 Slot: 80
	protected abstract EntryType ReadToNextEntry();
}

// Namespace: Sirenix.Serialization
public abstract class BaseDataReaderWriter // TypeDefIndex: 22293
{
	// Fields
	private NodeInfo[] nodes; // 0x10
	private int nodesLength; // 0x18

	// Properties
	[Obsolete("Use the Binder member on the writer's SerializationContext/DeserializationContext instead.", False)]
	[EditorBrowsable(1)]
	public TwoWaySerializationBinder Binder { get; set; }
	public bool IsInArrayNode { get; }
	protected int NodeDepth { get; }
	protected NodeInfo[] NodesArray { get; }
	protected NodeInfo CurrentNode { get; }

	// Methods

	// RVA: 0x7E85B38 Offset: 0x7E81B38 VA: 0x7E85B38 Slot: 4
	public TwoWaySerializationBinder get_Binder() { }

	// RVA: 0x7E85D08 Offset: 0x7E81D08 VA: 0x7E85D08 Slot: 5
	public void set_Binder(TwoWaySerializationBinder value) { }

	// RVA: 0x7E85E8C Offset: 0x7E81E8C VA: 0x7E85E8C Slot: 6
	public bool get_IsInArrayNode() { }

	// RVA: 0x7E85EDC Offset: 0x7E81EDC VA: 0x7E85EDC
	protected int get_NodeDepth() { }

	// RVA: 0x7E85EE4 Offset: 0x7E81EE4 VA: 0x7E85EE4
	protected NodeInfo[] get_NodesArray() { }

	// RVA: 0x7E853B4 Offset: 0x7E813B4 VA: 0x7E853B4
	protected NodeInfo get_CurrentNode() { }

	// RVA: 0x7E85EEC Offset: 0x7E81EEC VA: 0x7E85EEC
	protected void PushNode(NodeInfo node) { }

	// RVA: 0x7E8609C Offset: 0x7E8209C VA: 0x7E8609C
	protected void PushNode(string name, int id, Type type) { }

	// RVA: 0x7E8616C Offset: 0x7E8216C VA: 0x7E8616C
	protected void PushArray() { }

	// RVA: 0x7E85F9C Offset: 0x7E81F9C VA: 0x7E85F9C
	private void ExpandNodes() { }

	// RVA: 0x7E86288 Offset: 0x7E82288 VA: 0x7E86288
	protected void PopNode(string name) { }

	// RVA: 0x7E862EC Offset: 0x7E822EC VA: 0x7E862EC
	protected void PopArray() { }

	// RVA: 0x7E85B30 Offset: 0x7E81B30 VA: 0x7E85B30
	protected void ClearNodes() { }

	// RVA: 0x7E85330 Offset: 0x7E81330 VA: 0x7E85330
	protected void .ctor() { }
}

// Namespace: Sirenix.Serialization
public abstract class BaseDataWriter : BaseDataReaderWriter, IDataWriter, IDisposable // TypeDefIndex: 22294
{
	// Fields
	private SerializationContext context; // 0x20
	private Stream stream; // 0x28

	// Properties
	public virtual Stream Stream { get; set; }
	public SerializationContext Context { get; set; }

	// Methods

	// RVA: 0x7E8639C Offset: 0x7E8239C VA: 0x7E8639C
	protected void .ctor(Stream stream, SerializationContext context) { }

	// RVA: 0x7E863F4 Offset: 0x7E823F4 VA: 0x7E863F4 Slot: 44
	public virtual Stream get_Stream() { }

	// RVA: 0x7E863FC Offset: 0x7E823FC VA: 0x7E863FC Slot: 45
	public virtual void set_Stream(Stream value) { }

	// RVA: 0x7E864B8 Offset: 0x7E824B8 VA: 0x7E864B8 Slot: 12
	public SerializationContext get_Context() { }

	// RVA: 0x7E86528 Offset: 0x7E82528 VA: 0x7E86528 Slot: 13
	public void set_Context(SerializationContext value) { }

	// RVA: 0x7E86530 Offset: 0x7E82530 VA: 0x7E86530 Slot: 46
	public virtual void FlushToStream() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract void BeginReferenceNode(string name, Type type, int id);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract void BeginStructNode(string name, Type type);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract void EndNode(string name);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract void BeginArrayNode(long length);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract void EndArrayNode();

	// RVA: -1 Offset: -1 Slot: 52
	public abstract void WritePrimitiveArray<T>(T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseDataWriter.WritePrimitiveArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1 Slot: 53
	public abstract void WriteNull(string name);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract void WriteInternalReference(string name, int id);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract void WriteExternalReference(string name, int index);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract void WriteExternalReference(string name, Guid guid);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract void WriteExternalReference(string name, string id);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract void WriteChar(string name, char value);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract void WriteString(string name, string value);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract void WriteGuid(string name, Guid value);

	// RVA: -1 Offset: -1 Slot: 61
	public abstract void WriteSByte(string name, sbyte value);

	// RVA: -1 Offset: -1 Slot: 62
	public abstract void WriteInt16(string name, short value);

	// RVA: -1 Offset: -1 Slot: 63
	public abstract void WriteInt32(string name, int value);

	// RVA: -1 Offset: -1 Slot: 64
	public abstract void WriteInt64(string name, long value);

	// RVA: -1 Offset: -1 Slot: 65
	public abstract void WriteByte(string name, byte value);

	// RVA: -1 Offset: -1 Slot: 66
	public abstract void WriteUInt16(string name, ushort value);

	// RVA: -1 Offset: -1 Slot: 67
	public abstract void WriteUInt32(string name, uint value);

	// RVA: -1 Offset: -1 Slot: 68
	public abstract void WriteUInt64(string name, ulong value);

	// RVA: -1 Offset: -1 Slot: 69
	public abstract void WriteDecimal(string name, Decimal value);

	// RVA: -1 Offset: -1 Slot: 70
	public abstract void WriteSingle(string name, float value);

	// RVA: -1 Offset: -1 Slot: 71
	public abstract void WriteDouble(string name, double value);

	// RVA: -1 Offset: -1 Slot: 72
	public abstract void WriteBoolean(string name, bool value);

	// RVA: -1 Offset: -1 Slot: 73
	public abstract void Dispose();

	// RVA: 0x7E86560 Offset: 0x7E82560 VA: 0x7E86560 Slot: 74
	public virtual void PrepareNewSerializationSession() { }

	// RVA: -1 Offset: -1 Slot: 75
	public abstract string GetDataDump();
}

// Namespace: 
private struct BinaryDataReader.Struct256Bit // TypeDefIndex: 22295
{
	// Fields
	public Decimal d1; // 0x0
	public Decimal d2; // 0x10
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class BinaryDataReader.<>c // TypeDefIndex: 22296
{
	// Fields
	public static readonly BinaryDataReader.<>c <>9; // 0x0

	// Methods

	// RVA: 0x7E8BDE4 Offset: 0x7E87DE4 VA: 0x7E8BDE4
	private static void .cctor() { }

	// RVA: 0x7E8BE4C Offset: 0x7E87E4C VA: 0x7E8BE4C
	public void .ctor() { }

	// RVA: 0x7E8BE54 Offset: 0x7E87E54 VA: 0x7E8BE54
	internal char <.cctor>b__64_0(byte[] b, int i) { }

	// RVA: 0x7E8BEBC Offset: 0x7E87EBC VA: 0x7E8BEBC
	internal byte <.cctor>b__64_1(byte[] b, int i) { }

	// RVA: 0x7E8BEE8 Offset: 0x7E87EE8 VA: 0x7E8BEE8
	internal sbyte <.cctor>b__64_2(byte[] b, int i) { }

	// RVA: 0x7E8BF14 Offset: 0x7E87F14 VA: 0x7E8BF14
	internal bool <.cctor>b__64_3(byte[] b, int i) { }
}

// Namespace: Sirenix.Serialization
public class BinaryDataReader : BaseDataReader // TypeDefIndex: 22297
{
	// Fields
	private static readonly Dictionary<Type, Delegate> PrimitiveFromByteMethods; // 0x0
	private byte[] internalBufferBackup; // 0x30
	private byte[] buffer; // 0x38
	private int bufferIndex; // 0x40
	private int bufferEnd; // 0x44
	private Nullable<EntryType> peekedEntryType; // 0x48
	private BinaryEntryType peekedBinaryEntryType; // 0x4A
	private string peekedEntryName; // 0x50
	private Dictionary<int, Type> types; // 0x58

	// Methods

	// RVA: 0x7E86568 Offset: 0x7E82568 VA: 0x7E86568
	public void .ctor() { }

	// RVA: 0x7E86648 Offset: 0x7E82648 VA: 0x7E86648
	public void .ctor(Stream stream, DeserializationContext context) { }

	// RVA: 0x7E86730 Offset: 0x7E82730 VA: 0x7E86730 Slot: 76
	public override void Dispose() { }

	// RVA: 0x7E86734 Offset: 0x7E82734 VA: 0x7E86734 Slot: 54
	public override EntryType PeekEntry(out string name) { }

	// RVA: 0x7E86E88 Offset: 0x7E82E88 VA: 0x7E86E88 Slot: 51
	public override bool EnterArray(out long length) { }

	// RVA: 0x7E870D4 Offset: 0x7E830D4 VA: 0x7E870D4 Slot: 49
	public override bool EnterNode(out Type type) { }

	// RVA: 0x7E8726C Offset: 0x7E8326C VA: 0x7E8726C Slot: 52
	public override bool ExitArray() { }

	// RVA: 0x7E873B0 Offset: 0x7E833B0 VA: 0x7E873B0 Slot: 50
	public override bool ExitNode() { }

	// RVA: -1 Offset: -1 Slot: 53
	public override bool ReadPrimitiveArray<T>(out T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4540FE8 Offset: 0x453CFE8 VA: 0x4540FE8
	|-BinaryDataReader.ReadPrimitiveArray<bool>
	|
	|-RVA: 0x454167C Offset: 0x453D67C VA: 0x454167C
	|-BinaryDataReader.ReadPrimitiveArray<byte>
	|
	|-RVA: 0x4541D0C Offset: 0x453DD0C VA: 0x4541D0C
	|-BinaryDataReader.ReadPrimitiveArray<char>
	|
	|-RVA: 0x454239C Offset: 0x453E39C VA: 0x454239C
	|-BinaryDataReader.ReadPrimitiveArray<Decimal>
	|
	|-RVA: 0x4542A34 Offset: 0x453EA34 VA: 0x4542A34
	|-BinaryDataReader.ReadPrimitiveArray<double>
	|
	|-RVA: 0x45430C4 Offset: 0x453F0C4 VA: 0x45430C4
	|-BinaryDataReader.ReadPrimitiveArray<Guid>
	|
	|-RVA: 0x454375C Offset: 0x453F75C VA: 0x454375C
	|-BinaryDataReader.ReadPrimitiveArray<short>
	|
	|-RVA: 0x4543DEC Offset: 0x453FDEC VA: 0x4543DEC
	|-BinaryDataReader.ReadPrimitiveArray<int>
	|
	|-RVA: 0x454447C Offset: 0x454047C VA: 0x454447C
	|-BinaryDataReader.ReadPrimitiveArray<long>
	|
	|-RVA: 0x4544B0C Offset: 0x4540B0C VA: 0x4544B0C
	|-BinaryDataReader.ReadPrimitiveArray<sbyte>
	|
	|-RVA: 0x454519C Offset: 0x454119C VA: 0x454519C
	|-BinaryDataReader.ReadPrimitiveArray<float>
	|
	|-RVA: 0x454582C Offset: 0x454182C VA: 0x454582C
	|-BinaryDataReader.ReadPrimitiveArray<ushort>
	|
	|-RVA: 0x4545EBC Offset: 0x4541EBC VA: 0x4545EBC
	|-BinaryDataReader.ReadPrimitiveArray<uint>
	|
	|-RVA: 0x454654C Offset: 0x454254C VA: 0x454654C
	|-BinaryDataReader.ReadPrimitiveArray<ulong>
	|
	|-RVA: 0x4546BDC Offset: 0x4542BDC VA: 0x4546BDC
	|-BinaryDataReader.ReadPrimitiveArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7E87500 Offset: 0x7E83500 VA: 0x7E87500 Slot: 73
	public override bool ReadBoolean(out bool value) { }

	// RVA: 0x7E87624 Offset: 0x7E83624 VA: 0x7E87624 Slot: 62
	public override bool ReadSByte(out sbyte value) { }

	// RVA: 0x7E87734 Offset: 0x7E83734 VA: 0x7E87734 Slot: 66
	public override bool ReadByte(out byte value) { }

	// RVA: 0x7E87844 Offset: 0x7E83844 VA: 0x7E87844 Slot: 63
	public override bool ReadInt16(out short value) { }

	// RVA: 0x7E87954 Offset: 0x7E83954 VA: 0x7E87954 Slot: 67
	public override bool ReadUInt16(out ushort value) { }

	// RVA: 0x7E87A64 Offset: 0x7E83A64 VA: 0x7E87A64 Slot: 64
	public override bool ReadInt32(out int value) { }

	// RVA: 0x7E87B78 Offset: 0x7E83B78 VA: 0x7E87B78 Slot: 68
	public override bool ReadUInt32(out uint value) { }

	// RVA: 0x7E87C88 Offset: 0x7E83C88 VA: 0x7E87C88 Slot: 65
	public override bool ReadInt64(out long value) { }

	// RVA: 0x7E88218 Offset: 0x7E84218 VA: 0x7E88218 Slot: 69
	public override bool ReadUInt64(out ulong value) { }

	// RVA: 0x7E88770 Offset: 0x7E84770 VA: 0x7E88770 Slot: 59
	public override bool ReadChar(out char value) { }

	// RVA: 0x7E888D8 Offset: 0x7E848D8 VA: 0x7E888D8 Slot: 71
	public override bool ReadSingle(out float value) { }

	// RVA: 0x7E88CBC Offset: 0x7E84CBC VA: 0x7E88CBC Slot: 72
	public override bool ReadDouble(out double value) { }

	// RVA: 0x7E89098 Offset: 0x7E85098 VA: 0x7E89098 Slot: 70
	public override bool ReadDecimal(out Decimal value) { }

	// RVA: 0x7E89598 Offset: 0x7E85598 VA: 0x7E89598 Slot: 57
	public override bool ReadExternalReference(out Guid guid) { }

	// RVA: 0x7E8965C Offset: 0x7E8565C VA: 0x7E8965C Slot: 61
	public override bool ReadGuid(out Guid value) { }

	// RVA: 0x7E89720 Offset: 0x7E85720 VA: 0x7E89720 Slot: 56
	public override bool ReadExternalReference(out int index) { }

	// RVA: 0x7E89840 Offset: 0x7E85840 VA: 0x7E89840 Slot: 58
	public override bool ReadExternalReference(out string id) { }

	// RVA: 0x7E89924 Offset: 0x7E85924 VA: 0x7E89924 Slot: 74
	public override bool ReadNull() { }

	// RVA: 0x7E899CC Offset: 0x7E859CC VA: 0x7E899CC Slot: 55
	public override bool ReadInternalReference(out int id) { }

	// RVA: 0x7E89AEC Offset: 0x7E85AEC VA: 0x7E89AEC Slot: 60
	public override bool ReadString(out string value) { }

	// RVA: 0x7E89BD0 Offset: 0x7E85BD0 VA: 0x7E89BD0 Slot: 77
	public override void PrepareNewSerializationSession() { }

	// RVA: 0x7E89C54 Offset: 0x7E85C54 VA: 0x7E89C54 Slot: 78
	public override string GetDataDump() { }

	// RVA: 0x7E89D50 Offset: 0x7E85D50 VA: 0x7E89D50
	private string ReadStringValue() { }

	// RVA: 0x7E89F2C Offset: 0x7E85F2C VA: 0x7E89F2C
	private void SkipStringValue() { }

	// RVA: 0x7E89FFC Offset: 0x7E85FFC VA: 0x7E89FFC
	private void SkipPeekedEntryContent() { }

	// RVA: 0x7E8A304 Offset: 0x7E86304 VA: 0x7E8A304
	private bool SkipBuffer(int amount) { }

	// RVA: 0x7E8A324 Offset: 0x7E86324 VA: 0x7E8A324
	private Type ReadTypeEntry() { }

	// RVA: 0x7E8A7F0 Offset: 0x7E867F0 VA: 0x7E8A7F0
	private void MarkEntryContentConsumed() { }

	// RVA: 0x7E8A818 Offset: 0x7E86818 VA: 0x7E8A818 Slot: 79
	protected override EntryType PeekEntry() { }

	// RVA: 0x7E8A83C Offset: 0x7E8683C VA: 0x7E8A83C Slot: 80
	protected override EntryType ReadToNextEntry() { }

	// RVA: 0x7E8A874 Offset: 0x7E86874 VA: 0x7E8A874
	private bool UNSAFE_Read_1_Byte(out byte value) { }

	// RVA: 0x7E8A8F0 Offset: 0x7E868F0 VA: 0x7E8A8F0
	private bool UNSAFE_Read_1_SByte(out sbyte value) { }

	// RVA: 0x7E8A96C Offset: 0x7E8696C VA: 0x7E8A96C
	private bool UNSAFE_Read_2_Int16(out short value) { }

	// RVA: 0x7E8A9E8 Offset: 0x7E869E8 VA: 0x7E8A9E8
	private bool UNSAFE_Read_2_UInt16(out ushort value) { }

	// RVA: 0x7E8AA64 Offset: 0x7E86A64 VA: 0x7E8AA64
	private bool UNSAFE_Read_2_Char(out char value) { }

	// RVA: 0x7E8AAE0 Offset: 0x7E86AE0 VA: 0x7E8AAE0
	private bool UNSAFE_Read_4_Int32(out int value) { }

	// RVA: 0x7E8AB64 Offset: 0x7E86B64 VA: 0x7E8AB64
	private bool UNSAFE_Read_4_UInt32(out uint value) { }

	// RVA: 0x7E8ABE8 Offset: 0x7E86BE8 VA: 0x7E8ABE8
	private bool UNSAFE_Read_4_Float32(out float value) { }

	// RVA: 0x7E8ACB4 Offset: 0x7E86CB4 VA: 0x7E8ACB4
	private bool UNSAFE_Read_8_Int64(out long value) { }

	// RVA: 0x7E8ADC0 Offset: 0x7E86DC0 VA: 0x7E8ADC0
	private bool UNSAFE_Read_8_UInt64(out ulong value) { }

	// RVA: 0x7E8AECC Offset: 0x7E86ECC VA: 0x7E8AECC
	private bool UNSAFE_Read_8_Float64(out double value) { }

	// RVA: 0x7E8AFD8 Offset: 0x7E86FD8 VA: 0x7E8AFD8
	private bool UNSAFE_Read_16_Decimal(out Decimal value) { }

	// RVA: 0x7E8B118 Offset: 0x7E87118 VA: 0x7E8B118
	private bool UNSAFE_Read_16_Guid(out Guid value) { }

	// RVA: 0x7E8B238 Offset: 0x7E87238 VA: 0x7E8B238
	private bool HasBufferData(int amount) { }

	// RVA: 0x7E8B278 Offset: 0x7E87278 VA: 0x7E8B278
	private void ReadEntireStreamToBuffer() { }

	// RVA: 0x7E8B59C Offset: 0x7E8759C VA: 0x7E8B59C
	private static void .cctor() { }
}

// Namespace: 
private struct BinaryDataWriter.Struct256Bit // TypeDefIndex: 22298
{
	// Fields
	public Decimal d1; // 0x0
	public Decimal d2; // 0x10
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class BinaryDataWriter.<>c // TypeDefIndex: 22299
{
	// Fields
	public static readonly BinaryDataWriter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x7E94798 Offset: 0x7E90798 VA: 0x7E94798
	private static void .cctor() { }

	// RVA: 0x7E94800 Offset: 0x7E90800 VA: 0x7E94800
	public void .ctor() { }

	// RVA: 0x7E94808 Offset: 0x7E90808 VA: 0x7E94808
	internal void <.cctor>b__70_0(byte[] b, int i, char v) { }

	// RVA: 0x7E94878 Offset: 0x7E90878 VA: 0x7E94878
	internal void <.cctor>b__70_1(byte[] b, int i, byte v) { }

	// RVA: 0x7E948A4 Offset: 0x7E908A4 VA: 0x7E948A4
	internal void <.cctor>b__70_2(byte[] b, int i, sbyte v) { }

	// RVA: 0x7E948D0 Offset: 0x7E908D0 VA: 0x7E948D0
	internal void <.cctor>b__70_3(byte[] b, int i, bool v) { }
}

// Namespace: Sirenix.Serialization
public class BinaryDataWriter : BaseDataWriter // TypeDefIndex: 22300
{
	// Fields
	private static readonly Dictionary<Type, Delegate> PrimitiveGetBytesMethods; // 0x0
	private static readonly Dictionary<Type, int> PrimitiveSizes; // 0x8
	private readonly byte[] small_buffer; // 0x30
	private readonly byte[] buffer; // 0x38
	private int bufferIndex; // 0x40
	private readonly Dictionary<Type, int> types; // 0x48
	public bool CompressStringsTo8BitWhenPossible; // 0x50
	private static readonly Dictionary<Type, Action<BinaryDataWriter, object>> PrimitiveArrayWriters; // 0x10

	// Methods

	// RVA: 0x7E8BF48 Offset: 0x7E87F48 VA: 0x7E8BF48
	public void .ctor() { }

	// RVA: 0x7E8C064 Offset: 0x7E88064 VA: 0x7E8C064
	public void .ctor(Stream stream, SerializationContext context) { }

	// RVA: 0x7E8C188 Offset: 0x7E88188 VA: 0x7E8C188 Slot: 50
	public override void BeginArrayNode(long length) { }

	// RVA: 0x7E8C328 Offset: 0x7E88328 VA: 0x7E8C328 Slot: 47
	public override void BeginReferenceNode(string name, Type type, int id) { }

	// RVA: 0x7E8CD00 Offset: 0x7E88D00 VA: 0x7E8CD00 Slot: 48
	public override void BeginStructNode(string name, Type type) { }

	// RVA: 0x7E8CE20 Offset: 0x7E88E20 VA: 0x7E8CE20 Slot: 73
	public override void Dispose() { }

	// RVA: 0x7E8CE30 Offset: 0x7E88E30 VA: 0x7E8CE30 Slot: 51
	public override void EndArrayNode() { }

	// RVA: 0x7E8CEFC Offset: 0x7E88EFC VA: 0x7E8CEFC Slot: 49
	public override void EndNode(string name) { }

	// RVA: 0x7E8CFC8 Offset: 0x7E88FC8 VA: 0x7E8CFC8
	private static void WritePrimitiveArray_byte(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8D190 Offset: 0x7E89190 VA: 0x7E8D190
	private static void WritePrimitiveArray_sbyte(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8D5BC Offset: 0x7E895BC VA: 0x7E8D5BC
	private static void WritePrimitiveArray_bool(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8D9E8 Offset: 0x7E899E8 VA: 0x7E8D9E8
	private static void WritePrimitiveArray_char(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8DE24 Offset: 0x7E89E24 VA: 0x7E8DE24
	private static void WritePrimitiveArray_short(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8E260 Offset: 0x7E8A260 VA: 0x7E8E260
	private static void WritePrimitiveArray_int(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8E69C Offset: 0x7E8A69C VA: 0x7E8E69C
	private static void WritePrimitiveArray_long(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8EAD8 Offset: 0x7E8AAD8 VA: 0x7E8EAD8
	private static void WritePrimitiveArray_ushort(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8EF14 Offset: 0x7E8AF14 VA: 0x7E8EF14
	private static void WritePrimitiveArray_uint(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8F350 Offset: 0x7E8B350 VA: 0x7E8F350
	private static void WritePrimitiveArray_ulong(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8F844 Offset: 0x7E8B844 VA: 0x7E8F844
	private static void WritePrimitiveArray_decimal(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E8FD74 Offset: 0x7E8BD74 VA: 0x7E8FD74
	private static void WritePrimitiveArray_float(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E901B0 Offset: 0x7E8C1B0 VA: 0x7E901B0
	private static void WritePrimitiveArray_double(BinaryDataWriter writer, object o) { }

	// RVA: 0x7E906A8 Offset: 0x7E8C6A8 VA: 0x7E906A8
	private static void WritePrimitiveArray_Guid(BinaryDataWriter writer, object o) { }

	// RVA: -1 Offset: -1 Slot: 52
	public override void WritePrimitiveArray<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4547350 Offset: 0x4543350 VA: 0x4547350
	|-BinaryDataWriter.WritePrimitiveArray<bool>
	|
	|-RVA: 0x45474FC Offset: 0x45434FC VA: 0x45474FC
	|-BinaryDataWriter.WritePrimitiveArray<byte>
	|
	|-RVA: 0x45476A8 Offset: 0x45436A8 VA: 0x45476A8
	|-BinaryDataWriter.WritePrimitiveArray<char>
	|
	|-RVA: 0x4547854 Offset: 0x4543854 VA: 0x4547854
	|-BinaryDataWriter.WritePrimitiveArray<Decimal>
	|
	|-RVA: 0x4547A00 Offset: 0x4543A00 VA: 0x4547A00
	|-BinaryDataWriter.WritePrimitiveArray<double>
	|
	|-RVA: 0x4547BAC Offset: 0x4543BAC VA: 0x4547BAC
	|-BinaryDataWriter.WritePrimitiveArray<Guid>
	|
	|-RVA: 0x4547D58 Offset: 0x4543D58 VA: 0x4547D58
	|-BinaryDataWriter.WritePrimitiveArray<short>
	|
	|-RVA: 0x4547F04 Offset: 0x4543F04 VA: 0x4547F04
	|-BinaryDataWriter.WritePrimitiveArray<int>
	|
	|-RVA: 0x45480B0 Offset: 0x45440B0 VA: 0x45480B0
	|-BinaryDataWriter.WritePrimitiveArray<long>
	|
	|-RVA: 0x454825C Offset: 0x454425C VA: 0x454825C
	|-BinaryDataWriter.WritePrimitiveArray<sbyte>
	|
	|-RVA: 0x4548408 Offset: 0x4544408 VA: 0x4548408
	|-BinaryDataWriter.WritePrimitiveArray<float>
	|
	|-RVA: 0x45485B4 Offset: 0x45445B4 VA: 0x45485B4
	|-BinaryDataWriter.WritePrimitiveArray<ushort>
	|
	|-RVA: 0x4548760 Offset: 0x4544760 VA: 0x4548760
	|-BinaryDataWriter.WritePrimitiveArray<uint>
	|
	|-RVA: 0x454890C Offset: 0x454490C VA: 0x454890C
	|-BinaryDataWriter.WritePrimitiveArray<ulong>
	|
	|-RVA: 0x4548AB8 Offset: 0x4544AB8 VA: 0x4548AB8
	|-BinaryDataWriter.WritePrimitiveArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7E90BB8 Offset: 0x7E8CBB8 VA: 0x7E90BB8 Slot: 72
	public override void WriteBoolean(string name, bool value) { }

	// RVA: 0x7E90D80 Offset: 0x7E8CD80 VA: 0x7E90D80 Slot: 65
	public override void WriteByte(string name, byte value) { }

	// RVA: 0x7E90F44 Offset: 0x7E8CF44 VA: 0x7E90F44 Slot: 58
	public override void WriteChar(string name, char value) { }

	// RVA: 0x7E91114 Offset: 0x7E8D114 VA: 0x7E91114 Slot: 69
	public override void WriteDecimal(string name, Decimal value) { }

	// RVA: 0x7E912C0 Offset: 0x7E8D2C0 VA: 0x7E912C0 Slot: 71
	public override void WriteDouble(string name, double value) { }

	// RVA: 0x7E91464 Offset: 0x7E8D464 VA: 0x7E91464 Slot: 60
	public override void WriteGuid(string name, Guid value) { }

	// RVA: 0x7E91610 Offset: 0x7E8D610 VA: 0x7E91610 Slot: 56
	public override void WriteExternalReference(string name, Guid guid) { }

	// RVA: 0x7E917BC Offset: 0x7E8D7BC VA: 0x7E917BC Slot: 55
	public override void WriteExternalReference(string name, int index) { }

	// RVA: 0x7E91990 Offset: 0x7E8D990 VA: 0x7E91990 Slot: 57
	public override void WriteExternalReference(string name, string id) { }

	// RVA: 0x7E91AD8 Offset: 0x7E8DAD8 VA: 0x7E91AD8 Slot: 63
	public override void WriteInt32(string name, int value) { }

	// RVA: 0x7E91CAC Offset: 0x7E8DCAC VA: 0x7E91CAC Slot: 64
	public override void WriteInt64(string name, long value) { }

	// RVA: 0x7E91E48 Offset: 0x7E8DE48 VA: 0x7E91E48 Slot: 53
	public override void WriteNull(string name) { }

	// RVA: 0x7E91F48 Offset: 0x7E8DF48 VA: 0x7E91F48 Slot: 54
	public override void WriteInternalReference(string name, int id) { }

	// RVA: 0x7E9211C Offset: 0x7E8E11C VA: 0x7E9211C Slot: 61
	public override void WriteSByte(string name, sbyte value) { }

	// RVA: 0x7E922E0 Offset: 0x7E8E2E0 VA: 0x7E922E0 Slot: 62
	public override void WriteInt16(string name, short value) { }

	// RVA: 0x7E924B0 Offset: 0x7E8E4B0 VA: 0x7E924B0 Slot: 70
	public override void WriteSingle(string name, float value) { }

	// RVA: 0x7E92780 Offset: 0x7E8E780 VA: 0x7E92780 Slot: 59
	public override void WriteString(string name, string value) { }

	// RVA: 0x7E92888 Offset: 0x7E8E888 VA: 0x7E92888 Slot: 67
	public override void WriteUInt32(string name, uint value) { }

	// RVA: 0x7E92A5C Offset: 0x7E8EA5C VA: 0x7E92A5C Slot: 68
	public override void WriteUInt64(string name, ulong value) { }

	// RVA: 0x7E92BF8 Offset: 0x7E8EBF8 VA: 0x7E92BF8 Slot: 66
	public override void WriteUInt16(string name, ushort value) { }

	// RVA: 0x7E92DC8 Offset: 0x7E8EDC8 VA: 0x7E92DC8 Slot: 74
	public override void PrepareNewSerializationSession() { }

	// RVA: 0x7E92E24 Offset: 0x7E8EE24 VA: 0x7E92E24 Slot: 75
	public override string GetDataDump() { }

	// RVA: 0x7E93034 Offset: 0x7E8F034 VA: 0x7E93034
	private void WriteType(Type type) { }

	// RVA: 0x7E8C4C0 Offset: 0x7E884C0 VA: 0x7E8C4C0
	private void WriteStringFast(string value) { }

	// RVA: 0x7E93398 Offset: 0x7E8F398 VA: 0x7E93398 Slot: 46
	public override void FlushToStream() { }

	// RVA: 0x7E933F4 Offset: 0x7E8F3F4 VA: 0x7E933F4
	private void UNSAFE_WriteToBuffer_2_Char(char value) { }

	// RVA: 0x7E93424 Offset: 0x7E8F424 VA: 0x7E93424
	private void UNSAFE_WriteToBuffer_2_Int16(short value) { }

	// RVA: 0x7E93454 Offset: 0x7E8F454 VA: 0x7E93454
	private void UNSAFE_WriteToBuffer_2_UInt16(ushort value) { }

	// RVA: 0x7E93484 Offset: 0x7E8F484 VA: 0x7E93484
	private void UNSAFE_WriteToBuffer_4_Int32(int value) { }

	// RVA: 0x7E934B8 Offset: 0x7E8F4B8 VA: 0x7E934B8
	private void UNSAFE_WriteToBuffer_4_UInt32(uint value) { }

	// RVA: 0x7E934EC Offset: 0x7E8F4EC VA: 0x7E934EC
	private void UNSAFE_WriteToBuffer_4_Float32(float value) { }

	// RVA: 0x7E8C270 Offset: 0x7E88270 VA: 0x7E8C270
	private void UNSAFE_WriteToBuffer_8_Int64(long value) { }

	// RVA: 0x7E8F78C Offset: 0x7E8B78C VA: 0x7E8F78C
	private void UNSAFE_WriteToBuffer_8_UInt64(ulong value) { }

	// RVA: 0x7E905EC Offset: 0x7E8C5EC VA: 0x7E905EC
	private void UNSAFE_WriteToBuffer_8_Float64(double value) { }

	// RVA: 0x7E8FC80 Offset: 0x7E8BC80 VA: 0x7E8FC80
	private void UNSAFE_WriteToBuffer_16_Decimal(Decimal value) { }

	// RVA: 0x7E90AE4 Offset: 0x7E8CAE4 VA: 0x7E90AE4
	private void UNSAFE_WriteToBuffer_16_Guid(Guid value) { }

	// RVA: 0x7E935B8 Offset: 0x7E8F5B8 VA: 0x7E935B8
	private void EnsureBufferSpace(int space) { }

	// RVA: 0x7E93648 Offset: 0x7E8F648 VA: 0x7E93648
	private bool TryEnsureBufferSpace(int space) { }

	// RVA: 0x7E93698 Offset: 0x7E8F698 VA: 0x7E93698
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public enum BinaryEntryType // TypeDefIndex: 22301
{
	// Fields
	public byte value__; // 0x0
	public const BinaryEntryType Invalid = 0;
	public const BinaryEntryType NamedStartOfReferenceNode = 1;
	public const BinaryEntryType UnnamedStartOfReferenceNode = 2;
	public const BinaryEntryType NamedStartOfStructNode = 3;
	public const BinaryEntryType UnnamedStartOfStructNode = 4;
	public const BinaryEntryType EndOfNode = 5;
	public const BinaryEntryType StartOfArray = 6;
	public const BinaryEntryType EndOfArray = 7;
	public const BinaryEntryType PrimitiveArray = 8;
	public const BinaryEntryType NamedInternalReference = 9;
	public const BinaryEntryType UnnamedInternalReference = 10;
	public const BinaryEntryType NamedExternalReferenceByIndex = 11;
	public const BinaryEntryType UnnamedExternalReferenceByIndex = 12;
	public const BinaryEntryType NamedExternalReferenceByGuid = 13;
	public const BinaryEntryType UnnamedExternalReferenceByGuid = 14;
	public const BinaryEntryType NamedSByte = 15;
	public const BinaryEntryType UnnamedSByte = 16;
	public const BinaryEntryType NamedByte = 17;
	public const BinaryEntryType UnnamedByte = 18;
	public const BinaryEntryType NamedShort = 19;
	public const BinaryEntryType UnnamedShort = 20;
	public const BinaryEntryType NamedUShort = 21;
	public const BinaryEntryType UnnamedUShort = 22;
	public const BinaryEntryType NamedInt = 23;
	public const BinaryEntryType UnnamedInt = 24;
	public const BinaryEntryType NamedUInt = 25;
	public const BinaryEntryType UnnamedUInt = 26;
	public const BinaryEntryType NamedLong = 27;
	public const BinaryEntryType UnnamedLong = 28;
	public const BinaryEntryType NamedULong = 29;
	public const BinaryEntryType UnnamedULong = 30;
	public const BinaryEntryType NamedFloat = 31;
	public const BinaryEntryType UnnamedFloat = 32;
	public const BinaryEntryType NamedDouble = 33;
	public const BinaryEntryType UnnamedDouble = 34;
	public const BinaryEntryType NamedDecimal = 35;
	public const BinaryEntryType UnnamedDecimal = 36;
	public const BinaryEntryType NamedChar = 37;
	public const BinaryEntryType UnnamedChar = 38;
	public const BinaryEntryType NamedString = 39;
	public const BinaryEntryType UnnamedString = 40;
	public const BinaryEntryType NamedGuid = 41;
	public const BinaryEntryType UnnamedGuid = 42;
	public const BinaryEntryType NamedBoolean = 43;
	public const BinaryEntryType UnnamedBoolean = 44;
	public const BinaryEntryType NamedNull = 45;
	public const BinaryEntryType UnnamedNull = 46;
	public const BinaryEntryType TypeName = 47;
	public const BinaryEntryType TypeID = 48;
	public const BinaryEntryType EndOfStream = 49;
	public const BinaryEntryType NamedExternalReferenceByString = 50;
	public const BinaryEntryType UnnamedExternalReferenceByString = 51;
}

// Namespace: Sirenix.Serialization
public interface IDataReader : IDisposable // TypeDefIndex: 22302
{
	// Properties
	public abstract TwoWaySerializationBinder Binder { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Data readers and writers don't necessarily have streams any longer, so this API has been made obsolete. Using this property may result in NotSupportedExceptions being thrown.", False)]
	public abstract Stream Stream { get; set; }
	public abstract bool IsInArrayNode { get; }
	public abstract string CurrentNodeName { get; }
	public abstract int CurrentNodeId { get; }
	public abstract int CurrentNodeDepth { get; }
	public abstract DeserializationContext Context { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TwoWaySerializationBinder get_Binder();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Binder(TwoWaySerializationBinder value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Stream get_Stream();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Stream(Stream value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsInArrayNode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_CurrentNodeName();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_CurrentNodeId();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_CurrentNodeDepth();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DeserializationContext get_Context();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_Context(DeserializationContext value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string GetDataDump();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool EnterNode(out Type type);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool ExitNode();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool EnterArray(out long length);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool ExitArray();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool ReadPrimitiveArray<T>(out T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDataReader.ReadPrimitiveArray<__Il2CppFullySharedGenericStructType>
	|-IDataReader.ReadPrimitiveArray<bool>
	|-IDataReader.ReadPrimitiveArray<byte>
	|-IDataReader.ReadPrimitiveArray<char>
	|-IDataReader.ReadPrimitiveArray<Decimal>
	|-IDataReader.ReadPrimitiveArray<double>
	|-IDataReader.ReadPrimitiveArray<Guid>
	|-IDataReader.ReadPrimitiveArray<short>
	|-IDataReader.ReadPrimitiveArray<int>
	|-IDataReader.ReadPrimitiveArray<long>
	|-IDataReader.ReadPrimitiveArray<sbyte>
	|-IDataReader.ReadPrimitiveArray<float>
	|-IDataReader.ReadPrimitiveArray<ushort>
	|-IDataReader.ReadPrimitiveArray<uint>
	|-IDataReader.ReadPrimitiveArray<ulong>
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public abstract EntryType PeekEntry(out string name);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool ReadInternalReference(out int id);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool ReadExternalReference(out int index);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool ReadExternalReference(out Guid guid);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool ReadExternalReference(out string id);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool ReadChar(out char value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool ReadString(out string value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool ReadGuid(out Guid value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract bool ReadSByte(out sbyte value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract bool ReadInt16(out short value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool ReadInt32(out int value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool ReadInt64(out long value);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool ReadByte(out byte value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool ReadUInt16(out ushort value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool ReadUInt32(out uint value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool ReadUInt64(out ulong value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool ReadDecimal(out Decimal value);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool ReadSingle(out float value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract bool ReadDouble(out double value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract bool ReadBoolean(out bool value);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract bool ReadNull();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SkipEntry();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void PrepareNewSerializationSession();
}

// Namespace: Sirenix.Serialization
public interface IDataWriter : IDisposable // TypeDefIndex: 22303
{
	// Properties
	public abstract TwoWaySerializationBinder Binder { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("Data readers and writers don't necessarily have streams any longer, so this API has been made obsolete. Using this property may result in NotSupportedExceptions being thrown.", False)]
	public abstract Stream Stream { get; set; }
	public abstract bool IsInArrayNode { get; }
	public abstract SerializationContext Context { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TwoWaySerializationBinder get_Binder();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Binder(TwoWaySerializationBinder value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Stream get_Stream();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Stream(Stream value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsInArrayNode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract SerializationContext get_Context();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_Context(SerializationContext value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string GetDataDump();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FlushToStream();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void BeginReferenceNode(string name, Type type, int id);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void BeginStructNode(string name, Type type);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void EndNode(string name);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void BeginArrayNode(long length);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void EndArrayNode();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void WritePrimitiveArray<T>(T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDataWriter.WritePrimitiveArray<__Il2CppFullySharedGenericStructType>
	|-IDataWriter.WritePrimitiveArray<bool>
	|-IDataWriter.WritePrimitiveArray<byte>
	|-IDataWriter.WritePrimitiveArray<char>
	|-IDataWriter.WritePrimitiveArray<Decimal>
	|-IDataWriter.WritePrimitiveArray<double>
	|-IDataWriter.WritePrimitiveArray<Guid>
	|-IDataWriter.WritePrimitiveArray<short>
	|-IDataWriter.WritePrimitiveArray<int>
	|-IDataWriter.WritePrimitiveArray<long>
	|-IDataWriter.WritePrimitiveArray<sbyte>
	|-IDataWriter.WritePrimitiveArray<float>
	|-IDataWriter.WritePrimitiveArray<ushort>
	|-IDataWriter.WritePrimitiveArray<uint>
	|-IDataWriter.WritePrimitiveArray<ulong>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void WriteNull(string name);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void WriteInternalReference(string name, int id);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteExternalReference(string name, int index);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void WriteExternalReference(string name, Guid guid);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void WriteExternalReference(string name, string id);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void WriteChar(string name, char value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void WriteString(string name, string value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void WriteGuid(string name, Guid value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WriteSByte(string name, sbyte value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteInt16(string name, short value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void WriteInt32(string name, int value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void WriteInt64(string name, long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void WriteByte(string name, byte value);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void WriteUInt16(string name, ushort value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void WriteUInt32(string name, uint value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void WriteUInt64(string name, ulong value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void WriteDecimal(string name, Decimal value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void WriteSingle(string name, float value);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void WriteDouble(string name, double value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void WriteBoolean(string name, bool value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void PrepareNewSerializationSession();
}

// Namespace: Sirenix.Serialization
public static class JsonConfig // TypeDefIndex: 22304
{
	// Fields
	public const string ID_SIG = "$id";
	public const string TYPE_SIG = "$type";
	public const string REGULAR_ARRAY_LENGTH_SIG = "$rlength";
	public const string PRIMITIVE_ARRAY_LENGTH_SIG = "$plength";
	public const string REGULAR_ARRAY_CONTENT_SIG = "$rcontent";
	public const string PRIMITIVE_ARRAY_CONTENT_SIG = "$pcontent";
	public const string INTERNAL_REF_SIG = "$iref";
	public const string EXTERNAL_INDEX_REF_SIG = "$eref";
	public const string EXTERNAL_GUID_REF_SIG = "$guidref";
	public const string EXTERNAL_STRING_REF_SIG_OLD = "$strref";
	public const string EXTERNAL_STRING_REF_SIG_FIXED = "$fstrref";
}

// Namespace: Sirenix.Serialization
public class JsonDataReader : BaseDataReader // TypeDefIndex: 22305
{
	// Fields
	private JsonTextReader reader; // 0x30
	private Nullable<EntryType> peekedEntryType; // 0x38
	private string peekedEntryName; // 0x40
	private string peekedEntryContent; // 0x48
	private Dictionary<int, Type> seenTypes; // 0x50
	private readonly Dictionary<Type, Delegate> primitiveArrayReaders; // 0x58

	// Properties
	public override Stream Stream { get; set; }

	// Methods

	// RVA: 0x7E94900 Offset: 0x7E90900 VA: 0x7E94900
	public void .ctor() { }

	// RVA: 0x7E9490C Offset: 0x7E9090C VA: 0x7E9490C
	public void .ctor(Stream stream, DeserializationContext context) { }

	// RVA: 0x7E9514C Offset: 0x7E9114C VA: 0x7E9514C Slot: 47
	public override Stream get_Stream() { }

	// RVA: 0x7E95154 Offset: 0x7E91154 VA: 0x7E95154 Slot: 48
	public override void set_Stream(Stream value) { }

	// RVA: 0x7E951E8 Offset: 0x7E911E8 VA: 0x7E951E8 Slot: 76
	public override void Dispose() { }

	// RVA: 0x7E95204 Offset: 0x7E91204 VA: 0x7E95204 Slot: 54
	public override EntryType PeekEntry(out string name) { }

	// RVA: 0x7E952F0 Offset: 0x7E912F0 VA: 0x7E952F0 Slot: 49
	public override bool EnterNode(out Type type) { }

	// RVA: 0x7E957EC Offset: 0x7E917EC VA: 0x7E957EC Slot: 50
	public override bool ExitNode() { }

	// RVA: 0x7E9592C Offset: 0x7E9192C VA: 0x7E9592C Slot: 51
	public override bool EnterArray(out long length) { }

	// RVA: 0x7E95B7C Offset: 0x7E91B7C VA: 0x7E95B7C Slot: 52
	public override bool ExitArray() { }

	// RVA: -1 Offset: -1 Slot: 53
	public override bool ReadPrimitiveArray<T>(out T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x464773C Offset: 0x464373C VA: 0x464773C
	|-JsonDataReader.ReadPrimitiveArray<bool>
	|
	|-RVA: 0x4647C00 Offset: 0x4643C00 VA: 0x4647C00
	|-JsonDataReader.ReadPrimitiveArray<byte>
	|
	|-RVA: 0x46480C0 Offset: 0x46440C0 VA: 0x46480C0
	|-JsonDataReader.ReadPrimitiveArray<char>
	|
	|-RVA: 0x464857C Offset: 0x464457C VA: 0x464857C
	|-JsonDataReader.ReadPrimitiveArray<Decimal>
	|
	|-RVA: 0x4648A40 Offset: 0x4644A40 VA: 0x4648A40
	|-JsonDataReader.ReadPrimitiveArray<double>
	|
	|-RVA: 0x4648EFC Offset: 0x4644EFC VA: 0x4648EFC
	|-JsonDataReader.ReadPrimitiveArray<Guid>
	|
	|-RVA: 0x46493C0 Offset: 0x46453C0 VA: 0x46493C0
	|-JsonDataReader.ReadPrimitiveArray<short>
	|
	|-RVA: 0x464987C Offset: 0x464587C VA: 0x464987C
	|-JsonDataReader.ReadPrimitiveArray<int>
	|
	|-RVA: 0x4649D38 Offset: 0x4645D38 VA: 0x4649D38
	|-JsonDataReader.ReadPrimitiveArray<long>
	|
	|-RVA: 0x464A1F4 Offset: 0x46461F4 VA: 0x464A1F4
	|-JsonDataReader.ReadPrimitiveArray<sbyte>
	|
	|-RVA: 0x464A6B4 Offset: 0x46466B4 VA: 0x464A6B4
	|-JsonDataReader.ReadPrimitiveArray<float>
	|
	|-RVA: 0x464AB70 Offset: 0x4646B70 VA: 0x464AB70
	|-JsonDataReader.ReadPrimitiveArray<ushort>
	|
	|-RVA: 0x464B02C Offset: 0x464702C VA: 0x464B02C
	|-JsonDataReader.ReadPrimitiveArray<uint>
	|
	|-RVA: 0x464B4E8 Offset: 0x46474E8 VA: 0x464B4E8
	|-JsonDataReader.ReadPrimitiveArray<ulong>
	|
	|-RVA: 0x464B9A4 Offset: 0x46479A4 VA: 0x464B9A4
	|-JsonDataReader.ReadPrimitiveArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7E95CA8 Offset: 0x7E91CA8 VA: 0x7E95CA8 Slot: 73
	public override bool ReadBoolean(out bool value) { }

	// RVA: 0x7E95DD8 Offset: 0x7E91DD8 VA: 0x7E95DD8 Slot: 55
	public override bool ReadInternalReference(out int id) { }

	// RVA: 0x7E960C8 Offset: 0x7E920C8 VA: 0x7E960C8 Slot: 56
	public override bool ReadExternalReference(out int index) { }

	// RVA: 0x7E961E0 Offset: 0x7E921E0 VA: 0x7E961E0 Slot: 57
	public override bool ReadExternalReference(out Guid guid) { }

	// RVA: 0x7E96464 Offset: 0x7E92464 VA: 0x7E96464 Slot: 58
	public override bool ReadExternalReference(out string id) { }

	// RVA: 0x7E96660 Offset: 0x7E92660 VA: 0x7E96660 Slot: 59
	public override bool ReadChar(out char value) { }

	// RVA: 0x7E96784 Offset: 0x7E92784 VA: 0x7E96784 Slot: 60
	public override bool ReadString(out string value) { }

	// RVA: 0x7E968C8 Offset: 0x7E928C8 VA: 0x7E968C8 Slot: 61
	public override bool ReadGuid(out Guid value) { }

	// RVA: 0x7E96ADC Offset: 0x7E92ADC VA: 0x7E96ADC Slot: 62
	public override bool ReadSByte(out sbyte value) { }

	// RVA: 0x7E96BEC Offset: 0x7E92BEC VA: 0x7E96BEC Slot: 63
	public override bool ReadInt16(out short value) { }

	// RVA: 0x7E96CFC Offset: 0x7E92CFC VA: 0x7E96CFC Slot: 64
	public override bool ReadInt32(out int value) { }

	// RVA: 0x7E96E10 Offset: 0x7E92E10 VA: 0x7E96E10 Slot: 65
	public override bool ReadInt64(out long value) { }

	// RVA: 0x7E96FE4 Offset: 0x7E92FE4 VA: 0x7E96FE4 Slot: 66
	public override bool ReadByte(out byte value) { }

	// RVA: 0x7E970F4 Offset: 0x7E930F4 VA: 0x7E970F4 Slot: 67
	public override bool ReadUInt16(out ushort value) { }

	// RVA: 0x7E97204 Offset: 0x7E93204 VA: 0x7E97204 Slot: 68
	public override bool ReadUInt32(out uint value) { }

	// RVA: 0x7E97314 Offset: 0x7E93314 VA: 0x7E97314 Slot: 69
	public override bool ReadUInt64(out ulong value) { }

	// RVA: 0x7E974E8 Offset: 0x7E934E8 VA: 0x7E974E8 Slot: 70
	public override bool ReadDecimal(out Decimal value) { }

	// RVA: 0x7E976F0 Offset: 0x7E936F0 VA: 0x7E976F0 Slot: 71
	public override bool ReadSingle(out float value) { }

	// RVA: 0x7E978CC Offset: 0x7E938CC VA: 0x7E978CC Slot: 72
	public override bool ReadDouble(out double value) { }

	// RVA: 0x7E97AA8 Offset: 0x7E93AA8 VA: 0x7E97AA8 Slot: 74
	public override bool ReadNull() { }

	// RVA: 0x7E97B48 Offset: 0x7E93B48 VA: 0x7E97B48 Slot: 77
	public override void PrepareNewSerializationSession() { }

	// RVA: 0x7E97BD4 Offset: 0x7E93BD4 VA: 0x7E97BD4 Slot: 78
	public override string GetDataDump() { }

	// RVA: 0x7E97DAC Offset: 0x7E93DAC VA: 0x7E97DAC Slot: 79
	protected override EntryType PeekEntry() { }

	// RVA: 0x7E97DD0 Offset: 0x7E93DD0 VA: 0x7E97DD0 Slot: 80
	protected override EntryType ReadToNextEntry() { }

	// RVA: 0x7E965F0 Offset: 0x7E925F0 VA: 0x7E965F0
	private void MarkEntryConsumed() { }

	// RVA: 0x7E95EF0 Offset: 0x7E91EF0 VA: 0x7E95EF0
	private bool ReadAnyIntReference(out int value) { }

	[CompilerGenerated]
	// RVA: 0x7E97DF8 Offset: 0x7E93DF8 VA: 0x7E97DF8
	private char <.ctor>b__7_0() { }

	[CompilerGenerated]
	// RVA: 0x7E97E20 Offset: 0x7E93E20 VA: 0x7E97E20
	private sbyte <.ctor>b__7_1() { }

	[CompilerGenerated]
	// RVA: 0x7E97E48 Offset: 0x7E93E48 VA: 0x7E97E48
	private short <.ctor>b__7_2() { }

	[CompilerGenerated]
	// RVA: 0x7E97E70 Offset: 0x7E93E70 VA: 0x7E97E70
	private int <.ctor>b__7_3() { }

	[CompilerGenerated]
	// RVA: 0x7E97E98 Offset: 0x7E93E98 VA: 0x7E97E98
	private long <.ctor>b__7_4() { }

	[CompilerGenerated]
	// RVA: 0x7E97EC0 Offset: 0x7E93EC0 VA: 0x7E97EC0
	private byte <.ctor>b__7_5() { }

	[CompilerGenerated]
	// RVA: 0x7E97EE8 Offset: 0x7E93EE8 VA: 0x7E97EE8
	private ushort <.ctor>b__7_6() { }

	[CompilerGenerated]
	// RVA: 0x7E97F10 Offset: 0x7E93F10 VA: 0x7E97F10
	private uint <.ctor>b__7_7() { }

	[CompilerGenerated]
	// RVA: 0x7E97F38 Offset: 0x7E93F38 VA: 0x7E97F38
	private ulong <.ctor>b__7_8() { }

	[CompilerGenerated]
	// RVA: 0x7E97F60 Offset: 0x7E93F60 VA: 0x7E97F60
	private Decimal <.ctor>b__7_9() { }

	[CompilerGenerated]
	// RVA: 0x7E97FB0 Offset: 0x7E93FB0 VA: 0x7E97FB0
	private bool <.ctor>b__7_10() { }

	[CompilerGenerated]
	// RVA: 0x7E97FD8 Offset: 0x7E93FD8 VA: 0x7E97FD8
	private float <.ctor>b__7_11() { }

	[CompilerGenerated]
	// RVA: 0x7E98000 Offset: 0x7E94000 VA: 0x7E98000
	private double <.ctor>b__7_12() { }

	[CompilerGenerated]
	// RVA: 0x7E98028 Offset: 0x7E94028 VA: 0x7E98028
	private Guid <.ctor>b__7_13() { }
}

// Namespace: Sirenix.Serialization
public class JsonDataWriter : BaseDataWriter // TypeDefIndex: 22306
{
	// Fields
	private static readonly uint[] ByteToHexCharLookup; // 0x0
	private static readonly string NEW_LINE; // 0x8
	private bool justStarted; // 0x30
	private bool forceNoSeparatorNextLine; // 0x31
	private Dictionary<Type, Delegate> primitiveTypeWriters; // 0x38
	private Dictionary<Type, int> seenTypes; // 0x40
	private byte[] buffer; // 0x48
	private int bufferIndex; // 0x50
	public bool FormatAsReadable; // 0x54
	public bool EnableTypeOptimization; // 0x55

	// Methods

	// RVA: 0x7E98D94 Offset: 0x7E94D94 VA: 0x7E98D94
	public void .ctor() { }

	// RVA: 0x7E98DA4 Offset: 0x7E94DA4 VA: 0x7E98DA4
	public void .ctor(Stream stream, SerializationContext context, bool formatAsReadable = True) { }

	// RVA: 0x7E99554 Offset: 0x7E95554 VA: 0x7E99554
	public void MarkJustStarted() { }

	// RVA: 0x7E99560 Offset: 0x7E95560 VA: 0x7E99560 Slot: 46
	public override void FlushToStream() { }

	// RVA: 0x7E995C0 Offset: 0x7E955C0 VA: 0x7E995C0 Slot: 47
	public override void BeginReferenceNode(string name, Type type, int id) { }

	// RVA: 0x7E99AD0 Offset: 0x7E95AD0 VA: 0x7E99AD0 Slot: 48
	public override void BeginStructNode(string name, Type type) { }

	// RVA: 0x7E99BAC Offset: 0x7E95BAC VA: 0x7E99BAC Slot: 49
	public override void EndNode(string name) { }

	// RVA: 0x7E99E5C Offset: 0x7E95E5C VA: 0x7E99E5C Slot: 50
	public override void BeginArrayNode(long length) { }

	// RVA: 0x7E99F14 Offset: 0x7E95F14 VA: 0x7E99F14 Slot: 51
	public override void EndArrayNode() { }

	// RVA: -1 Offset: -1 Slot: 52
	public override void WritePrimitiveArray<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x464BF20 Offset: 0x4647F20 VA: 0x464BF20
	|-JsonDataWriter.WritePrimitiveArray<bool>
	|
	|-RVA: 0x464C278 Offset: 0x4648278 VA: 0x464C278
	|-JsonDataWriter.WritePrimitiveArray<byte>
	|
	|-RVA: 0x464C5D0 Offset: 0x46485D0 VA: 0x464C5D0
	|-JsonDataWriter.WritePrimitiveArray<char>
	|
	|-RVA: 0x464C928 Offset: 0x4648928 VA: 0x464C928
	|-JsonDataWriter.WritePrimitiveArray<Decimal>
	|
	|-RVA: 0x464CC84 Offset: 0x4648C84 VA: 0x464CC84
	|-JsonDataWriter.WritePrimitiveArray<double>
	|
	|-RVA: 0x464CFDC Offset: 0x4648FDC VA: 0x464CFDC
	|-JsonDataWriter.WritePrimitiveArray<Guid>
	|
	|-RVA: 0x464D338 Offset: 0x4649338 VA: 0x464D338
	|-JsonDataWriter.WritePrimitiveArray<short>
	|
	|-RVA: 0x464D690 Offset: 0x4649690 VA: 0x464D690
	|-JsonDataWriter.WritePrimitiveArray<int>
	|
	|-RVA: 0x464D9E8 Offset: 0x46499E8 VA: 0x464D9E8
	|-JsonDataWriter.WritePrimitiveArray<long>
	|
	|-RVA: 0x464DD40 Offset: 0x4649D40 VA: 0x464DD40
	|-JsonDataWriter.WritePrimitiveArray<sbyte>
	|
	|-RVA: 0x464E098 Offset: 0x464A098 VA: 0x464E098
	|-JsonDataWriter.WritePrimitiveArray<float>
	|
	|-RVA: 0x464E3F0 Offset: 0x464A3F0 VA: 0x464E3F0
	|-JsonDataWriter.WritePrimitiveArray<ushort>
	|
	|-RVA: 0x464E748 Offset: 0x464A748 VA: 0x464E748
	|-JsonDataWriter.WritePrimitiveArray<uint>
	|
	|-RVA: 0x464EAA0 Offset: 0x464AAA0 VA: 0x464EAA0
	|-JsonDataWriter.WritePrimitiveArray<ulong>
	|
	|-RVA: 0x464EDF8 Offset: 0x464ADF8 VA: 0x464EDF8
	|-JsonDataWriter.WritePrimitiveArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7E99F78 Offset: 0x7E95F78 VA: 0x7E99F78 Slot: 72
	public override void WriteBoolean(string name, bool value) { }

	// RVA: 0x7E99FF8 Offset: 0x7E95FF8 VA: 0x7E99FF8 Slot: 65
	public override void WriteByte(string name, byte value) { }

	// RVA: 0x7E9A00C Offset: 0x7E9600C VA: 0x7E9A00C Slot: 58
	public override void WriteChar(string name, char value) { }

	// RVA: 0x7E9A0CC Offset: 0x7E960CC VA: 0x7E9A0CC Slot: 69
	public override void WriteDecimal(string name, Decimal value) { }

	// RVA: 0x7E9A1C0 Offset: 0x7E961C0 VA: 0x7E9A1C0 Slot: 71
	public override void WriteDouble(string name, double value) { }

	// RVA: 0x7E9A260 Offset: 0x7E96260 VA: 0x7E9A260 Slot: 63
	public override void WriteInt32(string name, int value) { }

	// RVA: 0x7E9A274 Offset: 0x7E96274 VA: 0x7E9A274 Slot: 64
	public override void WriteInt64(string name, long value) { }

	// RVA: 0x7E9A314 Offset: 0x7E96314 VA: 0x7E9A314 Slot: 53
	public override void WriteNull(string name) { }

	// RVA: 0x7E9A36C Offset: 0x7E9636C VA: 0x7E9A36C Slot: 54
	public override void WriteInternalReference(string name, int id) { }

	// RVA: 0x7E9A434 Offset: 0x7E96434 VA: 0x7E9A434 Slot: 61
	public override void WriteSByte(string name, sbyte value) { }

	// RVA: 0x7E9A448 Offset: 0x7E96448 VA: 0x7E9A448 Slot: 62
	public override void WriteInt16(string name, short value) { }

	// RVA: 0x7E9A45C Offset: 0x7E9645C VA: 0x7E9A45C Slot: 70
	public override void WriteSingle(string name, float value) { }

	// RVA: 0x7E9A4FC Offset: 0x7E964FC VA: 0x7E9A4FC Slot: 59
	public override void WriteString(string name, string value) { }

	// RVA: 0x7E9AC68 Offset: 0x7E96C68 VA: 0x7E9AC68 Slot: 60
	public override void WriteGuid(string name, Guid value) { }

	// RVA: 0x7E9AD10 Offset: 0x7E96D10 VA: 0x7E9AD10 Slot: 67
	public override void WriteUInt32(string name, uint value) { }

	// RVA: 0x7E9AD24 Offset: 0x7E96D24 VA: 0x7E9AD24 Slot: 68
	public override void WriteUInt64(string name, ulong value) { }

	// RVA: 0x7E9ADC4 Offset: 0x7E96DC4 VA: 0x7E9ADC4 Slot: 55
	public override void WriteExternalReference(string name, int index) { }

	// RVA: 0x7E9AE8C Offset: 0x7E96E8C VA: 0x7E9AE8C Slot: 56
	public override void WriteExternalReference(string name, Guid guid) { }

	// RVA: 0x7E9AF5C Offset: 0x7E96F5C VA: 0x7E9AF5C Slot: 57
	public override void WriteExternalReference(string name, string id) { }

	// RVA: 0x7E9B0B0 Offset: 0x7E970B0 VA: 0x7E9B0B0 Slot: 66
	public override void WriteUInt16(string name, ushort value) { }

	// RVA: 0x7E9B0C4 Offset: 0x7E970C4 VA: 0x7E9B0C4 Slot: 73
	public override void Dispose() { }

	// RVA: 0x7E9B0C8 Offset: 0x7E970C8 VA: 0x7E9B0C8 Slot: 74
	public override void PrepareNewSerializationSession() { }

	// RVA: 0x7E9B130 Offset: 0x7E97130 VA: 0x7E9B130 Slot: 75
	public override string GetDataDump() { }

	// RVA: 0x7E996DC Offset: 0x7E956DC VA: 0x7E996DC
	private void WriteEntry(string name, string contents) { }

	// RVA: 0x7E9B324 Offset: 0x7E97324 VA: 0x7E9B324
	private void WriteEntry(string name, string contents, char surroundContentsWith) { }

	// RVA: 0x7E998B8 Offset: 0x7E958B8 VA: 0x7E998B8
	private void WriteTypeEntry(Type type) { }

	// RVA: 0x7E99C10 Offset: 0x7E95C10 VA: 0x7E99C10
	private void StartNewLine(bool noSeparator = False) { }

	// RVA: 0x7E99DCC Offset: 0x7E95DCC VA: 0x7E99DCC
	private void EnsureBufferSpace(int space) { }

	// RVA: 0x7E9A6E8 Offset: 0x7E966E8 VA: 0x7E9A6E8
	private void Buffer_WriteString_WithEscape(string str) { }

	// RVA: 0x7E9B55C Offset: 0x7E9755C VA: 0x7E9B55C
	private static uint[] CreateByteToHexLookup() { }

	// RVA: 0x7E9B678 Offset: 0x7E97678 VA: 0x7E9B678
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class JsonTextReader : IDisposable // TypeDefIndex: 22307
{
	// Fields
	private static readonly Dictionary<char, Nullable<EntryType>> EntryDelineators; // 0x0
	private static readonly Dictionary<char, char> UnescapeDictionary; // 0x8
	private StreamReader reader; // 0x10
	private int bufferIndex; // 0x18
	private char[] buffer; // 0x20
	private Nullable<char> lastReadChar; // 0x28
	private Nullable<char> peekedChar; // 0x2C
	private Queue<char> emergencyPlayback; // 0x30
	[CompilerGenerated]
	private DeserializationContext <Context>k__BackingField; // 0x38

	// Properties
	public DeserializationContext Context { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7E9B6F0 Offset: 0x7E976F0 VA: 0x7E9B6F0
	public DeserializationContext get_Context() { }

	[CompilerGenerated]
	// RVA: 0x7E9B6F8 Offset: 0x7E976F8 VA: 0x7E9B6F8
	private void set_Context(DeserializationContext value) { }

	// RVA: 0x7E9B700 Offset: 0x7E97700 VA: 0x7E9B700
	public void .ctor(Stream stream, DeserializationContext context) { }

	// RVA: 0x7E9B878 Offset: 0x7E97878 VA: 0x7E9B878
	public void Reset() { }

	// RVA: 0x7E9B8D4 Offset: 0x7E978D4 VA: 0x7E9B8D4 Slot: 4
	public void Dispose() { }

	// RVA: 0x7E9B8D8 Offset: 0x7E978D8 VA: 0x7E9B8D8
	public void ReadToNextEntry(out string name, out string valueContent, out EntryType entry) { }

	// RVA: 0x7E9C8E4 Offset: 0x7E988E4 VA: 0x7E9C8E4
	private void ParseEntryFromBuffer(out string name, out string valueContent, out EntryType entry, int valueSeparatorIndex, Nullable<EntryType> hintEntry) { }

	// RVA: 0x7E9C648 Offset: 0x7E98648 VA: 0x7E9C648
	private bool IsHex(char c) { }

	// RVA: 0x7E9D25C Offset: 0x7E9925C VA: 0x7E9D25C
	private uint ParseSingleChar(char c, uint multiplier) { }

	// RVA: 0x7E9C684 Offset: 0x7E98684 VA: 0x7E9C684
	private char ParseHexChar(char c1, char c2, char c3, char c4) { }

	// RVA: 0x7E9C7C4 Offset: 0x7E987C4 VA: 0x7E9C7C4
	private char ReadCharIntoBuffer() { }

	// RVA: 0x7E9D06C Offset: 0x7E9906C VA: 0x7E9D06C
	private Nullable<EntryType> GuessPrimitiveType(string content) { }

	// RVA: 0x7E9C3CC Offset: 0x7E983CC VA: 0x7E9C3CC
	private char PeekChar() { }

	// RVA: 0x7E9C4D8 Offset: 0x7E984D8 VA: 0x7E9C4D8
	private void SkipChar() { }

	// RVA: 0x7E9C580 Offset: 0x7E98580 VA: 0x7E9C580
	private char ConsumeChar() { }

	// RVA: 0x7E9D2B4 Offset: 0x7E992B4 VA: 0x7E9D2B4
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
[Serializable]
public struct SerializationNode // TypeDefIndex: 22308
{
	// Fields
	public string Name; // 0x0
	public EntryType Entry; // 0x8
	public string Data; // 0x10
}

// Namespace: Sirenix.Serialization
public class SerializationNodeDataReader : BaseDataReader // TypeDefIndex: 22309
{
	// Fields
	private string peekedEntryName; // 0x30
	private Nullable<EntryType> peekedEntryType; // 0x38
	private string peekedEntryData; // 0x40
	private int currentIndex; // 0x48
	private List<SerializationNode> nodes; // 0x50
	private Dictionary<Type, Delegate> primitiveTypeReaders; // 0x58

	// Properties
	private bool IndexIsValid { get; }
	public List<SerializationNode> Nodes { get; set; }
	public override Stream Stream { get; set; }

	// Methods

	// RVA: 0x7E9D538 Offset: 0x7E99538 VA: 0x7E9D538
	public void .ctor(DeserializationContext context) { }

	// RVA: 0x7E9DD30 Offset: 0x7E99D30 VA: 0x7E9DD30
	private bool get_IndexIsValid() { }

	// RVA: 0x7E9DD8C Offset: 0x7E99D8C VA: 0x7E9DD8C
	public List<SerializationNode> get_Nodes() { }

	// RVA: 0x7E9DE10 Offset: 0x7E99E10 VA: 0x7E9DE10
	public void set_Nodes(List<SerializationNode> value) { }

	// RVA: 0x7E9DE58 Offset: 0x7E99E58 VA: 0x7E9DE58 Slot: 47
	public override Stream get_Stream() { }

	// RVA: 0x7E9DEA4 Offset: 0x7E99EA4 VA: 0x7E9DEA4 Slot: 48
	public override void set_Stream(Stream value) { }

	// RVA: 0x7E9DEF0 Offset: 0x7E99EF0 VA: 0x7E9DEF0 Slot: 76
	public override void Dispose() { }

	// RVA: 0x7E9DF18 Offset: 0x7E99F18 VA: 0x7E9DF18 Slot: 77
	public override void PrepareNewSerializationSession() { }

	// RVA: 0x7E9DF38 Offset: 0x7E99F38 VA: 0x7E9DF38 Slot: 54
	public override EntryType PeekEntry(out string name) { }

	// RVA: 0x7E9E0D8 Offset: 0x7E9A0D8 VA: 0x7E9E0D8 Slot: 51
	public override bool EnterArray(out long length) { }

	// RVA: 0x7E9E2CC Offset: 0x7E9A2CC VA: 0x7E9E2CC Slot: 49
	public override bool EnterNode(out Type type) { }

	// RVA: 0x7E9E688 Offset: 0x7E9A688 VA: 0x7E9E688 Slot: 52
	public override bool ExitArray() { }

	// RVA: 0x7E9E7C4 Offset: 0x7E9A7C4 VA: 0x7E9E7C4 Slot: 50
	public override bool ExitNode() { }

	// RVA: 0x7E9E910 Offset: 0x7E9A910 VA: 0x7E9E910 Slot: 73
	public override bool ReadBoolean(out bool value) { }

	// RVA: 0x7E9EA34 Offset: 0x7E9AA34 VA: 0x7E9EA34 Slot: 66
	public override bool ReadByte(out byte value) { }

	// RVA: 0x7E9EB44 Offset: 0x7E9AB44 VA: 0x7E9EB44 Slot: 59
	public override bool ReadChar(out char value) { }

	// RVA: 0x7E9ECE4 Offset: 0x7E9ACE4 VA: 0x7E9ECE4 Slot: 70
	public override bool ReadDecimal(out Decimal value) { }

	// RVA: 0x7E9EF08 Offset: 0x7E9AF08 VA: 0x7E9EF08 Slot: 72
	public override bool ReadDouble(out double value) { }

	// RVA: 0x7E9F100 Offset: 0x7E9B100 VA: 0x7E9F100 Slot: 57
	public override bool ReadExternalReference(out Guid guid) { }

	// RVA: 0x7E9F364 Offset: 0x7E9B364 VA: 0x7E9F364 Slot: 58
	public override bool ReadExternalReference(out string id) { }

	// RVA: 0x7E9F428 Offset: 0x7E9B428 VA: 0x7E9F428 Slot: 56
	public override bool ReadExternalReference(out int index) { }

	// RVA: 0x7E9F618 Offset: 0x7E9B618 VA: 0x7E9F618 Slot: 61
	public override bool ReadGuid(out Guid value) { }

	// RVA: 0x7E9F87C Offset: 0x7E9B87C VA: 0x7E9F87C Slot: 63
	public override bool ReadInt16(out short value) { }

	// RVA: 0x7E9F98C Offset: 0x7E9B98C VA: 0x7E9F98C Slot: 64
	public override bool ReadInt32(out int value) { }

	// RVA: 0x7E9FAA0 Offset: 0x7E9BAA0 VA: 0x7E9FAA0 Slot: 65
	public override bool ReadInt64(out long value) { }

	// RVA: 0x7E9FC90 Offset: 0x7E9BC90 VA: 0x7E9FC90 Slot: 55
	public override bool ReadInternalReference(out int id) { }

	// RVA: 0x7E9FE80 Offset: 0x7E9BE80 VA: 0x7E9FE80 Slot: 74
	public override bool ReadNull() { }

	// RVA: -1 Offset: -1 Slot: 53
	public override bool ReadPrimitiveArray<T>(out T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E14B0 Offset: 0x46DD4B0 VA: 0x46E14B0
	|-SerializationNodeDataReader.ReadPrimitiveArray<bool>
	|
	|-RVA: 0x46E1BD0 Offset: 0x46DDBD0 VA: 0x46E1BD0
	|-SerializationNodeDataReader.ReadPrimitiveArray<byte>
	|
	|-RVA: 0x46E22EC Offset: 0x46DE2EC VA: 0x46E22EC
	|-SerializationNodeDataReader.ReadPrimitiveArray<char>
	|
	|-RVA: 0x46E2A08 Offset: 0x46DEA08 VA: 0x46E2A08
	|-SerializationNodeDataReader.ReadPrimitiveArray<Decimal>
	|
	|-RVA: 0x46E3124 Offset: 0x46DF124 VA: 0x46E3124
	|-SerializationNodeDataReader.ReadPrimitiveArray<double>
	|
	|-RVA: 0x46E3840 Offset: 0x46DF840 VA: 0x46E3840
	|-SerializationNodeDataReader.ReadPrimitiveArray<Guid>
	|
	|-RVA: 0x46E3F5C Offset: 0x46DFF5C VA: 0x46E3F5C
	|-SerializationNodeDataReader.ReadPrimitiveArray<short>
	|
	|-RVA: 0x46E4678 Offset: 0x46E0678 VA: 0x46E4678
	|-SerializationNodeDataReader.ReadPrimitiveArray<int>
	|
	|-RVA: 0x46E4D94 Offset: 0x46E0D94 VA: 0x46E4D94
	|-SerializationNodeDataReader.ReadPrimitiveArray<long>
	|
	|-RVA: 0x46E54B0 Offset: 0x46E14B0 VA: 0x46E54B0
	|-SerializationNodeDataReader.ReadPrimitiveArray<sbyte>
	|
	|-RVA: 0x46E5BCC Offset: 0x46E1BCC VA: 0x46E5BCC
	|-SerializationNodeDataReader.ReadPrimitiveArray<float>
	|
	|-RVA: 0x46E62E8 Offset: 0x46E22E8 VA: 0x46E62E8
	|-SerializationNodeDataReader.ReadPrimitiveArray<ushort>
	|
	|-RVA: 0x46E6A04 Offset: 0x46E2A04 VA: 0x46E6A04
	|-SerializationNodeDataReader.ReadPrimitiveArray<uint>
	|
	|-RVA: 0x46E7120 Offset: 0x46E3120 VA: 0x46E7120
	|-SerializationNodeDataReader.ReadPrimitiveArray<ulong>
	|
	|-RVA: 0x46E783C Offset: 0x46E383C VA: 0x46E783C
	|-SerializationNodeDataReader.ReadPrimitiveArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7E9FF20 Offset: 0x7E9BF20 VA: 0x7E9FF20 Slot: 62
	public override bool ReadSByte(out sbyte value) { }

	// RVA: 0x7EA0030 Offset: 0x7E9C030 VA: 0x7EA0030 Slot: 71
	public override bool ReadSingle(out float value) { }

	// RVA: 0x7EA0228 Offset: 0x7E9C228 VA: 0x7EA0228 Slot: 60
	public override bool ReadString(out string value) { }

	// RVA: 0x7EA02EC Offset: 0x7E9C2EC VA: 0x7EA02EC Slot: 67
	public override bool ReadUInt16(out ushort value) { }

	// RVA: 0x7EA03FC Offset: 0x7E9C3FC VA: 0x7EA03FC Slot: 68
	public override bool ReadUInt32(out uint value) { }

	// RVA: 0x7EA050C Offset: 0x7E9C50C VA: 0x7EA050C Slot: 69
	public override bool ReadUInt64(out ulong value) { }

	// RVA: 0x7EA06FC Offset: 0x7E9C6FC VA: 0x7EA06FC Slot: 78
	public override string GetDataDump() { }

	// RVA: 0x7E9E264 Offset: 0x7E9A264 VA: 0x7E9E264
	private void ConsumeCurrentEntry() { }

	// RVA: 0x7EA0904 Offset: 0x7E9C904 VA: 0x7EA0904 Slot: 79
	protected override EntryType PeekEntry() { }

	// RVA: 0x7EA0928 Offset: 0x7E9C928 VA: 0x7EA0928 Slot: 80
	protected override EntryType ReadToNextEntry() { }

	[CompilerGenerated]
	// RVA: 0x7EA0960 Offset: 0x7E9C960 VA: 0x7EA0960
	private char <.ctor>b__6_0() { }

	[CompilerGenerated]
	// RVA: 0x7EA0988 Offset: 0x7E9C988 VA: 0x7EA0988
	private sbyte <.ctor>b__6_1() { }

	[CompilerGenerated]
	// RVA: 0x7EA09B0 Offset: 0x7E9C9B0 VA: 0x7EA09B0
	private short <.ctor>b__6_2() { }

	[CompilerGenerated]
	// RVA: 0x7EA09D8 Offset: 0x7E9C9D8 VA: 0x7EA09D8
	private int <.ctor>b__6_3() { }

	[CompilerGenerated]
	// RVA: 0x7EA0A00 Offset: 0x7E9CA00 VA: 0x7EA0A00
	private long <.ctor>b__6_4() { }

	[CompilerGenerated]
	// RVA: 0x7EA0A28 Offset: 0x7E9CA28 VA: 0x7EA0A28
	private byte <.ctor>b__6_5() { }

	[CompilerGenerated]
	// RVA: 0x7EA0A50 Offset: 0x7E9CA50 VA: 0x7EA0A50
	private ushort <.ctor>b__6_6() { }

	[CompilerGenerated]
	// RVA: 0x7EA0A78 Offset: 0x7E9CA78 VA: 0x7EA0A78
	private uint <.ctor>b__6_7() { }

	[CompilerGenerated]
	// RVA: 0x7EA0AA0 Offset: 0x7E9CAA0 VA: 0x7EA0AA0
	private ulong <.ctor>b__6_8() { }

	[CompilerGenerated]
	// RVA: 0x7EA0AC8 Offset: 0x7E9CAC8 VA: 0x7EA0AC8
	private Decimal <.ctor>b__6_9() { }

	[CompilerGenerated]
	// RVA: 0x7EA0B18 Offset: 0x7E9CB18 VA: 0x7EA0B18
	private bool <.ctor>b__6_10() { }

	[CompilerGenerated]
	// RVA: 0x7EA0B40 Offset: 0x7E9CB40 VA: 0x7EA0B40
	private float <.ctor>b__6_11() { }

	[CompilerGenerated]
	// RVA: 0x7EA0B68 Offset: 0x7E9CB68 VA: 0x7EA0B68
	private double <.ctor>b__6_12() { }

	[CompilerGenerated]
	// RVA: 0x7EA0B90 Offset: 0x7E9CB90 VA: 0x7EA0B90
	private Guid <.ctor>b__6_13() { }
}

// Namespace: Sirenix.Serialization
public static class SerializationNodeDataReaderWriterConfig // TypeDefIndex: 22310
{
	// Fields
	public const string NodeIdSeparator = "|";
}

// Namespace: Sirenix.Serialization
public class SerializationNodeDataWriter : BaseDataWriter // TypeDefIndex: 22311
{
	// Fields
	private List<SerializationNode> nodes; // 0x30
	private Dictionary<Type, Delegate> primitiveTypeWriters; // 0x38

	// Properties
	public List<SerializationNode> Nodes { get; set; }
	public override Stream Stream { get; set; }

	// Methods

	// RVA: 0x7EA0BC0 Offset: 0x7E9CBC0 VA: 0x7EA0BC0
	public List<SerializationNode> get_Nodes() { }

	// RVA: 0x7EA0C44 Offset: 0x7E9CC44 VA: 0x7EA0C44
	public void set_Nodes(List<SerializationNode> value) { }

	// RVA: 0x7EA0C8C Offset: 0x7E9CC8C VA: 0x7EA0C8C
	public void .ctor(SerializationContext context) { }

	// RVA: 0x7EA13A0 Offset: 0x7E9D3A0 VA: 0x7EA13A0 Slot: 44
	public override Stream get_Stream() { }

	// RVA: 0x7EA13EC Offset: 0x7E9D3EC VA: 0x7EA13EC Slot: 45
	public override void set_Stream(Stream value) { }

	// RVA: 0x7EA1438 Offset: 0x7E9D438 VA: 0x7EA1438 Slot: 50
	public override void BeginArrayNode(long length) { }

	// RVA: 0x7EA15D4 Offset: 0x7E9D5D4 VA: 0x7EA15D4 Slot: 47
	public override void BeginReferenceNode(string name, Type type, int id) { }

	// RVA: 0x7EA183C Offset: 0x7E9D83C VA: 0x7EA183C Slot: 48
	public override void BeginStructNode(string name, Type type) { }

	// RVA: 0x7EA1A48 Offset: 0x7E9DA48 VA: 0x7EA1A48 Slot: 73
	public override void Dispose() { }

	// RVA: 0x7EA1A54 Offset: 0x7E9DA54 VA: 0x7EA1A54 Slot: 51
	public override void EndArrayNode() { }

	// RVA: 0x7EA1BB8 Offset: 0x7E9DBB8 VA: 0x7EA1BB8 Slot: 49
	public override void EndNode(string name) { }

	// RVA: 0x7EA1D2C Offset: 0x7E9DD2C VA: 0x7EA1D2C Slot: 74
	public override void PrepareNewSerializationSession() { }

	// RVA: 0x7EA1D34 Offset: 0x7E9DD34 VA: 0x7EA1D34 Slot: 72
	public override void WriteBoolean(string name, bool value) { }

	// RVA: 0x7EA1EA8 Offset: 0x7E9DEA8 VA: 0x7EA1EA8 Slot: 65
	public override void WriteByte(string name, byte value) { }

	// RVA: 0x7EA2038 Offset: 0x7E9E038 VA: 0x7EA2038 Slot: 58
	public override void WriteChar(string name, char value) { }

	// RVA: 0x7EA21DC Offset: 0x7E9E1DC VA: 0x7EA21DC Slot: 69
	public override void WriteDecimal(string name, Decimal value) { }

	// RVA: 0x7EA23B8 Offset: 0x7E9E3B8 VA: 0x7EA23B8 Slot: 70
	public override void WriteSingle(string name, float value) { }

	// RVA: 0x7EA2548 Offset: 0x7E9E548 VA: 0x7EA2548 Slot: 71
	public override void WriteDouble(string name, double value) { }

	// RVA: 0x7EA26D8 Offset: 0x7E9E6D8 VA: 0x7EA26D8 Slot: 56
	public override void WriteExternalReference(string name, Guid guid) { }

	// RVA: 0x7EA2868 Offset: 0x7E9E868 VA: 0x7EA2868 Slot: 57
	public override void WriteExternalReference(string name, string id) { }

	// RVA: 0x7EA29A4 Offset: 0x7E9E9A4 VA: 0x7EA29A4 Slot: 55
	public override void WriteExternalReference(string name, int index) { }

	// RVA: 0x7EA2B34 Offset: 0x7E9EB34 VA: 0x7EA2B34 Slot: 60
	public override void WriteGuid(string name, Guid value) { }

	// RVA: 0x7EA2CC4 Offset: 0x7E9ECC4 VA: 0x7EA2CC4 Slot: 62
	public override void WriteInt16(string name, short value) { }

	// RVA: 0x7EA2E54 Offset: 0x7E9EE54 VA: 0x7EA2E54 Slot: 63
	public override void WriteInt32(string name, int value) { }

	// RVA: 0x7EA2FE4 Offset: 0x7E9EFE4 VA: 0x7EA2FE4 Slot: 64
	public override void WriteInt64(string name, long value) { }

	// RVA: 0x7EA3174 Offset: 0x7E9F174 VA: 0x7EA3174 Slot: 54
	public override void WriteInternalReference(string name, int id) { }

	// RVA: 0x7EA3304 Offset: 0x7E9F304 VA: 0x7EA3304 Slot: 53
	public override void WriteNull(string name) { }

	// RVA: -1 Offset: -1 Slot: 52
	public override void WritePrimitiveArray<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46E801C Offset: 0x46E401C VA: 0x46E801C
	|-SerializationNodeDataWriter.WritePrimitiveArray<bool>
	|
	|-RVA: 0x46E85DC Offset: 0x46E45DC VA: 0x46E85DC
	|-SerializationNodeDataWriter.WritePrimitiveArray<byte>
	|
	|-RVA: 0x46E8B9C Offset: 0x46E4B9C VA: 0x46E8B9C
	|-SerializationNodeDataWriter.WritePrimitiveArray<char>
	|
	|-RVA: 0x46E915C Offset: 0x46E515C VA: 0x46E915C
	|-SerializationNodeDataWriter.WritePrimitiveArray<Decimal>
	|
	|-RVA: 0x46E9720 Offset: 0x46E5720 VA: 0x46E9720
	|-SerializationNodeDataWriter.WritePrimitiveArray<double>
	|
	|-RVA: 0x46E9CE0 Offset: 0x46E5CE0 VA: 0x46E9CE0
	|-SerializationNodeDataWriter.WritePrimitiveArray<Guid>
	|
	|-RVA: 0x46EA2A4 Offset: 0x46E62A4 VA: 0x46EA2A4
	|-SerializationNodeDataWriter.WritePrimitiveArray<short>
	|
	|-RVA: 0x46EA864 Offset: 0x46E6864 VA: 0x46EA864
	|-SerializationNodeDataWriter.WritePrimitiveArray<int>
	|
	|-RVA: 0x46EAE24 Offset: 0x46E6E24 VA: 0x46EAE24
	|-SerializationNodeDataWriter.WritePrimitiveArray<long>
	|
	|-RVA: 0x46EB3E4 Offset: 0x46E73E4 VA: 0x46EB3E4
	|-SerializationNodeDataWriter.WritePrimitiveArray<sbyte>
	|
	|-RVA: 0x46EB9A4 Offset: 0x46E79A4 VA: 0x46EB9A4
	|-SerializationNodeDataWriter.WritePrimitiveArray<float>
	|
	|-RVA: 0x46EBF64 Offset: 0x46E7F64 VA: 0x46EBF64
	|-SerializationNodeDataWriter.WritePrimitiveArray<ushort>
	|
	|-RVA: 0x46EC524 Offset: 0x46E8524 VA: 0x46EC524
	|-SerializationNodeDataWriter.WritePrimitiveArray<uint>
	|
	|-RVA: 0x46ECAE4 Offset: 0x46E8AE4 VA: 0x46ECAE4
	|-SerializationNodeDataWriter.WritePrimitiveArray<ulong>
	|
	|-RVA: 0x46ED0A4 Offset: 0x46E90A4 VA: 0x46ED0A4
	|-SerializationNodeDataWriter.WritePrimitiveArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7EA3458 Offset: 0x7E9F458 VA: 0x7EA3458 Slot: 61
	public override void WriteSByte(string name, sbyte value) { }

	// RVA: 0x7EA35E8 Offset: 0x7E9F5E8 VA: 0x7EA35E8 Slot: 59
	public override void WriteString(string name, string value) { }

	// RVA: 0x7EA3724 Offset: 0x7E9F724 VA: 0x7EA3724 Slot: 66
	public override void WriteUInt16(string name, ushort value) { }

	// RVA: 0x7EA38B4 Offset: 0x7E9F8B4 VA: 0x7EA38B4 Slot: 67
	public override void WriteUInt32(string name, uint value) { }

	// RVA: 0x7EA3A44 Offset: 0x7E9FA44 VA: 0x7EA3A44 Slot: 68
	public override void WriteUInt64(string name, ulong value) { }

	// RVA: 0x7EA3BD4 Offset: 0x7E9FBD4 VA: 0x7EA3BD4 Slot: 46
	public override void FlushToStream() { }

	// RVA: 0x7EA3BD8 Offset: 0x7E9FBD8 VA: 0x7EA3BD8 Slot: 75
	public override string GetDataDump() { }
}

// Namespace: Sirenix.Serialization
internal class ArrayFormatterLocator : IFormatterLocator // TypeDefIndex: 22312
{
	// Methods

	// RVA: 0x7EA3D98 Offset: 0x7E9FD98 VA: 0x7EA3D98 Slot: 4
	public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

	// RVA: 0x7EA4804 Offset: 0x7EA0804 VA: 0x7EA4804
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
internal class DelegateFormatterLocator : IFormatterLocator // TypeDefIndex: 22313
{
	// Methods

	// RVA: 0x7EA480C Offset: 0x7EA080C VA: 0x7EA480C Slot: 4
	public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

	// RVA: 0x7EA4B98 Offset: 0x7EA0B98 VA: 0x7EA4B98
	public void .ctor() { }
}

// Namespace: 
private struct FormatterLocator.FormatterInfo // TypeDefIndex: 22314
{
	// Fields
	public Type FormatterType; // 0x0
	public Type TargetType; // 0x8
	public Type WeakFallbackType; // 0x10
	public bool AskIfCanFormatTypes; // 0x18
	public int Priority; // 0x1C
}

// Namespace: 
private struct FormatterLocator.FormatterLocatorInfo // TypeDefIndex: 22315
{
	// Fields
	public IFormatterLocator LocatorInstance; // 0x0
	public int Priority; // 0x8
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FormatterLocator.<>c // TypeDefIndex: 22316
{
	// Fields
	public static readonly FormatterLocator.<>c <>9; // 0x0

	// Methods

	// RVA: 0x7EA8BBC Offset: 0x7EA4BBC VA: 0x7EA8BBC
	private static void .cctor() { }

	// RVA: 0x7EA8C24 Offset: 0x7EA4C24 VA: 0x7EA8C24
	public void .ctor() { }

	// RVA: 0x7EA8C2C Offset: 0x7EA4C2C VA: 0x7EA8C2C
	internal int <.cctor>b__9_0(FormatterLocator.FormatterInfo a, FormatterLocator.FormatterInfo b) { }

	// RVA: 0x7EA8CBC Offset: 0x7EA4CBC VA: 0x7EA8CBC
	internal int <.cctor>b__9_1(FormatterLocator.FormatterLocatorInfo a, FormatterLocator.FormatterLocatorInfo b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FormatterLocator.<GetAllPossibleMissingAOTTypes>d__17 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator // TypeDefIndex: 22317
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Type type; // 0x28
	public Type <>3__type; // 0x30
	private Type[] <>7__wrap1; // 0x38
	private int <>7__wrap2; // 0x40
	private Type <arg>5__4; // 0x48
	private IEnumerator<string> <>7__wrap4; // 0x50

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7EA79D0 Offset: 0x7EA39D0 VA: 0x7EA79D0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7EA8D64 Offset: 0x7EA4D64 VA: 0x7EA8D64 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7EA8D80 Offset: 0x7EA4D80 VA: 0x7EA8D80 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7EA9348 Offset: 0x7EA5348 VA: 0x7EA9348
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x7EA93F8 Offset: 0x7EA53F8 VA: 0x7EA93F8 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EA9400 Offset: 0x7EA5400 VA: 0x7EA9400 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7EA9438 Offset: 0x7EA5438 VA: 0x7EA9438 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EA9440 Offset: 0x7EA5440 VA: 0x7EA9440 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7EA94E4 Offset: 0x7EA54E4 VA: 0x7EA94E4 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Sirenix.Serialization
public static class FormatterLocator // TypeDefIndex: 22318
{
	// Fields
	private static readonly object StrongFormatters_LOCK; // 0x0
	private static readonly object WeakFormatters_LOCK; // 0x8
	private static readonly Dictionary<Type, IFormatter> FormatterInstances; // 0x10
	private static readonly DoubleLookupDictionary<Type, ISerializationPolicy, IFormatter> StrongTypeFormatterMap; // 0x18
	private static readonly DoubleLookupDictionary<Type, ISerializationPolicy, IFormatter> WeakTypeFormatterMap; // 0x20
	private static readonly List<FormatterLocator.FormatterLocatorInfo> FormatterLocators; // 0x28
	private static readonly List<FormatterLocator.FormatterInfo> FormatterInfos; // 0x30

	// Methods

	// RVA: 0x7EA4BA0 Offset: 0x7EA0BA0 VA: 0x7EA4BA0
	private static void .cctor() { }

	// RVA: 0x7EA5E54 Offset: 0x7EA1E54 VA: 0x7EA5E54
	public static void add_FormatterResolve(Func<Type, IFormatter> value) { }

	// RVA: 0x7EA5E8C Offset: 0x7EA1E8C VA: 0x7EA5E8C
	public static void remove_FormatterResolve(Func<Type, IFormatter> value) { }

	// RVA: -1 Offset: -1
	public static IFormatter<T> GetFormatter<T>(ISerializationPolicy policy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4601210 Offset: 0x45FD210 VA: 0x4601210
	|-FormatterLocator.GetFormatter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7EA5EC4 Offset: 0x7EA1EC4 VA: 0x7EA5EC4
	public static IFormatter GetFormatter(Type type, ISerializationPolicy policy) { }

	// RVA: 0x7EA5F2C Offset: 0x7EA1F2C VA: 0x7EA5F2C
	public static IFormatter GetFormatter(Type type, ISerializationPolicy policy, bool allowWeakFallbackFormatters) { }

	// RVA: 0x7EA7704 Offset: 0x7EA3704 VA: 0x7EA7704
	private static void LogAOTError(Type type, Exception ex) { }

	[IteratorStateMachine(typeof(FormatterLocator.<GetAllPossibleMissingAOTTypes>d__17))]
	// RVA: 0x7EA7954 Offset: 0x7EA3954 VA: 0x7EA7954
	private static IEnumerable<string> GetAllPossibleMissingAOTTypes(Type type) { }

	// RVA: 0x7EA7A04 Offset: 0x7EA3A04 VA: 0x7EA7A04
	internal static List<IFormatter> GetAllCompatiblePredefinedFormatters(Type type, ISerializationPolicy policy) { }

	// RVA: 0x7EA6478 Offset: 0x7EA2478 VA: 0x7EA6478
	private static IFormatter CreateFormatter(Type type, ISerializationPolicy policy, bool allowWeakFormatters) { }

	// RVA: 0x7EA8884 Offset: 0x7EA4884 VA: 0x7EA8884
	private static IFormatter GetFormatterInstance(Type type) { }
}

// Namespace: Sirenix.Serialization
internal class GenericCollectionFormatterLocator : IFormatterLocator // TypeDefIndex: 22319
{
	// Methods

	// RVA: 0x7EA94E8 Offset: 0x7EA54E8 VA: 0x7EA94E8 Slot: 4
	public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

	// RVA: 0x7EA9E9C Offset: 0x7EA5E9C VA: 0x7EA9E9C
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public interface IFormatterLocator // TypeDefIndex: 22320
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter);
}

// Namespace: Sirenix.Serialization
internal class ISerializableFormatterLocator : IFormatterLocator // TypeDefIndex: 22321
{
	// Methods

	// RVA: 0x7EA9EA4 Offset: 0x7EA5EA4 VA: 0x7EA9EA4 Slot: 4
	public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

	// RVA: 0x7EAA1C4 Offset: 0x7EA61C4 VA: 0x7EAA1C4
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
internal class SelfFormatterLocator : IFormatterLocator // TypeDefIndex: 22322
{
	// Methods

	// RVA: 0x7EAA1CC Offset: 0x7EA61CC VA: 0x7EAA1CC Slot: 4
	public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

	// RVA: 0x7EAA538 Offset: 0x7EA6538 VA: 0x7EAA538
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
internal class TypeFormatterLocator : IFormatterLocator // TypeDefIndex: 22323
{
	// Methods

	// RVA: 0x7EAA540 Offset: 0x7EA6540 VA: 0x7EAA540 Slot: 4
	public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

	// RVA: 0x7EAA630 Offset: 0x7EA6630 VA: 0x7EAA630
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class ArrayFormatter<T> : BaseFormatter<T[]> // TypeDefIndex: 22324
{
	// Fields
	private static Serializer<T> valueReaderWriter; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected override T[] GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x613E738 Offset: 0x613A738 VA: 0x613E738
	|-ArrayFormatter<__Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref T[] value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x613E740 Offset: 0x613A740 VA: 0x613E740
	|-ArrayFormatter<__Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref T[] value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x613ED80 Offset: 0x613AD80 VA: 0x613ED80
	|-ArrayFormatter<__Il2CppFullySharedGenericType>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x613F0D4 Offset: 0x613B0D4 VA: 0x613F0D4
	|-ArrayFormatter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x613F134 Offset: 0x613B134 VA: 0x613F134
	|-ArrayFormatter<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Sirenix.Serialization
public sealed class WeakArrayFormatter : WeakBaseFormatter // TypeDefIndex: 22325
{
	// Fields
	private readonly Serializer ValueReaderWriter; // 0x40
	private readonly Type ElementType; // 0x48

	// Methods

	// RVA: 0x7EA46B8 Offset: 0x7EA06B8 VA: 0x7EA46B8
	public void .ctor(Type arrayType, Type elementType) { }

	// RVA: 0x7EAAAB0 Offset: 0x7EA6AB0 VA: 0x7EAAAB0 Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EAAAB8 Offset: 0x7EA6AB8 VA: 0x7EAAAB8 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EAB174 Offset: 0x7EA7174 VA: 0x7EAB174 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }
}

// Namespace: Sirenix.Serialization
public class ArrayListFormatter : BaseFormatter<ArrayList> // TypeDefIndex: 22326
{
	// Fields
	private static readonly Serializer<object> ObjectSerializer; // 0x0

	// Methods

	// RVA: 0x7EAB410 Offset: 0x7EA7410 VA: 0x7EAB410 Slot: 9
	protected override ArrayList GetUninitializedObject() { }

	// RVA: 0x7EAB418 Offset: 0x7EA7418 VA: 0x7EAB418 Slot: 10
	protected override void DeserializeImplementation(ref ArrayList value, IDataReader reader) { }

	// RVA: 0x7EABBD4 Offset: 0x7EA7BD4 VA: 0x7EABBD4 Slot: 11
	protected override void SerializeImplementation(ref ArrayList value, IDataWriter writer) { }

	// RVA: 0x7EABFE8 Offset: 0x7EA7FE8 VA: 0x7EABFE8
	public void .ctor() { }

	// RVA: 0x7EAC054 Offset: 0x7EA8054 VA: 0x7EAC054
	private static void .cctor() { }
}

// Namespace: 
protected sealed class BaseFormatter.SerializationCallback<T> : MulticastDelegate // TypeDefIndex: 22327
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E2128 Offset: 0x54DE128 VA: 0x54E2128
	|-BaseFormatter.SerializationCallback<Nullable<int>>..ctor
	|
	|-RVA: 0x54E22C4 Offset: 0x54DE2C4 VA: 0x54E22C4
	|-BaseFormatter.SerializationCallback<Keyframe>..ctor
	|
	|-RVA: 0x54E2460 Offset: 0x54DE460 VA: 0x54E2460
	|-BaseFormatter.SerializationCallback<object>..ctor
	|
	|-RVA: 0x54E25DC Offset: 0x54DE5DC VA: 0x54E25DC
	|-BaseFormatter.SerializationCallback<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref T value, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E21DC Offset: 0x54DE1DC VA: 0x54E21DC
	|-BaseFormatter.SerializationCallback<Nullable<int>>.Invoke
	|
	|-RVA: 0x54E2378 Offset: 0x54DE378 VA: 0x54E2378
	|-BaseFormatter.SerializationCallback<Keyframe>.Invoke
	|
	|-RVA: 0x54E2514 Offset: 0x54DE514 VA: 0x54E2514
	|-BaseFormatter.SerializationCallback<object>.Invoke
	|
	|-RVA: 0x54E2690 Offset: 0x54DE690 VA: 0x54E2690
	|-BaseFormatter.SerializationCallback<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref T value, StreamingContext context, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E21F0 Offset: 0x54DE1F0 VA: 0x54E21F0
	|-BaseFormatter.SerializationCallback<Nullable<int>>.BeginInvoke
	|
	|-RVA: 0x54E238C Offset: 0x54DE38C VA: 0x54E238C
	|-BaseFormatter.SerializationCallback<Keyframe>.BeginInvoke
	|
	|-RVA: 0x54E2528 Offset: 0x54DE528 VA: 0x54E2528
	|-BaseFormatter.SerializationCallback<object>.BeginInvoke
	|
	|-RVA: 0x54E26A4 Offset: 0x54DE6A4 VA: 0x54E26A4
	|-BaseFormatter.SerializationCallback<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref T value, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E22A8 Offset: 0x54DE2A8 VA: 0x54E22A8
	|-BaseFormatter.SerializationCallback<Nullable<int>>.EndInvoke
	|
	|-RVA: 0x54E2444 Offset: 0x54DE444 VA: 0x54E2444
	|-BaseFormatter.SerializationCallback<Keyframe>.EndInvoke
	|
	|-RVA: 0x54E25C0 Offset: 0x54DE5C0 VA: 0x54E25C0
	|-BaseFormatter.SerializationCallback<object>.EndInvoke
	|
	|-RVA: 0x54E276C Offset: 0x54DE76C VA: 0x54E276C
	|-BaseFormatter.SerializationCallback<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class BaseFormatter.<>c__DisplayClass11_0<T> // TypeDefIndex: 22328
{
	// Fields
	public MethodInfo info; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4865570 Offset: 0x4861570 VA: 0x4865570
	|-BaseFormatter.<>c__DisplayClass11_0<Nullable<int>>..ctor
	|
	|-RVA: 0x48657D0 Offset: 0x48617D0 VA: 0x48657D0
	|-BaseFormatter.<>c__DisplayClass11_0<Keyframe>..ctor
	|
	|-RVA: 0x4865A2C Offset: 0x4861A2C VA: 0x4865A2C
	|-BaseFormatter.<>c__DisplayClass11_0<object>..ctor
	|
	|-RVA: 0x4865F54 Offset: 0x4861F54 VA: 0x4865F54
	|-BaseFormatter.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateCallback>b__0(ref T value, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4865578 Offset: 0x4861578 VA: 0x4865578
	|-BaseFormatter.<>c__DisplayClass11_0<Nullable<int>>.<CreateCallback>b__0
	|
	|-RVA: 0x48657D8 Offset: 0x48617D8 VA: 0x48657D8
	|-BaseFormatter.<>c__DisplayClass11_0<Keyframe>.<CreateCallback>b__0
	|
	|-RVA: 0x4865A34 Offset: 0x4861A34 VA: 0x4865A34
	|-BaseFormatter.<>c__DisplayClass11_0<object>.<CreateCallback>b__0
	|
	|-RVA: 0x4865F5C Offset: 0x4861F5C VA: 0x4865F5C
	|-BaseFormatter.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType>.<CreateCallback>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <CreateCallback>b__1(ref T value, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4865638 Offset: 0x4861638 VA: 0x4865638
	|-BaseFormatter.<>c__DisplayClass11_0<Nullable<int>>.<CreateCallback>b__1
	|
	|-RVA: 0x48658A0 Offset: 0x48618A0 VA: 0x48658A0
	|-BaseFormatter.<>c__DisplayClass11_0<Keyframe>.<CreateCallback>b__1
	|
	|-RVA: 0x4865B0C Offset: 0x4861B0C VA: 0x4865B0C
	|-BaseFormatter.<>c__DisplayClass11_0<object>.<CreateCallback>b__1
	|
	|-RVA: 0x4866094 Offset: 0x4862094 VA: 0x4866094
	|-BaseFormatter.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType>.<CreateCallback>b__1
	*/
}

// Namespace: Sirenix.Serialization
public abstract class BaseFormatter<T> : IFormatter<T>, IFormatter // TypeDefIndex: 22329
{
	// Fields
	protected static readonly BaseFormatter.SerializationCallback<T>[] OnSerializingCallbacks; // 0x0
	protected static readonly BaseFormatter.SerializationCallback<T>[] OnSerializedCallbacks; // 0x0
	protected static readonly BaseFormatter.SerializationCallback<T>[] OnDeserializingCallbacks; // 0x0
	protected static readonly BaseFormatter.SerializationCallback<T>[] OnDeserializedCallbacks; // 0x0
	protected static readonly bool IsValueType; // 0x0
	protected static readonly bool ImplementsISerializationCallbackReceiver; // 0x0
	protected static readonly bool ImplementsIDeserializationCallback; // 0x0
	protected static readonly bool ImplementsIObjectReference; // 0x0

	// Properties
	public Type SerializedType { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B687F4 Offset: 0x5B647F4 VA: 0x5B687F4
	|-BaseFormatter<Nullable<int>>..cctor
	|
	|-RVA: 0x5B6ADEC Offset: 0x5B66DEC VA: 0x5B6ADEC
	|-BaseFormatter<Keyframe>..cctor
	|
	|-RVA: 0x5B6D010 Offset: 0x5B69010 VA: 0x5B6D010
	|-BaseFormatter<object>..cctor
	|
	|-RVA: 0x5B6F4A0 Offset: 0x5B6B4A0 VA: 0x5B6F4A0
	|-BaseFormatter<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	private static BaseFormatter.SerializationCallback<T>[] GetCallbacks(MethodInfo[] methods, Type callbackAttribute, ref List<BaseFormatter.SerializationCallback<T>> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B6902C Offset: 0x5B6502C VA: 0x5B6902C
	|-BaseFormatter<Nullable<int>>.GetCallbacks
	|
	|-RVA: 0x5B6B624 Offset: 0x5B67624 VA: 0x5B6B624
	|-BaseFormatter<Keyframe>.GetCallbacks
	|
	|-RVA: 0x5B6D848 Offset: 0x5B69848 VA: 0x5B6D848
	|-BaseFormatter<object>.GetCallbacks
	|
	|-RVA: 0x5B6FDCC Offset: 0x5B6BDCC VA: 0x5B6FDCC
	|-BaseFormatter<__Il2CppFullySharedGenericType>.GetCallbacks
	*/

	// RVA: -1 Offset: -1
	private static BaseFormatter.SerializationCallback<T> CreateCallback(MethodInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B691FC Offset: 0x5B651FC VA: 0x5B691FC
	|-BaseFormatter<Nullable<int>>.CreateCallback
	|
	|-RVA: 0x5B6B7F4 Offset: 0x5B677F4 VA: 0x5B6B7F4
	|-BaseFormatter<Keyframe>.CreateCallback
	|
	|-RVA: 0x5B6DA18 Offset: 0x5B69A18 VA: 0x5B6DA18
	|-BaseFormatter<object>.CreateCallback
	|
	|-RVA: 0x5B70034 Offset: 0x5B6C034 VA: 0x5B70034
	|-BaseFormatter<__Il2CppFullySharedGenericType>.CreateCallback
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public Type get_SerializedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B69580 Offset: 0x5B65580 VA: 0x5B69580
	|-BaseFormatter<Nullable<int>>.get_SerializedType
	|
	|-RVA: 0x5B6BB78 Offset: 0x5B67B78 VA: 0x5B6BB78
	|-BaseFormatter<Keyframe>.get_SerializedType
	|
	|-RVA: 0x5B6DD9C Offset: 0x5B69D9C VA: 0x5B6DD9C
	|-BaseFormatter<object>.get_SerializedType
	|
	|-RVA: 0x5B70440 Offset: 0x5B6C440 VA: 0x5B70440
	|-BaseFormatter<__Il2CppFullySharedGenericType>.get_SerializedType
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void Sirenix.Serialization.IFormatter.Serialize(object value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B695E4 Offset: 0x5B655E4 VA: 0x5B695E4
	|-BaseFormatter<Nullable<int>>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x5B6BBDC Offset: 0x5B67BDC VA: 0x5B6BBDC
	|-BaseFormatter<Keyframe>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x5B6DE00 Offset: 0x5B69E00 VA: 0x5B6DE00
	|-BaseFormatter<object>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x5B704A4 Offset: 0x5B6C4A4 VA: 0x5B704A4
	|-BaseFormatter<__Il2CppFullySharedGenericType>.Sirenix.Serialization.IFormatter.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object Sirenix.Serialization.IFormatter.Deserialize(IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B69680 Offset: 0x5B65680 VA: 0x5B69680
	|-BaseFormatter<Nullable<int>>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x5B6BC94 Offset: 0x5B67C94 VA: 0x5B6BC94
	|-BaseFormatter<Keyframe>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x5B6DE88 Offset: 0x5B69E88 VA: 0x5B6DE88
	|-BaseFormatter<object>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x5B70580 Offset: 0x5B6C580 VA: 0x5B70580
	|-BaseFormatter<__Il2CppFullySharedGenericType>.Sirenix.Serialization.IFormatter.Deserialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B696C0 Offset: 0x5B656C0 VA: 0x5B696C0
	|-BaseFormatter<Nullable<int>>.Deserialize
	|
	|-RVA: 0x5B6BCE4 Offset: 0x5B67CE4 VA: 0x5B6BCE4
	|-BaseFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x5B6DE98 Offset: 0x5B69E98 VA: 0x5B6DE98
	|-BaseFormatter<object>.Deserialize
	|
	|-RVA: 0x5B70628 Offset: 0x5B6C628 VA: 0x5B70628
	|-BaseFormatter<__Il2CppFullySharedGenericType>.Deserialize
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B6A118 Offset: 0x5B66118 VA: 0x5B6A118
	|-BaseFormatter<Nullable<int>>.Serialize
	|
	|-RVA: 0x5B6C4C0 Offset: 0x5B684C0 VA: 0x5B6C4C0
	|-BaseFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x5B6E84C Offset: 0x5B6A84C VA: 0x5B6E84C
	|-BaseFormatter<object>.Serialize
	|
	|-RVA: 0x5B711C0 Offset: 0x5B6D1C0 VA: 0x5B711C0
	|-BaseFormatter<__Il2CppFullySharedGenericType>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual T GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B6A898 Offset: 0x5B66898 VA: 0x5B6A898
	|-BaseFormatter<Nullable<int>>.GetUninitializedObject
	|
	|-RVA: 0x5B6CABC Offset: 0x5B68ABC VA: 0x5B6CABC
	|-BaseFormatter<Keyframe>.GetUninitializedObject
	|
	|-RVA: 0x5B6EF90 Offset: 0x5B6AF90 VA: 0x5B6EF90
	|-BaseFormatter<object>.GetUninitializedObject
	|
	|-RVA: 0x5B71A10 Offset: 0x5B6DA10 VA: 0x5B71A10
	|-BaseFormatter<__Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1
	protected void RegisterReferenceID(T value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B6A9F4 Offset: 0x5B669F4 VA: 0x5B6A9F4
	|-BaseFormatter<Nullable<int>>.RegisterReferenceID
	|
	|-RVA: 0x5B6CC14 Offset: 0x5B68C14 VA: 0x5B6CC14
	|-BaseFormatter<Keyframe>.RegisterReferenceID
	|
	|-RVA: 0x5B6F0C4 Offset: 0x5B6B0C4 VA: 0x5B6F0C4
	|-BaseFormatter<object>.RegisterReferenceID
	|
	|-RVA: 0x5B71BE4 Offset: 0x5B6DBE4 VA: 0x5B71BE4
	|-BaseFormatter<__Il2CppFullySharedGenericType>.RegisterReferenceID
	*/

	[Obsolete("Use the InvokeOnDeserializingCallbacks variant that takes a ref T value instead. This is for struct compatibility reasons.", False)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	protected void InvokeOnDeserializingCallbacks(T value, DeserializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B6ABD4 Offset: 0x5B66BD4 VA: 0x5B6ABD4
	|-BaseFormatter<Nullable<int>>.InvokeOnDeserializingCallbacks
	|
	|-RVA: 0x5B6CE0C Offset: 0x5B68E0C VA: 0x5B6CE0C
	|-BaseFormatter<Keyframe>.InvokeOnDeserializingCallbacks
	|
	|-RVA: 0x5B6F288 Offset: 0x5B6B288 VA: 0x5B6F288
	|-BaseFormatter<object>.InvokeOnDeserializingCallbacks
	|
	|-RVA: 0x5B71E38 Offset: 0x5B6DE38 VA: 0x5B71E38
	|-BaseFormatter<__Il2CppFullySharedGenericType>.InvokeOnDeserializingCallbacks
	*/

	// RVA: -1 Offset: -1
	protected void InvokeOnDeserializingCallbacks(ref T value, DeserializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B6ABF8 Offset: 0x5B66BF8 VA: 0x5B6ABF8
	|-BaseFormatter<Nullable<int>>.InvokeOnDeserializingCallbacks
	|
	|-RVA: 0x5B6CE1C Offset: 0x5B68E1C VA: 0x5B6CE1C
	|-BaseFormatter<Keyframe>.InvokeOnDeserializingCallbacks
	|
	|-RVA: 0x5B6F2AC Offset: 0x5B6B2AC VA: 0x5B6F2AC
	|-BaseFormatter<object>.InvokeOnDeserializingCallbacks
	|
	|-RVA: 0x5B71E70 Offset: 0x5B6DE70 VA: 0x5B71E70
	|-BaseFormatter<__Il2CppFullySharedGenericType>.InvokeOnDeserializingCallbacks
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void DeserializeImplementation(ref T value, IDataReader reader);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseFormatter<__Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void SerializeImplementation(ref T value, IDataWriter writer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseFormatter<__Il2CppFullySharedGenericType>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B6ADE4 Offset: 0x5B66DE4 VA: 0x5B6ADE4
	|-BaseFormatter<Nullable<int>>..ctor
	|
	|-RVA: 0x5B6D008 Offset: 0x5B69008 VA: 0x5B6D008
	|-BaseFormatter<Keyframe>..ctor
	|
	|-RVA: 0x5B6F498 Offset: 0x5B6B498 VA: 0x5B6F498
	|-BaseFormatter<object>..ctor
	|
	|-RVA: 0x5B72060 Offset: 0x5B6E060 VA: 0x5B72060
	|-BaseFormatter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
protected sealed class WeakBaseFormatter.SerializationCallback : MulticastDelegate // TypeDefIndex: 22330
{
	// Methods

	// RVA: 0x7EAC544 Offset: 0x7EA8544 VA: 0x7EAC544
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7EAD354 Offset: 0x7EA9354 VA: 0x7EAD354 Slot: 13
	public virtual void Invoke(object value, StreamingContext context) { }

	// RVA: 0x7EAD368 Offset: 0x7EA9368 VA: 0x7EAD368 Slot: 14
	public virtual IAsyncResult BeginInvoke(object value, StreamingContext context, AsyncCallback callback, object object) { }

	// RVA: 0x7EAD3FC Offset: 0x7EA93FC VA: 0x7EAD3FC Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WeakBaseFormatter.<>c__DisplayClass14_0 // TypeDefIndex: 22331
{
	// Fields
	public MethodInfo info; // 0x10

	// Methods

	// RVA: 0x7EAC53C Offset: 0x7EA853C VA: 0x7EAC53C
	public void .ctor() { }

	// RVA: 0x7EAD408 Offset: 0x7EA9408 VA: 0x7EAD408
	internal void <CreateCallback>b__0(object value, StreamingContext context) { }

	// RVA: 0x7EAD428 Offset: 0x7EA9428 VA: 0x7EAD428
	internal void <CreateCallback>b__1(object value, StreamingContext context) { }
}

// Namespace: Sirenix.Serialization
public abstract class WeakBaseFormatter : IFormatter // TypeDefIndex: 22332
{
	// Fields
	protected readonly Type SerializedType; // 0x10
	protected readonly WeakBaseFormatter.SerializationCallback[] OnSerializingCallbacks; // 0x18
	protected readonly WeakBaseFormatter.SerializationCallback[] OnSerializedCallbacks; // 0x20
	protected readonly WeakBaseFormatter.SerializationCallback[] OnDeserializingCallbacks; // 0x28
	protected readonly WeakBaseFormatter.SerializationCallback[] OnDeserializedCallbacks; // 0x30
	protected readonly bool IsValueType; // 0x38
	protected readonly bool ImplementsISerializationCallbackReceiver; // 0x39
	protected readonly bool ImplementsIDeserializationCallback; // 0x3A
	protected readonly bool ImplementsIObjectReference; // 0x3B

	// Properties
	private Type Sirenix.Serialization.IFormatter.SerializedType { get; }

	// Methods

	// RVA: 0x7EAC0E8 Offset: 0x7EA80E8 VA: 0x7EAC0E8 Slot: 4
	private Type Sirenix.Serialization.IFormatter.get_SerializedType() { }

	// RVA: 0x7EAA638 Offset: 0x7EA6638 VA: 0x7EAA638
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EAC0F0 Offset: 0x7EA80F0 VA: 0x7EAC0F0
	private static WeakBaseFormatter.SerializationCallback[] GetCallbacks(MethodInfo[] methods, Type callbackAttribute, ref List<WeakBaseFormatter.SerializationCallback> list) { }

	// RVA: 0x7EAC278 Offset: 0x7EA8278 VA: 0x7EAC278
	private static WeakBaseFormatter.SerializationCallback CreateCallback(MethodInfo info) { }

	// RVA: 0x7EAC650 Offset: 0x7EA8650 VA: 0x7EAC650 Slot: 5
	public void Serialize(object value, IDataWriter writer) { }

	// RVA: 0x7EACB38 Offset: 0x7EA8B38 VA: 0x7EACB38 Slot: 6
	public object Deserialize(IDataReader reader) { }

	// RVA: 0x7EAAFF0 Offset: 0x7EA6FF0 VA: 0x7EAAFF0
	protected void RegisterReferenceID(object value, IDataReader reader) { }

	// RVA: 0x7EAD188 Offset: 0x7EA9188 VA: 0x7EAD188
	protected void InvokeOnDeserializingCallbacks(object value, DeserializationContext context) { }

	// RVA: 0x7EAD2DC Offset: 0x7EA92DC VA: 0x7EAD2DC Slot: 7
	protected virtual object GetUninitializedObject() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void DeserializeImplementation(ref object value, IDataReader reader);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void SerializeImplementation(ref object value, IDataWriter writer);
}

// Namespace: Sirenix.Serialization
public sealed class DateTimeFormatter : MinimalBaseFormatter<DateTime> // TypeDefIndex: 22333
{
	// Methods

	// RVA: 0x7EAD528 Offset: 0x7EA9528 VA: 0x7EAD528 Slot: 10
	protected override void Read(ref DateTime value, IDataReader reader) { }

	// RVA: 0x7EAD684 Offset: 0x7EA9684 VA: 0x7EAD684 Slot: 11
	protected override void Write(ref DateTime value, IDataWriter writer) { }

	// RVA: 0x7EAD76C Offset: 0x7EA976C VA: 0x7EAD76C
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class DateTimeOffsetFormatter : MinimalBaseFormatter<DateTimeOffset> // TypeDefIndex: 22334
{
	// Methods

	// RVA: 0x7EAD7D8 Offset: 0x7EA97D8 VA: 0x7EAD7D8 Slot: 10
	protected override void Read(ref DateTimeOffset value, IDataReader reader) { }

	// RVA: 0x7EAD934 Offset: 0x7EA9934 VA: 0x7EAD934 Slot: 11
	protected override void Write(ref DateTimeOffset value, IDataWriter writer) { }

	// RVA: 0x7EADA6C Offset: 0x7EA9A6C VA: 0x7EADA6C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DelegateFormatter.<>c<T> // TypeDefIndex: 22335
{
	// Fields
	public static readonly DelegateFormatter.<>c<T> <>9; // 0x0
	public static Func<Type, string> <>9__8_0; // 0x0
	public static Func<Type, string> <>9__8_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4823510 Offset: 0x481F510 VA: 0x4823510
	|-DelegateFormatter.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48235CC Offset: 0x481F5CC VA: 0x48235CC
	|-DelegateFormatter.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal string <DeserializeImplementation>b__8_0(Type p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48235D4 Offset: 0x481F5D4 VA: 0x48235D4
	|-DelegateFormatter.<>c<object>.<DeserializeImplementation>b__8_0
	*/

	// RVA: -1 Offset: -1
	internal string <DeserializeImplementation>b__8_1(Type p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482362C Offset: 0x481F62C VA: 0x482362C
	|-DelegateFormatter.<>c<object>.<DeserializeImplementation>b__8_1
	*/
}

// Namespace: Sirenix.Serialization
public class DelegateFormatter<T> : BaseFormatter<T> // TypeDefIndex: 22336
{
	// Fields
	private static readonly Serializer<object> ObjectSerializer; // 0x0
	private static readonly Serializer<string> StringSerializer; // 0x0
	private static readonly Serializer<Type> TypeSerializer; // 0x0
	private static readonly Serializer<Type[]> TypeArraySerializer; // 0x0
	private static readonly Serializer<Delegate[]> DelegateArraySerializer; // 0x0
	public readonly Type DelegateType; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D21CF4 Offset: 0x5D1DCF4 VA: 0x5D21CF4
	|-DelegateFormatter<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Type delegateType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D21D7C Offset: 0x5D1DD7C VA: 0x5D21D7C
	|-DelegateFormatter<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref T value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D21EDC Offset: 0x5D1DEDC VA: 0x5D21EDC
	|-DelegateFormatter<object>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2440C Offset: 0x5D2040C VA: 0x5D2440C
	|-DelegateFormatter<object>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override T GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D24B7C Offset: 0x5D20B7C VA: 0x5D24B7C
	|-DelegateFormatter<object>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D24B84 Offset: 0x5D20B84 VA: 0x5D24B84
	|-DelegateFormatter<object>..cctor
	*/
}

// Namespace: Sirenix.Serialization
public class WeakDelegateFormatter : DelegateFormatter<Delegate> // TypeDefIndex: 22337
{
	// Methods

	// RVA: 0x7EA4B1C Offset: 0x7EA0B1C VA: 0x7EA4B1C
	public void .ctor(Type delegateType) { }
}

// Namespace: Sirenix.Serialization
internal sealed class DerivedDictionaryFormatter<TDictionary, TKey, TValue> : BaseFormatter<TDictionary> // TypeDefIndex: 22338
{
	// Fields
	private static readonly bool KeyIsValueType; // 0x0
	private static readonly Serializer<IEqualityComparer<TKey>> EqualityComparerSerializer; // 0x0
	private static readonly Serializer<TKey> KeyReaderWriter; // 0x0
	private static readonly Serializer<TValue> ValueReaderWriter; // 0x0
	private static readonly ConstructorInfo ComparerConstructor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D42BD8 Offset: 0x5D3EBD8 VA: 0x5D42BD8
	|-DerivedDictionaryFormatter<object, int, object>..cctor
	|
	|-RVA: 0x5D446D0 Offset: 0x5D406D0 VA: 0x5D446D0
	|-DerivedDictionaryFormatter<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D42FCC Offset: 0x5D3EFCC VA: 0x5D42FCC
	|-DerivedDictionaryFormatter<object, int, object>..ctor
	|
	|-RVA: 0x5D44B6C Offset: 0x5D40B6C VA: 0x5D44B6C
	|-DerivedDictionaryFormatter<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override TDictionary GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D43028 Offset: 0x5D3F028 VA: 0x5D43028
	|-DerivedDictionaryFormatter<object, int, object>.GetUninitializedObject
	|
	|-RVA: 0x5D44BC8 Offset: 0x5D40BC8 VA: 0x5D44BC8
	|-DerivedDictionaryFormatter<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref TDictionary value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D43030 Offset: 0x5D3F030 VA: 0x5D43030
	|-DerivedDictionaryFormatter<object, int, object>.DeserializeImplementation
	|
	|-RVA: 0x5D44BD0 Offset: 0x5D40BD0 VA: 0x5D44BD0
	|-DerivedDictionaryFormatter<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref TDictionary value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D43EB0 Offset: 0x5D3FEB0 VA: 0x5D43EB0
	|-DerivedDictionaryFormatter<object, int, object>.SerializeImplementation
	|
	|-RVA: 0x5D45D6C Offset: 0x5D41D6C VA: 0x5D45D6C
	|-DerivedDictionaryFormatter<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
public sealed class DictionaryFormatter<TKey, TValue> : BaseFormatter<Dictionary<TKey, TValue>> // TypeDefIndex: 22339
{
	// Fields
	private static readonly bool KeyIsValueType; // 0x0
	private static readonly Serializer<IEqualityComparer<TKey>> EqualityComparerSerializer; // 0x0
	private static readonly Serializer<TKey> KeyReaderWriter; // 0x0
	private static readonly Serializer<TValue> ValueReaderWriter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D54A74 Offset: 0x5D50A74 VA: 0x5D54A74
	|-DictionaryFormatter<int, object>..cctor
	|
	|-RVA: 0x5D56278 Offset: 0x5D52278 VA: 0x5D56278
	|-DictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D54D24 Offset: 0x5D50D24 VA: 0x5D54D24
	|-DictionaryFormatter<int, object>..ctor
	|
	|-RVA: 0x5D565D0 Offset: 0x5D525D0 VA: 0x5D565D0
	|-DictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override Dictionary<TKey, TValue> GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D54D80 Offset: 0x5D50D80 VA: 0x5D54D80
	|-DictionaryFormatter<int, object>.GetUninitializedObject
	|
	|-RVA: 0x5D56630 Offset: 0x5D52630 VA: 0x5D56630
	|-DictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref Dictionary<TKey, TValue> value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D54D88 Offset: 0x5D50D88 VA: 0x5D54D88
	|-DictionaryFormatter<int, object>.DeserializeImplementation
	|
	|-RVA: 0x5D56638 Offset: 0x5D52638 VA: 0x5D56638
	|-DictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref Dictionary<TKey, TValue> value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D55A58 Offset: 0x5D51A58 VA: 0x5D55A58
	|-DictionaryFormatter<int, object>.SerializeImplementation
	|
	|-RVA: 0x5D57638 Offset: 0x5D53638 VA: 0x5D57638
	|-DictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
internal sealed class WeakDictionaryFormatter : WeakBaseFormatter // TypeDefIndex: 22340
{
	// Fields
	private readonly bool KeyIsValueType; // 0x3C
	private readonly Serializer EqualityComparerSerializer; // 0x40
	private readonly Serializer KeyReaderWriter; // 0x48
	private readonly Serializer ValueReaderWriter; // 0x50
	private readonly ConstructorInfo ComparerConstructor; // 0x58
	private readonly PropertyInfo ComparerProperty; // 0x60
	private readonly PropertyInfo CountProperty; // 0x68
	private readonly Type KeyType; // 0x70
	private readonly Type ValueType; // 0x78

	// Methods

	// RVA: 0x7EADAD8 Offset: 0x7EA9AD8 VA: 0x7EADAD8
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EADFE8 Offset: 0x7EA9FE8 VA: 0x7EADFE8 Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EADFF0 Offset: 0x7EA9FF0 VA: 0x7EADFF0 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EAEE34 Offset: 0x7EAAE34 VA: 0x7EAEE34 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }
}

// Namespace: Sirenix.Serialization
internal sealed class DoubleLookupDictionaryFormatter<TPrimary, TSecondary, TValue> : BaseFormatter<DoubleLookupDictionary<TPrimary, TSecondary, TValue>> // TypeDefIndex: 22341
{
	// Fields
	private static readonly Serializer<TPrimary> PrimaryReaderWriter; // 0x0
	private static readonly Serializer<Dictionary<TSecondary, TValue>> InnerReaderWriter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60206C8 Offset: 0x601C6C8 VA: 0x60206C8
	|-DoubleLookupDictionaryFormatter<int, int, object>..cctor
	|
	|-RVA: 0x6021B14 Offset: 0x601DB14 VA: 0x6021B14
	|-DoubleLookupDictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6020858 Offset: 0x601C858 VA: 0x6020858
	|-DoubleLookupDictionaryFormatter<int, int, object>..ctor
	|
	|-RVA: 0x6021D14 Offset: 0x601DD14 VA: 0x6021D14
	|-DoubleLookupDictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override DoubleLookupDictionary<TPrimary, TSecondary, TValue> GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60208B4 Offset: 0x601C8B4 VA: 0x60208B4
	|-DoubleLookupDictionaryFormatter<int, int, object>.GetUninitializedObject
	|
	|-RVA: 0x6021D74 Offset: 0x601DD74 VA: 0x6021D74
	|-DoubleLookupDictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref DoubleLookupDictionary<TPrimary, TSecondary, TValue> value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60208BC Offset: 0x601C8BC VA: 0x60208BC
	|-DoubleLookupDictionaryFormatter<int, int, object>.SerializeImplementation
	|
	|-RVA: 0x6021D7C Offset: 0x601DD7C VA: 0x6021D7C
	|-DoubleLookupDictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref DoubleLookupDictionary<TPrimary, TSecondary, TValue> value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6020FC0 Offset: 0x601CFC0 VA: 0x6020FC0
	|-DoubleLookupDictionaryFormatter<int, int, object>.DeserializeImplementation
	|
	|-RVA: 0x60226A4 Offset: 0x601E6A4 VA: 0x60226A4
	|-DoubleLookupDictionaryFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
internal sealed class WeakDoubleLookupDictionaryFormatter : WeakBaseFormatter // TypeDefIndex: 22342
{
	// Fields
	private readonly Serializer PrimaryReaderWriter; // 0x40
	private readonly Serializer InnerReaderWriter; // 0x48

	// Methods

	// RVA: 0x7EAF794 Offset: 0x7EAB794 VA: 0x7EAF794
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EAF8DC Offset: 0x7EAB8DC VA: 0x7EAF8DC Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EAF8E4 Offset: 0x7EAB8E4 VA: 0x7EAF8E4 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }

	// RVA: 0x7EB0194 Offset: 0x7EAC194 VA: 0x7EB0194 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }
}

// Namespace: Sirenix.Serialization
public abstract class EasyBaseFormatter<T> : BaseFormatter<T> // TypeDefIndex: 22343
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	protected sealed override void DeserializeImplementation(ref T value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051304 Offset: 0x604D304 VA: 0x6051304
	|-EasyBaseFormatter<__Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected sealed override void SerializeImplementation(ref T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60514B8 Offset: 0x604D4B8 VA: 0x60514B8
	|-EasyBaseFormatter<__Il2CppFullySharedGenericType>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EasyBaseFormatter<__Il2CppFullySharedGenericType>.ReadDataEntry
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void WriteDataEntries(ref T value, IDataWriter writer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EasyBaseFormatter<__Il2CppFullySharedGenericType>.WriteDataEntries
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60514C8 Offset: 0x604D4C8 VA: 0x60514C8
	|-EasyBaseFormatter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Sirenix.Serialization
[Usage(4)]
public class EmittedFormatterAttribute : Attribute // TypeDefIndex: 22344
{
	// Methods

	// RVA: 0x7EB0CF8 Offset: 0x7EACCF8 VA: 0x7EB0CF8
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public class EmptyTypeFormatter<T> : EasyBaseFormatter<T> // TypeDefIndex: 22345
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected override void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B1D28 Offset: 0x60ADD28 VA: 0x60B1D28
	|-EmptyTypeFormatter<__Il2CppFullySharedGenericType>.ReadDataEntry
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected override void WriteDataEntries(ref T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B1DC8 Offset: 0x60ADDC8 VA: 0x60B1DC8
	|-EmptyTypeFormatter<__Il2CppFullySharedGenericType>.WriteDataEntries
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B1DCC Offset: 0x60ADDCC VA: 0x60B1DCC
	|-EmptyTypeFormatter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[EmittedFormatter]
public abstract class FormatterEmitter.AOTEmittedFormatter<T> : EasyBaseFormatter<T> // TypeDefIndex: 22346
{
	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F35278 Offset: 0x5F31278 VA: 0x5F35278
	|-FormatterEmitter.AOTEmittedFormatter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public abstract class FormatterEmitter.EmptyAOTEmittedFormatter<T> : FormatterEmitter.AOTEmittedFormatter<T> // TypeDefIndex: 22347
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected override void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60532B4 Offset: 0x604F2B4 VA: 0x60532B4
	|-FormatterEmitter.EmptyAOTEmittedFormatter<__Il2CppFullySharedGenericType>.ReadDataEntry
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected override void WriteDataEntries(ref T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6053354 Offset: 0x604F354 VA: 0x6053354
	|-FormatterEmitter.EmptyAOTEmittedFormatter<__Il2CppFullySharedGenericType>.WriteDataEntries
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6053358 Offset: 0x604F358 VA: 0x6053358
	|-FormatterEmitter.EmptyAOTEmittedFormatter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Sirenix.Serialization
public static class FormatterEmitter // TypeDefIndex: 22348
{
	// Fields
	private static int helperFormatterNameId; // 0x0
	public const string PRE_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.AOTGenerated";
	public const string RUNTIME_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.RuntimeEmitted";

	// Methods

	// RVA: 0x7EA8B4C Offset: 0x7EA4B4C VA: 0x7EA8B4C
	public static IFormatter GetEmittedFormatter(Type type, ISerializationPolicy policy) { }
}

// Namespace: Sirenix.Serialization
public static class GenericCollectionFormatter // TypeDefIndex: 22349
{
	// Methods

	// RVA: 0x7EA981C Offset: 0x7EA581C VA: 0x7EA981C
	public static bool CanFormat(Type type, out Type elementType) { }
}

// Namespace: Sirenix.Serialization
public sealed class GenericCollectionFormatter<TCollection, TElement> : BaseFormatter<TCollection> // TypeDefIndex: 22350
{
	// Fields
	private static Serializer<TElement> valueReaderWriter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EB9E8 Offset: 0x48E79E8 VA: 0x48EB9E8
	|-GenericCollectionFormatter<object, int>..cctor
	|
	|-RVA: 0x48ECE58 Offset: 0x48E8E58 VA: 0x48ECE58
	|-GenericCollectionFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EBD9C Offset: 0x48E7D9C VA: 0x48EBD9C
	|-GenericCollectionFormatter<object, int>..ctor
	|
	|-RVA: 0x48ED244 Offset: 0x48E9244 VA: 0x48ED244
	|-GenericCollectionFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override TCollection GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EBDF8 Offset: 0x48E7DF8 VA: 0x48EBDF8
	|-GenericCollectionFormatter<object, int>.GetUninitializedObject
	|
	|-RVA: 0x48ED2A4 Offset: 0x48E92A4 VA: 0x48ED2A4
	|-GenericCollectionFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref TCollection value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EBE08 Offset: 0x48E7E08 VA: 0x48EBE08
	|-GenericCollectionFormatter<object, int>.DeserializeImplementation
	|
	|-RVA: 0x48ED344 Offset: 0x48E9344 VA: 0x48ED344
	|-GenericCollectionFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref TCollection value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48EC8BC Offset: 0x48E88BC VA: 0x48EC8BC
	|-GenericCollectionFormatter<object, int>.SerializeImplementation
	|
	|-RVA: 0x48EDEC8 Offset: 0x48E9EC8 VA: 0x48EDEC8
	|-GenericCollectionFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
public sealed class WeakGenericCollectionFormatter : WeakBaseFormatter // TypeDefIndex: 22351
{
	// Fields
	private readonly Serializer ValueReaderWriter; // 0x40
	private readonly Type ElementType; // 0x48
	private readonly PropertyInfo CountProperty; // 0x50
	private readonly MethodInfo AddMethod; // 0x58

	// Methods

	// RVA: 0x7EA9A68 Offset: 0x7EA5A68 VA: 0x7EA9A68
	public void .ctor(Type collectionType, Type elementType) { }

	// RVA: 0x7EB0D00 Offset: 0x7EACD00 VA: 0x7EB0D00 Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EB0D0C Offset: 0x7EACD0C VA: 0x7EB0D0C Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EB1790 Offset: 0x7EAD790 VA: 0x7EB1790 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }
}

// Namespace: Sirenix.Serialization
public class HashSetFormatter<T> : BaseFormatter<HashSet<T>> // TypeDefIndex: 22352
{
	// Fields
	private static readonly Serializer<T> TSerializer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4911E9C Offset: 0x490DE9C VA: 0x4911E9C
	|-HashSetFormatter<int>..cctor
	|
	|-RVA: 0x4912C7C Offset: 0x490EC7C VA: 0x4912C7C
	|-HashSetFormatter<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4911FA4 Offset: 0x490DFA4 VA: 0x4911FA4
	|-HashSetFormatter<int>..ctor
	|
	|-RVA: 0x4912DBC Offset: 0x490EDBC VA: 0x4912DBC
	|-HashSetFormatter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override HashSet<T> GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4912000 Offset: 0x490E000 VA: 0x4912000
	|-HashSetFormatter<int>.GetUninitializedObject
	|
	|-RVA: 0x4912E1C Offset: 0x490EE1C VA: 0x4912E1C
	|-HashSetFormatter<__Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref HashSet<T> value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4912008 Offset: 0x490E008 VA: 0x4912008
	|-HashSetFormatter<int>.DeserializeImplementation
	|
	|-RVA: 0x4912E24 Offset: 0x490EE24 VA: 0x4912E24
	|-HashSetFormatter<__Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref HashSet<T> value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49127DC Offset: 0x490E7DC VA: 0x49127DC
	|-HashSetFormatter<int>.SerializeImplementation
	|
	|-RVA: 0x4913684 Offset: 0x490F684 VA: 0x4913684
	|-HashSetFormatter<__Il2CppFullySharedGenericType>.SerializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
public class WeakHashSetFormatter : WeakBaseFormatter // TypeDefIndex: 22353
{
	// Fields
	private readonly Serializer ElementSerializer; // 0x40
	private readonly MethodInfo AddMethod; // 0x48
	private readonly PropertyInfo CountProperty; // 0x50

	// Methods

	// RVA: 0x7EB1CF0 Offset: 0x7EADCF0 VA: 0x7EB1CF0
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EB1FF8 Offset: 0x7EADFF8 VA: 0x7EB1FF8 Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EB2000 Offset: 0x7EAE000 VA: 0x7EB2000 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EB27C0 Offset: 0x7EAE7C0 VA: 0x7EB27C0 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }
}

// Namespace: Sirenix.Serialization
public interface IFormatter // TypeDefIndex: 22354
{
	// Properties
	public abstract Type SerializedType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_SerializedType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Serialize(object value, IDataWriter writer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object Deserialize(IDataReader reader);
}

// Namespace: Sirenix.Serialization
public interface IFormatter<T> : IFormatter // TypeDefIndex: 22355
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Serialize(T value, IDataWriter writer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IFormatter<__Il2CppFullySharedGenericType>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T Deserialize(IDataReader reader);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IFormatter<__Il2CppFullySharedGenericType>.Deserialize
	*/
}

// Namespace: Sirenix.Serialization
public sealed class KeyValuePairFormatter<TKey, TValue> : BaseFormatter<KeyValuePair<TKey, TValue>> // TypeDefIndex: 22356
{
	// Fields
	private static readonly Serializer<TKey> KeySerializer; // 0x0
	private static readonly Serializer<TValue> ValueSerializer; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref KeyValuePair<TKey, TValue> value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF0A1C Offset: 0x4AECA1C VA: 0x4AF0A1C
	|-KeyValuePairFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref KeyValuePair<TKey, TValue> value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF0BE0 Offset: 0x4AECBE0 VA: 0x4AF0BE0
	|-KeyValuePairFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF0E1C Offset: 0x4AECE1C VA: 0x4AF0E1C
	|-KeyValuePairFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AF0E7C Offset: 0x4AECE7C VA: 0x4AF0E7C
	|-KeyValuePairFormatter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Sirenix.Serialization
public sealed class WeakKeyValuePairFormatter : WeakBaseFormatter // TypeDefIndex: 22357
{
	// Fields
	private readonly Serializer KeySerializer; // 0x40
	private readonly Serializer ValueSerializer; // 0x48
	private readonly PropertyInfo KeyProperty; // 0x50
	private readonly PropertyInfo ValueProperty; // 0x58

	// Methods

	// RVA: 0x7EB2E60 Offset: 0x7EAEE60 VA: 0x7EB2E60
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EB2FA4 Offset: 0x7EAEFA4 VA: 0x7EB2FA4 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }

	// RVA: 0x7EB3044 Offset: 0x7EAF044 VA: 0x7EB3044 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }
}

// Namespace: Sirenix.Serialization
public class ListFormatter<T> : BaseFormatter<List<T>> // TypeDefIndex: 22358
{
	// Fields
	private static readonly Serializer<T> TSerializer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B651FC Offset: 0x4B611FC VA: 0x4B651FC
	|-ListFormatter<int>..cctor
	|
	|-RVA: 0x4B65F84 Offset: 0x4B61F84 VA: 0x4B65F84
	|-ListFormatter<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B65304 Offset: 0x4B61304 VA: 0x4B65304
	|-ListFormatter<int>..ctor
	|
	|-RVA: 0x4B660C4 Offset: 0x4B620C4 VA: 0x4B660C4
	|-ListFormatter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override List<T> GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B65360 Offset: 0x4B61360 VA: 0x4B65360
	|-ListFormatter<int>.GetUninitializedObject
	|
	|-RVA: 0x4B66124 Offset: 0x4B62124 VA: 0x4B66124
	|-ListFormatter<__Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref List<T> value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B65368 Offset: 0x4B61368 VA: 0x4B65368
	|-ListFormatter<int>.DeserializeImplementation
	|
	|-RVA: 0x4B6612C Offset: 0x4B6212C VA: 0x4B6612C
	|-ListFormatter<__Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref List<T> value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B65B84 Offset: 0x4B61B84 VA: 0x4B65B84
	|-ListFormatter<int>.SerializeImplementation
	|
	|-RVA: 0x4B66994 Offset: 0x4B62994 VA: 0x4B66994
	|-ListFormatter<__Il2CppFullySharedGenericType>.SerializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
public class WeakListFormatter : WeakBaseFormatter // TypeDefIndex: 22359
{
	// Fields
	private readonly Serializer ElementSerializer; // 0x40

	// Methods

	// RVA: 0x7EB3184 Offset: 0x7EAF184 VA: 0x7EB3184
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EB32A4 Offset: 0x7EAF2A4 VA: 0x7EB32A4 Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EB32AC Offset: 0x7EAF2AC VA: 0x7EB32AC Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EB3B44 Offset: 0x7EAFB44 VA: 0x7EB3B44 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MethodInfoFormatter.<>c<T> // TypeDefIndex: 22360
{
	// Fields
	public static readonly MethodInfoFormatter.<>c<T> <>9; // 0x0
	public static Func<Type, string> <>9__3_0; // 0x0
	public static Func<Type, string> <>9__3_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4823E30 Offset: 0x481FE30 VA: 0x4823E30
	|-MethodInfoFormatter.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4823EEC Offset: 0x481FEEC VA: 0x4823EEC
	|-MethodInfoFormatter.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal string <DeserializeImplementation>b__3_0(Type p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4823EF4 Offset: 0x481FEF4 VA: 0x4823EF4
	|-MethodInfoFormatter.<>c<object>.<DeserializeImplementation>b__3_0
	*/

	// RVA: -1 Offset: -1
	internal string <DeserializeImplementation>b__3_1(Type p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4823F4C Offset: 0x481FF4C VA: 0x4823F4C
	|-MethodInfoFormatter.<>c<object>.<DeserializeImplementation>b__3_1
	*/
}

// Namespace: Sirenix.Serialization
public class MethodInfoFormatter<T> : BaseFormatter<T> // TypeDefIndex: 22361
{
	// Fields
	private static readonly Serializer<string> StringSerializer; // 0x0
	private static readonly Serializer<Type> TypeSerializer; // 0x0
	private static readonly Serializer<Type[]> TypeArraySerializer; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref T value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F2444 Offset: 0x50EE444 VA: 0x50F2444
	|-MethodInfoFormatter<object>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F3FB8 Offset: 0x50EFFB8 VA: 0x50F3FB8
	|-MethodInfoFormatter<object>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override T GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F4574 Offset: 0x50F0574 VA: 0x50F4574
	|-MethodInfoFormatter<object>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F457C Offset: 0x50F057C VA: 0x50F457C
	|-MethodInfoFormatter<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F45D8 Offset: 0x50F05D8 VA: 0x50F45D8
	|-MethodInfoFormatter<object>..cctor
	*/
}

// Namespace: Sirenix.Serialization
public class WeakMethodInfoFormatter : MethodInfoFormatter<MethodInfo> // TypeDefIndex: 22362
{
	// Methods

	// RVA: 0x7EB402C Offset: 0x7EB002C VA: 0x7EB402C
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public abstract class MinimalBaseFormatter<T> : IFormatter<T>, IFormatter // TypeDefIndex: 22363
{
	// Fields
	protected static readonly bool IsValueType; // 0x0

	// Properties
	public Type SerializedType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public Type get_SerializedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F4AFC Offset: 0x50F0AFC VA: 0x50F4AFC
	|-MinimalBaseFormatter<Bounds>.get_SerializedType
	|
	|-RVA: 0x50F51A0 Offset: 0x50F11A0 VA: 0x50F51A0
	|-MinimalBaseFormatter<Color>.get_SerializedType
	|
	|-RVA: 0x50F5850 Offset: 0x50F1850 VA: 0x50F5850
	|-MinimalBaseFormatter<Color32>.get_SerializedType
	|
	|-RVA: 0x50F5E7C Offset: 0x50F1E7C VA: 0x50F5E7C
	|-MinimalBaseFormatter<DateTime>.get_SerializedType
	|
	|-RVA: 0x50F64AC Offset: 0x50F24AC VA: 0x50F64AC
	|-MinimalBaseFormatter<DateTimeOffset>.get_SerializedType
	|
	|-RVA: 0x50F6B20 Offset: 0x50F2B20 VA: 0x50F6B20
	|-MinimalBaseFormatter<GradientAlphaKey>.get_SerializedType
	|
	|-RVA: 0x50F7174 Offset: 0x50F3174 VA: 0x50F7174
	|-MinimalBaseFormatter<GradientColorKey>.get_SerializedType
	|
	|-RVA: 0x50F7818 Offset: 0x50F3818 VA: 0x50F7818
	|-MinimalBaseFormatter<Keyframe>.get_SerializedType
	|
	|-RVA: 0x50F7ED4 Offset: 0x50F3ED4 VA: 0x50F7ED4
	|-MinimalBaseFormatter<LayerMask>.get_SerializedType
	|
	|-RVA: 0x50F8500 Offset: 0x50F4500 VA: 0x50F8500
	|-MinimalBaseFormatter<object>.get_SerializedType
	|
	|-RVA: 0x50F8AD4 Offset: 0x50F4AD4 VA: 0x50F8AD4
	|-MinimalBaseFormatter<Quaternion>.get_SerializedType
	|
	|-RVA: 0x50F9184 Offset: 0x50F5184 VA: 0x50F9184
	|-MinimalBaseFormatter<Rect>.get_SerializedType
	|
	|-RVA: 0x50F9834 Offset: 0x50F5834 VA: 0x50F9834
	|-MinimalBaseFormatter<TimeSpan>.get_SerializedType
	|
	|-RVA: 0x50F9E64 Offset: 0x50F5E64 VA: 0x50F9E64
	|-MinimalBaseFormatter<Vector2>.get_SerializedType
	|
	|-RVA: 0x50FA4B8 Offset: 0x50F64B8 VA: 0x50FA4B8
	|-MinimalBaseFormatter<Vector2Int>.get_SerializedType
	|
	|-RVA: 0x50FAAE8 Offset: 0x50F6AE8 VA: 0x50FAAE8
	|-MinimalBaseFormatter<Vector3>.get_SerializedType
	|
	|-RVA: 0x50FB194 Offset: 0x50F7194 VA: 0x50FB194
	|-MinimalBaseFormatter<Vector3Int>.get_SerializedType
	|
	|-RVA: 0x50FB828 Offset: 0x50F7828 VA: 0x50FB828
	|-MinimalBaseFormatter<Vector4>.get_SerializedType
	|
	|-RVA: 0x50FBED8 Offset: 0x50F7ED8 VA: 0x50FBED8
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>.get_SerializedType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T Deserialize(IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F4B60 Offset: 0x50F0B60 VA: 0x50F4B60
	|-MinimalBaseFormatter<Bounds>.Deserialize
	|
	|-RVA: 0x50F5204 Offset: 0x50F1204 VA: 0x50F5204
	|-MinimalBaseFormatter<Color>.Deserialize
	|
	|-RVA: 0x50F58B4 Offset: 0x50F18B4 VA: 0x50F58B4
	|-MinimalBaseFormatter<Color32>.Deserialize
	|
	|-RVA: 0x50F5EE0 Offset: 0x50F1EE0 VA: 0x50F5EE0
	|-MinimalBaseFormatter<DateTime>.Deserialize
	|
	|-RVA: 0x50F6510 Offset: 0x50F2510 VA: 0x50F6510
	|-MinimalBaseFormatter<DateTimeOffset>.Deserialize
	|
	|-RVA: 0x50F6B84 Offset: 0x50F2B84 VA: 0x50F6B84
	|-MinimalBaseFormatter<GradientAlphaKey>.Deserialize
	|
	|-RVA: 0x50F71D8 Offset: 0x50F31D8 VA: 0x50F71D8
	|-MinimalBaseFormatter<GradientColorKey>.Deserialize
	|
	|-RVA: 0x50F787C Offset: 0x50F387C VA: 0x50F787C
	|-MinimalBaseFormatter<Keyframe>.Deserialize
	|
	|-RVA: 0x50F7F38 Offset: 0x50F3F38 VA: 0x50F7F38
	|-MinimalBaseFormatter<LayerMask>.Deserialize
	|
	|-RVA: 0x50F8564 Offset: 0x50F4564 VA: 0x50F8564
	|-MinimalBaseFormatter<object>.Deserialize
	|
	|-RVA: 0x50F8B38 Offset: 0x50F4B38 VA: 0x50F8B38
	|-MinimalBaseFormatter<Quaternion>.Deserialize
	|
	|-RVA: 0x50F91E8 Offset: 0x50F51E8 VA: 0x50F91E8
	|-MinimalBaseFormatter<Rect>.Deserialize
	|
	|-RVA: 0x50F9898 Offset: 0x50F5898 VA: 0x50F9898
	|-MinimalBaseFormatter<TimeSpan>.Deserialize
	|
	|-RVA: 0x50F9EC8 Offset: 0x50F5EC8 VA: 0x50F9EC8
	|-MinimalBaseFormatter<Vector2>.Deserialize
	|
	|-RVA: 0x50FA51C Offset: 0x50F651C VA: 0x50FA51C
	|-MinimalBaseFormatter<Vector2Int>.Deserialize
	|
	|-RVA: 0x50FAB4C Offset: 0x50F6B4C VA: 0x50FAB4C
	|-MinimalBaseFormatter<Vector3>.Deserialize
	|
	|-RVA: 0x50FB1F8 Offset: 0x50F71F8 VA: 0x50FB1F8
	|-MinimalBaseFormatter<Vector3Int>.Deserialize
	|
	|-RVA: 0x50FB88C Offset: 0x50F788C VA: 0x50FB88C
	|-MinimalBaseFormatter<Vector4>.Deserialize
	|
	|-RVA: 0x50FBF3C Offset: 0x50F7F3C VA: 0x50FBF3C
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>.Deserialize
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Serialize(T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F4C5C Offset: 0x50F0C5C VA: 0x50F4C5C
	|-MinimalBaseFormatter<Bounds>.Serialize
	|
	|-RVA: 0x50F52F4 Offset: 0x50F12F4 VA: 0x50F52F4
	|-MinimalBaseFormatter<Color>.Serialize
	|
	|-RVA: 0x50F5970 Offset: 0x50F1970 VA: 0x50F5970
	|-MinimalBaseFormatter<Color32>.Serialize
	|
	|-RVA: 0x50F5FA0 Offset: 0x50F1FA0 VA: 0x50F5FA0
	|-MinimalBaseFormatter<DateTime>.Serialize
	|
	|-RVA: 0x50F65E0 Offset: 0x50F25E0 VA: 0x50F65E0
	|-MinimalBaseFormatter<DateTimeOffset>.Serialize
	|
	|-RVA: 0x50F6C54 Offset: 0x50F2C54 VA: 0x50F6C54
	|-MinimalBaseFormatter<GradientAlphaKey>.Serialize
	|
	|-RVA: 0x50F72D4 Offset: 0x50F32D4 VA: 0x50F72D4
	|-MinimalBaseFormatter<GradientColorKey>.Serialize
	|
	|-RVA: 0x50F7984 Offset: 0x50F3984 VA: 0x50F7984
	|-MinimalBaseFormatter<Keyframe>.Serialize
	|
	|-RVA: 0x50F7FF4 Offset: 0x50F3FF4 VA: 0x50F7FF4
	|-MinimalBaseFormatter<LayerMask>.Serialize
	|
	|-RVA: 0x50F8628 Offset: 0x50F4628 VA: 0x50F8628
	|-MinimalBaseFormatter<object>.Serialize
	|
	|-RVA: 0x50F8C28 Offset: 0x50F4C28 VA: 0x50F8C28
	|-MinimalBaseFormatter<Quaternion>.Serialize
	|
	|-RVA: 0x50F92D8 Offset: 0x50F52D8 VA: 0x50F92D8
	|-MinimalBaseFormatter<Rect>.Serialize
	|
	|-RVA: 0x50F9958 Offset: 0x50F5958 VA: 0x50F9958
	|-MinimalBaseFormatter<TimeSpan>.Serialize
	|
	|-RVA: 0x50F9F98 Offset: 0x50F5F98 VA: 0x50F9F98
	|-MinimalBaseFormatter<Vector2>.Serialize
	|
	|-RVA: 0x50FA5DC Offset: 0x50F65DC VA: 0x50FA5DC
	|-MinimalBaseFormatter<Vector2Int>.Serialize
	|
	|-RVA: 0x50FAC38 Offset: 0x50F6C38 VA: 0x50FAC38
	|-MinimalBaseFormatter<Vector3>.Serialize
	|
	|-RVA: 0x50FB2D4 Offset: 0x50F72D4 VA: 0x50FB2D4
	|-MinimalBaseFormatter<Vector3Int>.Serialize
	|
	|-RVA: 0x50FB97C Offset: 0x50F797C VA: 0x50FB97C
	|-MinimalBaseFormatter<Vector4>.Serialize
	|
	|-RVA: 0x50FC108 Offset: 0x50F8108 VA: 0x50FC108
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void Sirenix.Serialization.IFormatter.Serialize(object value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F4C68 Offset: 0x50F0C68 VA: 0x50F4C68
	|-MinimalBaseFormatter<Bounds>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F5324 Offset: 0x50F1324 VA: 0x50F5324
	|-MinimalBaseFormatter<Color>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F5990 Offset: 0x50F1990 VA: 0x50F5990
	|-MinimalBaseFormatter<Color32>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F5FC0 Offset: 0x50F1FC0 VA: 0x50F5FC0
	|-MinimalBaseFormatter<DateTime>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F6610 Offset: 0x50F2610 VA: 0x50F6610
	|-MinimalBaseFormatter<DateTimeOffset>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F6C78 Offset: 0x50F2C78 VA: 0x50F6C78
	|-MinimalBaseFormatter<GradientAlphaKey>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F72E0 Offset: 0x50F32E0 VA: 0x50F72E0
	|-MinimalBaseFormatter<GradientColorKey>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F7990 Offset: 0x50F3990 VA: 0x50F7990
	|-MinimalBaseFormatter<Keyframe>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F8014 Offset: 0x50F4014 VA: 0x50F8014
	|-MinimalBaseFormatter<LayerMask>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F8648 Offset: 0x50F4648 VA: 0x50F8648
	|-MinimalBaseFormatter<object>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F8C58 Offset: 0x50F4C58 VA: 0x50F8C58
	|-MinimalBaseFormatter<Quaternion>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F9308 Offset: 0x50F5308 VA: 0x50F9308
	|-MinimalBaseFormatter<Rect>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F9978 Offset: 0x50F5978 VA: 0x50F9978
	|-MinimalBaseFormatter<TimeSpan>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50F9FBC Offset: 0x50F5FBC VA: 0x50F9FBC
	|-MinimalBaseFormatter<Vector2>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50FA5FC Offset: 0x50F65FC VA: 0x50FA5FC
	|-MinimalBaseFormatter<Vector2Int>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50FAC68 Offset: 0x50F6C68 VA: 0x50FAC68
	|-MinimalBaseFormatter<Vector3>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50FB308 Offset: 0x50F7308 VA: 0x50FB308
	|-MinimalBaseFormatter<Vector3Int>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50FB9AC Offset: 0x50F79AC VA: 0x50FB9AC
	|-MinimalBaseFormatter<Vector4>.Sirenix.Serialization.IFormatter.Serialize
	|
	|-RVA: 0x50FC140 Offset: 0x50F8140 VA: 0x50FC140
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>.Sirenix.Serialization.IFormatter.Serialize
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object Sirenix.Serialization.IFormatter.Deserialize(IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F4D38 Offset: 0x50F0D38 VA: 0x50F4D38
	|-MinimalBaseFormatter<Bounds>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F53EC Offset: 0x50F13EC VA: 0x50F53EC
	|-MinimalBaseFormatter<Color>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F5A50 Offset: 0x50F1A50 VA: 0x50F5A50
	|-MinimalBaseFormatter<Color32>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F6080 Offset: 0x50F2080 VA: 0x50F6080
	|-MinimalBaseFormatter<DateTime>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F66D8 Offset: 0x50F26D8 VA: 0x50F66D8
	|-MinimalBaseFormatter<DateTimeOffset>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F6D38 Offset: 0x50F2D38 VA: 0x50F6D38
	|-MinimalBaseFormatter<GradientAlphaKey>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F73B0 Offset: 0x50F33B0 VA: 0x50F73B0
	|-MinimalBaseFormatter<GradientColorKey>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F7A68 Offset: 0x50F3A68 VA: 0x50F7A68
	|-MinimalBaseFormatter<Keyframe>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F80D4 Offset: 0x50F40D4 VA: 0x50F80D4
	|-MinimalBaseFormatter<LayerMask>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F8700 Offset: 0x50F4700 VA: 0x50F8700
	|-MinimalBaseFormatter<object>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F8D20 Offset: 0x50F4D20 VA: 0x50F8D20
	|-MinimalBaseFormatter<Quaternion>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F93D0 Offset: 0x50F53D0 VA: 0x50F93D0
	|-MinimalBaseFormatter<Rect>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50F9A38 Offset: 0x50F5A38 VA: 0x50F9A38
	|-MinimalBaseFormatter<TimeSpan>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50FA07C Offset: 0x50F607C VA: 0x50FA07C
	|-MinimalBaseFormatter<Vector2>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50FA6BC Offset: 0x50F66BC VA: 0x50FA6BC
	|-MinimalBaseFormatter<Vector2Int>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50FAD38 Offset: 0x50F6D38 VA: 0x50FAD38
	|-MinimalBaseFormatter<Vector3>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50FB3D8 Offset: 0x50F73D8 VA: 0x50FB3D8
	|-MinimalBaseFormatter<Vector3Int>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50FBA74 Offset: 0x50F7A74 VA: 0x50FBA74
	|-MinimalBaseFormatter<Vector4>.Sirenix.Serialization.IFormatter.Deserialize
	|
	|-RVA: 0x50FC24C Offset: 0x50F824C VA: 0x50FC24C
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>.Sirenix.Serialization.IFormatter.Deserialize
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual T GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F4D88 Offset: 0x50F0D88 VA: 0x50F4D88
	|-MinimalBaseFormatter<Bounds>.GetUninitializedObject
	|
	|-RVA: 0x50F5430 Offset: 0x50F1430 VA: 0x50F5430
	|-MinimalBaseFormatter<Color>.GetUninitializedObject
	|
	|-RVA: 0x50F5A90 Offset: 0x50F1A90 VA: 0x50F5A90
	|-MinimalBaseFormatter<Color32>.GetUninitializedObject
	|
	|-RVA: 0x50F60C0 Offset: 0x50F20C0 VA: 0x50F60C0
	|-MinimalBaseFormatter<DateTime>.GetUninitializedObject
	|
	|-RVA: 0x50F6718 Offset: 0x50F2718 VA: 0x50F6718
	|-MinimalBaseFormatter<DateTimeOffset>.GetUninitializedObject
	|
	|-RVA: 0x50F6D78 Offset: 0x50F2D78 VA: 0x50F6D78
	|-MinimalBaseFormatter<GradientAlphaKey>.GetUninitializedObject
	|
	|-RVA: 0x50F7400 Offset: 0x50F3400 VA: 0x50F7400
	|-MinimalBaseFormatter<GradientColorKey>.GetUninitializedObject
	|
	|-RVA: 0x50F7AB8 Offset: 0x50F3AB8 VA: 0x50F7AB8
	|-MinimalBaseFormatter<Keyframe>.GetUninitializedObject
	|
	|-RVA: 0x50F8114 Offset: 0x50F4114 VA: 0x50F8114
	|-MinimalBaseFormatter<LayerMask>.GetUninitializedObject
	|
	|-RVA: 0x50F8710 Offset: 0x50F4710 VA: 0x50F8710
	|-MinimalBaseFormatter<object>.GetUninitializedObject
	|
	|-RVA: 0x50F8D64 Offset: 0x50F4D64 VA: 0x50F8D64
	|-MinimalBaseFormatter<Quaternion>.GetUninitializedObject
	|
	|-RVA: 0x50F9414 Offset: 0x50F5414 VA: 0x50F9414
	|-MinimalBaseFormatter<Rect>.GetUninitializedObject
	|
	|-RVA: 0x50F9A78 Offset: 0x50F5A78 VA: 0x50F9A78
	|-MinimalBaseFormatter<TimeSpan>.GetUninitializedObject
	|
	|-RVA: 0x50FA0BC Offset: 0x50F60BC VA: 0x50FA0BC
	|-MinimalBaseFormatter<Vector2>.GetUninitializedObject
	|
	|-RVA: 0x50FA6FC Offset: 0x50F66FC VA: 0x50FA6FC
	|-MinimalBaseFormatter<Vector2Int>.GetUninitializedObject
	|
	|-RVA: 0x50FAD7C Offset: 0x50F6D7C VA: 0x50FAD7C
	|-MinimalBaseFormatter<Vector3>.GetUninitializedObject
	|
	|-RVA: 0x50FB41C Offset: 0x50F741C VA: 0x50FB41C
	|-MinimalBaseFormatter<Vector3Int>.GetUninitializedObject
	|
	|-RVA: 0x50FBAB8 Offset: 0x50F7AB8 VA: 0x50FBAB8
	|-MinimalBaseFormatter<Vector4>.GetUninitializedObject
	|
	|-RVA: 0x50FC2F4 Offset: 0x50F82F4 VA: 0x50FC2F4
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void Read(ref T value, IDataReader reader);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>.Read
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void Write(ref T value, IDataWriter writer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>.Write
	*/

	// RVA: -1 Offset: -1
	protected void RegisterReferenceID(T value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F4EDC Offset: 0x50F0EDC VA: 0x50F4EDC
	|-MinimalBaseFormatter<Bounds>.RegisterReferenceID
	|
	|-RVA: 0x50F557C Offset: 0x50F157C VA: 0x50F557C
	|-MinimalBaseFormatter<Color>.RegisterReferenceID
	|
	|-RVA: 0x50F5BD0 Offset: 0x50F1BD0 VA: 0x50F5BD0
	|-MinimalBaseFormatter<Color32>.RegisterReferenceID
	|
	|-RVA: 0x50F6200 Offset: 0x50F2200 VA: 0x50F6200
	|-MinimalBaseFormatter<DateTime>.RegisterReferenceID
	|
	|-RVA: 0x50F6864 Offset: 0x50F2864 VA: 0x50F6864
	|-MinimalBaseFormatter<DateTimeOffset>.RegisterReferenceID
	|
	|-RVA: 0x50F6EB8 Offset: 0x50F2EB8 VA: 0x50F6EB8
	|-MinimalBaseFormatter<GradientAlphaKey>.RegisterReferenceID
	|
	|-RVA: 0x50F7554 Offset: 0x50F3554 VA: 0x50F7554
	|-MinimalBaseFormatter<GradientColorKey>.RegisterReferenceID
	|
	|-RVA: 0x50F7C10 Offset: 0x50F3C10 VA: 0x50F7C10
	|-MinimalBaseFormatter<Keyframe>.RegisterReferenceID
	|
	|-RVA: 0x50F8254 Offset: 0x50F4254 VA: 0x50F8254
	|-MinimalBaseFormatter<LayerMask>.RegisterReferenceID
	|
	|-RVA: 0x50F8844 Offset: 0x50F4844 VA: 0x50F8844
	|-MinimalBaseFormatter<object>.RegisterReferenceID
	|
	|-RVA: 0x50F8EB0 Offset: 0x50F4EB0 VA: 0x50F8EB0
	|-MinimalBaseFormatter<Quaternion>.RegisterReferenceID
	|
	|-RVA: 0x50F9560 Offset: 0x50F5560 VA: 0x50F9560
	|-MinimalBaseFormatter<Rect>.RegisterReferenceID
	|
	|-RVA: 0x50F9BB8 Offset: 0x50F5BB8 VA: 0x50F9BB8
	|-MinimalBaseFormatter<TimeSpan>.RegisterReferenceID
	|
	|-RVA: 0x50FA1FC Offset: 0x50F61FC VA: 0x50FA1FC
	|-MinimalBaseFormatter<Vector2>.RegisterReferenceID
	|
	|-RVA: 0x50FA83C Offset: 0x50F683C VA: 0x50FA83C
	|-MinimalBaseFormatter<Vector2Int>.RegisterReferenceID
	|
	|-RVA: 0x50FAEC4 Offset: 0x50F6EC4 VA: 0x50FAEC4
	|-MinimalBaseFormatter<Vector3>.RegisterReferenceID
	|
	|-RVA: 0x50FB568 Offset: 0x50F7568 VA: 0x50FB568
	|-MinimalBaseFormatter<Vector3Int>.RegisterReferenceID
	|
	|-RVA: 0x50FBC04 Offset: 0x50F7C04 VA: 0x50FBC04
	|-MinimalBaseFormatter<Vector4>.RegisterReferenceID
	|
	|-RVA: 0x50FC4C8 Offset: 0x50F84C8 VA: 0x50FC4C8
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>.RegisterReferenceID
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F50D4 Offset: 0x50F10D4 VA: 0x50F50D4
	|-MinimalBaseFormatter<Bounds>..ctor
	|
	|-RVA: 0x50F5784 Offset: 0x50F1784 VA: 0x50F5784
	|-MinimalBaseFormatter<Color>..ctor
	|
	|-RVA: 0x50F5DB0 Offset: 0x50F1DB0 VA: 0x50F5DB0
	|-MinimalBaseFormatter<Color32>..ctor
	|
	|-RVA: 0x50F63E0 Offset: 0x50F23E0 VA: 0x50F63E0
	|-MinimalBaseFormatter<DateTime>..ctor
	|
	|-RVA: 0x50F6A54 Offset: 0x50F2A54 VA: 0x50F6A54
	|-MinimalBaseFormatter<DateTimeOffset>..ctor
	|
	|-RVA: 0x50F70A8 Offset: 0x50F30A8 VA: 0x50F70A8
	|-MinimalBaseFormatter<GradientAlphaKey>..ctor
	|
	|-RVA: 0x50F774C Offset: 0x50F374C VA: 0x50F774C
	|-MinimalBaseFormatter<GradientColorKey>..ctor
	|
	|-RVA: 0x50F7E08 Offset: 0x50F3E08 VA: 0x50F7E08
	|-MinimalBaseFormatter<Keyframe>..ctor
	|
	|-RVA: 0x50F8434 Offset: 0x50F4434 VA: 0x50F8434
	|-MinimalBaseFormatter<LayerMask>..ctor
	|
	|-RVA: 0x50F8A08 Offset: 0x50F4A08 VA: 0x50F8A08
	|-MinimalBaseFormatter<object>..ctor
	|
	|-RVA: 0x50F90B8 Offset: 0x50F50B8 VA: 0x50F90B8
	|-MinimalBaseFormatter<Quaternion>..ctor
	|
	|-RVA: 0x50F9768 Offset: 0x50F5768 VA: 0x50F9768
	|-MinimalBaseFormatter<Rect>..ctor
	|
	|-RVA: 0x50F9D98 Offset: 0x50F5D98 VA: 0x50F9D98
	|-MinimalBaseFormatter<TimeSpan>..ctor
	|
	|-RVA: 0x50FA3EC Offset: 0x50F63EC VA: 0x50FA3EC
	|-MinimalBaseFormatter<Vector2>..ctor
	|
	|-RVA: 0x50FAA1C Offset: 0x50F6A1C VA: 0x50FAA1C
	|-MinimalBaseFormatter<Vector2Int>..ctor
	|
	|-RVA: 0x50FB0C8 Offset: 0x50F70C8 VA: 0x50FB0C8
	|-MinimalBaseFormatter<Vector3>..ctor
	|
	|-RVA: 0x50FB75C Offset: 0x50F775C VA: 0x50FB75C
	|-MinimalBaseFormatter<Vector3Int>..ctor
	|
	|-RVA: 0x50FBE0C Offset: 0x50F7E0C VA: 0x50FBE0C
	|-MinimalBaseFormatter<Vector4>..ctor
	|
	|-RVA: 0x50FC718 Offset: 0x50F8718 VA: 0x50FC718
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F50DC Offset: 0x50F10DC VA: 0x50F50DC
	|-MinimalBaseFormatter<Bounds>..cctor
	|
	|-RVA: 0x50F578C Offset: 0x50F178C VA: 0x50F578C
	|-MinimalBaseFormatter<Color>..cctor
	|
	|-RVA: 0x50F5DB8 Offset: 0x50F1DB8 VA: 0x50F5DB8
	|-MinimalBaseFormatter<Color32>..cctor
	|
	|-RVA: 0x50F63E8 Offset: 0x50F23E8 VA: 0x50F63E8
	|-MinimalBaseFormatter<DateTime>..cctor
	|
	|-RVA: 0x50F6A5C Offset: 0x50F2A5C VA: 0x50F6A5C
	|-MinimalBaseFormatter<DateTimeOffset>..cctor
	|
	|-RVA: 0x50F70B0 Offset: 0x50F30B0 VA: 0x50F70B0
	|-MinimalBaseFormatter<GradientAlphaKey>..cctor
	|
	|-RVA: 0x50F7754 Offset: 0x50F3754 VA: 0x50F7754
	|-MinimalBaseFormatter<GradientColorKey>..cctor
	|
	|-RVA: 0x50F7E10 Offset: 0x50F3E10 VA: 0x50F7E10
	|-MinimalBaseFormatter<Keyframe>..cctor
	|
	|-RVA: 0x50F843C Offset: 0x50F443C VA: 0x50F843C
	|-MinimalBaseFormatter<LayerMask>..cctor
	|
	|-RVA: 0x50F8A10 Offset: 0x50F4A10 VA: 0x50F8A10
	|-MinimalBaseFormatter<object>..cctor
	|
	|-RVA: 0x50F90C0 Offset: 0x50F50C0 VA: 0x50F90C0
	|-MinimalBaseFormatter<Quaternion>..cctor
	|
	|-RVA: 0x50F9770 Offset: 0x50F5770 VA: 0x50F9770
	|-MinimalBaseFormatter<Rect>..cctor
	|
	|-RVA: 0x50F9DA0 Offset: 0x50F5DA0 VA: 0x50F9DA0
	|-MinimalBaseFormatter<TimeSpan>..cctor
	|
	|-RVA: 0x50FA3F4 Offset: 0x50F63F4 VA: 0x50FA3F4
	|-MinimalBaseFormatter<Vector2>..cctor
	|
	|-RVA: 0x50FAA24 Offset: 0x50F6A24 VA: 0x50FAA24
	|-MinimalBaseFormatter<Vector2Int>..cctor
	|
	|-RVA: 0x50FB0D0 Offset: 0x50F70D0 VA: 0x50FB0D0
	|-MinimalBaseFormatter<Vector3>..cctor
	|
	|-RVA: 0x50FB764 Offset: 0x50F7764 VA: 0x50FB764
	|-MinimalBaseFormatter<Vector3Int>..cctor
	|
	|-RVA: 0x50FBE14 Offset: 0x50F7E14 VA: 0x50FBE14
	|-MinimalBaseFormatter<Vector4>..cctor
	|
	|-RVA: 0x50FC720 Offset: 0x50F8720 VA: 0x50FC720
	|-MinimalBaseFormatter<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Sirenix.Serialization
public abstract class WeakMinimalBaseFormatter : IFormatter // TypeDefIndex: 22364
{
	// Fields
	protected readonly Type SerializedType; // 0x10
	protected readonly bool IsValueType; // 0x18

	// Properties
	private Type Sirenix.Serialization.IFormatter.SerializedType { get; }

	// Methods

	// RVA: 0x7EB4098 Offset: 0x7EB0098 VA: 0x7EB4098 Slot: 4
	private Type Sirenix.Serialization.IFormatter.get_SerializedType() { }

	// RVA: 0x7EB40A0 Offset: 0x7EB00A0 VA: 0x7EB40A0
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EB40F4 Offset: 0x7EB00F4 VA: 0x7EB40F4 Slot: 6
	public object Deserialize(IDataReader reader) { }

	// RVA: 0x7EB42E4 Offset: 0x7EB02E4 VA: 0x7EB42E4 Slot: 5
	public void Serialize(object value, IDataWriter writer) { }

	// RVA: 0x7EB4304 Offset: 0x7EB0304 VA: 0x7EB4304 Slot: 7
	protected virtual object GetUninitializedObject() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void Read(ref object value, IDataReader reader);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Write(ref object value, IDataWriter writer);

	// RVA: 0x7EB4160 Offset: 0x7EB0160 VA: 0x7EB4160
	protected void RegisterReferenceID(object value, IDataReader reader) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MultiDimensionalArrayFormatter.<>c__DisplayClass6_0<TArray, TElement> // TypeDefIndex: 22365
{
	// Fields
	public IDataReader reader; // 0x0
	public string name; // 0x0
	public int elements; // 0x0
	public long length; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545C418 Offset: 0x5458418 VA: 0x545C418
	|-MultiDimensionalArrayFormatter.<>c__DisplayClass6_0<object, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement <DeserializeImplementation>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545C420 Offset: 0x5458420 VA: 0x545C420
	|-MultiDimensionalArrayFormatter.<>c__DisplayClass6_0<object, __Il2CppFullySharedGenericType>.<DeserializeImplementation>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class MultiDimensionalArrayFormatter.<>c__DisplayClass7_0<TArray, TElement> // TypeDefIndex: 22366
{
	// Fields
	public IDataWriter writer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545F8D0 Offset: 0x545B8D0 VA: 0x545F8D0
	|-MultiDimensionalArrayFormatter.<>c__DisplayClass7_0<object, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <SerializeImplementation>b__0(TElement v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545F8D8 Offset: 0x545B8D8 VA: 0x545F8D8
	|-MultiDimensionalArrayFormatter.<>c__DisplayClass7_0<object, __Il2CppFullySharedGenericType>.<SerializeImplementation>b__0
	*/
}

// Namespace: Sirenix.Serialization
public sealed class MultiDimensionalArrayFormatter<TArray, TElement> : BaseFormatter<TArray> // TypeDefIndex: 22367
{
	// Fields
	private const string RANKS_NAME = "ranks";
	private const char RANKS_SEPARATOR = '\x7c';
	private static readonly int ArrayRank; // 0x0
	private static readonly Serializer<TElement> ValueReaderWriter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51029B0 Offset: 0x50FE9B0 VA: 0x51029B0
	|-MultiDimensionalArrayFormatter<object, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override TArray GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5102EBC Offset: 0x50FEEBC VA: 0x5102EBC
	|-MultiDimensionalArrayFormatter<object, __Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref TArray value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5102EC4 Offset: 0x50FEEC4 VA: 0x5102EC4
	|-MultiDimensionalArrayFormatter<object, __Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref TArray value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51037B0 Offset: 0x50FF7B0 VA: 0x51037B0
	|-MultiDimensionalArrayFormatter<object, __Il2CppFullySharedGenericType>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1
	private void IterateArrayWrite(Array a, Func<TElement> write) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5103DF8 Offset: 0x50FFDF8 VA: 0x5103DF8
	|-MultiDimensionalArrayFormatter<object, __Il2CppFullySharedGenericType>.IterateArrayWrite
	*/

	// RVA: -1 Offset: -1
	private void IterateArrayWrite(Array a, int rank, int[] indices, Func<TElement> write) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5103EBC Offset: 0x50FFEBC VA: 0x5103EBC
	|-MultiDimensionalArrayFormatter<object, __Il2CppFullySharedGenericType>.IterateArrayWrite
	*/

	// RVA: -1 Offset: -1
	private void IterateArrayRead(Array a, Action<TElement> read) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5104058 Offset: 0x5100058 VA: 0x5104058
	|-MultiDimensionalArrayFormatter<object, __Il2CppFullySharedGenericType>.IterateArrayRead
	*/

	// RVA: -1 Offset: -1
	private void IterateArrayRead(Array a, int rank, int[] indices, Action<TElement> read) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x510411C Offset: 0x510011C VA: 0x510411C
	|-MultiDimensionalArrayFormatter<object, __Il2CppFullySharedGenericType>.IterateArrayRead
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51042E0 Offset: 0x51002E0 VA: 0x51042E0
	|-MultiDimensionalArrayFormatter<object, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class WeakMultiDimensionalArrayFormatter.<>c__DisplayClass7_0 // TypeDefIndex: 22368
{
	// Fields
	public IDataReader reader; // 0x10
	public string name; // 0x18
	public WeakMultiDimensionalArrayFormatter <>4__this; // 0x20
	public int elements; // 0x28
	public long length; // 0x30

	// Methods

	// RVA: 0x7EB4B94 Offset: 0x7EB0B94 VA: 0x7EB4B94
	public void .ctor() { }

	// RVA: 0x7EB53E8 Offset: 0x7EB13E8 VA: 0x7EB53E8
	internal object <DeserializeImplementation>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WeakMultiDimensionalArrayFormatter.<>c__DisplayClass8_0 // TypeDefIndex: 22369
{
	// Fields
	public WeakMultiDimensionalArrayFormatter <>4__this; // 0x10
	public IDataWriter writer; // 0x18

	// Methods

	// RVA: 0x7EB5178 Offset: 0x7EB1178 VA: 0x7EB5178
	public void .ctor() { }

	// RVA: 0x7EB5764 Offset: 0x7EB1764 VA: 0x7EB5764
	internal void <SerializeImplementation>b__0(object v) { }
}

// Namespace: Sirenix.Serialization
public sealed class WeakMultiDimensionalArrayFormatter : WeakBaseFormatter // TypeDefIndex: 22370
{
	// Fields
	private const string RANKS_NAME = "ranks";
	private const char RANKS_SEPARATOR = '\x7c';
	private readonly int ArrayRank; // 0x3C
	private readonly Type ElementType; // 0x40
	private readonly Serializer ValueReaderWriter; // 0x48

	// Methods

	// RVA: 0x7EA474C Offset: 0x7EA074C VA: 0x7EA474C
	public void .ctor(Type arrayType, Type elementType) { }

	// RVA: 0x7EB437C Offset: 0x7EB037C VA: 0x7EB437C Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EB4384 Offset: 0x7EB0384 VA: 0x7EB4384 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EB4C0C Offset: 0x7EB0C0C VA: 0x7EB4C0C Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }

	// RVA: 0x7EB4B9C Offset: 0x7EB0B9C VA: 0x7EB4B9C
	private void IterateArrayWrite(Array a, Func<object> write) { }

	// RVA: 0x7EB51F0 Offset: 0x7EB11F0 VA: 0x7EB51F0
	private void IterateArrayWrite(Array a, int rank, int[] indices, Func<object> write) { }

	// RVA: 0x7EB5180 Offset: 0x7EB1180 VA: 0x7EB5180
	private void IterateArrayRead(Array a, Action<object> read) { }

	// RVA: 0x7EB52EC Offset: 0x7EB12EC VA: 0x7EB52EC
	private void IterateArrayRead(Array a, int rank, int[] indices, Action<object> read) { }
}

// Namespace: Sirenix.Serialization
public sealed class NullableFormatter<T> : BaseFormatter<Nullable<T>> // TypeDefIndex: 22371
{
	// Fields
	private static readonly Serializer<T> TSerializer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512BB98 Offset: 0x5127B98 VA: 0x512BB98
	|-NullableFormatter<int>..cctor
	|
	|-RVA: 0x512BFC8 Offset: 0x5127FC8 VA: 0x512BFC8
	|-NullableFormatter<__Il2CppFullySharedGenericStructType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512BCA0 Offset: 0x5127CA0 VA: 0x512BCA0
	|-NullableFormatter<int>..ctor
	|
	|-RVA: 0x512C108 Offset: 0x5128108 VA: 0x512C108
	|-NullableFormatter<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref Nullable<T> value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512BCFC Offset: 0x5127CFC VA: 0x512BCFC
	|-NullableFormatter<int>.DeserializeImplementation
	|
	|-RVA: 0x512C168 Offset: 0x5128168 VA: 0x512C168
	|-NullableFormatter<__Il2CppFullySharedGenericStructType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref Nullable<T> value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512BE8C Offset: 0x5127E8C VA: 0x512BE8C
	|-NullableFormatter<int>.SerializeImplementation
	|
	|-RVA: 0x512C400 Offset: 0x5128400 VA: 0x512C400
	|-NullableFormatter<__Il2CppFullySharedGenericStructType>.SerializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
public sealed class WeakNullableFormatter : WeakBaseFormatter // TypeDefIndex: 22372
{
	// Fields
	private readonly Serializer ValueSerializer; // 0x40

	// Methods

	// RVA: 0x7EB5790 Offset: 0x7EB1790 VA: 0x7EB5790
	public void .ctor(Type nullableType) { }

	// RVA: 0x7EB583C Offset: 0x7EB183C VA: 0x7EB583C Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EB599C Offset: 0x7EB199C VA: 0x7EB599C Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }

	// RVA: 0x7EB5A78 Offset: 0x7EB1A78 VA: 0x7EB5A78 Slot: 7
	protected override object GetUninitializedObject() { }
}

// Namespace: Sirenix.Serialization
public sealed class PrimitiveArrayFormatter<T> : MinimalBaseFormatter<T[]> // TypeDefIndex: 22373
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected override T[] GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528D4E4 Offset: 0x52894E4 VA: 0x528D4E4
	|-PrimitiveArrayFormatter<__Il2CppFullySharedGenericStructType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void Read(ref T[] value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528D4EC Offset: 0x52894EC VA: 0x528D4EC
	|-PrimitiveArrayFormatter<__Il2CppFullySharedGenericStructType>.Read
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void Write(ref T[] value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528D6CC Offset: 0x52896CC VA: 0x528D6CC
	|-PrimitiveArrayFormatter<__Il2CppFullySharedGenericStructType>.Write
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x528D768 Offset: 0x5289768 VA: 0x528D768
	|-PrimitiveArrayFormatter<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: 
public enum WeakPrimitiveArrayFormatter.PrimitiveArrayType // TypeDefIndex: 22374
{
	// Fields
	public int value__; // 0x0
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_char = 0;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_sbyte = 1;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_short = 2;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_int = 3;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_long = 4;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_byte = 5;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_ushort = 6;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_uint = 7;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_ulong = 8;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_decimal = 9;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_bool = 10;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_float = 11;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_double = 12;
	public const WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveArray_Guid = 13;
}

// Namespace: Sirenix.Serialization
public sealed class WeakPrimitiveArrayFormatter : WeakMinimalBaseFormatter // TypeDefIndex: 22375
{
	// Fields
	private static readonly Dictionary<Type, WeakPrimitiveArrayFormatter.PrimitiveArrayType> PrimitiveTypes; // 0x0
	private readonly Type ElementType; // 0x20
	private readonly WeakPrimitiveArrayFormatter.PrimitiveArrayType PrimitiveType; // 0x28

	// Methods

	// RVA: 0x7EA4574 Offset: 0x7EA0574 VA: 0x7EA4574
	public void .ctor(Type arrayType, Type elementType) { }

	// RVA: 0x7EB5A80 Offset: 0x7EB1A80 VA: 0x7EB5A80 Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EB5A88 Offset: 0x7EB1A88 VA: 0x7EB5A88 Slot: 8
	protected override void Read(ref object value, IDataReader reader) { }

	// RVA: 0x7EB6424 Offset: 0x7EB2424 VA: 0x7EB6424 Slot: 9
	protected override void Write(ref object value, IDataWriter writer) { }

	// RVA: 0x7EB6CB4 Offset: 0x7EB2CB4 VA: 0x7EB6CB4
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class QueueFormatter<TQueue, TValue> : BaseFormatter<TQueue> // TypeDefIndex: 22376
{
	// Fields
	private static readonly Serializer<TValue> TSerializer; // 0x0
	private static readonly bool IsPlainQueue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52ABA9C Offset: 0x52A7A9C VA: 0x52ABA9C
	|-QueueFormatter<object, int>..cctor
	|
	|-RVA: 0x52ACA50 Offset: 0x52A8A50 VA: 0x52ACA50
	|-QueueFormatter<object, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52ABC68 Offset: 0x52A7C68 VA: 0x52ABC68
	|-QueueFormatter<object, int>..ctor
	|
	|-RVA: 0x52ACC54 Offset: 0x52A8C54 VA: 0x52ACC54
	|-QueueFormatter<object, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override TQueue GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52ABCC4 Offset: 0x52A7CC4 VA: 0x52ABCC4
	|-QueueFormatter<object, int>.GetUninitializedObject
	|
	|-RVA: 0x52ACCB0 Offset: 0x52A8CB0 VA: 0x52ACCB0
	|-QueueFormatter<object, __Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref TQueue value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52ABCCC Offset: 0x52A7CCC VA: 0x52ABCCC
	|-QueueFormatter<object, int>.DeserializeImplementation
	|
	|-RVA: 0x52ACCB8 Offset: 0x52A8CB8 VA: 0x52ACCB8
	|-QueueFormatter<object, __Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref TQueue value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52AC59C Offset: 0x52A859C VA: 0x52AC59C
	|-QueueFormatter<object, int>.SerializeImplementation
	|
	|-RVA: 0x52AD60C Offset: 0x52A960C VA: 0x52AD60C
	|-QueueFormatter<object, __Il2CppFullySharedGenericType>.SerializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
public class WeakQueueFormatter : WeakBaseFormatter // TypeDefIndex: 22377
{
	// Fields
	private readonly Serializer ElementSerializer; // 0x40
	private readonly bool IsPlainQueue; // 0x48
	private MethodInfo EnqueueMethod; // 0x50

	// Methods

	// RVA: 0x7EB70B4 Offset: 0x7EB30B4 VA: 0x7EB70B4
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EB73AC Offset: 0x7EB33AC VA: 0x7EB73AC Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EB73B4 Offset: 0x7EB33B4 VA: 0x7EB73B4 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EB7C84 Offset: 0x7EB3C84 VA: 0x7EB7C84 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }
}

// Namespace: Sirenix.Serialization
public class ReflectionFormatter<T> : BaseFormatter<T> // TypeDefIndex: 22378
{
	// Fields
	[CompilerGenerated]
	private ISerializationPolicy <OverridePolicy>k__BackingField; // 0x0

	// Properties
	public ISerializationPolicy OverridePolicy { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495A8C Offset: 0x5491A8C VA: 0x5495A8C
	|-ReflectionFormatter<Keyframe>..ctor
	|
	|-RVA: 0x54969D8 Offset: 0x54929D8 VA: 0x54969D8
	|-ReflectionFormatter<object>..ctor
	|
	|-RVA: 0x54978BC Offset: 0x54938BC VA: 0x54978BC
	|-ReflectionFormatter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ISerializationPolicy overridePolicy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495AE8 Offset: 0x5491AE8 VA: 0x5495AE8
	|-ReflectionFormatter<Keyframe>..ctor
	|
	|-RVA: 0x5496A34 Offset: 0x5492A34 VA: 0x5496A34
	|-ReflectionFormatter<object>..ctor
	|
	|-RVA: 0x549791C Offset: 0x549391C VA: 0x549791C
	|-ReflectionFormatter<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ISerializationPolicy get_OverridePolicy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495B58 Offset: 0x5491B58 VA: 0x5495B58
	|-ReflectionFormatter<Keyframe>.get_OverridePolicy
	|
	|-RVA: 0x5496AA4 Offset: 0x5492AA4 VA: 0x5496AA4
	|-ReflectionFormatter<object>.get_OverridePolicy
	|
	|-RVA: 0x549799C Offset: 0x549399C VA: 0x549799C
	|-ReflectionFormatter<__Il2CppFullySharedGenericType>.get_OverridePolicy
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_OverridePolicy(ISerializationPolicy value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495B60 Offset: 0x5491B60 VA: 0x5495B60
	|-ReflectionFormatter<Keyframe>.set_OverridePolicy
	|
	|-RVA: 0x5496AAC Offset: 0x5492AAC VA: 0x5496AAC
	|-ReflectionFormatter<object>.set_OverridePolicy
	|
	|-RVA: 0x54979A4 Offset: 0x54939A4 VA: 0x54979A4
	|-ReflectionFormatter<__Il2CppFullySharedGenericType>.set_OverridePolicy
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref T value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495B68 Offset: 0x5491B68 VA: 0x5495B68
	|-ReflectionFormatter<Keyframe>.DeserializeImplementation
	|
	|-RVA: 0x5496AB4 Offset: 0x5492AB4 VA: 0x5496AB4
	|-ReflectionFormatter<object>.DeserializeImplementation
	|
	|-RVA: 0x54979AC Offset: 0x54939AC VA: 0x54979AC
	|-ReflectionFormatter<__Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549661C Offset: 0x549261C VA: 0x549661C
	|-ReflectionFormatter<Keyframe>.SerializeImplementation
	|
	|-RVA: 0x549752C Offset: 0x549352C VA: 0x549752C
	|-ReflectionFormatter<object>.SerializeImplementation
	|
	|-RVA: 0x54984D0 Offset: 0x54944D0 VA: 0x54984D0
	|-ReflectionFormatter<__Il2CppFullySharedGenericType>.SerializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
public class WeakReflectionFormatter : WeakBaseFormatter // TypeDefIndex: 22379
{
	// Methods

	// RVA: 0x7EB8310 Offset: 0x7EB4310 VA: 0x7EB8310
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EB8318 Offset: 0x7EB4318 VA: 0x7EB8318 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EB9984 Offset: 0x7EB5984 VA: 0x7EB9984 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }
}

// Namespace: Sirenix.Serialization
public abstract class ReflectionOrEmittedBaseFormatter<T> : ReflectionFormatter<T> // TypeDefIndex: 22380
{
	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A2D30 Offset: 0x549ED30 VA: 0x54A2D30
	|-ReflectionOrEmittedBaseFormatter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Sirenix.Serialization
public sealed class SelfFormatterFormatter<T> : BaseFormatter<T> // TypeDefIndex: 22381
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref T value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DBEDC Offset: 0x54D7EDC VA: 0x54DBEDC
	|-SelfFormatterFormatter<__Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DBFC8 Offset: 0x54D7FC8 VA: 0x54DBFC8
	|-SelfFormatterFormatter<__Il2CppFullySharedGenericType>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DC0B4 Offset: 0x54D80B4 VA: 0x54DC0B4
	|-SelfFormatterFormatter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Sirenix.Serialization
public sealed class WeakSelfFormatterFormatter : WeakBaseFormatter // TypeDefIndex: 22382
{
	// Methods

	// RVA: 0x7EBA0E8 Offset: 0x7EB60E8 VA: 0x7EBA0E8
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EBA0F0 Offset: 0x7EB60F0 VA: 0x7EBA0F0 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EBA1E8 Offset: 0x7EB61E8 VA: 0x7EBA1E8 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SerializableFormatter.<>c__DisplayClass2_0<T> // TypeDefIndex: 22383
{
	// Fields
	public ConstructorInfo constructor; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486CE80 Offset: 0x4868E80 VA: 0x486CE80
	|-SerializableFormatter.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <.cctor>b__0(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486CE88 Offset: 0x4868E88 VA: 0x486CE88
	|-SerializableFormatter.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType>.<.cctor>b__0
	*/
}

// Namespace: Sirenix.Serialization
public sealed class SerializableFormatter<T> : BaseFormatter<T> // TypeDefIndex: 22384
{
	// Fields
	private static readonly Func<SerializationInfo, StreamingContext, T> ISerializableConstructor; // 0x0
	private static readonly ReflectionFormatter<T> ReflectionFormatter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DD648 Offset: 0x54D9648 VA: 0x54DD648
	|-SerializableFormatter<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override T GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DDDC8 Offset: 0x54D9DC8 VA: 0x54DDDC8
	|-SerializableFormatter<__Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref T value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DDE8C Offset: 0x54D9E8C VA: 0x54DDE8C
	|-SerializableFormatter<__Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DE4C4 Offset: 0x54DA4C4 VA: 0x54DE4C4
	|-SerializableFormatter<__Il2CppFullySharedGenericType>.SerializeImplementation
	*/

	// RVA: -1 Offset: -1
	private SerializationInfo ReadSerializationInfo(IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DE964 Offset: 0x54DA964 VA: 0x54DE964
	|-SerializableFormatter<__Il2CppFullySharedGenericType>.ReadSerializationInfo
	*/

	// RVA: -1 Offset: -1
	private void WriteSerializationInfo(SerializationInfo info, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DF070 Offset: 0x54DB070 VA: 0x54DF070
	|-SerializableFormatter<__Il2CppFullySharedGenericType>.WriteSerializationInfo
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54DF60C Offset: 0x54DB60C VA: 0x54DF60C
	|-SerializableFormatter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class WeakSerializableFormatter.<>c__DisplayClass2_0 // TypeDefIndex: 22385
{
	// Fields
	public WeakSerializableFormatter <>4__this; // 0x10
	public ConstructorInfo constructor; // 0x18

	// Methods

	// RVA: 0x7EBA830 Offset: 0x7EB6830 VA: 0x7EBA830
	public void .ctor() { }

	// RVA: 0x7EBBC44 Offset: 0x7EB7C44 VA: 0x7EBBC44
	internal ISerializable <.ctor>b__0(SerializationInfo info, StreamingContext context) { }
}

// Namespace: Sirenix.Serialization
public sealed class WeakSerializableFormatter : WeakBaseFormatter // TypeDefIndex: 22386
{
	// Fields
	private readonly Func<SerializationInfo, StreamingContext, ISerializable> ISerializableConstructor; // 0x40
	private readonly WeakReflectionFormatter ReflectionFormatter; // 0x48

	// Methods

	// RVA: 0x7EBA2DC Offset: 0x7EB62DC VA: 0x7EBA2DC
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EBA838 Offset: 0x7EB6838 VA: 0x7EBA838 Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EBA840 Offset: 0x7EB6840 VA: 0x7EBA840 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EBB2A4 Offset: 0x7EB72A4 VA: 0x7EBB2A4 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }

	// RVA: 0x7EBABD8 Offset: 0x7EB6BD8 VA: 0x7EBABD8
	private SerializationInfo ReadSerializationInfo(IDataReader reader) { }

	// RVA: 0x7EBB5DC Offset: 0x7EB75DC VA: 0x7EBB5DC
	private void WriteSerializationInfo(SerializationInfo info, IDataWriter writer) { }
}

// Namespace: Sirenix.Serialization
public class StackFormatter<TStack, TValue> : BaseFormatter<TStack> // TypeDefIndex: 22387
{
	// Fields
	private static readonly Serializer<TValue> TSerializer; // 0x0
	private static readonly bool IsPlainStack; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5518ED4 Offset: 0x5514ED4 VA: 0x5518ED4
	|-StackFormatter<object, int>..cctor
	|
	|-RVA: 0x551A0BC Offset: 0x55160BC VA: 0x551A0BC
	|-StackFormatter<object, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55190A0 Offset: 0x55150A0 VA: 0x55190A0
	|-StackFormatter<object, int>..ctor
	|
	|-RVA: 0x551A2C0 Offset: 0x55162C0 VA: 0x551A2C0
	|-StackFormatter<object, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override TStack GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55190FC Offset: 0x55150FC VA: 0x55190FC
	|-StackFormatter<object, int>.GetUninitializedObject
	|
	|-RVA: 0x551A31C Offset: 0x551631C VA: 0x551A31C
	|-StackFormatter<object, __Il2CppFullySharedGenericType>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void DeserializeImplementation(ref TStack value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5519104 Offset: 0x5515104 VA: 0x5519104
	|-StackFormatter<object, int>.DeserializeImplementation
	|
	|-RVA: 0x551A324 Offset: 0x5516324 VA: 0x551A324
	|-StackFormatter<object, __Il2CppFullySharedGenericType>.DeserializeImplementation
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void SerializeImplementation(ref TStack value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55199D4 Offset: 0x55159D4 VA: 0x55199D4
	|-StackFormatter<object, int>.SerializeImplementation
	|
	|-RVA: 0x551AC78 Offset: 0x5516C78 VA: 0x551AC78
	|-StackFormatter<object, __Il2CppFullySharedGenericType>.SerializeImplementation
	*/
}

// Namespace: Sirenix.Serialization
public class WeakStackFormatter : WeakBaseFormatter // TypeDefIndex: 22388
{
	// Fields
	private readonly Serializer ElementSerializer; // 0x40
	private readonly bool IsPlainStack; // 0x48
	private readonly MethodInfo PushMethod; // 0x50

	// Methods

	// RVA: 0x7EBBDF8 Offset: 0x7EB7DF8 VA: 0x7EBBDF8
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EBC0A4 Offset: 0x7EB80A4 VA: 0x7EBC0A4 Slot: 7
	protected override object GetUninitializedObject() { }

	// RVA: 0x7EBC0AC Offset: 0x7EB80AC VA: 0x7EBC0AC Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EBC920 Offset: 0x7EB8920 VA: 0x7EBC920 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }
}

// Namespace: Sirenix.Serialization
public sealed class TimeSpanFormatter : MinimalBaseFormatter<TimeSpan> // TypeDefIndex: 22389
{
	// Methods

	// RVA: 0x7EBD234 Offset: 0x7EB9234 VA: 0x7EBD234 Slot: 10
	protected override void Read(ref TimeSpan value, IDataReader reader) { }

	// RVA: 0x7EBD360 Offset: 0x7EB9360 VA: 0x7EBD360 Slot: 11
	protected override void Write(ref TimeSpan value, IDataWriter writer) { }

	// RVA: 0x7EBD43C Offset: 0x7EB943C VA: 0x7EBD43C
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class TypeFormatter : MinimalBaseFormatter<Type> // TypeDefIndex: 22390
{
	// Methods

	// RVA: 0x7EBD4A8 Offset: 0x7EB94A8 VA: 0x7EBD4A8 Slot: 10
	protected override void Read(ref Type value, IDataReader reader) { }

	// RVA: 0x7EBD740 Offset: 0x7EB9740 VA: 0x7EBD740 Slot: 11
	protected override void Write(ref Type value, IDataWriter writer) { }

	// RVA: 0x7EBD8EC Offset: 0x7EB98EC VA: 0x7EBD8EC Slot: 9
	protected override Type GetUninitializedObject() { }

	// RVA: 0x7EBD8F4 Offset: 0x7EB98F4 VA: 0x7EBD8F4
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class VersionFormatter : MinimalBaseFormatter<Version> // TypeDefIndex: 22391
{
	// Methods

	// RVA: 0x7EBD960 Offset: 0x7EB9960 VA: 0x7EBD960 Slot: 9
	protected override Version GetUninitializedObject() { }

	// RVA: 0x7EBD968 Offset: 0x7EB9968 VA: 0x7EBD968 Slot: 10
	protected override void Read(ref Version value, IDataReader reader) { }

	// RVA: 0x7EBDC0C Offset: 0x7EB9C0C VA: 0x7EBDC0C Slot: 11
	protected override void Write(ref Version value, IDataWriter writer) { }

	// RVA: 0x7EBDE1C Offset: 0x7EB9E1C VA: 0x7EBDE1C
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
[Usage(12, AllowMultiple = False, Inherited = True)]
public class AllowDeserializeInvalidDataAttribute : Attribute // TypeDefIndex: 22392
{
	// Methods

	// RVA: 0x7EBDE88 Offset: 0x7EB9E88 VA: 0x7EBDE88
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
[Usage(12, AllowMultiple = False, Inherited = True)]
public sealed class AlwaysFormatsSelfAttribute : Attribute // TypeDefIndex: 22393
{
	// Methods

	// RVA: 0x7EBDE90 Offset: 0x7EB9E90 VA: 0x7EBDE90
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public static class ArchitectureInfo // TypeDefIndex: 22394
{
	// Fields
	public static bool Architecture_Supports_Unaligned_Float32_Reads; // 0x0
	public static bool Architecture_Supports_All_Unaligned_ReadWrites; // 0x1

	// Methods

	// RVA: 0x7EBDE98 Offset: 0x7EB9E98 VA: 0x7EBDE98
	private static void .cctor() { }

	// RVA: 0x7EBDF20 Offset: 0x7EB9F20 VA: 0x7EBDF20
	internal static void SetRuntimePlatform(RuntimePlatform platform) { }
}

// Namespace: Sirenix.Serialization
public sealed class Buffer<T> : IDisposable // TypeDefIndex: 22395
{
	// Fields
	private static readonly object LOCK; // 0x0
	private static readonly List<Buffer<T>> FreeBuffers; // 0x0
	private int count; // 0x0
	private T[] array; // 0x0
	private bool isFree; // 0x0

	// Properties
	public int Count { get; }
	public T[] Array { get; }
	public bool IsFree { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8E8C0 Offset: 0x5B8A8C0 VA: 0x5B8E8C0
	|-Buffer<byte>..ctor
	|
	|-RVA: 0x5B8F4C8 Offset: 0x5B8B4C8 VA: 0x5B8F4C8
	|-Buffer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8E924 Offset: 0x5B8A924 VA: 0x5B8E924
	|-Buffer<byte>.get_Count
	|
	|-RVA: 0x5B8F52C Offset: 0x5B8B52C VA: 0x5B8F52C
	|-Buffer<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T[] get_Array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8E98C Offset: 0x5B8A98C VA: 0x5B8E98C
	|-Buffer<byte>.get_Array
	|
	|-RVA: 0x5B8F594 Offset: 0x5B8B594 VA: 0x5B8F594
	|-Buffer<__Il2CppFullySharedGenericType>.get_Array
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8E9F4 Offset: 0x5B8A9F4 VA: 0x5B8E9F4
	|-Buffer<byte>.get_IsFree
	|
	|-RVA: 0x5B8F5FC Offset: 0x5B8B5FC VA: 0x5B8F5FC
	|-Buffer<__Il2CppFullySharedGenericType>.get_IsFree
	*/

	// RVA: -1 Offset: -1
	public static Buffer<T> Claim(int minimumCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8EA0C Offset: 0x5B8AA0C VA: 0x5B8EA0C
	|-Buffer<byte>.Claim
	|
	|-RVA: 0x5B8F614 Offset: 0x5B8B614 VA: 0x5B8F614
	|-Buffer<__Il2CppFullySharedGenericType>.Claim
	*/

	// RVA: -1 Offset: -1
	public static void Free(Buffer<T> buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8EE44 Offset: 0x5B8AE44 VA: 0x5B8EE44
	|-Buffer<byte>.Free
	|
	|-RVA: 0x5B8FB74 Offset: 0x5B8BB74 VA: 0x5B8FB74
	|-Buffer<__Il2CppFullySharedGenericType>.Free
	*/

	// RVA: -1 Offset: -1
	public void Free() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8F290 Offset: 0x5B8B290 VA: 0x5B8F290
	|-Buffer<byte>.Free
	|
	|-RVA: 0x5B90070 Offset: 0x5B8C070 VA: 0x5B90070
	|-Buffer<__Il2CppFullySharedGenericType>.Free
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8F2EC Offset: 0x5B8B2EC VA: 0x5B8F2EC
	|-Buffer<byte>.Dispose
	|
	|-RVA: 0x5B900D0 Offset: 0x5B8C0D0 VA: 0x5B900D0
	|-Buffer<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	private static int NextPowerOfTwo(int v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8F348 Offset: 0x5B8B348 VA: 0x5B8F348
	|-Buffer<byte>.NextPowerOfTwo
	|
	|-RVA: 0x5B90130 Offset: 0x5B8C130 VA: 0x5B90130
	|-Buffer<__Il2CppFullySharedGenericType>.NextPowerOfTwo
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B8F368 Offset: 0x5B8B368 VA: 0x5B8F368
	|-Buffer<byte>..cctor
	|
	|-RVA: 0x5B90150 Offset: 0x5B8C150 VA: 0x5B90150
	|-Buffer<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Sirenix.Serialization
internal sealed class CachedMemoryStream : ICacheNotificationReceiver // TypeDefIndex: 22396
{
	// Fields
	public static int InitialCapacity; // 0x0
	public static int MaxCapacity; // 0x4
	private MemoryStream memoryStream; // 0x10

	// Properties
	public MemoryStream MemoryStream { get; }

	// Methods

	// RVA: 0x7EBE2AC Offset: 0x7EBA2AC VA: 0x7EBE2AC
	public MemoryStream get_MemoryStream() { }

	// RVA: 0x7EBE364 Offset: 0x7EBA364 VA: 0x7EBE364
	public void .ctor() { }

	// RVA: 0x7EBE404 Offset: 0x7EBA404 VA: 0x7EBE404 Slot: 4
	public void OnFreed() { }

	// RVA: 0x7EBE504 Offset: 0x7EBA504 VA: 0x7EBE504 Slot: 5
	public void OnClaimed() { }

	// RVA: 0x7EBE54C Offset: 0x7EBA54C VA: 0x7EBE54C
	public static Cache<CachedMemoryStream> Claim(int minCapacity) { }

	// RVA: 0x7EBE614 Offset: 0x7EBA614 VA: 0x7EBE614
	public static Cache<CachedMemoryStream> Claim(byte[] bytes) { }

	// RVA: 0x7EBE6E4 Offset: 0x7EBA6E4 VA: 0x7EBE6E4
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
[Obsolete("Use a RegisterFormatterAttribute applied to the containing assembly instead.", True)]
[Usage(4)]
[EditorBrowsable(1)]
public class CustomFormatterAttribute : Attribute // TypeDefIndex: 22397
{
	// Fields
	public readonly int Priority; // 0x10

	// Methods

	// RVA: 0x7EBE734 Offset: 0x7EBA734 VA: 0x7EBE734
	public void .ctor() { }

	// RVA: 0x7EBE750 Offset: 0x7EBA750 VA: 0x7EBE750
	public void .ctor(int priority = 0) { }
}

// Namespace: Sirenix.Serialization
[EditorBrowsable(1)]
[Usage(4)]
[Obsolete("Use a RegisterFormatterAttribute applied to the containing assembly instead.", True)]
public class CustomGenericFormatterAttribute : CustomFormatterAttribute // TypeDefIndex: 22398
{
	// Fields
	public readonly Type SerializedGenericTypeDefinition; // 0x18

	// Methods

	// RVA: 0x7EBE778 Offset: 0x7EBA778 VA: 0x7EBE778
	public void .ctor(Type serializedGenericTypeDefinition, int priority = 0) { }
}

// Namespace: Sirenix.Serialization
public class CustomSerializationPolicy : ISerializationPolicy // TypeDefIndex: 22399
{
	// Fields
	private string id; // 0x10
	private bool allowNonSerializableTypes; // 0x18
	private Func<MemberInfo, bool> shouldSerializeFunc; // 0x20

	// Properties
	public string ID { get; }
	public bool AllowNonSerializableTypes { get; }

	// Methods

	// RVA: 0x7EBE8E8 Offset: 0x7EBA8E8 VA: 0x7EBE8E8
	public void .ctor(string id, bool allowNonSerializableTypes, Func<MemberInfo, bool> shouldSerializeFunc) { }

	// RVA: 0x7EBE9B0 Offset: 0x7EBA9B0 VA: 0x7EBE9B0 Slot: 4
	public string get_ID() { }

	// RVA: 0x7EBE9B8 Offset: 0x7EBA9B8 VA: 0x7EBE9B8 Slot: 5
	public bool get_AllowNonSerializableTypes() { }

	// RVA: 0x7EBE9C0 Offset: 0x7EBA9C0 VA: 0x7EBE9C0 Slot: 6
	public bool ShouldSerializeMember(MemberInfo member) { }
}

// Namespace: Sirenix.Serialization
[Usage(1, AllowMultiple = True)]
public sealed class BindTypeNameToTypeAttribute : Attribute // TypeDefIndex: 22400
{
	// Fields
	internal readonly Type NewType; // 0x10
	internal readonly string OldTypeName; // 0x18

	// Methods

	// RVA: 0x7EBE9E4 Offset: 0x7EBA9E4 VA: 0x7EBE9E4
	public void .ctor(string oldFullTypeName, Type newType) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DefaultSerializationBinder.<>c // TypeDefIndex: 22401
{
	// Fields
	public static readonly DefaultSerializationBinder.<>c <>9; // 0x0

	// Methods

	// RVA: 0x7EC1DAC Offset: 0x7EBDDAC VA: 0x7EC1DAC
	private static void .cctor() { }

	// RVA: 0x7EC1E14 Offset: 0x7EBDE14 VA: 0x7EC1E14
	public void .ctor() { }

	// RVA: 0x7EC1E1C Offset: 0x7EBDE1C VA: 0x7EC1E1C
	internal void <.cctor>b__10_0(object sender, AssemblyLoadEventArgs args) { }
}

// Namespace: Sirenix.Serialization
public class DefaultSerializationBinder : TwoWaySerializationBinder // TypeDefIndex: 22402
{
	// Fields
	private static readonly object ASSEMBLY_LOOKUP_LOCK; // 0x0
	private static readonly Dictionary<string, Assembly> assemblyNameLookUp; // 0x8
	private static readonly Dictionary<string, Type> customTypeNameToTypeBindings; // 0x10
	private static readonly object TYPETONAME_LOCK; // 0x18
	private static readonly Dictionary<Type, string> nameMap; // 0x20
	private static readonly object NAMETOTYPE_LOCK; // 0x28
	private static readonly Dictionary<string, Type> typeMap; // 0x30
	private static readonly object ASSEMBLY_REGISTER_QUEUE_LOCK; // 0x38
	private static readonly List<Assembly> assembliesQueuedForRegister; // 0x40
	private static readonly List<AssemblyLoadEventArgs> assemblyLoadEventsQueuedForRegister; // 0x48

	// Methods

	// RVA: 0x7EBEA28 Offset: 0x7EBAA28 VA: 0x7EBEA28
	private static void .cctor() { }

	// RVA: 0x7EBF0DC Offset: 0x7EBB0DC VA: 0x7EBF0DC
	private static void RegisterAllQueuedAssembliesRepeating() { }

	// RVA: 0x7EBF140 Offset: 0x7EBB140 VA: 0x7EBF140
	private static bool RegisterQueuedAssemblies() { }

	// RVA: 0x7EBF39C Offset: 0x7EBB39C VA: 0x7EBF39C
	private static bool RegisterQueuedAssemblyLoadEvents() { }

	// RVA: 0x7EBF68C Offset: 0x7EBB68C VA: 0x7EBF68C
	private static void RegisterAssembly(Assembly assembly) { }

	// RVA: 0x7EBFBB8 Offset: 0x7EBBBB8 VA: 0x7EBFBB8 Slot: 4
	public override string BindToName(Type type, DebugContext debugContext) { }

	// RVA: 0x7EC035C Offset: 0x7EBC35C VA: 0x7EC035C Slot: 6
	public override bool ContainsType(string typeName) { }

	// RVA: 0x7EC04A8 Offset: 0x7EBC4A8 VA: 0x7EC04A8 Slot: 5
	public override Type BindToType(string typeName, DebugContext debugContext) { }

	// RVA: 0x7EC0770 Offset: 0x7EBC770 VA: 0x7EC0770
	private Type ParseTypeName(string typeName, DebugContext debugContext) { }

	// RVA: 0x7EC16B8 Offset: 0x7EBD6B8 VA: 0x7EC16B8
	private static void ParseName(string fullName, out string typeName, out string assemblyName) { }

	// RVA: 0x7EC0EA4 Offset: 0x7EBCEA4 VA: 0x7EC0EA4
	private Type ParseGenericAndOrArrayType(string typeName, DebugContext debugContext) { }

	// RVA: 0x7EC186C Offset: 0x7EBD86C VA: 0x7EC186C
	private static bool TryParseGenericAndOrArrayTypeName(string typeName, out string actualTypeName, out bool isGeneric, out List<string> genericArgNames, out bool isArray, out int arrayRank) { }

	// RVA: 0x7EC1C14 Offset: 0x7EBDC14 VA: 0x7EC1C14
	private static char Peek(string str, int i, int ahead) { }

	// RVA: 0x7EC1C48 Offset: 0x7EBDC48 VA: 0x7EC1C48
	private static bool ReadGenericArg(string typeName, ref int i, out string argName) { }

	// RVA: 0x7EC1D4C Offset: 0x7EBDD4C VA: 0x7EC1D4C
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class DeserializationContext : ICacheNotificationReceiver // TypeDefIndex: 22403
{
	// Fields
	private SerializationConfig config; // 0x10
	private Dictionary<int, object> internalIdReferenceMap; // 0x18
	private StreamingContext streamingContext; // 0x20
	private IFormatterConverter formatterConverter; // 0x30
	private TwoWaySerializationBinder binder; // 0x38
	[CompilerGenerated]
	private IExternalStringReferenceResolver <StringReferenceResolver>k__BackingField; // 0x40
	[CompilerGenerated]
	private IExternalGuidReferenceResolver <GuidReferenceResolver>k__BackingField; // 0x48
	[CompilerGenerated]
	private IExternalIndexReferenceResolver <IndexReferenceResolver>k__BackingField; // 0x50

	// Properties
	public TwoWaySerializationBinder Binder { get; set; }
	public IExternalStringReferenceResolver StringReferenceResolver { get; set; }
	public IExternalGuidReferenceResolver GuidReferenceResolver { get; set; }
	public IExternalIndexReferenceResolver IndexReferenceResolver { get; set; }
	public StreamingContext StreamingContext { get; }
	public IFormatterConverter FormatterConverter { get; }
	public SerializationConfig Config { get; set; }

	// Methods

	// RVA: 0x7EC1FAC Offset: 0x7EBDFAC VA: 0x7EC1FAC
	public void .ctor() { }

	// RVA: 0x7EC2128 Offset: 0x7EBE128 VA: 0x7EC2128
	public void .ctor(StreamingContext context) { }

	// RVA: 0x7EC219C Offset: 0x7EBE19C VA: 0x7EC219C
	public void .ctor(FormatterConverter formatterConverter) { }

	// RVA: 0x7EC2010 Offset: 0x7EBE010 VA: 0x7EC2010
	public void .ctor(StreamingContext context, FormatterConverter formatterConverter) { }

	// RVA: 0x7EBBB5C Offset: 0x7EB7B5C VA: 0x7EBBB5C
	public TwoWaySerializationBinder get_Binder() { }

	// RVA: 0x7EC2248 Offset: 0x7EBE248 VA: 0x7EC2248
	public void set_Binder(TwoWaySerializationBinder value) { }

	[CompilerGenerated]
	// RVA: 0x7EC2250 Offset: 0x7EBE250 VA: 0x7EC2250
	public IExternalStringReferenceResolver get_StringReferenceResolver() { }

	[CompilerGenerated]
	// RVA: 0x7EC2258 Offset: 0x7EBE258 VA: 0x7EC2258
	public void set_StringReferenceResolver(IExternalStringReferenceResolver value) { }

	[CompilerGenerated]
	// RVA: 0x7EC2260 Offset: 0x7EBE260 VA: 0x7EC2260
	public IExternalGuidReferenceResolver get_GuidReferenceResolver() { }

	[CompilerGenerated]
	// RVA: 0x7EC2268 Offset: 0x7EBE268 VA: 0x7EC2268
	public void set_GuidReferenceResolver(IExternalGuidReferenceResolver value) { }

	[CompilerGenerated]
	// RVA: 0x7EC2270 Offset: 0x7EBE270 VA: 0x7EC2270
	public IExternalIndexReferenceResolver get_IndexReferenceResolver() { }

	[CompilerGenerated]
	// RVA: 0x7EC2278 Offset: 0x7EBE278 VA: 0x7EC2278
	public void set_IndexReferenceResolver(IExternalIndexReferenceResolver value) { }

	// RVA: 0x7EC2280 Offset: 0x7EBE280 VA: 0x7EC2280
	public StreamingContext get_StreamingContext() { }

	// RVA: 0x7EC228C Offset: 0x7EBE28C VA: 0x7EC228C
	public IFormatterConverter get_FormatterConverter() { }

	// RVA: 0x7EB8C18 Offset: 0x7EB4C18 VA: 0x7EB8C18
	public SerializationConfig get_Config() { }

	// RVA: 0x7EC2308 Offset: 0x7EBE308 VA: 0x7EC2308
	public void set_Config(SerializationConfig value) { }

	// RVA: 0x7EC2310 Offset: 0x7EBE310 VA: 0x7EC2310
	public void RegisterInternalReference(int id, object reference) { }

	// RVA: 0x7EC2378 Offset: 0x7EBE378 VA: 0x7EC2378
	public object GetInternalReference(int id) { }

	// RVA: 0x7EC23E8 Offset: 0x7EBE3E8 VA: 0x7EC23E8
	public object GetExternalObject(int index) { }

	// RVA: 0x7EC2574 Offset: 0x7EBE574 VA: 0x7EC2574
	public object GetExternalObject(Guid guid) { }

	// RVA: 0x7EC277C Offset: 0x7EBE77C VA: 0x7EC277C
	public object GetExternalObject(string id) { }

	// RVA: 0x7EC21AC Offset: 0x7EBE1AC VA: 0x7EC21AC
	public void Reset() { }

	// RVA: 0x7EC2A44 Offset: 0x7EBEA44 VA: 0x7EC2A44 Slot: 4
	private void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnFreed() { }

	// RVA: 0x7EC2A48 Offset: 0x7EBEA48 VA: 0x7EC2A48 Slot: 5
	private void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnClaimed() { }
}

// Namespace: Sirenix.Serialization
[Usage(1, AllowMultiple = False)]
[EditorBrowsable(1)]
public sealed class EmittedAssemblyAttribute : Attribute // TypeDefIndex: 22404
{
	// Methods

	[Obsolete("This attribute cannot be used in code, and is only meant to be applied to dynamically emitted assemblies.", True)]
	// RVA: 0x7EC2A4C Offset: 0x7EBEA4C VA: 0x7EC2A4C
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public enum EntryType // TypeDefIndex: 22405
{
	// Fields
	public byte value__; // 0x0
	public const EntryType Invalid = 0;
	public const EntryType String = 1;
	public const EntryType Guid = 2;
	public const EntryType Integer = 3;
	public const EntryType FloatingPoint = 4;
	public const EntryType Boolean = 5;
	public const EntryType Null = 6;
	public const EntryType StartOfNode = 7;
	public const EntryType EndOfNode = 8;
	public const EntryType InternalReference = 9;
	public const EntryType ExternalReferenceByIndex = 10;
	public const EntryType ExternalReferenceByGuid = 11;
	public const EntryType StartOfArray = 12;
	public const EntryType EndOfArray = 13;
	public const EntryType PrimitiveArray = 14;
	public const EntryType EndOfStream = 15;
	public const EntryType ExternalReferenceByString = 16;
}

// Namespace: Sirenix.Serialization
[Usage(384, AllowMultiple = False, Inherited = True)]
[Obsolete("Use [HideInInspector] instead - it now also excludes the member completely from becoming a property in the property tree.", False)]
[EditorBrowsable(1)]
public sealed class ExcludeDataFromInspectorAttribute : Attribute // TypeDefIndex: 22406
{
	// Methods

	// RVA: 0x7EC2A54 Offset: 0x7EBEA54 VA: 0x7EC2A54
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public enum FormatterLocationStep // TypeDefIndex: 22407
{
	// Fields
	public int value__; // 0x0
	public const FormatterLocationStep BeforeRegisteredFormatters = 0;
	public const FormatterLocationStep AfterRegisteredFormatters = 1;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FormatterUtilities.<>c // TypeDefIndex: 22408
{
	// Fields
	public static readonly FormatterUtilities.<>c <>9; // 0x0
	public static Func<MemberInfo, string> <>9__15_0; // 0x8
	public static Func<MemberInfo, MemberInfo> <>9__15_1; // 0x10
	public static Func<MemberInfo, bool> <>9__16_0; // 0x18

	// Methods

	// RVA: 0x7EC4ACC Offset: 0x7EC0ACC VA: 0x7EC4ACC
	private static void .cctor() { }

	// RVA: 0x7EC4B34 Offset: 0x7EC0B34 VA: 0x7EC4B34
	public void .ctor() { }

	// RVA: 0x7EC4B3C Offset: 0x7EC0B3C VA: 0x7EC4B3C
	internal string <FindSerializableMembersMap>b__15_0(MemberInfo n) { }

	// RVA: 0x7EC4B64 Offset: 0x7EC0B64 VA: 0x7EC4B64
	internal MemberInfo <FindSerializableMembersMap>b__15_1(MemberInfo n) { }

	// RVA: 0x7EC4B6C Offset: 0x7EC0B6C VA: 0x7EC4B6C
	internal bool <FindSerializableMembers>b__16_0(MemberInfo n) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FormatterUtilities.<>c__DisplayClass16_0 // TypeDefIndex: 22409
{
	// Fields
	public MemberInfo member; // 0x10

	// Methods

	// RVA: 0x7EC45C4 Offset: 0x7EC05C4 VA: 0x7EC45C4
	public void .ctor() { }

	// RVA: 0x7EC4C24 Offset: 0x7EC0C24 VA: 0x7EC4C24
	internal bool <FindSerializableMembers>b__1(MemberInfo n) { }
}

// Namespace: Sirenix.Serialization
public static class FormatterUtilities // TypeDefIndex: 22410
{
	// Fields
	private static readonly DoubleLookupDictionary<ISerializationPolicy, Type, MemberInfo[]> MemberArrayCache; // 0x0
	private static readonly DoubleLookupDictionary<ISerializationPolicy, Type, Dictionary<string, MemberInfo>> MemberMapCache; // 0x8
	private static readonly object LOCK; // 0x10
	private static readonly HashSet<Type> PrimitiveArrayTypes; // 0x18
	private static readonly FieldInfo UnityObjectRuntimeErrorStringField; // 0x20
	private const string UnityObjectRuntimeErrorString = "The variable nullValue of {0} has not been assigned.\r\nYou probably need to assign the nullValue variable of the {0} script in the inspector.";

	// Methods

	// RVA: 0x7EC2A5C Offset: 0x7EBEA5C VA: 0x7EC2A5C
	private static void .cctor() { }

	// RVA: 0x7EB8DC4 Offset: 0x7EB4DC4 VA: 0x7EB8DC4
	public static Dictionary<string, MemberInfo> GetSerializableMembersMap(Type type, ISerializationPolicy policy) { }

	// RVA: 0x7EB9D04 Offset: 0x7EB5D04 VA: 0x7EB9D04
	public static MemberInfo[] GetSerializableMembers(Type type, ISerializationPolicy policy) { }

	// RVA: 0x7EC4054 Offset: 0x7EC0054 VA: 0x7EC4054
	public static Object CreateUnityNull(Type nullType, Type owningType) { }

	// RVA: 0x7EC43F4 Offset: 0x7EC03F4 VA: 0x7EC43F4
	public static bool IsPrimitiveType(Type type) { }

	// RVA: 0x7EC4544 Offset: 0x7EC0544 VA: 0x7EC4544
	public static bool IsPrimitiveArrayType(Type type) { }

	// RVA: 0x7EB9380 Offset: 0x7EB5380 VA: 0x7EB9380
	public static Type GetContainedType(MemberInfo member) { }

	// RVA: 0x7EB9F70 Offset: 0x7EB5F70 VA: 0x7EB9F70
	public static object GetMemberValue(MemberInfo member, object obj) { }

	// RVA: 0x7EB9520 Offset: 0x7EB5520 VA: 0x7EB9520
	public static void SetMemberValue(MemberInfo member, object obj, object value) { }

	// RVA: 0x7EC3198 Offset: 0x7EBF198 VA: 0x7EC3198
	private static Dictionary<string, MemberInfo> FindSerializableMembersMap(Type type, ISerializationPolicy policy) { }

	// RVA: 0x7EC383C Offset: 0x7EBF83C VA: 0x7EC383C
	private static void FindSerializableMembers(Type type, List<MemberInfo> members, ISerializationPolicy policy) { }

	// RVA: 0x7EC4770 Offset: 0x7EC0770 VA: 0x7EC4770
	internal static MemberInfo GetPrivateMemberAlias(MemberInfo member, string prefixString, string separatorString) { }

	// RVA: 0x7EC45CC Offset: 0x7EC05CC VA: 0x7EC45CC
	private static bool MemberIsPrivate(MemberInfo member) { }
}

// Namespace: Sirenix.Serialization
public interface IAskIfCanFormatTypes // TypeDefIndex: 22411
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanFormatType(Type type);
}

// Namespace: Sirenix.Serialization
public interface IExternalGuidReferenceResolver // TypeDefIndex: 22412
{
	// Properties
	public abstract IExternalGuidReferenceResolver NextResolver { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IExternalGuidReferenceResolver get_NextResolver();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_NextResolver(IExternalGuidReferenceResolver value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool TryResolveReference(Guid guid, out object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool CanReference(object value, out Guid guid);
}

// Namespace: Sirenix.Serialization
public interface IExternalIndexReferenceResolver // TypeDefIndex: 22413
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryResolveReference(int index, out object value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanReference(object value, out int index);
}

// Namespace: Sirenix.Serialization
public interface IExternalStringReferenceResolver // TypeDefIndex: 22414
{
	// Properties
	public abstract IExternalStringReferenceResolver NextResolver { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IExternalStringReferenceResolver get_NextResolver();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_NextResolver(IExternalStringReferenceResolver value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool TryResolveReference(string id, out object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool CanReference(object value, out string id);
}

// Namespace: Sirenix.Serialization
public interface ISelfFormatter // TypeDefIndex: 22415
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Serialize(IDataWriter writer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Deserialize(IDataReader reader);
}

// Namespace: Sirenix.Serialization
public interface ISerializationPolicy // TypeDefIndex: 22416
{
	// Properties
	public abstract string ID { get; }
	public abstract bool AllowNonSerializableTypes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ID();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_AllowNonSerializableTypes();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool ShouldSerializeMember(MemberInfo member);
}

// Namespace: Sirenix.Serialization
public struct NodeInfo // TypeDefIndex: 22417
{
	// Fields
	public static readonly NodeInfo Empty; // 0x0
	public readonly string Name; // 0x0
	public readonly int Id; // 0x8
	public readonly Type Type; // 0x10
	public readonly bool IsArray; // 0x18
	public readonly bool IsEmpty; // 0x19

	// Methods

	// RVA: 0x7EC4C80 Offset: 0x7EC0C80 VA: 0x7EC4C80
	public void .ctor(string name, int id, Type type, bool isArray) { }

	// RVA: 0x7EC4CD0 Offset: 0x7EC0CD0 VA: 0x7EC4CD0
	private void .ctor(bool parameter) { }

	// RVA: 0x7EC4D0C Offset: 0x7EC0D0C VA: 0x7EC4D0C
	public static bool op_Equality(NodeInfo a, NodeInfo b) { }

	// RVA: 0x7EC4DD4 Offset: 0x7EC0DD4 VA: 0x7EC4DD4
	public static bool op_Inequality(NodeInfo a, NodeInfo b) { }

	// RVA: 0x7EC4E6C Offset: 0x7EC0E6C VA: 0x7EC4E6C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x7EC4F34 Offset: 0x7EC0F34 VA: 0x7EC4F34 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7EC5064 Offset: 0x7EC1064 VA: 0x7EC5064
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
[Usage(384)]
[MeansImplicitUse]
public class OdinSerializeAttribute : Attribute // TypeDefIndex: 22418
{
	// Methods

	// RVA: 0x7EC5104 Offset: 0x7EC1104 VA: 0x7EC5104
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PrefabModification.<>c // TypeDefIndex: 22419
{
	// Fields
	public static readonly PrefabModification.<>c <>9; // 0x0
	public static Func<MemberInfo, bool> <>9__13_0; // 0x8
	public static Func<MemberInfo, bool> <>9__16_0; // 0x10

	// Methods

	// RVA: 0x7EC89D8 Offset: 0x7EC49D8 VA: 0x7EC89D8
	private static void .cctor() { }

	// RVA: 0x7EC8A40 Offset: 0x7EC4A40 VA: 0x7EC8A40
	public void .ctor() { }

	// RVA: 0x7EC8A48 Offset: 0x7EC4A48 VA: 0x7EC8A48
	internal bool <GetInstanceOfStep>b__13_0(MemberInfo n) { }

	// RVA: 0x7EC8B00 Offset: 0x7EC4B00 VA: 0x7EC8B00
	internal bool <TrySetInstanceOfStep>b__16_0(MemberInfo n) { }
}

// Namespace: Sirenix.Serialization
public sealed class PrefabModification // TypeDefIndex: 22420
{
	// Fields
	public PrefabModificationType ModificationType; // 0x10
	public string Path; // 0x18
	public List<string> ReferencePaths; // 0x20
	public object ModifiedValue; // 0x28
	public int NewLength; // 0x30
	public object[] DictionaryKeysAdded; // 0x38
	public object[] DictionaryKeysRemoved; // 0x40

	// Methods

	// RVA: 0x7EC510C Offset: 0x7EC110C VA: 0x7EC510C
	public void Apply(Object unityObject) { }

	// RVA: 0x7EC51CC Offset: 0x7EC11CC VA: 0x7EC51CC
	private void ApplyValue(Object unityObject) { }

	// RVA: 0x7EC53BC Offset: 0x7EC13BC VA: 0x7EC53BC
	private void ApplyListLength(Object unityObject) { }

	// RVA: 0x7EC5D78 Offset: 0x7EC1D78 VA: 0x7EC5D78
	private void ApplyDictionaryModifications(Object unityObject) { }

	// RVA: 0x7EC63CC Offset: 0x7EC23CC VA: 0x7EC63CC
	private static void ReplaceAllReferencesInGraph(object graph, object oldReference, object newReference, HashSet<object> processedReferences) { }

	// RVA: 0x7EC6240 Offset: 0x7EC2240 VA: 0x7EC6240
	private static object GetInstanceFromPath(string path, object instance) { }

	// RVA: 0x7EC6B84 Offset: 0x7EC2B84 VA: 0x7EC6B84
	private static object GetInstanceOfStep(string step, object instance) { }

	// RVA: 0x7EC6318 Offset: 0x7EC2318 VA: 0x7EC6318
	private static void SetInstanceToPath(string path, object instance, object value) { }

	// RVA: 0x7EC78EC Offset: 0x7EC38EC VA: 0x7EC78EC
	private static void SetInstanceToPath(string path, string[] steps, int index, object instance, object value, out bool setParentInstance) { }

	// RVA: 0x7EC79D4 Offset: 0x7EC39D4 VA: 0x7EC79D4
	private static bool TrySetInstanceOfStep(string step, object instance, object value, out bool setParentInstance) { }

	// RVA: 0x7EC89D0 Offset: 0x7EC49D0 VA: 0x7EC89D0
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public enum PrefabModificationType // TypeDefIndex: 22421
{
	// Fields
	public int value__; // 0x0
	public const PrefabModificationType Value = 0;
	public const PrefabModificationType ListLength = 1;
	public const PrefabModificationType Dictionary = 2;
}

// Namespace: Sirenix.Serialization
[Usage(384)]
public class PreviouslySerializedAsAttribute : Attribute // TypeDefIndex: 22422
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7EC8BB8 Offset: 0x7EC4BB8 VA: 0x7EC8BB8
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x7EC8BC0 Offset: 0x7EC4BC0 VA: 0x7EC8BC0
	private void set_Name(string value) { }

	// RVA: 0x7EC8BC8 Offset: 0x7EC4BC8 VA: 0x7EC8BC8
	public void .ctor(string name) { }
}

// Namespace: 
private struct ProperBitConverter.SingleByteUnion // TypeDefIndex: 22423
{
	// Fields
	public byte Byte0; // 0x0
	public byte Byte1; // 0x1
	public byte Byte2; // 0x2
	public byte Byte3; // 0x3
	public float Value; // 0x0
}

// Namespace: 
private struct ProperBitConverter.DoubleByteUnion // TypeDefIndex: 22424
{
	// Fields
	public byte Byte0; // 0x0
	public byte Byte1; // 0x1
	public byte Byte2; // 0x2
	public byte Byte3; // 0x3
	public byte Byte4; // 0x4
	public byte Byte5; // 0x5
	public byte Byte6; // 0x6
	public byte Byte7; // 0x7
	public double Value; // 0x0
}

// Namespace: 
private struct ProperBitConverter.DecimalByteUnion // TypeDefIndex: 22425
{
	// Fields
	public byte Byte0; // 0x0
	public byte Byte1; // 0x1
	public byte Byte2; // 0x2
	public byte Byte3; // 0x3
	public byte Byte4; // 0x4
	public byte Byte5; // 0x5
	public byte Byte6; // 0x6
	public byte Byte7; // 0x7
	public byte Byte8; // 0x8
	public byte Byte9; // 0x9
	public byte Byte10; // 0xA
	public byte Byte11; // 0xB
	public byte Byte12; // 0xC
	public byte Byte13; // 0xD
	public byte Byte14; // 0xE
	public byte Byte15; // 0xF
	public Decimal Value; // 0x0
}

// Namespace: 
private struct ProperBitConverter.GuidByteUnion // TypeDefIndex: 22426
{
	// Fields
	public byte Byte0; // 0x0
	public byte Byte1; // 0x1
	public byte Byte2; // 0x2
	public byte Byte3; // 0x3
	public byte Byte4; // 0x4
	public byte Byte5; // 0x5
	public byte Byte6; // 0x6
	public byte Byte7; // 0x7
	public byte Byte8; // 0x8
	public byte Byte9; // 0x9
	public byte Byte10; // 0xA
	public byte Byte11; // 0xB
	public byte Byte12; // 0xC
	public byte Byte13; // 0xD
	public byte Byte14; // 0xE
	public byte Byte15; // 0xF
	public Guid Value; // 0x0
}

// Namespace: Sirenix.Serialization
public static class ProperBitConverter // TypeDefIndex: 22427
{
	// Fields
	private static readonly uint[] ByteToHexCharLookupLowerCase; // 0x0
	private static readonly uint[] ByteToHexCharLookupUpperCase; // 0x8
	private static readonly byte[] HexToByteLookup; // 0x10

	// Methods

	// RVA: 0x7EC8BF8 Offset: 0x7EC4BF8 VA: 0x7EC8BF8
	private static uint[] CreateByteToHexLookup(bool upperCase) { }

	// RVA: 0x7EC8DC4 Offset: 0x7EC4DC4 VA: 0x7EC8DC4
	public static string BytesToHexString(byte[] bytes, bool lowerCaseHexChars = True) { }

	// RVA: 0x7EC8EF0 Offset: 0x7EC4EF0 VA: 0x7EC8EF0
	public static byte[] HexStringToBytes(string hex) { }

	// RVA: 0x7EC970C Offset: 0x7EC570C VA: 0x7EC970C
	public static short ToInt16(byte[] buffer, int index) { }

	// RVA: 0x7EC974C Offset: 0x7EC574C VA: 0x7EC974C
	public static ushort ToUInt16(byte[] buffer, int index) { }

	// RVA: 0x7EC978C Offset: 0x7EC578C VA: 0x7EC978C
	public static int ToInt32(byte[] buffer, int index) { }

	// RVA: 0x7EC97F8 Offset: 0x7EC57F8 VA: 0x7EC97F8
	public static uint ToUInt32(byte[] buffer, int index) { }

	// RVA: 0x7EC9864 Offset: 0x7EC5864 VA: 0x7EC9864
	public static long ToInt64(byte[] buffer, int index) { }

	// RVA: 0x7EC9924 Offset: 0x7EC5924 VA: 0x7EC9924
	public static ulong ToUInt64(byte[] buffer, int index) { }

	// RVA: 0x7EC99E4 Offset: 0x7EC59E4 VA: 0x7EC99E4
	public static float ToSingle(byte[] buffer, int index) { }

	// RVA: 0x7EC9A50 Offset: 0x7EC5A50 VA: 0x7EC9A50
	public static double ToDouble(byte[] buffer, int index) { }

	// RVA: 0x7EC9B0C Offset: 0x7EC5B0C VA: 0x7EC9B0C
	public static Decimal ToDecimal(byte[] buffer, int index) { }

	// RVA: 0x7EC9C80 Offset: 0x7EC5C80 VA: 0x7EC9C80
	public static Guid ToGuid(byte[] buffer, int index) { }

	// RVA: 0x7EC9DF4 Offset: 0x7EC5DF4 VA: 0x7EC9DF4
	public static void GetBytes(byte[] buffer, int index, short value) { }

	// RVA: 0x7EC9E3C Offset: 0x7EC5E3C VA: 0x7EC9E3C
	public static void GetBytes(byte[] buffer, int index, ushort value) { }

	// RVA: 0x7EC9E84 Offset: 0x7EC5E84 VA: 0x7EC9E84
	public static void GetBytes(byte[] buffer, int index, int value) { }

	// RVA: 0x7EC9F04 Offset: 0x7EC5F04 VA: 0x7EC9F04
	public static void GetBytes(byte[] buffer, int index, uint value) { }

	// RVA: 0x7EC9F84 Offset: 0x7EC5F84 VA: 0x7EC9F84
	public static void GetBytes(byte[] buffer, int index, long value) { }

	// RVA: 0x7ECA074 Offset: 0x7EC6074 VA: 0x7ECA074
	public static void GetBytes(byte[] buffer, int index, ulong value) { }

	// RVA: 0x7ECA164 Offset: 0x7EC6164 VA: 0x7ECA164
	public static void GetBytes(byte[] buffer, int index, float value) { }

	// RVA: 0x7ECA1E8 Offset: 0x7EC61E8 VA: 0x7ECA1E8
	public static void GetBytes(byte[] buffer, int index, double value) { }

	// RVA: 0x7ECA2DC Offset: 0x7EC62DC VA: 0x7ECA2DC
	public static void GetBytes(byte[] buffer, int index, Decimal value) { }

	// RVA: 0x7ECA4A8 Offset: 0x7EC64A8 VA: 0x7ECA4A8
	public static void GetBytes(byte[] buffer, int index, Guid value) { }

	// RVA: 0x7ECA674 Offset: 0x7EC6674 VA: 0x7ECA674
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
[Usage(1, AllowMultiple = True)]
public class RegisterFormatterAttribute : Attribute // TypeDefIndex: 22428
{
	// Fields
	[CompilerGenerated]
	private Type <FormatterType>k__BackingField; // 0x10
	[CompilerGenerated]
	private Type <WeakFallback>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <Priority>k__BackingField; // 0x20

	// Properties
	public Type FormatterType { get; set; }
	public Type WeakFallback { get; set; }
	public int Priority { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7ECA750 Offset: 0x7EC6750 VA: 0x7ECA750
	public Type get_FormatterType() { }

	[CompilerGenerated]
	// RVA: 0x7ECA758 Offset: 0x7EC6758 VA: 0x7ECA758
	private void set_FormatterType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x7ECA760 Offset: 0x7EC6760 VA: 0x7ECA760
	public Type get_WeakFallback() { }

	[CompilerGenerated]
	// RVA: 0x7ECA768 Offset: 0x7EC6768 VA: 0x7ECA768
	private void set_WeakFallback(Type value) { }

	[CompilerGenerated]
	// RVA: 0x7ECA770 Offset: 0x7EC6770 VA: 0x7ECA770
	public int get_Priority() { }

	[CompilerGenerated]
	// RVA: 0x7ECA778 Offset: 0x7EC6778 VA: 0x7ECA778
	private void set_Priority(int value) { }

	// RVA: 0x7ECA780 Offset: 0x7EC6780 VA: 0x7ECA780
	public void .ctor(Type formatterType, int priority = 0) { }

	// RVA: 0x7ECA7BC Offset: 0x7EC67BC VA: 0x7ECA7BC
	public void .ctor(Type formatterType, Type weakFallback, int priority = 0) { }
}

// Namespace: Sirenix.Serialization
[Usage(1, AllowMultiple = True)]
public class RegisterFormatterLocatorAttribute : Attribute // TypeDefIndex: 22429
{
	// Fields
	[CompilerGenerated]
	private Type <FormatterLocatorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Priority>k__BackingField; // 0x18

	// Properties
	public Type FormatterLocatorType { get; set; }
	public int Priority { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7ECA814 Offset: 0x7EC6814 VA: 0x7ECA814
	public Type get_FormatterLocatorType() { }

	[CompilerGenerated]
	// RVA: 0x7ECA81C Offset: 0x7EC681C VA: 0x7ECA81C
	private void set_FormatterLocatorType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x7ECA824 Offset: 0x7EC6824 VA: 0x7ECA824
	public int get_Priority() { }

	[CompilerGenerated]
	// RVA: 0x7ECA82C Offset: 0x7EC682C VA: 0x7ECA82C
	private void set_Priority(int value) { }

	// RVA: 0x7ECA834 Offset: 0x7EC6834 VA: 0x7ECA834
	public void .ctor(Type formatterLocatorType, int priority = 0) { }
}

// Namespace: Sirenix.Serialization
public class SerializationAbortException : Exception // TypeDefIndex: 22430
{
	// Methods

	// RVA: 0x7EBC03C Offset: 0x7EB803C VA: 0x7EBC03C
	public void .ctor(string message) { }

	// RVA: 0x7ECA870 Offset: 0x7EC6870 VA: 0x7ECA870
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: Sirenix.Serialization
public class SerializationConfig // TypeDefIndex: 22431
{
	// Fields
	private readonly object LOCK; // 0x10
	private ISerializationPolicy serializationPolicy; // 0x18
	private DebugContext debugContext; // 0x20
	public bool AllowDeserializeInvalidData; // 0x28

	// Properties
	public ISerializationPolicy SerializationPolicy { get; set; }
	public DebugContext DebugContext { get; set; }

	// Methods

	// RVA: 0x7EC2294 Offset: 0x7EBE294 VA: 0x7EC2294
	public void .ctor() { }

	// RVA: 0x7EB8C84 Offset: 0x7EB4C84 VA: 0x7EB8C84
	public ISerializationPolicy get_SerializationPolicy() { }

	// RVA: 0x7ECAC6C Offset: 0x7EC6C6C VA: 0x7ECAC6C
	public void set_SerializationPolicy(ISerializationPolicy value) { }

	// RVA: 0x7EB8FBC Offset: 0x7EB4FBC VA: 0x7EB8FBC
	public DebugContext get_DebugContext() { }

	// RVA: 0x7ECADA8 Offset: 0x7EC6DA8 VA: 0x7ECADA8
	public void set_DebugContext(DebugContext value) { }

	// RVA: 0x7EC294C Offset: 0x7EBE94C VA: 0x7EC294C
	public void ResetToDefault() { }
}

// Namespace: Sirenix.Serialization
public sealed class DebugContext // TypeDefIndex: 22432
{
	// Fields
	private readonly object LOCK; // 0x10
	private ILogger logger; // 0x18
	private LoggingPolicy loggingPolicy; // 0x20
	private ErrorHandlingPolicy errorHandlingPolicy; // 0x24

	// Properties
	public ILogger Logger { get; set; }
	public LoggingPolicy LoggingPolicy { get; set; }
	public ErrorHandlingPolicy ErrorHandlingPolicy { get; set; }

	// Methods

	// RVA: 0x7ECAF50 Offset: 0x7EC6F50 VA: 0x7ECAF50
	public ILogger get_Logger() { }

	// RVA: 0x7ECB094 Offset: 0x7EC7094 VA: 0x7ECB094
	public void set_Logger(ILogger value) { }

	// RVA: 0x7ECB164 Offset: 0x7EC7164 VA: 0x7ECB164
	public LoggingPolicy get_LoggingPolicy() { }

	// RVA: 0x7ECB17C Offset: 0x7EC717C VA: 0x7ECB17C
	public void set_LoggingPolicy(LoggingPolicy value) { }

	// RVA: 0x7ECB1A0 Offset: 0x7EC71A0 VA: 0x7ECB1A0
	public ErrorHandlingPolicy get_ErrorHandlingPolicy() { }

	// RVA: 0x7ECB1B8 Offset: 0x7EC71B8 VA: 0x7ECB1B8
	public void set_ErrorHandlingPolicy(ErrorHandlingPolicy value) { }

	// RVA: 0x7EB9238 Offset: 0x7EB5238 VA: 0x7EB9238
	public void LogWarning(string message) { }

	// RVA: 0x7EB90F0 Offset: 0x7EB50F0 VA: 0x7EB90F0
	public void LogError(string message) { }

	// RVA: 0x7EB977C Offset: 0x7EB577C VA: 0x7EB977C
	public void LogException(Exception exception) { }

	// RVA: 0x7ECAE78 Offset: 0x7EC6E78 VA: 0x7ECAE78
	public void ResetToDefault() { }

	// RVA: 0x7ECAD3C Offset: 0x7EC6D3C VA: 0x7ECAD3C
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class SerializationContext : ICacheNotificationReceiver // TypeDefIndex: 22433
{
	// Fields
	private SerializationConfig config; // 0x10
	private Dictionary<object, int> internalReferenceIdMap; // 0x18
	private StreamingContext streamingContext; // 0x20
	private IFormatterConverter formatterConverter; // 0x30
	private TwoWaySerializationBinder binder; // 0x38
	[CompilerGenerated]
	private IExternalIndexReferenceResolver <IndexReferenceResolver>k__BackingField; // 0x40
	[CompilerGenerated]
	private IExternalStringReferenceResolver <StringReferenceResolver>k__BackingField; // 0x48
	[CompilerGenerated]
	private IExternalGuidReferenceResolver <GuidReferenceResolver>k__BackingField; // 0x50

	// Properties
	public TwoWaySerializationBinder Binder { get; set; }
	public StreamingContext StreamingContext { get; }
	public IFormatterConverter FormatterConverter { get; }
	public IExternalIndexReferenceResolver IndexReferenceResolver { get; set; }
	public IExternalStringReferenceResolver StringReferenceResolver { get; set; }
	public IExternalGuidReferenceResolver GuidReferenceResolver { get; set; }
	public SerializationConfig Config { get; set; }

	// Methods

	// RVA: 0x7ECB1DC Offset: 0x7EC71DC VA: 0x7ECB1DC
	public void .ctor() { }

	// RVA: 0x7ECB38C Offset: 0x7EC738C VA: 0x7ECB38C
	public void .ctor(StreamingContext context) { }

	// RVA: 0x7ECB400 Offset: 0x7EC7400 VA: 0x7ECB400
	public void .ctor(FormatterConverter formatterConverter) { }

	// RVA: 0x7ECB240 Offset: 0x7EC7240 VA: 0x7ECB240
	public void .ctor(StreamingContext context, FormatterConverter formatterConverter) { }

	// RVA: 0x7EBBBD0 Offset: 0x7EB7BD0 VA: 0x7EBBBD0
	public TwoWaySerializationBinder get_Binder() { }

	// RVA: 0x7ECB4AC Offset: 0x7EC74AC VA: 0x7ECB4AC
	public void set_Binder(TwoWaySerializationBinder value) { }

	// RVA: 0x7ECB4B4 Offset: 0x7EC74B4 VA: 0x7ECB4B4
	public StreamingContext get_StreamingContext() { }

	// RVA: 0x7ECB4C0 Offset: 0x7EC74C0 VA: 0x7ECB4C0
	public IFormatterConverter get_FormatterConverter() { }

	[CompilerGenerated]
	// RVA: 0x7ECB4C8 Offset: 0x7EC74C8 VA: 0x7ECB4C8
	public IExternalIndexReferenceResolver get_IndexReferenceResolver() { }

	[CompilerGenerated]
	// RVA: 0x7ECB4D0 Offset: 0x7EC74D0 VA: 0x7ECB4D0
	public void set_IndexReferenceResolver(IExternalIndexReferenceResolver value) { }

	[CompilerGenerated]
	// RVA: 0x7ECB4D8 Offset: 0x7EC74D8 VA: 0x7ECB4D8
	public IExternalStringReferenceResolver get_StringReferenceResolver() { }

	[CompilerGenerated]
	// RVA: 0x7ECB4E0 Offset: 0x7EC74E0 VA: 0x7ECB4E0
	public void set_StringReferenceResolver(IExternalStringReferenceResolver value) { }

	[CompilerGenerated]
	// RVA: 0x7ECB4E8 Offset: 0x7EC74E8 VA: 0x7ECB4E8
	public IExternalGuidReferenceResolver get_GuidReferenceResolver() { }

	[CompilerGenerated]
	// RVA: 0x7ECB4F0 Offset: 0x7EC74F0 VA: 0x7ECB4F0
	public void set_GuidReferenceResolver(IExternalGuidReferenceResolver value) { }

	// RVA: 0x7EB9C98 Offset: 0x7EB5C98 VA: 0x7EB9C98
	public SerializationConfig get_Config() { }

	// RVA: 0x7ECB4F8 Offset: 0x7EC74F8 VA: 0x7ECB4F8
	public void set_Config(SerializationConfig value) { }

	// RVA: 0x7ECB500 Offset: 0x7EC7500 VA: 0x7ECB500
	public bool TryGetInternalReferenceId(object reference, out int id) { }

	// RVA: 0x7ECB568 Offset: 0x7EC7568 VA: 0x7ECB568
	public bool TryRegisterInternalReference(object reference, out int id) { }

	// RVA: 0x7ECB638 Offset: 0x7EC7638 VA: 0x7ECB638
	public bool TryRegisterExternalReference(object obj, out int index) { }

	// RVA: 0x7ECB70C Offset: 0x7EC770C VA: 0x7ECB70C
	public bool TryRegisterExternalReference(object obj, out Guid guid) { }

	// RVA: 0x7ECB85C Offset: 0x7EC785C VA: 0x7ECB85C
	public bool TryRegisterExternalReference(object obj, out string id) { }

	// RVA: 0x7ECB998 Offset: 0x7EC7998 VA: 0x7ECB998
	public void ResetInternalReferences() { }

	// RVA: 0x7ECB410 Offset: 0x7EC7410 VA: 0x7ECB410
	public void ResetToDefault() { }

	// RVA: 0x7ECB9E8 Offset: 0x7EC79E8 VA: 0x7ECB9E8 Slot: 4
	private void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnFreed() { }

	// RVA: 0x7ECB9EC Offset: 0x7EC79EC VA: 0x7ECB9EC Slot: 5
	private void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnClaimed() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SerializationPolicies.<>c // TypeDefIndex: 22434
{
	// Fields
	public static readonly SerializationPolicies.<>c <>9; // 0x0
	public static Func<MemberInfo, bool> <>9__6_0; // 0x8
	public static Func<MemberInfo, bool> <>9__10_0; // 0x10

	// Methods

	// RVA: 0x7ECBBA8 Offset: 0x7EC7BA8 VA: 0x7ECBBA8
	private static void .cctor() { }

	// RVA: 0x7ECBC10 Offset: 0x7EC7C10 VA: 0x7ECBC10
	public void .ctor() { }

	// RVA: 0x7ECBC18 Offset: 0x7EC7C18 VA: 0x7ECBC18
	internal bool <get_Everything>b__6_0(MemberInfo member) { }

	// RVA: 0x7ECBCE8 Offset: 0x7EC7CE8 VA: 0x7ECBCE8
	internal bool <get_Strict>b__10_0(MemberInfo member) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SerializationPolicies.<>c__DisplayClass8_0 // TypeDefIndex: 22435
{
	// Fields
	public Type tupleInterface; // 0x10

	// Methods

	// RVA: 0x7ECBB24 Offset: 0x7EC7B24 VA: 0x7ECBB24
	public void .ctor() { }

	// RVA: 0x7ECBF7C Offset: 0x7EC7F7C VA: 0x7ECBF7C
	internal bool <get_Unity>b__0(MemberInfo member) { }
}

// Namespace: Sirenix.Serialization
public static class SerializationPolicies // TypeDefIndex: 22436
{
	// Fields
	private static readonly object LOCK; // 0x0
	private static ISerializationPolicy everythingPolicy; // 0x8
	private static ISerializationPolicy unityPolicy; // 0x10
	private static ISerializationPolicy strictPolicy; // 0x18

	// Properties
	public static ISerializationPolicy Everything { get; }
	public static ISerializationPolicy Unity { get; }
	public static ISerializationPolicy Strict { get; }

	// Methods

	// RVA: 0x7ECB9F0 Offset: 0x7EC79F0 VA: 0x7ECB9F0
	public static bool TryGetByID(string name, out ISerializationPolicy policy) { }

	// RVA: 0x7EC68F4 Offset: 0x7EC28F4 VA: 0x7EC68F4
	public static ISerializationPolicy get_Everything() { }

	// RVA: 0x7ECA8E0 Offset: 0x7EC68E0 VA: 0x7ECA8E0
	public static ISerializationPolicy get_Unity() { }

	// RVA: 0x7EC2F08 Offset: 0x7EBEF08 VA: 0x7EC2F08
	public static ISerializationPolicy get_Strict() { }

	// RVA: 0x7ECBB2C Offset: 0x7EC7B2C VA: 0x7ECBB2C
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public static class SerializationUtility // TypeDefIndex: 22437
{
	// Methods

	// RVA: 0x7ECC2DC Offset: 0x7EC82DC VA: 0x7ECC2DC
	public static IDataWriter CreateWriter(Stream stream, SerializationContext context, DataFormat format) { }

	// RVA: 0x7ECC4B4 Offset: 0x7EC84B4 VA: 0x7ECC4B4
	public static IDataReader CreateReader(Stream stream, DeserializationContext context, DataFormat format) { }

	// RVA: 0x7ECC688 Offset: 0x7EC8688 VA: 0x7ECC688
	private static IDataWriter GetCachedWriter(out IDisposable cache, DataFormat format, Stream stream, SerializationContext context) { }

	// RVA: 0x7ECC8A0 Offset: 0x7EC88A0 VA: 0x7ECC8A0
	private static IDataReader GetCachedReader(out IDisposable cache, DataFormat format, Stream stream, DeserializationContext context) { }

	// RVA: 0x7ECCAB8 Offset: 0x7EC8AB8 VA: 0x7ECCAB8
	public static void SerializeValueWeak(object value, IDataWriter writer) { }

	// RVA: 0x7ECCC64 Offset: 0x7EC8C64 VA: 0x7ECCC64
	public static void SerializeValueWeak(object value, IDataWriter writer, out List<Object> unityObjects) { }

	// RVA: -1 Offset: -1
	public static void SerializeValue<T>(T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46EF61C Offset: 0x46EB61C VA: 0x46EF61C
	|-SerializationUtility.SerializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SerializeValue<T>(T value, IDataWriter writer, out List<Object> unityObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46EF920 Offset: 0x46EB920 VA: 0x46EF920
	|-SerializationUtility.SerializeValue<object>
	|
	|-RVA: 0x46F004C Offset: 0x46EC04C VA: 0x46F004C
	|-SerializationUtility.SerializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7ECCF88 Offset: 0x7EC8F88 VA: 0x7ECCF88
	public static void SerializeValueWeak(object value, Stream stream, DataFormat format, SerializationContext context) { }

	// RVA: 0x7ECD358 Offset: 0x7EC9358 VA: 0x7ECD358
	public static void SerializeValueWeak(object value, Stream stream, DataFormat format, out List<Object> unityObjects, SerializationContext context) { }

	// RVA: -1 Offset: -1
	public static void SerializeValue<T>(T value, Stream stream, DataFormat format, SerializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F089C Offset: 0x46EC89C VA: 0x46F089C
	|-SerializationUtility.SerializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SerializeValue<T>(T value, Stream stream, DataFormat format, out List<Object> unityObjects, SerializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F0D70 Offset: 0x46ECD70 VA: 0x46F0D70
	|-SerializationUtility.SerializeValue<object>
	|
	|-RVA: 0x46F1180 Offset: 0x46ED180 VA: 0x46F1180
	|-SerializationUtility.SerializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7ECD734 Offset: 0x7EC9734 VA: 0x7ECD734
	public static byte[] SerializeValueWeak(object value, DataFormat format, SerializationContext context) { }

	// RVA: 0x7ECD938 Offset: 0x7EC9938 VA: 0x7ECD938
	public static byte[] SerializeValueWeak(object value, DataFormat format, out List<Object> unityObjects) { }

	// RVA: -1 Offset: -1
	public static byte[] SerializeValue<T>(T value, DataFormat format, SerializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46EFD7C Offset: 0x46EBD7C VA: 0x46EFD7C
	|-SerializationUtility.SerializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static byte[] SerializeValue<T>(T value, DataFormat format, out List<Object> unityObjects, SerializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F05BC Offset: 0x46EC5BC VA: 0x46F05BC
	|-SerializationUtility.SerializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7ECDB40 Offset: 0x7EC9B40 VA: 0x7ECDB40
	public static object DeserializeValueWeak(IDataReader reader) { }

	// RVA: 0x7ECDC04 Offset: 0x7EC9C04 VA: 0x7ECDC04
	public static object DeserializeValueWeak(IDataReader reader, List<Object> referencedUnityObjects) { }

	// RVA: -1 Offset: -1
	public static T DeserializeValue<T>(IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46ED6E0 Offset: 0x46E96E0 VA: 0x46ED6E0
	|-SerializationUtility.DeserializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T DeserializeValue<T>(IDataReader reader, List<Object> referencedUnityObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46ED924 Offset: 0x46E9924 VA: 0x46ED924
	|-SerializationUtility.DeserializeValue<object>
	|
	|-RVA: 0x46EDD58 Offset: 0x46E9D58 VA: 0x46EDD58
	|-SerializationUtility.DeserializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7ECDF0C Offset: 0x7EC9F0C VA: 0x7ECDF0C
	public static object DeserializeValueWeak(Stream stream, DataFormat format, DeserializationContext context) { }

	// RVA: 0x7ECE2F0 Offset: 0x7ECA2F0 VA: 0x7ECE2F0
	public static object DeserializeValueWeak(Stream stream, DataFormat format, List<Object> referencedUnityObjects, DeserializationContext context) { }

	// RVA: -1 Offset: -1
	public static T DeserializeValue<T>(Stream stream, DataFormat format, DeserializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46EE504 Offset: 0x46EA504 VA: 0x46EE504
	|-SerializationUtility.DeserializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T DeserializeValue<T>(Stream stream, DataFormat format, List<Object> referencedUnityObjects, DeserializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46EEA20 Offset: 0x46EAA20 VA: 0x46EEA20
	|-SerializationUtility.DeserializeValue<object>
	|
	|-RVA: 0x46EF0FC Offset: 0x46EB0FC VA: 0x46EF0FC
	|-SerializationUtility.DeserializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7ECE6E0 Offset: 0x7ECA6E0 VA: 0x7ECE6E0
	public static object DeserializeValueWeak(byte[] bytes, DataFormat format, DeserializationContext context) { }

	// RVA: 0x7ECE8A8 Offset: 0x7ECA8A8 VA: 0x7ECE8A8
	public static object DeserializeValueWeak(byte[] bytes, DataFormat format, List<Object> referencedUnityObjects) { }

	// RVA: -1 Offset: -1
	public static T DeserializeValue<T>(byte[] bytes, DataFormat format, DeserializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46EE254 Offset: 0x46EA254 VA: 0x46EE254
	|-SerializationUtility.DeserializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T DeserializeValue<T>(byte[] bytes, DataFormat format, List<Object> referencedUnityObjects, DeserializationContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46EEE44 Offset: 0x46EAE44 VA: 0x46EEE44
	|-SerializationUtility.DeserializeValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7ECEA74 Offset: 0x7ECAA74 VA: 0x7ECEA74
	public static object CreateCopy(object obj) { }
}

// Namespace: Sirenix.Serialization
public abstract class TwoWaySerializationBinder // TypeDefIndex: 22438
{
	// Fields
	public static readonly TwoWaySerializationBinder Default; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string BindToName(Type type, DebugContext debugContext);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string typeName, DebugContext debugContext);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool ContainsType(string typeName);

	// RVA: 0x7EC1DA4 Offset: 0x7EBDDA4 VA: 0x7EC1DA4
	protected void .ctor() { }

	// RVA: 0x7ECF300 Offset: 0x7ECB300 VA: 0x7ECF300
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class AnySerializer : Serializer // TypeDefIndex: 22439
{
	// Fields
	private static readonly ISerializationPolicy UnityPolicy; // 0x0
	private static readonly ISerializationPolicy StrictPolicy; // 0x8
	private static readonly ISerializationPolicy EverythingPolicy; // 0x10
	private readonly Type SerializedType; // 0x10
	private readonly bool IsEnum; // 0x18
	private readonly bool IsValueType; // 0x19
	private readonly bool MayBeBoxedValueType; // 0x1A
	private readonly bool IsAbstract; // 0x1B
	private readonly bool IsNullable; // 0x1C
	private readonly bool AllowDeserializeInvalidData; // 0x1D
	private IFormatter UnityPolicyFormatter; // 0x20
	private IFormatter StrictPolicyFormatter; // 0x28
	private IFormatter EverythingPolicyFormatter; // 0x30
	private readonly Dictionary<ISerializationPolicy, IFormatter> FormattersByPolicy; // 0x38
	private readonly object FormattersByPolicy_LOCK; // 0x40

	// Methods

	// RVA: 0x7ECF378 Offset: 0x7ECB378 VA: 0x7ECF378
	public void .ctor(Type serializedType) { }

	// RVA: 0x7ECF764 Offset: 0x7ECB764 VA: 0x7ECF764 Slot: 4
	public override object ReadValueWeak(IDataReader reader) { }

	// RVA: 0x7ED2B10 Offset: 0x7ECEB10 VA: 0x7ED2B10 Slot: 5
	public override void WriteValueWeak(string name, object value, IDataWriter writer) { }

	// RVA: 0x7ED2808 Offset: 0x7ECE808 VA: 0x7ED2808
	private IFormatter GetBaseFormatter(ISerializationPolicy serializationPolicy) { }

	// RVA: 0x7ED39C8 Offset: 0x7ECF9C8 VA: 0x7ED39C8
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class BooleanSerializer : Serializer<bool> // TypeDefIndex: 22440
{
	// Methods

	// RVA: 0x7ED3A7C Offset: 0x7ECFA7C VA: 0x7ED3A7C Slot: 6
	public override bool ReadValue(IDataReader reader) { }

	// RVA: 0x7ED3F00 Offset: 0x7ECFF00 VA: 0x7ED3F00 Slot: 7
	public override void WriteValue(string name, bool value, IDataWriter writer) { }

	// RVA: 0x7ED3FB8 Offset: 0x7ECFFB8 VA: 0x7ED3FB8
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class ByteSerializer : Serializer<byte> // TypeDefIndex: 22441
{
	// Methods

	// RVA: 0x7ED4000 Offset: 0x7ED0000 VA: 0x7ED4000 Slot: 6
	public override byte ReadValue(IDataReader reader) { }

	// RVA: 0x7ED447C Offset: 0x7ED047C VA: 0x7ED447C Slot: 7
	public override void WriteValue(string name, byte value, IDataWriter writer) { }

	// RVA: 0x7ED4534 Offset: 0x7ED0534 VA: 0x7ED4534
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class CharSerializer : Serializer<char> // TypeDefIndex: 22442
{
	// Methods

	// RVA: 0x7ED457C Offset: 0x7ED057C VA: 0x7ED457C Slot: 6
	public override char ReadValue(IDataReader reader) { }

	// RVA: 0x7ED49F8 Offset: 0x7ED09F8 VA: 0x7ED49F8 Slot: 7
	public override void WriteValue(string name, char value, IDataWriter writer) { }

	// RVA: 0x7ED4AB0 Offset: 0x7ED0AB0 VA: 0x7ED4AB0
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public class ComplexTypeSerializer<T> : Serializer<T> // TypeDefIndex: 22443
{
	// Fields
	private static readonly bool ComplexTypeMayBeBoxedValueType; // 0x0
	private static readonly bool ComplexTypeIsAbstract; // 0x0
	private static readonly bool ComplexTypeIsNullable; // 0x0
	private static readonly bool ComplexTypeIsValueType; // 0x0
	private static readonly Type TypeOf_T; // 0x0
	private static readonly bool AllowDeserializeInvalidDataForT; // 0x0
	private static readonly Dictionary<ISerializationPolicy, IFormatter<T>> FormattersByPolicy; // 0x0
	private static readonly object FormattersByPolicy_LOCK; // 0x0
	private static readonly ISerializationPolicy UnityPolicy; // 0x0
	private static readonly ISerializationPolicy StrictPolicy; // 0x0
	private static readonly ISerializationPolicy EverythingPolicy; // 0x0
	private static IFormatter<T> UnityPolicyFormatter; // 0x0
	private static IFormatter<T> StrictPolicyFormatter; // 0x0
	private static IFormatter<T> EverythingPolicyFormatter; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public override T ReadValue(IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9A420 Offset: 0x5C96420 VA: 0x5C9A420
	|-ComplexTypeSerializer<__Il2CppFullySharedGenericType>.ReadValue
	*/

	// RVA: -1 Offset: -1
	private static IFormatter<T> GetBaseFormatter(ISerializationPolicy serializationPolicy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9E04C Offset: 0x5C9A04C VA: 0x5C9E04C
	|-ComplexTypeSerializer<__Il2CppFullySharedGenericType>.GetBaseFormatter
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteValue(string name, T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9E9F0 Offset: 0x5C9A9F0 VA: 0x5C9E9F0
	|-ComplexTypeSerializer<__Il2CppFullySharedGenericType>.WriteValue
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9FBC4 Offset: 0x5C9BBC4 VA: 0x5C9FBC4
	|-ComplexTypeSerializer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9FBD8 Offset: 0x5C9BBD8 VA: 0x5C9FBD8
	|-ComplexTypeSerializer<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Sirenix.Serialization
public sealed class DecimalSerializer : Serializer<Decimal> // TypeDefIndex: 22444
{
	// Methods

	// RVA: 0x7ED4AF8 Offset: 0x7ED0AF8 VA: 0x7ED4AF8 Slot: 6
	public override Decimal ReadValue(IDataReader reader) { }

	// RVA: 0x7ED4FD4 Offset: 0x7ED0FD4 VA: 0x7ED4FD4 Slot: 7
	public override void WriteValue(string name, Decimal value, IDataWriter writer) { }

	// RVA: 0x7ED5094 Offset: 0x7ED1094 VA: 0x7ED5094
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class DoubleSerializer : Serializer<double> // TypeDefIndex: 22445
{
	// Methods

	// RVA: 0x7ED50DC Offset: 0x7ED10DC VA: 0x7ED50DC Slot: 6
	public override double ReadValue(IDataReader reader) { }

	// RVA: 0x7ED55C8 Offset: 0x7ED15C8 VA: 0x7ED55C8 Slot: 7
	public override void WriteValue(string name, double value, IDataWriter writer) { }

	// RVA: 0x7ED5680 Offset: 0x7ED1680 VA: 0x7ED5680
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class EnumSerializer<T> : Serializer<T> // TypeDefIndex: 22446
{
	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60BAEEC Offset: 0x60B6EEC VA: 0x60BAEEC
	|-EnumSerializer<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override T ReadValue(IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60BB02C Offset: 0x60B702C VA: 0x60BB02C
	|-EnumSerializer<__Il2CppFullySharedGenericType>.ReadValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteValue(string name, T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60BB634 Offset: 0x60B7634 VA: 0x60BB634
	|-EnumSerializer<__Il2CppFullySharedGenericType>.WriteValue
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60BB914 Offset: 0x60B7914 VA: 0x60BB914
	|-EnumSerializer<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Sirenix.Serialization
public sealed class GuidSerializer : Serializer<Guid> // TypeDefIndex: 22447
{
	// Methods

	// RVA: 0x7ED56C8 Offset: 0x7ED16C8 VA: 0x7ED56C8 Slot: 6
	public override Guid ReadValue(IDataReader reader) { }

	// RVA: 0x7ED5B48 Offset: 0x7ED1B48 VA: 0x7ED5B48 Slot: 7
	public override void WriteValue(string name, Guid value, IDataWriter writer) { }

	// RVA: 0x7ED5C08 Offset: 0x7ED1C08 VA: 0x7ED5C08
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class Int16Serializer : Serializer<short> // TypeDefIndex: 22448
{
	// Methods

	// RVA: 0x7ED5C50 Offset: 0x7ED1C50 VA: 0x7ED5C50 Slot: 6
	public override short ReadValue(IDataReader reader) { }

	// RVA: 0x7ED60CC Offset: 0x7ED20CC VA: 0x7ED60CC Slot: 7
	public override void WriteValue(string name, short value, IDataWriter writer) { }

	// RVA: 0x7ED6184 Offset: 0x7ED2184 VA: 0x7ED6184
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class Int32Serializer : Serializer<int> // TypeDefIndex: 22449
{
	// Methods

	// RVA: 0x7ED61CC Offset: 0x7ED21CC VA: 0x7ED61CC Slot: 6
	public override int ReadValue(IDataReader reader) { }

	// RVA: 0x7ED6648 Offset: 0x7ED2648 VA: 0x7ED6648 Slot: 7
	public override void WriteValue(string name, int value, IDataWriter writer) { }

	// RVA: 0x7ED6700 Offset: 0x7ED2700 VA: 0x7ED6700
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class Int64Serializer : Serializer<long> // TypeDefIndex: 22450
{
	// Methods

	// RVA: 0x7ED6748 Offset: 0x7ED2748 VA: 0x7ED6748 Slot: 6
	public override long ReadValue(IDataReader reader) { }

	// RVA: 0x7ED6BC0 Offset: 0x7ED2BC0 VA: 0x7ED6BC0 Slot: 7
	public override void WriteValue(string name, long value, IDataWriter writer) { }

	// RVA: 0x7ED6C78 Offset: 0x7ED2C78 VA: 0x7ED6C78
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class IntPtrSerializer : Serializer<IntPtr> // TypeDefIndex: 22451
{
	// Methods

	// RVA: 0x7ED6CC0 Offset: 0x7ED2CC0 VA: 0x7ED6CC0 Slot: 6
	public override IntPtr ReadValue(IDataReader reader) { }

	// RVA: 0x7ED714C Offset: 0x7ED314C VA: 0x7ED714C Slot: 7
	public override void WriteValue(string name, IntPtr value, IDataWriter writer) { }

	// RVA: 0x7ED7214 Offset: 0x7ED3214 VA: 0x7ED7214
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class SByteSerializer : Serializer<sbyte> // TypeDefIndex: 22452
{
	// Methods

	// RVA: 0x7ED725C Offset: 0x7ED325C VA: 0x7ED725C Slot: 6
	public override sbyte ReadValue(IDataReader reader) { }

	// RVA: 0x7ED76D8 Offset: 0x7ED36D8 VA: 0x7ED76D8 Slot: 7
	public override void WriteValue(string name, sbyte value, IDataWriter writer) { }

	// RVA: 0x7ED7790 Offset: 0x7ED3790 VA: 0x7ED7790
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public abstract class Serializer // TypeDefIndex: 22453
{
	// Fields
	private static readonly Dictionary<Type, Type> PrimitiveReaderWriterTypes; // 0x0
	private static readonly object LOCK; // 0x8
	private static readonly Dictionary<Type, Serializer> Weak_ReaderWriterCache; // 0x10
	private static readonly Dictionary<Type, Serializer> Strong_ReaderWriterCache; // 0x18

	// Methods

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x7ED77D8 Offset: 0x7ED37D8 VA: 0x7ED77D8
	protected static void FireOnSerializedType(Type type) { }

	// RVA: 0x7ECCBAC Offset: 0x7EC8BAC VA: 0x7ECCBAC
	public static Serializer GetForValue(object value) { }

	// RVA: -1 Offset: -1
	public static Serializer<T> Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46F1668 Offset: 0x46ED668 VA: 0x46F1668
	|-Serializer.Get<byte>
	|
	|-RVA: 0x46F1764 Offset: 0x46ED764 VA: 0x46F1764
	|-Serializer.Get<Color>
	|
	|-RVA: 0x46F1860 Offset: 0x46ED860 VA: 0x46F1860
	|-Serializer.Get<int>
	|
	|-RVA: 0x46F195C Offset: 0x46ED95C VA: 0x46F195C
	|-Serializer.Get<Int32Enum>
	|
	|-RVA: 0x46F1A58 Offset: 0x46EDA58 VA: 0x46F1A58
	|-Serializer.Get<object>
	|
	|-RVA: 0x46F1B54 Offset: 0x46EDB54 VA: 0x46F1B54
	|-Serializer.Get<float>
	|
	|-RVA: 0x46F1C50 Offset: 0x46EDC50 VA: 0x46F1C50
	|-Serializer.Get<Vector3>
	|
	|-RVA: 0x46F1D4C Offset: 0x46EDD4C VA: 0x46F1D4C
	|-Serializer.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7EB94C8 Offset: 0x7EB54C8 VA: 0x7EB94C8
	public static Serializer Get(Type type) { }

	// RVA: 0x7ED77DC Offset: 0x7ED37DC VA: 0x7ED77DC
	private static Serializer Get(Type type, bool allowWeakFallback) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object ReadValueWeak(IDataReader reader);

	// RVA: 0x7EBD21C Offset: 0x7EB921C VA: 0x7EBD21C
	public void WriteValueWeak(object value, IDataWriter writer) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteValueWeak(string name, object value, IDataWriter writer);

	// RVA: 0x7ED7A24 Offset: 0x7ED3A24 VA: 0x7ED7A24
	private static Serializer Create(Type type, bool allowWeakfallback) { }

	// RVA: 0x7ED8018 Offset: 0x7ED4018 VA: 0x7ED8018
	private static void LogAOTError(Type type, ExecutionEngineException ex) { }

	// RVA: 0x7ECF75C Offset: 0x7ECB75C VA: 0x7ECF75C
	protected void .ctor() { }

	// RVA: 0x7ED81A8 Offset: 0x7ED41A8 VA: 0x7ED81A8
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public abstract class Serializer<T> : Serializer // TypeDefIndex: 22454
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override object ReadValueWeak(IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E3214 Offset: 0x54DF214 VA: 0x54E3214
	|-Serializer<bool>.ReadValueWeak
	|
	|-RVA: 0x54E3358 Offset: 0x54DF358 VA: 0x54E3358
	|-Serializer<byte>.ReadValueWeak
	|
	|-RVA: 0x54E3494 Offset: 0x54DF494 VA: 0x54E3494
	|-Serializer<char>.ReadValueWeak
	|
	|-RVA: 0x54E35D0 Offset: 0x54DF5D0 VA: 0x54E35D0
	|-Serializer<Color>.ReadValueWeak
	|
	|-RVA: 0x54E3710 Offset: 0x54DF710 VA: 0x54E3710
	|-Serializer<Decimal>.ReadValueWeak
	|
	|-RVA: 0x54E3878 Offset: 0x54DF878 VA: 0x54E3878
	|-Serializer<double>.ReadValueWeak
	|
	|-RVA: 0x54E39B0 Offset: 0x54DF9B0 VA: 0x54E39B0
	|-Serializer<Guid>.ReadValueWeak
	|
	|-RVA: 0x54E3AF0 Offset: 0x54DFAF0 VA: 0x54E3AF0
	|-Serializer<short>.ReadValueWeak
	|
	|-RVA: 0x54E3C2C Offset: 0x54DFC2C VA: 0x54E3C2C
	|-Serializer<int>.ReadValueWeak
	|
	|-RVA: 0x54E3D68 Offset: 0x54DFD68 VA: 0x54E3D68
	|-Serializer<Int32Enum>.ReadValueWeak
	|
	|-RVA: 0x54E3EA4 Offset: 0x54DFEA4 VA: 0x54E3EA4
	|-Serializer<long>.ReadValueWeak
	|
	|-RVA: 0x54E3FE0 Offset: 0x54DFFE0 VA: 0x54E3FE0
	|-Serializer<IntPtr>.ReadValueWeak
	|
	|-RVA: 0x54E411C Offset: 0x54E011C VA: 0x54E411C
	|-Serializer<object>.ReadValueWeak
	|
	|-RVA: 0x54E4224 Offset: 0x54E0224 VA: 0x54E4224
	|-Serializer<sbyte>.ReadValueWeak
	|
	|-RVA: 0x54E4360 Offset: 0x54E0360 VA: 0x54E4360
	|-Serializer<float>.ReadValueWeak
	|
	|-RVA: 0x54E4498 Offset: 0x54E0498 VA: 0x54E4498
	|-Serializer<ushort>.ReadValueWeak
	|
	|-RVA: 0x54E45D4 Offset: 0x54E05D4 VA: 0x54E45D4
	|-Serializer<uint>.ReadValueWeak
	|
	|-RVA: 0x54E4710 Offset: 0x54E0710 VA: 0x54E4710
	|-Serializer<ulong>.ReadValueWeak
	|
	|-RVA: 0x54E484C Offset: 0x54E084C VA: 0x54E484C
	|-Serializer<UIntPtr>.ReadValueWeak
	|
	|-RVA: 0x54E4988 Offset: 0x54E0988 VA: 0x54E4988
	|-Serializer<Vector3>.ReadValueWeak
	|
	|-RVA: 0x54E4AC8 Offset: 0x54E0AC8 VA: 0x54E4AC8
	|-Serializer<__Il2CppFullySharedGenericType>.ReadValueWeak
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void WriteValueWeak(string name, object value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E3254 Offset: 0x54DF254 VA: 0x54E3254
	|-Serializer<bool>.WriteValueWeak
	|
	|-RVA: 0x54E3394 Offset: 0x54DF394 VA: 0x54E3394
	|-Serializer<byte>.WriteValueWeak
	|
	|-RVA: 0x54E34D0 Offset: 0x54DF4D0 VA: 0x54E34D0
	|-Serializer<char>.WriteValueWeak
	|
	|-RVA: 0x54E3610 Offset: 0x54DF610 VA: 0x54E3610
	|-Serializer<Color>.WriteValueWeak
	|
	|-RVA: 0x54E3774 Offset: 0x54DF774 VA: 0x54E3774
	|-Serializer<Decimal>.WriteValueWeak
	|
	|-RVA: 0x54E38B4 Offset: 0x54DF8B4 VA: 0x54E38B4
	|-Serializer<double>.WriteValueWeak
	|
	|-RVA: 0x54E39EC Offset: 0x54DF9EC VA: 0x54E39EC
	|-Serializer<Guid>.WriteValueWeak
	|
	|-RVA: 0x54E3B2C Offset: 0x54DFB2C VA: 0x54E3B2C
	|-Serializer<short>.WriteValueWeak
	|
	|-RVA: 0x54E3C68 Offset: 0x54DFC68 VA: 0x54E3C68
	|-Serializer<int>.WriteValueWeak
	|
	|-RVA: 0x54E3DA4 Offset: 0x54DFDA4 VA: 0x54E3DA4
	|-Serializer<Int32Enum>.WriteValueWeak
	|
	|-RVA: 0x54E3EE0 Offset: 0x54DFEE0 VA: 0x54E3EE0
	|-Serializer<long>.WriteValueWeak
	|
	|-RVA: 0x54E401C Offset: 0x54E001C VA: 0x54E401C
	|-Serializer<IntPtr>.WriteValueWeak
	|
	|-RVA: 0x54E4128 Offset: 0x54E0128 VA: 0x54E4128
	|-Serializer<object>.WriteValueWeak
	|
	|-RVA: 0x54E4260 Offset: 0x54E0260 VA: 0x54E4260
	|-Serializer<sbyte>.WriteValueWeak
	|
	|-RVA: 0x54E439C Offset: 0x54E039C VA: 0x54E439C
	|-Serializer<float>.WriteValueWeak
	|
	|-RVA: 0x54E44D4 Offset: 0x54E04D4 VA: 0x54E44D4
	|-Serializer<ushort>.WriteValueWeak
	|
	|-RVA: 0x54E4610 Offset: 0x54E0610 VA: 0x54E4610
	|-Serializer<uint>.WriteValueWeak
	|
	|-RVA: 0x54E474C Offset: 0x54E074C VA: 0x54E474C
	|-Serializer<ulong>.WriteValueWeak
	|
	|-RVA: 0x54E4888 Offset: 0x54E0888 VA: 0x54E4888
	|-Serializer<UIntPtr>.WriteValueWeak
	|
	|-RVA: 0x54E49C8 Offset: 0x54E09C8 VA: 0x54E49C8
	|-Serializer<Vector3>.WriteValueWeak
	|
	|-RVA: 0x54E4B6C Offset: 0x54E0B6C VA: 0x54E4B6C
	|-Serializer<__Il2CppFullySharedGenericType>.WriteValueWeak
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract T ReadValue(IDataReader reader);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Serializer<__Il2CppFullySharedGenericType>.ReadValue
	*/

	// RVA: -1 Offset: -1
	public void WriteValue(T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E32E0 Offset: 0x54DF2E0 VA: 0x54E32E0
	|-Serializer<bool>.WriteValue
	|
	|-RVA: 0x54E3420 Offset: 0x54DF420 VA: 0x54E3420
	|-Serializer<byte>.WriteValue
	|
	|-RVA: 0x54E355C Offset: 0x54DF55C VA: 0x54E355C
	|-Serializer<char>.WriteValue
	|
	|-RVA: 0x54E36A0 Offset: 0x54DF6A0 VA: 0x54E36A0
	|-Serializer<Color>.WriteValue
	|
	|-RVA: 0x54E3800 Offset: 0x54DF800 VA: 0x54E3800
	|-Serializer<Decimal>.WriteValue
	|
	|-RVA: 0x54E3940 Offset: 0x54DF940 VA: 0x54E3940
	|-Serializer<double>.WriteValue
	|
	|-RVA: 0x54E3A78 Offset: 0x54DFA78 VA: 0x54E3A78
	|-Serializer<Guid>.WriteValue
	|
	|-RVA: 0x54E3BB8 Offset: 0x54DFBB8 VA: 0x54E3BB8
	|-Serializer<short>.WriteValue
	|
	|-RVA: 0x54E3CF4 Offset: 0x54DFCF4 VA: 0x54E3CF4
	|-Serializer<int>.WriteValue
	|
	|-RVA: 0x54E3E30 Offset: 0x54DFE30 VA: 0x54E3E30
	|-Serializer<Int32Enum>.WriteValue
	|
	|-RVA: 0x54E3F6C Offset: 0x54DFF6C VA: 0x54E3F6C
	|-Serializer<long>.WriteValue
	|
	|-RVA: 0x54E40A8 Offset: 0x54E00A8 VA: 0x54E40A8
	|-Serializer<IntPtr>.WriteValue
	|
	|-RVA: 0x54E41B0 Offset: 0x54E01B0 VA: 0x54E41B0
	|-Serializer<object>.WriteValue
	|
	|-RVA: 0x54E42EC Offset: 0x54E02EC VA: 0x54E42EC
	|-Serializer<sbyte>.WriteValue
	|
	|-RVA: 0x54E4428 Offset: 0x54E0428 VA: 0x54E4428
	|-Serializer<float>.WriteValue
	|
	|-RVA: 0x54E4560 Offset: 0x54E0560 VA: 0x54E4560
	|-Serializer<ushort>.WriteValue
	|
	|-RVA: 0x54E469C Offset: 0x54E069C VA: 0x54E469C
	|-Serializer<uint>.WriteValue
	|
	|-RVA: 0x54E47D8 Offset: 0x54E07D8 VA: 0x54E47D8
	|-Serializer<ulong>.WriteValue
	|
	|-RVA: 0x54E4914 Offset: 0x54E0914 VA: 0x54E4914
	|-Serializer<UIntPtr>.WriteValue
	|
	|-RVA: 0x54E4A58 Offset: 0x54E0A58 VA: 0x54E4A58
	|-Serializer<Vector3>.WriteValue
	|
	|-RVA: 0x54E4C58 Offset: 0x54E0C58 VA: 0x54E4C58
	|-Serializer<__Il2CppFullySharedGenericType>.WriteValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteValue(string name, T value, IDataWriter writer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Serializer<__Il2CppFullySharedGenericType>.WriteValue
	*/

	[Conditional("UNITY_EDITOR")]
	// RVA: -1 Offset: -1
	protected static void FireOnSerializedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E32FC Offset: 0x54DF2FC VA: 0x54E32FC
	|-Serializer<bool>.FireOnSerializedType
	|
	|-RVA: 0x54E3438 Offset: 0x54DF438 VA: 0x54E3438
	|-Serializer<byte>.FireOnSerializedType
	|
	|-RVA: 0x54E3574 Offset: 0x54DF574 VA: 0x54E3574
	|-Serializer<char>.FireOnSerializedType
	|
	|-RVA: 0x54E36B4 Offset: 0x54DF6B4 VA: 0x54E36B4
	|-Serializer<Color>.FireOnSerializedType
	|
	|-RVA: 0x54E381C Offset: 0x54DF81C VA: 0x54E381C
	|-Serializer<Decimal>.FireOnSerializedType
	|
	|-RVA: 0x54E3954 Offset: 0x54DF954 VA: 0x54E3954
	|-Serializer<double>.FireOnSerializedType
	|
	|-RVA: 0x54E3A94 Offset: 0x54DFA94 VA: 0x54E3A94
	|-Serializer<Guid>.FireOnSerializedType
	|
	|-RVA: 0x54E3BD0 Offset: 0x54DFBD0 VA: 0x54E3BD0
	|-Serializer<short>.FireOnSerializedType
	|
	|-RVA: 0x54E3D0C Offset: 0x54DFD0C VA: 0x54E3D0C
	|-Serializer<int>.FireOnSerializedType
	|
	|-RVA: 0x54E3E48 Offset: 0x54DFE48 VA: 0x54E3E48
	|-Serializer<Int32Enum>.FireOnSerializedType
	|
	|-RVA: 0x54E3F84 Offset: 0x54DFF84 VA: 0x54E3F84
	|-Serializer<long>.FireOnSerializedType
	|
	|-RVA: 0x54E40C0 Offset: 0x54E00C0 VA: 0x54E40C0
	|-Serializer<IntPtr>.FireOnSerializedType
	|
	|-RVA: 0x54E41C8 Offset: 0x54E01C8 VA: 0x54E41C8
	|-Serializer<object>.FireOnSerializedType
	|
	|-RVA: 0x54E4304 Offset: 0x54E0304 VA: 0x54E4304
	|-Serializer<sbyte>.FireOnSerializedType
	|
	|-RVA: 0x54E443C Offset: 0x54E043C VA: 0x54E443C
	|-Serializer<float>.FireOnSerializedType
	|
	|-RVA: 0x54E4578 Offset: 0x54E0578 VA: 0x54E4578
	|-Serializer<ushort>.FireOnSerializedType
	|
	|-RVA: 0x54E46B4 Offset: 0x54E06B4 VA: 0x54E46B4
	|-Serializer<uint>.FireOnSerializedType
	|
	|-RVA: 0x54E47F0 Offset: 0x54E07F0 VA: 0x54E47F0
	|-Serializer<ulong>.FireOnSerializedType
	|
	|-RVA: 0x54E492C Offset: 0x54E092C VA: 0x54E492C
	|-Serializer<UIntPtr>.FireOnSerializedType
	|
	|-RVA: 0x54E4A6C Offset: 0x54E0A6C VA: 0x54E4A6C
	|-Serializer<Vector3>.FireOnSerializedType
	|
	|-RVA: 0x54E4D28 Offset: 0x54E0D28 VA: 0x54E4D28
	|-Serializer<__Il2CppFullySharedGenericType>.FireOnSerializedType
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54E3300 Offset: 0x54DF300 VA: 0x54E3300
	|-Serializer<bool>..ctor
	|
	|-RVA: 0x54E343C Offset: 0x54DF43C VA: 0x54E343C
	|-Serializer<byte>..ctor
	|
	|-RVA: 0x54E3578 Offset: 0x54DF578 VA: 0x54E3578
	|-Serializer<char>..ctor
	|
	|-RVA: 0x54E36B8 Offset: 0x54DF6B8 VA: 0x54E36B8
	|-Serializer<Color>..ctor
	|
	|-RVA: 0x54E3820 Offset: 0x54DF820 VA: 0x54E3820
	|-Serializer<Decimal>..ctor
	|
	|-RVA: 0x54E3958 Offset: 0x54DF958 VA: 0x54E3958
	|-Serializer<double>..ctor
	|
	|-RVA: 0x54E3A98 Offset: 0x54DFA98 VA: 0x54E3A98
	|-Serializer<Guid>..ctor
	|
	|-RVA: 0x54E3BD4 Offset: 0x54DFBD4 VA: 0x54E3BD4
	|-Serializer<short>..ctor
	|
	|-RVA: 0x54E3D10 Offset: 0x54DFD10 VA: 0x54E3D10
	|-Serializer<int>..ctor
	|
	|-RVA: 0x54E3E4C Offset: 0x54DFE4C VA: 0x54E3E4C
	|-Serializer<Int32Enum>..ctor
	|
	|-RVA: 0x54E3F88 Offset: 0x54DFF88 VA: 0x54E3F88
	|-Serializer<long>..ctor
	|
	|-RVA: 0x54E40C4 Offset: 0x54E00C4 VA: 0x54E40C4
	|-Serializer<IntPtr>..ctor
	|
	|-RVA: 0x54E41CC Offset: 0x54E01CC VA: 0x54E41CC
	|-Serializer<object>..ctor
	|
	|-RVA: 0x54E4308 Offset: 0x54E0308 VA: 0x54E4308
	|-Serializer<sbyte>..ctor
	|
	|-RVA: 0x54E4440 Offset: 0x54E0440 VA: 0x54E4440
	|-Serializer<float>..ctor
	|
	|-RVA: 0x54E457C Offset: 0x54E057C VA: 0x54E457C
	|-Serializer<ushort>..ctor
	|
	|-RVA: 0x54E46B8 Offset: 0x54E06B8 VA: 0x54E46B8
	|-Serializer<uint>..ctor
	|
	|-RVA: 0x54E47F4 Offset: 0x54E07F4 VA: 0x54E47F4
	|-Serializer<ulong>..ctor
	|
	|-RVA: 0x54E4930 Offset: 0x54E0930 VA: 0x54E4930
	|-Serializer<UIntPtr>..ctor
	|
	|-RVA: 0x54E4A70 Offset: 0x54E0A70 VA: 0x54E4A70
	|-Serializer<Vector3>..ctor
	|
	|-RVA: 0x54E4D2C Offset: 0x54E0D2C VA: 0x54E4D2C
	|-Serializer<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Sirenix.Serialization
public sealed class SingleSerializer : Serializer<float> // TypeDefIndex: 22455
{
	// Methods

	// RVA: 0x7ED89B0 Offset: 0x7ED49B0 VA: 0x7ED89B0 Slot: 6
	public override float ReadValue(IDataReader reader) { }

	// RVA: 0x7ED8EB8 Offset: 0x7ED4EB8 VA: 0x7ED8EB8 Slot: 7
	public override void WriteValue(string name, float value, IDataWriter writer) { }

	// RVA: 0x7ED8F70 Offset: 0x7ED4F70 VA: 0x7ED8F70
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class StringSerializer : Serializer<string> // TypeDefIndex: 22456
{
	// Methods

	// RVA: 0x7ED8FB8 Offset: 0x7ED4FB8 VA: 0x7ED8FB8 Slot: 6
	public override string ReadValue(IDataReader reader) { }

	// RVA: 0x7ED960C Offset: 0x7ED560C VA: 0x7ED960C Slot: 7
	public override void WriteValue(string name, string value, IDataWriter writer) { }

	// RVA: 0x7ED9728 Offset: 0x7ED5728 VA: 0x7ED9728
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class UInt16Serializer : Serializer<ushort> // TypeDefIndex: 22457
{
	// Methods

	// RVA: 0x7ED9770 Offset: 0x7ED5770 VA: 0x7ED9770 Slot: 6
	public override ushort ReadValue(IDataReader reader) { }

	// RVA: 0x7ED9C04 Offset: 0x7ED5C04 VA: 0x7ED9C04 Slot: 7
	public override void WriteValue(string name, ushort value, IDataWriter writer) { }

	// RVA: 0x7ED9CBC Offset: 0x7ED5CBC VA: 0x7ED9CBC
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class UInt32Serializer : Serializer<uint> // TypeDefIndex: 22458
{
	// Methods

	// RVA: 0x7ED9D04 Offset: 0x7ED5D04 VA: 0x7ED9D04 Slot: 6
	public override uint ReadValue(IDataReader reader) { }

	// RVA: 0x7EDA198 Offset: 0x7ED6198 VA: 0x7EDA198 Slot: 7
	public override void WriteValue(string name, uint value, IDataWriter writer) { }

	// RVA: 0x7EDA250 Offset: 0x7ED6250 VA: 0x7EDA250
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class UInt64Serializer : Serializer<ulong> // TypeDefIndex: 22459
{
	// Methods

	// RVA: 0x7EDA298 Offset: 0x7ED6298 VA: 0x7EDA298 Slot: 6
	public override ulong ReadValue(IDataReader reader) { }

	// RVA: 0x7EDA728 Offset: 0x7ED6728 VA: 0x7EDA728 Slot: 7
	public override void WriteValue(string name, ulong value, IDataWriter writer) { }

	// RVA: 0x7EDA7E0 Offset: 0x7ED67E0 VA: 0x7EDA7E0
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class UIntPtrSerializer : Serializer<UIntPtr> // TypeDefIndex: 22460
{
	// Methods

	// RVA: 0x7EDA828 Offset: 0x7ED6828 VA: 0x7EDA828 Slot: 6
	public override UIntPtr ReadValue(IDataReader reader) { }

	// RVA: 0x7EDACCC Offset: 0x7ED6CCC VA: 0x7EDACCC Slot: 7
	public override void WriteValue(string name, UIntPtr value, IDataWriter writer) { }

	// RVA: 0x7EDAD94 Offset: 0x7ED6D94 VA: 0x7EDAD94
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public abstract class BaseDictionaryKeyPathProvider<T> : IDictionaryKeyPathProvider<T>, IDictionaryKeyPathProvider, IComparer<T> // TypeDefIndex: 22461
{
	// Properties
	public abstract string ProviderID { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_ProviderID();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.get_ProviderID
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract T GetKeyFromPathString(string pathStr);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.GetKeyFromPathString
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract string GetPathStringFromKey(T key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.GetPathStringFromKey
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int Compare(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BaseDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int Sirenix.Serialization.IDictionaryKeyPathProvider.Compare(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B2BD30 Offset: 0x5B27D30 VA: 0x5B2BD30
	|-BaseDictionaryKeyPathProvider<Vector2>.Sirenix.Serialization.IDictionaryKeyPathProvider.Compare
	|
	|-RVA: 0x5B2BECC Offset: 0x5B27ECC VA: 0x5B2BECC
	|-BaseDictionaryKeyPathProvider<Vector3>.Sirenix.Serialization.IDictionaryKeyPathProvider.Compare
	|
	|-RVA: 0x5B2C084 Offset: 0x5B28084 VA: 0x5B2C084
	|-BaseDictionaryKeyPathProvider<Vector4>.Sirenix.Serialization.IDictionaryKeyPathProvider.Compare
	|
	|-RVA: 0x5B2C240 Offset: 0x5B28240 VA: 0x5B2C240
	|-BaseDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.Sirenix.Serialization.IDictionaryKeyPathProvider.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object Sirenix.Serialization.IDictionaryKeyPathProvider.GetKeyFromPathString(string pathStr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B2BE0C Offset: 0x5B27E0C VA: 0x5B2BE0C
	|-BaseDictionaryKeyPathProvider<Vector2>.Sirenix.Serialization.IDictionaryKeyPathProvider.GetKeyFromPathString
	|
	|-RVA: 0x5B2BFBC Offset: 0x5B27FBC VA: 0x5B2BFBC
	|-BaseDictionaryKeyPathProvider<Vector3>.Sirenix.Serialization.IDictionaryKeyPathProvider.GetKeyFromPathString
	|
	|-RVA: 0x5B2C178 Offset: 0x5B28178 VA: 0x5B2C178
	|-BaseDictionaryKeyPathProvider<Vector4>.Sirenix.Serialization.IDictionaryKeyPathProvider.GetKeyFromPathString
	|
	|-RVA: 0x5B2C368 Offset: 0x5B28368 VA: 0x5B2C368
	|-BaseDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.Sirenix.Serialization.IDictionaryKeyPathProvider.GetKeyFromPathString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string Sirenix.Serialization.IDictionaryKeyPathProvider.GetPathStringFromKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B2BE4C Offset: 0x5B27E4C VA: 0x5B2BE4C
	|-BaseDictionaryKeyPathProvider<Vector2>.Sirenix.Serialization.IDictionaryKeyPathProvider.GetPathStringFromKey
	|
	|-RVA: 0x5B2C000 Offset: 0x5B28000 VA: 0x5B2C000
	|-BaseDictionaryKeyPathProvider<Vector3>.Sirenix.Serialization.IDictionaryKeyPathProvider.GetPathStringFromKey
	|
	|-RVA: 0x5B2C1BC Offset: 0x5B281BC VA: 0x5B2C1BC
	|-BaseDictionaryKeyPathProvider<Vector4>.Sirenix.Serialization.IDictionaryKeyPathProvider.GetPathStringFromKey
	|
	|-RVA: 0x5B2C40C Offset: 0x5B2840C VA: 0x5B2C40C
	|-BaseDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.Sirenix.Serialization.IDictionaryKeyPathProvider.GetPathStringFromKey
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B2BEC4 Offset: 0x5B27EC4 VA: 0x5B2BEC4
	|-BaseDictionaryKeyPathProvider<Vector2>..ctor
	|
	|-RVA: 0x5B2C07C Offset: 0x5B2807C VA: 0x5B2C07C
	|-BaseDictionaryKeyPathProvider<Vector3>..ctor
	|
	|-RVA: 0x5B2C238 Offset: 0x5B28238 VA: 0x5B2C238
	|-BaseDictionaryKeyPathProvider<Vector4>..ctor
	|
	|-RVA: 0x5B2C4E8 Offset: 0x5B284E8 VA: 0x5B2C4E8
	|-BaseDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class DictionaryKeyUtility.UnityObjectKeyComparer<T> : IComparer<T> // TypeDefIndex: 22462
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int Compare(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BDD70 Offset: 0x56B9D70 VA: 0x56BDD70
	|-DictionaryKeyUtility.UnityObjectKeyComparer<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56BDFF8 Offset: 0x56B9FF8 VA: 0x56BDFF8
	|-DictionaryKeyUtility.UnityObjectKeyComparer<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class DictionaryKeyUtility.FallbackKeyComparer<T> : IComparer<T> // TypeDefIndex: 22463
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int Compare(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633A420 Offset: 0x6336420 VA: 0x633A420
	|-DictionaryKeyUtility.FallbackKeyComparer<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x633A594 Offset: 0x6336594 VA: 0x633A594
	|-DictionaryKeyUtility.FallbackKeyComparer<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
public class DictionaryKeyUtility.KeyComparer<T> : IComparer<T> // TypeDefIndex: 22464
{
	// Fields
	public static readonly DictionaryKeyUtility.KeyComparer<T> Default; // 0x0
	private readonly IComparer<T> actualComparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AEEC58 Offset: 0x4AEAC58 VA: 0x4AEEC58
	|-DictionaryKeyUtility.KeyComparer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int Compare(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AEEFB0 Offset: 0x4AEAFB0 VA: 0x4AEEFB0
	|-DictionaryKeyUtility.KeyComparer<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4AEF130 Offset: 0x4AEB130 VA: 0x4AEF130
	|-DictionaryKeyUtility.KeyComparer<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DictionaryKeyUtility.<>c // TypeDefIndex: 22465
{
	// Fields
	public static readonly DictionaryKeyUtility.<>c <>9; // 0x0

	// Methods

	// RVA: 0x7EDF5D8 Offset: 0x7EDB5D8 VA: 0x7EDF5D8
	private static void .cctor() { }

	// RVA: 0x7EDF640 Offset: 0x7EDB640 VA: 0x7EDF640
	public void .ctor() { }

	// RVA: 0x7EDF648 Offset: 0x7EDB648 VA: 0x7EDF648
	internal IEnumerable<<>f__AnonymousType0<Assembly, RegisterDictionaryKeyPathProviderAttribute>> <.cctor>b__12_0(Assembly ass) { }

	// RVA: 0x7EDF874 Offset: 0x7EDB874 VA: 0x7EDF874
	internal bool <.cctor>b__12_1(<>f__AnonymousType0<Assembly, RegisterDictionaryKeyPathProviderAttribute> n) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DictionaryKeyUtility.<>c__DisplayClass12_0 // TypeDefIndex: 22466
{
	// Fields
	public Assembly ass; // 0x10

	// Methods

	// RVA: 0x7EDF7BC Offset: 0x7EDB7BC VA: 0x7EDF7BC
	public void .ctor() { }

	// RVA: 0x7EDF8F0 Offset: 0x7EDB8F0 VA: 0x7EDF8F0
	internal <>f__AnonymousType0<Assembly, RegisterDictionaryKeyPathProviderAttribute> <.cctor>b__2(object attr) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DictionaryKeyUtility.<GetPersistentPathKeyTypes>d__14 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IDisposable, IEnumerator // TypeDefIndex: 22467
{
	// Fields
	private int <>1__state; // 0x10
	private Type <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private HashSet.Enumerator<Type> <>7__wrap1; // 0x28
	private Dictionary.KeyCollection.Enumerator<Type, IDictionaryKeyPathProvider> <>7__wrap2; // 0x40

	// Properties
	private Type System.Collections.Generic.IEnumerator<System.Type>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7EDD2E4 Offset: 0x7ED92E4 VA: 0x7EDD2E4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7EDF9A8 Offset: 0x7EDB9A8 VA: 0x7EDF9A8 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7EDF9DC Offset: 0x7EDB9DC VA: 0x7EDF9DC Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7EDFCBC Offset: 0x7EDBCBC VA: 0x7EDFCBC
	private void <>m__Finally1() { }

	// RVA: 0x7EDFD0C Offset: 0x7EDBD0C VA: 0x7EDFD0C
	private void <>m__Finally2() { }

	[DebuggerHidden]
	// RVA: 0x7EDFD5C Offset: 0x7EDBD5C VA: 0x7EDFD5C Slot: 6
	private Type System.Collections.Generic.IEnumerator<System.Type>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EDFD64 Offset: 0x7EDBD64 VA: 0x7EDFD64 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7EDFD9C Offset: 0x7EDBD9C VA: 0x7EDFD9C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EDFDA4 Offset: 0x7EDBDA4 VA: 0x7EDFDA4 Slot: 4
	private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7EDFE34 Offset: 0x7EDBE34 VA: 0x7EDFE34 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Sirenix.Serialization
[Extension]
public static class DictionaryKeyUtility // TypeDefIndex: 22468
{
	// Fields
	private static readonly Dictionary<Type, bool> GetSupportedDictionaryKeyTypesResults; // 0x0
	private static readonly HashSet<Type> BaseSupportedDictionaryKeyTypes; // 0x8
	private static readonly HashSet<char> AllowedSpecialKeyStrChars; // 0x10
	private static readonly Dictionary<Type, IDictionaryKeyPathProvider> TypeToKeyPathProviders; // 0x18
	private static readonly Dictionary<string, IDictionaryKeyPathProvider> IDToKeyPathProviders; // 0x20
	private static readonly Dictionary<IDictionaryKeyPathProvider, string> ProviderToID; // 0x28
	private static readonly Dictionary<object, string> ObjectsToTempKeys; // 0x30
	private static readonly Dictionary<string, object> TempKeysToObjects; // 0x38
	private static long tempKeyCounter; // 0x40

	// Methods

	// RVA: 0x7EDADDC Offset: 0x7ED6DDC VA: 0x7EDADDC
	private static void .cctor() { }

	// RVA: 0x7EDCA3C Offset: 0x7ED8A3C VA: 0x7EDCA3C
	private static void LogInvalidKeyPathProvider(Type type, Assembly assembly, string reason) { }

	[IteratorStateMachine(typeof(DictionaryKeyUtility.<GetPersistentPathKeyTypes>d__14))]
	// RVA: 0x7EDD27C Offset: 0x7ED927C VA: 0x7EDD27C
	public static IEnumerable<Type> GetPersistentPathKeyTypes() { }

	// RVA: 0x7EDD318 Offset: 0x7ED9318 VA: 0x7EDD318
	public static bool KeyTypeSupportsPersistentPaths(Type type) { }

	// RVA: 0x7EDD404 Offset: 0x7ED9404 VA: 0x7EDD404
	private static bool PrivateIsSupportedDictionaryKeyType(Type type) { }

	// RVA: 0x7EDD4F4 Offset: 0x7ED94F4 VA: 0x7EDD4F4
	public static string GetDictionaryKeyString(object key) { }

	// RVA: 0x7EDEA98 Offset: 0x7EDAA98 VA: 0x7EDEA98
	public static object GetDictionaryKeyValue(string keyStr, Type expectedType) { }

	[Extension]
	// RVA: 0x7EDF5C0 Offset: 0x7EDB5C0 VA: 0x7EDF5C0
	private static string FromTo(string str, int from, int to) { }
}

// Namespace: Sirenix.Serialization
public interface IDictionaryKeyPathProvider // TypeDefIndex: 22469
{
	// Properties
	public abstract string ProviderID { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ProviderID();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetPathStringFromKey(object key);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object GetKeyFromPathString(string pathStr);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int Compare(object x, object y);
}

// Namespace: Sirenix.Serialization
public interface IDictionaryKeyPathProvider<T> : IDictionaryKeyPathProvider // TypeDefIndex: 22470
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetPathStringFromKey(T key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.GetPathStringFromKey
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T GetKeyFromPathString(string pathStr);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.GetKeyFromPathString
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Compare(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionaryKeyPathProvider<__Il2CppFullySharedGenericType>.Compare
	*/
}

// Namespace: Sirenix.Serialization
[Usage(1, AllowMultiple = True)]
public sealed class RegisterDictionaryKeyPathProviderAttribute : Attribute // TypeDefIndex: 22471
{
	// Fields
	public readonly Type ProviderType; // 0x10

	// Methods

	// RVA: 0x7EDFE38 Offset: 0x7EDBE38 VA: 0x7EDFE38
	public void .ctor(Type providerType) { }
}

// Namespace: Sirenix.Serialization
public sealed class Vector2DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider<Vector2> // TypeDefIndex: 22472
{
	// Properties
	public override string ProviderID { get; }

	// Methods

	// RVA: 0x7EDFE68 Offset: 0x7EDBE68 VA: 0x7EDFE68 Slot: 12
	public override string get_ProviderID() { }

	// RVA: 0x7EDFEA8 Offset: 0x7EDBEA8 VA: 0x7EDFEA8 Slot: 15
	public override int Compare(Vector2 x, Vector2 y) { }

	// RVA: 0x7EDFEEC Offset: 0x7EDBEEC VA: 0x7EDFEEC Slot: 13
	public override Vector2 GetKeyFromPathString(string pathStr) { }

	// RVA: 0x7EDFF9C Offset: 0x7EDBF9C VA: 0x7EDFF9C Slot: 14
	public override string GetPathStringFromKey(Vector2 key) { }

	// RVA: 0x7EE0178 Offset: 0x7EDC178 VA: 0x7EE0178
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class Vector3DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider<Vector3> // TypeDefIndex: 22473
{
	// Properties
	public override string ProviderID { get; }

	// Methods

	// RVA: 0x7EE01C0 Offset: 0x7EDC1C0 VA: 0x7EE01C0 Slot: 12
	public override string get_ProviderID() { }

	// RVA: 0x7EE0200 Offset: 0x7EDC200 VA: 0x7EE0200 Slot: 15
	public override int Compare(Vector3 x, Vector3 y) { }

	// RVA: 0x7EE0268 Offset: 0x7EDC268 VA: 0x7EE0268 Slot: 13
	public override Vector3 GetKeyFromPathString(string pathStr) { }

	// RVA: 0x7EE0374 Offset: 0x7EDC374 VA: 0x7EE0374 Slot: 14
	public override string GetPathStringFromKey(Vector3 key) { }

	// RVA: 0x7EE05C8 Offset: 0x7EDC5C8 VA: 0x7EE05C8
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class Vector4DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider<Vector4> // TypeDefIndex: 22474
{
	// Properties
	public override string ProviderID { get; }

	// Methods

	// RVA: 0x7EE0610 Offset: 0x7EDC610 VA: 0x7EE0610 Slot: 12
	public override string get_ProviderID() { }

	// RVA: 0x7EE0650 Offset: 0x7EDC650 VA: 0x7EE0650 Slot: 15
	public override int Compare(Vector4 x, Vector4 y) { }

	// RVA: 0x7EE06D8 Offset: 0x7EDC6D8 VA: 0x7EE06D8 Slot: 13
	public override Vector4 GetKeyFromPathString(string pathStr) { }

	// RVA: 0x7EE0848 Offset: 0x7EDC848 VA: 0x7EE0848 Slot: 14
	public override string GetPathStringFromKey(Vector4 key) { }

	// RVA: 0x7EE0B00 Offset: 0x7EDCB00 VA: 0x7EE0B00
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public class AnimationCurveFormatter : MinimalBaseFormatter<AnimationCurve> // TypeDefIndex: 22475
{
	// Fields
	private static readonly Serializer<Keyframe[]> KeyframeSerializer; // 0x0
	private static readonly Serializer<WrapMode> WrapModeSerializer; // 0x8

	// Methods

	// RVA: 0x7EE0B48 Offset: 0x7EDCB48 VA: 0x7EE0B48 Slot: 9
	protected override AnimationCurve GetUninitializedObject() { }

	// RVA: 0x7EE0B50 Offset: 0x7EDCB50 VA: 0x7EE0B50 Slot: 10
	protected override void Read(ref AnimationCurve value, IDataReader reader) { }

	// RVA: 0x7EE0C80 Offset: 0x7EDCC80 VA: 0x7EE0C80 Slot: 11
	protected override void Write(ref AnimationCurve value, IDataWriter writer) { }

	// RVA: 0x7EE0DA4 Offset: 0x7EDCDA4 VA: 0x7EE0DA4
	public void .ctor() { }

	// RVA: 0x7EE0E10 Offset: 0x7EDCE10 VA: 0x7EE0E10
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class BoundsFormatter : MinimalBaseFormatter<Bounds> // TypeDefIndex: 22476
{
	// Fields
	private static readonly Serializer<Vector3> Vector3Serializer; // 0x0

	// Methods

	// RVA: 0x7EE0ED8 Offset: 0x7EDCED8 VA: 0x7EE0ED8 Slot: 10
	protected override void Read(ref Bounds value, IDataReader reader) { }

	// RVA: 0x7EE0F98 Offset: 0x7EDCF98 VA: 0x7EE0F98 Slot: 11
	protected override void Write(ref Bounds value, IDataWriter writer) { }

	// RVA: 0x7EE105C Offset: 0x7EDD05C VA: 0x7EE105C
	public void .ctor() { }

	// RVA: 0x7EE10C8 Offset: 0x7EDD0C8 VA: 0x7EE10C8
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class Color32Formatter : MinimalBaseFormatter<Color32> // TypeDefIndex: 22477
{
	// Fields
	private static readonly Serializer<byte> ByteSerializer; // 0x0

	// Methods

	// RVA: 0x7EE115C Offset: 0x7EDD15C VA: 0x7EE115C Slot: 10
	protected override void Read(ref Color32 value, IDataReader reader) { }

	// RVA: 0x7EE124C Offset: 0x7EDD24C VA: 0x7EE124C Slot: 11
	protected override void Write(ref Color32 value, IDataWriter writer) { }

	// RVA: 0x7EE133C Offset: 0x7EDD33C VA: 0x7EE133C
	public void .ctor() { }

	// RVA: 0x7EE13A8 Offset: 0x7EDD3A8 VA: 0x7EE13A8
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class ColorBlockFormatterLocator : IFormatterLocator // TypeDefIndex: 22478
{
	// Methods

	// RVA: 0x7EE143C Offset: 0x7EDD43C VA: 0x7EE143C Slot: 4
	public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter) { }

	// RVA: 0x7EE18C8 Offset: 0x7EDD8C8 VA: 0x7EE18C8
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public class ColorBlockFormatter<T> : MinimalBaseFormatter<T> // TypeDefIndex: 22479
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0
	private static readonly Serializer<Color> ColorSerializer; // 0x0
	private static readonly PropertyInfo normalColor; // 0x0
	private static readonly PropertyInfo highlightedColor; // 0x0
	private static readonly PropertyInfo pressedColor; // 0x0
	private static readonly PropertyInfo disabledColor; // 0x0
	private static readonly PropertyInfo colorMultiplier; // 0x0
	private static readonly PropertyInfo fadeDuration; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	protected override void Read(ref T value, IDataReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC2D30 Offset: 0x5BBED30 VA: 0x5BC2D30
	|-ColorBlockFormatter<__Il2CppFullySharedGenericType>.Read
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void Write(ref T value, IDataWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC32AC Offset: 0x5BBF2AC VA: 0x5BC32AC
	|-ColorBlockFormatter<__Il2CppFullySharedGenericType>.Write
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC3950 Offset: 0x5BBF950 VA: 0x5BC3950
	|-ColorBlockFormatter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC39B0 Offset: 0x5BBF9B0 VA: 0x5BC39B0
	|-ColorBlockFormatter<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Sirenix.Serialization
public class WeakColorBlockFormatter : WeakBaseFormatter // TypeDefIndex: 22480
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0
	private static readonly Serializer<Color> ColorSerializer; // 0x8
	private readonly PropertyInfo normalColor; // 0x40
	private readonly PropertyInfo highlightedColor; // 0x48
	private readonly PropertyInfo pressedColor; // 0x50
	private readonly PropertyInfo disabledColor; // 0x58
	private readonly PropertyInfo colorMultiplier; // 0x60
	private readonly PropertyInfo fadeDuration; // 0x68

	// Methods

	// RVA: 0x7EE173C Offset: 0x7EDD73C VA: 0x7EE173C
	public void .ctor(Type colorBlockType) { }

	// RVA: 0x7EE18D0 Offset: 0x7EDD8D0 VA: 0x7EE18D0 Slot: 8
	protected override void DeserializeImplementation(ref object value, IDataReader reader) { }

	// RVA: 0x7EE1BA4 Offset: 0x7EDDBA4 VA: 0x7EE1BA4 Slot: 9
	protected override void SerializeImplementation(ref object value, IDataWriter writer) { }

	// RVA: 0x7EE1ECC Offset: 0x7EDDECC VA: 0x7EE1ECC
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class ColorFormatter : MinimalBaseFormatter<Color> // TypeDefIndex: 22481
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0

	// Methods

	// RVA: 0x7EE1F94 Offset: 0x7EDDF94 VA: 0x7EE1F94 Slot: 10
	protected override void Read(ref Color value, IDataReader reader) { }

	// RVA: 0x7EE2084 Offset: 0x7EDE084 VA: 0x7EE2084 Slot: 11
	protected override void Write(ref Color value, IDataWriter writer) { }

	// RVA: 0x7EE2174 Offset: 0x7EDE174 VA: 0x7EE2174
	public void .ctor() { }

	// RVA: 0x7EE21E0 Offset: 0x7EDE1E0 VA: 0x7EE21E0
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public sealed class CoroutineFormatter : IFormatter<Coroutine>, IFormatter // TypeDefIndex: 22482
{
	// Properties
	public Type SerializedType { get; }

	// Methods

	// RVA: 0x7EE2274 Offset: 0x7EDE274 VA: 0x7EE2274 Slot: 6
	public Type get_SerializedType() { }

	// RVA: 0x7EE22E0 Offset: 0x7EDE2E0 VA: 0x7EE22E0 Slot: 8
	private object Sirenix.Serialization.IFormatter.Deserialize(IDataReader reader) { }

	// RVA: 0x7EE22E8 Offset: 0x7EDE2E8 VA: 0x7EE22E8 Slot: 5
	public Coroutine Deserialize(IDataReader reader) { }

	// RVA: 0x7EE22F0 Offset: 0x7EDE2F0 VA: 0x7EE22F0 Slot: 7
	public void Serialize(object value, IDataWriter writer) { }

	// RVA: 0x7EE22F4 Offset: 0x7EDE2F4 VA: 0x7EE22F4 Slot: 4
	public void Serialize(Coroutine value, IDataWriter writer) { }

	// RVA: 0x7EE22F8 Offset: 0x7EDE2F8 VA: 0x7EE22F8
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public class GradientAlphaKeyFormatter : MinimalBaseFormatter<GradientAlphaKey> // TypeDefIndex: 22483
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0

	// Methods

	// RVA: 0x7EE2300 Offset: 0x7EDE300 VA: 0x7EE2300 Slot: 10
	protected override void Read(ref GradientAlphaKey value, IDataReader reader) { }

	// RVA: 0x7EE23A8 Offset: 0x7EDE3A8 VA: 0x7EE23A8 Slot: 11
	protected override void Write(ref GradientAlphaKey value, IDataWriter writer) { }

	// RVA: 0x7EE2458 Offset: 0x7EDE458 VA: 0x7EE2458
	public void .ctor() { }

	// RVA: 0x7EE24C4 Offset: 0x7EDE4C4 VA: 0x7EE24C4
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class GradientColorKeyFormatter : MinimalBaseFormatter<GradientColorKey> // TypeDefIndex: 22484
{
	// Fields
	private static readonly Serializer<Color> ColorSerializer; // 0x0
	private static readonly Serializer<float> FloatSerializer; // 0x8

	// Methods

	// RVA: 0x7EE2558 Offset: 0x7EDE558 VA: 0x7EE2558 Slot: 10
	protected override void Read(ref GradientColorKey value, IDataReader reader) { }

	// RVA: 0x7EE2604 Offset: 0x7EDE604 VA: 0x7EE2604 Slot: 11
	protected override void Write(ref GradientColorKey value, IDataWriter writer) { }

	// RVA: 0x7EE26CC Offset: 0x7EDE6CC VA: 0x7EE26CC
	public void .ctor() { }

	// RVA: 0x7EE2738 Offset: 0x7EDE738 VA: 0x7EE2738
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class GradientFormatter : MinimalBaseFormatter<Gradient> // TypeDefIndex: 22485
{
	// Fields
	private static readonly Serializer<GradientAlphaKey[]> AlphaKeysSerializer; // 0x0
	private static readonly Serializer<GradientColorKey[]> ColorKeysSerializer; // 0x8
	private static readonly PropertyInfo ModeProperty; // 0x10
	private static readonly Serializer<object> EnumSerializer; // 0x18

	// Methods

	// RVA: 0x7EE2800 Offset: 0x7EDE800 VA: 0x7EE2800 Slot: 9
	protected override Gradient GetUninitializedObject() { }

	// RVA: 0x7EE2854 Offset: 0x7EDE854 VA: 0x7EE2854 Slot: 10
	protected override void Read(ref Gradient value, IDataReader reader) { }

	// RVA: 0x7EE2BE4 Offset: 0x7EDEBE4 VA: 0x7EE2BE4 Slot: 11
	protected override void Write(ref Gradient value, IDataWriter writer) { }

	// RVA: 0x7EE2E98 Offset: 0x7EDEE98 VA: 0x7EE2E98
	public void .ctor() { }

	// RVA: 0x7EE2F04 Offset: 0x7EDEF04 VA: 0x7EE2F04
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class KeyframeFormatter : MinimalBaseFormatter<Keyframe> // TypeDefIndex: 22486
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0
	private static readonly Serializer<int> IntSerializer; // 0x8
	private static readonly bool Is_In_2018_1_Or_Above; // 0x10
	private static IFormatter<Keyframe> Formatter; // 0x18

	// Methods

	// RVA: 0x7EE30C8 Offset: 0x7EDF0C8 VA: 0x7EE30C8
	private static void .cctor() { }

	// RVA: 0x7EE33C0 Offset: 0x7EDF3C0 VA: 0x7EE33C0 Slot: 10
	protected override void Read(ref Keyframe value, IDataReader reader) { }

	// RVA: 0x7EE3798 Offset: 0x7EDF798 VA: 0x7EE3798 Slot: 11
	protected override void Write(ref Keyframe value, IDataWriter writer) { }

	// RVA: 0x7EE3A90 Offset: 0x7EDFA90 VA: 0x7EE3A90
	public void .ctor() { }
}

// Namespace: Sirenix.Serialization
public class LayerMaskFormatter : MinimalBaseFormatter<LayerMask> // TypeDefIndex: 22487
{
	// Fields
	private static readonly Serializer<int> IntSerializer; // 0x0

	// Methods

	// RVA: 0x7EE3AFC Offset: 0x7EDFAFC VA: 0x7EE3AFC Slot: 10
	protected override void Read(ref LayerMask value, IDataReader reader) { }

	// RVA: 0x7EE3B88 Offset: 0x7EDFB88 VA: 0x7EE3B88 Slot: 11
	protected override void Write(ref LayerMask value, IDataWriter writer) { }

	// RVA: 0x7EE3C28 Offset: 0x7EDFC28 VA: 0x7EE3C28
	public void .ctor() { }

	// RVA: 0x7EE3C94 Offset: 0x7EDFC94 VA: 0x7EE3C94
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class QuaternionFormatter : MinimalBaseFormatter<Quaternion> // TypeDefIndex: 22488
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0

	// Methods

	// RVA: 0x7EE3D28 Offset: 0x7EDFD28 VA: 0x7EE3D28 Slot: 10
	protected override void Read(ref Quaternion value, IDataReader reader) { }

	// RVA: 0x7EE3E18 Offset: 0x7EDFE18 VA: 0x7EE3E18 Slot: 11
	protected override void Write(ref Quaternion value, IDataWriter writer) { }

	// RVA: 0x7EE3F08 Offset: 0x7EDFF08 VA: 0x7EE3F08
	public void .ctor() { }

	// RVA: 0x7EE3F74 Offset: 0x7EDFF74 VA: 0x7EE3F74
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class RectFormatter : MinimalBaseFormatter<Rect> // TypeDefIndex: 22489
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0

	// Methods

	// RVA: 0x7EE4008 Offset: 0x7EE0008 VA: 0x7EE4008 Slot: 10
	protected override void Read(ref Rect value, IDataReader reader) { }

	// RVA: 0x7EE40F8 Offset: 0x7EE00F8 VA: 0x7EE40F8 Slot: 11
	protected override void Write(ref Rect value, IDataWriter writer) { }

	// RVA: 0x7EE41E8 Offset: 0x7EE01E8 VA: 0x7EE41E8
	public void .ctor() { }

	// RVA: 0x7EE4254 Offset: 0x7EE0254 VA: 0x7EE4254
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class UnityEventFormatter<T> : ReflectionFormatter<T> // TypeDefIndex: 22490
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected override T GetUninitializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B94D8 Offset: 0x56B54D8 VA: 0x56B94D8
	|-UnityEventFormatter<object>.GetUninitializedObject
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56B94E8 Offset: 0x56B54E8 VA: 0x56B94E8
	|-UnityEventFormatter<object>..ctor
	*/
}

// Namespace: Sirenix.Serialization
public class WeakUnityEventFormatter : WeakReflectionFormatter // TypeDefIndex: 22491
{
	// Methods

	// RVA: 0x7EE42E8 Offset: 0x7EE02E8 VA: 0x7EE42E8
	public void .ctor(Type serializedType) { }

	// RVA: 0x7EE42F0 Offset: 0x7EE02F0 VA: 0x7EE42F0 Slot: 7
	protected override object GetUninitializedObject() { }
}

// Namespace: Sirenix.Serialization
public class Vector2Formatter : MinimalBaseFormatter<Vector2> // TypeDefIndex: 22492
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0

	// Methods

	// RVA: 0x7EE42FC Offset: 0x7EE02FC VA: 0x7EE42FC Slot: 10
	protected override void Read(ref Vector2 value, IDataReader reader) { }

	// RVA: 0x7EE43A4 Offset: 0x7EE03A4 VA: 0x7EE43A4 Slot: 11
	protected override void Write(ref Vector2 value, IDataWriter writer) { }

	// RVA: 0x7EE4454 Offset: 0x7EE0454 VA: 0x7EE4454
	public void .ctor() { }

	// RVA: 0x7EE44C0 Offset: 0x7EE04C0 VA: 0x7EE44C0
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class Vector3Formatter : MinimalBaseFormatter<Vector3> // TypeDefIndex: 22493
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0

	// Methods

	// RVA: 0x7EE4554 Offset: 0x7EE0554 VA: 0x7EE4554 Slot: 10
	protected override void Read(ref Vector3 value, IDataReader reader) { }

	// RVA: 0x7EE4620 Offset: 0x7EE0620 VA: 0x7EE4620 Slot: 11
	protected override void Write(ref Vector3 value, IDataWriter writer) { }

	// RVA: 0x7EE46F0 Offset: 0x7EE06F0 VA: 0x7EE46F0
	public void .ctor() { }

	// RVA: 0x7EE475C Offset: 0x7EE075C VA: 0x7EE475C
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class Vector4Formatter : MinimalBaseFormatter<Vector4> // TypeDefIndex: 22494
{
	// Fields
	private static readonly Serializer<float> FloatSerializer; // 0x0

	// Methods

	// RVA: 0x7EE47F0 Offset: 0x7EE07F0 VA: 0x7EE47F0 Slot: 10
	protected override void Read(ref Vector4 value, IDataReader reader) { }

	// RVA: 0x7EE48E0 Offset: 0x7EE08E0 VA: 0x7EE48E0 Slot: 11
	protected override void Write(ref Vector4 value, IDataWriter writer) { }

	// RVA: 0x7EE49D0 Offset: 0x7EE09D0 VA: 0x7EE49D0
	public void .ctor() { }

	// RVA: 0x7EE4A3C Offset: 0x7EE0A3C VA: 0x7EE4A3C
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class Vector2IntFormatter : MinimalBaseFormatter<Vector2Int> // TypeDefIndex: 22495
{
	// Fields
	private static readonly Serializer<int> Serializer; // 0x0

	// Methods

	// RVA: 0x7EE4AD0 Offset: 0x7EE0AD0 VA: 0x7EE4AD0 Slot: 10
	protected override void Read(ref Vector2Int value, IDataReader reader) { }

	// RVA: 0x7EE4B78 Offset: 0x7EE0B78 VA: 0x7EE4B78 Slot: 11
	protected override void Write(ref Vector2Int value, IDataWriter writer) { }

	// RVA: 0x7EE4C28 Offset: 0x7EE0C28 VA: 0x7EE4C28
	public void .ctor() { }

	// RVA: 0x7EE4C94 Offset: 0x7EE0C94 VA: 0x7EE4C94
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public class Vector3IntFormatter : MinimalBaseFormatter<Vector3Int> // TypeDefIndex: 22496
{
	// Fields
	private static readonly Serializer<int> Serializer; // 0x0

	// Methods

	// RVA: 0x7EE4D28 Offset: 0x7EE0D28 VA: 0x7EE4D28 Slot: 10
	protected override void Read(ref Vector3Int value, IDataReader reader) { }

	// RVA: 0x7EE4DF4 Offset: 0x7EE0DF4 VA: 0x7EE4DF4 Slot: 11
	protected override void Write(ref Vector3Int value, IDataWriter writer) { }

	// RVA: 0x7EE4EC4 Offset: 0x7EE0EC4 VA: 0x7EE4EC4
	public void .ctor() { }

	// RVA: 0x7EE4F30 Offset: 0x7EE0F30 VA: 0x7EE4F30
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization
public interface IOverridesSerializationFormat // TypeDefIndex: 22497
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DataFormat GetFormatToSerializeAs(bool isPlayer);
}

// Namespace: Sirenix.Serialization
public interface IOverridesSerializationPolicy // TypeDefIndex: 22498
{
	// Properties
	public abstract ISerializationPolicy SerializationPolicy { get; }
	public abstract bool OdinSerializesUnityFields { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISerializationPolicy get_SerializationPolicy();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_OdinSerializesUnityFields();
}

// Namespace: Sirenix.Serialization
public interface ISupportsPrefabSerialization // TypeDefIndex: 22499
{
	// Properties
	public abstract SerializationData SerializationData { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SerializationData get_SerializationData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_SerializationData(SerializationData value);
}

// Namespace: Sirenix.Serialization
[Serializable]
public struct SerializationData // TypeDefIndex: 22500
{
	// Fields
	public const string PrefabModificationsReferencedUnityObjectsFieldName = "PrefabModificationsReferencedUnityObjects";
	public const string PrefabModificationsFieldName = "PrefabModifications";
	public const string PrefabFieldName = "Prefab";
	[SerializeField]
	public DataFormat SerializedFormat; // 0x0
	[SerializeField]
	public byte[] SerializedBytes; // 0x8
	[SerializeField]
	public List<Object> ReferencedUnityObjects; // 0x10
	[SerializeField]
	public string SerializedBytesString; // 0x18
	[SerializeField]
	public Object Prefab; // 0x20
	[SerializeField]
	public List<Object> PrefabModificationsReferencedUnityObjects; // 0x28
	[SerializeField]
	public List<string> PrefabModifications; // 0x30
	[SerializeField]
	public List<SerializationNode> SerializationNodes; // 0x38

	// Properties
	[Obsolete("Use ContainsData instead")]
	[EditorBrowsable(1)]
	public bool HasEditorData { get; }
	public bool ContainsData { get; }

	// Methods

	// RVA: 0x7EE4FC4 Offset: 0x7EE0FC4 VA: 0x7EE4FC4
	public bool get_HasEditorData() { }

	// RVA: 0x7EE5184 Offset: 0x7EE1184 VA: 0x7EE5184
	public bool get_ContainsData() { }

	// RVA: 0x7EE51B4 Offset: 0x7EE11B4 VA: 0x7EE51B4
	public void Reset() { }
}

// Namespace: Sirenix.Serialization
public sealed class UnityReferenceResolver : IExternalIndexReferenceResolver, ICacheNotificationReceiver // TypeDefIndex: 22501
{
	// Fields
	private Dictionary<Object, int> referenceIndexMapping; // 0x10
	private List<Object> referencedUnityObjects; // 0x18

	// Methods

	// RVA: 0x7EE538C Offset: 0x7EE138C VA: 0x7EE538C
	public void .ctor() { }

	// RVA: 0x7EE54A0 Offset: 0x7EE14A0 VA: 0x7EE54A0
	public void .ctor(List<Object> referencedUnityObjects) { }

	// RVA: 0x7EE5708 Offset: 0x7EE1708 VA: 0x7EE5708
	public List<Object> GetReferencedUnityObjects() { }

	// RVA: 0x7EE5570 Offset: 0x7EE1570 VA: 0x7EE5570
	public void SetReferencedUnityObjects(List<Object> referencedUnityObjects) { }

	// RVA: 0x7EE5710 Offset: 0x7EE1710 VA: 0x7EE5710 Slot: 5
	public bool CanReference(object value, out int index) { }

	// RVA: 0x7EE58F8 Offset: 0x7EE18F8 VA: 0x7EE58F8 Slot: 4
	public bool TryResolveReference(int index, out object value) { }

	// RVA: 0x7EE599C Offset: 0x7EE199C VA: 0x7EE599C
	public void Reset() { }

	// RVA: 0x7EE59FC Offset: 0x7EE19FC VA: 0x7EE59FC Slot: 6
	private void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnFreed() { }

	// RVA: 0x7EE5A00 Offset: 0x7EE1A00 VA: 0x7EE5A00 Slot: 7
	private void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnClaimed() { }
}

// Namespace: Sirenix.Serialization
public static class UnitySerializationInitializer // TypeDefIndex: 22502
{
	// Fields
	private static readonly object LOCK; // 0x0
	private static bool initialized; // 0x8
	[CompilerGenerated]
	private static RuntimePlatform <CurrentPlatform>k__BackingField; // 0xC

	// Properties
	public static bool Initialized { get; }
	public static RuntimePlatform CurrentPlatform { get; set; }

	// Methods

	// RVA: 0x7EE5A04 Offset: 0x7EE1A04 VA: 0x7EE5A04
	public static bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x7EE5A5C Offset: 0x7EE1A5C VA: 0x7EE5A5C
	public static RuntimePlatform get_CurrentPlatform() { }

	[CompilerGenerated]
	// RVA: 0x7EE5AB4 Offset: 0x7EE1AB4 VA: 0x7EE5AB4
	private static void set_CurrentPlatform(RuntimePlatform value) { }

	// RVA: 0x7EE5B10 Offset: 0x7EE1B10 VA: 0x7EE5B10
	public static void Initialize() { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x7EE5E20 Offset: 0x7EE1E20 VA: 0x7EE5E20
	private static void InitializeRuntime() { }

	// RVA: 0x7EE5E6C Offset: 0x7EE1E6C VA: 0x7EE5E6C
	private static void .cctor() { }
}

// Namespace: 
private struct UnitySerializationUtility.CachedSerializationBackendResult // TypeDefIndex: 22503
{
	// Fields
	public bool HasCalculatedSerializeUnityFieldsTrueResult; // 0x0
	public bool HasCalculatedSerializeUnityFieldsFalseResult; // 0x1
	public bool SerializeUnityFieldsTrueResult; // 0x2
	public bool SerializeUnityFieldsFalseResult; // 0x3
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnitySerializationUtility.<>c // TypeDefIndex: 22504
{
	// Fields
	public static readonly UnitySerializationUtility.<>c <>9; // 0x0
	public static Comparison<PrefabModification> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x7EF090C Offset: 0x7EEC90C VA: 0x7EF090C
	private static void .cctor() { }

	// RVA: 0x7EF0974 Offset: 0x7EEC974 VA: 0x7EF0974
	public void .ctor() { }

	// RVA: 0x7EF097C Offset: 0x7EEC97C VA: 0x7EF097C
	internal int <SerializePrefabModifications>b__33_0(PrefabModification a, PrefabModification b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnitySerializationUtility.<>c__DisplayClass39_0 // TypeDefIndex: 22505
{
	// Fields
	public MemberInfo member; // 0x10

	// Methods

	// RVA: 0x7EF02B8 Offset: 0x7EEC2B8 VA: 0x7EF02B8
	public void .ctor() { }

	// RVA: 0x7EF09F8 Offset: 0x7EEC9F8 VA: 0x7EF09F8
	internal object <GetCachedUnityMemberGetter>b__0(ref object instance) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnitySerializationUtility.<>c__DisplayClass40_0 // TypeDefIndex: 22506
{
	// Fields
	public MemberInfo member; // 0x10

	// Methods

	// RVA: 0x7EF02C0 Offset: 0x7EEC2C0 VA: 0x7EF02C0
	public void .ctor() { }

	// RVA: 0x7EF0A68 Offset: 0x7EECA68 VA: 0x7EF0A68
	internal void <GetCachedUnityMemberSetter>b__0(ref object instance, object value) { }
}

// Namespace: Sirenix.Serialization
public static class UnitySerializationUtility // TypeDefIndex: 22507
{
	// Fields
	public static readonly Type SerializeReferenceAttributeType; // 0x0
	private static readonly Assembly String_Assembly; // 0x8
	private static readonly Assembly HashSet_Assembly; // 0x10
	private static readonly Assembly LinkedList_Assembly; // 0x18
	private static readonly Dictionary<MemberInfo, WeakValueGetter> UnityMemberGetters; // 0x20
	private static readonly Dictionary<MemberInfo, WeakValueSetter> UnityMemberSetters; // 0x28
	private static readonly Dictionary<MemberInfo, bool> UnityWillSerializeMembersCache; // 0x30
	private static readonly Dictionary<Type, bool> UnityWillSerializeTypesCache; // 0x38
	private static readonly HashSet<Type> UnityNeverSerializesTypes; // 0x40
	private static readonly HashSet<string> UnityNeverSerializesTypeNames; // 0x48
	private static readonly ISerializationPolicy UnityPolicy; // 0x50
	private static readonly ISerializationPolicy EverythingPolicy; // 0x58
	private static readonly ISerializationPolicy StrictPolicy; // 0x60
	private static readonly Dictionary<MemberInfo, UnitySerializationUtility.CachedSerializationBackendResult> OdinWillSerializeCache_UnityPolicy; // 0x68
	private static readonly Dictionary<MemberInfo, UnitySerializationUtility.CachedSerializationBackendResult> OdinWillSerializeCache_EverythingPolicy; // 0x70
	private static readonly Dictionary<MemberInfo, UnitySerializationUtility.CachedSerializationBackendResult> OdinWillSerializeCache_StrictPolicy; // 0x78
	private static readonly Dictionary<ISerializationPolicy, Dictionary<MemberInfo, UnitySerializationUtility.CachedSerializationBackendResult>> OdinWillSerializeCache_CustomPolicies; // 0x80

	// Methods

	// RVA: 0x7EE5EF8 Offset: 0x7EE1EF8 VA: 0x7EE5EF8
	public static bool OdinWillSerialize(MemberInfo member, bool serializeUnityFields, ISerializationPolicy policy) { }

	// RVA: 0x7EE64C8 Offset: 0x7EE24C8 VA: 0x7EE64C8
	private static bool CalculateOdinWillSerialize(MemberInfo member, bool serializeUnityFields, ISerializationPolicy policy) { }

	// RVA: 0x7EE67E4 Offset: 0x7EE27E4 VA: 0x7EE67E4
	public static bool GuessIfUnityWillSerialize(MemberInfo member) { }

	// RVA: 0x7EE6A10 Offset: 0x7EE2A10 VA: 0x7EE6A10
	private static bool GuessIfUnityWillSerializePrivate(MemberInfo member) { }

	// RVA: 0x7EE6D3C Offset: 0x7EE2D3C VA: 0x7EE6D3C
	public static bool GuessIfUnityWillSerialize(Type type) { }

	// RVA: 0x7EE6F8C Offset: 0x7EE2F8C VA: 0x7EE6F8C
	private static bool GuessIfUnityWillSerializePrivate(Type type) { }

	// RVA: 0x7EE7D3C Offset: 0x7EE3D3C VA: 0x7EE7D3C
	public static void SerializeUnityObject(Object unityObject, ref SerializationData data, bool serializeUnityFields = False, SerializationContext context) { }

	// RVA: 0x7EE8FAC Offset: 0x7EE4FAC VA: 0x7EE8FAC
	public static void SerializeUnityObject(Object unityObject, ref string base64Bytes, ref List<Object> referencedUnityObjects, DataFormat format, bool serializeUnityFields = False, SerializationContext context) { }

	// RVA: 0x7EE80B4 Offset: 0x7EE40B4 VA: 0x7EE80B4
	public static void SerializeUnityObject(Object unityObject, ref byte[] bytes, ref List<Object> referencedUnityObjects, DataFormat format, bool serializeUnityFields = False, SerializationContext context) { }

	// RVA: 0x7EE9338 Offset: 0x7EE5338 VA: 0x7EE9338
	public static void SerializeUnityObject(Object unityObject, IDataWriter writer, bool serializeUnityFields = False) { }

	// RVA: 0x7EEA050 Offset: 0x7EE6050 VA: 0x7EEA050
	public static void DeserializeUnityObject(Object unityObject, ref SerializationData data, DeserializationContext context) { }

	// RVA: 0x7EEA0C4 Offset: 0x7EE60C4 VA: 0x7EEA0C4
	private static void DeserializeUnityObject(Object unityObject, ref SerializationData data, DeserializationContext context, bool isPrefabData, List<Object> prefabInstanceUnityObjects) { }

	// RVA: 0x7EED28C Offset: 0x7EE928C VA: 0x7EED28C
	public static void DeserializeUnityObject(Object unityObject, ref string base64Bytes, ref List<Object> referencedUnityObjects, DataFormat format, DeserializationContext context) { }

	// RVA: 0x7EEB120 Offset: 0x7EE7120 VA: 0x7EEB120
	public static void DeserializeUnityObject(Object unityObject, ref byte[] bytes, ref List<Object> referencedUnityObjects, DataFormat format, DeserializationContext context) { }

	// RVA: 0x7EEC2C4 Offset: 0x7EE82C4 VA: 0x7EEC2C4
	public static void DeserializeUnityObject(Object unityObject, IDataReader reader) { }

	// RVA: 0x7EEDA9C Offset: 0x7EE9A9C VA: 0x7EEDA9C
	public static List<string> SerializePrefabModifications(List<PrefabModification> modifications, ref List<Object> referencedUnityObjects) { }

	// RVA: 0x7EEE9F0 Offset: 0x7EEA9F0 VA: 0x7EEE9F0
	private static string GetStringFromStreamAndReset(Stream stream) { }

	// RVA: 0x7EEEAD8 Offset: 0x7EEAAD8 VA: 0x7EEEAD8
	public static List<PrefabModification> DeserializePrefabModifications(List<string> modifications, List<Object> referencedUnityObjects) { }

	// RVA: 0x7EEFB68 Offset: 0x7EEBB68 VA: 0x7EEFB68
	public static object CreateDefaultUnityInitializedObject(Type type) { }

	// RVA: 0x7EEFBC0 Offset: 0x7EEBBC0 VA: 0x7EEFBC0
	private static object CreateDefaultUnityInitializedObject(Type type, int depth) { }

	// RVA: 0x7EEC02C Offset: 0x7EE802C VA: 0x7EEC02C
	private static void ApplyPrefabModifications(Object unityObject, List<string> modificationData, List<Object> referencedUnityObjects) { }

	// RVA: 0x7EE9C78 Offset: 0x7EE5C78 VA: 0x7EE9C78
	private static WeakValueGetter GetCachedUnityMemberGetter(MemberInfo member) { }

	// RVA: 0x7EED6C4 Offset: 0x7EE96C4 VA: 0x7EED6C4
	private static WeakValueSetter GetCachedUnityMemberSetter(MemberInfo member) { }

	// RVA: 0x7EE908C Offset: 0x7EE508C VA: 0x7EE908C
	private static ICache GetCachedUnityWriter(DataFormat format, Stream stream, SerializationContext context) { }

	// RVA: 0x7EED418 Offset: 0x7EE9418 VA: 0x7EED418
	private static ICache GetCachedUnityReader(DataFormat format, Stream stream, DeserializationContext context) { }

	// RVA: 0x7EF02C8 Offset: 0x7EEC2C8 VA: 0x7EF02C8
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class FieldInfoExtensions // TypeDefIndex: 22508
{
	// Methods

	[Extension]
	// RVA: 0x7EF0AE0 Offset: 0x7EECAE0 VA: 0x7EF0AE0
	public static bool IsAliasField(FieldInfo fieldInfo) { }

	[Extension]
	// RVA: 0x7EF0B3C Offset: 0x7EECB3C VA: 0x7EF0B3C
	public static FieldInfo DeAliasField(FieldInfo fieldInfo, bool throwOnNotAliased = False) { }
}

// Namespace: 
public struct GarbageFreeIterators.ListIterator<T> : IDisposable // TypeDefIndex: 22509
{
	// Fields
	private bool isNull; // 0x0
	private List<T> list; // 0x0
	private List.Enumerator<T> enumerator; // 0x0

	// Properties
	public T Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B66E3C Offset: 0x4B62E3C VA: 0x4B66E3C
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public GarbageFreeIterators.ListIterator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B67084 Offset: 0x4B63084 VA: 0x4B67084
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B67134 Offset: 0x4B63134 VA: 0x4B67134
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B67290 Offset: 0x4B63290 VA: 0x4B67290
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B67380 Offset: 0x4B63380 VA: 0x4B67380
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: 
public struct GarbageFreeIterators.HashsetIterator<T> : IDisposable // TypeDefIndex: 22510
{
	// Fields
	private bool isNull; // 0x0
	private HashSet<T> hashset; // 0x0
	private HashSet.Enumerator<T> enumerator; // 0x0

	// Properties
	public T Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(HashSet<T> hashset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49815EC Offset: 0x497D5EC VA: 0x49815EC
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public GarbageFreeIterators.HashsetIterator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4981834 Offset: 0x497D834 VA: 0x4981834
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49818E4 Offset: 0x497D8E4 VA: 0x49818E4
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4981A40 Offset: 0x497DA40 VA: 0x4981A40
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4981B30 Offset: 0x497DB30 VA: 0x4981B30
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: 
public struct GarbageFreeIterators.DictionaryIterator<T1, T2> : IDisposable // TypeDefIndex: 22511
{
	// Fields
	private Dictionary<T1, T2> dictionary; // 0x0
	private Dictionary.Enumerator<T1, T2> enumerator; // 0x0
	private bool isNull; // 0x0

	// Properties
	public KeyValuePair<T1, T2> Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<T1, T2> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D580E0 Offset: 0x5D540E0 VA: 0x5D580E0
	|-GarbageFreeIterators.DictionaryIterator<int, object>..ctor
	|
	|-RVA: 0x5D58258 Offset: 0x5D54258 VA: 0x5D58258
	|-GarbageFreeIterators.DictionaryIterator<object, object>..ctor
	|
	|-RVA: 0x5D58548 Offset: 0x5D54548 VA: 0x5D58548
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public GarbageFreeIterators.DictionaryIterator<T1, T2> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5819C Offset: 0x5D5419C VA: 0x5D5819C
	|-GarbageFreeIterators.DictionaryIterator<int, object>.GetEnumerator
	|
	|-RVA: 0x5D58314 Offset: 0x5D54314 VA: 0x5D58314
	|-GarbageFreeIterators.DictionaryIterator<object, object>.GetEnumerator
	|
	|-RVA: 0x5D58790 Offset: 0x5D54790 VA: 0x5D58790
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<T1, T2> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D581B8 Offset: 0x5D541B8 VA: 0x5D581B8
	|-GarbageFreeIterators.DictionaryIterator<int, object>.get_Current
	|
	|-RVA: 0x5D58330 Offset: 0x5D54330 VA: 0x5D58330
	|-GarbageFreeIterators.DictionaryIterator<object, object>.get_Current
	|
	|-RVA: 0x5D58840 Offset: 0x5D54840 VA: 0x5D58840
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D581E0 Offset: 0x5D541E0 VA: 0x5D581E0
	|-GarbageFreeIterators.DictionaryIterator<int, object>.MoveNext
	|
	|-RVA: 0x5D58358 Offset: 0x5D54358 VA: 0x5D58358
	|-GarbageFreeIterators.DictionaryIterator<object, object>.MoveNext
	|
	|-RVA: 0x5D5899C Offset: 0x5D5499C VA: 0x5D5899C
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D58224 Offset: 0x5D54224 VA: 0x5D58224
	|-GarbageFreeIterators.DictionaryIterator<int, object>.Dispose
	|
	|-RVA: 0x5D5839C Offset: 0x5D5439C VA: 0x5D5839C
	|-GarbageFreeIterators.DictionaryIterator<object, object>.Dispose
	|
	|-RVA: 0x5D58A90 Offset: 0x5D54A90 VA: 0x5D58A90
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: 
public struct GarbageFreeIterators.DictionaryValueIterator<T1, T2> : IDisposable // TypeDefIndex: 22512
{
	// Fields
	private Dictionary<T1, T2> dictionary; // 0x0
	private Dictionary.Enumerator<T1, T2> enumerator; // 0x0
	private bool isNull; // 0x0

	// Properties
	public T2 Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<T1, T2> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5A138 Offset: 0x5D56138 VA: 0x5D5A138
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public GarbageFreeIterators.DictionaryValueIterator<T1, T2> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5A380 Offset: 0x5D56380 VA: 0x5D5A380
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T2 get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5A430 Offset: 0x5D56430 VA: 0x5D5A430
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5A670 Offset: 0x5D56670 VA: 0x5D5A670
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5A764 Offset: 0x5D56764 VA: 0x5D5A764
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class GarbageFreeIterators // TypeDefIndex: 22513
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static GarbageFreeIterators.ListIterator<T> GFIterator<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46315E0 Offset: 0x462D5E0 VA: 0x46315E0
	|-GarbageFreeIterators.GFIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static GarbageFreeIterators.DictionaryIterator<T1, T2> GFIterator<T1, T2>(Dictionary<T1, T2> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x463169C Offset: 0x462D69C VA: 0x463169C
	|-GarbageFreeIterators.GFIterator<int, object>
	|
	|-RVA: 0x46316EC Offset: 0x462D6EC VA: 0x46316EC
	|-GarbageFreeIterators.GFIterator<object, object>
	|
	|-RVA: 0x463173C Offset: 0x462D73C VA: 0x463173C
	|-GarbageFreeIterators.GFIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static GarbageFreeIterators.DictionaryValueIterator<T1, T2> GFValueIterator<T1, T2>(Dictionary<T1, T2> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46317F8 Offset: 0x462D7F8 VA: 0x46317F8
	|-GarbageFreeIterators.GFValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static GarbageFreeIterators.HashsetIterator<T> GFIterator<T>(HashSet<T> hashset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4631524 Offset: 0x462D524 VA: 0x4631524
	|-GarbageFreeIterators.GFIterator<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<Append>d__2<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 22514
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private IEnumerable<T> append; // 0x0
	public IEnumerable<T> <>3__append; // 0x0
	private IEnumerator<T> <>7__wrap1; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC85C4 Offset: 0x5BC45C4 VA: 0x5BC85C4
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC862C Offset: 0x5BC462C VA: 0x5BC862C
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC86B4 Offset: 0x5BC46B4 VA: 0x5BC86B4
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC8E34 Offset: 0x5BC4E34 VA: 0x5BC8E34
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC8F40 Offset: 0x5BC4F40 VA: 0x5BC8F40
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC904C Offset: 0x5BC504C VA: 0x5BC904C
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC90EC Offset: 0x5BC50EC VA: 0x5BC90EC
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9120 Offset: 0x5BC5120 VA: 0x5BC9120
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC91C4 Offset: 0x5BC51C4 VA: 0x5BC91C4
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9310 Offset: 0x5BC5310 VA: 0x5BC9310
	|-LinqExtensions.<Append>d__2<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class LinqExtensions // TypeDefIndex: 22515
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> ForEach<T>(IEnumerable<T> source, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4664DC4 Offset: 0x4660DC4 VA: 0x4664DC4
	|-LinqExtensions.ForEach<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> ForEach<T>(IEnumerable<T> source, Action<T, int> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466519C Offset: 0x466119C VA: 0x466519C
	|-LinqExtensions.ForEach<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<Append>d__2<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> Append<T>(IEnumerable<T> source, IEnumerable<T> append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4664D18 Offset: 0x4660D18 VA: 0x4664D18
	|-LinqExtensions.Append<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class MemberInfoExtensions // TypeDefIndex: 22516
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsDefined<T>(ICustomAttributeProvider member, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466E9AC Offset: 0x466A9AC VA: 0x466E9AC
	|-MemberInfoExtensions.IsDefined<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsDefined<T>(ICustomAttributeProvider member) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466E970 Offset: 0x466A970 VA: 0x466E970
	|-MemberInfoExtensions.IsDefined<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(ICustomAttributeProvider member, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466E718 Offset: 0x466A718 VA: 0x466E718
	|-MemberInfoExtensions.GetAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(ICustomAttributeProvider member) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466E6DC Offset: 0x466A6DC VA: 0x466E6DC
	|-MemberInfoExtensions.GetAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAttributes<T>(ICustomAttributeProvider member) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466E788 Offset: 0x466A788 VA: 0x466E788
	|-MemberInfoExtensions.GetAttributes<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAttributes<T>(ICustomAttributeProvider member, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466E7C4 Offset: 0x466A7C4 VA: 0x466E7C4
	|-MemberInfoExtensions.GetAttributes<object>
	*/

	[Extension]
	// RVA: 0x7EF0D38 Offset: 0x7EECD38 VA: 0x7EF0D38
	public static Attribute[] GetAttributes(ICustomAttributeProvider member) { }

	[Extension]
	// RVA: 0x7EF0E2C Offset: 0x7EECE2C VA: 0x7EF0E2C
	public static Attribute[] GetAttributes(ICustomAttributeProvider member, bool inherit) { }

	[Extension]
	// RVA: 0x7EF0C68 Offset: 0x7EECC68 VA: 0x7EF0C68
	public static string GetNiceName(MemberInfo member) { }

	[Extension]
	// RVA: 0x7EF1104 Offset: 0x7EED104 VA: 0x7EF1104
	public static bool IsStatic(MemberInfo member) { }

	[Extension]
	// RVA: 0x7EF1550 Offset: 0x7EED550 VA: 0x7EF1550
	public static bool IsAlias(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x7EF15F0 Offset: 0x7EED5F0 VA: 0x7EF15F0
	public static MemberInfo DeAlias(MemberInfo memberInfo, bool throwOnNotAliased = False) { }
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class MethodInfoExtensions // TypeDefIndex: 22517
{
	// Methods

	[Extension]
	// RVA: 0x7EF1798 Offset: 0x7EED798 VA: 0x7EF1798
	public static string GetFullName(MethodBase method, string extensionMethodPrefix) { }

	[Extension]
	// RVA: 0x7EF19A8 Offset: 0x7EED9A8 VA: 0x7EF19A8
	public static string GetParamsNames(MethodBase method) { }

	[Extension]
	// RVA: 0x7EF0F34 Offset: 0x7EECF34 VA: 0x7EF0F34
	public static string GetFullName(MethodBase method) { }

	[Extension]
	// RVA: 0x7EF18B4 Offset: 0x7EED8B4 VA: 0x7EF18B4
	public static bool IsExtensionMethod(MethodBase method) { }

	[Extension]
	// RVA: 0x7EF1BA8 Offset: 0x7EEDBA8 VA: 0x7EF1BA8
	public static bool IsAliasMethod(MethodInfo methodInfo) { }

	[Extension]
	// RVA: 0x7EF1C04 Offset: 0x7EEDC04 VA: 0x7EF1C04
	public static MethodInfo DeAliasMethod(MethodInfo methodInfo, bool throwOnNotAliased = False) { }
}

// Namespace: Sirenix.Serialization.Utilities
internal enum Operator // TypeDefIndex: 22518
{
	// Fields
	public int value__; // 0x0
	public const Operator Equality = 0;
	public const Operator Inequality = 1;
	public const Operator Addition = 2;
	public const Operator Subtraction = 3;
	public const Operator Multiply = 4;
	public const Operator Division = 5;
	public const Operator LessThan = 6;
	public const Operator GreaterThan = 7;
	public const Operator LessThanOrEqual = 8;
	public const Operator GreaterThanOrEqual = 9;
	public const Operator Modulus = 10;
	public const Operator RightShift = 11;
	public const Operator LeftShift = 12;
	public const Operator BitwiseAnd = 13;
	public const Operator BitwiseOr = 14;
	public const Operator ExclusiveOr = 15;
	public const Operator BitwiseComplement = 16;
	public const Operator LogicalAnd = 17;
	public const Operator LogicalOr = 18;
	public const Operator LogicalNot = 19;
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class PathUtilities // TypeDefIndex: 22519
{
	// Methods

	[Extension]
	// RVA: 0x7EF1D30 Offset: 0x7EEDD30 VA: 0x7EF1D30
	public static bool HasSubDirectory(DirectoryInfo parentDir, DirectoryInfo subDir) { }
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class PropertyInfoExtensions // TypeDefIndex: 22520
{
	// Methods

	[Extension]
	// RVA: 0x7EF1E84 Offset: 0x7EEDE84 VA: 0x7EF1E84
	public static bool IsAutoProperty(PropertyInfo propInfo, bool allowVirtual = False) { }

	[Extension]
	// RVA: 0x7EF208C Offset: 0x7EEE08C VA: 0x7EF208C
	public static bool IsAliasProperty(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x7EF20E8 Offset: 0x7EEE0E8 VA: 0x7EF20E8
	public static PropertyInfo DeAliasProperty(PropertyInfo propertyInfo, bool throwOnNotAliased = False) { }
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class StringExtensions // TypeDefIndex: 22521
{
	// Methods

	[Extension]
	// RVA: 0x7EF0F7C Offset: 0x7EECF7C VA: 0x7EF0F7C
	public static string ToTitleCase(string input) { }

	[Extension]
	// RVA: 0x7EE50B0 Offset: 0x7EE10B0 VA: 0x7EE50B0
	public static bool IsNullOrWhitespace(string str) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeExtensions.<>c__37<T> // TypeDefIndex: 22522
{
	// Fields
	public static readonly TypeExtensions.<>c__37<T> <>9; // 0x0
	public static Func<T, T, bool> <>9__37_0; // 0x0
	public static Func<T, T, bool> <>9__37_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485A168 Offset: 0x4856168 VA: 0x485A168
	|-TypeExtensions.<>c__37<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485A25C Offset: 0x485625C VA: 0x485A25C
	|-TypeExtensions.<>c__37<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <GetEqualityComparerDelegate>b__37_0(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485A264 Offset: 0x4856264 VA: 0x485A264
	|-TypeExtensions.<>c__37<__Il2CppFullySharedGenericType>.<GetEqualityComparerDelegate>b__37_0
	*/

	// RVA: -1 Offset: -1
	internal bool <GetEqualityComparerDelegate>b__37_1(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485A490 Offset: 0x4856490 VA: 0x485A490
	|-TypeExtensions.<>c__37<__Il2CppFullySharedGenericType>.<GetEqualityComparerDelegate>b__37_1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<>c__DisplayClass31_0 // TypeDefIndex: 22523
{
	// Fields
	public MethodInfo method; // 0x10

	// Methods

	// RVA: 0x7EFBBB0 Offset: 0x7EF7BB0 VA: 0x7EFBBB0
	public void .ctor() { }

	// RVA: 0x7EFBBB8 Offset: 0x7EF7BB8 VA: 0x7EFBBB8
	internal object <GetCastMethodDelegate>b__0(object obj) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<>c__DisplayClass47_0 // TypeDefIndex: 22524
{
	// Fields
	public string methodName; // 0x10

	// Methods

	// RVA: 0x7EFBC74 Offset: 0x7EF7C74 VA: 0x7EFBC74
	public void .ctor() { }

	// RVA: 0x7EFBC7C Offset: 0x7EF7C7C VA: 0x7EFBC7C
	internal bool <GetOperatorMethod>b__0(MethodInfo m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<>c__DisplayClass48_0 // TypeDefIndex: 22525
{
	// Fields
	public string methodName; // 0x10

	// Methods

	// RVA: 0x7EFBCB4 Offset: 0x7EF7CB4 VA: 0x7EFBCB4
	public void .ctor() { }

	// RVA: 0x7EFBCBC Offset: 0x7EF7CBC VA: 0x7EFBCBC
	internal bool <GetOperatorMethods>b__0(MethodInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetAllMembers>d__49 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IDisposable, IEnumerator // TypeDefIndex: 22526
{
	// Fields
	private int <>1__state; // 0x10
	private MemberInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Type type; // 0x28
	public Type <>3__type; // 0x30
	private BindingFlags flags; // 0x38
	public BindingFlags <>3__flags; // 0x3C
	private Type <currentType>5__2; // 0x40
	private MemberInfo[] <>7__wrap2; // 0x48
	private int <>7__wrap3; // 0x50

	// Properties
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7EFBCF4 Offset: 0x7EF7CF4 VA: 0x7EFBCF4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7EFBD28 Offset: 0x7EF7D28 VA: 0x7EFBD28 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7EFBD2C Offset: 0x7EF7D2C VA: 0x7EFBD2C Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7EFBF48 Offset: 0x7EF7F48 VA: 0x7EFBF48 Slot: 6
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EFBF50 Offset: 0x7EF7F50 VA: 0x7EFBF50 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7EFBF88 Offset: 0x7EF7F88 VA: 0x7EFBF88 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EFBF90 Offset: 0x7EF7F90 VA: 0x7EFBF90 Slot: 4
	private IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7EFC03C Offset: 0x7EF803C VA: 0x7EFC03C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetAllMembers>d__50 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IDisposable, IEnumerator // TypeDefIndex: 22527
{
	// Fields
	private int <>1__state; // 0x10
	private MemberInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Type type; // 0x28
	public Type <>3__type; // 0x30
	private BindingFlags flags; // 0x38
	public BindingFlags <>3__flags; // 0x3C
	private string name; // 0x40
	public string <>3__name; // 0x48
	private IEnumerator<MemberInfo> <>7__wrap1; // 0x50

	// Properties
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7EFC040 Offset: 0x7EF8040 VA: 0x7EFC040
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7EFC074 Offset: 0x7EF8074 VA: 0x7EFC074 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7EFC090 Offset: 0x7EF8090 VA: 0x7EFC090 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7EFC3B8 Offset: 0x7EF83B8 VA: 0x7EFC3B8
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x7EFC468 Offset: 0x7EF8468 VA: 0x7EFC468 Slot: 6
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EFC470 Offset: 0x7EF8470 VA: 0x7EFC470 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7EFC4A8 Offset: 0x7EF84A8 VA: 0x7EFC4A8 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EFC4B0 Offset: 0x7EF84B0 VA: 0x7EFC4B0 Slot: 4
	private IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7EFC56C Offset: 0x7EF856C VA: 0x7EFC56C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetAllMembers>d__51<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 22528
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Type type; // 0x0
	public Type <>3__type; // 0x0
	private BindingFlags flags; // 0x0
	public BindingFlags <>3__flags; // 0x0
	private Type <currentType>5__2; // 0x0
	private MemberInfo[] <>7__wrap2; // 0x0
	private int <>7__wrap3; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25A44 Offset: 0x5D21A44 VA: 0x5D25A44
	|-TypeExtensions.<GetAllMembers>d__51<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25A78 Offset: 0x5D21A78 VA: 0x5D25A78
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25A7C Offset: 0x5D21A7C VA: 0x5D25A7C
	|-TypeExtensions.<GetAllMembers>d__51<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25E74 Offset: 0x5D21E74 VA: 0x5D25E74
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25E7C Offset: 0x5D21E7C VA: 0x5D25E7C
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25EB0 Offset: 0x5D21EB0 VA: 0x5D25EB0
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25EB8 Offset: 0x5D21EB8 VA: 0x5D25EB8
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25F54 Offset: 0x5D21F54 VA: 0x5D25F54
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetBaseClasses>d__55 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IDisposable, IEnumerator // TypeDefIndex: 22529
{
	// Fields
	private int <>1__state; // 0x10
	private Type <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Type type; // 0x28
	public Type <>3__type; // 0x30
	private bool includeSelf; // 0x38
	public bool <>3__includeSelf; // 0x39
	private Type <current>5__2; // 0x40

	// Properties
	private Type System.Collections.Generic.IEnumerator<System.Type>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7EFC570 Offset: 0x7EF8570 VA: 0x7EFC570
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7EFC5A4 Offset: 0x7EF85A4 VA: 0x7EFC5A4 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7EFC5A8 Offset: 0x7EF85A8 VA: 0x7EFC5A8 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7EFC74C Offset: 0x7EF874C VA: 0x7EFC74C Slot: 6
	private Type System.Collections.Generic.IEnumerator<System.Type>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EFC754 Offset: 0x7EF8754 VA: 0x7EFC754 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7EFC78C Offset: 0x7EF878C VA: 0x7EFC78C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EFC794 Offset: 0x7EF8794 VA: 0x7EFC794 Slot: 4
	private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7EFC840 Offset: 0x7EF8840 VA: 0x7EFC840 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetCustomAttributes>d__64<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 22530
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Type type; // 0x0
	public Type <>3__type; // 0x0
	private bool inherit; // 0x0
	public bool <>3__inherit; // 0x0
	private object[] <attrs>5__2; // 0x0
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
	|-RVA: 0x5D26484 Offset: 0x5D22484 VA: 0x5D26484
	|-TypeExtensions.<GetCustomAttributes>d__64<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D264B8 Offset: 0x5D224B8 VA: 0x5D264B8
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D264BC Offset: 0x5D224BC VA: 0x5D264BC
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D266CC Offset: 0x5D226CC VA: 0x5D266CC
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D266D4 Offset: 0x5D226D4 VA: 0x5D266D4
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D26708 Offset: 0x5D22708 VA: 0x5D26708
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D26710 Offset: 0x5D22710 VA: 0x5D26710
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D267AC Offset: 0x5D227AC VA: 0x5D267AC
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class TypeExtensions // TypeDefIndex: 22531
{
	// Fields
	private static readonly Func<float, float, bool> FloatEqualityComparerFunc; // 0x0
	private static readonly Func<double, double, bool> DoubleEqualityComparerFunc; // 0x8
	private static readonly Func<Quaternion, Quaternion, bool> QuaternionEqualityComparerFunc; // 0x10
	private static readonly object GenericConstraintsSatisfaction_LOCK; // 0x18
	private static readonly Dictionary<Type, Type> GenericConstraintsSatisfactionInferredParameters; // 0x20
	private static readonly Dictionary<Type, Type> GenericConstraintsSatisfactionResolvedMap; // 0x28
	private static readonly HashSet<Type> GenericConstraintsSatisfactionProcessedParams; // 0x30
	private static readonly HashSet<Type> GenericConstraintsSatisfactionTypesToCheck; // 0x38
	private static readonly List<Type> GenericConstraintsSatisfactionTypesToCheck_ToAdd; // 0x40
	private static readonly Type GenericListInterface; // 0x48
	private static readonly Type GenericCollectionInterface; // 0x50
	private static readonly object WeaklyTypedTypeCastDelegates_LOCK; // 0x58
	private static readonly object StronglyTypedTypeCastDelegates_LOCK; // 0x60
	private static readonly DoubleLookupDictionary<Type, Type, Func<object, object>> WeaklyTypedTypeCastDelegates; // 0x68
	private static readonly DoubleLookupDictionary<Type, Type, Delegate> StronglyTypedTypeCastDelegates; // 0x70
	private static readonly Type[] TwoLengthTypeArray_Cached; // 0x78
	private static readonly Stack<Type> GenericArgumentsContainsTypes_ArgsToCheckCached; // 0x80
	private static HashSet<string> ReservedCSharpKeywords; // 0x88
	public static readonly Dictionary<string, string> TypeNameAlternatives; // 0x90
	private static readonly object CachedNiceNames_LOCK; // 0x98
	private static readonly Dictionary<Type, string> CachedNiceNames; // 0xA0
	private static readonly Type VoidPointerType; // 0xA8
	private static readonly Dictionary<Type, HashSet<Type>> PrimitiveImplicitCasts; // 0xB0
	private static readonly HashSet<Type> ExplicitCastIntegrals; // 0xB8

	// Methods

	// RVA: 0x7EF2214 Offset: 0x7EEE214 VA: 0x7EF2214
	private static string GetCachedNiceName(Type type) { }

	// RVA: 0x7EF23DC Offset: 0x7EEE3DC VA: 0x7EF23DC
	private static string CreateNiceName(Type type) { }

	[Extension]
	// RVA: 0x7EF2A90 Offset: 0x7EEEA90 VA: 0x7EF2A90
	internal static bool HasCastDefined(Type from, Type to, bool requireImplicitCast) { }

	// RVA: 0x7EF392C Offset: 0x7EEF92C VA: 0x7EF392C
	public static bool IsValidIdentifier(string identifier) { }

	// RVA: 0x7EF3B3C Offset: 0x7EEFB3C VA: 0x7EF3B3C
	private static bool IsValidIdentifierStartCharacter(char c) { }

	// RVA: 0x7EF3BCC Offset: 0x7EEFBCC VA: 0x7EF3BCC
	private static bool IsValidIdentifierPartCharacter(char c) { }

	[Extension]
	// RVA: 0x7EF2F08 Offset: 0x7EEEF08 VA: 0x7EF2F08
	public static bool IsCastableTo(Type from, Type to, bool requireImplicitCast = False) { }

	[Extension]
	// RVA: 0x7EF3C70 Offset: 0x7EEFC70 VA: 0x7EF3C70
	public static Func<object, object> GetCastMethodDelegate(Type from, Type to, bool requireImplicitCast = False) { }

	// RVA: -1 Offset: -1
	public static Func<TFrom, TTo> GetCastMethodDelegate<TFrom, TTo>(bool requireImplicitCast = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4734E94 Offset: 0x4730E94 VA: 0x4734E94
	|-TypeExtensions.GetCastMethodDelegate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7EF3094 Offset: 0x7EEF094 VA: 0x7EF3094
	public static MethodInfo GetCastMethod(Type from, Type to, bool requireImplicitCast = False) { }

	// RVA: 0x7EF3F04 Offset: 0x7EEFF04 VA: 0x7EF3F04
	private static bool FloatEqualityComparer(float a, float b) { }

	// RVA: 0x7EF3F44 Offset: 0x7EEFF44 VA: 0x7EF3F44
	private static bool DoubleEqualityComparer(double a, double b) { }

	// RVA: 0x7EF3F84 Offset: 0x7EEFF84 VA: 0x7EF3F84
	private static bool QuaternionEqualityComparer(Quaternion a, Quaternion b) { }

	// RVA: -1 Offset: -1
	public static Func<T, T, bool> GetEqualityComparerDelegate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4735470 Offset: 0x4731470 VA: 0x4735470
	|-TypeExtensions.GetEqualityComparerDelegate<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type type, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4734DA0 Offset: 0x4730DA0 VA: 0x4734DA0
	|-TypeExtensions.GetAttribute<object>
	*/

	[Extension]
	// RVA: 0x7EF3FAC Offset: 0x7EEFFAC VA: 0x7EF3FAC
	public static bool ImplementsOrInherits(Type type, Type to) { }

	[Extension]
	// RVA: 0x7EF3FD8 Offset: 0x7EEFFD8 VA: 0x7EF3FD8
	public static bool ImplementsOpenGenericType(Type candidateType, Type openGenericType) { }

	[Extension]
	// RVA: 0x7EDCC1C Offset: 0x7ED8C1C VA: 0x7EDCC1C
	public static bool ImplementsOpenGenericInterface(Type candidateType, Type openGenericInterfaceType) { }

	[Extension]
	// RVA: 0x7EE7AD4 Offset: 0x7EE3AD4 VA: 0x7EE7AD4
	public static bool ImplementsOpenGenericClass(Type candidateType, Type openGenericType) { }

	[Extension]
	// RVA: 0x7EF4060 Offset: 0x7EF0060 VA: 0x7EF4060
	public static Type[] GetArgumentsOfInheritedOpenGenericType(Type candidateType, Type openGenericType) { }

	[Extension]
	// RVA: 0x7EE7C00 Offset: 0x7EE3C00 VA: 0x7EE7C00
	public static Type[] GetArgumentsOfInheritedOpenGenericClass(Type candidateType, Type openGenericType) { }

	[Extension]
	// RVA: 0x7EDCE84 Offset: 0x7ED8E84 VA: 0x7EDCE84
	public static Type[] GetArgumentsOfInheritedOpenGenericInterface(Type candidateType, Type openGenericInterfaceType) { }

	[Extension]
	// RVA: 0x7EF40E8 Offset: 0x7EF00E8 VA: 0x7EF40E8
	public static MethodInfo GetOperatorMethod(Type type, Operator op, Type leftOperand, Type rightOperand) { }

	[Extension]
	// RVA: 0x7EF482C Offset: 0x7EF082C VA: 0x7EF482C
	public static MethodInfo GetOperatorMethod(Type type, Operator op) { }

	[Extension]
	// RVA: 0x7EF4BC0 Offset: 0x7EF0BC0 VA: 0x7EF4BC0
	public static MethodInfo[] GetOperatorMethods(Type type, Operator op) { }

	[IteratorStateMachine(typeof(TypeExtensions.<GetAllMembers>d__49))]
	[Extension]
	// RVA: 0x7EF4F7C Offset: 0x7EF0F7C VA: 0x7EF4F7C
	public static IEnumerable<MemberInfo> GetAllMembers(Type type, BindingFlags flags = 0) { }

	[Extension]
	[IteratorStateMachine(typeof(TypeExtensions.<GetAllMembers>d__50))]
	// RVA: 0x7EF5000 Offset: 0x7EF1000 VA: 0x7EF5000
	public static IEnumerable<MemberInfo> GetAllMembers(Type type, string name, BindingFlags flags = 0) { }

	[IteratorStateMachine(typeof(TypeExtensions.<GetAllMembers>d__51<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAllMembers<T>(Type type, BindingFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4734D24 Offset: 0x4730D24 VA: 0x4734D24
	|-TypeExtensions.GetAllMembers<object>
	*/

	[Extension]
	// RVA: 0x7EF5098 Offset: 0x7EF1098 VA: 0x7EF5098
	public static Type GetGenericBaseType(Type type, Type baseType) { }

	[Extension]
	// RVA: 0x7EF5108 Offset: 0x7EF1108 VA: 0x7EF5108
	public static Type GetGenericBaseType(Type type, Type baseType, out int depthCount) { }

	[Extension]
	// RVA: 0x7EF5540 Offset: 0x7EF1540 VA: 0x7EF5540
	public static IEnumerable<Type> GetBaseTypes(Type type, bool includeSelf = False) { }

	[IteratorStateMachine(typeof(TypeExtensions.<GetBaseClasses>d__55))]
	[Extension]
	// RVA: 0x7EF567C Offset: 0x7EF167C VA: 0x7EF567C
	public static IEnumerable<Type> GetBaseClasses(Type type, bool includeSelf = False) { }

	[Extension]
	// RVA: 0x7EF29AC Offset: 0x7EEE9AC VA: 0x7EF29AC
	private static string TypeNameGauntlet(Type type) { }

	[Extension]
	// RVA: 0x7EDCD90 Offset: 0x7ED8D90 VA: 0x7EDCD90
	public static string GetNiceName(Type type) { }

	[Extension]
	// RVA: 0x7EDD140 Offset: 0x7ED9140 VA: 0x7EDD140
	public static string GetNiceFullName(Type type) { }

	[Extension]
	// RVA: 0x7EF5704 Offset: 0x7EF1704 VA: 0x7EF5704
	public static string GetCompilableNiceName(Type type) { }

	[Extension]
	// RVA: 0x7EF57D8 Offset: 0x7EF17D8 VA: 0x7EF57D8
	public static string GetCompilableNiceFullName(Type type) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Type type, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x473526C Offset: 0x473126C VA: 0x473526C
	|-TypeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4735204 Offset: 0x4731204 VA: 0x4735204
	|-TypeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4735388 Offset: 0x4731388 VA: 0x4735388
	|-TypeExtensions.GetCustomAttributes<object>
	*/

	[IteratorStateMachine(typeof(TypeExtensions.<GetCustomAttributes>d__64<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(Type type, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47353F0 Offset: 0x47313F0 VA: 0x47353F0
	|-TypeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsDefined<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4735B88 Offset: 0x4731B88 VA: 0x4735B88
	|-TypeExtensions.IsDefined<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsDefined<T>(Type type, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4735C14 Offset: 0x4731C14 VA: 0x4735C14
	|-TypeExtensions.IsDefined<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool InheritsFrom<TBase>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4735AE4 Offset: 0x4731AE4 VA: 0x4735AE4
	|-TypeExtensions.InheritsFrom<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7EF27DC Offset: 0x7EEE7DC VA: 0x7EF27DC
	public static bool InheritsFrom(Type type, Type baseType) { }

	[Extension]
	// RVA: 0x7EF58AC Offset: 0x7EF18AC VA: 0x7EF58AC
	public static int GetInheritanceDistance(Type type, Type baseType) { }

	[Extension]
	// RVA: 0x7EF5C54 Offset: 0x7EF1C54 VA: 0x7EF5C54
	public static bool HasParamaters(MethodInfo methodInfo, IList<Type> paramTypes, bool inherit = True) { }

	[Extension]
	// RVA: 0x7EF5F14 Offset: 0x7EF1F14 VA: 0x7EF5F14
	public static Type GetReturnType(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x7EF6164 Offset: 0x7EF2164 VA: 0x7EF6164
	public static object GetMemberValue(MemberInfo member, object obj) { }

	[Extension]
	// RVA: 0x7EF62DC Offset: 0x7EF22DC VA: 0x7EF62DC
	public static void SetMemberValue(MemberInfo member, object obj, object value) { }

	[Extension]
	// RVA: 0x7EF6538 Offset: 0x7EF2538 VA: 0x7EF6538
	public static bool TryInferGenericParameters(Type genericTypeDefinition, out Type[] inferredParams, Type[] knownParameters) { }

	[Extension]
	// RVA: 0x7EF769C Offset: 0x7EF369C VA: 0x7EF769C
	public static bool AreGenericConstraintsSatisfiedBy(Type genericType, Type[] parameters) { }

	[Extension]
	// RVA: 0x7EF7A30 Offset: 0x7EF3A30 VA: 0x7EF7A30
	public static bool AreGenericConstraintsSatisfiedBy(MethodBase genericMethod, Type[] parameters) { }

	// RVA: 0x7EF7814 Offset: 0x7EF3814 VA: 0x7EF7814
	public static bool AreGenericConstraintsSatisfiedBy(Type[] definitions, Type[] parameters) { }

	[Extension]
	// RVA: 0x7EF8404 Offset: 0x7EF4404 VA: 0x7EF8404
	public static bool GenericParameterIsFulfilledBy(Type genericParameterDefinition, Type parameterType) { }

	[Extension]
	// RVA: 0x7EF7B7C Offset: 0x7EF3B7C VA: 0x7EF7B7C
	private static bool GenericParameterIsFulfilledBy(Type genericParameterDefinition, Type parameterType, Dictionary<Type, Type> resolvedMap, HashSet<Type> processedParams) { }

	[Extension]
	// RVA: 0x7EF856C Offset: 0x7EF456C VA: 0x7EF856C
	public static string GetGenericConstraintsString(Type type, bool useFullTypeNames = False) { }

	[Extension]
	// RVA: 0x7EF87D4 Offset: 0x7EF47D4 VA: 0x7EF87D4
	public static string GetGenericParameterConstraintsString(Type type, bool useFullTypeNames = False) { }

	[Extension]
	// RVA: 0x7EF8C78 Offset: 0x7EF4C78 VA: 0x7EF8C78
	public static bool GenericArgumentsContainsTypes(Type type, Type[] types) { }

	[Extension]
	// RVA: 0x7EF74A4 Offset: 0x7EF34A4 VA: 0x7EF74A4
	public static bool IsFullyConstructedGenericType(Type type) { }

	[Extension]
	// RVA: 0x7EF91DC Offset: 0x7EF51DC VA: 0x7EF91DC
	public static bool IsNullableType(Type type) { }

	// RVA: 0x7EF9234 Offset: 0x7EF5234 VA: 0x7EF9234
	public static ulong GetEnumBitmask(object value, Type enumType) { }

	[Extension]
	// RVA: 0x7EF93F8 Offset: 0x7EF53F8 VA: 0x7EF93F8
	public static Type[] SafeGetTypes(Assembly assembly) { }

	[Extension]
	// RVA: 0x7EF94BC Offset: 0x7EF54BC VA: 0x7EF94BC
	public static bool SafeIsDefined(Assembly assembly, Type attribute, bool inherit) { }

	[Extension]
	// RVA: 0x7EDF7C4 Offset: 0x7EDB7C4 VA: 0x7EDF7C4
	public static object[] SafeGetCustomAttributes(Assembly assembly, Type type, bool inherit) { }

	// RVA: 0x7EF9560 Offset: 0x7EF5560 VA: 0x7EF9560
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization.Utilities
[Extension]
internal static class UnityExtensions // TypeDefIndex: 22532
{
	// Fields
	private static readonly ValueGetter<Object, IntPtr> UnityObjectCachedPtrFieldGetter; // 0x0

	// Methods

	// RVA: 0x7EFC844 Offset: 0x7EF8844 VA: 0x7EFC844
	private static void .cctor() { }

	[Extension]
	// RVA: 0x7EFC978 Offset: 0x7EF8978 VA: 0x7EFC978
	public static bool SafeIsUnityNull(Object obj) { }
}

// Namespace: Sirenix.Serialization.Utilities
public interface ICache : IDisposable // TypeDefIndex: 22533
{
	// Properties
	public abstract object Value { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Value();
}

// Namespace: Sirenix.Serialization.Utilities
public sealed class Cache<T> : ICache, IDisposable // TypeDefIndex: 22534
{
	// Fields
	private static readonly bool IsNotificationReceiver; // 0x0
	private static object[] FreeValues; // 0x0
	private bool isFree; // 0x0
	private static int THREAD_LOCK_TOKEN; // 0x0
	private static int maxCacheSize; // 0x0
	public T Value; // 0x0

	// Properties
	public static int MaxCacheSize { get; set; }
	public bool IsFree { get; }
	private object Sirenix.Serialization.Utilities.ICache.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static int get_MaxCacheSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA4084 Offset: 0x5BA0084 VA: 0x5BA4084
	|-Cache<object>.get_MaxCacheSize
	*/

	// RVA: -1 Offset: -1
	public static void set_MaxCacheSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA40F0 Offset: 0x5BA00F0 VA: 0x5BA40F0
	|-Cache<object>.set_MaxCacheSize
	*/

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA41C4 Offset: 0x5BA01C4 VA: 0x5BA41C4
	|-Cache<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsFree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA420C Offset: 0x5BA020C VA: 0x5BA420C
	|-Cache<object>.get_IsFree
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object Sirenix.Serialization.Utilities.ICache.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA4214 Offset: 0x5BA0214 VA: 0x5BA4214
	|-Cache<object>.Sirenix.Serialization.Utilities.ICache.get_Value
	*/

	// RVA: -1 Offset: -1
	public static Cache<T> Claim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA421C Offset: 0x5BA021C VA: 0x5BA421C
	|-Cache<object>.Claim
	*/

	// RVA: -1 Offset: -1
	public static void Release(Cache<T> cache) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA4588 Offset: 0x5BA0588 VA: 0x5BA4588
	|-Cache<object>.Release
	*/

	// RVA: -1 Offset: -1
	public static T op_Implicit(Cache<T> cache) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA4AD0 Offset: 0x5BA0AD0 VA: 0x5BA4AD0
	|-Cache<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA4ADC Offset: 0x5BA0ADC VA: 0x5BA4ADC
	|-Cache<object>.Release
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA4B38 Offset: 0x5BA0B38 VA: 0x5BA4B38
	|-Cache<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA4B94 Offset: 0x5BA0B94 VA: 0x5BA4B94
	|-Cache<object>..cctor
	*/
}

// Namespace: Sirenix.Serialization.Utilities
[DefaultMember("Item")]
[Serializable]
internal class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> // TypeDefIndex: 22535
{
	// Fields
	private readonly IEqualityComparer<TSecondKey> secondKeyComparer; // 0x0

	// Properties
	public Dictionary<TSecondKey, TValue> Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60232D4 Offset: 0x601F2D4 VA: 0x60232D4
	|-DoubleLookupDictionary<int, int, object>..ctor
	|
	|-RVA: 0x6023D2C Offset: 0x601FD2C VA: 0x6023D2C
	|-DoubleLookupDictionary<object, object, object>..ctor
	|
	|-RVA: 0x6024794 Offset: 0x6020794 VA: 0x6024794
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TFirstKey> firstKeyComparer, IEqualityComparer<TSecondKey> secondKeyComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602331C Offset: 0x601F31C VA: 0x602331C
	|-DoubleLookupDictionary<int, int, object>..ctor
	|
	|-RVA: 0x6023D74 Offset: 0x601FD74 VA: 0x6023D74
	|-DoubleLookupDictionary<object, object, object>..ctor
	|
	|-RVA: 0x60247E4 Offset: 0x60207E4 VA: 0x60247E4
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary<TSecondKey, TValue> get_Item(TFirstKey firstKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6023354 Offset: 0x601F354 VA: 0x6023354
	|-DoubleLookupDictionary<int, int, object>.get_Item
	|
	|-RVA: 0x6023DAC Offset: 0x601FDAC VA: 0x6023DAC
	|-DoubleLookupDictionary<object, object, object>.get_Item
	|
	|-RVA: 0x6024820 Offset: 0x6020820 VA: 0x6024820
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public int InnerCount(TFirstKey firstKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6023404 Offset: 0x601F404 VA: 0x6023404
	|-DoubleLookupDictionary<int, int, object>.InnerCount
	|
	|-RVA: 0x6023E5C Offset: 0x601FE5C VA: 0x6023E5C
	|-DoubleLookupDictionary<object, object, object>.InnerCount
	|
	|-RVA: 0x60249B4 Offset: 0x60209B4 VA: 0x60249B4
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InnerCount
	*/

	// RVA: -1 Offset: -1
	public int TotalInnerCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6023460 Offset: 0x601F460 VA: 0x6023460
	|-DoubleLookupDictionary<int, int, object>.TotalInnerCount
	|
	|-RVA: 0x6023EB8 Offset: 0x601FEB8 VA: 0x6023EB8
	|-DoubleLookupDictionary<object, object, object>.TotalInnerCount
	|
	|-RVA: 0x6024AB8 Offset: 0x6020AB8 VA: 0x6024AB8
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TotalInnerCount
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKeys(TFirstKey firstKey, TSecondKey secondKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60235A8 Offset: 0x601F5A8 VA: 0x60235A8
	|-DoubleLookupDictionary<int, int, object>.ContainsKeys
	|
	|-RVA: 0x6024000 Offset: 0x6020000 VA: 0x6024000
	|-DoubleLookupDictionary<object, object, object>.ContainsKeys
	|
	|-RVA: 0x6024C48 Offset: 0x6020C48 VA: 0x6024C48
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKeys
	*/

	// RVA: -1 Offset: -1
	public bool TryGetInnerValue(TFirstKey firstKey, TSecondKey secondKey, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6023610 Offset: 0x601F610 VA: 0x6023610
	|-DoubleLookupDictionary<int, int, object>.TryGetInnerValue
	|
	|-RVA: 0x6024068 Offset: 0x6020068 VA: 0x6024068
	|-DoubleLookupDictionary<object, object, object>.TryGetInnerValue
	|
	|-RVA: 0x6024DC8 Offset: 0x6020DC8 VA: 0x6024DC8
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetInnerValue
	*/

	// RVA: -1 Offset: -1
	public TValue AddInner(TFirstKey firstKey, TSecondKey secondKey, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6023690 Offset: 0x601F690 VA: 0x6023690
	|-DoubleLookupDictionary<int, int, object>.AddInner
	|
	|-RVA: 0x60240E8 Offset: 0x60200E8 VA: 0x60240E8
	|-DoubleLookupDictionary<object, object, object>.AddInner
	|
	|-RVA: 0x6024F70 Offset: 0x6020F70 VA: 0x6024F70
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddInner
	*/

	// RVA: -1 Offset: -1
	public bool RemoveInner(TFirstKey firstKey, TSecondKey secondKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60237A8 Offset: 0x601F7A8 VA: 0x60237A8
	|-DoubleLookupDictionary<int, int, object>.RemoveInner
	|
	|-RVA: 0x6024200 Offset: 0x6020200 VA: 0x6024200
	|-DoubleLookupDictionary<object, object, object>.RemoveInner
	|
	|-RVA: 0x6025304 Offset: 0x6021304 VA: 0x6025304
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveInner
	*/

	// RVA: -1 Offset: -1
	public void RemoveWhere(Func<TValue, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602385C Offset: 0x601F85C VA: 0x602385C
	|-DoubleLookupDictionary<int, int, object>.RemoveWhere
	|
	|-RVA: 0x60242B4 Offset: 0x60202B4 VA: 0x60242B4
	|-DoubleLookupDictionary<object, object, object>.RemoveWhere
	|
	|-RVA: 0x6025528 Offset: 0x6021528 VA: 0x6025528
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveWhere
	*/
}

// Namespace: Sirenix.Serialization.Utilities
internal sealed class WeakValueGetter : MulticastDelegate // TypeDefIndex: 22536
{
	// Methods

	// RVA: 0x7EFCA74 Offset: 0x7EF8A74 VA: 0x7EFCA74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7EFCB24 Offset: 0x7EF8B24 VA: 0x7EFCB24 Slot: 13
	public virtual object Invoke(ref object instance) { }

	// RVA: 0x7EFCB38 Offset: 0x7EF8B38 VA: 0x7EFCB38 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref object instance, AsyncCallback callback, object object) { }

	// RVA: 0x7EFCB5C Offset: 0x7EF8B5C VA: 0x7EFCB5C Slot: 15
	public virtual object EndInvoke(ref object instance, IAsyncResult result) { }
}

// Namespace: Sirenix.Serialization.Utilities
internal sealed class WeakValueSetter : MulticastDelegate // TypeDefIndex: 22537
{
	// Methods

	// RVA: 0x7EFCB78 Offset: 0x7EF8B78 VA: 0x7EFCB78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7EFCC2C Offset: 0x7EF8C2C VA: 0x7EFCC2C Slot: 13
	public virtual void Invoke(ref object instance, object value) { }

	// RVA: 0x7EFCC40 Offset: 0x7EF8C40 VA: 0x7EFCC40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref object instance, object value, AsyncCallback callback, object object) { }

	// RVA: 0x7EFCC6C Offset: 0x7EF8C6C VA: 0x7EFCC6C Slot: 15
	public virtual void EndInvoke(ref object instance, IAsyncResult result) { }
}

// Namespace: Sirenix.Serialization.Utilities
internal sealed class WeakValueGetter<FieldType> : MulticastDelegate // TypeDefIndex: 22538
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C8024 Offset: 0x58C4024 VA: 0x58C8024
	|-WeakValueGetter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual FieldType Invoke(ref object instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C80D4 Offset: 0x58C40D4 VA: 0x58C80D4
	|-WeakValueGetter<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref object instance, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C80E8 Offset: 0x58C40E8 VA: 0x58C80E8
	|-WeakValueGetter<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual FieldType EndInvoke(ref object instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C810C Offset: 0x58C410C VA: 0x58C810C
	|-WeakValueGetter<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Sirenix.Serialization.Utilities
internal sealed class WeakValueSetter<FieldType> : MulticastDelegate // TypeDefIndex: 22539
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C836C Offset: 0x58C436C VA: 0x58C836C
	|-WeakValueSetter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref object instance, FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C8420 Offset: 0x58C4420 VA: 0x58C8420
	|-WeakValueSetter<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref object instance, FieldType value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C8434 Offset: 0x58C4434 VA: 0x58C8434
	|-WeakValueSetter<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref object instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C84B8 Offset: 0x58C44B8 VA: 0x58C84B8
	|-WeakValueSetter<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Sirenix.Serialization.Utilities
internal sealed class ValueGetter<InstanceType, FieldType> : MulticastDelegate // TypeDefIndex: 22540
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5742124 Offset: 0x573E124 VA: 0x5742124
	|-ValueGetter<object, IntPtr>..ctor
	|
	|-RVA: 0x5742238 Offset: 0x573E238 VA: 0x5742238
	|-ValueGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual FieldType Invoke(ref InstanceType instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x57421D4 Offset: 0x573E1D4 VA: 0x57421D4
	|-ValueGetter<object, IntPtr>.Invoke
	|
	|-RVA: 0x57422E8 Offset: 0x573E2E8 VA: 0x57422E8
	|-ValueGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InstanceType instance, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x57421E8 Offset: 0x573E1E8 VA: 0x57421E8
	|-ValueGetter<object, IntPtr>.BeginInvoke
	|
	|-RVA: 0x57422FC Offset: 0x573E2FC VA: 0x57422FC
	|-ValueGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual FieldType EndInvoke(ref InstanceType instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x574220C Offset: 0x573E20C VA: 0x574220C
	|-ValueGetter<object, IntPtr>.EndInvoke
	|
	|-RVA: 0x5742380 Offset: 0x573E380 VA: 0x5742380
	|-ValueGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Sirenix.Serialization.Utilities
internal sealed class ValueSetter<InstanceType, FieldType> : MulticastDelegate // TypeDefIndex: 22541
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5745FD4 Offset: 0x5741FD4 VA: 0x5745FD4
	|-ValueSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref InstanceType instance, FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5746088 Offset: 0x5742088 VA: 0x5746088
	|-ValueSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InstanceType instance, FieldType value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x574609C Offset: 0x574209C VA: 0x574609C
	|-ValueSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref InstanceType instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x574615C Offset: 0x574215C VA: 0x574615C
	|-ValueSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
public sealed class EmitUtilities.InstanceRefMethodCaller<InstanceType> : MulticastDelegate // TypeDefIndex: 22542
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499BBB4 Offset: 0x4997BB4 VA: 0x499BBB4
	|-EmitUtilities.InstanceRefMethodCaller<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref InstanceType instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499BC64 Offset: 0x4997C64 VA: 0x499BC64
	|-EmitUtilities.InstanceRefMethodCaller<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InstanceType instance, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499BC78 Offset: 0x4997C78 VA: 0x499BC78
	|-EmitUtilities.InstanceRefMethodCaller<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref InstanceType instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499BCFC Offset: 0x4997CFC VA: 0x499BCFC
	|-EmitUtilities.InstanceRefMethodCaller<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
public sealed class EmitUtilities.InstanceRefMethodCaller<InstanceType, TArg1> : MulticastDelegate // TypeDefIndex: 22543
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499BD18 Offset: 0x4997D18 VA: 0x499BD18
	|-EmitUtilities.InstanceRefMethodCaller<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref InstanceType instance, TArg1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499BDCC Offset: 0x4997DCC VA: 0x499BDCC
	|-EmitUtilities.InstanceRefMethodCaller<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InstanceType instance, TArg1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499BDE0 Offset: 0x4997DE0 VA: 0x499BDE0
	|-EmitUtilities.InstanceRefMethodCaller<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref InstanceType instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499BEA0 Offset: 0x4997EA0 VA: 0x499BEA0
	|-EmitUtilities.InstanceRefMethodCaller<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass10_0 // TypeDefIndex: 22544
{
	// Fields
	public FieldInfo fieldInfo; // 0x10

	// Methods

	// RVA: 0x7EFD284 Offset: 0x7EF9284 VA: 0x7EFD284
	public void .ctor() { }

	// RVA: 0x7EFDE1C Offset: 0x7EF9E1C VA: 0x7EFDE1C
	internal object <CreateWeakInstanceFieldGetter>b__0(ref object classInstance) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass11_0<InstanceType, FieldType> // TypeDefIndex: 22545
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486639C Offset: 0x486239C VA: 0x486639C
	|-EmitUtilities.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateInstanceFieldSetter>b__0(ref InstanceType classInstance, FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48663A4 Offset: 0x48623A4 VA: 0x48663A4
	|-EmitUtilities.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateInstanceFieldSetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass12_0<FieldType> // TypeDefIndex: 22546
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866A04 Offset: 0x4862A04 VA: 0x4866A04
	|-EmitUtilities.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866A0C Offset: 0x4862A0C VA: 0x4866A0C
	|-EmitUtilities.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>.<CreateWeakInstanceFieldSetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass13_0 // TypeDefIndex: 22547
{
	// Fields
	public FieldInfo fieldInfo; // 0x10

	// Methods

	// RVA: 0x7EFD468 Offset: 0x7EF9468 VA: 0x7EFD468
	public void .ctor() { }

	// RVA: 0x7EFDE44 Offset: 0x7EF9E44 VA: 0x7EFDE44
	internal void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, object value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass14_0 // TypeDefIndex: 22548
{
	// Fields
	public PropertyInfo propertyInfo; // 0x10

	// Methods

	// RVA: 0x7EFD6E0 Offset: 0x7EF96E0 VA: 0x7EFD6E0
	public void .ctor() { }

	// RVA: 0x7EFDE64 Offset: 0x7EF9E64 VA: 0x7EFDE64
	internal object <CreateWeakInstancePropertyGetter>b__0(ref object classInstance) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass15_0 // TypeDefIndex: 22549
{
	// Fields
	public PropertyInfo propertyInfo; // 0x10

	// Methods

	// RVA: 0x7EFD920 Offset: 0x7EF9920 VA: 0x7EFD920
	public void .ctor() { }

	// RVA: 0x7EFDE90 Offset: 0x7EF9E90 VA: 0x7EFDE90
	internal void <CreateWeakInstancePropertySetter>b__0(ref object classInstance, object value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass16_0<PropType> // TypeDefIndex: 22550
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48677D8 Offset: 0x48637D8 VA: 0x48677D8
	|-EmitUtilities.<>c__DisplayClass16_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateStaticPropertySetter>b__0(PropType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48677E0 Offset: 0x48637E0 VA: 0x48677E0
	|-EmitUtilities.<>c__DisplayClass16_0<__Il2CppFullySharedGenericType>.<CreateStaticPropertySetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass17_0<PropType> // TypeDefIndex: 22551
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48679F0 Offset: 0x48639F0 VA: 0x48679F0
	|-EmitUtilities.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal PropType <CreateStaticPropertyGetter>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48679F8 Offset: 0x48639F8 VA: 0x48679F8
	|-EmitUtilities.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType>.<CreateStaticPropertyGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass18_0<InstanceType, PropType> // TypeDefIndex: 22552
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486808C Offset: 0x486408C VA: 0x486808C
	|-EmitUtilities.<>c__DisplayClass18_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateInstancePropertySetter>b__0(ref InstanceType classInstance, PropType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4868094 Offset: 0x4864094 VA: 0x4868094
	|-EmitUtilities.<>c__DisplayClass18_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateInstancePropertySetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass19_0<InstanceType, PropType> // TypeDefIndex: 22553
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48695C8 Offset: 0x48655C8 VA: 0x48695C8
	|-EmitUtilities.<>c__DisplayClass19_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal PropType <CreateInstancePropertyGetter>b__0(ref InstanceType classInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48695D0 Offset: 0x48655D0 VA: 0x48695D0
	|-EmitUtilities.<>c__DisplayClass19_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateInstancePropertyGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass22_0<TArg1> // TypeDefIndex: 22554
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486A768 Offset: 0x4866768 VA: 0x486A768
	|-EmitUtilities.<>c__DisplayClass22_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486A770 Offset: 0x4866770 VA: 0x486A770
	|-EmitUtilities.<>c__DisplayClass22_0<__Il2CppFullySharedGenericType>.<CreateWeakInstanceMethodCaller>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass23_0 // TypeDefIndex: 22555
{
	// Fields
	public MethodInfo methodInfo; // 0x10

	// Methods

	// RVA: 0x7EFDD60 Offset: 0x7EF9D60 VA: 0x7EFDD60
	public void .ctor() { }

	// RVA: 0x7EFDEBC Offset: 0x7EF9EBC VA: 0x7EFDEBC
	internal void <CreateWeakInstanceMethodCaller>b__0(object classInstance) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass24_0<TResult, TArg1> // TypeDefIndex: 22556
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C1F8 Offset: 0x48681F8 VA: 0x486C1F8
	|-EmitUtilities.<>c__DisplayClass24_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C200 Offset: 0x4868200 VA: 0x486C200
	|-EmitUtilities.<>c__DisplayClass24_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateWeakInstanceMethodCaller>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass25_0<TResult> // TypeDefIndex: 22557
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C598 Offset: 0x4868598 VA: 0x486C598
	|-EmitUtilities.<>c__DisplayClass25_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C5A0 Offset: 0x48685A0 VA: 0x486C5A0
	|-EmitUtilities.<>c__DisplayClass25_0<__Il2CppFullySharedGenericType>.<CreateWeakInstanceMethodCallerFunc>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass26_0<TArg, TResult> // TypeDefIndex: 22558
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C880 Offset: 0x4868880 VA: 0x486C880
	|-EmitUtilities.<>c__DisplayClass26_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C888 Offset: 0x4868888 VA: 0x486C888
	|-EmitUtilities.<>c__DisplayClass26_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateWeakInstanceMethodCallerFunc>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass31_0<InstanceType> // TypeDefIndex: 22559
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486EA00 Offset: 0x486AA00 VA: 0x486EA00
	|-EmitUtilities.<>c__DisplayClass31_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateInstanceRefMethodCaller>b__0(ref InstanceType instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486EA08 Offset: 0x486AA08 VA: 0x486EA08
	|-EmitUtilities.<>c__DisplayClass31_0<__Il2CppFullySharedGenericType>.<CreateInstanceRefMethodCaller>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass32_0<InstanceType, Arg1> // TypeDefIndex: 22560
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486EF58 Offset: 0x486AF58 VA: 0x486EF58
	|-EmitUtilities.<>c__DisplayClass32_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateInstanceRefMethodCaller>b__0(ref InstanceType instance, Arg1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486EF60 Offset: 0x486AF60 VA: 0x486EF60
	|-EmitUtilities.<>c__DisplayClass32_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateInstanceRefMethodCaller>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass4_0<FieldType> // TypeDefIndex: 22561
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5459FDC Offset: 0x5455FDC VA: 0x5459FDC
	|-EmitUtilities.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal FieldType <CreateStaticFieldGetter>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5459FE4 Offset: 0x5455FE4 VA: 0x5459FE4
	|-EmitUtilities.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>.<CreateStaticFieldGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass4_1<FieldType> // TypeDefIndex: 22562
{
	// Fields
	public FieldType value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545A5A4 Offset: 0x54565A4 VA: 0x545A5A4
	|-EmitUtilities.<>c__DisplayClass4_1<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal FieldType <CreateStaticFieldGetter>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545A5AC Offset: 0x54565AC VA: 0x545A5AC
	|-EmitUtilities.<>c__DisplayClass4_1<__Il2CppFullySharedGenericType>.<CreateStaticFieldGetter>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass5_0 // TypeDefIndex: 22563
{
	// Fields
	public FieldInfo fieldInfo; // 0x10

	// Methods

	// RVA: 0x7EFCF14 Offset: 0x7EF8F14 VA: 0x7EFCF14
	public void .ctor() { }

	// RVA: 0x7EFDEDC Offset: 0x7EF9EDC VA: 0x7EFDEDC
	internal object <CreateWeakStaticFieldGetter>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass6_0<FieldType> // TypeDefIndex: 22564
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545DD10 Offset: 0x5459D10 VA: 0x545DD10
	|-EmitUtilities.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateStaticFieldSetter>b__0(FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545DD18 Offset: 0x5459D18 VA: 0x545DD18
	|-EmitUtilities.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>.<CreateStaticFieldSetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass7_0 // TypeDefIndex: 22565
{
	// Fields
	public FieldInfo fieldInfo; // 0x10

	// Methods

	// RVA: 0x7EFD0A0 Offset: 0x7EF90A0 VA: 0x7EFD0A0
	public void .ctor() { }

	// RVA: 0x7EFDF04 Offset: 0x7EF9F04 VA: 0x7EFDF04
	internal void <CreateWeakStaticFieldSetter>b__0(object value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass8_0<InstanceType, FieldType> // TypeDefIndex: 22566
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469908 Offset: 0x5465908 VA: 0x5469908
	|-EmitUtilities.<>c__DisplayClass8_0<object, IntPtr>..ctor
	|
	|-RVA: 0x5469A10 Offset: 0x5465A10 VA: 0x5469A10
	|-EmitUtilities.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal FieldType <CreateInstanceFieldGetter>b__0(ref InstanceType classInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469910 Offset: 0x5465910 VA: 0x5469910
	|-EmitUtilities.<>c__DisplayClass8_0<object, IntPtr>.<CreateInstanceFieldGetter>b__0
	|
	|-RVA: 0x5469A18 Offset: 0x5465A18 VA: 0x5469A18
	|-EmitUtilities.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateInstanceFieldGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass9_0<FieldType> // TypeDefIndex: 22567
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B1F8 Offset: 0x54671F8 VA: 0x546B1F8
	|-EmitUtilities.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal FieldType <CreateWeakInstanceFieldGetter>b__0(ref object classInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B200 Offset: 0x5467200 VA: 0x546B200
	|-EmitUtilities.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>.<CreateWeakInstanceFieldGetter>b__0
	*/
}

// Namespace: Sirenix.Serialization.Utilities
internal static class EmitUtilities // TypeDefIndex: 22568
{
	// Fields
	private static Assembly EngineAssembly; // 0x0

	// Properties
	public static bool CanEmit { get; }

	// Methods

	// RVA: 0x7EFCC88 Offset: 0x7EF8C88 VA: 0x7EFCC88
	public static bool get_CanEmit() { }

	// RVA: 0x7EFCC90 Offset: 0x7EF8C90 VA: 0x7EFCC90
	private static bool EmitIsIllegalForMember(MemberInfo member) { }

	// RVA: -1 Offset: -1
	public static Func<FieldType> CreateStaticFieldGetter<FieldType>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45777A8 Offset: 0x45737A8 VA: 0x45777A8
	|-EmitUtilities.CreateStaticFieldGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7EFCD90 Offset: 0x7EF8D90 VA: 0x7EFCD90
	public static Func<object> CreateWeakStaticFieldGetter(FieldInfo fieldInfo) { }

	// RVA: -1 Offset: -1
	public static Action<FieldType> CreateStaticFieldSetter<FieldType>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4577A44 Offset: 0x4573A44 VA: 0x4577A44
	|-EmitUtilities.CreateStaticFieldSetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7EFCF1C Offset: 0x7EF8F1C VA: 0x7EFCF1C
	public static Action<object> CreateWeakStaticFieldSetter(FieldInfo fieldInfo) { }

	// RVA: -1 Offset: -1
	public static ValueGetter<InstanceType, FieldType> CreateInstanceFieldGetter<InstanceType, FieldType>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45764BC Offset: 0x45724BC VA: 0x45764BC
	|-EmitUtilities.CreateInstanceFieldGetter<object, IntPtr>
	|
	|-RVA: 0x4576620 Offset: 0x4572620 VA: 0x4576620
	|-EmitUtilities.CreateInstanceFieldGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static WeakValueGetter<FieldType> CreateWeakInstanceFieldGetter<FieldType>(Type instanceType, FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4577FE4 Offset: 0x4573FE4 VA: 0x4577FE4
	|-EmitUtilities.CreateWeakInstanceFieldGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7EFD0A8 Offset: 0x7EF90A8 VA: 0x7EFD0A8
	public static WeakValueGetter CreateWeakInstanceFieldGetter(Type instanceType, FieldInfo fieldInfo) { }

	// RVA: -1 Offset: -1
	public static ValueSetter<InstanceType, FieldType> CreateInstanceFieldSetter<InstanceType, FieldType>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457678C Offset: 0x457278C VA: 0x457678C
	|-EmitUtilities.CreateInstanceFieldSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static WeakValueSetter<FieldType> CreateWeakInstanceFieldSetter<FieldType>(Type instanceType, FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45781B4 Offset: 0x45741B4 VA: 0x45781B4
	|-EmitUtilities.CreateWeakInstanceFieldSetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7EFD28C Offset: 0x7EF928C VA: 0x7EFD28C
	public static WeakValueSetter CreateWeakInstanceFieldSetter(Type instanceType, FieldInfo fieldInfo) { }

	// RVA: 0x7EFD470 Offset: 0x7EF9470 VA: 0x7EFD470
	public static WeakValueGetter CreateWeakInstancePropertyGetter(Type instanceType, PropertyInfo propertyInfo) { }

	// RVA: 0x7EFD6E8 Offset: 0x7EF96E8 VA: 0x7EFD6E8
	public static WeakValueSetter CreateWeakInstancePropertySetter(Type instanceType, PropertyInfo propertyInfo) { }

	// RVA: -1 Offset: -1
	public static Action<PropType> CreateStaticPropertySetter<PropType>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4577DE4 Offset: 0x4573DE4 VA: 0x4577DE4
	|-EmitUtilities.CreateStaticPropertySetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<PropType> CreateStaticPropertyGetter<PropType>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4577BE4 Offset: 0x4573BE4 VA: 0x4577BE4
	|-EmitUtilities.CreateStaticPropertyGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ValueSetter<InstanceType, PropType> CreateInstancePropertySetter<InstanceType, PropType>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4576FCC Offset: 0x4572FCC VA: 0x4576FCC
	|-EmitUtilities.CreateInstancePropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ValueGetter<InstanceType, PropType> CreateInstancePropertyGetter<InstanceType, PropType>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4576DCC Offset: 0x4572DCC VA: 0x4576DCC
	|-EmitUtilities.CreateInstancePropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<InstanceType, ReturnType> CreateMethodReturner<InstanceType, ReturnType>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45775F0 Offset: 0x45735F0 VA: 0x45775F0
	|-EmitUtilities.CreateMethodReturner<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7EFD928 Offset: 0x7EF9928 VA: 0x7EFD928
	public static Action CreateStaticMethodCaller(MethodInfo methodInfo) { }

	// RVA: -1 Offset: -1
	public static Action<object, TArg1> CreateWeakInstanceMethodCaller<TArg1>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4578384 Offset: 0x4574384 VA: 0x4578384
	|-EmitUtilities.CreateWeakInstanceMethodCaller<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7EFDB34 Offset: 0x7EF9B34 VA: 0x7EFDB34
	public static Action<object> CreateWeakInstanceMethodCaller(MethodInfo methodInfo) { }

	// RVA: -1 Offset: -1
	public static Func<object, TArg1, TResult> CreateWeakInstanceMethodCaller<TResult, TArg1>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457874C Offset: 0x457474C VA: 0x457874C
	|-EmitUtilities.CreateWeakInstanceMethodCaller<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<object, TResult> CreateWeakInstanceMethodCallerFunc<TResult>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4578C54 Offset: 0x4574C54 VA: 0x4578C54
	|-EmitUtilities.CreateWeakInstanceMethodCallerFunc<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<object, TArg, TResult> CreateWeakInstanceMethodCallerFunc<TArg, TResult>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4579010 Offset: 0x4575010 VA: 0x4579010
	|-EmitUtilities.CreateWeakInstanceMethodCallerFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Action<InstanceType> CreateInstanceMethodCaller<InstanceType>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45768F8 Offset: 0x45728F8 VA: 0x45768F8
	|-EmitUtilities.CreateInstanceMethodCaller<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Action<InstanceType, Arg1> CreateInstanceMethodCaller<InstanceType, Arg1>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4576B60 Offset: 0x4572B60 VA: 0x4576B60
	|-EmitUtilities.CreateInstanceMethodCaller<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static EmitUtilities.InstanceRefMethodCaller<InstanceType> CreateInstanceRefMethodCaller<InstanceType>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45771CC Offset: 0x45731CC VA: 0x45771CC
	|-EmitUtilities.CreateInstanceRefMethodCaller<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static EmitUtilities.InstanceRefMethodCaller<InstanceType, Arg1> CreateInstanceRefMethodCaller<InstanceType, Arg1>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45773DC Offset: 0x45733DC VA: 0x45773DC
	|-EmitUtilities.CreateInstanceRefMethodCaller<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7EFDD68 Offset: 0x7EF9D68 VA: 0x7EFDD68
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization.Utilities
public class FastTypeComparer : IEqualityComparer<Type> // TypeDefIndex: 22569
{
	// Fields
	public static readonly FastTypeComparer Instance; // 0x0

	// Methods

	// RVA: 0x7EFDF28 Offset: 0x7EF9F28 VA: 0x7EFDF28 Slot: 4
	public bool Equals(Type x, Type y) { }

	// RVA: 0x7EFDFA0 Offset: 0x7EF9FA0 VA: 0x7EFDFA0 Slot: 5
	public int GetHashCode(Type obj) { }

	// RVA: 0x7EFDFC4 Offset: 0x7EF9FC4 VA: 0x7EFDFC4
	public void .ctor() { }

	// RVA: 0x7EFDFCC Offset: 0x7EF9FCC VA: 0x7EFDFCC
	private static void .cctor() { }
}

// Namespace: Sirenix.Serialization.Utilities
internal static class Flags // TypeDefIndex: 22570
{
	// Fields
	public const BindingFlags AnyVisibility = 48;
	public const BindingFlags InstancePublic = 20;
	public const BindingFlags InstancePrivate = 36;
	public const BindingFlags InstanceAnyVisibility = 52;
	public const BindingFlags StaticPublic = 24;
	public const BindingFlags StaticPrivate = 40;
	public const BindingFlags StaticAnyVisibility = 56;
	public const BindingFlags InstancePublicDeclaredOnly = 22;
	public const BindingFlags InstancePrivateDeclaredOnly = 38;
	public const BindingFlags InstanceAnyDeclaredOnly = 54;
	public const BindingFlags StaticPublicDeclaredOnly = 26;
	public const BindingFlags StaticPrivateDeclaredOnly = 42;
	public const BindingFlags StaticAnyDeclaredOnly = 58;
	public const BindingFlags StaticInstanceAnyVisibility = 60;
	public const BindingFlags AllMembers = 124;
}

// Namespace: Sirenix.Serialization.Utilities
public interface ICacheNotificationReceiver // TypeDefIndex: 22571
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnFreed();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnClaimed();
}

// Namespace: Sirenix.Serialization.Utilities
internal interface IImmutableList : IList, ICollection, IEnumerable // TypeDefIndex: 22572
{}

// Namespace: Sirenix.Serialization.Utilities
[DefaultMember("Item")]
internal interface IImmutableList<T> : IImmutableList, IList, ICollection, IEnumerable, IList<T>, ICollection<T>, IEnumerable<T> // TypeDefIndex: 22573
{
	// Properties
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IImmutableList<__Il2CppFullySharedGenericType>.get_Item
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ImmutableList.<System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 22574
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ImmutableList <>4__this; // 0x20
	private IEnumerator <>7__wrap1; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x7EFE868 Offset: 0x7EFA868 VA: 0x7EFE868
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7EFEC34 Offset: 0x7EFAC34 VA: 0x7EFEC34 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7EFEC50 Offset: 0x7EFAC50 VA: 0x7EFEC50 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x7EFEEE8 Offset: 0x7EFAEE8 VA: 0x7EFEEE8
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x7EFEFA4 Offset: 0x7EFAFA4 VA: 0x7EFEFA4 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7EFEFAC Offset: 0x7EFAFAC VA: 0x7EFEFAC Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7EFEFE4 Offset: 0x7EFAFE4 VA: 0x7EFEFE4 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Sirenix.Serialization.Utilities
[DefaultMember("Item")]
[Serializable]
internal sealed class ImmutableList : IImmutableList<object>, IImmutableList, IList, ICollection, IEnumerable, IList<object>, ICollection<object>, IEnumerable<object> // TypeDefIndex: 22575
{
	// Fields
	[SerializeField]
	private IList innerList; // 0x10

	// Properties
	public int Count { get; }
	public bool IsFixedSize { get; }
	public bool IsReadOnly { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private object System.Collections.Generic.IList<System.Object>.Item { get; set; }
	public object Item { get; }

	// Methods

	// RVA: 0x7EFE034 Offset: 0x7EFA034 VA: 0x7EFE034
	public void .ctor(IList innerList) { }

	// RVA: 0x7EFE0B0 Offset: 0x7EFA0B0 VA: 0x7EFE0B0 Slot: 26
	public int get_Count() { }

	// RVA: 0x7EFE154 Offset: 0x7EFA154 VA: 0x7EFE154 Slot: 11
	public bool get_IsFixedSize() { }

	// RVA: 0x7EFE15C Offset: 0x7EFA15C VA: 0x7EFE15C Slot: 27
	public bool get_IsReadOnly() { }

	// RVA: 0x7EFE164 Offset: 0x7EFA164 VA: 0x7EFE164 Slot: 19
	public bool get_IsSynchronized() { }

	// RVA: 0x7EFE208 Offset: 0x7EFA208 VA: 0x7EFE208 Slot: 18
	public object get_SyncRoot() { }

	// RVA: 0x7EFE2AC Offset: 0x7EFA2AC VA: 0x7EFE2AC Slot: 5
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x7EFE354 Offset: 0x7EFA354 VA: 0x7EFE354 Slot: 6
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x7EFE3A0 Offset: 0x7EFA3A0 VA: 0x7EFE3A0 Slot: 21
	private object System.Collections.Generic.IList<System.Object>.get_Item(int index) { }

	// RVA: 0x7EFE448 Offset: 0x7EFA448 VA: 0x7EFE448 Slot: 22
	private void System.Collections.Generic.IList<System.Object>.set_Item(int index, object value) { }

	// RVA: 0x7EFE494 Offset: 0x7EFA494 VA: 0x7EFE494 Slot: 4
	public object get_Item(int index) { }

	// RVA: 0x7EFE53C Offset: 0x7EFA53C VA: 0x7EFE53C Slot: 30
	public bool Contains(object value) { }

	// RVA: 0x7EFE5E8 Offset: 0x7EFA5E8 VA: 0x7EFE5E8 Slot: 31
	public void CopyTo(object[] array, int arrayIndex) { }

	// RVA: 0x7EFE6A0 Offset: 0x7EFA6A0 VA: 0x7EFE6A0 Slot: 16
	public void CopyTo(Array array, int index) { }

	// RVA: 0x7EFE758 Offset: 0x7EFA758 VA: 0x7EFE758
	public IEnumerator GetEnumerator() { }

	// RVA: 0x7EFE7F8 Offset: 0x7EFA7F8 VA: 0x7EFE7F8 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(ImmutableList.<System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25))]
	// RVA: 0x7EFE7FC Offset: 0x7EFA7FC VA: 0x7EFE7FC Slot: 33
	private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

	// RVA: 0x7EFE890 Offset: 0x7EFA890 VA: 0x7EFE890 Slot: 7
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x7EFE8DC Offset: 0x7EFA8DC VA: 0x7EFE8DC Slot: 9
	private void System.Collections.IList.Clear() { }

	// RVA: 0x7EFE928 Offset: 0x7EFA928 VA: 0x7EFE928 Slot: 13
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x7EFE974 Offset: 0x7EFA974 VA: 0x7EFE974 Slot: 14
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x7EFE9C0 Offset: 0x7EFA9C0 VA: 0x7EFE9C0 Slot: 15
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x7EFEA0C Offset: 0x7EFAA0C VA: 0x7EFEA0C Slot: 23
	public int IndexOf(object value) { }

	// RVA: 0x7EFEAB8 Offset: 0x7EFAAB8 VA: 0x7EFEAB8 Slot: 25
	private void System.Collections.Generic.IList<System.Object>.RemoveAt(int index) { }

	// RVA: 0x7EFEB04 Offset: 0x7EFAB04 VA: 0x7EFEB04 Slot: 24
	private void System.Collections.Generic.IList<System.Object>.Insert(int index, object item) { }

	// RVA: 0x7EFEB50 Offset: 0x7EFAB50 VA: 0x7EFEB50 Slot: 28
	private void System.Collections.Generic.ICollection<System.Object>.Add(object item) { }

	// RVA: 0x7EFEB9C Offset: 0x7EFAB9C VA: 0x7EFEB9C Slot: 29
	private void System.Collections.Generic.ICollection<System.Object>.Clear() { }

	// RVA: 0x7EFEBE8 Offset: 0x7EFABE8 VA: 0x7EFEBE8 Slot: 32
	private bool System.Collections.Generic.ICollection<System.Object>.Remove(object item) { }
}

// Namespace: Sirenix.Serialization.Utilities
[DefaultMember("Item")]
[Serializable]
public sealed class ImmutableList<T> : IImmutableList<T>, IImmutableList, IList, ICollection, IEnumerable, IList<T>, ICollection<T>, IEnumerable<T> // TypeDefIndex: 22576
{
	// Fields
	[SerializeField]
	private IList<T> innerList; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> innerList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49934CC Offset: 0x498F4CC VA: 0x49934CC
	|-ImmutableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993540 Offset: 0x498F540 VA: 0x4993540
	|-ImmutableList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49935C8 Offset: 0x498F5C8 VA: 0x49935C8
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49935D0 Offset: 0x498F5D0 VA: 0x49935D0
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49935D8 Offset: 0x498F5D8 VA: 0x49935D8
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49935E0 Offset: 0x498F5E0 VA: 0x49935E0
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49935E8 Offset: 0x498F5E8 VA: 0x49935E8
	|-ImmutableList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49935F0 Offset: 0x498F5F0 VA: 0x49935F0
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499369C Offset: 0x498F69C VA: 0x499369C
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49936E4 Offset: 0x498F6E4 VA: 0x49936E4
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993800 Offset: 0x498F800 VA: 0x4993800
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993848 Offset: 0x498F848 VA: 0x4993848
	|-ImmutableList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993964 Offset: 0x498F964 VA: 0x4993964
	|-ImmutableList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993AAC Offset: 0x498FAAC VA: 0x4993AAC
	|-ImmutableList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993B50 Offset: 0x498FB50 VA: 0x4993B50
	|-ImmutableList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993BD8 Offset: 0x498FBD8 VA: 0x4993BD8
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993CDC Offset: 0x498FCDC VA: 0x4993CDC
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993D24 Offset: 0x498FD24 VA: 0x4993D24
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993D6C Offset: 0x498FD6C VA: 0x4993D6C
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993DB4 Offset: 0x498FDB4 VA: 0x4993DB4
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993DC8 Offset: 0x498FDC8 VA: 0x4993DC8
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993E10 Offset: 0x498FE10 VA: 0x4993E10
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993E58 Offset: 0x498FE58 VA: 0x4993E58
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993FB0 Offset: 0x498FFB0 VA: 0x4993FB0
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994100 Offset: 0x4990100 VA: 0x4994100
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994148 Offset: 0x4990148 VA: 0x4994148
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994190 Offset: 0x4990190 VA: 0x4994190
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49941D8 Offset: 0x49901D8 VA: 0x49941D8
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994220 Offset: 0x4990220 VA: 0x4994220
	|-ImmutableList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994360 Offset: 0x4990360 VA: 0x4994360
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	*/
}

// Namespace: Sirenix.Serialization.Utilities
[DefaultMember("Item")]
[Serializable]
public sealed class ImmutableList<TList, TElement> : IImmutableList<TElement>, IImmutableList, IList, ICollection, IEnumerable, IList<TElement>, ICollection<TElement>, IEnumerable<TElement> // TypeDefIndex: 22577
{
	// Fields
	private TList innerList; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	private TElement System.Collections.Generic.IList<TElement>.Item { get; set; }
	public TElement Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TList innerList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995284 Offset: 0x4991284 VA: 0x4995284
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49953D0 Offset: 0x49913D0 VA: 0x49953D0
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49954CC Offset: 0x49914CC VA: 0x49954CC
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49954D4 Offset: 0x49914D4 VA: 0x49954D4
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49954DC Offset: 0x49914DC VA: 0x49954DC
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49954E4 Offset: 0x49914E4 VA: 0x49954E4
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49954EC Offset: 0x49914EC VA: 0x49954EC
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49954F4 Offset: 0x49914F4 VA: 0x49954F4
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49955A0 Offset: 0x49915A0 VA: 0x49955A0
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49955E8 Offset: 0x49915E8 VA: 0x49955E8
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995724 Offset: 0x4991724 VA: 0x4995724
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TElement get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499576C Offset: 0x499176C VA: 0x499576C
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public bool Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49958A8 Offset: 0x49918A8 VA: 0x49958A8
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public void CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995A0C Offset: 0x4991A0C VA: 0x4995A0C
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995B20 Offset: 0x4991B20 VA: 0x4995B20
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995C1C Offset: 0x4991C1C VA: 0x4995C1C
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995D78 Offset: 0x4991D78 VA: 0x4995D78
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995DC0 Offset: 0x4991DC0 VA: 0x4995DC0
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995E08 Offset: 0x4991E08 VA: 0x4995E08
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995E50 Offset: 0x4991E50 VA: 0x4995E50
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995E64 Offset: 0x4991E64 VA: 0x4995E64
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995EAC Offset: 0x4991EAC VA: 0x4995EAC
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995EF4 Offset: 0x4991EF4 VA: 0x4995EF4
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499605C Offset: 0x499205C VA: 0x499605C
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49961BC Offset: 0x49921BC VA: 0x49961BC
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996204 Offset: 0x4992204 VA: 0x4996204
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499624C Offset: 0x499224C VA: 0x499624C
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996294 Offset: 0x4992294 VA: 0x4996294
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public int IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49962DC Offset: 0x49922DC VA: 0x49962DC
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996438 Offset: 0x4992438 VA: 0x4996438
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/
}

// Namespace: Sirenix.Serialization.Utilities
internal sealed class MemberAliasFieldInfo : FieldInfo // TypeDefIndex: 22578
{
	// Fields
	private const string FAKE_NAME_SEPARATOR_STRING = "+";
	private FieldInfo aliasedField; // 0x10
	private string mangledName; // 0x18

	// Properties
	public FieldInfo AliasedField { get; }
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0x7EFEFEC Offset: 0x7EFAFEC VA: 0x7EFEFEC
	public void .ctor(FieldInfo field, string namePrefix) { }

	// RVA: 0x7EFF098 Offset: 0x7EFB098 VA: 0x7EFF098
	public void .ctor(FieldInfo field, string namePrefix, string separatorString) { }

	// RVA: 0x7EFF11C Offset: 0x7EFB11C VA: 0x7EFF11C
	public FieldInfo get_AliasedField() { }

	// RVA: 0x7EFF124 Offset: 0x7EFB124 VA: 0x7EFF124 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x7EFF148 Offset: 0x7EFB148 VA: 0x7EFF148 Slot: 23
	public override int get_MetadataToken() { }

	// RVA: 0x7EFF16C Offset: 0x7EFB16C VA: 0x7EFF16C Slot: 13
	public override string get_Name() { }

	// RVA: 0x7EFF174 Offset: 0x7EFB174 VA: 0x7EFF174 Slot: 14
	public override Type get_DeclaringType() { }

	// RVA: 0x7EFF198 Offset: 0x7EFB198 VA: 0x7EFF198 Slot: 15
	public override Type get_ReflectedType() { }

	// RVA: 0x7EFF1BC Offset: 0x7EFB1BC VA: 0x7EFF1BC Slot: 31
	public override Type get_FieldType() { }

	// RVA: 0x7EFF1E0 Offset: 0x7EFB1E0 VA: 0x7EFF1E0 Slot: 47
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x7EFF204 Offset: 0x7EFB204 VA: 0x7EFF204 Slot: 30
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x7EFF228 Offset: 0x7EFB228 VA: 0x7EFF228 Slot: 19
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x7EFF250 Offset: 0x7EFB250 VA: 0x7EFF250 Slot: 20
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x7EFF278 Offset: 0x7EFB278 VA: 0x7EFF278 Slot: 18
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x7EFF2A0 Offset: 0x7EFB2A0 VA: 0x7EFF2A0 Slot: 48
	public override object GetValue(object obj) { }

	// RVA: 0x7EFF2C4 Offset: 0x7EFB2C4 VA: 0x7EFF2C4 Slot: 50
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }
}

// Namespace: Sirenix.Serialization.Utilities
internal sealed class MemberAliasMethodInfo : MethodInfo // TypeDefIndex: 22579
{
	// Fields
	private const string FAKE_NAME_SEPARATOR_STRING = "+";
	private MethodInfo aliasedMethod; // 0x10
	private string mangledName; // 0x18

	// Properties
	public MethodInfo AliasedMethod { get; }
	public override ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override Type ReturnType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x7EFF2E8 Offset: 0x7EFB2E8 VA: 0x7EFF2E8
	public void .ctor(MethodInfo method, string namePrefix) { }

	// RVA: 0x7EFF394 Offset: 0x7EFB394 VA: 0x7EFF394
	public void .ctor(MethodInfo method, string namePrefix, string separatorString) { }

	// RVA: 0x7EFF418 Offset: 0x7EFB418 VA: 0x7EFF418
	public MethodInfo get_AliasedMethod() { }

	// RVA: 0x7EFF420 Offset: 0x7EFB420 VA: 0x7EFF420 Slot: 77
	public override ICustomAttributeProvider get_ReturnTypeCustomAttributes() { }

	// RVA: 0x7EFF444 Offset: 0x7EFB444 VA: 0x7EFF444 Slot: 56
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x7EFF468 Offset: 0x7EFB468 VA: 0x7EFF468 Slot: 31
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x7EFF48C Offset: 0x7EFB48C VA: 0x7EFF48C Slot: 73
	public override Type get_ReturnType() { }

	// RVA: 0x7EFF4B0 Offset: 0x7EFB4B0 VA: 0x7EFF4B0 Slot: 14
	public override Type get_DeclaringType() { }

	// RVA: 0x7EFF4D4 Offset: 0x7EFB4D4 VA: 0x7EFF4D4 Slot: 13
	public override string get_Name() { }

	// RVA: 0x7EFF4DC Offset: 0x7EFB4DC VA: 0x7EFF4DC Slot: 15
	public override Type get_ReflectedType() { }

	// RVA: 0x7EFF500 Offset: 0x7EFB500 VA: 0x7EFF500 Slot: 76
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x7EFF524 Offset: 0x7EFB524 VA: 0x7EFF524 Slot: 19
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x7EFF54C Offset: 0x7EFB54C VA: 0x7EFF54C Slot: 20
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x7EFF574 Offset: 0x7EFB574 VA: 0x7EFF574 Slot: 33
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x7EFF598 Offset: 0x7EFB598 VA: 0x7EFF598 Slot: 30
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x7EFF5BC Offset: 0x7EFB5BC VA: 0x7EFF5BC Slot: 55
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x7EFF5E0 Offset: 0x7EFB5E0 VA: 0x7EFF5E0 Slot: 18
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: Sirenix.Serialization.Utilities
internal sealed class MemberAliasPropertyInfo : PropertyInfo // TypeDefIndex: 22580
{
	// Fields
	private const string FakeNameSeparatorString = "+";
	private PropertyInfo aliasedProperty; // 0x10
	private string mangledName; // 0x18

	// Properties
	public PropertyInfo AliasedProperty { get; }
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type PropertyType { get; }
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x7EFF608 Offset: 0x7EFB608 VA: 0x7EFF608
	public void .ctor(PropertyInfo prop, string namePrefix) { }

	// RVA: 0x7EFF6B4 Offset: 0x7EFB6B4 VA: 0x7EFF6B4
	public void .ctor(PropertyInfo prop, string namePrefix, string separatorString) { }

	// RVA: 0x7EFF738 Offset: 0x7EFB738 VA: 0x7EFF738
	public PropertyInfo get_AliasedProperty() { }

	// RVA: 0x7EFF740 Offset: 0x7EFB740 VA: 0x7EFF740 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x7EFF764 Offset: 0x7EFB764 VA: 0x7EFF764 Slot: 23
	public override int get_MetadataToken() { }

	// RVA: 0x7EFF788 Offset: 0x7EFB788 VA: 0x7EFF788 Slot: 13
	public override string get_Name() { }

	// RVA: 0x7EFF790 Offset: 0x7EFB790 VA: 0x7EFF790 Slot: 14
	public override Type get_DeclaringType() { }

	// RVA: 0x7EFF7B4 Offset: 0x7EFB7B4 VA: 0x7EFF7B4 Slot: 15
	public override Type get_ReflectedType() { }

	// RVA: 0x7EFF7D8 Offset: 0x7EFB7D8 VA: 0x7EFF7D8 Slot: 30
	public override Type get_PropertyType() { }

	// RVA: 0x7EFF7FC Offset: 0x7EFB7FC VA: 0x7EFF7FC Slot: 32
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x7EFF820 Offset: 0x7EFB820 VA: 0x7EFF820 Slot: 34
	public override bool get_CanRead() { }

	// RVA: 0x7EFF844 Offset: 0x7EFB844 VA: 0x7EFF844 Slot: 35
	public override bool get_CanWrite() { }

	// RVA: 0x7EFF868 Offset: 0x7EFB868 VA: 0x7EFF868 Slot: 19
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x7EFF890 Offset: 0x7EFB890 VA: 0x7EFF890 Slot: 20
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x7EFF8B8 Offset: 0x7EFB8B8 VA: 0x7EFF8B8 Slot: 18
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x7EFF8E0 Offset: 0x7EFB8E0 VA: 0x7EFF8E0 Slot: 37
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x7EFF908 Offset: 0x7EFB908 VA: 0x7EFF908 Slot: 40
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x7EFF930 Offset: 0x7EFB930 VA: 0x7EFF930 Slot: 31
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x7EFF954 Offset: 0x7EFB954 VA: 0x7EFF954 Slot: 43
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x7EFF97C Offset: 0x7EFB97C VA: 0x7EFF97C Slot: 47
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x7EFF9A0 Offset: 0x7EFB9A0 VA: 0x7EFF9A0 Slot: 51
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }
}

// Namespace: Sirenix.Serialization.Utilities
internal class ReferenceEqualityComparer<T> : IEqualityComparer<T> // TypeDefIndex: 22581
{
	// Fields
	public static readonly ReferenceEqualityComparer<T> Default; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495168 Offset: 0x5491168 VA: 0x5495168
	|-ReferenceEqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495174 Offset: 0x5491174 VA: 0x5495174
	|-ReferenceEqualityComparer<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495214 Offset: 0x5491214 VA: 0x5495214
	|-ReferenceEqualityComparer<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549521C Offset: 0x549121C VA: 0x549521C
	|-ReferenceEqualityComparer<object>..cctor
	*/
}

// Namespace: Sirenix.Serialization.Utilities
internal static class UnityVersion // TypeDefIndex: 22582
{
	// Fields
	public static readonly int Major; // 0x0
	public static readonly int Minor; // 0x4

	// Methods

	// RVA: 0x7EFF9C4 Offset: 0x7EFB9C4 VA: 0x7EFF9C4
	private static void .cctor() { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x7EFFDCC Offset: 0x7EFBDCC VA: 0x7EFFDCC
	private static void EnsureLoaded() { }

	// RVA: 0x7EFFDD0 Offset: 0x7EFBDD0 VA: 0x7EFFDD0
	public static bool IsVersionOrGreater(int major, int minor) { }
}

// Namespace: 
private struct UnsafeUtilities.Struct256Bit // TypeDefIndex: 22583
{
	// Fields
	public Decimal d1; // 0x0
	public Decimal d2; // 0x10
}

// Namespace: Sirenix.Serialization.Utilities.Unsafe
internal static class UnsafeUtilities // TypeDefIndex: 22584
{
	// Methods

	// RVA: -1 Offset: -1
	public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47565F8 Offset: 0x47525F8 VA: 0x47565F8
	|-UnsafeUtilities.StructArrayFromBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength, int byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x475663C Offset: 0x475263C VA: 0x475663C
	|-UnsafeUtilities.StructArrayFromBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static byte[] StructArrayToBytes<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4756C04 Offset: 0x4752C04 VA: 0x4756C04
	|-UnsafeUtilities.StructArrayToBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static byte[] StructArrayToBytes<T>(T[] array, ref byte[] bytes, int byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4756C50 Offset: 0x4752C50 VA: 0x4756C50
	|-UnsafeUtilities.StructArrayToBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7EFFE90 Offset: 0x7EFBE90 VA: 0x7EFFE90
	public static string StringFromBytes(byte[] buffer, int charLength, bool needs16BitSupport) { }

	// RVA: 0x7F002A0 Offset: 0x7EFC2A0 VA: 0x7F002A0
	public static int StringToBytes(byte[] buffer, string value, bool needs16BitSupport) { }

	// RVA: 0x7F0069C Offset: 0x7EFC69C VA: 0x7F0069C
	public static void MemoryCopy(void* from, void* to, int bytes) { }

	// RVA: 0x7F006F4 Offset: 0x7EFC6F4 VA: 0x7F006F4
	public static void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 22585
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 22586
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 21244F82B210125632917591768F6BF22EB6861F80C6C25A25BD26DFB580EA7B /*Metadata offset 0xF17030*/; // 0x0

	// Methods

	// RVA: 0x7F00960 Offset: 0x7EFC960 VA: 0x7F00960
	internal static uint ComputeStringHash(string s) { }
}

