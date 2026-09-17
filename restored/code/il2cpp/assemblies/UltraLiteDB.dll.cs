// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 26388
{}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteCollection.<Find>d__9<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 26389
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Query query; // 0x0
	public Query <>3__query; // 0x0
	public UltraLiteCollection<T> <>4__this; // 0x0
	private int skip; // 0x0
	public int <>3__skip; // 0x0
	private int limit; // 0x0
	public int <>3__limit; // 0x0
	private IEnumerator<BsonDocument> <>7__wrap1; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE0DA4 Offset: 0x5BDCDA4 VA: 0x5BE0DA4
	|-UltraLiteCollection.<Find>d__9<object>..ctor
	|
	|-RVA: 0x5BE135C Offset: 0x5BDD35C VA: 0x5BE135C
	|-UltraLiteCollection.<Find>d__9<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE0DD8 Offset: 0x5BDCDD8 VA: 0x5BE0DD8
	|-UltraLiteCollection.<Find>d__9<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x5BE13C4 Offset: 0x5BDD3C4 VA: 0x5BE13C4
	|-UltraLiteCollection.<Find>d__9<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE0DF4 Offset: 0x5BDCDF4 VA: 0x5BE0DF4
	|-UltraLiteCollection.<Find>d__9<object>.MoveNext
	|
	|-RVA: 0x5BE1424 Offset: 0x5BDD424 VA: 0x5BE1424
	|-UltraLiteCollection.<Find>d__9<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE11A4 Offset: 0x5BDD1A4 VA: 0x5BE11A4
	|-UltraLiteCollection.<Find>d__9<object>.<>m__Finally1
	|
	|-RVA: 0x5BE1A28 Offset: 0x5BDDA28 VA: 0x5BE1A28
	|-UltraLiteCollection.<Find>d__9<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE1254 Offset: 0x5BDD254 VA: 0x5BE1254
	|-UltraLiteCollection.<Find>d__9<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x5BE1B34 Offset: 0x5BDDB34 VA: 0x5BE1B34
	|-UltraLiteCollection.<Find>d__9<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE125C Offset: 0x5BDD25C VA: 0x5BE125C
	|-UltraLiteCollection.<Find>d__9<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5BE1BD4 Offset: 0x5BDDBD4 VA: 0x5BE1BD4
	|-UltraLiteCollection.<Find>d__9<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE1290 Offset: 0x5BDD290 VA: 0x5BE1290
	|-UltraLiteCollection.<Find>d__9<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5BE1C08 Offset: 0x5BDDC08 VA: 0x5BE1C08
	|-UltraLiteCollection.<Find>d__9<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE1298 Offset: 0x5BDD298 VA: 0x5BE1298
	|-UltraLiteCollection.<Find>d__9<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x5BE1CAC Offset: 0x5BDDCAC VA: 0x5BE1CAC
	|-UltraLiteCollection.<Find>d__9<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5BE134C Offset: 0x5BDD34C VA: 0x5BE134C
	|-UltraLiteCollection.<Find>d__9<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x5BE1E74 Offset: 0x5BDDE74 VA: 0x5BE1E74
	|-UltraLiteCollection.<Find>d__9<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: UltraLiteDB
public sealed class UltraLiteCollection<T> // TypeDefIndex: 26390
{
	// Fields
	private string _name; // 0x0
	private LazyLoad<UltraLiteEngine> _engine; // 0x0
	private BsonMapper _mapper; // 0x0
	private readonly EntityMapper _entity; // 0x0
	private Logger _log; // 0x0
	private MemberMapper _id; // 0x0
	private BsonAutoId _autoId; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public bool Exists(Query query) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x568D504 Offset: 0x5689504 VA: 0x568D504
	|-UltraLiteCollection<object>.Exists
	|
	|-RVA: 0x568E2E8 Offset: 0x568A2E8 VA: 0x568E2E8
	|-UltraLiteCollection<__Il2CppFullySharedGenericType>.Exists
	*/

	// RVA: -1 Offset: -1
	public int Delete(Query query) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x568D5B8 Offset: 0x56895B8 VA: 0x568D5B8
	|-UltraLiteCollection<object>.Delete
	|
	|-RVA: 0x568E39C Offset: 0x568A39C VA: 0x568E39C
	|-UltraLiteCollection<__Il2CppFullySharedGenericType>.Delete
	*/

	// RVA: -1 Offset: -1
	public bool Delete(BsonValue id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x568D66C Offset: 0x568966C VA: 0x568D66C
	|-UltraLiteCollection<object>.Delete
	|
	|-RVA: 0x568E450 Offset: 0x568A450 VA: 0x568E450
	|-UltraLiteCollection<__Il2CppFullySharedGenericType>.Delete
	*/

	[IteratorStateMachine(typeof(UltraLiteCollection.<Find>d__9<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<T> Find(Query query, int skip = 0, int limit = 2147483647) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x568D778 Offset: 0x5689778 VA: 0x568D778
	|-UltraLiteCollection<object>.Find
	|
	|-RVA: 0x568E560 Offset: 0x568A560 VA: 0x568E560
	|-UltraLiteCollection<__Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	public T FindById(BsonValue id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x568D81C Offset: 0x568981C VA: 0x568D81C
	|-UltraLiteCollection<object>.FindById
	|
	|-RVA: 0x568E668 Offset: 0x568A668 VA: 0x568E668
	|-UltraLiteCollection<__Il2CppFullySharedGenericType>.FindById
	*/

	// RVA: -1 Offset: -1
	public void Insert(BsonValue id, T document) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x568D934 Offset: 0x5689934 VA: 0x568D934
	|-UltraLiteCollection<object>.Insert
	|
	|-RVA: 0x568E818 Offset: 0x568A818 VA: 0x568E818
	|-UltraLiteCollection<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name, BsonAutoId autoId, LazyLoad<UltraLiteEngine> engine, BsonMapper mapper, Logger log) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x568DAC8 Offset: 0x5689AC8 VA: 0x568DAC8
	|-UltraLiteCollection<object>..ctor
	|
	|-RVA: 0x568EA7C Offset: 0x568AA7C VA: 0x568EA7C
	|-UltraLiteCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Update(BsonValue id, T document) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x568DF44 Offset: 0x5689F44 VA: 0x568DF44
	|-UltraLiteCollection<object>.Update
	|
	|-RVA: 0x568EEF8 Offset: 0x568AEF8 VA: 0x568EEF8
	|-UltraLiteCollection<__Il2CppFullySharedGenericType>.Update
	*/

	// RVA: -1 Offset: -1
	public bool Upsert(BsonValue id, T document) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x568E154 Offset: 0x568A154 VA: 0x568E154
	|-UltraLiteCollection<object>.Upsert
	|
	|-RVA: 0x568F1D4 Offset: 0x568B1D4 VA: 0x568F1D4
	|-UltraLiteCollection<__Il2CppFullySharedGenericType>.Upsert
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteDatabase.<>c__DisplayClass11_0 // TypeDefIndex: 26391
{
	// Fields
	public UltraLiteDatabase <>4__this; // 0x10
	public FileOptions options; // 0x18

	// Methods

	// RVA: 0x84A2ADC Offset: 0x849EADC VA: 0x84A2ADC
	public void .ctor() { }

	// RVA: 0x84A2F28 Offset: 0x849EF28 VA: 0x84A2F28
	internal UltraLiteEngine <.ctor>b__0() { }
}

// Namespace: UltraLiteDB
public class UltraLiteDatabase : IDisposable // TypeDefIndex: 26392
{
	// Fields
	private LazyLoad<UltraLiteEngine> _engine; // 0x10
	private BsonMapper _mapper; // 0x18
	private Logger _log; // 0x20
	private ConnectionString _connectionString; // 0x28

	// Methods

	// RVA: 0x84A280C Offset: 0x849E80C VA: 0x84A280C
	public void .ctor(ConnectionString connectionString, BsonMapper mapper, Logger log) { }

	// RVA: -1 Offset: -1
	public UltraLiteCollection<T> GetCollection<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x473C4B0 Offset: 0x47384B0 VA: 0x473C4B0
	|-UltraLiteDatabase.GetCollection<object>
	|
	|-RVA: 0x473C530 Offset: 0x4738530 VA: 0x473C530
	|-UltraLiteDatabase.GetCollection<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x84A2AE4 Offset: 0x849EAE4 VA: 0x84A2AE4
	public IEnumerable<string> GetCollectionNames() { }

	// RVA: 0x84A2BD4 Offset: 0x849EBD4 VA: 0x84A2BD4
	public bool DropCollection(string name) { }

	// RVA: 0x84A2DE0 Offset: 0x849EDE0 VA: 0x84A2DE0 Slot: 4
	public void Dispose() { }
}

// Namespace: UltraLiteDB
public static class BsonReader // TypeDefIndex: 26393
{
	// Methods

	// RVA: 0x84A35AC Offset: 0x849F5AC VA: 0x84A35AC
	public static BsonDocument Deserialize(byte[] bson, bool utcDate = True) { }

	// RVA: 0x84A3618 Offset: 0x849F618 VA: 0x84A3618
	public static BsonDocument ReadDocument(ByteReader reader, bool utcDate = True) { }

	// RVA: 0x84A3E3C Offset: 0x849FE3C VA: 0x84A3E3C
	public static BsonArray ReadArray(ByteReader reader, bool utcDate = True) { }

	// RVA: 0x84A386C Offset: 0x849F86C VA: 0x84A386C
	private static BsonValue ReadElement(ByteReader reader, out string name, bool utcDate) { }
}

// Namespace: UltraLiteDB
public static class BsonWriter // TypeDefIndex: 26394
{
	// Methods

	// RVA: 0x84A45D4 Offset: 0x84A05D4 VA: 0x84A45D4
	public static byte[] Serialize(BsonDocument doc) { }

	// RVA: 0x84A4668 Offset: 0x84A0668 VA: 0x84A4668
	public static void WriteDocument(ByteWriter writer, BsonDocument doc) { }

	// RVA: 0x84A5288 Offset: 0x84A1288 VA: 0x84A5288
	public static void WriteArray(ByteWriter writer, BsonArray array) { }

	// RVA: 0x84A4A64 Offset: 0x84A0A64 VA: 0x84A4A64
	private static void WriteElement(ByteWriter writer, string key, BsonValue value) { }

	// RVA: 0x84A54A4 Offset: 0x84A14A4 VA: 0x84A54A4
	private static void WriteString(ByteWriter writer, string s) { }

	// RVA: 0x84A5444 Offset: 0x84A1444 VA: 0x84A5444
	private static void WriteCString(ByteWriter writer, string s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BsonArray.<System-Collections-IEnumerable-GetEnumerator>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 26395
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BsonArray <>4__this; // 0x20
	private IEnumerator<BsonValue> <>7__wrap1; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84A5F3C Offset: 0x84A1F3C VA: 0x84A5F3C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84A6398 Offset: 0x84A2398 VA: 0x84A6398 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84A63B4 Offset: 0x84A23B4 VA: 0x84A63B4 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x84A6660 Offset: 0x84A2660 VA: 0x84A6660
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x84A6710 Offset: 0x84A2710 VA: 0x84A6710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84A6718 Offset: 0x84A2718 VA: 0x84A6718 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84A6750 Offset: 0x84A2750 VA: 0x84A6750 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UltraLiteDB
[DefaultMember("Item")]
public class BsonArray : BsonValue, IList<BsonValue>, ICollection<BsonValue>, IEnumerable<BsonValue>, IEnumerable // TypeDefIndex: 26396
{
	// Fields
	private int _length; // 0x20

	// Properties
	internal IList<BsonValue> RawValue { get; }
	public override BsonValue Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x84A3F0C Offset: 0x849FF0C VA: 0x84A3F0C
	public void .ctor() { }

	// RVA: 0x84A5520 Offset: 0x84A1520 VA: 0x84A5520
	public void .ctor(List<BsonValue> array) { }

	// RVA: 0x84A5660 Offset: 0x84A1660 VA: 0x84A5660
	internal IList<BsonValue> get_RawValue() { }

	// RVA: 0x84A56D8 Offset: 0x84A16D8 VA: 0x84A56D8 Slot: 9
	public override BsonValue get_Item(int index) { }

	// RVA: 0x84A5788 Offset: 0x84A1788 VA: 0x84A5788 Slot: 10
	public override void set_Item(int index, BsonValue value) { }

	// RVA: 0x84A539C Offset: 0x84A139C VA: 0x84A539C Slot: 19
	public int get_Count() { }

	// RVA: 0x84A5880 Offset: 0x84A1880 VA: 0x84A5880 Slot: 20
	public bool get_IsReadOnly() { }

	// RVA: 0x84A3FC0 Offset: 0x849FFC0 VA: 0x84A3FC0 Slot: 21
	public void Add(BsonValue item) { }

	// RVA: -1 Offset: -1
	public void AddRange<TCollection>(TCollection collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454987C Offset: 0x454587C VA: 0x454987C
	|-BsonArray.AddRange<object>
	|
	|-RVA: 0x4549DC0 Offset: 0x4545DC0 VA: 0x4549DC0
	|-BsonArray.AddRange<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x84A5888 Offset: 0x84A1888 VA: 0x84A5888 Slot: 22
	public void Clear() { }

	// RVA: 0x84A5934 Offset: 0x84A1934 VA: 0x84A5934 Slot: 23
	public bool Contains(BsonValue item) { }

	// RVA: 0x84A5A1C Offset: 0x84A1A1C VA: 0x84A5A1C Slot: 24
	public void CopyTo(BsonValue[] array, int arrayIndex) { }

	// RVA: 0x84A5AE0 Offset: 0x84A1AE0 VA: 0x84A5AE0 Slot: 26
	public IEnumerator<BsonValue> GetEnumerator() { }

	// RVA: 0x84A5B88 Offset: 0x84A1B88 VA: 0x84A5B88 Slot: 16
	public int IndexOf(BsonValue item) { }

	// RVA: 0x84A5C70 Offset: 0x84A1C70 VA: 0x84A5C70 Slot: 17
	public void Insert(int index, BsonValue item) { }

	// RVA: 0x84A5D68 Offset: 0x84A1D68 VA: 0x84A5D68 Slot: 25
	public bool Remove(BsonValue item) { }

	// RVA: 0x84A5E1C Offset: 0x84A1E1C VA: 0x84A5E1C Slot: 18
	public void RemoveAt(int index) { }

	[IteratorStateMachine(typeof(BsonArray.<System-Collections-IEnumerable-GetEnumerator>d__26))]
	// RVA: 0x84A5ED0 Offset: 0x84A1ED0 VA: 0x84A5ED0 Slot: 27
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x84A5F64 Offset: 0x84A1F64 VA: 0x84A5F64 Slot: 11
	public override int CompareTo(BsonValue other) { }

	// RVA: 0x84A6174 Offset: 0x84A2174 VA: 0x84A6174 Slot: 13
	internal override int GetBytesCount(bool recalc) { }
}

// Namespace: UltraLiteDB
public enum BsonAutoId // TypeDefIndex: 26397
{
	// Fields
	public int value__; // 0x0
	public const BsonAutoId Int32 = 2;
	public const BsonAutoId Int64 = 3;
	public const BsonAutoId ObjectId = 10;
	public const BsonAutoId Guid = 11;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class BsonDocument.<>c // TypeDefIndex: 26398
{
	// Fields
	public static readonly BsonDocument.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, BsonValue>, bool> <>9__35_0; // 0x8

	// Methods

	// RVA: 0x84A72F8 Offset: 0x84A32F8 VA: 0x84A72F8
	private static void .cctor() { }

	// RVA: 0x84A7360 Offset: 0x84A3360 VA: 0x84A7360
	public void .ctor() { }

	// RVA: 0x84A7368 Offset: 0x84A3368 VA: 0x84A7368
	internal bool <GetElements>b__35_0(KeyValuePair<string, BsonValue> x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BsonDocument.<GetElements>d__35 : IEnumerable<KeyValuePair<string, BsonValue>>, IEnumerable, IEnumerator<KeyValuePair<string, BsonValue>>, IEnumerator, IDisposable // TypeDefIndex: 26399
{
	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, BsonValue> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	public BsonDocument <>4__this; // 0x30
	private IEnumerator<KeyValuePair<string, BsonValue>> <>7__wrap1; // 0x38

	// Properties
	private KeyValuePair<string, BsonValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,UltraLiteDB.BsonValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84A6C7C Offset: 0x84A2C7C VA: 0x84A6C7C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84A73C0 Offset: 0x84A33C0 VA: 0x84A73C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84A73DC Offset: 0x84A33DC VA: 0x84A73DC Slot: 8
	private bool MoveNext() { }

	// RVA: 0x84A7850 Offset: 0x84A3850 VA: 0x84A7850
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x84A7900 Offset: 0x84A3900 VA: 0x84A7900 Slot: 6
	private KeyValuePair<string, BsonValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,UltraLiteDB.BsonValue>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84A790C Offset: 0x84A390C VA: 0x84A790C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84A7944 Offset: 0x84A3944 VA: 0x84A7944 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84A79A0 Offset: 0x84A39A0 VA: 0x84A79A0 Slot: 4
	private IEnumerator<KeyValuePair<string, BsonValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UltraLiteDB.BsonValue>>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x84A7A44 Offset: 0x84A3A44 VA: 0x84A7A44 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UltraLiteDB
[DefaultMember("Item")]
public class BsonDocument : BsonValue, IDictionary<string, BsonValue>, ICollection<KeyValuePair<string, BsonValue>>, IEnumerable<KeyValuePair<string, BsonValue>>, IEnumerable // TypeDefIndex: 26400
{
	// Fields
	[CompilerGenerated]
	private PageAddress <RawId>k__BackingField; // 0x20
	private int _length; // 0x28

	// Properties
	internal Dictionary<string, BsonValue> RawValue { get; }
	public override BsonValue Item { get; set; }
	public ICollection<string> Keys { get; }
	public ICollection<BsonValue> Values { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x84A3718 Offset: 0x849F718 VA: 0x84A3718
	public void .ctor() { }

	// RVA: 0x84A3DC0 Offset: 0x849FDC0 VA: 0x84A3DC0
	internal Dictionary<string, BsonValue> get_RawValue() { }

	// RVA: 0x84A6758 Offset: 0x84A2758 VA: 0x84A6758 Slot: 7
	public override BsonValue get_Item(string key) { }

	// RVA: 0x84A67F0 Offset: 0x84A27F0 VA: 0x84A67F0 Slot: 8
	public override void set_Item(string key, BsonValue value) { }

	// RVA: 0x84A6898 Offset: 0x84A2898 VA: 0x84A6898 Slot: 11
	public override int CompareTo(BsonValue other) { }

	// RVA: 0x84A4A10 Offset: 0x84A0A10 VA: 0x84A4A10 Slot: 16
	public ICollection<string> get_Keys() { }

	// RVA: 0x84A6AF4 Offset: 0x84A2AF4 VA: 0x84A6AF4 Slot: 17
	public ICollection<BsonValue> get_Values() { }

	// RVA: 0x84A6B48 Offset: 0x84A2B48 VA: 0x84A6B48 Slot: 22
	public int get_Count() { }

	// RVA: 0x84A6B9C Offset: 0x84A2B9C VA: 0x84A6B9C Slot: 23
	public bool get_IsReadOnly() { }

	// RVA: 0x84A6BA4 Offset: 0x84A2BA4 VA: 0x84A6BA4 Slot: 18
	public bool ContainsKey(string key) { }

	[IteratorStateMachine(typeof(BsonDocument.<GetElements>d__35))]
	// RVA: 0x84A6C00 Offset: 0x84A2C00 VA: 0x84A6C00
	public IEnumerable<KeyValuePair<string, BsonValue>> GetElements() { }

	// RVA: 0x84A6CB0 Offset: 0x84A2CB0 VA: 0x84A6CB0 Slot: 19
	public void Add(string key, BsonValue value) { }

	// RVA: 0x84A6D58 Offset: 0x84A2D58 VA: 0x84A6D58 Slot: 20
	public bool Remove(string key) { }

	// RVA: 0x84A6DB4 Offset: 0x84A2DB4 VA: 0x84A6DB4 Slot: 25
	public void Clear() { }

	// RVA: 0x84A6E08 Offset: 0x84A2E08 VA: 0x84A6E08 Slot: 21
	public bool TryGetValue(string key, out BsonValue value) { }

	// RVA: 0x84A6E74 Offset: 0x84A2E74 VA: 0x84A6E74 Slot: 24
	public void Add(KeyValuePair<string, BsonValue> item) { }

	// RVA: 0x84A6ED4 Offset: 0x84A2ED4 VA: 0x84A6ED4 Slot: 26
	public bool Contains(KeyValuePair<string, BsonValue> item) { }

	// RVA: 0x84A6F38 Offset: 0x84A2F38 VA: 0x84A6F38 Slot: 28
	public bool Remove(KeyValuePair<string, BsonValue> item) { }

	// RVA: 0x84A6F7C Offset: 0x84A2F7C VA: 0x84A6F7C Slot: 29
	public IEnumerator<KeyValuePair<string, BsonValue>> GetEnumerator() { }

	// RVA: 0x84A7014 Offset: 0x84A3014 VA: 0x84A7014 Slot: 30
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x84A70AC Offset: 0x84A30AC VA: 0x84A70AC Slot: 27
	public void CopyTo(KeyValuePair<string, BsonValue>[] array, int arrayIndex) { }

	// RVA: 0x84A7170 Offset: 0x84A3170 VA: 0x84A7170 Slot: 13
	internal override int GetBytesCount(bool recalc) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BsonFields.<Execute>d__2 : IEnumerable<BsonValue>, IEnumerable, IEnumerator<BsonValue>, IEnumerator, IDisposable // TypeDefIndex: 26401
{
	// Fields
	private int <>1__state; // 0x10
	private BsonValue <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private BsonDocument doc; // 0x28
	public BsonDocument <>3__doc; // 0x30
	public BsonFields <>4__this; // 0x38
	private bool includeNullIfEmpty; // 0x40
	public bool <>3__includeNullIfEmpty; // 0x41
	private int <index>5__2; // 0x44

	// Properties
	private BsonValue System.Collections.Generic.IEnumerator<UltraLiteDB.BsonValue>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84A7B1C Offset: 0x84A3B1C VA: 0x84A7B1C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84A7B50 Offset: 0x84A3B50 VA: 0x84A7B50 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84A7B54 Offset: 0x84A3B54 VA: 0x84A7B54 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x84A7C78 Offset: 0x84A3C78 VA: 0x84A7C78 Slot: 6
	private BsonValue System.Collections.Generic.IEnumerator<UltraLiteDB.BsonValue>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84A7C80 Offset: 0x84A3C80 VA: 0x84A7C80 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84A7CB8 Offset: 0x84A3CB8 VA: 0x84A7CB8 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84A7CC0 Offset: 0x84A3CC0 VA: 0x84A7CC0 Slot: 4
	private IEnumerator<BsonValue> System.Collections.Generic.IEnumerable<UltraLiteDB.BsonValue>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x84A7D7C Offset: 0x84A3D7C VA: 0x84A7D7C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UltraLiteDB
public class BsonFields // TypeDefIndex: 26402
{
	// Fields
	private string Field; // 0x10

	// Methods

	// RVA: 0x84A7A48 Offset: 0x84A3A48 VA: 0x84A7A48
	public void .ctor(string field) { }

	[IteratorStateMachine(typeof(BsonFields.<Execute>d__2))]
	// RVA: 0x84A7A78 Offset: 0x84A3A78 VA: 0x84A7A78
	public IEnumerable<BsonValue> Execute(BsonDocument doc, bool includeNullIfEmpty = True) { }
}

// Namespace: UltraLiteDB
public enum BsonType // TypeDefIndex: 26403
{
	// Fields
	public int value__; // 0x0
	public const BsonType MinValue = 0;
	public const BsonType Null = 1;
	public const BsonType Int32 = 2;
	public const BsonType Int64 = 3;
	public const BsonType Double = 4;
	public const BsonType Decimal = 5;
	public const BsonType String = 6;
	public const BsonType Document = 7;
	public const BsonType Array = 8;
	public const BsonType Binary = 9;
	public const BsonType ObjectId = 10;
	public const BsonType Guid = 11;
	public const BsonType Boolean = 12;
	public const BsonType DateTime = 13;
	public const BsonType MaxValue = 14;
}

// Namespace: UltraLiteDB
[DefaultMember("Item")]
public class BsonValue : IComparable<BsonValue>, IEquatable<BsonValue> // TypeDefIndex: 26404
{
	// Fields
	public static readonly DateTime UnixEpoch; // 0x0
	public static BsonValue Null; // 0x8
	public static BsonValue MinValue; // 0x10
	public static BsonValue MaxValue; // 0x18
	[CompilerGenerated]
	private readonly BsonType <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly object <RawValue>k__BackingField; // 0x18

	// Properties
	public BsonType Type { get; }
	internal virtual object RawValue { get; }
	public virtual BsonValue Item { get; set; }
	public virtual BsonValue Item { get; set; }
	[DebuggerBrowsable(0)]
	public BsonArray AsArray { get; }
	[DebuggerBrowsable(0)]
	public BsonDocument AsDocument { get; }
	[DebuggerBrowsable(0)]
	public byte[] AsBinary { get; }
	[DebuggerBrowsable(0)]
	public bool AsBoolean { get; }
	[DebuggerBrowsable(0)]
	public string AsString { get; }
	[DebuggerBrowsable(0)]
	public int AsInt32 { get; }
	[DebuggerBrowsable(0)]
	public long AsInt64 { get; }
	[DebuggerBrowsable(0)]
	public double AsDouble { get; }
	[DebuggerBrowsable(0)]
	public Decimal AsDecimal { get; }
	[DebuggerBrowsable(0)]
	public DateTime AsDateTime { get; }
	[DebuggerBrowsable(0)]
	public ObjectId AsObjectId { get; }
	[DebuggerBrowsable(0)]
	public Guid AsGuid { get; }
	[DebuggerBrowsable(0)]
	public bool IsNull { get; }
	[DebuggerBrowsable(0)]
	public bool IsArray { get; }
	[DebuggerBrowsable(0)]
	public bool IsDocument { get; }
	[DebuggerBrowsable(0)]
	public bool IsInt32 { get; }
	[DebuggerBrowsable(0)]
	public bool IsInt64 { get; }
	[DebuggerBrowsable(0)]
	public bool IsDouble { get; }
	[DebuggerBrowsable(0)]
	public bool IsDecimal { get; }
	[DebuggerBrowsable(0)]
	public bool IsNumber { get; }
	[DebuggerBrowsable(0)]
	public bool IsString { get; }
	[DebuggerBrowsable(0)]
	public bool IsMinValue { get; }
	[DebuggerBrowsable(0)]
	public bool IsMaxValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84A7D80 Offset: 0x84A3D80 VA: 0x84A7D80
	public BsonType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x84A7D88 Offset: 0x84A3D88 VA: 0x84A7D88 Slot: 6
	internal virtual object get_RawValue() { }

	// RVA: 0x84A7D90 Offset: 0x84A3D90 VA: 0x84A7D90
	public void .ctor(int value) { }

	// RVA: 0x84A7E10 Offset: 0x84A3E10 VA: 0x84A7E10
	public void .ctor(long value) { }

	// RVA: 0x84A7E90 Offset: 0x84A3E90 VA: 0x84A7E90
	public void .ctor(double value) { }

	// RVA: 0x84A7F10 Offset: 0x84A3F10 VA: 0x84A7F10
	public void .ctor(Decimal value) { }

	// RVA: 0x84A7FC4 Offset: 0x84A3FC4 VA: 0x84A7FC4
	public void .ctor(string value) { }

	// RVA: 0x84A800C Offset: 0x84A400C VA: 0x84A800C
	public void .ctor(byte[] value) { }

	// RVA: 0x84A8054 Offset: 0x84A4054 VA: 0x84A8054
	public void .ctor(ObjectId value) { }

	// RVA: 0x84A8100 Offset: 0x84A4100 VA: 0x84A8100
	public void .ctor(Guid value) { }

	// RVA: 0x84A818C Offset: 0x84A418C VA: 0x84A818C
	public void .ctor(bool value) { }

	// RVA: 0x84A8210 Offset: 0x84A4210 VA: 0x84A8210
	public void .ctor(DateTime value) { }

	// RVA: 0x84A82A0 Offset: 0x84A42A0 VA: 0x84A82A0
	public void .ctor(BsonValue value) { }

	// RVA: 0x84A5628 Offset: 0x84A1628 VA: 0x84A5628
	protected void .ctor(BsonType type, object rawValue) { }

	// RVA: 0x84A8394 Offset: 0x84A4394 VA: 0x84A8394 Slot: 7
	public virtual BsonValue get_Item(string name) { }

	// RVA: 0x84A8424 Offset: 0x84A4424 VA: 0x84A8424 Slot: 8
	public virtual void set_Item(string name, BsonValue value) { }

	// RVA: 0x84A84B4 Offset: 0x84A44B4 VA: 0x84A84B4 Slot: 9
	public virtual BsonValue get_Item(int index) { }

	// RVA: 0x84A8544 Offset: 0x84A4544 VA: 0x84A8544 Slot: 10
	public virtual void set_Item(int index, BsonValue value) { }

	// RVA: 0x84A60FC Offset: 0x84A20FC VA: 0x84A60FC
	public BsonArray get_AsArray() { }

	// RVA: 0x84A6A7C Offset: 0x84A2A7C VA: 0x84A6A7C
	public BsonDocument get_AsDocument() { }

	// RVA: 0x84A85D4 Offset: 0x84A45D4 VA: 0x84A85D4
	public byte[] get_AsBinary() { }

	// RVA: 0x84A8628 Offset: 0x84A4628 VA: 0x84A8628
	public bool get_AsBoolean() { }

	// RVA: 0x84A86A4 Offset: 0x84A46A4 VA: 0x84A86A4
	public string get_AsString() { }

	// RVA: 0x84A870C Offset: 0x84A470C VA: 0x84A870C
	public int get_AsInt32() { }

	// RVA: 0x84A877C Offset: 0x84A477C VA: 0x84A877C
	public long get_AsInt64() { }

	// RVA: 0x84A87EC Offset: 0x84A47EC VA: 0x84A87EC
	public double get_AsDouble() { }

	// RVA: 0x84A885C Offset: 0x84A485C VA: 0x84A885C
	public Decimal get_AsDecimal() { }

	// RVA: 0x84A88CC Offset: 0x84A48CC VA: 0x84A88CC
	public DateTime get_AsDateTime() { }

	// RVA: 0x84A8948 Offset: 0x84A4948 VA: 0x84A8948
	public ObjectId get_AsObjectId() { }

	// RVA: 0x84A89CC Offset: 0x84A49CC VA: 0x84A89CC
	public Guid get_AsGuid() { }

	// RVA: 0x84A8A4C Offset: 0x84A4A4C VA: 0x84A8A4C
	public bool get_IsNull() { }

	// RVA: 0x84A8A5C Offset: 0x84A4A5C VA: 0x84A8A5C
	public bool get_IsArray() { }

	// RVA: 0x84A8A6C Offset: 0x84A4A6C VA: 0x84A8A6C
	public bool get_IsDocument() { }

	// RVA: 0x84A8A7C Offset: 0x84A4A7C VA: 0x84A8A7C
	public bool get_IsInt32() { }

	// RVA: 0x84A8A8C Offset: 0x84A4A8C VA: 0x84A8A8C
	public bool get_IsInt64() { }

	// RVA: 0x84A8A9C Offset: 0x84A4A9C VA: 0x84A8A9C
	public bool get_IsDouble() { }

	// RVA: 0x84A8AAC Offset: 0x84A4AAC VA: 0x84A8AAC
	public bool get_IsDecimal() { }

	// RVA: 0x84A8ABC Offset: 0x84A4ABC VA: 0x84A8ABC
	public bool get_IsNumber() { }

	// RVA: 0x84A8AD0 Offset: 0x84A4AD0 VA: 0x84A8AD0
	public bool get_IsString() { }

	// RVA: 0x84A8AE0 Offset: 0x84A4AE0 VA: 0x84A8AE0
	public bool get_IsMinValue() { }

	// RVA: 0x84A8AF0 Offset: 0x84A4AF0 VA: 0x84A8AF0
	public bool get_IsMaxValue() { }

	// RVA: 0x84A44BC Offset: 0x84A04BC VA: 0x84A44BC
	public static BsonValue op_Implicit(int value) { }

	// RVA: 0x84A4514 Offset: 0x84A0514 VA: 0x84A4514
	public static BsonValue op_Implicit(long value) { }

	// RVA: 0x84A40A8 Offset: 0x84A00A8 VA: 0x84A40A8
	public static BsonValue op_Implicit(double value) { }

	// RVA: 0x84A456C Offset: 0x84A056C VA: 0x84A456C
	public static BsonValue op_Implicit(Decimal value) { }

	// RVA: 0x84A8B00 Offset: 0x84A4B00 VA: 0x84A8B00
	public static BsonValue op_Implicit(ulong value) { }

	// RVA: 0x84A8B58 Offset: 0x84A4B58 VA: 0x84A8B58
	public static string op_Implicit(BsonValue value) { }

	// RVA: 0x84A4108 Offset: 0x84A0108 VA: 0x84A4108
	public static BsonValue op_Implicit(string value) { }

	// RVA: 0x84A4160 Offset: 0x84A0160 VA: 0x84A4160
	public static BsonValue op_Implicit(byte[] value) { }

	// RVA: 0x84A43B4 Offset: 0x84A03B4 VA: 0x84A43B4
	public static BsonValue op_Implicit(ObjectId value) { }

	// RVA: 0x84A41B8 Offset: 0x84A01B8 VA: 0x84A41B8
	public static BsonValue op_Implicit(Guid value) { }

	// RVA: 0x84A440C Offset: 0x84A040C VA: 0x84A440C
	public static BsonValue op_Implicit(bool value) { }

	// RVA: 0x84A4464 Offset: 0x84A0464 VA: 0x84A4464
	public static BsonValue op_Implicit(DateTime value) { }

	// RVA: 0x84A8BC8 Offset: 0x84A4BC8 VA: 0x84A8BC8 Slot: 3
	public override string ToString() { }

	// RVA: 0x84A8C40 Offset: 0x84A4C40 VA: 0x84A8C40 Slot: 11
	public virtual int CompareTo(BsonValue other) { }

	// RVA: 0x84A8CB8 Offset: 0x84A4CB8 VA: 0x84A8CB8 Slot: 12
	public virtual int CompareTo(BsonValue other, Collation collation) { }

	// RVA: 0x84A91FC Offset: 0x84A51FC VA: 0x84A91FC Slot: 5
	public bool Equals(BsonValue other) { }

	// RVA: 0x84A834C Offset: 0x84A434C VA: 0x84A834C
	public static bool op_Equality(BsonValue lhs, BsonValue rhs) { }

	// RVA: 0x84A921C Offset: 0x84A521C VA: 0x84A921C
	public static bool op_Inequality(BsonValue lhs, BsonValue rhs) { }

	// RVA: 0x84A92C4 Offset: 0x84A52C4 VA: 0x84A92C4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x84A935C Offset: 0x84A535C VA: 0x84A935C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x84A93C0 Offset: 0x84A53C0 VA: 0x84A93C0 Slot: 13
	internal virtual int GetBytesCount(bool recalc) { }

	// RVA: 0x84A630C Offset: 0x84A230C VA: 0x84A630C
	protected int GetBytesCountElement(string key, BsonValue value) { }

	// RVA: 0x84A94E4 Offset: 0x84A54E4 VA: 0x84A94E4
	private static void .cctor() { }
}

// Namespace: UltraLiteDB
public static class JsonSerializer // TypeDefIndex: 26405
{
	// Methods

	// RVA: 0x84A8BCC Offset: 0x84A4BCC VA: 0x84A8BCC
	public static string Serialize(BsonValue value) { }

	// RVA: 0x84A9650 Offset: 0x84A5650 VA: 0x84A9650
	public static void Serialize(BsonValue value, StringBuilder sb) { }
}

// Namespace: UltraLiteDB
public class JsonWriter // TypeDefIndex: 26406
{
	// Fields
	private static readonly IFormatProvider _numberFormat; // 0x0
	private TextWriter _writer; // 0x10
	private int _indent; // 0x18
	private string _spacer; // 0x20
	[CompilerGenerated]
	private int <Indent>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <Pretty>k__BackingField; // 0x2C

	// Properties
	public int Indent { get; }
	public bool Pretty { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84A9980 Offset: 0x84A5980 VA: 0x84A9980
	public int get_Indent() { }

	[CompilerGenerated]
	// RVA: 0x84A9988 Offset: 0x84A5988 VA: 0x84A9988
	public bool get_Pretty() { }

	// RVA: 0x84A9848 Offset: 0x84A5848 VA: 0x84A9848
	public void .ctor(TextWriter writer) { }

	// RVA: 0x84A98C4 Offset: 0x84A58C4 VA: 0x84A98C4
	public void Serialize(BsonValue value) { }

	// RVA: 0x84A9990 Offset: 0x84A5990 VA: 0x84A9990
	private void WriteValue(BsonValue value) { }

	// RVA: 0x84AA03C Offset: 0x84A603C VA: 0x84AA03C
	private void WriteObject(BsonDocument obj) { }

	// RVA: 0x84A9E4C Offset: 0x84A5E4C VA: 0x84A9E4C
	private void WriteArray(BsonArray arr) { }

	// RVA: 0x84AA3D8 Offset: 0x84A63D8 VA: 0x84AA3D8
	private void WriteString(string s) { }

	// RVA: 0x84AA690 Offset: 0x84A6690 VA: 0x84AA690
	private void WriteExtendDataType(string type, string value) { }

	// RVA: 0x84AA860 Offset: 0x84A6860 VA: 0x84AA860
	private void WriteKeyValue(string key, BsonValue value, bool comma) { }

	// RVA: 0x84AA7E0 Offset: 0x84A67E0 VA: 0x84AA7E0
	private void WriteStartBlock(string str, bool hasData) { }

	// RVA: 0x84AAA2C Offset: 0x84A6A2C VA: 0x84AAA2C
	private void WriteEndBlock(string str, bool hasData) { }

	// RVA: 0x84AAB10 Offset: 0x84A6B10 VA: 0x84AAB10
	private void WriteNewLine() { }

	// RVA: 0x84AAA7C Offset: 0x84A6A7C VA: 0x84AAA7C
	private void WriteIndent() { }

	// RVA: 0x84AAB44 Offset: 0x84A6B44 VA: 0x84AAB44
	private static void .cctor() { }
}

// Namespace: UltraLiteDB
public class ObjectId : IComparable<ObjectId>, IEquatable<ObjectId> // TypeDefIndex: 26407
{
	// Fields
	[CompilerGenerated]
	private readonly int <Timestamp>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <Machine>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly short <Pid>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <Increment>k__BackingField; // 0x1C
	private static int _machine; // 0x0
	private static short _pid; // 0x4
	private static int _increment; // 0x8

	// Properties
	public int Timestamp { get; }
	public int Machine { get; }
	public short Pid { get; }
	public int Increment { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84AABDC Offset: 0x84A6BDC VA: 0x84AABDC
	public int get_Timestamp() { }

	[CompilerGenerated]
	// RVA: 0x84AABE4 Offset: 0x84A6BE4 VA: 0x84AABE4
	public int get_Machine() { }

	[CompilerGenerated]
	// RVA: 0x84AABEC Offset: 0x84A6BEC VA: 0x84AABEC
	public short get_Pid() { }

	[CompilerGenerated]
	// RVA: 0x84AABF4 Offset: 0x84A6BF4 VA: 0x84AABF4
	public int get_Increment() { }

	// RVA: 0x84AABFC Offset: 0x84A6BFC VA: 0x84AABFC
	public void .ctor(int timestamp, int machine, short pid, int increment) { }

	// RVA: 0x84A4220 Offset: 0x84A0220 VA: 0x84A4220
	public void .ctor(byte[] bytes, int startIndex = 0) { }

	// RVA: 0x84AAC40 Offset: 0x84A6C40 VA: 0x84AAC40 Slot: 5
	public bool Equals(ObjectId other) { }

	// RVA: 0x84AAD6C Offset: 0x84A6D6C VA: 0x84AAD6C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x84AADEC Offset: 0x84A6DEC VA: 0x84AADEC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x84A9158 Offset: 0x84A5158 VA: 0x84A9158 Slot: 4
	public int CompareTo(ObjectId other) { }

	// RVA: 0x84AAE80 Offset: 0x84A6E80 VA: 0x84AAE80
	public void ToByteArray(byte[] bytes, int startIndex) { }

	// RVA: 0x84A55C4 Offset: 0x84A15C4 VA: 0x84A55C4
	public byte[] ToByteArray() { }

	// RVA: 0x84AAFF0 Offset: 0x84A6FF0 VA: 0x84AAFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x84A80E0 Offset: 0x84A40E0 VA: 0x84A80E0
	public static bool op_Equality(ObjectId lhs, ObjectId rhs) { }

	// RVA: 0x84AACFC Offset: 0x84A6CFC VA: 0x84AACFC
	public static bool op_Inequality(ObjectId lhs, ObjectId rhs) { }

	// RVA: 0x84AB074 Offset: 0x84A7074 VA: 0x84AB074
	private static void .cctor() { }

	// RVA: 0x84AB208 Offset: 0x84A7208 VA: 0x84AB208
	private static int GetCurrentProcessId() { }

	// RVA: 0x84AB1B0 Offset: 0x84A71B0 VA: 0x84AB1B0
	private static int GetMachineHash() { }

	// RVA: 0x84AB274 Offset: 0x84A7274 VA: 0x84AB274
	public static ObjectId NewObjectId() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileDiskService.<ReadJournal>d__21 : IEnumerable<byte[]>, IEnumerable, IEnumerator<byte[]>, IEnumerator, IDisposable // TypeDefIndex: 26408
{
	// Fields
	private int <>1__state; // 0x10
	private byte[] <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private uint lastPageID; // 0x24
	public uint <>3__lastPageID; // 0x28
	public FileDiskService <>4__this; // 0x30
	private long <pos>5__2; // 0x38
	private byte[] <buffer>5__3; // 0x40

	// Properties
	private byte[] System.Collections.Generic.IEnumerator<System.Byte[]>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84ACB7C Offset: 0x84A8B7C VA: 0x84ACB7C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84ACCB4 Offset: 0x84A8CB4 VA: 0x84ACCB4 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84ACCB8 Offset: 0x84A8CB8 VA: 0x84ACCB8 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x84ACE44 Offset: 0x84A8E44 VA: 0x84ACE44 Slot: 6
	private byte[] System.Collections.Generic.IEnumerator<System.Byte[]>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84ACE4C Offset: 0x84A8E4C VA: 0x84ACE4C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84ACE84 Offset: 0x84A8E84 VA: 0x84ACE84 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84ACE8C Offset: 0x84A8E8C VA: 0x84ACE8C Slot: 4
	private IEnumerator<byte[]> System.Collections.Generic.IEnumerable<System.Byte[]>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x84ACF38 Offset: 0x84A8F38 VA: 0x84ACF38 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileDiskService.<>c__DisplayClass24_0 // TypeDefIndex: 26409
{
	// Fields
	public string path; // 0x10
	public FileMode mode; // 0x18
	public FileAccess access; // 0x1C
	public FileShare share; // 0x20

	// Methods

	// RVA: 0x84ACCAC Offset: 0x84A8CAC VA: 0x84ACCAC
	public void .ctor() { }

	// RVA: 0x84ACF3C Offset: 0x84A8F3C VA: 0x84ACF3C
	internal FileStream <CreateFileStream>b__0() { }
}

// Namespace: UltraLiteDB
public class FileDiskService : IDiskService, IDisposable // TypeDefIndex: 26410
{
	// Fields
	private FileStream _stream; // 0x10
	private string _filename; // 0x18
	private Logger _log; // 0x20
	private FileOptions _options; // 0x28
	private Random _lockReadRand; // 0x30

	// Properties
	public bool IsJournalEnabled { get; }

	// Methods

	// RVA: 0x84A3040 Offset: 0x849F040 VA: 0x84A3040
	public void .ctor(string filename, FileOptions options) { }

	// RVA: 0x84AB408 Offset: 0x84A7408 VA: 0x84AB408 Slot: 4
	public void Initialize(Logger log, string password) { }

	// RVA: 0x84ABAEC Offset: 0x84A7AEC VA: 0x84ABAEC Slot: 14
	public virtual void Dispose() { }

	// RVA: 0x84ABC34 Offset: 0x84A7C34 VA: 0x84ABC34 Slot: 15
	public virtual byte[] ReadPage(uint pageID) { }

	// RVA: 0x84ABF6C Offset: 0x84A7F6C VA: 0x84ABF6C Slot: 16
	public virtual void WritePage(uint pageID, byte[] buffer) { }

	// RVA: 0x84AC170 Offset: 0x84A8170 VA: 0x84AC170 Slot: 7
	public void SetLength(long fileSize) { }

	// RVA: 0x84AC1D8 Offset: 0x84A81D8 VA: 0x84AC1D8 Slot: 8
	public bool get_IsJournalEnabled() { }

	// RVA: 0x84AC1F4 Offset: 0x84A81F4 VA: 0x84AC1F4 Slot: 10
	public void WriteJournal(ICollection<byte[]> pages, uint lastPageID) { }

	[IteratorStateMachine(typeof(FileDiskService.<ReadJournal>d__21))]
	// RVA: 0x84ACAF0 Offset: 0x84A8AF0 VA: 0x84ACAF0 Slot: 9
	public IEnumerable<byte[]> ReadJournal(uint lastPageID) { }

	// RVA: 0x84ACBB0 Offset: 0x84A8BB0 VA: 0x84ACBB0 Slot: 11
	public void ClearJournal(uint lastPageID) { }

	// RVA: 0x84ACA0C Offset: 0x84A8A0C VA: 0x84ACA0C Slot: 12
	public void Flush() { }

	// RVA: 0x84AB63C Offset: 0x84A763C VA: 0x84AB63C
	private FileStream CreateFileStream(string path, FileMode mode, FileAccess access, FileShare share) { }
}

// Namespace: UltraLiteDB
public interface IDiskService : IDisposable // TypeDefIndex: 26411
{
	// Properties
	public abstract bool IsJournalEnabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize(Logger log, string password);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte[] ReadPage(uint pageID);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void WritePage(uint pageID, byte[] buffer);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetLength(long fileSize);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsJournalEnabled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IEnumerable<byte[]> ReadJournal(uint lastPageID);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void WriteJournal(ICollection<byte[]> pages, uint lastPageID);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ClearJournal(uint lastPageID);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Flush();
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass3_0 // TypeDefIndex: 26412
{
	// Fields
	public UltraLiteEngine <>4__this; // 0x10
	public Query query; // 0x18

	// Methods

	// RVA: 0x84AD74C Offset: 0x84A974C VA: 0x84AD74C
	public void .ctor() { }

	// RVA: 0x84B1354 Offset: 0x84AD354 VA: 0x84B1354
	internal BsonDocument <Exists>b__0(IndexNode x) { }

	// RVA: 0x84B13C4 Offset: 0x84AD3C4 VA: 0x84B13C4
	internal bool <Exists>b__1(BsonDocument x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass5_0 // TypeDefIndex: 26413
{
	// Fields
	public UltraLiteEngine <>4__this; // 0x10
	public string collection; // 0x18

	// Methods

	// RVA: 0x84AD754 Offset: 0x84A9754 VA: 0x84AD754
	public void .ctor() { }

	// RVA: 0x84B13E4 Offset: 0x84AD3E4 VA: 0x84B13E4
	internal bool <DropCollection>b__0(CollectionPage col) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass8_0 // TypeDefIndex: 26414
{
	// Fields
	public UltraLiteEngine <>4__this; // 0x10
	public string collection; // 0x18
	public Query query; // 0x20

	// Methods

	// RVA: 0x84AD8F0 Offset: 0x84A98F0 VA: 0x84AD8F0
	public void .ctor() { }

	// RVA: 0x84B1E24 Offset: 0x84ADE24 VA: 0x84B1E24
	internal int <Delete>b__0(CollectionPage col) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<Find>d__9 : IEnumerable<BsonDocument>, IEnumerable, IEnumerator<BsonDocument>, IEnumerator, IDisposable // TypeDefIndex: 26415
{
	// Fields
	private int <>1__state; // 0x10
	private BsonDocument <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private string collection; // 0x28
	public string <>3__collection; // 0x30
	private Query query; // 0x38
	public Query <>3__query; // 0x40
	public UltraLiteEngine <>4__this; // 0x48
	private int skip; // 0x50
	public int <>3__skip; // 0x54
	private int limit; // 0x58
	public int <>3__limit; // 0x5C
	private QueryCursor <cursor>5__2; // 0x60
	private List.Enumerator<BsonDocument> <>7__wrap2; // 0x68

	// Properties
	private BsonDocument System.Collections.Generic.IEnumerator<UltraLiteDB.BsonDocument>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84AD9BC Offset: 0x84A99BC VA: 0x84AD9BC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84B2828 Offset: 0x84AE828 VA: 0x84B2828 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84B2914 Offset: 0x84AE914 VA: 0x84B2914 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x84B345C Offset: 0x84AF45C VA: 0x84B345C
	private void <>m__Finally1() { }

	// RVA: 0x84B33BC Offset: 0x84AF3BC VA: 0x84B33BC
	private void <>m__Finally2() { }

	// RVA: 0x84B340C Offset: 0x84AF40C VA: 0x84B340C
	private void <>m__Finally3() { }

	[DebuggerHidden]
	// RVA: 0x84B350C Offset: 0x84AF50C VA: 0x84B350C Slot: 6
	private BsonDocument System.Collections.Generic.IEnumerator<UltraLiteDB.BsonDocument>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84B3514 Offset: 0x84AF514 VA: 0x84B3514 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84B354C Offset: 0x84AF54C VA: 0x84B354C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84B3554 Offset: 0x84AF554 VA: 0x84B3554 Slot: 4
	private IEnumerator<BsonDocument> System.Collections.Generic.IEnumerable<UltraLiteDB.BsonDocument>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x84B3628 Offset: 0x84AF628 VA: 0x84B3628 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass18_0 // TypeDefIndex: 26416
{
	// Fields
	public IEnumerable<BsonDocument> docs; // 0x10
	public UltraLiteEngine <>4__this; // 0x18
	public BsonAutoId autoId; // 0x20

	// Methods

	// RVA: 0x84ADCE4 Offset: 0x84A9CE4 VA: 0x84ADCE4
	public void .ctor() { }

	// RVA: 0x84B362C Offset: 0x84AF62C VA: 0x84B362C
	internal int <Insert>b__0(CollectionPage col) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass24_0 // TypeDefIndex: 26417
{
	// Fields
	public IEnumerable<BsonDocument> docs; // 0x10
	public UltraLiteEngine <>4__this; // 0x18

	// Methods

	// RVA: 0x84AEC88 Offset: 0x84AAC88 VA: 0x84AEC88
	public void .ctor() { }

	// RVA: 0x84B3958 Offset: 0x84AF958 VA: 0x84B3958
	internal int <Update>b__0(CollectionPage col) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass25_0 // TypeDefIndex: 26418
{
	// Fields
	public IndexNode[] allNodes; // 0x10

	// Methods

	// RVA: 0x84AF578 Offset: 0x84AB578 VA: 0x84AF578
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass25_1 // TypeDefIndex: 26419
{
	// Fields
	public CollectionIndex index; // 0x10
	public UltraLiteEngine.<>c__DisplayClass25_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x84AF9D0 Offset: 0x84AB9D0 VA: 0x84AF9D0
	public void .ctor() { }

	// RVA: 0x84B3C98 Offset: 0x84AFC98 VA: 0x84B3C98
	internal bool <UpdateDocument>b__1(BsonValue x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass25_2 // TypeDefIndex: 26420
{
	// Fields
	public BsonValue[] keys; // 0x10
	public UltraLiteEngine.<>c__DisplayClass25_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x84AF9D8 Offset: 0x84AB9D8 VA: 0x84AF9D8
	public void .ctor() { }

	// RVA: 0x84B3DA4 Offset: 0x84AFDA4 VA: 0x84B3DA4
	internal bool <UpdateDocument>b__0(IndexNode x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass25_3 // TypeDefIndex: 26421
{
	// Fields
	public IndexNode x; // 0x10

	// Methods

	// RVA: 0x84B3EC4 Offset: 0x84AFEC4 VA: 0x84B3EC4
	public void .ctor() { }

	// RVA: 0x84B3ECC Offset: 0x84AFECC VA: 0x84B3ECC
	internal bool <UpdateDocument>b__2(BsonValue k) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass25_4 // TypeDefIndex: 26422
{
	// Fields
	public BsonValue x; // 0x10
	public UltraLiteEngine.<>c__DisplayClass25_1 CS$<>8__locals3; // 0x18

	// Methods

	// RVA: 0x84B3D9C Offset: 0x84AFD9C VA: 0x84B3D9C
	public void .ctor() { }

	// RVA: 0x84B3F78 Offset: 0x84AFF78 VA: 0x84B3F78
	internal bool <UpdateDocument>b__3(IndexNode k) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UltraLiteEngine.<>c__DisplayClass27_0 // TypeDefIndex: 26423
{
	// Fields
	public IEnumerable<BsonDocument> docs; // 0x10
	public UltraLiteEngine <>4__this; // 0x18
	public BsonAutoId autoId; // 0x20

	// Methods

	// RVA: 0x84AFF2C Offset: 0x84ABF2C VA: 0x84AFF2C
	public void .ctor() { }

	// RVA: 0x84B404C Offset: 0x84B004C VA: 0x84B404C
	internal int <Upsert>b__0(CollectionPage col) { }
}

// Namespace: UltraLiteDB
public class UltraLiteEngine : IDisposable // TypeDefIndex: 26424
{
	// Fields
	private Logger _log; // 0x10
	private IDiskService _disk; // 0x18
	private CacheService _cache; // 0x20
	private PageService _pager; // 0x28
	private TransactionService _trans; // 0x30
	private IndexService _indexer; // 0x38
	private DataService _data; // 0x40
	private CollectionService _collections; // 0x48
	private AesEncryption _crypto; // 0x50
	private int _cacheSize; // 0x58
	private TimeSpan _timeout; // 0x60

	// Methods

	// RVA: 0x84ACFBC Offset: 0x84A8FBC VA: 0x84ACFBC
	public BsonValue Max(string collection, string field) { }

	// RVA: 0x84AD4C4 Offset: 0x84A94C4 VA: 0x84AD4C4
	public bool Exists(string collection, Query query) { }

	// RVA: 0x84A2B3C Offset: 0x849EB3C VA: 0x84A2B3C
	public IEnumerable<string> GetCollectionNames() { }

	// RVA: 0x84A2C8C Offset: 0x849EC8C VA: 0x84A2C8C
	public bool DropCollection(string collection) { }

	// RVA: 0x84AD75C Offset: 0x84A975C VA: 0x84AD75C
	public int Delete(string collection, Query query) { }

	[IteratorStateMachine(typeof(UltraLiteEngine.<Find>d__9))]
	// RVA: 0x84AD8F8 Offset: 0x84A98F8 VA: 0x84AD8F8
	public IEnumerable<BsonDocument> Find(string collection, Query query, int skip = 0, int limit = 2147483647) { }

	// RVA: 0x84AD9F0 Offset: 0x84A99F0 VA: 0x84AD9F0
	public BsonValue Insert(string collection, BsonDocument doc, BsonAutoId autoId = 10) { }

	// RVA: 0x84ADB54 Offset: 0x84A9B54 VA: 0x84ADB54
	public int Insert(string collection, IEnumerable<BsonDocument> docs, BsonAutoId autoId = 10) { }

	// RVA: 0x84ADCEC Offset: 0x84A9CEC VA: 0x84ADCEC
	private void InsertDocument(CollectionPage col, BsonDocument doc, BsonAutoId autoId) { }

	// RVA: 0x84AEB0C Offset: 0x84AAB0C VA: 0x84AEB0C
	public int Update(string collection, IEnumerable<BsonDocument> docs) { }

	// RVA: 0x84AEC90 Offset: 0x84AAC90 VA: 0x84AEC90
	private bool UpdateDocument(CollectionPage col, BsonDocument doc) { }

	// RVA: 0x84AFC54 Offset: 0x84ABC54 VA: 0x84AFC54
	public bool Upsert(string collection, BsonDocument doc, BsonAutoId autoId = 10) { }

	// RVA: 0x84AFD9C Offset: 0x84ABD9C VA: 0x84AFD9C
	public int Upsert(string collection, IEnumerable<BsonDocument> docs, BsonAutoId autoId = 10) { }

	// RVA: 0x84A317C Offset: 0x849F17C VA: 0x84A317C
	public void .ctor(IDiskService disk, string password, Nullable<TimeSpan> timeout, int cacheSize = 5000, Logger log, bool utcDate = False) { }

	// RVA: 0x84B0028 Offset: 0x84AC028 VA: 0x84B0028
	private void InitializeServices() { }

	// RVA: 0x84AD130 Offset: 0x84A9130 VA: 0x84AD130
	private CollectionPage GetCollectionPage(string name, bool addIfNotExits) { }

	// RVA: -1 Offset: -1
	private T Transaction<T>(string collection, bool addIfNotExists, Func<CollectionPage, T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x473C5B4 Offset: 0x47385B4 VA: 0x473C5B4
	|-UltraLiteEngine.Transaction<bool>
	|
	|-RVA: 0x473C748 Offset: 0x4738748 VA: 0x473C748
	|-UltraLiteEngine.Transaction<int>
	|
	|-RVA: 0x473C8DC Offset: 0x47388DC VA: 0x473C8DC
	|-UltraLiteEngine.Transaction<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x84A2E6C Offset: 0x849EE6C VA: 0x84A2E6C Slot: 4
	public void Dispose() { }

	// RVA: 0x84AB81C Offset: 0x84A781C VA: 0x84AB81C
	public static void CreateDatabase(Stream stream, string password, long initialSize = 0) { }
}

// Namespace: UltraLiteDB
public enum PageType // TypeDefIndex: 26425
{
	// Fields
	public int value__; // 0x0
	public const PageType Empty = 0;
	public const PageType Header = 1;
	public const PageType Collection = 2;
	public const PageType Index = 3;
	public const PageType Data = 4;
	public const PageType Extend = 5;
}

// Namespace: UltraLiteDB
internal abstract class BasePage // TypeDefIndex: 26426
{
	// Fields
	[CompilerGenerated]
	private uint <PageID>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <PrevPageID>k__BackingField; // 0x14
	[CompilerGenerated]
	private uint <NextPageID>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <ItemCount>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <FreeBytes>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte[] <DiskData>k__BackingField; // 0x28

	// Properties
	public uint PageID { get; set; }
	public abstract PageType PageType { get; }
	public uint PrevPageID { get; set; }
	public uint NextPageID { get; set; }
	public int ItemCount { get; set; }
	public int FreeBytes { get; set; }
	public bool IsDirty { get; set; }
	public byte[] DiskData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84B4458 Offset: 0x84B0458 VA: 0x84B4458
	public uint get_PageID() { }

	[CompilerGenerated]
	// RVA: 0x84B4460 Offset: 0x84B0460 VA: 0x84B4460
	public void set_PageID(uint value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract PageType get_PageType();

	[CompilerGenerated]
	// RVA: 0x84B4468 Offset: 0x84B0468 VA: 0x84B4468
	public uint get_PrevPageID() { }

	[CompilerGenerated]
	// RVA: 0x84B4470 Offset: 0x84B0470 VA: 0x84B4470
	public void set_PrevPageID(uint value) { }

	[CompilerGenerated]
	// RVA: 0x84B4478 Offset: 0x84B0478 VA: 0x84B4478
	public uint get_NextPageID() { }

	[CompilerGenerated]
	// RVA: 0x84B4480 Offset: 0x84B0480 VA: 0x84B4480
	public void set_NextPageID(uint value) { }

	[CompilerGenerated]
	// RVA: 0x84B4488 Offset: 0x84B0488 VA: 0x84B4488
	public int get_ItemCount() { }

	[CompilerGenerated]
	// RVA: 0x84B4490 Offset: 0x84B0490 VA: 0x84B4490
	public void set_ItemCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x84B4498 Offset: 0x84B0498 VA: 0x84B4498
	public int get_FreeBytes() { }

	[CompilerGenerated]
	// RVA: 0x84B44A0 Offset: 0x84B04A0 VA: 0x84B44A0
	public void set_FreeBytes(int value) { }

	[CompilerGenerated]
	// RVA: 0x84B44A8 Offset: 0x84B04A8 VA: 0x84B44A8
	public bool get_IsDirty() { }

	[CompilerGenerated]
	// RVA: 0x84B44B0 Offset: 0x84B04B0 VA: 0x84B44B0
	public void set_IsDirty(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84B44BC Offset: 0x84B04BC VA: 0x84B44BC
	public byte[] get_DiskData() { }

	[CompilerGenerated]
	// RVA: 0x84B44C4 Offset: 0x84B04C4 VA: 0x84B44C4
	public void set_DiskData(byte[] value) { }

	// RVA: 0x84B44CC Offset: 0x84B04CC VA: 0x84B44CC
	public void .ctor(uint pageID) { }

	// RVA: 0x84ABF2C Offset: 0x84A7F2C VA: 0x84ABF2C
	public static long GetSizeOfPages(uint pageCount) { }

	// RVA: 0x84AC96C Offset: 0x84A896C VA: 0x84AC96C
	public static long GetSizeOfPages(int pageCount) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>(uint pageID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x453AA8C Offset: 0x4536A8C VA: 0x453AA8C
	|-BasePage.CreateInstance<object>
	*/

	// RVA: 0x84B454C Offset: 0x84B054C VA: 0x84B454C
	public static BasePage CreateInstance(uint pageID, PageType pageType) { }

	// RVA: 0x84AFF34 Offset: 0x84ABF34 VA: 0x84AFF34
	public static BasePage ReadPage(byte[] buffer) { }

	// RVA: 0x84B128C Offset: 0x84AD28C VA: 0x84B128C
	public byte[] WritePage() { }

	// RVA: 0x84B4990 Offset: 0x84B0990 VA: 0x84B4990
	private void ReadHeader(ByteReader reader) { }

	// RVA: 0x84B4A08 Offset: 0x84B0A08 VA: 0x84B4A08
	private void WriteHeader(ByteWriter writer) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void ReadContent(ByteReader reader);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void WriteContent(ByteWriter writer);
}

// Namespace: 
[CompilerGenerated]
private sealed class CollectionPage.<>c__DisplayClass25_0 // TypeDefIndex: 26427
{
	// Fields
	public string field; // 0x10

	// Methods

	// RVA: 0x84B4F48 Offset: 0x84B0F48 VA: 0x84B4F48
	public void .ctor() { }

	// RVA: 0x84B4FF8 Offset: 0x84B0FF8 VA: 0x84B4FF8
	internal bool <GetIndex>b__0(CollectionIndex x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CollectionPage.<>c__DisplayClass28_0 // TypeDefIndex: 26428
{
	// Fields
	public bool includePK; // 0x10

	// Methods

	// RVA: 0x84B4F50 Offset: 0x84B0F50 VA: 0x84B4F50
	public void .ctor() { }

	// RVA: 0x84B501C Offset: 0x84B101C VA: 0x84B501C
	internal bool <GetIndexes>b__0(CollectionIndex x) { }
}

// Namespace: UltraLiteDB
internal class CollectionPage : BasePage // TypeDefIndex: 26429
{
	// Fields
	public static Regex NamePattern; // 0x0
	[CompilerGenerated]
	private string <CollectionName>k__BackingField; // 0x30
	public uint FreeDataPageID; // 0x38
	[CompilerGenerated]
	private long <DocumentCount>k__BackingField; // 0x40
	[CompilerGenerated]
	private CollectionIndex[] <Indexes>k__BackingField; // 0x48
	[CompilerGenerated]
	private long <Sequence>k__BackingField; // 0x50

	// Properties
	public override PageType PageType { get; }
	public string CollectionName { get; set; }
	public long DocumentCount { get; set; }
	public CollectionIndex[] Indexes { get; set; }
	public long Sequence { get; set; }
	public CollectionIndex PK { get; }

	// Methods

	// RVA: 0x84B4AA8 Offset: 0x84B0AA8 VA: 0x84B4AA8 Slot: 4
	public override PageType get_PageType() { }

	[CompilerGenerated]
	// RVA: 0x84B4AB0 Offset: 0x84B0AB0 VA: 0x84B4AB0
	public string get_CollectionName() { }

	[CompilerGenerated]
	// RVA: 0x84B4AB8 Offset: 0x84B0AB8 VA: 0x84B4AB8
	public void set_CollectionName(string value) { }

	[CompilerGenerated]
	// RVA: 0x84B4AC0 Offset: 0x84B0AC0 VA: 0x84B4AC0
	public long get_DocumentCount() { }

	[CompilerGenerated]
	// RVA: 0x84B4AC8 Offset: 0x84B0AC8 VA: 0x84B4AC8
	public void set_DocumentCount(long value) { }

	[CompilerGenerated]
	// RVA: 0x84B4AD0 Offset: 0x84B0AD0 VA: 0x84B4AD0
	public CollectionIndex[] get_Indexes() { }

	[CompilerGenerated]
	// RVA: 0x84B4AD8 Offset: 0x84B0AD8 VA: 0x84B4AD8
	public void set_Indexes(CollectionIndex[] value) { }

	[CompilerGenerated]
	// RVA: 0x84B4AE0 Offset: 0x84B0AE0 VA: 0x84B4AE0
	public long get_Sequence() { }

	[CompilerGenerated]
	// RVA: 0x84B4AE8 Offset: 0x84B0AE8 VA: 0x84B4AE8
	public void set_Sequence(long value) { }

	// RVA: 0x84B46B0 Offset: 0x84B06B0 VA: 0x84B46B0
	public void .ctor(uint pageID) { }

	// RVA: 0x84B4B0C Offset: 0x84B0B0C VA: 0x84B4B0C Slot: 5
	protected override void ReadContent(ByteReader reader) { }

	// RVA: 0x84B4CD4 Offset: 0x84B0CD4 VA: 0x84B4CD4 Slot: 6
	protected override void WriteContent(ByteWriter writer) { }

	// RVA: 0x84B4E90 Offset: 0x84B0E90 VA: 0x84B4E90
	public CollectionIndex GetFreeIndex() { }

	// RVA: 0x84AD244 Offset: 0x84A9244 VA: 0x84AD244
	public CollectionIndex GetIndex(string field) { }

	// RVA: 0x84AE994 Offset: 0x84AA994 VA: 0x84AE994
	public CollectionIndex get_PK() { }

	// RVA: 0x84AEA34 Offset: 0x84AAA34 VA: 0x84AEA34
	public IEnumerable<CollectionIndex> GetIndexes(bool includePK) { }

	// RVA: 0x84B4F58 Offset: 0x84B0F58 VA: 0x84B4F58
	private static void .cctor() { }
}

// Namespace: UltraLiteDB
internal class DataPage : BasePage // TypeDefIndex: 26430
{
	// Fields
	private Dictionary<ushort, DataBlock> _dataBlocks; // 0x30

	// Properties
	public override PageType PageType { get; }
	public int BlocksCount { get; }

	// Methods

	// RVA: 0x84B506C Offset: 0x84B106C VA: 0x84B506C Slot: 4
	public override PageType get_PageType() { }

	// RVA: 0x84B4894 Offset: 0x84B0894 VA: 0x84B4894
	public void .ctor(uint pageID) { }

	// RVA: 0x84B5074 Offset: 0x84B1074 VA: 0x84B5074
	public DataBlock GetBlock(ushort index) { }

	// RVA: 0x84B50CC Offset: 0x84B10CC VA: 0x84B50CC
	public void AddBlock(DataBlock block) { }

	// RVA: 0x84B51B8 Offset: 0x84B11B8 VA: 0x84B51B8
	public void UpdateBlockData(DataBlock block, byte[] data) { }

	// RVA: 0x84B51FC Offset: 0x84B11FC VA: 0x84B51FC
	public void DeleteBlock(DataBlock block) { }

	// RVA: 0x84B5280 Offset: 0x84B1280 VA: 0x84B5280
	public int get_BlocksCount() { }

	// RVA: 0x84B52D0 Offset: 0x84B12D0 VA: 0x84B52D0 Slot: 5
	protected override void ReadContent(ByteReader reader) { }

	// RVA: 0x84B54E8 Offset: 0x84B14E8 VA: 0x84B54E8 Slot: 6
	protected override void WriteContent(ByteWriter writer) { }
}

// Namespace: UltraLiteDB
internal class EmptyPage : BasePage // TypeDefIndex: 26431
{
	// Properties
	public override PageType PageType { get; }

	// Methods

	// RVA: 0x84B56C0 Offset: 0x84B16C0 VA: 0x84B56C0 Slot: 4
	public override PageType get_PageType() { }

	// RVA: 0x84B1334 Offset: 0x84AD334 VA: 0x84B1334
	public void .ctor(uint pageID) { }

	// RVA: 0x84B56C8 Offset: 0x84B16C8 VA: 0x84B56C8 Slot: 5
	protected override void ReadContent(ByteReader reader) { }

	// RVA: 0x84B56CC Offset: 0x84B16CC VA: 0x84B56CC Slot: 6
	protected override void WriteContent(ByteWriter writer) { }
}

// Namespace: UltraLiteDB
internal class ExtendPage : BasePage // TypeDefIndex: 26432
{
	// Fields
	private byte[] _data; // 0x30

	// Properties
	public override PageType PageType { get; }

	// Methods

	// RVA: 0x84B56D0 Offset: 0x84B16D0 VA: 0x84B56D0 Slot: 4
	public override PageType get_PageType() { }

	// RVA: 0x84B4920 Offset: 0x84B0920 VA: 0x84B4920
	public void .ctor(uint pageID) { }

	// RVA: 0x84B56D8 Offset: 0x84B16D8 VA: 0x84B56D8
	public void SetData(byte[] data, int offset, int length) { }

	// RVA: 0x84B5774 Offset: 0x84B1774 VA: 0x84B5774
	public byte[] GetData() { }

	// RVA: 0x84B577C Offset: 0x84B177C VA: 0x84B577C Slot: 5
	protected override void ReadContent(ByteReader reader) { }

	// RVA: 0x84B57B4 Offset: 0x84B17B4 VA: 0x84B57B4 Slot: 6
	protected override void WriteContent(ByteWriter writer) { }
}

// Namespace: UltraLiteDB
internal class HeaderPage : BasePage // TypeDefIndex: 26433
{
	// Fields
	[CompilerGenerated]
	private ushort <ChangeID>k__BackingField; // 0x30
	public uint FreeEmptyPageID; // 0x34
	[CompilerGenerated]
	private uint <LastPageID>k__BackingField; // 0x38
	[CompilerGenerated]
	private ushort <UserVersion>k__BackingField; // 0x3C
	[CompilerGenerated]
	private byte[] <Password>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte[] <Salt>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <Recovery>k__BackingField; // 0x50
	[CompilerGenerated]
	private Dictionary<string, uint> <CollectionPages>k__BackingField; // 0x58

	// Properties
	public override PageType PageType { get; }
	public ushort ChangeID { get; set; }
	public uint LastPageID { get; set; }
	public ushort UserVersion { get; set; }
	public byte[] Password { get; set; }
	public byte[] Salt { get; set; }
	public bool Recovery { get; set; }
	public Dictionary<string, uint> CollectionPages { get; set; }

	// Methods

	// RVA: 0x84B57D8 Offset: 0x84B17D8 VA: 0x84B57D8 Slot: 4
	public override PageType get_PageType() { }

	[CompilerGenerated]
	// RVA: 0x84B57E0 Offset: 0x84B17E0 VA: 0x84B57E0
	public ushort get_ChangeID() { }

	[CompilerGenerated]
	// RVA: 0x84B57E8 Offset: 0x84B17E8 VA: 0x84B57E8
	public void set_ChangeID(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x84B57F0 Offset: 0x84B17F0 VA: 0x84B57F0
	public uint get_LastPageID() { }

	[CompilerGenerated]
	// RVA: 0x84B57F8 Offset: 0x84B17F8 VA: 0x84B57F8
	public void set_LastPageID(uint value) { }

	[CompilerGenerated]
	// RVA: 0x84B5800 Offset: 0x84B1800 VA: 0x84B5800
	public ushort get_UserVersion() { }

	[CompilerGenerated]
	// RVA: 0x84B5808 Offset: 0x84B1808 VA: 0x84B5808
	public void set_UserVersion(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x84B5810 Offset: 0x84B1810 VA: 0x84B5810
	public byte[] get_Password() { }

	[CompilerGenerated]
	// RVA: 0x84B5818 Offset: 0x84B1818 VA: 0x84B5818
	public void set_Password(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x84B5820 Offset: 0x84B1820 VA: 0x84B5820
	public byte[] get_Salt() { }

	[CompilerGenerated]
	// RVA: 0x84B5828 Offset: 0x84B1828 VA: 0x84B5828
	public void set_Salt(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x84B5830 Offset: 0x84B1830 VA: 0x84B5830
	public bool get_Recovery() { }

	[CompilerGenerated]
	// RVA: 0x84B5838 Offset: 0x84B1838 VA: 0x84B5838
	public void set_Recovery(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84B5844 Offset: 0x84B1844 VA: 0x84B5844
	public Dictionary<string, uint> get_CollectionPages() { }

	[CompilerGenerated]
	// RVA: 0x84B584C Offset: 0x84B184C VA: 0x84B584C
	public void set_CollectionPages(Dictionary<string, uint> value) { }

	// RVA: 0x84B1138 Offset: 0x84AD138 VA: 0x84B1138
	public void .ctor() { }

	// RVA: 0x84B5854 Offset: 0x84B1854 VA: 0x84B5854 Slot: 5
	protected override void ReadContent(ByteReader reader) { }

	// RVA: 0x84B5A48 Offset: 0x84B1A48 VA: 0x84B5A48 Slot: 6
	protected override void WriteContent(ByteWriter writer) { }
}

// Namespace: UltraLiteDB
internal class IndexPage : BasePage // TypeDefIndex: 26434
{
	// Fields
	private Dictionary<ushort, IndexNode> _nodes; // 0x30

	// Properties
	public override PageType PageType { get; }
	public int NodesCount { get; }

	// Methods

	// RVA: 0x84B5CE8 Offset: 0x84B1CE8 VA: 0x84B5CE8 Slot: 4
	public override PageType get_PageType() { }

	// RVA: 0x84B4808 Offset: 0x84B0808 VA: 0x84B4808
	public void .ctor(uint pageID) { }

	// RVA: 0x84B5CF0 Offset: 0x84B1CF0 VA: 0x84B5CF0
	public IndexNode GetNode(ushort index) { }

	// RVA: 0x84B5D48 Offset: 0x84B1D48 VA: 0x84B5D48
	public void AddNode(IndexNode node) { }

	// RVA: 0x84B5E40 Offset: 0x84B1E40 VA: 0x84B5E40
	public void DeleteNode(IndexNode node) { }

	// RVA: 0x84B5ED0 Offset: 0x84B1ED0 VA: 0x84B5ED0
	public int get_NodesCount() { }

	// RVA: 0x84B5F20 Offset: 0x84B1F20 VA: 0x84B5F20 Slot: 5
	protected override void ReadContent(ByteReader reader) { }

	// RVA: 0x84B62E8 Offset: 0x84B22E8 VA: 0x84B62E8 Slot: 6
	protected override void WriteContent(ByteWriter writer) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Query.<>c // TypeDefIndex: 26435
{
	// Fields
	public static readonly Query.<>c <>9; // 0x0
	public static Func<IndexNode, PageAddress> <>9__39_0; // 0x8

	// Methods

	// RVA: 0x84B6A0C Offset: 0x84B2A0C VA: 0x84B6A0C
	private static void .cctor() { }

	// RVA: 0x84B6A74 Offset: 0x84B2A74 VA: 0x84B6A74
	public void .ctor() { }

	// RVA: 0x84B6A7C Offset: 0x84B2A7C VA: 0x84B6A7C
	internal PageAddress <Run>b__39_0(IndexNode x) { }
}

// Namespace: UltraLiteDB
public abstract class Query // TypeDefIndex: 26436
{
	// Fields
	[CompilerGenerated]
	private string <Field>k__BackingField; // 0x10
	[CompilerGenerated]
	private BsonFields <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <UseIndex>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <UseFilter>k__BackingField; // 0x21

	// Properties
	public string Field { get; set; }
	internal BsonFields Expression { get; set; }
	internal virtual bool UseIndex { get; set; }
	internal virtual bool UseFilter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84B65A4 Offset: 0x84B25A4 VA: 0x84B65A4
	public string get_Field() { }

	[CompilerGenerated]
	// RVA: 0x84B65AC Offset: 0x84B25AC VA: 0x84B65AC
	private void set_Field(string value) { }

	[CompilerGenerated]
	// RVA: 0x84B65B4 Offset: 0x84B25B4 VA: 0x84B65B4
	internal BsonFields get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x84B65BC Offset: 0x84B25BC VA: 0x84B65BC
	internal void set_Expression(BsonFields value) { }

	[CompilerGenerated]
	// RVA: 0x84B65C4 Offset: 0x84B25C4 VA: 0x84B65C4 Slot: 4
	internal virtual bool get_UseIndex() { }

	[CompilerGenerated]
	// RVA: 0x84B65CC Offset: 0x84B25CC VA: 0x84B65CC Slot: 5
	internal virtual void set_UseIndex(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84B65D8 Offset: 0x84B25D8 VA: 0x84B65D8 Slot: 6
	internal virtual bool get_UseFilter() { }

	[CompilerGenerated]
	// RVA: 0x84B65E0 Offset: 0x84B25E0 VA: 0x84B65E0 Slot: 7
	internal virtual void set_UseFilter(bool value) { }

	// RVA: 0x84B65EC Offset: 0x84B25EC VA: 0x84B65EC
	internal void .ctor(string field) { }

	// RVA: 0x84B661C Offset: 0x84B261C VA: 0x84B661C
	public static Query EQ(string field, BsonValue value) { }

	// RVA: 0x84B674C Offset: 0x84B274C VA: 0x84B674C Slot: 8
	internal virtual IEnumerable<IndexNode> Run(CollectionPage col, IndexService indexer) { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract IEnumerable<IndexNode> ExecuteIndex(IndexService indexer, CollectionIndex index);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool FilterDocument(BsonDocument doc);
}

// Namespace: UltraLiteDB
internal class QueryCursor : IDisposable // TypeDefIndex: 26437
{
	// Fields
	private int _position; // 0x10
	private int _skip; // 0x14
	private int _limit; // 0x18
	private Query _query; // 0x20
	private IEnumerator<IndexNode> _nodes; // 0x28
	[CompilerGenerated]
	private List<BsonDocument> <Documents>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <HasMore>k__BackingField; // 0x38

	// Properties
	public List<BsonDocument> Documents { get; set; }
	public bool HasMore { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84B6A94 Offset: 0x84B2A94 VA: 0x84B6A94
	public List<BsonDocument> get_Documents() { }

	[CompilerGenerated]
	// RVA: 0x84B6A9C Offset: 0x84B2A9C VA: 0x84B6A9C
	private void set_Documents(List<BsonDocument> value) { }

	[CompilerGenerated]
	// RVA: 0x84B6AA4 Offset: 0x84B2AA4 VA: 0x84B6AA4
	public bool get_HasMore() { }

	[CompilerGenerated]
	// RVA: 0x84B6AAC Offset: 0x84B2AAC VA: 0x84B6AAC
	private void set_HasMore(bool value) { }

	// RVA: 0x84B2FF4 Offset: 0x84AEFF4 VA: 0x84B2FF4
	public void .ctor(Query query, int skip, int limit) { }

	// RVA: 0x84B6AB8 Offset: 0x84B2AB8 VA: 0x84B6AB8
	public void Initialize(IEnumerator<IndexNode> nodes) { }

	// RVA: 0x84B30C0 Offset: 0x84AF0C0 VA: 0x84B30C0
	public void Fetch(TransactionService trans, DataService data) { }

	// RVA: 0x84B6AC0 Offset: 0x84B2AC0 VA: 0x84B6AC0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class QueryEquals.<ExecuteIndex>d__2 : IEnumerable<IndexNode>, IEnumerable, IEnumerator<IndexNode>, IEnumerator, IDisposable // TypeDefIndex: 26438
{
	// Fields
	private int <>1__state; // 0x10
	private IndexNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private IndexService indexer; // 0x28
	public IndexService <>3__indexer; // 0x30
	private CollectionIndex index; // 0x38
	public CollectionIndex <>3__index; // 0x40
	public QueryEquals <>4__this; // 0x48
	private IndexNode <node>5__2; // 0x50

	// Properties
	private IndexNode System.Collections.Generic.IEnumerator<UltraLiteDB.IndexNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84B6C14 Offset: 0x84B2C14 VA: 0x84B6C14
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84B6E04 Offset: 0x84B2E04 VA: 0x84B6E04 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84B6E08 Offset: 0x84B2E08 VA: 0x84B6E08 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x84B6FD8 Offset: 0x84B2FD8 VA: 0x84B6FD8 Slot: 6
	private IndexNode System.Collections.Generic.IEnumerator<UltraLiteDB.IndexNode>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84B6FE0 Offset: 0x84B2FE0 VA: 0x84B6FE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84B7018 Offset: 0x84B3018 VA: 0x84B7018 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84B7020 Offset: 0x84B3020 VA: 0x84B7020 Slot: 4
	private IEnumerator<IndexNode> System.Collections.Generic.IEnumerable<UltraLiteDB.IndexNode>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x84B70E4 Offset: 0x84B30E4 VA: 0x84B70E4 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UltraLiteDB
internal class QueryEquals : Query // TypeDefIndex: 26439
{
	// Fields
	private BsonValue _value; // 0x28

	// Methods

	// RVA: 0x84B6708 Offset: 0x84B2708 VA: 0x84B6708
	public void .ctor(string field, BsonValue value) { }

	[IteratorStateMachine(typeof(QueryEquals.<ExecuteIndex>d__2))]
	// RVA: 0x84B6B68 Offset: 0x84B2B68 VA: 0x84B6B68 Slot: 9
	internal override IEnumerable<IndexNode> ExecuteIndex(IndexService indexer, CollectionIndex index) { }

	// RVA: 0x84B6C48 Offset: 0x84B2C48 VA: 0x84B6C48 Slot: 10
	internal override bool FilterDocument(BsonDocument doc) { }

	// RVA: 0x84B6D04 Offset: 0x84B2D04 VA: 0x84B6D04 Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	// RVA: 0x84B6DD0 Offset: 0x84B2DD0 VA: 0x84B6DD0
	private bool <FilterDocument>b__3_0(BsonValue x) { }
}

// Namespace: UltraLiteDB
internal class CacheService // TypeDefIndex: 26440
{
	// Fields
	private Dictionary<uint, BasePage> _clean; // 0x10
	private Dictionary<uint, BasePage> _dirty; // 0x18
	private IDiskService _disk; // 0x20
	private Logger _log; // 0x28

	// Properties
	public int CleanUsed { get; }

	// Methods

	// RVA: 0x84B0934 Offset: 0x84AC934 VA: 0x84B0934
	public void .ctor(IDiskService disk, Logger log) { }

	// RVA: 0x84B70E8 Offset: 0x84B30E8 VA: 0x84B70E8
	public BasePage GetPage(uint pageID) { }

	// RVA: 0x84B716C Offset: 0x84B316C VA: 0x84B716C
	public void AddPage(BasePage page) { }

	// RVA: 0x84B721C Offset: 0x84B321C VA: 0x84B721C
	public void SetDirty(BasePage page) { }

	// RVA: 0x84B72AC Offset: 0x84B32AC VA: 0x84B72AC
	public ICollection<BasePage> GetDirtyPages() { }

	// RVA: 0x84B72FC Offset: 0x84B32FC VA: 0x84B72FC
	public int get_CleanUsed() { }

	// RVA: 0x84B734C Offset: 0x84B334C VA: 0x84B734C
	public void DiscardDirtyPages() { }

	// RVA: 0x84B7430 Offset: 0x84B3430 VA: 0x84B7430
	public void MarkDirtyAsClean() { }

	// RVA: 0x84B75F0 Offset: 0x84B35F0 VA: 0x84B75F0
	public void ClearPages() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CollectionService.<>c // TypeDefIndex: 26441
{
	// Fields
	public static readonly CollectionService.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, uint>, int> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x84B7BA0 Offset: 0x84B3BA0 VA: 0x84B7BA0
	private static void .cctor() { }

	// RVA: 0x84B7C08 Offset: 0x84B3C08 VA: 0x84B7C08
	public void .ctor() { }

	// RVA: 0x84B7C10 Offset: 0x84B3C10 VA: 0x84B7C10
	internal int <Add>b__7_0(KeyValuePair<string, uint> x) { }
}

// Namespace: UltraLiteDB
internal class CollectionService // TypeDefIndex: 26442
{
	// Fields
	private PageService _pager; // 0x10
	private IndexService _indexer; // 0x18
	private DataService _data; // 0x20
	private TransactionService _trans; // 0x28
	private Logger _log; // 0x30

	// Methods

	// RVA: 0x84B0BFC Offset: 0x84ACBFC VA: 0x84B0BFC
	public void .ctor(PageService pager, IndexService indexer, DataService data, TransactionService trans, Logger log) { }

	// RVA: 0x84B0C8C Offset: 0x84ACC8C VA: 0x84B0C8C
	public CollectionPage Get(string name) { }

	// RVA: 0x84B0DB0 Offset: 0x84ACDB0 VA: 0x84B0DB0
	public CollectionPage Add(string name) { }

	// RVA: 0x84B14EC Offset: 0x84AD4EC VA: 0x84B14EC
	public void Drop(CollectionPage col) { }
}

// Namespace: UltraLiteDB
internal class DataService // TypeDefIndex: 26443
{
	// Fields
	private PageService _pager; // 0x10
	private Logger _log; // 0x18

	// Methods

	// RVA: 0x84B0B20 Offset: 0x84ACB20 VA: 0x84B0B20
	public void .ctor(PageService pager, Logger log) { }

	// RVA: 0x84AE7F0 Offset: 0x84AA7F0 VA: 0x84AE7F0
	public DataBlock Insert(CollectionPage col, byte[] data) { }

	// RVA: 0x84AF75C Offset: 0x84AB75C VA: 0x84AF75C
	public DataBlock Update(CollectionPage col, PageAddress blockAddress, byte[] data) { }

	// RVA: 0x84B138C Offset: 0x84AD38C VA: 0x84B138C
	public byte[] Read(PageAddress blockAddress) { }

	// RVA: 0x84B7928 Offset: 0x84B3928 VA: 0x84B7928
	public DataBlock GetBlock(PageAddress blockAddress) { }

	// RVA: 0x84B7E9C Offset: 0x84B3E9C VA: 0x84B7E9C
	public byte[] ReadExtendData(uint extendPageID) { }

	// RVA: 0x84B26D0 Offset: 0x84AE6D0 VA: 0x84B26D0
	public DataBlock Delete(CollectionPage col, PageAddress blockAddress) { }

	// RVA: 0x84B7C58 Offset: 0x84B3C58 VA: 0x84B7C58
	public void StoreExtendData(ExtendPage page, byte[] data) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class IndexService.<GetNodeList>d__8 : IEnumerable<IndexNode>, IEnumerable, IEnumerator<IndexNode>, IEnumerator, IDisposable // TypeDefIndex: 26444
{
	// Fields
	private int <>1__state; // 0x10
	private IndexNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private IndexNode node; // 0x28
	public IndexNode <>3__node; // 0x30
	private bool includeInitial; // 0x38
	public bool <>3__includeInitial; // 0x39
	public IndexService <>4__this; // 0x40
	private PageAddress <next>5__2; // 0x48
	private PageAddress <prev>5__3; // 0x50

	// Properties
	private IndexNode System.Collections.Generic.IEnumerator<UltraLiteDB.IndexNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84B896C Offset: 0x84B496C VA: 0x84B896C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84B8AB0 Offset: 0x84B4AB0 VA: 0x84B8AB0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84B8AB4 Offset: 0x84B4AB4 VA: 0x84B8AB4 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x84B8C1C Offset: 0x84B4C1C VA: 0x84B8C1C Slot: 6
	private IndexNode System.Collections.Generic.IEnumerator<UltraLiteDB.IndexNode>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84B8C24 Offset: 0x84B4C24 VA: 0x84B8C24 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84B8C5C Offset: 0x84B4C5C VA: 0x84B8C5C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84B8C64 Offset: 0x84B4C64 VA: 0x84B8C64 Slot: 4
	private IEnumerator<IndexNode> System.Collections.Generic.IEnumerable<UltraLiteDB.IndexNode>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x84B8D20 Offset: 0x84B4D20 VA: 0x84B8D20 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class IndexService.<FindAll>d__13 : IEnumerable<IndexNode>, IEnumerable, IEnumerator<IndexNode>, IEnumerator, IDisposable // TypeDefIndex: 26445
{
	// Fields
	private int <>1__state; // 0x10
	private IndexNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public IndexService <>4__this; // 0x28
	private int order; // 0x30
	public int <>3__order; // 0x34
	private CollectionIndex index; // 0x38
	public CollectionIndex <>3__index; // 0x40
	private IndexNode <cur>5__2; // 0x48

	// Properties
	private IndexNode System.Collections.Generic.IEnumerator<UltraLiteDB.IndexNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x84B89A0 Offset: 0x84B49A0 VA: 0x84B89A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x84B8D24 Offset: 0x84B4D24 VA: 0x84B8D24 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x84B8D28 Offset: 0x84B4D28 VA: 0x84B8D28 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x84B8E78 Offset: 0x84B4E78 VA: 0x84B8E78 Slot: 6
	private IndexNode System.Collections.Generic.IEnumerator<UltraLiteDB.IndexNode>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84B8E80 Offset: 0x84B4E80 VA: 0x84B8E80 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x84B8EB8 Offset: 0x84B4EB8 VA: 0x84B8EB8 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x84B8EC0 Offset: 0x84B4EC0 VA: 0x84B8EC0 Slot: 4
	private IEnumerator<IndexNode> System.Collections.Generic.IEnumerable<UltraLiteDB.IndexNode>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x84B8F7C Offset: 0x84B4F7C VA: 0x84B8F7C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UltraLiteDB
internal class IndexService // TypeDefIndex: 26446
{
	// Fields
	private PageService _pager; // 0x10
	private Logger _log; // 0x18
	private Random _rand; // 0x20

	// Methods

	// RVA: 0x84B0A84 Offset: 0x84ACA84 VA: 0x84B0A84
	public void .ctor(PageService pager, Logger log) { }

	// RVA: 0x84B7780 Offset: 0x84B3780 VA: 0x84B7780
	public CollectionIndex CreateIndex(CollectionPage col) { }

	// RVA: 0x84AE9BC Offset: 0x84AA9BC VA: 0x84AE9BC
	public IndexNode AddNode(CollectionIndex index, BsonValue key, IndexNode last) { }

	// RVA: 0x84B833C Offset: 0x84B433C VA: 0x84B833C
	private IndexNode AddNode(CollectionIndex index, BsonValue key, byte level, IndexNode last) { }

	[IteratorStateMachine(typeof(IndexService.<GetNodeList>d__8))]
	// RVA: 0x84AF92C Offset: 0x84AB92C VA: 0x84AF92C
	public IEnumerable<IndexNode> GetNodeList(IndexNode node, bool includeInitial) { }

	// RVA: 0x84AF9E0 Offset: 0x84AB9E0 VA: 0x84AF9E0
	public void Delete(CollectionIndex index, PageAddress nodeAddress) { }

	// RVA: 0x84AD32C Offset: 0x84A932C VA: 0x84AD32C
	public IndexNode GetNode(PageAddress address) { }

	// RVA: 0x84B887C Offset: 0x84B487C VA: 0x84B887C
	public byte FlipCoin() { }

	[IteratorStateMachine(typeof(IndexService.<FindAll>d__13))]
	// RVA: 0x84B696C Offset: 0x84B296C VA: 0x84B696C
	public IEnumerable<IndexNode> FindAll(CollectionIndex index, int order) { }

	// RVA: 0x84AF580 Offset: 0x84AB580 VA: 0x84AF580
	public IndexNode Find(CollectionIndex index, BsonValue value, bool sibling, int order) { }

	// RVA: 0x84B8A14 Offset: 0x84B4A14 VA: 0x84B8A14
	private IndexNode FindBoundary(CollectionIndex index, IndexNode cur, BsonValue value, int order, int level) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PageService.<GetSeqPages>d__7<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 26447
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private uint firstPageID; // 0x0
	public uint <>3__firstPageID; // 0x0
	public PageService <>4__this; // 0x0
	private uint <pageID>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3080C Offset: 0x5D2C80C VA: 0x5D3080C
	|-PageService.<GetSeqPages>d__7<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D30840 Offset: 0x5D2C840 VA: 0x5D30840
	|-PageService.<GetSeqPages>d__7<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D30844 Offset: 0x5D2C844 VA: 0x5D30844
	|-PageService.<GetSeqPages>d__7<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D308D8 Offset: 0x5D2C8D8 VA: 0x5D308D8
	|-PageService.<GetSeqPages>d__7<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D308E0 Offset: 0x5D2C8E0 VA: 0x5D308E0
	|-PageService.<GetSeqPages>d__7<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D30914 Offset: 0x5D2C914 VA: 0x5D30914
	|-PageService.<GetSeqPages>d__7<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3091C Offset: 0x5D2C91C VA: 0x5D3091C
	|-PageService.<GetSeqPages>d__7<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D309B8 Offset: 0x5D2C9B8 VA: 0x5D309B8
	|-PageService.<GetSeqPages>d__7<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: UltraLiteDB
internal class PageService // TypeDefIndex: 26448
{
	// Fields
	private CacheService _cache; // 0x10
	private IDiskService _disk; // 0x18
	private AesEncryption _crypto; // 0x20
	private Logger _log; // 0x28

	// Methods

	// RVA: 0x84B0A10 Offset: 0x84ACA10 VA: 0x84B0A10
	public void .ctor(IDiskService disk, AesEncryption crypto, CacheService cache, Logger log) { }

	// RVA: -1 Offset: -1
	public T GetPage<T>(uint pageID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4687A10 Offset: 0x4683A10 VA: 0x4687A10
	|-PageService.GetPage<object>
	*/

	// RVA: 0x84AE7D8 Offset: 0x84AA7D8 VA: 0x84AE7D8
	public void SetDirty(BasePage page) { }

	[IteratorStateMachine(typeof(PageService.<GetSeqPages>d__7<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<T> GetSeqPages<T>(uint firstPageID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4687C40 Offset: 0x4683C40 VA: 0x4687C40
	|-PageService.GetSeqPages<object>
	*/

	// RVA: -1 Offset: -1
	public T NewPage<T>(BasePage prevPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4687CBC Offset: 0x4683CBC VA: 0x4687CBC
	|-PageService.NewPage<object>
	*/

	// RVA: 0x84B798C Offset: 0x84B398C VA: 0x84B798C
	public void DeletePage(uint pageID, bool addSequence = False) { }

	// RVA: -1 Offset: -1
	public T GetFreePage<T>(uint startPageID, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4687984 Offset: 0x4683984 VA: 0x4687984
	|-PageService.GetFreePage<object>
	*/

	// RVA: 0x84B7DE8 Offset: 0x84B3DE8 VA: 0x84B7DE8
	public void AddOrRemoveToFreeList(bool add, BasePage page, BasePage startPage, ref uint fieldPageID) { }

	// RVA: 0x84B8F80 Offset: 0x84B4F80 VA: 0x84B8F80
	private void AddToFreeList(BasePage page, BasePage startPage, ref uint fieldPageID) { }

	// RVA: 0x84B9124 Offset: 0x84B5124 VA: 0x84B9124
	private void RemoveToFreeList(BasePage page, BasePage startPage, ref uint fieldPageID) { }

	// RVA: 0x84B90E4 Offset: 0x84B50E4 VA: 0x84B90E4
	private void MoveToFreeList(BasePage page, BasePage startPage, ref uint fieldPageID) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TransactionService.<>c // TypeDefIndex: 26449
{
	// Fields
	public static readonly TransactionService.<>c <>9; // 0x0
	public static Func<BasePage, uint> <>9__8_0; // 0x8
	public static Func<BasePage, byte[]> <>9__8_1; // 0x10
	public static Func<byte[], bool> <>9__8_2; // 0x18

	// Methods

	// RVA: 0x84B9F08 Offset: 0x84B5F08 VA: 0x84B9F08
	private static void .cctor() { }

	// RVA: 0x84B9F70 Offset: 0x84B5F70 VA: 0x84B9F70
	public void .ctor() { }

	// RVA: 0x84B9F78 Offset: 0x84B5F78 VA: 0x84B9F78
	internal uint <PersistDirtyPages>b__8_0(BasePage x) { }

	// RVA: 0x84B9F90 Offset: 0x84B5F90 VA: 0x84B9F90
	internal byte[] <PersistDirtyPages>b__8_1(BasePage x) { }

	// RVA: 0x84B9FA8 Offset: 0x84B5FA8 VA: 0x84B9FA8
	internal bool <PersistDirtyPages>b__8_2(byte[] x) { }
}

// Namespace: UltraLiteDB
internal class TransactionService // TypeDefIndex: 26450
{
	// Fields
	private IDiskService _disk; // 0x10
	private AesEncryption _crypto; // 0x18
	private PageService _pager; // 0x20
	private CacheService _cache; // 0x28
	private Logger _log; // 0x30
	private int _cacheSize; // 0x38

	// Methods

	// RVA: 0x84B0B64 Offset: 0x84ACB64 VA: 0x84B0B64
	internal void .ctor(IDiskService disk, AesEncryption crypto, PageService pager, CacheService cache, int cacheSize, Logger log) { }

	// RVA: 0x84B2588 Offset: 0x84AE588 VA: 0x84B2588
	public bool CheckPoint() { }

	// RVA: 0x84B9210 Offset: 0x84B5210 VA: 0x84B9210
	public void PersistDirtyPages() { }

	// RVA: 0x84B0258 Offset: 0x84AC258 VA: 0x84B0258
	public void Recovery() { }
}

// Namespace: UltraLiteDB
internal class CollectionIndex // TypeDefIndex: 26451
{
	// Fields
	public static Regex IndexPattern; // 0x0
	[CompilerGenerated]
	private int <Slot>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Field>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <Unique>k__BackingField; // 0x20
	[CompilerGenerated]
	private PageAddress <HeadNode>k__BackingField; // 0x24
	[CompilerGenerated]
	private PageAddress <TailNode>k__BackingField; // 0x2C
	public uint FreeIndexPageID; // 0x34
	[CompilerGenerated]
	private byte <MaxLevel>k__BackingField; // 0x38
	[CompilerGenerated]
	private CollectionPage <Page>k__BackingField; // 0x40

	// Properties
	public int Slot { get; set; }
	public string Field { get; set; }
	public bool Unique { get; set; }
	public PageAddress HeadNode { get; set; }
	public PageAddress TailNode { get; set; }
	public bool IsEmpty { get; }
	public byte MaxLevel { get; set; }
	public CollectionPage Page { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84B9FC8 Offset: 0x84B5FC8 VA: 0x84B9FC8
	public int get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x84B9FD0 Offset: 0x84B5FD0 VA: 0x84B9FD0
	public void set_Slot(int value) { }

	[CompilerGenerated]
	// RVA: 0x84B9FD8 Offset: 0x84B5FD8 VA: 0x84B9FD8
	public string get_Field() { }

	[CompilerGenerated]
	// RVA: 0x84B9FE0 Offset: 0x84B5FE0 VA: 0x84B9FE0
	public void set_Field(string value) { }

	[CompilerGenerated]
	// RVA: 0x84B9FE8 Offset: 0x84B5FE8 VA: 0x84B9FE8
	public bool get_Unique() { }

	[CompilerGenerated]
	// RVA: 0x84B9FF0 Offset: 0x84B5FF0 VA: 0x84B9FF0
	public void set_Unique(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84B9FFC Offset: 0x84B5FFC VA: 0x84B9FFC
	public PageAddress get_HeadNode() { }

	[CompilerGenerated]
	// RVA: 0x84BA004 Offset: 0x84B6004 VA: 0x84BA004
	public void set_HeadNode(PageAddress value) { }

	[CompilerGenerated]
	// RVA: 0x84BA00C Offset: 0x84B600C VA: 0x84BA00C
	public PageAddress get_TailNode() { }

	[CompilerGenerated]
	// RVA: 0x84BA014 Offset: 0x84B6014 VA: 0x84BA014
	public void set_TailNode(PageAddress value) { }

	// RVA: 0x84B4F3C Offset: 0x84B0F3C VA: 0x84B4F3C
	public bool get_IsEmpty() { }

	[CompilerGenerated]
	// RVA: 0x84BA01C Offset: 0x84B601C VA: 0x84BA01C
	public byte get_MaxLevel() { }

	[CompilerGenerated]
	// RVA: 0x84BA024 Offset: 0x84B6024 VA: 0x84BA024
	public void set_MaxLevel(byte value) { }

	[CompilerGenerated]
	// RVA: 0x84BA02C Offset: 0x84B602C VA: 0x84BA02C
	public CollectionPage get_Page() { }

	[CompilerGenerated]
	// RVA: 0x84BA034 Offset: 0x84B6034 VA: 0x84BA034
	public void set_Page(CollectionPage value) { }

	// RVA: 0x84B4AF0 Offset: 0x84B0AF0 VA: 0x84B4AF0
	public void .ctor() { }

	// RVA: 0x84BA03C Offset: 0x84B603C VA: 0x84BA03C
	public void Clear() { }

	// RVA: 0x84BA0E8 Offset: 0x84B60E8 VA: 0x84BA0E8
	private static void .cctor() { }
}

// Namespace: UltraLiteDB
internal class DataBlock // TypeDefIndex: 26452
{
	// Fields
	[CompilerGenerated]
	private PageAddress <Position>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <ExtendPageID>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x20
	[CompilerGenerated]
	private DataPage <Page>k__BackingField; // 0x28

	// Properties
	public PageAddress Position { get; set; }
	public uint ExtendPageID { get; set; }
	public byte[] Data { get; set; }
	public DataPage Page { set; }
	public int Length { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84BA188 Offset: 0x84B6188 VA: 0x84BA188
	public PageAddress get_Position() { }

	[CompilerGenerated]
	// RVA: 0x84BA190 Offset: 0x84B6190 VA: 0x84BA190
	public void set_Position(PageAddress value) { }

	[CompilerGenerated]
	// RVA: 0x84BA198 Offset: 0x84B6198 VA: 0x84BA198
	public uint get_ExtendPageID() { }

	[CompilerGenerated]
	// RVA: 0x84BA1A0 Offset: 0x84B61A0 VA: 0x84BA1A0
	public void set_ExtendPageID(uint value) { }

	[CompilerGenerated]
	// RVA: 0x84BA1A8 Offset: 0x84B61A8 VA: 0x84BA1A8
	public byte[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x84BA1B0 Offset: 0x84B61B0 VA: 0x84BA1B0
	public void set_Data(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x84BA1B8 Offset: 0x84B61B8 VA: 0x84BA1B8
	public void set_Page(DataPage value) { }

	// RVA: 0x84B5198 Offset: 0x84B1198 VA: 0x84B5198
	public int get_Length() { }

	// RVA: 0x84B5448 Offset: 0x84B1448 VA: 0x84B5448
	public void .ctor() { }
}

// Namespace: UltraLiteDB
internal class IndexNode // TypeDefIndex: 26453
{
	// Fields
	[CompilerGenerated]
	private PageAddress <Position>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x18
	[CompilerGenerated]
	private PageAddress <PrevNode>k__BackingField; // 0x1C
	[CompilerGenerated]
	private PageAddress <NextNode>k__BackingField; // 0x24
	[CompilerGenerated]
	private PageAddress[] <Prev>k__BackingField; // 0x30
	[CompilerGenerated]
	private PageAddress[] <Next>k__BackingField; // 0x38
	[CompilerGenerated]
	private ushort <KeyLength>k__BackingField; // 0x40
	[CompilerGenerated]
	private BsonValue <Key>k__BackingField; // 0x48
	[CompilerGenerated]
	private PageAddress <DataBlock>k__BackingField; // 0x50
	[CompilerGenerated]
	private IndexPage <Page>k__BackingField; // 0x58

	// Properties
	public PageAddress Position { get; set; }
	public byte Slot { get; set; }
	public PageAddress PrevNode { get; set; }
	public PageAddress NextNode { get; set; }
	public PageAddress[] Prev { get; set; }
	public PageAddress[] Next { get; set; }
	public ushort KeyLength { get; set; }
	public BsonValue Key { get; set; }
	public PageAddress DataBlock { get; set; }
	public IndexPage Page { get; set; }
	public int Length { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84BA1C0 Offset: 0x84B61C0 VA: 0x84BA1C0
	public PageAddress get_Position() { }

	[CompilerGenerated]
	// RVA: 0x84BA1C8 Offset: 0x84B61C8 VA: 0x84BA1C8
	public void set_Position(PageAddress value) { }

	[CompilerGenerated]
	// RVA: 0x84BA1D0 Offset: 0x84B61D0 VA: 0x84BA1D0
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x84BA1D8 Offset: 0x84B61D8 VA: 0x84BA1D8
	public void set_Slot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x84BA1E0 Offset: 0x84B61E0 VA: 0x84BA1E0
	public PageAddress get_PrevNode() { }

	[CompilerGenerated]
	// RVA: 0x84BA1E8 Offset: 0x84B61E8 VA: 0x84BA1E8
	public void set_PrevNode(PageAddress value) { }

	[CompilerGenerated]
	// RVA: 0x84BA1F0 Offset: 0x84B61F0 VA: 0x84BA1F0
	public PageAddress get_NextNode() { }

	[CompilerGenerated]
	// RVA: 0x84BA1F8 Offset: 0x84B61F8 VA: 0x84BA1F8
	public void set_NextNode(PageAddress value) { }

	[CompilerGenerated]
	// RVA: 0x84BA200 Offset: 0x84B6200 VA: 0x84BA200
	public PageAddress[] get_Prev() { }

	[CompilerGenerated]
	// RVA: 0x84BA208 Offset: 0x84B6208 VA: 0x84BA208
	public void set_Prev(PageAddress[] value) { }

	[CompilerGenerated]
	// RVA: 0x84BA210 Offset: 0x84B6210 VA: 0x84BA210
	public PageAddress[] get_Next() { }

	[CompilerGenerated]
	// RVA: 0x84BA218 Offset: 0x84B6218 VA: 0x84BA218
	public void set_Next(PageAddress[] value) { }

	[CompilerGenerated]
	// RVA: 0x84BA220 Offset: 0x84B6220 VA: 0x84BA220
	public ushort get_KeyLength() { }

	[CompilerGenerated]
	// RVA: 0x84BA228 Offset: 0x84B6228 VA: 0x84BA228
	public void set_KeyLength(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x84BA230 Offset: 0x84B6230 VA: 0x84BA230
	public BsonValue get_Key() { }

	[CompilerGenerated]
	// RVA: 0x84BA238 Offset: 0x84B6238 VA: 0x84BA238
	public void set_Key(BsonValue value) { }

	[CompilerGenerated]
	// RVA: 0x84BA240 Offset: 0x84B6240 VA: 0x84BA240
	public PageAddress get_DataBlock() { }

	[CompilerGenerated]
	// RVA: 0x84BA248 Offset: 0x84B6248 VA: 0x84BA248
	public void set_DataBlock(PageAddress value) { }

	[CompilerGenerated]
	// RVA: 0x84BA250 Offset: 0x84B6250 VA: 0x84BA250
	public IndexPage get_Page() { }

	[CompilerGenerated]
	// RVA: 0x84BA258 Offset: 0x84B6258 VA: 0x84BA258
	public void set_Page(IndexPage value) { }

	// RVA: 0x84B89D4 Offset: 0x84B49D4 VA: 0x84B89D4
	public PageAddress NextPrev(int index, int order) { }

	// RVA: 0x84AD3D8 Offset: 0x84A93D8 VA: 0x84AD3D8
	public bool IsHeadTail(CollectionIndex index) { }

	// RVA: 0x84B5E14 Offset: 0x84B1E14 VA: 0x84B5E14
	public int get_Length() { }

	// RVA: 0x84B6170 Offset: 0x84B2170 VA: 0x84B6170
	public void .ctor(byte level) { }
}

// Namespace: UltraLiteDB
internal struct PageAddress // TypeDefIndex: 26454
{
	// Fields
	public static PageAddress Empty; // 0x0
	public uint PageID; // 0x0
	public ushort Index; // 0x4

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x84B6FC8 Offset: 0x84B2FC8 VA: 0x84B6FC8
	public bool get_IsEmpty() { }

	// RVA: 0x84B88D4 Offset: 0x84B48D4 VA: 0x84B88D4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x84BA260 Offset: 0x84B6260 VA: 0x84BA260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x84B518C Offset: 0x84B118C VA: 0x84B518C
	public void .ctor(uint pageID, ushort index) { }

	// RVA: 0x84BA27C Offset: 0x84B627C VA: 0x84BA27C Slot: 3
	public override string ToString() { }

	// RVA: 0x84BA33C Offset: 0x84B633C VA: 0x84BA33C
	private static void .cctor() { }
}

// Namespace: UltraLiteDB
public class BsonFieldAttribute : Attribute // TypeDefIndex: 26455
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84BA388 Offset: 0x84B6388 VA: 0x84BA388
	public string get_Name() { }
}

// Namespace: UltraLiteDB
public class BsonIdAttribute : Attribute // TypeDefIndex: 26456
{
	// Fields
	[CompilerGenerated]
	private bool <AutoId>k__BackingField; // 0x10

	// Properties
	public bool AutoId { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84BA390 Offset: 0x84B6390 VA: 0x84BA390
	public bool get_AutoId() { }
}

// Namespace: UltraLiteDB
public class BsonIgnoreAttribute : Attribute // TypeDefIndex: 26457
{
	// Methods

	// RVA: 0x84BA398 Offset: 0x84B6398 VA: 0x84BA398
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class BsonMapper.<>c // TypeDefIndex: 26458
{
	// Fields
	public static readonly BsonMapper.<>c <>9; // 0x0
	public static Func<string, string> <>9__29_0; // 0x8
	public static Action<Type, MemberInfo, MemberMapper> <>9__29_1; // 0x10
	public static Func<Type, string> <>9__29_2; // 0x18
	public static Func<Uri, BsonValue> <>9__29_3; // 0x20
	public static Func<BsonValue, Uri> <>9__29_4; // 0x28
	public static Func<DateTimeOffset, BsonValue> <>9__29_5; // 0x30
	public static Func<BsonValue, DateTimeOffset> <>9__29_6; // 0x38
	public static Func<TimeSpan, BsonValue> <>9__29_7; // 0x40
	public static Func<BsonValue, TimeSpan> <>9__29_8; // 0x48
	public static Func<Regex, BsonValue> <>9__29_9; // 0x50
	public static Func<BsonValue, Regex> <>9__29_10; // 0x58
	public static Func<MemberInfo, bool> <>9__38_0; // 0x60
	public static Func<MemberInfo, bool> <>9__38_1; // 0x68
	public static Func<MemberInfo, bool> <>9__38_2; // 0x70
	public static Func<PropertyInfo, bool> <>9__39_0; // 0x78
	public static Func<PropertyInfo, MemberInfo> <>9__39_1; // 0x80
	public static Func<FieldInfo, bool> <>9__39_2; // 0x88
	public static Func<FieldInfo, MemberInfo> <>9__39_3; // 0x90
	public static Func<MemberMapper, bool> <>9__49_0; // 0x98
	public static Func<MemberMapper, bool> <>9__55_0; // 0xA0

	// Methods

	// RVA: 0x84BF7D0 Offset: 0x84BB7D0 VA: 0x84BF7D0
	private static void .cctor() { }

	// RVA: 0x84BF838 Offset: 0x84BB838 VA: 0x84BF838
	public void .ctor() { }

	// RVA: 0x84BF840 Offset: 0x84BB840 VA: 0x84BF840
	internal string <.ctor>b__29_0(string s) { }

	// RVA: 0x84BF848 Offset: 0x84BB848 VA: 0x84BF848
	internal void <.ctor>b__29_1(Type t, MemberInfo mi, MemberMapper mm) { }

	// RVA: 0x84BF84C Offset: 0x84BB84C VA: 0x84BF84C
	internal string <.ctor>b__29_2(Type t) { }

	// RVA: 0x84BFCF8 Offset: 0x84BBCF8 VA: 0x84BFCF8
	internal BsonValue <.ctor>b__29_3(Uri uri) { }

	// RVA: 0x84BFD6C Offset: 0x84BBD6C VA: 0x84BFD6C
	internal Uri <.ctor>b__29_4(BsonValue bson) { }

	// RVA: 0x84BFDE4 Offset: 0x84BBDE4 VA: 0x84BFDE4
	internal BsonValue <.ctor>b__29_5(DateTimeOffset value) { }

	// RVA: 0x84BFE80 Offset: 0x84BBE80 VA: 0x84BFE80
	internal DateTimeOffset <.ctor>b__29_6(BsonValue bson) { }

	// RVA: 0x84BFF38 Offset: 0x84BBF38 VA: 0x84BFF38
	internal BsonValue <.ctor>b__29_7(TimeSpan value) { }

	// RVA: 0x84BFFB8 Offset: 0x84BBFB8 VA: 0x84BFFB8
	internal TimeSpan <.ctor>b__29_8(BsonValue bson) { }

	// RVA: 0x84BFFD0 Offset: 0x84BBFD0 VA: 0x84BFFD0
	internal BsonValue <.ctor>b__29_9(Regex r) { }

	// RVA: 0x84C0114 Offset: 0x84BC114 VA: 0x84C0114
	internal Regex <.ctor>b__29_10(BsonValue value) { }

	// RVA: 0x84C0278 Offset: 0x84BC278 VA: 0x84C0278
	internal bool <GetIdMember>b__38_0(MemberInfo x) { }

	// RVA: 0x84C0304 Offset: 0x84BC304 VA: 0x84C0304
	internal bool <GetIdMember>b__38_1(MemberInfo x) { }

	// RVA: 0x84C0370 Offset: 0x84BC370 VA: 0x84C0370
	internal bool <GetIdMember>b__38_2(MemberInfo x) { }

	// RVA: 0x84C0418 Offset: 0x84BC418 VA: 0x84C0418
	internal bool <GetTypeMembers>b__39_0(PropertyInfo x) { }

	// RVA: 0x84C0474 Offset: 0x84BC474 VA: 0x84C0474
	internal MemberInfo <GetTypeMembers>b__39_1(PropertyInfo x) { }

	// RVA: 0x84C047C Offset: 0x84BC47C VA: 0x84C047C
	internal bool <GetTypeMembers>b__39_2(FieldInfo x) { }

	// RVA: 0x84C0508 Offset: 0x84BC508 VA: 0x84C0508
	internal MemberInfo <GetTypeMembers>b__39_3(FieldInfo x) { }

	// RVA: 0x84C0510 Offset: 0x84BC510 VA: 0x84C0510
	internal bool <DeserializeObject>b__49_0(MemberMapper x) { }

	// RVA: 0x84C0530 Offset: 0x84BC530 VA: 0x84C0530
	internal bool <SerializeObject>b__55_0(MemberMapper x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BsonMapper.<>c__DisplayClass30_0<T> // TypeDefIndex: 26459
{
	// Fields
	public Func<T, BsonValue> serialize; // 0x0
	public Func<BsonValue, T> deserialize; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486E524 Offset: 0x486A524 VA: 0x486E524
	|-BsonMapper.<>c__DisplayClass30_0<DateTimeOffset>..ctor
	|
	|-RVA: 0x486E5F0 Offset: 0x486A5F0 VA: 0x486E5F0
	|-BsonMapper.<>c__DisplayClass30_0<object>..ctor
	|
	|-RVA: 0x486E694 Offset: 0x486A694 VA: 0x486E694
	|-BsonMapper.<>c__DisplayClass30_0<TimeSpan>..ctor
	|
	|-RVA: 0x486E760 Offset: 0x486A760 VA: 0x486E760
	|-BsonMapper.<>c__DisplayClass30_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal BsonValue <RegisterType>b__0(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486E52C Offset: 0x486A52C VA: 0x486E52C
	|-BsonMapper.<>c__DisplayClass30_0<DateTimeOffset>.<RegisterType>b__0
	|
	|-RVA: 0x486E5F8 Offset: 0x486A5F8 VA: 0x486E5F8
	|-BsonMapper.<>c__DisplayClass30_0<object>.<RegisterType>b__0
	|
	|-RVA: 0x486E69C Offset: 0x486A69C VA: 0x486E69C
	|-BsonMapper.<>c__DisplayClass30_0<TimeSpan>.<RegisterType>b__0
	|
	|-RVA: 0x486E768 Offset: 0x486A768 VA: 0x486E768
	|-BsonMapper.<>c__DisplayClass30_0<__Il2CppFullySharedGenericType>.<RegisterType>b__0
	*/

	// RVA: -1 Offset: -1
	internal object <RegisterType>b__1(BsonValue b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486E5A4 Offset: 0x486A5A4 VA: 0x486E5A4
	|-BsonMapper.<>c__DisplayClass30_0<DateTimeOffset>.<RegisterType>b__1
	|
	|-RVA: 0x486E670 Offset: 0x486A670 VA: 0x486E670
	|-BsonMapper.<>c__DisplayClass30_0<object>.<RegisterType>b__1
	|
	|-RVA: 0x486E714 Offset: 0x486A714 VA: 0x486E714
	|-BsonMapper.<>c__DisplayClass30_0<TimeSpan>.<RegisterType>b__1
	|
	|-RVA: 0x486E84C Offset: 0x486A84C VA: 0x486E84C
	|-BsonMapper.<>c__DisplayClass30_0<__Il2CppFullySharedGenericType>.<RegisterType>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class BsonMapper.<>c__DisplayClass37_0 // TypeDefIndex: 26460
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x84C0550 Offset: 0x84BC550 VA: 0x84C0550
	public void .ctor() { }

	// RVA: 0x84C0558 Offset: 0x84BC558 VA: 0x84C0558
	internal bool <BuildEntityMapper>b__0(MemberMapper x) { }
}

// Namespace: UltraLiteDB
public class BsonMapper // TypeDefIndex: 26461
{
	// Fields
	private Dictionary<Type, EntityMapper> _entities; // 0x10
	private Dictionary<Type, Func<object, BsonValue>> _customSerializer; // 0x18
	private Dictionary<Type, Func<BsonValue, object>> _customDeserializer; // 0x20
	private readonly Func<Type, object> _typeInstantiator; // 0x28
	public static BsonMapper Global; // 0x0
	public Func<string, string> ResolveFieldName; // 0x30
	[CompilerGenerated]
	private bool <SerializeNullValues>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <TrimWhitespace>k__BackingField; // 0x39
	[CompilerGenerated]
	private bool <EmptyStringToNull>k__BackingField; // 0x3A
	[CompilerGenerated]
	private bool <IncludeFields>k__BackingField; // 0x3B
	[CompilerGenerated]
	private bool <IncludeNonPublic>k__BackingField; // 0x3C
	public Action<Type, MemberInfo, MemberMapper> ResolveMember; // 0x40
	public Func<Type, string> ResolveCollectionName; // 0x48
	private Regex _lowerCaseDelimiter; // 0x50
	private HashSet<Type> _bsonTypes; // 0x58
	private HashSet<Type> _basicTypes; // 0x60

	// Properties
	public bool SerializeNullValues { get; set; }
	public bool TrimWhitespace { get; set; }
	public bool EmptyStringToNull { get; set; }
	public bool IncludeFields { get; set; }
	public bool IncludeNonPublic { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84BA3A0 Offset: 0x84B63A0 VA: 0x84BA3A0
	public bool get_SerializeNullValues() { }

	[CompilerGenerated]
	// RVA: 0x84BA3A8 Offset: 0x84B63A8 VA: 0x84BA3A8
	public void set_SerializeNullValues(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84BA3B4 Offset: 0x84B63B4 VA: 0x84BA3B4
	public bool get_TrimWhitespace() { }

	[CompilerGenerated]
	// RVA: 0x84BA3BC Offset: 0x84B63BC VA: 0x84BA3BC
	public void set_TrimWhitespace(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84BA3C8 Offset: 0x84B63C8 VA: 0x84BA3C8
	public bool get_EmptyStringToNull() { }

	[CompilerGenerated]
	// RVA: 0x84BA3D0 Offset: 0x84B63D0 VA: 0x84BA3D0
	public void set_EmptyStringToNull(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84BA3DC Offset: 0x84B63DC VA: 0x84BA3DC
	public bool get_IncludeFields() { }

	[CompilerGenerated]
	// RVA: 0x84BA3E4 Offset: 0x84B63E4 VA: 0x84BA3E4
	public void set_IncludeFields(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84BA3F0 Offset: 0x84B63F0 VA: 0x84BA3F0
	public bool get_IncludeNonPublic() { }

	// RVA: 0x84BA3F8 Offset: 0x84B63F8 VA: 0x84BA3F8
	public void .ctor(Func<Type, object> customTypeInstantiator) { }

	// RVA: -1 Offset: -1
	public void RegisterType<T>(Func<T, BsonValue> serialize, Func<BsonValue, T> deserialize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454A408 Offset: 0x4546408 VA: 0x454A408
	|-BsonMapper.RegisterType<DateTimeOffset>
	|
	|-RVA: 0x454A5C0 Offset: 0x45465C0 VA: 0x454A5C0
	|-BsonMapper.RegisterType<object>
	|
	|-RVA: 0x454A778 Offset: 0x4546778 VA: 0x454A778
	|-BsonMapper.RegisterType<TimeSpan>
	|
	|-RVA: 0x454A930 Offset: 0x4546930 VA: 0x454A930
	|-BsonMapper.RegisterType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x84BB114 Offset: 0x84B7114 VA: 0x84BB114
	internal EntityMapper GetEntityMapper(Type type) { }

	// RVA: 0x84BB2D4 Offset: 0x84B72D4 VA: 0x84BB2D4 Slot: 4
	protected virtual EntityMapper BuildEntityMapper(Type type) { }

	// RVA: 0x84BBD20 Offset: 0x84B7D20 VA: 0x84BBD20 Slot: 5
	protected virtual MemberInfo GetIdMember(IEnumerable<MemberInfo> members) { }

	// RVA: 0x84BBFB8 Offset: 0x84B7FB8 VA: 0x84BBFB8 Slot: 6
	protected virtual IEnumerable<MemberInfo> GetTypeMembers(Type type) { }

	// RVA: 0x84BC3E0 Offset: 0x84B83E0 VA: 0x84BC3E0 Slot: 7
	public virtual object ToObject(Type type, BsonDocument doc) { }

	// RVA: -1 Offset: -1 Slot: 8
	public virtual T ToObject<T>(BsonDocument doc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454AC8C Offset: 0x4546C8C VA: 0x454AC8C
	|-BsonMapper.ToObject<object>
	|
	|-RVA: 0x454AD60 Offset: 0x4546D60 VA: 0x454AD60
	|-BsonMapper.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x84BC514 Offset: 0x84B8514 VA: 0x84BC514
	internal object Deserialize(Type type, BsonValue value) { }

	// RVA: 0x84BCCB4 Offset: 0x84B8CB4 VA: 0x84BCCB4
	private object DeserializeArray(Type type, BsonArray array) { }

	// RVA: 0x84BCF88 Offset: 0x84B8F88 VA: 0x84BCF88
	private object DeserializeList(Type type, BsonArray value) { }

	// RVA: 0x84BD610 Offset: 0x84B9610 VA: 0x84BD610
	private void DeserializeDictionary(Type K, Type T, IDictionary dict, BsonDocument value) { }

	// RVA: 0x84BDA7C Offset: 0x84B9A7C VA: 0x84BDA7C
	private void DeserializeObject(Type type, object obj, BsonDocument value) { }

	// RVA: 0x84BDF0C Offset: 0x84B9F0C VA: 0x84BDF0C Slot: 9
	public virtual BsonDocument ToDocument(Type type, object entity) { }

	// RVA: -1 Offset: -1 Slot: 10
	public virtual BsonDocument ToDocument<T>(T entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454AAEC Offset: 0x4546AEC VA: 0x454AAEC
	|-BsonMapper.ToDocument<object>
	|
	|-RVA: 0x454AB70 Offset: 0x4546B70 VA: 0x454AB70
	|-BsonMapper.ToDocument<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x84BE004 Offset: 0x84BA004 VA: 0x84BE004
	internal BsonValue Serialize(Type type, object obj, int depth) { }

	// RVA: 0x84BEDDC Offset: 0x84BADDC VA: 0x84BEDDC
	private BsonArray SerializeArray(Type type, IEnumerable array, int depth) { }

	// RVA: 0x84BE938 Offset: 0x84BA938 VA: 0x84BE938
	private BsonDocument SerializeDictionary(Type type, IDictionary dict, int depth) { }

	// RVA: 0x84BF114 Offset: 0x84BB114 VA: 0x84BF114
	private BsonDocument SerializeObject(Type type, object obj, int depth) { }

	// RVA: 0x84BF768 Offset: 0x84BB768 VA: 0x84BF768
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EntityMapper.<>c // TypeDefIndex: 26462
{
	// Fields
	public static readonly EntityMapper.<>c <>9; // 0x0
	public static Func<MemberMapper, bool> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x84C0698 Offset: 0x84BC698 VA: 0x84C0698
	private static void .cctor() { }

	// RVA: 0x84C0700 Offset: 0x84BC700 VA: 0x84C0700
	public void .ctor() { }

	// RVA: 0x84C0708 Offset: 0x84BC708 VA: 0x84C0708
	internal bool <get_Id>b__5_0(MemberMapper x) { }
}

// Namespace: UltraLiteDB
public class EntityMapper // TypeDefIndex: 26463
{
	// Fields
	[CompilerGenerated]
	private List<MemberMapper> <Members>k__BackingField; // 0x10
	[CompilerGenerated]
	private Type <ForType>k__BackingField; // 0x18

	// Properties
	public List<MemberMapper> Members { get; set; }
	public MemberMapper Id { get; }
	public Type ForType { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84C057C Offset: 0x84BC57C VA: 0x84C057C
	public List<MemberMapper> get_Members() { }

	[CompilerGenerated]
	// RVA: 0x84C0584 Offset: 0x84BC584 VA: 0x84C0584
	public void set_Members(List<MemberMapper> value) { }

	// RVA: 0x84C058C Offset: 0x84BC58C VA: 0x84C058C
	public MemberMapper get_Id() { }

	[CompilerGenerated]
	// RVA: 0x84C0688 Offset: 0x84BC688 VA: 0x84C0688
	public void set_ForType(Type value) { }

	// RVA: 0x84C0690 Offset: 0x84BC690 VA: 0x84C0690
	public void .ctor() { }
}

// Namespace: UltraLiteDB
public class MemberMapper // TypeDefIndex: 26464
{
	// Fields
	[CompilerGenerated]
	private bool <AutoId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <MemberName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Type <DataType>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <FieldName>k__BackingField; // 0x28
	[CompilerGenerated]
	private GenericGetter <Getter>k__BackingField; // 0x30
	[CompilerGenerated]
	private GenericSetter <Setter>k__BackingField; // 0x38
	[CompilerGenerated]
	private Func<object, BsonMapper, BsonValue> <Serialize>k__BackingField; // 0x40
	[CompilerGenerated]
	private Func<BsonValue, BsonMapper, object> <Deserialize>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsList>k__BackingField; // 0x50
	[CompilerGenerated]
	private Type <UnderlyingType>k__BackingField; // 0x58

	// Properties
	public bool AutoId { get; set; }
	public string MemberName { set; }
	public Type DataType { get; set; }
	public string FieldName { get; set; }
	public GenericGetter Getter { get; set; }
	public GenericSetter Setter { get; set; }
	public Func<object, BsonMapper, BsonValue> Serialize { get; }
	public Func<BsonValue, BsonMapper, object> Deserialize { get; }
	public bool IsList { set; }
	public Type UnderlyingType { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84C075C Offset: 0x84BC75C VA: 0x84C075C
	public bool get_AutoId() { }

	[CompilerGenerated]
	// RVA: 0x84C0764 Offset: 0x84BC764 VA: 0x84C0764
	public void set_AutoId(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84C0770 Offset: 0x84BC770 VA: 0x84C0770
	public void set_MemberName(string value) { }

	[CompilerGenerated]
	// RVA: 0x84C0778 Offset: 0x84BC778 VA: 0x84C0778
	public Type get_DataType() { }

	[CompilerGenerated]
	// RVA: 0x84C0780 Offset: 0x84BC780 VA: 0x84C0780
	public void set_DataType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x84C0788 Offset: 0x84BC788 VA: 0x84C0788
	public string get_FieldName() { }

	[CompilerGenerated]
	// RVA: 0x84C0790 Offset: 0x84BC790 VA: 0x84C0790
	public void set_FieldName(string value) { }

	[CompilerGenerated]
	// RVA: 0x84C0798 Offset: 0x84BC798 VA: 0x84C0798
	public GenericGetter get_Getter() { }

	[CompilerGenerated]
	// RVA: 0x84C07A0 Offset: 0x84BC7A0 VA: 0x84C07A0
	public void set_Getter(GenericGetter value) { }

	[CompilerGenerated]
	// RVA: 0x84C07A8 Offset: 0x84BC7A8 VA: 0x84C07A8
	public GenericSetter get_Setter() { }

	[CompilerGenerated]
	// RVA: 0x84C07B0 Offset: 0x84BC7B0 VA: 0x84C07B0
	public void set_Setter(GenericSetter value) { }

	[CompilerGenerated]
	// RVA: 0x84C07B8 Offset: 0x84BC7B8 VA: 0x84C07B8
	public Func<object, BsonMapper, BsonValue> get_Serialize() { }

	[CompilerGenerated]
	// RVA: 0x84C07C0 Offset: 0x84BC7C0 VA: 0x84C07C0
	public Func<BsonValue, BsonMapper, object> get_Deserialize() { }

	[CompilerGenerated]
	// RVA: 0x84C07C8 Offset: 0x84BC7C8 VA: 0x84C07C8
	public void set_IsList(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84C07D4 Offset: 0x84BC7D4 VA: 0x84C07D4
	public void set_UnderlyingType(Type value) { }

	// RVA: 0x84C07DC Offset: 0x84BC7DC VA: 0x84C07DC
	public void .ctor() { }
}

// Namespace: UltraLiteDB
internal sealed class CreateObject : MulticastDelegate // TypeDefIndex: 26465
{
	// Methods

	// RVA: 0x84C07E4 Offset: 0x84BC7E4 VA: 0x84C07E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x84C0880 Offset: 0x84BC880 VA: 0x84C0880 Slot: 13
	public virtual object Invoke() { }
}

// Namespace: UltraLiteDB
public sealed class GenericSetter : MulticastDelegate // TypeDefIndex: 26466
{
	// Methods

	// RVA: 0x84C0894 Offset: 0x84BC894 VA: 0x84C0894
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x84C09A0 Offset: 0x84BC9A0 VA: 0x84C09A0 Slot: 13
	public virtual void Invoke(object target, object value) { }
}

// Namespace: UltraLiteDB
public sealed class GenericGetter : MulticastDelegate // TypeDefIndex: 26467
{
	// Methods

	// RVA: 0x84C09B4 Offset: 0x84BC9B4 VA: 0x84C09B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x84C0ABC Offset: 0x84BCABC VA: 0x84C0ABC Slot: 13
	public virtual object Invoke(object obj) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Reflection.<>c__DisplayClass9_0 // TypeDefIndex: 26468
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x84C1950 Offset: 0x84BD950 VA: 0x84C1950
	public void .ctor() { }

	// RVA: 0x84C1D68 Offset: 0x84BDD68 VA: 0x84C1D68
	internal object <CreateClass>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Reflection.<>c__DisplayClass10_0 // TypeDefIndex: 26469
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x84C1958 Offset: 0x84BD958 VA: 0x84C1958
	public void .ctor() { }

	// RVA: 0x84C1D74 Offset: 0x84BDD74 VA: 0x84C1D74
	internal object <CreateStruct>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Reflection.<>c__DisplayClass11_0 // TypeDefIndex: 26470
{
	// Fields
	public MethodInfo getMethod; // 0x10

	// Methods

	// RVA: 0x84C1AF0 Offset: 0x84BDAF0 VA: 0x84C1AF0
	public void .ctor() { }

	// RVA: 0x84C1D80 Offset: 0x84BDD80 VA: 0x84C1D80
	internal object <CreateGenericGetter>b__0(object target) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Reflection.<>c__DisplayClass12_0 // TypeDefIndex: 26471
{
	// Fields
	public MethodInfo setMethod; // 0x10

	// Methods

	// RVA: 0x84C1CC8 Offset: 0x84BDCC8 VA: 0x84C1CC8
	public void .ctor() { }

	// RVA: 0x84C1DA0 Offset: 0x84BDDA0 VA: 0x84C1DA0
	internal void <CreateGenericSetter>b__0(object target, object value) { }
}

// Namespace: UltraLiteDB
internal class Reflection // TypeDefIndex: 26472
{
	// Fields
	private static Dictionary<Type, CreateObject> _cacheCtor; // 0x0

	// Methods

	// RVA: 0x84C0AD0 Offset: 0x84BCAD0 VA: 0x84C0AD0
	public static object CreateInstance(Type type) { }

	// RVA: 0x84C17B0 Offset: 0x84BD7B0 VA: 0x84C17B0
	public static bool IsNullable(Type type) { }

	// RVA: 0x84C1438 Offset: 0x84BD438 VA: 0x84C1438
	public static Type UnderlyingTypeOf(Type type) { }

	// RVA: 0x84C14B0 Offset: 0x84BD4B0 VA: 0x84C14B0
	public static Type GetGenericListOfType(Type type) { }

	// RVA: 0x84C15B8 Offset: 0x84BD5B8 VA: 0x84C15B8
	public static Type GetGenericDictionaryOfType(Type k, Type v) { }

	// RVA: 0x84BFA80 Offset: 0x84BBA80 VA: 0x84BFA80
	public static Type GetListItemType(Type listType) { }

	// RVA: 0x84BF8E4 Offset: 0x84BB8E4 VA: 0x84BF8E4
	public static bool IsList(Type type) { }

	// RVA: 0x84C1894 Offset: 0x84BD894 VA: 0x84C1894
	public static MemberInfo SelectMember(IEnumerable<MemberInfo> members, Func<MemberInfo, bool>[] predicates) { }

	// RVA: 0x84C1380 Offset: 0x84BD380 VA: 0x84C1380
	public static CreateObject CreateClass(Type type) { }

	// RVA: 0x84C16F8 Offset: 0x84BD6F8 VA: 0x84C16F8
	public static CreateObject CreateStruct(Type type) { }

	// RVA: 0x84C1960 Offset: 0x84BD960 VA: 0x84C1960
	public static GenericGetter CreateGenericGetter(Type type, MemberInfo memberInfo) { }

	// RVA: 0x84C1AF8 Offset: 0x84BDAF8 VA: 0x84C1AF8
	public static GenericSetter CreateGenericSetter(Type type, MemberInfo memberInfo) { }

	// RVA: 0x84C1CD0 Offset: 0x84BDCD0 VA: 0x84C1CD0
	private static void .cctor() { }
}

// Namespace: UltraLiteDB
internal class AesEncryption // TypeDefIndex: 26473
{
	// Fields
	private Aes _aes; // 0x10

	// Methods

	// RVA: 0x84C1E60 Offset: 0x84BDE60 VA: 0x84C1E60
	public void .ctor(string password, byte[] salt) { }

	// RVA: 0x84C20D0 Offset: 0x84BE0D0 VA: 0x84C20D0
	public byte[] Encrypt(byte[] bytes) { }

	// RVA: 0x84C25E0 Offset: 0x84BE5E0 VA: 0x84C25E0
	public byte[] Decrypt(byte[] encryptedValue) { }

	// RVA: 0x84C2AF0 Offset: 0x84BEAF0 VA: 0x84C2AF0
	public static byte[] HashSHA1(string password) { }

	// RVA: 0x84C2B48 Offset: 0x84BEB48 VA: 0x84C2B48
	public static byte[] Salt(int maxLength = 16) { }

	// RVA: 0x84C2CEC Offset: 0x84BECEC VA: 0x84C2CEC
	public void Dispose() { }
}

// Namespace: UltraLiteDB
public class ByteReader // TypeDefIndex: 26474
{
	// Fields
	private byte[] _buffer; // 0x10
	private int _length; // 0x18
	private int _pos; // 0x1C

	// Properties
	public int Position { get; set; }

	// Methods

	// RVA: 0x84C2D04 Offset: 0x84BED04 VA: 0x84C2D04
	public int get_Position() { }

	// RVA: 0x84C2D0C Offset: 0x84BED0C VA: 0x84C2D0C
	public void set_Position(int value) { }

	// RVA: 0x84C2D14 Offset: 0x84BED14 VA: 0x84C2D14
	public void .ctor(byte[] buffer) { }

	// RVA: 0x84C2D58 Offset: 0x84BED58 VA: 0x84C2D58
	public void Skip(int length) { }

	// RVA: 0x84C2D68 Offset: 0x84BED68 VA: 0x84C2D68
	public byte ReadByte() { }

	// RVA: 0x84C2DA8 Offset: 0x84BEDA8 VA: 0x84C2DA8
	public bool ReadBoolean() { }

	// RVA: 0x84C2DF0 Offset: 0x84BEDF0 VA: 0x84C2DF0
	public ushort ReadUInt16() { }

	// RVA: 0x84C2E0C Offset: 0x84BEE0C VA: 0x84C2E0C
	public uint ReadUInt32() { }

	// RVA: 0x84C2E28 Offset: 0x84BEE28 VA: 0x84C2E28
	public int ReadInt32() { }

	// RVA: 0x84C2E44 Offset: 0x84BEE44 VA: 0x84C2E44
	public long ReadInt64() { }

	// RVA: 0x84C2E60 Offset: 0x84BEE60 VA: 0x84C2E60
	public double ReadDouble() { }

	// RVA: 0x84C2E7C Offset: 0x84BEE7C VA: 0x84C2E7C
	public Decimal ReadDecimal() { }

	// RVA: 0x84C2FBC Offset: 0x84BEFBC VA: 0x84C2FBC
	public byte[] ReadBytes(int count) { }

	// RVA: 0x84C3048 Offset: 0x84BF048 VA: 0x84C3048
	public string ReadString() { }

	// RVA: 0x84C30B4 Offset: 0x84BF0B4 VA: 0x84C30B4
	public string ReadString(int length) { }

	// RVA: 0x84C3108 Offset: 0x84BF108 VA: 0x84C3108
	public string ReadBsonString() { }

	// RVA: 0x84C3174 Offset: 0x84BF174 VA: 0x84C3174
	public string ReadCString() { }

	// RVA: 0x84C3244 Offset: 0x84BF244 VA: 0x84C3244
	public DateTime ReadDateTime() { }

	// RVA: 0x84C32E0 Offset: 0x84BF2E0 VA: 0x84C32E0
	public Guid ReadGuid() { }

	// RVA: 0x84C3314 Offset: 0x84BF314 VA: 0x84C3314
	public ObjectId ReadObjectId() { }

	// RVA: 0x84C3388 Offset: 0x84BF388 VA: 0x84C3388
	internal PageAddress ReadPageAddress() { }

	// RVA: 0x84C33F0 Offset: 0x84BF3F0 VA: 0x84C33F0
	public BsonValue ReadBsonValue(ushort length) { }
}

// Namespace: UltraLiteDB
public class ByteWriter // TypeDefIndex: 26475
{
	// Fields
	private byte[] _buffer; // 0x10
	private int _pos; // 0x18

	// Properties
	public byte[] Buffer { get; }
	public int Position { set; }

	// Methods

	// RVA: 0x84C3800 Offset: 0x84BF800 VA: 0x84C3800
	public byte[] get_Buffer() { }

	// RVA: 0x84C3808 Offset: 0x84BF808 VA: 0x84C3808
	public void set_Position(int value) { }

	// RVA: 0x84C3810 Offset: 0x84BF810 VA: 0x84C3810
	public void .ctor(int length) { }

	// RVA: 0x84C3888 Offset: 0x84BF888 VA: 0x84C3888
	public void Skip(int length) { }

	// RVA: 0x84C3898 Offset: 0x84BF898 VA: 0x84C3898
	public void Write(byte value) { }

	// RVA: 0x84C38D8 Offset: 0x84BF8D8 VA: 0x84C38D8
	public void Write(bool value) { }

	// RVA: 0x84C391C Offset: 0x84BF91C VA: 0x84C391C
	public void Write(ushort value) { }

	// RVA: 0x84C39B0 Offset: 0x84BF9B0 VA: 0x84C39B0
	public void Write(uint value) { }

	// RVA: 0x84C3AAC Offset: 0x84BFAAC VA: 0x84C3AAC
	public void Write(int value) { }

	// RVA: 0x84C3BA8 Offset: 0x84BFBA8 VA: 0x84C3BA8
	public void Write(long value) { }

	// RVA: 0x84C3D74 Offset: 0x84BFD74 VA: 0x84C3D74
	public void Write(double value) { }

	// RVA: 0x84C3F3C Offset: 0x84BFF3C VA: 0x84C3F3C
	public void Write(Decimal value) { }

	// RVA: 0x84C4014 Offset: 0x84C0014 VA: 0x84C4014
	public void Write(byte[] value) { }

	// RVA: 0x84C4064 Offset: 0x84C0064 VA: 0x84C4064
	public void Write(string value) { }

	// RVA: 0x84C40C0 Offset: 0x84C00C0 VA: 0x84C40C0
	public void Write(string value, int length) { }

	// RVA: 0x84C4164 Offset: 0x84C0164 VA: 0x84C4164
	public void Write(DateTime value) { }

	// RVA: 0x84C41EC Offset: 0x84C01EC VA: 0x84C41EC
	public void Write(Guid value) { }

	// RVA: 0x84C4220 Offset: 0x84C0220 VA: 0x84C4220
	public void Write(ObjectId value) { }

	// RVA: 0x84C424C Offset: 0x84C024C VA: 0x84C424C
	internal void Write(PageAddress value) { }

	// RVA: 0x84C4274 Offset: 0x84C0274 VA: 0x84C4274
	public void WriteBsonValue(BsonValue value, ushort length) { }
}

// Namespace: UltraLiteDB
public class Collation : IComparer<BsonValue>, IComparer<string>, IEqualityComparer<BsonValue> // TypeDefIndex: 26476
{
	// Fields
	private readonly CompareInfo _compareInfo; // 0x10
	public static Collation Default; // 0x0
	public static Collation Binary; // 0x8
	[CompilerGenerated]
	private readonly CultureInfo <Culture>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly CompareOptions <SortOptions>k__BackingField; // 0x20

	// Properties
	public CultureInfo Culture { get; }
	public CompareOptions SortOptions { get; }

	// Methods

	// RVA: 0x84C4764 Offset: 0x84C0764 VA: 0x84C4764
	public void .ctor(CompareOptions sortOptions) { }

	[CompilerGenerated]
	// RVA: 0x84C4828 Offset: 0x84C0828 VA: 0x84C4828
	public CultureInfo get_Culture() { }

	[CompilerGenerated]
	// RVA: 0x84C4830 Offset: 0x84C0830 VA: 0x84C4830
	public CompareOptions get_SortOptions() { }

	// RVA: 0x84C4838 Offset: 0x84C0838 VA: 0x84C4838 Slot: 5
	public int Compare(string left, string right) { }

	// RVA: 0x84C4878 Offset: 0x84C0878 VA: 0x84C4878 Slot: 4
	public int Compare(BsonValue left, BsonValue rigth) { }

	// RVA: 0x84C48A4 Offset: 0x84C08A4 VA: 0x84C48A4 Slot: 6
	public bool Equals(BsonValue x, BsonValue y) { }

	// RVA: 0x84C48DC Offset: 0x84C08DC VA: 0x84C48DC Slot: 7
	public int GetHashCode(BsonValue obj) { }

	// RVA: 0x84C4900 Offset: 0x84C0900 VA: 0x84C4900 Slot: 3
	public override string ToString() { }

	// RVA: 0x84C49B4 Offset: 0x84C09B4 VA: 0x84C49B4
	private static void .cctor() { }
}

// Namespace: UltraLiteDB
public class ConnectionString // TypeDefIndex: 26477
{
	// Fields
	[CompilerGenerated]
	private string <Filename>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <Journal>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Password>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <CacheSize>k__BackingField; // 0x28
	[CompilerGenerated]
	private TimeSpan <Timeout>k__BackingField; // 0x30
	[CompilerGenerated]
	private long <InitialSize>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <LimitSize>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <Log>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <UtcDate>k__BackingField; // 0x49
	[CompilerGenerated]
	private bool <Async>k__BackingField; // 0x4A
	[CompilerGenerated]
	private bool <Flush>k__BackingField; // 0x4B

	// Properties
	public string Filename { get; set; }
	public bool Journal { get; }
	public string Password { get; set; }
	public int CacheSize { get; }
	public TimeSpan Timeout { get; }
	public long InitialSize { get; }
	public long LimitSize { get; }
	public byte Log { get; }
	public bool UtcDate { get; }
	public bool Async { get; }
	public bool Flush { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84C4A44 Offset: 0x84C0A44 VA: 0x84C4A44
	public string get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x84C4A4C Offset: 0x84C0A4C VA: 0x84C4A4C
	public void set_Filename(string value) { }

	[CompilerGenerated]
	// RVA: 0x84C4A54 Offset: 0x84C0A54 VA: 0x84C4A54
	public bool get_Journal() { }

	[CompilerGenerated]
	// RVA: 0x84C4A5C Offset: 0x84C0A5C VA: 0x84C4A5C
	public string get_Password() { }

	[CompilerGenerated]
	// RVA: 0x84C4A64 Offset: 0x84C0A64 VA: 0x84C4A64
	public void set_Password(string value) { }

	[CompilerGenerated]
	// RVA: 0x84C4A6C Offset: 0x84C0A6C VA: 0x84C4A6C
	public int get_CacheSize() { }

	[CompilerGenerated]
	// RVA: 0x84C4A74 Offset: 0x84C0A74 VA: 0x84C4A74
	public TimeSpan get_Timeout() { }

	[CompilerGenerated]
	// RVA: 0x84C4A7C Offset: 0x84C0A7C VA: 0x84C4A7C
	public long get_InitialSize() { }

	[CompilerGenerated]
	// RVA: 0x84C4A84 Offset: 0x84C0A84 VA: 0x84C4A84
	public long get_LimitSize() { }

	[CompilerGenerated]
	// RVA: 0x84C4A8C Offset: 0x84C0A8C VA: 0x84C4A8C
	public byte get_Log() { }

	[CompilerGenerated]
	// RVA: 0x84C4A94 Offset: 0x84C0A94 VA: 0x84C4A94
	public bool get_UtcDate() { }

	[CompilerGenerated]
	// RVA: 0x84C4A9C Offset: 0x84C0A9C VA: 0x84C4A9C
	public bool get_Async() { }

	[CompilerGenerated]
	// RVA: 0x84C4AA4 Offset: 0x84C0AA4 VA: 0x84C4AA4
	public bool get_Flush() { }

	// RVA: 0x84C4AAC Offset: 0x84C0AAC VA: 0x84C4AAC
	public void .ctor() { }
}

// Namespace: UltraLiteDB
[Extension]
internal static class BinaryExtensions // TypeDefIndex: 26478
{
	// Methods

	[Extension]
	// RVA: 0x84C4B5C Offset: 0x84C0B5C VA: 0x84C4B5C
	public static int BinaryCompareTo(byte[] lh, byte[] rh) { }
}

// Namespace: UltraLiteDB
[Extension]
internal static class DateExtensions // TypeDefIndex: 26479
{
	// Methods

	[Extension]
	// RVA: 0x84C4C6C Offset: 0x84C0C6C VA: 0x84C4C6C
	public static DateTime Truncate(DateTime dt) { }
}

// Namespace: UltraLiteDB
[Extension]
internal static class DictionaryExtensions // TypeDefIndex: 26480
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static ushort NextIndex<T>(Dictionary<ushort, T> dict) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45724EC Offset: 0x456E4EC VA: 0x45724EC
	|-DictionaryExtensions.NextIndex<object>
	|
	|-RVA: 0x457257C Offset: 0x456E57C VA: 0x457257C
	|-DictionaryExtensions.NextIndex<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetOrDefault<K, T>(IDictionary<K, T> dict, K key, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4572164 Offset: 0x456E164 VA: 0x4572164
	|-DictionaryExtensions.GetOrDefault<object, object>
	|
	|-RVA: 0x4572234 Offset: 0x456E234 VA: 0x4572234
	|-DictionaryExtensions.GetOrDefault<uint, object>
	|
	|-RVA: 0x4572304 Offset: 0x456E304 VA: 0x4572304
	|-DictionaryExtensions.GetOrDefault<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
private sealed class LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<TSource, TKey> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IEnumerator, IDisposable // TypeDefIndex: 26481
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public LinqExtensions.<>c__DisplayClass2_0<TSource, TKey> <>4__this; // 0x0
	private HashSet<TKey> <knownKeys>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4814B8C Offset: 0x4810B8C VA: 0x4814B8C
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<object, PageAddress>..ctor
	|
	|-RVA: 0x4815114 Offset: 0x4811114 VA: 0x4815114
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4814BC0 Offset: 0x4810BC0 VA: 0x4814BC0
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<object, PageAddress>.System.IDisposable.Dispose
	|
	|-RVA: 0x481517C Offset: 0x481117C VA: 0x481517C
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4814BDC Offset: 0x4810BDC VA: 0x4814BDC
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<object, PageAddress>.MoveNext
	|
	|-RVA: 0x48151DC Offset: 0x48111DC VA: 0x48151DC
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4814F7C Offset: 0x4810F7C VA: 0x4814F7C
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<object, PageAddress>.<>m__Finally1
	|
	|-RVA: 0x48157E0 Offset: 0x48117E0 VA: 0x48157E0
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x481502C Offset: 0x481102C VA: 0x481502C
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<object, PageAddress>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x48158EC Offset: 0x48118EC VA: 0x48158EC
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4815034 Offset: 0x4811034 VA: 0x4815034
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<object, PageAddress>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x481598C Offset: 0x481198C VA: 0x481598C
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4815068 Offset: 0x4811068 VA: 0x4815068
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<object, PageAddress>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x48159C0 Offset: 0x48119C0 VA: 0x48159C0
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4815070 Offset: 0x4811070 VA: 0x4815070
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<object, PageAddress>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x4815A64 Offset: 0x4811A64 VA: 0x4815A64
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4815104 Offset: 0x4811104 VA: 0x4815104
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<object, PageAddress>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x4815B74 Offset: 0x4811B74 VA: 0x4815B74
	|-LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LinqExtensions.<>c__DisplayClass2_0<TSource, TKey> // TypeDefIndex: 26482
{
	// Fields
	public IEqualityComparer<TKey> comparer; // 0x0
	public IEnumerable<TSource> source; // 0x0
	public Func<TSource, TKey> keySelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486E2B4 Offset: 0x486A2B4 VA: 0x486E2B4
	|-LinqExtensions.<>c__DisplayClass2_0<object, PageAddress>..ctor
	|
	|-RVA: 0x486E334 Offset: 0x486A334 VA: 0x486E334
	|-LinqExtensions.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(LinqExtensions.<>c__DisplayClass2_0.<<DistinctBy>g___|0>d<TSource, TKey>))]
	// RVA: -1 Offset: -1
	internal IEnumerable<TSource> <DistinctBy>g___|0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x486E2BC Offset: 0x486A2BC VA: 0x486E2BC
	|-LinqExtensions.<>c__DisplayClass2_0<object, PageAddress>.<DistinctBy>g___|0
	|
	|-RVA: 0x486E33C Offset: 0x486A33C VA: 0x486E33C
	|-LinqExtensions.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<DistinctBy>g___|0
	*/
}

// Namespace: UltraLiteDB
[Extension]
internal static class LinqExtensions // TypeDefIndex: 26483
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> DistinctBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46687C8 Offset: 0x46647C8 VA: 0x46687C8
	|-LinqExtensions.DistinctBy<object, PageAddress>
	|
	|-RVA: 0x46688F0 Offset: 0x46648F0 VA: 0x46688F0
	|-LinqExtensions.DistinctBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: UltraLiteDB
[Extension]
internal static class StringExtensions // TypeDefIndex: 26484
{
	// Methods

	[Extension]
	// RVA: 0x84C4DF0 Offset: 0x84C0DF0 VA: 0x84C4DF0
	public static bool IsNullOrWhiteSpace(string str) { }
}

// Namespace: UltraLiteDB
public class FileOptions // TypeDefIndex: 26485
{
	// Fields
	[CompilerGenerated]
	private bool <Journal>k__BackingField; // 0x10
	[CompilerGenerated]
	private long <InitialSize>k__BackingField; // 0x18
	[CompilerGenerated]
	private long <LimitSize>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <Async>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <Flush>k__BackingField; // 0x29

	// Properties
	public bool Journal { get; set; }
	public long InitialSize { get; set; }
	public long LimitSize { get; set; }
	public bool Async { get; set; }
	public bool Flush { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84C4E24 Offset: 0x84C0E24 VA: 0x84C4E24
	public bool get_Journal() { }

	[CompilerGenerated]
	// RVA: 0x84C4E2C Offset: 0x84C0E2C VA: 0x84C4E2C
	public void set_Journal(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84C4E38 Offset: 0x84C0E38 VA: 0x84C4E38
	public long get_InitialSize() { }

	[CompilerGenerated]
	// RVA: 0x84C4E40 Offset: 0x84C0E40 VA: 0x84C4E40
	public void set_InitialSize(long value) { }

	[CompilerGenerated]
	// RVA: 0x84C4E48 Offset: 0x84C0E48 VA: 0x84C4E48
	public long get_LimitSize() { }

	[CompilerGenerated]
	// RVA: 0x84C4E50 Offset: 0x84C0E50 VA: 0x84C4E50
	public void set_LimitSize(long value) { }

	[CompilerGenerated]
	// RVA: 0x84C4E58 Offset: 0x84C0E58 VA: 0x84C4E58
	public bool get_Async() { }

	[CompilerGenerated]
	// RVA: 0x84C4E60 Offset: 0x84C0E60 VA: 0x84C4E60
	public void set_Async(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84C4E6C Offset: 0x84C0E6C VA: 0x84C4E6C
	public bool get_Flush() { }

	[CompilerGenerated]
	// RVA: 0x84C4E74 Offset: 0x84C0E74 VA: 0x84C4E74
	public void set_Flush(bool value) { }

	// RVA: 0x84C4E80 Offset: 0x84C0E80 VA: 0x84C4E80
	public void .ctor() { }
}

// Namespace: UltraLiteDB
public class LazyLoad<T> // TypeDefIndex: 26486
{
	// Fields
	private readonly object _locker; // 0x0
	private readonly Func<T> _createValue; // 0x0
	private bool _isValueCreated; // 0x0
	private T _value; // 0x0

	// Properties
	public T Value { get; }
	public bool IsValueCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B12E54 Offset: 0x4B0EE54 VA: 0x4B12E54
	|-LazyLoad<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public bool get_IsValueCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B12F60 Offset: 0x4B0EF60 VA: 0x4B12F60
	|-LazyLoad<object>.get_IsValueCreated
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> createValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B13028 Offset: 0x4B0F028 VA: 0x4B13028
	|-LazyLoad<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B130F4 Offset: 0x4B0F0F4 VA: 0x4B130F4
	|-LazyLoad<object>.ToString
	*/
}

// Namespace: UltraLiteDB
public class Logger // TypeDefIndex: 26487
{
	// Fields
	[CompilerGenerated]
	private Action<string> Logging; // 0x10
	[CompilerGenerated]
	private byte <Level>k__BackingField; // 0x18

	// Properties
	public byte Level { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84C4EB0 Offset: 0x84C0EB0 VA: 0x84C4EB0
	public byte get_Level() { }

	[CompilerGenerated]
	// RVA: 0x84C4EB8 Offset: 0x84C0EB8 VA: 0x84C4EB8
	public void set_Level(byte value) { }

	// RVA: 0x84C4EC0 Offset: 0x84C0EC0 VA: 0x84C4EC0
	public void .ctor() { }

	// RVA: 0x84C4EDC Offset: 0x84C0EDC VA: 0x84C4EDC
	public void Write(byte level, string message, object[] args) { }
}

// Namespace: UltraLiteDB
internal class StorageUnitHelper // TypeDefIndex: 26488
{
	// Methods

	// RVA: 0x84C526C Offset: 0x84C126C VA: 0x84C526C
	public static string FormatFileSize(long byteCount) { }
}

// Namespace: UltraLiteDB
public class UltraLiteException : Exception // TypeDefIndex: 26489
{
	// Fields
	[CompilerGenerated]
	private int <ErrorCode>k__BackingField; // 0x8C

	// Properties
	private int ErrorCode { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x84C5528 Offset: 0x84C1528 VA: 0x84C5528
	private void set_ErrorCode(int value) { }

	// RVA: 0x84C5530 Offset: 0x84C1530 VA: 0x84C5530
	internal void .ctor(int code, string message, object[] args) { }

	// RVA: 0x84C55C8 Offset: 0x84C15C8 VA: 0x84C55C8
	internal void .ctor(int code, Exception inner, string message, object[] args) { }

	// RVA: 0x84C5668 Offset: 0x84C1668 VA: 0x84C5668
	internal static UltraLiteException InvalidDatabase() { }

	// RVA: 0x84C573C Offset: 0x84C173C VA: 0x84C573C
	internal static UltraLiteException InvalidDatabaseVersion(int version) { }

	// RVA: 0x84C584C Offset: 0x84C184C VA: 0x84C584C
	internal static UltraLiteException FileSizeExceeded(long limit) { }

	// RVA: 0x84C5940 Offset: 0x84C1940 VA: 0x84C5940
	internal static UltraLiteException CollectionLimitExceeded(int limit) { }

	// RVA: 0x84C5A50 Offset: 0x84C1A50 VA: 0x84C5A50
	internal static UltraLiteException IndexLimitExceeded(string collection) { }

	// RVA: 0x84C5B98 Offset: 0x84C1B98 VA: 0x84C5B98
	internal static UltraLiteException IndexDuplicateKey(string field, BsonValue key) { }

	// RVA: 0x84C5CB8 Offset: 0x84C1CB8 VA: 0x84C5CB8
	internal static UltraLiteException IndexKeyTooLong() { }

	// RVA: 0x84C5DC8 Offset: 0x84C1DC8 VA: 0x84C5DC8
	internal static UltraLiteException DatabaseWrongPassword() { }

	// RVA: 0x84C5E9C Offset: 0x84C1E9C VA: 0x84C5E9C
	internal static UltraLiteException InvalidFormat(string field) { }

	// RVA: 0x84C5F84 Offset: 0x84C1F84 VA: 0x84C5F84
	internal static UltraLiteException DocumentMaxDepth(int depth, Type type) { }

	// RVA: 0x84C1228 Offset: 0x84BD228 VA: 0x84C1228
	internal static UltraLiteException InvalidCtor(Type type, Exception inner) { }

	// RVA: 0x84C614C Offset: 0x84C214C VA: 0x84C614C
	internal static UltraLiteException InvalidDataType(string field, BsonValue value) { }

	// RVA: 0x84C629C Offset: 0x84C229C VA: 0x84C629C
	internal static UltraLiteException InvalidTypedName(string type) { }
}

