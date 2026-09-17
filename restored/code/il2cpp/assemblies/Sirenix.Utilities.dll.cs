// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 24816
{}

// Namespace: Sirenix.Utilities
[Extension]
public static class ColorExtensions // TypeDefIndex: 24817
{
	// Fields
	private static readonly char[] trimRGBStart; // 0x0

	// Methods

	[Extension]
	// RVA: 0x7F009DC Offset: 0x7EFC9DC VA: 0x7F009DC
	public static Color Lerp(Color[] colors, float t) { }

	[Extension]
	// RVA: 0x7F00A90 Offset: 0x7EFCA90 VA: 0x7F00A90
	public static Color MoveTowards(Color from, Color to, float maxDelta) { }

	// RVA: 0x7F00B0C Offset: 0x7EFCB0C VA: 0x7F00B0C
	public static bool TryParseString(string colorStr, out Color color) { }

	[Extension]
	// RVA: 0x7F00ED8 Offset: 0x7EFCED8 VA: 0x7F00ED8
	public static string ToCSharpColor(Color color) { }

	[Extension]
	// RVA: 0x7F0120C Offset: 0x7EFD20C VA: 0x7F0120C
	public static Color Pow(Color color, float factor) { }

	[Extension]
	// RVA: 0x7F01288 Offset: 0x7EFD288 VA: 0x7F01288
	public static Color NormalizeRGB(Color color) { }

	// RVA: 0x7F010EC Offset: 0x7EFD0EC VA: 0x7F010EC
	private static string TrimFloat(float value) { }

	// RVA: 0x7F01360 Offset: 0x7EFD360 VA: 0x7F01360
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DelegateExtensions.<>c__DisplayClass0_0<TResult> // TypeDefIndex: 24818
{
	// Fields
	public bool hasValue; // 0x0
	public TResult value; // 0x0
	public Func<TResult> getValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485D260 Offset: 0x4859260 VA: 0x485D260
	|-DelegateExtensions.<>c__DisplayClass0_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <Memoize>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485D268 Offset: 0x4859268 VA: 0x485D268
	|-DelegateExtensions.<>c__DisplayClass0_0<__Il2CppFullySharedGenericType>.<Memoize>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DelegateExtensions.<>c__DisplayClass1_0<T, TResult> // TypeDefIndex: 24819
{
	// Fields
	public Dictionary<T, TResult> dic; // 0x0
	public Func<T, TResult> func; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486A220 Offset: 0x4866220 VA: 0x486A220
	|-DelegateExtensions.<>c__DisplayClass1_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <Memoize>b__0(T n) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486A228 Offset: 0x4866228 VA: 0x486A228
	|-DelegateExtensions.<>c__DisplayClass1_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<Memoize>b__0
	*/
}

// Namespace: Sirenix.Utilities
[Extension]
public static class DelegateExtensions // TypeDefIndex: 24820
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static Func<TResult> Memoize<TResult>(Func<TResult> getValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45714F0 Offset: 0x456D4F0 VA: 0x45714F0
	|-DelegateExtensions.Memoize<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Func<T, TResult> Memoize<T, TResult>(Func<T, TResult> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45715EC Offset: 0x456D5EC VA: 0x45715EC
	|-DelegateExtensions.Memoize<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sirenix.Utilities
[Extension]
public static class FieldInfoExtensions // TypeDefIndex: 24821
{
	// Methods

	[Extension]
	// RVA: 0x7F01400 Offset: 0x7EFD400 VA: 0x7F01400
	public static bool IsAliasField(FieldInfo fieldInfo) { }

	[Extension]
	// RVA: 0x7F0145C Offset: 0x7EFD45C VA: 0x7F0145C
	public static FieldInfo DeAliasField(FieldInfo fieldInfo, bool throwOnNotAliased = False) { }
}

// Namespace: 
public struct GarbageFreeIterators.ListIterator<T> : IDisposable // TypeDefIndex: 24822
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
	|-RVA: 0x4B6742C Offset: 0x4B6342C VA: 0x4B6742C
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public GarbageFreeIterators.ListIterator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B67674 Offset: 0x4B63674 VA: 0x4B67674
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B67724 Offset: 0x4B63724 VA: 0x4B67724
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B67880 Offset: 0x4B63880 VA: 0x4B67880
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B67970 Offset: 0x4B63970 VA: 0x4B67970
	|-GarbageFreeIterators.ListIterator<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: 
public struct GarbageFreeIterators.HashsetIterator<T> : IDisposable // TypeDefIndex: 24823
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
	|-RVA: 0x4981BDC Offset: 0x497DBDC VA: 0x4981BDC
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public GarbageFreeIterators.HashsetIterator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4981E24 Offset: 0x497DE24 VA: 0x4981E24
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4981ED4 Offset: 0x497DED4 VA: 0x4981ED4
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4982030 Offset: 0x497E030 VA: 0x4982030
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4982120 Offset: 0x497E120 VA: 0x4982120
	|-GarbageFreeIterators.HashsetIterator<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: 
public struct GarbageFreeIterators.DictionaryIterator<T1, T2> : IDisposable // TypeDefIndex: 24824
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
	|-RVA: 0x5D583D0 Offset: 0x5D543D0 VA: 0x5D583D0
	|-GarbageFreeIterators.DictionaryIterator<object, object>..ctor
	|
	|-RVA: 0x5D58B3C Offset: 0x5D54B3C VA: 0x5D58B3C
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public GarbageFreeIterators.DictionaryIterator<T1, T2> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5848C Offset: 0x5D5448C VA: 0x5D5848C
	|-GarbageFreeIterators.DictionaryIterator<object, object>.GetEnumerator
	|
	|-RVA: 0x5D58D84 Offset: 0x5D54D84 VA: 0x5D58D84
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<T1, T2> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D584A8 Offset: 0x5D544A8 VA: 0x5D584A8
	|-GarbageFreeIterators.DictionaryIterator<object, object>.get_Current
	|
	|-RVA: 0x5D58E34 Offset: 0x5D54E34 VA: 0x5D58E34
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D584D0 Offset: 0x5D544D0 VA: 0x5D584D0
	|-GarbageFreeIterators.DictionaryIterator<object, object>.MoveNext
	|
	|-RVA: 0x5D58F90 Offset: 0x5D54F90 VA: 0x5D58F90
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D58514 Offset: 0x5D54514 VA: 0x5D58514
	|-GarbageFreeIterators.DictionaryIterator<object, object>.Dispose
	|
	|-RVA: 0x5D59084 Offset: 0x5D55084 VA: 0x5D59084
	|-GarbageFreeIterators.DictionaryIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: 
public struct GarbageFreeIterators.DictionaryValueIterator<T1, T2> : IDisposable // TypeDefIndex: 24825
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
	|-RVA: 0x5D5A810 Offset: 0x5D56810 VA: 0x5D5A810
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public GarbageFreeIterators.DictionaryValueIterator<T1, T2> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5AA58 Offset: 0x5D56A58 VA: 0x5D5AA58
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T2 get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5AB08 Offset: 0x5D56B08 VA: 0x5D5AB08
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5AD48 Offset: 0x5D56D48 VA: 0x5D5AD48
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D5AE3C Offset: 0x5D56E3C VA: 0x5D5AE3C
	|-GarbageFreeIterators.DictionaryValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: Sirenix.Utilities
[Extension]
public static class GarbageFreeIterators // TypeDefIndex: 24826
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static GarbageFreeIterators.ListIterator<T> GFIterator<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4631970 Offset: 0x462D970 VA: 0x4631970
	|-GarbageFreeIterators.GFIterator<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static GarbageFreeIterators.DictionaryIterator<T1, T2> GFIterator<T1, T2>(Dictionary<T1, T2> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4631A2C Offset: 0x462DA2C VA: 0x4631A2C
	|-GarbageFreeIterators.GFIterator<object, object>
	|
	|-RVA: 0x4631A7C Offset: 0x462DA7C VA: 0x4631A7C
	|-GarbageFreeIterators.GFIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static GarbageFreeIterators.DictionaryValueIterator<T1, T2> GFValueIterator<T1, T2>(Dictionary<T1, T2> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4631B38 Offset: 0x462DB38 VA: 0x4631B38
	|-GarbageFreeIterators.GFValueIterator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static GarbageFreeIterators.HashsetIterator<T> GFIterator<T>(HashSet<T> hashset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46318B4 Offset: 0x462D8B4 VA: 0x46318B4
	|-GarbageFreeIterators.GFIterator<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<AppendIf>d__20<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24827
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private bool condition; // 0x0
	public bool <>3__condition; // 0x0
	private Func<T> append; // 0x0
	public Func<T> <>3__append; // 0x0
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
	|-RVA: 0x5BC9324 Offset: 0x5BC5324 VA: 0x5BC9324
	|-LinqExtensions.<AppendIf>d__20<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC938C Offset: 0x5BC538C VA: 0x5BC938C
	|-LinqExtensions.<AppendIf>d__20<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC93EC Offset: 0x5BC53EC VA: 0x5BC93EC
	|-LinqExtensions.<AppendIf>d__20<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9948 Offset: 0x5BC5948 VA: 0x5BC9948
	|-LinqExtensions.<AppendIf>d__20<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9A54 Offset: 0x5BC5A54 VA: 0x5BC9A54
	|-LinqExtensions.<AppendIf>d__20<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9AF4 Offset: 0x5BC5AF4 VA: 0x5BC9AF4
	|-LinqExtensions.<AppendIf>d__20<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9B28 Offset: 0x5BC5B28 VA: 0x5BC9B28
	|-LinqExtensions.<AppendIf>d__20<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9BCC Offset: 0x5BC5BCC VA: 0x5BC9BCC
	|-LinqExtensions.<AppendIf>d__20<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9D54 Offset: 0x5BC5D54 VA: 0x5BC9D54
	|-LinqExtensions.<AppendIf>d__20<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<AppendIf>d__21<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24828
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private bool condition; // 0x0
	public bool <>3__condition; // 0x0
	private T append; // 0x0
	public T <>3__append; // 0x0
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
	|-RVA: 0x5BC9D68 Offset: 0x5BC5D68 VA: 0x5BC9D68
	|-LinqExtensions.<AppendIf>d__21<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9DD0 Offset: 0x5BC5DD0 VA: 0x5BC9DD0
	|-LinqExtensions.<AppendIf>d__21<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BC9E30 Offset: 0x5BC5E30 VA: 0x5BC9E30
	|-LinqExtensions.<AppendIf>d__21<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCA364 Offset: 0x5BC6364 VA: 0x5BCA364
	|-LinqExtensions.<AppendIf>d__21<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCA470 Offset: 0x5BC6470 VA: 0x5BCA470
	|-LinqExtensions.<AppendIf>d__21<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCA510 Offset: 0x5BC6510 VA: 0x5BCA510
	|-LinqExtensions.<AppendIf>d__21<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCA544 Offset: 0x5BC6544 VA: 0x5BCA544
	|-LinqExtensions.<AppendIf>d__21<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCA5E8 Offset: 0x5BC65E8 VA: 0x5BCA5E8
	|-LinqExtensions.<AppendIf>d__21<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCA7DC Offset: 0x5BC67DC VA: 0x5BCA7DC
	|-LinqExtensions.<AppendIf>d__21<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<AppendIf>d__22<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24829
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private bool condition; // 0x0
	public bool <>3__condition; // 0x0
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
	|-RVA: 0x5BCA7F0 Offset: 0x5BC67F0 VA: 0x5BCA7F0
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCA858 Offset: 0x5BC6858 VA: 0x5BCA858
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCA8E0 Offset: 0x5BC68E0 VA: 0x5BCA8E0
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCB088 Offset: 0x5BC7088 VA: 0x5BCB088
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCB194 Offset: 0x5BC7194 VA: 0x5BCB194
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCB2A0 Offset: 0x5BC72A0 VA: 0x5BCB2A0
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCB340 Offset: 0x5BC7340 VA: 0x5BCB340
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCB374 Offset: 0x5BC7374 VA: 0x5BCB374
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCB418 Offset: 0x5BC7418 VA: 0x5BCB418
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCB5A0 Offset: 0x5BC75A0 VA: 0x5BCB5A0
	|-LinqExtensions.<AppendIf>d__22<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<AppendIf>d__23<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24830
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private Func<bool> condition; // 0x0
	public Func<bool> <>3__condition; // 0x0
	private Func<T> append; // 0x0
	public Func<T> <>3__append; // 0x0
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
	|-RVA: 0x5BCB5B4 Offset: 0x5BC75B4 VA: 0x5BCB5B4
	|-LinqExtensions.<AppendIf>d__23<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCB61C Offset: 0x5BC761C VA: 0x5BCB61C
	|-LinqExtensions.<AppendIf>d__23<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCB67C Offset: 0x5BC767C VA: 0x5BCB67C
	|-LinqExtensions.<AppendIf>d__23<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCBBF4 Offset: 0x5BC7BF4 VA: 0x5BCBBF4
	|-LinqExtensions.<AppendIf>d__23<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCBD00 Offset: 0x5BC7D00 VA: 0x5BCBD00
	|-LinqExtensions.<AppendIf>d__23<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCBDA0 Offset: 0x5BC7DA0 VA: 0x5BCBDA0
	|-LinqExtensions.<AppendIf>d__23<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCBDD4 Offset: 0x5BC7DD4 VA: 0x5BCBDD4
	|-LinqExtensions.<AppendIf>d__23<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCBE78 Offset: 0x5BC7E78 VA: 0x5BCBE78
	|-LinqExtensions.<AppendIf>d__23<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCC000 Offset: 0x5BC8000 VA: 0x5BCC000
	|-LinqExtensions.<AppendIf>d__23<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<AppendIf>d__24<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24831
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private Func<bool> condition; // 0x0
	public Func<bool> <>3__condition; // 0x0
	private T append; // 0x0
	public T <>3__append; // 0x0
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
	|-RVA: 0x5BCC014 Offset: 0x5BC8014 VA: 0x5BCC014
	|-LinqExtensions.<AppendIf>d__24<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCC07C Offset: 0x5BC807C VA: 0x5BCC07C
	|-LinqExtensions.<AppendIf>d__24<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCC0DC Offset: 0x5BC80DC VA: 0x5BCC0DC
	|-LinqExtensions.<AppendIf>d__24<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCC62C Offset: 0x5BC862C VA: 0x5BCC62C
	|-LinqExtensions.<AppendIf>d__24<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCC738 Offset: 0x5BC8738 VA: 0x5BCC738
	|-LinqExtensions.<AppendIf>d__24<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCC7D8 Offset: 0x5BC87D8 VA: 0x5BCC7D8
	|-LinqExtensions.<AppendIf>d__24<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCC80C Offset: 0x5BC880C VA: 0x5BCC80C
	|-LinqExtensions.<AppendIf>d__24<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCC8B0 Offset: 0x5BC88B0 VA: 0x5BCC8B0
	|-LinqExtensions.<AppendIf>d__24<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCCAA4 Offset: 0x5BC8AA4 VA: 0x5BCCAA4
	|-LinqExtensions.<AppendIf>d__24<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<AppendIf>d__25<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24832
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private Func<bool> condition; // 0x0
	public Func<bool> <>3__condition; // 0x0
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
	|-RVA: 0x5BCCAB8 Offset: 0x5BC8AB8 VA: 0x5BCCAB8
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCCB20 Offset: 0x5BC8B20 VA: 0x5BCCB20
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCCBA8 Offset: 0x5BC8BA8 VA: 0x5BCCBA8
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCD36C Offset: 0x5BC936C VA: 0x5BCD36C
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCD478 Offset: 0x5BC9478 VA: 0x5BCD478
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCD584 Offset: 0x5BC9584 VA: 0x5BCD584
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCD624 Offset: 0x5BC9624 VA: 0x5BCD624
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCD658 Offset: 0x5BC9658 VA: 0x5BCD658
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCD6FC Offset: 0x5BC96FC VA: 0x5BCD6FC
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCD884 Offset: 0x5BC9884 VA: 0x5BCD884
	|-LinqExtensions.<AppendIf>d__25<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<AppendWith>d__17<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24833
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private Func<T> append; // 0x0
	public Func<T> <>3__append; // 0x0
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
	|-RVA: 0x5BCE2B8 Offset: 0x5BCA2B8 VA: 0x5BCE2B8
	|-LinqExtensions.<AppendWith>d__17<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCE320 Offset: 0x5BCA320 VA: 0x5BCE320
	|-LinqExtensions.<AppendWith>d__17<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCE380 Offset: 0x5BCA380 VA: 0x5BCE380
	|-LinqExtensions.<AppendWith>d__17<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCE8B0 Offset: 0x5BCA8B0 VA: 0x5BCE8B0
	|-LinqExtensions.<AppendWith>d__17<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCE9BC Offset: 0x5BCA9BC VA: 0x5BCE9BC
	|-LinqExtensions.<AppendWith>d__17<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCEA5C Offset: 0x5BCAA5C VA: 0x5BCEA5C
	|-LinqExtensions.<AppendWith>d__17<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCEA90 Offset: 0x5BCAA90 VA: 0x5BCEA90
	|-LinqExtensions.<AppendWith>d__17<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCEB34 Offset: 0x5BCAB34 VA: 0x5BCEB34
	|-LinqExtensions.<AppendWith>d__17<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCEC80 Offset: 0x5BCAC80 VA: 0x5BCEC80
	|-LinqExtensions.<AppendWith>d__17<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<AppendWith>d__18<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24834
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private T append; // 0x0
	public T <>3__append; // 0x0
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
	|-RVA: 0x5BCEC94 Offset: 0x5BCAC94 VA: 0x5BCEC94
	|-LinqExtensions.<AppendWith>d__18<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCECFC Offset: 0x5BCACFC VA: 0x5BCECFC
	|-LinqExtensions.<AppendWith>d__18<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCED5C Offset: 0x5BCAD5C VA: 0x5BCED5C
	|-LinqExtensions.<AppendWith>d__18<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCF264 Offset: 0x5BCB264 VA: 0x5BCF264
	|-LinqExtensions.<AppendWith>d__18<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCF370 Offset: 0x5BCB370 VA: 0x5BCF370
	|-LinqExtensions.<AppendWith>d__18<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCF410 Offset: 0x5BCB410 VA: 0x5BCF410
	|-LinqExtensions.<AppendWith>d__18<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCF444 Offset: 0x5BCB444 VA: 0x5BCF444
	|-LinqExtensions.<AppendWith>d__18<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCF4E8 Offset: 0x5BCB4E8 VA: 0x5BCF4E8
	|-LinqExtensions.<AppendWith>d__18<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCF6A0 Offset: 0x5BCB6A0 VA: 0x5BCF6A0
	|-LinqExtensions.<AppendWith>d__18<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<AppendWith>d__19<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24835
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
	|-RVA: 0x5BCF6B4 Offset: 0x5BCB6B4 VA: 0x5BCF6B4
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCF71C Offset: 0x5BCB71C VA: 0x5BCF71C
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCF7A4 Offset: 0x5BCB7A4 VA: 0x5BCF7A4
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BCFF24 Offset: 0x5BCBF24 VA: 0x5BCFF24
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD0030 Offset: 0x5BCC030 VA: 0x5BD0030
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD013C Offset: 0x5BCC13C VA: 0x5BD013C
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD01DC Offset: 0x5BCC1DC VA: 0x5BD01DC
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD0210 Offset: 0x5BCC210 VA: 0x5BD0210
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD02B4 Offset: 0x5BCC2B4 VA: 0x5BD02B4
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD0400 Offset: 0x5BCC400 VA: 0x5BD0400
	|-LinqExtensions.<AppendWith>d__19<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<Convert>d__3<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24836
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private Func<object, T> converter; // 0x0
	public Func<object, T> <>3__converter; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD5AD4 Offset: 0x5BD1AD4 VA: 0x5BD5AD4
	|-LinqExtensions.<Convert>d__3<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD5B3C Offset: 0x5BD1B3C VA: 0x5BD5B3C
	|-LinqExtensions.<Convert>d__3<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD5B9C Offset: 0x5BD1B9C VA: 0x5BD5B9C
	|-LinqExtensions.<Convert>d__3<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD5FE4 Offset: 0x5BD1FE4 VA: 0x5BD5FE4
	|-LinqExtensions.<Convert>d__3<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD60E0 Offset: 0x5BD20E0 VA: 0x5BD60E0
	|-LinqExtensions.<Convert>d__3<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD6180 Offset: 0x5BD2180 VA: 0x5BD6180
	|-LinqExtensions.<Convert>d__3<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD61B4 Offset: 0x5BD21B4 VA: 0x5BD61B4
	|-LinqExtensions.<Convert>d__3<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD6258 Offset: 0x5BD2258 VA: 0x5BD6258
	|-LinqExtensions.<Convert>d__3<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BD63A4 Offset: 0x5BD23A4 VA: 0x5BD63A4
	|-LinqExtensions.<Convert>d__3<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<Examine>d__0<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24837
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private Action<T> action; // 0x0
	public Action<T> <>3__action; // 0x0
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
	|-RVA: 0x5BDED0C Offset: 0x5BDAD0C VA: 0x5BDED0C
	|-LinqExtensions.<Examine>d__0<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BDED74 Offset: 0x5BDAD74 VA: 0x5BDED74
	|-LinqExtensions.<Examine>d__0<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BDEDD4 Offset: 0x5BDADD4 VA: 0x5BDEDD4
	|-LinqExtensions.<Examine>d__0<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BDF2C8 Offset: 0x5BDB2C8 VA: 0x5BDF2C8
	|-LinqExtensions.<Examine>d__0<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BDF3D4 Offset: 0x5BDB3D4 VA: 0x5BDF3D4
	|-LinqExtensions.<Examine>d__0<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BDF474 Offset: 0x5BDB474 VA: 0x5BDF474
	|-LinqExtensions.<Examine>d__0<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BDF4A8 Offset: 0x5BDB4A8 VA: 0x5BDF4A8
	|-LinqExtensions.<Examine>d__0<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BDF54C Offset: 0x5BDB54C VA: 0x5BDF54C
	|-LinqExtensions.<Examine>d__0<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BDF698 Offset: 0x5BDB698 VA: 0x5BDF698
	|-LinqExtensions.<Examine>d__0<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<FilterCast>d__26<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24838
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE04E4 Offset: 0x5BDC4E4 VA: 0x5BE04E4
	|-LinqExtensions.<FilterCast>d__26<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE054C Offset: 0x5BDC54C VA: 0x5BE054C
	|-LinqExtensions.<FilterCast>d__26<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE05AC Offset: 0x5BDC5AC VA: 0x5BE05AC
	|-LinqExtensions.<FilterCast>d__26<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE0A0C Offset: 0x5BDCA0C VA: 0x5BE0A0C
	|-LinqExtensions.<FilterCast>d__26<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE0B08 Offset: 0x5BDCB08 VA: 0x5BE0B08
	|-LinqExtensions.<FilterCast>d__26<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE0BA8 Offset: 0x5BDCBA8 VA: 0x5BE0BA8
	|-LinqExtensions.<FilterCast>d__26<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE0BDC Offset: 0x5BDCBDC VA: 0x5BE0BDC
	|-LinqExtensions.<FilterCast>d__26<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE0C80 Offset: 0x5BDCC80 VA: 0x5BE0C80
	|-LinqExtensions.<FilterCast>d__26<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE0D90 Offset: 0x5BDCD90 VA: 0x5BE0D90
	|-LinqExtensions.<FilterCast>d__26<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependIf>d__10<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24839
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private bool condition; // 0x0
	public bool <>3__condition; // 0x0
	private IEnumerable<T> prepend; // 0x0
	public IEnumerable<T> <>3__prepend; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
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
	|-RVA: 0x5D3CA8C Offset: 0x5D38A8C VA: 0x5D3CA8C
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3CAF4 Offset: 0x5D38AF4 VA: 0x5D3CAF4
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3CB7C Offset: 0x5D38B7C VA: 0x5D3CB7C
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D31C Offset: 0x5D3931C VA: 0x5D3D31C
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D428 Offset: 0x5D39428 VA: 0x5D3D428
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D534 Offset: 0x5D39534 VA: 0x5D3D534
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D5D4 Offset: 0x5D395D4 VA: 0x5D3D5D4
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D608 Offset: 0x5D39608 VA: 0x5D3D608
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D6AC Offset: 0x5D396AC VA: 0x5D3D6AC
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D834 Offset: 0x5D39834 VA: 0x5D3D834
	|-LinqExtensions.<PrependIf>d__10<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependIf>d__11<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24840
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<bool> condition; // 0x0
	public Func<bool> <>3__condition; // 0x0
	private Func<T> prepend; // 0x0
	public Func<T> <>3__prepend; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
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
	|-RVA: 0x5D3D848 Offset: 0x5D39848 VA: 0x5D3D848
	|-LinqExtensions.<PrependIf>d__11<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D8B0 Offset: 0x5D398B0 VA: 0x5D3D8B0
	|-LinqExtensions.<PrependIf>d__11<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D910 Offset: 0x5D39910 VA: 0x5D3D910
	|-LinqExtensions.<PrependIf>d__11<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3DE88 Offset: 0x5D39E88 VA: 0x5D3DE88
	|-LinqExtensions.<PrependIf>d__11<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3DF94 Offset: 0x5D39F94 VA: 0x5D3DF94
	|-LinqExtensions.<PrependIf>d__11<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3E034 Offset: 0x5D3A034 VA: 0x5D3E034
	|-LinqExtensions.<PrependIf>d__11<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3E068 Offset: 0x5D3A068 VA: 0x5D3E068
	|-LinqExtensions.<PrependIf>d__11<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3E10C Offset: 0x5D3A10C VA: 0x5D3E10C
	|-LinqExtensions.<PrependIf>d__11<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3E294 Offset: 0x5D3A294 VA: 0x5D3E294
	|-LinqExtensions.<PrependIf>d__11<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependIf>d__12<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24841
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<bool> condition; // 0x0
	public Func<bool> <>3__condition; // 0x0
	private T prepend; // 0x0
	public T <>3__prepend; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
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
	|-RVA: 0x5D3E2A8 Offset: 0x5D3A2A8 VA: 0x5D3E2A8
	|-LinqExtensions.<PrependIf>d__12<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3E310 Offset: 0x5D3A310 VA: 0x5D3E310
	|-LinqExtensions.<PrependIf>d__12<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3E370 Offset: 0x5D3A370 VA: 0x5D3E370
	|-LinqExtensions.<PrependIf>d__12<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3E8C0 Offset: 0x5D3A8C0 VA: 0x5D3E8C0
	|-LinqExtensions.<PrependIf>d__12<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3E9CC Offset: 0x5D3A9CC VA: 0x5D3E9CC
	|-LinqExtensions.<PrependIf>d__12<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3EA6C Offset: 0x5D3AA6C VA: 0x5D3EA6C
	|-LinqExtensions.<PrependIf>d__12<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3EAA0 Offset: 0x5D3AAA0 VA: 0x5D3EAA0
	|-LinqExtensions.<PrependIf>d__12<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3EB44 Offset: 0x5D3AB44 VA: 0x5D3EB44
	|-LinqExtensions.<PrependIf>d__12<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3ED38 Offset: 0x5D3AD38 VA: 0x5D3ED38
	|-LinqExtensions.<PrependIf>d__12<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependIf>d__13<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24842
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<bool> condition; // 0x0
	public Func<bool> <>3__condition; // 0x0
	private IEnumerable<T> prepend; // 0x0
	public IEnumerable<T> <>3__prepend; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
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
	|-RVA: 0x5D3ED4C Offset: 0x5D3AD4C VA: 0x5D3ED4C
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3EDB4 Offset: 0x5D3ADB4 VA: 0x5D3EDB4
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3EE3C Offset: 0x5D3AE3C VA: 0x5D3EE3C
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3F5F8 Offset: 0x5D3B5F8 VA: 0x5D3F5F8
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3F704 Offset: 0x5D3B704 VA: 0x5D3F704
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3F810 Offset: 0x5D3B810 VA: 0x5D3F810
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3F8B0 Offset: 0x5D3B8B0 VA: 0x5D3F8B0
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3F8E4 Offset: 0x5D3B8E4 VA: 0x5D3F8E4
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3F988 Offset: 0x5D3B988 VA: 0x5D3F988
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3FB10 Offset: 0x5D3BB10 VA: 0x5D3FB10
	|-LinqExtensions.<PrependIf>d__13<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependIf>d__14<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24843
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<IEnumerable<T>, bool> condition; // 0x0
	public Func<IEnumerable<T>, bool> <>3__condition; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private Func<T> prepend; // 0x0
	public Func<T> <>3__prepend; // 0x0
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
	|-RVA: 0x5E2E36C Offset: 0x5E2A36C VA: 0x5E2E36C
	|-LinqExtensions.<PrependIf>d__14<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2E3D4 Offset: 0x5E2A3D4 VA: 0x5E2E3D4
	|-LinqExtensions.<PrependIf>d__14<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2E434 Offset: 0x5E2A434 VA: 0x5E2E434
	|-LinqExtensions.<PrependIf>d__14<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2E9F4 Offset: 0x5E2A9F4 VA: 0x5E2E9F4
	|-LinqExtensions.<PrependIf>d__14<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2EB00 Offset: 0x5E2AB00 VA: 0x5E2EB00
	|-LinqExtensions.<PrependIf>d__14<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2EBA0 Offset: 0x5E2ABA0 VA: 0x5E2EBA0
	|-LinqExtensions.<PrependIf>d__14<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2EBD4 Offset: 0x5E2ABD4 VA: 0x5E2EBD4
	|-LinqExtensions.<PrependIf>d__14<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2EC78 Offset: 0x5E2AC78 VA: 0x5E2EC78
	|-LinqExtensions.<PrependIf>d__14<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2EE00 Offset: 0x5E2AE00 VA: 0x5E2EE00
	|-LinqExtensions.<PrependIf>d__14<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependIf>d__15<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24844
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<IEnumerable<T>, bool> condition; // 0x0
	public Func<IEnumerable<T>, bool> <>3__condition; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private T prepend; // 0x0
	public T <>3__prepend; // 0x0
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
	|-RVA: 0x5E2EE14 Offset: 0x5E2AE14 VA: 0x5E2EE14
	|-LinqExtensions.<PrependIf>d__15<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2EE7C Offset: 0x5E2AE7C VA: 0x5E2EE7C
	|-LinqExtensions.<PrependIf>d__15<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2EEDC Offset: 0x5E2AEDC VA: 0x5E2EEDC
	|-LinqExtensions.<PrependIf>d__15<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2F474 Offset: 0x5E2B474 VA: 0x5E2F474
	|-LinqExtensions.<PrependIf>d__15<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2F580 Offset: 0x5E2B580 VA: 0x5E2F580
	|-LinqExtensions.<PrependIf>d__15<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2F620 Offset: 0x5E2B620 VA: 0x5E2F620
	|-LinqExtensions.<PrependIf>d__15<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2F654 Offset: 0x5E2B654 VA: 0x5E2F654
	|-LinqExtensions.<PrependIf>d__15<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2F6F8 Offset: 0x5E2B6F8 VA: 0x5E2F6F8
	|-LinqExtensions.<PrependIf>d__15<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2F8EC Offset: 0x5E2B8EC VA: 0x5E2F8EC
	|-LinqExtensions.<PrependIf>d__15<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependIf>d__16<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24845
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<IEnumerable<T>, bool> condition; // 0x0
	public Func<IEnumerable<T>, bool> <>3__condition; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
	private IEnumerable<T> prepend; // 0x0
	public IEnumerable<T> <>3__prepend; // 0x0
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
	|-RVA: 0x5E2F900 Offset: 0x5E2B900 VA: 0x5E2F900
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2F968 Offset: 0x5E2B968 VA: 0x5E2F968
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2F9F0 Offset: 0x5E2B9F0 VA: 0x5E2F9F0
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E301F4 Offset: 0x5E2C1F4 VA: 0x5E301F4
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E30300 Offset: 0x5E2C300 VA: 0x5E30300
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3040C Offset: 0x5E2C40C VA: 0x5E3040C
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E304AC Offset: 0x5E2C4AC VA: 0x5E304AC
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E304E0 Offset: 0x5E2C4E0 VA: 0x5E304E0
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E30584 Offset: 0x5E2C584 VA: 0x5E30584
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3070C Offset: 0x5E2C70C VA: 0x5E3070C
	|-LinqExtensions.<PrependIf>d__16<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependIf>d__8<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24846
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private bool condition; // 0x0
	public bool <>3__condition; // 0x0
	private Func<T> prepend; // 0x0
	public Func<T> <>3__prepend; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
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
	|-RVA: 0x5E30720 Offset: 0x5E2C720 VA: 0x5E30720
	|-LinqExtensions.<PrependIf>d__8<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E30788 Offset: 0x5E2C788 VA: 0x5E30788
	|-LinqExtensions.<PrependIf>d__8<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E307E8 Offset: 0x5E2C7E8 VA: 0x5E307E8
	|-LinqExtensions.<PrependIf>d__8<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E30D44 Offset: 0x5E2CD44 VA: 0x5E30D44
	|-LinqExtensions.<PrependIf>d__8<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E30E50 Offset: 0x5E2CE50 VA: 0x5E30E50
	|-LinqExtensions.<PrependIf>d__8<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E30EF0 Offset: 0x5E2CEF0 VA: 0x5E30EF0
	|-LinqExtensions.<PrependIf>d__8<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E30F24 Offset: 0x5E2CF24 VA: 0x5E30F24
	|-LinqExtensions.<PrependIf>d__8<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E30FC8 Offset: 0x5E2CFC8 VA: 0x5E30FC8
	|-LinqExtensions.<PrependIf>d__8<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E31150 Offset: 0x5E2D150 VA: 0x5E31150
	|-LinqExtensions.<PrependIf>d__8<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependIf>d__9<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24847
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private bool condition; // 0x0
	public bool <>3__condition; // 0x0
	private T prepend; // 0x0
	public T <>3__prepend; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
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
	|-RVA: 0x5E31164 Offset: 0x5E2D164 VA: 0x5E31164
	|-LinqExtensions.<PrependIf>d__9<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E311CC Offset: 0x5E2D1CC VA: 0x5E311CC
	|-LinqExtensions.<PrependIf>d__9<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3122C Offset: 0x5E2D22C VA: 0x5E3122C
	|-LinqExtensions.<PrependIf>d__9<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E31760 Offset: 0x5E2D760 VA: 0x5E31760
	|-LinqExtensions.<PrependIf>d__9<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3186C Offset: 0x5E2D86C VA: 0x5E3186C
	|-LinqExtensions.<PrependIf>d__9<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3190C Offset: 0x5E2D90C VA: 0x5E3190C
	|-LinqExtensions.<PrependIf>d__9<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E31940 Offset: 0x5E2D940 VA: 0x5E31940
	|-LinqExtensions.<PrependIf>d__9<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E319E4 Offset: 0x5E2D9E4 VA: 0x5E319E4
	|-LinqExtensions.<PrependIf>d__9<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E31BD8 Offset: 0x5E2DBD8 VA: 0x5E31BD8
	|-LinqExtensions.<PrependIf>d__9<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependWith>d__5<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24848
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<T> prepend; // 0x0
	public Func<T> <>3__prepend; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
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
	|-RVA: 0x5E3260C Offset: 0x5E2E60C VA: 0x5E3260C
	|-LinqExtensions.<PrependWith>d__5<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E32674 Offset: 0x5E2E674 VA: 0x5E32674
	|-LinqExtensions.<PrependWith>d__5<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E326D4 Offset: 0x5E2E6D4 VA: 0x5E326D4
	|-LinqExtensions.<PrependWith>d__5<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E32C04 Offset: 0x5E2EC04 VA: 0x5E32C04
	|-LinqExtensions.<PrependWith>d__5<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E32D10 Offset: 0x5E2ED10 VA: 0x5E32D10
	|-LinqExtensions.<PrependWith>d__5<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E32DB0 Offset: 0x5E2EDB0 VA: 0x5E32DB0
	|-LinqExtensions.<PrependWith>d__5<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E32DE4 Offset: 0x5E2EDE4 VA: 0x5E32DE4
	|-LinqExtensions.<PrependWith>d__5<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E32E88 Offset: 0x5E2EE88 VA: 0x5E32E88
	|-LinqExtensions.<PrependWith>d__5<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E32FD4 Offset: 0x5E2EFD4 VA: 0x5E32FD4
	|-LinqExtensions.<PrependWith>d__5<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependWith>d__6<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24849
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private T prepend; // 0x0
	public T <>3__prepend; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
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
	|-RVA: 0x5E32FE8 Offset: 0x5E2EFE8 VA: 0x5E32FE8
	|-LinqExtensions.<PrependWith>d__6<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E33050 Offset: 0x5E2F050 VA: 0x5E33050
	|-LinqExtensions.<PrependWith>d__6<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E330B0 Offset: 0x5E2F0B0 VA: 0x5E330B0
	|-LinqExtensions.<PrependWith>d__6<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E335B8 Offset: 0x5E2F5B8 VA: 0x5E335B8
	|-LinqExtensions.<PrependWith>d__6<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E336C4 Offset: 0x5E2F6C4 VA: 0x5E336C4
	|-LinqExtensions.<PrependWith>d__6<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E33764 Offset: 0x5E2F764 VA: 0x5E33764
	|-LinqExtensions.<PrependWith>d__6<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E33798 Offset: 0x5E2F798 VA: 0x5E33798
	|-LinqExtensions.<PrependWith>d__6<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3383C Offset: 0x5E2F83C VA: 0x5E3383C
	|-LinqExtensions.<PrependWith>d__6<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E339F4 Offset: 0x5E2F9F4 VA: 0x5E339F4
	|-LinqExtensions.<PrependWith>d__6<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<PrependWith>d__7<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24850
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<T> prepend; // 0x0
	public IEnumerable<T> <>3__prepend; // 0x0
	private IEnumerable<T> source; // 0x0
	public IEnumerable<T> <>3__source; // 0x0
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
	|-RVA: 0x5E33A08 Offset: 0x5E2FA08 VA: 0x5E33A08
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E33A70 Offset: 0x5E2FA70 VA: 0x5E33A70
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E33AF8 Offset: 0x5E2FAF8 VA: 0x5E33AF8
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E34278 Offset: 0x5E30278 VA: 0x5E34278
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E34384 Offset: 0x5E30384 VA: 0x5E34384
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E34490 Offset: 0x5E30490 VA: 0x5E34490
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E34530 Offset: 0x5E30530 VA: 0x5E34530
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E34564 Offset: 0x5E30564 VA: 0x5E34564
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E34608 Offset: 0x5E30608 VA: 0x5E34608
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E34754 Offset: 0x5E30754 VA: 0x5E34754
	|-LinqExtensions.<PrependWith>d__7<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Sirenix.Utilities
[Extension]
public static class LinqExtensions // TypeDefIndex: 24851
{
	// Methods

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<Examine>d__0<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> Examine<T>(IEnumerable<T> source, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466678C Offset: 0x466278C VA: 0x466678C
	|-LinqExtensions.Examine<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> ForEach<T>(IEnumerable<T> source, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46668BC Offset: 0x46628BC VA: 0x46668BC
	|-LinqExtensions.ForEach<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> ForEach<T>(IEnumerable<T> source, Action<T, int> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4666C94 Offset: 0x4662C94 VA: 0x4666C94
	|-LinqExtensions.ForEach<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<Convert>d__3<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> Convert<T>(IEnumerable source, Func<object, T> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46666E0 Offset: 0x46626E0 VA: 0x46666E0
	|-LinqExtensions.Convert<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static ImmutableList<T> ToImmutableList<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4668724 Offset: 0x4664724 VA: 0x4668724
	|-LinqExtensions.ToImmutableList<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<PrependWith>d__5<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependWith<T>(IEnumerable<T> source, Func<T> prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667D10 Offset: 0x4663D10 VA: 0x4667D10
	|-LinqExtensions.PrependWith<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<PrependWith>d__6<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependWith<T>(IEnumerable<T> source, T prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667BE4 Offset: 0x4663BE4 VA: 0x4667BE4
	|-LinqExtensions.PrependWith<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<PrependWith>d__7<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependWith<T>(IEnumerable<T> source, IEnumerable<T> prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667DBC Offset: 0x4663DBC VA: 0x4667DBC
	|-LinqExtensions.PrependWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<PrependIf>d__8<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependIf<T>(IEnumerable<T> source, bool condition, Func<T> prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667A4C Offset: 0x4663A4C VA: 0x4667A4C
	|-LinqExtensions.PrependIf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<PrependIf>d__9<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependIf<T>(IEnumerable<T> source, bool condition, T prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667900 Offset: 0x4663900 VA: 0x4667900
	|-LinqExtensions.PrependIf<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<PrependIf>d__10<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependIf<T>(IEnumerable<T> source, bool condition, IEnumerable<T> prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667B18 Offset: 0x4663B18 VA: 0x4667B18
	|-LinqExtensions.PrependIf<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<PrependIf>d__11<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependIf<T>(IEnumerable<T> source, Func<bool> condition, Func<T> prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667484 Offset: 0x4663484 VA: 0x4667484
	|-LinqExtensions.PrependIf<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<PrependIf>d__12<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependIf<T>(IEnumerable<T> source, Func<bool> condition, T prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667338 Offset: 0x4663338 VA: 0x4667338
	|-LinqExtensions.PrependIf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<PrependIf>d__13<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependIf<T>(IEnumerable<T> source, Func<bool> condition, IEnumerable<T> prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667550 Offset: 0x4663550 VA: 0x4667550
	|-LinqExtensions.PrependIf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<PrependIf>d__14<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependIf<T>(IEnumerable<T> source, Func<IEnumerable<T>, bool> condition, Func<T> prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667768 Offset: 0x4663768 VA: 0x4667768
	|-LinqExtensions.PrependIf<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<PrependIf>d__15<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependIf<T>(IEnumerable<T> source, Func<IEnumerable<T>, bool> condition, T prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466761C Offset: 0x466361C VA: 0x466761C
	|-LinqExtensions.PrependIf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<PrependIf>d__16<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> PrependIf<T>(IEnumerable<T> source, Func<IEnumerable<T>, bool> condition, IEnumerable<T> prepend) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667834 Offset: 0x4663834 VA: 0x4667834
	|-LinqExtensions.PrependIf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<AppendWith>d__17<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AppendWith<T>(IEnumerable<T> source, Func<T> append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4666588 Offset: 0x4662588 VA: 0x4666588
	|-LinqExtensions.AppendWith<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<AppendWith>d__18<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AppendWith<T>(IEnumerable<T> source, T append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466645C Offset: 0x466245C VA: 0x466645C
	|-LinqExtensions.AppendWith<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<AppendWith>d__19<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AppendWith<T>(IEnumerable<T> source, IEnumerable<T> append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4666634 Offset: 0x4662634 VA: 0x4666634
	|-LinqExtensions.AppendWith<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<AppendIf>d__20<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AppendIf<T>(IEnumerable<T> source, bool condition, Func<T> append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46662C4 Offset: 0x46622C4 VA: 0x46662C4
	|-LinqExtensions.AppendIf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(LinqExtensions.<AppendIf>d__21<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AppendIf<T>(IEnumerable<T> source, bool condition, T append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4666178 Offset: 0x4662178 VA: 0x4666178
	|-LinqExtensions.AppendIf<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<AppendIf>d__22<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AppendIf<T>(IEnumerable<T> source, bool condition, IEnumerable<T> append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4666390 Offset: 0x4662390 VA: 0x4666390
	|-LinqExtensions.AppendIf<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<AppendIf>d__23<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AppendIf<T>(IEnumerable<T> source, Func<bool> condition, Func<T> append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4665FE0 Offset: 0x4661FE0 VA: 0x4665FE0
	|-LinqExtensions.AppendIf<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<AppendIf>d__24<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AppendIf<T>(IEnumerable<T> source, Func<bool> condition, T append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4665E94 Offset: 0x4661E94 VA: 0x4665E94
	|-LinqExtensions.AppendIf<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<AppendIf>d__25<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AppendIf<T>(IEnumerable<T> source, Func<bool> condition, IEnumerable<T> append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46660AC Offset: 0x46620AC VA: 0x46660AC
	|-LinqExtensions.AppendIf<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<FilterCast>d__26<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> FilterCast<T>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4666838 Offset: 0x4662838 VA: 0x4666838
	|-LinqExtensions.FilterCast<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddRange<T>(HashSet<T> hashSet, IEnumerable<T> range) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4665590 Offset: 0x4661590 VA: 0x4665590
	|-LinqExtensions.AddRange<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667088 Offset: 0x4663088 VA: 0x4667088
	|-LinqExtensions.IsNullOrEmpty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Populate<T>(IList<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466713C Offset: 0x466313C VA: 0x466713C
	|-LinqExtensions.Populate<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> list, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4665968 Offset: 0x4661968 VA: 0x4665968
	|-LinqExtensions.AddRange<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Sort<T>(IList<T> list, Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4668178 Offset: 0x4664178 VA: 0x4668178
	|-LinqExtensions.Sort<object>
	|
	|-RVA: 0x4668404 Offset: 0x4664404 VA: 0x4668404
	|-LinqExtensions.Sort<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Sort<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4667E68 Offset: 0x4663E68 VA: 0x4667E68
	|-LinqExtensions.Sort<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sirenix.Utilities
[Extension]
public static class ListExtensions // TypeDefIndex: 24852
{
	// Methods

	// RVA: -1 Offset: -1
	public static void SetLength<T>(ref IList<T> list, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46695A4 Offset: 0x46655A4 VA: 0x46695A4
	|-ListExtensions.SetLength<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SetLength<T>(ref IList<T> list, int length, Func<T> newElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4669EC4 Offset: 0x4665EC4 VA: 0x4669EC4
	|-ListExtensions.SetLength<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void SetLength<T>(IList<T> list, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466919C Offset: 0x466519C VA: 0x466919C
	|-ListExtensions.SetLength<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void SetLength<T>(IList<T> list, int length, Func<T> newElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4669AAC Offset: 0x4665AAC VA: 0x4669AAC
	|-ListExtensions.SetLength<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sirenix.Utilities
[Extension]
public static class MemberInfoExtensions // TypeDefIndex: 24853
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsDefined<T>(ICustomAttributeProvider member, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466EDF4 Offset: 0x466ADF4 VA: 0x466EDF4
	|-MemberInfoExtensions.IsDefined<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsDefined<T>(ICustomAttributeProvider member) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466EDB8 Offset: 0x466ADB8 VA: 0x466EDB8
	|-MemberInfoExtensions.IsDefined<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(ICustomAttributeProvider member, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466EB60 Offset: 0x466AB60 VA: 0x466EB60
	|-MemberInfoExtensions.GetAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(ICustomAttributeProvider member) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466EB24 Offset: 0x466AB24 VA: 0x466EB24
	|-MemberInfoExtensions.GetAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAttributes<T>(ICustomAttributeProvider member) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466EBD0 Offset: 0x466ABD0 VA: 0x466EBD0
	|-MemberInfoExtensions.GetAttributes<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAttributes<T>(ICustomAttributeProvider member, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x466EC0C Offset: 0x466AC0C VA: 0x466EC0C
	|-MemberInfoExtensions.GetAttributes<object>
	*/

	[Extension]
	// RVA: 0x7F01658 Offset: 0x7EFD658 VA: 0x7F01658
	public static Attribute[] GetAttributes(ICustomAttributeProvider member) { }

	[Extension]
	// RVA: 0x7F0174C Offset: 0x7EFD74C VA: 0x7F0174C
	public static Attribute[] GetAttributes(ICustomAttributeProvider member, bool inherit) { }

	[Extension]
	// RVA: 0x7F01588 Offset: 0x7EFD588 VA: 0x7F01588
	public static string GetNiceName(MemberInfo member) { }

	[Extension]
	// RVA: 0x7F01A24 Offset: 0x7EFDA24 VA: 0x7F01A24
	public static bool IsStatic(MemberInfo member) { }

	[Extension]
	// RVA: 0x7F01E70 Offset: 0x7EFDE70 VA: 0x7F01E70
	public static bool IsAlias(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x7F01F10 Offset: 0x7EFDF10 VA: 0x7F01F10
	public static MemberInfo DeAlias(MemberInfo memberInfo, bool throwOnNotAliased = False) { }

	[Extension]
	// RVA: 0x7F020B8 Offset: 0x7EFE0B8 VA: 0x7F020B8
	public static bool SignaturesAreEqual(MemberInfo a, MemberInfo b) { }
}

// Namespace: Sirenix.Utilities
[Extension]
public static class MethodInfoExtensions // TypeDefIndex: 24854
{
	// Methods

	[Extension]
	// RVA: 0x7F027AC Offset: 0x7EFE7AC VA: 0x7F027AC
	public static string GetFullName(MethodBase method, string extensionMethodPrefix) { }

	[Extension]
	// RVA: 0x7F02BDC Offset: 0x7EFEBDC VA: 0x7F02BDC
	public static string GetParamsNames(MethodBase method) { }

	[Extension]
	// RVA: 0x7F01854 Offset: 0x7EFD854 VA: 0x7F01854
	public static string GetFullName(MethodBase method) { }

	[Extension]
	// RVA: 0x7F029F4 Offset: 0x7EFE9F4 VA: 0x7F029F4
	public static bool IsExtensionMethod(MethodBase method) { }

	[Extension]
	// RVA: 0x7F02DDC Offset: 0x7EFEDDC VA: 0x7F02DDC
	public static bool IsAliasMethod(MethodInfo methodInfo) { }

	[Extension]
	// RVA: 0x7F02E38 Offset: 0x7EFEE38 VA: 0x7F02E38
	public static MethodInfo DeAliasMethod(MethodInfo methodInfo, bool throwOnNotAliased = False) { }
}

// Namespace: Sirenix.Utilities
public enum Operator // TypeDefIndex: 24855
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

// Namespace: Sirenix.Utilities
[Extension]
public static class PathUtilities // TypeDefIndex: 24856
{
	// Methods

	// RVA: 0x7F02F64 Offset: 0x7EFEF64 VA: 0x7F02F64
	public static string GetDirectoryName(string x) { }

	[Extension]
	// RVA: 0x7F03010 Offset: 0x7EFF010 VA: 0x7F03010
	public static bool HasSubDirectory(DirectoryInfo parentDir, DirectoryInfo subDir) { }

	[Extension]
	// RVA: 0x7F03164 Offset: 0x7EFF164 VA: 0x7F03164
	public static DirectoryInfo FindParentDirectoryWithName(DirectoryInfo dir, string folderName) { }

	// RVA: 0x7F031D8 Offset: 0x7EFF1D8 VA: 0x7F031D8
	public static bool CanMakeRelative(string absoluteParentPath, string absolutePath) { }

	// RVA: 0x7F03374 Offset: 0x7EFF374 VA: 0x7F03374
	public static string MakeRelative(string absoluteParentPath, string absolutePath) { }

	// RVA: 0x7F036EC Offset: 0x7EFF6EC VA: 0x7F036EC
	public static bool TryMakeRelative(string absoluteParentPath, string absolutePath, out string relativePath) { }

	// RVA: 0x7F03750 Offset: 0x7EFF750 VA: 0x7F03750
	public static string Combine(string a, string b) { }
}

// Namespace: Sirenix.Utilities
[Extension]
public static class PropertyInfoExtensions // TypeDefIndex: 24857
{
	// Methods

	[Extension]
	// RVA: 0x7F03888 Offset: 0x7EFF888 VA: 0x7F03888
	public static bool IsAutoProperty(PropertyInfo propInfo, bool allowVirtual = False) { }

	[Extension]
	// RVA: 0x7F03A90 Offset: 0x7EFFA90 VA: 0x7F03A90
	public static bool IsAliasProperty(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x7F03AEC Offset: 0x7EFFAEC VA: 0x7F03AEC
	public static PropertyInfo DeAliasProperty(PropertyInfo propertyInfo, bool throwOnNotAliased = False) { }
}

// Namespace: Sirenix.Utilities
public enum Direction // TypeDefIndex: 24858
{
	// Fields
	public int value__; // 0x0
	public const Direction Left = 0;
	public const Direction Right = 1;
	public const Direction Top = 2;
	public const Direction Bottom = 3;
}

// Namespace: Sirenix.Utilities
[Extension]
public static class RectExtensions // TypeDefIndex: 24859
{
	// Methods

	[Extension]
	// RVA: 0x7F03C18 Offset: 0x7EFFC18 VA: 0x7F03C18
	public static Rect TakeFromDir(ref Rect rect, float width, Direction direction) { }

	[Extension]
	// RVA: 0x7F03CBC Offset: 0x7EFFCBC VA: 0x7F03CBC
	public static Rect TakeFromLeft(ref Rect rect, float width) { }

	[Extension]
	// RVA: 0x7F03D48 Offset: 0x7EFFD48 VA: 0x7F03D48
	public static Rect TakeFromRight(ref Rect rect, float width) { }

	[Extension]
	// RVA: 0x7F03DD8 Offset: 0x7EFFDD8 VA: 0x7F03DD8
	public static Rect TakeFromTop(ref Rect rect, float height) { }

	[Extension]
	// RVA: 0x7F03E64 Offset: 0x7EFFE64 VA: 0x7F03E64
	public static Rect TakeFromBottom(ref Rect rect, float height) { }

	[Extension]
	// RVA: 0x7F03F10 Offset: 0x7EFFF10 VA: 0x7F03F10
	public static Rect SetWidth(Rect rect, float width) { }

	[Extension]
	// RVA: 0x7F03F18 Offset: 0x7EFFF18 VA: 0x7F03F18
	public static Rect SetHeight(Rect rect, float height) { }

	[Extension]
	// RVA: 0x7F03F20 Offset: 0x7EFFF20 VA: 0x7F03F20
	public static Rect SetSize(Rect rect, float width, float height) { }

	[Extension]
	// RVA: 0x7F03F2C Offset: 0x7EFFF2C VA: 0x7F03F2C
	public static Rect SetSize(Rect rect, float widthAndHeight) { }

	[Extension]
	// RVA: 0x7F03F38 Offset: 0x7EFFF38 VA: 0x7F03F38
	public static Rect SetSize(Rect rect, Vector2 size) { }

	[Extension]
	// RVA: 0x7F03F44 Offset: 0x7EFFF44 VA: 0x7F03F44
	public static Rect HorizontalPadding(Rect rect, float padding) { }

	[Extension]
	// RVA: 0x7F03F54 Offset: 0x7EFFF54 VA: 0x7F03F54
	public static Rect HorizontalPadding(Rect rect, float left, float right) { }

	[Extension]
	// RVA: 0x7F03F64 Offset: 0x7EFFF64 VA: 0x7F03F64
	public static Rect VerticalPadding(Rect rect, float padding) { }

	[Extension]
	// RVA: 0x7F03F74 Offset: 0x7EFFF74 VA: 0x7F03F74
	public static Rect VerticalPadding(Rect rect, float top, float bottom) { }

	[Extension]
	// RVA: 0x7F03F84 Offset: 0x7EFFF84 VA: 0x7F03F84
	public static Rect Padding(Rect rect, float padding) { }

	[Extension]
	// RVA: 0x7F03F9C Offset: 0x7EFFF9C VA: 0x7F03F9C
	public static Rect Padding(Rect rect, float horizontal, float vertical) { }

	[Extension]
	// RVA: 0x7F03FB8 Offset: 0x7EFFFB8 VA: 0x7F03FB8
	public static Rect Padding(Rect rect, float left, float right, float top, float bottom) { }

	[Extension]
	// RVA: 0x7F03FD4 Offset: 0x7EFFFD4 VA: 0x7F03FD4
	public static Rect AlignLeft(Rect rect, float width) { }

	[Extension]
	// RVA: 0x7F03FDC Offset: 0x7EFFFDC VA: 0x7F03FDC
	public static Rect AlignCenter(Rect rect, float width) { }

	[Extension]
	// RVA: 0x7F03FF8 Offset: 0x7EFFFF8 VA: 0x7F03FF8
	public static Rect AlignCenter(Rect rect, float width, float height) { }

	[Extension]
	// RVA: 0x7F03EF0 Offset: 0x7EFFEF0 VA: 0x7F03EF0
	public static Rect AlignRight(Rect rect, float width) { }

	[Extension]
	// RVA: 0x7F04028 Offset: 0x7F00028 VA: 0x7F04028
	public static Rect AlignRight(Rect rect, float width, bool clamp) { }

	[Extension]
	// RVA: 0x7F04054 Offset: 0x7F00054 VA: 0x7F04054
	public static Rect AlignTop(Rect rect, float height) { }

	[Extension]
	// RVA: 0x7F0405C Offset: 0x7F0005C VA: 0x7F0405C
	public static Rect AlignMiddle(Rect rect, float height) { }

	[Extension]
	// RVA: 0x7F03F00 Offset: 0x7EFFF00 VA: 0x7F03F00
	public static Rect AlignBottom(Rect rect, float height) { }

	[Extension]
	// RVA: 0x7F04078 Offset: 0x7F00078 VA: 0x7F04078
	public static Rect AlignCenterX(Rect rect, float width) { }

	[Extension]
	// RVA: 0x7F04094 Offset: 0x7F00094 VA: 0x7F04094
	public static Rect AlignCenterY(Rect rect, float height) { }

	[Extension]
	// RVA: 0x7F040B0 Offset: 0x7F000B0 VA: 0x7F040B0
	public static Rect AlignCenterXY(Rect rect, float size) { }

	[Extension]
	// RVA: 0x7F040DC Offset: 0x7F000DC VA: 0x7F040DC
	public static Rect AlignCenterXY(Rect rect, float width, float height) { }

	[Extension]
	// RVA: 0x7F0410C Offset: 0x7F0010C VA: 0x7F0410C
	public static Rect Expand(Rect rect, float expand) { }

	[Extension]
	// RVA: 0x7F04124 Offset: 0x7F00124 VA: 0x7F04124
	public static Rect Expand(Rect rect, float horizontal, float vertical) { }

	[Extension]
	// RVA: 0x7F04140 Offset: 0x7F00140 VA: 0x7F04140
	public static Rect Expand(Rect rect, float left, float right, float top, float bottom) { }

	[Extension]
	// RVA: 0x7F0415C Offset: 0x7F0015C VA: 0x7F0415C
	public static Rect Split(Rect rect, int index, int count) { }

	[Extension]
	// RVA: 0x7F04174 Offset: 0x7F00174 VA: 0x7F04174
	public static Rect SplitVertical(Rect rect, int index, int count) { }

	[Extension]
	// RVA: 0x7F0418C Offset: 0x7F0018C VA: 0x7F0418C
	public static Rect SplitGrid(Rect rect, float width, float height, int index) { }

	[Extension]
	// RVA: 0x7F041DC Offset: 0x7F001DC VA: 0x7F041DC
	public static Rect SplitTableGrid(Rect rect, int columnCount, float rowHeight, int index) { }

	[Extension]
	// RVA: 0x7F0420C Offset: 0x7F0020C VA: 0x7F0420C
	public static Rect SetCenterX(Rect rect, float x) { }

	[Extension]
	// RVA: 0x7F04228 Offset: 0x7F00228 VA: 0x7F04228
	public static Rect SetCenterY(Rect rect, float y) { }

	[Extension]
	// RVA: 0x7F04244 Offset: 0x7F00244 VA: 0x7F04244
	public static Rect SetCenter(Rect rect, float x, float y) { }

	[Extension]
	// RVA: 0x7F0425C Offset: 0x7F0025C VA: 0x7F0425C
	public static Rect SetCenter(Rect rect, Vector2 center) { }

	[Extension]
	// RVA: 0x7F04274 Offset: 0x7F00274 VA: 0x7F04274
	public static Rect SetPosition(Rect rect, Vector2 position) { }

	[Extension]
	// RVA: 0x7F04280 Offset: 0x7F00280 VA: 0x7F04280
	public static Rect ResetPosition(Rect rect) { }

	[Extension]
	// RVA: 0x7F042D8 Offset: 0x7F002D8 VA: 0x7F042D8
	public static Rect AddPosition(Rect rect, Vector2 move) { }

	[Extension]
	// RVA: 0x7F042E4 Offset: 0x7F002E4 VA: 0x7F042E4
	public static Rect AddPosition(Rect rect, float x, float y) { }

	[Extension]
	// RVA: 0x7F042F0 Offset: 0x7F002F0 VA: 0x7F042F0
	public static Rect SetX(Rect rect, float x) { }

	[Extension]
	// RVA: 0x7F042F8 Offset: 0x7F002F8 VA: 0x7F042F8
	public static Rect AddX(Rect rect, float x) { }

	[Extension]
	// RVA: 0x7F04300 Offset: 0x7F00300 VA: 0x7F04300
	public static Rect SubX(Rect rect, float x) { }

	[Extension]
	// RVA: 0x7F04308 Offset: 0x7F00308 VA: 0x7F04308
	public static Rect SetY(Rect rect, float y) { }

	[Extension]
	// RVA: 0x7F04310 Offset: 0x7F00310 VA: 0x7F04310
	public static Rect AddY(Rect rect, float y) { }

	[Extension]
	// RVA: 0x7F04318 Offset: 0x7F00318 VA: 0x7F04318
	public static Rect SubY(Rect rect, float y) { }

	[Extension]
	// RVA: 0x7F04320 Offset: 0x7F00320 VA: 0x7F04320
	public static Rect SetMin(Rect rect, Vector2 min) { }

	[Extension]
	// RVA: 0x7F0433C Offset: 0x7F0033C VA: 0x7F0433C
	public static Rect AddMin(Rect rect, Vector2 value) { }

	[Extension]
	// RVA: 0x7F04360 Offset: 0x7F00360 VA: 0x7F04360
	public static Rect SubMin(Rect rect, Vector2 value) { }

	[Extension]
	// RVA: 0x7F04384 Offset: 0x7F00384 VA: 0x7F04384
	public static Rect SetMax(Rect rect, Vector2 max) { }

	[Extension]
	// RVA: 0x7F04390 Offset: 0x7F00390 VA: 0x7F04390
	public static Rect AddMax(Rect rect, Vector2 value) { }

	[Extension]
	// RVA: 0x7F043AC Offset: 0x7F003AC VA: 0x7F043AC
	public static Rect SubMax(Rect rect, Vector2 value) { }

	[Extension]
	// RVA: 0x7F043C8 Offset: 0x7F003C8 VA: 0x7F043C8
	public static Rect SetXMin(Rect rect, float xMin) { }

	[Extension]
	// RVA: 0x7F043D8 Offset: 0x7F003D8 VA: 0x7F043D8
	public static Rect AddXMin(Rect rect, float value) { }

	[Extension]
	// RVA: 0x7F043EC Offset: 0x7F003EC VA: 0x7F043EC
	public static Rect SubXMin(Rect rect, float value) { }

	[Extension]
	// RVA: 0x7F04400 Offset: 0x7F00400 VA: 0x7F04400
	public static Rect SetXMax(Rect rect, float xMax) { }

	[Extension]
	// RVA: 0x7F04408 Offset: 0x7F00408 VA: 0x7F04408
	public static Rect AddXMax(Rect rect, float value) { }

	[Extension]
	// RVA: 0x7F04418 Offset: 0x7F00418 VA: 0x7F04418
	public static Rect SubXMax(Rect rect, float value) { }

	[Extension]
	// RVA: 0x7F04428 Offset: 0x7F00428 VA: 0x7F04428
	public static Rect SetYMin(Rect rect, float yMin) { }

	[Extension]
	// RVA: 0x7F04438 Offset: 0x7F00438 VA: 0x7F04438
	public static Rect AddYMin(Rect rect, float value) { }

	[Extension]
	// RVA: 0x7F0444C Offset: 0x7F0044C VA: 0x7F0444C
	public static Rect SubYMin(Rect rect, float value) { }

	[Extension]
	// RVA: 0x7F04460 Offset: 0x7F00460 VA: 0x7F04460
	public static Rect SetYMax(Rect rect, float yMax) { }

	[Extension]
	// RVA: 0x7F04468 Offset: 0x7F00468 VA: 0x7F04468
	public static Rect AddYMax(Rect rect, float value) { }

	[Extension]
	// RVA: 0x7F04478 Offset: 0x7F00478 VA: 0x7F04478
	public static Rect SubYMax(Rect rect, float value) { }

	[Extension]
	// RVA: 0x7F04488 Offset: 0x7F00488 VA: 0x7F04488
	public static Rect MinWidth(Rect rect, float minWidth) { }

	[Extension]
	// RVA: 0x7F04494 Offset: 0x7F00494 VA: 0x7F04494
	public static Rect MaxWidth(Rect rect, float maxWidth) { }

	[Extension]
	// RVA: 0x7F044A0 Offset: 0x7F004A0 VA: 0x7F044A0
	public static Rect MinHeight(Rect rect, float minHeight) { }

	[Extension]
	// RVA: 0x7F044AC Offset: 0x7F004AC VA: 0x7F044AC
	public static Rect MaxHeight(Rect rect, float maxHeight) { }

	[Extension]
	// RVA: 0x7F044B8 Offset: 0x7F004B8 VA: 0x7F044B8
	public static Rect ExpandTo(Rect rect, Vector2 pos) { }
}

// Namespace: Sirenix.Utilities
[Extension]
public static class StringExtensions // TypeDefIndex: 24860
{
	// Methods

	[Extension]
	// RVA: 0x7F0189C Offset: 0x7EFD89C VA: 0x7F0189C
	public static string ToTitleCase(string input) { }

	[Extension]
	// RVA: 0x7F04504 Offset: 0x7F00504 VA: 0x7F04504
	public static bool Contains(string source, string toCheck, StringComparison comparisonType) { }

	[Extension]
	// RVA: 0x7F04528 Offset: 0x7F00528 VA: 0x7F04528
	public static string SplitPascalCase(string input) { }

	[Extension]
	// RVA: 0x7F04714 Offset: 0x7F00714 VA: 0x7F04714
	public static bool IsNullOrWhitespace(string str) { }

	// RVA: 0x7F047E8 Offset: 0x7F007E8 VA: 0x7F047E8
	public static int CalculateLevenshteinDistance(string source1, string source2) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeExtensions.<>c__37<T> // TypeDefIndex: 24861
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
	|-RVA: 0x485A78C Offset: 0x485678C VA: 0x485A78C
	|-TypeExtensions.<>c__37<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485A880 Offset: 0x4856880 VA: 0x485A880
	|-TypeExtensions.<>c__37<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <GetEqualityComparerDelegate>b__37_0(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485A888 Offset: 0x4856888 VA: 0x485A888
	|-TypeExtensions.<>c__37<__Il2CppFullySharedGenericType>.<GetEqualityComparerDelegate>b__37_0
	*/

	// RVA: -1 Offset: -1
	internal bool <GetEqualityComparerDelegate>b__37_1(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485AAB4 Offset: 0x4856AB4 VA: 0x485AAB4
	|-TypeExtensions.<>c__37<__Il2CppFullySharedGenericType>.<GetEqualityComparerDelegate>b__37_1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<>c__DisplayClass31_0 // TypeDefIndex: 24862
{
	// Fields
	public MethodInfo method; // 0x10

	// Methods

	// RVA: 0x7F067A4 Offset: 0x7F027A4 VA: 0x7F067A4
	public void .ctor() { }

	// RVA: 0x7F0EC30 Offset: 0x7F0AC30 VA: 0x7F0EC30
	internal object <GetCastMethodDelegate>b__0(object obj) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<>c__DisplayClass47_0 // TypeDefIndex: 24863
{
	// Fields
	public string methodName; // 0x10

	// Methods

	// RVA: 0x7F07B00 Offset: 0x7F03B00 VA: 0x7F07B00
	public void .ctor() { }

	// RVA: 0x7F0ECEC Offset: 0x7F0ACEC VA: 0x7F0ECEC
	internal bool <GetOperatorMethod>b__0(MethodInfo m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<>c__DisplayClass48_0 // TypeDefIndex: 24864
{
	// Fields
	public string methodName; // 0x10

	// Methods

	// RVA: 0x7F07EC4 Offset: 0x7F03EC4 VA: 0x7F07EC4
	public void .ctor() { }

	// RVA: 0x7F0ED24 Offset: 0x7F0AD24 VA: 0x7F0ED24
	internal bool <GetOperatorMethods>b__0(MethodInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetAllMembers>d__49 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IDisposable, IEnumerator // TypeDefIndex: 24865
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
	// RVA: 0x7F07F58 Offset: 0x7F03F58 VA: 0x7F07F58
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7F0ED5C Offset: 0x7F0AD5C VA: 0x7F0ED5C Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F0ED60 Offset: 0x7F0AD60 VA: 0x7F0ED60 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7F0EF7C Offset: 0x7F0AF7C VA: 0x7F0EF7C Slot: 6
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F0EF84 Offset: 0x7F0AF84 VA: 0x7F0EF84 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7F0EFBC Offset: 0x7F0AFBC VA: 0x7F0EFBC Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F0EFC4 Offset: 0x7F0AFC4 VA: 0x7F0EFC4 Slot: 4
	private IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7F0F070 Offset: 0x7F0B070 VA: 0x7F0F070 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetAllMembers>d__50 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IDisposable, IEnumerator // TypeDefIndex: 24866
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
	// RVA: 0x7F0802C Offset: 0x7F0402C VA: 0x7F0802C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7F0F074 Offset: 0x7F0B074 VA: 0x7F0F074 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F0F090 Offset: 0x7F0B090 VA: 0x7F0F090 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x7F0F3B4 Offset: 0x7F0B3B4 VA: 0x7F0F3B4
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x7F0F464 Offset: 0x7F0B464 VA: 0x7F0F464 Slot: 6
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F0F46C Offset: 0x7F0B46C VA: 0x7F0F46C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7F0F4A4 Offset: 0x7F0B4A4 VA: 0x7F0F4A4 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F0F4AC Offset: 0x7F0B4AC VA: 0x7F0F4AC Slot: 4
	private IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7F0F568 Offset: 0x7F0B568 VA: 0x7F0F568 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetAllMembers>d__51<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24867
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
	|-RVA: 0x5D25F64 Offset: 0x5D21F64 VA: 0x5D25F64
	|-TypeExtensions.<GetAllMembers>d__51<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25F98 Offset: 0x5D21F98 VA: 0x5D25F98
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D25F9C Offset: 0x5D21F9C VA: 0x5D25F9C
	|-TypeExtensions.<GetAllMembers>d__51<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D26394 Offset: 0x5D22394 VA: 0x5D26394
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2639C Offset: 0x5D2239C VA: 0x5D2639C
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D263D0 Offset: 0x5D223D0 VA: 0x5D263D0
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D263D8 Offset: 0x5D223D8 VA: 0x5D263D8
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D26474 Offset: 0x5D22474 VA: 0x5D26474
	|-TypeExtensions.<GetAllMembers>d__51<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetBaseClasses>d__55 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IDisposable, IEnumerator // TypeDefIndex: 24868
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
	// RVA: 0x7F086D4 Offset: 0x7F046D4 VA: 0x7F086D4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7F0F56C Offset: 0x7F0B56C VA: 0x7F0F56C Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F0F570 Offset: 0x7F0B570 VA: 0x7F0F570 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x7F0F714 Offset: 0x7F0B714 VA: 0x7F0F714 Slot: 6
	private Type System.Collections.Generic.IEnumerator<System.Type>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F0F71C Offset: 0x7F0B71C VA: 0x7F0F71C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7F0F754 Offset: 0x7F0B754 VA: 0x7F0F754 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F0F75C Offset: 0x7F0B75C VA: 0x7F0F75C Slot: 4
	private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x7F0F808 Offset: 0x7F0B808 VA: 0x7F0F808 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeExtensions.<GetCustomAttributes>d__64<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 24869
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
	|-RVA: 0x5D267BC Offset: 0x5D227BC VA: 0x5D267BC
	|-TypeExtensions.<GetCustomAttributes>d__64<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D267F0 Offset: 0x5D227F0 VA: 0x5D267F0
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D267F4 Offset: 0x5D227F4 VA: 0x5D267F4
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D26A04 Offset: 0x5D22A04 VA: 0x5D26A04
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D26A0C Offset: 0x5D22A0C VA: 0x5D26A0C
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D26A40 Offset: 0x5D22A40 VA: 0x5D26A40
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D26A48 Offset: 0x5D22A48 VA: 0x5D26A48
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D26AE4 Offset: 0x5D22AE4 VA: 0x5D26AE4
	|-TypeExtensions.<GetCustomAttributes>d__64<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Sirenix.Utilities
[Extension]
public static class TypeExtensions // TypeDefIndex: 24870
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
	public static readonly Dictionary<Type, string> TypeNameAlternatives; // 0x90
	private static readonly object CachedNiceNames_LOCK; // 0x98
	private static readonly Dictionary<Type, string> CachedNiceNames; // 0xA0
	private static readonly Type VoidPointerType; // 0xA8
	private static readonly Dictionary<Type, HashSet<Type>> PrimitiveImplicitCasts; // 0xB0
	private static readonly HashSet<Type> ExplicitCastIntegrals; // 0xB8

	// Methods

	// RVA: 0x7F04AE0 Offset: 0x7F00AE0 VA: 0x7F04AE0
	private static string GetCachedNiceName(Type type) { }

	// RVA: 0x7F04CA8 Offset: 0x7F00CA8 VA: 0x7F04CA8
	private static string CreateNiceName(Type type) { }

	[Extension]
	// RVA: 0x7F05330 Offset: 0x7F01330 VA: 0x7F05330
	private static bool HasCastDefined(Type from, Type to, bool requireImplicitCast) { }

	// RVA: 0x7F061CC Offset: 0x7F021CC VA: 0x7F061CC
	public static bool IsValidIdentifier(string identifier) { }

	// RVA: 0x7F063DC Offset: 0x7F023DC VA: 0x7F063DC
	private static bool IsValidIdentifierStartCharacter(char c) { }

	// RVA: 0x7F0646C Offset: 0x7F0246C VA: 0x7F0646C
	private static bool IsValidIdentifierPartCharacter(char c) { }

	[Extension]
	// RVA: 0x7F057A8 Offset: 0x7F017A8 VA: 0x7F057A8
	public static bool IsCastableTo(Type from, Type to, bool requireImplicitCast = False) { }

	[Extension]
	// RVA: 0x7F06510 Offset: 0x7F02510 VA: 0x7F06510
	public static Func<object, object> GetCastMethodDelegate(Type from, Type to, bool requireImplicitCast = False) { }

	// RVA: -1 Offset: -1
	public static Func<TFrom, TTo> GetCastMethodDelegate<TFrom, TTo>(bool requireImplicitCast = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4735E14 Offset: 0x4731E14 VA: 0x4735E14
	|-TypeExtensions.GetCastMethodDelegate<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7F05934 Offset: 0x7F01934 VA: 0x7F05934
	public static MethodInfo GetCastMethod(Type from, Type to, bool requireImplicitCast = False) { }

	// RVA: 0x7F067AC Offset: 0x7F027AC VA: 0x7F067AC
	private static bool FloatEqualityComparer(float a, float b) { }

	// RVA: 0x7F067EC Offset: 0x7F027EC VA: 0x7F067EC
	private static bool DoubleEqualityComparer(double a, double b) { }

	// RVA: 0x7F0682C Offset: 0x7F0282C VA: 0x7F0682C
	private static bool QuaternionEqualityComparer(Quaternion a, Quaternion b) { }

	// RVA: -1 Offset: -1
	public static Func<T, T, bool> GetEqualityComparerDelegate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47363F0 Offset: 0x47323F0 VA: 0x47363F0
	|-TypeExtensions.GetEqualityComparerDelegate<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type type, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4735D20 Offset: 0x4731D20 VA: 0x4735D20
	|-TypeExtensions.GetAttribute<object>
	*/

	[Extension]
	// RVA: 0x7F06854 Offset: 0x7F02854 VA: 0x7F06854
	public static bool ImplementsOrInherits(Type type, Type to) { }

	[Extension]
	// RVA: 0x7F06880 Offset: 0x7F02880 VA: 0x7F06880
	public static bool ImplementsOpenGenericType(Type candidateType, Type openGenericType) { }

	[Extension]
	// RVA: 0x7F06908 Offset: 0x7F02908 VA: 0x7F06908
	public static bool ImplementsOpenGenericInterface(Type candidateType, Type openGenericInterfaceType) { }

	[Extension]
	// RVA: 0x7F06A7C Offset: 0x7F02A7C VA: 0x7F06A7C
	public static bool ImplementsOpenGenericClass(Type candidateType, Type openGenericType) { }

	[Extension]
	// RVA: 0x7F06BA8 Offset: 0x7F02BA8 VA: 0x7F06BA8
	public static Type[] GetArgumentsOfInheritedOpenGenericType(Type candidateType, Type openGenericType) { }

	[Extension]
	// RVA: 0x7F06EEC Offset: 0x7F02EEC VA: 0x7F06EEC
	public static Type[] GetArgumentsOfInheritedOpenGenericClass(Type candidateType, Type openGenericType) { }

	[Extension]
	// RVA: 0x7F06C30 Offset: 0x7F02C30 VA: 0x7F06C30
	public static Type[] GetArgumentsOfInheritedOpenGenericInterface(Type candidateType, Type openGenericInterfaceType) { }

	[Extension]
	// RVA: 0x7F07028 Offset: 0x7F03028 VA: 0x7F07028
	public static MethodInfo GetOperatorMethod(Type type, Operator op, Type leftOperand, Type rightOperand) { }

	[Extension]
	// RVA: 0x7F0776C Offset: 0x7F0376C VA: 0x7F0776C
	public static MethodInfo GetOperatorMethod(Type type, Operator op) { }

	[Extension]
	// RVA: 0x7F07B08 Offset: 0x7F03B08 VA: 0x7F07B08
	public static MethodInfo[] GetOperatorMethods(Type type, Operator op) { }

	[IteratorStateMachine(typeof(TypeExtensions.<GetAllMembers>d__49))]
	[Extension]
	// RVA: 0x7F07ECC Offset: 0x7F03ECC VA: 0x7F07ECC
	public static IEnumerable<MemberInfo> GetAllMembers(Type type, BindingFlags flags = 0) { }

	[Extension]
	[IteratorStateMachine(typeof(TypeExtensions.<GetAllMembers>d__50))]
	// RVA: 0x7F07F8C Offset: 0x7F03F8C VA: 0x7F07F8C
	public static IEnumerable<MemberInfo> GetAllMembers(Type type, string name, BindingFlags flags = 0) { }

	[IteratorStateMachine(typeof(TypeExtensions.<GetAllMembers>d__51<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAllMembers<T>(Type type, BindingFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4735CA4 Offset: 0x4731CA4 VA: 0x4735CA4
	|-TypeExtensions.GetAllMembers<object>
	*/

	[Extension]
	// RVA: 0x7F08060 Offset: 0x7F04060 VA: 0x7F08060
	public static Type GetGenericBaseType(Type type, Type baseType) { }

	[Extension]
	// RVA: 0x7F080D0 Offset: 0x7F040D0 VA: 0x7F080D0
	public static Type GetGenericBaseType(Type type, Type baseType, out int depthCount) { }

	[Extension]
	// RVA: 0x7F08508 Offset: 0x7F04508 VA: 0x7F08508
	public static IEnumerable<Type> GetBaseTypes(Type type, bool includeSelf = False) { }

	[IteratorStateMachine(typeof(TypeExtensions.<GetBaseClasses>d__55))]
	[Extension]
	// RVA: 0x7F08644 Offset: 0x7F04644 VA: 0x7F08644
	public static IEnumerable<Type> GetBaseClasses(Type type, bool includeSelf = False) { }

	[Extension]
	// RVA: 0x7F05278 Offset: 0x7F01278 VA: 0x7F05278
	private static string GetMaybeSimplifiedTypeName(Type type) { }

	[Extension]
	// RVA: 0x7F02AE8 Offset: 0x7EFEAE8 VA: 0x7F02AE8
	public static string GetNiceName(Type type) { }

	[Extension]
	// RVA: 0x7F08708 Offset: 0x7F04708 VA: 0x7F08708
	public static string GetNiceFullName(Type type) { }

	[Extension]
	// RVA: 0x7F08844 Offset: 0x7F04844 VA: 0x7F08844
	public static string GetCompilableNiceName(Type type) { }

	[Extension]
	// RVA: 0x7F08918 Offset: 0x7F04918 VA: 0x7F08918
	public static string GetCompilableNiceFullName(Type type) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Type type, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47361EC Offset: 0x47321EC VA: 0x47361EC
	|-TypeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4736184 Offset: 0x4732184 VA: 0x4736184
	|-TypeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4736308 Offset: 0x4732308 VA: 0x4736308
	|-TypeExtensions.GetCustomAttributes<object>
	*/

	[IteratorStateMachine(typeof(TypeExtensions.<GetCustomAttributes>d__64<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(Type type, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4736370 Offset: 0x4732370 VA: 0x4736370
	|-TypeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsDefined<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4736B08 Offset: 0x4732B08 VA: 0x4736B08
	|-TypeExtensions.IsDefined<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsDefined<T>(Type type, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4736B94 Offset: 0x4732B94 VA: 0x4736B94
	|-TypeExtensions.IsDefined<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool InheritsFrom<TBase>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4736A64 Offset: 0x4732A64 VA: 0x4736A64
	|-TypeExtensions.InheritsFrom<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x7F050A8 Offset: 0x7F010A8 VA: 0x7F050A8
	public static bool InheritsFrom(Type type, Type baseType) { }

	[Extension]
	// RVA: 0x7F089EC Offset: 0x7F049EC VA: 0x7F089EC
	public static int GetInheritanceDistance(Type type, Type baseType) { }

	[Extension]
	// RVA: 0x7F08DB4 Offset: 0x7F04DB4 VA: 0x7F08DB4
	public static bool HasParamaters(MethodInfo methodInfo, IList<Type> paramTypes, bool inherit = True) { }

	[Extension]
	// RVA: 0x7F0255C Offset: 0x7EFE55C VA: 0x7F0255C
	public static Type GetReturnType(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x7F09074 Offset: 0x7F05074 VA: 0x7F09074
	public static object GetMemberValue(MemberInfo member, object obj) { }

	[Extension]
	// RVA: 0x7F091EC Offset: 0x7F051EC VA: 0x7F091EC
	public static void SetMemberValue(MemberInfo member, object obj, object value) { }

	[Extension]
	// RVA: 0x7F09448 Offset: 0x7F05448 VA: 0x7F09448
	public static bool TryInferGenericParameters(Type genericTypeDefinition, out Type[] inferredParams, Type[] knownParameters) { }

	[Extension]
	// RVA: 0x7F0A5AC Offset: 0x7F065AC VA: 0x7F0A5AC
	public static bool AreGenericConstraintsSatisfiedBy(Type genericType, Type[] parameters) { }

	[Extension]
	// RVA: 0x7F0A940 Offset: 0x7F06940 VA: 0x7F0A940
	public static bool AreGenericConstraintsSatisfiedBy(MethodBase genericMethod, Type[] parameters) { }

	// RVA: 0x7F0A724 Offset: 0x7F06724 VA: 0x7F0A724
	public static bool AreGenericConstraintsSatisfiedBy(Type[] definitions, Type[] parameters) { }

	[Extension]
	// RVA: 0x7F0B314 Offset: 0x7F07314 VA: 0x7F0B314
	public static bool GenericParameterIsFulfilledBy(Type genericParameterDefinition, Type parameterType) { }

	[Extension]
	// RVA: 0x7F0AA8C Offset: 0x7F06A8C VA: 0x7F0AA8C
	private static bool GenericParameterIsFulfilledBy(Type genericParameterDefinition, Type parameterType, Dictionary<Type, Type> resolvedMap, HashSet<Type> processedParams) { }

	[Extension]
	// RVA: 0x7F0B47C Offset: 0x7F0747C VA: 0x7F0B47C
	public static string GetGenericConstraintsString(Type type, bool useFullTypeNames = False) { }

	[Extension]
	// RVA: 0x7F0B6E4 Offset: 0x7F076E4 VA: 0x7F0B6E4
	public static string GetGenericParameterConstraintsString(Type type, bool useFullTypeNames = False) { }

	[Extension]
	// RVA: 0x7F0BB88 Offset: 0x7F07B88 VA: 0x7F0BB88
	public static bool GenericArgumentsContainsTypes(Type type, Type[] types) { }

	[Extension]
	// RVA: 0x7F0A3B4 Offset: 0x7F063B4 VA: 0x7F0A3B4
	public static bool IsFullyConstructedGenericType(Type type) { }

	[Extension]
	// RVA: 0x7F0C0EC Offset: 0x7F080EC VA: 0x7F0C0EC
	public static bool IsNullableType(Type type) { }

	// RVA: 0x7F0C144 Offset: 0x7F08144 VA: 0x7F0C144
	public static ulong GetEnumBitmask(object value, Type enumType) { }

	// RVA: 0x7F0C308 Offset: 0x7F08308 VA: 0x7F0C308
	public static bool IsCSharpKeyword(string identifier) { }

	[Extension]
	// RVA: 0x7F0C388 Offset: 0x7F08388 VA: 0x7F0C388
	public static Type[] SafeGetTypes(Assembly assembly) { }

	[Extension]
	// RVA: 0x7F0C44C Offset: 0x7F0844C VA: 0x7F0C44C
	public static bool SafeIsDefined(Assembly assembly, Type attribute, bool inherit) { }

	[Extension]
	// RVA: 0x7F0C4F0 Offset: 0x7F084F0 VA: 0x7F0C4F0
	public static object[] SafeGetCustomAttributes(Assembly assembly, Type type, bool inherit) { }

	// RVA: 0x7F0C5A0 Offset: 0x7F085A0 VA: 0x7F0C5A0
	private static void .cctor() { }
}

// Namespace: Sirenix.Utilities
[Extension]
public static class UnityExtensions // TypeDefIndex: 24871
{
	// Fields
	private static readonly ValueGetter<Object, IntPtr> UnityObjectCachedPtrFieldGetter; // 0x0

	// Methods

	// RVA: 0x7F0F80C Offset: 0x7F0B80C VA: 0x7F0F80C
	private static void .cctor() { }

	[Extension]
	// RVA: 0x7F0F940 Offset: 0x7F0B940 VA: 0x7F0F940
	public static bool SafeIsUnityNull(Object obj) { }
}

// Namespace: Sirenix.Utilities
public static class ArrayUtilities // TypeDefIndex: 24872
{
	// Methods

	// RVA: -1 Offset: -1
	public static T[] CreateNewArrayWithAddedElement<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FA708 Offset: 0x44F6708 VA: 0x44FA708
	|-ArrayUtilities.CreateNewArrayWithAddedElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] CreateNewArrayWithInsertedElement<T>(T[] array, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FA9A4 Offset: 0x44F69A4 VA: 0x44FA9A4
	|-ArrayUtilities.CreateNewArrayWithInsertedElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] CreateNewArrayWithRemovedElement<T>(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44FAC74 Offset: 0x44F6C74 VA: 0x44FAC74
	|-ArrayUtilities.CreateNewArrayWithRemovedElement<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
private enum DeepReflection.PathStepType // TypeDefIndex: 24873
{
	// Fields
	public int value__; // 0x0
	public const DeepReflection.PathStepType Member = 0;
	public const DeepReflection.PathStepType WeakListElement = 1;
	public const DeepReflection.PathStepType StrongListElement = 2;
	public const DeepReflection.PathStepType ArrayElement = 3;
}

// Namespace: 
private struct DeepReflection.PathStep // TypeDefIndex: 24874
{
	// Fields
	public readonly DeepReflection.PathStepType StepType; // 0x0
	public readonly MemberInfo Member; // 0x8
	public readonly int ElementIndex; // 0x10
	public readonly Type ElementType; // 0x18
	public readonly MethodInfo StrongListGetItemMethod; // 0x20

	// Methods

	// RVA: 0x7F11BE8 Offset: 0x7F0DBE8 VA: 0x7F11BE8
	public void .ctor(MemberInfo member) { }

	// RVA: 0x7F115E0 Offset: 0x7F0D5E0 VA: 0x7F115E0
	public void .ctor(int elementIndex) { }

	// RVA: 0x7F1145C Offset: 0x7F0D45C VA: 0x7F1145C
	public void .ctor(int elementIndex, Type strongListElementType, bool isArray) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass11_0<TResult> // TypeDefIndex: 24875
{
	// Fields
	public Func<object, object> del; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48662BC Offset: 0x48622BC VA: 0x48662BC
	|-DeepReflection.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateWeakInstanceValueGetter>b__0(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48662C4 Offset: 0x48622C4 VA: 0x48662C4
	|-DeepReflection.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType>.<CreateWeakInstanceValueGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass12_0<TResult> // TypeDefIndex: 24876
{
	// Fields
	public Func<object> slowDelegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866924 Offset: 0x4862924 VA: 0x4866924
	|-DeepReflection.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateValueGetter>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486692C Offset: 0x486292C VA: 0x486692C
	|-DeepReflection.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>.<CreateValueGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass13_0<TTarget, TResult> // TypeDefIndex: 24877
{
	// Fields
	public Func<object, object> slowDelegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866D90 Offset: 0x4862D90 VA: 0x4866D90
	|-DeepReflection.<>c__DisplayClass13_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateValueGetter>b__0(TTarget target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866D98 Offset: 0x4862D98 VA: 0x4866D98
	|-DeepReflection.<>c__DisplayClass13_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateValueGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass14_0<TTarget, TResult> // TypeDefIndex: 24878
{
	// Fields
	public Func<TTarget, TResult> func; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867178 Offset: 0x4863178 VA: 0x4867178
	|-DeepReflection.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <CreateWeakAliasForInstanceGetDelegate1>b__0(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867180 Offset: 0x4863180 VA: 0x4867180
	|-DeepReflection.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateWeakAliasForInstanceGetDelegate1>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass15_0<TTarget, TResult> // TypeDefIndex: 24879
{
	// Fields
	public Func<TTarget, TResult> func; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867440 Offset: 0x4863440 VA: 0x4867440
	|-DeepReflection.<>c__DisplayClass15_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateWeakAliasForInstanceGetDelegate2>b__0(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867448 Offset: 0x4863448 VA: 0x4867448
	|-DeepReflection.<>c__DisplayClass15_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateWeakAliasForInstanceGetDelegate2>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass16_0<TResult> // TypeDefIndex: 24880
{
	// Fields
	public Func<TResult> func; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867724 Offset: 0x4863724 VA: 0x4867724
	|-DeepReflection.<>c__DisplayClass16_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <CreateWeakAliasForStaticGetDelegate>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486772C Offset: 0x486372C VA: 0x486772C
	|-DeepReflection.<>c__DisplayClass16_0<__Il2CppFullySharedGenericType>.<CreateWeakAliasForStaticGetDelegate>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass17_0<TTarget, TArg1> // TypeDefIndex: 24881
{
	// Fields
	public Action<TTarget, TArg1> func; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867CA4 Offset: 0x4863CA4 VA: 0x4867CA4
	|-DeepReflection.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateWeakAliasForInstanceSetDelegate1>b__0(object obj, object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867CAC Offset: 0x4863CAC VA: 0x4867CAC
	|-DeepReflection.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateWeakAliasForInstanceSetDelegate1>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass18_0<TTarget, TArg1> // TypeDefIndex: 24882
{
	// Fields
	public Action<TTarget, TArg1> func; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867F44 Offset: 0x4863F44 VA: 0x4867F44
	|-DeepReflection.<>c__DisplayClass18_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateWeakAliasForInstanceSetDelegate2>b__0(object obj, TArg1 arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867F4C Offset: 0x4863F4C VA: 0x4867F4C
	|-DeepReflection.<>c__DisplayClass18_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateWeakAliasForInstanceSetDelegate2>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass19_0<TArg1> // TypeDefIndex: 24883
{
	// Fields
	public Action<TArg1> func; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4868CD4 Offset: 0x4864CD4 VA: 0x4868CD4
	|-DeepReflection.<>c__DisplayClass19_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateWeakAliasForStaticSetDelegate>b__0(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4868CDC Offset: 0x4864CDC VA: 0x4868CDC
	|-DeepReflection.<>c__DisplayClass19_0<__Il2CppFullySharedGenericType>.<CreateWeakAliasForStaticSetDelegate>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass21_0 // TypeDefIndex: 24884
{
	// Fields
	public List<DeepReflection.PathStep> memberPath; // 0x10

	// Methods

	// RVA: 0x7F10B04 Offset: 0x7F0CB04 VA: 0x7F10B04
	public void .ctor() { }

	// RVA: 0x7F11E78 Offset: 0x7F0DE78 VA: 0x7F11E78
	internal object <CreateSlowDeepStaticValueGetterDelegate>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass22_0 // TypeDefIndex: 24885
{
	// Fields
	public List<DeepReflection.PathStep> memberPath; // 0x10

	// Methods

	// RVA: 0x7F10B0C Offset: 0x7F0CB0C VA: 0x7F10B0C
	public void .ctor() { }

	// RVA: 0x7F11F6C Offset: 0x7F0DF6C VA: 0x7F11F6C
	internal object <CreateSlowDeepInstanceValueGetterDelegate>b__0(object instance) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DeepReflection.<>c__DisplayClass23_0 // TypeDefIndex: 24886
{
	// Fields
	public List<DeepReflection.PathStep> memberPath; // 0x10

	// Methods

	// RVA: 0x7F10B14 Offset: 0x7F0CB14 VA: 0x7F10B14
	public void .ctor() { }

	// RVA: 0x7F12060 Offset: 0x7F0E060 VA: 0x7F12060
	internal void <CreateSlowDeepInstanceValueSetterDelegate>b__0(object instance, object arg) { }
}

// Namespace: Sirenix.Utilities
public static class DeepReflection // TypeDefIndex: 24887
{
	// Fields
	private static MethodInfo WeakListGetItem; // 0x0
	private static MethodInfo WeakListSetItem; // 0x8
	private static MethodInfo CreateWeakAliasForInstanceGetDelegate1MethodInfo; // 0x10
	private static MethodInfo CreateWeakAliasForInstanceGetDelegate2MethodInfo; // 0x18
	private static MethodInfo CreateWeakAliasForStaticGetDelegateMethodInfo; // 0x20
	private static MethodInfo CreateWeakAliasForInstanceSetDelegate1MethodInfo; // 0x28

	// Methods

	// RVA: 0x7F0FA3C Offset: 0x7F0BA3C VA: 0x7F0FA3C
	public static Func<object> CreateWeakStaticValueGetter(Type rootType, Type resultType, string path, bool allowEmit = True) { }

	// RVA: 0x7F10690 Offset: 0x7F0C690 VA: 0x7F10690
	public static Func<object, object> CreateWeakInstanceValueGetter(Type rootType, Type resultType, string path, bool allowEmit = True) { }

	// RVA: 0x7F108A4 Offset: 0x7F0C8A4 VA: 0x7F108A4
	public static Action<object, object> CreateWeakInstanceValueSetter(Type rootType, Type argType, string path, bool allowEmit = True) { }

	// RVA: -1 Offset: -1
	public static Func<object, TResult> CreateWeakInstanceValueGetter<TResult>(Type rootType, string path, bool allowEmit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456D374 Offset: 0x4569374 VA: 0x456D374
	|-DeepReflection.CreateWeakInstanceValueGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<TResult> CreateValueGetter<TResult>(Type rootType, string path, bool allowEmit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456CD5C Offset: 0x4568D5C VA: 0x456CD5C
	|-DeepReflection.CreateValueGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<TTarget, TResult> CreateValueGetter<TTarget, TResult>(string path, bool allowEmit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456CB9C Offset: 0x4568B9C VA: 0x456CB9C
	|-DeepReflection.CreateValueGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Func<object, object> CreateWeakAliasForInstanceGetDelegate1<TTarget, TResult>(Func<TTarget, TResult> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456CF64 Offset: 0x4568F64 VA: 0x456CF64
	|-DeepReflection.CreateWeakAliasForInstanceGetDelegate1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Func<object, TResult> CreateWeakAliasForInstanceGetDelegate2<TTarget, TResult>(Func<TTarget, TResult> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456D014 Offset: 0x4569014 VA: 0x456D014
	|-DeepReflection.CreateWeakAliasForInstanceGetDelegate2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Func<object> CreateWeakAliasForStaticGetDelegate<TResult>(Func<TResult> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456D214 Offset: 0x4569214 VA: 0x456D214
	|-DeepReflection.CreateWeakAliasForStaticGetDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Action<object, object> CreateWeakAliasForInstanceSetDelegate1<TTarget, TArg1>(Action<TTarget, TArg1> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456D0BC Offset: 0x45690BC VA: 0x456D0BC
	|-DeepReflection.CreateWeakAliasForInstanceSetDelegate1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Action<object, TArg1> CreateWeakAliasForInstanceSetDelegate2<TTarget, TArg1>(Action<TTarget, TArg1> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456D16C Offset: 0x456916C VA: 0x456D16C
	|-DeepReflection.CreateWeakAliasForInstanceSetDelegate2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Action<object> CreateWeakAliasForStaticSetDelegate<TArg1>(Action<TArg1> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456D2C4 Offset: 0x45692C4 VA: 0x456D2C4
	|-DeepReflection.CreateWeakAliasForStaticSetDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7F10AB8 Offset: 0x7F0CAB8 VA: 0x7F10AB8
	private static Delegate CreateEmittedDeepValueGetterDelegate(string path, Type rootType, Type resultType, List<DeepReflection.PathStep> memberPath, bool rootIsStatic) { }

	// RVA: 0x7F105D4 Offset: 0x7F0C5D4 VA: 0x7F105D4
	private static Func<object> CreateSlowDeepStaticValueGetterDelegate(List<DeepReflection.PathStep> memberPath) { }

	// RVA: 0x7F107E8 Offset: 0x7F0C7E8 VA: 0x7F107E8
	private static Func<object, object> CreateSlowDeepInstanceValueGetterDelegate(List<DeepReflection.PathStep> memberPath) { }

	// RVA: 0x7F109FC Offset: 0x7F0C9FC VA: 0x7F109FC
	private static Action<object, object> CreateSlowDeepInstanceValueSetterDelegate(List<DeepReflection.PathStep> memberPath) { }

	// RVA: 0x7F10B1C Offset: 0x7F0CB1C VA: 0x7F10B1C
	private static object SlowGetMemberValue(DeepReflection.PathStep step, object instance) { }

	// RVA: 0x7F10F78 Offset: 0x7F0CF78 VA: 0x7F10F78
	private static void SlowSetMemberValue(DeepReflection.PathStep step, object instance, object value) { }

	// RVA: 0x7F0FB94 Offset: 0x7F0BB94 VA: 0x7F0FB94
	private static List<DeepReflection.PathStep> GetMemberPath(Type rootType, ref Type resultType, string path, out bool rootIsStatic, bool isSet) { }

	// RVA: 0x7F11630 Offset: 0x7F0D630 VA: 0x7F11630
	private static MemberInfo GetStepMember(Type owningType, string name, bool expectMethod) { }

	// RVA: 0x7F11C28 Offset: 0x7F0DC28 VA: 0x7F11C28
	private static void .cctor() { }
}

// Namespace: Sirenix.Utilities
[DefaultMember("Item")]
[Serializable]
public class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> // TypeDefIndex: 24888
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
	|-RVA: 0x6025E80 Offset: 0x6021E80 VA: 0x6025E80
	|-DoubleLookupDictionary<object, object, object>..ctor
	|
	|-RVA: 0x60268E8 Offset: 0x60228E8 VA: 0x60268E8
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TFirstKey> firstKeyComparer, IEqualityComparer<TSecondKey> secondKeyComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6025EC8 Offset: 0x6021EC8 VA: 0x6025EC8
	|-DoubleLookupDictionary<object, object, object>..ctor
	|
	|-RVA: 0x6026938 Offset: 0x6022938 VA: 0x6026938
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary<TSecondKey, TValue> get_Item(TFirstKey firstKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6025F00 Offset: 0x6021F00 VA: 0x6025F00
	|-DoubleLookupDictionary<object, object, object>.get_Item
	|
	|-RVA: 0x6026974 Offset: 0x6022974 VA: 0x6026974
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public int InnerCount(TFirstKey firstKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6025FB0 Offset: 0x6021FB0 VA: 0x6025FB0
	|-DoubleLookupDictionary<object, object, object>.InnerCount
	|
	|-RVA: 0x6026B08 Offset: 0x6022B08 VA: 0x6026B08
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InnerCount
	*/

	// RVA: -1 Offset: -1
	public int TotalInnerCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602600C Offset: 0x602200C VA: 0x602600C
	|-DoubleLookupDictionary<object, object, object>.TotalInnerCount
	|
	|-RVA: 0x6026C0C Offset: 0x6022C0C VA: 0x6026C0C
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TotalInnerCount
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKeys(TFirstKey firstKey, TSecondKey secondKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6026154 Offset: 0x6022154 VA: 0x6026154
	|-DoubleLookupDictionary<object, object, object>.ContainsKeys
	|
	|-RVA: 0x6026D9C Offset: 0x6022D9C VA: 0x6026D9C
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKeys
	*/

	// RVA: -1 Offset: -1
	public bool TryGetInnerValue(TFirstKey firstKey, TSecondKey secondKey, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60261BC Offset: 0x60221BC VA: 0x60261BC
	|-DoubleLookupDictionary<object, object, object>.TryGetInnerValue
	|
	|-RVA: 0x6026F1C Offset: 0x6022F1C VA: 0x6026F1C
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetInnerValue
	*/

	// RVA: -1 Offset: -1
	public TValue AddInner(TFirstKey firstKey, TSecondKey secondKey, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602623C Offset: 0x602223C VA: 0x602623C
	|-DoubleLookupDictionary<object, object, object>.AddInner
	|
	|-RVA: 0x60270C4 Offset: 0x60230C4 VA: 0x60270C4
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddInner
	*/

	// RVA: -1 Offset: -1
	public bool RemoveInner(TFirstKey firstKey, TSecondKey secondKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6026354 Offset: 0x6022354 VA: 0x6026354
	|-DoubleLookupDictionary<object, object, object>.RemoveInner
	|
	|-RVA: 0x6027458 Offset: 0x6023458 VA: 0x6027458
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveInner
	*/

	// RVA: -1 Offset: -1
	public void RemoveWhere(Func<TValue, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6026408 Offset: 0x6022408 VA: 0x6026408
	|-DoubleLookupDictionary<object, object, object>.RemoveWhere
	|
	|-RVA: 0x602767C Offset: 0x602367C VA: 0x602767C
	|-DoubleLookupDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveWhere
	*/
}

// Namespace: Sirenix.Utilities
public sealed class WeakValueGetter : MulticastDelegate // TypeDefIndex: 24889
{
	// Methods

	// RVA: 0x7F121BC Offset: 0x7F0E1BC VA: 0x7F121BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F1226C Offset: 0x7F0E26C VA: 0x7F1226C Slot: 13
	public virtual object Invoke(ref object instance) { }

	// RVA: 0x7F12280 Offset: 0x7F0E280 VA: 0x7F12280 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref object instance, AsyncCallback callback, object object) { }

	// RVA: 0x7F122A4 Offset: 0x7F0E2A4 VA: 0x7F122A4 Slot: 15
	public virtual object EndInvoke(ref object instance, IAsyncResult result) { }
}

// Namespace: Sirenix.Utilities
public sealed class WeakValueSetter : MulticastDelegate // TypeDefIndex: 24890
{
	// Methods

	// RVA: 0x7F122C0 Offset: 0x7F0E2C0 VA: 0x7F122C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F12374 Offset: 0x7F0E374 VA: 0x7F12374 Slot: 13
	public virtual void Invoke(ref object instance, object value) { }

	// RVA: 0x7F12388 Offset: 0x7F0E388 VA: 0x7F12388 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref object instance, object value, AsyncCallback callback, object object) { }

	// RVA: 0x7F123B4 Offset: 0x7F0E3B4 VA: 0x7F123B4 Slot: 15
	public virtual void EndInvoke(ref object instance, IAsyncResult result) { }
}

// Namespace: Sirenix.Utilities
public sealed class WeakValueGetter<FieldType> : MulticastDelegate // TypeDefIndex: 24891
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C81C8 Offset: 0x58C41C8 VA: 0x58C81C8
	|-WeakValueGetter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual FieldType Invoke(ref object instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C8278 Offset: 0x58C4278 VA: 0x58C8278
	|-WeakValueGetter<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref object instance, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C828C Offset: 0x58C428C VA: 0x58C828C
	|-WeakValueGetter<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual FieldType EndInvoke(ref object instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C82B0 Offset: 0x58C42B0 VA: 0x58C82B0
	|-WeakValueGetter<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Sirenix.Utilities
public sealed class WeakValueSetter<FieldType> : MulticastDelegate // TypeDefIndex: 24892
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C84D4 Offset: 0x58C44D4 VA: 0x58C84D4
	|-WeakValueSetter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref object instance, FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C8588 Offset: 0x58C4588 VA: 0x58C8588
	|-WeakValueSetter<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref object instance, FieldType value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C859C Offset: 0x58C459C VA: 0x58C859C
	|-WeakValueSetter<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref object instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58C8620 Offset: 0x58C4620 VA: 0x58C8620
	|-WeakValueSetter<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Sirenix.Utilities
public sealed class ValueGetter<InstanceType, FieldType> : MulticastDelegate // TypeDefIndex: 24893
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x574243C Offset: 0x573E43C VA: 0x574243C
	|-ValueGetter<object, IntPtr>..ctor
	|
	|-RVA: 0x5742550 Offset: 0x573E550 VA: 0x5742550
	|-ValueGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual FieldType Invoke(ref InstanceType instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x57424EC Offset: 0x573E4EC VA: 0x57424EC
	|-ValueGetter<object, IntPtr>.Invoke
	|
	|-RVA: 0x5742600 Offset: 0x573E600 VA: 0x5742600
	|-ValueGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InstanceType instance, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5742500 Offset: 0x573E500 VA: 0x5742500
	|-ValueGetter<object, IntPtr>.BeginInvoke
	|
	|-RVA: 0x5742614 Offset: 0x573E614 VA: 0x5742614
	|-ValueGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual FieldType EndInvoke(ref InstanceType instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5742524 Offset: 0x573E524 VA: 0x5742524
	|-ValueGetter<object, IntPtr>.EndInvoke
	|
	|-RVA: 0x5742698 Offset: 0x573E698 VA: 0x5742698
	|-ValueGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Sirenix.Utilities
public sealed class ValueSetter<InstanceType, FieldType> : MulticastDelegate // TypeDefIndex: 24894
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5746178 Offset: 0x5742178 VA: 0x5746178
	|-ValueSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref InstanceType instance, FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x574622C Offset: 0x574222C VA: 0x574622C
	|-ValueSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InstanceType instance, FieldType value, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5746240 Offset: 0x5742240 VA: 0x5746240
	|-ValueSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref InstanceType instance, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5746300 Offset: 0x5742300 VA: 0x5746300
	|-ValueSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass10_0 // TypeDefIndex: 24895
{
	// Fields
	public FieldInfo fieldInfo; // 0x10

	// Methods

	// RVA: 0x7F129C0 Offset: 0x7F0E9C0 VA: 0x7F129C0
	public void .ctor() { }

	// RVA: 0x7F13544 Offset: 0x7F0F544 VA: 0x7F13544
	internal object <CreateWeakInstanceFieldGetter>b__0(ref object classInstance) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass11_0<InstanceType, FieldType> // TypeDefIndex: 24896
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486662C Offset: 0x486262C VA: 0x486662C
	|-EmitUtilities.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateInstanceFieldSetter>b__0(ref InstanceType classInstance, FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866634 Offset: 0x4862634 VA: 0x4866634
	|-EmitUtilities.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateInstanceFieldSetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass12_0<FieldType> // TypeDefIndex: 24897
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866AD4 Offset: 0x4862AD4 VA: 0x4866AD4
	|-EmitUtilities.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4866ADC Offset: 0x4862ADC VA: 0x4866ADC
	|-EmitUtilities.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>.<CreateWeakInstanceFieldSetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass13_0 // TypeDefIndex: 24898
{
	// Fields
	public FieldInfo fieldInfo; // 0x10

	// Methods

	// RVA: 0x7F12BA0 Offset: 0x7F0EBA0 VA: 0x7F12BA0
	public void .ctor() { }

	// RVA: 0x7F1356C Offset: 0x7F0F56C VA: 0x7F1356C
	internal void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, object value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass14_0 // TypeDefIndex: 24899
{
	// Fields
	public PropertyInfo propertyInfo; // 0x10

	// Methods

	// RVA: 0x7F12E14 Offset: 0x7F0EE14 VA: 0x7F12E14
	public void .ctor() { }

	// RVA: 0x7F1358C Offset: 0x7F0F58C VA: 0x7F1358C
	internal object <CreateWeakInstancePropertyGetter>b__0(ref object classInstance) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass15_0 // TypeDefIndex: 24900
{
	// Fields
	public PropertyInfo propertyInfo; // 0x10

	// Methods

	// RVA: 0x7F13050 Offset: 0x7F0F050 VA: 0x7F13050
	public void .ctor() { }

	// RVA: 0x7F135B8 Offset: 0x7F0F5B8 VA: 0x7F135B8
	internal void <CreateWeakInstancePropertySetter>b__0(ref object classInstance, object value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass16_0<PropType> // TypeDefIndex: 24901
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48678A4 Offset: 0x48638A4 VA: 0x48678A4
	|-EmitUtilities.<>c__DisplayClass16_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateStaticPropertySetter>b__0(PropType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48678AC Offset: 0x48638AC VA: 0x48678AC
	|-EmitUtilities.<>c__DisplayClass16_0<__Il2CppFullySharedGenericType>.<CreateStaticPropertySetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass17_0<PropType> // TypeDefIndex: 24902
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867AD8 Offset: 0x4863AD8 VA: 0x4867AD8
	|-EmitUtilities.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal PropType <CreateStaticPropertyGetter>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4867AE0 Offset: 0x4863AE0 VA: 0x4867AE0
	|-EmitUtilities.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType>.<CreateStaticPropertyGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass18_0<InstanceType, PropType> // TypeDefIndex: 24903
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4868334 Offset: 0x4864334 VA: 0x4868334
	|-EmitUtilities.<>c__DisplayClass18_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateInstancePropertySetter>b__0(ref InstanceType classInstance, PropType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486833C Offset: 0x486433C VA: 0x486833C
	|-EmitUtilities.<>c__DisplayClass18_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateInstancePropertySetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass19_0<InstanceType, PropType> // TypeDefIndex: 24904
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48696EC Offset: 0x48656EC VA: 0x48696EC
	|-EmitUtilities.<>c__DisplayClass19_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal PropType <CreateInstancePropertyGetter>b__0(ref InstanceType classInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48696F4 Offset: 0x48656F4 VA: 0x48696F4
	|-EmitUtilities.<>c__DisplayClass19_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateInstancePropertyGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass22_0<TArg1> // TypeDefIndex: 24905
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486A8D8 Offset: 0x48668D8 VA: 0x486A8D8
	|-EmitUtilities.<>c__DisplayClass22_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486A8E0 Offset: 0x48668E0 VA: 0x486A8E0
	|-EmitUtilities.<>c__DisplayClass22_0<__Il2CppFullySharedGenericType>.<CreateWeakInstanceMethodCaller>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass23_0 // TypeDefIndex: 24906
{
	// Fields
	public MethodInfo methodInfo; // 0x10

	// Methods

	// RVA: 0x7F13488 Offset: 0x7F0F488 VA: 0x7F13488
	public void .ctor() { }

	// RVA: 0x7F135E4 Offset: 0x7F0F5E4 VA: 0x7F135E4
	internal void <CreateWeakInstanceMethodCaller>b__0(object classInstance) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass24_0<TResult, TArg1> // TypeDefIndex: 24907
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C3C8 Offset: 0x48683C8 VA: 0x486C3C8
	|-EmitUtilities.<>c__DisplayClass24_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C3D0 Offset: 0x48683D0 VA: 0x486C3D0
	|-EmitUtilities.<>c__DisplayClass24_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateWeakInstanceMethodCaller>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass25_0<TResult> // TypeDefIndex: 24908
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C674 Offset: 0x4868674 VA: 0x486C674
	|-EmitUtilities.<>c__DisplayClass25_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486C67C Offset: 0x486867C VA: 0x486C67C
	|-EmitUtilities.<>c__DisplayClass25_0<__Il2CppFullySharedGenericType>.<CreateWeakInstanceMethodCallerFunc>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass26_0<TArg, TResult> // TypeDefIndex: 24909
{
	// Fields
	public MethodInfo methodInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486CA50 Offset: 0x4868A50 VA: 0x486CA50
	|-EmitUtilities.<>c__DisplayClass26_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486CA58 Offset: 0x4868A58 VA: 0x486CA58
	|-EmitUtilities.<>c__DisplayClass26_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateWeakInstanceMethodCallerFunc>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass4_0<FieldType> // TypeDefIndex: 24910
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545A0C0 Offset: 0x54560C0 VA: 0x545A0C0
	|-EmitUtilities.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal FieldType <CreateStaticFieldGetter>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545A0C8 Offset: 0x54560C8 VA: 0x545A0C8
	|-EmitUtilities.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>.<CreateStaticFieldGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass4_1<FieldType> // TypeDefIndex: 24911
{
	// Fields
	public FieldType value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545A644 Offset: 0x5456644 VA: 0x545A644
	|-EmitUtilities.<>c__DisplayClass4_1<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal FieldType <CreateStaticFieldGetter>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545A64C Offset: 0x545664C VA: 0x545A64C
	|-EmitUtilities.<>c__DisplayClass4_1<__Il2CppFullySharedGenericType>.<CreateStaticFieldGetter>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass5_0 // TypeDefIndex: 24912
{
	// Fields
	public FieldInfo fieldInfo; // 0x10

	// Methods

	// RVA: 0x7F12658 Offset: 0x7F0E658 VA: 0x7F12658
	public void .ctor() { }

	// RVA: 0x7F13604 Offset: 0x7F0F604 VA: 0x7F13604
	internal object <CreateWeakStaticFieldGetter>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass6_0<FieldType> // TypeDefIndex: 24913
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545DDD0 Offset: 0x5459DD0 VA: 0x545DDD0
	|-EmitUtilities.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateStaticFieldSetter>b__0(FieldType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x545DDD8 Offset: 0x5459DD8 VA: 0x545DDD8
	|-EmitUtilities.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>.<CreateStaticFieldSetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass7_0 // TypeDefIndex: 24914
{
	// Fields
	public FieldInfo fieldInfo; // 0x10

	// Methods

	// RVA: 0x7F127E0 Offset: 0x7F0E7E0 VA: 0x7F127E0
	public void .ctor() { }

	// RVA: 0x7F1362C Offset: 0x7F0F62C VA: 0x7F1362C
	internal void <CreateWeakStaticFieldSetter>b__0(object value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass8_0<InstanceType, FieldType> // TypeDefIndex: 24915
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546998C Offset: 0x546598C VA: 0x546998C
	|-EmitUtilities.<>c__DisplayClass8_0<object, IntPtr>..ctor
	|
	|-RVA: 0x5469B30 Offset: 0x5465B30 VA: 0x5469B30
	|-EmitUtilities.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal FieldType <CreateInstanceFieldGetter>b__0(ref InstanceType classInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5469994 Offset: 0x5465994 VA: 0x5469994
	|-EmitUtilities.<>c__DisplayClass8_0<object, IntPtr>.<CreateInstanceFieldGetter>b__0
	|
	|-RVA: 0x5469B38 Offset: 0x5465B38 VA: 0x5469B38
	|-EmitUtilities.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateInstanceFieldGetter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class EmitUtilities.<>c__DisplayClass9_0<FieldType> // TypeDefIndex: 24916
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B2DC Offset: 0x54672DC VA: 0x546B2DC
	|-EmitUtilities.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal FieldType <CreateWeakInstanceFieldGetter>b__0(ref object classInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x546B2E4 Offset: 0x54672E4 VA: 0x546B2E4
	|-EmitUtilities.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>.<CreateWeakInstanceFieldGetter>b__0
	*/
}

// Namespace: Sirenix.Utilities
public static class EmitUtilities // TypeDefIndex: 24917
{
	// Fields
	private static Assembly EngineAssembly; // 0x0

	// Properties
	public static bool CanEmit { get; }

	// Methods

	// RVA: 0x7F123D0 Offset: 0x7F0E3D0 VA: 0x7F123D0
	public static bool get_CanEmit() { }

	// RVA: 0x7F123D8 Offset: 0x7F0E3D8 VA: 0x7F123D8
	private static bool EmitIsIllegalForMember(MemberInfo member) { }

	// RVA: -1 Offset: -1
	public static Func<FieldType> CreateStaticFieldGetter<FieldType>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457A294 Offset: 0x4576294 VA: 0x457A294
	|-EmitUtilities.CreateStaticFieldGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7F124D8 Offset: 0x7F0E4D8 VA: 0x7F124D8
	public static Func<object> CreateWeakStaticFieldGetter(FieldInfo fieldInfo) { }

	// RVA: -1 Offset: -1
	public static Action<FieldType> CreateStaticFieldSetter<FieldType>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457A530 Offset: 0x4576530 VA: 0x457A530
	|-EmitUtilities.CreateStaticFieldSetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7F12660 Offset: 0x7F0E660 VA: 0x7F12660
	public static Action<object> CreateWeakStaticFieldSetter(FieldInfo fieldInfo) { }

	// RVA: -1 Offset: -1
	public static ValueGetter<InstanceType, FieldType> CreateInstanceFieldGetter<InstanceType, FieldType>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4579484 Offset: 0x4575484 VA: 0x4579484
	|-EmitUtilities.CreateInstanceFieldGetter<object, IntPtr>
	|
	|-RVA: 0x45795E8 Offset: 0x45755E8 VA: 0x45795E8
	|-EmitUtilities.CreateInstanceFieldGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static WeakValueGetter<FieldType> CreateWeakInstanceFieldGetter<FieldType>(Type instanceType, FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457AAD0 Offset: 0x4576AD0 VA: 0x457AAD0
	|-EmitUtilities.CreateWeakInstanceFieldGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7F127E8 Offset: 0x7F0E7E8 VA: 0x7F127E8
	public static WeakValueGetter CreateWeakInstanceFieldGetter(Type instanceType, FieldInfo fieldInfo) { }

	// RVA: -1 Offset: -1
	public static ValueSetter<InstanceType, FieldType> CreateInstanceFieldSetter<InstanceType, FieldType>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4579754 Offset: 0x4575754 VA: 0x4579754
	|-EmitUtilities.CreateInstanceFieldSetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static WeakValueSetter<FieldType> CreateWeakInstanceFieldSetter<FieldType>(Type instanceType, FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457ACA0 Offset: 0x4576CA0 VA: 0x457ACA0
	|-EmitUtilities.CreateWeakInstanceFieldSetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7F129C8 Offset: 0x7F0E9C8 VA: 0x7F129C8
	public static WeakValueSetter CreateWeakInstanceFieldSetter(Type instanceType, FieldInfo fieldInfo) { }

	// RVA: 0x7F12BA8 Offset: 0x7F0EBA8 VA: 0x7F12BA8
	public static WeakValueGetter CreateWeakInstancePropertyGetter(Type instanceType, PropertyInfo propertyInfo) { }

	// RVA: 0x7F12E1C Offset: 0x7F0EE1C VA: 0x7F12E1C
	public static WeakValueSetter CreateWeakInstancePropertySetter(Type instanceType, PropertyInfo propertyInfo) { }

	// RVA: -1 Offset: -1
	public static Action<PropType> CreateStaticPropertySetter<PropType>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457A8D0 Offset: 0x45768D0 VA: 0x457A8D0
	|-EmitUtilities.CreateStaticPropertySetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<PropType> CreateStaticPropertyGetter<PropType>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457A6D0 Offset: 0x45766D0 VA: 0x457A6D0
	|-EmitUtilities.CreateStaticPropertyGetter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ValueSetter<InstanceType, PropType> CreateInstancePropertySetter<InstanceType, PropType>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4579EDC Offset: 0x4575EDC VA: 0x4579EDC
	|-EmitUtilities.CreateInstancePropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ValueGetter<InstanceType, PropType> CreateInstancePropertyGetter<InstanceType, PropType>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4579CDC Offset: 0x4575CDC VA: 0x4579CDC
	|-EmitUtilities.CreateInstancePropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<InstanceType, ReturnType> CreateMethodReturner<InstanceType, ReturnType>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457A0DC Offset: 0x45760DC VA: 0x457A0DC
	|-EmitUtilities.CreateMethodReturner<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7F13058 Offset: 0x7F0F058 VA: 0x7F13058
	public static Action CreateStaticMethodCaller(MethodInfo methodInfo) { }

	// RVA: -1 Offset: -1
	public static Action<object, TArg1> CreateWeakInstanceMethodCaller<TArg1>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457AE70 Offset: 0x4576E70 VA: 0x457AE70
	|-EmitUtilities.CreateWeakInstanceMethodCaller<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7F13260 Offset: 0x7F0F260 VA: 0x7F13260
	public static Action<object> CreateWeakInstanceMethodCaller(MethodInfo methodInfo) { }

	// RVA: -1 Offset: -1
	public static Func<object, TArg1, TResult> CreateWeakInstanceMethodCaller<TResult, TArg1>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457B238 Offset: 0x4577238 VA: 0x457B238
	|-EmitUtilities.CreateWeakInstanceMethodCaller<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<object, TResult> CreateWeakInstanceMethodCallerFunc<TResult>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457B740 Offset: 0x4577740 VA: 0x457B740
	|-EmitUtilities.CreateWeakInstanceMethodCallerFunc<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Func<object, TArg, TResult> CreateWeakInstanceMethodCallerFunc<TArg, TResult>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x457BAFC Offset: 0x4577AFC VA: 0x457BAFC
	|-EmitUtilities.CreateWeakInstanceMethodCallerFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Action<InstanceType> CreateInstanceMethodCaller<InstanceType>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45798C0 Offset: 0x45758C0 VA: 0x45798C0
	|-EmitUtilities.CreateInstanceMethodCaller<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Action<InstanceType, Arg1> CreateInstanceMethodCaller<InstanceType, Arg1>(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4579ACC Offset: 0x4575ACC VA: 0x4579ACC
	|-EmitUtilities.CreateInstanceMethodCaller<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x7F13490 Offset: 0x7F0F490 VA: 0x7F13490
	private static void .cctor() { }
}

// Namespace: Sirenix.Utilities
public static class Flags // TypeDefIndex: 24918
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

// Namespace: Sirenix.Utilities
public interface IGlobalConfigEvents // TypeDefIndex: 24919
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnConfigAutoCreated();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnConfigInstanceFirstAccessed();
}

// Namespace: Sirenix.Utilities
public abstract class GlobalConfig<T> : ScriptableObject, IGlobalConfigEvents // TypeDefIndex: 24920
{
	// Fields
	private static GlobalConfigAttribute configAttribute; // 0x0
	private static T instance; // 0x0

	// Properties
	public static GlobalConfigAttribute ConfigAttribute { get; }
	public static bool HasInstanceLoaded { get; }
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static GlobalConfigAttribute get_ConfigAttribute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C224 Offset: 0x4908224 VA: 0x490C224
	|-GlobalConfig<object>.get_ConfigAttribute
	*/

	// RVA: -1 Offset: -1
	public static bool get_HasInstanceLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C4D0 Offset: 0x49084D0 VA: 0x490C4D0
	|-GlobalConfig<object>.get_HasInstanceLoaded
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C4F4 Offset: 0x49084F4 VA: 0x490C4F4
	|-GlobalConfig<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	public static void LoadInstanceIfAssetExists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C55C Offset: 0x490855C VA: 0x490C55C
	|-GlobalConfig<object>.LoadInstanceIfAssetExists
	*/

	// RVA: -1 Offset: -1
	public void OpenInEditor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C5C4 Offset: 0x49085C4 VA: 0x490C5C4
	|-GlobalConfig<object>.OpenInEditor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void OnConfigInstanceFirstAccessed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C62C Offset: 0x490862C VA: 0x490C62C
	|-GlobalConfig<object>.OnConfigInstanceFirstAccessed
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnConfigAutoCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C630 Offset: 0x4908630 VA: 0x490C630
	|-GlobalConfig<object>.OnConfigAutoCreated
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void Sirenix.Utilities.IGlobalConfigEvents.OnConfigAutoCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C634 Offset: 0x4908634 VA: 0x490C634
	|-GlobalConfig<object>.Sirenix.Utilities.IGlobalConfigEvents.OnConfigAutoCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Sirenix.Utilities.IGlobalConfigEvents.OnConfigInstanceFirstAccessed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C640 Offset: 0x4908640 VA: 0x490C640
	|-GlobalConfig<object>.Sirenix.Utilities.IGlobalConfigEvents.OnConfigInstanceFirstAccessed
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C64C Offset: 0x490864C VA: 0x490C64C
	|-GlobalConfig<object>..ctor
	*/
}

// Namespace: Sirenix.Utilities
public static class GlobalConfigUtility<T> // TypeDefIndex: 24921
{
	// Fields
	private static T instance; // 0x0

	// Properties
	public static bool HasInstanceLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_HasInstanceLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490BD44 Offset: 0x4907D44 VA: 0x490BD44
	|-GlobalConfigUtility<object>.get_HasInstanceLoaded
	*/

	// RVA: -1 Offset: -1
	public static T GetInstance(string defaultAssetFolderPath, string defaultFileNameWithoutExtension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490BDD0 Offset: 0x4907DD0 VA: 0x490BDD0
	|-GlobalConfigUtility<object>.GetInstance
	*/

	// RVA: -1 Offset: -1
	internal static void LoadInstanceIfAssetExists(string assetPath, string defaultFileNameWithoutExtension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x490C040 Offset: 0x4908040 VA: 0x490C040
	|-GlobalConfigUtility<object>.LoadInstanceIfAssetExists
	*/
}

// Namespace: Sirenix.Utilities
[Usage(4)]
public class GlobalConfigAttribute : Attribute // TypeDefIndex: 24922
{
	// Fields
	private string assetPath; // 0x10
	[CompilerGenerated]
	private bool <UseAsset>k__BackingField; // 0x18

	// Properties
	[Obsolete("It's a bit more complicated than that as it's not always possible to know the full path, so try and make due without it if you can, only using the AssetDatabase.")]
	[EditorBrowsable(1)]
	public string FullPath { get; }
	public string AssetPath { get; }
	internal string AssetPathWithAssetsPrefix { get; }
	internal string AssetPathWithoutAssetsPrefix { get; }
	public string ResourcesPath { get; }
	[Obsolete("This option is obsolete and will have no effect - a GlobalConfig will always have an asset generated now; use a POCO singleton or a ScriptableSingleton<T> instead. Asset-less config objects that are recreated every reload cause UnityEngine.Object leaks.", True)]
	[EditorBrowsable(1)]
	public bool UseAsset { get; set; }
	public bool IsInResourcesFolder { get; }

	// Methods

	// RVA: 0x7F13650 Offset: 0x7F0F650 VA: 0x7F13650
	public string get_FullPath() { }

	// RVA: 0x7F136D8 Offset: 0x7F0F6D8 VA: 0x7F136D8
	public string get_AssetPath() { }

	// RVA: 0x7F137F8 Offset: 0x7F0F7F8 VA: 0x7F137F8
	internal string get_AssetPathWithAssetsPrefix() { }

	// RVA: 0x7F13878 Offset: 0x7F0F878 VA: 0x7F13878
	internal string get_AssetPathWithoutAssetsPrefix() { }

	// RVA: 0x7F13900 Offset: 0x7F0F900 VA: 0x7F13900
	public string get_ResourcesPath() { }

	[CompilerGenerated]
	// RVA: 0x7F13A18 Offset: 0x7F0FA18 VA: 0x7F13A18
	public bool get_UseAsset() { }

	[CompilerGenerated]
	// RVA: 0x7F13A20 Offset: 0x7F0FA20 VA: 0x7F13A20
	public void set_UseAsset(bool value) { }

	// RVA: 0x7F139B0 Offset: 0x7F0F9B0 VA: 0x7F139B0
	public bool get_IsInResourcesFolder() { }

	// RVA: 0x7F13A2C Offset: 0x7F0FA2C VA: 0x7F13A2C
	public void .ctor() { }

	// RVA: 0x7F13A88 Offset: 0x7F0FA88 VA: 0x7F13A88
	public void .ctor(string assetPath) { }
}

// Namespace: 
internal enum GUILayoutOptions.GUILayoutOptionType // TypeDefIndex: 24923
{
	// Fields
	public int value__; // 0x0
	public const GUILayoutOptions.GUILayoutOptionType Width = 0;
	public const GUILayoutOptions.GUILayoutOptionType Height = 1;
	public const GUILayoutOptions.GUILayoutOptionType MinWidth = 2;
	public const GUILayoutOptions.GUILayoutOptionType MaxHeight = 3;
	public const GUILayoutOptions.GUILayoutOptionType MaxWidth = 4;
	public const GUILayoutOptions.GUILayoutOptionType MinHeight = 5;
	public const GUILayoutOptions.GUILayoutOptionType ExpandHeight = 6;
	public const GUILayoutOptions.GUILayoutOptionType ExpandWidth = 7;
}

// Namespace: 
public sealed class GUILayoutOptions.GUILayoutOptionsInstance : IEquatable<GUILayoutOptions.GUILayoutOptionsInstance> // TypeDefIndex: 24924
{
	// Fields
	private float value; // 0x10
	internal GUILayoutOptions.GUILayoutOptionsInstance Parent; // 0x18
	internal GUILayoutOptions.GUILayoutOptionType GUILayoutOptionType; // 0x20

	// Methods

	// RVA: 0x7F14190 Offset: 0x7F10190 VA: 0x7F14190
	private GUILayoutOption[] GetCachedOptions() { }

	// RVA: 0x7F1454C Offset: 0x7F1054C VA: 0x7F1454C
	public static GUILayoutOption[] op_Implicit(GUILayoutOptions.GUILayoutOptionsInstance options) { }

	// RVA: 0x7F14360 Offset: 0x7F10360 VA: 0x7F14360
	private GUILayoutOption[] CreateOptionsArary() { }

	// RVA: 0x7F14294 Offset: 0x7F10294 VA: 0x7F14294
	private GUILayoutOptions.GUILayoutOptionsInstance Clone() { }

	// RVA: 0x7F13CB4 Offset: 0x7F0FCB4 VA: 0x7F13CB4
	internal void .ctor() { }

	// RVA: 0x7F1455C Offset: 0x7F1055C VA: 0x7F1455C
	public GUILayoutOptions.GUILayoutOptionsInstance Width(float width) { }

	// RVA: 0x7F145F8 Offset: 0x7F105F8 VA: 0x7F145F8
	public GUILayoutOptions.GUILayoutOptionsInstance Height(float height) { }

	// RVA: 0x7F14698 Offset: 0x7F10698 VA: 0x7F14698
	public GUILayoutOptions.GUILayoutOptionsInstance MaxHeight(float height) { }

	// RVA: 0x7F14738 Offset: 0x7F10738 VA: 0x7F14738
	public GUILayoutOptions.GUILayoutOptionsInstance MaxWidth(float width) { }

	// RVA: 0x7F147D8 Offset: 0x7F107D8 VA: 0x7F147D8
	public GUILayoutOptions.GUILayoutOptionsInstance MinHeight(float height) { }

	// RVA: 0x7F14878 Offset: 0x7F10878 VA: 0x7F14878
	public GUILayoutOptions.GUILayoutOptionsInstance MinWidth(float width) { }

	// RVA: 0x7F14918 Offset: 0x7F10918 VA: 0x7F14918
	public GUILayoutOptions.GUILayoutOptionsInstance ExpandHeight(bool expand = True) { }

	// RVA: 0x7F149C0 Offset: 0x7F109C0 VA: 0x7F149C0
	public GUILayoutOptions.GUILayoutOptionsInstance ExpandWidth(bool expand = True) { }

	// RVA: 0x7F13D4C Offset: 0x7F0FD4C VA: 0x7F13D4C
	internal void SetValue(GUILayoutOptions.GUILayoutOptionType type, float value) { }

	// RVA: 0x7F140D8 Offset: 0x7F100D8 VA: 0x7F140D8
	internal void SetValue(GUILayoutOptions.GUILayoutOptionType type, bool value) { }

	// RVA: 0x7F14A68 Offset: 0x7F10A68 VA: 0x7F14A68 Slot: 4
	public bool Equals(GUILayoutOptions.GUILayoutOptionsInstance other) { }

	// RVA: 0x7F14AC8 Offset: 0x7F10AC8 VA: 0x7F14AC8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Sirenix.Utilities
public static class GUILayoutOptions // TypeDefIndex: 24925
{
	// Fields
	private static int CurrentCacheIndex; // 0x0
	private static readonly GUILayoutOptions.GUILayoutOptionsInstance[] GUILayoutOptionsInstanceCache; // 0x8
	private static readonly Dictionary<GUILayoutOptions.GUILayoutOptionsInstance, GUILayoutOption[]> GUILayoutOptionsCache; // 0x10
	public static readonly GUILayoutOption[] EmptyGUIOptions; // 0x18

	// Methods

	// RVA: 0x7F13AB8 Offset: 0x7F0FAB8 VA: 0x7F13AB8
	private static void .cctor() { }

	// RVA: 0x7F13CBC Offset: 0x7F0FCBC VA: 0x7F13CBC
	public static GUILayoutOptions.GUILayoutOptionsInstance Width(float width) { }

	// RVA: 0x7F13D58 Offset: 0x7F0FD58 VA: 0x7F13D58
	public static GUILayoutOptions.GUILayoutOptionsInstance Height(float height) { }

	// RVA: 0x7F13DEC Offset: 0x7F0FDEC VA: 0x7F13DEC
	public static GUILayoutOptions.GUILayoutOptionsInstance MaxHeight(float height) { }

	// RVA: 0x7F13E80 Offset: 0x7F0FE80 VA: 0x7F13E80
	public static GUILayoutOptions.GUILayoutOptionsInstance MaxWidth(float width) { }

	// RVA: 0x7F13F14 Offset: 0x7F0FF14 VA: 0x7F13F14
	public static GUILayoutOptions.GUILayoutOptionsInstance MinWidth(float width) { }

	// RVA: 0x7F13FA8 Offset: 0x7F0FFA8 VA: 0x7F13FA8
	public static GUILayoutOptions.GUILayoutOptionsInstance MinHeight(float height) { }

	// RVA: 0x7F1403C Offset: 0x7F1003C VA: 0x7F1403C
	public static GUILayoutOptions.GUILayoutOptionsInstance ExpandHeight(bool expand = True) { }

	// RVA: 0x7F140F4 Offset: 0x7F100F4 VA: 0x7F140F4
	public static GUILayoutOptions.GUILayoutOptionsInstance ExpandWidth(bool expand = True) { }
}

// Namespace: Sirenix.Utilities
[Serializable]
public class ImmutableHashSet<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 24926
{
	// Fields
	private readonly HashSet<T> hashSet; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(HashSet<T> hashSet) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993274 Offset: 0x498F274 VA: 0x4993274
	|-ImmutableHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49932A4 Offset: 0x498F2A4 VA: 0x49932A4
	|-ImmutableHashSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993374 Offset: 0x498F374 VA: 0x4993374
	|-ImmutableHashSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993420 Offset: 0x498F420 VA: 0x4993420
	|-ImmutableHashSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Sirenix.Utilities
public interface IImmutableList : IList, ICollection, IEnumerable // TypeDefIndex: 24927
{}

// Namespace: Sirenix.Utilities
[DefaultMember("Item")]
public interface IImmutableList<T> : IImmutableList, IList, ICollection, IEnumerable, IList<T>, ICollection<T>, IEnumerable<T> // TypeDefIndex: 24928
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
private sealed class ImmutableList.<System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25 : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 24929
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
	// RVA: 0x7F15394 Offset: 0x7F11394 VA: 0x7F15394
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x7F15760 Offset: 0x7F11760 VA: 0x7F15760 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F1577C Offset: 0x7F1177C VA: 0x7F1577C Slot: 6
	private bool MoveNext() { }

	// RVA: 0x7F15A14 Offset: 0x7F11A14 VA: 0x7F15A14
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x7F15AD0 Offset: 0x7F11AD0 VA: 0x7F15AD0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x7F15AD8 Offset: 0x7F11AD8 VA: 0x7F15AD8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x7F15B10 Offset: 0x7F11B10 VA: 0x7F15B10 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Sirenix.Utilities
[DefaultMember("Item")]
[Serializable]
public sealed class ImmutableList : IImmutableList<object>, IImmutableList, IList, ICollection, IEnumerable, IList<object>, ICollection<object>, IEnumerable<object> // TypeDefIndex: 24930
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

	// RVA: 0x7F14B60 Offset: 0x7F10B60 VA: 0x7F14B60
	public void .ctor(IList innerList) { }

	// RVA: 0x7F14BDC Offset: 0x7F10BDC VA: 0x7F14BDC Slot: 26
	public int get_Count() { }

	// RVA: 0x7F14C80 Offset: 0x7F10C80 VA: 0x7F14C80 Slot: 11
	public bool get_IsFixedSize() { }

	// RVA: 0x7F14C88 Offset: 0x7F10C88 VA: 0x7F14C88 Slot: 27
	public bool get_IsReadOnly() { }

	// RVA: 0x7F14C90 Offset: 0x7F10C90 VA: 0x7F14C90 Slot: 19
	public bool get_IsSynchronized() { }

	// RVA: 0x7F14D34 Offset: 0x7F10D34 VA: 0x7F14D34 Slot: 18
	public object get_SyncRoot() { }

	// RVA: 0x7F14DD8 Offset: 0x7F10DD8 VA: 0x7F14DD8 Slot: 5
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x7F14E80 Offset: 0x7F10E80 VA: 0x7F14E80 Slot: 6
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x7F14ECC Offset: 0x7F10ECC VA: 0x7F14ECC Slot: 21
	private object System.Collections.Generic.IList<System.Object>.get_Item(int index) { }

	// RVA: 0x7F14F74 Offset: 0x7F10F74 VA: 0x7F14F74 Slot: 22
	private void System.Collections.Generic.IList<System.Object>.set_Item(int index, object value) { }

	// RVA: 0x7F14FC0 Offset: 0x7F10FC0 VA: 0x7F14FC0 Slot: 4
	public object get_Item(int index) { }

	// RVA: 0x7F15068 Offset: 0x7F11068 VA: 0x7F15068 Slot: 30
	public bool Contains(object value) { }

	// RVA: 0x7F15114 Offset: 0x7F11114 VA: 0x7F15114 Slot: 31
	public void CopyTo(object[] array, int arrayIndex) { }

	// RVA: 0x7F151CC Offset: 0x7F111CC VA: 0x7F151CC Slot: 16
	public void CopyTo(Array array, int index) { }

	// RVA: 0x7F15284 Offset: 0x7F11284 VA: 0x7F15284
	public IEnumerator GetEnumerator() { }

	// RVA: 0x7F15324 Offset: 0x7F11324 VA: 0x7F15324 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(ImmutableList.<System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25))]
	// RVA: 0x7F15328 Offset: 0x7F11328 VA: 0x7F15328 Slot: 33
	private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

	// RVA: 0x7F153BC Offset: 0x7F113BC VA: 0x7F153BC Slot: 7
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x7F15408 Offset: 0x7F11408 VA: 0x7F15408 Slot: 9
	private void System.Collections.IList.Clear() { }

	// RVA: 0x7F15454 Offset: 0x7F11454 VA: 0x7F15454 Slot: 13
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x7F154A0 Offset: 0x7F114A0 VA: 0x7F154A0 Slot: 14
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x7F154EC Offset: 0x7F114EC VA: 0x7F154EC Slot: 15
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x7F15538 Offset: 0x7F11538 VA: 0x7F15538 Slot: 23
	public int IndexOf(object value) { }

	// RVA: 0x7F155E4 Offset: 0x7F115E4 VA: 0x7F155E4 Slot: 25
	private void System.Collections.Generic.IList<System.Object>.RemoveAt(int index) { }

	// RVA: 0x7F15630 Offset: 0x7F11630 VA: 0x7F15630 Slot: 24
	private void System.Collections.Generic.IList<System.Object>.Insert(int index, object item) { }

	// RVA: 0x7F1567C Offset: 0x7F1167C VA: 0x7F1567C Slot: 28
	private void System.Collections.Generic.ICollection<System.Object>.Add(object item) { }

	// RVA: 0x7F156C8 Offset: 0x7F116C8 VA: 0x7F156C8 Slot: 29
	private void System.Collections.Generic.ICollection<System.Object>.Clear() { }

	// RVA: 0x7F15714 Offset: 0x7F11714 VA: 0x7F15714 Slot: 32
	private bool System.Collections.Generic.ICollection<System.Object>.Remove(object item) { }
}

// Namespace: Sirenix.Utilities
[DefaultMember("Item")]
[Serializable]
public sealed class ImmutableList<T> : IImmutableList<T>, IImmutableList, IList, ICollection, IEnumerable, IList<T>, ICollection<T>, IEnumerable<T> // TypeDefIndex: 24931
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
	|-RVA: 0x49943A8 Offset: 0x49903A8 VA: 0x49943A8
	|-ImmutableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499441C Offset: 0x499041C VA: 0x499441C
	|-ImmutableList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49944A4 Offset: 0x49904A4 VA: 0x49944A4
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49944AC Offset: 0x49904AC VA: 0x49944AC
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49944B4 Offset: 0x49904B4 VA: 0x49944B4
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49944BC Offset: 0x49904BC VA: 0x49944BC
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49944C4 Offset: 0x49904C4 VA: 0x49944C4
	|-ImmutableList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49944CC Offset: 0x49904CC VA: 0x49944CC
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994578 Offset: 0x4990578 VA: 0x4994578
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49945C0 Offset: 0x49905C0 VA: 0x49945C0
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49946DC Offset: 0x49906DC VA: 0x49946DC
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994724 Offset: 0x4990724 VA: 0x4994724
	|-ImmutableList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994840 Offset: 0x4990840 VA: 0x4994840
	|-ImmutableList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994988 Offset: 0x4990988 VA: 0x4994988
	|-ImmutableList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994A2C Offset: 0x4990A2C VA: 0x4994A2C
	|-ImmutableList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994AB4 Offset: 0x4990AB4 VA: 0x4994AB4
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994BB8 Offset: 0x4990BB8 VA: 0x4994BB8
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994C00 Offset: 0x4990C00 VA: 0x4994C00
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994C48 Offset: 0x4990C48 VA: 0x4994C48
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994C90 Offset: 0x4990C90 VA: 0x4994C90
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994CA4 Offset: 0x4990CA4 VA: 0x4994CA4
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994CEC Offset: 0x4990CEC VA: 0x4994CEC
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994D34 Offset: 0x4990D34 VA: 0x4994D34
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994E8C Offset: 0x4990E8C VA: 0x4994E8C
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4994FDC Offset: 0x4990FDC VA: 0x4994FDC
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4995024 Offset: 0x4991024 VA: 0x4995024
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499506C Offset: 0x499106C VA: 0x499506C
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49950B4 Offset: 0x49910B4 VA: 0x49950B4
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49950FC Offset: 0x49910FC VA: 0x49950FC
	|-ImmutableList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499523C Offset: 0x499123C VA: 0x499523C
	|-ImmutableList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	*/
}

// Namespace: Sirenix.Utilities
[DefaultMember("Item")]
[Serializable]
public sealed class ImmutableList<TList, TElement> : IImmutableList<TElement>, IImmutableList, IList, ICollection, IEnumerable, IList<TElement>, ICollection<TElement>, IEnumerable<TElement> // TypeDefIndex: 24932
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
	|-RVA: 0x4996480 Offset: 0x4992480 VA: 0x4996480
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49965CC Offset: 0x49925CC VA: 0x49965CC
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49966C8 Offset: 0x49926C8 VA: 0x49966C8
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49966D0 Offset: 0x49926D0 VA: 0x49966D0
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49966D8 Offset: 0x49926D8 VA: 0x49966D8
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49966E0 Offset: 0x49926E0 VA: 0x49966E0
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49966E8 Offset: 0x49926E8 VA: 0x49966E8
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49966F0 Offset: 0x49926F0 VA: 0x49966F0
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499679C Offset: 0x499279C VA: 0x499679C
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49967E4 Offset: 0x49927E4 VA: 0x49967E4
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996920 Offset: 0x4992920 VA: 0x4996920
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TElement get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996968 Offset: 0x4992968 VA: 0x4996968
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public bool Contains(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996AA4 Offset: 0x4992AA4 VA: 0x4996AA4
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public void CopyTo(TElement[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996C08 Offset: 0x4992C08 VA: 0x4996C08
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996D1C Offset: 0x4992D1C VA: 0x4996D1C
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996E18 Offset: 0x4992E18 VA: 0x4996E18
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996F74 Offset: 0x4992F74 VA: 0x4996F74
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.Generic.ICollection<TElement>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4996FBC Offset: 0x4992FBC VA: 0x4996FBC
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4997004 Offset: 0x4993004 VA: 0x4997004
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TElement>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499704C Offset: 0x499304C VA: 0x499704C
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4997060 Offset: 0x4993060 VA: 0x4997060
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49970A8 Offset: 0x49930A8 VA: 0x49970A8
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49970F0 Offset: 0x49930F0 VA: 0x49970F0
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4997258 Offset: 0x4993258 VA: 0x4997258
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49973B8 Offset: 0x49933B8 VA: 0x49973B8
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4997400 Offset: 0x4993400 VA: 0x4997400
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4997448 Offset: 0x4993448 VA: 0x4997448
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4997490 Offset: 0x4993490 VA: 0x4997490
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public int IndexOf(TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49974D8 Offset: 0x49934D8 VA: 0x49974D8
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4997634 Offset: 0x4993634 VA: 0x4997634
	|-ImmutableList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IList<TElement>.RemoveAt
	*/
}

// Namespace: Sirenix.Utilities
[Extension]
public static class MathUtilities // TypeDefIndex: 24933
{
	// Fields
	private const float ZERO_TOLERANCE = 1E-06;

	// Methods

	// RVA: 0x7F15B18 Offset: 0x7F11B18 VA: 0x7F15B18
	public static float PointDistanceToLine(Vector3 point, Vector3 a, Vector3 b) { }

	// RVA: 0x7F15B50 Offset: 0x7F11B50 VA: 0x7F15B50
	public static float Hermite(float start, float end, float t) { }

	// RVA: 0x7F15B88 Offset: 0x7F11B88 VA: 0x7F15B88
	public static float StackHermite(float start, float end, float t, int count) { }

	// RVA: 0x7F15BD4 Offset: 0x7F11BD4 VA: 0x7F15BD4
	public static float Fract(float value) { }

	// RVA: 0x7F15C40 Offset: 0x7F11C40 VA: 0x7F15C40
	public static Vector2 Fract(Vector2 value) { }

	// RVA: 0x7F15C70 Offset: 0x7F11C70 VA: 0x7F15C70
	public static Vector3 Fract(Vector3 value) { }

	// RVA: 0x7F15CBC Offset: 0x7F11CBC VA: 0x7F15CBC
	public static float BounceEaseInFastOut(float t) { }

	// RVA: 0x7F15CEC Offset: 0x7F11CEC VA: 0x7F15CEC
	public static float Hermite01(float t) { }

	// RVA: 0x7F15D1C Offset: 0x7F11D1C VA: 0x7F15D1C
	public static float StackHermite01(float t, int count) { }

	// RVA: 0x7F15D5C Offset: 0x7F11D5C VA: 0x7F15D5C
	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float amount) { }

	// RVA: 0x7F15D84 Offset: 0x7F11D84 VA: 0x7F15D84
	public static Vector2 LerpUnclamped(Vector2 from, Vector2 to, float amount) { }

	// RVA: 0x7F15DA0 Offset: 0x7F11DA0 VA: 0x7F15DA0
	public static float Bounce(float value) { }

	// RVA: 0x7F15DC8 Offset: 0x7F11DC8 VA: 0x7F15DC8
	public static float EaseInElastic(float value, float amplitude = 0.25, float length = 0.6) { }

	[Extension]
	// RVA: 0x7F15E80 Offset: 0x7F11E80 VA: 0x7F15E80
	public static Vector3 Pow(Vector3 v, float p) { }

	[Extension]
	// RVA: 0x7F15EDC Offset: 0x7F11EDC VA: 0x7F15EDC
	public static Vector3 Abs(Vector3 v) { }

	[Extension]
	// RVA: 0x7F15EEC Offset: 0x7F11EEC VA: 0x7F15EEC
	public static Vector3 Sign(Vector3 v) { }

	// RVA: 0x7F15F10 Offset: 0x7F11F10 VA: 0x7F15F10
	public static float EaseOutElastic(float value, float amplitude = 0.25, float length = 0.6) { }

	// RVA: 0x7F15F34 Offset: 0x7F11F34 VA: 0x7F15F34
	public static float EaseInOut(float t) { }

	[Extension]
	// RVA: 0x7F15F70 Offset: 0x7F11F70 VA: 0x7F15F70
	public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max) { }

	[Extension]
	// RVA: 0x7F15FAC Offset: 0x7F11FAC VA: 0x7F15FAC
	public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max) { }

	// RVA: 0x7F15FD0 Offset: 0x7F11FD0 VA: 0x7F15FD0
	public static int ComputeByteArrayHash(byte[] data) { }

	// RVA: 0x7F16050 Offset: 0x7F12050 VA: 0x7F16050
	public static Vector3 InterpolatePoints(Vector3[] path, float t) { }

	// RVA: 0x7F16274 Offset: 0x7F12274 VA: 0x7F16274
	public static bool LineIntersectsLine(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2, out Vector2 intersection) { }

	// RVA: 0x7F16414 Offset: 0x7F12414 VA: 0x7F16414
	public static Vector2 InfiniteLineIntersect(Vector2 ps1, Vector2 pe1, Vector2 ps2, Vector2 pe2) { }

	// RVA: 0x7F164C0 Offset: 0x7F124C0 VA: 0x7F164C0
	public static float LineDistToPlane(Vector3 planeOrigin, Vector3 planeNormal, Vector3 lineOrigin, Vector3 lineDirectionNormalized) { }

	// RVA: 0x7F165B8 Offset: 0x7F125B8 VA: 0x7F165B8
	public static float RayDistToPlane(Ray ray, Plane plane) { }

	// RVA: 0x7F1661C Offset: 0x7F1261C VA: 0x7F1661C
	public static Vector2 RotatePoint(Vector2 point, float degrees) { }

	// RVA: 0x7F1666C Offset: 0x7F1266C VA: 0x7F1666C
	public static Vector2 RotatePoint(Vector2 point, Vector2 around, float degrees) { }

	// RVA: 0x7F166DC Offset: 0x7F126DC VA: 0x7F166DC
	public static float SmoothStep(float a, float b, float t) { }

	// RVA: 0x7F16714 Offset: 0x7F12714 VA: 0x7F16714
	public static float LinearStep(float a, float b, float t) { }

	// RVA: 0x7F16738 Offset: 0x7F12738 VA: 0x7F16738
	public static double Wrap(double value, double min, double max) { }

	// RVA: 0x7F16800 Offset: 0x7F12800 VA: 0x7F16800
	public static float Wrap(float value, float min, float max) { }

	// RVA: 0x7F168C8 Offset: 0x7F128C8 VA: 0x7F168C8
	public static int Wrap(int value, int min, int max) { }

	// RVA: 0x7F16984 Offset: 0x7F12984 VA: 0x7F16984
	public static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference) { }

	// RVA: 0x7F16A1C Offset: 0x7F12A1C VA: 0x7F16A1C
	public static double DiscardLeastSignificantDecimal(double v) { }

	// RVA: 0x7F16C08 Offset: 0x7F12C08 VA: 0x7F16C08
	public static float ClampWrapAngle(float angle, float min, float max) { }

	// RVA: 0x7F16B7C Offset: 0x7F12B7C VA: 0x7F16B7C
	private static int GetNumberOfDecimalsForMinimumDifference(double minDifference) { }
}

// Namespace: Sirenix.Utilities
public sealed class MemberAliasFieldInfo : FieldInfo // TypeDefIndex: 24934
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

	// RVA: 0x7F16D30 Offset: 0x7F12D30 VA: 0x7F16D30
	public void .ctor(FieldInfo field, string namePrefix) { }

	// RVA: 0x7F16DDC Offset: 0x7F12DDC VA: 0x7F16DDC
	public void .ctor(FieldInfo field, string namePrefix, string separatorString) { }

	// RVA: 0x7F16E60 Offset: 0x7F12E60 VA: 0x7F16E60
	public FieldInfo get_AliasedField() { }

	// RVA: 0x7F16E68 Offset: 0x7F12E68 VA: 0x7F16E68 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x7F16E8C Offset: 0x7F12E8C VA: 0x7F16E8C Slot: 23
	public override int get_MetadataToken() { }

	// RVA: 0x7F16EB0 Offset: 0x7F12EB0 VA: 0x7F16EB0 Slot: 13
	public override string get_Name() { }

	// RVA: 0x7F16EB8 Offset: 0x7F12EB8 VA: 0x7F16EB8 Slot: 14
	public override Type get_DeclaringType() { }

	// RVA: 0x7F16EDC Offset: 0x7F12EDC VA: 0x7F16EDC Slot: 15
	public override Type get_ReflectedType() { }

	// RVA: 0x7F16F00 Offset: 0x7F12F00 VA: 0x7F16F00 Slot: 31
	public override Type get_FieldType() { }

	// RVA: 0x7F16F24 Offset: 0x7F12F24 VA: 0x7F16F24 Slot: 47
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x7F16F48 Offset: 0x7F12F48 VA: 0x7F16F48 Slot: 30
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x7F16F6C Offset: 0x7F12F6C VA: 0x7F16F6C Slot: 19
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x7F16F94 Offset: 0x7F12F94 VA: 0x7F16F94 Slot: 20
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x7F16FBC Offset: 0x7F12FBC VA: 0x7F16FBC Slot: 18
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x7F16FE4 Offset: 0x7F12FE4 VA: 0x7F16FE4 Slot: 48
	public override object GetValue(object obj) { }

	// RVA: 0x7F17008 Offset: 0x7F13008 VA: 0x7F17008 Slot: 50
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }
}

// Namespace: Sirenix.Utilities
public sealed class MemberAliasMethodInfo : MethodInfo // TypeDefIndex: 24935
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

	// RVA: 0x7F1702C Offset: 0x7F1302C VA: 0x7F1702C
	public void .ctor(MethodInfo method, string namePrefix) { }

	// RVA: 0x7F170D8 Offset: 0x7F130D8 VA: 0x7F170D8
	public void .ctor(MethodInfo method, string namePrefix, string separatorString) { }

	// RVA: 0x7F1715C Offset: 0x7F1315C VA: 0x7F1715C
	public MethodInfo get_AliasedMethod() { }

	// RVA: 0x7F17164 Offset: 0x7F13164 VA: 0x7F17164 Slot: 77
	public override ICustomAttributeProvider get_ReturnTypeCustomAttributes() { }

	// RVA: 0x7F17188 Offset: 0x7F13188 VA: 0x7F17188 Slot: 56
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x7F171AC Offset: 0x7F131AC VA: 0x7F171AC Slot: 31
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x7F171D0 Offset: 0x7F131D0 VA: 0x7F171D0 Slot: 73
	public override Type get_ReturnType() { }

	// RVA: 0x7F171F4 Offset: 0x7F131F4 VA: 0x7F171F4 Slot: 14
	public override Type get_DeclaringType() { }

	// RVA: 0x7F17218 Offset: 0x7F13218 VA: 0x7F17218 Slot: 13
	public override string get_Name() { }

	// RVA: 0x7F17220 Offset: 0x7F13220 VA: 0x7F17220 Slot: 15
	public override Type get_ReflectedType() { }

	// RVA: 0x7F17244 Offset: 0x7F13244 VA: 0x7F17244 Slot: 76
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x7F17268 Offset: 0x7F13268 VA: 0x7F17268 Slot: 19
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x7F17290 Offset: 0x7F13290 VA: 0x7F17290 Slot: 20
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x7F172B8 Offset: 0x7F132B8 VA: 0x7F172B8 Slot: 33
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x7F172DC Offset: 0x7F132DC VA: 0x7F172DC Slot: 30
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x7F17300 Offset: 0x7F13300 VA: 0x7F17300 Slot: 55
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x7F17324 Offset: 0x7F13324 VA: 0x7F17324 Slot: 18
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: Sirenix.Utilities
public sealed class MemberAliasPropertyInfo : PropertyInfo // TypeDefIndex: 24936
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

	// RVA: 0x7F1734C Offset: 0x7F1334C VA: 0x7F1734C
	public void .ctor(PropertyInfo prop, string namePrefix) { }

	// RVA: 0x7F173F8 Offset: 0x7F133F8 VA: 0x7F173F8
	public void .ctor(PropertyInfo prop, string namePrefix, string separatorString) { }

	// RVA: 0x7F1747C Offset: 0x7F1347C VA: 0x7F1747C
	public PropertyInfo get_AliasedProperty() { }

	// RVA: 0x7F17484 Offset: 0x7F13484 VA: 0x7F17484 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x7F174A8 Offset: 0x7F134A8 VA: 0x7F174A8 Slot: 23
	public override int get_MetadataToken() { }

	// RVA: 0x7F174CC Offset: 0x7F134CC VA: 0x7F174CC Slot: 13
	public override string get_Name() { }

	// RVA: 0x7F174D4 Offset: 0x7F134D4 VA: 0x7F174D4 Slot: 14
	public override Type get_DeclaringType() { }

	// RVA: 0x7F174F8 Offset: 0x7F134F8 VA: 0x7F174F8 Slot: 15
	public override Type get_ReflectedType() { }

	// RVA: 0x7F1751C Offset: 0x7F1351C VA: 0x7F1751C Slot: 30
	public override Type get_PropertyType() { }

	// RVA: 0x7F17540 Offset: 0x7F13540 VA: 0x7F17540 Slot: 32
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x7F17564 Offset: 0x7F13564 VA: 0x7F17564 Slot: 34
	public override bool get_CanRead() { }

	// RVA: 0x7F17588 Offset: 0x7F13588 VA: 0x7F17588 Slot: 35
	public override bool get_CanWrite() { }

	// RVA: 0x7F175AC Offset: 0x7F135AC VA: 0x7F175AC Slot: 19
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x7F175D4 Offset: 0x7F135D4 VA: 0x7F175D4 Slot: 20
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x7F175FC Offset: 0x7F135FC VA: 0x7F175FC Slot: 18
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x7F17624 Offset: 0x7F13624 VA: 0x7F17624 Slot: 37
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x7F1764C Offset: 0x7F1364C VA: 0x7F1764C Slot: 40
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x7F17674 Offset: 0x7F13674 VA: 0x7F17674 Slot: 31
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x7F17698 Offset: 0x7F13698 VA: 0x7F17698 Slot: 43
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x7F176C0 Offset: 0x7F136C0 VA: 0x7F176C0 Slot: 47
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x7F176E4 Offset: 0x7F136E4 VA: 0x7F176E4 Slot: 51
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }
}

// Namespace: Sirenix.Utilities
public static class MultiDimArrayUtilities // TypeDefIndex: 24937
{
	// Methods

	// RVA: -1 Offset: -1
	public static TElement[,] InsertOneColumnLeft<TElement>(TElement[,] array, int columnIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467E698 Offset: 0x467A698 VA: 0x467E698
	|-MultiDimArrayUtilities.InsertOneColumnLeft<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TElement[,] InsertOneColumnRight<TElement>(TElement[,] arr, int columnIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467E91C Offset: 0x467A91C VA: 0x467E91C
	|-MultiDimArrayUtilities.InsertOneColumnRight<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TElement[,] InsertOneRowAbove<TElement>(TElement[,] array, int rowIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467EBA0 Offset: 0x467ABA0 VA: 0x467EBA0
	|-MultiDimArrayUtilities.InsertOneRowAbove<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TElement[,] InsertOneRowBelow<TElement>(TElement[,] array, int rowIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467EE28 Offset: 0x467AE28 VA: 0x467EE28
	|-MultiDimArrayUtilities.InsertOneRowBelow<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TElement[,] DuplicateColumn<TElement>(TElement[,] array, int columnIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467DF90 Offset: 0x4679F90 VA: 0x467DF90
	|-MultiDimArrayUtilities.DuplicateColumn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TElement[,] DuplicateRow<TElement>(TElement[,] array, int rowIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467E318 Offset: 0x467A318 VA: 0x467E318
	|-MultiDimArrayUtilities.DuplicateRow<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TElement[,] MoveColumn<TElement>(TElement[,] array, int fromColumn, int toColumn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467F0B0 Offset: 0x467B0B0 VA: 0x467F0B0
	|-MultiDimArrayUtilities.MoveColumn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TElement[,] MoveRow<TElement>(TElement[,] array, int fromRow, int toRow) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467F580 Offset: 0x467B580 VA: 0x467F580
	|-MultiDimArrayUtilities.MoveRow<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TElement[,] DeleteColumn<TElement>(TElement[,] array, int columnIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467DB10 Offset: 0x4679B10 VA: 0x467DB10
	|-MultiDimArrayUtilities.DeleteColumn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TElement[,] DeleteRow<TElement>(TElement[,] array, int rowIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x467DD50 Offset: 0x4679D50 VA: 0x467DD50
	|-MultiDimArrayUtilities.DeleteRow<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sirenix.Utilities
public class OdinDefineSymbols // TypeDefIndex: 24938
{
	// Fields
	public const bool SIRENIX_INTERNAL = False;
	public const bool ODIN_ASSET_STORE = True;
	public const bool ODIN_TRIAL = False;
	public const bool ODIN_EDUCATIONAL = False;
	public const bool ODIN_GAMEJAM = False;

	// Methods

	// RVA: 0x7F17708 Offset: 0x7F13708 VA: 0x7F17708
	public void .ctor() { }
}

// Namespace: Sirenix.Utilities
[Usage(1)]
public class PersistentAssemblyAttribute : Attribute // TypeDefIndex: 24939
{
	// Methods

	// RVA: 0x7F17710 Offset: 0x7F13710 VA: 0x7F17710
	public void .ctor() { }
}

// Namespace: Sirenix.Utilities
internal class ProjectPathFinder : ScriptableObject // TypeDefIndex: 24940
{
	// Methods

	// RVA: 0x7F17718 Offset: 0x7F13718 VA: 0x7F17718
	public void .ctor() { }
}

// Namespace: Sirenix.Utilities
public class ReferenceEqualityComparer<T> : IEqualityComparer<T> // TypeDefIndex: 24941
{
	// Fields
	public static readonly ReferenceEqualityComparer<T> Default; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54952D8 Offset: 0x54912D8 VA: 0x54952D8
	|-ReferenceEqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54952E4 Offset: 0x54912E4 VA: 0x54952E4
	|-ReferenceEqualityComparer<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5495384 Offset: 0x5491384 VA: 0x5495384
	|-ReferenceEqualityComparer<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x549538C Offset: 0x549138C VA: 0x549538C
	|-ReferenceEqualityComparer<object>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SirenixAssetPaths.<>c__DisplayClass12_0 // TypeDefIndex: 24942
{
	// Fields
	public char[] invalids; // 0x10
	public char replace; // 0x18

	// Methods

	// RVA: 0x7F17A44 Offset: 0x7F13A44 VA: 0x7F17A44
	public void .ctor() { }

	// RVA: 0x7F17A4C Offset: 0x7F13A4C VA: 0x7F17A4C
	internal char <ToPathSafeString>b__0(char c) { }
}

// Namespace: Sirenix.Utilities
public static class SirenixAssetPaths // TypeDefIndex: 24943
{
	// Fields
	public const string DefaultSirenixPluginPath = "Assets/Plugins/Sirenix/";
	public const string SirenixAssetPathsSOGuid = "08379ccefc05200459f90a1c0711a340";
	public const string LookupAssetName = "OdinPathLookup.asset";
	public static readonly string OdinPath; // 0x0
	public static readonly string SirenixAssetsPath; // 0x8
	public static readonly string SirenixPluginPath; // 0x10
	public static readonly string SirenixAssembliesPath; // 0x18
	public static readonly string OdinResourcesPath; // 0x20
	public static readonly string OdinEditorConfigsPath; // 0x28
	public static readonly string OdinResourcesConfigsPath; // 0x30
	public static readonly string OdinTempPath; // 0x38

	// Methods

	// RVA: 0x7F17720 Offset: 0x7F13720 VA: 0x7F17720
	private static void .cctor() { }

	// RVA: 0x7F17904 Offset: 0x7F13904 VA: 0x7F17904
	private static string ToPathSafeString(string name, char replace = '\x5f') { }
}

// Namespace: Sirenix.Utilities
[Usage(1, AllowMultiple = False, Inherited = False)]
public class SirenixBuildNameAttribute : Attribute // TypeDefIndex: 24944
{
	// Fields
	[CompilerGenerated]
	private string <BuildName>k__BackingField; // 0x10

	// Properties
	public string BuildName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F17AB4 Offset: 0x7F13AB4 VA: 0x7F17AB4
	public string get_BuildName() { }

	[CompilerGenerated]
	// RVA: 0x7F17ABC Offset: 0x7F13ABC VA: 0x7F17ABC
	private void set_BuildName(string value) { }

	// RVA: 0x7F17AC4 Offset: 0x7F13AC4 VA: 0x7F17AC4
	public void .ctor(string buildName) { }
}

// Namespace: Sirenix.Utilities
[Usage(1, AllowMultiple = False, Inherited = False)]
public class SirenixBuildVersionAttribute : Attribute // TypeDefIndex: 24945
{
	// Fields
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x10

	// Properties
	public string Version { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F17AF4 Offset: 0x7F13AF4 VA: 0x7F17AF4
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x7F17AFC Offset: 0x7F13AFC VA: 0x7F17AFC
	private void set_Version(string value) { }

	// RVA: 0x7F17B04 Offset: 0x7F13B04 VA: 0x7F17B04
	public void .ctor(string version) { }
}

// Namespace: Sirenix.Utilities
public class SirenixEditorConfigAttribute : GlobalConfigAttribute // TypeDefIndex: 24946
{
	// Methods

	// RVA: 0x7F17B34 Offset: 0x7F13B34 VA: 0x7F17B34
	public void .ctor() { }
}

// Namespace: Sirenix.Utilities
public class SirenixGlobalConfigAttribute : GlobalConfigAttribute // TypeDefIndex: 24947
{
	// Methods

	// RVA: 0x7F17B98 Offset: 0x7F13B98 VA: 0x7F17B98
	public void .ctor() { }
}

// Namespace: Sirenix.Utilities
[Extension]
public static class StringUtilities // TypeDefIndex: 24948
{
	// Methods

	// RVA: 0x7F17BFC Offset: 0x7F13BFC VA: 0x7F17BFC
	public static string NicifyByteSize(int bytes, int decimals = 1) { }

	[Extension]
	// RVA: 0x7F17EC4 Offset: 0x7F13EC4 VA: 0x7F17EC4
	public static bool FastEndsWith(string str, string endsWith) { }

	// RVA: 0x7F17F80 Offset: 0x7F13F80 VA: 0x7F17F80
	public static int NumberAwareStringCompare(string a, string b, bool ignoreLeadingZeroes = True, bool ignoreWhiteSpace = True, bool ignoreCase = False) { }
}

// Namespace: Sirenix.Utilities
public static class UnityVersion // TypeDefIndex: 24949
{
	// Fields
	public static readonly int Major; // 0x0
	public static readonly int Minor; // 0x4

	// Methods

	// RVA: 0x7F183C8 Offset: 0x7F143C8 VA: 0x7F183C8
	private static void .cctor() { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x7F187D0 Offset: 0x7F147D0 VA: 0x7F187D0
	private static void EnsureLoaded() { }

	// RVA: 0x7F187D4 Offset: 0x7F147D4 VA: 0x7F187D4
	public static bool IsVersionOrGreater(int major, int minor) { }
}

// Namespace: Sirenix.Utilities.Unsafe
public static class UnsafeUtilities // TypeDefIndex: 24950
{
	// Methods

	// RVA: -1 Offset: -1
	public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4756E78 Offset: 0x4752E78 VA: 0x4756E78
	|-UnsafeUtilities.StructArrayFromBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength, int byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4756EBC Offset: 0x4752EBC VA: 0x4756EBC
	|-UnsafeUtilities.StructArrayFromBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static byte[] StructArrayToBytes<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4757484 Offset: 0x4753484 VA: 0x4757484
	|-UnsafeUtilities.StructArrayToBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static byte[] StructArrayToBytes<T>(T[] array, ref byte[] bytes, int byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47574D0 Offset: 0x47534D0 VA: 0x47574D0
	|-UnsafeUtilities.StructArrayToBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x7F18894 Offset: 0x7F14894 VA: 0x7F18894
	public static string StringFromBytes(byte[] buffer, int charLength, bool needs16BitSupport) { }

	// RVA: 0x7F18CA4 Offset: 0x7F14CA4 VA: 0x7F18CA4
	public static int StringToBytes(byte[] buffer, string value, bool needs16BitSupport) { }

	// RVA: 0x7F190A0 Offset: 0x7F150A0 VA: 0x7F190A0
	public static void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 // TypeDefIndex: 24951
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 24952
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 AEAB8CBF0F8D91747CD9D0B9512DF7A2F96DFAEA4D2FFEA89EF2654D47B721AF /*Metadata offset 0xF3CCC0*/; // 0x0
}

