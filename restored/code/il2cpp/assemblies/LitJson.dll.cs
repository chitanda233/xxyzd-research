// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27614
{}

// Namespace: LitJson
public enum JsonType // TypeDefIndex: 27615
{
	// Fields
	public int value__; // 0x0
	public const JsonType None = 0;
	public const JsonType Object = 1;
	public const JsonType Array = 2;
	public const JsonType String = 3;
	public const JsonType Int = 4;
	public const JsonType Long = 5;
	public const JsonType Double = 6;
	public const JsonType Boolean = 7;
}

// Namespace: LitJson
public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary // TypeDefIndex: 27616
{
	// Properties
	public abstract bool IsArray { get; }
	public abstract bool IsBoolean { get; }
	public abstract bool IsDouble { get; }
	public abstract bool IsInt { get; }
	public abstract bool IsLong { get; }
	public abstract bool IsObject { get; }
	public abstract bool IsString { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsArray();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsBoolean();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsDouble();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsInt();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsLong();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsObject();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsString();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool GetBoolean();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract double GetDouble();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetInt();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract JsonType GetJsonType();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long GetLong();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string GetString();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void SetBoolean(bool val);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SetDouble(double val);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SetInt(int val);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetJsonType(JsonType type);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetLong(long val);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SetString(string val);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract string ToJson();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ToJson(JsonWriter writer);
}

// Namespace: LitJson
[DefaultMember("Item")]
public class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonData> // TypeDefIndex: 27617
{
	// Fields
	private IList<JsonData> inst_array; // 0x10
	private bool inst_boolean; // 0x18
	private double inst_double; // 0x20
	private int inst_int; // 0x28
	private long inst_long; // 0x30
	private IDictionary<string, JsonData> inst_object; // 0x38
	private string inst_string; // 0x40
	private string json; // 0x48
	private JsonType type; // 0x50
	private IList<KeyValuePair<string, JsonData>> object_list; // 0x58

	// Properties
	public int Count { get; }
	public bool IsArray { get; }
	public bool IsBoolean { get; }
	public bool IsDouble { get; }
	public bool IsInt { get; }
	public bool IsLong { get; }
	public bool IsObject { get; }
	public bool IsString { get; }
	public ICollection<string> Keys { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool LitJson.IJsonWrapper.IsArray { get; }
	private bool LitJson.IJsonWrapper.IsBoolean { get; }
	private bool LitJson.IJsonWrapper.IsDouble { get; }
	private bool LitJson.IJsonWrapper.IsInt { get; }
	private bool LitJson.IJsonWrapper.IsLong { get; }
	private bool LitJson.IJsonWrapper.IsObject { get; }
	private bool LitJson.IJsonWrapper.IsString { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private object System.Collections.Specialized.IOrderedDictionary.Item { get; set; }
	private object System.Collections.IList.Item { get; set; }
	public JsonData Item { get; set; }
	public JsonData Item { get; set; }

	// Methods

	// RVA: 0x797C840 Offset: 0x7978840 VA: 0x797C840
	public int get_Count() { }

	// RVA: 0x797C9C0 Offset: 0x79789C0 VA: 0x797C9C0
	public bool get_IsArray() { }

	// RVA: 0x797C9D0 Offset: 0x79789D0 VA: 0x797C9D0
	public bool get_IsBoolean() { }

	// RVA: 0x797C9E0 Offset: 0x79789E0 VA: 0x797C9E0
	public bool get_IsDouble() { }

	// RVA: 0x797C9F0 Offset: 0x79789F0 VA: 0x797C9F0
	public bool get_IsInt() { }

	// RVA: 0x797CA00 Offset: 0x7978A00 VA: 0x797CA00
	public bool get_IsLong() { }

	// RVA: 0x797CA10 Offset: 0x7978A10 VA: 0x797CA10
	public bool get_IsObject() { }

	// RVA: 0x797CA20 Offset: 0x7978A20 VA: 0x797CA20
	public bool get_IsString() { }

	// RVA: 0x797CA30 Offset: 0x7978A30 VA: 0x797CA30
	public ICollection<string> get_Keys() { }

	// RVA: 0x797CC50 Offset: 0x7978C50 VA: 0x797CC50
	public bool ContainsKey(string key) { }

	// RVA: 0x797CD7C Offset: 0x7978D7C VA: 0x797CD7C Slot: 37
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x797CD80 Offset: 0x7978D80 VA: 0x797CD80 Slot: 39
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x797CE2C Offset: 0x7978E2C VA: 0x797CE2C Slot: 38
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x797CED8 Offset: 0x7978ED8 VA: 0x797CED8 Slot: 54
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x797CF84 Offset: 0x7978F84 VA: 0x797CF84 Slot: 53
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x797D030 Offset: 0x7979030 VA: 0x797D030 Slot: 48
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x797D408 Offset: 0x7979408 VA: 0x797D408 Slot: 49
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x797D7E0 Offset: 0x79797E0 VA: 0x797D7E0 Slot: 4
	private bool LitJson.IJsonWrapper.get_IsArray() { }

	// RVA: 0x797D7F0 Offset: 0x79797F0 VA: 0x797D7F0 Slot: 5
	private bool LitJson.IJsonWrapper.get_IsBoolean() { }

	// RVA: 0x797D800 Offset: 0x7979800 VA: 0x797D800 Slot: 6
	private bool LitJson.IJsonWrapper.get_IsDouble() { }

	// RVA: 0x797D810 Offset: 0x7979810 VA: 0x797D810 Slot: 7
	private bool LitJson.IJsonWrapper.get_IsInt() { }

	// RVA: 0x797D820 Offset: 0x7979820 VA: 0x797D820 Slot: 8
	private bool LitJson.IJsonWrapper.get_IsLong() { }

	// RVA: 0x797D830 Offset: 0x7979830 VA: 0x797D830 Slot: 9
	private bool LitJson.IJsonWrapper.get_IsObject() { }

	// RVA: 0x797D840 Offset: 0x7979840 VA: 0x797D840 Slot: 10
	private bool LitJson.IJsonWrapper.get_IsString() { }

	// RVA: 0x797D850 Offset: 0x7979850 VA: 0x797D850 Slot: 31
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x797DA20 Offset: 0x7979A20 VA: 0x797DA20 Slot: 30
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x797DACC Offset: 0x7979ACC VA: 0x797DACC Slot: 46
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x797DB7C Offset: 0x7979B7C VA: 0x797DB7C Slot: 47
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x797E078 Offset: 0x797A078 VA: 0x797E078 Slot: 41
	private object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx) { }

	// RVA: 0x797E13C Offset: 0x797A13C VA: 0x797E13C Slot: 42
	private void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value) { }

	// RVA: 0x797E348 Offset: 0x797A348 VA: 0x797E348 Slot: 25
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x797E3F8 Offset: 0x797A3F8 VA: 0x797E3F8 Slot: 26
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x797E6D8 Offset: 0x797A6D8 VA: 0x797E6D8
	public JsonData get_Item(string prop_name) { }

	// RVA: 0x797DCE0 Offset: 0x7979CE0 VA: 0x797DCE0
	public void set_Item(string prop_name, JsonData value) { }

	// RVA: 0x797E788 Offset: 0x797A788 VA: 0x797E788
	public JsonData get_Item(int index) { }

	// RVA: 0x797E430 Offset: 0x797A430 VA: 0x797E430
	public void set_Item(int index, JsonData value) { }

	// RVA: 0x797E8D8 Offset: 0x797A8D8 VA: 0x797E8D8
	public void .ctor() { }

	// RVA: 0x797E8E0 Offset: 0x797A8E0 VA: 0x797E8E0
	public void .ctor(bool boolean) { }

	// RVA: 0x797E910 Offset: 0x797A910 VA: 0x797E910
	public void .ctor(double number) { }

	// RVA: 0x797E940 Offset: 0x797A940 VA: 0x797E940
	public void .ctor(int number) { }

	// RVA: 0x797E970 Offset: 0x797A970 VA: 0x797E970
	public void .ctor(long number) { }

	// RVA: 0x797E9A0 Offset: 0x797A9A0 VA: 0x797E9A0
	public void .ctor(object obj) { }

	// RVA: 0x797EBD0 Offset: 0x797ABD0 VA: 0x797EBD0
	public void .ctor(string str) { }

	// RVA: 0x797EC08 Offset: 0x797AC08 VA: 0x797EC08
	public static JsonData op_Implicit(bool data) { }

	// RVA: 0x797EC70 Offset: 0x797AC70 VA: 0x797EC70
	public static JsonData op_Implicit(double data) { }

	// RVA: 0x797ECDC Offset: 0x797ACDC VA: 0x797ECDC
	public static JsonData op_Implicit(int data) { }

	// RVA: 0x797ED40 Offset: 0x797AD40 VA: 0x797ED40
	public static JsonData op_Implicit(long data) { }

	// RVA: 0x797EDA4 Offset: 0x797ADA4 VA: 0x797EDA4
	public static JsonData op_Implicit(string data) { }

	// RVA: 0x797EE14 Offset: 0x797AE14 VA: 0x797EE14
	public static bool op_Explicit(JsonData data) { }

	// RVA: 0x797EE80 Offset: 0x797AE80 VA: 0x797EE80
	public static double op_Explicit(JsonData data) { }

	// RVA: 0x797EEEC Offset: 0x797AEEC VA: 0x797EEEC
	public static int op_Explicit(JsonData data) { }

	// RVA: 0x797EF68 Offset: 0x797AF68 VA: 0x797EF68
	public static long op_Explicit(JsonData data) { }

	// RVA: 0x797EFE4 Offset: 0x797AFE4 VA: 0x797EFE4
	public static string op_Explicit(JsonData data) { }

	// RVA: 0x797F050 Offset: 0x797B050 VA: 0x797F050 Slot: 36
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x797F110 Offset: 0x797B110 VA: 0x797F110 Slot: 51
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x797F2DC Offset: 0x797B2DC VA: 0x797F2DC Slot: 52
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x797F410 Offset: 0x797B410 VA: 0x797F410 Slot: 50
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x797F4C4 Offset: 0x797B4C4 VA: 0x797F4C4 Slot: 55
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x797F55C Offset: 0x797B55C VA: 0x797F55C Slot: 56
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x797F7E8 Offset: 0x797B7E8 VA: 0x797F7E8 Slot: 40
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x797F890 Offset: 0x797B890 VA: 0x797F890 Slot: 11
	private bool LitJson.IJsonWrapper.GetBoolean() { }

	// RVA: 0x797F8F4 Offset: 0x797B8F4 VA: 0x797F8F4 Slot: 12
	private double LitJson.IJsonWrapper.GetDouble() { }

	// RVA: 0x797F958 Offset: 0x797B958 VA: 0x797F958 Slot: 13
	private int LitJson.IJsonWrapper.GetInt() { }

	// RVA: 0x797F9BC Offset: 0x797B9BC VA: 0x797F9BC Slot: 15
	private long LitJson.IJsonWrapper.GetLong() { }

	// RVA: 0x797FA20 Offset: 0x797BA20 VA: 0x797FA20 Slot: 16
	private string LitJson.IJsonWrapper.GetString() { }

	// RVA: 0x797FA84 Offset: 0x797BA84 VA: 0x797FA84 Slot: 17
	private void LitJson.IJsonWrapper.SetBoolean(bool val) { }

	// RVA: 0x797FAA0 Offset: 0x797BAA0 VA: 0x797FAA0 Slot: 18
	private void LitJson.IJsonWrapper.SetDouble(double val) { }

	// RVA: 0x797FAB8 Offset: 0x797BAB8 VA: 0x797FAB8 Slot: 19
	private void LitJson.IJsonWrapper.SetInt(int val) { }

	// RVA: 0x797FAD0 Offset: 0x797BAD0 VA: 0x797FAD0 Slot: 21
	private void LitJson.IJsonWrapper.SetLong(long val) { }

	// RVA: 0x797FAE8 Offset: 0x797BAE8 VA: 0x797FAE8 Slot: 22
	private void LitJson.IJsonWrapper.SetString(string val) { }

	// RVA: 0x797FB14 Offset: 0x797BB14 VA: 0x797FB14 Slot: 23
	private string LitJson.IJsonWrapper.ToJson() { }

	// RVA: 0x797FBE8 Offset: 0x797BBE8 VA: 0x797FBE8 Slot: 24
	private void LitJson.IJsonWrapper.ToJson(JsonWriter writer) { }

	// RVA: 0x797FC1C Offset: 0x797BC1C VA: 0x797FC1C Slot: 27
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x797FCF0 Offset: 0x797BCF0 VA: 0x797FCF0 Slot: 29
	private void System.Collections.IList.Clear() { }

	// RVA: 0x797FDAC Offset: 0x797BDAC VA: 0x797FDAC Slot: 28
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x797FE60 Offset: 0x797BE60 VA: 0x797FE60 Slot: 32
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x797FF14 Offset: 0x797BF14 VA: 0x797FF14 Slot: 33
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x797FFE8 Offset: 0x797BFE8 VA: 0x797FFE8 Slot: 34
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x79800AC Offset: 0x797C0AC VA: 0x79800AC Slot: 35
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x7980170 Offset: 0x797C170 VA: 0x7980170 Slot: 43
	private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator() { }

	// RVA: 0x7980290 Offset: 0x797C290 VA: 0x7980290 Slot: 44
	private void System.Collections.Specialized.IOrderedDictionary.Insert(int idx, object key, object value) { }

	// RVA: 0x79803DC Offset: 0x797C3DC VA: 0x79803DC Slot: 45
	private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int idx) { }

	// RVA: 0x797C8EC Offset: 0x79788EC VA: 0x797C8EC
	private ICollection EnsureCollection() { }

	// RVA: 0x797CADC Offset: 0x7978ADC VA: 0x797CADC
	private IDictionary EnsureDictionary() { }

	// RVA: 0x797D8FC Offset: 0x79798FC VA: 0x797D8FC
	private IList EnsureList() { }

	// RVA: 0x797DC54 Offset: 0x7979C54 VA: 0x797DC54
	private JsonData ToJsonData(object obj) { }

	// RVA: 0x7980588 Offset: 0x797C588 VA: 0x7980588
	private static void WriteJson(IJsonWrapper obj, JsonWriter writer) { }

	// RVA: 0x797FC20 Offset: 0x797BC20 VA: 0x797FC20
	public int Add(object value) { }

	// RVA: 0x7981A84 Offset: 0x797DA84 VA: 0x7981A84
	public bool Remove(object obj) { }

	// RVA: 0x7981E10 Offset: 0x797DE10 VA: 0x7981E10
	public void Clear() { }

	// RVA: 0x7981F20 Offset: 0x797DF20 VA: 0x7981F20 Slot: 57
	public bool Equals(JsonData x) { }

	// RVA: 0x79820D0 Offset: 0x797E0D0 VA: 0x79820D0 Slot: 14
	public JsonType GetJsonType() { }

	// RVA: 0x79820D8 Offset: 0x797E0D8 VA: 0x79820D8 Slot: 20
	public void SetJsonType(JsonType type) { }

	// RVA: 0x797FB18 Offset: 0x797BB18 VA: 0x797FB18
	public string ToJson() { }

	// RVA: 0x797FBEC Offset: 0x797BBEC VA: 0x797FBEC
	public void ToJson(JsonWriter writer) { }

	// RVA: 0x79822E4 Offset: 0x797E2E4 VA: 0x79822E4 Slot: 3
	public override string ToString() { }
}

// Namespace: LitJson
internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 27618
{
	// Fields
	private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator; // 0x10

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x7982400 Offset: 0x797E400 VA: 0x7982400 Slot: 8
	public object get_Current() { }

	// RVA: 0x7982464 Offset: 0x797E464 VA: 0x7982464 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x798254C Offset: 0x797E54C VA: 0x798254C Slot: 4
	public object get_Key() { }

	// RVA: 0x79825F8 Offset: 0x797E5F8 VA: 0x79825F8 Slot: 5
	public object get_Value() { }

	// RVA: 0x7980260 Offset: 0x797C260 VA: 0x7980260
	public void .ctor(IEnumerator<KeyValuePair<string, JsonData>> enumerator) { }

	// RVA: 0x79826AC Offset: 0x797E6AC VA: 0x79826AC Slot: 7
	public bool MoveNext() { }

	// RVA: 0x798274C Offset: 0x797E74C VA: 0x798274C Slot: 9
	public void Reset() { }
}

// Namespace: LitJson
public class JsonException : ApplicationException // TypeDefIndex: 27619
{
	// Methods

	// RVA: 0x79827F0 Offset: 0x797E7F0 VA: 0x79827F0
	public void .ctor() { }

	// RVA: 0x79827F8 Offset: 0x797E7F8 VA: 0x79827F8
	internal void .ctor(ParserToken token) { }

	// RVA: 0x7982894 Offset: 0x797E894 VA: 0x7982894
	internal void .ctor(ParserToken token, Exception inner_exception) { }

	// RVA: 0x7982938 Offset: 0x797E938 VA: 0x7982938
	internal void .ctor(int c) { }

	// RVA: 0x79829D4 Offset: 0x797E9D4 VA: 0x79829D4
	internal void .ctor(int c, Exception inner_exception) { }

	// RVA: 0x7982A78 Offset: 0x797EA78 VA: 0x7982A78
	public void .ctor(string message) { }

	// RVA: 0x7982A80 Offset: 0x797EA80 VA: 0x7982A80
	public void .ctor(string message, Exception inner_exception) { }
}

// Namespace: LitJson
internal struct PropertyMetadata // TypeDefIndex: 27620
{
	// Fields
	public MemberInfo Info; // 0x0
	public bool IsField; // 0x8
	public Type Type; // 0x10
}

// Namespace: LitJson
internal struct ArrayMetadata // TypeDefIndex: 27621
{
	// Fields
	private Type element_type; // 0x0
	private bool is_array; // 0x8
	private bool is_list; // 0x9

	// Properties
	public Type ElementType { get; set; }
	public bool IsArray { get; set; }
	public bool IsList { get; set; }

	// Methods

	// RVA: 0x7982A88 Offset: 0x797EA88 VA: 0x7982A88
	public Type get_ElementType() { }

	// RVA: 0x7982B30 Offset: 0x797EB30 VA: 0x7982B30
	public void set_ElementType(Type value) { }

	// RVA: 0x7982B38 Offset: 0x797EB38 VA: 0x7982B38
	public bool get_IsArray() { }

	// RVA: 0x7982B40 Offset: 0x797EB40 VA: 0x7982B40
	public void set_IsArray(bool value) { }

	// RVA: 0x7982B4C Offset: 0x797EB4C VA: 0x7982B4C
	public bool get_IsList() { }

	// RVA: 0x7982B54 Offset: 0x797EB54 VA: 0x7982B54
	public void set_IsList(bool value) { }
}

// Namespace: LitJson
internal struct ObjectMetadata // TypeDefIndex: 27622
{
	// Fields
	private Type element_type; // 0x0
	private bool is_dictionary; // 0x8
	private IDictionary<string, PropertyMetadata> properties; // 0x10

	// Properties
	public Type ElementType { get; set; }
	public bool IsDictionary { get; set; }
	public IDictionary<string, PropertyMetadata> Properties { get; set; }

	// Methods

	// RVA: 0x7982B60 Offset: 0x797EB60 VA: 0x7982B60
	public Type get_ElementType() { }

	// RVA: 0x7982C08 Offset: 0x797EC08 VA: 0x7982C08
	public void set_ElementType(Type value) { }

	// RVA: 0x7982C10 Offset: 0x797EC10 VA: 0x7982C10
	public bool get_IsDictionary() { }

	// RVA: 0x7982C18 Offset: 0x797EC18 VA: 0x7982C18
	public void set_IsDictionary(bool value) { }

	// RVA: 0x7982C24 Offset: 0x797EC24 VA: 0x7982C24
	public IDictionary<string, PropertyMetadata> get_Properties() { }

	// RVA: 0x7982C2C Offset: 0x797EC2C VA: 0x7982C2C
	public void set_Properties(IDictionary<string, PropertyMetadata> value) { }
}

// Namespace: LitJson
internal sealed class ExporterFunc : MulticastDelegate // TypeDefIndex: 27623
{
	// Methods

	// RVA: 0x7982C34 Offset: 0x797EC34 VA: 0x7982C34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7982D40 Offset: 0x797ED40 VA: 0x7982D40 Slot: 13
	public virtual void Invoke(object obj, JsonWriter writer) { }

	// RVA: 0x7982D54 Offset: 0x797ED54 VA: 0x7982D54 Slot: 14
	public virtual IAsyncResult BeginInvoke(object obj, JsonWriter writer, AsyncCallback callback, object object) { }

	// RVA: 0x7982D7C Offset: 0x797ED7C VA: 0x7982D7C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: LitJson
public sealed class ExporterFunc<T> : MulticastDelegate // TypeDefIndex: 27624
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631AF20 Offset: 0x6316F20 VA: 0x631AF20
	|-ExporterFunc<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T obj, JsonWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B02C Offset: 0x631702C VA: 0x631B02C
	|-ExporterFunc<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T obj, JsonWriter writer, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B040 Offset: 0x6317040 VA: 0x631B040
	|-ExporterFunc<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B0C8 Offset: 0x63170C8 VA: 0x631B0C8
	|-ExporterFunc<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: LitJson
internal sealed class ImporterFunc : MulticastDelegate // TypeDefIndex: 27625
{
	// Methods

	// RVA: 0x7982D88 Offset: 0x797ED88 VA: 0x7982D88
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7982E90 Offset: 0x797EE90 VA: 0x7982E90 Slot: 13
	public virtual object Invoke(object input) { }

	// RVA: 0x7982EA4 Offset: 0x797EEA4 VA: 0x7982EA4 Slot: 14
	public virtual IAsyncResult BeginInvoke(object input, AsyncCallback callback, object object) { }

	// RVA: 0x7982EC4 Offset: 0x797EEC4 VA: 0x7982EC4 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}

// Namespace: LitJson
public sealed class ImporterFunc<TJson, TValue> : MulticastDelegate // TypeDefIndex: 27626
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998350 Offset: 0x4994350 VA: 0x4998350
	|-ImporterFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(TJson input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4998458 Offset: 0x4994458 VA: 0x4998458
	|-ImporterFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(TJson input, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x499846C Offset: 0x499446C VA: 0x499846C
	|-ImporterFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TValue EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49984EC Offset: 0x49944EC VA: 0x49984EC
	|-ImporterFunc<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: LitJson
public sealed class WrapperFactory : MulticastDelegate // TypeDefIndex: 27627
{
	// Methods

	// RVA: 0x7982ED0 Offset: 0x797EED0 VA: 0x7982ED0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7982F6C Offset: 0x797EF6C VA: 0x7982F6C Slot: 13
	public virtual IJsonWrapper Invoke() { }

	// RVA: 0x7982F80 Offset: 0x797EF80 VA: 0x7982F80 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x7982FA0 Offset: 0x797EFA0 VA: 0x7982FA0 Slot: 15
	public virtual IJsonWrapper EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JsonMapper.<>c // TypeDefIndex: 27628
{
	// Fields
	public static readonly JsonMapper.<>c <>9; // 0x0
	public static WrapperFactory <>9__23_0; // 0x8
	public static ExporterFunc <>9__24_0; // 0x10
	public static ExporterFunc <>9__24_1; // 0x18
	public static ExporterFunc <>9__24_2; // 0x20
	public static ExporterFunc <>9__24_3; // 0x28
	public static ExporterFunc <>9__24_4; // 0x30
	public static ExporterFunc <>9__24_5; // 0x38
	public static ExporterFunc <>9__24_6; // 0x40
	public static ExporterFunc <>9__24_7; // 0x48
	public static ExporterFunc <>9__24_8; // 0x50
	public static ExporterFunc <>9__24_9; // 0x58
	public static ImporterFunc <>9__25_0; // 0x60
	public static ImporterFunc <>9__25_1; // 0x68
	public static ImporterFunc <>9__25_2; // 0x70
	public static ImporterFunc <>9__25_3; // 0x78
	public static ImporterFunc <>9__25_4; // 0x80
	public static ImporterFunc <>9__25_5; // 0x88
	public static ImporterFunc <>9__25_6; // 0x90
	public static ImporterFunc <>9__25_7; // 0x98
	public static ImporterFunc <>9__25_8; // 0xA0
	public static ImporterFunc <>9__25_9; // 0xA8
	public static ImporterFunc <>9__25_10; // 0xB0
	public static ImporterFunc <>9__25_11; // 0xB8
	public static ImporterFunc <>9__25_12; // 0xC0
	public static ImporterFunc <>9__25_13; // 0xC8
	public static ImporterFunc <>9__25_14; // 0xD0
	public static WrapperFactory <>9__30_0; // 0xD8
	public static WrapperFactory <>9__31_0; // 0xE0
	public static WrapperFactory <>9__32_0; // 0xE8

	// Methods

	// RVA: 0x798B3A8 Offset: 0x79873A8 VA: 0x798B3A8
	private static void .cctor() { }

	// RVA: 0x798B410 Offset: 0x7987410 VA: 0x798B410
	public void .ctor() { }

	// RVA: 0x798B418 Offset: 0x7987418 VA: 0x798B418
	internal IJsonWrapper <ReadSkip>b__23_0() { }

	// RVA: 0x798B474 Offset: 0x7987474 VA: 0x798B474
	internal void <RegisterBaseExporters>b__24_0(object obj, JsonWriter writer) { }

	// RVA: 0x798B528 Offset: 0x7987528 VA: 0x798B528
	internal void <RegisterBaseExporters>b__24_1(object obj, JsonWriter writer) { }

	// RVA: 0x798B5DC Offset: 0x79875DC VA: 0x798B5DC
	internal void <RegisterBaseExporters>b__24_2(object obj, JsonWriter writer) { }

	// RVA: 0x798B6C8 Offset: 0x79876C8 VA: 0x798B6C8
	internal void <RegisterBaseExporters>b__24_3(object obj, JsonWriter writer) { }

	// RVA: 0x798B820 Offset: 0x7987820 VA: 0x798B820
	internal void <RegisterBaseExporters>b__24_4(object obj, JsonWriter writer) { }

	// RVA: 0x798B8D4 Offset: 0x79878D4 VA: 0x798B8D4
	internal void <RegisterBaseExporters>b__24_5(object obj, JsonWriter writer) { }

	// RVA: 0x798B988 Offset: 0x7987988 VA: 0x798B988
	internal void <RegisterBaseExporters>b__24_6(object obj, JsonWriter writer) { }

	// RVA: 0x798BA3C Offset: 0x7987A3C VA: 0x798BA3C
	internal void <RegisterBaseExporters>b__24_7(object obj, JsonWriter writer) { }

	// RVA: 0x798BAF0 Offset: 0x7987AF0 VA: 0x798BAF0
	internal void <RegisterBaseExporters>b__24_8(object obj, JsonWriter writer) { }

	// RVA: 0x798BB6C Offset: 0x7987B6C VA: 0x798BB6C
	internal void <RegisterBaseExporters>b__24_9(object obj, JsonWriter writer) { }

	// RVA: 0x798BC78 Offset: 0x7987C78 VA: 0x798BC78
	internal object <RegisterBaseImporters>b__25_0(object input) { }

	// RVA: 0x798BD48 Offset: 0x7987D48 VA: 0x798BD48
	internal object <RegisterBaseImporters>b__25_1(object input) { }

	// RVA: 0x798BE18 Offset: 0x7987E18 VA: 0x798BE18
	internal object <RegisterBaseImporters>b__25_2(object input) { }

	// RVA: 0x798BEE8 Offset: 0x7987EE8 VA: 0x798BEE8
	internal object <RegisterBaseImporters>b__25_3(object input) { }

	// RVA: 0x798BFB8 Offset: 0x7987FB8 VA: 0x798BFB8
	internal object <RegisterBaseImporters>b__25_4(object input) { }

	// RVA: 0x798C088 Offset: 0x7988088 VA: 0x798C088
	internal object <RegisterBaseImporters>b__25_5(object input) { }

	// RVA: 0x798C158 Offset: 0x7988158 VA: 0x798C158
	internal object <RegisterBaseImporters>b__25_6(object input) { }

	// RVA: 0x798C228 Offset: 0x7988228 VA: 0x798C228
	internal object <RegisterBaseImporters>b__25_7(object input) { }

	// RVA: 0x798C2F4 Offset: 0x79882F4 VA: 0x798C2F4
	internal object <RegisterBaseImporters>b__25_8(object input) { }

	// RVA: 0x798C3C0 Offset: 0x79883C0 VA: 0x798C3C0
	internal object <RegisterBaseImporters>b__25_9(object input) { }

	// RVA: 0x798C4B8 Offset: 0x79884B8 VA: 0x798C4B8
	internal object <RegisterBaseImporters>b__25_10(object input) { }

	// RVA: 0x798C584 Offset: 0x7988584 VA: 0x798C584
	internal object <RegisterBaseImporters>b__25_11(object input) { }

	// RVA: 0x798C654 Offset: 0x7988654 VA: 0x798C654
	internal object <RegisterBaseImporters>b__25_12(object input) { }

	// RVA: 0x798C718 Offset: 0x7988718 VA: 0x798C718
	internal object <RegisterBaseImporters>b__25_13(object input) { }

	// RVA: 0x798C814 Offset: 0x7988814 VA: 0x798C814
	internal object <RegisterBaseImporters>b__25_14(object input) { }

	// RVA: 0x798C8FC Offset: 0x79888FC VA: 0x798C8FC
	internal IJsonWrapper <ToObject>b__30_0() { }

	// RVA: 0x798C950 Offset: 0x7988950 VA: 0x798C950
	internal IJsonWrapper <ToObject>b__31_0() { }

	// RVA: 0x798C9A4 Offset: 0x79889A4 VA: 0x798C9A4
	internal IJsonWrapper <ToObject>b__32_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonMapper.<>c__DisplayClass39_0<T> // TypeDefIndex: 27629
{
	// Fields
	public ExporterFunc<T> exporter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4874C60 Offset: 0x4870C60 VA: 0x4874C60
	|-JsonMapper.<>c__DisplayClass39_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterExporter>b__0(object obj, JsonWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4874C68 Offset: 0x4870C68 VA: 0x4874C68
	|-JsonMapper.<>c__DisplayClass39_0<__Il2CppFullySharedGenericType>.<RegisterExporter>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonMapper.<>c__DisplayClass40_0<TJson, TValue> // TypeDefIndex: 27630
{
	// Fields
	public ImporterFunc<TJson, TValue> importer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4876558 Offset: 0x4872558 VA: 0x4876558
	|-JsonMapper.<>c__DisplayClass40_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <RegisterImporter>b__0(object input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4876560 Offset: 0x4872560 VA: 0x4876560
	|-JsonMapper.<>c__DisplayClass40_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<RegisterImporter>b__0
	*/
}

// Namespace: LitJson
public class JsonMapper // TypeDefIndex: 27631
{
	// Fields
	private static readonly int max_nesting_depth; // 0x0
	private static readonly IFormatProvider datetime_format; // 0x8
	private static readonly IDictionary<Type, ExporterFunc> base_exporters_table; // 0x10
	private static readonly IDictionary<Type, ExporterFunc> custom_exporters_table; // 0x18
	private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table; // 0x20
	private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table; // 0x28
	private static readonly IDictionary<Type, ArrayMetadata> array_metadata; // 0x30
	private static readonly object array_metadata_lock; // 0x38
	private static readonly IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops; // 0x40
	private static readonly object conv_ops_lock; // 0x48
	private static readonly IDictionary<Type, ObjectMetadata> object_metadata; // 0x50
	private static readonly object object_metadata_lock; // 0x58
	private static readonly IDictionary<Type, IList<PropertyMetadata>> type_properties; // 0x60
	private static readonly object type_properties_lock; // 0x68
	private static readonly JsonWriter static_writer; // 0x70
	private static readonly object static_writer_lock; // 0x78

	// Methods

	// RVA: 0x7982FAC Offset: 0x797EFAC VA: 0x7982FAC
	private static void .cctor() { }

	// RVA: 0x79850BC Offset: 0x79810BC VA: 0x79850BC
	private static void AddArrayMetadata(Type type) { }

	// RVA: 0x7985548 Offset: 0x7981548 VA: 0x7985548
	private static void AddObjectMetadata(Type type) { }

	// RVA: 0x7985CD4 Offset: 0x7981CD4 VA: 0x7985CD4
	private static void AddTypeProperties(Type type) { }

	// RVA: 0x7986240 Offset: 0x7982240 VA: 0x7986240
	private static MethodInfo GetConvOp(Type t1, Type t2) { }

	// RVA: 0x7986ACC Offset: 0x7982ACC VA: 0x7986ACC
	private static object ReadValue(Type inst_type, JsonReader reader) { }

	// RVA: 0x7988044 Offset: 0x7984044 VA: 0x7988044
	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader) { }

	// RVA: 0x7987F44 Offset: 0x7983F44 VA: 0x7987F44
	private static void ReadSkip(JsonReader reader) { }

	// RVA: 0x7983464 Offset: 0x797F464 VA: 0x7983464
	private static void RegisterBaseExporters() { }

	// RVA: 0x79841A8 Offset: 0x79801A8 VA: 0x79841A8
	private static void RegisterBaseImporters() { }

	// RVA: 0x7988744 Offset: 0x7984744 VA: 0x7988744
	private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer) { }

	// RVA: 0x7988984 Offset: 0x7984984 VA: 0x7988984
	private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth) { }

	// RVA: 0x798A2D8 Offset: 0x79862D8 VA: 0x798A2D8
	public static string ToJson(object obj) { }

	// RVA: 0x798A6D4 Offset: 0x79866D4 VA: 0x798A6D4
	public static void ToJson(object obj, JsonWriter writer) { }

	// RVA: 0x798A888 Offset: 0x7986888 VA: 0x798A888
	public static JsonData ToObject(JsonReader reader) { }

	// RVA: 0x798AAA8 Offset: 0x7986AA8 VA: 0x798AAA8
	public static JsonData ToObject(TextReader reader) { }

	// RVA: 0x798AD00 Offset: 0x7986D00 VA: 0x798AD00
	public static JsonData ToObject(string json) { }

	// RVA: -1 Offset: -1
	public static T ToObject<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x465191C Offset: 0x464D91C VA: 0x465191C
	|-JsonMapper.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ToObject<T>(TextReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4651F48 Offset: 0x464DF48 VA: 0x4651F48
	|-JsonMapper.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ToObject<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4651674 Offset: 0x464D674 VA: 0x4651674
	|-JsonMapper.ToObject<object>
	|
	|-RVA: 0x4651C08 Offset: 0x464DC08 VA: 0x4651C08
	|-JsonMapper.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x798AFC0 Offset: 0x7986FC0 VA: 0x798AFC0
	public static object ToObject(string json, Type ConvertType) { }

	// RVA: 0x79886E0 Offset: 0x79846E0 VA: 0x79886E0
	public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader) { }

	// RVA: 0x798AF34 Offset: 0x7986F34 VA: 0x798AF34
	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json) { }

	// RVA: -1 Offset: -1
	public static void RegisterExporter<T>(ExporterFunc<T> exporter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x465139C Offset: 0x464D39C VA: 0x465139C
	|-JsonMapper.RegisterExporter<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x465152C Offset: 0x464D52C VA: 0x465152C
	|-JsonMapper.RegisterImporter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x798B208 Offset: 0x7987208 VA: 0x798B208
	public static void UnregisterExporters() { }

	// RVA: 0x798B2D4 Offset: 0x79872D4 VA: 0x798B2D4
	public static void UnregisterImporters() { }

	// RVA: 0x798B3A0 Offset: 0x79873A0 VA: 0x798B3A0
	public void .ctor() { }
}

// Namespace: LitJson
public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary // TypeDefIndex: 27632
{
	// Properties
	public bool IsArray { get; }
	public bool IsBoolean { get; }
	public bool IsDouble { get; }
	public bool IsInt { get; }
	public bool IsLong { get; }
	public bool IsObject { get; }
	public bool IsString { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private object System.Collections.Specialized.IOrderedDictionary.Item { get; set; }

	// Methods

	// RVA: 0x798C9F8 Offset: 0x79889F8 VA: 0x798C9F8 Slot: 4
	public bool get_IsArray() { }

	// RVA: 0x798CA00 Offset: 0x7988A00 VA: 0x798CA00 Slot: 5
	public bool get_IsBoolean() { }

	// RVA: 0x798CA08 Offset: 0x7988A08 VA: 0x798CA08 Slot: 6
	public bool get_IsDouble() { }

	// RVA: 0x798CA10 Offset: 0x7988A10 VA: 0x798CA10 Slot: 7
	public bool get_IsInt() { }

	// RVA: 0x798CA18 Offset: 0x7988A18 VA: 0x798CA18 Slot: 8
	public bool get_IsLong() { }

	// RVA: 0x798CA20 Offset: 0x7988A20 VA: 0x798CA20 Slot: 9
	public bool get_IsObject() { }

	// RVA: 0x798CA28 Offset: 0x7988A28 VA: 0x798CA28 Slot: 10
	public bool get_IsString() { }

	// RVA: 0x798CA30 Offset: 0x7988A30 VA: 0x798CA30 Slot: 11
	public bool GetBoolean() { }

	// RVA: 0x798CA38 Offset: 0x7988A38 VA: 0x798CA38 Slot: 12
	public double GetDouble() { }

	// RVA: 0x798CA40 Offset: 0x7988A40 VA: 0x798CA40 Slot: 13
	public int GetInt() { }

	// RVA: 0x798CA48 Offset: 0x7988A48 VA: 0x798CA48 Slot: 14
	public JsonType GetJsonType() { }

	// RVA: 0x798CA50 Offset: 0x7988A50 VA: 0x798CA50 Slot: 15
	public long GetLong() { }

	// RVA: 0x798CA58 Offset: 0x7988A58 VA: 0x798CA58 Slot: 16
	public string GetString() { }

	// RVA: 0x798CA98 Offset: 0x7988A98 VA: 0x798CA98 Slot: 17
	public void SetBoolean(bool val) { }

	// RVA: 0x798CA9C Offset: 0x7988A9C VA: 0x798CA9C Slot: 18
	public void SetDouble(double val) { }

	// RVA: 0x798CAA0 Offset: 0x7988AA0 VA: 0x798CAA0 Slot: 19
	public void SetInt(int val) { }

	// RVA: 0x798CAA4 Offset: 0x7988AA4 VA: 0x798CAA4 Slot: 20
	public void SetJsonType(JsonType type) { }

	// RVA: 0x798CAA8 Offset: 0x7988AA8 VA: 0x798CAA8 Slot: 21
	public void SetLong(long val) { }

	// RVA: 0x798CAAC Offset: 0x7988AAC VA: 0x798CAAC Slot: 22
	public void SetString(string val) { }

	// RVA: 0x798CAB0 Offset: 0x7988AB0 VA: 0x798CAB0 Slot: 23
	public string ToJson() { }

	// RVA: 0x798CAF0 Offset: 0x7988AF0 VA: 0x798CAF0 Slot: 24
	public void ToJson(JsonWriter writer) { }

	// RVA: 0x798CAF4 Offset: 0x7988AF4 VA: 0x798CAF4 Slot: 31
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x798CAFC Offset: 0x7988AFC VA: 0x798CAFC Slot: 30
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x798CB04 Offset: 0x7988B04 VA: 0x798CB04 Slot: 25
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x798CB0C Offset: 0x7988B0C VA: 0x798CB0C Slot: 26
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x798CB10 Offset: 0x7988B10 VA: 0x798CB10 Slot: 27
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x798CB18 Offset: 0x7988B18 VA: 0x798CB18 Slot: 29
	private void System.Collections.IList.Clear() { }

	// RVA: 0x798CB1C Offset: 0x7988B1C VA: 0x798CB1C Slot: 28
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x798CB24 Offset: 0x7988B24 VA: 0x798CB24 Slot: 32
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x798CB2C Offset: 0x7988B2C VA: 0x798CB2C Slot: 33
	private void System.Collections.IList.Insert(int i, object v) { }

	// RVA: 0x798CB30 Offset: 0x7988B30 VA: 0x798CB30 Slot: 34
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x798CB34 Offset: 0x7988B34 VA: 0x798CB34 Slot: 35
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x798CB38 Offset: 0x7988B38 VA: 0x798CB38 Slot: 37
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x798CB40 Offset: 0x7988B40 VA: 0x798CB40 Slot: 39
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x798CB48 Offset: 0x7988B48 VA: 0x798CB48 Slot: 38
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x798CB50 Offset: 0x7988B50 VA: 0x798CB50 Slot: 36
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x798CB54 Offset: 0x7988B54 VA: 0x798CB54 Slot: 40
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x798CB5C Offset: 0x7988B5C VA: 0x798CB5C Slot: 54
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x798CB64 Offset: 0x7988B64 VA: 0x798CB64 Slot: 53
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x798CB6C Offset: 0x7988B6C VA: 0x798CB6C Slot: 48
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x798CB74 Offset: 0x7988B74 VA: 0x798CB74 Slot: 49
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x798CB7C Offset: 0x7988B7C VA: 0x798CB7C Slot: 46
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x798CB84 Offset: 0x7988B84 VA: 0x798CB84 Slot: 47
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x798CB88 Offset: 0x7988B88 VA: 0x798CB88 Slot: 51
	private void System.Collections.IDictionary.Add(object k, object v) { }

	// RVA: 0x798CB8C Offset: 0x7988B8C VA: 0x798CB8C Slot: 52
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x798CB90 Offset: 0x7988B90 VA: 0x798CB90 Slot: 50
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x798CB98 Offset: 0x7988B98 VA: 0x798CB98 Slot: 56
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x798CB9C Offset: 0x7988B9C VA: 0x798CB9C Slot: 55
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x798CBA4 Offset: 0x7988BA4 VA: 0x798CBA4 Slot: 41
	private object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx) { }

	// RVA: 0x798CBAC Offset: 0x7988BAC VA: 0x798CBAC Slot: 42
	private void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value) { }

	// RVA: 0x798CBB0 Offset: 0x7988BB0 VA: 0x798CBB0 Slot: 43
	private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator() { }

	// RVA: 0x798CBB8 Offset: 0x7988BB8 VA: 0x798CBB8 Slot: 44
	private void System.Collections.Specialized.IOrderedDictionary.Insert(int i, object k, object v) { }

	// RVA: 0x798CBBC Offset: 0x7988BBC VA: 0x798CBBC Slot: 45
	private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int i) { }

	// RVA: 0x798B46C Offset: 0x798746C VA: 0x798B46C
	public void .ctor() { }
}

// Namespace: LitJson
public enum JsonToken // TypeDefIndex: 27633
{
	// Fields
	public int value__; // 0x0
	public const JsonToken None = 0;
	public const JsonToken ObjectStart = 1;
	public const JsonToken PropertyName = 2;
	public const JsonToken ObjectEnd = 3;
	public const JsonToken ArrayStart = 4;
	public const JsonToken ArrayEnd = 5;
	public const JsonToken Int = 6;
	public const JsonToken Long = 7;
	public const JsonToken Double = 8;
	public const JsonToken String = 9;
	public const JsonToken Boolean = 10;
	public const JsonToken Null = 11;
}

// Namespace: LitJson
public class JsonReader // TypeDefIndex: 27634
{
	// Fields
	private static readonly IDictionary<int, IDictionary<int, int[]>> parse_table; // 0x0
	private Stack<int> automaton_stack; // 0x10
	private int current_input; // 0x18
	private int current_symbol; // 0x1C
	private bool end_of_json; // 0x20
	private bool end_of_input; // 0x21
	private Lexer lexer; // 0x28
	private bool parser_in_string; // 0x30
	private bool parser_return; // 0x31
	private bool read_started; // 0x32
	private TextReader reader; // 0x38
	private bool reader_is_owned; // 0x40
	private bool skip_non_members; // 0x41
	private object token_value; // 0x48
	private JsonToken token; // 0x50

	// Properties
	public bool AllowComments { get; set; }
	public bool AllowSingleQuotedStrings { get; set; }
	public bool SkipNonMembers { get; set; }
	public bool EndOfInput { get; }
	public bool EndOfJson { get; }
	public JsonToken Token { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x798CBC0 Offset: 0x7988BC0 VA: 0x798CBC0
	public bool get_AllowComments() { }

	// RVA: 0x798CBE4 Offset: 0x7988BE4 VA: 0x798CBE4
	public void set_AllowComments(bool value) { }

	// RVA: 0x798CC10 Offset: 0x7988C10 VA: 0x798CC10
	public bool get_AllowSingleQuotedStrings() { }

	// RVA: 0x798CC34 Offset: 0x7988C34 VA: 0x798CC34
	public void set_AllowSingleQuotedStrings(bool value) { }

	// RVA: 0x7987F3C Offset: 0x7983F3C VA: 0x7987F3C
	public bool get_SkipNonMembers() { }

	// RVA: 0x798CC60 Offset: 0x7988C60 VA: 0x798CC60
	public void set_SkipNonMembers(bool value) { }

	// RVA: 0x798CC6C Offset: 0x7988C6C VA: 0x798CC6C
	public bool get_EndOfInput() { }

	// RVA: 0x798CC74 Offset: 0x7988C74 VA: 0x798CC74
	public bool get_EndOfJson() { }

	// RVA: 0x7987F2C Offset: 0x7983F2C VA: 0x7987F2C
	public JsonToken get_Token() { }

	// RVA: 0x7987F34 Offset: 0x7983F34 VA: 0x7987F34
	public object get_Value() { }

	// RVA: 0x798CC7C Offset: 0x7988C7C VA: 0x798CC7C
	private static void .cctor() { }

	// RVA: 0x798B198 Offset: 0x7987198 VA: 0x798B198
	public void .ctor(string json_text) { }

	// RVA: 0x798ACF8 Offset: 0x7986CF8 VA: 0x798ACF8
	public void .ctor(TextReader reader) { }

	// RVA: 0x798D438 Offset: 0x7989438 VA: 0x798D438
	private void .ctor(TextReader reader, bool owned) { }

	// RVA: 0x798CCD4 Offset: 0x7988CD4 VA: 0x798CCD4
	private static IDictionary<int, IDictionary<int, int[]>> PopulateParseTable() { }

	// RVA: 0x798D7B4 Offset: 0x79897B4 VA: 0x798D7B4
	private static void TableAddCol(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken row, int col, int[] symbols) { }

	// RVA: 0x798D6C4 Offset: 0x79896C4 VA: 0x798D6C4
	private static void TableAddRow(IDictionary<int, IDictionary<int, int[]>> parse_table, ParserToken rule) { }

	// RVA: 0x798D8E8 Offset: 0x79898E8 VA: 0x798D8E8
	private void ProcessNumber(string number) { }

	// RVA: 0x798DB3C Offset: 0x7989B3C VA: 0x798DB3C
	private void ProcessSymbol() { }

	// RVA: 0x798DD04 Offset: 0x7989D04 VA: 0x798DD04
	private bool ReadToken() { }

	// RVA: 0x798DF30 Offset: 0x7989F30 VA: 0x798DF30
	public void Close() { }

	// RVA: 0x7987AD4 Offset: 0x7983AD4 VA: 0x7987AD4
	public bool Read() { }
}

// Namespace: LitJson
internal enum Condition // TypeDefIndex: 27635
{
	// Fields
	public int value__; // 0x0
	public const Condition InArray = 0;
	public const Condition InObject = 1;
	public const Condition NotAProperty = 2;
	public const Condition Property = 3;
	public const Condition Value = 4;
}

// Namespace: LitJson
internal class WriterContext // TypeDefIndex: 27636
{
	// Fields
	public int Count; // 0x10
	public bool InArray; // 0x14
	public bool InObject; // 0x15
	public bool ExpectingValue; // 0x16
	public int Padding; // 0x18

	// Methods

	// RVA: 0x798E008 Offset: 0x798A008 VA: 0x798E008
	public void .ctor() { }
}

// Namespace: LitJson
public class JsonWriter // TypeDefIndex: 27637
{
	// Fields
	private static readonly NumberFormatInfo number_format; // 0x0
	private WriterContext context; // 0x10
	private Stack<WriterContext> ctx_stack; // 0x18
	private bool has_reached_end; // 0x20
	private char[] hex_seq; // 0x28
	private int indentation; // 0x30
	private int indent_value; // 0x34
	private StringBuilder inst_string_builder; // 0x38
	private bool pretty_print; // 0x40
	private bool validate; // 0x41
	private bool lower_case_properties; // 0x42
	private TextWriter writer; // 0x48

	// Properties
	public int IndentValue { get; set; }
	public bool PrettyPrint { get; set; }
	public TextWriter TextWriter { get; }
	public bool Validate { get; set; }
	public bool LowerCaseProperties { get; set; }

	// Methods

	// RVA: 0x798E010 Offset: 0x798A010 VA: 0x798E010
	public int get_IndentValue() { }

	// RVA: 0x798E018 Offset: 0x798A018 VA: 0x798E018
	public void set_IndentValue(int value) { }

	// RVA: 0x798E02C Offset: 0x798A02C VA: 0x798E02C
	public bool get_PrettyPrint() { }

	// RVA: 0x798E034 Offset: 0x798A034 VA: 0x798E034
	public void set_PrettyPrint(bool value) { }

	// RVA: 0x798A128 Offset: 0x7986128 VA: 0x798A128
	public TextWriter get_TextWriter() { }

	// RVA: 0x79822DC Offset: 0x797E2DC VA: 0x79822DC
	public bool get_Validate() { }

	// RVA: 0x79822D0 Offset: 0x797E2D0 VA: 0x79822D0
	public void set_Validate(bool value) { }

	// RVA: 0x798E040 Offset: 0x798A040 VA: 0x798E040
	public bool get_LowerCaseProperties() { }

	// RVA: 0x798E048 Offset: 0x798A048 VA: 0x798E048
	public void set_LowerCaseProperties(bool value) { }

	// RVA: 0x798E054 Offset: 0x798A054 VA: 0x798E054
	private static void .cctor() { }

	// RVA: 0x79833A4 Offset: 0x797F3A4 VA: 0x79833A4
	public void .ctor() { }

	// RVA: 0x798E1E8 Offset: 0x798A1E8 VA: 0x798E1E8
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x798224C Offset: 0x797E24C VA: 0x798224C
	public void .ctor(TextWriter writer) { }

	// RVA: 0x798E254 Offset: 0x798A254 VA: 0x798E254
	private void DoValidation(Condition cond) { }

	// RVA: 0x798E0B0 Offset: 0x798A0B0 VA: 0x798E0B0
	private void Init() { }

	// RVA: 0x798E3DC Offset: 0x798A3DC VA: 0x798E3DC
	private static void IntToHex(int n, char[] hex) { }

	// RVA: 0x798E454 Offset: 0x798A454 VA: 0x798E454
	private void Indent() { }

	// RVA: 0x798E46C Offset: 0x798A46C VA: 0x798E46C
	private void Put(string str) { }

	// RVA: 0x798E4F8 Offset: 0x798A4F8 VA: 0x798E4F8
	private void PutNewline() { }

	// RVA: 0x798E500 Offset: 0x798A500 VA: 0x798E500
	private void PutNewline(bool add_comma) { }

	// RVA: 0x798E594 Offset: 0x798A594 VA: 0x798E594
	private void PutString(string str) { }

	// RVA: 0x798E89C Offset: 0x798A89C VA: 0x798E89C
	private void Unindent() { }

	// RVA: 0x798E8B4 Offset: 0x798A8B4 VA: 0x798E8B4 Slot: 3
	public override string ToString() { }

	// RVA: 0x798A5E8 Offset: 0x79865E8 VA: 0x798A5E8
	public void Reset() { }

	// RVA: 0x79811F4 Offset: 0x797D1F4 VA: 0x79811F4
	public void Write(bool boolean) { }

	// RVA: 0x798B744 Offset: 0x7987744 VA: 0x798B744
	public void Write(Decimal number) { }

	// RVA: 0x798128C Offset: 0x797D28C VA: 0x798128C
	public void Write(double number) { }

	// RVA: 0x798A130 Offset: 0x7986130 VA: 0x798A130
	public void Write(float number) { }

	// RVA: 0x79813C8 Offset: 0x797D3C8 VA: 0x79813C8
	public void Write(int number) { }

	// RVA: 0x798149C Offset: 0x797D49C VA: 0x798149C
	public void Write(long number) { }

	// RVA: 0x7981168 Offset: 0x797D168 VA: 0x7981168
	public void Write(string str) { }

	// RVA: 0x798A204 Offset: 0x7986204 VA: 0x798A204
	public void Write(ulong number) { }

	// RVA: 0x7981664 Offset: 0x797D664 VA: 0x7981664
	public void WriteArrayEnd() { }

	// RVA: 0x7981570 Offset: 0x797D570 VA: 0x7981570
	public void WriteArrayStart() { }

	// RVA: 0x7981984 Offset: 0x797D984 VA: 0x7981984
	public void WriteObjectEnd() { }

	// RVA: 0x7981764 Offset: 0x797D764 VA: 0x7981764
	public void WriteObjectStart() { }

	// RVA: 0x7981858 Offset: 0x797D858 VA: 0x7981858
	public void WritePropertyName(string property_name) { }
}

// Namespace: LitJson
internal class FsmContext // TypeDefIndex: 27638
{
	// Fields
	public bool Return; // 0x10
	public int NextState; // 0x14
	public Lexer L; // 0x18
	public int StateStack; // 0x20

	// Methods

	// RVA: 0x798E91C Offset: 0x798A91C VA: 0x798E91C
	public void .ctor() { }
}

// Namespace: 
private sealed class Lexer.StateHandler : MulticastDelegate // TypeDefIndex: 27639
{
	// Methods

	// RVA: 0x798F320 Offset: 0x798B320 VA: 0x798F320
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7990808 Offset: 0x798C808 VA: 0x7990808 Slot: 13
	public virtual bool Invoke(FsmContext ctx) { }

	// RVA: 0x799081C Offset: 0x798C81C VA: 0x799081C Slot: 14
	public virtual IAsyncResult BeginInvoke(FsmContext ctx, AsyncCallback callback, object object) { }

	// RVA: 0x799083C Offset: 0x798C83C VA: 0x799083C Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: LitJson
internal class Lexer // TypeDefIndex: 27640
{
	// Fields
	private static readonly int[] fsm_return_table; // 0x0
	private static readonly Lexer.StateHandler[] fsm_handler_table; // 0x8
	private bool allow_comments; // 0x10
	private bool allow_single_quoted_strings; // 0x11
	private bool end_of_input; // 0x12
	private FsmContext fsm_context; // 0x18
	private int input_buffer; // 0x20
	private int input_char; // 0x24
	private TextReader reader; // 0x28
	private int state; // 0x30
	private StringBuilder string_buffer; // 0x38
	private string string_value; // 0x40
	private int token; // 0x48
	private int unichar; // 0x4C

	// Properties
	public bool AllowComments { get; set; }
	public bool AllowSingleQuotedStrings { get; set; }
	public bool EndOfInput { get; }
	public int Token { get; }
	public string StringValue { get; }

	// Methods

	// RVA: 0x798CBDC Offset: 0x7988BDC VA: 0x798CBDC
	public bool get_AllowComments() { }

	// RVA: 0x798CC04 Offset: 0x7988C04 VA: 0x798CC04
	public void set_AllowComments(bool value) { }

	// RVA: 0x798CC2C Offset: 0x7988C2C VA: 0x798CC2C
	public bool get_AllowSingleQuotedStrings() { }

	// RVA: 0x798CC54 Offset: 0x7988C54 VA: 0x798CC54
	public void set_AllowSingleQuotedStrings(bool value) { }

	// RVA: 0x798DF28 Offset: 0x7989F28 VA: 0x798DF28
	public bool get_EndOfInput() { }

	// RVA: 0x798E000 Offset: 0x798A000 VA: 0x798E000
	public int get_Token() { }

	// RVA: 0x798DCFC Offset: 0x7989CFC VA: 0x798DCFC
	public string get_StringValue() { }

	// RVA: 0x798E924 Offset: 0x798A924 VA: 0x798E924
	private static void .cctor() { }

	// RVA: 0x798D5CC Offset: 0x79895CC VA: 0x798D5CC
	public void .ctor(TextReader reader) { }

	// RVA: 0x798F29C Offset: 0x798B29C VA: 0x798F29C
	private static int HexValue(int digit) { }

	// RVA: 0x798E96C Offset: 0x798A96C VA: 0x798E96C
	private static void PopulateFsmTables(out Lexer.StateHandler[] fsm_handler_table, out int[] fsm_return_table) { }

	// RVA: 0x798F428 Offset: 0x798B428 VA: 0x798F428
	private static char ProcessEscChar(int esc_char) { }

	// RVA: 0x798F518 Offset: 0x798B518 VA: 0x798F518
	private static bool State1(FsmContext ctx) { }

	// RVA: 0x798F720 Offset: 0x798B720 VA: 0x798F720
	private static bool State2(FsmContext ctx) { }

	// RVA: 0x798F7C8 Offset: 0x798B7C8 VA: 0x798F7C8
	private static bool State3(FsmContext ctx) { }

	// RVA: 0x798F920 Offset: 0x798B920 VA: 0x798F920
	private static bool State4(FsmContext ctx) { }

	// RVA: 0x798FA18 Offset: 0x798BA18 VA: 0x798FA18
	private static bool State5(FsmContext ctx) { }

	// RVA: 0x798FA94 Offset: 0x798BA94 VA: 0x798FA94
	private static bool State6(FsmContext ctx) { }

	// RVA: 0x798FB90 Offset: 0x798BB90 VA: 0x798FB90
	private static bool State7(FsmContext ctx) { }

	// RVA: 0x798FC24 Offset: 0x798BC24 VA: 0x798FC24
	private static bool State8(FsmContext ctx) { }

	// RVA: 0x798FD14 Offset: 0x798BD14 VA: 0x798FD14
	private static bool State9(FsmContext ctx) { }

	// RVA: 0x798FD7C Offset: 0x798BD7C VA: 0x798FD7C
	private static bool State10(FsmContext ctx) { }

	// RVA: 0x798FDE4 Offset: 0x798BDE4 VA: 0x798FDE4
	private static bool State11(FsmContext ctx) { }

	// RVA: 0x798FE50 Offset: 0x798BE50 VA: 0x798FE50
	private static bool State12(FsmContext ctx) { }

	// RVA: 0x798FEB8 Offset: 0x798BEB8 VA: 0x798FEB8
	private static bool State13(FsmContext ctx) { }

	// RVA: 0x798FF20 Offset: 0x798BF20 VA: 0x798FF20
	private static bool State14(FsmContext ctx) { }

	// RVA: 0x798FF88 Offset: 0x798BF88 VA: 0x798FF88
	private static bool State15(FsmContext ctx) { }

	// RVA: 0x798FFF4 Offset: 0x798BFF4 VA: 0x798FFF4
	private static bool State16(FsmContext ctx) { }

	// RVA: 0x799005C Offset: 0x798C05C VA: 0x799005C
	private static bool State17(FsmContext ctx) { }

	// RVA: 0x79900C4 Offset: 0x798C0C4 VA: 0x79900C4
	private static bool State18(FsmContext ctx) { }

	// RVA: 0x7990130 Offset: 0x798C130 VA: 0x7990130
	private static bool State19(FsmContext ctx) { }

	// RVA: 0x79901D8 Offset: 0x798C1D8 VA: 0x79901D8
	private static bool State20(FsmContext ctx) { }

	// RVA: 0x7990244 Offset: 0x798C244 VA: 0x7990244
	private static bool State21(FsmContext ctx) { }

	// RVA: 0x799037C Offset: 0x798C37C VA: 0x799037C
	private static bool State22(FsmContext ctx) { }

	// RVA: 0x79904F0 Offset: 0x798C4F0 VA: 0x79904F0
	private static bool State23(FsmContext ctx) { }

	// RVA: 0x7990598 Offset: 0x798C598 VA: 0x7990598
	private static bool State24(FsmContext ctx) { }

	// RVA: 0x799060C Offset: 0x798C60C VA: 0x799060C
	private static bool State25(FsmContext ctx) { }

	// RVA: 0x7990688 Offset: 0x798C688 VA: 0x7990688
	private static bool State26(FsmContext ctx) { }

	// RVA: 0x79906F0 Offset: 0x798C6F0 VA: 0x79906F0
	private static bool State27(FsmContext ctx) { }

	// RVA: 0x7990758 Offset: 0x798C758 VA: 0x7990758
	private static bool State28(FsmContext ctx) { }

	// RVA: 0x798F6F0 Offset: 0x798B6F0 VA: 0x798F6F0
	private bool GetChar() { }

	// RVA: 0x79907D0 Offset: 0x798C7D0 VA: 0x79907D0
	private int NextChar() { }

	// RVA: 0x798DD58 Offset: 0x7989D58 VA: 0x798DD58
	public bool NextToken() { }

	// RVA: 0x798F914 Offset: 0x798B914 VA: 0x798F914
	private void UngetChar() { }
}

// Namespace: LitJson
internal enum ParserToken // TypeDefIndex: 27641
{
	// Fields
	public int value__; // 0x0
	public const ParserToken None = 65536;
	public const ParserToken Number = 65537;
	public const ParserToken True = 65538;
	public const ParserToken False = 65539;
	public const ParserToken Null = 65540;
	public const ParserToken CharSeq = 65541;
	public const ParserToken Char = 65542;
	public const ParserToken Text = 65543;
	public const ParserToken Object = 65544;
	public const ParserToken ObjectPrime = 65545;
	public const ParserToken Pair = 65546;
	public const ParserToken PairRest = 65547;
	public const ParserToken Array = 65548;
	public const ParserToken ArrayPrime = 65549;
	public const ParserToken Value = 65550;
	public const ParserToken ValueRest = 65551;
	public const ParserToken String = 65552;
	public const ParserToken End = 65553;
	public const ParserToken Epsilon = 65554;
}

// Namespace: 
internal struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 27642
{}

// Namespace: 
internal struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 // TypeDefIndex: 27643
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 27644
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 59B7E757844D3BF9299877BD1C17451611BFBAB493374D6B18D973FDE534151A /*Metadata offset 0xF4F9B0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 5B979F69B96A61586A09DD4ED26F20534C629B08732AE32FA34B6F8A0049ACDD /*Metadata offset 0xF4F9C0*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7FCA397EF25DB53B2C58A05F9BBFA4E8E0685FDBC8AAF39536123447056895C0 /*Metadata offset 0xF4F9D0*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B257E85A5D3CAB5E738D5A0FD1A7AE96624BFE92CB7915726CBBE1518C3225CF /*Metadata offset 0xF4F9E0*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B7A918F6F138CA8137025633559198B529D28CCEC5A51B005376CC69A5B83D85 /*Metadata offset 0xF4F9F0*/; // 0x30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 C84227140A8A7787B30DFF8BD5693C19AA5A430C4E89FFD0256D7F77B3FEAD82 /*Metadata offset 0xF4FA00*/; // 0x3C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 FC03ECB1D62767A5B31230F548FA4D4C02F01E3DA8CA1FC66C7C332EA16BF206 /*Metadata offset 0xF4FA78*/; // 0xAC
}

