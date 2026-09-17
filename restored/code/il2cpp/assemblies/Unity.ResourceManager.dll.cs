// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 24953
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 24954
{
	// Methods

	// RVA: 0x86106C4 Offset: 0x860C6C4 VA: 0x86106C4
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 24955
{
	// Methods

	// RVA: 0x86106CC Offset: 0x860C6CC VA: 0x86106CC
	public void .ctor() { }
}

// Namespace: 
internal class DelegateList<T> // TypeDefIndex: 24956
{
	// Fields
	private Func<Action<T>, LinkedListNode<Action<T>>> m_acquireFunc; // 0x0
	private Action<LinkedListNode<Action<T>>> m_releaseFunc; // 0x0
	private LinkedList<Action<T>> m_callbacks; // 0x0
	private bool m_invoking; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<Action<T>, LinkedListNode<Action<T>>> acquireFunc, Action<LinkedListNode<Action<T>>> releaseFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D24E74 Offset: 0x5D20E74 VA: 0x5D24E74
	|-DelegateList<AsyncOperationHandle<bool>>..ctor
	|
	|-RVA: 0x5D3FB24 Offset: 0x5D3BB24 VA: 0x5D3FB24
	|-DelegateList<AsyncOperationHandle<long>>..ctor
	|
	|-RVA: 0x5D40198 Offset: 0x5D3C198 VA: 0x5D40198
	|-DelegateList<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x5D4080C Offset: 0x5D3C80C VA: 0x5D4080C
	|-DelegateList<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x5D40E80 Offset: 0x5D3CE80 VA: 0x5D40E80
	|-DelegateList<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x5D414F4 Offset: 0x5D3D4F4 VA: 0x5D414F4
	|-DelegateList<DiagnosticEvent>..ctor
	|
	|-RVA: 0x5D41B68 Offset: 0x5D3DB68 VA: 0x5D41B68
	|-DelegateList<float>..ctor
	|
	|-RVA: 0x5D421C4 Offset: 0x5D3E1C4 VA: 0x5D421C4
	|-DelegateList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D24F28 Offset: 0x5D20F28 VA: 0x5D24F28
	|-DelegateList<AsyncOperationHandle<bool>>.get_Count
	|
	|-RVA: 0x5D3FBD8 Offset: 0x5D3BBD8 VA: 0x5D3FBD8
	|-DelegateList<AsyncOperationHandle<long>>.get_Count
	|
	|-RVA: 0x5D4024C Offset: 0x5D3C24C VA: 0x5D4024C
	|-DelegateList<AsyncOperationHandle<object>>.get_Count
	|
	|-RVA: 0x5D408C0 Offset: 0x5D3C8C0 VA: 0x5D408C0
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.get_Count
	|
	|-RVA: 0x5D40F34 Offset: 0x5D3CF34 VA: 0x5D40F34
	|-DelegateList<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x5D415A8 Offset: 0x5D3D5A8 VA: 0x5D415A8
	|-DelegateList<DiagnosticEvent>.get_Count
	|
	|-RVA: 0x5D41C1C Offset: 0x5D3DC1C VA: 0x5D41C1C
	|-DelegateList<float>.get_Count
	|
	|-RVA: 0x5D42278 Offset: 0x5D3E278 VA: 0x5D42278
	|-DelegateList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D24F40 Offset: 0x5D20F40 VA: 0x5D24F40
	|-DelegateList<AsyncOperationHandle<bool>>.Add
	|
	|-RVA: 0x5D3FBF0 Offset: 0x5D3BBF0 VA: 0x5D3FBF0
	|-DelegateList<AsyncOperationHandle<long>>.Add
	|
	|-RVA: 0x5D40264 Offset: 0x5D3C264 VA: 0x5D40264
	|-DelegateList<AsyncOperationHandle<object>>.Add
	|
	|-RVA: 0x5D408D8 Offset: 0x5D3C8D8 VA: 0x5D408D8
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Add
	|
	|-RVA: 0x5D40F4C Offset: 0x5D3CF4C VA: 0x5D40F4C
	|-DelegateList<AsyncOperationHandle>.Add
	|
	|-RVA: 0x5D415C0 Offset: 0x5D3D5C0 VA: 0x5D415C0
	|-DelegateList<DiagnosticEvent>.Add
	|
	|-RVA: 0x5D41C34 Offset: 0x5D3DC34 VA: 0x5D41C34
	|-DelegateList<float>.Add
	|
	|-RVA: 0x5D42298 Offset: 0x5D3E298 VA: 0x5D42298
	|-DelegateList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D24FE8 Offset: 0x5D20FE8 VA: 0x5D24FE8
	|-DelegateList<AsyncOperationHandle<bool>>.Remove
	|
	|-RVA: 0x5D3FC98 Offset: 0x5D3BC98 VA: 0x5D3FC98
	|-DelegateList<AsyncOperationHandle<long>>.Remove
	|
	|-RVA: 0x5D4030C Offset: 0x5D3C30C VA: 0x5D4030C
	|-DelegateList<AsyncOperationHandle<object>>.Remove
	|
	|-RVA: 0x5D40980 Offset: 0x5D3C980 VA: 0x5D40980
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Remove
	|
	|-RVA: 0x5D40FF4 Offset: 0x5D3CFF4 VA: 0x5D40FF4
	|-DelegateList<AsyncOperationHandle>.Remove
	|
	|-RVA: 0x5D41668 Offset: 0x5D3D668 VA: 0x5D41668
	|-DelegateList<DiagnosticEvent>.Remove
	|
	|-RVA: 0x5D41CDC Offset: 0x5D3DCDC VA: 0x5D41CDC
	|-DelegateList<float>.Remove
	|
	|-RVA: 0x5D42368 Offset: 0x5D3E368 VA: 0x5D42368
	|-DelegateList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T res) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D250C0 Offset: 0x5D210C0 VA: 0x5D250C0
	|-DelegateList<AsyncOperationHandle<bool>>.Invoke
	|
	|-RVA: 0x5D3FD70 Offset: 0x5D3BD70 VA: 0x5D3FD70
	|-DelegateList<AsyncOperationHandle<long>>.Invoke
	|
	|-RVA: 0x5D403E4 Offset: 0x5D3C3E4 VA: 0x5D403E4
	|-DelegateList<AsyncOperationHandle<object>>.Invoke
	|
	|-RVA: 0x5D40A58 Offset: 0x5D3CA58 VA: 0x5D40A58
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Invoke
	|
	|-RVA: 0x5D410CC Offset: 0x5D3D0CC VA: 0x5D410CC
	|-DelegateList<AsyncOperationHandle>.Invoke
	|
	|-RVA: 0x5D41740 Offset: 0x5D3D740 VA: 0x5D41740
	|-DelegateList<DiagnosticEvent>.Invoke
	|
	|-RVA: 0x5D41DB4 Offset: 0x5D3DDB4 VA: 0x5D41DB4
	|-DelegateList<float>.Invoke
	|
	|-RVA: 0x5D4248C Offset: 0x5D3E48C VA: 0x5D4248C
	|-DelegateList<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25284 Offset: 0x5D21284 VA: 0x5D25284
	|-DelegateList<AsyncOperationHandle<bool>>.Clear
	|
	|-RVA: 0x5D3FF34 Offset: 0x5D3BF34 VA: 0x5D3FF34
	|-DelegateList<AsyncOperationHandle<long>>.Clear
	|
	|-RVA: 0x5D405A8 Offset: 0x5D3C5A8 VA: 0x5D405A8
	|-DelegateList<AsyncOperationHandle<object>>.Clear
	|
	|-RVA: 0x5D40C1C Offset: 0x5D3CC1C VA: 0x5D40C1C
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Clear
	|
	|-RVA: 0x5D41290 Offset: 0x5D3D290 VA: 0x5D41290
	|-DelegateList<AsyncOperationHandle>.Clear
	|
	|-RVA: 0x5D41904 Offset: 0x5D3D904 VA: 0x5D41904
	|-DelegateList<DiagnosticEvent>.Clear
	|
	|-RVA: 0x5D41F60 Offset: 0x5D3DF60 VA: 0x5D41F60
	|-DelegateList<float>.Clear
	|
	|-RVA: 0x5D4278C Offset: 0x5D3E78C VA: 0x5D4278C
	|-DelegateList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public static DelegateList<T> CreateWithGlobalCache() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25318 Offset: 0x5D21318 VA: 0x5D25318
	|-DelegateList<AsyncOperationHandle<bool>>.CreateWithGlobalCache
	|
	|-RVA: 0x5D3FFC8 Offset: 0x5D3BFC8 VA: 0x5D3FFC8
	|-DelegateList<AsyncOperationHandle<long>>.CreateWithGlobalCache
	|
	|-RVA: 0x5D4063C Offset: 0x5D3C63C VA: 0x5D4063C
	|-DelegateList<AsyncOperationHandle<object>>.CreateWithGlobalCache
	|
	|-RVA: 0x5D40CB0 Offset: 0x5D3CCB0 VA: 0x5D40CB0
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.CreateWithGlobalCache
	|
	|-RVA: 0x5D41324 Offset: 0x5D3D324 VA: 0x5D41324
	|-DelegateList<AsyncOperationHandle>.CreateWithGlobalCache
	|
	|-RVA: 0x5D41998 Offset: 0x5D3D998 VA: 0x5D41998
	|-DelegateList<DiagnosticEvent>.CreateWithGlobalCache
	|
	|-RVA: 0x5D41FF4 Offset: 0x5D3DFF4 VA: 0x5D41FF4
	|-DelegateList<float>.CreateWithGlobalCache
	|
	|-RVA: 0x5D4284C Offset: 0x5D3E84C VA: 0x5D4284C
	|-DelegateList<__Il2CppFullySharedGenericType>.CreateWithGlobalCache
	*/
}

// Namespace: 
[DefaultMember("Item")]
internal class ListWithEvents<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 24957
{
	// Fields
	private List<T> m_List; // 0x0
	[CompilerGenerated]
	private Action<T> OnElementAdded; // 0x0
	[CompilerGenerated]
	private Action<T> OnElementRemoved; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_OnElementAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6B9E8 Offset: 0x4B679E8 VA: 0x4B6B9E8
	|-ListWithEvents<object>.add_OnElementAdded
	|
	|-RVA: 0x4B6C374 Offset: 0x4B68374 VA: 0x4B6C374
	|-ListWithEvents<__Il2CppFullySharedGenericType>.add_OnElementAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_OnElementAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BA94 Offset: 0x4B67A94 VA: 0x4B6BA94
	|-ListWithEvents<object>.remove_OnElementAdded
	|
	|-RVA: 0x4B6C420 Offset: 0x4B68420 VA: 0x4B6C420
	|-ListWithEvents<__Il2CppFullySharedGenericType>.remove_OnElementAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_OnElementRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BB40 Offset: 0x4B67B40 VA: 0x4B6BB40
	|-ListWithEvents<object>.add_OnElementRemoved
	|
	|-RVA: 0x4B6C4CC Offset: 0x4B684CC VA: 0x4B6C4CC
	|-ListWithEvents<__Il2CppFullySharedGenericType>.add_OnElementRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_OnElementRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BBEC Offset: 0x4B67BEC VA: 0x4B6BBEC
	|-ListWithEvents<object>.remove_OnElementRemoved
	|
	|-RVA: 0x4B6C578 Offset: 0x4B68578 VA: 0x4B6C578
	|-ListWithEvents<__Il2CppFullySharedGenericType>.remove_OnElementRemoved
	*/

	// RVA: -1 Offset: -1
	private void InvokeAdded(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BC98 Offset: 0x4B67C98 VA: 0x4B6BC98
	|-ListWithEvents<object>.InvokeAdded
	|
	|-RVA: 0x4B6C624 Offset: 0x4B68624 VA: 0x4B6C624
	|-ListWithEvents<__Il2CppFullySharedGenericType>.InvokeAdded
	*/

	// RVA: -1 Offset: -1
	private void InvokeRemoved(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BCB4 Offset: 0x4B67CB4 VA: 0x4B6BCB4
	|-ListWithEvents<object>.InvokeRemoved
	|
	|-RVA: 0x4B6C6E4 Offset: 0x4B686E4 VA: 0x4B6C6E4
	|-ListWithEvents<__Il2CppFullySharedGenericType>.InvokeRemoved
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BCD0 Offset: 0x4B67CD0 VA: 0x4B6BCD0
	|-ListWithEvents<object>.get_Item
	|
	|-RVA: 0x4B6C7A4 Offset: 0x4B687A4 VA: 0x4B6C7A4
	|-ListWithEvents<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BCF4 Offset: 0x4B67CF4 VA: 0x4B6BCF4
	|-ListWithEvents<object>.set_Item
	|
	|-RVA: 0x4B6C858 Offset: 0x4B68858 VA: 0x4B6C858
	|-ListWithEvents<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BDA8 Offset: 0x4B67DA8 VA: 0x4B6BDA8
	|-ListWithEvents<object>.get_Count
	|
	|-RVA: 0x4B6CA9C Offset: 0x4B68A9C VA: 0x4B6CA9C
	|-ListWithEvents<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BDC4 Offset: 0x4B67DC4 VA: 0x4B6BDC4
	|-ListWithEvents<object>.get_IsReadOnly
	|
	|-RVA: 0x4B6CAC4 Offset: 0x4B68AC4 VA: 0x4B6CAC4
	|-ListWithEvents<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BE50 Offset: 0x4B67E50 VA: 0x4B6BE50
	|-ListWithEvents<object>.Add
	|
	|-RVA: 0x4B6CB50 Offset: 0x4B68B50 VA: 0x4B6CB50
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6BF00 Offset: 0x4B67F00 VA: 0x4B6BF00
	|-ListWithEvents<object>.Clear
	|
	|-RVA: 0x4B6CCA8 Offset: 0x4B68CA8 VA: 0x4B6CCA8
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6C048 Offset: 0x4B68048 VA: 0x4B6C048
	|-ListWithEvents<object>.Contains
	|
	|-RVA: 0x4B6CF8C Offset: 0x4B68F8C VA: 0x4B6CF8C
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6C06C Offset: 0x4B6806C VA: 0x4B6C06C
	|-ListWithEvents<object>.CopyTo
	|
	|-RVA: 0x4B6D060 Offset: 0x4B69060 VA: 0x4B6D060
	|-ListWithEvents<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6C090 Offset: 0x4B68090 VA: 0x4B6C090
	|-ListWithEvents<object>.GetEnumerator
	|
	|-RVA: 0x4B6D088 Offset: 0x4B69088 VA: 0x4B6D088
	|-ListWithEvents<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6C0F4 Offset: 0x4B680F4 VA: 0x4B6C0F4
	|-ListWithEvents<object>.IndexOf
	|
	|-RVA: 0x4B6D134 Offset: 0x4B69134 VA: 0x4B6D134
	|-ListWithEvents<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6C118 Offset: 0x4B68118 VA: 0x4B6C118
	|-ListWithEvents<object>.Insert
	|
	|-RVA: 0x4B6D200 Offset: 0x4B69200 VA: 0x4B6D200
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6C174 Offset: 0x4B68174 VA: 0x4B6C174
	|-ListWithEvents<object>.Remove
	|
	|-RVA: 0x4B6D364 Offset: 0x4B69364 VA: 0x4B6D364
	|-ListWithEvents<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6C1D4 Offset: 0x4B681D4 VA: 0x4B6C1D4
	|-ListWithEvents<object>.RemoveAt
	|
	|-RVA: 0x4B6D4BC Offset: 0x4B694BC VA: 0x4B6D4BC
	|-ListWithEvents<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6C264 Offset: 0x4B68264 VA: 0x4B6C264
	|-ListWithEvents<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4B6D61C Offset: 0x4B6961C VA: 0x4B6D61C
	|-ListWithEvents<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B6C304 Offset: 0x4B68304 VA: 0x4B6C304
	|-ListWithEvents<object>..ctor
	|
	|-RVA: 0x4B6D6BC Offset: 0x4B696BC VA: 0x4B6D6BC
	|-ListWithEvents<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
internal class MonoBehaviourCallbackHooks : ComponentSingleton<MonoBehaviourCallbackHooks> // TypeDefIndex: 24958
{
	// Fields
	internal Action<float> m_OnUpdateDelegate; // 0x20
	internal Action<float> m_OnLateUpdateDelegate; // 0x28

	// Methods

	// RVA: 0x86106D4 Offset: 0x860C6D4 VA: 0x86106D4
	public void add_OnUpdateDelegate(Action<float> value) { }

	// RVA: 0x861077C Offset: 0x860C77C VA: 0x861077C
	public void remove_OnUpdateDelegate(Action<float> value) { }

	// RVA: 0x8610824 Offset: 0x860C824 VA: 0x8610824
	internal void add_OnLateUpdateDelegate(Action<float> value) { }

	// RVA: 0x86108CC Offset: 0x860C8CC VA: 0x86108CC
	internal void remove_OnLateUpdateDelegate(Action<float> value) { }

	// RVA: 0x8610974 Offset: 0x860C974 VA: 0x8610974 Slot: 4
	protected override string GetGameObjectName() { }

	// RVA: 0x86109B4 Offset: 0x860C9B4 VA: 0x86109B4
	internal void Update() { }

	// RVA: 0x86109E4 Offset: 0x860C9E4 VA: 0x86109E4
	internal void LateUpdate() { }

	// RVA: 0x8610A14 Offset: 0x860CA14 VA: 0x8610A14
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 24959
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 24960
{
	// Methods

	// RVA: 0x8610A5C Offset: 0x860CA5C VA: 0x8610A5C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x8610B54 Offset: 0x860CB54 VA: 0x8610B54
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement
internal class ChainOperation<TObject, TObjectDependency> : AsyncOperationBase<TObject> // TypeDefIndex: 24961
{
	// Fields
	private AsyncOperationHandle<TObjectDependency> m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private DownloadStatus m_depStatus; // 0x0
	private DownloadStatus m_wrapStatus; // 0x0
	private Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> m_Callback; // 0x0
	private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BAC3A8 Offset: 0x5BA83A8 VA: 0x5BAC3A8
	|-ChainOperation<long, object>..ctor
	|
	|-RVA: 0x5BACE4C Offset: 0x5BA8E4C VA: 0x5BACE4C
	|-ChainOperation<object, object>..ctor
	|
	|-RVA: 0x5BAD8F0 Offset: 0x5BA98F0 VA: 0x5BAD8F0
	|-ChainOperation<SceneInstance, SceneInstance>..ctor
	|
	|-RVA: 0x5BAE3A0 Offset: 0x5BAA3A0 VA: 0x5BAE3A0
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BAC420 Offset: 0x5BA8420 VA: 0x5BAC420
	|-ChainOperation<long, object>.get_DebugName
	|
	|-RVA: 0x5BACEC4 Offset: 0x5BA8EC4 VA: 0x5BACEC4
	|-ChainOperation<object, object>.get_DebugName
	|
	|-RVA: 0x5BAD968 Offset: 0x5BA9968 VA: 0x5BAD968
	|-ChainOperation<SceneInstance, SceneInstance>.get_DebugName
	|
	|-RVA: 0x5BAE448 Offset: 0x5BAA448 VA: 0x5BAE448
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BAC608 Offset: 0x5BA8608 VA: 0x5BAC608
	|-ChainOperation<long, object>.GetDependencies
	|
	|-RVA: 0x5BAD0AC Offset: 0x5BA90AC VA: 0x5BAD0AC
	|-ChainOperation<object, object>.GetDependencies
	|
	|-RVA: 0x5BADB50 Offset: 0x5BA9B50 VA: 0x5BADB50
	|-ChainOperation<SceneInstance, SceneInstance>.GetDependencies
	|
	|-RVA: 0x5BAE64C Offset: 0x5BAA64C VA: 0x5BAE64C
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BAC754 Offset: 0x5BA8754 VA: 0x5BAC754
	|-ChainOperation<long, object>.Init
	|
	|-RVA: 0x5BAD1F8 Offset: 0x5BA91F8 VA: 0x5BAD1F8
	|-ChainOperation<object, object>.Init
	|
	|-RVA: 0x5BADC9C Offset: 0x5BA9C9C VA: 0x5BADC9C
	|-ChainOperation<SceneInstance, SceneInstance>.Init
	|
	|-RVA: 0x5BAE7D8 Offset: 0x5BAA7D8 VA: 0x5BAE7D8
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BAC7EC Offset: 0x5BA87EC VA: 0x5BAC7EC
	|-ChainOperation<long, object>.InvokeWaitForCompletion
	|
	|-RVA: 0x5BAD290 Offset: 0x5BA9290 VA: 0x5BAD290
	|-ChainOperation<object, object>.InvokeWaitForCompletion
	|
	|-RVA: 0x5BADD34 Offset: 0x5BA9D34 VA: 0x5BADD34
	|-ChainOperation<SceneInstance, SceneInstance>.InvokeWaitForCompletion
	|
	|-RVA: 0x5BAE8CC Offset: 0x5BAA8CC VA: 0x5BAE8CC
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BAC8DC Offset: 0x5BA88DC VA: 0x5BAC8DC
	|-ChainOperation<long, object>.Execute
	|
	|-RVA: 0x5BAD380 Offset: 0x5BA9380 VA: 0x5BAD380
	|-ChainOperation<object, object>.Execute
	|
	|-RVA: 0x5BADE24 Offset: 0x5BA9E24 VA: 0x5BADE24
	|-ChainOperation<SceneInstance, SceneInstance>.Execute
	|
	|-RVA: 0x5BAEB28 Offset: 0x5BAAB28 VA: 0x5BAEB28
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BAC9A0 Offset: 0x5BA89A0 VA: 0x5BAC9A0
	|-ChainOperation<long, object>.OnWrappedCompleted
	|
	|-RVA: 0x5BAD444 Offset: 0x5BA9444 VA: 0x5BAD444
	|-ChainOperation<object, object>.OnWrappedCompleted
	|
	|-RVA: 0x5BADEE8 Offset: 0x5BA9EE8 VA: 0x5BADEE8
	|-ChainOperation<SceneInstance, SceneInstance>.OnWrappedCompleted
	|
	|-RVA: 0x5BAEC84 Offset: 0x5BAAC84 VA: 0x5BAEC84
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BACAB8 Offset: 0x5BA8AB8 VA: 0x5BACAB8
	|-ChainOperation<long, object>.Destroy
	|
	|-RVA: 0x5BAD55C Offset: 0x5BA955C VA: 0x5BAD55C
	|-ChainOperation<object, object>.Destroy
	|
	|-RVA: 0x5BAE00C Offset: 0x5BAA00C VA: 0x5BAE00C
	|-ChainOperation<SceneInstance, SceneInstance>.Destroy
	|
	|-RVA: 0x5BAEE80 Offset: 0x5BAAE80 VA: 0x5BAEE80
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BACB3C Offset: 0x5BA8B3C VA: 0x5BACB3C
	|-ChainOperation<long, object>.ReleaseDependencies
	|
	|-RVA: 0x5BAD5E0 Offset: 0x5BA95E0 VA: 0x5BAD5E0
	|-ChainOperation<object, object>.ReleaseDependencies
	|
	|-RVA: 0x5BAE090 Offset: 0x5BAA090 VA: 0x5BAE090
	|-ChainOperation<SceneInstance, SceneInstance>.ReleaseDependencies
	|
	|-RVA: 0x5BAEF84 Offset: 0x5BAAF84 VA: 0x5BAEF84
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BACB8C Offset: 0x5BA8B8C VA: 0x5BACB8C
	|-ChainOperation<long, object>.GetDownloadStatus
	|
	|-RVA: 0x5BAD630 Offset: 0x5BA9630 VA: 0x5BAD630
	|-ChainOperation<object, object>.GetDownloadStatus
	|
	|-RVA: 0x5BAE0E0 Offset: 0x5BAA0E0 VA: 0x5BAE0E0
	|-ChainOperation<SceneInstance, SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0x5BAF01C Offset: 0x5BAB01C VA: 0x5BAF01C
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	private void RefreshDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BACC00 Offset: 0x5BA8C00 VA: 0x5BACC00
	|-ChainOperation<long, object>.RefreshDownloadStatus
	|
	|-RVA: 0x5BAD6A4 Offset: 0x5BA96A4 VA: 0x5BAD6A4
	|-ChainOperation<object, object>.RefreshDownloadStatus
	|
	|-RVA: 0x5BAE154 Offset: 0x5BAA154 VA: 0x5BAE154
	|-ChainOperation<SceneInstance, SceneInstance>.RefreshDownloadStatus
	|
	|-RVA: 0x5BAF12C Offset: 0x5BAB12C VA: 0x5BAF12C
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RefreshDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BACD0C Offset: 0x5BA8D0C VA: 0x5BACD0C
	|-ChainOperation<long, object>.get_Progress
	|
	|-RVA: 0x5BAD7B0 Offset: 0x5BA97B0 VA: 0x5BAD7B0
	|-ChainOperation<object, object>.get_Progress
	|
	|-RVA: 0x5BAE260 Offset: 0x5BAA260 VA: 0x5BAE260
	|-ChainOperation<SceneInstance, SceneInstance>.get_Progress
	|
	|-RVA: 0x5BAF310 Offset: 0x5BAB310 VA: 0x5BAF310
	|-ChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Progress
	*/
}

// Namespace: UnityEngine.ResourceManagement
internal class ChainOperationTypelessDepedency<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 24962
{
	// Fields
	private AsyncOperationHandle m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private DownloadStatus m_depStatus; // 0x0
	private DownloadStatus m_wrapStatus; // 0x0
	private Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> m_Callback; // 0x0
	private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	internal AsyncOperationHandle<TObject> WrappedOp { get; }
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> get_WrappedOp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA9068 Offset: 0x5BA5068 VA: 0x5BA9068
	|-ChainOperationTypelessDepedency<bool>.get_WrappedOp
	|
	|-RVA: 0x5BA9968 Offset: 0x5BA5968 VA: 0x5BA9968
	|-ChainOperationTypelessDepedency<long>.get_WrappedOp
	|
	|-RVA: 0x5BAA264 Offset: 0x5BA6264 VA: 0x5BAA264
	|-ChainOperationTypelessDepedency<object>.get_WrappedOp
	|
	|-RVA: 0x5BAAB6C Offset: 0x5BA6B6C VA: 0x5BAAB6C
	|-ChainOperationTypelessDepedency<SceneInstance>.get_WrappedOp
	|
	|-RVA: 0x5BAB484 Offset: 0x5BA7484 VA: 0x5BAB484
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.get_WrappedOp
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA907C Offset: 0x5BA507C VA: 0x5BA907C
	|-ChainOperationTypelessDepedency<bool>..ctor
	|
	|-RVA: 0x5BA997C Offset: 0x5BA597C VA: 0x5BA997C
	|-ChainOperationTypelessDepedency<long>..ctor
	|
	|-RVA: 0x5BAA278 Offset: 0x5BA6278 VA: 0x5BAA278
	|-ChainOperationTypelessDepedency<object>..ctor
	|
	|-RVA: 0x5BAAB80 Offset: 0x5BA6B80 VA: 0x5BAAB80
	|-ChainOperationTypelessDepedency<SceneInstance>..ctor
	|
	|-RVA: 0x5BAB4BC Offset: 0x5BA74BC VA: 0x5BAB4BC
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA90F4 Offset: 0x5BA50F4 VA: 0x5BA90F4
	|-ChainOperationTypelessDepedency<bool>.get_DebugName
	|
	|-RVA: 0x5BA99F4 Offset: 0x5BA59F4 VA: 0x5BA99F4
	|-ChainOperationTypelessDepedency<long>.get_DebugName
	|
	|-RVA: 0x5BAA2F0 Offset: 0x5BA62F0 VA: 0x5BAA2F0
	|-ChainOperationTypelessDepedency<object>.get_DebugName
	|
	|-RVA: 0x5BAABF8 Offset: 0x5BA6BF8 VA: 0x5BAABF8
	|-ChainOperationTypelessDepedency<SceneInstance>.get_DebugName
	|
	|-RVA: 0x5BAB564 Offset: 0x5BA7564 VA: 0x5BAB564
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA91D0 Offset: 0x5BA51D0 VA: 0x5BA91D0
	|-ChainOperationTypelessDepedency<bool>.GetDependencies
	|
	|-RVA: 0x5BA9AD0 Offset: 0x5BA5AD0 VA: 0x5BA9AD0
	|-ChainOperationTypelessDepedency<long>.GetDependencies
	|
	|-RVA: 0x5BAA3CC Offset: 0x5BA63CC VA: 0x5BAA3CC
	|-ChainOperationTypelessDepedency<object>.GetDependencies
	|
	|-RVA: 0x5BAACD4 Offset: 0x5BA6CD4 VA: 0x5BAACD4
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDependencies
	|
	|-RVA: 0x5BAB654 Offset: 0x5BA7654 VA: 0x5BAB654
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA92D8 Offset: 0x5BA52D8 VA: 0x5BA92D8
	|-ChainOperationTypelessDepedency<bool>.Init
	|
	|-RVA: 0x5BA9BD8 Offset: 0x5BA5BD8 VA: 0x5BA9BD8
	|-ChainOperationTypelessDepedency<long>.Init
	|
	|-RVA: 0x5BAA4D4 Offset: 0x5BA64D4 VA: 0x5BAA4D4
	|-ChainOperationTypelessDepedency<object>.Init
	|
	|-RVA: 0x5BAADDC Offset: 0x5BA6DDC VA: 0x5BAADDC
	|-ChainOperationTypelessDepedency<SceneInstance>.Init
	|
	|-RVA: 0x5BAB790 Offset: 0x5BA7790 VA: 0x5BAB790
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA9368 Offset: 0x5BA5368 VA: 0x5BA9368
	|-ChainOperationTypelessDepedency<bool>.InvokeWaitForCompletion
	|
	|-RVA: 0x5BA9C68 Offset: 0x5BA5C68 VA: 0x5BA9C68
	|-ChainOperationTypelessDepedency<long>.InvokeWaitForCompletion
	|
	|-RVA: 0x5BAA564 Offset: 0x5BA6564 VA: 0x5BAA564
	|-ChainOperationTypelessDepedency<object>.InvokeWaitForCompletion
	|
	|-RVA: 0x5BAAE6C Offset: 0x5BA6E6C VA: 0x5BAAE6C
	|-ChainOperationTypelessDepedency<SceneInstance>.InvokeWaitForCompletion
	|
	|-RVA: 0x5BAB874 Offset: 0x5BA7874 VA: 0x5BAB874
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA9448 Offset: 0x5BA5448 VA: 0x5BA9448
	|-ChainOperationTypelessDepedency<bool>.Execute
	|
	|-RVA: 0x5BA9D44 Offset: 0x5BA5D44 VA: 0x5BA9D44
	|-ChainOperationTypelessDepedency<long>.Execute
	|
	|-RVA: 0x5BAA64C Offset: 0x5BA664C VA: 0x5BAA64C
	|-ChainOperationTypelessDepedency<object>.Execute
	|
	|-RVA: 0x5BAAF58 Offset: 0x5BA6F58 VA: 0x5BAAF58
	|-ChainOperationTypelessDepedency<SceneInstance>.Execute
	|
	|-RVA: 0x5BABAB8 Offset: 0x5BA7AB8 VA: 0x5BABAB8
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA950C Offset: 0x5BA550C VA: 0x5BA950C
	|-ChainOperationTypelessDepedency<bool>.OnWrappedCompleted
	|
	|-RVA: 0x5BA9E08 Offset: 0x5BA5E08 VA: 0x5BA9E08
	|-ChainOperationTypelessDepedency<long>.OnWrappedCompleted
	|
	|-RVA: 0x5BAA710 Offset: 0x5BA6710 VA: 0x5BAA710
	|-ChainOperationTypelessDepedency<object>.OnWrappedCompleted
	|
	|-RVA: 0x5BAB01C Offset: 0x5BA701C VA: 0x5BAB01C
	|-ChainOperationTypelessDepedency<SceneInstance>.OnWrappedCompleted
	|
	|-RVA: 0x5BABC14 Offset: 0x5BA7C14 VA: 0x5BABC14
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA9624 Offset: 0x5BA5624 VA: 0x5BA9624
	|-ChainOperationTypelessDepedency<bool>.Destroy
	|
	|-RVA: 0x5BA9F20 Offset: 0x5BA5F20 VA: 0x5BA9F20
	|-ChainOperationTypelessDepedency<long>.Destroy
	|
	|-RVA: 0x5BAA828 Offset: 0x5BA6828 VA: 0x5BAA828
	|-ChainOperationTypelessDepedency<object>.Destroy
	|
	|-RVA: 0x5BAB140 Offset: 0x5BA7140 VA: 0x5BAB140
	|-ChainOperationTypelessDepedency<SceneInstance>.Destroy
	|
	|-RVA: 0x5BABE10 Offset: 0x5BA7E10 VA: 0x5BABE10
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA9698 Offset: 0x5BA5698 VA: 0x5BA9698
	|-ChainOperationTypelessDepedency<bool>.ReleaseDependencies
	|
	|-RVA: 0x5BA9F94 Offset: 0x5BA5F94 VA: 0x5BA9F94
	|-ChainOperationTypelessDepedency<long>.ReleaseDependencies
	|
	|-RVA: 0x5BAA89C Offset: 0x5BA689C VA: 0x5BAA89C
	|-ChainOperationTypelessDepedency<object>.ReleaseDependencies
	|
	|-RVA: 0x5BAB1B4 Offset: 0x5BA71B4 VA: 0x5BAB1B4
	|-ChainOperationTypelessDepedency<SceneInstance>.ReleaseDependencies
	|
	|-RVA: 0x5BABEE0 Offset: 0x5BA7EE0 VA: 0x5BABEE0
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA96C8 Offset: 0x5BA56C8 VA: 0x5BA96C8
	|-ChainOperationTypelessDepedency<bool>.GetDownloadStatus
	|
	|-RVA: 0x5BA9FC4 Offset: 0x5BA5FC4 VA: 0x5BA9FC4
	|-ChainOperationTypelessDepedency<long>.GetDownloadStatus
	|
	|-RVA: 0x5BAA8CC Offset: 0x5BA68CC VA: 0x5BAA8CC
	|-ChainOperationTypelessDepedency<object>.GetDownloadStatus
	|
	|-RVA: 0x5BAB1E4 Offset: 0x5BA71E4 VA: 0x5BAB1E4
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0x5BABF44 Offset: 0x5BA7F44 VA: 0x5BABF44
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	private void RefreshDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA973C Offset: 0x5BA573C VA: 0x5BA973C
	|-ChainOperationTypelessDepedency<bool>.RefreshDownloadStatus
	|
	|-RVA: 0x5BAA038 Offset: 0x5BA6038 VA: 0x5BAA038
	|-ChainOperationTypelessDepedency<long>.RefreshDownloadStatus
	|
	|-RVA: 0x5BAA940 Offset: 0x5BA6940 VA: 0x5BAA940
	|-ChainOperationTypelessDepedency<object>.RefreshDownloadStatus
	|
	|-RVA: 0x5BAB258 Offset: 0x5BA7258 VA: 0x5BAB258
	|-ChainOperationTypelessDepedency<SceneInstance>.RefreshDownloadStatus
	|
	|-RVA: 0x5BAC054 Offset: 0x5BA8054 VA: 0x5BAC054
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.RefreshDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BA9838 Offset: 0x5BA5838 VA: 0x5BA9838
	|-ChainOperationTypelessDepedency<bool>.get_Progress
	|
	|-RVA: 0x5BAA134 Offset: 0x5BA6134 VA: 0x5BAA134
	|-ChainOperationTypelessDepedency<long>.get_Progress
	|
	|-RVA: 0x5BAAA3C Offset: 0x5BA6A3C VA: 0x5BAAA3C
	|-ChainOperationTypelessDepedency<object>.get_Progress
	|
	|-RVA: 0x5BAB354 Offset: 0x5BA7354 VA: 0x5BAB354
	|-ChainOperationTypelessDepedency<SceneInstance>.get_Progress
	|
	|-RVA: 0x5BAC218 Offset: 0x5BA8218 VA: 0x5BAC218
	|-ChainOperationTypelessDepedency<__Il2CppFullySharedGenericType>.get_Progress
	*/
}

// Namespace: 
public enum ResourceManager.DiagnosticEventType // TypeDefIndex: 24963
{
	// Fields
	public int value__; // 0x0
	public const ResourceManager.DiagnosticEventType AsyncOperationFail = 0;
	public const ResourceManager.DiagnosticEventType AsyncOperationCreate = 1;
	public const ResourceManager.DiagnosticEventType AsyncOperationPercentComplete = 2;
	public const ResourceManager.DiagnosticEventType AsyncOperationComplete = 3;
	public const ResourceManager.DiagnosticEventType AsyncOperationReferenceCount = 4;
	public const ResourceManager.DiagnosticEventType AsyncOperationDestroy = 5;
}

// Namespace: 
public struct ResourceManager.DiagnosticEventContext // TypeDefIndex: 24964
{
	// Fields
	[CompilerGenerated]
	private readonly AsyncOperationHandle <OperationHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ResourceManager.DiagnosticEventType <Type>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <EventValue>k__BackingField; // 0x1C
	[CompilerGenerated]
	private readonly IResourceLocation <Location>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly object <Context>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Error>k__BackingField; // 0x30

	// Properties
	public AsyncOperationHandle OperationHandle { get; }
	public ResourceManager.DiagnosticEventType Type { get; }
	public int EventValue { get; }
	public IResourceLocation Location { get; }
	public object Context { get; }
	public string Error { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x8615A84 Offset: 0x8611A84 VA: 0x8615A84
	public AsyncOperationHandle get_OperationHandle() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8615A98 Offset: 0x8611A98 VA: 0x8615A98
	public ResourceManager.DiagnosticEventType get_Type() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8615AA0 Offset: 0x8611AA0 VA: 0x8615AA0
	public int get_EventValue() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x8615AA8 Offset: 0x8611AA8 VA: 0x8615AA8
	public IResourceLocation get_Location() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8615AB0 Offset: 0x8611AB0 VA: 0x8615AB0
	public object get_Context() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8615AB8 Offset: 0x8611AB8 VA: 0x8615AB8
	public string get_Error() { }

	// RVA: 0x8615AC0 Offset: 0x8611AC0 VA: 0x8615AC0
	public void .ctor(AsyncOperationHandle op, ResourceManager.DiagnosticEventType type, int eventValue = 0, string error, object context) { }
}

// Namespace: 
private struct ResourceManager.DeferredCallbackRegisterRequest // TypeDefIndex: 24965
{
	// Fields
	internal IAsyncOperation operation; // 0x0
	internal bool incrementRefCount; // 0x8
}

// Namespace: 
private class ResourceManager.CompletedOperation<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 24966
{
	// Fields
	private bool m_Success; // 0x0
	private Exception m_Exception; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C99714 Offset: 0x5C95714 VA: 0x5C99714
	|-ResourceManager.CompletedOperation<bool>..ctor
	|
	|-RVA: 0x5C998EC Offset: 0x5C958EC VA: 0x5C998EC
	|-ResourceManager.CompletedOperation<long>..ctor
	|
	|-RVA: 0x5C99AC0 Offset: 0x5C95AC0 VA: 0x5C99AC0
	|-ResourceManager.CompletedOperation<object>..ctor
	|
	|-RVA: 0x5C99CA4 Offset: 0x5C95CA4 VA: 0x5C99CA4
	|-ResourceManager.CompletedOperation<SceneInstance>..ctor
	|
	|-RVA: 0x5C99EA0 Offset: 0x5C95EA0 VA: 0x5C99EA0
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C99724 Offset: 0x5C95724 VA: 0x5C99724
	|-ResourceManager.CompletedOperation<bool>.Init
	|
	|-RVA: 0x5C998FC Offset: 0x5C958FC VA: 0x5C998FC
	|-ResourceManager.CompletedOperation<long>.Init
	|
	|-RVA: 0x5C99AD0 Offset: 0x5C95AD0 VA: 0x5C99AD0
	|-ResourceManager.CompletedOperation<object>.Init
	|
	|-RVA: 0x5C99CB4 Offset: 0x5C95CB4 VA: 0x5C99CB4
	|-ResourceManager.CompletedOperation<SceneInstance>.Init
	|
	|-RVA: 0x5C99EB4 Offset: 0x5C95EB4 VA: 0x5C99EB4
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1
	public void Init(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C997DC Offset: 0x5C957DC VA: 0x5C997DC
	|-ResourceManager.CompletedOperation<bool>.Init
	|
	|-RVA: 0x5C999B4 Offset: 0x5C959B4 VA: 0x5C999B4
	|-ResourceManager.CompletedOperation<long>.Init
	|
	|-RVA: 0x5C99B88 Offset: 0x5C95B88 VA: 0x5C99B88
	|-ResourceManager.CompletedOperation<object>.Init
	|
	|-RVA: 0x5C99D7C Offset: 0x5C95D7C VA: 0x5C99D7C
	|-ResourceManager.CompletedOperation<SceneInstance>.Init
	|
	|-RVA: 0x5C9A0B8 Offset: 0x5C960B8 VA: 0x5C9A0B8
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C99824 Offset: 0x5C95824 VA: 0x5C99824
	|-ResourceManager.CompletedOperation<bool>.get_DebugName
	|
	|-RVA: 0x5C999F8 Offset: 0x5C959F8 VA: 0x5C999F8
	|-ResourceManager.CompletedOperation<long>.get_DebugName
	|
	|-RVA: 0x5C99BDC Offset: 0x5C95BDC VA: 0x5C99BDC
	|-ResourceManager.CompletedOperation<object>.get_DebugName
	|
	|-RVA: 0x5C99DD8 Offset: 0x5C95DD8 VA: 0x5C99DD8
	|-ResourceManager.CompletedOperation<SceneInstance>.get_DebugName
	|
	|-RVA: 0x5C9A1FC Offset: 0x5C961FC VA: 0x5C9A1FC
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C99864 Offset: 0x5C95864 VA: 0x5C99864
	|-ResourceManager.CompletedOperation<bool>.InvokeWaitForCompletion
	|
	|-RVA: 0x5C99A38 Offset: 0x5C95A38 VA: 0x5C99A38
	|-ResourceManager.CompletedOperation<long>.InvokeWaitForCompletion
	|
	|-RVA: 0x5C99C1C Offset: 0x5C95C1C VA: 0x5C99C1C
	|-ResourceManager.CompletedOperation<object>.InvokeWaitForCompletion
	|
	|-RVA: 0x5C99E18 Offset: 0x5C95E18 VA: 0x5C99E18
	|-ResourceManager.CompletedOperation<SceneInstance>.InvokeWaitForCompletion
	|
	|-RVA: 0x5C9A23C Offset: 0x5C9623C VA: 0x5C9A23C
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C998BC Offset: 0x5C958BC VA: 0x5C998BC
	|-ResourceManager.CompletedOperation<bool>.Execute
	|
	|-RVA: 0x5C99A90 Offset: 0x5C95A90 VA: 0x5C99A90
	|-ResourceManager.CompletedOperation<long>.Execute
	|
	|-RVA: 0x5C99C74 Offset: 0x5C95C74 VA: 0x5C99C74
	|-ResourceManager.CompletedOperation<object>.Execute
	|
	|-RVA: 0x5C99E70 Offset: 0x5C95E70 VA: 0x5C99E70
	|-ResourceManager.CompletedOperation<SceneInstance>.Execute
	|
	|-RVA: 0x5C9A2D4 Offset: 0x5C962D4 VA: 0x5C9A2D4
	|-ResourceManager.CompletedOperation<__Il2CppFullySharedGenericType>.Execute
	*/
}

// Namespace: 
internal class ResourceManager.InstanceOperation : AsyncOperationBase<GameObject> // TypeDefIndex: 24967
{
	// Fields
	private AsyncOperationHandle<GameObject> m_dependency; // 0x98
	private InstantiationParameters m_instantiationParams; // 0xB0
	private IInstanceProvider m_instanceProvider; // 0xE0
	private GameObject m_instance; // 0xE8
	private Scene m_scene; // 0xF0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x8614C18 Offset: 0x8610C18 VA: 0x8614C18
	public void Init(ResourceManager rm, IInstanceProvider instanceProvider, InstantiationParameters instantiationParams, AsyncOperationHandle<GameObject> dependency) { }

	// RVA: 0x8615BF8 Offset: 0x8611BF8 VA: 0x8615BF8 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x8615CD4 Offset: 0x8611CD4 VA: 0x8615CD4 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x8615E04 Offset: 0x8611E04 VA: 0x8615E04 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x8615F18 Offset: 0x8611F18 VA: 0x8615F18
	public Scene InstanceScene() { }

	// RVA: 0x8615F20 Offset: 0x8611F20 VA: 0x8615F20 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x8615FD4 Offset: 0x8611FD4 VA: 0x8615FD4 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x861601C Offset: 0x861201C VA: 0x861601C Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x861614C Offset: 0x861214C VA: 0x861614C Slot: 28
	protected override void Execute() { }

	// RVA: 0x8616390 Offset: 0x8612390 VA: 0x8616390
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ResourceManager.<>c__DisplayClass100_0<TObject> // TypeDefIndex: 24968
{
	// Fields
	public Action<TObject> callback; // 0x0
	public bool releaseDependenciesOnFailure; // 0x0
	public ResourceManager <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485F0A8 Offset: 0x485B0A8 VA: 0x485F0A8
	|-ResourceManager.<>c__DisplayClass100_0<object>..ctor
	|
	|-RVA: 0x48609B4 Offset: 0x485C9B4 VA: 0x48609B4
	|-ResourceManager.<>c__DisplayClass100_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ProvideResources>b__0(AsyncOperationHandle x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485F0B0 Offset: 0x485B0B0 VA: 0x485F0B0
	|-ResourceManager.<>c__DisplayClass100_0<object>.<ProvideResources>b__0
	|
	|-RVA: 0x48609BC Offset: 0x485C9BC VA: 0x48609BC
	|-ResourceManager.<>c__DisplayClass100_0<__Il2CppFullySharedGenericType>.<ProvideResources>b__0
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<TObject>> <ProvideResources>b__1(AsyncOperationHandle resultHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485F138 Offset: 0x485B138 VA: 0x485F138
	|-ResourceManager.<>c__DisplayClass100_0<object>.<ProvideResources>b__1
	|
	|-RVA: 0x4860AB0 Offset: 0x485CAB0 VA: 0x4860AB0
	|-ResourceManager.<>c__DisplayClass100_0<__Il2CppFullySharedGenericType>.<ProvideResources>b__1
	*/
}

// Namespace: UnityEngine.ResourceManagement
public class ResourceManager : IDisposable // TypeDefIndex: 24969
{
	// Fields
	internal bool postProfilerEvents; // 0x10
	[CompilerGenerated]
	private static Action<AsyncOperationHandle, Exception> <ExceptionHandler>k__BackingField; // 0x0
	[CompilerGenerated]
	private Func<IResourceLocation, string> <InternalIdTransformFunc>k__BackingField; // 0x18
	[CompilerGenerated]
	private Action<UnityWebRequest> <WebRequestOverride>k__BackingField; // 0x20
	internal bool CallbackHooksEnabled; // 0x28
	private ListWithEvents<IResourceProvider> m_ResourceProviders; // 0x30
	private IAllocationStrategy m_allocator; // 0x38
	internal ListWithEvents<IUpdateReceiver> m_UpdateReceivers; // 0x40
	private List<IUpdateReceiver> m_UpdateReceiversToRemove; // 0x48
	private bool m_UpdatingReceivers; // 0x50
	private bool m_InsideUpdateMethod; // 0x51
	internal Dictionary<int, IResourceProvider> m_providerMap; // 0x58
	private Dictionary<IOperationCacheKey, IAsyncOperation> m_AssetOperationCache; // 0x60
	private HashSet<ResourceManager.InstanceOperation> m_TrackedInstanceOperations; // 0x68
	internal DelegateList<float> m_UpdateCallbacks; // 0x70
	private List<IAsyncOperation> m_DeferredCompleteCallbacks; // 0x78
	private bool m_InsideExecuteDeferredCallbacksMethod; // 0x80
	private List<ResourceManager.DeferredCallbackRegisterRequest> m_DeferredCallbacksToRegister; // 0x88
	private Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> m_obsoleteDiagnosticsHandler; // 0x90
	private Action<ResourceManager.DiagnosticEventContext> m_diagnosticsHandler; // 0x98
	private Action<IAsyncOperation> m_ReleaseOpNonCached; // 0xA0
	private Action<IAsyncOperation> m_ReleaseOpCached; // 0xA8
	private Action<IAsyncOperation> m_ReleaseInstanceOp; // 0xB0
	private static int s_GroupOperationTypeHash; // 0x8
	private static int s_InstanceOperationTypeHash; // 0xC
	[CompilerGenerated]
	private CertificateHandler <CertificateHandlerInstance>k__BackingField; // 0xB8
	private bool m_RegisteredForCallbacks; // 0xC0
	private Dictionary<Type, Type> m_ProviderOperationTypeCache; // 0xC8

	// Properties
	public static Action<AsyncOperationHandle, Exception> ExceptionHandler { get; set; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public Action<UnityWebRequest> WebRequestOverride { get; set; }
	internal int OperationCacheCount { get; }
	internal int InstanceOperationCount { get; }
	internal int DeferredCompleteCallbacksCount { get; }
	internal int DeferredCallbackCount { get; }
	public IAllocationStrategy Allocator { get; set; }
	public IList<IResourceProvider> ResourceProviders { get; }
	public CertificateHandler CertificateHandlerInstance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8610B5C Offset: 0x860CB5C VA: 0x8610B5C
	public static Action<AsyncOperationHandle, Exception> get_ExceptionHandler() { }

	[CompilerGenerated]
	// RVA: 0x8610BB4 Offset: 0x860CBB4 VA: 0x8610BB4
	public static void set_ExceptionHandler(Action<AsyncOperationHandle, Exception> value) { }

	[CompilerGenerated]
	// RVA: 0x8610C1C Offset: 0x860CC1C VA: 0x8610C1C
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	[CompilerGenerated]
	// RVA: 0x8610C24 Offset: 0x860CC24 VA: 0x8610C24
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x8610C2C Offset: 0x860CC2C VA: 0x8610C2C
	public string TransformInternalId(IResourceLocation location) { }

	[CompilerGenerated]
	// RVA: 0x8610CF0 Offset: 0x860CCF0 VA: 0x8610CF0
	public Action<UnityWebRequest> get_WebRequestOverride() { }

	[CompilerGenerated]
	// RVA: 0x8610CF8 Offset: 0x860CCF8 VA: 0x8610CF8
	public void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x8610D00 Offset: 0x860CD00 VA: 0x8610D00
	internal int get_OperationCacheCount() { }

	// RVA: 0x8610D50 Offset: 0x860CD50 VA: 0x8610D50
	internal int get_InstanceOperationCount() { }

	// RVA: 0x8610D98 Offset: 0x860CD98 VA: 0x8610D98
	internal int get_DeferredCompleteCallbacksCount() { }

	// RVA: 0x8610DE0 Offset: 0x860CDE0 VA: 0x8610DE0
	internal int get_DeferredCallbackCount() { }

	// RVA: 0x8610E2C Offset: 0x860CE2C VA: 0x8610E2C
	public void AddUpdateReceiver(IUpdateReceiver receiver) { }

	// RVA: 0x8610E94 Offset: 0x860CE94 VA: 0x8610E94
	public void RemoveUpdateReciever(IUpdateReceiver receiver) { }

	// RVA: 0x8610FDC Offset: 0x860CFDC VA: 0x8610FDC
	public IAllocationStrategy get_Allocator() { }

	// RVA: 0x8610FE4 Offset: 0x860CFE4 VA: 0x8610FE4
	public void set_Allocator(IAllocationStrategy value) { }

	// RVA: 0x8610FEC Offset: 0x860CFEC VA: 0x8610FEC
	public IList<IResourceProvider> get_ResourceProviders() { }

	[CompilerGenerated]
	// RVA: 0x8610FF4 Offset: 0x860CFF4 VA: 0x8610FF4
	public CertificateHandler get_CertificateHandlerInstance() { }

	[CompilerGenerated]
	// RVA: 0x8610FFC Offset: 0x860CFFC VA: 0x8610FFC
	public void set_CertificateHandlerInstance(CertificateHandler value) { }

	// RVA: 0x8611004 Offset: 0x860D004 VA: 0x8611004
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x8611924 Offset: 0x860D924 VA: 0x8611924
	private void OnObjectAdded(object obj) { }

	// RVA: 0x8611998 Offset: 0x860D998 VA: 0x8611998
	private void OnObjectRemoved(object obj) { }

	// RVA: 0x8611A0C Offset: 0x860DA0C VA: 0x8611A0C
	internal void RegisterForCallbacks() { }

	[Obsolete("ClearDiagnosticsCallback is Obsolete, use ClearDiagnosticCallbacks instead.")]
	// RVA: 0x8611AD4 Offset: 0x860DAD4 VA: 0x8611AD4
	public void ClearDiagnosticsCallback() { }

	// RVA: 0x8611AFC Offset: 0x860DAFC VA: 0x8611AFC
	public void ClearDiagnosticCallbacks() { }

	// RVA: 0x8611B24 Offset: 0x860DB24 VA: 0x8611B24
	public void UnregisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	[Obsolete]
	// RVA: 0x8611C20 Offset: 0x860DC20 VA: 0x8611C20
	public void RegisterDiagnosticCallback(Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> func) { }

	// RVA: 0x8611C28 Offset: 0x860DC28 VA: 0x8611C28
	public void RegisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	// RVA: 0x8611CD0 Offset: 0x860DCD0 VA: 0x8611CD0
	internal void PostDiagnosticEvent(ResourceManager.DiagnosticEventContext context) { }

	// RVA: 0x8611DCC Offset: 0x860DDCC VA: 0x8611DCC
	public IResourceProvider GetResourceProvider(Type t, IResourceLocation location) { }

	// RVA: 0x8612210 Offset: 0x860E210 VA: 0x8612210
	private Type GetDefaultTypeForLocation(IResourceLocation loc) { }

	// RVA: 0x861234C Offset: 0x860E34C VA: 0x861234C
	private int CalculateLocationsHash(IList<IResourceLocation> locations, Type t) { }

	// RVA: 0x86127A0 Offset: 0x860E7A0 VA: 0x86127A0
	private AsyncOperationHandle ProvideResource(IResourceLocation location, Type desiredType, bool releaseDependenciesOnFailure = True) { }

	// RVA: 0x861399C Offset: 0x860F99C VA: 0x861399C
	internal IAsyncOperation GetOperationFromCache(IResourceLocation location, Type desiredType) { }

	// RVA: 0x8612FBC Offset: 0x860EFBC VA: 0x8612FBC
	internal IOperationCacheKey CreateCacheKeyForLocation(IResourceProvider provider, IResourceLocation location, Type desiredType) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> ProvideResource<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C23E4 Offset: 0x46BE3E4 VA: 0x46C23E4
	|-ResourceManager.ProvideResource<object>
	|
	|-RVA: 0x46C24C0 Offset: 0x46BE4C0 VA: 0x46C24C0
	|-ResourceManager.ProvideResource<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> StartOperation<TObject>(AsyncOperationBase<TObject> operation, AsyncOperationHandle dependency) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C2BA8 Offset: 0x46BEBA8 VA: 0x46C2BA8
	|-ResourceManager.StartOperation<bool>
	|
	|-RVA: 0x46C2C58 Offset: 0x46BEC58 VA: 0x46C2C58
	|-ResourceManager.StartOperation<long>
	|
	|-RVA: 0x46C2D08 Offset: 0x46BED08 VA: 0x46C2D08
	|-ResourceManager.StartOperation<object>
	|
	|-RVA: 0x46C2DB8 Offset: 0x46BEDB8 VA: 0x46C2DB8
	|-ResourceManager.StartOperation<SceneInstance>
	|
	|-RVA: 0x46C2E68 Offset: 0x46BEE68 VA: 0x46C2E68
	|-ResourceManager.StartOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8613828 Offset: 0x860F828 VA: 0x8613828
	internal AsyncOperationHandle StartOperation(IAsyncOperation operation, AsyncOperationHandle dependency) { }

	// RVA: 0x8613B48 Offset: 0x860FB48 VA: 0x8613B48
	private void OnInstanceOperationDestroy(IAsyncOperation o) { }

	// RVA: 0x8613C8C Offset: 0x860FC8C VA: 0x8613C8C
	private void OnOperationDestroyNonCached(IAsyncOperation o) { }

	// RVA: 0x8613D60 Offset: 0x860FD60 VA: 0x8613D60
	private void OnOperationDestroyCached(IAsyncOperation o) { }

	// RVA: -1 Offset: -1
	internal T CreateOperation<T>(Type actualType, int typeHash, IOperationCacheKey cacheKey, Action<IAsyncOperation> onDestroyAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C1DFC Offset: 0x46BDDFC VA: 0x46C1DFC
	|-ResourceManager.CreateOperation<object>
	|
	|-RVA: 0x46C202C Offset: 0x46BE02C VA: 0x46C202C
	|-ResourceManager.CreateOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x861400C Offset: 0x861000C VA: 0x861400C
	internal void AddOperationToCache(IOperationCacheKey key, IAsyncOperation operation) { }

	// RVA: 0x8613F94 Offset: 0x860FF94 VA: 0x8613F94
	internal bool RemoveOperationFromCache(IOperationCacheKey key) { }

	// RVA: 0x8614094 Offset: 0x8610094 VA: 0x8614094
	internal bool IsOperationCached(IOperationCacheKey key) { }

	// RVA: 0x86140EC Offset: 0x86100EC VA: 0x86140EC
	internal int CachedOperationCount() { }

	// RVA: 0x861413C Offset: 0x861013C VA: 0x861413C
	internal void ClearOperationCache() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BF774 Offset: 0x46BB774 VA: 0x46BF774
	|-ResourceManager.CreateCompletedOperation<bool>
	|
	|-RVA: 0x46BF84C Offset: 0x46BB84C VA: 0x46BF84C
	|-ResourceManager.CreateCompletedOperation<long>
	|
	|-RVA: 0x46BF924 Offset: 0x46BB924 VA: 0x46BF924
	|-ResourceManager.CreateCompletedOperation<object>
	|
	|-RVA: 0x46BF9FC Offset: 0x46BB9FC VA: 0x46BF9FC
	|-ResourceManager.CreateCompletedOperation<SceneInstance>
	|
	|-RVA: 0x46BFAE0 Offset: 0x46BBAE0 VA: 0x46BFAE0
	|-ResourceManager.CreateCompletedOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateCompletedOperationWithException<TObject>(TObject result, Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C0404 Offset: 0x46BC404 VA: 0x46C0404
	|-ResourceManager.CreateCompletedOperationWithException<long>
	|
	|-RVA: 0x46C0484 Offset: 0x46BC484 VA: 0x46C0484
	|-ResourceManager.CreateCompletedOperationWithException<object>
	|
	|-RVA: 0x46C0504 Offset: 0x46BC504 VA: 0x46C0504
	|-ResourceManager.CreateCompletedOperationWithException<SceneInstance>
	|
	|-RVA: 0x46C0590 Offset: 0x46BC590 VA: 0x46C0590
	|-ResourceManager.CreateCompletedOperationWithException<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BFCEC Offset: 0x46BBCEC VA: 0x46BFCEC
	|-ResourceManager.CreateCompletedOperationInternal<bool>
	|
	|-RVA: 0x46BFE30 Offset: 0x46BBE30 VA: 0x46BFE30
	|-ResourceManager.CreateCompletedOperationInternal<long>
	|
	|-RVA: 0x46BFF74 Offset: 0x46BBF74 VA: 0x46BFF74
	|-ResourceManager.CreateCompletedOperationInternal<object>
	|
	|-RVA: 0x46C00B8 Offset: 0x46BC0B8 VA: 0x46C00B8
	|-ResourceManager.CreateCompletedOperationInternal<SceneInstance>
	|
	|-RVA: 0x46C0204 Offset: 0x46BC204 VA: 0x46C0204
	|-ResourceManager.CreateCompletedOperationInternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x861418C Offset: 0x861018C VA: 0x861418C
	public void Release(AsyncOperationHandle handle) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> Acquire<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BE75C Offset: 0x46BA75C VA: 0x46BE75C
	|-ResourceManager.Acquire<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8614198 Offset: 0x8610198 VA: 0x8614198
	public void Acquire(AsyncOperationHandle handle) { }

	// RVA: 0x86141BC Offset: 0x86101BC VA: 0x86141BC
	private GroupOperation AcquireGroupOpFromCache(IOperationCacheKey key) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C06A4 Offset: 0x46BC6A4 VA: 0x46C06A4
	|-ResourceManager.CreateGroupOperation<object>
	|
	|-RVA: 0x46C0C70 Offset: 0x46BCC70 VA: 0x46C0C70
	|-ResourceManager.CreateGroupOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations, bool allowFailedDependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C1248 Offset: 0x46BD248 VA: 0x46C1248
	|-ResourceManager.CreateGroupOperation<object>
	|
	|-RVA: 0x46C181C Offset: 0x46BD81C VA: 0x46C181C
	|-ResourceManager.CreateGroupOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86142F8 Offset: 0x86102F8 VA: 0x86142F8
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGenericGroupOperation(List<AsyncOperationHandle> operations, bool releasedCachedOpOnComplete = False) { }

	// RVA: 0x8613098 Offset: 0x860F098 VA: 0x8613098
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> ProvideResourceGroupCached(IList<IResourceLocation> locations, int groupHash, Type desiredType, Action<AsyncOperationHandle> callback, bool releaseDependenciesOnFailure = True) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C25A0 Offset: 0x46BE5A0 VA: 0x46C25A0
	|-ResourceManager.ProvideResources<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, bool releaseDependenciesOnFailure, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C261C Offset: 0x46BE61C VA: 0x46C261C
	|-ResourceManager.ProvideResources<object>
	|
	|-RVA: 0x46C28D4 Offset: 0x46BE8D4 VA: 0x46C28D4
	|-ResourceManager.ProvideResources<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BECF8 Offset: 0x46BACF8 VA: 0x46BECF8
	|-ResourceManager.CreateChainOperation<long, object>
	|
	|-RVA: 0x46BEE8C Offset: 0x46BAE8C VA: 0x46BEE8C
	|-ResourceManager.CreateChainOperation<object, object>
	|
	|-RVA: 0x46BF020 Offset: 0x46BB020 VA: 0x46BF020
	|-ResourceManager.CreateChainOperation<SceneInstance, SceneInstance>
	|
	|-RVA: 0x46BF1B4 Offset: 0x46BB1B4 VA: 0x46BF1B4
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BE7BC Offset: 0x46BA7BC VA: 0x46BE7BC
	|-ResourceManager.CreateChainOperation<bool>
	|
	|-RVA: 0x46BE8C4 Offset: 0x46BA8C4 VA: 0x46BE8C4
	|-ResourceManager.CreateChainOperation<long>
	|
	|-RVA: 0x46BE9CC Offset: 0x46BA9CC VA: 0x46BE9CC
	|-ResourceManager.CreateChainOperation<object>
	|
	|-RVA: 0x46BEAD4 Offset: 0x46BAAD4 VA: 0x46BEAD4
	|-ResourceManager.CreateChainOperation<SceneInstance>
	|
	|-RVA: 0x46BEBDC Offset: 0x46BABDC VA: 0x46BEBDC
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BF5A4 Offset: 0x46BB5A4 VA: 0x46BF5A4
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46BF378 Offset: 0x46BB378 VA: 0x46BF378
	|-ResourceManager.CreateChainOperation<object>
	|
	|-RVA: 0x46BF484 Offset: 0x46BB484 VA: 0x46BF484
	|-ResourceManager.CreateChainOperation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8614564 Offset: 0x8610564 VA: 0x8614564
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority) { }

	// RVA: 0x86146C0 Offset: 0x86106C0 VA: 0x86146C0
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	// RVA: 0x8614804 Offset: 0x8610804 VA: 0x8614804
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider sceneProvider, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x8614948 Offset: 0x8610948 VA: 0x8614948
	public AsyncOperationHandle<GameObject> ProvideInstance(IInstanceProvider provider, IResourceLocation location, InstantiationParameters instantiateParameters) { }

	// RVA: 0x8614C98 Offset: 0x8610C98 VA: 0x8614C98
	public void CleanupSceneInstances(Scene scene) { }

	// RVA: 0x86150A0 Offset: 0x86110A0 VA: 0x86150A0
	private void ExecuteDeferredCallbacks() { }

	// RVA: 0x8615254 Offset: 0x8611254 VA: 0x8615254
	internal void RegisterForDeferredCallback(IAsyncOperation op, bool incrementRefCount = True) { }

	// RVA: 0x8615494 Offset: 0x8611494 VA: 0x8615494
	internal void Update(float unscaledDeltaTime) { }

	// RVA: 0x86158CC Offset: 0x86118CC VA: 0x86158CC Slot: 4
	public void Dispose() { }

	// RVA: 0x86159A0 Offset: 0x86119A0 VA: 0x86159A0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x8615A80 Offset: 0x8611A80 VA: 0x8615A80
	private void <.ctor>b__57_0(IUpdateReceiver x) { }
}

// Namespace: UnityEngine.ResourceManagement
public interface IUpdateReceiver // TypeDefIndex: 24970
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update(float unscaledDeltaTime);
}

// Namespace: UnityEngine.ResourceManagement
public class WebRequestQueueOperation // TypeDefIndex: 24971
{
	// Fields
	private bool m_Completed; // 0x10
	public UnityWebRequestAsyncOperation Result; // 0x18
	public Action<UnityWebRequestAsyncOperation> OnComplete; // 0x20
	internal UnityWebRequest m_WebRequest; // 0x28

	// Properties
	public bool IsDone { get; }
	public UnityWebRequest WebRequest { get; set; }

	// Methods

	// RVA: 0x86163D8 Offset: 0x86123D8 VA: 0x86163D8
	public bool get_IsDone() { }

	// RVA: 0x86163F8 Offset: 0x86123F8 VA: 0x86163F8
	public UnityWebRequest get_WebRequest() { }

	// RVA: 0x8616400 Offset: 0x8612400 VA: 0x8616400
	internal void set_WebRequest(UnityWebRequest value) { }

	// RVA: 0x8616408 Offset: 0x8612408 VA: 0x8616408
	public void .ctor(UnityWebRequest request) { }

	// RVA: 0x8616438 Offset: 0x8612438 VA: 0x8616438
	internal void Complete(UnityWebRequestAsyncOperation asyncOp) { }
}

// Namespace: UnityEngine.ResourceManagement
public static class WebRequestQueue // TypeDefIndex: 24972
{
	// Fields
	internal static int s_MaxRequest; // 0x0
	internal static Queue<WebRequestQueueOperation> s_QueuedOperations; // 0x8
	internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests; // 0x10

	// Methods

	// RVA: 0x861647C Offset: 0x861247C VA: 0x861647C
	public static void SetMaxConcurrentRequests(int maxRequests) { }

	// RVA: 0x861653C Offset: 0x861253C VA: 0x861653C
	public static WebRequestQueueOperation QueueRequest(UnityWebRequest request) { }

	// RVA: 0x86168B8 Offset: 0x86128B8 VA: 0x86168B8
	public static void WaitForRequestToBeActive(WebRequestQueueOperation request, int millisecondsTimeout) { }

	// RVA: 0x8616EE0 Offset: 0x8612EE0 VA: 0x8616EE0
	internal static void DequeueRequest(UnityWebRequestAsyncOperation operation) { }

	// RVA: 0x8616F98 Offset: 0x8612F98 VA: 0x8616F98
	private static void OnWebAsyncOpComplete(AsyncOperation operation) { }

	// RVA: 0x8616DD8 Offset: 0x8612DD8 VA: 0x8616DD8
	private static void OnWebAsyncOpComplete(UnityWebRequestAsyncOperation operation) { }

	// RVA: 0x8616648 Offset: 0x8612648 VA: 0x8616648
	private static void BeginWebRequest(WebRequestQueueOperation queueOperation) { }

	// RVA: 0x861703C Offset: 0x861303C VA: 0x861703C
	private static void .cctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class ResourceManagerException : Exception // TypeDefIndex: 24973
{
	// Methods

	// RVA: 0x8617134 Offset: 0x8613134 VA: 0x8617134
	public void .ctor() { }

	// RVA: 0x861718C Offset: 0x861318C VA: 0x861718C
	public void .ctor(string message) { }

	// RVA: 0x86171F4 Offset: 0x86131F4 VA: 0x86171F4
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x8617264 Offset: 0x8613264 VA: 0x8617264
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x86172E4 Offset: 0x86132E4 VA: 0x86172E4 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class UnknownResourceProviderException : ResourceManagerException // TypeDefIndex: 24974
{
	// Fields
	[CompilerGenerated]
	private IResourceLocation <Location>k__BackingField; // 0x90

	// Properties
	public IResourceLocation Location { get; set; }
	public override string Message { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8617370 Offset: 0x8613370 VA: 0x8617370
	public IResourceLocation get_Location() { }

	[CompilerGenerated]
	// RVA: 0x8617378 Offset: 0x8613378 VA: 0x8617378
	private void set_Location(IResourceLocation value) { }

	// RVA: 0x8612F90 Offset: 0x860EF90 VA: 0x8612F90
	public void .ctor(IResourceLocation location) { }

	// RVA: 0x8617380 Offset: 0x8613380 VA: 0x8617380
	public void .ctor() { }

	// RVA: 0x8617384 Offset: 0x8613384 VA: 0x8617384
	public void .ctor(string message) { }

	// RVA: 0x8617388 Offset: 0x8613388 VA: 0x8617388
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x861738C Offset: 0x861338C VA: 0x861738C
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x8617390 Offset: 0x8613390 VA: 0x8617390 Slot: 5
	public override string get_Message() { }

	// RVA: 0x861754C Offset: 0x861354C VA: 0x861754C Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class OperationException : Exception // TypeDefIndex: 24975
{
	// Methods

	// RVA: 0x8617558 Offset: 0x8613558 VA: 0x8617558
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x86175C8 Offset: 0x86135C8 VA: 0x86175C8 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class ProviderException : OperationException // TypeDefIndex: 24976
{
	// Fields
	[CompilerGenerated]
	private readonly IResourceLocation <Location>k__BackingField; // 0x90

	// Properties
	public IResourceLocation Location { get; }

	// Methods

	// RVA: 0x8617654 Offset: 0x8613654 VA: 0x8617654
	public void .ctor(string message, IResourceLocation location, Exception innerException) { }

	[CompilerGenerated]
	// RVA: 0x8617684 Offset: 0x8613684 VA: 0x8617684
	public IResourceLocation get_Location() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class RemoteProviderException : ProviderException // TypeDefIndex: 24977
{
	// Fields
	[CompilerGenerated]
	private readonly UnityWebRequestResult <WebRequestResult>k__BackingField; // 0x98

	// Properties
	public override string Message { get; }
	public UnityWebRequestResult WebRequestResult { get; }

	// Methods

	// RVA: 0x861768C Offset: 0x861368C VA: 0x861768C
	public void .ctor(string message, IResourceLocation location, UnityWebRequestResult uwrResult, Exception innerException) { }

	// RVA: 0x86176D0 Offset: 0x86136D0 VA: 0x86176D0 Slot: 5
	public override string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x86176DC Offset: 0x86136DC VA: 0x86176DC
	public UnityWebRequestResult get_WebRequestResult() { }

	// RVA: 0x86176E4 Offset: 0x86136E4 VA: 0x86176E4 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private struct BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap // TypeDefIndex: 24978
{
	// Fields
	public uint stringId; // 0x0
	public char separator; // 0x4
}

// Namespace: 
[CompilerGenerated]
private sealed class BinaryStorageBuffer.BuiltinTypesSerializer.<>c__DisplayClass4_0 // TypeDefIndex: 24979
{
	// Fields
	public char s; // 0x10

	// Methods

	// RVA: 0x8618620 Offset: 0x8614620 VA: 0x8618620
	public void .ctor() { }

	// RVA: 0x8618A98 Offset: 0x8614A98 VA: 0x8618A98
	internal bool <FindBestSeparator>b__0(char c) { }
}

// Namespace: 
private class BinaryStorageBuffer.BuiltinTypesSerializer : BinaryStorageBuffer.ISerializationAdapter<int>, BinaryStorageBuffer.ISerializationAdapter, BinaryStorageBuffer.ISerializationAdapter<bool>, BinaryStorageBuffer.ISerializationAdapter<long>, BinaryStorageBuffer.ISerializationAdapter<string>, BinaryStorageBuffer.ISerializationAdapter<Hash128> // TypeDefIndex: 24980
{
	// Properties
	public IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies { get; }

	// Methods

	// RVA: 0x86180F0 Offset: 0x86140F0 VA: 0x86180F0 Slot: 4
	public IEnumerable<BinaryStorageBuffer.ISerializationAdapter> get_Dependencies() { }

	// RVA: 0x86180F8 Offset: 0x86140F8 VA: 0x86180F8 Slot: 6
	public object Deserialize(BinaryStorageBuffer.Reader reader, Type t, uint offset) { }

	// RVA: 0x8618468 Offset: 0x8614468 VA: 0x8618468
	private char FindBestSeparator(string str, char[] seps) { }

	// RVA: 0x8618628 Offset: 0x8614628 VA: 0x8618628 Slot: 5
	public uint Serialize(BinaryStorageBuffer.Writer writer, object val) { }

	// RVA: 0x8618A90 Offset: 0x8614A90 VA: 0x8618A90
	public void .ctor() { }
}

// Namespace: 
private struct BinaryStorageBuffer.TypeSerializer.Data // TypeDefIndex: 24981
{
	// Fields
	public uint assemblyId; // 0x0
	public uint classId; // 0x4
}

// Namespace: 
private class BinaryStorageBuffer.TypeSerializer : BinaryStorageBuffer.ISerializationAdapter<Type>, BinaryStorageBuffer.ISerializationAdapter // TypeDefIndex: 24982
{
	// Properties
	public IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies { get; }

	// Methods

	// RVA: 0x8618AA8 Offset: 0x8614AA8 VA: 0x8618AA8 Slot: 4
	public IEnumerable<BinaryStorageBuffer.ISerializationAdapter> get_Dependencies() { }

	// RVA: 0x8618AB0 Offset: 0x8614AB0 VA: 0x8618AB0 Slot: 6
	public object Deserialize(BinaryStorageBuffer.Reader reader, Type type, uint offset) { }

	// RVA: 0x8618C64 Offset: 0x8614C64 VA: 0x8618C64 Slot: 5
	public uint Serialize(BinaryStorageBuffer.Writer writer, object val) { }

	// RVA: 0x8618D98 Offset: 0x8614D98 VA: 0x8618D98
	public void .ctor() { }
}

// Namespace: 
private struct BinaryStorageBuffer.DynamicString // TypeDefIndex: 24983
{
	// Fields
	public uint stringId; // 0x0
	public uint nextId; // 0x4
}

// Namespace: 
private struct BinaryStorageBuffer.ObjectTypeData // TypeDefIndex: 24984
{
	// Fields
	public uint typeId; // 0x0
	public uint objectId; // 0x4
}

// Namespace: 
public interface BinaryStorageBuffer.ISerializationAdapter // TypeDefIndex: 24985
{
	// Properties
	public abstract IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract uint Serialize(BinaryStorageBuffer.Writer writer, object val);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object Deserialize(BinaryStorageBuffer.Reader reader, Type t, uint offset);
}

// Namespace: 
public interface BinaryStorageBuffer.ISerializationAdapter<T> : BinaryStorageBuffer.ISerializationAdapter // TypeDefIndex: 24986
{}

// Namespace: 
public class BinaryStorageBuffer.Reader // TypeDefIndex: 24987
{
	// Fields
	private byte[] m_Buffer; // 0x10
	private Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> m_Adapters; // 0x18
	private LRUCache<uint, object> m_Cache; // 0x20
	private StringBuilder stringBuilder; // 0x38

	// Methods

	// RVA: 0x8618DA0 Offset: 0x8614DA0 VA: 0x8618DA0
	private void Init(byte[] data, int maxCachedObjects, BinaryStorageBuffer.ISerializationAdapter[] adapters) { }

	// RVA: 0x8618F9C Offset: 0x8614F9C VA: 0x8618F9C
	public void AddSerializationAdapter(BinaryStorageBuffer.ISerializationAdapter a) { }

	// RVA: 0x8618FA8 Offset: 0x8614FA8 VA: 0x8618FA8
	public void .ctor(byte[] data, int maxCachedObjects = 1024, BinaryStorageBuffer.ISerializationAdapter[] adapters) { }

	// RVA: 0x8618FEC Offset: 0x8614FEC VA: 0x8618FEC
	internal byte[] GetBuffer() { }

	// RVA: 0x8618FF4 Offset: 0x8614FF4 VA: 0x8618FF4
	public void .ctor(Stream inputStream, uint bufferSize, int maxCachedObjects, BinaryStorageBuffer.ISerializationAdapter[] adapters) { }

	// RVA: -1 Offset: -1
	private bool TryGetCachedValue<T>(uint offset, out T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4795AE4 Offset: 0x4791AE4 VA: 0x4795AE4
	|-BinaryStorageBuffer.Reader.TryGetCachedValue<object>
	|
	|-RVA: 0x4795C04 Offset: 0x4791C04 VA: 0x4795C04
	|-BinaryStorageBuffer.Reader.TryGetCachedValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x86190D8 Offset: 0x86150D8 VA: 0x86190D8
	public object[] ReadObjectArray(uint id, bool cacheValues = True) { }

	// RVA: 0x86192E0 Offset: 0x86152E0 VA: 0x86192E0
	public object[] ReadObjectArray(Type t, uint id, bool cacheValues = True) { }

	// RVA: -1 Offset: -1
	public T[] ReadObjectArray<T>(uint id, bool cacheValues = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47949BC Offset: 0x47909BC VA: 0x47949BC
	|-BinaryStorageBuffer.Reader.ReadObjectArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8619228 Offset: 0x8615228 VA: 0x8619228
	public object ReadObject(uint id, bool cacheValue = True) { }

	// RVA: -1 Offset: -1
	public T ReadObject<T>(uint offset, bool cacheValue = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47947B4 Offset: 0x47907B4 VA: 0x47947B4
	|-BinaryStorageBuffer.Reader.ReadObject<object>
	|
	|-RVA: 0x479488C Offset: 0x479088C VA: 0x479488C
	|-BinaryStorageBuffer.Reader.ReadObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x8619440 Offset: 0x8615440 VA: 0x8619440
	public object ReadObject(Type t, uint id, bool cacheValue = True) { }

	// RVA: -1 Offset: -1
	public T[] ReadValueArray<T>(uint id, bool cacheValue = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4795628 Offset: 0x4791628 VA: 0x4795628
	|-BinaryStorageBuffer.Reader.ReadValueArray<uint>
	|
	|-RVA: 0x4795880 Offset: 0x4791880 VA: 0x4795880
	|-BinaryStorageBuffer.Reader.ReadValueArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public T ReadValue<T>(uint id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4794BB4 Offset: 0x4790BB4 VA: 0x4794BB4
	|-BinaryStorageBuffer.Reader.ReadValue<bool>
	|
	|-RVA: 0x4794CCC Offset: 0x4790CCC VA: 0x4794CCC
	|-BinaryStorageBuffer.Reader.ReadValue<Hash128>
	|
	|-RVA: 0x4794DE0 Offset: 0x4790DE0 VA: 0x4794DE0
	|-BinaryStorageBuffer.Reader.ReadValue<int>
	|
	|-RVA: 0x4794EF0 Offset: 0x4790EF0 VA: 0x4794EF0
	|-BinaryStorageBuffer.Reader.ReadValue<long>
	|
	|-RVA: 0x4795000 Offset: 0x4791000 VA: 0x4795000
	|-BinaryStorageBuffer.Reader.ReadValue<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x47951E8 Offset: 0x47911E8 VA: 0x47951E8
	|-BinaryStorageBuffer.Reader.ReadValue<BinaryStorageBuffer.DynamicString>
	|
	|-RVA: 0x47952F8 Offset: 0x47912F8 VA: 0x47952F8
	|-BinaryStorageBuffer.Reader.ReadValue<BinaryStorageBuffer.ObjectTypeData>
	|
	|-RVA: 0x4795408 Offset: 0x4791408 VA: 0x4795408
	|-BinaryStorageBuffer.Reader.ReadValue<BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap>
	|
	|-RVA: 0x4795518 Offset: 0x4791518 VA: 0x4795518
	|-BinaryStorageBuffer.Reader.ReadValue<BinaryStorageBuffer.TypeSerializer.Data>
	*/

	// RVA: 0x8618440 Offset: 0x8614440 VA: 0x8618440
	public string ReadString(uint id, char sep = '\x0', bool cacheValue = True) { }

	// RVA: 0x8619838 Offset: 0x8615838 VA: 0x8619838
	private string ReadStringInternal(uint offset, Encoding enc, bool cacheValue = True) { }

	// RVA: 0x861963C Offset: 0x861563C VA: 0x861963C
	private string ReadAutoEncodedString(uint id, bool cacheValue) { }

	// RVA: 0x8619690 Offset: 0x8615690 VA: 0x8619690
	private string ReadDynamicString(uint id, char sep, bool cacheValue) { }
}

// Namespace: 
private class BinaryStorageBuffer.Writer.Chunk // TypeDefIndex: 24988
{
	// Fields
	public uint position; // 0x10
	public byte[] data; // 0x18

	// Methods

	// RVA: 0x8619D3C Offset: 0x8615D3C VA: 0x8619D3C
	public void .ctor() { }
}

// Namespace: 
private struct BinaryStorageBuffer.Writer.StringParts // TypeDefIndex: 24989
{
	// Fields
	public string str; // 0x0
	public uint dataSize; // 0x8
	public bool isUnicode; // 0xC
}

// Namespace: 
public class BinaryStorageBuffer.Writer // TypeDefIndex: 24990
{
	// Fields
	private uint totalBytes; // 0x10
	private uint defaulChunkSize; // 0x14
	private List<BinaryStorageBuffer.Writer.Chunk> chunks; // 0x18
	private Dictionary<Hash128, uint> existingValues; // 0x20
	private Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> serializationAdapters; // 0x28

	// Properties
	public uint Length { get; }

	// Methods

	// RVA: 0x8619A70 Offset: 0x8615A70 VA: 0x8619A70
	public uint get_Length() { }

	// RVA: 0x8619A78 Offset: 0x8615A78 VA: 0x8619A78
	public void .ctor(int chunkSize = 1048576, BinaryStorageBuffer.ISerializationAdapter[] adapters) { }

	// RVA: 0x8619D44 Offset: 0x8615D44 VA: 0x8619D44
	private BinaryStorageBuffer.Writer.Chunk FindChunkWithSpace(uint length) { }

	// RVA: 0x8619EF8 Offset: 0x8615EF8 VA: 0x8619EF8
	private uint WriteInternal(void* pData, uint dataSize, bool prefixSize) { }

	// RVA: 0x861A0A8 Offset: 0x86160A8 VA: 0x861A0A8
	private uint ReserveInternal(uint dataSize, bool prefixSize) { }

	// RVA: 0x861A100 Offset: 0x8616100 VA: 0x861A100
	private void WriteInternal(uint id, void* pData, uint dataSize, bool prefixSize) { }

	// RVA: -1 Offset: -1
	public uint Reserve<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4795D50 Offset: 0x4791D50 VA: 0x4795D50
	|-BinaryStorageBuffer.Writer.Reserve<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public uint Write<T>(in T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4795EC8 Offset: 0x4791EC8 VA: 0x4795EC8
	|-BinaryStorageBuffer.Writer.Write<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public uint Write<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4795DE0 Offset: 0x4791DE0 VA: 0x4795DE0
	|-BinaryStorageBuffer.Writer.Write<bool>
	|
	|-RVA: 0x4795E08 Offset: 0x4791E08 VA: 0x4795E08
	|-BinaryStorageBuffer.Writer.Write<Hash128>
	|
	|-RVA: 0x4795E34 Offset: 0x4791E34 VA: 0x4795E34
	|-BinaryStorageBuffer.Writer.Write<int>
	|
	|-RVA: 0x4795E58 Offset: 0x4791E58 VA: 0x4795E58
	|-BinaryStorageBuffer.Writer.Write<long>
	|
	|-RVA: 0x4795E7C Offset: 0x4791E7C VA: 0x4795E7C
	|-BinaryStorageBuffer.Writer.Write<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x4795F14 Offset: 0x4791F14 VA: 0x4795F14
	|-BinaryStorageBuffer.Writer.Write<BinaryStorageBuffer.DynamicString>
	|
	|-RVA: 0x4795F38 Offset: 0x4791F38 VA: 0x4795F38
	|-BinaryStorageBuffer.Writer.Write<BinaryStorageBuffer.ObjectTypeData>
	|
	|-RVA: 0x4795F5C Offset: 0x4791F5C VA: 0x4795F5C
	|-BinaryStorageBuffer.Writer.Write<BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap>
	|
	|-RVA: 0x4795F80 Offset: 0x4791F80 VA: 0x4795F80
	|-BinaryStorageBuffer.Writer.Write<BinaryStorageBuffer.TypeSerializer.Data>
	*/

	// RVA: -1 Offset: -1
	public uint Write<T>(uint offset, in T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4796370 Offset: 0x4792370 VA: 0x4796370
	|-BinaryStorageBuffer.Writer.Write<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public uint Write<T>(uint offset, T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x479630C Offset: 0x479230C VA: 0x479630C
	|-BinaryStorageBuffer.Writer.Write<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public uint Reserve<T>(uint count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4795D94 Offset: 0x4791D94 VA: 0x4795D94
	|-BinaryStorageBuffer.Writer.Reserve<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public uint Write<T>(T[] values, bool hashElements = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4795FA4 Offset: 0x4791FA4 VA: 0x4795FA4
	|-BinaryStorageBuffer.Writer.Write<uint>
	|
	|-RVA: 0x4796110 Offset: 0x4792110 VA: 0x4796110
	|-BinaryStorageBuffer.Writer.Write<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public uint Write<T>(uint offset, T[] values, bool hashElements = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47963D4 Offset: 0x47923D4 VA: 0x47963D4
	|-BinaryStorageBuffer.Writer.Write<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public uint WriteObjects<T>(IEnumerable<T> objs, bool serizalizeTypeData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x479679C Offset: 0x479279C VA: 0x479679C
	|-BinaryStorageBuffer.Writer.WriteObjects<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x861A380 Offset: 0x8616380 VA: 0x861A380
	public uint WriteObject(object obj, bool serializeTypeData) { }

	// RVA: 0x8618A74 Offset: 0x8614A74 VA: 0x8618A74
	public uint WriteString(string str, char sep = '\x0') { }

	// RVA: 0x861A704 Offset: 0x8616704 VA: 0x861A704
	private uint WriteStringInternal(string val, Encoding enc) { }

	// RVA: 0x861A760 Offset: 0x8616760 VA: 0x861A760
	public byte[] SerializeToByteArray() { }

	// RVA: 0x861A9AC Offset: 0x86169AC VA: 0x861A9AC
	public uint SerializeToStream(Stream str) { }

	// RVA: 0x861AB2C Offset: 0x8616B2C VA: 0x861AB2C
	private static bool IsUnicode(string str) { }

	// RVA: 0x861A664 Offset: 0x8616664 VA: 0x861A664
	private uint WriteAutoEncodedString(string str) { }

	// RVA: 0x861AB98 Offset: 0x8616B98 VA: 0x861AB98
	private uint WriteUnicodeString(string str) { }

	// RVA: 0x861ABD0 Offset: 0x8616BD0 VA: 0x861ABD0
	private static uint ComputeStringSize(string str, out bool isUnicode) { }

	// RVA: 0x861AC28 Offset: 0x8616C28 VA: 0x861AC28
	private uint RecurseDynamicStringParts(BinaryStorageBuffer.Writer.StringParts[] parts, int index, char sep, uint minSize) { }

	// RVA: 0x861A4C8 Offset: 0x86164C8 VA: 0x861A4C8
	private uint WriteDynamicString(string str, char sep) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal class BinaryStorageBuffer // TypeDefIndex: 24991
{
	// Fields
	private const uint kUnicodeStringFlag = 2147483648;
	private const uint kDynamicStringFlag = 1073741824;
	private const uint kClearFlagsMask = 1073741823;

	// Methods

	// RVA: 0x861788C Offset: 0x861388C VA: 0x861788C
	private static void ComputeHash(void* pData, ulong size, Hash128* hash) { }

	// RVA: 0x86178A4 Offset: 0x86138A4 VA: 0x86178A4
	private static void AddSerializationAdapter(Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> serializationAdapters, BinaryStorageBuffer.ISerializationAdapter adapter, bool forceOverride = False) { }

	// RVA: 0x8617EA0 Offset: 0x8613EA0 VA: 0x8617EA0
	private static bool GetSerializationAdapter(Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> serializationAdapters, Type t, out BinaryStorageBuffer.ISerializationAdapter adapter) { }

	// RVA: 0x86180E8 Offset: 0x86140E8 VA: 0x86180E8
	public void .ctor() { }
}

// Namespace: 
public struct LRUCache.Entry<TKey, TValue> : IEquatable<LRUCache.Entry<TKey, TValue>> // TypeDefIndex: 24992
{
	// Fields
	public LinkedListNode<TKey> lruNode; // 0x0
	public TValue Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(LRUCache.Entry<TKey, TValue> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B79EC Offset: 0x60B39EC VA: 0x60B79EC
	|-LRUCache.Entry<uint, object>.Equals
	|
	|-RVA: 0x60B7BDC Offset: 0x60B3BDC VA: 0x60B7BDC
	|-LRUCache.Entry<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60B7A54 Offset: 0x60B3A54 VA: 0x60B7A54
	|-LRUCache.Entry<uint, object>.GetHashCode
	|
	|-RVA: 0x60B7DBC Offset: 0x60B3DBC VA: 0x60B7DBC
	|-LRUCache.Entry<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
internal struct LRUCache<TKey, TValue> // TypeDefIndex: 24993
{
	// Fields
	private int entryLimit; // 0x0
	private Dictionary<TKey, LRUCache.Entry<TKey, TValue>> cache; // 0x0
	private LinkedList<TKey> lru; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int limit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B08404 Offset: 0x4B04404 VA: 0x4B08404
	|-LRUCache<uint, object>..ctor
	|
	|-RVA: 0x4B087A8 Offset: 0x4B047A8 VA: 0x4B087A8
	|-LRUCache<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey id, TValue obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B084E8 Offset: 0x4B044E8 VA: 0x4B084E8
	|-LRUCache<uint, object>.TryAdd
	|
	|-RVA: 0x4B088F4 Offset: 0x4B048F4 VA: 0x4B088F4
	|-LRUCache<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryGet(TKey offset, out TValue val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0868C Offset: 0x4B0468C VA: 0x4B0868C
	|-LRUCache<uint, object>.TryGet
	|
	|-RVA: 0x4B08FE4 Offset: 0x4B04FE4 VA: 0x4B08FE4
	|-LRUCache<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGet
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
[ExecuteInEditMode]
public abstract class ComponentSingleton<T> : MonoBehaviour // TypeDefIndex: 24994
{
	// Fields
	private static T s_Instance; // 0x0

	// Properties
	public static bool Exists { get; }
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_Exists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9A00 Offset: 0x5CA5A00 VA: 0x5CA9A00
	|-ComponentSingleton<object>.get_Exists
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9A8C Offset: 0x5CA5A8C VA: 0x5CA9A8C
	|-ComponentSingleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	private static T FindInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9BEC Offset: 0x5CA5BEC VA: 0x5CA9BEC
	|-ComponentSingleton<object>.FindInstance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual string GetGameObjectName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9C54 Offset: 0x5CA5C54 VA: 0x5CA9C54
	|-ComponentSingleton<object>.GetGameObjectName
	*/

	// RVA: -1 Offset: -1
	private static T CreateNewSingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9CD0 Offset: 0x5CA5CD0 VA: 0x5CA9CD0
	|-ComponentSingleton<object>.CreateNewSingleton
	*/

	// RVA: -1 Offset: -1
	private void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA9DF8 Offset: 0x5CA5DF8 VA: 0x5CA9DF8
	|-ComponentSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	public static void DestroySingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CAA040 Offset: 0x5CA6040 VA: 0x5CAA040
	|-ComponentSingleton<object>.DestroySingleton
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CAA11C Offset: 0x5CA611C VA: 0x5CAA11C
	|-ComponentSingleton<object>..ctor
	*/
}

// Namespace: 
private struct DelayedActionManager.DelegateInfo // TypeDefIndex: 24995
{
	// Fields
	private static int s_Id; // 0x0
	private int m_Id; // 0x0
	private Delegate m_Delegate; // 0x8
	private object[] m_Target; // 0x10
	[CompilerGenerated]
	private float <InvocationTime>k__BackingField; // 0x18

	// Properties
	public float InvocationTime { get; set; }

	// Methods

	// RVA: 0x861B268 Offset: 0x8617268 VA: 0x861B268
	public void .ctor(Delegate d, float invocationTime, object[] p) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x861BCF4 Offset: 0x8617CF4 VA: 0x861BCF4
	public float get_InvocationTime() { }

	[CompilerGenerated]
	// RVA: 0x861BCFC Offset: 0x8617CFC VA: 0x861BCFC
	private void set_InvocationTime(float value) { }

	// RVA: 0x861BD04 Offset: 0x8617D04 VA: 0x861BD04 Slot: 3
	public override string ToString() { }

	// RVA: 0x861B8AC Offset: 0x86178AC VA: 0x861B8AC
	public void Invoke() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal class DelayedActionManager : ComponentSingleton<DelayedActionManager> // TypeDefIndex: 24996
{
	// Fields
	private List<DelayedActionManager.DelegateInfo>[] m_Actions; // 0x20
	private LinkedList<DelayedActionManager.DelegateInfo> m_DelayedActions; // 0x28
	private Stack<LinkedListNode<DelayedActionManager.DelegateInfo>> m_NodeCache; // 0x30
	private int m_CollectionIndex; // 0x38
	private bool m_DestroyOnCompletion; // 0x3C

	// Properties
	public static bool IsActive { get; }

	// Methods

	// RVA: 0x861AE24 Offset: 0x8616E24 VA: 0x861AE24
	private LinkedListNode<DelayedActionManager.DelegateInfo> GetNode(ref DelayedActionManager.DelegateInfo del) { }

	// RVA: 0x861AF2C Offset: 0x8616F2C VA: 0x861AF2C
	public static void Clear() { }

	// RVA: 0x861AFA0 Offset: 0x8616FA0 VA: 0x861AFA0
	private void DestroyWhenComplete() { }

	// RVA: 0x861AFAC Offset: 0x8616FAC VA: 0x861AFAC
	public static void AddAction(Delegate action, float delay = 0, object[] parameters) { }

	// RVA: 0x861B020 Offset: 0x8617020 VA: 0x861B020
	private void AddActionInternal(Delegate action, float delay, object[] parameters) { }

	// RVA: 0x861B300 Offset: 0x8617300 VA: 0x861B300
	public static bool get_IsActive() { }

	// RVA: 0x861B41C Offset: 0x861741C VA: 0x861B41C
	public static bool Wait(float timeout = 0, float timeAdvanceAmount = 0) { }

	// RVA: 0x861B890 Offset: 0x8617890 VA: 0x861B890
	private void LateUpdate() { }

	// RVA: 0x861B57C Offset: 0x861757C VA: 0x861B57C
	private void InternalLateUpdate(float t) { }

	// RVA: 0x861BA40 Offset: 0x8617A40 VA: 0x861BA40
	private void OnApplicationQuit() { }

	// RVA: 0x861BAF4 Offset: 0x8617AF4 VA: 0x861BAF4
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal interface IOperationCacheKey : IEquatable<IOperationCacheKey> // TypeDefIndex: 24997
{}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class IdCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 24998
{
	// Fields
	public string ID; // 0x10
	public Type locationType; // 0x18

	// Methods

	// RVA: 0x861C0C4 Offset: 0x86180C4 VA: 0x861C0C4
	public void .ctor(Type locType, string id) { }

	// RVA: 0x861C108 Offset: 0x8618108 VA: 0x861C108
	private bool Equals(IdCacheKey other) { }

	// RVA: 0x861C1A8 Offset: 0x86181A8 VA: 0x861C1A8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x861C200 Offset: 0x8618200 VA: 0x861C200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x861C264 Offset: 0x8618264 VA: 0x861C264 Slot: 4
	public bool Equals(IOperationCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class LocationCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 24999
{
	// Fields
	private readonly IResourceLocation m_Location; // 0x10
	private readonly Type m_DesiredType; // 0x18

	// Methods

	// RVA: 0x8613A40 Offset: 0x860FA40 VA: 0x8613A40
	public void .ctor(IResourceLocation location, Type desiredType) { }

	// RVA: 0x861C2C8 Offset: 0x86182C8 VA: 0x861C2C8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x861C374 Offset: 0x8618374 VA: 0x861C374 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x861C434 Offset: 0x8618434 VA: 0x861C434 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x861C3D8 Offset: 0x86183D8 VA: 0x861C3D8
	private bool Equals(LocationCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class DependenciesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 25000
{
	// Fields
	private readonly IList<IResourceLocation> m_Dependencies; // 0x10
	private readonly int m_DependenciesHash; // 0x18

	// Methods

	// RVA: 0x8614528 Offset: 0x8610528 VA: 0x8614528
	public void .ctor(IList<IResourceLocation> dependencies, int dependenciesHash) { }

	// RVA: 0x861C78C Offset: 0x861878C VA: 0x861C78C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x861C794 Offset: 0x8618794 VA: 0x861C794 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x861C84C Offset: 0x861884C VA: 0x861C84C Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x861C824 Offset: 0x8618824 VA: 0x861C824
	private bool Equals(DependenciesCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class AsyncOpHandlesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 25001
{
	// Fields
	private readonly HashSet<AsyncOperationHandle> m_Handles; // 0x10

	// Methods

	// RVA: 0x8614498 Offset: 0x8610498 VA: 0x8614498
	public void .ctor(IList<AsyncOperationHandle> handles) { }

	// RVA: 0x861CB68 Offset: 0x8618B68 VA: 0x861CB68 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x861CB88 Offset: 0x8618B88 VA: 0x861CB88 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x861CC68 Offset: 0x8618C68 VA: 0x861CC68 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x861CBEC Offset: 0x8618BEC VA: 0x861CBEC
	private bool Equals(AsyncOpHandlesCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal static class LocationUtils // TypeDefIndex: 25002
{
	// Methods

	// RVA: 0x861C498 Offset: 0x8618498 VA: 0x861C498
	public static bool LocationEquals(IResourceLocation loc1, IResourceLocation loc2) { }

	// RVA: 0x861C8DC Offset: 0x86188DC VA: 0x861C8DC
	public static bool DependenciesEqual(IList<IResourceLocation> deps1, IList<IResourceLocation> deps2) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal class PlatformUtilities // TypeDefIndex: 25003
{
	// Methods

	// RVA: 0x861CCCC Offset: 0x8618CCC VA: 0x861CCCC
	internal static bool PlatformUsesMultiThreading(RuntimePlatform platform) { }

	// RVA: 0x861CCD8 Offset: 0x8618CD8 VA: 0x861CCD8
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public interface IInitializableObject // TypeDefIndex: 25004
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Initialize(string id, string data);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data);
}

// Namespace: UnityEngine.ResourceManagement.Util
public interface IObjectInitializationDataProvider // TypeDefIndex: 25005
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ObjectInitializationData CreateObjectInitializationData();
}

// Namespace: UnityEngine.ResourceManagement.Util
public interface IAllocationStrategy // TypeDefIndex: 25006
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object New(Type type, int typeHash);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Release(int typeHash, object obj);
}

// Namespace: UnityEngine.ResourceManagement.Util
public class DefaultAllocationStrategy : IAllocationStrategy // TypeDefIndex: 25007
{
	// Methods

	// RVA: 0x861CCE0 Offset: 0x8618CE0 VA: 0x861CCE0 Slot: 4
	public object New(Type type, int typeHash) { }

	// RVA: 0x861CCEC Offset: 0x8618CEC VA: 0x861CCEC Slot: 5
	public void Release(int typeHash, object obj) { }

	// RVA: 0x861CCF0 Offset: 0x8618CF0 VA: 0x861CCF0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class LRUCacheAllocationStrategy : IAllocationStrategy // TypeDefIndex: 25008
{
	// Fields
	private int m_poolMaxSize; // 0x10
	private int m_poolInitialCapacity; // 0x14
	private int m_poolCacheMaxSize; // 0x18
	private List<List<object>> m_poolCache; // 0x20
	private Dictionary<int, List<object>> m_cache; // 0x28

	// Methods

	// RVA: 0x8611528 Offset: 0x860D528 VA: 0x8611528
	public void .ctor(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity) { }

	// RVA: 0x861CCF8 Offset: 0x8618CF8 VA: 0x861CCF8
	private List<object> GetPool() { }

	// RVA: 0x861CDE8 Offset: 0x8618DE8 VA: 0x861CDE8
	private void ReleasePool(List<object> pool) { }

	// RVA: 0x861CEB8 Offset: 0x8618EB8 VA: 0x861CEB8 Slot: 4
	public object New(Type type, int typeHash) { }

	// RVA: 0x861CFF4 Offset: 0x8618FF4 VA: 0x861CFF4 Slot: 5
	public void Release(int typeHash, object obj) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class SerializedTypeRestrictionAttribute : Attribute // TypeDefIndex: 25009
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x861D134 Offset: 0x8619134 VA: 0x861D134
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class LinkedListNodeCache<T> // TypeDefIndex: 25010
{
	// Fields
	private int m_NodesCreated; // 0x0
	private LinkedList<T> m_NodeCache; // 0x0

	// Properties
	internal int CreatedNodeCount { get; }
	internal int CachedNodeCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17874 Offset: 0x4B13874 VA: 0x4B17874
	|-LinkedListNodeCache<object>.Acquire
	|
	|-RVA: 0x4B17ACC Offset: 0x4B13ACC VA: 0x4B17ACC
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B178FC Offset: 0x4B138FC VA: 0x4B178FC
	|-LinkedListNodeCache<object>.Release
	|
	|-RVA: 0x4B17C80 Offset: 0x4B13C80 VA: 0x4B17C80
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	internal int get_CreatedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B1799C Offset: 0x4B1399C VA: 0x4B1799C
	|-LinkedListNodeCache<object>.get_CreatedNodeCount
	|
	|-RVA: 0x4B17DE4 Offset: 0x4B13DE4 VA: 0x4B17DE4
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.get_CreatedNodeCount
	*/

	// RVA: -1 Offset: -1
	internal int get_CachedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B179A4 Offset: 0x4B139A4 VA: 0x4B179A4
	|-LinkedListNodeCache<object>.get_CachedNodeCount
	|
	|-RVA: 0x4B17DEC Offset: 0x4B13DEC VA: 0x4B17DEC
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.get_CachedNodeCount
	*/

	// RVA: -1 Offset: -1
	internal void set_CachedNodeCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B179BC Offset: 0x4B139BC VA: 0x4B179BC
	|-LinkedListNodeCache<object>.set_CachedNodeCount
	|
	|-RVA: 0x4B17E0C Offset: 0x4B13E0C VA: 0x4B17E0C
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.set_CachedNodeCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17AC4 Offset: 0x4B13AC4 VA: 0x4B17AC4
	|-LinkedListNodeCache<object>..ctor
	|
	|-RVA: 0x4B1800C Offset: 0x4B1400C VA: 0x4B1800C
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
internal static class GlobalLinkedListNodeCache<T> // TypeDefIndex: 25011
{
	// Fields
	private static LinkedListNodeCache<T> m_globalCache; // 0x0

	// Properties
	public static bool CacheExists { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_CacheExists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C654 Offset: 0x4908654 VA: 0x490C654
	|-GlobalLinkedListNodeCache<object>.get_CacheExists
	|
	|-RVA: 0x490CA9C Offset: 0x4908A9C VA: 0x490CA9C
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.get_CacheExists
	*/

	// RVA: -1 Offset: -1
	public static void SetCacheSize(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C694 Offset: 0x4908694 VA: 0x490C694
	|-GlobalLinkedListNodeCache<object>.SetCacheSize
	|
	|-RVA: 0x490CADC Offset: 0x4908ADC VA: 0x490CADC
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.SetCacheSize
	*/

	// RVA: -1 Offset: -1
	public static LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C7EC Offset: 0x49087EC VA: 0x490C7EC
	|-GlobalLinkedListNodeCache<object>.Acquire
	|
	|-RVA: 0x490CCAC Offset: 0x4908CAC VA: 0x490CCAC
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public static void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C944 Offset: 0x4908944 VA: 0x490C944
	|-GlobalLinkedListNodeCache<object>.Release
	|
	|-RVA: 0x490CF84 Offset: 0x4908F84 VA: 0x490CF84
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.Release
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
[Serializable]
public struct SerializedType // TypeDefIndex: 25012
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_assemblyName")]
	private string m_AssemblyName; // 0x0
	[SerializeField]
	[FormerlySerializedAs("m_className")]
	private string m_ClassName; // 0x8
	private Type m_CachedType; // 0x10
	[CompilerGenerated]
	private bool <ValueChanged>k__BackingField; // 0x18

	// Properties
	public string AssemblyName { get; }
	public string ClassName { get; }
	public Type Value { get; set; }
	public bool ValueChanged { get; set; }

	// Methods

	// RVA: 0x861D13C Offset: 0x861913C VA: 0x861D13C
	public string get_AssemblyName() { }

	// RVA: 0x861D144 Offset: 0x8619144 VA: 0x861D144
	public string get_ClassName() { }

	// RVA: 0x861D14C Offset: 0x861914C VA: 0x861D14C Slot: 3
	public override string ToString() { }

	// RVA: 0x861D200 Offset: 0x8619200 VA: 0x861D200
	public Type get_Value() { }

	// RVA: 0x861D404 Offset: 0x8619404 VA: 0x861D404
	public void set_Value(Type value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x861D4F4 Offset: 0x86194F4 VA: 0x861D4F4
	public bool get_ValueChanged() { }

	[CompilerGenerated]
	// RVA: 0x861D4FC Offset: 0x86194FC VA: 0x861D4FC
	public void set_ValueChanged(bool value) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
[Serializable]
public struct ObjectInitializationData // TypeDefIndex: 25013
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_id")]
	private string m_Id; // 0x0
	[SerializeField]
	[FormerlySerializedAs("m_objectType")]
	private SerializedType m_ObjectType; // 0x8
	[FormerlySerializedAs("m_data")]
	[SerializeField]
	private string m_Data; // 0x28

	// Properties
	public string Id { get; }
	public SerializedType ObjectType { get; }
	public string Data { get; }

	// Methods

	// RVA: 0x861D508 Offset: 0x8619508 VA: 0x861D508
	public string get_Id() { }

	// RVA: 0x861D510 Offset: 0x8619510 VA: 0x861D510
	public SerializedType get_ObjectType() { }

	// RVA: 0x861D520 Offset: 0x8619520 VA: 0x861D520
	public string get_Data() { }

	// RVA: 0x861D528 Offset: 0x8619528 VA: 0x861D528 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	public TObject CreateInstance<TObject>(string idOverride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4686858 Offset: 0x4682858 VA: 0x4686858
	|-ObjectInitializationData.CreateInstance<object>
	|
	|-RVA: 0x4686A7C Offset: 0x4682A7C VA: 0x4686A7C
	|-ObjectInitializationData.CreateInstance<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x861D5C0 Offset: 0x86195C0 VA: 0x861D5C0
	public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public static class ResourceManagerConfig // TypeDefIndex: 25014
{
	// Methods

	// RVA: 0x861D810 Offset: 0x8619810 VA: 0x861D810
	public static bool ExtractKeyAndSubKey(object keyObj, out string mainKey, out string subKey) { }

	// RVA: 0x861D920 Offset: 0x8619920 VA: 0x861D920
	public static bool IsPathRemote(string path) { }

	// RVA: 0x861D984 Offset: 0x8619984 VA: 0x861D984
	public static string StripQueryParameters(string path) { }

	// RVA: 0x861D9C8 Offset: 0x86199C8 VA: 0x861D9C8
	public static bool ShouldPathUseWebRequest(string path) { }

	// RVA: 0x861DA44 Offset: 0x8619A44 VA: 0x861DA44
	private static bool PlatformCanLoadLocallyFromUrlPath() { }

	// RVA: 0x861DB68 Offset: 0x8619B68 VA: 0x861DB68
	public static Array CreateArrayResult(Type type, Object[] allAssets) { }

	// RVA: -1 Offset: -1
	public static TObject CreateArrayResult<TObject>(Object[] allAssets) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C31EC Offset: 0x46BF1EC VA: 0x46C31EC
	|-ResourceManagerConfig.CreateArrayResult<object>
	*/

	// RVA: 0x861DD20 Offset: 0x8619D20 VA: 0x861DD20
	public static IList CreateListResult(Type type, Object[] allAssets) { }

	// RVA: -1 Offset: -1
	public static TObject CreateListResult<TObject>(Object[] allAssets) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C32D0 Offset: 0x46BF2D0 VA: 0x46C32D0
	|-ResourceManagerConfig.CreateListResult<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool IsInstance<T1, T2>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46C33E4 Offset: 0x46BF3E4 VA: 0x46C33E4
	|-ResourceManagerConfig.IsInstance<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
[Flags]
internal enum BundleSource // TypeDefIndex: 25015
{
	// Fields
	public int value__; // 0x0
	public const BundleSource None = 0;
	public const BundleSource Local = 1;
	public const BundleSource Cache = 2;
	public const BundleSource Download = 4;
}

// Namespace: UnityEngine.ResourceManagement.Util
public class UnityWebRequestUtilities // TypeDefIndex: 25016
{
	// Methods

	// RVA: 0x861DEEC Offset: 0x8619EEC VA: 0x861DEEC
	public static bool RequestHasErrors(UnityWebRequest webReq, out UnityWebRequestResult result) { }

	// RVA: 0x8616D34 Offset: 0x8612D34 VA: 0x8616D34
	public static bool IsAssetBundleDownloaded(UnityWebRequestAsyncOperation op) { }

	// RVA: 0x861E14C Offset: 0x861A14C VA: 0x861E14C
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class UnityWebRequestResult // TypeDefIndex: 25017
{
	// Fields
	[CompilerGenerated]
	private string <Error>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly long <ResponseCode>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly UnityWebRequest.Result <Result>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <Method>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Url>k__BackingField; // 0x30

	// Properties
	public string Error { get; set; }
	public long ResponseCode { get; }
	public UnityWebRequest.Result Result { get; }
	public string Method { get; }
	public string Url { get; }

	// Methods

	// RVA: 0x861E02C Offset: 0x861A02C VA: 0x861E02C
	public void .ctor(UnityWebRequest request) { }

	// RVA: 0x861E154 Offset: 0x861A154 VA: 0x861E154 Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	// RVA: 0x861E2D4 Offset: 0x861A2D4 VA: 0x861E2D4
	public string get_Error() { }

	[CompilerGenerated]
	// RVA: 0x861E2DC Offset: 0x861A2DC VA: 0x861E2DC
	public void set_Error(string value) { }

	[CompilerGenerated]
	// RVA: 0x861E2E4 Offset: 0x861A2E4 VA: 0x861E2E4
	public long get_ResponseCode() { }

	[CompilerGenerated]
	// RVA: 0x861E2EC Offset: 0x861A2EC VA: 0x861E2EC
	public UnityWebRequest.Result get_Result() { }

	[CompilerGenerated]
	// RVA: 0x861E2F4 Offset: 0x861A2F4 VA: 0x861E2F4
	public string get_Method() { }

	[CompilerGenerated]
	// RVA: 0x861E2FC Offset: 0x861A2FC VA: 0x861E2FC
	public string get_Url() { }

	// RVA: 0x861E304 Offset: 0x861A304 VA: 0x861E304
	public bool ShouldRetryDownloadError() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
internal class DownloadOnlyLocation : LocationWrapper // TypeDefIndex: 25018
{
	// Methods

	// RVA: 0x861E5FC Offset: 0x861A5FC VA: 0x861E5FC
	public void .ctor(IResourceLocation location) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public enum AssetLoadMode // TypeDefIndex: 25019
{
	// Fields
	public int value__; // 0x0
	public const AssetLoadMode RequestedAssetAndDependencies = 0;
	public const AssetLoadMode AllPackedAssetsAndDependencies = 1;
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface IAssetBundleResource // TypeDefIndex: 25020
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AssetBundle GetAssetBundle();
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Serializable]
public class AssetBundleRequestOptions : ILocationSizeData // TypeDefIndex: 25021
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_hash")]
	private string m_Hash; // 0x10
	[SerializeField]
	[FormerlySerializedAs("m_crc")]
	private uint m_Crc; // 0x18
	[FormerlySerializedAs("m_timeout")]
	[SerializeField]
	private int m_Timeout; // 0x1C
	[SerializeField]
	[FormerlySerializedAs("m_chunkedTransfer")]
	private bool m_ChunkedTransfer; // 0x20
	[SerializeField]
	[FormerlySerializedAs("m_redirectLimit")]
	private int m_RedirectLimit; // 0x24
	[FormerlySerializedAs("m_retryCount")]
	[SerializeField]
	private int m_RetryCount; // 0x28
	[SerializeField]
	private string m_BundleName; // 0x30
	[SerializeField]
	private AssetLoadMode m_AssetLoadMode; // 0x38
	[SerializeField]
	private long m_BundleSize; // 0x40
	[SerializeField]
	private bool m_UseCrcForCachedBundles; // 0x48
	[SerializeField]
	private bool m_UseUWRForLocalBundles; // 0x49
	[SerializeField]
	private bool m_ClearOtherCachedVersionsWhenLoaded; // 0x4A

	// Properties
	public string Hash { get; set; }
	public uint Crc { get; set; }
	public int Timeout { get; set; }
	public bool ChunkedTransfer { get; set; }
	public int RedirectLimit { get; set; }
	public int RetryCount { get; set; }
	public string BundleName { get; set; }
	public AssetLoadMode AssetLoadMode { get; set; }
	public long BundleSize { get; set; }
	public bool UseCrcForCachedBundle { get; set; }
	public bool UseUnityWebRequestForLocalBundles { get; set; }
	public bool ClearOtherCachedVersionsWhenLoaded { get; set; }

	// Methods

	// RVA: 0x861E65C Offset: 0x861A65C VA: 0x861E65C
	public string get_Hash() { }

	// RVA: 0x861E664 Offset: 0x861A664 VA: 0x861E664
	public void set_Hash(string value) { }

	// RVA: 0x861E66C Offset: 0x861A66C VA: 0x861E66C
	public uint get_Crc() { }

	// RVA: 0x861E674 Offset: 0x861A674 VA: 0x861E674
	public void set_Crc(uint value) { }

	// RVA: 0x861E67C Offset: 0x861A67C VA: 0x861E67C
	public int get_Timeout() { }

	// RVA: 0x861E684 Offset: 0x861A684 VA: 0x861E684
	public void set_Timeout(int value) { }

	// RVA: 0x861E68C Offset: 0x861A68C VA: 0x861E68C
	public bool get_ChunkedTransfer() { }

	// RVA: 0x861E694 Offset: 0x861A694 VA: 0x861E694
	public void set_ChunkedTransfer(bool value) { }

	// RVA: 0x861E6A0 Offset: 0x861A6A0 VA: 0x861E6A0
	public int get_RedirectLimit() { }

	// RVA: 0x861E6B4 Offset: 0x861A6B4 VA: 0x861E6B4
	public void set_RedirectLimit(int value) { }

	// RVA: 0x861E6BC Offset: 0x861A6BC VA: 0x861E6BC
	public int get_RetryCount() { }

	// RVA: 0x861E6C4 Offset: 0x861A6C4 VA: 0x861E6C4
	public void set_RetryCount(int value) { }

	// RVA: 0x861E6CC Offset: 0x861A6CC VA: 0x861E6CC
	public string get_BundleName() { }

	// RVA: 0x861E6D4 Offset: 0x861A6D4 VA: 0x861E6D4
	public void set_BundleName(string value) { }

	// RVA: 0x861E6DC Offset: 0x861A6DC VA: 0x861E6DC
	public AssetLoadMode get_AssetLoadMode() { }

	// RVA: 0x861E6E4 Offset: 0x861A6E4 VA: 0x861E6E4
	public void set_AssetLoadMode(AssetLoadMode value) { }

	// RVA: 0x861E6EC Offset: 0x861A6EC VA: 0x861E6EC
	public long get_BundleSize() { }

	// RVA: 0x861E6F4 Offset: 0x861A6F4 VA: 0x861E6F4
	public void set_BundleSize(long value) { }

	// RVA: 0x861E6FC Offset: 0x861A6FC VA: 0x861E6FC
	public bool get_UseCrcForCachedBundle() { }

	// RVA: 0x861E704 Offset: 0x861A704 VA: 0x861E704
	public void set_UseCrcForCachedBundle(bool value) { }

	// RVA: 0x861E710 Offset: 0x861A710 VA: 0x861E710
	public bool get_UseUnityWebRequestForLocalBundles() { }

	// RVA: 0x861E718 Offset: 0x861A718 VA: 0x861E718
	public void set_UseUnityWebRequestForLocalBundles(bool value) { }

	// RVA: 0x861E724 Offset: 0x861A724 VA: 0x861E724
	public bool get_ClearOtherCachedVersionsWhenLoaded() { }

	// RVA: 0x861E72C Offset: 0x861A72C VA: 0x861E72C
	public void set_ClearOtherCachedVersionsWhenLoaded(bool value) { }

	// RVA: 0x861E738 Offset: 0x861A738 VA: 0x861E738 Slot: 5
	public virtual long ComputeSize(IResourceLocation location, ResourceManager resourceManager) { }

	// RVA: 0x861E880 Offset: 0x861A880 VA: 0x861E880
	public void .ctor() { }
}

// Namespace: 
public enum AssetBundleResource.LoadType // TypeDefIndex: 25022
{
	// Fields
	public int value__; // 0x0
	public const AssetBundleResource.LoadType None = 0;
	public const AssetBundleResource.LoadType Local = 1;
	public const AssetBundleResource.LoadType Web = 2;
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class AssetBundleResource : IAssetBundleResource, IUpdateReceiver // TypeDefIndex: 25023
{
	// Fields
	private AssetBundle m_AssetBundle; // 0x10
	private AsyncOperation m_RequestOperation; // 0x18
	internal WebRequestQueueOperation m_WebRequestQueueOperation; // 0x20
	internal ProvideHandle m_ProvideHandle; // 0x28
	internal AssetBundleRequestOptions m_Options; // 0x40
	private bool m_RequestCompletedCallbackCalled; // 0x48
	private int m_Retries; // 0x4C
	private BundleSource m_Source; // 0x50
	private long m_BytesToDownload; // 0x58
	private long m_DownloadedBytes; // 0x60
	private bool m_Completed; // 0x68
	private AssetBundleUnloadOperation m_UnloadOperation; // 0x70
	private const int k_WaitForWebRequestMainThreadSleep = 1;
	private string m_TransformedInternalId; // 0x78
	private AssetBundleRequest m_PreloadRequest; // 0x80
	private bool m_PreloadCompleted; // 0x88
	private ulong m_LastDownloadedByteCount; // 0x90
	private float m_TimeoutTimer; // 0x98
	private int m_TimeoutOverFrames; // 0x9C
	private int m_LastFrameCount; // 0xA0
	private float m_TimeSecSinceLastUpdate; // 0xA4

	// Properties
	private bool HasTimedOut { get; }
	internal long BytesToDownload { get; }

	// Methods

	// RVA: 0x861E8E0 Offset: 0x861A8E0 VA: 0x861E8E0
	private bool get_HasTimedOut() { }

	// RVA: 0x861E920 Offset: 0x861A920 VA: 0x861E920
	internal long get_BytesToDownload() { }

	// RVA: 0x861EA24 Offset: 0x861AA24 VA: 0x861EA24
	internal UnityWebRequest CreateWebRequest(IResourceLocation loc) { }

	// RVA: 0x861EA4C Offset: 0x861AA4C VA: 0x861EA4C
	internal UnityWebRequest CreateWebRequest(string url) { }

	// RVA: 0x861EDD4 Offset: 0x861ADD4 VA: 0x861EDD4
	public AssetBundleRequest GetAssetPreloadRequest() { }

	// RVA: 0x861EF24 Offset: 0x861AF24 VA: 0x861EF24
	private float PercentComplete() { }

	// RVA: 0x861EF3C Offset: 0x861AF3C VA: 0x861EF3C
	private DownloadStatus GetDownloadStatus() { }

	// RVA: 0x861EF08 Offset: 0x861AF08 VA: 0x861EF08 Slot: 4
	public AssetBundle GetAssetBundle() { }

	// RVA: 0x861EC94 Offset: 0x861AC94 VA: 0x861EC94
	private void AddBundleToProfiler(ContentStatus status, BundleSource source) { }

	// RVA: 0x861F724 Offset: 0x861B724 VA: 0x861F724
	private void RemoveBundleFromProfiler() { }

	// RVA: 0x861F790 Offset: 0x861B790 VA: 0x861F790
	private void OnUnloadOperationComplete(AsyncOperation op) { }

	// RVA: 0x861F9B8 Offset: 0x861B9B8 VA: 0x861F9B8
	public void Start(ProvideHandle provideHandle, AssetBundleUnloadOperation unloadOp) { }

	// RVA: 0x861FF24 Offset: 0x861BF24 VA: 0x861FF24
	private bool WaitForCompletionHandler() { }

	// RVA: 0x86209D4 Offset: 0x861C9D4 VA: 0x86209D4
	private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback) { }

	// RVA: 0x8620A34 Offset: 0x861CA34 VA: 0x8620A34
	public static void GetLoadInfo(ProvideHandle handle, out AssetBundleResource.LoadType loadType, out string path) { }

	// RVA: 0x8620A64 Offset: 0x861CA64 VA: 0x8620A64
	internal static void GetLoadInfo(IResourceLocation location, ResourceManager resourceManager, out AssetBundleResource.LoadType loadType, out string path) { }

	// RVA: 0x861F7B0 Offset: 0x861B7B0 VA: 0x861F7B0
	private void BeginOperation() { }

	// RVA: 0x8620CDC Offset: 0x861CCDC VA: 0x8620CDC
	private void LoadLocalBundle() { }

	// RVA: 0x8620DAC Offset: 0x861CDAC VA: 0x8620DAC
	internal WebRequestQueueOperation EnqueueWebRequest(string internalId) { }

	// RVA: 0x8620EBC Offset: 0x861CEBC VA: 0x8620EBC
	internal void AddBeginWebRequestHandler(WebRequestQueueOperation webRequestQueueOperation) { }

	// RVA: 0x8620FDC Offset: 0x861CFDC VA: 0x8620FDC
	private void BeginWebRequestOperation(AsyncOperation asyncOp) { }

	// RVA: 0x86210F0 Offset: 0x861D0F0 VA: 0x86210F0 Slot: 5
	public void Update(float unscaledDeltaTime) { }

	// RVA: 0x862092C Offset: 0x861C92C VA: 0x862092C
	private void LocalRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x8621254 Offset: 0x861D254 VA: 0x8621254
	private void CompleteBundleLoad(AssetBundle bundle) { }

	// RVA: 0x86202CC Offset: 0x861C2CC VA: 0x86202CC
	private void WebRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x86213B0 Offset: 0x861D3B0 VA: 0x86213B0
	public bool Unload(out AssetBundleUnloadOperation unloadOp) { }

	// RVA: 0x8621494 Offset: 0x861D494 VA: 0x8621494
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x86214A4 Offset: 0x861D4A4 VA: 0x86214A4
	private void <GetAssetPreloadRequest>b__28_0(AsyncOperation operation) { }

	[CompilerGenerated]
	// RVA: 0x86214B0 Offset: 0x861D4B0 VA: 0x86214B0
	private void <AddBeginWebRequestHandler>b__43_0(UnityWebRequestAsyncOperation asyncOp) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AssetBundleProvider.<>c__DisplayClass12_0 // TypeDefIndex: 25024
{
	// Fields
	public IResourceLocation location; // 0x10

	// Methods

	// RVA: 0x8621D48 Offset: 0x861DD48 VA: 0x8621D48
	public void .ctor() { }

	// RVA: 0x8621E90 Offset: 0x861DE90 VA: 0x8621E90
	internal void <Release>b__0(AsyncOperation op) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("AssetBundle Provider")]
public class AssetBundleProvider : ResourceProviderBase // TypeDefIndex: 25025
{
	// Fields
	internal static Dictionary<string, AssetBundleUnloadOperation> m_UnloadingBundles; // 0x0

	// Properties
	protected internal static Dictionary<string, AssetBundleUnloadOperation> UnloadingBundles { get; set; }
	internal static int UnloadingAssetBundleCount { get; }
	internal static int AssetBundleCount { get; }

	// Methods

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x86214B4 Offset: 0x861D4B4 VA: 0x86214B4
	private static void Init() { }

	// RVA: 0x862155C Offset: 0x861D55C VA: 0x862155C
	protected internal static Dictionary<string, AssetBundleUnloadOperation> get_UnloadingBundles() { }

	// RVA: 0x86215B4 Offset: 0x861D5B4 VA: 0x86215B4
	internal static void set_UnloadingBundles(Dictionary<string, AssetBundleUnloadOperation> value) { }

	// RVA: 0x862161C Offset: 0x861D61C VA: 0x862161C
	internal static int get_UnloadingAssetBundleCount() { }

	// RVA: 0x8621694 Offset: 0x861D694 VA: 0x8621694
	internal static int get_AssetBundleCount() { }

	// RVA: 0x8621714 Offset: 0x861D714 VA: 0x8621714
	internal static void WaitForAllUnloadingBundlesToComplete() { }

	// RVA: 0x8621810 Offset: 0x861D810 VA: 0x8621810 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }

	// RVA: 0x8621990 Offset: 0x861D990 VA: 0x8621990 Slot: 16
	public override Type GetDefaultType(IResourceLocation location) { }

	// RVA: 0x86219FC Offset: 0x861D9FC VA: 0x86219FC Slot: 15
	public override void Release(IResourceLocation location, object asset) { }

	// RVA: 0x8621D50 Offset: 0x861DD50 VA: 0x8621D50 Slot: 19
	internal virtual IOperationCacheKey CreateCacheKeyForLocation(ResourceManager rm, IResourceLocation location, Type desiredType) { }

	// RVA: 0x8621DE8 Offset: 0x861DDE8 VA: 0x8621DE8
	public void .ctor() { }

	// RVA: 0x8621DF8 Offset: 0x861DDF8 VA: 0x8621DF8
	private static void .cctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Sprites from Atlases Provider")]
public class AtlasSpriteProvider : ResourceProviderBase // TypeDefIndex: 25026
{
	// Methods

	// RVA: 0x8621F88 Offset: 0x861DF88 VA: 0x8621F88 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }

	// RVA: 0x862230C Offset: 0x861E30C VA: 0x862230C Slot: 15
	public override void Release(IResourceLocation location, object obj) { }

	// RVA: 0x8622398 Offset: 0x861E398 VA: 0x8622398
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Binary Asset Provider")]
internal class BinaryAssetProvider<TAdapter> : BinaryDataProvider // TypeDefIndex: 25027
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 19
	public override object Convert(Type type, byte[] data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B88DA0 Offset: 0x5B84DA0 VA: 0x5B88DA0
	|-BinaryAssetProvider<__Il2CppFullySharedGenericType>.Convert
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5B88F34 Offset: 0x5B84F34 VA: 0x5B88F34
	|-BinaryAssetProvider<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
internal class BinaryDataProvider.InternalOp // TypeDefIndex: 25028
{
	// Fields
	private BinaryDataProvider m_Provider; // 0x10
	private UnityWebRequestAsyncOperation m_RequestOperation; // 0x18
	private WebRequestQueueOperation m_RequestQueueOperation; // 0x20
	private ProvideHandle m_PI; // 0x28
	private bool m_IgnoreFailures; // 0x40
	private bool m_Complete; // 0x41
	private int m_Timeout; // 0x44

	// Methods

	// RVA: 0x8622910 Offset: 0x861E910 VA: 0x8622910
	private float GetPercentComplete() { }

	// RVA: 0x8622464 Offset: 0x861E464 VA: 0x8622464
	public void Start(ProvideHandle provideHandle, BinaryDataProvider rawProvider) { }

	// RVA: 0x8622ACC Offset: 0x861EACC VA: 0x8622ACC
	private bool WaitForCompletionHandler() { }

	// RVA: 0x8622B40 Offset: 0x861EB40 VA: 0x8622B40
	private void RequestOperation_completed(AsyncOperation op) { }

	// RVA: 0x8622D04 Offset: 0x861ED04 VA: 0x8622D04
	protected void CompleteOperation(byte[] data, Exception exception) { }

	// RVA: 0x8622928 Offset: 0x861E928 VA: 0x8622928
	private object ConvertBytes(byte[] data) { }

	// RVA: 0x8622DA8 Offset: 0x861EDA8 VA: 0x8622DA8 Slot: 4
	protected virtual void SendWebRequest(string path) { }

	// RVA: 0x862245C Offset: 0x861E45C VA: 0x862245C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8623050 Offset: 0x861F050 VA: 0x8623050
	private void <SendWebRequest>b__13_0(UnityWebRequestAsyncOperation asyncOperation) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Binary Data Provider")]
internal class BinaryDataProvider : ResourceProviderBase // TypeDefIndex: 25029
{
	// Fields
	[CompilerGenerated]
	private bool <IgnoreFailures>k__BackingField; // 0x1C

	// Properties
	public bool IgnoreFailures { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x86223A0 Offset: 0x861E3A0 VA: 0x86223A0
	public bool get_IgnoreFailures() { }

	[CompilerGenerated]
	// RVA: 0x86223A8 Offset: 0x861E3A8 VA: 0x86223A8
	public void set_IgnoreFailures(bool value) { }

	// RVA: 0x86223B4 Offset: 0x861E3B4 VA: 0x86223B4 Slot: 19
	public virtual object Convert(Type type, byte[] data) { }

	// RVA: 0x86223BC Offset: 0x861E3BC VA: 0x86223BC Slot: 17
	public override void Provide(ProvideHandle provideHandle) { }

	// RVA: 0x8622908 Offset: 0x861E908 VA: 0x8622908
	public void .ctor() { }
}

// Namespace: 
internal class BundledAssetProvider.InternalOp // TypeDefIndex: 25030
{
	// Fields
	private AssetBundle m_AssetBundle; // 0x10
	private AssetBundleRequest m_PreloadRequest; // 0x18
	private AssetBundleRequest m_RequestOperation; // 0x20
	private object m_Result; // 0x28
	private ProvideHandle m_ProvideHandle; // 0x30
	private string subObjectName; // 0x48

	// Methods

	// RVA: -1 Offset: -1
	internal static T LoadBundleFromDependecies<T>(IList<object> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4796C0C Offset: 0x4792C0C VA: 0x4796C0C
	|-BundledAssetProvider.InternalOp.LoadBundleFromDependecies<object>
	*/

	// RVA: 0x8623190 Offset: 0x861F190 VA: 0x8623190
	public void Start(ProvideHandle provideHandle) { }

	// RVA: 0x8623650 Offset: 0x861F650 VA: 0x8623650
	private void BeginAssetLoad() { }

	// RVA: 0x86241C8 Offset: 0x86201C8 VA: 0x86241C8
	private bool WaitForCompletionHandler() { }

	// RVA: 0x8623A34 Offset: 0x861FA34 VA: 0x8623A34
	private void ActionComplete(AsyncOperation obj) { }

	// RVA: 0x86242C8 Offset: 0x86202C8 VA: 0x86242C8
	private void GetArrayResult(Object[] allAssets) { }

	// RVA: 0x8624300 Offset: 0x8620300 VA: 0x8624300
	private void GetListResult(Object[] allAssets) { }

	// RVA: 0x8624338 Offset: 0x8620338 VA: 0x8624338
	private void GetAssetResult(Object asset) { }

	// RVA: 0x86243FC Offset: 0x86203FC VA: 0x86243FC
	private void GetAssetSubObjectResult(Object[] allAssets) { }

	// RVA: 0x86244E0 Offset: 0x86204E0 VA: 0x86244E0
	private void CompleteOperation() { }

	// RVA: 0x8624644 Offset: 0x8620644 VA: 0x8624644
	public float ProgressCallback() { }

	// RVA: 0x8623188 Offset: 0x861F188 VA: 0x8623188
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x862465C Offset: 0x862065C VA: 0x862465C
	private void <Start>b__7_0(AsyncOperation operation) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Assets from Bundles Provider")]
public class BundledAssetProvider : ResourceProviderBase // TypeDefIndex: 25031
{
	// Methods

	// RVA: 0x86230F8 Offset: 0x861F0F8 VA: 0x86230F8 Slot: 17
	public override void Provide(ProvideHandle provideHandle) { }

	// RVA: 0x8623594 Offset: 0x861F594 VA: 0x8623594
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct InstantiationParameters // TypeDefIndex: 25032
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Quaternion m_Rotation; // 0xC
	private Transform m_Parent; // 0x20
	private bool m_InstantiateInWorldPosition; // 0x28
	private bool m_SetPositionRotation; // 0x29

	// Properties
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Transform Parent { get; }
	public bool InstantiateInWorldPosition { get; }
	public bool SetPositionRotation { get; }

	// Methods

	// RVA: 0x8624660 Offset: 0x8620660 VA: 0x8624660
	public Vector3 get_Position() { }

	// RVA: 0x862466C Offset: 0x862066C VA: 0x862466C
	public Quaternion get_Rotation() { }

	// RVA: 0x8624678 Offset: 0x8620678 VA: 0x8624678
	public Transform get_Parent() { }

	// RVA: 0x8624680 Offset: 0x8620680 VA: 0x8624680
	public bool get_InstantiateInWorldPosition() { }

	// RVA: 0x8624688 Offset: 0x8620688 VA: 0x8624688
	public bool get_SetPositionRotation() { }

	// RVA: 0x8624690 Offset: 0x8620690 VA: 0x8624690
	public void .ctor(Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x862474C Offset: 0x862074C VA: 0x862474C
	public void .ctor(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: -1 Offset: -1
	public TObject Instantiate<TObject>(TObject source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4645F30 Offset: 0x4641F30 VA: 0x4645F30
	|-InstantiationParameters.Instantiate<object>
	*/
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface IInstanceProvider // TypeDefIndex: 25033
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReleaseInstance(ResourceManager resourceManager, GameObject instance);
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class InstanceProvider : IInstanceProvider // TypeDefIndex: 25034
{
	// Fields
	private Dictionary<GameObject, AsyncOperationHandle<GameObject>> m_InstanceObjectToPrefabHandle; // 0x10

	// Methods

	// RVA: 0x862477C Offset: 0x862077C VA: 0x862477C Slot: 4
	public GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters) { }

	// RVA: 0x8624864 Offset: 0x8620864 VA: 0x8624864 Slot: 5
	public void ReleaseInstance(ResourceManager resourceManager, GameObject instance) { }

	// RVA: 0x8624A68 Offset: 0x8620A68 VA: 0x8624A68
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public enum ProviderBehaviourFlags // TypeDefIndex: 25035
{
	// Fields
	public int value__; // 0x0
	public const ProviderBehaviourFlags None = 0;
	public const ProviderBehaviourFlags CanProvideWithFailedDependencies = 1;
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct ProvideHandle // TypeDefIndex: 25036
{
	// Fields
	private int m_Version; // 0x0
	private IGenericProviderOperation m_InternalOp; // 0x8
	private ResourceManager m_ResourceManager; // 0x10

	// Properties
	internal bool IsValid { get; }
	internal IGenericProviderOperation InternalOp { get; }
	public ResourceManager ResourceManager { get; }
	public Type Type { get; }
	public IResourceLocation Location { get; }
	public int DependencyCount { get; }

	// Methods

	// RVA: 0x8624AF0 Offset: 0x8620AF0 VA: 0x8624AF0
	internal void .ctor(ResourceManager rm, IGenericProviderOperation op) { }

	// RVA: 0x861F08C Offset: 0x861B08C VA: 0x861F08C
	internal bool get_IsValid() { }

	// RVA: 0x8624BC8 Offset: 0x8620BC8 VA: 0x8624BC8
	internal IGenericProviderOperation get_InternalOp() { }

	// RVA: 0x8624CC8 Offset: 0x8620CC8 VA: 0x8624CC8
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x8622A20 Offset: 0x861EA20 VA: 0x8622A20
	public Type get_Type() { }

	// RVA: 0x861E978 Offset: 0x861A978 VA: 0x861E978
	public IResourceLocation get_Location() { }

	// RVA: 0x8624CD0 Offset: 0x8620CD0 VA: 0x8624CD0
	public int get_DependencyCount() { }

	// RVA: -1 Offset: -1
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46AF408 Offset: 0x46AB408 VA: 0x46AF408
	|-ProvideHandle.GetDependency<object>
	|
	|-RVA: 0x46AF4C4 Offset: 0x46AB4C4 VA: 0x46AF4C4
	|-ProvideHandle.GetDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x862359C Offset: 0x861F59C VA: 0x862359C
	public void GetDependencies(IList<object> list) { }

	// RVA: 0x861FD08 Offset: 0x861BD08 VA: 0x861FD08
	public void SetProgressCallback(Func<float> callback) { }

	// RVA: 0x861FDBC Offset: 0x861BDBC VA: 0x861FDBC
	public void SetDownloadProgressCallbacks(Func<DownloadStatus> callback) { }

	// RVA: 0x861FE70 Offset: 0x861BE70 VA: 0x861FE70
	public void SetWaitForCompletionCallback(Func<bool> callback) { }

	// RVA: -1 Offset: -1
	public void Complete<T>(T result, bool status, Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46AF1C0 Offset: 0x46AB1C0 VA: 0x46AF1C0
	|-ProvideHandle.Complete<object>
	|
	|-RVA: 0x46AF294 Offset: 0x46AB294 VA: 0x46AF294
	|-ProvideHandle.Complete<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface IResourceProvider // TypeDefIndex: 25037
{
	// Properties
	public abstract string ProviderId { get; }
	public abstract ProviderBehaviourFlags BehaviourFlags { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ProviderId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type GetDefaultType(IResourceLocation location);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool CanProvide(Type type, IResourceLocation location);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Provide(ProvideHandle provideHandle);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release(IResourceLocation location, object asset);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ProviderBehaviourFlags get_BehaviourFlags();
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct SceneInstance // TypeDefIndex: 25038
{
	// Fields
	private Scene m_Scene; // 0x0
	internal AsyncOperation m_Operation; // 0x8

	// Properties
	public Scene Scene { get; set; }

	// Methods

	// RVA: 0x8624D7C Offset: 0x8620D7C VA: 0x8624D7C
	public Scene get_Scene() { }

	// RVA: 0x8624D84 Offset: 0x8620D84 VA: 0x8624D84
	internal void set_Scene(Scene value) { }

	[Obsolete("Activate() has been deprecated.  Please use ActivateAsync().")]
	// RVA: 0x8624D8C Offset: 0x8620D8C VA: 0x8624D8C
	public void Activate() { }

	// RVA: 0x8624DAC Offset: 0x8620DAC VA: 0x8624DAC
	public AsyncOperation ActivateAsync() { }

	// RVA: 0x8624DD8 Offset: 0x8620DD8 VA: 0x8624DD8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8624DF8 Offset: 0x8620DF8 VA: 0x8624DF8 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface ISceneProvider // TypeDefIndex: 25039
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle);
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
internal interface ISceneProvider2 : ISceneProvider // TypeDefIndex: 25040
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions);
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Extension]
internal static class SceneProviderExtensions // TypeDefIndex: 25041
{
	// Methods

	[Extension]
	// RVA: 0x8624EAC Offset: 0x8620EAC VA: 0x8624EAC
	public static AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider provider, ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("JSON Asset Provider")]
public class JsonAssetProvider : TextDataProvider // TypeDefIndex: 25042
{
	// Methods

	// RVA: 0x86250D4 Offset: 0x86210D4 VA: 0x86250D4 Slot: 19
	public override object Convert(Type type, string text) { }

	// RVA: 0x86250E0 Offset: 0x86210E0 VA: 0x86250E0
	public void .ctor() { }
}

// Namespace: 
internal class LegacyResourcesProvider.InternalOp // TypeDefIndex: 25043
{
	// Fields
	private ResourceRequest m_RequestOperation; // 0x10
	private ProvideHandle m_ProvideHandle; // 0x18

	// Methods

	// RVA: 0x8625500 Offset: 0x8621500 VA: 0x8625500
	public void Start(ProvideHandle provideHandle) { }

	// RVA: 0x86257D4 Offset: 0x86217D4 VA: 0x86257D4
	private bool WaitForCompletionHandler() { }

	// RVA: 0x8625928 Offset: 0x8621928 VA: 0x8625928
	private void AsyncOperationCompleted(AsyncOperation op) { }

	// RVA: 0x8625AA8 Offset: 0x8621AA8 VA: 0x8625AA8
	public float PercentComplete() { }

	// RVA: 0x86254F8 Offset: 0x86214F8 VA: 0x86254F8
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Assets from Legacy Resources")]
public class LegacyResourcesProvider : ResourceProviderBase // TypeDefIndex: 25044
{
	// Methods

	// RVA: 0x86250F0 Offset: 0x86210F0 VA: 0x86250F0 Slot: 17
	public override void Provide(ProvideHandle pi) { }

	// RVA: 0x86256A8 Offset: 0x86216A8 VA: 0x86256A8 Slot: 15
	public override void Release(IResourceLocation location, object asset) { }

	// RVA: 0x86257CC Offset: 0x86217CC VA: 0x86257CC
	public void .ctor() { }
}

// Namespace: 
private class ResourceProviderBase.BaseInitAsyncOp : AsyncOperationBase<bool> // TypeDefIndex: 25045
{
	// Fields
	private Func<bool> m_CallBack; // 0x98

	// Methods

	// RVA: 0x8625DF8 Offset: 0x8621DF8 VA: 0x8625DF8
	public void Init(Func<bool> callback) { }

	// RVA: 0x8625E00 Offset: 0x8621E00 VA: 0x8625E00 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x8625E70 Offset: 0x8621E70 VA: 0x8625E70 Slot: 28
	protected override void Execute() { }

	// RVA: 0x8625DA8 Offset: 0x8621DA8 VA: 0x8625DA8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ResourceProviderBase.<>c__DisplayClass10_0 // TypeDefIndex: 25046
{
	// Fields
	public ResourceProviderBase <>4__this; // 0x10
	public string id; // 0x18
	public string data; // 0x20

	// Methods

	// RVA: 0x8625DA0 Offset: 0x8621DA0 VA: 0x8625DA0
	public void .ctor() { }

	// RVA: 0x8625EF8 Offset: 0x8621EF8 VA: 0x8625EF8
	internal bool <InitializeAsync>b__0() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public abstract class ResourceProviderBase : IResourceProvider, IInitializableObject // TypeDefIndex: 25047
{
	// Fields
	protected string m_ProviderId; // 0x10
	protected ProviderBehaviourFlags m_BehaviourFlags; // 0x18

	// Properties
	public virtual string ProviderId { get; }
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.BehaviourFlags { get; }

	// Methods

	// RVA: 0x8625AC0 Offset: 0x8621AC0 VA: 0x8625AC0 Slot: 12
	public virtual string get_ProviderId() { }

	// RVA: 0x8625B24 Offset: 0x8621B24 VA: 0x8625B24 Slot: 13
	public virtual bool Initialize(string id, string data) { }

	// RVA: 0x8625B54 Offset: 0x8621B54 VA: 0x8625B54 Slot: 14
	public virtual bool CanProvide(Type t, IResourceLocation location) { }

	// RVA: 0x8625B94 Offset: 0x8621B94 VA: 0x8625B94 Slot: 3
	public override string ToString() { }

	// RVA: 0x8625BA0 Offset: 0x8621BA0 VA: 0x8625BA0 Slot: 15
	public virtual void Release(IResourceLocation location, object obj) { }

	// RVA: 0x8625BA4 Offset: 0x8621BA4 VA: 0x8625BA4 Slot: 16
	public virtual Type GetDefaultType(IResourceLocation location) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Provide(ProvideHandle provideHandle);

	// RVA: 0x8625C10 Offset: 0x8621C10 VA: 0x8625C10 Slot: 18
	public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data) { }

	// RVA: 0x8625DF0 Offset: 0x8621DF0 VA: 0x8625DF0 Slot: 9
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.get_BehaviourFlags() { }

	// RVA: 0x8621DF0 Offset: 0x861DDF0 VA: 0x8621DF0
	protected void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Serializable]
public class ProviderLoadRequestOptions // TypeDefIndex: 25048
{
	// Fields
	[SerializeField]
	private bool m_IgnoreFailures; // 0x10
	private int m_WebRequestTimeout; // 0x14

	// Properties
	public bool IgnoreFailures { get; set; }
	public int WebRequestTimeout { get; set; }

	// Methods

	// RVA: 0x8625F24 Offset: 0x8621F24 VA: 0x8625F24
	public ProviderLoadRequestOptions Copy() { }

	// RVA: 0x8625FA4 Offset: 0x8621FA4 VA: 0x8625FA4
	public bool get_IgnoreFailures() { }

	// RVA: 0x8625FAC Offset: 0x8621FAC VA: 0x8625FAC
	public void set_IgnoreFailures(bool value) { }

	// RVA: 0x8625FB8 Offset: 0x8621FB8 VA: 0x8625FB8
	public int get_WebRequestTimeout() { }

	// RVA: 0x8625FC0 Offset: 0x8621FC0 VA: 0x8625FC0
	public void set_WebRequestTimeout(int value) { }

	// RVA: 0x8625FC8 Offset: 0x8621FC8 VA: 0x8625FC8
	public void .ctor() { }
}

// Namespace: 
private class SceneProvider.SceneOp : AsyncOperationBase<SceneInstance>, IUpdateReceiver // TypeDefIndex: 25049
{
	// Fields
	private bool m_ActivateOnLoad; // 0xA0
	private SceneInstance m_Inst; // 0xA8
	private IResourceLocation m_Location; // 0xB8
	private LoadSceneParameters m_LoadSceneParameters; // 0xC0
	private int m_Priority; // 0xC8
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xD0
	private ResourceManager m_ResourceManager; // 0xE8
	private ISceneProvider2 m_provider; // 0xF0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x8626404 Offset: 0x8622404 VA: 0x8626404
	public void .ctor(ResourceManager rm, ISceneProvider2 provider) { }

	// RVA: 0x86268DC Offset: 0x86228DC VA: 0x86268DC Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x86269B8 Offset: 0x86229B8 VA: 0x86269B8
	public void Init(IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: 0x862647C Offset: 0x862247C VA: 0x862647C
	public void Init(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: 0x8626A30 Offset: 0x8622A30 VA: 0x8626A30 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x8626D70 Offset: 0x8622D70 VA: 0x8626D70 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x8626EC8 Offset: 0x8622EC8 VA: 0x8626EC8 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x8626F6C Offset: 0x8622F6C VA: 0x8626F6C Slot: 28
	protected override void Execute() { }

	// RVA: 0x86274C8 Offset: 0x86234C8 VA: 0x86274C8
	internal SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	// RVA: 0x86275BC Offset: 0x86235BC VA: 0x86275BC
	private AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneParameters loadSceneParameters) { }

	// RVA: 0x86278E0 Offset: 0x86238E0 VA: 0x86278E0 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x8627AAC Offset: 0x8623AAC VA: 0x8627AAC Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x8627B6C Offset: 0x8623B6C VA: 0x8627B6C Slot: 36
	private void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }
}

// Namespace: 
private class SceneProvider.UnloadSceneOp : AsyncOperationBase<SceneInstance> // TypeDefIndex: 25050
{
	// Fields
	private SceneInstance m_Instance; // 0xA0
	private AsyncOperationHandle<SceneInstance> m_sceneLoadHandle; // 0xB0
	private UnloadSceneOptions m_UnloadOptions; // 0xC8

	// Properties
	protected override float Progress { get; }

	// Methods

	// RVA: 0x8626818 Offset: 0x8622818 VA: 0x8626818
	public void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions options) { }

	// RVA: 0x8627D10 Offset: 0x8623D10 VA: 0x8627D10 Slot: 28
	protected override void Execute() { }

	// RVA: 0x86281AC Offset: 0x86241AC VA: 0x86281AC Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x86280BC Offset: 0x86240BC VA: 0x86280BC
	private void UnloadSceneCompleted(AsyncOperation obj) { }

	// RVA: 0x8628260 Offset: 0x8624260 VA: 0x8628260 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x86267D0 Offset: 0x86227D0 VA: 0x86267D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class SceneProvider : ISceneProvider2, ISceneProvider // TypeDefIndex: 25051
{
	// Methods

	// RVA: 0x8625FD0 Offset: 0x8621FD0 VA: 0x8625FD0 Slot: 5
	public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority) { }

	// RVA: 0x8626050 Offset: 0x8622050 VA: 0x8626050 Slot: 6
	public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	// RVA: 0x8626584 Offset: 0x8622584 VA: 0x8626584 Slot: 7
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x8626684 Offset: 0x8622684 VA: 0x8626684 Slot: 4
	private AsyncOperationHandle<SceneInstance> UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider2.ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }

	// RVA: 0x86268D4 Offset: 0x86228D4 VA: 0x86268D4
	public void .ctor() { }
}

// Namespace: 
internal class TextDataProvider.InternalOp // TypeDefIndex: 25052
{
	// Fields
	private TextDataProvider m_Provider; // 0x10
	private UnityWebRequestAsyncOperation m_RequestOperation; // 0x18
	private WebRequestQueueOperation m_RequestQueueOperation; // 0x20
	private ProvideHandle m_PI; // 0x28
	private bool m_IgnoreFailures; // 0x40
	private bool m_Complete; // 0x41
	private int m_Timeout; // 0x44

	// Methods

	// RVA: 0x8628778 Offset: 0x8624778 VA: 0x8628778
	private float GetPercentComplete() { }

	// RVA: 0x862836C Offset: 0x862436C VA: 0x862836C
	public void Start(ProvideHandle provideHandle, TextDataProvider rawProvider) { }

	// RVA: 0x8628888 Offset: 0x8624888 VA: 0x8628888
	private bool WaitForCompletionHandler() { }

	// RVA: 0x86288FC Offset: 0x86248FC VA: 0x86288FC
	private void RequestOperation_completed(AsyncOperation op) { }

	// RVA: 0x8628AC0 Offset: 0x8624AC0 VA: 0x8628AC0
	protected void CompleteOperation(string text, Exception exception) { }

	// RVA: 0x8628790 Offset: 0x8624790 VA: 0x8628790
	private object ConvertText(string text) { }

	// RVA: 0x8628B6C Offset: 0x8624B6C VA: 0x8628B6C Slot: 4
	protected virtual void SendWebRequest(string path) { }

	// RVA: 0x8628364 Offset: 0x8624364 VA: 0x8628364
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8628F74 Offset: 0x8624F74 VA: 0x8628F74
	private void <SendWebRequest>b__13_0(UnityWebRequestAsyncOperation asyncOperation) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Text Data Provider")]
public class TextDataProvider : ResourceProviderBase // TypeDefIndex: 25053
{
	// Fields
	[CompilerGenerated]
	private bool <IgnoreFailures>k__BackingField; // 0x1C

	// Properties
	public bool IgnoreFailures { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x86282A8 Offset: 0x86242A8 VA: 0x86282A8
	public bool get_IgnoreFailures() { }

	[CompilerGenerated]
	// RVA: 0x86282B0 Offset: 0x86242B0 VA: 0x86282B0
	public void set_IgnoreFailures(bool value) { }

	// RVA: 0x86282BC Offset: 0x86242BC VA: 0x86282BC Slot: 19
	public virtual object Convert(Type type, string text) { }

	// RVA: 0x86282C4 Offset: 0x86242C4 VA: 0x86282C4 Slot: 17
	public override void Provide(ProvideHandle provideHandle) { }

	// RVA: 0x86250E8 Offset: 0x86210E8 VA: 0x86250E8
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public interface ILocationSizeData // TypeDefIndex: 25054
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long ComputeSize(IResourceLocation location, ResourceManager resourceManager);
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public interface IResourceLocation // TypeDefIndex: 25055
{
	// Properties
	public abstract string InternalId { get; }
	public abstract string ProviderId { get; }
	public abstract IList<IResourceLocation> Dependencies { get; }
	public abstract int DependencyHashCode { get; }
	public abstract bool HasDependencies { get; }
	public abstract object Data { get; }
	public abstract string PrimaryKey { get; }
	public abstract Type ResourceType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_InternalId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ProviderId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IList<IResourceLocation> get_Dependencies();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int Hash(Type resultType);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_DependencyHashCode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_HasDependencies();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_Data();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_PrimaryKey();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Type get_ResourceType();
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public class ResourceLocationBase : IResourceLocation // TypeDefIndex: 25056
{
	// Fields
	private string m_Name; // 0x10
	private string m_Id; // 0x18
	private string m_ProviderId; // 0x20
	private object m_Data; // 0x28
	private int m_DependencyHashCode; // 0x30
	private int m_HashCode; // 0x34
	private Type m_Type; // 0x38
	private List<IResourceLocation> m_Dependencies; // 0x40
	private string m_PrimaryKey; // 0x48

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public bool HasDependencies { get; }
	public object Data { get; set; }
	public string PrimaryKey { get; set; }
	public int DependencyHashCode { get; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x862901C Offset: 0x862501C VA: 0x862901C Slot: 4
	public string get_InternalId() { }

	// RVA: 0x8629024 Offset: 0x8625024 VA: 0x8629024 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x862902C Offset: 0x862502C VA: 0x862902C Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x8629034 Offset: 0x8625034 VA: 0x8629034 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x8629088 Offset: 0x8625088 VA: 0x8629088 Slot: 10
	public object get_Data() { }

	// RVA: 0x8629090 Offset: 0x8625090 VA: 0x8629090
	public void set_Data(object value) { }

	// RVA: 0x8629098 Offset: 0x8625098 VA: 0x8629098 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x86290A0 Offset: 0x86250A0 VA: 0x86290A0
	public void set_PrimaryKey(string value) { }

	// RVA: 0x86290A8 Offset: 0x86250A8 VA: 0x86290A8 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x86290B0 Offset: 0x86250B0 VA: 0x86290B0 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x86290B8 Offset: 0x86250B8 VA: 0x86290B8 Slot: 7
	public int Hash(Type t) { }

	// RVA: 0x862910C Offset: 0x862510C VA: 0x862910C Slot: 3
	public override string ToString() { }

	// RVA: 0x8629114 Offset: 0x8625114 VA: 0x8629114
	public void .ctor(string name, string id, string providerId, Type t, IResourceLocation[] dependencies) { }

	// RVA: 0x8629384 Offset: 0x8625384 VA: 0x8629384
	public void ComputeDependencyHash() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
internal class LocationWrapper : IResourceLocation // TypeDefIndex: 25057
{
	// Fields
	private IResourceLocation m_InternalLocation; // 0x10

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public int DependencyHashCode { get; }
	public bool HasDependencies { get; }
	public object Data { get; }
	public string PrimaryKey { get; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x861E62C Offset: 0x861A62C VA: 0x861E62C
	public void .ctor(IResourceLocation location) { }

	// RVA: 0x86295DC Offset: 0x86255DC VA: 0x86295DC Slot: 4
	public string get_InternalId() { }

	// RVA: 0x862967C Offset: 0x862567C VA: 0x862967C Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x8629720 Offset: 0x8625720 VA: 0x8629720 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x86297C4 Offset: 0x86257C4 VA: 0x86297C4 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x8629868 Offset: 0x8625868 VA: 0x8629868 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x862990C Offset: 0x862590C VA: 0x862990C Slot: 10
	public object get_Data() { }

	// RVA: 0x86299B0 Offset: 0x86259B0 VA: 0x86299B0 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x8629A54 Offset: 0x8625A54 VA: 0x8629A54 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x8629AF8 Offset: 0x8625AF8 VA: 0x8629AF8 Slot: 7
	public int Hash(Type resultType) { }
}

// Namespace: UnityEngine.ResourceManagement.Profiling
public class EngineEmitter : IProfilerEmitter // TypeDefIndex: 25058
{
	// Properties
	public bool IsEnabled { get; }

	// Methods

	// RVA: 0x8629BA4 Offset: 0x8625BA4 VA: 0x8629BA4 Slot: 4
	public bool get_IsEnabled() { }

	// RVA: 0x8629BAC Offset: 0x8625BAC VA: 0x8629BAC Slot: 5
	public void EmitFrameMetaData(Guid id, int tag, Array data) { }

	// RVA: 0x8629BB0 Offset: 0x8625BB0 VA: 0x8629BB0 Slot: 6
	public void InitialiseCallbacks(Action<float> d) { }

	// RVA: 0x8629C04 Offset: 0x8625C04 VA: 0x8629C04
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Profiling
[Flags]
internal enum ContentStatus // TypeDefIndex: 25059
{
	// Fields
	public int value__; // 0x0
	public const ContentStatus None = 0;
	public const ContentStatus Queue = 2;
	public const ContentStatus Downloading = 4;
	public const ContentStatus Released = 16;
	public const ContentStatus Loading = 64;
	public const ContentStatus Active = 256;
}

// Namespace: UnityEngine.ResourceManagement.Profiling
[Flags]
internal enum BundleOptions // TypeDefIndex: 25060
{
	// Fields
	public short value__; // 0x0
	public const BundleOptions None = 0;
	public const BundleOptions CachingEnabled = 1;
	public const BundleOptions CheckSumEnabled = 2;
}

// Namespace: UnityEngine.ResourceManagement.Profiling
internal struct CatalogFrameData // TypeDefIndex: 25061
{
	// Fields
	public Hash128 BuildResultHash; // 0x0
}

// Namespace: UnityEngine.ResourceManagement.Profiling
internal struct BundleFrameData // TypeDefIndex: 25062
{
	// Fields
	public int BundleCode; // 0x0
	public int ReferenceCount; // 0x4
	public float PercentComplete; // 0x8
	public ContentStatus Status; // 0xC
	public BundleSource Source; // 0x10
	public BundleOptions LoadingOptions; // 0x14
}

// Namespace: UnityEngine.ResourceManagement.Profiling
internal struct AssetFrameData // TypeDefIndex: 25063
{
	// Fields
	public int AssetCode; // 0x0
	public int BundleCode; // 0x4
	public int ReferenceCount; // 0x8
	public float PercentComplete; // 0xC
	public ContentStatus Status; // 0x10

	// Methods

	// RVA: 0x8629C0C Offset: 0x8625C0C VA: 0x8629C0C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x8629C94 Offset: 0x8625C94 VA: 0x8629C94 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.ResourceManagement.Profiling
internal interface IProfilerEmitter // TypeDefIndex: 25064
{
	// Properties
	public abstract bool IsEnabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsEnabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void EmitFrameMetaData(Guid id, int tag, Array data);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void InitialiseCallbacks(Action<float> onLateUpdateDelegate);
}

// Namespace: 
[CompilerGenerated]
private sealed class ProfilerFrameData.<Enumerate>d__17<T1, T2> : IEnumerable<KeyValuePair<T1, T2>>, IEnumerable, IEnumerator<KeyValuePair<T1, T2>>, IEnumerator, IDisposable // TypeDefIndex: 25065
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<T1, T2> <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public ProfilerFrameData<T1, T2> <>4__this; // 0x0
	private Dictionary.Enumerator<T1, T2> <>7__wrap1; // 0x0

	// Properties
	private KeyValuePair<T1, T2> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1,T2>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD9570 Offset: 0x5BD5570 VA: 0x5BD9570
	|-ProfilerFrameData.<Enumerate>d__17<Hash128, CatalogFrameData>..ctor
	|
	|-RVA: 0x5BD98C0 Offset: 0x5BD58C0 VA: 0x5BD98C0
	|-ProfilerFrameData.<Enumerate>d__17<object, AssetFrameData>..ctor
	|
	|-RVA: 0x5BD9C24 Offset: 0x5BD5C24 VA: 0x5BD9C24
	|-ProfilerFrameData.<Enumerate>d__17<object, BundleFrameData>..ctor
	|
	|-RVA: 0x5BD9F88 Offset: 0x5BD5F88 VA: 0x5BD9F88
	|-ProfilerFrameData.<Enumerate>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD95A4 Offset: 0x5BD55A4 VA: 0x5BD95A4
	|-ProfilerFrameData.<Enumerate>d__17<Hash128, CatalogFrameData>.System.IDisposable.Dispose
	|
	|-RVA: 0x5BD98F4 Offset: 0x5BD58F4 VA: 0x5BD98F4
	|-ProfilerFrameData.<Enumerate>d__17<object, AssetFrameData>.System.IDisposable.Dispose
	|
	|-RVA: 0x5BD9C58 Offset: 0x5BD5C58 VA: 0x5BD9C58
	|-ProfilerFrameData.<Enumerate>d__17<object, BundleFrameData>.System.IDisposable.Dispose
	|
	|-RVA: 0x5BD9FF0 Offset: 0x5BD5FF0 VA: 0x5BD9FF0
	|-ProfilerFrameData.<Enumerate>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD95E4 Offset: 0x5BD55E4 VA: 0x5BD95E4
	|-ProfilerFrameData.<Enumerate>d__17<Hash128, CatalogFrameData>.MoveNext
	|
	|-RVA: 0x5BD9934 Offset: 0x5BD5934 VA: 0x5BD9934
	|-ProfilerFrameData.<Enumerate>d__17<object, AssetFrameData>.MoveNext
	|
	|-RVA: 0x5BD9C98 Offset: 0x5BD5C98 VA: 0x5BD9C98
	|-ProfilerFrameData.<Enumerate>d__17<object, BundleFrameData>.MoveNext
	|
	|-RVA: 0x5BDA050 Offset: 0x5BD6050 VA: 0x5BDA050
	|-ProfilerFrameData.<Enumerate>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD9788 Offset: 0x5BD5788 VA: 0x5BD9788
	|-ProfilerFrameData.<Enumerate>d__17<Hash128, CatalogFrameData>.<>m__Finally1
	|
	|-RVA: 0x5BD9AEC Offset: 0x5BD5AEC VA: 0x5BD9AEC
	|-ProfilerFrameData.<Enumerate>d__17<object, AssetFrameData>.<>m__Finally1
	|
	|-RVA: 0x5BD9E50 Offset: 0x5BD5E50 VA: 0x5BD9E50
	|-ProfilerFrameData.<Enumerate>d__17<object, BundleFrameData>.<>m__Finally1
	|
	|-RVA: 0x5BDA3C8 Offset: 0x5BD63C8 VA: 0x5BDA3C8
	|-ProfilerFrameData.<Enumerate>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private KeyValuePair<T1, T2> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1,T2>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD97A4 Offset: 0x5BD57A4 VA: 0x5BD97A4
	|-ProfilerFrameData.<Enumerate>d__17<Hash128, CatalogFrameData>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1,T2>>.get_Current
	|
	|-RVA: 0x5BD9B08 Offset: 0x5BD5B08 VA: 0x5BD9B08
	|-ProfilerFrameData.<Enumerate>d__17<object, AssetFrameData>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1,T2>>.get_Current
	|
	|-RVA: 0x5BD9E6C Offset: 0x5BD5E6C VA: 0x5BD9E6C
	|-ProfilerFrameData.<Enumerate>d__17<object, BundleFrameData>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1,T2>>.get_Current
	|
	|-RVA: 0x5BDA4D4 Offset: 0x5BD64D4 VA: 0x5BDA4D4
	|-ProfilerFrameData.<Enumerate>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1,T2>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD97B4 Offset: 0x5BD57B4 VA: 0x5BD97B4
	|-ProfilerFrameData.<Enumerate>d__17<Hash128, CatalogFrameData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5BD9B18 Offset: 0x5BD5B18 VA: 0x5BD9B18
	|-ProfilerFrameData.<Enumerate>d__17<object, AssetFrameData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5BD9E7C Offset: 0x5BD5E7C VA: 0x5BD9E7C
	|-ProfilerFrameData.<Enumerate>d__17<object, BundleFrameData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5BDA574 Offset: 0x5BD6574 VA: 0x5BDA574
	|-ProfilerFrameData.<Enumerate>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD97E8 Offset: 0x5BD57E8 VA: 0x5BD97E8
	|-ProfilerFrameData.<Enumerate>d__17<Hash128, CatalogFrameData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5BD9B4C Offset: 0x5BD5B4C VA: 0x5BD9B4C
	|-ProfilerFrameData.<Enumerate>d__17<object, AssetFrameData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5BD9EB0 Offset: 0x5BD5EB0 VA: 0x5BD9EB0
	|-ProfilerFrameData.<Enumerate>d__17<object, BundleFrameData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5BDA5A8 Offset: 0x5BD65A8 VA: 0x5BDA5A8
	|-ProfilerFrameData.<Enumerate>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<T1, T2>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD981C Offset: 0x5BD581C VA: 0x5BD981C
	|-ProfilerFrameData.<Enumerate>d__17<Hash128, CatalogFrameData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator
	|
	|-RVA: 0x5BD9B80 Offset: 0x5BD5B80 VA: 0x5BD9B80
	|-ProfilerFrameData.<Enumerate>d__17<object, AssetFrameData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator
	|
	|-RVA: 0x5BD9EE4 Offset: 0x5BD5EE4 VA: 0x5BD9EE4
	|-ProfilerFrameData.<Enumerate>d__17<object, BundleFrameData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator
	|
	|-RVA: 0x5BDA64C Offset: 0x5BD664C VA: 0x5BDA64C
	|-ProfilerFrameData.<Enumerate>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD98B0 Offset: 0x5BD58B0 VA: 0x5BD98B0
	|-ProfilerFrameData.<Enumerate>d__17<Hash128, CatalogFrameData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5BD9C14 Offset: 0x5BD5C14 VA: 0x5BD9C14
	|-ProfilerFrameData.<Enumerate>d__17<object, AssetFrameData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5BD9F78 Offset: 0x5BD5F78 VA: 0x5BD9F78
	|-ProfilerFrameData.<Enumerate>d__17<object, BundleFrameData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5BDA75C Offset: 0x5BD675C VA: 0x5BDA75C
	|-ProfilerFrameData.<Enumerate>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: UnityEngine.ResourceManagement.Profiling
[DefaultMember("Item")]
internal class ProfilerFrameData<T1, T2> // TypeDefIndex: 25066
{
	// Fields
	private Dictionary<T1, T2> m_Data; // 0x0
	private T2[] m_Array; // 0x0
	private uint m_Version; // 0x0
	private uint m_ArrayVersion; // 0x0

	// Properties
	internal Dictionary<T1, T2> Data { get; }
	public T2[] Values { get; }
	public T2 Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal Dictionary<T1, T2> get_Data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294A70 Offset: 0x5290A70 VA: 0x5294A70
	|-ProfilerFrameData<Hash128, CatalogFrameData>.get_Data
	|
	|-RVA: 0x5295050 Offset: 0x5291050 VA: 0x5295050
	|-ProfilerFrameData<object, AssetFrameData>.get_Data
	|
	|-RVA: 0x529564C Offset: 0x529164C VA: 0x529564C
	|-ProfilerFrameData<object, BundleFrameData>.get_Data
	|
	|-RVA: 0x5295C94 Offset: 0x5291C94 VA: 0x5295C94
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Data
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294A78 Offset: 0x5290A78 VA: 0x5294A78
	|-ProfilerFrameData<Hash128, CatalogFrameData>..ctor
	|
	|-RVA: 0x5295058 Offset: 0x5291058 VA: 0x5295058
	|-ProfilerFrameData<object, AssetFrameData>..ctor
	|
	|-RVA: 0x5295654 Offset: 0x5291654 VA: 0x5295654
	|-ProfilerFrameData<object, BundleFrameData>..ctor
	|
	|-RVA: 0x5295C9C Offset: 0x5291C9C VA: 0x5295C9C
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294ADC Offset: 0x5290ADC VA: 0x5294ADC
	|-ProfilerFrameData<Hash128, CatalogFrameData>..ctor
	|
	|-RVA: 0x52950BC Offset: 0x52910BC VA: 0x52950BC
	|-ProfilerFrameData<object, AssetFrameData>..ctor
	|
	|-RVA: 0x52956B8 Offset: 0x52916B8 VA: 0x52956B8
	|-ProfilerFrameData<object, BundleFrameData>..ctor
	|
	|-RVA: 0x5295D04 Offset: 0x5291D04 VA: 0x5295D04
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(T1 key, T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294B44 Offset: 0x5290B44 VA: 0x5294B44
	|-ProfilerFrameData<Hash128, CatalogFrameData>.Add
	|
	|-RVA: 0x5295124 Offset: 0x5291124 VA: 0x5295124
	|-ProfilerFrameData<object, AssetFrameData>.Add
	|
	|-RVA: 0x5295720 Offset: 0x5291720 VA: 0x5295720
	|-ProfilerFrameData<object, BundleFrameData>.Add
	|
	|-RVA: 0x5295D70 Offset: 0x5291D70 VA: 0x5295D70
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	internal bool Remove(T1 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294BE0 Offset: 0x5290BE0 VA: 0x5294BE0
	|-ProfilerFrameData<Hash128, CatalogFrameData>.Remove
	|
	|-RVA: 0x52951CC Offset: 0x52911CC VA: 0x52951CC
	|-ProfilerFrameData<object, AssetFrameData>.Remove
	|
	|-RVA: 0x52957C8 Offset: 0x52917C8 VA: 0x52957C8
	|-ProfilerFrameData<object, BundleFrameData>.Remove
	|
	|-RVA: 0x5295F48 Offset: 0x5291F48 VA: 0x5295F48
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public T2[] get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294C20 Offset: 0x5290C20 VA: 0x5294C20
	|-ProfilerFrameData<Hash128, CatalogFrameData>.get_Values
	|
	|-RVA: 0x529520C Offset: 0x529120C VA: 0x529520C
	|-ProfilerFrameData<object, AssetFrameData>.get_Values
	|
	|-RVA: 0x5295808 Offset: 0x5291808 VA: 0x5295808
	|-ProfilerFrameData<object, BundleFrameData>.get_Values
	|
	|-RVA: 0x5296038 Offset: 0x5292038 VA: 0x5296038
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item(T1 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294D48 Offset: 0x5290D48 VA: 0x5294D48
	|-ProfilerFrameData<Hash128, CatalogFrameData>.get_Item
	|
	|-RVA: 0x5295334 Offset: 0x5291334 VA: 0x5295334
	|-ProfilerFrameData<object, AssetFrameData>.get_Item
	|
	|-RVA: 0x5295930 Offset: 0x5291930 VA: 0x5295930
	|-ProfilerFrameData<object, BundleFrameData>.get_Item
	|
	|-RVA: 0x5296130 Offset: 0x5292130 VA: 0x5296130
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(T1 key, T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294E10 Offset: 0x5290E10 VA: 0x5294E10
	|-ProfilerFrameData<Hash128, CatalogFrameData>.set_Item
	|
	|-RVA: 0x5295414 Offset: 0x5291414 VA: 0x5295414
	|-ProfilerFrameData<object, AssetFrameData>.set_Item
	|
	|-RVA: 0x5295A10 Offset: 0x5291A10 VA: 0x5295A10
	|-ProfilerFrameData<object, BundleFrameData>.set_Item
	|
	|-RVA: 0x5296368 Offset: 0x5292368 VA: 0x5296368
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(T1 key, out T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294F90 Offset: 0x5290F90 VA: 0x5294F90
	|-ProfilerFrameData<Hash128, CatalogFrameData>.TryGetValue
	|
	|-RVA: 0x529558C Offset: 0x529158C VA: 0x529558C
	|-ProfilerFrameData<object, AssetFrameData>.TryGetValue
	|
	|-RVA: 0x5295BD4 Offset: 0x5291BD4 VA: 0x5295BD4
	|-ProfilerFrameData<object, BundleFrameData>.TryGetValue
	|
	|-RVA: 0x52966F0 Offset: 0x52926F0 VA: 0x52966F0
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(T1 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294FB4 Offset: 0x5290FB4 VA: 0x5294FB4
	|-ProfilerFrameData<Hash128, CatalogFrameData>.ContainsKey
	|
	|-RVA: 0x52955B0 Offset: 0x52915B0 VA: 0x52955B0
	|-ProfilerFrameData<object, AssetFrameData>.ContainsKey
	|
	|-RVA: 0x5295BF8 Offset: 0x5291BF8 VA: 0x5295BF8
	|-ProfilerFrameData<object, BundleFrameData>.ContainsKey
	|
	|-RVA: 0x52967D0 Offset: 0x52927D0 VA: 0x52967D0
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	[IteratorStateMachine(typeof(ProfilerFrameData.<Enumerate>d__17<T1, T2>))]
	// RVA: -1 Offset: -1
	public IEnumerable<KeyValuePair<T1, T2>> Enumerate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5294FD8 Offset: 0x5290FD8 VA: 0x5294FD8
	|-ProfilerFrameData<Hash128, CatalogFrameData>.Enumerate
	|
	|-RVA: 0x52955D4 Offset: 0x52915D4 VA: 0x52955D4
	|-ProfilerFrameData<object, AssetFrameData>.Enumerate
	|
	|-RVA: 0x5295C1C Offset: 0x5291C1C VA: 0x5295C1C
	|-ProfilerFrameData<object, BundleFrameData>.Enumerate
	|
	|-RVA: 0x52968A0 Offset: 0x52928A0 VA: 0x52968A0
	|-ProfilerFrameData<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Enumerate
	*/
}

// Namespace: UnityEngine.ResourceManagement.Profiling
internal static class ProfilerRuntime // TypeDefIndex: 25067
{
	// Fields
	internal static IProfilerEmitter m_profilerEmitter; // 0x0
	public static readonly Guid kResourceManagerProfilerGuid; // 0x8
	public const int kCatalogTag = 0;
	public const int kBundleDataTag = 1;
	public const int kAssetDataTag = 2;
	public const int kSceneDataTag = 3;
	private static ProfilerCounterValue<int> CatalogLoadCounter; // 0x18
	private static ProfilerCounterValue<int> AssetBundleLoadCounter; // 0x19
	private static ProfilerCounterValue<int> AssetLoadCounter; // 0x1A
	private static ProfilerCounterValue<int> SceneLoadCounter; // 0x1B
	private static ProfilerFrameData<Hash128, CatalogFrameData> m_CatalogData; // 0x20
	private static ProfilerFrameData<IAsyncOperation, BundleFrameData> m_BundleData; // 0x28
	private static ProfilerFrameData<IAsyncOperation, AssetFrameData> m_AssetData; // 0x30
	private static ProfilerFrameData<IAsyncOperation, AssetFrameData> m_SceneData; // 0x38
	private static Dictionary<string, IAsyncOperation> m_BundleNameToOperation; // 0x40
	private static Dictionary<string, List<IAsyncOperation>> m_BundleNameToAssetOperations; // 0x48
	private static Dictionary<IAsyncOperation, ValueTuple<int, float>> m_DataChange; // 0x50

	// Methods

	// RVA: 0x8611724 Offset: 0x860D724 VA: 0x8611724
	public static void Initialise() { }

	// RVA: 0x8629D74 Offset: 0x8625D74 VA: 0x8629D74
	private static void InstanceOnOnLateUpdateDelegate(float deltaTime) { }

	// RVA: 0x862A190 Offset: 0x8626190 VA: 0x862A190
	public static void AddCatalog(Hash128 buildHash) { }

	// RVA: 0x861F440 Offset: 0x861B440 VA: 0x861F440
	public static void AddBundleOperation(ProvideHandle handle, AssetBundleRequestOptions requestOptions, ContentStatus status, BundleSource source) { }

	// RVA: 0x861F144 Offset: 0x861B144 VA: 0x861F144
	public static void BundleReleased(string bundleName) { }

	// RVA: 0x8623BB4 Offset: 0x861FBB4 VA: 0x8623BB4
	public static void AddAssetOperation(ProvideHandle handle, ContentStatus status) { }

	// RVA: 0x862A244 Offset: 0x8626244 VA: 0x862A244
	private static string GetContainingBundleNameForLocation(IResourceLocation location) { }

	// RVA: 0x86276B8 Offset: 0x86236B8 VA: 0x86276B8
	public static void AddSceneOperation(AsyncOperationHandle<SceneInstance> handle, IResourceLocation location, ContentStatus status) { }

	// RVA: 0x8627E80 Offset: 0x8623E80 VA: 0x8627E80
	public static void SceneReleased(AsyncOperationHandle<SceneInstance> handle) { }

	// RVA: 0x8629DC0 Offset: 0x8625DC0 VA: 0x8629DC0
	internal static void PushToProfilerStream() { }

	// RVA: 0x862A5A0 Offset: 0x86265A0 VA: 0x862A5A0
	private static void RefreshChangedReferenceCounts() { }

	// RVA: 0x862B0C0 Offset: 0x86270C0 VA: 0x862B0C0
	private static bool ShouldUpdateFrameDataWithOperationData(IAsyncOperation activeOperation, int frameReferenceCount, float framePercentComplete, out ValueTuple<int, float> newDataOut) { }

	// RVA: 0x862B3C8 Offset: 0x86273C8 VA: 0x862B3C8
	private static void .cctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Diagnostics
[Serializable]
public struct DiagnosticEvent // TypeDefIndex: 25068
{
	// Fields
	[SerializeField]
	private string m_Graph; // 0x0
	[SerializeField]
	private int[] m_Dependencies; // 0x8
	[SerializeField]
	private int m_ObjectId; // 0x10
	[SerializeField]
	private string m_DisplayName; // 0x18
	[SerializeField]
	private int m_Stream; // 0x20
	[SerializeField]
	private int m_Frame; // 0x24
	[SerializeField]
	private int m_Value; // 0x28

	// Properties
	public string Graph { get; }
	public int ObjectId { get; }
	public string DisplayName { get; }
	public int[] Dependencies { get; }
	public int Stream { get; }
	public int Frame { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x862B758 Offset: 0x8627758 VA: 0x862B758
	public string get_Graph() { }

	// RVA: 0x862B760 Offset: 0x8627760 VA: 0x862B760
	public int get_ObjectId() { }

	// RVA: 0x862B768 Offset: 0x8627768 VA: 0x862B768
	public string get_DisplayName() { }

	// RVA: 0x862B770 Offset: 0x8627770 VA: 0x862B770
	public int[] get_Dependencies() { }

	// RVA: 0x862B778 Offset: 0x8627778 VA: 0x862B778
	public int get_Stream() { }

	// RVA: 0x862B780 Offset: 0x8627780 VA: 0x862B780
	public int get_Frame() { }

	// RVA: 0x862B788 Offset: 0x8627788 VA: 0x862B788
	public int get_Value() { }

	// RVA: 0x862B790 Offset: 0x8627790 VA: 0x862B790
	public void .ctor(string graph, string name, int id, int stream, int frame, int value, int[] deps) { }

	// RVA: 0x862B800 Offset: 0x8627800 VA: 0x862B800
	internal byte[] Serialize() { }

	// RVA: 0x862B898 Offset: 0x8627898 VA: 0x862B898
	public static DiagnosticEvent Deserialize(byte[] data) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DiagnosticEventCollectorSingleton.<>c // TypeDefIndex: 25069
{
	// Fields
	public static readonly DiagnosticEventCollectorSingleton.<>c <>9; // 0x0
	public static Func<DiagnosticEvent, int> <>9__8_0; // 0x8
	public static Action<DiagnosticEvent> <>9__11_0; // 0x10

	// Methods

	// RVA: 0x862C6D8 Offset: 0x86286D8 VA: 0x862C6D8
	private static void .cctor() { }

	// RVA: 0x862C740 Offset: 0x8628740 VA: 0x862C740
	public void .ctor() { }

	// RVA: 0x862C748 Offset: 0x8628748 VA: 0x862C748
	internal int <RegisterEventHandler>b__8_0(DiagnosticEvent evt) { }

	// RVA: 0x862C750 Offset: 0x8628750 VA: 0x862C750
	internal void <Awake>b__11_0(DiagnosticEvent diagnosticEvent) { }
}

// Namespace: UnityEngine.ResourceManagement.Diagnostics
public class DiagnosticEventCollectorSingleton : ComponentSingleton<DiagnosticEventCollectorSingleton> // TypeDefIndex: 25070
{
	// Fields
	private static Guid s_editorConnectionGuid; // 0x0
	internal Dictionary<int, DiagnosticEvent> m_CreatedEvents; // 0x20
	internal List<DiagnosticEvent> m_UnhandledEvents; // 0x28
	internal DelegateList<DiagnosticEvent> s_EventHandlers; // 0x30
	private float m_lastTickSent; // 0x38
	private int m_lastFrame; // 0x3C
	private float fpsAvg; // 0x40

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x862B924 Offset: 0x8627924 VA: 0x862B924
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x862BA20 Offset: 0x8627A20 VA: 0x862BA20 Slot: 4
	protected override string GetGameObjectName() { }

	// RVA: 0x862BA60 Offset: 0x8627A60 VA: 0x862BA60
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x862BB2C Offset: 0x8627B2C VA: 0x862BB2C
	internal void RegisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x862C004 Offset: 0x8628004 VA: 0x862C004
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x862C0A8 Offset: 0x86280A8 VA: 0x862C0A8
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x862C2D0 Offset: 0x86282D0 VA: 0x862C2D0
	private void Awake() { }

	// RVA: 0x862C3B8 Offset: 0x86283B8 VA: 0x862C3B8
	private void Update() { }

	// RVA: 0x862C5AC Offset: 0x86285AC VA: 0x862C5AC
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Diagnostics
public class DiagnosticEventCollector : MonoBehaviour // TypeDefIndex: 25071
{
	// Fields
	private static DiagnosticEventCollector s_Collector; // 0x0

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x862C7B4 Offset: 0x86287B4 VA: 0x862C7B4
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x862C7BC Offset: 0x86287BC VA: 0x862C7BC
	public static DiagnosticEventCollector FindOrCreateGlobalInstance() { }

	// RVA: 0x862C998 Offset: 0x8628998 VA: 0x862C998
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x862C9A8 Offset: 0x86289A8 VA: 0x862C9A8
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x862CA00 Offset: 0x8628A00 VA: 0x862CA00
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x862CA84 Offset: 0x8628A84 VA: 0x862CA84
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal interface ICachable // TypeDefIndex: 25072
{
	// Properties
	public abstract IOperationCacheKey Key { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IOperationCacheKey get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Key(IOperationCacheKey value);
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal interface IAsyncOperation // TypeDefIndex: 25073
{
	// Properties
	public abstract Type ResultType { get; }
	public abstract int Version { get; }
	public abstract string DebugName { get; }
	public abstract int ReferenceCount { get; }
	public abstract float PercentComplete { get; }
	public abstract AsyncOperationStatus Status { get; }
	public abstract Exception OperationException { get; }
	public abstract bool IsDone { get; }
	public abstract Action<IAsyncOperation> OnDestroy { set; }
	public abstract bool IsRunning { get; }
	public abstract Task<object> Task { get; }
	public abstract AsyncOperationHandle Handle { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetResultAsObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_ResultType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Version();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_DebugName();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DecrementReferenceCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void IncrementReferenceCount();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_ReferenceCount();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_PercentComplete();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DownloadStatus GetDownloadStatus(HashSet<object> visited);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract AsyncOperationStatus get_Status();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Exception get_OperationException();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsDone();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_OnDestroy(Action<IAsyncOperation> value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void GetDependencies(List<AsyncOperationHandle> deps);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsRunning();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void add_CompletedTypeless(Action<AsyncOperationHandle> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void remove_CompletedTypeless(Action<AsyncOperationHandle> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void add_Destroyed(Action<AsyncOperationHandle> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public abstract void remove_Destroyed(Action<AsyncOperationHandle> value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void InvokeCompletionEvent();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Task<object> get_Task();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract AsyncOperationHandle get_Handle();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WaitForCompletion();
}

// Namespace: 
[CompilerGenerated]
private sealed class AsyncOperationBase.<>c__DisplayClass60_0<TObject> // TypeDefIndex: 25074
{
	// Fields
	public Action<AsyncOperationHandle> value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545B698 Offset: 0x5457698 VA: 0x545B698
	|-AsyncOperationBase.<>c__DisplayClass60_0<bool>..ctor
	|
	|-RVA: 0x545B724 Offset: 0x5457724 VA: 0x545B724
	|-AsyncOperationBase.<>c__DisplayClass60_0<long>..ctor
	|
	|-RVA: 0x545B7B0 Offset: 0x54577B0 VA: 0x545B7B0
	|-AsyncOperationBase.<>c__DisplayClass60_0<object>..ctor
	|
	|-RVA: 0x545BA00 Offset: 0x5457A00 VA: 0x545BA00
	|-AsyncOperationBase.<>c__DisplayClass60_0<SceneInstance>..ctor
	|
	|-RVA: 0x545BA8C Offset: 0x5457A8C VA: 0x545BA8C
	|-AsyncOperationBase.<>c__DisplayClass60_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <add_CompletedTypeless>b__0(AsyncOperationHandle<TObject> s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545B6A0 Offset: 0x54576A0 VA: 0x545B6A0
	|-AsyncOperationBase.<>c__DisplayClass60_0<bool>.<add_CompletedTypeless>b__0
	|
	|-RVA: 0x545B72C Offset: 0x545772C VA: 0x545B72C
	|-AsyncOperationBase.<>c__DisplayClass60_0<long>.<add_CompletedTypeless>b__0
	|
	|-RVA: 0x545B7B8 Offset: 0x54577B8 VA: 0x545B7B8
	|-AsyncOperationBase.<>c__DisplayClass60_0<object>.<add_CompletedTypeless>b__0
	|
	|-RVA: 0x545BA08 Offset: 0x5457A08 VA: 0x545BA08
	|-AsyncOperationBase.<>c__DisplayClass60_0<SceneInstance>.<add_CompletedTypeless>b__0
	|
	|-RVA: 0x545BA94 Offset: 0x5457A94 VA: 0x545BA94
	|-AsyncOperationBase.<>c__DisplayClass60_0<__Il2CppFullySharedGenericType>.<add_CompletedTypeless>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class AsyncOperationBase.<>c__DisplayClass61_0<TObject> // TypeDefIndex: 25075
{
	// Fields
	public Action<AsyncOperationHandle> value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545BB80 Offset: 0x5457B80 VA: 0x545BB80
	|-AsyncOperationBase.<>c__DisplayClass61_0<bool>..ctor
	|
	|-RVA: 0x545BC0C Offset: 0x5457C0C VA: 0x545BC0C
	|-AsyncOperationBase.<>c__DisplayClass61_0<long>..ctor
	|
	|-RVA: 0x545BC98 Offset: 0x5457C98 VA: 0x545BC98
	|-AsyncOperationBase.<>c__DisplayClass61_0<object>..ctor
	|
	|-RVA: 0x545BDFC Offset: 0x5457DFC VA: 0x545BDFC
	|-AsyncOperationBase.<>c__DisplayClass61_0<SceneInstance>..ctor
	|
	|-RVA: 0x545BE88 Offset: 0x5457E88 VA: 0x545BE88
	|-AsyncOperationBase.<>c__DisplayClass61_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <remove_CompletedTypeless>b__0(AsyncOperationHandle<TObject> s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545BB88 Offset: 0x5457B88 VA: 0x545BB88
	|-AsyncOperationBase.<>c__DisplayClass61_0<bool>.<remove_CompletedTypeless>b__0
	|
	|-RVA: 0x545BC14 Offset: 0x5457C14 VA: 0x545BC14
	|-AsyncOperationBase.<>c__DisplayClass61_0<long>.<remove_CompletedTypeless>b__0
	|
	|-RVA: 0x545BCA0 Offset: 0x5457CA0 VA: 0x545BCA0
	|-AsyncOperationBase.<>c__DisplayClass61_0<object>.<remove_CompletedTypeless>b__0
	|
	|-RVA: 0x545BE04 Offset: 0x5457E04 VA: 0x545BE04
	|-AsyncOperationBase.<>c__DisplayClass61_0<SceneInstance>.<remove_CompletedTypeless>b__0
	|
	|-RVA: 0x545BE90 Offset: 0x5457E90 VA: 0x545BE90
	|-AsyncOperationBase.<>c__DisplayClass61_0<__Il2CppFullySharedGenericType>.<remove_CompletedTypeless>b__0
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public abstract class AsyncOperationBase<TObject> : IAsyncOperation // TypeDefIndex: 25076
{
	// Fields
	[CompilerGenerated]
	private TObject <Result>k__BackingField; // 0x0
	private int m_referenceCount; // 0x0
	internal AsyncOperationStatus m_Status; // 0x0
	internal Exception m_Error; // 0x0
	internal ResourceManager m_RM; // 0x0
	internal int m_Version; // 0x0
	private DelegateList<AsyncOperationHandle> m_DestroyedAction; // 0x0
	private DelegateList<AsyncOperationHandle<TObject>> m_CompletedActionT; // 0x0
	private Action<IAsyncOperation> m_OnDestroyAction; // 0x0
	private Action<AsyncOperationHandle> m_dependencyCompleteAction; // 0x0
	protected internal bool HasExecuted; // 0x0
	[CompilerGenerated]
	private Action Executed; // 0x0
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; // 0x0
	private TaskCompletionSource<TObject> m_taskCompletionSource; // 0x0
	private TaskCompletionSource<object> m_taskCompletionSourceTypeless; // 0x0
	private bool m_InDeferredCallbackQueue; // 0x0
	private DelegateList<float> m_UpdateCallbacks; // 0x0
	private Action<float> m_UpdateCallback; // 0x0

	// Properties
	protected virtual float Progress { get; }
	protected virtual string DebugName { get; }
	public TObject Result { get; set; }
	internal int Version { get; }
	internal bool CompletedEventHasListeners { get; }
	internal bool DestroyedEventHasListeners { get; }
	internal Action<IAsyncOperation> OnDestroy { set; }
	protected internal int ReferenceCount { get; }
	public bool IsRunning { get; set; }
	internal Task<TObject> Task { get; }
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Task { get; }
	internal AsyncOperationStatus Status { get; }
	internal Exception OperationException { get; set; }
	internal object Current { get; }
	internal bool IsDone { get; }
	internal float PercentComplete { get; }
	internal AsyncOperationHandle<TObject> Handle { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Version { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ReferenceCount { get; }
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.PercentComplete { get; }
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Status { get; }
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OperationException { get; }
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IsDone { get; }
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Handle { get; }
	private Action<IAsyncOperation> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OnDestroy { set; }
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DebugName { get; }
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ResultType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void Execute();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected virtual void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54927A8 Offset: 0x548E7A8 VA: 0x54927A8
	|-AsyncOperationBase<bool>.Destroy
	|
	|-RVA: 0x55BA5E8 Offset: 0x55B65E8 VA: 0x55BA5E8
	|-AsyncOperationBase<long>.Destroy
	|
	|-RVA: 0x55BC5C4 Offset: 0x55B85C4 VA: 0x55BC5C4
	|-AsyncOperationBase<object>.Destroy
	|
	|-RVA: 0x55BE534 Offset: 0x55BA534 VA: 0x55BE534
	|-AsyncOperationBase<SceneInstance>.Destroy
	|
	|-RVA: 0x55C0560 Offset: 0x55BC560 VA: 0x55C0560
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected virtual float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54927AC Offset: 0x548E7AC VA: 0x54927AC
	|-AsyncOperationBase<bool>.get_Progress
	|
	|-RVA: 0x55BA5EC Offset: 0x55B65EC VA: 0x55BA5EC
	|-AsyncOperationBase<long>.get_Progress
	|
	|-RVA: 0x55BC5C8 Offset: 0x55B85C8 VA: 0x55BC5C8
	|-AsyncOperationBase<object>.get_Progress
	|
	|-RVA: 0x55BE538 Offset: 0x55BA538 VA: 0x55BE538
	|-AsyncOperationBase<SceneInstance>.get_Progress
	|
	|-RVA: 0x55C0564 Offset: 0x55BC564 VA: 0x55C0564
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected virtual string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54927B4 Offset: 0x548E7B4 VA: 0x54927B4
	|-AsyncOperationBase<bool>.get_DebugName
	|
	|-RVA: 0x55BA5F4 Offset: 0x55B65F4 VA: 0x55BA5F4
	|-AsyncOperationBase<long>.get_DebugName
	|
	|-RVA: 0x55BC5D0 Offset: 0x55B85D0 VA: 0x55BC5D0
	|-AsyncOperationBase<object>.get_DebugName
	|
	|-RVA: 0x55BE540 Offset: 0x55BA540 VA: 0x55BE540
	|-AsyncOperationBase<SceneInstance>.get_DebugName
	|
	|-RVA: 0x55C056C Offset: 0x55BC56C VA: 0x55C056C
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54927D0 Offset: 0x548E7D0 VA: 0x54927D0
	|-AsyncOperationBase<bool>.GetDependencies
	|
	|-RVA: 0x55BA610 Offset: 0x55B6610 VA: 0x55BA610
	|-AsyncOperationBase<long>.GetDependencies
	|
	|-RVA: 0x55BC5EC Offset: 0x55B85EC VA: 0x55BC5EC
	|-AsyncOperationBase<object>.GetDependencies
	|
	|-RVA: 0x55BE55C Offset: 0x55BA55C VA: 0x55BE55C
	|-AsyncOperationBase<SceneInstance>.GetDependencies
	|
	|-RVA: 0x55C0588 Offset: 0x55BC588 VA: 0x55C0588
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54927D4 Offset: 0x548E7D4 VA: 0x54927D4
	|-AsyncOperationBase<bool>.get_Result
	|
	|-RVA: 0x55BA614 Offset: 0x55B6614 VA: 0x55BA614
	|-AsyncOperationBase<long>.get_Result
	|
	|-RVA: 0x55BC5F0 Offset: 0x55B85F0 VA: 0x55BC5F0
	|-AsyncOperationBase<object>.get_Result
	|
	|-RVA: 0x55BE560 Offset: 0x55BA560 VA: 0x55BE560
	|-AsyncOperationBase<SceneInstance>.get_Result
	|
	|-RVA: 0x55C058C Offset: 0x55BC58C VA: 0x55C058C
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Result
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Result(TObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54927DC Offset: 0x548E7DC VA: 0x54927DC
	|-AsyncOperationBase<bool>.set_Result
	|
	|-RVA: 0x55BA61C Offset: 0x55B661C VA: 0x55BA61C
	|-AsyncOperationBase<long>.set_Result
	|
	|-RVA: 0x55BC5F8 Offset: 0x55B85F8 VA: 0x55BC5F8
	|-AsyncOperationBase<object>.set_Result
	|
	|-RVA: 0x55BE56C Offset: 0x55BA56C VA: 0x55BE56C
	|-AsyncOperationBase<SceneInstance>.set_Result
	|
	|-RVA: 0x55C0624 Offset: 0x55BC624 VA: 0x55C0624
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_Result
	*/

	// RVA: -1 Offset: -1
	internal int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54927E8 Offset: 0x548E7E8 VA: 0x54927E8
	|-AsyncOperationBase<bool>.get_Version
	|
	|-RVA: 0x55BA624 Offset: 0x55B6624 VA: 0x55BA624
	|-AsyncOperationBase<long>.get_Version
	|
	|-RVA: 0x55BC600 Offset: 0x55B8600 VA: 0x55BC600
	|-AsyncOperationBase<object>.get_Version
	|
	|-RVA: 0x55BE57C Offset: 0x55BA57C VA: 0x55BE57C
	|-AsyncOperationBase<SceneInstance>.get_Version
	|
	|-RVA: 0x55C06D8 Offset: 0x55BC6D8 VA: 0x55C06D8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Version
	*/

	// RVA: -1 Offset: -1
	internal bool get_CompletedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54927F0 Offset: 0x548E7F0 VA: 0x54927F0
	|-AsyncOperationBase<bool>.get_CompletedEventHasListeners
	|
	|-RVA: 0x55BA62C Offset: 0x55B662C VA: 0x55BA62C
	|-AsyncOperationBase<long>.get_CompletedEventHasListeners
	|
	|-RVA: 0x55BC608 Offset: 0x55B8608 VA: 0x55BC608
	|-AsyncOperationBase<object>.get_CompletedEventHasListeners
	|
	|-RVA: 0x55BE584 Offset: 0x55BA584 VA: 0x55BE584
	|-AsyncOperationBase<SceneInstance>.get_CompletedEventHasListeners
	|
	|-RVA: 0x55C0700 Offset: 0x55BC700 VA: 0x55C0700
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_CompletedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal bool get_DestroyedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549281C Offset: 0x548E81C VA: 0x549281C
	|-AsyncOperationBase<bool>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x55BA658 Offset: 0x55B6658 VA: 0x55BA658
	|-AsyncOperationBase<long>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x55BC634 Offset: 0x55B8634 VA: 0x55BC634
	|-AsyncOperationBase<object>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x55BE5B0 Offset: 0x55BA5B0 VA: 0x55BE5B0
	|-AsyncOperationBase<SceneInstance>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x55C0788 Offset: 0x55BC788 VA: 0x55C0788
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_DestroyedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal void set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5492874 Offset: 0x548E874 VA: 0x5492874
	|-AsyncOperationBase<bool>.set_OnDestroy
	|
	|-RVA: 0x55BA6B0 Offset: 0x55B66B0 VA: 0x55BA6B0
	|-AsyncOperationBase<long>.set_OnDestroy
	|
	|-RVA: 0x55BC68C Offset: 0x55B868C VA: 0x55BC68C
	|-AsyncOperationBase<object>.set_OnDestroy
	|
	|-RVA: 0x55BE608 Offset: 0x55BA608 VA: 0x55BE608
	|-AsyncOperationBase<SceneInstance>.set_OnDestroy
	|
	|-RVA: 0x55C0830 Offset: 0x55BC830 VA: 0x55C0830
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_OnDestroy
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void add_Executed(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549287C Offset: 0x548E87C VA: 0x549287C
	|-AsyncOperationBase<bool>.add_Executed
	|
	|-RVA: 0x55BA6B8 Offset: 0x55B66B8 VA: 0x55BA6B8
	|-AsyncOperationBase<long>.add_Executed
	|
	|-RVA: 0x55BC694 Offset: 0x55B8694 VA: 0x55BC694
	|-AsyncOperationBase<object>.add_Executed
	|
	|-RVA: 0x55BE610 Offset: 0x55BA610 VA: 0x55BE610
	|-AsyncOperationBase<SceneInstance>.add_Executed
	|
	|-RVA: 0x55C0850 Offset: 0x55BC850 VA: 0x55C0850
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_Executed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void remove_Executed(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5492918 Offset: 0x548E918 VA: 0x5492918
	|-AsyncOperationBase<bool>.remove_Executed
	|
	|-RVA: 0x55BA754 Offset: 0x55B6754 VA: 0x55BA754
	|-AsyncOperationBase<long>.remove_Executed
	|
	|-RVA: 0x55BC730 Offset: 0x55B8730 VA: 0x55BC730
	|-AsyncOperationBase<object>.remove_Executed
	|
	|-RVA: 0x55BE6AC Offset: 0x55BA6AC VA: 0x55BE6AC
	|-AsyncOperationBase<SceneInstance>.remove_Executed
	|
	|-RVA: 0x55C092C Offset: 0x55BC92C VA: 0x55C092C
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_Executed
	*/

	// RVA: -1 Offset: -1
	protected internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54929B4 Offset: 0x548E9B4 VA: 0x54929B4
	|-AsyncOperationBase<bool>.get_ReferenceCount
	|
	|-RVA: 0x55BA7F0 Offset: 0x55B67F0 VA: 0x55BA7F0
	|-AsyncOperationBase<long>.get_ReferenceCount
	|
	|-RVA: 0x55BC7CC Offset: 0x55B87CC VA: 0x55BC7CC
	|-AsyncOperationBase<object>.get_ReferenceCount
	|
	|-RVA: 0x55BE748 Offset: 0x55BA748 VA: 0x55BE748
	|-AsyncOperationBase<SceneInstance>.get_ReferenceCount
	|
	|-RVA: 0x55C0A08 Offset: 0x55BCA08 VA: 0x55C0A08
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_ReferenceCount
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public bool get_IsRunning() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54929BC Offset: 0x548E9BC VA: 0x54929BC
	|-AsyncOperationBase<bool>.get_IsRunning
	|
	|-RVA: 0x55BA7F8 Offset: 0x55B67F8 VA: 0x55BA7F8
	|-AsyncOperationBase<long>.get_IsRunning
	|
	|-RVA: 0x55BC7D4 Offset: 0x55B87D4 VA: 0x55BC7D4
	|-AsyncOperationBase<object>.get_IsRunning
	|
	|-RVA: 0x55BE750 Offset: 0x55BA750 VA: 0x55BE750
	|-AsyncOperationBase<SceneInstance>.get_IsRunning
	|
	|-RVA: 0x55C0A30 Offset: 0x55BCA30 VA: 0x55C0A30
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_IsRunning
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_IsRunning(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54929C4 Offset: 0x548E9C4 VA: 0x54929C4
	|-AsyncOperationBase<bool>.set_IsRunning
	|
	|-RVA: 0x55BA800 Offset: 0x55B6800 VA: 0x55BA800
	|-AsyncOperationBase<long>.set_IsRunning
	|
	|-RVA: 0x55BC7DC Offset: 0x55B87DC VA: 0x55BC7DC
	|-AsyncOperationBase<object>.set_IsRunning
	|
	|-RVA: 0x55BE758 Offset: 0x55BA758 VA: 0x55BE758
	|-AsyncOperationBase<SceneInstance>.set_IsRunning
	|
	|-RVA: 0x55C0A58 Offset: 0x55BCA58 VA: 0x55C0A58
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_IsRunning
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54929D0 Offset: 0x548E9D0 VA: 0x54929D0
	|-AsyncOperationBase<bool>..ctor
	|
	|-RVA: 0x55BA80C Offset: 0x55B680C VA: 0x55BA80C
	|-AsyncOperationBase<long>..ctor
	|
	|-RVA: 0x55BC7E8 Offset: 0x55B87E8 VA: 0x55BC7E8
	|-AsyncOperationBase<object>..ctor
	|
	|-RVA: 0x55BE764 Offset: 0x55BA764 VA: 0x55BE764
	|-AsyncOperationBase<SceneInstance>..ctor
	|
	|-RVA: 0x55C0A78 Offset: 0x55BCA78 VA: 0x55C0A78
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static string ShortenPath(string p, bool keepExtension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5492AA8 Offset: 0x548EAA8 VA: 0x5492AA8
	|-AsyncOperationBase<bool>.ShortenPath
	|
	|-RVA: 0x55BA8E4 Offset: 0x55B68E4 VA: 0x55BA8E4
	|-AsyncOperationBase<long>.ShortenPath
	|
	|-RVA: 0x55BC8C0 Offset: 0x55B88C0 VA: 0x55BC8C0
	|-AsyncOperationBase<object>.ShortenPath
	|
	|-RVA: 0x55BE83C Offset: 0x55BA83C VA: 0x55BE83C
	|-AsyncOperationBase<SceneInstance>.ShortenPath
	|
	|-RVA: 0x55C0B88 Offset: 0x55BCB88 VA: 0x55C0B88
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.ShortenPath
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5492B34 Offset: 0x548EB34 VA: 0x5492B34
	|-AsyncOperationBase<bool>.WaitForCompletion
	|
	|-RVA: 0x55BA970 Offset: 0x55B6970 VA: 0x55BA970
	|-AsyncOperationBase<long>.WaitForCompletion
	|
	|-RVA: 0x55BC94C Offset: 0x55B894C VA: 0x55BC94C
	|-AsyncOperationBase<object>.WaitForCompletion
	|
	|-RVA: 0x55BE8C8 Offset: 0x55BA8C8 VA: 0x55BE8C8
	|-AsyncOperationBase<SceneInstance>.WaitForCompletion
	|
	|-RVA: 0x55C0C14 Offset: 0x55BCC14 VA: 0x55C0C14
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected virtual bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5492C60 Offset: 0x548EC60 VA: 0x5492C60
	|-AsyncOperationBase<bool>.InvokeWaitForCompletion
	|
	|-RVA: 0x55BAA9C Offset: 0x55B6A9C VA: 0x55BAA9C
	|-AsyncOperationBase<long>.InvokeWaitForCompletion
	|
	|-RVA: 0x55BCA78 Offset: 0x55B8A78 VA: 0x55BCA78
	|-AsyncOperationBase<object>.InvokeWaitForCompletion
	|
	|-RVA: 0x55BE9F4 Offset: 0x55BA9F4 VA: 0x55BE9F4
	|-AsyncOperationBase<SceneInstance>.InvokeWaitForCompletion
	|
	|-RVA: 0x55C0D40 Offset: 0x55BCD40 VA: 0x55C0D40
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1
	protected internal void IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5492C68 Offset: 0x548EC68 VA: 0x5492C68
	|-AsyncOperationBase<bool>.IncrementReferenceCount
	|
	|-RVA: 0x55BAAA4 Offset: 0x55B6AA4 VA: 0x55BAAA4
	|-AsyncOperationBase<long>.IncrementReferenceCount
	|
	|-RVA: 0x55BCA80 Offset: 0x55B8A80 VA: 0x55BCA80
	|-AsyncOperationBase<object>.IncrementReferenceCount
	|
	|-RVA: 0x55BE9FC Offset: 0x55BA9FC VA: 0x55BE9FC
	|-AsyncOperationBase<SceneInstance>.IncrementReferenceCount
	|
	|-RVA: 0x55C0D48 Offset: 0x55BCD48 VA: 0x55C0D48
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1
	protected internal void DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5492D74 Offset: 0x548ED74 VA: 0x5492D74
	|-AsyncOperationBase<bool>.DecrementReferenceCount
	|
	|-RVA: 0x55BABB0 Offset: 0x55B6BB0 VA: 0x55BABB0
	|-AsyncOperationBase<long>.DecrementReferenceCount
	|
	|-RVA: 0x55BCB8C Offset: 0x55B8B8C VA: 0x55BCB8C
	|-AsyncOperationBase<object>.DecrementReferenceCount
	|
	|-RVA: 0x55BEB08 Offset: 0x55BAB08 VA: 0x55BEB08
	|-AsyncOperationBase<SceneInstance>.DecrementReferenceCount
	|
	|-RVA: 0x55C0F28 Offset: 0x55BCF28 VA: 0x55C0F28
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54930B0 Offset: 0x548F0B0 VA: 0x54930B0
	|-AsyncOperationBase<bool>.get_Task
	|
	|-RVA: 0x55BAEDC Offset: 0x55B6EDC VA: 0x55BAEDC
	|-AsyncOperationBase<long>.get_Task
	|
	|-RVA: 0x55BCEC4 Offset: 0x55B8EC4 VA: 0x55BCEC4
	|-AsyncOperationBase<object>.get_Task
	|
	|-RVA: 0x55BEE44 Offset: 0x55BAE44 VA: 0x55BEE44
	|-AsyncOperationBase<SceneInstance>.get_Task
	|
	|-RVA: 0x55C15C8 Offset: 0x55BD5C8 VA: 0x55C15C8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549318C Offset: 0x548F18C VA: 0x549318C
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x55BAFB8 Offset: 0x55B6FB8 VA: 0x55BAFB8
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x55BCFA0 Offset: 0x55B8FA0 VA: 0x55BCFA0
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x55BEF20 Offset: 0x55BAF20 VA: 0x55BEF20
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x55C17A8 Offset: 0x55BD7A8 VA: 0x55C17A8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54932C0 Offset: 0x548F2C0 VA: 0x54932C0
	|-AsyncOperationBase<bool>.ToString
	|
	|-RVA: 0x55BB0EC Offset: 0x55B70EC VA: 0x55BB0EC
	|-AsyncOperationBase<long>.ToString
	|
	|-RVA: 0x55BD0B4 Offset: 0x55B90B4 VA: 0x55BD0B4
	|-AsyncOperationBase<object>.ToString
	|
	|-RVA: 0x55BF05C Offset: 0x55BB05C VA: 0x55BF05C
	|-AsyncOperationBase<SceneInstance>.ToString
	|
	|-RVA: 0x55C19A4 Offset: 0x55BD9A4 VA: 0x55C19A4
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	private void RegisterForDeferredCallbackEvent(bool incrementReferenceCount = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54934AC Offset: 0x548F4AC VA: 0x54934AC
	|-AsyncOperationBase<bool>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x55BB2D8 Offset: 0x55B72D8 VA: 0x55BB2D8
	|-AsyncOperationBase<long>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x55BD278 Offset: 0x55B9278 VA: 0x55BD278
	|-AsyncOperationBase<object>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x55BF248 Offset: 0x55BB248 VA: 0x55BF248
	|-AsyncOperationBase<SceneInstance>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x55C1C18 Offset: 0x55BDC18 VA: 0x55C1C18
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.RegisterForDeferredCallbackEvent
	*/

	// RVA: -1 Offset: -1
	internal void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54934EC Offset: 0x548F4EC VA: 0x54934EC
	|-AsyncOperationBase<bool>.add_Completed
	|
	|-RVA: 0x55BB318 Offset: 0x55B7318 VA: 0x55BB318
	|-AsyncOperationBase<long>.add_Completed
	|
	|-RVA: 0x55BD2B8 Offset: 0x55B92B8 VA: 0x55BD2B8
	|-AsyncOperationBase<object>.add_Completed
	|
	|-RVA: 0x55BF288 Offset: 0x55BB288 VA: 0x55BF288
	|-AsyncOperationBase<SceneInstance>.add_Completed
	|
	|-RVA: 0x55C1CD0 Offset: 0x55BDCD0 VA: 0x55C1CD0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_Completed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493574 Offset: 0x548F574 VA: 0x5493574
	|-AsyncOperationBase<bool>.remove_Completed
	|
	|-RVA: 0x55BB3A0 Offset: 0x55B73A0 VA: 0x55BB3A0
	|-AsyncOperationBase<long>.remove_Completed
	|
	|-RVA: 0x55BD340 Offset: 0x55B9340 VA: 0x55BD340
	|-AsyncOperationBase<object>.remove_Completed
	|
	|-RVA: 0x55BF310 Offset: 0x55BB310 VA: 0x55BF310
	|-AsyncOperationBase<SceneInstance>.remove_Completed
	|
	|-RVA: 0x55C1D9C Offset: 0x55BDD9C VA: 0x55C1D9C
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	internal void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493590 Offset: 0x548F590 VA: 0x5493590
	|-AsyncOperationBase<bool>.add_Destroyed
	|
	|-RVA: 0x55BB3BC Offset: 0x55B73BC VA: 0x55BB3BC
	|-AsyncOperationBase<long>.add_Destroyed
	|
	|-RVA: 0x55BD35C Offset: 0x55B935C VA: 0x55BD35C
	|-AsyncOperationBase<object>.add_Destroyed
	|
	|-RVA: 0x55BF32C Offset: 0x55BB32C VA: 0x55BF32C
	|-AsyncOperationBase<SceneInstance>.add_Destroyed
	|
	|-RVA: 0x55C1DF8 Offset: 0x55BDDF8 VA: 0x55C1DF8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549361C Offset: 0x548F61C VA: 0x549361C
	|-AsyncOperationBase<bool>.remove_Destroyed
	|
	|-RVA: 0x55BB448 Offset: 0x55B7448 VA: 0x55BB448
	|-AsyncOperationBase<long>.remove_Destroyed
	|
	|-RVA: 0x55BD3E8 Offset: 0x55B93E8 VA: 0x55BD3E8
	|-AsyncOperationBase<object>.remove_Destroyed
	|
	|-RVA: 0x55BF3B8 Offset: 0x55BB3B8 VA: 0x55BF3B8
	|-AsyncOperationBase<SceneInstance>.remove_Destroyed
	|
	|-RVA: 0x55C1ED8 Offset: 0x55BDED8 VA: 0x55C1ED8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549367C Offset: 0x548F67C VA: 0x549367C
	|-AsyncOperationBase<bool>.add_CompletedTypeless
	|
	|-RVA: 0x55BB4A8 Offset: 0x55B74A8 VA: 0x55BB4A8
	|-AsyncOperationBase<long>.add_CompletedTypeless
	|
	|-RVA: 0x55BD448 Offset: 0x55B9448 VA: 0x55BD448
	|-AsyncOperationBase<object>.add_CompletedTypeless
	|
	|-RVA: 0x55BF418 Offset: 0x55BB418 VA: 0x55BF418
	|-AsyncOperationBase<SceneInstance>.add_CompletedTypeless
	|
	|-RVA: 0x55C1F64 Offset: 0x55BDF64 VA: 0x55C1F64
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493740 Offset: 0x548F740 VA: 0x5493740
	|-AsyncOperationBase<bool>.remove_CompletedTypeless
	|
	|-RVA: 0x55BB56C Offset: 0x55B756C VA: 0x55BB56C
	|-AsyncOperationBase<long>.remove_CompletedTypeless
	|
	|-RVA: 0x55BD50C Offset: 0x55B950C VA: 0x55BD50C
	|-AsyncOperationBase<object>.remove_CompletedTypeless
	|
	|-RVA: 0x55BF4DC Offset: 0x55BB4DC VA: 0x55BF4DC
	|-AsyncOperationBase<SceneInstance>.remove_CompletedTypeless
	|
	|-RVA: 0x55C2034 Offset: 0x55BE034 VA: 0x55C2034
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493828 Offset: 0x548F828 VA: 0x5493828
	|-AsyncOperationBase<bool>.get_Status
	|
	|-RVA: 0x55BB654 Offset: 0x55B7654 VA: 0x55BB654
	|-AsyncOperationBase<long>.get_Status
	|
	|-RVA: 0x55BD5F4 Offset: 0x55B95F4 VA: 0x55BD5F4
	|-AsyncOperationBase<object>.get_Status
	|
	|-RVA: 0x55BF5C4 Offset: 0x55BB5C4 VA: 0x55BF5C4
	|-AsyncOperationBase<SceneInstance>.get_Status
	|
	|-RVA: 0x55C2108 Offset: 0x55BE108 VA: 0x55C2108
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1
	internal Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493830 Offset: 0x548F830 VA: 0x5493830
	|-AsyncOperationBase<bool>.get_OperationException
	|
	|-RVA: 0x55BB65C Offset: 0x55B765C VA: 0x55BB65C
	|-AsyncOperationBase<long>.get_OperationException
	|
	|-RVA: 0x55BD5FC Offset: 0x55B95FC VA: 0x55BD5FC
	|-AsyncOperationBase<object>.get_OperationException
	|
	|-RVA: 0x55BF5CC Offset: 0x55BB5CC VA: 0x55BF5CC
	|-AsyncOperationBase<SceneInstance>.get_OperationException
	|
	|-RVA: 0x55C2130 Offset: 0x55BE130 VA: 0x55C2130
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	private void set_OperationException(Exception value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493838 Offset: 0x548F838 VA: 0x5493838
	|-AsyncOperationBase<bool>.set_OperationException
	|
	|-RVA: 0x55BB664 Offset: 0x55B7664 VA: 0x55BB664
	|-AsyncOperationBase<long>.set_OperationException
	|
	|-RVA: 0x55BD604 Offset: 0x55B9604 VA: 0x55BD604
	|-AsyncOperationBase<object>.set_OperationException
	|
	|-RVA: 0x55BF5D4 Offset: 0x55BB5D4 VA: 0x55BF5D4
	|-AsyncOperationBase<SceneInstance>.set_OperationException
	|
	|-RVA: 0x55C2158 Offset: 0x55BE158 VA: 0x55C2158
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.set_OperationException
	*/

	// RVA: -1 Offset: -1
	internal bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493984 Offset: 0x548F984 VA: 0x5493984
	|-AsyncOperationBase<bool>.MoveNext
	|
	|-RVA: 0x55BB7B0 Offset: 0x55B77B0 VA: 0x55BB7B0
	|-AsyncOperationBase<long>.MoveNext
	|
	|-RVA: 0x55BD750 Offset: 0x55B9750 VA: 0x55BD750
	|-AsyncOperationBase<object>.MoveNext
	|
	|-RVA: 0x55BF720 Offset: 0x55BB720 VA: 0x55BF720
	|-AsyncOperationBase<SceneInstance>.MoveNext
	|
	|-RVA: 0x55C22D0 Offset: 0x55BE2D0 VA: 0x55C22D0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493998 Offset: 0x548F998 VA: 0x5493998
	|-AsyncOperationBase<bool>.Reset
	|
	|-RVA: 0x55BB7C4 Offset: 0x55B77C4 VA: 0x55BB7C4
	|-AsyncOperationBase<long>.Reset
	|
	|-RVA: 0x55BD764 Offset: 0x55B9764 VA: 0x55BD764
	|-AsyncOperationBase<object>.Reset
	|
	|-RVA: 0x55BF734 Offset: 0x55BB734 VA: 0x55BF734
	|-AsyncOperationBase<SceneInstance>.Reset
	|
	|-RVA: 0x55C22F8 Offset: 0x55BE2F8 VA: 0x55C22F8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	internal object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549399C Offset: 0x548F99C VA: 0x549399C
	|-AsyncOperationBase<bool>.get_Current
	|
	|-RVA: 0x55BB7C8 Offset: 0x55B77C8 VA: 0x55BB7C8
	|-AsyncOperationBase<long>.get_Current
	|
	|-RVA: 0x55BD768 Offset: 0x55B9768 VA: 0x55BD768
	|-AsyncOperationBase<object>.get_Current
	|
	|-RVA: 0x55BF738 Offset: 0x55BB738 VA: 0x55BF738
	|-AsyncOperationBase<SceneInstance>.get_Current
	|
	|-RVA: 0x55C22FC Offset: 0x55BE2FC VA: 0x55C22FC
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54939A4 Offset: 0x548F9A4 VA: 0x54939A4
	|-AsyncOperationBase<bool>.get_IsDone
	|
	|-RVA: 0x55BB7D0 Offset: 0x55B77D0 VA: 0x55BB7D0
	|-AsyncOperationBase<long>.get_IsDone
	|
	|-RVA: 0x55BD770 Offset: 0x55B9770 VA: 0x55BD770
	|-AsyncOperationBase<object>.get_IsDone
	|
	|-RVA: 0x55BF740 Offset: 0x55BB740 VA: 0x55BF740
	|-AsyncOperationBase<SceneInstance>.get_IsDone
	|
	|-RVA: 0x55C2304 Offset: 0x55BE304 VA: 0x55C2304
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	internal float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54939B8 Offset: 0x548F9B8 VA: 0x54939B8
	|-AsyncOperationBase<bool>.get_PercentComplete
	|
	|-RVA: 0x55BB7E4 Offset: 0x55B77E4 VA: 0x55BB7E4
	|-AsyncOperationBase<long>.get_PercentComplete
	|
	|-RVA: 0x55BD784 Offset: 0x55B9784 VA: 0x55BD784
	|-AsyncOperationBase<object>.get_PercentComplete
	|
	|-RVA: 0x55BF754 Offset: 0x55BB754 VA: 0x55BF754
	|-AsyncOperationBase<SceneInstance>.get_PercentComplete
	|
	|-RVA: 0x55C2364 Offset: 0x55BE364 VA: 0x55C2364
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal void InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493A54 Offset: 0x548FA54 VA: 0x5493A54
	|-AsyncOperationBase<bool>.InvokeCompletionEvent
	|
	|-RVA: 0x55BB880 Offset: 0x55B7880 VA: 0x55BB880
	|-AsyncOperationBase<long>.InvokeCompletionEvent
	|
	|-RVA: 0x55BD820 Offset: 0x55B9820 VA: 0x55BD820
	|-AsyncOperationBase<object>.InvokeCompletionEvent
	|
	|-RVA: 0x55BF7F0 Offset: 0x55BB7F0 VA: 0x55BF7F0
	|-AsyncOperationBase<SceneInstance>.InvokeCompletionEvent
	|
	|-RVA: 0x55C2420 Offset: 0x55BE420 VA: 0x55C2420
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493B74 Offset: 0x548FB74 VA: 0x5493B74
	|-AsyncOperationBase<bool>.get_Handle
	|
	|-RVA: 0x55BB9A0 Offset: 0x55B79A0 VA: 0x55BB9A0
	|-AsyncOperationBase<long>.get_Handle
	|
	|-RVA: 0x55BD920 Offset: 0x55B9920 VA: 0x55BD920
	|-AsyncOperationBase<object>.get_Handle
	|
	|-RVA: 0x55BF910 Offset: 0x55BB910 VA: 0x55BF910
	|-AsyncOperationBase<SceneInstance>.get_Handle
	|
	|-RVA: 0x55C2700 Offset: 0x55BE700 VA: 0x55C2700
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.get_Handle
	*/

	// RVA: -1 Offset: -1
	private void UpdateCallback(float unscaledDeltaTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493B94 Offset: 0x548FB94 VA: 0x5493B94
	|-AsyncOperationBase<bool>.UpdateCallback
	|
	|-RVA: 0x55BB9C0 Offset: 0x55B79C0 VA: 0x55BB9C0
	|-AsyncOperationBase<long>.UpdateCallback
	|
	|-RVA: 0x55BD940 Offset: 0x55B9940 VA: 0x55BD940
	|-AsyncOperationBase<object>.UpdateCallback
	|
	|-RVA: 0x55BF930 Offset: 0x55BB930 VA: 0x55BF930
	|-AsyncOperationBase<SceneInstance>.UpdateCallback
	|
	|-RVA: 0x55C2720 Offset: 0x55BE720 VA: 0x55C2720
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UpdateCallback
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493C60 Offset: 0x548FC60 VA: 0x5493C60
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0x55BBA8C Offset: 0x55B7A8C VA: 0x55BBA8C
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0x55BDA0C Offset: 0x55B9A0C VA: 0x55BDA0C
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0x55BF9FC Offset: 0x55BB9FC VA: 0x55BF9FC
	|-AsyncOperationBase<SceneInstance>.Complete
	|
	|-RVA: 0x55C27EC Offset: 0x55BE7EC VA: 0x55C27EC
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Complete
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493C7C Offset: 0x548FC7C VA: 0x5493C7C
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0x55BBAA4 Offset: 0x55B7AA4 VA: 0x55BBAA4
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0x55BDA24 Offset: 0x55B9A24 VA: 0x55BDA24
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0x55BFA14 Offset: 0x55BBA14 VA: 0x55BFA14
	|-AsyncOperationBase<SceneInstance>.Complete
	|
	|-RVA: 0x55C28D8 Offset: 0x55BE8D8 VA: 0x55C28D8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Complete
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5493D38 Offset: 0x548FD38 VA: 0x5493D38
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0x55BBB60 Offset: 0x55B7B60 VA: 0x55BBB60
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0x55BDAE0 Offset: 0x55B9AE0 VA: 0x55BDAE0
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0x55BFAE0 Offset: 0x55BBAE0 VA: 0x55BFAE0
	|-AsyncOperationBase<SceneInstance>.Complete
	|
	|-RVA: 0x55C2AF0 Offset: 0x55BEAF0 VA: 0x55C2AF0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Complete
	*/

	// RVA: -1 Offset: -1
	internal void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494220 Offset: 0x5490220 VA: 0x5494220
	|-AsyncOperationBase<bool>.Start
	|
	|-RVA: 0x55BC044 Offset: 0x55B8044 VA: 0x55BC044
	|-AsyncOperationBase<long>.Start
	|
	|-RVA: 0x55BDFD4 Offset: 0x55B9FD4 VA: 0x55BDFD4
	|-AsyncOperationBase<object>.Start
	|
	|-RVA: 0x55BFFDC Offset: 0x55BBFDC VA: 0x55BFFDC
	|-AsyncOperationBase<SceneInstance>.Start
	|
	|-RVA: 0x55C32AC Offset: 0x55BF2AC VA: 0x55C32AC
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.Start
	*/

	// RVA: -1 Offset: -1
	internal void InvokeExecute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494404 Offset: 0x5490404 VA: 0x5494404
	|-AsyncOperationBase<bool>.InvokeExecute
	|
	|-RVA: 0x55BC228 Offset: 0x55B8228 VA: 0x55BC228
	|-AsyncOperationBase<long>.InvokeExecute
	|
	|-RVA: 0x55BE1B8 Offset: 0x55BA1B8 VA: 0x55BE1B8
	|-AsyncOperationBase<object>.InvokeExecute
	|
	|-RVA: 0x55C01C0 Offset: 0x55BC1C0 VA: 0x55C01C0
	|-AsyncOperationBase<SceneInstance>.InvokeExecute
	|
	|-RVA: 0x55C3580 Offset: 0x55BF580 VA: 0x55C3580
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeExecute
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54944CC Offset: 0x54904CC VA: 0x54944CC
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x55BC2F0 Offset: 0x55B82F0 VA: 0x55BC2F0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x55BE280 Offset: 0x55BA280 VA: 0x55BE280
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x55C0288 Offset: 0x55BC288 VA: 0x55C0288
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x55C36D4 Offset: 0x55BF6D4 VA: 0x55C36D4
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54944DC Offset: 0x54904DC VA: 0x54944DC
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x55BC300 Offset: 0x55B8300 VA: 0x55BC300
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x55BE290 Offset: 0x55BA290 VA: 0x55BE290
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x55C0298 Offset: 0x55BC298 VA: 0x55C0298
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x55C36E8 Offset: 0x55BF6E8 VA: 0x55C36E8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54944EC Offset: 0x54904EC VA: 0x54944EC
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x55BC310 Offset: 0x55B8310 VA: 0x55BC310
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x55BE2A0 Offset: 0x55BA2A0 VA: 0x55BE2A0
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x55C02A8 Offset: 0x55BC2A8 VA: 0x55C02A8
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x55C36FC Offset: 0x55BF6FC VA: 0x55C36FC
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54944F0 Offset: 0x54904F0 VA: 0x54944F0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x55BC314 Offset: 0x55B8314 VA: 0x55BC314
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x55BE2A4 Offset: 0x55BA2A4 VA: 0x55BE2A4
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x55C02AC Offset: 0x55BC2AC VA: 0x55C02AC
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x55C3710 Offset: 0x55BF710 VA: 0x55C3710
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54944F4 Offset: 0x54904F4 VA: 0x54944F4
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x55BC318 Offset: 0x55B8318 VA: 0x55BC318
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x55BE2A8 Offset: 0x55BA2A8 VA: 0x55BE2A8
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x55C02B0 Offset: 0x55BC2B0 VA: 0x55C02B0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x55C3724 Offset: 0x55BF724 VA: 0x55C3724
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54944FC Offset: 0x54904FC VA: 0x54944FC
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x55BC320 Offset: 0x55B8320 VA: 0x55BC320
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x55BE2B0 Offset: 0x55BA2B0 VA: 0x55BE2B0
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x55C02B8 Offset: 0x55BC2B8 VA: 0x55C02B8
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x55C3738 Offset: 0x55BF738 VA: 0x55C3738
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494504 Offset: 0x5490504 VA: 0x5494504
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x55BC328 Offset: 0x55B8328 VA: 0x55BC328
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x55BE2B8 Offset: 0x55BA2B8 VA: 0x55BE2B8
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x55C02C0 Offset: 0x55BC2C0 VA: 0x55C02C0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x55C374C Offset: 0x55BF74C VA: 0x55C374C
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494508 Offset: 0x5490508 VA: 0x5494508
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x55BC32C Offset: 0x55B832C VA: 0x55BC32C
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x55BE2BC Offset: 0x55BA2BC VA: 0x55BE2BC
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x55C02C4 Offset: 0x55BC2C4 VA: 0x55C02C4
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x55C3760 Offset: 0x55BF760 VA: 0x55C3760
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494510 Offset: 0x5490510 VA: 0x5494510
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x55BC334 Offset: 0x55B8334 VA: 0x55BC334
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x55BE2C4 Offset: 0x55BA2C4 VA: 0x55BE2C4
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x55C02CC Offset: 0x55BC2CC VA: 0x55C02CC
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x55C3774 Offset: 0x55BF774 VA: 0x55C3774
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494518 Offset: 0x5490518 VA: 0x5494518
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x55BC33C Offset: 0x55B833C VA: 0x55BC33C
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x55BE2CC Offset: 0x55BA2CC VA: 0x55BE2CC
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x55C02D4 Offset: 0x55BC2D4 VA: 0x55C02D4
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x55C3788 Offset: 0x55BF788 VA: 0x55C3788
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549452C Offset: 0x549052C VA: 0x549452C
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x55BC350 Offset: 0x55B8350 VA: 0x55BC350
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x55BE2E0 Offset: 0x55BA2E0 VA: 0x55BE2E0
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x55C02E8 Offset: 0x55BC2E8 VA: 0x55C02E8
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x55C379C Offset: 0x55BF79C VA: 0x55C379C
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54945BC Offset: 0x54905BC VA: 0x54945BC
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x55BC3C8 Offset: 0x55B83C8 VA: 0x55BC3C8
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x55BE358 Offset: 0x55BA358 VA: 0x55BE358
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x55C0360 Offset: 0x55BC360 VA: 0x55C0360
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x55C3820 Offset: 0x55BF820 VA: 0x55C3820
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54945C4 Offset: 0x54905C4 VA: 0x54945C4
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x55BC3D0 Offset: 0x55B83D0 VA: 0x55BC3D0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x55BE360 Offset: 0x55BA360 VA: 0x55BE360
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x55C0368 Offset: 0x55BC368 VA: 0x55C0368
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x55C3834 Offset: 0x55BF834 VA: 0x55C3834
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54945D4 Offset: 0x54905D4 VA: 0x54945D4
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x55BC3E0 Offset: 0x55B83E0 VA: 0x55BC3E0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x55BE370 Offset: 0x55BA370 VA: 0x55BE370
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x55C0378 Offset: 0x55BC378 VA: 0x55C0378
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x55C3844 Offset: 0x55BF844 VA: 0x55C3844
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54945FC Offset: 0x54905FC VA: 0x54945FC
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x55BC408 Offset: 0x55B8408 VA: 0x55BC408
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x55BE378 Offset: 0x55BA378 VA: 0x55BE378
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x55C03A4 Offset: 0x55BC3A4 VA: 0x55C03A4
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x55C38E8 Offset: 0x55BF8E8 VA: 0x55C38E8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494660 Offset: 0x5490660 VA: 0x5494660
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x55BC46C Offset: 0x55B846C VA: 0x55BC46C
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x55BE3DC Offset: 0x55BA3DC VA: 0x55BE3DC
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x55C0408 Offset: 0x55BC408 VA: 0x55C0408
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x55C394C Offset: 0x55BF94C VA: 0x55C394C
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494670 Offset: 0x5490670 VA: 0x5494670
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x55BC47C Offset: 0x55B847C VA: 0x55BC47C
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x55BE3EC Offset: 0x55BA3EC VA: 0x55BE3EC
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x55C0418 Offset: 0x55BC418 VA: 0x55C0418
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x55C395C Offset: 0x55BF95C VA: 0x55C395C
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494680 Offset: 0x5490680 VA: 0x5494680
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x55BC48C Offset: 0x55B848C VA: 0x55BC48C
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x55BE3FC Offset: 0x55BA3FC VA: 0x55BE3FC
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x55C0428 Offset: 0x55BC428 VA: 0x55C0428
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x55C3970 Offset: 0x55BF970 VA: 0x55C3970
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494690 Offset: 0x5490690 VA: 0x5494690
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x55BC49C Offset: 0x55B849C VA: 0x55BC49C
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x55BE40C Offset: 0x55BA40C VA: 0x55BE40C
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x55C0438 Offset: 0x55BC438 VA: 0x55C0438
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x55C3984 Offset: 0x55BF984 VA: 0x55C3984
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54946A0 Offset: 0x54906A0 VA: 0x54946A0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x55BC4AC Offset: 0x55B84AC VA: 0x55BC4AC
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x55BE41C Offset: 0x55BA41C VA: 0x55BE41C
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x55C0448 Offset: 0x55BC448 VA: 0x55C0448
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x55C3998 Offset: 0x55BF998 VA: 0x55C3998
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal virtual void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54946E0 Offset: 0x54906E0 VA: 0x54946E0
	|-AsyncOperationBase<bool>.ReleaseDependencies
	|
	|-RVA: 0x55BC4EC Offset: 0x55B84EC VA: 0x55BC4EC
	|-AsyncOperationBase<long>.ReleaseDependencies
	|
	|-RVA: 0x55BE45C Offset: 0x55BA45C VA: 0x55BE45C
	|-AsyncOperationBase<object>.ReleaseDependencies
	|
	|-RVA: 0x55C0488 Offset: 0x55BC488 VA: 0x55C0488
	|-AsyncOperationBase<SceneInstance>.ReleaseDependencies
	|
	|-RVA: 0x55C39E0 Offset: 0x55BF9E0 VA: 0x55C39E0
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private DownloadStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54946E4 Offset: 0x54906E4 VA: 0x54946E4
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x55BC4F0 Offset: 0x55B84F0 VA: 0x55BC4F0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x55BE460 Offset: 0x55BA460 VA: 0x55BE460
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x55C048C Offset: 0x55BC48C VA: 0x55C048C
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x55C39E4 Offset: 0x55BF9E4 VA: 0x55C39E4
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal virtual DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5494720 Offset: 0x5490720 VA: 0x5494720
	|-AsyncOperationBase<bool>.GetDownloadStatus
	|
	|-RVA: 0x55BC52C Offset: 0x55B852C VA: 0x55BC52C
	|-AsyncOperationBase<long>.GetDownloadStatus
	|
	|-RVA: 0x55BE49C Offset: 0x55BA49C VA: 0x55BE49C
	|-AsyncOperationBase<object>.GetDownloadStatus
	|
	|-RVA: 0x55C04C8 Offset: 0x55BC4C8 VA: 0x55C04C8
	|-AsyncOperationBase<SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0x55C3A20 Offset: 0x55BFA20 VA: 0x55C3A20
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <.ctor>b__38_0(AsyncOperationHandle o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54947A8 Offset: 0x54907A8 VA: 0x54947A8
	|-AsyncOperationBase<bool>.<.ctor>b__38_0
	|
	|-RVA: 0x55BC5B4 Offset: 0x55B85B4 VA: 0x55BC5B4
	|-AsyncOperationBase<long>.<.ctor>b__38_0
	|
	|-RVA: 0x55BE524 Offset: 0x55BA524 VA: 0x55BE524
	|-AsyncOperationBase<object>.<.ctor>b__38_0
	|
	|-RVA: 0x55C0550 Offset: 0x55BC550 VA: 0x55C0550
	|-AsyncOperationBase<SceneInstance>.<.ctor>b__38_0
	|
	|-RVA: 0x55C3AB8 Offset: 0x55BFAB8 VA: 0x55C3AB8
	|-AsyncOperationBase<__Il2CppFullySharedGenericType>.<.ctor>b__38_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AsyncOperationHandle.<>c<TObject> // TypeDefIndex: 25077
{
	// Fields
	public static readonly AsyncOperationHandle.<>c<TObject> <>9; // 0x0
	public static Action<AsyncOperationHandle<TObject>> <>9__20_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4820568 Offset: 0x481C568 VA: 0x4820568
	|-AsyncOperationHandle.<>c<bool>..cctor
	|
	|-RVA: 0x48226DC Offset: 0x481E6DC VA: 0x48226DC
	|-AsyncOperationHandle.<>c<long>..cctor
	|
	|-RVA: 0x48230A4 Offset: 0x481F0A4 VA: 0x48230A4
	|-AsyncOperationHandle.<>c<object>..cctor
	|
	|-RVA: 0x4825A0C Offset: 0x4821A0C VA: 0x4825A0C
	|-AsyncOperationHandle.<>c<SceneInstance>..cctor
	|
	|-RVA: 0x482740C Offset: 0x482340C VA: 0x482740C
	|-AsyncOperationHandle.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4820624 Offset: 0x481C624 VA: 0x4820624
	|-AsyncOperationHandle.<>c<bool>..ctor
	|
	|-RVA: 0x4822798 Offset: 0x481E798 VA: 0x4822798
	|-AsyncOperationHandle.<>c<long>..ctor
	|
	|-RVA: 0x4823160 Offset: 0x481F160 VA: 0x4823160
	|-AsyncOperationHandle.<>c<object>..ctor
	|
	|-RVA: 0x4825AC8 Offset: 0x4821AC8 VA: 0x4825AC8
	|-AsyncOperationHandle.<>c<SceneInstance>..ctor
	|
	|-RVA: 0x4827500 Offset: 0x4823500 VA: 0x4827500
	|-AsyncOperationHandle.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ReleaseHandleOnCompletion>b__20_0(AsyncOperationHandle<TObject> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482062C Offset: 0x481C62C VA: 0x482062C
	|-AsyncOperationHandle.<>c<bool>.<ReleaseHandleOnCompletion>b__20_0
	|
	|-RVA: 0x48227A0 Offset: 0x481E7A0 VA: 0x48227A0
	|-AsyncOperationHandle.<>c<long>.<ReleaseHandleOnCompletion>b__20_0
	|
	|-RVA: 0x4823168 Offset: 0x481F168 VA: 0x4823168
	|-AsyncOperationHandle.<>c<object>.<ReleaseHandleOnCompletion>b__20_0
	|
	|-RVA: 0x4825AD0 Offset: 0x4821AD0 VA: 0x4825AD0
	|-AsyncOperationHandle.<>c<SceneInstance>.<ReleaseHandleOnCompletion>b__20_0
	|
	|-RVA: 0x4827508 Offset: 0x4823508 VA: 0x4827508
	|-AsyncOperationHandle.<>c<__Il2CppFullySharedGenericType>.<ReleaseHandleOnCompletion>b__20_0
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct AsyncOperationHandle<TObject> : IEnumerator, IEquatable<AsyncOperationHandle<TObject>> // TypeDefIndex: 25078
{
	// Fields
	internal AsyncOperationBase<TObject> m_InternalOp; // 0x0
	private int m_Version; // 0x0
	private string m_LocationName; // 0x0

	// Properties
	internal int Version { get; }
	internal string LocationName { get; set; }
	public string DebugName { get; }
	internal AsyncOperationBase<TObject> InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public TObject Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<TObject> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C3ACC Offset: 0x55BFACC VA: 0x55C3ACC
	|-AsyncOperationHandle<bool>.get_Version
	|
	|-RVA: 0x55C502C Offset: 0x55C102C VA: 0x55C502C
	|-AsyncOperationHandle<long>.get_Version
	|
	|-RVA: 0x55C6588 Offset: 0x55C2588 VA: 0x55C6588
	|-AsyncOperationHandle<object>.get_Version
	|
	|-RVA: 0x55C7AB0 Offset: 0x55C3AB0 VA: 0x55C7AB0
	|-AsyncOperationHandle<SceneInstance>.get_Version
	|
	|-RVA: 0x55C9014 Offset: 0x55C5014 VA: 0x55C9014
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Version
	*/

	// RVA: -1 Offset: -1
	internal string get_LocationName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C3AD4 Offset: 0x55BFAD4 VA: 0x55C3AD4
	|-AsyncOperationHandle<bool>.get_LocationName
	|
	|-RVA: 0x55C5034 Offset: 0x55C1034 VA: 0x55C5034
	|-AsyncOperationHandle<long>.get_LocationName
	|
	|-RVA: 0x55C6590 Offset: 0x55C2590 VA: 0x55C6590
	|-AsyncOperationHandle<object>.get_LocationName
	|
	|-RVA: 0x55C7AB8 Offset: 0x55C3AB8 VA: 0x55C7AB8
	|-AsyncOperationHandle<SceneInstance>.get_LocationName
	|
	|-RVA: 0x55C901C Offset: 0x55C501C VA: 0x55C901C
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_LocationName
	*/

	// RVA: -1 Offset: -1
	internal void set_LocationName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C3ADC Offset: 0x55BFADC VA: 0x55C3ADC
	|-AsyncOperationHandle<bool>.set_LocationName
	|
	|-RVA: 0x55C503C Offset: 0x55C103C VA: 0x55C503C
	|-AsyncOperationHandle<long>.set_LocationName
	|
	|-RVA: 0x55C6598 Offset: 0x55C2598 VA: 0x55C6598
	|-AsyncOperationHandle<object>.set_LocationName
	|
	|-RVA: 0x55C7AC0 Offset: 0x55C3AC0 VA: 0x55C7AC0
	|-AsyncOperationHandle<SceneInstance>.set_LocationName
	|
	|-RVA: 0x55C9024 Offset: 0x55C5024 VA: 0x55C9024
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.set_LocationName
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle op_Implicit(AsyncOperationHandle<TObject> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C3AE4 Offset: 0x55BFAE4 VA: 0x55C3AE4
	|-AsyncOperationHandle<bool>.op_Implicit
	|
	|-RVA: 0x55C5044 Offset: 0x55C1044 VA: 0x55C5044
	|-AsyncOperationHandle<long>.op_Implicit
	|
	|-RVA: 0x55C65A0 Offset: 0x55C25A0 VA: 0x55C65A0
	|-AsyncOperationHandle<object>.op_Implicit
	|
	|-RVA: 0x55C7AC8 Offset: 0x55C3AC8 VA: 0x55C7AC8
	|-AsyncOperationHandle<SceneInstance>.op_Implicit
	|
	|-RVA: 0x55C902C Offset: 0x55C502C VA: 0x55C902C
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(AsyncOperationBase<TObject> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C3B04 Offset: 0x55BFB04 VA: 0x55C3B04
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x55C5064 Offset: 0x55C1064 VA: 0x55C5064
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x55C65C0 Offset: 0x55C25C0 VA: 0x55C65C0
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x55C7AE8 Offset: 0x55C3AE8 VA: 0x55C7AE8
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0x55C904C Offset: 0x55C504C VA: 0x55C904C
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public DownloadStatus GetDownloadStatus() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C3B5C Offset: 0x55BFB5C VA: 0x55C3B5C
	|-AsyncOperationHandle<bool>.GetDownloadStatus
	|
	|-RVA: 0x55C50BC Offset: 0x55C10BC VA: 0x55C50BC
	|-AsyncOperationHandle<long>.GetDownloadStatus
	|
	|-RVA: 0x55C6618 Offset: 0x55C2618 VA: 0x55C6618
	|-AsyncOperationHandle<object>.GetDownloadStatus
	|
	|-RVA: 0x55C7B40 Offset: 0x55C3B40 VA: 0x55C7B40
	|-AsyncOperationHandle<SceneInstance>.GetDownloadStatus
	|
	|-RVA: 0x55C90E8 Offset: 0x55C50E8 VA: 0x55C90E8
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C3C18 Offset: 0x55BFC18 VA: 0x55C3C18
	|-AsyncOperationHandle<bool>.InternalGetDownloadStatus
	|
	|-RVA: 0x55C5178 Offset: 0x55C1178 VA: 0x55C5178
	|-AsyncOperationHandle<long>.InternalGetDownloadStatus
	|
	|-RVA: 0x55C66D4 Offset: 0x55C26D4 VA: 0x55C66D4
	|-AsyncOperationHandle<object>.InternalGetDownloadStatus
	|
	|-RVA: 0x55C7BFC Offset: 0x55C3BFC VA: 0x55C7BFC
	|-AsyncOperationHandle<SceneInstance>.InternalGetDownloadStatus
	|
	|-RVA: 0x55C91DC Offset: 0x55C51DC VA: 0x55C91DC
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.InternalGetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C3D8C Offset: 0x55BFD8C VA: 0x55C3D8C
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x55C52EC Offset: 0x55C12EC VA: 0x55C52EC
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x55C6848 Offset: 0x55C2848 VA: 0x55C6848
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x55C7D70 Offset: 0x55C3D70 VA: 0x55C7D70
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0x55C93F8 Offset: 0x55C53F8 VA: 0x55C93F8
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C3F24 Offset: 0x55BFF24 VA: 0x55C3F24
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x55C5484 Offset: 0x55C1484 VA: 0x55C5484
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x55C69E0 Offset: 0x55C29E0 VA: 0x55C69E0
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x55C7F08 Offset: 0x55C3F08 VA: 0x55C7F08
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0x55C9590 Offset: 0x55C5590 VA: 0x55C9590
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4030 Offset: 0x55C0030 VA: 0x55C4030
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x55C5590 Offset: 0x55C1590 VA: 0x55C5590
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x55C6AEC Offset: 0x55C2AEC VA: 0x55C6AEC
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x55C8014 Offset: 0x55C4014 VA: 0x55C8014
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0x55C969C Offset: 0x55C569C VA: 0x55C969C
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C41CC Offset: 0x55C01CC VA: 0x55C41CC
	|-AsyncOperationHandle<bool>..ctor
	|
	|-RVA: 0x55C572C Offset: 0x55C172C VA: 0x55C572C
	|-AsyncOperationHandle<long>..ctor
	|
	|-RVA: 0x55C6C88 Offset: 0x55C2C88 VA: 0x55C6C88
	|-AsyncOperationHandle<object>..ctor
	|
	|-RVA: 0x55C81B0 Offset: 0x55C41B0 VA: 0x55C81B0
	|-AsyncOperationHandle<SceneInstance>..ctor
	|
	|-RVA: 0x55C9838 Offset: 0x55C5838 VA: 0x55C9838
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C42DC Offset: 0x55C02DC VA: 0x55C42DC
	|-AsyncOperationHandle<bool>.Acquire
	|
	|-RVA: 0x55C583C Offset: 0x55C183C VA: 0x55C583C
	|-AsyncOperationHandle<long>.Acquire
	|
	|-RVA: 0x55C6D98 Offset: 0x55C2D98 VA: 0x55C6D98
	|-AsyncOperationHandle<object>.Acquire
	|
	|-RVA: 0x55C82C0 Offset: 0x55C42C0 VA: 0x55C82C0
	|-AsyncOperationHandle<SceneInstance>.Acquire
	|
	|-RVA: 0x55C9948 Offset: 0x55C5948 VA: 0x55C9948
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4360 Offset: 0x55C0360 VA: 0x55C4360
	|-AsyncOperationHandle<bool>.add_Completed
	|
	|-RVA: 0x55C58C0 Offset: 0x55C18C0 VA: 0x55C58C0
	|-AsyncOperationHandle<long>.add_Completed
	|
	|-RVA: 0x55C6E1C Offset: 0x55C2E1C VA: 0x55C6E1C
	|-AsyncOperationHandle<object>.add_Completed
	|
	|-RVA: 0x55C8344 Offset: 0x55C4344 VA: 0x55C8344
	|-AsyncOperationHandle<SceneInstance>.add_Completed
	|
	|-RVA: 0x55C9A3C Offset: 0x55C5A3C VA: 0x55C9A3C
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.add_Completed
	*/

	// RVA: -1 Offset: -1
	public void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C43D4 Offset: 0x55C03D4 VA: 0x55C43D4
	|-AsyncOperationHandle<bool>.remove_Completed
	|
	|-RVA: 0x55C5934 Offset: 0x55C1934 VA: 0x55C5934
	|-AsyncOperationHandle<long>.remove_Completed
	|
	|-RVA: 0x55C6E90 Offset: 0x55C2E90 VA: 0x55C6E90
	|-AsyncOperationHandle<object>.remove_Completed
	|
	|-RVA: 0x55C83B8 Offset: 0x55C43B8 VA: 0x55C83B8
	|-AsyncOperationHandle<SceneInstance>.remove_Completed
	|
	|-RVA: 0x55C9B28 Offset: 0x55C5B28 VA: 0x55C9B28
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	public void ReleaseHandleOnCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4448 Offset: 0x55C0448 VA: 0x55C4448
	|-AsyncOperationHandle<bool>.ReleaseHandleOnCompletion
	|
	|-RVA: 0x55C59C8 Offset: 0x55C19C8 VA: 0x55C59C8
	|-AsyncOperationHandle<long>.ReleaseHandleOnCompletion
	|
	|-RVA: 0x55C6F24 Offset: 0x55C2F24 VA: 0x55C6F24
	|-AsyncOperationHandle<object>.ReleaseHandleOnCompletion
	|
	|-RVA: 0x55C844C Offset: 0x55C444C VA: 0x55C844C
	|-AsyncOperationHandle<SceneInstance>.ReleaseHandleOnCompletion
	|
	|-RVA: 0x55C9C14 Offset: 0x55C5C14 VA: 0x55C9C14
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.ReleaseHandleOnCompletion
	*/

	// RVA: -1 Offset: -1
	public void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4640 Offset: 0x55C0640 VA: 0x55C4640
	|-AsyncOperationHandle<bool>.add_CompletedTypeless
	|
	|-RVA: 0x55C5BC0 Offset: 0x55C1BC0 VA: 0x55C5BC0
	|-AsyncOperationHandle<long>.add_CompletedTypeless
	|
	|-RVA: 0x55C711C Offset: 0x55C311C VA: 0x55C711C
	|-AsyncOperationHandle<object>.add_CompletedTypeless
	|
	|-RVA: 0x55C8644 Offset: 0x55C4644 VA: 0x55C8644
	|-AsyncOperationHandle<SceneInstance>.add_CompletedTypeless
	|
	|-RVA: 0x55C9E80 Offset: 0x55C5E80 VA: 0x55C9E80
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C46B4 Offset: 0x55C06B4 VA: 0x55C46B4
	|-AsyncOperationHandle<bool>.remove_CompletedTypeless
	|
	|-RVA: 0x55C5C34 Offset: 0x55C1C34 VA: 0x55C5C34
	|-AsyncOperationHandle<long>.remove_CompletedTypeless
	|
	|-RVA: 0x55C7190 Offset: 0x55C3190 VA: 0x55C7190
	|-AsyncOperationHandle<object>.remove_CompletedTypeless
	|
	|-RVA: 0x55C86B8 Offset: 0x55C46B8 VA: 0x55C86B8
	|-AsyncOperationHandle<SceneInstance>.remove_CompletedTypeless
	|
	|-RVA: 0x55C9F6C Offset: 0x55C5F6C VA: 0x55C9F6C
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	public string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4728 Offset: 0x55C0728 VA: 0x55C4728
	|-AsyncOperationHandle<bool>.get_DebugName
	|
	|-RVA: 0x55C5CA8 Offset: 0x55C1CA8 VA: 0x55C5CA8
	|-AsyncOperationHandle<long>.get_DebugName
	|
	|-RVA: 0x55C7204 Offset: 0x55C3204 VA: 0x55C7204
	|-AsyncOperationHandle<object>.get_DebugName
	|
	|-RVA: 0x55C872C Offset: 0x55C472C VA: 0x55C872C
	|-AsyncOperationHandle<SceneInstance>.get_DebugName
	|
	|-RVA: 0x55CA058 Offset: 0x55C6058 VA: 0x55CA058
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1
	public void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4838 Offset: 0x55C0838 VA: 0x55C4838
	|-AsyncOperationHandle<bool>.GetDependencies
	|
	|-RVA: 0x55C5DB8 Offset: 0x55C1DB8 VA: 0x55C5DB8
	|-AsyncOperationHandle<long>.GetDependencies
	|
	|-RVA: 0x55C7314 Offset: 0x55C3314 VA: 0x55C7314
	|-AsyncOperationHandle<object>.GetDependencies
	|
	|-RVA: 0x55C883C Offset: 0x55C483C VA: 0x55C883C
	|-AsyncOperationHandle<SceneInstance>.GetDependencies
	|
	|-RVA: 0x55CA1D8 Offset: 0x55C61D8 VA: 0x55CA1D8
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4894 Offset: 0x55C0894 VA: 0x55C4894
	|-AsyncOperationHandle<bool>.add_Destroyed
	|
	|-RVA: 0x55C5E14 Offset: 0x55C1E14 VA: 0x55C5E14
	|-AsyncOperationHandle<long>.add_Destroyed
	|
	|-RVA: 0x55C7370 Offset: 0x55C3370 VA: 0x55C7370
	|-AsyncOperationHandle<object>.add_Destroyed
	|
	|-RVA: 0x55C8898 Offset: 0x55C4898 VA: 0x55C8898
	|-AsyncOperationHandle<SceneInstance>.add_Destroyed
	|
	|-RVA: 0x55CA268 Offset: 0x55C6268 VA: 0x55CA268
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4908 Offset: 0x55C0908 VA: 0x55C4908
	|-AsyncOperationHandle<bool>.remove_Destroyed
	|
	|-RVA: 0x55C5E80 Offset: 0x55C1E80 VA: 0x55C5E80
	|-AsyncOperationHandle<long>.remove_Destroyed
	|
	|-RVA: 0x55C73DC Offset: 0x55C33DC VA: 0x55C73DC
	|-AsyncOperationHandle<object>.remove_Destroyed
	|
	|-RVA: 0x55C8904 Offset: 0x55C4904 VA: 0x55C8904
	|-AsyncOperationHandle<SceneInstance>.remove_Destroyed
	|
	|-RVA: 0x55CA354 Offset: 0x55C6354 VA: 0x55CA354
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(AsyncOperationHandle<TObject> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C497C Offset: 0x55C097C VA: 0x55C497C
	|-AsyncOperationHandle<bool>.Equals
	|
	|-RVA: 0x55C5EEC Offset: 0x55C1EEC VA: 0x55C5EEC
	|-AsyncOperationHandle<long>.Equals
	|
	|-RVA: 0x55C7448 Offset: 0x55C3448 VA: 0x55C7448
	|-AsyncOperationHandle<object>.Equals
	|
	|-RVA: 0x55C8970 Offset: 0x55C4970 VA: 0x55C8970
	|-AsyncOperationHandle<SceneInstance>.Equals
	|
	|-RVA: 0x55CA440 Offset: 0x55C6440 VA: 0x55CA440
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C49A8 Offset: 0x55C09A8 VA: 0x55C49A8
	|-AsyncOperationHandle<bool>.GetHashCode
	|
	|-RVA: 0x55C5F18 Offset: 0x55C1F18 VA: 0x55C5F18
	|-AsyncOperationHandle<long>.GetHashCode
	|
	|-RVA: 0x55C7474 Offset: 0x55C3474 VA: 0x55C7474
	|-AsyncOperationHandle<object>.GetHashCode
	|
	|-RVA: 0x55C899C Offset: 0x55C499C VA: 0x55C899C
	|-AsyncOperationHandle<SceneInstance>.GetHashCode
	|
	|-RVA: 0x55CA46C Offset: 0x55C646C VA: 0x55CA46C
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public TObject WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C49D8 Offset: 0x55C09D8 VA: 0x55C49D8
	|-AsyncOperationHandle<bool>.WaitForCompletion
	|
	|-RVA: 0x55C5F48 Offset: 0x55C1F48 VA: 0x55C5F48
	|-AsyncOperationHandle<long>.WaitForCompletion
	|
	|-RVA: 0x55C74A4 Offset: 0x55C34A4 VA: 0x55C74A4
	|-AsyncOperationHandle<object>.WaitForCompletion
	|
	|-RVA: 0x55C89CC Offset: 0x55C49CC VA: 0x55C89CC
	|-AsyncOperationHandle<SceneInstance>.WaitForCompletion
	|
	|-RVA: 0x55CA49C Offset: 0x55C649C VA: 0x55CA49C
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationBase<TObject> get_InternalOp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4B2C Offset: 0x55C0B2C VA: 0x55C4B2C
	|-AsyncOperationHandle<bool>.get_InternalOp
	|
	|-RVA: 0x55C6098 Offset: 0x55C2098 VA: 0x55C6098
	|-AsyncOperationHandle<long>.get_InternalOp
	|
	|-RVA: 0x55C75F4 Offset: 0x55C35F4 VA: 0x55C75F4
	|-AsyncOperationHandle<object>.get_InternalOp
	|
	|-RVA: 0x55C8B1C Offset: 0x55C4B1C VA: 0x55C8B1C
	|-AsyncOperationHandle<SceneInstance>.get_InternalOp
	|
	|-RVA: 0x55CA880 Offset: 0x55C6880 VA: 0x55CA880
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_InternalOp
	*/

	// RVA: -1 Offset: -1
	public bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4BB0 Offset: 0x55C0BB0 VA: 0x55C4BB0
	|-AsyncOperationHandle<bool>.get_IsDone
	|
	|-RVA: 0x55C611C Offset: 0x55C211C VA: 0x55C611C
	|-AsyncOperationHandle<long>.get_IsDone
	|
	|-RVA: 0x55C7678 Offset: 0x55C3678 VA: 0x55C7678
	|-AsyncOperationHandle<object>.get_IsDone
	|
	|-RVA: 0x55C8BA0 Offset: 0x55C4BA0 VA: 0x55C8BA0
	|-AsyncOperationHandle<SceneInstance>.get_IsDone
	|
	|-RVA: 0x55CA950 Offset: 0x55C6950 VA: 0x55CA950
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	public bool IsValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4C50 Offset: 0x55C0C50 VA: 0x55C4C50
	|-AsyncOperationHandle<bool>.IsValid
	|
	|-RVA: 0x55C61B8 Offset: 0x55C21B8 VA: 0x55C61B8
	|-AsyncOperationHandle<long>.IsValid
	|
	|-RVA: 0x55C7714 Offset: 0x55C3714 VA: 0x55C7714
	|-AsyncOperationHandle<object>.IsValid
	|
	|-RVA: 0x55C8C3C Offset: 0x55C4C3C VA: 0x55C8C3C
	|-AsyncOperationHandle<SceneInstance>.IsValid
	|
	|-RVA: 0x55CAAA4 Offset: 0x55C6AA4 VA: 0x55CAAA4
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.IsValid
	*/

	// RVA: -1 Offset: -1
	public Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4C98 Offset: 0x55C0C98 VA: 0x55C4C98
	|-AsyncOperationHandle<bool>.get_OperationException
	|
	|-RVA: 0x55C6200 Offset: 0x55C2200 VA: 0x55C6200
	|-AsyncOperationHandle<long>.get_OperationException
	|
	|-RVA: 0x55C775C Offset: 0x55C375C VA: 0x55C775C
	|-AsyncOperationHandle<object>.get_OperationException
	|
	|-RVA: 0x55C8C84 Offset: 0x55C4C84 VA: 0x55C8C84
	|-AsyncOperationHandle<SceneInstance>.get_OperationException
	|
	|-RVA: 0x55CAB34 Offset: 0x55C6B34 VA: 0x55CAB34
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	public float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4CFC Offset: 0x55C0CFC VA: 0x55C4CFC
	|-AsyncOperationHandle<bool>.get_PercentComplete
	|
	|-RVA: 0x55C6264 Offset: 0x55C2264 VA: 0x55C6264
	|-AsyncOperationHandle<long>.get_PercentComplete
	|
	|-RVA: 0x55C77C0 Offset: 0x55C37C0 VA: 0x55C77C0
	|-AsyncOperationHandle<object>.get_PercentComplete
	|
	|-RVA: 0x55C8CE8 Offset: 0x55C4CE8 VA: 0x55C8CE8
	|-AsyncOperationHandle<SceneInstance>.get_PercentComplete
	|
	|-RVA: 0x55CAC18 Offset: 0x55C6C18 VA: 0x55CAC18
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4D68 Offset: 0x55C0D68 VA: 0x55C4D68
	|-AsyncOperationHandle<bool>.get_ReferenceCount
	|
	|-RVA: 0x55C62C8 Offset: 0x55C22C8 VA: 0x55C62C8
	|-AsyncOperationHandle<long>.get_ReferenceCount
	|
	|-RVA: 0x55C7824 Offset: 0x55C3824 VA: 0x55C7824
	|-AsyncOperationHandle<object>.get_ReferenceCount
	|
	|-RVA: 0x55C8D4C Offset: 0x55C4D4C VA: 0x55C8D4C
	|-AsyncOperationHandle<SceneInstance>.get_ReferenceCount
	|
	|-RVA: 0x55CACFC Offset: 0x55C6CFC VA: 0x55CACFC
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1
	public void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4DCC Offset: 0x55C0DCC VA: 0x55C4DCC
	|-AsyncOperationHandle<bool>.Release
	|
	|-RVA: 0x55C632C Offset: 0x55C232C VA: 0x55C632C
	|-AsyncOperationHandle<long>.Release
	|
	|-RVA: 0x55C7888 Offset: 0x55C3888 VA: 0x55C7888
	|-AsyncOperationHandle<object>.Release
	|
	|-RVA: 0x55C8DB0 Offset: 0x55C4DB0 VA: 0x55C8DB0
	|-AsyncOperationHandle<SceneInstance>.Release
	|
	|-RVA: 0x55CADE0 Offset: 0x55C6DE0 VA: 0x55CADE0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4E48 Offset: 0x55C0E48 VA: 0x55C4E48
	|-AsyncOperationHandle<bool>.get_Result
	|
	|-RVA: 0x55C63A8 Offset: 0x55C23A8 VA: 0x55C63A8
	|-AsyncOperationHandle<long>.get_Result
	|
	|-RVA: 0x55C7904 Offset: 0x55C3904 VA: 0x55C7904
	|-AsyncOperationHandle<object>.get_Result
	|
	|-RVA: 0x55C8E2C Offset: 0x55C4E2C VA: 0x55C8E2C
	|-AsyncOperationHandle<SceneInstance>.get_Result
	|
	|-RVA: 0x55CAEC4 Offset: 0x55C6EC4 VA: 0x55CAEC4
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4EAC Offset: 0x55C0EAC VA: 0x55C4EAC
	|-AsyncOperationHandle<bool>.get_Status
	|
	|-RVA: 0x55C640C Offset: 0x55C240C VA: 0x55C640C
	|-AsyncOperationHandle<long>.get_Status
	|
	|-RVA: 0x55C7968 Offset: 0x55C3968 VA: 0x55C7968
	|-AsyncOperationHandle<object>.get_Status
	|
	|-RVA: 0x55C8E90 Offset: 0x55C4E90 VA: 0x55C8E90
	|-AsyncOperationHandle<SceneInstance>.get_Status
	|
	|-RVA: 0x55CB048 Offset: 0x55C7048 VA: 0x55CB048
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1
	public Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4F10 Offset: 0x55C0F10 VA: 0x55C4F10
	|-AsyncOperationHandle<bool>.get_Task
	|
	|-RVA: 0x55C6470 Offset: 0x55C2470 VA: 0x55C6470
	|-AsyncOperationHandle<long>.get_Task
	|
	|-RVA: 0x55C79CC Offset: 0x55C39CC VA: 0x55C79CC
	|-AsyncOperationHandle<object>.get_Task
	|
	|-RVA: 0x55C8EF4 Offset: 0x55C4EF4 VA: 0x55C8EF4
	|-AsyncOperationHandle<SceneInstance>.get_Task
	|
	|-RVA: 0x55CB12C Offset: 0x55C712C VA: 0x55CB12C
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4F7C Offset: 0x55C0F7C VA: 0x55C4F7C
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x55C64DC Offset: 0x55C24DC VA: 0x55C64DC
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x55C7A38 Offset: 0x55C3A38 VA: 0x55C7A38
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x55C8F60 Offset: 0x55C4F60 VA: 0x55C8F60
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x55CB210 Offset: 0x55C7210 VA: 0x55CB210
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C4FE8 Offset: 0x55C0FE8 VA: 0x55C4FE8
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x55C6544 Offset: 0x55C2544 VA: 0x55C6544
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x55C7A6C Offset: 0x55C3A6C VA: 0x55C7A6C
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x55C8FD0 Offset: 0x55C4FD0 VA: 0x55C8FD0
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.MoveNext
	|
	|-RVA: 0x55CB334 Offset: 0x55C7334 VA: 0x55CB334
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x55C5028 Offset: 0x55C1028 VA: 0x55C5028
	|-AsyncOperationHandle<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x55C6584 Offset: 0x55C2584 VA: 0x55C6584
	|-AsyncOperationHandle<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x55C7AAC Offset: 0x55C3AAC VA: 0x55C7AAC
	|-AsyncOperationHandle<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x55C9010 Offset: 0x55C5010 VA: 0x55C9010
	|-AsyncOperationHandle<SceneInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x55CB3B0 Offset: 0x55C73B0 VA: 0x55CB3B0
	|-AsyncOperationHandle<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AsyncOperationHandle.<>c // TypeDefIndex: 25079
{
	// Fields
	public static readonly AsyncOperationHandle.<>c <>9; // 0x0
	public static Action<AsyncOperationHandle> <>9__16_0; // 0x8

	// Methods

	// RVA: 0x862DDF0 Offset: 0x8629DF0 VA: 0x862DDF0
	private static void .cctor() { }

	// RVA: 0x862DE58 Offset: 0x8629E58 VA: 0x862DE58
	public void .ctor() { }

	// RVA: 0x862DE60 Offset: 0x8629E60 VA: 0x862DE60
	internal void <ReleaseHandleOnCompletion>b__16_0(AsyncOperationHandle op) { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct AsyncOperationHandle : IEnumerator // TypeDefIndex: 25080
{
	// Fields
	internal IAsyncOperation m_InternalOp; // 0x0
	private int m_Version; // 0x8
	private string m_LocationName; // 0x10

	// Properties
	internal int Version { get; }
	internal string LocationName { get; set; }
	public string DebugName { get; }
	private IAsyncOperation InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public object Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<object> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x862CA8C Offset: 0x8628A8C VA: 0x862CA8C
	internal int get_Version() { }

	// RVA: 0x862CA94 Offset: 0x8628A94 VA: 0x862CA94
	internal string get_LocationName() { }

	// RVA: 0x862CA9C Offset: 0x8628A9C VA: 0x862CA9C
	internal void set_LocationName(string value) { }

	// RVA: 0x862CAA4 Offset: 0x8628AA4 VA: 0x862CAA4
	internal void .ctor(IAsyncOperation op) { }

	// RVA: 0x862CB7C Offset: 0x8628B7C VA: 0x862CB7C
	internal void .ctor(IAsyncOperation op, int version) { }

	// RVA: 0x862CBB0 Offset: 0x8628BB0 VA: 0x862CBB0
	internal void .ctor(IAsyncOperation op, string locationName) { }

	// RVA: 0x862CC94 Offset: 0x8628C94 VA: 0x862CC94
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }

	// RVA: 0x862CCCC Offset: 0x8628CCC VA: 0x862CCCC
	internal AsyncOperationHandle Acquire() { }

	// RVA: 0x862CE8C Offset: 0x8628E8C VA: 0x862CE8C
	public void add_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x862CF40 Offset: 0x8628F40 VA: 0x862CF40
	public void remove_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x862CFF4 Offset: 0x8628FF4 VA: 0x862CFF4
	public void ReleaseHandleOnCompletion() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> Convert<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4503DA0 Offset: 0x44FFDA0 VA: 0x4503DA0
	|-AsyncOperationHandle.Convert<object>
	|
	|-RVA: 0x4503DFC Offset: 0x44FFDFC VA: 0x4503DFC
	|-AsyncOperationHandle.Convert<SceneInstance>
	|
	|-RVA: 0x4503E58 Offset: 0x44FFE58 VA: 0x4503E58
	|-AsyncOperationHandle.Convert<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x862D0D4 Offset: 0x86290D4 VA: 0x862D0D4
	public bool Equals(AsyncOperationHandle other) { }

	// RVA: 0x862D100 Offset: 0x8629100 VA: 0x862D100
	public string get_DebugName() { }

	// RVA: 0x862D294 Offset: 0x8629294 VA: 0x862D294
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x862D348 Offset: 0x8629348 VA: 0x862D348
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x862D3FC Offset: 0x86293FC VA: 0x862D3FC
	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x862D4B0 Offset: 0x86294B0 VA: 0x862D4B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x862CD90 Offset: 0x8628D90 VA: 0x862CD90
	private IAsyncOperation get_InternalOp() { }

	// RVA: 0x862D4E0 Offset: 0x86294E0 VA: 0x862D4E0
	public bool get_IsDone() { }

	// RVA: 0x862D1DC Offset: 0x86291DC VA: 0x862D1DC
	public bool IsValid() { }

	// RVA: 0x862D5A8 Offset: 0x86295A8 VA: 0x862D5A8
	public Exception get_OperationException() { }

	// RVA: 0x862D654 Offset: 0x8629654 VA: 0x862D654
	public float get_PercentComplete() { }

	// RVA: 0x862D700 Offset: 0x8629700 VA: 0x862D700
	public DownloadStatus GetDownloadStatus() { }

	// RVA: 0x862D79C Offset: 0x862979C VA: 0x862D79C
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x862D91C Offset: 0x862991C VA: 0x862D91C
	internal int get_ReferenceCount() { }

	// RVA: 0x862D9C8 Offset: 0x86299C8 VA: 0x862D9C8
	public void Release() { }

	// RVA: 0x862DA84 Offset: 0x8629A84 VA: 0x862DA84
	public object get_Result() { }

	// RVA: 0x862DB2C Offset: 0x8629B2C VA: 0x862DB2C
	public AsyncOperationStatus get_Status() { }

	// RVA: 0x862DBD8 Offset: 0x8629BD8 VA: 0x862DBD8
	public Task<object> get_Task() { }

	// RVA: 0x862DC84 Offset: 0x8629C84 VA: 0x862DC84 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x862DC88 Offset: 0x8629C88 VA: 0x862DC88 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x862DCA0 Offset: 0x8629CA0 VA: 0x862DCA0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x862DCA4 Offset: 0x8629CA4 VA: 0x862DCA4
	public object WaitForCompletion() { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public enum AsyncOperationStatus // TypeDefIndex: 25081
{
	// Fields
	public int value__; // 0x0
	public const AsyncOperationStatus None = 0;
	public const AsyncOperationStatus Succeeded = 1;
	public const AsyncOperationStatus Failed = 2;
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct DownloadStatus // TypeDefIndex: 25082
{
	// Fields
	public long TotalBytes; // 0x0
	public long DownloadedBytes; // 0x8
	public bool IsDone; // 0x10

	// Properties
	public float Percent { get; }

	// Methods

	// RVA: 0x862DE68 Offset: 0x8629E68 VA: 0x862DE68
	public float get_Percent() { }
}

// Namespace: 
[Flags]
public enum GroupOperation.GroupOperationSettings // TypeDefIndex: 25083
{
	// Fields
	public int value__; // 0x0
	public const GroupOperation.GroupOperationSettings None = 0;
	public const GroupOperation.GroupOperationSettings ReleaseDependenciesOnFailure = 1;
	public const GroupOperation.GroupOperationSettings AllowFailedDependencies = 2;
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class GroupOperation : AsyncOperationBase<IList<AsyncOperationHandle>>, ICachable // TypeDefIndex: 25084
{
	// Fields
	private Action<AsyncOperationHandle> m_InternalOnComplete; // 0x98
	private int m_LoadedCount; // 0xA0
	private GroupOperation.GroupOperationSettings m_Settings; // 0xA4
	private string debugName; // 0xA8
	private const int k_MaxDisplayedLocationLength = 45;
	[CompilerGenerated]
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; // 0xB0
	private HashSet<string> m_CachedDependencyLocations; // 0xB8

	// Properties
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key { get; set; }
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: 0x862DEA0 Offset: 0x8629EA0 VA: 0x862DEA0
	public void .ctor() { }

	// RVA: 0x862DFF8 Offset: 0x8629FF8 VA: 0x862DFF8 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	[CompilerGenerated]
	// RVA: 0x862E3D4 Offset: 0x862A3D4 VA: 0x862E3D4 Slot: 36
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }

	[CompilerGenerated]
	// RVA: 0x862E3DC Offset: 0x862A3DC VA: 0x862E3DC Slot: 37
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }

	// RVA: 0x862E3E4 Offset: 0x862A3E4 VA: 0x862E3E4
	internal IList<AsyncOperationHandle> GetDependentOps() { }

	// RVA: 0x862E420 Offset: 0x862A420 VA: 0x862E420 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x862E484 Offset: 0x862A484 VA: 0x862E484 Slot: 34
	internal override void ReleaseDependencies() { }

	// RVA: 0x862E6D8 Offset: 0x862A6D8 VA: 0x862E6D8 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x862E934 Offset: 0x862A934 VA: 0x862E934
	private bool DependenciesAreUnchanged(List<AsyncOperationHandle> deps) { }

	// RVA: 0x862EB08 Offset: 0x862AB08 VA: 0x862EB08 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x862EDE4 Offset: 0x862ADE4 VA: 0x862EDE4 Slot: 28
	protected override void Execute() { }

	// RVA: 0x862EFF4 Offset: 0x862AFF4 VA: 0x862EFF4
	private void CompleteIfDependenciesComplete() { }

	// RVA: 0x862F2EC Offset: 0x862B2EC VA: 0x862F2EC Slot: 29
	protected override void Destroy() { }

	// RVA: 0x862F2FC Offset: 0x862B2FC VA: 0x862F2FC Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x862F4E8 Offset: 0x862B4E8 VA: 0x862F4E8
	public void Init(List<AsyncOperationHandle> operations, bool releaseDependenciesOnFailure = True, bool allowFailedDependencies = False) { }

	// RVA: 0x862F5A4 Offset: 0x862B5A4 VA: 0x862F5A4
	public void Init(List<AsyncOperationHandle> operations, GroupOperation.GroupOperationSettings settings) { }

	// RVA: 0x862F648 Offset: 0x862B648 VA: 0x862F648
	private void OnOperationCompleted(AsyncOperationHandle op) { }
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal interface IGenericProviderOperation // TypeDefIndex: 25085
{
	// Properties
	public abstract int ProvideHandleVersion { get; }
	public abstract IResourceLocation Location { get; }
	public abstract int DependencyCount { get; }
	public abstract Type RequestedType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_ProvideHandleVersion();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IResourceLocation get_Location();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_DependencyCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetDependencies(IList<object> dstList);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TDepObject GetDependency<TDepObject>(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericProviderOperation.GetDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetProgressCallback(Func<float> callback);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ProviderCompleted<T>(T result, bool status, Exception e);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGenericProviderOperation.ProviderCompleted<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_RequestedType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void SetDownloadProgressCallback(Func<DownloadStatus> callback);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SetWaitForCompletionCallback(Func<bool> callback);
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
[Preserve]
internal class ProviderOperation<TObject> : AsyncOperationBase<TObject>, IGenericProviderOperation, ICachable // TypeDefIndex: 25086
{
	// Fields
	private bool m_ReleaseDependenciesOnFailure; // 0x0
	private Func<float> m_GetProgressCallback; // 0x0
	private Func<DownloadStatus> m_GetDownloadProgressCallback; // 0x0
	private Func<bool> m_WaitForCompletionCallback; // 0x0
	private bool m_ProviderCompletedCalled; // 0x0
	private DownloadStatus m_DownloadStatus; // 0x0
	private IResourceProvider m_Provider; // 0x0
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x0
	private IResourceLocation m_Location; // 0x0
	private int m_ProvideHandleVersion; // 0x0
	private bool m_NeedsRelease; // 0x0
	[CompilerGenerated]
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; // 0x0
	private ResourceManager m_ResourceManager; // 0x0
	private const float k_OperationWaitingToCompletePercentComplete = 0.99;
	internal const string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used";

	// Properties
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key { get; set; }
	public int ProvideHandleVersion { get; }
	public IResourceLocation Location { get; }
	protected override string DebugName { get; }
	public Type RequestedType { get; }
	public int DependencyCount { get; }
	protected override float Progress { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 48
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E500 Offset: 0x529A500 VA: 0x529E500
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key
	|
	|-RVA: 0x529FC20 Offset: 0x529BC20 VA: 0x529FC20
	|-ProviderOperation<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 49
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E508 Offset: 0x529A508 VA: 0x529E508
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key
	|
	|-RVA: 0x529FC48 Offset: 0x529BC48 VA: 0x529FC48
	|-ProviderOperation<__Il2CppFullySharedGenericType>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public int get_ProvideHandleVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E518 Offset: 0x529A518 VA: 0x529E518
	|-ProviderOperation<object>.get_ProvideHandleVersion
	|
	|-RVA: 0x529FC68 Offset: 0x529BC68 VA: 0x529FC68
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_ProvideHandleVersion
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public IResourceLocation get_Location() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E520 Offset: 0x529A520 VA: 0x529E520
	|-ProviderOperation<object>.get_Location
	|
	|-RVA: 0x529FC90 Offset: 0x529BC90 VA: 0x529FC90
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_Location
	*/

	// RVA: -1 Offset: -1 Slot: 46
	public void SetDownloadProgressCallback(Func<DownloadStatus> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E528 Offset: 0x529A528 VA: 0x529E528
	|-ProviderOperation<object>.SetDownloadProgressCallback
	|
	|-RVA: 0x529FCB8 Offset: 0x529BCB8 VA: 0x529FCB8
	|-ProviderOperation<__Il2CppFullySharedGenericType>.SetDownloadProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 47
	public void SetWaitForCompletionCallback(Func<bool> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E58C Offset: 0x529A58C VA: 0x529E58C
	|-ProviderOperation<object>.SetWaitForCompletionCallback
	|
	|-RVA: 0x529FD90 Offset: 0x529BD90 VA: 0x529FD90
	|-ProviderOperation<__Il2CppFullySharedGenericType>.SetWaitForCompletionCallback
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E594 Offset: 0x529A594 VA: 0x529E594
	|-ProviderOperation<object>.InvokeWaitForCompletion
	|
	|-RVA: 0x529FDB0 Offset: 0x529BDB0 VA: 0x529FDB0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E6BC Offset: 0x529A6BC VA: 0x529E6BC
	|-ProviderOperation<object>.GetDownloadStatus
	|
	|-RVA: 0x529FFB8 Offset: 0x529BFB8 VA: 0x529FFB8
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E7F0 Offset: 0x529A7F0 VA: 0x529E7F0
	|-ProviderOperation<object>..ctor
	|
	|-RVA: 0x52A0204 Offset: 0x529C204 VA: 0x52A0204
	|-ProviderOperation<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E808 Offset: 0x529A808 VA: 0x529E808
	|-ProviderOperation<object>.GetDependencies
	|
	|-RVA: 0x52A024C Offset: 0x529C24C VA: 0x52A024C
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E960 Offset: 0x529A960 VA: 0x529E960
	|-ProviderOperation<object>.ReleaseDependencies
	|
	|-RVA: 0x52A03E4 Offset: 0x529C3E4 VA: 0x52A03E4
	|-ProviderOperation<__Il2CppFullySharedGenericType>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529E9DC Offset: 0x529A9DC VA: 0x529E9DC
	|-ProviderOperation<object>.get_DebugName
	|
	|-RVA: 0x52A049C Offset: 0x529C49C VA: 0x52A049C
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public void GetDependencies(IList<object> dstList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529EB48 Offset: 0x529AB48 VA: 0x529EB48
	|-ProviderOperation<object>.GetDependencies
	|
	|-RVA: 0x52A0650 Offset: 0x529C650 VA: 0x52A0650
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 45
	public Type get_RequestedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529EE10 Offset: 0x529AE10 VA: 0x529EE10
	|-ProviderOperation<object>.get_RequestedType
	|
	|-RVA: 0x52A0990 Offset: 0x529C990 VA: 0x52A0990
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_RequestedType
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public int get_DependencyCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529EE74 Offset: 0x529AE74 VA: 0x529EE74
	|-ProviderOperation<object>.get_DependencyCount
	|
	|-RVA: 0x52A09F4 Offset: 0x529C9F4 VA: 0x52A09F4
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_DependencyCount
	*/

	// RVA: -1 Offset: -1 Slot: 42
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4345F10 Offset: 0x4341F10 VA: 0x4345F10
	|-ProviderOperation<object>.GetDependency<object>
	|
	|-RVA: 0x43464B4 Offset: 0x43424B4 VA: 0x43464B4
	|-ProviderOperation<__Il2CppFullySharedGenericType>.GetDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 43
	public void SetProgressCallback(Func<float> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529EF7C Offset: 0x529AF7C VA: 0x529EF7C
	|-ProviderOperation<object>.SetProgressCallback
	|
	|-RVA: 0x52A0B50 Offset: 0x529CB50 VA: 0x52A0B50
	|-ProviderOperation<__Il2CppFullySharedGenericType>.SetProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 44
	public void ProviderCompleted<T>(T result, bool status, Exception e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43460D4 Offset: 0x43420D4 VA: 0x43460D4
	|-ProviderOperation<object>.ProviderCompleted<object>
	|
	|-RVA: 0x434670C Offset: 0x434270C VA: 0x434670C
	|-ProviderOperation<__Il2CppFullySharedGenericType>.ProviderCompleted<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529EF84 Offset: 0x529AF84 VA: 0x529EF84
	|-ProviderOperation<object>.get_Progress
	|
	|-RVA: 0x52A0B70 Offset: 0x529CB70 VA: 0x52A0B70
	|-ProviderOperation<__Il2CppFullySharedGenericType>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529F484 Offset: 0x529B484 VA: 0x529F484
	|-ProviderOperation<object>.Execute
	|
	|-RVA: 0x52A111C Offset: 0x529D11C VA: 0x52A111C
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529F770 Offset: 0x529B770 VA: 0x529F770
	|-ProviderOperation<object>.Init
	|
	|-RVA: 0x52A1594 Offset: 0x529D594 VA: 0x52A1594
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529F8C4 Offset: 0x529B8C4 VA: 0x529F8C4
	|-ProviderOperation<object>.Init
	|
	|-RVA: 0x52A17C0 Offset: 0x529D7C0 VA: 0x52A17C0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1
	private bool WaitForCompletionHandler() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529FA1C Offset: 0x529BA1C VA: 0x529FA1C
	|-ProviderOperation<object>.WaitForCompletionHandler
	|
	|-RVA: 0x52A19F0 Offset: 0x529D9F0 VA: 0x52A19F0
	|-ProviderOperation<__Il2CppFullySharedGenericType>.WaitForCompletionHandler
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x529FAF0 Offset: 0x529BAF0 VA: 0x529FAF0
	|-ProviderOperation<object>.Destroy
	|
	|-RVA: 0x52A1B18 Offset: 0x529DB18 VA: 0x52A1B18
	|-ProviderOperation<__Il2CppFullySharedGenericType>.Destroy
	*/
}

// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class UnityWebRequestOperation : AsyncOperationBase<UnityWebRequest> // TypeDefIndex: 25087
{
	// Fields
	private UnityWebRequest m_UWR; // 0x98

	// Methods

	// RVA: 0x862F658 Offset: 0x862B658 VA: 0x862F658
	public void .ctor(UnityWebRequest webRequest) { }

	// RVA: 0x862F6BC Offset: 0x862B6BC VA: 0x862F6BC Slot: 28
	protected override void Execute() { }

	[CompilerGenerated]
	// RVA: 0x862F758 Offset: 0x862B758 VA: 0x862F758
	private void <Execute>b__2_0(AsyncOperation request) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 25088
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5341 // TypeDefIndex: 25089
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7525 // TypeDefIndex: 25090
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 25091
{
	// Fields
	internal static readonly long 2D2025322643CE1497D8FB03FA789F27E833CF43545CA1003AFEFEA250D39313 = 3172232900852580628; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7525 987B8C8BFA51522BED86A79FD27B693F154DF2F1529EC3406B7711693441BCAB /*Metadata offset 0xF3CDB0*/; // 0x8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5341 A710774284EFCBD1BC52AA805EE1AB02B9D741B2C877835988ECB6A83AC1D4C4 /*Metadata offset 0xF3EB18*/; // 0x1D6D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 EA60AE08A5700DD4BD20B4E747628D0EB97778BF93E89F290F83674C07FC2BF2 /*Metadata offset 0xF3FFF8*/; // 0x324A
}

