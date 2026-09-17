// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28610
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 28611
{
	// Methods

	// RVA: 0x858C46C Offset: 0x858846C VA: 0x858C46C
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(27524, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 28612
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x858C474 Offset: 0x8588474 VA: 0x858C474
	public void .ctor(byte ) { }

	// RVA: 0x858C4FC Offset: 0x85884FC VA: 0x858C4FC
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(5196, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 28613
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x858C52C Offset: 0x858852C VA: 0x858C52C
	public void .ctor(byte ) { }
}

// Namespace: Uniject
internal interface IThreadUtils // TypeDefIndex: 28614
{
	// Properties
	public abstract bool IsRunningOnMainThread { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsRunningOnMainThread();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task PostAsync(Action action);
}

// Namespace: Uniject
internal interface IUtil // TypeDefIndex: 28615
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RunOnMainThread(Action runnable);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddPauseListener(Action<bool> runnable);
}

// Namespace: Uniject
[Preserve]
internal class UnityThreadUtils : IThreadUtils // TypeDefIndex: 28616
{
	// Fields
	private static int s_UnityThreadId; // 0x0
	private static TaskScheduler UnityThreadScheduler; // 0x8

	// Properties
	public bool IsRunningOnMainThread { get; }

	// Methods

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x858C554 Offset: 0x8588554 VA: 0x858C554
	private static void CaptureUnityThreadInfo() { }

	// RVA: 0x858C5F4 Offset: 0x85885F4 VA: 0x858C5F4 Slot: 4
	public bool get_IsRunningOnMainThread() { }

	// RVA: 0x858C654 Offset: 0x8588654 VA: 0x858C654 Slot: 5
	public Task PostAsync(Action action) { }

	// RVA: 0x858C74C Offset: 0x858874C VA: 0x858C74C
	public void .ctor() { }
}

// Namespace: Purchasing.Utilities
internal interface IMonoBehaviourUtil // TypeDefIndex: 28617
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Coroutine StartCoroutine(IEnumerator start);
}

// Namespace: 
[CompilerGenerated]
private sealed class MonoBehaviourUtil.<DelayedCoroutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 28618
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int delay; // 0x20
	public MonoBehaviourUtil <>4__this; // 0x28
	public IEnumerator coroutine; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x858C8C4 Offset: 0x85888C4 VA: 0x858C8C4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x858C8FC Offset: 0x85888FC VA: 0x858C8FC Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x858C900 Offset: 0x8588900 VA: 0x858C900 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x858C9BC Offset: 0x85889BC VA: 0x858C9BC Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x858C9C4 Offset: 0x85889C4 VA: 0x858C9C4 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x858C9FC Offset: 0x85889FC VA: 0x858C9FC Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Purchasing.Utilities
[HideInInspector]
[AddComponentMenu("")]
internal class MonoBehaviourUtil : MonoBehaviour, IMonoBehaviourUtil // TypeDefIndex: 28619
{
	// Methods

	// RVA: 0x858C754 Offset: 0x8588754 VA: 0x858C754 Slot: 5
	public GameObject[] GetGameObjects() { }

	[IteratorStateMachine(typeof(MonoBehaviourUtil.<DelayedCoroutine>d__1))]
	// RVA: 0x858C834 Offset: 0x8588834 VA: 0x858C834 Slot: 6
	public IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay) { }

	// RVA: 0x858C8EC Offset: 0x85888EC VA: 0x858C8EC Slot: 4
	private Coroutine Purchasing.Utilities.IMonoBehaviourUtil.StartCoroutine(IEnumerator start) { }

	// RVA: 0x858C8F4 Offset: 0x85888F4 VA: 0x858C8F4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumerableExtensions.<>c__0<T> // TypeDefIndex: 28620
{
	// Fields
	[Nullable(0)]
	public static readonly EnumerableExtensions.<>c__0<T> <>9; // 0x0
	[Nullable(0)]
	public static Func<T, bool> <>9__0_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4856474 Offset: 0x4852474 VA: 0x4856474
	|-EnumerableExtensions.<>c__0<object>..cctor
	|
	|-RVA: 0x4856620 Offset: 0x4852620 VA: 0x4856620
	|-EnumerableExtensions.<>c__0<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4856530 Offset: 0x4852530 VA: 0x4856530
	|-EnumerableExtensions.<>c__0<object>..ctor
	|
	|-RVA: 0x4856714 Offset: 0x4852714 VA: 0x4856714
	|-EnumerableExtensions.<>c__0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal bool <NonNull>b__0_0(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4856538 Offset: 0x4852538 VA: 0x4856538
	|-EnumerableExtensions.<>c__0<object>.<NonNull>b__0_0
	|
	|-RVA: 0x485671C Offset: 0x485271C VA: 0x485671C
	|-EnumerableExtensions.<>c__0<__Il2CppFullySharedGenericType>.<NonNull>b__0_0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EnumerableExtensions.<IgnoreExceptions>d__1<T, TException> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 28621
{
	// Fields
	private int <>1__state; // 0x0
	[Nullable(0)]
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	[Nullable(0)]
	private IEnumerable<T> enumerable; // 0x0
	[Nullable(0)]
	public IEnumerable<T> <>3__enumerable; // 0x0
	[Nullable(new[] { 0, 1 })]
	private Action<TException> onException; // 0x0
	[Nullable(new[] { 0, 1 })]
	public Action<TException> <>3__onException; // 0x0
	[Nullable(0)]
	private IEnumerator<T> <enumerator>5__2; // 0x0
	private bool <hasNext>5__3; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D32360 Offset: 0x5D2E360 VA: 0x5D32360
	|-EnumerableExtensions.<IgnoreExceptions>d__1<object, object>..ctor
	|
	|-RVA: 0x5D32978 Offset: 0x5D2E978 VA: 0x5D32978
	|-EnumerableExtensions.<IgnoreExceptions>d__1<__Il2CppFullySharedGenericType, object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D32394 Offset: 0x5D2E394 VA: 0x5D32394
	|-EnumerableExtensions.<IgnoreExceptions>d__1<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5D329E0 Offset: 0x5D2E9E0 VA: 0x5D329E0
	|-EnumerableExtensions.<IgnoreExceptions>d__1<__Il2CppFullySharedGenericType, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D323B0 Offset: 0x5D2E3B0 VA: 0x5D323B0
	|-EnumerableExtensions.<IgnoreExceptions>d__1<object, object>.MoveNext
	|
	|-RVA: 0x5D32A40 Offset: 0x5D2EA40 VA: 0x5D32A40
	|-EnumerableExtensions.<IgnoreExceptions>d__1<__Il2CppFullySharedGenericType, object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D327D0 Offset: 0x5D2E7D0 VA: 0x5D327D0
	|-EnumerableExtensions.<IgnoreExceptions>d__1<object, object>.<>m__Finally1
	|
	|-RVA: 0x5D3305C Offset: 0x5D2F05C VA: 0x5D3305C
	|-EnumerableExtensions.<IgnoreExceptions>d__1<__Il2CppFullySharedGenericType, object>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D32880 Offset: 0x5D2E880 VA: 0x5D32880
	|-EnumerableExtensions.<IgnoreExceptions>d__1<object, object>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x5D33168 Offset: 0x5D2F168 VA: 0x5D33168
	|-EnumerableExtensions.<IgnoreExceptions>d__1<__Il2CppFullySharedGenericType, object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D32888 Offset: 0x5D2E888 VA: 0x5D32888
	|-EnumerableExtensions.<IgnoreExceptions>d__1<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5D33208 Offset: 0x5D2F208 VA: 0x5D33208
	|-EnumerableExtensions.<IgnoreExceptions>d__1<__Il2CppFullySharedGenericType, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D328BC Offset: 0x5D2E8BC VA: 0x5D328BC
	|-EnumerableExtensions.<IgnoreExceptions>d__1<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5D3323C Offset: 0x5D2F23C VA: 0x5D3323C
	|-EnumerableExtensions.<IgnoreExceptions>d__1<__Il2CppFullySharedGenericType, object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D328C4 Offset: 0x5D2E8C4 VA: 0x5D328C4
	|-EnumerableExtensions.<IgnoreExceptions>d__1<object, object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x5D332E0 Offset: 0x5D2F2E0 VA: 0x5D332E0
	|-EnumerableExtensions.<IgnoreExceptions>d__1<__Il2CppFullySharedGenericType, object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D32968 Offset: 0x5D2E968 VA: 0x5D32968
	|-EnumerableExtensions.<IgnoreExceptions>d__1<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5D3342C Offset: 0x5D2F42C VA: 0x5D3342C
	|-EnumerableExtensions.<IgnoreExceptions>d__1<__Il2CppFullySharedGenericType, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: UnityEngine.Purchasing
[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class EnumerableExtensions // TypeDefIndex: 28622
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> NonNull<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45DE8B4 Offset: 0x45DA8B4 VA: 0x45DE8B4
	|-EnumerableExtensions.NonNull<object>
	|
	|-RVA: 0x45DE9EC Offset: 0x45DA9EC VA: 0x45DE9EC
	|-EnumerableExtensions.NonNull<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(EnumerableExtensions.<IgnoreExceptions>d__1<T, TException>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> IgnoreExceptions<T, TException>(IEnumerable<T> enumerable, Action<TException> onException) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45DE780 Offset: 0x45DA780 VA: 0x45DE780
	|-EnumerableExtensions.IgnoreExceptions<object, object>
	|
	|-RVA: 0x45DE808 Offset: 0x45DA808 VA: 0x45DE808
	|-EnumerableExtensions.IgnoreExceptions<__Il2CppFullySharedGenericType, object>
	*/
}

// Namespace: UnityEngine.Purchasing
[Extension]
internal static class LoggerExtensions // TypeDefIndex: 28623
{
	// Methods

	[Extension]
	// RVA: 0x858CA04 Offset: 0x8588A04 VA: 0x858CA04
	public static void LogIAP(ILogger logger, string message) { }

	[Extension]
	// RVA: 0x858CAC8 Offset: 0x8588AC8 VA: 0x858CAC8
	public static void LogIAPError(ILogger logger, string message) { }

	[Extension]
	// RVA: 0x858CB8C Offset: 0x8588B8C VA: 0x858CB8C
	public static void LogIAPException(ILogger logger, Exception exception) { }

	[Extension]
	// RVA: 0x858CCF0 Offset: 0x8588CF0 VA: 0x858CCF0
	public static void LogIAPWarning(ILogger logger, string message) { }
}

// Namespace: UnityEngine.Purchasing
public class MiniJson // TypeDefIndex: 28624
{
	// Methods

	// RVA: 0x858CDB4 Offset: 0x8588DB4 VA: 0x858CDB4
	public static string JsonEncode(object json) { }

	// RVA: 0x858CDBC Offset: 0x8588DBC VA: 0x858CDBC
	public static object JsonDecode(string json) { }
}

// Namespace: 
[CompilerGenerated]
private struct TaskQueue.<Enqueue>d__2<T> : IAsyncStateMachine // TypeDefIndex: 28625
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	[Nullable(0)]
	public TaskQueue <>4__this; // 0x0
	[Nullable(new[] { 0, 1, 0 })]
	public Func<Task<T>> taskGenerator; // 0x0
	private TaskAwaiter <>u__1; // 0x0
	[Nullable(0)]
	private TaskAwaiter<T> <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD8864 Offset: 0x5BD4864 VA: 0x5BD8864
	|-TaskQueue.<Enqueue>d__2<object>.MoveNext
	|
	|-RVA: 0x5BD8D78 Offset: 0x5BD4D78 VA: 0x5BD8D78
	|-TaskQueue.<Enqueue>d__2<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD8D00 Offset: 0x5BD4D00 VA: 0x5BD8D00
	|-TaskQueue.<Enqueue>d__2<object>.SetStateMachine
	|
	|-RVA: 0x5BD94B0 Offset: 0x5BD54B0 VA: 0x5BD94B0
	|-TaskQueue.<Enqueue>d__2<__Il2CppFullySharedGenericType>.SetStateMachine
	*/
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class TaskQueue // TypeDefIndex: 28626
{
	// Fields
	private readonly SemaphoreSlim semaphore; // 0x10

	// Methods

	// RVA: 0x858CE14 Offset: 0x8588E14 VA: 0x858CE14
	public void .ctor() { }

	[AsyncStateMachine(typeof(TaskQueue.<Enqueue>d__2<T>))]
	// RVA: -1 Offset: -1
	public Task<T> Enqueue<T>(Func<Task<T>> taskGenerator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x471A8D0 Offset: 0x47168D0 VA: 0x471A8D0
	|-TaskQueue.Enqueue<object>
	|
	|-RVA: 0x471A9BC Offset: 0x47169BC VA: 0x471A9BC
	|-TaskQueue.Enqueue<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.Purchasing
[NullableContext(1)]
internal interface ITransactionLog // TypeDefIndex: 28627
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasRecordOf(string transactionID);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Record(string transactionID);
}

// Namespace: UnityEngine.Purchasing
[Nullable(0)]
[NullableContext(1)]
internal class TransactionLog : ITransactionLog // TypeDefIndex: 28628
{
	// Fields
	[Nullable(2)]
	private readonly string m_PersistentDataPath; // 0x10

	// Methods

	// RVA: 0x858CE84 Offset: 0x8588E84 VA: 0x858CE84
	public void .ctor(string persistentDataPath) { }

	// RVA: 0x858CF5C Offset: 0x8588F5C VA: 0x858CF5C Slot: 4
	public bool HasRecordOf(string transactionID) { }

	// RVA: 0x858D030 Offset: 0x8589030 VA: 0x858D030 Slot: 5
	public void Record(string transactionID) { }

	// RVA: 0x858CFB8 Offset: 0x8588FB8 VA: 0x858CFB8
	private static string GetRecordPath(string dataPath, string transactionID) { }

	// RVA: 0x858D1C4 Offset: 0x85891C4 VA: 0x858D1C4
	private static string ComputeHash(string transactionID) { }
}

// Namespace: UnityEngine.Purchasing.Extension
internal class UnityUtil : IUtil // TypeDefIndex: 28629
{
	// Fields
	private IThreadUtils m_ThreadUtils; // 0x10
	private IMonoBehaviourUtil m_MonoBehaviourUtils; // 0x18
	private static readonly List<RuntimePlatform> s_PcControlledPlatforms; // 0x0
	private readonly List<Action<bool>> pauseListeners; // 0x20

	// Methods

	[Preserve]
	// RVA: 0x858D348 Offset: 0x8589348 VA: 0x858D348
	public void .ctor(IThreadUtils threadUtils, IMonoBehaviourUtil monoBehaviorUtil) { }

	// RVA: 0x858D400 Offset: 0x8589400 VA: 0x858D400 Slot: 4
	public void RunOnMainThread(Action runnable) { }

	// RVA: 0x858D538 Offset: 0x8589538 VA: 0x858D538 Slot: 5
	public void AddPauseListener(Action<bool> runnable) { }

	// RVA: 0x858D5E4 Offset: 0x85895E4 VA: 0x858D5E4
	private static void .cctor() { }
}

// Namespace: 
private enum Json.Parser.TOKEN // TypeDefIndex: 28630
{
	// Fields
	public int value__; // 0x0
	public const Json.Parser.TOKEN NONE = 0;
	public const Json.Parser.TOKEN CURLY_OPEN = 1;
	public const Json.Parser.TOKEN CURLY_CLOSE = 2;
	public const Json.Parser.TOKEN SQUARED_OPEN = 3;
	public const Json.Parser.TOKEN SQUARED_CLOSE = 4;
	public const Json.Parser.TOKEN COLON = 5;
	public const Json.Parser.TOKEN COMMA = 6;
	public const Json.Parser.TOKEN STRING = 7;
	public const Json.Parser.TOKEN NUMBER = 8;
	public const Json.Parser.TOKEN TRUE = 9;
	public const Json.Parser.TOKEN FALSE = 10;
	public const Json.Parser.TOKEN NULL = 11;
}

// Namespace: 
private sealed class Json.Parser : IDisposable // TypeDefIndex: 28631
{
	// Fields
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Json.Parser.TOKEN NextToken { get; }

	// Methods

	// RVA: 0x858DA90 Offset: 0x8589A90 VA: 0x858DA90
	public static bool IsWordBreak(char c) { }

	// RVA: 0x858DB2C Offset: 0x8589B2C VA: 0x858DB2C
	private void .ctor(string jsonString) { }

	// RVA: 0x858D874 Offset: 0x8589874 VA: 0x858D874
	public static object Parse(string jsonString) { }

	// RVA: 0x858DBC4 Offset: 0x8589BC4 VA: 0x858DBC4 Slot: 4
	public void Dispose() { }

	// RVA: 0x858DBF4 Offset: 0x8589BF4 VA: 0x858DBF4
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x858E15C Offset: 0x858A15C VA: 0x858E15C
	private List<object> ParseArray() { }

	// RVA: 0x858DBA8 Offset: 0x8589BA8 VA: 0x858DBA8
	private object ParseValue() { }

	// RVA: 0x858E288 Offset: 0x858A288 VA: 0x858E288
	private object ParseByToken(Json.Parser.TOKEN token) { }

	// RVA: 0x858DEDC Offset: 0x8589EDC VA: 0x858DEDC
	private string ParseString() { }

	// RVA: 0x858E378 Offset: 0x858A378 VA: 0x858E378
	private object ParseNumber() { }

	// RVA: 0x858E5F8 Offset: 0x858A5F8 VA: 0x858E5F8
	private void EatWhitespace() { }

	// RVA: 0x858E69C Offset: 0x858A69C VA: 0x858E69C
	private char get_PeekChar() { }

	// RVA: 0x858E4CC Offset: 0x858A4CC VA: 0x858E4CC
	private char get_NextChar() { }

	// RVA: 0x858E544 Offset: 0x858A544 VA: 0x858E544
	private string get_NextWord() { }

	// RVA: 0x858DD18 Offset: 0x8589D18 VA: 0x858DD18
	private Json.Parser.TOKEN get_NextToken() { }
}

// Namespace: 
private sealed class Json.Serializer // TypeDefIndex: 28632
{
	// Fields
	private readonly StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x858E714 Offset: 0x858A714 VA: 0x858E714
	private void .ctor() { }

	// RVA: 0x858DA1C Offset: 0x8589A1C VA: 0x858DA1C
	public static string Serialize(object obj) { }

	// RVA: 0x858E780 Offset: 0x858A780 VA: 0x858E780
	private void SerializeValue(object value) { }

	// RVA: 0x858EF6C Offset: 0x858AF6C VA: 0x858EF6C
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x858EC0C Offset: 0x858AC0C VA: 0x858EC0C
	private void SerializeArray(IList anArray) { }

	// RVA: 0x858E950 Offset: 0x858A950 VA: 0x858E950
	private void SerializeString(string str) { }

	// RVA: 0x858F3F8 Offset: 0x858B3F8 VA: 0x858F3F8
	private void SerializeOther(object value) { }
}

// Namespace: UnityEngine.Purchasing.MiniJSON
public static class Json // TypeDefIndex: 28633
{
	// Methods

	// RVA: 0x858CDE8 Offset: 0x8588DE8 VA: 0x858CDE8
	public static object Deserialize(string json) { }

	// RVA: 0x858CDB8 Offset: 0x8588DB8 VA: 0x858CDB8
	public static string Serialize(object obj) { }
}

// Namespace: UnityEngine.Purchasing.MiniJSON
[Extension]
public static class MiniJsonExtensions // TypeDefIndex: 28634
{
	// Methods

	[Extension]
	// RVA: 0x858F6D0 Offset: 0x858B6D0 VA: 0x858F6D0
	public static string toJson(Dictionary<string, object> obj) { }

	[Extension]
	// RVA: 0x858F6D4 Offset: 0x858B6D4 VA: 0x858F6D4
	public static List<object> ArrayListFromJson(string json) { }
}

