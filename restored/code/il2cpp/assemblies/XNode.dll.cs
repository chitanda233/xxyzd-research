// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28370
{}

// Namespace: 
public enum Node.ShowBackingValue // TypeDefIndex: 28371
{
	// Fields
	public int value__; // 0x0
	public const Node.ShowBackingValue Never = 0;
	public const Node.ShowBackingValue Unconnected = 1;
	public const Node.ShowBackingValue Always = 2;
}

// Namespace: 
public enum Node.ConnectionType // TypeDefIndex: 28372
{
	// Fields
	public int value__; // 0x0
	public const Node.ConnectionType Multiple = 0;
	public const Node.ConnectionType Override = 1;
}

// Namespace: 
public enum Node.TypeConstraint // TypeDefIndex: 28373
{
	// Fields
	public int value__; // 0x0
	public const Node.TypeConstraint None = 0;
	public const Node.TypeConstraint Inherited = 1;
	public const Node.TypeConstraint Strict = 2;
	public const Node.TypeConstraint InheritedInverse = 3;
}

// Namespace: 
[Usage(256)]
public class Node.InputAttribute : Attribute // TypeDefIndex: 28374
{
	// Fields
	public Node.ShowBackingValue backingValue; // 0x10
	public Node.ConnectionType connectionType; // 0x14
	public bool dynamicPortList; // 0x18
	public Node.TypeConstraint typeConstraint; // 0x1C

	// Methods

	// RVA: 0x89E698C Offset: 0x89E298C VA: 0x89E698C
	public void .ctor(Node.ShowBackingValue backingValue = 1, Node.ConnectionType connectionType = 0, Node.TypeConstraint typeConstraint = 0, bool dynamicPortList = False) { }
}

// Namespace: 
[Usage(256)]
public class Node.OutputAttribute : Attribute // TypeDefIndex: 28375
{
	// Fields
	public Node.ShowBackingValue backingValue; // 0x10
	public Node.ConnectionType connectionType; // 0x14
	public bool dynamicPortList; // 0x18
	public Node.TypeConstraint typeConstraint; // 0x1C

	// Methods

	// RVA: 0x89E69D0 Offset: 0x89E29D0 VA: 0x89E69D0
	public void .ctor(Node.ShowBackingValue backingValue = 0, Node.ConnectionType connectionType = 0, Node.TypeConstraint typeConstraint = 0, bool dynamicPortList = False) { }
}

// Namespace: 
[Usage(4, AllowMultiple = False)]
public class Node.NodeTintAttribute : Attribute // TypeDefIndex: 28376
{
	// Fields
	public Color color; // 0x10

	// Methods

	// RVA: 0x89E6A14 Offset: 0x89E2A14 VA: 0x89E6A14
	public void .ctor(string hex) { }

	// RVA: 0x89E6A44 Offset: 0x89E2A44 VA: 0x89E6A44
	public void .ctor(byte r, byte g, byte b) { }
}

// Namespace: 
[Serializable]
private class Node.NodePortDictionary : Dictionary<string, NodePort>, ISerializationCallbackReceiver // TypeDefIndex: 28377
{
	// Fields
	[SerializeField]
	private List<string> keys; // 0x50
	[SerializeField]
	private List<NodePort> values; // 0x58

	// Methods

	// RVA: 0x89E6AA8 Offset: 0x89E2AA8 VA: 0x89E6AA8 Slot: 46
	public void OnBeforeSerialize() { }

	// RVA: 0x89E6D80 Offset: 0x89E2D80 VA: 0x89E6D80 Slot: 47
	public void OnAfterDeserialize() { }

	// RVA: 0x89E689C Offset: 0x89E289C VA: 0x89E689C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Node.<get_DynamicInputs>d__26 : IEnumerable<NodePort>, IEnumerable, IEnumerator<NodePort>, IEnumerator, IDisposable // TypeDefIndex: 28378
{
	// Fields
	private int <>1__state; // 0x10
	private NodePort <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public Node <>4__this; // 0x28
	private IEnumerator<NodePort> <>7__wrap1; // 0x30

	// Properties
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x89E5348 Offset: 0x89E1348 VA: 0x89E5348
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x89E700C Offset: 0x89E300C VA: 0x89E700C Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x89E7028 Offset: 0x89E3028 VA: 0x89E7028 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x89E7310 Offset: 0x89E3310 VA: 0x89E7310
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x89E73C0 Offset: 0x89E33C0 VA: 0x89E73C0 Slot: 6
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E73C8 Offset: 0x89E33C8 VA: 0x89E73C8 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x89E7400 Offset: 0x89E3400 VA: 0x89E7400 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E7408 Offset: 0x89E3408 VA: 0x89E7408 Slot: 4
	private IEnumerator<NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x89E74AC Offset: 0x89E34AC VA: 0x89E74AC Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Node.<get_DynamicOutputs>d__24 : IEnumerable<NodePort>, IEnumerable, IEnumerator<NodePort>, IEnumerator, IDisposable // TypeDefIndex: 28379
{
	// Fields
	private int <>1__state; // 0x10
	private NodePort <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public Node <>4__this; // 0x28
	private IEnumerator<NodePort> <>7__wrap1; // 0x30

	// Properties
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x89E5314 Offset: 0x89E1314 VA: 0x89E5314
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x89E74B0 Offset: 0x89E34B0 VA: 0x89E74B0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x89E74CC Offset: 0x89E34CC VA: 0x89E74CC Slot: 8
	private bool MoveNext() { }

	// RVA: 0x89E77B8 Offset: 0x89E37B8 VA: 0x89E77B8
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x89E7868 Offset: 0x89E3868 VA: 0x89E7868 Slot: 6
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E7870 Offset: 0x89E3870 VA: 0x89E7870 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x89E78A8 Offset: 0x89E38A8 VA: 0x89E78A8 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E78B0 Offset: 0x89E38B0 VA: 0x89E78B0 Slot: 4
	private IEnumerator<NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x89E7954 Offset: 0x89E3954 VA: 0x89E7954 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Node.<get_DynamicPorts>d__22 : IEnumerable<NodePort>, IEnumerable, IEnumerator<NodePort>, IEnumerator, IDisposable // TypeDefIndex: 28380
{
	// Fields
	private int <>1__state; // 0x10
	private NodePort <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public Node <>4__this; // 0x28
	private IEnumerator<NodePort> <>7__wrap1; // 0x30

	// Properties
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x89E52E0 Offset: 0x89E12E0 VA: 0x89E52E0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x89E7958 Offset: 0x89E3958 VA: 0x89E7958 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x89E7974 Offset: 0x89E3974 VA: 0x89E7974 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x89E7C44 Offset: 0x89E3C44 VA: 0x89E7C44
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x89E7CF4 Offset: 0x89E3CF4 VA: 0x89E7CF4 Slot: 6
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E7CFC Offset: 0x89E3CFC VA: 0x89E7CFC Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x89E7D34 Offset: 0x89E3D34 VA: 0x89E7D34 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E7D3C Offset: 0x89E3D3C VA: 0x89E7D3C Slot: 4
	private IEnumerator<NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x89E7DE0 Offset: 0x89E3DE0 VA: 0x89E7DE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Node.<get_Inputs>d__20 : IEnumerable<NodePort>, IEnumerable, IEnumerator<NodePort>, IEnumerator, IDisposable // TypeDefIndex: 28381
{
	// Fields
	private int <>1__state; // 0x10
	private NodePort <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public Node <>4__this; // 0x28
	private IEnumerator<NodePort> <>7__wrap1; // 0x30

	// Properties
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x89E52AC Offset: 0x89E12AC VA: 0x89E52AC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x89E7DE4 Offset: 0x89E3DE4 VA: 0x89E7DE4 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x89E7E00 Offset: 0x89E3E00 VA: 0x89E7E00 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x89E80D0 Offset: 0x89E40D0 VA: 0x89E80D0
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x89E8180 Offset: 0x89E4180 VA: 0x89E8180 Slot: 6
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E8188 Offset: 0x89E4188 VA: 0x89E8188 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x89E81C0 Offset: 0x89E41C0 VA: 0x89E81C0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E81C8 Offset: 0x89E41C8 VA: 0x89E81C8 Slot: 4
	private IEnumerator<NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x89E826C Offset: 0x89E426C VA: 0x89E826C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Node.<get_Outputs>d__18 : IEnumerable<NodePort>, IEnumerable, IEnumerator<NodePort>, IEnumerator, IDisposable // TypeDefIndex: 28382
{
	// Fields
	private int <>1__state; // 0x10
	private NodePort <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public Node <>4__this; // 0x28
	private IEnumerator<NodePort> <>7__wrap1; // 0x30

	// Properties
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x89E51FC Offset: 0x89E11FC VA: 0x89E51FC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x89E8270 Offset: 0x89E4270 VA: 0x89E8270 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x89E828C Offset: 0x89E428C VA: 0x89E828C Slot: 8
	private bool MoveNext() { }

	// RVA: 0x89E8560 Offset: 0x89E4560 VA: 0x89E8560
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x89E8610 Offset: 0x89E4610 VA: 0x89E8610 Slot: 6
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E8618 Offset: 0x89E4618 VA: 0x89E8618 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x89E8650 Offset: 0x89E4650 VA: 0x89E8650 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E8658 Offset: 0x89E4658 VA: 0x89E8658 Slot: 4
	private IEnumerator<NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x89E86FC Offset: 0x89E46FC VA: 0x89E86FC Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Node.<get_Ports>d__16 : IEnumerable<NodePort>, IEnumerable, IEnumerator<NodePort>, IEnumerator, IDisposable // TypeDefIndex: 28383
{
	// Fields
	private int <>1__state; // 0x10
	private NodePort <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public Node <>4__this; // 0x28
	private Dictionary.ValueCollection.Enumerator<string, NodePort> <>7__wrap1; // 0x30

	// Properties
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x89E514C Offset: 0x89E114C VA: 0x89E514C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x89E8700 Offset: 0x89E4700 VA: 0x89E8700 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x89E871C Offset: 0x89E471C VA: 0x89E871C Slot: 8
	private bool MoveNext() { }

	// RVA: 0x89E88EC Offset: 0x89E48EC VA: 0x89E88EC
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x89E893C Offset: 0x89E493C VA: 0x89E893C Slot: 6
	private NodePort System.Collections.Generic.IEnumerator<XNode.NodePort>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E8944 Offset: 0x89E4944 VA: 0x89E8944 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x89E897C Offset: 0x89E497C VA: 0x89E897C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x89E8984 Offset: 0x89E4984 VA: 0x89E8984 Slot: 4
	private IEnumerator<NodePort> System.Collections.Generic.IEnumerable<XNode.NodePort>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x89E8A28 Offset: 0x89E4A28 VA: 0x89E8A28 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: XNode
[Serializable]
public abstract class Node : ScriptableObject // TypeDefIndex: 28384
{
	// Fields
	[SerializeField]
	public NodeGraph graph; // 0x18
	[SerializeField]
	public Vector2 position; // 0x20
	[SerializeField]
	private Node.NodePortDictionary ports; // 0x28
	public static NodeGraph graphHotfix; // 0x0

	// Properties
	[Obsolete("Use DynamicPorts instead")]
	public IEnumerable<NodePort> InstancePorts { get; }
	[Obsolete("Use DynamicOutputs instead")]
	public IEnumerable<NodePort> InstanceOutputs { get; }
	[Obsolete("Use DynamicInputs instead")]
	public IEnumerable<NodePort> InstanceInputs { get; }
	public IEnumerable<NodePort> Ports { get; }
	public IEnumerable<NodePort> Outputs { get; }
	public IEnumerable<NodePort> Inputs { get; }
	public IEnumerable<NodePort> DynamicPorts { get; }
	public IEnumerable<NodePort> DynamicOutputs { get; }
	public IEnumerable<NodePort> DynamicInputs { get; }

	// Methods

	// RVA: 0x89E49C4 Offset: 0x89E09C4 VA: 0x89E49C4
	public IEnumerable<NodePort> get_InstancePorts() { }

	// RVA: 0x89E4A44 Offset: 0x89E0A44 VA: 0x89E4A44
	public IEnumerable<NodePort> get_InstanceOutputs() { }

	// RVA: 0x89E4AC4 Offset: 0x89E0AC4 VA: 0x89E4AC4
	public IEnumerable<NodePort> get_InstanceInputs() { }

	[Obsolete("Use AddDynamicInput instead")]
	// RVA: 0x89E4B44 Offset: 0x89E0B44 VA: 0x89E4B44
	public NodePort AddInstanceInput(Type type, Node.ConnectionType connectionType = 0, Node.TypeConstraint typeConstraint = 0, string fieldName) { }

	[Obsolete("Use AddDynamicOutput instead")]
	// RVA: 0x89E4B6C Offset: 0x89E0B6C VA: 0x89E4B6C
	public NodePort AddInstanceOutput(Type type, Node.ConnectionType connectionType = 0, Node.TypeConstraint typeConstraint = 0, string fieldName) { }

	[Obsolete("Use AddDynamicPort instead")]
	// RVA: 0x89E4B94 Offset: 0x89E0B94 VA: 0x89E4B94
	private NodePort AddInstancePort(Type type, NodePort.IO direction, Node.ConnectionType connectionType = 0, Node.TypeConstraint typeConstraint = 0, string fieldName) { }

	[Obsolete("Use RemoveDynamicPort instead")]
	// RVA: 0x89E4DB0 Offset: 0x89E0DB0 VA: 0x89E4DB0
	public void RemoveInstancePort(string fieldName) { }

	[Obsolete("Use RemoveDynamicPort instead")]
	// RVA: 0x89E4E58 Offset: 0x89E0E58 VA: 0x89E4E58
	public void RemoveInstancePort(NodePort port) { }

	[Obsolete("Use ClearDynamicPorts instead")]
	// RVA: 0x89E4F44 Offset: 0x89E0F44 VA: 0x89E4F44
	public void ClearInstancePorts() { }

	[IteratorStateMachine(typeof(Node.<get_Ports>d__16))]
	// RVA: 0x89E50D0 Offset: 0x89E10D0 VA: 0x89E50D0
	public IEnumerable<NodePort> get_Ports() { }

	[IteratorStateMachine(typeof(Node.<get_Outputs>d__18))]
	// RVA: 0x89E5180 Offset: 0x89E1180 VA: 0x89E5180
	public IEnumerable<NodePort> get_Outputs() { }

	[IteratorStateMachine(typeof(Node.<get_Inputs>d__20))]
	// RVA: 0x89E5230 Offset: 0x89E1230 VA: 0x89E5230
	public IEnumerable<NodePort> get_Inputs() { }

	[IteratorStateMachine(typeof(Node.<get_DynamicPorts>d__22))]
	// RVA: 0x89E49C8 Offset: 0x89E09C8 VA: 0x89E49C8
	public IEnumerable<NodePort> get_DynamicPorts() { }

	[IteratorStateMachine(typeof(Node.<get_DynamicOutputs>d__24))]
	// RVA: 0x89E4A48 Offset: 0x89E0A48 VA: 0x89E4A48
	public IEnumerable<NodePort> get_DynamicOutputs() { }

	[IteratorStateMachine(typeof(Node.<get_DynamicInputs>d__26))]
	// RVA: 0x89E4AC8 Offset: 0x89E0AC8 VA: 0x89E4AC8
	public IEnumerable<NodePort> get_DynamicInputs() { }

	// RVA: 0x89E537C Offset: 0x89E137C VA: 0x89E537C
	protected void OnEnable() { }

	// RVA: 0x89E5454 Offset: 0x89E1454 VA: 0x89E5454
	public void UpdatePorts() { }

	// RVA: 0x89E5DB8 Offset: 0x89E1DB8 VA: 0x89E5DB8 Slot: 4
	protected virtual void Init() { }

	// RVA: 0x89E5DBC Offset: 0x89E1DBC VA: 0x89E5DBC
	public void VerifyConnections() { }

	// RVA: 0x89E4B58 Offset: 0x89E0B58 VA: 0x89E4B58
	public NodePort AddDynamicInput(Type type, Node.ConnectionType connectionType = 0, Node.TypeConstraint typeConstraint = 0, string fieldName) { }

	// RVA: 0x89E4B80 Offset: 0x89E0B80 VA: 0x89E4B80
	public NodePort AddDynamicOutput(Type type, Node.ConnectionType connectionType = 0, Node.TypeConstraint typeConstraint = 0, string fieldName) { }

	// RVA: 0x89E4B98 Offset: 0x89E0B98 VA: 0x89E4B98
	private NodePort AddDynamicPort(Type type, NodePort.IO direction, Node.ConnectionType connectionType = 0, Node.TypeConstraint typeConstraint = 0, string fieldName) { }

	// RVA: 0x89E4DB4 Offset: 0x89E0DB4 VA: 0x89E4DB4
	public void RemoveDynamicPort(string fieldName) { }

	// RVA: 0x89E4E5C Offset: 0x89E0E5C VA: 0x89E4E5C
	public void RemoveDynamicPort(NodePort port) { }

	[ContextMenu("Clear Dynamic Ports")]
	// RVA: 0x89E4F48 Offset: 0x89E0F48 VA: 0x89E4F48
	public void ClearDynamicPorts() { }

	// RVA: 0x89E6464 Offset: 0x89E2464 VA: 0x89E6464
	public NodePort GetOutputPort(string fieldName) { }

	// RVA: 0x89E6484 Offset: 0x89E2484 VA: 0x89E6484
	public NodePort GetInputPort(string fieldName) { }

	// RVA: 0x89E6350 Offset: 0x89E2350 VA: 0x89E6350
	public NodePort GetPort(string fieldName) { }

	// RVA: 0x89E6200 Offset: 0x89E2200 VA: 0x89E6200
	public bool HasPort(string fieldName) { }

	// RVA: -1 Offset: -1
	public T GetInputValue<T>(string fieldName, T fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x468430C Offset: 0x468030C VA: 0x468430C
	|-Node.GetInputValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetInputValues<T>(string fieldName, T[] fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x468442C Offset: 0x468042C VA: 0x468442C
	|-Node.GetInputValues<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x89E64A4 Offset: 0x89E24A4 VA: 0x89E64A4 Slot: 5
	public virtual object GetValue(NodePort port) { }

	// RVA: 0x89E6558 Offset: 0x89E2558 VA: 0x89E6558 Slot: 6
	public virtual void OnCreateConnection(NodePort from, NodePort to) { }

	// RVA: 0x89E655C Offset: 0x89E255C VA: 0x89E655C Slot: 7
	public virtual void OnRemoveConnection(NodePort port) { }

	// RVA: 0x89E6560 Offset: 0x89E2560 VA: 0x89E6560
	public void ClearConnections() { }

	// RVA: 0x89E6834 Offset: 0x89E2834 VA: 0x89E6834
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
private class NodeDataCache.PortDataCache : Dictionary<Type, List<NodePort>>, ISerializationCallbackReceiver // TypeDefIndex: 28385
{
	// Fields
	[SerializeField]
	private List<Type> keys; // 0x50
	[SerializeField]
	private List<List<NodePort>> values; // 0x58

	// Methods

	// RVA: 0x89EA74C Offset: 0x89E674C VA: 0x89EA74C Slot: 46
	public void OnBeforeSerialize() { }

	// RVA: 0x89EAA24 Offset: 0x89E6A24 VA: 0x89EAA24 Slot: 47
	public void OnAfterDeserialize() { }

	// RVA: 0x89E9B10 Offset: 0x89E5B10 VA: 0x89E9B10
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NodeDataCache.<>c // TypeDefIndex: 28386
{
	// Fields
	public static readonly NodeDataCache.<>c <>9; // 0x0
	public static Func<object, bool> <>9__5_0; // 0x8
	public static Func<object, bool> <>9__8_0; // 0x10
	public static Func<object, bool> <>9__8_1; // 0x18

	// Methods

	// RVA: 0x89EABC0 Offset: 0x89E6BC0 VA: 0x89EABC0
	private static void .cctor() { }

	// RVA: 0x89EAC28 Offset: 0x89E6C28 VA: 0x89EAC28
	public void .ctor() { }

	// RVA: 0x89EAC30 Offset: 0x89E6C30 VA: 0x89EAC30
	internal bool <IsDynamicListPort>b__5_0(object x) { }

	// RVA: 0x89EAD18 Offset: 0x89E6D18 VA: 0x89EAD18
	internal bool <CachePorts>b__8_0(object x) { }

	// RVA: 0x89EAD90 Offset: 0x89E6D90 VA: 0x89EAD90
	internal bool <CachePorts>b__8_1(object x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NodeDataCache.<>c__DisplayClass6_0 // TypeDefIndex: 28387
{
	// Fields
	public Type baseType; // 0x10
	public Func<Type, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x89E9B08 Offset: 0x89E5B08 VA: 0x89E9B08
	public void .ctor() { }

	// RVA: 0x89EAE08 Offset: 0x89E6E08 VA: 0x89EAE08
	internal bool <BuildCache>b__0(Type t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NodeDataCache.<>c__DisplayClass7_0 // TypeDefIndex: 28388
{
	// Fields
	public FieldInfo parentField; // 0x10

	// Methods

	// RVA: 0x89EA4B8 Offset: 0x89E64B8 VA: 0x89EA4B8
	public void .ctor() { }

	// RVA: 0x89EAE64 Offset: 0x89E6E64 VA: 0x89EAE64
	internal bool <GetNodeFields>b__0(FieldInfo x) { }
}

// Namespace: XNode
public static class NodeDataCache // TypeDefIndex: 28389
{
	// Fields
	private static NodeDataCache.PortDataCache portDataCache; // 0x0

	// Properties
	private static bool Initialized { get; }

	// Methods

	// RVA: 0x89E8A2C Offset: 0x89E4A2C VA: 0x89E8A2C
	private static bool get_Initialized() { }

	// RVA: 0x89E545C Offset: 0x89E145C VA: 0x89E545C
	public static void UpdatePorts(Node node, Dictionary<string, NodePort> ports) { }

	// RVA: 0x89E99F0 Offset: 0x89E59F0 VA: 0x89E99F0
	private static Type GetBackingValueType(Type portValType) { }

	// RVA: 0x89E9148 Offset: 0x89E5148 VA: 0x89E9148
	private static bool IsDynamicListPort(NodePort port) { }

	// RVA: 0x89E8A7C Offset: 0x89E4A7C VA: 0x89E8A7C
	private static void BuildCache() { }

	// RVA: 0x89EA200 Offset: 0x89E6200 VA: 0x89EA200
	public static List<FieldInfo> GetNodeFields(Type nodeType) { }

	// RVA: 0x89E9C00 Offset: 0x89E5C00 VA: 0x89E9C00
	private static void CachePorts(Type nodeType) { }
}

// Namespace: XNode
[Serializable]
public abstract class NodeGraph : ScriptableObject // TypeDefIndex: 28390
{
	// Fields
	[SerializeField]
	public List<Node> nodes; // 0x18

	// Methods

	// RVA: -1 Offset: -1
	public T AddNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46844B0 Offset: 0x46804B0 VA: 0x46844B0
	|-NodeGraph.AddNode<object>
	*/

	// RVA: 0x89EAEC0 Offset: 0x89E6EC0 VA: 0x89EAEC0 Slot: 4
	public virtual Node AddNode(Type type) { }

	// RVA: 0x89EAFF8 Offset: 0x89E6FF8 VA: 0x89EAFF8 Slot: 5
	public virtual Node CopyNode(Node original) { }

	// RVA: 0x89EB140 Offset: 0x89E7140 VA: 0x89EB140 Slot: 6
	public virtual void RemoveNode(Node node) { }

	// RVA: 0x89EB210 Offset: 0x89E7210 VA: 0x89EB210 Slot: 7
	public virtual void Clear() { }

	// RVA: 0x89EB344 Offset: 0x89E7344 VA: 0x89EB344 Slot: 8
	public virtual NodeGraph Copy() { }

	// RVA: 0x89EBA4C Offset: 0x89E7A4C VA: 0x89EBA4C Slot: 9
	protected virtual void OnDestroy() { }

	// RVA: 0x89EBA58 Offset: 0x89E7A58 VA: 0x89EBA58
	protected void .ctor() { }
}

// Namespace: 
public enum NodePort.IO // TypeDefIndex: 28391
{
	// Fields
	public int value__; // 0x0
	public const NodePort.IO Input = 0;
	public const NodePort.IO Output = 1;
}

// Namespace: 
[Serializable]
private class NodePort.PortConnection // TypeDefIndex: 28392
{
	// Fields
	[SerializeField]
	public string fieldName; // 0x10
	[SerializeField]
	public Node node; // 0x18
	private NodePort port; // 0x20
	[SerializeField]
	public List<Vector2> reroutePoints; // 0x28

	// Properties
	public NodePort Port { get; }

	// Methods

	// RVA: 0x89EBBD4 Offset: 0x89E7BD4 VA: 0x89EBBD4
	public NodePort get_Port() { }

	// RVA: 0x89EBEF4 Offset: 0x89E7EF4 VA: 0x89EBEF4
	public void .ctor(NodePort port) { }

	// RVA: 0x89EC264 Offset: 0x89E8264 VA: 0x89EC264
	private NodePort GetPort() { }
}

// Namespace: XNode
[Serializable]
public class NodePort // TypeDefIndex: 28393
{
	// Fields
	private Type valueType; // 0x10
	[SerializeField]
	private string _fieldName; // 0x18
	[SerializeField]
	private Node _node; // 0x20
	[SerializeField]
	private string _typeQualifiedName; // 0x28
	[SerializeField]
	private List<NodePort.PortConnection> connections; // 0x30
	[SerializeField]
	private NodePort.IO _direction; // 0x38
	[SerializeField]
	private Node.ConnectionType _connectionType; // 0x3C
	[SerializeField]
	private Node.TypeConstraint _typeConstraint; // 0x40
	[SerializeField]
	private bool _dynamic; // 0x44

	// Properties
	public int ConnectionCount { get; }
	public NodePort Connection { get; }
	public NodePort.IO direction { get; set; }
	public Node.ConnectionType connectionType { get; set; }
	public Node.TypeConstraint typeConstraint { get; set; }
	public bool IsConnected { get; }
	public bool IsInput { get; }
	public bool IsOutput { get; }
	public string fieldName { get; }
	public Node node { get; }
	public bool IsDynamic { get; }
	public bool IsStatic { get; }
	public Type ValueType { get; set; }

	// Methods

	// RVA: 0x89EBAE0 Offset: 0x89E7AE0 VA: 0x89EBAE0
	public int get_ConnectionCount() { }

	// RVA: 0x89EBB28 Offset: 0x89E7B28 VA: 0x89EBB28
	public NodePort get_Connection() { }

	// RVA: 0x89EBC14 Offset: 0x89E7C14 VA: 0x89EBC14
	public NodePort.IO get_direction() { }

	// RVA: 0x89EBC1C Offset: 0x89E7C1C VA: 0x89EBC1C
	internal void set_direction(NodePort.IO value) { }

	// RVA: 0x89EBC24 Offset: 0x89E7C24 VA: 0x89EBC24
	public Node.ConnectionType get_connectionType() { }

	// RVA: 0x89EBC2C Offset: 0x89E7C2C VA: 0x89EBC2C
	internal void set_connectionType(Node.ConnectionType value) { }

	// RVA: 0x89EBC34 Offset: 0x89E7C34 VA: 0x89EBC34
	public Node.TypeConstraint get_typeConstraint() { }

	// RVA: 0x89EBC3C Offset: 0x89E7C3C VA: 0x89EBC3C
	internal void set_typeConstraint(Node.TypeConstraint value) { }

	// RVA: 0x89EBC44 Offset: 0x89E7C44 VA: 0x89EBC44
	public bool get_IsConnected() { }

	// RVA: 0x89E7300 Offset: 0x89E3300 VA: 0x89E7300
	public bool get_IsInput() { }

	// RVA: 0x89E77A8 Offset: 0x89E37A8 VA: 0x89E77A8
	public bool get_IsOutput() { }

	// RVA: 0x89EBC94 Offset: 0x89E7C94 VA: 0x89EBC94
	public string get_fieldName() { }

	// RVA: 0x89EBC9C Offset: 0x89E7C9C VA: 0x89EBC9C
	public Node get_node() { }

	// RVA: 0x89EBCA4 Offset: 0x89E7CA4 VA: 0x89EBCA4
	public bool get_IsDynamic() { }

	// RVA: 0x89E63C8 Offset: 0x89E23C8 VA: 0x89E63C8
	public bool get_IsStatic() { }

	// RVA: 0x89E8FA8 Offset: 0x89E4FA8 VA: 0x89E8FA8
	public Type get_ValueType() { }

	// RVA: 0x89E9090 Offset: 0x89E5090 VA: 0x89E9090
	public void set_ValueType(Type value) { }

	// RVA: 0x89EA4C0 Offset: 0x89E64C0 VA: 0x89EA4C0
	public void .ctor(FieldInfo fieldInfo) { }

	// RVA: 0x89E92F0 Offset: 0x89E52F0 VA: 0x89E92F0
	public void .ctor(NodePort nodePort, Node node) { }

	// RVA: 0x89E6258 Offset: 0x89E2258 VA: 0x89E6258
	public void .ctor(string fieldName, Type type, NodePort.IO direction, Node.ConnectionType connectionType, Node.TypeConstraint typeConstraint, Node node) { }

	// RVA: 0x89E6090 Offset: 0x89E2090 VA: 0x89E6090
	public void VerifyConnections() { }

	// RVA: 0x89EBCAC Offset: 0x89E7CAC VA: 0x89EBCAC
	public object GetOutputValue() { }

	// RVA: 0x89EBCE4 Offset: 0x89E7CE4 VA: 0x89EBCE4
	public object GetInputValue() { }

	// RVA: 0x89EBD00 Offset: 0x89E7D00 VA: 0x89EBD00
	public object[] GetInputValues() { }

	// RVA: -1 Offset: -1
	public T GetInputValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x468459C Offset: 0x468059C VA: 0x468459C
	|-NodePort.GetInputValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetInputValues<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46846E8 Offset: 0x46806E8 VA: 0x46846E8
	|-NodePort.GetInputValues<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x89E9600 Offset: 0x89E5600 VA: 0x89E9600
	public void Connect(NodePort port) { }

	// RVA: 0x89E8E80 Offset: 0x89E4E80 VA: 0x89E8E80
	public List<NodePort> GetConnections() { }

	// RVA: 0x89EBFB8 Offset: 0x89E7FB8 VA: 0x89EBFB8
	public NodePort GetConnection(int i) { }

	// RVA: 0x89EBE50 Offset: 0x89E7E50 VA: 0x89EBE50
	public bool IsConnectedTo(NodePort port) { }

	// RVA: 0x89E93D4 Offset: 0x89E53D4 VA: 0x89E93D4
	public bool CanConnectTo(NodePort port) { }

	// RVA: 0x89EC100 Offset: 0x89E8100 VA: 0x89EC100
	public void Disconnect(NodePort port) { }

	// RVA: 0x89E63D8 Offset: 0x89E23D8 VA: 0x89E63D8
	public void ClearConnections() { }

	// RVA: 0x89EB874 Offset: 0x89E7874 VA: 0x89EB874
	public void Redirect(List<Node> oldNodes, List<Node> newNodes) { }
}

// Namespace: XNode
public class SceneGraph : MonoBehaviour // TypeDefIndex: 28394
{
	// Fields
	public NodeGraph graph; // 0x20

	// Methods

	// RVA: 0x89EC2FC Offset: 0x89E82FC VA: 0x89EC2FC
	public void .ctor() { }
}

// Namespace: XNode
public class SceneGraph<T> : SceneGraph // TypeDefIndex: 28395
{
	// Properties
	public T graph { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4DA4 Offset: 0x54D0DA4 VA: 0x54D4DA4
	|-SceneGraph<object>.get_graph
	*/

	// RVA: -1 Offset: -1
	public void set_graph(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4E30 Offset: 0x54D0E30 VA: 0x54D4E30
	|-SceneGraph<object>.set_graph
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54D4E38 Offset: 0x54D0E38 VA: 0x54D4E38
	|-SceneGraph<object>..ctor
	*/
}

