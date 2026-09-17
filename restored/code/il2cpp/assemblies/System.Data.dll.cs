// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 19058
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 19059
{
	// Methods

	// RVA: 0x8084294 Offset: 0x8080294 VA: 0x8084294
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 19060
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x808429C Offset: 0x808029C VA: 0x808429C
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 19061
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x8084324 Offset: 0x8080324 VA: 0x8084324
	public void .ctor(byte ) { }
}

// Namespace: 
internal static class SR // TypeDefIndex: 19062
{
	// Methods

	// RVA: 0x808434C Offset: 0x808034C VA: 0x808434C
	internal static string GetString(string name) { }

	// RVA: 0x8084350 Offset: 0x8080350 VA: 0x8084350
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x80843C0 Offset: 0x80803C0 VA: 0x80843C0
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0x8084438 Offset: 0x8080438 VA: 0x8084438
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }
}

// Namespace: System
internal static class LocalAppContextSwitches // TypeDefIndex: 19063
{
	// Fields
	private static int s_allowArbitraryTypeInstantiation; // 0x0

	// Properties
	public static bool AllowArbitraryTypeInstantiation { get; }

	// Methods

	// RVA: 0x80844C0 Offset: 0x80804C0 VA: 0x80844C0
	public static bool get_AllowArbitraryTypeInstantiation() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LocalAppContext.<>c // TypeDefIndex: 19064
{
	// Fields
	public static readonly LocalAppContext.<>c <>9; // 0x0
	public static Func<bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x808470C Offset: 0x808070C VA: 0x808470C
	private static void .cctor() { }

	// RVA: 0x8084774 Offset: 0x8080774 VA: 0x8084774
	public void .ctor() { }

	// RVA: 0x808477C Offset: 0x808077C VA: 0x808477C
	internal bool <get_DisableCaching>b__6_0() { }
}

// Namespace: System
internal class LocalAppContext // TypeDefIndex: 19065
{
	// Fields
	private static bool s_isDisableCachingInitialized; // 0x0
	private static bool s_disableCaching; // 0x1
	private static object s_syncObject; // 0x8

	// Properties
	private static bool DisableCaching { get; }

	// Methods

	// RVA: 0x8084540 Offset: 0x8080540 VA: 0x8084540
	internal static bool GetCachedSwitchValue(string switchName, ref int switchValue) { }

	// RVA: 0x8084560 Offset: 0x8080560 VA: 0x8084560
	private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue) { }

	// RVA: 0x80845F4 Offset: 0x80805F4 VA: 0x80845F4
	private static bool get_DisableCaching() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[ToolboxItem(False)]
[DefaultProperty("ColumnName")]
[DesignTimeVisible(False)]
public class DataColumn : MarshalByValueComponent // TypeDefIndex: 19066
{
	// Fields
	private bool _allowNull; // 0x20
	private string _caption; // 0x28
	private string _columnName; // 0x30
	private Type _dataType; // 0x38
	private StorageType _storageType; // 0x40
	internal object _defaultValue; // 0x48
	private DataSetDateTime _dateTimeMode; // 0x50
	private DataExpression _expression; // 0x58
	private int _maxLength; // 0x60
	private int _ordinal; // 0x64
	private bool _readOnly; // 0x68
	internal Index _sortIndex; // 0x70
	internal DataTable _table; // 0x78
	private bool _unique; // 0x80
	internal MappingType _columnMapping; // 0x84
	internal int _hashCode; // 0x88
	internal int _errors; // 0x8C
	private bool _isSqlType; // 0x90
	private bool _implementsINullable; // 0x91
	private bool _implementsIChangeTracking; // 0x92
	private bool _implementsIRevertibleChangeTracking; // 0x93
	private bool _implementsIXMLSerializable; // 0x94
	private bool _defaultValueIsNull; // 0x95
	internal List<DataColumn> _dependentColumns; // 0x98
	internal PropertyCollection _extendedProperties; // 0xA0
	private DataStorage _storage; // 0xA8
	private AutoIncrementValue _autoInc; // 0xB0
	internal string _columnUri; // 0xB8
	private string _columnPrefix; // 0xC0
	internal string _encodedColumnName; // 0xC8
	internal SimpleType _simpleType; // 0xD0
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0xD8
	[CompilerGenerated]
	private string <XmlDataType>k__BackingField; // 0xE0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	// Properties
	[DefaultValue(True)]
	public bool AllowDBNull { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(False)]
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValue(0)]
	public long AutoIncrementSeed { get; set; }
	[DefaultValue(1)]
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[RefreshProperties(1)]
	[DefaultValue("")]
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[DefaultValue(typeof(string))]
	[RefreshProperties(1)]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(3)]
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[RefreshProperties(1)]
	[DefaultValue("")]
	public string Expression { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValue(-1)]
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public int Ordinal { get; }
	[DefaultValue(False)]
	public bool ReadOnly { get; set; }
	[DebuggerBrowsable(0)]
	private Index SortIndex { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DesignerSerializationVisibility(0)]
	[DefaultValue(False)]
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValue(1)]
	public virtual MappingType ColumnMapping { get; set; }
	internal bool IsCustomType { get; }
	internal bool ImplementsIXMLSerializable { get; }

	// Methods

	// RVA: 0x80847F4 Offset: 0x80807F4 VA: 0x80847F4
	public void .ctor() { }

	// RVA: 0x8084BA4 Offset: 0x8080BA4 VA: 0x8084BA4
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x8084884 Offset: 0x8080884 VA: 0x8084884
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x8084CC0 Offset: 0x8080CC0 VA: 0x8084CC0
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0x80855D0 Offset: 0x80815D0 VA: 0x80855D0
	public bool get_AllowDBNull() { }

	// RVA: 0x80855D8 Offset: 0x80815D8 VA: 0x80855D8
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x8085BB0 Offset: 0x8081BB0 VA: 0x8085BB0
	public bool get_AutoIncrement() { }

	// RVA: 0x8085BD0 Offset: 0x8081BD0 VA: 0x8085BD0
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x8086AD0 Offset: 0x8082AD0 VA: 0x8086AD0
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x8086B54 Offset: 0x8082B54 VA: 0x8086B54
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x80869CC Offset: 0x80829CC VA: 0x80869CC
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x8086B3C Offset: 0x8082B3C VA: 0x8086B3C
	public long get_AutoIncrementSeed() { }

	// RVA: 0x8086D4C Offset: 0x8082D4C VA: 0x8086D4C
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x8086E3C Offset: 0x8082E3C VA: 0x8086E3C
	public long get_AutoIncrementStep() { }

	// RVA: 0x8086E58 Offset: 0x8082E58 VA: 0x8086E58
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x8086F50 Offset: 0x8082F50 VA: 0x8086F50
	public string get_Caption() { }

	// RVA: 0x8086F6C Offset: 0x8082F6C VA: 0x8086F6C
	public void set_Caption(string value) { }

	// RVA: 0x8087080 Offset: 0x8083080 VA: 0x8087080
	public string get_ColumnName() { }

	// RVA: 0x8087088 Offset: 0x8083088 VA: 0x8087088
	public void set_ColumnName(string value) { }

	// RVA: 0x80874E4 Offset: 0x80834E4 VA: 0x80874E4
	internal string get_EncodedColumnName() { }

	// RVA: 0x8086C58 Offset: 0x8082C58 VA: 0x8086C58
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x8087014 Offset: 0x8083014 VA: 0x8087014
	internal CultureInfo get_Locale() { }

	// RVA: 0x8087564 Offset: 0x8083564 VA: 0x8087564
	internal int get_ObjectID() { }

	// RVA: 0x808756C Offset: 0x808356C VA: 0x808756C
	public string get_Prefix() { }

	// RVA: 0x8087574 Offset: 0x8083574 VA: 0x8087574
	public void set_Prefix(string value) { }

	// RVA: 0x8087724 Offset: 0x8083724 VA: 0x8087724
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x8087848 Offset: 0x8083848 VA: 0x8087848
	internal bool get_Computed() { }

	// RVA: 0x8087858 Offset: 0x8083858 VA: 0x8087858
	internal DataExpression get_DataExpression() { }

	// RVA: 0x8087860 Offset: 0x8083860 VA: 0x8087860
	public Type get_DataType() { }

	// RVA: 0x808613C Offset: 0x808213C VA: 0x808613C
	public void set_DataType(Type value) { }

	// RVA: 0x8088004 Offset: 0x8084004 VA: 0x8088004
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x808800C Offset: 0x808400C VA: 0x808800C
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x8087A78 Offset: 0x8083A78 VA: 0x8087A78
	public object get_DefaultValue() { }

	// RVA: 0x8087BB8 Offset: 0x8083BB8 VA: 0x8087BB8
	public void set_DefaultValue(object value) { }

	// RVA: 0x8088360 Offset: 0x8084360 VA: 0x8088360
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x8088368 Offset: 0x8084368 VA: 0x8088368
	internal void BindExpression() { }

	// RVA: 0x808838C Offset: 0x808438C VA: 0x808838C
	public string get_Expression() { }

	// RVA: 0x8084DE8 Offset: 0x8080DE8 VA: 0x8084DE8
	public void set_Expression(string value) { }

	// RVA: 0x8088820 Offset: 0x8084820 VA: 0x8088820
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x80860E0 Offset: 0x80820E0 VA: 0x80860E0
	internal bool get_HasData() { }

	// RVA: 0x8088890 Offset: 0x8084890 VA: 0x8088890
	internal bool get_ImplementsINullable() { }

	// RVA: 0x8088898 Offset: 0x8084898 VA: 0x8088898
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0x80888A0 Offset: 0x80848A0 VA: 0x80888A0
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x80888A8 Offset: 0x80848A8 VA: 0x80888A8
	internal bool get_IsValueType() { }

	// RVA: 0x80888C4 Offset: 0x80848C4 VA: 0x80888C4
	internal bool get_IsSqlType() { }

	// RVA: 0x80888CC Offset: 0x80848CC VA: 0x80888CC
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x8088970 Offset: 0x8084970 VA: 0x8088970
	public int get_MaxLength() { }

	// RVA: 0x8088978 Offset: 0x8084978 VA: 0x8088978
	public void set_MaxLength(int value) { }

	// RVA: 0x8089198 Offset: 0x8085198 VA: 0x8089198
	public string get_Namespace() { }

	// RVA: 0x8089210 Offset: 0x8085210 VA: 0x8089210
	public void set_Namespace(string value) { }

	// RVA: 0x80893A8 Offset: 0x80853A8 VA: 0x80893A8
	public int get_Ordinal() { }

	// RVA: 0x80893B0 Offset: 0x80853B0 VA: 0x80893B0
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0x80894F0 Offset: 0x80854F0 VA: 0x80894F0
	public bool get_ReadOnly() { }

	// RVA: 0x80884A0 Offset: 0x80844A0 VA: 0x80884A0
	public void set_ReadOnly(bool value) { }

	// RVA: 0x8089538 Offset: 0x8085538 VA: 0x8089538
	private Index get_SortIndex() { }

	// RVA: 0x808961C Offset: 0x808561C VA: 0x808961C
	public DataTable get_Table() { }

	// RVA: 0x8089624 Offset: 0x8085624 VA: 0x8089624
	internal void SetTable(DataTable table) { }

	// RVA: 0x80896F8 Offset: 0x80856F8 VA: 0x80896F8
	private DataRow GetDataRow(int index) { }

	// RVA: 0x80877EC Offset: 0x80837EC VA: 0x80877EC
	internal object get_Item(int record) { }

	// RVA: 0x808971C Offset: 0x808571C VA: 0x808971C
	internal void set_Item(int record, object value) { }

	// RVA: 0x8088794 Offset: 0x8084794 VA: 0x8088794
	internal void InitializeRecord(int record) { }

	// RVA: 0x8089978 Offset: 0x8085978 VA: 0x8089978
	internal void SetValue(int record, object value) { }

	// RVA: 0x8089A80 Offset: 0x8085A80 VA: 0x8089A80
	internal void FreeRecord(int record) { }

	// RVA: 0x8089AA4 Offset: 0x8085AA4 VA: 0x8089AA4
	public bool get_Unique() { }

	// RVA: 0x8089AAC Offset: 0x8085AAC VA: 0x8089AAC
	public void set_Unique(bool value) { }

	// RVA: 0x8089FA0 Offset: 0x8085FA0 VA: 0x8089FA0
	internal void InternalUnique(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8089FAC Offset: 0x8085FAC VA: 0x8089FAC
	internal string get_XmlDataType() { }

	[CompilerGenerated]
	// RVA: 0x8089FB4 Offset: 0x8085FB4 VA: 0x8089FB4
	internal void set_XmlDataType(string value) { }

	// RVA: 0x8089FBC Offset: 0x8085FBC VA: 0x8089FBC
	internal SimpleType get_SimpleType() { }

	// RVA: 0x8084C6C Offset: 0x8080C6C VA: 0x8084C6C
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x8089FC4 Offset: 0x8085FC4 VA: 0x8089FC4 Slot: 16
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x8089FCC Offset: 0x8085FCC VA: 0x8089FCC Slot: 17
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x808A310 Offset: 0x8086310 VA: 0x808A310
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x8088D78 Offset: 0x8084D78 VA: 0x8088D78
	internal bool CheckMaxLength() { }

	// RVA: 0x808A3DC Offset: 0x80863DC VA: 0x808A3DC
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x8085778 Offset: 0x8081778 VA: 0x8085778
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x808A364 Offset: 0x8086364 VA: 0x808A364
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x8089F54 Offset: 0x8085F54 VA: 0x8089F54
	protected void CheckUnique() { }

	// RVA: 0x808A5B0 Offset: 0x80865B0 VA: 0x808A5B0
	internal int Compare(int record1, int record2) { }

	// RVA: 0x808A5D0 Offset: 0x80865D0 VA: 0x808A5D0
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x808A7B0 Offset: 0x80867B0 VA: 0x808A7B0
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x808A7D0 Offset: 0x80867D0 VA: 0x808A7D0
	internal object ConvertValue(object value) { }

	// RVA: 0x808A7F0 Offset: 0x80867F0 VA: 0x808A7F0
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x808A810 Offset: 0x8086810 VA: 0x808A810
	internal DataColumn Clone() { }

	// RVA: 0x808AE40 Offset: 0x8086E40 VA: 0x808AE40
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x808A458 Offset: 0x8086458 VA: 0x808A458
	private int GetStringLength(int record) { }

	// RVA: 0x808AF04 Offset: 0x8086F04 VA: 0x808AF04
	internal void Init(int record) { }

	// RVA: 0x8085E04 Offset: 0x8081E04 VA: 0x8085E04
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x808AF90 Offset: 0x8086F90 VA: 0x808AF90
	internal bool get_IsCustomType() { }

	// RVA: 0x808B004 Offset: 0x8087004 VA: 0x808B004
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x808B0D0 Offset: 0x80870D0 VA: 0x808B0D0
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x80878E8 Offset: 0x80838E8 VA: 0x80878E8
	internal bool IsInRelation() { }

	// RVA: 0x808B0D8 Offset: 0x80870D8 VA: 0x808B0D8
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x808B68C Offset: 0x808768C VA: 0x808B68C
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x808B7FC Offset: 0x80877FC VA: 0x808B7FC
	internal void FinishInitInProgress() { }

	// RVA: 0x808B80C Offset: 0x808780C VA: 0x808B80C Slot: 18
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x808746C Offset: 0x808346C VA: 0x808746C
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x808B834 Offset: 0x8087834 VA: 0x808B834
	private void InsureStorage() { }

	// RVA: 0x808B8D0 Offset: 0x80878D0 VA: 0x808B8D0
	internal void SetCapacity(int capacity) { }

	// RVA: 0x808B90C Offset: 0x808790C VA: 0x808B90C
	internal void OnSetDataSet() { }

	// RVA: 0x808B910 Offset: 0x8087910 VA: 0x808B910 Slot: 3
	public override string ToString() { }

	// RVA: 0x808B984 Offset: 0x8087984 VA: 0x808B984
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x808B9C0 Offset: 0x80879C0 VA: 0x808B9C0
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x808780C Offset: 0x808380C VA: 0x808780C
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x808BA04 Offset: 0x8087A04 VA: 0x808BA04
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x808BA58 Offset: 0x8087A58 VA: 0x808BA58
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x808BA8C Offset: 0x8087A8C VA: 0x808BA8C
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x808BAA8 Offset: 0x8087AA8 VA: 0x808BAA8
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x808BAE4 Offset: 0x8087AE4 VA: 0x808BAE4
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x808BC00 Offset: 0x8087C00 VA: 0x808BC00
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x808865C Offset: 0x808465C VA: 0x808865C
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }
}

// Namespace: System.Data
internal abstract class AutoIncrementValue // TypeDefIndex: 19067
{
	// Fields
	[CompilerGenerated]
	private bool <Auto>k__BackingField; // 0x10

	// Properties
	internal bool Auto { get; set; }
	internal abstract object Current { get; set; }
	internal abstract long Seed { get; set; }
	internal abstract long Step { get; set; }
	internal abstract Type DataType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x808BC98 Offset: 0x8087C98 VA: 0x808BC98
	internal bool get_Auto() { }

	[CompilerGenerated]
	// RVA: 0x808BCA0 Offset: 0x8087CA0 VA: 0x808BCA0
	internal void set_Auto(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void set_Current(object value);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract long get_Seed();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void set_Seed(long value);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract long get_Step();

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void set_Step(long value);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract Type get_DataType();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract void SetCurrent(object value, IFormatProvider formatProvider);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract void SetCurrentAndIncrement(object value);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void MoveAfter();

	// RVA: 0x808AD30 Offset: 0x8086D30 VA: 0x808AD30
	internal AutoIncrementValue Clone() { }

	// RVA: 0x808BCAC Offset: 0x8087CAC VA: 0x808BCAC
	protected void .ctor() { }
}

// Namespace: System.Data
internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 19068
{
	// Fields
	private long _current; // 0x18
	private long _seed; // 0x20
	private long _step; // 0x28

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x808BCB4 Offset: 0x8087CB4 VA: 0x808BCB4 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x808BD10 Offset: 0x8087D10 VA: 0x808BD10 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x808BD88 Offset: 0x8087D88 VA: 0x808BD88 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x808BDF4 Offset: 0x8087DF4 VA: 0x808BDF4 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x808BDFC Offset: 0x8087DFC VA: 0x808BDFC Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x808BF5C Offset: 0x8087F5C VA: 0x808BF5C Slot: 8
	internal override long get_Step() { }

	// RVA: 0x808BF64 Offset: 0x8087F64 VA: 0x808BF64 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x808C024 Offset: 0x8088024 VA: 0x808C024 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x808C038 Offset: 0x8088038 VA: 0x808C038 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x808C0AC Offset: 0x80880AC VA: 0x808C0AC Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x808BE8C Offset: 0x8087E8C VA: 0x808BE8C
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x8086CC4 Offset: 0x8082CC4 VA: 0x8086CC4
	public void .ctor() { }
}

// Namespace: System.Data
internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 19069
{
	// Fields
	private BigInteger _current; // 0x18
	private long _seed; // 0x28
	private BigInteger _step; // 0x30

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x808C214 Offset: 0x8088214 VA: 0x808C214 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x808C270 Offset: 0x8088270 VA: 0x808C270 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x808C2F0 Offset: 0x80882F0 VA: 0x808C2F0 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x808C35C Offset: 0x808835C VA: 0x808C35C Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x808C364 Offset: 0x8088364 VA: 0x808C364 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x808C580 Offset: 0x8088580 VA: 0x808C580 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x808C5E0 Offset: 0x80885E0 VA: 0x808C5E0 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x808C78C Offset: 0x808878C VA: 0x808C78C Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x808C820 Offset: 0x8088820 VA: 0x808C820 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x808C850 Offset: 0x8088850 VA: 0x808C850 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x808C458 Offset: 0x8088458 VA: 0x808C458
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x8086CD4 Offset: 0x8082CD4 VA: 0x8086CD4
	public void .ctor() { }
}

// Namespace: System.Data
[Serializable]
public class DataException : SystemException // TypeDefIndex: 19070
{
	// Methods

	// RVA: 0x808C92C Offset: 0x808892C VA: 0x808C92C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808C934 Offset: 0x8088934 VA: 0x808C934
	public void .ctor() { }

	// RVA: 0x808C990 Offset: 0x8088990 VA: 0x808C990
	public void .ctor(string s) { }

	// RVA: 0x808C9B4 Offset: 0x80889B4 VA: 0x808C9B4
	public void .ctor(string s, Exception innerException) { }
}

// Namespace: System.Data
[Serializable]
public class ConstraintException : DataException // TypeDefIndex: 19071
{
	// Methods

	// RVA: 0x808C9BC Offset: 0x80889BC VA: 0x808C9BC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808C9C4 Offset: 0x80889C4 VA: 0x808C9C4
	public void .ctor() { }

	// RVA: 0x808CA20 Offset: 0x8088A20 VA: 0x808CA20
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class DeletedRowInaccessibleException : DataException // TypeDefIndex: 19072
{
	// Methods

	// RVA: 0x808CA44 Offset: 0x8088A44 VA: 0x808CA44
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808CA4C Offset: 0x8088A4C VA: 0x808CA4C
	public void .ctor() { }

	// RVA: 0x808CAA8 Offset: 0x8088AA8 VA: 0x808CAA8
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class DuplicateNameException : DataException // TypeDefIndex: 19073
{
	// Methods

	// RVA: 0x808CACC Offset: 0x8088ACC VA: 0x808CACC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808CAD4 Offset: 0x8088AD4 VA: 0x808CAD4
	public void .ctor() { }

	// RVA: 0x808CB30 Offset: 0x8088B30 VA: 0x808CB30
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class InRowChangingEventException : DataException // TypeDefIndex: 19074
{
	// Methods

	// RVA: 0x808CB54 Offset: 0x8088B54 VA: 0x808CB54
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808CB5C Offset: 0x8088B5C VA: 0x808CB5C
	public void .ctor() { }

	// RVA: 0x808CBB8 Offset: 0x8088BB8 VA: 0x808CBB8
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class InvalidConstraintException : DataException // TypeDefIndex: 19075
{
	// Methods

	// RVA: 0x808CBDC Offset: 0x8088BDC VA: 0x808CBDC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808CBE4 Offset: 0x8088BE4 VA: 0x808CBE4
	public void .ctor() { }

	// RVA: 0x808CC40 Offset: 0x8088C40 VA: 0x808CC40
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class NoNullAllowedException : DataException // TypeDefIndex: 19076
{
	// Methods

	// RVA: 0x808CC64 Offset: 0x8088C64 VA: 0x808CC64
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808CC6C Offset: 0x8088C6C VA: 0x808CC6C
	public void .ctor() { }

	// RVA: 0x808CCC8 Offset: 0x8088CC8 VA: 0x808CCC8
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class ReadOnlyException : DataException // TypeDefIndex: 19077
{
	// Methods

	// RVA: 0x808CCEC Offset: 0x8088CEC VA: 0x808CCEC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808CCF4 Offset: 0x8088CF4 VA: 0x808CCF4
	public void .ctor() { }

	// RVA: 0x808CD50 Offset: 0x8088D50 VA: 0x808CD50
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class RowNotInTableException : DataException // TypeDefIndex: 19078
{
	// Methods

	// RVA: 0x808CD74 Offset: 0x8088D74 VA: 0x808CD74
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808CD7C Offset: 0x8088D7C VA: 0x808CD7C
	public void .ctor() { }

	// RVA: 0x808CDD8 Offset: 0x8088DD8 VA: 0x808CDD8
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class VersionNotFoundException : DataException // TypeDefIndex: 19079
{
	// Methods

	// RVA: 0x808CDFC Offset: 0x8088DFC VA: 0x808CDFC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x808CE04 Offset: 0x8088E04 VA: 0x808CE04
	public void .ctor() { }

	// RVA: 0x808CE60 Offset: 0x8088E60 VA: 0x808CE60
	public void .ctor(string s) { }
}

// Namespace: System.Data
internal static class ExceptionBuilder // TypeDefIndex: 19080
{
	// Methods

	// RVA: 0x808CE84 Offset: 0x8088E84 VA: 0x808CE84
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x808CF1C Offset: 0x8088F1C VA: 0x808CF1C
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x808858C Offset: 0x808458C VA: 0x808858C
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x80887D0 Offset: 0x80847D0 VA: 0x80887D0
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x808CF6C Offset: 0x8088F6C VA: 0x808CF6C
	internal static Exception _Argument(string error) { }

	// RVA: 0x808CFC8 Offset: 0x8088FC8 VA: 0x808CFC8
	internal static Exception _Argument(string paramName, string error) { }

	// RVA: 0x808D024 Offset: 0x8089024 VA: 0x808D024
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x808D090 Offset: 0x8089090 VA: 0x808D090
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x808D0FC Offset: 0x80890FC VA: 0x808D0FC
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x808D168 Offset: 0x8089168 VA: 0x808D168
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x808D1C4 Offset: 0x80891C4 VA: 0x808D1C4
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x808D220 Offset: 0x8089220 VA: 0x808D220
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45EE9E8 Offset: 0x45EA9E8 VA: 0x45EE9E8
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0x45EEAE0 Offset: 0x45EAAE0 VA: 0x45EEAE0
	|-ExceptionBuilder._InvalidEnumArgumentException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x808D27C Offset: 0x808927C VA: 0x808D27C
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x808D2CC Offset: 0x80892CC VA: 0x808D2CC
	private static Exception _Data(string error) { }

	// RVA: 0x808D334 Offset: 0x8089334 VA: 0x808D334
	private static Exception _Constraint(string error) { }

	// RVA: 0x808D39C Offset: 0x808939C VA: 0x808D39C
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x808D404 Offset: 0x8089404 VA: 0x808D404
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x808D46C Offset: 0x808946C VA: 0x808D46C
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x808D4D4 Offset: 0x80894D4 VA: 0x808D4D4
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x808D53C Offset: 0x808953C VA: 0x808D53C
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x808D5A4 Offset: 0x80895A4 VA: 0x808D5A4
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x808D60C Offset: 0x808960C VA: 0x808D60C
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x808D674 Offset: 0x8089674 VA: 0x808D674
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x8084BB0 Offset: 0x8080BB0 VA: 0x8084BB0
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x808D6DC Offset: 0x80896DC VA: 0x808D6DC
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x808D730 Offset: 0x8089730 VA: 0x808D730
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x808D77C Offset: 0x808977C VA: 0x808D77C
	public static Exception ArgumentContainsNull(string paramName) { }

	// RVA: 0x808D7CC Offset: 0x80897CC VA: 0x808D7CC
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0x808D838 Offset: 0x8089838 VA: 0x808D838
	public static Exception CannotModifyCollection() { }

	// RVA: 0x808D878 Offset: 0x8089878 VA: 0x808D878
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x808D8C4 Offset: 0x80898C4 VA: 0x808D8C4
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x808D910 Offset: 0x8089910 VA: 0x808D910
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x808D950 Offset: 0x8089950 VA: 0x808D950
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x808D9AC Offset: 0x80899AC VA: 0x808D9AC
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x808D9EC Offset: 0x80899EC VA: 0x808D9EC
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x808DA7C Offset: 0x8089A7C VA: 0x808DA7C
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x808DAC8 Offset: 0x8089AC8 VA: 0x808DAC8
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x808DB14 Offset: 0x8089B14 VA: 0x808DB14
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x808A284 Offset: 0x8086284 VA: 0x808A284
	public static Exception CannotAddColumn3() { }

	// RVA: 0x808A2C4 Offset: 0x80862C4 VA: 0x808A2C4
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x808DB60 Offset: 0x8089B60 VA: 0x808DB60
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x808DBAC Offset: 0x8089BAC VA: 0x808DBAC
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x808DBF8 Offset: 0x8089BF8 VA: 0x808DBF8
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x808DC44 Offset: 0x8089C44 VA: 0x808DC44
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x808DC84 Offset: 0x8089C84 VA: 0x808DC84
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x808DCC4 Offset: 0x8089CC4 VA: 0x808DCC4
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x808DD10 Offset: 0x8089D10 VA: 0x808DD10
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x808DD6C Offset: 0x8089D6C VA: 0x808DD6C
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x808DDC8 Offset: 0x8089DC8 VA: 0x808DDC8
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x808DE08 Offset: 0x8089E08 VA: 0x808DE08
	public static Exception NoConstraintName() { }

	// RVA: 0x808DE48 Offset: 0x8089E48 VA: 0x808DE48
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x808DE94 Offset: 0x8089E94 VA: 0x808DE94
	public static string KeysToString(object[] keys) { }

	// RVA: 0x808DFB8 Offset: 0x8089FB8 VA: 0x808DFB8
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x808E124 Offset: 0x808A124 VA: 0x808E124
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x808E134 Offset: 0x808A134 VA: 0x808E134
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x808E1C4 Offset: 0x808A1C4 VA: 0x808E1C4
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x808E210 Offset: 0x808A210 VA: 0x808E210
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x808E25C Offset: 0x808A25C VA: 0x808E25C
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x808E2E4 Offset: 0x808A2E4 VA: 0x808E2E4
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x808E324 Offset: 0x808A324 VA: 0x808E324
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x808E364 Offset: 0x808A364 VA: 0x808E364
	public static Exception ConstraintParentValues() { }

	// RVA: 0x808E3A4 Offset: 0x808A3A4 VA: 0x808E3A4
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x808E3F8 Offset: 0x808A3F8 VA: 0x808E3F8
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x808E438 Offset: 0x808A438 VA: 0x808E438
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x808E484 Offset: 0x808A484 VA: 0x808E484
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x808E4D0 Offset: 0x808A4D0 VA: 0x808E4D0
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x808E534 Offset: 0x808A534 VA: 0x808E534
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x808E59C Offset: 0x808A59C VA: 0x808E59C
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x808B644 Offset: 0x8087644 VA: 0x808B644
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x808B7B4 Offset: 0x80877B4 VA: 0x808B7B4
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x808E604 Offset: 0x808A604 VA: 0x808E604
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x8085D84 Offset: 0x8081D84 VA: 0x8085D84
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x8085DC4 Offset: 0x8081DC4 VA: 0x8085DC4
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x808BFE4 Offset: 0x8087FE4 VA: 0x808BFE4
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x8087868 Offset: 0x8083868 VA: 0x8087868
	public static Exception CantChangeDataType() { }

	// RVA: 0x80878A8 Offset: 0x80838A8 VA: 0x80878A8
	public static Exception NullDataType() { }

	// RVA: 0x808742C Offset: 0x808342C VA: 0x808742C
	public static Exception ColumnNameRequired() { }

	// RVA: 0x8088278 Offset: 0x8084278 VA: 0x8088278
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x8087ED0 Offset: 0x8083ED0 VA: 0x8087ED0
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x80882B8 Offset: 0x80842B8 VA: 0x80882B8
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x80883E8 Offset: 0x80843E8 VA: 0x80883E8
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x80885DC Offset: 0x80845DC VA: 0x80885DC
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x8088428 Offset: 0x8084428 VA: 0x8088428
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x808E650 Offset: 0x808A650 VA: 0x808E650
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x808861C Offset: 0x808461C VA: 0x808861C
	public static Exception ExpressionCircular() { }

	// RVA: 0x808A564 Offset: 0x8086564 VA: 0x808A564
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x808A4CC Offset: 0x80864CC VA: 0x808A4CC
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x808A518 Offset: 0x8086518 VA: 0x808A518
	public static Exception NullValues(string column) { }

	// RVA: 0x80894F8 Offset: 0x80854F8 VA: 0x80894F8
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x808E6A4 Offset: 0x808A6A4 VA: 0x808E6A4
	public static Exception ReadOnly(string column) { }

	// RVA: 0x8089F14 Offset: 0x8085F14 VA: 0x8089F14
	public static Exception UniqueAndExpression() { }

	// RVA: 0x808989C Offset: 0x808589C VA: 0x808989C
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x808E6F0 Offset: 0x808A6F0 VA: 0x808E6F0
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x808A478 Offset: 0x8086478 VA: 0x808A478
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x80890F4 Offset: 0x80850F4 VA: 0x80890F4
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x8088CD0 Offset: 0x8084CD0 VA: 0x8088CD0
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x8087FA8 Offset: 0x8083FA8 VA: 0x8087FA8
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x808A228 Offset: 0x8086228 VA: 0x808A228
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x808935C Offset: 0x808535C VA: 0x808935C
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x8088D24 Offset: 0x8084D24 VA: 0x8088D24
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x80860F0 Offset: 0x80820F0 VA: 0x80860F0
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x808E744 Offset: 0x808A744 VA: 0x808E744
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x808E790 Offset: 0x808A790 VA: 0x808E790
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x808E7DC Offset: 0x808A7DC VA: 0x808E7DC
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x808E828 Offset: 0x808A828 VA: 0x808E828
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x8088138 Offset: 0x8084138 VA: 0x8088138
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x8088230 Offset: 0x8084230 VA: 0x8088230
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x8088178 Offset: 0x8084178 VA: 0x8088178
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x8084C04 Offset: 0x8080C04 VA: 0x8084C04
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x808E894 Offset: 0x808A894 VA: 0x808E894
	public static Exception SetFailed(string name) { }

	// RVA: 0x808E8E0 Offset: 0x808A8E0 VA: 0x808E8E0
	public static Exception SetRowStateFilter() { }

	// RVA: 0x808E920 Offset: 0x808A920 VA: 0x808E920
	public static Exception CanNotUseDataViewManager() { }

	// RVA: 0x808E960 Offset: 0x808A960 VA: 0x808E960
	public static Exception CanNotSetTable() { }

	// RVA: 0x808E9A0 Offset: 0x808A9A0 VA: 0x808E9A0
	public static Exception CanNotUse() { }

	// RVA: 0x808E9E0 Offset: 0x808A9E0 VA: 0x808E9E0
	public static Exception CanNotBindTable() { }

	// RVA: 0x808EA20 Offset: 0x808AA20 VA: 0x808EA20
	public static Exception SetTable() { }

	// RVA: 0x808EA60 Offset: 0x808AA60 VA: 0x808EA60
	public static Exception SetIListObject() { }

	// RVA: 0x808EAA0 Offset: 0x808AAA0 VA: 0x808EAA0
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x808EAE0 Offset: 0x808AAE0 VA: 0x808EAE0
	public static Exception NotOpen() { }

	// RVA: 0x808EB20 Offset: 0x808AB20 VA: 0x808EB20
	public static Exception CreateChildView() { }

	// RVA: 0x808EB60 Offset: 0x808AB60 VA: 0x808EB60
	public static Exception CanNotDelete() { }

	// RVA: 0x808EBA0 Offset: 0x808ABA0 VA: 0x808EBA0
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x808EC30 Offset: 0x808AC30 VA: 0x808EC30
	public static Exception AddExternalObject() { }

	// RVA: 0x808EC70 Offset: 0x808AC70 VA: 0x808EC70
	public static Exception CanNotClear() { }

	// RVA: 0x808ECB0 Offset: 0x808ACB0 VA: 0x808ECB0
	public static Exception InsertExternalObject() { }

	// RVA: 0x808ECF0 Offset: 0x808ACF0 VA: 0x808ECF0
	public static Exception RemoveExternalObject() { }

	// RVA: 0x808ED30 Offset: 0x808AD30 VA: 0x808ED30
	public static Exception ColumnToSortIsOutOfRange(string column) { }

	// RVA: 0x808ED7C Offset: 0x808AD7C VA: 0x808ED7C
	public static Exception KeyTableMismatch() { }

	// RVA: 0x808EDBC Offset: 0x808ADBC VA: 0x808EDBC
	public static Exception KeyNoColumns() { }

	// RVA: 0x808EDFC Offset: 0x808ADFC VA: 0x808EDFC
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x808EE8C Offset: 0x808AE8C VA: 0x808EE8C
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x808EED8 Offset: 0x808AED8 VA: 0x808EED8
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x8087A38 Offset: 0x8083A38 VA: 0x8087A38
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x808EF18 Offset: 0x808AF18 VA: 0x808EF18
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x808EF58 Offset: 0x808AF58 VA: 0x808EF58
	public static Exception KeyLengthZero() { }

	// RVA: 0x808EF98 Offset: 0x808AF98 VA: 0x808EF98
	public static Exception ForeignRelation() { }

	// RVA: 0x808EFD8 Offset: 0x808AFD8 VA: 0x808EFD8
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x808F018 Offset: 0x808B018 VA: 0x808F018
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x808F074 Offset: 0x808B074 VA: 0x808F074
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x808F0D0 Offset: 0x808B0D0 VA: 0x808F0D0
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x808F12C Offset: 0x808B12C VA: 0x808F12C
	public static Exception RelationForeignRow() { }

	// RVA: 0x808F16C Offset: 0x808B16C VA: 0x808F16C
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x808F1AC Offset: 0x808B1AC VA: 0x808F1AC
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x808F1F8 Offset: 0x808B1F8 VA: 0x808F1F8
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x808F244 Offset: 0x808B244 VA: 0x808F244
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x808F284 Offset: 0x808B284 VA: 0x808F284
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x808F2C4 Offset: 0x808B2C4 VA: 0x808F2C4
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x808F310 Offset: 0x808B310 VA: 0x808F310
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x808F35C Offset: 0x808B35C VA: 0x808F35C
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x808F39C Offset: 0x808B39C VA: 0x808F39C
	public static Exception RowNotInTheTable() { }

	// RVA: 0x808F3DC Offset: 0x808B3DC VA: 0x808F3DC
	public static Exception EditInRowChanging() { }

	// RVA: 0x808F41C Offset: 0x808B41C VA: 0x808F41C
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x808F45C Offset: 0x808B45C VA: 0x808F45C
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x808F49C Offset: 0x808B49C VA: 0x808F49C
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x808F4DC Offset: 0x808B4DC VA: 0x808F4DC
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x808F51C Offset: 0x808B51C VA: 0x808F51C
	public static Exception ValueArrayLength() { }

	// RVA: 0x808F55C Offset: 0x808B55C VA: 0x808F55C
	public static Exception NoCurrentData() { }

	// RVA: 0x808F59C Offset: 0x808B59C VA: 0x808F59C
	public static Exception NoOriginalData() { }

	// RVA: 0x808F5DC Offset: 0x808B5DC VA: 0x808F5DC
	public static Exception NoProposedData() { }

	// RVA: 0x808F61C Offset: 0x808B61C VA: 0x808F61C
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x808F65C Offset: 0x808B65C VA: 0x808F65C
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x808F69C Offset: 0x808B69C VA: 0x808F69C
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x808F6DC Offset: 0x808B6DC VA: 0x808F6DC
	public static Exception RowEmpty() { }

	// RVA: 0x808F71C Offset: 0x808B71C VA: 0x808F71C
	public static Exception InvalidRowVersion() { }

	// RVA: 0x808F75C Offset: 0x808B75C VA: 0x808F75C
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x808F7EC Offset: 0x808B7EC VA: 0x808F7EC
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x808F88C Offset: 0x808B88C VA: 0x808F88C
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x808F8D8 Offset: 0x808B8D8 VA: 0x808F8D8
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x808F918 Offset: 0x808B918 VA: 0x808F918
	public static Exception MultipleParents() { }

	// RVA: 0x808F958 Offset: 0x808B958 VA: 0x808F958
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x808F9A0 Offset: 0x808B9A0 VA: 0x808F9A0
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x808F9E0 Offset: 0x808B9E0 VA: 0x808F9E0
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x808FA20 Offset: 0x808BA20 VA: 0x808FA20
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x808FA6C Offset: 0x808BA6C VA: 0x808FA6C
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x808FAB8 Offset: 0x808BAB8 VA: 0x808FAB8
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x808FB04 Offset: 0x808BB04 VA: 0x808FB04
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x808FB44 Offset: 0x808BB44 VA: 0x808FB44
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x808FB84 Offset: 0x808BB84 VA: 0x808FB84
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x808FBC4 Offset: 0x808BBC4 VA: 0x808FBC4
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x808FC04 Offset: 0x808BC04 VA: 0x808FC04
	public static Exception RecordStateRange() { }

	// RVA: 0x808FC44 Offset: 0x808BC44 VA: 0x808FC44
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x808FD20 Offset: 0x808BD20 VA: 0x808FD20
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x808FD9C Offset: 0x808BD9C VA: 0x808FD9C
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x808FDDC Offset: 0x808BDDC VA: 0x808FDDC
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x808FE1C Offset: 0x808BE1C VA: 0x808FE1C
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x808FE68 Offset: 0x808BE68 VA: 0x808FE68
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x808FEEC Offset: 0x808BEEC VA: 0x808FEEC
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x808FF38 Offset: 0x808BF38 VA: 0x808FF38
	public static Exception RelationTableNull() { }

	// RVA: 0x808FF78 Offset: 0x808BF78 VA: 0x808FF78
	public static Exception RelationDataSetNull() { }

	// RVA: 0x808FFB8 Offset: 0x808BFB8 VA: 0x808FFB8
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x808FFF8 Offset: 0x808BFF8 VA: 0x808FFF8
	public static Exception ParentTableMismatch() { }

	// RVA: 0x8090038 Offset: 0x808C038 VA: 0x8090038
	public static Exception ChildTableMismatch() { }

	// RVA: 0x8090078 Offset: 0x808C078 VA: 0x8090078
	public static Exception EnforceConstraint() { }

	// RVA: 0x80900B8 Offset: 0x808C0B8 VA: 0x80900B8
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x80900F8 Offset: 0x808C0F8 VA: 0x80900F8
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x8090100 Offset: 0x808C100 VA: 0x8090100
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x8090148 Offset: 0x808C148 VA: 0x8090148
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x8090190 Offset: 0x808C190 VA: 0x8090190
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x80901D0 Offset: 0x808C1D0 VA: 0x80901D0
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x8090210 Offset: 0x808C210 VA: 0x8090210
	public static Exception NoTableName() { }

	// RVA: 0x8090250 Offset: 0x808C250 VA: 0x8090250
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x8090290 Offset: 0x808C290 VA: 0x8090290
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x80902DC Offset: 0x808C2DC VA: 0x80902DC
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x8090328 Offset: 0x808C328 VA: 0x8090328
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x8090384 Offset: 0x808C384 VA: 0x8090384
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x80903D0 Offset: 0x808C3D0 VA: 0x80903D0
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x809041C Offset: 0x808C41C VA: 0x809041C
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x809045C Offset: 0x808C45C VA: 0x809045C
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x809049C Offset: 0x808C49C VA: 0x809049C
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x809052C Offset: 0x808C52C VA: 0x809052C
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x8090578 Offset: 0x808C578 VA: 0x8090578
	public static Exception TableInRelation() { }

	// RVA: 0x80905B8 Offset: 0x808C5B8 VA: 0x80905B8
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x8090630 Offset: 0x808C630 VA: 0x8090630
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x8090670 Offset: 0x808C670 VA: 0x8090670
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x80906B0 Offset: 0x808C6B0 VA: 0x80906B0
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x80906F0 Offset: 0x808C6F0 VA: 0x80906F0
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x8090730 Offset: 0x808C730 VA: 0x8090730
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x809077C Offset: 0x808C77C VA: 0x809077C
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x8090838 Offset: 0x808C838 VA: 0x8090838
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x80908CC Offset: 0x808C8CC VA: 0x80908CC
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x809097C Offset: 0x808C97C VA: 0x809097C
	public static Exception NullRange() { }

	// RVA: 0x80909BC Offset: 0x808C9BC VA: 0x80909BC
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x80909FC Offset: 0x808C9FC VA: 0x80909FC
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x8090AD8 Offset: 0x808CAD8 VA: 0x8090AD8
	public static Exception StorageSetFailed() { }

	// RVA: 0x8090B18 Offset: 0x808CB18 VA: 0x8090B18
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x8090B58 Offset: 0x808CB58 VA: 0x8090B58
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x8090BA8 Offset: 0x808CBA8 VA: 0x8090BA8
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x8090C04 Offset: 0x808CC04 VA: 0x8090C04
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x8090C60 Offset: 0x808CC60 VA: 0x8090C60
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x8090CC4 Offset: 0x808CCC4 VA: 0x8090CC4
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x8090D10 Offset: 0x808CD10 VA: 0x8090D10
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x8090D5C Offset: 0x808CD5C VA: 0x8090D5C
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x8090DA8 Offset: 0x808CDA8 VA: 0x8090DA8
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x8090DF4 Offset: 0x808CDF4 VA: 0x8090DF4
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x8090E40 Offset: 0x808CE40 VA: 0x8090E40
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x8090E8C Offset: 0x808CE8C VA: 0x8090E8C
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x8090ECC Offset: 0x808CECC VA: 0x8090ECC
	public static Exception MismatchKeyLength() { }

	// RVA: 0x8090F0C Offset: 0x808CF0C VA: 0x8090F0C
	public static Exception InvalidField(string name) { }

	// RVA: 0x8090F58 Offset: 0x808CF58 VA: 0x8090F58
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x8090FA4 Offset: 0x808CFA4 VA: 0x8090FA4
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x8090FF0 Offset: 0x808CFF0 VA: 0x8090FF0
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x809103C Offset: 0x808D03C VA: 0x809103C
	public static Exception InvalidKey(string name) { }

	// RVA: 0x8091088 Offset: 0x808D088 VA: 0x8091088
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x80910D4 Offset: 0x808D0D4 VA: 0x80910D4
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x8091114 Offset: 0x808D114 VA: 0x8091114
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x8091160 Offset: 0x808D160 VA: 0x8091160
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x80911AC Offset: 0x808D1AC VA: 0x80911AC
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x8091208 Offset: 0x808D208 VA: 0x8091208
	public static Exception MissingRefer(string name) { }

	// RVA: 0x80876D8 Offset: 0x80836D8 VA: 0x80876D8
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x809128C Offset: 0x808D28C VA: 0x809128C
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x80912CC Offset: 0x808D2CC VA: 0x80912CC
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x809130C Offset: 0x808D30C VA: 0x809130C
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x809134C Offset: 0x808D34C VA: 0x809134C
	public static Exception NestedCircular(string name) { }

	// RVA: 0x8091398 Offset: 0x808D398 VA: 0x8091398
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x80913E4 Offset: 0x808D3E4 VA: 0x80913E4
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x8091430 Offset: 0x808D430 VA: 0x8091430
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x8091470 Offset: 0x808D470 VA: 0x8091470
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x80914D0 Offset: 0x808D4D0 VA: 0x80914D0
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x809151C Offset: 0x808D51C VA: 0x809151C
	public static Exception FoundEntity() { }

	// RVA: 0x809155C Offset: 0x808D55C VA: 0x809155C
	public static Exception MergeFailed(string name) { }

	// RVA: 0x8091560 Offset: 0x808D560 VA: 0x8091560
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x80915F0 Offset: 0x808D5F0 VA: 0x80915F0
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x809164C Offset: 0x808D64C VA: 0x809164C
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x80916CC Offset: 0x808D6CC VA: 0x80916CC
	public static Exception EnumeratorModified() { }
}

// Namespace: System.Data
[XmlRoot("DataSet")]
[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[XmlSchemaProvider("GetDataSetSchema")]
[DefaultProperty("DataSetName")]
[Serializable]
public class DataSet : MarshalByValueComponent, IListSource, IXmlSerializable, ISupportInitializeNotification, ISupportInitialize, ISerializable // TypeDefIndex: 19081
{
	// Fields
	private DataViewManager _defaultViewManager; // 0x20
	private readonly DataTableCollection _tableCollection; // 0x28
	private readonly DataRelationCollection _relationCollection; // 0x30
	internal PropertyCollection _extendedProperties; // 0x38
	private string _dataSetName; // 0x40
	private string _datasetPrefix; // 0x48
	internal string _namespaceURI; // 0x50
	private bool _enforceConstraints; // 0x58
	private bool _caseSensitive; // 0x59
	private CultureInfo _culture; // 0x60
	private bool _cultureUserSet; // 0x68
	internal bool _fInReadXml; // 0x69
	internal bool _fInLoadDiffgram; // 0x6A
	internal bool _fTopLevelTable; // 0x6B
	internal bool _fInitInProgress; // 0x6C
	internal bool _fEnableCascading; // 0x6D
	internal bool _fIsSchemaLoading; // 0x6E
	internal string _mainTableName; // 0x70
	private SerializationFormat _remotingFormat; // 0x78
	private object _defaultViewManagerLock; // 0x80
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x88
	private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
	internal bool _useDataSetSchemaOnly; // 0x8C
	internal bool _udtIsWrapped; // 0x8D
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	[CompilerGenerated]
	private MergeFailedEventHandler MergeFailed; // 0x98
	[CompilerGenerated]
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	[CompilerGenerated]
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8
	[CompilerGenerated]
	private EventHandler Initialized; // 0xB0

	// Properties
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValue(False)]
	public bool CaseSensitive { get; set; }
	private bool System.ComponentModel.IListSource.ContainsListCollection { get; }
	[Browsable(False)]
	public DataViewManager DefaultViewManager { get; }
	[DefaultValue(True)]
	public bool EnforceConstraints { get; set; }
	[DefaultValue("")]
	public string DataSetName { get; set; }
	[DefaultValue("")]
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	[Browsable(False)]
	public bool IsInitialized { get; }
	public CultureInfo Locale { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public override ISite Site { get; set; }
	[DesignerSerializationVisibility(2)]
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibility(2)]
	public DataTableCollection Tables { get; }
	internal string MainTableName { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x809170C Offset: 0x808D70C VA: 0x809170C
	public void .ctor() { }

	// RVA: 0x80919B8 Offset: 0x808D9B8 VA: 0x80919B8
	public void .ctor(string dataSetName) { }

	// RVA: 0x8091B3C Offset: 0x808DB3C VA: 0x8091B3C
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x8091B44 Offset: 0x808DB44 VA: 0x8091B44
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x8091BE4 Offset: 0x808DBE4 VA: 0x8091BE4 Slot: 27
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0x8091BEC Offset: 0x808DBEC VA: 0x8091BEC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x8091BF4 Offset: 0x808DBF4 VA: 0x8091BF4
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0x8091E34 Offset: 0x808DE34 VA: 0x8091E34 Slot: 28
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x809245C Offset: 0x808E45C VA: 0x809245C Slot: 29
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0x8091E3C Offset: 0x808DE3C VA: 0x8091E3C
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x8091DEC Offset: 0x808DDEC VA: 0x8091DEC
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x8093180 Offset: 0x808F180 VA: 0x8093180
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x8093670 Offset: 0x808F670 VA: 0x8093670
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x8092460 Offset: 0x808E460 VA: 0x8092460
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x8093844 Offset: 0x808F844 VA: 0x8093844
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x80925D0 Offset: 0x808E5D0 VA: 0x80925D0
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x8093B48 Offset: 0x808FB48 VA: 0x8093B48
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x8094D7C Offset: 0x8090D7C VA: 0x8094D7C
	internal void FailedEnableConstraints() { }

	// RVA: 0x8094F30 Offset: 0x8090F30 VA: 0x8094F30
	public bool get_CaseSensitive() { }

	// RVA: 0x8094F38 Offset: 0x8090F38 VA: 0x8094F38
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x8095664 Offset: 0x8091664 VA: 0x8095664 Slot: 16
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0x809566C Offset: 0x809166C VA: 0x809566C
	public DataViewManager get_DefaultViewManager() { }

	// RVA: 0x8095790 Offset: 0x8091790 VA: 0x8095790
	public bool get_EnforceConstraints() { }

	// RVA: 0x8094DA8 Offset: 0x8090DA8 VA: 0x8094DA8
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x8095F48 Offset: 0x8091F48 VA: 0x8095F48
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0x8095798 Offset: 0x8091798 VA: 0x8095798
	internal void EnableConstraints() { }

	// RVA: 0x8095F54 Offset: 0x8091F54 VA: 0x8095F54
	public string get_DataSetName() { }

	// RVA: 0x80919E0 Offset: 0x808D9E0 VA: 0x80919E0
	public void set_DataSetName(string value) { }

	// RVA: 0x8095FD4 Offset: 0x8091FD4 VA: 0x8095FD4
	public string get_Namespace() { }

	// RVA: 0x8095FDC Offset: 0x8091FDC VA: 0x8095FDC
	public void set_Namespace(string value) { }

	// RVA: 0x80964BC Offset: 0x80924BC VA: 0x80964BC
	public string get_Prefix() { }

	// RVA: 0x80964C4 Offset: 0x80924C4 VA: 0x80964C4
	public void set_Prefix(string value) { }

	// RVA: 0x8094D0C Offset: 0x8090D0C VA: 0x8094D0C
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x80965F8 Offset: 0x80925F8 VA: 0x80965F8 Slot: 21
	public bool get_IsInitialized() { }

	// RVA: 0x8096608 Offset: 0x8092608 VA: 0x8096608
	public CultureInfo get_Locale() { }

	// RVA: 0x8096610 Offset: 0x8092610 VA: 0x8096610
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x80967B0 Offset: 0x80927B0 VA: 0x80967B0
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0x80973C0 Offset: 0x80933C0 VA: 0x80973C0
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x80973C8 Offset: 0x80933C8 VA: 0x80973C8 Slot: 10
	public override ISite get_Site() { }

	// RVA: 0x80973D0 Offset: 0x80933D0 VA: 0x80973D0 Slot: 11
	public override void set_Site(ISite value) { }

	// RVA: 0x8097594 Offset: 0x8093594 VA: 0x8097594
	public DataRelationCollection get_Relations() { }

	// RVA: 0x809759C Offset: 0x809359C VA: 0x809759C
	public DataTableCollection get_Tables() { }

	[CompilerGenerated]
	// RVA: 0x80975A4 Offset: 0x80935A4 VA: 0x80975A4 Slot: 22
	public void add_Initialized(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x8097640 Offset: 0x8093640 VA: 0x8097640 Slot: 23
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0x80976DC Offset: 0x80936DC VA: 0x80976DC Slot: 24
	public void BeginInit() { }

	// RVA: 0x80976E8 Offset: 0x80936E8 VA: 0x80976E8 Slot: 25
	public void EndInit() { }

	// RVA: 0x8097898 Offset: 0x8093898 VA: 0x8097898
	public void Clear() { }

	// RVA: 0x8097ACC Offset: 0x8093ACC VA: 0x8097ACC Slot: 30
	public virtual DataSet Clone() { }

	// RVA: 0x8092E44 Offset: 0x808EE44 VA: 0x8092E44
	internal int EstimatedXmlStringSize() { }

	// RVA: 0x8098B38 Offset: 0x8094B38 VA: 0x8098B38 Slot: 17
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0x8098B3C Offset: 0x8094B3C VA: 0x8098B3C
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0x8092CAC Offset: 0x808ECAC VA: 0x8092CAC
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0x8098C6C Offset: 0x8094C6C VA: 0x8098C6C
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0x809442C Offset: 0x809042C VA: 0x809442C
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x8099074 Offset: 0x8095074 VA: 0x8099074
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x8099520 Offset: 0x8095520 VA: 0x8099520
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0x8099128 Offset: 0x8095128 VA: 0x8099128
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x8098DCC Offset: 0x8094DCC VA: 0x8098DCC
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x8098C74 Offset: 0x8094C74 VA: 0x8098C74
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x8099598 Offset: 0x8095598 VA: 0x8099598
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x80997D4 Offset: 0x80957D4 VA: 0x80997D4
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0x80997DC Offset: 0x80957DC VA: 0x80997DC
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0x80991BC Offset: 0x80951BC VA: 0x80991BC
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0x809BC84 Offset: 0x8097C84 VA: 0x809BC84
	private bool IsEmpty() { }

	// RVA: 0x809A8F8 Offset: 0x80968F8 VA: 0x809A8F8
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x8094D04 Offset: 0x8090D04 VA: 0x8094D04
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0x809C0F8 Offset: 0x80980F8 VA: 0x809C0F8
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x8092F64 Offset: 0x808EF64 VA: 0x8092F64
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0x809BF74 Offset: 0x8097F74 VA: 0x809BF74
	public void Merge(DataSet dataSet) { }

	// RVA: 0x809CEAC Offset: 0x8098EAC VA: 0x809CEAC
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x809D118 Offset: 0x8099118 VA: 0x809D118 Slot: 31
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x809D140 Offset: 0x8099140 VA: 0x809D140
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0x809D19C Offset: 0x809919C VA: 0x809D19C
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x809D240 Offset: 0x8099240 VA: 0x809D240
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0x8097AA4 Offset: 0x8093AA4 VA: 0x8097AA4
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x8097818 Offset: 0x8093818 VA: 0x8097818
	private void OnInitialized() { }

	// RVA: 0x809D268 Offset: 0x8099268 VA: 0x809D268 Slot: 32
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0x809D26C Offset: 0x809926C VA: 0x809D26C
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x809D298 Offset: 0x8099298 VA: 0x809D298 Slot: 33
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0x809D29C Offset: 0x809929C VA: 0x809D29C
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0x8095F5C Offset: 0x8091F5C VA: 0x8095F5C
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x809D2AC Offset: 0x80992AC VA: 0x809D2AC
	internal DataTable[] TopLevelTables() { }

	// RVA: 0x809D2B4 Offset: 0x80992B4 VA: 0x809D2B4
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0x809D5A4 Offset: 0x80995A4 VA: 0x809D5A4 Slot: 34
	public virtual void Reset() { }

	// RVA: 0x8095264 Offset: 0x8091264 VA: 0x8095264
	internal bool ValidateCaseConstraint() { }

	// RVA: 0x8096F68 Offset: 0x8092F68 VA: 0x8096F68
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0x809D864 Offset: 0x8099864 VA: 0x809D864
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	// RVA: 0x809D95C Offset: 0x809995C VA: 0x809D95C Slot: 35
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x809DC44 Offset: 0x8099C44 VA: 0x809DC44
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x809DEC0 Offset: 0x8099EC0 VA: 0x809DEC0 Slot: 18
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x809E094 Offset: 0x809A094 VA: 0x809E094 Slot: 19
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x809E2E4 Offset: 0x809A2E4 VA: 0x809E2E4 Slot: 20
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x809E318 Offset: 0x809A318 VA: 0x809E318
	internal string get_MainTableName() { }

	// RVA: 0x809E320 Offset: 0x809A320 VA: 0x809E320
	internal void set_MainTableName(string value) { }

	// RVA: 0x809E328 Offset: 0x809A328 VA: 0x809E328
	internal int get_ObjectID() { }
}

// Namespace: 
internal struct DataTable.RowDiffIdUsageSection // TypeDefIndex: 19082
{
	// Fields
	private DataTable _targetTable; // 0x0

	// Methods

	// RVA: 0x809E330 Offset: 0x809A330 VA: 0x809E330
	internal void Prepare(DataTable table) { }
}

// Namespace: 
internal struct DataTable.DSRowDiffIdUsageSection // TypeDefIndex: 19083
{
	// Fields
	private DataSet _targetDS; // 0x0

	// Methods

	// RVA: 0x809A878 Offset: 0x8096878 VA: 0x809A878
	internal void Prepare(DataSet ds) { }
}

// Namespace: System.Data
[DesignTimeVisible(False)]
[ToolboxItem(False)]
[XmlSchemaProvider("GetDataTableSchema")]
[DefaultEvent("RowChanging")]
[DefaultProperty("TableName")]
[Serializable]
public class DataTable : MarshalByValueComponent, IListSource, ISupportInitializeNotification, ISupportInitialize, ISerializable, IXmlSerializable // TypeDefIndex: 19084
{
	// Fields
	private DataSet _dataSet; // 0x20
	private DataView _defaultView; // 0x28
	internal long _nextRowID; // 0x30
	internal readonly DataRowCollection _rowCollection; // 0x38
	internal readonly DataColumnCollection _columnCollection; // 0x40
	private readonly ConstraintCollection _constraintCollection; // 0x48
	private int _elementColumnCount; // 0x50
	internal DataRelationCollection _parentRelationsCollection; // 0x58
	internal DataRelationCollection _childRelationsCollection; // 0x60
	internal readonly RecordManager _recordManager; // 0x68
	internal readonly List<Index> _indexes; // 0x70
	private List<Index> _shadowIndexes; // 0x78
	private int _shadowCount; // 0x80
	internal PropertyCollection _extendedProperties; // 0x88
	private string _tableName; // 0x90
	internal string _tableNamespace; // 0x98
	private string _tablePrefix; // 0xA0
	internal DataExpression _displayExpression; // 0xA8
	internal bool _fNestedInDataset; // 0xB0
	private CultureInfo _culture; // 0xB8
	private bool _cultureUserSet; // 0xC0
	private CompareInfo _compareInfo; // 0xC8
	private CompareOptions _compareFlags; // 0xD0
	private IFormatProvider _formatProvider; // 0xD8
	private StringComparer _hashCodeProvider; // 0xE0
	private bool _caseSensitive; // 0xE8
	private bool _caseSensitiveUserSet; // 0xE9
	internal string _encodedTableName; // 0xF0
	internal DataColumn _xmlText; // 0xF8
	internal DataColumn _colUnique; // 0x100
	internal Decimal _minOccurs; // 0x108
	internal Decimal _maxOccurs; // 0x118
	internal bool _repeatableElement; // 0x128
	private object _typeName; // 0x130
	internal UniqueConstraint _primaryKey; // 0x138
	internal IndexField[] _primaryIndex; // 0x140
	private DataColumn[] _delayedSetPrimaryKey; // 0x148
	private Index _loadIndex; // 0x150
	private Index _loadIndexwithOriginalAdded; // 0x158
	private Index _loadIndexwithCurrentDeleted; // 0x160
	private int _suspendIndexEvents; // 0x168
	private bool _inDataLoad; // 0x16C
	private bool _schemaLoading; // 0x16D
	private bool _enforceConstraints; // 0x16E
	internal bool _suspendEnforceConstraints; // 0x16F
	protected internal bool fInitInProgress; // 0x170
	private bool _inLoad; // 0x171
	internal bool _fInLoadDiffgram; // 0x172
	private byte _isTypedDataTable; // 0x173
	private DataRow[] _emptyDataRowArray; // 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
	private DataRelation[] _nestedParentRelations; // 0x188
	internal List<DataColumn> _dependentColumns; // 0x190
	private bool _mergingData; // 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
	private EventHandler _onInitialized; // 0x1F0
	private readonly DataRowBuilder _rowBuilder; // 0x1F8
	internal readonly List<DataView> _delayedViews; // 0x200
	private readonly List<DataViewListener> _dataViewListeners; // 0x208
	internal Hashtable _rowDiffId; // 0x210
	internal readonly ReaderWriterLockSlim _indexesLock; // 0x218
	internal int _ukColumnPositionForInference; // 0x220
	private SerializationFormat _remotingFormat; // 0x224
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x228

	// Properties
	public bool CaseSensitive { get; set; }
	internal bool AreIndexEventsSuspended { get; }
	[Browsable(False)]
	public bool IsInitialized { get; }
	private bool IsTypedDataTable { get; }
	internal bool SelfNested { get; }
	[DebuggerBrowsable(0)]
	internal List<Index> LiveIndexes { get; }
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibility(2)]
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibility(2)]
	public ConstraintCollection Constraints { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public DataSet DataSet { get; }
	[Browsable(False)]
	public DataView DefaultView { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValue(50)]
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey { get; set; }
	[Browsable(False)]
	public DataRowCollection Rows { get; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override ISite Site { get; set; }
	private bool System.ComponentModel.IListSource.ContainsListCollection { get; }
	internal bool NeedColumnChangeEvents { get; }
	internal XmlQualifiedName TypeName { get; set; }
	internal Hashtable RowDiffId { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x806B360 Offset: 0x8067360 VA: 0x806B360
	public void .ctor() { }

	// RVA: 0x806B8B8 Offset: 0x80678B8 VA: 0x806B8B8
	public void .ctor(string tableName) { }

	// RVA: 0x806B928 Offset: 0x8067928 VA: 0x806B928
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x806BDDC Offset: 0x8067DDC VA: 0x806BDDC Slot: 27
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x806BEB4 Offset: 0x8067EB4 VA: 0x806BEB4
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x806BAC0 Offset: 0x8067AC0 VA: 0x806BAC0
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x806C194 Offset: 0x8068194 VA: 0x806C194
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x806D4B8 Offset: 0x80694B8 VA: 0x806D4B8
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x807038C Offset: 0x806C38C VA: 0x807038C
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x8071410 Offset: 0x806D410 VA: 0x8071410
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x807215C Offset: 0x806E15C VA: 0x807215C
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x80722B8 Offset: 0x806E2B8 VA: 0x80722B8
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x806CE68 Offset: 0x8068E68 VA: 0x806CE68
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x806E3F0 Offset: 0x806A3F0 VA: 0x806E3F0
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x80726D4 Offset: 0x806E6D4 VA: 0x80726D4
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0x807241C Offset: 0x806E41C VA: 0x807241C
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x807277C Offset: 0x806E77C VA: 0x807277C
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x8072A50 Offset: 0x806EA50 VA: 0x8072A50
	public bool get_CaseSensitive() { }

	// RVA: 0x8072A58 Offset: 0x806EA58 VA: 0x8072A58
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x8072AF8 Offset: 0x806EAF8 VA: 0x8072AF8
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0x8072B08 Offset: 0x806EB08 VA: 0x8072B08
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0x8072EBC Offset: 0x806EEBC VA: 0x8072EBC
	internal void SuspendIndexEvents() { }

	// RVA: 0x8072F68 Offset: 0x806EF68 VA: 0x8072F68 Slot: 18
	public bool get_IsInitialized() { }

	// RVA: 0x8072F78 Offset: 0x806EF78 VA: 0x8072F78
	private bool get_IsTypedDataTable() { }

	// RVA: 0x8070AC0 Offset: 0x806CAC0 VA: 0x8070AC0
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0x8073034 Offset: 0x806F034 VA: 0x8073034
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0x807303C Offset: 0x806F03C VA: 0x807303C
	internal bool get_SelfNested() { }

	// RVA: 0x80733D4 Offset: 0x806F3D4 VA: 0x80733D4
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0x807347C Offset: 0x806F47C VA: 0x807347C
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x8073484 Offset: 0x806F484 VA: 0x8073484
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x80734E4 Offset: 0x806F4E4 VA: 0x80734E4
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x80734EC Offset: 0x806F4EC VA: 0x80734EC
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0x80734F4 Offset: 0x806F4F4 VA: 0x80734F4
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x8073570 Offset: 0x806F570 VA: 0x8073570
	public DataColumnCollection get_Columns() { }

	// RVA: 0x8073578 Offset: 0x806F578 VA: 0x8073578
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x80735CC Offset: 0x806F5CC VA: 0x80735CC
	public ConstraintCollection get_Constraints() { }

	// RVA: 0x80735D4 Offset: 0x806F5D4 VA: 0x80735D4
	private void ResetConstraints() { }

	// RVA: 0x80735F0 Offset: 0x806F5F0 VA: 0x80735F0
	public DataSet get_DataSet() { }

	// RVA: 0x80735F8 Offset: 0x806F5F8 VA: 0x80735F8
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x80736BC Offset: 0x806F6BC VA: 0x80736BC
	public DataView get_DefaultView() { }

	// RVA: 0x807379C Offset: 0x806F79C VA: 0x807379C
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0x8073800 Offset: 0x806F800 VA: 0x8073800
	internal bool get_EnforceConstraints() { }

	// RVA: 0x8073830 Offset: 0x806F830 VA: 0x8073830
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0x8073E48 Offset: 0x806FE48 VA: 0x8073E48
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0x8073E50 Offset: 0x806FE50 VA: 0x8073E50
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0x8073870 Offset: 0x806F870 VA: 0x8073870
	internal void EnableConstraints() { }

	// RVA: 0x806FE14 Offset: 0x806BE14 VA: 0x806FE14
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x8073E5C Offset: 0x806FE5C VA: 0x8073E5C
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x8073EFC Offset: 0x806FEFC VA: 0x8073EFC
	public CultureInfo get_Locale() { }

	// RVA: 0x8073F04 Offset: 0x806FF04 VA: 0x8073F04
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x8070DE8 Offset: 0x806CDE8 VA: 0x8070DE8
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x80743C0 Offset: 0x80703C0 VA: 0x80743C0
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x80743C8 Offset: 0x80703C8 VA: 0x80743C8
	public int get_MinimumCapacity() { }

	// RVA: 0x80713E0 Offset: 0x806D3E0 VA: 0x80713E0
	public void set_MinimumCapacity(int value) { }

	// RVA: 0x80743E4 Offset: 0x80703E4 VA: 0x80743E4
	internal int get_RecordCapacity() { }

	// RVA: 0x8074400 Offset: 0x8070400 VA: 0x8074400
	internal int get_ElementColumnCount() { }

	// RVA: 0x8074408 Offset: 0x8070408 VA: 0x8074408
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0x8073358 Offset: 0x806F358 VA: 0x8073358
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0x807444C Offset: 0x807044C VA: 0x807444C
	internal bool get_MergingData() { }

	// RVA: 0x8074454 Offset: 0x8070454 VA: 0x8074454
	internal void set_MergingData(bool value) { }

	// RVA: 0x8074460 Offset: 0x8070460 VA: 0x8074460
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0x8074468 Offset: 0x8070468 VA: 0x8074468
	internal bool get_SchemaLoading() { }

	// RVA: 0x8074470 Offset: 0x8070470 VA: 0x8074470
	internal void CacheNestedParent() { }

	// RVA: 0x8074490 Offset: 0x8070490 VA: 0x8074490
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0x8074914 Offset: 0x8070914 VA: 0x8074914
	internal int get_NestedParentsCount() { }

	// RVA: 0x8074BF4 Offset: 0x8070BF4 VA: 0x8074BF4
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0x8074CA8 Offset: 0x8070CA8 VA: 0x8074CA8
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x8075110 Offset: 0x8071110 VA: 0x8075110
	public DataRowCollection get_Rows() { }

	// RVA: 0x8075118 Offset: 0x8071118 VA: 0x8075118
	public string get_TableName() { }

	// RVA: 0x8075120 Offset: 0x8071120 VA: 0x8075120
	public void set_TableName(string value) { }

	// RVA: 0x80756F0 Offset: 0x80716F0 VA: 0x80756F0
	internal string get_EncodedTableName() { }

	// RVA: 0x8075774 Offset: 0x8071774 VA: 0x8075774
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0x806D434 Offset: 0x8069434 VA: 0x806D434
	public string get_Namespace() { }

	// RVA: 0x806FACC Offset: 0x806BACC VA: 0x806FACC
	public void set_Namespace(string value) { }

	// RVA: 0x8076790 Offset: 0x8072790 VA: 0x8076790
	internal bool IsNamespaceInherited() { }

	// RVA: 0x80759C4 Offset: 0x80719C4 VA: 0x80759C4
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0x8075DA0 Offset: 0x8071DA0 VA: 0x8075DA0
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0x80767A0 Offset: 0x80727A0 VA: 0x80767A0
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0x80761C4 Offset: 0x80721C4 VA: 0x80761C4
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x8076B20 Offset: 0x8072B20 VA: 0x8076B20 Slot: 28
	public virtual void BeginInit() { }

	// RVA: 0x8076B2C Offset: 0x8072B2C VA: 0x8076B2C Slot: 29
	public virtual void EndInit() { }

	// RVA: 0x80770FC Offset: 0x80730FC VA: 0x80770FC
	public string get_Prefix() { }

	// RVA: 0x8077104 Offset: 0x8073104 VA: 0x8077104
	public void set_Prefix(string value) { }

	// RVA: 0x807726C Offset: 0x807326C VA: 0x807726C
	internal DataColumn get_XmlText() { }

	// RVA: 0x8077274 Offset: 0x8073274 VA: 0x8077274
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0x8077334 Offset: 0x8073334 VA: 0x8077334
	internal Decimal get_MaxOccurs() { }

	// RVA: 0x8077340 Offset: 0x8073340 VA: 0x8077340
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0x8077348 Offset: 0x8073348 VA: 0x8077348
	internal Decimal get_MinOccurs() { }

	// RVA: 0x8077354 Offset: 0x8073354 VA: 0x8077354
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0x807735C Offset: 0x807335C VA: 0x807735C
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0x80773EC Offset: 0x80733EC VA: 0x80773EC
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0x807747C Offset: 0x807347C VA: 0x807747C
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0x80774FC Offset: 0x80734FC VA: 0x80774FC
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0x8077888 Offset: 0x8073888 VA: 0x8077888
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0x8078264 Offset: 0x8074264 VA: 0x8078264 Slot: 30
	protected virtual DataTable CreateInstance() { }

	// RVA: 0x80782F0 Offset: 0x80742F0 VA: 0x80782F0 Slot: 31
	public virtual DataTable Clone() { }

	// RVA: 0x80782F8 Offset: 0x80742F8 VA: 0x80782F8
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0x80784EC Offset: 0x80744EC VA: 0x80784EC
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0x807882C Offset: 0x807482C VA: 0x807882C
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0x806EDA8 Offset: 0x806ADA8 VA: 0x806EDA8
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x8078CAC Offset: 0x8074CAC VA: 0x8078CAC Slot: 19
	public void add_Initialized(EventHandler value) { }

	// RVA: 0x8078D40 Offset: 0x8074D40 VA: 0x8078D40 Slot: 20
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0x8078DD4 Offset: 0x8074DD4 VA: 0x8078DD4 Slot: 10
	public override ISite get_Site() { }

	// RVA: 0x8078DDC Offset: 0x8074DDC VA: 0x8078DDC Slot: 11
	public override void set_Site(ISite value) { }

	// RVA: 0x8078FA0 Offset: 0x8074FA0 VA: 0x8078FA0
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0x8078FB0 Offset: 0x8074FB0 VA: 0x8078FB0
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0x8078FBC Offset: 0x8074FBC VA: 0x8078FBC
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0x8079B44 Offset: 0x8075B44 VA: 0x8079B44
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0x8079B74 Offset: 0x8075B74 VA: 0x8079B74
	public void Clear() { }

	// RVA: 0x8079B7C Offset: 0x8075B7C VA: 0x8079B7C
	internal void Clear(bool clearAll) { }

	// RVA: 0x807A560 Offset: 0x8076560 VA: 0x807A560
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0x807A618 Offset: 0x8076618 VA: 0x807A618
	internal void CommitRow(DataRow row) { }

	// RVA: 0x807A7D0 Offset: 0x80767D0 VA: 0x807A7D0
	internal int Compare(string s1, string s2) { }

	// RVA: 0x807A7D8 Offset: 0x80767D8 VA: 0x807A7D8
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0x807A93C Offset: 0x807693C VA: 0x807A93C
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0x807A97C Offset: 0x807697C VA: 0x807A97C
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0x807A9BC Offset: 0x80769BC VA: 0x807A9BC Slot: 16
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0x807A9C4 Offset: 0x80769C4 VA: 0x807A9C4
	internal void DeleteRow(DataRow row) { }

	// RVA: 0x807AA1C Offset: 0x8076A1C VA: 0x807AA1C
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0x807AB48 Offset: 0x8076B48 VA: 0x807AB48
	internal void FreeRecord(ref int record) { }

	// RVA: 0x807AB64 Offset: 0x8076B64 VA: 0x807AB64
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x807AF08 Offset: 0x8076F08 VA: 0x807AF08
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x807B0D0 Offset: 0x80770D0 VA: 0x807B0D0 Slot: 17
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0x807B0D4 Offset: 0x80770D4 VA: 0x807B0D4
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0x80742BC Offset: 0x80702BC VA: 0x80742BC
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0x8077DB8 Offset: 0x8073DB8 VA: 0x8077DB8
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0x807BDDC Offset: 0x8077DDC VA: 0x807BDDC
	internal int NewRecord() { }

	// RVA: 0x807BEC8 Offset: 0x8077EC8 VA: 0x807BEC8
	internal int NewUninitializedRecord() { }

	// RVA: 0x807BDE4 Offset: 0x8077DE4 VA: 0x807BDE4
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0x8072680 Offset: 0x806E680 VA: 0x8072680
	internal DataRow NewEmptyRow() { }

	// RVA: 0x807BEE4 Offset: 0x8077EE4 VA: 0x807BEE4
	private DataRow NewUninitializedRow() { }

	// RVA: 0x807BF9C Offset: 0x8077F9C VA: 0x807BF9C
	public DataRow NewRow() { }

	// RVA: 0x807C054 Offset: 0x8078054 VA: 0x807C054
	internal DataRow CreateEmptyRow() { }

	// RVA: 0x807BFD0 Offset: 0x8077FD0 VA: 0x807BFD0
	private void NewRowCreated(DataRow row) { }

	// RVA: 0x807BF10 Offset: 0x8077F10 VA: 0x807BF10
	internal DataRow NewRow(int record) { }

	// RVA: 0x807C42C Offset: 0x807842C VA: 0x807C42C Slot: 32
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0x807C488 Offset: 0x8078488 VA: 0x807C488 Slot: 33
	protected virtual Type GetRowType() { }

	// RVA: 0x807C4F4 Offset: 0x80784F4 VA: 0x807C4F4
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0x807C6A8 Offset: 0x80786A8 VA: 0x807C6A8
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0x807C6DC Offset: 0x80786DC VA: 0x807C6DC Slot: 34
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0x807C7AC Offset: 0x80787AC VA: 0x807C7AC Slot: 35
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0x807C87C Offset: 0x807887C VA: 0x807C87C Slot: 36
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x807C94C Offset: 0x807894C VA: 0x807C94C
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x807C95C Offset: 0x807895C VA: 0x807C95C Slot: 37
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0x807A72C Offset: 0x807672C VA: 0x807A72C
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x807A688 Offset: 0x8076688 VA: 0x807A688
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x807C960 Offset: 0x8078960 VA: 0x807C960 Slot: 38
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0x807CA30 Offset: 0x8078A30 VA: 0x807CA30 Slot: 39
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0x807CB00 Offset: 0x8078B00 VA: 0x807CB00 Slot: 40
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0x807CBD0 Offset: 0x8078BD0 VA: 0x807CBD0 Slot: 41
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0x807CCA0 Offset: 0x8078CA0 VA: 0x807CCA0 Slot: 42
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0x807CD70 Offset: 0x8078D70 VA: 0x807CD70 Slot: 43
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0x807CE40 Offset: 0x8078E40 VA: 0x807CE40 Slot: 44
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0x8077004 Offset: 0x8073004 VA: 0x8077004
	private void OnInitialized() { }

	// RVA: 0x807AB98 Offset: 0x8076B98 VA: 0x807AB98
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0x8075678 Offset: 0x8071678 VA: 0x8075678
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0x807CF10 Offset: 0x8078F10 VA: 0x807CF10
	internal void RecordChanged(int record) { }

	// RVA: 0x807D08C Offset: 0x807908C VA: 0x807D08C
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0x807B270 Offset: 0x8077270 VA: 0x807B270
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x807B404 Offset: 0x8077404 VA: 0x807B404
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0x807D264 Offset: 0x8079264 VA: 0x807D264
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x807D428 Offset: 0x8079428 VA: 0x807D428
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x807D59C Offset: 0x807959C VA: 0x807D59C
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0x807DE7C Offset: 0x8079E7C VA: 0x807DE7C
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0x807E018 Offset: 0x807A018 VA: 0x807E018 Slot: 45
	public virtual void Reset() { }

	// RVA: 0x806EDA0 Offset: 0x806ADA0 VA: 0x806EDA0
	internal void ResetIndexes() { }

	// RVA: 0x807E2A0 Offset: 0x807A2A0 VA: 0x807E2A0
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0x807E480 Offset: 0x807A480 VA: 0x807E480
	internal void RollbackRow(DataRow row) { }

	// RVA: 0x807BBF4 Offset: 0x8077BF4 VA: 0x807BBF4
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x807E4F4 Offset: 0x807A4F4 VA: 0x807E4F4
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x807B0DC Offset: 0x80770DC VA: 0x807B0DC
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0x80775B8 Offset: 0x80735B8 VA: 0x80775B8
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0x8079348 Offset: 0x8075348 VA: 0x8079348
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0x8077610 Offset: 0x8073610 VA: 0x8077610
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0x807E6A4 Offset: 0x807A6A4 VA: 0x807E6A4
	private void RestoreShadowIndexes() { }

	// RVA: 0x8072E6C Offset: 0x806EE6C VA: 0x8072E6C
	private void SetShadowIndexes() { }

	// RVA: 0x807E6C4 Offset: 0x807A6C4 VA: 0x807E6C4
	internal void ShadowIndexCopy() { }

	// RVA: 0x807E758 Offset: 0x807A758 VA: 0x807E758 Slot: 3
	public override string ToString() { }

	// RVA: 0x807E4CC Offset: 0x807A4CC VA: 0x807E4CC
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0x807E7CC Offset: 0x807A7CC VA: 0x807E7CC
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0x807EA60 Offset: 0x807AA60 VA: 0x807EA60
	internal DataColumn AddUniqueKey() { }

	// RVA: 0x807EA68 Offset: 0x807AA68 VA: 0x807EA68
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0x807EB14 Offset: 0x807AB14 VA: 0x807EB14
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0x807EB28 Offset: 0x807AB28 VA: 0x807EB28
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0x806FD80 Offset: 0x806BD80 VA: 0x806FD80
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x807ED94 Offset: 0x807AD94 VA: 0x807ED94
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0x807EDA4 Offset: 0x807ADA4 VA: 0x807EDA4
	public void Merge(DataTable table) { }

	// RVA: 0x807EDB0 Offset: 0x807ADB0 VA: 0x807EDB0
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x807F020 Offset: 0x807B020 VA: 0x807F020
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0x807F3DC Offset: 0x807B3DC VA: 0x807F3DC
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x806FE84 Offset: 0x806BE84 VA: 0x806FE84
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0x807F8D8 Offset: 0x807B8D8 VA: 0x807F8D8
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0x807FC18 Offset: 0x807BC18 VA: 0x807FC18
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0x807FC6C Offset: 0x807BC6C VA: 0x807FC6C
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0x807FE3C Offset: 0x807BE3C VA: 0x807FE3C
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x8081810 Offset: 0x807D810 VA: 0x8081810
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x80818A4 Offset: 0x807D8A4 VA: 0x80818A4
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x8082D38 Offset: 0x807ED38 VA: 0x8082D38
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x8080E0C Offset: 0x807CE0C VA: 0x8080E0C
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x8082DEC Offset: 0x807EDEC VA: 0x8082DEC
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x8081914 Offset: 0x807D914 VA: 0x8081914
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x807F4F0 Offset: 0x807B4F0 VA: 0x807F4F0
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0x8082F80 Offset: 0x807EF80 VA: 0x8082F80
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0x80834A0 Offset: 0x807F4A0 VA: 0x80834A0
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x80836DC Offset: 0x807F6DC VA: 0x80836DC Slot: 24
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x80836EC Offset: 0x807F6EC VA: 0x80836EC Slot: 46
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0x80838C0 Offset: 0x807F8C0 VA: 0x80838C0 Slot: 25
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x8083A6C Offset: 0x807FA6C VA: 0x8083A6C Slot: 26
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8083AA0 Offset: 0x807FAA0 VA: 0x8083AA0 Slot: 47
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x8083AAC Offset: 0x807FAAC VA: 0x8083AAC
	internal Hashtable get_RowDiffId() { }

	// RVA: 0x8083B20 Offset: 0x807FB20 VA: 0x8083B20
	internal int get_ObjectID() { }

	// RVA: 0x8083B28 Offset: 0x807FB28 VA: 0x8083B28
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x8083C64 Offset: 0x807FC64 VA: 0x8083C64
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x8083CF4 Offset: 0x807FCF4 VA: 0x8083CF4
	internal void EvaluateExpressions() { }

	// RVA: 0x807B644 Offset: 0x8077644 VA: 0x807B644
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0x808406C Offset: 0x808006C VA: 0x808406C
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0x807A400 Offset: 0x8076400 VA: 0x807A400
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0x807D70C Offset: 0x807970C VA: 0x807D70C
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }
}

// Namespace: System.Data
internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 19085
{
	// Fields
	internal readonly string _name; // 0x18
	internal readonly int _info; // 0x20
	internal int _argumentCount; // 0x24
	internal ExpressionNode[] _arguments; // 0x28
	[Nullable(2)]
	private readonly TypeLimiter _capturedLimiter; // 0x30
	private static readonly Function[] s_funcs; // 0x0

	// Properties
	internal FunctionId Aggregate { get; }
	internal bool IsAggregate { get; }

	// Methods

	// RVA: 0x809E35C Offset: 0x809A35C VA: 0x809E35C
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x809E4B4 Offset: 0x809A4B4 VA: 0x809E4B4
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x809E6A0 Offset: 0x809A6A0 VA: 0x809E6A0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x809EB44 Offset: 0x809AB44 VA: 0x809EB44 Slot: 6
	internal override object Eval() { }

	// RVA: 0x809EB58 Offset: 0x809AB58 VA: 0x809EB58 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x80A0F70 Offset: 0x809CF70 VA: 0x80A0F70 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x80A0FA4 Offset: 0x809CFA4 VA: 0x80A0FA4 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x80A1034 Offset: 0x809D034 VA: 0x80A1034 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x80A10B0 Offset: 0x809D0B0 VA: 0x80A10B0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x80A112C Offset: 0x809D12C VA: 0x80A112C Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x80A11A8 Offset: 0x809D1A8 VA: 0x80A11A8 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x80A1230 Offset: 0x809D230 VA: 0x80A1230 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x809F4D4 Offset: 0x809B4D4 VA: 0x809F4D4
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x809F774 Offset: 0x809B774 VA: 0x809F774
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x80A13F4 Offset: 0x809D3F4 VA: 0x80A13F4
	internal FunctionId get_Aggregate() { }

	// RVA: 0x80A1490 Offset: 0x809D490 VA: 0x80A1490
	internal bool get_IsAggregate() { }

	// RVA: 0x809E998 Offset: 0x809A998 VA: 0x809E998
	internal void Check() { }

	// RVA: 0x80A16C4 Offset: 0x809D6C4 VA: 0x80A16C4
	private static void .cctor() { }
}

// Namespace: System.Data
internal enum FunctionId // TypeDefIndex: 19086
{
	// Fields
	public int value__; // 0x0
	public const FunctionId none = -1;
	public const FunctionId Ascii = 0;
	public const FunctionId Char = 1;
	public const FunctionId Charindex = 2;
	public const FunctionId Difference = 3;
	public const FunctionId Len = 4;
	public const FunctionId Lower = 5;
	public const FunctionId LTrim = 6;
	public const FunctionId Patindex = 7;
	public const FunctionId Replicate = 8;
	public const FunctionId Reverse = 9;
	public const FunctionId Right = 10;
	public const FunctionId RTrim = 11;
	public const FunctionId Soundex = 12;
	public const FunctionId Space = 13;
	public const FunctionId Str = 14;
	public const FunctionId Stuff = 15;
	public const FunctionId Substring = 16;
	public const FunctionId Upper = 17;
	public const FunctionId IsNull = 18;
	public const FunctionId Iif = 19;
	public const FunctionId Convert = 20;
	public const FunctionId cInt = 21;
	public const FunctionId cBool = 22;
	public const FunctionId cDate = 23;
	public const FunctionId cDbl = 24;
	public const FunctionId cStr = 25;
	public const FunctionId Abs = 26;
	public const FunctionId Acos = 27;
	public const FunctionId In = 28;
	public const FunctionId Trim = 29;
	public const FunctionId Sum = 30;
	public const FunctionId Avg = 31;
	public const FunctionId Min = 32;
	public const FunctionId Max = 33;
	public const FunctionId Count = 34;
	public const FunctionId StDev = 35;
	public const FunctionId Var = 37;
	public const FunctionId DateTimeOffset = 38;
}

// Namespace: System.Data
internal sealed class Function // TypeDefIndex: 19087
{
	// Fields
	internal readonly string _name; // 0x10
	internal readonly FunctionId _id; // 0x18
	internal readonly Type _result; // 0x20
	internal readonly bool _isValidateArguments; // 0x28
	internal readonly bool _isVariantArgumentList; // 0x29
	internal readonly int _argumentCount; // 0x2C
	internal readonly Type[] _parameters; // 0x30
	internal static string[] s_functionName; // 0x0

	// Methods

	// RVA: 0x80A2114 Offset: 0x809E114 VA: 0x80A2114
	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0x80A2360 Offset: 0x809E360 VA: 0x80A2360
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeLimiter.Scope.<>c // TypeDefIndex: 19088
{
	// Fields
	public static readonly TypeLimiter.Scope.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x80A40FC Offset: 0x80A00FC VA: 0x80A40FC
	private static void .cctor() { }

	// RVA: 0x80A4164 Offset: 0x80A0164 VA: 0x80A4164
	public void .ctor() { }

	// RVA: 0x80A416C Offset: 0x80A016C VA: 0x80A416C
	internal bool <.ctor>b__3_0(Type type) { }
}

// Namespace: 
private sealed class TypeLimiter.Scope : IDisposable // TypeDefIndex: 19089
{
	// Fields
	private static readonly HashSet<Type> s_allowedTypes; // 0x0
	private HashSet<Type> m_allowedTypes; // 0x10
	[Nullable(2)]
	private readonly TypeLimiter.Scope m_previousScope; // 0x18

	// Methods

	// RVA: 0x80A3150 Offset: 0x809F150 VA: 0x80A3150
	internal void .ctor(TypeLimiter.Scope previousScope, IEnumerable<Type> allowedTypes) { }

	// RVA: 0x80A3530 Offset: 0x809F530 VA: 0x80A3530 Slot: 4
	public void Dispose() { }

	// RVA: 0x80A2D5C Offset: 0x809ED5C VA: 0x80A2D5C
	public bool IsAllowedType(Type type) { }

	// RVA: 0x80A3604 Offset: 0x809F604 VA: 0x80A3604
	private static bool IsTypeUnconditionallyAllowed(Type type) { }

	// RVA: 0x80A37C8 Offset: 0x809F7C8 VA: 0x80A37C8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeLimiter.<>c // TypeDefIndex: 19090
{
	// Fields
	public static readonly TypeLimiter.<>c <>9; // 0x0
	public static Func<DataColumn, Type> <>9__10_0; // 0x8
	public static Func<DataTable, IEnumerable<Type>> <>9__11_0; // 0x10

	// Methods

	// RVA: 0x80A41C8 Offset: 0x80A01C8 VA: 0x80A41C8
	private static void .cctor() { }

	// RVA: 0x80A4230 Offset: 0x80A0230 VA: 0x80A4230
	public void .ctor() { }

	// RVA: 0x80A4238 Offset: 0x80A0238 VA: 0x80A4238
	internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

	// RVA: 0x80A4250 Offset: 0x80A0250 VA: 0x80A4250
	internal IEnumerable<Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }
}

// Namespace: System.Data
internal sealed class TypeLimiter // TypeDefIndex: 19091
{
	// Fields
	[ThreadStatic]
	[Nullable(2)]
	private static TypeLimiter.Scope s_activeScope; // 0x80000000
	private TypeLimiter.Scope m_instanceScope; // 0x10

	// Properties
	private static bool IsTypeLimitingDisabled { get; }

	// Methods

	// RVA: 0x80A2BA0 Offset: 0x809EBA0 VA: 0x80A2BA0
	private void .ctor(TypeLimiter.Scope scope) { }

	// RVA: 0x80A2BD0 Offset: 0x809EBD0 VA: 0x80A2BD0
	private static bool get_IsTypeLimitingDisabled() { }

	[NullableContext(2)]
	// RVA: 0x80A2C48 Offset: 0x809EC48 VA: 0x80A2C48
	public static TypeLimiter Capture() { }

	[NullableContext(2)]
	// RVA: 0x80A2CC4 Offset: 0x809ECC4 VA: 0x80A2CC4
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0x80A2EF4 Offset: 0x809EEF4 VA: 0x80A2EF4
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0x80A32D4 Offset: 0x809F2D4 VA: 0x80A32D4
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0x80A3394 Offset: 0x809F394 VA: 0x80A3394
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0x80A2FB4 Offset: 0x809EFB4 VA: 0x80A2FB4
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }
}

// Namespace: System.Data
public enum AcceptRejectRule // TypeDefIndex: 19092
{
	// Fields
	public int value__; // 0x0
	public const AcceptRejectRule None = 0;
	public const AcceptRejectRule Cascade = 1;
}

// Namespace: System.Data
internal enum AggregateType // TypeDefIndex: 19093
{
	// Fields
	public int value__; // 0x0
	public const AggregateType None = 0;
	public const AggregateType Sum = 4;
	public const AggregateType Mean = 5;
	public const AggregateType Min = 6;
	public const AggregateType Max = 7;
	public const AggregateType First = 8;
	public const AggregateType Count = 9;
	public const AggregateType Var = 10;
	public const AggregateType StDev = 11;
}

// Namespace: System.Data
public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 19094
{
	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x0

	// Properties
	[Browsable(False)]
	public virtual int Count { get; }
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[Browsable(False)]
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0x80A4258 Offset: 0x80A0258 VA: 0x80A4258 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x80A4284 Offset: 0x80A0284 VA: 0x80A4284 Slot: 10
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0x80A42CC Offset: 0x80A02CC VA: 0x80A42CC Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x80A42F8 Offset: 0x80A02F8 VA: 0x80A42F8 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x80A4300 Offset: 0x80A0300 VA: 0x80A4300
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0x80A43B0 Offset: 0x80A03B0 VA: 0x80A43B0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x80A43B4 Offset: 0x80A03B4 VA: 0x80A43B4 Slot: 12
	protected virtual ArrayList get_List() { }

	// RVA: 0x80A43BC Offset: 0x80A03BC VA: 0x80A43BC
	public void .ctor() { }

	// RVA: 0x80A43C4 Offset: 0x80A03C4 VA: 0x80A43C4
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class ColumnTypeConverter : TypeConverter // TypeDefIndex: 19095
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private TypeConverter.StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0x80A4448 Offset: 0x80A0448 VA: 0x80A4448
	public void .ctor() { }

	// RVA: 0x80A4450 Offset: 0x80A0450 VA: 0x80A4450 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x80A4518 Offset: 0x80A0518 VA: 0x80A4518 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x80A4A18 Offset: 0x80A0A18 VA: 0x80A4A18 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x80A4AE0 Offset: 0x80A0AE0 VA: 0x80A4AE0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x80A4CE8 Offset: 0x80A0CE8 VA: 0x80A4CE8 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x80A4E08 Offset: 0x80A0E08 VA: 0x80A4E08 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x80A4E10 Offset: 0x80A0E10 VA: 0x80A4E10 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x80A4E18 Offset: 0x80A0E18 VA: 0x80A4E18
	private static void .cctor() { }
}

// Namespace: System.Data
[EventSource(Name = "System.Data.DataCommonEventSource")]
internal class DataCommonEventSource : EventSource // TypeDefIndex: 19096
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[Event(1, Level = 4)]
	// RVA: 0x80A5AE4 Offset: 0x80A1AE4 VA: 0x80A5AE4
	internal void Trace(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4569214 Offset: 0x4565214 VA: 0x4569214
	|-DataCommonEventSource.Trace<int>
	|
	|-RVA: 0x45692D8 Offset: 0x45652D8 VA: 0x45692D8
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0x4569384 Offset: 0x4565384 VA: 0x4569384
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45694BC Offset: 0x45654BC VA: 0x45694BC
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0x45695A8 Offset: 0x45655A8 VA: 0x45695A8
	|-DataCommonEventSource.Trace<int, int>
	|
	|-RVA: 0x4569690 Offset: 0x4565690 VA: 0x4569690
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0x4569778 Offset: 0x4565778 VA: 0x4569778
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0x4569868 Offset: 0x4565868 VA: 0x4569868
	|-DataCommonEventSource.Trace<int, object>
	|
	|-RVA: 0x4569934 Offset: 0x4565934 VA: 0x4569934
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4569AC8 Offset: 0x4565AC8 VA: 0x4569AC8
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0x4569BE0 Offset: 0x4565BE0 VA: 0x4569BE0
	|-DataCommonEventSource.Trace<int, int, int>
	|
	|-RVA: 0x4569CF4 Offset: 0x4565CF4 VA: 0x4569CF4
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0x4569E08 Offset: 0x4565E08 VA: 0x4569E08
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|
	|-RVA: 0x4569F00 Offset: 0x4565F00 VA: 0x4569F00
	|-DataCommonEventSource.Trace<int, object, object>
	|
	|-RVA: 0x4569FDC Offset: 0x4565FDC VA: 0x4569FDC
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456A1D8 Offset: 0x45661D8 VA: 0x456A1D8
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x456A40C Offset: 0x456640C VA: 0x456A40C
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|
	|-RVA: 0x456A608 Offset: 0x4566608 VA: 0x456A608
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456A964 Offset: 0x4566964 VA: 0x456A964
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|
	|-RVA: 0x456ABD4 Offset: 0x4566BD4 VA: 0x456ABD4
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456AFC0 Offset: 0x4566FC0 VA: 0x456AFC0
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x456B2EC Offset: 0x45672EC VA: 0x456B2EC
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(2, Level = 5)]
	// RVA: 0x80A5AF4 Offset: 0x80A1AF4 VA: 0x80A5AF4
	internal long EnterScope(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4567ED8 Offset: 0x4563ED8 VA: 0x4567ED8
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0x4567FA4 Offset: 0x4563FA4 VA: 0x4567FA4
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45680E4 Offset: 0x45640E4 VA: 0x45680E4
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0x45681D8 Offset: 0x45641D8 VA: 0x45681D8
	|-DataCommonEventSource.EnterScope<int, int>
	|
	|-RVA: 0x45682C8 Offset: 0x45642C8 VA: 0x45682C8
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0x45683B8 Offset: 0x45643B8 VA: 0x45683B8
	|-DataCommonEventSource.EnterScope<int, object>
	|
	|-RVA: 0x456848C Offset: 0x456448C VA: 0x456848C
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4568628 Offset: 0x4564628 VA: 0x4568628
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|
	|-RVA: 0x4568748 Offset: 0x4564748 VA: 0x4568748
	|-DataCommonEventSource.EnterScope<int, int, object>
	|
	|-RVA: 0x4568848 Offset: 0x4564848 VA: 0x4568848
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0x4568968 Offset: 0x4564968 VA: 0x4568968
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|
	|-RVA: 0x4568A6C Offset: 0x4564A6C VA: 0x4568A6C
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4568C70 Offset: 0x4564C70 VA: 0x4568C70
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0x4568EB0 Offset: 0x4564EB0 VA: 0x4568EB0
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(3, Level = 5)]
	// RVA: 0x80A5BB8 Offset: 0x80A1BB8 VA: 0x80A5BB8
	internal void ExitScope(long scopeId) { }

	// RVA: 0x80A5BC8 Offset: 0x80A1BC8 VA: 0x80A5BC8
	public void .ctor() { }

	// RVA: 0x80A5BD0 Offset: 0x80A1BD0 VA: 0x80A5BD0
	private static void .cctor() { }
}

// Namespace: System.Data
[TypeConverter(typeof(ConstraintConverter))]
[DefaultProperty("ConstraintName")]
public abstract class Constraint // TypeDefIndex: 19097
{
	// Fields
	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	// Properties
	[DefaultValue("")]
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliant(False)]
	protected virtual DataSet _DataSet { get; }

	// Methods

	// RVA: 0x80A5C48 Offset: 0x80A1C48 VA: 0x80A5C48 Slot: 4
	public virtual string get_ConstraintName() { }

	// RVA: 0x80A5C50 Offset: 0x80A1C50 VA: 0x80A5C50 Slot: 5
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0x80A60B0 Offset: 0x80A20B0 VA: 0x80A60B0
	internal string get_SchemaName() { }

	// RVA: 0x80A60E8 Offset: 0x80A20E8 VA: 0x80A60E8
	internal void set_SchemaName(string value) { }

	// RVA: 0x80A612C Offset: 0x80A212C VA: 0x80A612C Slot: 6
	internal virtual bool get_InCollection() { }

	// RVA: 0x80A6134 Offset: 0x80A2134 VA: 0x80A6134 Slot: 7
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DataTable get_Table();

	// RVA: 0x80A617C Offset: 0x80A217C VA: 0x80A617C
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool ContainsColumn(DataColumn column);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool CanEnableConstraint();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract Constraint Clone(DataSet destination);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	// RVA: 0x80A61EC Offset: 0x80A21EC VA: 0x80A61EC
	internal void CheckConstraint() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void CheckState();

	// RVA: 0x80A6240 Offset: 0x80A2240 VA: 0x80A6240
	protected void CheckStateForProperty() { }

	// RVA: 0x80A6338 Offset: 0x80A2338 VA: 0x80A6338 Slot: 17
	protected virtual DataSet get__DataSet() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract bool IsConstraintViolated();

	// RVA: 0x80A6340 Offset: 0x80A2340 VA: 0x80A6340 Slot: 3
	public override string ToString() { }

	// RVA: 0x80A634C Offset: 0x80A234C VA: 0x80A634C
	protected void .ctor() { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class ConstraintCollection : InternalDataCollectionBase // TypeDefIndex: 19098
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private CollectionChangeEventHandler _onCollectionChanged; // 0x28
	private Constraint[] _delayLoadingConstraints; // 0x30
	private bool _fLoadForeignKeyConstraintsOnly; // 0x38

	// Properties
	protected override ArrayList List { get; }
	public Constraint Item { get; }
	internal DataTable Table { get; }
	public Constraint Item { get; }

	// Methods

	// RVA: 0x80A63C4 Offset: 0x80A23C4 VA: 0x80A63C4
	internal void .ctor(DataTable table) { }

	// RVA: 0x80A647C Offset: 0x80A247C VA: 0x80A647C Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x80A6484 Offset: 0x80A2484 VA: 0x80A6484
	public Constraint get_Item(int index) { }

	// RVA: 0x80A6580 Offset: 0x80A2580 VA: 0x80A6580
	internal DataTable get_Table() { }

	// RVA: 0x80A6588 Offset: 0x80A2588 VA: 0x80A6588
	public Constraint get_Item(string name) { }

	// RVA: 0x80A67D0 Offset: 0x80A27D0 VA: 0x80A67D0
	public void Add(Constraint constraint) { }

	// RVA: 0x80A67D8 Offset: 0x80A27D8 VA: 0x80A67D8
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0x80A715C Offset: 0x80A315C VA: 0x80A715C
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0x80A6DB8 Offset: 0x80A2DB8 VA: 0x80A6DB8
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0x80A6FC4 Offset: 0x80A2FC4 VA: 0x80A6FC4
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0x80A6CE8 Offset: 0x80A2CE8 VA: 0x80A6CE8
	private bool AutoGenerated(Constraint constraint) { }

	// RVA: 0x80A70FC Offset: 0x80A30FC VA: 0x80A70FC
	private void ArrayAdd(Constraint constraint) { }

	// RVA: 0x80A7204 Offset: 0x80A3204 VA: 0x80A7204
	private void ArrayRemove(Constraint constraint) { }

	// RVA: 0x80A6FA0 Offset: 0x80A2FA0 VA: 0x80A6FA0
	internal string AssignName() { }

	// RVA: 0x80A7034 Offset: 0x80A3034 VA: 0x80A7034
	private void BaseAdd(Constraint constraint) { }

	// RVA: 0x80A72F4 Offset: 0x80A32F4 VA: 0x80A72F4
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0x80A74A8 Offset: 0x80A34A8 VA: 0x80A74A8
	private void BaseRemove(Constraint constraint) { }

	// RVA: 0x80A7754 Offset: 0x80A3754 VA: 0x80A7754
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0x80A7784 Offset: 0x80A3784 VA: 0x80A7784
	public void Clear() { }

	// RVA: 0x80A7B70 Offset: 0x80A3B70 VA: 0x80A7B70
	public bool Contains(string name) { }

	// RVA: 0x80A7B88 Offset: 0x80A3B88 VA: 0x80A7B88
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x80A6B8C Offset: 0x80A2B8C VA: 0x80A6B8C
	internal Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0x80A6E94 Offset: 0x80A2E94 VA: 0x80A6E94
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0x80A7D0C Offset: 0x80A3D0C VA: 0x80A7D0C
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0x80A7E18 Offset: 0x80A3E18 VA: 0x80A7E18
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x80A7C84 Offset: 0x80A3C84 VA: 0x80A7C84
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0x80A6674 Offset: 0x80A2674 VA: 0x80A6674
	internal int InternalIndexOf(string constraintName) { }

	// RVA: 0x80A723C Offset: 0x80A323C VA: 0x80A723C
	private string MakeName(int index) { }

	// RVA: 0x80A7134 Offset: 0x80A3134 VA: 0x80A7134
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x80A5E48 Offset: 0x80A1E48 VA: 0x80A5E48
	internal void RegisterName(string name) { }

	// RVA: 0x80A7F48 Offset: 0x80A3F48 VA: 0x80A7F48
	public void Remove(Constraint constraint) { }

	// RVA: 0x80A6030 Offset: 0x80A2030 VA: 0x80A6030
	internal void UnregisterName(string name) { }

	// RVA: 0x80A80A4 Offset: 0x80A40A4 VA: 0x80A80A4
	internal void FinishInitConstraints() { }
}

// Namespace: System.Data
internal sealed class ConstraintConverter : ExpandableObjectConverter // TypeDefIndex: 19099
{
	// Methods

	// RVA: 0x80A8958 Offset: 0x80A4958 VA: 0x80A8958
	public void .ctor() { }

	// RVA: 0x80A8960 Offset: 0x80A4960 VA: 0x80A8960 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x80A8A28 Offset: 0x80A4A28 VA: 0x80A8A28 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
internal class ConstraintEnumerator // TypeDefIndex: 19100
{
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Properties
	protected Constraint CurrentObject { get; }

	// Methods

	// RVA: 0x80A94B4 Offset: 0x80A54B4 VA: 0x80A94B4
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x80A951C Offset: 0x80A551C VA: 0x80A951C
	public bool GetNext() { }

	// RVA: 0x80A9848 Offset: 0x80A5848 VA: 0x80A9848
	public Constraint GetConstraint() { }

	// RVA: 0x80A9850 Offset: 0x80A5850 VA: 0x80A9850 Slot: 4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x80A9858 Offset: 0x80A5858 VA: 0x80A9858
	protected Constraint get_CurrentObject() { }
}

// Namespace: System.Data
internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator // TypeDefIndex: 19101
{
	// Methods

	// RVA: 0x80A9860 Offset: 0x80A5860 VA: 0x80A9860
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x80A9864 Offset: 0x80A5864 VA: 0x80A9864 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x80A98DC Offset: 0x80A58DC VA: 0x80A98DC
	public ForeignKeyConstraint GetForeignKeyConstraint() { }
}

// Namespace: System.Data
internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 19102
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0x80A9954 Offset: 0x80A5954 VA: 0x80A9954
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0x80A9980 Offset: 0x80A5980 VA: 0x80A9980 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }
}

// Namespace: System.Data
internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 19103
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0x80A9A14 Offset: 0x80A5A14 VA: 0x80A9A14
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0x80A9A40 Offset: 0x80A5A40 VA: 0x80A9A40 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }
}

// Namespace: System.Data
public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 19104
{
	// Fields
	private DataColumn _column; // 0x10
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGenerated]
	private object <ProposedValue>k__BackingField; // 0x20

	// Properties
	public object ProposedValue { get; set; }

	// Methods

	// RVA: 0x80A9AD8 Offset: 0x80A5AD8 VA: 0x80A9AD8
	internal void .ctor(DataRow row) { }

	// RVA: 0x80A9B4C Offset: 0x80A5B4C VA: 0x80A9B4C
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGenerated]
	// RVA: 0x80A9BF0 Offset: 0x80A5BF0 VA: 0x80A9BF0
	public object get_ProposedValue() { }

	[CompilerGenerated]
	// RVA: 0x80A9BF8 Offset: 0x80A5BF8 VA: 0x80A9BF8
	public void set_ProposedValue(object value) { }

	// RVA: 0x80A9C00 Offset: 0x80A5C00 VA: 0x80A9C00
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }
}

// Namespace: System.Data
public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 19105
{
	// Methods

	// RVA: 0x80A9C30 Offset: 0x80A5C30 VA: 0x80A9C30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x80A9D3C Offset: 0x80A5D3C VA: 0x80A9D3C Slot: 13
	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 19106
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataColumn[] _delayedAddRangeColumns; // 0x28
	private readonly Dictionary<string, DataColumn> _columnFromName; // 0x30
	private bool _fInClear; // 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
	private int _nColumnsImplementingIChangeTracking; // 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	[CompilerGenerated]
	private CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

	// Properties
	protected override ArrayList List { get; }
	internal DataColumn[] ColumnsImplementingIChangeTracking { get; }
	internal int ColumnsImplementingIChangeTrackingCount { get; }
	internal int ColumnsImplementingIRevertibleChangeTrackingCount { get; }
	public DataColumn Item { get; }
	public DataColumn Item { get; }
	internal DataColumn Item { get; }

	// Methods

	// RVA: 0x80A9D50 Offset: 0x80A5D50 VA: 0x80A9D50
	internal void .ctor(DataTable table) { }

	// RVA: 0x80A9EC4 Offset: 0x80A5EC4 VA: 0x80A9EC4 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x80A9ECC Offset: 0x80A5ECC VA: 0x80A9ECC
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x80A9ED4 Offset: 0x80A5ED4 VA: 0x80A9ED4
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x80A9EDC Offset: 0x80A5EDC VA: 0x80A9EDC
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x80A9EE4 Offset: 0x80A5EE4 VA: 0x80A9EE4
	public DataColumn get_Item(int index) { }

	// RVA: 0x80A8614 Offset: 0x80A4614 VA: 0x80A8614
	public DataColumn get_Item(string name) { }

	// RVA: 0x80AA164 Offset: 0x80A6164 VA: 0x80AA164
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x80AA208 Offset: 0x80A6208 VA: 0x80AA208
	public void Add(DataColumn column) { }

	// RVA: 0x80AA214 Offset: 0x80A6214 VA: 0x80AA214
	internal void AddAt(int index, DataColumn column) { }

	[CompilerGenerated]
	// RVA: 0x80AA8C8 Offset: 0x80A68C8 VA: 0x80AA8C8
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x80AA964 Offset: 0x80A6964 VA: 0x80AA964
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x80AAA00 Offset: 0x80A6A00 VA: 0x80AAA00
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x80AAA9C Offset: 0x80A6A9C VA: 0x80AAA9C
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x80AA7B8 Offset: 0x80A67B8 VA: 0x80AA7B8
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x80AA778 Offset: 0x80A6778 VA: 0x80AA778
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x80AAB80 Offset: 0x80A6B80 VA: 0x80AAB80
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x80AADC8 Offset: 0x80A6DC8 VA: 0x80AADC8
	internal string AssignName() { }

	// RVA: 0x80AA4A0 Offset: 0x80A64A0 VA: 0x80AA4A0
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x80AB190 Offset: 0x80A7190 VA: 0x80AB190
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x80AB370 Offset: 0x80A7370 VA: 0x80AB370
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x80AB428 Offset: 0x80A7428 VA: 0x80AB428
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x80AAB38 Offset: 0x80A6B38 VA: 0x80AAB38
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x80ABC88 Offset: 0x80A7C88 VA: 0x80ABC88
	public void Clear() { }

	// RVA: 0x80ABF68 Offset: 0x80A7F68 VA: 0x80ABF68
	public bool Contains(string name) { }

	// RVA: 0x80ABFFC Offset: 0x80A7FFC VA: 0x80ABFFC
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x80AC098 Offset: 0x80A8098 VA: 0x80AC098
	public int IndexOf(string columnName) { }

	// RVA: 0x80AA014 Offset: 0x80A6014 VA: 0x80AA014
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x80AC198 Offset: 0x80A8198 VA: 0x80AC198
	internal void FinishInitCollection() { }

	// RVA: 0x80AAE5C Offset: 0x80A6E5C VA: 0x80AAE5C
	private string MakeName(int index) { }

	// RVA: 0x80AA824 Offset: 0x80A6824 VA: 0x80AA824
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x80AA478 Offset: 0x80A6478 VA: 0x80AA478
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x80AC274 Offset: 0x80A8274 VA: 0x80AC274
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x80AAF14 Offset: 0x80A6F14 VA: 0x80AAF14
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x80AC2CC Offset: 0x80A82CC VA: 0x80AC2CC
	internal bool CanRegisterName(string name) { }

	// RVA: 0x80AC330 Offset: 0x80A8330 VA: 0x80AC330
	public void Remove(DataColumn column) { }

	// RVA: 0x80AB0D4 Offset: 0x80A70D4 VA: 0x80AB0D4
	internal void UnregisterName(string name) { }

	// RVA: 0x80ABBAC Offset: 0x80A7BAC VA: 0x80ABBAC
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x80AACB0 Offset: 0x80A6CB0 VA: 0x80AACB0
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }
}

// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 19107
{
	// Fields
	[CompilerGenerated]
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Properties
	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override bool IsBrowsable { get; }

	// Methods

	// RVA: 0x80AC440 Offset: 0x80A8440 VA: 0x80AC440
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0x80AC480 Offset: 0x80A8480 VA: 0x80AC480 Slot: 6
	public override AttributeCollection get_Attributes() { }

	[CompilerGenerated]
	// RVA: 0x80AC644 Offset: 0x80A8644 VA: 0x80AC644
	internal DataColumn get_Column() { }

	// RVA: 0x80AC64C Offset: 0x80A864C VA: 0x80AC64C Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x80AC6B8 Offset: 0x80A86B8 VA: 0x80AC6B8 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x80AC6D4 Offset: 0x80A86D4 VA: 0x80AC6D4 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x80AC6F0 Offset: 0x80A86F0 VA: 0x80AC6F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x80AC760 Offset: 0x80A8760 VA: 0x80AC760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x80AC780 Offset: 0x80A8780 VA: 0x80AC780 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x80AC8C8 Offset: 0x80A88C8 VA: 0x80AC8C8 Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x80AC950 Offset: 0x80A8950 VA: 0x80AC950 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x80ACAA0 Offset: 0x80A8AA0 VA: 0x80ACAA0 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x80ACB80 Offset: 0x80A8B80 VA: 0x80ACB80 Slot: 31
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x80ACB88 Offset: 0x80A8B88 VA: 0x80ACB88 Slot: 9
	public override bool get_IsBrowsable() { }
}

// Namespace: 
internal struct DataError.ColumnError // TypeDefIndex: 19108
{
	// Fields
	internal DataColumn _column; // 0x0
	internal string _error; // 0x8
}

// Namespace: System.Data
internal sealed class DataError // TypeDefIndex: 19109
{
	// Fields
	private string _rowError; // 0x10
	private int _count; // 0x18
	private DataError.ColumnError[] _errorList; // 0x20

	// Properties
	internal string Text { get; set; }
	internal bool HasErrors { get; }

	// Methods

	// RVA: 0x80ACBD0 Offset: 0x80A8BD0 VA: 0x80ACBD0
	internal void .ctor() { }

	// RVA: 0x80ACC30 Offset: 0x80A8C30 VA: 0x80ACC30
	internal void .ctor(string rowError) { }

	// RVA: 0x80ACD08 Offset: 0x80A8D08 VA: 0x80ACD08
	internal string get_Text() { }

	// RVA: 0x80ACD10 Offset: 0x80A8D10 VA: 0x80ACD10
	internal void set_Text(string value) { }

	// RVA: 0x80ACD14 Offset: 0x80A8D14 VA: 0x80ACD14
	internal bool get_HasErrors() { }

	// RVA: 0x80ACD48 Offset: 0x80A8D48 VA: 0x80ACD48
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x80AD07C Offset: 0x80A907C VA: 0x80AD07C
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x80ACE78 Offset: 0x80A8E78 VA: 0x80ACE78
	internal void Clear(DataColumn column) { }

	// RVA: 0x80AD118 Offset: 0x80A9118 VA: 0x80AD118
	internal void Clear() { }

	// RVA: 0x80AD1C4 Offset: 0x80A91C4 VA: 0x80AD1C4
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x80ACCA8 Offset: 0x80A8CA8 VA: 0x80ACCA8
	private void SetText(string errorText) { }

	// RVA: 0x80ACF24 Offset: 0x80A8F24 VA: 0x80ACF24
	internal int IndexOf(DataColumn column) { }
}

// Namespace: System.Data
[IsReadOnly]
internal struct DataKey // TypeDefIndex: 19110
{
	// Fields
	private readonly DataColumn[] _columns; // 0x0

	// Properties
	internal DataColumn[] ColumnsReference { get; }
	internal bool HasValue { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x80AD2C0 Offset: 0x80A92C0 VA: 0x80AD2C0
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0x80AD570 Offset: 0x80A9570 VA: 0x80AD570
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x80AD578 Offset: 0x80A9578 VA: 0x80AD578
	internal bool get_HasValue() { }

	// RVA: 0x80A9484 Offset: 0x80A5484 VA: 0x80A9484
	internal DataTable get_Table() { }

	// RVA: 0x80AD4D8 Offset: 0x80A94D8 VA: 0x80AD4D8
	internal void CheckState() { }

	// RVA: 0x80AD588 Offset: 0x80A9588 VA: 0x80AD588
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x80AD590 Offset: 0x80A9590 VA: 0x80AD590
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x80ABB1C Offset: 0x80A7B1C VA: 0x80ABB1C
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x80AD6A8 Offset: 0x80A96A8 VA: 0x80AD6A8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x80AD70C Offset: 0x80A970C VA: 0x80AD70C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x80AD784 Offset: 0x80A9784 VA: 0x80AD784
	internal bool Equals(DataKey value) { }

	// RVA: 0x80AD83C Offset: 0x80A983C VA: 0x80AD83C
	internal string[] GetColumnNames() { }

	// RVA: 0x80AD908 Offset: 0x80A9908 VA: 0x80AD908
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x80AD9F4 Offset: 0x80A99F4 VA: 0x80AD9F4
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x80ADB04 Offset: 0x80A9B04 VA: 0x80ADB04
	internal Index GetSortIndex() { }

	// RVA: 0x80ADB0C Offset: 0x80A9B0C VA: 0x80ADB0C
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x80ADB64 Offset: 0x80A9B64 VA: 0x80ADB64
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x80ADBE8 Offset: 0x80A9BE8 VA: 0x80ADBE8
	internal DataColumn[] ToArray() { }
}

// Namespace: System.Data
[DefaultProperty("RelationName")]
[TypeConverter(typeof(RelationshipConverter))]
public class DataRelation // TypeDefIndex: 19111
{
	// Fields
	private DataSet _dataSet; // 0x10
	internal PropertyCollection _extendedProperties; // 0x18
	internal string _relationName; // 0x20
	private DataKey _childKey; // 0x28
	private DataKey _parentKey; // 0x30
	private UniqueConstraint _parentKeyConstraint; // 0x38
	private ForeignKeyConstraint _childKeyConstraint; // 0x40
	internal string[] _parentColumnNames; // 0x48
	internal string[] _childColumnNames; // 0x50
	internal string _parentTableName; // 0x58
	internal string _childTableName; // 0x60
	internal string _parentTableNamespace; // 0x68
	internal string _childTableNamespace; // 0x70
	internal bool _nested; // 0x78
	internal bool _createConstraints; // 0x79
	private bool _checkMultipleNested; // 0x7A
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x7C
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x80

	// Properties
	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public virtual DataSet DataSet { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValue("")]
	public virtual string RelationName { get; }
	[DefaultValue(False)]
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool CheckMultipleNested { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x80ADCE0 Offset: 0x80A9CE0 VA: 0x80ADCE0
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x80AE214 Offset: 0x80AA214 VA: 0x80AE214
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x80AE21C Offset: 0x80AA21C VA: 0x80AE21C
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Browsable(False)]
	// RVA: 0x80AE2EC Offset: 0x80AA2EC VA: 0x80AE2EC
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	[Browsable(False)]
	// RVA: 0x80AE414 Offset: 0x80AA414 VA: 0x80AE414
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0x80AE564 Offset: 0x80AA564 VA: 0x80AE564 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x80AE668 Offset: 0x80AA668 VA: 0x80AE668
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x80ABB7C Offset: 0x80A7B7C VA: 0x80ABB7C
	internal DataKey get_ChildKey() { }

	// RVA: 0x80AE680 Offset: 0x80AA680 VA: 0x80AE680 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x80AE698 Offset: 0x80AA698 VA: 0x80AE698 Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x80AE6B0 Offset: 0x80AA6B0 VA: 0x80AE6B0
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x80AE6B8 Offset: 0x80AA6B8 VA: 0x80AE6B8
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x80AE6C0 Offset: 0x80AA6C0 VA: 0x80AE6C0
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x80AE784 Offset: 0x80AA784 VA: 0x80AE784
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x80AE840 Offset: 0x80AA840 VA: 0x80AE840
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x80AE8D8 Offset: 0x80AA8D8 VA: 0x80AE8D8
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x80AEAB4 Offset: 0x80AAAB4 VA: 0x80AEAB4
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x80AEACC Offset: 0x80AAACC VA: 0x80AEACC Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x80AEAE4 Offset: 0x80AAAE4 VA: 0x80AEAE4
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x80ABB94 Offset: 0x80A7B94 VA: 0x80ABB94
	internal DataKey get_ParentKey() { }

	// RVA: 0x80AEAEC Offset: 0x80AAAEC VA: 0x80AEAEC Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x80AEB04 Offset: 0x80AAB04 VA: 0x80AEB04 Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x80AEB1C Offset: 0x80AAB1C VA: 0x80AEB1C
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x80AEEC0 Offset: 0x80AAEC0 VA: 0x80AEEC0
	internal void CheckNestedRelations() { }

	// RVA: 0x80AF2D8 Offset: 0x80AB2D8 VA: 0x80AF2D8 Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x80AF2F0 Offset: 0x80AB2F0 VA: 0x80AF2F0 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x80B09C0 Offset: 0x80AC9C0 VA: 0x80B09C0 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x80B09D8 Offset: 0x80AC9D8 VA: 0x80B09D8
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x80B09E0 Offset: 0x80AC9E0 VA: 0x80B09E0 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x80B09F8 Offset: 0x80AC9F8 VA: 0x80B09F8
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x80B0A68 Offset: 0x80ACA68 VA: 0x80B0A68
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x80B0A70 Offset: 0x80ACA70 VA: 0x80B0A70
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x80B0A7C Offset: 0x80ACA7C VA: 0x80B0A7C
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x80B0A84 Offset: 0x80ACA84 VA: 0x80B0A84
	internal void CheckState() { }

	// RVA: 0x80AE57C Offset: 0x80AA57C VA: 0x80AE57C
	protected void CheckStateForProperty() { }

	// RVA: 0x80ADEF8 Offset: 0x80A9EF8 VA: 0x80ADEF8
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x80B0CC0 Offset: 0x80ACCC0 VA: 0x80B0CC0
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x80B1320 Offset: 0x80AD320 VA: 0x80B1320
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x80B0878 Offset: 0x80AC878 VA: 0x80B0878
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x80B13F0 Offset: 0x80AD3F0 VA: 0x80B13F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x80B03A8 Offset: 0x80AC3A8 VA: 0x80B03A8
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x80B13FC Offset: 0x80AD3FC VA: 0x80B13FC
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0x80B15D4 Offset: 0x80AD5D4 VA: 0x80B15D4
	internal int get_ObjectID() { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class DataRelationCollection.DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 19112
{
	// Fields
	private readonly DataTable _table; // 0x38
	private readonly ArrayList _relations; // 0x40
	private readonly bool _fParentCollection; // 0x48
	[CompilerGenerated]
	private CollectionChangeEventHandler RelationPropertyChanged; // 0x50

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0x80B2B98 Offset: 0x80AEB98 VA: 0x80B2B98
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0x80B2C50 Offset: 0x80AEC50 VA: 0x80B2C50 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x80B2C58 Offset: 0x80AEC58 VA: 0x80B2C58
	private void EnsureDataSet() { }

	// RVA: 0x80B2C9C Offset: 0x80AEC9C VA: 0x80B2C9C Slot: 18
	protected override DataSet GetDataSet() { }

	// RVA: 0x80B2CC0 Offset: 0x80AECC0 VA: 0x80B2CC0 Slot: 13
	public override DataRelation get_Item(int index) { }

	// RVA: 0x80B2DC0 Offset: 0x80AEDC0 VA: 0x80B2DC0 Slot: 14
	public override DataRelation get_Item(string name) { }

	[CompilerGenerated]
	// RVA: 0x80B2EAC Offset: 0x80AEEAC VA: 0x80B2EAC
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x80B2F48 Offset: 0x80AEF48 VA: 0x80B2F48
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x80B2FE4 Offset: 0x80AEFE4 VA: 0x80B2FE4
	private void AddCache(DataRelation relation) { }

	// RVA: 0x80B302C Offset: 0x80AF02C VA: 0x80B302C Slot: 15
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0x80B30EC Offset: 0x80AF0EC VA: 0x80B30EC
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0x80B31C0 Offset: 0x80AF1C0 VA: 0x80B31C0 Slot: 21
	protected override void RemoveCore(DataRelation relation) { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class DataRelationCollection.DataSetRelationCollection : DataRelationCollection // TypeDefIndex: 19113
{
	// Fields
	private readonly DataSet _dataSet; // 0x38
	private readonly ArrayList _relations; // 0x40
	private DataRelation[] _delayLoadingRelations; // 0x48

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0x80B3280 Offset: 0x80AF280 VA: 0x80B3280
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x80B3324 Offset: 0x80AF324 VA: 0x80B3324 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x80B332C Offset: 0x80AF32C VA: 0x80B332C Slot: 16
	public override void Clear() { }

	// RVA: 0x80B3370 Offset: 0x80AF370 VA: 0x80B3370 Slot: 18
	protected override DataSet GetDataSet() { }

	// RVA: 0x80B3378 Offset: 0x80AF378 VA: 0x80B3378 Slot: 13
	public override DataRelation get_Item(int index) { }

	// RVA: 0x80B3478 Offset: 0x80AF478 VA: 0x80B3478 Slot: 14
	public override DataRelation get_Item(string name) { }

	// RVA: 0x80B3564 Offset: 0x80AF564 VA: 0x80B3564 Slot: 15
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0x80B3AC8 Offset: 0x80AFAC8 VA: 0x80B3AC8 Slot: 21
	protected override void RemoveCore(DataRelation relation) { }

	// RVA: 0x80B3D1C Offset: 0x80AFD1C VA: 0x80B3D1C
	internal void FinishInitRelations() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("CollectionChanged")]
[DefaultProperty("Table")]
public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 19114
{
	// Fields
	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

	// Properties
	internal int ObjectID { get; }
	public abstract DataRelation Item { get; }
	public abstract DataRelation Item { get; }

	// Methods

	// RVA: 0x80B15DC Offset: 0x80AD5DC VA: 0x80B15DC
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DataRelation get_Item(string name);

	// RVA: 0x80B15E4 Offset: 0x80AD5E4 VA: 0x80B15E4
	public void Add(DataRelation relation) { }

	// RVA: 0x80B189C Offset: 0x80AD89C VA: 0x80B189C Slot: 15
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0x80B1B44 Offset: 0x80ADB44 VA: 0x80B1B44
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x80B1C4C Offset: 0x80ADC4C VA: 0x80B1C4C
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x80B1D54 Offset: 0x80ADD54 VA: 0x80B1D54
	internal string AssignName() { }

	// RVA: 0x80B1E30 Offset: 0x80ADE30 VA: 0x80B1E30 Slot: 16
	public virtual void Clear() { }

	// RVA: 0x80B2098 Offset: 0x80AE098 VA: 0x80B2098 Slot: 17
	public virtual bool Contains(string name) { }

	// RVA: 0x80B20B0 Offset: 0x80AE0B0 VA: 0x80B20B0
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract DataSet GetDataSet();

	// RVA: 0x80B1D78 Offset: 0x80ADD78 VA: 0x80B1D78
	private string MakeName(int index) { }

	// RVA: 0x80B2228 Offset: 0x80AE228 VA: 0x80B2228 Slot: 19
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x80B22F8 Offset: 0x80AE2F8 VA: 0x80B22F8 Slot: 20
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x80B23C8 Offset: 0x80AE3C8 VA: 0x80B23C8
	internal void RegisterName(string name) { }

	// RVA: 0x80B2584 Offset: 0x80AE584 VA: 0x80B2584
	public void Remove(DataRelation relation) { }

	// RVA: 0x80B2780 Offset: 0x80AE780 VA: 0x80B2780
	public void RemoveAt(int index) { }

	// RVA: 0x80B27F4 Offset: 0x80AE7F4 VA: 0x80B27F4 Slot: 21
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0x80B29DC Offset: 0x80AE9DC VA: 0x80B29DC
	internal void UnregisterName(string name) { }

	// RVA: 0x80B2B08 Offset: 0x80AEB08 VA: 0x80B2B08
	protected void .ctor() { }
}

// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 19115
{
	// Fields
	[CompilerGenerated]
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Properties
	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x80B40B8 Offset: 0x80B00B8 VA: 0x80B40B8
	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGenerated]
	// RVA: 0x80B410C Offset: 0x80B010C VA: 0x80B410C
	internal DataRelation get_Relation() { }

	// RVA: 0x80B4114 Offset: 0x80B0114 VA: 0x80B4114 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x80B4180 Offset: 0x80B0180 VA: 0x80B4180 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x80B4188 Offset: 0x80B0188 VA: 0x80B4188 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x80B41F4 Offset: 0x80B01F4 VA: 0x80B41F4 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x80B4264 Offset: 0x80B0264 VA: 0x80B4264 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x80B4284 Offset: 0x80B0284 VA: 0x80B4284 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x80B428C Offset: 0x80B028C VA: 0x80B428C Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x80B4320 Offset: 0x80B0320 VA: 0x80B4320 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x80B4324 Offset: 0x80B0324 VA: 0x80B4324 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x80B4328 Offset: 0x80B0328 VA: 0x80B4328 Slot: 31
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataRow // TypeDefIndex: 19116
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataColumnCollection _columns; // 0x18
	internal int _oldRecord; // 0x20
	internal int _newRecord; // 0x24
	internal int _tempRecord; // 0x28
	internal long _rowID; // 0x30
	internal DataRowAction _action; // 0x38
	internal bool _inChangingEvent; // 0x3C
	internal bool _inDeletingEvent; // 0x3D
	internal bool _inCascade; // 0x3E
	private DataColumn _lastChangedColumn; // 0x40
	private int _countColumnChange; // 0x48
	private DataError _error; // 0x50
	private int _rbTreeNodeId; // 0x58
	private static int s_objectTypeCount; // 0x0
	internal readonly int _objectID; // 0x5C

	// Properties
	internal DataColumn LastChangedColumn { get; set; }
	internal bool HasPropertyChanged { get; }
	internal int RBTreeNodeId { get; set; }
	public string RowError { get; set; }
	internal long rowID { get; set; }
	public DataRowState RowState { get; }
	public DataTable Table { get; }
	public string Item { set; }
	public object Item { get; set; }
	public object Item { get; }
	public object[] ItemArray { set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0x80B4330 Offset: 0x80B0330 VA: 0x80B4330
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0x80B43E4 Offset: 0x80B03E4 VA: 0x80B43E4
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0x80B4400 Offset: 0x80B0400 VA: 0x80B4400
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0x80B4414 Offset: 0x80B0414 VA: 0x80B4414
	internal bool get_HasPropertyChanged() { }

	// RVA: 0x80B4424 Offset: 0x80B0424 VA: 0x80B4424
	internal int get_RBTreeNodeId() { }

	// RVA: 0x80B442C Offset: 0x80B042C VA: 0x80B442C
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0x80B44DC Offset: 0x80B04DC VA: 0x80B44DC
	public string get_RowError() { }

	// RVA: 0x80B4538 Offset: 0x80B0538 VA: 0x80B4538
	public void set_RowError(string value) { }

	// RVA: 0x80B4674 Offset: 0x80B0674 VA: 0x80B4674
	private void RowErrorChanged() { }

	// RVA: 0x80B46C4 Offset: 0x80B06C4 VA: 0x80B46C4
	internal long get_rowID() { }

	// RVA: 0x80B46CC Offset: 0x80B06CC VA: 0x80B46CC
	internal void set_rowID(long value) { }

	// RVA: 0x80B4724 Offset: 0x80B0724 VA: 0x80B4724
	public DataRowState get_RowState() { }

	// RVA: 0x80B4948 Offset: 0x80B0948 VA: 0x80B4948
	public DataTable get_Table() { }

	// RVA: 0x80B08E4 Offset: 0x80AC8E4 VA: 0x80B08E4
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0x80B4950 Offset: 0x80B0950 VA: 0x80B4950
	internal int GetNestedParentCount() { }

	// RVA: 0x80B4A18 Offset: 0x80B0A18 VA: 0x80B4A18
	public void set_Item(string columnName, object value) { }

	// RVA: 0x80B490C Offset: 0x80B090C VA: 0x80B490C
	public object get_Item(DataColumn column) { }

	// RVA: 0x80B4AAC Offset: 0x80B0AAC VA: 0x80B4AAC
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0x80B5104 Offset: 0x80B1104 VA: 0x80B5104
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0x80B51A8 Offset: 0x80B11A8 VA: 0x80B51A8
	public void set_ItemArray(object[] value) { }

	// RVA: 0x80B5590 Offset: 0x80B1590 VA: 0x80B5590
	public void AcceptChanges() { }

	[EditorBrowsable(2)]
	// RVA: 0x80B5910 Offset: 0x80B1910 VA: 0x80B5910
	public void BeginEdit() { }

	// RVA: 0x80B4E88 Offset: 0x80B0E88 VA: 0x80B4E88
	private bool BeginEditInternal() { }

	[EditorBrowsable(2)]
	// RVA: 0x80B4F9C Offset: 0x80B0F9C VA: 0x80B4F9C
	public void CancelEdit() { }

	// RVA: 0x80B4DAC Offset: 0x80B0DAC VA: 0x80B4DAC
	private void CheckColumn(DataColumn column) { }

	// RVA: 0x80B5914 Offset: 0x80B1914 VA: 0x80B5914
	internal void CheckInTable() { }

	// RVA: 0x80B5950 Offset: 0x80B1950 VA: 0x80B5950
	public void Delete() { }

	[EditorBrowsable(2)]
	// RVA: 0x80B5004 Offset: 0x80B1004 VA: 0x80B5004
	public void EndEdit() { }

	// RVA: 0x80B59B0 Offset: 0x80B19B0 VA: 0x80B59B0
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0x80B5A14 Offset: 0x80B1A14 VA: 0x80B5A14
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x80B5CAC Offset: 0x80B1CAC VA: 0x80B5CAC
	public string GetColumnError(string columnName) { }

	// RVA: 0x80B5C24 Offset: 0x80B1C24 VA: 0x80B5C24
	public string GetColumnError(DataColumn column) { }

	// RVA: 0x80B5CC8 Offset: 0x80B1CC8 VA: 0x80B5CC8
	public void ClearErrors() { }

	// RVA: 0x80ABAF4 Offset: 0x80A7AF4 VA: 0x80ABAF4
	internal void ClearError(DataColumn column) { }

	// RVA: 0x80B5CF0 Offset: 0x80B1CF0 VA: 0x80B5CF0
	public bool get_HasErrors() { }

	// RVA: 0x80B5D34 Offset: 0x80B1D34 VA: 0x80B5D34
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0x80B5DD8 Offset: 0x80B1DD8 VA: 0x80B5DD8
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0x80B5DE0 Offset: 0x80B1DE0 VA: 0x80B5DE0
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x80B4A44 Offset: 0x80B0A44 VA: 0x80B4A44
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0x80B09B8 Offset: 0x80AC9B8 VA: 0x80B09B8
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0x80B5EF8 Offset: 0x80B1EF8 VA: 0x80B5EF8
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x80B6000 Offset: 0x80B2000 VA: 0x80B6000
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0x80B60BC Offset: 0x80B20BC VA: 0x80B60BC
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0x80B60C4 Offset: 0x80B20C4 VA: 0x80B60C4
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x80B61DC Offset: 0x80B21DC VA: 0x80B61DC
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0x80B61E4 Offset: 0x80B21E4 VA: 0x80B61E4
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0x80B6234 Offset: 0x80B2234 VA: 0x80B6234
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0x80AE81C Offset: 0x80AA81C VA: 0x80AE81C
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0x80B6254 Offset: 0x80B2254 VA: 0x80B6254
	internal int GetCurrentRecordNo() { }

	// RVA: 0x80B4E24 Offset: 0x80B0E24 VA: 0x80B4E24
	internal int GetDefaultRecord() { }

	// RVA: 0x80B6290 Offset: 0x80B2290 VA: 0x80B6290
	internal int GetOriginalRecordNo() { }

	// RVA: 0x80B4F60 Offset: 0x80B0F60 VA: 0x80B4F60
	private int GetProposedRecordNo() { }

	// RVA: 0x80B5148 Offset: 0x80B1148 VA: 0x80B5148
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0x80B62CC Offset: 0x80B22CC VA: 0x80B62CC
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0x80B6308 Offset: 0x80B2308 VA: 0x80B6308
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0x80B6360 Offset: 0x80B2360 VA: 0x80B6360
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0x80B636C Offset: 0x80B236C VA: 0x80B636C
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x80AEA2C Offset: 0x80AAA2C VA: 0x80AEA2C
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0x80B63F0 Offset: 0x80B23F0 VA: 0x80B63F0
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0x80B63FC Offset: 0x80B23FC VA: 0x80B63FC
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x80B64A4 Offset: 0x80B24A4 VA: 0x80B64A4
	public void RejectChanges() { }

	// RVA: 0x80B4700 Offset: 0x80B0700 VA: 0x80B4700
	internal void ResetLastChangedColumn() { }

	// RVA: 0x80B6A98 Offset: 0x80B2A98 VA: 0x80B6A98
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0x80B6BB0 Offset: 0x80B2BB0 VA: 0x80B6BB0
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0x80B6FA0 Offset: 0x80B2FA0 VA: 0x80B6FA0
	internal void SetParentRowToDBNull() { }

	// RVA: 0x80B7284 Offset: 0x80B3284 VA: 0x80B7284
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0x80B73F8 Offset: 0x80B33F8 VA: 0x80B73F8
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }
}

// Namespace: System.Data
public sealed class DataRowBuilder // TypeDefIndex: 19117
{
	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0x80B76E4 Offset: 0x80B36E4 VA: 0x80B76E4
	internal void .ctor(DataTable table, int record) { }
}

// Namespace: System.Data
[Flags]
public enum DataRowAction // TypeDefIndex: 19118
{
	// Fields
	public int value__; // 0x0
	public const DataRowAction Nothing = 0;
	public const DataRowAction Delete = 1;
	public const DataRowAction Change = 2;
	public const DataRowAction Rollback = 4;
	public const DataRowAction Commit = 8;
	public const DataRowAction Add = 16;
	public const DataRowAction ChangeOriginal = 32;
	public const DataRowAction ChangeCurrentAndOriginal = 64;
}

// Namespace: System.Data
public class DataRowChangeEventArgs : EventArgs // TypeDefIndex: 19119
{
	// Fields
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly DataRowAction <Action>k__BackingField; // 0x18

	// Methods

	// RVA: 0x80B7720 Offset: 0x80B3720 VA: 0x80B7720
	public void .ctor(DataRow row, DataRowAction action) { }
}

// Namespace: System.Data
public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 19120
{
	// Methods

	// RVA: 0x80B77A0 Offset: 0x80B37A0 VA: 0x80B77A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x80B78AC Offset: 0x80B38AC VA: 0x80B78AC Slot: 13
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }
}

// Namespace: 
private sealed class DataRowCollection.DataRowTree : RBTree<DataRow> // TypeDefIndex: 19121
{
	// Methods

	// RVA: 0x80B7968 Offset: 0x80B3968 VA: 0x80B7968
	internal void .ctor() { }

	// RVA: 0x80B8008 Offset: 0x80B4008 VA: 0x80B8008 Slot: 5
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0x80B8034 Offset: 0x80B4034 VA: 0x80B8034 Slot: 6
	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 19122
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowCollection.DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Properties
	public override int Count { get; }
	public DataRow Item { get; }

	// Methods

	// RVA: 0x80B78C0 Offset: 0x80B38C0 VA: 0x80B78C0
	internal void .ctor(DataTable table) { }

	// RVA: 0x80B79B4 Offset: 0x80B39B4 VA: 0x80B79B4 Slot: 9
	public override int get_Count() { }

	// RVA: 0x80ABA9C Offset: 0x80A7A9C VA: 0x80ABA9C
	public DataRow get_Item(int index) { }

	// RVA: 0x80B7A04 Offset: 0x80B3A04 VA: 0x80B7A04
	public void Add(DataRow row) { }

	// RVA: 0x80B7A24 Offset: 0x80B3A24 VA: 0x80B7A24
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0x80B7C2C Offset: 0x80B3C2C VA: 0x80B7C2C
	public int IndexOf(DataRow row) { }

	// RVA: 0x80B7CC4 Offset: 0x80B3CC4 VA: 0x80B7CC4
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0x80B7D24 Offset: 0x80B3D24 VA: 0x80B7D24
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0x80B7D8C Offset: 0x80B3D8C VA: 0x80B7D8C
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0x80B7E04 Offset: 0x80B3E04 VA: 0x80B7E04
	internal void ArrayClear() { }

	// RVA: 0x80B7E54 Offset: 0x80B3E54 VA: 0x80B7E54
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0x80B7EE8 Offset: 0x80B3EE8 VA: 0x80B7EE8 Slot: 10
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0x80B7F50 Offset: 0x80B3F50 VA: 0x80B7F50
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0x80B7FB8 Offset: 0x80B3FB8 VA: 0x80B7FB8 Slot: 11
	public override IEnumerator GetEnumerator() { }
}

// Namespace: System.Data
internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 19123
{
	// Methods

	// RVA: 0x80B8060 Offset: 0x80B4060 VA: 0x80B8060
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x80B816C Offset: 0x80B416C VA: 0x80B816C Slot: 13
	public virtual void Invoke(object sender, DataRow r) { }
}

// Namespace: System.Data
internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 19124
{
	// Methods

	// RVA: 0x80B8180 Offset: 0x80B4180 VA: 0x80B8180
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x80B828C Offset: 0x80B428C VA: 0x80B828C Slot: 13
	public virtual void Invoke(object sender, DataTable table) { }
}

// Namespace: System.Data
[Flags]
public enum DataRowState // TypeDefIndex: 19125
{
	// Fields
	public int value__; // 0x0
	public const DataRowState Detached = 1;
	public const DataRowState Unchanged = 2;
	public const DataRowState Added = 4;
	public const DataRowState Deleted = 8;
	public const DataRowState Modified = 16;
}

// Namespace: System.Data
public enum DataRowVersion // TypeDefIndex: 19126
{
	// Fields
	public int value__; // 0x0
	public const DataRowVersion Original = 256;
	public const DataRowVersion Current = 512;
	public const DataRowVersion Proposed = 1024;
	public const DataRowVersion Default = 1536;
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataRowView : ICustomTypeDescriptor, IEditableObject, IDataErrorInfo, INotifyPropertyChanged // TypeDefIndex: 19127
{
	// Fields
	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Properties
	public DataView DataView { get; }
	private string System.ComponentModel.IDataErrorInfo.Item { get; }
	private string System.ComponentModel.IDataErrorInfo.Error { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }

	// Methods

	// RVA: 0x80B82A0 Offset: 0x80B42A0 VA: 0x80B82A0
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0x80B82E4 Offset: 0x80B42E4 VA: 0x80B82E4 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x80B82F0 Offset: 0x80B42F0 VA: 0x80B82F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x80B8310 Offset: 0x80B4310 VA: 0x80B8310
	public DataView get_DataView() { }

	// RVA: 0x80B8318 Offset: 0x80B4318 VA: 0x80B8318 Slot: 19
	private string System.ComponentModel.IDataErrorInfo.get_Item(string colName) { }

	// RVA: 0x80B8340 Offset: 0x80B4340 VA: 0x80B8340 Slot: 20
	private string System.ComponentModel.IDataErrorInfo.get_Error() { }

	// RVA: 0x80B83A4 Offset: 0x80B43A4 VA: 0x80B83A4
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0x80B83FC Offset: 0x80B43FC VA: 0x80B83FC
	internal int GetRecord() { }

	// RVA: 0x80B8420 Offset: 0x80B4420 VA: 0x80B8420
	internal bool HasRecord() { }

	// RVA: 0x80AC894 Offset: 0x80A8894 VA: 0x80AC894
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0x80ACA14 Offset: 0x80A8A14 VA: 0x80ACA14
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0x80B8444 Offset: 0x80B4444 VA: 0x80B8444
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0x80B4318 Offset: 0x80B0318 VA: 0x80B4318
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x80B85DC Offset: 0x80B45DC VA: 0x80B85DC
	public DataRow get_Row() { }

	// RVA: 0x80B85E4 Offset: 0x80B45E4 VA: 0x80B85E4 Slot: 16
	public void BeginEdit() { }

	// RVA: 0x80B85F0 Offset: 0x80B45F0 VA: 0x80B85F0 Slot: 18
	public void CancelEdit() { }

	// RVA: 0x80B8664 Offset: 0x80B4664 VA: 0x80B8664 Slot: 17
	public void EndEdit() { }

	// RVA: 0x80B863C Offset: 0x80B463C VA: 0x80B863C
	public bool get_IsNew() { }

	[CompilerGenerated]
	// RVA: 0x80B86B0 Offset: 0x80B46B0 VA: 0x80B86B0 Slot: 21
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x80B874C Offset: 0x80B474C VA: 0x80B874C Slot: 22
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x80B87E8 Offset: 0x80B47E8 VA: 0x80B87E8
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0x80B8878 Offset: 0x80B4878 VA: 0x80B8878 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x80B88D0 Offset: 0x80B48D0 VA: 0x80B88D0 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x80B88D8 Offset: 0x80B48D8 VA: 0x80B88D8 Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x80B88E0 Offset: 0x80B48E0 VA: 0x80B88E0 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x80B88E8 Offset: 0x80B48E8 VA: 0x80B88E8 Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x80B88F0 Offset: 0x80B48F0 VA: 0x80B88F0 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x80B88F8 Offset: 0x80B48F8 VA: 0x80B88F8 Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x80B8900 Offset: 0x80B4900 VA: 0x80B8900 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x80B8958 Offset: 0x80B4958 VA: 0x80B8958 Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x80B89B0 Offset: 0x80B49B0 VA: 0x80B89B0 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x80B8A4C Offset: 0x80B4A4C VA: 0x80B8A4C Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x80B8AD4 Offset: 0x80B4AD4 VA: 0x80B8AD4 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x80B8AD8 Offset: 0x80B4AD8 VA: 0x80B8AD8
	private static void .cctor() { }
}

// Namespace: System.Data
public enum SerializationFormat // TypeDefIndex: 19128
{
	// Fields
	public int value__; // 0x0
	public const SerializationFormat Xml = 0;
	public const SerializationFormat Binary = 1;
}

// Namespace: System.Data
public enum DataSetDateTime // TypeDefIndex: 19129
{
	// Fields
	public int value__; // 0x0
	public const DataSetDateTime Local = 1;
	public const DataSetDateTime Unspecified = 2;
	public const DataSetDateTime UnspecifiedLocal = 3;
	public const DataSetDateTime Utc = 4;
}

// Namespace: System.Data
public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 19130
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x10

	// Methods

	// RVA: 0x80B8B58 Offset: 0x80B4B58 VA: 0x80B8B58
	public void .ctor(DataTable dataTable) { }
}

// Namespace: System.Data
public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 19131
{
	// Methods

	// RVA: 0x80B8BCC Offset: 0x80B4BCC VA: 0x80B8BCC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x80B8CD8 Offset: 0x80B4CD8 VA: 0x80B8CD8 Slot: 13
	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }
}

// Namespace: System.Data
[ListBindable(False)]
[DefaultMember("Item")]
[DefaultEvent("CollectionChanged")]
public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 19132
{
	// Fields
	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

	// Properties
	protected override ArrayList List { get; }
	internal int ObjectID { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }

	// Methods

	// RVA: 0x80B8CEC Offset: 0x80B4CEC VA: 0x80B8CEC
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x80B8E54 Offset: 0x80B4E54 VA: 0x80B8E54 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x80B8E5C Offset: 0x80B4E5C VA: 0x80B8E5C
	internal int get_ObjectID() { }

	// RVA: 0x80B8E64 Offset: 0x80B4E64 VA: 0x80B8E64
	public DataTable get_Item(int index) { }

	// RVA: 0x80A875C Offset: 0x80A475C VA: 0x80A875C
	public DataTable get_Item(string name) { }

	// RVA: 0x80A8850 Offset: 0x80A4850 VA: 0x80A8850
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x80B92E8 Offset: 0x80B52E8 VA: 0x80B92E8
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x80B9404 Offset: 0x80B5404 VA: 0x80B9404
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x80B9540 Offset: 0x80B5540 VA: 0x80B9540
	public void Add(DataTable table) { }

	// RVA: 0x80B9AB4 Offset: 0x80B5AB4 VA: 0x80B9AB4
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x80B9BBC Offset: 0x80B5BBC VA: 0x80B9BBC
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x80B99C0 Offset: 0x80B59C0 VA: 0x80B99C0
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x80B9CC4 Offset: 0x80B5CC4 VA: 0x80B9CC4
	internal string AssignName() { }

	// RVA: 0x80B98AC Offset: 0x80B58AC VA: 0x80B98AC
	private void BaseAdd(DataTable table) { }

	// RVA: 0x80BA03C Offset: 0x80B603C VA: 0x80BA03C
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x80BA1B4 Offset: 0x80B61B4 VA: 0x80BA1B4
	private void BaseRemove(DataTable table) { }

	// RVA: 0x80BA22C Offset: 0x80B622C VA: 0x80BA22C
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x80BA7B4 Offset: 0x80B67B4 VA: 0x80BA7B4
	public void Clear() { }

	// RVA: 0x80B9DC4 Offset: 0x80B5DC4 VA: 0x80B9DC4
	public bool Contains(string name) { }

	// RVA: 0x80BAA8C Offset: 0x80B6A8C VA: 0x80BAA8C
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x80BAC00 Offset: 0x80B6C00 VA: 0x80BAC00
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x80BAD28 Offset: 0x80B6D28 VA: 0x80BAD28
	public int IndexOf(DataTable table) { }

	// RVA: 0x80BAE0C Offset: 0x80B6E0C VA: 0x80BAE0C
	public int IndexOf(string tableName) { }

	// RVA: 0x80BAE24 Offset: 0x80B6E24 VA: 0x80BAE24
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x80BAE84 Offset: 0x80B6E84 VA: 0x80BAE84
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x80B8F94 Offset: 0x80B4F94 VA: 0x80B8F94
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x80B915C Offset: 0x80B515C VA: 0x80B915C
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x80BAED4 Offset: 0x80B6ED4 VA: 0x80BAED4
	internal void FinishInitCollection() { }

	// RVA: 0x80B9D0C Offset: 0x80B5D0C VA: 0x80B9D0C
	private string MakeName(int index) { }

	// RVA: 0x80B99E4 Offset: 0x80B59E4 VA: 0x80B99E4
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x80B97DC Offset: 0x80B57DC VA: 0x80B97DC
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x80B9DDC Offset: 0x80B5DDC VA: 0x80B9DDC
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x80BAF60 Offset: 0x80B6F60 VA: 0x80BAF60
	public void Remove(DataTable table) { }

	// RVA: 0x80BA6A8 Offset: 0x80B66A8 VA: 0x80BA6A8
	internal void UnregisterName(string name) { }
}

// Namespace: System.Data
public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 19133
{
	// Fields
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0x80BB15C Offset: 0x80B715C VA: 0x80BB15C
	public void .ctor(DataRow dataRow) { }
}

// Namespace: System.Data
public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 19134
{
	// Methods

	// RVA: 0x80BB1D0 Offset: 0x80B71D0 VA: 0x80BB1D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x80BB2DC Offset: 0x80B72DC VA: 0x80BB2DC Slot: 13
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }
}

// Namespace: System.Data
internal sealed class DataTablePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 19135
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x88

	// Properties
	public DataTable Table { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x80BB2F0 Offset: 0x80B72F0 VA: 0x80BB2F0
	public DataTable get_Table() { }

	// RVA: 0x80BB2F8 Offset: 0x80B72F8 VA: 0x80BB2F8
	internal void .ctor(DataTable dataTable) { }

	// RVA: 0x80BB338 Offset: 0x80B7338 VA: 0x80BB338 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x80BB3A4 Offset: 0x80B73A4 VA: 0x80BB3A4 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x80BB3AC Offset: 0x80B73AC VA: 0x80BB3AC Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x80BB418 Offset: 0x80B7418 VA: 0x80BB418 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x80BB488 Offset: 0x80B7488 VA: 0x80BB488 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x80BB4A8 Offset: 0x80B74A8 VA: 0x80BB4A8 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x80BB4B0 Offset: 0x80B74B0 VA: 0x80BB4B0 Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x80BB594 Offset: 0x80B7594 VA: 0x80BB594 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x80BB598 Offset: 0x80B7598 VA: 0x80BB598 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x80BB59C Offset: 0x80B759C VA: 0x80BB59C Slot: 31
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: System.Data
internal sealed class DataTableTypeConverter : ReferenceConverter // TypeDefIndex: 19136
{
	// Methods

	// RVA: 0x80BB5A4 Offset: 0x80B75A4 VA: 0x80BB5A4
	public void .ctor() { }

	// RVA: 0x80BB658 Offset: 0x80B7658 VA: 0x80BB658 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }
}

// Namespace: 
private sealed class DataView.DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 19137
{
	// Fields
	internal static readonly DataView.DataRowReferenceComparer s_default; // 0x0

	// Methods

	// RVA: 0x80C07C0 Offset: 0x80BC7C0 VA: 0x80C07C0
	private void .ctor() { }

	// RVA: 0x80C07C8 Offset: 0x80BC7C8 VA: 0x80C07C8 Slot: 4
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0x80C07D4 Offset: 0x80BC7D4 VA: 0x80C07D4 Slot: 5
	public int GetHashCode(DataRow obj) { }

	// RVA: 0x80C07EC Offset: 0x80BC7EC VA: 0x80C07EC
	private static void .cctor() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("PositionChanged")]
[DefaultProperty("Table")]
public class DataView : MarshalByValueComponent, IBindingListView, IBindingList, IList, ICollection, IEnumerable, ITypedList, ISupportInitializeNotification, ISupportInitialize // TypeDefIndex: 19138
{
	// Fields
	private DataViewManager _dataViewManager; // 0x20
	private DataTable _table; // 0x28
	private bool _locked; // 0x30
	private Index _index; // 0x38
	private Dictionary<string, Index> _findIndexes; // 0x40
	private string _sort; // 0x48
	private Comparison<DataRow> _comparison; // 0x50
	private IFilter _rowFilter; // 0x58
	private DataViewRowState _recordStates; // 0x60
	private bool _shouldOpen; // 0x64
	private bool _open; // 0x65
	private bool _allowNew; // 0x66
	private bool _allowEdit; // 0x67
	private bool _allowDelete; // 0x68
	private bool _applyDefaultSort; // 0x69
	internal DataRow _addNewRow; // 0x70
	private ListChangedEventArgs _addNewMoved; // 0x78
	private ListChangedEventHandler _onListChanged; // 0x80
	internal static ListChangedEventArgs s_resetEventArgs; // 0x0
	private DataTable _delayedTable; // 0x88
	private string _delayedRowFilter; // 0x90
	private string _delayedSort; // 0x98
	private DataViewRowState _delayedRecordStates; // 0xA0
	private bool _fInitInProgress; // 0xA4
	private bool _fEndInitInProgress; // 0xA5
	private Dictionary<DataRow, DataRowView> _rowViewCache; // 0xA8
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; // 0xB0
	private DataViewListener _dvListener; // 0xB8
	private static int s_objectTypeCount; // 0x8
	private readonly int _objectID; // 0xC0
	[CompilerGenerated]
	private EventHandler Initialized; // 0xC8

	// Properties
	[DefaultValue(True)]
	public bool AllowDelete { get; }
	[DefaultValue(True)]
	public bool AllowEdit { get; }
	[DefaultValue(True)]
	public bool AllowNew { get; }
	[Browsable(False)]
	public int Count { get; }
	private int CountFromIndex { get; }
	[Browsable(False)]
	public DataViewManager DataViewManager { get; }
	[Browsable(False)]
	public bool IsInitialized { get; }
	[Browsable(False)]
	protected bool IsOpen { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	[DefaultValue("")]
	public virtual string RowFilter { get; set; }
	[DefaultValue(22)]
	public DataViewRowState RowStateFilter { get; set; }
	[DefaultValue("")]
	public string Sort { get; set; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[DefaultValue(null)]
	[RefreshProperties(1)]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table { get; set; }
	private object System.Collections.IList.Item { get; set; }
	public DataRowView Item { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }
	private string System.ComponentModel.IBindingListView.Filter { get; set; }
	private ListSortDescriptionCollection System.ComponentModel.IBindingListView.SortDescriptions { get; }
	private bool System.ComponentModel.IBindingListView.SupportsAdvancedSorting { get; }
	private bool System.ComponentModel.IBindingListView.SupportsFiltering { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x80BB660 Offset: 0x80B7660 VA: 0x80BB660
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x80BBBAC Offset: 0x80B7BAC VA: 0x80BBBAC
	public void .ctor(DataTable table) { }

	// RVA: 0x80BBE80 Offset: 0x80B7E80 VA: 0x80BBE80
	public bool get_AllowDelete() { }

	// RVA: 0x80BBE88 Offset: 0x80B7E88 VA: 0x80BBE88
	public bool get_AllowEdit() { }

	// RVA: 0x80BBE90 Offset: 0x80B7E90 VA: 0x80BBE90
	public bool get_AllowNew() { }

	// RVA: 0x80BBE98 Offset: 0x80B7E98 VA: 0x80BBE98 Slot: 52
	public int get_Count() { }

	// RVA: 0x80BBEE8 Offset: 0x80B7EE8 VA: 0x80BBEE8
	private int get_CountFromIndex() { }

	// RVA: 0x80BBF04 Offset: 0x80B7F04 VA: 0x80BBF04
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x80BBF0C Offset: 0x80B7F0C VA: 0x80BBF0C Slot: 58
	public bool get_IsInitialized() { }

	// RVA: 0x80BBF1C Offset: 0x80B7F1C VA: 0x80BBF1C
	protected bool get_IsOpen() { }

	// RVA: 0x80BBF24 Offset: 0x80B7F24 VA: 0x80BBF24 Slot: 54
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x80BBF2C Offset: 0x80B7F2C VA: 0x80BBF2C Slot: 63
	public virtual string get_RowFilter() { }

	// RVA: 0x80BC020 Offset: 0x80B8020 VA: 0x80BC020 Slot: 64
	public virtual void set_RowFilter(string value) { }

	// RVA: 0x80BC1F0 Offset: 0x80B81F0 VA: 0x80BC1F0
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x80BC1F8 Offset: 0x80B81F8 VA: 0x80BC1F8
	public void set_RowStateFilter(DataViewRowState value) { }

	// RVA: 0x80BC330 Offset: 0x80B8330 VA: 0x80BC330
	public string get_Sort() { }

	// RVA: 0x80BC384 Offset: 0x80B8384 VA: 0x80BC384
	public void set_Sort(string value) { }

	// RVA: 0x80BC560 Offset: 0x80B8560 VA: 0x80BC560
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0x80BC568 Offset: 0x80B8568 VA: 0x80BC568 Slot: 53
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x80BC56C Offset: 0x80B856C VA: 0x80BC56C
	public DataTable get_Table() { }

	// RVA: 0x80BC574 Offset: 0x80B8574 VA: 0x80BC574
	public void set_Table(DataTable value) { }

	// RVA: 0x80BC7F8 Offset: 0x80B87F8 VA: 0x80BC7F8 Slot: 40
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x80BC830 Offset: 0x80B8830 VA: 0x80BC830 Slot: 41
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x80BC814 Offset: 0x80B8814 VA: 0x80BC814
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x80BC94C Offset: 0x80B894C VA: 0x80BC94C Slot: 65
	public virtual DataRowView AddNew() { }

	// RVA: 0x80BCD38 Offset: 0x80B8D38 VA: 0x80BCD38 Slot: 61
	public void BeginInit() { }

	// RVA: 0x80BCD44 Offset: 0x80B8D44 VA: 0x80BCD44 Slot: 62
	public void EndInit() { }

	// RVA: 0x80BCC30 Offset: 0x80B8C30 VA: 0x80BCC30
	private void CheckOpen() { }

	// RVA: 0x80BC510 Offset: 0x80B8510 VA: 0x80BC510
	private void CheckSort(string sort) { }

	// RVA: 0x80BCF58 Offset: 0x80B8F58 VA: 0x80BCF58
	protected void Close() { }

	// RVA: 0x80BCFA4 Offset: 0x80B8FA4 VA: 0x80BCFA4 Slot: 51
	public void CopyTo(Array array, int index) { }

	// RVA: 0x80BD128 Offset: 0x80B9128 VA: 0x80BD128
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x80BD2E8 Offset: 0x80B92E8 VA: 0x80BD2E8
	public void Delete(int index) { }

	// RVA: 0x80BD304 Offset: 0x80B9304 VA: 0x80BD304
	internal void Delete(DataRow row) { }

	// RVA: 0x80BD684 Offset: 0x80B9684 VA: 0x80BD684 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x80BD4D0 Offset: 0x80B94D0 VA: 0x80BD4D0
	internal void FinishAddNew(bool success) { }

	// RVA: 0x80BD6B8 Offset: 0x80B96B8 VA: 0x80BD6B8 Slot: 55
	public IEnumerator GetEnumerator() { }

	// RVA: 0x80BD734 Offset: 0x80B9734 VA: 0x80BD734 Slot: 45
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x80BD73C Offset: 0x80B973C VA: 0x80BD73C Slot: 46
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x80BD744 Offset: 0x80B9744 VA: 0x80BD744 Slot: 42
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x80BD798 Offset: 0x80B9798 VA: 0x80BD798 Slot: 44
	private void System.Collections.IList.Clear() { }

	// RVA: 0x80BD7C0 Offset: 0x80B97C0 VA: 0x80BD7C0 Slot: 43
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x80BD84C Offset: 0x80B984C VA: 0x80BD84C Slot: 47
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x80BCC68 Offset: 0x80B8C68 VA: 0x80BCC68
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x80BD8CC Offset: 0x80B98CC VA: 0x80BD8CC
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x80BD924 Offset: 0x80B9924 VA: 0x80BD924 Slot: 48
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x80BD94C Offset: 0x80B994C VA: 0x80BD94C Slot: 49
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x80BDA6C Offset: 0x80B9A6C VA: 0x80BDA6C Slot: 50
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x80BDA88 Offset: 0x80B9A88 VA: 0x80BDA88
	internal Index GetFindIndex(string column, bool keepIndex) { }

	// RVA: 0x80BDC38 Offset: 0x80B9C38 VA: 0x80BDC38 Slot: 23
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x80BDC40 Offset: 0x80B9C40 VA: 0x80BDC40 Slot: 24
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x80BDC50 Offset: 0x80B9C50 VA: 0x80BDC50 Slot: 25
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x80BDC58 Offset: 0x80B9C58 VA: 0x80BDC58 Slot: 26
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x80BDC60 Offset: 0x80B9C60 VA: 0x80BDC60 Slot: 27
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x80BDC68 Offset: 0x80B9C68 VA: 0x80BDC68 Slot: 28
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x80BDC70 Offset: 0x80B9C70 VA: 0x80BDC70 Slot: 29
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x80BDC78 Offset: 0x80B9C78 VA: 0x80BDC78 Slot: 30
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x80BDC9C Offset: 0x80B9C9C VA: 0x80BDC9C Slot: 31
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x80BDCA0 Offset: 0x80B9CA0 VA: 0x80BDCA0
	internal PropertyDescriptor GetSortProperty() { }

	// RVA: 0x80BDD30 Offset: 0x80B9D30 VA: 0x80BDD30 Slot: 32
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0x80BDD68 Offset: 0x80B9D68 VA: 0x80BDD68 Slot: 33
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x80BDE70 Offset: 0x80B9E70 VA: 0x80BDE70 Slot: 34
	public void remove_ListChanged(ListChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x80BDF78 Offset: 0x80B9F78 VA: 0x80BDF78 Slot: 59
	public void add_Initialized(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x80BE014 Offset: 0x80BA014 VA: 0x80BE014 Slot: 60
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0x80BE0B0 Offset: 0x80BA0B0 VA: 0x80BE0B0 Slot: 35
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x80BE0E8 Offset: 0x80BA0E8 VA: 0x80BE0E8 Slot: 36
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x80BE1E8 Offset: 0x80BA1E8 VA: 0x80BE1E8 Slot: 37
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x80BE480 Offset: 0x80BA480 VA: 0x80BE480 Slot: 38
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x80BE4B8 Offset: 0x80BA4B8 VA: 0x80BE4B8 Slot: 39
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x80BE578 Offset: 0x80BA578 VA: 0x80BE578 Slot: 16
	private void System.ComponentModel.IBindingListView.ApplySort(ListSortDescriptionCollection sorts) { }

	// RVA: 0x80BE104 Offset: 0x80BA104 VA: 0x80BE104
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x80BEAE8 Offset: 0x80BAAE8 VA: 0x80BEAE8 Slot: 20
	private void System.ComponentModel.IBindingListView.RemoveFilter() { }

	// RVA: 0x80BEBB4 Offset: 0x80BABB4 VA: 0x80BEBB4 Slot: 17
	private string System.ComponentModel.IBindingListView.get_Filter() { }

	// RVA: 0x80BEBC4 Offset: 0x80BABC4 VA: 0x80BEBC4 Slot: 18
	private void System.ComponentModel.IBindingListView.set_Filter(string value) { }

	// RVA: 0x80BEBD4 Offset: 0x80BABD4 VA: 0x80BEBD4 Slot: 19
	private ListSortDescriptionCollection System.ComponentModel.IBindingListView.get_SortDescriptions() { }

	// RVA: 0x80BEBD8 Offset: 0x80BABD8 VA: 0x80BEBD8
	internal ListSortDescriptionCollection GetSortDescriptions() { }

	// RVA: 0x80BEE2C Offset: 0x80BAE2C VA: 0x80BEE2C Slot: 21
	private bool System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting() { }

	// RVA: 0x80BEE34 Offset: 0x80BAE34 VA: 0x80BEE34 Slot: 22
	private bool System.ComponentModel.IBindingListView.get_SupportsFiltering() { }

	// RVA: 0x80BEE3C Offset: 0x80BAE3C VA: 0x80BEE3C Slot: 56
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x80BEECC Offset: 0x80BAECC VA: 0x80BEECC Slot: 57
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x80BEF74 Offset: 0x80BAF74 VA: 0x80BEF74 Slot: 66
	internal virtual IFilter GetFilter() { }

	// RVA: 0x80BEF7C Offset: 0x80BAF7C VA: 0x80BEF7C
	private int GetRecord(int recordIndex) { }

	// RVA: 0x80BC858 Offset: 0x80B8858 VA: 0x80BC858
	internal DataRow GetRow(int index) { }

	// RVA: 0x80BD0F4 Offset: 0x80B90F4 VA: 0x80BD0F4
	private DataRowView GetRowView(int record) { }

	// RVA: 0x80BC8F4 Offset: 0x80B88F4 VA: 0x80BC8F4
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x80BF004 Offset: 0x80BB004 VA: 0x80BF004 Slot: 67
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x80BF094 Offset: 0x80BB094 VA: 0x80BF094
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x80BF154 Offset: 0x80BB154 VA: 0x80BF154
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x80BF60C Offset: 0x80BB60C VA: 0x80BF60C Slot: 68
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x80BCED8 Offset: 0x80B8ED8 VA: 0x80BCED8
	private void OnInitialized() { }

	// RVA: 0x80BF924 Offset: 0x80BB924 VA: 0x80BF924
	protected void Reset() { }

	// RVA: 0x80BF3C4 Offset: 0x80BB3C4 VA: 0x80BF3C4
	internal void ResetRowViewCache() { }

	// RVA: 0x80BF950 Offset: 0x80BB950 VA: 0x80BF950
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x80BFB90 Offset: 0x80BBB90 VA: 0x80BFB90 Slot: 69
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x80BBC1C Offset: 0x80B7C1C VA: 0x80BBC1C
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x80BCF90 Offset: 0x80B8F90 VA: 0x80BCF90
	protected void UpdateIndex() { }

	// RVA: 0x80BFEC0 Offset: 0x80BBEC0 VA: 0x80BFEC0 Slot: 70
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x80BFB98 Offset: 0x80BBB98 VA: 0x80BFB98
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x80C00B8 Offset: 0x80BC0B8 VA: 0x80C00B8
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x80C02DC Offset: 0x80BC2DC VA: 0x80C02DC
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x80C0500 Offset: 0x80BC500 VA: 0x80C0500 Slot: 71
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x80C0724 Offset: 0x80BC724 VA: 0x80C0724
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x80C0734 Offset: 0x80BC734 VA: 0x80C0734
	internal int get_ObjectID() { }

	// RVA: 0x80C073C Offset: 0x80BC73C VA: 0x80C073C
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class DataViewListener // TypeDefIndex: 19139
{
	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x80BB940 Offset: 0x80B7940 VA: 0x80BB940
	internal void .ctor(DataView dv) { }

	// RVA: 0x80C0854 Offset: 0x80BC854 VA: 0x80C0854
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x80C0920 Offset: 0x80BC920 VA: 0x80C0920
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x80C09D0 Offset: 0x80BC9D0 VA: 0x80C09D0
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x80C0A9C Offset: 0x80BCA9C VA: 0x80C0A9C
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x80C0B68 Offset: 0x80BCB68 VA: 0x80C0B68
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x80BB9C4 Offset: 0x80B79C4 VA: 0x80BB9C4
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x80BC7F0 Offset: 0x80B87F0 VA: 0x80BC7F0
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x80C0E34 Offset: 0x80BCE34 VA: 0x80C0E34
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x80BFFD4 Offset: 0x80BBFD4 VA: 0x80BFFD4
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x80BFECC Offset: 0x80BBECC VA: 0x80BFECC
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x80C0904 Offset: 0x80BC904 VA: 0x80C0904
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x80C0C18 Offset: 0x80BCC18 VA: 0x80C0C18
	private void RegisterListener(DataTable table) { }
}

// Namespace: System.Data
public class DataViewManager : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList // TypeDefIndex: 19140
{
	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	private DataSet _dataSet; // 0x28
	private DataViewManagerListItemTypeDescriptor _item; // 0x30
	private bool _locked; // 0x38
	internal int _nViews; // 0x3C
	private static NotSupportedException s_notSupported; // 0x0
	[CompilerGenerated]
	private ListChangedEventHandler ListChanged; // 0x40

	// Properties
	[DefaultValue(null)]
	public DataSet DataSet { get; }
	[DesignerSerializationVisibility(2)]
	public DataViewSettingCollection DataViewSettings { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }

	// Methods

	// RVA: 0x80C10D8 Offset: 0x80BD0D8 VA: 0x80C10D8
	internal void .ctor(DataSet dataSet, bool locked) { }

	// RVA: 0x80C1398 Offset: 0x80BD398 VA: 0x80C1398
	public DataSet get_DataSet() { }

	// RVA: 0x80C13A0 Offset: 0x80BD3A0 VA: 0x80C13A0
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0x80C13A8 Offset: 0x80BD3A8 VA: 0x80C13A8 Slot: 48
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x80C1484 Offset: 0x80BD484 VA: 0x80C1484 Slot: 45
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x80C148C Offset: 0x80BD48C VA: 0x80C148C Slot: 46
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x80C1490 Offset: 0x80BD490 VA: 0x80C1490 Slot: 47
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x80C1498 Offset: 0x80BD498 VA: 0x80C1498 Slot: 38
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x80C14A0 Offset: 0x80BD4A0 VA: 0x80C14A0 Slot: 39
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x80C14A8 Offset: 0x80BD4A8 VA: 0x80C14A8 Slot: 44
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x80C1534 Offset: 0x80BD534 VA: 0x80C1534 Slot: 33
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x80C153C Offset: 0x80BD53C VA: 0x80C153C Slot: 34
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x80C1564 Offset: 0x80BD564 VA: 0x80C1564 Slot: 35
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x80C158C Offset: 0x80BD58C VA: 0x80C158C Slot: 37
	private void System.Collections.IList.Clear() { }

	// RVA: 0x80C15B4 Offset: 0x80BD5B4 VA: 0x80C15B4 Slot: 36
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x80C15C4 Offset: 0x80BD5C4 VA: 0x80C15C4 Slot: 40
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x80C15D8 Offset: 0x80BD5D8 VA: 0x80C15D8 Slot: 41
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x80C1600 Offset: 0x80BD600 VA: 0x80C1600 Slot: 42
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x80C1628 Offset: 0x80BD628 VA: 0x80C1628 Slot: 43
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x80C1650 Offset: 0x80BD650 VA: 0x80C1650 Slot: 16
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x80C1658 Offset: 0x80BD658 VA: 0x80C1658 Slot: 17
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x80C1698 Offset: 0x80BD698 VA: 0x80C1698 Slot: 18
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x80C16A0 Offset: 0x80BD6A0 VA: 0x80C16A0 Slot: 19
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x80C16A8 Offset: 0x80BD6A8 VA: 0x80C16A8 Slot: 20
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x80C16B0 Offset: 0x80BD6B0 VA: 0x80C16B0 Slot: 21
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x80C16B8 Offset: 0x80BD6B8 VA: 0x80C16B8 Slot: 22
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x80C16C0 Offset: 0x80BD6C0 VA: 0x80C16C0 Slot: 23
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x80C1700 Offset: 0x80BD700 VA: 0x80C1700 Slot: 24
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x80C1740 Offset: 0x80BD740 VA: 0x80C1740 Slot: 25
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[CompilerGenerated]
	// RVA: 0x80C1780 Offset: 0x80BD780 VA: 0x80C1780 Slot: 26
	public void add_ListChanged(ListChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x80C181C Offset: 0x80BD81C VA: 0x80C181C Slot: 27
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x80C18B8 Offset: 0x80BD8B8 VA: 0x80C18B8 Slot: 28
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x80C18BC Offset: 0x80BD8BC VA: 0x80C18BC Slot: 29
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x80C18FC Offset: 0x80BD8FC VA: 0x80C18FC Slot: 30
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x80C193C Offset: 0x80BD93C VA: 0x80C193C Slot: 31
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x80C1940 Offset: 0x80BD940 VA: 0x80C1940 Slot: 32
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x80C1980 Offset: 0x80BD980 VA: 0x80C1980 Slot: 49
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x80C1A2C Offset: 0x80BDA2C VA: 0x80C1A2C Slot: 50
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x80C1B9C Offset: 0x80BDB9C VA: 0x80C1B9C
	public DataView CreateDataView(DataTable table) { }

	// RVA: 0x80C1C38 Offset: 0x80BDC38 VA: 0x80C1C38 Slot: 51
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x80C1D30 Offset: 0x80BDD30 VA: 0x80C1D30 Slot: 52
	protected virtual void TableCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x80C1F4C Offset: 0x80BDF4C VA: 0x80C1F4C Slot: 53
	protected virtual void RelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x80C2170 Offset: 0x80BE170 VA: 0x80C2170
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class DataViewManagerListItemTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 19141
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private PropertyDescriptorCollection _propsCollection; // 0x18

	// Methods

	// RVA: 0x80C12AC Offset: 0x80BD2AC VA: 0x80C12AC
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0x80BB51C Offset: 0x80B751C VA: 0x80BB51C
	internal DataView GetDataView(DataTable table) { }

	// RVA: 0x80C21EC Offset: 0x80BE1EC VA: 0x80C21EC Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x80C2244 Offset: 0x80BE244 VA: 0x80C2244 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x80C224C Offset: 0x80BE24C VA: 0x80C224C Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x80C2254 Offset: 0x80BE254 VA: 0x80C2254 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x80C225C Offset: 0x80BE25C VA: 0x80C225C Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x80C2264 Offset: 0x80BE264 VA: 0x80C2264 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x80C226C Offset: 0x80BE26C VA: 0x80C226C Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x80C2274 Offset: 0x80BE274 VA: 0x80C2274 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x80C22CC Offset: 0x80BE2CC VA: 0x80C22CC Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x80C2324 Offset: 0x80BE324 VA: 0x80C2324 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x80C23C0 Offset: 0x80BE3C0 VA: 0x80C23C0 Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x80C2560 Offset: 0x80BE560 VA: 0x80C2560 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: System.Data
[Flags]
public enum DataViewRowState // TypeDefIndex: 19142
{
	// Fields
	public int value__; // 0x0
	public const DataViewRowState None = 0;
	public const DataViewRowState Unchanged = 2;
	public const DataViewRowState Added = 4;
	public const DataViewRowState Deleted = 8;
	public const DataViewRowState ModifiedCurrent = 16;
	public const DataViewRowState ModifiedOriginal = 32;
	public const DataViewRowState OriginalRows = 42;
	public const DataViewRowState CurrentRows = 22;
}

// Namespace: System.Data
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DataViewSetting // TypeDefIndex: 19143
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

	// Properties
	public bool ApplyDefaultSort { get; }
	public string RowFilter { get; }
	public DataViewRowState RowStateFilter { get; }
	public string Sort { get; }

	// Methods

	// RVA: 0x80C2564 Offset: 0x80BE564 VA: 0x80C2564
	internal void .ctor() { }

	// RVA: 0x80C25E4 Offset: 0x80BE5E4 VA: 0x80C25E4
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x80C25EC Offset: 0x80BE5EC VA: 0x80C25EC
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x80C2604 Offset: 0x80BE604 VA: 0x80C2604
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x80C261C Offset: 0x80BE61C VA: 0x80C261C
	public string get_RowFilter() { }

	// RVA: 0x80C2624 Offset: 0x80BE624 VA: 0x80C2624
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x80C262C Offset: 0x80BE62C VA: 0x80C262C
	public string get_Sort() { }
}

// Namespace: 
private sealed class DataViewSettingCollection.DataViewSettingsEnumerator : IEnumerator // TypeDefIndex: 19144
{
	// Fields
	private DataViewSettingCollection _dataViewSettings; // 0x10
	private IEnumerator _tableEnumerator; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x80C29B4 Offset: 0x80BE9B4 VA: 0x80C29B4
	public void .ctor(DataViewManager dvm) { }

	// RVA: 0x80C2AEC Offset: 0x80BEAEC VA: 0x80C2AEC Slot: 4
	public bool MoveNext() { }

	// RVA: 0x80C2B8C Offset: 0x80BEB8C VA: 0x80C2B8C Slot: 6
	public void Reset() { }

	// RVA: 0x80C2C30 Offset: 0x80BEC30 VA: 0x80C2C30 Slot: 5
	public object get_Current() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataViewSettingCollection : ICollection, IEnumerable // TypeDefIndex: 19145
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Properties
	public virtual DataViewSetting Item { get; set; }
	[Browsable(False)]
	public virtual int Count { get; }
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[Browsable(False)]
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x80C12DC Offset: 0x80BD2DC VA: 0x80C12DC
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0x80C2634 Offset: 0x80BE634 VA: 0x80C2634 Slot: 9
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x80C272C Offset: 0x80BE72C VA: 0x80C272C Slot: 10
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x80C27DC Offset: 0x80BE7DC VA: 0x80C27DC Slot: 4
	public void CopyTo(Array ar, int index) { }

	// RVA: 0x80C2978 Offset: 0x80BE978 VA: 0x80C2978 Slot: 11
	public virtual int get_Count() { }

	// RVA: 0x80C291C Offset: 0x80BE91C VA: 0x80C291C Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x80C2ABC Offset: 0x80BEABC VA: 0x80C2ABC Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x80C2AC4 Offset: 0x80BEAC4 VA: 0x80C2AC4 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x80C2AC8 Offset: 0x80BEAC8 VA: 0x80C2AC8
	internal void Remove(DataTable table) { }
}

// Namespace: System.Data
internal sealed class DefaultValueTypeConverter : StringConverter // TypeDefIndex: 19146
{
	// Methods

	// RVA: 0x80C2D40 Offset: 0x80BED40 VA: 0x80C2D40
	public void .ctor() { }

	// RVA: 0x80C2D48 Offset: 0x80BED48 VA: 0x80C2D48 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x80C2EF4 Offset: 0x80BEEF4 VA: 0x80C2EF4 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }
}

// Namespace: System.Data
internal enum Aggregate // TypeDefIndex: 19147
{
	// Fields
	public int value__; // 0x0
	public const Aggregate None = -1;
	public const Aggregate Sum = 30;
	public const Aggregate Avg = 31;
	public const Aggregate Min = 32;
	public const Aggregate Max = 33;
	public const Aggregate Count = 34;
	public const Aggregate StDev = 35;
	public const Aggregate Var = 37;
}

// Namespace: System.Data
internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 19148
{
	// Fields
	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48

	// Methods

	// RVA: 0x80C3094 Offset: 0x80BF094 VA: 0x80C3094
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x80C30A0 Offset: 0x80BF0A0 VA: 0x80C30A0
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x80C31D4 Offset: 0x80BF1D4 VA: 0x80C31D4 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x80C3488 Offset: 0x80BF488 VA: 0x80C3488
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0x80C368C Offset: 0x80BF68C VA: 0x80C368C Slot: 6
	internal override object Eval() { }

	// RVA: 0x80C36A0 Offset: 0x80BF6A0 VA: 0x80C36A0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x80C397C Offset: 0x80BF97C VA: 0x80C397C Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x80C39F8 Offset: 0x80BF9F8 VA: 0x80C39F8 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x80C3A00 Offset: 0x80BFA00 VA: 0x80C3A00 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x80C3A08 Offset: 0x80BFA08 VA: 0x80C3A08 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x80C3A10 Offset: 0x80BFA10 VA: 0x80C3A10 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x80C3A20 Offset: 0x80BFA20 VA: 0x80C3A20 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x80C3AB8 Offset: 0x80BFAB8 VA: 0x80C3AB8 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: 
private enum BinaryNode.DataTypePrecedence // TypeDefIndex: 19149
{
	// Fields
	public int value__; // 0x0
	public const BinaryNode.DataTypePrecedence SqlDateTime = 25;
	public const BinaryNode.DataTypePrecedence DateTimeOffset = 24;
	public const BinaryNode.DataTypePrecedence DateTime = 23;
	public const BinaryNode.DataTypePrecedence TimeSpan = 20;
	public const BinaryNode.DataTypePrecedence SqlDouble = 19;
	public const BinaryNode.DataTypePrecedence Double = 18;
	public const BinaryNode.DataTypePrecedence SqlSingle = 17;
	public const BinaryNode.DataTypePrecedence Single = 16;
	public const BinaryNode.DataTypePrecedence SqlDecimal = 15;
	public const BinaryNode.DataTypePrecedence Decimal = 14;
	public const BinaryNode.DataTypePrecedence SqlMoney = 13;
	public const BinaryNode.DataTypePrecedence UInt64 = 12;
	public const BinaryNode.DataTypePrecedence SqlInt64 = 11;
	public const BinaryNode.DataTypePrecedence Int64 = 10;
	public const BinaryNode.DataTypePrecedence UInt32 = 9;
	public const BinaryNode.DataTypePrecedence SqlInt32 = 8;
	public const BinaryNode.DataTypePrecedence Int32 = 7;
	public const BinaryNode.DataTypePrecedence UInt16 = 6;
	public const BinaryNode.DataTypePrecedence SqlInt16 = 5;
	public const BinaryNode.DataTypePrecedence Int16 = 4;
	public const BinaryNode.DataTypePrecedence Byte = 3;
	public const BinaryNode.DataTypePrecedence SqlByte = 2;
	public const BinaryNode.DataTypePrecedence SByte = 1;
	public const BinaryNode.DataTypePrecedence Error = 0;
	public const BinaryNode.DataTypePrecedence SqlBoolean = -1;
	public const BinaryNode.DataTypePrecedence Boolean = -2;
	public const BinaryNode.DataTypePrecedence SqlGuid = -3;
	public const BinaryNode.DataTypePrecedence SqlString = -4;
	public const BinaryNode.DataTypePrecedence String = -5;
	public const BinaryNode.DataTypePrecedence SqlXml = -6;
	public const BinaryNode.DataTypePrecedence SqlChars = -7;
	public const BinaryNode.DataTypePrecedence Char = -8;
	public const BinaryNode.DataTypePrecedence SqlBytes = -9;
	public const BinaryNode.DataTypePrecedence SqlBinary = -10;
}

// Namespace: System.Data
internal class BinaryNode : ExpressionNode // TypeDefIndex: 19150
{
	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x80C3ABC Offset: 0x80BFABC VA: 0x80C3ABC
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x80C3B24 Offset: 0x80BFB24 VA: 0x80C3B24 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x80C3B94 Offset: 0x80BFB94 VA: 0x80C3B94 Slot: 6
	internal override object Eval() { }

	// RVA: 0x80C3BA8 Offset: 0x80BFBA8 VA: 0x80C3BA8 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x80C9338 Offset: 0x80C5338 VA: 0x80C9338 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x80C9354 Offset: 0x80C5354 VA: 0x80C9354 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x80C939C Offset: 0x80C539C VA: 0x80C939C Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x80C93E4 Offset: 0x80C53E4 VA: 0x80C93E4 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x80C942C Offset: 0x80C542C VA: 0x80C942C Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x80C9474 Offset: 0x80C5474 VA: 0x80C9474 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x80C94D8 Offset: 0x80C54D8 VA: 0x80C94D8 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x80C9A60 Offset: 0x80C5A60 VA: 0x80C9A60
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x80C9A94 Offset: 0x80C5A94 VA: 0x80C9A94
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x80C9AC4 Offset: 0x80C5AC4 VA: 0x80C9AC4
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x80C9ACC Offset: 0x80C5ACC VA: 0x80C9ACC
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x80C3BC4 Offset: 0x80BFBC4 VA: 0x80C3BC4
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x80CB584 Offset: 0x80C7584 VA: 0x80CB584
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x80CB5A8 Offset: 0x80C75A8 VA: 0x80CB5A8
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x80CB5CC Offset: 0x80C75CC VA: 0x80CB5CC
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x80CB6B0 Offset: 0x80C76B0 VA: 0x80CB6B0
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x80CB158 Offset: 0x80C7158 VA: 0x80CB158
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x80CAD70 Offset: 0x80C6D70 VA: 0x80CAD70
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x80CB7C0 Offset: 0x80C77C0 VA: 0x80CB7C0
	private int SqlResultType(int typeCode) { }
}

// Namespace: System.Data
internal sealed class LikeNode : BinaryNode // TypeDefIndex: 19151
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0x80CB820 Offset: 0x80C7820 VA: 0x80CB820
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x80CB824 Offset: 0x80C7824 VA: 0x80CB824 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x80CBD88 Offset: 0x80C7D88 VA: 0x80CBD88
	internal string AnalyzePattern(string pat) { }
}

// Namespace: System.Data
internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 19152
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0x80CC06C Offset: 0x80C806C VA: 0x80CC06C
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0x80C973C Offset: 0x80C573C VA: 0x80C973C
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0x80CCB34 Offset: 0x80C8B34 VA: 0x80CCB34 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x80CCB3C Offset: 0x80C8B3C VA: 0x80CCB3C Slot: 6
	internal override object Eval() { }

	// RVA: 0x80CCB44 Offset: 0x80C8B44 VA: 0x80CCB44 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x80CCB50 Offset: 0x80C8B50 VA: 0x80CCB50 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x80CCB5C Offset: 0x80C8B5C VA: 0x80CCB5C Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x80CCB64 Offset: 0x80C8B64 VA: 0x80CCB64 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x80CCB6C Offset: 0x80C8B6C VA: 0x80CCB6C Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x80CCB74 Offset: 0x80C8B74 VA: 0x80CCB74 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x80CCB7C Offset: 0x80C8B7C VA: 0x80CCB7C Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x80CC6A4 Offset: 0x80C86A4 VA: 0x80CC6A4
	private object SmallestDecimal(object constant) { }

	// RVA: 0x80CC074 Offset: 0x80C8074 VA: 0x80CC074
	private object SmallestNumeric(object constant) { }
}

// Namespace: System.Data
internal sealed class DataExpression : IFilter // TypeDefIndex: 19153
{
	// Fields
	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

	// Properties
	internal string Expression { get; }
	internal bool HasValue { get; }

	// Methods

	// RVA: 0x80BC1E8 Offset: 0x80B81E8 VA: 0x80BC1E8
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x80CCB80 Offset: 0x80C8B80 VA: 0x80CCB80
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x80BBFD0 Offset: 0x80B7FD0 VA: 0x80BBFD0
	internal string get_Expression() { }

	// RVA: 0x80CDD64 Offset: 0x80C9D64 VA: 0x80CDD64
	internal bool get_HasValue() { }

	// RVA: 0x80CDC2C Offset: 0x80C9C2C VA: 0x80CDC2C
	internal void Bind(DataTable table) { }

	// RVA: 0x80C3A9C Offset: 0x80BFA9C VA: 0x80C3A9C
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x80CDD74 Offset: 0x80C9D74 VA: 0x80CDD74
	internal object Evaluate() { }

	// RVA: 0x80CDD80 Offset: 0x80C9D80 VA: 0x80CDD80
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x80CDF78 Offset: 0x80C9F78 VA: 0x80CDF78 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x80CE05C Offset: 0x80CA05C VA: 0x80CE05C
	internal DataColumn[] GetDependency() { }

	// RVA: 0x80CE064 Offset: 0x80CA064 VA: 0x80CE064
	internal bool IsTableAggregate() { }

	// RVA: 0x80CE07C Offset: 0x80CA07C VA: 0x80CE07C
	internal static bool IsUnknown(object value) { }

	// RVA: 0x80CE0D4 Offset: 0x80CA0D4 VA: 0x80CE0D4
	internal bool HasLocalAggregate() { }

	// RVA: 0x80CE0EC Offset: 0x80CA0EC VA: 0x80CE0EC
	internal bool HasRemoteAggregate() { }

	// RVA: 0x80CAAE8 Offset: 0x80C6AE8 VA: 0x80CAAE8
	internal static bool ToBoolean(object value) { }
}

// Namespace: System.Data
internal abstract class ExpressionNode // TypeDefIndex: 19154
{
	// Fields
	private DataTable _table; // 0x10

	// Properties
	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }

	// Methods

	// RVA: 0x80C31A4 Offset: 0x80BF1A4 VA: 0x80C31A4
	protected void .ctor(DataTable table) { }

	// RVA: 0x80CAA7C Offset: 0x80C6A7C VA: 0x80CAA7C
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x80CE104 Offset: 0x80CA104 VA: 0x80CE104 Slot: 4
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0x80CE10C Offset: 0x80CA10C VA: 0x80CE10C
	protected DataTable get_table() { }

	// RVA: 0x80CE114 Offset: 0x80CA114 VA: 0x80CE114
	protected void BindTable(DataTable table) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void Bind(DataTable table, List<DataColumn> list);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract object Eval();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract object Eval(DataRow row, DataRowVersion version);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract object Eval(int[] recordNos);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool IsConstant();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool IsTableConstant();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool HasLocalAggregate();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool HasRemoteAggregate();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract ExpressionNode Optimize();

	// RVA: 0x80CE11C Offset: 0x80CA11C VA: 0x80CE11C Slot: 14
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0x80CB7B0 Offset: 0x80C77B0 VA: 0x80CB7B0
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x80CB558 Offset: 0x80C7558 VA: 0x80CB558
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x80CB660 Offset: 0x80C7660 VA: 0x80CB660
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x80CB73C Offset: 0x80C773C VA: 0x80CB73C
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x80CB690 Offset: 0x80C7690 VA: 0x80CB690
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x80CB768 Offset: 0x80C7768 VA: 0x80CB768
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x80CB790 Offset: 0x80C7790 VA: 0x80CB790
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x80CB7F4 Offset: 0x80C77F4 VA: 0x80CB7F4
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x80CE124 Offset: 0x80CA124 VA: 0x80CE124
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x80CE134 Offset: 0x80CA134 VA: 0x80CE134
	internal static bool IsFloatSql(StorageType type) { }
}

// Namespace: System.Data
internal enum ValueType // TypeDefIndex: 19155
{
	// Fields
	public int value__; // 0x0
	public const ValueType Unknown = -1;
	public const ValueType Null = 0;
	public const ValueType Bool = 1;
	public const ValueType Numeric = 2;
	public const ValueType Str = 3;
	public const ValueType Float = 4;
	public const ValueType Decimal = 5;
	public const ValueType Object = 6;
	public const ValueType Date = 7;
}

// Namespace: System.Data
internal enum Nodes // TypeDefIndex: 19156
{
	// Fields
	public int value__; // 0x0
	public const Nodes Noop = 0;
	public const Nodes Unop = 1;
	public const Nodes UnopSpec = 2;
	public const Nodes Binop = 3;
	public const Nodes BinopSpec = 4;
	public const Nodes Zop = 5;
	public const Nodes Call = 6;
	public const Nodes Const = 7;
	public const Nodes Name = 8;
	public const Nodes Paren = 9;
	public const Nodes Conv = 10;
}

// Namespace: 
[IsReadOnly]
private struct ExpressionParser.ReservedWords // TypeDefIndex: 19157
{
	// Fields
	internal readonly string _word; // 0x0
	internal readonly Tokens _token; // 0x8
	internal readonly int _op; // 0xC

	// Methods

	// RVA: 0x80CF760 Offset: 0x80CB760 VA: 0x80CF760
	internal void .ctor(string word, Tokens token, int op) { }
}

// Namespace: System.Data
internal sealed class ExpressionParser // TypeDefIndex: 19158
{
	// Fields
	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; // 0x0
	private char _escape; // 0x10
	private char _decimalSeparator; // 0x12
	private char _listSeparator; // 0x14
	private char _exponentL; // 0x16
	private char _exponentU; // 0x18
	internal char[] _text; // 0x20
	internal int _pos; // 0x28
	internal int _start; // 0x2C
	internal Tokens _token; // 0x30
	internal int _op; // 0x34
	internal OperatorInfo[] _ops; // 0x38
	internal int _topOperator; // 0x40
	internal int _topNode; // 0x44
	private readonly DataTable _table; // 0x48
	internal ExpressionNode[] _nodeStack; // 0x50
	internal int _prevOperand; // 0x58
	internal ExpressionNode _expression; // 0x60

	// Methods

	// RVA: 0x80CCD6C Offset: 0x80C8D6C VA: 0x80CCD6C
	internal void .ctor(DataTable table) { }

	// RVA: 0x80CCE30 Offset: 0x80C8E30 VA: 0x80CCE30
	internal void LoadExpression(string data) { }

	// RVA: 0x80CE15C Offset: 0x80CA15C VA: 0x80CE15C
	internal void StartScan() { }

	// RVA: 0x80CCF30 Offset: 0x80C8F30 VA: 0x80CCF30
	internal ExpressionNode Parse() { }

	// RVA: 0x80CE940 Offset: 0x80CA940 VA: 0x80CE940
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x80CE904 Offset: 0x80CA904 VA: 0x80CE904
	private ExpressionNode NodePop() { }

	// RVA: 0x80CE8C0 Offset: 0x80CA8C0 VA: 0x80CE8C0
	private ExpressionNode NodePeek() { }

	// RVA: 0x80CE824 Offset: 0x80CA824 VA: 0x80CE824
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x80CE594 Offset: 0x80CA594 VA: 0x80CE594
	private void BuildExpression(int pri) { }

	// RVA: 0x80CE7DC Offset: 0x80CA7DC VA: 0x80CE7DC
	internal void CheckToken(Tokens token) { }

	// RVA: 0x80CE1F0 Offset: 0x80CA1F0 VA: 0x80CE1F0
	internal Tokens Scan() { }

	// RVA: 0x80CEEDC Offset: 0x80CAEDC VA: 0x80CEEDC
	private void ScanNumeric() { }

	// RVA: 0x80CF240 Offset: 0x80CB240 VA: 0x80CF240
	private void ScanName() { }

	// RVA: 0x80CEDCC Offset: 0x80CADCC VA: 0x80CEDCC
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x80CEC54 Offset: 0x80CAC54 VA: 0x80CEC54
	private void ScanDate() { }

	// RVA: 0x80CF008 Offset: 0x80CB008 VA: 0x80CF008
	private void ScanBinaryConstant() { }

	// RVA: 0x80CF020 Offset: 0x80CB020 VA: 0x80CF020
	private void ScanReserved() { }

	// RVA: 0x80CECF8 Offset: 0x80CACF8 VA: 0x80CECF8
	private void ScanString(char escape) { }

	// RVA: 0x80CE7B4 Offset: 0x80CA7B4 VA: 0x80CE7B4
	internal void ScanToken(Tokens token) { }

	// RVA: 0x80CEBFC Offset: 0x80CABFC VA: 0x80CEBFC
	private void ScanWhite() { }

	// RVA: 0x80CF2D4 Offset: 0x80CB2D4 VA: 0x80CF2D4
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x80CF204 Offset: 0x80CB204 VA: 0x80CF204
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x80CF00C Offset: 0x80CB00C VA: 0x80CF00C
	private bool IsDigit(char ch) { }

	// RVA: 0x80CF2A8 Offset: 0x80CB2A8 VA: 0x80CF2A8
	private bool IsAlpha(char ch) { }

	// RVA: 0x80CF2E8 Offset: 0x80CB2E8 VA: 0x80CF2E8
	private static void .cctor() { }
}

// Namespace: System.Data
internal enum Tokens // TypeDefIndex: 19159
{
	// Fields
	public int value__; // 0x0
	public const Tokens None = 0;
	public const Tokens Name = 1;
	public const Tokens Numeric = 2;
	public const Tokens Decimal = 3;
	public const Tokens Float = 4;
	public const Tokens BinaryConst = 5;
	public const Tokens StringConst = 6;
	public const Tokens Date = 7;
	public const Tokens ListSeparator = 8;
	public const Tokens LeftParen = 9;
	public const Tokens RightParen = 10;
	public const Tokens ZeroOp = 11;
	public const Tokens UnaryOp = 12;
	public const Tokens BinaryOp = 13;
	public const Tokens Child = 14;
	public const Tokens Parent = 15;
	public const Tokens Dot = 16;
	public const Tokens Unknown = 17;
	public const Tokens EOS = 18;
}

// Namespace: System.Data
internal sealed class OperatorInfo // TypeDefIndex: 19160
{
	// Fields
	internal Nodes _type; // 0x10
	internal int _op; // 0x14
	internal int _priority; // 0x18

	// Methods

	// RVA: 0x80CF78C Offset: 0x80CB78C VA: 0x80CF78C
	internal void .ctor(Nodes type, int op, int pri) { }
}

// Namespace: System.Data
[Serializable]
public class InvalidExpressionException : DataException // TypeDefIndex: 19161
{
	// Methods

	// RVA: 0x80CF7C8 Offset: 0x80CB7C8 VA: 0x80CF7C8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x80CF7D0 Offset: 0x80CB7D0 VA: 0x80CF7D0
	public void .ctor() { }

	// RVA: 0x80CF7D8 Offset: 0x80CB7D8 VA: 0x80CF7D8
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class EvaluateException : InvalidExpressionException // TypeDefIndex: 19162
{
	// Methods

	// RVA: 0x80CF7E0 Offset: 0x80CB7E0 VA: 0x80CF7E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x80CF7E8 Offset: 0x80CB7E8 VA: 0x80CF7E8
	public void .ctor() { }

	// RVA: 0x80CF7F0 Offset: 0x80CB7F0 VA: 0x80CF7F0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class SyntaxErrorException : InvalidExpressionException // TypeDefIndex: 19163
{
	// Methods

	// RVA: 0x80CF7F8 Offset: 0x80CB7F8 VA: 0x80CF7F8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x80CF800 Offset: 0x80CB800 VA: 0x80CF800
	public void .ctor() { }

	// RVA: 0x80CF808 Offset: 0x80CB808 VA: 0x80CF808
	public void .ctor(string s) { }
}

// Namespace: System.Data
internal sealed class ExprException // TypeDefIndex: 19164
{
	// Methods

	// RVA: 0x80CF810 Offset: 0x80CB810 VA: 0x80CF810
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x80CF878 Offset: 0x80CB878 VA: 0x80CF878
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x80CF8E0 Offset: 0x80CB8E0 VA: 0x80CF8E0
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x80CF948 Offset: 0x80CB948 VA: 0x80CF948
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x80CF9B0 Offset: 0x80CB9B0 VA: 0x80CF9B0
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x80CFA18 Offset: 0x80CBA18 VA: 0x80CFA18
	public static Exception InvokeArgument() { }

	// RVA: 0x80CFA5C Offset: 0x80CBA5C VA: 0x80CFA5C
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x80CFAAC Offset: 0x80CBAAC VA: 0x80CFAAC
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x80CFBF8 Offset: 0x80CBBF8 VA: 0x80CFBF8
	public static Exception MissingOperator(string token) { }

	// RVA: 0x80CFC48 Offset: 0x80CBC48 VA: 0x80CFC48
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x80CFC98 Offset: 0x80CBC98 VA: 0x80CFC98
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x80CFD00 Offset: 0x80CBD00 VA: 0x80CFD00
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x80CFD40 Offset: 0x80CBD40 VA: 0x80CFD40
	public static Exception UnboundName(string name) { }

	// RVA: 0x80CFD90 Offset: 0x80CBD90 VA: 0x80CFD90
	public static Exception InvalidString(string str) { }

	// RVA: 0x80CFDE0 Offset: 0x80CBDE0 VA: 0x80CFDE0
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x80CFE30 Offset: 0x80CBE30 VA: 0x80CFE30
	public static Exception SyntaxError() { }

	// RVA: 0x80CFE70 Offset: 0x80CBE70 VA: 0x80CFE70
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x80CFEC0 Offset: 0x80CBEC0 VA: 0x80CFEC0
	public static Exception MissingRightParen() { }

	// RVA: 0x80CFF00 Offset: 0x80CBF00 VA: 0x80CFF00
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x80CFFA4 Offset: 0x80CBFA4 VA: 0x80CFFA4
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x80D00B4 Offset: 0x80CC0B4 VA: 0x80D00B4
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x80D0140 Offset: 0x80CC140 VA: 0x80D0140
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x80D01CC Offset: 0x80CC1CC VA: 0x80D01CC
	public static Exception InvalidName(string name) { }

	// RVA: 0x80D021C Offset: 0x80CC21C VA: 0x80D021C
	public static Exception InvalidDate(string date) { }

	// RVA: 0x80D026C Offset: 0x80CC26C VA: 0x80D026C
	public static Exception NonConstantArgument() { }

	// RVA: 0x80D02AC Offset: 0x80CC2AC VA: 0x80D02AC
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x80D02FC Offset: 0x80CC2FC VA: 0x80D02FC
	public static Exception InWithoutParentheses() { }

	// RVA: 0x80D033C Offset: 0x80CC33C VA: 0x80D033C
	public static Exception InWithoutList() { }

	// RVA: 0x80D037C Offset: 0x80CC37C VA: 0x80D037C
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x80D03BC Offset: 0x80CC3BC VA: 0x80D03BC
	public static Exception Overflow(Type type) { }

	// RVA: 0x80D042C Offset: 0x80CC42C VA: 0x80D042C
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x80D04F4 Offset: 0x80CC4F4 VA: 0x80D04F4
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x80D0598 Offset: 0x80CC598 VA: 0x80D0598
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x80D0664 Offset: 0x80CC664 VA: 0x80D0664
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x80D0730 Offset: 0x80CC730 VA: 0x80D0730
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x80D07B0 Offset: 0x80CC7B0 VA: 0x80D07B0
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x80D0800 Offset: 0x80CC800 VA: 0x80D0800
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x80D0850 Offset: 0x80CC850 VA: 0x80D0850
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x80D0890 Offset: 0x80CC890 VA: 0x80D0890
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x80D08F0 Offset: 0x80CC8F0 VA: 0x80D08F0
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x80D0940 Offset: 0x80CC940 VA: 0x80D0940
	public static Exception AggregateArgument() { }

	// RVA: 0x80D0980 Offset: 0x80CC980 VA: 0x80D0980
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x80D09D0 Offset: 0x80CC9D0 VA: 0x80D09D0
	public static Exception EvalNoContext() { }

	// RVA: 0x80D0A10 Offset: 0x80CCA10 VA: 0x80D0A10
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x80D0A60 Offset: 0x80CCA60 VA: 0x80D0A60
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x80D0AB0 Offset: 0x80CCAB0 VA: 0x80D0AB0
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x80D0B00 Offset: 0x80CCB00 VA: 0x80D0B00
	public static Exception LookupArgument() { }

	// RVA: 0x80D0B40 Offset: 0x80CCB40 VA: 0x80D0B40
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x80D0B90 Offset: 0x80CCB90 VA: 0x80D0B90
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x80D0BD0 Offset: 0x80CCBD0 VA: 0x80D0BD0
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x80D0C10 Offset: 0x80CCC10 VA: 0x80D0C10
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x80D0C50 Offset: 0x80CCC50 VA: 0x80D0C50
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x80D0C90 Offset: 0x80CCC90 VA: 0x80D0C90
	public static Exception UnsupportedDataType(Type type) { }
}

// Namespace: System.Data
internal interface IFilter // TypeDefIndex: 19165
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Invoke(DataRow row, DataRowVersion version);
}

// Namespace: System.Data
internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 19166
{
	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0x80D0D04 Offset: 0x80CCD04 VA: 0x80D0D04
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0x80D0D48 Offset: 0x80CCD48 VA: 0x80D0D48 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x80D0FE4 Offset: 0x80CCFE4 VA: 0x80D0FE4 Slot: 6
	internal override object Eval() { }

	// RVA: 0x80D1008 Offset: 0x80CD008 VA: 0x80D1008 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x80D110C Offset: 0x80CD10C VA: 0x80D110C Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x80D113C Offset: 0x80CD13C VA: 0x80D113C Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x80D1144 Offset: 0x80CD144 VA: 0x80D1144 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x80D114C Offset: 0x80CD14C VA: 0x80D114C Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x80D1154 Offset: 0x80CD154 VA: 0x80D1154 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x80D115C Offset: 0x80CD15C VA: 0x80D115C Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x80D116C Offset: 0x80CD16C VA: 0x80D116C Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
internal sealed class NameNode : ExpressionNode // TypeDefIndex: 19167
{
	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0x80D1170 Offset: 0x80CD170 VA: 0x80D1170
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0x80D13B4 Offset: 0x80CD3B4 VA: 0x80D13B4
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x80D13E4 Offset: 0x80CD3E4 VA: 0x80D13E4 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0x80D1400 Offset: 0x80CD400 VA: 0x80D1400 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x80D166C Offset: 0x80CD66C VA: 0x80D166C Slot: 6
	internal override object Eval() { }

	// RVA: 0x80D1690 Offset: 0x80CD690 VA: 0x80D1690 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x80D1728 Offset: 0x80CD728 VA: 0x80D1728 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x80D1758 Offset: 0x80CD758 VA: 0x80D1758 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x80D1760 Offset: 0x80CD760 VA: 0x80D1760 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x80D17A8 Offset: 0x80CD7A8 VA: 0x80D17A8 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x80D17F0 Offset: 0x80CD7F0 VA: 0x80D17F0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x80D1838 Offset: 0x80CD838 VA: 0x80D1838 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x80D18A4 Offset: 0x80CD8A4 VA: 0x80D18A4 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x80D11C0 Offset: 0x80CD1C0 VA: 0x80D11C0
	internal static string ParseName(char[] text, int start, int pos) { }
}

// Namespace: System.Data
internal sealed class Operators // TypeDefIndex: 19168
{
	// Fields
	private static readonly int[] s_priority; // 0x0
	private static readonly string[] s_looks; // 0x8

	// Methods

	// RVA: 0x80D18A8 Offset: 0x80CD8A8 VA: 0x80D18A8
	internal static bool IsArithmetical(int op) { }

	// RVA: 0x80D18CC Offset: 0x80CD8CC VA: 0x80D18CC
	internal static bool IsLogical(int op) { }

	// RVA: 0x80D18F8 Offset: 0x80CD8F8 VA: 0x80D18F8
	internal static bool IsRelational(int op) { }

	// RVA: 0x80D1908 Offset: 0x80CD908 VA: 0x80D1908
	internal static int Priority(int op) { }

	// RVA: 0x80CFB38 Offset: 0x80CBB38 VA: 0x80CFB38
	internal static string ToString(int op) { }

	// RVA: 0x80D19B4 Offset: 0x80CD9B4 VA: 0x80D19B4
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 19169
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0x80D2248 Offset: 0x80CE248 VA: 0x80D2248
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0x80D2280 Offset: 0x80CE280 VA: 0x80D2280 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x80D22C8 Offset: 0x80CE2C8 VA: 0x80D22C8 Slot: 6
	internal override object Eval() { }

	// RVA: 0x80D22DC Offset: 0x80CE2DC VA: 0x80D22DC Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x80D2B18 Offset: 0x80CEB18 VA: 0x80D2B18 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x80D231C Offset: 0x80CE31C VA: 0x80D231C
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0x80D2B38 Offset: 0x80CEB38 VA: 0x80D2B38 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x80D2B58 Offset: 0x80CEB58 VA: 0x80D2B58 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x80D2B78 Offset: 0x80CEB78 VA: 0x80D2B78 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x80D2B98 Offset: 0x80CEB98 VA: 0x80D2B98 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x80D2BB8 Offset: 0x80CEBB8 VA: 0x80D2BB8 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x80D2BDC Offset: 0x80CEBDC VA: 0x80D2BDC Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 19170
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0x80D2CA4 Offset: 0x80CECA4 VA: 0x80D2CA4
	internal void .ctor(int op) { }

	// RVA: 0x80D2CD0 Offset: 0x80CECD0 VA: 0x80D2CD0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x80D2CD4 Offset: 0x80CECD4 VA: 0x80D2CD4 Slot: 6
	internal override object Eval() { }

	// RVA: 0x80D2D90 Offset: 0x80CED90 VA: 0x80D2D90 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x80D2D9C Offset: 0x80CED9C VA: 0x80D2D9C Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x80D2DA8 Offset: 0x80CEDA8 VA: 0x80D2DA8 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x80D2DB0 Offset: 0x80CEDB0 VA: 0x80D2DB0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x80D2DB8 Offset: 0x80CEDB8 VA: 0x80D2DB8 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x80D2DC0 Offset: 0x80CEDC0 VA: 0x80D2DC0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x80D2DC8 Offset: 0x80CEDC8 VA: 0x80D2DC8 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class ForeignKeyConstraint : Constraint // TypeDefIndex: 19171
{
	// Fields
	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50
	internal string _constraintName; // 0x58
	internal string[] _parentColumnNames; // 0x60
	internal string[] _childColumnNames; // 0x68
	internal string _parentTableName; // 0x70
	internal string _parentTableNamespace; // 0x78

	// Properties
	internal DataKey ChildKey { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	[DefaultValue(0)]
	public virtual AcceptRejectRule AcceptRejectRule { get; set; }
	[DefaultValue(1)]
	public virtual Rule DeleteRule { get; set; }
	[ReadOnly(True)]
	public virtual DataColumn[] RelatedColumns { get; }
	internal DataColumn[] RelatedColumnsReference { get; }
	internal DataKey ParentKey { get; }
	[ReadOnly(True)]
	public virtual DataTable RelatedTable { get; }
	[DefaultValue(1)]
	public virtual Rule UpdateRule { get; set; }

	// Methods

	// RVA: 0x80D2DCC Offset: 0x80CEDCC VA: 0x80D2DCC
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x80D2E0C Offset: 0x80CEE0C VA: 0x80D2E0C
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Browsable(False)]
	// RVA: 0x80D2FD8 Offset: 0x80CEFD8 VA: 0x80D2FD8
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0x80D3080 Offset: 0x80CF080 VA: 0x80D3080
	internal DataKey get_ChildKey() { }

	// RVA: 0x80D309C Offset: 0x80CF09C VA: 0x80D309C Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x80D30BC Offset: 0x80CF0BC VA: 0x80D30BC Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x80D30DC Offset: 0x80CF0DC VA: 0x80D30DC
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x80D30E8 Offset: 0x80CF0E8 VA: 0x80D30E8
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x80D30F4 Offset: 0x80CF0F4 VA: 0x80D30F4 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x80D321C Offset: 0x80CF21C VA: 0x80D321C Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x80D3224 Offset: 0x80CF224 VA: 0x80D3224
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x80D32E8 Offset: 0x80CF2E8 VA: 0x80D32E8 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x80D37B8 Offset: 0x80CF7B8 VA: 0x80D37B8 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x80D3924 Offset: 0x80CF924 VA: 0x80D3924
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x80D3A84 Offset: 0x80CFA84 VA: 0x80D3A84
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x80D3FB4 Offset: 0x80CFFB4 VA: 0x80D3FB4
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x80D41A0 Offset: 0x80D01A0 VA: 0x80D41A0
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x80D4638 Offset: 0x80D0638 VA: 0x80D4638
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x80D4714 Offset: 0x80D0714 VA: 0x80D4714
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x80D47DC Offset: 0x80D07DC VA: 0x80D47DC
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x80D48DC Offset: 0x80D08DC VA: 0x80D48DC Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x80D4BB0 Offset: 0x80D0BB0 VA: 0x80D4BB0
	private void NonVirtualCheckState() { }

	// RVA: 0x80D4E10 Offset: 0x80D0E10 VA: 0x80D4E10 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x80D4E14 Offset: 0x80D0E14 VA: 0x80D4E14 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x80D4E30 Offset: 0x80D0E30 VA: 0x80D4E30 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x80D4E84 Offset: 0x80D0E84 VA: 0x80D4E84 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x80D4ECC Offset: 0x80D0ECC VA: 0x80D4ECC Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x80D4EDC Offset: 0x80D0EDC VA: 0x80D4EDC Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x80D5640 Offset: 0x80D1640 VA: 0x80D5640
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x80D2E58 Offset: 0x80CEE58 VA: 0x80D2E58
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x80D5C54 Offset: 0x80D1C54 VA: 0x80D5C54 Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x80D5C70 Offset: 0x80D1C70 VA: 0x80D5C70 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x80D5CC4 Offset: 0x80D1CC4 VA: 0x80D5CC4 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0x80D5DB4 Offset: 0x80D1DB4 VA: 0x80D5DB4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x80D5DBC Offset: 0x80D1DBC VA: 0x80D5DBC Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x80D5624 Offset: 0x80D1624 VA: 0x80D5624
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x80D47C0 Offset: 0x80D07C0 VA: 0x80D47C0
	internal DataKey get_ParentKey() { }

	// RVA: 0x80D5DDC Offset: 0x80D1DDC VA: 0x80D5DDC
	internal DataRelation FindParentRelation() { }

	// RVA: 0x80D5EA4 Offset: 0x80D1EA4 VA: 0x80D5EA4 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x80D5EC4 Offset: 0x80D1EC4 VA: 0x80D5EC4 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x80D5EE0 Offset: 0x80D1EE0 VA: 0x80D5EE0 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }
}

// Namespace: System.Data
public enum MappingType // TypeDefIndex: 19172
{
	// Fields
	public int value__; // 0x0
	public const MappingType Element = 1;
	public const MappingType Attribute = 2;
	public const MappingType SimpleContent = 3;
	public const MappingType Hidden = 4;
}

// Namespace: System.Data
public class MergeFailedEventArgs : EventArgs // TypeDefIndex: 19173
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Conflict>k__BackingField; // 0x18

	// Properties
	public string Conflict { get; }

	// Methods

	// RVA: 0x80D5F34 Offset: 0x80D1F34 VA: 0x80D5F34
	public void .ctor(DataTable table, string conflict) { }

	[CompilerGenerated]
	// RVA: 0x80D5FBC Offset: 0x80D1FBC VA: 0x80D5FBC
	public string get_Conflict() { }
}

// Namespace: System.Data
public sealed class MergeFailedEventHandler : MulticastDelegate // TypeDefIndex: 19174
{
	// Methods

	// RVA: 0x80D5FC4 Offset: 0x80D1FC4 VA: 0x80D5FC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x80D60D0 Offset: 0x80D20D0 VA: 0x80D60D0 Slot: 13
	public virtual void Invoke(object sender, MergeFailedEventArgs e) { }
}

// Namespace: System.Data
internal sealed class Merger // TypeDefIndex: 19175
{
	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0x80D60E4 Offset: 0x80D20E4 VA: 0x80D60E4
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x80D6138 Offset: 0x80D2138 VA: 0x80D6138
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x80D6194 Offset: 0x80D2194 VA: 0x80D6194
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0x80D7D98 Offset: 0x80D3D98 VA: 0x80D7D98
	internal void MergeTable(DataTable src) { }

	// RVA: 0x80D7FC4 Offset: 0x80D3FC4 VA: 0x80D7FC4
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0x80D85C8 Offset: 0x80D45C8 VA: 0x80D85C8
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0x80D7288 Offset: 0x80D3288 VA: 0x80D7288
	private void MergeTableData(DataTable src) { }

	// RVA: 0x80D7310 Offset: 0x80D3310 VA: 0x80D7310
	private void MergeConstraints(DataSet source) { }

	// RVA: 0x80D8CEC Offset: 0x80D4CEC VA: 0x80D8CEC
	private void MergeConstraints(DataTable table) { }

	// RVA: 0x80D7380 Offset: 0x80D3380 VA: 0x80D7380
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0x80D7B44 Offset: 0x80D3B44 VA: 0x80D7B44
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0x80D846C Offset: 0x80D446C VA: 0x80D846C
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }
}

// Namespace: System.Data
public enum MissingSchemaAction // TypeDefIndex: 19176
{
	// Fields
	public int value__; // 0x0
	public const MissingSchemaAction Add = 1;
	public const MissingSchemaAction Ignore = 2;
	public const MissingSchemaAction Error = 3;
	public const MissingSchemaAction AddWithKey = 4;
}

// Namespace: System.Data
internal sealed class PrimaryKeyTypeConverter : ReferenceConverter // TypeDefIndex: 19177
{
	// Methods

	// RVA: 0x80D8F9C Offset: 0x80D4F9C VA: 0x80D8F9C
	public void .ctor() { }

	// RVA: 0x80D9050 Offset: 0x80D5050 VA: 0x80D9050 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x80D9058 Offset: 0x80D5058 VA: 0x80D9058 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x80D9120 Offset: 0x80D5120 VA: 0x80D9120 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
[Serializable]
public class PropertyCollection : Hashtable, ICloneable // TypeDefIndex: 19178
{
	// Methods

	// RVA: 0x80D92E4 Offset: 0x80D52E4 VA: 0x80D92E4
	public void .ctor() { }

	// RVA: 0x80D92EC Offset: 0x80D52EC VA: 0x80D92EC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x80D92F4 Offset: 0x80D52F4 VA: 0x80D92F4 Slot: 25
	public override object Clone() { }
}

// Namespace: System.Data
internal struct Range // TypeDefIndex: 19179
{
	// Fields
	private int _min; // 0x0
	private int _max; // 0x4
	private bool _isNotNull; // 0x8

	// Properties
	public int Count { get; }
	public bool IsNull { get; }
	public int Min { get; }

	// Methods

	// RVA: 0x80D95F0 Offset: 0x80D55F0 VA: 0x80D95F0
	public void .ctor(int min, int max) { }

	// RVA: 0x80D3F50 Offset: 0x80CFF50 VA: 0x80D3F50
	public int get_Count() { }

	// RVA: 0x80D3A74 Offset: 0x80CFA74 VA: 0x80D3A74
	public bool get_IsNull() { }

	// RVA: 0x80D3F70 Offset: 0x80CFF70 VA: 0x80D3F70
	public int get_Min() { }

	// RVA: 0x80D963C Offset: 0x80D563C VA: 0x80D963C
	internal void CheckNull() { }
}

// Namespace: System.Data
internal enum RBTreeError // TypeDefIndex: 19180
{
	// Fields
	public int value__; // 0x0
	public const RBTreeError InvalidPageSize = 1;
	public const RBTreeError PagePositionInSlotInUse = 3;
	public const RBTreeError NoFreeSlots = 4;
	public const RBTreeError InvalidStateinInsert = 5;
	public const RBTreeError InvalidNextSizeInDelete = 7;
	public const RBTreeError InvalidStateinDelete = 8;
	public const RBTreeError InvalidNodeSizeinDelete = 9;
	public const RBTreeError InvalidStateinEndDelete = 10;
	public const RBTreeError CannotRotateInvalidsuccessorNodeinDelete = 11;
	public const RBTreeError IndexOutOFRangeinGetNodeByIndex = 13;
	public const RBTreeError RBDeleteFixup = 14;
	public const RBTreeError UnsupportedAccessMethod1 = 15;
	public const RBTreeError UnsupportedAccessMethod2 = 16;
	public const RBTreeError UnsupportedAccessMethodInNonNillRootSubtree = 17;
	public const RBTreeError AttachedNodeWithZerorbTreeNodeId = 18;
	public const RBTreeError CompareNodeInDataRowTree = 19;
	public const RBTreeError CompareSateliteTreeNodeInDataRowTree = 20;
	public const RBTreeError NestedSatelliteTreeEnumerator = 21;
}

// Namespace: System.Data
internal enum TreeAccessMethod // TypeDefIndex: 19181
{
	// Fields
	public int value__; // 0x0
	public const TreeAccessMethod KEY_SEARCH_AND_INDEX = 1;
	public const TreeAccessMethod INDEX_ONLY = 2;
}

// Namespace: 
private enum RBTree.NodeColor<K> // TypeDefIndex: 19182
{
	// Fields
	public int value__; // 0x0
	public const RBTree.NodeColor<K> red = 0;
	public const RBTree.NodeColor<K> black = 1;
}

// Namespace: 
private struct RBTree.Node<K> // TypeDefIndex: 19183
{
	// Fields
	internal int _selfId; // 0x0
	internal int _leftId; // 0x0
	internal int _rightId; // 0x0
	internal int _parentId; // 0x0
	internal int _nextId; // 0x0
	internal int _subTreeSize; // 0x0
	internal K _keyOfNode; // 0x0
	internal RBTree.NodeColor<K> _nodeColor; // 0x0
}

// Namespace: 
[IsReadOnly]
private struct RBTree.NodePath<K> // TypeDefIndex: 19184
{
	// Fields
	internal readonly int _nodeID; // 0x0
	internal readonly int _mainTreeNodeID; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int nodeID, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512A5CC Offset: 0x51265CC VA: 0x512A5CC
	|-RBTree.NodePath<int>..ctor
	|
	|-RVA: 0x512A5D4 Offset: 0x51265D4 VA: 0x512A5D4
	|-RBTree.NodePath<object>..ctor
	|
	|-RVA: 0x512A5DC Offset: 0x51265DC VA: 0x512A5DC
	|-RBTree.NodePath<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private sealed class RBTree.TreePage<K> // TypeDefIndex: 19185
{
	// Fields
	internal readonly RBTree.Node<K>[] _slots; // 0x0
	internal readonly int[] _slotMap; // 0x0
	private int _inUseCount; // 0x0
	private int _pageId; // 0x0
	private int _nextFreeSlotLine; // 0x0

	// Properties
	internal int InUseCount { get; set; }
	internal int PageId { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5643BE0 Offset: 0x563FBE0 VA: 0x5643BE0
	|-RBTree.TreePage<int>..ctor
	|
	|-RVA: 0x5643E04 Offset: 0x563FE04 VA: 0x5643E04
	|-RBTree.TreePage<object>..ctor
	|
	|-RVA: 0x5644028 Offset: 0x5640028 VA: 0x5644028
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int AllocSlot(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5643CB0 Offset: 0x563FCB0 VA: 0x5643CB0
	|-RBTree.TreePage<int>.AllocSlot
	|
	|-RVA: 0x5643ED4 Offset: 0x563FED4 VA: 0x5643ED4
	|-RBTree.TreePage<object>.AllocSlot
	|
	|-RVA: 0x56440F8 Offset: 0x56400F8 VA: 0x56440F8
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.AllocSlot
	*/

	// RVA: -1 Offset: -1
	internal int get_InUseCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5643DE4 Offset: 0x563FDE4 VA: 0x5643DE4
	|-RBTree.TreePage<int>.get_InUseCount
	|
	|-RVA: 0x5644008 Offset: 0x5640008 VA: 0x5644008
	|-RBTree.TreePage<object>.get_InUseCount
	|
	|-RVA: 0x564424C Offset: 0x564024C VA: 0x564424C
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.get_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal void set_InUseCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5643DEC Offset: 0x563FDEC VA: 0x5643DEC
	|-RBTree.TreePage<int>.set_InUseCount
	|
	|-RVA: 0x5644010 Offset: 0x5640010 VA: 0x5644010
	|-RBTree.TreePage<object>.set_InUseCount
	|
	|-RVA: 0x5644254 Offset: 0x5640254 VA: 0x5644254
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.set_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal int get_PageId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5643DF4 Offset: 0x563FDF4 VA: 0x5643DF4
	|-RBTree.TreePage<int>.get_PageId
	|
	|-RVA: 0x5644018 Offset: 0x5640018 VA: 0x5644018
	|-RBTree.TreePage<object>.get_PageId
	|
	|-RVA: 0x564425C Offset: 0x564025C VA: 0x564425C
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.get_PageId
	*/

	// RVA: -1 Offset: -1
	internal void set_PageId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5643DFC Offset: 0x563FDFC VA: 0x5643DFC
	|-RBTree.TreePage<int>.set_PageId
	|
	|-RVA: 0x5644020 Offset: 0x5640020 VA: 0x5644020
	|-RBTree.TreePage<object>.set_PageId
	|
	|-RVA: 0x5644264 Offset: 0x5640264 VA: 0x5644264
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.set_PageId
	*/
}

// Namespace: 
internal struct RBTree.RBTreeEnumerator<K> : IEnumerator<K>, IDisposable, IEnumerator // TypeDefIndex: 19186
{
	// Fields
	private readonly RBTree<K> _tree; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private int _mainTreeNodeId; // 0x0
	private K _current; // 0x0

	// Properties
	public K Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EDC08 Offset: 0x52E9C08 VA: 0x52EDC08
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x52EDE5C Offset: 0x52E9E5C VA: 0x52EDE5C
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0x52EE080 Offset: 0x52EA080 VA: 0x52EE080
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EDC44 Offset: 0x52E9C44 VA: 0x52EDC44
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x52EDE9C Offset: 0x52E9E9C VA: 0x52EDE9C
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0x52EE1CC Offset: 0x52EA1CC VA: 0x52EE1CC
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EDCE8 Offset: 0x52E9CE8 VA: 0x52EDCE8
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|
	|-RVA: 0x52EDF40 Offset: 0x52E9F40 VA: 0x52EDF40
	|-RBTree.RBTreeEnumerator<object>.Dispose
	|
	|-RVA: 0x52EE440 Offset: 0x52EA440 VA: 0x52EE440
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EDCEC Offset: 0x52E9CEC VA: 0x52EDCEC
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RVA: 0x52EDF44 Offset: 0x52E9F44 VA: 0x52EDF44
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	|
	|-RVA: 0x52EE444 Offset: 0x52EA444 VA: 0x52EE444
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EDDA4 Offset: 0x52E9DA4 VA: 0x52EDDA4
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RVA: 0x52EE004 Offset: 0x52EA004 VA: 0x52EE004
	|-RBTree.RBTreeEnumerator<object>.get_Current
	|
	|-RVA: 0x52EE778 Offset: 0x52EA778 VA: 0x52EE778
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EDDAC Offset: 0x52E9DAC VA: 0x52EDDAC
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x52EE00C Offset: 0x52EA00C VA: 0x52EE00C
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x52EE868 Offset: 0x52EA868 VA: 0x52EE868
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EDE14 Offset: 0x52E9E14 VA: 0x52EDE14
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x52EE034 Offset: 0x52EA034 VA: 0x52EE034
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x52EE98C Offset: 0x52EA98C VA: 0x52EE98C
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: System.Data
[DefaultMember("Item")]
internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 19187
{
	// Fields
	private RBTree.TreePage<K>[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	// Properties
	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareNode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareSateliteTreeNode
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EEB1C Offset: 0x52EAB1C VA: 0x52EEB1C
	|-RBTree<int>..ctor
	|
	|-RVA: 0x52F2318 Offset: 0x52EE318 VA: 0x52F2318
	|-RBTree<object>..ctor
	|
	|-RVA: 0x52F5ADC Offset: 0x52F1ADC VA: 0x52F5ADC
	|-RBTree<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EEB58 Offset: 0x52EAB58 VA: 0x52EEB58
	|-RBTree<int>.InitTree
	|
	|-RVA: 0x52F2354 Offset: 0x52EE354 VA: 0x52F2354
	|-RBTree<object>.InitTree
	|
	|-RVA: 0x52F5B1C Offset: 0x52F1B1C VA: 0x52F5B1C
	|-RBTree<__Il2CppFullySharedGenericType>.InitTree
	*/

	// RVA: -1 Offset: -1
	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EEC88 Offset: 0x52EAC88 VA: 0x52EEC88
	|-RBTree<int>.FreePage
	|
	|-RVA: 0x52F2484 Offset: 0x52EE484 VA: 0x52F2484
	|-RBTree<object>.FreePage
	|
	|-RVA: 0x52F5C94 Offset: 0x52F1C94 VA: 0x52F5C94
	|-RBTree<__Il2CppFullySharedGenericType>.FreePage
	*/

	// RVA: -1 Offset: -1
	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EECF4 Offset: 0x52EACF4 VA: 0x52EECF4
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0x52F24F0 Offset: 0x52EE4F0 VA: 0x52F24F0
	|-RBTree<object>.AllocPage
	|
	|-RVA: 0x52F5D1C Offset: 0x52F1D1C VA: 0x52F5D1C
	|-RBTree<__Il2CppFullySharedGenericType>.AllocPage
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EEF5C Offset: 0x52EAF5C VA: 0x52EEF5C
	|-RBTree<int>.MarkPageFull
	|
	|-RVA: 0x52F2758 Offset: 0x52EE758 VA: 0x52F2758
	|-RBTree<object>.MarkPageFull
	|
	|-RVA: 0x52F5FC8 Offset: 0x52F1FC8 VA: 0x52F5FC8
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFull
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EEFB4 Offset: 0x52EAFB4 VA: 0x52EEFB4
	|-RBTree<int>.MarkPageFree
	|
	|-RVA: 0x52F27B0 Offset: 0x52EE7B0 VA: 0x52F27B0
	|-RBTree<object>.MarkPageFree
	|
	|-RVA: 0x52F605C Offset: 0x52F205C VA: 0x52F605C
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFree
	*/

	// RVA: -1 Offset: -1
	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF00C Offset: 0x52EB00C VA: 0x52EF00C
	|-RBTree<int>.GetIntValueFromBitMap
	|
	|-RVA: 0x52F2808 Offset: 0x52EE808 VA: 0x52F2808
	|-RBTree<object>.GetIntValueFromBitMap
	|
	|-RVA: 0x52F60F0 Offset: 0x52F20F0 VA: 0x52F60F0
	|-RBTree<__Il2CppFullySharedGenericType>.GetIntValueFromBitMap
	*/

	// RVA: -1 Offset: -1
	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF070 Offset: 0x52EB070 VA: 0x52EF070
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0x52F286C Offset: 0x52EE86C VA: 0x52F286C
	|-RBTree<object>.FreeNode
	|
	|-RVA: 0x52F6154 Offset: 0x52F2154 VA: 0x52F6154
	|-RBTree<__Il2CppFullySharedGenericType>.FreeNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF154 Offset: 0x52EB154 VA: 0x52EF154
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x52F2954 Offset: 0x52EE954 VA: 0x52F2954
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x52F62D8 Offset: 0x52F22D8 VA: 0x52F62D8
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexOfPageWithFreeSlot
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF284 Offset: 0x52EB284 VA: 0x52EF284
	|-RBTree<int>.get_Count
	|
	|-RVA: 0x52F2A84 Offset: 0x52EEA84 VA: 0x52F2A84
	|-RBTree<object>.get_Count
	|
	|-RVA: 0x52F6418 Offset: 0x52F2418 VA: 0x52F6418
	|-RBTree<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF290 Offset: 0x52EB290 VA: 0x52EF290
	|-RBTree<int>.get_HasDuplicates
	|
	|-RVA: 0x52F2A90 Offset: 0x52EEA90 VA: 0x52F2A90
	|-RBTree<object>.get_HasDuplicates
	|
	|-RVA: 0x52F6424 Offset: 0x52F2424 VA: 0x52F6424
	|-RBTree<__Il2CppFullySharedGenericType>.get_HasDuplicates
	*/

	// RVA: -1 Offset: -1
	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF2A0 Offset: 0x52EB2A0 VA: 0x52EF2A0
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0x52F2AA0 Offset: 0x52EEAA0 VA: 0x52F2AA0
	|-RBTree<object>.GetNewNode
	|
	|-RVA: 0x52F6434 Offset: 0x52F2434 VA: 0x52F6434
	|-RBTree<__Il2CppFullySharedGenericType>.GetNewNode
	*/

	// RVA: -1 Offset: -1
	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF400 Offset: 0x52EB400 VA: 0x52EF400
	|-RBTree<int>.Successor
	|
	|-RVA: 0x52F2C34 Offset: 0x52EEC34 VA: 0x52F2C34
	|-RBTree<object>.Successor
	|
	|-RVA: 0x52F6734 Offset: 0x52F2734 VA: 0x52F6734
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF494 Offset: 0x52EB494 VA: 0x52EF494
	|-RBTree<int>.Successor
	|
	|-RVA: 0x52F2CC8 Offset: 0x52EECC8 VA: 0x52F2CC8
	|-RBTree<object>.Successor
	|
	|-RVA: 0x52F6820 Offset: 0x52F2820 VA: 0x52F6820
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF594 Offset: 0x52EB594 VA: 0x52EF594
	|-RBTree<int>.Minimum
	|
	|-RVA: 0x52F2DC8 Offset: 0x52EEDC8 VA: 0x52F2DC8
	|-RBTree<object>.Minimum
	|
	|-RVA: 0x52F6944 Offset: 0x52F2944 VA: 0x52F6944
	|-RBTree<__Il2CppFullySharedGenericType>.Minimum
	*/

	// RVA: -1 Offset: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF5D8 Offset: 0x52EB5D8 VA: 0x52EF5D8
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0x52F2E0C Offset: 0x52EEE0C VA: 0x52F2E0C
	|-RBTree<object>.LeftRotate
	|
	|-RVA: 0x52F69BC Offset: 0x52F29BC VA: 0x52F69BC
	|-RBTree<__Il2CppFullySharedGenericType>.LeftRotate
	*/

	// RVA: -1 Offset: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EF848 Offset: 0x52EB848 VA: 0x52EF848
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0x52F307C Offset: 0x52EF07C VA: 0x52F307C
	|-RBTree<object>.RightRotate
	|
	|-RVA: 0x52F6ECC Offset: 0x52F2ECC VA: 0x52F6ECC
	|-RBTree<__Il2CppFullySharedGenericType>.RightRotate
	*/

	// RVA: -1 Offset: -1
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52EFAB8 Offset: 0x52EBAB8 VA: 0x52EFAB8
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0x52F32EC Offset: 0x52EF2EC VA: 0x52F32EC
	|-RBTree<object>.RBInsert
	|
	|-RVA: 0x52F73E0 Offset: 0x52F33E0 VA: 0x52F73E0
	|-RBTree<__Il2CppFullySharedGenericType>.RBInsert
	*/

	// RVA: -1 Offset: -1
	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F02F4 Offset: 0x52EC2F4 VA: 0x52F02F4
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0x52F3B28 Offset: 0x52EFB28 VA: 0x52F3B28
	|-RBTree<object>.UpdateNodeKey
	|
	|-RVA: 0x52F83D4 Offset: 0x52F43D4 VA: 0x52F83D4
	|-RBTree<__Il2CppFullySharedGenericType>.UpdateNodeKey
	*/

	// RVA: -1 Offset: -1
	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F035C Offset: 0x52EC35C VA: 0x52F035C
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0x52F3B90 Offset: 0x52EFB90 VA: 0x52F3B90
	|-RBTree<object>.DeleteByIndex
	|
	|-RVA: 0x52F85B4 Offset: 0x52F45B4 VA: 0x52F85B4
	|-RBTree<__Il2CppFullySharedGenericType>.DeleteByIndex
	*/

	// RVA: -1 Offset: -1
	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F03CC Offset: 0x52EC3CC VA: 0x52F03CC
	|-RBTree<int>.RBDelete
	|
	|-RVA: 0x52F3C00 Offset: 0x52EFC00 VA: 0x52F3C00
	|-RBTree<object>.RBDelete
	|
	|-RVA: 0x52F86B4 Offset: 0x52F46B4 VA: 0x52F86B4
	|-RBTree<__Il2CppFullySharedGenericType>.RBDelete
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F03EC Offset: 0x52EC3EC VA: 0x52F03EC
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0x52F3C20 Offset: 0x52EFC20 VA: 0x52F3C20
	|-RBTree<object>.RBDeleteX
	|
	|-RVA: 0x52F86D8 Offset: 0x52F46D8 VA: 0x52F86D8
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteX
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F0AFC Offset: 0x52ECAFC VA: 0x52F0AFC
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0x52F4330 Offset: 0x52F0330 VA: 0x52F4330
	|-RBTree<object>.RBDeleteFixup
	|
	|-RVA: 0x52F93F4 Offset: 0x52F53F4 VA: 0x52F93F4
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteFixup
	*/

	// RVA: -1 Offset: -1
	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F0FC8 Offset: 0x52ECFC8 VA: 0x52F0FC8
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0x52F47FC Offset: 0x52F07FC VA: 0x52F47FC
	|-RBTree<object>.SearchSubTree
	|
	|-RVA: 0x52F9C68 Offset: 0x52F5C68 VA: 0x52F9C68
	|-RBTree<__Il2CppFullySharedGenericType>.SearchSubTree
	*/

	// RVA: -1 Offset: -1
	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1084 Offset: 0x52ED084 VA: 0x52F1084
	|-RBTree<int>.get_Item
	|
	|-RVA: 0x52F48B8 Offset: 0x52F08B8 VA: 0x52F48B8
	|-RBTree<object>.get_Item
	|
	|-RVA: 0x52F9E3C Offset: 0x52F5E3C VA: 0x52F9E3C
	|-RBTree<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F10AC Offset: 0x52ED0AC VA: 0x52F10AC
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0x52F48E0 Offset: 0x52F08E0 VA: 0x52F48E0
	|-RBTree<object>.GetNodeByKey
	|
	|-RVA: 0x52F9F0C Offset: 0x52F5F0C VA: 0x52F9F0C
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F11B0 Offset: 0x52ED1B0 VA: 0x52F11B0
	|-RBTree<int>.GetIndexByKey
	|
	|-RVA: 0x52F49C4 Offset: 0x52F09C4 VA: 0x52F49C4
	|-RBTree<object>.GetIndexByKey
	|
	|-RVA: 0x52FA214 Offset: 0x52F6214 VA: 0x52FA214
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1204 Offset: 0x52ED204 VA: 0x52F1204
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0x52F4A18 Offset: 0x52F0A18 VA: 0x52F4A18
	|-RBTree<object>.GetIndexByNode
	|
	|-RVA: 0x52FA308 Offset: 0x52F6308 VA: 0x52FA308
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F12E8 Offset: 0x52ED2E8 VA: 0x52F12E8
	|-RBTree<int>.GetIndexByNodePath
	|
	|-RVA: 0x52F4AFC Offset: 0x52F0AFC VA: 0x52F4AFC
	|-RBTree<object>.GetIndexByNodePath
	|
	|-RVA: 0x52FA47C Offset: 0x52F647C VA: 0x52FA47C
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNodePath
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1380 Offset: 0x52ED380 VA: 0x52F1380
	|-RBTree<int>.ComputeIndexByNode
	|
	|-RVA: 0x52F4B94 Offset: 0x52F0B94 VA: 0x52F4B94
	|-RBTree<object>.ComputeIndexByNode
	|
	|-RVA: 0x52FA50C Offset: 0x52F650C VA: 0x52FA50C
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F140C Offset: 0x52ED40C VA: 0x52F140C
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x52F4C20 Offset: 0x52F0C20 VA: 0x52F4C20
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x52FA5FC Offset: 0x52F65FC VA: 0x52FA5FC
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexWithSatelliteByNode
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F14CC Offset: 0x52ED4CC VA: 0x52F14CC
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0x52F4CE0 Offset: 0x52F0CE0 VA: 0x52F4CE0
	|-RBTree<object>.GetNodeByIndex
	|
	|-RVA: 0x52FA750 Offset: 0x52F6750 VA: 0x52FA750
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F159C Offset: 0x52ED59C VA: 0x52F159C
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x52F4DB0 Offset: 0x52F0DB0 VA: 0x52F4DB0
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x52FA828 Offset: 0x52F6828 VA: 0x52FA828
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F16E8 Offset: 0x52ED6E8 VA: 0x52F16E8
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x52F4EFC Offset: 0x52F0EFC VA: 0x52F4EFC
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x52FAA24 Offset: 0x52F6A24 VA: 0x52FAA24
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1760 Offset: 0x52ED760 VA: 0x52F1760
	|-RBTree<int>.Insert
	|
	|-RVA: 0x52F4F74 Offset: 0x52F0F74 VA: 0x52F4F74
	|-RBTree<object>.Insert
	|
	|-RVA: 0x52FAAD8 Offset: 0x52F6AD8 VA: 0x52FAAD8
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F17BC Offset: 0x52ED7BC VA: 0x52F17BC
	|-RBTree<int>.Add
	|
	|-RVA: 0x52F4FD0 Offset: 0x52F0FD0 VA: 0x52F4FD0
	|-RBTree<object>.Add
	|
	|-RVA: 0x52FABD8 Offset: 0x52F6BD8 VA: 0x52FABD8
	|-RBTree<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1818 Offset: 0x52ED818 VA: 0x52F1818
	|-RBTree<int>.GetEnumerator
	|
	|-RVA: 0x52F502C Offset: 0x52F102C VA: 0x52F502C
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0x52FACD8 Offset: 0x52F6CD8 VA: 0x52FACD8
	|-RBTree<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1868 Offset: 0x52ED868 VA: 0x52F1868
	|-RBTree<int>.IndexOf
	|
	|-RVA: 0x52F5074 Offset: 0x52F1074 VA: 0x52F5074
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0x52FAD88 Offset: 0x52F6D88 VA: 0x52FAD88
	|-RBTree<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1960 Offset: 0x52ED960 VA: 0x52F1960
	|-RBTree<int>.Insert
	|
	|-RVA: 0x52F5130 Offset: 0x52F1130 VA: 0x52F5130
	|-RBTree<object>.Insert
	|
	|-RVA: 0x52FAFF4 Offset: 0x52F6FF4 VA: 0x52FAFF4
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1974 Offset: 0x52ED974 VA: 0x52F1974
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0x52F5144 Offset: 0x52F1144 VA: 0x52F5144
	|-RBTree<object>.InsertAt
	|
	|-RVA: 0x52FB0DC Offset: 0x52F70DC VA: 0x52FB0DC
	|-RBTree<__Il2CppFullySharedGenericType>.InsertAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F19E8 Offset: 0x52ED9E8 VA: 0x52F19E8
	|-RBTree<int>.RemoveAt
	|
	|-RVA: 0x52F51B8 Offset: 0x52F11B8 VA: 0x52F51B8
	|-RBTree<object>.RemoveAt
	|
	|-RVA: 0x52FB1F0 Offset: 0x52F71F0 VA: 0x52FB1F0
	|-RBTree<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F19F8 Offset: 0x52ED9F8 VA: 0x52F19F8
	|-RBTree<int>.Clear
	|
	|-RVA: 0x52F51C8 Offset: 0x52F11C8 VA: 0x52F51C8
	|-RBTree<object>.Clear
	|
	|-RVA: 0x52FB27C Offset: 0x52F727C VA: 0x52FB27C
	|-RBTree<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1A24 Offset: 0x52EDA24 VA: 0x52F1A24
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x52F51F4 Offset: 0x52F11F4 VA: 0x52F51F4
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x52FB2AC Offset: 0x52F72AC VA: 0x52FB2AC
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1B4C Offset: 0x52EDB4C VA: 0x52F1B4C
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x52F5304 Offset: 0x52F1304 VA: 0x52F5304
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x52FB478 Offset: 0x52F7478 VA: 0x52FB478
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1C6C Offset: 0x52EDC6C VA: 0x52F1C6C
	|-RBTree<int>.SetRight
	|
	|-RVA: 0x52F542C Offset: 0x52F142C VA: 0x52F542C
	|-RBTree<object>.SetRight
	|
	|-RVA: 0x52FB6A0 Offset: 0x52F76A0 VA: 0x52FB6A0
	|-RBTree<__Il2CppFullySharedGenericType>.SetRight
	*/

	// RVA: -1 Offset: -1
	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1CC8 Offset: 0x52EDCC8 VA: 0x52F1CC8
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0x52F5488 Offset: 0x52F1488 VA: 0x52F5488
	|-RBTree<object>.SetLeft
	|
	|-RVA: 0x52FB71C Offset: 0x52F771C VA: 0x52FB71C
	|-RBTree<__Il2CppFullySharedGenericType>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1D24 Offset: 0x52EDD24 VA: 0x52F1D24
	|-RBTree<int>.SetParent
	|
	|-RVA: 0x52F54E4 Offset: 0x52F14E4 VA: 0x52F54E4
	|-RBTree<object>.SetParent
	|
	|-RVA: 0x52FB798 Offset: 0x52F7798 VA: 0x52FB798
	|-RBTree<__Il2CppFullySharedGenericType>.SetParent
	*/

	// RVA: -1 Offset: -1
	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1D80 Offset: 0x52EDD80 VA: 0x52F1D80
	|-RBTree<int>.SetColor
	|
	|-RVA: 0x52F5540 Offset: 0x52F1540 VA: 0x52F5540
	|-RBTree<object>.SetColor
	|
	|-RVA: 0x52FB814 Offset: 0x52F7814 VA: 0x52FB814
	|-RBTree<__Il2CppFullySharedGenericType>.SetColor
	*/

	// RVA: -1 Offset: -1
	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1DDC Offset: 0x52EDDDC VA: 0x52F1DDC
	|-RBTree<int>.SetKey
	|
	|-RVA: 0x52F559C Offset: 0x52F159C VA: 0x52F559C
	|-RBTree<object>.SetKey
	|
	|-RVA: 0x52FB890 Offset: 0x52F7890 VA: 0x52FB890
	|-RBTree<__Il2CppFullySharedGenericType>.SetKey
	*/

	// RVA: -1 Offset: -1
	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1E38 Offset: 0x52EDE38 VA: 0x52F1E38
	|-RBTree<int>.SetNext
	|
	|-RVA: 0x52F55FC Offset: 0x52F15FC VA: 0x52F55FC
	|-RBTree<object>.SetNext
	|
	|-RVA: 0x52FB9A0 Offset: 0x52F79A0 VA: 0x52FB9A0
	|-RBTree<__Il2CppFullySharedGenericType>.SetNext
	*/

	// RVA: -1 Offset: -1
	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1E94 Offset: 0x52EDE94 VA: 0x52F1E94
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0x52F5658 Offset: 0x52F1658 VA: 0x52F5658
	|-RBTree<object>.SetSubTreeSize
	|
	|-RVA: 0x52FBA1C Offset: 0x52F7A1C VA: 0x52FBA1C
	|-RBTree<__Il2CppFullySharedGenericType>.SetSubTreeSize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1EF0 Offset: 0x52EDEF0 VA: 0x52F1EF0
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0x52F56B4 Offset: 0x52F16B4 VA: 0x52F56B4
	|-RBTree<object>.IncreaseSize
	|
	|-RVA: 0x52FBA98 Offset: 0x52F7A98 VA: 0x52FBA98
	|-RBTree<__Il2CppFullySharedGenericType>.IncreaseSize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F1F54 Offset: 0x52EDF54 VA: 0x52F1F54
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0x52F5718 Offset: 0x52F1718 VA: 0x52F5718
	|-RBTree<object>.RecomputeSize
	|
	|-RVA: 0x52FBB24 Offset: 0x52F7B24 VA: 0x52FBB24
	|-RBTree<__Il2CppFullySharedGenericType>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F2030 Offset: 0x52EE030 VA: 0x52F2030
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0x52F57F4 Offset: 0x52F17F4 VA: 0x52F57F4
	|-RBTree<object>.DecreaseSize
	|
	|-RVA: 0x52FBC94 Offset: 0x52F7C94 VA: 0x52FBC94
	|-RBTree<__Il2CppFullySharedGenericType>.DecreaseSize
	*/

	// RVA: -1 Offset: -1
	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F2094 Offset: 0x52EE094 VA: 0x52F2094
	|-RBTree<int>.Right
	|
	|-RVA: 0x52F5858 Offset: 0x52F1858 VA: 0x52F5858
	|-RBTree<object>.Right
	|
	|-RVA: 0x52FBD20 Offset: 0x52F7D20 VA: 0x52FBD20
	|-RBTree<__Il2CppFullySharedGenericType>.Right
	*/

	// RVA: -1 Offset: -1
	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F20F0 Offset: 0x52EE0F0 VA: 0x52F20F0
	|-RBTree<int>.Left
	|
	|-RVA: 0x52F58B4 Offset: 0x52F18B4 VA: 0x52F58B4
	|-RBTree<object>.Left
	|
	|-RVA: 0x52FBDA4 Offset: 0x52F7DA4 VA: 0x52FBDA4
	|-RBTree<__Il2CppFullySharedGenericType>.Left
	*/

	// RVA: -1 Offset: -1
	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F214C Offset: 0x52EE14C VA: 0x52F214C
	|-RBTree<int>.Parent
	|
	|-RVA: 0x52F5910 Offset: 0x52F1910 VA: 0x52F5910
	|-RBTree<object>.Parent
	|
	|-RVA: 0x52FBE28 Offset: 0x52F7E28 VA: 0x52FBE28
	|-RBTree<__Il2CppFullySharedGenericType>.Parent
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F21A8 Offset: 0x52EE1A8 VA: 0x52F21A8
	|-RBTree<int>.color
	|
	|-RVA: 0x52F596C Offset: 0x52F196C VA: 0x52F596C
	|-RBTree<object>.color
	|
	|-RVA: 0x52FBEAC Offset: 0x52F7EAC VA: 0x52FBEAC
	|-RBTree<__Il2CppFullySharedGenericType>.color
	*/

	// RVA: -1 Offset: -1
	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F2204 Offset: 0x52EE204 VA: 0x52F2204
	|-RBTree<int>.Next
	|
	|-RVA: 0x52F59C8 Offset: 0x52F19C8 VA: 0x52F59C8
	|-RBTree<object>.Next
	|
	|-RVA: 0x52FBF30 Offset: 0x52F7F30 VA: 0x52FBF30
	|-RBTree<__Il2CppFullySharedGenericType>.Next
	*/

	// RVA: -1 Offset: -1
	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F2260 Offset: 0x52EE260 VA: 0x52F2260
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0x52F5A24 Offset: 0x52F1A24 VA: 0x52F5A24
	|-RBTree<object>.SubTreeSize
	|
	|-RVA: 0x52FBFB4 Offset: 0x52F7FB4 VA: 0x52FBFB4
	|-RBTree<__Il2CppFullySharedGenericType>.SubTreeSize
	*/

	// RVA: -1 Offset: -1
	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F22BC Offset: 0x52EE2BC VA: 0x52F22BC
	|-RBTree<int>.Key
	|
	|-RVA: 0x52F5A80 Offset: 0x52F1A80 VA: 0x52F5A80
	|-RBTree<object>.Key
	|
	|-RVA: 0x52FC038 Offset: 0x52F8038 VA: 0x52FC038
	|-RBTree<__Il2CppFullySharedGenericType>.Key
	*/
}

// Namespace: System.Data
[DefaultMember("Item")]
internal sealed class RecordManager // TypeDefIndex: 19188
{
	// Fields
	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly List<int> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	// Properties
	internal int LastFreeRecord { get; }
	internal int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; set; }
	internal DataRow Item { get; set; }

	// Methods

	// RVA: 0x80D9674 Offset: 0x80D5674 VA: 0x80D9674
	internal void .ctor(DataTable table) { }

	// RVA: 0x80D974C Offset: 0x80D574C VA: 0x80D974C
	private void GrowRecordCapacity() { }

	// RVA: 0x80D9938 Offset: 0x80D5938 VA: 0x80D9938
	internal int get_LastFreeRecord() { }

	// RVA: 0x80D9940 Offset: 0x80D5940 VA: 0x80D9940
	internal int get_MinimumCapacity() { }

	// RVA: 0x80D9948 Offset: 0x80D5948 VA: 0x80D9948
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x80D998C Offset: 0x80D598C VA: 0x80D998C
	internal int get_RecordCapacity() { }

	// RVA: 0x80D98A8 Offset: 0x80D58A8 VA: 0x80D98A8
	internal void set_RecordCapacity(int value) { }

	// RVA: 0x80D985C Offset: 0x80D585C VA: 0x80D985C
	internal static int NewCapacity(int capacity) { }

	// RVA: 0x80D9870 Offset: 0x80D5870 VA: 0x80D9870
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0x80D9994 Offset: 0x80D5994 VA: 0x80D9994
	internal int NewRecordBase() { }

	// RVA: 0x80D9A60 Offset: 0x80D5A60 VA: 0x80D9A60
	internal void FreeRecord(ref int record) { }

	// RVA: 0x80D9C18 Offset: 0x80D5C18 VA: 0x80D9C18
	internal void Clear(bool clearAll) { }

	// RVA: 0x80D9E18 Offset: 0x80D5E18 VA: 0x80D9E18
	internal DataRow get_Item(int record) { }

	// RVA: 0x80D9BB0 Offset: 0x80D5BB0 VA: 0x80D9BB0
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0x80D9E48 Offset: 0x80D5E48 VA: 0x80D9E48
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0x80D9E50 Offset: 0x80D5E50 VA: 0x80D9E50
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0x80DA164 Offset: 0x80D6164 VA: 0x80DA164
	internal void SetRowCache(DataRow[] newRows) { }
}

// Namespace: System.Data
internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 19189
{
	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xD0
	private readonly DataKey _childKey; // 0xE0
	private readonly DataRowView _parentRowView; // 0xE8
	private readonly object[] _filterValues; // 0xF0

	// Methods

	// RVA: 0x80DA1A4 Offset: 0x80D61A4 VA: 0x80DA1A4
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0x80DA2E0 Offset: 0x80D62E0 VA: 0x80DA2E0
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0x80DA41C Offset: 0x80D641C VA: 0x80DA41C
	private object[] GetParentValues() { }

	// RVA: 0x80DA4B4 Offset: 0x80D64B4 VA: 0x80DA4B4 Slot: 72
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x80DA63C Offset: 0x80D663C VA: 0x80DA63C Slot: 66
	internal override IFilter GetFilter() { }

	// RVA: 0x80DA640 Offset: 0x80D6640 VA: 0x80DA640 Slot: 65
	public override DataRowView AddNew() { }

	// RVA: 0x80DA6A0 Offset: 0x80D66A0 VA: 0x80DA6A0 Slot: 69
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }
}

// Namespace: System.Data
internal sealed class RelationshipConverter : ExpandableObjectConverter // TypeDefIndex: 19190
{
	// Methods

	// RVA: 0x80DA6C4 Offset: 0x80D66C4 VA: 0x80DA6C4
	public void .ctor() { }

	// RVA: 0x80DA6CC Offset: 0x80D66CC VA: 0x80DA6CC Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x80DA794 Offset: 0x80D6794 VA: 0x80DA794 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
public enum Rule // TypeDefIndex: 19191
{
	// Fields
	public int value__; // 0x0
	public const Rule None = 0;
	public const Rule Cascade = 1;
	public const Rule SetNull = 2;
	public const Rule SetDefault = 3;
}

// Namespace: System.Data
public enum SchemaSerializationMode // TypeDefIndex: 19192
{
	// Fields
	public int value__; // 0x0
	public const SchemaSerializationMode IncludeSchema = 1;
	public const SchemaSerializationMode ExcludeSchema = 2;
}

// Namespace: System.Data
[IsReadOnly]
internal struct IndexField // TypeDefIndex: 19193
{
	// Fields
	public readonly DataColumn Column; // 0x0
	public readonly bool IsDescending; // 0x8

	// Methods

	// RVA: 0x80DB3A4 Offset: 0x80D73A4 VA: 0x80DB3A4
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0x80DB3CC Offset: 0x80D73CC VA: 0x80DB3CC
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0x80DB3E8 Offset: 0x80D73E8 VA: 0x80DB3E8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x80DB478 Offset: 0x80D7478 VA: 0x80DB478 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class Index.IndexTree : RBTree<int> // TypeDefIndex: 19194
{
	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0x80DDCFC Offset: 0x80D9CFC VA: 0x80DDCFC
	internal void .ctor(Index index) { }

	// RVA: 0x80DE5D4 Offset: 0x80DA5D4 VA: 0x80DE5D4 Slot: 5
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0x80DE5EC Offset: 0x80DA5EC VA: 0x80DE5EC Slot: 6
	protected override int CompareSateliteTreeNode(int record1, int record2) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Index.<>c // TypeDefIndex: 19195
{
	// Fields
	public static readonly Index.<>c <>9; // 0x0
	public static Listeners.Func<DataViewListener, DataViewListener, bool> <>9__22_0; // 0x8
	public static Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool> <>9__85_0; // 0x10

	// Methods

	// RVA: 0x80DE604 Offset: 0x80DA604 VA: 0x80DE604
	private static void .cctor() { }

	// RVA: 0x80DE66C Offset: 0x80DA66C VA: 0x80DE66C
	public void .ctor() { }

	// RVA: 0x80DE674 Offset: 0x80DA674 VA: 0x80DE674
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0x80DE680 Offset: 0x80DA680 VA: 0x80DE680
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Index.<>c__DisplayClass86_0 // TypeDefIndex: 19196
{
	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0x80DDE7C Offset: 0x80D9E7C VA: 0x80DDE7C
	public void .ctor() { }

	// RVA: 0x80DE69C Offset: 0x80DA69C VA: 0x80DE69C
	internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }
}

// Namespace: System.Data
internal sealed class Index // TypeDefIndex: 19197
{
	// Fields
	private readonly DataTable _table; // 0x10
	internal readonly IndexField[] _indexFields; // 0x18
	private readonly Comparison<DataRow> _comparison; // 0x20
	private readonly DataViewRowState _recordStates; // 0x28
	private WeakReference _rowFilter; // 0x30
	private Index.IndexTree _records; // 0x38
	private int _recordCount; // 0x40
	private int _refCount; // 0x44
	private Listeners<DataViewListener> _listeners; // 0x48
	private bool _suspendEvents; // 0x50
	private readonly bool _isSharable; // 0x51
	private readonly bool _hasRemoteAggregate; // 0x52
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x54

	// Properties
	internal bool HasRemoteAggregate { get; }
	internal int ObjectID { get; }
	public DataViewRowState RecordStates { get; }
	public IFilter RowFilter { get; }
	public bool HasDuplicates { get; }
	public int RecordCount { get; }
	public int RefCount { get; }
	private bool DoListChanged { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x80DB4F8 Offset: 0x80D74F8 VA: 0x80DB4F8
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x80DB820 Offset: 0x80D7820 VA: 0x80DB820
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x80DB878 Offset: 0x80D7878 VA: 0x80DB878
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0x80DB508 Offset: 0x80D7508 VA: 0x80DB508
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x80DBD74 Offset: 0x80D7D74 VA: 0x80DBD74
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x80DBE1C Offset: 0x80D7E1C VA: 0x80DBE1C
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x80DBE24 Offset: 0x80D7E24 VA: 0x80DBE24
	internal int get_ObjectID() { }

	// RVA: 0x80DBE2C Offset: 0x80D7E2C VA: 0x80DBE2C
	public DataViewRowState get_RecordStates() { }

	// RVA: 0x80DBE34 Offset: 0x80D7E34 VA: 0x80DBE34
	public IFilter get_RowFilter() { }

	// RVA: 0x80DBEAC Offset: 0x80D7EAC VA: 0x80DBEAC
	public int GetRecord(int recordIndex) { }

	// RVA: 0x80DBF04 Offset: 0x80D7F04 VA: 0x80DBF04
	public bool get_HasDuplicates() { }

	// RVA: 0x80DBF54 Offset: 0x80D7F54 VA: 0x80DBF54
	public int get_RecordCount() { }

	// RVA: 0x80DBF5C Offset: 0x80D7F5C VA: 0x80DBF5C
	private bool AcceptRecord(int record) { }

	// RVA: 0x80DBF88 Offset: 0x80D7F88 VA: 0x80DBF88
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0x80DC11C Offset: 0x80D811C VA: 0x80DC11C
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0x80DC174 Offset: 0x80D8174 VA: 0x80DC174
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x80DC1CC Offset: 0x80D81CC VA: 0x80DC1CC
	public int get_RefCount() { }

	// RVA: 0x80DC1D4 Offset: 0x80D81D4 VA: 0x80DC1D4
	public void AddRef() { }

	// RVA: 0x80DC3D0 Offset: 0x80D83D0 VA: 0x80DC3D0
	public int RemoveRef() { }

	// RVA: 0x80DC58C Offset: 0x80D858C VA: 0x80DC58C
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0x80DC9BC Offset: 0x80D89BC VA: 0x80DC9BC
	public bool CheckUnique() { }

	// RVA: 0x80DC9D4 Offset: 0x80D89D4 VA: 0x80DC9D4
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0x80DCB20 Offset: 0x80D8B20 VA: 0x80DCB20
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0x80DCB8C Offset: 0x80D8B8C VA: 0x80DCB8C
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0x80DCCD8 Offset: 0x80D8CD8 VA: 0x80DCCD8
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0x80DCDA8 Offset: 0x80D8DA8 VA: 0x80DCDA8
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0x80DC95C Offset: 0x80D895C VA: 0x80DC95C
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0x80DCDB0 Offset: 0x80D8DB0 VA: 0x80DCDB0
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0x80DD080 Offset: 0x80D9080 VA: 0x80DD080
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0x80DC964 Offset: 0x80D8964 VA: 0x80DC964
	public int GetIndex(int record) { }

	// RVA: 0x80DC824 Offset: 0x80D8824 VA: 0x80DC824
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0x80D34E0 Offset: 0x80CF4E0 VA: 0x80D34E0
	public object[] GetUniqueKeyValues() { }

	// RVA: 0x80DD30C Offset: 0x80D930C VA: 0x80DD30C
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0x80DD520 Offset: 0x80D9520 VA: 0x80DD520
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0x80DD764 Offset: 0x80D9764 VA: 0x80DD764
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0x80DD858 Offset: 0x80D9858 VA: 0x80DD858
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0x80DD980 Offset: 0x80D9980 VA: 0x80DD980
	public Range FindRecords(object key) { }

	// RVA: 0x80D361C Offset: 0x80CF61C VA: 0x80D361C
	public Range FindRecords(object[] key) { }

	// RVA: 0x80DD9A4 Offset: 0x80D99A4 VA: 0x80DD9A4
	internal void FireResetEvent() { }

	// RVA: 0x80DDC8C Offset: 0x80D9C8C VA: 0x80DDC8C
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x80DDCA8 Offset: 0x80D9CA8 VA: 0x80DDCA8
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0x80D3F88 Offset: 0x80CFF88 VA: 0x80D3F88
	public DataRow GetRow(int i) { }

	// RVA: 0x80DDCD0 Offset: 0x80D9CD0 VA: 0x80DDCD0
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0x80D3640 Offset: 0x80CF640 VA: 0x80D3640
	public DataRow[] GetRows(Range range) { }

	// RVA: 0x80DB970 Offset: 0x80D7970 VA: 0x80DB970
	private void InitRecords(IFilter filter) { }

	// RVA: 0x80DDD64 Offset: 0x80D9D64 VA: 0x80DDD64
	public int InsertRecordToIndex(int record) { }

	// RVA: 0x80DC630 Offset: 0x80D8630 VA: 0x80DC630
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0x80DDDB4 Offset: 0x80D9DB4 VA: 0x80DDDB4
	public bool IsKeyInIndex(object key) { }

	// RVA: 0x80D3604 Offset: 0x80CF604 VA: 0x80D3604
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0x80DDDCC Offset: 0x80D9DCC VA: 0x80DDDCC
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0x80DDA8C Offset: 0x80D9A8C VA: 0x80DDA8C
	private bool get_DoListChanged() { }

	// RVA: 0x80DDDE4 Offset: 0x80D9DE4 VA: 0x80DDDE4
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0x80DCFF0 Offset: 0x80D8FF0 VA: 0x80DCFF0
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0x80DDB0C Offset: 0x80D9B0C VA: 0x80DDB0C
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x80DCED4 Offset: 0x80D8ED4 VA: 0x80DCED4
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0x80DDE84 Offset: 0x80D9E84 VA: 0x80DDE84
	public void Reset() { }

	// RVA: 0x80DDF4C Offset: 0x80D9F4C VA: 0x80DDF4C
	public void RecordChanged(int record) { }

	// RVA: 0x80DE030 Offset: 0x80DA030 VA: 0x80DE030
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0x80DE168 Offset: 0x80DA168 VA: 0x80DE168
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x80DE268 Offset: 0x80DA268 VA: 0x80DE268
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x80DE5CC Offset: 0x80DA5CC VA: 0x80DE5CC
	internal DataTable get_Table() { }

	// RVA: 0x80DD0E8 Offset: 0x80D90E8 VA: 0x80DD0E8
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4645B08 Offset: 0x4641B08 VA: 0x4645B08
	|-Index.IndexOfReference<object>
	*/
}

// Namespace: 
internal sealed class Listeners.Action<TElem, T1, T2, T3, T4> : MulticastDelegate // TypeDefIndex: 19198
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6049A0C Offset: 0x6045A0C VA: 0x6049A0C
	|-Listeners.Action<object, object, Int32Enum, object, bool>..ctor
	|
	|-RVA: 0x6049B30 Offset: 0x6045B30 VA: 0x6049B30
	|-Listeners.Action<object, object, object, bool, bool>..ctor
	|
	|-RVA: 0x6049C58 Offset: 0x6045C58 VA: 0x6049C58
	|-Listeners.Action<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6049B18 Offset: 0x6045B18 VA: 0x6049B18
	|-Listeners.Action<object, object, Int32Enum, object, bool>.Invoke
	|
	|-RVA: 0x6049C3C Offset: 0x6045C3C VA: 0x6049C3C
	|-Listeners.Action<object, object, object, bool, bool>.Invoke
	|
	|-RVA: 0x6049D64 Offset: 0x6045D64 VA: 0x6049D64
	|-Listeners.Action<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
internal sealed class Listeners.Func<TElem, T1, TResult> : MulticastDelegate // TypeDefIndex: 19199
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DC7C Offset: 0x4899C7C VA: 0x489DC7C
	|-Listeners.Func<object, object, bool>..ctor
	|
	|-RVA: 0x489DD98 Offset: 0x4899D98 VA: 0x489DD98
	|-Listeners.Func<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DD84 Offset: 0x4899D84 VA: 0x489DD84
	|-Listeners.Func<object, object, bool>.Invoke
	|
	|-RVA: 0x489DEA0 Offset: 0x4899EA0 VA: 0x489DEA0
	|-Listeners.Func<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Data
internal sealed class Listeners<TElem> // TypeDefIndex: 19200
{
	// Fields
	private readonly List<TElem> _listeners; // 0x0
	private readonly Listeners.Func<TElem, TElem, bool> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	// Properties
	internal bool HasListeners { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5003A10 Offset: 0x4FFFA10 VA: 0x5003A10
	|-Listeners<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5003A98 Offset: 0x4FFFA98 VA: 0x5003A98
	|-Listeners<object>.get_HasListeners
	*/

	// RVA: -1 Offset: -1
	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5003ABC Offset: 0x4FFFABC VA: 0x5003ABC
	|-Listeners<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5003B2C Offset: 0x4FFFB2C VA: 0x5003B2C
	|-Listeners<object>.IndexOfReference
	*/

	// RVA: -1 Offset: -1
	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5003B40 Offset: 0x4FFFB40 VA: 0x5003B40
	|-Listeners<object>.Remove
	*/

	// RVA: -1 Offset: -1
	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4223BC0 Offset: 0x421FBC0 VA: 0x4223BC0
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0x4223DB8 Offset: 0x421FDB8 VA: 0x4223DB8
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0x4223FB4 Offset: 0x421FFB4 VA: 0x4223FB4
	|-Listeners<object>.Notify<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5003BEC Offset: 0x4FFFBEC VA: 0x5003BEC
	|-Listeners<object>.RemoveNullListeners
	*/
}

// Namespace: System.Data
[Serializable]
internal sealed class SimpleType : ISerializable // TypeDefIndex: 19201
{
	// Fields
	private string _baseType; // 0x10
	private SimpleType _baseSimpleType; // 0x18
	private XmlQualifiedName _xmlBaseType; // 0x20
	private string _name; // 0x28
	private int _length; // 0x30
	private int _minLength; // 0x34
	private int _maxLength; // 0x38
	private string _pattern; // 0x40
	private string _ns; // 0x48
	private string _maxExclusive; // 0x50
	private string _maxInclusive; // 0x58
	private string _minExclusive; // 0x60
	private string _minInclusive; // 0x68
	internal string _enumeration; // 0x70

	// Properties
	internal string BaseType { get; }
	internal XmlQualifiedName XmlBaseType { get; }
	internal string Name { get; }
	internal string Namespace { get; }
	internal int Length { get; }
	internal int MaxLength { get; set; }
	internal SimpleType BaseSimpleType { get; }
	public string SimpleTypeQualifiedName { get; }

	// Methods

	// RVA: 0x80DE6CC Offset: 0x80DA6CC VA: 0x80DE6CC
	internal void .ctor(string baseType) { }

	// RVA: 0x80DE800 Offset: 0x80DA800 VA: 0x80DE800
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0x80DF34C Offset: 0x80DB34C VA: 0x80DF34C Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x80DE9D8 Offset: 0x80DA9D8 VA: 0x80DE9D8
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0x80DF384 Offset: 0x80DB384 VA: 0x80DF384
	internal bool IsPlainString() { }

	// RVA: 0x80DF4BC Offset: 0x80DB4BC VA: 0x80DF4BC
	internal string get_BaseType() { }

	// RVA: 0x80DF4C4 Offset: 0x80DB4C4 VA: 0x80DF4C4
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x80DF4CC Offset: 0x80DB4CC VA: 0x80DF4CC
	internal string get_Name() { }

	// RVA: 0x80DF4D4 Offset: 0x80DB4D4 VA: 0x80DF4D4
	internal string get_Namespace() { }

	// RVA: 0x80DF4DC Offset: 0x80DB4DC VA: 0x80DF4DC
	internal int get_Length() { }

	// RVA: 0x80DF4E4 Offset: 0x80DB4E4 VA: 0x80DF4E4
	internal int get_MaxLength() { }

	// RVA: 0x80DF4EC Offset: 0x80DB4EC VA: 0x80DF4EC
	internal void set_MaxLength(int value) { }

	// RVA: 0x80DF4F4 Offset: 0x80DB4F4 VA: 0x80DF4F4
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0x80DF4FC Offset: 0x80DB4FC VA: 0x80DF4FC
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0x80DF56C Offset: 0x80DB56C VA: 0x80DF56C
	internal string QualifiedName(string name) { }

	// RVA: 0x80DF5E8 Offset: 0x80DB5E8 VA: 0x80DF5E8
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0x80DFA54 Offset: 0x80DBA54 VA: 0x80DFA54
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0x80DFAE0 Offset: 0x80DBAE0 VA: 0x80DFAE0
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0x80DFB48 Offset: 0x80DBB48 VA: 0x80DFB48
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0x80DFBC8 Offset: 0x80DBBC8 VA: 0x80DFBC8
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0x80DFCB8 Offset: 0x80DBCB8 VA: 0x80DFCB8
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0x80DFDB8 Offset: 0x80DBDB8 VA: 0x80DFDB8
	internal bool CanHaveMaxLength() { }

	// RVA: 0x80DFE1C Offset: 0x80DBE1C VA: 0x80DFE1C
	internal void ConvertToAnnonymousSimpleType() { }
}

// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class UniqueConstraint : Constraint // TypeDefIndex: 19202
{
	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48
	internal string _constraintName; // 0x50
	internal string[] _columnNames; // 0x58

	// Properties
	internal string[] ColumnNames { get; }
	internal Index ConstraintIndex { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }

	// Methods

	// RVA: 0x80DFEC0 Offset: 0x80DBEC0 VA: 0x80DFEC0
	public void .ctor(DataColumn column) { }

	// RVA: 0x80E0074 Offset: 0x80DC074 VA: 0x80E0074
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0x80E00A8 Offset: 0x80DC0A8 VA: 0x80E00A8
	public void .ctor(DataColumn[] columns) { }

	[Browsable(False)]
	// RVA: 0x80E00D8 Offset: 0x80DC0D8 VA: 0x80E00D8
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0x80E0130 Offset: 0x80DC130 VA: 0x80E0130
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x80E0174 Offset: 0x80DC174 VA: 0x80E0174
	internal string[] get_ColumnNames() { }

	// RVA: 0x80E0180 Offset: 0x80DC180 VA: 0x80E0180
	internal Index get_ConstraintIndex() { }

	// RVA: 0x80E0188 Offset: 0x80DC188 VA: 0x80E0188
	internal void ConstraintIndexClear() { }

	// RVA: 0x80E01B8 Offset: 0x80DC1B8 VA: 0x80E01B8
	internal void ConstraintIndexInitialize() { }

	// RVA: 0x80E0210 Offset: 0x80DC210 VA: 0x80E0210 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x80E021C Offset: 0x80DC21C VA: 0x80E021C
	private void NonVirtualCheckState() { }

	// RVA: 0x80E0228 Offset: 0x80DC228 VA: 0x80E0228 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x80E022C Offset: 0x80DC22C VA: 0x80E022C Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x80E0398 Offset: 0x80DC398 VA: 0x80E0398 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x80E03E4 Offset: 0x80DC3E4 VA: 0x80E03E4 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x80E0644 Offset: 0x80DC644 VA: 0x80E0644 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x80E0744 Offset: 0x80DC744 VA: 0x80E0744 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x80E0750 Offset: 0x80DC750 VA: 0x80E0750 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x80E0760 Offset: 0x80DC760 VA: 0x80E0760 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x80E0CB8 Offset: 0x80DCCB8 VA: 0x80E0CB8
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0x80E1174 Offset: 0x80DD174 VA: 0x80E1174 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x80E073C Offset: 0x80DC73C VA: 0x80E073C
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x80E1180 Offset: 0x80DD180 VA: 0x80E1180
	public bool get_IsPrimaryKey() { }

	// RVA: 0x80DFF7C Offset: 0x80DBF7C VA: 0x80DFF7C
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0x80E11C4 Offset: 0x80DD1C4 VA: 0x80E11C4 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0x80E127C Offset: 0x80DD27C VA: 0x80E127C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x80E1284 Offset: 0x80DD284 VA: 0x80E1284 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x80E12D4 Offset: 0x80DD2D4 VA: 0x80E12D4
	internal DataKey get_Key() { }

	// RVA: 0x80E12DC Offset: 0x80DD2DC VA: 0x80E12DC Slot: 8
	public override DataTable get_Table() { }
}

// Namespace: 
private sealed class XDRSchema.NameType : IComparable // TypeDefIndex: 19203
{
	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0x80E48E4 Offset: 0x80E08E4 VA: 0x80E48E4
	public void .ctor(string n, Type t) { }

	// RVA: 0x80E4928 Offset: 0x80E0928 VA: 0x80E4928 Slot: 4
	public int CompareTo(object obj) { }
}

// Namespace: System.Data
internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 19204
{
	// Fields
	internal string _schemaName; // 0x10
	internal string _schemaUri; // 0x18
	internal XmlElement _schemaRoot; // 0x20
	internal DataSet _ds; // 0x28
	private static readonly char[] s_colonArray; // 0x0
	private static XDRSchema.NameType[] s_mapNameTypeXdr; // 0x8
	private static XDRSchema.NameType s_enumerationNameType; // 0x10

	// Methods

	// RVA: 0x80E1310 Offset: 0x80DD310 VA: 0x80E1310
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0x80E13B4 Offset: 0x80DD3B4 VA: 0x80E13B4
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0x80E17E4 Offset: 0x80DD7E4 VA: 0x80E17E4
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0x80E1B2C Offset: 0x80DDB2C VA: 0x80E1B2C
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0x80E1CFC Offset: 0x80DDCFC VA: 0x80E1CFC
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0x80E1624 Offset: 0x80DD624 VA: 0x80E1624
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0x80E276C Offset: 0x80DE76C VA: 0x80E276C
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0x80E2840 Offset: 0x80DE840 VA: 0x80E2840
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0x80E297C Offset: 0x80DE97C VA: 0x80E297C
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0x80E2AFC Offset: 0x80DEAFC VA: 0x80E2AFC
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0x80E1E5C Offset: 0x80DDE5C VA: 0x80E1E5C
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x80E33AC Offset: 0x80DF3AC VA: 0x80E33AC
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x80E36E4 Offset: 0x80DF6E4 VA: 0x80E36E4
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0x80E2098 Offset: 0x80DE098 VA: 0x80E2098
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0x80E1E6C Offset: 0x80DDE6C VA: 0x80E1E6C
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0x80E38D8 Offset: 0x80DF8D8 VA: 0x80E38D8
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class XMLDiffLoader // TypeDefIndex: 19205
{
	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0x80E4998 Offset: 0x80E0998 VA: 0x80E4998
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0x80E51DC Offset: 0x80E11DC VA: 0x80E51DC
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x80E5560 Offset: 0x80E1560 VA: 0x80E5560
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0x80E4B4C Offset: 0x80E0B4C VA: 0x80E4B4C
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0x80E5770 Offset: 0x80E1770 VA: 0x80E5770
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0x80E4E3C Offset: 0x80E0E3C VA: 0x80E4E3C
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0x80E5A54 Offset: 0x80E1A54 VA: 0x80E5A54
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0x80E6E54 Offset: 0x80E2E54 VA: 0x80E6E54
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0x80E5F64 Offset: 0x80E1F64 VA: 0x80E5F64
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0x80E5F04 Offset: 0x80E1F04 VA: 0x80E5F04
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x80E7028 Offset: 0x80E3028 VA: 0x80E7028
	public void .ctor() { }
}

// Namespace: System.Data
internal class XMLSchema // TypeDefIndex: 19206
{
	// Methods

	// RVA: 0x80E7030 Offset: 0x80E3030 VA: 0x80E7030
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0x80E7088 Offset: 0x80E3088 VA: 0x80E7088
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x80E74D4 Offset: 0x80E34D4 VA: 0x80E74D4
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0x80E7548 Offset: 0x80E3548 VA: 0x80E7548
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0x80E7698 Offset: 0x80E3698 VA: 0x80E7698
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0x80E77BC Offset: 0x80E37BC VA: 0x80E77BC
	public void .ctor() { }
}

// Namespace: System.Data
internal sealed class ConstraintTable // TypeDefIndex: 19207
{
	// Fields
	public DataTable table; // 0x10
	public XmlSchemaIdentityConstraint constraint; // 0x18

	// Methods

	// RVA: 0x80E77C4 Offset: 0x80E37C4 VA: 0x80E77C4
	public void .ctor(DataTable t, XmlSchemaIdentityConstraint c) { }
}

// Namespace: 
private sealed class XSDSchema.NameType : IComparable // TypeDefIndex: 19208
{
	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0x80F7E2C Offset: 0x80F3E2C VA: 0x80F7E2C
	public void .ctor(string n, Type t) { }

	// RVA: 0x80F7E70 Offset: 0x80F3E70 VA: 0x80F7E70 Slot: 4
	public int CompareTo(object obj) { }
}

// Namespace: System.Data
internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 19209
{
	// Fields
	private XmlSchemaSet _schemaSet; // 0x10
	private XmlSchemaElement _dsElement; // 0x18
	private DataSet _ds; // 0x20
	private string _schemaName; // 0x28
	private ArrayList _columnExpressions; // 0x30
	private Hashtable _constraintNodes; // 0x38
	private ArrayList _refTables; // 0x40
	private ArrayList _complexTypes; // 0x48
	private XmlSchemaObjectCollection _annotations; // 0x50
	private XmlSchemaObjectCollection _elements; // 0x58
	private Hashtable _attributes; // 0x60
	private Hashtable _elementsTable; // 0x68
	private Hashtable _attributeGroups; // 0x70
	private Hashtable _schemaTypes; // 0x78
	private Hashtable _expressions; // 0x80
	private Dictionary<DataTable, List<DataTable>> _tableDictionary; // 0x88
	private Hashtable _udSimpleTypes; // 0x90
	private Hashtable _existingSimpleTypeMap; // 0x98
	private bool _fromInference; // 0xA0
	private static readonly XSDSchema.NameType[] s_mapNameTypeXsd; // 0x0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x80E7808 Offset: 0x80E3808 VA: 0x80E7808
	internal bool get_FromInference() { }

	// RVA: 0x80E7810 Offset: 0x80E3810 VA: 0x80E7810
	internal void set_FromInference(bool value) { }

	// RVA: 0x80E781C Offset: 0x80E381C VA: 0x80E781C
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0x80E78A4 Offset: 0x80E38A4 VA: 0x80E78A4
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0x80E8370 Offset: 0x80E4370 VA: 0x80E8370
	internal static string QualifiedName(string name) { }

	// RVA: 0x80E83EC Offset: 0x80E43EC VA: 0x80E83EC
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x80E8950 Offset: 0x80E4950 VA: 0x80E8950
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x80E8CE0 Offset: 0x80E4CE0 VA: 0x80E8CE0
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x80E8258 Offset: 0x80E4258 VA: 0x80E8258
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0x80E8EE0 Offset: 0x80E4EE0 VA: 0x80E8EE0
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x80E9124 Offset: 0x80E5124 VA: 0x80E9124
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0x80E92E0 Offset: 0x80E52E0 VA: 0x80E92E0
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0x80E9B38 Offset: 0x80E5B38 VA: 0x80E9B38
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x80E9DB8 Offset: 0x80E5DB8 VA: 0x80E9DB8
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0x80EA7E0 Offset: 0x80E67E0 VA: 0x80EA7E0
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0x80EAB78 Offset: 0x80E6B78 VA: 0x80EAB78
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0x80EB164 Offset: 0x80E7164 VA: 0x80EB164
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0x80EB188 Offset: 0x80E7188 VA: 0x80EB188
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0x80EEB80 Offset: 0x80EAB80 VA: 0x80EEB80
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0x80EA364 Offset: 0x80E6364 VA: 0x80EA364
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0x80EEEA8 Offset: 0x80EAEA8 VA: 0x80EEEA8
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0x80F0590 Offset: 0x80EC590 VA: 0x80F0590
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0x80F1254 Offset: 0x80ED254 VA: 0x80F1254
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0x80F163C Offset: 0x80ED63C VA: 0x80F163C
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0x80EB048 Offset: 0x80E7048 VA: 0x80EB048
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0x80F2D4C Offset: 0x80EED4C VA: 0x80F2D4C
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0x80F2ED0 Offset: 0x80EEED0 VA: 0x80F2ED0
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0x80EAA20 Offset: 0x80E6A20 VA: 0x80EAA20
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0x80ED3F0 Offset: 0x80E93F0 VA: 0x80ED3F0
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0x80F31A4 Offset: 0x80EF1A4 VA: 0x80F31A4
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0x80F3228 Offset: 0x80EF228 VA: 0x80F3228
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0x80F3314 Offset: 0x80EF314 VA: 0x80F3314
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0x80F3BDC Offset: 0x80EFBDC VA: 0x80F3BDC
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0x80F4014 Offset: 0x80F0014 VA: 0x80F4014
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0x80E9208 Offset: 0x80E5208 VA: 0x80E9208
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0x80F4B68 Offset: 0x80F0B68 VA: 0x80F4B68
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0x80F61F0 Offset: 0x80F21F0 VA: 0x80F61F0
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0x80F62CC Offset: 0x80F22CC VA: 0x80F62CC
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0x80F63A0 Offset: 0x80F23A0 VA: 0x80F63A0
	private Type ParseDataType(string dt) { }

	// RVA: 0x80F6508 Offset: 0x80F2508 VA: 0x80F6508
	internal static bool IsXsdType(string name) { }

	// RVA: 0x80ED474 Offset: 0x80E9474 VA: 0x80ED474
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0x80F23B0 Offset: 0x80EE3B0 VA: 0x80F23B0
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x80F1C28 Offset: 0x80EDC28 VA: 0x80F1C28
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x80F088C Offset: 0x80EC88C VA: 0x80F088C
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0x80EF874 Offset: 0x80EB874 VA: 0x80EF874
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0x80ED898 Offset: 0x80E9898 VA: 0x80ED898
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0x80F6578 Offset: 0x80F2578 VA: 0x80F6578
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0x80F4758 Offset: 0x80F0758 VA: 0x80F4758
	private string GetPrefix(string ns) { }

	// RVA: 0x80F678C Offset: 0x80F278C VA: 0x80F678C
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0x80F6060 Offset: 0x80F2060 VA: 0x80F6060
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x80F3AC4 Offset: 0x80EFAC4 VA: 0x80F3AC4
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x80EA574 Offset: 0x80E6574 VA: 0x80EA574
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0x80ED720 Offset: 0x80E9720 VA: 0x80ED720
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x80F6BA4 Offset: 0x80F2BA4 VA: 0x80F6BA4
	public void .ctor() { }

	// RVA: 0x80F6BAC Offset: 0x80F2BAC VA: 0x80F6BAC
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 19210
{
	// Fields
	private List<string> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0x80F7EE0 Offset: 0x80F3EE0 VA: 0x80F7EE0
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0x80F7F80 Offset: 0x80F3F80 VA: 0x80F7F80 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x80F8090 Offset: 0x80F4090 VA: 0x80F8090 Slot: 28
	public override bool MoveToNextAttribute() { }
}

// Namespace: System.Data
internal sealed class XmlDataLoader // TypeDefIndex: 19211
{
	// Fields
	private DataSet _dataSet; // 0x10
	private XmlToDatasetMap _nodeToSchemaMap; // 0x18
	private Hashtable _nodeToRowMap; // 0x20
	private Stack _childRowsStack; // 0x28
	private Hashtable _htableExcludedNS; // 0x30
	private bool _fIsXdr; // 0x38
	internal bool _isDiffgram; // 0x39
	private XmlElement _topMostNode; // 0x40
	private bool _ignoreSchema; // 0x48
	private DataTable _dataTable; // 0x50
	private bool _isTableLevel; // 0x58
	private bool _fromInference; // 0x59
	private XmlReader _dataReader; // 0x60
	private object _XSD_XMLNS_NS; // 0x68
	private object _XDR_SCHEMA; // 0x70
	private object _XDRNS; // 0x78
	private object _SQL_SYNC; // 0x80
	private object _UPDGNS; // 0x88
	private object _XSD_SCHEMA; // 0x90
	private object _XSDNS; // 0x98
	private object _DFFNS; // 0xA0
	private object _MSDNS; // 0xA8
	private object _DIFFID; // 0xB0
	private object _HASCHANGES; // 0xB8
	private object _ROWORDER; // 0xC0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x80F819C Offset: 0x80F419C VA: 0x80F819C
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x80F8248 Offset: 0x80F4248 VA: 0x80F8248
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x80F834C Offset: 0x80F434C VA: 0x80F834C
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x80F8410 Offset: 0x80F4410 VA: 0x80F8410
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x80F852C Offset: 0x80F452C VA: 0x80F852C
	internal bool get_FromInference() { }

	// RVA: 0x80F8534 Offset: 0x80F4534 VA: 0x80F8534
	internal void set_FromInference(bool value) { }

	// RVA: 0x80F8540 Offset: 0x80F4540 VA: 0x80F8540
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x80F8734 Offset: 0x80F4734 VA: 0x80F8734
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x80F88B4 Offset: 0x80F48B4 VA: 0x80F88B4
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x80F8AD8 Offset: 0x80F4AD8 VA: 0x80F8AD8
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x80F8CE0 Offset: 0x80F4CE0 VA: 0x80F8CE0
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x80F869C Offset: 0x80F469C VA: 0x80F869C
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x80F8DAC Offset: 0x80F4DAC VA: 0x80F8DAC
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x80F8828 Offset: 0x80F4828 VA: 0x80F8828
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x80F8E94 Offset: 0x80F4E94 VA: 0x80F8E94
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x80F9158 Offset: 0x80F5158 VA: 0x80F9158
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x80F8A84 Offset: 0x80F4A84 VA: 0x80F8A84
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x80F8D78 Offset: 0x80F4D78 VA: 0x80F8D78
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x80F91E0 Offset: 0x80F51E0 VA: 0x80F91E0
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x80F9634 Offset: 0x80F5634 VA: 0x80F9634
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x80FA2C8 Offset: 0x80F62C8 VA: 0x80FA2C8
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x80FA608 Offset: 0x80F6608 VA: 0x80FA608
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x80FA67C Offset: 0x80F667C VA: 0x80FA67C
	private void InitNameTable() { }

	// RVA: 0x80FA984 Offset: 0x80F6984 VA: 0x80FA984
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x80FAD44 Offset: 0x80F6D44 VA: 0x80FAD44
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x80FB9B4 Offset: 0x80F79B4 VA: 0x80FB9B4
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x80FC810 Offset: 0x80F8810 VA: 0x80FC810
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x80FB794 Offset: 0x80F7794 VA: 0x80FB794
	private bool ProcessXsdSchema() { }
}

// Namespace: System.Data
public enum XmlReadMode // TypeDefIndex: 19212
{
	// Fields
	public int value__; // 0x0
	public const XmlReadMode Auto = 0;
	public const XmlReadMode ReadSchema = 1;
	public const XmlReadMode IgnoreSchema = 2;
	public const XmlReadMode InferSchema = 3;
	public const XmlReadMode DiffGram = 4;
	public const XmlReadMode Fragment = 5;
	public const XmlReadMode InferTypedSchema = 6;
}

// Namespace: 
private sealed class XmlToDatasetMap.XmlNodeIdentety // TypeDefIndex: 19213
{
	// Fields
	public string LocalName; // 0x10
	public string NamespaceURI; // 0x18

	// Methods

	// RVA: 0x80FFCF0 Offset: 0x80FBCF0 VA: 0x80FFCF0
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0x80FFD34 Offset: 0x80FBD34 VA: 0x80FFD34 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x80FFD54 Offset: 0x80FBD54 VA: 0x80FFD54 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class XmlToDatasetMap.XmlNodeIdHashtable : Hashtable // TypeDefIndex: 19214
{
	// Fields
	private XmlToDatasetMap.XmlNodeIdentety _id; // 0x50

	// Properties
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x80FFDF0 Offset: 0x80FBDF0 VA: 0x80FFDF0
	public void .ctor(int capacity) { }

	// RVA: 0x80FFE90 Offset: 0x80FBE90 VA: 0x80FFE90
	public object get_Item(XmlNode node) { }

	// RVA: 0x80FFF20 Offset: 0x80FBF20 VA: 0x80FFF20
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0x80FFFA8 Offset: 0x80FBFA8 VA: 0x80FFFA8
	public object get_Item(DataTable table) { }

	// RVA: 0x8100028 Offset: 0x80FC028 VA: 0x8100028
	public object get_Item(string name) { }
}

// Namespace: 
private sealed class XmlToDatasetMap.TableSchemaInfo // TypeDefIndex: 19215
{
	// Fields
	public DataTable TableSchema; // 0x10
	public XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0x81000B4 Offset: 0x80FC0B4 VA: 0x81000B4
	public void .ctor(DataTable tableSchema) { }
}

// Namespace: System.Data
internal sealed class XmlToDatasetMap // TypeDefIndex: 19216
{
	// Fields
	private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0x80F9510 Offset: 0x80F5510 VA: 0x80F9510
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x80FACDC Offset: 0x80F6CDC VA: 0x80FACDC
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x80F94DC Offset: 0x80F54DC VA: 0x80F94DC
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x80FAD10 Offset: 0x80F6D10 VA: 0x80FAD10
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x80FA650 Offset: 0x80F6650 VA: 0x80FA650
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x80FF18C Offset: 0x80FB18C VA: 0x80FF18C
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x80FF2B4 Offset: 0x80FB2B4 VA: 0x80FF2B4
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x80FF444 Offset: 0x80FB444 VA: 0x80FF444
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x80FF6DC Offset: 0x80FB6DC VA: 0x80FF6DC
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x80FD178 Offset: 0x80F9178 VA: 0x80FD178
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x80FD7A4 Offset: 0x80F97A4 VA: 0x80FD7A4
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x80FE300 Offset: 0x80FA300 VA: 0x80FE300
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x80FE674 Offset: 0x80FA674 VA: 0x80FE674
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x80FF8A4 Offset: 0x80FB8A4 VA: 0x80FF8A4
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x80F8F74 Offset: 0x80F4F74 VA: 0x80F8F74
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x80FC6C8 Offset: 0x80F86C8 VA: 0x80FC6C8
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x80F9544 Offset: 0x80F5544 VA: 0x80F9544
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x80FB6B4 Offset: 0x80F76B4 VA: 0x80FB6B4
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x80FF57C Offset: 0x80FB57C VA: 0x80FF57C
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }
}

// Namespace: System.Data
public enum XmlWriteMode // TypeDefIndex: 19217
{
	// Fields
	public int value__; // 0x0
	public const XmlWriteMode WriteSchema = 0;
	public const XmlWriteMode IgnoreSchema = 1;
	public const XmlWriteMode DiffGram = 2;
}

// Namespace: System.Data
internal enum SchemaFormat // TypeDefIndex: 19218
{
	// Fields
	public int value__; // 0x0
	public const SchemaFormat Public = 1;
	public const SchemaFormat Remoting = 2;
	public const SchemaFormat WebService = 3;
	public const SchemaFormat RemotingSkipSchema = 4;
	public const SchemaFormat WebServiceSkipSchema = 5;
}

// Namespace: System.Data
internal sealed class XmlTreeGen // TypeDefIndex: 19219
{
	// Fields
	private ArrayList _constraintNames; // 0x10
	private Hashtable _namespaces; // 0x18
	private Hashtable _autogenerated; // 0x20
	private Hashtable _prefixes; // 0x28
	private DataSet _ds; // 0x30
	private ArrayList _tables; // 0x38
	private ArrayList _relations; // 0x40
	private XmlDocument _dc; // 0x48
	private XmlElement _sRoot; // 0x50
	private int _prefixCount; // 0x58
	private SchemaFormat _schFormat; // 0x5C
	private string _filePath; // 0x60
	private string _fileName; // 0x68
	private string _fileExt; // 0x70
	private XmlElement _dsElement; // 0x78
	private XmlElement _constraintSeparator; // 0x80
	private Converter<Type, string> _targetConverter; // 0x88

	// Methods

	// RVA: 0x8100158 Offset: 0x80FC158 VA: 0x8100158
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0x8100204 Offset: 0x80FC204 VA: 0x8100204
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0x810020C Offset: 0x80FC20C VA: 0x810020C
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0x8100980 Offset: 0x80FC980 VA: 0x8100980
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x8100B30 Offset: 0x80FCB30 VA: 0x8100B30
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x810145C Offset: 0x80FD45C VA: 0x810145C
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0x8102324 Offset: 0x80FE324 VA: 0x8102324
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0x8102840 Offset: 0x80FE840 VA: 0x8102840
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0x8102938 Offset: 0x80FE938 VA: 0x8102938
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0x8102C1C Offset: 0x80FEC1C VA: 0x8102C1C
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0x8102C44 Offset: 0x80FEC44 VA: 0x8102C44
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0x8102DC8 Offset: 0x80FEDC8 VA: 0x8102DC8
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0x810302C Offset: 0x80FF02C VA: 0x810302C
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0x81030B4 Offset: 0x80FF0B4 VA: 0x81030B4
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0x8103DCC Offset: 0x80FFDCC VA: 0x8103DCC
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0x8103394 Offset: 0x80FF394 VA: 0x8103394
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0x8104518 Offset: 0x8100518 VA: 0x8104518
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x810489C Offset: 0x810089C VA: 0x810489C
	private void CreateRelations(DataTable dt) { }

	// RVA: 0x8104BF4 Offset: 0x8100BF4 VA: 0x8104BF4
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x8104EE0 Offset: 0x8100EE0 VA: 0x8104EE0
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0x8108314 Offset: 0x8104314 VA: 0x8108314
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0x8107670 Offset: 0x8103670 VA: 0x8107670
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0x810B1F8 Offset: 0x81071F8 VA: 0x810B1F8
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0x810B4C0 Offset: 0x81074C0 VA: 0x810B4C0
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0x810B4E0 Offset: 0x81074E0 VA: 0x810B4E0
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0x810B4D4 Offset: 0x81074D4 VA: 0x810B4D4
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0x810B5A0 Offset: 0x81075A0 VA: 0x810B5A0
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0x810B5AC Offset: 0x81075AC VA: 0x810B5AC
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x8107D50 Offset: 0x8103D50 VA: 0x8107D50
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0x810B70C Offset: 0x810770C VA: 0x810B70C
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0x810B800 Offset: 0x8107800 VA: 0x810B800
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0x810BA94 Offset: 0x8107A94 VA: 0x810BA94
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0x810BF18 Offset: 0x8107F18 VA: 0x810BF18
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0x810C524 Offset: 0x8108524 VA: 0x810C524
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0x810C634 Offset: 0x8108634 VA: 0x810C634
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0x810D32C Offset: 0x810932C VA: 0x810D32C
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0x810D39C Offset: 0x810939C VA: 0x810D39C
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0x8107C98 Offset: 0x8103C98 VA: 0x8107C98
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0x810D164 Offset: 0x8109164 VA: 0x810D164
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0x8107C90 Offset: 0x8103C90 VA: 0x8107C90
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0x810D454 Offset: 0x8109454 VA: 0x810D454
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0x8103EC0 Offset: 0x80FFEC0 VA: 0x8103EC0
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0x810D7F8 Offset: 0x81097F8 VA: 0x810D7F8
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0x8104444 Offset: 0x8100444 VA: 0x8104444
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0x8104438 Offset: 0x8100438 VA: 0x8104438
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0x810D8DC Offset: 0x81098DC VA: 0x810D8DC
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0x810DA1C Offset: 0x8109A1C VA: 0x810DA1C
	private bool IsAutoGenerated(object o) { }

	// RVA: 0x81087E0 Offset: 0x81047E0 VA: 0x81087E0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0x8102140 Offset: 0x80FE140 VA: 0x8102140
	private void SetMSDataAttribute(XmlElement root, Type type) { }
}

// Namespace: System.Data
internal sealed class NewDiffgramGen // TypeDefIndex: 19220
{
	// Fields
	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x810DAC8 Offset: 0x8109AC8 VA: 0x810DAC8
	internal void .ctor(DataSet ds) { }

	// RVA: 0x810DE80 Offset: 0x8109E80 VA: 0x810DE80
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x810DFA4 Offset: 0x8109FA4 VA: 0x810DFA4
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0x810DC10 Offset: 0x8109C10 VA: 0x810DC10
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0x810E328 Offset: 0x810A328 VA: 0x810E328
	private bool EmptyData() { }

	// RVA: 0x810E41C Offset: 0x810A41C VA: 0x810E41C
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0x810E424 Offset: 0x810A424 VA: 0x810E424
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0x810F45C Offset: 0x810B45C VA: 0x810F45C
	private void GenerateTable(DataTable table) { }

	// RVA: 0x810F4D8 Offset: 0x810B4D8 VA: 0x810F4D8
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0x810FA18 Offset: 0x810BA18 VA: 0x810FA18
	private void GenerateRow(DataRow row) { }

	// RVA: 0x811008C Offset: 0x810C08C VA: 0x811008C
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0x810DA60 Offset: 0x8109A60 VA: 0x810DA60
	internal static string QualifiedName(string prefix, string name) { }
}

// Namespace: System.Data
internal sealed class XmlDataTreeWriter // TypeDefIndex: 19221
{
	// Fields
	private XmlWriter _xmlw; // 0x10
	private DataSet _ds; // 0x18
	private DataTable _dt; // 0x20
	private ArrayList _dTables; // 0x28
	private DataTable[] _topLevelTables; // 0x30
	private bool _fFromTable; // 0x38
	private bool _isDiffgram; // 0x39
	private Hashtable _rowsOrder; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x810F0F0 Offset: 0x810B0F0 VA: 0x810F0F0
	internal void .ctor(DataSet ds) { }

	// RVA: 0x810E890 Offset: 0x810A890 VA: 0x810E890
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x8110EDC Offset: 0x810CEDC VA: 0x8110EDC
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x8110B58 Offset: 0x810CB58 VA: 0x8110B58
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x810FFC4 Offset: 0x810BFC4 VA: 0x810FFC4
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x810EA28 Offset: 0x810AA28 VA: 0x810EA28
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x8112B14 Offset: 0x810EB14 VA: 0x8112B14
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x81133F4 Offset: 0x810F3F4 VA: 0x81133F4
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x81111C8 Offset: 0x810D1C8 VA: 0x81111C8
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x8110A9C Offset: 0x810CA9C VA: 0x8110A9C
	internal static bool PreserveSpace(object value) { }
}

// Namespace: System.Data
internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 19222
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x810E828 Offset: 0x810A828 VA: 0x810E828
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x811373C Offset: 0x810F73C VA: 0x811373C
	private void .ctor(XmlWriter w) { }

	// RVA: 0x810B42C Offset: 0x810742C VA: 0x810B42C
	internal Stream get_BaseStream() { }

	// RVA: 0x811376C Offset: 0x810F76C VA: 0x811376C Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x811378C Offset: 0x810F78C VA: 0x811378C Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x81137B0 Offset: 0x810F7B0 VA: 0x81137B0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x81137D0 Offset: 0x810F7D0 VA: 0x81137D0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x81137F0 Offset: 0x810F7F0 VA: 0x81137F0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x8113810 Offset: 0x810F810 VA: 0x8113810 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x8113830 Offset: 0x810F830 VA: 0x8113830 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x8113850 Offset: 0x810F850 VA: 0x8113850 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x8113870 Offset: 0x810F870 VA: 0x8113870 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x8113894 Offset: 0x810F894 VA: 0x8113894 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x81138B8 Offset: 0x810F8B8 VA: 0x81138B8 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x81138DC Offset: 0x810F8DC VA: 0x81138DC Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x8113900 Offset: 0x810F900 VA: 0x8113900 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x8113924 Offset: 0x810F924 VA: 0x8113924 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x8113948 Offset: 0x810F948 VA: 0x8113948 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x811396C Offset: 0x810F96C VA: 0x811396C Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x8113990 Offset: 0x810F990 VA: 0x8113990 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x81139B4 Offset: 0x810F9B4 VA: 0x81139B4 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x81139D8 Offset: 0x810F9D8 VA: 0x81139D8 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x81139FC Offset: 0x810F9FC VA: 0x81139FC Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x8113A20 Offset: 0x810FA20 VA: 0x8113A20 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x8113A44 Offset: 0x810FA44 VA: 0x8113A44 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x8113A68 Offset: 0x810FA68 VA: 0x8113A68 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x8113A8C Offset: 0x810FA8C VA: 0x8113A8C Slot: 28
	public override void Close() { }

	// RVA: 0x8113AB0 Offset: 0x810FAB0 VA: 0x8113AB0 Slot: 29
	public override void Flush() { }

	// RVA: 0x8113AD4 Offset: 0x810FAD4 VA: 0x8113AD4 Slot: 30
	public override string LookupPrefix(string ns) { }
}

// Namespace: System.Data
internal sealed class DataTextReader : XmlReader // TypeDefIndex: 19223
{
	// Fields
	private XmlReader _xmlreader; // 0x10

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }

	// Methods

	// RVA: 0x8113AF8 Offset: 0x810FAF8 VA: 0x8113AF8
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x8113B50 Offset: 0x810FB50 VA: 0x8113B50
	private void .ctor(XmlReader input) { }

	// RVA: 0x8113BC4 Offset: 0x810FBC4 VA: 0x8113BC4 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x8113BE4 Offset: 0x810FBE4 VA: 0x8113BE4 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x8113C04 Offset: 0x810FC04 VA: 0x8113C04 Slot: 7
	public override string get_Name() { }

	// RVA: 0x8113C24 Offset: 0x810FC24 VA: 0x8113C24 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x8113C44 Offset: 0x810FC44 VA: 0x8113C44 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x8113C64 Offset: 0x810FC64 VA: 0x8113C64 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x8113C84 Offset: 0x810FC84 VA: 0x8113C84 Slot: 11
	public override string get_Value() { }

	// RVA: 0x8113CA4 Offset: 0x810FCA4 VA: 0x8113CA4 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x8113CC4 Offset: 0x810FCC4 VA: 0x8113CC4 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x8113CE8 Offset: 0x810FCE8 VA: 0x8113CE8 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x8113D0C Offset: 0x810FD0C VA: 0x8113D0C Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x8113D30 Offset: 0x810FD30 VA: 0x8113D30 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x8113D54 Offset: 0x810FD54 VA: 0x8113D54 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x8113D78 Offset: 0x810FD78 VA: 0x8113D78 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x8113D9C Offset: 0x810FD9C VA: 0x8113D9C Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x8113DC0 Offset: 0x810FDC0 VA: 0x8113DC0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x8113DE4 Offset: 0x810FDE4 VA: 0x8113DE4 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x8113E08 Offset: 0x810FE08 VA: 0x8113E08 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x8113E2C Offset: 0x810FE2C VA: 0x8113E2C Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x8113E50 Offset: 0x810FE50 VA: 0x8113E50 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x8113E74 Offset: 0x810FE74 VA: 0x8113E74 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x8113E98 Offset: 0x810FE98 VA: 0x8113E98 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x8113EBC Offset: 0x810FEBC VA: 0x8113EBC Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x8113EE0 Offset: 0x810FEE0 VA: 0x8113EE0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x8113F04 Offset: 0x810FF04 VA: 0x8113F04 Slot: 31
	public override bool Read() { }

	// RVA: 0x8113F28 Offset: 0x810FF28 VA: 0x8113F28 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x8113F4C Offset: 0x810FF4C VA: 0x8113F4C Slot: 33
	public override void Close() { }

	// RVA: 0x8113F70 Offset: 0x810FF70 VA: 0x8113F70 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x8113F94 Offset: 0x810FF94 VA: 0x8113F94 Slot: 35
	public override void Skip() { }

	// RVA: 0x8113FB8 Offset: 0x810FFB8 VA: 0x8113FB8 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x8113FDC Offset: 0x810FFDC VA: 0x8113FDC Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x8114000 Offset: 0x8110000 VA: 0x8114000 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x8114024 Offset: 0x8110024 VA: 0x8114024 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x8114048 Offset: 0x8110048 VA: 0x8114048 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x811406C Offset: 0x811006C VA: 0x811406C Slot: 42
	public override string ReadString() { }
}

// Namespace: System.Data.SqlTypes
internal static class SQLResource // TypeDefIndex: 19224
{
	// Properties
	internal static string NullString { get; }
	internal static string ArithOverflowMessage { get; }
	internal static string DivideByZeroMessage { get; }
	internal static string NullValueMessage { get; }
	internal static string TruncationMessage { get; }
	internal static string DateTimeOverflowMessage { get; }
	internal static string ConcatDiffCollationMessage { get; }
	internal static string CompareDiffCollationMessage { get; }
	internal static string ConversionOverflowMessage { get; }
	internal static string TimeZoneSpecifiedMessage { get; }
	internal static string InvalidPrecScaleMessage { get; }
	internal static string FormatMessage { get; }

	// Methods

	// RVA: 0x8114090 Offset: 0x8110090 VA: 0x8114090
	internal static string get_NullString() { }

	// RVA: 0x81140D0 Offset: 0x81100D0 VA: 0x81140D0
	internal static string get_ArithOverflowMessage() { }

	// RVA: 0x8114110 Offset: 0x8110110 VA: 0x8114110
	internal static string get_DivideByZeroMessage() { }

	// RVA: 0x8114150 Offset: 0x8110150 VA: 0x8114150
	internal static string get_NullValueMessage() { }

	// RVA: 0x8114190 Offset: 0x8110190 VA: 0x8114190
	internal static string get_TruncationMessage() { }

	// RVA: 0x81141D0 Offset: 0x81101D0 VA: 0x81141D0
	internal static string get_DateTimeOverflowMessage() { }

	// RVA: 0x8114210 Offset: 0x8110210 VA: 0x8114210
	internal static string get_ConcatDiffCollationMessage() { }

	// RVA: 0x8114250 Offset: 0x8110250 VA: 0x8114250
	internal static string get_CompareDiffCollationMessage() { }

	// RVA: 0x8114290 Offset: 0x8110290 VA: 0x8114290
	internal static string get_ConversionOverflowMessage() { }

	// RVA: 0x81142D0 Offset: 0x81102D0 VA: 0x81142D0
	internal static string get_TimeZoneSpecifiedMessage() { }

	// RVA: 0x8114310 Offset: 0x8110310 VA: 0x8114310
	internal static string get_InvalidPrecScaleMessage() { }

	// RVA: 0x8114350 Offset: 0x8110350 VA: 0x8114350
	internal static string get_FormatMessage() { }

	// RVA: 0x8114390 Offset: 0x8110390 VA: 0x8114390
	internal static string InvalidOpStreamClosed(string method) { }

	// RVA: 0x81143DC Offset: 0x81103DC VA: 0x81143DC
	internal static string InvalidOpStreamNonWritable(string method) { }

	// RVA: 0x8114428 Offset: 0x8110428 VA: 0x8114428
	internal static string InvalidOpStreamNonReadable(string method) { }

	// RVA: 0x8114474 Offset: 0x8110474 VA: 0x8114474
	internal static string InvalidOpStreamNonSeekable(string method) { }
}

// Namespace: System.Data.SqlTypes
public interface INullable // TypeDefIndex: 19225
{
	// Properties
	public abstract bool IsNull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsNull();
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19226
{
	// Fields
	private byte[] _value; // 0x0
	public static readonly SqlBinary Null; // 0x0

	// Properties
	public bool IsNull { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x81144C0 Offset: 0x81104C0 VA: 0x81144C0
	private void .ctor(bool fNull) { }

	// RVA: 0x81144CC Offset: 0x81104CC VA: 0x81144CC
	public void .ctor(byte[] value) { }

	// RVA: 0x8114558 Offset: 0x8110558 VA: 0x8114558 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x8114568 Offset: 0x8110568 VA: 0x8114568
	public byte[] get_Value() { }

	// RVA: 0x811463C Offset: 0x811063C VA: 0x811463C
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x811465C Offset: 0x811065C VA: 0x811465C Slot: 3
	public override string ToString() { }

	// RVA: 0x8114770 Offset: 0x8110770 VA: 0x8114770
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0x811486C Offset: 0x811086C VA: 0x811486C
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0x8114980 Offset: 0x8110980 VA: 0x8114980
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x8114A80 Offset: 0x8110A80 VA: 0x8114A80
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x8114B80 Offset: 0x8110B80 VA: 0x8114B80 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x8114C84 Offset: 0x8110C84 VA: 0x8114C84
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x8114E24 Offset: 0x8110E24 VA: 0x8114E24 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8114FB0 Offset: 0x8110FB0 VA: 0x8114FB0
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x8115018 Offset: 0x8111018 VA: 0x8115018 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x81150DC Offset: 0x81110DC VA: 0x81150DC Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x81150E4 Offset: 0x81110E4 VA: 0x81150E4 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x8115298 Offset: 0x8111298 VA: 0x8115298 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x81153C4 Offset: 0x81113C4 VA: 0x81153C4
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x8115450 Offset: 0x8111450 VA: 0x8115450
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19227
{
	// Fields
	private byte m_value; // 0x0
	public static readonly SqlBoolean True; // 0x0
	public static readonly SqlBoolean False; // 0x1
	public static readonly SqlBoolean Null; // 0x2
	public static readonly SqlBoolean Zero; // 0x3
	public static readonly SqlBoolean One; // 0x4

	// Properties
	public bool IsNull { get; }
	public bool Value { get; }
	public bool IsTrue { get; }
	public bool IsFalse { get; }
	public byte ByteValue { get; }

	// Methods

	// RVA: 0x811496C Offset: 0x811096C VA: 0x811496C
	public void .ctor(bool value) { }

	// RVA: 0x81154BC Offset: 0x81114BC VA: 0x81154BC
	public void .ctor(int value) { }

	// RVA: 0x8115528 Offset: 0x8111528 VA: 0x8115528
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x8115544 Offset: 0x8111544 VA: 0x8115544 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x8114F58 Offset: 0x8110F58 VA: 0x8114F58
	public bool get_Value() { }

	// RVA: 0x8115554 Offset: 0x8111554 VA: 0x8115554
	public bool get_IsTrue() { }

	// RVA: 0x8115564 Offset: 0x8111564 VA: 0x8115564
	public bool get_IsFalse() { }

	// RVA: 0x8115574 Offset: 0x8111574 VA: 0x8115574
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0x8114DC8 Offset: 0x8110DC8 VA: 0x8114DC8
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0x8115584 Offset: 0x8111584 VA: 0x8115584
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x811563C Offset: 0x811163C VA: 0x811563C
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x81156F4 Offset: 0x81116F4 VA: 0x81156F4
	public byte get_ByteValue() { }

	// RVA: 0x8115788 Offset: 0x8111788 VA: 0x8115788 Slot: 3
	public override string ToString() { }

	// RVA: 0x811586C Offset: 0x811186C VA: 0x811586C
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x811591C Offset: 0x811191C VA: 0x811591C
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x8115988 Offset: 0x8111988 VA: 0x8115988
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x81159F4 Offset: 0x81119F4 VA: 0x81159F4 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x8115AF8 Offset: 0x8111AF8 VA: 0x8115AF8
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x8115BFC Offset: 0x8111BFC VA: 0x8115BFC Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8115D08 Offset: 0x8111D08 VA: 0x8115D08 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8115DC4 Offset: 0x8111DC4 VA: 0x8115DC4 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8115DCC Offset: 0x8111DCC VA: 0x8115DCC Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x8115EF0 Offset: 0x8111EF0 VA: 0x8115EF0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8116008 Offset: 0x8112008 VA: 0x8116008
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x8116094 Offset: 0x8112094 VA: 0x8116094
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19228
{
	// Fields
	private bool m_fNotNull; // 0x0
	private byte m_value; // 0x1
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	// Properties
	public bool IsNull { get; }
	public byte Value { get; }

	// Methods

	// RVA: 0x8116144 Offset: 0x8112144 VA: 0x8116144
	private void .ctor(bool fNull) { }

	// RVA: 0x811614C Offset: 0x811214C VA: 0x811614C
	public void .ctor(byte value) { }

	// RVA: 0x811615C Offset: 0x811215C VA: 0x811615C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x811616C Offset: 0x811216C VA: 0x811616C
	public byte get_Value() { }

	// RVA: 0x81161EC Offset: 0x81121EC VA: 0x81161EC
	public static SqlByte op_Implicit(byte x) { }

	// RVA: 0x81161FC Offset: 0x81121FC VA: 0x81161FC Slot: 3
	public override string ToString() { }

	// RVA: 0x8116270 Offset: 0x8112270 VA: 0x8116270
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0x81163A0 Offset: 0x81123A0 VA: 0x81163A0
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0x81164D0 Offset: 0x81124D0 VA: 0x81164D0
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0x8116604 Offset: 0x8112604 VA: 0x8116604
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0x811670C Offset: 0x811270C VA: 0x811670C
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0x81168BC Offset: 0x81128BC VA: 0x81168BC
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0x8116998 Offset: 0x8112998 VA: 0x8116998
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x8116A74 Offset: 0x8112A74 VA: 0x8116A74
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x8116B50 Offset: 0x8112B50 VA: 0x8116B50
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x8116BBC Offset: 0x8112BBC VA: 0x8116BBC
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x8116C28 Offset: 0x8112C28 VA: 0x8116C28
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x8116D4C Offset: 0x8112D4C VA: 0x8116D4C
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x8116E6C Offset: 0x8112E6C VA: 0x8116E6C Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x8116F70 Offset: 0x8112F70 VA: 0x8116F70
	public int CompareTo(SqlByte value) { }

	// RVA: 0x81170C0 Offset: 0x81130C0 VA: 0x81170C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8117200 Offset: 0x8113200 VA: 0x8117200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8117290 Offset: 0x8113290 VA: 0x8117290 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8117298 Offset: 0x8113298 VA: 0x8117298 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x81173B8 Offset: 0x81133B8 VA: 0x81173B8 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x81174E8 Offset: 0x81134E8 VA: 0x81174E8
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x8117574 Offset: 0x8113574 VA: 0x8117574
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal enum SqlBytesCharsState // TypeDefIndex: 19229
{
	// Fields
	public int value__; // 0x0
	public const SqlBytesCharsState Null = 0;
	public const SqlBytesCharsState Buffer = 1;
	public const SqlBytesCharsState Stream = 3;
}

// Namespace: System.Data.SqlTypes
[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 19230
{
	// Fields
	internal byte[] _rgbBuf; // 0x10
	private long _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private byte[] _rgbWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public byte[] Buffer { get; }
	public long Length { get; }
	public byte[] Value { get; }
	public static SqlBytes Null { get; }

	// Methods

	// RVA: 0x81175EC Offset: 0x81135EC VA: 0x81175EC
	public void .ctor() { }

	// RVA: 0x811764C Offset: 0x811364C VA: 0x811764C
	public void .ctor(byte[] buffer) { }

	// RVA: 0x81176C4 Offset: 0x81136C4 VA: 0x81176C4
	public void .ctor(SqlBinary value) { }

	// RVA: 0x811775C Offset: 0x811375C VA: 0x811775C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x811776C Offset: 0x811376C VA: 0x811776C
	public byte[] get_Buffer() { }

	// RVA: 0x8117914 Offset: 0x8113914 VA: 0x8117914
	public long get_Length() { }

	// RVA: 0x8117980 Offset: 0x8113980 VA: 0x8117980
	public byte[] get_Value() { }

	// RVA: 0x8117620 Offset: 0x8113620 VA: 0x8117620
	public void SetNull() { }

	// RVA: 0x81177A4 Offset: 0x81137A4 VA: 0x81177A4
	private void CopyStreamToBuffer() { }

	// RVA: 0x8117794 Offset: 0x8113794 VA: 0x8117794
	internal bool FStream() { }

	// RVA: 0x8117B84 Offset: 0x8113B84 VA: 0x8117B84
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x8117BE4 Offset: 0x8113BE4 VA: 0x8117BE4 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8117BEC Offset: 0x8113BEC VA: 0x8117BEC Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x8117DB0 Offset: 0x8113DB0 VA: 0x8117DB0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8117EE4 Offset: 0x8113EE4 VA: 0x8117EE4
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x8117F70 Offset: 0x8113F70 VA: 0x8117F70 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x8117FA8 Offset: 0x8113FA8 VA: 0x8117FA8
	public static SqlBytes get_Null() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 19231
{
	// Fields
	internal char[] _rgchBuf; // 0x10
	private long _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private char[] _rgchWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public char[] Buffer { get; }
	public long Length { get; }
	public char[] Value { get; }
	public static SqlChars Null { get; }

	// Methods

	// RVA: 0x8117FFC Offset: 0x8113FFC VA: 0x8117FFC
	public void .ctor() { }

	// RVA: 0x811805C Offset: 0x811405C VA: 0x811805C
	public void .ctor(char[] buffer) { }

	// RVA: 0x81180D4 Offset: 0x81140D4 VA: 0x81180D4
	public void .ctor(SqlString value) { }

	// RVA: 0x811820C Offset: 0x811420C VA: 0x811820C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x811821C Offset: 0x811421C VA: 0x811821C
	public char[] get_Buffer() { }

	// RVA: 0x81183BC Offset: 0x81143BC VA: 0x81183BC
	public long get_Length() { }

	// RVA: 0x8118428 Offset: 0x8114428 VA: 0x8118428
	public char[] get_Value() { }

	// RVA: 0x8118030 Offset: 0x8114030 VA: 0x8118030
	public void SetNull() { }

	// RVA: 0x8118244 Offset: 0x8114244 VA: 0x8118244
	internal bool FStream() { }

	// RVA: 0x8118254 Offset: 0x8114254 VA: 0x8118254
	private void CopyStreamToBuffer() { }

	// RVA: 0x81185FC Offset: 0x81145FC VA: 0x81185FC
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x811865C Offset: 0x811465C VA: 0x811865C Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8118664 Offset: 0x8114664 VA: 0x8118664 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x8118780 Offset: 0x8114780 VA: 0x8118780 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8118880 Offset: 0x8114880 VA: 0x8118880
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x811890C Offset: 0x811490C VA: 0x811890C Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x8118944 Offset: 0x8114944 VA: 0x8118944
	public static SqlChars get_Null() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19232
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_day; // 0x4
	private int m_time; // 0x8
	private static readonly double s_SQLTicksPerMillisecond; // 0x0
	public static readonly int SQLTicksPerSecond; // 0x8
	public static readonly int SQLTicksPerMinute; // 0xC
	public static readonly int SQLTicksPerHour; // 0x10
	private static readonly int s_SQLTicksPerDay; // 0x14
	private static readonly long s_ticksPerSecond; // 0x18
	private static readonly DateTime s_SQLBaseDate; // 0x20
	private static readonly long s_SQLBaseDateTicks; // 0x28
	private static readonly int s_minYear; // 0x30
	private static readonly int s_maxYear; // 0x34
	private static readonly int s_minDay; // 0x38
	private static readonly int s_maxDay; // 0x3C
	private static readonly int s_minTime; // 0x40
	private static readonly int s_maxTime; // 0x44
	private static readonly int s_dayBase; // 0x48
	private static readonly int[] s_daysToMonth365; // 0x50
	private static readonly int[] s_daysToMonth366; // 0x58
	private static readonly DateTime s_minDateTime; // 0x60
	private static readonly DateTime s_maxDateTime; // 0x68
	private static readonly TimeSpan s_minTimeSpan; // 0x70
	private static readonly TimeSpan s_maxTimeSpan; // 0x78
	private static readonly string s_ISO8601_DateTimeFormat; // 0x80
	private static readonly string[] s_dateTimeFormats; // 0x88
	public static readonly SqlDateTime MinValue; // 0x90
	public static readonly SqlDateTime MaxValue; // 0x9C
	public static readonly SqlDateTime Null; // 0xA8

	// Properties
	public bool IsNull { get; }
	public DateTime Value { get; }
	public int DayTicks { get; }
	public int TimeTicks { get; }

	// Methods

	// RVA: 0x8118998 Offset: 0x8114998 VA: 0x8118998
	private void .ctor(bool fNull) { }

	// RVA: 0x81189A4 Offset: 0x81149A4 VA: 0x81189A4
	public void .ctor(DateTime value) { }

	// RVA: 0x8118AF4 Offset: 0x8114AF4 VA: 0x8118AF4
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0x8118C1C Offset: 0x8114C1C VA: 0x8118C1C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x8118C2C Offset: 0x8114C2C VA: 0x8118C2C
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0x8118CD4 Offset: 0x8114CD4 VA: 0x8118CD4
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0x8118D7C Offset: 0x8114D7C VA: 0x8118D7C
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0x8118A10 Offset: 0x8114A10 VA: 0x8118A10
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0x8118F78 Offset: 0x8114F78 VA: 0x8118F78
	public DateTime get_Value() { }

	// RVA: 0x8119010 Offset: 0x8115010 VA: 0x8119010
	public int get_DayTicks() { }

	// RVA: 0x8119058 Offset: 0x8115058 VA: 0x8119058
	public int get_TimeTicks() { }

	// RVA: 0x81190A0 Offset: 0x81150A0 VA: 0x81190A0
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0x81190D0 Offset: 0x81150D0 VA: 0x81190D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x811919C Offset: 0x811519C VA: 0x811919C
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x8119294 Offset: 0x8115294 VA: 0x8119294
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x8119394 Offset: 0x8115394 VA: 0x8119394
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x8119494 Offset: 0x8115494 VA: 0x8119494
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x8119518 Offset: 0x8115518 VA: 0x8119518
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x811959C Offset: 0x811559C VA: 0x811959C Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x81196A8 Offset: 0x81156A8 VA: 0x81196A8
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0x811981C Offset: 0x811581C VA: 0x811981C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8119968 Offset: 0x8115968 VA: 0x8119968 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8119A20 Offset: 0x8115A20 VA: 0x8119A20 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8119A28 Offset: 0x8115A28 VA: 0x8119A28 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x8119C28 Offset: 0x8115C28 VA: 0x8119C28 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8119D84 Offset: 0x8115D84 VA: 0x8119D84
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x8119E10 Offset: 0x8115E10 VA: 0x8119E10
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19233
{
	// Fields
	internal byte _bStatus; // 0x0
	internal byte _bLen; // 0x1
	internal byte _bPrec; // 0x2
	internal byte _bScale; // 0x3
	internal uint _data1; // 0x4
	internal uint _data2; // 0x8
	internal uint _data3; // 0xC
	internal uint _data4; // 0x10
	private static readonly byte s_NUMERIC_MAX_PRECISION; // 0x0
	public static readonly byte MaxPrecision; // 0x1
	public static readonly byte MaxScale; // 0x2
	private static readonly byte s_bNullMask; // 0x3
	private static readonly byte s_bIsNull; // 0x4
	private static readonly byte s_bNotNull; // 0x5
	private static readonly byte s_bReverseNullMask; // 0x6
	private static readonly byte s_bSignMask; // 0x7
	private static readonly byte s_bPositive; // 0x8
	private static readonly byte s_bNegative; // 0x9
	private static readonly byte s_bReverseSignMask; // 0xA
	private static readonly uint s_uiZero; // 0xC
	private static readonly int s_cNumeMax; // 0x10
	private static readonly long s_lInt32Base; // 0x18
	private static readonly ulong s_ulInt32Base; // 0x20
	private static readonly ulong s_ulInt32BaseForMod; // 0x28
	internal static readonly ulong s_llMax; // 0x30
	private static readonly uint s_ulBase10; // 0x38
	private static readonly double s_DUINT_BASE; // 0x40
	private static readonly double s_DUINT_BASE2; // 0x48
	private static readonly double s_DUINT_BASE3; // 0x50
	private static readonly double s_DMAX_NUME; // 0x58
	private static readonly uint s_DBL_DIG; // 0x60
	private static readonly byte s_cNumeDivScaleMin; // 0x64
	private static readonly uint[] s_rgulShiftBase; // 0x68
	private static readonly uint[] s_decimalHelpersLo; // 0x70
	private static readonly uint[] s_decimalHelpersMid; // 0x78
	private static readonly uint[] s_decimalHelpersHi; // 0x80
	private static readonly uint[] s_decimalHelpersHiHi; // 0x88
	private static readonly byte[] s_rgCLenFromPrec; // 0x90
	private static readonly uint s_ulT1; // 0x98
	private static readonly uint s_ulT2; // 0x9C
	private static readonly uint s_ulT3; // 0xA0
	private static readonly uint s_ulT4; // 0xA4
	private static readonly uint s_ulT5; // 0xA8
	private static readonly uint s_ulT6; // 0xAC
	private static readonly uint s_ulT7; // 0xB0
	private static readonly uint s_ulT8; // 0xB4
	private static readonly uint s_ulT9; // 0xB8
	private static readonly ulong s_dwlT10; // 0xC0
	private static readonly ulong s_dwlT11; // 0xC8
	private static readonly ulong s_dwlT12; // 0xD0
	private static readonly ulong s_dwlT13; // 0xD8
	private static readonly ulong s_dwlT14; // 0xE0
	private static readonly ulong s_dwlT15; // 0xE8
	private static readonly ulong s_dwlT16; // 0xF0
	private static readonly ulong s_dwlT17; // 0xF8
	private static readonly ulong s_dwlT18; // 0x100
	private static readonly ulong s_dwlT19; // 0x108
	public static readonly SqlDecimal Null; // 0x110
	public static readonly SqlDecimal MinValue; // 0x124
	public static readonly SqlDecimal MaxValue; // 0x138

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }
	public bool IsPositive { get; }
	public byte Scale { get; }
	public int[] Data { get; }

	// Methods

	// RVA: 0x811A2B4 Offset: 0x81162B4 VA: 0x811A2B4
	private byte CalculatePrecision() { }

	// RVA: 0x811A4D8 Offset: 0x81164D8 VA: 0x811A4D8
	private bool VerifyPrecision(byte precision) { }

	// RVA: 0x811A6F4 Offset: 0x81166F4 VA: 0x811A6F4
	private void .ctor(bool fNull) { }

	// RVA: 0x811A75C Offset: 0x811675C VA: 0x811A75C
	public void .ctor(Decimal value) { }

	// RVA: 0x811A8C0 Offset: 0x81168C0 VA: 0x811A8C0
	public void .ctor(int value) { }

	// RVA: 0x811AACC Offset: 0x8116ACC VA: 0x811AACC
	public void .ctor(long value) { }

	// RVA: 0x811ADDC Offset: 0x8116DDC VA: 0x811ADDC
	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	// RVA: 0x811B0A0 Offset: 0x81170A0 VA: 0x811B0A0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x811B110 Offset: 0x8117110 VA: 0x811B110
	public Decimal get_Value() { }

	// RVA: 0x811B2C4 Offset: 0x81172C4 VA: 0x811B2C4
	public bool get_IsPositive() { }

	// RVA: 0x811B038 Offset: 0x8117038 VA: 0x811B038
	private void SetPositive() { }

	// RVA: 0x811B380 Offset: 0x8117380 VA: 0x811B380
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x811B404 Offset: 0x8117404 VA: 0x811B404
	public byte get_Scale() { }

	// RVA: 0x811B494 Offset: 0x8117494 VA: 0x811B494
	public int[] get_Data() { }

	// RVA: 0x811B58C Offset: 0x811758C VA: 0x811B58C Slot: 3
	public override string ToString() { }

	// RVA: 0x811B968 Offset: 0x8117968 VA: 0x811B968
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x811C1FC Offset: 0x81181FC VA: 0x811C1FC
	public double ToDouble() { }

	// RVA: 0x811B164 Offset: 0x8117164 VA: 0x811B164
	private Decimal ToDecimal() { }

	// RVA: 0x811C344 Offset: 0x8118344 VA: 0x811C344
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0x811C35C Offset: 0x811835C VA: 0x811C35C
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0x811C3C4 Offset: 0x81183C4 VA: 0x811C3C4
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0x811C4DC Offset: 0x81184DC VA: 0x811C4DC
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x811CFB8 Offset: 0x8118FB8 VA: 0x811CFB8
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x811D098 Offset: 0x8119098 VA: 0x811D098
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x811D9D8 Offset: 0x81199D8 VA: 0x811D9D8
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x811E6C4 Offset: 0x811A6C4 VA: 0x811E6C4
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0x811E7A0 Offset: 0x811A7A0 VA: 0x811E7A0
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0x811E8D4 Offset: 0x811A8D4 VA: 0x811E8D4
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0x811EA4C Offset: 0x811AA4C VA: 0x811EA4C
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0x811EB34 Offset: 0x811AB34 VA: 0x811EB34
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0x811E648 Offset: 0x811A648 VA: 0x811E648
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x811B018 Offset: 0x8117018 VA: 0x811B018
	private bool FZero() { }

	// RVA: 0x811CF50 Offset: 0x8118F50 VA: 0x811CF50
	private bool FGt10_38() { }

	// RVA: 0x811ED3C Offset: 0x811AD3C VA: 0x811ED3C
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0x811A994 Offset: 0x8116994 VA: 0x811A994
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0x811AB98 Offset: 0x8116B98 VA: 0x811AB98
	private static byte BGetPrecUI8(ulong dwlVal) { }

	// RVA: 0x811C048 Offset: 0x8118048 VA: 0x811C048
	private void AddULong(uint ulAdd) { }

	// RVA: 0x811BE3C Offset: 0x8117E3C VA: 0x811BE3C
	private void MultByULong(uint uiMultiplier) { }

	// RVA: 0x811EE0C Offset: 0x811AE0C VA: 0x811EE0C
	private uint DivByULong(uint iDivisor) { }

	// RVA: 0x811CAD8 Offset: 0x8118AD8 VA: 0x811CAD8
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x811CDF8 Offset: 0x8118DF8 VA: 0x811CDF8
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0x811EFEC Offset: 0x811AFEC VA: 0x811EFEC
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0x811F050 Offset: 0x811B050 VA: 0x811F050
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0x811F07C Offset: 0x811B07C VA: 0x811F07C
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x811F0D4 Offset: 0x811B0D4 VA: 0x811F0D4
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0x811B888 Offset: 0x8117888 VA: 0x811B888
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x811F1D4 Offset: 0x811B1D4 VA: 0x811F1D4
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0x811F1C8 Offset: 0x811B1C8 VA: 0x811F1C8
	private static uint HI(ulong x) { }

	// RVA: 0x811F1D0 Offset: 0x811B1D0 VA: 0x811F1D0
	private static uint LO(ulong x) { }

	// RVA: 0x811DE0C Offset: 0x8119E0C VA: 0x811DE0C
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x811F1E0 Offset: 0x811B1E0 VA: 0x811F1E0
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0x811AF3C Offset: 0x8116F3C VA: 0x811AF3C
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0x811F44C Offset: 0x811B44C VA: 0x811F44C
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x811F56C Offset: 0x811B56C VA: 0x811F56C
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x811F68C Offset: 0x811B68C VA: 0x811F68C
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x811F7AC Offset: 0x811B7AC VA: 0x811F7AC
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x811F860 Offset: 0x811B860 VA: 0x811F860
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x811F914 Offset: 0x811B914 VA: 0x811F914
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x811FA58 Offset: 0x811BA58 VA: 0x811FA58
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x811FCA0 Offset: 0x811BCA0 VA: 0x811FCA0
	public SqlMoney ToSqlMoney() { }

	// RVA: 0x811B960 Offset: 0x8117960 VA: 0x811B960
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x811EDB4 Offset: 0x811ADB4 VA: 0x811EDB4
	private void StoreFromWorkingArray(uint[] rguiData) { }

	// RVA: 0x811BDC4 Offset: 0x8117DC4 VA: 0x811BDC4
	private void SetToZero() { }

	// RVA: 0x811FDF4 Offset: 0x811BDF4 VA: 0x811FDF4 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x811FF1C Offset: 0x811BF1C VA: 0x811FF1C
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x81200E8 Offset: 0x811C0E8 VA: 0x81200E8 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8120274 Offset: 0x811C274 VA: 0x8120274 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x812037C Offset: 0x811C37C VA: 0x812037C Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8120384 Offset: 0x811C384 VA: 0x8120384 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x81204E8 Offset: 0x811C4E8 VA: 0x81204E8 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8120600 Offset: 0x811C600 VA: 0x8120600
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x812068C Offset: 0x811C68C VA: 0x812068C
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19234
{
	// Fields
	private bool m_fNotNull; // 0x0
	private double m_value; // 0x8
	public static readonly SqlDouble Null; // 0x0
	public static readonly SqlDouble Zero; // 0x10
	public static readonly SqlDouble MinValue; // 0x20
	public static readonly SqlDouble MaxValue; // 0x30

	// Properties
	public bool IsNull { get; }
	public double Value { get; }

	// Methods

	// RVA: 0x8120A28 Offset: 0x811CA28 VA: 0x8120A28
	private void .ctor(bool fNull) { }

	// RVA: 0x8120A34 Offset: 0x811CA34 VA: 0x8120A34
	public void .ctor(double value) { }

	// RVA: 0x8120AA8 Offset: 0x811CAA8 VA: 0x8120AA8 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x8120AB8 Offset: 0x811CAB8 VA: 0x8120AB8
	public double get_Value() { }

	// RVA: 0x8120B00 Offset: 0x811CB00 VA: 0x8120B00
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x8120B24 Offset: 0x811CB24 VA: 0x8120B24 Slot: 3
	public override string ToString() { }

	// RVA: 0x8120B98 Offset: 0x811CB98 VA: 0x8120B98
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0x8120C40 Offset: 0x811CC40 VA: 0x8120C40
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0x8120D6C Offset: 0x811CD6C VA: 0x8120D6C
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0x8120E98 Offset: 0x811CE98 VA: 0x8120E98
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0x8120FC4 Offset: 0x811CFC4 VA: 0x8120FC4
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0x8116C80 Offset: 0x8112C80 VA: 0x8116C80
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0x8121128 Offset: 0x811D128 VA: 0x8121128
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0x81211F4 Offset: 0x811D1F4 VA: 0x81211F4
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0x81212BC Offset: 0x811D2BC VA: 0x81212BC
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0x8121384 Offset: 0x811D384 VA: 0x8121384
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0x81214A4 Offset: 0x811D4A4 VA: 0x81214A4
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0x811F994 Offset: 0x811B994 VA: 0x811F994
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0x81215F8 Offset: 0x811D5F8 VA: 0x81215F8
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0x81216E4 Offset: 0x811D6E4 VA: 0x81216E4
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x81217D0 Offset: 0x811D7D0 VA: 0x81217D0
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x81218BC Offset: 0x811D8BC VA: 0x81218BC
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x8121940 Offset: 0x811D940 VA: 0x8121940
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x81219C4 Offset: 0x811D9C4 VA: 0x81219C4
	public SqlSingle ToSqlSingle() { }

	// RVA: 0x8121AE4 Offset: 0x811DAE4 VA: 0x8121AE4 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x8121BEC Offset: 0x811DBEC VA: 0x8121BEC
	public int CompareTo(SqlDouble value) { }

	// RVA: 0x8121D54 Offset: 0x811DD54 VA: 0x8121D54 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8121E98 Offset: 0x811DE98 VA: 0x8121E98 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8121F2C Offset: 0x811DF2C VA: 0x8121F2C Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8121F34 Offset: 0x811DF34 VA: 0x8121F34 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x8122054 Offset: 0x811E054 VA: 0x8122054 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8122190 Offset: 0x811E190 VA: 0x8122190
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x812221C Offset: 0x811E21C VA: 0x812221C
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19235
{
	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private byte[] m_value; // 0x0
	public static readonly SqlGuid Null; // 0x10

	// Properties
	public bool IsNull { get; }
	public Guid Value { get; }

	// Methods

	// RVA: 0x81222AC Offset: 0x811E2AC VA: 0x81222AC
	private void .ctor(bool fNull) { }

	// RVA: 0x81222B8 Offset: 0x811E2B8 VA: 0x81222B8
	public void .ctor(Guid g) { }

	// RVA: 0x81222F0 Offset: 0x811E2F0 VA: 0x81222F0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x8122300 Offset: 0x811E300 VA: 0x8122300
	public Guid get_Value() { }

	// RVA: 0x81223A4 Offset: 0x811E3A4 VA: 0x81223A4
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x81223D8 Offset: 0x811E3D8 VA: 0x81223D8 Slot: 3
	public override string ToString() { }

	// RVA: 0x8122460 Offset: 0x811E460 VA: 0x8122460
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0x8122558 Offset: 0x811E558 VA: 0x8122558
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0x812264C Offset: 0x811E64C VA: 0x812264C
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x8122740 Offset: 0x811E740 VA: 0x8122740
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x8122834 Offset: 0x811E834 VA: 0x8122834 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x8122938 Offset: 0x811E938 VA: 0x8122938
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x8122A84 Offset: 0x811EA84 VA: 0x8122A84 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8122BBC Offset: 0x811EBBC VA: 0x8122BBC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8122C4C Offset: 0x811EC4C VA: 0x8122C4C Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8122C54 Offset: 0x811EC54 VA: 0x8122C54 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x8122D88 Offset: 0x811ED88 VA: 0x8122D88 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8122ED4 Offset: 0x811EED4 VA: 0x8122ED4
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x8122F60 Offset: 0x811EF60 VA: 0x8122F60
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19236
{
	// Fields
	private bool m_fNotNull; // 0x0
	private short m_value; // 0x2
	private static readonly int s_MASKI2; // 0x0
	public static readonly SqlInt16 Null; // 0x4
	public static readonly SqlInt16 Zero; // 0x8
	public static readonly SqlInt16 MinValue; // 0xC
	public static readonly SqlInt16 MaxValue; // 0x10

	// Properties
	public bool IsNull { get; }
	public short Value { get; }

	// Methods

	// RVA: 0x812303C Offset: 0x811F03C VA: 0x812303C
	private void .ctor(bool fNull) { }

	// RVA: 0x8123048 Offset: 0x811F048 VA: 0x8123048
	public void .ctor(short value) { }

	// RVA: 0x811E87C Offset: 0x811A87C VA: 0x811E87C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x811E88C Offset: 0x811A88C VA: 0x811E88C
	public short get_Value() { }

	// RVA: 0x8123058 Offset: 0x811F058 VA: 0x8123058
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x8123068 Offset: 0x811F068 VA: 0x8123068 Slot: 3
	public override string ToString() { }

	// RVA: 0x81230DC Offset: 0x811F0DC VA: 0x81230DC
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0x8123178 Offset: 0x811F178 VA: 0x8123178
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x8123288 Offset: 0x811F288 VA: 0x8123288
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x8123398 Offset: 0x811F398 VA: 0x8123398
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x81234E4 Offset: 0x811F4E4 VA: 0x81234E4
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x8123644 Offset: 0x811F644 VA: 0x8123644
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0x8123714 Offset: 0x811F714 VA: 0x8123714
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0x812382C Offset: 0x811F82C VA: 0x812382C
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x8123904 Offset: 0x811F904 VA: 0x8123904
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x81239DC Offset: 0x811F9DC VA: 0x81239DC
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x8123AB4 Offset: 0x811FAB4 VA: 0x8123AB4
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x8123B20 Offset: 0x811FB20 VA: 0x8123B20
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x8123B8C Offset: 0x811FB8C VA: 0x8123B8C
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x8123BE4 Offset: 0x811FBE4 VA: 0x8123BE4
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x8123D04 Offset: 0x811FD04 VA: 0x8123D04 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x8123E08 Offset: 0x811FE08 VA: 0x8123E08
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x8123F58 Offset: 0x811FF58 VA: 0x8123F58 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8124098 Offset: 0x8120098 VA: 0x8124098 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8124128 Offset: 0x8120128 VA: 0x8124128 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8124130 Offset: 0x8120130 VA: 0x8124130 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x8124250 Offset: 0x8120250 VA: 0x8124250 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8124380 Offset: 0x8120380 VA: 0x8124380
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x812440C Offset: 0x812040C VA: 0x812440C
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19237
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_value; // 0x4
	private static readonly long s_iIntMin; // 0x0
	private static readonly long s_lBitNotIntMax; // 0x8
	public static readonly SqlInt32 Null; // 0x10
	public static readonly SqlInt32 Zero; // 0x18
	public static readonly SqlInt32 MinValue; // 0x20
	public static readonly SqlInt32 MaxValue; // 0x28

	// Properties
	public bool IsNull { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x8124488 Offset: 0x8120488 VA: 0x8124488
	private void .ctor(bool fNull) { }

	// RVA: 0x8124494 Offset: 0x8120494 VA: 0x8124494
	public void .ctor(int value) { }

	// RVA: 0x811E9B0 Offset: 0x811A9B0 VA: 0x811E9B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x811E9C0 Offset: 0x811A9C0 VA: 0x811E9C0
	public int get_Value() { }

	// RVA: 0x81244A4 Offset: 0x81204A4 VA: 0x81244A4
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x81244B4 Offset: 0x81204B4 VA: 0x81244B4 Slot: 3
	public override string ToString() { }

	// RVA: 0x8124528 Offset: 0x8120528 VA: 0x8124528
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0x81245C4 Offset: 0x81205C4 VA: 0x81245C4
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x8124708 Offset: 0x8120708 VA: 0x8124708
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x8124840 Offset: 0x8120840 VA: 0x8124840
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x812498C Offset: 0x812098C VA: 0x812498C
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x8124AF8 Offset: 0x8120AF8 VA: 0x8124AF8
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0x8124BC8 Offset: 0x8120BC8 VA: 0x8124BC8
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0x8124C98 Offset: 0x8120C98 VA: 0x8124C98
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0x81246FC Offset: 0x81206FC VA: 0x81246FC
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0x8124DB0 Offset: 0x8120DB0 VA: 0x8124DB0
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x8124E8C Offset: 0x8120E8C VA: 0x8124E8C
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x8124F68 Offset: 0x8120F68 VA: 0x8124F68
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x8125044 Offset: 0x8121044 VA: 0x8125044
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x81250B0 Offset: 0x81210B0 VA: 0x81250B0
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x812511C Offset: 0x812111C VA: 0x812511C
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x8125174 Offset: 0x8121174 VA: 0x8125174
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x8125294 Offset: 0x8121294 VA: 0x8125294 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x8125398 Offset: 0x8121398 VA: 0x8125398
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x81254E4 Offset: 0x81214E4 VA: 0x81254E4 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8125620 Offset: 0x8121620 VA: 0x8125620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x81256B0 Offset: 0x81216B0 VA: 0x81256B0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x81256B8 Offset: 0x81216B8 VA: 0x81256B8 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x81257D8 Offset: 0x81217D8 VA: 0x81257D8 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8125908 Offset: 0x8121908 VA: 0x8125908
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x8125994 Offset: 0x8121994 VA: 0x8125994
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19238
{
	// Fields
	private bool m_fNotNull; // 0x0
	private long m_value; // 0x8
	private static readonly long s_lLowIntMask; // 0x0
	private static readonly long s_lHighIntMask; // 0x8
	public static readonly SqlInt64 Null; // 0x10
	public static readonly SqlInt64 Zero; // 0x20
	public static readonly SqlInt64 MinValue; // 0x30
	public static readonly SqlInt64 MaxValue; // 0x40

	// Properties
	public bool IsNull { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x8125A10 Offset: 0x8121A10 VA: 0x8125A10
	private void .ctor(bool fNull) { }

	// RVA: 0x8125A1C Offset: 0x8121A1C VA: 0x8125A1C
	public void .ctor(long value) { }

	// RVA: 0x8116864 Offset: 0x8112864 VA: 0x8116864 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x8116874 Offset: 0x8112874 VA: 0x8116874
	public long get_Value() { }

	// RVA: 0x8125A2C Offset: 0x8121A2C VA: 0x8125A2C
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x8125A38 Offset: 0x8121A38 VA: 0x8125A38 Slot: 3
	public override string ToString() { }

	// RVA: 0x8125AAC Offset: 0x8121AAC VA: 0x8125AAC
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0x8125B48 Offset: 0x8121B48 VA: 0x8125B48
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x8125C94 Offset: 0x8121C94 VA: 0x8125C94
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x8125DD0 Offset: 0x8121DD0 VA: 0x8125DD0
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x8125F58 Offset: 0x8121F58 VA: 0x8125F58
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x81260A8 Offset: 0x81220A8 VA: 0x81260A8
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x8116DA4 Offset: 0x8112DA4 VA: 0x8116DA4
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0x8123C3C Offset: 0x811FC3C VA: 0x8123C3C
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0x81251CC Offset: 0x81211CC VA: 0x81251CC
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0x811FAD8 Offset: 0x811BAD8 VA: 0x811FAD8
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0x8125C84 Offset: 0x8121C84 VA: 0x8125C84
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0x81261FC Offset: 0x81221FC VA: 0x81261FC
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x81262E0 Offset: 0x81222E0 VA: 0x81262E0
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x81263C4 Offset: 0x81223C4 VA: 0x81263C4
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x81264A8 Offset: 0x81224A8 VA: 0x81264A8
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x812652C Offset: 0x812252C VA: 0x812652C
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x81265B0 Offset: 0x81225B0 VA: 0x81265B0
	public SqlByte ToSqlByte() { }

	// RVA: 0x8126614 Offset: 0x8122614 VA: 0x8126614
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x8126670 Offset: 0x8122670 VA: 0x8126670
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0x81266D4 Offset: 0x81226D4 VA: 0x81266D4
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0x8126730 Offset: 0x8122730 VA: 0x8126730
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x81267B8 Offset: 0x81227B8 VA: 0x81267B8 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x81268C0 Offset: 0x81228C0 VA: 0x81268C0
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0x8126A28 Offset: 0x8122A28 VA: 0x8126A28 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8126B6C Offset: 0x8122B6C VA: 0x8126B6C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8126BFC Offset: 0x8122BFC VA: 0x8126BFC Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8126C04 Offset: 0x8122C04 VA: 0x8126C04 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x8126D24 Offset: 0x8122D24 VA: 0x8126D24 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x8126E54 Offset: 0x8122E54 VA: 0x8126E54
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x8126EE0 Offset: 0x8122EE0 VA: 0x8126EE0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19239
{
	// Fields
	private bool _fNotNull; // 0x0
	private long _value; // 0x8
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly long s_lTickBase; // 0x8
	private static readonly double s_dTickBase; // 0x10
	private static readonly long s_minLong; // 0x18
	private static readonly long s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }

	// Methods

	// RVA: 0x8126F78 Offset: 0x8122F78 VA: 0x8126F78
	private void .ctor(bool fNull) { }

	// RVA: 0x8126F84 Offset: 0x8122F84 VA: 0x8126F84
	internal void .ctor(long value, int ignored) { }

	// RVA: 0x8126F94 Offset: 0x8122F94 VA: 0x8126F94
	public void .ctor(int value) { }

	// RVA: 0x8127010 Offset: 0x8123010 VA: 0x8127010
	public void .ctor(long value) { }

	// RVA: 0x812710C Offset: 0x812310C VA: 0x812710C
	public void .ctor(Decimal value) { }

	// RVA: 0x811EC28 Offset: 0x811AC28 VA: 0x811EC28 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x8127268 Offset: 0x8123268 VA: 0x8127268
	public Decimal get_Value() { }

	// RVA: 0x811EC38 Offset: 0x811AC38 VA: 0x811EC38
	public Decimal ToDecimal() { }

	// RVA: 0x8121568 Offset: 0x811D568 VA: 0x8121568
	public double ToDouble() { }

	// RVA: 0x81272F4 Offset: 0x81232F4 VA: 0x81272F4
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0x8127320 Offset: 0x8123320 VA: 0x8127320
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x812737C Offset: 0x812337C VA: 0x812737C Slot: 3
	public override string ToString() { }

	// RVA: 0x812747C Offset: 0x812347C VA: 0x812747C
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0x8127578 Offset: 0x8123578 VA: 0x8127578
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0x8127728 Offset: 0x8123728 VA: 0x8127728
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0x81278D4 Offset: 0x81238D4 VA: 0x81278D4
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0x8127A10 Offset: 0x8123A10 VA: 0x8127A10
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0x8127B4C Offset: 0x8123B4C VA: 0x8127B4C
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0x8127C14 Offset: 0x8123C14 VA: 0x8127C14
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0x8127CDC Offset: 0x8123CDC VA: 0x8127CDC
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0x8127DA4 Offset: 0x8123DA4 VA: 0x8127DA4
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0x811FD20 Offset: 0x811BD20 VA: 0x811FD20
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0x8127E6C Offset: 0x8123E6C VA: 0x8127E6C
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0x8127F50 Offset: 0x8123F50 VA: 0x8127F50
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x8128034 Offset: 0x8124034 VA: 0x8128034
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x8128118 Offset: 0x8124118 VA: 0x8128118
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x812819C Offset: 0x812419C VA: 0x812819C
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x8128220 Offset: 0x8124220 VA: 0x8128220
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x812827C Offset: 0x812427C VA: 0x812827C
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x8128304 Offset: 0x8124304 VA: 0x8128304 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x812840C Offset: 0x812440C VA: 0x812840C
	public int CompareTo(SqlMoney value) { }

	// RVA: 0x8128574 Offset: 0x8124574 VA: 0x8128574 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x81286B8 Offset: 0x81246B8 VA: 0x81286B8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8128728 Offset: 0x8124728 VA: 0x8128728 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8128730 Offset: 0x8124730 VA: 0x8128730 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x81288A0 Offset: 0x81248A0 VA: 0x81288A0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x81289F0 Offset: 0x81249F0 VA: 0x81289F0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x8128A7C Offset: 0x8124A7C VA: 0x8128A7C
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19240
{
	// Fields
	private bool _fNotNull; // 0x0
	private float _value; // 0x4
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	// Properties
	public bool IsNull { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x8128B44 Offset: 0x8124B44 VA: 0x8128B44
	private void .ctor(bool fNull) { }

	// RVA: 0x8128B50 Offset: 0x8124B50 VA: 0x8128B50
	public void .ctor(float value) { }

	// RVA: 0x8128BC4 Offset: 0x8124BC4 VA: 0x8128BC4
	public void .ctor(double value) { }

	// RVA: 0x812144C Offset: 0x811D44C VA: 0x812144C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x812145C Offset: 0x811D45C VA: 0x812145C
	public float get_Value() { }

	// RVA: 0x8128C28 Offset: 0x8124C28 VA: 0x8128C28
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x8128C44 Offset: 0x8124C44 VA: 0x8128C44 Slot: 3
	public override string ToString() { }

	// RVA: 0x8128CB8 Offset: 0x8124CB8 VA: 0x8128CB8
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0x8128D58 Offset: 0x8124D58 VA: 0x8128D58
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0x8128E74 Offset: 0x8124E74 VA: 0x8128E74
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0x8128F90 Offset: 0x8124F90 VA: 0x8128F90
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0x81290AC Offset: 0x81250AC VA: 0x81290AC
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0x8129200 Offset: 0x8125200 VA: 0x8129200
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0x81292CC Offset: 0x81252CC VA: 0x81292CC
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0x8129398 Offset: 0x8125398 VA: 0x8129398
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0x8129460 Offset: 0x8125460 VA: 0x8129460
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0x8129528 Offset: 0x8125528 VA: 0x8129528
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0x81295EC Offset: 0x81255EC VA: 0x81295EC
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0x8121A20 Offset: 0x811DA20 VA: 0x8121A20
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0x81296B0 Offset: 0x81256B0 VA: 0x81296B0
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0x8129794 Offset: 0x8125794 VA: 0x8129794
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x8129878 Offset: 0x8125878 VA: 0x8129878
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x812995C Offset: 0x812595C VA: 0x812995C
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x81299C8 Offset: 0x81259C8 VA: 0x81299C8
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x8129A34 Offset: 0x8125A34 VA: 0x8129A34
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x8129A8C Offset: 0x8125A8C VA: 0x8129A8C Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x8129B90 Offset: 0x8125B90 VA: 0x8129B90
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x8129CDC Offset: 0x8125CDC VA: 0x8129CDC Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x8129E18 Offset: 0x8125E18 VA: 0x8129E18 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8129EA8 Offset: 0x8125EA8 VA: 0x8129EA8 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x8129EB0 Offset: 0x8125EB0 VA: 0x8129EB0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x8129FD0 Offset: 0x8125FD0 VA: 0x8129FD0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x812A10C Offset: 0x812610C VA: 0x812A10C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x812A198 Offset: 0x8126198 VA: 0x812A198
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[Flags]
public enum SqlCompareOptions // TypeDefIndex: 19241
{
	// Fields
	public int value__; // 0x0
	public const SqlCompareOptions None = 0;
	public const SqlCompareOptions IgnoreCase = 1;
	public const SqlCompareOptions IgnoreNonSpace = 2;
	public const SqlCompareOptions IgnoreKanaType = 8;
	public const SqlCompareOptions IgnoreWidth = 16;
	public const SqlCompareOptions BinarySort = 32768;
	public const SqlCompareOptions BinarySort2 = 16384;
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 19242
{
	// Fields
	private string m_value; // 0x0
	private CompareInfo m_cmpInfo; // 0x8
	private int m_lcid; // 0x10
	private SqlCompareOptions m_flag; // 0x14
	private bool m_fNotNull; // 0x18
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	// Properties
	public bool IsNull { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x812A228 Offset: 0x8126228 VA: 0x812A228
	private void .ctor(bool fNull) { }

	// RVA: 0x812A25C Offset: 0x812625C VA: 0x812A25C
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x812A3C0 Offset: 0x81263C0 VA: 0x812A3C0
	public void .ctor(string data) { }

	// RVA: 0x812A47C Offset: 0x812647C VA: 0x812A47C
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x8118170 Offset: 0x8114170 VA: 0x8118170 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x8118180 Offset: 0x8114180 VA: 0x8118180
	public string get_Value() { }

	// RVA: 0x812A55C Offset: 0x812655C VA: 0x812A55C
	private void SetCompareInfo() { }

	// RVA: 0x812A5F8 Offset: 0x81265F8 VA: 0x812A5F8
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x812A60C Offset: 0x812660C VA: 0x812A60C Slot: 3
	public override string ToString() { }

	// RVA: 0x812A678 Offset: 0x8126678 VA: 0x812A678
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0x812A7C0 Offset: 0x81267C0 VA: 0x812A7C0
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0x812ADDC Offset: 0x8126DDC VA: 0x812ADDC
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0x812AF48 Offset: 0x8126F48 VA: 0x812AF48
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0x812A314 Offset: 0x8126314 VA: 0x812A314
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x812AD34 Offset: 0x8126D34 VA: 0x812AD34
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x812AFE0 Offset: 0x8126FE0 VA: 0x812AFE0
	private bool FBinarySort() { }

	// RVA: 0x812A9F4 Offset: 0x81269F4 VA: 0x812A9F4
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0x812ABBC Offset: 0x8126BBC VA: 0x812ABBC
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x812B04C Offset: 0x812704C VA: 0x812B04C Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x812B164 Offset: 0x8127164 VA: 0x812B164
	public int CompareTo(SqlString value) { }

	// RVA: 0x812B264 Offset: 0x8127264 VA: 0x812B264 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x812B420 Offset: 0x8127420 VA: 0x812B420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x812B644 Offset: 0x8127644 VA: 0x812B644 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x812B64C Offset: 0x812764C VA: 0x812B64C Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x812B74C Offset: 0x812774C VA: 0x812B74C Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x812B848 Offset: 0x8127848 VA: 0x812B848
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x812B8D4 Offset: 0x81278D4 VA: 0x812B8D4
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal enum EComparison // TypeDefIndex: 19243
{
	// Fields
	public int value__; // 0x0
	public const EComparison LT = 0;
	public const EComparison LE = 1;
	public const EComparison EQ = 2;
	public const EComparison GE = 3;
	public const EComparison GT = 4;
	public const EComparison NE = 5;
}

// Namespace: System.Data.SqlTypes
[Serializable]
public class SqlTypeException : SystemException // TypeDefIndex: 19244
{
	// Methods

	// RVA: 0x812B9D8 Offset: 0x81279D8 VA: 0x812B9D8
	public void .ctor() { }

	// RVA: 0x8117B5C Offset: 0x8113B5C VA: 0x8117B5C
	public void .ctor(string message) { }

	// RVA: 0x812BA38 Offset: 0x8127A38 VA: 0x812BA38
	public void .ctor(string message, Exception e) { }

	// RVA: 0x812BA5C Offset: 0x8127A5C VA: 0x812BA5C
	protected void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x812BAAC Offset: 0x8127AAC VA: 0x812BAAC
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlNullValueException : SqlTypeException // TypeDefIndex: 19245
{
	// Methods

	// RVA: 0x81161B4 Offset: 0x81121B4 VA: 0x81161B4
	public void .ctor() { }

	// RVA: 0x812BBA8 Offset: 0x8127BA8 VA: 0x812BBA8
	public void .ctor(string message) { }

	// RVA: 0x812BB84 Offset: 0x8127B84 VA: 0x812BB84
	public void .ctor(string message, Exception e) { }

	// RVA: 0x812BBD0 Offset: 0x8127BD0 VA: 0x812BBD0
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x812BC30 Offset: 0x8127C30 VA: 0x812BC30
	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlTruncateException : SqlTypeException // TypeDefIndex: 19246
{
	// Methods

	// RVA: 0x811EFB4 Offset: 0x811AFB4 VA: 0x811EFB4
	public void .ctor() { }

	// RVA: 0x812BD2C Offset: 0x8127D2C VA: 0x812BD2C
	public void .ctor(string message) { }

	// RVA: 0x812BD08 Offset: 0x8127D08 VA: 0x812BD08
	public void .ctor(string message, Exception e) { }

	// RVA: 0x812BD54 Offset: 0x8127D54 VA: 0x812BD54
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x812BDB4 Offset: 0x8127DB4 VA: 0x812BDB4
	private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
internal abstract class SqlStreamChars // TypeDefIndex: 19247
{
	// Properties
	public abstract long Length { get; }
	public abstract long Position { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int Read(char[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long Seek(long offset, SeekOrigin origin);
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 19248
{
	// Fields
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; // 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
	private MethodInfo _createSqlReaderMethodInfo; // 0x10
	private bool _fNotNull; // 0x18
	private Stream _stream; // 0x20
	private bool _firstCreateReader; // 0x28

	// Properties
	private static MethodInfo CreateSqlReaderMethodInfo { get; }
	public bool IsNull { get; }

	// Methods

	// RVA: 0x812BE8C Offset: 0x8127E8C VA: 0x812BE8C
	public void .ctor() { }

	// RVA: 0x812BEEC Offset: 0x8127EEC VA: 0x812BEEC
	public XmlReader CreateReader() { }

	// RVA: 0x812C208 Offset: 0x8128208 VA: 0x812C208
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0x812C3C0 Offset: 0x81283C0 VA: 0x812C3C0
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0x812C0E4 Offset: 0x81280E4 VA: 0x812C0E4
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0x812C054 Offset: 0x8128054 VA: 0x812C054 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x812BEC0 Offset: 0x8127EC0 VA: 0x812BEC0
	private void SetNull() { }

	// RVA: 0x812C4B8 Offset: 0x81284B8 VA: 0x812C4B8 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x812C4C0 Offset: 0x81284C0 VA: 0x812C4C0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x812C6AC Offset: 0x81286AC VA: 0x812C6AC Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x812C7FC Offset: 0x81287FC VA: 0x812C7FC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x812C888 Offset: 0x8128888 VA: 0x812C888
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 19249
{
	// Fields
	private Stream _stream; // 0x28
	private long _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x812C064 Offset: 0x8128064 VA: 0x812C064
	internal void .ctor(Stream stream) { }

	// RVA: 0x812C980 Offset: 0x8128980 VA: 0x812C980 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x812CA28 Offset: 0x8128A28 VA: 0x812CA28 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x812CA60 Offset: 0x8128A60 VA: 0x812CA60 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x812CA98 Offset: 0x8128A98 VA: 0x812CA98 Slot: 11
	public override long get_Length() { }

	// RVA: 0x812CBE8 Offset: 0x8128BE8 VA: 0x812CBE8 Slot: 12
	public override long get_Position() { }

	// RVA: 0x812CC44 Offset: 0x8128C44 VA: 0x812CC44 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x812CD18 Offset: 0x8128D18 VA: 0x812CD18 Slot: 33
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x812CE80 Offset: 0x8128E80 VA: 0x812CE80 Slot: 35
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x812D0B4 Offset: 0x81290B4 VA: 0x812D0B4 Slot: 38
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x812D2E8 Offset: 0x81292E8 VA: 0x812D2E8 Slot: 37
	public override int ReadByte() { }

	// RVA: 0x812D3FC Offset: 0x81293FC VA: 0x812D3FC Slot: 40
	public override void WriteByte(byte value) { }

	// RVA: 0x812D4E0 Offset: 0x81294E0 VA: 0x812D4E0 Slot: 34
	public override void SetLength(long value) { }

	// RVA: 0x812D574 Offset: 0x8129574 VA: 0x812D574 Slot: 22
	public override void Flush() { }

	// RVA: 0x812D590 Offset: 0x8129590 VA: 0x812D590 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x812CB6C Offset: 0x8128B6C VA: 0x812CB6C
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0x812D038 Offset: 0x8129038 VA: 0x812D038
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0x812D26C Offset: 0x812926C VA: 0x812D26C
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0x812CB04 Offset: 0x8128B04 VA: 0x812CB04
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0x812C9B8 Offset: 0x81289B8 VA: 0x812C9B8
	private bool IsStreamClosed() { }
}

// Namespace: 
private enum ObjectStorage.Families // TypeDefIndex: 19250
{
	// Fields
	public int value__; // 0x0
	public const ObjectStorage.Families DATETIME = 0;
	public const ObjectStorage.Families NUMBER = 1;
	public const ObjectStorage.Families STRING = 2;
	public const ObjectStorage.Families BOOLEAN = 3;
	public const ObjectStorage.Families ARRAY = 4;
}

// Namespace: 
private class ObjectStorage.TempAssemblyComparer : IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> // TypeDefIndex: 19251
{
	// Fields
	internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default; // 0x0

	// Methods

	// RVA: 0x8130DD4 Offset: 0x812CDD4 VA: 0x8130DD4
	private void .ctor() { }

	// RVA: 0x8130DDC Offset: 0x812CDDC VA: 0x8130DDC Slot: 4
	public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

	// RVA: 0x8130F20 Offset: 0x812CF20 VA: 0x8130F20 Slot: 5
	public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

	// RVA: 0x8130FA8 Offset: 0x812CFA8 VA: 0x8130FA8
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 19252
{
	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x812D5A4 Offset: 0x81295A4 VA: 0x812D5A4
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x812D74C Offset: 0x812974C VA: 0x812D74C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x812D77C Offset: 0x812977C VA: 0x812D77C Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x812DDCC Offset: 0x8129DCC VA: 0x812DDCC Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x812DFB0 Offset: 0x8129FB0 VA: 0x812DFB0
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x812D930 Offset: 0x8129930 VA: 0x812D930
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x812E27C Offset: 0x812A27C VA: 0x812E27C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x812E2F4 Offset: 0x812A2F4 VA: 0x812E2F4 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x812E188 Offset: 0x812A188 VA: 0x812E188
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x812E330 Offset: 0x812A330 VA: 0x812E330 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x812E368 Offset: 0x812A368 VA: 0x812E368 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x812EC58 Offset: 0x812AC58 VA: 0x812EC58 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x812ED18 Offset: 0x812AD18 VA: 0x812ED18 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x812F2E4 Offset: 0x812B2E4 VA: 0x812F2E4 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x812FFCC Offset: 0x812BFCC VA: 0x812FFCC Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x813062C Offset: 0x812C62C VA: 0x813062C Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x8130790 Offset: 0x812C790 VA: 0x8130790 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x81307D8 Offset: 0x812C7D8 VA: 0x81307D8 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x81309EC Offset: 0x812C9EC VA: 0x81309EC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x8130BD4 Offset: 0x812CBD4 VA: 0x8130BD4
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x812F270 Offset: 0x812B270 VA: 0x812F270
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x812F9D4 Offset: 0x812B9D4 VA: 0x812F9D4
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x8130D00 Offset: 0x812CD00 VA: 0x8130D00
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal static class ADP // TypeDefIndex: 19253
{
	// Fields
	private static readonly Type s_stackOverflowType; // 0x0
	private static readonly Type s_outOfMemoryType; // 0x8
	private static readonly Type s_threadAbortType; // 0x10
	private static readonly Type s_nullReferenceType; // 0x18
	private static readonly Type s_accessViolationType; // 0x20
	private static readonly Type s_securityType; // 0x28
	internal static readonly string StrEmpty; // 0x30
	internal static readonly string[] AzureSqlServerEndpoints; // 0x38
	internal static readonly IntPtr PtrZero; // 0x40
	internal static readonly int PtrSize; // 0x48

	// Methods

	// RVA: 0x8131010 Offset: 0x812D010 VA: 0x8131010
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x81310A8 Offset: 0x812D0A8 VA: 0x81310A8
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x8131114 Offset: 0x812D114 VA: 0x8131114
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x8131180 Offset: 0x812D180 VA: 0x8131180
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x8131210 Offset: 0x812D210 VA: 0x8131210
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x81312A0 Offset: 0x812D2A0 VA: 0x81312A0
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x8131338 Offset: 0x812D338 VA: 0x8131338
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x81313C8 Offset: 0x812D3C8 VA: 0x81313C8
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x8131458 Offset: 0x812D458 VA: 0x8131458
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x8131664 Offset: 0x812D664 VA: 0x8131664
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x8131838 Offset: 0x812D838 VA: 0x8131838
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x813194C Offset: 0x812D94C VA: 0x813194C
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x81319B8 Offset: 0x812D9B8 VA: 0x81319B8
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x8131A68 Offset: 0x812DA68 VA: 0x8131A68
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x8131B18 Offset: 0x812DB18 VA: 0x8131B18
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x8131BC8 Offset: 0x812DBC8 VA: 0x8131BC8
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x8131C8C Offset: 0x812DC8C VA: 0x8131C8C
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 19254
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x8132004 Offset: 0x812E004 VA: 0x8132004
	internal void .ctor(DataColumn column) { }

	// RVA: 0x81321D8 Offset: 0x812E1D8 VA: 0x81321D8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x8132208 Offset: 0x812E208 VA: 0x8132208 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8132390 Offset: 0x812E390 VA: 0x8132390 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x81324E0 Offset: 0x812E4E0 VA: 0x81324E0
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x8132CB4 Offset: 0x812ECB4 VA: 0x8132CB4
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x8133448 Offset: 0x812F448 VA: 0x8133448 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8133504 Offset: 0x812F504 VA: 0x8133504 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x81335A4 Offset: 0x812F5A4 VA: 0x81335A4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8133698 Offset: 0x812F698 VA: 0x8133698 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8133808 Offset: 0x812F808 VA: 0x8133808 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x813395C Offset: 0x812F95C VA: 0x813395C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8133A0C Offset: 0x812FA0C VA: 0x8133A0C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8133AFC Offset: 0x812FAFC VA: 0x8133AFC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8133B44 Offset: 0x812FB44 VA: 0x8133B44 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8133C58 Offset: 0x812FC58 VA: 0x8133C58 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 19255
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x8133D1C Offset: 0x812FD1C VA: 0x8133D1C
	internal void .ctor(DataColumn column) { }

	// RVA: 0x8133E10 Offset: 0x812FE10 VA: 0x8133E10 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81341C0 Offset: 0x81301C0 VA: 0x81341C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x813428C Offset: 0x813028C VA: 0x813428C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x81343A4 Offset: 0x81303A4 VA: 0x81343A4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x81344F8 Offset: 0x81304F8 VA: 0x81344F8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x813454C Offset: 0x813054C VA: 0x813454C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x81345E8 Offset: 0x81305E8 VA: 0x81345E8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8134770 Offset: 0x8130770 VA: 0x8134770 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8134840 Offset: 0x8130840 VA: 0x8134840 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x81348D0 Offset: 0x81308D0 VA: 0x81348D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8134968 Offset: 0x8130968 VA: 0x8134968 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x81349B0 Offset: 0x81309B0 VA: 0x81349B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8134AB0 Offset: 0x8130AB0 VA: 0x8134AB0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class ByteStorage : DataStorage // TypeDefIndex: 19256
{
	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x8134B74 Offset: 0x8130B74 VA: 0x8134B74
	internal void .ctor(DataColumn column) { }

	// RVA: 0x8134C68 Offset: 0x8130C68 VA: 0x8134C68 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x8135430 Offset: 0x8131430 VA: 0x8135430 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x81354A0 Offset: 0x81314A0 VA: 0x81354A0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x81355A4 Offset: 0x81315A4 VA: 0x81355A4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x81356F4 Offset: 0x81316F4 VA: 0x81356F4 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8135748 Offset: 0x8131748 VA: 0x8135748 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x81357E4 Offset: 0x81317E4 VA: 0x81357E4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8135968 Offset: 0x8131968 VA: 0x8135968 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8135A38 Offset: 0x8131A38 VA: 0x8135A38 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8135AC4 Offset: 0x8131AC4 VA: 0x8135AC4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8135B5C Offset: 0x8131B5C VA: 0x8135B5C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8135BA4 Offset: 0x8131BA4 VA: 0x8135BA4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8135CA4 Offset: 0x8131CA4 VA: 0x8135CA4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class CharStorage : DataStorage // TypeDefIndex: 19257
{
	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x8135D68 Offset: 0x8131D68 VA: 0x8135D68
	internal void .ctor(DataColumn column) { }

	// RVA: 0x8135E5C Offset: 0x8131E5C VA: 0x8135E5C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81361E8 Offset: 0x81321E8 VA: 0x81361E8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x81362B0 Offset: 0x81322B0 VA: 0x81362B0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x81363C8 Offset: 0x81323C8 VA: 0x81363C8 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8136518 Offset: 0x8132518 VA: 0x8136518 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x813656C Offset: 0x813256C VA: 0x813656C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8136608 Offset: 0x8132608 VA: 0x8136608 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x81367E8 Offset: 0x81327E8 VA: 0x81367E8 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x81368B8 Offset: 0x81328B8 VA: 0x81368B8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8136944 Offset: 0x8132944 VA: 0x8136944 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x81369DC Offset: 0x81329DC VA: 0x81369DC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8136A24 Offset: 0x8132A24 VA: 0x8136A24 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8136B24 Offset: 0x8132B24 VA: 0x8136B24 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal enum StorageType // TypeDefIndex: 19258
{
	// Fields
	public int value__; // 0x0
	public const StorageType Empty = 0;
	public const StorageType Object = 1;
	public const StorageType DBNull = 2;
	public const StorageType Boolean = 3;
	public const StorageType Char = 4;
	public const StorageType SByte = 5;
	public const StorageType Byte = 6;
	public const StorageType Int16 = 7;
	public const StorageType UInt16 = 8;
	public const StorageType Int32 = 9;
	public const StorageType UInt32 = 10;
	public const StorageType Int64 = 11;
	public const StorageType UInt64 = 12;
	public const StorageType Single = 13;
	public const StorageType Double = 14;
	public const StorageType Decimal = 15;
	public const StorageType DateTime = 16;
	public const StorageType TimeSpan = 17;
	public const StorageType String = 18;
	public const StorageType Guid = 19;
	public const StorageType ByteArray = 20;
	public const StorageType CharArray = 21;
	public const StorageType Type = 22;
	public const StorageType DateTimeOffset = 23;
	public const StorageType BigInteger = 24;
	public const StorageType Uri = 25;
	public const StorageType SqlBinary = 26;
	public const StorageType SqlBoolean = 27;
	public const StorageType SqlByte = 28;
	public const StorageType SqlBytes = 29;
	public const StorageType SqlChars = 30;
	public const StorageType SqlDateTime = 31;
	public const StorageType SqlDecimal = 32;
	public const StorageType SqlDouble = 33;
	public const StorageType SqlGuid = 34;
	public const StorageType SqlInt16 = 35;
	public const StorageType SqlInt32 = 36;
	public const StorageType SqlInt64 = 37;
	public const StorageType SqlMoney = 38;
	public const StorageType SqlSingle = 39;
	public const StorageType SqlString = 40;
}

// Namespace: System.Data.Common
internal abstract class DataStorage // TypeDefIndex: 19259
{
	// Fields
	private static readonly Type[] s_storageClassType; // 0x0
	internal readonly DataColumn _column; // 0x10
	internal readonly DataTable _table; // 0x18
	internal readonly Type _dataType; // 0x20
	internal readonly StorageType _storageTypeCode; // 0x28
	private BitArray _dbNullBits; // 0x30
	private readonly object _defaultValue; // 0x38
	internal readonly object _nullValue; // 0x40
	internal readonly bool _isCloneable; // 0x48
	internal readonly bool _isCustomDefinedType; // 0x49
	internal readonly bool _isStringType; // 0x4A
	internal readonly bool _isValueType; // 0x4B
	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; // 0x8
	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; // 0x10

	// Properties
	internal DataSetDateTime DateTimeMode { get; }
	internal IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x8132144 Offset: 0x812E144 VA: 0x8132144
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x8136D3C Offset: 0x8132D3C VA: 0x8136D3C
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x8136BE8 Offset: 0x8132BE8 VA: 0x8136BE8
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x8136DA8 Offset: 0x8132DA8 VA: 0x8136DA8
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x81334E8 Offset: 0x812F4E8 VA: 0x81334E8
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x81341AC Offset: 0x81301AC VA: 0x81341AC Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x8136DC4 Offset: 0x8132DC4 VA: 0x8136DC4
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x8132320 Offset: 0x812E320 VA: 0x8132320
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x8136E90 Offset: 0x8132E90 VA: 0x8136E90 Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x8133564 Offset: 0x812F564 VA: 0x8133564
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x8133660 Offset: 0x812F660 VA: 0x8133660
	protected object GetBits(int recordNo) { }

	// RVA: 0x8136E98 Offset: 0x8132E98 VA: 0x8136E98 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x81324B8 Offset: 0x812E4B8 VA: 0x81324B8
	protected bool HasValue(int recordNo) { }

	// RVA: 0x8136EA0 Offset: 0x8132EA0 VA: 0x8136EA0 Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x81337E8 Offset: 0x812F7E8 VA: 0x81337E8
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x81338D8 Offset: 0x812F8D8 VA: 0x81338D8 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x8136EBC Offset: 0x8132EBC VA: 0x8136EBC Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x8136EFC Offset: 0x8132EFC VA: 0x8136EFC Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x8136F38 Offset: 0x8132F38 VA: 0x8136F38
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x81385D4 Offset: 0x81345D4 VA: 0x81385D4
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x81386F0 Offset: 0x81346F0 VA: 0x81386F0
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x813876C Offset: 0x813476C VA: 0x813876C
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x8136D48 Offset: 0x8132D48 VA: 0x8136D48
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x81387E4 Offset: 0x81347E4 VA: 0x81387E4
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x81387F0 Offset: 0x81347F0 VA: 0x81387F0
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x8136D6C Offset: 0x8132D6C VA: 0x8136D6C
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x81388EC Offset: 0x81348EC VA: 0x81388EC
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x8138A40 Offset: 0x8134A40 VA: 0x8138A40
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x8138BF8 Offset: 0x8134BF8 VA: 0x8138BF8
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x8138CCC Offset: 0x8134CCC VA: 0x8138CCC
	public static bool IsObjectNull(object value) { }

	// RVA: 0x8138D6C Offset: 0x8134D6C VA: 0x8138D6C
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x8138E20 Offset: 0x8134E20 VA: 0x8138E20
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x8138E30 Offset: 0x8134E30 VA: 0x8138E30
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8138E40 Offset: 0x8134E40 VA: 0x8138E40
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x8138E50 Offset: 0x8134E50 VA: 0x8138E50
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x8138E58 Offset: 0x8134E58 VA: 0x8138E58
	internal static Type GetType(string value) { }

	// RVA: 0x8138F94 Offset: 0x8134F94 VA: 0x8138F94
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x8139008 Offset: 0x8135008 VA: 0x8139008
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 19260
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0x8137DCC Offset: 0x8133DCC VA: 0x8137DCC
	internal void .ctor(DataColumn column) { }

	// RVA: 0x8139F40 Offset: 0x8135F40 VA: 0x8139F40 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x813A428 Offset: 0x8136428 VA: 0x813A428 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x813A5CC Offset: 0x81365CC VA: 0x813A5CC Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x813A74C Offset: 0x813674C VA: 0x813A74C Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x813A7F0 Offset: 0x81367F0 VA: 0x813A7F0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x813A844 Offset: 0x8136844 VA: 0x813A844 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x813A950 Offset: 0x8136950 VA: 0x813A950 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x813AA70 Offset: 0x8136A70 VA: 0x813AA70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x813AB40 Offset: 0x8136B40 VA: 0x813AB40 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x813ABCC Offset: 0x8136BCC VA: 0x813ABCC Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x813AC68 Offset: 0x8136C68 VA: 0x813AC68 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x813ACB0 Offset: 0x8136CB0 VA: 0x813ACB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x813ADB4 Offset: 0x8136DB4 VA: 0x813ADB4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x813AE78 Offset: 0x8136E78 VA: 0x813AE78
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 19261
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x8137CA4 Offset: 0x8133CA4 VA: 0x8137CA4
	internal void .ctor(DataColumn column) { }

	// RVA: 0x813AEFC Offset: 0x8136EFC VA: 0x813AEFC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x813B3C4 Offset: 0x81373C4 VA: 0x813B3C4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x813B53C Offset: 0x813753C VA: 0x813B53C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x813B6A0 Offset: 0x81376A0 VA: 0x813B6A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x813B7F0 Offset: 0x81377F0 VA: 0x813B7F0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x813B844 Offset: 0x8137844 VA: 0x813B844 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x813B93C Offset: 0x813793C VA: 0x813B93C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x813BCB0 Offset: 0x8137CB0 VA: 0x813BCB0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x813BD80 Offset: 0x8137D80 VA: 0x813BD80 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x813BE34 Offset: 0x8137E34 VA: 0x813BE34 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x813BEE8 Offset: 0x8137EE8 VA: 0x813BEE8 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x813BF30 Offset: 0x8137F30 VA: 0x813BF30 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x813C090 Offset: 0x8138090 VA: 0x813C090 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x813C2AC Offset: 0x81382AC VA: 0x813C2AC
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 19262
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x8137B68 Offset: 0x8133B68 VA: 0x8137B68
	internal void .ctor(DataColumn column) { }

	// RVA: 0x813C324 Offset: 0x8138324 VA: 0x813C324 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x813CD40 Offset: 0x8138D40 VA: 0x813CD40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x813CEBC Offset: 0x8138EBC VA: 0x813CEBC Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x813D028 Offset: 0x8139028 VA: 0x813D028 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x813D1A0 Offset: 0x81391A0 VA: 0x813D1A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x813D1F4 Offset: 0x81391F4 VA: 0x813D1F4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x813D2B8 Offset: 0x81392B8 VA: 0x813D2B8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x813D460 Offset: 0x8139460 VA: 0x813D460 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x813D530 Offset: 0x8139530 VA: 0x813D530 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x813D5E4 Offset: 0x81395E4 VA: 0x813D5E4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x813D680 Offset: 0x8139680 VA: 0x813D680 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x813D6C8 Offset: 0x81396C8 VA: 0x813D6C8 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x813D7CC Offset: 0x81397CC VA: 0x813D7CC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 19263
{
	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x8137A74 Offset: 0x8133A74 VA: 0x8137A74
	internal void .ctor(DataColumn column) { }

	// RVA: 0x813D890 Offset: 0x8139890 VA: 0x813D890 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x813DFC8 Offset: 0x8139FC8 VA: 0x813DFC8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x813E048 Offset: 0x813A048 VA: 0x813E048 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x813E150 Offset: 0x813A150 VA: 0x813E150 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x813E29C Offset: 0x813A29C VA: 0x813E29C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x813E2F0 Offset: 0x813A2F0 VA: 0x813E2F0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x813E390 Offset: 0x813A390 VA: 0x813E390 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x813E514 Offset: 0x813A514 VA: 0x813E514 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x813E5E4 Offset: 0x813A5E4 VA: 0x813E5E4 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x813E66C Offset: 0x813A66C VA: 0x813E66C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x813E704 Offset: 0x813A704 VA: 0x813E704 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x813E74C Offset: 0x813A74C VA: 0x813E74C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x813E84C Offset: 0x813A84C VA: 0x813E84C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int16Storage : DataStorage // TypeDefIndex: 19264
{
	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x8137798 Offset: 0x8133798 VA: 0x8137798
	internal void .ctor(DataColumn column) { }

	// RVA: 0x813E910 Offset: 0x813A910 VA: 0x813E910 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x813F158 Offset: 0x813B158 VA: 0x813F158 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x813F1B8 Offset: 0x813B1B8 VA: 0x813F1B8 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x813F2A8 Offset: 0x813B2A8 VA: 0x813F2A8 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x813F3F8 Offset: 0x813B3F8 VA: 0x813F3F8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x813F44C Offset: 0x813B44C VA: 0x813F44C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x813F4E8 Offset: 0x813B4E8 VA: 0x813F4E8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x813F66C Offset: 0x813B66C VA: 0x813F66C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x813F73C Offset: 0x813B73C VA: 0x813F73C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x813F7C8 Offset: 0x813B7C8 VA: 0x813F7C8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x813F860 Offset: 0x813B860 VA: 0x813F860 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x813F8A8 Offset: 0x813B8A8 VA: 0x813F8A8 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x813F9A4 Offset: 0x813B9A4 VA: 0x813F9A4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int32Storage : DataStorage // TypeDefIndex: 19265
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x813788C Offset: 0x813388C VA: 0x813788C
	internal void .ctor(DataColumn column) { }

	// RVA: 0x813FA68 Offset: 0x813BA68 VA: 0x813FA68 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81402A8 Offset: 0x813C2A8 VA: 0x81402A8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8140314 Offset: 0x813C314 VA: 0x8140314 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8140404 Offset: 0x813C404 VA: 0x8140404 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8140554 Offset: 0x813C554 VA: 0x8140554 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x81405A8 Offset: 0x813C5A8 VA: 0x81405A8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8140644 Offset: 0x813C644 VA: 0x8140644 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x81407C8 Offset: 0x813C7C8 VA: 0x81407C8 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8140898 Offset: 0x813C898 VA: 0x8140898 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8140924 Offset: 0x813C924 VA: 0x8140924 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x81409BC Offset: 0x813C9BC VA: 0x81409BC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8140A04 Offset: 0x813CA04 VA: 0x8140A04 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8140B00 Offset: 0x813CB00 VA: 0x8140B00 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int64Storage : DataStorage // TypeDefIndex: 19266
{
	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x8137980 Offset: 0x8133980 VA: 0x8137980
	internal void .ctor(DataColumn column) { }

	// RVA: 0x8140BC4 Offset: 0x813CBC4 VA: 0x8140BC4 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81413D4 Offset: 0x813D3D4 VA: 0x81413D4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8141440 Offset: 0x813D440 VA: 0x8141440 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8141530 Offset: 0x813D530 VA: 0x8141530 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8141680 Offset: 0x813D680 VA: 0x8141680 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x81416D4 Offset: 0x813D6D4 VA: 0x81416D4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8141770 Offset: 0x813D770 VA: 0x8141770 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x81418F4 Offset: 0x813D8F4 VA: 0x81418F4 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x81419C4 Offset: 0x813D9C4 VA: 0x81419C4 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8141A50 Offset: 0x813DA50 VA: 0x8141A50 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8141AE8 Offset: 0x813DAE8 VA: 0x8141AE8 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8141B30 Offset: 0x813DB30 VA: 0x8141B30 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8141C2C Offset: 0x813DC2C VA: 0x8141C2C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SByteStorage : DataStorage // TypeDefIndex: 19267
{
	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x81376A4 Offset: 0x81336A4 VA: 0x81376A4
	public void .ctor(DataColumn column) { }

	// RVA: 0x8141CF0 Offset: 0x813DCF0 VA: 0x8141CF0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81424E0 Offset: 0x813E4E0 VA: 0x81424E0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8142598 Offset: 0x813E598 VA: 0x8142598 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x814269C Offset: 0x813E69C VA: 0x814269C Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x81427EC Offset: 0x813E7EC VA: 0x81427EC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8142840 Offset: 0x813E840 VA: 0x8142840 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x81428F0 Offset: 0x813E8F0 VA: 0x81428F0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8142A74 Offset: 0x813EA74 VA: 0x8142A74 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8142B44 Offset: 0x813EB44 VA: 0x8142B44 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8142BD0 Offset: 0x813EBD0 VA: 0x8142BD0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8142C68 Offset: 0x813EC68 VA: 0x8142C68 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8142CB0 Offset: 0x813ECB0 VA: 0x8142CB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8142DB0 Offset: 0x813EDB0 VA: 0x8142DB0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal static class SqlConvert // TypeDefIndex: 19268
{
	// Methods

	// RVA: 0x8142E74 Offset: 0x813EE74 VA: 0x8142E74
	public static SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0x8143050 Offset: 0x813F050 VA: 0x8143050
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0x81432FC Offset: 0x813F2FC VA: 0x81432FC
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0x81436C8 Offset: 0x813F6C8 VA: 0x81436C8
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0x8143BB8 Offset: 0x813FBB8 VA: 0x8143BB8
	public static SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0x8144300 Offset: 0x8140300 VA: 0x8144300
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0x81449A0 Offset: 0x81409A0 VA: 0x81449A0
	public static SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0x8145068 Offset: 0x8141068 VA: 0x8145068
	public static SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0x814567C Offset: 0x814167C VA: 0x814567C
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0x8145864 Offset: 0x8141864 VA: 0x8145864
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0x8145A2C Offset: 0x8141A2C VA: 0x8145A2C
	public static SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0x8145C08 Offset: 0x8141C08 VA: 0x8145C08
	public static SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0x8145DD8 Offset: 0x8141DD8 VA: 0x8145DD8
	public static SqlString ConvertToSqlString(object value) { }

	// RVA: 0x8145FB0 Offset: 0x8141FB0 VA: 0x8145FB0
	public static SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0x81460F8 Offset: 0x81420F8 VA: 0x81460F8
	public static SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0x8146240 Offset: 0x8142240 VA: 0x8146240
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0x81462A8 Offset: 0x81422A8 VA: 0x81462A8
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x8146484 Offset: 0x8142484 VA: 0x8146484
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x8147A60 Offset: 0x8143A60 VA: 0x8147A60
	public static object ChangeTypeForXML(object value, Type type) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 19269
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x8137EFC Offset: 0x8133EFC VA: 0x8137EFC
	public void .ctor(DataColumn column) { }

	// RVA: 0x8149778 Offset: 0x8145778 VA: 0x8149778 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81499B4 Offset: 0x81459B4 VA: 0x81499B4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8149A54 Offset: 0x8145A54 VA: 0x8149A54 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8149B10 Offset: 0x8145B10 VA: 0x8149B10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8149B84 Offset: 0x8145B84 VA: 0x8149B84 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8149BC8 Offset: 0x8145BC8 VA: 0x8149BC8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8149C48 Offset: 0x8145C48 VA: 0x8149C48 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x8149CC4 Offset: 0x8145CC4 VA: 0x8149CC4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8149D10 Offset: 0x8145D10 VA: 0x8149D10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8149DD0 Offset: 0x8145DD0 VA: 0x8149DD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x814A0B8 Offset: 0x81460B8 VA: 0x814A0B8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x814A35C Offset: 0x814635C VA: 0x814A35C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x814A3A4 Offset: 0x81463A4 VA: 0x814A3A4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x814A4AC Offset: 0x81464AC VA: 0x814A4AC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 19270
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x813803C Offset: 0x813403C VA: 0x813803C
	public void .ctor(DataColumn column) { }

	// RVA: 0x814A548 Offset: 0x8146548 VA: 0x814A548 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x814B390 Offset: 0x8147390 VA: 0x814B390 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x814B430 Offset: 0x8147430 VA: 0x814B430 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x814B4EC Offset: 0x81474EC VA: 0x814B4EC Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x814B560 Offset: 0x8147560 VA: 0x814B560 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x814B59C Offset: 0x814759C VA: 0x814B59C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x814B61C Offset: 0x814761C VA: 0x814B61C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x814B698 Offset: 0x8147698 VA: 0x814B698 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x814B6DC Offset: 0x81476DC VA: 0x814B6DC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x814B79C Offset: 0x814779C VA: 0x814B79C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x814BA84 Offset: 0x8147A84 VA: 0x814BA84 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x814BD28 Offset: 0x8147D28 VA: 0x814BD28 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x814BD70 Offset: 0x8147D70 VA: 0x814BD70 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x814BE70 Offset: 0x8147E70 VA: 0x814BE70 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 19271
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x8138174 Offset: 0x8134174 VA: 0x8138174
	public void .ctor(DataColumn column) { }

	// RVA: 0x814BF0C Offset: 0x8147F0C VA: 0x814BF0C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x814C120 Offset: 0x8148120 VA: 0x814C120 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x814C128 Offset: 0x8148128 VA: 0x814C128 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x814C130 Offset: 0x8148130 VA: 0x814C130 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x814C170 Offset: 0x8148170 VA: 0x814C170 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x814C1A0 Offset: 0x81481A0 VA: 0x814C1A0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x814C1D8 Offset: 0x81481D8 VA: 0x814C1D8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x814C2D0 Offset: 0x81482D0 VA: 0x814C2D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x814C390 Offset: 0x8148390 VA: 0x814C390 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x814C69C Offset: 0x814869C VA: 0x814C69C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x814C940 Offset: 0x8148940 VA: 0x814C940 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x814C988 Offset: 0x8148988 VA: 0x814C988 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x814CA90 Offset: 0x8148A90 VA: 0x814CA90 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 19272
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x8138254 Offset: 0x8134254 VA: 0x8138254
	public void .ctor(DataColumn column) { }

	// RVA: 0x814CB2C Offset: 0x8148B2C VA: 0x814CB2C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x814CD40 Offset: 0x8148D40 VA: 0x814CD40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x814CD48 Offset: 0x8148D48 VA: 0x814CD48 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x814CD50 Offset: 0x8148D50 VA: 0x814CD50 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x814CD90 Offset: 0x8148D90 VA: 0x814CD90 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x814CDC0 Offset: 0x8148DC0 VA: 0x814CDC0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x814CDF8 Offset: 0x8148DF8 VA: 0x814CDF8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x814CEF0 Offset: 0x8148EF0 VA: 0x814CEF0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x814CFB0 Offset: 0x8148FB0 VA: 0x814CFB0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x814D2C8 Offset: 0x81492C8 VA: 0x814D2C8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x814D56C Offset: 0x814956C VA: 0x814D56C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x814D5B4 Offset: 0x81495B4 VA: 0x814D5B4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x814D6BC Offset: 0x81496BC VA: 0x814D6BC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 19273
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x8138334 Offset: 0x8134334 VA: 0x8138334
	public void .ctor(DataColumn column) { }

	// RVA: 0x814D758 Offset: 0x8149758 VA: 0x814D758 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x814DD68 Offset: 0x8149D68 VA: 0x814DD68 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x814DE1C Offset: 0x8149E1C VA: 0x814DE1C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x814DEE0 Offset: 0x8149EE0 VA: 0x814DEE0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x814DF58 Offset: 0x8149F58 VA: 0x814DF58 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x814DFB0 Offset: 0x8149FB0 VA: 0x814DFB0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x814E040 Offset: 0x814A040 VA: 0x814E040 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x814E0C0 Offset: 0x814A0C0 VA: 0x814E0C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x814E110 Offset: 0x814A110 VA: 0x814E110 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x814E1D0 Offset: 0x814A1D0 VA: 0x814E1D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x814E4C4 Offset: 0x814A4C4 VA: 0x814E4C4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x814E768 Offset: 0x814A768 VA: 0x814E768 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x814E7B0 Offset: 0x814A7B0 VA: 0x814E7B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x814E8C8 Offset: 0x814A8C8 VA: 0x814E8C8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 19274
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x8138484 Offset: 0x8134484 VA: 0x8138484
	public void .ctor(DataColumn column) { }

	// RVA: 0x814E964 Offset: 0x814A964 VA: 0x814E964 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x814F8CC Offset: 0x814B8CC VA: 0x814F8CC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x814F99C Offset: 0x814B99C VA: 0x814F99C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x814FA78 Offset: 0x814BA78 VA: 0x814FA78 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x814FAF8 Offset: 0x814BAF8 VA: 0x814FAF8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x814FB60 Offset: 0x814BB60 VA: 0x814FB60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x814FBEC Offset: 0x814BBEC VA: 0x814FBEC Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x814FC6C Offset: 0x814BC6C VA: 0x814FC6C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x814FCDC Offset: 0x814BCDC VA: 0x814FCDC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x814FD9C Offset: 0x814BD9C VA: 0x814FD9C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8150090 Offset: 0x814C090 VA: 0x8150090 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8150334 Offset: 0x814C334 VA: 0x8150334 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x815037C Offset: 0x814C37C VA: 0x815037C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x81504AC Offset: 0x814C4AC VA: 0x81504AC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 19275
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x8150548 Offset: 0x814C548 VA: 0x8150548
	public void .ctor(DataColumn column) { }

	// RVA: 0x8150688 Offset: 0x814C688 VA: 0x8150688 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81513A0 Offset: 0x814D3A0 VA: 0x81513A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8151448 Offset: 0x814D448 VA: 0x8151448 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8151504 Offset: 0x814D504 VA: 0x8151504 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x815157C Offset: 0x814D57C VA: 0x815157C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x81515B8 Offset: 0x814D5B8 VA: 0x81515B8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x815163C Offset: 0x814D63C VA: 0x815163C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x81516B8 Offset: 0x814D6B8 VA: 0x81516B8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8151704 Offset: 0x814D704 VA: 0x8151704 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x81517C4 Offset: 0x814D7C4 VA: 0x81517C4 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8151AAC Offset: 0x814DAAC VA: 0x8151AAC Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8151D4C Offset: 0x814DD4C VA: 0x8151D4C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8151D94 Offset: 0x814DD94 VA: 0x8151D94 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8151E9C Offset: 0x814DE9C VA: 0x8151E9C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 19276
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x8151F38 Offset: 0x814DF38 VA: 0x8151F38
	public void .ctor(DataColumn column) { }

	// RVA: 0x8152078 Offset: 0x814E078 VA: 0x8152078 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81522B4 Offset: 0x814E2B4 VA: 0x81522B4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8152354 Offset: 0x814E354 VA: 0x8152354 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8152410 Offset: 0x814E410 VA: 0x8152410 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8152488 Offset: 0x814E488 VA: 0x8152488 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x81524CC Offset: 0x814E4CC VA: 0x81524CC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x815254C Offset: 0x814E54C VA: 0x815254C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x81525C8 Offset: 0x814E5C8 VA: 0x81525C8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8152618 Offset: 0x814E618 VA: 0x8152618 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x81526D8 Offset: 0x814E6D8 VA: 0x81526D8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x81529C0 Offset: 0x814E9C0 VA: 0x81529C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8152C60 Offset: 0x814EC60 VA: 0x8152C60 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8152CA8 Offset: 0x814ECA8 VA: 0x8152CA8 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8152DB0 Offset: 0x814EDB0 VA: 0x8152DB0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 19277
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x8152E4C Offset: 0x814EE4C VA: 0x8152E4C
	public void .ctor(DataColumn column) { }

	// RVA: 0x8152F84 Offset: 0x814EF84 VA: 0x8152F84 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x8153DDC Offset: 0x814FDDC VA: 0x8153DDC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8153E7C Offset: 0x814FE7C VA: 0x8153E7C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8153F38 Offset: 0x814FF38 VA: 0x8153F38 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8153FB0 Offset: 0x814FFB0 VA: 0x8153FB0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8153FEC Offset: 0x814FFEC VA: 0x8153FEC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x815406C Offset: 0x815006C VA: 0x815406C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x81540E8 Offset: 0x81500E8 VA: 0x81540E8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8154130 Offset: 0x8150130 VA: 0x8154130 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x81541F0 Offset: 0x81501F0 VA: 0x81541F0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x81544D8 Offset: 0x81504D8 VA: 0x81544D8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8154778 Offset: 0x8150778 VA: 0x8154778 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x81547C0 Offset: 0x81507C0 VA: 0x81547C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x81548C0 Offset: 0x81508C0 VA: 0x81548C0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 19278
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x815495C Offset: 0x815095C VA: 0x815495C
	public void .ctor(DataColumn column) { }

	// RVA: 0x8154A9C Offset: 0x8150A9C VA: 0x8154A9C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81558BC Offset: 0x81518BC VA: 0x81558BC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x815595C Offset: 0x815195C VA: 0x815595C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8155A18 Offset: 0x8151A18 VA: 0x8155A18 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8155A90 Offset: 0x8151A90 VA: 0x8155A90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8155ACC Offset: 0x8151ACC VA: 0x8155ACC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8155B4C Offset: 0x8151B4C VA: 0x8155B4C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x8155BC8 Offset: 0x8151BC8 VA: 0x8155BC8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8155C10 Offset: 0x8151C10 VA: 0x8155C10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8155CD0 Offset: 0x8151CD0 VA: 0x8155CD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8155FB8 Offset: 0x8151FB8 VA: 0x8155FB8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8156258 Offset: 0x8152258 VA: 0x8156258 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x81562A0 Offset: 0x81522A0 VA: 0x81562A0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x81563A0 Offset: 0x81523A0 VA: 0x81563A0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 19279
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x815643C Offset: 0x815243C VA: 0x815643C
	public void .ctor(DataColumn column) { }

	// RVA: 0x815657C Offset: 0x815257C VA: 0x815657C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x8157420 Offset: 0x8153420 VA: 0x8157420 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x81574C8 Offset: 0x81534C8 VA: 0x81574C8 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8157584 Offset: 0x8153584 VA: 0x8157584 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x81575FC Offset: 0x81535FC VA: 0x81575FC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8157638 Offset: 0x8153638 VA: 0x8157638 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x81576BC Offset: 0x81536BC VA: 0x81576BC Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x8157738 Offset: 0x8153738 VA: 0x8157738 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8157784 Offset: 0x8153784 VA: 0x8157784 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8157844 Offset: 0x8153844 VA: 0x8157844 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8157B2C Offset: 0x8153B2C VA: 0x8157B2C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8157DCC Offset: 0x8153DCC VA: 0x8157DCC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8157E14 Offset: 0x8153E14 VA: 0x8157E14 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8157F1C Offset: 0x8153F1C VA: 0x8157F1C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 19280
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x8157FB8 Offset: 0x8153FB8 VA: 0x8157FB8
	public void .ctor(DataColumn column) { }

	// RVA: 0x81580F8 Offset: 0x81540F8 VA: 0x81580F8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x8158FFC Offset: 0x8154FFC VA: 0x8158FFC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x81590A4 Offset: 0x81550A4 VA: 0x81590A4 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8159160 Offset: 0x8155160 VA: 0x8159160 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x81591D8 Offset: 0x81551D8 VA: 0x81591D8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8159214 Offset: 0x8155214 VA: 0x8159214 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8159298 Offset: 0x8155298 VA: 0x8159298 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x8159314 Offset: 0x8155314 VA: 0x8159314 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8159360 Offset: 0x8155360 VA: 0x8159360 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8159420 Offset: 0x8155420 VA: 0x8159420 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8159708 Offset: 0x8155708 VA: 0x8159708 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x81599A8 Offset: 0x81559A8 VA: 0x81599A8 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x81599F0 Offset: 0x81559F0 VA: 0x81599F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8159AF8 Offset: 0x8155AF8 VA: 0x8159AF8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 19281
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x8159B94 Offset: 0x8155B94 VA: 0x8159B94
	public void .ctor(DataColumn column) { }

	// RVA: 0x8159CD4 Offset: 0x8155CD4 VA: 0x8159CD4 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x815AAC8 Offset: 0x8156AC8 VA: 0x815AAC8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x815AB68 Offset: 0x8156B68 VA: 0x815AB68 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x815AC24 Offset: 0x8156C24 VA: 0x815AC24 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x815AC9C Offset: 0x8156C9C VA: 0x815AC9C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x815ACD8 Offset: 0x8156CD8 VA: 0x815ACD8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x815AD58 Offset: 0x8156D58 VA: 0x815AD58 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x815ADD4 Offset: 0x8156DD4 VA: 0x815ADD4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x815AE1C Offset: 0x8156E1C VA: 0x815AE1C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x815AEDC Offset: 0x8156EDC VA: 0x815AEDC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x815B1C4 Offset: 0x81571C4 VA: 0x815B1C4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x815B464 Offset: 0x8157464 VA: 0x815B464 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x815B4AC Offset: 0x81574AC VA: 0x815B4AC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x815B5AC Offset: 0x81575AC VA: 0x815B5AC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 19282
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x815B648 Offset: 0x8157648 VA: 0x815B648
	public void .ctor(DataColumn column) { }

	// RVA: 0x815B788 Offset: 0x8157788 VA: 0x815B788 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x815BBA4 Offset: 0x8157BA4 VA: 0x815BBA4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x815BC14 Offset: 0x8157C14 VA: 0x815BC14
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x815BD50 Offset: 0x8157D50 VA: 0x815BD50 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x815BE14 Offset: 0x8157E14 VA: 0x815BE14 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x815BE94 Offset: 0x8157E94 VA: 0x815BE94 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x815BEF4 Offset: 0x8157EF4 VA: 0x815BEF4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x815BF78 Offset: 0x8157F78 VA: 0x815BF78 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x815C044 Offset: 0x8158044 VA: 0x815C044 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x815C0C4 Offset: 0x81580C4 VA: 0x815C0C4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x815C13C Offset: 0x815813C VA: 0x815C13C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x815C1FC Offset: 0x81581FC VA: 0x815C1FC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x815C4E8 Offset: 0x81584E8 VA: 0x815C4E8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x815C788 Offset: 0x8158788 VA: 0x815C788 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x815C7D0 Offset: 0x81587D0 VA: 0x815C7D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x815C8F4 Offset: 0x81588F4 VA: 0x815C8F4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 19283
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x815C990 Offset: 0x8158990 VA: 0x815C990
	public void .ctor(DataColumn column) { }

	// RVA: 0x815CAD0 Offset: 0x8158AD0 VA: 0x815CAD0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x815CF54 Offset: 0x8158F54 VA: 0x815CF54 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x815CFF4 Offset: 0x8158FF4 VA: 0x815CFF4 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x815D0B0 Offset: 0x81590B0 VA: 0x815D0B0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x815D128 Offset: 0x8159128 VA: 0x815D128 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x815D164 Offset: 0x8159164 VA: 0x815D164 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x815D1E4 Offset: 0x81591E4 VA: 0x815D1E4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x815D260 Offset: 0x8159260 VA: 0x815D260 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x815D2A8 Offset: 0x81592A8 VA: 0x815D2A8 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x815D368 Offset: 0x8159368 VA: 0x815D368 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x815D650 Offset: 0x8159650 VA: 0x815D650 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x815D8F0 Offset: 0x81598F0 VA: 0x815D8F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x815D938 Offset: 0x8159938 VA: 0x815D938 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x815DA38 Offset: 0x8159A38 VA: 0x815DA38 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SingleStorage : DataStorage // TypeDefIndex: 19284
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x815DAD4 Offset: 0x8159AD4 VA: 0x815DAD4
	public void .ctor(DataColumn column) { }

	// RVA: 0x815DBCC Offset: 0x8159BCC VA: 0x815DBCC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x815E324 Offset: 0x815A324 VA: 0x815E324 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x815E3A8 Offset: 0x815A3A8 VA: 0x815E3A8 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x815E4B0 Offset: 0x815A4B0 VA: 0x815E4B0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x815E5F4 Offset: 0x815A5F4 VA: 0x815E5F4 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x815E64C Offset: 0x815A64C VA: 0x815E64C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x815E6F0 Offset: 0x815A6F0 VA: 0x815E6F0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x815E868 Offset: 0x815A868 VA: 0x815E868 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x815E93C Offset: 0x815A93C VA: 0x815E93C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x815E9C4 Offset: 0x815A9C4 VA: 0x815E9C4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x815EA5C Offset: 0x815AA5C VA: 0x815EA5C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x815EAA4 Offset: 0x815AAA4 VA: 0x815EAA4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x815EBA4 Offset: 0x815ABA4 VA: 0x815EBA4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SqlUdtStorage.<>c__DisplayClass6_0 // TypeDefIndex: 19285
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x815EF7C Offset: 0x815AF7C VA: 0x815EF7C
	public void .ctor() { }

	// RVA: 0x81603A0 Offset: 0x815C3A0 VA: 0x81603A0
	internal object <GetStaticNullForUdtType>b__0(Type t) { }
}

// Namespace: System.Data.Common
internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 19286
{
	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly ConcurrentDictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x815EC68 Offset: 0x815AC68 VA: 0x815EC68
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x815EDF4 Offset: 0x815ADF4 VA: 0x815EDF4
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x815ECE0 Offset: 0x815ACE0 VA: 0x815ECE0
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x815EF84 Offset: 0x815AF84 VA: 0x815EF84 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x815F088 Offset: 0x815B088 VA: 0x815F088 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x815F0B8 Offset: 0x815B0B8 VA: 0x815F0B8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x815F0F0 Offset: 0x815B0F0 VA: 0x815F0F0 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x815F37C Offset: 0x815B37C VA: 0x815F37C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x815F404 Offset: 0x815B404 VA: 0x815F404 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x815F434 Offset: 0x815B434 VA: 0x815F434 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x815F5A4 Offset: 0x815B5A4 VA: 0x815F5A4 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x815F678 Offset: 0x815B678 VA: 0x815F678 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x815F9C4 Offset: 0x815B9C4 VA: 0x815F9C4 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x815FC60 Offset: 0x815BC60 VA: 0x815FC60 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x815FF8C Offset: 0x815BF8C VA: 0x815FF8C Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x81600E4 Offset: 0x815C0E4 VA: 0x81600E4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x816012C Offset: 0x815C12C VA: 0x816012C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x816026C Offset: 0x815C26C VA: 0x816026C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x8160308 Offset: 0x815C308 VA: 0x8160308
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class StringStorage : DataStorage // TypeDefIndex: 19287
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x81604C8 Offset: 0x815C4C8 VA: 0x81604C8
	public void .ctor(DataColumn column) { }

	// RVA: 0x81605AC Offset: 0x815C5AC VA: 0x81605AC Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x816089C Offset: 0x815C89C VA: 0x816089C Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8160914 Offset: 0x815C914 VA: 0x8160914 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x81609E8 Offset: 0x815C9E8 VA: 0x81609E8 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8160A18 Offset: 0x815CA18 VA: 0x8160A18 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8160A58 Offset: 0x815CA58 VA: 0x8160A58 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x8160A94 Offset: 0x815CA94 VA: 0x8160A94 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x8160AD4 Offset: 0x815CAD4 VA: 0x8160AD4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x8160B0C Offset: 0x815CB0C VA: 0x8160B0C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8160B8C Offset: 0x815CB8C VA: 0x8160B8C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8160C4C Offset: 0x815CC4C VA: 0x8160C4C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8160C54 Offset: 0x815CC54 VA: 0x8160C54 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8160CB4 Offset: 0x815CCB4 VA: 0x8160CB4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8160CFC Offset: 0x815CCFC VA: 0x8160CFC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8160E04 Offset: 0x815CE04 VA: 0x8160E04 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 19288
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x8160EA0 Offset: 0x815CEA0 VA: 0x8160EA0
	public void .ctor(DataColumn column) { }

	// RVA: 0x8160FCC Offset: 0x815CFCC VA: 0x8160FCC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x8161C00 Offset: 0x815DC00 VA: 0x8161C00 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8161D7C Offset: 0x815DD7C VA: 0x8161D7C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8161EF0 Offset: 0x815DEF0 VA: 0x8161EF0
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x8162114 Offset: 0x815E114 VA: 0x8162114 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x81621C0 Offset: 0x815E1C0 VA: 0x81621C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8162218 Offset: 0x815E218 VA: 0x8162218 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8162318 Offset: 0x815E318 VA: 0x8162318 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x81623EC Offset: 0x815E3EC VA: 0x81623EC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x81624C0 Offset: 0x815E4C0 VA: 0x81624C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x816254C Offset: 0x815E54C VA: 0x816254C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x81625E4 Offset: 0x815E5E4 VA: 0x81625E4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x816262C Offset: 0x815E62C VA: 0x816262C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x816272C Offset: 0x815E72C VA: 0x816272C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x81627F0 Offset: 0x815E7F0 VA: 0x81627F0
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 19289
{
	// Fields
	private static readonly ushort s_defaultValue; // 0x0
	private ushort[] _values; // 0x50

	// Methods

	// RVA: 0x8162868 Offset: 0x815E868 VA: 0x8162868
	public void .ctor(DataColumn column) { }

	// RVA: 0x8162980 Offset: 0x815E980 VA: 0x8162980 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x81631DC Offset: 0x815F1DC VA: 0x81631DC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8163298 Offset: 0x815F298 VA: 0x8163298 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x81633B4 Offset: 0x815F3B4 VA: 0x81633B4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x81634FC Offset: 0x815F4FC VA: 0x81634FC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8163554 Offset: 0x815F554 VA: 0x8163554 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8163624 Offset: 0x815F624 VA: 0x8163624 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x81637BC Offset: 0x815F7BC VA: 0x81637BC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8163890 Offset: 0x815F890 VA: 0x8163890 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x816391C Offset: 0x815F91C VA: 0x816391C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x81639B4 Offset: 0x815F9B4 VA: 0x81639B4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x81639FC Offset: 0x815F9FC VA: 0x81639FC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8163AFC Offset: 0x815FAFC VA: 0x8163AFC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 19290
{
	// Fields
	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50

	// Methods

	// RVA: 0x8163BC0 Offset: 0x815FBC0 VA: 0x8163BC0
	public void .ctor(DataColumn column) { }

	// RVA: 0x8163CD8 Offset: 0x815FCD8 VA: 0x8163CD8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x8164538 Offset: 0x8160538 VA: 0x8164538 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8164604 Offset: 0x8160604 VA: 0x8164604 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8164720 Offset: 0x8160720 VA: 0x8164720 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8164868 Offset: 0x8160868 VA: 0x8164868 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x81648C0 Offset: 0x81608C0 VA: 0x81648C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8164990 Offset: 0x8160990 VA: 0x8164990 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8164B28 Offset: 0x8160B28 VA: 0x8164B28 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8164BFC Offset: 0x8160BFC VA: 0x8164BFC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x8164C88 Offset: 0x8160C88 VA: 0x8164C88 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x8164D20 Offset: 0x8160D20 VA: 0x8164D20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x8164D68 Offset: 0x8160D68 VA: 0x8164D68 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x8164E68 Offset: 0x8160E68 VA: 0x8164E68 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 19291
{
	// Fields
	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50

	// Methods

	// RVA: 0x8164F2C Offset: 0x8160F2C VA: 0x8164F2C
	public void .ctor(DataColumn column) { }

	// RVA: 0x8165044 Offset: 0x8161044 VA: 0x8165044 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x8165890 Offset: 0x8161890 VA: 0x8165890 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x8165998 Offset: 0x8161998 VA: 0x8165998 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x8165AB4 Offset: 0x8161AB4 VA: 0x8165AB4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x8165BFC Offset: 0x8161BFC VA: 0x8165BFC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x8165C54 Offset: 0x8161C54 VA: 0x8165C54 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x8165D24 Offset: 0x8161D24 VA: 0x8165D24 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x8165EBC Offset: 0x8161EBC VA: 0x8165EBC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x8165F90 Offset: 0x8161F90 VA: 0x8165F90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x816601C Offset: 0x816201C VA: 0x816601C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x81660B4 Offset: 0x81620B4 VA: 0x81660B4 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x81660FC Offset: 0x81620FC VA: 0x81660FC Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x81661FC Offset: 0x81621FC VA: 0x81661FC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 19292
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 // TypeDefIndex: 19293
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 19294
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 19295
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 // TypeDefIndex: 19296
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 // TypeDefIndex: 19297
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 19298
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 39A47A6A540EB845B37C85CE8C346359A0DB937D4AAF7A74A6C207205E0BC61E /*Metadata offset 0xEFCF08*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D /*Metadata offset 0xEFCFA8*/; // 0x98
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA /*Metadata offset 0xEFCFD0*/; // 0xBE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD /*Metadata offset 0xEFD008*/; // 0xF2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 BA1E68F004F9EFDE72987E33682A8A5C579C4A609FBECE4F6EDBB844431D9226 /*Metadata offset 0xEFD030*/; // 0x116
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 C44E90B8C219817ECD3C403823D4770C0F744358EBF32A4282B3CE0338D4602E /*Metadata offset 0xEFD0D0*/; // 0x1AE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 D44900CF81FC3D53E7F8D2FCB6EF3B50B39ED1A857628FA737F5B4B7E0382939 /*Metadata offset 0xEFD170*/; // 0x246
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 E29424929B12EB1FDF4FD2E4911E09644CB58261C6033211F88022DDED785AE6 /*Metadata offset 0xEFD210*/; // 0x2DE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 F327BBE8D18E0318C5295B25F9A8BA9B3AFE1F44C3C244BB3921AFEB578F1591 /*Metadata offset 0xEFD2C8*/; // 0x38E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315 /*Metadata offset 0xEFD310*/; // 0x3CE
}

